Imports Nano.clsFuncoes
Public Class clsXmlNFCe
    Public Shared Function Identificador(ByVal parCodUF As String, ByVal parCodNF As String, _
        ByVal parNatOp As String, ByVal parIndPag As String, ByVal parModelo As String, ByVal parSerie As String, _
        ByVal parNumNF As String, ByVal parDEmi As String, ByVal parTipoNF As String, ByVal parIdDest As String, _
        ByVal parMunFG As String, ByVal parTipoImp As String, ByVal parTipoEmi As String, ByVal parCDV As String, _
        ByVal parTipoAmb As String, ByVal parFinNfe As String, ByVal parIndFinal As String, ByVal parIndPres As String, _
        ByVal parProcEmi As String, ByVal parVerProc As String) As String

        Dim strIdentificador As String

        strIdentificador = "<ide>" & vbCrLf
        strIdentificador &= "<cUF>" & parCodUF.Trim & "</cUF>" & vbCrLf
        strIdentificador &= "<cNF>" & parCodNF.Trim & "</cNF>" & vbCrLf
        strIdentificador &= "<natOp>" & parNatOp.Trim & "</natOp>" & vbCrLf
        If VersaoXml = "3.10" Then
            strIdentificador &= "<indPag>" & parIndPag.Trim & "</indPag>" & vbCrLf
        End If
        strIdentificador &= "<mod>" & parModelo.Trim & "</mod>" & vbCrLf
        strIdentificador &= "<serie>" & parSerie.Trim & "</serie>" & vbCrLf
        strIdentificador &= "<nNF>" & parNumNF.Trim & "</nNF>" & vbCrLf
        strIdentificador &= "<dhEmi>" & parDEmi.Trim & "</dhEmi>" & vbCrLf
        strIdentificador &= "<tpNF>" & parTipoNF.Trim & "</tpNF>" & vbCrLf
        strIdentificador &= "<idDest>" & parIdDest.Trim & "</idDest>" & vbCrLf
        strIdentificador &= "<cMunFG>" & parMunFG.Trim & "</cMunFG>" & vbCrLf
        strIdentificador &= "<tpImp>" & parTipoImp.Trim & "</tpImp>" & vbCrLf
        strIdentificador &= "<tpEmis>" & parTipoEmi.Trim & "</tpEmis>" & vbCrLf
        strIdentificador &= "<cDV>" & parCDV.Trim & "</cDV>" & vbCrLf
        strIdentificador &= "<tpAmb>" & parTipoAmb.Trim & "</tpAmb>" & vbCrLf
        strIdentificador &= "<finNFe>" & parFinNfe.Trim & "</finNFe>" & vbCrLf
        strIdentificador &= "<indFinal>" & parIndFinal.Trim & "</indFinal>" & vbCrLf
        strIdentificador &= "<indPres>" & parIndPres.Trim & "</indPres>" & vbCrLf
        strIdentificador &= "<procEmi>" & parProcEmi.Trim & "</procEmi>" & vbCrLf
        strIdentificador &= "<verProc>" & parVerProc.Trim & "</verProc>" & vbCrLf
        strIdentificador &= "</ide>"
        Return strIdentificador

    End Function


    Public Shared Function Emitente(ByVal parCNPJ As String, ByVal parNome As String, ByVal parFantasia As String, _
     ByVal parLogradouro As String, ByVal parNumero As String, ByVal parBairro As String, ByVal parCodMunicipio As String, _
     ByVal parMunicipio As String, ByVal parUF As String, ByVal parCEP As String, ByVal parCodPais As String, _
     ByVal parNomePais As String, ByVal parTelefone As String, ByVal parIE As String, ByVal parCRT As String, _
     ByVal parComplemento As String, ByVal parIM As String, ByVal parCNAE As String) As String

        Dim strEmitente As String
        strEmitente = "<emit>" & vbCrLf
        strEmitente &= "<CNPJ>" & parCNPJ.Trim & "</CNPJ>" & vbCrLf
        strEmitente &= "<xNome>" & parNome.Trim & "</xNome>" & vbCrLf
        strEmitente &= "<xFant>" & parFantasia.Trim & "</xFant>" & vbCrLf
        strEmitente &= "<enderEmit>" & vbCrLf
        strEmitente &= "<xLgr>" & parLogradouro.Trim & "</xLgr>" & vbCrLf
        strEmitente &= "<nro>" & parNumero.Trim & "</nro>" & vbCrLf
        If parComplemento <> "" Then
            strEmitente &= "<xCpl>" & parComplemento.Trim & "</xCpl>" & vbCrLf
        End If
        strEmitente &= "<xBairro>" & parBairro.Trim & "</xBairro>" & vbCrLf
        strEmitente &= "<cMun>" & parCodMunicipio.Trim & "</cMun>" & vbCrLf
        strEmitente &= "<xMun>" & parMunicipio.Trim & "</xMun>" & vbCrLf
        strEmitente &= "<UF>" & parUF.Trim & "</UF>" & vbCrLf
        strEmitente &= "<CEP>" & parCEP.Trim & "</CEP>" & vbCrLf
        strEmitente &= "<cPais>" & parCodPais.Trim & "</cPais>" & vbCrLf
        strEmitente &= "<xPais>" & parNomePais.Trim & "</xPais>" & vbCrLf
        If parTelefone <> "" Then
            strEmitente &= "<fone>" & parTelefone.Trim & "</fone>" & vbCrLf
        End If

        strEmitente &= "</enderEmit>" & vbCrLf
        strEmitente &= "<IE>" & parIE.Trim & "</IE>" & vbCrLf
        If parIM <> "" Then
            strEmitente &= "<IM>" & parIM.Trim & "</IM>" & vbCrLf
        End If
        If parCNAE <> "" Then
            strEmitente &= "<CNAE>" & parCNAE.Trim & "</CNAE>" & vbCrLf
        End If
        strEmitente &= "<CRT>" & parCRT & "</CRT>" & vbCrLf
        strEmitente &= "</emit>"

        Return strEmitente
    End Function


    Public Shared Function Destinatario(ByVal parTipoPessoa As String, ByVal parCpfCnpj As String, ByVal parNome As String, _
     ByVal parLogradouro As String, ByVal parNumero As String, ByVal parBairro As String, ByVal parCodMunicipio As String, _
     ByVal parMunicipio As String, ByVal parUF As String, ByVal parCEP As String, ByVal parCodPais As String, _
     ByVal parNomePais As String, ByVal parTelefone As String, ByVal parIE As String, ByVal parEmail As String, _
     ByVal parIndIEDest As String, ByVal parComplemento As String) As String
        Dim strDestinatario As String
        If parCpfCnpj = "00000000000" Then
            Return strDestinatario
            Exit Function
        End If



        strDestinatario = "<dest>" & vbCrLf
        If parUF <> "EX" Then

            If parTipoPessoa = "F" Then
                strDestinatario &= "<CPF>" & parCpfCnpj & "</CPF>" & vbCrLf
            Else
                strDestinatario &= "<CNPJ>" & parCpfCnpj & "</CNPJ>" & vbCrLf
            End If


        Else
            strDestinatario &= "<idEstrangeiro></idEstrangeiro>" & vbCrLf
        End If


        strDestinatario &= "<xNome>" & parNome.Trim & "</xNome>" & vbCrLf
        If parLogradouro <> "" Then
            strDestinatario &= "<enderDest>" & vbCrLf
            strDestinatario &= "<xLgr>" & parLogradouro.Trim & "</xLgr>" & vbCrLf
            strDestinatario &= "<nro>" & parNumero.Trim & "</nro>" & vbCrLf
            If parComplemento <> "" Then
                strDestinatario &= "<xCpl>" & parComplemento.Trim & "</xCpl>" & vbCrLf
            End If
            strDestinatario &= "<xBairro>" & parBairro.Trim & "</xBairro>" & vbCrLf
            strDestinatario &= "<cMun>" & parCodMunicipio.Trim & "</cMun>" & vbCrLf
            strDestinatario &= "<xMun>" & parMunicipio.Trim & "</xMun>" & vbCrLf
            strDestinatario &= "<UF>" & parUF.Trim & "</UF>" & vbCrLf
            If parCEP.Trim <> "" Then
                strDestinatario &= "<CEP>" & parCEP.Trim & "</CEP>" & vbCrLf
            End If

            strDestinatario &= "<cPais>" & parCodPais & "</cPais>" & vbCrLf
            strDestinatario &= "<xPais>" & parNomePais & "</xPais>" & vbCrLf
            If parTelefone <> "" Then
                strDestinatario &= "<fone>" & parTelefone.Trim & "</fone>" & vbCrLf
            End If
            strDestinatario &= "</enderDest>" & vbCrLf

        Else

            'strDestinatario &= "<enderDest>" & vbCrLf
            'strDestinatario &= "<xLgr></xLgr>" & vbCrLf
            'strDestinatario &= "<nro></nro>" & vbCrLf
            'strDestinatario &= "<xBairro></xBairro>" & vbCrLf
            'strDestinatario &= "<cMun></cMun>" & vbCrLf
            'strDestinatario &= "<xMun></xMun>" & vbCrLf
            'strDestinatario &= "<UF></UF>" & vbCrLf
            'strDestinatario &= "<CEP></CEP>" & vbCrLf
            'strDestinatario &= "<cPais></cPais>" & vbCrLf
            'strDestinatario &= "<xPais></xPais>" & vbCrLf
            'strDestinatario &= "</enderDest>" & vbCrLf

        End If
        If parTipoPessoa = "F" Then
            strDestinatario &= "<indIEDest>9</indIEDest>" & vbCrLf

        Else
            If parIndIEDest = "1" Then
                strDestinatario &= "<indIEDest>" & parIndIEDest & "</indIEDest>" & vbCrLf
                strDestinatario &= "<IE>" & parIE & "</IE>" & vbCrLf
            Else
                If parIndIEDest <> "" Then
                    strDestinatario &= "<indIEDest>" & parIndIEDest & "</indIEDest>" & vbCrLf
                End If
            End If
        End If

        If parEmail <> "" Then
            strDestinatario &= "<email>" & parEmail.ToLower.Trim & "</email>" & vbCrLf
        End If
        strDestinatario &= "</dest>"

        Return strDestinatario
    End Function

    Public Shared Function Produto(ByVal parNumProd As String, ByVal parCodProd As String, ByVal parCodBarra As String, _
     ByVal parNome As String, ByVal parNCM As String, ByVal parCFOP As String, ByVal parUCom As String, _
     ByVal parQCom As String, ByVal parVUnCom As String, ByVal parVProd As String, ByVal parVFrete As String, _
     ByVal parVOutro As String, ByVal parIndTot As String, ByVal parCodANP As String, ByVal parUFComb As String, _
     ByVal parCest As String, ByVal parPedCompra As String, ByVal parNumItemCompra As String, _
     ByVal parNumDocImp As String, ByVal parDataDocImp As String, ByVal parLocalDesemImp As String, _
     ByVal parUFDesemImp As String, ByVal parDataDesemImp As String, ByVal parViaTranspImp As String, _
     ByVal parTipoInterImp As String, ByVal parCodExpImp As String, _
     ByVal parNumAdicImp As String, ByVal parNumSeqImp As String, ByVal parCodFabriImp As String, ByVal parVDesconto As String, ByVal parDescANP As String) As String

        Dim strProduto As String
        strProduto = "<det nItem=""" & parNumProd & """>" & vbCrLf

        strProduto &= "<prod>" & vbCrLf
        strProduto &= "<cProd>" & parCodProd & "</cProd>" & vbCrLf
        If parCodBarra <> "" Then
            strProduto &= "<cEAN>" & parCodBarra & "</cEAN>" & vbCrLf
        Else
            strProduto &= "<cEAN/>" & vbCrLf
        End If

        strProduto &= "<xProd>" & parNome.Trim & "</xProd>" & vbCrLf
        strProduto &= "<NCM>" & parNCM.Trim & "</NCM>" & vbCrLf
        If parCest.Trim <> "" Then
            strProduto &= "<CEST>" & parCest & "</CEST>" & vbCrLf
        End If
        strProduto &= "<CFOP>" & parCFOP & "</CFOP>" & vbCrLf
        strProduto &= "<uCom>" & parUCom.Trim & "</uCom>" & vbCrLf
        strProduto &= "<qCom>" & parQCom & "</qCom>" & vbCrLf
        strProduto &= "<vUnCom>" & parVUnCom & "</vUnCom>" & vbCrLf
        strProduto &= "<vProd>" & parVProd & "</vProd>" & vbCrLf
        If parCodBarra <> "" Then
            strProduto &= "<cEANTrib>" & parCodBarra & "</cEANTrib>" & vbCrLf
        Else
            strProduto &= "<cEANTrib/>" & vbCrLf
        End If
        strProduto &= "<uTrib>" & parUCom & "</uTrib>" & vbCrLf
        strProduto &= "<qTrib>" & parQCom & "</qTrib>" & vbCrLf
        strProduto &= "<vUnTrib>" & parVUnCom & "</vUnTrib>" & vbCrLf
        If parVFrete.Trim <> "" Then
            strProduto &= "<vFrete>" & parVFrete & "</vFrete>" & vbCrLf
        End If
        If parVDesconto.Trim <> "" Then
            Dim dblDesc As Double = parVDesconto
            If dblDesc > 0 Then

                strProduto &= "<vDesc>" & parVDesconto & "</vDesc>" & vbCrLf
            End If
        End If
        If parVOutro.Trim <> "" Then
            strProduto &= "<vOutro>" & parVOutro & "</vOutro>" & vbCrLf
        End If
        strProduto &= "<indTot>" & parIndTot & "</indTot>" & vbCrLf

        If parPedCompra <> "" Then
            strProduto &= "<xPed>" & parPedCompra & "</xPed>" & vbCrLf
            strProduto &= "<nItemPed>" & parNumItemCompra & "</nItemPed>" & vbCrLf
        End If

        If parCodANP <> "" Then
            strProduto &= "<comb>" & vbCrLf
            strProduto &= "<cProdANP>" & parCodANP & "</cProdANP>" & vbCrLf
            If parDescANP <> "" Then
                strProduto &= "<descANP>" & parDescANP & "</descANP>" & vbCrLf
            End If
            strProduto &= "<UFCons>" & parUFComb & "</UFCons>" & vbCrLf
            strProduto &= "</comb>" & vbCrLf
        End If

        If parNumDocImp <> "" And parLocalDesemImp <> "" Then
            strProduto &= "<DI>" & vbCrLf
            strProduto &= "<nDI>" & parNumDocImp & "</nDI>" & vbCrLf
            If parDataDocImp <> "" Then
                strProduto &= "<dDI>" & parDataDocImp & "</dDI>" & vbCrLf
            End If
            strProduto &= "<xLocDesemb>" & parLocalDesemImp & "</xLocDesemb>" & vbCrLf
            If parUFDesemImp <> "" Then
                strProduto &= "<UFDesemb>" & parUFDesemImp & "</UFDesemb>" & vbCrLf
            End If
            If parDataDesemImp <> "" Then
                strProduto &= "<dDesemb>" & parDataDesemImp & "</dDesemb>" & vbCrLf
            End If
            If parViaTranspImp <> "" Then
                strProduto &= "<tpViaTransp>" & parViaTranspImp & "</tpViaTransp>" & vbCrLf
            End If
            If parTipoInterImp <> "" Then
                strProduto &= "<tpIntermedio>" & parTipoInterImp & "</tpIntermedio>" & vbCrLf
            End If
            If parCodExpImp <> "" Then
                strProduto &= "<cExportador>" & parCodExpImp & "</cExportador>" & vbCrLf
            End If
            If parNumAdicImp <> "" Then
                strProduto &= "<adi>" & vbCrLf
                strProduto &= "<nAdicao>" & parNumAdicImp & "</nAdicao>" & vbCrLf
                If parNumSeqImp <> "" Then
                    strProduto &= "<nSeqAdic>" & parNumSeqImp & "</nSeqAdic>" & vbCrLf
                End If
                If parCodFabriImp <> "" Then
                    strProduto &= "<cFabricante>" & parCodFabriImp & "</cFabricante>" & vbCrLf
                End If
                strProduto &= "</adi>" & vbCrLf
            End If

            strProduto &= "</DI>" & vbCrLf
        End If

        strProduto &= "</prod>"

        Return strProduto
    End Function

    Public Shared Function ICMS(ByVal parCST As String, ByVal parOrigem As String, _
     ByVal parModBC As String, ByVal parVBC As String, ByVal parPRedBC As String, ByVal parPIcms As String, _
     ByVal parVIcms As String, ByVal parModBCST As String, ByVal parPMVaST As String, ByVal parPRedBCST As String, _
     ByVal parVBCST As String, ByVal parPIcmsST As String, ByVal parVIcmsST As String, ByVal parPCred As String, _
     ByVal parVCred As String, ByVal parValAprox As String) As String

        Dim strICMS As String
        strICMS = "<imposto>" & vbCrLf
        If parValAprox <> "" Then
            strICMS &= "<vTotTrib>" & parValAprox & "</vTotTrib>"
        End If
        strICMS &= "<ICMS>" & vbCrLf

        Select Case parCST
            Case "00"
                strICMS &= "<ICMS00>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CST>00</CST>" & vbCrLf
                strICMS &= "<modBC>" & parModBC & "</modBC>" & vbCrLf
                strICMS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strICMS &= "<pICMS>" & parPIcms & "</pICMS>" & vbCrLf
                strICMS &= "<vICMS>" & parVIcms & "</vICMS>" & vbCrLf
                strICMS &= "</ICMS00>" & vbCrLf
            Case "10"
                strICMS &= "<ICMS10>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CST>10</CST>" & vbCrLf
                strICMS &= "<modBC>" & parModBC & "</modBC>" & vbCrLf
                strICMS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strICMS &= "<pICMS>" & parPIcms & "</pICMS>" & vbCrLf
                strICMS &= "<vICMS>" & parVIcms & "</vICMS>" & vbCrLf
                strICMS &= "<modBCST>" & parModBCST & "</modBCST>" & vbCrLf
                strICMS &= "<pMVAST>" & parPMVaST & "</pMVAST>" & vbCrLf
                strICMS &= "<pRedBCST>" & parPRedBCST & "</pRedBCST>" & vbCrLf
                strICMS &= "<vBCST>" & parVBCST & "</vBCST>" & vbCrLf
                strICMS &= "<pICMSST>" & parPIcmsST & "</pICMSST>" & vbCrLf
                strICMS &= "<vICMSST>" & parVIcmsST & "</vICMSST>" & vbCrLf
                strICMS &= "</ICMS10>" & vbCrLf
            Case "20"
                strICMS &= "<ICMS" & parCST & ">" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strICMS &= "<modBC>" & parModBC & "</modBC>" & vbCrLf
                strICMS &= "<pRedBC>" & parPRedBC & "</pRedBC>" & vbCrLf
                strICMS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strICMS &= "<pICMS>" & parPIcms & "</pICMS>" & vbCrLf
                strICMS &= "<vICMS>" & parVIcms & "</vICMS>" & vbCrLf
                strICMS &= "</ICMS" & parCST & ">" & vbCrLf
            Case "51"
                strICMS &= "<ICMS" & parCST & ">" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CST>" & parCST & "</CST>" & vbCrLf
                If parModBC <> "" Then
                    strICMS &= "<modBC>" & parModBC & "</modBC>" & vbCrLf
                    If parPRedBC <> "" Then
                        strICMS &= "<pRedBC>" & parPRedBC & "</pRedBC>" & vbCrLf
                    End If
                    If parVBC <> "" Then
                        strICMS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                    End If
                    If parPIcms <> "" Then
                        strICMS &= "<pICMS>" & parPIcms & "</pICMS>" & vbCrLf
                    End If
                    If parVIcms <> "" Then
                        strICMS &= "<vICMS>" & parVIcms & "</vICMS>" & vbCrLf
                    End If
                End If


                strICMS &= "</ICMS" & parCST & ">" & vbCrLf
            Case "30"
                strICMS &= "<ICMS30>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CST>30</CST>" & vbCrLf
                strICMS &= "<modBCST>" & parModBCST & "</modBCST>" & vbCrLf
                strICMS &= "<pMVAST>" & parPMVaST & "</pMVAST>" & vbCrLf
                strICMS &= "<pRedBCST>" & parPRedBCST & "</pRedBCST>" & vbCrLf
                strICMS &= "<vBCST>" & parVBCST & "</vBCST>" & vbCrLf
                strICMS &= "<pICMSST>" & parPIcmsST & "</pICMSST>" & vbCrLf
                strICMS &= "<vICMSST>" & parVIcmsST & "</vICMSST>" & vbCrLf
                strICMS &= "</ICMS30>" & vbCrLf
            Case "40", "41", "50"
                strICMS &= "<ICMS40>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strICMS &= "</ICMS40>" & vbCrLf
            Case "60"
                strICMS &= "<ICMS60>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CST>60</CST>" & vbCrLf
                strICMS &= "</ICMS60>" & vbCrLf
            Case "70", "90"
                strICMS &= "<ICMS" & parCST & ">" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CST>" & parCST & "</CST>" & vbCrLf
                If parModBC <> "" Then
                    strICMS &= "<modBC>" & parModBC & "</modBC>" & vbCrLf
                    If parVBC <> "" Then
                        strICMS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                    End If
                    If parPRedBC <> "" Then
                        strICMS &= "<pRedBC>" & parPRedBC & "</pRedBC>" & vbCrLf
                    End If
                    If parPIcms <> "" Then
                        strICMS &= "<pICMS>" & parPIcms & "</pICMS>" & vbCrLf
                    End If
                    If parVIcms <> "" Then
                        strICMS &= "<vICMS>" & parVIcms & "</vICMS>" & vbCrLf
                    End If

                End If
                If parModBCST <> "" Then

                    strICMS &= "<modBCST>" & parModBCST & "</modBCST>" & vbCrLf
                    If parPMVaST <> "" Then
                        strICMS &= "<pMVAST>" & parPMVaST & "</pMVAST>" & vbCrLf
                    End If
                    If parPRedBCST <> "" Then
                        strICMS &= "<pRedBCST>" & parPRedBCST & "</pRedBCST>" & vbCrLf
                    End If
                    If parVBCST <> "" Then
                        strICMS &= "<vBCST>" & parVBCST & "</vBCST>" & vbCrLf
                    End If
                    If parPIcmsST <> "" Then
                        strICMS &= "<pICMSST>" & parPIcmsST & "</pICMSST>" & vbCrLf
                    End If
                    If parVIcmsST <> "" Then
                        strICMS &= "<vICMSST>" & parVIcmsST & "</vICMSST>" & vbCrLf
                    End If

                End If

                strICMS &= "</ICMS" & parCST & ">" & vbCrLf

            Case "101"
                strICMS &= "<ICMSSN101>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CSOSN>101</CSOSN>" & vbCrLf
                strICMS &= "<pCredSN>" & parPCred & "</pCredSN>" & vbCrLf
                strICMS &= "<vCredICMSSN>" & parVCred & "</vCredICMSSN>" & vbCrLf
                strICMS &= "</ICMSSN101>" & vbCrLf
            Case "102", "300", "400"
                strICMS &= "<ICMSSN102>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CSOSN>" & parCST & "</CSOSN>" & vbCrLf
                strICMS &= "</ICMSSN102>" & vbCrLf

            Case "201"
                strICMS &= "<ICMSSN201>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CSOSN>201</CSOSN>" & vbCrLf
                strICMS &= "<modBCST>" & parModBCST & "</modBCST>" & vbCrLf
                strICMS &= "<pMVAST>" & parPMVaST & "</pMVAST>" & vbCrLf
                strICMS &= "<pRedBCST>" & parPRedBCST & "</pRedBCST>" & vbCrLf
                strICMS &= "<vBCST>" & parVBCST & "</vBCST>" & vbCrLf
                strICMS &= "<pICMSST>" & parPIcmsST & "</pICMSST>" & vbCrLf
                strICMS &= "<vICMSST>" & parVIcmsST & "</vICMSST>" & vbCrLf
                strICMS &= "<pCredSN>" & parPCred & "</pCredSN>" & vbCrLf
                strICMS &= "<vCredICMSSN>" & parVCred & "</vCredICMSSN>" & vbCrLf
                strICMS &= "</ICMSSN201>" & vbCrLf
            Case "202", "203"
                strICMS &= "<ICMSSN202>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CSOSN>" & parCST & "</CSOSN>" & vbCrLf
                strICMS &= "<modBCST>" & parModBCST & "</modBCST>" & vbCrLf
                strICMS &= "<pMVAST>" & parPMVaST & "</pMVAST>" & vbCrLf
                strICMS &= "<pRedBCST>" & parPRedBCST & "</pRedBCST>" & vbCrLf
                strICMS &= "<vBCST>" & parVBCST & "</vBCST>" & vbCrLf
                strICMS &= "<pICMSST>" & parPIcmsST & "</pICMSST>" & vbCrLf
                strICMS &= "<vICMSST>" & parVIcmsST & "</vICMSST>" & vbCrLf
                strICMS &= "</ICMSSN202>" & vbCrLf
            Case "500"
                'strICMS &= "<ICMSSN500>" & vbCrLf
                'strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                'strICMS &= "<CSOSN>500</CSOSN>" & vbCrLf
                'strICMS &= "<vBCSTRet>0.00</vBCSTRet>" & vbCrLf
                'strICMS &= "<vICMSSTRet>0.00</vICMSSTRet>" & vbCrLf
                'strICMS &= "</ICMSSN500>" & vbCrLf


                strICMS &= "<ICMSSN500>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CSOSN>500</CSOSN>" & vbCrLf

                If VersaoXml = "3.10" Then
                    'strICMS &= "<vBCSTRet>0.00</vBCSTRet>" & vbCrLf
                    'strICMS &= "<vICMSSTRet>0.00</vICMSSTRet>" & vbCrLf
                ElseIf VersaoXml = "4.00" Then
                    'If parVBCST <> "" Then
                    '    strICMS &= "<vBCSTRet>" & parVBCST & "</vBCSTRet>" & vbCrLf
                    'End If
                    'If parPIcmsST <> "" Then
                    '    strICMS &= "<pST>" & parPIcmsST & "</pST>" & vbCrLf
                    'End If
                    'If parVIcmsST <> "" Then
                    '    strICMS &= "<vICMSSTRet>" & parVIcmsST & "</vICMSSTRet>" & vbCrLf
                    'End If

                    'If parBCFCPST <> "" Then
                    '    strICMS &= "<vBCFCPSTRet>" & parBCFCPST & "</vBCFCPSTRet>" & vbCrLf
                    'End If
                    'If parPerFCPST <> "" Then
                    '    strICMS &= "<pFCPSTRet>" & parPerFCPST & "</pFCPSTRet>" & vbCrLf
                    'End If
                    'If parValFCPST <> "" Then
                    '    strICMS &= "<vFCPSTRet>" & parValFCPST & "</vFCPSTRet>" & vbCrLf
                    'End If
                End If
                strICMS &= "</ICMSSN500>" & vbCrLf
            Case "900"
                strICMS &= "<ICMSSN900>" & vbCrLf
                strICMS &= "<orig>" & parOrigem & "</orig>" & vbCrLf
                strICMS &= "<CSOSN>900</CSOSN>" & vbCrLf
                If parModBC <> "" Then
                    strICMS &= "<modBC>" & parModBC & "</modBC>" & vbCrLf
                    If parVBC <> "" Then
                        strICMS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                    End If
                    If parPRedBC <> "" Then
                        strICMS &= "<pRedBC>" & parPRedBC & "</pRedBC>" & vbCrLf
                    End If
                    If parPIcms <> "" Then
                        strICMS &= "<pICMS>" & parPIcms & "</pICMS>" & vbCrLf
                        strICMS &= "<vICMS>" & parVIcms & "</vICMS>" & vbCrLf
                    End If
                End If

                If parModBCST <> "" Then
                    strICMS &= "<modBCST>" & parModBCST & "</modBCST>" & vbCrLf
                    If parPMVaST <> "" Then
                        strICMS &= "<pMVAST>" & parPMVaST & "</pMVAST>" & vbCrLf
                    End If
                    If parPRedBCST <> "" Then
                        strICMS &= "<pRedBCST>" & parPRedBCST & "</pRedBCST>" & vbCrLf
                    End If
                    If parVBCST <> "" Then
                        strICMS &= "<vBCST>" & parVBCST & "</vBCST>" & vbCrLf
                    End If
                    If parPIcmsST <> "" Then
                        strICMS &= "<pICMSST>" & parPIcmsST & "</pICMSST>" & vbCrLf
                        strICMS &= "<vICMSST>" & parVIcmsST & "</vICMSST>" & vbCrLf
                    End If
                End If

                If parVCred <> "" Then
                    If parVCred <> "0,00" And parVCred <> "0" And parVCred <> "0.00" Then
                        strICMS &= "<pCredSN>" & parPCred & "</pCredSN>" & vbCrLf
                        strICMS &= "<vCredICMSSN>" & parVCred & "</vCredICMSSN>" & vbCrLf
                    End If
                End If


                strICMS &= "</ICMSSN900>" & vbCrLf
        End Select
        strICMS &= "</ICMS>"

        Return strICMS


    End Function
    Public Shared Function IPI(ByVal parCEnq As String, ByVal parCST As String, ByVal parVBC As String, _
    ByVal parPIPI As String, ByVal parVIPI As String) As String

        Dim strIPI As String = ""
        If parCST <> "" Then


            strIPI = "<IPI>" & vbCrLf

            strIPI &= "<cEnq>" & parCEnq.Trim & "</cEnq>" & vbCrLf
            Select Case parCST
                Case "00", "49", "50", "99"
                    strIPI &= "<IPITrib>" & vbCrLf
                    strIPI &= "<CST>" & parCST & "</CST>" & vbCrLf
                    strIPI &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                    strIPI &= "<pIPI>" & parPIPI & "</pIPI>" & vbCrLf
                    strIPI &= "<vIPI>" & parVIPI & "</vIPI>" & vbCrLf
                    strIPI &= "</IPITrib>" & vbCrLf
                Case "01", "02", "03", "04", "52", "53", "51", "54", "55"
                    strIPI &= "<IPINT>" & vbCrLf
                    strIPI &= "<CST>" & parCST & "</CST>" & vbCrLf
                    strIPI &= "</IPINT>" & vbCrLf
            End Select

            strIPI &= "</IPI>"
        End If
        Return strIPI

    End Function
    Public Shared Function II(ByVal parVBC As String, ByVal parValIOF As String, _
        ByVal parValDesp As String, ByVal parValImp As String) As String

        Dim strII As String = ""

        If parVBC <> "" Then
            strII = "<II>" & vbCrLf
            strII &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
            strII &= "<vDespAdu>" & parValDesp & "</vDespAdu>" & vbCrLf
            strII &= "<vII>" & parValImp & "</vII>" & vbCrLf
            strII &= "<vIOF>" & parValIOF & "</vIOF>" & vbCrLf
            strII &= "</II>"
        End If
        Return strII

    End Function
    Public Shared Function PIS(ByVal parCST As String, ByVal parVBC As String, ByVal parPPIS As String, ByVal parVPIS As String) As String

        Dim strPIS As String
        strPIS = "<PIS>" & vbCrLf

        Select Case parCST
            Case "01", "02"
                strPIS &= "<PISAliq>" & vbCrLf
                strPIS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strPIS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strPIS &= "<pPIS>" & parPPIS & "</pPIS>" & vbCrLf
                strPIS &= "<vPIS>" & parVPIS & "</vPIS>" & vbCrLf
                strPIS &= "</PISAliq>" & vbCrLf
            Case "03", "05"

            Case "04", "06", "07", "08", "09"
                strPIS &= "<PISNT>" & vbCrLf
                strPIS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strPIS &= "</PISNT>" & vbCrLf


            Case Else
                strPIS &= "<PISOutr>" & vbCrLf
                strPIS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strPIS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strPIS &= "<pPIS>" & parPPIS & "</pPIS>" & vbCrLf
                strPIS &= "<vPIS>" & parVPIS & "</vPIS>" & vbCrLf
                strPIS &= "</PISOutr>" & vbCrLf
        End Select

        strPIS &= "</PIS>"

        Return strPIS

    End Function

    Public Shared Function COFINS(ByVal parCST As String, ByVal parVBC As String, ByVal parPCOFINS As String, _
    ByVal parVCOFINS As String, ByVal parICMSUFDest As Boolean) As String

        Dim strCOFINS As String
        strCOFINS = "<COFINS>" & vbCrLf
        Select Case parCST
            Case "01", "02"
                strCOFINS &= "<COFINSAliq>" & vbCrLf
                strCOFINS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strCOFINS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strCOFINS &= "<pCOFINS>" & parPCOFINS & "</pCOFINS>" & vbCrLf
                strCOFINS &= "<vCOFINS>" & parVCOFINS & "</vCOFINS>" & vbCrLf
                strCOFINS &= "</COFINSAliq>" & vbCrLf
            Case "03", "05"

            Case "04", "06", "07", "08", "09"
                strCOFINS &= "<COFINSNT>" & vbCrLf
                strCOFINS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strCOFINS &= "</COFINSNT>" & vbCrLf


            Case Else
                strCOFINS &= "<COFINSOutr>" & vbCrLf
                strCOFINS &= "<CST>" & parCST & "</CST>" & vbCrLf
                strCOFINS &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
                strCOFINS &= "<pCOFINS>" & parPCOFINS & "</pCOFINS>" & vbCrLf
                strCOFINS &= "<vCOFINS>" & parVCOFINS & "</vCOFINS>" & vbCrLf
                strCOFINS &= "</COFINSOutr>" & vbCrLf
        End Select

        strCOFINS &= "</COFINS>" & vbCrLf
        If parICMSUFDest = False Then
            strCOFINS &= "</imposto>" & vbCrLf
            strCOFINS &= "</det>"
        End If


        Return strCOFINS
    End Function

    Public Shared Function ICMSUFDest(ByVal parValBCUFDest As String, ByVal parPerFCPUFDest As String, _
    ByVal parPerICMSUFDest As String, ByVal parPerICMSInter As String, ByVal parPerICMSInterPart As String, _
    ByVal parValFCPUFDest As String, ByVal parValICMSUFDest As String, ByVal parValICMSUFRemet As String) As String

        Dim strICMSUFDest As String
        strICMSUFDest = "<ICMSUFDest>" & vbCrLf

        If parValBCUFDest.Trim <> "" Then
            strICMSUFDest &= "<vBCUFDest>" & parValBCUFDest & "</vBCUFDest>" & vbCrLf
        End If
        If parPerFCPUFDest.Trim <> "" Then
            strICMSUFDest &= "<pFCPUFDest>" & parPerFCPUFDest & "</pFCPUFDest>" & vbCrLf
        End If
        If parPerICMSUFDest.Trim <> "" Then
            strICMSUFDest &= "<pICMSUFDest>" & parPerICMSUFDest & "</pICMSUFDest>" & vbCrLf
        End If
        If parPerICMSInter.Trim <> "" Then
            strICMSUFDest &= "<pICMSInter>" & parPerICMSInter & "</pICMSInter>" & vbCrLf
        End If
        If parPerICMSInterPart.Trim <> "" Then
            strICMSUFDest &= "<pICMSInterPart>" & parPerICMSInterPart & "</pICMSInterPart>" & vbCrLf
        End If
        If parValFCPUFDest.Trim <> "" Then
            strICMSUFDest &= "<vFCPUFDest>" & parValFCPUFDest & "</vFCPUFDest>" & vbCrLf
        End If
        If parValICMSUFDest.Trim <> "" Then
            strICMSUFDest &= "<vICMSUFDest>" & parValICMSUFDest & "</vICMSUFDest>" & vbCrLf
        End If
        If parValICMSUFRemet.Trim <> "" Then
            strICMSUFDest &= "<vICMSUFRemet>" & parValICMSUFRemet & "</vICMSUFRemet>" & vbCrLf
        End If
        strICMSUFDest &= "</ICMSUFDest>" & vbCrLf
        strICMSUFDest &= "</imposto>" & vbCrLf
        strICMSUFDest &= "</det>"

        Return strICMSUFDest
    End Function

    Public Shared Function Total(ByVal parVBC As String, ByVal parVICMS As String, ByVal parVBCST As String, _
    ByVal parVST As String, ByVal parVProd As String, ByVal parVFrete As String, ByVal parVSeg As String, _
    ByVal parVDesc As String, ByVal parVII As String, ByVal parVIPI As String, ByVal parVPIS As String, _
    ByVal parVCOFINS As String, ByVal parVOutro As String, ByVal parVNF As String, ByVal parTotalAprox As String, _
    ByVal parValFCPUFDest As String, ByVal parValICMSUFDest As String, ByVal parValICMSUFRemet As String, ByVal parICMSUFDest As String) As String

        Dim strTotal As String
        strTotal = "<total>" & vbCrLf
        strTotal &= "<ICMSTot>" & vbCrLf
        strTotal &= "<vBC>" & parVBC & "</vBC>" & vbCrLf
        strTotal &= "<vICMS>" & parVICMS & "</vICMS>" & vbCrLf

        strTotal &= "<vICMSDeson>0.00</vICMSDeson>" & vbCrLf

        If parICMSUFDest <> "" Then
            If parValFCPUFDest <> "" Then
                strTotal &= "<vFCPUFDest>" & parValFCPUFDest & "</vFCPUFDest>" & vbCrLf
            End If
            If parValICMSUFDest <> "" Then
                strTotal &= "<vICMSUFDest>" & parValICMSUFDest & "</vICMSUFDest>" & vbCrLf
            End If
            If parValICMSUFRemet <> "" Then
                strTotal &= "<vICMSUFRemet>" & parValICMSUFRemet & "</vICMSUFRemet>" & vbCrLf
            End If
        End If
        If VersaoXml = "4.00" Then
            'If parValFCP <> "" Then
            strTotal &= "<vFCP>0.00</vFCP>" & vbCrLf
            'End If
        End If
        strTotal &= "<vBCST>" & parVBCST & "</vBCST>" & vbCrLf
        strTotal &= "<vST>" & parVST & "</vST>" & vbCrLf
        If VersaoXml = "4.00" Then
            'If parValFCPST <> "" Then
            strTotal &= "<vFCPST>0.00</vFCPST>" & vbCrLf
            'End If
            'If parValFCPSTRet <> "" Then
            strTotal &= "<vFCPSTRet>0.00</vFCPSTRet>" & vbCrLf
            'End If
        End If
        strTotal &= "<vProd>" & parVProd & "</vProd>" & vbCrLf
        strTotal &= "<vFrete>" & parVFrete & "</vFrete>" & vbCrLf
        strTotal &= "<vSeg>" & parVSeg & "</vSeg>" & vbCrLf
        strTotal &= "<vDesc>" & parVDesc & "</vDesc>" & vbCrLf
        strTotal &= "<vII>" & parVII & "</vII>" & vbCrLf
        strTotal &= "<vIPI>" & parVIPI & "</vIPI>" & vbCrLf
        If VersaoXml = "4.00" Then
            'If parValIPIDevol <> "" Then
            strTotal &= "<vIPIDevol>0.00</vIPIDevol>" & vbCrLf
            'End If
        End If

        strTotal &= "<vPIS>" & parVPIS & "</vPIS>" & vbCrLf
        strTotal &= "<vCOFINS>" & parVCOFINS & "</vCOFINS>" & vbCrLf
        strTotal &= "<vOutro>" & parVOutro & "</vOutro>" & vbCrLf
        strTotal &= "<vNF>" & parVNF & "</vNF>" & vbCrLf
        If parTotalAprox <> "" Then
            strTotal &= "<vTotTrib>" & parTotalAprox & "</vTotTrib>" & vbCrLf
        End If

        strTotal &= "</ICMSTot>" & vbCrLf
        strTotal &= "</total>"


        Return strTotal
    End Function

    Public Shared Function Transportadora(ByVal parModFrete As String, ByVal parCNPJ As String, ByVal parNome As String, ByVal parIE As String, _
    ByVal parEnder As String, ByVal parMun As String, ByVal parUF As String, ByVal parPlaca As String, ByVal parVeiUF As String, _
    ByVal parRNTC As String, ByVal parQVol As String, ByVal parEspecie As String, ByVal parMarca As String, ByVal parNVol As String, _
    ByVal parPesoLiq As String, ByVal parPesoBruto As String) As String

        Dim strTransportadora As String
        strTransportadora = "<transp>" & vbCrLf
        strTransportadora &= "<modFrete>" & parModFrete & "</modFrete>" & vbCrLf
        Select Case parModFrete
            Case "9"
                strTransportadora &= "</transp>"
            Case Else
                If parNome <> "" Then
                    strTransportadora &= "<transporta>" & vbCrLf
                    If parCNPJ <> "" Then
                        strTransportadora &= "<CNPJ>" & parCNPJ & "</CNPJ>" & vbCrLf
                    End If
                    If parNome <> "" Then
                        strTransportadora &= "<xNome>" & parNome.Trim & "</xNome>" & vbCrLf
                    End If
                    If parIE <> "" Then
                        strTransportadora &= "<IE>" & parIE.Trim & "</IE>" & vbCrLf
                    End If
                    If parEnder <> "" Then
                        strTransportadora &= "<xEnder>" & parEnder.Trim & "</xEnder>" & vbCrLf
                    End If
                    If parMun <> "" Then
                        strTransportadora &= "<xMun>" & parMun & "</xMun>" & vbCrLf
                    End If
                    If parUF <> "" Then
                        strTransportadora &= "<UF>" & parUF & "</UF>" & vbCrLf
                    End If

                    strTransportadora &= "</transporta>" & vbCrLf

                    If parPlaca <> "" Then
                        strTransportadora &= "<veicTransp>" & vbCrLf
                        strTransportadora &= "<placa>" & parPlaca.Trim & "</placa>" & vbCrLf
                        strTransportadora &= "<UF>" & parVeiUF & "</UF>" & vbCrLf
                        If parRNTC <> "" Then
                            strTransportadora &= "<RNTC>" & parRNTC.Trim & "</RNTC>" & vbCrLf
                        End If
                        strTransportadora &= "</veicTransp>" & vbCrLf
                    End If
                End If
                If parQVol <> "" Or parEspecie <> "" Or parNVol <> "" Then
                    strTransportadora &= "<vol>" & vbCrLf
                    If parQVol <> "" Then
                        strTransportadora &= "<qVol>" & parQVol.Trim & "</qVol>" & vbCrLf
                    End If
                    If parEspecie <> "" Then
                        strTransportadora &= "<esp>" & parEspecie.Trim & "</esp>" & vbCrLf
                    End If
                    If parMarca <> "" Then
                        strTransportadora &= "<marca>" & parMarca.Trim & "</marca>" & vbCrLf
                    End If
                    If parNVol <> "" Then
                        strTransportadora &= "<nVol>" & parNVol.Trim & "</nVol>" & vbCrLf
                    End If
                    If parPesoLiq <> "" Then
                        strTransportadora &= "<pesoL>" & parPesoLiq.Trim.Replace(",", ".") & "</pesoL>" & vbCrLf
                    End If
                    If parPesoBruto <> "" Then
                        strTransportadora &= "<pesoB>" & parPesoBruto.Trim.Replace(",", ".") & "</pesoB>" & vbCrLf
                    End If
                    strTransportadora &= "</vol>" & vbCrLf
                End If

                strTransportadora &= "</transp>"
        End Select



        Return strTransportadora

    End Function

    Public Shared Function Pagamento(ByVal parcMP As String, ByVal parvMP As String, ByVal parFormaPag As String) As String

        Dim strPagamento As String = ""
        If VersaoXml = "3.10" Then
            strPagamento = "<pag>" & vbCrLf
        ElseIf VersaoXml = "4.00" Then
            strPagamento = "<detPag>" & vbCrLf
        End If

        strPagamento &= "<tPag>" & parcMP & "</tPag>" & vbCrLf
        strPagamento &= "<vPag>" & parvMP.Trim & "</vPag>" & vbCrLf
        If parcMP = "03" Or parcMP = "04" Then
            strPagamento &= "<card>" & vbCrLf
            strPagamento &= "<tpIntegra>2</tpIntegra>" & vbCrLf
            'strPagamento &= "<CNPJ></CNPJ>" & vbCrLf
            If parFormaPag.Contains("VISA") = True Then
                strPagamento &= "<tBand>01</tBand>" & vbCrLf
            ElseIf parFormaPag.Contains("MASTER") = True Then
                strPagamento &= "<tBand>02</tBand>" & vbCrLf
            ElseIf parFormaPag.Contains("AMERICAN") = True Then
                strPagamento &= "<tBand>03</tBand>" & vbCrLf
            ElseIf parFormaPag.Contains("SOROCRED") = True Then
                strPagamento &= "<tBand>04</tBand>" & vbCrLf
            Else
                strPagamento &= "<tBand>99</tBand>" & vbCrLf
            End If

            'strPagamento &= "<tBand></tBand>" & vbCrLf
            'strPagamento &= "<cAut></cAut>" & vbCrLf
            strPagamento &= "</card>" & vbCrLf
        End If
        If VersaoXml = "3.10" Then
            strPagamento &= "</pag>"
        ElseIf VersaoXml = "4.00" Then
            strPagamento &= "</detPag>" & vbCrLf
        End If

        Return strPagamento

    End Function

    Public Shared Function Cobranca(ByVal parNumFat As String, ByVal parVOrig As String, ByVal parVLiq As String, ByVal parVDesc As String) As String

        Dim strCobranca As String = ""

        If parNumFat <> "" Then
            strCobranca = "<cobr>" & vbCrLf
            strCobranca &= "<fat>" & vbCrLf
            strCobranca &= "<nFat>" & parNumFat.Trim & "</nFat>" & vbCrLf
            strCobranca &= "<vOrig>" & parVOrig & "</vOrig>" & vbCrLf
            If parVDesc <> "" Then
                strCobranca &= "<vDesc>" & parVDesc & "</vDesc>" & vbCrLf
            End If

            strCobranca &= "<vLiq>" & parVLiq & "</vLiq>" & vbCrLf

            strCobranca &= "</fat>"
        End If


        Return strCobranca

    End Function

    Public Shared Function Duplicata(ByVal parInicio As Boolean, ByVal parFechar As Boolean, ByVal parCobranca As Boolean, ByVal parNumDup As String, _
    ByVal parDVenc As String, ByVal parVDup As String) As String

        Dim strDuplicata As String = ""

        If parNumDup <> "" Then
            If parCobranca = False Then
                If parInicio = True Then
                    strDuplicata = "<cobr>" & vbCrLf
                End If
            End If

            strDuplicata = "<dup>" & vbCrLf
            strDuplicata &= "<nDup>" & parNumDup.Trim & "</nDup>" & vbCrLf
            strDuplicata &= "<dVenc>" & parDVenc & "</dVenc>" & vbCrLf
            strDuplicata &= "<vDup>" & parVDup & "</vDup>" & vbCrLf

            strDuplicata &= "</dup>" & vbCrLf
        End If

        If parFechar = True Then
            strDuplicata &= "</cobr>"
        End If
        Return strDuplicata

    End Function

    Public Shared Function Adicionais(ByVal parFisco As String, ByVal parComplementar As String) As String

        Dim strAdicionais As String = ""

        If parFisco.Trim <> "" Then
            strAdicionais = "<infAdic>" & vbCrLf
            strAdicionais &= "<infAdFisco>" & parFisco.Trim & "</infAdFisco>" & vbCrLf
            If parComplementar.Trim <> "" Then
                strAdicionais &= "<infCpl>" & parComplementar.Trim & "</infCpl>" & vbCrLf
            End If
            strAdicionais &= "</infAdic>"
        Else
            If parComplementar.Trim <> "" Then
                strAdicionais = "<infAdic>" & vbCrLf
                strAdicionais &= "<infCpl>" & parComplementar.Trim & "</infCpl>" & vbCrLf
                strAdicionais &= "</infAdic>"
            End If

        End If

        'strAdicionais &= "</nfeProc>"
        Return strAdicionais

    End Function

    Public Shared Function QrCode(ByVal parCode As String, ByVal parUrlChave As String) As String

        Dim strQrCode As String = ""


        strQrCode = "<infNFeSupl>" & vbCrLf
        strQrCode &= "<qrCode>" & parCode.Trim & "</qrCode>" & vbCrLf
        If VersaoXml <> "3.10" Then

            Dim intddd As Integer = parUrlChave.Length
            If intddd > 85 Then
                parUrlChave = parUrlChave.Substring(0, 84)
            End If

            strQrCode &= "<urlChave>" & parUrlChave.Trim & "</urlChave>" & vbCrLf
        End If

        strQrCode &= "</infNFeSupl>"
        Return strQrCode

    End Function
    Public Shared Function Exportacao(ByVal parUFEmbarque As String, ByVal parLocalEmbarque As String, ByVal parLocalDespacho As String) As String

        Dim strExportacao As String = ""


        strExportacao = "<exporta>" & vbCrLf
        strExportacao &= "<UFSaidaPais>" & parUFEmbarque.Trim & "</UFSaidaPais>" & vbCrLf
        strExportacao &= "<xLocExporta>" & parLocalEmbarque.Trim & "</xLocExporta>" & vbCrLf
        strExportacao &= "<xLocDespacho>" & parLocalDespacho.Trim & "</xLocDespacho>" & vbCrLf
        strExportacao &= "</exporta>"

        Return strExportacao

    End Function
    Public Shared Function Cce(ByVal parcOrgao As String, ByVal partpAmb As String, ByVal parCNPJ As String, _
    ByVal parchNFe As String, ByVal pardhEvento As String, ByVal partpEvento As String, ByVal parnSeqEvento As String, _
    ByVal parverEvento As String, ByVal pardescEvento As String, ByVal parxCorrecao As String, _
    ByVal parxCondUso As String) As String

        Dim strCce As String = ""


        strCce = "<cOrgao>" & parcOrgao & "</cOrgao>" & vbCrLf
        strCce &= "<tpAmb>" & partpAmb & "</tpAmb>" & vbCrLf

        strCce &= "<CNPJ>" & parCNPJ & "</CNPJ>" & vbCrLf

        strCce &= "<chNFe>" & parchNFe & "</chNFe>" & vbCrLf
        strCce &= "<dhEvento>" & pardhEvento & "</dhEvento>" & vbCrLf
        strCce &= "<tpEvento>" & partpEvento & "</tpEvento>" & vbCrLf
        strCce &= "<nSeqEvento>" & parnSeqEvento & "</nSeqEvento>" & vbCrLf
        strCce &= "<verEvento>" & parverEvento & "</verEvento>" & vbCrLf
        strCce &= "<detEvento versao = """ & parverEvento & """>" & vbCrLf
        strCce &= "<descEvento>" & pardescEvento.Trim & "</descEvento>" & vbCrLf
        strCce &= "<xCorrecao>" & parxCorrecao.Trim & "</xCorrecao>" & vbCrLf
        strCce &= "<xCondUso>" & parxCondUso & "</xCondUso>" & vbCrLf

        strCce &= "</detEvento>" & vbCrLf
        strCce &= "</infEvento>" & vbCrLf
        strCce &= "</evento>" & vbCrLf

        Return strCce
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

    Public Shared Function Inutilizacao(ByVal partpAmb As String, ByVal parxServ As String, _
    ByVal parcUF As String, ByVal parano As String, ByVal parCNPJ As String, ByVal parmod As String, _
    ByVal parserie As String, ByVal parnNFIni As String, ByVal parnNFFin As String, _
    ByVal parxJust As String) As String

        Dim strInutilizacao As String = ""



        strInutilizacao &= "<tpAmb>" & partpAmb & "</tpAmb>" & vbCrLf

        strInutilizacao &= "<xServ>" & parxServ & "</xServ>" & vbCrLf

        strInutilizacao &= "<cUF>" & parcUF & "</cUF>" & vbCrLf
        strInutilizacao &= "<ano>" & parano & "</ano>" & vbCrLf
        strInutilizacao &= "<CNPJ>" & parCNPJ & "</CNPJ>" & vbCrLf
        strInutilizacao &= "<mod>" & parmod & "</mod>" & vbCrLf
        strInutilizacao &= "<serie>" & parserie & "</serie>" & vbCrLf
        strInutilizacao &= "<nNFIni>" & parnNFIni & "</nNFIni>" & vbCrLf
        strInutilizacao &= "<nNFFin>" & parnNFFin & "</nNFFin>" & vbCrLf
        strInutilizacao &= "<xJust>" & parxJust & "</xJust>" & vbCrLf

        strInutilizacao &= "</infInut>" & vbCrLf
        strInutilizacao &= "</inutNFe>" & vbCrLf


        Return strInutilizacao

    End Function
End Class
