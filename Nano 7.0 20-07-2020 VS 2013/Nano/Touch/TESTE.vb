Public Class TESTE 
    Dim virtualKeyboard
    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Private Declare Function ShowWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal nCmdShow As Integer) As Integer
    Private Const SW_SHOWNORMAL As Integer = 1
    Private Const SW_SHOWMINIMIZED As Integer = 2

 
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Me.TextEdit1.Text = "" Then
            Dim iHwnd As IntPtr = FindWindow(vbNullString, Me.TextEdit2.Text)
            ShowWindow(iHwnd, SW_SHOWMINIMIZED)
        End If
        If Me.TextEdit2.Text = "" Then
            Dim iHwnd As IntPtr = FindWindow(Me.TextEdit1.Text, vbNullString)
            ShowWindow(iHwnd, SW_SHOWMINIMIZED)
        End If
    End Sub

    Private Sub TESTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'virtualKeyboard = New System.Diagnostics.Process()
        'virtualKeyboard = System.Diagnostics.Process.Start("osk.exe")
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Me.TextEdit1.Text = "" Then
            Dim iHwnd As IntPtr = FindWindow(vbNullString, Me.TextEdit2.Text)
            ShowWindow(iHwnd, SW_SHOWNORMAL)
        End If
        If Me.TextEdit2.Text = "" Then
            Dim iHwnd As IntPtr = FindWindow(Me.TextEdit1.Text, vbNullString)
            ShowWindow(iHwnd, SW_SHOWNORMAL)
        End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        virtualKeyboard = New System.Diagnostics.Process()
        virtualKeyboard = System.Diagnostics.Process.Start(Me.TextEdit2.Text)
    End Sub
End Class