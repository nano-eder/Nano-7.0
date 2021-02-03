Imports Nano.clsFuncoes
Public Class frmDetalharCupom

    Public strCodigoAut As String
    Public intIndex As Integer
    Private Sub frmDetalharCupom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim dt2 As DataTable = CarregarDataTable("Select convert(numeric(15,2),ICMS) as ICMS, IPI, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, TipoFIA, NCM from ImpostoProduto where CodProd = " & strCodigoAut)

        If dt2.Rows.Count > 0 Then
            Me.txtIcms.Text = dt2.Rows.Item(0).Item("ICMS").ToString

            Select Case dt2.Rows.Item(0).Item("Tributacao").ToString
                Case "T"
                    Me.cboTrib2.SelectedIndex = 0
                Case "F"
                    Me.cboTrib2.SelectedIndex = 1
                Case "I"
                    Me.cboTrib2.SelectedIndex = 2
                Case "N"
                    Me.cboTrib2.SelectedIndex = 3
            End Select


            Me.txtNCMImpProd.Text = dt2.Rows.Item(0).Item("NCM").ToString
        Else
            Me.txtNCMImpProd.ResetText()
            Me.txtIcms.ResetText()
            Me.cboTrib2.SelectedIndex = -1
           
        End If

    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.cboTrib2) = False Then Exit Sub
        If Me.cboTrib2.SelectedIndex = 0 Then
            If Validar(txtIcms) = False Then Exit Sub
        End If
        If Validar(Me.txtNCMImpProd) = False Then Exit Sub

        frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCFOP, Me.cboTrib2.Text.Substring(0, 1))
        frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaICMS, Me.txtIcms.Text)
        frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colNCM, Me.txtNCMImpProd.Text)
   

        Dim dt As DataTable = CarregarDataTable("Select ICMS from ImpostoProduto where CodProd = " & strCodigoAut)
        If dt.Rows.Count = 0 Then
            Inserir("Insert into ImpostoProduto (CodProd, ICMS, Tributacao, NCM) Values(" & strCodigoAut & "," & Num(Me.txtIcms.Text.Trim) & ",'" & Me.cboTrib2.Text.Substring(0, 1) & "','" & Me.txtNCMImpProd.Text & "')")
        Else
            Atualizar("Update ImpostoProduto set ICMS =" & Num(Me.txtIcms.Text.Trim) & ", Tributacao ='" & Me.cboTrib2.Text.Substring(0, 1) & "', NCM = '" & Me.txtNCMImpProd.Text & "' where CodProd = " & strCodigoAut)
        End If

        MsgBox("Dados salvo com sucesso!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnSalvarTodos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvarTodos.ItemClick
        If Validar(Me.cboTrib2) = False Then Exit Sub
        If Me.cboTrib2.SelectedIndex = 0 Then
            If Validar(txtIcms) = False Then Exit Sub
        End If
        If Validar(Me.txtNCMImpProd) = False Then Exit Sub
        Dim I As Integer

        Dim intGridCount As Integer = frmPesquisaImp.grd1.RowCount

        For I = 0 To frmPesquisaImp.grd1.RowCount - 1
            Dim intIndex As Integer = intGridCount - (I + 1)
            Dim strCodProd As String = frmPesquisaImp.grd1.GetRowCellDisplayText(intIndex, frmPesquisaImp.colCodigo)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCFOP, Me.cboTrib2.Text.Substring(0, 1))
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaICMS, Me.txtIcms.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colNCM, Me.txtNCMImpProd.Text)


            Dim dt As DataTable = CarregarDataTable("Select ICMS from ImpostoProduto where CodProd = " & strCodProd)
            If dt.Rows.Count = 0 Then
                Inserir("Insert into ImpostoProduto (CodProd, ICMS, Tributacao, NCM) Values(" & strCodProd & "," & Num(Me.txtIcms.Text.Trim) & ",'" & Me.cboTrib2.Text.Substring(0, 1) & "','" & Me.txtNCMImpProd.Text & "')")
            Else
                Atualizar("Update ImpostoProduto set ICMS =" & Num(Me.txtIcms.Text.Trim) & ", Tributacao ='" & Me.cboTrib2.Text.Substring(0, 1) & "', NCM = '" & Me.txtNCMImpProd.Text & "' where CodProd = " & strCodProd)
            End If
        Next

        Dim index As Integer = -999997
        frmPesquisaImp.grd1.FocusedRowHandle = index
        frmPesquisaImp.grd1.FocusedColumn = frmPesquisaImp.colProduto
        frmPesquisaImp.grd1.ShowEditor()
        MsgBox("Dados salvo com sucesso!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub cboTrib2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrib2.SelectedIndexChanged
        Select Case Me.cboTrib2.SelectedIndex
            Case 0, 1
                Me.txtIcms.Enabled = True
            Case Else
                Me.txtIcms.Text = "0,00"
                Me.txtIcms.Enabled = False
        End Select
    End Sub
End Class