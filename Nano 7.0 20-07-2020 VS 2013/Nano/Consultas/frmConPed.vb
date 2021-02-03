Imports Nano.clsFuncoes
Public Class frmConPed

    Private Sub frmConPed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        Dim strData As String
        Dim strCodFunc As String = ""
        strData = String.Format("TotalEntradaNf.Data >= '{0:dd/MM/yyyy}' AND TotalEntradaNf.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-365), Date.Today) & " and TotalEntradaNf.Codconfig = " & CodConfig
        If VincularUser = True Then
            Dim dtUser As DataTable = CarregarDataTable("SELECT Codigo FROM Funcionario where codUser = " & CodUser)

            If dtUser.Rows.Count > 0 Then
                If dtUser.Rows.Item(0).Item("Codigo").ToString <> "" Then
                    strCodFunc = " And TotalConsig.CodFunc =" & dtUser.Rows.Item(0).Item("Codigo").ToString
                End If
            End If
        End If
        Select Case Me.Tag

            Case "CONSULTA"
                If VincularUser = True Then
                    If TipoNano = 3 Then
                        Me.colAnimal.Visible = True
                        Me.colAnimal.VisibleIndex = 2
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, TotalConsig.CodCli, TotalConsig.Status, " & _
                        "TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, Cliente.Nome as Cliente, " & _
                        "Animal.Nome as Animal, TotalConsig.Comanda FROM ((TotalConsig left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
                        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo) where " & _
                        "TotalConsig.CodConfig =" & CodConfig & strCodFunc & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)
                    ElseIf TipoNano = 5 Then
                        CarregarDados("Select TotalConsig.Placa, TotalConsig.Modelo + ' ' + TotalConsig.Cor as Modelo,TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, TotalConsig.StatusPedido, Cliente.Nome as Cliente, TotalConsig.Comanda from TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status <> 'Excluído' AND TotalConsig.CodConfig =" & CodConfig & strCodFunc & " order by TotalConsig.CodOrdens Desc", Me.TotalGridControl)

                        Me.colPlaca.Visible = True
                        Me.colModelo.Visible = True

                        Me.colPlaca.VisibleIndex = 1
                        Me.colModelo.VisibleIndex = 2
                    Else
                        Me.colStatusPedido.Visible = True
                        Me.colStatusPedido.VisibleIndex = 5
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, TotalConsig.StatusPedido, Cliente.Nome as Cliente, TotalConsig.Comanda from TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status <> 'Excluído' AND TotalConsig.CodConfig =" & CodConfig & strCodFunc & " order by TotalConsig.CodOrdens Desc", Me.TotalGridControl)
                        
                    End If
                Else
                    If TipoNano = 3 Then
                        Me.colAnimal.Visible = True
                        Me.colAnimal.VisibleIndex = 2
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, TotalConsig.CodCli, TotalConsig.Status, " & _
                        "TotalConsig.Data,replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, Cliente.Nome as Cliente, " & _
                        "Animal.Nome as Animal, TotalConsig.Comanda FROM ((TotalConsig left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
                        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo) where " & _
                        "TotalConsig.CodConfig =" & CodConfig & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)
                    ElseIf TipoNano = 5 Then
                       CarregarDados("Select TotalConsig.Placa, TotalConsig.Modelo + ' ' + TotalConsig.Cor as Modelo,TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, TotalConsig.StatusPedido, Cliente.Nome as Cliente, TotalConsig.Comanda from TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status <> 'Excluído' AND TotalConsig.CodConfig =" & CodConfig & " order by TotalConsig.CodOrdens Desc", Me.TotalGridControl)

                        Me.colPlaca.Visible = True
                        Me.colModelo.Visible = True

                        Me.colPlaca.VisibleIndex = 1
                        Me.colModelo.VisibleIndex = 2
                    Else
                        Me.colStatusPedido.Visible = True
                        Me.colStatusPedido.VisibleIndex = 5
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, TotalConsig.StatusPedido, Cliente.Nome as Cliente, TotalConsig.Comanda from TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status <> 'Excluído' AND TotalConsig.CodConfig =" & CodConfig & " order by TotalConsig.CodOrdens Desc", Me.TotalGridControl)

                    End If
                End If
               
                If ComandaPedido = True Then
                    Me.colComanda.VisibleIndex = 1
                    Me.colComanda.Visible = True
                End If
                Me.colTotal.Visible = True
            Case "ALTERA", "ATIVO"
                If VincularUser = True Then
                    If TipoNano = 3 Then
                        Me.colAnimal.Visible = True
                        Me.colAnimal.VisibleIndex = 2
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, TotalConsig.CodCli, TotalConsig.Status, " & _
                        "TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, Cliente.Nome as Cliente, " & _
                        "Animal.Nome as Animal, TotalConsig.Comanda FROM ((TotalConsig left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
                        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo) where TotalConsig.Status <> 'Faturado' and TotalConsig.Status <> 'Excluído' " & _
                        "and TotalConsig.CodConfig =" & CodConfig & strCodFunc & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)
                    ElseIf TipoNano = 5 Then
                        CarregarDados("Select TotalConsig.Placa, TotalConsig.Modelo + ' ' + TotalConsig.Cor as Modelo,TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, TotalConsig.StatusPedido, Cliente.Nome as Cliente, TotalConsig.Comanda FROM TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status <> 'Faturado' and TotalConsig.Status <> 'Excluído' and TotalConsig.CodConfig =" & CodConfig & strCodFunc & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)

                        Me.colPlaca.Visible = True
                        Me.colModelo.Visible = True

                        Me.colPlaca.VisibleIndex = 1
                        Me.colModelo.VisibleIndex = 2
                    Else
                        Me.colStatusPedido.Visible = True
                        Me.colStatusPedido.VisibleIndex = 5
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, TotalConsig.StatusPedido, Cliente.Nome as Cliente, TotalConsig.Comanda FROM TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status <> 'Faturado' and TotalConsig.Status <> 'Excluído' and TotalConsig.CodConfig =" & CodConfig & strCodFunc & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)

                    End If
                Else
                    If TipoNano = 3 Then
                        Me.colAnimal.Visible = True
                        Me.colAnimal.VisibleIndex = 2
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, TotalConsig.CodCli, TotalConsig.Status, " & _
                        "TotalConsig.Data,replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, Cliente.Nome as Cliente, " & _
                        "Animal.Nome as Animal, TotalConsig.Comanda FROM ((TotalConsig left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
                        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo) where TotalConsig.Status <> 'Faturado' and TotalConsig.Status <> 'Excluído' " & _
                        "and TotalConsig.CodConfig =" & CodConfig & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)
                    ElseIf TipoNano = 5 Then
                        CarregarDados("Select TotalConsig.Placa, TotalConsig.Modelo + ' ' + TotalConsig.Cor as Modelo,TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, TotalConsig.StatusPedido, Cliente.Nome as Cliente, TotalConsig.Comanda FROM TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status <> 'Faturado' and TotalConsig.Status <> 'Excluído' and TotalConsig.CodConfig =" & CodConfig & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)

                        Me.colPlaca.Visible = True
                        Me.colModelo.Visible = True

                        Me.colPlaca.VisibleIndex = 1
                        Me.colModelo.VisibleIndex = 2
                    Else
                        Me.colStatusPedido.Visible = True
                        Me.colStatusPedido.VisibleIndex = 5
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, TotalConsig.StatusPedido, Cliente.Nome as Cliente, TotalConsig.Comanda FROM TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status <> 'Faturado' and TotalConsig.Status <> 'Excluído' and TotalConsig.CodConfig =" & CodConfig & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)

                    End If
                End If
                
                If ComandaPedido = True Then
                    Me.colComanda.VisibleIndex = 1
                    Me.colComanda.Visible = True
                End If
                Me.colTotal.Visible = True
            Case "FATURA"
                If VincularUser = True Then
                   
                    If TipoNano = 3 Then
                        Me.colAnimal.Visible = True
                        Me.colAnimal.VisibleIndex = 2
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, TotalConsig.CodCli, TotalConsig.Status, " & _
                        "TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, Cliente.Nome as Cliente, " & _
                        "Animal.Nome as Animal, TotalConsig.Comanda FROM ((TotalConsig left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
                        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo) where TotalConsig.Status = 'Pendente' " & _
                        "and TotalConsig.CodConfig =" & CodConfig & strCodFunc & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)
                    ElseIf TipoNano = 5 Then
                        CarregarDados("Select TotalConsig.Placa, TotalConsig.Modelo + ' ' + TotalConsig.Cor as Modelo, " & _
                        "TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data,replace(TotalConsig.Descricao,'|','') as Descricao, " & _
                        "TotalConsig.Total, Cliente.Nome as Cliente, TotalConsig.Comanda FROM TotalConsig, Cliente where " & _
                        "TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status = 'Pendente' and " & _
                        "TotalConsig.CodConfig =" & CodConfig & strCodFunc & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)
                        Me.colPlaca.Visible = True
                        Me.colModelo.Visible = True

                        Me.colPlaca.VisibleIndex = 1
                        Me.colModelo.VisibleIndex = 2
                    Else
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, " & _
                        "TotalConsig.Data,replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, " & _
                        "Cliente.Nome as Cliente, TotalConsig.Comanda FROM TotalConsig, Cliente where " & _
                        "TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status = 'Pendente' and " & _
                        "TotalConsig.CodConfig =" & CodConfig & strCodFunc & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)

                    End If
                Else
                    If TipoNano = 3 Then
                        Me.colAnimal.Visible = True
                        Me.colAnimal.VisibleIndex = 2
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, TotalConsig.CodCli, TotalConsig.Status, " & _
                        "TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, Cliente.Nome as Cliente, " & _
                        "Animal.Nome as Animal, TotalConsig.Comanda FROM ((TotalConsig left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
                        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo) where TotalConsig.Status = 'Pendente' " & _
                        "and TotalConsig.CodConfig =" & CodConfig & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)

                    Else
                        CarregarDados("Select TotalConsig.CodOrdens as Codigo, CodCli, TotalConsig.Status, TotalConsig.Data, replace(TotalConsig.Descricao,'|','') as Descricao, TotalConsig.Total, Cliente.Nome as Cliente, TotalConsig.Comanda FROM TotalConsig, Cliente where TotalConsig.CodCli = Cliente.Codigo and TotalConsig.Status = 'Pendente' and TotalConsig.CodConfig =" & CodConfig & " Order By TotalConsig.CodOrdens desc", Me.TotalGridControl)

                    End If
                End If
               
                If ComandaPedido = True Then
                    Me.colComanda.VisibleIndex = 1
                    Me.colComanda.Visible = True
                End If
                Me.colTotal.Visible = True

            Case "RECEITA"
                Me.Text = "Consulta de Receita"
                CarregarDados("SELECT CodigoInterno as Codigo, Nome as Cliente, CodConfig as Status FROM Receita", Me.TotalGridControl)
                Me.colStatus.Visible = False
                Me.colData1.Visible = False
                Me.colCliente.Caption = "Nome"
                Me.colCodigo.Caption = "Cód. Receita"
                'Me.colStatus.Caption = "Cód. Loja"
            Case "ALTERATRANS", "ENVIATRANS"
                CarregarDados("Select CodOrdem as Codigo, Config.Descricao as Cliente, Status, Data, sum(convert(numeric(15,3),Transferencia.Codigo)) from Transferencia left join Config on Transferencia.CodConfig = Config.Codigo where Status = 'Pendente' and CodConfig = " & CodConfig & " group by CodOrdem, Config.Descricao, Status, Data", Me.TotalGridControl)
                Me.colCliente.Caption = "Loja"
                Me.colCodigo.Caption = "Cód. Ordem"
            Case "CONSULTATRANS"
                CarregarDados("Select CodOrdem as Codigo, Config.Descricao as Cliente, Status, Data, sum(convert(numeric(15,3),Transferencia.Codigo)) from Transferencia left join Config on Transferencia.CodConfig = Config.Codigo where CodConfig = " & CodConfig & " group by CodOrdem, Config.Descricao, Status, Data", Me.TotalGridControl)
                Me.colCliente.Caption = "Loja"
                Me.colCodigo.Caption = "Cód. Ordem"
            Case "CONSULTANFE"
                CarregarDados("Select Total.CodOrdem as Codigo, Total.CodCli, Total.Data, Cliente.Nome as Cliente from (Total left join Cliente on Total.CodCli = Cliente.Codigo)left join TotalNfe on Total.CodOrdem = TotalNfe.CodOrdem where Total.CodConfig =" & CodConfig & " and TotalNfe.CodOrdem is null order by Total.CodOrdem Desc", Me.TotalGridControl)
                Me.colCodigo.Caption = "Nº Venda"
                Me.colObs.Visible = False
                Me.colStatus.Visible = False


            Case "ENTRADANFCONSULTA"

                CarregarDados("SELECT NumeroNF as Codigo, Fornecedor.Nome as Cliente, TotalEntradaNf.Data, EstoqueOK as Estoque, CodFor as Status, TotalEntradaNF.Total FROM TotalEntradaNF left join Fornecedor on TotalEntradaNF.CodFor = Fornecedor.Codigo where " & strData, Me.TotalGridControl)
            Case "ENTRADANFALTERA"
                CarregarDados("SELECT NumeroNF as Codigo, Fornecedor.Nome as Cliente, TotalEntradaNf.Data, EstoqueOK as Estoque, CodFor as Status, TotalEntradaNF.Total FROM TotalEntradaNF left join Fornecedor on TotalEntradaNF.CodFor = Fornecedor.Codigo where " & strData & " and EstoqueOK = 'False'", Me.TotalGridControl)
            Case "ENTRADANFCANCELA"
                CarregarDados("SELECT NumeroNF as Codigo, Fornecedor.Nome as Cliente, TotalEntradaNf.Data, EstoqueOK as Estoque, CodFor as Status, TotalEntradaNF.Total FROM TotalEntradaNF left join Fornecedor on TotalEntradaNF.CodFor = Fornecedor.Codigo where " & strData, Me.TotalGridControl)



            Case "CONSULTACOMPRA"
                Me.colCliente.Caption = "Fornecedor"
                CarregarDados("Select TotalPedCompra.CodOrdens as Codigo, CodFor, TotalPedCompra.Status, TotalPedCompra.Data, TotalPedCompra.Descricao, TotalPedCompra.Total, Fornecedor.Nome as Cliente from TotalPedCompra, Fornecedor where TotalPedCompra.CodFor = Fornecedor.Codigo and TotalPedCompra.Status <> 'Excluído' AND TotalPedCompra.CodConfig =" & CodConfig & " order by TotalPedCompra.CodOrdens Desc", Me.TotalGridControl)


            Case "ALTERACOMPRA"
                Me.colCliente.Caption = "Fornecedor"
                CarregarDados("Select TotalPedCompra.CodOrdens as Codigo, CodFor, TotalPedCompra.Status, TotalPedCompra.Data, TotalPedCompra.Descricao, TotalPedCompra.Total, Fornecedor.Nome as Cliente FROM TotalPedCompra, Fornecedor where TotalPedCompra.CodFor = Fornecedor.Codigo and TotalPedCompra.Status <> 'Finalizado' and TotalPedCompra.Status <> 'Excluído' and TotalPedCompra.CodConfig =" & CodConfig & " Order By TotalPedCompra.CodOrdens desc", Me.TotalGridControl)


            Case "CONSULTACOMPRANF"
                Me.colCliente.Caption = "Fornecedor"
                CarregarDados("Select TotalPedCompra.CodOrdens as Codigo, CodFor, TotalPedCompra.Status, TotalPedCompra.Data, TotalPedCompra.Descricao, TotalPedCompra.Total, Fornecedor.Nome as Cliente FROM TotalPedCompra, Fornecedor where TotalPedCompra.CodFor = Fornecedor.Codigo and TotalPedCompra.Status <> 'Finalizado' and TotalPedCompra.Status <> 'Excluído' and TotalPedCompra.CodConfig =" & CodConfig & " Order By TotalPedCompra.CodOrdens desc", Me.TotalGridControl)

            Case "CAMPANHACONSULTA"
                Me.Text = "Consulta Campanhas"
                Me.colCliente.Caption = "Campanha"
                Me.colObs.Visible = False
                Me.colTotal.Visible = False
                Me.colCodigo.Caption = "Código"
                Me.colCodigo.Visible = False
                CarregarDados("Select Data, NomeCampanha as Cliente, Status FROM Campanha where CodConfig =" & CodConfig & " group by Data, NomeCampanha, Status Order By Data desc", Me.TotalGridControl)
            Case "CAMPANHAALTERA"
                Me.Text = "Consulta Campanhas"
                Me.colCliente.Caption = "Campanha"
                Me.colObs.Visible = False
                Me.colTotal.Visible = False
                Me.colCodigo.Caption = "Código"
                Me.colCodigo.Visible = False
                CarregarDados("Select Data, NomeCampanha as Cliente, Status FROM Campanha where Status <> 'Finalizado' and CodConfig =" & CodConfig & " group by Data, NomeCampanha, Status Order By Data desc", Me.TotalGridControl)
            Case "CAMPANHAFINALIZAR"
                Me.Text = "Consulta Campanhas"
                Me.colCliente.Caption = "Campanha"
                Me.colObs.Visible = False
                Me.colTotal.Visible = False
                Me.colCodigo.Caption = "Código"
                Me.colCodigo.Visible = False
                CarregarDados("Select Data, NomeCampanha as Cliente, Status FROM Campanha where Status = 'Lancado' and CodConfig =" & CodConfig & " group by Data, NomeCampanha, Status Order By Data desc", Me.TotalGridControl)
            Case "CAMPANHAANDAMENTO"
                Me.Text = "Campanhas em Andamento"
                Me.colCliente.Caption = "Campanha"
                Me.colObs.Visible = False
                Me.colTotal.Visible = False
                Me.colCodigo.Caption = "Código"
                Me.colCodigo.Visible = False
                CarregarDados("Select Data, NomeCampanha as Cliente, Status FROM Campanha where Status = 'Lancado' and CodConfig =" & CodConfig & " group by Data, NomeCampanha, Status Order By Data desc", Me.TotalGridControl)

            Case "COTACAO"
                CarregarDados("Select CodOrdem as Codigo,  Sum(Valor) As Total, Data From Cotacao Where CodConfig=" & CodConfig & " Group By CodOrdem, Data", Me.TotalGridControl)

                Me.Text = "Consulta de Cotação"
                'Me.colPlaca.Visible = False
                'Me.colModelo.Visible = False
                Me.colStatus.Visible = False
                Me.colCodigo.Caption = "Nº Cotação"
                Me.colCliente.Visible = False
                '.colEstoqueOK.Visible = False
                Me.colCodigo.SortOrder = DevExpress.Data.ColumnSortOrder.None
                Me.colData1.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
                Me.colTotal.Width = 200

        End Select

        If Me.Tag.ToString.Contains("ENTRADA") = True Then
            Me.Text = "Consulta de Notas Fiscais"
            Me.colObs.Visible = False
            Me.colStatus.Visible = False
            Me.colCodigo.Caption = "Nº NF"
            Me.colCliente.Caption = "Fornecedor"
            Me.colEstoque.Visible = True
            Me.colCodigo.SortOrder = DevExpress.Data.ColumnSortOrder.None
            Me.colData1.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            Me.colTotal.Visible = True
        End If
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        If ComandaPedido = True Then
            Select Case Me.Tag
                Case "CONSULTA", "ALTERA", "ATIVO", "FATURA"
                    grd1.FocusedColumn = Me.colComanda
                Case "CAMPANHA"
                    grd1.FocusedColumn = Me.colCliente
                Case Else
                    grd1.FocusedColumn = Me.colCodigo
            End Select
        Else
            If Me.Tag.ToString.Contains("CAMPANHA") = True Then
                grd1.FocusedColumn = Me.colCliente
            Else
                grd1.FocusedColumn = Me.colCodigo
            End If

        End If

        grd1.ShowEditor()
        Timer1.Stop()
    End Sub

    Private Sub txtRetorno_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetorno.DoubleClick
        Retorno()
    End Sub

    Private Sub Retorno()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If Me.Tag.ToString.Contains("ENTRADA") = True Then
            RetornaEntradaNF = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo) & "|" & Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colStatus)
        ElseIf Me.Tag.ToString.Contains("CAMPANHA") = True Then
            ConsultaPedido = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCliente)
        Else
            ConsultaPedido = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
        End If

        Me.Close()
    End Sub

    Private Sub txtRetorno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRetorno.KeyDown

        If Me.grd1.FocusedColumn.ColumnHandle <> 0 And Me.grd1.FocusedColumn.ColumnHandle <> 7 Then
            If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then
            'If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
            If Me.Tag.ToString.Contains("ENTRADA") = True Then
                RetornaEntradaNF = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo) & "|" & Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colStatus)

            Else


                Select Case Me.Tag
                    Case "FATURA", "ALTERA"
                        If Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo) <> "" Then
                            Dim dt As DataTable = CarregarDataTable("SELECT CodOrdens FROM TotalConsig where Status <> 'Faturado' and CodOrdens = " & Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo))
                            If dt.Rows.Count > 0 Then
                                ConsultaPedido = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
                            Else
                                Exit Sub
                            End If

                        Else
                            If Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colComanda) <> "" Then
                                Dim dt As DataTable = CarregarDataTable("SELECT CodOrdens FROM TotalConsig where Status <> 'Faturado' and Comanda = '" & Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colComanda) & "'")
                                If dt.Rows.Count > 0 Then
                                    ConsultaPedido = dt.Rows.Item(0).Item("CodOrdens").ToString
                                Else
                                    Exit Sub
                                End If
                            Else
                                Exit Sub
                            End If
                        End If
                    Case "CAMPANHAALTERA", "CAMPANHACONSULTA"

                        ConsultaPedido = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCliente)
                       
                    Case Else
                        If Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo) <> "" Then
                            ConsultaPedido = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
                        Else
                            Exit Sub
                        End If
                End Select

            End If

            Me.Close()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnVisu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisu.ItemClick
        Me.TotalGridControl.ShowPrintPreview()
    End Sub

    Private Sub txtRetorno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetorno.KeyPress

        If Me.grd1.FocusedColumn.Name <> Me.colCodigo.Name Then Exit Sub

        If IsNumeric(e.KeyChar) = False Then
            If e.KeyChar = vbBack Or e.KeyChar = "*" Then Exit Sub
            e.Handled = True
        End If
    End Sub
End Class