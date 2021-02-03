Imports Nano.clsFuncoes
Public Class frmRelComissaoTotal

    Private Sub frmRelComissaoTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "15")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelComissaoTotal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        Me.colCodConfig.Visible = Master
        If ComissaoProduto = True Then
            Me.colPorcentagem.Visible = False
        End If
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        If Me.Tag = "Somado" Then
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.colPago.Visible = False
            Me.lblTotalPago.Visible = False
            Me.txtTotalPago.Visible = False
            Me.Text = "Relatório Somado de Comissões"
            Dim strData As String = String.Format("Comissao.Data >= '{0:dd/MM/yyyy}' AND Comissao.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-30), Date.Today)

            Me.colCodOrdem.Visible = False
            Me.colData.Visible = False
            Me.colPorcentagem.Visible = False

            If NomeEmpresa.ToUpper.Contains("CAIRO") = True Then

                If Master = True Then
                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo FROM Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo where " & strData & " group by Comissao.CodConfig, " & _
                    "Funcionario.Nome, Comissao.TipoProduto", Me.GridControl1)

                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo FROM Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo where Month(Comissao.Data) = '" & Date.Today.Month & "' " & _
                    "And year(Comissao.Data) = '" & Date.Today.Year & "' group by Comissao.CodConfig, " & _
                    "Funcionario.Nome, Comissao.TipoProduto", Me.GridControl1)

                Else
                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo FROM Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo where Comissao.CodConfig =" & CodConfig & " and " & _
                    " " & strData & " group by " & _
                    "Funcionario.Nome, Comissao.TipoProduto", Me.GridControl1)

                End If
                Me.colCliente.Visible = False
            Else
                If Master = True Then
                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo, Cliente.Nome as Cliente FROM ((Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo where " & strData & " group by Comissao.CodConfig, " & _
                    "Funcionario.Nome, Comissao.TipoProduto, Cliente.Nome", Me.GridControl1)

                    'CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    '"sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, Comissao.CodConfig, " & _
                    '"Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo, Cliente.Nome as Cliente FROM ((Comissao left join Funcionario on " & _
                    '"Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo where Month(Comissao.Data) = '" & Date.Today.Month & "' " & _
                    '"And year(Comissao.Data) = '" & Date.Today.Year & "' group by Comissao.CodConfig, " & _
                    '"Funcionario.Nome, Comissao.TipoProduto, Cliente.Nome", Me.GridControl1)

                Else
                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo, Cliente.Nome as Cliente FROM ((Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo where Comissao.CodConfig =" & CodConfig & " and " & _
                    " " & strData & " group by " & _
                    "Funcionario.Nome, Comissao.TipoProduto, Cliente.Nome", Me.GridControl1)

                End If
            End If

        Else

            If NomeEmpresa.ToUpper.Contains("SOROCALHAS") = False Then
                Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.colPago.Visible = False
                Me.lblTotalPago.Visible = False
                Me.txtTotalPago.Visible = False
            End If
            Me.Text = "Relatório Detalhado de Comissões"
 
            If NomeEmpresa.ToUpper.Contains("CAIRO") = True Then
                If Master = True Then
                    CarregarDados("SELECT Comissao.Codigo, Comissao.TipoProduto as Tipo, Comissao.CodOrdem, Comissao.Data, Convert(Numeric(15,2),Comissao.ValorProduto) as ValorProduto, Convert(Numeric(15,2),Comissao.ValorComissao) as ValorComissao, Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, Funcionario.Nome as Funcionario, Pago FROM Comissao left join Funcionario on Comissao.CodFunc = Funcionario.Codigo", Me.GridControl1)
                Else
                    CarregarDados("SELECT Comissao.Codigo, Comissao.TipoProduto as Tipo, Comissao.CodOrdem, Comissao.Data, Convert(Numeric(15,2),Comissao.ValorProduto) as ValorProduto, Convert(Numeric(15,2),Comissao.ValorComissao) as ValorComissao, Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, Funcionario.Nome as Funcionario, Pago FROM Comissao left join Funcionario on Comissao.CodFunc = Funcionario.Codigo where Comissao.CodConfig =" & CodConfig, Me.GridControl1)

                End If
                Me.colCliente.Visible = False
            Else
                If Master = True Then
                    CarregarDados("SELECT Comissao.TipoProduto as Tipo, Comissao.CodOrdem, Comissao.Data, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
                    "Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Pago, Cliente.Nome as Cliente  FROM ((Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo  group by Comissao.TipoProduto, Comissao.Porcentagem, " & _
                    "Comissao.CodConfig, Funcionario.Nome, Comissao.CodOrdem, Comissao.Data, Pago, Cliente.Nome", Me.GridControl1)
                Else
                    CarregarDados("SELECT Comissao.TipoProduto as Tipo, Comissao.CodOrdem, Comissao.Data, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
                    "Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Pago, Cliente.Nome as Cliente  FROM ((Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo   where Comissao.CodConfig =" & CodConfig & " " & _
                    "group by Comissao.TipoProduto, Comissao.Porcentagem, " & _
                    "Comissao.CodConfig, Funcionario.Nome, Comissao.CodOrdem, Comissao.Data, Pago, Cliente.Nome", Me.GridControl1)

                End If
            End If
    
        End If
  

        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colCodOrdem
        grd1.ShowEditor()
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

        Dim strData As String = String.Format("Comissao.Data >= '{0:dd/MM/yyyy}' AND Comissao.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue)

        If Me.Tag = "Somado" Then
            If NomeEmpresa.ToUpper.Contains("CAIRO") = True Then
                If Master = True Then
                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo FROM Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo where " & strData & " group by Comissao.CodConfig, " & _
                    "Funcionario.Nome, Comissao.TipoProduto", Me.GridControl1)
                Else
                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo FROM Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo where Comissao.CodConfig =" & CodConfig & " and " & _
                    " " & strData & " group by " & _
                    "Funcionario.Nome, Comissao.TipoProduto", Me.GridControl1)

                End If
                Me.colCliente.Visible = False
            Else
                If Master = True Then
                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo, Cliente.Nome as Cliente FROM ((Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo where " & strData & " group by Comissao.CodConfig, " & _
                    "Funcionario.Nome, Comissao.TipoProduto, Cliente.Nome", Me.GridControl1)
                Else
                    CarregarDados("SELECT sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
                    "Funcionario.Nome as Funcionario, Comissao.TipoProduto as Tipo, Cliente.Nome as Cliente FROM ((Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo where Comissao.CodConfig =" & CodConfig & " and " & _
                    " " & strData & " group by " & _
                    "Funcionario.Nome, Comissao.TipoProduto, Cliente.Nome", Me.GridControl1)
                End If
            End If
      
        Else
            'If Master = True Then
            '    CarregarDados("SELECT Comissao.CodOrdem, Comissao.Tipo, Comissao.Data, Convert(Numeric(15,2),Comissao.ValorProduto) as ValorProduto, Convert(Numeric(15,2),Comissao.ValorComissao) as ValorComissao, Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, Funcionario.Nome as Funcionario, Pago FROM Comissao left join Funcionario on Comissao.CodFunc = Funcionario.Codigo where " & strData, Me.GridControl1)
            'Else
            '    CarregarDados("SELECT Comissao.CodOrdem, Comissao.Tipo, Comissao.Data, Convert(Numeric(15,2),Comissao.ValorProduto) as ValorProduto, Convert(Numeric(15,2),Comissao.ValorComissao) as ValorComissao, Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, Funcionario.Nome as Funcionario, Pago FROM Comissao left join Funcionario on Comissao.CodFunc = Funcionario.Codigo where Comissao.CodConfig =" & CodConfig & " and Funcionario.CodConfig = " & CodConfig & " and " & strData, Me.GridControl1)

            'End If

            ''If Master = True Then
            ''    CarregarDados("SELECT Comissao.TipoProduto as Tipo, Comissao.CodOrdem, Comissao.Data, " & _
            ''    "sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
            ''    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
            ''    "Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, " & _
            ''    "Funcionario.Nome as Funcionario, Pago, (SELECT Cliente.Nome FROM Cliente left join Total on Cliente.Codigo = Total.CodCli where Total.CodOrdem = Comissao.CodOrdem and Total.CodConfig = Comissao.CodConfig) as Cliente FROM Comissao left join Funcionario on " & _
            ''    "Comissao.CodFunc = Funcionario.Codigo where " & strData & " group by Comissao.TipoProduto, Comissao.Porcentagem, " & _
            ''    "Comissao.CodConfig, Funcionario.Nome, Comissao.CodOrdem, Comissao.Data, Pago", Me.GridControl1)
            ''Else
            ''    CarregarDados("SELECT Comissao.TipoProduto as Tipo, Comissao.CodOrdem, Comissao.Data, " & _
            ''    "sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
            ''    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
            ''    "Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, " & _
            ''    "Funcionario.Nome as Funcionario, Pago, (SELECT Cliente.Nome FROM Cliente left join Total on Cliente.Codigo = Total.CodCli where Total.CodOrdem = Comissao.CodOrdem and Total.CodConfig = Comissao.CodConfig) as Cliente  FROM Comissao left join Funcionario on " & _
            ''    "Comissao.CodFunc = Funcionario.Codigo where Comissao.CodConfig =" & CodConfig & " and " & _
            ''    "Funcionario.CodConfig = " & CodConfig & " and " & strData & " group by Comissao.TipoProduto, Comissao.Porcentagem, " & _
            ''    "Comissao.CodConfig, Funcionario.Nome, Comissao.CodOrdem, Comissao.Data, Pago", Me.GridControl1)

            ''End If
            If NomeEmpresa.ToUpper.Contains("CAIRO") = True Then
                If Master = True Then
                    CarregarDados("SELECT Comissao.CodOrdem, Comissao.Tipo, Comissao.Data, Convert(Numeric(15,2),Comissao.ValorProduto) as ValorProduto, Convert(Numeric(15,2),Comissao.ValorComissao) as ValorComissao, Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, Funcionario.Nome as Funcionario, Pago FROM Comissao left join Funcionario on Comissao.CodFunc = Funcionario.Codigo where " & strData, Me.GridControl1)
                Else
                    CarregarDados("SELECT Comissao.CodOrdem, Comissao.Tipo, Comissao.Data, Convert(Numeric(15,2),Comissao.ValorProduto) as ValorProduto, Convert(Numeric(15,2),Comissao.ValorComissao) as ValorComissao, Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, Funcionario.Nome as Funcionario, Pago FROM Comissao left join Funcionario on Comissao.CodFunc = Funcionario.Codigo where Comissao.CodConfig =" & CodConfig & " and Funcionario.CodConfig = " & CodConfig & " and " & strData, Me.GridControl1)

                End If
                Me.colCliente.Visible = False
            Else
                If Master = True Then
                    CarregarDados("SELECT Comissao.TipoProduto as Tipo, Comissao.CodOrdem, Comissao.Data, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
                    "Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Pago, Cliente.Nome as Cliente FROM ((Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo where " & strData & " group by Comissao.TipoProduto, Comissao.Porcentagem, " & _
                    "Comissao.CodConfig, Funcionario.Nome, Comissao.CodOrdem, Comissao.Data, Pago, Cliente.Nome", Me.GridControl1)
                Else
                    CarregarDados("SELECT Comissao.TipoProduto as Tipo, Comissao.CodOrdem, Comissao.Data, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorProduto)) as ValorProduto, " & _
                    "sum(Convert(Numeric(15,2),Comissao.ValorComissao)) as ValorComissao, " & _
                    "Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Comissao.CodConfig, " & _
                    "Funcionario.Nome as Funcionario, Pago, Cliente.Nome as Cliente  FROM ((Comissao left join Funcionario on " & _
                    "Comissao.CodFunc = Funcionario.Codigo) left join Total on Comissao.CodOrdem = Total.CodOrdem and Comissao.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli =Cliente.Codigo   where Comissao.CodConfig =" & CodConfig & " and " & _
                    "" & strData & " group by Comissao.TipoProduto, Comissao.Porcentagem, " & _
                    "Comissao.CodConfig, Funcionario.Nome, Comissao.CodOrdem, Comissao.Data, Pago, Cliente.Nome", Me.GridControl1)

                End If
            End If

        End If
        'CarregarDados("SELECT Comissao.CodOrdem, Comissao.Data, Convert(Numeric(15,2),Comissao.ValorProduto) as ValorProduto, Convert(Numeric(15,2),Comissao.ValorComissao) as ValorComissao, Convert(Numeric(15,2),Comissao.Porcentagem) as Porcentagem, Funcionario.Nome as Funcionario FROM Comissao left join Funcionario on Comissao.CodFunc = Funcionario.Codigo where " & strData, Me.GridControl1)
        Calcular()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub

    Private Sub Calcular()
        Dim I As Integer
        Dim dblValor, dblVenda, dblPago As Double
        For I = 0 To Me.grd1.RowCount - 1
            If Me.grd1.GetRowCellDisplayText(I, Me.colValorComissao) <> "" Then
                dblValor += Me.grd1.GetRowCellDisplayText(I, Me.colValorComissao)
            End If
            If Me.grd1.GetRowCellDisplayText(I, Me.colValorProduto) <> "" Then
                dblVenda += Me.grd1.GetRowCellDisplayText(I, Me.colValorProduto)
            End If
            If Me.Tag <> "Somado" Then
                Dim strPago As String = Me.grd1.GetRowCellValue(I, Me.colPago).ToString
                If strPago <> "" Then
                    If Me.grd1.GetRowCellValue(I, Me.colPago) = True Then
                        dblPago += Me.grd1.GetRowCellDisplayText(I, Me.colValorComissao)
                    End If
                End If
            End If
        
        Next
        Me.txtTotGer.Text = dblValor.ToString("###,###,##0.00")
        Me.txtVen.Text = dblVenda.ToString("###,###,##0.00")
        Me.txtTotalPago.Text = dblPago.ToString("###,###,##0.00")
    End Sub

    Private Sub btnRelCom_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCom.ItemClick
        Dim rel As New relComissaoTotal
        rel.picLogo.Image = LogoTipo
        rel.lblTitulo.Text = Me.Text
        With rel.tbCom.Rows
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Funcionario") = Me.grd1.GetRowCellDisplayText(I, Me.colFuncionario)
                .Item(I).Item("ValorVenda") = Me.grd1.GetRowCellDisplayText(I, Me.colValorProduto)
                .Item(I).Item("ValorComissao") = Me.grd1.GetRowCellDisplayText(I, Me.colValorComissao)

                .Item(I).Item("Tipo") = Me.grd1.GetRowCellDisplayText(I, Me.colTipo)
                .Item(I).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)

            Next
        End With
        If NomeEmpresa.ToUpper.Contains("CAIRO") = True Then
            rel.colCliente.Visible = False
        End If
        If Me.Tag = "Somado" Then
            rel.tabPago.Visible = False
            rel.colCodOrdem.Visible = False
            rel.colData.Visible = False
        End If
        If NomeEmpresa.ToUpper.Contains("SOROCALHAS") = False Then
            rel.tabPago.Visible = False
        Else
            rel.lblPago.Text = Me.txtTotalPago.Text
        End If
        rel.lblTotal.Text = Me.txtTotGer.Text.Trim
        rel.celVen.Text = Me.txtVen.Text.Trim
        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colCodOrdem
        grd1.ShowEditor()

        Dim I As Integer

        For I = 0 To Me.grd1.RowCount - 1
            'Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
            Dim strCodigoOrdem As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
            Dim strTipo As String = Me.grd1.GetRowCellDisplayText(I, Me.colTipo)
            Dim strCodConfig As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodConfig)
            Dim bolPago As Boolean = Me.grd1.GetRowCellValue(I, Me.colPago)

            Atualizar("UPDATE Comissao set Pago = '" & bolPago & "' where CodOrdem = " & strCodigoOrdem & " and Tipo = '" & strTipo & "' and CodConfig = " & strCodConfig)

        Next

        MsgBox("Dados salvo com sucesso!", MsgBoxStyle.Information)

    End Sub
End Class