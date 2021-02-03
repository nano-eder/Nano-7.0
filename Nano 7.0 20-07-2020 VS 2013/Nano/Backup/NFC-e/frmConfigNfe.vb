Imports Nano.clsFuncoes
Imports Nano.clsValidar
Imports Nano.AssinaturaDigital
Imports System.IO
Public Class frmConfigNfe
    Dim strCodUF As String
    Dim bolAlterar As Boolean = False
    Dim intCodigo As Integer
    Public bolMensalista As Boolean
    Dim strCNPJCliente As String
    Private Sub AtualizarGrid()
        Dim strCodigoEmitente As String = ""

        Dim dtConfig As DataTable = CarregarDataTable("SELECT EmitentePadrao FROM Config WHERE Codigo = " & CodConfig)
        If dtConfig.Rows.Count > 0 Then
            strCodigoEmitente = dtConfig.Rows.Item(0).Item("EmitentePadrao").ToString
        End If

        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Razao, Fantasia, CNPJ, IE, Endereco, Bairro, Numero, Cidade, CodMun, Cep, UF, CodUF, " & _
        "Pais, CodPais, CRT, Telefone, NatOp, Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, VerProc, ModFrete, ObsCont, " & _
        "TZDCce, Padrao, Email, PastaBackupNFCe, SerialName, CertificadoDigital, VencimentoCertificado, IndFinal, IndPres, IdDest, VersaoXml, " & _
        "AutXml, Complemento, CNAE, IM, PorValorAproximado, CSC, Impressora, PortaImpressora, ImpDireto, MensImpCupom, TokenNFCe FROM ConfigNfe where CodConfig = " & CodConfig)

        Dim I As Integer

        Me.tbNFe.Rows.Clear()

        With Me.tbNFe.Rows
            For I = 0 To dt.Rows.Count - 1
                .Add()
                .Item(I).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
                If strCodigoEmitente = dt.Rows.Item(I).Item("Codigo").ToString Then
                    .Item(I).Item("Padrao") = True
                Else
                    .Item(I).Item("Padrao") = False
                End If
                .Item(I).Item("Razao") = dt.Rows.Item(I).Item("Razao").ToString
                .Item(I).Item("Fantasia") = dt.Rows.Item(I).Item("Fantasia").ToString
                .Item(I).Item("CNPJ") = dt.Rows.Item(I).Item("CNPJ").ToString
                .Item(I).Item("IE") = dt.Rows.Item(I).Item("IE").ToString
                .Item(I).Item("Endereco") = dt.Rows.Item(I).Item("Endereco").ToString
                .Item(I).Item("Bairro") = dt.Rows.Item(I).Item("Bairro").ToString
                .Item(I).Item("Numero") = dt.Rows.Item(I).Item("Numero").ToString
                .Item(I).Item("Cidade") = dt.Rows.Item(I).Item("Cidade").ToString
                .Item(I).Item("CodMun") = dt.Rows.Item(I).Item("CodMun").ToString
                .Item(I).Item("Cep") = dt.Rows.Item(I).Item("Cep").ToString
                .Item(I).Item("UF") = dt.Rows.Item(I).Item("UF").ToString
                .Item(I).Item("CodUF") = dt.Rows.Item(I).Item("CodUF").ToString
                .Item(I).Item("Pais") = dt.Rows.Item(I).Item("Pais").ToString

                .Item(I).Item("CodPais") = dt.Rows.Item(I).Item("CodPais").ToString
                .Item(I).Item("CRT") = dt.Rows.Item(I).Item("CRT").ToString
                .Item(I).Item("Telefone") = dt.Rows.Item(I).Item("Telefone").ToString
                .Item(I).Item("NatOp") = dt.Rows.Item(I).Item("NatOp").ToString
                .Item(I).Item("Mod") = "55"
                .Item(I).Item("Serie") = dt.Rows.Item(I).Item("Serie").ToString
                .Item(I).Item("TipoNF") = dt.Rows.Item(I).Item("TipoNF").ToString
                .Item(I).Item("TipoImp") = dt.Rows.Item(I).Item("TipoImp").ToString
                .Item(I).Item("TipoEmi") = dt.Rows.Item(I).Item("TipoEmi").ToString

                .Item(I).Item("TipoAmb") = dt.Rows.Item(I).Item("TipoAmb").ToString
                .Item(I).Item("FinNfe") = dt.Rows.Item(I).Item("FinNfe").ToString
                .Item(I).Item("ProcEmi") = dt.Rows.Item(I).Item("ProcEmi").ToString
                .Item(I).Item("VerProc") = dt.Rows.Item(I).Item("VerProc").ToString
                .Item(I).Item("ModFrete") = dt.Rows.Item(I).Item("ModFrete").ToString

                .Item(I).Item("ObsCont") = dt.Rows.Item(I).Item("ObsCont").ToString
                .Item(I).Item("TZDCce") = dt.Rows.Item(I).Item("TZDCce").ToString

                .Item(I).Item("Email") = dt.Rows.Item(I).Item("Email").ToString
                .Item(I).Item("PastaBackup") = dt.Rows.Item(I).Item("PastaBackupNFCe").ToString
                .Item(I).Item("SerialName") = dt.Rows.Item(I).Item("SerialName").ToString
                .Item(I).Item("CertificadoDigital") = dt.Rows.Item(I).Item("CertificadoDigital").ToString


                .Item(I).Item("VencimentoCertificado") = dt.Rows.Item(I).Item("VencimentoCertificado").ToString
                .Item(I).Item("IndFinal") = dt.Rows.Item(I).Item("IndFinal").ToString
                .Item(I).Item("IndPres") = dt.Rows.Item(I).Item("IndPres").ToString
                .Item(I).Item("IdDest") = dt.Rows.Item(I).Item("IdDest").ToString
                .Item(I).Item("VersaoXml") = dt.Rows.Item(I).Item("VersaoXml").ToString
                .Item(I).Item("AutXml") = dt.Rows.Item(I).Item("AutXml").ToString
                .Item(I).Item("Complemento") = dt.Rows.Item(I).Item("Complemento").ToString
                '.Item(I).Item("CodMunicipioFG") = dt.Rows.Item(I).Item("CodMunicipioFG").ToString

                .Item(I).Item("IM") = dt.Rows.Item(I).Item("IM").ToString
                .Item(I).Item("CNAE") = dt.Rows.Item(I).Item("CNAE").ToString

                .Item(I).Item("PorValorAproximado") = dt.Rows.Item(I).Item("PorValorAproximado").ToString
                .Item(I).Item("CSC") = dt.Rows.Item(I).Item("CSC").ToString

                .Item(I).Item("Impressora") = dt.Rows.Item(I).Item("Impressora").ToString
                .Item(I).Item("PortaImpressora") = dt.Rows.Item(I).Item("PortaImpressora").ToString
                .Item(I).Item("ImpDireto") = dt.Rows.Item(I).Item("ImpDireto").ToString
                .Item(I).Item("MensImpCupom") = dt.Rows.Item(I).Item("MensImpCupom").ToString
                .Item(I).Item("TokenNFCe") = dt.Rows.Item(I).Item("TokenNFCe").ToString

            Next
        End With

        ' Me.picLogo.Image = System.Drawing.Bitmap.FromFile(PastaRemessas.Replace("Remessas", "Arquivos") & "\logo.jpg")




        Try
            Dim dtLogo As DataTable = CarregarDataTable("SELECT LogoTipo FROM ConfigNfe where Codigo = 1")
            If dtLogo.Rows.Count > 0 Then
                If dtLogo.Rows.Item(0).Item("LogoTipo").ToString <> "" Then
                    Me.picLogo.Image = CarregarLogoConfig(dtLogo.Rows.Item(0).Item("LogoTipo"))
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Function CarregarLogoConfig(ByVal parLogo As Object) As Image
        Try
            Dim Imagem As Byte() = CType(parLogo, Byte())

            Dim memorybits As New IO.MemoryStream(Imagem)

            Dim bitmap As New Bitmap(memorybits)

            Return bitmap
        Catch ex As Exception

        End Try
    End Function
    Private Sub frmConfigNfe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\iconenfe.ico") = True Then
            Me.Icon = New Icon(My.Application.Info.DirectoryPath & "\iconenfe.ico")
        End If
        If TesteConexao() = False Then Exit Sub
        Me.cboNat.Properties.Items.Clear()

        PreencherOrdenado("NatOpe", Me.cboNat, 1, "Descricao")
        'PreencherCombo("Pais", Me.cboPais, 1, "Nome")
        If Login = "ADM" And Senha = "SPFC" Then
            Me.txtValAprox.Visible = True
            Me.lblValAprox.Visible = True
            Me.colPorValorAproximado.Visible = True
            Me.colPorValorAproximado.VisibleIndex = 10
        End If
        Me.txtVersaoProc.Text = VersaoDoSistemaProjeto
        AtualizarGrid()

        Limpar()



        Timer1.Start()
    End Sub
    Private Sub Limpar()
        'If NanoBanco = "0" Then
        Me.rdgDoc.SelectedIndex = 0
        Me.tbAut.Rows.Clear()
        Me.txtCPFAut.ResetText()
        Me.txtSerialName.ResetText()
        Me.txtCertificadoDigital.ResetText()
        Me.dtVencimento.ResetText()
        Me.txtPastaBackup.ResetText()
        Me.chkIsento.Checked = False
        Me.txtNome.ResetText()
        Me.txtFant.ResetText()
        Me.txtCNPJ.ResetText()
        Me.txtIE.ResetText()
        Me.cboCRT.SelectedIndex = -1
        Me.txtEnd.ResetText()
        Me.txtBairro.ResetText()
        Me.txtNum.ResetText()
        Me.txtCep.ResetText()
        'Me.txtCodMunicipioFG.ResetText()
        Me.cboUF.Text = "SP"
        CarregarComboCidade(Me.cboUF.Text, Me.cboCidade)
        SelecionarCodigoUF(Me.cboUF.Text)
        Me.cboCidade.SelectedIndex = -1
        Me.txtCodMun.ResetText()
        strCodUF = ""
        'Me.cboPais.ResetText()
        'Me.txtCodPais.ResetText()
        Me.txtTel1.ResetText()
        'Me.cboNat.ResetText()
        Me.txtModelo.Text = "55"
        Me.XtraTabControl1.SelectedTabPageIndex = 0
        Me.txtSerie.ResetText()
        Me.txtCSC.ResetText()
        'Me.cboTipoNf.SelectedIndex = -1
        Me.cboTipoImp.SelectedIndex = 0
        Me.cboTipoEmi.SelectedIndex = 0
        'Me.cboTipoAmb.SelectedIndex = -1
        Me.cboFinalidade.SelectedIndex = 0
        Me.cboProcEmi.SelectedIndex = 0
        Me.txtVersaoProc.Text = VersaoDoSistemaProjeto
        Me.txtComplemento.ResetText()
        Me.txtToken.ResetText()
        'Me.cboModFrete.SelectedIndex = -1

        'Me.cboIndFinal.SelectedIndex = -1
        'Me.cboIndPres.SelectedIndex = -1
        'Me.cboIdDest.SelectedIndex = -1

        Me.memContribuinte.ResetText()
        Me.cboTZD.Text = "-03:00"

        Me.txtNome.Focus()
            Me.chkPadrao.Checked = False

        bolAlterar = False

        ' End If
        Me.cboModeloImp.SelectedIndex = -1
        Me.txtPortaImpressora.ResetText()
        Me.chkImpDireto.Checked = False
        Me.chkMensImpCupom.Checked = False

        Me.txtCNAE.ResetText()
        Me.txtIM.ResetText()
        Me.cboTipoEmi.SelectedIndex = 0
        Me.cboTipoImp.SelectedIndex = 0
        Me.cboFinalidade.SelectedIndex = 0
        Me.cboProcEmi.SelectedIndex = 0
        Me.txtVersaoProc.Text = VersaoDoSistemaProjeto
        Me.txtValAprox.ResetText()
    End Sub
    Private Sub Alterar()

        Dim intIndex As Integer = Me.grd1.FocusedRowHandle


        bolAlterar = True

        intCodigo = Me.grd1.GetRowCellValue(intIndex, Me.colCodigo)
        Me.txtNome.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colRazao)
        Me.txtFant.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colFantasia)
        Me.txtCNPJ.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCNPJ)

        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colCRT) = "1" Then
            Me.cboCRT.SelectedIndex = 0
        ElseIf Me.grd1.GetRowCellDisplayText(intIndex, Me.colCRT) = "3" Then
            Me.cboCRT.SelectedIndex = 1
        Else
            Me.cboCRT.SelectedIndex = -1
        End If
        Me.txtEnd.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colEndereco)
        Me.txtBairro.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colBairro)
        Me.txtNum.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNumero)
        Me.txtCep.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCep)
        Me.cboUF.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colUF)

        CarregarComboCidade(Me.cboUF.Text, Me.cboCidade)
        Me.cboCidade.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCidade)
        Me.txtCodMun.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodMun)
        strCodUF = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodUF)
        'Me.cboPais.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colPais)
        'Me.txtCodPais.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodPais)
        Me.txtTel1.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colTelefone)
        Me.cboNat.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNatOp)
        Me.txtModelo.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colMod)
        Me.txtIE.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colIE)
        Me.txtSerie.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colSerie)
        Me.cboTipoNf.SelectedIndex = Me.grd1.GetRowCellDisplayText(intIndex, Me.colTipoNF)
        Me.cboTipoImp.SelectedIndex = (Me.grd1.GetRowCellDisplayText(intIndex, Me.colTipoImp)) - 1
        Me.cboTipoEmi.SelectedIndex = (Me.grd1.GetRowCellDisplayText(intIndex, Me.colTipoEmi)) - 1
        Me.cboTipoAmb.SelectedIndex = (Me.grd1.GetRowCellDisplayText(intIndex, Me.colTipoAmb)) - 1
        Me.cboFinalidade.SelectedIndex = (Me.grd1.GetRowCellDisplayText(intIndex, Me.colFinNfe)) - 1
        Me.cboProcEmi.SelectedIndex = Me.grd1.GetRowCellDisplayText(intIndex, Me.colProcEmi)
        Me.txtVersaoProc.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colVerProc)
        Me.txtCSC.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCSC)
        Me.chkPadrao.Checked = Me.grd1.GetRowCellValue(intIndex, Me.colPadrao)
        ' Me.txtCodMunicipioFG.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodMunicipioFG)
        Select Case Me.grd1.GetRowCellDisplayText(intIndex, Me.colModFrete)
            Case 9
                Me.cboModFrete.SelectedIndex = 3
            Case Else
                Me.cboModFrete.SelectedIndex = Me.grd1.GetRowCellDisplayText(intIndex, Me.colModFrete)
        End Select

        Me.memContribuinte.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colObsCont)

        Me.cboTZD.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colTZDCce)

        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colIE) = "ISENTO" Then
            Me.chkIsento.Checked = True
        Else
            Me.txtIE.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colIE).Trim
        End If

        Me.txtSerialName.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colSerialName)
        Me.txtCertificadoDigital.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCertificadoDigital)
        Me.txtPastaBackup.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colPastaBackup)
        Me.dtVencimento.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colVencimentoCertificado)

        Me.cboIndFinal.SelectedIndex = Me.grd1.GetRowCellDisplayText(intIndex, Me.colIndFinal)
        Me.cboIdDest.SelectedIndex = (Me.grd1.GetRowCellDisplayText(intIndex, Me.colIdDest)) - 1
        Me.txtComplemento.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colComplemento)
        Me.txtIM.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colIM)
        Me.txtCNAE.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCNAE)

        Me.txtValAprox.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colPorValorAproximado)



        Me.cboModeloImp.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colImpressora)
        Me.txtPortaImpressora.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colPortaImpressora)

        Me.chkImpDireto.Checked = Me.grd1.GetRowCellValue(intIndex, Me.colImpDireto)
        Me.chkMensImpCupom.Checked = Me.grd1.GetRowCellValue(intIndex, Me.colMensImpCupom)


        Me.txtToken.Text = Me.grd1.GetRowCellValue(intIndex, Me.colTokenNFCe)

        Select Case Me.grd1.GetRowCellDisplayText(intIndex, Me.colIndPres)
            Case 9
                Me.cboIndPres.SelectedIndex = 4
            Case Else
                Me.cboIndPres.SelectedIndex = Me.grd1.GetRowCellDisplayText(intIndex, Me.colIndPres)
        End Select

        Dim strCPFAut As String = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAutXml)

        If strCPFAut <> "" Then
            Dim vetCPF As Array = Split(strCPFAut, "|")

            Me.tbAut.Rows.Clear()

            Dim A As Integer

            For A = 0 To vetCPF.Length - 1
                Dim strCPF As String = vetCPF(A)
                Me.tbAut.Rows.Add()
                Me.tbAut.Rows.Item(A).Item("Item") = A + 1
                Me.tbAut.Rows.Item(A).Item("CPF") = strCPF
            Next
        End If

        Dim strStatus As String = ""
        If Me.cboTipoAmb.SelectedIndex = 0 Then
            strStatus = "PRODUÇÃO"

        Else
            strStatus = "HOMOLOGAÇÃO"
        End If



        Dim dtLogo As DataTable = CarregarDataTable("SELECT LogoTipo FROM ConfigNfe where Codigo = " & intCodigo)
        If dtLogo.Rows.Count > 0 Then
            If dtLogo.Rows.Item(0).Item("LogoTipo").ToString <> "" Then
                CarregarLogo(dtLogo.Rows.Item(0).Item("LogoTipo"))
                Me.picLogo.Image = LogoTipo
            End If
        End If


        Dim dtOrdem As DataTable = CarregarDataTable("SELECT Max(Cod) as Cod FROM Ordens where Tabela = 'NFCe' and " & _
        "CodEmitente = " & intCodigo & " and StatusEmitente = '" & strStatus & "'")
        If dtOrdem.Rows.Count > 0 Then
            Me.txtNumUltNota.Text = dtOrdem.Rows.Item(0).Item("Cod").ToString
        Else
            Me.txtNumUltNota.Text = "0"
        End If

    End Sub
    Private Sub CarregarComboCidade(ByVal parUF As String, ByVal parCidade As Object)
        Dim dt As DataTable
        Dim I As Integer
        dt = CarregarDataTable("SELECT Nome FROM Cidade where UF = '" & parUF & "'")
        For I = 0 To dt.Rows.Count - 1
            parCidade.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
        Next
    End Sub
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub


    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If Validar(Me.txtNome) = False Then Exit Sub
        If Validar(Me.txtFant) = False Then Exit Sub
        If Validar(Me.txtCNPJ) = False Then Exit Sub
        If Validar(Me.txtIE) = False Then Exit Sub
        If Validar(Me.cboCRT) = False Then Exit Sub
        If Validar(Me.txtEnd) = False Then Exit Sub
        If Validar(Me.txtBairro) = False Then Exit Sub
        If Validar(Me.txtCep) = False Then Exit Sub
        If Validar(Me.cboUF) = False Then Exit Sub
        If Validar(Me.cboCidade) = False Then Exit Sub
        If Validar(Me.txtCodMun) = False Then Exit Sub
        'If Validar(Me.cboPais) = False Then Exit Sub
        'If Validar(Me.txtCodPais) = False Then Exit Sub
        If Validar(Me.cboNat) = False Then Exit Sub
        If Validar(Me.txtModelo) = False Then Exit Sub
        If Validar(Me.txtSerie) = False Then Exit Sub
        If Validar(Me.cboTipoNf) = False Then Exit Sub
        If Validar(Me.cboTipoImp) = False Then Exit Sub
        If Validar(Me.cboTipoEmi) = False Then Exit Sub
        If Validar(Me.cboTipoAmb) = False Then Exit Sub
        If Validar(Me.cboFinalidade) = False Then Exit Sub
        If Validar(Me.cboProcEmi) = False Then Exit Sub
        If Validar(Me.txtVersaoProc) = False Then Exit Sub
        If Validar(Me.cboModFrete) = False Then Exit Sub
        If Validar(Me.txtCSC) = False Then Exit Sub
        If Validar(Me.txtCertificadoDigital) = False Then Exit Sub
        If Validar(Me.txtToken) = False Then Exit Sub

        Dim strIndFinal As String = Me.cboIndFinal.Text

        Dim strIndPres As String = Me.cboIndPres.Text

        Dim strIdDest As String = Me.cboIdDest.Text

        'If Me.cboVersaoXml.Text <> "2.00" Then
        If Validar(Me.cboIdDest) = False Then Exit Sub
        If Validar(Me.cboIndFinal) = False Then Exit Sub
        If Validar(Me.cboIndPres) = False Then Exit Sub
        ' End If

        If strIndFinal <> "" Then
            strIndFinal = strIndFinal.Substring(0, 1)
        End If
        If strIndPres <> "" Then
            strIndPres = strIndPres.Substring(0, 1)
        End If
        If strIdDest <> "" Then
            strIdDest = strIdDest.Substring(0, 1)
        End If
        If TesteConexao() = False Then Exit Sub


        Dim strTipoNf As String = Me.cboTipoNf.Text
        strTipoNf = strTipoNf.Substring(0, 1)

        Dim strTipoImp As String = Me.cboTipoImp.Text
        strTipoImp = strTipoImp.Substring(0, 1)

        Dim strTipoEmi As String = Me.cboTipoEmi.Text
        strTipoEmi = strTipoEmi.Substring(0, 1)

        Dim strTipoAmb As String = Me.cboTipoAmb.Text
        strTipoAmb = strTipoAmb.Substring(0, 1)

        Dim strFinalidade As String = Me.cboFinalidade.Text
        strFinalidade = strFinalidade.Substring(0, 1)

        Dim strProcEmi As String = Me.cboProcEmi.Text
        strProcEmi = Me.cboProcEmi.SelectedIndex

        Dim strModFrete As String = Me.cboModFrete.Text
        strModFrete = strModFrete.Substring(0, 1)

        strCodUF = SelecionarCodigoUF(Me.cboUF.Text)

        Dim bolPadrao As Boolean = Me.chkPadrao.Checked

        Dim bolEmail As Boolean = True


        Dim strCPFAut As String = ""
        Dim A As Integer
        For A = 0 To Me.grd4.RowCount - 1
            Dim strCPF As String = Me.grd4.GetRowCellDisplayText(A, Me.colCPF)
            If A = 0 Then
                strCPFAut = strCPF
            Else
                strCPFAut &= "|" & strCPF
            End If

        Next

        Dim strCRT As String = "1"

        If Me.cboCRT.SelectedIndex = 1 Then
            strCRT = "3"
        End If
        Dim strNumUltNota As String = "0"
        If Me.txtNumUltNota.Text <> "" Then
            strNumUltNota = Me.txtNumUltNota.Text
        End If

       
        Dim strValAprox As String = ""
        If Me.txtValAprox.Text <> "" Then
            Dim dblValAprox As Double = Me.txtValAprox.Text
            If dblValAprox > 0 Then
                strValAprox = dblValAprox.ToString("0.00")
            End If
        End If
        If bolAlterar = False Then

            If Me.chkPadrao.Checked = True Then

                Atualizar("UPDATE ConfigNfe set Padrao = 'False'")


            Else
                Dim bolPadraoOk As Boolean = False
                Dim dtPadrao As DataTable = CarregarDataTable("SELECT Padrao FROM ConfigNfe")
                Dim I As Integer
                For I = 0 To dtPadrao.Rows.Count - 1
                    Dim bolPad As Boolean = dtPadrao.Rows.Item(I).Item("Padrao")

                    If bolPad = True Then
                        bolPadraoOk = True
                        Exit For
                    End If
                Next
                If bolPadraoOk = False Then
                    bolPadrao = True
                End If
            End If





            Inserir("INSERT INTO ConfigNfe (Razao, Fantasia, CNPJ, IE, Endereco, Bairro, Numero, Cidade, CodMun, Cep, " & _
            "UF, CodUF, Pais, CodPais, CRT, Telefone, NatOp, Mod, Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, " & _
            "ProcEmi, VerProc, ModFrete, ObsCont, TZDCce, Padrao, CertificadoDigital, VencimentoCertificado, PastaBackupNFCe, " & _
            "Email, SerialName, CodConfig, IndFinal, IndPres, IdDest, VersaoXml, AutXml, Complemento, IM, CNAE, PorValorAproximado, " & _
            "CSC, Impressora, PortaImpressora, ImpDireto, MensImpCupom, TokenNFCe) VALUES ('" & Me.txtNome.Text & "'," & _
            "'" & Me.txtFant.Text & "','" & Me.txtCNPJ.Text & "','" & Me.txtIE.Text & "','" & Me.txtEnd.Text & "'," & _
            "'" & Me.txtBairro.Text & "','" & Me.txtNum.Text & "','" & Me.cboCidade.Text & "','" & Me.txtCodMun.Text & "'," & _
            "'" & Me.txtCep.Text & "','" & Me.cboUF.Text & "','" & strCodUF & "','BRASIL'," & _
            "'1058','" & strCRT & "','" & Me.txtTel1.Text & "','" & Me.cboNat.Text & "','" & Me.txtModelo.Text & "'," & _
            "'" & Me.txtSerie.Text & "','" & strTipoNf & "','" & strTipoImp & "','" & strTipoEmi & "','" & strTipoAmb & "','" & strFinalidade & "'," & _
            "'" & strProcEmi & "','" & Me.txtVersaoProc.Text & "','" & strModFrete & "','" & Me.memContribuinte.Text.Replace("'", "") & "'," & _
            "'" & Me.cboTZD.Text & "','" & bolPadrao & "','" & Me.txtCertificadoDigital.Text & "','" & Me.dtVencimento.Text & "'," & _
            "'" & Me.txtPastaBackup.Text & "','" & bolEmail & "','" & Me.txtSerialName.Text & "'," & CodConfig & ",'" & strIndFinal & "'," & _
            "'" & strIndPres & "','" & strIdDest & "','4.00','" & strCPFAut & "','" & Me.txtComplemento.Text & "'," & _
            "'" & Me.txtIM.Text & "','" & Me.txtCNAE.Text & "','" & strValAprox & "','" & Me.txtCSC.Text & "','" & Me.cboModeloImp.Text & "'," & _
            "'" & Me.txtPortaImpressora.Text & "','" & Me.chkImpDireto.Checked & "','" & Me.chkMensImpCupom.Checked & "','" & Me.txtToken.Text & "')")

            Dim dt As DataTable = CarregarDataTable("SELECT Codigo from ConfigNfe where CNPJ = '" & Me.txtCNPJ.Text & "'")
            If dt.Rows.Count > 0 Then
                intCodigo = dt.Rows.Item(0).Item("Codigo").ToString

                If Me.chkPadrao.Checked = True Then
                    Atualizar("UPDATE Config set EmitentePadrao = '" & intCodigo & "' where Codigo = " & CodConfig)
                End If
            End If

            Dim strStatus As String = ""
            If Me.cboTipoAmb.SelectedIndex = 0 Then
                strStatus = "PRODUÇÃO"

            Else
                strStatus = "HOMOLOGAÇÃO"
            End If
            Excluir("DELETE FROM Ordens where Tabela = 'NFCe' and CodEmitente = " & intCodigo & " and StatusEmitente = '" & strStatus & "'")
            Inserir("INSERT INTO Ordens(Cod, Tabela, CodEmitente, CodConfig, StatusEmitente) VALUES (" & strNumUltNota & ",'NFCe'," & intCodigo & "," & CodConfig & ",'" & strStatus & "')")



        Else

            If Me.chkPadrao.Checked = True Then
                Atualizar("UPDATE ConfigNfe set Padrao = 'False'")
            Else
                Dim bolPadraoOk As Boolean = False
                Dim dtPadrao As DataTable = CarregarDataTable("SELECT Codigo, Padrao FROM ConfigNfe")
                Dim I As Integer
                For I = 0 To dtPadrao.Rows.Count - 1
                    Dim bolPad As Boolean = dtPadrao.Rows.Item(I).Item("Padrao")
                    Dim intCod As Integer = dtPadrao.Rows.Item(I).Item("Codigo")
                    If bolPad = True Then
                        If intCod = intCodigo Then
                            bolPadraoOk = False
                            Atualizar("UPDATE ConfigNfe set Padrao = 'False'")
                            Exit For
                        Else
                            bolPadraoOk = True

                        End If

                    End If
                Next
                If bolPadraoOk = False Then
                    bolPadrao = True
                End If
            End If



            Atualizar("UPDATE ConfigNfe SET Razao = '" & Me.txtNome.Text & "', Fantasia = '" & Me.txtFant.Text & "', CNPJ = '" & Me.txtCNPJ.Text & "', " & _
            "IE = '" & Me.txtIE.Text & "', Endereco = '" & Me.txtEnd.Text & "', Bairro = '" & Me.txtBairro.Text & "', Numero = '" & Me.txtNum.Text & "', " & _
            "Cidade = '" & Me.cboCidade.Text & "', CodMun = '" & Me.txtCodMun.Text & "', Cep = '" & Me.txtCep.Text & "', UF = '" & Me.cboUF.Text & "', " & _
            "CodUF = '" & strCodUF & "', Pais = 'BRASIL', CodPais = '1058', CRT = '" & strCRT & "', " & _
            "Telefone = '" & Me.txtTel1.Text & "', NatOp = '" & Me.cboNat.Text & "', Mod = '" & Me.txtModelo.Text & "', Serie = '" & Me.txtSerie.Text & "', " & _
            "TipoNF = '" & strTipoNf & "', TipoImp = '" & strTipoImp & "', TipoEmi = '" & strTipoEmi & "', TipoAmb = '" & strTipoAmb & "', " & _
            "FinNfe = '" & strFinalidade & "', ProcEmi = '" & strProcEmi & "', VerProc = '" & Me.txtVersaoProc.Text & "', ModFrete = '" & strModFrete & "', " & _
            "ObsCont = '" & Me.memContribuinte.Text.Replace("'", "") & "', TZDCce = '" & Me.cboTZD.Text & "', " & _
            "Padrao = '" & bolPadrao & "', CertificadoDigital = '" & Me.txtCertificadoDigital.Text & "', " & _
            "VencimentoCertificado = '" & Me.dtVencimento.Text & "', PastaBackupNFCe = '" & Me.txtPastaBackup.Text & "', " & _
            "Email = '" & bolEmail & "', SerialName = '" & Me.txtSerialName.Text & "', CodConfig = " & CodConfig & ", " & _
            "IndFinal = '" & strIndFinal & "', IndPres = '" & strIndPres & "', IdDest = '" & strIdDest & "', VersaoXml = '4.00', " & _
            "AutXml = '" & strCPFAut & "', Complemento = '" & Me.txtComplemento.Text & "', " & _
            "IM = '" & Me.txtIM.Text & "', CNAE = '" & Me.txtCNAE.Text & "', PorValorAproximado = '" & strValAprox & "', " & _
            "CSC = '" & Me.txtCSC.Text & "', Impressora = '" & Me.cboModeloImp.Text & "', PortaImpressora = '" & Me.txtPortaImpressora.Text & "', " & _
            "ImpDireto = '" & Me.chkImpDireto.Checked & "', MensImpCupom = '" & Me.chkMensImpCupom.Checked & "', TokenNFCe = '" & Me.txtToken.Text & "' where Codigo = " & intCodigo)
            If Me.chkPadrao.Checked = True Then
                Atualizar("UPDATE Config set EmitentePadrao = '" & intCodigo & "' where Codigo = " & CodConfig)

            End If

            Dim strStatus As String = ""
            If Me.cboTipoAmb.SelectedIndex = 0 Then
                strStatus = "PRODUÇÃO"

            Else
                strStatus = "HOMOLOGAÇÃO"
            End If
            Excluir("DELETE FROM Ordens where Tabela = 'NFCe' and CodEmitente = " & intCodigo & " and StatusEmitente = '" & strStatus & "'")
            Inserir("INSERT INTO Ordens(Cod, Tabela, CodEmitente, CodConfig, StatusEmitente) VALUES (" & strNumUltNota & ",'NFCe'," & intCodigo & "," & CodConfig & ",'" & strStatus & "')")



        End If

        If Me.picLogo.Image Is Nothing = False Then
            Dim imagem As Byte() = converteimagem(Me.picLogo.Image)
            InserirImagem("UPDATE ConfigNFe set LogoTipo = @Img where Codigo = " & intCodigo, imagem)

        End If


        MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)

        clsNFCe.CarregarEmitente()

        AtualizarGrid()

        Limpar()


    End Sub
 
    Private Sub cboUF_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged
        Me.cboCidade.Properties.Items.Clear()
        Me.cboCidade.SelectedIndex = -1
        CarregarComboCidade(Me.cboUF.Text, Me.cboCidade)
        If Me.txtIE.Text = "ISENTO" Or Me.txtIE.Text = "" Then Exit Sub

        strCodUF = SelecionarCodigoUF(Me.cboUF.Text)
        Me.txtIE.ResetText()
        Me.txtIE.Focus()
    End Sub

    Private Sub txtCep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCep.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        FormatarCep(Me.txtCep)
    End Sub

    Private Sub txtCep_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCep.Leave
        If ValidarCep = True Then
            Try
                If My.Computer.Network.IsAvailable = False Then Exit Sub
            Catch ex As Exception
                Exit Sub
            End Try


            Dim ht As Hashtable = BuscaCep(Me.txtCep.Text.Trim)
            Dim strCidade, strEnd, strBairro As String
            Try
                If ht.Count > 0 Then
                    strEnd = ht("tipologradouro") & " " & ht("logradouro")
                    strBairro = ht("bairro")
                    strCidade = ht("cidade")
                    Me.txtEnd.Text = strEnd.ToUpper
                    Me.txtBairro.Text = strBairro.ToUpper
                    Me.cboCidade.Text = strCidade.ToUpper
                    Me.cboUF.Text = ht("UF")

                    If Me.cboCidade.Text <> "" Then
                        Dim dt As DataTable = CarregarDataTable("SELECT CodIBGE FROM Cidade where Nome = '" & Me.cboCidade.Text.Replace("'", "´") & "' and UF = '" & Me.cboUF.Text & "'")
                        If dt.Rows.Count > 0 Then
                            Me.txtCodMun.Text = dt.Rows.Item(0).Item("CodIBGE").ToString
                        End If
                    End If

                    strCodUF = SelecionarCodigoUF(Me.cboUF.Text)

                    Me.txtNum.Focus()
                    Exit Sub
                End If
            Catch ex As Exception

            End Try

            Me.cboUF.Focus()
        End If
    End Sub

    Private Sub txtCNPJ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNPJ.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        FormatarDocumento(Me.txtCNPJ, "Cnpj")
    End Sub

    Private Sub txtCNPJ_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.Leave
        If Me.txtCNPJ.Text.Trim = "" Then
            Me.txtNome.Focus()
            Exit Sub
        End If

        If ValidaCPF(Me.txtCNPJ.Text.Trim) = False Then
            Me.txtCNPJ.ResetText()
            Me.txtCNPJ.Focus()
        End If
        Me.cboCRT.Focus()
    End Sub

    Private Sub txtIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIE.KeyPress
        Select Case Me.cboUF.Text
            Case "AC"    ' Acre
                Me.txtIE.Properties.MaxLength = 17
            Case "AL", "AP", "ES", "MA", "MS", "PI"   ' Alagoas
                Me.txtIE.Properties.MaxLength = 9
            Case "AM", "RN"   ' Amazonas
                Me.txtIE.Properties.MaxLength = 12
            Case "CE", "GO", "PB", "RR" ' Ceara
                Me.txtIE.Properties.MaxLength = 10
            Case "DF"    ' Distrito Federal
                Me.txtIE.Properties.MaxLength = 20
            Case "MG"    ' Minas Gerais
                Me.txtIE.Properties.MaxLength = 16
            Case "PA", "PR", "RJ", "RO", "RS", "SC", "SE", "TO"  ' Para
                Me.txtIE.Properties.MaxLength = 11
            Case "PE"    ' Pernambuco
                Me.txtIE.Properties.MaxLength = 18
            Case "SP"    ' São Paulo
                Me.txtIE.Properties.MaxLength = 15
        End Select
        If IsNumeric(e.KeyChar) AndAlso Me.txtIE.Text.Length < Me.txtIE.Properties.MaxLength Then
            Me.txtIE.Text &= e.KeyChar
            Me.txtIE.SelectionStart = Me.txtIE.Text.Length
            formataIE(Me.txtIE, Me.cboUF.Text)
        End If
        If e.KeyChar = vbBack Then Exit Sub
        e.Handled = True
    End Sub

    Private Sub txtIE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIE.Leave
        If Me.txtIE.Text = "" Then Exit Sub
        If ChecaInscrE(Me.cboUF.Text, Me.txtIE.Text) = False Then
            MsgBox("Inscrição Estadual informada não é valida, insira todos os ponto e verifique se a UF selecionada é a UF do cliente.", MsgBoxStyle.Information)
            Me.txtIE.ResetText()
            Me.txtIE.Focus()
        End If
    End Sub

    Private Sub cboCidade_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCidade.Leave
        If Me.cboCidade.Text <> "" Then
            Dim dt As DataTable = CarregarDataTable("SELECT CodIBGE FROM Cidade where Nome = '" & Me.cboCidade.Text.Replace("'", "´") & "' and UF = '" & Me.cboUF.Text & "'")
            If dt.Rows.Count > 0 Then
                Me.txtCodMun.Text = dt.Rows.Item(0).Item("CodIBGE").ToString
            End If
        End If
    End Sub


    Private Sub memContribuinte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles memContribuinte.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If

        If e.Control AndAlso (e.KeyCode = Keys.V) Then e.SuppressKeyPress = True
    End Sub

    Private Sub memContribuinte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles memContribuinte.KeyPress
        If e.KeyChar <> vbBack And e.KeyChar = "'" Then
            e.Handled = True
        End If
        If e.KeyChar = "|" Then
            e.Handled = True
        End If
    End Sub

    Private Sub memContribuinte_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles memContribuinte.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub

    Private Sub memCondUsoCce_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub

    Private Sub btnNatOpe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNatOpe.Click
        frmCadNatOpe.ShowDialog()
        Me.cboNat.Properties.Items.Clear()

        PreencherOrdenado("NatOpe", Me.cboNat, 1, "Descricao")


    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If

    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Alterar()
    End Sub

    Private Sub chkIsento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsento.CheckedChanged
        If Me.chkIsento.Checked = True Then
            Me.txtIE.ResetText()
            Me.txtIE.Text = "ISENTO"
            Me.txtIE.Properties.ReadOnly = True
            Me.chkIsento.BackColor = Color.WhiteSmoke
        Else
            Me.txtIE.ResetText()
            Me.txtIE.Properties.ReadOnly = False
            Me.chkIsento.BackColor = Color.White
        End If
    End Sub

    Private Sub txtCertificadoDigital_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCertificadoDigital.ButtonClick
        Dim strRetorno As String = ""
        Dim OAd As New AssinaturaDigital

        OAd.SelecionarCertificado("", strRetorno)

        If strRetorno <> "" Then
            Exit Sub
        End If
        Me.txtSerialName.Text = certificate.SerialNumber
        Me.txtCertificadoDigital.Text = certificate.Subject
        Me.dtVencimento.Text = certificate.NotAfter

    End Sub

    Private Sub txtPastaBackup_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPastaBackup.ButtonClick

        Me.fbdBackup.SelectedPath = ""
        Me.fbdBackup.ShowDialog()
        Me.txtPastaBackup.Text = fbdBackup.SelectedPath
    End Sub

    Private Sub btnAddCPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCPF.Click
        If Me.txtCPFAut.Text = "" Then Exit Sub

        Dim I As Integer

        For I = 0 To Me.grd4.RowCount - 1
            Dim strCPF As String = Me.grd4.GetRowCellDisplayText(I, Me.colCPF)

            If Me.txtCPFAut.Text = strCPF Then

                MsgBox("CPF já informado!", MsgBoxStyle.Information)
                Exit Sub
            End If

        Next


        Me.tbAut.Rows.Add()
        Me.tbAut.Rows.Item(Me.tbAut.Rows.Count - 1).Item("Item") = Me.tbAut.Rows.Count
        Me.tbAut.Rows.Item(Me.tbAut.Rows.Count - 1).Item("CPF") = Me.txtCPFAut.Text

        Me.txtCPFAut.ResetText()
        Me.txtCPFAut.Focus()
    End Sub

    Private Sub rdgDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDoc.SelectedIndexChanged
        Me.txtCPFAut.ResetText()
        Me.txtCPFAut.Focus()
    End Sub
    Private Sub txtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPFAut.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        Select Case Me.rdgDoc.SelectedIndex
            Case 0
                FormatarDocumento(Me.txtCPFAut, "Cpf")
            Case 1
                FormatarDocumento(Me.txtCPFAut, "Cnpj")
        End Select

    End Sub

    Private Sub txtCPF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPFAut.Leave
        If Me.txtCPFAut.Text.Trim = "" Then Exit Sub
        If ValidaCPF(Me.txtCPFAut.Text.Trim) = False Then
            Me.txtCPFAut.ResetText()
            Me.txtCPFAut.Focus()
        End If
        If Me.txtCPFAut.Text.Trim = "000.000.000-00" Or Me.txtCPFAut.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCPFAut.ResetText()
        End If

    End Sub

 
    Private Sub btnExcluirCPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCPF.Click
        If grd4.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd4.FocusedRowHandle

        Me.grd4.DeleteRow(Index)

        Dim I As Integer

        For I = 0 To Me.grd4.RowCount - 1
            Me.grd4.SetRowCellValue(I, Me.colItem, I + 1)
        Next
    End Sub

    Private Sub btnBuscaCNPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCNPJ.Click
        If My.Computer.Network.IsAvailable = False Then
            Exit Sub
        End If

        If My.Computer.Network.Ping("www.terra.com.br") = False Then
            Exit Sub
        End If


        BuscaCNPJ(Me.cboUF.Text, Me.txtCNPJ.Text, Me.Name, "01/01/1900")


        Me.txtCodMun.Text = CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)
        'If Me.txtNome.Text <> "" Then
        '    Me.txFant.Focus()
        'End If
        Me.cboCRT.Focus()

    End Sub

    Private Sub btnVoltar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVoltar.ItemClick
        Dim intPage As Integer = Me.XtraTabControl1.SelectedTabPageIndex
        Me.btnAvancar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Try

            If Me.XtraTabPage2.PageVisible = True Then
                Me.XtraTabControl1.SelectedTabPageIndex = intPage - 1
                If Me.XtraTabControl1.SelectedTabPageIndex = 3 Then
                    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Me.Bar3.ItemLinks.Item(4).BeginGroup = True
                Else
                    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.Bar3.ItemLinks.Item(4).BeginGroup = False
                End If
            Else
                Me.XtraTabControl1.SelectedTabPageIndex = intPage - 2
                If Me.XtraTabControl1.SelectedTabPageIndex = 2 Then
                    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Me.Bar3.ItemLinks.Item(4).BeginGroup = True
                Else
                    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.Bar3.ItemLinks.Item(4).BeginGroup = False
                End If
            End If
     
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnAvancar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAvancar.ItemClick
        Dim intPage As Integer = Me.XtraTabControl1.SelectedTabPageIndex
        Try
            If intPage = 0 Then
                If Validar(Me.txtCNPJ) = False Then Exit Sub
                If Validar(Me.cboCRT) = False Then Exit Sub
                If Validar(Me.txtNome) = False Then Exit Sub
                If Validar(Me.txtFant) = False Then Exit Sub
                If Validar(Me.txtIE) = False Then Exit Sub
                If Validar(Me.txtCep) = False Then Exit Sub
                If Validar(Me.txtEnd) = False Then Exit Sub
                If Validar(Me.txtNum) = False Then Exit Sub
                If Validar(Me.txtBairro) = False Then Exit Sub
                If Validar(Me.txtCodMun) = False Then Exit Sub
                If Validar(Me.cboCidade) = False Then Exit Sub
            End If

            If Me.XtraTabPage2.PageVisible = True Then


                Me.XtraTabControl1.SelectedTabPageIndex = intPage + 1

                If intPage = 2 Then
                    Me.btnAvancar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If


                If Me.XtraTabControl1.SelectedTabPageIndex = 3 Then
                    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Me.Bar3.ItemLinks.Item(4).BeginGroup = True
                Else
                    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.Bar3.ItemLinks.Item(4).BeginGroup = False
                End If
            Else

                Me.XtraTabControl1.SelectedTabPageIndex = intPage + 2

                If intPage = 0 Then
                    Me.btnAvancar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If

                If Me.XtraTabControl1.SelectedTabPageIndex = 2 Then
                    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Me.Bar3.ItemLinks.Item(4).BeginGroup = True
                Else
                    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.Bar3.ItemLinks.Item(4).BeginGroup = False
                End If
            End If
   
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Alterar()
        Me.cboUF.Focus()
        Timer1.Stop()
    End Sub


    Public Overloads Shared Function ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap

        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .Clear(Color.White)
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver
                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using


        Return bmDest
    End Function

    Private Sub XtraTabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Click
        If Me.XtraTabPage2.PageVisible = True Then

            If Me.XtraTabControl1.SelectedTabPageIndex = 3 Then
                Me.btnAvancar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.Bar3.ItemLinks.Item(4).BeginGroup = True
            Else
                Me.btnAvancar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.Bar3.ItemLinks.Item(4).BeginGroup = False
            End If
        Else
            If Me.XtraTabControl1.SelectedTabPageIndex = 2 Then
                Me.btnAvancar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.Bar3.ItemLinks.Item(4).BeginGroup = True
            Else
                Me.btnAvancar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.Bar3.ItemLinks.Item(4).BeginGroup = False
            End If
        End If

    End Sub

    Private Sub cboCRT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCRT.Leave
        If Me.txtNome.Text = "" Then
            Me.txtNome.Focus()
        Else
            If Me.txtFant.Text = "" Then
                Me.txtFant.Focus()
            Else
                If Me.txtCep.Text = "" Then
                    Me.txtCep.Focus()
                Else
                    Me.txtTel1.Focus()
                End If
            End If
          
        End If
    End Sub

    Private Sub txtFant_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFant.Leave
        If Me.txtCep.Text = "" Then
            Me.txtCep.Focus()
        Else
            Me.txtTel1.Focus()
        End If
    End Sub

    Private Shared Function CodigoMunicipio(ByVal parCidade As String, ByVal parUF As String) As String
        Dim strCodMunicipio As String = ""
        If parCidade <> "" Then
            Dim dt As DataTable = CarregarDataTable("SELECT CodIBGE FROM Cidade where Nome = '" & parCidade.Replace("'", "´") & "' and UF = '" & parUF & "'")
            If dt.Rows.Count > 0 Then
                strCodMunicipio = dt.Rows.Item(0).Item("CodIBGE").ToString
            End If
        End If
        Return strCodMunicipio
    End Function
    Private Shared Function CarregarLogo(ByVal parLogo As Object) As Boolean
        Try
            Dim Imagem As Byte() = CType(parLogo, Byte())

            Dim memorybits As New MemoryStream(Imagem)

            Dim bitmap As New Bitmap(memorybits)
            LogoTipo = bitmap
            Return True
        Catch ex As Exception

        End Try
    End Function

    Private Shared Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function

    Private Sub picLogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLogo.Click
        ofdImagem.FileName = ""
        ofdImagem.ShowDialog()
        If ofdImagem.FileName <> "" Then
            Me.picLogo.Image.Dispose()
            Me.picLogo.Image = System.Drawing.Bitmap.FromFile(ofdImagem.FileName)
        End If
        ofdImagem.Dispose()
        Me.picLogo.Image = ResizeImage(Me.picLogo.Image, 180, 151)
    End Sub

 
End Class