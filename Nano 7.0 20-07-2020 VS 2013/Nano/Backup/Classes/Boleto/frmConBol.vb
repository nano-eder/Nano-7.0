Imports Nano.clsFuncoes
Imports System.IO
Public Class frmConBol
    Public strCodPed As String
    Private Sub frmConPed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AtualizarGrid(True)

    End Sub
    
    Private Sub txtRetorno_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetorno.DoubleClick
        If Me.grd2.FocusedRowHandle < 0 Then Exit Sub

        GerarDanfe.GerarBoletoBradesco(Me.grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colCodigo), False)

        Me.Close()
    End Sub

    Private Sub txtRetorno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRetorno.KeyDown
        If Me.grd2.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then

            GerarDanfe.GerarEvento(Me.grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colCodigo), False)

            Me.Close()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
    Private Sub AtualizarGrid(ByVal parConsultaFutura As Boolean)
        Me.tbBoleto.Rows.Clear()
        Dim strCNPJ As String = CNPJEmpresa

        Dim strTipDoc As String

        If CNPJEmpresa.Length = 11 Then
            strTipDoc = "Cpf"
        Else
            strTipDoc = "Cnpj"
        End If

        strCNPJ = FormatarDocumentoString(CNPJEmpresa, strTipDoc)

        Dim strData As String = ""
        If parConsultaFutura = False Then
            strData = String.Format("Vencimento <= '{0:dd/MM/yyyy}'", Date.DaysInMonth(Now.Year, Now.Month) & "/" & Now.Month & "/" & Now.Year) & " and"
        End If
        Dim dtCli As DataTable = DataTableOnline("SELECT Codigo FROM Cliente where CPF = '" & strCNPJ & "'")
        If dtCli.Rows.Count > 0 Then

            Dim strCodCli As String = dtCli.Rows.Item(0).Item("Codigo").ToString
            Dim dtBoleto As DataTable = DataTableOnline("SELECT Boleto.Codigo, NossoNumero, Boleto.Valor, convert(varchar(10),Vencimento,103) as Vencimento, NumeroDocumento as Parcela, Cliente.Nome as Cliente FROM Boleto left join Cliente on Boleto.CodCli = Cliente.Codigo where " & strData & " CodCli = " & strCodCli & " and StatusRetorno is null or StatusRetorno <> 'LIQUÍDADO'")

            ' Dim dtBoleto As DataTable = CarregarDataTable("SELECT ContaReceber.Codigo, ContaReceber.FormaPagamento as Cliente, Parcelas as Parcela, Contareceber.NumeroDocumento as NossoNumero, ContaReceber.ValorParcela as Valor, convert(varchar(10),ContaReceber.Vencimento,103) as Vencimento FROM ContaReceber where RecebidoOk = 'False'")


            If dtBoleto.Rows.Count > 0 Then
                Dim I As Integer
                For I = 0 To dtBoleto.Rows.Count - 1
                    Dim strCodigo As String = dtBoleto.Rows.Item(I).Item("Codigo").ToString
                    Dim strNossoNumero As String = dtBoleto.Rows.Item(I).Item("NossoNumero").ToString
                    Dim strVencimento As String = dtBoleto.Rows.Item(I).Item("Vencimento").ToString
                    Dim strParcela As String = dtBoleto.Rows.Item(I).Item("Parcela").ToString
                    Dim strValorParcela As String = dtBoleto.Rows.Item(I).Item("Valor").ToString
                    Me.tbBoleto.Rows.Add()
                    Me.tbBoleto.Rows.Item(I).Item("Codigo") = strCodigo
                    Me.tbBoleto.Rows.Item(I).Item("NossoNumero") = strNossoNumero
                    Me.tbBoleto.Rows.Item(I).Item("Vencimento") = strVencimento
                    Me.tbBoleto.Rows.Item(I).Item("Parcela") = strParcela
                    Me.tbBoleto.Rows.Item(I).Item("Valor") = strValorParcela
                    Me.tbBoleto.Rows.Item(I).Item("Cliente") = dtBoleto.Rows.Item(I).Item("Cliente").ToString
                Next

            End If
        End If

    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If Me.grd2.FocusedRowHandle < 0 Then Exit Sub

        Dim dtVenc As Date = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colVencimento)

        If dtVenc >= Date.Today Then
            GerarDanfe.GerarBoletoBradesco(Me.grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colCodigo), False)
        Else
            GerarDanfe.GerarBoletoBradesco(Me.grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colCodigo), True)
        End If
    End Sub

    Private Sub btnAtualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtualizar.ItemClick
        AtualizarGrid(True)
    End Sub

  

    Private Sub btnCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCR.Click
        If MsgBox("Deseja realizar a instalação do visualizador de boleto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\CRRedist2005_x86.msi") Then
                System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\CRRedist2005_x86.msi")

            End If
        End If

    End Sub

End Class