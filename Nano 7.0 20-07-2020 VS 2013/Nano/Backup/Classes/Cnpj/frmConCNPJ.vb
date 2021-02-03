Option Strict Off 'because of late binding MyWeb.ExecWB
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Nano.clsFuncoes
Public Class frmConCNPJ
    Private consulta As ConsultaCNPJ.ConsultaCNPJReceita
    Public dtData As Date

    Public strForm As String
    Public strCNPJ As String
    Public strUF As String

    Dim strText As String
    Dim strValAnt, strAux As String
    Dim strValNovo As String = Nothing
    Dim antIndex, proxIndex As Integer

    Dim strRaiz As String
    Dim strUrl As String
    Dim strImg As String

    Dim bolJaPassou As Boolean = False

    Dim bolClick As Boolean = False


    Dim strRGIE As String
    Dim strEndereco As String
    Dim strNumero As String
    Dim strBairro As String
    Dim strComplemento As String
    Dim strCidade As String
    Dim strEstado As String
    Dim strRazao As String
    Dim strFantasia As String
    Dim strCep As String

    Dim bolAlterar As Boolean = False
    Public Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum
    Private Enum execOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    Private Sub frmConCNPJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtLetras.ResetText()
        Select Case strUF
            Case "SP"
                strRaiz = "https://www.cadesp.fazenda.sp.gov.br/(S(g4rgvq55hzjxpeey0qrgb255))"
                strUrl = "/Pages/Cadastro/Consultas/ConsultaPublica/ConsultaPublica.aspx"
                strImg = "/imagemDinamica.aspx"
                bolJaPassou = False
                AddHandler wb2.DocumentCompleted, AddressOf wb2_DocumentCompleted
                Me.wb2.Navigate(strRaiz & strUrl)

            Case "RS"
                wb1.Navigate("https://www.sefaz.rs.gov.br/ASP/SEF_ROOT/INF/SEF-sintegra-1.asp")
            Case "MT", "MS", "MG"


            Case "CPF"

                Me.Timer1.Start()

            Case Else
                'carregarCaptcha()
                'Me.wb1.Visible = False
                'Me.wb2.Visible = False
                'Me.picLetras.Visible = True
                Me.txtLetras.Text = strCNPJ
        End Select


        Me.txtLetras.Focus()

    End Sub

    Private Function CarregarInfo(ByVal strParIndex As String, ByVal strParIndexProx As String, ByVal parWeb As WebBrowser) As String
        Dim strRR, strIndexOf, strIndexProx As String
        Dim strInfo As String
        Dim PosString, AntString As Integer
        Dim Tamanho As Integer

        strRR = parWeb.Document.ActiveElement.InnerText
        strRR = strRR.Trim
        strIndexOf = strParIndex
        strIndexProx = strParIndexProx

        Tamanho = strIndexOf.Length
        AntString = strRR.IndexOf(strIndexProx)

        PosString = strRR.IndexOf(strIndexOf)
        PosString = PosString + Tamanho
        strInfo = strRR.Substring(PosString, AntString - PosString)
        Return strInfo.Trim
    End Function
    Public Sub carregarCaptcha()
        consulta = New ConsultaCNPJ.ConsultaCNPJReceita()
        txtLetras.Text = ""
        txtLetras.Focus()
        Dim cursor As Cursor
        cursor = Me.Cursor
        Me.Cursor = Cursors.WaitCursor
        Dim bit As Bitmap = consulta.GetCaptcha()
        If bit IsNot Nothing Then
            picLetras.Image = bit
        Else
            MessageBox.Show("Não foi possível recuperar a imagem de validação do site da Receita Federal")
        End If
        Me.Cursor = cursor
    End Sub

    Private Function RecuperaColunaValor(ByVal pattern As [String], ByVal parColuna As String) As String

        Dim strRetorno As String = pattern.Replace(vbLf, "").Replace(vbTab, "").Replace(vbCr, "")

        Select Case parColuna
            Case "Razao"

                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha NOME EMPRESARIAL -->", "<!-- Fim Linha NOME EMPRESARIAL -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

            Case "Fantasia"
                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha ESTABELECIMENTO -->", "<!-- Fim Linha ESTABELECIMENTO -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

            Case "Endereco"

                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

            Case "Numero"

                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

            Case "Complemento"

                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

            Case "Cep"

                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

            Case "Bairro"

                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

            Case "Cidade"

                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

            Case "Estado"

                strRetorno = StringEntreString(strRetorno, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->")
                strRetorno = StringEntreString(strRetorno, "<tr>", "</tr>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringSaltaString(strRetorno, "</b>")
                strRetorno = StringEntreString(strRetorno, "<b>", "</b>")

        End Select
        Return strRetorno.Trim
    End Function
    Private Function StringEntreString(ByVal Str As [String], ByVal StrInicio As [String], ByVal StrFinal As [String]) As [String]
        Dim Ini As Integer
        Dim Fim As Integer
        Dim Diff As Integer
        Ini = Str.IndexOf(StrInicio)
        Fim = Str.IndexOf(StrFinal)
        If Ini > 0 Then
            Ini = Ini + StrInicio.Length
        End If
        If Fim > 0 Then
            Fim = Fim + StrFinal.Length
        End If
        Diff = ((Fim - Ini) - StrFinal.Length)
        If (Fim > Ini) AndAlso (Diff > 0) Then
            Return Str.Substring(Ini, Diff)
        Else
            Return ""
        End If
    End Function

    Private Function StringSaltaString(ByVal Str As [String], ByVal StrInicio As [String]) As [String]
        Dim Ini As Integer
        Ini = Str.IndexOf(StrInicio)
        If Ini > 0 Then
            Ini = Ini + StrInicio.Length
            Return Str.Substring(Ini)
        Else
            Return Str
        End If
    End Function

    Public Function StringPrimeiraLetraMaiuscula(ByVal Str As [String]) As String
        Dim StrResult As String = ""
        If Str.Length > 0 Then
            StrResult += Str.Substring(0, 1).ToUpper()
            StrResult += Str.Substring(1, Str.Length - 1).ToLower()
        End If
        Return StrResult
    End Function
    Private Sub Consultar()
        Dim cursor As Cursor
        cursor = Me.Cursor
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim tmp As String = consulta.Consulta(strCNPJ, txtLetras.Text)

            If tmp.Length > 0 Then

                Select Case strForm
                    Case "frmCadCliente"
                        frmCadCliente.txtNome.Text = RecuperaColunaValor(tmp, "Razao").Replace("'", "´")
                        frmCadCliente.txtFant.Text = RecuperaColunaValor(tmp, "Fantasia").Replace("'", "´")
                        frmCadCliente.txtEnd.Text = RecuperaColunaValor(tmp, "Endereco").Replace("'", "´")
                        frmCadCliente.txtNum.Text = RecuperaColunaValor(tmp, "Numero").Replace("'", "´")
                        frmCadCliente.txtBairro.Text = RecuperaColunaValor(tmp, "Bairro").Replace("'", "´")
                        frmCadCliente.txtCep.Text = RecuperaColunaValor(tmp, "Cep").Replace("'", "´")
                        frmCadCliente.cboCidade.Text = RecuperaColunaValor(tmp, "Cidade").Replace("'", "´")
                        frmCadCliente.cboUF.Text = RecuperaColunaValor(tmp, "Estado").Replace("'", "´")
                        frmCadCliente.txtComp.Text = RecuperaColunaValor(tmp, "Complemento").Replace("'", "´")
                        frmCadFornecedor.txtTel1.Focus()
                    Case "frmCadFornecedor"
                        frmCadFornecedor.txtNome.Text = RecuperaColunaValor(tmp, "Razao").Replace("'", "´")
                        frmCadFornecedor.txtFantasia.Text = RecuperaColunaValor(tmp, "Fantasia").Replace("'", "´")
                        frmCadFornecedor.txtEnd.Text = RecuperaColunaValor(tmp, "Endereco").Replace("'", "´")
                        frmCadFornecedor.txtNum.Text = RecuperaColunaValor(tmp, "Numero").Replace("'", "´")
                        frmCadFornecedor.txtBairro.Text = RecuperaColunaValor(tmp, "Bairro").Replace("'", "´")
                        frmCadFornecedor.txtCep.Text = RecuperaColunaValor(tmp, "Cep").Replace("'", "´")
                        frmCadFornecedor.cboCidade.Text = RecuperaColunaValor(tmp, "Cidade").Replace("'", "´")
                        frmCadFornecedor.cboUF.Text = RecuperaColunaValor(tmp, "Estado").Replace("'", "´")
                        frmCadFornecedor.txtComp.Text = RecuperaColunaValor(tmp, "Complemento").Replace("'", "´")
                        frmCadFornecedor.txtTel1.Focus()
                End Select

                

                If RecuperaColunaValor(tmp, "Razao") <> "" Then
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            carregarCaptcha()
        End Try

        Me.Cursor = cursor
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If strCNPJ = "" Then
            MsgBox("Informe o CNPJ!", MsgBoxStyle.Information)
            Me.Close()
            Exit Sub
        End If
        If txtLetras.Text = "" Then Exit Sub

        Select Case strUF
            Case "SP"
                'Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_imagemDinamicaTextBox").SetAttribute("value", Me.txtLetras.Text)

                'Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_valorFiltroTextBox").SetAttribute("value", strCNPJ)
                'Me.wb2.Document.GetElementById("ctl00_conteudoPaginaPlaceHolder_consultaPublicaButton").InvokeMember("click")

                Me.wb2.Document.Forms(0).All("ctl00$conteudoPaginaPlaceHolder$filtroTabContainer$filtroEmitirCertidaoTabPanel$imagemDinamicaTextBox").SetAttribute("value", Me.txtLetras.Text)

                Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_filtroTabContainer_filtroEmitirCertidaoTabPanel_valorFiltroTextBox").SetAttribute("value", strCNPJ)
                Me.wb2.Document.GetElementById("ctl00_conteudoPaginaPlaceHolder_filtroTabContainer_filtroEmitirCertidaoTabPanel_consultaPublicaButton").InvokeMember("click")
            Case "RS"
                Me.wb1.Document.Forms(0).All("captchaCode").SetAttribute("value", Me.txtLetras.Text)

                Dim i As Integer
                Try
                    For i = 0 To wb1.Document.Forms(0).All.Count - 1

                        'seta o campo do captcha como enable = true para que seja possivel acessar a pagina de informações
                        wb1.Document.Forms(0).All.GetElementsByName("captchaCode").Item("captchaCode").Enabled = True

                    Next
                Catch ex As Exception
                End Try
                Me.wb1.Document.GetElementById("btOK").InvokeMember("click")

                bolClick = True


            Case "MS"
                Me.wb1.Document.Forms(0).All("captchacode").SetAttribute("value", Me.txtLetras.Text)


                Me.wb1.Document.Forms(0).All("CGC_CPF").SetAttribute("value", strCNPJ)
                Me.wb1.Document.GetElementById("bconsulta").InvokeMember("click")
            Case "MT"
                Me.wb1.Document.Forms(0).All("captchaDigitado").SetAttribute("value", Me.txtLetras.Text)

                Me.wb1.Document.Forms(0).All("numero").SetAttribute("value", strCNPJ)
                Me.wb1.Document.GetElementById("btnConsultar").InvokeMember("click")


            Case "MG"
                Me.wb1.Document.Forms(1).All("recaptcha_response_field").SetAttribute("value", Me.txtLetras.Text)

                Me.wb1.Document.Forms(1).All("filtro").SetAttribute("value", strCNPJ)
                Me.wb1.Document.GetElementById("Pesquisar").InvokeMember("click")


            Case "CPF"
                wb1.Visible = False
                'Me.wb1.Document.Forms(2).All("txtTexto_captcha_serpro_gov_br").SetAttribute("value", Me.txtLetras.Text)
                'Me.wb1.Document.Forms(1).All("txtCPF").SetAttribute("value", strCNPJ)
                'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = True
                'Me.wb1.Document.GetElementById("btnAR2").InvokeMember("click")

                Try
                    Me.wb1.Document.GetElementById("txtTexto_captcha_serpro_gov_br").SetAttribute("value", Me.txtLetras.Text)
                    Me.wb1.Document.GetElementById("txtCPF").SetAttribute("value", strCNPJ)
                    Me.wb1.Document.GetElementById("txtDataNascimento").SetAttribute("value", My.Forms.frmCadCliente.dtNasc.Text)
                    Me.wb1.Document.GetElementById("Enviar").InvokeMember("click")
                Catch ex As Exception
                End Try

            Case Else
                ' Consultar()
                If IO.File.Exists(My.Application.Info.DirectoryPath & "\cnpj.txt") = True Then
                    System.IO.File.Delete(My.Application.Info.DirectoryPath & "\cnpj.txt")
                End If
                My.Computer.Network.DownloadFile("https://www.receitaws.com.br/v1/cnpj/" & strCNPJ, My.Application.Info.DirectoryPath & "\cnpj.txt")
                Dim strTexto As String = LerArquivo(My.Application.Info.DirectoryPath & "\cnpj.txt", False)


                'strRGIE = ""
                'strRazao = CarregarInfo2("nome", "uf", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                'strEndereco = CarregarInfo2("logradouro", "numero", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                'strNumero = CarregarInfo2("numero", "cep", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                'strComplemento = CarregarInfo2("complemento", "efr", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                'strBairro = CarregarInfo2("bairro", "logradouro", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                'strCidade = CarregarInfo2("municipio", "abertura", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                'strEstado = CarregarInfo2("uf", "telefone", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                'If strEstado.Length > 2 Then
                '    strEstado = CarregarInfo2("uf", "qsa", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                '    If strEstado.Length > 2 Then
                '        strEstado = strEstado.Substring(0, 2)
                '    End If
                'End If
                'strFantasia = ""
                'strCep = CarregarInfo2("cep", "municipio", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                'CarregarForm()

                strRGIE = ""
                strRazao = CarregarInfo2("nome", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                strEndereco = CarregarInfo2("logradouro", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                strNumero = CarregarInfo2("numero", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                strComplemento = CarregarInfo2("complemento", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                strBairro = CarregarInfo2("bairro", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                strCidade = CarregarInfo2("municipio", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                strEstado = CarregarInfo2("uf", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                If strEstado.Length > 2 Then
                    strEstado = CarregarInfo2("uf", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                    If strEstado.Length > 2 Then
                        strEstado = strEstado.Substring(0, 2)
                    End If
                End If
                strFantasia = ""
                strCep = CarregarInfo2("cep", """,", strTexto).Replace("""", "").Replace(":", "").Replace(",", "").Trim
                CarregarForm()

                Me.Close()
        End Select

    End Sub
    Private Function CarregarInfo2(ByVal strParIndex As String, ByVal strParIndexProx As String, ByVal parWeb As String) As String
        Dim strRR, strIndexOf, strIndexProx As String
        Dim strInfo As String
        Dim PosString, AntString As Integer
        Dim Tamanho As Integer

        strRR = parWeb

        strIndexOf = strParIndex

        strIndexProx = strParIndexProx
        Tamanho = strIndexOf.Length
        PosString = strRR.IndexOf(strIndexOf)
        AntString = strRR.IndexOf(strIndexProx, PosString)
        Select Case strUF
            Case "SP", "RS", "MT", "MS", "MG", "CPF"
            Case Else
                If strIndexOf = "NÚMERO" Then
                    Dim vetArray As Array = Split(strRR, "LOGRADOURO")

                    strRR = vetArray(1)
                    Tamanho = strIndexOf.Length
                    PosString = strRR.IndexOf(strIndexOf)
                    AntString = strRR.IndexOf(strIndexProx, PosString)
                End If
        End Select



        PosString = PosString + Tamanho
        Try
            strInfo = strRR.Substring(PosString, AntString - PosString)
        Catch ex As Exception
            strInfo = strRR.Substring(PosString, AntString - PosString)
        End Try

        Return strInfo.Trim
    End Function
    Private Sub ttbLetras_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLetras.Leave
        Me.btnOk.Focus()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Select Case strUF
            Case "SP"
                'Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_valorFiltroTextBox").SetAttribute("value", strCNPJ)
                'Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_imagemDinamicaTextBox").SetAttribute("value", "1234")
                'Me.wb2.Document.GetElementById("ctl00_conteudoPaginaPlaceHolder_consultaPublicaButton").InvokeMember("click")
                Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_filtroTabContainer_filtroEmitirCertidaoTabPanel_valorFiltroTextBox").SetAttribute("value", strCNPJ)
                Me.wb2.Document.Forms(0).All("ctl00$conteudoPaginaPlaceHolder$filtroTabContainer$filtroEmitirCertidaoTabPanel$imagemDinamicaTextBox").SetAttribute("value", "1234")
                Me.wb2.Document.GetElementById("ctl00_conteudoPaginaPlaceHolder_filtroTabContainer_filtroEmitirCertidaoTabPanel_consultaPublicaButton").InvokeMember("click")
            Case "RS"
                Me.wb1.Visible = False
                Me.wb1.Navigate("https://www.sefaz.rs.gov.br/ASP/SEF_ROOT/INF/SEF-sintegra-1.asp")
            Case "MT"
                Me.wb1.Visible = False
                Me.wb1.Document.Forms(0).All("numero").SetAttribute("value", "1234")
                Me.wb1.Document.Forms(0).All("numero").SetAttribute("value", strCNPJ)
                Me.wb1.Document.GetElementById("btnConsultar").InvokeMember("click")
            Case "MG"
                Me.wb1.Visible = False
                Me.wb1.Navigate("http://consultasintegra.fazenda.mg.gov.br/sintegra/")
            Case "MS"
                Me.wb1.Visible = False
                Me.wb1.Navigate("http://www1.sefaz.ms.gov.br/cadastro/CadastroMsCCI.asp")
                'Case "CPF"
                ' wb1.Visible = False
                'Me.wb1.Document.Forms(2).All("txtTexto_captcha_serpro_gov_br").SetAttribute("value", "123456")
                'Me.wb1.Document.Forms(1).All("txtCPF").SetAttribute("value", strCNPJ)
                'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = True
                'Me.wb1.Document.GetElementById("btnAR2").InvokeMember("click")
                'bolAlterar = True
            Case Else
                carregarCaptcha()
                If strUF = "CPF" Then
                    Me.Timer1.Start()
                End If
        End Select


    End Sub

    Private Sub wb1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb1.DocumentCompleted
        Dim i As Integer
        Dim strr As String = wb1.Url.ToString
        Select Case strUF

            Case "SP"
                If strCNPJ = Nothing Then Exit Sub
                Me.wb1.Document.Window.ScrollTo(9, 15)
                wb1.Visible = True

            Case "RS"
                If wb1.Url.ToString = "http://sintegra.sefaz.rs.gov.br/sef_root/inf/Sintegra_Entrada.asp" Then

                    If bolClick = True Then

                        Me.Hide()

                        wb1.Navigate("https://www.sefaz.rs.gov.br/ASP/SEF_ROOT/INF/SEF-sintegra-1.asp")
                        bolClick = False

                        Exit Sub
                    End If
                End If
                Dim strSint As String = "_SINTEGRA_"

                For i = 0 To wb1.Url.ToString.Length
                    'o existe uma mudança na url do site para cada janela
                    'quando tiver o numero 1 significa que esta na janela de digitar o cnpj
                    'quando for 2 estará na tela do captcha
                    'e quando 4 sera a tela com as informações 
                    Try
                        'verifica em qual tela o navegador esta pela sua url buscando o numero 1, 2, ou 4
                        strSint = strr.Substring(i, 1)
                        If strSint = "1" Or strSint = "2" Or strSint = "4" Then
                            Exit For
                        End If
                    Catch ex As Exception

                    End Try
                Next


                If strSint = "1" Then

                    If bolClick = True Then
                        'verifica se o botão consultar ja foi clicado caso sim o formulario de validação ficará oculto
                        Me.Hide()

                        bolClick = False
                        Exit Sub
                    Else

                        'caso não irá entrar com o cnpj digitado para a janela do captcha
                        Me.wb1.Document.Forms(0).All("cgcmf").SetAttribute("value", strCNPJ)
                        Me.wb1.Document.GetElementById("Action").InvokeMember("click")
                    End If
                ElseIf strSint = "2" Then


                    ' se estiver na tela do captcha vai dexar o campo de digitação do captcha enable false para que ele não tenha o foco 
                    wb1.Document.Forms(0).All.GetElementsByName("captchaCode").Item("captchaCode").Enabled = False

                    Me.txtLetras.Focus()

                    wb1.Document.Window.ScrollTo(23, 230)

                    'impede que o erro de script gerado ao deixar o campo enable false apareça
                    AddHandler CType(sender, WebBrowser).Document.Window.Error, AddressOf Window_Error

                    wb1.Visible = True

                ElseIf strSint = "4" Then
                    'caso seja a tela de informações vai exibilas nos texts do form 
                    strr = wb1.Document.ActiveElement.InnerText

                    strRGIE = CarregarInfo("CAD ICMS", "Inscrição Única", wb1)
                    strRazao = CarregarInfo("Razão Social", "Nome Fantasia", wb1)
                    strFantasia = CarregarInfo("Nome Fantasia", "ENDEREÇO", wb1)
                    strEndereco = CarregarInfo("Logradouro", "Número", wb1)
                    strNumero = CarregarInfo("Número", "Complemento", wb1)
                    strComplemento = CarregarInfo("Complemento", "Bairro", wb1)
                    strBairro = CarregarInfo("Bairro", "Município", wb1)
                    strCidade = CarregarInfo("Município", "UF", wb1)
                    strEstado = CarregarInfo("UF", "CEP", wb1)
                    strCep = CarregarInfo("CEP", "Telefone", wb1)
                    CarregarForm()
                    Me.Close()
                End If

            Case "MS"

                'strValida vai pegar o innerText da pagina e vai verificar se ele contem aquela especifica parte localizada apenas na tela de informações
                'caso ela não contenha sera a tela de digitar o cnpj e captcha, caso contenha sera a tela de informações
                Dim strValida As String = wb1.Document.ActiveElement.InnerText
                If strValida.Contains("RAZÃO SOCIAL/NOME") Then

                    strRGIE = CarregarInfo("INSCRIÇÃO ESTADUAL", "CONSULTA DE INSCRIÇÃO E DE SITUAÇÃO CADASTRAL DATA INÍCIO DA ATIVIDADE", wb1)
                    strRazao = CarregarInfo("RAZÃO SOCIAL/NOME", "DESCRIÇÃO DA ATIVIDADE ECONÔMICA", wb1)
                    strEndereco = CarregarInfo("LOGRADOURO", "NÚMERO", wb1)
                    strNumero = CarregarInfo("NÚMERO", "COMPLEMENTO", wb1)
                    strComplemento = CarregarInfo("COMPLEMENTO", "CEP", wb1)
                    strBairro = CarregarInfo("BAIRRO", "MUNICÍPIO", wb1)
                    strCidade = CarregarInfo("MUNICÍPIO", "UF", wb1)
                    Dim strMs As String = CarregarInfo("UF", "DATA DA ÚLTIMA ATUALIZAÇÃO", wb1)
                    strEstado = strMs.Substring(0, 2)
                    strCep = CarregarInfo("CEP", "BAIRRO", wb1)
                    CarregarForm()
                    Me.Close()

                Else

                    wb1.Document.Window.ScrollTo(87, 213)
                    wb1.Visible = True

                End If

            Case "MT"
                'strValida vai pegar o innerText da pagina e vai verificar se ele contem aquela especifica parte localizada apenas na tela de informações
                'caso ela não contenha sera a tela de digitar o cnpj e captcha, caso contenha sera a tela de informações
                Dim strValida As String = wb1.Document.ActiveElement.InnerText
                If strValida.Contains("Página de Erros") Then
                    wb1.Visible = False
                    wb1.Navigate("https://www.sefaz.mt.gov.br/sid/consulta/infocadastral/consultar/publica")



                ElseIf strValida.Contains("Identificação") = False Then


                    wb1.Document.Window.ScrollTo(216, 206)
                    wb1.Visible = True
                    AddHandler CType(sender, WebBrowser).Document.Window.Error, AddressOf Window_Error

                Else

                    strRGIE = CarregarInfo("Inscrição estadual:", "Razão social:", wb1)
                    strRazao = CarregarInfo("Razão social:", "Endereço", wb1)
                    strEndereco = CarregarInfo("Logradouro:", "Número:", wb1)
                    strNumero = CarregarInfo("Número:", "Complemento:", wb1)
                    strComplemento = CarregarInfo("Complemento:", "Bairro:", wb1)
                    strBairro = CarregarInfo("Bairro:", "Município", wb1)
                    Dim strMun As String = CarregarInfo("Município/UF:", "CEP:", wb1)
                    Dim intIndex As Integer = strMun.IndexOf(" - ")
                    strCidade = strMun.Substring(0, strMun.Length - intIndex)
                    strEstado = strMun.Substring(intIndex + 3, 2)
                    strCep = CarregarInfo("CEP:", "Telefone:", wb1)
                    CarregarForm()
                    Me.Close()
                End If

            Case "MG"
                'strValida vai pegar o innerText da pagina e vai verificar se ele contem aquela especifica parte localizada apenas na tela de informações
                'caso ela não contenha sera a tela de digitar o cnpj e captcha, caso contenha sera a tela de informações
                Dim strValida As String = wb1.Document.ActiveElement.InnerText
                If strValida.Contains("SIARE") Then
                    strRGIE = CarregarInfo("Inscrição Estadual:", "UF:", wb1)
                    strRazao = CarregarInfo("Nome Empresarial:", " Informações Complementares", wb1)
                    strEndereco = CarregarInfo("Logradouro:", "Número:", wb1)
                    strNumero = CarregarInfo("Número:", "Complemento:", wb1)
                    strComplemento = CarregarInfo("Complemento:", "Telefone:", wb1)
                    strBairro = CarregarInfo("Bairro:", "Logradouro:", wb1)
                    strCidade = CarregarInfo("Município:", "Distrito/Povoado:", wb1)
                    strEstado = CarregarInfo("UF:", "Nome Empresarial:", wb1)
                    Dim strCep As String = CarregarInfo("CEP:", "Município:", wb1)
                    Dim indexCep As Integer = strCep.IndexOf("UF:")
                    strCep = strCep.Substring(0, indexCep - 0)
                    CarregarForm()
                    Me.Close()
                Else

                    Me.wb1.Document.Window.ScrollTo(507, 285)
                    Me.wb1.Visible = True
                    AddHandler CType(sender, WebBrowser).Document.Window.Error, AddressOf Window_Error
                    Me.wb1.Document.Forms(1).All("identificadorCmbOpcao").SetAttribute("value", "2")
                End If

            Case "CPF"
                wb1.Visible = False

                AddHandler CType(sender, WebBrowser).Document.Window.Error, AddressOf Window_Error

                'Dim MyWeb As Object = Me.wb1.ActiveXInstance
                'MyWeb = Me.wb1.ActiveXInstance
                'MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 100, CObj(IntPtr.Zero))
                'MyWeb = Nothing
                Dim doc As String
                doc = Me.wb1.Document.ActiveElement.InnerText




                If bolAlterar = False Then


                    If doc.Contains("Nome:") Then
                        strRazao = CarregarInfo("Nome:", "Data de Nascimento:", wb1)
                        CarregarForm()
                        Me.Close()
                    ElseIf doc.Contains("CPF incorreto") Then
                        MsgBox("CPF incorreto.", MsgBoxStyle.Information)
                        Me.Close()
                    ElseIf doc.Contains("Data de nascimento informada") Then
                        MsgBox("Data de nascimento informada está divergente da constante na base de dados da Secretaria da Receita Federal do Brasil.", MsgBoxStyle.Information)
                        Me.Close()
                    ElseIf doc.Contains("Os caracteres da imagem não foram preenchidos corretamente") Then
                        'MsgBox("Os caracteres da imagem não foram preenchidos corretamente.", MsgBoxStyle.Information)
                        'wb1.ScriptErrorsSuppressed = True
                        wb1.Document.Body.Style = "overflow:hidden"
                        Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = False
                        Me.wb1.Document.Window.ScrollTo(23, 320)
                        strCNPJ = strCNPJ.Replace(".", "").Replace("-", "")
                        strCNPJ = AddPonto(strCNPJ, "F")
                        Me.wb1.Document.Forms(1).All("txtCPF").SetAttribute("value", strCNPJ)
                        Dim strNasc As String = Format(dtData, "dd/MM/yyyy")
                        strNasc = My.Forms.frmCadCliente.dtNasc.Text
                        Me.wb1.Document.Forms(1).All("txtDataNascimento").SetAttribute("value", strNasc)
                        Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = True
                        Me.wb1.Document.GetElementById("id_submit").InvokeMember("click")

                    Else

                        'wb1.ScriptErrorsSuppressed = True
                        wb1.Document.Body.Style = "overflow:hidden"
                        Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = False
                        Me.wb1.Document.Window.ScrollTo(23, 320)
                        strCNPJ = strCNPJ.Replace(".", "").Replace("-", "")
                        strCNPJ = AddPonto(strCNPJ, "F")
                        Me.wb1.Document.Forms(1).All("txtCPF").SetAttribute("value", strCNPJ)
                        Dim strNasc As String = Format(dtData, "dd/MM/yyyy")
                        strNasc = My.Forms.frmCadCliente.dtNasc.Text
                        Me.wb1.Document.Forms(1).All("txtDataNascimento").SetAttribute("value", strNasc)
                        Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = True
                        Me.wb1.Document.GetElementById("id_submit").InvokeMember("click")


                        'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = False
                        'Me.wb1.Document.Forms(1).All("txtCPF").SetAttribute("value", strCNPJ)
                        'Dim strNasc As String = Format(dtData, "dd/MM/yyyy")
                        'Me.wb1.Document.Forms(1).All("txtDataNascimento").SetAttribute("value", strNasc)
                        'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = True
                        'Me.wb1.Document.Forms(1).All("txtDataNascimento").SetAttribute("value", strNasc)



                        'wb1.ScriptErrorsSuppressed = True
                        'wb1.Document.Body.Style = "overflow:hidden"
                        'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = False
                        'Me.wb1.Document.Window.ScrollTo(23, 320)
                        'strCNPJ = strCNPJ.Replace(".", "").Replace("-", "")
                        'strCNPJ = AddPonto(strCNPJ, "F")
                        'Me.wb1.Document.Forms(1).All("txtCPF").SetAttribute("value", strCNPJ)
                        'Dim strNasc As String = Format(dtData, "dd/MM/yyyy")
                        'Me.wb1.Document.Forms(1).All("txtDataNascimento").SetAttribute("value", strNasc)
                        'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = True
                        'Me.wb1.Document.GetElementById("id_submit").InvokeMember("click")
                        'Dim intLeft As Integer
                        'Dim intTop As Integer
                        'If wb1.ReadyState = WebBrowserReadyState.Complete Then


                        'If (wb1.Document IsNot Nothing) Then

                        'With wb1.Document
                        'Dim Elems As HtmlElementCollection = .All.GetElementsByName("txtTexto_captcha_serpro_gov_br")
                        'If (Not Elems Is Nothing And Elems.Count > 0) Then
                        ' Dim Elem As HtmlElement = Elems(0)
                        'Elem.ScrollIntoView(True)
                        'intLeft = Elem.OffsetRectangle.Left
                        'intLeft += 2
                        'intTop = Elem.OffsetRectangle.Top
                        'intTop -= 64
                    End If
                    'End With
                    End If
                'End If
                'Me.wb1.Document.Window.ScrollTo(intLeft, intTop)

                'End If
                'Else
                'wb1.ScriptErrorsSuppressed = True
                'wb1.Document.Body.Style = "overflow:hidden"
                'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = False
                'Me.wb1.Document.Window.ScrollTo(23, 320)
                'strCNPJ = strCNPJ.Replace(".", "").Replace("-", "")
                'strCNPJ = AddPonto(strCNPJ, "F")
                'Me.wb1.Document.Forms(1).All("txtCPF").SetAttribute("value", strCNPJ)
                'Dim strNasc As String = Format(dtData, "dd/MM/yyyy")
                'Me.wb1.Document.Forms(1).All("txtDataNascimento").SetAttribute("value", strNasc)
                'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = True
                'Me.wb1.Document.GetElementById("id_submit").InvokeMember("click")
                'bolAlterar = False
                'End If
                'wb1.ScriptErrorsSuppressed = True
                'wb1.Document.Body.Style = "overflow:hidden"


                'Me.wb1.Document.Forms(1).All.GetElementsByName("txtCPF").Item("txtCPF").Enabled = False

                wb1.Visible = True
        End Select
    End Sub

    Private Sub CarregarForm()


        Select Case strForm
            Case "frmCadCliente"
                Select Case strUF
                    Case "CPF"
                        frmCadCliente.txtNome.Text = strRazao.Replace("'", "´")
                    Case Else
                        frmCadCliente.txtRGIE.Text = strRGIE.Replace("'", "´")
                        frmCadCliente.txtNome.Text = strRazao.Replace("'", "´")
                        frmCadCliente.txtFant.Text = strFantasia.Replace("'", "´")
                        frmCadCliente.txtEnd.Text = strEndereco.Replace("'", "´")
                        frmCadCliente.txtNum.Text = strNumero.Replace("'", "´")
                        frmCadCliente.txtComp.Text = strComplemento.Replace("'", "´")
                        frmCadCliente.txtCep.Text = strCep.Replace("'", "´")
                        frmCadCliente.txtBairro.Text = strBairro.Replace("'", "´")
                        frmCadCliente.cboUF.Text = strEstado.Replace("'", "´")
                        frmCadCliente.cboCidade.Text = strCidade.Replace("'", "´")
                        frmCadCliente.txtTel1.Focus()
                End Select

            Case "frmCadFornecedor"
                Select Case strUF
                    Case "CPF"
                        frmCadFornecedor.txtNome.Text = strRazao.Replace("'", "´")
                    Case Else
                        frmCadFornecedor.txtIE.Text = strRGIE.Replace("'", "´")
                        frmCadFornecedor.txtNome.Text = strRazao.Replace("'", "´")
                        frmCadFornecedor.txtFantasia.Text = strFantasia.Replace("'", "´")
                        frmCadFornecedor.txtEnd.Text = strEndereco.Replace("'", "´")
                        frmCadFornecedor.txtNum.Text = strNumero.Replace("'", "´")
                        frmCadFornecedor.txtComp.Text = strComplemento.Replace("'", "´")
                        frmCadFornecedor.txtCep.Text = strCep.Replace("'", "´")
                        frmCadFornecedor.txtBairro.Text = strBairro.Replace("'", "´")

                        frmCadFornecedor.cboUF.Text = strEstado.Replace("'", "´")
                        frmCadFornecedor.cboCidade.Text = strCidade.Replace("'", "´")
                        frmCadFornecedor.txtTel1.Focus()
                End Select
            Case "frmConfigNfe"
                frmConfigNfe.txtIE.Text = strRGIE.Replace("'", "´")
                frmConfigNfe.txtNome.Text = strRazao.Replace("'", "´")
                frmConfigNfe.txtFant.Text = strFantasia.Replace("'", "´")
                frmConfigNfe.txtEnd.Text = strEndereco.Replace("'", "´")
                frmConfigNfe.txtNum.Text = strNumero.Replace("'", "´")
                frmConfigNfe.txtCep.Text = strCep.Replace("'", "´")
                frmConfigNfe.txtBairro.Text = strBairro.Replace("'", "´")

                frmConfigNfe.cboUF.Text = strEstado.Replace("'", "´")
                frmConfigNfe.cboCidade.Text = strCidade.Replace("'", "´")

                frmConfigNfe.txtTel1.Focus()
            Case "frmConfig"
                frmConfig.txtNome.Text = strRazao.Replace("'", "´")
                frmConfig.txtEnd.Text = strEndereco.Replace("'", "´") & ", " & strNumero.Replace("'", "´") & " - " & strBairro.Replace("'", "´")
                frmConfig.cboUF.Text = strEstado.Replace("'", "´")
                frmConfig.txtCidade.Text = strCidade.Replace("'", "´")
                frmConfig.txtTel.Focus()
        End Select

    End Sub
    Public Property ScriptErrorsSuppressed() As Boolean
        Get
        End Get
        Set(ByVal value As Boolean)
        End Set
    End Property
    'impedir que apareça os erros de script 
    Private Sub SuppressScriptErrorsOnly(ByVal browser As WebBrowser)
        browser.ScriptErrorsSuppressed = False
        AddHandler browser.DocumentCompleted, AddressOf wb1_DocumentCompleted
    End Sub
    'impedir que apareça os erros de script 
    Private Sub Window_Error(ByVal sender As Object, ByVal e As HtmlElementErrorEventArgs)
        e.Handled = True
    End Sub


    Private Sub wb2_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb2.DocumentCompleted

        Dim intRaiz As Integer
        'variavel cont para que a alteração do combo para cnpj seja feita apenas uma vez, assim não recarregando a pegina toda hora
        If bolJaPassou = False Then
            ''preenche o campo cnpj com o valor digitado para que não apareça erro ao dar o click
            'Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_valorFiltroTextBox").SetAttribute("value", strCNPJ)
            '' da o click para alterar o combo para o valor cnpj
            'Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_tipoFiltroDropDownList").SetAttribute("value", "1")
            'Me.wb2.Document.GetElementById("ctl00_conteudoPaginaPlaceHolder_consultaPublicaButton").InvokeMember("click")
            'preenche o campo cnpj com o valor digitado para que não apareça erro ao dar o click
            Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_filtroTabContainer_filtroEmitirCertidaoTabPanel_valorFiltroTextBox").SetAttribute("value", strCNPJ)
            ' da o click para alterar o combo para o valor cnpj
            Me.wb2.Document.Forms(0).All("ctl00_conteudoPaginaPlaceHolder_filtroTabContainer_filtroEmitirCertidaoTabPanel_tipoFiltroDropDownList").SetAttribute("value", "1")
            Me.wb2.Document.GetElementById("ctl00_conteudoPaginaPlaceHolder_filtroTabContainer_filtroEmitirCertidaoTabPanel_consultaPublicaButton").InvokeMember("click")
            bolJaPassou = True
        End If
        'strValida vai pegar o innerText da pagina e vai verificar se ele contem aquela especifica parte localizada apenas na tela de informações
        'caso ela não contenha ira ser carregada a imagem no webbrowser, caso contenha sera a tela de informações
        Dim strValidar As String = wb2.DocumentText
        If strValidar.Contains("de controle da consulta") Then


            strRGIE = CarregarInfo("IE:", "CNPJ:", Me.wb2)
            strRazao = CarregarInfo("Nome Empresarial:", "Nome Fantasia:", Me.wb2)
            strFantasia = CarregarInfo("Nome Fantasia:", "Natureza Jurídica:", Me.wb2)
            strEndereco = CarregarInfo("Logradouro:", "Nº:", Me.wb2)
            strNumero = CarregarInfo("Nº:", "Complemento:", Me.wb2)
            strComplemento = CarregarInfo("Complemento:", "CEP:", Me.wb2)
            strCep = CarregarInfo("CEP:", "Bairro:", Me.wb2)
            strBairro = CarregarInfo("Bairro:", "Município:", Me.wb2)
            strCidade = CarregarInfo("Município:", "UF:", Me.wb2)
            strEstado = CarregarInfo("UF:", "Informações Complementares", Me.wb2)
            CarregarForm()
            Me.Close()
        Else
            Dim strUrlInteira As String = Me.wb2.Url.ToString
            intRaiz = strUrlInteira.IndexOf(strUrl)
            strRaiz = strUrlInteira.Substring(0, intRaiz)
            Me.wb1.Navigate(strRaiz & strImg)
        End If
    End Sub

    Function Base64ToImage(ByVal base64string As String) As System.Drawing.Image
        Dim img As System.Drawing.Image = Nothing
        Try
            'Setup image and get data stream together
            Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
            Dim b64 As String = base64string.Replace(" ", "+")
            Dim b() As Byte

            'Converts the base64 encoded msg to image data
            b = Convert.FromBase64String(b64)
            MS = New System.IO.MemoryStream(b)

            'creates image
            img = System.Drawing.Image.FromStream(MS)
        Catch ex As Exception
        End Try

        Return img
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim strCaptcha As String = Me.wb1.Document.GetElementById("imgcaptcha").GetAttribute("src")
            If strCaptcha.Contains("data:image/png;base64,") = True Then

                Me.PictureEdit1.Image = Base64ToImage(strCaptcha.Replace("data:image/png;base64,", ""))
                Me.PictureEdit1.Visible = True
                Timer1.Stop()

            End If
        Catch ex As Exception
        End Try
    End Sub
End Class