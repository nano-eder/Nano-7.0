Public Class IPI
    Public CST As String
    Public totalProd As Decimal
    Public pIPI As Decimal

    Public vBC As Decimal
    Public vIPI As Decimal
    Sub New()
        CST = ""
        totalProd = 0
        pIPI = 0
        vBC = 0
        vIPI = 0
    End Sub
    Public Sub gerar()
        Select Case CST
            Case "01", "02", "03", "04", "51", "52", "53", "54", "55"
                ' NÃO CALCULA NADA
            Case "00", "49", "50", "99"
                vBC = totalProd
                vIPI = (vBC * pIPI) / 100
        End Select
    End Sub
End Class
