Imports System.IO
Imports Nano.clsSAT
Imports Nano.clsFuncoes
Imports System.Runtime.InteropServices
Public Class frmMenuSAT
    Dim ACK As Integer
    Dim ST1 As Integer
    Dim ST2 As Integer
    Dim ST3 As Integer
    Private Sub frmMenuSAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Login = "ADM" And Senha = "SPFC" Then
            Me.btnConfig.Enabled = True
            Me.btnAtivacao.Enabled = True
            Me.chkSatTeste.Visible = True
            Me.chkSatTeste.Checked = SatTeste
            Me.btnAlterarNumeroSessao.Enabled = True
            Me.btnInstalar.Enabled = True
            Me.btnAtualizarSW.Enabled = True
        End If

        If ModeloSAT <> "BEMATECH" Then
            Me.btnLX.Text = "Imprimir via Xml"
            Me.btnReducaoZ.Text = "Consulta Ult. Sessão"
            Me.btnUltimasInf.Text = "Extrair Log."
            Me.btnRetornaSefaz.Text = "Consulta Sat"
            Me.btnDados.Text = "Consulta Status"
        End If
        Me.pnlMarquee.Location = New System.Drawing.Point(150, 150)
        Me.pnlMarquee.Size = New System.Drawing.Size(352, 51)
    End Sub

    Private Sub btnLX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLX.Click
        If ModeloSAT = "BEMATECH" Then
            iRetorno = ImportsDLL.Bematech_FI_LeituraX()
            iRetorno = Bematech_FI_LeituraXSerial()

            Dim oLeitura As System.IO.StreamReader

            oLeitura = File.OpenText("C:\SAT\Retorno.txt")
            Dim strTexto As String = oLeitura.ReadToEnd
            Me.rtfSAT.Text = strTexto

        Else
            ofdXml.FileName = ""
            ofdXml.Filter = "|*xml"
            ofdXml.ShowDialog()
            If ofdXml.FileName <> "" Then

                Dim fluxoTexto As IO.StreamReader
                Dim strTexto As String = ""

                If IO.File.Exists(ofdXml.FileName) Then
                    fluxoTexto = New IO.StreamReader(ofdXml.FileName)
                    strTexto = fluxoTexto.ReadToEnd
                    fluxoTexto.Close()
                End If

                If strTexto.Contains("</KeyInfo></Signature></CFe>") = True Then
                    GerarSat.GerarCupomSatAccess(ofdXml.FileName, "")

                ElseIf strTexto.Contains("</KeyInfo></Signature></CFeCanc>") = True Then
                    GerarSat.GerarCupomCancelamentoSat(strTexto, "")

                Else
                    MsgBox("Arquivo inválido!", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnReducaoZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReducaoZ.Click
        If ModeloSAT = "BEMATECH" Then
            iRetorno = ImportsDLL.Bematech_FI_ReducaoZ("", "")
            If iRetorno = 1 Then
                Me.rtfSAT.Text = "Redução Z"
                Dim dtConfigEcf As DataTable = CarregarDataTable("SELECT Codigo FROM ConfigEcf where CodigoEquipamento = '" & CodigoEquipamento & "'")
                If dtConfigEcf.Rows.Count > 0 Then
                    Dim I As Integer

                    For I = 0 To dtConfigEcf.Rows.Count - 1
                        Dim strCod As String = dtConfigEcf.Rows.Item(I).Item("Codigo").ToString

                        Inserir("INSERT INTO Operador (Operador, Tipo, Entrada, Data, CodConfig, CodConfigECF) VALUES " & _
                                                          "('" & Login & "','Fechamento',0,'" & My.Computer.Clock.LocalTime & "'," & _
                                                          "" & CodConfig & "," & strCod & ")")
                    Next
                End If
            End If

        Else
            'frmConsVendaSAT.ShowDialog()
            ' Me.rtfSAT.Text = VerificarUltimaSessao()

            frmNumeroSessao.Tag = "VERIFICAR"
            frmNumeroSessao.ShowDialog()
        End If
     
    End Sub

    Private Sub btnCancelaCupom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelaCupom.Click
        If ModeloSAT = "BEMATECH" Then

            iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
            If iRetorno = 1 Then
                Me.rtfSAT.Text = "Cancela Cupom"
            End If

        Else
            frmCancelarSAT.ShowDialog()
        End If
       
    End Sub

    Private Sub btnUltimasInf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimasInf.Click
        If ModeloSAT = "BEMATECH" Then
            Dim strA As String = Space(47)
            Dim strB As String = Space(6)
            Dim strC As String = Space(9)

            iRetorno = ImportsDLL.Bematech_FI_UltimasInformacoesSAT(strA, strB, strC)

            Dim strDados1 As String = ""

            Me.rtfSAT.Text = "Última Chave de acesso: " & strA
            strDados1 = Me.rtfSAT.Text & vbCrLf
            Me.rtfSAT.Text = "Número da Nota: " & strB
            strDados1 &= Me.rtfSAT.Text & vbCrLf
            Me.rtfSAT.Text = "Número de série do SAT: " & strC
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Me.rtfSAT.Text = strDados1

        ElseIf ModeloSAT = "BEMATECHDLL" Then
            Try

                Dim cmdLineStr As IntPtr = clsBematechSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                SatRetorno = clsBematechSatDLL.Base64ToAscii(SatRetorno, 5)


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "ELGIN" Then
            Dim cmdLineStr As IntPtr = clsElginSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            cmdLineStr = clsElginSatDLL.Base64ToAscii()
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            Me.rtfSAT.Text = SatRetorno

        ElseIf ModeloSAT = "ELGIN 2" Then
            Dim cmdLineStr As IntPtr = clsElginSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            SatRetorno = clsElginSatDLL.Base64ToAscii2(SatRetorno, 5)

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "GERTEC" Then
            Dim cmdLineStr As IntPtr = clsGertecSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            SatRetorno = clsGertecSatDLL.Base64ToAscii2(SatRetorno, 5)

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "EPSON" Then
            Dim cmdLineStr As IntPtr = clsEpsonSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            SatRetorno = clsEpsonSatDLL.Base64ToAscii2(SatRetorno, 5)

            Me.rtfSAT.Text = SatRetorno



        ElseIf ModeloSAT = "DIMEP" Then

            Dim cmdLineStr As IntPtr = clsDimepSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            cmdLineStr = clsDimepSatDLL.Base64ToAscii()
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            Me.rtfSAT.Text = SatRetorno


        ElseIf ModeloSAT = "EASYS" Then
            Dim cmdLineStr As IntPtr = clsEasysSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            SatRetorno = clsEasysSatDLL.Base64ToAscii2(SatRetorno, 5)

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "TANCA" Then

            Dim cmdLineStr As IntPtr = clsTancaSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            Me.rtfSAT.Text = clsTancaSatDLL.Base64ToAscii(SatRetorno, 5)
        ElseIf ModeloSAT = "SWEDA" Then
            Dim cmdLineStr As IntPtr = clsSwedaSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            SatRetorno = clsSwedaSatDLL.Base64ToAscii2(SatRetorno, 5)

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "CONTROLID" Then
            Dim cmdLineStr As IntPtr = clsControlidSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            SatRetorno = clsControlidSatDLL.Base64ToAscii2(SatRetorno, 5)

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "CUSTOM" Then
            Dim cmdLineStr As IntPtr = clsCustomSatDLL.ExtrairLogs(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            SatRetorno = clsCustomSatDLL.Base64ToAscii2(SatRetorno, 5)

            Me.rtfSAT.Text = SatRetorno
        End If

    End Sub

    Private Sub btnRetornaSefaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornaSefaz.Click
        If ModeloSAT = "BEMATECH" Then
            Dim strA As String = Space(255)
            Dim strB As String = Space(3)
            Dim strC As String = Space(255)
            Dim strD As String = Space(4)
            Dim strDados1 As String = ""

            iRetorno = ImportsDLL.Bematech_FI_RetornaMensagemSeFazSAT(strA, strB, strC, strD)

            Me.rtfSAT.Text = "Mensagem: " & strA
            strDados1 = Me.rtfSAT.Text & vbCrLf
            Me.rtfSAT.Text = "Código: " & strB
            strDados1 &= Me.rtfSAT.Text & vbCrLf
            Me.rtfSAT.Text = "Erro: " & strC
            strDados1 &= Me.rtfSAT.Text & vbCrLf
            Me.rtfSAT.Text = "Código de Erro: " & strC
            strDados1 &= Me.rtfSAT.Text & vbCrLf
            Me.rtfSAT.Text = strDados1
        ElseIf ModeloSAT = "BEMATECHDLL" Then
            Try

                Dim cmdLineStr As IntPtr = clsBematechSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "ELGIN" Then
            Try
                Dim cmdLineStr As IntPtr = clsElginSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "ELGIN 2" Then
            Try
                Dim cmdLineStr As IntPtr = clsElginSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno

        ElseIf ModeloSAT = "GERTEC" Then
            Try
                Dim cmdLineStr As IntPtr = clsGertecSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "EPSON" Then
            Try
                Dim cmdLineStr As IntPtr = clsEpsonSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno

        ElseIf ModeloSAT = "DIMEP" Then



            Try
                Dim cmdLineStr As IntPtr = clsDimepSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno

        ElseIf ModeloSAT = "TANCA" Then



            Try
                Dim cmdLineStr As IntPtr = clsTancaSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno

        ElseIf ModeloSAT = "EASYS" Then
            Try
                Dim cmdLineStr As IntPtr = clsEasysSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno

        ElseIf ModeloSAT = "SWEDA" Then
            Try
                Dim cmdLineStr As IntPtr = clsSwedaSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "CONTROLID" Then
            Try
                Dim cmdLineStr As IntPtr = clsControlidSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "CUSTOM" Then
            Try
                Dim cmdLineStr As IntPtr = clsCustomSatDLL.ConsultarSAT(NumeroSessaoSat())
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                'SatRetorno = SATFiscalDLL.ConsultarSAT("1")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            Me.rtfSAT.Text = SatRetorno
        End If
  

    End Sub
  
    Private Sub btnDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDados.Click
        If ModeloSAT = "BEMATECH" Then
            Dim strDados1 As String = ""

            Dim strCOO As String = Space(7)
            iRetorno = Bematech_FI_NumeroCupom(strCOO)
            Me.rtfSAT.Text = "COO: " & strCOO.ToString.Trim
            strDados1 = Me.rtfSAT.Text & vbCrLf
            Dim strCRO As String = Space(5)
            iRetorno = Bematech_FI_NumeroIntervencoes(strCRO)
            Me.rtfSAT.Text = "CRO: " & strCRO.Trim
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strCC As String = Space(5)
            iRetorno = Bematech_FI_NumeroCuponsCancelados(strCC)
            Me.rtfSAT.Text = "CC: " & strCC & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strCCF As String = Space(7)
            iRetorno = Bematech_FI_ContadorCupomFiscalMFD(strCCF)
            Me.rtfSAT.Text = "CCF: " & strCCF & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strCRZ As String = Space(5)
            iRetorno = Bematech_FI_NumeroReducoes(strCRZ)
            Me.rtfSAT.Text = "CRZ: " & strCRZ & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strCRZ_R As String = Space(5)
            iRetorno = Bematech_FI_ReducoesRestantesMFD(strCRZ_R)
            Me.rtfSAT.Text = "CRZ_R: " & strCRZ_R & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strGNF As String = Space(7)
            iRetorno = Bematech_FI_NumeroOperacoesNaoFiscais(strGNF)
            Me.rtfSAT.Text = "GNF: " & strGNF & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strCDC As String = Space(5)
            iRetorno = Bematech_FI_ContadorComprovantesCreditoMFD(strCDC)
            Me.rtfSAT.Text = "CDC: " & strCDC & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strGRG As String = Space(7)
            iRetorno = Bematech_FI_ContadorRelatoriosGerenciaisMFD(strGRG)
            Me.rtfSAT.Text = "GRG:" & strGRG & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strGT As String = Space(19)
            iRetorno = Bematech_FI_GrandeTotal(strGT)
            Me.rtfSAT.Text = "GT: " & strGT & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf


            Dim strDataReducao As String = Space(7)
            Dim strHoraReducao As String = Space(7)
            iRetorno = Bematech_FI_DataHoraReducao(strDataReducao, strHoraReducao)
            Me.rtfSAT.Text = "Data Ultima RZ: " & strDataReducao & " " & strHoraReducao & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strData As String = Space(7)
            Dim strHora As String = Space(7)
            iRetorno = Bematech_FI_DataHoraImpressora(strData, strHora)
            Me.rtfSAT.Text = "Data Hora SAT: " & strData & " " & strHora & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim strDataMovimento As String = Space(7)
            iRetorno = Bematech_FI_DataMovimento(strDataMovimento)
            Me.rtfSAT.Text = "Data Ultimo Movimento: " & strDataMovimento & vbCrLf

            Dim strAliquotasCad As String = Space(80)
            iRetorno = Bematech_FI_RetornoAliquotas(strAliquotasCad)
            Me.rtfSAT.Text = "Aliquota Cadastradas: " & strAliquotasCad & vbCrLf
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Dim intFlag As Integer
            iRetorno = Bematech_FI_FlagsFiscais(intFlag)

            Select Case intFlag
                Case 4, 12, 13, 15, 20, 21, 23, 36, 37, 39, 44, 45, 47, 132, 133, 135, 164, 165, 167, 172, 173, 175
                    Me.rtfSAT.Text = "Horário Verão: " & "Habilitado" & vbCrLf
                Case Else
                    Me.rtfSAT.Text = "Horário Verão: " & "Desabilitado" & vbCrLf
            End Select
            strDados1 &= Me.rtfSAT.Text & vbCrLf

            Me.rtfSAT.Text = strDados1

        ElseIf ModeloSAT = "BEMATECHDLL" Then
            Try

                Dim cmdLineStr As IntPtr = clsBematechSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                If SatRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(SatRetorno, "|")

                    SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                    SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                    SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                    SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                    SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                    SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                    SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                    SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                    SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                    SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                    SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                    SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                    SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                    SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                    SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                    SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                    SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                    SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                    SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                    SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                    SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                    SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                    Dim strEstadoOp As String = ""
                    Select Case vetRetorno(27)
                        Case "0"
                            strEstadoOp = "DESBLOQUEADO"
                        Case "1"
                            strEstadoOp = "BLOQUEIO SEFAZ"
                        Case "2"
                            strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                        Case "3"
                            strEstadoOp = "BLOQUEIO AUTÔNOMO"
                        Case "4"
                            strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                    End Select
                    SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


                End If
                Me.rtfSAT.Text = SatRetorno

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

        ElseIf ModeloSAT = "ELGIN" Then
            Dim cmdLineStr As IntPtr = clsElginSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "ELGIN 2" Then
            Dim cmdLineStr As IntPtr = clsElginSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "GERTEC" Then
            Dim cmdLineStr As IntPtr = clsGertecSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno

        ElseIf ModeloSAT = "EPSON" Then
            Dim cmdLineStr As IntPtr = clsEpsonSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "EASYS" Then
            Dim cmdLineStr As IntPtr = clsEasysSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "TANCA" Then
            Dim cmdLineStr As IntPtr = clsTancaSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "SWEDA" Then
            Dim cmdLineStr As IntPtr = clsSwedaSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "CONTROLID" Then
            Dim cmdLineStr As IntPtr = clsControlidSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        ElseIf ModeloSAT = "CUSTOM" Then
            Dim cmdLineStr As IntPtr = clsCustomSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbCrLf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbCrLf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbCrLf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        Else
            Dim cmdLineStr As IntPtr = clsDimepSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            If SatRetorno.Contains("Resposta com Sucesso") = True Then
                Dim vetRetorno As Array = Split(SatRetorno, "|")

                SatRetorno = "Nº Série: " & vetRetorno(5) & vbCrLf
                SatRetorno &= "Tipo Lan: " & vetRetorno(6) & vbcrlf
                SatRetorno &= "Lan IP: " & vetRetorno(7) & vbCrLf
                SatRetorno &= "Lan Mac: " & vetRetorno(8) & vbCrLf
                SatRetorno &= "Lan Mask: " & vetRetorno(9) & vbcrlf
                SatRetorno &= "Lan GW: " & vetRetorno(10) & vbCrLf
                SatRetorno &= "Lan DNS 1: " & vetRetorno(11) & vbCrLf
                SatRetorno &= "Lan DNS 2: " & vetRetorno(12) & vbCrLf
                SatRetorno &= "Status Lan: " & vetRetorno(13) & vbCrLf
                SatRetorno &= "Nivel Bateria: " & vetRetorno(14) & vbCrLf
                SatRetorno &= "MT Total: " & vetRetorno(15) & vbcrlf
                SatRetorno &= "MT Usada: " & vetRetorno(16) & vbCrLf
                SatRetorno &= "Data Hora: " & vetRetorno(17) & vbCrLf
                SatRetorno &= "Versão SB: " & vetRetorno(18) & vbCrLf
                SatRetorno &= "Versão Layout: " & vetRetorno(19) & vbCrLf
                SatRetorno &= "Último CF-e: " & vetRetorno(20) & vbCrLf
                SatRetorno &= "Lista Inicial: " & vetRetorno(21) & vbCrLf
                SatRetorno &= "Lista Final: " & vetRetorno(22) & vbCrLf
                SatRetorno &= "Data Hora CF-e: " & vetRetorno(23) & vbCrLf
                SatRetorno &= "Data Hora Comunicação: " & vetRetorno(24) & vbCrLf
                SatRetorno &= "Data Emissão Cert.: " & vetRetorno(25) & vbCrLf
                SatRetorno &= "Data Venc. Cert.: " & vetRetorno(26) & vbCrLf

                Dim strEstadoOp As String = ""
                Select Case vetRetorno(27)
                    Case "0"
                        strEstadoOp = "DESBLOQUEADO"
                    Case "1"
                        strEstadoOp = "BLOQUEIO SEFAZ"
                    Case "2"
                        strEstadoOp = "BLOQUEIO CONTRIBUINTE"
                    Case "3"
                        strEstadoOp = "BLOQUEIO AUTÔNOMO"
                    Case "4"
                        strEstadoOp = "BLOQUEIO PARA DESATIVAÇÃO"
                End Select
                SatRetorno &= "Estado Operacional: " & strEstadoOp & vbCrLf


            End If
            Me.rtfSAT.Text = SatRetorno
        End If
        
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Me.rtfSAT.Text, Font, Brushes.Black, 10, 10)
    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        If ModeloSAT = "BEMATECH" Then
            frmConfigFiscal.ShowDialog()
        Else
            frmConfigSAT.ShowDialog()
        End If
    End Sub


    Private Sub btnAtivacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtivacao.Click
        frmAtivacaoSAT.ShowDialog()
    End Sub

    Private Sub chkSatTeste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSatTeste.CheckedChanged
        SatTeste = Me.chkSatTeste.Checked
    End Sub

    Private Sub btnAlterarNumeroSessao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterarNumeroSessao.Click
        frmNumeroSessao.Tag = "ALTERAR"
        frmNumeroSessao.ShowDialog()
    End Sub

    Private Sub btnInstalar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstalar.Click
        frmInstalarSat.Tag = "SAT"
        frmInstalarSat.ShowDialog()


    End Sub

    Private Sub btnGerarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarArquivo.Click
        frmGerarArquivo.ShowDialog()
    End Sub

    Private Sub btnAtualizarSW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizarSW.Click
        If MsgBox("Tem certeza que deseja atualizar o software do SAT?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Barra(True)
            Dim cmdLineStr As IntPtr
            Dim strMensagem As String = ""
            Try
                If ModeloSAT = "DIMEP" Then
                    cmdLineStr = clsDimepSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "TANCA" Then
                    cmdLineStr = clsTancaSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "ELGIN" Then
                    cmdLineStr = clsElginSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "ELGIN 2" Then
                    cmdLineStr = clsElginSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "GERTEC" Then
                    cmdLineStr = clsGertecSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "EPSON" Then
                    cmdLineStr = clsEpsonSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "EASYS" Then
                    cmdLineStr = clsEasysSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "BEMATECHDLL" Then
                    cmdLineStr = clsBematechSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "SWEDA" Then
                    cmdLineStr = clsSwedaSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "CONTROLID" Then
                    cmdLineStr = clsControlidSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "CUSTOM" Then
                    cmdLineStr = clsCustomSatDLL.AtualizarSoftwareSAT(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                End If
            Catch ex As Exception
                Barra(False)
                Me.rtfSAT.Text = ex.Message
                Exit Sub
            End Try

            strMensagem = SatRetorno

            Dim strVersaoXml As String = VersaoXmlSAT
            Try
                If ModeloSAT = "DIMEP" Then
                    cmdLineStr = clsDimepSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If

                ElseIf ModeloSAT = "TANCA" Then
                    cmdLineStr = clsTancaSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If
                ElseIf ModeloSAT = "ELGIN" Then
                    cmdLineStr = clsElginSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If

                ElseIf ModeloSAT = "ELGIN 2" Then
                    cmdLineStr = clsElginSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If
                ElseIf ModeloSAT = "GERTEC" Then
                    cmdLineStr = clsGertecSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If

                ElseIf ModeloSAT = "EPSON" Then
                    cmdLineStr = clsEpsonSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If
                ElseIf ModeloSAT = "EASYS" Then
                    cmdLineStr = clsEasysSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                    End If
                ElseIf ModeloSAT = "BEMATECHDLL" Then
                    cmdLineStr = clsBematechSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If
                ElseIf ModeloSAT = "SWEDA" Then
                    cmdLineStr = clsSwedaSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If
                ElseIf ModeloSAT = "CONTROLID" Then
                    cmdLineStr = clsControlidSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If
                ElseIf ModeloSAT = "CUSTOM" Then
                    cmdLineStr = clsCustomSatDLL.ConsultarStatusOperacional(NumeroSessaoSat(), NumeroSerieECF)
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    If SatRetorno.Contains("Resposta com Sucesso") = True Then
                        Dim vetRetorno As Array = Split(SatRetorno, "|")
                        If vetRetorno(19).ToString.Contains("7") = True Then
                            strVersaoXml = "0.07"
                        End If
                        If vetRetorno(19).ToString.Contains("8") = True Then
                            strVersaoXml = "0.08"
                        End If
                    End If
                End If


            Catch ex As Exception

                Barra(False)
                Me.rtfSAT.Text = strMensagem & ex.Message
                Exit Sub
            End Try
            VersaoXmlSAT = strVersaoXml
            Atualizar("UPDATE ConfigECF SET  VersaoXmlSAT = '" & strVersaoXml & "' where Codigo = " & CodConfigECF)
            Barra(False)
            Me.rtfSAT.Text = strMensagem
        End If
    End Sub
    Private Sub Barra(ByVal parOk As Boolean)
        If parOk = True Then
            Me.pnlMarquee.Visible = True
            Me.btnFechar.Enabled = False

        Else
            Me.pnlMarquee.Visible = False
            Me.btnFechar.Enabled = True

        End If
    End Sub
End Class