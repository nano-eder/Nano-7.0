Imports Nano.clsFuncoes
Imports System.Runtime.InteropServices
Public Class frmAtivacaoSAT
    Private Sub frmAtivacaoSAT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cboModSAT.Text = ModeloSAT
        LimparConfigRede()

        Me.pnlMarquee.Location = New System.Drawing.Point(171, 104)
        Me.pnlMarquee.Size = New System.Drawing.Size(352, 51)
    End Sub
    Private Sub LimparConfigRede()
        Me.cboTipoInterface.SelectedIndex = 0
        Me.cboSeguranca.SelectedIndex = 0
        Me.cboTipoLan.SelectedIndex = 0
        Me.cboTipoProxy.SelectedIndex = 0
    End Sub
    Private Sub cboTipoInterface_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoInterface.SelectedIndexChanged
        Me.cboSeguranca.SelectedIndex = 0
        Me.txtNomeRede.ResetText()
        Me.txtSenhaInterface.ResetText()

        Select Case Me.cboTipoInterface.SelectedIndex
            Case 0
                Me.cboSeguranca.Enabled = False
                Me.txtSenhaInterface.Enabled = False
                Me.txtNomeRede.Enabled = False
            Case 1
                Me.cboSeguranca.Enabled = True
                Me.txtNomeRede.Enabled = True
        End Select
    End Sub

    Private Sub cboSeguranca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeguranca.SelectedIndexChanged
        Me.txtSenhaInterface.ResetText()

        Select Case Me.cboSeguranca.SelectedIndex
            Case 0
                Me.txtSenhaInterface.Enabled = False
            Case Else
                Me.txtSenhaInterface.Enabled = True
        End Select
    End Sub

    Private Sub cboTipoLan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoLan.SelectedIndexChanged
        Me.txtIPLan.ResetText()
        Me.txtMascara.ResetText()
        Me.txtGateway.ResetText()
        Me.txtDNS1.ResetText()
        Me.txtDNS2.ResetText()
        Select Case Me.cboTipoLan.SelectedIndex
            Case 0

                Me.txtIPLan.Enabled = False
                Me.txtMascara.Enabled = False
                Me.txtGateway.Enabled = False
                Me.txtDNS1.Enabled = False
                Me.txtDNS2.Enabled = False
            Case 1
                Me.txtIPLan.Enabled = True
                Me.txtMascara.Enabled = True
                Me.txtGateway.Enabled = True
                Me.txtDNS1.Enabled = True
                Me.txtDNS2.Enabled = True
        End Select
    End Sub

    Private Sub cboTipoProxy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoProxy.SelectedIndexChanged
        Me.txtIPProxy.ResetText()
        Me.txtPorta.ResetText()
        Me.txtUsuarioProxy.ResetText()
        Me.txtSenhaProxy.ResetText()
        Select Case Me.cboTipoProxy.SelectedIndex
            Case 0
                Me.txtIPProxy.Enabled = False
                Me.txtPorta.Enabled = False
                Me.txtUsuarioProxy.Enabled = False
                Me.txtSenhaProxy.Enabled = False
            Case Else
                Me.txtIPProxy.Enabled = True
                Me.txtPorta.Enabled = True
                Me.txtUsuarioProxy.Enabled = True
                Me.txtSenhaProxy.Enabled = True
        End Select
    End Sub

    Private Sub btnLimparRede_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparRede.Click
        If MsgBox("Tem certeza que deseja limpar todos os campos da aba configurar rede?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            LimparConfigRede()
        End If
    End Sub

    Private Sub btnConfigRede_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigRede.Click
        Barra(True)

        Dim strConfigRede As String = clsSAT.ConfigurarRede(Me.cboTipoInterface.Text, Me.txtNomeRede.Text, Me.cboSeguranca.Text, _
        Me.txtSenhaInterface.Text, Me.cboTipoLan.Text, Me.txtIPLan.Text, Me.txtMascara.Text, _
        Me.txtGateway.Text, Me.txtDNS1.Text, Me.txtDNS2.Text, Me.cboTipoProxy.SelectedIndex, _
        Me.txtIPProxy.Text, Me.txtPorta.Text, Me.txtUsuarioProxy.Text, Me.txtSenhaProxy.Text)

        Barra(False)

        MsgBox(strConfigRede, MsgBoxStyle.Information)



    End Sub
    Private Sub Barra(ByVal parOk As Boolean)
        If parOk = True Then
            Me.pnlMarquee.Visible = True
            Me.btnConfigRede.Enabled = False
            Me.btnLimparRede.Enabled = False
            Me.btnFechar.Enabled = False

            Me.btnAtivar.Enabled = False
            Me.btnLimparAtivacao.Enabled = False

            Me.btnAssociar.Enabled = False
            Me.btnLimparAssociacao.Enabled = False

            Me.btnTrocarCodAtivacao.Enabled = False
            Me.btnLimparCodAtivacao.Enabled = False
        Else
            Me.pnlMarquee.Visible = False
            Me.btnConfigRede.Enabled = True
            Me.btnLimparRede.Enabled = True
            Me.btnFechar.Enabled = True

            Me.btnAtivar.Enabled = True
            Me.btnLimparAtivacao.Enabled = True

            Me.btnAssociar.Enabled = True
            Me.btnLimparAssociacao.Enabled = True

            Me.btnTrocarCodAtivacao.Enabled = True
            Me.btnLimparCodAtivacao.Enabled = True
        End If
    End Sub
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub



    Private Sub btnAtivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtivar.Click
        If Validar(Me.txtCodAtivacao) = False Then Exit Sub
        If Validar(Me.txtConCodAtivacao) = False Then Exit Sub
        If Validar(Me.txtCNPJ) = False Then Exit Sub
        If Validar(Me.cboModSAT) = False Then Exit Sub

        If Me.txtCodAtivacao.Text.Length < 8 Then
            MsgBox("O código de ativação tem que ter no mínimo 8 caracter!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.txtCodAtivacao.Text <> Me.txtConCodAtivacao.Text Then
            MsgBox("Código de ativação diferente da confirmação!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim strCodUF As String = SelecionarCodigoUF(Me.cboUF.Text)
        Dim strCNPJ As String = Me.txtCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "")

        Barra(True)

        Dim cmdLineStr As IntPtr
        If ModeloSAT = "DIMEP" Then
            cmdLineStr = clsDimepSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "ELGIN" Then
            cmdLineStr = clsElginSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "ELGIN 2" Then
            cmdLineStr = clsElginSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "GERTEC" Then
            cmdLineStr = clsGertecSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "EPSON" Then
            cmdLineStr = clsEpsonSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "EASYS" Then
            cmdLineStr = clsEasysSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "BEMATECHDLL" Then
            cmdLineStr = clsBematechSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "TANCA" Then
            cmdLineStr = clsTancaSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "SWEDA" Then
            cmdLineStr = clsSwedaSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "CONTROLID" Then
            cmdLineStr = clsControlidSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "CUSTOM" Then
            cmdLineStr = clsCustomSatDLL.AtivarSAT(NumeroSessaoSatAtivacao(), 1, Me.txtCodAtivacao.Text, strCNPJ, strCodUF)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        End If

        Barra(False)

       If SatRetorno.ToUpper.Contains("CORRETAMENTE") = True Then
            Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM ConfigECF where CNPJ = '" & Me.txtCNPJ.Text & "'")
            If dt.Rows.Count = 0 Then
                Dim strImp As String = ""
                Select Case Impressora
                    Case "DARUMA", "EPSON"
                        strImp = Impressora
                    Case "BEMATECH MP - 4000"
                        strImp = "MP-4200 TH"
                    Case "ESC/POS EPSON"
                        strImp = "TERMICA MARGEM"
                    Case "ESC/POS DARUMA", "ESC/POS BEMATECH"
                        strImp = "TERMICA"
                    Case Else
                        strImp = "NORMAL"
                End Select


                Inserir("INSERT INTO ConfigECF (CNPJ, IE, NumeroSerie, Computador, NumeroECF, CodConfig, ModeloImpSAT, " & _
                "CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, ModeloSAT) VALUES ('" & Me.txtCNPJ.Text & "','" & Me.txtIE.Text & "'," & _
                "'" & Me.txtCodAtivacao.Text & "','" & My.Computer.Name.ToUpper & "','001'," & CodConfig & ",'" & strImp & "'," & _
                "'C:\SAT\Remessas','" & PortaImpressora & "','False','" & Me.cboModSAT.Text & "')")

                dt = CarregarDataTable("SELECT Codigo FROM ConfigECF " & _
                "where Computador = '" & My.Computer.Name.ToUpper & "' and CodConfig = " & CodConfig)

                CodConfigECF = dt.Rows.Item(0).Item("Codigo").ToString
                CNPJECF = Me.txtCNPJ.Text
                IEECF = Me.txtIE.Text
                NumeroSerieECF = Me.txtCodAtivacao.Text
                NumeroEcfECF = "001"
                ComputadorECF = My.Computer.Name.ToUpper
                ModeloImpSAT = strImp
                CaminhoPastaSAT = "C:\SAT\Remessas"
                NomeImpSAT = PortaImpressora
                ImpDiretoSAT = False
            End If
        End If

        MsgBox(SatRetorno, MsgBoxStyle.Information)



    End Sub

    Private Sub LimparAtivacao()
        Me.txtCodAtivacao.ResetText()
        Me.txtConCodAtivacao.ResetText()
        Me.txtCNPJ.ResetText()
        Me.cboUF.Text = "SP"
        Me.txtCodAtivacao.Focus()
    End Sub
    Private Sub txtCNPJ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNPJ.KeyPress

        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarDocumento(Me.txtCNPJ, "Cnpj")
    End Sub

    Private Sub txtCNPJ_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.Leave
        If Me.txtCNPJ.Text.Trim = "" Then Exit Sub

        If ValidaCPF(Me.txtCNPJ.Text.Trim) = False Then
            Me.txtCNPJ.ResetText()
            Me.txtCNPJ.Focus()
            Exit Sub
        End If

        If Me.txtCNPJ.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCNPJ.ResetText()
            Exit Sub
        End If
    End Sub

    Private Sub btnLimparAtivacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparAtivacao.Click
        If MsgBox("Tem certeza que deseja limpar todos os campos da aba ativar sat?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            LimparAtivacao()
        End If
    End Sub

    Private Sub btnAssociar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssociar.Click
        If Validar(Me.txtAssinatura) = False Then Exit Sub
        If Validar(Me.txtCNPJ2) = False Then Exit Sub

        Dim strCNPJ As String = Me.txtCNPJ2.Text.Replace(".", "").Replace("/", "").Replace("-", "")

        'EraSystemsCNPJ = "16.716.114/0001-72"

        Dim strCNPJSistema As String = EraSystemsCNPJ.Replace(".", "").Replace("/", "").Replace("-", "")

        strCNPJ = strCNPJSistema & strCNPJ

        Barra(True)
        Dim strVersaoXml As String = "0.06"
        Dim cmdLineStr As IntPtr

        Dim strRetorno As String = ""
        Try
            If ModeloSAT = "DIMEP" Then
                cmdLineStr = clsDimepSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "ELGIN" Then
                cmdLineStr = clsElginSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "ELGIN 2" Then
                cmdLineStr = clsElginSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "GERTEC" Then
                cmdLineStr = clsGertecSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "EPSON" Then
                cmdLineStr = clsEpsonSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "EASYS" Then
                cmdLineStr = clsEasysSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "BEMATECHDLL" Then
                cmdLineStr = clsBematechSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "TANCA" Then
                cmdLineStr = clsTancaSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "SWEDA" Then
                cmdLineStr = clsSwedaSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "CONTROLID" Then
                cmdLineStr = clsControlidSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "CUSTOM" Then
                cmdLineStr = clsCustomSatDLL.AssociarAssinatura(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text, strCNPJ, Me.txtAssinatura.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            End If



            If ModeloSAT = "DIMEP" Then
                cmdLineStr = clsDimepSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "ELGIN" Then
                cmdLineStr = clsElginSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If

            ElseIf ModeloSAT = "ELGIN 2" Then
                cmdLineStr = clsElginSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "GERTEC" Then
                cmdLineStr = clsGertecSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "EPSON" Then
                cmdLineStr = clsEpsonSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "EASYS" Then
                cmdLineStr = clsEasysSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "BEMATECHDLL" Then
                cmdLineStr = clsBematechSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "TANCA" Then
                cmdLineStr = clsTancaSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "SWEDA" Then
                cmdLineStr = clsSwedaSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "CONTROLID" Then
                cmdLineStr = clsControlidSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            ElseIf ModeloSAT = "CUSTOM" Then
                cmdLineStr = clsCustomSatDLL.ConsultarStatusOperacional(NumeroSessaoSatAtivacao(), Me.txtCodAtivacaoAssociacao.Text)
                strRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                If strRetorno.Contains("Resposta com Sucesso") = True Then
                    Dim vetRetorno As Array = Split(strRetorno, "|")
                    If vetRetorno(19).ToString.Contains("7") = True Then
                        strVersaoXml = "0.07"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Barra(False)
            Exit Sub
        End Try


        Barra(False)

        If SatRetorno.ToUpper.Contains("AC REGISTRADA") = True Then
            Atualizar("UPDATE ConfigECF SET Assinatura = '" & Me.txtAssinatura.Text & "', VersaoXmlSAT = '" & strVersaoXml & "' where Codigo = " & CodConfigECF)
        End If


        MsgBox(SatRetorno, MsgBoxStyle.Information)
    End Sub
    Private Sub txtCNPJ2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNPJ2.KeyPress

        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarDocumento(Me.txtCNPJ2, "Cnpj")
    End Sub

    Private Sub txtCNPJ2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ2.Leave
        If Me.txtCNPJ2.Text.Trim = "" Then Exit Sub

        If ValidaCPF(Me.txtCNPJ2.Text.Trim) = False Then
            Me.txtCNPJ2.ResetText()
            Me.txtCNPJ2.Focus()
            Exit Sub
        End If

        If Me.txtCNPJ2.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCNPJ2.ResetText()
            Exit Sub
        End If
    End Sub
    Private Sub LimparAssociacao()
        Me.txtCNPJ2.ResetText()
        Me.txtAssinatura.ResetText()
    End Sub
    Private Sub btnLimparAssociacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparAssociacao.Click
        If MsgBox("Tem certeza que deseja limpar todos os campos da aba associar assinatura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            LimparAssociacao()
        End If
    End Sub

    Private Sub chkCodEmergencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCodEmergencia.CheckedChanged
        Select Case Me.chkCodEmergencia.Checked
            Case True
                Me.txtAntigo.Enabled = False
                Me.txtAntigo.Text = "00000000"
            Case False
                Me.txtAntigo.Enabled = True
                Me.txtAntigo.ResetText()
        End Select
    End Sub

    Private Sub btnTrocarCodAtivacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrocarCodAtivacao.Click
        If Validar(Me.txtAntigo) = False Then Exit Sub
        If Validar(Me.txtNovo) = False Then Exit Sub
        If Validar(Me.txtTrocaConfirmacao) = False Then Exit Sub

        If Me.txtNovo.Text.Length < 8 Then
            MsgBox("O código de ativação tem que ter no mínimo 8 caracter!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.txtTrocaConfirmacao.Text.Length < 8 Then
            MsgBox("O código de ativação tem que ter no mínimo 8 caracter!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.txtNovo.Text <> Me.txtTrocaConfirmacao.Text Then
            MsgBox("Código de ativação diferente da confirmação!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Barra(True)

        Dim cmdLineStr As IntPtr
        Try
            If ModeloSAT = "DIMEP" Then
                cmdLineStr = clsDimepSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "ELGIN" Then
                cmdLineStr = clsElginSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "ELGIN 2" Then
                cmdLineStr = clsElginSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "GERTEC" Then
                cmdLineStr = clsGertecSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "EPSON" Then
                cmdLineStr = clsEpsonSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "EASYS" Then
                cmdLineStr = clsEasysSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "BEMATECHDLL" Then
                cmdLineStr = clsBematechSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            ElseIf ModeloSAT = "TANCA" Then
                cmdLineStr = clsTancaSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "SWEDA" Then
                cmdLineStr = clsSwedaSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "CONTROLID" Then
                cmdLineStr = clsControlidSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "CUSTOM" Then
                cmdLineStr = clsCustomSatDLL.TrocarCodigoDeAtivacao(NumeroSessaoSat(), Me.txtAntigo.Text, Me.txtNovo.Text, Me.txtTrocaConfirmacao.Text)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Barra(False)
            Exit Sub
        End Try


        Barra(False)

        MsgBox(SatRetorno, MsgBoxStyle.Information)

    End Sub

    Private Sub btnLimparCodAtivacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparCodAtivacao.Click
        If MsgBox("Tem certeza que deseja limpar todos os campos da aba trocar código ativação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            LimparTrocaCodigoAtivacao()
        End If
    End Sub

    Private Sub LimparTrocaCodigoAtivacao()
        Me.txtAntigo.ResetText()
        Me.txtNovo.ResetText()
        Me.txtAntigo.Enabled = True
        Me.txtTrocaConfirmacao.ResetText()
        Me.chkCodEmergencia.Checked = False
        Me.txtAntigo.Focus()
    End Sub
    
 
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Select Case Me.XtraTabControl1.SelectedTabPageIndex
            Case 2
                If Me.txtCodAtivacaoAssociacao.Text = "" Then
                    Me.txtCodAtivacaoAssociacao.Text = Me.txtCodAtivacao.Text
                End If
                If Me.txtCNPJ2.Text = "" Then
                    Me.txtCNPJ2.Text = Me.txtCNPJ.Text
                End If
        End Select
    End Sub

    Private Sub cboModSAT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModSAT.SelectedIndexChanged
        ModeloSAT = Me.cboModSAT.Text
    End Sub

    Private Sub CarregarSatFiscal()
        Dim strCNPJ, IE As String
        strCNPJ = CNPJEmpresa
        If strCNPJ.Length = 14 Then
            strCNPJ = AddPonto(strCNPJ, "J")
        Else
            strCNPJ = AddPonto(strCNPJ, "F")
        End If


        Dim dtSat As DataTable = DataTableOnline("SET DATEFORMAT dmy Select SatFiscal.Modelo, SatFiscal.Impressora, " & _
        " SatFiscal.PortaImpressora, SatFiscal.CodigoAtivacao, SatFiscal.NumeroSerie, SatFiscal.Assinatura, " & _
        " SatFiscal.Inativo, SatFiscal.DataInstalacao, Cliente.RGIE From SatFiscal Left Join Cliente on " & _
        " SatFiscal.CodCli = Cliente.Codigo Where Cliente.CPF = '" & strCNPJ & "'")

        If dtSat.Rows.Count > 0 Then

            txtCodAtivacao.Text = dtSat.Rows.Item(0).Item("CodigoAtivacao").ToString.ToLower
            If txtCodAtivacao.Text = "" Then
                txtCodAtivacao.Text = "spfc1234"
            End If

            txtConCodAtivacao.Text = dtSat.Rows.Item(0).Item("CodigoAtivacao").ToString.ToLower
            If txtConCodAtivacao.Text = "" Then
                txtConCodAtivacao.Text = "spfc1234"
            End If

            txtCNPJ.Text = strCNPJ.Trim

            IE = dtSat.Rows.Item(0).Item("RGIE").ToString
            txtIE.Text = IE.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "")

            txtCodAtivacaoAssociacao.Text = dtSat.Rows.Item(0).Item("CodigoAtivacao").ToString.ToLower
            If txtCodAtivacaoAssociacao.Text = "" Then
                txtCodAtivacaoAssociacao.Text = "spfc1234"
            End If

            txtCNPJ2.Text = strCNPJ.Trim
            txtAssinatura.Text = dtSat.Rows.Item(0).Item("Assinatura").ToString

        End If
    End Sub

    Private Sub btnConSat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConSat.Click
        CarregarSatFiscal()
    End Sub
End Class