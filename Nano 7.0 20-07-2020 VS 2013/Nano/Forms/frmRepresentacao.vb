Imports Nano.clsFuncoes
Public Class frmRepresentacao
    Dim strFiltro As String
    Dim intCodigoCliente As Integer
    Dim intCodigoFuncionario As Integer

    Private Sub frmRepresentacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)

        
        AtualizarGrid(Date.Today, Date.Today)
        Me.dtData.EditValue = Date.Today

        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colCodPed
        grd1.ShowEditor()
    End Sub
    Private Sub Limpar()
        Me.txtCodPed.ResetText()
        Me.txtCli.ResetText()
        Me.lueFunc.EditValue = DBNull.Value
        CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)

        Me.dtData.EditValue = Date.Today
        Me.txtValor.ResetText()
        Me.txtPorcentagem.ResetText()
        Me.txtValorComissao.ResetText()
        Me.txtCodPed.Focus()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Validar(Me.txtCodPed) = False Then Exit Sub
        If Validar(Me.txtCli) = False Then Exit Sub
        If Validar(Me.lueFunc) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        If Validar(Me.txtPorcentagem) = False Then Exit Sub
        If Validar(Me.dtData) = False Then Exit Sub
        intCodigoFuncionario = Me.lueFunc.EditValue

        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Representacao where CodPed = " & Me.txtCodPed.Text & " and CodFunc = " & intCodigoFuncionario & " and CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then
            MsgBox("Cód. Ped. já cadastrado para este vendedor!", MsgBoxStyle.Information)
            Me.txtCodPed.ResetText()
            Me.txtCodPed.Focus()
            Exit Sub
        End If

        Try
            Inserir("INSERT INTO Representacao (CodPed, CodCli, CodFunc, Valor, Porcentagem, ComissaoFunc, " & _
            "ComissaoEsc, Data, CodConfig) VALUES (" & Me.txtCodPed.Text & "," & intCodigoCliente & "," & _
            "" & intCodigoFuncionario & "," & Num(Me.txtValor.Text) & "," & Num(Me.txtPorcentagem.Text) & "," & _
            "" & Num(Me.txtValorComissao.Text) & "," & Num(Me.txtValorComissao.Text) & ",'" & Me.dtData.Text & "'," & CodConfig & ")")
            MsgBox("Comissões cadastradas com sucesso!", MsgBoxStyle.Information)

        Catch ex As Exception

        End Try
        Limpar()
        AtualizarGrid(Date.Today, Date.Today)

    End Sub
    Private Sub CalcularComissao()
        If Me.txtValor.Text = "" Then Exit Sub
        If Me.txtPorcentagem.Text = "" Then Exit Sub
        Dim dblValor As Double = Me.txtValor.Text
        Dim dblPorc As Double = Me.txtPorcentagem.Text

        Dim dblResul As Double = (dblValor / 100) * dblPorc

        Me.txtValorComissao.Text = dblResul.ToString("0.00")
    End Sub
    Private Sub AtualizarGrid(ByVal parInicial As Date, ByVal parFinal As Date)
        If Master = False Then
            strFiltro = " and Representacao.CodConfig =" & CodConfig
        End If
        Dim strData As String = String.Format("Representacao.Data >= '{0:dd/MM/yyyy}' AND Representacao.Data <= '{1:dd/MM/yyyy}'", parInicial, parFinal) & strFiltro
        CarregarDados("SELECT Representacao.Codigo, CodPed, CodCli, CodFunc, Valor, Porcentagem, ComissaoFunc, ComissaoEsc, " & _
        "Representacao.Data, Cliente.Nome as Cliente, Funcionario.Nome as Funcionario FROM (Representacao left join Cliente " & _
        "on Representacao.CodCli = Cliente.Codigo) left join Funcionario on Representacao.CodFunc = Funcionario.Codigo " & _
        "where " & strData, Me.GridControl1)
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

        AtualizarGrid(dtInicial.EditValue, dtFinal.EditValue)

    End Sub

    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        Preco(Me.txtValor)
        CalcularComissao()
    End Sub

    Private Sub txtPorcentagem_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentagem.Leave
        Preco(Me.txtPorcentagem)
        CalcularComissao()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Dim strCodigo As String
        strCodigo = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
        Dim strMotivo As String = "Cód. Ped. " & grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodPed) & " Cliente " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCliente)

        If MsgBox("Deseja realmente excluir esta comissão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If SenhaEstaOK() = False Then Exit Sub

            Excluir("DELETE FROM Representacao where Codigo = " & strCodigo)

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strMotivo & "','EXCLUIDO','REPRESENTAÇÃO','REPRESENTAÇÃO','EXCLUSÃO'," & CodConfig & ")")
            MsgBox("Comissão excluida com sucesso!", MsgBoxStyle.Information)
            AtualizarGrid(Date.Today, Date.Today)
        End If
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relRepresentacao

        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        Dim I As Integer
        Dim A As Integer = 0
        With rel.tbRep.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colCliente) <> "" Then
                    .Add()
                    .Item(A).Item("CodPed") = Me.grd1.GetRowCellDisplayText(I, Me.colCodPed)
                    .Item(A).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                    .Item(A).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)
                    .Item(A).Item("Funcionario") = Me.grd1.GetRowCellDisplayText(I, Me.colFuncionario)
                    .Item(A).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    .Item(A).Item("Porcentagem") = Me.grd1.GetRowCellDisplayText(I, Me.colPorcentagem)
                    .Item(A).Item("ComissaoFunc") = Me.grd1.GetRowCellDisplayText(I, Me.colComissaoFunc)
                    .Item(A).Item("ComissaoEsc") = Me.grd1.GetRowCellDisplayText(I, Me.colComissaoEsc)
                    A += 1
                End If
            Next
        End With

        rel.lblValorTotal.Text = Me.txtValorTotal.Text
        rel.lblComissaoEsc.Text = Me.txtComissaoEsc.Text
        rel.lblComissaoVend.Text = Me.txtComissaoVend.Text

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Calcular()
    End Sub
    Private Sub Calcular()
        Dim I As Integer
        Dim dblValorTotal, dblComissaoFunc, dblComissaoEsc As Double

        For I = 0 To grd1.RowCount - 1

            With grd1

                dblValorTotal += .GetRowCellDisplayText(I, Me.colValor)
                dblComissaoFunc += .GetRowCellDisplayText(I, Me.colComissaoFunc)
                dblComissaoEsc += .GetRowCellDisplayText(I, Me.colComissaoEsc)


            End With


        Next

        Me.txtValorTotal.Text = dblValorTotal.ToString("###,###,##0.00")
        Me.txtComissaoVend.Text = dblComissaoFunc.ToString("###,###,##0.00")
        Me.txtComissaoEsc.Text = dblComissaoEsc.ToString("###,###,##0.00")

    End Sub

    Private Sub txtCli_ButtonClick1(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCli.ButtonClick
        CodigoDoCliente = Nothing
        intCodigoCliente = 0
        Dim frm As New frmCadCliente
        frm.Tag = "PESQUISA"
        frm.ShowDialog()
        frm.Tag = ""

        If CodigoDoCliente <> Nothing Then

            intCodigoCliente = CodigoDoCliente

            Dim dt As DataTable = CarregarDataTable("SELECT Nome FROM Cliente where Codigo = " & intCodigoCliente)
            If dt.Rows.Count > 0 Then
                Me.txtCli.Text = dt.Rows.Item(0).Item("Nome").ToString
            End If
        End If

        Me.lueFunc.Focus()
    End Sub
End Class