Imports Nano.clsFuncoes
Imports Nano.clsFuncoesBematech

Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports System.Text
Public Class frmDav
    Public strArquivoProcessado As String
    Public strStatus As String
    Dim bolManterGrid As Boolean = False
    Dim intCodOrdemManter As Integer = 0
    Dim dtDataFiltro As Date
    Private Sub CarregarGrid()

        If Me.Tag = "Consulta" Then
            CarregarDados("SELECT REPLICATE( '0' ,13 - len(NumDav) ) + NumDav as Dav, '' as Pagamento, Total.CodOrdem, Total.Total as Valor, Cliente.Nome as Cliente, case when Total.NFP = 'False' then '' else CPFCliente end as CPF, Convert(Varchar(10), Total.Data, 103) as Data FROM (Total left join Cliente on Total.CodCli = Cliente.Codigo) left join R4 on Total.CodOrdem = R4.CodOrdem and Total.CodConfig = R4.CodConfig where NumDav <> '0' and Total.CodConfig = " & CodConfig, Me.GridControl1)
        Else
            Dim strData As String = String.Format("Total.Data = '{0:dd/MM/yyyy}'", Date.Today)
            CarregarDados("SELECT REPLICATE( '0' ,13 - len(NumDav) ) + NumDav as Dav, '' as Pagamento, Total.CodOrdem, Total.Total as Valor, Cliente.Nome as Cliente, case when Total.NFP = 'False' then '' else CPFCliente end as CPF, Convert(Varchar(10), Total.Data, 103) as Data FROM (Total left join Cliente on Total.CodCli = Cliente.Codigo) left join R4 on Total.CodOrdem = R4.CodOrdem and Total.CodConfig = R4.CodConfig where NumDav <> '0' and StatusDAV = 'Pendente' and Total.CodConfig = " & CodConfig & " and " & strData, Me.GridControl1)
        End If

        Me.tbProd.Rows.Clear()
        Me.GroupControl2.Text = "Produtos da Venda"

        Dim I As Integer

        For I = 0 To Me.grd1.RowCount - 1
            Dim strCodPed As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
            Dim strPagamento As String = ""
            Dim dtRec As DataTable = CarregarDataTable("SELECT Pagamento FROM Recebimento where Codordem = " & strCodPed & " and CodConfig =  " & CodConfig)

            If dtRec.Rows.Count > 0 Then
                Dim A As Integer

                For A = 0 To dtRec.Rows.Count - 1
                    If A = 0 Then
                        strPagamento = dtRec.Rows.Item(A).Item("Pagamento").ToString

                    Else
                        strPagamento = strPagamento & "," & dtRec.Rows.Item(A).Item("Pagamento").ToString

                    End If

                Next
            End If
            Me.grd1.SetRowCellValue(I, Me.colPagamento, strPagamento)
        Next
        Timer1.Start()
    End Sub

    Private Sub CarregarGridSat(ByVal parData As Date)
        Dim I As Integer
        Dim strData As String = String.Format("Total.Data = '{0:dd/MM/yyyy}'", parData)
        Me.tbDav.Rows.Clear()
        Me.grd1.ClearColumnsFilter()
        Me.grd1.ClearSorting()
        CarregarDados("SELECT '' as Pagamento, Total.CodOrdem, Total.Total as Valor, Cliente.Nome as Cliente, " & _
        "case when Total.NFP = 'False' then '' else CPFCliente end as CPF, Convert(Varchar(10), Total.Data, 103) as Data " & _
        "FROM (Total left join Cliente on Total.CodCli = Cliente.Codigo) left join SatFiscal on " & _
        "Total.CodOrdem = SatFiscal.CodOrdem2 and Total.CodConfig = SatFiscal.CodConfig where SatFiscal.CodOrdem2 is Null " & _
        "and Total.CodConfig = " & CodConfig & " and " & strData, Me.GridControl1)

        Me.tbProd.Rows.Clear()
        Me.GroupControl2.Text = "Produtos da Venda"

        For I = 0 To Me.grd1.RowCount - 1

            Dim strCodPed As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
            Dim strPagamento As String = ""
            Dim dtRec As DataTable = CarregarDataTable("SELECT Pagamento FROM Recebimento where Codordem = " & strCodPed & " and CodConfig =  " & CodConfig)

            If dtRec.Rows.Count > 0 Then
                Dim A As Integer

                For A = 0 To dtRec.Rows.Count - 1
                    If A = 0 Then
                        strPagamento = dtRec.Rows.Item(A).Item("Pagamento").ToString

                    Else
                        strPagamento = strPagamento & "," & dtRec.Rows.Item(A).Item("Pagamento").ToString

                    End If

                Next
            End If
            Me.grd1.SetRowCellValue(I, Me.colPagamento, strPagamento)


        Next


        Timer1.Start()
        Me.colCodOrdem.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
    End Sub
    Private Sub CarregarGridNFCe(ByVal parData As Date)
        Dim I As Integer
        Dim strData As String = String.Format("Total.Data = '{0:dd/MM/yyyy}'", parData)
        Me.tbDav.Rows.Clear()
        Me.grd1.ClearColumnsFilter()
        Me.grd1.ClearSorting()
        CarregarDados("SELECT '' as Pagamento, Total.CodOrdem, Total.Total as Valor, Cliente.Nome as Cliente, " & _
        "case when Total.NFP = 'False' then '' else CPFCliente end as CPF, Convert(Varchar(10), Total.Data, 103) as Data " & _
        "FROM (Total left join Cliente on Total.CodCli = Cliente.Codigo) left join NFCe on " & _
        "Total.CodOrdem = NFCe.CodOrdem and Total.CodConfig = NFCe.CodConfig where NFCe.CodOrdem is Null " & _
        "and Total.CodConfig = " & CodConfig & " and " & strData & " order by Total.CodOrdem Desc", Me.GridControl1)

        Me.tbProd.Rows.Clear()
        Me.GroupControl2.Text = "Produtos da Venda"

        For I = 0 To Me.grd1.RowCount - 1

            Dim strCodPed As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
            Dim strPagamento As String = ""
            Dim dtRec As DataTable = CarregarDataTable("SELECT Pagamento FROM Recebimento where Codordem = " & strCodPed & " and CodConfig =  " & CodConfig)

            If dtRec.Rows.Count > 0 Then
                Dim A As Integer

                For A = 0 To dtRec.Rows.Count - 1
                    If A = 0 Then
                        strPagamento = dtRec.Rows.Item(A).Item("Pagamento").ToString

                    Else
                        strPagamento = strPagamento & "," & dtRec.Rows.Item(A).Item("Pagamento").ToString

                    End If

                Next
            End If
            Me.grd1.SetRowCellValue(I, Me.colPagamento, strPagamento)


        Next


        Timer1.Start()
        Me.colCodOrdem.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
    End Sub
    Private Sub frmDav_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmDav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Data As String = Space(7)
        Me.dtData.EditValue = Nothing
        dtDataFiltro = Date.Today
        'Dim Hora As String = Space(7)
        intCodOrdemManter = 0
        'Retorno = Bematech_FI_DataHoraImpressora(Data, Hora)
        'Dim strD As String = Data
        'Dim strH As String = Hora
        'Retorno = Bematech_FI_ReducaoZ(strD.Trim, strH.Trim)
        Me.btnFaturar.Enabled = True
        If StringDeConexao Is Nothing = True Then
            StringDeConexao = My.Settings.dsNanoCommerce

            'StringOnline = Decrypt("RGF0YSBTb3VyY2U9bWluaGFkbnMuZHluZG5zLm9yZywxNDM1O0luaXRpYWwgQ2F0YWxvZz1kYkVyYVN5c3RlbXM7IFBlcnNpc3QgU2VjdXJpdHkgSW5mbz1UcnVlO1VzZXIgSUQ9c2E7UGFzc3dvcmQ9ZWQzMjIz")
            StringOnline = Decrypt("RGF0YSBTb3VyY2U9MzUuMTk5LjExMy4xMTU7SW5pdGlhbCBDYXRhbG9nPWRiRXJhU3lzdGVtcztVc2VyIElEPWVyYTtQYXNzd29yZD1lZDMyMjM=")

            Dim vetNome As Array = Split(StringDeConexao, "=")

            vetNome = Split(vetNome(2).ToString, ";")

            NomeDoBancoSql = vetNome(0).ToString.Trim

            CarregarConfiguracao()
        End If
        Me.btnFaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        If SATFiscal = True Or NANONFCe = True Then
            Me.colDav.Visible = False
            Me.colTributacao.Caption = "CST/CSOSN"
            Me.colAliquota.Caption = "CFOP"

            Me.bsiImp.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            If SATFiscal = True Then
                CarregarGridSat(dtDataFiltro)
            Else
                Me.btnCancelarCupom.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                CarregarGridNFCe(dtDataFiltro)
            End If
        Else
            Me.btnAtualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            If Me.Tag = "Consulta" Then
                Me.btnFaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.dtData.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.btnFiltrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                If VerificaAbertura("Abertura") = True Then
                    Dim strDataAtual As String = Format(Date.Today, "ddMMyy")
                    Dim strDataUltimaRZ As String = ""
                    If TipoImpressoraFiscal = "DARUMA" Then
                        Dim strDataRZ As New StringBuilder(" ", 1164)
                        strDataRZ.Length = 1164
                        DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("140", strDataRZ)
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                        strDataUltimaRZ = strDataRZ.ToString.Trim.Substring(0, 8)
                        Dim I As Integer
                        Dim strData As String = ""
                        For I = 0 To strDataUltimaRZ.Length - 2
                            Dim strD As String = strDataUltimaRZ.ToString.Trim.Substring(I, 2)

                            Select Case I
                                Case 0
                                    strData = strD
                                Case 2
                                    strData &= "/" & strD
                                Case 4
                                    strData &= "/" & strD
                                Case 6
                                    strData &= strD

                            End Select

                            I += 1
                        Next

                        strDataUltimaRZ = Format(CDate(strData), "ddMMyy")
                    Else
                        Dim strDataRZ As String = Space(7)
                        Retorno = Bematech_FI_DataMovimentoUltimaReducaoMFD(strDataRZ)
                        strDataUltimaRZ = strDataRZ.Substring(0, 6)
                    End If


                    If strDataUltimaRZ = strDataAtual Then

                        Me.btnFaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                    End If

                Else
                    Me.btnFaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                End If

            End If
            CarregarGrid()
        End If
    End Sub
   

    Private Sub btnFaturar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFaturar.ItemClick
        Me.btnFaturar.Enabled = False
        If SATFiscal = True Then
            If Me.grd1.FocusedRowHandle < 0 Then
                MsgBox("Selecione uma venda!", MsgBoxStyle.Information)
                Me.btnFaturar.Enabled = True
                Exit Sub
            End If

            Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)

            If ModeloSAT = "BEMATECH" Then
                If clsSAT.ImprimirCupomSAT(strCodOrdem) = False Then
                    MsgBox("ERRO NA HORA DE GERAR O SAT-CF-e!", MsgBoxStyle.Information)
                End If
            Else
                If clsSAT.ImprimirCupomSatDll(strCodOrdem) = False Then
                    MsgBox("ERRO NA HORA DE GERAR O SAT-CF-e!", MsgBoxStyle.Information)
                End If
            End If

            CarregarGridSat(dtDataFiltro)
            intCodOrdemManter = strCodOrdem
            Timer1.Start()
        Else
            If NANONFCe = True Then
                If Me.grd1.FocusedRowHandle < 0 Then
                    MsgBox("Selecione uma venda!", MsgBoxStyle.Information)
                    Me.btnFaturar.Enabled = True
                    Exit Sub
                End If

                Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)

                Dim intCod As Integer = 0
                If clsNFCe.ImprimirCupomNFCe(strCodOrdem, intCod) = False Then
                    If intCod > 0 Then
                        Excluir("DELETE FROM Ordens where Cod = " & intCod & " and Tabela = 'NFCe' and CodConfig = " & CodConfig & " and CodEmitente = " & CodEmitente & " and StatusEmitente = '" & StatusEmitente & "'")

                    End If
                    Excluir("DELETE FROM NFCe where CodOrdem = " & strCodOrdem)
                    MsgBox("ERRO NA HORA DE GERAR O NFC-e!", MsgBoxStyle.Information)

                Else

                    frmProcesNfe.strStatus = strStatus
                    frmProcesNfe.strChaveAcesso = ChaveAcesso
                    frmProcesNfe.Tag = "NFe"
                    frmProcesNfe.strUF = EstadoEmitente
                    frmProcesNfe.strTipoAmb = TipoAmbiente
                    frmProcesNfe.strCaminhoNfe = CaminhoNFCe
                    frmProcesNfe.strDataEmissao = DataEmissao
                    frmProcesNfe.ShowDialog()

                    If strArquivoProcessado = "OK" Then
                        Atualizar("UPDATE NFCe set Status = 'OK' where CodOrdem = " & strCodOrdem)
                        strStatus = ""
                    ElseIf strArquivoProcessado = "NOK" Then
                        MsgBox("A Nota Fiscal não foi emitida com sucesso!", MsgBoxStyle.Information)
                        If intCod > 0 Then
                            Excluir("DELETE FROM Ordens where Cod = " & intCod & " and Tabela = 'NFce' and CodConfig = " & CodConfig & " and CodEmitente = " & CodEmitente & " and StatusEmitente = '" & StatusEmitente & "'")

                        End If
                        Excluir("DELETE FROM NFCe where CodOrdem = " & strCodOrdem)
                        strStatus = ""

                    ElseIf strArquivoProcessado = "AGUARDANDO" Then
                        Atualizar("UPDATE NFCe set Status = 'AGUARDANDO' where CodOrdem = " & strCodOrdem)
                        strStatus = "AGUARDANDO"
                    End If
                End If


                CarregarGridNFCe(dtDataFiltro)

            Else
                If Me.grd1.FocusedRowHandle < 0 Then
                    Me.btnFaturar.Enabled = True
                    Exit Sub
                End If


                Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)
                Dim strDav As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colDav)

                Dim dt As DataTable = CarregarDataTable("SELECT StatusDAV FROM Total where CodOrdem = " & strCodOrdem & " and Total.CodConfig = " & CodConfig)
                If dt.Rows.Count > 0 Then
                    Dim strStatus As String = dt.Rows.Item(0).Item("StatusDAV").ToString
                    If strStatus = "Faturado" Then
                        MsgBox("DAV " & strDav & " já faturado!", MsgBoxStyle.Information)
                    Else
                        ImprimirCupom(strCodOrdem, strDav)
                    End If
                End If

                CarregarGrid()
            End If
        End If
        Me.btnFaturar.Enabled = True
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick

        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim strTextoDav As String = ""
        Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)

        Dim dt As DataTable = CarregarDataTable("SELECT REPLICATE( '0' ,13 - len(NumDav) ) + NumDav as Dav, Total.CodOrdem, Cliente.Nome as Cliente, CPFCliente as CPF, convert(varchar(10),Total.Data,103) as Data, Total.Hora, convert(numeric(15,2),Total.Total) as Total FROM Total left join Cliente on Total.CodCli = Cliente.Codigo where Total.CodOrdem = " & strCodOrdem & " and Total.CodConfig = " & CodConfig)

        If dt.Rows.Count > 0 Then
            Dim strNumeroDav As String = dt.Rows.Item(0).Item("Dav").ToString
            Dim strData As String = dt.Rows.Item(0).Item("Data").ToString
            Dim strHora As String = dt.Rows.Item(0).Item("Hora").ToString
            Dim strCliente As String = dt.Rows.Item(0).Item("Cliente").ToString
            Dim strCPF As String = dt.Rows.Item(0).Item("CPF").ToString
            Dim strTotal As String = dt.Rows.Item(0).Item("Total").ToString

            If TipoImpressoraFiscal = "DARUMA" Then
                DarumaFiscal.iRetorno = DarumaFiscal.iRGAbrirIndice_ECF_Daruma(1)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Else
                Retorno = Bematech_FI_AbreRelatorioGerencialMFD("01")
            End If

            Dim strTraco As String = "------------------------------------------------"
            strTextoDav = strTraco & vbCrLf
            strTextoDav &= Dir("DOCUMENTO AUXILIAR DE VENDA - Orçamento", 48) & vbCrLf
            strTextoDav &= strTraco & vbCrLf & vbCrLf
            strTextoDav &= Dir("NAO E DOCUMENTO FISCAL", 48) & vbCrLf
            strTextoDav &= Dir("NAO E VALIDO COMO RECIBO E", 48) & vbCrLf
            strTextoDav &= Dir("COMO GARANTIA DE MERCADORIA", 48) & vbCrLf
            strTextoDav &= Dir("NAO COMPROVA PAGAMENTO", 48) & vbCrLf & vbCrLf
            strTextoDav &= Cent("Identificacao do Estabelecimento Emitente", 48) & vbCrLf
            strTextoDav &= strTraco & vbCrLf & vbCrLf
            strTextoDav = VerificaTamnhoTexto(strTextoDav)
            strTextoDav &= Dir(NomeEmpresa, 48) & vbCrLf
            strTextoDav &= Dir("Fone: " & TelefoneEmpresa, 48) & vbCrLf
            strTextoDav &= Dir("CNPJ: " & CNPJEmpresa, 48) & vbCrLf
            strTextoDav &= strTraco & vbCrLf & vbCrLf
            strTextoDav = VerificaTamnhoTexto(strTextoDav)
            strTextoDav &= Cent("Identificacao do Destinatario", 48) & vbCrLf
            strTextoDav &= strTraco & vbCrLf & vbCrLf
            strTextoDav &= Dir("Nome: " & strCliente, 48) & vbCrLf
            strTextoDav &= Dir("CPF/CNPJ: " & strCPF, 48) & vbCrLf
            strTextoDav &= strTraco & vbCrLf & vbCrLf

            strTextoDav = VerificaTamnhoTexto(strTextoDav)
            strTextoDav &= Dir("Nº do Documento: " & strNumeroDav, 48) & vbCrLf
            strTextoDav &= Dir("Data: " & strData & " " & strHora, 48) & vbCrLf
            strTextoDav &= Dir("Nº do Documento Fiscal: ____________", 48) & vbCrLf & vbCrLf

            strTextoDav &= Cent("Produtos do Documento Auxiliar de Vendas", 48) & vbCrLf
            strTextoDav &= strTraco & vbCrLf
            strTextoDav &= Dir("Cod.   Descricao", 48) & vbCrLf
            strTextoDav &= Dir("Qtde UN  Vl Unit(R$)", 37) & Esq("Vl Item(R$)", 11) & vbCrLf
            strTextoDav &= strTraco & vbCrLf
            strTextoDav = VerificaTamnhoTexto(strTextoDav)
            Dim dtPed As DataTable = CarregarDataTable("SELECT CodProdInterno, Produto, Qtd, UM, convert(numeric(15,2),ValorUnitario) as ValorUnitario, convert(Numeric (15,2),ValorTotal) as ValorTotal FROM Pedido where CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig)
            Dim I As Integer

            For I = 0 To dtPed.Rows.Count - 1
                Dim strCodigoInterno As String = dtPed.Rows.Item(I).Item("CodProdInterno").ToString
                Dim strProduto As String = dtPed.Rows.Item(I).Item("Produto").ToString
                Dim strQtd As String = dtPed.Rows.Item(I).Item("Qtd").ToString
                Dim strUN As String = dtPed.Rows.Item(I).Item("UM").ToString
                Dim strValorUnitario As String = dtPed.Rows.Item(I).Item("ValorUnitario").ToString
                Dim strValorTotal As String = dtPed.Rows.Item(I).Item("ValorTotal").ToString


                strTextoDav &= Dir(strCodigoInterno, 7) & Dir(strProduto, 41) & vbCrLf
                strTextoDav &= Dir("  " & strQtd & strUN & " X " & strValorUnitario, 38) & Esq(strValorTotal, 10) & vbCrLf
                strTextoDav = VerificaTamnhoTexto(strTextoDav)
            Next
            strTextoDav &= strTraco & vbCrLf

            strTextoDav &= Dir("Total:", 37) & Esq(strTotal, 11) & vbCrLf
            strTextoDav &= strTraco & vbCrLf

            strTextoDav = VerificaTamnhoTexto(strTextoDav)
            strTextoDav &= Cent("E vedada a autenticacao deste documento", 48) & vbCrLf & vbCrLf

            strTextoDav &= Cent("Identificacao das Formas de Pagamento", 48) & vbCrLf

            strTextoDav &= strTraco & vbCrLf

            strTextoDav = VerificaTamnhoTexto(strTextoDav)


            Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, convert(numeric(15,2),Valor) as Valor, FormaPagamento FROM Recebimento where CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig)
            If dtPag.Rows.Count > 0 Then

                strTextoDav &= Dir("Ord.   Forma de Pagto        Valor     Vencto.", 48) & vbCrLf
                strTextoDav &= strTraco & vbCrLf

                Dim P As Integer
                Dim B As Integer = 0
                For P = 0 To dtPag.Rows.Count - 1
                    Dim dblValor As Double
                    Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString

                    Dim strFormaPag As String = dtPag.Rows.Item(P).Item("FormaPagamento").ToString

                    If strFormaPag = "A VISTA" Then
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        B += 1
                        strTextoDav &= Dir(B, 7) & Dir(strPag, 21) & Dir(dblValor, 9) & Esq(strData, 11) & vbCrLf
                        strTextoDav = VerificaTamnhoTexto(strTextoDav)
                    Else
                        Dim dtRec As DataTable = CarregarDataTable("SELECT convert(varchar(10),Vencimento,103) as Vencimento, ValorParcela FROM ContaReceber where CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig)
                        If dtRec.Rows.Count > 0 Then
                            Dim A As Integer
                            For A = 0 To dtRec.Rows.Count - 1
                                Dim strVenc As String = dtRec.Rows.Item(A).Item("Vencimento").ToString
                                Dim dblValorParc As Double
                                If dtRec.Rows.Item(A).Item("ValorParcela").ToString <> "" Then
                                    dblValorParc = dtRec.Rows.Item(A).Item("ValorParcela").ToString
                                End If


                                B += 1
                                strTextoDav &= Dir(B, 7) & Dir(strPag, 21) & Dir(dblValorParc.ToString("0.00"), 9) & Esq(strVenc, 11) & vbCrLf
                                strTextoDav = VerificaTamnhoTexto(strTextoDav)
                            Next
                        Else
                            If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                                dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                            End If
                        End If
                        B += 1
                        strTextoDav &= Dir(B, 7) & Dir(strPag, 21) & Dir(dblValor.ToString("0.00"), 9) & Esq(strData, 11) & vbCrLf
                        strTextoDav = VerificaTamnhoTexto(strTextoDav)
                    End If
                Next
            End If


            strTextoDav &= strTraco & vbCrLf & vbCrLf & vbCrLf



            If TipoImpressoraFiscal = "DARUMA" Then
                DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strTextoDav)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                DarumaFiscal.iRetorno = DarumaFiscal.iRGFechar_ECF_Daruma()
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Else
                Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strTextoDav)
                Retorno = Bematech_FI_FechaRelatorioGerencial()
            End If
            SalvarDocumento("RG")

        End If
    End Sub

    Private Sub btnImpArquivo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpArquivo.ItemClick
        Dim rel As New relDav

        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim strTextoDav As String = ""
        Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)

        Dim dt As DataTable = CarregarDataTable("SELECT REPLICATE( '0' ,13 - len(NumDav) ) + NumDav as Dav, Total.CodOrdem, Cliente.Nome as Cliente, CPFCliente as CPF, convert(varchar(10),Total.Data,103) as Data, Total.Hora, convert(numeric(15,2),Total.Total) as Total FROM Total left join Cliente on Total.CodCli = Cliente.Codigo where Total.CodOrdem = " & strCodOrdem & " and Total.CodConfig = " & CodConfig)


        If dt.Rows.Count > 0 Then
            Dim strNumeroDav As String = dt.Rows.Item(0).Item("Dav").ToString
            Dim strData As String = dt.Rows.Item(0).Item("Data").ToString
            Dim strHora As String = dt.Rows.Item(0).Item("Hora").ToString
            Dim strCliente As String = dt.Rows.Item(0).Item("Cliente").ToString
            Dim strCPF As String = dt.Rows.Item(0).Item("CPF").ToString
            Dim strTotal As String = dt.Rows.Item(0).Item("Total").ToString


            rel.lblEmpresa.Text = "Denominação: " & NomeEmpresa
            rel.lblCNPF.Text = "CNPJ: " & CNPJEmpresa

            rel.lblDestinatario.Text = "Nome: " & strCliente
            rel.lblCPF.Text = "CPF/CNPJ: " & strCPF

            rel.lblNumDav.Text = "Nº do Documento: " & strNumeroDav
            rel.lblDataDav.Text = "Data: " & strData & " " & strHora


            Dim dtPed As DataTable = CarregarDataTable("SELECT CodProdInterno, Produto, Qtd, UM, convert(numeric(15,2),ValorUnitario) as ValorUnitario, convert(Numeric (15,2),ValorTotal) as ValorTotal FROM Pedido where CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig)
            Dim I As Integer

            For I = 0 To dtPed.Rows.Count - 1
                Dim strCodigoInterno As String = dtPed.Rows.Item(I).Item("CodProdInterno").ToString
                Dim strProduto As String = dtPed.Rows.Item(I).Item("Produto").ToString
                Dim strQtd As String = dtPed.Rows.Item(I).Item("Qtd").ToString
                Dim strUN As String = dtPed.Rows.Item(I).Item("UM").ToString
                Dim strValorUnitario As String = dtPed.Rows.Item(I).Item("ValorUnitario").ToString
                Dim strValorTotal As String = dtPed.Rows.Item(I).Item("ValorTotal").ToString



                Dim row As New XRTableRow
                row.Size = New System.Drawing.Size(800, 15)
                Dim cell0 As New XRTableCell
                Dim cell1 As New XRTableCell
                Dim cell2 As New XRTableCell
                Dim cell3 As New XRTableCell
                Dim cell4 As New XRTableCell
                Dim cell5 As New XRTableCell
                Dim cell6 As New XRTableCell


                cell0.Size = New System.Drawing.Size(350, 15)
                cell1.Size = New System.Drawing.Size(83, 15)
                cell2.Size = New System.Drawing.Size(68, 15)
                cell3.Size = New System.Drawing.Size(59, 15)
                cell4.Size = New System.Drawing.Size(65, 15)
                cell5.Size = New System.Drawing.Size(92, 15)
                cell6.Size = New System.Drawing.Size(83, 15)



                cell0.Text = strProduto
                cell1.Text = strValorUnitario
                cell2.Text = strQtd
                cell3.Text = strUN
                cell4.Text = "0,00"
                cell5.Text = strValorTotal



                cell0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
                cell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
                cell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
                cell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
                cell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
                cell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight

                cell0.Font = New System.Drawing.Font("Times New Roman", "7")
                cell1.Font = New System.Drawing.Font("Times New Roman", "7")
                cell2.Font = New System.Drawing.Font("Times New Roman", "7")
                cell3.Font = New System.Drawing.Font("Times New Roman", "7")
                cell4.Font = New System.Drawing.Font("Times New Roman", "7")
                cell5.Font = New System.Drawing.Font("Times New Roman", "7")

                row.Cells.Add(cell0)
                row.Cells.Add(cell1)
                row.Cells.Add(cell2)
                row.Cells.Add(cell3)
                row.Cells.Add(cell4)
                row.Cells.Add(cell5)
                row.Cells.Add(cell6)

                rel.XrTable1.Rows.Add(row)
            Next

            Dim row2 As New XRTableRow
            row2.Size = New System.Drawing.Size(800, 15)
            Dim cell10 As New XRTableCell
            Dim cell11 As New XRTableCell
            Dim cell12 As New XRTableCell
            Dim cell13 As New XRTableCell
            Dim cell14 As New XRTableCell
            Dim cell15 As New XRTableCell
            Dim cell16 As New XRTableCell


            cell10.Size = New System.Drawing.Size(350, 15)
            cell11.Size = New System.Drawing.Size(83, 15)
            cell12.Size = New System.Drawing.Size(68, 15)
            cell13.Size = New System.Drawing.Size(59, 15)
            cell14.Size = New System.Drawing.Size(65, 15)
            cell15.Size = New System.Drawing.Size(92, 15)
            cell16.Size = New System.Drawing.Size(83, 15)



            cell10.Text = ""
            cell11.Text = ""
            cell12.Text = ""
            cell13.Text = ""
            cell14.Text = "TOTAL"
            cell15.Text = strTotal

            cell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            cell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            cell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            cell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            cell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            cell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight

            cell10.Font = New System.Drawing.Font("Times New Roman", "7")
            cell11.Font = New System.Drawing.Font("Times New Roman", "7")
            cell12.Font = New System.Drawing.Font("Times New Roman", "7")
            cell13.Font = New System.Drawing.Font("Times New Roman", "7")
            cell14.Font = New System.Drawing.Font("Times New Roman", "7")
            cell15.Font = New System.Drawing.Font("Times New Roman", "7")

            row2.Cells.Add(cell10)
            row2.Cells.Add(cell11)
            row2.Cells.Add(cell12)
            row2.Cells.Add(cell13)
            row2.Cells.Add(cell14)
            row2.Cells.Add(cell15)
            row2.Cells.Add(cell16)

            rel.XrTable1.Rows.Add(row2)


            Dim row3 As New XRTableRow
            Dim cell110 As New XRTableCell
            row3.Size = New System.Drawing.Size(800, 15)
            cell110.Size = New System.Drawing.Size(800, 15)
            cell110.Text = "É VEDADA A AUTENTICAÇÃO DESTE DOCUMENTO"
            cell110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            cell10.Font = New System.Drawing.Font("Times New Roman", "7")
            row3.Cells.Add(cell110)
            rel.XrTable1.Rows.Add(row3)


            rel.ShowPreview()
        End If
    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick

        Dim data1 As String
        data1 = dtData.EditValue
        Me.tbProd.Rows.Clear()
        Me.grd1.ClearColumnsFilter()
        Me.grd1.ClearSorting()
        Me.GroupControl2.Text = "Produtos da Venda"
        If data1 = "" Then MsgBox("Selecione a Data!", MsgBoxStyle.Information) : Exit Sub
        Dim strData As String = String.Format("Total.Data = '{0:dd/MM/yyyy}'", dtData.EditValue)
        dtDataFiltro = dtData.EditValue
        If SATFiscal = True Then

            CarregarDados("SELECT '' as Pagamento, Total.CodOrdem, Total.Total as Valor, Cliente.Nome as Cliente, " & _
            "case when Total.NFP = 'False' then '' else CPFCliente end as CPF, Convert(Varchar(10), Total.Data, 103) as Data " & _
            "FROM (Total left join Cliente on Total.CodCli = Cliente.Codigo) left join SatFiscal on " & _
            "Total.CodOrdem = SatFiscal.CodOrdem2 and Total.CodConfig = SatFiscal.CodConfig where SatFiscal.CodOrdem2 is Null " & _
            "and Total.CodConfig = " & CodConfig & " and " & strData, Me.GridControl1)

        ElseIf NANONFCe = True Then


            CarregarDados("SELECT '' as Pagamento, Total.CodOrdem, Total.Total as Valor, Cliente.Nome as Cliente, " & _
  "case when Total.NFP = 'False' then '' else CPFCliente end as CPF, Convert(Varchar(10), Total.Data, 103) as Data " & _
  "FROM (Total left join Cliente on Total.CodCli = Cliente.Codigo) left join NFCe on " & _
  "Total.CodOrdem = NFCe.CodOrdem and Total.CodConfig = NFCe.CodConfig where NFCe.CodOrdem is Null " & _
  "and Total.CodConfig = " & CodConfig & " and " & strData & " order by Total.CodOrdem Desc", Me.GridControl1)
        Else

            CarregarDados("SELECT REPLICATE( '0' ,13 - len(NumDav) ) + NumDav as Dav, '' as Pagamento, Total.CodOrdem, Total.Total as Valor, Cliente.Nome as Cliente, case when NFP = 'False' then '' else CPFCliente end as CPF, Convert(Varchar(10), Total.Data, 103) as Data FROM (Total left join Cliente on Total.CodCli = Cliente.Codigo) left join R4 on Total.CodOrdem = R4.CodOrdem and Total.CodConfig = R4.CodConfig where NumDav <> '0' and StatusDAV = 'Pendente' and Total.CodConfig = " & CodConfig & " and " & strData, Me.GridControl1)


        End If


        Dim I As Integer
        For I = 0 To Me.grd1.RowCount - 1
            Dim strCodPed As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
            Dim strPagamento As String = ""
            Dim dtRec As DataTable = CarregarDataTable("SELECT Pagamento FROM Recebimento where Codordem = " & strCodPed & " and CodConfig =  " & CodConfig)

            If dtRec.Rows.Count > 0 Then
                Dim A As Integer

                For A = 0 To dtRec.Rows.Count - 1
                    If A = 0 Then
                        strPagamento = dtRec.Rows.Item(A).Item("Pagamento").ToString

                    Else
                        strPagamento = strPagamento & "," & dtRec.Rows.Item(A).Item("Pagamento").ToString

                    End If

                Next
            End If
            Me.grd1.SetRowCellValue(I, Me.colPagamento, strPagamento)
        Next
        Timer1.Start()

        Me.colCodOrdem.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
    End Sub

    Private Sub btnCancelarCupom_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelarCupom.ItemClick

        If SATFiscal = True Then
            Dim dt As DataTable = CarregarDataTable("SELECT Top 1 CodOrdem, Chave, Data, CFPDest, AssinaturaQrCode FROM SATFiscal order by Codigo DESC")
            If dt.Rows.Count > 0 Then
                Dim strChave As String = dt.Rows.Item(0).Item("Chave").ToString
                Dim strData As Date = dt.Rows.Item(0).Item("Data")
                Dim strCPF As String = dt.Rows.Item(0).Item("CFPDest").ToString
                Dim strCodOrdem As String = dt.Rows.Item(0).Item("CodOrdem").ToString
                Dim dtDataAtual As Date = My.Computer.Clock.LocalTime
                Dim strQrCode As String = dt.Rows.Item(0).Item("AssinaturaQrCode").ToString
                Dim dif As TimeSpan = dtDataAtual.Subtract(strData)
                If dif.Days = 0 And dif.Hours = 0 And dif.Minutes < 30 Then

                    clsSAT.ImprimirCupomCancelamentoSatDll(strCodOrdem, strChave, strCPF, strQrCode)
                Else
                    MsgBox("Cancelamento não permitido, pois já se passaram 30 min!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Dados inválidos!", MsgBoxStyle.Information)

            End If
            CarregarGridSat(dtDataFiltro)
        Else
            CancelarCupom(False, "")
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If intCodOrdemManter > 0 Then
            Dim I As Integer

            For I = 0 To Me.grd1.RowCount - 1
                Dim intCodOrdem As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)

                If intCodOrdemManter > intCodOrdem Then
                    Me.grd1.FocusedRowHandle = I
                    Me.grd1.FocusedColumn = Me.colCodOrdem
                    Me.grd1.ShowEditor()
                    intCodOrdemManter = 0
                    Exit For
                End If
            Next
        Else
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colCodOrdem
            grd1.ShowEditor()
        End If


        Timer1.Stop()
    End Sub

    Private Sub txtAlterar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.Click

    End Sub

    Private Sub grd1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grd1.FocusedRowChanged
        If Me.grd1.FocusedRowHandle < 0 Then
            Me.tbProd.Rows.Clear()
            Me.GroupControl2.Text = "Produtos do Pedido"
            Exit Sub
        End If

        Me.tbProd.Rows.Clear()
        Me.GroupControl2.Text = "Produtos do Pedido"
        Dim strCodPed As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)


        Dim dt As DataTable = CarregarDataTable("SELECT Pedido.CodProd, Pedido.CodProdInterno as CodigoPeca, " & _
        "Pedido.Produto, Pedido.Qtd, Pedido.ValorUnitario, Pedido.ValorTotal, Produto.Tipo as TipoProduto " & _
        "FROM Pedido left join Produto on Pedido.CodProd = Produto.Codigo where CodOrdem = " & strCodPed & " and Pedido.CodConfig = " & CodConfig & " and Pedido.TipoItens <> 'CONSUMO'")

        Dim I As Integer
        With Me.tbProd.Rows
            For I = 0 To dt.Rows.Count - 1
                .Add()
                .Item(I).Item("Codigo") = dt.Rows.Item(I).Item("CodigoPeca").ToString
                .Item(I).Item("Produto") = dt.Rows.Item(I).Item("Produto").ToString
                .Item(I).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString
                .Item(I).Item("ValorUnitario") = dt.Rows.Item(I).Item("ValorUnitario").ToString
                .Item(I).Item("ValorTotal") = dt.Rows.Item(I).Item("ValorTotal").ToString
                .Item(I).Item("Tipo") = dt.Rows.Item(I).Item("TipoProduto").ToString
                If dt.Rows.Item(I).Item("CodProd").ToString <> "" Then
                    If SATFiscal = True Or NANONFCe = True Then

                        Dim dtImp As DataTable = CarregarDataTable("SELECT CST, CFOP, NCM FROM NFe where CodProd = '" & dt.Rows.Item(I).Item("CodProd").ToString & "' and Regime = '" & RegimeSAT & "' or  CodProd = '" & dt.Rows.Item(I).Item("CodProd").ToString & "' and Regime = '" & RegimeSAT & " SAT'")
                        If dtImp.Rows.Count > 0 Then
                            .Item(I).Item("Tributacao") = dtImp.Rows.Item(0).Item("CST").ToString
                            .Item(I).Item("Aliquota") = dtImp.Rows.Item(0).Item("CFOP").ToString
                            .Item(I).Item("NCM") = dtImp.Rows.Item(0).Item("NCM").ToString
                        End If
                    Else
                        Dim dtImp As DataTable = CarregarDataTable("SELECT Tributacao, ICMS, NCM FROM ImpostoProduto where CodProd = '" & dt.Rows.Item(I).Item("CodProd").ToString & "'")
                        If dtImp.Rows.Count > 0 Then
                            .Item(I).Item("Tributacao") = dtImp.Rows.Item(0).Item("Tributacao").ToString
                            .Item(I).Item("Aliquota") = dtImp.Rows.Item(0).Item("ICMS").ToString
                            .Item(I).Item("NCM") = dtImp.Rows.Item(0).Item("NCM").ToString
                        End If
                    End If

                End If

            Next
        End With

        Me.GroupControl2.Text = "Produtos da Venda: " & strCodPed
    End Sub

    Private Sub btnEditarCPF_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnEditarCPF.ButtonClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        Dim strCod As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)

        Dim frm As New frmEditarCPF
        frm.txtCPF.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCPF)
        frm.strCodOrdem = strCod
        frm.ShowDialog()

        Dim dt As DataTable = CarregarDataTable("SELECT CPFCliente FROM Total where CodOrdem = " & strCod & " and CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then
            Dim strCPF As String = dt.Rows.Item(0).Item("CPFCliente").ToString
            Me.grd1.SetFocusedRowCellValue(Me.colCPF, strCPF)

        End If

    End Sub
    Private Sub CarregarConfiguracao()
        Dim dtConf As DataTable = CarregarDataTable("Select * from Config")
        If dtConf.Rows.Count > 1 Then
            SATExterno = True
            frmLogin.ShowDialog()
            If CodConfig <= 0 Then
                Me.Close()
                Exit Sub
            End If
            'Me.DefaultLookAndFeel1.LookAndFeel.SkinName = SkinDoUsuario
            dtConf = CarregarDataTable("Select * from Config where Codigo = " & CodConfig)
            'Else
            '    Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
        End If

        If dtConf.Rows.Count > 0 Then
            CodConfig = dtConf.Rows.Item(0).Item("Codigo").ToString
            NomeEmpresa = dtConf.Rows.Item(0).Item("Empresa").ToString
            TelefoneEmpresa = dtConf.Rows.Item(0).Item("Telefone").ToString
            EnderecoEmpresa = dtConf.Rows.Item(0).Item("Endereco").ToString
            CNPJEmpresa = dtConf.Rows.Item(0).Item("CNPJ").ToString
            UFEmpresa = dtConf.Rows.Item(0).Item("UF")
            TemImpressora = dtConf.Rows.Item(0).Item("TemImpressora")
            CidadeEmpresa = dtConf.Rows.Item(0).Item("Cidade").ToString
            ModeloCarne = dtConf.Rows.Item(0).Item("ModeloCarne").ToString
            TipoNano = dtConf.Rows.Item(0).Item("TipoNano").ToString
            PastaSincrinizacao = dtConf.Rows.Item(0).Item("PastaSinc").ToString
            GerarComissao = dtConf.Rows.Item(0).Item("GerarComissao")
            ValidarCPF = dtConf.Rows.Item(0).Item("ValidarCPF")
            TemGuilhotina = dtConf.Rows.Item(0).Item("TemGuilhotina")
            NomePCImpressora = dtConf.Rows.Item(0).Item("NomePCImpressora").ToString
            PermiteEstoqueZerado = dtConf.Rows.Item(0).Item("EstoqueZerado")
            BloquearParcelas = dtConf.Rows.Item(0).Item("AlterarParcelas")
            Impressora = dtConf.Rows.Item(0).Item("Impressora").ToString
            PortaImpressora = dtConf.Rows.Item(0).Item("Porta").ToString
            TemGaveta = dtConf.Rows.Item(0).Item("TemGaveta")
            DescontoMaximo = dtConf.Rows.Item(0).Item("DescontoMaximo").ToString
            Mensalista = dtConf.Rows.Item(0).Item("Mensalista")
            ComissaoProduto = dtConf.Rows.Item(0).Item("ComissaoProduto")
            ImpostoPorItem = dtConf.Rows.Item(0).Item("ImpostoPorItem").ToString
            SimplesNacional = dtConf.Rows.Item(0).Item("SimplesNacional")
            AtuPreCusto = dtConf.Rows.Item(0).Item("AtuPreCusto")
            BuscaCpfCnpj = dtConf.Rows.Item(0).Item("BuscaCpfCnpj").ToString
            ObsProduto = dtConf.Rows.Item(0).Item("ObsProduto")
            ObsPedidoVenda = dtConf.Rows.Item(0).Item("ImpObsPedidoVenda")
            SegViaRecibo = dtConf.Rows.Item(0).Item("SegViaRecibo").ToString
            AlteraPrecoPedido = dtConf.Rows.Item(0).Item("AltPrecoPedido")
            ObsPedido = dtConf.Rows.Item(0).Item("DescricaoPedido").ToString
            DescricaoVenda = dtConf.Rows.Item(0).Item("DescricaoVenda").ToString
            PafEcfNano = dtConf.Rows.Item(0).Item("PafEcfNano")
            TrocoCaixa = dtConf.Rows.Item(0).Item("TrocoCaixa")
            ImpressaoPedidoCompleto = dtConf.Rows.Item(0).Item("PedidoCompleto")
            EstoqueSomado = dtConf.Rows.Item(0).Item("EstoqueSomado")
            PorValorAproximado = dtConf.Rows.Item(0).Item("PorValorAproximado").ToString
            ImprimirDireto = dtConf.Rows.Item(0).Item("ImprimirDireto")
            CodigoBarraCupom = dtConf.Rows.Item(0).Item("CodigoBarraCupom")
            DezPorcento = dtConf.Rows.Item(0).Item("DezPorcento")
            SATFiscal = dtConf.Rows.Item(0).Item("SATFiscal")
            ModeloSAT = dtConf.Rows.Item(0).Item("ModeloSAT").ToString


            If SATFiscal = True Then
                AbaSatFiscal = True
                Dim dtEcf As DataTable = CarregarDataTable("SELECT CNPJ, IE, Codigo, NumeroECF, Assinatura, " & _
                "NumeroSerie, CodigoEquipamento, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, VersaoXmlSAT, Regime FROM " & _
                "ConfigECF where Computador = '" & My.Computer.Name & "' and CodConfig = " & CodConfig)

                If dtEcf.Rows.Count > 0 Then
                    CodConfigECF = dtEcf.Rows.Item(0).Item("Codigo").ToString
                    AssinaturaAC = dtEcf.Rows.Item(0).Item("Assinatura").ToString
                    NumeroSerieECF = dtEcf.Rows.Item(0).Item("NumeroSerie").ToString
                    CodigoEquipamento = dtEcf.Rows.Item(0).Item("CodigoEquipamento").ToString

                    CNPJECF = dtEcf.Rows.Item(0).Item("CNPJ").ToString
                    IEECF = dtEcf.Rows.Item(0).Item("IE").ToString
                    NumeroEcfECF = dtEcf.Rows.Item(0).Item("NumeroECF").ToString


                    ModeloImpSAT = dtEcf.Rows.Item(0).Item("ModeloImpSAT").ToString
                    CaminhoPastaSAT = dtEcf.Rows.Item(0).Item("CaminhoPastaSAT").ToString
                    NomeImpSAT = dtEcf.Rows.Item(0).Item("NomeImpSAT").ToString
                    ImpDiretoSAT = dtEcf.Rows.Item(0).Item("ImpDiretoSAT").ToString
                    VersaoXmlSAT = dtEcf.Rows.Item(0).Item("VersaoXmlSAT").ToString
                    RegimeSAT = dtEcf.Rows.Item(0).Item("Regime").ToString
                    If VersaoXmlSAT = "" Then
                        VersaoXmlSAT = "0.06"
                    End If
                Else
                    SATFiscal = False
                End If

            End If

            If PafEcfNano = True Then
                CpfNaNota = True
            Else
                If SATFiscal = True Then
                    CpfNaNota = True
                Else
                    CpfNaNota = False
                End If
            End If
            DeOlhoNoImposto = dtConf.Rows.Item(0).Item("ValorAproximado")
            TresCasasDecimais = dtConf.Rows.Item(0).Item("TresCasasDecimais")
            If PortaImpressora.Trim = "" Then
                PortaImpressora = LerArquivo(My.Application.Info.DirectoryPath & "\Porta.txt", True)
            End If
        End If
    End Sub

    Private Sub btnAtualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtualizar.ItemClick
        If SATFiscal = True Then
            CarregarGridSat(dtDataFiltro)
        Else
            CarregarGridNFCe(dtDataFiltro)
        End If

    End Sub
End Class