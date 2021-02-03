Imports Nano.clsFuncoes
Public Class clsXmlSat
    Public Shared Function Identificador(ByVal parCNPJSoftwareHouse As String, ByVal parAssinaturaAC As String, ByVal parnumeroCaixa As String) As String
        Dim strIdentificador As String
        strIdentificador = "<ide>" & vbCrLf
        strIdentificador &= "<CNPJ>" & parCNPJSoftwareHouse.Trim & "</CNPJ>" & vbCrLf
        strIdentificador &= "<signAC>" & parAssinaturaAC.Trim & "</signAC>" & vbCrLf
        strIdentificador &= "<numeroCaixa>" & parnumeroCaixa.Trim & "</numeroCaixa>" & vbCrLf
        strIdentificador &= "</ide>"



        Return strIdentificador
    End Function


    Public Shared Function Emitente(ByVal parCNPJ As String, ByVal parIE As String, ByVal parindRatISSQN As String) As String

        Dim strEmitente As String
        If parCNPJ <> "" Then
            strEmitente = "<emit>" & vbCrLf
            strEmitente &= "<CNPJ>" & parCNPJ.Trim & "</CNPJ>" & vbCrLf
            strEmitente &= "<IE>" & parIE.Trim & "</IE>" & vbCrLf
            strEmitente &= "<indRatISSQN>" & parindRatISSQN & "</indRatISSQN>" & vbCrLf
            strEmitente &= "</emit>"
        Else
            strEmitente &= "<emit/>"
        End If
    

        Return strEmitente
    End Function


    Public Shared Function Destinatario(ByVal parTipoPessoa As String, ByVal parCpfCnpj As String, ByVal parNome As String) As String

        Dim strDestinatario As String

        If ModeloSAT = "ELGIN 2" Then
            If parCpfCnpj = "00000000000" Then
                strDestinatario = "<dest/>"
                Return strDestinatario
                Exit Function
            End If
        End If
        If ModeloSAT = "ELGIN" Then
            If parCpfCnpj = "00000000000" Then
                strDestinatario = "<dest/>"
                Return strDestinatario
                Exit Function
            End If
        End If
        If ModeloSAT = "SWEDA" Then
            If parCpfCnpj = "00000000000" Then
                strDestinatario = "<dest/>"
                Return strDestinatario
                Exit Function
            End If
        End If
        If ModeloSAT = "EASYS" Then
            If parCpfCnpj = "00000000000" Then
                strDestinatario = "<dest/>"
                Return strDestinatario
                Exit Function
            End If
        End If
        If ModeloSAT = "GERTEC" Or ModeloSAT = "EPSON" Or ModeloSAT = "CONTROLID" Or ModeloSAT = "CUSTOM" Then
            If parCpfCnpj = "00000000000" Then
                strDestinatario = "<dest/>"
                Return strDestinatario
                Exit Function
            End If
        End If
        If VersaoXmlSAT = "0.08" Then
            If ModeloSAT = "TANCA" Then
                If parCpfCnpj = "00000000000" Then
                    strDestinatario = "<dest/>"
                    Return strDestinatario
                    Exit Function
                End If
            End If
        End If

        If VersaoXmlSAT = "0.08" Then
            If ModeloSAT = "DIMEP" Then
                If parCpfCnpj = "00000000000" Then
                    strDestinatario = "<dest/>"
                    Return strDestinatario
                    Exit Function
                End If
            End If
        End If

        If parCpfCnpj <> "" Then
            strDestinatario = "<dest>" & vbCrLf
            If parCpfCnpj = "00000000000" Then
             
                strDestinatario &= "<CPF/>" & vbCrLf

            Else
                If parTipoPessoa = "F" Then
                    strDestinatario &= "<CPF>" & parCpfCnpj & "</CPF>" & vbCrLf
                Else
                    strDestinatario &= "<CNPJ>" & parCpfCnpj & "</CNPJ>" & vbCrLf
                End If
                If parNome <> "" Then
                    strDestinatario &= "<xNome>" & parNome.Trim & "</xNome>" & vbCrLf
                End If
            End If
            strDestinatario &= "</dest>"
        Else
            strDestinatario &= "<dest/>"
        End If





        Return strDestinatario
    End Function

    Public Shared Function Produto(ByVal parNumProd As String, ByVal parCodProd As String, ByVal parCodBarra As String, _
   ByVal parNome As String, ByVal parNCM As String, ByVal parCFOP As String, ByVal parUCom As String, _
   ByVal parQCom As String, ByVal parVUnCom As String, ByVal parindRegra As String, ByVal parCest As String, ByVal parCodigoANP As String) As String

        Dim strProduto As String
        strProduto = "<det nItem=""" & parNumProd & """>" & vbCrLf

        strProduto &= "<prod>" & vbCrLf
        strProduto &= "<cProd>" & parCodProd & "</cProd>" & vbCrLf
        If parCodBarra <> "" Then
            strProduto &= "<cEAN>" & parCodBarra & "</cEAN>" & vbCrLf
        Else
            'strProduto &= "<cEAN/>" & vbCrLf
        End If
        parNome = parNome.Replace("<", "").Replace(">", "")
        strProduto &= "<xProd>" & parNome.Trim & "</xProd>" & vbCrLf
        strProduto &= "<NCM>" & parNCM.Trim & "</NCM>" & vbCrLf
        strProduto &= "<CFOP>" & parCFOP & "</CFOP>" & vbCrLf
        strProduto &= "<uCom>" & parUCom.Trim & "</uCom>" & vbCrLf
        strProduto &= "<qCom>" & parQCom & "</qCom>" & vbCrLf
        strProduto &= "<vUnCom>" & parVUnCom & "</vUnCom>" & vbCrLf

        strProduto &= "<indRegra>" & parindRegra & "</indRegra>" & vbCrLf

        If parCest <> "" Then
            strProduto &= "<obsFiscoDet xCampoDet=""Cod. CEST"">" & vbCrLf
            strProduto &= "<xTextoDet>" & parCest.Trim & "</xTextoDet>" & vbCrLf
            strProduto &= "</obsFiscoDet>" & vbCrLf
        End If

        If parCodigoANP <> "" Then
            strProduto &= "<obsFiscoDet xCampoDet=""Cod. Produto NP"">" & vbCrLf
            strProduto &= "<xTextoDet>" & parCodigoANP.Trim & "</xTextoDet>" & vbCrLf
            strProduto &= "</obsFiscoDet>" & vbCrLf
        End If
        strProduto &= "</prod>" & vbCrLf

        Return strProduto
    End Function

    Public Shared Function ICMS(ByVal parCST As String, ByVal parOrigem As String, _
     ByVal parPIcms As String, ByVal parValAprox As String) As String

        Dim strICMS As String
        strICMS = "<imposto>" & vbCrLf
        If parValAprox <> "" Then
            strICMS &= "<vItem12741>" & parValAprox & "</vItem12741>" & vbCrLf
        End If
        strICMS &= "<ICMS>" & vbCrLf

        Select Case parCST
            Case "00", "20", "90"
                strICMS &= "<ICMS00>" & vbCrLf
                strICMS &= "<Orig>" & parOrigem & "</Orig>" & vbCrLf
                strICMS &= "<CST>00</CST>" & vbCrLf
                strICMS &= "<pICMS>" & parPIcms & "</pICMS>" & vbCrLf
                strICMS &= "</ICMS00>" & vbCrLf
            Case "40", "41", "50", "60"
                strICMS &= "<ICMS40>" & vbCrLf
                strICMS &= "<Orig>" & parOrigem & "</Orig>" & vbCrLf
                strICMS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strICMS &= "</ICMS40>" & vbCrLf

            Case "102", "300", "500"
                strICMS &= "<ICMSSN102>" & vbCrLf
                strICMS &= "<Orig>" & parOrigem & "</Orig>" & vbCrLf
                strICMS &= "<CSOSN>" & parCST & "</CSOSN>" & vbCrLf
                strICMS &= "</ICMSSN102>" & vbCrLf


            Case "900"
                strICMS &= "<ICMSSN900>" & vbCrLf
                strICMS &= "<Orig>" & parOrigem & "</Orig>" & vbCrLf
                strICMS &= "<CSOSN>900</CSOSN>" & vbCrLf

                strICMS &= "<pICMS>" & parPIcms & "</pICMS>" & vbCrLf
                strICMS &= "</ICMSSN900>" & vbCrLf
        End Select
        strICMS &= "</ICMS>" & vbCrLf

        Return strICMS


    End Function

    Public Shared Function PIS(ByVal parCST As String, ByVal parVBC As String, ByVal parPPIS As String) As String

        Dim strPIS As String
        strPIS = "<PIS>" & vbCrLf

        Select Case parCST
            Case "01", "02", "05"
                strPIS &= "<PISAliq>" & vbCrLf
                strPIS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strPIS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strPIS &= "<pPIS>" & parPPIS & "</pPIS>" & vbCrLf
                strPIS &= "</PISAliq>" & vbCrLf
            Case "03"

            Case "04", "06", "07", "08", "09"
                strPIS &= "<PISNT>" & vbCrLf
                strPIS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strPIS &= "</PISNT>" & vbCrLf

            Case "49"
                strPIS &= "<PISSN>" & vbCrLf
                strPIS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strPIS &= "</PISSN>" & vbCrLf

            Case "99"
                strPIS &= "<PISOutr>" & vbCrLf
                strPIS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strPIS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strPIS &= "<pPIS>" & parPPIS & "</pPIS>" & vbCrLf
                strPIS &= "</PISOutr>" & vbCrLf
        End Select

        strPIS &= "</PIS>" & vbCrLf

        Return strPIS

    End Function

    Public Shared Function COFINS(ByVal parCST As String, ByVal parVBC As String, ByVal parPCOFINS As String) As String

        Dim strCOFINS As String
        strCOFINS = "<COFINS>" & vbCrLf
        Select Case parCST
            Case "01", "02", "05"
                strCOFINS &= "<COFINSAliq>" & vbCrLf
                strCOFINS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strCOFINS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strCOFINS &= "<pCOFINS>" & parPCOFINS & "</pCOFINS>" & vbCrLf
                strCOFINS &= "</COFINSAliq>" & vbCrLf
            Case "03"

            Case "04", "06", "07", "08", "09"
                strCOFINS &= "<COFINSNT>" & vbCrLf
                strCOFINS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strCOFINS &= "</COFINSNT>" & vbCrLf

            Case "49"
                strCOFINS &= "<COFINSSN>" & vbCrLf
                strCOFINS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strCOFINS &= "</COFINSSN>" & vbCrLf


            Case "99"
                strCOFINS &= "<COFINSOutr>" & vbCrLf
                strCOFINS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strCOFINS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strCOFINS &= "<pCOFINS>" & parPCOFINS & "</pCOFINS>" & vbCrLf
                strCOFINS &= "</COFINSOutr>" & vbCrLf
        End Select

        strCOFINS &= "</COFINS>" & vbCrLf

        strCOFINS &= "</imposto>" & vbCrLf
        strCOFINS &= "</det>"


        Return strCOFINS
    End Function


    Public Shared Function Total(ByVal parVDesc As String,  ByVal parTotalAprox As String) As String

        Dim strTotal As String = ""
        If parVDesc <> "" Or parTotalAprox <> "" Then
            strTotal = "<total>" & vbCrLf
            If ModeloSAT = "BEMATECHDLL" Then
                If parVDesc <> "" And parVDesc <> "0.00" Then
                    strTotal &= "<DescAcrEntr>" & vbCrLf
                    strTotal &= "<vDescSubtot>" & parVDesc & "</vDescSubtot>" & vbCrLf
                    strTotal &= "</DescAcrEntr>" & vbCrLf
                End If
            Else
                If parVDesc <> "" Then
                    strTotal &= "<DescAcrEntr>" & vbCrLf
                    strTotal &= "<vDescSubtot>" & parVDesc & "</vDescSubtot>" & vbCrLf
                    strTotal &= "</DescAcrEntr>" & vbCrLf
                End If
            End If
          
            If parTotalAprox <> "" Then
                strTotal &= "<vCFeLei12741>" & parTotalAprox & "</vCFeLei12741>" & vbCrLf
            End If
            strTotal &= "</total>"
        Else
            strTotal &= "<total/>"
        End If



        Return strTotal
    End Function

    Public Shared Function Pagamento(ByVal parcMP As String, ByVal parvMP As String) As String

        Dim strPagamento As String = ""
        'strPagamento = "<pgto>" & vbCrLf
        strPagamento &= "<MP>" & vbCrLf
  
        strPagamento &= "<cMP>" & parcMP & "</cMP>" & vbCrLf
        strPagamento &= "<vMP>" & parvMP.Trim & "</vMP>" & vbCrLf
       
        strPagamento &= "</MP>" & vbCrLf
        'strPagamento &= "</pgto>"

        Return strPagamento

    End Function


    Public Shared Function Adicionais(ByVal parComplementar As String) As String

        Dim strAdicionais As String = ""

        If parComplementar.Trim <> "" Then
            strAdicionais = "<infAdic>" & vbCrLf
            strAdicionais &= "<infCpl>" & parComplementar.Trim & "</infCpl>" & vbCrLf

            'strAdicionais &= "<obsFisco xCampo=""01.01.01.01"">" & vbCrLf
            'strAdicionais &= "<xTexto>Consulte o QRCode deste extrato atraves do App DeOlhoNaNota</xTexto>" & vbCrLf
            'strAdicionais &= "</obsFisco>" & vbCrLf
            strAdicionais &= "</infAdic>" & vbCrLf
        Else
            strAdicionais &= "<infAdic/>" & vbCrLf
        End If

        Return strAdicionais

    End Function

    Public Shared Function Cancelamento(ByVal parcOrgao As String, ByVal partpAmb As String, ByVal parCNPJ As String, _
    ByVal parchNFe As String, ByVal pardhEvento As String, ByVal partpEvento As String, ByVal parnSeqEvento As String, _
    ByVal parverEvento As String, ByVal pardescEvento As String, ByVal parnProt As String, _
    ByVal parxJust As String) As String

        Dim strCancelamento As String = ""


        strCancelamento = "<cOrgao>" & parcOrgao & "</cOrgao>" & vbCrLf
        strCancelamento &= "<tpAmb>" & partpAmb & "</tpAmb>" & vbCrLf

        strCancelamento &= "<CNPJ>" & parCNPJ & "</CNPJ>" & vbCrLf

        strCancelamento &= "<chNFe>" & parchNFe & "</chNFe>" & vbCrLf
        strCancelamento &= "<dhEvento>" & pardhEvento & "</dhEvento>" & vbCrLf
        strCancelamento &= "<tpEvento>" & partpEvento & "</tpEvento>" & vbCrLf
        strCancelamento &= "<nSeqEvento>" & parnSeqEvento & "</nSeqEvento>" & vbCrLf
        strCancelamento &= "<verEvento>" & parverEvento & "</verEvento>" & vbCrLf
        strCancelamento &= "<detEvento versao = """ & parverEvento & """>" & vbCrLf
        strCancelamento &= "<descEvento>" & pardescEvento & "</descEvento>" & vbCrLf
        strCancelamento &= "<nProt>" & parnProt & "</nProt>" & vbCrLf
        strCancelamento &= "<xJust>" & parxJust.Trim & "</xJust>" & vbCrLf

        strCancelamento &= "</detEvento>" & vbCrLf
        strCancelamento &= "</infEvento>" & vbCrLf
        strCancelamento &= "</evento>" & vbCrLf

        Return strCancelamento
    End Function

    Public Shared Function TipoInterface(ByVal partipoInter As String, ByVal parSSID As String, ByVal parseg As String, _
    ByVal parCodigo As String) As String

        Dim strTipoInterface As String = ""

        strTipoInterface &= "<tipoInter>" & partipoInter.Trim & "</tipoInter>"
        If partipoInter = "WIFI" Then
            strTipoInterface &= vbCrLf
            strTipoInterface &= "<SSID>" & parSSID.Trim & "</SSID>" & vbCrLf
            strTipoInterface &= "<seg>" & parseg.Trim & "</seg>"
            If parseg <> "NONE" Then
                strTipoInterface &= vbCrLf
                strTipoInterface &= "<codigo>" & parCodigo.Trim & "</codigo>"
            End If
        End If

        Return strTipoInterface
    End Function

    Public Shared Function TipoRede(ByVal partipoLan As String, ByVal parlanIP As String, ByVal parlanMask As String, _
    ByVal parlanGW As String, ByVal parlanDNS1 As String, ByVal parlanDNS2 As String) As String

        Dim strTipoRede As String = ""

        strTipoRede &= "<tipoLan>" & partipoLan.Trim & "</tipoLan>" & vbCrLf

        If partipoLan = "IPFIX" Then
            strTipoRede &= "<lanIP>" & parlanIP.Trim & "</lanIP>" & vbCrLf
            strTipoRede &= "<lanMask>" & parlanMask.Trim & "</lanMask>" & vbCrLf
            strTipoRede &= "<lanGW>" & parlanGW.Trim & "</lanGW>" & vbCrLf
            strTipoRede &= "<lanDNS1>" & parlanDNS1.Trim & "</lanDNS1>" & vbCrLf
            strTipoRede &= "<lanDNS2>" & parlanDNS2.Trim & "</lanDNS2>" & vbCrLf
        End If
        If ModeloSAT <> "SWEDA" Then
            strTipoRede &= "<usuario></usuario>" & vbCrLf
            strTipoRede &= "<senha></senha>"

        End If

        Return strTipoRede


    End Function

    Public Shared Function Proxy(ByVal parproxy As String, ByVal parproxy_ip As String, ByVal parproxy_porta As String, _
    ByVal parproxy_user As String, ByVal parproxy_senha As String) As String

        Dim strProxy As String = ""

        strProxy &= "<proxy>" & parproxy.Trim & "</proxy>" & vbCrLf
        If parproxy_ip <> "" Then
            strProxy &= "<proxy_ip>" & parproxy_ip.Trim & "</proxy_ip>" & vbCrLf
        Else
            If ModeloSAT <> "SWEDA" Then
                strProxy &= "<proxy_ip/>" & vbCrLf
            End If

        End If
        If parproxy_porta <> "" Then
            strProxy &= "<proxy_porta>" & parproxy_porta.Trim & "</proxy_porta>" & vbCrLf
        Else
            If ModeloSAT <> "SWEDA" Then
                strProxy &= "<proxy_porta/>" & vbCrLf

            End If
         
        End If

        If parproxy_user <> "" Then
            strProxy &= "<proxy_user>" & parproxy_user.Trim & "</proxy_user>" & vbCrLf
        Else
            If ModeloSAT <> "SWEDA" Then
                strProxy &= "<proxy_user/>" & vbCrLf
            End If

        End If

        If parproxy_senha <> "" Then
            strProxy &= "<proxy_senha>" & parproxy_senha.Trim & "</proxy_senha>"
        Else
            If ModeloSAT <> "SWEDA" Then
                strProxy &= "<proxy_senha/>"
            End If

        End If
        

        Return strProxy


    End Function
End Class
