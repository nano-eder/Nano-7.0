Imports Nano.clsFuncoes
Imports System.IO
Public Class frmGrupo
    Public intCodigo As Integer
    Public bolAlterar As Boolean
    Dim strTipo As String = ""
    Dim strNome As String
    Public strBairro As String

    Private Sub frmGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        Me.GroupControl1.Visible = False
        Me.txtNome.Size = New System.Drawing.Size(464, 20)
        Me.txtPorta.Size = New System.Drawing.Size(259, 20)
        Me.colPortaImpressora.Caption = "Porta"
        Me.colPortaImpressora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default
        Me.lblPorta.Text = "Porta"
        Me.colImpressora.Visible = True
        Select Case Me.Tag
            Case "SETOR"
                Me.txtNome.Size = New System.Drawing.Size(320, 20)
                Me.txtPorta.Size = New System.Drawing.Size(115, 20)
                Me.GroupControl1.Visible = True
        End Select

        Me.lblPorta.Visible = Master
        Me.txtPorta.Visible = Master
        Me.colPortaImpressora.Visible = Master
        Limpar()


        Select Case Me.Tag
            Case "BAIRRO"
                Dim I As Integer
                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Tipo = 'B'")
                If dt.Rows.Count > 0 Then
                    Dim dtCli As DataTable = CarregarDataTable("SELECT Bairro FROM Cliente group by Bairro")
                    If dtCli.Rows.Count > 0 Then
                        For I = 0 To dtCli.Rows.Count - 1
                            Dim strBairro As String = dtCli.Rows.Item(I).Item("Bairro").ToString
                            If strBairro <> "" Then
                                Inserir("If not exists(Select Codigo from Grupo where Tipo = 'B' and Nome = '" & strBairro & "') INSERT INTO Grupo (Nome, Tipo, PortaImpressora) VALUES ('" & TirarAcento(strBairro) & "','B','0,00')")
                            End If
                        Next
                    End If
                End If
                Me.lblPorta.Text = "Valor"
                Me.colPortaImpressora.Caption = "Valor"
                Me.colPortaImpressora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

                Me.txtPorta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                Me.colImpressora.Visible = False
        End Select
        AtualizarGrid()

        bolAlterar = False
        Timer1.Start()

    End Sub
    Private Sub AtualizarGrid()
        Select Case Me.Tag
            Case "GRUPO"
                Me.Text = "Cadastro de Grupos de Produto"
                Me.grpCad.Text = "Grupos Cadastrados"
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='G'", Me.GrupoGridControl)
                strTipo = "G"
            Case "SETOR"
                If TipoNano = 2 Then
                    Me.Text = "Cadastro de Marcas"
                    Me.grpCad.Text = "Marcas Cadastradas"
                Else
                    Me.Text = "Cadastro de Setores"
                    Me.grpCad.Text = "Setores Cadastrados"
                End If
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='S'", Me.GrupoGridControl)
                strTipo = "S"
            Case "FAMILIA"
                Me.Text = "Cadastro de Família"
                Me.grpCad.Text = "Famílias Cadastradas"
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='F'", Me.GrupoGridControl)
                strTipo = "F"
            Case "CENTROCUSTO"
                Me.Text = "Cadastro de Centro de Custo"
                Me.grpCad.Text = "Centros de Custos Cadastrados"
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='C'", Me.GrupoGridControl)
                strTipo = "C"
            Case "TABELAPRECO"
                Me.lblImp.Visible = False
                Me.cboImpressora.Visible = False
                Me.lblPorta.Visible = False
                Me.txtPorta.Visible = False
                Me.colPortaImpressora.Visible = False
                Me.colImpressora.Visible = False
                Me.Text = "Cadastro de Tabela de Preço"
                Me.grpCad.Text = "Tabela de Preços Cadastradas"
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='T'", Me.GrupoGridControl)
                strTipo = "T"
            Case "PEDIDO"
                Me.lblImp.Visible = False
                Me.cboImpressora.Visible = False
                Me.lblPorta.Visible = False
                Me.txtPorta.Visible = False
                Me.colPortaImpressora.Visible = False
                Me.colImpressora.Visible = False
                Me.Text = "Cadastro de Status de Pedido"
                Me.grpCad.Text = "Status de Pedido Cadastrados"
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='P'", Me.GrupoGridControl)
                strTipo = "P"
            Case "UNIDADEMEDIDA"
                Me.lblImp.Visible = False
                Me.cboImpressora.Visible = False
                Me.lblPorta.Visible = False
                Me.txtPorta.Visible = False
                Me.colPortaImpressora.Visible = False
                Me.colImpressora.Visible = False

                Me.txtNome.Properties.MaxLength = 2
                Me.Text = "Cadastro de Unidade Medida"
                Me.grpCad.Text = "Unidade Medida Cadastradas"
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='U'", Me.GrupoGridControl)
                strTipo = "U"
            Case "SEGURADORA"
                Me.lblImp.Visible = False
                Me.cboImpressora.Visible = False
                Me.lblPorta.Visible = False
                Me.txtPorta.Visible = False
                Me.colPortaImpressora.Visible = False
                Me.colImpressora.Visible = False


                Me.Text = "Cadastro de Seguradora"
                Me.grpCad.Text = "Seguradoras Cadastradas"
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='SEG'", Me.GrupoGridControl)
                strTipo = "SEG"
            Case "BAIRRO"
                strTipo = "B"
                Me.Text = "Cadastro de Frete por Bairro"
                Me.lblImp.Visible = False
                Me.cboImpressora.Visible = False
                Me.lblPorta.Visible = True
                Me.txtPorta.Visible = True
                Me.colPortaImpressora.Visible = True
                CarregarDados("SELECT * FROM Grupo WHERE Tipo ='B'", Me.GrupoGridControl)
            Case "MOTIVO"
                Me.lblImp.Text = "Tipo"
                Me.cboImpressora.Properties.Items.Clear()
                Me.cboImpressora.Properties.Items.Add("C")
                Me.cboImpressora.Properties.Items.Add("D")

                Me.colPortaImpressora.Visible = False
                Me.colImpressora.Visible = False

                Me.colTipo.Visible = True
                Me.lblPorta.Visible = False
                Me.txtPorta.Visible = False
                Me.Text = "Cadastro de Motivos do Caixa"
                Me.grpCad.Text = "Motivos Cadastrados"
                CarregarDados("SELECT Codigo, Nome, PortaImpressora, Impressora, case when Tipo = 'R' then 'C' else 'D' end as Tipo FROM Grupo WHERE Tipo ='R' or Tipo = 'D'", Me.GrupoGridControl)
        End Select

    End Sub
    Private Sub Limpar()
        Select Case Me.Tag
            Case "SETOR"
                Me.picImagem.Image = Nothing
        End Select

        Me.txtNome.ResetText()
        Me.txtPorta.ResetText()
        Me.cboImpressora.SelectedIndex = -1
        bolAlterar = False
        Me.txtNome.Focus()
    End Sub
    Private Sub Alterar()
        bolAlterar = True
        intCodigo = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        strNome = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
        Me.txtNome.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
        Me.txtPorta.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colPortaImpressora)
        If Me.Tag = "MOTIVO" Then
            If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colTipo) = "R" Then
                Me.cboImpressora.Text = "C"
            Else
                Me.cboImpressora.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colTipo)
            End If

        Else
            Me.cboImpressora.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colImpressora)
        End If
        Select Case Me.Tag
            Case "SETOR"
                CarregarImagem(intCodigo)
        End Select
    End Sub
    Private Sub CarregarImagem(ByVal parCodigo As String)
        If parCodigo = "" Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("SELECT Imagem FROM Grupo where Codigo = " & parCodigo)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Imagem").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)
                Me.picImagem.Image = bitmap
            Else
                Me.picImagem.Image = Nothing
            End If
        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.txtNome) = False Then Exit Sub
        If Me.Tag = "MOTIVO" Then
            If Validar(Me.cboImpressora) = False Then Exit Sub
            If Me.cboImpressora.Text = "C" Then
                strTipo = "R"
            Else
                strTipo = Me.cboImpressora.Text
            End If

        End If
        If bolAlterar = False Then

            If Existe("Nome", "Grupo", "Nome", Me.txtNome.Text.Trim, False) = True Then
                Select Case Me.Tag
                    Case "GRUPO"
                        MsgBox("Já existe um grupo cadastrado com esse nome!", MsgBoxStyle.Information)

                    Case "SETOR"
                        MsgBox("Já existe um setor cadastrado com esse nome!", MsgBoxStyle.Information)

                    Case "FAMILIA"
                        MsgBox("Já existe uma familia cadastrada com esse nome!", MsgBoxStyle.Information)

                    Case "CENTROCUSTO"
                        MsgBox("Já existe um centro de custo cadastrado com esse nome!", MsgBoxStyle.Information)

                    Case "TABELAPRECO"
                        MsgBox("Já existe uma tabela de preço cadastrada com esse nome!", MsgBoxStyle.Information)

                    Case "PEDIDO"
                        MsgBox("Já existe um pedido cadastrado com esse nome!", MsgBoxStyle.Information)

                    Case "UNIDADEMEDIDA"
                        MsgBox("Já existe uma unidade medida cadastrada com esse nome!", MsgBoxStyle.Information)

                    Case "SEGURADORA"
                        MsgBox("Já existe uma seguradora cadastrado com esse nome!", MsgBoxStyle.Information)

                    Case "BAIRRO"
                        MsgBox("Já existe um bairro cadastrado com esse nome!", MsgBoxStyle.Information)

                    Case "MOTIVO"
                        MsgBox("Já existe um motivo cadastrado com esse nome!", MsgBoxStyle.Information)

                End Select
                Me.txtNome.ResetText()
                Exit Sub
            End If

            
            If Inserir("INSERT INTO Grupo (Nome, Tipo, PortaImpressora, Impressora) VALUES ('" & TirarAcento(Me.txtNome.Text.Trim) & "'," & _
            "'" & strTipo & "','" & Me.txtPorta.Text.Trim & "','" & Me.cboImpressora.Text & "')") = True Then

                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Nome = '" & Me.txtNome.Text.Trim & "' and Tipo = '" & strTipo & "'")
                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Codigo").ToString <> "" Then
                        intCodigo = dt.Rows.Item(0).Item("Codigo")
                    End If
                End If
                MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
                Exit Sub
            End If

        Else
            If Atualizar("UPDATE Grupo SET Nome = '" & TirarAcento(Me.txtNome.Text.Trim) & "', PortaImpressora ='" & Me.txtPorta.Text.Trim & "', " & _
            "Impressora = '" & Me.cboImpressora.Text & "' where Codigo = " & intCodigo) = True Then
                If strTipo = "S" Then
                    Atualizar("UPDATE Produto SET Setor = '" & Me.txtNome.Text.Trim & "' where Setor = '" & strNome & "'")
                End If
                If strTipo = "C" Then
                    Atualizar("UPDATE ContaPagar SET CentroCusto = '" & Me.txtNome.Text.Trim & "' where CentroCusto = '" & strNome & "'")
                    Atualizar("UPDATE Caixa SET CentroCusto = '" & Me.txtNome.Text.Trim & "' where CentroCusto = '" & strNome & "'")
                End If

                If strTipo = "D" Or strTipo = "R" Then
                    Atualizar("UPDATE Grupo SET Tipo = '" & strTipo & "' where Codigo = " & intCodigo)
                End If

                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information)

            Else
                MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
            End If

        End If

        Select Case Me.Tag
            Case "SETOR"
                If Me.picImagem.Image Is Nothing = False Then
                    Dim imagem As Byte() = converteimagem(Me.picImagem.Image)
                    InserirImagem("UPDATE Grupo set Imagem = @Img where Codigo = " & intCodigo, imagem)
                End If
        End Select
        AtualizarGrid()
        Limpar()

    End Sub
    Public Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function
    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If grd1.FocusedRowHandle < 0 Then Exit Sub
        If grd1.RowCount = 0 Then Exit Sub
        Dim strNome As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
        If Me.Tag = "TABELAPRECO" Then
            If MsgBox("Deseja realmente excluir o Ítem " & strNome & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If MsgBox("Ao excluir o Ítem " & strNome & " todos os preços relacionados a tabela serão excluidos, deseja realmente excluir o Íten " & strNome & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Excluir("DELETE FROM Grupo where Codigo = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))
                    Excluir("DELETE FROM TabelaPreco where CodTabela = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))

                    MsgBox(strNome & " excluido com sucesso.", MsgBoxStyle.Information)
                    AtualizarGrid()
                    Limpar()
                End If
            End If
        Else
            If MsgBox("Deseja realmente excluir o Ítem " & strNome & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Excluir("DELETE FROM Grupo where Codigo = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))
                MsgBox(strNome & " excluido com sucesso.", MsgBoxStyle.Information)
                AtualizarGrid()
                Limpar()
            End If
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.Tag = "SEGURADORA" Then
            Seguradora = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
            Me.Close()
            Exit Sub
        Else
            Alterar()
        End If

    End Sub

    Private Sub txtAlterar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlterar.KeyPress
        'If grd1.FocusedRowHandle >= 0 Then
        '    Me.colNome.OptionsColumn.ReadOnly = True
        'Else
        '    Me.colNome.OptionsColumn.ReadOnly = False
        'End If
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
      Alterar()

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Me.GrupoGridControl.ShowPrintPreview()
    End Sub

    'Private Sub picImagem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagem.Click

    '    ofdImagem.FileName = ""
    '    ofdImagem.ShowDialog()
    '    If ofdImagem.FileName <> "" Then
    '        Me.picImagem.Image = System.Drawing.Bitmap.FromFile(ofdImagem.FileName)
    '        Dim intw As Integer = Me.picImagem.Image.Width
    '        Dim inth As Integer = Me.picImagem.Image.Height
    '        inth = (180 * inth) / intw

    '        Dim dest_image As New Bitmap(180, inth)
    '        Dim g As Graphics = Graphics.FromImage(dest_image)
    '        g.DrawImage(System.Drawing.Bitmap.FromFile(ofdImagem.FileName), 0, 0, dest_image.Width + 1, dest_image.Height + 1)
    '        Me.picImagem.Image = dest_image

    '    End If
    'End Sub


    Private Sub picImagem_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picImagem.MouseDown

        If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left Then
            ofdImagem.FileName = ""
            ofdImagem.ShowDialog()
            If ofdImagem.FileName <> "" Then
                Me.picImagem.Image = System.Drawing.Bitmap.FromFile(ofdImagem.FileName)
                Dim intw As Integer = Me.picImagem.Image.Width
                Dim inth As Integer = Me.picImagem.Image.Height
                inth = (180 * inth) / intw

                Dim dest_image As New Bitmap(180, inth)
                Dim g As Graphics = Graphics.FromImage(dest_image)
                g.DrawImage(System.Drawing.Bitmap.FromFile(ofdImagem.FileName), 0, 0, dest_image.Width + 1, dest_image.Height + 1)
                Me.picImagem.Image = dest_image

            End If
        End If
    End Sub

    Private Sub txtPorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorta.KeyPress
        If Me.Tag = "BAIRRO" Then
            If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
                e.Handled = True
            End If
        End If
      
    End Sub

    Private Sub txtPorta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorta.Leave
        If Me.Tag = "BAIRRO" Then
            Preco(Me.txtPorta)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.grd1.ClearColumnsFilter()
        If Me.Tag = "BAIRRO" Then
            If strBairro <> "" Then
                Dim dtGrupo As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Nome = '" & strBairro & "' and Tipo = 'B'")
                If dtGrupo.Rows.Count > 0 Then
                    Dim index As Integer = -999997
                    grd1.FocusedRowHandle = index
                    grd1.FocusedColumn = Me.colNome
                    grd1.SetRowCellValue(index, Me.colNome, strBairro)
                    grd1.ShowEditor()
                Else
                    Me.txtNome.Text = strBairro
                    Me.txtPorta.Focus()
                End If
            Else
                Me.txtNome.Focus()
            End If

        Else
            Me.txtNome.Focus()
        End If
        Timer1.Stop()
    End Sub
End Class