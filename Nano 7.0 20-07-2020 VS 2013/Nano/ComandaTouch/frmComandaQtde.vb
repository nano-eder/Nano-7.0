Imports Nano.clsImprimir
Imports Nano.clsFuncoes
Imports System.IO
Public Class frmComandaQtde
    Dim strGrupo As String
    Public strCodComanda As String
    Public strCodProduto As String
    Public strSetor As String
    Public bolMisto As Boolean
    Dim strComanda As String
    Dim strCliente As String
    Dim strMesa As String
    Dim dblValorProduto As Double
    Dim strCodProdInterno As String
    Dim dblValorUnitario As Double
    'Private Sub frmComandaQtde_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtde.KeyDown, txtObservacao.KeyDown
    '    If e.KeyCode = 91 Or e.KeyCode = Keys.Escape Or e.KeyCode = 13 Then
    '        Me.pnlTeclado.Visible = False
    '        Me.btnMais.Focus()
    '        Me.btnConcluido.Focus()
    '    End If
    'End Sub

    Private Sub frmComandaQtde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormAberto = Me.Name
        Me.tbTipo.Rows.Clear()
        Me.PanelControl5.Controls.Add(Me.PictureEdit7)
        Dim dtComanda As DataTable = CarregarDataTable("SELECT CodComanda, Mesa, Nome From Comanda where CodOrdens = " & strCodComanda & " and CodConfig = " & CodConfig)
        If dtComanda.Rows.Count > 0 Then

            strCliente = dtComanda.Rows.Item(0).Item("Nome").ToString
            strComanda = dtComanda.Rows.Item(0).Item("CodComanda").ToString
            strMesa = dtComanda.Rows.Item(0).Item("Mesa").ToString
        End If

        Dim dtProd As DataTable = CarregarDataTable("SELECT Valor, UnidadeMedida, ValorCusto, CodigoInterno, Desconto, Grupo, Tipo, Imagem1 FROM Produto where Codigo = " & strCodProduto)
        If dtProd.Rows.Count > 0 Then
            strGrupo = dtProd.Rows.Item(0).Item("Grupo").ToString
            strCodProdInterno = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
            dblValorProduto = dtProd.Rows.Item(0).Item("Valor").ToString
            dblValorUnitario = dtProd.Rows.Item(0).Item("Valor").ToString
            Dim dblPerDesc, dblResto As Double
            Dim bolPromocao As Boolean = False

            If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" Then
                dblPerDesc = dtProd.Rows.Item(0).Item("Desconto").ToString

                dblResto = (dblValorProduto / 100) * dblPerDesc

                dblValorProduto = dblValorProduto - dblResto
                bolPromocao = True
            End If


            If dtProd.Rows.Item(0).Item("Imagem1").ToString <> "" Then
                Dim Imagem As Byte() = CType(dtProd.Rows.Item(0).Item("Imagem1"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)


                Me.PictureEdit2.Image = bitmap
            Else

                Me.PictureEdit2.Image = Nothing
            End If

            Me.txtValorTotal.Text = dblValorProduto.ToString("0.00")
        End If

        Dim dt As DataTable = CarregarDataTable("SELECT Tipo FROM ProdOpc left join VincProdOpc on ProdOpc.Codigo = VincProdOpc.CodOpc where VincProdOpc.CodProd = " & strCodProduto & " group by Tipo")
        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            Me.tbTipo.Rows.Add()
            Me.tbTipo.Rows.Item(Me.tbTipo.Rows.Count - 1).Item("Tipo") = dt.Rows.Item(I).Item("Tipo").ToString
        Next

        Me.grd3.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.grd3.OptionsSelection.EnableAppearanceHideSelection = False
        Me.grd3.OptionsSelection.EnableAppearanceFocusedCell = False


    If dt.Rows.Count > 1 Then
            Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = False
            Me.grd1.OptionsSelection.EnableAppearanceHideSelection = False
            Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = False

        End If





    

        Me.btnConcluido.Appearance.BackColor = CorBotoes
        Me.btnRemover.Appearance.BackColor = CorBotoes
        Me.btnMais.Appearance.BackColor = CorBotoes
        Me.btnMenos.Appearance.BackColor = CorBotoes
        Me.btnAddOpcao.Buttons.Item(0).Appearance.BackColor = CorBotoes
        Me.PanelControl1.Appearance.BackColor = CorFundo

        Me.BackColor = CorFundo
        Me.PictureEdit3.BackColor = CorFundo
        Me.PictureEdit4.BackColor = CorFundo
        Me.PictureEdit5.BackColor = CorFundo
        Me.PictureEdit6.BackColor = CorFundo
        Me.PictureEdit7.BackColor = CorFundo
        Me.LabelControl2.BackColor = CorFundo
        Me.LabelControl3.BackColor = CorFundo

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda/" & CorImagemBotao) = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Ok.png") = True Then
                Me.btnConcluido.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Ok.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Mais.png") = True Then
                Me.btnAddOpcao.Buttons.Item(0).Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Mais.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Menos.png") = True Then
                Me.btnMenos.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Menos.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/ExcluirItem.png") = True Then
                Me.btnRemover.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\ExcluirItem.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Mais.png") = True Then
                Me.btnMais.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Mais.png")
            End If


        End If

        Timer1.Start()
    End Sub

    
    Private Sub grd1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grd1.FocusedRowChanged
        Me.tbOpcoes.Rows.Clear()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim strTipo As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colAdicional)
        Dim dt As DataTable = CarregarDataTable("SELECT Produto, Valor FROM ProdOpc left Join VincProdOpc on ProdOpc.Codigo = VincProdOpc.CodOpc Where Tipo = '" & strTipo & "' and CodProd = " & strCodProduto)

        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            Me.tbOpcoes.Rows.Add()
            Me.tbOpcoes.Rows.Item(Me.tbOpcoes.Rows.Count - 1).Item("Opcoes") = dt.Rows.Item(I).Item("Produto").ToString
            Me.tbOpcoes.Rows.Item(Me.tbOpcoes.Rows.Count - 1).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

    End Sub

    Private Sub txtAdicionar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdicionar.DoubleClick
        If Me.grd2.FocusedRowHandle < 0 Then Exit Sub
        Dim strTipo As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colAdicional)
        Dim strProduto As String = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colOpcoes)
        Dim dblValor As Double = 0
        If Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colValor) <> "" Then
            dblValor = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colValor)
        End If
        Me.tbAdicionados.Rows.Add()
        Me.tbAdicionados.Rows.Item(Me.tbAdicionados.Rows.Count - 1).Item("Descricao") = strTipo & " - " & strProduto
        Me.tbAdicionados.Rows.Item(Me.tbAdicionados.Rows.Count - 1).Item("Valor") = dblValor.ToString("0.00")
        Calcular()
    End Sub
    Private Sub Calcular()
        Dim I As Integer
        Dim dblValorTotal As Double
        For I = 0 To Me.grd3.RowCount - 1
            If Me.grd3.GetRowCellDisplayText(I, Me.colValorAdicionado) <> "" Then
                dblValorTotal += Me.grd3.GetRowCellDisplayText(I, Me.colValorAdicionado)
            End If
        Next
        dblValorTotal += dblValorProduto
        dblValorUnitario = dblValorTotal
        Dim dblQtd As Double = 1
        If Me.txtQtde.Text <> "" Then
            dblQtd = Me.txtQtde.Text
        End If
        dblValorTotal = dblValorTotal * dblQtd
        Me.txtValorTotal.Text = dblValorTotal.ToString("0.00")
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If Me.grd3.FocusedRowHandle < 0 Then Exit Sub

        Me.grd3.DeleteRow(Me.grd3.FocusedRowHandle)
        Calcular()
    End Sub

    Private Sub btnMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenos.Click

        If Me.txtQtde.Text = "" Then Exit Sub
        Dim dblQtde As Double = Me.txtQtde.Text
        If dblQtde <= 1 Then Exit Sub

        dblQtde -= 1
        Me.txtQtde.Text = dblQtde
        Calcular()
    End Sub

    Private Sub btnMais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMais.Click
        If Me.txtQtde.Text = "" Then
            Me.txtQtde.Text = "1"
        End If
        Dim dblQtde As Double = Me.txtQtde.Text

        dblQtde += 1
        Me.txtQtde.Text = dblQtde
        Calcular()
    End Sub

    'Private Sub txtQtde_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtde.GotFocus
    '    Me.pnlTeclado.Visible = True
    '    Me.pnlAdicionados.Visible = False
    '    Me.pnlOpcoes.Visible = False
    '    Me.pnlObservacao.Dock = DockStyle.Top
    '    IniciaThreadTeclado()
    'End Sub

    Private Sub txtQtde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQtde_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtde.Leave
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = False
            Me.pnlAdicionados.Visible = True
            Me.pnlOpcoes.Visible = True
            Me.pnlObservacao.Dock = DockStyle.Bottom
            'FecharTeclado()

            FecharTecladoArquivo(False)
        End If
      
        Calcular()
    End Sub

    Private Sub txtObservacao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservacao.Leave
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = False
            Me.pnlAdicionados.Visible = True
            Me.pnlOpcoes.Visible = True
            Me.pnlObservacao.Dock = DockStyle.Bottom
            'FecharTeclado()

            FecharTecladoArquivo(False)

        End If
  
    End Sub

    'Private Sub txtQtde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtde.LostFocus
    '    Me.pnlTeclado.Visible = False
    '    Me.pnlAdicionados.Visible = True
    '    Me.pnlOpcoes.Visible = True
    '    Me.pnlObservacao.Dock = DockStyle.Bottom
    '    FecharTeclado()
    'End Sub



    'Private Sub txtObservacao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservacao.GotFocus
    '    Me.pnlTeclado.Visible = True
    '    Me.pnlAdicionados.Visible = False
    '    Me.pnlOpcoes.Visible = False
    '    Me.pnlObservacao.Dock = DockStyle.Top
    '    IniciaThreadTeclado()
    'End Sub

    'Private Sub txtObservacao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservacao.Leave
    '    Me.btnConcluido.Focus()
    'End Sub

    'Private Sub txtObservacao_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservacao.LostFocus
    '    Me.pnlTeclado.Visible = False
    '    Me.pnlAdicionados.Visible = True
    '    Me.pnlOpcoes.Visible = True
    '    Me.pnlObservacao.Dock = DockStyle.Bottom
    '    FecharTeclado()
    'End Sub
    Private Sub grd1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.GotFocus
        Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = True
        Me.grd1.OptionsSelection.EnableAppearanceHideSelection = True
        Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = True

    End Sub
    Private Sub grd3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd3.GotFocus
        Me.grd3.OptionsSelection.EnableAppearanceFocusedRow = True
        Me.grd3.OptionsSelection.EnableAppearanceHideSelection = True
        Me.grd3.OptionsSelection.EnableAppearanceFocusedCell = True

    End Sub

    Private Sub grd3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd3.LostFocus

        Me.grd3.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.grd3.OptionsSelection.EnableAppearanceHideSelection = False
        Me.grd3.OptionsSelection.EnableAppearanceFocusedCell = False

    End Sub

    Private Sub btnConcluido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcluido.Click
        If Validar(Me.txtQtde) = False Then Exit Sub


        Dim dblQtd, dblUni, dblCusto, dblTot, dblTotCus As Double

        If Me.txtQtde.Text.Trim <> "" Then
            dblQtd = Me.txtQtde.Text.Trim
            If dblQtd <= 0 Then
                dblQtd = 1
            End If
        Else
            dblQtd = 1
        End If


        Dim I As Integer
        Dim strListaOpcoes As String = ""
        For I = 0 To Me.grd3.RowCount - 1
            If I = 0 Then
                strListaOpcoes = Me.grd3.GetRowCellDisplayText(I, Me.colDescricao)
            Else
                strListaOpcoes &= "|" & Me.grd3.GetRowCellDisplayText(I, Me.colDescricao)
            End If
        Next

        'Dim bolMisto As Boolean = False
        'If strListaOpcoes <> "" Then
        '    bolMisto = True
        'End If
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Comanda where CodOrdens = " & strCodComanda & " and CodConfig = " & CodConfig & " and Produto = 'INSERIR'")
        If dt.Rows.Count > 0 Then
            Dim strCodigo As String = dt.Rows.Item(0).Item("Codigo").ToString
            Inserir("Update Comanda set CodProd = " & strCodProduto & ", CodProdInterno = '" & strCodProdInterno & "', " & _
            "Produto = '" & Me.txtProduto.Text & "', Qtd = " & Num(dblQtd) & ", ValorUnitario = " & Num(dblValorUnitario) & ", " & _
            "Data = '" & My.Computer.Clock.LocalTime & "', Status = 'Aberto', CodConfig = " & CodConfig & ", Misto = '" & bolMisto & "', " & _
            "CodFunc = " & "1" & ", CodCli = " & "1" & ", Tipo = 'COMANDA', Opcoes = '" & strListaOpcoes & "', " & _
            "Obs = '" & Me.txtObservacao.Text & "', ImpOk = 'False', Nome = '" & strCliente & "' Where Codigo = " & strCodigo)

        Else

            If strMesa = "" Then
                Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Produto, Qtd, ValorUnitario, " & _
                        "Data, Status, CodConfig, Misto, CodFunc, CodCli, Tipo, Opcoes, Obs, ImpOk, Nome) VALUES (" & strCodComanda & "," & _
                        "'" & strComanda & "'," & strCodProduto & ",'" & strCodProdInterno & "'," & _
                        "'" & Me.txtProduto.Text & "'," & Num(dblQtd) & "," & Num(dblValorUnitario) & ",'" & My.Computer.Clock.LocalTime & "'," & _
                        "'" & "Aberto" & "'," & CodConfig & ",'" & bolMisto & "'," & "1" & "," & "1" & "," & _
                        "'COMANDA','" & strListaOpcoes & "','" & Me.txtObservacao.Text & "','False','" & strCliente & "')")

            Else
                Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Produto, Qtd, ValorUnitario, " & _
                        "Data, Status, CodConfig, Misto, CodFunc, CodCli, Tipo, Opcoes, Obs, ImpOk, Nome, Mesa) VALUES (" & strCodComanda & "," & _
                        "'" & strComanda & "'," & strCodProduto & ",'" & strCodProdInterno & "'," & _
                        "'" & Me.txtProduto.Text & "'," & Num(dblQtd) & "," & Num(dblValorUnitario) & ",'" & My.Computer.Clock.LocalTime & "'," & _
                        "'" & "Aberto" & "'," & CodConfig & ",'" & bolMisto & "'," & "1" & "," & "1" & "," & _
                        "'COMANDA','" & strListaOpcoes & "','" & Me.txtObservacao.Text & "','False','" & strCliente & "','" & strMesa & "')")

            End If
   
        End If

        'If strTipoComanda <> "COMANDA" Then
        '    Atualizar("Update Comanda set CodCli =" & intCodCli & ", Nome ='" & Me.txtNome.Text.Trim & "' Where CodComanda = '" & Me.txtComan.Text.Trim & "' and Status = 'Aberto' and CodConfig = " & CodConfig)
        'End If
        'If ImprimeComanda = True Then
        '    If strTipoComanda = "COMANDA" Then
        'EnviarImpressao(strGrupo, strCodProdInterno, Me.txtProduto.Text, dblQtd.ToString("0.000"), strListaOpcoes)
        '    End If
        'End If
        'SalvarObservacao()
        'FecharTeclado()

        FecharTecladoArquivo(False)

        Me.Close()
        frmComandaPrincipal.Close()
        frmComandaItens.MdiParent = MDIComanda
        frmComandaItens.strCodComanda = strCodComanda
        frmComandaItens.Show()
        frmComandaItens.Dock = DockStyle.Fill
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.grd1.RowCount > 1 Then
            Me.grd1.OptionsView.ShowAutoFilterRow = True
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colAdicional
            grd1.ShowEditor()
            Me.tbOpcoes.Rows.Clear()
            Me.grd1.OptionsView.ShowAutoFilterRow = False
        End If

        If QtdeVaziaComanda = True Then
            Me.txtQtde.ResetText()
            Me.txtQtde.Focus()
            If TecladoVirtual = True Then
                Me.pnlTeclado.Visible = True
                Me.pnlAdicionados.Visible = False
                Me.pnlOpcoes.Visible = False
                Me.pnlObservacao.Dock = DockStyle.Top
                'IniciaThreadTeclado()
                AbrirTecladoArquivo(True)

            End If
        End If

        Timer1.Stop()
    End Sub

    'Private Sub EnviarImpressao(ByVal parGrupo As String, ByVal parCod As String, ByVal parProd As String, ByVal parQtd As String, ByVal parMisto As String)
    '    If TemImpressora = False Then Exit Sub

    '    Dim strPorta As String = ""
    '    Dim strModImpressora As String = Impressora
    '    Dim dtGru As DataTable = CarregarDataTable("Select PortaImpressora, Impressora from Grupo where Nome ='" & parGrupo & "'")

    '    If dtGru.Rows.Count > 0 Then
    '        strPorta = dtGru.Rows.Item(0).Item("PortaImpressora").ToString
    '        If dtGru.Rows.Item(0).Item("Impressora").ToString <> "" Then
    '            strModImpressora = dtGru.Rows.Item(0).Item("Impressora").ToString
    '        End If
    '    Else
    '        Exit Sub
    '    End If

    '    If strPorta.Trim = "" Then
    '        MsgBox("O Grupo/Setor " & parGrupo & " não está com a porta de impressão configurada!", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If

    '    If strModImpressora.Contains("ESC/POS") = True Then

    '        Dim strImpressao As String

    '        strIgual = CompComanda("=======================================================", strModImpressora)
    '        strTraco = CompComanda("-------------------------------------------------------", strModImpressora)

    '        strImpressao = CentralizarComanda(NegComanda(NomeEmpresa.ToString.Trim, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
    '        strImpressao &= strIgual & vbCrLf & vbCrLf

    '        strImpressao &= CentralizarComanda(ExpComanda("Comanda/Mesa" & ": " & strComanda & "/" & strMesa, strModImpressora), strModImpressora) & vbCrLf & vbCrLf
    '        strImpressao &= strIgual & vbCrLf

    '        strImpressao &= Dir("CODIGO                                              QTD", 55) & vbCrLf
    '        strImpressao &= "DESCRICAO                                              " & vbCrLf

    '        strImpressao &= strTraco & vbCrLf


    '        If strModImpressora.ToUpper.Contains("DARUMA") = True Then
    '            strImpressao &= ExpComanda(Dir(parCod, 14) & Esq(parQtd, 14), strModImpressora) & vbCrLf
    '        End If

    '        If strModImpressora.ToUpper.Contains("BEMATECH") = True Then

    '            strImpressao &= Dir(parCod, 20) & Esq(parQtd, 35) & vbCrLf

    '        End If
    '        If strModImpressora.ToUpper.Contains("EPSON") = True Then

    '            strImpressao &= ExpComanda(Dir(parCod, 27) & Esq(parQtd, 15), strModImpressora) & vbCrLf

    '        End If


    '        strImpressao &= Dir(parProd, 55) & vbCrLf

    '        Dim P As Integer

    '        If parMisto.Trim <> "" Then

    '            Dim strOpci As String = parMisto

    '            Dim vetOpc As Array = Split(strOpci, "|")

    '            For P = 0 To vetOpc.Length - 1
    '                strOpci = vetOpc(P).ToString
    '                strImpressao &= Dir(strOpci, 55) & vbCrLf
    '            Next

    '        End If

    '        If ObsOpcoes <> "" Then
    '            strImpressao &= Dir("OBSERVAÇÃO: " & ObsOpcoes, 55) & vbCrLf
    '        End If

    '        'If GerarComissao = True Then
    '        '    If Me.txtComan.Text.Trim <> "" And strCodigoOrdem <> "" Then
    '        '        Dim dtFunc As DataTable = CarregarDataTable("SELECT funcionario.Nome FROM Funcionario where Funcionario.Codigo =  " & strCodFunc)
    '        '        If dtFunc.Rows.Count > 0 Then

    '        '            strImpressao &= strTraco & vbCrLf
    '        '            strImpressao &= Dir("Atend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
    '        '        End If
    '        '    End If
    '        'End If

    '        strImpressao &= strTraco & vbCrLf

    '        strImpressao &= CentralizarComanda(My.Computer.Clock.LocalTime, strModImpressora) & vbCrLf

    '        RodapeComanda(strImpressao, strModImpressora, strPorta)

    '    ElseIf strModImpressora.Contains("BEMATECH") Or strModImpressora.Contains("ARQUIVO") Or strModImpressora.Contains("NANO PRINT") Then
    '        Dim strImpressao As String

    '        Dim intTamEsp As Integer
    '        Dim strEstrela, strTraço As String

    '        intTamEsp = 42
    '        strEstrela = "******************************************"
    '        strTraço = "------------------------------------------"

    '        strImpressao = Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf & vbCrLf

    '        strImpressao &= strEstrela & vbCrLf & vbCrLf
    '        strImpressao &= Cent("Comanda/Mesa" & ": " & strComanda & "/" & strMesa, intTamEsp) & vbCrLf & vbCrLf
    '        strImpressao &= strEstrela & vbCrLf

    '        strImpressao &= "CODIGO                                 QTD" & vbCrLf
    '        strImpressao &= "DESCRICAO                                 " & vbCrLf

    '        strImpressao &= strTraço & vbCrLf

    '        strImpressao &= Dir(parCod, 20) & Esq(parQtd, 22) & vbCrLf

    '        strImpressao &= parProd & vbCrLf


    '        Dim P As Integer

    '        If parMisto.Trim <> "" Then

    '            Dim strOpci As String = parMisto

    '            Dim vetOpc As Array = Split(strOpci, "|")

    '            For P = 0 To vetOpc.Length - 1
    '                strOpci = vetOpc(P).ToString
    '                strImpressao &= "Opc. " & P + 1 & ": " & strOpci & vbCrLf
    '            Next

    '        End If

    '        If ObsOpcoes <> "" Then
    '            strImpressao &= "OBSERVAÇÃO: " & ObsOpcoes & vbCrLf
    '        End If


    '        strImpressao &= strTraço & vbCrLf

    '        strImpressao &= Cent(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf

    '        strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


    '        If strModImpressora = "ARQUIVO" Then
    '            strImpressao += Avanco() & vbCrLf

    '            If TemGuilhotina = True Then
    '                strImpressao += Corte() & vbCrLf
    '            End If
    '            SendStringToPrinter(strPorta, strImpressao)

    '            ''EscreveArquivo(strPorta & "\" & My.Computer.Name & ".txt", strImpressao)
    '            'ImprimiArquivo(strImpressao, strPorta)
    '        ElseIf strModImpressora.Contains("NANO PRINT") = True Then
    '            If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
    '                ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
    '            Else
    '                EscreveArquivo(strPorta & "\" & My.Computer.Name & ".txt", strImpressao)
    '            End If
    '        Else
    '            If strModImpressora.Contains("MP-4000") Then
    '                iRetorno = ConfiguraModeloImpressora(5)
    '                iRetorno = SelecionaQualidadeImpressao(3)
    '            Else
    '                iRetorno = ConfiguraModeloImpressora(1)
    '            End If
    '            iRetorno = clsBematech.IniciaPorta(strPorta)


    '            iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

    '            If TemGuilhotina = True Then
    '                iRetorno = clsBematech.AcionaGuilhotina(0)
    '            End If
    '        End If

    '    ElseIf strModImpressora = "EPSON" Then
    '        Dim strImpressao As String

    '        Dim intTamEsp As Integer
    '        Dim strEstrela, strTraço As String

    '        strEstrela = clsImprimir.Comp("************************************************")
    '        strTraço = clsImprimir.Comp("------------------------------------------------")

    '        strImpressao = "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf & vbCrLf

    '        strImpressao &= strEstrela & vbCrLf & vbCrLf
    '        strImpressao &= "<ce>" & "Comanda/Mesa" & ": " & strComanda & "/" & strMesa & "</ce>" & vbCrLf & vbCrLf
    '        strImpressao &= strEstrela & vbCrLf

    '        strImpressao &= "CODIGO                                 QTD" & vbCrLf
    '        strImpressao &= "DESCRICAO                                 " & vbCrLf

    '        strImpressao &= strTraço & vbCrLf

    '        strImpressao &= Dir(parCod, 37) & Esq(parQtd, 11) & vbCrLf


    '        strImpressao &= parProd & vbCrLf



    '        Dim P As Integer

    '        If parMisto.Trim <> "" Then

    '            Dim strOpci As String = parMisto

    '            Dim vetOpc As Array = Split(strOpci, "|")

    '            For P = 0 To vetOpc.Length - 1
    '                strOpci = vetOpc(P).ToString
    '                strImpressao &= "Opc. " & P + 1 & ": " & strOpci & vbCrLf
    '            Next

    '        End If

    '        If ObsOpcoes <> "" Then
    '            strImpressao &= "OBSERVAÇÃO: " & ObsOpcoes & vbCrLf
    '        End If




    '        strImpressao &= strTraço & vbCrLf

    '        strImpressao &= "<ce>" & My.Computer.Clock.LocalTime & "</ce>" & vbCrLf

    '        strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")



    '        iRetorno = clsEpson.IniciaPorta(strPorta)

    '        iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

    '        If TemGuilhotina = True Then
    '            iRetorno = clsEpson.AcionaGuilhotina(1)
    '        End If

    '        iRetorno = clsEpson.FechaPorta()

    '    End If
    'End Sub

    Private Sub btnAddOpcao_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAddOpcao.ButtonClick
        If Me.grd2.FocusedRowHandle < 0 Then Exit Sub
        Dim strTipo As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colAdicional)
        Dim strProduto As String = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colOpcoes)
        Dim dblValor As Double = 0
        If Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colValor) <> "" Then
            dblValor = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colValor)
        End If
        Me.tbAdicionados.Rows.Add()
        Me.tbAdicionados.Rows.Item(Me.tbAdicionados.Rows.Count - 1).Item("Descricao") = strTipo & " - " & strProduto
        Me.tbAdicionados.Rows.Item(Me.tbAdicionados.Rows.Count - 1).Item("Valor") = dblValor.ToString("0.00")
        Calcular()
    End Sub

    Private Sub txtQtde_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtQtde.MouseDown
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = True
            Me.pnlAdicionados.Visible = False
            Me.pnlOpcoes.Visible = False
            Me.pnlObservacao.Dock = DockStyle.Top
            'IniciaThreadTeclado()
            AbrirTecladoArquivo(True)

        End If
    
    End Sub

    Private Sub txtObservacao_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtObservacao.MouseDown
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = True
            Me.pnlAdicionados.Visible = False
            Me.pnlOpcoes.Visible = False
            Me.pnlObservacao.Dock = DockStyle.Top
            'IniciaThreadTeclado()
            AbrirTecladoArquivo(True)

        End If
   
    End Sub
End Class