Public Class clsValidar

    Private dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44", _
                                              "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}
    Private Const msgErro As String = "Dados Inválidos"
    Private bValida As Boolean
    Private sCPF As String
    Private sCNPJ As String

    Public Property cpf() As String

        Get

            Return sCPF

        End Get

        Set(ByVal Valor As String)

            bValida = ValidaCPF(Valor)

            If bValida Then

                sCPF = Valor

            Else
                sCPF = Valor
                ' Throw (New System.ArgumentException(msgErro, "Numero do CPF"))

            End If

        End Set

    End Property

    Public ReadOnly Property isCpfValido() As Boolean

        Get

            bValida = ValidaCPF(cpf)

            If bValida Then

                Return True

            Else

                Return False

            End If

        End Get

    End Property

    Public Property cnpj() As String
        Get
            Return sCNPJ
        End Get
        Set(ByVal Valor As String)
            bValida = ValidaCNPJ(Valor)
            If bValida Then
                sCNPJ = Valor
            Else
                sCNPJ = Valor
                'Throw (New System.ArgumentException(msgErro, "Numero do CNPJ"))
            End If
        End Set
    End Property

    Public ReadOnly Property isCnpjValido() As Boolean
        Get
            bValida = ValidaCNPJ(cnpj)
            If bValida Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Private Function ValidaCPF(ByVal CPF As String) As Boolean

        Dim i, x, n1, n2 As Integer

        CPF = CPF.Trim

        For i = 0 To dadosArray.Length - 1
            If CPF.Length <> 14 Or dadosArray(i).Equals(CPF) Then
                Return False
            End If
        Next

        'remove a maskara
        CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)

        For x = 0 To 1
            n1 = 0

            For i = 0 To 8 + x
                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
            Next

            n2 = 11 - (n1 - (Int(n1 / 11) * 11))

            If n2 = 10 Or n2 = 11 Then n2 = 0

            If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                Return False
            End If
        Next

        Return True

    End Function
    Private Function ValidaCNPJ(ByVal CNPJ As String) As Boolean

        Dim i As Integer
        Dim valida As Boolean

        CNPJ = CNPJ.Trim


        For i = 0 To dadosArray.Length - 1
            If CNPJ.Length <> 18 Or dadosArray(i).Equals(CNPJ) Then
                Return False
            End If
        Next

        'remove a maskara
        CNPJ = CNPJ.Substring(0, 2) + CNPJ.Substring(3, 3) + CNPJ.Substring(7, 3) + CNPJ.Substring(11, 4) + CNPJ.Substring(16)
        valida = efetivaValidacao(CNPJ)

        If valida Then
            ValidaCNPJ = True
        Else
            ValidaCNPJ = False
        End If

    End Function

    Private Function efetivaValidacao(ByVal cnpj As String)
        Dim Numero(13) As Integer
        Dim soma As Integer
        Dim i As Integer
        Dim resultado1 As Integer
        Dim resultado2 As Integer

        For i = 0 To Numero.Length - 1
            Numero(i) = CInt(cnpj.Substring(i, 1))
        Next

        soma = Numero(0) * 5 + Numero(1) * 4 + Numero(2) * 3 + Numero(3) * 2 + Numero(4) * 9 + Numero(5) * 8 + Numero(6) * 7 + _
                   Numero(7) * 6 + Numero(8) * 5 + Numero(9) * 4 + Numero(10) * 3 + Numero(11) * 2

        soma = soma - (11 * (Int(soma / 11)))
        If soma = 0 Or soma = 1 Then
            resultado1 = 0
        Else
            resultado1 = 11 - soma
        End If

        If resultado1 = Numero(12) Then
            soma = Numero(0) * 6 + Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 + _
                         Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
            soma = soma - (11 * (Int(soma / 11)))
            If soma = 0 Or soma = 1 Then
                resultado2 = 0
            Else
                resultado2 = 11 - soma
            End If
            If resultado2 = Numero(13) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Public Shared Function formatacpf(ByVal txtTexto As Object) As Boolean
        If Len(txtTexto.Text) = 3 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 7 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 11 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Function


    Public Shared Function formatacnpj(ByVal txtTexto As Object) As Boolean
        If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 6 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

        If Len(txtTexto.Text) = 10 Then
            txtTexto.Text = txtTexto.Text & "/"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

        If Len(txtTexto.Text) = 15 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Function

    Public Shared Function formataIE(ByVal txtTexto As Object, ByVal pUF As String) As Boolean
        Select Case pUF
            'Case "AC"    ' Acre
            '    If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 6 Then
            '        txtTexto.Text = txtTexto.Text & "."
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    ElseIf Len(txtTexto.Text) = 10 Then
            '        txtTexto.Text = txtTexto.Text & "/"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    ElseIf Len(txtTexto.Text) = 14 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "AM", "GO", "RN", "MT"  ' Amazonas
            '    If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 6 Then
            '        txtTexto.Text = txtTexto.Text & "."
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    ElseIf Len(txtTexto.Text) = 10 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "BA"    ' Bahia
            '    If Len(txtTexto.Text) = 6 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "CE"    ' Ceara
            '    If Len(txtTexto.Text) = 8 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "DF"    ' Distrito Federal
            '    If Len(txtTexto.Text) = 11 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If

            'Case "MG"    ' Minas Gerais
            '    If Len(txtTexto.Text) = 3 Or Len(txtTexto.Text) = 7 Then
            '        txtTexto.Text = txtTexto.Text & "."
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    ElseIf Len(txtTexto.Text) = 11 Then
            '        txtTexto.Text = txtTexto.Text & "/"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "PA"    ' Para
            '    If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 9 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "PB", "PR", "RR" ' Paraiba
            '    If Len(txtTexto.Text) = 8 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "PE"    ' Pernambuco
            '    'If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 4 Or Len(txtTexto.Text) = 8 Then
            '    '    txtTexto.Text = txtTexto.Text & "."
            '    '    txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    'ElseIf Len(txtTexto.Text) = 16 Then
            '    '    txtTexto.Text = txtTexto.Text & "-"
            '    '    txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    'End If
            'Case "RJ"    ' Rio de Janeiro
            '    If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 6 Then
            '        txtTexto.Text = txtTexto.Text & "."
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    ElseIf Len(txtTexto.Text) = 9 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If

            'Case "RO"    ' Rondonia
            '    If Len(txtTexto.Text) = 3 Then
            '        txtTexto.Text = txtTexto.Text & "."
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    ElseIf Len(txtTexto.Text) = 9 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "RS"    ' Rio Grande do Sul
            '    If Len(txtTexto.Text) = 3 Then
            '        txtTexto.Text = txtTexto.Text & "/"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "SC"    ' Santa Catarina
            '    If Len(txtTexto.Text) = 3 Or Len(txtTexto.Text) = 7 Then
            '        txtTexto.Text = txtTexto.Text & "."
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            'Case "SE"    ' Sergipe
            '    If Len(txtTexto.Text) = 9 Then
            '        txtTexto.Text = txtTexto.Text & "-"
            '        txtTexto.SelectionStart = Len(txtTexto.Text) + 1
            '    End If
            Case "SP"    ' São Paulo
                If Len(txtTexto.Text) = 3 Or Len(txtTexto.Text) = 7 Or Len(txtTexto.Text) = 11 Then
                    txtTexto.Text = txtTexto.Text & "."
                    txtTexto.SelectionStart = Len(txtTexto.Text) + 1
                End If
            Case "TO"    ' Tocantins

        End Select
    End Function

    Public Shared Function ChecaInscrE(ByVal pUF As String, ByVal pInscr As String)

        ChecaInscrE = False
        Dim strBase As String
        Dim strBase2 As String
        Dim strOrigem As String
        Dim strDigito1 As String
        Dim strDigito2 As String
        Dim intPos As Integer
        Dim intValor As Integer
        Dim intSoma As Integer
        Dim intResto As Integer
        Dim intNumero As Integer
        Dim intPeso As Integer
        Dim intDig As Integer

        strBase = ""
        strBase2 = ""
        strOrigem = ""
        If Trim(pInscr) = "ISENTO" Then
            ChecaInscrE = True
            Exit Function
        End If
        For intPos = 1 To Len(Trim(pInscr))
            If InStr(1, "0123456789P", Mid$(pInscr, intPos, 1), vbTextCompare) > 0 Then
                strOrigem = strOrigem & Mid$(pInscr, intPos, 1)
            End If
        Next
        Select Case pUF
            'Case "AC"    ' Acre
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    If Left(strBase, 2) = "01" And Mid$(strBase, 3, 2) <> "00" Then
            '        intSoma = 0
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "AL"    ' Alagoas
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    If Left(strBase, 2) = "24" Then
            '        intSoma = 0
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intSoma = intSoma * 10
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto = 10, "0", Str(intResto)), 1)
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "AM"    ' Amazonas
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    intSoma = 0
            '    For intPos = 1 To 8
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * (10 - intPos)
            '        intSoma = intSoma + intValor
            '    Next
            '    If intSoma < 11 Then
            '        strDigito1 = Right(Str(11 - intSoma), 1)
            '    Else
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    End If
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "AP"    ' Amapa
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    intPeso = 0
            '    intDig = 0
            '    If Left(strBase, 2) = "03" Then
            '        intNumero = Val(Left(strBase, 8))
            '        If intNumero >= 3000001 And _
            '        intNumero <= 3017000 Then
            '            intPeso = 5
            '            intDig = 0
            '        ElseIf intNumero >= 3017001 And _
            '            intNumero <= 3019022 Then
            '            intPeso = 9
            '            intDig = 1
            '        ElseIf intNumero >= 3019023 Then
            '            intPeso = 0
            '            intDig = 0
            '        End If
            '        intSoma = intPeso
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 11
            '        intValor = 11 - intResto
            '        If intValor = 10 Then
            '            intValor = 0
            '        ElseIf intValor = 11 Then
            '            intValor = intDig
            '        End If
            '        strDigito1 = Right(Str(intValor), 1)
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "BA"    ' Bahia
            '    strBase = Left(Trim(strOrigem) & "00000000", 8)
            '    If InStr(1, "0123458", Left(strBase, 1), vbTextCompare) > 0 Then
            '        intSoma = 0
            '        For intPos = 1 To 6
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (8 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 10
            '        strDigito2 = Right(IIf(intResto = 0, "0", Str(10 - intResto)), 1)
            '        strBase2 = Left(strBase, 6) & strDigito2
            '        intSoma = 0
            '        For intPos = 1 To 7
            '            intValor = Val(Mid$(strBase2, intPos, 1))
            '            intValor = intValor * (9 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 10
            '        strDigito1 = Right(IIf(intResto = 0, "0", Str(10 - intResto)), 1)
            '    Else
            '        intSoma = 0
            '        For intPos = 1 To 6
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (8 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 11
            '        strDigito2 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '        strBase2 = Left(strBase, 6) & strDigito2
            '        intSoma = 0
            '        For intPos = 1 To 7
            '            intValor = Val(Mid$(strBase2, intPos, 1))
            '            intValor = intValor * (9 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    End If
            '    strBase2 = Left(strBase, 6) & strDigito1 & strDigito2
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "CE"    ' Ceara
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    intSoma = 0
            '    For intPos = 1 To 8
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * (10 - intPos)
            '        intSoma = intSoma + intValor
            '    Next
            '    intResto = intSoma Mod 11
            '    intValor = 11 - intResto
            '    If intValor > 9 Then
            '        intValor = 0
            '    End If
            '    strDigito1 = Right(Str(intValor), 1)
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "DF"    ' Distrito Federal
            '    strBase = Left(Trim(strOrigem) & "0000000000000", 13)
            '    If Left(strBase, 3) = "073" Then
            '        intSoma = 0
            '        intPeso = 2
            '        For intPos = 11 To 1 Step -1
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * intPeso
            '            intSoma = intSoma + intValor
            '            intPeso = intPeso + 1
            '            If intPeso > 9 Then
            '                intPeso = 2
            '            End If
            '        Next
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '        strBase2 = Left(strBase, 11) & strDigito1
            '        intSoma = 0
            '        intPeso = 2
            '        For intPos = 12 To 1 Step -1
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * intPeso
            '            intSoma = intSoma + intValor
            '            intPeso = intPeso + 1
            '            If intPeso > 9 Then
            '                intPeso = 2
            '            End If
            '        Next
            '        intResto = intSoma Mod 11
            '        strDigito2 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '        strBase2 = Left(strBase, 12) & strDigito2
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "ES"    ' Espirito Santo
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    intSoma = 0
            '    For intPos = 1 To 8
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * (10 - intPos)
            '        intSoma = intSoma + intValor
            '    Next
            '    intResto = intSoma Mod 11
            '    strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "GO"    ' Goias
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    If InStr(1, "10,11,15", Left(strBase, 2), vbTextCompare) > 0 Then
            '        intSoma = 0
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 11
            '        If intResto = 0 Then
            '            strDigito1 = "0"
            '        ElseIf intResto = 1 Then
            '            intNumero = Val(Left(strBase, 8))
            '            strDigito1 = Right(IIf(intNumero >= 10103105 And intNumero <= 10119997, "1", "0"), 1)
            '        Else
            '            strDigito1 = Right(Str(11 - intResto), 1)
            '        End If
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "MA"    ' Maranhão
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    If Left(strBase, 2) = "12" Then
            '        intSoma = 0
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "MT"    ' Mato Grosso
            '    While Len(strOrigem) < 11
            '        strOrigem = "0" & strOrigem
            '    End While
            '    strBase = Left(Trim(strOrigem) & "000000000", 11)
            '    Dim d01 As Integer = CInt(Mid(strBase, 1, 1))
            '    Dim d02 As Integer = CInt(Mid(strBase, 2, 1))
            '    Dim d03 As Integer = CInt(Mid(strBase, 3, 1))
            '    Dim d04 As Integer = CInt(Mid(strBase, 4, 1))
            '    Dim d05 As Integer = CInt(Mid(strBase, 5, 1))
            '    Dim d06 As Integer = CInt(Mid(strBase, 6, 1))
            '    Dim d07 As Integer = CInt(Mid(strBase, 7, 1))
            '    Dim d08 As Integer = CInt(Mid(strBase, 8, 1))
            '    Dim d09 As Integer = CInt(Mid(strBase, 9, 1))
            '    Dim d10 As Integer = CInt(Mid(strBase, 10, 1))
            '    Dim dfinal As Integer = CInt(Mid(strBase, 11, 1))
            '    Dim ds As Integer = 3 * d01 + 2 * d02 + 9 * d03 + 8 * d04 + 7 * d05 + 6 * d06 + 5 * d07 + 4 * d08 + _
            '                       3 * d09 + 2 * d10
            '    Dim aux1 As Integer = Fix(ds / 11)
            '    aux1 = aux1 * 11
            '    Dim aux2 As Integer = ds - aux1
            '    Dim digVerificador As Integer
            '    If aux2 = 0 Or aux2 = 1 Then
            '        digVerificador = 0
            '    Else
            '        digVerificador = 11 - aux2
            '    End If
            '    If dfinal = digVerificador Then
            '        ChecaInscrE = True
            '    End If
            'Case "MS"    ' Mato Grosso do Sul
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    If Left(strBase, 2) = "28" Then
            '        intSoma = 0
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "MG"    ' Minas Gerais
            '    strBase = Left(Trim(strOrigem) & "0000000000000", 13)
            '    strBase2 = Left(strBase, 3) & "0" & Mid$(strBase, 4, 8)
            '    intNumero = 2
            '    For intPos = 1 To 12
            '        intValor = Val(Mid$(strBase2, intPos, 1))
            '        intNumero = IIf(intNumero = 2, 1, 2)
            '        intValor = intValor * intNumero
            '        If intValor > 9 Then
            '            strDigito1 = Format(intValor, "00")
            '            intValor = Val(Left(strDigito1, 1)) + _
            '                          Val(Right(strDigito1, 1))
            '        End If
            '        intSoma = intSoma + intValor
            '    Next
            '    intValor = intSoma
            '    While Right(Format(intValor, "000"), 1) <> "0"
            '        intValor = intValor + 1
            '    End While
            '    strDigito1 = Right(Format(intValor - intSoma, "00"), 1)
            '    strBase2 = Left(strBase, 11) & strDigito1
            '    intSoma = 0
            '    intPeso = 2
            '    For intPos = 12 To 1 Step -1
            '        intValor = Val(Mid$(strBase2, intPos, 1))
            '        intValor = intValor * intPeso
            '        intSoma = intSoma + intValor
            '        intPeso = intPeso + 1
            '        If intPeso > 11 Then
            '            intPeso = 2
            '        End If
            '    Next
            '    intResto = intSoma Mod 11
            '    strDigito2 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    strBase2 = strBase2 & strDigito2
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "PA"    ' Para
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    If Left(strBase, 2) = "15" Then
            '        intSoma = 0
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "PB"    ' Paraiba
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    intSoma = 0
            '    For intPos = 1 To 8
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * (10 - intPos)
            '        intSoma = intSoma + intValor
            '    Next
            '    intResto = intSoma Mod 11
            '    intValor = 11 - intResto
            '    If intValor > 9 Then
            '        intValor = 0
            '    End If
            '    strDigito1 = Right(Str(intValor), 1)
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "PE"    ' Pernambuco
            '    'strBase = Left(Trim(strOrigem) & "00000000000000", 14)
            '    'intSoma = 0
            '    'intPeso = 2
            '    'For intPos = 13 To 1 Step -1
            '    '    intValor = Val(Mid$(strBase, intPos, 1))
            '    '    intValor = intValor * intPeso
            '    '    intSoma = intSoma + intValor
            '    '    intPeso = intPeso + 1
            '    '    If intPeso > 9 Then
            '    '        intPeso = 2
            '    '    End If
            '    'Next
            '    'intResto = intSoma Mod 11
            '    'intValor = 11 - intResto
            '    'If intValor > 9 Then
            '    '    intValor = intValor - 10
            '    'End If
            '    'strDigito1 = Right(Str(intValor), 1)
            '    'strBase2 = Left(strBase, 13) & strDigito1
            '    'If strBase2 = strOrigem Then
            '    ChecaInscrE = True
            '    'End If
            'Case "PI"    ' Piaui
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    intSoma = 0
            '    For intPos = 1 To 8
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * (10 - intPos)
            '        intSoma = intSoma + intValor
            '    Next
            '    intResto = intSoma Mod 11
            '    strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "PR"    ' Parana
            '    strBase = Left(Trim(strOrigem) & "0000000000", 10)
            '    intSoma = 0
            '    intPeso = 2
            '    For intPos = 8 To 1 Step -1
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * intPeso
            '        intSoma = intSoma + intValor
            '        intPeso = intPeso + 1
            '        If intPeso > 7 Then
            '            intPeso = 2
            '        End If
            '    Next
            '    intResto = intSoma Mod 11
            '    strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    intSoma = 0
            '    intPeso = 2
            '    For intPos = 9 To 1 Step -1
            '        intValor = Val(Mid$(strBase2, intPos, 1))
            '        intValor = intValor * intPeso
            '        intSoma = intSoma + intValor
            '        intPeso = intPeso + 1
            '        If intPeso > 7 Then
            '            intPeso = 2
            '        End If
            '    Next
            '    intResto = intSoma Mod 11
            '    strDigito2 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    strBase2 = strBase2 & strDigito2
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "RJ"    ' Rio de Janeiro
            '    strBase = Left(Trim(strOrigem) & "00000000", 8)
            '    intSoma = 0
            '    intPeso = 2
            '    For intPos = 7 To 1 Step -1
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * intPeso
            '        intSoma = intSoma + intValor
            '        intPeso = intPeso + 1
            '        If intPeso > 7 Then
            '            intPeso = 2
            '        End If
            '    Next
            '    intResto = intSoma Mod 11
            '    strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    strBase2 = Left(strBase, 7) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "RN"    ' Rio Grande do Norte
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    If Left(strBase, 2) = "20" Then
            '        intSoma = 0
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intSoma = intSoma * 10
            '        intResto = intSoma Mod 11
            '        strDigito1 = Right(IIf(intResto > 9, "0", Str(intResto)), 1)
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "RO"    ' Rondonia
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    strBase2 = Mid$(strBase, 4, 5)
            '    intSoma = 0
            '    For intPos = 1 To 5
            '        intValor = Val(Mid$(strBase2, intPos, 1))
            '        intValor = intValor * (7 - intPos)
            '        intSoma = intSoma + intValor
            '    Next
            '    intResto = intSoma Mod 11
            '    intValor = 11 - intResto
            '    If intValor > 9 Then
            '        intValor = intValor - 10
            '    End If
            '    strDigito1 = Right(Str(intValor), 1)
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "RR"    ' Roraima
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    If Left(strBase, 2) = "24" Then
            '        intSoma = 0
            '        For intPos = 1 To 8
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * (10 - intPos)
            '            intSoma = intSoma + intValor
            '        Next
            '        intResto = intSoma Mod 9
            '        strDigito1 = Right(Str(intResto), 1)
            '        strBase2 = Left(strBase, 8) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "RS"    ' Rio Grande do Sul
            '    strBase = Left(Trim(strOrigem) & "0000000000", 10)
            '    intNumero = Val(Left(strBase, 3))
            '    If intNumero > 0 And intNumero < 468 Then
            '        intSoma = 0
            '        intPeso = 2
            '        For intPos = 9 To 1 Step -1
            '            intValor = Val(Mid$(strBase, intPos, 1))
            '            intValor = intValor * intPeso
            '            intSoma = intSoma + intValor
            '            intPeso = intPeso + 1
            '            If intPeso > 9 Then
            '                intPeso = 2
            '            End If
            '        Next
            '        intResto = intSoma Mod 11
            '        intValor = 11 - intResto
            '        If intValor > 9 Then
            '            intValor = 0
            '        End If
            '        strDigito1 = Right(Str(intValor), 1)
            '        strBase2 = Left(strBase, 9) & strDigito1
            '        If strBase2 = strOrigem Then
            '            ChecaInscrE = True
            '        End If
            '    End If
            'Case "SC"    ' Santa Catarina
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    intSoma = 0
            '    For intPos = 1 To 8
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * (10 - intPos)
            '        intSoma = intSoma + intValor
            '    Next
            '    intResto = intSoma Mod 11
            '    strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            'Case "SE"    ' Sergipe
            '    strBase = Left(Trim(strOrigem) & "000000000", 9)
            '    intSoma = 0
            '    For intPos = 1 To 8
            '        intValor = Val(Mid$(strBase, intPos, 1))
            '        intValor = intValor * (10 - intPos)
            '        intSoma = intSoma + intValor
            '    Next
            '    intResto = intSoma Mod 11
            '    intValor = 11 - intResto
            '    If intValor > 9 Then
            '        intValor = 0
            '    End If
            '    strDigito1 = Right(Str(intValor), 1)
            '    strBase2 = Left(strBase, 8) & strDigito1
            '    If strBase2 = strOrigem Then
            '        ChecaInscrE = True
            '    End If
            Case "SP"    ' São Paulo
                If Left(strOrigem, 1) = "P" Then
                    strBase = Left(Trim(strOrigem) & "0000000000000", 13)
                    strBase2 = Mid$(strBase, 2, 8)
                    intSoma = 0
                    intPeso = 1
                    For intPos = 1 To 8
                        intValor = Val(Mid$(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso = 2 Then
                            intPeso = 3
                        End If
                        If intPeso = 9 Then
                            intPeso = 10
                        End If
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(Str(intResto), 1)
                    strBase2 = Left(strBase, 8) & strDigito1 & Mid$(strBase, 11, 3)
                Else
                    strBase = Left(Trim(strOrigem) & "000000000000", 12)
                    intSoma = 0
                    intPeso = 1
                    For intPos = 1 To 8
                        intValor = Val(Mid$(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso = 2 Then
                            intPeso = 3
                        End If
                        If intPeso = 9 Then
                            intPeso = 10
                        End If
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(Str(intResto), 1)
                    strBase2 = Left(strBase, 8) & strDigito1 & Mid$(strBase, 10, 2)
                    intSoma = 0
                    intPeso = 2
                    For intPos = 11 To 1 Step -1
                        intValor = Val(Mid$(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso > 10 Then
                            intPeso = 2
                        End If
                    Next
                    intResto = intSoma Mod 11
                    strDigito2 = Right(Str(intResto), 1)
                    strBase2 = strBase2 & strDigito2
                End If
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "TO"    ' Tocantins
                strBase = Left(Trim(strOrigem) & "00000000000", 11)
                If InStr(1, "01,02,03,99", Mid$(strBase, 3, 2), vbTextCompare) > 0 Then
                    strBase2 = Left(strBase, 2) & Mid$(strBase, 5, 6)
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = Val(Mid$(strBase2, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", Str(11 - intResto)), 1)
                    strBase2 = Left(strBase, 10) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If

            Case Else
                ChecaInscrE = True
        End Select

    End Function

End Class
