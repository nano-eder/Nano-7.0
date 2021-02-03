Imports Nano.clsFuncoes
Public Class frmConAtivos

    Private Sub frmConAtivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "BAIXA" Then
            Me.cboStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiVisualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.grd1.OptionsView.ShowGroupPanel = False

            CarregarDados("Select AtivoConsig.CodOrdens as CodOrdem, AtivoConsig.Codigo, AtivoConsig.Nome as Descricao, " & _
            "AtivoConsig.CodPadrao, convert(Varchar(10),AtivoConsig.Vencimento,103) as Vencimento, AtivoConsig.Status, " & _
            "ItensConsig.Produto, Cliente.Nome as Cliente from ((AtivoConsig left join ItensConsig on " & _
            "AtivoConsig.CodPedAut = ItensConsig.Codigo and AtivoConsig.CodConfig = ItensConsig.CodConfig) left join " & _
            "TotalConsig on AtivoConsig.CodOrdens = TotalConsig.CodOrdens and AtivoConsig.Codconfig = TotalConsig.CodConfig) " & _
            "Left join Cliente on TotalConsig.Codcli = Cliente.Codigo where AtivoConsig.Status = 'Entregue' " & _
            "and AtivoConsig.CodConfig = " & CodConfig, Me.GridControl1)


            Me.grd1.FormatConditions.Item(0).Value1 = Date.Today.AddDays(4)
            Me.grd1.FormatConditions.Item(1).Value1 = Date.Today.AddDays(-1)


        End If
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

        Dim strStatus As String = ""
        If Me.Tag <> "BAIXA" Then
            strStatus = Me.cboStatus.EditValue
            If strStatus = "" Then MsgBox("Selecione o Status!", MsgBoxStyle.Information) : Exit Sub
        Else
            strStatus = "ENTREGUE"
        End If
      

        If TesteConexao() = False Then Exit Sub

        Dim strData As String = String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue)

        CarregarDados("Select AtivoConsig.CodOrdens as CodOrdem, AtivoConsig.Codigo, AtivoConsig.Nome as Descricao, " & _
        "AtivoConsig.CodPadrao, convert(Varchar(10),AtivoConsig.Vencimento,103) as Vencimento, AtivoConsig.Status, " & _
        "ItensConsig.Produto, Cliente.Nome as Cliente from ((AtivoConsig left join ItensConsig on " & _
        "AtivoConsig.CodPedAut = ItensConsig.Codigo and AtivoConsig.CodConfig = ItensConsig.CodConfig) left join " & _
        "TotalConsig on AtivoConsig.CodOrdens = TotalConsig.CodOrdens and AtivoConsig.Codconfig = TotalConsig.CodConfig) " & _
        "Left join Cliente on TotalConsig.Codcli = Cliente.Codigo where AtivoConsig.Status = '" & strStatus & "' " & _
        "and AtivoConsig.CodConfig = " & CodConfig & " and " & strData, Me.GridControl1)

        If strStatus = "ENTREGUE" Then
            Me.pnlLegenda.Visible = True
            Me.grd1.FormatConditions.Item(0).Value1 = Date.Today.AddDays(4)
            Me.grd1.FormatConditions.Item(1).Value1 = Date.Today.AddDays(-1)
        Else
            Me.pnlLegenda.Visible = False
        End If
    
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relAtivo

        rel.picLogo.Image = LogoTipo
        Dim A As Integer = 0
        With rel.tbItens.Rows
            Dim I As Integer

            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem) <> "" Then
                    .Add()
                    .Item(A).Item("CodOrdem") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                    .Item(A).Item("CodPadrao") = Me.grd1.GetRowCellDisplayText(I, Me.colCodPadrao)
                    .Item(A).Item("Descricao") = Me.grd1.GetRowCellDisplayText(I, Me.colDescricao)
                    .Item(A).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(A).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)
                    .Item(A).Item("Vencimento") = Me.grd1.GetRowCellDisplayText(I, Me.colVencimento)
                    .Item(A).Item("Status") = Me.grd1.GetRowCellDisplayText(I, Me.colStatus)
                    A += 1
                End If
            
            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.Tag = "BAIXA" Then
            CodigoAtivo = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            Me.Close()
        End If
    End Sub
End Class