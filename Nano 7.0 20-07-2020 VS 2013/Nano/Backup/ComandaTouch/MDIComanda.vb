Imports Nano.clsFuncoes
Public Class MDIComanda

    Private Sub MDIComanda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'FecharTeclado()
        FecharTecladoArquivo(True)
        FormAberto = ""
        frmComandaPrincipal.Close()
        frmComandaProduto.Close()
        frmComandaSetor.Close()
        frmAbrirComanda.Close()
        frmComandaQtde.Close()
        frmComandaItens.Close()
        frmConfigComanda.Close()
        frmCadCliente.Close()
    End Sub

    Private Sub MDIComanda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

        AbrirTecladoArquivo(False)

        If IO.File.Exists(My.Application.Info.DirectoryPath & "\ConfigComanda.txt") = True Then

            Dim strStringColor As String = LerArquivo(My.Application.Info.DirectoryPath & "\ConfigComanda.txt", False)
            ConverterColor(strStringColor)

        Else
            CorFundo = Color.AliceBlue
            CorBarra = Color.DarkSlateGray
            CorTeclado = Color.Azure
            CorComanda = Color.SteelBlue
            CorGrupo = Color.SteelBlue
            CorProduto = Color.MediumAquamarine
            CorFonte = Color.AliceBlue
            CorBotoes = Color.DarkSlateGray
            LocationTeclado = 300
            CorImagemBarra = "Laranja"
            CorImagemBotao = "Laranja"
        End If
        Me.PictureEdit1.Properties.Appearance.BackColor = CorBarra
        Me.btnAbrirComanda.Appearance.BackColor = CorBarra
        Me.SimpleButton1.Appearance.BackColor = CorBarra
        Me.btnComandaPrincipal.Appearance.BackColor = CorBarra
        Me.btnVoltar.Appearance.BackColor = CorBarra
        Me.lblHora.Appearance.BackColor = CorBarra
        Me.btnTeclado.Appearance.BackColor = CorBarra
        Me.btnConfigComanda.Appearance.BackColor = CorBarra
        Me.btnConsultar.Appearance.BackColor = CorBarra
        Me.btnReabrirComanda.Appearance.BackColor = CorBarra
        Me.btnVender.Appearance.BackColor = CorBarra
        If TecladoVirtual = False Then
            Me.btnTeclado.Visible = False
        End If
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra) = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Novo.png") = True Then
                Me.btnAbrirComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Novo.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Comanda.png") = True Then
                Me.btnComandaPrincipal.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Comanda.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Voltar.png") = True Then
                Me.btnVoltar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Voltar.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Teclado.png") = True Then
                Me.btnTeclado.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Teclado.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Fechar.png") = True Then
                Me.SimpleButton1.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Fechar.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Config.png") = True Then
                Me.btnConfigComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Config.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Consultar.png") = True Then
                Me.btnConsultar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Consultar.png")
            End If

            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Reabrir.png") = True Then
                Me.btnReabrirComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Reabrir.png")
            End If

            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Finalizar.png") = True Then
                Me.btnVender.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Finalizar.png")
            End If
        End If

 
        CodConfig = 1
        StringDeConexao = My.Settings.dsNanoCommerce
        'strForm = "frmComandaPrincipal"
        frmComandaPrincipal.MdiParent = Me
        frmComandaPrincipal.Show()
        frmComandaPrincipal.Dock = DockStyle.Fill


    End Sub

    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'FecharTeclado()
        FecharTecladoArquivo(False)



        RetornoMensagemComanda = False

        frmComandaMensagem.lblMensagem.Text = "Deseja realmente sair da comanda?"
        frmComandaMensagem.btnSim.Visible = True
        frmComandaMensagem.btnNao.Text = "Não"
        frmComandaMensagem.Size = New System.Drawing.Size(529, 210)
        frmComandaMensagem.btnNao.Location = New System.Drawing.Point(319, 107)
        frmComandaMensagem.ShowDialog()

        If RetornoMensagemComanda = True Then
            Me.Close()
        End If
    End Sub

    Private Sub btnComandaPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComandaPrincipal.Click
        'FecharTeclado()

        FecharTecladoArquivo(False)

        If FormAberto = "frmComandaItens" Then Exit Sub
        frmComandaProduto.Close()
        frmComandaSetor.Close()
        frmAbrirComanda.Close()
        frmComandaQtde.Close()
        frmComandaItens.Close()
        frmConfigComanda.Close()
        frmCadCliente.Close()

        frmComandaPrincipal.txtCliente.Properties.Appearance.ForeColor = Color.LightGray
        frmComandaPrincipal.txtCliente.Properties.CharacterCasing = CharacterCasing.Normal
        frmComandaPrincipal.txtCliente.Text = "Digite o número da comanda/mesa"
        frmComandaPrincipal.MdiParent = Me
        frmComandaPrincipal.Show()
        frmComandaPrincipal.Dock = DockStyle.Fill
    End Sub

    Private Sub btnAbrirComanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirComanda.Click
        If FormAberto <> "frmAbrirComanda" Then
            'FecharTeclado()
            FecharTecladoArquivo(False)

            If FormAberto = "frmComandaItens" Then Exit Sub
            frmComandaSetor.Close()
            frmComandaPrincipal.Close()
            frmComandaQtde.Close()
            frmComandaItens.Close()
            frmComandaProduto.Close()
            frmConfigComanda.Close()
            frmCadCliente.Close()

            frmAbrirComanda.MdiParent = Me
            frmAbrirComanda.Show()
            frmAbrirComanda.Dock = DockStyle.Fill
        End If
      
    End Sub

    Private Sub btnTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeclado.Click
        'FecharTeclado()
        Select Case FormAberto
            Case "frmComandaPrincipal"
                If frmComandaPrincipal.txtCliente.Text = "Digite o número da comanda/mesa" Then
                    frmComandaPrincipal.txtCliente.Text = ""
                    frmComandaPrincipal.txtCliente.Properties.Appearance.ForeColor = Color.Gray
                End If
                frmComandaPrincipal.txtCliente.Focus()
                frmComandaPrincipal.pnlTeclado.Visible = True
                'IniciaThreadTeclado()

            Case "frmComandaSetor"
                If frmComandaSetor.txtCliente.Text = "Digite o nome do grupo" Then
                    frmComandaSetor.txtCliente.Text = ""
                    frmComandaSetor.txtCliente.Properties.Appearance.ForeColor = Color.Gray
                End If
                frmComandaSetor.txtCliente.Focus()
                frmComandaSetor.pnlTeclado.Visible = True
                'IniciaThreadTeclado()
            Case "frmComandaProduto"
                If frmComandaProduto.txtCliente.Text = "Digite o nome do produto" Then
                    frmComandaProduto.txtCliente.Text = ""
                    frmComandaProduto.txtCliente.Properties.Appearance.ForeColor = Color.Gray
                End If
                frmComandaProduto.txtCliente.Focus()
                frmComandaProduto.pnlTeclado.Visible = True
                'IniciaThreadTeclado()
            Case "frmComandaQtde"
                frmComandaQtde.txtQtde.Focus()
                frmComandaQtde.pnlTeclado.Visible = True
                frmComandaQtde.pnlAdicionados.Visible = False
                frmComandaQtde.pnlOpcoes.Visible = False
                frmComandaQtde.pnlObservacao.Dock = DockStyle.Top
                'IniciaThreadTeclado()
            Case "frmComandaItens", "frmComandaItensCONSULTAR"
                frmComandaItens.txtObservacao.Focus()
                frmComandaItens.pnlTeclado.Visible = True
                frmComandaItens.PanelControl3.Visible = False
                frmComandaItens.PanelControl4.Visible = False
                frmComandaItens.PanelControl5.Dock = DockStyle.Top
                'IniciaThreadTeclado()
            Case "frmAbrirComanda"
                frmAbrirComanda.txtComanda.Focus()
            Case "frmCadCliente"
                'IniciaThreadTeclado()

        End Select

        AbrirTecladoArquivo(True)

    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigComanda.Click
        If FormAberto = "frmComandaItens" Then Exit Sub
        'FecharTeclado()

        FecharTecladoArquivo(False)

        frmComandaSetor.Close()
        frmComandaPrincipal.Close()
        frmComandaQtde.Close()
        frmComandaItens.Close()
        frmComandaProduto.Close()
        frmConfigComanda.Close()
        frmCadCliente.Close()

        frmConfigComanda.MdiParent = Me
        frmConfigComanda.Show()
        frmConfigComanda.Dock = DockStyle.Fill
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblHora.Text = My.Computer.Clock.LocalTime
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        'FecharTeclado()

        FecharTecladoArquivo(False)

        If FormAberto = "frmComandaItens" Then Exit Sub
        Select Case FormAberto
            Case "frmComandaPrincipal"
            Case "frmCadCliente"
                frmComandaProduto.Close()
                frmComandaSetor.Close()
                frmAbrirComanda.Close()
                frmComandaQtde.Close()
                frmComandaItens.Close()
                frmConfigComanda.Close()

                frmAbrirComanda.txtComanda.Text = frmCadCliente.strComanda
                frmAbrirComanda.txtMesa.Text = frmCadCliente.strMesa
                frmCadCliente.Close()
                frmAbrirComanda.MdiParent = Me
                frmAbrirComanda.Show()
                frmAbrirComanda.Dock = DockStyle.Fill

            Case "frmComandaSetor", "frmComandaItensCONSULTAR", "frmAbrirComanda", "frmConfigComanda"
                frmComandaProduto.Close()
                frmComandaSetor.Close()
                frmAbrirComanda.Close()
                frmComandaQtde.Close()
                frmComandaItens.Close()
                frmConfigComanda.Close()
                frmCadCliente.Close()

                frmComandaPrincipal.MdiParent = Me
                frmComandaPrincipal.Show()
                frmComandaPrincipal.Dock = DockStyle.Fill
            Case "frmComandaProduto"

                frmComandaPrincipal.Close()
                frmAbrirComanda.Close()
                frmComandaQtde.Close()
                frmComandaItens.Close()
                frmConfigComanda.Close()
                frmCadCliente.Close()

                frmComandaSetor.strCodComanda = frmComandaProduto.strCodComanda
                frmComandaProduto.Close()
                frmComandaSetor.MdiParent = Me
                frmComandaSetor.Show()
                frmComandaSetor.Dock = DockStyle.Fill
            Case "frmComandaQtde"
                frmComandaPrincipal.Close()
                frmComandaSetor.Close()
                frmAbrirComanda.Close()
                frmComandaItens.Close()
                frmConfigComanda.Close()
                frmCadCliente.Close()

                frmComandaProduto.strSetor = frmComandaQtde.strSetor
                frmComandaProduto.strCodComanda = frmComandaQtde.strCodComanda
                frmComandaQtde.Close()
                frmComandaProduto.MdiParent = Me
                frmComandaProduto.Show()
                frmComandaProduto.Dock = DockStyle.Fill
          
        End Select
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Select Case FormAberto
            Case "frmComandaPrincipal"
                If frmComandaPrincipal.LayoutView1.FocusedRowHandle < 0 Then Exit Sub

                Dim strCodComanda As String = frmComandaPrincipal.LayoutView1.GetRowCellDisplayText(frmComandaPrincipal.LayoutView1.FocusedRowHandle, "CodOrdens")

                'FecharTeclado()


                'If frmComandaPrincipal.LayoutView1.GetRowCellDisplayText(frmComandaPrincipal.LayoutView1.FocusedRowHandle, "Status") = "FECHADO" Then

                '    frmComandaMensagem.lblMensagem.Text = "Comanda fechada, não é possível alterar!"
                '    frmComandaMensagem.btnSim.Visible = False
                '    frmComandaMensagem.btnNao.Text = "Ok"
                '    frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
                '    frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
                '    frmComandaMensagem.ShowDialog()
                '    Exit Sub
                'End If


                FecharTecladoArquivo(False)

                frmComandaPrincipal.Close()
                frmComandaItens.Tag = "CONSULTAR"
                frmComandaItens.MdiParent = Me
                frmComandaItens.strCodComanda = strCodComanda
                frmComandaItens.Show()
                frmComandaItens.Dock = DockStyle.Fill

        End Select
    End Sub

    Private Sub btnReabrirComanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReabrirComanda.Click
        Select Case FormAberto
            Case "frmComandaPrincipal"
                If frmComandaPrincipal.LayoutView1.FocusedRowHandle < 0 Then Exit Sub
                If frmComandaPrincipal.LayoutView1.GetRowCellDisplayText(frmComandaPrincipal.LayoutView1.FocusedRowHandle, "Status") = "ABERTO" Then
                    Exit Sub
                End If
                Dim strCodComanda As String = ""
                Dim strCodOrdens As String = frmComandaPrincipal.LayoutView1.GetRowCellDisplayText(frmComandaPrincipal.LayoutView1.FocusedRowHandle, "CodOrdens")
                Dim dt As DataTable = CarregarDataTable("SELECT CodComanda FROM Comanda where CodOrdens = " & strCodOrdens & " and CodConfig = " & CodConfig)
                If dt.Rows.Count > 0 Then
                    strCodComanda = dt.Rows.Item(0).Item("CodComanda").ToString
                End If

                RetornoMensagemComanda = False

                frmComandaMensagem.lblMensagem.Text = "Deseja realmente reabrir a Comanda " & strCodComanda & " ?"
                frmComandaMensagem.btnSim.Visible = True
                frmComandaMensagem.btnNao.Text = "Não"
                frmComandaMensagem.Size = New System.Drawing.Size(588, 210)
                frmComandaMensagem.btnNao.Location = New System.Drawing.Point(378, 107)
                frmComandaMensagem.ShowDialog()
              

                If RetornoMensagemComanda = True Then
                    If SenhaAdm = True Then
                        RetornoMensagemComanda = False
                        frmComandaExcluir.ShowDialog()
                    End If
                    If RetornoMensagemComanda = True Then

                        Atualizar("Update Comanda Set Status ='Aberto' where CodOrdens = '" & strCodOrdens & "' and Status = 'Fechado' and CodConfig = " & CodConfig)
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Comanda " & strCodComanda & " Fechado" & "','Aberto','COMANDA','COMANDA','REABERTURA'," & CodConfig & ")")
                        frmComandaPrincipal.LayoutView1.SetRowCellValue(frmComandaPrincipal.LayoutView1.FocusedRowHandle, "Status", "ABERTO")

                    End If
                End If
            Case "frmComandaItens", "frmComandaItensCONSULTAR"

                If frmComandaItens.grd1.RowCount = 0 Then Exit Sub
                If frmComandaItens.SimpleButton1.Visible = False Then
                    Exit Sub
                End If
                Dim strCodComanda As String = frmComandaItens.txtComanda.Text
                Dim strCodOrdens As String = frmComandaItens.strCodComanda

                RetornoMensagemComanda = False

                frmComandaMensagem.lblMensagem.Text = "Deseja realmente reabrir a Comanda " & strCodComanda & " ?"
                frmComandaMensagem.btnSim.Visible = True
                frmComandaMensagem.btnNao.Text = "Não"
                frmComandaMensagem.Size = New System.Drawing.Size(588, 210)
                frmComandaMensagem.btnNao.Location = New System.Drawing.Point(378, 107)
                frmComandaMensagem.ShowDialog()


                If RetornoMensagemComanda = True Then
                    If SenhaAdm = True Then
                        RetornoMensagemComanda = False
                        frmComandaExcluir.ShowDialog()
                    End If
                    If RetornoMensagemComanda = True Then

                        Atualizar("Update Comanda Set Status ='Aberto' where CodOrdens = '" & strCodOrdens & "' and Status = 'Fechado' and CodConfig = " & CodConfig)
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Comanda " & strCodComanda & " Fechado" & "','Aberto','COMANDA','COMANDA','REABERTURA'," & CodConfig & ")")
                        frmComandaItens.btnObs.Appearance.BackColor = Color.Tomato
                        frmComandaItens.SimpleButton3.Appearance.BackColor = Color.LightBlue
                        frmComandaItens.SimpleButton5.Appearance.BackColor = Color.LightBlue
                        frmComandaItens.SimpleButton1.Appearance.BackColor = Color.LightBlue
                        frmComandaItens.SimpleButton1.Visible = False
                        frmComandaItens.strStatusComanda = "ABERTO"
                    End If
                End If

        End Select

    End Sub

    Private Sub btnVender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVender.Click
        Dim strComanda As String = ""
        Dim strCodOrdens As String = ""
        Dim strObs As String = ""
        Select Case FormAberto
            Case "frmComandaPrincipal"
                If frmComandaPrincipal.LayoutView1.FocusedRowHandle < 0 Then Exit Sub

                strCodOrdens = frmComandaPrincipal.LayoutView1.GetRowCellDisplayText(frmComandaPrincipal.LayoutView1.FocusedRowHandle, "CodOrdens")
                Dim dt As DataTable = CarregarDataTable("SELECT CodComanda FROM Comanda where CodOrdens = " & strCodOrdens & " and CodConfig = " & CodConfig)
                If dt.Rows.Count > 0 Then
                    strComanda = dt.Rows.Item(0).Item("CodComanda").ToString
                End If
            Case "frmComandaItens", "frmComandaItensCONSULTAR"
                strComanda = frmComandaItens.txtComanda.Text
                strCodOrdens = frmComandaItens.strCodComanda
                strObs = frmComandaItens.txtObservacao.Text
        End Select

        If strComanda = "" Then Exit Sub

        If ProcuraForm("frmVenda") = "frmVenda" Then

            If frmVenda.grd1.RowCount > 0 Then
                MsgBox("Não é possivel realizar esse procedimento pois já existe uma venda sendo realizada!", MsgBoxStyle.Information)
                Exit Sub
            End If
            FinalizarComanda(strComanda, strCodOrdens, strObs)
            Dim dt As DataTable = CarregarDataTable("SELECT Status FROM Comanda where CodComanda = '" & strComanda & "' and Status = 'Fechado' and CodConfig = " & CodConfig)
            If dt.Rows.Count = 0 Then Exit Sub
            ConsultaPedido = strComanda
            frmVenda.F8(False)
            frmVenda.WindowState = FormWindowState.Maximized

        Else
            FinalizarComanda(strComanda, strCodOrdens, strObs)
            Dim dt As DataTable = CarregarDataTable("SELECT Status FROM Comanda where CodComanda = '" & strComanda & "' and Status = 'Fechado' and CodConfig = " & CodConfig)
            If dt.Rows.Count = 0 Then Exit Sub
            ConsultaPedido = strComanda
            'frmVenda.bolPedido = True
            frmVenda.Show()
            frmVenda.F8(False)

        End If

        VendaComComanda = True

    End Sub

    Private Sub FinalizarComanda(ByVal parComanda As String, ByVal parCodOrdens As String, ByVal parObs As String)
        Atualizar("Update Comanda Set Status ='Fechado', " & _
        "Troco =0, APP = 'True' where CodComanda = '" & parComanda & "' and Status = 'Aberto' and CodConfig = " & CodConfig)


        Dim dtComanda As DataTable = CarregarDataTable("SELECT Codigo, ValorPago FROM R7 where CodUser = " & parCodOrdens & " and CodConfig = " & CodConfig)
        If dtComanda.Rows.Count > 0 Then
            If dtComanda.Rows.Item(0).Item("ValorPago").ToString <> "" Then
                QtdePessoasMesa = CInt(dtComanda.Rows.Item(0).Item("ValorPago"))
            End If
        Else
            QtdePessoasMesa = "0"
            RetornoNumeroComanda = 0
            frmComandaSelecionar.Tag = "QTDE"
            frmComandaSelecionar.ShowDialog()
            QtdePessoasMesa = RetornoNumeroComanda
        End If

        If dtComanda.Rows.Count > 0 Then
            Atualizar("UPDATE R7 set COO = '" & parObs & "', ValorPago = " & Num(QtdePessoasMesa) & " where CodUser = " & parCodOrdens & " and Codconfig = " & CodConfig)

        Else
            Inserir("INSERT INTO R7 (CodUser, COO, ValorPago, CodConfig) VALUES (" & parCodOrdens & ",'" & parObs & "'," & _
            "" & Num(QtdePessoasMesa) & "," & CodConfig & ")")

        End If

        ''If parVender = False Then
        'If ImprimeComanda = True Then
        '    Imprimir()
        'End If
    End Sub
End Class