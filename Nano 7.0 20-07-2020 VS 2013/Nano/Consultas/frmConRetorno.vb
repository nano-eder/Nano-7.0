Imports Nano.clsFuncoes
Public Class frmConRetorno

    Private Sub frmConRetorno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmConRetorno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strData As String = String.Format("DATEADD(day,convert(integer,Retorno),TotalConsig.Data) >= '{0:dd/MM/yyyy}'", Date.Today) & " and TotalConsig.CodConfig = " & CodConfig

        CarregarDados("SELECT TotalConsig.CodOrdens as CodOrdem, Cliente.Nome as Cliente, Animal.Nome as Animal, CodigoInterno, Produto, TotalConsig.Data, " & _
        "case when Retorno <>'' then DATEADD(day,convert(integer,Retorno),TotalConsig.Data) else '' end as Retorno, Cliente.Email " & _
        "FROM ((ItensConsig left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and " & _
        "ItensConsig.CodConfig = TotalConsig.CodConfig) left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo where " & strData & " and Retorno <>''", Me.GridControl1)


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

        Dim strData As String = String.Format("DATEADD(day,convert(integer,Retorno),TotalConsig.Data) >= '{0:dd/MM/yyyy}' AND DATEADD(day,convert(integer,Retorno),TotalConsig.Data) <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & " and TotalConsig.CodConfig = " & CodConfig

        CarregarDados("SELECT TotalConsig.CodOrdens as CodOrdem, Cliente.Nome as Cliente, Animal.Nome as Animal, CodigoInterno, Produto, TotalConsig.Data, " & _
        "case when Retorno <>'' then DATEADD(day,convert(integer,Retorno),TotalConsig.Data) else '' end as Retorno, Cliente.Email " & _
        "FROM ((ItensConsig left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and " & _
        "ItensConsig.CodConfig = TotalConsig.CodConfig) left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo where " & strData & " and Retorno <> ''", Me.GridControl1)

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relRetorno
        Dim I As Integer
        rel.lblTitulo.Text = "Relatório de Retornos"

        rel.picLogo.Image = LogoTipo

        With rel.tbRetorno.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("Cliente") = grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("Animal") = grd1.GetRowCellDisplayText(I, Me.colAnimal)
                .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("CodigoInterno") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Retorno") = grd1.GetRowCellDisplayText(I, Me.colRetorno)
            Next


            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnEmail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmail.ItemClick
        Dim I As Integer
        Dim strCco As String = ""
        For I = 0 To Me.grd1.RowCount - 1
            If strCco = "" Then
                If Me.grd1.GetRowCellDisplayText(I, Me.colEmail) <> "" Then
                    strCco = Me.grd1.GetRowCellDisplayText(I, Me.colEmail)
                End If

            Else
                If Me.grd1.GetRowCellDisplayText(I, Me.colEmail) <> "" Then
                    strCco = ";" & Me.grd1.GetRowCellDisplayText(I, Me.colEmail)
                End If

            End If

        Next

        Dim frm As New frmEmail
        frm.cboTipo.EditValue = "RETORNO"
        Dim data1 As String
        data1 = dtInicial.EditValue

        If data1 = "" Then
            frm.dtInicialRetorno.Text = Date.Today
            frm.dtFinalRetorno.Text = Date.Today
        Else
            frm.dtInicialRetorno.Text = dtInicial.EditValue
            frm.dtFinalRetorno.Text = dtFinal.EditValue
        End If
        frm.txtCco.Text = strCco.ToLower
        frm.txtQtdRetorno.Text = Me.grd1.RowCount
        frm.Show()

    End Sub
End Class