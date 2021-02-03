Imports Nano.clsFuncoes
Public Class frmTabelaPreco

    Public intCodigo, intCodTabela As Integer
    Public bolAlterar As Boolean
    Dim strNome As String = ""
    Public strValorCusto As String
    Public intCodProd As Integer
    Dim bolValor As Boolean
    Dim bolPor As Boolean

    Private Sub frmGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        AtualizarGrid()
        bolAlterar = False
    End Sub
    Public Function AtualizarGrid() As Boolean
        If TesteConexao() = False Then
            Return False
            Exit Function

        Else
            Dim dt1 As DataTable = CarregarDataTable("Select Grupo.Codigo, Grupo.Nome From Grupo Where Tipo ='T' order by Codigo")

            Dim dt2 As DataTable = CarregarDataTable("Select Codigo, CodProd, CodTabela, Valor, Porcentagem From TabelaPreco Where CodProd =" & intCodProd & " order by CodTabela")

            Me.tbPreco.Rows.Clear()
            Dim I As Integer

            If dt1.Rows.Count > 0 Then
                For I = 0 To dt1.Rows.Count - 1
                    Me.tbPreco.Rows.Add()
                    Me.tbPreco.Rows.Item(I).Item("Nome") = dt1.Rows.Item(I).Item("Nome").ToString
                    Me.tbPreco.Rows.Item(I).Item("CodTabela") = dt1.Rows.Item(I).Item("Codigo").ToString
                Next
            End If

            If dt1.Rows.Count > 0 Then
                If dt2.Rows.Count > 0 Then
                    For I = 0 To dt1.Rows.Count - 1
                        Try
                            Me.tbPreco.Rows.Item(I).Item("CodPreco") = dt2.Rows.Item(I).Item("Codigo").ToString
                            Me.tbPreco.Rows.Item(I).Item("Valor") = dt2.Rows.Item(I).Item("Valor").ToString
                            Me.tbPreco.Rows.Item(I).Item("Porcent") = dt2.Rows.Item(I).Item("Porcentagem").ToString
                        Catch ex As Exception
                            If TresCasasDecimais = True Then
                                Me.tbPreco.Rows.Item(I).Item("Valor") = "0,000"
                                Me.tbPreco.Rows.Item(I).Item("Porcent") = "0,000"
                            Else
                                Me.tbPreco.Rows.Item(I).Item("Valor") = "0,00"
                                Me.tbPreco.Rows.Item(I).Item("Porcent") = "0,00"
                            End If
                        End Try
                    Next
                Else
                    For I = 0 To dt1.Rows.Count - 1
                        If TresCasasDecimais = True Then
                            Me.tbPreco.Rows.Item(I).Item("Valor") = "0,000"
                            Me.tbPreco.Rows.Item(I).Item("Porcent") = "0,000"
                        Else
                            Me.tbPreco.Rows.Item(I).Item("Valor") = "0,00"
                            Me.tbPreco.Rows.Item(I).Item("Porcent") = "0,00"
                        End If
                    Next
                End If
            End If

            Return True
        End If
    End Function
    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        Me.Close()
    End Sub
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.tbPreco.Rows.Clear()
        Me.Close()
    End Sub
    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.GridControl.ShowPrintPreview()
    End Sub
    Private Sub btnTabPreco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTabPreco.Click
        frmGrupo.Tag = "TABELAPRECO"
        frmGrupo.ShowDialog()
        AtualizarGrid()
    End Sub
    Private Sub txtPor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPor.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub CalcularPor()
        If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colPorcent) = "" Then Exit Sub

        Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colPorcent)
        Dim dblValCus, dblResul, dblPor As Double
        Try
            dblPor = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colPorcent)
            bolPor = True
        Catch ex As Exception
            bolPor = False
            Exit Sub
        End Try
        
        dblValCus = strValorCusto

        dblResul = (dblValCus * dblPor) / 100

        dblResul = dblValCus + dblResul

        If TresCasasDecimais = True Then
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colValor, dblResul.ToString("0.000"))
        Else
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colValor, dblResul.ToString("0.00"))
        End If

        If TresCasasDecimais = True Then
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colPorcent, dblPor.ToString("0.000"))
        Else
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colPorcent, dblPor.ToString("0.00"))
        End If
    End Sub
    Private Sub CalcularVal()
        If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValor) = "" Then Exit Sub

        Dim dblValVenda, dblValCusto, dblLucro, dblMargem As Double
        Try
            dblValVenda = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValor)
            bolValor = True
        Catch ex As Exception
            bolValor = False
            Exit Sub
        End Try
        dblValCusto = strValorCusto
        dblLucro = dblValVenda - dblValCusto

        dblMargem = (dblLucro * 100) / dblValCusto
        Dim str As String = dblMargem

        If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
            If TresCasasDecimais = True Then
                Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colPorcent, dblMargem.ToString("0.000"))
            Else
                Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colPorcent, dblMargem.ToString("0.00"))
            End If
        End If

        If TresCasasDecimais = True Then
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colValor, dblValVenda.ToString("0.000"))
        Else
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colValor, dblValVenda.ToString("0.00"))
        End If
    End Sub
    Private Sub txtPorcent_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPor.Leave
        Me.Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        CalcularPor()
        Me.Timer1.Stop()
        If bolPor = False Then
            MsgBox("Valor inválido!", MsgBoxStyle.Exclamation)
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colPorcent, "")
        End If
    End Sub
    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        Me.Timer2.Start()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        CalcularVal()
        Me.Timer2.Stop()
        If bolValor = False Then
            MsgBox("Valor inválido!", MsgBoxStyle.Exclamation)
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colValor, "")
        End If
    End Sub
    Private Sub GridControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")

            Dim strcol As String = Me.grd1.FocusedColumn.Name
            If strcol = "colValor" Then
                Me.colPorcent.OptionsColumn.AllowFocus = False
                Me.colNome.OptionsColumn.AllowFocus = False
            End If
        End If
    End Sub
    Private Sub GridControl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl.MouseMove
        Me.colPorcent.OptionsColumn.AllowFocus = True
        Me.colNome.OptionsColumn.AllowFocus = True
    End Sub
End Class