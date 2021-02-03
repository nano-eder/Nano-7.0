Imports Nano.clsFuncoes
Public Class frmConCampanha

    Dim strFiltro As String

    Private Sub frmConCampanha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)


        If Master = False Then
            strFiltro = " where Campanha.CodConfig =" & CodConfig
        End If

 
        Me.colCodConfig.Visible = Master

        If Me.Tag = "TOTAL" Then
            Me.colCodigoInterno.Visible = False
            Me.colCodInternoAnt.Visible = False
            Me.colProduto.Visible = False
            Me.colValor.Visible = False
            Me.colValorAnt.Visible = False
            Me.btnManter.Visible = False
            Me.btnPadrao.Visible = False

            CarregarDados("SELECT Campanha.NomeCampanha as Campanha, Campanha.Data, Campanha.Status, " & _
            "Campanha.CodConfig FROM Campanha " & strFiltro & " group by Campanha.NomeCampanha, Campanha.Data, " & _
            "Campanha.Status, Campanha.CodConfig", Me.PedidoGridControl)
        Else
            ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

            CarregarDados("SELECT Campanha.Codigo, Campanha.NomeCampanha as Campanha, Campanha.Data, Campanha.CodProd, " & _
            "Campanha.CodigoInterno, Campanha.CodInternoAnt, Campanha.Valor, Campanha.ValorAnt, Campanha.Status, " & _
            "Campanha.CodConfig, Produto.Nome as Produto FROM Campanha left join Produto on Campanha.CodProd = " & _
            "Produto.Codigo " & strFiltro, Me.PedidoGridControl)
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

        If TesteConexao() = False Then Exit Sub

        If Master = False Then
            strFiltro = " and Campanha.CodConfig =" & CodConfig
        End If

        Dim strData As String = String.Format("Campanha.Data >= '{0:dd/MM/yyyy}' AND Campanha.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        
        If Me.Tag = "TOTAL" Then
            CarregarDados("SELECT Campanha.NomeCampanha as Campanha, Campanha.Data, Campanha.Status, " & _
            "Campanha.CodConfig FROM Campanha where " & strData & " group by Campanha.NomeCampanha, Campanha.Data, " & _
            "Campanha.Status, Campanha.CodConfig", Me.PedidoGridControl)
        Else
            CarregarDados("SELECT Campanha.Codigo, Campanha.NomeCampanha as Campanha, Campanha.Data, Campanha.CodProd, " & _
            "Campanha.CodigoInterno, Campanha.CodInternoAnt, Campanha.Valor, Campanha.ValorAnt, Campanha.Status, " & _
            "Campanha.CodConfig, Produto.Nome as Produto FROM Campanha left join Produto on Campanha.CodProd = " & _
            "Produto.Codigo where " & strData, Me.PedidoGridControl)
        End If
       
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relConCampanha

        rel.picLogo.Image = LogoTipo
        Dim I As Integer
        With rel.tbCampanha.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Campanha") = grd1.GetRowCellDisplayText(I, Me.colCampanha)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                If Me.Tag = "ITENS" Then
                    .Item(I).Item("CodigoInterno") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                    .Item(I).Item("CodInternoAnt") = grd1.GetRowCellDisplayText(I, Me.colCodInternoAnt)
                    .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(I).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                    .Item(I).Item("ValorAnt") = grd1.GetRowCellDisplayText(I, Me.colValorAnt)
                End If
            
                .Item(I).Item("Status") = grd1.GetRowCellDisplayText(I, Me.colStatus)
                .Item(I).Item("CodConfig") = grd1.GetRowCellDisplayText(I, Me.colCodConfig)

            Next
         

        End With
        If Me.Tag = "TOTAL" Then
            rel.colCodigoInterno.Visible = False
            rel.colCodInternoAnt.Visible = False
            rel.colProduto.Visible = False
            rel.colValor.Visible = False
            rel.colValorAnt.Visible = False

            rel.Landscape = False

            rel.XrLine2.Size = New System.Drawing.Size(767, 8)
            rel.XrLine3.Size = New System.Drawing.Size(767, 8)
            rel.lblTitulo.Size = New System.Drawing.Size(575, 25)
        End If
        If Master = False Then
            rel.colCodConfig.Visible = False
        End If



        rel.ShowPreview()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.PedidoGridControl.ShowPrintPreview()
    End Sub
End Class