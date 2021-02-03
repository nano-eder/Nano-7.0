Imports Nano.clsFuncoes
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Globalization
Public Class frmClienteTouch
    Dim intCont As Integer
    Dim virtualKeyboard

    Dim intProtecao As Integer
    Dim vetLista As Array

    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Private Declare Function ShowWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal nCmdShow As Integer) As Integer
    Private Const SW_SHOWNORMAL As Integer = 1
    Private Const SW_SHOWMINIMIZED As Integer = 2
    Private Sub frmClienteTouch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
  
    Private Sub frmClienteTouch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StringDeConexao = My.Settings.dsNanoCommerce
        Dim vetNome As Array = Split(StringDeConexao, "=")
        Dim vetNomeComp As Array = Split(vetNome(1).ToString, ";")
        Dim strNomeDoComputador As String = vetNomeComp(0)
        vetNome = Split(vetNome(2).ToString, ";")
        NomeDoBancoSql = vetNome(0).ToString.Trim
        Dim dtConf As DataTable = CarregarDataTable("SELECT Porta, Empresa FROM Config where CNPJ = '26338033000130'")
        'Dim dtConf As DataTable = CarregarDataTable("SELECT Porta, Empresa FROM Config")
        PortaImpressora = dtConf.Rows.Item(0).Item("Porta").ToString
        NomeEmpresa = dtConf.Rows.Item(0).Item("Empresa").ToString

        AbrirTeclado()
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Imagens") = True Then
            vetLista = Directory.GetFiles(My.Application.Info.DirectoryPath & "\Imagens")
        End If
        GerarCupomDesconto("", "000.000.000-00")
        Timer2.Start()
    End Sub
    Private Sub AbrirTeclado()
        Dim iHwnd As IntPtr = FindWindow(vbNullString, "Teclado Virtual")
        ShowWindow(iHwnd, SW_SHOWNORMAL)
        'Try
        '    virtualKeyboard.kill()
        'Catch ex As Exception

        'End Try

        'Dim bolTeclado As Boolean = False

        'Try
        '    MsgBox("1", MsgBoxStyle.Information)
        '    virtualKeyboard = New System.Diagnostics.Process()
        '    virtualKeyboard = System.Diagnostics.Process.Start("C:\\Windows\\System32\\osk.exe")
        '    bolTeclado = True
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'End Try

        ' '' If bolTeclado = False Then
        'Try
        '    MsgBox("2", MsgBoxStyle.Information)
        '    virtualKeyboard = New System.Diagnostics.Process()
        '    'virtualKeyboard = System.Diagnostics.Process.Start("TabTip.exe")
        '    virtualKeyboard = System.Diagnostics.Process.Start("C:\NANO\Teclado.bat")

        '    bolTeclado = True
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'End Try

        ' '' End If

        '' If bolTeclado = False Then
        'Try
        '    'MsgBox("4", MsgBoxStyle.Information)
        '    virtualKeyboard = New System.Diagnostics.Process()
        '    virtualKeyboard = System.Diagnostics.Process.Start("osk.exe")
        '    bolTeclado = True
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'End Try
        '' End If
        'If bolTeclado = False Then
        '    Try

        '        virtualKeyboard = New System.Diagnostics.Process()
        '        virtualKeyboard = System.Diagnostics.Process.Start("C:\Windows\SysWow64\osk.exe")
        '        bolTeclado = True
        '    Catch ex As Exception

        '    End Try

        'End If
        'If bolTeclado = False Then
        '    Try
        '        virtualKeyboard = New System.Diagnostics.Process()
        '        virtualKeyboard = System.Diagnostics.Process.Start("c:\program files\common files\microsoft shared\ink\tabtip.exe")
        '        bolTeclado = True
        '    Catch ex As Exception

        '    End Try

        'End If
    End Sub
    Private Sub txtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress
        intProtecao = 0
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarDocumento(Me.txtCPF, "Cpf")
    End Sub

    Private Sub txtCPF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPF.Leave
        If Me.txtCPF.Text.Trim = "" Then Exit Sub
        If PesquisarClienteTouch(txtCPF) = False Then
            Me.txtCPF.ResetText()
            Me.txtCPF.Focus()
            Me.lblMensagem.Text = "Já existe um Cliente cadastrado com esse CPF!"
            Timer1.Start()
            Exit Sub
        End If

        If ValidaCPFTouch(Me.txtCPF.Text.Trim) = False Then
            Me.lblMensagem.Text = "CPF Inválido!"
            Timer1.Start()
            Me.txtCPF.ResetText()
            Me.txtCPF.Focus()
            Exit Sub
        End If

        If Me.txtCPF.Text.Trim = "000.000.000-00" Or Me.txtCPF.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCPF.ResetText()
            Exit Sub
        End If

    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        intProtecao = 0
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.Leave
        If Me.txtEmail.Text <> "" Then
            If Me.txtEmail.Text.Contains("@") = False Then
                Me.lblMensagem.Text = "Email inválido!"
                Timer1.Start()
                Me.txtEmail.Focus()
            End If
            If Me.txtEmail.Text.ToUpper.Contains(".COM") = False Then
                Me.lblMensagem.Text = "Email inválido!"
                Timer1.Start()
                Me.txtEmail.Focus()
            End If
        End If
    End Sub
    Private Sub Limpar()
        Me.txtEmail.ResetText()
        Me.txtCPF.ResetText()
        Me.txtTelefone.ResetText()
        Me.txtNome.ResetText()
        Me.txtNome.Focus()
        Timer4.Start()
    End Sub

    Private Sub GerarCupomDesconto(ByVal parNome As String, ByVal parCPF As String)
        Dim rptDoc As New Desconto
        Dim TextObjects(38) As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim dtCliente As DataTable
        Dim dtConfig As DataTable
        Dim dtBarra As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("Produto")
        dt.Columns.Add("vProd")
        dt.Columns.Add("CodInterno")

        TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtRazaoEmitente")
        TextObjects(0).Text = NomeEmpresa

        TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtCliente")
        TextObjects(1).Text = parNome

        If IO.File.Exists(My.Application.Info.DirectoryPath & "\Cabecalho.txt") = True Then
            Dim strCabecalho As String = LerArquivo(My.Application.Info.DirectoryPath & "\Cabecalho.txt", True)
            If strCabecalho <> "" Then
                TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtTexto")
                TextObjects(2).Text = strCabecalho
            Else
                rptDoc.PageHeaderSection6.SectionFormat.EnableSuppress = True
            End If
        End If

        Dim I As Integer

        Dim dtProduto As DataTable = CarregarDataTable("SELECT Grupo, Nome, Desconto FROM Produto where Desconto > 0 and Inativo = 'False' order by Grupo, Desconto")

        Dim strGrupoGeral As String = ""
        Dim dblDescontoGeral As Double
        Dim strTexto As String = ""
        Dim A As Integer = 0
        If dtProduto.Rows.Count > 0 Then
            For I = 0 To dtProduto.Rows.Count - 1
                Dim strGrupo As String = dtProduto.Rows.Item(I).Item("Grupo").ToString
                Dim strProduto As String = dtProduto.Rows.Item(I).Item("Nome").ToString
                Dim dblDesconto As Double = dtProduto.Rows.Item(I).Item("Desconto").ToString.Replace(".", ",")

                If strGrupo <> strGrupoGeral Or dblDesconto <> dblDescontoGeral Then

                    If I > 0 Then
                        dt.Rows.Add()
                        dt.Rows.Item(A).Item("CodInterno") = strTexto
                        dt.Rows.Item(A).Item("Produto") = strGrupoGeral
                        dt.Rows.Item(A).Item("vProd") = dblDescontoGeral & " %"
                        strTexto = ""
                        A += 1
                    End If

                    strTexto = strProduto & vbCrLf
                    strGrupoGeral = strGrupo
                    dblDescontoGeral = dblDesconto
                Else
                    strTexto &= strProduto & vbCrLf
                End If
            Next

            dt.Rows.Add()
            dt.Rows.Item(A).Item("CodInterno") = strTexto
            dt.Rows.Item(A).Item("Produto") = strGrupoGeral
            dt.Rows.Item(A).Item("vProd") = dblDescontoGeral & " %"

        End If
        






        dtConfig = New DataTable
        Dim picLogo As New PictureBox
        picLogo.Size = New System.Drawing.Size(361, 104)
        picLogo.Image = System.Drawing.Bitmap.FromFile("C:\NANO\LOGO.png")
        If picLogo.Image Is Nothing = False Then
            dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
            dtConfig.Rows.Add()
            Dim bLogo As Byte() = converteimagem(picLogo.Image)
            dtConfig.Rows.Item(0).Item("Logo") = bLogo
        End If


        dtBarra = New DataTable
        dtBarra.Columns.Add(New DataColumn("PlanoFundo", GetType(Byte())))
        dtBarra.Rows.Add()
        Dim intImagem As New PictureBox
        intImagem.Size = New System.Drawing.Size(361, 104)
        parCPF = parCPF.Replace(".", "").Replace("-", "")
        Dim BarcodeChave As New BarcodeLib.Barcode(parCPF, BarcodeLib.TYPE.CODE128)
        intImagem.Image = BarcodeChave.Encode(BarcodeLib.TYPE.CODE128, parCPF, 300, 150)
        Dim imgChave As Byte() = converteimagem(intImagem.Image)
        dtBarra.Rows.Item(0).Item("PlanoFundo") = imgChave


        'Dim BarcodeChave As New BarcodeLib.Barcode(parCPF, BarcodeLib.TYPE.CODE128)
        'intImagem.Image = BarcodeChave.Encode(BarcodeLib.TYPE.CODE128, parCPF, 300, 150)
        'Dim imgChave As Byte() = converteimagem(intImagem.Image)
        'dtBarra.Rows.Item(0).Item("PlanoFundo") = imgChave

        dtConfig.TableName = "Config"
        dtBarra.TableName = "Usuario"
        'dtCliente.TableName = "Cliente"
        dt.TableName = "ItensNfe"
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        ds.Tables.Add(dtConfig)
        ds.Tables.Add(dtBarra)
        'ds.Tables.Add(dtCliente)
        rptDoc.SetDataSource(ds)




        'If ModeloImpSAT = "NORMAL" Then
        '    Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
        '    Try
        '        margins.bottomMargin = 350
        '        margins.leftMargin = 350
        '        margins.rightMargin = 350
        '        margins.topMargin = 350


        '        rptDoc.PrintOptions.ApplyPageMargins(margins)
        '    Catch ex As Exception

        '    End Try


        '    rptDoc.PrintOptions.PrinterName = NomeImpSAT
        '    rptDoc.PrintToPrinter(1, False, 0, 0)
        'ElseIf ModeloImpSAT = "TERMICA" Then
        Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
        Try
            margins.bottomMargin = 150
            margins.leftMargin = 220
            margins.rightMargin = 20
            margins.topMargin = 150


            rptDoc.PrintOptions.ApplyPageMargins(margins)
        Catch ex As Exception

        End Try
        rptDoc.PrintOptions.PrinterName = PortaImpressora
        rptDoc.PrintToPrinter(1, False, 0, 0)

        'ElseIf ModeloImpSAT = "TERMICA MARGEM" Then

        '    Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
        '    Try
        '        margins.bottomMargin = 150
        '        margins.leftMargin = 180
        '        margins.rightMargin = 50
        '        margins.topMargin = 150


        '        rptDoc.PrintOptions.ApplyPageMargins(margins)
        '    Catch ex As Exception

        '    End Try
        '    rptDoc.PrintOptions.PrinterName = NomeImpSAT
        '    rptDoc.PrintToPrinter(1, False, 0, 0)
        'End If
    End Sub

    Private Sub GerarCupom1()


        If IO.File.Exists(My.Application.Info.DirectoryPath & "\Cupom1.txt") = True Then
            Dim strTexto As String = LerArquivo(My.Application.Info.DirectoryPath & "\Cupom1.txt", True)
            If strTexto <> "" Then

                Dim rptDoc As New Cupom1
                Dim TextObjects(10) As CrystalDecisions.CrystalReports.Engine.TextObject

                Dim dtConfig As DataTable

                Dim vetTexto As Array = Split(strTexto, "|")
                If vetTexto.Length > 0 Then
                    TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtTitulo1")
                    TextObjects(0).Text = vetTexto(0).ToString.Trim
                End If

                If vetTexto.Length > 1 Then
                    TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtTexto1")
                    TextObjects(1).Text = vetTexto(1).ToString.Trim
                End If

                If vetTexto.Length > 2 Then
                    TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtTitulo2")
                    TextObjects(2).Text = vetTexto(2).ToString.Trim
                End If

                If vetTexto.Length > 3 Then
                    TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtSite")
                    TextObjects(3).Text = vetTexto(3).ToString.Trim
                End If

                If vetTexto.Length > 4 Then
                    TextObjects(4) = rptDoc.Section1.ReportObjects.Item("txtObs")
                    TextObjects(4).Text = vetTexto(4).ToString.Trim
                End If


                dtConfig = New DataTable
                Dim picLogo As New PictureBox
                picLogo.Size = New System.Drawing.Size(361, 104)
                picLogo.Image = System.Drawing.Bitmap.FromFile("C:\NANO\LOGO.png")
                If picLogo.Image Is Nothing = False Then
                    dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
                    dtConfig.Rows.Add()
                    Dim bLogo As Byte() = converteimagem(picLogo.Image)
                    dtConfig.Rows.Item(0).Item("Logo") = bLogo
                End If


                dtConfig.TableName = "Config"
                Dim ds As New DataSet
                ds.Tables.Add(dtConfig)
                rptDoc.SetDataSource(ds)

                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                Try
                    margins.bottomMargin = 150
                    margins.leftMargin = 220
                    margins.rightMargin = 20
                    margins.topMargin = 150


                    rptDoc.PrintOptions.ApplyPageMargins(margins)
                Catch ex As Exception

                End Try
                rptDoc.PrintOptions.PrinterName = PortaImpressora
                rptDoc.PrintToPrinter(1, False, 0, 0)
            End If
        End If




    End Sub


    Private Sub GerarCupom2(ByVal parNome As String, ByVal parCpf As String, ByVal parTelefone As String, ByVal parEmail As String)


        If IO.File.Exists(My.Application.Info.DirectoryPath & "\Cupom2.txt") = True Then
            Dim strTexto As String = LerArquivo(My.Application.Info.DirectoryPath & "\Cupom2.txt", True)
            If strTexto <> "" Then

                Dim rptDoc As New Cupom2
                Dim TextObjects(10) As CrystalDecisions.CrystalReports.Engine.TextObject

                Dim dtConfig As DataTable

                Dim vetTexto As Array = Split(strTexto, "|")
                If vetTexto.Length > 0 Then
                    TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtTitulo1")
                    TextObjects(0).Text = vetTexto(0).ToString.Trim
                End If

                If vetTexto.Length > 1 Then
                    TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtTexto1")
                    TextObjects(1).Text = vetTexto(1).ToString.Trim
                End If


                If vetTexto.Length > 2 Then
                    TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtObs")
                    TextObjects(2).Text = vetTexto(2).ToString.Trim
                End If

                TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtCliente")
                TextObjects(3).Text = "Nome: " & parNome
                TextObjects(4) = rptDoc.Section1.ReportObjects.Item("txtCpf")
                TextObjects(4).Text = "CPF: " & parCpf
                TextObjects(5) = rptDoc.Section1.ReportObjects.Item("txtTelefone")
                TextObjects(5).Text = "Telefone: " & parTelefone
                TextObjects(6) = rptDoc.Section1.ReportObjects.Item("txtEmail")
                TextObjects(6).Text = "Email: " & parEmail

                dtConfig = New DataTable
                Dim picLogo As New PictureBox
                picLogo.Size = New System.Drawing.Size(361, 104)
                picLogo.Image = System.Drawing.Bitmap.FromFile("C:\NANO\LOGO.png")
                If picLogo.Image Is Nothing = False Then
                    dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
                    dtConfig.Rows.Add()
                    Dim bLogo As Byte() = converteimagem(picLogo.Image)
                    dtConfig.Rows.Item(0).Item("Logo") = bLogo
                End If


                dtConfig.TableName = "Config"
                Dim ds As New DataSet
                ds.Tables.Add(dtConfig)
                rptDoc.SetDataSource(ds)

                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                Try
                    margins.bottomMargin = 150
                    margins.leftMargin = 220
                    margins.rightMargin = 20
                    margins.topMargin = 150


                    rptDoc.PrintOptions.ApplyPageMargins(margins)
                Catch ex As Exception

                End Try
                rptDoc.PrintOptions.PrinterName = PortaImpressora
                rptDoc.PrintToPrinter(1, False, 0, 0)
            End If
        End If




    End Sub
    Public Shared Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.txtNome.Text = "" Then
            Me.lblMensagem.Text = "Campo Nome é obrigatório!"
            Timer1.Start()
            Exit Sub
        End If
        If Me.txtCPF.Text = "" Then
            Me.lblMensagem.Text = "Campo CPF é obrigatório!"
            Timer1.Start()
            Exit Sub
        End If

        If Me.txtTelefone.Text = "" Then
            Me.lblMensagem.Text = "Campo Telefone é obrigatório!"
            Timer1.Start()
            Exit Sub
        End If
        If Me.txtEmail.Text = "" Then
            Me.lblMensagem.Text = "Campo E-mail é obrigatório!"
            Timer1.Start()
            Exit Sub
        End If


        If Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, " & _
        "Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, " & _
        "Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, " & _
        "Pessoa2, RG1, RG2, Inativo, TempoTrabalho, Moradia, NomeConjuge, TelConjuge, Suframa, CodMunicipio, " & _
        "CodPais, NomePais, Desconto, Agencia, ContaCorrente, Banco, Contato) VALUES ('" & Me.txtNome.Text.Trim & "'," & _
        "'','" & Me.txtCPF.Text.Trim & "',''," & _
        "'" & Me.txtTelefone.Text.Trim & "','',''," & _
        "'" & Me.txtEmail.Text.Trim & "','" & Date.Today & "',''," & _
        "'','',''," & _
        "'',''," & _
        "'','False',''," & _
        "'','',''," & _
        "'','',''," & _
        "'','',''," & _
        "" & CodConfig & ",'',''," & _
        "'','','False'," & _
        "'','',''," & _
        "'','',''," & _
        "'','',0," & _
        "'','',''," & _
        "'')") = True Then
            Me.lblMensagem.Text = "Cliente cadastrado com sucesso! Retire seu cupom."
            Timer1.Start()
            Dim strNome As String = Me.txtNome.Text
            Dim strCPF As String = Me.txtCPF.Text
            Dim strTelefone As String = Me.txtTelefone.Text
            Dim strEmail As String = Me.txtEmail.Text
            Limpar()

            GerarCupomDesconto(strNome, strCPF)
            GerarCupom1()
            GerarCupom2(strNome, strCPF, strTelefone, strEmail)

            intProtecao = 6
        End If
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
     
        Limpar()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        intCont += 1
        If intCont = 5 Then
            Me.lblMensagem.Text = ""
            intCont = 0
            Timer1.Stop()
        End If
    End Sub

    Private Shared Function PesquisarClienteTouch(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean
        Try
            Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Cliente where CPF = '" & parCampo.Text() & "'")
            If dt.Rows.Count > 0 Then
                Return False
                Exit Function
            End If
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Function ValidaCPFTouch(ByVal parCPF As String) As Boolean
        If parCPF.Trim = "" Then Return True
        Dim cpf1 As New clsValidar

        cpf1.cpf = parCPF

        If cpf1.isCpfValido() Then
            Return True
        Else
            Dim Cnpj1 As New clsValidar

            Cnpj1.cnpj = parCPF

            If Cnpj1.isCnpjValido() Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub btnTouch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTouch.Click
        AbrirTeclado()
    End Sub

    Private Sub frmClienteTouch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        intProtecao = 0
    End Sub

    Private Sub frmClienteTouch_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        intProtecao = 0
    End Sub
    Private Sub frmClienteTouch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        intProtecao = 0
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.picImagem.Visible = False Then
            intProtecao += 1
            If Me.txtNome.Text = "" Then
                If intProtecao >= 10 Then
                    If vetLista.Length > 0 Then
                        'Me.picImagem.Image = System.Drawing.Bitmap.FromFile(vetLista(vetLista.Length - 1))
                        Me.picImagem.ImageLocation = vetLista(vetLista.Length - 1)
                    End If

                    Me.picImagem.Dock = DockStyle.Fill
                    Me.picImagem.Visible = True
                    'Me.txtClique.Visible = True
                    intProtecao = 0
                     FecharTeclado()
                    'Me.SimpleButton1.Visible = True
                    Me.Timer3.Start()
                End If
            Else
                If intProtecao >= 45 Then
                    If vetLista.Length > 0 Then
                        'Me.picImagem.Image = System.Drawing.Bitmap.FromFile(vetLista(vetLista.Length - 1))
                        Me.picImagem.ImageLocation = vetLista(vetLista.Length - 1)
                    End If

                    Me.picImagem.Dock = DockStyle.Fill
                    Me.picImagem.Visible = True
                    'Me.txtClique.Visible = True
                    intProtecao = 0
                    FecharTeclado()
                    'Me.SimpleButton1.Visible = True
                    Me.Timer3.Start()
                End If
            End If
            
        End If
       
    End Sub
    Dim intImagem As Integer
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        'Me.SimpleButton1.Visible = True
        intImagem += 1
        If vetLista.Length > intImagem Then
            'picImagem.Image = System.Drawing.Bitmap.FromFile(vetLista(intImagem - 1))
            picImagem.ImageLocation = vetLista(intImagem - 1)
        Else
            intImagem = 0
        End If
    End Sub



    Private Sub CancelarProtecao()

        Timer3.Stop()
        intImagem = 0
        intProtecao = 0
        Me.picImagem.Visible = False
        'Me.txtClique.Visible = False
        FecharTeclado()
        Me.txtNome.Focus()
        AbrirTeclado()
    End Sub
    Private Sub FecharTeclado()
        'Try
        '    virtualKeyboard.kill()
        'Catch ex As Exception

        'End Try
        'Dim proc As Process
        'For Each proc In Process.GetProcesses
        '    Try
        '        If proc.ProcessName = "osk" Then
        '            Try
        '                proc.Kill()
        '                proc.Close()
        '            Catch ex As Exception

        '            End Try
        '        End If
        '    Catch ex As Exception

        '    End Try

        '    Try
        '        If proc.ProcessName = "TabTip" Then
        '            Try
        '                proc.Kill()
        '                proc.Close()
        '            Catch ex As Exception

        '            End Try
        '        End If
        '    Catch ex As Exception

        '    End Try

        'Next
        Dim iHwnd As IntPtr = FindWindow(vbNullString, "Teclado Virtual")
        ShowWindow(iHwnd, SW_SHOWMINIMIZED)
    End Sub
    Private Sub txtTelefone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefone.KeyPress
        intProtecao = 0

        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False

            If Me.txtTelefone.Text.Length = 14 Then
                txtTelefone.Text = txtTelefone.Text.Replace("-", "")
                'Dim strtr As String = txtTelefone.Text.Substring(8, 5)

                'Dim ttt As String = txtTelefone.Text.Substring(0, 8)
                'Dim strdd As String = txtTelefone.Text.Substring(0, 8) & "-" & txtTelefone.Text.Substring(8, 5)
                txtTelefone.Text = txtTelefone.Text.Substring(0, 8) & "-" & txtTelefone.Text.Substring(8, 5)
                txtTelefone.SelectionStart = 14

            End If
            Exit Sub
        End If

        txtTelefone.Properties.MaxLength = 14
        Select Case txtTelefone.Text.Length
            Case 0
                txtTelefone.Text = txtTelefone.Text & "("
                txtTelefone.SelectionStart = 1

            Case 3
                txtTelefone.Text = txtTelefone.Text & ")"
                txtTelefone.SelectionStart = 4
            Case 8
                txtTelefone.Text = txtTelefone.Text & "-"
                txtTelefone.SelectionStart = 9
            Case 13
                If txtTelefone.Text.Length > 12 Then
                    txtTelefone.Text = txtTelefone.Text.Replace("-", "")

                    txtTelefone.Text = txtTelefone.Text.Substring(0, 9) & "-" & txtTelefone.Text.Substring(9, 3)
                    txtTelefone.SelectionStart = 14
                End If

                'Case 10
                '    parDocumento.Text = parDocumento.Text & "/"
                '    parDocumento.SelectionStart = 11
                'Case 15
                '    parDocumento.Text = parDocumento.Text & "-"
                '    parDocumento.SelectionStart = 16
        End Select

    End Sub

    Private Sub txtNome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyDown, txtCPF.KeyDown, txtTelefone.KeyDown, txtEmail.KeyDown, btnLimpar.KeyDown, btnSalvar.KeyDown, btnTouch.KeyDown
        If e.KeyCode = Keys.Escape Then
            FecharTeclado()
            Me.Close()
        End If
    End Sub

    Private Sub txtNome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNome.KeyPress
        intProtecao = 0
    End Sub

    Private Sub txtClique_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        CancelarProtecao()
        Limpar()
    End Sub

    Private Sub picImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picImagem.Click
        CancelarProtecao()
        Limpar()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Me.txtNome.Focus()
        Timer4.Stop()
    End Sub
End Class