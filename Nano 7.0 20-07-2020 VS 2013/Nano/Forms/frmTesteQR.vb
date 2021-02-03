Imports System.IO
Imports System.Text
Public Class frmTesteQR

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim I As Integer
        Dim strQrCode As String = "35180108723218000186599000070680000436173103|20180110160446|48.19||FMUtd1DTZKnG8AmOSxIGv//W8qpN/AO31ITzu2yQCx8SFLgBygvFvgUz6DFe/dqB3tWPAl5/l6urJD7lDc9LwelI7UUo0rm323MBt9S//59TCzfUPUHuzwkc06QmrHiIBw870U66D9HVFhl/kXsyAyQlVrldBLAgfQ714++Jgcs5UtLaGiE8Rrip239vtAwBHRpXDaHgWaITAKNHyECgm4ynM5q9j5GBVpRtU75BXX/tvf/ElREdqwLyejxP3cfZQ61QPMG9A0bbJnvysO2NnY2W4NVL6JO+CnYgk/W8o6SH/YqG+6ky7CSnV3FM9i8sGoif7HfXCNyD25zM5IOSDg=="
        strQrCode = "35180108723218000186599000070680000511330959|20180123144650|100.00|36970939839|g44BbWGPYoUJKlQvb9f4LAC+NSDWxyWYejWaF1cGM29bHOYVZqZQcZDYJgJDoBF3QW5bL/Karne1P+RzOh9/aFzWhESJVQP8BfbP3pSHVoiMOTxerLuZL5F34ZOmjHj4vGmsjQLDfBrXcS39hlUDHm70OQtcABOWS5vM9MbNlCyDAiBO80U3ZggSF0AJ6O7a4pJU7UYJY7vFonUTMDRdkkSqyWjSSYNjxED1M4TkQYU5x9cg6i9A5o+HZZyZbSPHrcd4o+EoZrJCb4xqCa0mFN2VDYR8zqqkPTKCLqSaIvOlaTY8LocuWZUVFIKjvhn4i60Ea+tAFIG5lNo5AVDL7g=="
        'Dim strTeste As String = ""

        'Dim texto As Byte() = UnicodeStringToBytes(strQrCode)

        'For I = 0 To texto.Length - 1
        '    strTeste &= texto(I) & "|"
        'Next
        'strTeste = ""
        'Dim qrcode As Byte() = {29, 107, 81}
        'Dim dimensao As Byte() = {1, 0, 10, 1}
        'Dim resto_divisao As Integer = texto.Length
        'If texto.Length > 255 Then
        '    resto_divisao = texto.Length Mod 255
        'End If
        'Dim resto_divisao_byte As Byte = CByte(resto_divisao)
        'Dim divisao As Integer = 0
        'If texto.Length > 255 Then
        '    divisao = texto.Length / 255
        'End If
        'Dim divisao_byte As Byte = CByte(divisao)
        'Dim len As Integer = qrcode.Length + dimensao.Length + 1 + 1 + texto.Length
        'Dim toprint As Byte() = New Byte(len - 1) {}
        'Dim last_pos_qrcode As Integer = qrcode.Length
        'Dim last_pos_dimensao As Integer = qrcode.Length + dimensao.Length
        'Dim last_pos_rest_div As Integer = last_pos_dimensao + 1
        'Dim last_pos_divisao As Integer = last_pos_rest_div + 1

        'Dim strStringQr As String = ""
        'For I = 0 To len - 1
        '    If (I < last_pos_qrcode) Then
        '        toprint(I) = qrcode(I)
        '        strStringQr &= qrcode(I) & "|"
        '    ElseIf (I < last_pos_dimensao) Then
        '        toprint(I) = dimensao(I - last_pos_qrcode)
        '        strStringQr &= dimensao(I - last_pos_qrcode) & "|"
        '    ElseIf (I < last_pos_rest_div) Then
        '        toprint(I) = resto_divisao_byte
        '        strStringQr &= resto_divisao_byte & "|"
        '    ElseIf (I < last_pos_divisao) Then
        '        toprint(I) = divisao_byte
        '        strStringQr &= divisao_byte & "|"
        '    Else
        '        toprint(I) = texto(I - last_pos_divisao)
        '        strStringQr &= texto(I - last_pos_divisao) & "|"
        '    End If
        'Next
        'Impressora = "BEMATECH"
        'strTeste = clsImprimir.Comp(clsImprimir.Centralizar("DOCUMENTO NÃO FISCAL")) & vbCrLf
        'strTeste &= clsImprimir.Comp(clsImprimir.Centralizar("DOCUMENTO NÃO FISCAL")) & vbCrLf
        'strTeste &= clsImprimir.Comp(clsImprimir.Centralizar("DOCUMENTO NÃO FISCAL")) & vbCrLf
        'strTeste &= clsImprimir.Comp(clsImprimir.Centralizar("DOCUMENTO NÃO FISCAL")) & vbCrLf
        'strTeste &= clsImprimir.Comp(clsImprimir.Centralizar("DOCUMENTO NÃO FISCAL")) & vbCrLf
        'strTeste &= clsImprimir.Comp(clsImprimir.Centralizar("DOCUMENTO NÃO FISCAL")) & vbCrLf
        'clsImprimir.SendStringToPrinter("MP-4200 TH", strTeste)

        'strTeste = clsImprimir.Centralizar(UnicodeBytesToString(toprint))
        'strTeste &= clsImprimir.Centralizar(strTeste)
        Dim strttt As String = "Teste QrCode"
        Dim qrcode As String
        Dim intTamanho As Integer = Len(strQrCode)
        Dim iHigh As Integer = intTamanho
        If intTamanho > 255 Then
            iHigh = intTamanho / 255
        End If
        Dim iLow As Integer = 0
        If intTamanho > 255 Then
            iLow = (intTamanho Mod 255) - 1
        End If



        qrcode = Chr(27) + Chr(97) + Chr(1) + _
        Chr(29) + Chr(107) + Chr(81) + _
        Chr(2) + Chr(6) + Chr(8) + Chr(1) + _
        Chr(170) + _
        Chr(1) + strQrCode


    

        Impressora = "EPSON"
        Dim strTeste As String = clsImprimir.Comp(clsImprimir.Centralizar("DOCUMENTO NAO FISCAL")) & vbCrLf
        clsImprimir.SendStringToPrinter("EPSON", strTeste)
        clsImprimir.SendStringToPrinter("EPSON", qrcode)
        clsImprimir.SendStringToPrinter("EPSON", strTeste)


        Dim sCenter As String = Chr(27) + Chr(97) + Chr(1)
        Dim MontaQrCode As String = Chr(29) & Chr(40) & Chr(107) & Chr(4) & Chr(0) & Chr(49) & Chr(65) & Chr(50) & Chr(0) ' & Enter
        Dim sModuloWidth As String = Chr(29) + Chr(40) + Chr(107) + Chr(3) + Chr(0) + Chr(49) + Chr(67) + Chr(48)
        Dim sErrorCorrection As String = Chr(29) + Chr(40) + Chr(107) + Chr(3) + Chr(0) + Chr(49) + Chr(69) + Chr(48)
        Dim sStoreSymbolDate As String = Chr(29) + Chr(40) + Chr(107) + Chr(170) + Chr(1) + Chr(49) + Chr(80) + Chr(48)
        Dim sBarCodeData As String = strQrCode
        Dim sPrintQrCodeSymbol As String = Chr(29) + Chr(40) + Chr(107) + Chr(3) + Chr(0) + Chr(49) + Chr(81) + Chr(48)

        Dim sComando As String = sCenter + MontaQrCode + sModuloWidth + sErrorCorrection + sStoreSymbolDate + sBarCodeData + sPrintQrCodeSymbol

        clsImprimir.SendStringToPrinter("EPSON", strTeste)
        clsImprimir.SendStringToPrinter("EPSON", sComando)
        clsImprimir.SendStringToPrinter("EPSON", strTeste)

        clsImprimir.SendStringToPrinter("EPSON", strTeste)


        'Dim texto As Byte() = UnicodeStringToBytes(strQrCode)

        'For I = 0 To texto.Length - 1
        '    strTeste &= texto(I) & "|"
        'Next
        'strTeste = ""
        'Dim qrcode1 As Byte() = {29, 107, 81}
        'Dim dimensao As Byte() = {2, 8, 16, 1}
        'Dim resto_divisao As Integer = texto.Length
        'If texto.Length > 255 Then
        '    resto_divisao = texto.Length Mod 255
        'End If
        'Dim resto_divisao_byte As Byte = CByte(resto_divisao)
        'Dim divisao As Integer = 0
        'If texto.Length > 255 Then
        '    divisao = 1 'texto.Length / 255
        'End If
        'Dim divisao_byte As Byte = CByte(divisao)
        'Dim len As Integer = qrcode1.Length + dimensao.Length + 1 + 1 + texto.Length
        'Dim toprint As Byte() = New Byte(len - 1) {}
        'Dim last_pos_qrcode As Integer = qrcode1.Length
        'Dim last_pos_dimensao As Integer = qrcode1.Length + dimensao.Length
        'Dim last_pos_rest_div As Integer = last_pos_dimensao + 1
        'Dim last_pos_divisao As Integer = last_pos_rest_div + 1

        'Dim strStringQr As String = ""
        'For I = 0 To len - 1
        '    If (I < last_pos_qrcode) Then
        '        toprint(I) = qrcode1(I)
        '        strStringQr &= qrcode1(I) & "|"
        '    ElseIf (I < last_pos_dimensao) Then
        '        toprint(I) = dimensao(I - last_pos_qrcode)
        '        strStringQr &= dimensao(I - last_pos_qrcode) & "|"
        '    ElseIf (I < last_pos_rest_div) Then
        '        toprint(I) = resto_divisao_byte
        '        strStringQr &= resto_divisao_byte & "|"
        '    ElseIf (I < last_pos_divisao) Then
        '        toprint(I) = divisao_byte
        '        strStringQr &= divisao_byte & "|"
        '    Else
        '        toprint(I) = texto(I - last_pos_divisao)
        '        strStringQr &= texto(I - last_pos_divisao) & "|"
        '    End If
        'Next

        'clsImprimir.SendStringToPrinter("MP-4200 TH", strTeste)
        'clsImprimir.SendStringToPrinter("MP-4200 TH", clsImprimir.Centralizar(UnicodeBytesToString(toprint)))
        'clsImprimir.SendStringToPrinter("MP-4200 TH", strTeste)
        Dim qrcode1 As String
        qrcode1 = Chr(29) + Chr(107) + Chr(81) + _
        Chr(2) + Chr(12) + Chr(8) + Chr(1) + _
        Chr("20") + _
        Chr(0) + _
        "leandrolimongebastos"
        clsImprimir.SendStringToPrinter("EPSON", strTeste)
        clsImprimir.SendStringToPrinter("EPSON", qrcode1)
        Dim intTamanho1 As Integer = Len(strQrCode) + 3
        'qrcode1 = Chr(29) + "(k" + Chr(4) + Chr(0) + "1A2" + Chr(0) + _
        '             Chr(29) + "(k" + Chr(3) + Chr(0) + "1C" + Chr(4) + _
        '             Chr(29) + "(k" + Chr(3) + Chr(0) + "1E0" + _
        '             Chr(29) + "(k" + Chr(170) + "1P0" + strQrCode + _
        '             Chr(29) + "(k" + Chr(3) + Chr(0) + "1Q0"

        '//GS ( k <function 167> size of module 
        qrcode1 = "#29#40#107#03#00#49#67#07" + _
               "#29#40#107" + Chr((Len(strQrCode) Mod 256) + 3) + Chr(Len(strQrCode) / 256) + "#49#80#48" + strQrCode + "#10" + _
               "#29#40#107#03#00#49#81#48"

        clsImprimir.SendStringToPrinter("EPSON", strTeste)
        clsImprimir.SendStringToPrinter("EPSON", qrcode1)

    End Sub
    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()

        Return System.Text.Encoding.Default.GetBytes(str)
    End Function
    Private Function UnicodeBytesToString(ByVal bytes() As Byte) As String

        Return System.Text.Encoding.Default.GetString(bytes)
    End Function

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim fluxoTexto As IO.StreamReader
        Dim strTexto As String = ""
        ModeloImpSAT = "ESC/POS"
        Impressora = "BEMATECH"
        If IO.File.Exists("C:\SAT\Autorizadas\CFe35180108723218000186599000070680000436173103.xml") Then
            fluxoTexto = New IO.StreamReader("C:\SAT\Autorizadas\CFe35180108723218000186599000070680000436173103.xml")
            strTexto = fluxoTexto.ReadToEnd
            fluxoTexto.Close()
        End If
        If strTexto.Contains("</KeyInfo></Signature></CFe>") = True Then
            GerarSat.GerarCupomSat(strTexto, "")

        ElseIf strTexto.Contains("</KeyInfo></Signature></CFeCanc>") = True Then
            GerarSat.GerarCupomCancelamentoSat(strTexto, "")

        End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim StringImpressao As String
        Impressora = "EPSON"
        StringImpressao = clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("3518 0108 7232 1800 0186 5990 0007 0680 0004 3617 3103"))) & vbCrLf
        'StringImpressao &= Chr(29) + Chr(107) + Chr(73) + Chr("44") + "35180108723218000186599000070680000436173103" & vbCrLf
        clsImprimir.SendStringToPrinter("EPSON", StringImpressao)

        StringImpressao = Chr(27) + Chr(97) + Chr(1) + _
        Chr(29) + Chr(107) + Chr(73) + _
        Chr("44") + "35180108723218000186599000070680000436173103" + Chr(0)


        StringImpressao = Chr(29) + Chr(72) + Chr("0") + _
            Chr(29) + Chr(102) + Chr("0") + _
       Chr(29) + Chr(104) + Chr("50") + _
       Chr(29) + Chr(119) + Chr("2") + _
       Chr(29) + Chr(107) + Chr(73) + _
       Chr("46") + "35180108723218000186599000070680000436173103" + "{C"
        ' StringImpressao = Chr(29) + Chr(107) + Chr(73) + Chr("7") + "0101" + Chr(0)
        clsImprimir.SendStringToPrinter("EPSON", clsImprimir.Comp(StringImpressao))
        Dim strTeste As String = clsImprimir.Comp(clsImprimir.Centralizar("DOCUMENTO NAO FISCAL")) & vbCrLf
        clsImprimir.SendStringToPrinter("EPSON", strTeste)



        Dim Temp, Cmd1 As String
        Dim dividido As Boolean
        Dim Largura As Integer
        Dim HRI As Integer
        Dim Altura As Integer

        'Inicia as variáveis
        dividido = False
        Temp = "35180108723218000186599000070680000436173103"
        Largura = 2 'Largura do código de barras, pode variar de 2 a 6, sendo 2 a mais fina e 6 a mais grossa
        HRI = 0     'Posição da impressão dos caracteres do código: 0-Não imprime, 1-Acima, 2-Abaixo, 3-Acima e Abaixo
        Altura = 60 'Altura do código de barras, pode variar entre 1 a 255

        Cmd1 = Chr(29) + Chr(119) + Chr(Largura) + Chr(29) + Chr(72) + Chr(HRI) + Chr(29) + Chr(104) + Chr(Altura)

        If ((Temp.Length Mod 2) <> 0) Then 'Tamanho impar, precisa inserir um 0 a esquerda, pois o CODE128C tem que ser par
            Temp = "0" + Temp
        End If

        If (Temp.Length > 42) Then 'Se for maior que 42, divide em 2 códigos
            dividido = True

            Cmd1 = Cmd1 + Chr(29) + Chr(107) + Chr(73) + Chr(((Temp.Length / 2) / 2) + 2) + "{C"

            For i As Integer = 0 To (Temp.Length / 2) - 1 Step 2
                Cmd1 = Cmd1 + Chr(Convert.ToInt32(Temp.Substring(i, 2)))
            Next
            Cmd1 = Cmd1 + Chr(10) + Chr(29) + Chr(107) + Chr(73) + Chr(((Temp.Length / 2) / 2) + 2) + "{C"
            For i As Integer = (Temp.Length / 2) To Temp.Length - 1 Step 2
                Cmd1 = Cmd1 + Chr(Convert.ToInt32(Temp.Substring(i, 2)))
            Next
            Cmd1 = Cmd1 + Chr(10)
        Else
            dividido = False

            Cmd1 = Chr(29) + Chr(119) + Chr(2) + Chr(29) + Chr(72) + Chr(1)
            Cmd1 = Chr(29) + Chr(107) + Chr(73) + Chr((Temp.Length / 2) + 2) + "{C"

            For i As Integer = 0 To Temp.Length - 1 Step 2
                Cmd1 = Cmd1 + Chr(Convert.ToInt32(Temp.Substring(i, 2)))
            Next
            Cmd1 = Cmd1 + Chr(10)
        End If

        clsImprimir.SendStringToPrinter("EPSON", clsImprimir.Comp(Cmd1))
    End Sub
End Class

