Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Drawing.Printing
Imports Nano.clsFuncoes
Imports System.Globalization
Public Class clsImprimir

    ' Structure and API declarions:
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
     Structure DOCINFOW
        <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
    End Structure

    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="WritePrinter", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EnumJobsW", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EnumJobs(ByVal hPrinter As IntPtr, ByVal FirstJob As Integer, ByVal NoJobs As Integer, ByVal Level As Integer, ByRef pJob As Byte, ByVal cdBuf As Integer, ByRef pcbNeeded As Integer, ByRef pcReturned As Integer) As Integer
    End Function

    ' <DllImport("winspool.Drv", EntryPoint:="EnumJobsA", _
    'SetLastError:=True, CharSet:=CharSet.Auto, _
    'ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    'Public Shared Function EnumJobs(ByVal hPrinter As IntPtr, ByVal FirstJob As Integer, ByVal NoJobs As Integer, ByVal Level As Integer, ByRef pJob As IntPtr, ByVal cdBuf As Integer, ByRef pcbNeeded As Integer, ByRef pcReturned As Integer) As Integer
    ' End Function

    <DllImport("winspool.Drv", EntryPoint:="SetJobW", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SetJob(ByVal hPrinter As IntPtr, ByVal JobId As Integer, ByVal Level As Integer, ByRef pJob As JOB_INFO_1, ByVal cdBuf As Integer) As Integer
    End Function

    <DllImport("winspool.Drv", EntryPoint:="AbortPrinter", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function AbortPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    ' SendBytesToPrinter()
    ' When the function is given a printer name and an unmanaged array of
    ' bytes, the function sends those bytes to the print queue.
    ' Returns True on success or False on failure.
    Public Shared Function CancelarImpressao(ByVal hPrinter As IntPtr, ByVal parJobId As Integer) As Boolean
        Const JOB_CONTROL_CANCEL = &H5
        Dim JobInfo As New JOB_INFO_1
        Dim Result As Long = SetJob(hPrinter, parJobId, 1, JobInfo, JOB_CONTROL_CANCEL)
        'Dim Result As Long = SetJob(hPrinter, 28, 1, JobInfo, JOB_CONTROL_CANCEL)
        Return True
        Dim dtrrr As String = ""
    End Function
    Public Structure SYSTEMTIME
        Public wYear As Short
        Public wMonth As Short
        Public wDayOfWeek As Short
        Public wDay As Short
        Public wHour As Short
        Public wMinute As Short
        Public wSecond As Short
        Public wMilliseconds As Short
    End Structure

    Public Structure JOB_INFO_1
        Dim JobID As Integer
        Dim pPrinterName As String
        Dim pMachineName As String
        Dim pUserName As String
        Dim pDocument As String
        Dim pDatatype As String
        Dim pStatus As String
        Dim Status As Integer
        Dim Priority As Integer
        Dim Position As Integer
        Dim TotalPages As Integer
        Dim PagesPrinted As Integer
        Dim Submitted As SYSTEMTIME
    End Structure
   

    Private Declare Sub CopyMem Lib "kernel32.dll" Alias "RtlMoveMemory" (ByVal pTo As JOB_INFO_1_API, ByVal uFrom As Long, ByVal lSize As Long)
    Private Declare Function lstrlenW Lib "kernel32.dll" (ByVal lpString As Long) As Long
    Private Declare Function HeapAlloc Lib "kernel32.dll" (ByVal hHeap As Long, ByVal dwFlags As Long, ByVal dwBytes As Long) As Long
    Private Declare Function GetProcessHeap Lib "kernel32.dll" () As Long
    Private Declare Function HeapFree Lib "kernel32.dll" (ByVal hHeap As Long, ByVal dwFlags As Long, ByVal lpMem As Long) As Long

    <DllImport("kernel32.dll", EntryPoint:="GetLastError", _
    SetLastError:=True, CharSet:=CharSet.Auto, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetLastError() As Boolean
    End Function
    'privatestructure filled by GetPrinterQueue with all the documents data in the selected printer queue

    Private Structure JOB_INFO_1_API
        Public JobId As Integer
        Public pPrinterName As IntPtr
        Public pMachineName As IntPtr
        Public pUserName As IntPtr
        Public pDocument As IntPtr
        Public pDataType As IntPtr
        Public pStatus As IntPtr
        Public Status As Integer
        Public Priority As Integer
        Public Position As Integer
        Public TotalPages As Integer
        Public PagesPrinter As Integer
        Public Submitted As SYSTEMTIME
    End Structure

    Public Shared Function VerificarImpressao(ByVal hPrinter As IntPtr)
        Dim lNeeded As Long, lReturned As Long
        Dim lJobCount As Long
        Dim intJobId As Integer
        Dim strH As String = hPrinter

        'byteJobsBuffer(0)

        EnumJobs(hPrinter, 0, 20, 1, 0, 0, lNeeded, lReturned)
        If lNeeded > 0 Then
            Dim byteJobsBuffer(lNeeded - 1) As Byte
            EnumJobs(hPrinter, 0, 20, 1, byteJobsBuffer(0), lNeeded, lNeeded, lReturned)
            If lReturned > 0 Then
                Dim I As Integer
                intJobId = byteJobsBuffer(0)
                lJobCount = lReturned
            Else
                lJobCount = 0
            End If
        Else
            lJobCount = 0
        End If
        CancelarImpressao(strH, intJobId)
        'AbortPrinter(hPrinter)
        ClosePrinter(hPrinter)
        MsgBox("Jobs in printer queue: " + CStr(lJobCount), vbInformation)
    End Function
    Public Shared Function VerificarImpressao2(ByVal hPrinter As IntPtr) As Boolean


        Const ERROR_INSUFFICIENT_BUFFER = 122
        Const firstJob As UInteger = 0UI
        Const noJobs As UInteger = 10UI
        Const level As UInteger = 1UI

        Try

            Dim needed As UInteger
            Dim returned As UInteger
            Dim b1 As Boolean = EnumJobs(hPrinter, firstJob, noJobs, level, IntPtr.Zero, 0, needed, returned)

            Dim strH As String = hPrinter

            Debug.Assert(Not b1)
            'Dim lastError As UInteger = GetLastError()
            'Debug.Assert(lastError = ERROR_INSUFFICIENT_BUFFER)
            Dim pJob As IntPtr = Marshal.AllocHGlobal(CInt(needed))
            Dim bytesCopied As UInteger
            Dim structsCopied As UInteger
            'Dim b2 As Boolean = EnumJobs(hPrinter, firstJob, noJobs, level, pJob, needed, needed, returned)
            Dim b2 As Boolean = EnumJobs(hPrinter, firstJob, noJobs, level, pJob, needed, bytesCopied, structsCopied)
            '
            Debug.Assert(b2)
            'Dim jobInfos = New JOB_INFO_1_API(returned - 1) {}
            'Dim sizeOf As Integer = Marshal.SizeOf(GetType(JOB_INFO_1_API))
            'Dim pStruct As IntPtr = pJob

            'For i As Integer = 0 To returned - 1
            '    Dim jobInfo_1W = CType(Marshal.PtrToStructure(pStruct, GetType(JOB_INFO_1_API)), JOB_INFO_1_API)
            '    jobInfos(i) = jobInfo_1W
            '    'pStruct += sizeOf
            'Next
            Dim b3 As Boolean = CancelarImpressao(strH, pJob)
            'ClosePrinter(strH)

            Marshal.FreeHGlobal(pJob)

            Return True
        Catch ex As Exception

        End Try
        
    End Function

    Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
        Dim hPrinter As IntPtr ' The printer handle.
        Dim dwError As Int32 ' Last error - in case there was trouble.
        Dim di As New DOCINFOW ' Describes your document (name, port, data type).
        Dim dwWritten As Int32 ' The number of bytes written by WritePrinter().
        Dim bSuccess As Boolean ' Your success code.

        ' Set up the DOCINFO structure.
        With di
            .pDocName = "Impressão Nano"
            .pDataType = "RAW"
        End With
        ' Assume failure unless you specifically succeed.
        bSuccess = False
        If OpenPrinter(szPrinterName, hPrinter, 0) Then
            If StartDocPrinter(hPrinter, 1, di) Then
                If StartPagePrinter(hPrinter) Then
                    ' Write your printer-specific bytes to the printer.
                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                    EndPagePrinter(hPrinter)




                End If
                EndDocPrinter(hPrinter)
                'VerificarImpressao(hPrinter)
                'VerificarImpressao(hPrinter)
                ' bSuccess = False
            End If
            ClosePrinter(hPrinter)
        End If


        ' If you did not succeed, GetLastError may give more information
        ' about why not.
        If bSuccess = False Then
            dwError = Marshal.GetLastWin32Error()
        End If
        Return bSuccess
    End Function ' SendBytesToPrinter()

    ' SendFileToPrinter()
    ' When the function is given a file name and a printer name,
    ' the function reads the contents of the file and sends the
    ' contents to the printer.
    ' Presumes that the file contains printer-ready data.
    ' Shows how to use the SendBytesToPrinter function.
    ' Returns True on success or False on failure.
    Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
        ' Open the file.
        Dim fs As New FileStream(szFileName, FileMode.Open)
        ' Create a BinaryReader on the file.
        Dim br As New BinaryReader(fs)
        ' Dim an array of bytes large enough to hold the file's contents.
        Dim bytes(fs.Length) As Byte
        Dim bSuccess As Boolean
        ' Your unmanaged pointer.
        Dim pUnmanagedBytes As IntPtr

        ' Read the contents of the file into the array.
        bytes = br.ReadBytes(fs.Length)
        ' Allocate some unmanaged memory for those bytes.
        pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
        ' Copy the managed byte array into the unmanaged array.
        Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
        ' Send the unmanaged bytes to the printer.
        bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
        ' Free the unmanaged memory that you allocated earlier.
        Marshal.FreeCoTaskMem(pUnmanagedBytes)
        Return bSuccess
    End Function ' SendFileToPrinter()

    ' When the function is given a string and a printer name,
    ' the function sends the string to the printer as raw bytes.
    Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String) As Boolean
        Dim pBytes As IntPtr
        Dim dwCount As Int32
        ' How many characters are in the string?
        dwCount = szString.Length()
        ' Assume that the printer is expecting ANSI text, and then convert
        ' the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString)
        ' Send the converted ANSI string to the printer.
        Try
            SendBytesToPrinter(szPrinterName, pBytes, dwCount)
            Marshal.FreeCoTaskMem(pBytes)
        Catch ex As Exception
            MsgBox("Erro na impressão!", MsgBoxStyle.Information)
        End Try
        

        Return True

    End Function

    Public Shared Function Norm(ByVal parString As String) As String
        parString = Chr(27) + "!" + Chr(0) + parString

        Return parString
    End Function


    Public Shared Function Comp(ByVal parString As String) As String
      
        If Impressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) + Chr(15) + parString
        End If

        If Impressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + "!" + Chr(1) + parString
        End If
        If Impressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) + "!" + Chr(1) + parString
        End If


        Return parString
    End Function
    Public Shared Function CompSAT(ByVal parString As String) As String
        If ModeloImpSAT.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) + Chr(15) + parString
        End If

        If ModeloImpSAT.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + "!" + Chr(1) + parString
        End If
        If ModeloImpSAT.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) + "!" + Chr(1) + parString
        End If
        Return parString
    End Function
    Public Shared Function CompComanda(ByVal parString As String, ByVal parImpressora As String) As String
        If parImpressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) + Chr(15) + parString
        End If

        If parImpressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + "!" + Chr(1) + parString
        End If
        If parImpressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) + "!" + Chr(1) + parString
        End If
        Return parString
    End Function
    Public Shared Function CompNeg(ByVal parString As String) As String
        parString = Chr(27) + "!" + Chr(9) + parString

        Return parString
    End Function

    Public Shared Function Neg(ByVal parString As String) As String

        If Impressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) + Chr(69) + parString & Chr(27) + Chr(70)
        End If

        If Impressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + Chr(33) + Chr(9) + parString
        End If

        If Impressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) + Chr(33) + Chr(9) + parString
        End If
        Return parString
    End Function
    Public Shared Function NegSAT(ByVal parString As String) As String

        If ModeloImpSAT.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) + Chr(69) + parString & Chr(27) + Chr(70)
        End If

        If ModeloImpSAT.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + Chr(33) + Chr(9) + parString
        End If

        If ModeloImpSAT.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) + Chr(33) + Chr(9) + parString
        End If
        Return parString
    End Function
    Public Shared Function NegComanda(ByVal parString As String, ByVal parImpressora As String) As String

        If parImpressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) + Chr(69) + parString & Chr(27) + Chr(70)
        End If

        If parImpressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + Chr(33) + Chr(9) + parString
        End If

        If parImpressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) + Chr(33) + Chr(9) + parString
        End If
        Return parString
    End Function
    Public Shared Function Exp(ByVal parString As String) As String
       
        If Impressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) + Chr(14) + parString
        End If

        If Impressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + "!" + Chr(14) + parString
          
        End If
        If Impressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) + "!" + Chr(14) + parString

        End If
        Return parString
    End Function

    Public Shared Function ExpComanda(ByVal parString As String, ByVal parImpressora As String) As String

        If parImpressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) + Chr(14) + parString
        End If

        If parImpressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + "!" + Chr(14) + parString

        End If
        If parImpressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) + "!" + Chr(14) + parString

        End If
        Return parString
    End Function

    Public Shared Function DupLin(ByVal parString As String) As String
        parString = Chr(27) + "!" + Chr(16) + parString & Chr(27) + "!" + Chr(0)

        Return parString
    End Function

    Public Shared Function Subl(ByVal parString As String) As String
        parString = Chr(27) + "!" + Chr(128) + parString

        Return parString
    End Function


   
    Public Shared Function GerarBarCode(ByVal parString As String) As String
        If Impressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) & Chr(98) + Chr(5) + Chr(2) + Chr(150) + Chr(0) & parString + Chr(0)
        End If


        If Impressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(29) + Chr(107) + Chr(6) + parString + Chr(0)
            'parString = Chr(29) + Chr(107) + Chr(6) + parString + Chr(45) + Chr(68) + Chr(0)
        End If

        If Impressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(29) + Chr(107) + Chr(4) + parString + Chr(0)
        End If


        If CodigoBarraCupom = False Then
            parString = ""
        End If

        Return parString
    End Function

    Public Shared Function Centralizar(ByVal parString As String) As String

        If Impressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) & Chr(106) + Chr(1) & parString
        End If

        If Impressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) & Chr(97) + Chr(1) & parString
        End If

        If Impressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) & Chr(97) + Chr(1) & parString
        End If

        Return parString
    End Function

    Public Shared Function CentralizarSAT(ByVal parString As String) As String

        If ModeloImpSAT.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) & Chr(106) + Chr(1) & parString
        End If

        If ModeloImpSAT.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) & Chr(97) + Chr(1) & parString
        End If

        If ModeloImpSAT.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) & Chr(97) + Chr(1) & parString
        End If

        Return parString
    End Function

    Public Shared Function CentralizarComanda(ByVal parString As String, ByVal parImpressora As String) As String

        If parImpressora.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) & Chr(106) + Chr(1) & parString
        End If

        If parImpressora.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) & Chr(97) + Chr(1) & parString
        End If

        If parImpressora.ToUpper.Contains("EPSON") = True Then
            parString = Chr(27) & Chr(97) + Chr(1) & parString
        End If

        Return parString
    End Function

    Public Shared Function Corte() As String
        Dim parString As String

        parString = Chr(27) & Chr(109)

        Return parString
    End Function

    Public Shared Function AbreGaveta() As String

        Dim eClear As String = Chr(27) + "@"
        Dim eDrawer As String = eClear + Chr(27) + "p" + Chr(0) + ".}"

        Dim parString As String

        parString = eDrawer

        Return parString

    End Function


    Public Shared Function Avanco() As String
        Dim strString As String = ""

        If Impressora.ToUpper.Contains("DARUMA") = True Then
            strString = Chr(25)
        End If

        If Impressora.ToUpper.Contains("BEMATECH") = True Then
            strString = vbCrLf & vbCrLf & vbCrLf
        End If
        If Impressora.ToUpper.Contains("EPSON") = True Then
            strString = vbCrLf & vbCrLf & vbCrLf
        End If
        If Impressora = "ARQUIVO" Then
            strString = vbCrLf & vbCrLf & vbCrLf
        End If

        Return strString
    End Function
    Public Shared Function AvancoComanda(ByVal parImpressora As String) As String
        Dim strString As String = ""

        If parImpressora.ToUpper.Contains("DARUMA") = True Then
            strString = Chr(25)
        End If

        If parImpressora.ToUpper.Contains("BEMATECH") = True Then
            strString = vbCrLf & vbCrLf & vbCrLf
        End If
        If parImpressora.ToUpper.Contains("EPSON") = True Then
            strString = vbCrLf & vbCrLf & vbCrLf
        End If
        If parImpressora = "ARQUIVO" Then
            strString = vbCrLf & vbCrLf & vbCrLf
        End If

        Return strString
    End Function
    Public Shared Function Margem() As String
        Dim strString As String

        strString = Chr(27) & Chr(108) & 1

        Return strString
    End Function


    Public Shared Function Cabecalho() As String


        ' SendFileToPrinter(PortaImpressora, "C:\Users\Eder\Desktop\DOSPrinter\Sample3.prn")

        strTraco = Comp("-------------------------------------------------------")
        strIgual = Comp("=======================================================")

        'StringImpressao = Chr(29) + Chr(249) + Chr(53) + Chr(0) & vbCrLf

        StringImpressao = Centralizar(strIgual) & vbCrLf
        StringImpressao &= Exp(Centralizar(NomeEmpresa)) & vbCrLf
        StringImpressao &= Comp(Centralizar(EnderecoEmpresa.Trim)) & vbCrLf
        StringImpressao &= Comp(Centralizar(TelefoneEmpresa)) & vbCrLf
  
        StringImpressao &= Centralizar(strIgual) & vbCrLf

        Return StringImpressao
    End Function

    Public Shared Function CabecalhoComanda(ByVal parImpressora As String) As String


        ' SendFileToPrinter(PortaImpressora, "C:\Users\Eder\Desktop\DOSPrinter\Sample3.prn")

        strTraco = CompComanda("-------------------------------------------------------", parImpressora)
        strIgual = CompComanda("=======================================================", parImpressora)

        'StringImpressao = Chr(29) + Chr(249) + Chr(53) + Chr(0) & vbCrLf

        StringImpressao = strIgual & vbCrLf
        StringImpressao &= ExpComanda(CentralizarComanda(NomeEmpresa, parImpressora), parImpressora) & vbCrLf
        StringImpressao &= CompComanda(CentralizarComanda(EnderecoEmpresa.Trim, parImpressora), parImpressora) & vbCrLf
        StringImpressao &= CompComanda(CentralizarComanda(TelefoneEmpresa, parImpressora), parImpressora) & vbCrLf
        StringImpressao &= strIgual & vbCrLf

        Return StringImpressao
    End Function
    Public Shared Function Rodape(ByVal parGaveta As Boolean, ByVal parString As String, Optional ByVal parPorta As String = "") As Boolean

        parString &= strTraco & vbCrLf

        parString &= Comp(Centralizar("DOCUMENTO NÃO FISCAL")) & vbCrLf

        ' parString &= Chr(27) + "!" + Chr(0) + "TESTE"

        parString = parString.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("ô", "o").Replace("Ò", "O").Replace("Õ", "O").Replace("Ô", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")


        parString += Avanco() & vbCrLf

        If TemGuilhotina = True Then
            parString += Corte() & vbCrLf
        End If

        If NomePCGaveta <> "" Then
            If NomePCGaveta.ToUpper <> My.Computer.Name.ToUpper Then
                parGaveta = False
            End If
        End If
        If parGaveta = True Then
            If TemGaveta = True Then
                parString += AbreGaveta() & vbCrLf
            End If
        End If

        Try
            If parPorta <> "" Then
                SendStringToPrinter(parPorta, parString)
            Else
                SendStringToPrinter(PortaImpressora, parString)
            End If
        Catch ex As Exception
            MsgBox("Erro na impressão!", MsgBoxStyle.Information)

        End Try


        Return True
    End Function

    Public Shared Function RodapeTEF(ByVal parString As String, Optional ByVal parPorta As String = "") As Boolean

        parString &= strTraco & vbCrLf

        parString &= Comp(Centralizar("DOCUMENTO NÃO FISCAL")) & vbCrLf

        ' parString &= Chr(27) + "!" + Chr(0) + "TESTE"

        parString = parString.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("ô", "o").Replace("Ò", "O").Replace("Õ", "O").Replace("Ô", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")





        parString += Avanco() & vbCrLf

        If TemGuilhotina = True Then
            parString += Corte() & vbCrLf
        End If

        Try
            If parPorta <> "" Then
                SendStringToPrinter(parPorta, parString)
            Else
                SendStringToPrinter(PortaImpressora, parString)
            End If
        Catch ex As Exception
            MsgBox("Erro na impressão!", MsgBoxStyle.Information)

        End Try


        Return True
    End Function
    Public Shared Function RodapeComanda(ByVal parString As String, ByVal parImpressora As String, Optional ByVal parPorta As String = "") As Boolean

        parString &= strTraco & vbCrLf

        parString &= CompComanda(CentralizarComanda("DOCUMENTO NÃO FISCAL", parImpressora), parImpressora) & vbCrLf

        ' parString &= Chr(27) + "!" + Chr(0) + "TESTE"

        parString = parString.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("ô", "o").Replace("Ò", "O").Replace("Õ", "O").Replace("Ô", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")





        parString += AvancoComanda(parImpressora) & vbCrLf

        If TemGuilhotina = True Then
            parString += Corte() & vbCrLf
        End If

        If TemGaveta = True Then
            parString += AbreGaveta() & vbCrLf
        End If



        Try
            If parPorta <> "" Then
                SendStringToPrinter(parPorta, parString)
            Else
                SendStringToPrinter(PortaImpressora, parString)
            End If
        Catch ex As Exception
            MsgBox("Erro na impressão!", MsgBoxStyle.Information)

        End Try


        Return True
    End Function
    Public Shared Function ImprimeCupom(ByVal parCodOrdem As Integer, ByVal parCodPedido As Integer, ByVal parGaveta As Boolean) As Boolean

        Cabecalho()


        Dim dtPed As DataTable = CarregarDataTable("SELECT CodProd, CodProdInterno, Produto, ValorUnitario, Tamanho, Qtd, " & _
        "ValorTotal, UM, Total.CodCli, Total.CodConfig, Total.Total, Total.Troco, Total.Recebido, Total.ValDesc, " & _
        "Total.Data, Total.Hora, CodPedido, UniSemDesc, Pedido.CodFunc FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem where " & _
        "Pedido.CodOrdem = " & parCodOrdem & " and Pedido.TipoItens <> 'CONSUMO' and " & _
        "Pedido.CodConfig =" & CodConfig & " and Total.CodConfig =" & CodConfig)



        If dtPed.Rows.Count = 0 Then Exit Function

        If dtPed.Rows.Item(0).Item("CodPedido").ToString <> "" Then
            parCodPedido = dtPed.Rows.Item(0).Item("CodPedido")
        End If
        Dim dtObsPed As DataTable = CarregarDataTable("Select Descricao from TotalConsig where CodOrdens =" & parCodPedido & " and CodConfig =" & CodConfig)

        Dim strObsPedido As String = ""

        If dtObsPed.Rows.Count > 0 Then
            strObsPedido = dtObsPed.Rows.Item(0).Item("Descricao").ToString
        End If

        StringImpressao &= Comp(Esq(Format(dtPed.Rows.Item(0).Item("Data"), "dd/MM/yyyy") & " " & dtPed.Rows.Item(0).Item("Hora"), 55)) & vbCrLf
        StringImpressao &= Centralizar(Exp("VENDA N: " & parCodOrdem)) & vbCrLf
        StringImpressao &= strTraco & vbCrLf
        StringImpressao &= Neg(Comp(Dir("CODIGO DESCRICAO", 55))) & vbCrLf
        If EconomiaCupom = False Then
            StringImpressao &= Neg(Comp(Dir("UM   QTD    VL UNIT R$", 44) & Esq("VL TOTAL R$", 11))) & vbCrLf
        Else
            StringImpressao &= Neg(Comp(Dir("UM   QTD    VL UNIT R$     VL S/DES R$", 44) & Esq("VL TOTAL R$", 11))) & vbCrLf
        End If
        StringImpressao &= strTraco & vbCrLf


        Dim L As Integer
        Dim dblQtd As Double
        Dim dblValDesTot As Double
        Dim dblResultVed As Double
        Dim dblValReceb As Double

        For L = 0 To dtPed.Rows.Count - 1
            Dim strCod, strProd, strQtd, strUM, strCodAut, strTam As String
            Dim dblUni, dblTot, dblProd As Double

            Dim strCodFunc As String = dtPed.Rows.Item(L).Item("CodFunc").ToString
            Dim strCodProd As String = dtPed.Rows.Item(L).Item("CodProd").ToString
            strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
            strProd = dtPed.Rows.Item(L).Item("Produto").ToString
            dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
            strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
            dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
            dblValDesTot = dtPed.Rows.Item(L).Item("ValDesc").ToString
            strUM = dtPed.Rows.Item(L).Item("UM").ToString
            strTam = dtPed.Rows.Item(L).Item("Tamanho").ToString
            If strUM.Trim = "" Then
                strUM = "UN"
            End If
            dblQtd += dtPed.Rows.Item(L).Item("Qtd").ToString


            If BaixaPorLote = True Then
                If CNPJEmpresa = "08650693000170" Then
                    strProd = strCod & "  " & strProd
                    'If strProd.Length > 55 Then
                    '    strProd = Mid(strProd, 1, 55)
                    'End If
                Else
                    strProd = Dir(strCod & "  " & strProd, 55)
                    If strProd.Length > 47 Then
                        strProd = Mid(strProd, 1, 47)
                    End If

                    strProd = strProd & " - " & strTam
                End If

            Else
                strProd = Dir(strCod & "  " & strProd, 55)
                If strProd.Length > 55 Then
                    strProd = Mid(strProd, 1, 55)
                End If
            End If


            StringImpressao &= Comp(strProd) & vbCrLf

            Dim dblResult As Double
            If dtPed.Rows.Item(L).Item("UniSemDesc").ToString <> "" Then
                dblResult = dtPed.Rows.Item(L).Item("UniSemDesc").ToString
            Else
                dblResult = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
            End If

            'If EconomiaCupom = True Then
            '    strCodAut = dtPed.Rows.Item(L).Item("CodProd").ToString
            '    Dim dtProduto As DataTable = CarregarDataTable("Select ValorAnt From Campanha Where CodProd=" & strCodAut & " And Status='Lancado' And CodConfig=" & CodConfig)
            '    If dtProduto.Rows.Count > 0 Then
            '        dblProd = dtProduto.Rows.Item(0).Item("ValorAnt").ToString
            '    End If

            '    If dblUni < dblProd Then
            '        dblResult = CInt(strQtd) * dblProd
            '    Else
            '        dblResult = CInt(strQtd) * dblUni
            '    End If
            '    dblResultVed = dblResultVed + dblResult
            'End If
            Dim str As String

            If EconomiaCupom = False Then
                str = Dir(strUM & "   " & strQtd & "  X  " & dblUni.ToString("####,##0.00"), 40) & Esq(dblTot.ToString("####,##0.00"), 15)
            Else
                str = Dir(strUM & "   " & strQtd & "  X  " & dblUni.ToString("####,##0.00"), 32) & Dir(dblResult.ToString("####,##0.00"), 12) & Esq(dblTot.ToString("####,##0.00"), 10)
            End If

            If TipoNano = 5 Or TipoNano = 2 Then
                Dim strFunc As String = ""
                Dim strLoc As String = ""
                If strCodFunc <> "" Then
                    Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFunc)

                    If dtFunc.Rows.Count > 0 Then
                        strFunc = dtFunc.Rows.Item(0).Item("Nome").ToString
                    End If
                End If

                Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Locacao where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)
                If dtLoc.Rows.Count > 0 Then
                    strLoc = dtLoc.Rows.Item(0).Item("Locacao").ToString
                End If
                If strLoc <> "" Or strFunc <> "" Then
                    str &= vbCrLf & Dir(strLoc, 12) & Dir(strFunc, 30)
                End If
            End If

            StringImpressao &= Comp(str) & vbCrLf
        Next


        Dim dblValor As Double = dtPed.Rows.Item(0).Item("Total").ToString
        Dim dblValorEco As Double = dtPed.Rows.Item(0).Item("Total").ToString
        StringImpressao &= strTraco & vbCrLf

        Dim dblSubTotal As Double = dblValor + dblValDesTot

        If Impressora.Contains("DARUMA") = True Then
            'StringImpressao &= vbCrLf
            'StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf

            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 28)) & Comp(Esq("SUBTOTAL R$", 13) & Esq(dblSubTotal.ToString("####,##0.00"), 14)) & vbCrLf & vbCrLf
            StringImpressao &= Comp(Dir("              ", 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf

        End If

        If Impressora.Contains("BEMATECH") = True Then
            'StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf

            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 28)) & Comp(Esq("SUBTOTAL R$", 13) & Esq(dblSubTotal.ToString("####,##0.00"), 14)) & vbCrLf
            StringImpressao &= Comp(Dir("              ", 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf
        End If

        If Impressora.Contains("EPSON") = True Then
            'StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf

            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 28)) & Comp(Esq("SUBTOTAL R$", 13) & Esq(dblSubTotal.ToString("####,##0.00"), 14)) & vbCrLf
            StringImpressao &= Comp(Dir("              ", 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf

        End If

        StringImpressao &= Comp("                           _____________________________") & vbCrLf

        If dblValDesTot > 0 Then
            If EconomiaCupom = False Then
                StringImpressao &= Comp(Esq("DESCONTO R$ ", 42) & Esq(dblValDesTot.ToString("0.00"), 13)) & vbCrLf
            End If
        End If
        Dim dblTro As Double = 0
        dblTro = dtPed.Rows.Item(0).Item("Troco").ToString

        Dim bolTroco As Boolean = False
        Dim P As Integer
        Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor FROM Recebimento where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)

        If FormaPagamentoGaveta <> "" Then
            parGaveta = False
        End If

        If dtPag.Rows.Count > 0 Then

            For P = 0 To dtPag.Rows.Count - 1
                Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString
                If FormaPagamentoGaveta <> "" Then
                    If FormaPagamentoGaveta.Contains("|" & strPag & "|") = True Then
                        parGaveta = True
                    End If
                End If
                If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                    dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                    dblValReceb = dtPag.Rows.Item(P).Item("Valor").ToString
                End If
                If strPag.ToUpper.Contains("DINHEIRO") Then
                    If bolTroco = False Then
                        If dblTro > 0 Then

                            dblValor = dblValor + dblTro
                            bolTroco = True
                        End If
                    End If
                End If
                StringImpressao &= Comp(Esq(strPag & " R$ ", 42) & Esq(dblValor.ToString("####,##0.00"), 13)) & vbCrLf
            Next
        End If


        StringImpressao &= Neg(Comp(Esq("TROCO R$ ", 42) & Esq(dblTro.ToString("####,##0.00"), 13))) & vbCrLf


        If dblValDesTot = 0 Then
            If EconomiaCupom = True And frmVenda.dblValorEconomia > 0 Then
                Dim dblTot As Double = (frmVenda.dblValorEconomia - dblValorEco) + dblValDesTot
                If dblTot > 0 Then
                    StringImpressao &= Neg(Comp(Esq("TOTAL ECONOMIZADO R$ ", 42) & Esq(dblTot.ToString("####,##0.00"), 13))) & vbCrLf
                End If
            End If
        Else
            Dim dblTot As Double = frmVenda.dblValorEconomia - dblValorEco
            If frmVenda.dblValorEconomia > 0 Then
                If dblTot > 0 Then
                    StringImpressao &= Neg(Comp(Esq("TOTAL ECONOMIZADO R$ ", 42) & Esq(dblTot.ToString("####,##0.00"), 13))) & vbCrLf
                End If
            End If
        End If


        Dim bolTraco As Boolean = False

        If GerarComissao = True Then
            Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario left join Pedido on Funcionario.Codigo = Pedido.CodFunc where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.CodConfig =" & CodConfig)
            If dtFunc.Rows.Count > 0 Then

                StringImpressao &= strTraco & vbCrLf
                bolTraco = True
                StringImpressao &= Dir("Vend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
            End If

        End If
        Dim dtCaixa As DataTable = CarregarDataTable("SELECT Caixa FROM Caixa where Motivo like '%Venda Nº " & parCodOrdem & ",%' and CodConfig = " & CodConfig)
        If dtCaixa.Rows.Count > 0 Then
            If dtCaixa.Rows.Item(0).Item("Caixa").ToString <> "" Then
                StringImpressao &= Dir("Oper.: " & dtCaixa.Rows.Item(0).Item("Caixa").ToString, 55) & vbCrLf
            End If
        End If

        Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig)

        Dim bolCredia As Boolean = False

        If dtRec.Rows.Count > 0 Then
            bolCredia = True
            If bolTraco = False Then
                StringImpressao &= strTraco & vbCrLf
            End If

            Dim dtVenc As Date
            Dim dblPar As Double

            StringImpressao &= Comp(" ") & vbCrLf

            Dim R As Integer

            For R = 0 To dtRec.Rows.Count - 1

                If R = 0 Then
                    StringImpressao &= Neg(Dir(dtRec.Rows.Item(R).Item("Pagamento").ToString, 55)) & vbCrLf
                End If

                dtVenc = Dir(dtRec.Rows.Item(R).Item("Vencimento").ToString, 55)
                dblPar = Dir(dtRec.Rows.Item(R).Item("ValorParcela").ToString, 55)
                StringImpressao &= Comp(Dir(dtVenc & "   R$ " & dblPar.ToString("0.00"), 55)) & vbCrLf
            Next
        End If


        Dim dtFut As DataTable = CarregarDataTable("Select Pagamento, convert(Numeric(15,2),Total) as Total, Count(Codigo) as Qtd from Futuro " & _
        "where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig & " group by Pagamento, convert(Numeric(15,2),Total)")

        If dtFut.Rows.Count > 0 Then

            If bolTraco = False Then
                StringImpressao &= strTraco & vbCrLf
            End If

            StringImpressao &= Comp(" ") & vbCrLf

            Dim R As Integer

            For R = 0 To dtFut.Rows.Count - 1


                StringImpressao &= Neg(Dir(dtFut.Rows.Item(R).Item("Pagamento").ToString, 55)) & vbCrLf
                StringImpressao &= Comp(Dir(dtFut.Rows.Item(R).Item("Qtd").ToString & " x " & dtFut.Rows.Item(R).Item("Total").ToString, 55)) & vbCrLf
                If R <> dtFut.Rows.Count - 1 Then
                    StringImpressao &= " " & vbCrLf
                End If
            Next
        End If

        If TotalPendenciaImpressao = True Then
            dtRec = CarregarDataTable("Select sum(convert(numeric(15,2),ValorParcela)) as Valor from ContaReceber where CodCli =" & dtPed.Rows.Item(0).Item("CodCli").ToString & " and CodConfig =" & CodConfig & " and RecebidoOk = 'False'")
            If dtRec.Rows.Count > 0 Then
                If dtRec.Rows.Item(0).Item("Valor").ToString <> "" Then
                    StringImpressao &= " " & vbCrLf
                    StringImpressao &= Neg(Dir("Total Pendência: R$" & dtRec.Rows.Item(0).Item("Valor").ToString, 55)) & vbCrLf

                End If
            End If
        End If
        

        Dim dt As DataTable

        dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia, CPF from Cliente where Codigo =" & dtPed.Rows.Item(0).Item("CodCli").ToString)

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                StringImpressao &= " " & vbCrLf
                StringImpressao &= Neg(Dir(dt.Rows.Item(0).Item("Nome").ToString, 55)) & vbCrLf
                If dt.Rows.Item(0).Item("CPF").ToString <> "" And dt.Rows.Item(0).Item("CPF").ToString <> "000.000.000-00" Then
                    StringImpressao &= Neg(Dir(dt.Rows.Item(0).Item("CPF").ToString, 55)) & vbCrLf
                End If

            End If
            If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                StringImpressao &= Neg(Dir(dt.Rows.Item(0).Item("Fantasia").ToString, 55)) & vbCrLf
            End If
            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Telefone").ToString, 55)) & vbCrLf
            End If

        End If


        If TipoNano = 5 Then
            dt = CarregarDataTable("Select Total.Placa, Total.Modelo, Carro.Cor, Carro.Ano From Total left join Carro on Total.Placa=Carro.Placa Where Total.CodOrdem=" & parCodOrdem & " And Total.CodConfig=" & CodConfig)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Placa").ToString.Trim <> "" Then
                    StringImpressao &= " " & vbCrLf
                    'StringImpressao &= Dir("Placa: " & dt.Rows.Item(0).Item("Placa").ToString & ", " & "Modelo: " & dt.Rows.Item(0).Item("Modelo").ToString, 55) & vbCrLf
                    StringImpressao &= Dir("Placa: " & dt.Rows.Item(0).Item("Placa").ToString, 55) & vbCrLf
                    If dt.Rows.Item(0).Item("Modelo").ToString <> "" Then
                        StringImpressao &= Dir("Modelo: " & dt.Rows.Item(0).Item("Modelo").ToString & " - " & dt.Rows.Item(0).Item("Cor").ToString, 55) & vbCrLf
                    End If
                End If
                'If dt.Rows.Item(0).Item("Cor").ToString.Trim <> "" Then
                '    StringImpressao &= Dir("Cor: " & dt.Rows.Item(0).Item("Cor").ToString & ", " & "Ano: " & dt.Rows.Item(0).Item("Ano").ToString, 55) & vbCrLf
                'End If
                If dt.Rows.Item(0).Item("Ano").ToString <> "" Then
                    StringImpressao &= Dir("Ano: " & dt.Rows.Item(0).Item("Ano").ToString, 55) & vbCrLf
                End If
            End If
        End If


        Dim bol2Via As Boolean = False

        If ModeloCarne <> "0" Then
            dt = CarregarDataTable("Select Codigo from ContaReceber where CodOrdem =" & parCodOrdem & " and CodConfig =" & dtPed.Rows.Item(0).Item("CodConfig").ToString)

            If dt.Rows.Count > 0 Then

                bol2Via = True

                StringImpressao &= " " & vbCrLf
                StringImpressao &= " " & vbCrLf

                StringImpressao &= Centralizar(Comp("Reconheco que pagarei a dívida acima")) & vbCrLf
                StringImpressao &= Centralizar("apresentada conforme Contrato assinado") & vbCrLf
                StringImpressao &= Centralizar("em separado.") & vbCrLf
                StringImpressao &= " " & vbCrLf
                StringImpressao &= Centralizar("______________________________________") & vbCrLf

            End If
        End If

        If ObsPedidoVenda = True Then
            If Not strObsPedido = "" Then
                StringImpressao &= " " & vbCrLf
                StringImpressao &= Neg(Dir("OBSERVACOES DO PEDIDO", 55)) & vbCrLf
                StringImpressao &= Dir(strObsPedido, 55) & vbCrLf
                'StringImpressao &= " " & vbCrLf
            End If
        End If

        If DescricaoVenda <> "" Then
            StringImpressao &= " " & vbCrLf
            StringImpressao &= DescricaoVenda & vbCrLf
            StringImpressao &= " " & vbCrLf
        End If
        StringImpressao &= GerarBarCode(parCodOrdem) & vbCrLf

        Rodape(parGaveta, StringImpressao)

        If ModeloCarne <> "0" Then
            If bolCredia = True Then
                If MsgBox("Deseja imprimir o Carnê?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    ImprimeCrediario(parCodOrdem, dtPed.Rows.Item(0).Item("CodCli").ToString)
                End If
            End If
        End If


        If ValePresente = True Then
            ImprimeValePresente(parCodOrdem, parCodPedido)
        End If
    End Function
    Public Shared Function ImprimeValePresente(ByVal parCodOrdem As Integer, ByVal parCodPedido As Integer) As Boolean

        Cabecalho()

        Dim dtPed As DataTable = CarregarDataTable("SELECT CodProd, CodProdInterno, Produto, Tamanho, Qtd, " & _
        "Total.CodCli, Total.Data, Total.Hora, CodPedido, Pedido.CodFunc FROM Pedido left join Total on " & _
        "Pedido.CodOrdem = Total.CodOrdem and Total.CodConfig = Pedido.CodConfig where " & _
        "Pedido.CodOrdem = " & parCodOrdem & " and Pedido.TipoItens <> 'CONSUMO' and " & _
        "Pedido.CodConfig =" & CodConfig)

        If dtPed.Rows.Count = 0 Then Exit Function

        If dtPed.Rows.Item(0).Item("CodPedido").ToString <> "" Then
            parCodPedido = dtPed.Rows.Item(0).Item("CodPedido")
        End If
        Dim dtObsPed As DataTable = CarregarDataTable("Select Descricao from TotalConsig where CodOrdens =" & parCodPedido & " and CodConfig =" & CodConfig)

        Dim strObsPedido As String = ""

        If dtObsPed.Rows.Count > 0 Then
            strObsPedido = dtObsPed.Rows.Item(0).Item("Descricao").ToString
        End If

        StringImpressao &= Comp(Esq(Format(dtPed.Rows.Item(0).Item("Data"), "dd/MM/yyyy") & " " & dtPed.Rows.Item(0).Item("Hora"), 55)) & vbCrLf
        StringImpressao &= Centralizar(Exp("VENDA N: " & parCodOrdem)) & vbCrLf
        StringImpressao &= strTraco & vbCrLf

        StringImpressao &= Centralizar(DupLin("VALE PRESENTE")) & vbCrLf

        StringImpressao &= strTraco & vbCrLf

        StringImpressao &= Neg(Comp(Dir("CODIGO DESCRICAO", 44) & Esq("QTD", 11))) & vbCrLf

        StringImpressao &= strTraco & vbCrLf


        Dim L As Integer
        Dim dblQtd As Double

        For L = 0 To dtPed.Rows.Count - 1
            Dim strCod, strProd, strQtd, strTam As String

            Dim strCodFunc As String = dtPed.Rows.Item(L).Item("CodFunc").ToString
            Dim strCodProd As String = dtPed.Rows.Item(L).Item("CodProd").ToString
            strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
            strProd = dtPed.Rows.Item(L).Item("Produto").ToString
            strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString

            strTam = dtPed.Rows.Item(L).Item("Tamanho").ToString

            dblQtd += dtPed.Rows.Item(L).Item("Qtd").ToString

            If BaixaPorLote = True Then
                strProd = Dir(strCod & "  " & strProd, 55)
                If strProd.Length > 40 Then
                    strProd = Mid(strProd, 1, 40)
                End If
                strProd = strProd & " - " & strTam
            Else
                strProd = Dir(strCod & "  " & strProd, 47)
                If strProd.Length > 47 Then
                    strProd = Mid(strProd, 1, 47)
                End If
            End If


            StringImpressao &= Comp(Dir(strProd, 47) & Esq(strQtd, 8)) & vbCrLf
            'Dim str As String = ""
            'If TipoNano = 5 Or TipoNano = 2 Then
            '    Dim strFunc As String = ""
            '    Dim strLoc As String = ""
            '    If strCodFunc <> "" Then
            '        Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFunc)

            '        If dtFunc.Rows.Count > 0 Then
            '            strFunc = dtFunc.Rows.Item(0).Item("Nome").ToString
            '        End If
            '    End If

            '    Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Locacao where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)
            '    If dtLoc.Rows.Count > 0 Then
            '        strLoc = dtLoc.Rows.Item(0).Item("Locacao").ToString
            '    End If
            '    If strLoc <> "" Or strFunc <> "" Then
            '        str &= vbCrLf & Dir(strLoc, 12) & Dir(strFunc, 30)
            '    End If
            'End If

            'StringImpressao &= Comp(str) & vbCrLf
        Next


        StringImpressao &= strTraco & vbCrLf
        StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 55)) & vbCrLf

        Dim bolTraco As Boolean = False

        If GerarComissao = True Then
            Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario left join Pedido on Funcionario.Codigo = Pedido.CodFunc where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.CodConfig =" & CodConfig)
            If dtFunc.Rows.Count > 0 Then

                StringImpressao &= strTraco & vbCrLf
                bolTraco = True
                StringImpressao &= Dir("Vend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
            End If

        End If
        Dim dtCaixa As DataTable = CarregarDataTable("SELECT Caixa FROM Caixa where Motivo like '%Venda Nº " & parCodOrdem & ",%' and CodConfig = " & CodConfig)
        If dtCaixa.Rows.Count > 0 Then
            If dtCaixa.Rows.Item(0).Item("Caixa").ToString <> "" Then
                StringImpressao &= Dir("Oper.: " & dtCaixa.Rows.Item(0).Item("Caixa").ToString, 55) & vbCrLf
            End If
        End If

        Dim dt As DataTable

        dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia, CPF from Cliente where Codigo =" & dtPed.Rows.Item(0).Item("CodCli").ToString)

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                StringImpressao &= " " & vbCrLf
                StringImpressao &= Neg(Dir(dt.Rows.Item(0).Item("Nome").ToString, 55)) & vbCrLf
                If dt.Rows.Item(0).Item("CPF").ToString <> "" And dt.Rows.Item(0).Item("CPF").ToString <> "000.000.000-00" Then
                    StringImpressao &= Neg(Dir(dt.Rows.Item(0).Item("CPF").ToString, 55)) & vbCrLf
                End If

            End If
            If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                StringImpressao &= Neg(Dir(dt.Rows.Item(0).Item("Fantasia").ToString, 55)) & vbCrLf
            End If
            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Telefone").ToString, 55)) & vbCrLf
            End If

        End If


        If TipoNano = 5 Then
            dt = CarregarDataTable("Select Total.Placa, Total.Modelo, Carro.Cor, Carro.Ano From Total left join Carro on Total.Placa=Carro.Placa Where Total.CodOrdem=" & parCodOrdem & " And Total.CodConfig=" & CodConfig)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Placa").ToString.Trim <> "" Then
                    StringImpressao &= " " & vbCrLf
                    'StringImpressao &= Dir("Placa: " & dt.Rows.Item(0).Item("Placa").ToString & ", " & "Modelo: " & dt.Rows.Item(0).Item("Modelo").ToString, 55) & vbCrLf
                    StringImpressao &= Dir("Placa: " & dt.Rows.Item(0).Item("Placa").ToString, 55) & vbCrLf
                    If dt.Rows.Item(0).Item("Modelo").ToString <> "" Then
                        StringImpressao &= Dir("Modelo: " & dt.Rows.Item(0).Item("Modelo").ToString & " - " & dt.Rows.Item(0).Item("Cor").ToString, 55) & vbCrLf
                    End If
                End If
                'If dt.Rows.Item(0).Item("Cor").ToString.Trim <> "" Then
                '    StringImpressao &= Dir("Cor: " & dt.Rows.Item(0).Item("Cor").ToString & ", " & "Ano: " & dt.Rows.Item(0).Item("Ano").ToString, 55) & vbCrLf
                'End If
                If dt.Rows.Item(0).Item("Ano").ToString <> "" Then
                    StringImpressao &= Dir("Ano: " & dt.Rows.Item(0).Item("Ano").ToString, 55) & vbCrLf
                End If
            End If
        End If


        'Dim bol2Via As Boolean = False

        'If ObsPedidoVenda = True Then
        '    If Not strObsPedido = "" Then
        '        StringImpressao &= " " & vbCrLf
        '        StringImpressao &= Neg(Dir("OBSERVACOES DO PEDIDO", 55)) & vbCrLf
        '        StringImpressao &= Dir(strObsPedido, 55) & vbCrLf
        '        'StringImpressao &= " " & vbCrLf
        '    End If
        'End If

        'If DescricaoVenda <> "" Then
        '    StringImpressao &= " " & vbCrLf
        '    StringImpressao &= DescricaoVenda & vbCrLf
        '    StringImpressao &= " " & vbCrLf
        'End If
        StringImpressao &= GerarBarCode(parCodOrdem) & vbCrLf

        Rodape(False, StringImpressao)

    End Function
    Public Shared Function ImprimeCrediario(ByVal parCodOrdem As Integer, ByVal parCodCliente As Integer) As Boolean
        Cabecalho()

        StringImpressao &= Exp(Centralizar("CREDIÁRIO")) & vbCrLf

        StringImpressao &= strTraco & vbCrLf

        Dim dt As DataTable

        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Estado from Cliente where Codigo =" & parCodCliente)

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                StringImpressao &= Neg(Dir(dt.Rows.Item(0).Item("Nome").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                StringImpressao &= Dir(dt.Rows.Item(0).Item("CPF").ToString, 55) & vbCrLf
            End If

        End If

        StringImpressao &= strTraco & vbCrLf

        StringImpressao &= Neg(Exp(Centralizar("VENDA N: " & parCodOrdem))) & vbCrLf

        StringImpressao &= strTraco & vbCrLf

        Dim dtRec As DataTable = CarregarDataTable("Select Parcelas, Vencimento, ValorParcela, ValorVenda from ContaReceber where CodOrdem =" & parCodOrdem & " and CodCli =" & parCodCliente & " and CodConfig =" & CodConfig & " and RecebidoOK ='False'")

        Dim I As Integer
        Dim dblVal As Double
        Dim dblTot As Double
        Dim strVenc As String
        For I = 0 To dtRec.Rows.Count - 1
            dblVal = dtRec.Rows.Item(I).Item("ValorParcela").ToString
            StringImpressao &= Dir("N. Parcela: " & dtRec.Rows.Item(I).Item("Parcelas").ToString, 55) & vbCrLf
            StringImpressao &= Dir("Vencimento: " & Format(dtRec.Rows.Item(I).Item("Vencimento"), "dd/MM/yyyy"), 55) & vbCrLf
            StringImpressao &= Neg(Dir("Valor Parc: R$ " & dblVal.ToString("0.00") & "   Data Pag.: ____/____/_______", 55)) & vbCrLf
            StringImpressao &= vbCrLf & vbCrLf
            StringImpressao &= Dir("Autenticacao:_______________________________________", 55) & vbCrLf
            StringImpressao &= strTraco & vbCrLf
            strVenc = dtRec.Rows.Item(I).Item("Vencimento")
            dblTot += dblVal
        Next

        StringImpressao &= vbCrLf & vbCrLf

        If dtRec.Rows.Count > 0 Then
            dblVal = dtRec.Rows.Item(0).Item("ValorVenda").ToString
            StringImpressao &= Neg(Dir("Total Crediário: R$ " & dblTot.ToString("0.00"), 55)) & vbCrLf
        End If


        StringImpressao &= vbCrLf & vbCrLf

        StringImpressao &= Neg(Centralizar("A Parcela será considerada paga")) & vbCrLf
        StringImpressao &= Neg(Centralizar("quando conter O RECIBO DE PAGAMENTO.")) & vbCrLf

        StringImpressao &= vbCrLf & vbCrLf

        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
            StringImpressao &= Comp(Centralizar("Pague em dia e aumento seu Limite.")) & vbCrLf
            StringImpressao &= Comp(Centralizar("O seu nome é seu maior patrimônio!")) & vbCrLf
        End If

        StringImpressao &= GerarBarCode(parCodOrdem) & vbCrLf

        Rodape(True, StringImpressao)


        If NomeEmpresa.Contains("TAUÁ") = False And NomeEmpresa.Contains("CRISS") = True Then
            If MsgBox("Deseja imprimir a NOTA PROMISSÓRIA?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                If strVenc = "" Then
                    MsgBox("Só é possível imprimir a NOTA PROMISSÓRIA quando o Carne foi impresso!", MsgBoxStyle.Information)
                    Exit Function
                End If
                Dim rel As New relPromissoria
                Dim culture As New CultureInfo("pt-BR")
                Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
                Dim dia As Integer = DateTime.Now.Day
                Dim ano As Integer = DateTime.Now.Year
                Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))

                Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek))

                Dim data As String = diasemana & ", " & dia & " de " & mes & " de " & ano
                Dim vetData As Array
                vetData = Split(strVenc, "/")
                Dim intMes, intDia, intAno As Integer
                intMes = vetData(1)
                intDia = vetData(0)
                intAno = vetData(2)
                Dim strMesVenc As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(intMes))
                Dim strDia As String = getInteger(intDia)
                Dim strAno As String = getInteger(intAno)
                Dim strEndereco As String
                strEndereco = dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & "  " & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & " - " & dt.Rows.Item(0).Item("Estado").ToString
                rel.lblPagavel.Text = CidadeEmpresa
                rel.lblCPF1.Text = CNPJEmpresa
                rel.lblCidade.Text = CidadeEmpresa & ","
                rel.lblDiaAtual.Text = Date.Today.Day
                rel.lblMesAtual.Text = mes.ToUpper
                rel.lblAnoAtual.Text = Date.Today.Year
                rel.lblDia.Text = intDia
                rel.lblMes.Text = strMesVenc.ToUpper
                rel.lblAno.Text = intAno
                rel.lblEmit.Text = dt.Rows.Item(0).Item("Nome").ToString
                rel.lblEnd.Text = strEndereco
                rel.lblCPF2.Text = dt.Rows.Item(0).Item("CPF").ToString
                rel.lblVia.Text = NomeEmpresa
                If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                    If dt.Rows.Item(0).Item("CPF").ToString.Length > 13 Then
                        rel.lblPagar.Text = "EMOS"
                    Else
                        rel.lblPagar.Text = "EI"
                    End If
                Else
                    rel.lblPagar.Text = "EI"
                End If


                rel.lblNumero.Text = "01/01"
                rel.lblValor.Text = dblTot.ToString("0.00")
                Dim strValorExt As String = dblTot.ToString("0.00")
                Dim vetValor As Array
                vetValor = Split(strValorExt, ",")
                Dim strReais, strCentavos As String
                strReais = getInteger(vetValor(0))
                If vetValor(1) = "00" Then
                    strValorExt = strReais.ToUpper & " REAIS"
                Else
                    strCentavos = getInteger(vetValor(1))
                    strValorExt = strReais.ToUpper & " REAIS E " & strCentavos.ToUpper & " CENTAVOS"
                End If
                rel.lblValorExt.Text = strValorExt
                rel.lblAos.Text = "DIA " & strDia.ToUpper & " DO MÊS DE " & strMesVenc.ToUpper & " DO ANO DE " & strAno.ToUpper
                rel.ShowPreviewDialog()
            End If
        End If

        
    End Function

    Public Shared Function ImprimePedido(ByVal parCodPed As Integer, ByVal parCodCli As Integer, ByVal parData As String, ByVal parVendedor As String, ByVal parOBS As String) As Boolean

        Cabecalho()


        Dim dtPed As DataTable = CarregarDataTable("Select CodigoInterno, Produto, ValorUnitario, Qtd, " & _
        "ValorTotal, UM, Autorizado, CodigoProduto, CodigoFuncionario from ItensConsig where CodOrdens =" & parCodPed & " and CodConfig =" & CodConfig)

        Dim dtCarro As DataTable = CarregarDataTable("Select Placa, Modelo, Cor, Ano, Motor, NivelCombustivel, " & _
        "KMSaida, KMEntrada, DataRetirada, DataEntrega, Desconto, Total from TotalConsig where CodOrdens =" & parCodPed & " and CodConfig = " & CodConfig)

        StringImpressao &= Esq(parData & " " & Format(Hour(My.Computer.Clock.LocalTime), "00") & ":" & Format(Minute(My.Computer.Clock.LocalTime), "00") & ":" & Format(Second(My.Computer.Clock.LocalTime), "00"), 55) & vbCrLf
        StringImpressao &= Exp(Centralizar("Pedido N: " & parCodPed)) & vbCrLf
        StringImpressao &= strTraco & vbCrLf
        StringImpressao &= Comp("CÓDIGO    DESCRIÇÃO                                    ") & vbCrLf
        StringImpressao &= Comp("UN.    QTD.    VL UNIT R$                   VL TOTAL R$") & vbCrLf
        StringImpressao &= strTraco & vbCrLf

        Dim L As Integer
        Dim dblQtd, dblUni, dblTot, dblTotal As Double
        For L = 0 To dtPed.Rows.Count - 1
            If dtPed.Rows.Item(L).Item("Autorizado") = True Then


                Dim strCod, strProd, strQtd, strUM As String
                Dim strCodProd As String = dtPed.Rows.Item(L).Item("CodigoProduto").ToString
                Dim strCodFunc As String = dtPed.Rows.Item(L).Item("CodigoFuncionario").ToString
                strCod = dtPed.Rows.Item(L).Item("CodigoInterno").ToString
                strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
                dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                strUM = dtPed.Rows.Item(L).Item("UM").ToString
                dblQtd += CDbl(strQtd)
                dblTotal += dblUni * CDbl(strQtd)
                StringImpressao &= Comp(Dir(strCod & "   " & strProd, 55)) & vbCrLf
                Dim str As String
                str = Dir(strUM, 6) & Dir(strQtd & "  X  " & dblUni.ToString("0.00"), 21) & Esq(dblTot.ToString("0.00"), 28)


                If TipoNano = 5 Then
                    Dim strFunc As String = ""
                    Dim strLoc As String = ""
                    If strCodFunc <> "" Then
                        Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFunc)

                        If dtFunc.Rows.Count > 0 Then
                            strFunc = dtFunc.Rows.Item(0).Item("Nome").ToString
                        End If
                    End If

                    Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Locacao where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)
                    If dtLoc.Rows.Count > 0 Then
                        strLoc = dtLoc.Rows.Item(0).Item("Locacao").ToString
                    End If
                    If strLoc <> "" Or strFunc <> "" Then
                        str &= vbCrLf & Dir(strLoc, 12) & Dir(strFunc, 30)
                    End If
                End If
                StringImpressao &= Comp(str) & vbCrLf
            End If
        Next
        dblTotal = dtCarro.Rows.Item(0).Item("Total").ToString

        StringImpressao &= strTraco & vbCrLf
        Dim dblValDesTot As Double = 0
        If dtCarro.Rows.Item(0).Item("Desconto").ToString <> "" And dtCarro.Rows.Item(0).Item("Desconto").ToString <> "|" Then
            Dim strDesconto As String = dtCarro.Rows.Item(0).Item("Desconto").ToString
            Dim vetDesc As Array = Split(strDesconto, "|")
            dblValDesTot = vetDesc(0)
        End If
        Dim dblSubTotal As Double = dblTotal + dblValDesTot


        'If Impressora.Contains("DARUMA") = True Then
        '    StringImpressao &= vbCrLf
        '    StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 27)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 14)) & vbCrLf
        'End If

        'If Impressora.Contains("BEMATECH") = True Then
        '    StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf
        'End If

        'If Impressora.Contains("EPSON") = True Then
        '    StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf
        'End If


        If Impressora.Contains("DARUMA") = True Then
            'StringImpressao &= vbCrLf
            'StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf
            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 28)) & Comp(Esq("SUBTOTAL R$", 13) & Esq(dblSubTotal.ToString("####,##0.00"), 14)) & vbCrLf & vbCrLf

            ' StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & Comp(Esq("SUBTOTAL R$", 8) & Esq(dblSubTotal.ToString("####,##0.00"), 11)) & vbCrLf
            StringImpressao &= Comp(Dir("              ", 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf

        End If

        If Impressora.Contains("BEMATECH") = True Then
            'StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf

            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 28)) & Comp(Esq("SUBTOTAL R$", 13) & Esq(dblSubTotal.ToString("####,##0.00"), 14)) & vbCrLf
            StringImpressao &= Comp(Dir("              ", 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf
        End If

        If Impressora.Contains("EPSON") = True Then
            'StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblValor.ToString("####,##0.00"), 11)) & vbCrLf

            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 28)) & Comp(Esq("SUBTOTAL R$", 13) & Esq(dblSubTotal.ToString("####,##0.00"), 14)) & vbCrLf
            StringImpressao &= Comp(Dir("              ", 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf

        End If
        StringImpressao &= Comp("                           _____________________________") & vbCrLf

        'StringImpressao &= vbCrLf & vbCrLf
        If dblValDesTot > 0 Then
            If EconomiaCupom = False Then
                StringImpressao &= Comp(Esq("DESCONTO R$ ", 42) & Esq(dblValDesTot.ToString("0.00"), 13)) & vbCrLf
            End If
        End If
        'ENTRADA PEDIDO
        'Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Caixa Where Motivo like '%ENTRADA RECEBIDA DO PEDIDO Nº " & parCodPed & "%' And CodConfig=" & CodConfig)
        Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = " & parCodPed & " And CodConfig=" & CodConfig)
        If dtEntrada.Rows.Count > 0 Then
            'StringImpressao &= Comp(Dir(" ENTRADA", 57)) & vbCrLf
            StringImpressao &= Comp("ENTRADA                                                ") & vbCrLf
            'StringImpressao &= Comp("UN.    QTD.    VL UNIT R$                   VL TOTAL R$") & vbCrLf
            StringImpressao &= strTraco & vbCrLf
            'StringImpressao &= Comp(" PAG.      VALOR R$                                     ")
            'StringImpressao &= Comp(" PAGAMENTO R$")


            If Impressora.Contains("DARUMA") = True Then
                'StringImpressao &= vbCrLf
                StringImpressao &= Comp(Dir("PAGAMENTO R$", 32)) '& Comp(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 14)) & vbCrLf
            End If

            If Impressora.Contains("BEMATECH") = True Then
                StringImpressao &= Comp(Dir("PAGAMENTO R$", 32)) '& Comp(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf
            End If

            If Impressora.Contains("EPSON") = True Then
                StringImpressao &= Comp(Dir("PAGAMENTO R$", 32)) '& Comp(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf
            End If

            Dim strPag As String
            Dim strValor As String
            Dim dblValor As Double
            For I As Integer = 0 To dtEntrada.Rows.Count - 1
                strPag = dtEntrada.Rows.Item(I).Item("Pagamento").ToString
                dblValor = dtEntrada.Rows.Item(I).Item("Valor").ToString
                strValor = dblValor.ToString("####,##0.00")

                Dim str As String
                str = Esq(" " & strPag, 10) & Esq(strValor, 14)

                StringImpressao &= Comp(str)
            Next
            StringImpressao &= vbCrLf
        End If

        StringImpressao &= strTraco & vbCrLf

        If GerarComissao = True Then
            StringImpressao &= Comp(Dir("Vend.: " & parVendedor, 55)) & vbCrLf
        End If

        Dim dt As DataTable

        dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Cliente where Codigo =" & parCodCli)

        If dt.Rows.Count > 0 Then
            StringImpressao &= vbCrLf
            If NomeEmpresa.Contains("POLI CONGELADOS") = True Then
                If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                    StringImpressao &= Neg(Comp(Dir(dt.Rows.Item(0).Item("Fantasia").ToString, 55))) & vbCrLf
                End If
            Else
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    StringImpressao &= Neg(Comp(Dir(dt.Rows.Item(0).Item("Nome").ToString, 55))) & vbCrLf
                End If
                If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                    StringImpressao &= Neg(Comp(Dir(dt.Rows.Item(0).Item("Fantasia").ToString, 55))) & vbCrLf
                End If
            End If
          

            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Telefone").ToString, 55)) & vbCrLf
            End If

        End If


      If dtCarro.Rows.Count > 0 Then
            If dtCarro.Rows.Item(0).Item("Placa").ToString <> "" Then
                StringImpressao &= vbCrLf
                StringImpressao &= Comp(Dir("Placa: " & dtCarro.Rows.Item(0).Item("Placa").ToString, 55)) & vbCrLf

                If dtCarro.Rows.Item(0).Item("Modelo").ToString <> "" Then
                    StringImpressao &= Comp(Dir("Modelo: " & dtCarro.Rows.Item(0).Item("Modelo").ToString & " - " & dtCarro.Rows.Item(0).Item("Cor").ToString, 55)) & vbCrLf
                End If

                If dtCarro.Rows.Item(0).Item("Ano").ToString <> "" Then
                    StringImpressao &= Comp(Dir("Ano: " & dtCarro.Rows.Item(0).Item("Ano").ToString & " - " & dtCarro.Rows.Item(0).Item("Motor").ToString, 55)) & vbCrLf
                End If
                If dtCarro.Rows.Item(0).Item("KMEntrada").ToString <> "" Then
                    StringImpressao &= Comp(Dir("KM Entrada: " & dtCarro.Rows.Item(0).Item("KMEntrada").ToString, 55)) & vbCrLf
                End If
                If dtCarro.Rows.Item(0).Item("KMSaida").ToString <> "" Then
                    StringImpressao &= Comp(Dir("KM Saída: " & dtCarro.Rows.Item(0).Item("KMSaida").ToString, 55)) & vbCrLf
                End If
                'StringImpressao &= vbCrLf
            End If

            If dtCarro.Rows.Item(0).Item("DataRetirada").ToString <> "" And dtCarro.Rows.Item(0).Item("DataRetirada").ToString <> "01/01/1900 00:00:00" Then
                StringImpressao &= Comp(Dir("Data Retirada: " & dtCarro.Rows.Item(0).Item("DataRetirada").ToString.Replace(" 00:00:00", ""), 55)) & vbCrLf
            End If
            If dtCarro.Rows.Item(0).Item("DataEntrega").ToString <> "" And dtCarro.Rows.Item(0).Item("DataEntrega").ToString <> "01/01/1900 00:00:00" Then
                StringImpressao &= Comp(Dir("Data Entrega: " & dtCarro.Rows.Item(0).Item("DataEntrega").ToString.Replace(" 00:00:00", ""), 55)) & vbCrLf
            End If
        End If


        If parOBS.Trim <> "" Then
            StringImpressao &= vbCrLf

            StringImpressao &= Neg(Dir("OBSERVAÇÕES", 55)) & vbCrLf
            StringImpressao &= Comp(Dir(parOBS, 55)) & vbCrLf
        End If

        If ObsPedido <> "" Then
            StringImpressao &= " " & vbCrLf
            StringImpressao &= ObsPedido & vbCrLf
            StringImpressao &= " " & vbCrLf
        End If

        If AutorizacaoPedido = True Then
            StringImpressao &= vbCrLf
            StringImpressao &= Centralizar("___________________________________") & vbCrLf
            StringImpressao &= Centralizar(dt.Rows.Item(0).Item("Nome").ToString) & vbCrLf
        End If


        StringImpressao &= Centralizar(GerarBarCode(parCodPed)) & vbCrLf

        Rodape(True, StringImpressao)


        Return True

    End Function
    Public Shared Function ImprimePedidoCompra(ByVal parCodPed As Integer, ByVal parCodCli As Integer, ByVal parData As String, ByVal parVendedor As String, ByVal parOBS As String) As Boolean

        Cabecalho()


        Dim dtPed As DataTable = CarregarDataTable("Select CodigoInterno, Produto, ValorUnitario, Qtd, ValorTotal, UM from PedCompra where CodOrdens =" & parCodPed & " and CodConfig =" & CodConfig)

        StringImpressao &= Esq(parData, 55) & vbCrLf
        StringImpressao &= Exp(Centralizar("Pedido N: " & parCodPed)) & vbCrLf
        StringImpressao &= strTraco & vbCrLf
        StringImpressao &= Comp("CÓDIGO    DESCRIÇÃO                                    ") & vbCrLf
        StringImpressao &= Comp("UN.    QTD.    VL UNIT R$                   VL TOTAL R$") & vbCrLf
        StringImpressao &= strTraco & vbCrLf

        Dim L As Integer
        Dim dblQtd, dblUni, dblTot, dblTotal As Double
        For L = 0 To dtPed.Rows.Count - 1
            Dim strCod, strProd, strQtd, strUM As String

            strCod = dtPed.Rows.Item(L).Item("CodigoInterno").ToString
            strProd = dtPed.Rows.Item(L).Item("Produto").ToString
            dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
            strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
            dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
            strUM = dtPed.Rows.Item(L).Item("UM").ToString
            dblQtd += CDbl(strQtd)
            dblTotal += dblUni * CDbl(strQtd)
            StringImpressao &= Comp(Dir(strCod & "   " & strProd, 55)) & vbCrLf
            Dim str As String
            str = Dir(strUM, 6) & Dir(strQtd & "  X  " & dblUni.ToString("0.00"), 21) & Esq(dblTot.ToString("0.00"), 28)
            StringImpressao &= Comp(str) & vbCrLf
        Next


        StringImpressao &= strTraco & vbCrLf



        If Impressora.Contains("DARUMA") = True Then
            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 33)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 14)) & vbCrLf
        End If

        If Impressora.Contains("BEMATECH") = True Then
            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf
        End If

        StringImpressao &= vbCrLf & vbCrLf

        StringImpressao &= strTraco & vbCrLf

        If GerarComissao = True Then
            StringImpressao &= Comp(Dir("Vend.: " & parVendedor, 55)) & vbCrLf
        End If

        Dim dt As DataTable

        dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Fornecedor where Codigo =" & parCodCli)

        If dt.Rows.Count > 0 Then

            If NomeEmpresa.Contains("POLI CONGELADOS") = True Then
                If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                    StringImpressao &= Neg(Comp(Dir(dt.Rows.Item(0).Item("Fantasia").ToString, 55))) & vbCrLf
                End If
            Else
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    StringImpressao &= Neg(Comp(Dir(dt.Rows.Item(0).Item("Nome").ToString, 55))) & vbCrLf
                End If
            End If


            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Telefone").ToString, 55)) & vbCrLf
            End If

        End If

        If parOBS.Trim <> "" Then
            StringImpressao &= vbCrLf

            StringImpressao &= Neg(Dir("OBSERVAÇÕES", 55)) & vbCrLf
            StringImpressao &= Comp(Dir(parOBS, 55)) & vbCrLf
        End If


        If AutorizacaoPedido = True Then
            StringImpressao &= vbCrLf
            StringImpressao &= Centralizar("___________________________________") & vbCrLf
            StringImpressao &= Centralizar(dt.Rows.Item(0).Item("Nome").ToString) & vbCrLf
        End If


        StringImpressao &= Centralizar(GerarBarCode(parCodPed)) & vbCrLf

        Rodape(True, StringImpressao)


        Return True

    End Function
    Public Shared Function ImprimePedido2(ByVal parCodPed As Integer, ByVal parCodFor As Integer, ByVal parData As String, ByVal parVendedor As String, ByVal parOBS As String) As Boolean

        Cabecalho()


        Dim dtPed As DataTable = CarregarDataTable("Select CodigoInterno, Produto, ValorUnitario, Qtd, ValorTotal, UM from ItensConsig where CodOrdens =" & parCodPed & " and CodConfig =" & CodConfig)

        StringImpressao &= Esq(parData, 55) & vbCrLf
        StringImpressao &= Exp(Centralizar("Pedido N: " & parCodPed)) & vbCrLf
        StringImpressao &= strTraco & vbCrLf
        StringImpressao &= Comp("CÓDIGO    DESCRIÇÃO                                    ") & vbCrLf
        StringImpressao &= Comp("UN.    QTD.    VL UNIT R$                   VL TOTAL R$") & vbCrLf
        StringImpressao &= strTraco & vbCrLf

        Dim L As Integer
        Dim dblQtd, dblUni, dblTot, dblTotal As Double
        For L = 0 To dtPed.Rows.Count - 1
            Dim strCod, strProd, strQtd, strUM As String

            strCod = dtPed.Rows.Item(L).Item("CodigoInterno").ToString
            strProd = dtPed.Rows.Item(L).Item("Produto").ToString
            dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
            strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
            dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
            strUM = dtPed.Rows.Item(L).Item("UM").ToString
            dblQtd += CDbl(strQtd)
            dblTotal += dblUni * CDbl(strQtd)
            StringImpressao &= Comp(Dir(strCod & "   " & strProd, 55)) & vbCrLf
            Dim str As String
            str = Dir(strUM, 6) & Dir(strQtd & "  X  " & dblUni.ToString("0.00"), 21) & Esq(dblTot.ToString("0.00"), 28)
            StringImpressao &= Comp(str) & vbCrLf
        Next


        StringImpressao &= strTraco & vbCrLf



        If Impressora.Contains("DARUMA") = True Then
            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 33)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 14)) & vbCrLf
        End If

        If Impressora.Contains("BEMATECH") = True Then
            StringImpressao &= Comp(Dir("QTD DE ITENS: " & dblQtd, 29)) & DupLin(Esq("TOTAL R$", 8) & Esq(dblTotal.ToString("####,##0.00"), 11)) & vbCrLf
        End If

        StringImpressao &= vbCrLf & vbCrLf

        StringImpressao &= strTraco & vbCrLf

        If GerarComissao = True Then
            StringImpressao &= Comp(Dir("Vend.: " & parVendedor, 55)) & vbCrLf
        End If

        Dim dt As DataTable

        dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Fornecedor where Codigo =" & parCodFor)

        If dt.Rows.Count > 0 Then

            If NomeEmpresa.Contains("POLI CONGELADOS") = True Then
                If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                    StringImpressao &= Neg(Comp(Dir(dt.Rows.Item(0).Item("Fantasia").ToString, 55))) & vbCrLf
                End If
            Else
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    StringImpressao &= Neg(Comp(Dir(dt.Rows.Item(0).Item("Nome").ToString, 55))) & vbCrLf
                End If
            End If


            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString, 55)) & vbCrLf
            End If

            If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                StringImpressao &= Comp(Dir(dt.Rows.Item(0).Item("Telefone").ToString, 55)) & vbCrLf
            End If

        End If

        If parOBS.Trim <> "" Then
            StringImpressao &= vbCrLf

            StringImpressao &= Neg(Dir("OBSERVAÇÕES", 55)) & vbCrLf
            StringImpressao &= Comp(Dir(parOBS, 55)) & vbCrLf
        End If


        If AutorizacaoPedido = True Then
            StringImpressao &= vbCrLf
            StringImpressao &= Centralizar("___________________________________") & vbCrLf
            StringImpressao &= Centralizar(dt.Rows.Item(0).Item("Nome").ToString) & vbCrLf
        End If


        StringImpressao &= Centralizar(GerarBarCode(parCodPed)) & vbCrLf

        Rodape(True, StringImpressao)


        Return True

    End Function

    Public Shared Function ImprimeCupomTEF(ByVal parComprvante As String) As Boolean

        Cabecalho()
        StringImpressao &= parComprvante & vbCrLf
        RodapeTEF(StringImpressao)

    End Function



    Public Shared Function CodigoBarraSAT(ByVal parString As String) As String
        If ModeloImpSAT.ToUpper.Contains("DARUMA") = True Then
            parString = Chr(27) & Chr(98) + Chr(5) + Chr(2) + Chr(50) + Chr(0) & parString + Chr(0)

        End If

        If ModeloImpSAT.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + Chr(97) + Chr(1) + _
            Chr(29) + Chr(72) + Chr("0") + _
            Chr(29) + Chr(102) + Chr("0") + _
       Chr(29) + Chr(104) + Chr("50") + _
       Chr(29) + Chr(119) + Chr("2") + _
       Chr(29) + Chr(107) + Chr(73) + _
       Chr("46") + Chr(123) + Chr(67) + parString + Chr(0)

        End If
        If ModeloImpSAT.ToUpper.Contains("EPSON") = True Then
            Dim strCodigo As String = parString
            If ((strCodigo.Length Mod 2) <> 0) Then 'Tamanho impar, precisa inserir um 0 a esquerda, pois o CODE128C tem que ser par
                strCodigo = "0" + strCodigo
            End If

            parString = Chr(29) + Chr(119) + Chr(2) + Chr(29) + Chr(72) + Chr(0) + Chr(29) + Chr(104) + Chr(60)
            parString = parString + Chr(29) + Chr(107) + Chr(73) + Chr((strCodigo.Length / 2) + 2) + "{C"

            For i As Integer = 0 To strCodigo.Length - 1 Step 2
                parString = parString + Chr(Convert.ToInt32(strCodigo.Substring(i, 2)))
            Next
            parString = parString + Chr(10)


        End If





        Return parString
    End Function


    
    Public Shared Function QrCodeSAT(ByVal parString As String) As String
        Dim intTamanho As Integer = Len(parString)
        Dim iHigh As Integer = intTamanho
        Dim iLow As Integer = 0
        If intTamanho > 255 Then
            iLow = (intTamanho Mod 255) - 1
        End If

        If ModeloImpSAT.ToUpper.Contains("DARUMA") = True Then

            parString = Chr(27) + Chr(129) + Chr(iLow + 2) + _
         Chr(1) + Chr(4) + Chr(77) + parString

        End If

        If ModeloImpSAT.ToUpper.Contains("BEMATECH") = True Then
            parString = Chr(27) + Chr(97) + Chr(1) + _
             Chr(29) + Chr(107) + Chr(81) + _
             Chr(2) + Chr(6) + Chr(8) + Chr(1) + _
             Chr(iLow) + _
             Chr(1) + parString

        End If
        If ModeloImpSAT.ToUpper.Contains("EPSON") = True Then
            Dim MontaQrCode As String = Chr(29) & Chr(40) & Chr(107) & Chr(4) & Chr(0) & Chr(49) & Chr(65) & Chr(40) & Chr(0) ' & Enter
            Dim sModuloWidth As String = Chr(29) + Chr(40) + Chr(107) + Chr(3) + Chr(0) + Chr(49) + Chr(67) + Chr(48)
            Dim sErrorCorrection As String = Chr(29) + Chr(40) + Chr(107) + Chr(3) + Chr(0) + Chr(49) + Chr(69) + Chr(48)
            Dim sStoreSymbolDate As String = Chr(29) + Chr(40) + Chr(107) + Chr(iLow + 3) + Chr(1) + Chr(49) + Chr(80) + Chr(48)
            Dim sBarCodeData As String = parString
            Dim sPrintQrCodeSymbol As String = Chr(29) + Chr(40) + Chr(107) + Chr(3) + Chr(0) + Chr(49) + Chr(81) + Chr(48)

            parString = MontaQrCode + sModuloWidth + sErrorCorrection + sStoreSymbolDate + sBarCodeData + sPrintQrCodeSymbol


        End If
 


        Return parString
    End Function


End Class
