Imports System.IO
Imports System.IO.File
Imports Nano.clsFuncoes
Imports DevExpress.XtraEditors.Popup.PopupColorEditForm
Imports DevExpress.XtraEditors.Popup
Public Class frmConfigComanda

    Private Sub frmConfigComanda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        MDIComanda.PictureEdit1.Properties.Appearance.BackColor = CorBarra
        MDIComanda.btnAbrirComanda.Appearance.BackColor = CorBarra
        MDIComanda.SimpleButton1.Appearance.BackColor = CorBarra
        MDIComanda.btnComandaPrincipal.Appearance.BackColor = CorBarra
        MDIComanda.btnVoltar.Appearance.BackColor = CorBarra
        MDIComanda.lblHora.Appearance.BackColor = CorBarra
        MDIComanda.btnTeclado.Appearance.BackColor = CorBarra
        MDIComanda.btnConfigComanda.Appearance.BackColor = CorBarra
        MDIComanda.btnConsultar.Appearance.BackColor = CorBarra
        MDIComanda.btnReabrirComanda.Appearance.BackColor = CorBarra
        MDIComanda.btnVender.Appearance.BackColor = CorBarra

        If TecladoVirtual = False Then
            MDIComanda.btnTeclado.Visible = False
        Else
            MDIComanda.btnTeclado.Visible = True
        End If

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra) = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Novo.png") = True Then
                MDIComanda.btnAbrirComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Novo.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Comanda.png") = True Then
                MDIComanda.btnComandaPrincipal.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Comanda.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Voltar.png") = True Then
                MDIComanda.btnVoltar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Voltar.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Teclado.png") = True Then
                MDIComanda.btnTeclado.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Teclado.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Fechar.png") = True Then
                MDIComanda.SimpleButton1.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Fechar.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Config.png") = True Then
                MDIComanda.btnConfigComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Config.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Consultar.png") = True Then
                MDIComanda.btnConsultar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Consultar.png")
            End If

            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Reabrir.png") = True Then
                MDIComanda.btnReabrirComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Reabrir.png")
            End If

            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Finalizar.png") = True Then
                MDIComanda.btnVender.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Finalizar.png")
            End If
        End If
    End Sub

    Private Sub frmConfigComanda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao) = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Padrao.png") = True Then
                Me.btnPadrao.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Padrao.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Ok.png") = True Then
                Me.btnSalvar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Ok.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Menos.png") = True Then
                Me.btnMenos.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Menos.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Mais.png") = True Then
                Me.btnMais.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Mais.png")
            End If
        End If



        FormAberto = Me.Name
        Me.clrFundo.Color = CorFundo
        Me.clrBarra.Color = CorBarra
        Me.clrTeclado.Color = CorTeclado
        Me.clrComanda.Color = CorComanda
        Me.clrGrupo.Color = CorGrupo
        Me.clrProduto.Color = CorProduto
        Me.clrFonte.Color = CorFonte
        Me.clrBotoes.Color = CorBotoes

        Me.clrFundo.BackColor = CorFundo
        Me.clrBarra.BackColor = CorBarra
        Me.clrTeclado.BackColor = CorTeclado
        Me.clrComanda.BackColor = CorComanda
        Me.clrGrupo.BackColor = CorGrupo
        Me.clrProduto.BackColor = CorProduto
        Me.clrFonte.BackColor = CorFonte
        Me.clrBotoes.BackColor = CorBotoes


        If TecladoVirtual = True Then
            Me.cboTecladoVirtual.SelectedIndex = 0
        Else
            Me.cboTecladoVirtual.SelectedIndex = 1
        End If

        If QtdeVaziaComanda = False Then
            Me.cboQtdeVazia.SelectedIndex = 1
        Else
            Me.cboQtdeVazia.SelectedIndex = 0
        End If
        Select Case CorImagemBarra
            Case "Preto"
                Me.cboImagemBarra.Text = "Preto"
                Me.cboImagemBarra.Properties.Appearance.BackColor = Color.Black
                Me.cboImagemBarra.Properties.Appearance.ForeColor = Color.Black
            Case "Branco"
                Me.cboImagemBarra.Text = "Branco"
                Me.cboImagemBarra.Properties.Appearance.BackColor = Color.White
                Me.cboImagemBarra.Properties.Appearance.ForeColor = Color.White
            Case Else
                Me.cboImagemBarra.Text = "Laranja"
                Me.cboImagemBarra.Properties.Appearance.BackColor = Color.Orange
                Me.cboImagemBarra.Properties.Appearance.ForeColor = Color.Orange
        End Select

        Select Case CorImagemBotao
            Case "Preto"
                Me.cboImagemBotao.Text = "Preto"
                Me.cboImagemBotao.Properties.Appearance.BackColor = Color.Black
                Me.cboImagemBotao.Properties.Appearance.ForeColor = Color.Black
            Case "Branco"
                Me.cboImagemBotao.Text = "Branco"
                Me.cboImagemBotao.Properties.Appearance.BackColor = Color.White
                Me.cboImagemBotao.Properties.Appearance.ForeColor = Color.White
            Case Else
                Me.cboImagemBotao.Text = "Laranja"
                Me.cboImagemBotao.Properties.Appearance.BackColor = Color.Orange
                Me.cboImagemBotao.Properties.Appearance.ForeColor = Color.Orange
        End Select

        Me.txtQtde.Text = LocationTeclado
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Validar(Me.txtQtde) = False Then Exit Sub
        Dim strCorFundo As String = ColorString(Me.clrFundo.Color)
        Dim strCorBarra As String = ColorString(Me.clrBarra.Color)
        Dim strCorTeclado As String = ColorString(Me.clrTeclado.Color)
        Dim strCorComanda As String = ColorString(Me.clrComanda.Color)
        Dim strCorGrupo As String = ColorString(Me.clrGrupo.Color)
        Dim strCorProduto As String = ColorString(Me.clrProduto.Color)
        Dim strCorFonte As String = ColorString(Me.clrFonte.Color)
        Dim strCorBotoes As String = ColorString(Me.clrBotoes.Color)


        Dim strConfigColor As String = strCorFundo & "|" & strCorBarra & "|" & strCorTeclado & "|" & strCorComanda & "|" & strCorGrupo & "|" & strCorProduto & "|" & strCorFonte & "|" & strCorBotoes & "|" & Me.txtQtde.Text & "|" & Me.cboImagemBarra.Text & "|" & Me.cboImagemBotao.Text & "|" & Me.cboTecladoVirtual.Text & "|" & Me.cboQtdeVazia.Text

        If IO.File.Exists(My.Application.Info.DirectoryPath & "\ConfigComanda.txt") = True Then
            IO.File.Delete(My.Application.Info.DirectoryPath & "\ConfigComanda.txt")
        End If
        Dim SW As New StreamWriter(My.Application.Info.DirectoryPath & "\ConfigComanda.txt")

        SW.WriteLine(strConfigColor)
        SW.Close()
        SW.Dispose()
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda") = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa.png") = True Then
                Dim imagem As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa.png")

                Dim bmp As Bitmap = New Bitmap(imagem)

                Dim g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Me.clrComanda.Color)
                g.DrawImage(imagem, 0, 0, imagem.Width, imagem.Height)

                bmp.Save(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa1.png", imagem.RawFormat)
                If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa1.png") = True Then
                    Imagem1Comanda = frmCadProduto.converteimagem(System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa1.png"))
                End If
                'If IO.File.Exists(My.Application.Info.DirectoryPath & "/Mesa2.png") = True Then
                '    Imagem2Comanda = frmCadProduto.converteimagem(System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/Mesa2.png"))
                'Else
                '    Imagem2Comanda = frmCadProduto.converteimagem(imagem)
                'End If
            End If
        End If
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\ConfigComanda.txt") = True Then
            Dim strStringColor As String = LerArquivo(My.Application.Info.DirectoryPath & "\ConfigComanda.txt", False)
            ConverterColor(strStringColor)

            MDIComanda.PictureEdit1.Properties.Appearance.BackColor = CorBarra
            MDIComanda.btnAbrirComanda.Appearance.BackColor = CorBarra
            MDIComanda.SimpleButton1.Appearance.BackColor = CorBarra
            MDIComanda.btnComandaPrincipal.Appearance.BackColor = CorBarra
            MDIComanda.btnVoltar.Appearance.BackColor = CorBarra
            MDIComanda.lblHora.Appearance.BackColor = CorBarra
            MDIComanda.btnTeclado.Appearance.BackColor = CorBarra
            MDIComanda.btnConfigComanda.Appearance.BackColor = CorBarra
            MDIComanda.btnConsultar.Appearance.BackColor = CorBarra
            MDIComanda.btnReabrirComanda.Appearance.BackColor = CorBarra
            MDIComanda.btnVender.Appearance.BackColor = CorBarra
            If TecladoVirtual = False Then
                MDIComanda.btnTeclado.Visible = False
            End If

            'If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra) = True Then
            '    If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Novo.png") = True Then
            '        MDIComanda.btnAbrirComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Novo.png")
            '    End If
            '    If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Comanda.png") = True Then
            '        MDIComanda.btnComandaPrincipal.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Comanda.png")
            '    End If
            '    If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Voltar.png") = True Then
            '        MDIComanda.btnVoltar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Voltar.png")
            '    End If
            '    If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Teclado.png") = True Then
            '        MDIComanda.btnTeclado.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Teclado.png")
            '    End If
            '    If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Fechar.png") = True Then
            '        MDIComanda.SimpleButton1.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Fechar.png")
            '    End If
            '    If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Config.png") = True Then
            '        MDIComanda.btnConfigComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Config.png")
            '    End If
            '    If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Consultar.png") = True Then
            '        MDIComanda.btnConsultar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Consultar.png")
            '    End If

            'End If

        End If

        frmComandaMensagem.lblMensagem.Text = "Configuração salva com sucesso!"
        frmComandaMensagem.btnSim.Visible = False
        frmComandaMensagem.btnNao.Text = "Ok"
        frmComandaMensagem.Size = New System.Drawing.Size(488, 210)
        frmComandaMensagem.btnNao.Location = New System.Drawing.Point(152, 107)
        frmComandaMensagem.ShowDialog()

        Me.Close()
        frmComandaPrincipal.MdiParent = MDIComanda
        frmComandaPrincipal.Show()
        frmComandaPrincipal.Dock = DockStyle.Fill
    End Sub

    Private Shared Function ColorString(ByVal parCor As System.Drawing.Color) As String

        Dim intR As Integer = parCor.R
        Dim intG As Integer = parCor.G
        Dim intB As Integer = parCor.B
        Dim strCorFundo As String = intR & "," & intG & "," & intB
        Return strCorFundo

    End Function



    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        Me.clrFundo.Color = Color.AliceBlue
        Me.clrBarra.Color = Color.DarkSlateGray
        Me.clrTeclado.Color = Color.Azure
        Me.clrComanda.Color = Color.SteelBlue
        Me.clrGrupo.Color = Color.SteelBlue
        Me.clrProduto.Color = Color.MediumAquamarine
        Me.clrFonte.Color = Color.AliceBlue
        Me.clrBotoes.Color = Color.DarkSlateGray

        Me.clrFundo.BackColor = Color.AliceBlue
        Me.clrBarra.BackColor = Color.DarkSlateGray
        Me.clrTeclado.BackColor = Color.Azure
        Me.clrComanda.BackColor = Color.SteelBlue
        Me.clrGrupo.BackColor = Color.SteelBlue
        Me.clrProduto.BackColor = Color.MediumAquamarine
        Me.clrFonte.BackColor = Color.AliceBlue
        Me.clrBotoes.BackColor = Color.DarkSlateGray

        Dim strCorFundo As String = ColorString(Me.clrFundo.Color)
        Dim strCorBarra As String = ColorString(Me.clrBarra.Color)
        Dim strCorTeclado As String = ColorString(Me.clrTeclado.Color)
        Dim strCorComanda As String = ColorString(Me.clrComanda.Color)
        Dim strCorGrupo As String = ColorString(Me.clrGrupo.Color)
        Dim strCorProduto As String = ColorString(Me.clrProduto.Color)
        Dim strCorFonte As String = ColorString(Me.clrFonte.Color)
        Dim strCorBotoes As String = ColorString(Me.clrBotoes.Color)

        Me.txtQtde.Text = "300"



        Me.cboImagemBarra.Text = "Laranja"
        Me.cboImagemBarra.Properties.Appearance.BackColor = Color.Orange
        Me.cboImagemBarra.Properties.Appearance.ForeColor = Color.Orange

        Me.cboImagemBotao.Text = "Laranja"
        Me.cboImagemBotao.Properties.Appearance.BackColor = Color.Orange
        Me.cboImagemBotao.Properties.Appearance.ForeColor = Color.Orange

        Me.cboTecladoVirtual.SelectedIndex = 0
        Me.cboQtdeVazia.SelectedText = 1
        Dim strConfigColor As String = strCorFundo & "|" & strCorBarra & "|" & strCorTeclado & "|" & strCorComanda & "|" & strCorGrupo & "|" & strCorProduto & "|" & strCorFonte & "|" & strCorBotoes & "|" & Me.txtQtde.Text & "|" & Me.cboImagemBarra.Text & "|" & Me.cboImagemBotao.Text & "|" & Me.cboTecladoVirtual.Text & "|" & Me.cboQtdeVazia.Text


        If IO.File.Exists(My.Application.Info.DirectoryPath & "\ConfigComanda.txt") = True Then
            IO.File.Delete(My.Application.Info.DirectoryPath & "\ConfigComanda.txt")
        End If
        Dim SW As New StreamWriter(My.Application.Info.DirectoryPath & "\ConfigComanda.txt")

        SW.WriteLine(strConfigColor)
        SW.Close()
        SW.Dispose()
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda") = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa.png") = True Then
                Dim imagem As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa.png")

                Dim bmp As Bitmap = New Bitmap(imagem)

                Dim g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Me.clrComanda.Color)
                g.DrawImage(imagem, 0, 0, imagem.Width, imagem.Height)

                bmp.Save(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa1.png", imagem.RawFormat)
                If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa1.png") = True Then
                    Imagem1Comanda = frmCadProduto.converteimagem(System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa1.png"))
                End If
                'If IO.File.Exists(My.Application.Info.DirectoryPath & "/Mesa2.png") = True Then
                '    Imagem2Comanda = frmCadProduto.converteimagem(System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/Mesa2.png"))
                'Else
                '    Imagem2Comanda = frmCadProduto.converteimagem(imagem)
                'End If
            End If
        End If

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
        TecladoVirtual = True
        QtdeVaziaComanda = False

        MDIComanda.PictureEdit1.Properties.Appearance.BackColor = CorBarra
        MDIComanda.btnAbrirComanda.Appearance.BackColor = CorBarra
        MDIComanda.SimpleButton1.Appearance.BackColor = CorBarra
        MDIComanda.btnComandaPrincipal.Appearance.BackColor = CorBarra
        MDIComanda.btnVoltar.Appearance.BackColor = CorBarra
        MDIComanda.lblHora.Appearance.BackColor = CorBarra
        MDIComanda.btnTeclado.Appearance.BackColor = CorBarra
        MDIComanda.btnConfigComanda.Appearance.BackColor = CorBarra
        MDIComanda.btnConsultar.Appearance.BackColor = CorBarra
        MDIComanda.btnReabrirComanda.Appearance.BackColor = CorBarra
        MDIComanda.btnVender.Appearance.BackColor = CorBarra

        MDIComanda.btnTeclado.Visible = True

        frmComandaMensagem.lblMensagem.Text = "Configuração salva com sucesso!"
        frmComandaMensagem.btnSim.Visible = False
        frmComandaMensagem.btnNao.Text = "Ok"
        frmComandaMensagem.Size = New System.Drawing.Size(488, 210)
        frmComandaMensagem.btnNao.Location = New System.Drawing.Point(152, 107)
        frmComandaMensagem.ShowDialog()


        Me.Close()
        frmComandaPrincipal.MdiParent = MDIComanda
        frmComandaPrincipal.Show()
        frmComandaPrincipal.Dock = DockStyle.Fill

    End Sub

    Private Sub clrFundo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrFundo.EditValueChanged
        Me.clrFundo.Properties.Appearance.BackColor = Me.clrFundo.EditValue
    End Sub

    Private Sub clrBarra_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrBarra.EditValueChanged
        Me.clrBarra.Properties.Appearance.BackColor = Me.clrBarra.EditValue

        MDIComanda.PictureEdit1.Properties.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.btnAbrirComanda.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.SimpleButton1.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.btnComandaPrincipal.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.btnVoltar.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.lblHora.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.btnTeclado.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.btnConfigComanda.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.btnConsultar.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.btnVender.Appearance.BackColor = Me.clrBarra.EditValue
        MDIComanda.btnReabrirComanda.Appearance.BackColor = Me.clrBarra.EditValue
    End Sub

    Private Sub clrTeclado_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrTeclado.EditValueChanged
        Me.clrTeclado.Properties.Appearance.BackColor = Me.clrTeclado.EditValue
    End Sub

    Private Sub clrComanda_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrComanda.EditValueChanged
        Me.clrComanda.Properties.Appearance.BackColor = Me.clrComanda.EditValue
    End Sub

    Private Sub clrGrupo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrGrupo.EditValueChanged
        Me.clrGrupo.Properties.Appearance.BackColor = Me.clrGrupo.EditValue
    End Sub

    Private Sub clrProduto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrProduto.EditValueChanged
        Me.clrProduto.Properties.Appearance.BackColor = Me.clrProduto.EditValue
    End Sub

    Private Sub clrFonte_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrFonte.EditValueChanged
        Me.clrFonte.Properties.Appearance.BackColor = Me.clrFonte.EditValue
    End Sub

    Private Sub clrBotoes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrBotoes.EditValueChanged
        Me.clrBotoes.Properties.Appearance.BackColor = Me.clrBotoes.EditValue

        Me.btnMais.Appearance.BackColor = Me.clrBotoes.EditValue
        Me.btnMenos.Appearance.BackColor = Me.clrBotoes.EditValue
        Me.btnPadrao.Appearance.BackColor = Me.clrBotoes.EditValue
        Me.btnSalvar.Appearance.BackColor = Me.clrBotoes.EditValue
    End Sub
    Private Sub btnMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenos.Click

        If Me.txtQtde.Text = "" Then Exit Sub
        Dim dblQtde As Double = Me.txtQtde.Text
        If dblQtde <= 0 Then Exit Sub

        dblQtde -= 1
        Me.txtQtde.Text = dblQtde
    End Sub

    Private Sub btnMais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMais.Click
        If Me.txtQtde.Text = "" Then
            Me.txtQtde.Text = "0"
        End If
        Dim dblQtde As Double = Me.txtQtde.Text

        dblQtde += 1
        Me.txtQtde.Text = dblQtde
    End Sub


    Private Sub clrComanda_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles clrComanda.Popup, clrBarra.Popup, clrBotoes.Popup, clrFonte.Popup, clrFundo.Popup, clrGrupo.Popup, clrProduto.Popup, clrTeclado.Popup
        Dim form As PopupColorEditForm = TryCast((TryCast(sender, DevExpress.Utils.Win.IPopupControl)).PopupWindow, PopupColorEditForm)
        form.Size = New Size(400, 450)
    End Sub


    Private Sub cboImagemBarra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboImagemBarra.SelectedIndexChanged
        Select Case cboImagemBarra.Text
            Case "Preto"
                Me.cboImagemBarra.Properties.Appearance.BackColor = Color.Black
                Me.cboImagemBarra.Properties.Appearance.ForeColor = Color.Black
            Case "Branco"
                Me.cboImagemBarra.Properties.Appearance.BackColor = Color.White
                Me.cboImagemBarra.Properties.Appearance.ForeColor = Color.White
            Case Else
                Me.cboImagemBarra.Properties.Appearance.BackColor = Color.Orange
                Me.cboImagemBarra.Properties.Appearance.ForeColor = Color.Orange
        End Select


        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBarra.Text) = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBarra.Text & "/Novo.png") = True Then
                MDIComanda.btnAbrirComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBarra.Text & "\Novo.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBarra.Text & "/Comanda.png") = True Then
                MDIComanda.btnComandaPrincipal.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBarra.Text & "\Comanda.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBarra.Text & "/Voltar.png") = True Then
                MDIComanda.btnVoltar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBarra.Text & "\Voltar.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBarra.Text & "/Teclado.png") = True Then
                MDIComanda.btnTeclado.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBarra.Text & "\Teclado.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBarra.Text & "/Fechar.png") = True Then
                MDIComanda.SimpleButton1.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBarra.Text & "\Fechar.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBarra.Text & "/Config.png") = True Then
                MDIComanda.btnConfigComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBarra.Text & "\Config.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBarra.Text & "/Consultar.png") = True Then
                MDIComanda.btnConsultar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBarra.Text & "\Consultar.png")
            End If

            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Reabrir.png") = True Then
                MDIComanda.btnReabrirComanda.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Reabrir.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBarra & "/Finalizar.png") = True Then
                MDIComanda.btnVender.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBarra & "\Finalizar.png")
            End If
        End If
    End Sub

    Private Sub cboImagemBotao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboImagemBotao.SelectedIndexChanged
        Select Case cboImagemBotao.Text
            Case "Preto"
                Me.cboImagemBotao.Properties.Appearance.BackColor = Color.Black
                Me.cboImagemBotao.Properties.Appearance.ForeColor = Color.Black
            Case "Branco"
                Me.cboImagemBotao.Properties.Appearance.BackColor = Color.White
                Me.cboImagemBotao.Properties.Appearance.ForeColor = Color.White
            Case Else
                Me.cboImagemBotao.Properties.Appearance.BackColor = Color.Orange
                Me.cboImagemBotao.Properties.Appearance.ForeColor = Color.Orange
        End Select

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBotao.Text) = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBotao.Text & "/Padrao.png") = True Then
                Me.btnPadrao.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBotao.Text & "\Padrao.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBotao.Text & "\Ok.png") = True Then
                Me.btnSalvar.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBotao.Text & "\Ok.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBotao.Text & "/Menos.png") = True Then
                Me.btnMenos.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBotao.Text & "\Menos.png")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & cboImagemBotao.Text & "/Mais.png") = True Then
                Me.btnMais.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & cboImagemBotao.Text & "\Mais.png")
            End If
        End If
    End Sub
End Class