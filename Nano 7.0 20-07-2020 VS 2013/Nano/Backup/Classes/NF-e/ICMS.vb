Public Class ICMS
    Public totalProd As Decimal
    Public CST As String
    Public IPI As Decimal

    ' ICMS PROPRIO
    Public bcEstabelecida As Decimal ' Pauta ou Preço Tabelado Produto
    Public modBC As String
    Public pRedBC As Decimal
    Public pICMS As Decimal
    Public mva As Decimal

    ' ICMS SUBST TRIBUTARIA
    Public bcEstabelecidaST As Decimal ' Pauta ou Preço Tabelado Produto
    Public modBCST As String
    Public pRedBCST As Decimal
    Public pICMSST As Decimal
    Public mvaST As Decimal

    ' RETORNADO
    Public vBC As Decimal
    Public vICMS As Decimal
    Public vBCST As Decimal
    Public vICMSST As Decimal

    Sub New()
        totalProd = 0
        CST = ""
        IPI = 0
        bcEstabelecida = 0
        modBC = ""
        pRedBC = 0
        pICMS = 0
        mva = 0
        bcEstabelecidaST = 0
        modBCST = ""
        pRedBCST = 0
        pICMSST = 0
        mvaST = 0
        vBC = 0
        vICMS = 0
        vBCST = 0
        vICMSST = 0
    End Sub
    Public Sub gerar()
        Select Case CST
            Case "00"
                'ICMS
                If modBC = "0" Then ' Margem Valor Agregado
                    vBC = totalProd + ((totalProd * mva) / 100)
                ElseIf (modBC = "1") Or (modBC = "2") Then ' Pauta ou Preço Tabelado
                    vBC = bcEstabelecida
                Else ' Valor da Operação
                    vBC = totalProd
                End If
                vICMS = (vBC * pICMS) / 100

            Case "10"
                If modBC = "0" Then ' Margem Valor Agregado
                    vBC = totalProd + ((totalProd * mva) / 100)
                ElseIf (modBC = "1") Or (modBC = "2") Then ' Pauta ou Preço Tabelado
                    vBC = bcEstabelecida
                Else ' Valor da Operação
                    vBC = totalProd
                End If
                vICMS = (vBC * pICMS) / 100

                If (modBCST = "0") Or (modBCST = "1") Or (modBCST = "2") Or (modBCST = "3") Or (modBCST = "5") Then ' Pauta ou Preço Tabelado
                    vBCST = bcEstabelecidaST + IPI
                Else
                    vBCST = (vBC + IPI) + (((vBC + IPI) * mvaST) / 100)
                End If

                vICMSST = ((vBCST * pICMSST) / 100) - vICMS



            Case "20"
                If modBC = "0" Then ' Margem Valor Agregado
                    vBC = totalProd + ((totalProd * mva) / 100)
                ElseIf (modBC = "1") Or (modBC = "2") Then ' Pauta ou Preço Tabelado
                    vBC = bcEstabelecida
                Else ' Valor da Operação
                    vBC = totalProd
                End If
                vBC = (vBC * pRedBC) / 100
                vICMS = (vBC * pICMS) / 100

            Case "30"
                Dim vBC_Int, vICMS_Int As Decimal
                vBC_Int = totalProd
                vICMS_Int = (vBC_Int * pICMS) / 100

                If (modBCST = "0") Or (modBCST = "1") Or (modBCST = "2") Or (modBCST = "3") Or (modBCST = "5") Then ' Pauta ou Preço Tabelado
                    vBCST = bcEstabelecidaST
                Else
                    vBCST = vBC_Int + ((vBC_Int * mvaST) / 100)
                End If
                vICMSST = ((vBCST * pICMSST) / 100) - vICMS_Int

            Case "40", "41", "50", "51"
                ' NÃO CALCULA ICMS
            Case "60"
                ' OS VALORES SÃO CALCULADOS CONFORME A ENTRADA
                ' NÓS NÃO ESTAMOS CONSIDERANDO ISTO
            Case "70"
                If modBC = "0" Then ' Margem Valor Agregado
                    vBC = totalProd + ((totalProd * mva) / 100)
                ElseIf (modBC = "1") Or (modBC = "2") Then ' Pauta ou Preço Tabelado
                    vBC = bcEstabelecida
                Else ' Valor da Operação
                    vBC = totalProd
                End If
                vBC = (vBC * pRedBC) / 100
                vICMS = (vBC * pICMS) / 100

                If (modBCST = "0") Or (modBCST = "1") Or (modBCST = "2") Or (modBCST = "3") Or (modBCST = "5") Then ' Pauta ou Preço Tabelado
                    vBCST = bcEstabelecidaST + IPI
                Else
                    vBCST = (vBC + IPI) + (((vBC + IPI) * mvaST) / 100)
                End If
                vICMSST = ((vBCST * pICMSST) / 100) - vICMS

            Case "90"
                ' DEPENDE
                If modBC = "0" Then ' Margem Valor Agregado
                    vBC = totalProd + ((totalProd * mva) / 100)
                ElseIf (modBC = "1") Or (modBC = "2") Then ' Pauta ou Preço Tabelado
                    vBC = bcEstabelecida
                Else ' Valor da Operação
                    vBC = totalProd
                End If
                If pRedBC > 0 Then
                    vBC = (vBC * pRedBC) / 100
                End If
                vICMS = (vBC * pICMS) / 100

                If (modBCST = "0") Or (modBCST = "1") Or (modBCST = "2") Or (modBCST = "3") Or (modBCST = "5") Then ' Pauta ou Preço Tabelado
                    vBCST = bcEstabelecidaST + IPI
                Else
                    vBCST = (vBC + IPI) + (((vBC + IPI) * mvaST) / 100)
                End If
                vICMSST = ((vBCST * pICMSST) / 100) - vICMS
        End Select
    End Sub
End Class
