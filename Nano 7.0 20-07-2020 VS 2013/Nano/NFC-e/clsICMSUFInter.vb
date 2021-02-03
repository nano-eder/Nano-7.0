Public Class clsICMSUFInter

    Public Shared Function AliquotaInterestadual(ByVal parOrigem As String, ByVal parDestino As String) As Double
        Dim dblAliquota As Double = 0

        Select Case parOrigem
            Case "AC"
                Select Case parDestino
                    Case "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "AL"
                Select Case parDestino
                    Case "AC", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "AM"
                Select Case parDestino
                    Case "AC", "AL", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "AP"
                Select Case parDestino
                    Case "AC", "AL", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "BA"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select
            Case "CE"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "DF", "ES", "GO", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select
            Case "DF"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "ES"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "GO", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "GO"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "MA", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "MA"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MT", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "MT"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "MS"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "PA", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "MG"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", _
                    "PA", "PB", "PE", "PI", "RN", "RO", "RR", "SE", "TO"
                        dblAliquota = 7

                    Case "PR", "RS", "RJ", "SC", "SP"
                        dblAliquota = 12
                End Select

            Case "PA"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PB", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "PB"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PA", "PR", "PE", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "PR"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", _
                    "MS", "PA", "PB", "PE", "PI", "RN", "RO", "RR", "SE", "TO"
                        dblAliquota = 7

                    Case "MG", "RS", "RJ", "SC", "SP"
                        dblAliquota = 12
                End Select

            Case "PE"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PA", "PR", "PB", "PI", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "PI"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PA", "PR", "PB", "PE", "RN", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "RN"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PA", "PR", "PB", "PE", "PI", "RS", "RJ", "RO", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "RS"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", _
                    "MS", "PA", "PB", "PE", "PI", "RN", "RO", "RR", "SE", "TO"
                        dblAliquota = 7

                    Case "MG", "PR", "RJ", "SC", "SP"
                        dblAliquota = 12

                End Select

            Case "RJ"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", _
                    "MS", "PA", "PB", "PE", "PI", "RS", "RN", "RO", "RR", "SE", "TO"
                        dblAliquota = 7

                    Case "MG", "PR", "SC", "SP"
                        dblAliquota = 12

                End Select

            Case "RO"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PA", "PR", "PB", "PE", "PI", "RS", "RJ", "RN", "RR", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "RR"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PA", "PR", "PB", "PE", "PI", "RS", "RJ", "RN", "RO", "SC", "SP", "SE", "TO"
                        dblAliquota = 12
                End Select

            Case "SC"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", _
                    "MS", "PA", "PB", "PE", "PI", "RN", "RO", "RR", "SE", "TO"
                        dblAliquota = 7

                    Case "MG", "PR", "RS", "RJ", "SP"
                        dblAliquota = 12
                End Select

            Case "SP"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", _
                    "MS", "PA", "PB", "PE", "PI", "RN", "RO", "RR", "SE", "TO"
                        dblAliquota = 7

                    Case "MG", "PR", "RS", "RJ", "SC"
                        dblAliquota = 12
                End Select
            Case "SE"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PA", "PR", "PB", "PE", "PI", "RS", "RJ", "RN", "RO", "SC", "SP", "RR", "TO"
                        dblAliquota = 12
                End Select
            Case "TO"
                Select Case parDestino
                    Case "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MG", _
                    "MS", "PA", "PR", "PB", "PE", "PI", "RS", "RJ", "RN", "RO", "SC", "SP", "RR", "SE"
                        dblAliquota = 12
                End Select
        End Select
        Return dblAliquota
    End Function

    Public Shared Function AliquotaPartilhaOrigem() As Double
        Dim dblAliquota As Double = 0
        Select Case Year(Date.Today)
            Case "2016"
                dblAliquota = 60
            Case "2017"
                dblAliquota = 40
            Case "2018"
                dblAliquota = 20
            Case "2019"
                dblAliquota = 100
        End Select
        Return dblAliquota
    End Function

    Public Shared Function AliquotaPartilhaDestino() As Double
        Dim dblAliquota As Double = 0
        Select Case Year(Date.Today)
            Case "2016"
                dblAliquota = 40
            Case "2017"
                dblAliquota = 60
            Case "2018"
                dblAliquota = 80
            Case "2019"
                dblAliquota = 100
        End Select
        Return dblAliquota
    End Function
End Class
