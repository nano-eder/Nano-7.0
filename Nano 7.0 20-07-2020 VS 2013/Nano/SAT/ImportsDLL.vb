Imports System.Runtime.InteropServices

Public Class ImportsDLL

    Const DLL = "BemaFI32.dll"

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_VendeItemCompletoJSON(ByVal json As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_ProgramaAliquota(ByVal a As String, ByVal b As Integer) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_HabilitaDesabilitaRetornoEstendidoMFD(act As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_RetornoImpressoraMFD(ByRef a As Integer, ByRef b As Integer, ByRef c As Integer, ByRef d As Integer) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_AbreCupom(CGC_CPF As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_LeituraX() As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_CancelaCupom() As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_ReducaoZ(a As String, b As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_VendeItem(Codigo As String,Descricao As String, Aliquota As String, TipoQuantidade As String,Quantidade As String,CasasDecimais As Integer,ValorUnitario As String,  TipoDesconto As String, Desconto As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_IniciaFechamentoCupomMFD(a As String, b As String, c As String, d As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_IniciaFechamentoCupom(a As String, b As String, c As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_EfetuaFormaPagamento(a As String, b As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_EfetuaFormaPagamentoMFD(a As String, b As String, c As String, d As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_FechaCupom(a As String, b As String, c As String, d As String, e As String, f As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_SubTotalizaCupomMFD() As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_TotalizaCupomMFD() As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_TerminaFechamentoCupom(ByVal a As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_UltimasInformacoesSAT(ByVal a As String, ByVal b As String, ByVal c As String) As Integer
    End Function
    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_RetornaMensagemSeFazSAT(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String) As Integer
    End Function

    <DllImport(DLL)> _
    Public Shared Function Bematech_FI_StatusUltimaNFCe(ByVal s() As Byte) As Integer
    End Function
End Class
