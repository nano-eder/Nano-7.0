Imports Nano.clsFuncoes
Public Class frmCheque
    Dim bolAlterar As Boolean = False
    Dim intCodigo As Integer
    Dim intIndex As Integer
    Dim intCodConfig As Integer
    Dim strFiltro As String = ""
    Private Sub AtualizarGrid()
        If Me.Tag = "RECEBIDOOK" Then
            CarregarDados("SELECT Codigo, CodPed, Cliente, Convert(NUMERIC(15,2),Valor) as Valor, Vencimento, Data, Documento, Banco, Quem, RecebidoOk as Recebido, Recebimento, CodConfig, Observacao FROM Cheque where RecebidoOk = 'True'" & strFiltro, Me.GridControl1)
        Else
            CarregarDados("SELECT Codigo, CodPed, Cliente, Convert(NUMERIC(15,2),Valor) as Valor, Vencimento, Data, Documento, Banco, Quem, RecebidoOk as Recebido, Recebimento, CodConfig, Observacao FROM Cheque where RecebidoOk = 'False'" & strFiltro, Me.GridControl1)
        End If
    End Sub
    Private Sub Limpar()
        intCodigo = Nothing
        Me.txtCliente.ResetText()
        Me.txtNumDoc.ResetText()
        Me.txtQuem.ResetText()
        Me.txtValor.ResetText()
        Me.dtVenc.ResetText()
        Me.cboBanco.ResetText()
        Me.txtPedido.ResetText()
        Me.txtPedido.Focus()
        Me.chkAlterar.Checked = False
        Me.chkAlterar.Visible = False
        Me.txtObservacao.ResetText()
        bolAlterar = False
    End Sub
    Private Sub Alterar()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        bolAlterar = True
        Me.chkAlterar.Visible = True
        intCodConfig = Me.grd1.GetRowCellValue(intIndex, Me.colCodConfig)
        intCodigo = Me.grd1.GetRowCellValue(intIndex, Me.colCodigo)
        Me.txtCliente.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCliente)
        Me.txtNumDoc.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colDocumento)
        Me.txtQuem.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colQuem)
        Me.txtValor.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colValor)
        Me.dtVenc.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colVencimento)
        Me.cboBanco.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colBanco)
        Me.txtPedido.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodPed)
        Me.txtObservacao.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colObservacao)
        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodPed) <> "" Then
            Me.chkAlterar.Checked = True
        Else
            Me.chkAlterar.Checked = False
        End If
        If Me.grd1.GetRowCellValue(intIndex, Me.colRecebido) = True Then
            Me.rdgFim.SelectedIndex = 1
        Else
            Me.rdgFim.SelectedIndex = 0
        End If

    End Sub

    Private Sub frmCheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "92")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmCheque_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        If TesteConexao() = False Then Exit Sub

        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
        End If
        Me.colCodConfig.Visible = Master
        AtualizarGrid()
        Me.dtVenc.Text = Date.Today
        PreencherOrdenado("Banco", Me.cboBanco, 1, "Nome")
        Dim index As Integer = -999997
        If Me.Tag = "RECEBIDOOK" Then
            Me.GroupControl1.Dock = DockStyle.Fill
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnAlterar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.grd1.FormatConditions.Item(0).Value1 = Date.Today
            Me.grd1.FormatConditions.Item(1).Value1 = Date.Today
        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub
        If Validar(Me.txtCliente) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        If Validar(Me.dtVenc) = False Then Exit Sub
        Dim bolRec As Boolean

        If Me.rdgFim.SelectedIndex = 0 Then
            bolRec = False
        Else
            bolRec = True
        End If
        If bolAlterar = False Then
            Inserir("INSERT INTO Cheque (CodPed, Cliente, Vencimento, Valor, Documento, Banco, Data, Quem, RecebidoOk, CodConfig, Observacao) VALUES ('" & Me.txtPedido.Text.Trim & "','" & Me.txtCliente.Text.Trim & "','" & Me.dtVenc.Text.Trim & "'," & Num(Me.txtValor.Text.Trim) & ",'" & Me.txtNumDoc.Text.Trim & "','" & Me.cboBanco.Text.Trim & "','" & Date.Today & "','" & Me.txtQuem.Text.Trim & "','" & bolRec & "'," & CodConfig & ",'" & Me.txtObservacao.Text.Replace("'", "") & "')")
            MsgBox("Cheque cadastrado com sucesso!", MsgBoxStyle.Information)
        Else

            Atualizar("UPDATE Cheque SET CodPed = '" & Me.txtPedido.Text.Trim & "', Cliente = '" & Me.txtCliente.Text.Trim & "', Vencimento = '" & Me.dtVenc.Text.Trim & "', Valor = " & Num(Me.txtValor.Text.Trim) & ", Documento = '" & Me.txtNumDoc.Text.Trim & "', Banco = '" & Me.cboBanco.Text.Trim & "', Quem = '" & Me.txtQuem.Text.Trim & "', RecebidoOk = '" & bolRec & "', Recebimento = '" & Date.Today & "', Observacao = '" & Me.txtObservacao.Text.Replace("'", "") & "' where Codigo = " & intCodigo & " and CodConfig = " & intCodConfig)
            MsgBox("Cheque alterado com sucesso!", MsgBoxStyle.Information)
        End If
        Limpar()
        AtualizarGrid()
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        intIndex = Me.grd1.FocusedRowHandle
        Alterar()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
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

        Dim strData As String

        If Me.Tag = "RECEBIDOOK" Then
            strData = String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro
        Else
            strData = String.Format("Recebimento >= '{0:dd/MM/yyyy}' AND Recebimento <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro
        End If
        CarregarDados("SELECT Codigo, CodPed, Cliente, Convert(NUMERIC(15,2),Valor) as Valor, Vencimento, Data, Documento, Banco, Quem, RecebidoOk as Recebido, Recebimento, CodConfig, Observacao FROM Cheque where " & strData, Me.GridControl1)
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        intIndex = Me.grd1.FocusedRowHandle
        Alterar()
    End Sub

    Private Sub txtCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCliente.ButtonClick
        AbreCliente()
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F10 Then
            AbreCliente()
        End If
    End Sub
    Private Sub AbreCliente()
        frmCadCliente.Tag = "PESQUISA"
        NomeDoCliente = ""
        CodigoDoCliente = Nothing
        frmCadCliente.ShowDialog()
        frmCadCliente.Tag = ""
        If CodigoDoCliente > 0 Then
            Dim dt As DataTable = CarregarDataTable("SELECT Nome FROM Cliente where Codigo = " & CodigoDoCliente)
            If dt.Rows.Count > 0 Then
                Me.txtCliente.Text = dt.Rows.Item(0).Item("Nome").ToString
            End If

            Me.txtQuem.Focus()
        End If
    End Sub

    Private Sub btnCadBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBanco.Click
        frmCadBanco.ShowDialog()
        Me.cboBanco.Properties.Items.Clear()
        PreencherOrdenado("Banco", Me.cboBanco, 1, "Nome")
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        Preco(Me.txtValor)
    End Sub

    Private Sub chkAlterar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlterar.CheckedChanged
        If chkAlterar.Checked = True Then
            Me.txtPedido.Enabled = False
        Else
            Me.txtPedido.Enabled = True
            Me.txtPedido.Focus()
        End If
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If TesteConexao() = False Then Exit Sub
        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle
        If Index < 0 Then Exit Sub

        Dim strCPF As String = grd1.GetRowCellDisplayText(Index, Me.colCodigo)
        Dim strCliente As String = grd1.GetRowCellDisplayText(Index, Me.colDocumento)
        If MsgBox("Deseja realmente excluir este cheque?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Excluir("DELETE FROM Cheque where Codigo = " & strCPF & " and CodConfig = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig))
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strCliente & "','EXCLUÍDO','CHEQUE','CHEQUE','EXCLUSÃO'," & CodConfig & ")")
            AtualizarGrid()
            Limpar()
        End If
    End Sub

    Private Sub txtPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPedido.KeyPress, txtQuem.Properties.KeyPress, txtNumDoc.Properties.KeyPress, txtCliente.Properties.KeyPress
        If e.KeyChar <> vbBack And e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relCheque

        Dim I As Integer

        rel.lblTitulo.Text = "Relatório de Cheques"
        rel.picLogo.Image = LogoTipo
        Dim A As Integer = 0

        With rel.tbCheque.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colCodPed) <> "" Then
                    .Add()
                    .Item(A).Item("CodPed") = Me.grd1.GetRowCellDisplayText(I, Me.colCodPed)
                    .Item(A).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)
                    .Item(A).Item("Vencimento") = Me.grd1.GetRowCellDisplayText(I, Me.colVencimento)
                    .Item(A).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    .Item(A).Item("Documento") = Me.grd1.GetRowCellDisplayText(I, Me.colDocumento)
                    .Item(A).Item("Banco") = Me.grd1.GetRowCellDisplayText(I, Me.colBanco)
                    .Item(A).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                    .Item(A).Item("Quem") = Me.grd1.GetRowCellDisplayText(I, Me.colQuem)
                    .Item(A).Item("Recebido") = Me.grd1.GetRowCellDisplayText(I, Me.colRecebido)
                    .Item(A).Item("Recebimento") = Me.grd1.GetRowCellDisplayText(I, Me.colRecebimento)
                    A += 1
                End If
          


            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class