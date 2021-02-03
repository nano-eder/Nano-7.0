Imports Nano.clsFuncoes
Imports Nano.clsImprimir
Public Class frmComandaItens

    Public strCodComanda As String
    Dim strEndereco As String
    Dim strTelefone As String

    Public strStatusComanda As String
    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoProduto.Click
        'FecharTeclado()
        FecharTecladoArquivo(False)



        If strStatusComanda = "FECHADO" Then

            frmComandaMensagem.lblMensagem.Text = "Comanda fechada, não é possível alterar!"
            frmComandaMensagem.btnSim.Visible = False
            frmComandaMensagem.btnNao.Text = "Ok"
            frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
            frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
            frmComandaMensagem.ShowDialog()
            Exit Sub
        End If

        Me.Close()
        frmComandaPrincipal.Close()
        frmComandaSetor.MdiParent = MDIComanda
        frmComandaSetor.strCodComanda = strCodComanda

        frmComandaSetor.Show()
        frmComandaSetor.Dock = DockStyle.Fill
    End Sub

    'Private Sub frmComandaItens_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = 91 Or e.KeyCode = Keys.Escape Or e.KeyCode = 13 Then
    '        Me.pnlTeclado.Visible = False
    '        FecharTeclado()
    '    End If
    'End Sub
    Private Sub CarregarGrid()
        Me.tbItens.Rows.Clear()
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, CodComanda, Mesa, Nome, CodProd, CodProdInterno, Produto, Qtd, ValorUnitario, convert(Numeric(15,2), Qtd * ValorUnitario) as ValorTotal, Opcoes, Obs, Status FROM Comanda where CodOrdens = " & strCodComanda & " and CodConfig = " & CodConfig)
        Dim I As Integer
        If dt.Rows.Count > 0 Then
            Me.txtComanda.Text = dt.Rows.Item(0).Item("CodComanda").ToString
            Me.txtMesa.Text = dt.Rows.Item(0).Item("Mesa").ToString
            If dt.Rows.Item(0).Item("Nome").ToString <> "" Then
                Me.txtCliente.Text = dt.Rows.Item(0).Item("Nome").ToString

            Else
                Me.txtCliente.Text = "CONSUMIDOR"

            End If
            strStatusComanda = dt.Rows.Item(0).Item("Status").ToString.ToUpper
            For I = 0 To dt.Rows.Count - 1
                If dt.Rows.Item(I).Item("Produto").ToString <> "INSERIR" Then
                    Me.tbItens.Rows.Add()
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("CodProd") = dt.Rows.Item(I).Item("CodProd").ToString
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("CodigoInterno") = dt.Rows.Item(I).Item("CodProdInterno").ToString
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("Produto") = dt.Rows.Item(I).Item("Produto").ToString
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("ValorUnitario") = dt.Rows.Item(I).Item("ValorUnitario").ToString
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("ValorTotal") = dt.Rows.Item(I).Item("ValorTotal").ToString
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("Opcoes") = dt.Rows.Item(I).Item("Opcoes").ToString
                    Me.tbItens.Rows.Item(Me.tbItens.Rows.Count - 1).Item("Observacao") = dt.Rows.Item(I).Item("Obs").ToString
                End If
            Next
        End If
        Calcular()
    End Sub
    Private Sub frmComandaItens_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Tag = "CONSULTAR" Then
            FormAberto = Me.Name & "CONSULTAR"
        Else
            FormAberto = Me.Name
        End If



        Timer1.Start()

        Me.btnNovoProduto.Focus()
        Me.PanelControl1.Controls.Add(Me.PictureEdit5)
        CarregarGrid()
        Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.grd1.OptionsSelection.EnableAppearanceHideSelection = False
        Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = False

        Me.btnExcluirComanda.Appearance.BackColor = CorBotoes
        Me.btnExcluirItem.Appearance.BackColor = CorBotoes
        Me.btnFinalizar.Appearance.BackColor = CorBotoes
        Me.btnImprimir.Appearance.BackColor = CorBotoes
        Me.btnNovoProduto.Appearance.BackColor = CorBotoes
        Me.lblImpressora.Appearance.BackColor = CorBotoes
        Me.lblImpressora.Appearance.ForeColor = Me.btnImprimir.Appearance.ForeColor
        Me.btnFechar.Appearance.BackColor = CorBotoes
        Me.cboImpressora.Properties.Buttons.Item(0).Appearance.BackColor = CorBotoes
        Me.cboImpressora.BackColor = CorBotoes
        Me.btnTransferir.Appearance.BackColor = CorBotoes

        Me.BackColor = CorFundo
        Me.PictureEdit1.BackColor = CorFundo
        Me.PictureEdit2.BackColor = CorFundo
        Me.PictureEdit3.BackColor = CorFundo
        Me.PictureEdit4.BackColor = CorFundo
        Me.PictureEdit5.BackColor = CorFundo
        Me.LabelControl1.BackColor = CorFundo
        Me.LabelControl2.BackColor = CorFundo
        Me.LabelControl3.BackColor = CorFundo

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao) = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Ok.png") = True Then
                Me.btnFinalizar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Ok.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Impressora.png") = True Then
                Me.btnImprimir.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Impressora.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Excluir.png") = True Then
                Me.btnExcluirComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Excluir.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/ExcluirItem.png") = True Then
                Me.btnExcluirItem.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\ExcluirItem.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Mais.png") = True Then
                Me.btnNovoProduto.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Mais.png")
            End If

            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Finalizar.png") = True Then
                Me.btnFechar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Finalizar.png")
            End If

            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Transferir.png") = True Then
                Me.btnTransferir.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Transferir.png")
            End If
        End If

        Me.cboImpressora.Properties.Items.Clear()
        Dim dtGrupo As DataTable = CarregarDataTable("SELECT PortaImpressora, Impressora FROM grupo where PortaImpressora<>'' group by PortaImpressora, Impressora")
        Me.cboImpressora.Properties.Items.Add(PortaImpressora & " | " & Impressora)
        Me.lblImpressora.Text = PortaImpressora & " | " & Impressora
        Dim I As Integer
        For I = 0 To dtGrupo.Rows.Count - 1
            Me.cboImpressora.Properties.Items.Add(dtGrupo.Rows.Item(I).Item("PortaImpressora").ToString & " | " & dtGrupo.Rows.Item(I).Item("Impressora").ToString)
        Next


        If strStatusComanda = "FECHADO" Then
            'Me.btnObs.Text = "Observação                                                                         Comanda Fechada"
            Me.SimpleButton1.Visible = True
            Me.btnObs.Appearance.BackColor = Color.Tomato
            Me.SimpleButton3.Appearance.BackColor = Color.Tomato
            Me.SimpleButton5.Appearance.BackColor = Color.Tomato
            Me.SimpleButton1.Appearance.BackColor = Color.Tomato
            'Me.SimpleButton1.Appearance.ForeColor = Color.Tomato
        Else
            Me.SimpleButton1.Visible = False
        End If



    End Sub
    Private Sub grd1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.GotFocus
        Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = True
        Me.grd1.OptionsSelection.EnableAppearanceHideSelection = True
        Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = True

    End Sub

    Private Sub grd1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.LostFocus
        Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.grd1.OptionsSelection.EnableAppearanceHideSelection = False
        Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = False
    End Sub
    Private Sub Calcular()
        Dim I As Integer
        Dim dblValorTotal As Double
        For I = 0 To Me.tbItens.Rows.Count - 1
            If Me.tbItens.Rows.Item(I).Item("ValorTotal").ToString <> "" Then
                dblValorTotal += Me.tbItens.Rows.Item(I).Item("ValorTotal")
            End If
        Next
        Me.txtValorTotal.Text = dblValorTotal.ToString("0.00")
    End Sub

    Private Sub btnExcluirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirItem.Click


    

        


        'FecharTeclado()
        FecharTecladoArquivo(False)


        If strStatusComanda = "FECHADO" Then

            frmComandaMensagem.lblMensagem.Text = "Comanda fechada, não é possível excluir!"
            frmComandaMensagem.btnSim.Visible = False
            frmComandaMensagem.btnNao.Text = "Ok"
            frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
            frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
            frmComandaMensagem.ShowDialog()
            Exit Sub
        End If
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub


        RetornoMensagemComanda = False
        frmComandaMensagem.Tag = ""
        frmComandaMensagem.lblMensagem.Text = "Deseja realmente excluir o item selecionado?"
        frmComandaMensagem.lblMensagem2.Visible = True
        frmComandaMensagem.lblMensagem2.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
        frmComandaMensagem.btnSim.Visible = True
        frmComandaMensagem.btnNao.Text = "Não"
        frmComandaMensagem.Size = New System.Drawing.Size(649, 210)
        frmComandaMensagem.btnNao.Location = New System.Drawing.Point(439, 107)


        frmComandaMensagem.ShowDialog()
        frmComandaMensagem.lblMensagem2.Visible = False
        If RetornoMensagemComanda = True Then

            If SenhaAdm = True Then
                RetornoMensagemComanda = False
                frmComandaExcluir.ShowDialog()
            End If

            If RetornoMensagemComanda = True Then
                Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)

                EnviarImpressao2(strCodigo)

                If Me.grd1.RowCount = 1 Then
                    Inserir("Update Comanda set Produto = 'INSERIR', ValorUnitario = NULL where Codigo = " & strCodigo)

                Else
                    Inserir("DELETE FROM Comanda where Codigo = " & strCodigo)

                End If

                CarregarGrid()
            End If


         
        End If

    End Sub

    Private Sub btnExcluirComanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirComanda.Click
        'FecharTeclado()
        FecharTecladoArquivo(False)

        If strStatusComanda = "FECHADO" Then

            frmComandaMensagem.lblMensagem.Text = "Comanda fechada, não é possível excluir!"
            frmComandaMensagem.btnSim.Visible = False
            frmComandaMensagem.btnNao.Text = "Ok"
            frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
            frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
            frmComandaMensagem.ShowDialog()
            Exit Sub
        End If


        RetornoMensagemComanda = False
        frmComandaMensagem.Tag = ""
        frmComandaMensagem.lblMensagem.Text = "Deseja realmente CANCELAR a comanda atual?"
        frmComandaMensagem.btnSim.Visible = True
        frmComandaMensagem.btnNao.Text = "Não"
        frmComandaMensagem.Size = New System.Drawing.Size(649, 210)
        frmComandaMensagem.btnNao.Location = New System.Drawing.Point(439, 107)
        frmComandaMensagem.ShowDialog()

        If RetornoMensagemComanda = True Then
          
            'frmComandaMensagem.lblMensagem.Text = "Você tem certeza?"
            'frmComandaMensagem.btnSim.Visible = True
            'frmComandaMensagem.btnNao.Text = "Não"
            'frmComandaMensagem.Size = New System.Drawing.Size(411, 210)
            'frmComandaMensagem.btnNao.Location = New System.Drawing.Point(201, 107)
            'frmComandaMensagem.ShowDialog()
            If SenhaAdm = True Then
                RetornoMensagemComanda = False
                frmComandaExcluir.ShowDialog()
            End If

            If RetornoMensagemComanda = True Then
                Inserir("DELETE FROM Comanda where CodOrdens = " & strCodComanda & " and CodConfig = " & CodConfig)
                Me.Close()
                frmComandaPrincipal.Close()
                frmComandaPrincipal.MdiParent = MDIComanda
                frmComandaPrincipal.Show()
                frmComandaPrincipal.Dock = DockStyle.Fill
            End If

        End If
    
    End Sub
    'Private Sub txtObservacao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservacao.GotFocus

    '    Me.pnlTeclado.Visible = True
    '    Me.PanelControl3.Visible = False
    '    Me.PanelControl4.Visible = False
    '    Me.PanelControl5.Dock = DockStyle.Top
    '    IniciaThreadTeclado()
    'End Sub

    'Private Sub txtObservacao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservacao.Leave
    '    Me.PanelControl3.Visible = True
    '    Me.PanelControl4.Visible = True
    '    Me.pnlTeclado.Visible = False
    '    Me.PanelControl5.Dock = DockStyle.Bottom
    '    FecharTeclado()
    '    ''Timer1.Start()
    '    'Dim proc As Process
    '    'For Each proc In Process.GetProcesses
    '    '    If proc.ProcessName = "TecladoNano" Then
    '    '        Try
    '    '            proc.Kill()
    '    '            proc.Close()
    '    '        Catch ex As Exception

    '    '        End Try
    '    '    End If
    '    'Next
    'End Sub

    Private Sub txtObservacao_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservacao.LostFocus
        If TecladoVirtual = True Then
            Me.PanelControl3.Visible = True
            Me.PanelControl4.Visible = True
            Me.pnlTeclado.Visible = False
            Me.PanelControl5.Dock = DockStyle.Bottom
            'FecharTeclado()
            FecharTecladoArquivo(False)
        End If
    
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        ' FecharTeclado()

        FecharTecladoArquivo(False)
        'If Me.grd1.FocusedRowHandle < 0 Then Exit Sub


        EnviarImpressao2("")

        Me.Close()
        frmComandaPrincipal.MdiParent = MDIComanda
        frmComandaPrincipal.Show()
        frmComandaPrincipal.Dock = DockStyle.Fill
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.grd1.RowCount = 0 Then Exit Sub
        Imprimir()
    End Sub

    Private Sub Imprimir()

        If TemImpressora = False Then Exit Sub

        Dim strImp As String = Me.lblImpressora.Text
        If strImp = "" Then MsgBox("Selecione a impressora!", MsgBoxStyle.Information) : Exit Sub

        Dim vetImp As Array = Split(strImp, " | ")
        Dim strPorta As String = vetImp(0)
        Dim strImpressora As String = vetImp(1)

        If strImpressora.Contains("ESC/POS") = True Then
            Dim strImpressao As String


            strImpressao = Cabecalho()

            strImpressao &= Esq(My.Computer.Clock.LocalTime, 55) & vbCrLf & vbCrLf

            strImpressao &= CentralizarComanda(ExpComanda("Comanda/Mesa" & ": " & Me.txtComanda.Text.Trim & "/" & Me.txtMesa.Text, strImpressora), strImpressora) & vbCrLf
            strImpressao &= strTraco & vbCrLf

            If Me.txtCliente.Text <> "CONSUMIDOR" Then
                strImpressao &= Dir("Cliente.: " & Me.txtCliente.Text, 55) & vbCrLf
                'strImpressao &= Dir("Endereco: " & strEndereco, 55) & vbCrLf
                'strImpressao &= Dir("Telefone: " & strTelefone, 55) & vbCrLf
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

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoInterno)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")
                'strCodFunc = Me.grd1.GetRowCellDisplayText(L, Me.colCodFunc)
                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

                Dim P As Integer = 0

                'If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then

                '    Dim vetProd As Array = Split(strProd, "|")

                '    strProd = ""

                '    For P = 0 To vetProd.Length - 1
                '        If vetProd(P).ToString <> "" Then
                '            strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
                '        End If
                '    Next
                '    strProd = Mid(strProd, 1, strProd.Length - 3)
                'End If

                Dim strItem As String

                strItem = strCod & "   " & strProd '& "   (" & strCodFunc & ")"

                If strItem.Length > 55 Then
                    strItem = Mid(strItem, 1, 55)
                End If

                strImpressao &= Dir(strItem, 55) & vbCrLf

                Dim str As String
                str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 44) & Esq("R$ " & strTotal, 11)
                strImpressao &= str & vbCrLf

                'If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
                If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

                    Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

                    Dim vetOpc As Array = Split(strOpci, "|")

                    For P = 0 To vetOpc.Length - 1
                        strOpci = vetOpc(P).ToString
                        strImpressao &= Dir(strOpci, 55) & vbCrLf
                    Next

                End If

                If Me.grd1.GetRowCellDisplayText(L, Me.colObservacao).Trim <> "" Then
                    strImpressao &= Dir("OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObservacao).Trim, 55) & vbCrLf
                End If
                If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then
                    strImpressao &= strTraco.Replace("-", ".") & vbCrLf
                End If

                'End If

            Next

            strImpressao &= strTraco & vbCrLf
            'If DezPorcento = True Then
            '    'If strTipoComanda = "COMANDA" Then
            '    strImpressao &= Esq("Total........: R$ ", 45) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
            '    'strImpressao &= Esq("Taxa 10%.....: R$ ", 45) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
            '    'End If
            'End If



            strImpressao &= Esq("Total Geral..: R$ ", 45) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf

            strImpressao &= " " & vbCrLf


            If QtdePessoasMesa <> "0" And QtdePessoasMesa <> "" Then
                strImpressao &= Dir("Qtde Pessoas: " & QtdePessoasMesa, 55) & vbCrLf
                Dim dblValorPessoa As Double = CDbl(Me.txtValorTotal.Text) / CDbl(QtdePessoasMesa)
                strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
            If Me.txtObservacao.Text <> "" Then
                strImpressao &= "OBSERVAÇÃO: " & Me.txtObservacao.Text & vbCrLf
                strImpressao &= " " & vbCrLf
            End If

            'If strTipoComanda = "ENTREGAR" Then
            '    strImpressao &= strTraco & vbCrLf
            '    strImpressao &= Dir("DODOS DE ENTREGA", 55) & vbCrLf
            '    strImpressao &= Dir("Entregador: " & Me.cboEnt.Text.Trim, 55) & vbCrLf
            '    strImpressao &= Dir("Troco R$..: " & Me.txtTroco.Text.Trim, 55) & vbCrLf
            '    strImpressao &= Dir("Tempo.....: " & Me.cboTempo.Text.Trim, 55) & vbCrLf & vbCrLf
            '    If Me.rdgMaqCartao.SelectedIndex = 1 Then
            '        strImpressao &= Dir("LEVAR MÁQUINA DE CARTÃO" & Me.cboTempo.Text.Trim, 55) & vbCrLf
            '    End If

            'Else
            '    strImpressao &= GerarBarCode(Me.txtComan.Text.Trim) & vbCrLf
            'End If
            'If GerarComissao = True Then
            '    If Me.txtComan.Text.Trim <> "" And strCodigoOrdem <> "" Then
            '        Dim dtFunc As DataTable = CarregarDataTable("SELECT funcionario.Nome FROM Funcionario where Funcionario.Codigo =  " & strCodFunc)
            '        If dtFunc.Rows.Count > 0 Then

            '            strImpressao &= strTraco & vbCrLf
            '            strImpressao &= Dir("Atend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
            '        End If
            '    End If
            'End If

            RodapeComanda(strImpressao, strImpressora, strPorta)
        ElseIf strImpressora.Contains("BEMATECH") Or strImpressora.Contains("ARQUIVO") Or strImpressora.Contains("NANO PRINT") Then

            '    Dim strImpressao As String

            '    Dim intTamEsp As Integer
            '    Dim strEstrela, strTraço As String

            '    If Impressora = "ARQUIVO" Then
            '        intTamEsp = 42
            '        strEstrela = "******************************************"
            '        strTraço = "------------------------------------------"
            '    Else
            '        intTamEsp = 60
            '        strEstrela = "************************************************************"
            '        strTraço = "------------------------------------------------------------"
            '    End If

            '    strImpressao = strEstrela & vbCrLf

            '    strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
            '    strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
            '    strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf

            '    strImpressao &= strEstrela & vbCrLf
            '    strImpressao &= Esq(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf

            '    strImpressao &= strTraço & vbCrLf & vbCrLf
            '    strImpressao &= Cent(Me.colCodComanda.Caption.ToUpper & ":  " & Me.txtComan.Text.Trim, intTamEsp) & vbCrLf & vbCrLf
            '    strImpressao &= strTraço & vbCrLf

            '    If Me.lblCli.Text <> "CONSUMIDOR" Then
            '        strImpressao &= "Cliente.: " & Me.lblCli.Text & vbCrLf
            '        strImpressao &= "Endereco: " & Me.lblEnd.Text & vbCrLf
            '        strImpressao &= "Telefone: " & Me.txtTel.Text & vbCrLf
            '        strImpressao &= strTraço & vbCrLf
            '    End If

            '    strImpressao &= "ITEM CÓDIGO    DESCRICAO                  " & vbCrLf
            '    strImpressao &= Dir("UN.   QTD.     VL UNIT R$      VL TOTAL R$", intTamEsp) & vbCrLf
            '    strImpressao &= strTraço & vbCrLf

            '    Dim L As Integer
            '    Dim dblQtd As Double
            '    For L = 0 To Me.grd1.RowCount - 1
            '        Dim strCod, strProd, strUni, strQtd, strTotal As String

            '        strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdInterno)
            '        strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
            '        strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
            '        strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
            '        strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

            '        dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

            '        Dim P As Integer = 0

            '        If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
            '            strImpressao &= strTraço.Replace("-", ".") & vbCrLf

            '            Dim vetProd As Array = Split(strProd, "|")

            '            strProd = ""

            '            For P = 0 To vetProd.Length - 1
            '                If vetProd(P).ToString <> "" Then
            '                    strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
            '                End If
            '            Next
            '            strProd = Mid(strProd, 1, strProd.Length - 3)
            '        End If

            '        strImpressao &= L + 1 & "   " & strCod & "   " & strProd & vbCrLf

            '        Dim str As String
            '        str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 31) & Esq("R$ " & strTotal, 11)
            '        strImpressao &= str & vbCrLf

            '        If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
            '            If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

            '                Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

            '                Dim vetOpc As Array = Split(strOpci, "|")

            '                For P = 0 To vetOpc.Length - 1
            '                    strOpci = vetOpc(P).ToString
            '                    strImpressao &= strOpci & vbCrLf
            '                Next

            '            End If

            '            If Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim <> "" Then
            '                strImpressao &= "OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim & vbCrLf
            '            End If

            '            strImpressao &= strTraço.Replace("-", ".") & vbCrLf
            '        End If

            '    Next


            '    strImpressao &= strTraço & vbCrLf
            '    'strImpressao &= Esq("N de Itens......: ", 32) & Esq(dblQtd, 10) & vbCrLf
            '    If DezPorcento = True Then
            '        If strTipoComanda = "COMANDA" Then
            '            strImpressao &= Esq("Total........: R$ ", 32) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
            '            strImpressao &= Esq("Taxa 10%.....: R$ ", 32) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
            '        End If
            '    End If

            '    strImpressao &= Esq("Total Geral..: R$ ", 32) & Esq(Me.txtGeral.Text.Trim, 10) & vbCrLf

            '    strImpressao &= " " & vbCrLf
            '    If QtdePessoasMesa <> "0" And QtdePessoasMesa <> "" Then
            '        strImpressao &= Dir("Qtde Pessoas: " & QtdePessoasMesa, 55) & vbCrLf
            '        Dim dblValorPessoa As Double = CDbl(Me.txtGeral.Text) / CDbl(QtdePessoasMesa)
            '        strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
            '        strImpressao &= " " & vbCrLf
            '    End If
            '    If Me.txtObs.Text <> "" Then
            '        strImpressao &= "OBSERVAÇÃO: " & Me.txtObs.Text & vbCrLf
            '        strImpressao &= " " & vbCrLf
            '    End If
            '    If strTipoComanda <> "COMANDA" Then
            '        strImpressao &= strEstrela & vbCrLf
            '        strImpressao &= "DODOS DE ENTREGA" & vbCrLf
            '        strImpressao &= "Entregador: " & Me.cboEnt.Text.Trim & vbCrLf
            '        strImpressao &= "Troco R$..: " & Me.txtTroco.Text.Trim & vbCrLf
            '        strImpressao &= "Tempo.....: " & Me.cboTempo.Text.Trim & vbCrLf
            '        If strTipoComanda = "ENTREGAR" Then
            '            If Me.rdgMaqCartao.SelectedIndex = 1 Then
            '                strImpressao &= vbCrLf
            '                strImpressao &= "LEVAR MÁQUINA DE CARTÃO" & vbCrLf
            '            End If
            '        End If
            '        strImpressao &= strEstrela & vbCrLf

            '    Else
            '        strImpressao &= strTraço & vbCrLf
            '    End If

            '    strImpressao &= Cent("DOCUMENTO NAO FISCAL", intTamEsp) & vbCrLf

            '    strImpressao &= strTraço & vbCrLf
            '    strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

            '    strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            '    If strImpressora = "ARQUIVO" Then
            '        strImpressao += Avanco() & vbCrLf

            '        If TemGuilhotina = True Then
            '            strImpressao += Corte() & vbCrLf
            '        End If
            '        SendStringToPrinter(strPorta, strImpressao)
            '        'ImprimiArquivo(strImpressao, PortaImpressora)

            '    ElseIf strImpressora.Contains("NANO PRINT") = True Then
            '        If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
            '            ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
            '        Else
            '            EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
            '        End If
            '    Else
            '        If strImpressora.Contains("MP-4000") Then
            '            iRetorno = ConfiguraModeloImpressora(5)
            '            iRetorno = SelecionaQualidadeImpressao(3)
            '        Else
            '            iRetorno = ConfiguraModeloImpressora(1)
            '        End If
            '        iRetorno = clsBematech.IniciaPorta(PortaImpressora)


            '        iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

            '        If TemGuilhotina = True Then
            '            iRetorno = clsBematech.AcionaGuilhotina(0)
            '        End If
            '    End If

            'ElseIf strImpressora = "EPSON" Then

            '    Dim strImpressao As String

            '    Dim strEstrela, strTraço As String

            '    strEstrela = clsImprimir.Comp("************************************************")
            '    strTraço = clsImprimir.Comp("------------------------------------------------")

            '    strImpressao = strEstrela & vbCrLf

            '    strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
            '    strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
            '    strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

            '    strImpressao &= strEstrela & vbCrLf
            '    strImpressao &= Esq(My.Computer.Clock.LocalTime, 48) & vbCrLf

            '    strImpressao &= strTraço & vbCrLf & vbCrLf
            '    strImpressao &= "<ce>" & Me.colCodComanda.Caption.ToUpper & ":  " & Me.txtComan.Text.Trim & "</ce>" & vbCrLf & vbCrLf
            '    strImpressao &= strTraço & vbCrLf

            '    If Me.lblCli.Text <> "CONSUMIDOR" Then
            '        strImpressao &= "Cliente.: " & Me.lblCli.Text & vbCrLf
            '        strImpressao &= "Endereco: " & Me.lblEnd.Text & vbCrLf
            '        strImpressao &= "Telefone: " & Me.txtTel.Text & vbCrLf
            '        strImpressao &= strTraço & vbCrLf
            '    End If

            '    strImpressao &= "ITEM CÓDIGO    DESCRICAO                  " & vbCrLf
            '    strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 37) & Esq("VL TOTAL R$", 11) & vbCrLf
            '    strImpressao &= strTraço & vbCrLf

            '    Dim L As Integer
            '    Dim dblQtd As Double
            '    For L = 0 To Me.grd1.RowCount - 1
            '        Dim strCod, strProd, strUni, strQtd, strTotal As String

            '        strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdInterno)
            '        strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
            '        strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
            '        strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
            '        strTotal = (CDbl(strQtd) * CDbl(strUni)).ToString("0.00")

            '        dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)

            '        Dim P As Integer = 0

            '        If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
            '            strImpressao &= strTraço.Replace("-", ".") & vbCrLf

            '            Dim vetProd As Array = Split(strProd, "|")

            '            strProd = ""

            '            For P = 0 To vetProd.Length - 1
            '                If vetProd(P).ToString <> "" Then
            '                    strProd &= P + 1 & "/" & vetProd.Length & "  " & vetProd(P).ToString & " | "
            '                End If
            '            Next
            '            strProd = Mid(strProd, 1, strProd.Length - 3)
            '        End If

            '        strImpressao &= L + 1 & "   " & strCod & "   " & strProd & vbCrLf

            '        Dim str As String
            '        str = Dir("UN" & "    " & strQtd & "  X  " & strUni, 37) & Esq("R$ " & strTotal, 11)
            '        strImpressao &= str & vbCrLf

            '        If Me.grd1.GetRowCellValue(L, Me.colMisto) = True Then
            '            If Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim <> "" Then

            '                Dim strOpci As String = Me.grd1.GetRowCellDisplayText(L, Me.colOpcoes).Trim

            '                Dim vetOpc As Array = Split(strOpci, "|")

            '                For P = 0 To vetOpc.Length - 1
            '                    strOpci = vetOpc(P).ToString
            '                    strImpressao &= strOpci & vbCrLf
            '                Next

            '            End If

            '            If Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim <> "" Then
            '                strImpressao &= "OBSERVAÇÃO: " & Me.grd1.GetRowCellDisplayText(L, Me.colObs).Trim & vbCrLf
            '            End If

            '            strImpressao &= strTraço.Replace("-", ".") & vbCrLf
            '        End If

            '    Next


            '    strImpressao &= strTraço & vbCrLf
            '    'strImpressao &= Esq("N de Itens......: ", 32) & Esq(dblQtd, 10) & vbCrLf
            '    If DezPorcento = True Then
            '        If strTipoComanda = "COMANDA" Then
            '            strImpressao &= Esq("Total........: R$ ", 38) & Esq(Me.txtValorTotal.Text.Trim, 10) & vbCrLf
            '            strImpressao &= Esq("Taxa 10%.....: R$ ", 38) & Esq(Me.txtTaxa.Text.Trim, 10) & vbCrLf
            '        End If
            '    End If

            '    strImpressao &= Esq("Total Geral..: R$ ", 38) & Esq(Me.txtGeral.Text.Trim, 10) & vbCrLf

            '    strImpressao &= " " & vbCrLf
            '    If QtdePessoasMesa <> "0" And QtdePessoasMesa <> "" Then
            '        strImpressao &= Dir("Qtde Pessoas: " & QtdePessoasMesa, 55) & vbCrLf
            '        Dim dblValorPessoa As Double = CDbl(Me.txtGeral.Text) / CDbl(QtdePessoasMesa)
            '        strImpressao &= Dir("Valor por Pessoa: " & dblValorPessoa.ToString("0.00"), 55) & vbCrLf
            '        strImpressao &= " " & vbCrLf
            '    End If
            '    If Me.txtObs.Text <> "" Then
            '        strImpressao &= "OBSERVAÇÃO: " & Me.txtObs.Text & vbCrLf
            '        strImpressao &= " " & vbCrLf
            '    End If
            '    If strTipoComanda <> "COMANDA" Then
            '        strImpressao &= strEstrela & vbCrLf
            '        strImpressao &= "DODOS DE ENTREGA" & vbCrLf
            '        strImpressao &= "Entregador: " & Me.cboEnt.Text.Trim & vbCrLf
            '        strImpressao &= "Troco R$..: " & Me.txtTroco.Text.Trim & vbCrLf
            '        strImpressao &= "Tempo.....: " & Me.cboTempo.Text.Trim & vbCrLf

            '        If strTipoComanda = "ENTREGAR" Then
            '            If Me.rdgMaqCartao.SelectedIndex = 1 Then
            '                strImpressao &= vbCrLf
            '                strImpressao &= "LEVAR MÁQUINA DE CARTÃO" & vbCrLf
            '            End If
            '        End If
            '        strImpressao &= strEstrela & vbCrLf
            '    Else
            '        strImpressao &= strTraço & vbCrLf
            '    End If

            '    strImpressao &= "<ce>" & "DOCUMENTO NAO FISCAL" & "</ce>" & vbCrLf

            '    strImpressao &= strTraço & vbCrLf
            '    strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf

            '    strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            '    iRetorno = clsEpson.IniciaPorta(PortaImpressora)
            '    iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

            '    If TemGuilhotina = True Then
            '        iRetorno = clsEpson.AcionaGuilhotina(1)
            '    End If
            '    iRetorno = clsEpson.FechaPorta
        End If

    End Sub
    Private Declare Function SetForegroundWindow Lib "user32" (ByVal hwng As Integer) As Integer
    Private Sub txtObservacao_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtObservacao.MouseDown
        If TecladoVirtual = True Then
            'Me.pnlTeclado.Visible = True
            Me.PanelControl3.Visible = False
            Me.PanelControl4.Visible = False
            Me.PanelControl5.Dock = DockStyle.Top
            'Dim proc As Process
            'For Each proc In Process.GetProcesses
            '    If proc.ProcessName = "TecladoNano" Then
            '        Try
            '            proc.Kill()
            '            proc.Close()
            '        Catch ex As Exception

            '        End Try
            '    End If
            'Next
            'System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\TecladoNano.exe")
            'SetForegroundWindow(Me.Handle)
            'If Process.GetProcessesByName("Nano.vshost").Length >= 1 Then
            '    For Each ObjProcess As Process In Process.GetProcessesByName("Nano.vshost")
            '        AppActivate(ObjProcess.Id)
            '    Next
            'End If

            'IniciaThreadTeclado()
            AbrirTecladoArquivo(True)
        End If
        

    End Sub


    Private Sub EnviarImpressao2(ByVal parCodigoItem As String)
        If TemImpressora = False Then Exit Sub

        Dim strFiltro As String = " and ImpOk = 'False' "
        If parCodigoItem <> "" Then
            strFiltro = " and Comanda.Codigo = " & parCodigoItem
        End If

        Dim dtPorta As DataTable = CarregarDataTable("SELECT PortaImpressora, Impressora FROM (Comanda left join Produto " & _
        "on Comanda.CodProd = Produto.Codigo)Left join Grupo on Grupo.Nome = Produto.Grupo where " & _
        "CodComanda = '" & Me.txtComanda.Text.Trim & "' and Comanda.Tipo ='COMANDA' " & strFiltro & " AND Comanda.Status ='Aberto' AND CodConfig =" & CodConfig & " and PortaImpressora <> '' " & _
        "group by PortaImpressora, Impressora")


        Dim I As Integer
        Dim A As Integer

    


        For I = 0 To dtPorta.Rows.Count - 1

            Dim strPorta As String = dtPorta.Rows.Item(I).Item("PortaImpressora").ToString
            Dim strModImpressora As String = dtPorta.Rows.Item(I).Item("Impressora").ToString

            Dim dtItens As DataTable = CarregarDataTable("SELECT Comanda.Codigo, Comanda.CodProd, Comanda.CodProdInterno, " & _
            "Comanda.Produto, Comanda.Qtd, Comanda.ValorUnitario, (Comanda.Qtd * Comanda.ValorUnitario) as ValorTotal, " & _
            "Comanda.Misto, Comanda.Opcoes, Comanda.Obs, Comanda.CodFunc FROM (Comanda left join Produto on Comanda.CodProd = Produto.Codigo)" & _
            "Left join Grupo on Grupo.Nome = Produto.Grupo where CodComanda = '" & Me.txtComanda.Text.Trim & "' " & strFiltro & " " & _
            "and Comanda.Status = 'Aberto' AND Comanda.CodConfig =" & CodConfig & " and PortaImpressora = '" & strPorta & "' and " & _
            "Impressora = '" & strModImpressora & "'")

            If dtItens.Rows.Count > 0 Then
                If strModImpressora.Contains("ESC/POS") = True Then

                    Dim strImpressao As String = ""

                    strIgual = CompComanda("=======================================================", strModImpressora)
                    strTraco = CompComanda("-------------------------------------------------------", strModImpressora)

                    strImpressao = CentralizarComanda(NegComanda(NomeEmpresa.ToString.Trim, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
                    strImpressao &= strIgual & vbCrLf & vbCrLf

                    strImpressao &= CentralizarComanda(ExpComanda("Comanda/Mesa" & ": " & Me.txtComanda.Text.Trim & "/" & Me.txtMesa.Text.Trim, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
                    strImpressao &= strTraco & vbCrLf

                    If Me.txtCliente.Text <> "CONSUMIDOR" Then
                        strImpressao &= Dir("Cliente.: " & Me.txtCliente.Text, 55) & vbCrLf
                        'strImpressao &= Dir("Endereco: " & strEndereco, 55) & vbCrLf
                        'strImpressao &= Dir("Telefone: " & strTelefone, 55) & vbCrLf
                        strImpressao &= strTraco & vbCrLf
                    End If
                    strImpressao &= Dir("CODIGO                                              QTD", 55) & vbCrLf
                    strImpressao &= "DESCRICAO                                              " & vbCrLf

                    strImpressao &= strTraco & vbCrLf
                    Dim strCodFunc As String = ""
                    For A = 0 To dtItens.Rows.Count - 1
                        Dim strCod As String = dtItens.Rows.Item(A).Item("CodProdInterno").ToString
                        Dim strQtd As String = dtItens.Rows.Item(A).Item("Qtd").ToString
                        Dim bolMisto As Boolean = dtItens.Rows.Item(A).Item("Misto")
                        'strCodFunc = dtItens.Rows.Item(A).Item("CodFunc").ToString
                        Dim strProduto As String = dtItens.Rows.Item(A).Item("Produto").ToString '& "   (" & strCodFunc & ")"
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

                         


                        End If

                        If strObs <> "" Then
                            strImpressao &= Dir("OBSERVAÇÃO: " & strObs, 55) & vbCrLf
                        End If

                        If A < dtItens.Rows.Count - 1 Then
                            strImpressao &= vbCrLf
                        End If


                        If parCodigoItem <> "" Then
                            strImpressao &= CentralizarComanda(ExpComanda("CANCELADO", strModImpressora), strModImpressora) & vbCrLf
                        End If

                    Next




                    If Me.txtObservacao.Text <> "" Then
                        strImpressao &= strTraco & vbCrLf

                        strImpressao &= "OBSERVAÇÃO: " & Me.txtObservacao.Text & vbCrLf
                    End If

                    'If GerarComissao = True Then
                    '    'If Me.txtComan.Text.Trim <> "" And strCodigoOrdem <> "" Then
                    '    Dim dtFunc As DataTable = CarregarDataTable("SELECT funcionario.Nome FROM Funcionario where Funcionario.Codigo =  " & strCodFunc)
                    '    If dtFunc.Rows.Count > 0 Then

                    '        strImpressao &= strTraco & vbCrLf
                    '        strImpressao &= Dir("Atend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
                    '    End If
                    '    'End If
                    'End If

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
                    strImpressao &= Cent("Comanda/Mesa" & ": " & Me.txtComanda.Text.Trim & "/" & Me.txtMesa.Text.Trim, intTamEsp) & vbCrLf & vbCrLf
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
                    If Me.txtObservacao.Text <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & Me.txtObservacao.Text & vbCrLf
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
                    strImpressao &= "<ce>" & "Comanda/Mesa" & ": " & Me.txtComanda.Text.Trim & "/" & Me.txtMesa.Text.Trim & "</ce>" & vbCrLf & vbCrLf
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
                    If Me.txtObservacao.Text <> "" Then
                        strImpressao &= "OBSERVAÇÃO: " & Me.txtObservacao.Text & vbCrLf
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
            "Left join Grupo on Grupo.Nome = Produto.Grupo where CodComanda = '" & Me.txtComanda.Text.Trim & "' and ImpOk = 'False' " & _
            "and Comanda.Tipo ='COMANDA' AND Comanda.CodConfig =" & CodConfig & " and PortaImpressora = '" & strPorta & "' and " & _
            "Impressora = '" & strModImpressora & "'")

        Next

    End Sub
  
    Private Sub cboImpressora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboImpressora.SelectedIndexChanged
        Me.lblImpressora.Text = Me.cboImpressora.Text
    End Sub

  
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click


         If Me.grd1.RowCount = 0 Then Exit Sub

        If strStatusComanda = "FECHADO" Then

            frmComandaMensagem.lblMensagem.Text = "Comanda fechada, não é possível alterar!"
            frmComandaMensagem.btnSim.Visible = False
            frmComandaMensagem.btnNao.Text = "Ok"
            frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
            frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
            frmComandaMensagem.ShowDialog()
            Exit Sub
        End If

        Dim dblTro As Double = 0


        RetornoMensagemComanda = False
        frmComandaMensagem.Tag = ""
        frmComandaMensagem.lblMensagem.Text = "Deseja realmente finalizar esta comanda?"
        frmComandaMensagem.btnSim.Visible = True
        frmComandaMensagem.btnNao.Text = "Não"
        frmComandaMensagem.Size = New System.Drawing.Size(600, 210)
        frmComandaMensagem.btnNao.Location = New System.Drawing.Point(390, 107)
        frmComandaMensagem.ShowDialog()

        If RetornoMensagemComanda = True Then
            QtdePessoasMesa = "0"
            RetornoNumeroComanda = 0
            frmComandaSelecionar.Tag = "QTDE"
            frmComandaSelecionar.ShowDialog()
            QtdePessoasMesa = RetornoNumeroComanda

            If RetornoNumeroComanda > 0 Then
                Atualizar("Update Comanda Set Status ='Fechado', " & _
                            "Troco =" & Num(dblTro.ToString("0.00")) & ", APP = 'True' where CodComanda = '" & Me.txtComanda.Text.Trim & "' and Status = 'Aberto' and CodConfig = " & CodConfig)


                Dim dtComanda As DataTable = CarregarDataTable("SELECT Codigo, ValorPago FROM R7 where CodUser = " & strCodComanda & " and CodConfig = " & CodConfig)
                If dtComanda.Rows.Count > 0 Then
                    If dtComanda.Rows.Item(0).Item("ValorPago").ToString <> "" Then
                        QtdePessoasMesa = CInt(dtComanda.Rows.Item(0).Item("ValorPago"))
                    End If
                End If





                If dtComanda.Rows.Count > 0 Then
                    Atualizar("UPDATE R7 set COO = '" & Me.txtObservacao.Text & "', ValorPago = " & Num(QtdePessoasMesa) & " where CodUser = " & strCodComanda & " and Codconfig = " & CodConfig)

                Else
                    Inserir("INSERT INTO R7 (CodUser, COO, ValorPago, CodConfig) VALUES (" & strCodComanda & ",'" & Me.txtObservacao.Text & "'," & _
                    "" & Num(QtdePessoasMesa) & "," & CodConfig & ")")

                End If

                'If parVender = False Then
                If ImprimeComanda = True Then
                    Imprimir()
                End If
                'End If

                Me.Close()
                frmComandaPrincipal.Close()
                frmComandaPrincipal.MdiParent = MDIComanda
                frmComandaPrincipal.Show()
                frmComandaPrincipal.Dock = DockStyle.Fill
            End If

            
        End If

    End Sub

 
    'Private Sub btnImprimir_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.GotFocus
    '    Me.lblImpressora.Appearance.BackColor = Color.FromArgb(184, 234, 239)
    'End Sub

    'Private Sub btnImprimir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.LostFocus
    '    Me.lblImpressora.Appearance.BackColor = CorBotoes
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim intTamanhoTotal As Double = Me.txtObservacao.Size.Width


        intTamanhoTotal = intTamanhoTotal - 42

        intTamanhoTotal = intTamanhoTotal / 5

        Dim dblLocation As Double = intTamanhoTotal + 10
        Me.btnExcluirItem.Size = New System.Drawing.Size(intTamanhoTotal, 90)
        Me.btnExcluirItem.Location = New System.Drawing.Point(4, 4)
        Me.cboImpressora.Size = New System.Drawing.Size(intTamanhoTotal, 90)
        Me.cboImpressora.Location = New System.Drawing.Point(dblLocation, 4)
        Me.btnImprimir.Location = New System.Drawing.Point(dblLocation, 4)
        Me.lblImpressora.Location = New System.Drawing.Point(dblLocation, Me.lblImpressora.Location.Y)

        dblLocation += intTamanhoTotal + 6

        Me.btnExcluirComanda.Size = New System.Drawing.Size(intTamanhoTotal, 90)
        Me.btnExcluirComanda.Location = New System.Drawing.Point(dblLocation, 4)
        dblLocation += intTamanhoTotal + 6

        Me.btnTransferir.Size = New System.Drawing.Size(intTamanhoTotal, 90)
        Me.btnTransferir.Location = New System.Drawing.Point(dblLocation, 4)
        dblLocation += intTamanhoTotal + 6


        Dim dblTeste As Double = Me.txtObservacao.Size.Width - (dblLocation + intTamanhoTotal) + 1
        Me.btnFechar.Size = New System.Drawing.Size(intTamanhoTotal + dblTeste, 90)
        Me.btnFechar.Location = New System.Drawing.Point(dblLocation, 4)


        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colProduto
        grd1.ShowEditor()
        Me.grd1.OptionsView.ShowAutoFilterRow = False
        Timer1.Stop()
    End Sub

    Private Sub btnTransferir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTransferir.Click

        If strStatusComanda = "FECHADO" Then

            frmComandaMensagem.lblMensagem.Text = "Comanda fechada, não é possível transferir!"
            frmComandaMensagem.btnSim.Visible = False
            frmComandaMensagem.btnNao.Text = "Ok"
            frmComandaMensagem.Size = New System.Drawing.Size(649, 210)
            frmComandaMensagem.btnNao.Location = New System.Drawing.Point(210, 107)
            frmComandaMensagem.ShowDialog()
            Exit Sub
        End If

        RetornoMensagemComanda = False
        frmComandaExcluir.ShowDialog()
        If RetornoMensagemComanda = True Then

            RetornoNumeroComanda = 0
            frmComandaSelecionar.Tag = "TRANSFERIR"
            frmComandaSelecionar.ShowDialog()
            If RetornoNumeroComanda > 0 Then
                Dim strNum As String = RetornoNumeroComanda

                If strNum.Trim = "" Then Exit Sub

                If strNum.Trim = Me.txtComanda.Text.Trim Then
                    frmComandaMensagem.Tag = ""
                    frmComandaMensagem.lblMensagem.Text = "A Comanda de destino é a mesma de origem!"
                    frmComandaMensagem.btnSim.Visible = False
                    frmComandaMensagem.btnNao.Text = "Ok"
                    frmComandaMensagem.Size = New System.Drawing.Size(649, 210)
                    frmComandaMensagem.btnNao.Location = New System.Drawing.Point(210, 107)
                    frmComandaMensagem.ShowDialog()

                    'MsgBox("A Comanda/Mesa de destino é a mesma de origem!" & vbCrLf & "Informe uma Comanda/Mesa diferente.", MsgBoxStyle.Information)
                    Exit Sub
                End If

                Dim dt As DataTable = CarregarDataTable("Select CodOrdens, Status, Mesa, Nome from Comanda where CodComanda ='" & strNum & "' and Status <> 'Faturado'")

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Status").ToString = "Fechado" Then
                        frmComandaMensagem.Tag = ""
                        frmComandaMensagem.lblMensagem.Text = "A Comanda de destino está fechada!"
                        frmComandaMensagem.btnSim.Visible = False
                        frmComandaMensagem.btnNao.Text = "Ok"
                        frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
                        frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
                        frmComandaMensagem.ShowDialog()
                        Exit Sub
                    End If

                    'ATUALIZAR OBSERVACAO
                    Dim strObservacao As String = AtualizarObservacao(dt.Rows.Item(0).Item("CodOrdens").ToString, Me.txtComanda.Text.Trim)
                    Atualizar("Update R7 set COO='" & strObservacao & "' Where CodUser='" & dt.Rows.Item(0).Item("CodOrdens").ToString & "' And CodConfig=" & CodConfig)

                    Dim str As String = dt.Rows.Item(0).Item("CodOrdens").ToString
                    Dim strM As String = dt.Rows.Item(0).Item("Mesa").ToString
                    Dim strNome As String = dt.Rows.Item(0).Item("Nome").ToString

                    Atualizar("Update Comanda set CodOrdens =" & dt.Rows.Item(0).Item("CodOrdens").ToString & ", CodComanda ='" & strNum & "', Mesa = '" & strM & "', Nome = '" & strNome & "' where CodComanda ='" & Me.txtComanda.Text.Trim & "' and Status ='Aberto' And CodConfig=" & CodConfig)

                    frmComandaMensagem.Tag = ""
                    frmComandaMensagem.lblMensagem.Text = "Comanda transferida com sucesso!"
                    frmComandaMensagem.btnSim.Visible = False
                    frmComandaMensagem.btnNao.Text = "Ok"
                    frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
                    frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
                    frmComandaMensagem.ShowDialog()

                    Me.Close()
                    frmComandaPrincipal.Close()
                    frmComandaPrincipal.MdiParent = MDIComanda
                    frmComandaPrincipal.Show()
                    frmComandaPrincipal.Dock = DockStyle.Fill
                Else
                    'MsgBox("Essa Comanda/Mesa não está cadastrada ou já foi fechada!", MsgBoxStyle.Information)
                    Dim intCodOrdens As Integer
                    intCodOrdens = GerarCodigo("Ordens", "Cod", CodConfig)
                    Inserir("INSERT INTO Ordens(Cod, Tabela, CodConfig) VALUES (" & intCodOrdens & ",'Comanda'," & CodConfig & ")")


                    Atualizar("Update Comanda set CodOrdens =" & intCodOrdens & ", CodComanda ='" & strNum & "' where CodComanda ='" & Me.txtComanda.Text.Trim & "' and Status ='Aberto' And CodConfig=" & CodConfig)
                    frmComandaMensagem.Tag = ""
                    frmComandaMensagem.lblMensagem.Text = "Comanda transferida com sucesso!"
                    frmComandaMensagem.btnSim.Visible = False
                    frmComandaMensagem.btnNao.Text = "Ok"
                    frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
                    frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
                    frmComandaMensagem.ShowDialog()

                    Me.Close()
                    frmComandaPrincipal.Close()
                    frmComandaPrincipal.MdiParent = MDIComanda
                    frmComandaPrincipal.Show()
                    frmComandaPrincipal.Dock = DockStyle.Fill
                End If
            End If
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
End Class