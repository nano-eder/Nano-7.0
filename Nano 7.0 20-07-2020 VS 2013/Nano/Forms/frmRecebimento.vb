Imports Nano.clsFuncoes
Public Class frmRecebimento
    Dim strTroco As String
    Public intCodCliente As String
    Public strCodPed As String
    Dim bolEntrada As Boolean
    Public bolParcSalvo As Boolean

    Dim strQuery As String
    Private Sub frmRecebimento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpar()
    End Sub

    Private Sub frmRecebimento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            If strQuery <> "" Then
                If Me.txtTroco.Text <> "" Then
                    Dim dblTroco As Double = Me.txtTroco.Text
                    If dblTroco > 0 Then
                        Dim strMot As String = "TROCO DO PEDIDO Nº " & strCodPed & " - " & NomeDoCliente

                        strQuery &= "INSERT INTO Caixa (Motivo, Caixa, Credito, Pagamento, Valor, Data, " & _
                        "CodConfig) VALUES('" & strMot & "','" & UserNano & "','" & "D" & "','" & "DINHEIRO" & "'," & _
                        "" & Num(dblTroco) & ",'" & Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ")" & vbCrLf

                    End If
                End If

                Atualizar(strQuery)
            End If

            Me.Close()
        End If
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoAutomotivo.chm", HelpNavigator.TopicId, "66")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

    End Sub

    Private Sub frmRecebimento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNanoCommerce.Pagamento' table. You can move, or remove it, as needed.
        Me.PagamentoTableAdapter.Fill(Me.DsNanoCommerce.Pagamento)

        strQuery = ""
        Me.dtData.Text = Date.Today

        If Me.Tag = "CONSULTA" Then
            Bloquear(True)
        Else
            Bloquear(False)
        End If

        Carregar()

        Timer1.Start()
    End Sub
    Private Sub Carregar()

        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, CodigoPedido, FormaPagamento, Pagamento, Documento, Convert(Numeric(15,2),Valor) as Valor, Data, Obs FROM Recebimento where CodigoPedido = '" & strCodPed & "' and CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then
            Dim I As Integer
            Me.tbRec.Rows.Clear()
            For I = 0 To dt.Rows.Count - 1
                With Me.tbRec.Rows
                    .Add()
                    .Item(I).Item("FormaPagamento") = dt.Rows.Item(I).Item("Pagamento").ToString
                    .Item(I).Item("Pagamento") = dt.Rows.Item(I).Item("FormaPagamento").ToString
                    .Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
                    .Item(I).Item("Data") = dt.Rows.Item(I).Item("Data").ToString
                End With

            Next
        End If

    End Sub
    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "," And e.KeyChar <> "." And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        Preco(txtValor)
        If Me.cboPag.GetColumnValue("FormaPagamento") <> Nothing Then
            If Me.cboPag.GetColumnValue("FormaPagamento").ToString = "A PRAZO" Then
                If Me.cboPag.GetColumnValue("Prazo") = False Then
                    Me.btnPar.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub InserirCartao()
        Dim dblValor As Double = Me.txtValor.Text
        If Me.cboPag.Text.Trim = "DINHEIRO" Then
            Dim dblValRec As Double = Me.txtARec.Text
            If dblValor > dblValRec Then
                dblValor = dblValRec
            End If
        End If

     
        strQuery &= "Insert into Recebimento (CodOrdem, CodigoPedido, FormaPagamento, Pagamento, Valor, Data, " & _
         "CodConfig) Values(0,'" & strCodPed & "','" & Me.cboPag.GetColumnValue("FormaPagamento").ToString.Trim & "'," & _
         "'" & Me.cboPag.Text.Trim & "'," & Num(dblValor) & ",'" & Me.dtData.Text.Trim & "'," & CodConfig & ")" & vbCrLf

        If Me.cboPag.GetColumnValue("Prazo") = True Then
            If Validar(Me.txtVez) = False Then Exit Sub

            Dim I, intDias As Integer

            Dim dblTot, dblDes, dblTotDes, dblResul As Double

            dblTot = Me.txtValor.Text.Trim / Val(Me.txtVez.Text.Trim)
            dblDes = Me.cboPag.GetColumnValue("Desconto")

            dblTotDes = (dblTot / 100) * dblDes
            dblResul = dblTot - dblTotDes

            intDias = Me.cboPag.GetColumnValue("Dias")

            Dim dtData1 As Date = Me.dtData.Text.Trim

            For I = 0 To Val(Me.txtVez.Text.Trim) - 1
                dtData1 = dtData1.AddDays(intDias)


                strQuery &= "Insert into Futuro (CodOrdem, Data, Pagamento, Total, TotalDesconto, CodigoPedido, " & _
                "CodConfig, Recebido) Values(0,'" & dtData1 & "','" & Me.cboPag.Text.Trim & "'," & _
                "" & Num(dblTot) & "," & Num(dblResul) & ",'" & strCodPed & "'," & CodConfig & ",'False')" & vbCrLf

            Next
        End If





        With Me.tbRec.Rows
            .Add()
            .Item(.Count - 1).Item("FormaPagamento") = Me.cboPag.Text.Trim
            .Item(.Count - 1).Item("Pagamento") = Me.cboPag.GetColumnValue("FormaPagamento").ToString.Trim
            .Item(.Count - 1).Item("Valor") = Me.txtValor.Text.Trim
            .Item(.Count - 1).Item("Data") = Me.dtData.Text.Trim
        End With

        Calcular()
        Caixa()

    End Sub
    Private Sub Caixa()
        Dim dtPag As DataTable = CarregarDataTable("Select IrCaixa from Pagamento where Descricao ='" & Me.cboPag.Text & "'")

        Dim strMot As String = "ENTRADA RECEBIDA DO PEDIDO Nº " & strCodPed & " - " & NomeDoCliente
        If dtPag.Rows.Item(0).Item(0).ToString = "SIM" Then
            strQuery &= "INSERT INTO Caixa (Motivo, Caixa, Credito, Pagamento, Valor, Data, " & _
            "CodConfig) VALUES('" & strMot & "','" & UserNano & "','" & "C" & "','" & Me.cboPag.Text & "'," & _
            "" & Num(Me.txtValor.Text) & ",'" & Me.dtData.EditValue & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ")" & vbCrLf
        End If
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Validar(Me.cboPag) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        If Me.cboPag.GetColumnValue("FormaPagamento").ToString = "A PRAZO" Then
            If Me.cboPag.GetColumnValue("Prazo") = False Then
                If MsgBox("Deseja realmente inserir um pagamento a prazo como a vista?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If
        InserirCartao()
        If Me.cboPag.Text.Contains("CHEQUE") Then
            strQuery &= "INSERT INTO Cheque (CodPed, CodigoPedido, Cliente, Vencimento, Valor, Banco, Data, Quem, RecebidoOk, " & _
            "CodConfig) VALUES ('0','" & strCodPed & "','" & NomeDoCliente & "','" & Me.dtData.Text.Trim & "'," & _
            "" & Num(Me.txtValor.Text.Trim) & ",'" & "" & "','" & Date.Today & "','" & "" & "','False'," & CodConfig & ")" & vbCrLf

        End If
        Limpar()
    End Sub

    Private Sub Limpar()
        Me.txtVez.ResetText()
        Me.txtValor.ResetText()

        Me.cboPag.EditValue = DBNull.Value
        Me.cboPag.ClosePopup()
        Me.cboPag.Focus()

    End Sub

    Private Sub Bloquear(ByVal parConsulta As Boolean)
        If parConsulta = True Then
            Me.cboPag.Properties.ReadOnly = True
            Me.txtValor.Properties.ReadOnly = True

            Me.btnOk.Enabled = False
         

            Me.btnPar.Enabled = False
            Me.txtVez.Properties.ReadOnly = True

            Me.btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnFechar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.cboPag.Properties.ReadOnly = False
            Me.txtValor.Properties.ReadOnly = False

            Me.btnOk.Enabled = True
        
            Me.btnPar.Enabled = True
            Me.txtVez.Properties.ReadOnly = False

            Me.btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnFechar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

    End Sub
    Private Sub Calcular()

        If grd1.RowCount = 0 Then
            Me.txtARec.Text = Me.txtTotal.Text.Trim
            Me.txtRec.Text = "0,00"
            Me.txtTroco.Text = "0,00"
            Exit Sub
        End If


        Dim dblLinha, dblResul, dblTotal As Double
        Dim I As Integer

        dblTotal = Me.txtTotal.Text.Trim

        For I = 0 To grd1.RowCount - 1
            dblLinha = grd1.GetRowCellDisplayText(I, Me.colValor)
            dblResul += dblLinha
        Next

        Me.txtRec.Text = dblResul.ToString("0.00")

        strTroco = dblTotal - dblResul

        Dim dblTrco2 As Double = strTroco
        Dim dblTrco As Double = dblResul - dblTotal
        If dblTrco2 < 0 Then
            Me.txtARec.Text = "0,00"
        Else
            Me.txtARec.Text = dblTrco2.ToString("0.00")
        End If
        If dblTrco > 0 Then
            Me.txtTroco.Text = dblTrco.ToString("0.00")
        Else
            Me.txtTroco.Text = "0,00"
        End If


    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        If strQuery <> "" Then
            If Me.txtTroco.Text <> "" Then
                Dim dblTroco As Double = Me.txtTroco.Text
                If dblTroco > 0 Then
                    Dim strMot As String = "TROCO DO PEDIDO Nº " & strCodPed & " - " & NomeDoCliente

                    strQuery &= "INSERT INTO Caixa (Motivo, Caixa, Credito, Pagamento, Valor, Data, " & _
                    "CodConfig) VALUES('" & strMot & "','" & UserNano & "','" & "D" & "','" & "DINHEIRO" & "'," & _
                    "" & Num(dblTroco) & ",'" & Me.dtData.EditValue & "'," & CodConfig & ")" & vbCrLf

                End If
            End If

            Atualizar(strQuery)
        End If

        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Calcular()
        Timer1.Stop()
    End Sub

    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick

        If MsgBox("Deseja realmente excluir todas as forma de Pagamento '" & Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colPagamento) & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.tbRec.Rows.Clear()
            Timer1.Start()


            Excluir("Delete from Recebimento where CodigoPedido ='" & strCodPed & "' and CodConfig = " & CodConfig)
            Excluir("Delete from ContaReceber where CodigoPedido ='" & strCodPed & "' and CodConfig = " & CodConfig)
            Excluir("Delete from Caixa where Motivo LIKE '%PEDIDO Nº " & strCodPed & "%' and CodConfig = " & CodConfig)
            Excluir("Delete from Cheque where CodigoPedido ='" & strCodPed & "' and CodConfig = " & CodConfig)
            Excluir("Delete from Futuro where CodigoPedido ='" & strCodPed & "' and CodConfig = " & CodConfig)

        End If
    End Sub

    Private Sub txtVez_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVez.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboPag_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPag.Leave
        Me.txtValor.Text = Me.txtARec.Text.Trim
    End Sub

    Private Sub cboPag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPag.TextChanged

        If Me.cboPag.GetColumnValue("FormaPagamento") = "A VISTA" Then
            Me.txtVez.Text = 1
            Me.txtVez.Enabled = False
            Me.btnPar.Enabled = False
        Else
            Me.txtVez.Enabled = True
            Me.txtVez.ResetText()
            Me.btnPar.Enabled = True
        End If

        If Me.cboPag.GetColumnValue("Prazo") = True Then
            Me.btnPar.Enabled = False
        ElseIf Me.cboPag.GetColumnValue("Prazo") = False And Me.cboPag.GetColumnValue("FormaPagamento") = "A VISTA" Then
            Me.btnPar.Enabled = False
        Else
            Me.btnPar.Enabled = True
        End If
      
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.tbRec.Rows.Clear()
        strQuery = ""
        Calcular()
        Me.Close()
    End Sub

    Private Sub btnPar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPar.Click
        If Validar(Me.cboPag) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        If Validar(Me.txtVez) = False Then Exit Sub


        If Me.cboPag.GetColumnValue("Prazo") = True Then
            InserirCartao()
        Else

            If Validar(Me.txtVez) = False Then Exit Sub

        End If

        Dim I As Integer

        Dim strPedido As String

        strPedido = strCodPed

        Dim dblTot As Double

        dblTot = Me.txtValor.Text.Trim / Val(Me.txtVez.Text.Trim)

        If Me.cboPag.GetColumnValue("Prazo") = False Then

            Dim frm As New frmCrediario3
            frm.Tag = "PEDIDO"
            frm.intOrdem = strCodPed
            frm.txtDias.Text = "30"
            frm.intCodCliente = intCodCliente
            frm.dblValorCrediario = Me.txtValor.Text.Trim
            frm.strPagamento = Me.cboPag.Text.Trim
            frm.txtValCred.Text = Me.txtValor.Text.Trim
            frm.dtVen.Text = Date.Today.AddMonths(1)
            frm.seParcela.Text = Me.txtVez.Text.Trim
            frm.strCliente = NomeDoCliente
            frm.strDataVenda = dtData.EditValue
            frm.dblValorTotal = Me.txtTotal.Text
            SalvarCrediario = False
            frm.ShowDialog()

            If SalvarCrediario = False Then Exit Sub
            SalvarCrediario = False
            strQuery &= "Insert into Recebimento (CodOrdem, CodigoPedido, FormaPagamento, Pagamento, Valor, Data, " & _
            "CodConfig) Values(0,'" & strCodPed & "','" & Me.cboPag.GetColumnValue("FormaPagamento").ToString.Trim & "'," & _
            "'" & Me.cboPag.Text.Trim & "'," & Num(Me.txtValor.Text.Trim) & ",'" & Me.dtData.Text.Trim & "'," & _
            "" & CodConfig & ")" & vbCrLf

            Caixa()

        End If

        With Me.tbRec.Rows
            .Add()
            .Item(.Count - 1).Item("FormaPagamento") = Me.cboPag.Text.Trim
            .Item(.Count - 1).Item("Pagamento") = Me.cboPag.GetColumnValue("FormaPagamento").ToString.Trim
            .Item(.Count - 1).Item("Valor") = Me.txtValor.Text.Trim
            .Item(.Count - 1).Item("Data") = Me.dtData.Text.Trim

        End With

        Calcular()
        Limpar()
    End Sub
End Class