Imports Nano.clsFuncoes
Imports System
Imports System.Drawing
Imports System.Data
Imports System.IO
Public Class frmPlanoFundo
    Dim ImagemAtual As Image

    Private Sub frmPlanoFundo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "70")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmPlanoFundo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        'TODO: This line of code loads data into the 'DsNanoCommerce.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.DsNanoCommerce.Usuario)
        
   
        Dim dtFundo As DataTable
        dtFundo = CarregarDataTable("SELECT FundoPadrao, Exibicao, PlanoFundo FROM Usuario where Login ='" & Login & "' and Senha ='" & Senha & "'")
        Dim strExibicao As String
        Dim bolPadrao As Boolean
        bolPadrao = dtFundo.Rows.Item(0).Item("FundoPadrao")
        strExibicao = dtFundo.Rows.Item(0).Item("Exibicao").ToString
        If bolPadrao = True Then
            rpgPadrao.SelectedIndex = 0

        Else
            Select Case strExibicao
                Case "0"
                    Me.cboExibicao.SelectedIndex = 0
                Case "1"
                    Me.cboExibicao.SelectedIndex = 1
                Case "2"
                    Me.cboExibicao.SelectedIndex = 2
            End Select

            If dtFundo.Rows.Item(0).Item("PlanoFundo") Is Nothing Then
                rpgPadrao.SelectedIndex = 0
                Padrao()
                Exit Sub
            Else
                Dim Imagem As Byte() = CType(dtFundo.Rows.Item(0).Item("PlanoFundo"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)

                Me.picFundo.Image = bitmap
            End If
            ImagemAtual = Me.picFundo.Image
            rpgPadrao.SelectedIndex = 1
        End If
        Padrao()
    End Sub
 
    Public Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        Dim dt As DataTable = CarregarDataTable("SELECT Login, Senha FROM  Usuario")
        Dim i, indice As Integer
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows.Item(i).Item("Login").ToString = Login Then
                If dt.Rows.Item(i).Item("Senha").ToString = Senha Then
                    indice = i
                End If
            End If
        Next
        If Me.chkPadrao.Checked = False Then
            If Me.picFundo.Image Is Nothing Then
                MsgBox("Escolha uma imagem ou selecione a padrão!", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim imagem As Byte() = converteimagem(Me.picFundo.Image)

            Me.DsNanoCommerce.Usuario.Rows.Item(indice).Item("PlanoFundo") = imagem
            Me.DsNanoCommerce.Usuario.Rows.Item(indice).Item("Exibicao") = Me.txtExib.Text
        End If

        Me.DsNanoCommerce.Usuario.Rows.Item(indice).Item("FundoPadrao") = Me.chkPadrao.Checked


        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.UsuarioTableAdapter.Update(Me.DsNanoCommerce.Usuario)

        MsgBox("Plano de fundo alterado com sucesso!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub txtImagem_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtImagem.ButtonClick
        ofdFundo.FileName = ""
        ofdFundo.ShowDialog()
        If ofdFundo.FileName <> "" Then
            Me.picFundo.ImageLocation = ofdFundo.FileName
            Me.txtImagem.Text = ofdFundo.FileName
            Padrao()
        End If
    End Sub


    Private Sub Padrao()

        Select Case rpgPadrao.SelectedIndex
            Case 0
                Me.cboExibicao.SelectedIndex = 0
                Me.txtImagem.Enabled = False
                Me.PanelControl2.Enabled = False
                Me.chkPadrao.Checked = True

                Me.picPadrao.Visible = True
                Me.pnlLadoLado.Visible = False
                Me.pnlPrincipal.Visible = False
           
            Case 1
                Me.txtImagem.Enabled = True
                If Me.txtImagem.Text <> "" Then
                    Me.picFundo.ImageLocation = Me.txtImagem.Text
                    Me.PictureBox1.ImageLocation = Me.txtImagem.Text
                    Me.PictureBox2.ImageLocation = Me.txtImagem.Text
                    Me.PictureBox3.ImageLocation = Me.txtImagem.Text
                    Me.PictureBox4.ImageLocation = Me.txtImagem.Text
                    Me.PictureBox5.ImageLocation = Me.txtImagem.Text
                    Me.PictureBox6.ImageLocation = Me.txtImagem.Text
                Else
                    Me.picFundo.Image = ImagemAtual
                    Me.PictureBox1.Image = ImagemAtual
                    Me.PictureBox2.Image = ImagemAtual
                    Me.PictureBox3.Image = ImagemAtual
                    Me.PictureBox4.Image = ImagemAtual
                    Me.PictureBox5.Image = ImagemAtual
                    Me.PictureBox6.Image = ImagemAtual
                End If
                Me.picPadrao.Visible = False
                Me.pnlLadoLado.Visible = False
                Me.pnlPrincipal.Visible = True
                Me.cboExibicao.SelectedIndex = 1
                Me.PanelControl2.Enabled = True
                Me.chkPadrao.Checked = False
        End Select
    End Sub
    Private Sub rpgPadrao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpgPadrao.SelectedIndexChanged
        Padrao()
    End Sub

    Private Sub cboExibicao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboExibicao.SelectedIndexChanged
        Select Case cboExibicao.SelectedIndex
            Case 0
                Me.picFundo.Dock = DockStyle.None
                Me.pnlLadoLado.Visible = False
                Me.pnlPrincipal.Visible = True
                Me.txtExib.Text = "0"
            Case 1
                Me.picFundo.Dock = DockStyle.Fill
                Me.pnlLadoLado.Visible = False
                Me.pnlPrincipal.Visible = True
                Me.txtExib.Text = "1"
            Case 2
                Me.pnlLadoLado.Visible = True
                Me.pnlPrincipal.Visible = False
                Me.txtExib.Text = "2"
        End Select
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

 
End Class