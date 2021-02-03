Imports Nano.clsFuncoes
Imports Nano.clsImprimir

Public Class frmComanda

    Dim bolLeave As Boolean = False
    Dim strProdutoFinal As String
    Dim dblMaiorValor As Double
    Dim strCodAutMaior, strCodInterMaior As String
    Dim intCont As Integer
    Dim intCodCli As Integer = 1
    Dim strTipoComanda As String
    Dim intCodigoComanda As Integer

    Dim bolDigQtd As Boolean = False

    Dim strCodigoOrdem As String
    Dim bolSplit As Boolean = False
    Dim bolManter As Boolean = False
    Dim bolFunc As Boolean = False
    Public intCodFunc As Integer = 0

    Dim strMesa As String


    Dim strBairro As String


    Private Sub txtComan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComan.KeyPress
        'If bolLeave = True Then bolLeave = False : Exit Sub
        'LimparDados(False)
    End Sub

    Private Sub TrazCliente(ByVal parCodCli As Integer, ByVal parAlterar As Boolean)
        Dim dt As DataTable = CarregarDataTable("Select Nome, Telefone, Endereco, Numero, Complemento, Bairro from Cliente where Cliente.Codigo =" & parCodCli)

        If dt.Rows.Count > 0 Then
            Dim strEnd As String = ""

            intCodCli = parCodCli
            Me.lblCli.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtNome.Text = dt.Rows.Item(0).Item("Nome").ToString

            If parAlterar = False Then
                Dim dtCliente As DataTable = CarregarDataTable("Select Nome from Comanda Where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status = 'Aberto' and Tipo ='" & strTipoComanda & "' AND CodConfig =" & CodConfig & " order by Codigo Desc")
                If dtCliente.Rows.Count > 0 Then
                    Me.lblCli.Text = dtCliente.Rows.Item(0).Item("Nome").ToString.Trim
                    Me.txtNome.Text = dtCliente.Rows.Item(0).Item("Nome").ToString.Trim
                End If
            End If
 

            'If strTipoComanda = "COMANDA" Then
            AlterarCliente(intCodCli, Me.txtNome.Text)
            'End If

            Me.txtTel.Text = dt.Rows.Item(0).Item("Telefone").ToString

            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                strEnd = dt.Rows.Item(0).Item("Endereco").ToString
            End If

            If dt.Rows.Item(0).Item("Numero").ToString <> "" Then
                strEnd += ", " & dt.Rows.Item(0).Item("Numero").ToString
            End If

            If dt.Rows.Item(0).Item("Complemento").ToString <> "" Then
                strEnd += " - " & dt.Rows.Item(0).Item("Complemento").ToString
            End If
            strBairro = ""
            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                strEnd += " - " & dt.Rows.Item(0).Item("Bairro").ToString

                strBairro = dt.Rows.Item(0).Item("Bairro").ToString

                If Me.lblEnd.Text = "" Then
                    SalvarBairro(strBairro)
                End If
                
            End If

            Me.lblEnd.Text = strEnd

        Else
            intCodCli = 1
            Me.lblCli.Text = ""
            Me.txtTel.Text = ""
            Me.lblEnd.Text = ""
        End If

        'Me.txtAte.Focus()

    End Sub
    Private Sub SalvarBairro(ByVal parBairro As String)
        If Me.btnEntrega.Checked = False Then Exit Sub
        If parBairro <> "" Then
            Dim dtGrupo As DataTable = CarregarDataTable("SELECT PortaImpressora FROM Grupo where Tipo = 'B' order by PortaImpressora desc")
            If dtGrupo.Rows.Count = 0 Then
                Exit Sub
            Else
                If dtGrupo.Rows.Item(0).Item("PortaImpressora").ToString <> "" Then
                    Dim dblFrete As Double = dtGrupo.Rows.Item(0).Item("PortaImpressora")
                    If dblFrete <= 0 Then
                        Exit Sub
                    End If
                End If
            End If

            dtGrupo = CarregarDataTable("SELECT Codigo, PortaImpressora FROM Grupo where Nome = '" & parBairro & "' and Tipo = 'B'")
            Dim bolSalvarFrete As Boolean = True
            Dim strCodigo As String = ""
            If dtGrupo.Rows.Count > 0 Then
                strCodigo = dtGrupo.Rows.Item(0).Item("Codigo").ToString
                If dtGrupo.Rows.Item(0).Item("PortaImpressora").ToString <> "" Then
                    Dim dblFrete As Double = dtGrupo.Rows.Item(0).Item("PortaImpressora")
                    If dblFrete > 0 Then
                        bolSalvarFrete = False
                    End If
                End If
           
            End If
            If bolSalvarFrete = True Then
                ValorUnitComanda = 0
                frmValorComanda.Tag = "FRETE"
                frmValorComanda.ShowDialog()
                Dim strValor As String = ValorUnitComanda.ToString("0.00")
                If strCodigo = "" Then
                    Inserir("INSERT INTO Grupo (Nome, Tipo, PortaImpressora) VALUES ('" & parBairro & "','B','" & strValor & "')")
                Else
                    If ValorUnitComanda > 0 Then
                        Atualizar("UPDATE Grupo set PortaImpressora = '" & strValor & "' where Nome = '" & parBairro & "' and Tipo = 'B'")
                    End If

                End If
            End If
            'Inserir("If not exists(Select Codigo from Grupo where Tipo = 'B' and Nome = '" & Me.txtBairro.Text & "') INSERT INTO Grupo (Nome, Tipo, PortaImpressora) VALUES ('" & Me.txtBairro.Text & "','B','0,00')")
        End If
    End Sub
    Private Sub LimparDados(ByVal parLimpaComanda As Boolean)
      
        Me.txtCodProd.ResetText()
        Me.txtCodProd.Tag = ""
        Me.txtQtd.ResetText()
        Me.txtValorTotal.ResetText()
        Me.txtGeral.ResetText()
        Me.cboEnt.SelectedIndex = -1
        Me.cboTempo.SelectedIndex = -1
        Me.txtTroco.ResetText()
        Me.txtTroPar.ResetText()
        Me.rdgMaqCartao.SelectedIndex = 0
        Me.txtValorFrete.ResetText()
        Me.txtObs.ResetText()
        QtdePessoasMesa = "0"
        LimpaAtendente()
        LimparTxtNum()
        strBairro = ""
        If parLimpaComanda = True Then
            Me.txtComan.ResetText()
        End If

        TrazCliente(1, False)

        CarregarDados("SELECT CodComanda FROM Comanda where CodComanda = '00'", Me.GridControl1)

        If strTipoComanda = "COMANDA" Then
            Me.txtComan.Focus()
        Else
            Me.txtTel.Focus()
        End If
        If TabelaPreco <> "" Then
            Dim dtTab As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Tipo = 'T' and Nome = '" & TabelaPreco & "'")
            If dtTab.Rows.Count > 0 Then
                Me.cboTabela.Text = TabelaPreco
            Else
                Me.cboTabela.Text = "PADRÃO"
            End If
        Else
            Me.cboTabela.Text = "PADRÃO"
        End If
    End Sub

    Private Sub SalvarObservacao()
        If Me.txtComan.Text <> "" Then
            Try
                Dim dtObs As DataTable = CarregarDataTable("Select R7.Codigo From R7 Left Join Comanda On Comanda.CodOrdens=R7.CodUser " & _
                " And Comanda.CodConfig=R7.CodConfig Where Comanda.CodComanda=" & Me.txtComan.Text & " And Comanda.Status='Aberto' " & _
                " And Comanda.CodConfig=" & CodConfig & " Group by R7.Codigo;")

                Dim intCodigo As Integer = 0

                If dtObs.Rows.Count > 0 Then
                    intCodigo = dtObs.Rows.Item(0).Item("Codigo").ToString
                End If


                Dim dtComanda As DataTable = CarregarDataTable("Select CodOrdens From Comanda Where CodComanda=" & Me.txtComan.Text & " And Status='Aberto' And Comanda.CodConfig=" & CodConfig & "")

                If dtComanda.Rows.Count > 0 Then
                    Dim Obs As String = Me.txtObs.Text().ToString().Trim().Replace("&", "E").Replace("'", "´")

                    If intCodigo <> 0 Then
                        Inserir("Update R7 set R7.COO='" & Obs & "', ValorEstorno = " & Num(Me.txtValorFrete.Text) & " Where Codigo=" & intCodigo & ";")
                    Else
                        Inserir("Insert Into R7 (CodUser, COO, CodConfig, ValorEstorno) Values(" & strCodigoOrdem & ",'" & Obs & "'," & CodConfig & "," & Num(Me.txtValorFrete.Text) & ");")
                    End If
                End If
                
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub txtComan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComan.GotFocus
        strComandaMesa = Me.txtComan.Text
    End Sub
    Private Sub txtComan_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComan.Leave
        If Me.txtComan.Text.Trim = "" Then Exit Sub
        If NomeEmpresa.Trim.Contains("UP HAIR") = True Then
            TrazCliente(Me.txtComan.Text.Trim, False)

            If Me.lblCli.Text.Trim = "" Then
                Me.txtComan.ResetText()
                MsgBox("Cliente não cadastrado no sistema!", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        LeaveComanda()
    End Sub
    Dim strComandaMesa As String = ""
    Dim bolTabela As Boolean = True
    Private Sub LeaveComanda()
        If Me.txtComan.Text.Trim = "" Then Exit Sub
     
        Me.txtComan.Text = Me.txtComan.Text.Replace("A", "")

        Dim dt As DataTable = CarregarDataTable("SELECT sum(Codigo), CodComanda, Status, Tipo, CodOrdens FROM Comanda where CodComanda = '" & Me.txtComan.Text.Trim & "' and CodConfig = " & CodConfig & " and Status <> 'Faturado' GROUP BY CodComanda, Status, Tipo, CodOrdens")
        If dt.Rows.Count > 0 Then

            strCodigoOrdem = dt.Rows.Item(0).Item("CodOrdens").ToString

            Dim dtTabela As DataTable = CarregarDataTable("SELECT top 1 TabelaPreco from Comanda where " & _
           "CodOrdens = " & strCodigoOrdem & " and CodConfig =" & CodConfig & " order by Codigo desc")

            If dtTabela.Rows.Count > 0 Then
                If dtTabela.Rows.Item(0).Item("TabelaPreco").ToString <> "" Then
                    bolTabela = False
                    Me.cboTabela.Text = dtTabela.Rows.Item(0).Item("TabelaPreco").ToString
                    bolTabela = True
                End If
            End If

            If dt.Rows.Item(0).Item("Tipo").ToString <> strTipoComanda Then
                'MsgBox("Número de Comanda/Pedido já está sendo utilizado!", MsgBoxStyle.Information)
                'Me.txtComan.ResetText()
                'Me.txtComan.Focus()
                
                CarregarItensComanda()
                Me.txtAte.Focus()
                Calcular()
                Exit Sub
            End If

            If dt.Rows.Item(0).Item("Status").ToString = "Fechado" Then
                Me.txtComan.ResetText()
                MsgBox(Me.colCodComanda.Caption & " fechado(a), não é possível alterar!", MsgBoxStyle.Information)
                Me.txtComan.Focus()
                CarregarDados("SELECT CodComanda FROM Comanda where CodComanda = '00'", Me.GridControl1)
                Exit Sub
            End If
            
            CarregarItensComanda()
            CarregarComandas()

            Dim dtCom As DataTable = CarregarDataTable("SELECT COO as Obs, ValorPago as Qtd, ValorEstorno as ValorFrete FROM R7 where CodUser = " & strCodigoOrdem & " and CodConfig = " & CodConfig)
            If dtCom.Rows.Count > 0 Then
                QtdePessoasMesa = dtCom.Rows.Item(0).Item("Qtd").ToString
                Me.txtObs.Text = dtCom.Rows.Item(0).Item("Obs").ToString
                If dtCom.Rows.Item(0).Item("ValorFrete").ToString <> "" Then
                    Dim dblFrete As Double = dtCom.Rows.Item(0).Item("ValorFrete").ToString
                    Me.txtValorFrete.Text = dblFrete.ToString("0.00")
                Else
                    Me.txtValorFrete.Text = "0,00"
                End If

            End If

            Calcular()
        Else
            Me.txtCodProd.ResetText()
            Me.txtQtd.ResetText()
            Me.txtObs.ResetText()
            LimpaAtendente()
            CarregarDados("SELECT CodComanda FROM Comanda where CodComanda = '00'", Me.GridControl1)
        End If
      
        bolLeave = True

        If Me.txtAte.Text = "" Then
            Me.txtAte.Focus()
        Else
            Me.txtCodProd.Focus()
        End If

    End Sub

    Private Sub LimpaAtendente()
        If Me.CheckEdit1.Checked = False Then

            If strComandaMesa <> Me.txtComan.Text And strComandaMesa <> "" Then
                Me.txtAte.ResetText()
                Me.lblAten.Text = ""
            End If

        End If
    End Sub
    Private Sub txtQtd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtd.KeyDown
        If TemBalanca = True Then
            If e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9 Then
                bolDigQtd = True
            ElseIf e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9 Then
                bolDigQtd = True
            ElseIf e.KeyCode = Keys.Back Then
                If Me.txtQtd.Text.Trim <> "" Then
                    If CDbl(Me.txtQtd.Text.Trim) = 0 Then Me.txtQtd.ResetText()
                    bolDigQtd = True
                Else
                    bolDigQtd = False
                End If
            End If
        End If

    End Sub
    Private Sub txtQtd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtd.Leave
        If Me.txtQtd.Text.Trim <> "" Then
            If CDbl(Me.txtQtd.Text.Trim) = 0 Then
                Me.txtQtd.Text = ""
            End If
        Else
            bolDigQtd = False
        End If
        
        Me.txtCodProd.Focus()
    End Sub

    Private Sub txtComanda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComanda.DoubleClick
        DiminuirSplit()

        LimparDados(True)

        If Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colStatus2) = "Fechado" Then
            MsgBox(Me.colCodComanda.Caption & " fechado(a), não é possível alterar!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim strCodComanda As String = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodComanda)
        Me.txtComan.Text = strCodComanda
        strCodigoOrdem = strCodComanda

        Dim dt As DataTable = CarregarDataTable("SELECT Mesa, CodOrdens from Comanda where Comanda.CodComanda = '" & Me.txtComan.Text.Trim & "' and Comanda.Status = 'Aberto' and " & _
        "Comanda.Tipo ='" & strTipoComanda & "' AND Comanda.CodConfig =" & CodConfig)
        strMesa = ""
        Dim strOrdens As String = ""
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Mesa").ToString <> "" Then
                strMesa = dt.Rows.Item(0).Item("Mesa").ToString
            End If
            strOrdens = dt.Rows.Item(0).Item("CodOrdens").ToString
        End If

        CarregarItensComanda()

        If intCodFunc <> 0 Then
            Me.txtAte.Text = intCodFunc
        Else
            Me.txtAte.ResetText()
        End If

        If Me.CheckEdit1.Checked = True Then
            Me.txtCodProd.Focus()
        Else
            Me.txtAte.Focus()
        End If

        Calcular()

        If Me.CheckEdit1.Checked = True Then
            Me.txtCodProd.Focus()
        Else
            Me.txtAte.Focus()
        End If
    End Sub

    Private Sub InserirProduto(ByVal parPesquisaPorNome As Boolean, ByVal parConsignacao As Boolean, Optional ByVal parTamanho As String = "")

        Dim dtProd As DataTable
        Dim strProduto, strUM, strGrupo, strTipo As String
        Dim dblValor As Double
        Dim bolMisto As Boolean = False
        Dim intNumCarac As Integer = 0

        If parPesquisaPorNome = False Then
            If Me.txtCodProd.Text.Trim = "" Then Exit Sub
            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Grupo, Tipo from Produto where Tipo <> 'CONSUMO' and CodigoInterno ='" & Me.txtCodProd.Text.Trim & "' or CodigoBarra ='" & Me.txtCodProd.Text.Trim & "'")
        Else
            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, CodigoInterno, Desconto, Grupo, Tipo from Produto where Codigo=" & CodigoDoProduto & " and Tipo <> 'CONSUMO'")
            If dtProd.Rows.Count > 0 Then
                Me.txtCodProd.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
            End If
        End If

        If dtProd.Rows.Count > 0 Then

            With dtProd.Rows.Item(0)
                Dim intCodProdAut As Integer

                intCodProdAut = .Item(0).ToString

                TamanhoDoProduto = "U"

                Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and CodConfig =" & CodConfig & " group by Tamanho"

                Dim dtQtd As DataTable = CarregarDataTable(strSql)


                Me.txtCodProd.Tag = intCodProdAut
                strProduto = .Item(1).ToString
                strUM = .Item(2).ToString
                dblValor = .Item(4)
                strGrupo = dtProd.Rows.Item(0).Item("Grupo").ToString
                strTipo = dtProd.Rows.Item(0).Item("Tipo").ToString


                If Me.cboTabela.Text <> "PADRÃO" Then
                    dblValor = ValorTabela(intCodProdAut, Me.cboTabela.Text)
                End If
              
                If bolMisto = True Then
                    If strTipo.Trim <> "RECEITA" Then
                        MsgBox("Produto não pode ser vendido de forma mista!", MsgBoxStyle.Information)
                        Me.txtCodProd.Tag = ""
                        Me.txtCodProd.ResetText()
                        Me.txtCodProd.Focus()
                        bolDigQtd = False
                        Exit Sub
                    End If
                End If

            End With
        Else
            strProduto = ""
            Me.txtCodProd.ResetText()
            Me.txtQtd.ResetText()
            strUM = ""
            dblValor = Nothing
            bolDigQtd = False
            MsgBox("Produto inexistente!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If strProduto = "DIVERSOS" And Me.txtCodProd.Text = "1" Then
            ValorUnitComanda = 0

            dblValor = Nothing
            frmValorComanda.Tag = "COMANDA"
            frmValorComanda.ShowDialog()
            If ValorUnitComanda > 0 Then
                InserirProdEnter(dtProd, ValorUnitComanda)
            End If

        Else
            'CALCULOS ANTES DE ADICIONAR

            Dim dblQtd, dblUni, dblCusto, dblTot, dblTotCus As Double

            If Me.txtQtd.Text.Trim <> "" Then
                dblQtd = Me.txtQtd.Text.Trim
            Else
                dblQtd = 1
            End If

            Dim dt As DataTable = CarregarDataTable("Select Codigo, Qtd, ValorCusto from Qtde where CodProd = " & Me.txtCodProd.Tag & " and Tamanho ='" & TamanhoDoProduto & "' and CodConfig =" & CodConfig & " order by Codigo asc")

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
                    dblCusto = dt.Rows.Item(0).Item("ValorCusto").ToString
                Else
                    dblCusto = dtProd.Rows.Item(0).Item(3).ToString
                End If

            Else
                dblCusto = dtProd.Rows.Item(0).Item(3).ToString
            End If


            dblUni = dblValor

            Dim dblPerDesc, dblResto As Double
            Dim bolPromocao As Boolean = False

            If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" Then
                dblPerDesc = dtProd.Rows.Item(0).Item("Desconto").ToString

                dblResto = (dblUni / 100) * dblPerDesc

                dblUni = dblUni - dblResto
                bolPromocao = True
            End If

            dblTot = dblQtd * dblUni
            dblTotCus = dblQtd * dblCusto


            Dim dtComanda As DataTable = CarregarDataTable("SELECT CodOrdens FROM Comanda where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status ='Aberto' AND Tipo ='" & strTipoComanda & "' and CodConfig =" & CodConfig)
            Dim intCodOrdens As Integer
            If dtComanda.Rows.Count > 0 Then
                intCodOrdens = dtComanda.Rows.Item(0).Item("CodOrdens").ToString
            Else
                intCodOrdens = GerarCodigo("Ordens", "Cod", CodConfig)
                Inserir("INSERT INTO Ordens(Cod, Tabela, CodConfig) VALUES (" & intCodOrdens & ",'Comanda'," & CodConfig & ")")
                If strTipoComanda <> "COMANDA" Then
                    Me.txtComan.Text = intCodOrdens
                End If
            End If
            strCodigoOrdem = intCodOrdens
            If strMesa = "" Then
                Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Produto, Qtd, " & _
                "ValorUnitario, Data, Status, CodConfig, Misto, CodFunc, CodCli, Tipo, ImpOk, Nome, TabelaPreco) VALUES (" & intCodOrdens & "," & _
                "'" & Me.txtComan.Text.Trim & "'," & Me.txtCodProd.Tag & ",'" & Me.txtCodProd.Text.Trim & "'," & _
                "'" & strProduto & "'," & Num(dblQtd) & "," & Num(dblUni) & ",'" & My.Computer.Clock.LocalTime & "'," & _
                "'" & "Aberto" & "'," & CodConfig & ",'" & bolMisto & "'," & Me.txtAte.Text.Trim & "," & intCodCli & "," & _
                "'" & strTipoComanda & "','False','" & Me.txtNome.Text.Trim & "','" & Me.cboTabela.Text.Trim & "')")
            Else
                Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Produto, Qtd, " & _
                "ValorUnitario, Data, Status, CodConfig, Misto, CodFunc, CodCli, Tipo, ImpOk, Nome, Mesa, TabelaPreco) VALUES (" & intCodOrdens & "," & _
                "'" & Me.txtComan.Text.Trim & "'," & Me.txtCodProd.Tag & ",'" & Me.txtCodProd.Text.Trim & "'," & _
                "'" & strProduto & "'," & Num(dblQtd) & "," & Num(dblUni) & ",'" & My.Computer.Clock.LocalTime & "'," & _
                "'" & "Aberto" & "'," & CodConfig & ",'" & bolMisto & "'," & Me.txtAte.Text.Trim & "," & intCodCli & "," & _
                "'" & strTipoComanda & "','False','" & Me.txtNome.Text.Trim & "','" & strMesa & "','" & Me.cboTabela.Text.Trim & "')")
            End If


            If strTipoComanda <> "COMANDA" Then
                Atualizar("Update Comanda set CodCli =" & intCodCli & ", Nome ='" & Me.txtNome.Text.Trim & "' Where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status = 'Aberto' and CodConfig = " & CodConfig)
            End If
            If CNPJEmpresa = "10302513000100" Then
                If ImprimeComanda = True Then
                    If strTipoComanda = "COMANDA" Then
                        EnviarImpressao(strGrupo, Me.txtCodProd.Text.Trim, strProduto, dblQtd.ToString("0.000"), False)
                    End If
                End If
            End If


            'Dim dtCom As DataTable = CarregarDataTable("SELECT Codigo FROM R7 where CodUser = " & strCodigoOrdem & " and CodConfig = " & CodConfig)
            'If dtCom.Rows.Count > 0 Then
            '    Atualizar("UPDATE R7 set COO = '" & Me.txtObs.Text & "' where CodUser = " & strCodigoOrdem & " and Codconfig = " & CodConfig)

            'Else
            '    Inserir("INSERT INTO R7 (CodUser, COO, CodConfig) VALUES (" & strCodigoOrdem & ",'" & Me.txtObs.Text & "'," & _
            '    "" & CodConfig & ")")

            'End If
            SalvarObservacao()

            'If ImprimeComanda = True Then
            '    If strTipoComanda = "COMANDA" Then
            '        EnviarImpressao(strGrupo, Me.txtCodProd.Text.Trim, strProduto, dblQtd.ToString("0.000"), False)
            '    End If
            'End If

            CarregarDadosTela()

            Me.txtCodProd.Tag = ""
            Me.txtCodProd.ResetText()
            Me.txtQtd.ResetText()
            Me.txtCodProd.Focus()
            bolDigQtd = False
            Calcular()
        End If
        
    End Sub


    Private Sub InserirProdEnter(ByVal dtProd As DataTable, ByVal parValor As Double)


        Dim strProduto, strUM, strGrupo, strTipo As String
        Dim dblValor As Double
        Dim bolMisto As Boolean = False
        Dim intNumCarac As Integer = 0

        'If parPesquisaPorNome = False Then
        '    If Me.txtCodProd.Text.Trim = "" Then Exit Sub
        '    dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Grupo, Tipo from Produto where Tipo <> 'CONSUMO' and CodigoInterno ='" & Me.txtCodProd.Text.Trim & "' or CodigoBarra ='" & Me.txtCodProd.Text.Trim & "'")
        'Else
        '    dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, CodigoInterno, Desconto, Grupo, Tipo from Produto where Codigo=" & CodigoDoProduto & " and Tipo <> 'CONSUMO'")
        '    If dtProd.Rows.Count > 0 Then
        '        Me.txtCodProd.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
        '    End If
        'End If

        If dtProd.Rows.Count > 0 Then

            With dtProd.Rows.Item(0)
                Dim intCodProdAut As Integer

                intCodProdAut = .Item(0).ToString

                TamanhoDoProduto = "U"

                Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and CodConfig =" & CodConfig & " group by Tamanho"

                Dim dtQtd As DataTable = CarregarDataTable(strSql)


                Me.txtCodProd.Tag = intCodProdAut
                strProduto = .Item(1).ToString
                strUM = .Item(2).ToString
                dblValor = parValor
                strGrupo = dtProd.Rows.Item(0).Item("Grupo").ToString
                strTipo = dtProd.Rows.Item(0).Item("Tipo").ToString

                If bolMisto = True Then
                    If strTipo.Trim <> "RECEITA" Then
                        MsgBox("Produto não pode ser vendido de forma mista!", MsgBoxStyle.Information)
                        Me.txtCodProd.Tag = ""
                        Me.txtCodProd.ResetText()
                        Me.txtCodProd.Focus()
                        bolDigQtd = False
                        Exit Sub
                    End If
                End If

            End With
        Else
            strProduto = ""
            Me.txtCodProd.ResetText()
            Me.txtQtd.ResetText()
            strUM = ""
            dblValor = Nothing
            bolDigQtd = False
            Exit Sub
        End If

  
        'CALCULOS ANTES DE ADICIONAR

        Dim dblQtd, dblUni, dblCusto, dblTot, dblTotCus As Double

        If Me.txtQtd.Text.Trim <> "" Then
            dblQtd = Me.txtQtd.Text.Trim
        Else
            dblQtd = 1
        End If

        Dim dt As DataTable = CarregarDataTable("Select Codigo, Qtd, ValorCusto from Qtde where CodProd = " & Me.txtCodProd.Tag & " and Tamanho ='" & TamanhoDoProduto & "' and CodConfig =" & CodConfig & " order by Codigo asc")

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
                dblCusto = dt.Rows.Item(0).Item("ValorCusto").ToString
            Else
                dblCusto = dtProd.Rows.Item(0).Item(3).ToString
            End If

        Else
            dblCusto = dtProd.Rows.Item(0).Item(3).ToString
        End If


        dblUni = dblValor

        Dim dblPerDesc, dblResto As Double
        Dim bolPromocao As Boolean = False

        If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" Then
            dblPerDesc = dtProd.Rows.Item(0).Item("Desconto").ToString

            dblResto = (dblUni / 100) * dblPerDesc

            dblUni = dblUni - dblResto
            bolPromocao = True
        End If

        dblTot = dblQtd * dblUni
        dblTotCus = dblQtd * dblCusto


        Dim dtComanda As DataTable = CarregarDataTable("SELECT CodOrdens FROM Comanda where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status ='Aberto' AND Tipo ='" & strTipoComanda & "' and CodConfig =" & CodConfig)
        Dim intCodOrdens As Integer
        If dtComanda.Rows.Count > 0 Then
            intCodOrdens = dtComanda.Rows.Item(0).Item("CodOrdens").ToString
        Else
            intCodOrdens = GerarCodigo("Ordens", "Cod", CodConfig)
            Inserir("INSERT INTO Ordens(Cod, Tabela, CodConfig) VALUES (" & intCodOrdens & ",'Comanda'," & CodConfig & ")")
            If strTipoComanda <> "COMANDA" Then
                Me.txtComan.Text = intCodOrdens
            End If
        End If

        Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Produto, Qtd, " & _
        "ValorUnitario, Data, Status, CodConfig, Misto, CodFunc, CodCli, Tipo, ImpOk, Nome) VALUES (" & intCodOrdens & "," & _
        "'" & Me.txtComan.Text.Trim & "'," & Me.txtCodProd.Tag & ",'" & Me.txtCodProd.Text.Trim & "'," & _
        "'" & strProduto & "'," & Num(dblQtd) & "," & Num(dblUni) & ",'" & My.Computer.Clock.LocalTime & "'," & _
        "'" & "Aberto" & "'," & CodConfig & ",'" & bolMisto & "'," & Me.txtAte.Text.Trim & "," & intCodCli & "," & _
        "'" & strTipoComanda & "','False','" & Me.txtNome.Text.Trim & "')")

        If strTipoComanda <> "COMANDA" Then
            Atualizar("Update Comanda set CodCli =" & intCodCli & ", Nome ='" & Me.txtNome.Text.Trim & "' Where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status = 'Aberto' and CodConfig = " & CodConfig)
        End If

        'If ImprimeComanda = True Then
        '    If strTipoComanda = "COMANDA" Then
        '        EnviarImpressao(strGrupo, Me.txtCodProd.Text.Trim, strProduto, dblQtd.ToString("0.000"), False)
        '    End If
        'End If

        CarregarDadosTela()

        Me.txtCodProd.Tag = ""
        Me.txtCodProd.ResetText()
        Me.txtQtd.ResetText()
        Me.txtCodProd.Focus()
        bolDigQtd = False
        Calcular()


    End Sub
    Private Sub LimparTxtNum()
        strProdutoFinal = ""
        strCodAutMaior = ""
        strCodInterMaior = ""
        dblMaiorValor = 0
        intCont = 0
    End Sub
    Private Sub Calcular()
        Dim I As Integer
        Dim dblVal, dblResul, dblTaxa, dblGeral As Double

        Dim dblResulTaxa As Double

        For I = 0 To Me.grd1.RowCount - 1
            dblVal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblResul += dblVal

            If Me.grd1.GetRowCellDisplayText(I, Me.colGrupo) <> "SEM DEZ PORCENTO" Then
                dblResulTaxa += dblVal
            End If
        Next

        If DezPorcento = True Then
            If strTipoComanda = "COMANDA" Then
                dblTaxa = ((dblResulTaxa / 100) * 10)
            End If
        End If
        Dim dblFrete As Double = 0
        If Me.txtValorFrete.Text <> "" Then
            dblFrete = Me.txtValorFrete.Text
        End If
        dblGeral = dblResul + dblTaxa + dblFrete

        Me.txtValorTotal.Text = dblResul.ToString("0.00")
        Me.txtTaxa.Text = dblTaxa.ToString("0.00")
        Me.txtGeral.Text = dblGeral.ToString("0.00")

    End Sub

    Private Sub txtCodProd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProd.KeyDown

        If e.KeyCode = Keys.F10 Then
            If strTipoComanda = "COMANDA" Then
                If Validar(Me.txtComan) = False Then Exit Sub
            End If
            If Validar(Me.txtAte) = False Then Exit Sub
          
            Dim frm As New frmConProduto
            frm.Tag = "VENDA"
            CodigoDoProduto = -1
            CodigoDoProdutoAgrupado = ""
            QtdeDoProduto = 0
            frm.ShowDialog()
            'If CodigoDoProduto = -1 Then Exit Sub
            If CodigoDoProdutoAgrupado <> "" Then
                Dim I As Integer
                Dim vetProd As Array = Split(CodigoDoProdutoAgrupado, "|")

                For I = 0 To vetProd.Length - 1
                    Dim vetCodProd As Array = Split(vetProd(I), "%")
                    CodigoDoProduto = vetCodProd(0)
                    'If Me.txtQtd.Text = "" Then
                    Me.txtQtd.Text = vetCodProd(1)
                    'End If

                    'InserirProduto(True, False, "", Me.lblTabela.Caption)
                    InserirProduto(True, False)
                    QtdeDoProduto = 0
                    CodigoDoProduto = -1
                Next
            End If

        End If

        If e.KeyCode = Keys.Space Then
            If Me.txtCodProd.Text = "" Then
                ConsultaProduto()
                Timer3.Start()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            If bolConsultaProduto = True Then
                If strTipoComanda = "COMANDA" Then
                    If Validar(Me.txtComan) = False Then Exit Sub
                End If
                If Validar(Me.txtAte) = False Then Exit Sub

                Dim frm As New frmConProduto
                frm.strFiltroProduto = Me.txtCodProd.Text
                frm.Tag = "VENDA"
                QtdeDoProduto = 0
                CodigoDoProduto = -1
                CodigoDoProdutoAgrupado = ""
                frm.ShowDialog()
                If CodigoDoProduto = -1 Then Exit Sub
                InserirProduto(True, False)
            Else
                If strTipoComanda = "COMANDA" Then
                    If Validar(Me.txtComan) = False Then Exit Sub
                End If

                If Validar(Me.txtAte) = False Then Exit Sub

                If Me.txtCodProd.Text.Trim = "" Then
                    Me.txtQtd.Focus()
                    Exit Sub
                End If
                InserirProduto(False, False)
            End If
        End If
    End Sub

    Private Sub CarregarDadosTela()
        CarregarItensComanda()
        CarregarComandas()
    End Sub

    Private Sub CarregarComandas()
        'CarregarDados("SELECT Sum(Comanda.Codigo), Comanda.CodComanda, Comanda.Status, Case When Comanda.Nome is not null Then Comanda.Nome Else Cliente.Nome End As Nome FROM Comanda Left Join Cliente on Comanda.codCli = Cliente.codigo Where Comanda.Status <> 'Faturado' AND Comanda.Tipo ='" & strTipoComanda & "' AND Comanda.CodConfig =" & CodConfig & " Group By Comanda.CodComanda, Comanda.Status, Comanda.Nome, Cliente.Nome", Me.GridControl2)
        CarregarDados("SELECT Sum(Comanda.Codigo), Comanda.CodComanda, Comanda.Status, Case When Comanda.Nome is not null Then Comanda.Nome Else Cliente.Nome End As Nome, R7.COO as Obs FROM (Comanda Left Join Cliente on Comanda.codCli = Cliente.codigo) left join R7 on r7.CodUser=Comanda.CodOrdens Where Comanda.Status <> 'Faturado' AND Comanda.Tipo ='" & strTipoComanda & "' AND Comanda.CodConfig =" & CodConfig & " Group By Comanda.CodComanda, Comanda.Status, Comanda.Nome, Cliente.Nome, R7.COO", Me.GridControl2)
    End Sub

    Private Sub CarregarItensComanda()
      

        CarregarDados("SELECT Comanda.Codigo, Comanda.CodOrdens, Comanda.CodComanda, Comanda.CodProd, " & _
        "Comanda.CodProdInterno, Comanda.Produto, Comanda.Qtd, Comanda.ValorUnitario, " & _
        "Convert(Varchar(5),Comanda.Data,114) as Data, Comanda.Status, convert(Numeric(15,2),(Comanda.Qtd * Comanda.ValorUnitario)) as ValorTotal, " & _
        "Comanda.Misto, Comanda.CodCli, Comanda.Opcoes, Comanda.Obs, Comanda.Entregador, Comanda.Troco, Comanda.Tempo, " & _
        "Produto.Grupo, Comanda.CodFunc, Comanda.Mesa FROM Comanda left join Produto on Comanda.CodProd = Produto.Codigo where " & _
        "Comanda.CodComanda = '" & Me.txtComan.Text.Trim & "' and Comanda.Status = 'Aberto' and " & _
        "Comanda.Tipo ='" & strTipoComanda & "' AND Comanda.CodConfig =" & CodConfig, Me.GridControl1)
        If Me.grd1.RowCount = 0 Then Exit Sub
        TrazCliente(Me.grd1.GetRowCellDisplayText(0, Me.colCodCli).Trim, False)
        Me.cboEnt.Text = Me.grd1.GetRowCellDisplayText(0, Me.colEntregador)

        Dim dblTroco As Double = 0

        If Me.grd1.GetRowCellDisplayText(0, Me.colTroco).Trim <> "" Then
            dblTroco = Me.grd1.GetRowCellDisplayText(0, Me.colTroco)
        End If

        Me.txtTroco.Text = dblTroco.ToString("0.00")
        Me.cboTempo.Text = Me.grd1.GetRowCellDisplayText(0, Me.colTempo)

    End Sub
    Public Shared Function ListaBytesParaString(ByVal lista As Byte()) As String
        Dim retornoChar As Char() = New Char(lista.Length - 1) {}
        For i As Integer = 0 To lista.Length - 1
            retornoChar(i) = ChrW(lista(i))
        Next
        Dim retorno As New String(retornoChar)
        Return retorno
    End Function
    Dim PortaAberta As Boolean = False
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If AtualizarComanda = True Then
            LimparDados(True)
            Me.txtComan.ResetText()
            CarregarComandas()
            AtualizarComanda = False
        End If


        If TemBalanca = True Then
            If PortaAberta = False Then
                If clsToledoPrix.AbrePorta(PortaBalanca, BaudRateBalanca, DataBitsBalanca, ParidadeBalanca) = 1 Then
                    PortaAberta = True
                End If
            End If
            If bolDigQtd = True Then Exit Sub

            Dim DadosPeso As Byte() = New Byte(5) {}  '5 bytes + nulo
            Dim Caminho As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)

            If clsToledoPrix.PegaPeso(0, DadosPeso, Caminho) = 1 Then
                Me.lblStatus.Text = ""
                Dim strPeso As String = ListaBytesParaString(DadosPeso)
                Dim strDec, strInt As String
                strInt = Mid(strPeso, 1, 2)
                strDec = Mid(strPeso, 3, 5)
                strPeso = strInt & "," & strDec

                Dim dblPeso As Double = strPeso

                If dblPeso > 0 Then
                    Me.txtQtd.Text = dblPeso.ToString("0.000")
                Else
                    If bolDigQtd = False Then
                        Me.txtQtd.ResetText()
                    End If
                End If

            Else
                Me.lblStatus.Text = "Lendo Balança..."
            End If
        End If
    End Sub

    Private Sub frmComanda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If TemBalanca = True Then
            If PortaAberta = True Then
                clsToledoPrix.FechaPorta()
                PortaAberta = False
            End If
        End If
    End Sub

    Private Sub frmComanda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.btnComanda.Checked = True
        End If
        If e.KeyCode = Keys.F3 Then
            Me.btnEntrega.Checked = True
        End If
        If e.KeyCode = Keys.F4 Then
            Me.btnRetirar.Checked = True
        End If
        If BloquearVenda = False Then
            If e.KeyCode = Keys.F5 Then
                Vender()
            End If
        End If
      
        If e.KeyCode = Keys.F11 Then
            Montar()
        End If
        If e.KeyCode = Keys.F12 Then
            LimparComandaMesa()
        End If
    End Sub

    Private Sub LimparComandaMesa()
        EnviarImpressao2()
        SalvarObservacao()
        Tipo(strTipoComanda)
    End Sub

    Private Sub frmComanda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If SkinDoUsuario = "Blue" Or SkinDoUsuario = "Money Twins" Then
            Me.cboTabela.BackColor = Color.AliceBlue

        Else
            Me.cboTabela.BackColor = Color.WhiteSmoke

        End If
        Me.cboTabela.Visible = True


        If TemBalanca = True Then
            Try
                clsToledoPrix.FechaPorta()
            Catch ex As Exception
            End Try
        End If
        Me.btnComanda.Checked = True

        Dim I As Integer

        Dim dtGrupo As DataTable = CarregarDataTable("SELECT PortaImpressora, Impressora FROM grupo where PortaImpressora<>'' group by PortaImpressora, Impressora")
        Me.cboImpressora.Items.Add(PortaImpressora & " | " & Impressora)
        For I = 0 To dtGrupo.Rows.Count - 1
            Me.cboImpressora.Items.Add(dtGrupo.Rows.Item(I).Item("PortaImpressora").ToString & " | " & dtGrupo.Rows.Item(I).Item("Impressora").ToString)
        Next


        Dim dt As DataTable = CarregarDataTable("Select Nome From Funcionario where Funcao ='ENTREGADOR' and Ativo ='True'")


        For I = 0 To dt.Rows.Count - 1
            Me.cboEnt.Properties.Items.Add(dt.Rows.Item(I).Item("Nome").ToString)
        Next
        If Nivel = "USUÁRIO" Then
            Me.btnVender.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If NomeEmpresa.ToUpper.Contains("CASA DO ÓLEO") = True Then
            Me.Text = "Elevadores"
            Me.colCodComanda.Caption = "Elevador"
            Me.grcItens.Text = "Itens do Elevador"
            Me.lblComanda.Text = "Elevador"
            Me.btnComanda.Text = "Elevador F2"
        End If

        ConfigurarGrid(Me.grd2, Me, True, Me.btnPadrao)

        If Me.btnPadrao.Enabled = True Then
            bolManter = True
            If Me.GridColumn1.Visible = True Then
                AlmentarSplit()
            End If
        Else
            bolManter = False
        End If

        PreencherCombo2("Select Grupo.Nome From Grupo Inner Join TabelaPreco on Grupo.Codigo = TabelaPreco.CodTabela Where " & _
    "Grupo.Tipo ='T' Group by Grupo.Nome, Grupo.Codigo Order by Grupo.Codigo", Me.cboTabela, 0, "PADRÃO")

        If TabelaPreco <> "" Then
            Dim dtTab As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Tipo = 'T' and Nome = '" & TabelaPreco & "'")
            If dtTab.Rows.Count > 0 Then
                Me.cboTabela.Text = TabelaPreco
            Else
                Me.cboTabela.Text = "PADRÃO"
            End If
        Else
            Me.cboTabela.Text = "PADRÃO"
        End If

        If BloquearVenda = True Then
            Me.btnVender.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        Me.Timer1.Start()
        Me.Timer4.Start()
    End Sub

    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If Me.grd2.RowCount = 0 Then Exit Sub
        Dim strComanda As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodComanda)
        Dim strAntigo As String = "Comanda " & strComanda
        If strComanda = "" Then
            MsgBox("Selecione o(a)" & Me.colCodComanda.Caption & " a ser excluída!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Deseja realmente excluir o(a) " & Me.colCodComanda.Caption & "   " & strComanda & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If SenhaEstaOK() = False Then Exit Sub
            Excluir("DELETE FROM Comanda where CodComanda = '" & strComanda & "' and Status = 'Aberto' and CodConfig = " & CodConfig)
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','EXCLUÍDO','COMANDA','COMANDA','EXCLUSÃO'," & CodConfig & ")")
            CarregarComandas()
            If Me.txtComan.Text = strComanda Then
                Me.txtComan.ResetText()
                LimparDados(True)
            End If
            Me.txtValorTotal.ResetText()
            Me.txtComan.Focus()
        End If
    End Sub

    Private Sub btnDelItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelItem.ItemClick
        'If Me.grd1.RowCount = 0 Then Exit Sub
        'If Validar(Me.txtComan) = False Then Exit Sub
        'Dim strProduto As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
        'Dim strComanda As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodComanda1)
        'If strComanda = "" Then
        '    MsgBox("Selecione o item da comanda a ser excluído!", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'Dim strAntigo As String = strProduto & " da comanda " & strComanda
        'Dim intCodigo As Integer = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        'If MsgBox("Deseja realmente excluir o item " & strProduto & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    If SenhaEstaOK() = False Then Exit Sub
        '    Excluir("DELETE FROM Comanda where Codigo = " & intCodigo & " and CodConfig = " & CodConfig)
        '    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','EXCLUÍDO','COMANDA','COMANDA','EXCLUSÃO'," & CodConfig & ")")

        '    CarregarDadosTela()

        '    If Me.grd1.RowCount = 0 Then
        '        Me.txtComan.ResetText()
        '        Me.txtComan.Focus()
        '        Me.txtValorTotal.ResetText()
        '        Exit Sub
        '    End If
        '    Calcular()
        'End If

        If Me.grd1.RowCount = 0 Then Exit Sub
        If Validar(Me.txtComan) = False Then Exit Sub
        Dim strProduto As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
        Dim strComanda As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodComanda1)
        If strComanda = "" Then
            MsgBox("Selecione o item da comanda a ser excluído!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim strAntigo As String = strProduto & " da comanda " & strComanda
        Dim intCodigo As Integer = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)

        If MsgBox("Deseja realmente excluir o item " & strProduto & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If SenhaEstaOK() = False Then Exit Sub

            Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colQtd)
            Dim strCodProduto As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProd)
            strProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)

            If dblQtd > 1 Then
                QtdeExcluida = 0
                Dim frm As New frmTamanhoProd
                frm.Tag = "QTDE"
                frm.dblQtdVenda = dblQtd
                frm.ShowDialog()
                If QtdeExcluida > 0 Then
                    dblQtd = dblQtd - QtdeExcluida
                    If dblQtd = 0 Then
                        Me.grd1.DeleteRow(grd1.FocusedRowHandle)

                        Excluir("DELETE FROM Comanda where Codigo = " & intCodigo & " and CodConfig = " & CodConfig)
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
                        "VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','EXCLUÍDO','COMANDA'," & _
                        "'COMANDA','EXCLUSÃO'," & CodConfig & ")")
                    Else
                        Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colQtd, dblQtd.ToString("0.000"))

                        Atualizar("UPDATE Comanda SET Qtd=" & dblQtd & " where Codigo = " & intCodigo & " and CodConfig = " & CodConfig)
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
                        "VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strProduto & "'," & _
                        "'Cód. Prod.: " & strCodProduto & " Qtde: " & dblQtd & "','COMANDA','COMANDA','EXCLUSÃO'," & CodConfig & ")")
                    End If

                    
                    CarregarDadosTela()

                    If Me.grd1.RowCount = 0 Then
                        Me.txtComan.ResetText()
                        Me.txtComan.Focus()
                        Me.txtValorTotal.ResetText()
                        Exit Sub
                    End If
                    Calcular()
                End If

            Else
                Excluir("DELETE FROM Comanda where Codigo = " & intCodigo & " and CodConfig = " & CodConfig)
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
                "VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','EXCLUÍDO','COMANDA'," & _
                "'COMANDA','EXCLUSÃO'," & CodConfig & ")")

                Me.grd1.DeleteRow(grd1.FocusedRowHandle)
                CarregarDadosTela()

                If Me.grd1.RowCount = 0 Then
                    Me.txtComan.ResetText()
                    Me.txtComan.Focus()
                    Me.txtValorTotal.ResetText()
                    Exit Sub
                End If
                Calcular()
            End If
        End If

    End Sub
    Private Sub Finalizar(ByVal parVender As Boolean)
        If Validar(Me.txtComan) = False Then Exit Sub
        'If strTipoComanda = "ENTREGAR" Then
        '    If Validar(Me.cboEnt) = False Then Exit Sub
        '    If Validar(Me.txtTroco) = False Then Exit Sub
        '    If Validar(Me.cboTempo) = False Then Exit Sub
        'End If

        Dim dblTro As Double = 0

        If Me.txtTroco.Text.Trim <> "" Then
            dblTro = Me.txtTroco.Text.Trim
        End If
       

        If MsgBox("Deseja realmente finalizar o(a) " & Me.colCodComanda.Caption & "   " & Me.txtComan.Text.Trim & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Atualizar("Update Comanda Set Status ='Fechado', Entregador ='" & Me.cboEnt.Text.Trim & "', " & _
            "Troco =" & Num(dblTro.ToString("0.00")) & ", Tempo ='" & Me.cboTempo.Text.Trim & "', APP = 'True' where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status = 'Aberto' and CodConfig = " & CodConfig)
            QtdePessoasMesa = "0"
            Dim dtComanda As DataTable = CarregarDataTable("SELECT Codigo, ValorPago FROM R7 where CodUser = " & strCodigoOrdem & " and CodConfig = " & CodConfig)
            If dtComanda.Rows.Count > 0 Then
                If dtComanda.Rows.Item(0).Item("ValorPago").ToString <> "" Then
                    QtdePessoasMesa = CInt(dtComanda.Rows.Item(0).Item("ValorPago"))
                End If
            End If

            Dim frm As New frmTamanhoProd
            frm.Tag = "COMANDA"
            frm.ShowDialog()
      

            If dtComanda.Rows.Count > 0 Then
                Atualizar("UPDATE R7 set COO = '" & Me.txtObs.Text & "', ValorPago = " & Num(QtdePessoasMesa) & ", ValorEstorno = " & Num(Me.txtValorFrete.Text) & " where CodUser = " & strCodigoOrdem & " and Codconfig = " & CodConfig)

            Else
                Inserir("INSERT INTO R7 (CodUser, COO, ValorPago, CodConfig, ValorEstorno) VALUES (" & strCodigoOrdem & ",'" & Me.txtObs.Text & "'," & _
                "" & Num(QtdePessoasMesa) & "," & CodConfig & "," & Num(Me.txtValorFrete.Text) & ")")

            End If

            'If parVender = False Then
            If ImprimeComanda = True Then
                Imprimir()
            End If
            'End If
            strMesa = ""
            intCodigoComanda = Me.txtComan.Text.Trim
            CarregarComandas()
            LimparDados(True)

        End If
    End Sub
    Private Sub btnFinalizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFinalizar.ItemClick
        Finalizar(False)
       
    End Sub

    Private Sub btnReabrir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReabrir.ItemClick

        If Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colStatus2) = "Aberto" Then
            Exit Sub
        End If

        Dim strComanda As String = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodComanda)

        If MsgBox("Deseja realmente reabrir o(a) " & Me.colCodComanda.Caption & "   " & strComanda & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If SenhaEstaOK() = False Then Exit Sub
            Atualizar("Update Comanda Set Status ='Aberto' where CodComanda = '" & strComanda & "' and Status = 'Fechado' and CodConfig = " & CodConfig)
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & "Fechado" & "','Aberto','COMANDA','COMANDA','REABERTURA'," & CodConfig & ")")
            CarregarComandas()
            LimparDados(True)
            Me.txtComan.Focus()
        End If
    End Sub

    Private Sub EnviarImpressao(ByVal parGrupo As String, ByVal parCod As String, ByVal parProd As String, ByVal parQtd As String, ByVal parMisto As Boolean)
        If TemImpressora = False Then Exit Sub

        Dim strPorta As String = ""
        Dim strModImpressora As String = Impressora
        Dim dtGru As DataTable = CarregarDataTable("Select PortaImpressora, Impressora from Grupo where Nome ='" & parGrupo & "'")

        If dtGru.Rows.Count > 0 Then
            strPorta = dtGru.Rows.Item(0).Item("PortaImpressora").ToString
            If dtGru.Rows.Item(0).Item("Impressora").ToString <> "" Then
                strModImpressora = dtGru.Rows.Item(0).Item("Impressora").ToString
            End If


        Else
            Exit Sub
        End If

        If strPorta.Trim = "" Then
            MsgBox("O Grupo/Setor " & parGrupo & " não está com a porta de impressão configurada!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If strModImpressora.Contains("ESC/POS") = True Then

            Dim strImpressao As String

            strIgual = CompComanda("=======================================================", strModImpressora)
            strTraco = CompComanda("-------------------------------------------------------", strModImpressora)

            strImpressao = CentralizarComanda(NegComanda(NomeEmpresa.ToString.Trim, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
            strImpressao &= strIgual & vbCrLf & vbCrLf

            strImpressao &= CentralizarComanda(ExpComanda(Me.colCodComanda.Caption & ": " & Me.txtComan.Text.Trim, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
            strImpressao &= strIgual & vbCrLf

            strImpressao &= Dir("CODIGO                                              QTD", 55) & vbCrLf
            strImpressao &= "DESCRICAO                                              " & vbCrLf

            strImpressao &= strTraco & vbCrLf

            strImpressao &= Dir(parCod, 20) & Esq(parQtd, 35) & vbCrLf

            If parMisto = True Then
                Dim P As Integer

                Dim vetProd As Array = Split(parProd, "|")

                parProd = ""

                For P = 0 To vetProd.Length - 1
                    If vetProd(P).ToString <> "" Then
                        parProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                    End If
                Next
                parProd = Mid(parProd, 1, parProd.Length - 3)
            End If

            strImpressao &= Dir(parProd, 55) & vbCrLf


            If parMisto = True Then

                Dim P As Integer

                If ListaOpcoes.Trim <> "" Then

                    Dim strOpci As String = ListaOpcoes

                    Dim vetOpc As Array = Split(strOpci, "|")

                    For P = 0 To vetOpc.Length - 1
                        strOpci = vetOpc(P).ToString
                        strImpressao &= Dir(strOpci, 55) & vbCrLf
                    Next

                End If

                If ObsOpcoes <> "" Then
                    strImpressao &= Dir("OBSERVAÇÃO: " & ObsOpcoes, 55) & vbCrLf
                End If


            End If

            strImpressao &= strTraco & vbCrLf

            strImpressao &= CentralizarComanda(My.Computer.Clock.LocalTime, strModImpressora) & vbCrLf

            RodapeComanda(strImpressao, strModImpressora, strPorta)

        ElseIf strModImpressora.Contains("BEMATECH") Or strModImpressora.Contains("ARQUIVO") Or strModImpressora.Contains("NANO PRINT") Then
            Dim strImpressao As String

            Dim intTamEsp As Integer
            Dim strEstrela, strTraço As String

            intTamEsp = 42
            strEstrela = "******************************************"
            strTraço = "------------------------------------------"

            strImpressao = Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf & vbCrLf

            strImpressao &= strEstrela & vbCrLf & vbCrLf
            strImpressao &= Cent(Me.colCodComanda.Caption & ": " & Me.txtComan.Text.Trim, intTamEsp) & vbCrLf & vbCrLf
            strImpressao &= strEstrela & vbCrLf

            strImpressao &= "CODIGO                                 QTD" & vbCrLf
            strImpressao &= "DESCRICAO                                 " & vbCrLf

            strImpressao &= strTraço & vbCrLf

            strImpressao &= Dir(parCod, 20) & Esq(parQtd, 22) & vbCrLf

            If parMisto = True Then
                Dim P As Integer

                Dim vetProd As Array = Split(parProd, "|")

                parProd = ""

                For P = 0 To vetProd.Length - 1
                    If vetProd(P).ToString <> "" Then
                        parProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                    End If
                Next
                parProd = Mid(parProd, 1, parProd.Length - 3)
            End If

            strImpressao &= parProd & vbCrLf


            If parMisto = True Then

                Dim P As Integer

                If ListaOpcoes.Trim <> "" Then

                    Dim strOpci As String = ListaOpcoes

                    Dim vetOpc As Array = Split(strOpci, "|")

                    For P = 0 To vetOpc.Length - 1
                        strOpci = vetOpc(P).ToString
                        strImpressao &= "Opc. " & P + 1 & ": " & strOpci & vbCrLf
                    Next

                End If

                If ObsOpcoes <> "" Then
                    strImpressao &= "OBSERVAÇÃO: " & ObsOpcoes & vbCrLf
                End If


            End If


            strImpressao &= strTraço & vbCrLf

            strImpressao &= Cent(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            If strModImpressora = "ARQUIVO" Then
                strImpressao += Avanco() & vbCrLf

                If TemGuilhotina = True Then
                    strImpressao += Corte() & vbCrLf
                End If
                SendStringToPrinter(strPorta, strImpressao)

                ''EscreveArquivo(strPorta & "\" & My.Computer.Name & ".txt", strImpressao)
                'ImprimiArquivo(strImpressao, strPorta)
            ElseIf strModImpressora.Contains("NANO PRINT") = True Then
                If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                    ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                Else
                    EscreveArquivo(strPorta & "\" & My.Computer.Name & ".txt", strImpressao)
                End If
            Else
                If strModImpressora.Contains("MP-4000") Then
                    iRetorno = ConfiguraModeloImpressora(5)
                    iRetorno = SelecionaQualidadeImpressao(3)
                Else
                    iRetorno = ConfiguraModeloImpressora(1)
                End If
                iRetorno = clsBematech.IniciaPorta(strPorta)


                iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If
            End If

        ElseIf strModImpressora = "EPSON" Then
            Dim strImpressao As String

            Dim intTamEsp As Integer
            Dim strEstrela, strTraço As String

            strEstrela = clsImprimir.Comp("************************************************")
            strTraço = clsImprimir.Comp("------------------------------------------------")

            strImpressao = "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf & vbCrLf

            strImpressao &= strEstrela & vbCrLf & vbCrLf
            strImpressao &= "<ce>" & Me.colCodComanda.Caption & ": " & Me.txtComan.Text.Trim & "</ce>" & vbCrLf & vbCrLf
            strImpressao &= strEstrela & vbCrLf

            strImpressao &= "CODIGO                                 QTD" & vbCrLf
            strImpressao &= "DESCRICAO                                 " & vbCrLf

            strImpressao &= strTraço & vbCrLf

            strImpressao &= Dir(parCod, 37) & Esq(parQtd, 11) & vbCrLf

            If parMisto = True Then
                Dim P As Integer

                Dim vetProd As Array = Split(parProd, "|")

                parProd = ""

                For P = 0 To vetProd.Length - 1
                    If vetProd(P).ToString <> "" Then
                        parProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                    End If
                Next
                parProd = Mid(parProd, 1, parProd.Length - 3)
            End If

            strImpressao &= parProd & vbCrLf


            If parMisto = True Then

                Dim P As Integer

                If ListaOpcoes.Trim <> "" Then

                    Dim strOpci As String = ListaOpcoes

                    Dim vetOpc As Array = Split(strOpci, "|")

                    For P = 0 To vetOpc.Length - 1
                        strOpci = vetOpc(P).ToString
                        strImpressao &= "Opc. " & P + 1 & ": " & strOpci & vbCrLf
                    Next

                End If

                If ObsOpcoes <> "" Then
                    strImpressao &= "OBSERVAÇÃO: " & ObsOpcoes & vbCrLf
                End If


            End If


            strImpressao &= strTraço & vbCrLf

            strImpressao &= "<ce>" & My.Computer.Clock.LocalTime & "</ce>" & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")



            iRetorno = clsEpson.IniciaPorta(strPorta)

            iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

            If TemGuilhotina = True Then
                iRetorno = clsEpson.AcionaGuilhotina(1)
            End If

            iRetorno = clsEpson.FechaPorta()

        End If
    End Sub

    Private Sub btnPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Imprimir()
    End Sub

    Private Sub Imprimir()

        If TemImpressora = False Then Exit Sub

        Dim strImp As String = Me.cboImp.EditValue
        If strImp = "" Then MsgBox("Selecione a impressora!", MsgBoxStyle.Information) : Exit Sub

        Dim vetImp As Array = Split(strImp, " | ")
        Dim strPorta As String = vetImp(0)
        Dim strImpressora As String = vetImp(1)

        If strImpressora.Contains("ESC/POS") = True Then
            Dim strImpressao As String


            strImpressao = Cabecalho()

            strImpressao &= Esq(My.Computer.Clock.LocalTime, 55) & vbCrLf & vbCrLf

            strImpressao &= CentralizarComanda(ExpComanda(Me.colCodComanda.Caption.ToUpper & ": " & Me.txtComan.Text.Trim, strImpressora), strImpressora) & vbCrLf
            strImpressao &= strTraco & vbCrLf

            If Me.lblCli.Text <> "CONSUMIDOR" Then
                strImpressao &= Dir("Cliente.: " & Me.lblCli.Text, 55) & vbCrLf
                strImpressao &= Dir("Endereco: " & Me.lblEnd.Text, 55) & vbCrLf
                strImpressao &= Dir("Telefone: " & Me.txtTel.Text, 55) & vbCrLf
                strImpressao &= strTraco & vbCrLf
            End If

            strImpressao &= Dir("CÓDIGO    DESCRICAO", 55) & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$                   VL TOTAL R$", 55) & vbCrLf
            strImpressao &= strTraco & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            Dim strCodFunc As String = ""
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdInterno)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")
                strCodFunc = Me.grd1.GetRowCellDisplayText(L, Me.colCodFunc)
                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

                Dim P As Integer = 0

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                Dim strItem As String

                strItem = strCod & "   " & strProd & "   (" & strCodFunc & ")"

                If strItem.Length > 55 Then
                    strItem = Mid(strItem, 1, 55)
                End If

                strImpressao &= Dir(strItem, 55) & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 44) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

                        Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= Dir(strOpci, 55) & vbCrLf
                        Next

                    End If

                    If Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim <> "" Then
                        strImpressao &= Dir("OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim, 55) & vbCrLf
                    End If

                    strImpressao &= strTraco.Replace("-", ".") & vbCrLf
                End If

            Next

            strImpressao &= strTraco & vbCrLf
            If DezPorcento = True Then
                If strTipoComanda = "COMANDA" Then
                    strImpressao &= Esq("Total........: R$ ", 45) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
                    If Me.txtValorFrete.Text <> "" Then
                        Dim dblFrete As Double = Me.txtValorFrete.Text
                        If dblFrete > 0 Then
                            strImpressao &= Esq("Total Frete..: R$ ", 45) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                        End If
                    End If
                    strImpressao &= Esq("Taxa 10%.....: R$ ", 45) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
                End If
            Else
                If Me.txtValorFrete.Text <> "" Then
                    Dim dblFrete As Double = Me.txtValorFrete.Text
                    If dblFrete > 0 Then
                        strImpressao &= Esq("Total........: R$ ", 45) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
                        strImpressao &= Esq("Total Frete..: R$ ", 45) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                    End If
                End If
            End If

            strImpressao &= Esq("Total Geral..: R$ ", 45) & Esq(Me.txtGeral.Text.Trim, 10) & vbCrLf

            strImpressao &= " " & vbCrLf


            If QtdePessoasMesa <> "0" And QtdePessoasMesa <> "" Then
                strImpressao &= Dir("Qtde Pessoas: " & QtdePessoasMesa, 55) & vbCrLf
                Dim dblValorPessoa As Double = CDbl(Me.txtGeral.Text) / CDbl(QtdePessoasMesa)
                strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If Me.txtObs.Text <> "" Then
                strImpressao &= "OBSERVAÇÃO: " & Me.txtObs.Text & vbCrLf
                strImpressao &= " " & vbCrLf
            End If

            If strTipoComanda = "ENTREGAR" Then
                strImpressao &= strTraco & vbCrLf
                strImpressao &= Dir("DODOS DE ENTREGA", 55) & vbCrLf
                strImpressao &= Dir("Entregador: " & Me.cboEnt.Text.Trim, 55) & vbCrLf
                strImpressao &= Dir("Troco R$..: " & Me.txtTroco.Text.Trim, 55) & vbCrLf
                strImpressao &= Dir("Tempo.....: " & Me.cboTempo.Text.Trim, 55) & vbCrLf & vbCrLf
                If Me.rdgMaqCartao.SelectedIndex = 1 Then
                    strImpressao &= Dir("LEVAR MÁQUINA DE CARTÃO" & Me.cboTempo.Text.Trim, 55) & vbCrLf
                End If

            Else
                strImpressao &= GerarBarCode(Me.txtComan.Text.Trim) & vbCrLf
            End If
            If GerarComissao = True Then
                If Me.txtComan.Text.Trim <> "" And strCodigoOrdem <> "" Then
                    Dim dtFunc As DataTable = CarregarDataTable("SELECT funcionario.Nome FROM Funcionario where Funcionario.Codigo =  " & strCodFunc)
                    If dtFunc.Rows.Count > 0 Then

                        strImpressao &= strTraco & vbCrLf
                        strImpressao &= Dir("Atend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
                    End If
                End If
            End If

            RodapeComanda(strImpressao, strImpressora, strPorta)
        ElseIf strImpressora.Contains("BEMATECH") Or strImpressora.Contains("ARQUIVO") Or strImpressora.Contains("NANO PRINT") Then

            Dim strImpressao As String

            Dim intTamEsp As Integer
            Dim strEstrela, strTraço As String

            If Impressora = "ARQUIVO" Then
                intTamEsp = 42
                strEstrela = "******************************************"
                strTraço = "------------------------------------------"
            Else
                intTamEsp = 60
                strEstrela = "************************************************************"
                strTraço = "------------------------------------------------------------"
            End If

            strImpressao = strEstrela & vbCrLf

            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= Esq(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf & vbCrLf
            strImpressao &= Cent(Me.colCodComanda.Caption.ToUpper & ":  " & Me.txtComan.Text.Trim, intTamEsp) & vbCrLf & vbCrLf
            strImpressao &= strTraço & vbCrLf

            If Me.lblCli.Text <> "CONSUMIDOR" Then
                strImpressao &= "Cliente.: " & Me.lblCli.Text & vbCrLf
                strImpressao &= "Endereco: " & Me.lblEnd.Text & vbCrLf
                strImpressao &= "Telefone: " & Me.txtTel.Text & vbCrLf
                strImpressao &= strTraço & vbCrLf
            End If

            strImpressao &= "ITEM CÓDIGO    DESCRICAO                  " & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$      VL TOTAL R$", intTamEsp) & vbCrLf
            strImpressao &= strTraço & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdInterno)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

                Dim P As Integer = 0

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                strImpressao &= L + 1 & "   " & strCod & "   " & strProd & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 31) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

                        Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= strOpci & vbCrLf
                        Next

                    End If

                    If Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim & vbCrLf
                    End If

                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf
                End If

            Next


            strImpressao &= strTraço & vbCrLf
            'strImpressao &= Esq("N de Itens......: ", 32) & Esq(dblQtd, 10) & vbCrLf
            If DezPorcento = True Then
                If strTipoComanda = "COMANDA" Then
                    strImpressao &= Esq("Total........: R$ ", 32) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
                    If Me.txtValorFrete.Text <> "" Then
                        Dim dblFrete As Double = Me.txtValorFrete.Text
                        If dblFrete > 0 Then
                            strImpressao &= Esq("Total Frete..: R$ ", 32) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                        End If
                    End If
                    strImpressao &= Esq("Taxa 10%.....: R$ ", 32) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
                End If
            Else
                If Me.txtValorFrete.Text <> "" Then
                    Dim dblFrete As Double = Me.txtValorFrete.Text
                    If dblFrete > 0 Then
                        strImpressao &= Esq("Total........: R$ ", 32) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
                        strImpressao &= Esq("Total Frete..: R$ ", 32) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                    End If
                End If
            End If

            strImpressao &= Esq("Total Geral..: R$ ", 32) & Esq(Me.txtGeral.Text.Trim, 10) & vbCrLf

            strImpressao &= " " & vbCrLf
            If QtdePessoasMesa <> "0" And QtdePessoasMesa <> "" Then
                strImpressao &= Dir("Qtde Pessoas: " & QtdePessoasMesa, 55) & vbCrLf
                Dim dblValorPessoa As Double = CDbl(Me.txtGeral.Text) / CDbl(QtdePessoasMesa)
                strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If Me.txtObs.Text <> "" Then
                strImpressao &= "OBSERVAÇÃO: " & Me.txtObs.Text & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If strTipoComanda <> "COMANDA" Then
                strImpressao &= strEstrela & vbCrLf
                strImpressao &= "DODOS DE ENTREGA" & vbCrLf
                strImpressao &= "Entregador: " & Me.cboEnt.Text.Trim & vbCrLf
                strImpressao &= "Troco R$..: " & Me.txtTroco.Text.Trim & vbCrLf
                strImpressao &= "Tempo.....: " & Me.cboTempo.Text.Trim & vbCrLf
                If strTipoComanda = "ENTREGAR" Then
                    If Me.rdgMaqCartao.SelectedIndex = 1 Then
                        strImpressao &= vbCrLf
                        strImpressao &= "LEVAR MÁQUINA DE CARTÃO" & vbCrLf
                    End If
                End If
                strImpressao &= strEstrela & vbCrLf

            Else
                strImpressao &= strTraço & vbCrLf
            End If

            strImpressao &= Cent("DOCUMENTO NAO FISCAL", intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            If strImpressora = "ARQUIVO" Then
                strImpressao += Avanco() & vbCrLf

                If TemGuilhotina = True Then
                    strImpressao += Corte() & vbCrLf
                End If
                SendStringToPrinter(strPorta, strImpressao)
                'ImprimiArquivo(strImpressao, PortaImpressora)

            ElseIf strImpressora.Contains("NANO PRINT") = True Then
                If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                    ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                Else
                    EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
                End If
            Else
                If strImpressora.Contains("MP-4000") Then
                    iRetorno = ConfiguraModeloImpressora(5)
                    iRetorno = SelecionaQualidadeImpressao(3)
                Else
                    iRetorno = ConfiguraModeloImpressora(1)
                End If
                iRetorno = clsBematech.IniciaPorta(PortaImpressora)


                iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If
            End If

        ElseIf strImpressora = "EPSON" Then

            Dim strImpressao As String

            Dim strEstrela, strTraço As String

            strEstrela = clsImprimir.Comp("************************************************")
            strTraço = clsImprimir.Comp("------------------------------------------------")

            strImpressao = strEstrela & vbCrLf

            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= Esq(My.Computer.Clock.LocalTime, 48) & vbCrLf

            strImpressao &= strTraço & vbCrLf & vbCrLf
            strImpressao &= "<ce>" & Me.colCodComanda.Caption.ToUpper & ":  " & Me.txtComan.Text.Trim & "</ce>" & vbCrLf & vbCrLf
            strImpressao &= strTraço & vbCrLf

            If Me.lblCli.Text <> "CONSUMIDOR" Then
                strImpressao &= "Cliente.: " & Me.lblCli.Text & vbCrLf
                strImpressao &= "Endereco: " & Me.lblEnd.Text & vbCrLf
                strImpressao &= "Telefone: " & Me.txtTel.Text & vbCrLf
                strImpressao &= strTraço & vbCrLf
            End If

            strImpressao &= "ITEM CÓDIGO    DESCRICAO                  " & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 37) & Esq("VL TOTAL R$", 11) & vbCrLf
            strImpressao &= strTraço & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdInterno)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

                Dim P As Integer = 0

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                strImpressao &= L + 1 & "   " & strCod & "   " & strProd & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 37) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

                        Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= strOpci & vbCrLf
                        Next

                    End If

                    If Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim & vbCrLf
                    End If

                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf
                End If

            Next


            strImpressao &= strTraço & vbCrLf
            'strImpressao &= Esq("N de Itens......: ", 32) & Esq(dblQtd, 10) & vbCrLf
            If DezPorcento = True Then
                If strTipoComanda = "COMANDA" Then
                    strImpressao &= Esq("Total........: R$ ", 38) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
                    If Me.txtValorFrete.Text <> "" Then
                        Dim dblFrete As Double = Me.txtValorFrete.Text
                        If dblFrete > 0 Then
                            strImpressao &= Esq("Total Frete..: R$ ", 38) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                        End If
                    End If
                    strImpressao &= Esq("Taxa 10%.....: R$ ", 38) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
                End If
            Else
                If Me.txtValorFrete.Text <> "" Then
                    Dim dblFrete As Double = Me.txtValorFrete.Text
                    If dblFrete > 0 Then
                        strImpressao &= Esq("Total........: R$ ", 38) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
                        strImpressao &= Esq("Total Frete..: R$ ", 38) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                    End If
                End If
            End If

            strImpressao &= Esq("Total Geral..: R$ ", 38) & Esq(Me.txtGeral.Text.Trim, 10) & vbCrLf

            strImpressao &= " " & vbCrLf
            If QtdePessoasMesa <> "0" And QtdePessoasMesa <> "" Then
                strImpressao &= Dir("Qtde Pessoas: " & QtdePessoasMesa, 55) & vbCrLf
                Dim dblValorPessoa As Double = CDbl(Me.txtGeral.Text) / CDbl(QtdePessoasMesa)
                strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If Me.txtObs.Text <> "" Then
                strImpressao &= "OBSERVAÇÃO: " & Me.txtObs.Text & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If strTipoComanda <> "COMANDA" Then
                strImpressao &= strEstrela & vbCrLf
                strImpressao &= "DODOS DE ENTREGA" & vbCrLf
                strImpressao &= "Entregador: " & Me.cboEnt.Text.Trim & vbCrLf
                strImpressao &= "Troco R$..: " & Me.txtTroco.Text.Trim & vbCrLf
                strImpressao &= "Tempo.....: " & Me.cboTempo.Text.Trim & vbCrLf

                If strTipoComanda = "ENTREGAR" Then
                    If Me.rdgMaqCartao.SelectedIndex = 1 Then
                        strImpressao &= vbCrLf
                        strImpressao &= "LEVAR MÁQUINA DE CARTÃO" & vbCrLf
                    End If
                End If
                strImpressao &= strEstrela & vbCrLf
            Else
                strImpressao &= strTraço & vbCrLf
            End If

            strImpressao &= "<ce>" & "DOCUMENTO NAO FISCAL" & "</ce>" & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            iRetorno = clsEpson.IniciaPorta(PortaImpressora)
            iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

            If TemGuilhotina = True Then
                iRetorno = clsEpson.AcionaGuilhotina(1)
            End If
            iRetorno = clsEpson.FechaPorta
        End If

    End Sub

    Private Sub Imprimir2()
        If TemImpressora = False Then Exit Sub

        If Impressora.Contains("ESC/POS") = True Then
            Dim strImpressao As String


            strImpressao = Cabecalho()

            strImpressao &= Esq(My.Computer.Clock.LocalTime, 55) & vbCrLf & vbCrLf

            strImpressao &= Centralizar(Exp(Me.colCodComanda.Caption.ToUpper & ": " & Me.txtComan.Text.Trim)) & vbCrLf
            strImpressao &= strTraco & vbCrLf

            If Me.lblCli.Text <> "CONSUMIDOR" Then
                strImpressao &= Dir("Cliente.: " & Me.lblCli.Text, 55) & vbCrLf
                strImpressao &= Dir("Endereco: " & Me.lblEnd.Text, 55) & vbCrLf
                strImpressao &= Dir("Telefone: " & Me.txtTel.Text, 55) & vbCrLf
                strImpressao &= strTraco & vbCrLf
            End If

            strImpressao &= Dir("CÓDIGO    DESCRICAO", 55) & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$                   VL TOTAL R$", 55) & vbCrLf
            strImpressao &= strTraco & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdInterno)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

                Dim P As Integer = 0

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                Dim strItem As String

                strItem = strCod & "   " & strProd

                If strItem.Length > 55 Then
                    strItem = Mid(strItem, 1, 55)
                End If

                strImpressao &= Dir(strItem, 55) & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 44) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

                        Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= Dir(strOpci, 55) & vbCrLf
                        Next

                    End If

                    If Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim <> "" Then
                        strImpressao &= Dir("OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim, 55) & vbCrLf
                    End If

                    strImpressao &= strTraco.Replace("-", ".") & vbCrLf
                End If

            Next

            strImpressao &= strTraco & vbCrLf

            strImpressao &= Esq("Total........: R$ ", 45) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
            If Me.txtValorFrete.Text <> "" Then
                Dim dblFrete As Double = Me.txtValorFrete.Text
                If dblFrete > 0 Then
                    strImpressao &= Esq("Total Frete..: R$ ", 45) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                End If
            End If
            strImpressao &= Esq("Taxa 10%.....: R$ ", 45) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
            strImpressao &= Esq("Total Geral..: R$ ", 45) & Esq(Me.txtGeral.Text.Trim, 10) & vbCrLf

            strImpressao &= " " & vbCrLf

            If strTipoComanda = "ENTREGAR" Then
                strImpressao &= strTraco & vbCrLf
                strImpressao &= Dir("DODOS DE ENTREGA", 55) & vbCrLf
                strImpressao &= Dir("Entregador: " & Me.cboEnt.Text.Trim, 55) & vbCrLf
                strImpressao &= Dir("Troco R$..: " & Me.txtTroco.Text.Trim, 55) & vbCrLf
                strImpressao &= Dir("Tempo.....: " & Me.cboTempo.Text.Trim, 55) & vbCrLf
            Else
                strImpressao &= GerarBarCode(Me.txtComan.Text.Trim) & vbCrLf
            End If


            Rodape(True, strImpressao)
        ElseIf Impressora.Contains("BEMATECH") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then

            Dim strImpressao As String

            Dim intTamEsp As Integer
            Dim strEstrela, strTraço As String

            If Impressora = "ARQUIVO" Then
                intTamEsp = 42
                strEstrela = "******************************************"
                strTraço = "------------------------------------------"
            Else
                intTamEsp = 60
                strEstrela = "************************************************************"
                strTraço = "------------------------------------------------------------"
            End If

            strImpressao = strEstrela & vbCrLf

            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= Esq(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf & vbCrLf
            strImpressao &= Cent(Me.colCodComanda.Caption.ToUpper & ":  " & Me.txtComan.Text.Trim, intTamEsp) & vbCrLf & vbCrLf
            strImpressao &= strTraço & vbCrLf

            If Me.lblCli.Text <> "CONSUMIDOR" Then
                strImpressao &= "Cliente.: " & Me.lblCli.Text & vbCrLf
                strImpressao &= "Endereco: " & Me.lblEnd.Text & vbCrLf
                strImpressao &= "Telefone: " & Me.txtTel.Text & vbCrLf
                strImpressao &= strTraço & vbCrLf
            End If

            strImpressao &= "ITEM CÓDIGO    DESCRICAO                  " & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$      VL TOTAL R$", intTamEsp) & vbCrLf
            strImpressao &= strTraço & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdInterno)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

                Dim P As Integer = 0

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                strImpressao &= L + 1 & "   " & strCod & "   " & strProd & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 31) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

                        Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= strOpci & vbCrLf
                        Next

                    End If

                    If Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim & vbCrLf
                    End If

                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf
                End If

            Next


            strImpressao &= strTraço & vbCrLf
            'strImpressao &= Esq("N de Itens......: ", 32) & Esq(dblQtd, 10) & vbCrLf
            strImpressao &= Esq("Total........: R$ ", 32) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
            If Me.txtValorFrete.Text <> "" Then
                Dim dblFrete As Double = Me.txtValorFrete.Text
                If dblFrete > 0 Then
                    strImpressao &= Esq("Total Frete..: R$ ", 32) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                End If
            End If
            strImpressao &= Esq("Taxa 10%.....: R$ ", 32) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
            strImpressao &= Esq("Total Geral..: R$ ", 32) & Esq(Me.txtGeral.Text.Trim, 10) & vbCrLf

            strImpressao &= " " & vbCrLf

            If strTipoComanda <> "COMANDA" Then
                strImpressao &= strEstrela & vbCrLf
                strImpressao &= "DODOS DE ENTREGA" & vbCrLf
                strImpressao &= "Entregador: " & Me.cboEnt.Text.Trim & vbCrLf
                strImpressao &= "Troco R$..: " & Me.txtTroco.Text.Trim & vbCrLf
                strImpressao &= "Tempo.....: " & Me.cboTempo.Text.Trim & vbCrLf
                strImpressao &= strEstrela & vbCrLf
            Else
                strImpressao &= strTraço & vbCrLf
            End If

            strImpressao &= Cent("DOCUMENTO NAO FISCAL", intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            If Impressora = "ARQUIVO" Then
                ImprimiArquivo(strImpressao, PortaImpressora)
            ElseIf Impressora.Contains("NANO PRINT") = True Then
                If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                    ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                Else
                    EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
                End If
            Else
                If Impressora.Contains("MP-4000") Then
                    iRetorno = ConfiguraModeloImpressora(5)
                    iRetorno = SelecionaQualidadeImpressao(3)
                Else
                    iRetorno = ConfiguraModeloImpressora(1)
                End If
                iRetorno = clsBematech.IniciaPorta(PortaImpressora)


                iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If
            End If

        ElseIf Impressora = "EPSON" Then

            Dim strImpressao As String

            Dim strEstrela, strTraço As String

            strEstrela = clsImprimir.Comp("************************************************")
            strTraço = clsImprimir.Comp("------------------------------------------------")

            strImpressao = strEstrela & vbCrLf

            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= Esq(My.Computer.Clock.LocalTime, 48) & vbCrLf

            strImpressao &= strTraço & vbCrLf & vbCrLf
            strImpressao &= "<ce>" & Me.colCodComanda.Caption.ToUpper & ":  " & Me.txtComan.Text.Trim & "</ce>" & vbCrLf & vbCrLf
            strImpressao &= strTraço & vbCrLf

            If Me.lblCli.Text <> "CONSUMIDOR" Then
                strImpressao &= "Cliente.: " & Me.lblCli.Text & vbCrLf
                strImpressao &= "Endereco: " & Me.lblEnd.Text & vbCrLf
                strImpressao &= "Telefone: " & Me.txtTel.Text & vbCrLf
                strImpressao &= strTraço & vbCrLf
            End If

            strImpressao &= "ITEM CÓDIGO    DESCRICAO                  " & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 37) & Esq("VL TOTAL R$", 11) & vbCrLf
            strImpressao &= strTraço & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTotal As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdInterno)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

                Dim P As Integer = 0

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf

                    Dim vetProd As Array = Split(strProd, "|")

                    strProd = ""

                    For P = 0 To vetProd.Length - 1
                        If vetProd(P).ToString <> "" Then
                            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                        End If
                    Next
                    strProd = Mid(strProd, 1, strProd.Length - 3)
                End If

                strImpressao &= L + 1 & "   " & strCod & "   " & strProd & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 37) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                    If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

                        Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

                        Dim vetOpc As Array = Split(strOpci, "|")

                        For P = 0 To vetOpc.Length - 1
                            strOpci = vetOpc(P).ToString
                            strImpressao &= strOpci & vbCrLf
                        Next

                    End If

                    If Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim & vbCrLf
                    End If

                    strImpressao &= strTraço.Replace("-", ".") & vbCrLf
                End If

            Next


            strImpressao &= strTraço & vbCrLf
            'strImpressao &= Esq("N de Itens......: ", 32) & Esq(dblQtd, 10) & vbCrLf
            strImpressao &= Esq("Total........: R$ ", 38) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
            If Me.txtValorFrete.Text <> "" Then
                Dim dblFrete As Double = Me.txtValorFrete.Text
                If dblFrete > 0 Then
                    strImpressao &= Esq("Total Frete..: R$ ", 38) & Esq(Me.txtValorFrete.Text.Trim, 10) & vbCrLf
                End If
            End If
            strImpressao &= Esq("Taxa 10%.....: R$ ", 38) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
            strImpressao &= Esq("Total Geral..: R$ ", 38) & Esq(Me.txtGeral.Text.Trim, 10) & vbCrLf

            strImpressao &= " " & vbCrLf

            If strTipoComanda <> "COMANDA" Then
                strImpressao &= strEstrela & vbCrLf
                strImpressao &= "DODOS DE ENTREGA" & vbCrLf
                strImpressao &= "Entregador: " & Me.cboEnt.Text.Trim & vbCrLf
                strImpressao &= "Troco R$..: " & Me.txtTroco.Text.Trim & vbCrLf
                strImpressao &= "Tempo.....: " & Me.cboTempo.Text.Trim & vbCrLf
                strImpressao &= strEstrela & vbCrLf
            Else
                strImpressao &= strTraço & vbCrLf
            End If

            strImpressao &= "<ce>" & "DOCUMENTO NAO FISCAL" & "</ce>" & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            iRetorno = clsEpson.IniciaPorta(PortaImpressora)
            iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

            If TemGuilhotina = True Then
                iRetorno = clsEpson.AcionaGuilhotina(1)
            End If
            iRetorno = clsEpson.FechaPorta
        End If

    End Sub

    Private Sub txtAte_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAte.Leave
        If Me.txtAte.Text.Trim = "" Then Exit Sub

        Dim dt As DataTable = CarregarDataTable("Select Nome From Funcionario where Ativo ='True' and Codigo =" & Me.txtAte.Text.Trim & " and CodConfig =" & CodConfig)

        If dt.Rows.Count > 0 Then
            Me.lblAten.Text = dt.Rows.Item(0).Item("Nome").ToString
        Else
            LimpaAtendente()
        End If

    End Sub

    Private Sub txtTel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTel.Leave
        If Me.txtTel.Text.Trim = "" Then
            TrazCliente(1, False)
            Exit Sub
        End If

        Dim dt As DataTable = CarregarDataTable("Select Codigo from Cliente where Telefone ='" & Me.txtTel.Text & "'")

        If dt.Rows.Count > 0 Then
            TrazCliente(dt.Rows.Item(0).Item("Codigo").ToString, True)
            BairroFrete(strBairro)
        Else
            TrazCliente(1, False)
            Me.txtTel.Focus()

        End If
    End Sub

    Private Sub AbreCliente()
        Dim frm As New frmCadCliente
        CodigoDoCliente = 0
        TrazCliente(0, False)
        frm.Tag = "PESQUISA"
        frm.ShowDialog()
        frm.Tag = ""

        If CodigoDoCliente <> Nothing Then
            TrazCliente(CodigoDoCliente, True)
            'If strTipoComanda <> "COMANDA" Then
            '    Me.txtComan.Text = CodigoDoCliente
            'End If
            LeaveComanda()
            BairroFrete(strBairro)
            
        End If
    End Sub
    Private Sub BairroFrete(ByVal parBairro As String)
        If Me.btnEntrega.Checked = False Then Exit Sub
        If parBairro = "" Then
            Me.txtValorFrete.ResetText()
            Exit Sub
        End If

        Dim dtBairro As DataTable = CarregarDataTable("SELECT PortaImpressora from Grupo where Tipo= 'B' and Nome = '" & parBairro & "'")
        If dtBairro.Rows.Count > 0 Then
            If dtBairro.Rows.Item(0).Item("PortaImpressora").ToString <> "" Then
                Dim dblFrete As Double = dtBairro.Rows.Item(0).Item("PortaImpressora").ToString
                Me.txtValorFrete.Text = dblFrete.ToString("0.00")
                Calcular()
            End If
        End If
    End Sub
    Private Sub btnEntrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrega.CheckedChanged
        Entrega()
    End Sub

    Private Sub Entrega()
        If Me.btnEntrega.Checked = True Then
            Tipo("ENTREGAR")
            Me.btnEntrega.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnRetirar.Checked = False
            Me.btnComanda.Checked = False
            Me.btnRetirar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
            Me.btnComanda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
            Me.lblMaqCartao.Visible = True
            Me.rdgMaqCartao.Visible = True

            Me.txtValorFrete.Enabled = True
        End If
    End Sub

    Private Sub btnRetirar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetirar.CheckedChanged
        Retirar()
    End Sub

    Private Sub Retirar()
        If Me.btnRetirar.Checked = True Then
            Tipo("RETIRAR")
            btnRetirar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnEntrega.Checked = False
            Me.btnComanda.Checked = False
            Me.btnEntrega.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
            Me.btnComanda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
            Me.lblMaqCartao.Visible = False
            Me.rdgMaqCartao.Visible = False

            Me.txtValorFrete.Enabled = False
        End If
    End Sub

    Private Sub btnComanda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComanda.CheckedChanged
        Comanda()
    End Sub

    Private Sub Comanda()
        If Me.btnComanda.Checked = True Then
            Tipo("COMANDA")
            Me.btnComanda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnEntrega.Checked = False
            Me.btnRetirar.Checked = False
            Me.btnEntrega.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
            Me.btnRetirar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default

            Me.lblMaqCartao.Visible = False
            Me.rdgMaqCartao.Visible = False

            Me.txtValorFrete.Enabled = False
        End If
    End Sub

    Private Sub Tipo(ByVal parTipo As String)
        LimparDados(True)

        Select Case parTipo

            Case "COMANDA"
                strTipoComanda = "COMANDA"
                Me.colCodComanda.Caption = "Comanda/Mesa"
                Me.lblComanda.Text = "Comanda/Mesa"
                Me.txtComanda.Appearance.Font = New Font("Tahoma", 20, FontStyle.Bold)
                Me.colCodComanda.Visible = True
                Me.colNome.Visible = False
                TrazCliente(1, False)
                Me.txtComan.Enabled = True
                Me.btnConCli.Enabled = True
                Me.txtTel.Enabled = True
                Me.cboEnt.Enabled = True
                Me.txtTroco.Enabled = True
                Me.cboTempo.Enabled = True
                Me.btnTranItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.btnTranTudo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.txtComan.Focus()

            Case Else
                strTipoComanda = parTipo
                Me.colCodComanda.Caption = "Pedido/" & parTipo
                Me.colNome.Caption = "Pedido/" & parTipo
                Me.lblComanda.Text = "Pedido/" & parTipo
                Me.txtComanda.Appearance.Font = New Font("Tahoma", 10, FontStyle.Bold)
                Me.colCodComanda.Visible = False
                Me.colNome.Visible = True
                Me.btnConCli.Enabled = True
                Me.txtTel.Enabled = True
                Me.txtComan.Enabled = False
                Me.cboEnt.Enabled = True
                Me.txtTroco.Enabled = True
                Me.cboTempo.Enabled = True
                Me.btnTranItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.btnTranTudo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.txtTel.Focus()

        End Select

        CarregarComandas()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        EnviarImpressao2()
        SalvarObservacao()
        Tipo(strTipoComanda)
    End Sub

    Private Sub btnConCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConCli.Click
        AbreCliente()
    End Sub

    Private Sub txtTel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTel.KeyDown
        If e.KeyCode = Keys.F10 Then
            AbreCliente()
        End If
    End Sub

    Private Sub btnOpc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpc.Click
        Montar()
    End Sub

    Private Sub Montar()
        If strTipoComanda = "COMANDA" Then
            If Validar(Me.txtComan) = False Then Exit Sub
        End If
        If Validar(Me.txtAte) = False Then Exit Sub

        Dim frm As New frmMontaProduto
        ListaProduto = ""
        ListaOpcoes = ""
        CodigoInternoProdutoOpcoes = ""
        ObsOpcoes = ""
        PrecoProdutoOpcoes = 0
        CodigoProdutoOpcoes = 0
        frm.ShowDialog()

        If ListaProduto = "" Then Exit Sub

        If ListaProduto.Length > 0 Then
            ListaProduto = Mid(ListaProduto, 1, ListaProduto.Length - 1)
        End If

        If ListaOpcoes.Length > 0 Then
            ListaOpcoes = Mid(ListaOpcoes, 1, ListaOpcoes.Length - 1)
        End If

        Dim bolMisto = True
        Dim dblQtd As Double

        Dim dtComanda As DataTable = CarregarDataTable("SELECT CodOrdens FROM Comanda where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status ='Aberto' AND Tipo ='" & strTipoComanda & "' and CodConfig =" & CodConfig)
        Dim intCodOrdens As Integer
        If dtComanda.Rows.Count > 0 Then
            intCodOrdens = dtComanda.Rows.Item(0).Item("CodOrdens").ToString
        Else
            intCodOrdens = GerarCodigo("Ordens", "Cod", CodConfig)
            Inserir("INSERT INTO Ordens(Cod, Tabela, CodConfig) VALUES (" & intCodOrdens & ",'Comanda'," & CodConfig & ")")
            If strTipoComanda <> "COMANDA" Then
                Me.txtComan.Text = intCodOrdens
            End If
        End If

        If Me.txtQtd.Text.Trim <> "" Then
            dblQtd = Me.txtQtd.Text
        Else
            dblQtd = 1
        End If

        Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Produto, Qtd, ValorUnitario, " & _
        "Data, Status, CodConfig, Misto, CodFunc, CodCli, Tipo, Opcoes, Obs, ImpOk, Nome) VALUES (" & intCodOrdens & "," & _
        "'" & Me.txtComan.Text.Trim & "'," & CodigoProdutoOpcoes & ",'" & CodigoInternoProdutoOpcoes & "'," & _
        "'" & ListaProduto & "'," & Num(dblQtd) & "," & Num(PrecoProdutoOpcoes) & ",'" & My.Computer.Clock.LocalTime & "'," & _
        "'" & "Aberto" & "'," & CodConfig & ",'" & bolMisto & "'," & Me.txtAte.Text.Trim & "," & intCodCli & "," & _
        "'" & strTipoComanda & "','" & ListaOpcoes & "','" & ObsOpcoes & "','False','" & Me.txtNome.Text.Trim & "')")

        If strTipoComanda <> "COMANDA" Then
            Atualizar("Update Comanda set CodCli =" & intCodCli & ", Nome ='" & Me.txtNome.Text & "' where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status = 'Aberto' and CodConfig = " & CodConfig)
        End If

        Dim dtGru As DataTable = CarregarDataTable("Select Grupo from Produto where Codigo =" & CodigoProdutoOpcoes)
        If CNPJEmpresa = "10302513000100" Then
            If strTipoComanda = "COMANDA" Then
                EnviarImpressao(dtGru.Rows.Item(0).Item("Grupo").ToString, CodigoInternoProdutoOpcoes, ListaProduto, dblQtd.ToString("0.000"), True)
            End If
        End If
       

        CarregarDadosTela()

        Me.txtCodProd.Tag = ""
        Me.txtCodProd.ResetText()
        Me.txtQtd.ResetText()
        Me.txtCodProd.Focus()
        Calcular()

        Me.txtCodProd.Focus()
    End Sub

    Private Sub btnTranItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTranItem.ItemClick
        If SenhaEstaOK() = False Then Exit Sub

        Dim strNum As String = InputBox("Digite para qual Comanda/Mesa o produto será transferido.", "Transferência de Produto")

        If strNum.Trim = "" Then Exit Sub

        If strNum.Trim = Me.txtComan.Text.Trim Then
            MsgBox("A Comanda/Mesa de destino é a mesma de origem!" & vbCrLf & "Informe uma Comanda/Mesa diferente.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dt As DataTable = CarregarDataTable("Select CodOrdens, Status from Comanda where CodComanda ='" & strNum & "' and Status <> 'Fechado'")

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Status").ToString = "Fechado" Then
                MsgBox("A Comanda/Mesa de destino não pode estar fechada!", MsgBoxStyle.Information)
                Exit Sub
            End If

            'ATUALIZAR OBSERVACAO
            Dim strObservacao As String = AtualizarObservacao(dt.Rows.Item(0).Item("CodOrdens").ToString, Me.txtComan.Text.Trim)
            Atualizar("Update R7 set COO='" & strObservacao & "' Where CodUser='" & dt.Rows.Item(0).Item("CodOrdens").ToString & "' And CodConfig=" & CodConfig)

            Atualizar("Update Comanda set CodOrdens =" & dt.Rows.Item(0).Item("CodOrdens").ToString & ", CodComanda ='" & strNum & "' where Codigo =" & Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodigo))
            LimparDados(True)
            CarregarDadosTela()
            MsgBox("Produto transferido com sucesso!", MsgBoxStyle.Information)
        Else
            'MsgBox("Essa Comanda/Mesa não está cadastrada ou já foi fechada!", MsgBoxStyle.Information)
            Dim intCodOrdens As Integer
            intCodOrdens = GerarCodigo("Ordens", "Cod", CodConfig)
            Inserir("INSERT INTO Ordens(Cod, Tabela, CodConfig) VALUES (" & intCodOrdens & ",'Comanda'," & CodConfig & ")")
            If strTipoComanda <> "COMANDA" Then
                Me.txtComan.Text = intCodOrdens
            End If

            Atualizar("Update Comanda set CodOrdens =" & intCodOrdens & ", CodComanda ='" & strNum & "' where Codigo =" & Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodigo))
            LimparDados(True)
            CarregarDadosTela()
            MsgBox("Produto transferido com sucesso!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Function AtualizarObservacao(ByVal parCodOrdens As String, ByVal parComanda As String) As String
        Dim strObs1 As String = ""
        Dim strObs2 As String = ""
        Dim strCodObs2 As String = ""
        Dim strResult As String = ""

        Dim dtObs1 As DataTable = CarregarDataTable("Select Codigo, COO From r7 Where CodUser=" & parCodOrdens)

        If dtObs1.Rows.Count > 0 Then
            strObs1 = dtObs1.Rows.Item(0).Item("COO").ToString
        End If


        Dim dtObs2 As DataTable = CarregarDataTable("Select r7.Codigo, COO From r7 Left Join Comanda On " & _
        " CodOrdens=CodUser And r7.CodConfig=Comanda.CodConfig Where CodComanda='" & parComanda & "' " & _
        " And Status='Aberto' And Comanda.CodConfig=" & CodConfig)

        If dtObs2.Rows.Count > 0 Then
            strObs2 = dtObs2.Rows.Item(0).Item("COO").ToString
            strCodObs2 = dtObs2.Rows.Item(0).Item("Codigo").ToString
        End If

        If strCodObs2 <> "" Then
            Excluir("Delete From R7 Where Codigo=" & strCodObs2)
        End If

        strResult = strObs1 & " " & strObs2
        strResult = strResult.Trim

        Return strResult
    End Function

    Private Sub btnTranTudo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTranTudo.ItemClick
        If SenhaEstaOK() = False Then Exit Sub

        Dim strNum As String = InputBox("Digite para qual Comanda/Mesa os produtos serão transferidos.", "Transferência de Comanda/Mesa")

        If strNum.Trim = "" Then Exit Sub

        If strNum.Trim = Me.txtComan.Text.Trim Then
            MsgBox("A Comanda/Mesa de destino é a mesma de origem!" & vbCrLf & "Informe uma Comanda/Mesa diferente.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dt As DataTable = CarregarDataTable("Select CodOrdens, Status from Comanda where CodComanda ='" & strNum & "' and Status <> 'Fechado' and Status <> 'Faturado'")

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Status").ToString = "Fechado" Then
                MsgBox("A Comanda/Mesa de destino não pode estar fechada!", MsgBoxStyle.Information)
                Exit Sub
            End If

            'ATUALIZAR OBSERVACAO
            Dim strObservacao As String = AtualizarObservacao(dt.Rows.Item(0).Item("CodOrdens").ToString, Me.txtComan.Text.Trim)
            Atualizar("Update R7 set COO='" & strObservacao & "' Where CodUser='" & dt.Rows.Item(0).Item("CodOrdens").ToString & "' And CodConfig=" & CodConfig)

            Dim str As String = dt.Rows.Item(0).Item("CodOrdens").ToString

            Atualizar("Update Comanda set CodOrdens =" & dt.Rows.Item(0).Item("CodOrdens").ToString & ", CodComanda ='" & strNum & "' where CodComanda ='" & Me.txtComan.Text.Trim & "' and Status ='Aberto' And CodConfig=" & CodConfig)
            LimparDados(True)
            CarregarDadosTela()
            MsgBox("Comanda/Mesa transferida com sucesso!", MsgBoxStyle.Information)
        Else
            'MsgBox("Essa Comanda/Mesa não está cadastrada ou já foi fechada!", MsgBoxStyle.Information)
            Dim intCodOrdens As Integer
            intCodOrdens = GerarCodigo("Ordens", "Cod", CodConfig)
            Inserir("INSERT INTO Ordens(Cod, Tabela, CodConfig) VALUES (" & intCodOrdens & ",'Comanda'," & CodConfig & ")")
            If strTipoComanda <> "COMANDA" Then
                Me.txtComan.Text = intCodOrdens
            End If

            Atualizar("Update Comanda set CodOrdens =" & intCodOrdens & ", CodComanda ='" & strNum & "' where CodComanda ='" & Me.txtComan.Text.Trim & "' and Status ='Aberto' And CodConfig=" & CodConfig)
            LimparDados(True)
            CarregarDadosTela()
            MsgBox("Comanda/Mesa transferida com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnVender_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVender.ItemClick
        If CNPJEmpresa <> "04625955000195" Then
            EnviarImpressao2()
        End If
        SalvarObservacao()
        Vender()
    End Sub

    Private Sub Vender()
        If Me.txtComan.Text.Trim = "" Then Exit Sub

        If ProcuraForm("frmVenda") = "frmVenda" Then

            If frmVenda.grd1.RowCount > 0 Then
                MsgBox("Não é possivel realizar esse procedimento pois já existe uma venda sendo realizada!", MsgBoxStyle.Information)
                Exit Sub
            End If
            Finalizar(True)
            Dim dt As DataTable = CarregarDataTable("SELECT Status FROM Comanda where CodComanda = '" & intCodigoComanda & "' and Status = 'Fechado' and CodConfig = " & CodConfig)
            If dt.Rows.Count = 0 Then Exit Sub
            ConsultaPedido = intCodigoComanda
            frmVenda.F8(False)
            frmVenda.WindowState = FormWindowState.Maximized

        Else
            Finalizar(True)
            Dim dt As DataTable = CarregarDataTable("SELECT Status FROM Comanda where CodComanda = '" & intCodigoComanda & "' and Status = 'Fechado' and CodConfig = " & CodConfig)
            If dt.Rows.Count = 0 Then Exit Sub
            ConsultaPedido = intCodigoComanda
            'frmVenda.bolPedido = True
            frmVenda.Show()
            frmVenda.F8(False)

        End If

        VendaComComanda = True
    End Sub
    Private Sub EnviarImpressao2()
        If TemImpressora = False Then Exit Sub

        Dim dtPorta As DataTable = CarregarDataTable("SELECT PortaImpressora, Impressora FROM (Comanda left join Produto " & _
        "on Comanda.CodProd = Produto.Codigo)Left join Grupo on Grupo.Nome = Produto.Grupo where CodComanda = '" & Me.txtComan.Text.Trim & "' and ImpOk = 'False' and Comanda.Tipo ='" & strTipoComanda & "' AND Comanda.Status ='Aberto' AND CodConfig =" & CodConfig & " and PortaImpressora <> '' " & _
        "group by PortaImpressora, Impressora")


        Dim I As Integer
        Dim A As Integer

        For I = 0 To dtPorta.Rows.Count - 1

            Dim strPorta As String = dtPorta.Rows.Item(I).Item("PortaImpressora").ToString
            Dim strModImpressora As String = dtPorta.Rows.Item(I).Item("Impressora").ToString

            Dim dtItens As DataTable = CarregarDataTable("SELECT Comanda.Codigo, Comanda.CodProd, Comanda.CodProdInterno, " & _
            "Comanda.Produto, Comanda.Qtd, Comanda.ValorUnitario, (Comanda.Qtd * Comanda.ValorUnitario) as ValorTotal, " & _
            "Comanda.Misto, Comanda.Opcoes, Comanda.Obs, Comanda.CodFunc FROM (Comanda left join Produto on Comanda.CodProd = Produto.Codigo)" & _
            "Left join Grupo on Grupo.Nome = Produto.Grupo where CodComanda = '" & Me.txtComan.Text.Trim & "' and ImpOk = 'False' " & _
            "and Comanda.Tipo ='" & strTipoComanda & "' AND Comanda.Status = 'Aberto' AND Comanda.CodConfig =" & CodConfig & " and PortaImpressora = '" & strPorta & "' and " & _
            "Impressora = '" & strModImpressora & "'")

            If dtItens.Rows.Count > 0 Then
                If strModImpressora.Contains("ESC/POS") = True Then

                    Dim strImpressao As String = ""

                    strIgual = CompComanda("=======================================================", strModImpressora)
                    strTraco = CompComanda("-------------------------------------------------------", strModImpressora)

                    strImpressao = CentralizarComanda(NegComanda(NomeEmpresa.ToString.Trim, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
                    strImpressao &= strIgual & vbCrLf & vbCrLf

                    strImpressao &= CentralizarComanda(ExpComanda(Me.colCodComanda.Caption & ": " & Me.txtComan.Text.Trim, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
                    strImpressao &= strIgual & vbCrLf

                    strImpressao &= Dir("CODIGO                                              QTD", 55) & vbCrLf
                    strImpressao &= "DESCRICAO                                              " & vbCrLf

                    strImpressao &= strTraco & vbCrLf
                    Dim strCodFunc As String = ""
                    For A = 0 To dtItens.Rows.Count - 1
                        Dim strCod As String = dtItens.Rows.Item(A).Item("CodProdInterno").ToString
                        Dim strQtd As String = dtItens.Rows.Item(A).Item("Qtd").ToString
                        Dim bolMisto As Boolean = dtItens.Rows.Item(A).Item("Misto")
                        strCodFunc = dtItens.Rows.Item(A).Item("CodFunc").ToString
                        Dim strProduto As String = dtItens.Rows.Item(A).Item("Produto").ToString & "   (" & strCodFunc & ")"
                        Dim strOpcoes As String = dtItens.Rows.Item(A).Item("Opcoes").ToString
                        Dim strObs As String = dtItens.Rows.Item(A).Item("Obs").ToString

                        If strModImpressora.ToUpper.Contains("DARUMA") = True Then
                            strImpressao &= ExpComanda(Dir(strCod, 14) & Esq(strQtd, 14), strModImpressora) & vbCrLf
                        End If

                        If strModImpressora.ToUpper.Contains("BEMATECH") = True Then

                            strImpressao &= Dir(strCod, 20) & Esq(strQtd, 35) & vbCrLf

                        End If
                        If strModImpressora.ToUpper.Contains("EPSON") = True Then

                            strImpressao &= ExpComanda(Dir(strCod, 27) & Esq(strQtd, 15), strModImpressora) & vbCrLf

                        End If
                      
                        If bolMisto = True Then
                            Dim P As Integer

                            Dim vetProd As Array = Split(strProduto, "|")

                            strProduto = ""

                            For P = 0 To vetProd.Length - 1
                                If vetProd(P).ToString <> "" Then
                                    strProduto &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                                End If
                            Next
                            strProduto = Mid(strProduto, 1, strProduto.Length - 3)
                        End If

                        strImpressao &= CompComanda(Dir(strProduto, 55), strModImpressora) & vbCrLf


                        If bolMisto = True Then

                            Dim P As Integer

                            If strOpcoes.Trim <> "" Then

                                Dim strOpci As String = strOpcoes

                                Dim vetOpc As Array = Split(strOpci, "|")

                                For P = 0 To vetOpc.Length - 1
                                    strOpci = vetOpc(P).ToString
                                    'strImpressao &= Dir("Opc. " & P + 1 & ": " & strOpci, 55) & vbCrLf
                                    strImpressao &= Dir(strOpci, 55) & vbCrLf
                                Next

                            End If

                            If strObs <> "" Then
                                strImpressao &= Dir("OBSERVAÇÃO: " & strObs, 55) & vbCrLf
                            End If


                        End If
                        If A < dtItens.Rows.Count - 1 Then
                            strImpressao &= vbCrLf
                        End If

                    Next




                    If Me.txtObs.Text <> "" Then
                        strImpressao &= strTraco & vbCrLf

                        strImpressao &= "OBSERVAÇÃO: " & Me.txtObs.Text & vbCrLf
                    End If
                    If GerarComissao = True Then
                        If Me.txtComan.Text.Trim <> "" And strCodigoOrdem <> "" Then
                            Dim dtFunc As DataTable = CarregarDataTable("SELECT funcionario.Nome FROM Funcionario where Funcionario.Codigo =  " & strCodFunc)
                            If dtFunc.Rows.Count > 0 Then

                                strImpressao &= strTraco & vbCrLf
                                strImpressao &= Dir("Atend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
                            End If
                        End If
                    End If
                    strImpressao &= strTraco & vbCrLf

                    strImpressao &= CentralizarComanda(My.Computer.Clock.LocalTime, strModImpressora) & vbCrLf

                    RodapeComanda(strImpressao, strModImpressora, strPorta)

                ElseIf strModImpressora.Contains("BEMATECH") Or strModImpressora.Contains("ARQUIVO") Or strModImpressora.Contains("NANO PRINT") Then
                    Dim strImpressao As String

                    Dim intTamEsp As Integer
                    Dim strEstrela, strTraço As String

                    intTamEsp = 42
                    strEstrela = "******************************************"
                    strTraço = "------------------------------------------"

                    strImpressao = Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf & vbCrLf

                    strImpressao &= strEstrela & vbCrLf & vbCrLf
                    strImpressao &= Cent(Me.colCodComanda.Caption & ": " & Me.txtComan.Text.Trim, intTamEsp) & vbCrLf & vbCrLf
                    strImpressao &= strEstrela & vbCrLf

                    strImpressao &= "CODIGO                                 QTD" & vbCrLf
                    strImpressao &= "DESCRICAO                                 " & vbCrLf

                    strImpressao &= strTraço & vbCrLf
                    For A = 0 To dtItens.Rows.Count - 1
                        Dim strCod As String = dtItens.Rows.Item(A).Item("CodProdInterno").ToString
                        Dim strQtd As String = dtItens.Rows.Item(A).Item("Qtd").ToString
                        Dim bolMisto As Boolean = dtItens.Rows.Item(A).Item("Misto")
                        Dim strProduto As String = dtItens.Rows.Item(A).Item("Produto").ToString
                        Dim strOpcoes As String = dtItens.Rows.Item(A).Item("Opcoes").ToString
                        Dim strObs As String = dtItens.Rows.Item(A).Item("Obs").ToString

                        strImpressao &= Dir(strCod, 20) & Esq(strQtd, 22) & vbCrLf

                        If bolMisto = True Then
                            Dim P As Integer

                            Dim vetProd As Array = Split(strProduto, "|")

                            strProduto = ""

                            For P = 0 To vetProd.Length - 1
                                If vetProd(P).ToString <> "" Then
                                    strProduto &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                                End If
                            Next
                            strProduto = Mid(strProduto, 1, strProduto.Length - 3)
                        End If

                        strImpressao &= strProduto & vbCrLf


                        If bolMisto = True Then

                            Dim P As Integer

                            If strOpcoes.Trim <> "" Then

                                Dim strOpci As String = strOpcoes

                                Dim vetOpc As Array = Split(strOpci, "|")

                                For P = 0 To vetOpc.Length - 1
                                    strOpci = vetOpc(P).ToString
                                    strImpressao &= strOpci & vbCrLf
                                Next

                            End If

                            If strObs <> "" Then
                                strImpressao &= "OBSERVAÇÃO: " & strObs & vbCrLf
                            End If


                        End If
                    Next



                    strImpressao &= strTraço & vbCrLf
                    If Me.txtObs.Text <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & Me.txtObs.Text & vbCrLf
                    End If
                    strImpressao &= strTraco & vbCrLf

                    strImpressao &= Cent(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf

                    strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


                    If strModImpressora = "ARQUIVO" Then
                        strImpressao += Avanco() & vbCrLf

                        If TemGuilhotina = True Then
                            strImpressao += Corte() & vbCrLf
                        End If
                        SendStringToPrinter(strPorta, strImpressao)
                        'EscreveArquivo(strPorta & "\" & My.Computer.Name & ".txt", strImpressao)
                        'ImprimiArquivo(strImpressao, strPorta)
                    ElseIf strModImpressora.Contains("NANO PRINT") = True Then
                        If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                            ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                        Else
                            EscreveArquivo(strPorta & "\" & My.Computer.Name & ".txt", strImpressao)
                        End If
                    Else
                        If strModImpressora.Contains("MP-4000") Then
                            iRetorno = ConfiguraModeloImpressora(5)
                            iRetorno = SelecionaQualidadeImpressao(3)
                        Else
                            iRetorno = ConfiguraModeloImpressora(1)
                        End If
                        iRetorno = clsBematech.IniciaPorta(strPorta)


                        iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                        If TemGuilhotina = True Then
                            iRetorno = clsBematech.AcionaGuilhotina(0)
                        End If
                    End If

                ElseIf strModImpressora = "EPSON" Then
                    Dim strImpressao As String

                    Dim intTamEsp As Integer
                    Dim strEstrela, strTraço As String

                    strEstrela = clsImprimir.Comp("************************************************")
                    strTraço = clsImprimir.Comp("------------------------------------------------")

                    strImpressao = "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf & vbCrLf

                    strImpressao &= strEstrela & vbCrLf & vbCrLf
                    strImpressao &= "<ce>" & Me.colCodComanda.Caption & ": " & Me.txtComan.Text.Trim & "</ce>" & vbCrLf & vbCrLf
                    strImpressao &= strEstrela & vbCrLf

                    strImpressao &= "CODIGO                                 QTD" & vbCrLf
                    strImpressao &= "DESCRICAO                                 " & vbCrLf

                    strImpressao &= strTraço & vbCrLf
                    For A = 0 To dtItens.Rows.Count - 1
                        Dim strCod As String = dtItens.Rows.Item(A).Item("CodProdInterno").ToString
                        Dim strQtd As String = dtItens.Rows.Item(A).Item("Qtd").ToString
                        Dim bolMisto As Boolean = dtItens.Rows.Item(A).Item("Misto")
                        Dim strProduto As String = dtItens.Rows.Item(A).Item("Produto").ToString
                        Dim strOpcoes As String = dtItens.Rows.Item(A).Item("Opcoes").ToString
                        Dim strObs As String = dtItens.Rows.Item(A).Item("Obs").ToString
                        strImpressao &= Dir(strCod, 37) & Esq(strQtd, 11) & vbCrLf

                        If bolMisto = True Then
                            Dim P As Integer

                            Dim vetProd As Array = Split(strProduto, "|")

                            strProduto = ""

                            For P = 0 To vetProd.Length - 1
                                If vetProd(P).ToString <> "" Then
                                    strProduto &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                                End If
                            Next
                            strProduto = Mid(strProduto, 1, strProduto.Length - 3)
                        End If

                        strImpressao &= strProduto & vbCrLf


                        If bolMisto = True Then

                            Dim P As Integer

                            If strOpcoes.Trim <> "" Then

                                Dim strOpci As String = strOpcoes

                                Dim vetOpc As Array = Split(strOpci, "|")

                                For P = 0 To vetOpc.Length - 1
                                    strOpci = vetOpc(P).ToString
                                    strImpressao &= strOpci & vbCrLf
                                Next

                            End If

                            If strObs <> "" Then
                                strImpressao &= "OBSERVAÇÃO: " & strObs & vbCrLf
                            End If


                        End If

                    Next


                    strImpressao &= strTraço & vbCrLf
                    If Me.txtObs.Text <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & Me.txtObs.Text & vbCrLf
                    End If
                    strImpressao &= strTraco & vbCrLf

                    strImpressao &= "<ce>" & My.Computer.Clock.LocalTime & "</ce>" & vbCrLf

                    strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")



                    iRetorno = clsEpson.IniciaPorta(strPorta)

                    iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                    If TemGuilhotina = True Then
                        iRetorno = clsEpson.AcionaGuilhotina(1)
                    End If

                    iRetorno = clsEpson.FechaPorta()

                End If
            End If


            Atualizar("UPDATE Comanda set ImpOk = 'True' FROM (Comanda left join Produto on Comanda.CodProd = Produto.Codigo)" & _
            "Left join Grupo on Grupo.Nome = Produto.Grupo where CodComanda = '" & Me.txtComan.Text.Trim & "' and ImpOk = 'False' " & _
            "and Comanda.Tipo ='" & strTipoComanda & "' AND Comanda.CodConfig =" & CodConfig & " and PortaImpressora = '" & strPorta & "' and " & _
            "Impressora = '" & strModImpressora & "'")

        Next

    End Sub

    Private Sub txtTroPar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTroPar.Leave
        Try
            Me.txtTroco.Text = (CDbl(Me.txtTroPar.Text) - CDbl(Me.txtGeral.Text)).ToString("0.00")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rdgDezPorcento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calcular()

    End Sub

    Private Sub txtObs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObs.Leave
        SalvarObservacao()
        CarregarComandas()
    End Sub

    Private Sub SplitContainerControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainerControl1.Click
        Me.Timer2.Start()
    End Sub

    Private Sub AlmentarSplit()
        Me.SplitContainerControl1.SplitterPosition = 270
        bolSplit = True
        Me.GridColumn1.Visible = True
    End Sub

    Private Sub DiminuirSplit()
        If bolManter = False Then
            Me.SplitContainerControl1.SplitterPosition = 187
            bolSplit = False
            Me.GridColumn1.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If bolSplit = False Then
            AlmentarSplit()
            Me.Timer2.Stop()
        Else
            DiminuirSplit()
            Me.Timer2.Stop()
        End If
        CarregarComandas()
    End Sub

    Private Sub grd2_ColumnFilterChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd2.ColumnFilterChanged
        Dim index As Integer = -999997
        Dim strComanda As String = Me.grd2.GetRowCellDisplayText(index, Me.colCodComanda)

        If strComanda <> "" Then
            AlmentarSplit()
        Else
            'DiminuirSplit()
            AlmentarSplit()
        End If
        CarregarComandas()
    End Sub

    Private Sub txtComanda_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComanda.Enter
        If bolManter = False Then
            AlmentarSplit()
        End If

    End Sub

    Private Sub txtComan_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComan.Enter, txtAte.Enter, txtQtd.Enter, txtObs.Enter, txtCodProd.Enter, txtCodProd.Enter
        If bolManter = False Then
            DiminuirSplit()
        End If

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If bolFunc = False Then
            If Me.txtAte.Text <> "" Then
                intCodFunc = Me.txtAte.Text
                bolFunc = True
            Else
                If Me.CheckEdit1.Checked = True Then
                    Validar(Me.txtAte)
                End If
                Me.CheckEdit1.Checked = False
            End If
        Else
            intCodFunc = 0
            bolFunc = False
        End If
    End Sub

    Dim bolConsultaProduto As Boolean = False
    Private Sub ConsultaProduto()
        'bolConsultaPreco = False
        If bolConsultaProduto = True Then
            bolConsultaProduto = False
            'Me.txtCodProd.Properties.AppearanceReadOnly.BackColor = Color.White
            Me.txtCodProd.ForeColor = Color.Black
            Me.txtCodProd.BackColor = Color.White
            'Me.txtValor.Properties.AppearanceReadOnly.BackColor = Color.RoyalBlue
        Else
            bolConsultaProduto = True
            'Me.txtCodProd.Text = "DIGITE SUA BUSCA"
            'Me.txtCodProd.Properties.AppearanceReadOnly.BackColor = Color.DarkGreen
            Me.txtCodProd.ForeColor = Color.White
            Me.txtCodProd.BackColor = Color.DarkGreen
            'Me.txtCodProd.Properties.AppearanceReadOnly.BackColor = Color.DarkGreen
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.txtCodProd.Text = "$" Or Me.txtCodProd.Text = "%" Or Me.txtCodProd.Text = " " Then
            Me.txtCodProd.ResetText()
        End If
        Timer3.Stop()
    End Sub

    Private Sub AlterarCliente(ByVal parCodCli As String, ByVal parNome As String)
        If Me.txtComan.Text <> "" Then
            Try
                Dim dtComanda As DataTable = CarregarDataTable("Select CodOrdens From Comanda Where CodComanda=" & Me.txtComan.Text & " And Status='Aberto' And Comanda.CodConfig=" & CodConfig & " Group By CodOrdens")

                If dtComanda.Rows.Count > 0 Then
                    Inserir("Update Comanda set CodCli='" & parCodCli & "', Nome='" & parNome & "' Where CodComanda=" & Me.txtComan.Text & " And Status='Aberto' And Comanda.CodConfig=" & CodConfig & " And CodOrdens='" & dtComanda.Rows.Item(0).Item("CodOrdens").ToString & "'")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd2, Me, False, Me.btnPadrao)
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Me.txtAte.Focus()
        Me.Timer4.Stop()
    End Sub

    Private Sub txtValorFrete_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorFrete.Leave
        If Me.txtValorFrete.Text <> "" Then
            Dim dblFrete As Double = Me.txtValorFrete.Text
            Me.txtValorFrete.Text = dblFrete.ToString("0.00")
        End If
        Calcular()
        Me.txtObs.Focus()
    End Sub


    Private Shared Function ValorTabela(ByVal parCodProd As Integer, ByVal parTabela As String) As Double
        Dim dbValor As Double
        Dim dt As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='" & parTabela & "'")
        Dim Codigo As Integer = dt.Rows.Item(0).Item("Codigo").ToString

        Dim dtTabela As DataTable = CarregarDataTable("Select Valor From TabelaPreco Where CodTabela=" & Codigo & " And CodProd=" & parCodProd & "")
        If dtTabela.Rows.Count > 0 Then
            If dtTabela.Rows.Item(0).Item("Valor").ToString <> "" Then
                dbValor = dtTabela.Rows.Item(0).Item("Valor").ToString()
            Else
                dbValor = 0
            End If
        Else
            dbValor = 0
        End If
        Return CampoValor(dbValor)

    End Function

    Private Sub cboTabela_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTabela.EditValueChanged
        If TabelaPrecoPorItem = True Then Exit Sub


        If bolTabela = False Then Exit Sub
        If Me.grd1.RowCount > 0 Then
            If Me.cboTabela.Text <> "PADRÃO" Then
                Dim I As Integer
                Dim dbValor As Double

                For I = 0 To Me.grd1.RowCount - 1
                    Dim dt As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='" & Me.cboTabela.Text.Trim & "'")
                    Dim Codigo As Integer = dt.Rows.Item(0).Item("Codigo").ToString

                    Dim CodProd As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                    Dim strCodC As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                    Dim dtTabela As DataTable = CarregarDataTable("Select Valor From TabelaPreco Where CodTabela=" & Codigo & " And CodProd=" & CodProd & "")
                    If dtTabela.Rows.Count > 0 Then
                        If dtTabela.Rows.Item(0).Item("Valor").ToString <> "" Then
                            dbValor = dtTabela.Rows.Item(0).Item("Valor").ToString()
                        Else
                            dbValor = 0
                        End If
                    Else
                        dbValor = 0
                    End If

                    Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    Dim dblTot As Double = dblQtd * dbValor
                    'If resCasasDecimais = True Then
                    '    Me.grd1.SetRowCellValue(I, Me.colValorUnitario, dbValor.ToString("0.000"))
                    '    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dbValor.ToString("0.000"))
                    '    Me.grd1.SetRowCellValue(I, Me.colUniSemDesc, dbValor.ToString("0.00"))
                    'Else
                    Me.grd1.SetRowCellValue(I, Me.colValorUnitario, CampoValor(dbValor))
                    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dblTot.ToString("0.00"))
                    'End If

                    Atualizar("UPDATE Comanda SET ValorUnitario = " & Num(CampoValor(dbValor)) & ", TabelaPreco = '" & Me.cboTabela.Text.Trim & "' where Codigo = " & strCodC)


                Next
                Calcular()

            Else
                Dim I As Integer
                Dim dbValor As Double

                For I = 0 To Me.grd1.RowCount - 1
                    Dim strCodC As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                    Dim CodProd As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                    Dim dt As DataTable = CarregarDataTable("Select Valor, Desconto From Produto Where Codigo=" & CodProd & "")
                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Valor").ToString <> "" Then
                            dbValor = dt.Rows.Item(0).Item("Valor").ToString()
                        Else
                            dbValor = 0
                        End If
                        If dt.Rows.Item(0).Item("Desconto").ToString <> "" Then
                            Dim dblPerDesc, dblResto As Double
                            dblPerDesc = dt.Rows.Item(0).Item("Desconto").ToString

                            dblResto = (dbValor / 100) * dblPerDesc

                            dbValor = dbValor - dblResto
                        End If

                    Else
                        dbValor = 0
                    End If



                    'If resCasasDecimais = True Then
                    '    Me.grd1.SetRowCellValue(I, Me.colValorUnitario, dbValor.ToString("0.000"))
                    '    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dbValor.ToString("0.000"))
                    '    Me.grd1.SetRowCellValue(I, Me.colUniSemDesc, dbValor.ToString("0.00"))
                    'Else
                    Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    Dim dblTot As Double = dblQtd * dbValor
                    Me.grd1.SetRowCellValue(I, Me.colValorUnitario, CampoValor(dbValor))
                    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dblTot.ToString("0.00"))
                    'End If

                    Atualizar("UPDATE Comanda SET ValorUnitario = " & Num(CampoValor(dbValor)) & ", TabelaPreco = '" & Me.cboTabela.Text.Trim & "' where Codigo = " & strCodC)

                Next
                Calcular()
            End If
        End If
    End Sub
End Class