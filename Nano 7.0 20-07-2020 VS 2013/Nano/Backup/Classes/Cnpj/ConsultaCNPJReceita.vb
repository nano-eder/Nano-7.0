Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Namespace ConsultaCNPJ
    Public Class ConsultaCNPJReceita
        Private ReadOnly _cookies As New CookieContainer()

        Private urlBaseReceitaFederal As [String] = "http://www.receita.fazenda.gov.br/pessoajuridica/cnpj/cnpjreva/"
        Private paginaValidacao As [String] = "valida.asp"
        Private paginaPrincipal As [String] = "cnpjreva_solicitacao2.asp"
        Private paginaCaptcha As [String] = "captcha/gerarCaptcha.asp"
  
        Public Function GetCaptcha() As Bitmap
            Dim htmlResult As [String]
            Using wc = New CookieAwareWebClient()
                wc.SetCookieContainer(_cookies)
                wc.Headers(HttpRequestHeader.UserAgent) = "Mozilla/4.0 (compatible; Synapse)"
                wc.Headers(HttpRequestHeader.KeepAlive) = "300"
                htmlResult = wc.DownloadString(urlBaseReceitaFederal + paginaPrincipal)

            End Using
            If htmlResult.Length > 0 Then
                Dim wc2 = New CookieAwareWebClient()
                wc2.SetCookieContainer(_cookies)
                wc2.Headers(HttpRequestHeader.UserAgent) = "Mozilla/4.0 (compatible; Synapse)"
                wc2.Headers(HttpRequestHeader.KeepAlive) = "300"
                Dim data As Byte() = wc2.DownloadData(urlBaseReceitaFederal + paginaCaptcha)
                Return New Bitmap(New MemoryStream(data))
            End If
            Return Nothing
        End Function

        Public Function Consulta(ByVal aCNPJ As String, ByVal aCaptcha As String) As [String]
            Dim request = DirectCast(WebRequest.Create(urlBaseReceitaFederal + paginaValidacao), HttpWebRequest)
            request.ProtocolVersion = HttpVersion.Version10
            request.CookieContainer = _cookies
            request.Method = "POST"

            Dim postData As String = ""
            postData = postData & Convert.ToString("origem=comprovante&")
            postData = (postData & Convert.ToString("cnpj=")) + New Regex("[^\d]").Replace(aCNPJ, String.Empty) + "&"
            postData = (Convert.ToString(postData & Convert.ToString("txtTexto_captcha_serpro_gov_br=")) & aCaptcha) + "&"
            postData = postData & Convert.ToString("submit1=Consultar&")
            postData = postData & Convert.ToString("search_type=cnpj")

            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length

            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()

            Dim response As WebResponse = request.GetResponse()
            Dim stHtml As New StreamReader(response.GetResponseStream(), Encoding.GetEncoding("ISO-8859-1"))
            Dim retorno As [String] = stHtml.ReadToEnd()

            If retorno.Contains("Verifique se o mesmo foi digitado corretamente") Then
                Throw New System.InvalidOperationException("O número do CNPJ não foi digitado corretamente")
            End If
            If retorno.Contains("Erro na Consulta") Then
                Throw New System.InvalidOperationException("Os caracteres digitados não correspondem com a imagem")
            End If
            Return retorno
        End Function

        Private Function StringEntreString(ByVal Str As String, ByVal StrInicio As String, ByVal StrFinal As String) As String

            Dim Ini As Integer
            Dim Fim As Integer
            Dim Diff As Integer
            Ini = Str.IndexOf(StrInicio)
            Fim = Str.IndexOf(StrFinal)
            If Ini > 0 Then
                Ini = Ini + StrInicio.Length
            End If
            If Fim > 0 Then
                Fim = Fim + StrFinal.Length
            End If
            Diff = ((Fim - Ini) - StrFinal.Length)
            If (Fim > Ini) AndAlso (Diff > 0) Then
                Return Str.Substring(Ini, Diff)
            Else
                Return ""
            End If
        End Function

        Private Function StringSaltaString(ByVal Str As String, ByVal StrInicio As String) As String

            Dim Ini As Integer
            Ini = Str.IndexOf(StrInicio)
            If Ini > 0 Then
                Ini = Ini + StrInicio.Length
                Return Str.Substring(Ini)
            Else
                Return Str
            End If
        End Function
    End Class

End Namespace

