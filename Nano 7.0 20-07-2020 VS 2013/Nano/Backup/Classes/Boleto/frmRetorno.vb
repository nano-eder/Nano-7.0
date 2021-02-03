Imports Nano.clsFuncoes
Imports System.IO
Public Class frmRetorno

    Dim strCodigoBanco As String
    Dim strCaminhoArquivo As String
    Private Sub frmRetorno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDadosLue("SELECT Codigo, NomeBanco as Nome FROM Banco", Me.lueBanco)

        Limpar(True)

    End Sub

    Private Sub Limpar(ByVal parBotao As Boolean)
        Me.tbRetorno.Rows.Clear()
        Me.txtCaminhoRetorno.ResetText()
        Me.txtCaminhoRetorno.Focus()

        Me.txtAgencia.ResetText()
        Me.txtCodCedente.ResetText()
        Me.txtContaCorrente.ResetText()
        Me.txtCedente.ResetText()
        Me.txtCPFCedente.ResetText()
        Me.txtCarteira.ResetText()
        If parBotao = True Then
            Dim dt As DataTable = CarregarDataTable("SELECT NomeBanco FROM Banco where Padrao = 'True' and CodConfig = " & CodConfig)
            If dt.Rows.Count > 0 Then
                Me.lueBanco.Text = dt.Rows.Item(0).Item("NomeBanco").ToString
            End If
        End If
        
    
    End Sub
 
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtCaminhoRetorno_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCaminhoRetorno.ButtonClick

        Me.ofdRetorno.ShowDialog()
        Me.txtCaminhoRetorno.Text = Me.ofdRetorno.FileName
        If Me.txtCaminhoRetorno.Text = "" Then
            Me.tbRetorno.Rows.Clear()
            Me.txtCaminhoRetorno.Focus()
            Exit Sub
        End If
        Dim strArquivoNome As String = System.IO.Path.GetFileName(Me.ofdRetorno.FileName)
        Dim strArquivoDiretorio As String = System.IO.Path.GetDirectoryName(Me.ofdRetorno.FileName)
        Me.tbRetorno.Rows.Clear()
        If strCodigoBanco = "" Then MsgBox("Seleciona o banco!", MsgBoxStyle.Information) : Me.txtCaminhoRetorno.ResetText() : Exit Sub
        If File.Exists(Me.txtCaminhoRetorno.Text) = False Then Exit Sub

        Dim CobreBemX As CobreBemX.ContaCorrente


        CobreBemX = New CobreBemX.ContaCorrente

        Dim intCodOrdem As Integer = GerarCodigoOrdensBanco("Boleto", CodBanco)

        CobreBemX.ArquivoLicenca = strCaminhoArquivo
        CobreBemX.CodigoAgencia = Me.txtAgencia.Text
        CobreBemX.NumeroContaCorrente = Me.txtContaCorrente.Text
        CobreBemX.CodigoCedente = Me.txtCodCedente.Text

        Select Case CodigoBancoBoleto
            Case "341"
                CobreBemX.InicioNossoNumero = "00000001"
                CobreBemX.FimNossoNumero = "99999999"
                CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000000")

            Case "104"
                CobreBemX.InicioNossoNumero = "000000001"
                CobreBemX.FimNossoNumero = "999999999"
                CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "000000000")
            Case "756"
                CobreBemX.InicioNossoNumero = "0000001"
                CobreBemX.FimNossoNumero = "9999999"
                CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "0000000")
                CobreBemX.ArquivoRetorno.Layout = "FEBRABAN240"
            Case Else
                CobreBemX.InicioNossoNumero = "00001"
                CobreBemX.FimNossoNumero = "99999"
                CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000")

        End Select
        CobreBemX.ArquivoRetorno.Diretorio = strArquivoDiretorio & "\"
        CobreBemX.ArquivoRetorno.Arquivo = strArquivoNome

        CobreBemX.CarregaArquivosRetorno()

        Dim I As Integer
        If CobreBemX.OcorrenciasCobranca.Count > 0 Then
            Dim strrr As String = CobreBemX.OcorrenciasCobranca(0).Agencia
            Dim ss As String = CobreBemX.OcorrenciasCobranca(0).Agencia.Substring(1, strrr.Length - 2)
            Select Case CodigoBancoBoleto
                Case "756"
                    If Me.txtAgencia.Text.Contains(CobreBemX.OcorrenciasCobranca(0).Agencia.Substring(1, strrr.Length - 2)) = False Then
                        MsgBox("Arquivo inválido!", MsgBoxStyle.Information)
                        Me.txtCaminhoRetorno.ResetText()
                        Exit Sub
                    End If
                Case Else
                    If Me.txtAgencia.Text.Contains(CobreBemX.OcorrenciasCobranca(0).Agencia) = False Then
                        MsgBox("Arquivo inválido!", MsgBoxStyle.Information)
                        Me.txtCaminhoRetorno.ResetText()
                        Exit Sub
                    End If
            End Select
           
            Me.txtCarteira.Text = CobreBemX.OcorrenciasCobranca(0).Carteira
            Me.txtAgencia.Text = CobreBemX.OcorrenciasCobranca(0).Agencia
            Me.txtCodCedente.Text = CobreBemX.OcorrenciasCobranca(0).CodigoCedente
            Me.txtContaCorrente.Text = CobreBemX.OcorrenciasCobranca(0).ContaCorrente
            Me.txtCPFCedente.Text = CPFCedente
            Me.txtCedente.Text = NomeCedente
        Else
            MsgBox("Arquivo inválido!", MsgBoxStyle.Information)
            Me.txtCaminhoRetorno.ResetText()
            Exit Sub
        End If
        For I = 0 To CobreBemX.OcorrenciasCobranca.Count - 1
            Dim strOcorrencia As String = Me.grd1.GetRowCellDisplayText(I, Me.colOcorrencia)

            Me.tbRetorno.Rows.Add()
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("CodigoBanco") = ""
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("NomeBanco") = CobreBemX.OcorrenciasCobranca(I).Banco
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("Agencia") = CobreBemX.OcorrenciasCobranca(I).Agencia
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("CodigoCedente") = CobreBemX.OcorrenciasCobranca(I).CodigoCedente
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("DataRecebimento") = CobreBemX.OcorrenciasCobranca(I).DataCredito

            Dim strNossoNumero As String = ""
            Select Case strCodigoBanco
                Case "341"
                    strNossoNumero = CobreBemX.OcorrenciasCobranca(I).NossoNumero
                    strNossoNumero = Format(CInt(strNossoNumero), "00000000")

                Case Else
                    strNossoNumero = CobreBemX.OcorrenciasCobranca(I).NossoNumero
            End Select


            Dim dt As DataTable = CarregarDataTable("SELECT Boleto.Codigo, CodOrdem, Boleto.CodBanco, NumeroDocumento, Boleto.Status, " & _
             "StatusRetorno, case when Cliente.Nome is null then Fornecedor.Nome else Cliente.Nome end  as Cliente, CodigoConta FROM " & _
             "((Boleto left join Banco on Boleto.CodBanco = Banco.Codigo) left join Cliente on Boleto.CodCli = Cliente.Codigo) left join Fornecedor on " & _
             "Boleto.CodFor = Fornecedor.Codigo where CodigoBanco = '" & CodigoBancoBoleto & "' and NossoNumero = '" & strNossoNumero & "'")
            Dim strSacado As String = ""
            Dim strStatus As String = ""
            If dt.Rows.Count > 0 Then
                strSacado = dt.Rows.Item(0).Item("Cliente").ToString
                strStatus = dt.Rows.Item(0).Item("StatusRetorno").ToString
            End If

            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("NossoNumero") = strNossoNumero
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("Ocorrencia") = CobreBemX.OcorrenciasCobranca(I).CodigoOcorrencia
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("Sacado") = strSacado
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("Status") = strStatus
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("CodOrdem") = CobreBemX.OcorrenciasCobranca(I).NumeroDocumento
            Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("PagoOk") = CobreBemX.OcorrenciasCobranca(I).Pagamento
            If CobreBemX.OcorrenciasCobranca(I).Pagamento = True Then
                Dim dblValor As Double = CobreBemX.OcorrenciasCobranca(I).ValorPago
                Me.tbRetorno.Rows.Item(Me.tbRetorno.Rows.Count - 1).Item("ValorTotal") = dblValor.ToString("0.00")
            End If
        Next
    End Sub

  
    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar(True)

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        'Dim rel As New relRetorno

        'rel.lblTitulo.Text = "Relatório de Boletos Retorno"

        'rel.picLogo.Image = LogoTipo
        'Dim I As Integer

        'With rel.tbRetorno.Rows
        '    For I = 0 To Me.grd1.RowCount - 1
        '        .Add()
        '        .Item(I).Item("NossoNumero") = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)
        '        .Item(I).Item("Sacado") = Me.grd1.GetRowCellDisplayText(I, Me.colSacado)
        '        .Item(I).Item("NumeroDocumento") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
        '        .Item(I).Item("Vencimento") = Me.grd1.GetRowCellDisplayText(I, Me.colVencimento)
        '        .Item(I).Item("ValorFatura") = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
        '        .Item(I).Item("Recebimento") = Me.grd1.GetRowCellDisplayText(I, Me.colDataRecebimento)
        '        .Item(I).Item("Ocorrencia") = Me.grd1.GetRowCellDisplayText(I, Me.colOcorrencia)
        '        .Item(I).Item("Carteira") = Me.grd1.GetRowCellDisplayText(I, Me.colCarteira)
        '    Next
        'End With
        'rel.lblCedente.Text = Me.txtCedente.Text
        'rel.lblCodBanco.Text = Me.txtCodBanco.Text
        'rel.lblCnpj.Text = Me.txtCPFCedente.Text
        'rel.lblAgencia.Text = Me.txtAgencia.Text
        'rel.lblCodCedente.Text = Me.txtCodCedente.Text
        'rel.lblContaCorrente.Text = Me.txtContaCorrente.Text
        'rel.lblNomeBanco.Text = Me.cboNomeBanco.Text

        'rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnSalvar1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar1.ItemClick

        Dim I As Integer
        Dim bolLiquidado As Boolean = False
        For I = 0 To Me.grd1.RowCount - 1
            Dim bolPago As Boolean = Me.grd1.GetRowCellValue(I, Me.colPagoOk)
            If bolPago = True Then


                Dim strNomeBanco As String = Me.grd1.GetRowCellDisplayText(I, Me.colNomeBanco)
                Dim strCodigoBanco As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoBanco)
                Dim strAgencia As String = Me.grd1.GetRowCellDisplayText(I, Me.colAgencia)
                Dim strCodigoCendente As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoCedente)
                Dim strNossoNumero As String = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)
               
                Dim strDataRecebimento As String = Me.grd1.GetRowCellDisplayText(I, Me.colDataRecebimento)
                Dim strValor As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)

                Select Case CodigoBancoBoleto
                    Case "341"
                        strNossoNumero = Format(CInt(strNossoNumero), "0000000")
                    Case "756"
                        strNossoNumero = Format(CInt(strNossoNumero), "0000000")
                    Case Else

                        'CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000")
                        strNossoNumero = Format(CInt(strNossoNumero), "0000000000000")

                End Select
                
                Dim dt As DataTable = CarregarDataTable("SELECT Boleto.Codigo, CodOrdem, Boleto.CodBanco, NumeroDocumento, Boleto.Status, " & _
                "StatusRetorno, case when Cliente.Nome is null then Fornecedor.Nome else Cliente.Nome end  as Cliente, CodigoConta FROM " & _
                "((Boleto left join Banco on Boleto.CodBanco = Banco.Codigo) left join Cliente on Boleto.CodCli = Cliente.Codigo) left join Fornecedor on " & _
                "Boleto.CodFor = Fornecedor.Codigo where CodigoBanco = '" & CodigoBancoBoleto & "' and NossoNumero = '" & strNossoNumero & "'")


                If dt.Rows.Count > 0 Then
                    Dim strCodigo As String = dt.Rows.Item(0).Item("Codigo").ToString
                    Dim strNumeroDocumento As String = dt.Rows.Item(0).Item("NumeroDocumento").ToString
                    Dim strCliente As String = dt.Rows.Item(0).Item("Cliente").ToString
                    Dim strStatusRetorno As String = dt.Rows.Item(0).Item("StatusRetorno").ToString
                    Dim strCodigoConta As String = dt.Rows.Item(0).Item("CodigoConta").ToString

                    If strStatusRetorno <> "LIQUÍDADO" Then
                        Dim A As Integer
                        Dim vetConta As Array = Split(strCodigoConta, ",")
                        Dim dtRec As DataTable = Nothing
                        For A = 0 To vetConta.Length - 1
                            Dim strCod As String = vetConta(A).ToString.Trim
                       
                            dtRec = CarregarDataTable("SELECT Codigo, RecebidoOK, Vencimento, ValorParcela FROM ContaReceber where Codigo = " & strCod & " and CodConfig = " & CodConfig)

                         
                            If dtRec.Rows.Count > 0 Then

                                Dim bolRecebidoOk As Boolean = dtRec.Rows.Item(0).Item("RecebidoOK")
                                If bolRecebidoOk = False Then
                                    Dim strCodConta As String = dtRec.Rows.Item(0).Item("Codigo").ToString

                                    If vetConta.Length > 1 Then
                                        Dim dblJuros As Double = strValor
                                   
                                        Dim dtConfig As DataTable = CarregarDataTable("SELECT Tolerancia, Juros FROM Config")
                                        Dim intTole As Integer = dtConfig.Rows.Item(0).Item("Tolerancia").ToString
                                        Dim dblJurosConfig As Double

                                        If dtConfig.Rows.Item(0).Item("Juros").ToString <> "" Then
                                            dblJurosConfig = dtConfig.Rows.Item(0).Item("Juros").ToString
                                        End If

                                        Dim dtVencimento, dtTole As Date
                                        dtVencimento = dtRec.Rows.Item(0).Item("Vencimento").ToString
                                        dtTole = dtVencimento.AddDays(intTole)
                                        Dim tsHora As TimeSpan
                                        Dim intDias As Integer

                                        Dim dtPag As Date = strDataRecebimento

                                        tsHora = dtPag.Subtract(dtTole)
                                        intDias = tsHora.Days

                                        If intDias <= 0 Then
                                            dblJuros = dtRec.Rows.Item(0).Item("ValorParcela").ToString
                                        Else

                                            dtVencimento = dtRec.Rows.Item(0).Item("Vencimento").ToString
                                            tsHora = Now.Subtract(dtVencimento)
                                            intDias = tsHora.Days

                                            Dim dblResul As Double = (dblJurosConfig * dtRec.Rows.Item(0).Item("ValorParcela").ToString) / 100
                                            dblJuros = (dblResul * intDias) + dtRec.Rows.Item(0).Item("ValorParcela").ToString
                                        End If


                                
                                        Atualizar("UPDATE ContaReceber SET FormaPagamento = 'A PRAZO', ValorRecebido = " & Num(dblJuros) & ", " & _
                                        "Recebimento = '" & strDataRecebimento & "', RecebidoOK = 'True', " & _
                                        "Pagamento = 'BOLETO', Banco = '" & strNomeBanco & "', CodLojaBaixa = " & CodConfig & " where Codigo = " & strCodConta)



                                    Else
                                        Dim Cont As Integer
                                        Dim dblNVal As Double
                                        Dim strNVal As String
                                        Cont = vetConta.Length
                                    
                                        dblNVal = Convert.ToDouble(strValor) / Cont
                                        strNVal = dblNVal.ToString("#.00")
                                        Atualizar("UPDATE ContaReceber SET FormaPagamento = 'A PRAZO', ValorRecebido = " & Num(strNVal) & ", " & _
                                      "Recebimento = '" & strDataRecebimento & "', RecebidoOK = 'True', " & _
                                      "Pagamento = 'BOLETO', Banco = '" & strNomeBanco & "', CodLojaBaixa = " & CodConfig & " where Codigo = " & strCodConta)



                                    End If

                                End If

                            End If

                        Next


                        Dim dblValRecebido, dblSaldo, dblResulBanco As Double
                        Dim intCodBanco As Integer
                        Dim strMot As String = strCliente & ", Boleto " & strNossoNumero & " da Venda Nº " & strNumeroDocumento
                        dblValRecebido = strValor
                        Dim dtBanco As DataTable
                        dtBanco = CarregarDataTable("SELECT Codigo, Saldo FROM Banco where CodigoBanco = '" & strNomeBanco & "'")
                        If dtBanco.Rows.Count > 0 Then
                            intCodBanco = dtBanco.Rows.Item(0).Item("Codigo").ToString
                            If dtBanco.Rows.Item(0).Item("Saldo").ToString = "" Then
                                dblSaldo = "0,00"
                            Else
                                dblSaldo = dtBanco.Rows.Item(0).Item("Saldo").ToString
                            End If

                            dblResulBanco = dblSaldo + dblValRecebido
                            Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, " & _
                            "CodConfig)VALUES(" & intCodBanco & ",'CRÉDITO'," & Num(dblValRecebido) & ",'" & strDataRecebimento & "','" & strMot & "'," & CodConfig & ")")
                            Atualizar("UPDATE Banco SET Saldo = " & Num(dblResulBanco) & " where Codigo = " & intCodBanco)
                        End If

                        bolLiquidado = True
                        Atualizar("UPDATE Boleto set StatusRetorno = 'LIQUÍDADO', DataRecebimento = '" & strDataRecebimento & "' where Codigo = " & strCodigo & " and CodConfig = " & CodConfig)

                    End If

                End If

            End If
        Next

        If bolLiquidado = False Then
            MsgBox("Nenhum boleto liquídado!", MsgBoxStyle.Information)
        Else
            MsgBox("Boletos liquídados!", MsgBoxStyle.Information)
        End If
        Me.tbRetorno.Rows.Clear()
        Me.txtCaminhoRetorno.ResetText()
    End Sub

    Private Sub lueBanco_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueBanco.EditValueChanged

        Dim dt As DataTable = CarregarDataTable("SELECT Cedente, CPF, CodigoBanco, NomeBanco, Agencia, CodigoCedente, " & _
        "ContaCorrente, CaminhoArquivo FROM Banco where Codigo = " & Me.lueBanco.EditValue)
        If dt.Rows.Count > 0 Then
            Me.txtAgencia.Text = dt.Rows.Item(0).Item("Agencia").ToString
            Me.txtCodCedente.Text = dt.Rows.Item(0).Item("CodigoCedente").ToString
            Me.txtContaCorrente.Text = dt.Rows.Item(0).Item("ContaCorrente").ToString
            Me.txtCedente.Text = dt.Rows.Item(0).Item("Cedente").ToString
            Me.txtCPFCedente.Text = dt.Rows.Item(0).Item("CPF").ToString
            strCodigoBanco = dt.Rows.Item(0).Item("CodigoBanco").ToString

            strCaminhoArquivo = dt.Rows.Item(0).Item("CaminhoArquivo").ToString
        End If
    End Sub
End Class