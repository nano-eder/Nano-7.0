Imports Nano.clsFuncoes
Public Class frmGastosFunc
    Dim strFiltro As String
    Private Sub frmGastosFunc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)
        CarregarDadosLue3("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFuncionario)

        If TipoNano = 5 Then
            Me.GridColumn3.Visible = True
            Me.GridColumn4.Visible = True
        Else
            Me.GridColumn3.Visible = False
            Me.GridColumn4.Visible = False
        End If
        ConfigurarGrid(Me.grd2, Me, True, Me.btnPadrao)

        If Me.Tag = "CADASTRA" Then
            'AtualizarGrid(Date.Today, Date.Today, "")
            Me.dtData.EditValue = Date.Today
        End If
        Organizacao()
        Calcular()
        Me.txtDias.Text = "30"
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colFuncionario
        grd1.ShowEditor()

    End Sub

    Private Sub AtualizarGrid(ByVal parInicial As Date, ByVal parFinal As Date, ByVal parCodFunc As String)
        If Master = False Then
            strFiltro = " and GastosFunc.CodConfig =" & CodConfig
        End If
        Dim strData As String = String.Format("GastosFunc.Data >= '{0:dd/MM/yyyy}' AND GastosFunc.Data <= '{1:dd/MM/yyyy}'", parInicial, parFinal) & strFiltro

        If parCodFunc <> "" Then
            parCodFunc = " and CodFunc = " & parCodFunc
        End If

        CarregarDados("SELECT GastosFunc.Codigo, CodFunc, Valor, convert(varchar(10),GastosFunc.Data,103) as Data, Funcionario.Nome as Funcionario, " & _
        "Motivo, Tipo FROM GastosFunc left join Funcionario on GastosFunc.CodFunc = Funcionario.Codigo " & _
        "where " & strData & parCodFunc, Me.GridControl1)

    End Sub

    Private Sub AtualizarGrid2(ByVal parInicial As Date, ByVal parFinal As Date, ByVal parCodFunc As String)
        If Master = False Then
            strFiltro = " and Representacao.CodConfig =" & CodConfig
        End If
        Dim strData As String = String.Format("Representacao.Data >= '{0:dd/MM/yyyy}' AND Representacao.Data <= '{1:dd/MM/yyyy}'", parInicial, parFinal) & strFiltro
        If parCodFunc <> "" Then
            parCodFunc = " and CodFunc = " & parCodFunc
        End If
        CarregarDados("SELECT Representacao.Codigo, CodPed, CodCli, CodFunc, Valor, Porcentagem, ComissaoFunc, ComissaoEsc, " & _
        "Representacao.Data, Cliente.Nome as Cliente, Funcionario.Nome as Funcionario FROM (Representacao left join Cliente " & _
        "on Representacao.CodCli = Cliente.Codigo) left join Funcionario on Representacao.CodFunc = Funcionario.Codigo " & _
        "where " & strData & parCodFunc, Me.GridControl2)

    End Sub

    Private Sub Limpar()
        Me.lueFunc.EditValue = DBNull.Value
        CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)
        Me.lueFuncionario.EditValue = DBNull.Value
        CarregarDadosLue3("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFuncionario)
        Me.txtDias.Text = "30"
        Me.dtData.EditValue = Date.Today
        Me.txtValor.ResetText()
        Me.txtMotivo.ResetText()
        Me.cboTipo.SelectedIndex = -1
        Me.lueFunc.Focus()
        Me.lueFunc.ClosePopup()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
   
        If Validar(Me.lueFunc) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        If Validar(Me.txtMotivo) = False Then Exit Sub
        If Validar(Me.dtData) = False Then Exit Sub
        If Validar(Me.cboTipo) = False Then Exit Sub


        If Validar(Me.txtDias) = False Then Exit Sub


        If Me.seParcela.Value <= 0 Then MsgBox("Número de Nº Parcelas é obrigatório!", MsgBoxStyle.Information) : Exit Sub

        Dim I As Integer
        Dim dblValConta, dblValPar As Double
        dblValConta = Me.txtValor.Text.Trim
        Dim dtDate As Date = Me.dtData.DateTime

        For I = 0 To Me.seParcela.Value - 1

            Dim strCodigo As String = GerarCodigo("GastosFunc", "Codigo", CodConfig) - 1

            With Me.tbGasto.Rows
                .Add()
                .Item(.Count - 1).Item("Codigo") = strCodigo
                .Item(.Count - 1).Item("Funcionario") = Me.lueFunc.Text
                .Item(.Count - 1).Item("Data") = dtDate
                .Item(.Count - 1).Item("Motivo") = Me.txtMotivo.Text.Trim
                .Item(.Count - 1).Item("Valor") = dblValConta.ToString("0.00")
                .Item(.Count - 1).Item("Tipo") = Me.cboTipo.Text

            End With


            Inserir("INSERT INTO GastosFunc (CodFunc, Valor, Motivo, Tipo, Data, CodConfig) VALUES (" & Me.lueFunc.EditValue & "," & _
            "" & Num(dblValConta) & ",'" & Me.txtMotivo.Text & "','" & Me.cboTipo.Text & "','" & dtDate & "'," & CodConfig & ")")


            If Me.txtDias.Text = "30" Then
                dtDate = dtDate.AddMonths(1)
            Else
                dtDate = dtDate.AddDays(Me.txtDias.Text)
            End If
        Next
        MsgBox("Gastos cadastrados com sucesso!", MsgBoxStyle.Information)
        Limpar()
        'AtualizarGrid(Date.Today, Date.Today, "")
        Calcular()
    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        If Me.Tag = "CADASTRA" Then
            AtualizarGrid(dtInicial.EditValue, dtFinal.EditValue, "")
        Else
            Dim strCodFunc As String = Me.lueFuncionario.EditValue
            If strCodFunc = "" Then MsgBox("Selecione o Funcionário!", MsgBoxStyle.Information) : Exit Sub

            AtualizarGrid(dtInicial.EditValue, dtFinal.EditValue, Me.lueFuncionario.EditValue)
            If NomeEmpresa.Trim.ToUpper.Contains("CHARME REPRESENTAÇÕES") = True Then
                AtualizarGrid2(dtInicial.EditValue, dtFinal.EditValue, Me.lueFuncionario.EditValue)
            Else
                AtualizarGrid3(dtInicial.EditValue, dtFinal.EditValue, Me.lueFuncionario.EditValue)
            End If

        End If
        Calcular()
    End Sub
    Private Sub AtualizarGrid3(ByVal parInicial As Date, ByVal parFinal As Date, ByVal parCodFunc As String)
        If Master = False Then
            strFiltro = " and Comissao.CodConfig =" & CodConfig
        End If
        Dim strData As String = String.Format("Comissao.Data >= '{0:dd/MM/yyyy}' AND Comissao.Data <= '{1:dd/MM/yyyy}'", parInicial, parFinal) & strFiltro
        If parCodFunc <> "" Then
            parCodFunc = " and Comissao.CodFunc = " & parCodFunc
        End If

        CarregarDados("SELECT Comissao.CodOrdem as CodPed, Comissao.Data, " & _
        "Convert(Numeric(15,2),Comissao.ValorProduto) as Valor, Convert(Numeric(15,2),Comissao.ValorComissao) as ComissaoFunc, " & _
        "Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, Funcionario.Nome as Funcionario, " & _
        "Cliente.Nome as Cliente, Total.Placa, Total.Modelo FROM ((Comissao left join Funcionario on Comissao.CodFunc = Funcionario.Codigo) " & _
        "Left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) " & _
        "Left join Cliente on Total.CodCli = Cliente.Codigo where " & strData & parCodFunc, Me.GridControl2)

    End Sub
    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Dim strCodigo As String
        strCodigo = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
        Dim strMotivo As String = "Data " & grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colData) & " Vend. " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colFuncionario) & " Val. R$ " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValor)

        If MsgBox("Deseja realmente excluir este gasto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If SenhaEstaOK() = False Then Exit Sub

            Excluir("DELETE FROM GastosFunc where Codigo = " & strCodigo)

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strMotivo & "','EXCLUIDO','GASTOS FUNC','GASTOS FUNC','EXCLUSÃO'," & CodConfig & ")")
            MsgBox("Gasto excluido com sucesso!", MsgBoxStyle.Information)
            AtualizarGrid(Date.Today, Date.Today, "")
            Calcular()
        End If

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        If Me.Tag = "CADASTRA" Then
            VisualizarCredidoDebito()
        Else
            VisualizarComissao()
        End If
       
    End Sub
    Private Sub VisualizarCredidoDebito()
        Dim rel As New relRepresentacao

        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        Dim I As Integer
        Dim A As Integer = 0
        With rel.tbRep.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colFuncionario) <> "" Then
                    .Add()
                    '.Item(A).Item("CodPed") = Me.grd1.GetRowCellDisplayText(I, Me.colCodPed)
                    .Item(A).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                    '.Item(A).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)
                    .Item(A).Item("Funcionario") = Me.grd1.GetRowCellDisplayText(I, Me.colFuncionario)
                    .Item(A).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    .Item(A).Item("Porcentagem") = Me.grd1.GetRowCellDisplayText(I, Me.colTipo)
                    .Item(A).Item("ComissaoFunc") = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
                    '.Item(A).Item("ComissaoEsc") = Me.grd1.GetRowCellDisplayText(I, Me.colComissaoEsc)
                    A += 1
                End If
            Next
        End With
        rel.colPorcentagem.Caption = "Tipo"
        rel.colComissaoFunc.Caption = "Motivo"

        rel.colCodPed.Visible = False
        rel.colCliente.Visible = False
        rel.colComissaoEsc.Visible = False

        rel.colData.VisibleIndex = 0
        rel.colFuncionario.VisibleIndex = 1
        rel.colFuncionario.Width = 200
        rel.colPorcentagem.VisibleIndex = 2
        rel.colPorcentagem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        rel.colComissaoFunc.VisibleIndex = 3
        rel.colComissaoFunc.Width = 200
        rel.colComissaoFunc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default
        rel.colValor.VisibleIndex = 4

        rel.XrLabel9.Text = "Total Crédito R$"
        rel.XrLabel10.Text = "Total Débito R$"
        rel.XrLabel11.Text = "Saldo R$"
        rel.lblValorTotal.Text = Me.txtCred.Text
        rel.lblComissaoEsc.Text = Me.txtDeb.Text
        rel.lblComissaoVend.Text = Me.txtSaldo.Text

        rel.ShowPreview()
    End Sub
    Private Sub VisualizarComissao()
        Dim rel As New relComissaoDetail

        With rel
            Dim strCodFunc As String = Me.lueFuncionario.EditValue
            Dim strFuncionario As String = ""
            Dim dt As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFunc)
            If dt.Rows.Count > 0 Then
                strFuncionario = dt.Rows.Item(0).Item("Nome").ToString
            End If
            .lblDataIni.Text = Me.dtInicial.EditValue
            .lblDataFim.Text = Me.dtFinal.EditValue
            .lblFunc.Text = strFuncionario
            .lblComis.Text = Me.txtComissaoVend.Text.Trim
            .lblCre.Text = Me.txtCred.Text.Trim
            .lblDeb.Text = Me.txtDeb.Text.Trim
            .lblSaldo.Text = Me.txtSaldo.Text.Trim
            .lblTot.Text = Me.txtTotalGeral.Text

            .lblTitulo2.Text = NomeEmpresa
            .lblSaldo2.Text = Me.txtTotalGeral.Text
            .lblFunc2.Text = strFuncionario
            





            Dim I As Integer

            Dim J As Integer = 0
            For I = 0 To grd1.RowCount - 1

                If Me.grd1.GetRowCellDisplayText(I, Me.colTipo) = "C" Then
                    .tbCred.Rows.Add()

                    .tbCred.Rows.Item(J).Item("Motivo") = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
                    .tbCred.Rows.Item(J).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    .tbCred.Rows.Item(J).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)

                    J = J + 1
                End If
            Next

            Dim L As Integer
            For I = 0 To grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colTipo) = "D" Then
                    .tbDeb.Rows.Add()

                    .tbDeb.Rows.Item(L).Item("Motivo") = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
                    .tbDeb.Rows.Item(L).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    .tbDeb.Rows.Item(L).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                    L = L + 1
                End If
            Next

            For I = 0 To grd2.RowCount - 1
                .dtCom.Rows.Add()
                .dtCom.Rows.Item(I).Item("CodigoPedido") = grd2.GetRowCellDisplayText(I, Me.colCodPed)
                .dtCom.Rows.Item(I).Item("Data") = grd2.GetRowCellDisplayText(I, Me.colData1)


                If TipoNano = 5 Then
                    rel.colFuncionario.Caption = "Placa - Modelo"
                    .dtCom.Rows.Item(I).Item("Funcionario") = grd2.GetRowCellDisplayText(I, Me.GridColumn3) & " - " & grd2.GetRowCellDisplayText(I, Me.GridColumn4)
                Else
                    rel.colFuncionario.Caption = "Vendedor"
                    .dtCom.Rows.Item(I).Item("Funcionario") = grd2.GetRowCellDisplayText(I, Me.colFuncionario1)
                End If

                .dtCom.Rows.Item(I).Item("ValorServico") = grd2.GetRowCellDisplayText(I, Me.colValor1)
                .dtCom.Rows.Item(I).Item("Porcentagem") = grd2.GetRowCellDisplayText(I, Me.colPorcentagem)
                .dtCom.Rows.Item(I).Item("Comissao") = grd2.GetRowCellDisplayText(I, Me.colComissaoFunc)
                .dtCom.Rows.Item(I).Item("Cliente") = grd2.GetRowCellDisplayText(I, Me.colCliente)

            Next

            rel.colTipoProduto.Visible = False
            .picLogo.Image = LogoTipo

            .ShowPreview()
        End With
    End Sub
    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        If Me.Tag = "CADASTRA" Then
            Me.GridControl1.ShowPrintPreview()
        Else
            Dim rel As New relComissaoDetail

            With rel
                Dim strCodFunc As String = Me.lueFuncionario.EditValue
                Dim strFuncionario As String = ""
                Dim dt As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFunc)
                If dt.Rows.Count > 0 Then
                    strFuncionario = dt.Rows.Item(0).Item("Nome").ToString
                End If
                .lblDataIni.Text = Me.dtInicial.EditValue
                .lblDataFim.Text = Me.dtFinal.EditValue
                .lblFunc.Text = strFuncionario
                '.lblComis.Text = txtComT.Text.Trim
                .lblCre.Text = Me.txtCred.Text.Trim
                .lblDeb.Text = Me.txtDeb.Text.Trim
                .lblSaldo.Text = Me.txtTotalGeral.Text.Trim
                '   .lblTot.Text = Me.txtTotGer.Text.Trim

                .lblTitulo2.Text = NomeEmpresa
                .lblSaldo2.Text = Me.txtTotalGeral.Text.Trim
                .lblFunc2.Text = strFuncionario
                .lblCom.Visible = False
                .lin1.Visible = False
                .colCodigoPedido.Visible = False
                .GridColumn1.Visible = False
                .GridColumn2.Visible = False
                .colTipo.Visible = False
                .colTipoProduto.Visible = False
                .colComissao.Visible = False
                .colPorcentagem.Visible = False
                .colFuncionario.Visible = False
                .colValorServico.Visible = False
                .lblTexto1.Visible = False
                rel.Grid1.Visible = False

                Dim I As Integer

                Dim J As Integer = 0
                For I = 0 To grd2.RowCount - 1

                    If Me.grd1.GetRowCellDisplayText(I, Me.colTipo) = "C" Then
                        .tbCred.Rows.Add()
                        .tbCred.Rows.Item(J).Item("Motivo") = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
                        .tbCred.Rows.Item(J).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                        .tbCred.Rows.Item(J).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                        J = J + 1
                    End If
                Next

                If Me.txtComissaoVend.Text.Trim <> "" And Me.txtComissaoVend.Text.Trim <> "0,00" Then
                    .tbCred.Rows.Add()
                    .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Motivo") = "TOTAL DE COMISSÃO"
                    .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Valor") = txtComissaoVend.Text.Trim
                    .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Data") = Date.Today
                End If

                Dim L As Integer
                For I = 0 To grd1.RowCount - 1
                    If Me.grd1.GetRowCellDisplayText(I, Me.colTipo) = "D" Then
                        .tbDeb.Rows.Add()
                        .tbDeb.Rows.Item(L).Item("Motivo") = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
                        .tbDeb.Rows.Item(L).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                        .tbDeb.Rows.Item(L).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                        L = L + 1
                    End If
                Next

                J = 0
                For I = 0 To grd1.RowCount - 1

                    If Me.grd1.GetRowCellDisplayText(I, Me.colTipo) = "C" Then
                        .tbCred.Rows.Add()

                        .tbCred.Rows.Item(J).Item("Motivo") = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
                        .tbCred.Rows.Item(J).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                        .tbCred.Rows.Item(J).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)

                        J = J + 1
                    End If
                Next

                .picLogo.Image = LogoTipo
                .ShowPreview()
            End With
        End If

    End Sub
    Private Sub Calcular()

        Dim I As Integer
        Dim dblCred, dblDeb, dblTotCred, dblTotDeb, dblResul As Double

        For I = 0 To grd1.RowCount - 1

            With grd1

                Select Case .GetRowCellDisplayText(I, Me.colTipo)
                    Case "C"
                        dblCred = .GetRowCellDisplayText(I, Me.colValor)
                        dblTotCred += dblCred


                    Case "D"
                        dblDeb = .GetRowCellDisplayText(I, Me.colValor)
                        dblTotDeb += dblDeb
                End Select
            End With


        Next

        Dim dblValorTotal, dblComissaoFunc As Double

        For I = 0 To grd2.RowCount - 1

            With grd2

                dblValorTotal += .GetRowCellDisplayText(I, Me.colValor1)
                dblComissaoFunc += .GetRowCellDisplayText(I, Me.colComissaoFunc)



            End With


        Next

        Me.txtCred.Text = dblTotCred.ToString("###,###,##0.00")
        Me.txtDeb.Text = dblTotDeb.ToString("###,###,##0.00")

        dblResul = dblTotCred - dblTotDeb

        Me.txtSaldo.Text = dblResul.ToString("###,###,##0.00")

        Me.txtValorTotal.Text = dblValorTotal.ToString("###,###,##0.00")
        Me.txtComissaoVend.Text = dblComissaoFunc.ToString("###,###,##0.00")
        dblResul = dblResul + dblComissaoFunc
        Me.txtTotalGeral.Text = dblResul.ToString("###,###,##0.00")
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub Organizacao()
        If Me.Tag = "CADASTRA" Then

            Me.lblValorTotal.Visible = False
            Me.lblTotalComissao.Visible = False
            Me.txtComissaoVend.Visible = False
            Me.txtValorTotal.Visible = False

            Me.txtSaldo.Location = New System.Drawing.Point(811, 504)
            Me.lblTotalSaldo.Location = New System.Drawing.Point(756, 508)
            Me.txtDeb.Location = New System.Drawing.Point(548, 504)
            Me.lblDebito.Location = New System.Drawing.Point(455, 508)
            Me.txtCred.Location = New System.Drawing.Point(279, 504)
            Me.lblCredito.Location = New System.Drawing.Point(182, 508)
            Me.btnCalc.Location = New System.Drawing.Point(66, 501)

            Me.GroupControl3.Visible = False
            Me.lueFuncionario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.GroupControl1.AppearanceCaption.Font = New Font("Tahoma", 18, FontStyle.Bold)
            Me.btnRelCust.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.btnRelCust.Caption = "Relatório &Totais"
            Me.GroupControl1.Dock = DockStyle.Fill
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Calcular()

    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd2, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub btnRelCustomizado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCustomizado.ItemClick
        If Me.Tag = "CADASTRA" Then
            Me.GridControl1.ShowPrintPreview()
        Else
            Me.GridControl2.ShowPrintPreview()
        End If

    End Sub
End Class