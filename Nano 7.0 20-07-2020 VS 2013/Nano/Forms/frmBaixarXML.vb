Imports System
Imports System.Net
Imports System.IO

Public Class frmBaixarXML

    Dim bolCapcha As Boolean = False
    Dim bolPassou As Boolean = False
    Dim bolOk As Boolean = False
    Dim strTextoHtml As String = ""
    Dim intCount As Integer

    Private Const BrowserKeyPath As String = "\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"

    Private Sub CreateBrowserKey(Optional ByVal IgnoreIDocDirective As Boolean = False)
        Dim basekey As String = Microsoft.Win32.Registry.CurrentUser.ToString
        Dim value As Int32
        Dim thisAppsName As String = My.Application.Info.AssemblyName & ".exe"

        Select Case (New WebBrowser).Version.Major
            Case 8
                If IgnoreIDocDirective Then
                    value = 8888
                Else
                    value = 8000
                End If
            Case 9
                If IgnoreIDocDirective Then
                    value = 9999
                Else
                    value = 9000
                End If
            Case 10
                If IgnoreIDocDirective Then
                    value = 10001
                Else
                    value = 10000
                End If

            Case 11
                If IgnoreIDocDirective Then
                    value = 11001
                Else
                    value = 11000
                End If
            Case Else
                Exit Sub
        End Select
        Microsoft.Win32.Registry.SetValue(Microsoft.Win32.Registry.CurrentUser.ToString & BrowserKeyPath, Process.GetCurrentProcess.ProcessName & ".exe", value, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub

    Private Sub RemoveBrowerKey()
        Dim key As Microsoft.Win32.RegistryKey
        key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(BrowserKeyPath.Substring(1), True)
        key.DeleteValue(Process.GetCurrentProcess.ProcessName & ".exe", False)
    End Sub

    Private Sub frmBaixarXML_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RemoveBrowerKey()
    End Sub

    Private Function CarregarCaptcha(ByVal parCaptcha As String) As Boolean
        Try
            Dim web As WebClient = New WebClient()
            web.Headers(HttpRequestHeader.UserAgent) = "User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36"
            Dim imageBytes As Byte() = web.DownloadData(parCaptcha)

            Dim memorybits As New MemoryStream(imageBytes)
            Dim bitmap As New Bitmap(memorybits)

            Me.picCaptcha.Image = bitmap
            Timer1.Stop()
            Return True
        Catch ex As Exception
            CarregarPagina()
            Return False
        End Try
    End Function

    Private Sub frmBaixarXML_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            CarregarCaptcha(Me.WebBrowser1.Document.GetElementById("imgcaptcha").GetAttribute("src").ToString.Trim)
        End If
    End Sub

    Private Sub frmBaixarXML_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateBrowserKey()
        CarregarPagina()
        CriarPasta()
    End Sub

    Private Sub CarregarPagina()
        Try
            My.Computer.Registry.CurrentUser.CreateSubKey("REG_DWORD")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\Main\" & _
            "FeatureControl\FEATURE_BROWSER_EMULATION", "Nano.exe", "11001", Microsoft.Win32.RegistryValueKind.DWord)

            My.Computer.Registry.CurrentUser.CreateSubKey("REG_DWORD")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\Main\" & _
            "FeatureControl\FEATURE_BROWSER_EMULATION", "Nano.vshost.exe", "10001", Microsoft.Win32.RegistryValueKind.DWord)
        Catch ex As Exception
        End Try

        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Navigate("https://www.fsist.com.br/", "_top", Nothing, "User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36")

        Timer1.Start()
        bolCapcha = False
        bolPassou = False
        bolOk = False
    End Sub

    Private Sub CriarPasta()
        Dim Caminho As String = "C:\NANOXML"
        If Not IO.Directory.Exists(Caminho) Then
            IO.Directory.CreateDirectory(Caminho)
        End If
        Caminho = "C:\Users\" & Environment.UserName.ToString.Trim() & "\Downloads"
        If Not IO.Directory.Exists(Caminho) Then
            IO.Directory.CreateDirectory(Caminho)
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        CarregarCaptcha(Me.WebBrowser1.Document.GetElementById("imgcaptcha").GetAttribute("src").ToString.Trim)
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If bolPassou = False Then
            If Me.txtChave.Text <> "" And Me.txtCaptcha.Text <> "" Then
                Me.WebBrowser1.Document.GetElementById("chave").SetAttribute("value", Me.txtChave.Text.Trim)
                Me.WebBrowser1.Document.GetElementById("captcha").SetAttribute("value", Me.txtCaptcha.Text.Trim)
                Me.WebBrowser1.Document.GetElementById("butconsulta").InvokeMember("click")

                bolOk = True
                Timer1.Start()
            End If
        Else
            Me.WebBrowser1.Document.GetElementById("linksemcert").InvokeMember("click")
            Me.Timer2.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If bolCapcha = False Then
            Try
                Dim strCaptcha As String = Me.WebBrowser1.Document.GetElementById("imgcaptcha").GetAttribute("src")
                If strCaptcha.Contains("base64") = False Then
                    bolCapcha = CarregarCaptcha(strCaptcha)

                    CarregarCaptcha(strCaptcha)
                    CarregarCaptcha(strCaptcha)
                End If
            Catch ex As Exception
            End Try
        End If

        Try
            strTextoHtml = Me.WebBrowser1.Document.Body.InnerHtml
            If strTextoHtml.Contains("but-destivado") = True And bolOk = True Then
                bolPassou = True
                Me.btnOk.Text = "Baixar"
                Me.btnAlterar.Enabled = False
                Me.txtCaptcha.Enabled = False
                Me.txtCaptcha.BackColor = Color.White
                Me.btnOk.Image = My.Resources.Download_2
                Me.picCaptcha.Image = My.Resources.NFe_Baixar
                Me.LabelControl3.Visible = True

                Me.btnOk.Appearance.BackColor = Color.LimeGreen
                Me.btnOk.Appearance.BackColor2 = Color.LimeGreen
                Me.btnOk.Appearance.BorderColor = Color.LightGreen
                Timer1.Stop()
            End If
        Catch ex As Exception
        End Try

        If bolOk = True Then
            intCount = intCount + 1
            If intCount = 100 Then
                MsgBox("Nota não foi localizada. Verifique a chave ou caracteres digitados!", MsgBoxStyle.Information)
                intCount = 0
                Me.txtCaptcha.ResetText()
                CarregarPagina()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If System.IO.File.Exists("C:\NANOXML\" & Me.txtChave.Text.Trim & ".xml") = True Then
            LocalNFe = "C:\NANOXML\" & Me.txtChave.Text.Trim & ".xml"
            Me.Timer2.Stop()
            Me.Close()
        ElseIf System.IO.File.Exists("C:\Users\" & Environment.UserName.ToString.Trim() & "\Downloads\" & Me.txtChave.Text.Trim & ".xml") = True Then
            LocalNFe = "C:\Users\" & Environment.UserName.ToString.Trim() & "\Downloads\" & Me.txtChave.Text.Trim & ".xml"
            Me.Timer2.Stop()
            Me.Close()
        ElseIf System.IO.File.Exists("C:\Users\" & Environment.UserName.ToString.Trim() & "\Desktop\" & Me.txtChave.Text.Trim & ".xml") = True Then
            LocalNFe = "C:\Users\" & Environment.UserName.ToString.Trim() & "\Desktop\" & Me.txtChave.Text.Trim & ".xml"
            Me.Timer2.Stop()
            Me.Close()
        End If
    End Sub
End Class