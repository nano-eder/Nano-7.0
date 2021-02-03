Imports System.Runtime.InteropServices

Public MustInherit Class Keyboard

	<Flags> _
	Private Enum KeyStates
		None = 0
		Down = 1
		Toggled = 2
	End Enum

	<DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
	Private Shared Function GetKeyState(ByVal keycode As Integer) As Short
	End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
 Public Shared Function SetForegroundWindow(ByVal hwng As Integer) As Integer
    End Function

    Private Shared Function GetkeyState(ByVal key As Keys) As KeyStates
        Dim state = KeyStates.None

        Dim retVal As Short = GetkeyState(CInt(key))

        If (retVal And &H8000) = &H8000 Then
            state = state Or KeyStates.Down
        End If

        If (retVal And 1) = 1 Then
            state = state Or KeyStates.Toggled
        End If

        Return state
    End Function

    Public Shared Function IsKeyDown(ByVal key As Keys) As Boolean
        Return KeyStates.Down = (GetKeyState(key) And KeyStates.Down)
    End Function

    Public Shared Function IsKeyToggled(ByVal key As Keys) As Boolean
        Return KeyStates.Toggled = (GetKeyState(key) And KeyStates.Toggled)
    End Function

    <DllImport("user32.dll")> _
    Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UIntPtr)
    End Sub

    Public Shared Sub SetKeyDown(ByVal keys As Keys)
        Const KEYEVENTF_EXTENDEDKEY As Integer = &H1
        Const KEYEVENTF_KEYUP As Integer = &H2

        'keybd_event((byte)keys, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        'keybd_event((byte)keys, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);

        keybd_event(CByte(keys), &H45, KEYEVENTF_EXTENDEDKEY, 0)
        keybd_event(CByte(keys), &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    End Sub

End Class
