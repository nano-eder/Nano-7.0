Imports Nano.clsFuncoes
Public Class frmRelMediaVenda
    Dim strFiltro As String

    Private Sub frmRelMediaVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        If Master = False Then
            Me.colCodConfig.Visible = False
            strFiltro = " and Pedido.CodConfig =" & CodConfig
        Else

            strFiltro = ""
        End If


        Me.cboRelatorio.EditValue = "PMV"
        Me.cboLoja.EditValue = "LOJA"

    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick

        'Dim strRelatorio As String = Me.cboRelatorio.EditValue
        Dim strLoja As String = Me.cboLoja.EditValue

        ' If strRelatorio = "" Then MsgBox("Campo Relatório é obrigatório!", MsgBoxStyle.Information) : Exit Sub
        If strLoja = "" Then MsgBox("Campo Loja/Vend. é obrigatório!", MsgBoxStyle.Information) : Exit Sub


        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)

        If strLoja = "LOJA" Then
            Me.colLoja.Caption = "Loja"
        Else
            Me.colLoja.Caption = "Vendedor"
        End If

        'Select Case strRelatorio

        '    Case "PMV"

        'Me.colValor.Caption = "Valor Total Venda R$"
        Me.colValor.DisplayFormat.FormatString = "c"
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.colQtd.Caption = "Qtde Total Venda"
        Me.colCalculo.Caption = "PMV R$"
        Me.colCalculo.DisplayFormat.FormatString = "c"
        Me.colCalculo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPMPV.DisplayFormat.FormatString = "c"
        Me.colPMPV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        If strLoja = "LOJA" Then

            CarregarDados("Select Config.Descricao as Loja, Sum(Pedido.ValorTotal) as Valor, Count(Distinct Total.CodOrdem) as Qtd, " & _
            "convert(Numeric(15,2),Sum(Pedido.ValorTotal) / Count(Distinct Total.CodOrdem)) as Calculo, Pedido.CodConfig, " & _
            "Sum(Pedido.Qtd) as QtdProduto, convert(Numeric(15,2),Sum(Pedido.Qtd) / Count(Distinct Total.CodOrdem)) as PA, " & _
            "convert(Numeric(15,2),Sum(Pedido.ValorTotal) / sum(Qtd)) as PMPV from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
            "and Pedido.CodConfig = Total.CodConfig)  left Join Config on Pedido.CodConfig = Config.Codigo " & _
            "where " & strData & strFiltro & " and Devolvido = 'False' and Pedido.TipoItens <> 'CONSUMO' group by Config.Descricao, Pedido.CodConfig", Me.GridControl1)

        Else
            CarregarDados("Select Funcionario.Nome as Loja, Sum(Pedido.ValorTotal) as Valor, Count(Distinct Total.CodOrdem) as Qtd, " & _
            "case when Count(Distinct Total.CodOrdem) > 0 then convert(Numeric(15,2),Sum(Pedido.ValorTotal) / Count(Distinct Total.CodOrdem)) else 0 end as Calculo, Pedido.CodConfig, " & _
            "Sum(Pedido.Qtd) as QtdProduto, case when Count(Distinct Total.CodOrdem) > 0 then convert(Numeric(15,2),Sum(Pedido.Qtd) / Count(Distinct Total.CodOrdem)) else 0 end as PA, " & _
            "case when sum(Qtd) > 0 then convert(Numeric(15,2),Sum(Pedido.ValorTotal) / sum(Qtd)) else 0 end as PMPV  from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
            "and Pedido.CodConfig = Total.CodConfig)  left Join Funcionario on Pedido.CodFunc = Funcionario.Codigo " & _
            "where " & strData & strFiltro & " and Devolvido = 'False' and Pedido.TipoItens <> 'CONSUMO' group by Funcionario.Nome, Pedido.CodConfig", Me.GridControl1)
        End If

        '    Case "PA"

        'Me.colValor.Caption = "Qtde Total Produto"
        'Me.colQtd.Caption = "Qtde Total Venda"
        'Me.colCalculo.Caption = "PA"
        'Me.colCalculo.DisplayFormat.FormatString = ""
        'Me.colCalculo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
        'Me.colValor.DisplayFormat.FormatString = ""
        'Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None

        'If strLoja = "LOJA" Then
        '    CarregarDados("Select Config.Descricao as Loja, Sum(Pedido.Qtd) as Valor, Count(Distinct Total.CodOrdem) as Qtd, " & _
        '    "convert(Numeric(15,2),Sum(Pedido.Qtd) / Count(Distinct Total.CodOrdem)) as Calculo, Pedido.CodConfig from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
        '    "and Pedido.CodConfig = Total.CodConfig)  left Join Config on Pedido.CodConfig = Config.Codigo " & _
        '    "where " & strData & strFiltro & " and Devolvido = 'False' group by Config.Descricao, Pedido.CodConfig", Me.GridControl1)

        'Else
        '    CarregarDados("Select Funcionario.Nome as Loja, Sum(Pedido.Qtd) as Valor, Count(Distinct Total.CodOrdem) as Qtd, " & _
        '    "convert(Numeric(15,2),Sum(Pedido.Qtd) / Count(Distinct Total.CodOrdem)) as Calculo, Pedido.CodConfig from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
        '    "and Pedido.CodConfig = Total.CodConfig)  left Join Funcionario on Pedido.CodFunc = Funcionario.Codigo " & _
        '    "where " & strData & strFiltro & " and Devolvido = 'False' group by Funcionario.Nome, Pedido.CodConfig", Me.GridControl1)

        'End If

        '    Case "PMPV"

        'Me.colValor.Caption = "Valor Total R$"
        'Me.colQtd.Caption = "Qtde Total Produto"
        'Me.colCalculo.Caption = "PMPV R$"
        'Me.colValor.DisplayFormat.FormatString = "c"
        'Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.colCalculo.DisplayFormat.FormatString = "c"
        'Me.colCalculo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'If strLoja = "LOJA" Then
        '    CarregarDados("Select Config.Descricao as Loja, Sum(Pedido.ValorTotal) as Valor, sum(Qtd) as Qtd, " & _
        '    "convert(Numeric(15,2),Sum(Pedido.ValorTotal) / sum(Qtd)) as Calculo, Pedido.CodConfig from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
        '    "and Pedido.CodConfig = Total.CodConfig)  left Join Config on Pedido.CodConfig = Config.Codigo " & _
        '    "where " & strData & strFiltro & " and Devolvido = 'False' group by Config.Descricao, Pedido.CodConfig", Me.GridControl1)
        'Else
        '    CarregarDados("Select Funcionario.Nome as Loja, Sum(Pedido.ValorTotal) as Valor, sum(Qtd) as Qtd, " & _
        '    "convert(Numeric(15,2),Sum(Pedido.ValorTotal) / sum(Qtd)) as Calculo, Pedido.CodConfig from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
        '    "and Pedido.CodConfig = Total.CodConfig)  left Join Funcionario on Pedido.CodFunc = Funcionario.Codigo " & _
        '    "where " & strData & strFiltro & " and Devolvido = 'False' group by Funcionario.Nome, Pedido.CodConfig", Me.GridControl1)
        'End If

        'End Select

        'Timer1.Start()
    End Sub

    Private Sub btnRelDesempenho_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelDesempenho.ItemClick
        Dim rel As New relDesempenho
        rel.picLogo.Image = LogoTipo
        rel.lblTitulo.Text = Me.Text & " - " & Me.cboRelatorio.EditValue
        With rel.tbVenda.Rows
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("Loja") = Me.grd1.GetRowCellDisplayText(I, Me.colLoja)
                .Item(I).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Calculo") = Me.grd1.GetRowCellDisplayText(I, Me.colCalculo)

                .Item(I).Item("QtdProduto") = Me.grd1.GetRowCellDisplayText(I, Me.colQtdProduto)
                .Item(I).Item("PA") = Me.grd1.GetRowCellDisplayText(I, Me.colPA)
                .Item(I).Item("PMPV") = Me.grd1.GetRowCellDisplayText(I, Me.colPMPV)
            Next
        End With

        rel.colLoja.Caption = Me.colLoja.Caption
        rel.colValor.Caption = Me.colValor.Caption
        rel.colQtd.Caption = Me.colQtd.Caption
        rel.colQtdProduto.Caption = Me.colQtdProduto.Caption
        rel.colCalculo.Caption = Me.colCalculo.Caption

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    '    Select Case Me.cboRelatorio.EditValue

    '        Case "PMV"
    '            Me.colValor.DisplayFormat.FormatString = "c"
    '            Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '            Me.colCalculo.DisplayFormat.FormatString = "c"
    '            Me.colCalculo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '        Case "PA"
    '            Me.colCalculo.DisplayFormat.FormatString = ""
    '            Me.colCalculo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
    '            Me.colValor.DisplayFormat.FormatString = ""
    '            Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
    '        Case "PMPV"
    '            Me.colValor.DisplayFormat.FormatString = "c"
    '            Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '            Me.colCalculo.DisplayFormat.FormatString = "c"
    '            Me.colCalculo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    End Select
    '    Timer1.Stop()
    'End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class