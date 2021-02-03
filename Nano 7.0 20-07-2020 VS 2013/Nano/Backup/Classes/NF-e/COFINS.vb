Public Class COFINS
    Public CST As String
    Public totalProd As Decimal
    Public pCofins As Decimal

    Public vBC As Decimal
    Public vCofins As Decimal
    Sub New()
        CST = ""
        totalProd = 0
        pCofins = 0
        vBC = 0
        vCofins = 0
    End Sub
    Public Sub gerar()
        Select Case CST
            Case "01", "02"
                vBC = totalProd
                vCofins = (vBC * pCofins) / 100
            Case "03"
                'NÃO USADO
            Case "04", "06", "07", "08", "09"
                'TODOS ZERADOS
            Case "99", "98", "49", "50", "51", "52", "53", "54", "55", "56", "60", "61", "62", "63", "64", "65", "66", "67", "70", "71", "72", "73", "74", "75"
                vBC = 0
                vCofins = 0
            Case Else 'pis ST
                'NÃO TEMOS CLIENTES QUE USAM ESSA MODALIDADE
        End Select
    End Sub
End Class
