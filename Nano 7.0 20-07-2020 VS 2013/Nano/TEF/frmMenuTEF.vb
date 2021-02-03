Imports Nano.clsFuncoes
Public Class frmMenuTEF

    Private Sub frmMenuTEF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frmTEF.Conectar(IP, CaixaTEF)
        Limpar()
        If Login = "ADM" And Senha = "SPFC" Then
            Me.btnConfig.Enabled = True
            Me.btnInstalacao.Enabled = True
        End If
        
        
    End Sub
    Private Sub CarregarTEF()

        CarregarDados("Select Futuro.CodOrdem, Futuro.Pagamento, Pagamento.FormaPagamento, Bandeira, NumTransacao as NSU, Cliente.Nome as Cliente, " & _
        "Total.Data, sum(Futuro.Total) as ValorTotal, Cliente.CPF, Futuro.CodConfig from ((Futuro left join Pagamento on Futuro.Pagamento = Pagamento.Descricao) left join Total " & _
        "on Futuro.codordem = total.codordem and Futuro.codconfig = total.codconfig) Left join Cliente on " & _
        "Total.CodCli = Cliente.Codigo where Futuro.Status = 'OK' and Futuro.CodConfig =" & CodConfig & " group by " & _
        "Futuro.CodOrdem, Bandeira, NumTransacao, Cliente.Nome, Total.Data, Cliente.CPF, Futuro.CodConfig, Futuro.Pagamento, Pagamento.FormaPagamento order by Futuro.CodOrdem desc", Me.GridControl1)

    End Sub
    Private Sub Limpar()
        Me.btnTeste.Checked = False
        Me.btnImprimir.Checked = False
        Me.btnCancelar.Checked = False
        Me.XtraTabControl1.SelectedTabPageIndex = 0
        Me.picFundo.Focus()
    End Sub
    Private Sub btnImprimir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.CheckedChanged

        Select Case Me.btnImprimir.Checked
            Case True
                Me.XtraTabControl1.SelectedTabPageIndex = 2
                Me.btnTeste.Checked = False
                Me.btnCancelar.Checked = False
                Me.btnImprimir.Checked = True
                CarregarTEF()

                Me.btnImprimirTEF.Visible = True
                Me.btnCancelarTEF.Visible = False
            Case False
                Limpar()

        End Select
    End Sub
    Private Sub btnTeste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeste.CheckedChanged

        Select Case Me.btnTeste.Checked
            Case True
                Me.XtraTabControl1.SelectedTabPageIndex = 1
                Me.btnImprimir.Checked = False
                Me.btnCancelar.Checked = False
                Me.btnTeste.Checked = True
            Case False
                Limpar()

        End Select
    End Sub

    Private Sub btnCancelar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.CheckedChanged

        Select Case Me.btnCancelar.Checked
            Case True
                Me.XtraTabControl1.SelectedTabPageIndex = 2
                Me.btnImprimir.Checked = False
                Me.btnTeste.Checked = False
                Me.btnCancelar.Checked = True
                CarregarTEF()

                Me.btnImprimirTEF.Visible = False
                Me.btnCancelarTEF.Visible = True
            Case False
                Limpar()

        End Select
    End Sub
    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        Limpar()
        frmConfigTEF.ShowDialog()

    End Sub

    Private Sub btnInstalacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstalacao.Click

    End Sub

    Private Sub btnCancelarTEF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTEF.Click
        If Me.grd1.FocusedRowHandle < 0 Then
            MsgBox("Selecione uma venda!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)
        Dim strNSU As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNSU)

        Dim intCodTEF As Integer = GerarCodigoOrdens("TEF", CodConfig)
        Inserir("Insert into Ordens (Tabela, Cod, CodConfig) values('TEF'," & intCodTEF & "," & CodConfig & ")")

        Dim strValor As Double = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValorTotal)

        Dim strCredDeb As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colFormaPagamento)
        Dim strPagamento As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colPagamento)
        If strCredDeb = "A VISTA" Then
            If strPagamento.Contains("CRED") = True Or strPagamento.Contains("CRÉD") = True _
            Or strPagamento.Contains("PARC") = True Then
                frmTEF.intCreditoDebito = 2
            Else
                frmTEF.intCreditoDebito = 1
            End If

        Else
            frmTEF.intCreditoDebito = 2
        End If

        ComprovanteTEF(0) = ""
        ComprovanteTEF(1) = ""

        frmTEF.intCredDeb = 200
        RetornoTEF = -1
        frmTEF.strValor = strValor.ToString("0.00")
        frmTEF.Tag = ""

        frmTEF.strNumTransacao = strNSU
        frmTEF.cupomFiscal = intCodTEF
        frmTEF.ShowDialog()
        If RetornoTEF = 0 Then
            Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
            Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
            clsTEF.FinalizaTransacaoSiTefInterativo(1, intCodTEF, dataFiscal, horario)
            If RetornoTEF = 0 Then
                Atualizar("UPDATE Futuro set Status = 'Cancelado' where CodOrdem = " & strCodOrdem & " and NumTransacao = '" & strNSU & "'")
                Dim A As Integer
                For A = 0 To ComprovanteTEF.Length - 1
                    If Impressora.Contains("ESC/POS") = True Then
                        If ComprovanteTEF(A) <> "" Then
                            clsImprimir.ImprimeCupomTEF(ComprovanteTEF(A))
                        End If

                    End If
                    ComprovanteTEF(A) = ""
                Next

                CarregarTEF()
            End If
        End If
    End Sub


    Private Sub btnImprimirTEF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirTEF.Click
        If Me.grd1.FocusedRowHandle < 0 Then
            MsgBox("Selecione uma venda!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)
        Dim strNSU As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNSU)

        Dim intCodTEF As Integer = GerarCodigoOrdens("TEF", CodConfig)
        Inserir("Insert into Ordens (Tabela, Cod, CodConfig) values('TEF'," & intCodTEF & "," & CodConfig & ")")

        Dim strValor As Double = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValorTotal)
        frmTEF.intCredDeb = 113
        RetornoTEF = -1
        ComprovanteTEF(0) = ""
        ComprovanteTEF(1) = ""
        frmTEF.Tag = ""
        frmTEF.strValor = strValor.ToString("0.00")
        frmTEF.strNumTransacao = strNSU
        frmTEF.cupomFiscal = intCodTEF
        frmTEF.ShowDialog()


        If RetornoTEF = 0 Then
         
            Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
            Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
            clsTEF.FinalizaTransacaoSiTefInterativo(1, intCodTEF, dataFiscal, horario)
            If RetornoTEF = 0 Then
                Dim A As Integer
                For A = 0 To ComprovanteTEF.Length - 1
                    If Impressora.Contains("ESC/POS") = True Then
                        If ComprovanteTEF(A) <> "" Then
                            clsImprimir.ImprimeCupomTEF(ComprovanteTEF(A))
                        End If

                    End If
                    ComprovanteTEF(A) = ""
                Next
            End If
     
        End If

    End Sub

    Private Sub btnTestarTEF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestarTEF.Click
        Dim intCodTEF As Integer = GerarCodigoOrdens("TEF", CodConfig)
        Inserir("Insert into Ordens (Tabela, Cod, CodConfig) values('TEF'," & intCodTEF & "," & CodConfig & ")")


        frmTEF.intCredDeb = 111
        RetornoTEF = -1
        frmTEF.Tag = "TESTE"
        frmTEF.strValor = "1,00"
        frmTEF.strNumTransacao = ""
        frmTEF.cupomFiscal = intCodTEF
        frmTEF.ShowDialog()


        If RetornoTEF = 0 Then

        End If
    End Sub

 
End Class