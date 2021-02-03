Imports System.Runtime.InteropServices
Imports System.Threading
Public Class frmWebCam
    Dim bolImg As Boolean

    'constantes usadas na DLL
    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0 ' ID do dispositivo atual
    Dim hHwnd As Integer ' manipulador da janela do visualizador

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
    (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
    ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    'A função DestroyWindow destroi a janela especificada.
    'Envia as mensagens WM_DESTROY e WM_NCDESTROY para a
    'janela para destivá-la e remove o foco do teclado da mesma
    'Library - User32
    'Parametros - hWnd - (identica a janela a ser destruida)
    'Retorna um valor diferente de zero se for executada com sucesso, 'caso contrario retorna zero
    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean


    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
    ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Short, ByVal hWndParent As Integer, ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
    ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, ByVal cbVer As Integer) As Boolean






    <DllImport("USER32.DLL")> _
        Private Shared Function GetShellWindow() As IntPtr
    End Function

    <DllImport("USER32.DLL")> _
    Private Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function

    <DllImport("USER32.DLL")> _
    Private Shared Function GetWindowTextLength(ByVal hWnd As IntPtr) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function GetWindowThreadProcessId(ByVal hWnd As IntPtr, <Out()> ByRef lpdwProcessId As UInt32) As UInt32
    End Function

    <DllImport("USER32.DLL")> _
    Private Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As Boolean
    End Function

    Private Delegate Function EnumWindowsProc(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean

    <DllImport("USER32.DLL")> _
    Private Shared Function EnumWindows(ByVal enumFunc As EnumWindowsProc, ByVal lParam As Integer) As Boolean
    End Function

    Private hShellWindow As IntPtr = GetShellWindow()
    Private dictWindows As New Dictionary(Of IntPtr, String)
    Private currentProcessID As Integer
    Private Sub frmWebCam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mThread.Abort()
        fechaJanelaVisualizacao()

    End Sub
    Private Sub frmWebCam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'verifica e carrega os dispositivos
        carregaDispositivos()

        ' se encontrou dispostivos instalados então exibe
        If lstDispositivos.Items.Count > 0 Then

            lstDispositivos.SelectedIndex = 0

        Else
            lstDispositivos.Items.Add("Não dispositivo de captura instalado.")
            'Me.btnWebCam.Enabled = False
        End If

        picCaptura.SizeMode = PictureBoxSizeMode.StretchImage
        bolImg = False
        Timer1.Start()
        'Me.btnWebCam.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    End Sub

    Private Sub carregaDispositivos()
        Dim strNome As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bRetorna As Boolean
        Dim x As Integer = 0

        '' Carrega os dispositivos em lstDevices
        Do

            ' Obtem o nome e a versão Driver
            bRetorna = capGetDriverDescriptionA(x, strNome, 100, strVer, 100)

            ' se existir um dispositivo inclui o nome da lista
            If bRetorna Then lstDispositivos.Items.Add(strNome.Trim)
            x += 1
        Loop Until bRetorna = False
    End Sub
    Dim bolAbriu As Boolean = False
    Private Sub abreJanelaVisualizacao()
        Dim iHeight As Integer = picCaptura.Height
        Dim iWidth As Integer = picCaptura.Width

        ' Abre a janela de visualização no picturebox
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
        480, picCaptura.Handle.ToInt32, 0)

        ' Conecta com o drive
        Try
            If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
                '
                'Define a escala de previsão
                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

                'Define a taxa de visualização em milisegundos
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

                'Iniciar a visualização da imagem a partir da camara
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

                ' Redimensiona a janela para se ajustar no picturebox
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picCaptura.Width, picCaptura.Height, SWP_NOMOVE Or SWP_NOZORDER)

                bolImg = True
            Else
                '
                ' Erro de conexão fecha a janela de dispostivos

                DestroyWindow(hHwnd)


                bolImg = False
            End If
        Catch ex As Exception

            bolImg = False
            Timer1.Stop()
            fechaJanelaVisualizacao()
            MsgBox("Ocorreu um erro ao acessar o drive da webcam." & vbCrLf & "Abra a tela novamente.", MsgBoxStyle.Information)

            Me.Close()
        End Try
        bolAbriu = True
     
    End Sub

    Private Sub fechaJanelaVisualizacao()
        ' Desconecta do dispositivo
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

        ' fecha a chama a janela
        DestroyWindow(hHwnd)
    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        Dim dados As IDataObject
        Dim bmap As Image

        ' Copia a imagem para o clipboard
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Obtem a imagem do clipboard e converte para bitmap
        dados = Clipboard.GetDataObject()

        If dados.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)
            picCaptura.Image = bmap
            fechaJanelaVisualizacao()
            If Me.Tag = "ANIMAL" Then
                frmCadAnimal.picFoto.Image = bmap
            ElseIf Me.Tag = "PRODUTO1" Then
                frmCadProduto.picImagem3.Image = bmap
            ElseIf Me.Tag = "PRODUTO2" Then
                frmCadProduto.picImagem4.Image = bmap
            Else
                frmCadCliente.picImagem.Image = bmap
            End If


            Me.Close()

        End If
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub
    Dim intaa As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If intaa = 0 Then
            intaa += 1
            IniciaThread()
        End If
        Dim proc As Process
        For Each proc In Process.GetProcesses
            If proc.ProcessName = "MyCam" Then
                Try
                    proc.Kill()
                    proc.Close()
                Catch ex As Exception

                End Try
            End If
        Next

        If bolImg = False Then
            iDevice = lstDispositivos.SelectedIndex
            abreJanelaVisualizacao()
        Else

            Me.Timer1.Stop()
        End If

    End Sub
    Private mThread As Thread
    Public Sub IniciaThread()
        mThread = New Threading.Thread(AddressOf procurar)
        mThread.Start()
    End Sub
    Private Sub procurar()
        Dim bolff As Boolean = False
        While bolff = False
            Dim bolTelaVideo As Boolean = False
            For Each P As Process In Process.GetProcesses
                If P.ProcessName = "Nano" Then

                    Dim windows As IDictionary(Of IntPtr, String) = GetOpenWindowsFromPID(P.Id)

                    For Each kvp As KeyValuePair(Of IntPtr, String) In windows
                        'MessageBox.Show(kvp.Value)
                        If kvp.Value = "Fonte de vídeo" Then

                            bolTelaVideo = True
                        End If

                    Next

                End If
            Next
            If bolTelaVideo = True Then
                Me.btnOk.Enabled = False
                Me.btnCancelar.Enabled = False
            Else
                Me.btnOk.Enabled = True
                Me.btnCancelar.Enabled = True
            End If
        End While

       

    End Sub

    Public Function GetOpenWindowsFromPID(ByVal processID As Integer) As IDictionary(Of IntPtr, String)
        dictWindows.Clear()
        currentProcessID = processID
        EnumWindows(AddressOf enumWindowsInternal, 0)
        Return dictWindows
    End Function

    Private Function enumWindowsInternal(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
        If (hWnd <> hShellWindow) Then
            Dim windowPid As UInt32
            If Not IsWindowVisible(hWnd) Then
                Return True
            End If
            Dim length As Integer = GetWindowTextLength(hWnd)
            If (length = 0) Then
                Return True
            End If
            GetWindowThreadProcessId(hWnd, windowPid)
            If (windowPid <> currentProcessID) Then
                Return True
            End If
            Dim stringBuilder As New System.Text.StringBuilder(length)
            GetWindowText(hWnd, stringBuilder, (length + 1))
            dictWindows.Add(hWnd, stringBuilder.ToString)
        End If
        Return True
    End Function

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub
End Class