Imports Nano.clsFuncoes
Imports System.Globalization
Imports System
Imports System.IO
Public Class frmCrediario3

    Public intOrdem, intCodCliente As Integer
    Public dblValorCrediario, dblValorTotal As Double
    Public strPagamento, strCliente, strDataVenda As String
    Public bolOK As Boolean = False

    Private Sub seParcela_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seParcela.EditValueChanged
        GerarParecelas()
    End Sub

    Private Sub seParcela_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seParcela.Enter

        If Validar(Me.txtValCred) = False Then Exit Sub
        If Validar(Me.dtVen) = False Then Exit Sub
        If Validar(Me.txtDias) = False Then Exit Sub
        GerarParecelas()
    End Sub

    Private Sub txtValCred_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValCred.Leave
        Me.txtJuros.Focus()
    End Sub

    Private Sub txtJuros_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJuros.Leave
        If Me.txtJuros.Text.Trim = "" Then Exit Sub
        If Me.txtValCred.Text.Trim = "" Then Me.txtJuros.ResetText() : Exit Sub

        Me.tdCred.Rows.Clear()

        Dim dblValCred, dblPor, dblResto, dblResul As Double

        dblValCred = dblValorCrediario
        dblPor = Me.txtJuros.Text.Trim

        dblResto = (dblValCred / 100) * dblPor

        dblResul = dblValCred + dblResto

        Me.txtValCred.Text = dblResul.ToString("0.00")

    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick

        Me.Close()
    End Sub

    Private Sub btnClear_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClear.ItemClick

        If MsgBox("Você tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Me.txtValCred.Text = dblValorCrediario
        Me.txtJuros.ResetText()
        Me.dtVen.EditValue = DBNull.Value
        Me.seParcela.Value = 0

        Me.tdCred.Rows.Clear()

        Me.txtJuros.Focus()

    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If Me.tdCred.Rows.Count = 0 Then Exit Sub

        'Dim I As Integer
        'Dim strValPar, strVenc, strNumDoc As String

        'strVenc = ""
        'For I = 0 To Me.tdCred.Rows.Count - 1

        '    strValPar = Me.tdCred.Rows.Item(I).Item("Valor").ToString
        '    strVenc = Me.tdCred.Rows.Item(I).Item("Vencimento")
        '    strNumDoc = Me.tdCred.Rows.Item(I).Item("Documento").ToString

        '    'Inserir("Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, RecebidoOK) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ",'" & "A PRAZO" & "','" & I + 1 & "/" & Me.tdCred.Rows.Count & "'," & Num(strValPar) & ",'" & strVenc & "'," & Num(Me.txtValCred.Text.Trim) & ",'" & strPagamento & "','" & strNumDoc & "','" & "V" & "'," & CodConfig & ",'False')")
        '    frmVenda.strCmdsPagamento &= "Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, RecebidoOK) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ",'" & "A PRAZO" & "','" & I + 1 & "/" & Me.tdCred.Rows.Count & "'," & Num(strValPar) & ",'" & strVenc & "'," & Num(Me.txtValCred.Text.Trim) & ",'" & strPagamento & "','" & strNumDoc & "','" & "V" & "'," & CodConfig & ",'False')"
        'Next
        If Me.Tag = "PEDIDO" Then
            Dim I As Integer
            Dim strValPar, strVenc, strNumDoc As String

            strVenc = ""
            For I = 0 To Me.tdCred.Rows.Count - 1

                strValPar = Me.tdCred.Rows.Item(I).Item("Valor").ToString
                strVenc = Me.tdCred.Rows.Item(I).Item("Vencimento")
                strNumDoc = Me.tdCred.Rows.Item(I).Item("Documento").ToString

                Inserir("Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, " & _
                "ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, " & _
                "RecebidoOK, CodigoPedido) Values(0,'" & Date.Today & "'," & intCodCliente & "," & _
                "'" & "A PRAZO" & "','" & I + 1 & "/" & Me.tdCred.Rows.Count & "'," & Num(strValPar) & "," & _
                "'" & strVenc & "'," & Num(Me.txtValCred.Text.Trim) & ",'" & strPagamento & "','" & strNumDoc & "'," & _
                "'" & "V" & "'," & CodConfig & ",'False','" & intOrdem & "')")
            Next
            SalvarCrediario = True
            frmRecebimento.bolParcSalvo = True
        Else
            frmVenda.bolCrediarioOK = True

        End If
       

        'If MsgBox("Deseja imprimir o carnê?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

        '    'corrigir no Commerce sql
        '    '##################################################################################################################
        '    If ModeloCarne.Trim = "1" Or ModeloCarne.Trim = "" Then


        '        Dim rel As New relCred
        '        rel.picLogo.Image = LogoTipo
        '        For I = 0 To Me.grd1.RowCount - 1
        '            rel.tbCred.Rows.Add()
        '            rel.tbCred.Rows.Item(I).Item("Vencimento") = Me.grd1.GetRowCellDisplayText(I, Me.colVencimento)
        '            rel.tbCred.Rows.Item(I).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
        '            rel.tbCred.Rows.Item(I).Item("CodVenda") = intOrdem
        '            rel.tbCred.Rows.Item(I).Item("Prest") = Me.grd1.GetRowCellDisplayText(I, Me.colParcela) & "/" & Me.grd1.RowCount


        '            rel.tbCred.Rows.Item(I).Item("Cliente") = strCliente

        '            rel.tbCred.Rows.Item(I).Item("Empresa") = NomeEmpresa
        '            rel.tbCred.Rows.Item(I).Item("Endereco") = EnderecoEmpresa
        '            rel.tbCred.Rows.Item(I).Item("Telefone") = TelefoneEmpresa
        '            rel.tbCred.Rows.Item(I).Item("Data") = strDataVenda
        '        Next

        '        rel.ShowPreviewDialog()


        '    ElseIf ModeloCarne.Trim = "2" Then

        '        If Impressora = "DARUMA" Then
        '            If TemImpressora = False Then Exit Sub

        '            Dim strImpressao As String

        '            strImpressao = "<tc>#</tc>" & vbCrLf

        '            strImpressao &= "<b><e><ce>" & NomeEmpresa.ToString.Trim & "</ce></e></b>" & vbCrLf

        '            strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

        '            strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
        '            strImpressao &= "<tc>#</tc>" & vbCrLf
        '            strImpressao &= "<ad>Ordem Nº " & intOrdem & "  <dt></dt></ad>" & vbCrLf
        '            strImpressao &= "<l></l>" & vbCrLf
        '            strImpressao &= "<e><ce>CREDIÁRIO" & "</ce></e>" & vbCrLf
        '            strImpressao &= "<tc>-</tc>" & vbCrLf

        '            Dim dt As DataTable

        '            dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

        '            If dt.Rows.Count > 0 Then
        '                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
        '                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Nome").ToString & " CPF/CNPJ: " & dt.Rows.Item(0).Item("CPF").ToString & "</c>" & vbCrLf
        '                End If

        '                If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
        '                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & "</c>" & vbCrLf
        '                End If

        '                If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
        '                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
        '                End If

        '                If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
        '                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
        '                End If

        '            End If

        '            strImpressao &= "<tc>-</tc>" & vbCrLf


        '            For I = 0 To Me.grd1.RowCount - 1
        '                strImpressao &= "<c>Nº Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcela).Trim & "</c>" & vbCrLf
        '                strImpressao &= "<c>Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim & "</c>" & vbCrLf
        '                strImpressao &= "<c><b>Valor Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValor).Trim & "    Data Pagamento:____/____/________</b></c>" & vbCrLf
        '                strImpressao &= "<l></l>" & vbCrLf
        '                strImpressao &= "<c>Autenticação:_______________________________________</c>" & vbCrLf
        '                strImpressao &= "<tc>-</tc>" & vbCrLf

        '            Next

        '            strImpressao &= "<l></l>" & vbCrLf

        '            strImpressao &= "<c><b>Total Crediário: R$ " & txtValCred.Text.Trim & "</b></c>" & vbCrLf

        '            strImpressao &= "<l></l>" & vbCrLf

        '            strImpressao &= "<e><ce>DOCUMENTO NÃO FISCAL" & "</ce></e>" & vbCrLf

        '            strImpressao &= "<tc>-</tc>" & vbCrLf
        '            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
        '            strImpressao &= "<l></l>" & vbCrLf
        '            strImpressao &= "<l></l>" & vbCrLf
        '            strImpressao &= "<l></l>" & vbCrLf

        '            If TemGuilhotina = True Then
        '                strImpressao &= "<gui></gui>" & vbCrLf
        '            End If

        '            If ImpressoraOK() = True Then
        '                iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
        '            End If
        '        ElseIf Impressora.Contains("BEMATECH") Or Impressora.Contains("ARQUIVO") Then
        '            Dim strImpressao As String
        '            If Impressora.Contains("MP-4000") Then
        '                iRetorno = ConfiguraModeloImpressora(5)
        '                iRetorno = SelecionaQualidadeImpressao(3)
        '            Else
        '                iRetorno = ConfiguraModeloImpressora(1)
        '            End If


        '            iRetorno = IniciaPorta(PortaImpressora)

        '            Dim intTamEsp As Integer
        '            Dim strEstrela, strTraço As String

        '            If Impressora = "ARQUIVO" Then
        '                intTamEsp = 48
        '                strEstrela = "************************************************"
        '                strTraço = "------------------------------------------------"
        '            Else
        '                intTamEsp = 60
        '                strEstrela = "************************************************************"
        '                strTraço = "------------------------------------------------------------"
        '            End If


        '            strImpressao = strEstrela & vbCrLf

        '            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
        '            strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
        '            strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf

        '            strImpressao &= strEstrela & vbCrLf
        '            strImpressao &= Dir("Ordem N - " & intOrdem, intTamEsp) & vbCrLf
        '            strImpressao &= " " & vbCrLf
        '            strImpressao &= Cent("CREDIÁRIO", intTamEsp) & vbCrLf

        '            strImpressao &= strTraço & vbCrLf

        '            Dim dt As DataTable

        '            dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

        '            If dt.Rows.Count > 0 Then
        '                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
        '                    strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & " CPF/CNPJ: " & dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
        '                End If

        '                If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
        '                    strImpressao &= dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
        '                End If

        '                If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
        '                    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
        '                End If

        '                If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
        '                    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
        '                End If

        '            End If

        '            strImpressao &= strTraço & vbCrLf


        '            For I = 0 To Me.grd1.RowCount - 1
        '                strImpressao &= "N. Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcela).Trim & vbCrLf
        '                strImpressao &= "Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim & vbCrLf
        '                strImpressao &= "Valor Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValor).Trim & "  Dt Pag:___/___/______" & vbCrLf
        '                strImpressao &= " " & vbCrLf
        '                strImpressao &= "Autenticação:____________________________________" & vbCrLf
        '                strImpressao &= strTraço & vbCrLf

        '            Next

        '            strImpressao &= " " & vbCrLf

        '            strImpressao &= "Total Crediário: R$ " & txtValCred.Text.Trim & vbCrLf

        '            strImpressao &= " " & vbCrLf

        '            strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

        '            strImpressao &= strTraço & vbCrLf
        '            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

        '            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U").Replace("Ç", "C").Replace("ç", "c")


        '            If Impressora = "ARQUIVO" Then
        '                ImprimiArquivo(strImpressao)
        '            Else

        '                iRetorno = FormataTX(strImpressao, 1, 0, 0, 0, 1)

        '                If TemGuilhotina = True Then
        '                    iRetorno = AcionaGuilhotina(0)
        '                End If

        '            End If


        '            iRetorno = FechaPorta()

        '        End If

        '    End If

        '    'ATÉ AQUI
        '    '###################################################################################################################
        'End If

        'If NomeEmpresa.Contains("TAUÁ") = False Then

        '    If MsgBox("Deseja imprimir a NOTA PROMISSÓRIA?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        '        Dim rel As New relPromissoria
        '        Dim culture As New CultureInfo("pt-BR")
        '        Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
        '        Dim dia As Integer = DateTime.Now.Day
        '        Dim ano As Integer = DateTime.Now.Year
        '        Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))
        '        Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek))
        '        Dim data As String = diasemana & ", " & dia & " de " & mes & " de " & ano
        '        Dim vetData As Array
        '        vetData = Split(strVenc, "/")
        '        Dim intMes, intDia, intAno As Integer
        '        intMes = vetData(1)
        '        intDia = vetData(0)
        '        intAno = vetData(2)
        '        Dim strMesVenc As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(intMes))
        '        Dim strDia As String = getInteger(intDia)
        '        Dim strAno As String = getInteger(intAno)
        '        Dim dt As DataTable
        '        dt = CarregarDataTable("SELECT Nome, Endereco, Numero, Bairro, Cidade , Estado, CPF FROM Cliente where Codigo = " & intCodCliente)
        '        Dim strEndereco As String
        '        strEndereco = dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & "  " & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & " - " & dt.Rows.Item(0).Item("Estado").ToString
        '        rel.lblPagavel.Text = CidadeEmpresa
        '        rel.lblCPF1.Text = CNPJEmpresa
        '        rel.lblCidade.Text = CidadeEmpresa & ","
        '        rel.lblDiaAtual.Text = Date.Today.Day
        '        rel.lblMesAtual.Text = mes.ToUpper
        '        rel.lblAnoAtual.Text = Date.Today.Year
        '        rel.lblDia.Text = intDia
        '        rel.lblMes.Text = strMesVenc.ToUpper
        '        rel.lblAno.Text = intAno
        '        rel.lblEmit.Text = strCliente
        '        rel.lblEnd.Text = strEndereco
        '        rel.lblCPF2.Text = dt.Rows.Item(0).Item("CPF").ToString
        '        rel.lblVia.Text = NomeEmpresa
        '        If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
        '            If dt.Rows.Item(0).Item("CPF").ToString.Length > 13 Then
        '                rel.lblPagar.Text = "EMOS"
        '            Else
        '                rel.lblPagar.Text = "EI"
        '            End If
        '        Else
        '            rel.lblPagar.Text = "EI"
        '        End If


        '        rel.lblNumero.Text = "01/01"
        '        rel.lblValor.Text = dblValorTotal.ToString("0.00")
        '        Dim strValorExt As String = dblValorTotal.ToString("0.00")
        '        Dim vetValor As Array
        '        vetValor = Split(strValorExt, ",")
        '        Dim strReais, strCentavos As String
        '        strReais = getInteger(vetValor(0))
        '        If vetValor(1) = "00" Then
        '            strValorExt = strReais.ToUpper & " REAIS"
        '        Else
        '            strCentavos = getInteger(vetValor(1))
        '            strValorExt = strReais.ToUpper & " REAIS E " & strCentavos.ToUpper & " CENTAVOS"
        '        End If
        '        rel.lblValorExt.Text = strValorExt
        '        rel.lblAos.Text = "DIA " & strDia.ToUpper & " DO MÊS DE " & strMesVenc.ToUpper & " DO ANO DE " & strAno.ToUpper
        '        rel.ShowPreviewDialog()
        '    End If
        'End If

        'frmVenda.bolCrediarioOK = True

        Me.Close()

    End Sub

    Private Sub GerarParecelas()
        Dim I As Integer
        Dim dblValCred, dblValPar As Double

        dblValCred = Me.txtValCred.Text.Trim

        dblValPar = dblValCred / Me.seParcela.Value

        Dim dtDate As Date = Me.dtVen.DateTime

        Me.tdCred.Rows.Clear()
        Dim dblTotal As Double
        For I = 0 To Me.seParcela.Value - 1

            With Me.tdCred.Rows
                .Add()

                .Item(I).Item("Parcela") = I + 1
                .Item(I).Item("Valor") = dblValPar.ToString("0.00")
                .Item(I).Item("Vencimento") = dtDate
                .Item(I).Item("Pagamento") = frmVenda.cboPag.Text.Trim

                If Me.txtDias.Text = "30" Then
                    dtDate = dtDate.AddMonths(1)
                Else
                    dtDate = dtDate.AddDays(Me.txtDias.Text)
                End If
                dblTotal += dblValPar
            End With

        Next

        GerarJuros()

        If dblTotal > 0 Then
            Dim dblResul As Double = dblValCred - dblTotal
            If dblResul > "0,5" Then
                MsgBox("A soma das parcelas não batem com o valor da conta!", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub GerarJuros()

        Dim I As Integer
        Dim dblValConta As Double

        If JurosPorParcela > 0 Then
            If Me.seParcela.Value >= JurosPorParcela Then
                Dim intPar As Integer = Me.seParcela.Value - JurosPorParcela

                Dim dtParcela2 As Date
                Dim dtParcela1 As Date
                For I = 0 To Me.tdCred.Rows.Count - 1
                    If Me.tdCred.Rows.Item(I).Item("Parcela") = JurosPorParcela Then
                        dtParcela1 = Me.tdCred.Rows.Item(I).Item("Vencimento")
                    End If
                    If Me.tdCred.Rows.Item(I).Item("Parcela") = Me.tdCred.Rows.Count Then
                        dtParcela2 = Me.tdCred.Rows.Item(I).Item("Vencimento")
                    End If
                Next
                Dim tsHora As TimeSpan
                Dim intDias As Integer
                tsHora = dtParcela2.Subtract(dtParcela1)
                intDias = tsHora.Days

                dblValConta = Me.txtValCred.Text.Trim
                Dim dblResul As Double = (PorcentualJuros * dblValConta) / 100
                dblResul = (dblResul * intDias) + dblValConta
                dblValConta = dblResul
                Dim dblValPar As Double
                dblValPar = dblValConta / Me.seParcela.Value


                For I = 0 To Me.seParcela.Value - 1
                    Me.tdCred.Rows.Item(I).Item("Valor") = dblValPar.ToString("0.00")
                Next
            End If

        End If

    End Sub


    Private Sub frmCrediario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmVenda.bolCrediarioOK = True Then
            If frmVenda.txtLimite.Text.Trim <> "" Then
                frmVenda.txtLimite.Text = (CDbl(frmVenda.txtLimite.Text) - CDbl(Me.txtValCred.Text.Trim)).ToString("0.00")
            End If
        Else
            Me.txtValCred.Text = dblValorCrediario
            Me.txtJuros.ResetText()
            Me.dtVen.EditValue = DBNull.Value
            Me.seParcela.Value = 0

            Me.tdCred.Rows.Clear()

            Me.txtJuros.Focus()
        End If
    End Sub

    Private Sub frmCrediario3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.tdCred.Rows.Count = 0 Then Exit Sub

            frmVenda.bolCrediarioOK = True
            bolOK = True
            frmRecebimento.bolParcSalvo = True

            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCrediario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.colValor.OptionsColumn.ReadOnly = BloquearParcelas
        Me.colVencimento.OptionsColumn.ReadOnly = BloquearParcelas

        GerarParecelas()



        'Dim dtConfig As DataTable = CarregarDataTable("SELECT JurosParcela, Juros FROM Config")
        'If dtConfig.Rows.Count > 0 Then
        '    If dtConfig.Rows.Item(0).Item("JurosParcela").ToString <> "" Then
        '        intJurosParcela = dtConfig.Rows.Item(0).Item("JurosParcela").ToString
        '        If dtConfig.Rows.Item(0).Item("Juros").ToString <> "" Then
        '            dblJurosParcela = dtConfig.Rows.Item(0).Item("Juros").ToString
        '        End If

        '    Else
        '        intJurosParcela = 0
        '        dblJurosParcela = 0
        '    End If
        'Else
        '    intJurosParcela = 0
        '    dblJurosParcela = 0
        'End If
    End Sub

    Private Sub txtVal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVal.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "," And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVal.Leave
        If Me.grd1.GetFocusedDisplayText = "" Then Exit Sub
        Try
            Dim dblVal As Double = Me.grd1.GetFocusedDisplayText
            Me.grd1.SetFocusedValue(dblVal.ToString("0.00"))


            If Me.txtValCred.Text = "" Then Exit Sub
            If Me.seParcela.Text = "" Then Exit Sub
            Dim dblTotal As Double
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                dblTotal += Me.grd1.GetRowCellDisplayText(I, Me.colValor)

            Next

            Dim dblvalor As Double = Me.txtValCred.Text
            Dim dblResul As Double = dblvalor - dblTotal
            If dblResul > "0,5" Then
                MsgBox("A soma das parcelas não batem com o valor da conta!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            Me.grd1.SetFocusedValue("")
        End Try
    End Sub
    Private Sub txtDias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDias.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDias_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDias.Leave
        If Validar(Me.txtValCred) = False Then Exit Sub
        If Validar(Me.dtVen) = False Then Exit Sub
        If Validar(Me.txtDias) = False Then Exit Sub
        GerarParecelas()
    End Sub
End Class