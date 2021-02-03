Imports Nano.clsFuncoes
Imports Nano.clsImprimir

Public Class frmCaixa

    Dim bolFiltrado As Boolean = False
    Dim strFiltro As String = ""


    Private Sub frmCaixa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "21")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        'If NomeEmpresa.ToUpper.Trim.Contains("TAUÁ") = True Then

        '    Dim dt As DataTable = CarregarDataTable("Select Caixa from Caixa where Motivo ='TROCO DIA ANTERIOR' AND Data ='" & Date.Today & "' and CodConfig =" & CodConfig)

        '    If dt.Rows.Count = 0 Then
        '        Dim dtDeb As DataTable = CarregarDataTable("Select Sum(Valor) as Debito from Caixa where Data ='" & Date.Today.AddDays(-1) & "' and Credito ='D' and Pagamento ='DINHEIRO' AND CodConfig =" & CodConfig)
        '        Dim dtCred As DataTable = CarregarDataTable("Select Sum(Valor) as Credito from Caixa where Data ='" & Date.Today.AddDays(-1) & "' and Credito ='C' and Pagamento ='DINHEIRO' AND CodConfig =" & CodConfig)

        '        Dim dblDeb, dblCred, dblRes As Double

        '        If dtDeb.Rows.Count > 0 Then
        '            If dtDeb.Rows.Item(0).Item("Debito").ToString <> "" Then
        '                dblDeb = dtDeb.Rows.Item(0).Item("Debito").ToString
        '            End If

        '        End If

        '        If dtCred.Rows.Count > 0 Then
        '            If dtCred.Rows.Item(0).Item("Credito").ToString <> "" Then
        '                dblCred = dtCred.Rows.Item(0).Item("Credito").ToString
        '            End If
        '        End If

        '        dblRes = dblCred - dblDeb

        '        If dblRes <> 0 Then
        '            Inserir("Insert Into Caixa (Motivo, Credito, Pagamento, Valor, Data, Caixa, CodConfig) Values('TROCO DIA ANTERIOR','C', 'DINHEIRO'," & Num(dblRes.ToString("0.00")) & ",'" & Date.Today & "','SISTEMA'," & CodConfig & ")")
        '        End If

        '    End If
        'End If
        If SaldoCaixa = True Then
            If SaldoAtualCaixa = True Then
                Me.lblSaldo.Visible = False
                Me.txtSaldoCaixa.Visible = False

                If NomeEmpresa.ToUpper.Contains("O REI DOS") = True Then
                    Me.lblCredito.Visible = False
                    Me.lblDebito.Visible = False
                    Me.lblTotalSaldo.Visible = False

                    Me.txtCred.Visible = False
                    Me.txtDeb.Visible = False
                    Me.txtSaldo.Visible = False
                    Me.btnCalc.Visible = False
                    Me.GroupControl2.ShowCaption = False
                End If

            End If

            If SaldoAtualCaixaDinheiro = True Then
                Me.lblSaldoDinheiro.Visible = False
                Me.txtSaldoAtualDinheiro.Visible = False
            Else
                If SaldoAtualCaixa = True Then
                    Me.lblSaldoDinheiro.Location = New System.Drawing.Point(669, 487)
                    Me.txtSaldoAtualDinheiro.Location = New System.Drawing.Point(807, 475)
                End If
            End If
        Else
            Me.lblSaldo.Visible = False
            Me.txtSaldoCaixa.Visible = False
            Me.lblSaldoDinheiro.Visible = False
            Me.txtSaldoAtualDinheiro.Visible = False

            'Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18)
        End If
        

       
        If Master = False Then
            strFiltro = " and CodConfig =" & CodConfig
        End If

        Me.grd1.OptionsView.ShowFooter = Master

        If CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja) = False Then
            Exit Sub
        End If

        'Me.CaixaBindingSource.Filter = "Data = '" & Date.Today & "'" & strFiltro
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        Me.colCodConfig.Visible = Master
        Me.lueConfig.Visible = Master
        Me.lblLoja.Visible = Master
        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueConfig)

        'Me.CaixaTableAdapter.Fill(Me.DsNanoCommerce.Caixa)

        'If CaixaTodosUsuarios = True Then
        '    CarregarDados("SELECT * FROM Caixa where Caixa = '" & UserNano & "' and Data = '" & Date.Today & "'" & strFiltro, Me.CaixaGridControl)
        'Else

        If AbrirFecharCaixa = True Then
            If Nivel <> "USUÁRIO" Then
                Dim dtCaixa As DataTable = CarregarDataTable("SELECT max(Codigo) as Codigo, Caixa, Motivo FROM Caixa where  " & _
                "CodConfig = " & CodConfig & " and Motivo = 'ABERTURA CAIXA' or " & _
                "CodConfig = " & CodConfig & " and Motivo = 'FECHAMENTO CAIXA' group by Caixa, Motivo order by max(Data) Desc, max(Codigo) Desc")
                If dtCaixa.Rows.Count > 0 Then
                    Dim I As Integer
                    For I = 0 To dtCaixa.Rows.Count - 1
                        Dim strCodigoCaixa As String = dtCaixa.Rows.Item(I).Item("Codigo").ToString
                        Dim strMotivoCaixa As String = dtCaixa.Rows.Item(I).Item("Motivo").ToString
                        Dim strUsuarioCaixa As String = dtCaixa.Rows.Item(I).Item("Caixa").ToString
                        If strMotivoCaixa = "ABERTURA CAIXA" Then
                            Dim dtFechamento As DataTable = CarregarDataTable("SELECT Codigo, Data FROM Caixa Where " & _
                            "Codigo >= " & strCodigoCaixa & " and Caixa = '" & strUsuarioCaixa & "' and " & _
                            "Motivo = 'FECHAMENTO CAIXA' and CodConfig = " & CodConfig)
                            Dim bolCaixa As Boolean = True
                            If dtFechamento.Rows.Count > 0 Then
                                Dim dtDataFechamento As Date = dtFechamento.Rows.Item(0).Item("Data")
                                If dtDataFechamento < Date.Today.AddDays(-1) Then
                                    bolCaixa = False
                                End If
                            End If
                            If bolCaixa = True Then
                                Dim dtCaixaGrid As DataTable = CarregarDataTable("SELECT Codigo, Motivo, Credito, Data, " & _
                                                            "Pagamento, Valor, Caixa, CentroCusto, CodConfig, Auxiliar FROM Caixa where " & _
                                                            "Codigo >= " & strCodigoCaixa & " and Caixa = '" & strUsuarioCaixa & "' and CodConfig = " & CodConfig)
                                If dtCaixaGrid.Rows.Count > 0 Then
                                    Dim A As Integer
                                    For A = 0 To dtCaixaGrid.Rows.Count - 1
                                        Me.tbCaixaGrid.Rows.Add()
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Codigo") = dtCaixaGrid.Rows.Item(A).Item("Codigo").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Motivo") = dtCaixaGrid.Rows.Item(A).Item("Motivo").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Credito") = dtCaixaGrid.Rows.Item(A).Item("Credito").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Data") = dtCaixaGrid.Rows.Item(A).Item("Data").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Pagamento") = dtCaixaGrid.Rows.Item(A).Item("Pagamento").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Valor") = dtCaixaGrid.Rows.Item(A).Item("Valor").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Caixa") = dtCaixaGrid.Rows.Item(A).Item("Caixa").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("CentroCusto") = dtCaixaGrid.Rows.Item(A).Item("CentroCusto").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("CodConfig") = dtCaixaGrid.Rows.Item(A).Item("CodConfig").ToString
                                        Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Auxiliar") = dtCaixaGrid.Rows.Item(A).Item("Auxiliar").ToString
                                    Next
                                End If
                            End If
                            
                        End If
                    Next
                    'CarregarDados("SELECT * FROM Caixa where Codigo >= " & strCodigoCaixa & " & strFiltro, Me.CaixaGridControl)
                End If
            End If


        Else
            CarregarDados("SELECT * FROM Caixa where Data >= '" & Date.Today & "' and Data <= '" & Date.Today.AddDays(1) & "'" & strFiltro, Me.CaixaGridControl)
        End If


        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit1.EditMask = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.EditMask = "dd/MM/yyyy HH:mm"

       'End If
        PreencherGrupoSetorCusto("R", Me.txtMot, "D")
        PreencherOrdenado("Pagamento", Me.cboPag, 1, "Descricao")
        Me.dtData.EditValue = Date.Today

        If Nivel = "ADMINISTRADOR" Or Nivel = "MASTER" Then
            Me.btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            If CNPJEmpresa = "09813990000151" Or CNPJEmpresa = "05017176000170" Then
                Me.lblCredito.Visible = False
                Me.lblDebito.Visible = False
                Me.lblTotalSaldo.Visible = False
                Me.txtCred.Visible = False
                Me.txtDeb.Visible = False
                Me.txtSaldo.Visible = False
                Me.btnCalc.Visible = False
                Me.GroupControl2.ShowCaption = False
                Me.btnRelCaixa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            'If NomeEmpresa.ToUpper.Trim.Contains("JÉSSICA COSMÉTICOS") Then
            '    Me.lblCredito.Visible = False
            '    Me.lblDebito.Visible = False
            '    Me.lblTotalSaldo.Visible = False
            '    Me.txtCred.Visible = False
            '    Me.txtDeb.Visible = False
            '    Me.txtSaldo.Visible = False
            '    Me.btnCalc.Visible = False
            '    Me.GroupControl2.ShowCaption = False
            '    Me.btnRelCaixa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'End If
        End If
        If AlterarDataCaixa = False Then
            Me.dtData.Text = Date.Today
            Me.dtData.Enabled = False

            Me.dtInicial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.dtFinal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If NomeEmpresa.ToUpper.Contains("CATÁLOGO") = True Then
            Me.dtData.Text = Date.Today
            Me.dtData.Enabled = False
        End If
        If NomeEmpresa.ToUpper.Contains("BOM PREÇO") = True Then
            Me.dtData.Text = Date.Today
            Me.dtData.Enabled = False
        End If

        If BloquearRelatoriosCaixa = True Then
            Me.bsiVisu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnTransferencia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        PreencherGrupoSetorCusto("C", Me.cboCenCus)

        CalculaTudo()

        If BloqueioTransferenciaBancario = False Then
            Me.btnTransferencia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        Timer1.Start()
    End Sub

    Private Sub CalculaTudo()
        Dim dtCredito, dtDebito As DataTable
        Dim dblCredito, dblDebito, dblResultado As Double
        Dim strSQL As String = ""

        strSQL = "SELECT sum(Valor) FROM Caixa where Credito = 'C'" & strFiltro


        dtCredito = CarregarDataTable(strSQL)
        If dtCredito.Rows.Item(0).ItemArray(0).ToString = "" Then
            dblCredito = "0,00"
        Else
            dblCredito = dtCredito.Rows.Item(0).ItemArray(0).ToString
        End If

        strSQL = "SELECT sum(Valor) FROM Caixa where Credito = 'D'" & strFiltro

        dtDebito = CarregarDataTable(strSQL)

        If dtDebito.Rows.Item(0).ItemArray(0).ToString = "" Then
            dblDebito = "0,00"
        Else
            dblDebito = dtDebito.Rows.Item(0).ItemArray(0).ToString
        End If

        dblResultado = dblCredito - dblDebito
        Me.txtSaldoCaixa.Text = dblResultado.ToString("###,###,###,##0.00")


        strSQL = "SELECT sum(Valor) FROM Caixa where Credito = 'C' and Pagamento = 'DINHEIRO'" & strFiltro


        dtCredito = CarregarDataTable(strSQL)
        If dtCredito.Rows.Item(0).ItemArray(0).ToString = "" Then
            dblCredito = "0,00"
        Else
            dblCredito = dtCredito.Rows.Item(0).ItemArray(0).ToString
        End If

        strSQL = "SELECT sum(Valor) FROM Caixa where Credito = 'D' and Pagamento = 'DINHEIRO'" & strFiltro

        dtDebito = CarregarDataTable(strSQL)

        If dtDebito.Rows.Item(0).ItemArray(0).ToString = "" Then
            dblDebito = "0,00"
        Else
            dblDebito = dtDebito.Rows.Item(0).ItemArray(0).ToString
        End If

        dblResultado = dblCredito - dblDebito
        Me.txtSaldoAtualDinheiro.Text = dblResultado.ToString("###,###,###,##0.00")

    End Sub

    Private Sub Limpar()
        Me.txtMot.ResetText()
        Me.cboCred.SelectedIndex = -1
        Me.dtData.EditValue = Date.Today
        Me.cboPag.SelectedIndex = -1
        Me.txtVal.ResetText()
        Me.cboCenCus.SelectedIndex = -1
        Me.txtMot.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If TesteConexao() = False Then Exit Sub
        If Master = True Then
            If Validar(Me.lueConfig) = False Then Exit Sub
        End If
        If Validar(Me.txtMot) = False Then Exit Sub
        If Validar(Me.cboCred) = False Then Exit Sub
        If Validar(Me.dtData) = False Then Exit Sub
        If Validar(Me.cboPag) = False Then Exit Sub
        If Validar(Me.txtVal) = False Then Exit Sub

        If AbrirFecharCaixa = True Then
            If VerificarCaixa(Me.txtMot.Text) = False Then Exit Sub
        End If
     
        Dim strAuxiliar As String

        strAuxiliar = NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")

        Dim intCodConfig As Integer = CodConfig
        If Master = True Then
            intCodConfig = Me.lueConfig.EditValue
        End If

        If AbrirFecharCaixa = True Then
            Inserir("INSERT INTO Caixa (Motivo, Credito, Data, Pagamento, Valor, Caixa, CentroCusto, CodConfig, Auxiliar) " & _
             "VALUES ('" & Me.txtMot.Text.Trim & "','" & Me.cboCred.Text.Trim & "','" & My.Computer.Clock.LocalTime & "'," & _
             "'" & Me.cboPag.Text.Trim & "'," & Num(Me.txtVal.Text.Trim) & ",'" & UserNano.Trim & "','" & Me.cboCenCus.Text.Trim & "'," & _
             "" & intCodConfig & ",'" & strAuxiliar & "')")
        Else
            Inserir("INSERT INTO Caixa (Motivo, Credito, Data, Pagamento, Valor, Caixa, CentroCusto, CodConfig, Auxiliar) " & _
             "VALUES ('" & Me.txtMot.Text.Trim & "','" & Me.cboCred.Text.Trim & "','" & Me.dtData.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & _
             "'" & Me.cboPag.Text.Trim & "'," & Num(Me.txtVal.Text.Trim) & ",'" & UserNano.Trim & "','" & Me.cboCenCus.Text.Trim & "'," & _
             "" & intCodConfig & ",'" & strAuxiliar & "')")
        End If
 
        'With Me.DsNanoCommerce.Caixa.Rows
        '    .Add()
        '    .Item(.Count - 1).Item("Motivo") = Me.txtMot.Text.Trim
        '    .Item(.Count - 1).Item("Credito") = Me.cboCred.Text.Trim
        '    .Item(.Count - 1).Item("Data") = Me.dtData.Text.Trim
        '    .Item(.Count - 1).Item("Pagamento") = Me.cboPag.Text.Trim
        '    .Item(.Count - 1).Item("Valor") = Me.txtVal.Text.Trim
        '    .Item(.Count - 1).Item("Caixa") = UserNano.Trim
        '    .Item(.Count - 1).Item("CentroCusto") = Me.cboCenCus.Text.Trim
        '    .Item(.Count - 1).Item("CodConfig") = intCodConfig
        '    .Item(.Count - 1).Item("Auxiliar") = strAuxiliar
        'End With
        'Me.Validate()
        'Me.CaixaBindingSource.EndEdit()
        'Me.CaixaTableAdapter.Update(Me.DsNanoCommerce.Caixa)

        Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", Date.Today, Date.Today.ToString.Replace("00:00", "23:59")) & strFiltro
        'Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1)) & strFiltro
        

        If AbrirFecharCaixa = True Then
            If Nivel <> "USUÁRIO" Then
               
                CarregarDados("SELECT * FROM Caixa where " & strData, Me.CaixaGridControl)

            End If
        Else
           
            CarregarDados("SELECT * FROM Caixa where " & strData, Me.CaixaGridControl)

        End If
     
       

        Calcular()

        Select Case Me.cboCred.Text
            Case "C"
                MsgBox("Crédito adicionado com sucesso!", MsgBoxStyle.Information)

            Case "D"
                MsgBox("Débito adicionado com sucesso!", MsgBoxStyle.Information)
        End Select

        If TemImpressora = True Then
            If MsgBox("Deseja imprimir o comprovante?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Comprovante()
                If SegViaRecibo = True Then
                    If MsgBox("Deseja imprimir a 2ª via?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Comprovante()
                    End If
                End If
            End If
        End If

        Limpar()

    End Sub
    
    Private Sub Comprovante()

        If Impressora = "DARUMA" Then


            If TemImpressora = False Then Exit Sub

            Dim strImpressao As String

            strImpressao = "<tc>#</tc>" & vbCrLf

            strImpressao &= "<b><ce>" & NomeEmpresa.ToString.Trim & "</ce></b>" & vbCrLf
            strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

            strImpressao &= "<tc>#</tc>" & vbCrLf
            strImpressao &= "<l></l>" & vbCrLf
            strImpressao &= "<e><ce>COMPROVANTE NÃO FISCAL" & "</ce></e>" & vbCrLf
            strImpressao &= "<tc>-</tc>" & vbCrLf



            If Impressora = "ARQUIVO" Then

                If Me.cboCred.SelectedIndex = 0 Then
                    strImpressao &= "<c>" & Dir("CRÉDITO", 23) & Esq(Me.dtData.EditValue & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & "</c>" & vbCrLf
                Else
                    strImpressao &= "<c>" & Dir("DÉBITO", 23) & Esq(Me.dtData.EditValue & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & "</c>" & vbCrLf
                End If
                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<c>" & Dir(Me.txtMot.Text.Trim, 33) & Esq(Me.txtVal.Text, 10) & "</c>" & vbCrLf

                strImpressao &= "<c>" & Dir(" ", 23) & Esq("--------------------", 20) & "</c>" & vbCrLf


            Else
                If Me.cboCred.SelectedIndex = 0 Then
                    strImpressao &= "<c>" & Dir("CRÉDITO", 37) & Esq(Me.dtData.EditValue & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & "</c>" & vbCrLf
                Else
                    strImpressao &= "<c>" & Dir("DÉBITO", 37) & Esq(Me.dtData.EditValue & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & "</c>" & vbCrLf
                End If
                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<c>" & Dir(Me.txtMot.Text.Trim, 47) & Esq(Me.txtVal.Text, 10) & "</c>" & vbCrLf

                strImpressao &= "<c>" & Dir(" ", 37) & Esq("--------------------", 20) & "</c>" & vbCrLf

            End If


            If Impressora = "ARQUIVO" Then
                strImpressao &= "<c>" & Dir("TOTAL R$ ", 33) & Esq(Me.txtVal.Text, 10) & "</c>" & vbCrLf

            Else

                strImpressao &= "<c>" & Dir("TOTAL R$ ", 47) & Esq(Me.txtVal.Text, 10) & "</c>" & vbCrLf
            End If
            strImpressao &= "<c>" & Me.cboPag.Text & "</c>" & vbCrLf
            strImpressao &= "<l></l>" & vbCrLf
            strImpressao &= "<tc>-</tc>" & vbCrLf
            strImpressao &= "<ce>DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf
            strImpressao &= "<l></l>" & vbCrLf
            strImpressao &= "<l></l>" & vbCrLf
            strImpressao &= "<l></l>" & vbCrLf

            If TemGuilhotina = True Then
                strImpressao &= "<gui></gui>" & vbCrLf
            End If

            If ImpressoraOK() = True Then
                iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
            End If


        ElseIf Impressora.Contains("MP") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then
            If TemImpressora = False Then Exit Sub
            Dim strImpressao As String



            If Impressora.Contains("MP-4000") Then
                iRetorno = ConfiguraModeloImpressora(5)
                iRetorno = SelecionaQualidadeImpressao(3)
            Else
                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = ConfiguraModeloImpressora(1)
                    'Else
                    '    Try
                    '        iRetorno = ConfiguraModeloImpressora(1)
                    '    Catch ex As Exception

                    '    End Try
                End If

            End If



            If Impressora.Contains("BEMATECH") = True Then
                iRetorno = clsBematech.IniciaPorta(PortaImpressora)

            ElseIf Impressora.Contains("MP-4000") = True Then
                Try
                    iRetorno = clsBematech.IniciaPorta(PortaImpressora)
                Catch ex As Exception
                End Try
            End If



            Dim intTamEsp As Integer
            Dim strEstrela, strTraço As String

            If Impressora.Contains("ARQUIVO") = True Then
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
            strImpressao &= " " & vbCrLf
            strImpressao &= Cent("COMPROVANTE NÃO FISCAL", intTamEsp) & vbCrLf
            strImpressao &= " " & vbCrLf
            strImpressao &= strTraço & vbCrLf

            If Impressora.Contains("ARQUIVO") = True Then

                If Me.cboCred.SelectedIndex = 0 Then
                    strImpressao &= Dir("CRÉDITO", 22) & Esq(Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & vbCrLf
                Else
                    strImpressao &= Dir("DÉBITO", 22) & Esq(Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & vbCrLf
                End If
                strImpressao &= " " & vbCrLf
                strImpressao &= Dir(Me.txtMot.Text.Trim, 32) & Esq(Me.txtVal.Text, 10) & vbCrLf


                strImpressao &= Dir(" ", 22) & Esq("--------------------", 20) & vbCrLf

            Else
                If Me.cboCred.SelectedIndex = 0 Then
                    strImpressao &= Dir("CRÉDITO", 40) & Esq(Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & vbCrLf
                Else
                    strImpressao &= Dir("DÉBITO", 40) & Esq(Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & vbCrLf
                End If
                strImpressao &= " " & vbCrLf
                strImpressao &= Dir(Me.txtMot.Text.Trim, 50) & Esq(Me.txtVal.Text, 10) & vbCrLf
                strImpressao &= Dir(" ", 40) & Esq("--------------------", 20) & vbCrLf

            End If

            If Impressora.Contains("ARQUIVO") = True Then
                strImpressao &= Dir("TOTAL R$ ", 32) & Esq(Me.txtVal.Text, 10) & vbCrLf
            Else
                strImpressao &= Dir("TOTAL R$ ", 50) & Esq(Me.txtVal.Text, 10) & vbCrLf
            End If

            strImpressao &= Me.cboPag.Text.Trim & vbCrLf

            strImpressao &= " " & vbCrLf
            strImpressao &= strTraço & vbCrLf

            strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")

            If Impressora = "ARQUIVO" Then
                'ImprimiArquivo(strImpressao, PortaImpressora)

                clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)

                If TemGuilhotina = True Then
                    strImpressao = clsImprimir.Avanco() & vbCrLf
                    strImpressao &= clsImprimir.Corte()
                    clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                End If

                If TemGaveta = True Then
                    strImpressao = clsImprimir.AbreGaveta() & vbCrLf
                    clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                End If

            ElseIf Impressora.Contains("NANO PRINT") = True Then

                If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                    ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                Else
                    EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
                End If

            Else
                iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If

                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = clsBematech.FechaPorta()
                Else
                    Try
                        iRetorno = clsBematech.FechaPorta()
                    Catch ex As Exception

                    End Try
                End If
            End If


        ElseIf Impressora = "EPSON" Then
            If TemImpressora = False Then Exit Sub
            Dim strImpressao As String

            Dim strEstrela, strTraço As String

            strEstrela = clsImprimir.Comp("************************************************")
            strTraço = clsImprimir.Comp("------------------------------------------------")

            strImpressao = strEstrela & vbCrLf

            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= " " & vbCrLf
            strImpressao &= "<ce>" & "COMPROVANTE NÃO FISCAL" & "</ce>" & vbCrLf
            strImpressao &= " " & vbCrLf
            strImpressao &= strTraço & vbCrLf


            If Me.cboCred.SelectedIndex = 0 Then
                strImpressao &= Dir("CRÉDITO", 28) & Esq(Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & vbCrLf
            Else
                strImpressao &= Dir("DÉBITO", 28) & Esq(Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20) & vbCrLf
            End If
            strImpressao &= " " & vbCrLf
            strImpressao &= Dir(Me.txtMot.Text.Trim, 38) & Esq(Me.txtVal.Text, 10) & vbCrLf
            strImpressao &= Dir(" ", 28) & Esq("--------------------", 20) & vbCrLf


            strImpressao &= Dir("TOTAL R$ ", 38) & Esq(Me.txtVal.Text, 10) & vbCrLf

            strImpressao &= Me.cboPag.Text.Trim & vbCrLf

            strImpressao &= " " & vbCrLf
            strImpressao &= strTraço & vbCrLf

            strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            iRetorno = clsEpson.IniciaPorta(PortaImpressora)

            iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

            If TemGuilhotina = True Then
                iRetorno = clsEpson.AcionaGuilhotina(1)
            End If
            iRetorno = clsEpson.FechaPorta()
        ElseIf Impressora.Contains("ESC/POS") = True Then

            StringImpressao = Cabecalho()

            StringImpressao &= Exp(Centralizar("COMPROVANTE NÃO FISCAL")) & vbCrLf

            StringImpressao &= strTraco & vbCrLf

            Dim strCred As String

            If Me.cboCred.SelectedIndex = 0 Then
                strCred = "CREDITO"
            Else
                strCred = "DEBITO"
            End If

            StringImpressao &= Neg(Dir(strCred, 35)) & Comp(Esq(Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now), 20)) & vbCrLf

            StringImpressao &= " " & vbCrLf
            StringImpressao &= Comp(Dir(Me.txtMot.Text.Trim, 45) & Esq(Me.txtVal.Text, 10)) & vbCrLf
            StringImpressao &= Comp(Dir(" ", 35) & Esq("--------------------", 20)) & vbCrLf


            StringImpressao &= Comp(Dir(Me.cboPag.Text.Trim, 45) & Esq(Me.txtVal.Text, 10)) & vbCrLf

            StringImpressao &= " " & vbCrLf

            Rodape(True, StringImpressao)
        End If
    End Sub
    Private Sub txtVal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "," And e.KeyChar <> "." And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Preco(txtVal)
    End Sub

    Private Sub Calcular()

        Dim I As Integer
        Dim dblCred, dblDeb, dblTotCred, dblTotDeb, dblResul As Double

        For I = 0 To grd1.RowCount - 1

            With grd1

                Select Case .GetRowCellDisplayText(I, Me.colCredito)
                    Case "C"
                        dblCred = .GetRowCellDisplayText(I, Me.colValor)
                        dblTotCred += dblCred


                    Case "D"
                        dblDeb = .GetRowCellDisplayText(I, Me.colValor)
                        dblTotDeb += dblDeb
                End Select
            End With


        Next

        CalculaTudo()

        Me.txtCred.Text = dblTotCred.ToString("###,###,##0.00")
        Me.txtDeb.Text = dblTotDeb.ToString("###,###,##0.00")

        dblResul = dblTotCred - dblTotDeb

        Me.txtSaldo.Text = dblResul.ToString("###,###,##0.00")

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Calcular()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick

        

        Dim strMotivo As String
        strMotivo = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colMotivo)
        Dim strCodigo As String = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)

        If AbrirFecharCaixa = True Then
            If VerificarExclusaoCaixa(strMotivo, strCodigo) = False Then Exit Sub
        End If

        If MsgBox("Deseja realmente excluir o item " & grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colMotivo) & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If SenhaEstaOK() = False Then Exit Sub

            Dim dlbValor As Double = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colValor)
            Dim strValor As String = dlbValor.ToString("0.00")
            Dim strPagamento As String = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colPagamento)

            Me.grd1.DeleteRow(grd1.FocusedRowHandle)
            'Me.Validate()
            'Me.CaixaBindingSource.EndEdit()
            'Me.CaixaTableAdapter.Update(Me.DsNanoCommerce.Caixa)
            If strMotivo.Contains("TRANSFERÊNCIA CAIXA") = True Then

                
                Dim dtData As String = Format(CDate(Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colData)), "dd/MM/yyyy")

                Dim dtMovBanco As DataTable = CarregarDataTable("SELECT Codigo, CodBanco FROM MovimentoBancario where " & _
                "TipoMovimento = 'CRÉDITO' and Data = '" & dtData & "' and Valor = " & dlbValor & " and  Observacao like '%TRANSFERÊNCIA CAIXA%'")
                If dtMovBanco.Rows.Count > 0 Then
                    If dtMovBanco.Rows.Count = 1 Then
                        Dim intCodigo As Integer = dtMovBanco.Rows.Item(0).Item("Codigo")
                        Dim intCodBanco As Integer = dtMovBanco.Rows.Item(0).Item("CodBanco")

                        Dim dt As DataTable
                        dt = CarregarDataTable("SELECT Saldo FROM Banco where Codigo = " & intCodBanco)

                        If dt.Rows.Count > 0 Then
                            Dim dblSaldo, dblResul As Double
                            If dt.Rows.Item(0).Item("Saldo").ToString <> "" Then
                                dblSaldo = dt.Rows.Item(0).Item("Saldo").ToString
                            End If
                            dblResul = dblSaldo - dlbValor

                            Atualizar("UPDATE Banco SET Saldo = " & Num(dblResul) & " where Codigo = " & intCodBanco)

                            Excluir("DELETE FROM MovimentoBancario where Codigo = " & intCodigo & " and CodConfig = " & CodConfig)
                        End If
                    Else
                        MsgBox("Foram encontrados mais de um registro com as mesmas informações, faça a exclusão do movimento bancário manualmente!", MsgBoxStyle.Information)
                    End If
                End If
            End If

            Excluir("DELETE FROM Caixa where Codigo = " & strCodigo)

            Calcular()
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strMotivo & ", " & strPagamento & ", R$ " & strValor & "','EXCLUIDO','CAIXA','CAIXA','EXCLUSÃO'," & CodConfig & ")")
            MsgBox("Item " & strMotivo & " excluido com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnFilter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilter.ItemClick

        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        
        'Me.CaixaBindingSource.Filter = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro

        Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", dtInicial.EditValue, dtFinal.EditValue.ToString.Replace("00:00", "23:59")) & strFiltro

        If AbrirFecharCaixa = True Then
            If Nivel = "USUÁRIO" Then Exit Sub
            'strData = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro

            Me.tbCaixaGrid.Rows.Clear()
            Dim dtCaixaGrid As DataTable = CarregarDataTable("SELECT Codigo, Motivo, Credito, Data, " & _
                           "Pagamento, Valor, Caixa, CentroCusto, CodConfig, Auxiliar FROM Caixa where " & strData)

            If dtCaixaGrid.Rows.Count > 0 Then
                Dim A As Integer
                For A = 0 To dtCaixaGrid.Rows.Count - 1
                    Me.tbCaixaGrid.Rows.Add()
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Codigo") = dtCaixaGrid.Rows.Item(A).Item("Codigo").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Motivo") = dtCaixaGrid.Rows.Item(A).Item("Motivo").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Credito") = dtCaixaGrid.Rows.Item(A).Item("Credito").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Data") = dtCaixaGrid.Rows.Item(A).Item("Data").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Pagamento") = dtCaixaGrid.Rows.Item(A).Item("Pagamento").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Valor") = dtCaixaGrid.Rows.Item(A).Item("Valor").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Caixa") = dtCaixaGrid.Rows.Item(A).Item("Caixa").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("CentroCusto") = dtCaixaGrid.Rows.Item(A).Item("CentroCusto").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("CodConfig") = dtCaixaGrid.Rows.Item(A).Item("CodConfig").ToString
                    Me.tbCaixaGrid.Rows.Item(Me.tbCaixaGrid.Rows.Count - 1).Item("Auxiliar") = dtCaixaGrid.Rows.Item(A).Item("Auxiliar").ToString
                Next
            End If
        Else
            'If dataFim > "15/06/2020" Then
            '    strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dataFim.AddDays(1)) & strFiltro
            'End If
            CarregarDados("SELECT * FROM Caixa where " & strData, Me.CaixaGridControl)

        End If
        'Me.CaixaTableAdapter.Fill(Me.DsNanoCommerce.Caixa)

        'If CaixaTodosUsuarios = True Then
        '    CarregarDados("SELECT * FROM Caixa where Caixa = '" & UserNano & "' and " & strData, Me.CaixaGridControl)


        'Else
        

        'End If

        Calcular()
        bolFiltrado = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Calcular()
        Timer1.Stop()
    End Sub

    Private Sub btnCenCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCenCus.Click
        Dim frm As New frmGrupo
        frm.Tag = "CENTROCUSTO"
        frm.ShowDialog()
        Me.cboCenCus.Properties.Items.Clear()
        PreencherGrupoSetorCusto("C", Me.cboCenCus)
        Me.cboCenCus.Focus()
    End Sub

    Private Sub VisualizarSemTroco(ByVal parTotal As Boolean)
        Dim rel As New relCaixa

        With rel

            Dim I As Integer
            
            

            .lblCre.Text = Me.txtCred.Text.Trim
            .lblDeb.Text = Me.txtDeb.Text.Trim
            .lblSaldo.Text = Me.txtSaldo.Text.Trim

            Dim dblTroco As Double

            Me.tbPagamento.Rows.Clear()
            Me.tbCaixaSomado.Rows.Clear()
            For I = 0 To Me.grd1.RowCount - 1
                Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                If Me.grd1.GetRowCellDisplayText(I, Me.colMotivo).ToUpper.Contains("TROCO VENDA") = True Then
                    dblTroco += dblVal
                Else
                    ImpPagamento(Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito))
                    If parTotal = True Then
                        CaixaSomado(Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), Me.grd1.GetRowCellDisplayText(I, Me.colCaixa))

                    End If
                End If


            Next



            If parTotal = False Then
                For I = 0 To grd1.RowCount - 1

                    Select Case grd1.GetRowCellDisplayText(I, Me.colCredito)
                        Case "C"
                            .tbCred.Rows.Add()
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Caixa") = grd1.GetRowCellDisplayText(I, Me.colCaixa)

                        Case "D"
                            If grd1.GetRowCellDisplayText(I, Me.colMotivo).ToUpper.Contains("TROCO VENDA") = False Then
                                .tbDeb.Rows.Add()
                                .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                                .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                                .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                                .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                                .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Caixa") = grd1.GetRowCellDisplayText(I, Me.colCaixa)
                            End If

                    End Select
                Next
            Else
                For I = 0 To Me.tbCaixaSomado.Rows.Count - 1
                    Dim dblVal As Double = Me.tbCaixaSomado.Rows.Item(I).Item("Valor")
                    Select Case Me.tbCaixaSomado.Rows.Item(I).Item("Credito")
                        Case "C"
                            .tbCred.Rows.Add()
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Pagamento") = Me.tbCaixaSomado.Rows.Item(I).Item("Pagamento")
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Valor") = dblVal.ToString("0.00")
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Caixa") = Me.tbCaixaSomado.Rows.Item(I).Item("Caixa")

                        Case "D"
                            .tbDeb.Rows.Add()
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Pagamento") = Me.tbCaixaSomado.Rows.Item(I).Item("Pagamento")
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Valor") = dblVal.ToString("0.00")
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Caixa") = Me.tbCaixaSomado.Rows.Item(I).Item("Caixa")
                    End Select
                Next

                rel.colData.Visible = False
                rel.colData1.Visible = False
                rel.colMotivo.Visible = False
                rel.colMotivo1.Visible = False
            End If


            Dim dblCred As Double = 0
            Dim dlbDeb As Double

            'Dim strTeste As String = ""
            For I = 0 To Me.tbPagamento.Rows.Count - 1


                'strTeste &= Me.tbPagamento.Rows.Item(I).Item("Pagamento").ToString & "    " & Me.tbPagamento.Rows.Item(I).Item("Credito") & "    " & Me.tbPagamento.Rows.Item(I).Item("Valor") & vbCrLf
                Dim dblValor As Double = Me.tbPagamento.Rows.Item(I).Item("Valor")
                If Me.tbPagamento.Rows.Item(I).Item("Credito") = "C" Then

                    If Me.tbPagamento.Rows.Item(I).Item("Pagamento").ToString.ToUpper = "DINHEIRO" Then
                        dblValor = dblValor - dblTroco
                    End If
                    .lblTotCred.Text &= Me.tbPagamento.Rows.Item(I).Item("Pagamento") & " R$ " & dblValor.ToString("###,###,##0.00") & vbCrLf
                    dblCred += dblValor
                Else
                    Dim strMot As String = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                    'If grd1.GetRowCellDisplayText(I, Me.colMotivo).ToUpper.Contains("TROCO") = False Then
                    .lblTotDeb.Text &= Me.tbPagamento.Rows.Item(I).Item("Pagamento") & " R$ " & dblValor.ToString("###,###,##0.00") & vbCrLf
                    dlbDeb += dblValor
                    'End If
                End If
            Next
            'strTeste = strTeste



            'Dim strData As String = ""
            'Dim G As Integer
            'If bolFiltrado = False Then
            '    strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today) & strFiltro
            'Else
            '    strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro
            'End If

            'Dim dt As DataTable = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'D' and Motivo like '%TROCO%' GROUP BY Pagamento")

            'For G = 0 To dt.Rows.Count - 1
            '    dblTroco += CDbl(dt.Rows.Item(G).ItemArray(1).ToString)
            'Next

            'dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'C' GROUP BY Pagamento")


            '.lblTotCred.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight

            'For G = 0 To dt.Rows.Count - 1
            '    Dim dblVal As Double = dt.Rows.Item(G).ItemArray(1).ToString
            '    If dt.Rows.Item(G).ItemArray(0).ToString = "DINHEIRO" Then
            '        dblVal = dblVal - dblTroco

            '    End If
            '    .lblTotCred.Text &= dt.Rows.Item(G).ItemArray(0).ToString & " R$ " & dblVal.ToString("###,###,##0.00") & vbCrLf
            '    dblCred += dblVal
            'Next


            'dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'D' and Motivo not like '%TROCO%' GROUP BY Pagamento")

            '.lblTotDeb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight

            'For G = 0 To dt.Rows.Count - 1
            '    .lblTotDeb.Text &= dt.Rows.Item(G).ItemArray(0).ToString & " R$ " & CDbl(dt.Rows.Item(G).ItemArray(1).ToString).ToString("###,###,##0.00") & vbCrLf
            '    dlbDeb += CDbl(dt.Rows.Item(G).ItemArray(1).ToString)
            'Next
            .lblDeb.Text = dlbDeb.ToString("###,###,##0.00")
            .lblCre.Text = dblCred.ToString("###,###,##0.00")
            Dim dblResul As Double = dblCred - dlbDeb
            .lblSaldo.Text = dblResul.ToString("###,###,##0.00")
            .picLogo.Image = LogoTipo
            If NomeEmpresa.Contains("MAX DENIM") = True Then
                .lblLabelSaldoAtual.Visible = True
                .lblSaldoAtual.Visible = True
                .lblSaldoAtual.Text = Me.txtSaldoCaixa.Text
            End If
            If bolFiltrado = True Then
                rel.lblTitulo.Text = "Relatório Caixa de " & dtInicial.EditValue & " a " & dtFinal.EditValue
            Else
                rel.lblTitulo.Text = "Relatório Caixa de " & Date.Today
            End If
            .ShowPreview()
        End With
    End Sub
    Private Sub VisualizarComTroco(ByVal parTotal As Boolean)
        Dim rel As New relCaixa

        With rel

            Dim I As Integer
      
           

            .lblCre.Text = Me.txtCred.Text.Trim
            .lblDeb.Text = Me.txtDeb.Text.Trim
            .lblSaldo.Text = Me.txtSaldo.Text.Trim


            Me.tbPagamento.Rows.Clear()
            Me.tbCaixaSomado.Rows.Clear()
            For I = 0 To Me.grd1.RowCount - 1

                Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                ImpPagamento(Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito))


                If parTotal = True Then
                    CaixaSomado(Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), Me.grd1.GetRowCellDisplayText(I, Me.colCaixa))

                End If
            Next

            If parTotal = False Then
                For I = 0 To grd1.RowCount - 1

                    Select Case grd1.GetRowCellDisplayText(I, Me.colCredito)
                        Case "C"
                            .tbCred.Rows.Add()
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Caixa") = grd1.GetRowCellDisplayText(I, Me.colCaixa)

                        Case "D"
                            .tbDeb.Rows.Add()
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Caixa") = grd1.GetRowCellDisplayText(I, Me.colCaixa)
                    End Select
                Next
            Else
                For I = 0 To Me.tbCaixaSomado.Rows.Count - 1
                    Dim dblVal As Double = Me.tbCaixaSomado.Rows.Item(I).Item("Valor")
                    Select Case Me.tbCaixaSomado.Rows.Item(I).Item("Credito")
                        Case "C"
                            .tbCred.Rows.Add()
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Pagamento") = Me.tbCaixaSomado.Rows.Item(I).Item("Pagamento")
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Valor") = dblVal.ToString("0.00")
                            .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Caixa") = Me.tbCaixaSomado.Rows.Item(I).Item("Caixa")

                        Case "D"
                            .tbDeb.Rows.Add()
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Pagamento") = Me.tbCaixaSomado.Rows.Item(I).Item("Pagamento")
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Valor") = dblVal.ToString("0.00")
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Caixa") = Me.tbCaixaSomado.Rows.Item(I).Item("Caixa")
                    End Select
                Next

                rel.colData.Visible = False
                rel.colData1.Visible = False
                rel.colMotivo.Visible = False
                rel.colMotivo1.Visible = False
            End If


            For I = 0 To Me.tbPagamento.Rows.Count - 1
                If Me.tbPagamento.Rows.Item(I).Item("Credito") = "C" Then
                    .lblTotCred.Text &= Me.tbPagamento.Rows.Item(I).Item("Pagamento") & " R$ " & CDbl(Me.tbPagamento.Rows.Item(I).Item("Valor")).ToString("###,###,##0.00") & vbCrLf

                Else
                    .lblTotDeb.Text &= Me.tbPagamento.Rows.Item(I).Item("Pagamento") & " R$ " & CDbl(Me.tbPagamento.Rows.Item(I).Item("Valor")).ToString("###,###,##0.00") & vbCrLf

                End If

            Next


            'Dim strData As String = ""
            'Dim G As Integer

            'If bolFiltrado = False Then
            '    strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today) & strFiltro
            'Else
            '    strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro
            'End If

            'Dim dt As DataTable = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'C' GROUP BY Pagamento")



            '.lblTotCred.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight

            'For G = 0 To dt.Rows.Count - 1
            '    .lblTotCred.Text &= dt.Rows.Item(G).ItemArray(0).ToString & " R$ " & CDbl(dt.Rows.Item(G).ItemArray(1).ToString).ToString("###,###,##0.00") & vbCrLf
            'Next

            'dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'D' GROUP BY Pagamento")

            '.lblTotDeb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            'For G = 0 To dt.Rows.Count - 1
            '    .lblTotDeb.Text &= dt.Rows.Item(G).ItemArray(0).ToString & " R$ " & CDbl(dt.Rows.Item(G).ItemArray(1).ToString).ToString("###,###,##0.00") & vbCrLf
            'Next


            If NomeEmpresa.Contains("MAX DENIM") = True Then
                .lblLabelSaldoAtual.Visible = True
                .lblSaldoAtual.Visible = True
                .lblSaldoAtual.Text = Me.txtSaldoCaixa.Text
            End If
            If bolFiltrado = True Then
                rel.lblTitulo.Text = "Relatório Caixa de " & dtInicial.EditValue & " a " & dtFinal.EditValue
            Else
                rel.lblTitulo.Text = "Relatório Caixa de " & Date.Today
            End If

            .picLogo.Image = LogoTipo

            .ShowPreview()
        End With
    End Sub
    Private Sub ImpPagamento(ByVal parPagamento As String, ByVal parValor As Double, ByVal parCredito As String)
        Dim I As Integer
        If Me.tbPagamento.Rows.Count = 0 Then
            Me.tbPagamento.Rows.Add()
            Me.tbPagamento.Rows.Item(0).Item("Pagamento") = parPagamento
            Me.tbPagamento.Rows.Item(0).Item("Valor") = parValor
            Me.tbPagamento.Rows.Item(0).Item("Credito") = parCredito
        Else
            Dim intCountPagamento As Integer = Me.tbPagamento.Rows.Count - 1
            Dim bolExiste As Boolean = False
            For I = 0 To intCountPagamento

                If Me.tbPagamento.Rows.Item(I).Item("Pagamento") = parPagamento Then
                    If Me.tbPagamento.Rows.Item(I).Item("Credito") = parCredito Then
                        Dim dblVal As Double = Me.tbPagamento.Rows.Item(I).Item("Valor")
                        dblVal = dblVal + parValor
                        If dblVal = 19.4 Then
                            Dim strd As String = ""
                        End If
                        Me.tbPagamento.Rows.Item(I).Item("Valor") = dblVal
                        bolExiste = True
                        Exit For
                    End If
                End If

            Next

            If bolExiste = False Then
                Me.tbPagamento.Rows.Add()
                Me.tbPagamento.Rows.Item(Me.tbPagamento.Rows.Count - 1).Item("Pagamento") = parPagamento
                Me.tbPagamento.Rows.Item(Me.tbPagamento.Rows.Count - 1).Item("Valor") = parValor
                Me.tbPagamento.Rows.Item(Me.tbPagamento.Rows.Count - 1).Item("Credito") = parCredito
            End If
        End If

    End Sub

    Private Sub CaixaSomado(ByVal parPagamento As String, ByVal parValor As Double, ByVal parCredito As String, ByVal parCaixa As String)
        Dim I As Integer
        If Me.tbCaixaSomado.Rows.Count = 0 Then
            Me.tbCaixaSomado.Rows.Add()
            Me.tbCaixaSomado.Rows.Item(0).Item("Pagamento") = parPagamento
            Me.tbCaixaSomado.Rows.Item(0).Item("Valor") = parValor
            Me.tbCaixaSomado.Rows.Item(0).Item("Credito") = parCredito
            Me.tbCaixaSomado.Rows.Item(0).Item("Caixa") = parCaixa
        Else
            Dim intCountPagamento As Integer = Me.tbCaixaSomado.Rows.Count - 1
            Dim bolExiste As Boolean = False
            For I = 0 To intCountPagamento

                If Me.tbCaixaSomado.Rows.Item(I).Item("Pagamento") = parPagamento Then
                    If Me.tbCaixaSomado.Rows.Item(I).Item("Credito") = parCredito Then
                        If Me.tbCaixaSomado.Rows.Item(I).Item("Caixa") = parCaixa Then

                            Dim dblVal As Double = Me.tbCaixaSomado.Rows.Item(I).Item("Valor")
                            dblVal = dblVal + parValor
                            If dblVal = 19.4 Then
                                Dim strd As String = ""
                            End If
                            Me.tbCaixaSomado.Rows.Item(I).Item("Valor") = dblVal
                            bolExiste = True
                            Exit For
                        End If

                    End If
                End If

            Next

            If bolExiste = False Then
                Me.tbCaixaSomado.Rows.Add()
                Me.tbCaixaSomado.Rows.Item(Me.tbCaixaSomado.Rows.Count - 1).Item("Pagamento") = parPagamento
                Me.tbCaixaSomado.Rows.Item(Me.tbCaixaSomado.Rows.Count - 1).Item("Valor") = parValor
                Me.tbCaixaSomado.Rows.Item(Me.tbCaixaSomado.Rows.Count - 1).Item("Credito") = parCredito
                Me.tbCaixaSomado.Rows.Item(Me.tbCaixaSomado.Rows.Count - 1).Item("Caixa") = parCaixa
            End If
        End If

    End Sub
    Private Sub btnRelCaixa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCaixa.ItemClick
        If NomeEmpresa.ToUpper.Trim.Contains("JÉSSICA COSMÉTICOS") Then
            Me.btnRelTotais.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            If TrocoCaixa = True Then
                VisualizarComTrocoFiltro()
            Else
                VisualizarSemTrocoFiltro()
            End If
        Else
            If TrocoCaixa = True Then
                VisualizarComTroco(False)
            Else
                VisualizarSemTroco(False)
            End If
        End If
        
    End Sub


    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.CaixaGridControl.ShowPrintPreview()
    End Sub


    Private Sub btnCadPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadPag.Click
        Dim frm As New frmPagamento
        frm.ShowDialog()
        Me.cboPag.Properties.Items.Clear()
        PreencherOrdenado("Pagamento", Me.cboPag, 1, "Descricao")
        Me.cboPag.Focus()
    End Sub

    Private Sub btnTransferencia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransferencia.ItemClick
        frmMovBancario.Tag = ""
        frmMovBancario.ShowDialog()

        '' Me.CaixaBindingSource.Filter = "Data = '" & Date.Today & "'" & strFiltro
        'Me.CaixaTableAdapter.Fill(Me.DsNanoCommerce.Caixa)
        Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", Date.Today, Date.Today.ToString.Replace("00:00", "23:59")) & strFiltro

        CarregarDados("SELECT * FROM Caixa where " & strData, Me.CaixaGridControl)

        CalculaTudo()
        Calcular()
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub


    Private Sub btnRelTotais_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelTotais.ItemClick

        VisualizarTotalSemTroco()

        'If TrocoCaixa = True Then
        '    VisualizarComTroco(True)
        'Else
        '    VisualizarSemTroco(True)
        'End If
    End Sub



    Private Sub VisualizarSemTrocoFiltro()
        Dim rel As New relCaixa

        With rel

            Dim I As Integer

            For I = 0 To grd1.RowCount - 1

                Select Case grd1.GetRowCellDisplayText(I, Me.colCredito)
                    Case "C"
                        .tbCred.Rows.Add()
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Caixa") = grd1.GetRowCellDisplayText(I, Me.colCaixa)

                    Case "D"
                        If grd1.GetRowCellDisplayText(I, Me.colMotivo).Contains("TROCO VENDA") = False Then
                            .tbDeb.Rows.Add()
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                            .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Caixa") = grd1.GetRowCellDisplayText(I, Me.colCaixa)
                        End If

                End Select
            Next

            .lblCre.Text = Me.txtCred.Text.Trim
            .lblDeb.Text = Me.txtDeb.Text.Trim
            .lblSaldo.Text = Me.txtSaldo.Text.Trim

            Dim strData As String = ""
            Dim G As Integer

            If bolFiltrado = False Then
                'strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1)) & strFiltro

                strData = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", Date.Today, Date.Today.ToString.Replace("00:00", "23:59")) & strFiltro
                rel.lblTitulo.Text = "Relatório Caixa de " & Date.Today
            Else
                'If AbrirFecharCaixa = True Then
                '    strData = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro
                'Else
                '    Dim dtFim As Date = dtFinal.EditValue
                '    strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro

                '    If dtFim > "15/06/2020" Then
                '        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFim.AddDays(1)) & strFiltro
                '    End If
                'End If
                strData = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", dtInicial.EditValue, dtFinal.EditValue.ToString.Replace("00:00", "23:59")) & strFiltro
                rel.lblTitulo.Text = "Relatório Caixa de " & dtInicial.EditValue & " a " & dtFinal.EditValue
            End If

            Dim dt As DataTable = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'D' and Motivo like '%TROCO VENDA%' GROUP BY Pagamento")
            Dim dblTroco As Double
            For G = 0 To dt.Rows.Count - 1
                dblTroco += CDbl(dt.Rows.Item(G).ItemArray(1).ToString)
            Next

            dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'C' GROUP BY Pagamento")


            .lblTotCred.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight

            Dim dblCred As Double = 0
            For G = 0 To dt.Rows.Count - 1
                Dim dblVal As Double = dt.Rows.Item(G).ItemArray(1).ToString
                If dt.Rows.Item(G).ItemArray(0).ToString = "DINHEIRO" Then
                    dblVal = dblVal - dblTroco

                End If
                .lblTotCred.Text &= dt.Rows.Item(G).ItemArray(0).ToString & " R$ " & dblVal.ToString("###,###,##0.00") & vbCrLf
                dblCred += dblVal
            Next


            dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'D' and Motivo not like '%TROCO VENDA%' GROUP BY Pagamento")

            .lblTotDeb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Dim dlbDeb As Double
            For G = 0 To dt.Rows.Count - 1
                .lblTotDeb.Text &= dt.Rows.Item(G).ItemArray(0).ToString & " R$ " & CDbl(dt.Rows.Item(G).ItemArray(1).ToString).ToString("###,###,##0.00") & vbCrLf
                dlbDeb += CDbl(dt.Rows.Item(G).ItemArray(1).ToString)
            Next
            .lblDeb.Text = dlbDeb.ToString("###,###,##0.00")
            .lblCre.Text = dblCred.ToString("###,###,##0.00")
            Dim dblResul As Double = dblCred - dlbDeb
            .lblSaldo.Text = dblResul.ToString("###,###,##0.00")
            .picLogo.Image = LogoTipo
            If NomeEmpresa.Contains("MAX DENIM") = True Then
                .lblLabelSaldoAtual.Visible = True
                .lblSaldoAtual.Visible = True
                .lblSaldoAtual.Text = Me.txtSaldoCaixa.Text
            End If
            .ShowPreview()
        End With
    End Sub
    Private Sub VisualizarComTrocoFiltro()
        Dim rel As New relCaixa

        With rel

            Dim I As Integer

            For I = 0 To grd1.RowCount - 1

                Select Case grd1.GetRowCellDisplayText(I, Me.colCredito)
                    Case "C"
                        .tbCred.Rows.Add()
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                        .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Caixa") = grd1.GetRowCellDisplayText(I, Me.colCaixa)

                    Case "D"
                        .tbDeb.Rows.Add()
                        .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                        .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                        .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                        .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                        .tbDeb.Rows.Item(.tbDeb.Rows.Count - 1).Item("Caixa") = grd1.GetRowCellDisplayText(I, Me.colCaixa)
                End Select
            Next

            .lblCre.Text = Me.txtCred.Text.Trim
            .lblDeb.Text = Me.txtDeb.Text.Trim
            .lblSaldo.Text = Me.txtSaldo.Text.Trim

            Dim strData As String = ""
            Dim G As Integer
            If bolFiltrado = False Then
                'strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1)) & strFiltro
                strData = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", Date.Today, Date.Today.ToString.Replace("00:00", "23:59")) & strFiltro

                rel.lblTitulo.Text = "Relatório Caixa de " & Date.Today
            Else
                'If AbrirFecharCaixa = True Then
                '    strData = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro
                'Else
                '    Dim dtFim As Date = dtFinal.EditValue
                '    strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro

                '    If dtFim > "15/06/2020" Then
                '        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFim.AddDays(1)) & strFiltro
                '    End If
                'End If
                strData = String.Format("Data >= '{0:dd/MM/yyyy HH:mm}' AND Data <= '{1:dd/MM/yyyy HH:mm}'", dtInicial.EditValue, dtFinal.EditValue.ToString.Replace("00:00", "23:59")) & strFiltro

                rel.lblTitulo.Text = "Relatório Caixa de " & dtInicial.EditValue & " a " & dtFinal.EditValue
            End If

            Dim dt As DataTable = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'C' GROUP BY Pagamento")


            .lblTotCred.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight

            For G = 0 To dt.Rows.Count - 1
                .lblTotCred.Text &= dt.Rows.Item(G).ItemArray(0).ToString & " R$ " & CDbl(dt.Rows.Item(G).ItemArray(1).ToString).ToString("###,###,##0.00") & vbCrLf
            Next

            dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & " AND Credito = 'D' GROUP BY Pagamento")

            .lblTotDeb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            For G = 0 To dt.Rows.Count - 1
                .lblTotDeb.Text &= dt.Rows.Item(G).ItemArray(0).ToString & " R$ " & CDbl(dt.Rows.Item(G).ItemArray(1).ToString).ToString("###,###,##0.00") & vbCrLf
            Next


            If NomeEmpresa.Contains("MAX DENIM") = True Then
                .lblLabelSaldoAtual.Visible = True
                .lblSaldoAtual.Visible = True
                .lblSaldoAtual.Text = Me.txtSaldoCaixa.Text
            End If
            .picLogo.Image = LogoTipo

            .ShowPreview()
        End With
    End Sub


    Private Sub VisualizarTotalSemTroco()
        Dim rel As New relCaixaTotal

        With rel

            Dim I As Integer

            Dim dblTroco As Double

            Me.tbPagamento.Rows.Clear()
            Me.tbCaixaSomado.Rows.Clear()

            Dim T As Integer
            Dim dbltotaaallll As Double = 0
            If TrocoCaixa = True Then
                For I = 0 To Me.grd1.RowCount - 1
                    Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)         
                    ImpPagamento(Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito))
                    CaixaSomado(Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), Me.grd1.GetRowCellDisplayText(I, Me.colCaixa))
                Next
            Else
                For I = 0 To Me.grd1.RowCount - 1
                    Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    dbltotaaallll += dblVal
                    If Me.grd1.GetRowCellDisplayText(I, Me.colMotivo).ToUpper.Contains("TROCO VENDA") = True Then
                        If CNPJEmpresa <> "19844010000131" And CNPJEmpresa <> "24724046000111" Then
                            For T = 0 To Me.tbCaixaSomado.Rows.Count - 1
                                If Me.tbCaixaSomado.Rows.Item(T).Item("Pagamento") = Me.grd1.GetRowCellDisplayText(I, Me.colPagamento) Then
                                    If Me.tbCaixaSomado.Rows.Item(T).Item("Caixa") = Me.grd1.GetRowCellDisplayText(I, Me.colCaixa) Then
                                        If Me.tbCaixaSomado.Rows.Item(T).Item("Credito") = "C" Then
                                            Dim dblValTroco As Double = Me.tbCaixaSomado.Rows.Item(T).Item("Valor")
                                            dblValTroco = dblValTroco - dblVal
                                            Me.tbCaixaSomado.Rows.Item(T).Item("Valor") = dblValTroco
                                            Exit For
                                        End If

                                    End If
                                End If

                            Next
                        End If
             

                    Else
                        ImpPagamento(Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito))
                        CaixaSomado(Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), Me.grd1.GetRowCellDisplayText(I, Me.colCaixa))

                    End If
                Next
            End If
            

            

            For I = 0 To Me.tbCaixaSomado.Rows.Count - 1
                Dim dblVal As Double = Me.tbCaixaSomado.Rows.Item(I).Item("Valor")
                Select Case Me.tbCaixaSomado.Rows.Item(I).Item("Credito")
                    Case "C"
                        .tbCaixa.Rows.Add()
                        .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Pagamento") = Me.tbCaixaSomado.Rows.Item(I).Item("Pagamento")
                        .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Credito") = dblVal.ToString("0.00")
                        .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Debito") = "0.00"
                        .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Saldo") = dblVal.ToString("0.00")
                        .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Caixa") = Me.tbCaixaSomado.Rows.Item(I).Item("Caixa")



                End Select
            Next

            Dim A As Integer
            For I = 0 To Me.tbCaixaSomado.Rows.Count - 1
                Dim dblVal As Double = Me.tbCaixaSomado.Rows.Item(I).Item("Valor")
                Select Case Me.tbCaixaSomado.Rows.Item(I).Item("Credito")
                    Case "D"
                        Dim bolNovo As Boolean = True
                        For A = 0 To .tbCaixa.Rows.Count - 1

                            If Me.tbCaixaSomado.Rows.Item(I).Item("Pagamento") = .tbCaixa.Rows.Item(A).Item("Pagamento") Then
                                If Me.tbCaixaSomado.Rows.Item(I).Item("Caixa") = .tbCaixa.Rows.Item(A).Item("Caixa") Then

                                    Dim dblCred As Double = .tbCaixa.Rows.Item(A).Item("Credito")

                                    .tbCaixa.Rows.Item(A).Item("Debito") = dblVal.ToString("0.00")
                                    dblVal = dblCred - dblVal
                                    .tbCaixa.Rows.Item(A).Item("Saldo") = dblVal.ToString("0.00")

                                    bolNovo = False
                                End If
                             
                            End If
                        Next
                        If bolNovo = True Then
                            .tbCaixa.Rows.Add()
                            .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Pagamento") = Me.tbCaixaSomado.Rows.Item(I).Item("Pagamento")
                            .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Debito") = dblVal.ToString("0.00")
                            .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Credito") = "0.00"
                            dblVal = 0 - dblVal
                            .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Saldo") = dblVal.ToString("0.00")
                            .tbCaixa.Rows.Item(.tbCaixa.Rows.Count - 1).Item("Caixa") = Me.tbCaixaSomado.Rows.Item(I).Item("Caixa")
                        End If
                     
                End Select
            Next

            Dim B As Integer
          

            For A = 0 To .tbCaixa.Rows.Count - 1
                Dim strPag As String = .tbCaixa.Rows.Item(A).Item("Pagamento")
                Dim dblTotalCredito As Double = .tbCaixa.Rows.Item(A).Item("Credito")
                Dim dblTotalDebito As Double = .tbCaixa.Rows.Item(A).Item("Debito")
                Dim dblSaldoTotal As Double

                Dim bolNovo As Boolean = True

                For B = 0 To .tbTotal.Rows.Count - 1

                    If strPag = .tbTotal.Rows.Item(B).Item("PagamentoTotal") Then
                        Dim dblCred As Double = .tbTotal.Rows.Item(B).Item("CreditoTotal")
                        Dim dblDeb As Double = .tbTotal.Rows.Item(B).Item("DebitoTotal")
                        dblTotalCredito = dblTotalCredito + dblCred
                        dblTotalDebito = dblTotalDebito + dblDeb

                        .tbTotal.Rows.Item(B).Item("DebitoTotal") = dblTotalDebito.ToString("0.00")
                        .tbTotal.Rows.Item(B).Item("CreditoTotal") = dblTotalCredito.ToString("0.00")
                        dblSaldoTotal = dblTotalCredito - dblTotalDebito
                        .tbTotal.Rows.Item(B).Item("SaldoTotal") = dblSaldoTotal.ToString("0.00")
                        bolNovo = False
                    End If
                Next
                If bolNovo = True Then
                    .tbTotal.Rows.Add()
                    .tbTotal.Rows.Item(.tbTotal.Rows.Count - 1).Item("PagamentoTotal") = strPag
                    .tbTotal.Rows.Item(.tbTotal.Rows.Count - 1).Item("DebitoTotal") = dblTotalDebito.ToString("0.00")
                    .tbTotal.Rows.Item(.tbTotal.Rows.Count - 1).Item("CreditoTotal") = dblTotalCredito.ToString("0.00")
                    dblSaldoTotal = dblTotalCredito - dblTotalDebito
                    .tbTotal.Rows.Item(.tbTotal.Rows.Count - 1).Item("SaldoTotal") = dblSaldoTotal.ToString("0.00")
                    .tbTotal.Rows.Item(.tbTotal.Rows.Count - 1).Item("CaixaTotal") = "TOTAL GERAL"
                End If

            Next
  
          
            .picLogo.Image = LogoTipo
           
            If bolFiltrado = True Then
                rel.lblTitulo.Text = "Relatório Caixa de " & dtInicial.EditValue & " a " & dtFinal.EditValue
            Else
                rel.lblTitulo.Text = "Relatório Caixa de " & Date.Today
            End If
            .grd1.Columns("Caixa").Group()
            .grd1.ExpandAllGroups()

            .GridView1.Columns("CaixaTotal").Group()
            .GridView1.ExpandAllGroups()
            .ShowPreview()
        End With
    End Sub

    Private Sub SomaExtrato(ByVal parMotivo As String, ByVal parPagamento As String, ByVal parValor As Double, ByVal parCredito As String, ByVal parTipo As Integer)
        Dim I As Integer
        If Me.tbExtrato.Rows.Count = 0 Then
            Me.tbExtrato.Rows.Add()
            Me.tbExtrato.Rows.Item(0).Item("Motivo") = parMotivo
            Me.tbExtrato.Rows.Item(0).Item("Pagamento") = parPagamento
            Me.tbExtrato.Rows.Item(0).Item("Valor") = parValor
            Me.tbExtrato.Rows.Item(0).Item("Credito") = parCredito
        Else
            Dim intCountPagamento As Integer = Me.tbExtrato.Rows.Count - 1
            Dim bolExiste As Boolean = False
            For I = 0 To intCountPagamento

                If Me.tbExtrato.Rows.Item(I).Item("Pagamento") = parPagamento Then
                    If parTipo = 0 Then

                        If Me.tbExtrato.Rows.Item(I).Item("Motivo") = parMotivo Then
                            Dim dblVal As Double = Me.tbExtrato.Rows.Item(I).Item("Valor")
                            dblVal = dblVal + parValor
                            Me.tbExtrato.Rows.Item(I).Item("Valor") = dblVal
                            bolExiste = True
                            Exit For
                        End If
                    ElseIf parTipo = 1 Then

                        If Me.tbExtrato.Rows.Item(I).Item("Pagamento") = parPagamento And Me.tbExtrato.Rows.Item(I).Item("Credito") = parCredito Then
                            Dim dblVal As Double = Me.tbExtrato.Rows.Item(I).Item("Valor")
                            dblVal = dblVal + parValor
                            Me.tbExtrato.Rows.Item(I).Item("Valor") = dblVal
                            bolExiste = True
                            Exit For
                        End If
                    End If
                End If

            Next

            If bolExiste = False Then
                Me.tbExtrato.Rows.Add()
                Me.tbExtrato.Rows.Item(Me.tbExtrato.Rows.Count - 1).Item("Motivo") = parMotivo
                Me.tbExtrato.Rows.Item(Me.tbExtrato.Rows.Count - 1).Item("Pagamento") = parPagamento
                Me.tbExtrato.Rows.Item(Me.tbExtrato.Rows.Count - 1).Item("Valor") = parValor
                Me.tbExtrato.Rows.Item(Me.tbExtrato.Rows.Count - 1).Item("Credito") = parCredito
            End If
        End If
    End Sub

    Private Function CalcularExtrato() As Double
        Dim dblTotal As Double = 0

        Try
            For J As Integer = 0 To Me.GridView1.RowCount - 1
                Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(J, Me.colValor1)
                Dim strCred As String = Me.GridView1.GetRowCellDisplayText(J, Me.colCredito1)

                If strCred <> "D" Then
                    dblTotal = dblTotal + dblValor
                Else
                    dblTotal = dblTotal + -dblValor
                End If

            Next
        Catch ex As Exception
            dblTotal = 0
        End Try

        Return dblTotal
    End Function

    Private Sub btnExtrato_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExtrato.ItemClick
        Calcular()

        Dim dblTotal As Double

        If Impressora.Contains("ESC/POS") = True Then
            If TemImpressora = False Then Exit Sub
            Dim strImpressao As String

            Dim data As Date = Date.Now
            Dim strData As String = data.ToString("dd/MM/yyyy HH:mm")

            strImpressao = Cabecalho()

            strImpressao &= "EXTRATO DO CAIXA" & Space(23) & strData & vbCrLf & vbCrLf
            strImpressao &= Dir("DINHEIRO", 55) & vbCrLf
            strImpressao &= strTraco & vbCrLf
            strImpressao &= vbCrLf


            'PREENCHE A TABELA EXTRATO EM DINHEIRO
            Me.colMotivo1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            Me.tbExtrato.Clear()
            For I As Integer = 0 To Me.grd1.RowCount - 1
                Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                If grd1.GetRowCellDisplayText(I, Me.colMotivo).Contains("Venda N") = False Then
                    If grd1.GetRowCellDisplayText(I, Me.colPagamento) = "DINHEIRO" Then
                        'SomaExtrato(Me.grd1.GetRowCellDisplayText(I, Me.colMotivo), Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito))
                        If grd1.GetRowCellDisplayText(I, Me.colMotivo).ToUpper.Contains("ENTRADA") = True Then
                            SomaExtrato("ENTRADA PEDIDO", Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                        Else
                            SomaExtrato(Me.grd1.GetRowCellDisplayText(I, Me.colMotivo), Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                        End If
                    End If
                Else
                    If grd1.GetRowCellDisplayText(I, Me.colPagamento) = "DINHEIRO" Then
                        Dim Motivo As String = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                        If Motivo.ToUpper.Contains("TROCO") = False Then
                            SomaExtrato("VENDA", Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                        Else
                            SomaExtrato("TROCO", Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                        End If
                    End If
                End If
            Next


            For J As Integer = 0 To Me.GridView1.RowCount - 1
                Dim strMotivo As String = Me.GridView1.GetRowCellDisplayText(J, Me.colMotivo1)
                Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(J, Me.colValor1)
                Dim strCredito As String = Me.GridView1.GetRowCellDisplayText(J, Me.colCredito1)

                Dim strValor As String = dblValor.ToString("###,###,##0.00")
                If strCredito = "D" Then
                    strValor = "-" & dblValor.ToString("###,###,##0.00")
                End If

                'strImpressao &= Dir(strMotivo, 8) & Esq(strValor, 48) & vbCrLf

                Dim lens As Integer = strMotivo.Length
                If lens >= 8 Then
                    Dim intEsq As Integer = 56 - lens
                    strImpressao &= strMotivo & Esq(strValor, intEsq) & vbCrLf
                Else
                    strImpressao &= Dir(strMotivo, 8) & Esq(strValor, 48) & vbCrLf
                End If
            Next

            'CALCULA TOTAL EM DINHEIRO DO EXTRATO
            dblTotal = CalcularExtrato()

            'strImpressao &= strTraco & vbCrLf
            'strImpressao &= vbCrLf
            strImpressao &= Neg(Dir(Space(1), 26) & Esq("SALDO DINHEIRO R$ " & dblTotal.ToString("###,###,##0.00"), 30)) & vbCrLf
            'strImpressao &= strTraco & vbCrLf & vbCrLf
            strImpressao &= vbCrLf


            'PREENCHE A TABELA EXTRATO EM CARTAO
            Me.colMotivo1.SortOrder = DevExpress.Data.ColumnSortOrder.None
            Me.colPagamento1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            Me.tbExtrato.Clear()
            For A As Integer = 0 To Me.grd1.RowCount - 1
                Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(A, Me.colValor)

                If grd1.GetRowCellDisplayText(A, Me.colMotivo).Contains("Venda N") = False Then
                    If grd1.GetRowCellDisplayText(A, Me.colPagamento) <> "DINHEIRO" Then
                        SomaExtrato(Me.grd1.GetRowCellDisplayText(A, Me.colMotivo), Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito), 1)
                    End If
                Else
                    If grd1.GetRowCellDisplayText(A, Me.colPagamento) <> "DINHEIRO" Then
                        Dim Motivo As String = grd1.GetRowCellDisplayText(A, Me.colMotivo)
                        If Motivo.ToUpper.Contains("TROCO") = False Then
                            SomaExtrato("VENDA", Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito), 1)
                        Else
                            'SomaExtrato("TROCO", Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito))
                        End If
                    End If
                End If
            Next

            Dim strPag As String
            Dim dblVal2 As Double = 0
            Dim count As Integer = 0
            Dim bolPassou As Boolean = False
            For B As Integer = 0 To Me.GridView1.RowCount - 1
                Dim strPagamento As String = Me.GridView1.GetRowCellDisplayText(B, Me.colPagamento1)
                Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(B, Me.colValor1)
                Dim strCredito As String = Me.GridView1.GetRowCellDisplayText(B, Me.colCredito1)

                If strPag <> strPagamento Then
                    strPag = strPagamento

                    If bolPassou = True Then
                        If count > 1 Then
                            'strImpressao &= vbCrLf
                            strImpressao &= Neg(Dir(Space(1), 26) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 30)) & vbCrLf
                            strImpressao &= vbCrLf
                            'strImpressao &= strTraco & vbCrLf & vbCrLf
                        Else
                            'strImpressao &= vbCrLf
                            'strImpressao &= strTraco & vbCrLf & vbCrLf
                        End If
                    End If
                    dblVal2 = 0
                    count = 0
                End If

                Dim strValor As String = dblValor.ToString("###,###,##0.00")
                If strCredito = "D" Then
                    strValor = "-" & dblValor.ToString("###,###,##0.00")
                End If

                Dim lens As Integer = strPagamento.Length

                If lens >= 8 Then
                    Dim intEsq As Integer = 56 - lens
                    strImpressao &= strPagamento & Esq(strValor, intEsq) & vbCrLf
                    If strCredito = "C" Then
                        dblVal2 = dblVal2 + dblValor
                    Else
                        dblVal2 = dblVal2 + -dblValor
                    End If
                    count = count + 1
                    bolPassou = True
                Else
                    strImpressao &= Dir(strPagamento, 8) & Esq(strValor, 48) & vbCrLf
                    If strCredito = "C" Then
                        dblVal2 = dblVal2 + dblValor
                    Else
                        dblVal2 = dblVal2 + -dblValor
                    End If
                    count = count + 1
                    bolPassou = True
                End If
            Next

            If count > 1 Then
                'strImpressao &= vbCrLf
                strImpressao &= Neg(Dir(Space(1), 26) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 30)) & vbCrLf
                'strImpressao &= vbCrLf
            Else
                'strImpressao &= vbCrLf
            End If
            'strImpressao &= vbCrLf
            'strImpressao &= Neg(Dir(Space(1), 26) & Esq("Saldo R$ " & dblVal2, 30)) & vbCrLf

            'strImpressao &= Dir("Crédito", 8) & Esq(Me.txtCred.Text, 48) & vbCrLf
            'strImpressao &= Dir("Débito", 8) & Esq(Me.txtDeb.Text, 48) & vbCrLf

            Dim dlbTotalCartao As Double = CalcularExtrato()
            Dim dblSaldo As Double = dlbTotalCartao + dblTotal

            strImpressao &= strTraco & vbCrLf
            strImpressao &= Neg(Dir(Space(1), 26) & Esq("SALDO CAIXA R$ " & dblSaldo.ToString("###,###,##0.00"), 30)) & vbCrLf

            strImpressao = strImpressao


            Rodape(True, strImpressao)

        ElseIf Impressora.Contains("MP") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then
            If TemImpressora = False Then Exit Sub
            Dim strImpressao As String

            If Impressora.Contains("MP-4000") Then
                iRetorno = ConfiguraModeloImpressora(5)
                iRetorno = SelecionaQualidadeImpressao(3)
            Else
                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = ConfiguraModeloImpressora(1)
                End If
            End If


            If Impressora.Contains("BEMATECH") = True Then
                iRetorno = clsBematech.IniciaPorta(PortaImpressora)

            ElseIf Impressora.Contains("MP-4000") = True Then
                Try
                    iRetorno = clsBematech.IniciaPorta(PortaImpressora)
                Catch ex As Exception
                End Try
            End If

            Dim data As Date = Date.Now
            Dim strData As String = data.ToString("dd/MM/yyyy HH:mm")


            Dim intTamEsp As Integer
            Dim strEstrela, strTraço As String

            If Impressora.Contains("ARQUIVO") = True Then
                intTamEsp = 42
                'strEstrela = "******************************************"
                strEstrela = "=========================================="
                strTraço = "------------------------------------------"
            Else
                intTamEsp = 60
                'strEstrela = "************************************************************"
                strEstrela = "============================================================"
                strTraço = "------------------------------------------------------------"
            End If

            strImpressao = strEstrela & vbCrLf
            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf
            strImpressao &= strEstrela & vbCrLf


            If Impressora.Contains("ARQUIVO") = True Then

                strImpressao &= Dir("EXTRATO DO CAIXA", 22) & Esq(strData, 20) & vbCrLf & vbCrLf
                strImpressao &= Dir("DINHEIRO", 22) & vbCrLf
                strImpressao &= strTraço & vbCrLf & vbCrLf

                'PREENCHE A TABELA EXTRATO
                Me.colMotivo1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                Me.tbExtrato.Clear()
                For I As Integer = 0 To Me.grd1.RowCount - 1
                    Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                    If grd1.GetRowCellDisplayText(I, Me.colMotivo).Contains("Venda N") = False Then
                        If grd1.GetRowCellDisplayText(I, Me.colPagamento) = "DINHEIRO" Then
                            If grd1.GetRowCellDisplayText(I, Me.colMotivo).ToUpper.Contains("ENTRADA") = True Then
                                SomaExtrato("ENTRADA PEDIDO", Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                            Else
                                SomaExtrato(Me.grd1.GetRowCellDisplayText(I, Me.colMotivo), Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                            End If
                        End If
                    Else
                        If grd1.GetRowCellDisplayText(I, Me.colPagamento) = "DINHEIRO" Then
                            Dim Motivo As String = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                            If Motivo.ToUpper.Contains("TROCO") = False Then
                                SomaExtrato("VENDA", Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                            Else
                                SomaExtrato("TROCO", Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                            End If
                        End If
                    End If
                Next


                For J As Integer = 0 To Me.GridView1.RowCount - 1
                    Dim strMotivo As String = Me.GridView1.GetRowCellDisplayText(J, Me.colMotivo1)
                    Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(J, Me.colValor1)
                    Dim strCred As String = Me.GridView1.GetRowCellDisplayText(J, Me.colCredito1)

                    Dim strValor As String = dblValor.ToString("###,###,##0.00")
                    If strCred = "D" Then
                        strValor = "-" & dblValor.ToString("###,###,##0.00")
                    End If

                    'strImpressao &= Dir(strMotivo, 32) & Esq(strValor, 10) & vbCrLf
                    Dim lens As Integer = strMotivo.Length
                    If lens >= 32 Then
                        Dim intEsq As Integer = 32 - lens
                        strImpressao &= strMotivo & Esq(strValor, intEsq) & vbCrLf
                    Else
                        strImpressao &= Dir(strMotivo, 32) & Esq(strValor, 10) & vbCrLf
                    End If
                Next

                'CALCULA TOTAL EM DINHEIRO DO EXTRATO
                dblTotal = CalcularExtrato()

                'strImpressao &= strTraço & vbCrLf
                'strImpressao &= " " & vbCrLf

                Dim lenD As Integer = CStr("SALDO DINHEIRO R$ " & dblTotal.ToString("###,###,##0.00")).Length

                If lenD > 20 Then
                    Dim intDir As Integer = 42 - lenD
                    strImpressao &= Dir(Space(1), intDir) & Esq("SALDO DINHEIRO R$ " & dblTotal.ToString("###,###,##0.00"), 20) & vbCrLf
                Else
                    strImpressao &= Dir(Space(1), 22) & Esq("SALDO DINHEIRO R$ " & dblTotal.ToString("###,###,##0.00"), 20) & vbCrLf
                End If
                'strImpressao &= strTraço & vbCrLf & vbCrLf
                strImpressao &= " " & vbCrLf


                'PREENCHE A TABELA EXTRATO EM CARTAO
                Me.colMotivo1.SortOrder = DevExpress.Data.ColumnSortOrder.None
                Me.colPagamento1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                Me.tbExtrato.Clear()
                For A As Integer = 0 To Me.grd1.RowCount - 1
                    Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(A, Me.colValor)

                    If grd1.GetRowCellDisplayText(A, Me.colMotivo).Contains("Venda N") = False Then
                        If grd1.GetRowCellDisplayText(A, Me.colPagamento) <> "DINHEIRO" Then
                            SomaExtrato(Me.grd1.GetRowCellDisplayText(A, Me.colMotivo), Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito), 1)
                        End If
                    Else
                        If grd1.GetRowCellDisplayText(A, Me.colPagamento) <> "DINHEIRO" Then
                            Dim Motivo As String = grd1.GetRowCellDisplayText(A, Me.colMotivo)
                            If Motivo.ToUpper.Contains("TROCO") = False Then
                                SomaExtrato("VENDA", Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito), 1)
                            Else
                                'SomaExtrato("TROCO", Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito))
                            End If
                        End If
                    End If
                Next

                Dim strPag As String
                Dim dblVal2 As Double = 0
                Dim count As Integer = 0
                Dim bolPassou As Boolean = False
                For B As Integer = 0 To Me.GridView1.RowCount - 1
                    Dim strPagamento As String = Me.GridView1.GetRowCellDisplayText(B, Me.colPagamento1)
                    Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(B, Me.colValor1)
                    Dim strCredito As String = Me.GridView1.GetRowCellDisplayText(B, Me.colCredito1)

                    If strPag <> strPagamento Then
                        strPag = strPagamento

                        If bolPassou = True Then
                            If count > 1 Then
                                lenD = CStr("SALDO R$ " & dblVal2.ToString("###,###,##0.00")).Length
                                If lenD > 20 Then
                                    Dim intDir As Integer = 42 - lenD
                                    strImpressao &= Dir(Space(1), intDir) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 20) & vbCrLf & vbCrLf
                                    'strImpressao &= strTraço & vbCrLf & vbCrLf
                                Else
                                    strImpressao &= Dir(Space(1), 22) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 20) & vbCrLf & vbCrLf
                                    'strImpressao &= strTraço & vbCrLf & vbCrLf
                                End If
                            Else
                                'strImpressao &= strTraço & vbCrLf & vbCrLf
                            End If
                        End If
                        dblVal2 = 0
                        count = 0
                    End If

                    Dim strValor As String = dblValor.ToString("###,###,##0.00")
                    If strCredito = "D" Then
                        strValor = "-" & dblValor.ToString("###,###,##0.00")
                    End If

                    Dim lens As Integer = strPagamento.Length

                    If lens >= 32 Then
                        Dim intEsq As Integer = 42 - lens
                        strImpressao &= strPagamento & Esq(strValor, intEsq) & vbCrLf
                        If strCredito = "C" Then
                            dblVal2 = dblVal2 + dblValor
                        Else
                            dblVal2 = dblVal2 + -dblValor
                        End If
                        count = count + 1
                        bolPassou = True
                    Else
                        strImpressao &= Dir(strPagamento, 32) & Esq(strValor, 10) & vbCrLf
                        If strCredito = "C" Then
                            dblVal2 = dblVal2 + dblValor
                        Else
                            dblVal2 = dblVal2 + -dblValor
                        End If
                        count = count + 1
                        bolPassou = True
                    End If
                Next

                If count > 1 Then
                    lenD = CStr("SALDO R$ " & dblVal2.ToString("###,###,##0.00")).Length
                    If lenD > 20 Then
                        Dim intDir As Integer = 42 - lenD
                        strImpressao &= Dir(Space(1), intDir) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 20) & vbCrLf '& vbCrLf
                        'strImpressao &= strTraço & vbCrLf & vbCrLf
                    Else
                        strImpressao &= Dir(Space(1), 22) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 20) & vbCrLf '& vbCrLf
                        'strImpressao &= strTraço & vbCrLf & vbCrLf
                    End If
                End If

                'strImpressao &= Dir("Credito", 32) & Esq(Me.txtCred.Text, 10) & vbCrLf
                'strImpressao &= Dir("Debito", 32) & Esq(Me.txtDeb.Text, 10) & vbCrLf

                Dim dlbTotalCartao As Double = CalcularExtrato()
                Dim dblSaldo As Double = dlbTotalCartao + dblTotal

                strImpressao &= strTraço & vbCrLf

                Dim len As Integer = CStr("SALDO CAIXA R$ " & dblSaldo.ToString("###,###,##0.00")).Length

                If len > 20 Then
                    Dim intDir As Integer = 42 - len
                    strImpressao &= Dir(Space(1), intDir) & Esq("SALDO CAIXA R$ " & dblSaldo.ToString("###,###,##0.00"), 20) & vbCrLf
                Else
                    strImpressao &= Dir(Space(1), 22) & Esq("SALDO CAIXA R$ " & dblSaldo.ToString("###,###,##0.00"), 20) & vbCrLf
                End If

            Else
                strImpressao &= Dir("EXTRATO DO CAIXA", 40) & Esq(strData, 20) & vbCrLf & vbCrLf
                strImpressao &= Dir("DINHEIRO", 22) & vbCrLf
                strImpressao &= strTraço & vbCrLf & vbCrLf

                'PREENCHE A TABELA EXTRATO
                Me.colMotivo1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                Me.tbExtrato.Clear()
                For I As Integer = 0 To Me.grd1.RowCount - 1
                    Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                    If grd1.GetRowCellDisplayText(I, Me.colMotivo).Contains("Venda N") = False Then
                        If grd1.GetRowCellDisplayText(I, Me.colPagamento) = "DINHEIRO" Then
                            SomaExtrato(Me.grd1.GetRowCellDisplayText(I, Me.colMotivo), Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                        End If
                    Else
                        If grd1.GetRowCellDisplayText(I, Me.colPagamento) = "DINHEIRO" Then
                            Dim Motivo As String = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                            If Motivo.ToUpper.Contains("TROCO") = False Then
                                SomaExtrato("VENDA", Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                            Else
                                SomaExtrato("TROCO", Me.grd1.GetRowCellDisplayText(I, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(I, Me.colCredito), 0)
                            End If
                        End If
                    End If
                Next


                For J As Integer = 0 To Me.GridView1.RowCount - 1
                    Dim strMotivo As String = Me.GridView1.GetRowCellDisplayText(J, Me.colMotivo1)
                    Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(J, Me.colValor1)
                    Dim strCred As String = Me.GridView1.GetRowCellDisplayText(J, Me.colCredito1)

                    Dim strValor As String = dblValor.ToString("###,###,##0.00")
                    If strCred = "D" Then
                        strValor = "-" & dblValor.ToString("###,###,##0.00")
                    End If

                    'strImpressao &= Dir(strMotivo, 50) & Esq(strValor, 10) & vbCrLf
                    Dim lens As Integer = strMotivo.Length
                    If lens >= 50 Then
                        Dim intEsq As Integer = 50 - lens
                        strImpressao &= strMotivo & Esq(strValor, intEsq) & vbCrLf
                    Else
                        strImpressao &= Dir(strMotivo, 50) & Esq(strValor, 10) & vbCrLf
                    End If
                Next

                'CALCULA TOTAL EM DINHEIRO DO EXTRATO
                dblTotal = CalcularExtrato()

                'strImpressao &= strTraço & vbCrLf
                Dim lenD As Integer = CStr("SALDO DINHEIRO R$ " & dblTotal.ToString("###,###,##0.00")).Length

                If lenD > 40 Then
                    Dim intDir As Integer = 60 - lenD
                    strImpressao &= Dir(Space(1), intDir) & Esq("SALDO DINHEIRO R$ " & dblTotal.ToString("###,###,##0.00"), 20) & vbCrLf
                Else
                    strImpressao &= Dir(Space(1), 40) & Esq("SALDO DINHEIRO R$ " & dblTotal.ToString("###,###,##0.00"), 20) & vbCrLf
                End If
                'strImpressao &= Dir(Space(1), 40) & Esq("Saldo Dinheiro R$ " & dblTotal.ToString("###,###,##0.00"), 20) & vbCrLf
                'strImpressao &= strTraço & vbCrLf
                strImpressao &= " " & vbCrLf

                'strImpressao &= Dir("Credito", 50) & Esq(Me.txtCred.Text, 10) & vbCrLf
                'strImpressao &= Dir("Debito", 50) & Esq(Me.txtDeb.Text, 10) & vbCrLf

                'PREENCHE A TABELA EXTRATO EM CARTAO
                Me.colMotivo1.SortOrder = DevExpress.Data.ColumnSortOrder.None
                Me.colPagamento1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                Me.tbExtrato.Clear()
                For A As Integer = 0 To Me.grd1.RowCount - 1
                    Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(A, Me.colValor)

                    If grd1.GetRowCellDisplayText(A, Me.colMotivo).Contains("Venda N") = False Then
                        If grd1.GetRowCellDisplayText(A, Me.colPagamento) <> "DINHEIRO" Then
                            SomaExtrato(Me.grd1.GetRowCellDisplayText(A, Me.colMotivo), Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito), 1)
                        End If
                    Else
                        If grd1.GetRowCellDisplayText(A, Me.colPagamento) <> "DINHEIRO" Then
                            Dim Motivo As String = grd1.GetRowCellDisplayText(A, Me.colMotivo)
                            If Motivo.ToUpper.Contains("TROCO") = False Then
                                SomaExtrato("VENDA", Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito), 1)
                            Else
                                'SomaExtrato("TROCO", Me.grd1.GetRowCellDisplayText(A, Me.colPagamento), dblVal, Me.grd1.GetRowCellDisplayText(A, Me.colCredito))
                            End If
                        End If
                    End If
                Next

                Dim strPag As String
                Dim dblVal2 As Double = 0
                Dim count As Integer = 0
                Dim bolPassou As Boolean = False
                For B As Integer = 0 To Me.GridView1.RowCount - 1
                    Dim strPagamento As String = Me.GridView1.GetRowCellDisplayText(B, Me.colPagamento1)
                    Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(B, Me.colValor1)
                    Dim strCredito As String = Me.GridView1.GetRowCellDisplayText(B, Me.colCredito1)

                    If strPag <> strPagamento Then
                        strPag = strPagamento

                        If bolPassou = True Then
                            If count > 1 Then
                                lenD = CStr("SALDO R$ " & dblVal2.ToString("###,###,##0.00")).Length
                                If lenD > 40 Then
                                    Dim intDir As Integer = 60 - lenD
                                    strImpressao &= Dir(Space(1), intDir) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 20) & vbCrLf & vbCrLf
                                    'strImpressao &= strTraço & vbCrLf & vbCrLf
                                Else
                                    strImpressao &= Dir(Space(1), 40) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 20) & vbCrLf & vbCrLf
                                    'strImpressao &= strTraço & vbCrLf & vbCrLf
                                End If
                            Else
                                'strImpressao &= strTraço & vbCrLf & vbCrLf
                            End If
                        End If
                        dblVal2 = 0
                        count = 0
                    End If

                    Dim strValor As String = dblValor.ToString("###,###,##0.00")
                    If strCredito = "D" Then
                        strValor = "-" & dblValor.ToString("###,###,##0.00")
                    End If

                    Dim lens As Integer = strPagamento.Length

                    If lens >= 50 Then
                        Dim intEsq As Integer = 60 - lens
                        strImpressao &= strPagamento & Esq(strValor, intEsq) & vbCrLf
                        If strCredito = "C" Then
                            dblVal2 = dblVal2 + dblValor
                        Else
                            dblVal2 = dblVal2 + -dblValor
                        End If
                        count = count + 1
                        bolPassou = True
                    Else
                        strImpressao &= Dir(strPagamento, 50) & Esq(strValor, 10) & vbCrLf
                        If strCredito = "C" Then
                            dblVal2 = dblVal2 + dblValor
                        Else
                            dblVal2 = dblVal2 + -dblValor
                        End If
                        count = count + 1
                        bolPassou = True
                    End If
                Next

                If count > 1 Then
                    lenD = CStr("SALDO R$ " & dblVal2.ToString("###,###,##0.00")).Length
                    If lenD > 40 Then
                        Dim intDir As Integer = 60 - lenD
                        strImpressao &= Dir(Space(1), intDir) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 20) & vbCrLf
                    Else
                        strImpressao &= Dir(Space(1), 40) & Esq("SALDO R$ " & dblVal2.ToString("###,###,##0.00"), 20) & vbCrLf
                    End If
                End If

                Dim dlbTotalCartao As Double = CalcularExtrato()
                Dim dblSaldo As Double = dlbTotalCartao + dblTotal

                strImpressao &= strTraço & vbCrLf

                Dim len As Integer = CStr("SALDO CAIXA R$ " & dblSaldo.ToString("###,###,##0.00")).Length

                If len > 40 Then
                    Dim intDir As Integer = 60 - len
                    strImpressao &= Dir(Space(1), intDir) & Esq("SALDO CAIXA R$ " & dblSaldo.ToString("###,###,##0.00"), 20) & vbCrLf
                Else
                    strImpressao &= Dir(Space(1), 40) & Esq("SALDO CAIXA R$ " & dblSaldo.ToString("###,###,##0.00"), 20) & vbCrLf
                End If

                'strImpressao &= strTraço & vbCrLf
                'strImpressao &= Dir(Space(1), 40) & Esq("Saldo Caixa R$ " & Me.txtSaldo.Text, 20) & vbCrLf
            End If

            strImpressao &= strTraço & vbCrLf
            strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf
            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            If Impressora = "ARQUIVO" Then
                'ImprimiArquivo(strImpressao, PortaImpressora)
                clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)

                If TemGuilhotina = True Then
                    strImpressao = clsImprimir.Avanco() & vbCrLf
                    strImpressao &= clsImprimir.Corte()
                    clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                End If

                If TemGaveta = True Then
                    strImpressao = clsImprimir.AbreGaveta() & vbCrLf
                    clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                End If

            ElseIf Impressora.Contains("NANO PRINT") = True Then
                If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                    ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                Else
                    EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
                End If
            Else
                iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If

                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = clsBematech.FechaPorta()
                Else
                    Try
                        iRetorno = clsBematech.FechaPorta()
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub btnCadMotivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadMotivo.Click
        Dim frm As New frmGrupo
        frm.Tag = "MOTIVO"
        frm.ShowDialog()
        Me.txtMot.Properties.Items.Clear()
        PreencherGrupoSetorCusto("R", Me.txtMot, "D")
        Me.txtMot.Focus()
    End Sub

    Private Sub txtMot_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMot.Leave
        If Me.txtMot.Text = "" Then Exit Sub

        Dim dt As DataTable = CarregarDataTable("SELECT Tipo FROM Grupo where Nome = '" & Me.txtMot.Text & "' and Tipo = 'D' or Nome = '" & Me.txtMot.Text & "' and Tipo = 'R'")
        If dt.Rows.Count > 0 Then
            Dim strTipo As String = dt.Rows.Item(0).Item("Tipo").ToString
            If strTipo = "R" Then
                strTipo = "C"
            End If
            Me.cboCred.Text = strTipo
        End If
    End Sub

    Private Sub txtMot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMot.SelectedIndexChanged
        If AbrirFecharCaixa = True Then
        
            If Me.txtMot.Text = "ABERTURA CAIXA" Or Me.txtMot.Text = "FECHAMENTO CAIXA" Then
                Me.dtData.Enabled = False
                Me.cboCenCus.Enabled = False
                Me.cboCred.Enabled = False
                Me.cboPag.Enabled = False
                Me.cboPag.Text = "DINHEIRO"
                Me.txtVal.Focus()
            Else
                Me.dtData.Enabled = True
                Me.cboCenCus.Enabled = True
                Me.cboCred.Enabled = True
                Me.cboPag.Enabled = True

                Me.cboPag.ResetText()
            End If
        End If
    End Sub
End Class
