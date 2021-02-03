Imports Nano.clsFuncoes
Imports System
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports Microsoft.VisualBasic

Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Public Class frmMigracao2
    Dim strTabela As String
    Dim intPB As Integer
    Dim intMax As Integer
    Public Shared Sub Main()
        Application.Run(New frmMigracao2())
    End Sub

    Private Sub frmImigracao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As DataTable = CarregarDataTable2("SELECT Name FROM SYSDATABASES", "Master")

        Dim I As Integer
        Me.cboBanco2.Items.Clear()
        For I = 0 To dt.Rows.Count - 1
            Dim strBanco As String = dt.Rows.Item(I).Item("Name").ToString

            Me.cboBanco2.Items.Add(strBanco)
        Next
    End Sub


    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        Me.rtbMens.ResetText()

        Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable = Nothing
        Dim I, B As Integer
        B = 1

        If MsgBox("Deseja realmente iniciar a migração?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim strBanco As String = Me.cboBanco.EditValue
        If strBanco = Nothing Then
            MsgBox("SELECIONE UM BANCO!", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim P As Integer = 10


        Me.btnOk.Enabled = False
        pb.Value = 0

        pb.Maximum = 40
        intMax = 40




        '**********CLIENTE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Clientes order by CODCLIE", strBanco)
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strNome As String = dt.Rows.Item(I).Item("RAZAO").ToString

            Dim strPessoa As String = dt.Rows.Item(I).Item("PESSOA").ToString
            Dim strRG As String
            Dim strCPF As String = dt.Rows.Item(I).Item("CNPJ_CPF").ToString
            If strPessoa = "J" Then
                strRG = dt.Rows.Item(I).Item("IE").ToString
            Else
                strRG = dt.Rows.Item(I).Item("RG").ToString
            End If

            strCPF = AddPonto(strCPF, strPessoa)


            Dim strEnd As String = dt.Rows.Item(I).Item("ENDERECO").ToString
            Dim strNum As String = dt.Rows.Item(I).Item("NUMERO").ToString.Replace("'", "")
            Dim strComp As String = dt.Rows.Item(I).Item("COMPLEMENTO").ToString.Replace("'", "")
            Dim strBairro As String = dt.Rows.Item(I).Item("BAIRRO").ToString
            Dim strCep As String = dt.Rows.Item(I).Item("CEP").ToString

            strCep = AddPonto(strCep, "CEP")

            Dim strCidade As String = dt.Rows.Item(I).Item("CIDADE").ToString
            Dim strUF As String = dt.Rows.Item(I).Item("ESTADO").ToString
            Dim strTel As String = dt.Rows.Item(I).Item("TELEFONE").ToString

            strTel = AddPonto(strTel, "TEL")

            Dim strFax As String = dt.Rows.Item(I).Item("FAX").ToString
            strFax = AddPonto(strFax, "TEL")
            Dim strCel As String = dt.Rows.Item(I).Item("CELULAR").ToString
            strCel = AddPonto(strCel, "TEL")
            Dim strEmail As String = dt.Rows.Item(I).Item("EMAIL").ToString
            Dim strData As String = dt.Rows.Item(I).Item("DTCAD").ToString
            Dim strFant As String = dt.Rows.Item(I).Item("FANTASIA").ToString.Replace("'", "")
            Dim bolIna As Boolean = False

            Dim strObs As String
            If dt.Rows.Item(I).Item("OBS1").ToString = "" Then
                strObs = dt.Rows.Item(I).Item("OBS2").ToString
            Else
                If dt.Rows.Item(I).Item("OBS2").ToString = "" Then
                    strObs = dt.Rows.Item(I).Item("OBS1").ToString
                Else
                    strObs = dt.Rows.Item(I).Item("OBS1").ToString & vbCrLf & dt.Rows.Item(I).Item("OBS2").ToString
                End If
            End If
            Dim strStatus As String = "3"

            Dim strNasc As String = dt.Rows.Item(I).Item("DTANIVER").ToString.Replace("0974", "1974").Replace("1000", "1910")
            Dim strSexo As String = dt.Rows.Item(I).Item("SEXO").ToString
            Dim strLimite As String = "5000,00"


            Dim strEmpresa As String = dt.Rows.Item(I).Item("EMPRESA").ToString
            Dim strTelEmpresa As String = dt.Rows.Item(I).Item("FONE_EMP").ToString
            strTelEmpresa = AddPonto(strTelEmpresa, "TEL")
            Dim bolInativo As Boolean = False

            If dt.Rows.Item(I).Item("ATIVO").ToString = "N" Then
                bolInativo = True
            End If

            Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Inativo, CodConfig) VALUES ('" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "','" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strNum & "','" & strComp & "','" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "','" & strUF & "','" & strFant & "','" & bolIna & "','" & strObs.Replace("'", "´") & "','" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa & "','" & strTelEmpresa & "','" & bolInativo & "',1)")
            LogDeErro()

            B += 1
            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Cliente"
        BarraProdgresso()


        '**********FORNECEDOR**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Fornecedores order by CODFORNEC", strBanco)
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strNome As String = dt.Rows.Item(I).Item("RAZAO").ToString.Replace("'", "´")
            Dim strCPF As String = dt.Rows.Item(I).Item("CNPJ_CPF").ToString
            Dim strPessoa As String = dt.Rows.Item(I).Item("PESSOA").ToString
            strCPF = AddPonto(strCPF, strPessoa)

            Dim strEnd As String = dt.Rows.Item(I).Item("ENDERECO").ToString.Replace("'", "´")
            Dim strNum As String = dt.Rows.Item(I).Item("NUMERO").ToString
            Dim strComp As String = dt.Rows.Item(I).Item("COMPLEMENTO").ToString
            Dim strBairro As String = dt.Rows.Item(I).Item("BAIRRO").ToString
            Dim strCep As String = dt.Rows.Item(I).Item("CEP").ToString
            strCep = AddPonto(strCep, "CEP")
            Dim strCidade As String = dt.Rows.Item(I).Item("CIDADE").ToString.Replace("'", "´")
            Dim strUF As String = dt.Rows.Item(I).Item("ESTADO").ToString
            Dim strTelefone As String = dt.Rows.Item(I).Item("TELEFONE").ToString
            strTelefone = AddPonto(strTelefone, "TEL")
            Dim strFax As String = dt.Rows.Item(I).Item("FAX").ToString
            strFax = AddPonto(strFax, "TEL")
            Dim strCelular As String = dt.Rows.Item(I).Item("CELULAR").ToString
            strCelular = AddPonto(strCelular, "TEL")
            Dim strEmail As String
            If dt.Rows.Item(I).Item("EMAIL").ToString.Contains(",CONTATO") Then
                Dim vet As Array = Split(dt.Rows.Item(I).Item("EMAIL").ToString, ",CONTATO")
                strEmail = vet(0)
            Else
                strEmail = dt.Rows.Item(I).Item("EMAIL").ToString
            End If

            Dim strData As String = dt.Rows.Item(I).Item("DTCAD").ToString

            Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
            Dim strContato As String = dt.Rows.Item(I).Item("CONTATO").ToString
            Dim strFantasia As String = dt.Rows.Item(I).Item("FANTASIA").ToString.Replace("'", "´")
            Dim strStatus As String = "3"
            Dim strObs As String = dt.Rows.Item(I).Item("OBS").ToString


            Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Fantasia, Status, Obs, CodConfig) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "','" & strNum & "','" & strComp & "','" & strBairro & "','" & strCep & "','" & strCidade & "','" & strUF & "','" & strTelefone & "','" & strFax & "','" & strCelular & "','" & strEmail & "','" & strData & "','" & strIE & "','" & strContato & "','" & strFantasia & "','" & strStatus & "','" & strObs & "',1)")
            B += 1
            LogDeErro()
            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Fornecedor"
        BarraProdgresso()


        '**********GRUPO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Grupo order by CODGRUPO", strBanco)
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("CODGRUPO").ToString

            Dim strNome As String = dt.Rows.Item(I).Item("DESCRICAO").ToString
            Dim strTipo As String = "G"

            Dim dtG As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Nome = '" & strNome.Trim & "'")
            If dtG.Rows.Count = 0 Then
                Inserir("Insert into Grupo (Nome, Tipo) values('" & strNome & "','" & strTipo & "')")
            End If

            B += 1
            LogDeErro()
            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
       
        strTabela = "Grupo"
        BarraProdgresso()
        '**********PRODUTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Produtos order by CODPROD", strBanco)
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB

        For I = 0 To dt.Rows.Count - 1

            Dim strCodigo As String = dt.Rows.Item(I).Item("CODPROD").ToString



            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Produto (Nome) VALUES ('SQL SERVER')")
                    B += 1
                    LogDeErro()
                Next


            End If


            Dim strNome As String = dt.Rows.Item(I).Item("DESCRICAO").ToString.Replace("'", "´")
            Dim strUnidadeMedida As String = dt.Rows.Item(I).Item("UNIDADE").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("PRECO_UNIT").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("PRECO_CUST").ToString

            Dim strPorcentagens As String = dt.Rows.Item(I).Item("MARGEM_BRUTA").ToString


            Dim dtG As DataTable = CarregarDataTable2("SELECT DESCRICAO FROM Grupo where CODGRUPO = " & dt.Rows.Item(I).Item("CODGRUPO").ToString, strBanco)
            Dim strGrupo As String = dtG.Rows.Item(0).Item("DESCRICAO").ToString


            Dim strObs As String = dt.Rows.Item(I).Item("OBS").ToString

            Dim strData As String = dt.Rows.Item(I).Item("DTINCLUI").ToString

            Dim strCodigoBarra As String = dt.Rows.Item(I).Item("BARRA").ToString

            Dim strTipo As String = "VENDA"



            Dim strEstoque As String = dt.Rows.Item(I).Item("ESTOQUE").ToString
            Dim strEstoqueMin As String = dt.Rows.Item(I).Item("ESTOQUE_MIN").ToString
            Dim strEmFalta As String
            Dim dblQtdMin As Double = strEstoqueMin
            Dim dblQtd As Double = strEstoque
            If dblQtdMin > dblQtd Then
                strEmFalta = 1
            Else
                strEmFalta = 0
            End If
            Dim strLote As String = ""


            If strCodigo.Length = 1 Then
                strCodigo = "000" & strCodigo
            ElseIf strCodigo.Length = 2 Then
                strCodigo = "00" & strCodigo
            ElseIf strCodigo.Length = 3 Then
                strCodigo = "0" & strCodigo
            ElseIf strCodigo.Length = 5 Then
                strCodigo = "0" & strCodigo
            End If
            Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Porcentagens, Grupo, Obs, Data, CodigoInterno, CodigoBarra, NivelComboCodCF, Desconto, Tipo) VALUES ('" & strNome.Replace("'", "´") & "','UN'," & Num(strValor) & "," & Num(strValorCusto) & ",'" & strPorcentagens & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "','" & strData & "','" & strCodigo & "','" & strCodigoBarra & "','0',0,'" & strTipo & "')")

            Dim intDia, intMes, intAno, intHora, intMinuto As Integer

            intDia = Date.Today.Day
            intMes = Month(Now)
            intAno = Year(Now)
            intHora = Hour(Now)
            intMinuto = Minute(Now)
            strLote = intDia.ToString("00") & intMes.ToString("00") & intAno & "-" & intHora.ToString("00") & intMinuto.ToString("00")

            Dim intCodiProd As Integer = GerarCodigo("Produto", "Codigo", 0) - 1
            If dblQtd > 0 Then
                Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, Acabou) VALUES (" & intCodiProd & ",'U'," & Num(strEstoqueMin) & "," & Num(strEstoque) & ",'" & strLote & "'," & Num(strValorCusto) & ",'" & strEmFalta & "',1,'False')")

            End If


            B += 1
            LogDeErro()
            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        Excluir("DELETE FROM Produto where Nome = 'SQL SERVER'")

        strTabela = "Produto"
        BarraProdgresso()

        Me.Cursor = Cursors.Default
        Me.rtbMens.AppendText(vbCrLf & "Tabelas migradas com sucesso!")
        Me.btnOk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    End Sub

    Private Sub BarraProdgresso()
        If pb.Value < intMax Then
            pb.Value = pb.Value + 10
        End If
        Clipboard.SetImage(Me.ImageList1.Images.Item(0))
        Me.rtbMens.Paste()
        Me.rtbMens.AppendText(" Tabela " & strTabela & " migrada com sucesso!" & vbCrLf)

        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub
    Private Sub BarraProgresso2()
        If pb1.Value < intPB Then
            pb1.Value = pb1.Value + 1
        End If
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub
    Private Sub LogDeErro()
        If MensagemDeErro <> "" Then
            Clipboard.SetImage(Me.ImageList1.Images.Item(1))
            Me.rtbMens.Paste()
            Me.rtbMens.AppendText(" " & MensagemDeErro & vbCrLf)
            MensagemDeErro = ""
            Application.DoEvents()
            System.Threading.Thread.Sleep(40)
        End If

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub


End Class