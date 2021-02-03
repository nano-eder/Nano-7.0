Imports Nano.clsFuncoes
Public Class frmAbrirComanda
    Dim frm As New Form1
    Dim intA As Integer
    Dim intL As Integer
    Dim intL1 As Integer
    Dim intL2 As Integer

    Private Sub frmAbrirComanda_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Form1.Close()
        'FecharTeclado()
        FecharTecladoArquivo(False)
    End Sub

    Private Sub frmAbrirComanda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao) = True Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/" & CorImagemBotao & "/Abrir.png") = True Then
                Me.btnAbrir.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\ImagensComanda\" & CorImagemBotao & "\Abrir.png")
            End If
        End If

        FormAberto = Me.Name
        Me.txtCliente.Properties.Buttons(0).Appearance.BackColor = CorBotoes
        Me.BackColor = CorFundo
        Me.PictureEdit1.BackColor = CorFundo
        Me.LabelControl4.BackColor = CorFundo
        Me.LabelControl5.BackColor = CorFundo
        Me.LabelControl6.BackColor = CorFundo

        Me.btnAbrir.Appearance.BackColor = CorBotoes
        'IniciaThreadTeclado()

        AbrirTecladoArquivo(True)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'intA = Me.PanelControl1.Size.Height
        'intL = Me.PanelControl1.Size.Width
        'intL1 = Me.PanelControl1.Location.Y
        'intL2 = Me.PanelControl1.Location.X
        Dim t As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim f As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Timer1.Stop()
    End Sub

 
    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
        'inserir("INSERT INTO Comanda (C
        If Me.txtComanda.Text = "" Then
            'FecharTeclado()

            FecharTecladoArquivo(False)
            'MsgBox("Campo comanda ou mesa não pode ser vazio!", MsgBoxStyle.Information)
            frmComandaMensagem.Tag = ""
            frmComandaMensagem.lblMensagem.Text = "Campo comanda não pode ser vazio!"
            frmComandaMensagem.btnSim.Visible = False
            frmComandaMensagem.btnNao.Text = "Ok"
            frmComandaMensagem.Size = New System.Drawing.Size(649, 210)
            frmComandaMensagem.btnNao.Location = New System.Drawing.Point(210, 107)
            frmComandaMensagem.ShowDialog()

            'IniciaThreadTeclado()
            AbrirTecladoArquivo(True)

            Me.txtComanda.Focus()
            Exit Sub
        End If

       
       
        Dim intCodOrdens As Integer = GerarCodigo("Ordens", "Cod", CodConfig)
        Inserir("INSERT INTO Ordens(Cod, Tabela, CodConfig) VALUES (" & intCodOrdens & ",'Comanda'," & CodConfig & ")")

        If Me.txtMesa.Text = "" Then
            Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, Data, Status, CodConfig, Nome, Produto) VALUES (" & intCodOrdens & "," & _
                "'" & Me.txtComanda.Text.Trim & "','" & My.Computer.Clock.LocalTime & "'," & _
                "'" & "Aberto" & "'," & CodConfig & ",'" & Me.txtCliente.Text.Trim & "','INSERIR')")

        Else
            Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, Data, Status, CodConfig, Nome, Mesa, Produto) VALUES (" & intCodOrdens & "," & _
                "'" & Me.txtComanda.Text.Trim & "','" & My.Computer.Clock.LocalTime & "'," & _
                "'" & "Aberto" & "'," & CodConfig & ",'" & Me.txtCliente.Text.Trim & "','" & Me.txtMesa.Text & "','INSERIR')")

        End If
    
        'strForm = "frmComandaSetor"
        'FecharTeclado()

        FecharTecladoArquivo(False)
        Me.Close()
        frmComandaPrincipal.Close()
        frmComandaSetor.MdiParent = MDIComanda
        frmComandaSetor.strCodComanda = intCodOrdens
  
        frmComandaSetor.Show()
        frmComandaSetor.Dock = DockStyle.Fill

    End Sub

    Private Sub txtComanda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComanda.KeyPress, txtMesa.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    'Private Sub ColorEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorEdit1.EditValueChanged
    '    Me.BackColor = Me.ColorEdit1.EditValue
    '    CorTela = Me.ColorEdit1.EditValue
    'End Sub

    Private Sub txtComanda_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComanda.Leave
        If Me.txtComanda.Text = "" Then Exit Sub
        Dim intComanda As Integer = Me.txtComanda.Text
        Me.txtComanda.Text = intComanda
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Comanda where CodComanda = " & intComanda & " and Status <> 'Faturado' and CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then
            'FecharTeclado()
            FecharTecladoArquivo(False)
            RetornoMensagemComanda = False
            frmComandaMensagem.Tag = ""
            frmComandaMensagem.lblMensagem.Text = "Comanda já aberta!"
            frmComandaMensagem.btnSim.Visible = False
            frmComandaMensagem.btnNao.Text = "Ok"
            frmComandaMensagem.Size = New System.Drawing.Size(353, 210)
            frmComandaMensagem.btnNao.Location = New System.Drawing.Point(81, 107)
            frmComandaMensagem.ShowDialog()
            'IniciaThreadTeclado()
            AbrirTecladoArquivo(True)

            Me.txtComanda.ResetText()
            Me.txtComanda.Focus()
        End If
    End Sub

    Private Sub txtCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCliente.ButtonClick
        'FecharTeclado()
        FecharTecladoArquivo(False)
        Me.Close()
        frmCadCliente.strComanda = Me.txtComanda.Text
        frmCadCliente.strMesa = Me.txtMesa.Text
        frmCadCliente.MdiParent = MDIComanda
        frmCadCliente.ControlBox = False
        frmCadCliente.Tag = "PESQUISACOMANDA"
        frmCadCliente.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        frmCadCliente.Dock = DockStyle.Fill
        frmCadCliente.Show()
    End Sub
End Class