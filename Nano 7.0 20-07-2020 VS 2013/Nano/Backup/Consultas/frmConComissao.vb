Imports Nano.clsFuncoes
Public Class frmConComissao
    Dim dblTotalComissao As Double
    Dim I As Integer

    Private Sub frmConComissao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNano.Lancamentos' table. You can move, or remove it, as needed.
        If TesteConexao() = False Then Exit Sub
        Me.LancamentosTableAdapter.Fill(Me.DsNano.Lancamentos)

        If Me.Tag = "LANCAR" Then
            Me.dtFinal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.dtInicial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnVisualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnFiltrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.editCboFun.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.grpCom.Visible = False
            Me.grpCD.Dock = DockStyle.Fill

            CarregarDadosLue("Select * from Lancamentos", Me.cboMot)
            ' PreencherOrdenado("Funcionario", Me.cboFun, 1, "Nome", CodConfig)

        ElseIf Me.Tag = "CONSULTAR" Then
            ' PreencherOrdenado2("Funcionario", Me.cboFunc2, 1, "Nome", CodConfig)
            Me.grpGrid.Dock = DockStyle.Fill
            Me.grpCom.Dock = DockStyle.Fill
        End If



        If NomeEmpresa.Trim.ToUpper.Contains("CHARME REPRESENTAÇÕES") = False Then
            Me.grpCom.Visible = False
        End If
    End Sub

    Private Sub Calcular()

        dblTotalComissao = 0
        Dim dblLinhaCred, dblLinhaDeb, dblResulCred, dblResulDeb, dblTotal As Double
 
        With grd2
            For I = 0 To .RowCount - 1
                If .GetRowCellDisplayText(I, Me.colComissao2) <> "" Then

                    If .GetRowCellDisplayText(I, Me.colTipo2) = "C" Then
                        dblLinhaCred = .GetRowCellDisplayText(I, Me.colComissao2)
                        dblResulCred += dblLinhaCred

                    ElseIf .GetRowCellDisplayText(I, Me.colTipo2) = "D" Then
                        dblLinhaDeb = .GetRowCellDisplayText(I, Me.colComissao2)
                        dblResulDeb += dblLinhaDeb
                    End If
                End If
            Next

        End With


        Dim dblComP, dblComS, dblTotComP, dblTotComS, dblComTotal, dblLinha, dblTotGer As Double

        With grd1
          
            For I = 0 To .RowCount - 1

                If .GetRowCellDisplayText(I, Me.colTipoProduto) = "P" Then
                    dblComP = .GetRowCellDisplayText(I, Me.colComissao)
                    dblTotComP += dblComP
                End If

                If .GetRowCellDisplayText(I, Me.colTipoProduto) = "S" Then
                    dblComS = .GetRowCellDisplayText(I, Me.colComissao)
                    dblTotComS += dblComS
                End If

                dblLinha = .GetRowCellDisplayText(I, Me.colValorServico)
                dblTotGer += dblLinha

            Next
        End With

        dblComTotal = dblTotComP + dblTotComS
        dblResulCred += dblComTotal
       
        dblTotal = dblResulCred - dblResulDeb

        Me.txtComP.Text = dblTotComP.ToString("###,###,##0.00")
        Me.txtComS.Text = dblTotComS.ToString("###,###,##0.00")
        Me.txtComT.Text = dblComTotal.ToString("###,###,##0.00")
        Me.txtCred.Text = dblResulCred.ToString("###,###,##0.00")
        Me.txtDeb.Text = dblResulDeb.ToString("###,###,##0.00")
        Me.txtTot.Text = dblTotal.ToString("###,###,##0.00")
        Me.txtTotGer.Text = dblTotGer.ToString("###,###,##0.00")

    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        If TesteConexao() = False Then Exit Sub
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        If Me.editCboFun.EditValue.ToString.Trim = "" Then MsgBox("Selecione o Funcionário!", MsgBoxStyle.Information) : Exit Sub
        Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & " and CodConfig = " & CodConfig

        CarregarDados("Select CodigoPedido, Data, Funcionario, Motivo, Convert(Numeric(15,2),sum(ValorServico)) as ValorServico, Porcentagem, Convert(Numeric(15,2),Sum(Comissao)) as Comissao, TipoProduto from Comissao where Funcionario ='" & Me.editCboFun.EditValue.ToString.Trim & "' and Tipo ='C' and " & strData & " and TipoProduto <> 'D' group by CodigoPedido, Data, Funcionario, Motivo, Porcentagem, TipoProduto order by data", Me.Grid1)

        CarregarDados("Select Codigo, CodigoPedido, Funcionario, Motivo, Convert(Numeric(15,2),ValorServico) as ValorServico, Porcentagem, Convert(Numeric(15,2),Comissao) as Comissao, Tipo, Data from Comissao where Funcionario ='" & Me.editCboFun.EditValue.ToString.Trim & "' and " & strData & " and TipoProduto = 'D'", Me.GridControl1)

        'Me.ComissaoBindingSource.Filter = "TipoProduto ='' and Funcionario = '" & editCboFun.EditValue.ToString.Trim & "' and " & String.Format("Data >= #{0:M/dd/yyyy}# AND Data <= #{1:M/dd/yyyy}#", dtInicial.EditValue, dtFinal.EditValue)
        'Me.ComissaoTableAdapter.Fill(Me.DsMecanica.Comissao)
        Calcular()

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relComissaoDetail

        With rel


            .lblDataIni.Text = Me.dtInicial.EditValue
            .lblDataFim.Text = Me.dtFinal.EditValue
            .lblFunc.Text = editCboFun.EditValue.ToString.Trim
            .lblComis.Text = txtComT.Text.Trim
            .lblCre.Text = Me.txtCred.Text.Trim
            .lblDeb.Text = Me.txtDeb.Text.Trim
            .lblSaldo.Text = Me.txtTot.Text.Trim
            '  .lblTot.Text = Me.txtTotGer.Text.Trim

            .lblTitulo2.Text = NomeEmpresa
            .lblSaldo2.Text = Me.txtTot.Text.Trim
            .lblFunc2.Text = editCboFun.EditValue.ToString.Trim


            Dim I As Integer

            Dim J As Integer = 0
            For I = 0 To grd2.RowCount - 1

                If Me.grd2.GetRowCellDisplayText(I, Me.colTipo) = "C" Then
                    .tbCred.Rows.Add()
                    Dim strCarro As String = ""
                    If Me.grd2.GetRowCellDisplayText(I, Me.colCodigoPedido2) <> "" Then
                        Dim dtPed As DataTable = CarregarDataTable("SELECT Carro.Modelo, Carro.Cor FROM Total left join Carro on Total.Placa = Carro.Placa where Cod = '" & Me.grd2.GetRowCellDisplayText(I, Me.colCodigoPedido2) & "' and Total.CodConfig = " & CodConfig)

                        If dtPed.Rows.Count > 0 Then
                            strCarro = " " & dtPed.Rows.Item(0).Item("Modelo").ToString & " " & dtPed.Rows.Item(0).Item("Cor").ToString
                        End If
                    End If
                    .tbCred.Rows.Item(J).Item("Motivo") = Me.grd2.GetRowCellDisplayText(I, Me.colMotivo) & strCarro
                    .tbCred.Rows.Item(J).Item("Valor") = Me.grd2.GetRowCellDisplayText(I, Me.colComissao)
                    .tbCred.Rows.Item(J).Item("Data") = Me.grd2.GetRowCellDisplayText(I, Me.colData)

                    J = J + 1
                End If
            Next

            Dim L As Integer
            For I = 0 To grd2.RowCount - 1
                If Me.grd2.GetRowCellDisplayText(I, Me.colTipo) = "D" Then
                    .tbDeb.Rows.Add()
                    Dim strCarro As String = ""
                    If Me.grd2.GetRowCellDisplayText(I, Me.colCodigoPedido2) <> "" Then
                        Dim dtPed As DataTable = CarregarDataTable("SELECT Carro.Modelo, Carro.Cor FROM Total left join Carro on Total.Placa = Carro.Placa where Cod = '" & Me.grd2.GetRowCellDisplayText(I, Me.colCodigoPedido2) & "' and Total.CodConfig = " & CodConfig)

                        If dtPed.Rows.Count > 0 Then
                            strCarro = " " & dtPed.Rows.Item(0).Item("Modelo").ToString & " " & dtPed.Rows.Item(0).Item("Cor").ToString
                        End If
                    End If
                    .tbDeb.Rows.Item(L).Item("Motivo") = Me.grd2.GetRowCellDisplayText(I, Me.colMotivo) & strCarro
                    .tbDeb.Rows.Item(L).Item("Valor") = Me.grd2.GetRowCellDisplayText(I, Me.colComissao)
                    .tbDeb.Rows.Item(L).Item("Data") = Me.grd2.GetRowCellDisplayText(I, Me.colData)
                    L = L + 1
                End If
            Next

            For I = 0 To grd1.RowCount - 1
                .dtCom.Rows.Add()
                .dtCom.Rows.Item(I).Item("CodigoPedido") = grd1.GetRowCellDisplayText(I, Me.colCodigoPedido)
                .dtCom.Rows.Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .dtCom.Rows.Item(I).Item("Funcionario") = grd1.GetRowCellDisplayText(I, Me.colFuncionario)
                .dtCom.Rows.Item(I).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                .dtCom.Rows.Item(I).Item("ValorServico") = grd1.GetRowCellDisplayText(I, Me.colValorServico)
                .dtCom.Rows.Item(I).Item("Porcentagem") = grd1.GetRowCellDisplayText(I, Me.colPorcentagem)
                .dtCom.Rows.Item(I).Item("Comissao") = grd1.GetRowCellDisplayText(I, Me.colComissao)
                .dtCom.Rows.Item(I).Item("TipoProduto") = grd1.GetRowCellDisplayText(I, Me.colTipoProduto)
            Next

            .picLogo.Image = LogoTipo

            .ShowPreview()
        End With

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        If TesteConexao() = False Then Exit Sub
        If Validar(Me.cboFun) = False Then Exit Sub
        If Validar(Me.cboMot) = False Then Exit Sub
        If Validar(Me.dtDate) = False Then Exit Sub
        If Validar(Me.txtVal) = False Then Exit Sub
        If Me.cboMot.GetColumnValue("Tipo").ToString = "" Then
            MsgBox("Informe se o lançamento é crédito ou débito!", MsgBoxStyle.Information)
            Exit Sub
        End If

        With Me.DsNano.Comissao.Rows
            .Add()
            .Item(.Count - 1).Item("CodigoPedido") = 0
            .Item(.Count - 1).Item("Funcionario") = Me.cboFun.Text.Trim
            .Item(.Count - 1).Item("ValorServico") = "0,00"
            .Item(.Count - 1).Item("Porcentagem") = 0
            .Item(.Count - 1).Item("Comissao") = Me.txtVal.Text.Trim
            .Item(.Count - 1).Item("Data") = Me.dtDate.Text.Trim
            .Item(.Count - 1).Item("Motivo") = Me.cboMot.Text.Trim
            .Item(.Count - 1).Item("TipoProduto") = "D"
            .Item(.Count - 1).Item("Tipo") = Me.cboMot.GetColumnValue("Tipo").ToString
            .Item(.Count - 1).Item("CodConfig") = CodConfig
            Me.Validate()
            Me.ComissaoBindingSource.EndEdit()
            Me.ComissaoTableAdapter.Update(Me.DsNano.Comissao)

        End With

        Select Case Me.cboMot.GetColumnValue("Tipo").ToString
            Case "C"
                MsgBox("Crédito lançado com sucesso!", MsgBoxStyle.Information)
            Case "D"
                MsgBox("Débito lançado com sucesso!", MsgBoxStyle.Information)
        End Select

        Me.cboFun.SelectedIndex = -1
        Me.dtDate.ResetText()
        Me.txtVal.ResetText()
        Me.cboFun.Focus()

        Calcular()

    End Sub

    Private Sub txtVal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVal.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVal.Leave
        Preco(txtVal)
    End Sub

    Private Sub btnTotais_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTotais.ItemClick
        Dim rel As New relComissaoDetail

        With rel

            .lblDataIni.Text = Me.dtInicial.EditValue
            .lblDataFim.Text = Me.dtFinal.EditValue
            .lblFunc.Text = editCboFun.EditValue.ToString.Trim
            '.lblComis.Text = txtComT.Text.Trim
            .lblCre.Text = Me.txtCred.Text.Trim
            .lblDeb.Text = Me.txtDeb.Text.Trim
            .lblSaldo.Text = Me.txtTot.Text.Trim
            '   .lblTot.Text = Me.txtTotGer.Text.Trim

            .lblTitulo2.Text = NomeEmpresa
            .lblSaldo2.Text = Me.txtTot.Text.Trim
            .lblFunc2.Text = editCboFun.EditValue.ToString.Trim
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

                If Me.grd2.GetRowCellDisplayText(I, Me.colTipo) = "C" Then
                    .tbCred.Rows.Add()
                    .tbCred.Rows.Item(J).Item("Motivo") = Me.grd2.GetRowCellDisplayText(I, Me.colMotivo)
                    .tbCred.Rows.Item(J).Item("Valor") = Me.grd2.GetRowCellDisplayText(I, Me.colComissao)
                    .tbCred.Rows.Item(J).Item("Data") = Me.grd2.GetRowCellDisplayText(I, Me.colData)
                    J = J + 1
                End If
            Next

            If Me.txtComT.Text.Trim <> "" And Me.txtComT.Text.Trim <> "0,00" Then
                .tbCred.Rows.Add()
                .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Motivo") = "TOTAL DE COMISSÃO"
                .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Valor") = txtComT.Text.Trim
                .tbCred.Rows.Item(.tbCred.Rows.Count - 1).Item("Data") = Date.Today
            End If

            Dim L As Integer
            For I = 0 To grd2.RowCount - 1
                If Me.grd2.GetRowCellDisplayText(I, Me.colTipo) = "D" Then
                    .tbDeb.Rows.Add()
                    .tbDeb.Rows.Item(L).Item("Motivo") = Me.grd2.GetRowCellDisplayText(I, Me.colMotivo)
                    .tbDeb.Rows.Item(L).Item("Valor") = Me.grd2.GetRowCellDisplayText(I, Me.colComissao)
                    .tbDeb.Rows.Item(L).Item("Data") = Me.grd2.GetRowCellDisplayText(I, Me.colData)
                    L = L + 1
                End If
            Next

            .picLogo.Image = LogoTipo
            .ShowPreview()
        End With
    End Sub

    Private Sub btnDelCredDeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelCredDeb.Click
        If TesteConexao() = False Then Exit Sub
        If grd2.FocusedRowHandle < 0 Then Exit Sub
        If grd2.RowCount = 0 Then Exit Sub

        If MsgBox("Deseja realmente excluir o item " & grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colMotivo2) & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If Excluir("Delete from Comissao where Codigo =" & grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colCodigo2) & " and CodConfig = " & CodConfig) = True Then
                grd2.DeleteRow(grd2.FocusedRowHandle)
                MsgBox("Exclusão concluída com sucesso!", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub
End Class