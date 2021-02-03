Imports Nano.clsFuncoes
Public Class frmConsultaChave2
    Public strRetorno As String
    Private Sub btnConsultar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultar.ItemClick
        If Validar(Me.txtChave) = False Then Exit Sub
        frmProcesNfe.strStatus = "Consulta"
        frmProcesNfe.strChaveAcesso = Me.txtChave.Text
        frmProcesNfe.Tag = "ConsultaChave"
        frmProcesNfe.strUF = SelecionarUF(Me.txtChave.Text.Substring(0, 2))
        frmProcesNfe.strTipoAmb = Me.rdgNfe.SelectedIndex + 1
        frmProcesNfe.strCaminhoNfe = ""
        frmProcesNfe.ShowDialog()

        If strRetorno <> "" Then
            If strRetorno = "NOK" Then Exit Sub

            Dim vetRetorno As Array = Split(strRetorno, "|EVENTO|")
            strRetorno = "<?xml version=""1.0"" encoding=""UTF-8""?><nfeProc><NFe>" & strRetorno & "</NFe></nfeProc>"

            'If NanoBanco = "0" Then

            '    Dim dtNF As DataTable = ArquivoNfeXml(strRetorno, "/nfeProc/NFe/infProt", "tpAmb Varchar(1), verAplic varchar(20), " & _
            '    "chNFe varchar(50), dhRecbto varchar(20), nProt varchar(30), digVal varchar(20), cStat varchar(10), xMotivo varchar(50)", "")
            '    If dtNF.Rows.Count > 0 Then
            '        Me.tbNFe.Rows.Add()
            '        Me.tbNFe.Rows.Item(0).Item("Titulo") = "NF-e"
            '        Me.tbNFe.Rows.Item(0).Item("TipoAmb") = dtNF.Rows.Item(0).Item("tpAmb").ToString
            '        Me.tbNFe.Rows.Item(0).Item("VerAplic") = dtNF.Rows.Item(0).Item("verAplic").ToString
            '        Me.tbNFe.Rows.Item(0).Item("Chave") = dtNF.Rows.Item(0).Item("chNFe").ToString
            '        Me.tbNFe.Rows.Item(0).Item("DataRecebimento") = dtNF.Rows.Item(0).Item("dhRecbto").ToString
            '        Me.tbNFe.Rows.Item(0).Item("NumProtocolo") = dtNF.Rows.Item(0).Item("nProt").ToString
            '        Me.tbNFe.Rows.Item(0).Item("ValorDigital") = dtNF.Rows.Item(0).Item("digVal").ToString
            '        Me.tbNFe.Rows.Item(0).Item("Status") = dtNF.Rows.Item(0).Item("cStat").ToString
            '        Me.tbNFe.Rows.Item(0).Item("Motivo") = dtNF.Rows.Item(0).Item("xMotivo").ToString
            '    End If


            '    dtNF = ArquivoNfeXml(strRetorno, "/nfeProc/NFe/infEvento", "tpAmb Varchar(1), verAplic varchar(20), " & _
            '    "cOrgao varchar(2), cStat varchar(10), xMotivo varchar(50), chNFe varchar(50), tpEvento varchar(10), " & _
            '    "xEvento varchar(30), nSeqEvento varchar(2), CPFDest varchar(20), emailDest varchar(30), " & _
            '    "dhRegEvento varchar(30), nProt varchar(30)", "")
            '    Dim I As Integer
            '    For I = 0 To dtNF.Rows.Count - 1


            '        Me.tbEvento.Rows.Add()
            '        Me.tbEvento.Rows.Item(0).Item("Titulo") = "EVENTO"
            '        Me.tbEvento.Rows.Item(I).Item("TipoAmb") = dtNF.Rows.Item(I).Item("tpAmb").ToString
            '        Me.tbEvento.Rows.Item(I).Item("VerAplic") = dtNF.Rows.Item(I).Item("verAplic").ToString
            '        Me.tbEvento.Rows.Item(I).Item("UF") = dtNF.Rows.Item(I).Item("cOrgao").ToString
            '        Me.tbEvento.Rows.Item(I).Item("Status") = dtNF.Rows.Item(I).Item("cStat").ToString
            '        Me.tbEvento.Rows.Item(I).Item("Motivo") = dtNF.Rows.Item(I).Item("xMotivo").ToString
            '        Me.tbEvento.Rows.Item(I).Item("ChaveNFe") = dtNF.Rows.Item(I).Item("chNFe").ToString
            '        Me.tbEvento.Rows.Item(I).Item("TipoEvento") = dtNF.Rows.Item(I).Item("tpEvento").ToString
            '        Me.tbEvento.Rows.Item(I).Item("Evento") = dtNF.Rows.Item(I).Item("xEvento").ToString
            '        Me.tbEvento.Rows.Item(I).Item("NumSeq") = dtNF.Rows.Item(I).Item("nSeqEvento").ToString
            '        Me.tbEvento.Rows.Item(I).Item("CPF") = dtNF.Rows.Item(I).Item("CPFDest").ToString
            '        Me.tbEvento.Rows.Item(I).Item("Email") = dtNF.Rows.Item(I).Item("emailDest").ToString
            '        Me.tbEvento.Rows.Item(I).Item("DataRegistro") = dtNF.Rows.Item(I).Item("dhRegEvento").ToString
            '        Me.tbEvento.Rows.Item(I).Item("NumProtocolo") = dtNF.Rows.Item(I).Item("nProt").ToString


            '    Next
            'Else
            Dim oXML As System.Xml.XmlDocument = New System.Xml.XmlDocument
            Dim ns As System.Xml.XmlNamespaceManager = New System.Xml.XmlNamespaceManager(oXML.NameTable)
            Dim NodeRoot As System.Xml.XmlNode

            ns.AddNamespace("nfe", "http://www.portalfiscal.inf.br/nfe")
            oXML.LoadXml(strRetorno)
            NodeRoot = oXML.SelectSingleNode("nfeProc/NFe/nfe:infProt", ns)
            Dim strtpAmb As String = ""
            Dim strverAplic As String = ""
            Dim strchNFe As String = ""
            Dim strdhRecbto As String = ""
            Dim strnProt As String = ""
            Dim strdigVal As String = ""
            Dim strcStat As String = ""
            Dim strxMotivo As String = ""
            For Each outerNode As Xml.XmlNode In NodeRoot
                Select Case outerNode.Name
                    Case "tpAmb"
                        strtpAmb = outerNode.InnerText
                    Case "verAplic"
                        strverAplic = outerNode.InnerText
                    Case "chNFe"
                        strchNFe = outerNode.InnerText
                    Case "dhRecbto"
                        strdhRecbto = outerNode.InnerText
                    Case "nProt"
                        strnProt = outerNode.InnerText
                    Case "digVal"
                        strdigVal = outerNode.InnerText
                    Case "cStat"
                        strcStat = outerNode.InnerText
                    Case "xMotivo"
                        strxMotivo = outerNode.InnerText
                End Select
            Next
            If strchNFe <> "" Then
                Me.tbNFe.Rows.Add()
                Me.tbNFe.Rows.Item(0).Item("Titulo") = "NF-e"
                Me.tbNFe.Rows.Item(0).Item("TipoAmb") = strtpAmb
                Me.tbNFe.Rows.Item(0).Item("VerAplic") = strverAplic
                Me.tbNFe.Rows.Item(0).Item("Chave") = strchNFe
                Me.tbNFe.Rows.Item(0).Item("DataRecebimento") = strdhRecbto
                Me.tbNFe.Rows.Item(0).Item("NumProtocolo") = strnProt
                Me.tbNFe.Rows.Item(0).Item("ValorDigital") = strdigVal
                Me.tbNFe.Rows.Item(0).Item("Status") = strcStat
                Me.tbNFe.Rows.Item(0).Item("Motivo") = strxMotivo
            End If


            NodeRoot = oXML.SelectSingleNode("nfeProc/NFe", ns)

            Dim I As Integer = 0
            For Each outerNode As Xml.XmlNode In NodeRoot
                Select Case outerNode.Name
                    Case "infEvento"
                        Dim strtpAmbEvento As String = ""
                        Dim strverAplicEvento As String = ""
                        Dim strchNFeEvento As String = ""
                        Dim strdhRecbtoEvento As String = ""
                        Dim strnProtEvento As String = ""
                        Dim strcStatEvento As String = ""
                        Dim strxMotivoEvento As String = ""

                        Dim strcOrgaoEvento As String = ""
                        Dim strtpEvento As String = ""
                        Dim strxEvento As String = ""
                        Dim strnSeqEvento As String = ""
                        Dim strCPFDestEvento As String = ""
                        Dim stremailDestEvento As String = ""
                        For Each outerNode1 As Xml.XmlNode In outerNode
                            Select Case outerNode1.Name
                                Case "tpAmb"
                                    strtpAmbEvento = outerNode1.InnerText
                                Case "verAplic"
                                    strverAplicEvento = outerNode1.InnerText
                                Case "cOrgao"
                                    strcOrgaoEvento = outerNode1.InnerText
                                Case "cStat"
                                    strcStatEvento = outerNode1.InnerText
                                Case "xMotivo"
                                    strxMotivoEvento = outerNode1.InnerText
                                Case "chNFe"
                                    strchNFeEvento = outerNode1.InnerText
                                Case "tpEvento"
                                    strtpEvento = outerNode1.InnerText
                                Case "xEvento"
                                    strxEvento = outerNode1.InnerText
                                Case "nSeqEvento"
                                    strnSeqEvento = outerNode1.InnerText
                                Case "CPFDest"
                                    strCPFDestEvento = outerNode1.InnerText
                                Case "emailDest"
                                    stremailDestEvento = outerNode1.InnerText
                                Case "dhRegEvento"
                                    strdhRecbtoEvento = outerNode1.InnerText
                                Case "nProt"
                                    strnProtEvento = outerNode1.InnerText
                            End Select
                        Next

                        Me.tbEvento.Rows.Add()
                        Me.tbEvento.Rows.Item(0).Item("Titulo") = "EVENTO"
                        Me.tbEvento.Rows.Item(I).Item("TipoAmb") = strtpAmbEvento
                        Me.tbEvento.Rows.Item(I).Item("VerAplic") = strverAplicEvento
                        Me.tbEvento.Rows.Item(I).Item("UF") = strcOrgaoEvento
                        Me.tbEvento.Rows.Item(I).Item("Status") = strcStatEvento
                        Me.tbEvento.Rows.Item(I).Item("Motivo") = strxMotivoEvento
                        Me.tbEvento.Rows.Item(I).Item("ChaveNFe") = strchNFeEvento
                        Me.tbEvento.Rows.Item(I).Item("TipoEvento") = strtpEvento
                        Me.tbEvento.Rows.Item(I).Item("Evento") = strxEvento
                        Me.tbEvento.Rows.Item(I).Item("NumSeq") = strnSeqEvento
                        Me.tbEvento.Rows.Item(I).Item("CPF") = strCPFDestEvento
                        Me.tbEvento.Rows.Item(I).Item("Email") = stremailDestEvento
                        Me.tbEvento.Rows.Item(I).Item("DataRegistro") = strdhRecbtoEvento
                        Me.tbEvento.Rows.Item(I).Item("NumProtocolo") = strnProtEvento
                        I += 1
                End Select

            Next

        End If


        'End If
    End Sub

End Class