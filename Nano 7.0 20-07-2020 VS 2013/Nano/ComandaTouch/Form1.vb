Imports System.Drawing
Imports System.Security.Permissions
Imports Nano.clsFuncoes
' size form = 699; 259
Public Class Form1

    Private Const WS_EX_TOPMOST As Integer = &H8
    Private Const WS_EX_NOACTIVATE As Long = &H8000000L
    Private Const WM_NCMOUSEMOVE As Integer = &HA0
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private previousForegroundWindow As IntPtr = IntPtr.Zero

    ''' <summary>
    ''' La forma del conjunto de estilo:  WS_EX_NOACTIVATE ，Así que no va a ser el foco.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")> _
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or (CInt(WS_EX_NOACTIVATE) Or CInt(WS_EX_TOPMOST))
            Return cp
        End Get
    End Property

    ''' <summary>
    ''' Procesamiento de mensajes de ventana.
    ''' 
    ''' Cuando el cursor se encuentra en una zona de no-usuarios de la ventana,
    ''' el usuario presiona el botón izquierdo del ratón, y que evitará el mango actual ventana de primer plano y,
    ''' a continuación, activar usted mismo.
    ''' 
    ''' Cuando el cursor se encuentra en la zona de no-usuarios de la ventana se mueve,
    ''' por lo que significa en el botón izquierdo del ratón ha sido puesto en libertad,
    ''' esta ventana se activará la ventana en primer plano anterior.
    ''' </summary>
    ''' <param name="m"></param>
    ''' <remarks></remarks>
    <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")> _
    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case WM_NCLBUTTONDOWN
                ' Obtén la ventana actual en primer plano.
                Dim foregroundWindow As IntPtr = UnsafeNativeMethods.GetForegroundWindow()
                ' Si la ventana no es la ventana actual en primer plano, y luego activarlo usted mismo.
                If foregroundWindow <> Me.Handle Then
                    UnsafeNativeMethods.SetForegroundWindow(Me.Handle)
                    ' Anteriormente salvado ventana en primer plano mango.
                    If foregroundWindow <> IntPtr.Zero Then
                        previousForegroundWindow = foregroundWindow
                    End If
                End If
            Case WM_NCMOUSEMOVE
                ' Determinar si hay una ventana anterior. Si existe, entonces activarlo.
                ' Nota: este es el caso, la ventana anterior está cerrada,
                ' pero el mismo mango asignado a una nueva ventana.
                If UnsafeNativeMethods.IsWindow(previousForegroundWindow) Then
                    UnsafeNativeMethods.SetForegroundWindow(previousForegroundWindow)
                    previousForegroundWindow = IntPtr.Zero
                End If
        End Select

        MyBase.WndProc(m)
    End Sub

    Private isAlt As Boolean = False
    Private isCtrl As Boolean = False
    Private isShift As Boolean = False
    Private isChangedButtons As Boolean = False
    Private isChangedButtonsSpecials As Boolean = False

    Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Enable double duffering to stop flickering.
		Me.SetStyle(ControlStyles.DoubleBuffer, True)
		Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
		Me.SetStyle(ControlStyles.UserPaint, True)
		Me.SetStyle(ControlStyles.SupportsTransparentBackColor, False)
		Me.SetStyle(ControlStyles.Opaque, False)
		Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
		Me.SetStyle(ControlStyles.ResizeRedraw, True)

		' Inicializa los numeros y las letras
		btNumberAndLetterInit()

		' Inicializa los botones shift.
		bt_shiftRL()

		' Inicializa los botones ctrl.
		bt_ctrlRL()

		' Inicializa los botones alt.
		bt_altRL()
	End Sub

	''' <summary>
	''' Inicializa los botones del abecedario y nos numeros.
	''' </summary>
	''' <remarks></remarks>
	Private Sub btNumberAndLetterInit()
		' Number
		AddHandler bt_0.Click, AddressOf bt_Assing
		AddHandler bt_1.Click, AddressOf bt_Assing
		AddHandler bt_2.Click, AddressOf bt_Assing
		AddHandler bt_3.Click, AddressOf bt_Assing
		AddHandler bt_4.Click, AddressOf bt_Assing
		AddHandler bt_5.Click, AddressOf bt_Assing
		AddHandler bt_6.Click, AddressOf bt_Assing
		AddHandler bt_7.Click, AddressOf bt_Assing
		AddHandler bt_8.Click, AddressOf bt_Assing
		AddHandler bt_9.Click, AddressOf bt_Assing

		'	// Letters
		AddHandler bt_q.Click, AddressOf bt_Assing
		AddHandler bt_w.Click, AddressOf bt_Assing
		AddHandler bt_e.Click, AddressOf bt_Assing
		AddHandler bt_r.Click, AddressOf bt_Assing
		AddHandler bt_t.Click, AddressOf bt_Assing
		AddHandler bt_y.Click, AddressOf bt_Assing
		AddHandler bt_u.Click, AddressOf bt_Assing
		AddHandler bt_i.Click, AddressOf bt_Assing
		AddHandler bt_o.Click, AddressOf bt_Assing
		AddHandler bt_a.Click, AddressOf bt_Assing
		AddHandler bt_s.Click, AddressOf bt_Assing
		AddHandler bt_d.Click, AddressOf bt_Assing
		AddHandler bt_f.Click, AddressOf bt_Assing
		AddHandler bt_g.Click, AddressOf bt_Assing
		AddHandler bt_h.Click, AddressOf bt_Assing
		AddHandler bt_j.Click, AddressOf bt_Assing
		AddHandler bt_k.Click, AddressOf bt_Assing
		AddHandler bt_l.Click, AddressOf bt_Assing
		AddHandler bt_z.Click, AddressOf bt_Assing
		AddHandler bt_x.Click, AddressOf bt_Assing
		AddHandler bt_c.Click, AddressOf bt_Assing
		AddHandler bt_v.Click, AddressOf bt_Assing
		AddHandler bt_b.Click, AddressOf bt_Assing
		AddHandler bt_n.Click, AddressOf bt_Assing
        AddHandler bt_m.Click, AddressOf bt_Assing
        AddHandler bt_p.Click, AddressOf bt_Assing
	End Sub

	Private Sub bt_Assing(ByVal sender As Object, ByVal e As EventArgs)

		Dim bt As Button = TryCast(sender, Button)
        sendCommand(bt.Text.ToUpper())

	End Sub

	''' <summary>
	''' Inicializa los botones Shift L y R.
	''' </summary>
	''' <remarks></remarks>
	Private Sub bt_shiftRL()
		AddHandler bt_shiftL.Click, AddressOf bt_shiftAssing
		AddHandler bt_shiftR.Click, AddressOf bt_shiftAssing
	End Sub

	Private Sub bt_shiftAssing(ByVal sender As Object, ByVal e As EventArgs)
		' isShift = isShift == true ? false : true;
		If isShift Then
			isShift = False
		Else
			isShift = True
		End If

		If isShift Then
			bt_shiftL.BackColor = Color.Brown
			bt_shiftR.BackColor = Color.Brown
		Else
			bt_shiftL.BackColor = Me.BackColor
			bt_shiftR.BackColor = Me.BackColor
		End If
	End Sub

	''' <summary>
	''' Inicializa los botones Ctrl L y R.
	''' </summary>
	''' <remarks></remarks>
	Private Sub bt_ctrlRL()
		AddHandler bt_ctrlL.Click, AddressOf bt_ctrlAssing
		AddHandler bt_ctrlL.Click, AddressOf bt_ctrlAssing
	End Sub

	Private Sub bt_ctrlAssing(ByVal sender As Object, ByVal e As EventArgs)
		' isCtrl = isCtrl == true ? false : true;
		If isCtrl Then
			isCtrl = False
		Else
			isCtrl = True
		End If

		If isCtrl Then
			bt_ctrlL.BackColor = Color.Brown
			bt_ctrlR.BackColor = Color.Brown
		Else
			bt_ctrlL.BackColor = Me.BackColor
			bt_ctrlR.BackColor = Me.BackColor
		End If
	End Sub

	''' <summary>
	''' Inicializa los botones Alt L y R.
	''' </summary>
	''' <remarks></remarks>
	Private Sub bt_altRL()
		AddHandler bt_altL.Click, AddressOf bt_altAssing
		AddHandler bt_altR.Click, AddressOf bt_altAssing
	End Sub

	Private Sub bt_altAssing(ByVal sender As Object, ByVal e As EventArgs)
		' isAlt = isAlt == true ? false : true;
		If isAlt Then
			isAlt = False
		Else
			isAlt = True
		End If

		If isAlt Then
			bt_altL.BackColor = Color.Brown
			bt_altR.BackColor = Color.Brown
		Else
			bt_altL.BackColor = Me.BackColor
			bt_altR.BackColor = Me.BackColor
		End If
	End Sub

	''' <summary>
	''' Envia un commando con las opciones indicadas.
	''' </summary>
	''' <param name="command"></param>
	''' <remarks></remarks>
	Private Sub sendCommand(ByVal command As String)
		If command.Equals("&&") Then
			command = "&"
		End If
		If command.Equals("(") Then
			command = "{(}"
		End If
		If command.Equals(")") Then
			command = "{)}"
		End If

		'if (isShift && isCtrl && !isAlt)
		If isShift And isCtrl And Not (isAlt) Then
			SendKeys.Send("+" + "^" + command)

			Me.isShift = False
			bt_shiftL.BackColor = Me.BackColor
			bt_shiftR.BackColor = Me.BackColor

			Me.isCtrl = False
			bt_ctrlL.BackColor = Me.BackColor
			bt_ctrlR.BackColor = Me.BackColor

		ElseIf isCtrl And isAlt And Not (isShift) Then
			SendKeys.Send("^" + "%" + command)

			Me.isCtrl = False
			bt_ctrlL.BackColor = Me.BackColor
			bt_ctrlR.BackColor = Me.BackColor

			Me.isAlt = False
			bt_altL.BackColor = Me.BackColor
			bt_altR.BackColor = Me.BackColor

		ElseIf isShift And isCtrl And isAlt Then
			SendKeys.Send("+" + "^" + "%" + command)

			Me.isShift = False
			bt_shiftL.BackColor = Me.BackColor
			bt_shiftR.BackColor = Me.BackColor

			Me.isCtrl = False
			bt_ctrlL.BackColor = Me.BackColor
			bt_ctrlR.BackColor = Me.BackColor

			Me.isAlt = False
			bt_altL.BackColor = Me.BackColor
			bt_altR.BackColor = Me.BackColor

		ElseIf (isShift) Then
			SendKeys.Send("+" + command)
			Me.isShift = False
			bt_shiftL.BackColor = Me.BackColor
			bt_shiftR.BackColor = Me.BackColor

		ElseIf (isCtrl) Then
			SendKeys.Send("^" + command)
			Me.isCtrl = False
			bt_ctrlL.BackColor = Me.BackColor
			bt_ctrlR.BackColor = Me.BackColor

		ElseIf (isAlt) Then
			SendKeys.Send("%" + command)
			Me.isAlt = False
			bt_altL.BackColor = Me.BackColor
			bt_altR.BackColor = Me.BackColor

        Else
            Try
                SendKeys.Send(command)
            Catch ex As Exception

            End Try
        End If
	End Sub

	Private Sub bt_esc_Click(sender As Object, e As EventArgs) Handles bt_esc.Click
		sendCommand("{ESC}")
	End Sub

	Private Sub bt_c0_Click(sender As Object, e As EventArgs) Handles bt_c0.Click
		sendCommand("`")
	End Sub

	Private Sub bt_minor_Click(sender As Object, e As EventArgs) Handles bt_minor.Click
		sendCommand("-")
	End Sub

	Private Sub bt_equal_Click(sender As Object, e As EventArgs) Handles bt_equal.Click
		sendCommand("=")
	End Sub

	Private Sub bt_backspace_Click(sender As Object, e As EventArgs) Handles bt_backspace.Click
		sendCommand("{BACKSPACE}")
	End Sub

	Private Sub bt_tab_Click(sender As Object, e As EventArgs) Handles bt_tab.Click
		sendCommand("{TAB}")
	End Sub

	Private Sub bt_corcheteL_Click(sender As Object, e As EventArgs) Handles bt_corcheteL.Click
		sendCommand("[")
	End Sub

	Private Sub bt_corcheteR_Click(sender As Object, e As EventArgs) Handles bt_corcheteR.Click
		sendCommand("]")
	End Sub

	Private Sub bt_divideL_Click(sender As Object, e As EventArgs) Handles bt_divideL.Click
		sendCommand("\")
	End Sub

	Private Sub bt_del_Click(sender As Object, e As EventArgs) Handles bt_del.Click
		sendCommand("{DEL}")
	End Sub

	Private Sub bt_caps_Click(sender As Object, e As EventArgs) Handles bt_caps.Click
		' {CAPSLOCK}
		' Win32Api.SetKeyDown(Win32Api.CAPS_KEY);
		Keyboard.SetKeyDown(Keys.CapsLock)
	End Sub

	Private Sub bt_pointComa_Click(sender As Object, e As EventArgs) Handles bt_pointComa.Click
		sendCommand(";")
	End Sub

	Private Sub bt_singleComilla_Click(sender As Object, e As EventArgs) Handles bt_singleComilla.Click
		sendCommand("'")
	End Sub

	Private Sub bt_enter_Click(sender As Object, e As EventArgs) Handles bt_enter.Click
        'sendCommand("{ENTER}")
        sendCommand("~")
	End Sub

	Private Sub bt_coma_Click(sender As Object, e As EventArgs) Handles bt_coma.Click
		sendCommand(",")
	End Sub

	Private Sub bt_point_Click(sender As Object, e As EventArgs) Handles bt_point.Click
		sendCommand(".")
	End Sub

	Private Sub bt_divideR_Click(sender As Object, e As EventArgs) Handles bt_divideR.Click
		sendCommand("/")
	End Sub

	Private Sub bt_up_Click(sender As Object, e As EventArgs) Handles bt_up.Click
		sendCommand("{UP}")
	End Sub

	Private Sub bt_left_Click(sender As Object, e As EventArgs) Handles bt_left.Click
		sendCommand("{LEFT}")
	End Sub

	Private Sub bt_down_Click(sender As Object, e As EventArgs) Handles bt_down.Click
		sendCommand("{DOWN}")
	End Sub

	Private Sub bt_right_Click(sender As Object, e As EventArgs) Handles bt_right.Click
		sendCommand("{RIGHT}")
	End Sub

	Private Sub bt_win_Click(sender As Object, e As EventArgs) Handles bt_win.Click
		isCtrl = True
		sendCommand("{ESC}")
	End Sub

	Private Sub bt_space_Click(sender As Object, e As EventArgs) Handles bt_space.Click
		sendCommand(" ")
	End Sub

	''' <summary>
	''' Control Buttons Keys
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		IsKeyDownShift()
        'IsKeyToggledCapsLock()
	End Sub

	''' <summary>
	''' Check Active CapsLock
	''' </summary>
	''' <remarks></remarks>
	Private Sub IsKeyToggledCapsLock()
		Dim isCaps As Boolean = Keyboard.IsKeyToggled(Keys.CapsLock)

		If isCaps = True Then
			bt_caps.BackColor = Color.Brown
		Else
			bt_caps.BackColor = Me.BackColor
		End If

		If isCaps And Not (isChangedButtons) Then
			updateButtons(isCaps, True)
		End If
		If Not (isCaps) And isChangedButtons Then
			updateButtons(isCaps, False)
		End If
	End Sub

	''' <summary>
	''' Update Buttons Letter.
	''' </summary>
	''' <param name="isCaps"></param>
	''' <param name="isStop"></param>
	''' <remarks></remarks>
	Private Sub updateButtons(ByVal isCaps As Boolean, ByVal isStop As Boolean)
		Dim i As Integer = 0
        'For i = 0 To Me.Controls.Count - 1
        Dim bt As Button = TryCast(Me.Controls(i), Button)
        '	If isCaps Then
        '		If bt.Text.Length > 0 Then
        '			If Char.IsLetter(bt.Text(0)) And bt.Text.Length = 1 Then
        bt.Text = bt.Text.ToUpper()
        '			End If
        '		End If
        '	Else
        '		If bt.Text.Length > 0 Then
        '			If Char.IsLetter(bt.Text(0)) And bt.Text.Length = 1 Then
        '				bt.Text = bt.Text.ToLower()
        '			End If
        '		End If
        '	End If
        'Next
		Me.isChangedButtons = isStop
	End Sub

	''' <summary>
	''' Check key down shift
	''' </summary>
	''' <remarks></remarks>
	Private Sub IsKeyDownShift()
		Dim isDownShift As Boolean = Keyboard.IsKeyDown(Keys.ShiftKey)
		If isDownShift Or isShift Then
			bt_shiftL.BackColor = Color.Brown
			bt_shiftR.BackColor = Color.Brown

			Me.isShift = Not (isDownShift)
		Else
			bt_shiftL.BackColor = Me.BackColor
			bt_shiftR.BackColor = Me.BackColor

			Me.isShift = False
		End If

		If isDownShift Then
			If isDownShift And Not (isChangedButtonsSpecials) Then
				updateButtonsSpecial(isDownShift, True)
			End If
			If Not (isDownShift) And isChangedButtonsSpecials Then
				updateButtonsSpecial(isDownShift, False)
			End If
		Else
			If isShift And Not (isChangedButtonsSpecials) Then
				updateButtonsSpecial(isShift, True)
			End If
			If Not (isShift) And isChangedButtonsSpecials Then
				updateButtonsSpecial(isShift, False)
			End If
		End If
	End Sub

	''' <summary>
	''' Update Buttons Special.
	''' </summary>
	''' <param name="isPressed"></param>
	''' <param name="isStop"></param>
	''' <remarks></remarks>
	Private Sub updateButtonsSpecial(ByVal isPressed As Boolean, ByVal isStop As Boolean)
        'Me.updateButtons(isPressed, Not (isStop))
		If Not (isStop) Then
			bt_c0.Text = "`"
			bt_1.Text = "1"
			bt_2.Text = "2"
			bt_3.Text = "3"
			bt_4.Text = "4"
			bt_5.Text = "5"
			bt_6.Text = "6"
			bt_7.Text = "7"
			bt_8.Text = "8"
			bt_9.Text = "9"
			bt_0.Text = "0"
			bt_minor.Text = "-"
			bt_equal.Text = "="
			bt_corcheteL.Text = "["
			bt_corcheteR.Text = "]"
			bt_divideL.Text = "\"
			bt_pointComa.Text = ";"
			bt_singleComilla.Text = "'"
			bt_coma.Text = ","
			bt_point.Text = "."
			bt_divideR.Text = "/"
		Else
			bt_c0.Text = "~"
			bt_1.Text = "!"
			bt_2.Text = "@"
			bt_3.Text = "#"
			bt_4.Text = "$"
			bt_5.Text = "%"
			bt_6.Text = "^"
			bt_7.Text = "&&"
			bt_8.Text = "*"
			bt_9.Text = "("
			bt_0.Text = ")"
			bt_minor.Text = "_"
			bt_equal.Text = "+"
			bt_corcheteL.Text = "{"
			bt_corcheteR.Text = "}"
			bt_divideL.Text = "|"
			bt_pointComa.Text = ":"
			bt_singleComilla.Text = """"
			bt_coma.Text = "<"
			bt_point.Text = ">"
			bt_divideR.Text = "?"
		End If

		Me.isChangedButtonsSpecials = isStop
	End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FormAberto = "frmAbrirComanda" Then
            Me.Button1.Visible = False
        End If
        Control.CheckForIllegalCrossThreadCalls = False
        Me.PictureEdit1.BackColor = CorTeclado
        Me.PictureEdit2.BackColor = CorTeclado
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FormAberto = "frmCadCliente" Then
            Me.Close()
            Exit Sub
        End If
        sendCommand("{ENTER}")
    End Sub


End Class
