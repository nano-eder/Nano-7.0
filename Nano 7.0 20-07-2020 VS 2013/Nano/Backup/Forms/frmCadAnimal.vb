Imports Nano.clsFuncoes
Imports Nano.clsValidar
Imports System.IO
Public Class frmCadAnimal
    Dim intcod As Integer
    Dim bolsalvalt As Boolean = False
    Dim i As Integer
    Dim resul As DialogResult
    Dim intcodcli As Integer
    Dim file As String = Nothing

    Private Sub frmCadAnimal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmCadAnimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        Try

            CarregarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
   

        PreencherGrupoSetorCusto("R", Me.cboRaca)
        PreencherGrupoSetorCusto("E", Me.cboEspecie)
        Timer1.Start()

        ConfigurarGrid(Me.GridView1, Me, True, Me.btnPadrao)
    End Sub
    Private Sub CarregarGrid()
        CarregarDados("select animal.Codigo, animal.Nome, CodEletronico, Especie, Animal.Sexo, Vivo, Raca, Pelagem, animal.Nascimento," & _
        "animal.Data, Ficha,  animal.CodCli, cliente.Nome as Dono, Animal.Peso, Cliente.Telefone, Cliente.Endereco from animal left join cliente on animal.CodCli = cliente.Codigo", grid1)

        CarregarEspecie()
    End Sub
    Private Sub txtFicha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If


        If Char.IsLower(e.KeyChar) Then

            txtFicha.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If txtNome.Text = Nothing Then
            MsgBox("O campo NOME é obrigatório!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If txtDono.Text = Nothing Then
            MsgBox("Selecione o propriétario!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If bolsalvalt = False Then
            Try

                Inserir("insert into animal(nome, codeletronico, especie, sexo, vivo, raca, pelagem, nascimento, data, ficha, codcli, Peso) values" & _
                "('" & txtNome.Text & "','" & txtID.Text & "','" & cboEspecie.Text & "','" & cboSexo.Text & "','" & chkVivo.Checked & "'" & _
                ",'" & cboRaca.Text & "','" & txtPelagem.Text & "','" & dtNasc.Text & "','" & System.DateTime.Now & "'," & _
                "'" & txtFicha.Rtf.Replace("'", "''").Replace("&", "") & "','" & intcodcli & "'," & Num(Me.txtPeso.Text) & ")")



                MsgBox("Animal cadastrado com sucesso!", MsgBoxStyle.Information)
                SalvarImagem()
                carregargrid()
                LIMPAR()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        Else
            Try
                Atualizar("UPDATE ANIMAL SET nome ='" & txtNome.Text & "', codeletronico='" & txtID.Text & "', especie='" & cboEspecie.Text & "'," & _
                "sexo='" & cboSexo.Text & "', vivo='" & chkVivo.Checked & "', raca='" & cboRaca.Text & "', pelagem='" & txtPelagem.Text & "'," & _
                "nascimento='" & dtNasc.Text & "', ficha='" & txtFicha.Rtf.Replace("'", "''").Replace("&", "") & "', codcli='" & intcodcli & "'," & _
                "Peso = " & Num(Me.txtPeso.Text) & " where codigo='" & intcod & "'")
                MsgBox("Animal alterado com sucesso!", MsgBoxStyle.Information)
                SalvarImagem()
                carregargrid()
                LIMPAR()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub alterar()
        Dim intIndex As Integer
        intIndex = GridView1.FocusedRowHandle
        If intIndex < 0 Then Exit Sub
        intcod = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colCodigo)

        Me.txtDono.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colDono)



        Try
            Me.txtFicha.Rtf = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colFicha)
        Catch ex As Exception
            Me.txtFicha.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colFicha)
        End Try

        Me.txtID.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colCodEletronico)
        Me.txtNome.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colNome)
        Me.txtPelagem.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colPelagem)
        Me.cboEspecie.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colEspecie)
        CarregarRaca()
        Me.cboRaca.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colRaca)
        Me.cboSexo.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colSexo)
        Me.chkVivo.Checked = Me.GridView1.GetRowCellValue(intIndex, Me.colVivo)
        CarregarFoto(intcod)
        Me.dtNasc.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colNascimento)
        intcodcli = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colCodCli)
        Me.txtPeso.Text = Me.GridView1.GetRowCellDisplayText(intIndex, Me.colPeso)
        bolsalvalt = True

    End Sub
    
    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        RetornaPesquisa()
    End Sub
    Private Sub RetornaPesquisa()
        If GridView1.FocusedRowHandle < 0 Then Exit Sub
        If Me.Tag = "PESQUISA" Then
            CodigoDoAnimal = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, Me.colCodigo)
            Me.Close()
            Exit Sub
        Else
            alterar()
        End If
    End Sub
    Private Sub LIMPAR()
        Me.txtPeso.ResetText()
        Me.txtDono.ResetText()
        Me.txtFicha.ResetText()
        Me.txtID.ResetText()
        Me.txtNome.ResetText()
        Me.txtPelagem.ResetText()
        Me.cboEspecie.SelectedIndex = -1
        Me.cboRaca.SelectedIndex = -1
        Me.cboSexo.SelectedIndex = -1
        Me.chkVivo.Checked = False
        Me.dtNasc.ResetText()
        intcodcli = Nothing
        Me.picFoto.Image = Nothing

        bolsalvalt = False
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        resul = MessageBox.Show("Deseja limpar todos os campos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resul = Windows.Forms.DialogResult.No Then Exit Sub
        LIMPAR()
    End Sub

    Private Sub btnFecha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFecha.ItemClick
        Me.Close()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        RetornaPesquisa()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        resul = MessageBox.Show("Deseja Excluir o Registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resul = Windows.Forms.DialogResult.No Then Exit Sub
        Dim intindex As Integer = GridView1.FocusedRowHandle
        If intindex < 0 Then Exit Sub
        intcod = Me.GridView1.GetRowCellDisplayText(intindex, Me.colCodigo)
        Try
            Excluir("Delete animal where codigo =" & intcod)
            MsgBox("Registro excluido com sucesso!", MsgBoxStyle.Information)
            CarregarGrid()
            LIMPAR()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub BuscaCliente()

        Dim frm As New frmCadCliente
        frm.Tag = "PESQUISADono"
        frm.ShowDialog()

        Dim dt As DataTable
        dt = CarregarDataTable("SELECT Nome, Codigo FROM Cliente where Codigo = " & CodigoDoCliente)
        If dt.Rows.Count > 0 Then
            intcodcli = CodigoDoCliente
            If dt.Rows.Item(0).Item("Nome").ToString.Contains("CONSUMIDOR") = True Then
                CodigoDoCliente = 0
                MsgBox("Não é possível cadastar animais para o cliente CONSUMIDOR!", MsgBoxStyle.Information)
                Exit Sub
            End If

            Me.txtDono.Text = dt.Rows.Item(0).Item("Nome").ToString
            intcodcli = dt.Rows.Item(0).Item("Codigo").ToString
        End If
    End Sub

    Private Sub btnBuscarCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCli.Click
        BuscaCliente()

    End Sub

    Private Sub CarregarFoto(ByVal parCodigo As String)

        Dim dt As DataTable = CarregarDataTable("SELECT Foto FROM Animal where Codigo = " & parCodigo)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Foto").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Foto"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)

                Me.picFoto.Image = bitmap
            Else
                Me.picFoto.Image = Nothing
            End If

        Else
            Me.picFoto.Image = Nothing
        End If

    End Sub



    Public Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        'retorna um array de bytes

        Return ms.ToArray()

    End Function

    Private Sub SalvarImagem()
        Me.AnimalTableAdapter.Fill(Me.DsNanoCommerce.Animal)
        If bolsalvalt = False Then

            If Me.picFoto.Image Is Nothing = False Then
                Dim strImagem1 As Byte() = converteimagem(Me.picFoto.Image)
                Me.DsNanoCommerce.Animal.Rows.Item(DsNanoCommerce.Animal.Rows.Count - 1).Item("Foto") = strImagem1

                Me.Validate()
                Me.AnimalBindingSource.EndEdit()
                Me.AnimalTableAdapter.Update(Me.DsNanoCommerce.Animal)
            End If


        Else
            Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Animal order by Codigo")
            Dim I, indice As Integer
            For I = 0 To dtProd.Rows.Count - 1
                If dtProd.Rows.Item(I).Item("Codigo").ToString = intcod Then
                    indice = I
                    Exit For
                End If
            Next
            If Me.picFoto.Image Is Nothing = False Then
                Dim strImagem1 As Byte() = converteimagem(Me.picFoto.Image)
                Me.DsNanoCommerce.Animal.Rows.Item(indice).Item("Foto") = strImagem1

                Me.Validate()
                Me.AnimalBindingSource.EndEdit()
                Me.AnimalTableAdapter.Update(Me.DsNanoCommerce.Animal)
            End If
        End If
    End Sub


    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Try
            Me.OpenFileDialog1.FileName = ""
            OpenFileDialog1.ShowDialog()
            file = Me.OpenFileDialog1.FileName
            If Me.OpenFileDialog1.FileName <> "" Then
                Me.picFoto.Image = System.Drawing.Bitmap.FromFile(file)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnTirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTirar.Click
        frmWebCam.Tag = "ANIMAL"
        frmWebCam.ShowDialog()
    End Sub


    Private Sub txtCodCLi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Tag = "PESQUISA" Then
            Dim index As Integer = -999997
            Me.GridView1.FocusedRowHandle = index
            Me.GridView1.FocusedColumn = Me.colNome
            Me.GridView1.ShowEditor()
        Else
            Me.txtNome.Focus()
        End If
        Timer1.Stop()
    End Sub

    Private Sub cboEspecie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEspecie.SelectedIndexChanged

        CarregarRaca()
    End Sub

    Private Sub CarregarEspecie()
        Me.cboEspecie.Properties.Items.Clear()

        Dim dt As DataTable = CarregarDataTable("SELECT Especie FROM Animal group by Especie")
        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            Me.cboEspecie.Properties.Items.Add(dt.Rows.Item(I).Item("Especie").ToString)
        Next

    End Sub

    Private Sub CarregarRaca()
        Me.cboRaca.Properties.Items.Clear()
        If Me.cboEspecie.Text <> "" Then
            Dim dt As DataTable = CarregarDataTable("SELECT Raca FROM Animal where Especie = '" & Me.cboEspecie.Text & "' group by Raca")
            Dim I As Integer
            For I = 0 To dt.Rows.Count - 1
                Me.cboRaca.Properties.Items.Add(dt.Rows.Item(I).Item("Raca").ToString)
            Next
        End If
    End Sub
    Private Function rtPadFontStyle() As FontStyle
        Dim fs As FontStyle = New FontStyle()
        If Me.btnN.Down Then
            fs = fs Or FontStyle.Bold
        End If
        If Me.btnI.down Then
            fs = fs Or FontStyle.Italic
        End If
        If btnS.down = True Then
            fs = fs Or FontStyle.Underline
        End If
        Return fs
    End Function
    Dim strEstilo As String
    Private modified_Renamed As Boolean
    Private open_Renamed As Boolean

    Private docName_Renamed As String
    Private currentCursor As Cursor

    Protected Property DocName() As String
        Get
            Return docName_Renamed
        End Get
        Set(ByVal value As String)
            If value <> docName_Renamed Then
                docName_Renamed = value
            End If
        End Set
    End Property

    Protected Property Open() As Boolean
        Get
            Return open_Renamed
        End Get
        Set(ByVal value As Boolean)
            If value <> open_Renamed Then
                open_Renamed = value
                Me.txtFicha.HideSelection = Not open_Renamed
            End If
        End Set
    End Property

    Protected Sub InitFormat()
        btnN.Down = SelectFont.Bold
        btnI.down = SelectFont.Italic
        btnS.down = SelectFont.Underline
        'Select Case rtbTexto.SelectionAlignment
        '    Case HorizontalAlignment.Left
        '        btnLe.Checked = True
        '    Case HorizontalAlignment.Center
        '        btnCe.Down = True
        '    Case HorizontalAlignment.Right
        '        btnRi.Down = True
        'End Select
    End Sub

    Protected Sub rtPadClear()
        RefreshForm(True)
        Me.txtFicha.SelectionBullet = False
        Me.txtFicha.SelectionProtected = False
        Me.txtFicha.Clear()
        Me.txtFicha.ClearUndo()
        Me.txtFicha.Focus()
        RefreshForm(False)
    End Sub

    Protected ReadOnly Property SelectFont() As Font
        Get
            If Not Me.txtFicha.SelectionFont Is Nothing Then
                Return Me.txtFicha.SelectionFont
            End If
            Return Me.txtFicha.Font
        End Get
    End Property
    Protected Sub RefreshForm(ByVal b As Boolean)
        If b Then
            currentCursor = Windows.Forms.Cursor.Current
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Refresh()
        Else
            Windows.Forms.Cursor.Current = currentCursor
        End If
    End Sub
    Private Sub btnN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnN.ItemClick
        strEstilo = "N"
        Me.txtFicha.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())

    End Sub

    Private Sub btnI_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnI.ItemClick
        strEstilo = "I"
        txtFicha.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())

    End Sub

    Private Sub btnS_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnS.ItemClick
        strEstilo = "S"
        txtFicha.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())

    End Sub

    Private Sub btnLinha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLinha.ItemClick

        Dim strLinha As String = "_________________________________________________________________________________________________________________________\par" & vbCrLf
        strLinha &= "\par" & vbCrLf
        strLinha &= "}"
        Dim intLinhas As Integer = Me.txtFicha.Lines.Length

        Dim strTeste As String = Me.txtFicha.Rtf
        Dim I As Integer
        Dim strChar As String

        For I = 0 To strTeste.Length
            strChar = strTeste.Substring(strTeste.Length - 1)
            strTeste = strTeste.Substring(0, strTeste.Length - 1)

            If strChar = "}" Then
                Exit For
            End If
        Next

        'If intLinhas > 0 Then
        '    Dim strtt As String = Me.txtFicha.Lines.GetValue(intLinhas - 1)

        '    strTeste = strTeste & strLinha
        'Else
        strTeste = strTeste & strLinha
        'End If
        Me.txtFicha.Rtf = strTeste

        Me.txtFicha.SelectionStart = Me.txtFicha.TextLength
    End Sub

    Private Sub btnMax_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMax.ItemClick
        If Me.btnMax.Tag = "MAX" Then
            Me.btnMax.Tag = "MIN"

            Me.Controls.Add(Me.PanelControl3)
            Me.GroupControl1.Visible = False
            Me.btnMax.Glyph = Global.Nano.My.Resources.Resources.kwin18x18
            Me.PanelControl3.BringToFront()
            Me.PanelControl3.Dock = DockStyle.Top
            Me.PanelControl3.Size = New System.Drawing.Size(1001, 315)

            Dim sTooltip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim args As DevExpress.Utils.SuperToolTipSetupArgs = New DevExpress.Utils.SuperToolTipSetupArgs
            args.Contents.Text = "Restaurar Tamanho Original"
            args.Contents.Font = New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
            sTooltip2.Setup(args)
            Me.btnMax.SuperTip = sTooltip2
        Else
            Me.btnMax.Tag = "MAX"
            Me.btnMax.Glyph = Global.Nano.My.Resources.Resources.kpersonalizer18x18
            Me.GroupControl1.Visible = True
            Me.PanelControl3.Dock = DockStyle.None
            Me.PanelControl3.Size = New System.Drawing.Size(757, 225)
            Me.PanelControl3.Location = New System.Drawing.Point(3, 91)

            Dim sTooltip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim args As DevExpress.Utils.SuperToolTipSetupArgs = New DevExpress.Utils.SuperToolTipSetupArgs
            args.Contents.Text = "Maximizar"
            args.Contents.Font = New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
            sTooltip2.Setup(args)
            Me.btnMax.SuperTip = sTooltip2
        End If
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.GridView1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub btnDados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDados.ItemClick
        Dim rel As New relDadosAnimal
        rel.picLogo.Image = LogoTipo


        rel.lblPeso.Text = Me.txtPeso.Text
        rel.lblProprietario.Text = Me.txtDono.Text
        rel.rtfFicha.Rtf = Me.txtFicha.Rtf
        rel.lblId.Text = Me.txtID.Text
        rel.lblNome.Text = Me.txtNome.Text
        rel.lblPelagem.Text = Me.txtPelagem.Text
        rel.lblEspecie.Text = Me.cboEspecie.Text
        rel.lblRaca.Text = Me.cboRaca.Text
        rel.lblSexo.Text = Me.cboSexo.Text
        rel.chkVivo.Checked = Me.chkVivo.Checked
        rel.lblNascimento.Text = Me.dtNasc.Text
        rel.picFoto.Image = Me.picFoto.Image
        rel.ShowPreview()

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relAnimal
        rel.picLogo.Image = LogoTipo
        Dim I As Integer

        With rel.tbAnimal.Rows
            For I = 0 To Me.GridView1.RowCount - 1
                .Add()
                .Item(I).Item("Nome") = Me.GridView1.GetRowCellDisplayText(I, Me.colNome)
                .Item(I).Item("Proprietario") = Me.GridView1.GetRowCellDisplayText(I, Me.colDono)
                .Item(I).Item("Especie") = Me.GridView1.GetRowCellDisplayText(I, Me.colEspecie)
                .Item(I).Item("Raca") = Me.GridView1.GetRowCellDisplayText(I, Me.colRaca)
                .Item(I).Item("Sexo") = Me.GridView1.GetRowCellDisplayText(I, Me.colSexo)
                .Item(I).Item("Nascimento") = Me.GridView1.GetRowCellDisplayText(I, Me.colNascimento)
                .Item(I).Item("Id") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodEletronico)
                .Item(I).Item("Data") = Me.GridView1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Pelagem") = Me.GridView1.GetRowCellDisplayText(I, Me.colPelagem)
                .Item(I).Item("Peso") = Me.GridView1.GetRowCellDisplayText(I, Me.colPeso)
                .Item(I).Item("Vivo") = Me.GridView1.GetRowCellValue(I, Me.colVivo)
            Next
        End With
        rel.ShowPreview()
    End Sub

    Private Sub btnRelCustomizado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCustomizado.ItemClick
        Me.grid1.ShowPrintPreview()
    End Sub
End Class