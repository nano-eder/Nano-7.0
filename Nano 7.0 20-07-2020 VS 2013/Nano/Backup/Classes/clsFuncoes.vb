Imports System
Imports System.Data
Imports System.Data.sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.File
Imports System.Collections.Generic
Imports System.Text
Imports System.Configuration
Imports System.Configuration.ConfigurationSettings
Imports System.Collections
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.Configuration.ConfigurationManager
Imports System.Drawing.Printing

Imports System.Data.OleDb
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Net.mail
Imports System.Net.Mime
Imports System.Threading
Imports Nano.clsFuncoesBematech
Imports Nano.clsImprimir
Imports System.IO.Compression

Imports System.Security
Imports System.Security.Cryptography

Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports System.Globalization

Public Class clsFuncoes

    Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name As String, ByVal hmod As Integer, ByVal flags As Integer) As Integer
    Public Const SND_SYNC = &H0 ' TOCANDO com sincronismo
    Public Const SND_ASYNC = &H1 ' TOCANDO sem sincronismo
    Public Const SND_FILENAME = &H20000
    Public Const SND_RESOURCE = &H40004

    Public Shared Function ExisteTabela(ByVal parTabela As String) As Boolean
        Dim tabela As New DataTable

        Dim criterioSQL As String

        criterioSQL = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_TYPE"
        Try

            Dim da As New SqlDataAdapter(criterioSQL, StringDeConexao)

            da.Fill(tabela)

            For Each dr As DataRow In tabela.Rows

                If dr("TABLE_NAME").ToString = parTabela Then

                    Return True

                End If

            Next

            Return False

        Catch ex As Exception

            MessageBox.Show("ERRO " & ex.Message, "Verifica tabela")

            Return False

        End Try
    End Function
    Public Shared Function GerarCodigoDav(ByVal parTabela As String, ByVal parCodConfig As Integer) As String
        Dim conexao As New SqlConnection(StringDeConexao)

        Dim strSql As String = ""
        Dim strcod As String = ""

        Try
            If parCodConfig = 0 Then
                strSql = "Select max(convert(integer,NumDav)) as NumDav From " & parTabela
            Else
                strSql = "Select max(convert(integer,NumDav)) as NumDav From " & parTabela & " where CodConfig =" & CodConfig
            End If

            Dim dt As DataTable = CarregarDataTable(strSql)

            If dt.Rows.Count > 0 Then
                strcod = dt.Rows.Item(0).Item("NumDav").ToString
            End If

            conexao.Close()
        Catch ex As Exception

        End Try
        Return Val(strcod) + 1
    End Function
    Public Shared Function PreencherCombo(ByVal parTabela As String, ByVal parCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal parNivel As Integer, ByVal Ordem As String) As Boolean

        TesteConexao()

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader

        Try
            conexao.open()
            sql = "SELECT * FROM " & parTabela & " order by " & Ordem
            cmd = New SqlCommand(sql, conexao)

            dr = cmd.ExecuteReader
            parCombo.Properties.Items.Add("")
            While dr.Read

                parCombo.Properties.Items.Add(dr(parNivel))

            End While

        Catch ex As Exception

        End Try
        conexao.close()
        Return True

    End Function

    Public Shared Function PreencherCombo2(ByVal parQuery As String, ByVal parCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal parNivel As Integer, ByVal parLinha As String) As Boolean
        TesteConexao()

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            conexao.open()

            cmd = New SqlCommand(parQuery, conexao)

            dr = cmd.ExecuteReader

            parCombo.Properties.Items.Add(parLinha)
            While dr.Read

                parCombo.Properties.Items.Add(dr(parNivel))

            End While
        Catch ex As Exception

        End Try
        conexao.close()
        Return True

    End Function

    Public Shared Function Somar(ByVal parSql As String) As String

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim strResul As String = 0
        Dim dr As SqlDataReader

        Try
            conexao.open()
            cmd = New SqlCommand(parSql, conexao)

            dr = cmd.ExecuteReader

            While dr.Read

                strResul = dr(0).ToString.Trim

            End While

            If strResul = "" Then
                strResul = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        conexao.close()
        Return strResul

    End Function

    Public Shared Function ValidaCPF(ByVal parCPF As String) As Boolean
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
                MsgBox("CPF ou CNPJ Inválido!", MsgBoxStyle.Information)
                Return False
            End If
        End If
    End Function

    Public Shared Function PreencherOrdenado(ByVal parTabela As String, ByVal parCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal parNivel As Integer, ByVal Order As String) As Boolean

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader

        Try

            conexao.open()
            sql = "SELECT * FROM " & parTabela & " order by " & Order
            cmd = New SqlCommand(sql, conexao)

            dr = cmd.ExecuteReader

            While dr.Read

                parCombo.Properties.Items.Add(dr(parNivel))

            End While

        Catch ex As Exception

        End Try
        conexao.close()
        Return True

    End Function

    Public Shared Function PreencherGrupoSetorCusto(ByVal parTipo As String, ByVal parCombo As DevExpress.XtraEditors.ComboBoxEdit, Optional ByVal parTipo2 As String = "") As Boolean

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader

        Try
            If parTipo2 <> "" Then
                parTipo2 = "or Tipo = '" & parTipo2 & "'"
            End If
            conexao.open()
            sql = "SELECT * FROM Grupo where Tipo ='" & parTipo & "' " & parTipo2 & " order by Nome"
            cmd = New SqlCommand(sql, conexao)

            dr = cmd.ExecuteReader
            parCombo.Properties.Items.Add("")
            While dr.Read

                parCombo.Properties.Items.Add(dr(1))

            End While

        Catch ex As Exception

        End Try
        conexao.close()
        Return True

    End Function

    Public Shared Function PreencherOrdenado2(ByVal parTabela As String, ByVal parCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox, ByVal parNivel As Integer, ByVal Order As String) As Boolean

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader

        Try

            conexao.open()
            sql = "SELECT * FROM " & parTabela & " order by " & Order
            cmd = New SqlCommand(sql, conexao)

            dr = cmd.ExecuteReader

            While dr.Read

                parCombo.Items.Add(dr(parNivel))

            End While

        Catch ex As Exception

        End Try
        conexao.close()
        Return True

    End Function

    Public Shared Function Validar(ByVal parComponente As Object) As Boolean
        Try
            If parComponente.text.trim = "" Then
                MsgBox("Campo " & parComponente.tag & " é obrigatório!", MsgBoxStyle.Information)
                parComponente.text = ""
                parComponente.focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

        End Try

    End Function

    Public Shared Function Deletar(ByVal parTabela As String, ByVal parChavPrimaria As String, ByVal parId As String, ByVal nomeGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal parIndex As Integer) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            conexao.open()
            sql = "DELETE FROM " & parTabela & " WHERE " & parChavPrimaria & " = '" & parId & "'"
            cmd = New SqlCommand(sql, conexao)
            cmd.ExecuteNonQuery()
            nomeGrid.DeleteRow(parIndex)
            cmd.UpdatedRowSource = UpdateRowSource.Both

            MsgBox("Exclusão concluída com sucesso!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        conexao.close()
        Return True

    End Function


    Public Shared Function Atualizar(ByVal strSQL As String) As Boolean

        Try
            If TesteConexao() = False Then Exit Function

            strSQL = "SET DATEFORMAT dmy " & strSQL

            Dim conexao = New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()

            Return True

        Catch ex As Exception

            If TelaErro(ex.Message, strSQL) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            End If

            If ComandoOK = True Then
                Return True
            Else
                Return False
            End If
        End Try

    End Function

    Public Shared Function InserirImagem(ByVal strSQL As String, ByVal parImagem As Byte()) As Boolean

        Try
            If TesteConexao() = False Then Exit Function

            strSQL = "SET DATEFORMAT dmy " & strSQL

            Dim conexao = New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)
            cmd.Parameters.Add("@Img", SqlDbType.Image).Value = parImagem
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()

            Return True

        Catch ex As Exception

            If TelaErro(ex.Message, strSQL) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            End If

            If ComandoOK = True Then
                Return True
            Else
                Return False
            End If
        End Try

    End Function
    Public Shared Function Excluir(ByVal strSQL As String) As Boolean
        Try

            If TesteConexao() = False Then Exit Function

            strSQL = "SET DATEFORMAT dmy " & strSQL

            Dim conexao = New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()
            Return True
        Catch ex As Exception
            If TelaErro(ex.Message, strSQL) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            End If

            If ComandoOK = True Then
                Return True
            Else
                Return False
            End If
        End Try
    End Function
    Public Sub IniciaThread()
        Dim mThread As New Threading.Thread(AddressOf EnviarEmail)
        'If mThread.IsAlive Then
        '    mThread.Abort()
        'End If
        mThread.Start()
    End Sub
    Private Sub EnviarEmail()

        Try

            Dim rel As New relMailErro
            rel.lblEmpresa.Text = NomeEmpresa
            rel.lblLoja.Text = DescricaoEmpresa
            rel.lblUsu.Text = UserNano
            rel.lblPc.Text = My.Computer.Name
            rel.lblContato.Text = TelefoneEmpresa
            rel.lblCid.Text = CidadeEmpresa
            rel.lblMsg.Text = MensagemDeErro
            rel.rtbStr.Text = StringSQLComErro
            rel.rtbMail.Rtf = MensagemEmailUsuario
            rel.lblData.Text = My.Computer.Clock.LocalTime


            Dim strEmail As String

            rel.ExportToHtml(My.Application.Info.DirectoryPath & "\Mail.html")
            strEmail = LerArquivo(My.Application.Info.DirectoryPath & "\Mail.html", False)

            enviaMensagemEmail("erasystems@ymail.com", "P@ssw0rd", "suporte@erasystems.com.br", "", "", NomeEmpresa, strEmail, "smtp.mail.yahoo.com", "0", False, "", "587", "Yahoo", Nothing)

        Catch ex As Exception

        End Try

    End Sub
    Public Shared Function Inserir(ByVal strSQL As String) As Boolean
        Try
            If TesteConexao() = False Then Exit Function

            strSQL = "SET DATEFORMAT dmy " & strSQL
            Dim conexao = New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()
            Return True
        Catch ex As Exception

            If TelaErro(ex.Message, strSQL) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            End If

            If ComandoOK = True Then
                Return True
            Else
                Return False
            End If

        End Try
    End Function



    Public Shared Function PesquisarCliente(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader
            Dim bolExiste As Boolean = False

            Sql = "Select * From Cliente Where CPF = '" & parCampo.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While

            If bolExiste = True Then
                MsgBox("Já existe um Cliente cadastrado com esse CPF/CNPJ!", MsgBoxStyle.Information)
                parCampo.ResetText()
                Return False
                parCampo.Focus()
            Else
                Return True
            End If

            conexao.Close()

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function PesquisarNF(ByVal parCampo As DevExpress.XtraEditors.TextEdit, ByVal parCodFor As Integer) As Boolean

        Dim bolExiste As Boolean = False
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader


            Sql = "Select Total From TotalEntradaNF Where NumeroNF = '" & parCampo.Text.Trim & "' and CodFor = " & parCodFor
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While

            If bolExiste = True Then
                MsgBox("Já existe uma Nota cadastrada com esse número para esse fornecedor!", MsgBoxStyle.Information)
                parCampo.ResetText()
                parCampo.Focus()
            End If

            conexao.Close()
        Catch ex As Exception

        End Try

        If bolExiste = False Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Shared Function PesquisarFuncionario(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader
            Dim bolExiste As Boolean = False

            Sql = "Select * From Funcionario Where CPF = '" & parCampo.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While

            If bolExiste = True Then
                MsgBox("Já existe um Funcionário cadastrado com esse CPF!", MsgBoxStyle.Information)
                parCampo.ResetText()
                parCampo.Focus()
                Return True
            Else
                Return False
            End If

            conexao.Close()
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function PesquisarFornecedor(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean

        If parCampo.Text.Trim = "" Then Return True

        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader
            Dim bolExiste As Boolean = False

            Sql = "Select * From Fornecedor Where CPF = '" & parCampo.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While

            If bolExiste = True Then
                MsgBox("Já existe um Fornecedor cadastrado com esse CPF/CNPJ!", MsgBoxStyle.Information)
                parCampo.ResetText()
                parCampo.Focus()
            End If

            conexao.Close()
        Catch ex As Exception

        End Try

        Return True

    End Function

    Public Shared Function PesquisarRepresentante(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean
        Dim bolExiste As Boolean = False
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader


            Sql = "Select * From Representante Where CPFFor = '" & parCampo.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While


            conexao.Close()
        Catch ex As Exception

        End Try

        Return bolExiste

    End Function

    Public Shared Function RetornarRepresentante(ByVal parCPFFor As String) As Array
        Dim vetDados(7) As String
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader


            Sql = "Select * From Representante Where CPFFor = '" & parCPFFor & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            Dim i As Integer
            While dr.Read

                For i = 0 To dr.FieldCount - 1
                    vetDados(i) = dr(i)
                Next

            End While


            conexao.Close()
        Catch ex As Exception

        End Try

        Return vetDados

    End Function

    Public Shared Function PesquisarProduto(ByVal parCampo As DevExpress.XtraEditors.TextEdit, ByVal parColuna As String) As Boolean
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader
            Dim bolExiste As Boolean = False

            Sql = "Select * From Produto Where " & parColuna & " = '" & parCampo.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While

            If bolExiste = True Then
                MsgBox("Código já cadastrado para outro Produto!", MsgBoxStyle.Information)
                parCampo.ResetText()
                parCampo.Focus()
            End If

            conexao.Close()
        Catch ex As Exception

        End Try

        Return True

    End Function

    Public Shared Function PesquisarReceita(ByVal parCampo As DevExpress.XtraEditors.TextEdit, ByVal parColuna As String) As Boolean
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader
            Dim bolExiste As Boolean = False

            Sql = "Select * From Receita Where " & parColuna & " = '" & parCampo.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While

            If bolExiste = True Then
                MsgBox("Código já cadastrado para outro Produto!", MsgBoxStyle.Information)
                parCampo.ResetText()
                parCampo.Focus()
            End If

            conexao.Close()
        Catch ex As Exception

        End Try

        Return True

    End Function
    Public Shared Function PesquisarUsuario(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean
        Dim conexao As New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim Sql As String
        Dim dr As SqlDataReader
        Dim bolExiste As Boolean = False

        Try
            Sql = "Select * From Usuario Where Login = '" & parCampo.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While

            conexao.Close()
        Catch ex As Exception

        End Try

        If bolExiste = True Then
            MsgBox("Login já cadastrado para outro Usuário!", MsgBoxStyle.Information)
            parCampo.ResetText()
            parCampo.Focus()
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function ValidarUsuario(ByVal parLogin As TextBox, ByVal parSenha As TextBox) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim Sql As String
        Dim dr As SqlDataReader
        Dim bolExiste As Boolean = False
        Dim bolInativo As Boolean = False
        Try
            Sql = "Select * From Usuario Where Login = '" & parLogin.Text.Trim & "' and Senha = '" & parSenha.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                CodUser = dr(0)
                Login = dr(1)
                UserNano = dr("Nome").ToString
                Nivel = dr(3).ToString
                Senha = dr(4).ToString
                CodConfig = dr("CodConfig").ToString
                bolInativo = dr("Inativo").ToString
                If dr(8).ToString <> "" Then
                    SkinDoUsuario = dr(8).ToString
                End If
                Dim dt As DataTable = CarregarDataTable("Select Descricao from Config where Codigo =" & CodConfig)
                If dt.Rows.Count > 0 Then
                    DescricaoEmpresa = dt.Rows.Item(0).Item("Descricao").ToString.Trim
                End If

                If Nivel.Trim = "MASTER" Then
                    Master = True
                End If
                bolExiste = True
                Exit While
            End While

            conexao.Close()
        Catch ex As Exception

        End Try

        If bolExiste = False Then
            MsgBox("Usuário ou Senha Inválido!", MsgBoxStyle.Information)
            parSenha.ResetText()
            parLogin.Focus()
            Return False
        Else
            If bolInativo = True Then
                MsgBox("Usuário Inativo!", MsgBoxStyle.Information)
                parSenha.ResetText()
                parLogin.Focus()
                Return False
            End If
            Return True
        End If

    End Function

    Public Shared Function GerarCodigo(ByVal parTabela As String, ByVal parChave As String, ByVal parCodConfig As Integer) As String
        Dim conexao As New SqlConnection(StringDeConexao)

        Dim strSql As String = ""
        Dim strcod As String = ""

        Try
            If parCodConfig = 0 Then
                strSql = "Select max(" & parChave & ") as " & parChave & " From " & parTabela
            Else
                strSql = "Select max(" & parChave & ") as " & parChave & " From " & parTabela & " where CodConfig =" & CodConfig
            End If

            Dim dt As DataTable = CarregarDataTable(strSql)

            If dt.Rows.Count > 0 Then
                strcod = dt.Rows.Item(0).Item(parChave).ToString
            End If

            conexao.Close()
        Catch ex As Exception

        End Try
        Return Val(strcod) + 1
    End Function

    Public Shared Function GerarCodigo2(ByVal parTabela As String, ByVal parChave As String, ByVal parCodConfig As Integer) As String
        Dim conexao As New OleDbConnection(My.Settings.MecanicaString)

        Dim strSql As String = ""
        Dim strcod As String = ""

        Try
            If parCodConfig = 0 Then
                strSql = "Select max(" & parChave & ") as " & parChave & " From " & parTabela
            Else
                strSql = "Select max(" & parChave & ") as " & parChave & " From " & parTabela & " where CodConfig =" & CodConfig
            End If

            Dim dt As DataTable = CarregarAccess(strSql)

            If dt.Rows.Count > 0 Then
                strcod = dt.Rows.Item(0).Item(parChave).ToString
            End If

            conexao.Close()
        Catch ex As Exception

        End Try
        Return Val(strcod) + 1
    End Function

    Public Shared Function GerarCodigoOrdens(ByVal parTabela As String, ByVal parCodConfig As Integer) As String
        Dim conexao As New SqlConnection(StringDeConexao)

        Dim strSql As String = ""
        Dim strcod As String = ""

        Try

            strSql = "Select max(Cod) as Cod From Ordens where Tabela ='" & parTabela & "' and CodConfig = " & CodConfig

            Dim dt As DataTable = CarregarDataTable(strSql)

            If dt.Rows.Count > 0 Then
                strcod = dt.Rows.Item(0).Item("Cod").ToString
            End If

            conexao.Close()
        Catch ex As Exception

        End Try
        Return Val(strcod) + 1
    End Function

    Public Shared Function GerarCodigoOrdensBanco(ByVal parTabela As String, ByVal parCodBanco As Integer) As String
        Dim conexao As New SqlConnection(StringDeConexao)

        Dim strSql As String = ""
        Dim strcod As String = ""

        Try

            strSql = "Select max(Cod) as Cod From Ordens where Tabela ='" & parTabela & "' and CodBanco = " & parCodBanco & " and CodConfig = " & CodConfig

            Dim dt As DataTable = CarregarDataTable(strSql)

            If dt.Rows.Count > 0 Then
                strcod = dt.Rows.Item(0).Item("Cod").ToString
            End If

            conexao.Close()
        Catch ex As Exception

        End Try
        Return Val(strcod) ' + 1
    End Function
    Public Shared Function GerarCodigoOrdensSat() As String
        Dim conexao As New SqlConnection(StringDeConexao)

        Dim strSql As String = ""
        Dim strcod As String = ""

        Try

            strSql = "Select max(Cod) as Cod From Ordens where Tabela ='Sat' and CodConfig = " & CodConfig & " and CodEmitente = " & CodConfigECF

            Dim dt As DataTable = CarregarDataTable(strSql)

            If dt.Rows.Count > 0 Then
                strcod = dt.Rows.Item(0).Item("Cod").ToString
            End If

            conexao.Close()
        Catch ex As Exception

        End Try
        Return Val(strcod) + 1
    End Function
    Public Shared Function PrecoECF(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean
        If parCampo.Text.Trim = "" Then Exit Function
        Try
            Dim dblVal As Double = parCampo.Text.Trim.Replace(".", ",")
           
            parCampo.Text = dblVal.ToString("0.00")

            Return True
        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            parCampo.ResetText()
            parCampo.Focus()
            Return False
        End Try
    End Function

    Public Shared Function Preco(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean
        If parCampo.Text.Trim = "" Then Exit Function
        Try
            Dim dblVal As Double = parCampo.Text.Trim.Replace(".", ",")
            'If resCasasDecimais = True Then
            '    parCampo.Text = dblVal.ToString("0.000")
            'Else
            '    parCampo.Text = dblVal.ToString("0.00")
            'End If
            Select Case CasaDecimal
                Case "2"
                    parCampo.Text = dblVal.ToString("0.00")
                Case "3"
                    parCampo.Text = dblVal.ToString("0.000")
                Case "4"
                    parCampo.Text = dblVal.ToString("0.0000")
                Case "5"
                    parCampo.Text = dblVal.ToString("0.00000")
                Case "6"
                    parCampo.Text = dblVal.ToString("0.000000")
                Case "7"
                    parCampo.Text = dblVal.ToString("0.0000000")
            End Select
            Return True
        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            parCampo.ResetText()
            parCampo.Focus()
            Return False
        End Try
    End Function


    Public Shared Function LerArquivo(ByVal parCaminhoArquivo As String, ByVal parMsg As Boolean) As String
        'Dim Arquivo As String

        'Arquivo = "c:\NANO\Texto.txt"

        'Dim fluxoTexto As IO.StreamReader
        'Dim Texto As String

        'If IO.File.Exists(Arquivo) Then

        '    fluxoTexto = New IO.StreamReader(Arquivo, System.Text.Encoding.Default)
        '    Texto = fluxoTexto.ReadToEnd

        '    LerArquivo = Split(Texto, "|")
        '    fluxoTexto.Close()

        'Else
        '    MessageBox.Show("Arquivo não existe")
        'End If

        'Return LerArquivo


        Dim fluxoTexto As IO.StreamReader
        Dim strTexto As String = ""

        If IO.File.Exists(parCaminhoArquivo) Then
            fluxoTexto = New IO.StreamReader(parCaminhoArquivo)
            strTexto = fluxoTexto.ReadToEnd
            fluxoTexto.Close()

        Else
            If parMsg = True Then
                MessageBox.Show("Arquivo " & parCaminhoArquivo & " não existe")
            End If
        End If

        Return strTexto
    End Function

    Public Shared Function LerArquivoDuplicata() As Array
        Dim Arquivo As String
        LerArquivoDuplicata = Nothing
        Arquivo = "C:\NANO\Duplicata.txt"

        Dim fluxoTexto As IO.StreamReader
        Dim Texto As String

        If IO.File.Exists(Arquivo) Then

            fluxoTexto = New IO.StreamReader(Arquivo, System.Text.Encoding.Default)
            Texto = fluxoTexto.ReadToEnd

            LerArquivoDuplicata = Split(Texto, "|")
            fluxoTexto.Close()

        Else
            MessageBox.Show("Arquivo não existe")
        End If

        Return LerArquivoDuplicata
    End Function

    Public Shared Function CarregarPedido(ByVal parTabela As String, ByVal parCampo As String, ByVal parChavePrim As String, ByVal parGrid As DevExpress.XtraGrid.GridControl) As Boolean
        Dim conexao As New SqlConnection(StringDeConexao)

        Dim da As SqlDataAdapter
        Dim dt As DataTable


        da = New SqlDataAdapter("Select * From " & parTabela & " Where " & parCampo & "= '" & parChavePrim & "'", conexao)

        dt = New DataTable
        da.Fill(dt)

        parGrid.DataSource = dt.DefaultView

        Return CarregarPedido

    End Function



    Public Shared Function CarregarDados(ByVal parCmdSql As String, ByVal parGrid As DevExpress.XtraGrid.GridControl) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable
        Try
            da.Fill(dt)
            parGrid.DataSource = dt.DefaultView
        Catch ex As Exception

            If TelaErro(ex.Message, parCmdSql) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            Else
                If NovoComandoSQL <> Nothing Then
                    da = New SqlDataAdapter(NovoComandoSQL, conexao)
                    dt = New DataTable
                    da.Fill(dt)
                End If
            End If
        End Try

        Return True

    End Function
    Public Shared Function CarregarDadosPedidoMDI(ByVal parCmdSql As String, ByVal parGrid As DevExpress.XtraGrid.GridControl) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable
        Try
            da.Fill(dt)
            parGrid.DataSource = dt.DefaultView
        Catch ex As Exception


        End Try

        Return True

    End Function
    Public Shared Function CarregarAccess(ByVal parCmdSql As String) As DataTable
        Dim conexao As New OleDbConnection(My.Settings.MecanicaString)

        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim vetDados As New ArrayList


        da = New OleDbDataAdapter(parCmdSql, conexao)

        dt = New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            MensagemDeErro = ex.Message & vbCrLf & "Query: " & parCmdSql

            Dim Erro As New clsFuncoes
            Erro.IniciaThread()
        End Try

        Return dt

    End Function

    Public Shared Function CarregarOutroBD(ByVal parCmdSql As String) As DataTable
        Dim conexao As New SqlConnection("Data Source=SERVER;Initial Catalog=dbLoja1;Persist Security Info=True;User ID=sa;Password=ed3223")
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception

            If TelaErro(ex.Message, parCmdSql) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            Else

                If NovoComandoSQL <> Nothing Then
                    da = New SqlDataAdapter(NovoComandoSQL, conexao)
                    dt = New DataTable
                    da.Fill(dt)
                End If

            End If

        End Try

        Return dt

    End Function

    Public Shared Function CarregarDataTable(ByVal parCmdSql As String) As DataTable
        Dim strVerificarBanco As String = ""
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\VerificarBanco.txt") = True Then
            strVerificarBanco = LerArquivo(My.Application.Info.DirectoryPath & "\VerificarBanco.txt", False)
        End If
        If strVerificarBanco <> "NÃO" Then
            If TesteConexao() = False Then Return Nothing : Exit Function
        End If
       
        Dim conexao As New SqlConnection(StringDeConexao)
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception

            If TelaErro(ex.Message, parCmdSql) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            Else

                If NovoComandoSQL <> Nothing Then
                    da = New SqlDataAdapter(NovoComandoSQL, conexao)
                    dt = New DataTable
                    da.Fill(dt)
                End If

            End If

        End Try

        Return dt

    End Function


    Public Shared Function CarregarDataTableGrafico(ByVal parCmdSql As String) As DataTable

        If TesteConexao() = False Then Return Nothing : Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception



        End Try

        Return dt

    End Function

    Public Shared Function TelaErro(ByVal parMsgErro As String, ByVal parSQl As String) As Boolean
        StringSQLComErro = parSQl
        ComandoOK = False
        frmErro.bolMail = False
        frmErro.btnDetails.Visible = False
        frmErro.grpTetalhe.Visible = False
        frmErro.txtMsg.Text = parMsgErro
        frmErro.txtDetalhes.Text = parSQl
        frmErro.intOrdemVenda = frmVenda.intOrdem
        frmErro.ShowDialog()
        Return frmErro.bolMail
    End Function

    Public Shared Function CarregarDadosLue(ByVal parCmdSql As String, ByVal parLue As DevExpress.XtraEditors.LookUpEdit) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)

        Dim da As SqlDataAdapter
        Dim dt As DataTable


        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception

        End Try


        parLue.Properties.DataSource = dt.DefaultView

        Return True

    End Function

    Public Shared Function RetornaFunc(ByVal parCod As String) As String

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim strDados As String = ""

        Try
            conexao.open()
            sql = "SELECT Nome, PorcComissao From Funcionario where Codigo =" & parCod
            cmd = New SqlCommand(sql, conexao)

            dr = cmd.ExecuteReader

            While dr.Read
                strDados = dr(0) & "|"
                strDados &= dr(1) & "|"
            End While

        Catch ex As Exception

        End Try
        conexao.close()
        Return strDados

    End Function


    Public Shared Function RetRec(ByVal parSql As String) As Array

        Dim conexao = New SqlConnection(StringDeConexao)
        Dim cmd As SqlCommand
        Dim strResul(10) As String
        Dim dr As SqlDataReader

        Try
            conexao.open()
            cmd = New SqlCommand(parSql, conexao)

            dr = cmd.ExecuteReader
            Dim I As Integer = 0
            While dr.Read
                Dim dblVal As Double

                dblVal = dr(2)
                strResul(I) = dr(0) & " R$ " & dblVal.ToString("0.00") : I += 1


            End While

        Catch ex As Exception

        End Try
        conexao.close()
        Return strResul

    End Function
    Public Shared Function DirCorte(ByVal Conteudo As String, ByVal Tamanho As String) As String
        If Conteudo.Length > Tamanho Then
            Return Conteudo.Substring(0, Tamanho)
        Else
            Return Dir(Conteudo, Tamanho)
        End If
    End Function
    Public Shared Function Dir(ByVal Conteudo As String, ByVal Tamanho As String) As String
        Dir = InsCaracter(Conteudo, " ", Tamanho, 1)
    End Function

    Public Shared Function Esq(ByVal Conteudo As String, ByVal Tamanho As String) As String
        Esq = InsCaracter(Conteudo, " ", Tamanho, 0)
    End Function

    Public Shared Function InsCaracter(ByVal parCampo As String, ByVal parCaracter As String, ByVal parTamanho As Integer, Optional ByVal parPosicao As Integer = 0) As String
        Dim Ret As String = ""
        Dim I As Integer

        If parTamanho = 0 Then Return ""
        If parTamanho - Len(parCampo) < 1 Then Return parCampo

        For I = 1 To parTamanho - Len(parCampo)
            Ret = Ret & parCaracter
        Next I

        If parPosicao = 0 Then
            Ret = Ret & parCampo
        Else
            Ret = parCampo & Ret
        End If

        Return Ret
    End Function
    Public Shared Function InserirPonto(ByVal Conteudo As String) As String
        Dim len As Integer
        Dim dblLen As Double
        Dim strPonto As String = "."
        Dim Ret As String = ""
        len = Conteudo.Length
        dblLen = 11 - len
        Dim i As Integer
        For i = 0 To dblLen - 1
            Ret = Ret & strPonto
        Next
        Ret = Ret & ": "
        Ret = Conteudo & Ret
        Ret = Ret.ToLower
        Dim primeira As Char = Char.ToUpper(Ret(0))
        Ret = primeira + Ret.Substring(1)
        Return Ret
    End Function

    Public Function NumeroToExtenso(ByVal number As Decimal) As String
        Dim cent As Integer
        Try
            ' se for =0 retorna 0 reais
            If number = 0 Then
                Return "Zero Reais"
            End If
            ' Verifica a parte decimal, ou seja, os centavos
            cent = Decimal.Round((number - Int(number)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            number = Int(number)
            ' Caso existam centavos
            If cent > 0 Then
                ' Caso seja 1 não coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real e " + getDecimal(cent) + "centavos"
                    ' Caso o valor seja inferior a 1 Real
                ElseIf number = 0 Then
                    Return getDecimal(cent) + "centavos"
                Else
                    Return getInteger(number) + "Reais e " + getDecimal(cent) + "centavos"
                End If
            Else
                ' Caso seja 1 não coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real"
                Else
                    Return getInteger(number) + "Reais"
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Função auxiliar - Parte decimal a converter
    ''' </summary>
    ''' <param name="number">Parte decimal a converter</param>
    Public Function getDecimal(ByVal number As Byte) As String
        Try
            Select Case number
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String = _
                       {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis", _
                        "Sete", "Oito", "Nove", "Dez", "Onze", _
                        "Doze", "Treze", "Quatorze", "Quinze", _
                        "Dezesseis", "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(number - 1) + " "
                Case 20 To 99
                    Dim strArray() As String = _
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta", _
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2) + " "
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getDecimal(number Mod 10) + " "
                    End If
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Função auxiliar - Parte inteira a converter
    ''' </summary>
    ''' <param name="number">Parte inteira a converter</param>
    Public Shared Function getInteger(ByVal number As Decimal) As String
        Try
            number = Int(number)
            Select Case number
                Case Is < 0
                    Return "-" & getInteger(-number)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String = _
                        {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis", _
                        "Sete", "Oito", "Nove", "Dez", "Onze", "Doze", _
                        "Treze", "Quatorze", "Quinze", "Dezesseis", _
                        "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(number - 1) + " "
                Case 20 To 99
                    Dim strArray() As String = _
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta", _
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getInteger(number Mod 10)
                    End If
                Case 100
                    Return "Cem"
                Case 101 To 999
                    Dim strArray() As String = _
                           {"Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", _
                           "Seiscentos", "Setecentos", "Oitocentos", "Novecentos"}
                    If (number Mod 100) = 0 Then
                        Return strArray(number \ 100 - 1) + " "
                    Else
                        Return strArray(number \ 100 - 1) + " e " + getInteger(number Mod 100)
                    End If
                Case 1000 To 1999
                    Select Case (number Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return "Mil e " + getInteger(number Mod 1000)
                        Case Else
                            Return "Mil, " + getInteger(number Mod 1000)
                    End Select
                Case 2000 To 999999
                    Select Case (number Mod 1000)
                        Case 0
                            Return getInteger(number \ 1000) & "Mil"
                        Case Is <= 100
                            Return getInteger(number \ 1000) & "Mil e " & getInteger(number Mod 1000)
                        Case Else
                            Return getInteger(number \ 1000) & "Mil, " & getInteger(number Mod 1000)
                    End Select
                Case 1000000 To 1999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return "Um Milhão"
                        Case Is <= 100
                            Return getInteger(number \ 1000000) + "Milhão e " & getInteger(number Mod 1000000)
                        Case Else
                            Return getInteger(number \ 1000000) + "Milhão, " & getInteger(number Mod 1000000)
                    End Select
                Case 2000000 To 999999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return getInteger(number \ 1000000) + " Milhões"
                        Case Is <= 100
                            Return getInteger(number \ 1000000) + "Milhões e " & getInteger(number Mod 1000000)
                        Case Else
                            Return getInteger(number \ 1000000) + "Milhões, " & getInteger(number Mod 1000000)
                    End Select
                Case 1000000000 To 1999999999
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return "Um Bilhão"
                        Case Is <= 100
                            Return getInteger(number \ 1000000000) + "Bilhão e " + getInteger(number Mod 1000000000)
                        Case Else
                            Return getInteger(number \ 1000000000) + "Bilhão, " + getInteger(number Mod 1000000000)
                    End Select
                Case Else
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return getInteger(number \ 1000000000) + " Bilhões"
                        Case Is <= 100
                            Return getInteger(number \ 1000000000) + "Bilhões e " + getInteger(number Mod 1000000000)
                        Case Else
                            Return getInteger(number \ 1000000000) + "Bilhões, " + getInteger(number Mod 1000000000)
                    End Select
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Shared Function BuscaCep2(ByVal cep As String) As Hashtable
        If cep.Trim = "" Then Return (Nothing)
        Dim ds As DataSet
        Dim _resultado As String
        Dim ht As System.Collections.Hashtable = Nothing
        Try
            ds = New DataSet()
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.Replace("-", "").Trim() + "&formato=xml")
            If Not IsNothing(ds) Then
                If (ds.Tables(0).Rows.Count > 0) Then
                    _resultado = ds.Tables(0).Rows(0).Item("resultado").ToString()
                    ht = New Hashtable
                    Select Case _resultado
                        Case ("1")
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("bairro", ds.Tables(0).Rows(0).Item("bairro").ToString().Trim())
                            ht.Add("tipologradouro", ds.Tables(0).Rows(0).Item("tipo_logradouro").ToString().Trim())
                            ht.Add("logradouro", ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim())
                            ht.Add("tipo", 1)

                        Case ("2")
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("tipo", 2)
                        Case Else
                            ht.Add("tipo", 0)
                    End Select
                End If
            End If
            Return (ht)
        Catch ex As Exception
            MsgBox("Falha ao buscar o cep!" & vbCrLf & ex.ToString)
            Return (Nothing)
        End Try
    End Function

    Public Shared Function BuscaCep(ByVal cep As String) As Hashtable
        If cep.Trim = "" Then Return (Nothing)
        Dim ds As DataSet

        Dim ht As System.Collections.Hashtable = Nothing
        Try
            ds = New DataSet()
            ds.ReadXml("http://cep.paicon.com.br/xml/" + cep.Replace("-", "").Replace(".", "").Trim())
            If Not IsNothing(ds) Then
                If (ds.Tables(0).Rows.Count > 0) Then
                    ht = New Hashtable

                    ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                    ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                    ht.Add("bairro", ds.Tables(0).Rows(0).Item("bairro").ToString().Trim())
                    ht.Add("tipologradouro", ds.Tables(0).Rows(0).Item("tipoLogradouro").ToString().Trim())
                    ht.Add("logradouro", ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim())
                End If
            End If
            Return (ht)
        Catch ex As Exception

            Return (Nothing)
        End Try
    End Function
    Public Shared Function FormatarDocumento(ByVal parDocumento As Object, ByVal parTipoDocumento As String)
        Select Case parTipoDocumento
            Case "Cnpj"
                parDocumento.Properties.MaxLength = 18
                Select Case parDocumento.Text.Length

                    Case 2
                        parDocumento.Text = parDocumento.Text & "."
                        parDocumento.SelectionStart = 3

                    Case 6
                        parDocumento.Text = parDocumento.Text & "."
                        parDocumento.SelectionStart = 7
                    Case 10
                        parDocumento.Text = parDocumento.Text & "/"
                        parDocumento.SelectionStart = 11
                    Case 15
                        parDocumento.Text = parDocumento.Text & "-"
                        parDocumento.SelectionStart = 16
                End Select
            Case "Cpf"
                parDocumento.Properties.MaxLength = 14
                Select Case parDocumento.Text.Length

                    Case 3
                        parDocumento.Text = parDocumento.Text & "."
                        parDocumento.SelectionStart = 4

                    Case 7
                        parDocumento.Text = parDocumento.Text & "."
                        parDocumento.SelectionStart = 8
                    Case 11
                        parDocumento.Text = parDocumento.Text & "-"
                        parDocumento.SelectionStart = 12

                End Select

        End Select

        Return parDocumento
    End Function

    Public Shared Function FormatarDocumentoString(ByVal parDocumento As String, ByVal parTipoDocumento As String) As String

        Dim strDoc As String = ""

        Select Case parTipoDocumento

            Case "Cnpj"

                If parDocumento.Length = 14 Then
                    strDoc = parDocumento.Substring(0, 2) & "." & parDocumento.Substring(2, 3) & "." & parDocumento.Substring(5, 3) & "/" & parDocumento.Substring(8, 4) & "-" & parDocumento.Substring(12, 2)
                End If

            Case "Cpf"
                If parDocumento.Length = 11 Then
                    strDoc = parDocumento.Substring(0, 3) & "." & parDocumento.Substring(3, 3) & "." & parDocumento.Substring(6, 3) & "-" & parDocumento.Substring(9, 2)
                End If

        End Select

        Return strDoc
    End Function

    Public Shared Function FormatarCep(ByVal parCep As Object)
        Select Case parCep.Text.Length

            Case 2
                parCep.Text = parCep.Text & "."
                parCep.SelectionStart = 3

            Case 6
                parCep.Text = parCep.Text & "-"
                parCep.SelectionStart = 7
        End Select
        Return parCep
    End Function
    Public Shared Function Existe(ByVal parColuna As String, ByVal parTabela As String, ByVal parChave As String, ByVal parParametro As String, ByVal parNumerico As Boolean) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)
        Dim strQuery As String = ""

        If parNumerico = False Then
            strQuery = "SELECT " & parColuna & " FROM " & parTabela & " where " & parChave & " = '" & parParametro & "'"
        Else
            strQuery = "SELECT " & parColuna & " FROM " & parTabela & " where " & parChave & " = " & parParametro
        End If
        conexao.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand(strQuery, conexao)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Dim bolExiste As Boolean = False
        While dr.Read
            bolExiste = True
            Exit While
        End While
        conexao.Close()
        Return bolExiste
    End Function

    Public Shared Function EscreveArquivo(ByVal parPath As String, ByVal parTexto As String) As Boolean
        Try

            Dim Escritor As StreamWriter

            Try
                System.IO.File.Delete(parPath)
            Catch ex As Exception

            End Try

            Escritor = New StreamWriter(New FileStream(parPath, FileMode.Create), System.Text.Encoding.Default)
            Escritor.Write(parTexto)
            Escritor.Close()


            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Public Shared Function Encryp(ByVal parTexto As String)

        Dim b() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(parTexto)

        Dim encryptedPwd As String = Convert.ToBase64String(b)

        Return encryptedPwd

    End Function

    'Método que descriptografa a senha

    Public Shared Function Decrypt(ByVal parTexto As String)

        Dim b() As Byte = Convert.FromBase64String(parTexto)

        Dim decryptedPwd As String = System.Text.ASCIIEncoding.ASCII.GetString(b)

        Return decryptedPwd

    End Function


    Public Shared Function SenhaEstaOK() As Boolean


        Dim frm As New frmSenhaExcluir
        bolSenhaOK = False
        frm.ShowDialog()

        Return bolSenhaOK
    End Function

    Public Shared Function ImpressoraOK() As Boolean

        Try
            Dim iRetorno As Short

            iRetorno = eDefinirProduto_Daruma("DUAL")

            iRetorno = rStatusImpressora_DUAL_DarumaFramework()

            If (iRetorno = 1) Then

                Select Case (iRetorno)

                    Case CInt("0") : MsgBox("Impressora desligada!", MsgBoxStyle.Information) : Return False
                    Case CInt("1") : Return True
                    Case CInt("-27") : MsgBox("Erro generico", MsgBoxStyle.Information) : Return False
                    Case CInt("-50") : MsgBox("Impressora OFFLINE!", MsgBoxStyle.Information) : Return False
                    Case CInt("-51") : MsgBox("Impressora sem papel!", MsgBoxStyle.Information) : Return False
                    Case CInt("-52") : MsgBox("Impressora inicializando!", MsgBoxStyle.Information) : Return False

                End Select

            Else
                MsgBox("Retorno inesperado da impressora!", MsgBoxStyle.Information) : Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)

        End Try



    End Function


    Public Shared Function InserirImagem(ByVal parImagem As Image, ByVal parExibicao As String, ByVal parPadrao As Boolean, ByVal parLogin As String, ByVal parSenha As String) As Boolean

        Dim MySQL As String = "UPDATE Usuario SET PlanoFundo = @PlanoFundo, Exibicao = @Exibicao, FundoPadrao = @FundoPadrao WHERE Login = @Login and Senha = @Senha"

        Dim strConn As New String("")
        strConn = ConfigurationManager.ConnectionStrings(StringDeConexao).ConnectionString
        Dim myConn As SqlConnection = New SqlConnection(strConn)
        Dim TheCommand As SqlCommand = New SqlCommand(MySQL, myConn)


        TheCommand.Parameters.AddWithValue("@PlanoFundo", parImagem)
        TheCommand.Parameters.AddWithValue("@Exibicao", parExibicao)
        TheCommand.Parameters.AddWithValue("@FundoPadrao", parPadrao)
        TheCommand.Parameters.AddWithValue("@Login", parLogin)
        TheCommand.Parameters.AddWithValue("@Senha", parSenha)

        myConn.Open()
        TheCommand.ExecuteNonQuery()
        myConn.Close()

        'cmd.Connection = conexao

        'param = New sql.sqlParameter
        'param.ParameterName = "@PlanoFundo"
        'param.sqlType = sqlType.VarChar
        'param.Value = parImagem
        'cmd.Parameters.Add(param)


        'param = New sql.sqlParameter
        'param.ParameterName = "@Exibicao"
        'param.sqlType = sqlType.VarChar
        'param.Value = parExibicao
        'cmd.Parameters.Add(param)

        'param = New sql.sqlParameter
        'param.ParameterName = "@FundoPadrao"
        'param.sqlType = sqlType.Boolean
        'param.Value = parPadrao
        'cmd.Parameters.Add(param)

        'param = New sql.sqlParameter
        'param.ParameterName = "@Login"
        'param.sqlType = sqlType.VarChar
        'param.Value = parLogin
        'cmd.Parameters.Add(param)

        'param = New sql.sqlParameter
        'param.ParameterName = "@Senha"
        'param.sqlType = sqlType.VarChar
        'param.Value = parSenha
        'cmd.Parameters.Add(param)


        'conexao.open()

        'cmd.ExecuteNonQuery()
    End Function

    Public Shared Function CarregarDadosLue2(ByVal parCmdSql As String, ByVal parLue As Object) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)

        Dim da As SqlDataAdapter
        Dim dt As DataTable


        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception

        End Try


        parLue.DataSource = dt.DefaultView

        Return True

    End Function

    Public Shared Function CarregarDadosLue3(ByVal parCmdSql As String, ByVal parLue As Object) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)

        Dim da As SqlDataAdapter
        Dim dt As DataTable


        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception

        End Try


        parLue.Edit.DataSource = dt.DefaultView

        Return True

    End Function
    Public Shared Function Cent(ByVal Conteudo As String, ByVal Tamanho As String) As String
        Dim len As Integer
        Dim dblLen As Double
        Dim dblAre As Double
        Dim dblResul As Double
        Dim strEsp As String = " "
        Dim Ret As String = ""
        len = Conteudo.Length
        dblLen = Tamanho - len
        dblLen = dblLen / 2

        dblAre = dblLen.ToString("0")
        dblResul = dblAre - dblLen
        If dblResul > 0 Then
            dblAre = dblLen - 0.5
        End If
        Dim i As Integer
        For i = 0 To dblAre - 1
            Ret = Ret & strEsp
        Next
        Ret = Ret & Conteudo
        Return Ret
    End Function
    Public Shared Function Num(ByVal parCampo As String) As String

        If parCampo = "" Then
            parCampo = "0,00"
        End If

        parCampo = parCampo.Trim.Replace(",", ".")

        Return parCampo
    End Function
    Public Shared Function BackupSql(ByVal strSQL As String, ByVal bolBackup As Boolean) As Boolean
        Dim strConexao As String = StringDeConexao
        If bolBackup = False Then
            strConexao = strConexao.Replace(NomeDoBancoSql, "dbBackup")
        End If

        Dim conexao = New SqlConnection(strConexao)
        Try

            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()

            Return True
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)
            conexao.close()
            Return False

        End Try

    End Function
    Public Shared Function CriarBancoSQL(ByVal strSQL As String) As Boolean

        Try
            Dim conexao = New SqlConnection(StringDeConexao.Replace(NomeDoBancoSql, "Master"))
            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()

            Return True
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function
    Public Shared Function ExisteBanco() As Boolean
        Dim conexao As New SqlConnection(StringDeConexao.Replace(NomeDoBancoSql, "Master"))
        conexao.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("SELECT * FROM SYSDATABASES where Name = '" & NomeDoBancoSql & "'", conexao)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Dim bolExiste As Boolean = False
        While dr.Read
            bolExiste = True
            Exit While
        End While
        conexao.Close()
        Return bolExiste
    End Function

    Public Shared Function VerificaBanco(ByRef parMensagem As String) As Boolean
        Dim conexao As New SqlConnection(StringDeConexao.Replace(NomeDoBancoSql, "Master"))
        Try
            conexao.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT * FROM SYSDATABASES where Name = '" & NomeDoBancoSql & "'", conexao)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            Dim bolExiste As Boolean = False
            While dr.Read
                bolExiste = True
                Exit While
            End While

            conexao.Close()
            Return bolExiste
        Catch ex As Exception
            conexao.Close()
            parMensagem = ex.Message
            Return False
        End Try

    End Function
    Public Shared Function CarregarDadosPesquisa(ByVal parCmdSql As String, ByVal parGrid As DevExpress.XtraGrid.GridControl, ByVal bolConexao As Boolean) As Boolean
        Dim strCon As String = StringDeConexao
        If bolConexao = False Then
            strCon = strCon.Replace(NomeDoBancoSql, "dbBackup")
        End If
        Dim conexao As New SqlConnection(strCon)
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable
        da.Fill(dt)

        parGrid.DataSource = dt.DefaultView

        Return True

    End Function
    Public Shared Function CarregarDataTable2(ByVal parCmdSql As String, ByVal parBanco As String) As DataTable

        If TesteConexao() = False Then Return Nothing : Exit Function

        Dim strCon As String = StringDeConexao.Replace(NomeDoBancoSql, parBanco)
        Dim conexao As New SqlConnection(strCon)
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception

            If TelaErro(ex.Message, parCmdSql) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            Else

                If NovoComandoSQL <> Nothing Then
                    da = New SqlDataAdapter(NovoComandoSQL, conexao)
                    dt = New DataTable
                    da.Fill(dt)
                End If

            End If

        End Try

        Return dt

    End Function
    Public Shared Function InserirAccess(ByVal strSQL As String) As Boolean

        Try
            Dim conexao = New OleDbConnection(My.Settings.MecanicaString)
            Dim cmd As OleDbCommand
            conexao.open()
            cmd = New OleDbCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()

            Return True

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function

    Public Shared Function ImprimiArquivo(ByVal parConteudo As String, ByVal parPortaImpressora As String) As Boolean
        Try
            EscreveArquivo(My.Application.Info.DirectoryPath & "\Cupom.prn", parConteudo)
            System.IO.File.Copy(My.Application.Info.DirectoryPath & "\Cupom.prn", parPortaImpressora, True)

            Dim strImpressao As String

            If TemGuilhotina = True Then
                strImpressao = clsImprimir.Avanco() & vbCrLf
                strImpressao &= clsImprimir.Corte()

                clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
            End If

            If TemGaveta = True Then
                strImpressao = clsImprimir.AbreGaveta() & vbCrLf
                clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Function

    Public Shared Function ImprimeArquivo(ByVal parPath As String, ByVal parTexto As String) As Boolean
        Try

            Dim Escritor As StreamWriter

            Escritor = New StreamWriter(New FileStream(parPath, FileMode.Create), System.Text.Encoding.Default)
            Escritor.Write(parTexto)
            Escritor.Close()

            Dim info As New ProcessStartInfo()

            'If PortaImpressora.Trim <> "" Then
            '    info.Verb = "PrintTo"
            '    info.Arguments = PortaImpressora
            'Else
            info.Verb = "Print"
            'End If

            info.FileName = parPath
            info.CreateNoWindow = False
            info.WindowStyle = ProcessWindowStyle.Hidden

            Dim proc As Process = New Process()

            proc.StartInfo = info

            proc.Start()

            'Imprime(parPath)


            Try
                proc.WaitForInputIdle()
                System.Threading.Thread.Sleep(3000)
                If False = proc.CloseMainWindow() Then
                    proc.Kill()
                End If
            Catch ex As Exception

            End Try

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Public Shared Function Imprime(ByVal parArquivo As String) As Boolean
        SendFileToPrinter("Bema", parArquivo)
    End Function


    Public Shared Function AbreGaveta() As Boolean
        If TemGaveta = True Then
            If PafEcfNano = False Then
                If Impressora = "DARUMA" Then
                    iRetorno = (iImprimirTexto_DUAL_DarumaFramework("<g></g>", 0))
                End If



                If Impressora.Contains("ESC/POS") = True Then

                    clsImprimir.SendStringToPrinter(PortaImpressora, clsImprimir.AbreGaveta())
                    Exit Function
                End If

                If Impressora.Contains("BEMATECH") Then
                    If PortaImpressora.Trim = "" Then
                        MsgBox("Informe a porta de comunicacão da impressora!")
                        Exit Function
                    End If
                    iRetorno = clsBematech.IniciaPorta(PortaImpressora)
                    iRetorno = Le_Status_Gaveta()

                    'If NomeEmpresa.Contains("SILVIO CARNES") = True Then

                    '    MsgBox("TESTE", MsgBoxStyle.Information)

                    '    Dim strComando As String
                    '    strComando = Chr(27) + Chr(118) + Chr(110)
                    '    iRetorno = ComandoTX(strComando, Len(strComando))

                    'Else
                    Select Case iRetorno
                        Case 0
                            MsgBox("Erro de comunicação!")

                        Case 1
                            MsgBox("Gaveta aberta!")
                        Case 2
                            Dim strComando As String
                            strComando = Chr(27) + Chr(118) + Chr(140)
                            iRetorno = ComandoTX(strComando, Len(strComando))
                    End Select
                    ' End If



                    iRetorno = clsBematech.FechaPorta()

                End If

                If Impressora.Trim = "" Then
                    If PortaImpressora.Trim = "" Then
                        MsgBox("Informe a porta de comunicacão da impressora!")
                        Exit Function
                    End If
                    iRetorno = clsBematech.IniciaPorta(PortaImpressora)
                    iRetorno = Le_Status_Gaveta()

                    Select Case iRetorno
                        Case 0
                            MsgBox("Erro de comunicação!")

                        Case 1
                            MsgBox("Gaveta aberta!")
                        Case 2
                            Dim strComando As String
                            strComando = Chr(27) + Chr(118) + Chr(140)
                            iRetorno = ComandoTX(strComando, Len(strComando))
                    End Select


                    iRetorno = clsBematech.FechaPorta()
                End If

                If Impressora.Contains("ARQUIVO") Then
                    Try
                        If PortaImpressora.Trim = "" Then
                            MsgBox("Informe a porta de comunicacão da impressora!")
                            Exit Function
                        End If
                        iRetorno = clsBematech.IniciaPorta(PortaImpressora)
                        iRetorno = Le_Status_Gaveta()

                        Select Case iRetorno
                            Case 0
                                'MsgBox("Erro de comunicação!")

                            Case 1
                                MsgBox("Gaveta aberta!")
                            Case 2
                                Dim strComando As String
                                strComando = Chr(27) + Chr(118) + Chr(140)
                                iRetorno = ComandoTX(strComando, Len(strComando))
                        End Select


                        iRetorno = clsBematech.FechaPorta()
                    Catch ex As Exception

                    End Try
                    

                End If


            Else
                If NomeEmpresa.Contains("SILVIO CARNES") = True Then
                    If Impressora.Contains("BEMATECH") Then
                        If PortaImpressora.Trim = "" Then
                            MsgBox("Informe a porta de comunicacão da impressora!")
                            Exit Function
                        End If
                        iRetorno = clsBematech.IniciaPorta("COM3")
                        Dim strComando As String
                        strComando = Chr(27) + Chr(118) + Chr(140)
                        iRetorno = ComandoTX(strComando, Len(strComando))
                        iRetorno = clsBematech.FechaPorta()
                    End If
                Else
                    If TipoImpressoraFiscal = "DARUMA" Then
                        DarumaFiscal.iRetorno = DarumaFiscal.eAbrirGaveta_ECF_Daruma()
                    Else

                        Retorno = Bematech_FI_AcionaGaveta()

                    End If
                End If




            End If

        End If

    End Function
    Public Shared Function CarregarDadosExecel(ByVal parLocal As String, ByVal parTabela As String, ByVal parGrid As DevExpress.XtraGrid.GridControl) As Boolean
        'Dim conexao As New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & parLocal & parTabela & ".xls';Extended Properties=Excel 8.0;")
        Dim conexao As New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & parLocal & "';Extended Properties=Excel 8.0;")

        Dim da As OleDbDataAdapter
        Dim dt As DataTable

        da = New OleDbDataAdapter("select * from [" & parTabela & "$]", conexao)

        dt = New DataTable
        da.Fill(dt)


        parGrid.DataSource = dt.DefaultView

        Return True

    End Function
    Public Shared Function CarregarDataTableExcel(ByVal parLocal As String, ByVal parTabela As String) As DataTable


        Dim conexao As New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & parLocal & parTabela & ".xls';Extended Properties=Excel 8.0;")

        Dim da As OleDbDataAdapter
        Dim dt As DataTable

        da = New OleDbDataAdapter("select * from [" & parTabela & "$]", conexao)

        dt = New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        Return dt

    End Function
    Public Shared Function AddPonto(ByVal parCPF As String, ByVal parPessoa As String) As String
        If parCPF = "" Then Return "" : Exit Function
        Dim I As Integer
        Dim strChar As String
        Dim strCPF As String = ""
        If parPessoa = "J" Then

            For I = 0 To 13
                'If parCPF.Length = I Then
                '    strChar = strCPF & "0"
                '    Exit For
                'End If
                strChar = parCPF.Substring(I, 1)
                strCPF = strCPF & strChar
                Select Case I

                    Case 1

                        strCPF = strCPF & "."
                    Case 4
                        strCPF = strCPF & "."
                    Case 7
                        strCPF = strCPF & "/"
                    Case 11
                        strCPF = strCPF & "-"
                End Select
            Next
        ElseIf parPessoa = "F" Then
            If parCPF.Length = 11 Then
                For I = 0 To 10
                    strChar = parCPF.Substring(I, 1)
                    strCPF = strCPF & strChar
                    Select Case I

                        Case 2
                            strCPF = strCPF & "."
                        Case 5
                            strCPF = strCPF & "."
                        Case 8
                            strCPF = strCPF & "-"
                    End Select
                Next
            ElseIf parCPF.Length = 10 Then
                For I = 0 To 9
                    strChar = parCPF.Substring(I, 1)
                    strCPF = strCPF & strChar
                    Select Case I

                        Case 1
                            strCPF = strCPF & "."
                        Case 4
                            strCPF = strCPF & "."
                        Case 7
                            strCPF = strCPF & "-"
                    End Select
                Next
            End If


        ElseIf parPessoa = "CEP" Then
            For I = 0 To 7
                strChar = parCPF.Substring(I, 1)
                strCPF = strCPF & strChar
                Select Case I

                    Case 1
                        strCPF = strCPF & "."
                    Case 4
                        strCPF = strCPF & "-"

                End Select
            Next


        Else
            Dim A As Integer = 0
            If parCPF.Length > 9 Then
                For I = 0 To parCPF.Length - 1

                    strChar = parCPF.Substring(I, 1)

                    Select Case I

                        Case 0

                            strCPF = strCPF & "("
                            If strChar = "0" Then
                                A = 3

                            Else

                                A = 2

                            End If


                        Case A
                            strCPF = strCPF & ")"

                    End Select

                    strCPF = strCPF & strChar

                Next
            End If
        End If

        Return strCPF

    End Function

    Public Shared Function ExcluirVendaPedido(ByVal parCodigo As Integer, ByVal parMotivo As String, ByVal parVendaPedido As String, ByVal parAvisos As Boolean, ByVal parSat As Boolean) As Boolean

        If parVendaPedido = "VENDA" Then

            If AbrirFecharCaixa = True Then
                If parCodigo > 0 Then
                    Dim dtCaixa As DataTable = CarregarDataTable("SELECT Codigo, Motivo FROM Caixa Motivo LIKE '%Venda Nº " & parCodigo & "%' and CodConfig =" & CodConfig)
                    If dtCaixa.Rows.Count > 0 Then
                        Dim strCodigoCaixa As String = dtCaixa.Rows.Item(0).Item("Codigo").ToString
                        Dim strMotivoCaixa As String = dtCaixa.Rows.Item(0).Item("Motivo").ToString
                        If VerificarExclusaoCaixa(strMotivoCaixa, strCodigoCaixa) = False Then Exit Function
                    End If
                End If
             
            End If


            Dim dt As DataTable = CarregarDataTable("Select Total from Total where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig)

            If dt.Rows.Count = 0 Then
                If parAvisos = True Then
                    MsgBox("Venda Nº " & parCodigo & " não existe!", MsgBoxStyle.Information)
                    Exit Function
                End If

            End If

            If parAvisos = True Then
                If MsgBox("Você tem certeza que deseja Excluir a Venda Nº " & parCodigo & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return False : Exit Function
            End If


            If PafEcfNano = True Then
                ExcluirVendaDAV(parCodigo)
            End If

            dt = CarregarDataTable("Select CodProd, Qtd, Tamanho, Lote, Devolvido from Pedido where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig)

            Dim I As Integer
            Dim dtQtd As DataTable

            For I = 0 To dt.Rows.Count - 1
                Dim bolDev As Boolean = dt.Rows.Item(I).Item("Devolvido")

                If bolDev = False Then

                    Dim dblQtdQtde, dblQtdMinQtde, dblQtdVenda, dblResul As Double
                    Dim intFalta, intCodProd As Integer

                    dtQtd = CarregarDataTable("Select Codigo, Qtd, QtdMinima from Qtde where CodProd =" & dt.Rows.Item(I).Item("CodProd").ToString & " and Lote ='" & dt.Rows.Item(I).Item("Lote").ToString & "' and Tamanho ='" & dt.Rows.Item(I).Item("Tamanho").ToString & "' AND CodConfig =" & CodConfig)

                    If dtQtd.Rows.Count > 0 Then
                        intCodProd = dtQtd.Rows.Item(0).Item("Codigo").ToString
                        dblQtdQtde = dtQtd.Rows.Item(0).Item("Qtd").ToString
                        dblQtdMinQtde = dtQtd.Rows.Item(0).Item("QtdMinima").ToString
                    End If

                    dblQtdVenda = dt.Rows.Item(I).Item("Qtd").ToString

                    dblResul = dblQtdQtde + dblQtdVenda

                    If dblQtdMinQtde >= dblResul Then
                        intFalta = 1
                    End If

                    Atualizar("Update Qtde set Qtd =" & Num(dblResul) & ", Acabou = 'False', EmFalta ='" & intFalta & "' where Codigo = " & intCodProd & " AND CodConfig =" & CodConfig)
                End If

            Next

            dt = CarregarDataTable("SELECT Valor FROM Recebimento where CodOrdem =" & parCodigo & " and Pagamento = 'CRÉDITO CLIENTE' and CodConfig =" & CodConfig)
            If dt.Rows.Count > 0 Then
                Dim dblValor As Double
                Dim dblCredito As Double
                Dim strCodCli As String = ""
                For I = 0 To dt.Rows.Count - 1

                    If dt.Rows.Item(I).Item("Valor").ToString <> "" Then
                        dblValor += dt.Rows.Item(I).Item("Valor").ToString
                    End If
                Next

                Dim dtCli As DataTable = CarregarDataTable("SELECT CodCli, Credito FROM Cliente left join Total on Cliente.Codigo = Total.CodCli where CodOrdem = " & parCodigo & " and Total.CodConfig = " & CodConfig)
                If dtCli.Rows.Count > 0 Then
                    strCodCli = dtCli.Rows.Item(0).Item("CodCli").ToString
                    If dtCli.Rows.Item(0).Item("Credito").ToString <> "" Then
                        dblCredito = dtCli.Rows.Item(0).Item("Credito").ToString
                    End If
                End If
                Dim dblResul As Double = dblCredito + dblValor
                Atualizar("UPDATE Cliente SET Credito = '" & dblResul.ToString("0.00") & "' where Codigo = " & strCodCli)
            End If

            dt = CarregarDataTable("SELECT sum(ValorParcela) as Valor FROM ContaReceber where CodOrdem = " & parCodigo & " and CodConfig = " & CodConfig & " and CodigoPedido = ''")
            If dt.Rows.Count > 0 Then
                Dim dblValor As Double
                Dim dblLimite As Double
                Dim strCodCli As String = ""
                If dt.Rows.Item(0).Item("Valor").ToString <> "" Then
                    dblValor = dt.Rows.Item(0).Item("Valor").ToString
                End If
                Dim dtCli As DataTable = CarregarDataTable("SELECT CodCli, Limite FROM Cliente left join Total on Cliente.Codigo = Total.CodCli where CodOrdem = " & parCodigo & " and Total.CodConfig = " & CodConfig)
                If dtCli.Rows.Count > 0 Then
                    strCodCli = dtCli.Rows.Item(0).Item("CodCli").ToString
                    If dtCli.Rows.Item(0).Item("Limite").ToString <> "" Then
                        dblLimite = dtCli.Rows.Item(0).Item("Limite").ToString
                    End If
                End If
                Dim dblResul As Double = dblLimite + dblValor

                If dtCli.Rows.Count > 0 Then
                    Atualizar("UPDATE Cliente SET Limite = '" & dblResul.ToString("0.00") & "' where Codigo = " & strCodCli)
                End If


            End If

            If EstoqueSomado = False Then
                dt = CarregarDataTable("Select Codigo, CodProd, Qtde, Motivo from Devolucao where Motivo Like '%NA VENDA Nº " & parCodigo & "%' and CodConfig =" & CodConfig)


                Dim K As Integer

                For K = 0 To dt.Rows.Count - 1
                    Dim strCodigoDev As String = dt.Rows.Item(K).Item("Codigo").ToString
                    Dim strMot As String = dt.Rows.Item(K).Item("Motivo").ToString
                    Dim vetMot As Array = Split(strMot, ",")
                    Dim strCodPed As String

                    If vetMot.Length > 2 Then
                        strCodPed = vetMot(2).ToString.Replace(" CÓDIGO AUTOMÁTICO Nº ", "")
                        Dim dt2 As DataTable = CarregarDataTable("Select Qtd, ValorUnitario, Custo, Devolvido, Lote from Pedido where Codigo = " & strCodPed.Trim)


                        Dim dblQtd, dblQtd2 As Double
                        Dim dblCusto As Double
                        Dim dblValTot As Double

                        dblQtd = dt2.Rows.Item(0).Item("Qtd").ToString
                        dblQtd2 = dt2.Rows.Item(0).Item("Qtd").ToString
                        dblCusto = dt2.Rows.Item(0).Item("Custo")
                        dblCusto = dblCusto / dblQtd

                        ' If dt2.Rows.Item(0).Item("Devolvido") = True Then
                        '     dblQtd = dt.Rows.Item(K).Item("Qtde").ToString
                        ' Else
                        '     If EstoqueSomado = True Then
                        '         dblQtd = dt.Rows.Item(K).Item("Qtde").ToString
                        '     Else
                        '         dblQtd = CDbl(dt2.Rows.Item(0).Item("Qtd").ToString) + CDbl(dt.Rows.Item(K).Item("Qtde").ToString)

                        '     End If
                        'End If


                        ' dblCusto = dblQtd * dblCusto
                        ' dblValTot = dblQtd * CDbl(dt2.Rows.Item(0).Item("ValorUnitario").ToString)

                        ' Atualizar("Update Pedido set Qtd =" & Num(dblQtd.ToString("0.000")) & ", Custo =" & Num(dblCusto.ToString("0.00")) & ", ValorTotal =" & Num(dblValTot.ToString("0.00")) & ", Devolvido ='False' where Codigo =" & strCodPed)


                        Dim dt3 As DataTable = CarregarDataTable("Select Codigo, Qtd from Qtde where CodProd=" & dt.Rows(K).Item("CodProd").ToString & " and Acabou = 'False' and CodConfig =" & CodConfig)

                        If dt3.Rows.Count > 0 Then
                            Dim dblQtdTabQtd As Double
                            Dim dblResulQtd As Double
                            dblQtdTabQtd = dt3.Rows.Item(0).Item("Qtd").ToString
                            dblResulQtd = dblQtdTabQtd - dblQtd2

                            If BaixaPorLote = True Then
                                Dim bolAcab As Boolean = False
                                If dblResulQtd <= 0 Then
                                    bolAcab = True
                                End If
                                Atualizar("Update Qtde set Qtd =" & dblResulQtd & ", Acabou ='" & bolAcab & "' where Codigo =" & dt3.Rows.Item(0).Item("Codigo").ToString)
                            Else
                                Atualizar("Update Qtde set Qtd =" & dblResulQtd & " where Codigo =" & dt3.Rows.Item(0).Item("Codigo").ToString)
                            End If

                        End If

                    End If
                    Excluir("DELETE FROM Devolucao where Codigo = " & strCodigoDev)

                Next
            End If
            

            Excluir("Delete from Caixa where Motivo LIKE '%Venda Nº " & parCodigo & "%' and CodConfig =" & CodConfig)

            Excluir("Delete from Recebimento where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig & " and CodigoPedido = ''")

            Dim dt1 As DataTable = CarregarDataTable("SELECT CodigoPedido FROM Recebimento where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig)
            If dt1.Rows.Count > 0 Then
                Dim strCodigoPedido As String = dt1.Rows.Item(0).Item("CodigoPedido").ToString
                If strCodigoPedido <> "" Then
                    Atualizar("UPDATE Recebimento SET CodOrdem = 0 where CodigoPedido = '" & strCodigoPedido & "' and CodConfig = " & CodConfig)
                End If
            End If
            If TEF = True Then
                dt1 = CarregarDataTable("SELECT NumTransacao, sum(Total) as Valor FROM Futuro where Status <> 'Cancelado' and CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig & " and CodigoPedido = '' group by NumTransacao")

                For I = 0 To dt1.Rows.Count - 1
                    Dim intCodTEF As Integer = GerarCodigoOrdens("TEF", CodConfig)
                    Inserir("Insert into Ordens (Tabela, Cod, CodConfig) values('TEF'," & intCodTEF & "," & CodConfig & ")")

                    Dim strValor As Double = dt1.Rows.Item(0).Item("Valor").ToString
                    frmTEF.intCredDeb = 200
                    RetornoTEF = -1
                    frmTEF.strNumTransacao = dt1.Rows.Item(0).Item("NumTransacao").ToString
                    frmTEF.cupomFiscal = intCodTEF
                    frmTEF.ShowDialog()
                    If RetornoTEF = 0 Then
                        Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
                        Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
                        clsTEF.FinalizaTransacaoSiTefInterativo(1, intCodTEF, dataFiscal, horario)
                    End If
                Next
            End If
            

            Excluir("Delete from Futuro where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig & " and CodigoPedido = ''")
            dt1 = CarregarDataTable("SELECT CodigoPedido FROM Futuro where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig)
            If dt1.Rows.Count > 0 Then
                Dim strCodigoPedido As String = dt1.Rows.Item(0).Item("CodigoPedido").ToString
                If strCodigoPedido <> "" Then
                    Atualizar("UPDATE Futuro SET CodOrdem = 0 where CodigoPedido = '" & strCodigoPedido & "' and CodConfig = " & CodConfig)
                End If
            End If
            Excluir("Delete from ContaReceber where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig & " and CodigoPedido = ''")
            dt1 = CarregarDataTable("SELECT CodigoPedido FROM ContaReceber where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig)
            If dt1.Rows.Count > 0 Then
                Dim strCodigoPedido As String = dt1.Rows.Item(0).Item("CodigoPedido").ToString
                If strCodigoPedido <> "" Then
                    Atualizar("UPDATE ContaReceber SET CodOrdem = 0 where CodigoPedido = '" & strCodigoPedido & "' and CodConfig = " & CodConfig)
                End If
            End If

            dt = CarregarDataTable("SELECT CodPedido, Total FROM Total where CodOrdem = " & parCodigo & " and CodConfig = " & CodConfig)
            Dim strTotal As String = ""
            If dt.Rows.Count > 0 Then
                strTotal = dt.Rows.Item(0).Item("Total").ToString
                Dim strCodOrdem As String = dt.Rows.Item(0).Item("CodPedido").ToString
                If strCodOrdem <> "" Then
                    Atualizar("UPDATE TotalConsig set Status = 'Pendente' where CodOrdens = " & strCodOrdem & " and CodConfig = " & CodConfig)
                End If
            End If


            Excluir("Delete from Pedido where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig)
            Excluir("Delete from Total where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig)
            Excluir("Delete from Comissao where CodOrdem =" & parCodigo & " and CodConfig =" & CodConfig)
            Excluir("Delete from MovimentoBancario where Observacao Like '%REFERENTE A VENDA Nº " & parCodigo & "%' and CodConfig =" & CodConfig)

            If parSat = False Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & "Venda Nº " & parCodigo & " Total R$ " & strTotal & "','" & parMotivo.Trim & "','ORDEM','VENDAS','EXCLUSÃO'," & CodConfig & ")")

            Else
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & "Venda Nº " & parCodigo & " Total R$ " & strTotal & "','" & parMotivo.Trim & "','ORDEM','SAT','EXCLUSÃO'," & CodConfig & ")")

            End If
           


            Return True

        ElseIf parVendaPedido = "PEDIDO" Then

            Dim dt As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens =" & parCodigo & " and CodConfig =" & CodConfig)

            If dt.Rows.Count = 0 Then
                MsgBox("Pedido Nº " & parCodigo & " não existe!", MsgBoxStyle.Information)
                Exit Function
            Else
                If dt.Rows.Item(0).Item("Status").ToString = "Pendente" Then
                    MsgBox("Pedido Nº " & parCodigo & " ainda não foi Faturado!", MsgBoxStyle.Information)
                    Exit Function
                End If
            End If
            dt = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & parCodigo & " and CodConfig = " & CodConfig)
            If dt.Rows.Count > 0 Then
                Dim strCodOrdem As String = dt.Rows.Item(0).Item("CodOrdem").ToString

                dt = CarregarDataTable("SELECT CodOrdem FROM Recebimento where CodigoPedido = '" & parCodigo & "' and CodConfig = " & CodConfig)
                If dt.Rows.Count > 0 Then
                    MsgBox("Pedido Nº " & parCodigo & " já utilizado na venda Nº " & strCodOrdem & "!", MsgBoxStyle.Information)
                    Exit Function
                End If
            End If
            If MsgBox("Você tem certeza que deseja Desfaturar o Pedido Nº " & parCodigo & "?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Atualizar("Update TotalConsig set Status ='Pendente' where CodOrdens =" & parCodigo & " and CodConfig =" & CodConfig) = True Then

                    Atualizar("UPDATE Total set CodPedido = null where CodPedido = " & parCodigo & " and CodConfig =" & CodConfig)

                    MsgBox("Pedido desfaturado com sucesso!", MsgBoxStyle.Information)
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & "Pedido Nº " & parCodigo & "','" & parMotivo.Trim & "','STATUS','TOTALCONSIG','DESFATURAR'," & CodConfig & ")")

                    'Excluir("Delete from Recebimento where CodigoPedido ='" & parCodigo & "' and CodConfig = " & CodConfig & " and CodOrdem = 0")
                    'Excluir("Delete from ContaReceber where CodigoPedido ='" & parCodigo & "' and CodConfig = " & CodConfig & " and CodOrdem = 0")
                    'Excluir("Delete from Caixa where Motivo LIKE '%PEDIDO Nº " & parCodigo & "%' and CodConfig = " & CodConfig)
                    'Excluir("Delete from Cheque where CodigoPedido ='" & parCodigo & "' and CodConfig = " & CodConfig & " and CodOrdem = 0")
                    'Excluir("Delete from Futuro where CodigoPedido ='" & parCodigo & "' and CodConfig = " & CodConfig & " and CodOrdem = 0")


                    Return True

                End If
            Else
                Return False
            End If
        End If
    End Function

    Public Shared Function TesteConexao() As Boolean

        Dim conexao As New SqlConnection(StringDeConexao)
        Dim strSQL As String
        strSQL = "Select Empresa from Config"
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(strSQL, conexao)

        dt = New DataTable

        Try
            da.Fill(dt)
            Return True
        Catch ex As Exception
            MsgBox("Seu computador não possui conexão com o banco de dados." & vbCrLf & "Verifique sua conexão de rede!", MsgBoxStyle.Information)
            Return False
        End Try
    End Function
    Public Shared Function SelecionarCodigoUF(ByVal parUF As String) As String
        Dim strCodUF As String = ""
        Select Case parUF

            Case "AC"
                strCodUF = "12"

            Case "AL"
                strCodUF = "27"

            Case "AP"
                strCodUF = "16"

            Case "AM"
                strCodUF = "13"

            Case "BA"
                strCodUF = "29"

            Case "CE"
                strCodUF = "23"

            Case "DF"
                strCodUF = "53"

            Case "ES"
                strCodUF = "32"

            Case "GO"
                strCodUF = "52"

            Case "MA"
                strCodUF = "21"

            Case "MT"
                strCodUF = "51"

            Case "MS"
                strCodUF = "50"

            Case "MG"
                strCodUF = "31"

            Case "PA"
                strCodUF = "15"

            Case "PB"
                strCodUF = "25"

            Case "PR"
                strCodUF = "41"

            Case "PE"
                strCodUF = "26"

            Case "PI"
                strCodUF = "22"

            Case "RJ"
                strCodUF = "33"

            Case "RN"
                strCodUF = "24"

            Case "RS"
                strCodUF = "43"

            Case "RO"
                strCodUF = "11"

            Case "RR"
                strCodUF = "14"

            Case "SC"
                strCodUF = "42"

            Case "SP"
                strCodUF = "35"

            Case "SE"
                strCodUF = "28"

            Case "TO"
                strCodUF = "17"

        End Select

        Return strCodUF
    End Function

    Public Shared Function SelecionarNomeUF(ByVal parUF As String) As String
        Dim strCodUF As String = ""
        Select Case parUF

            Case "AC"
                strCodUF = "Acre"

            Case "AL"
                strCodUF = "Alagoas"

            Case "AP"
                strCodUF = "Amapa"

            Case "AM"
                strCodUF = "Amazonas"

            Case "BA"
                strCodUF = "Bahia"

            Case "CE"
                strCodUF = "Ceara"

            Case "DF"
                strCodUF = "DistritoFederal"

            Case "ES"
                strCodUF = "EspiritoSanto"

            Case "GO"
                strCodUF = "Goias"

            Case "MA"
                strCodUF = "Maranhao"

            Case "MT"
                strCodUF = "MatoGrosso"

            Case "MS"
                strCodUF = "MatoGrossodoSul"

            Case "MG"
                strCodUF = "MinasGerais"

            Case "PA"
                strCodUF = "Para"

            Case "PB"
                strCodUF = "Paraiba"

            Case "PR"
                strCodUF = "Parana"

            Case "PE"
                strCodUF = "Pernambuco"

            Case "PI"
                strCodUF = "Piaui"

            Case "RJ"
                strCodUF = "RiodeJaneiro"

            Case "RN"
                strCodUF = "RioGrandedoNorte"

            Case "RS"
                strCodUF = "RioGrandedoSul"

            Case "RO"
                strCodUF = "Rondonia"

            Case "RR"
                strCodUF = "Roraima"

            Case "SC"
                strCodUF = "SantaCatarina"

            Case "SP"
                strCodUF = "SaoPaulo"

            Case "SE"
                strCodUF = "Sergipe"

            Case "TO"
                strCodUF = "Tocantins"

        End Select

        Return strCodUF
    End Function
    Public Shared Function Data(ByVal parData As String) As String
        Dim strData As String = ""
        If parData.ToString = "" Then
            strData = ""
        Else
            Dim dtData As Date = parData
            Dim strAno As String = dtData.Year
            If strAno > "2050" Then
                strData = ""
            ElseIf strAno < "1910" Then
                strData = ""
            Else
                strData = parData
            End If
        End If

        Return strData
    End Function

    Public Shared Function ComSenha() As Boolean

        If MsgBox("O cliente está com pagamentos em atraso, deseja informar a senha de administrador para efetuar a venda mesmo assim?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Return SenhaEstaOK()
        End If

    End Function

    Public Shared Function VerificarNSNFe() As Boolean
        Dim myprocesses As Process()
        myprocesses = Process.GetProcessesByName("NFe")
        If myprocesses.Length > 0 Then
        Else

            Try
                System.Diagnostics.Process.Start("C:\NSNFE\NFe.exe")
            Catch ex As Exception

            End Try
        End If
    End Function

    Public Shared Function LerArquivoMail(ByVal parPath As String) As String
        Dim Arquivo As String

        Arquivo = parPath

        'Dim fluxoTexto As IO.StreamReader
        Dim Texto As String = ""

        If IO.File.Exists(Arquivo) Then

            Dim Leitor As StreamReader
            'Leitor = New StreamReader(New FileStream(parPath, FileMode.Open), False)
            Leitor = File.OpenText(Arquivo)
            Texto = Leitor.ReadToEnd
            Leitor.Close()
        Else
            MessageBox.Show("Arquivo não existe")
        End If

        Return Texto
    End Function


    Public Shared Function enviaMensagemEmail(ByVal from As String, ByVal parSenha As String, _
    ByVal recepient As String, ByVal bcc As String, ByVal cc As String, ByVal subject As String, _
    ByVal body As String, ByVal servidorSMTP As String, ByVal parNivel As String, ByVal parConfirmacao As Boolean, _
    ByVal parTeste As String, ByVal parPorta As String, ByVal parServico As String, ByVal parAnexos() As String) As Boolean

        If parServico = "" Then

            'Try
            '    ' cria uma instância do objeto MailMessage

            '    Dim mMailMessage As New System.Net.Mail.MailMessage()

            '    ' Define o endereço do remetente
            '    mMailMessage.From = New System.Net.Mail.MailAddress(from)

            '    If parConfirmacao = True Then
            '        mMailMessage.Headers.Add("Disposition-Notification-To", from)
            '    End If


            '    Dim vetDest As Array
            '    vetDest = Split(recepient, ";")
            '    If vetDest(0).ToString <> "" Then
            '        For Each mail As Object In vetDest
            '            ' mMailMessage.Bcc.Add(mail.ToString())
            '            mMailMessage.To.Add(mail.ToString.Trim())
            '        Next
            '    End If

            '    vetDest = Split(bcc, ";")
            '    If vetDest(0).ToString <> "" Then
            '        For Each mail As Object In vetDest
            '            ' mMailMessage.Bcc.Add(mail.ToString())
            '            mMailMessage.Bcc.Add(mail.ToString.Trim())

            '        Next
            '    End If
            '    ' verifica se o valor para cc é nulo ou uma string vazia
            '    vetDest = Split(cc, ";")
            '    If vetDest(0).ToString <> "" Then
            '        For Each mail As Object In vetDest
            '            ' mMailMessage.Bcc.Add(mail.ToString())
            '            mMailMessage.CC.Add(mail.ToString.Trim())
            '        Next
            '    End If
            '    Dim i As Integer
            '    For i = 0 To frmEmail.lstAnexo.Items.Count - 1
            '        mMailMessage.Attachments.Add(New System.Net.Mail.Attachment(frmEmail.lstAnexo.Items(i)))
            '    Next

            '    ' Define o assunto 

            '    mMailMessage.Subject = subject
            '    ' Define o corpo da mensagem
            '    mMailMessage.Body = body
            '    ' Dim view As AlternateView = AlternateView.CreateAlternateViewFromString(body, Nothing, MediaTypeNames.Text.Html)

            '    mMailMessage.IsBodyHtml = True
            '    mMailMessage.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
            '    mMailMessage.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

            '    Select Case parNivel
            '        Case "Normal"
            '            mMailMessage.Priority = System.Net.Mail.MailPriority.Normal
            '        Case "High"
            '            mMailMessage.Priority = System.Net.Mail.MailPriority.High
            '        Case "Low"
            '            mMailMessage.Priority = System.Net.Mail.MailPriority.Low
            '    End Select

            '    Dim mSmtpClient As New System.Net.Mail.SmtpClient(servidorSMTP)
            '    mSmtpClient.Credentials = New System.Net.NetworkCredential(from, parSenha)
            '    mSmtpClient.Host = servidorSMTP
            '    mSmtpClient.Port = parPorta
            '    'mSmtpClient.EnableSsl = True

            '    mSmtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network

            '    mSmtpClient.Send(mMailMessage)

            '    If parTeste = "TESTE" Then
            '        MsgBox("Teste de conta realizado com sucesso!", MsgBoxStyle.Information)
            '        Return True
            '    Else
            '        MsgBox("Mensagem enviada com sucesso!", MsgBoxStyle.Information)
            '        Return True
            '    End If

            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Information)
            '    Return False
            'End Try

        Else

            Try

                Dim bolSSL As Boolean = False

                Select Case parServico
                    Case "LocaWeb"
                        bolSSL = False
                    Case "Outros"
                        bolSSL = False
                    Case Else
                        bolSSL = True
                End Select

                Dim SmtpServer As New SmtpClient()
                SmtpServer.Credentials = New Net.NetworkCredential(from, parSenha)
                SmtpServer.Port = parPorta
                SmtpServer.Host = servidorSMTP
                SmtpServer.EnableSsl = bolSSL
                Dim mMailMessage As New MailMessage()


                ' Define o endereço do remetente
                mMailMessage.From = New MailAddress(from, from, System.Text.Encoding.UTF8)

                If parConfirmacao = True Then
                    mMailMessage.Headers.Add("Disposition-Notification-To", from)
                End If


                Dim vetDest As Array
                vetDest = Split(recepient, ";")
                If vetDest(0).ToString <> "" Then
                    For Each mail As Object In vetDest
                        mMailMessage.To.Add(mail.ToString.Trim())
                    Next
                End If

                vetDest = Split(bcc, ";")
                If vetDest(0).ToString <> "" Then
                    For Each mail As Object In vetDest
                        mMailMessage.Bcc.Add(mail.ToString.Trim())
                    Next
                End If
                ' verifica se o valor para cc é nulo ou uma string vazia
                vetDest = Split(cc, ";")
                If vetDest(0).ToString <> "" Then
                    For Each mail As Object In vetDest
                        mMailMessage.CC.Add(mail.ToString.Trim())
                    Next
                End If


                Dim strCaminho As String = ""

                If IO.File.Exists("C:\NANO\AssinaturaEmail.png") = True Then
                    strCaminho = "C:\NANO\AssinaturaEmail.png"
                Else

                    If IO.File.Exists("C:\NANO\AssinaturaEmail.jpg") = True Then
                        strCaminho = "C:\NANO\AssinaturaEmail.jpg"
                    Else

                        If IO.File.Exists("C:\NANO\AssinaturaEmail.jpeg") = True Then
                            strCaminho = "C:\NANO\AssinaturaEmail.jpeg"
                        End If

                    End If

                End If

               

                If strCaminho <> "" Then
                    body = body.Replace("</table>", "</table><img src=cid:companylogo>")
                
                End If

                Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(body, Nothing, "text/html")

                If strCaminho <> "" Then
                    Dim logo As New LinkedResource(strCaminho)
                    logo.ContentId = "companylogo"
                    htmlView.LinkedResources.Add(logo)
                End If

                Dim i As Integer = frmEmail.tbImagem.Rows.Count

                Dim dr1 As DataRow()
                dr1 = frmEmail.tbImagem.Select("Caminho <> ''", "Ordem")

                For i = 0 To dr1.Length - 1
                    Dim strCaminhoImagem As String = dr1(i).Item("Caminho").ToString
                    Dim strOrdem As String = dr1(i).Item("Ordem").ToString
                    Dim imgImagem As New LinkedResource(strCaminhoImagem)
                    imgImagem.ContentId = "Imagem" & i + 1
                    htmlView.LinkedResources.Add(imgImagem)
                Next
                'For i = 0 To frmEmail.grd1.RowCount - 1
                '    Dim strCaminho As String = frmEmail.grd1.GetRowCellDisplayText(i, frmEmail.colCaminho)
                '    Dim imgImagem As New LinkedResource(strCaminho)
                '    imgImagem.ContentId = "Imagem" & i + 1
                '    htmlView.LinkedResources.Add(imgImagem)

                'Next
                mMailMessage.AlternateViews.Add(htmlView)



                For i = 0 To frmEmail.lstAnexo.Items.Count - 1
                    mMailMessage.Attachments.Add(New System.Net.Mail.Attachment(frmEmail.lstAnexo.Items(i)))
                Next
                If parAnexos Is Nothing Then

                Else
                    For i = 0 To parAnexos.Length - 1

                        If parAnexos(i) Is Nothing Then

                        Else
                            mMailMessage.Attachments.Add(New System.Net.Mail.Attachment(parAnexos(i).ToString))
                        End If


                    Next

                End If

                ' Define o assunto 

                mMailMessage.Subject = subject
                ' Define o corpo da mensagem
                mMailMessage.Body = body
                ' Dim view As AlternateView = AlternateView.CreateAlternateViewFromString(body, Nothing, MediaTypeNames.Text.Html)

                mMailMessage.IsBodyHtml = True
                'mMailMessage.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
                'mMailMessage.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

                Select Case parNivel
                    Case "Normal"
                        mMailMessage.Priority = System.Net.Mail.MailPriority.Normal
                    Case "High"
                        mMailMessage.Priority = System.Net.Mail.MailPriority.High
                    Case "Low"
                        mMailMessage.Priority = System.Net.Mail.MailPriority.Low
                End Select


                SmtpServer.Send(mMailMessage)

                If parTeste = "TESTE" Then
                    MsgBox("Teste de conta realizado com sucesso!", MsgBoxStyle.Information)
                    mMailMessage.Dispose()
                    Return True
                ElseIf parTeste = "ARQUIVO" Then
                    mMailMessage.Dispose()
                    Return True
                Else
                    MsgBox("Mensagem enviada com sucesso!", MsgBoxStyle.Information)
                    mMailMessage.Dispose()
                    Return True
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)

                Return False
            End Try

        End If


    End Function


    Public Shared Function LerArquivo2(ByVal parCaminhoArquivo As String) As String
        Dim fluxoTexto As IO.StreamReader
        Dim strTexto As String = ""

        If IO.File.Exists(parCaminhoArquivo) Then
            fluxoTexto = New IO.StreamReader(parCaminhoArquivo)
            strTexto = fluxoTexto.ReadToEnd
            fluxoTexto.Close()

        Else
            MessageBox.Show("Arquivo " & parCaminhoArquivo & " não existe")
        End If

        Return strTexto
    End Function

    Public Shared Function ValidaEan13(ByVal Codigo As String) As Boolean
        Dim Retorno As Boolean = False
        Dim Peso As Integer = 3
        Dim Soma As Integer = 0
        Dim Digito As Integer
        Dim I As Integer
        If Codigo = "" Then Return True : Exit Function
        If Codigo.Length = 13 Then

            For I = 1 To 12
                If Peso = 1 Then Peso = 3 Else Peso = 1
                Soma += (CInt(Mid(Codigo, I, 1)) * Peso)
            Next

            Digito = (Int(Soma / 10) + 1) * 10 - Soma

            If Microsoft.VisualBasic.Right(Codigo, 1) = Digito.ToString Then Return True : Exit Function

        End If
        Return False
    End Function

    'VERIFICA DIA DA SEMANA PARA CADASTRO MOVIMENTO BANCARIO
    Public Shared Function DiaDaSemana(ByVal parData As String) As String
        Dim strVencimento As String = parData
        Try
            Dim culture As New CultureInfo("pt-BR")
            Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
            Dim dtVenc As Date = parData

            Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(CDate(parData).DayOfWeek))

            strVencimento = dtVenc.Date
            If diasemana.Trim = "Sábado" Then
                strVencimento = dtVenc.AddDays(2)
            ElseIf diasemana.Trim = "Domingo" Then
                strVencimento = dtVenc.AddDays(1)
            End If
        Catch ex As Exception
        End Try

        Return strVencimento
    End Function

    Public Shared Function BaixarCartoes() As Boolean
        Dim dt As DataTable = CarregarDataTable("Select Futuro.Codigo, Futuro.CodOrdem, Futuro.Pagamento, Futuro.Data, " & _
        "Futuro.TotalDesconto as Valor from Futuro left join Pagamento on Futuro.Pagamento = Pagamento.Descricao " & _
        "where Futuro.Data <='" & Date.Today & "' and Futuro.Recebido ='False' and Futuro.CodConfig = " & CodConfig & " and Pagamento.CodBanco > 0")

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1

            Dim dtBanco As DataTable = CarregarDataTable("Select Codbanco from Pagamento where Descricao ='" & dt.Rows.Item(I).Item("Pagamento").ToString & "'")

            Dim intCodBanco As Integer = 0
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
            If dtBanco.Rows.Count > 0 Then
                If dtBanco.Rows.Item(0).Item("CodBanco").ToString <> "" Then
                    intCodBanco = dtBanco.Rows.Item(0).Item("CodBanco")
                End If

            End If


            If intCodBanco <> 0 Then
                Dim dtBanco2 As DataTable = CarregarDataTable("Select * from Banco where codigo =" & intCodBanco)
                If dtBanco2.Rows.Count > 0 Then

                    Dim strVencimento As String = DiaDaSemana(dt.Rows.Item(I).Item("Data"))

                    Dim strMotivo As String = "RECEBIMENTO " & dt.Rows.Item(I).Item("Pagamento").ToString & " REFERENTE A VENDA Nº " & strCodOrdem
                    Inserir("Insert into MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig) Values(" & intCodBanco & ",'CRÉDITO','" & Num(dt.Rows.Item(I).Item("Valor").ToString) & "','" & strVencimento & "','" & strMotivo & "'," & CodConfig & ")")
                    Atualizar("Update Futuro set Recebido ='True' where Codigo = " & strCodigo & " and CodConfig = " & CodConfig)

                End If
          End If

        Next

        'If dt.Rows.Count > 0 Then
        '    Atualizar("Update Futuro set Recebido ='True' where Data <='" & Date.Today & "'")
        'End If

    End Function

    Public Shared Function ExecCmdOnline(ByVal strSQL As String) As Boolean

        Try
            strSQL = "SET DATEFORMAT dmy " & strSQL

            Dim conexao = New SqlConnection(StringOnline)
            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function DataTableOnline(ByVal parCmdSql As String) As DataTable


        Dim conexao As New SqlConnection(StringOnline)
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable

        Try
            da.Fill(dt)

            ErroConexaoOnline = False
        Catch ex As Exception
            ErroConexaoOnline = True
        End Try

        Return dt

    End Function


    Public Shared Function AjusteQtde(ByVal parCodConfig As String, ByVal parCodProd As String) As Double
        Dim dblQtdEnt As Double = 0
        Dim dblQtdSai As Double = 0
        Dim dblQtdAjuste As Double = 0

        Dim dtEnt As DataTable = CarregarDataTable("SELECT case when Sum(QtdProd) is null then 0 else sum(QtdProd) end as Entrada " & _
        "FROM (Produto left join EntradaNf on Produto.Codigo = EntradaNf.CodProd) left join TotalEntradaNf on " & _
        "EntradaNf.CodTotNf = TotalEntradaNf.Codigo where Produto.Codigo = " & parCodProd & " and " & _
        "EstoqueOk = 'True' and EntradaNf.Codconfig = " & parCodConfig)

        dblQtdEnt = dtEnt.Rows.Item(0).Item("Entrada").ToString

        Dim dtPed As DataTable = CarregarDataTable("SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end as Saida " & _
        "FROM Produto left join Pedido on Produto.Codigo = Pedido.CodProd where Produto.Codigo = " & parCodProd & " and " & _
        "Pedido.Codconfig = " & parCodConfig & " and Pedido.Devolvido = 'False'")

        dblQtdSai = dtPed.Rows.Item(0).Item("Saida").ToString

        Dim dtAjus As DataTable = CarregarDataTable("SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end as Ajuste " & _
        "FROM Produto left join AjusteQtde on Produto.Codigo = AjusteQtde.CodProd where Produto.Codigo = " & parCodProd & " and " & _
        "AjusteQtde.Codconfig = " & parCodConfig)

        dblQtdAjuste = dtAjus.Rows.Item(0).Item("Ajuste").ToString

        Dim dblResul As Double = (dblQtdEnt - dblQtdSai) + dblQtdAjuste

        Return dblResul
    End Function
    Public Shared Function AjusteQtdeData(ByVal parCodConfig As String, ByVal parCodProd As String, ByVal parData As String) As Double
        Dim dblQtdEnt As Double = 0
        Dim dblQtdSai As Double = 0
        Dim dblQtdAjuste As Double = 0

        Dim dtEnt As DataTable = CarregarDataTable("SELECT case when Sum(QtdProd) is null then 0 else sum(QtdProd) end as Entrada " & _
        "FROM (Produto left join EntradaNf on Produto.Codigo = EntradaNf.CodProd) left join TotalEntradaNf on " & _
        "EntradaNf.CodTotNf = TotalEntradaNf.Codigo where Produto.Codigo = " & parCodProd & " and " & _
        "EstoqueOk = 'True' and EntradaNf.Codconfig = " & parCodConfig & " and TotalEntradaNf.Data < '" & parData & "'")

        dblQtdEnt = dtEnt.Rows.Item(0).Item("Entrada").ToString

        Dim dtPed As DataTable = CarregarDataTable("SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end as Saida " & _
        "FROM (Produto left join Pedido on Produto.Codigo = Pedido.CodProd) left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where Produto.Codigo = " & parCodProd & " and " & _
        "Pedido.Codconfig = " & parCodConfig & " and Pedido.Devolvido = 'False' and Total.Data < '" & parData & "'")

        dblQtdSai = dtPed.Rows.Item(0).Item("Saida").ToString

        Dim dtAjus As DataTable = CarregarDataTable("SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end as Ajuste " & _
        "FROM Produto left join AjusteQtde on Produto.Codigo = AjusteQtde.CodProd where Produto.Codigo = " & parCodProd & " and " & _
        "AjusteQtde.Codconfig = " & parCodConfig & " and AjusteQtde.Data < '" & parData & "'")

        dblQtdAjuste = dtAjus.Rows.Item(0).Item("Ajuste").ToString

        Dim dblResul As Double = (dblQtdEnt - dblQtdSai) + dblQtdAjuste

        Return dblResul
    End Function
    Public Shared Function ProcuraForm(ByVal form_name As String) As String
        Dim i As Integer

        ProcuraForm = ""

        For i = 0 To My.Application.OpenForms.Count - 1
            Dim strForm As String = My.Application.OpenForms.Item(i).Name
            If strForm = form_name Then
                ProcuraForm = strForm
                Exit For
            End If
        Next
        Return ProcuraForm
    End Function
    Public Shared Function CarregarDadosAgenda(ByVal parCmdSql As String, ByVal parAgenda As DevExpress.XtraScheduler.SchedulerStorage) As Boolean

        If TesteConexao() = False Then Exit Function

        Dim conexao As New SqlConnection(StringDeConexao)
        parCmdSql = "SET DATEFORMAT dmy " & parCmdSql
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable
        Try
            da.Fill(dt)
            parAgenda.Appointments.DataSource = dt.DefaultView

        Catch ex As Exception

            'If TelaErro(ex.Message, parCmdSql) = True Then
            '    MensagemDeErro = ex.Message
            '    Dim Erro As New clsFuncoes
            '    Erro.IniciaThread()
            'Else
            '    If NovoComandoSQL <> Nothing Then
            '        da = New SqlDataAdapter(NovoComandoSQL, conexao)
            '        dt = New DataTable
            '        da.Fill(dt)
            '    End If
            'End If
        End Try

        Return True

    End Function
    Public Shared Function UltimoDiaMes(ByVal paramDataX As Date) As Date
        UltimoDiaMes = DateAdd("m", 1, DateSerial(Year(paramDataX), Month(paramDataX), 1))
        UltimoDiaMes = DateAdd("d", -1, UltimoDiaMes)
        Return UltimoDiaMes
    End Function

    Public Shared Function ImprimirVendaNormal(ByVal parOrdem As String, ByVal parConfig As String) As Boolean


        If ImpressaoPedidoCompleto = False Then
            Dim rel As New relVenda
            Dim dtPed As DataTable = CarregarDataTable("SELECT CodProdInterno, Produto, ValorUnitario, Qtd, ValorTotal, " & _
            "Tamanho, Total.CodCli, Total.CodConfig, Convert(Numeric(15,2),Total.Total)as Total, Total.Troco, " & _
            "Total.Recebido, Total.Data, Pedido.CodFunc, UniSemDesc, convert(Numeric(15,2),Total.ValDesc) as ValDesc, Total.CPFCliente, CodPedido " & _
            "FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem where Pedido.CodOrdem = " & parOrdem & " and " & _
            "Pedido.TipoItens <> 'CONSUMO' and Pedido.CodConfig =" & parConfig & " and Total.CodConfig =" & parConfig)

            If dtPed.Rows.Count > 0 Then

                rel.lblNumVen.Text = parOrdem
                rel.lblData.Text = Format(dtPed.Rows.Item(0).Item("Data"), "dd/MM/yyyy")


                Dim strCodFunc As String = dtPed.Rows.Item(0).Item("CodFunc").ToString
                If strCodFunc <> "" Then
                    Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFunc)
                    If dtFunc.Rows.Count > 0 Then
                        rel.lblVend.Text = dtFunc.Rows.Item(0).Item("Nome").ToString
                    Else
                        rel.XrLabel4.Visible = False
                    End If
                Else
                    rel.XrLabel4.Visible = False
                End If


                Dim L As Integer

                Dim dblValorTotal As Double
                Dim dblValor As Double
                Dim dblTotDesc As Double
                Dim dblTotDevolvido As Double = 0
                For L = 0 To dtPed.Rows.Count - 1
                    Dim strCod, strProd, strQtd, strTam As String
                    Dim dblUni, dblTot, dblUniSemDesc As Double

                    strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                    strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                    dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                    strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
                    dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                    strTam = dtPed.Rows.Item(L).Item("Tamanho").ToString
                    If dtPed.Rows.Item(L).Item("UniSemDesc").ToString <> "" Then
                        dblUniSemDesc = dtPed.Rows.Item(L).Item("UniSemDesc").ToString
                    Else
                        dblUniSemDesc = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                    End If

                    dblValorTotal += strQtd * dblUniSemDesc

                    rel.tbItens.Rows.Add()
                    rel.tbItens.Rows.Item(L).Item("CodProd") = strCod
                    rel.tbItens.Rows.Item(L).Item("Produto") = strProd
                    rel.tbItens.Rows.Item(L).Item("Qtde") = strQtd
                    rel.tbItens.Rows.Item(L).Item("Unitario") = dblUni.ToString("0.000")
                    rel.tbItens.Rows.Item(L).Item("Total") = dblTot.ToString("0.00")
                    rel.tbItens.Rows.Item(L).Item("Tamanho") = strTam
                    rel.tbItens.Rows.Item(L).Item("UniSemDesc") = dblUniSemDesc.ToString("0.000")
                    If dblUniSemDesc > 0 Then
                        dblTotDesc = dblTotDesc + (dblUniSemDesc * strQtd)
                    Else
                        dblTotDevolvido = dblTotDevolvido + (dblUniSemDesc * strQtd)
                    End If

                Next
                dblTotDesc = dblTotDesc - dblTotDevolvido
                dblValor = dtPed.Rows.Item(0).Item("Total").ToString
                Dim dblTroco As Double = 0
                If dtPed.Rows.Item(0).Item("Troco").ToString <> "" Then
                    dblTroco = dtPed.Rows.Item(0).Item("Troco").ToString


                End If
                rel.lblTotalSDesc.Text = "0,00"
                Try
                    Dim dtTotSemDesc As DataTable = CarregarDataTable("Select Sum(case when Qtd < 0 then ((Qtd - Qtd) - Qtd) * UniSemDesc else Qtd * UniSemDesc end) as TotalSemDesc " & _
                    " From Pedido where Pedido.CodOrdem = " & parOrdem & " and Pedido.TipoItens <> 'CONSUMO' " & _
                    " and Pedido.CodConfig =" & parConfig)

                    If dtTotSemDesc.Rows.Count > 0 Then
                        Dim dblTolSemDesc As Double = dtTotSemDesc.Rows.Item(0).Item("TotalSemDesc").ToString
                        rel.lblTotalSDesc.Text = dblTolSemDesc.ToString("0.00")
                    End If
                Catch ex As Exception

                End Try

                'If NomeEmpresa.ToString.ToUpper.Contains("BAREX") = False Then
                rel.XrTable1.Visible = True
                If dtPed.Rows.Item(0).Item("ValDesc").ToString <> "0,00" Then
                    rel.lblDesconto.Text = dtPed.Rows.Item(0).Item("ValDesc").ToString
                Else
                    Dim dbl As Double
                    Dim dbl2 As Double = dtPed.Rows.Item(0).Item("Total").ToString

                    dbl = dblTotDesc - dbl2

                    rel.lblDesconto.Text = dbl.ToString("0.00")
                    If dbl < 0 Then
                        rel.XrTableCell1.Text = "Acréscimo R$"
                    End If
                End If
                rel.lblTotal.Text = dtPed.Rows.Item(0).Item("Total").ToString
                'End If

                If DescontoImpressao = False Then
                    'rel.XrTableRow1.Visible = False
                    'rel.XrTableRow3.Visible = False
                    rel.colUniSemDesc.Visible = False
                    rel.XrTableCell2.Text = ""
                    rel.lblTotalSDesc.Text = ""
                    rel.XrTableCell1.Text = ""
                    rel.lblDesconto.Text = ""
                    rel.lblTotalSDesc.Borders = BorderSide.None
                    rel.XrTableCell2.Borders = BorderSide.None
                    rel.XrTableCell1.Borders = BorderSide.Bottom
                    rel.lblDesconto.Borders = BorderSide.Bottom
                Else
                    If rel.lblTotalSDesc.Text = rel.lblTotal.Text Then
                        rel.XrTableCell2.Text = ""
                        rel.lblTotalSDesc.Text = ""
                        'rel.XrTableRow3.Visible = False
                        rel.colUniSemDesc.Visible = False
                        rel.lblTotalSDesc.Borders = BorderSide.Bottom
                        rel.XrTableCell2.Borders = BorderSide.Bottom
                    End If
                End If

                Dim bolTroco As Boolean = False
                Dim P As Integer
                Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor FROM Recebimento where CodOrdem = " & parOrdem & " and CodConfig = " & parConfig & " order by Codigo desc")
                If dtPag.Rows.Count > 0 Then

                    For P = 0 To dtPag.Rows.Count - 1
                        Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        If strPag = "DINHEIRO" Then
                            If bolTroco = False Then
                                If dblTroco > 0 Then
                                    dblValor = dblValor + dblTroco
                                    bolTroco = True
                                End If
                            End If
                        End If

                        rel.txtTexto.Text &= " " & Dir(strPag, 19) & " R$ " & Esq(dblValor.ToString("0.00"), 9) & vbCrLf
                    Next
                End If



                If dblTroco > 0 Then
                    rel.txtTexto.Text &= " TROCO              " & "R$ " & Esq(dblTroco.ToString("0.00"), 9) & vbCrLf
                End If

                Dim dtCli As DataTable = CarregarDataTable("Select Nome, CPF, RGIE, Endereco, Bairro, Numero, Cidade, Cep, " & _
                "convert(Varchar(10),Nascimento,103) as Nascimento from Cliente where Codigo =" & dtPed.Rows.Item(0).Item("CodCli").ToString)

                If dtCli.Rows.Count > 0 Then
                    rel.lblCli.Text = dtCli.Rows.Item(0).Item("Nome").ToString
                    rel.lblCPF.Text = dtPed.Rows.Item(0).Item("CPFCliente").ToString

                End If

                Dim dt As DataTable

                dt = CarregarDataTable("Select Parcelas, ValorParcela, Vencimento, RecebidoOK from ContaReceber where CodOrdem =" & parOrdem & " and CodConfig =" & parConfig)


                Dim J As Integer
                Dim strVenc, strOK, strPar As String
                Dim dblValPar As Double


                For J = 0 To dt.Rows.Count - 1
                    strPar = dt.Rows.Item(J).Item("Parcelas").ToString
                    dblValPar = dt.Rows.Item(J).Item("ValorParcela").ToString
                    strVenc = Format(dt.Rows.Item(J).Item("Vencimento"), "dd/MM/yyyy")
                    strOK = "Sim"

                    If dt.Rows.Item(J).Item("RecebidoOK") = False Then
                        strOK = "Não"
                    End If

                    rel.txtTexto2.Text &= Cent(strPar, 5) & Esq(dblValPar.ToString("0.00"), 16) & Esq(strVenc, 14) & Esq(strOK, 10) & vbCrLf

                Next

                dt = CarregarDataTable("Select Descricao from Config where Codigo =" & parConfig)

                If dt.Rows.Count > 0 Then
                    rel.lblLoja.Text = dt.Rows.Item(0).Item("Descricao").ToString
                End If

                rel.picLogo.Image = LogoTipo

                'OcultarAutorizacao
                If AutorizacaoPedido = False Then
                    rel.lblAutorizacao.Visible = False
                    rel.lblAutorizacaoEmpresa.Visible = False
                Else
                    rel.lblAutorizacao.Text = dtCli.Rows.Item(0).Item("Nome").ToString
                    rel.lblAutorizacaoEmpresa.Text = NomeEmpresa
                    If NomeEmpresa.ToUpper.Contains("DECOR") = False Then
                        rel.lblAutorizacaoEmpresa.Visible = False
                    End If

                End If

                If DescricaoVenda <> "" Then
                    rel.lblDescricaoVenda.Text = DescricaoVenda
                End If

                Dim intCodPedido As Integer = 0
                If dtPed.Rows.Item(0).Item("CodPedido").ToString <> "" And dtPed.Rows.Item(0).Item("CodPedido").ToString <> "0" Then
                    intCodPedido = dtPed.Rows.Item(0).Item("CodPedido")
                    rel.lblPed.Visible = True
                    rel.lblNumPed.Visible = True
                    rel.lblNumPed.Text = intCodPedido
                End If

                If ObsPedidoVenda = True Then
                 
                    Dim dtObsPed As DataTable = CarregarDataTable("Select Descricao from TotalConsig where CodOrdens =" & intCodPedido & " and CodConfig =" & CodConfig)

                    Dim strObsPedido As String = ""

                    If dtObsPed.Rows.Count > 0 Then
                        strObsPedido = dtObsPed.Rows.Item(0).Item("Descricao").ToString
                        rel.lblObsPedido.Text = strObsPedido
                    End If
                End If

                rel.lblTitulo.Text = NomeEmpresa
                rel.lblEndereco.Text = EnderecoEmpresa
                rel.lblFones.Text = TelefoneEmpresa

                rel.ShowPreview()
            End If

        Else

            Dim rel As New relVenda2
            Dim dtPed As DataTable = CarregarDataTable("SELECT CodProdInterno, Produto, ValorUnitario, Qtd, ValorTotal, " & _
            "Tamanho, Total.CodCli, Total.CodConfig, Convert(Numeric(15,2),Total.Total) as Total, Total.Troco, Total.Recebido, Total.Data, Pedido.CodFunc, UniSemDesc, convert(Numeric(15,2),Total.ValDesc) as ValDesc, CodPedido " & _
            "FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem where Pedido.CodOrdem = " & parOrdem & " and " & _
            "Pedido.TipoItens <> 'CONSUMO' and Pedido.CodConfig =" & parConfig & " and Total.CodConfig =" & parConfig)

            If dtPed.Rows.Count > 0 Then
                If QtdeLoja > 1 Then
                    rel.XrLabel5.Location = New System.Drawing.Point(8, 8)
                    rel.lblLoja.Location = New System.Drawing.Point(83, 8)

                    rel.XrLabel1.Location = New System.Drawing.Point(333, 8)
                    rel.lblNumVen.Location = New System.Drawing.Point(417, 8)

                    rel.XrLabel4.Location = New System.Drawing.Point(533, 33)
                    rel.lblVend.Location = New System.Drawing.Point(633, 33)
                    rel.lblVend.Size = New System.Drawing.Size(108, 17)


                End If
                rel.lblNumVen.Text = parOrdem
                rel.lblData.Text = Format(dtPed.Rows.Item(0).Item("Data"), "dd/MM/yyyy")


                Dim strCodFunc As String = dtPed.Rows.Item(0).Item("CodFunc").ToString
                If strCodFunc <> "" Then
                    Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFunc)
                    If dtFunc.Rows.Count > 0 Then
                        rel.lblVend.Text = dtFunc.Rows.Item(0).Item("Nome").ToString
                    Else
                        rel.XrLabel4.Visible = False
                    End If
                Else
                    rel.XrLabel4.Visible = False
                End If

                Dim L As Integer
                Dim dblTotDesc As Double
                Dim dblValor As Double
                Dim dblTotDevolvido As Double = 0
                For L = 0 To dtPed.Rows.Count - 1
                    Dim strCod, strProd, strQtd, strTam As String
                    Dim dblUni, dblTot, dblUniSemDesc, dblTotSemDesc As Double

                    strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                    strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                    dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                    strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
                    dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                    strTam = dtPed.Rows.Item(L).Item("Tamanho").ToString

                    If dtPed.Rows.Item(L).Item("UniSemDesc").ToString <> "" Then
                        dblUniSemDesc = dtPed.Rows.Item(L).Item("UniSemDesc").ToString
                    Else
                        dblUniSemDesc = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                    End If


                    rel.tbItens.Rows.Add()
                    rel.tbItens.Rows.Item(L).Item("CodProd") = strCod
                    rel.tbItens.Rows.Item(L).Item("Produto") = strProd
                    rel.tbItens.Rows.Item(L).Item("Qtde") = strQtd
                    rel.tbItens.Rows.Item(L).Item("Unitario") = dblUni.ToString("0.000")
                    rel.tbItens.Rows.Item(L).Item("Total") = dblTot.ToString("0.00")
                    rel.tbItens.Rows.Item(L).Item("Tamanho") = strTam
                    rel.tbItens.Rows.Item(L).Item("UniSemDesc") = dblUniSemDesc.ToString("0.000")
                    If dblUniSemDesc > 0 Then
                        dblTotDesc = dblTotDesc + (dblUniSemDesc * strQtd)
                    Else
                        dblTotDevolvido = dblTotDevolvido + (dblUniSemDesc * strQtd)
                    End If

                Next
                dblTotDesc = dblTotDesc - dblTotDevolvido
                dblValor = dtPed.Rows.Item(0).Item("Total").ToString

                Dim dblTroco As Double = 0
                If dtPed.Rows.Item(0).Item("Troco").ToString <> "" Then
                    dblTroco = dtPed.Rows.Item(0).Item("Troco").ToString

                End If
                rel.lblTotalSDesc.Text = "0,00"
                Try
                    Dim dtTotSemDesc As DataTable = CarregarDataTable("Select Sum(case when Qtd < 0 then ((Qtd - Qtd) - Qtd) * UniSemDesc else Qtd * UniSemDesc end) as TotalSemDesc " & _
                    " From Pedido where Pedido.CodOrdem = " & parOrdem & " and Pedido.TipoItens <> 'CONSUMO' " & _
                    " and Pedido.CodConfig =" & parConfig)

                    If dtTotSemDesc.Rows.Count > 0 Then
                        Dim dblTolSemDesc As Double = dtTotSemDesc.Rows.Item(0).Item("TotalSemDesc").ToString
                        rel.lblTotalSDesc.Text = dblTolSemDesc.ToString("0.00")
                    End If
                Catch ex As Exception

                End Try

                'If NomeEmpresa.ToString.ToUpper.Contains("BAREX") = False Then
                rel.XrTable1.Visible = True
                If dtPed.Rows.Item(0).Item("ValDesc").ToString <> "0,00" Then
                    rel.lblDesconto.Text = dtPed.Rows.Item(0).Item("ValDesc").ToString
                Else
                    Dim dbl As Double
                    Dim dbl2 As Double = dtPed.Rows.Item(0).Item("Total").ToString

                    dbl = dblTotDesc - dbl2
                    rel.lblDesconto.Text = dbl.ToString("0.00")
                    If dbl < 0 Then
                        rel.XrTableCell1.Text = "Acréscimo R$"
                    End If
                End If
                'End If
                'rel.XrTable1.Visible = False
                'End If
                rel.lblTotal.Text = dtPed.Rows.Item(0).Item("Total").ToString

                If DescontoImpressao = False Then
                    'rel.XrTableRow1.Visible = False
                    'rel.XrTableRow3.Visible = False
                    rel.colUniSemDesc.Visible = False
                    rel.XrTableCell2.Text = ""
                    rel.lblTotalSDesc.Text = ""
                    rel.XrTableCell1.Text = ""
                    rel.lblDesconto.Text = ""
                    rel.lblTotalSDesc.Borders = BorderSide.None
                    rel.XrTableCell2.Borders = BorderSide.None
                    rel.XrTableCell1.Borders = BorderSide.Bottom
                    rel.lblDesconto.Borders = BorderSide.Bottom
                Else
                    If rel.lblTotalSDesc.Text = rel.lblTotal.Text Then
                        rel.XrTableCell2.Text = ""
                        rel.lblTotalSDesc.Text = ""
                        'rel.XrTableRow3.Visible = False
                        rel.colUniSemDesc.Visible = False
                        rel.lblTotalSDesc.Borders = BorderSide.Bottom
                        rel.XrTableCell2.Borders = BorderSide.Bottom
                    End If
                End If
                
                Dim bolTroco As Boolean = False
                Dim P As Integer
                Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor FROM Recebimento where CodOrdem = " & parOrdem & " and CodConfig = " & parConfig & " order by Codigo Desc")
                If dtPag.Rows.Count > 0 Then

                    For P = 0 To dtPag.Rows.Count - 1
                        Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        If strPag = "DINHEIRO" Then
                            If bolTroco = False Then
                                If dblTroco > 0 Then
                                    dblValor = dblValor + dblTroco
                                    bolTroco = True
                                End If
                            End If
                        End If
                        rel.txtTexto.Text &= " " & Dir(strPag, 19) & " R$ " & Esq(dblValor.ToString("0.00"), 9) & vbCrLf
                    Next
                End If



                If dblTroco > 0 Then
                    rel.txtTexto.Text &= " TROCO              " & "R$ " & Esq(dblTroco.ToString("0.00"), 9) & vbCrLf
                End If

                Dim dtCli As DataTable = CarregarDataTable("Select Nome, CPF, RGIE, Endereco, Bairro, Numero, Cidade, Cep, " & _
                "convert(Varchar(10),Nascimento,103) as Nascimento, Fantasia, Email, Telefone, Fax from Cliente where Codigo =" & dtPed.Rows.Item(0).Item("CodCli").ToString)

                If dtCli.Rows.Count > 0 Then
                    If QtdeLoja > 1 Then
                        If NomeEmpresa.ToUpper.Contains("FAMATEX") = True Then
                            rel.lblCli.Text = dtCli.Rows.Item(0).Item("Nome").ToString
                        Else
                            If dtCli.Rows.Item(0).Item("Fantasia").ToString <> "" Then
                                rel.lblCli.Text = dtCli.Rows.Item(0).Item("Fantasia").ToString
                            Else
                                rel.lblCli.Text = dtCli.Rows.Item(0).Item("Nome").ToString
                            End If
                        End If
                    Else
                        rel.lblCli.Text = dtCli.Rows.Item(0).Item("Nome").ToString
                    End If

                    rel.lblCPF.Text = dtCli.Rows.Item(0).Item("CPF").ToString
                    rel.lblEnd.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
                    rel.lblBairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
                    rel.lblNum.Text = dtCli.Rows.Item(0).Item("Numero").ToString
                    rel.lblCidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
                    rel.lblCep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
                    rel.lblRG.Text = dtCli.Rows.Item(0).Item("RGIE").ToString
                    rel.lblNascimento.Text = dtCli.Rows.Item(0).Item("Nascimento").ToString

                    rel.lblWeb.Text = dtCli.Rows.Item(0).Item("Email").ToString
                    rel.lblTel1.Text = dtCli.Rows.Item(0).Item("Telefone").ToString
                    rel.lblTel2.Text = dtCli.Rows.Item(0).Item("Fax").ToString
                End If

                Dim dt As DataTable

                dt = CarregarDataTable("Select Parcelas, ValorParcela, Vencimento, RecebidoOK from ContaReceber where CodOrdem =" & parOrdem & " and CodConfig =" & parConfig)


                Dim J As Integer
                Dim strVenc, strOK, strPar As String
                Dim dblValPar As Double


                For J = 0 To dt.Rows.Count - 1
                    strPar = dt.Rows.Item(J).Item("Parcelas").ToString
                    dblValPar = dt.Rows.Item(J).Item("ValorParcela").ToString
                    strVenc = Format(dt.Rows.Item(J).Item("Vencimento"), "dd/MM/yyyy")
                    strOK = "Sim"

                    If dt.Rows.Item(J).Item("RecebidoOK") = False Then
                        strOK = "Não"
                    End If

                    rel.txtTexto2.Text &= Cent(strPar, 5) & Esq(dblValPar.ToString("0.00"), 16) & Esq(strVenc, 14) & Esq(strOK, 10) & vbCrLf

                Next

                dt = CarregarDataTable("Select Descricao from Config where Codigo =" & parConfig)

                If dt.Rows.Count > 0 Then
                    rel.lblLoja.Text = dt.Rows.Item(0).Item("Descricao").ToString
                End If

                rel.picLogo.Image = LogoTipo

                'OcultarAutorizacao
                If AutorizacaoPedido = False Then
                    rel.lblAutorizacao.Visible = False
                    rel.lblAutorizacaoEmpresa.Visible = False
                Else
                    rel.lblAutorizacao.Text = dtCli.Rows.Item(0).Item("Nome").ToString
                    rel.lblAutorizacaoEmpresa.Text = NomeEmpresa
                    If NomeEmpresa.ToUpper.Contains("DECOR") = False Then
                        rel.lblAutorizacaoEmpresa.Visible = False
                    End If

                End If
                If DescricaoVenda <> "" Then
                    rel.lblDescricaoVenda.Text = DescricaoVenda
                End If


                Dim intCodPedido As Integer = 0
                If dtPed.Rows.Item(0).Item("CodPedido").ToString <> "" And dtPed.Rows.Item(0).Item("CodPedido").ToString <> "0" Then
                    intCodPedido = dtPed.Rows.Item(0).Item("CodPedido")
                    rel.lblPed.Visible = True
                    rel.lblNumPed.Visible = True
                    rel.lblNumPed.Text = intCodPedido
                End If

                If ObsPedidoVenda = True Then
                    
                    Dim dtObsPed As DataTable = CarregarDataTable("Select Descricao from TotalConsig where CodOrdens =" & intCodPedido & " and CodConfig =" & CodConfig)

                    Dim strObsPedido As String = ""

                    If dtObsPed.Rows.Count > 0 Then
                        strObsPedido = dtObsPed.Rows.Item(0).Item("Descricao").ToString
                        rel.lblObsPedido.Text = strObsPedido
                    End If
                End If
                rel.lblTitulo.Text = NomeEmpresa
                rel.lblEndereco.Text = EnderecoEmpresa
                rel.lblFones.Text = TelefoneEmpresa
                rel.ShowPreview()
            End If

        End If



        Return True


    End Function
    Public Shared Function VerificaHelp() As Boolean
        Try
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm") Then
                Return True
                Exit Function
            Else
                Dim wc As New System.Net.WebClient()
                Dim strDebug As String = My.Application.Info.DirectoryPath
                System.IO.File.Delete(strDebug & "\HNC.chm.gz")
                wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/HNC.chm.gz?attredirects=0&d=1", strDebug & "\HNC.chm.gz")
                System.IO.File.Delete(strDebug & "\HelpNanoCommerce.chm")
                descompactaArquivo(strDebug & "\HNC.chm.gz", strDebug & "\HelpNanoCommerce.chm")

                If IO.File.Exists(My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm") Then
                    Return True
                    Exit Function
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function


    Public Shared Function descompactaArquivo(ByVal arquivoOrigem As String, ByVal arquivoDestino As String) As Boolean
        Dim streamFonte As FileStream
        Dim streamDestino As FileStream
        Dim streamCompactado As GZipStream
        Dim streamDescompactado As GZipStream
        ' ----- Compacata o contéudo do arquivo e
        '       guarda o resultado em um novo arquivo
        Try
            streamFonte = New FileStream(arquivoOrigem, FileMode.Open, FileAccess.Read)
            streamDestino = New FileStream(arquivoDestino, FileMode.Create, FileAccess.Write)

            ' ----- Os bytes serão processados através de um decompressor de stream
            streamDescompactado = New GZipStream(streamFonte, CompressionMode.Decompress, True)

            ' ----- Processa os bytes de um arquivo para outro
            Const tamanhoBloco As Integer = 4096
            Dim buffer(tamanhoBloco) As Byte
            Dim bytesLidos As Integer
            Do
                bytesLidos = streamDescompactado.Read(buffer, 0, tamanhoBloco)
                If (bytesLidos = 0) Then Exit Do
                streamDestino.Write(buffer, 0, bytesLidos)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' ----- Fecha todos os arquivos
            streamFonte.Close()
            streamDescompactado.Close()
            streamDestino.Close()
        End Try
    End Function

    Public Shared Function BuscaCNPJ(ByVal parEstado As String, ByVal parCNPJ As String, ByVal parForm As String, ByVal parData As Date) As String
        Dim frmC As New frmConCNPJ
        Select Case parEstado
            Case "SP"
                frmC.wb2.Location = New System.Drawing.Point(6, 53)
                frmC.Size = New System.Drawing.Size(174, 137)
                frmC.wb1.Location = New System.Drawing.Point(44, 7)
                frmC.wb1.Size = New System.Drawing.Size(80, 40)
                frmC.txtLetras.Location = New System.Drawing.Point(6, 53)
                frmC.btnAlterar.Location = New System.Drawing.Point(6, 85)
                frmC.btnOk.Location = New System.Drawing.Point(87, 85)

            Case "RS"
                frmC.wb2.Visible = False
                frmC.Size = New System.Drawing.Size(239, 161)
                frmC.wb1.Location = New System.Drawing.Point(6, 7)
                frmC.wb1.Size = New System.Drawing.Size(220, 65)
                frmC.txtLetras.Location = New System.Drawing.Point(35, 78)
                frmC.btnAlterar.Location = New System.Drawing.Point(35, 110)
                frmC.btnOk.Location = New System.Drawing.Point(116, 110)
            Case "MG"
                frmC.wb2.Visible = False
                frmC.Size = New System.Drawing.Size(320, 158)
                frmC.wb1.Location = New System.Drawing.Point(6, 7)
                frmC.wb1.Size = New System.Drawing.Size(300, 57)
                frmC.txtLetras.Location = New System.Drawing.Point(71, 74)
                frmC.btnAlterar.Location = New System.Drawing.Point(71, 106)
                frmC.btnOk.Location = New System.Drawing.Point(152, 106)
                frmC.wb1.Navigate("http://consultasintegra.fazenda.mg.gov.br/sintegra/")

            Case "MS"
                frmC.wb2.Visible = False
                frmC.Size = New System.Drawing.Size(176, 127)
                frmC.wb1.Location = New System.Drawing.Point(19, 7)
                frmC.wb1.Size = New System.Drawing.Size(130, 25)
                frmC.txtLetras.Location = New System.Drawing.Point(6, 41)
                frmC.btnAlterar.Location = New System.Drawing.Point(6, 73)
                frmC.btnOk.Location = New System.Drawing.Point(87, 73)
                frmC.wb1.Navigate("http://www1.sefaz.ms.gov.br/cadastro/CadastroMsCCI.asp")

            Case "MT"
                frmC.wb2.Visible = False
                frmC.Size = New System.Drawing.Size(218, 161)
                frmC.wb1.Location = New System.Drawing.Point(6, 7)
                frmC.wb1.Size = New System.Drawing.Size(200, 65)
                frmC.txtLetras.Location = New System.Drawing.Point(27, 78)
                frmC.btnAlterar.Location = New System.Drawing.Point(27, 110)
                frmC.btnOk.Location = New System.Drawing.Point(108, 110)
                frmC.wb1.Navigate("https://www.sefaz.mt.gov.br/sid/consulta/infocadastral/consultar/publica")

            Case "CPF"
                frmC.wb2.Visible = False

                'frmC.Size = New System.Drawing.Size(174, 137)
                'frmC.wb1.Location = New System.Drawing.Point(44, 7)
                'frmC.wb1.Size = New System.Drawing.Size(80, 40)
                'frmC.txtLetras.Location = New System.Drawing.Point(6, 53)
                'frmC.btnAlterar.Location = New System.Drawing.Point(6, 85)
                'frmC.btnOk.Location = New System.Drawing.Point(87, 85)


                frmC.Size = New System.Drawing.Size(218, 161)
                frmC.PictureEdit1.Size = New System.Drawing.Size(156, 62)
                frmC.PictureEdit1.Location = New System.Drawing.Point(27, 7)
                frmC.wb1.Location = New System.Drawing.Point(27, 7)
                frmC.txtLetras.Location = New System.Drawing.Point(27, 78)
                frmC.btnAlterar.Location = New System.Drawing.Point(27, 110)
                frmC.btnOk.Location = New System.Drawing.Point(108, 110)

                'frmC.Size = New System.Drawing.Size(1024, 700)
                'frmC.wb1.Location = New System.Drawing.Point(6, 7)
                'frmC.wb1.Dock = DockStyle.Fill
                'frmC.txtLetras.Visible = False
                'frmC.btnAlterar.Visible = False
                'frmC.btnOk.Visible = False

                'frmC.wb1.Navigate("https://servicos.receita.fazenda.gov.br/Servicos/CPF/ConsultaSituacao/ConsultaPublica.asp")
                'frmC.wb1.Navigate("https://www.receita.fazenda.gov.br/Aplicacoes/SSL/ATCTA/CPF/ConsultaSituacao/ConsultaPublica.asp")

                Try
                    My.Computer.Registry.CurrentUser.CreateSubKey("REG_DWORD")
                    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\Main\" & _
                    "FeatureControl\FEATURE_BROWSER_EMULATION", "Nano.exe", "11001", Microsoft.Win32.RegistryValueKind.DWord)

                    My.Computer.Registry.CurrentUser.CreateSubKey("REG_DWORD")
                    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\Main\" & _
                    "FeatureControl\FEATURE_BROWSER_EMULATION", "Nano.vshost.exe", "10001", Microsoft.Win32.RegistryValueKind.DWord)
                Catch ex As Exception
                End Try

                frmC.wb1.ScriptErrorsSuppressed = True

                frmC.wb1.Navigate("https://servicos.receita.fazenda.gov.br/Servicos/CPF/ConsultaSituacao/ConsultaPublicaSonoro.asp?CPF=&NASCIMENTO=")
            Case Else
                frmC.wb2.Visible = False
                frmC.Size = New System.Drawing.Size(188, 100)
                frmC.wb1.Location = New System.Drawing.Point(6, 7)
                frmC.wb1.Size = New System.Drawing.Size(180, 60)
                frmC.btnAlterar.Visible = False
                frmC.txtLetras.Location = New System.Drawing.Point(14, 10)
                frmC.txtLetras.Text = parCNPJ.Replace(".", "").Replace("-", "").Replace("/", "")
                frmC.txtLetras.Enabled = False
                'frmC.btnAlterar.Location = New System.Drawing.Point(14, 108)
                frmC.btnOk.Location = New System.Drawing.Point(50, 42)
                'frmC.wb1.Navigate("http://www.receita.fazenda.gov.br/pessoajuridica/cnpj/cnpjreva/Cnpjreva_solicitacao3.asp")


        End Select
        frmC.dtData = parData
        frmC.strForm = parForm
        frmC.strUF = parEstado
        frmC.strCNPJ = parCNPJ.Replace(".", "").Replace("-", "").Replace("/", "")
        frmC.ShowDialog()

        Return ""
    End Function

    Public Shared Function ConfigurarGrid(ByVal parGrid As DevExpress.XtraGrid.Views.Grid.GridView, _
   ByVal parForm As Form, ByVal parCarregar As Boolean, ByVal parPadrao As DevExpress.XtraEditors.SimpleButton) As Boolean

        Dim I As Integer

        Dim strFormQtd As String = ""
        If parPadrao.Name = "btnPadraoQtd" Then
            strFormQtd = "QTD"
        End If
        If parCarregar = True Then

            If IO.File.Exists(My.Application.Info.DirectoryPath & "\Forms\" & parForm.Name & strFormQtd & ".txt") = True Then
                Dim strCadProduto As String = LerArquivo(My.Application.Info.DirectoryPath & "\Forms\" & parForm.Name & strFormQtd & ".txt", False)

                If strCadProduto <> "" Then
                    parPadrao.Enabled = True
                Else
                    parPadrao.Enabled = False
                End If

                Dim vetCadProduto As Array = Split(strCadProduto, "|")

                Dim A As Integer = 0
                'For I = 0 To vetCadProduto.Length - 1

                '    Dim strColuna As String = vetCadProduto(I)
                '    Dim vetColuna As Array = Split(vetCadProduto(I), ",")

                '    Try

                '        If vetColuna.Length > 1 Then
                '            If vetColuna(1).ToString <> "" Then
                '                Dim bolVisivel As Boolean = vetColuna(1)
                '                parGrid.Columns(vetColuna(0)).Visible = vetColuna(1)

                '                If bolVisivel = True Then
                '                    If vetColuna.Length > 2 Then
                '                        If vetColuna(2).ToString <> "" Then
                '                            parGrid.Columns(vetColuna(0)).VisibleIndex = vetColuna(2)

                '                        End If
                '                    End If
                '                    If vetColuna.Length > 3 Then
                '                        If vetColuna(3).ToString <> "" Then
                '                            parGrid.Columns(vetColuna(0)).SortOrder = vetColuna(3)
                '                        End If
                '                    End If
                '                    If vetColuna.Length > 4 Then
                '                        If vetColuna(4).ToString <> "" Then
                '                            parGrid.Columns(vetColuna(0)).Width = vetColuna(4)
                '                        End If
                '                    End If
                '                End If
                '            End If

                '        End If

                '        A += 1
                '    Catch ex As Exception

                '    End Try

                'Next

                Dim vetColuna2(100) As String

                Dim B As Integer = 0
                Dim C As Integer = 0
                For I = 0 To vetCadProduto.Length - 1

                    Dim strColuna As String = vetCadProduto(I)
                    'If parForm.ToString.Contains("frmComanda") = True Then
                    '    If strColuna.Contains("CodComanda") = True Then
                    '        strColuna = strColuna.Replace("20.25", "8.25")
                    '    End If
                    'End If
                    Dim vetColuna As Array = Split(vetCadProduto(I), ",")

                    Try

                        If vetColuna.Length > 1 Then
                            If vetColuna(1).ToString <> "" Then
                                Dim bolVisivel As Boolean = vetColuna(1)
                                parGrid.Columns(vetColuna(0)).Visible = vetColuna(1)

                                If bolVisivel = True Then
                                    C += 1
                                    If vetColuna.Length > 2 Then
                                        If vetColuna(2).ToString <> "" Then
                                            'parGrid.Columns(vetColuna(0)).VisibleIndex = vetColuna(2)
                                            Dim intCol As Integer = vetColuna(2)
                                            vetColuna2(intCol) = strColuna
                                        End If
                                    End If
                                    If vetColuna.Length > 3 Then
                                        If vetColuna(3).ToString <> "" Then
                                            'parGrid.Columns(vetColuna(0)).SortOrder = vetColuna(3)
                                        End If
                                    End If
                                    If vetColuna.Length > 4 Then
                                        If vetColuna(4).ToString <> "" Then
                                            'parGrid.Columns(vetColuna(0)).Width = vetColuna(4)
                                        End If
                                    End If
                                End If

                                If parForm.ToString.Contains("frmComanda") = False Then
                                    If vetColuna.Length > 7 Then
                                        Dim strNome As String = vetColuna(5).ToString
                                        Dim dblSize As Single = vetColuna(6).ToString.Replace(".", ",")
                                        Dim strStyle As String = vetColuna(7).ToString

                                        Dim fs As FontStyle = FontStyle.Regular
                                        Select Case strStyle
                                            Case "Bold"
                                                fs = FontStyle.Bold
                                            Case "Italic"
                                                fs = FontStyle.Italic
                                            Case "Regular"
                                                fs = FontStyle.Regular
                                            Case "Strikeout"
                                                fs = FontStyle.Strikeout
                                            Case "Underline"
                                                fs = FontStyle.Underline
                                            Case "Bold, Italic"
                                                fs = FontStyle.Bold Or FontStyle.Italic
                                        End Select


                                        parGrid.Columns.Item(vetColuna(0)).AppearanceCell.Font = New Font(strNome, dblSize, fs)
                                        parGrid.Columns.Item(vetColuna(0)).AppearanceHeader.Font = New Font(strNome, dblSize, fs)
                                    End If
                                End If
                            End If

                        End If

                        A += 1
                    Catch ex As Exception

                    End Try

                Next
                C -= 1
                For I = 0 To vetColuna2.Length - 1
                    If C < I Then Exit For
                    If vetColuna2(C - I) = Nothing Then Exit For
                    Dim strColuna As String = vetColuna2(C - I)
                    Dim vetColuna As Array = Split(vetColuna2(C - I), ",")

                    Try

                        If vetColuna.Length > 1 Then
                            If vetColuna(1).ToString <> "" Then
                                Dim bolVisivel As Boolean = vetColuna(1)
                                parGrid.Columns(vetColuna(0)).Visible = vetColuna(1)

                                If bolVisivel = True Then
                                    If vetColuna.Length > 2 Then
                                        If vetColuna(2).ToString <> "" Then
                                            parGrid.Columns(vetColuna(0)).VisibleIndex = 0
                                            parGrid.Columns(vetColuna(0)).Visible = vetColuna(1)

                                        End If
                                    End If
                                    If vetColuna.Length > 3 Then
                                        If vetColuna(3).ToString <> "" Then
                                            parGrid.Columns(vetColuna(0)).SortOrder = vetColuna(3)
                                        End If
                                    End If
                                    If vetColuna.Length > 4 Then
                                        If vetColuna(4).ToString <> "" Then
                                            parGrid.Columns(vetColuna(0)).Width = vetColuna(4)
                                        End If
                                    End If
                                End If

                                If parForm.ToString.Contains("frmComanda") = False Then
                                    If vetColuna.Length > 7 Then
                                        Dim strNome As String = vetColuna(5).ToString
                                        Dim dblSize As Single = vetColuna(6).ToString.Replace(".", ",")
                                        Dim strStyle As String = vetColuna(7).ToString

                                        Dim fs As FontStyle = FontStyle.Regular
                                        Select Case strStyle
                                            Case "Bold"
                                                fs = FontStyle.Bold
                                            Case "Italic"
                                                fs = FontStyle.Italic
                                            Case "Regular"
                                                fs = FontStyle.Regular
                                            Case "Strikeout"
                                                fs = FontStyle.Strikeout
                                            Case "Underline"
                                                fs = FontStyle.Underline
                                            Case "Bold, Italic"
                                                fs = FontStyle.Bold Or FontStyle.Italic
                                        End Select

                                        parGrid.Columns.Item(vetColuna(0)).AppearanceCell.Font = New Font(strNome, dblSize, fs)
                                        parGrid.Columns.Item(vetColuna(0)).AppearanceHeader.Font = New Font(strNome, dblSize, fs)

                                    End If
                                End If
                                
                            End If

                        End If

                        A += 1
                    Catch ex As Exception

                    End Try


                Next

            End If

        Else
            Dim strAjuste As String = ""
            For I = 0 To parGrid.Columns.Count - 1
                Dim strName As String = parGrid.Columns.Item(I).FieldName
                Dim strShort As String = parGrid.Columns.Item(I).SortOrder
                Dim strIndesx As Integer = parGrid.Columns.Item(I).VisibleIndex
                Dim strTamanho As String = parGrid.Columns.Item(I).Width
                Dim bolVisivel As Boolean = parGrid.Columns.Item(I).Visible

                Dim strStyleFonte As String = parGrid.Columns.Item(I).AppearanceCell.Font.Style.ToString
                Dim strNomeFonte As String = parGrid.Columns.Item(I).AppearanceCell.Font.Name.ToString
                Dim strSizeFonte As String = parGrid.Columns.Item(I).AppearanceCell.Font.Size.ToString.Replace(",", ".")

                If I = 0 Then
                    strAjuste = strName & "," & bolVisivel & "," & strIndesx & "," & strShort & "," & strTamanho & "," & strNomeFonte & "," & strSizeFonte & "," & strStyleFonte
                Else
                    strAjuste &= "|" & strName & "," & bolVisivel & "," & strIndesx & "," & strShort & "," & strTamanho & "," & strNomeFonte & "," & strSizeFonte & "," & strStyleFonte
                End If

            Next

            If IO.File.Exists(My.Application.Info.DirectoryPath & "\Forms\" & parForm.Name & strFormQtd & ".txt") = True Then
                IO.File.Delete(My.Application.Info.DirectoryPath & "\Forms\" & parForm.Name & strFormQtd & ".txt")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\Forms") = False Then
                IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Forms")
            End If

            Dim SW As New StreamWriter(My.Application.Info.DirectoryPath & "\Forms\" & parForm.Name & strFormQtd & ".txt")

            SW.WriteLine(strAjuste)
            SW.Close()
            SW.Dispose()
            parPadrao.Enabled = True

            MsgBox("Configurações da grid salva com sucesso!", MsgBoxStyle.Information)

        End If
        Return True
    End Function


   
    Public Shared Function ConfigurarGridPadrao(ByVal parForm As Form, ByVal parPadrao As DevExpress.XtraEditors.SimpleButton) As Boolean
        Dim strFormQtd As String = ""
        If parPadrao.Name = "btnPadraoQtd" Then
            strFormQtd = "QTD"
        End If
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\Forms\" & parForm.Name & strFormQtd & ".txt") = True Then
            IO.File.Delete(My.Application.Info.DirectoryPath & "\Forms\" & parForm.Name & strFormQtd & ".txt")
        End If
        parPadrao.Enabled = False
        MsgBox("Feche a tela e abre-a novamente!", MsgBoxStyle.Information)
        Return True
    End Function
    Public Shared Function playSound(ByVal wavfile As String)

        playSound(wavfile, Nothing, SND_FILENAME Or SND_ASYNC)
        Return Nothing
    End Function

    Public Shared Function NumeroSessaoSat() As String


        Dim intNumSessao As Integer = GerarCodigoOrdensSat()

        If intNumSessao > 999999 Then
            Excluir("DELETE FROM Ordens where Tabela = 'Sat' and CodConfig = " & CodConfig & " and CodEmitente = " & CodConfigECF)
            intNumSessao = 1
        End If

        Inserir("Insert into Ordens (Tabela, Cod, CodConfig, CodEmitente) values('Sat'," & intNumSessao & "," & CodConfig & "," & CodConfigECF & ")")

        Return intNumSessao

    End Function
    Public Shared Function NumeroSessaoSatAtivacao() As String


        Dim intNumSessao As Integer = GerarCodigoOrdens("Sat", CodConfig)

        If intNumSessao > 999999 Then
            Excluir("DELETE FROM Ordens where Tabela = 'Sat' and CodConfig = " & CodConfig)
            intNumSessao = 1
        End If

        Inserir("Insert into Ordens (Tabela, Cod, CodConfig) values('Sat'," & intNumSessao & "," & CodConfig & ")")

        Return intNumSessao

    End Function
    Public Shared Function ValidarCodigoBarraGTIN(ByVal parCodigo As String) As Boolean
        If parCodigo = "" Then
            Return True
        End If
        If parCodigo.Length = 8 Or parCodigo.Length = 12 Or parCodigo.Length = 13 Or parCodigo.Length = 14 Then
            Dim strCodigo As String = parCodigo.Substring(0, parCodigo.Length - 1)
            Dim strDigito As String = parCodigo.Substring(parCodigo.Length - 1, 1)


            Dim I As Integer
            Dim intResul As Integer
            For I = 1 To strCodigo.Length
                Dim strNumero As String = strCodigo.Substring(strCodigo.Length - I, 1)
                If IsNumeric(strNumero) = False Then
                    Return False
                End If
                Dim intNum As Integer = strNumero

                If I Mod 2 <> 0 Then
                    intNum = intNum * 3
                Else
                    intNum = intNum * 1
                End If
                intResul += intNum
            Next

            I = 0

            While I < intResul
                I += 10

            End While

            Dim strDigitoVerificador As String = I - intResul

            If strDigito = strDigitoVerificador Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If
    End Function
    Public Shared Function VerificarPasta(ByVal parPasta As String) As Boolean
        If IO.Directory.Exists(parPasta) = False Then
            IO.Directory.CreateDirectory(parPasta)
        End If
        Return True
    End Function

    Public Shared Function WebService(ByVal parUF As String, ByVal parOperacao As String) As String

        Dim strUrl As String = ""

        Dim strCaminho As String = PastaWebServices & "\WebServices.xml"
        'strCaminho = PastaWebServices & "\WebServices_3.10.xml"

        If VersaoXml = "3.10" Then
            strCaminho = PastaWebServices & "\WebServices_3.10.xml"
        ElseIf VersaoXml = "4.00" Then
            strCaminho = PastaWebServices & "\WebServices_4.00.xml"
        End If

        Dim ds As New DataSet()

        ds.ReadXml(strCaminho)

        Dim I As Integer
        For I = 0 To ds.Tables(0).Rows.Count - 1

            Dim strNome As String = ds.Tables(0).Rows.Item(I).Item("nome").ToString
            Dim strUF As String = ds.Tables(0).Rows.Item(I).Item("uf").ToString
            Dim strU As String = ds.Tables(0).Rows.Item(I).Item("endereco").ToString
            If strNome = parOperacao And strUF = parUF Then
                strUrl = strU
                Exit For
            End If
        Next


        Return strUrl
    End Function

    Public Shared Function GerarCodigoOrdemNFCe(ByVal parTabela As String, ByVal parCodEmitente As String) As String
        'Dim conexao As New SqlConnection(StringDeConexao)

        Dim strSql As String = ""
        Dim strcod As String = ""

        Try

            strSql = "Select max(Cod) as Cod From Ordens where Tabela ='" & parTabela & "' and CodEmitente = " & parCodEmitente & " and StatusEmitente = '" & StatusEmitente & "'"
            Dim dt As DataTable = CarregarDataTable(strSql)

            If dt.Rows.Count > 0 Then
                strcod = dt.Rows.Item(0).Item("Cod").ToString
            End If

            'conexao.Close()
        Catch ex As Exception

        End Try
        Return Val(strcod) + 1
    End Function
    Public Shared Function SelecionarUF(ByVal parCodUF As String) As String
        Dim strCodUF As String = ""
        Select Case parCodUF

            Case "12"
                strCodUF = "AC"

            Case "27"
                strCodUF = "AL"

            Case "16"
                strCodUF = "AP"

            Case "13"
                strCodUF = "AM"

            Case "29"
                strCodUF = "BA"

            Case "23"
                strCodUF = "CE"

            Case "53"
                strCodUF = "DF"

            Case "32"
                strCodUF = "ES"

            Case "GO"
                strCodUF = "52"

            Case "21"
                strCodUF = "MA"

            Case "51"
                strCodUF = "MT"

            Case "50"
                strCodUF = "MS"

            Case "31"
                strCodUF = "MG"

            Case "15"
                strCodUF = "PA"

            Case "25"
                strCodUF = "PB"

            Case "41"
                strCodUF = "PR"

            Case "26"
                strCodUF = "PE"

            Case "22"
                strCodUF = "PI"

            Case "33"
                strCodUF = "RJ"

            Case "24"
                strCodUF = "RN"

            Case "43"
                strCodUF = "RS"

            Case "11"
                strCodUF = "RO"

            Case "14"
                strCodUF = "RR"

            Case "42"
                strCodUF = "SC"

            Case "35"
                strCodUF = "SP"

            Case "28"
                strCodUF = "SE"

            Case "17"
                strCodUF = "TO"

        End Select

        Return strCodUF
    End Function

    Public Shared Function ConverterHexadecimal(ByVal parTexto As String) As String
        Dim strHex As String
        Dim strVal As String

        While parTexto.Length > 0
            strVal = Conversion.Hex(Strings.Asc(parTexto.Substring(0, 1).ToString()))
            parTexto = parTexto.Substring(1, parTexto.Length - 1)
            strHex = strHex & strVal
        End While

        Return strHex.ToLower
    End Function
    Public Shared Function ConverterSHA1(ByVal parTexto As String) As String
        Dim sha As New SHA1CryptoServiceProvider ' declare sha as a new SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte ' and here is a byte variable

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(parTexto) ' covert the password into ASCII code

        bytesToHash = sha.ComputeHash(bytesToHash) ' this is where the magic starts and the encryption begins

        Dim encPassword As String = ""

        For Each b As Byte In bytesToHash
            encPassword += b.ToString("x2")
        Next

        Return encPassword ' boom there goes the encrypted password!

    End Function
    Public Shared Function SelecionarURLQrCode(ByVal parUF As String, ByVal parAmbiente As String) As String
        Dim strURL As String = ""
        Select Case parAmbiente
            Case "1"
                Select Case parUF

                    Case "AC"

                        strURL = "www.sefaznet.ac.gov.br/nfce/qrcode"

                    Case "AL"
                        strURL = "http://nfce.sefaz.al.gov.br/QRCode/consultarNFCe.jsp"

                    Case "AP"
                        strURL = "https://www.sefaz.ap.gov.br/nfce/nfcep.php"

                    Case "AM"
                        strURL = "sistemas.sefaz.am.gov.br/nfceweb/consultarNFCe.jsp?chNFe=1315…."

                    Case "BA"
                        strURL = "http://nfe.sefaz.ba.gov.br/servicos/nfce/modulos/geral/NFCEC_consulta_chave_acesso.aspx"

                    Case "CE"
                        strURL = ""

                    Case "DF"
                        strURL = "http://dec.fazenda.df.gov.br/ConsultarNFCe.aspx"

                    Case "ES"
                        strURL = ""

                    Case "GO"
                        strURL = ""

                    Case "MA"
                        strURL = "http://www.nfce.sefaz.ma.gov.br/portal/consultaNFe.do?method=preFilterCupom&"

                    Case "MT"
                        strURL = "http://www.sefaz.mt.gov.br/nfce/consultanfce"

                    Case "MS"
                        strURL = "http://www.dfe.ms.gov.br/nfce/qrcode"

                    Case "MG"
                        strURL = "https://nfce.fazenda.mg.gov.br/portalnfce/sistema/qrcode.xhtml"

                    Case "PA"
                        strURL = "https://appnfc.sefa.pa.gov.br/portal/view/consultas/nfce/nfceForm.seam"

                    Case "PB"
                        strURL = "http://www.receita.pb.gov.br/nfce"

                    Case "PR"
                        strURL = "http://www.dfeportal.fazenda.pr.gov.br/dfe-portal/rest/servico/consultaNFCe"

                    Case "PE"
                        strURL = "http://nfce.sefaz.pe.gov.br/nfce-web/consultarNFCe"

                    Case "PI"
                        strURL = "http://webas.sefaz.pi.gov.br/nfceweb/consultarNFCe.jsf"

                    Case "RJ"
                        strURL = "http://www4.fazenda.rj.gov.br/consultaNFCe/QRCode"

                    Case "RN"
                        strURL = "http://nfce.set.rn.gov.br/consultarNFCe.aspx"

                    Case "RS"
                        strURL = "https://www.sefaz.rs.gov.br/NFCE/NFCE-COM.aspx"

                    Case "RO"
                        strURL = "http://www.nfce.sefin.ro.gov.br/consultanfce/consulta.jsp"

                    Case "RR"
                        strURL = "https://www.sefaz.rr.gov.br/nfce/servlet/qrcode"

                    Case "SC"
                        strURL = ""

                    Case "SP"
                        strURL = "https://www.nfce.fazenda.sp.gov.br/NFCeConsultaPublica/Paginas/ConsultaQRCode.aspx"

                    Case "SE"
                        strURL = "http://www.nfce.se.gov.br/portal/consultarNFCe.jsp"

                    Case "TO"
                        strURL = ""

                End Select
            Case "2"
                Select Case parUF

                    Case "AC"

                        strURL = "http://hml.sefaznet.ac.gov.br/nfce/qrcode"

                    Case "AL"
                        strURL = "http://nfce.sefaz.al.gov.br/QRCode/consultarNFCe.jsp"

                    Case "AP"
                        strURL = "https://www.sefaz.ap.gov.br/nfcehml/nfce.php"

                    Case "AM"
                        strURL = "homnfce.sefaz.am.gov.br/nfceweb/consultarNFCe.jsp?chNFe=1315…."

                    Case "BA"
                        strURL = "http://hnfe.sefaz.ba.gov.br/servicos/nfce/modulos/geral/NFCEC_consulta_chave_acesso.aspx"

                    Case "CE"
                        strURL = "http://nfceh.sefaz.ce.gov.br/pages/ShowNFCe.html"

                    Case "DF"
                        strURL = "http://dec.fazenda.df.gov.br/ConsultarNFCe.aspx"

                    Case "ES"
                        strURL = "http://homologacao.sefaz.es.gov.br/ConsultaNFCe/qrcode.aspx"

                    Case "GO"
                        strURL = ""

                    Case "MA"
                        strURL = "http://www.hom.nfce.sefaz.ma.gov.br/portal/consultarNFCe.jsp"

                    Case "MT"
                        strURL = "http://homologacao.sefaz.mt.gov.br/nfce/consultanfce"

                    Case "MS"
                        strURL = "http://www.dfe.ms.gov.br/nfce/qrcode"

                    Case "MG"
                        strURL = "https://nfce.fazenda.mg.gov.br/portalnfce/sistema/qrcode.xhtml"

                    Case "PA"
                        strURL = "https://appnfc.sefa.pa.gov.br/portal-homologacao/view/consultas/nfce/nfceForm.seam"

                    Case "PB"
                        strURL = "http://www.receita.pb.gov.br/nfcehom"

                    Case "PR"
                        strURL = "http://www.dfeportal.fazenda.pr.gov.br/dfe-portal/rest/servico/consultaNFCe"

                    Case "PE"
                        strURL = "http://nfcehomolog.sefaz.pe.gov.br/nfce-web/consultarNFCe"

                    Case "PI"
                        strURL = "http://webas.sefaz.pi.gov.br/nfceweb-homologacao/consultarNFCe.jsf"

                    Case "RJ"
                        strURL = "http://www4.fazenda.rj.gov.br/consultaNFCe/QRCode"

                    Case "RN"
                        strURL = "http://hom.nfce.set.rn.gov.br/consultarNFCe.aspx"

                    Case "RS"
                        strURL = "https://www.sefaz.rs.gov.br/NFCE/NFCE-COM.aspx"

                    Case "RO"
                        strURL = "http://www.nfce.sefin.ro.gov.br/consultanfce/consulta.jsp"

                    Case "RR"
                        strURL = "http://200.174.88.103:8080/nfce/servlet/qrcode"

                    Case "SC"
                        strURL = ""

                    Case "SP"
                        strURL = "https://www.homologacao.nfce.fazenda.sp.gov.br/NFCeConsultaPublica/Paginas/ConsultaQRCode.aspx"

                    Case "SE"
                        strURL = "http://www.hom.nfe.se.gov.br/portal/consultarNFCe.jsp"

                    Case "TO"
                        strURL = ""

                End Select
        End Select


        Return strURL
    End Function
    Public Shared Function CorrigirUnidadeMedida(ByVal parUnidade As String) As String
        Dim strUM As String = parUnidade
        Select Case strUM
            Case "UNIDADE", "UN"
                strUM = "UN"
            Case "JOGO", "JG"
                strUM = "JG"
            Case "KIT", "KT"
                strUM = "KT"
            Case "PESO", "KG"
                strUM = "KG"
            Case "LÍTRO", "LT"
                strUM = "LT"
            Case "METRO", "MT"
                strUM = "MT"
            Case "HORA", "HR"
                strUM = "HR"
            Case "PAR", "PR"
                strUM = "PR"
            Case Else
                If strUM.Length = 2 Then
                    strUM = strUM
                Else
                    strUM = "UN"
                End If

        End Select
        Return strUM
    End Function

    Public Shared Function CarregarEmitenteNFe() As String
        Dim I As Integer
        Dim strCodigoEmitente As String = "1"
        Dim dtConfig As DataTable = CarregarDataTable("SELECT EmitentePadrao FROM Config WHERE Codigo = " & CodConfig)
        If dtConfig.Rows.Count > 0 Then
            If dtConfig.Rows.Item(0).Item("EmitentePadrao").ToString <> "" Then
                strCodigoEmitente = dtConfig.Rows.Item(0).Item("EmitentePadrao").ToString
            End If
        End If

        Dim dtPadrao As DataTable = CarregarDataTable("SELECT Codigo FROM ConfigNFe where Padrao = 'True'")
        Select Case dtPadrao.Rows.Count
            Case 1
                CodEmitente = dtPadrao.Rows.Item(0).Item("Codigo").ToString
            Case Else
                CodEmitente = strCodigoEmitente
        End Select

        RegimeSAT = "SIMPLES NACIONAL"

        Dim dt As DataTable = CarregarDataTable("SELECT CRT FROM ConfigNfe where Codigo = " & CodEmitente)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("CRT").ToString = "3" Then
                RegimeSAT = "TRIBUTAÇÃO NORMAL"
            End If
        End If


    End Function
    Public Shared Function CarregarDadosTEF() As Boolean
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, IP, NumCaixa, Computador, CodConfig, NomeAd FROM ConfigTEF " & _
        "where Computador = '" & My.Computer.Name.ToUpper & "' and CodConfig = " & CodConfig)

        If dt.Rows.Count > 0 Then

            IP = dt.Rows.Item(0).Item("IP").ToString
            CaixaTEF = dt.Rows.Item(0).Item("NumCaixa").ToString
            CodigoTerminal = dt.Rows.Item(0).Item("Codigo").ToString

            NomeAd = dt.Rows.Item(0).Item("NomeAd").ToString
            If IP = "" Then
                Try
                    Dim strHostName As String = System.Net.Dns.GetHostName()

                    Dim ipEntry As Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

                    Dim addr As Net.IPAddress() = ipEntry.AddressList

                    IP = addr(addr.Length - 1).ToString()
                Catch ex As Exception

                End Try
            End If
            TEF = True
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function ImpComandaApp()
        If TemImpressora = False Then Exit Function

        Dim dtPorta As DataTable = CarregarDataTable("SELECT PortaImpressora, Impressora FROM (Comanda left join Produto " & _
        "on Comanda.CodProd = Produto.Codigo)Left join Grupo on Grupo.Nome = Produto.Grupo where ImpOk = 'False' and Comanda.Tipo ='COMANDA' AND Comanda.Status ='Aberto' AND CodConfig =" & CodConfig & " and PortaImpressora <> '' " & _
        "group by PortaImpressora, Impressora")


        Dim I As Integer
        Dim A As Integer

        Dim CodComanda As String = ""

        For I = 0 To dtPorta.Rows.Count - 1

            Dim strPorta As String = dtPorta.Rows.Item(I).Item("PortaImpressora").ToString
            Dim strModImpressora As String = dtPorta.Rows.Item(I).Item("Impressora").ToString


            Dim dtItens As DataTable = CarregarDataTable("SELECT Comanda.Codigo, Comanda.CodProd, Comanda.CodProdInterno, " & _
            "Comanda.Produto, Comanda.Qtd, Comanda.ValorUnitario, (Comanda.Qtd * Comanda.ValorUnitario) as ValorTotal, " & _
            "Comanda.Misto, Comanda.Opcoes, Comanda.Obs, CodComanda, Comanda.CodOrdens, Comanda.CodFunc FROM (Comanda left join Produto on Comanda.CodProd = Produto.Codigo)" & _
            "Left join Grupo on Grupo.Nome = Produto.Grupo where ImpOk = 'False' " & _
            "and Comanda.Tipo ='COMANDA' AND Comanda.Status = 'Aberto' AND App = 'True' AND Comanda.CodConfig =" & CodConfig & " and PortaImpressora = '" & strPorta & "' and " & _
            "Impressora = '" & strModImpressora & "'")

            Dim strQtdePessoasMesa As String = ""
            Dim strObsComanda As String = ""
            If dtItens.Rows.Count > 0 Then
                For B As Integer = 0 To dtItens.Rows.Count - 1
                    CodComanda = dtItens.Rows.Item(B).Item("CodComanda").ToString
                    Dim strComandaOrdens As String = dtItens.Rows.Item(B).Item("CodOrdens").ToString
                    Dim CodFunc As String = dtItens.Rows.Item(B).Item("CodFunc").ToString

                    Dim dtCom As DataTable = CarregarDataTable("SELECT COO as Obs, ValorPago as Qtd FROM R7 where CodUser = " & strComandaOrdens & " and CodConfig = " & CodConfig)
                    If dtCom.Rows.Count > 0 Then
                        strQtdePessoasMesa = dtCom.Rows.Item(0).Item("Qtd").ToString
                        strObsComanda = dtCom.Rows.Item(0).Item("Obs").ToString
                    End If

                    Dim dtItens2 As DataTable = CarregarDataTable("SELECT Comanda.Codigo, Comanda.CodProd, Comanda.CodProdInterno, " & _
            "Comanda.Produto, Comanda.Qtd, Comanda.ValorUnitario, (Comanda.Qtd * Comanda.ValorUnitario) as ValorTotal, " & _
            "Comanda.Misto, Comanda.Opcoes, Comanda.Obs, CodComanda, Comanda.CodOrdens, Comanda.CodFunc FROM (Comanda left join Produto on Comanda.CodProd = Produto.Codigo)" & _
            "Left join Grupo on Grupo.Nome = Produto.Grupo where ImpOk = 'False' " & _
            "and Comanda.Tipo ='COMANDA' AND Comanda.Status = 'Aberto' AND App = 'True' AND Comanda.CodConfig =" & CodConfig & " and PortaImpressora = '" & strPorta & "' and " & _
            "Impressora = '" & strModImpressora & "' And CodComanda=" & CodComanda)

                    If strModImpressora.Contains("ESC/POS") = True Then

                        Dim strImpressao As String = ""

                        strIgual = CompComanda("=======================================================", strModImpressora)
                        strTraco = CompComanda("-------------------------------------------------------", strModImpressora)

                        strImpressao = CentralizarComanda(NegComanda(NomeEmpresa.ToString.Trim, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
                        strImpressao &= strIgual & vbCrLf & vbCrLf

                        strImpressao &= CentralizarComanda(ExpComanda("Comanda/Mesa: " & CodComanda, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
                        strImpressao &= strIgual & vbCrLf

                        strImpressao &= Dir("CODIGO                                              QTD", 55) & vbCrLf
                        strImpressao &= "DESCRICAO                                              " & vbCrLf

                        strImpressao &= strTraco & vbCrLf

                        For A = 0 To dtItens2.Rows.Count - 1
                            Dim strCod As String = dtItens2.Rows.Item(A).Item("CodProdInterno").ToString
                            Dim strQtd As String = dtItens2.Rows.Item(A).Item("Qtd").ToString
                            Dim bolMisto As Boolean = dtItens2.Rows.Item(A).Item("Misto")
                            Dim strProduto As String = dtItens2.Rows.Item(A).Item("Produto").ToString
                            Dim strOpcoes As String = dtItens2.Rows.Item(A).Item("Opcoes").ToString
                            Dim strObs As String = dtItens2.Rows.Item(A).Item("Obs").ToString
                            strImpressao &= Dir(strCod, 20) & Esq(strQtd, 35) & vbCrLf

                            If bolMisto = True Then
                                Dim P As Integer

                                Dim vetProd As Array = Split(strProduto, "|")

                                strProduto = ""

                                For P = 0 To vetProd.Length - 1
                                    If vetProd(P).ToString <> "" Then
                                        strProduto &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                                    End If
                                Next
                                strProduto = Mid(strProduto, 1, strProduto.Length - 3)
                            End If

                            strImpressao &= Dir(strProduto, 55) & vbCrLf


                            If bolMisto = True Then

                                Dim P As Integer

                                If strOpcoes.Trim <> "" Then

                                    Dim strOpci As String = strOpcoes

                                    Dim vetOpc As Array = Split(strOpci, "|")

                                    For P = 0 To vetOpc.Length - 1
                                        strOpci = vetOpc(P).ToString
                                        'strImpressao &= Dir("Opc. " & P + 1 & ": " & strOpci, 55) & vbCrLf
                                        strImpressao &= Dir(strOpci, 55) & vbCrLf
                                    Next

                                End If

                                If strObs <> "" Then
                                    strImpressao &= Dir("OBSERVAÇÃO: " & strObs, 55) & vbCrLf
                                End If
                            End If

                            'If strObs <> "" Then
                            '    strImpressao &= Dir("OBSERVAÇÃO: " & strObs, 55) & vbCrLf
                            'End If
                        Next




                        If strObsComanda <> "" Then
                            strImpressao &= strTraco & vbCrLf

                            strImpressao &= "OBSERVAÇÃO: " & strObsComanda & vbCrLf
                        End If
                        'If GerarComissao = True Then
                        'If Me.txtComan.Text.Trim <> "" And strCodigoOrdem <> "" Then
                        Dim dtFunc As DataTable = CarregarDataTable("SELECT funcionario.Nome FROM Funcionario where Funcionario.Codigo =  " & CodFunc)
                        If dtFunc.Rows.Count > 0 Then

                            strImpressao &= strTraco & vbCrLf
                            strImpressao &= Dir("Atend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
                        End If
                        'End If
                        'End If

                        strImpressao &= strTraco & vbCrLf
                        strImpressao &= CentralizarComanda(My.Computer.Clock.LocalTime, strModImpressora) & vbCrLf

                        RodapeComanda(strImpressao, strModImpressora, strPorta)

                    ElseIf strModImpressora.Contains("BEMATECH") Or strModImpressora.Contains("ARQUIVO") Or strModImpressora.Contains("NANO PRINT") Then
                        Dim strImpressao As String

                        Dim intTamEsp As Integer
                        Dim strEstrela, strTraço As String

                        intTamEsp = 42
                        strEstrela = "******************************************"
                        strTraço = "------------------------------------------"

                        strImpressao = Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf & vbCrLf

                        strImpressao &= strEstrela & vbCrLf & vbCrLf
                        strImpressao &= Cent("Comanda/Mesa: " & CodComanda, intTamEsp) & vbCrLf & vbCrLf
                        strImpressao &= strEstrela & vbCrLf

                        strImpressao &= "CODIGO                                 QTD" & vbCrLf
                        strImpressao &= "DESCRICAO                                 " & vbCrLf

                        strImpressao &= strTraço & vbCrLf
                        For A = 0 To dtItens2.Rows.Count - 1
                            Dim strCod As String = dtItens2.Rows.Item(A).Item("CodProdInterno").ToString
                            Dim strQtd As String = dtItens2.Rows.Item(A).Item("Qtd").ToString
                            Dim bolMisto As Boolean = dtItens2.Rows.Item(A).Item("Misto")
                            Dim strProduto As String = dtItens2.Rows.Item(A).Item("Produto").ToString
                            Dim strOpcoes As String = dtItens2.Rows.Item(A).Item("Opcoes").ToString
                            Dim strObs As String = dtItens2.Rows.Item(A).Item("Obs").ToString

                            strImpressao &= Dir(strCod, 20) & Esq(strQtd, 22) & vbCrLf

                            If bolMisto = True Then
                                Dim P As Integer

                                Dim vetProd As Array = Split(strProduto, "|")

                                strProduto = ""

                                For P = 0 To vetProd.Length - 1
                                    If vetProd(P).ToString <> "" Then
                                        strProduto &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                                    End If
                                Next
                                strProduto = Mid(strProduto, 1, strProduto.Length - 3)
                            End If

                            strImpressao &= strProduto & vbCrLf


                            If bolMisto = True Then

                                Dim P As Integer

                                If strOpcoes.Trim <> "" Then

                                    Dim strOpci As String = strOpcoes

                                    Dim vetOpc As Array = Split(strOpci, "|")

                                    For P = 0 To vetOpc.Length - 1
                                        strOpci = vetOpc(P).ToString
                                        strImpressao &= strOpci & vbCrLf
                                    Next

                                End If

                                If strObs <> "" Then
                                    strImpressao &= "OBSERVAÇÃO: " & strObs & vbCrLf
                                End If
                            End If

                            'If strObs <> "" Then
                            '    strImpressao &= "OBSERVAÇÃO: " & strObs & vbCrLf
                            'End If
                        Next




                        If strObsComanda <> "" Then
                            strImpressao &= strTraço & vbCrLf
                            strImpressao &= "OBSERVAÇÃO: " & strObsComanda & vbCrLf
                        End If

                        'If GerarComissao = True Then
                        'If Me.txtComan.Text.Trim <> "" And strCodigoOrdem <> "" Then
                        Dim dtFunc As DataTable = CarregarDataTable("SELECT funcionario.Nome FROM Funcionario where Funcionario.Codigo =  " & CodFunc)
                        If dtFunc.Rows.Count > 0 Then

                            strImpressao &= strTraço & vbCrLf
                            strImpressao &= "ATEND.: " & dtFunc.Rows.Item(0).Item("Nome").ToString & vbCrLf
                        End If
                        'End If
                        'End If

                        strImpressao &= strTraco & vbCrLf
                        strImpressao &= Cent(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf

                        strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")

                        strImpressao = RetiraAcentos(strImpressao)

                        If strModImpressora = "ARQUIVO" Then
                            strImpressao += Avanco() & vbCrLf

                            If TemGuilhotina = True Then
                                strImpressao += Corte() & vbCrLf
                            End If
                            SendStringToPrinter(strPorta, strImpressao)
                            'EscreveArquivo(strPorta & "\" & My.Computer.Name & ".txt", strImpressao)
                            'ImprimiArquivo(strImpressao, strPorta)

                        ElseIf strModImpressora.Contains("NANO PRINT") = True Then
                            If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                                ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                            Else
                                EscreveArquivo(strPorta & "\" & My.Computer.Name & ".txt", strImpressao)
                            End If
                        Else
                            If strModImpressora.Contains("MP-4000") Then
                                iRetorno = ConfiguraModeloImpressora(5)
                                iRetorno = SelecionaQualidadeImpressao(3)
                            Else
                                iRetorno = ConfiguraModeloImpressora(1)
                            End If
                            iRetorno = clsBematech.IniciaPorta(strPorta)


                            iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                            If TemGuilhotina = True Then
                                iRetorno = clsBematech.AcionaGuilhotina(0)
                            End If
                        End If

                    ElseIf strModImpressora = "EPSON" Then
                        Dim strImpressao As String

                        Dim intTamEsp As Integer
                        Dim strEstrela, strTraço As String

                        strEstrela = clsImprimir.Comp("************************************************")
                        strTraço = clsImprimir.Comp("------------------------------------------------")

                        strImpressao = "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf & vbCrLf

                        strImpressao &= strEstrela & vbCrLf & vbCrLf
                        strImpressao &= "<ce>" & "Comanda/Mesa: " & CodComanda & "</ce>" & vbCrLf & vbCrLf
                        strImpressao &= strEstrela & vbCrLf

                        strImpressao &= "CODIGO                                 QTD" & vbCrLf
                        strImpressao &= "DESCRICAO                                 " & vbCrLf

                        strImpressao &= strTraço & vbCrLf
                        For A = 0 To dtItens2.Rows.Count - 1
                            Dim strCod As String = dtItens2.Rows.Item(A).Item("CodProdInterno").ToString
                            Dim strQtd As String = dtItens2.Rows.Item(A).Item("Qtd").ToString
                            Dim bolMisto As Boolean = dtItens2.Rows.Item(A).Item("Misto")
                            Dim strProduto As String = dtItens2.Rows.Item(A).Item("Produto").ToString
                            Dim strOpcoes As String = dtItens2.Rows.Item(A).Item("Opcoes").ToString
                            Dim strObs As String = dtItens2.Rows.Item(A).Item("Obs").ToString
                            strImpressao &= Dir(strCod, 37) & Esq(strQtd, 11) & vbCrLf

                            If bolMisto = True Then
                                Dim P As Integer

                                Dim vetProd As Array = Split(strProduto, "|")

                                strProduto = ""

                                For P = 0 To vetProd.Length - 1
                                    If vetProd(P).ToString <> "" Then
                                        strProduto &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                                    End If
                                Next
                                strProduto = Mid(strProduto, 1, strProduto.Length - 3)
                            End If

                            strImpressao &= strProduto & vbCrLf


                            If bolMisto = True Then

                                Dim P As Integer

                                If strOpcoes.Trim <> "" Then

                                    Dim strOpci As String = strOpcoes

                                    Dim vetOpc As Array = Split(strOpci, "|")

                                    For P = 0 To vetOpc.Length - 1
                                        strOpci = vetOpc(P).ToString
                                        strImpressao &= strOpci & vbCrLf
                                    Next

                                End If

                                If strObs <> "" Then
                                    strImpressao &= "OBSERVAÇÃO: " & strObs & vbCrLf
                                End If
                            End If

                        Next


                        strImpressao &= strTraço & vbCrLf
                        If strObsComanda <> "" Then
                            strImpressao &= "OBSERVAÇÃO: " & strObsComanda & vbCrLf
                        End If

                        strImpressao &= strTraco & vbCrLf
                        strImpressao &= "<ce>" & My.Computer.Clock.LocalTime & "</ce>" & vbCrLf

                        strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")



                        iRetorno = clsEpson.IniciaPorta(strPorta)

                        iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                        If TemGuilhotina = True Then
                            iRetorno = clsEpson.AcionaGuilhotina(1)
                        End If

                        iRetorno = clsEpson.FechaPorta()

                    End If

                    If CodComanda <> "" Then
                        Atualizar("UPDATE Comanda set ImpOk = 'True' FROM (Comanda left join Produto on Comanda.CodProd = Produto.Codigo)" & _
                        "Left join Grupo on Grupo.Nome = Produto.Grupo where CodComanda = '" & CodComanda.Trim & "' and ImpOk = 'False' " & _
                        "and Comanda.Tipo ='COMANDA' AND Comanda.CodConfig =" & CodConfig & " and PortaImpressora = '" & strPorta & "' and " & _
                        "Impressora = '" & strModImpressora & "'")
                    End If

                Next
                
            End If

            'If CodComanda <> "" Then
            '    Atualizar("UPDATE Comanda set ImpOk = 'True' FROM (Comanda left join Produto on Comanda.CodProd = Produto.Codigo)" & _
            '    "Left join Grupo on Grupo.Nome = Produto.Grupo where CodComanda = '" & CodComanda.Trim & "' and ImpOk = 'False' " & _
            '    "and Comanda.Tipo ='COMANDA' AND Comanda.CodConfig =" & CodConfig & " and PortaImpressora = '" & strPorta & "' and " & _
            '    "Impressora = '" & strModImpressora & "'")
            'End If

        Next
    End Function

    Public Shared Function ImpTotalComandaApp()

        'VERIFICA QUAL COMANDA SERÁ IMPRESSA
        Dim dtImpApp As DataTable = CarregarDataTable("SELECT Comanda.Tempo, Comanda.Tipo FROM Comanda Where Comanda.Tipo ='COMANDA' AND Comanda.Status = 'Aberto' And Tempo like '%|%' And Comanda.CodConfig =" & CodConfig)
        Dim strImp As String = ""
        Dim strTipoComanda As String = ""

        If dtImpApp.Rows.Count > 0 Then
            strImp = dtImpApp.Rows.Item(0).Item("Tempo").ToString()
            strTipoComanda = dtImpApp.Rows.Item(0).Item("Tipo").ToString()
        Else
            Exit Function
        End If

        Dim vetImp As String() = strImp.Split("|")
        Dim strComanda As String = vetImp(0)
        Dim strPorta As String = vetImp(1)


        'CARREGA TIPO DE IMPRESSÃO
        Dim dtImpressora = CarregarDataTable("SELECT Impressora FROM Grupo WHERE PortaImpressora = '" & strPorta & "' " & _
        " UNION SELECT Impressora FROM Config WHERE Codigo = " & CodConfig & " AND Porta = '" & strPorta & "'")

        Dim strImpressora As String = ""
        If dtImpressora.Rows.Count > 0 Then
            strImpressora = dtImpressora.Rows.Item(0).Item("Impressora").ToString()
        Else
            strImpressora = "ARQUIVO"
        End If


        'CARREGA DADOS DA COMANDA
        Dim dtComanda As DataTable = CarregarDataTable("SELECT Comanda.Codigo, Comanda.CodProd, Comanda.CodProdInterno, " & _
            " Comanda.Produto, Comanda.Qtd, Comanda.ValorUnitario, Comanda.Misto, Comanda.Opcoes, " & _
            " Comanda.Obs, CodComanda, Comanda.Nome, Comanda.CodCli, Comanda.CodOrdens FROM Comanda Where CodComanda = '" & strComanda & "' And " & _
            " Comanda.Status = 'Aberto' And CodConfig = " & CodConfig)


        'CARREGA VALOR TOTAL DA COMANDA 
        Dim dtTotal As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,3), Sum((Comanda.Qtd * Comanda.ValorUnitario))) As Total " & _
            " FROM Comanda Where CodComanda = '" & strComanda & "' And Comanda.Status = 'Aberto' And CodConfig = " & CodConfig)

        Dim dblTotal As Double = dtTotal.Rows.Item(0).Item("Total").ToString()
        Dim strTotalGeral = dblTotal.ToString("0.00")


        Dim strComandaOrdens As String = dtComanda.Rows.Item(0).Item("CodOrdens").ToString
        Dim strQtdePessoasMesa As String = ""
        Dim strObsComanda As String = ""
        Dim dtCom As DataTable = CarregarDataTable("SELECT COO as Obs, ValorPago as Qtd FROM R7 where CodUser = " & strComandaOrdens & " and CodConfig = " & CodConfig)
        If dtCom.Rows.Count > 0 Then
            strQtdePessoasMesa = dtCom.Rows.Item(0).Item("Qtd").ToString
            strObsComanda = dtCom.Rows.Item(0).Item("Obs").ToString
        End If

        If strImpressora.Contains("ESC/POS") = True Then
            Dim strImpressao As String

            strImpressao = Cabecalho()

            strImpressao &= Esq(My.Computer.Clock.LocalTime, 55) & vbCrLf & vbCrLf

            strImpressao &= CentralizarComanda(ExpComanda("COMANDA/MESA: " & strComanda.Trim, strImpressora), strImpressora) & vbCrLf
            strImpressao &= strTraco & vbCrLf


            'CARREGA DADOS DO CLIENTE
            Dim strCliente As String = dtComanda.Rows.Item(0).Item("Nome").ToString
            Dim intCodCli As Integer = dtComanda.Rows.Item(0).Item("CodCli").ToString

            If strCliente <> "CONSUMIDOR" Then
                Dim strEnd, strTel As String

                Dim dtCli As DataTable = CarregarDataTable("SELECT Endereco, Telefone FROM Cliente Where Codigo = " & intCodCli)
                If dtCli.Rows.Count > 0 Then
                    strEnd = dtCli.Rows.Item(0).Item("Endereco").ToString
                    strTel = dtCli.Rows.Item(0).Item("Telefone").ToString
                End If

                strImpressao &= Dir("Cliente.: " & strCliente, 55) & vbCrLf
                strImpressao &= Dir("Endereco: " & strEnd, 55) & vbCrLf
                strImpressao &= Dir("Telefone: " & strTel, 55) & vbCrLf
                strImpressao &= strTraco & vbCrLf
            End If


            strImpressao &= Dir("CÓDIGO    DESCRICAO", 55) & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$                   VL TOTAL R$", 55) & vbCrLf
            strImpressao &= strTraco & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            Dim dblResulTaxa As Double
            Dim dblValTot As Double
            For L = 0 To dtComanda.Rows.Count - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                Dim item As Integer = L + 1

                strCod = item & "  " & dtComanda.Rows.Item(L).Item("CodProdInterno").ToString
                strProd = dtComanda.Rows.Item(L).Item("Produto").ToString
                strUni = dtComanda.Rows.Item(L).Item("ValorUnitario").ToString
                strQtd = dtComanda.Rows.Item(L).Item("Qtd").ToString
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")


                dblQtd += dtComanda.Rows.Item(L).Item("Qtd").ToString

                'CARREGAR GRUPO PRODUTO
                Dim dtGrupo As DataTable = CarregarDataTable("Select Grupo From Produto Where Codigo=" & dtComanda.Rows.Item(L).Item("CodProd").ToString)
                Dim strGrupo As String = ""
                If dtGrupo.Rows.Count > 0 Then
                    strGrupo = dtGrupo.Rows.Item(0).Item("Grupo").ToString
                    If strGrupo <> "SEM DEZ PORCENTO" Then
                        dblResulTaxa = dblResulTaxa + (CDbl(strQtd) * CDbl(strUni))
                    End If
                End If

                Dim P As Integer = 0

                Dim bolMisto As Boolean = CBool(dtComanda.Rows.Item(L).Item("Misto").ToString)
                If bolMisto = True Then

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                Dim strItem As String

                strItem = strCod & "   " & strProd

                If strItem.Length > 55 Then
                    strItem = Mid(strItem, 1, 55)
                End If

                strImpressao &= Dir(strItem, 55) & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 44) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If bolMisto = True Then
                    If dtComanda.Rows.Item(L).Item("Opcoes").ToString <> "" Then

                        Dim strOpci As String = dtComanda.Rows.Item(L).Item("Opcoes").ToString.Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= Dir(strOpci, 55) & vbCrLf
                        Next

                    End If

                    If dtComanda.Rows.Item(L).Item("Obs").ToString <> "" Then
                        strImpressao &= Dir("OBSERVAÇÃO: " & dtComanda.Rows.Item(L).Item("Obs").ToString.Trim, 55) & vbCrLf
                    End If

                    strImpressao &= strTraco.Replace("-", ".") & vbCrLf
                End If

            Next

            Dim dblVal, dblTaxa, dblGeral As Double
            dblVal = strTotalGeral

            strImpressao &= strTraco & vbCrLf
            If DezPorcento = True Then
                If strTipoComanda = "COMANDA" Then
                    strImpressao &= Esq("Total........: R$ ", 45) & Esq(strTotalGeral.Trim, 10) & vbCrLf
                    dblTaxa = ((dblResulTaxa / 100) * 10)
                    strImpressao &= Esq("Taxa 10%.....: R$ ", 45) & Esq(dblTaxa.ToString("0.00"), 10) & vbCrLf
                End If
            End If

            If DezPorcento = True Then
                dblGeral = dblVal + dblTaxa
                strImpressao &= Esq("Total Geral..: R$ ", 45) & Esq(dblGeral.ToString("0.00"), 10) & vbCrLf
            Else
                strImpressao &= Esq("Total Geral..: R$ ", 45) & Esq(strTotalGeral, 10) & vbCrLf
            End If

            strImpressao &= " " & vbCrLf
            If strQtdePessoasMesa <> "0" And strQtdePessoasMesa <> "" Then
                strImpressao &= Dir("Qtde Pessoas: " & strQtdePessoasMesa, 55) & vbCrLf
                Dim dblValorPessoa As Double = CDbl(dblTotal) / CDbl(strQtdePessoasMesa)
                strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If strObsComanda <> "" Then
                strImpressao &= "OBSERVAÇÃO: " & strObsComanda
                strImpressao &= " " & vbCrLf
            End If

            'If strTipoComanda = "ENTREGAR" Then
            '    strImpressao &= strTraco & vbCrLf
            '    strImpressao &= Dir("DODOS DE ENTREGA", 55) & vbCrLf
            '    strImpressao &= Dir("Entregador: " & Me.cboEnt.Text.Trim, 55) & vbCrLf
            '    strImpressao &= Dir("Troco R$..: " & Me.txtTroco.Text.Trim, 55) & vbCrLf
            '    strImpressao &= Dir("Tempo.....: " & Me.cboTempo.Text.Trim, 55) & vbCrLf & vbCrLf
            '    If Me.rdgMaqCartao.SelectedIndex = 1 Then
            '        strImpressao &= Dir("LEVAR MÁQUINA DE CARTÃO" & Me.cboTempo.Text.Trim, 55) & vbCrLf
            '    End If
            'Else

            strImpressao &= GerarBarCode(strComanda.Trim) & vbCrLf

            'End If


            RodapeComanda(strImpressao, strImpressora, strPorta)

            Atualizar("UPDATE Comanda set Tempo='' Where CodComanda = '" & strComanda & "' And " & _
                            " Comanda.Status = 'Aberto' And CodConfig = " & CodConfig)

        ElseIf strImpressora.Contains("BEMATECH") Or strImpressora.Contains("ARQUIVO") Or strImpressora.Contains("NANO PRINT") Then

            Dim strImpressao As String

            Dim intTamEsp As Integer
            Dim strEstrela, strTraço As String

            If Impressora = "ARQUIVO" Then
                intTamEsp = 42
                strEstrela = "******************************************"
                strTraço = "------------------------------------------"
            Else
                intTamEsp = 60
                strEstrela = "************************************************************"
                strTraço = "------------------------------------------------------------"
            End If

            strImpressao = strEstrela & vbCrLf

            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= Esq(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf & vbCrLf
            strImpressao &= Cent("COMANDA/MESA:  " & strComanda.Trim, intTamEsp) & vbCrLf & vbCrLf
            strImpressao &= strTraço & vbCrLf


            'CARREGA DADOS DO CLIENTE
            Dim strCliente As String = dtComanda.Rows.Item(0).Item("Nome").ToString
            Dim intCodCli As Integer = dtComanda.Rows.Item(0).Item("CodCli").ToString

            If strCliente <> "CONSUMIDOR" Then
                Dim strEnd, strTel As String

                Dim dtCli As DataTable = CarregarDataTable("SELECT Endereco, Telefone FROM Cliente Where Codigo = " & intCodCli)
                If dtCli.Rows.Count > 0 Then
                    strEnd = dtCli.Rows.Item(0).Item("Endereco").ToString
                    strTel = dtCli.Rows.Item(0).Item("Telefone").ToString
                End If

                strImpressao &= Dir("Cliente.: " & strCliente, 55) & vbCrLf
                strImpressao &= Dir("Endereco: " & strEnd, 55) & vbCrLf
                strImpressao &= Dir("Telefone: " & strTel, 55) & vbCrLf
                strImpressao &= strTraco & vbCrLf
            End If


            strImpressao &= "ITEM CÓDIGO    DESCRICAO                  " & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$      VL TOTAL R$", intTamEsp) & vbCrLf
            strImpressao &= strTraço & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            Dim dblResulTaxa As Double
            For L = 0 To dtComanda.Rows.Count - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                'Dim item As Integer = L + 1

                strCod = dtComanda.Rows.Item(L).Item("CodProdInterno").ToString
                strProd = dtComanda.Rows.Item(L).Item("Produto").ToString
                strUni = dtComanda.Rows.Item(L).Item("ValorUnitario").ToString
                strQtd = dtComanda.Rows.Item(L).Item("Qtd").ToString
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

                dblQtd += dtComanda.Rows.Item(L).Item("Qtd").ToString

                'CARREGAR GRUPO PRODUTO
                Dim dtGrupo As DataTable = CarregarDataTable("Select Grupo From Produto Where Codigo=" & dtComanda.Rows.Item(L).Item("CodProd").ToString)
                Dim strGrupo As String = ""
                If dtGrupo.Rows.Count > 0 Then
                    strGrupo = dtGrupo.Rows.Item(0).Item("Grupo").ToString
                    If strGrupo <> "SEM DEZ PORCENTO" Then
                        dblResulTaxa = dblResulTaxa + (CDbl(strQtd) * CDbl(strUni))
                    End If
                End If

                Dim P As Integer = 0

                Dim bolMisto As Boolean = CBool(dtComanda.Rows.Item(L).Item("Misto").ToString)
                If bolMisto = True Then
                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                strImpressao &= L + 1 & "   " & strCod & "   " & strProd & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 31) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If bolMisto = True Then
                    If dtComanda.Rows.Item(L).Item("Opcoes").ToString <> "" Then

                        Dim strOpci As String = dtComanda.Rows.Item(L).Item("Opcoes").ToString.Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= strOpci & vbCrLf
                        Next

                    End If

                    If dtComanda.Rows.Item(L).Item("Obs").ToString <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & dtComanda.Rows.Item(L).Item("Obs").ToString.Trim & vbCrLf
                    End If

                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf
                End If

            Next


            Dim dblVal, dblTaxa, dblGeral As Double
            dblVal = strTotalGeral

            strImpressao &= strTraço & vbCrLf
            'strImpressao &= Esq("N de Itens......: ", 32) & Esq(dblQtd, 10) & vbCrLf
            If DezPorcento = True Then
                If strTipoComanda = "COMANDA" Then
                    strImpressao &= Esq("Total........: R$ ", 32) & Esq(strTotalGeral.Trim, 10) & vbCrLf
                    dblTaxa = ((dblResulTaxa / 100) * 10)
                    strImpressao &= Esq("Taxa 10%.....: R$ ", 32) & Esq(dblTaxa.ToString("0.00"), 10) & vbCrLf
                End If
            End If

            If DezPorcento = True Then
                dblGeral = dblVal + dblTaxa
                strImpressao &= Esq("Total Geral..: R$ ", 32) & Esq(dblGeral.ToString("0.00"), 10) & vbCrLf
            Else
                strImpressao &= Esq("Total Geral..: R$ ", 32) & Esq(strTotalGeral, 10) & vbCrLf
            End If


            strImpressao &= " " & vbCrLf
            If strQtdePessoasMesa <> "0" And strQtdePessoasMesa <> "" Then
                strImpressao &= Dir("Qtde Pessoas: " & strQtdePessoasMesa, 55) & vbCrLf
                Dim dblValorPessoa As Double = CDbl(dblTotal) / CDbl(strQtdePessoasMesa)
                strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If strObsComanda <> "" Then
                strImpressao &= "OBSERVAÇÃO: " & strObsComanda
                strImpressao &= " " & vbCrLf
            End If
            'If strTipoComanda <> "COMANDA" Then
            '    strImpressao &= strEstrela & vbCrLf
            '    strImpressao &= "DODOS DE ENTREGA" & vbCrLf
            '    strImpressao &= "Entregador: " & Me.cboEnt.Text.Trim & vbCrLf
            '    strImpressao &= "Troco R$..: " & Me.txtTroco.Text.Trim & vbCrLf
            '    strImpressao &= "Tempo.....: " & Me.cboTempo.Text.Trim & vbCrLf
            '    If strTipoComanda = "ENTREGAR" Then
            '        If Me.rdgMaqCartao.SelectedIndex = 1 Then
            '            strImpressao &= vbCrLf
            '            strImpressao &= "LEVAR MÁQUINA DE CARTÃO" & vbCrLf
            '        End If
            '    End If
            '    strImpressao &= strEstrela & vbCrLf
            'Else

            strImpressao &= strTraço & vbCrLf

            'End If


            strImpressao &= Cent("DOCUMENTO NAO FISCAL", intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            If strImpressora = "ARQUIVO" Then
                strImpressao += Avanco() & vbCrLf

                If TemGuilhotina = True Then
                    strImpressao += Corte() & vbCrLf
                End If
                SendStringToPrinter(strPorta, strImpressao)
                'ImprimiArquivo(strImpressao, PortaImpressora)

            ElseIf strImpressora.Contains("NANO PRINT") = True Then
                If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                    ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                Else
                    EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
                End If
            Else
                If strImpressora.Contains("MP-4000") Then
                    iRetorno = ConfiguraModeloImpressora(5)
                    iRetorno = SelecionaQualidadeImpressao(3)
                Else
                    iRetorno = ConfiguraModeloImpressora(1)
                End If
                iRetorno = clsBematech.IniciaPorta(PortaImpressora)


                iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If
            End If

            Atualizar("UPDATE Comanda set Tempo='' Where CodComanda = '" & strComanda & "' And " & _
                           " Comanda.Status = 'Aberto' And CodConfig = " & CodConfig)

        ElseIf strImpressora = "EPSON" Then

            Dim strImpressao As String

            Dim strEstrela, strTraço As String

            strEstrela = clsImprimir.Comp("************************************************")
            strTraço = clsImprimir.Comp("------------------------------------------------")

            strImpressao = strEstrela & vbCrLf

            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= Esq(My.Computer.Clock.LocalTime, 48) & vbCrLf

            strImpressao &= strTraço & vbCrLf & vbCrLf
            strImpressao &= "<ce>" & "COMANDA/MESA: " & strComanda.Trim & "</ce>" & vbCrLf & vbCrLf
            strImpressao &= strTraço & vbCrLf


            'CARREGA DADOS DO CLIENTE
            Dim strCliente As String = dtComanda.Rows.Item(0).Item("Nome").ToString
            Dim intCodCli As Integer = dtComanda.Rows.Item(0).Item("CodCli").ToString

            If strCliente <> "CONSUMIDOR" Then
                Dim strEnd, strTel As String

                Dim dtCli As DataTable = CarregarDataTable("SELECT Endereco, Telefone FROM Cliente Where Codigo = " & intCodCli)
                If dtCli.Rows.Count > 0 Then
                    strEnd = dtCli.Rows.Item(0).Item("Endereco").ToString
                    strTel = dtCli.Rows.Item(0).Item("Telefone").ToString
                End If

                strImpressao &= Dir("Cliente.: " & strCliente, 55) & vbCrLf
                strImpressao &= Dir("Endereco: " & strEnd, 55) & vbCrLf
                strImpressao &= Dir("Telefone: " & strTel, 55) & vbCrLf
                strImpressao &= strTraco & vbCrLf
            End If


            strImpressao &= "ITEM CÓDIGO    DESCRICAO                  " & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 37) & Esq("VL TOTAL R$", 11) & vbCrLf
            strImpressao &= strTraço & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            Dim dblResulTaxa As Double
            For L = 0 To dtComanda.Rows.Count - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                strCod = dtComanda.Rows.Item(L).Item("CodProdInterno").ToString
                strProd = dtComanda.Rows.Item(L).Item("Produto").ToString
                strUni = dtComanda.Rows.Item(L).Item("ValorUnitario").ToString
                strQtd = dtComanda.Rows.Item(L).Item("Qtd").ToString
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

                dblQtd += dtComanda.Rows.Item(L).Item("Qtd").ToString

                'CARREGAR GRUPO PRODUTO
                Dim dtGrupo As DataTable = CarregarDataTable("Select Grupo From Produto Where Codigo=" & dtComanda.Rows.Item(L).Item("CodProd").ToString)
                Dim strGrupo As String = ""
                If dtGrupo.Rows.Count > 0 Then
                    strGrupo = dtGrupo.Rows.Item(0).Item("Grupo").ToString
                    If strGrupo <> "SEM DEZ PORCENTO" Then
                        dblResulTaxa = dblResulTaxa + (CDbl(strQtd) * CDbl(strUni))
                    End If
                End If

                Dim P As Integer = 0

                Dim bolMisto As Boolean = CBool(dtComanda.Rows.Item(L).Item("Misto").ToString)
                If bolMisto = True Then
                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                strImpressao &= L + 1 & "   " & strCod & "   " & strProd & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 37) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If bolMisto = True Then
                    If dtComanda.Rows.Item(L).Item("Opcoes").ToString <> "" Then

                        Dim strOpci As String = dtComanda.Rows.Item(L).Item("Opcoes").ToString.Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= strOpci & vbCrLf
                        Next

                    End If

                    If dtComanda.Rows.Item(L).Item("Obs").ToString <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & dtComanda.Rows.Item(L).Item("Obs").ToString.Trim & vbCrLf
                    End If

                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf
                End If

            Next


            Dim dblVal, dblTaxa, dblGeral As Double
            dblVal = strTotalGeral

            strImpressao &= strTraço & vbCrLf
            'strImpressao &= Esq("N de Itens......: ", 32) & Esq(dblQtd, 10) & vbCrLf
            If DezPorcento = True Then
                If strTipoComanda = "COMANDA" Then
                    strImpressao &= Esq("Total........: R$ ", 38) & Esq(strTotalGeral.Trim, 10) & vbCrLf
                    dblTaxa = ((dblResulTaxa / 100) * 10)
                    strImpressao &= Esq("Taxa 10%.....: R$ ", 38) & Esq(dblTaxa.ToString("0.00"), 10) & vbCrLf
                End If
            End If

            If DezPorcento = True Then
                dblGeral = dblVal + dblTaxa
                strImpressao &= Esq("Total Geral..: R$ ", 38) & Esq(dblGeral.ToString("0.00"), 10) & vbCrLf
            Else
                strImpressao &= Esq("Total Geral..: R$ ", 38) & Esq(strTotalGeral, 10) & vbCrLf
            End If

            strImpressao &= " " & vbCrLf
            If strQtdePessoasMesa <> "0" And strQtdePessoasMesa <> "" Then
                strImpressao &= Dir("Qtde Pessoas: " & strQtdePessoasMesa, 55) & vbCrLf
                Dim dblValorPessoa As Double = CDbl(dblTotal) / CDbl(strQtdePessoasMesa)
                strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If strObsComanda <> "" Then
                strImpressao &= "OBSERVAÇÃO: " & strObsComanda
                strImpressao &= " " & vbCrLf
            End If
            'If strTipoComanda <> "COMANDA" Then
            '    strImpressao &= strEstrela & vbCrLf
            '    strImpressao &= "DODOS DE ENTREGA" & vbCrLf
            '    strImpressao &= "Entregador: " & Me.cboEnt.Text.Trim & vbCrLf
            '    strImpressao &= "Troco R$..: " & Me.txtTroco.Text.Trim & vbCrLf
            '    strImpressao &= "Tempo.....: " & Me.cboTempo.Text.Trim & vbCrLf

            '    If strTipoComanda = "ENTREGAR" Then
            '        If Me.rdgMaqCartao.SelectedIndex = 1 Then
            '            strImpressao &= vbCrLf
            '            strImpressao &= "LEVAR MÁQUINA DE CARTÃO" & vbCrLf
            '        End If
            '    End If
            '    strImpressao &= strEstrela & vbCrLf
            'Else

            strImpressao &= strTraço & vbCrLf

            'End If

            strImpressao &= "<ce>" & "DOCUMENTO NAO FISCAL" & "</ce>" & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            iRetorno = clsEpson.IniciaPorta(PortaImpressora)
            iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

            If TemGuilhotina = True Then
                iRetorno = clsEpson.AcionaGuilhotina(1)
            End If
            iRetorno = clsEpson.FechaPorta

            Atualizar("UPDATE Comanda set Tempo='' Where CodComanda = '" & strComanda & "' And " & _
                           " Comanda.Status = 'Aberto' And CodConfig = " & CodConfig)

        End If
    End Function
    Public Shared Function BuscaCep3(ByVal cep As String) As Hashtable
        If cep.Trim = "" Then Return (Nothing)
        Dim c3p As String = cep.Trim
        Dim ds As DataSet
        'Dim _resultado As String
        Dim ht As System.Collections.Hashtable = Nothing
        Try
            ds = New DataSet()
            ds.ReadXml("https://viacep.com.br/ws/" + cep.Replace("-", "").Replace(".", "").Trim() + "/xml/")
            If Not IsNothing(ds) Then
                If (ds.Tables(0).Rows.Count > 0) Then

                    ht = New Hashtable

                    ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                    ht.Add("localidade", ds.Tables(0).Rows(0).Item("localidade").ToString().Trim())
                    ht.Add("bairro", ds.Tables(0).Rows(0).Item("bairro").ToString().Trim())
                    'ht.Add("tipologradouro", ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim())
                    ht.Add("logradouro", ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim())
                    ht.Add("tipo", 1)

                End If
            End If
            Return (ht)
        Catch ex As Exception
            'MsgBox("Falha ao buscar o cep!" & vbCrLf & ex.ToString)
            Return (Nothing)
        End Try
    End Function

    Public Shared Function PesquisarCarro(ByVal parCampo As DevExpress.XtraEditors.TextEdit) As Boolean
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            Dim Sql As String
            Dim dr As SqlDataReader
            Dim bolExiste As Boolean = False

            Sql = "Select * From Carro Where Placa = '" & parCampo.Text.Trim & "'"
            conexao.Open()
            cmd = New SqlCommand(Sql, conexao)
            dr = cmd.ExecuteReader

            While dr.Read
                bolExiste = True
                Exit While
            End While

            If bolExiste = True Then
                MsgBox("Veículo já cadastrado no Sistema!", MsgBoxStyle.Information)
                parCampo.ResetText()
                parCampo.Focus()
            End If

            conexao.Close()
        Catch ex As Exception
        End Try

        Return True
    End Function

    Public Shared Function CampoValor(ByVal parCampo As String) As String
        Dim dblValor As Double
        If parCampo <> "" Then
            dblValor = parCampo
        Else
            dblValor = 0
        End If

        Select Case CasaDecimal
            Case "2"
                parCampo = dblValor.ToString("0.00")
            Case "3"
                parCampo = dblValor.ToString("0.000")
            Case "4"
                parCampo = dblValor.ToString("0.0000")
            Case "5"
                parCampo = dblValor.ToString("0.00000")
            Case "6"
                parCampo = dblValor.ToString("0.000000")
            Case "7"
                parCampo = dblValor.ToString("0.0000000")
        End Select
        Return parCampo
    End Function

    Public Shared Function ImpObsComandaApp()
        'VERIFICA QUAL EXCLUSAO DE PRODUTO DEVERA IMPRIMIR
        Dim dtImpApp As DataTable = CarregarDataTable("Select Codigo, Antigo as Produto, Novo as Obs, Tabela as Tipo, Motivo as Imp From Log Where Tabela='COMANDA' And Motivo like '%\\%' And CodConfig=" & CodConfig)

        Dim strImp As String = ""
        Dim strProduto As String = ""
        Dim strObs As String = ""
        Dim strTipoComanda As String = ""
        Dim strCodLog As String = ""

        If dtImpApp.Rows.Count > 0 Then
            For I As Integer = 0 To dtImpApp.Rows.Count - 1
                strTipoComanda = dtImpApp.Rows.Item(I).Item("Tipo").ToString()
                strCodLog = dtImpApp.Rows.Item(I).Item("Codigo").ToString()

                'CARREGA O NOME DA IMPRESSORA
                strImp = dtImpApp.Rows.Item(I).Item("Imp").ToString()
                Dim strPorta As String = strImp

                Dim dtImpressora = CarregarDataTable("SELECT Impressora FROM Grupo WHERE PortaImpressora = '" & strPorta & "' " & _
                " UNION SELECT Impressora FROM Config WHERE Codigo = " & CodConfig & " AND Porta = '" & strPorta & "'")

                Dim strImpressora As String = ""
                If dtImpressora.Rows.Count > 0 Then
                    strImpressora = dtImpressora.Rows.Item(0).Item("Impressora").ToString()
                Else
                    strImpressora = "ARQUIVO"
                End If


                'SEPARA MESA DA OBS
                strObs = dtImpApp.Rows.Item(I).Item("Obs").ToString()
                Dim strSplit As String = strObs.Replace(", Obs: ", "|")
                Dim vetImp As String() = strSplit.Split("|")
                Dim strComanda As String = vetImp(0).ToString.Replace("Comanda/Mesa: ", "")
                Dim Observacao As String = vetImp(1).ToString


                'SEPARA PRODUTO DO CODFUNC
                strProduto = dtImpApp.Rows.Item(I).Item("Produto").ToString()
                Dim strSplitProd As String = strProduto.Replace("Func: ", "|")
                strSplitProd = strSplitProd.Replace(", Produto: ", "|")
                strSplitProd = strSplitProd.Replace(", Qtd: ", "|")
                Dim vetProduto As String() = strSplitProd.Split("|")


                Dim CodFunc As String = vetProduto(1).ToString
                Dim NomeProd As String = vetProduto(2).ToString
                Dim Qtd As String = vetProduto(3).ToString



                If strImpressora.Contains("ESC/POS") = True Then
                    Dim strImpressao As String

                    strImpressao = Cabecalho()

                    strImpressao &= Esq(My.Computer.Clock.LocalTime, 55) & vbCrLf & vbCrLf

                    strImpressao &= CentralizarComanda(ExpComanda("COMANDA/MESA: " & strComanda.Trim, strImpressora), strImpressora) & vbCrLf


                    strImpressao &= strTraco & vbCrLf
                    Dim dtFunc As DataTable = CarregarDataTable("Select Nome From Funcionario Where Codigo=" & CodFunc & " And CodConfig=" & CodConfig & "")
                    If dtFunc.Rows.Count > 0 Then
                        strImpressao &= Dir("Func.", 55) & vbCrLf
                        strImpressao &= Dir(dtFunc.Rows.Item(0).Item("Nome").ToString.Trim, 55) & vbCrLf
                    Else
                        strImpressao &= Dir("CÓD. FUNC.", 55) & vbCrLf
                        strImpressao &= Dir(CodFunc, 55) & vbCrLf
                    End If
                    strImpressao &= strTraco & vbCrLf


                    strImpressao &= Dir("DESCRICAO", 55) & vbCrLf
                    strImpressao &= Dir("QTD.", 55) & vbCrLf
                    strImpressao &= Dir(NomeProd, 55) & vbCrLf
                    strImpressao &= Dir(Qtd.Replace(".", ","), 55) & vbCrLf & vbCrLf


                    strImpressao &= strTraco & vbCrLf
                    strImpressao &= " " & vbCrLf
                    strImpressao &= Dir(ExpComanda("MOTIVO EXCLUSAO", strImpressora), 45) '& vbCrLf
                    strImpressao &= Dir(ExpComanda(Observacao, strImpressora), 55) '& vbCrLf


                    strImpressao &= GerarBarCode(strComanda.Trim) & vbCrLf


                    'IMPRESSAO ESC/POS
                    RodapeComanda(strImpressao, strImpressora, strPorta)


                    Atualizar("UPDATE Log set Motivo='EXCLUSÃO' Where Codigo=" & strCodLog)


                ElseIf strImpressora.Contains("BEMATECH") Or strImpressora.Contains("ARQUIVO") Or strImpressora.Contains("NANO PRINT") Then
                    Dim strImpressao As String
                    Dim intTamEsp As Integer
                    Dim strEstrela, strTraço As String


                    intTamEsp = 42
                    'strEstrela = "******************************************"
                    strEstrela = "=========================================="
                    strTraço = "------------------------------------------"


                    strImpressao = strEstrela & vbCrLf
                    strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
                    strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
                    strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf


                    strImpressao &= strEstrela & vbCrLf
                    strImpressao &= Esq(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf & vbCrLf
                    'strImpressao &= strTraço & vbCrLf & vbCrLf
                    strImpressao &= Cent("COMANDA/MESA:  " & strComanda.Trim, intTamEsp) & vbCrLf '& vbCrLf


                    strImpressao &= strTraço & vbCrLf
                    Dim dtFunc As DataTable = CarregarDataTable("Select Nome From Funcionario Where Codigo=" & CodFunc & " And CodConfig=" & CodConfig & "")
                    If dtFunc.Rows.Count > 0 Then
                        strImpressao &= Dir("Func.", intTamEsp) & vbCrLf
                        strImpressao &= Dir(dtFunc.Rows.Item(0).Item("Nome").ToString.Trim, intTamEsp) & vbCrLf
                    Else
                        strImpressao &= Dir("Cod Func.", intTamEsp) & vbCrLf
                        strImpressao &= Dir(CodFunc, intTamEsp) & vbCrLf
                    End If
                    strImpressao &= strTraço & vbCrLf


                    strImpressao &= "DESCRICAO                  " & vbCrLf
                    strImpressao &= Dir("QTD.", intTamEsp) & vbCrLf
                    strImpressao &= Dir(NomeProd, intTamEsp) & vbCrLf
                    strImpressao &= Dir(Qtd.Replace(".", ","), intTamEsp) '& vbCrLf
                    strImpressao &= strTraço & vbCrLf '& vbCrLf


                    strImpressao &= Dir("MOTIVO EXCLUSAO", intTamEsp) & vbCrLf
                    strImpressao &= Dir(Observacao, intTamEsp) '& vbCrLf
                    strImpressao &= strTraço & vbCrLf


                    strImpressao &= Cent("DOCUMENTO NAO FISCAL", intTamEsp) & vbCrLf
                    'strImpressao &= strTraço & vbCrLf


                    strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


                    'IMPRESSAO ARQUIVO
                    If strImpressora = "ARQUIVO" Then
                        strImpressao += Avanco() & vbCrLf

                        If TemGuilhotina = True Then
                            strImpressao += Corte() & vbCrLf
                        End If
                        SendStringToPrinter(strPorta, strImpressao)
                        'ImprimiArquivo(strImpressao, PortaImpressora)

                    ElseIf strImpressora.Contains("NANO PRINT") = True Then
                        If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                            ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                        Else
                            EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
                        End If
                    Else
                        If strImpressora.Contains("MP-4000") Then
                            iRetorno = ConfiguraModeloImpressora(5)
                            iRetorno = SelecionaQualidadeImpressao(3)
                        Else
                            iRetorno = ConfiguraModeloImpressora(1)
                        End If
                        iRetorno = clsBematech.IniciaPorta(PortaImpressora)


                        iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                        If TemGuilhotina = True Then
                            iRetorno = clsBematech.AcionaGuilhotina(0)
                        End If
                    End If


                    Atualizar("UPDATE Log set Motivo='EXCLUSÃO' Where Codigo=" & strCodLog)
                End If

            Next
        Else
            Exit Function
        End If
    End Function
    Public Shared Function SelecionarURLQrCode2(ByVal parUF As String, ByVal parAmbiente As String) As String
        Dim strURL As String = ""
        Select Case parAmbiente
            Case "1"
                Select Case parUF

                    Case "AC"

                        strURL = "www.sefaznet.ac.gov.br/nfce/consulta"

                    Case "AL"
                        strURL = "www.sefaz.al.gov.br/nfce/consulta"

                    Case "AP"
                        strURL = "www.sefaz.ap.gov.br/nfce/consulta"

                    Case "AM"
                        strURL = "www.sefaz.am.gov.br/nfce/consulta"

                    Case "BA"
                        strURL = "http://www.sefaz.ba.gov.br/nfce/consulta"

                    Case "CE"
                        strURL = "www.sefaz.ce.gov.br/nfce/consulta"

                    Case "DF"
                        strURL = "www.fazenda.df.gov.br/nfce/consulta"

                    Case "ES"
                        strURL = "www.sefaz.es.gov.br/nfce/consulta"

                    Case "GO"
                        strURL = "www.sefaz.go.gov.br/nfce/consulta"

                    Case "MA"
                        strURL = "www.sefaz.ma.gov.br/nfce/consulta"

                    Case "MT"
                        strURL = "www.sefaz.mt.gov.br/nfce/consulta"

                    Case "MS"
                        strURL = "www.dfe.ms.gov.br/nfce/consulta"

                    Case "MG"
                        strURL = "http://nfce.fazenda.mg.gov.br/portalnfce"

                    Case "PA"
                        strURL = "www.sefa.pa.gov.br/nfce/consulta"

                    Case "PB"
                        strURL = "www.receita.pb.gov.br/nfce/consulta"

                    Case "PR"
                        strURL = "www.fazenda.pr.gov.br/nfce/consulta"

                    Case "PE"
                        strURL = "nfce.sefaz.pe.gov.br/nfce/consulta"

                    Case "PI"
                        strURL = "www.sefaz.pi.gov.br/nfce/consulta"

                    Case "RJ"
                        strURL = "www.fazenda.rj.gov.br/nfce/consulta"

                    Case "RN"
                        strURL = "www.set.rn.gov.br/nfce/consulta"

                    Case "RS"
                        strURL = "www.sefaz.rs.gov.br/nfce/consulta"

                    Case "RO"
                        strURL = "www.sefin.ro.gov.br/nfce/consulta"

                    Case "RR"
                        strURL = "www.sefaz.rr.gov.br/nfce/consulta"

                    Case "SC"
                        strURL = ""

                    Case "SP"
                        strURL = "https://www.nfce.fazenda.sp.gov.br/consulta"
                    Case "SE"
                        strURL = "http://www.nfce.se.gov.br/nfce/consulta"

                    Case "TO"
                        strURL = "www.sefaz.to.gov.br/nfce/consulta"

                End Select
            Case "2"
                Select Case parUF

                    Case "AC"

                        strURL = "www.sefaznet.ac.gov.br/nfce/consulta"

                    Case "AL"
                        strURL = "www.sefaz.al.gov.br/nfce/consulta"

                    Case "AP"
                        strURL = "www.sefaz.ap.gov.br/nfce/consulta"

                    Case "AM"
                        strURL = "www.sefaz.am.gov.br/nfce/consulta"

                    Case "BA"
                        strURL = "http://hinternet.sefaz.ba.gov.br/nfce/consulta"

                    Case "CE"
                        strURL = "www.sefaz.ce.gov.br/nfce/consulta"

                    Case "DF"
                        strURL = "www.fazenda.df.gov.br/nfce/consulta"

                    Case "ES"
                        strURL = "www.sefaz.es.gov.br/nfce/consulta"

                    Case "GO"
                        strURL = "www.sefaz.go.gov.br/nfce/consulta"

                    Case "MA"
                        strURL = "www.sefaz.ma.gov.br/nfce/consulta"

                    Case "MT"
                        strURL = "www.sefaz.mt.gov.br/nfce/consulta"

                    Case "MS"
                        strURL = "www.dfe.ms.gov.br/nfce/consulta"

                    Case "MG"
                        strURL = "www.fazenda.mg.gov.br/nfce/consulta"

                    Case "PA"
                        strURL = "www.sefa.pa.gov.br/nfce/consulta"

                    Case "PB"
                        strURL = "www.receita.pb.gov.br/nfcehom"

                    Case "PR"
                        strURL = "www.fazenda.pr.gov.br/nfce/consulta"

                    Case "PE"
                        strURL = "nfce.sefaz.pe.gov.br/nfce/consulta"

                    Case "PI"
                        strURL = "www.sefaz.pi.gov.br/nfce/consulta"

                    Case "RJ"
                        strURL = "www.fazenda.rj.gov.br/nfce/consulta"

                    Case "RN"
                        strURL = "www.set.rn.gov.br/nfce/consulta"

                    Case "RS"
                        strURL = "www.sefaz.rs.gov.br/nfce/consulta"

                    Case "RO"
                        strURL = "www.sefin.ro.gov.br/nfce/consulta"

                    Case "RR"
                        strURL = "www.sefaz.rr.gov.br/nfce/consulta"

                    Case "SC"
                        strURL = ""

                    Case "SP"
                        strURL = "https://www.homologacao.nfce.fazenda.sp.gov.br/consulta"

                    Case "SE"
                        strURL = "http://www.hom.nfe.se.gov.br/nfce/consulta"

                    Case "TO"
                        strURL = "www.sefaz.to.gov.br/nfce/consulta"

                End Select
        End Select


        Return strURL
    End Function

    Public Shared Function GerarCodigoOrdensBoleto(ByVal parTabela As String, ByVal parCodBanco As String) As String
        Dim conexao As New SqlConnection(StringDeConexao)

        Dim strSql As String = ""
        Dim strcod As String = ""

        Try

            strSql = "Select max(Cod) as Cod From Ordens where Tabela ='" & parTabela & "' and CodBanco = " & parCodBanco
            Dim dt As DataTable = CarregarDataTable(strSql)

            If dt.Rows.Count > 0 Then
                strcod = dt.Rows.Item(0).Item("Cod").ToString
            End If

            conexao.Close()

        Catch ex As Exception

        End Try
        Return Val(strcod) + 1
    End Function

    Public Shared Function QueryTabelaPreco(ByVal parTabela As String) As String
        Dim strQueryValor As String = ""
        Dim strResult As String = ""
        If parTabela = "" Then
            parTabela = TabelaPreco
        End If
        Try
            'Dim dtTabela As DataTable = CarregarDataTable("Select TabelaPreco From Config Where Codigo=" & CodConfig)

            'Dim strTabela As String = ""
            'If dtTabela.Rows.Count > 0 Then
            '    strTabela = dtTabela.Rows.Item(0).Item("TabelaPreco")
            'End If

            If parTabela <> "" And parTabela <> "PADRÃO" Then
                Dim dtCodTabela As DataTable = CarregarDataTable("Select TabelaPreco.CodTabela From TabelaPreco " & _
                " Left Join Grupo on Grupo.Codigo=CodTabela Where Grupo.Nome='" & parTabela & "' " & _
                " Group by TabelaPreco.CodTabela")

                If dtCodTabela.Rows.Count > 0 Then
                    strQueryValor = "(Select Top 1 TabelaPreco.Valor From TabelaPreco Where " & _
                    " CodTabela=" & dtCodTabela.Rows.Item(0).Item("CodTabela").ToString & " And " & _
                    " TabelaPreco.CodProd=Produto.Codigo)"
                End If

                strResult = "Case When " & strQueryValor & " Is Not NULL Then " & strQueryValor & " Else 0.00 End"
            Else
                strResult = "Produto.Valor"
            End If
        Catch ex As Exception
            strResult = "Produto.Valor"
        End Try

        Return strResult
    End Function

    Public Shared Function ArredondarValorMais(ByVal parValor As Double) As Double
        Dim dblValor As Double = 0.0

        Try
            dblValor = Math.Ceiling(parValor)
        Catch ex As Exception
        End Try

        Return dblValor
    End Function

    Public Shared Function ArredondarValorMenos(ByVal parValor As Double) As Double
        Dim dblValor As Double = 0.0

        Try
            dblValor = Math.Floor(parValor)
        Catch ex As Exception
        End Try

        Return dblValor
    End Function

    Shared strTitulo As String
    Public Shared Function ShowPrint(ByVal parGidControl As DevExpress.XtraGrid.GridControl, ByVal parTitulo As String)
        Dim system As PrintingSystem = New PrintingSystem()
        Dim link As PrintableComponentLink = New PrintableComponentLink()
        link.PrintingSystem = system
        link.Component = parGidControl
        strTitulo = parTitulo
        AddHandler link.CreateMarginalHeaderArea, AddressOf Link_CreateMarginalHeaderArea
        AddHandler link.CreateMarginalFooterArea, AddressOf Link_CreateMarginalFooterArea
        AddHandler link.CreateMarginalFooterArea, AddressOf Link_CreateMarginalFooterArea2
        link.ShowPreview()
    End Function

    Shared Sub Link_CreateMarginalHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        Dim Brick As TextBrick = e.Graph.DrawString(strTitulo, Color.Black, New RectangleF(0, 30, e.Graph.ClientPageSize.Width, 50), BorderSide.None)
        Brick.StringFormat = New BrickStringFormat(StringAlignment.Center)
        Brick.Font = New System.Drawing.Font("Tahoma", 14, FontStyle.Regular)
    End Sub
    Shared Sub Link_CreateMarginalFooterArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        Dim Brick As PageInfoBrick = e.Graph.DrawPageInfo(PageInfo.DateTime, "", Color.Black, New RectangleF(0, 0, 100, 20), BorderSide.None)
        Brick.LineAlignment = BrickAlignment.Center
        Brick.Alignment = BrickAlignment.Center
        Brick.AutoWidth = True
    End Sub
    Shared Sub Link_CreateMarginalFooterArea2(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        Dim Brick As PageInfoBrick = e.Graph.DrawPageInfo(PageInfo.NumberOfTotal, "", Color.Black, New RectangleF(0, 0, 100, 20), BorderSide.None)
        Brick.LineAlignment = BrickAlignment.Center
        Brick.Alignment = BrickAlignment.Far
        Brick.AutoWidth = True
    End Sub



    Public Shared Sub IniciaThreadTeclado()
        Try
            If mThreadTeclado.IsAlive = True Then
                mThreadTeclado.Abort()
            End If

        Catch ex As Exception

        End Try
        'FecharTeclado()
        Try
            'If mThreadTeclado.IsAlive = False Then
            mThreadTeclado = New Threading.Thread(AddressOf Verificar)
            mThreadTeclado.SetApartmentState(Threading.ApartmentState.STA)
            mThreadTeclado.Start()
            'Else
            'mThreadTeclado.Abort()
            'End If
        Catch ex As Exception
            Try
                mThreadTeclado.Abort()
            Catch ex1 As Exception

            End Try
        End Try

      
        'FecharTeclado()
        
    End Sub

    Private Delegate Sub VerificarDelegate()

    Private Shared Sub Verificar()

       
        Dim frm As New Form1
        'frm.TopLevel = False
        'Form1.Parent = Me.PanelControl1
        Dim f As Integer = Screen.PrimaryScreen.WorkingArea.Width

        frm.Size = New System.Drawing.Size(f, 362)

        If f > 1062 Then
            Dim intT As Integer = f - 1062
            intT = intT / 2
            frm.PanelControl2.Location = New System.Drawing.Point(intT, 12)
        End If
        'If f > 1171 Then
        '    Dim intT As Integer = f - 1171
        '    intT = intT / 2
        '    frm.PanelControl2.Location = New System.Drawing.Point(intT, 12)
        'End If
        ' frm.Location = New System.Drawing.Point(0, 229)

        frm.Location = New System.Drawing.Point(0, LocationTeclado)

        'Form1.ShowDialog()
        Application.Run(frm)
    End Sub
    Public Shared Sub FecharTeclado()

        Try
            'Dim I As Integer
            'For I = 0 To My.Application.OpenForms.Count - 1
            '    If I = My.Application.OpenForms.Count Then Exit For
            '    If My.Application.OpenForms.Item(I).Name = "Form1" Then
            '        My.Application.OpenForms.Item(I).Close()
            '        Exit Sub
            '    End If
            'Next

            mThreadTeclado.Abort()

            'Form1.BeginInvoke(New Action(Sub() Form1.close()))
        Catch ex As Exception

        End Try

      

    End Sub


    Public Shared Sub IniciaThreadTecladoNumerico()
        Try
            mThreadTecladoNumerico.Abort()
        Catch ex As Exception

        End Try
        'FecharTeclado()
        mThreadTecladoNumerico = New Threading.Thread(AddressOf VerificarNumerico)
        mThreadTecladoNumerico.Start()
    End Sub
    Private Shared Sub VerificarNumerico()

        'frm.TopLevel = False
        'Form1.Parent = Me.PanelControl1
        Dim f As Integer = Screen.PrimaryScreen.WorkingArea.Width
        'frmTecladoNumerico.Size = New System.Drawing.Size(f, 300)
        'frmTecladoNumerico.Location = New System.Drawing.Point(0, 200)
        'frmTecladoNumerico.ShowDialog()
    End Sub

    Public Shared Sub FecharTecladoNumerico()
        Try
            mThreadTecladoNumerico.Abort()
        Catch ex As Exception

        End Try
        'Dim I As Integer
        'For I = 0 To My.Application.OpenForms.Count - 1
        '    If I = My.Application.OpenForms.Count Then Exit For
        '    If My.Application.OpenForms.Item(I).Name = "Form1" Then
        '        My.Application.OpenForms.Item(I).Close()
        '        Exit Sub
        '    End If
        'Next
    End Sub
    Public Shared Function ConverterColor(ByVal parStringColor As String) As System.Drawing.Color
        Dim vetStringColor As Array = Split(parStringColor, "|")

        Dim I As Integer

        For I = 0 To vetStringColor.Length - 1
            Dim clsColor As Color
            If vetStringColor(I).ToString.Contains(",") Then
                Dim vetCor As Array = Split(vetStringColor(I), ",")
                Dim intR As Integer = vetCor(0)
                Dim intG As Integer = vetCor(1)
                Dim intB As Integer = vetCor(2)
                clsColor = Color.FromArgb(intR, intG, intB)
            End If



            Select Case I
                Case 0
                    CorFundo = clsColor
                Case 1
                    CorBarra = clsColor
                Case 2
                    CorTeclado = clsColor
                Case 3
                    CorComanda = clsColor
                Case 4
                    CorGrupo = clsColor
                Case 5
                    CorProduto = clsColor
                Case 6
                    CorFonte = clsColor
                Case 7
                    CorBotoes = clsColor
                Case 8
                    If vetStringColor(I).ToString <> "" Then
                        LocationTeclado = vetStringColor(I)
                    Else
                        LocationTeclado = 300
                    End If
                Case 9
                    If vetStringColor(I).ToString <> "" Then
                        CorImagemBarra = vetStringColor(I).ToString.Trim
                    Else
                        CorImagemBarra = "Laranja"
                    End If

                Case 10
                    If vetStringColor(I).ToString <> "" Then
                        CorImagemBotao = vetStringColor(I).ToString.Trim
                    Else
                        CorImagemBotao = "Laranja"
                    End If
                Case 11
                    If vetStringColor(I).ToString.Trim = "NÃO" Then
                        TecladoVirtual = False
                    Else
                        TecladoVirtual = True
                    End If
                Case 12
                    If vetStringColor(I).ToString.Trim = "NÃO" Then
                        QtdeVaziaComanda = False
                    Else
                        QtdeVaziaComanda = True
                    End If
            End Select

        Next


    End Function

    Public Shared Function AbrirTecladoArquivo(ByVal parShow As Boolean)
        If TecladoVirtual = False Then Exit Function
        Try
            Dim proc As Process
            Dim bolTeclado As Boolean = False
            For Each proc In Process.GetProcesses
                If proc.ProcessName = "TecladoNano" Then
                    bolTeclado = True
                End If
            Next
            If bolTeclado = False Then
                System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\TecladoNano.exe")
            End If
            If parShow = True Then
                Dim SW As New StreamWriter(My.Application.Info.DirectoryPath & "\StatusTeclado.txt") ' Cria o arquivo de texto
                SW.WriteLine("Abrir") ' Grava uma linha no arquivo de texto
                SW.Close() 'Fecha o arquivo de texto
                SW.Dispose() 'Libera a memória utilizada
            End If
        Catch ex As Exception

        End Try
        

    End Function
    Public Shared Function FecharTecladoArquivo(ByVal parFechar As Boolean)
        If TecladoVirtual = False Then Exit Function
        Try
            If parFechar = False Then

                Dim SW As New StreamWriter(My.Application.Info.DirectoryPath & "\StatusTeclado.txt") ' Cria o arquivo de texto
                SW.WriteLine("Fechar") ' Grava uma linha no arquivo de texto
                SW.Close() 'Fecha o arquivo de texto
                SW.Dispose() 'Libera a memória utilizada

            Else

                Dim SW As New StreamWriter(My.Application.Info.DirectoryPath & "\StatusTeclado.txt") ' Cria o arquivo de texto
                SW.WriteLine("") ' Grava uma linha no arquivo de texto
                SW.Close() 'Fecha o arquivo de texto
                SW.Dispose() 'Libera a memória utilizada
                Dim proc As Process
                Dim bolTeclado As Boolean = False
                For Each proc In Process.GetProcesses
                    If proc.ProcessName = "TecladoNano" Then
                        Try
                            proc.Kill()
                            proc.Close()
                        Catch ex As Exception

                        End Try
                    End If
                Next

            End If
        Catch ex As Exception

        End Try

  
    End Function


    Public Shared Function VerificarCaixa(ByVal parMotivo As String, Optional ByVal parExcluir As Boolean = False) As Boolean
        Dim dt As DataTable = CarregarDataTable("SELECT Top 1 Motivo, datediff(hour,Data,getdate()) as Hora FROM Caixa where Caixa = '" & UserNano.Trim & "' " & _
        "and CodConfig = " & CodConfig & " and Motivo = 'ABERTURA CAIXA' or Caixa = '" & UserNano.Trim & "' " & _
        "and CodConfig = " & CodConfig & " and Motivo = 'FECHAMENTO CAIXA' order by Data Desc, Codigo Desc")

        Dim strMotivo As String = ""
        Dim intHora As Integer
        If dt.Rows.Count > 0 Then
            strMotivo = dt.Rows.Item(0).Item("Motivo").ToString
            intHora = dt.Rows.Item(0).Item("Hora").ToString
        End If

        Select Case parMotivo
            Case "FECHAMENTO CAIXA"

                If strMotivo = "FECHAMENTO CAIXA" Then
                    MsgBox("Caixa já fechado para esse usuário!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                ElseIf strMotivo = "" Then
                    MsgBox("Não exite movimentação, faça a abertura do caixa!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                End If
            Case "ABERTURA CAIXA"
                If strMotivo = "ABERTURA CAIXA" Then
                    MsgBox("Caixa já aberto para esse usuário!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                End If
            Case Else
                If strMotivo = "FECHAMENTO CAIXA" Then
                    MsgBox("Caixa fechado para esse usuário!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                ElseIf strMotivo = "" Then
                    MsgBox("Não exite movimentação, faça a abertura do caixa!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                End If

                If intHora > 24 Then
                    MsgBox("Caixa aberto mais de 24 hr, faça o fechamento do caixa!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                End If
        End Select
        Return True
    End Function

    Public Shared Function VerificarExclusaoCaixa(ByVal parMotivo As String, ByVal parCodigo As String) As Boolean

        Dim dt As DataTable = CarregarDataTable("SELECT Top 1 Motivo, Codigo FROM Caixa where Caixa = '" & UserNano.Trim & "' " & _
        "and CodConfig = " & CodConfig & " order by Data Desc, Codigo Desc")

        Dim strMotivo As String = ""
        Dim strCodigo As String = ""
        If dt.Rows.Count > 0 Then
            strMotivo = dt.Rows.Item(0).Item("Motivo").ToString
            strCodigo = dt.Rows.Item(0).Item("Codigo").ToString
        End If

        Select Case parMotivo
            Case "FECHAMENTO CAIXA"
                If strMotivo <> "FECHAMENTO CAIXA" Or strCodigo <> parCodigo Then
                    MsgBox("Não é possível excluir este fechamente para esse usuário!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                End If
            Case "ABERTURA CAIXA"
                If strMotivo <> "ABERTURA CAIXA" Or strCodigo <> parCodigo Then
                    MsgBox("Não é possível excluir esta abertura para esse usuário!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                End If
            Case Else
                If strMotivo = "FECHAMENTO CAIXA" Then
                    MsgBox("Não é possível excluir este movimento porque o caixa já foi fechado!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                ElseIf strMotivo = "ABERTURA CAIXA" Then
                    MsgBox("Não é possível excluir este movimento porque o caixa já foi fechado!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                Else
                    dt = CarregarDataTable("SELECT Codigo FROM Caixa where Caixa = '" & UserNano.Trim & "' " & _
                    "and CodConfig = " & CodConfig & " and Motivo = 'FECHAMENTO CAIXA' and Codigo > " & parCodigo & " order by Data Desc, Codigo Desc")
                    If dt.Rows.Count > 0 Then
                        MsgBox("Não é possível excluir este movimento porque o caixa já foi fechado!", MsgBoxStyle.Information)
                        Return False
                        Exit Function
                    End If
                End If
        End Select
        Return True
    End Function

    Public Shared Function TirarAcento(ByVal parTexto As String) As String
        If parTexto = "" Then Exit Function

        Dim strTexto As String = parTexto

        strTexto = strTexto.Replace("Ç", "C")
        strTexto = strTexto.Replace("Á", "A")
        strTexto = strTexto.Replace("É", "E")
        strTexto = strTexto.Replace("Ê", "E")
        strTexto = strTexto.Replace("Í", "I")
        strTexto = strTexto.Replace("Ã", "A")
        strTexto = strTexto.Replace("&", "E")
        strTexto = strTexto.Replace("Õ", "O")
        strTexto = strTexto.Replace("Ó", "O")
        strTexto = strTexto.Replace("Ô", "O")
        strTexto = strTexto.Replace("Ä", "A")
        strTexto = strTexto.Replace("À", "A")
        strTexto = strTexto.Replace("Ë", "E")
        strTexto = strTexto.Replace("Ï", "I")
        strTexto = strTexto.Replace("Ö", "A")
        strTexto = strTexto.Replace("Ü", "E")
        strTexto = strTexto.Replace("Ú", "U")
        strTexto = strTexto.Replace("Ù", "U")
        strTexto = strTexto.Replace("Â", "A")
        strTexto = strTexto.Replace("´", "")
        strTexto = strTexto.Replace("º", "")
        strTexto = strTexto.Replace("ª", "")
        strTexto = strTexto.Replace("–", "-")
        strTexto = strTexto.Replace("|", "")
      
        Return strTexto
    End Function
End Class

