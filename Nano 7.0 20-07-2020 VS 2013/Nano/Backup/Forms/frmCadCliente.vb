Imports Nano.clsFuncoes
Imports Nano.clsValidar
Imports Nano.clsGerarArqs
Imports Nano.clsGerarArqsNfe
Imports System.Drawing
Imports System.Data
Imports System.IO
Public Class frmCadCliente
    Dim bolAlterado As Boolean = False
    Dim intCodCli As Integer
    Dim I As Integer
    Dim strCPF, strCpfCnpj As String
    Dim IndexRow As Integer
    Dim vet As Array
    Dim bolValida As Boolean = False
    Dim strNome As String
    Dim IndexReceber As Integer
    Dim dblCreditoCliente As Double

    Dim strPlaca As String
    Dim bolAlteradoCarro As Boolean = False
    Dim intCodConfig As Integer

    Public strComanda As String
    Public strMesa As String

    Private Sub frmCadCliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.grd1.ClearColumnsFilter()
    End Sub
    Private Sub frmCadCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "4")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCadCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormAberto = "frmCadCliente"

        'Me.nbcImagem.Size = New System.Drawing.Size(37, 247)
        Me.nbcImagem.Size = New System.Drawing.Size(37, 276)
        Me.nbcImagem.Location = New System.Drawing.Point(952, 0)
        If TesteConexao() = False Then Exit Sub

        If Me.Tag = Nothing Then
            Me.Tag = "CADASTRO"
        End If
        If Me.Tag = "Email" Then
            Me.btnEmail.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            Me.btnEmail.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        AtualizarGrid()
        rdgDoc.SelectedIndex = 0

        Me.tabNFE.PageVisible = EmiteNFE

        bolValida = True
        Dim dtConfig As DataTable = CarregarDataTable("SELECT Credito FROM Config where Codigo = " & CodConfig)
        If dtConfig.Rows.Count > 0 Then
            If dtConfig.Rows.Item(0).Item("Credito").ToString <> "" Then
                dblCreditoCliente = dtConfig.Rows.Item(0).Item("Credito").ToString
            Else
                dblCreditoCliente = 0
            End If

        End If

        Me.txtLimite.Text = dblCreditoCliente.ToString("0.00")

        If Master = True Then
            Me.txtLimite.Enabled = True
        Else
            Me.txtLimite.Enabled = False
        End If


        If PreencherCombo("Pais", Me.cboPais, 1, "Nome") = False Then
            Exit Sub
        End If

        CarregarComboCidade(Me.ComboBoxEdit2.Text, Me.ComboBoxEdit1)
        CarregarComboCidade(Me.cboUF.Text, Me.cboCidade)
        CarregarDadosLue("Select Codigo as Cod, Nome from Funcionario where Ativo = 'True' and codconfig = " & CodConfig, Me.lueCodFunc)

        If Me.Tag = "Receber" Or Me.Tag = "VEICULO" Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colCodigo
            grd1.SetRowCellValue(index, Me.colCodigo, CodigoDoCliente)
            grd1.ShowEditor()
            Alterar()
        End If

        Timer1.Start()

        Me.cboUF.Text = UFEmpresa
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        If TipoNano = 5 Then
            Me.tabVeiculo.PageVisible = True

            'CARREGAR DADOS CARRO
            CarregarDadosLue2("SELECT * FROM Config", Me.lueLoja)
            AtualizarGridCarro()

            
        End If


        Me.txtBairro.Properties.Items.Clear()
        PreencherGrupoSetorCusto("B", Me.txtBairro)

        Me.NanoCampo1.Properties.Items.Clear()
        PreencherGrupoSetorCusto("B", Me.NanoCampo1)

    End Sub
    Private Sub AtualizarGridCarro()
        CarregarDados("SELECT Carro.Codigo as CodigoCarro, Placa, Modelo, Cor, Ano, KM, Carro.Data, " & _
                   "Cliente.CPF as CPFCliente, Cliente.Nome as NomeCliente, Fabricante, " & _
                   "Combustivel, Motor, Cilindros, Valvulas, Chassi, Carro.Obs, Opcionais, KMMes, " & _
                   "Carro.CodConfig, CodCli FROM Carro left join Cliente on Carro.CodCli = Cliente.Codigo", Me.CarroGridControl)
    End Sub
    Private Sub AtualizarGrid()
        CarregarDados("SELECT *, case when Nome like '%PROTESTADO%' then 'PROTESTADO' else '' end as Protestado FROM Cliente", Me.ClienteGridControl)
        If Nivel = "USUÁRIO" Then
            Me.txtLimCli.Properties.ReadOnly = True
        End If
        txtQtdCli.Text = grd1.RowCount
    End Sub
    Private Sub CarregarComboCidade(ByVal parUF As String, ByVal parCidade As Object)
        Dim dt As DataTable
        Dim I As Integer
        dt = CarregarDataTable("SELECT Nome FROM Cidade where UF = '" & parUF & "'")
        For I = 0 To dt.Rows.Count - 1
            parCidade.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
        Next
    End Sub
    'Private Sub CarregarComboCidade(ByVal parUF As Object, ByVal parCidade As Object)
    '    Dim dt As DataTable
    '    Dim I As Integer
    '    dt = CarregarDataTable("SELECT Nome FROM Cidade where UF = '" & parUF.Text & "'")
    '    For I = 0 To dt.Rows.Count - 1
    '        parCidade.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
    '    Next
    'End Sub
    Private Sub Limpar(ByVal parSoCarro As Boolean)
        intCodCli = 0
        Me.txtCli.Enabled = True
        bolAlterarClienteVeiculo = False
        Me.grd1.ClearColumnsFilter()
        Me.GridView1.ClearColumnsFilter()
        If Master = True Then
            Me.txtLimite.Enabled = True
        Else
            Me.txtLimite.Enabled = False
        End If
        Me.txtContato.ResetText()
        Me.picImagem.Image = Nothing
        Me.txtNome.ResetText()
        Me.txtRGIE.ResetText()
        Me.txtCPF.ResetText()
        Me.txtEnd.ResetText()
        Me.txtTel1.ResetText()
        Me.txtdtCad.ResetText()
        Me.txtUltVis.ResetText()
        Me.txtTel2.ResetText()
        Me.txtTel3.ResetText()
        Me.txtWeb.ResetText()
        Me.txtFant.ResetText()
        Me.txtNum.ResetText()
        Me.txtComp.ResetText()
        Me.txtBairro.ResetText()
        Me.txtCep.ResetText()
        Me.cboUF.Text = UFEmpresa
        CarregarComboCidade(Me.cboUF.Text, Me.cboCidade)
        Me.cboCidade.SelectedIndex = -1
        Me.cboCidade.ResetText()
        strCPF = ""
        Me.chkIna.Checked = False
        Me.chkInativar.Checked = False
        Me.chkInativar.Properties.ReadOnly = False
        Me.txtObs.ResetText()
        bolAlterado = False
        Me.rdgDoc.SelectedIndex = 0
        Me.dtNasc.ResetText()
        Me.cboSexo.SelectedIndex = -1
        Me.cboStatus.Text = "3"
        Me.txtLimite.ResetText()
        Me.txtSal.ResetText()
        Me.txtEmp.ResetText()
        Me.txtTelEmp.ResetText()
        If parSoCarro = False Then
            Me.tbbCli.SelectedTabPageIndex = 0
            Me.tab.SelectedTabPage = Me.tabPri
        End If
        Me.lueCodFunc.EditValue = DBNull.Value
        CarregarDadosLue("Select Codigo as Cod, Nome from Funcionario where Ativo = 'True' and codconfig = " & CodConfig, Me.lueCodFunc)

        Me.chkCPF.Tag = ""
        Me.chkCPF.Checked = False
        Me.chkCPF.Visible = False
        Me.txtCPF.Enabled = True
        Me.lblCred.Visible = False
        Me.txtCredito.Visible = False
        Me.lblTotalGasto.Visible = False
        Me.txtTotalGasto.Visible = False
        Me.txtMarcas.ResetText()
        Me.txtPessoa1.ResetText()
        Me.txtPessoa2.ResetText()
        Me.txtRG1.ResetText()
        Me.txtRG2.ResetText()
        Me.txtTempTra.ResetText()
        Me.txtNomeConj.ResetText()
        Me.txtTelConj.ResetText()
        Me.cboMor.SelectedIndex = -1
        Me.txtLimCli.ResetText()
        Me.txtCredito.Text = "0,00"
        Me.txtNumCom.ResetText()
        Me.txtSalDev.ResetText()
        Me.txtCodMun.ResetText()
        Me.txtCodPais.ResetText()
        Me.cboPais.SelectedIndex = -1
        Me.txtSuframa.ResetText()
        Me.txtPerDesc.ResetText()
        Me.txtLimite.Text = dblCreditoCliente.ToString("0.00")
        txtNome.Focus()
        Me.chkIsento.BackColor = Color.White

        Me.txtAgencia.ResetText()
        Me.txtContaCorrente.ResetText()
        Me.txtBanco.ResetText()

        Me.NanoCampo5.ResetText()
        Me.NanoCampo3.ResetText()
        Me.NanoCampo2.ResetText()
        Me.NanoCampo1.ResetText()
        Me.NanoCampo4.ResetText()
        Me.ComboBoxEdit1.ResetText()
        Me.ComboBoxEdit2.Text = UFEmpresa
        Me.XtraTabControl1.SelectedTabPageIndex = 0

        bolAlteradoCarro = False
        Me.txtAno.ResetText()
        Me.txtCor.ResetText()
        Me.txtKM.ResetText()
        Me.txtMod.ResetText()
        Me.txtPlaca.ResetText()
        Me.txtCli.ResetText()
        Me.cboComb.SelectedIndex = -1
        Me.cboFab.SelectedIndex = -1
        Me.txtMot.ResetText()
        Me.txtCil.ResetText()
        Me.txtVal.ResetText()
        Me.txtCha.ResetText()
        Me.txtObs.ResetText()
        Me.txtKMMes.ResetText()
        Me.lstItens.Items.Clear()
        Dim H As Integer
        For H = 0 To Me.lstOpc.ItemCount - 1
            Me.lstOpc.Items.Item(H).CheckState = CheckState.Unchecked
        Next
        Me.MemoEdit1.ResetText()
        Me.GroupControl1.Visible = True
        Me.tab.Dock = DockStyle.None


        Me.picImagem1.Image = Nothing
        Me.picImagem2.Image = Nothing
        Me.picImagem3.Image = Nothing
        Me.picImagem4.Image = Nothing
        Me.picImagem5.Image = Nothing
        Me.picImagem6.Image = Nothing
        Me.PictureEdit1.Image = Nothing


        Me.txtCli.Enabled = True
        Me.chkCli.BackColor = Color.White
        Me.chkCli.Visible = False


        Me.tab.SelectedTabPageIndex = 0
        Me.tab.Dock = DockStyle.Top
        Me.GroupControl7.Visible = True



        If parSoCarro = False Then
            Me.tbbCliente.SelectedTabPageIndex = 0
            Me.tbbCli.SelectedTabPageIndex = 0
            Me.txtNome.Focus()
        Else
            Me.txtPlaca.Focus()
        End If

        'Select Case Me.tbbCliente.SelectedTabPageIndex
        '    Case 0
        '        Me.tbbCli.SelectedTabPageIndex = 0
        '        Me.txtNome.Focus()
        '    Case 1
        '        Me.tab.SelectedTabPageIndex = 0
        '        Me.tab.Dock = DockStyle.Top
        '        Me.GroupControl7.Visible = True
        '        Me.txtPlaca.Focus()
        'End Select        
    End Sub

    Private Sub Alterar()
        bolAlterado = True

        Dim Index As Integer
        If Me.Tag = "Receber" Or Me.Tag = "VEICULO" Then
            Index = 0
            If Me.Tag = "Receber" Then
                Me.Tag = ""
            End If

        Else
            If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
            Index = grd1.FocusedRowHandle
            If bolAlterarClienteVeiculo = False Then
                Me.txtCli.Enabled = False
            End If
        End If

        IndexRow = Me.ClienteBindingSource.Position
        Me.tbbCli.SelectedTabPageIndex = 0
        Me.txtCPF.Enabled = False
        Me.chkCPF.BackColor = Color.Transparent
        Me.chkIsento.Checked = False
        With grd1
            intCodCli = .GetRowCellValue(Index, Me.colCodigo)
            strNome = .GetRowCellDisplayText(Index, Me.colNome)
            'Me.txtCli.Text = strNome
            Select Case Me.chkCli.Checked
                Case True
                    Me.txtCli.Text = strNome
                Case False
                    'Me.txtCli.Text = strNome
            End Select

            Me.txtNome.Text = .GetRowCellDisplayText(index, Me.colNome)
            Me.cboUF.Text = .GetRowCellDisplayText(index, Me.colEstado)
            Me.txtRGIE.Text = .GetRowCellDisplayText(index, Me.colRGIE)
            If .GetRowCellDisplayText(index, Me.colRGIE) = "ISENTO" Then
                Me.chkIsento.Checked = True
            Else
                Me.txtRGIE.Text = .GetRowCellDisplayText(index, Me.colRGIE)
            End If
            If .GetRowCellDisplayText(index, Me.colCPF).Length <= 14 Then
                Me.rdgDoc.SelectedIndex = 0
            Else
                Me.rdgDoc.SelectedIndex = 1
            End If

            Me.txtCPF.Text = .GetRowCellDisplayText(index, Me.colCPF)
            strCPF = .GetRowCellDisplayText(index, Me.colCPF)
            Me.chkCPF.Visible = True
            Me.chkCPF.Tag = strCPF
            Me.txtEnd.Text = .GetRowCellDisplayText(index, Me.colEndereco)
            Me.txtTel1.Text = .GetRowCellDisplayText(index, Me.colTelefone)
            Me.txtTel2.Text = .GetRowCellDisplayText(index, Me.colFax)
            Me.txtTel3.Text = .GetRowCellDisplayText(index, Me.colCelular)
            Me.txtWeb.Text = .GetRowCellDisplayText(index, Me.colEmail)
            Me.txtFant.Text = .GetRowCellDisplayText(index, Me.colFantasia)
            Me.txtNum.Text = .GetRowCellDisplayText(index, Me.colNumero)
            Me.txtComp.Text = .GetRowCellDisplayText(index, Me.colComplemento)
            Me.txtBairro.Text = .GetRowCellDisplayText(index, Me.colBairro)
            Me.txtCep.Text = .GetRowCellDisplayText(index, Me.colCep)
            Me.cboCidade.Text = .GetRowCellDisplayText(index, Me.colCidade)
            Me.txtCredito.Text = .GetRowCellDisplayText(index, Me.colCredito)
            Me.chkIna.Checked = .GetRowCellValue(index, Me.colInadimplente)
            Me.txtObs.Text = .GetRowCellDisplayText(index, Me.colObservacao)
            Me.dtNasc.EditValue = .GetRowCellDisplayText(index, Me.colNascimento)
            Me.cboSexo.Text = .GetRowCellDisplayText(index, Me.colSexo)
            Me.cboStatus.Text = .GetRowCellDisplayText(index, Me.colStatus)
            Me.txtLimite.Text = .GetRowCellDisplayText(index, Me.colLimite)
            Me.txtdtCad.Text = .GetRowCellDisplayText(index, Me.colData)
            Me.txtCli.Text = Me.txtNome.Text
            If .GetRowCellValue(index, Me.colInativo) = False Then
                Me.chkInativar.Properties.ReadOnly = False
            End If

            Me.chkInativar.Checked = .GetRowCellValue(index, Me.colInativo)

            Me.txtEmp.Text = .GetRowCellDisplayText(index, Me.colEmpresa)
            Me.txtTelEmp.Text = .GetRowCellDisplayText(index, Me.colTelEmpresa)
            Me.txtSal.Text = .GetRowCellDisplayText(index, Me.colSalario)
            Me.txtMarcas.Text = .GetRowCellDisplayText(index, Me.colMarcas)

            Me.txtPessoa1.Text = .GetRowCellDisplayText(index, Me.colPessoa1)
            Me.txtPessoa2.Text = .GetRowCellDisplayText(index, Me.colPessoa2)
            Me.txtRG1.Text = .GetRowCellDisplayText(index, Me.colRG1)
            Me.txtRG2.Text = .GetRowCellDisplayText(index, Me.colRG2)
            Me.txtTempTra.Text = .GetRowCellDisplayText(index, Me.colTempoTrabalho)
            Me.cboMor.Text = .GetRowCellDisplayText(index, Me.colMoradia)
            Me.txtNomeConj.Text = .GetRowCellDisplayText(index, Me.colNomeConjuge)
            Me.txtTelConj.Text = .GetRowCellDisplayText(index, Me.colTelConjuge)

            Me.txtCodPais.Text = .GetRowCellDisplayText(index, Me.colCodPais)
            Me.cboPais.Text = .GetRowCellDisplayText(index, Me.colNomePais)
            Me.txtSuframa.Text = .GetRowCellDisplayText(index, Me.colSuframa)

            Me.txtPerDesc.Text = .GetRowCellDisplayText(index, Me.colDesconto)

            Me.txtAgencia.Text = .GetRowCellDisplayText(index, Me.colAgencia)
            Me.txtContaCorrente.Text = .GetRowCellDisplayText(index, Me.colContaCorrente)
            Me.txtBanco.Text = .GetRowCellDisplayText(Index, Me.colBanco)


            Me.NanoCampo5.Text = .GetRowCellDisplayText(Index, Me.colEnderecoEntrega)
            Me.NanoCampo3.Text = .GetRowCellDisplayText(Index, Me.colNumeroEntrega)
            Me.NanoCampo2.Text = .GetRowCellDisplayText(Index, Me.colComplementoEntrega)
            Me.NanoCampo1.Text = .GetRowCellDisplayText(Index, Me.colBairroEntrega)
            Me.NanoCampo4.Text = .GetRowCellDisplayText(Index, Me.colCepEntrega)
            Me.ComboBoxEdit1.Text = .GetRowCellDisplayText(Index, Me.colCidadeEntrega)
            Me.ComboBoxEdit2.Text = .GetRowCellDisplayText(Index, Me.colEstadoEntrega)


            If .GetRowCellDisplayText(Index, Me.colCodFunc).ToString <> "" And .GetRowCellDisplayText(Index, Me.colCodFunc).ToString <> "0" Then
                Me.lueCodFunc.Text = .GetRowCellDisplayText(Index, Me.colCodFunc)
                Me.lueCodFunc.ClosePopup()
            Else
                Me.lueCodFunc.EditValue = DBNull.Value
                CarregarDadosLue("Select Codigo as Cod, Nome from Funcionario where Ativo = 'True' and codconfig = " & CodConfig, Me.lueCodFunc)
            End If

            Me.txtContato.Text = .GetRowCellDisplayText(Index, Me.colContato)
            Dim dblGasto As Double
            Dim dtTotal As DataTable
            dtTotal = CarregarDataTable("Select sum(Total)as Total from Total where CodCli =" & intCodCli)
            If dtTotal.Rows.Count > 0 Then
                If dtTotal.Rows.Item(0).Item("Total").ToString = "" Then
                    dblGasto = "0,00"
                Else
                    dblGasto = dtTotal.Rows.Item(0).Item("Total").ToString
                End If

                Me.txtTotalGasto.Text = dblGasto.ToString("0.00")
            End If

            dtTotal = CarregarDataTable("Select CodOrdem from Total where CodCli  =" & intCodCli)

            Me.txtNumCom.Text = dtTotal.Rows.Count

            dtTotal = CarregarDataTable("Select Sum(ValorParcela) as Valor from ContaReceber where CodCli  =" & intCodCli & " and RecebidoOK ='False'")

            If dtTotal.Rows.Count > 0 Then
                If dtTotal.Rows.Item(0).Item("Valor").ToString = "" Then
                    dblGasto = "0,00"
                Else
                    dblGasto = dtTotal.Rows.Item(0).Item("Valor").ToString
                End If
            Else
                dblGasto = "0,00"
            End If

            Me.txtSalDev.Text = dblGasto.ToString("0.00")


            dtTotal = CarregarDataTable("Select datediff(day,min(Vencimento),getdate()) as Vencimento from ContaReceber where CodCli  =" & intCodCli & " and RecebidoOK ='False'")
            If dtTotal.Rows.Count > 0 Then
                If dtTotal.Rows.Item(0).Item("Vencimento").ToString <> "" Then
                    Dim intDia As Integer = dtTotal.Rows.Item(0).Item("Vencimento").ToString
                    If intDia > 0 Then
                        Me.txtDiasEmAtraso.Text = dtTotal.Rows.Item(0).Item("Vencimento").ToString
                    Else
                        Me.txtDiasEmAtraso.Text = "0"
                    End If

                Else
                    Me.txtDiasEmAtraso.Text = "0"
                End If
            End If


            If Me.txtLimite.Text.Trim <> "" Then
                Me.txtLimCli.Text = (CDbl(Me.txtLimite.Text) + CDbl(Me.txtSalDev.Text)).ToString("0.00")
            End If

            Me.lblTotalGasto.Visible = True
            Me.txtTotalGasto.Visible = True

            Dim dt As DataTable = CarregarDataTable("Select Top 1 Data from Total where CodCli =" & intCodCli & " order by Data desc")
            If dt.Rows.Count > 0 Then
                Dim vet As Array = Split(dt.Rows.Item(0).ItemArray(0).ToString, " ")
                Me.txtUltVis.Text = vet(0)
            Else
                Me.txtUltVis.ResetText()
            End If

            CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)

            Me.txtCredito.Visible = True
            Me.lblCred.Visible = True

            CarregarImagem(intCodCli)

            Dim imgImagem As New PictureBox

            imgImagem.Size = New System.Drawing.Size(300, 50)

            Dim Barcode As New BarcodeLib.Barcode(intCodCli, BarcodeLib.TYPE.CODE128)
            imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, intCodCli, 120, 19)
            imgImagem.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone)

            Me.picCod.Image = imgImagem.Image


            Me.txtNome.Focus()
        End With
    End Sub
    Private Sub CarregarImagem(ByVal parCodigo As String)
        Dim dt As DataTable = CarregarDataTable("SELECT Imagem FROM Cliente where Codigo = " & parCodigo)
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

    Private Sub FiltroCarro()
        If Me.txtNome.Text <> "" Then
            If bolAlterado = False Then
                Me.txtCli.Text = Me.txtNome.Text
            End If
            Dim indexCarro As Integer = -999997
            Me.GridView1.FocusedRowHandle = indexCarro
            Me.GridView1.FocusedColumn = Me.colPlaca
            Me.GridView1.SetRowCellValue(indexCarro, Me.colNomeCliente, Me.txtNome.Text.Trim)
            'Me.GridView1.SetRowCellValue(indexCarro, Me.colCPFCliente, Me.txtCPF.Text.Trim)
            Me.GridView1.ShowEditor()
        Else

            Dim indexCarro As Integer = -999997
            Me.GridView1.FocusedRowHandle = indexCarro
            Me.GridView1.FocusedColumn = Me.colPlaca
            Me.GridView1.SetRowCellValue(indexCarro, Me.colNomeCliente, Nothing)
            'Me.GridView1.SetRowCellValue(indexCarro, Me.colCPFCliente, Nothing)
            Me.GridView1.ShowEditor()
        End If
    End Sub

    Private Sub AlterarCarro()
        If Me.GridView1.FocusedRowHandle < 0 Then Exit Sub
        bolAlteradoCarro = True

        Me.lstItens.Items.Clear()
        Dim H As Integer
        For H = 0 To Me.lstOpc.ItemCount - 1
            Me.lstOpc.Items.Item(H).CheckState = CheckState.Unchecked
        Next
        Me.tab.SelectedTabPage = Me.tabPri

        Dim Index As Integer = GridView1.FocusedRowHandle
        'Index2 = Me.CarroBindingSource.Position

        With GridView1
            If .GetRowCellDisplayText(Index, Me.colCodCli).ToString <> "" Then
                If bolAlterado = False Then
                    intCodCli = .GetRowCellDisplayText(Index, Me.colCodCli)
                    txtCli.Text = .GetRowCellDisplayText(Index, Me.colNomeCliente)
                    Me.txtNome.Text = .GetRowCellDisplayText(Index, Me.colNomeCliente)
                End If
            End If
            strPlaca = .GetRowCellDisplayText(Index, Me.colPlaca)
            txtPlaca.Text = .GetRowCellDisplayText(Index, Me.colPlaca)
            txtMod.Text = .GetRowCellDisplayText(Index, Me.colModelo)
            txtCor.Text = .GetRowCellDisplayText(Index, Me.colCor)
            txtAno.Text = .GetRowCellDisplayText(Index, Me.colAno)
            txtKM.Text = .GetRowCellDisplayText(Index, Me.colKM)

            'txtCli.Tag = .GetRowCellDisplayText(Index, Me.colCPFCliente)
            Me.cboFab.Text = .GetRowCellDisplayText(Index, Me.colFabricante)
            Me.cboComb.Text = .GetRowCellDisplayText(Index, Me.colCombustivel)
            Me.txtMot.Text = .GetRowCellDisplayText(Index, Me.colMotor)
            Me.txtCil.Text = .GetRowCellDisplayText(Index, Me.colCilindros)
            Me.txtVal.Text = .GetRowCellDisplayText(Index, Me.colValvulas)
            Me.txtCha.Text = .GetRowCellDisplayText(Index, Me.colChassi)
            Me.txtObs.Text = .GetRowCellDisplayText(Index, Me.colObs)
            Me.txtKMMes.Text = .GetRowCellDisplayText(Index, Me.colKMMes)
            Dim vetOpc As Array = Split(.GetRowCellDisplayText(Index, Me.colOpcionais), "|")
            intCodConfig = .GetRowCellDisplayText(Index, Me.colCodConfig)
            Dim L As Integer
            For L = 0 To vetOpc.Length - 1
                Me.lstItens.Items.Add(vetOpc(L))
            Next

            'Me.txtCli.Enabled = False
            'Me.chkCli.BackColor = Color.Transparent
            'Me.chkCli.Visible = True

            CarregarImagemsCarro(strPlaca)
        End With

    End Sub

    Private Sub SalvarImagemCarro(ByVal parCodigo As String)

        If Me.picImagem1.Image Is Nothing = False Then
            Dim strImagem1 As Byte() = converteimagem(Me.picImagem1.Image)
            InserirImagem("UPDATE Carro set Imagem1 = @Img where Placa = '" & parCodigo & "'", strImagem1)
        Else
            Atualizar("UPDATE Carro set Imagem1 = null where Placa = '" & parCodigo & "'")
        End If

        If Me.picImagem2.Image Is Nothing = False Then
            Dim strImagem1 As Byte() = converteimagem(Me.picImagem2.Image)
            InserirImagem("UPDATE Carro set Imagem2 = @Img where Placa = '" & parCodigo & "'", strImagem1)
        Else
            Atualizar("UPDATE Carro set Imagem2 = null where Placa = '" & parCodigo & "'")
        End If

        If Me.picImagem3.Image Is Nothing = False Then
            Dim strImagem1 As Byte() = converteimagem(Me.picImagem3.Image)
            InserirImagem("UPDATE Carro set Imagem3 = @Img where Placa = '" & parCodigo & "'", strImagem1)
        Else
            Atualizar("UPDATE Carro set Imagem3 = null where Placa = '" & parCodigo & "'")
        End If

        If Me.picImagem4.Image Is Nothing = False Then
            Dim strImagem1 As Byte() = converteimagem(Me.picImagem4.Image)
            InserirImagem("UPDATE Carro set Imagem4 = @Img where Placa = '" & parCodigo & "'", strImagem1)
        Else
            Atualizar("UPDATE Carro set Imagem4 = null where Placa = '" & parCodigo & "'")
        End If

        If Me.picImagem5.Image Is Nothing = False Then
            Dim strImagem1 As Byte() = converteimagem(Me.picImagem5.Image)
            InserirImagem("UPDATE Carro set Imagem5 = @Img where Placa = '" & parCodigo & "'", strImagem1)
        Else
            Atualizar("UPDATE Carro set Imagem5 = null where Placa = '" & parCodigo & "'")
        End If

        If Me.picImagem6.Image Is Nothing = False Then
            Dim strImagem1 As Byte() = converteimagem(Me.picImagem6.Image)
            InserirImagem("UPDATE Carro set Imagem6 = @Img where Placa = '" & parCodigo & "'", strImagem1)
        Else
            Atualizar("UPDATE Carro set Imagem6 = null where Placa = '" & parCodigo & "'")
        End If
    End Sub

    Private Sub CarregarImagemsCarro(ByVal parPlaca As String)
        If parPlaca = "" Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("SELECT Imagem1, Imagem2, Imagem3, Imagem4, Imagem5, Imagem6 FROM Carro where Placa = '" & parPlaca & "'")

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Imagem1").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem1"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)
                Me.picImagem1.Image = bitmap
            Else
                Me.picImagem1.Image = Nothing
            End If

            If dt.Rows.Item(0).Item("Imagem2").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem2"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)
                Me.picImagem2.Image = bitmap
            Else
                Me.picImagem2.Image = Nothing
            End If

            If dt.Rows.Item(0).Item("Imagem3").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem3"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)
                Me.picImagem3.Image = bitmap
            Else
                Me.picImagem3.Image = Nothing
            End If

            If dt.Rows.Item(0).Item("Imagem4").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem4"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)
                Me.picImagem4.Image = bitmap
            Else
                Me.picImagem4.Image = Nothing
            End If

            If dt.Rows.Item(0).Item("Imagem5").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem5"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)
                Me.picImagem5.Image = bitmap
            Else
                Me.picImagem5.Image = Nothing
            End If

            If dt.Rows.Item(0).Item("Imagem6").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem6"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)
                Me.picImagem6.Image = bitmap
            Else
                Me.picImagem6.Image = Nothing
            End If

        Else
            Me.picImagem1.Image = Nothing
            Me.picImagem2.Image = Nothing
            Me.picImagem3.Image = Nothing
            Me.picImagem4.Image = Nothing
            Me.picImagem5.Image = Nothing
            Me.picImagem6.Image = Nothing
        End If

    End Sub

    Private Sub SalvarCarro(ByVal parCodCli As Integer)
        If TesteConexao() = False Then Exit Sub
        If Validar(txtPlaca) = False Then Exit Sub
        If Validar(Me.txtMod) = False Then Exit Sub


        Dim strOpc As String = ""
        Dim J As Integer

        For J = 0 To Me.lstItens.ItemCount - 1
            strOpc &= Me.lstItens.Items.Item(J) & "|"
        Next

        If bolAlteradoCarro = False Then
            If Validar(Me.txtCli) = False Then Exit Sub
            Dim strInsert As String

            strInsert = "INSERT INTO Carro (Placa, Modelo, Cor, Ano, KM, Data, Fabricante, Combustivel, Motor, Cilindros, " & _
            "Valvulas, Chassi, Obs, Opcionais, KMMes, CodConfig, CodCli) values('" & Me.txtPlaca.Text.Trim & "','" _
            & Me.txtMod.Text.Trim.Replace("'", "") & "','" & Me.txtCor.Text.Trim.Replace("'", "") & "'," & _
            "'" & Me.txtAno.Text.Trim.Replace("'", "") & "','" & Me.txtKM.Text.Trim.Replace("'", "") & "'," & _
            "'" & Date.Today & "','" & Me.cboFab.Text.Trim.Replace("'", "") & "','" & Me.cboComb.Text.Trim.Replace("'", "") & "'," & _
            "'" & Me.txtMot.Text.Trim.Replace("'", "") & "','" & Me.txtCil.Text.Trim.Replace("'", "") & "'," & _
            "'" & Me.txtVal.Text.Trim.Replace("'", "") & "','" & Me.txtCha.Text.Trim.Replace("'", "") & "'," & _
            "'" & Me.MemoEdit1.Text.Trim.Replace("'", "") & "','" & strOpc & "','" & Me.txtKMMes.Text.Trim.Replace("'", "") & "'," & _
            "" & CodConfig & "," & parCodCli & ")"

            If Inserir(strInsert) = True Then
                SalvarImagemCarro(Me.txtPlaca.Text.Trim)
                MsgBox("Veículo " & txtPlaca.Text.Trim & " cadastrado com sucesso!", MsgBoxStyle.Information)

                If Me.Tag = "PEDIDO" Or Me.Tag = "VEICULO" Then
                    PlacaDoCarro = Me.txtPlaca.Text.Trim
                    Me.Close()
                End If

                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & " " & "','" & Me.txtPlaca.Text.Trim & "','PLACA','CARRO','CADASTRO'," & CodConfig & ")")
            Else
                MsgBox("Ocorreu algum erro ao tentar salvar os dados, tente novamente!", MsgBoxStyle.Information)
            End If

        Else

            Dim strUpdate As String

            'Select Case Me.chkCli.Checked
            '     Case True
            strUpdate = "Update Carro set Placa ='" & Me.txtPlaca.Text.Trim & "', Modelo ='" & Me.txtMod.Text.Trim.Replace("'", "") & "', " & _
            "Cor ='" & Me.txtCor.Text.Trim.Replace("'", "") & "', Ano ='" & Me.txtAno.Text.Trim.Replace("'", "") & "', " & _
            "KM ='" & Me.txtKM.Text.Trim.Replace("'", "") & "', Data ='" & Date.Today & "', " & _
            "Fabricante ='" & Me.cboFab.Text.Trim.Replace("'", "") & "', Combustivel ='" & Me.cboComb.Text.Trim.Replace("'", "") & "', " & _
            "Motor ='" & Me.txtMot.Text.Trim.Replace("'", "") & "', Cilindros = '" & Me.txtCil.Text.Trim.Replace("'", "") & "', " & _
            "Valvulas = '" & Me.txtVal.Text.Trim.Replace("'", "") & "', Chassi = '" & Me.txtCha.Text.Trim.Replace("'", "") & "', " & _
            "Obs = '" & Me.MemoEdit1.Text.Trim.Replace("'", "") & "', Opcionais = '" & strOpc & "', " & _
            "KMMes ='" & Me.txtKMMes.Text.Trim.Replace("'", "") & "', CodCli = " & parCodCli & " where Placa ='" & strPlaca & "' and CodConfig = " & intCodConfig
            '    Case False
            '        strUpdate = "Update Carro set Placa ='" & Me.txtPlaca.Text.Trim & "', Modelo ='" & Me.txtMod.Text.Trim.Replace("'", "") & "', " & _
            '        "Cor ='" & Me.txtCor.Text.Trim.Replace("'", "") & "', Ano ='" & Me.txtAno.Text.Trim.Replace("'", "") & "', " & _
            '        "KM ='" & Me.txtKM.Text.Trim.Replace("'", "") & "', Data ='" & Date.Today & "', " & _
            '        "Fabricante ='" & Me.cboFab.Text.Trim.Replace("'", "") & "', Combustivel ='" & Me.cboComb.Text.Trim.Replace("'", "") & "', " & _
            '        "Motor ='" & Me.txtMot.Text.Trim.Replace("'", "") & "', Cilindros = '" & Me.txtCil.Text.Trim.Replace("'", "") & "', " & _
            '        "Valvulas = '" & Me.txtVal.Text.Trim.Replace("'", "") & "', Chassi = '" & Me.txtCha.Text.Trim.Replace("'", "") & "', " & _
            '        "Obs = '" & Me.txtObs.Text.Trim.Replace("'", "") & "', Opcionais = '" & strOpc & "', " & _
            '        "KMMes ='" & Me.txtKMMes.Text.Trim.Replace("'", "") & "' where Placa ='" & strPlaca & "' and CodConfig = " & intCodConfig
            'End Select

            If Atualizar(strUpdate) = True Then
                SalvarImagemCarro(Me.txtPlaca.Text.Trim)
                MsgBox("Veículo " & txtPlaca.Text.Trim & " alterado com sucesso!", MsgBoxStyle.Information)
                If Me.Tag = "PEDIDO" Or Me.Tag = "VEICULO" Then
                    PlacaDoCarro = Me.txtPlaca.Text.Trim
                    Me.Close()
                End If
            End If

            If Me.txtPlaca.Text.Trim <> strPlaca Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strPlaca & "','" & Me.txtPlaca.Text.Trim & "','PLACA','CARRO','ALTERAÇÃO'," & CodConfig & ")")
                'Atualizar("UPDATE ItensConsig SET Placa = '" & Me.txtPlaca.Text.Trim & "' where Placa = '" & strPlaca & "' and CodConfig = " & intCodConfig)
                Atualizar("UPDATE TotalConsig SET Placa = '" & Me.txtPlaca.Text.Trim & "' where Placa = '" & strPlaca & "' and CodConfig = " & intCodConfig)
            End If

        End If

        CarregarDadosLue2("SELECT * FROM Config", Me.lueLoja)
        AtualizarGridCarro()
        'CarregarDados("SELECT Carro.Codigo as CodigoCarro, Placa, Modelo, Cor, Ano, KM, Carro.Data, CodCli, " & _
        '"Cliente.Nome as NomeCliente, Fabricante, Combustivel, Motor, Cilindros, Valvulas, Chassi, Carro.Obs, Opcionais, KMMes, " & _
        '"Carro.CodConfig, CodCli FROM Carro left Join Cliente on Carro.CodCli = Cliente.Codigo", Me.CarroGridControl)

    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Dim bolSoCarro As Boolean = True
        'If Validar(Me.txtNome) = False Then Exit Sub
        If Me.txtNome.Text <> "" Then
            If ValidarCPF = True Then
                If Validar(Me.txtCPF) = False Then Exit Sub


                If ValidaCPF(Me.txtCPF.Text.Trim) = False Then
                    Me.txtCPF.ResetText()
                    Me.txtCPF.Focus()
                    Exit Sub
                End If
            End If

            If NomeEmpresa.Trim.ToUpper.Contains("TAUÁ MODAS") = True Then
                If Not Me.txtNome.Text.Trim = "CUPOM FISCAL" Then
                    If Validar(Me.dtNasc) = False Then Exit Sub
                    If Validar(Me.txtCep) = False Then Exit Sub
                    If Validar(Me.cboUF) = False Then Exit Sub
                    If Validar(Me.cboCidade) = False Then Exit Sub
                    If Validar(Me.txtEnd) = False Then Exit Sub
                    If Validar(Me.txtNum) = False Then Exit Sub
                    If Validar(Me.txtBairro) = False Then Exit Sub
                    If Validar(Me.txtTel1) = False Then Exit Sub
                    If Validar(Me.txtTel2) = False Then Exit Sub
                    If Validar(Me.txtTel3) = False Then Exit Sub
                    If Validar(Me.cboMor) = False Then Exit Sub
                    If Validar(Me.txtEmp) = False Then Exit Sub
                    If Validar(Me.txtTelEmp) = False Then Exit Sub
                    If Validar(Me.txtTempTra) = False Then Exit Sub
                    If Validar(Me.txtNomeConj) = False Then Exit Sub
                    If Validar(Me.txtTelConj) = False Then Exit Sub
                    If Validar(Me.txtEnd) = False Then Exit Sub
                End If
            End If

            If DescontoMaximo <> "" Then
                If txtPerDesc.Text <> "" Then
                    If CDbl(txtPerDesc.Text) > CDbl(DescontoMaximo) Then
                        If Nivel = "USUÁRIO" Then
                            MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                            If SenhaEstaOK() = False Then
                                MsgBox("Desconto maior que o permitido!", MsgBoxStyle.Information)
                                Me.txtPerDesc.Text = ""
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If

            If Me.chkCPF.Tag = Nothing Then
                Me.chkCPF.Tag = ""
            End If
            If Me.txtCPF.Text.Trim <> Me.chkCPF.Tag.ToString.Trim Then
                If PesquisarCliente(txtCPF) = False Then Exit Sub
            End If

            Dim dtData As Date
            If Me.dtNasc.Text.Trim <> "" Then
                dtData = Me.dtNasc.Text
            Else
                dtData = "01/01/1900"
            End If

            If Validar(Me.txtLimite) = False Then
                Exit Sub
            End If
            If Me.txtCodMun.Text = "" Then
                CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)
            End If
            If Me.cboPais.Text = "" Then
                Me.cboPais.Text = "BRASIL"
            End If
            Dim strCadastro As String = ""
            Try
                strCadastro = CodUser & " " & NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss")
            Catch ex As Exception
                strCadastro = CodUser & " " & NomeComputador.ToUpper & " " & Date.Today.Day & "/" & Date.Today.Month & "/" & Date.Today.Year & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
            End Try

            Dim intCodFunc As Integer = 0
            If Me.lueCodFunc.Text <> "" Then
                intCodFunc = Me.lueCodFunc.EditValue
            End If

            Me.txtBairro.Text = TirarAcento(Me.txtBairro.Text)
            Me.NanoCampo1.Text = TirarAcento(Me.NanoCampo1.Text)

            If bolAlterado = False Then


                If intCodCli > 0 Then
                    Atualizar("UPDATE Cliente SET Nome = '" & Me.txtNome.Text.Trim & "', " & _
                    "RGIE = '" & Me.txtRGIE.Text.Trim & "', CPF = '" & Me.txtCPF.Text.Trim & "', " & _
                    "Endereco = '" & Me.txtEnd.Text.Trim.Replace("'", "`") & "', Telefone = '" & Me.txtTel1.Text.Trim & "', " & _
                                    "Fax = '" & Me.txtTel2.Text.Trim & "', Celular = '" & Me.txtTel3.Text.Trim & "', " & _
                                    "Email = '" & Me.txtWeb.Text.Trim & "', Numero = '" & Me.txtNum.Text.Trim & "', " & _
                                    "Complemento = '" & Me.txtComp.Text.Trim & "', Bairro = '" & Me.txtBairro.Text.Trim & "', " & _
                                    "Cep = '" & Me.txtCep.Text.Trim & "', Cidade = '" & Me.cboCidade.Text.Trim.Replace("'", "`") & "', " & _
                                    "Estado = '" & Me.cboUF.Text.Trim & "', Fantasia = '" & Me.txtFant.Text.Trim & "', " & _
                                    "Inadimplente = '" & Me.chkIna.Checked & "', Observacao = '" & Me.txtObs.Text.Trim.Replace("'", "") & "', " & _
                                    "Status = '" & Me.cboStatus.Text.Trim & "', Nascimento = '" & dtData & "', " & _
                                    "Sexo = '" & Me.cboSexo.Text.Trim & "', Limite = '" & Me.txtLimite.Text.Trim & "', " & _
                                    "Empresa = '" & Me.txtEmp.Text.Trim & "',TelEmpresa = '" & Me.txtTelEmp.Text.Trim & "', " & _
                                    "Salario = '" & Me.txtSal.Text.Trim & "', Credito = '" & Me.txtCredito.Text.Trim & "', " & _
                                    "Marcas = '" & Me.txtMarcas.Text.Trim & "', Pessoa1 ='" & Me.txtPessoa1.Text.Trim & "', " & _
                                    "Pessoa2 ='" & Me.txtPessoa2.Text.Trim & "', RG1 ='" & Me.txtRG1.Text.Trim & "', " & _
                                    "RG2 ='" & Me.txtRG2.Text.Trim & "', Inativo = '" & Me.chkInativar.Checked & "', " & _
                                    "TempoTrabalho ='" & Me.txtTempTra.Text.Trim & "', Moradia ='" & Me.cboMor.Text.Trim & "', " & _
                                    "NomeConjuge ='" & Me.txtNomeConj.Text.Trim & "', TelConjuge ='" & Me.txtTelConj.Text.Trim & "', " & _
                                    "Suframa = '" & Me.txtSuframa.Text & "', CodMunicipio = '" & Me.txtCodMun.Text & "', " & _
                                    "CodPais = '" & Me.txtCodPais.Text & "', NomePais = '" & Me.cboPais.Text & "', " & _
                                    "Desconto = " & Num(Me.txtPerDesc.Text) & ", Agencia = '" & Me.txtAgencia.Text & "', " & _
                                    "ContaCorrente = '" & Me.txtContaCorrente.Text & "', Banco = '" & Me.txtBanco.Text & "', " & _
                                    "Contato = '" & Me.txtContato.Text & "', CodFunc = " & intCodFunc & ", " & _
                                    "EnderecoEntrega='" & Me.NanoCampo5.Text.Trim.Replace("'", "`") & "', " & _
                                    "NumeroEntrega='" & Me.NanoCampo3.Text.Trim.Replace("'", "`") & "', " & _
                                    "ComplementoEntrega='" & Me.NanoCampo2.Text.Trim.Replace("'", "`") & "', " & _
                                    "BairroEntrega='" & Me.NanoCampo1.Text.Trim.Replace("'", "`") & "', " & _
                                    "CepEntrega='" & Me.NanoCampo4.Text.Trim.Replace("'", "`") & "', " & _
                                    "CidadeEntrega='" & Me.ComboBoxEdit1.Text.Trim.Replace("'", "`") & "', " & _
                                    "EstadoEntrega='" & Me.ComboBoxEdit2.Text.Trim.Replace("'", "`") & "' where Codigo = " & intCodCli)
                Else
                    If Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, " & _
                    "Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, " & _
                    "Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, " & _
                    "Pessoa2, RG1, RG2, Inativo, TempoTrabalho, Moradia, NomeConjuge, TelConjuge, Suframa, CodMunicipio, " & _
                    "CodPais, NomePais, Desconto, Agencia, ContaCorrente, Banco, Contato, Cadastro, CodFunc, EnderecoEntrega, " & _
                    "NumeroEntrega, ComplementoEntrega, BairroEntrega, CepEntrega, CidadeEntrega, EstadoEntrega) " & _
                    "VALUES ('" & Me.txtNome.Text.Trim & "','" & Me.txtRGIE.Text.Trim & "','" & Me.txtCPF.Text.Trim & "'," & _
                    "'" & Me.txtEnd.Text.Trim.Replace("'", "`") & "','" & Me.txtTel1.Text.Trim & "','" & Me.txtTel2.Text.Trim & "'," & _
                    "'" & Me.txtTel3.Text.Trim & "','" & Me.txtWeb.Text.Trim & "','" & Date.Today & "','" & Me.txtNum.Text.Trim & "'," & _
                    "'" & Me.txtComp.Text.Trim & "','" & Me.txtBairro.Text.Trim & "','" & Me.txtCep.Text.Trim & "'," & _
                    "'" & Me.cboCidade.Text.Trim.Replace("'", "`") & "','" & Me.cboUF.Text.Trim & "'," & _
                    "'" & Me.txtFant.Text.Trim & "','" & Me.chkIna.Checked & "','" & Me.txtObs.Text.Trim.Replace("'", "") & "'," & _
                    "'" & Me.cboStatus.Text.Trim & "','" & dtData & "','" & Me.cboSexo.Text.Trim & "'," & _
                    "'" & Me.txtLimite.Text.Trim & "','" & Me.txtEmp.Text.Trim & "','" & Me.txtTelEmp.Text.Trim & "'," & _
                                    "'" & Me.txtSal.Text.Trim & "','" & Me.txtCredito.Text.Trim & "','" & Me.txtMarcas.Text.Trim & "'," & _
                                    "" & CodConfig & ",'" & Me.txtPessoa1.Text.Trim & "','" & Me.txtPessoa2.Text.Trim & "'," & _
                                    "'" & Me.txtRG1.Text.Trim & "','" & Me.txtRG2.Text.Trim & "','" & Me.chkInativar.Checked & "'," & _
                                    "'" & Me.txtTempTra.Text.Trim & "','" & Me.cboMor.Text.Trim & "','" & Me.txtNomeConj.Text.Trim & "'," & _
                                    "'" & Me.txtTelConj.Text.Trim & "','" & Me.txtSuframa.Text.Trim & "','" & Me.txtCodMun.Text.Trim & "'," & _
                                    "'" & Me.txtCodPais.Text.Trim & "','" & Me.cboPais.Text & "'," & Num(Me.txtPerDesc.Text) & "," & _
                                    "'" & Me.txtAgencia.Text & "','" & Me.txtContaCorrente.Text & "','" & Me.txtBanco.Text & "'," & _
                                    "'" & Me.txtContato.Text & "','" & strCadastro & "'," & intCodFunc & "," & _
                                    "'" & Me.NanoCampo5.Text.Trim.Replace("'", "`") & "','" & Me.NanoCampo3.Text.Trim.Replace("'", "`") & "'," & _
                                    "'" & Me.NanoCampo2.Text.Trim.Replace("'", "`") & "','" & Me.NanoCampo1.Text.Trim.Replace("'", "`") & "'," & _
                                    "'" & Me.NanoCampo4.Text.Trim.Replace("'", "`") & "','" & Me.ComboBoxEdit1.Text.Trim.Replace("'", "`") & "'," & _
                                    "'" & Me.ComboBoxEdit2.Text.Trim.Replace("'", "`") & "')") = True Then


                        Dim dtCli As DataTable = CarregarDataTable("SELECT Codigo FROM Cliente where Nome = '" & Me.txtNome.Text.Trim & "' " & _
                      "and Cadastro = '" & strCadastro & "'")
                        If dtCli.Rows.Count > 0 Then
                            intCodCli = dtCli.Rows.Item(0).Item("Codigo")
                        Else
                            intCodCli = Val(GerarCodigo("Cliente", "Codigo", CodConfig)) - 1
                        End If

                        MsgBox("Cliente " & Me.txtNome.Text & " cadastrado com sucesso!", MsgBoxStyle.Information)

                    Else
                        MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If

               
                If Me.txtPlaca.Text <> "" Then

                    SalvarCarro(intCodCli)
                    bolAlteradoCarro = False
                    'LimparCarro()

                    FiltroCarro()
                    FiltroCarro()
                End If

                If Me.Tag = "VENDA" Then
                    NomeDoCliente = Me.txtNome.Text.Trim
                    CpfDoCliente = Me.txtCPF.Text.Trim
                    Me.Close()
                End If
                If Me.Tag = "PESQUISACOMANDA" Then
                    RetornaComanda(Me.txtNome.Text.Trim)
                    Exit Sub
                End If

           
                If Me.Tag = "PESQUISAVENDA" Or Me.Tag = "VEICULO" Or Me.Tag = "PESQUISA" Then
                    CodigoDoCliente = intCodCli
                    Me.Close()
                    Exit Sub
                End If

            Else

                If Atualizar("UPDATE Cliente SET Nome = '" & Me.txtNome.Text.Trim & "', " & _
                "RGIE = '" & Me.txtRGIE.Text.Trim & "', CPF = '" & Me.txtCPF.Text.Trim & "', " & _
                "Endereco = '" & Me.txtEnd.Text.Trim.Replace("'", "`") & "', Telefone = '" & Me.txtTel1.Text.Trim & "', " & _
                "Fax = '" & Me.txtTel2.Text.Trim & "', Celular = '" & Me.txtTel3.Text.Trim & "', " & _
                "Email = '" & Me.txtWeb.Text.Trim & "', Numero = '" & Me.txtNum.Text.Trim & "', " & _
                "Complemento = '" & Me.txtComp.Text.Trim & "', Bairro = '" & Me.txtBairro.Text.Trim & "', " & _
                "Cep = '" & Me.txtCep.Text.Trim & "', Cidade = '" & Me.cboCidade.Text.Trim.Replace("'", "`") & "', " & _
                "Estado = '" & Me.cboUF.Text.Trim & "', Fantasia = '" & Me.txtFant.Text.Trim & "', " & _
                "Inadimplente = '" & Me.chkIna.Checked & "', Observacao = '" & Me.txtObs.Text.Trim.Replace("'", "") & "', " & _
                "Status = '" & Me.cboStatus.Text.Trim & "', Nascimento = '" & dtData & "', " & _
                "Sexo = '" & Me.cboSexo.Text.Trim & "', Limite = '" & Me.txtLimite.Text.Trim & "', " & _
                "Empresa = '" & Me.txtEmp.Text.Trim & "',TelEmpresa = '" & Me.txtTelEmp.Text.Trim & "', " & _
                "Salario = '" & Me.txtSal.Text.Trim & "', Credito = '" & Me.txtCredito.Text.Trim & "', " & _
                "Marcas = '" & Me.txtMarcas.Text.Trim & "', Pessoa1 ='" & Me.txtPessoa1.Text.Trim & "', " & _
                "Pessoa2 ='" & Me.txtPessoa2.Text.Trim & "', RG1 ='" & Me.txtRG1.Text.Trim & "', " & _
                "RG2 ='" & Me.txtRG2.Text.Trim & "', Inativo = '" & Me.chkInativar.Checked & "', " & _
                "TempoTrabalho ='" & Me.txtTempTra.Text.Trim & "', Moradia ='" & Me.cboMor.Text.Trim & "', " & _
                "NomeConjuge ='" & Me.txtNomeConj.Text.Trim & "', TelConjuge ='" & Me.txtTelConj.Text.Trim & "', " & _
                "Suframa = '" & Me.txtSuframa.Text & "', CodMunicipio = '" & Me.txtCodMun.Text & "', " & _
                "CodPais = '" & Me.txtCodPais.Text & "', NomePais = '" & Me.cboPais.Text & "', " & _
                "Desconto = " & Num(Me.txtPerDesc.Text) & ", Agencia = '" & Me.txtAgencia.Text & "', " & _
                "ContaCorrente = '" & Me.txtContaCorrente.Text & "', Banco = '" & Me.txtBanco.Text & "', " & _
                "Contato = '" & Me.txtContato.Text & "', CodFunc = " & intCodFunc & ", " & _
                "EnderecoEntrega='" & Me.NanoCampo5.Text.Trim.Replace("'", "`") & "', " & _
                "NumeroEntrega='" & Me.NanoCampo3.Text.Trim.Replace("'", "`") & "', " & _
                "ComplementoEntrega='" & Me.NanoCampo2.Text.Trim.Replace("'", "`") & "', " & _
                "BairroEntrega='" & Me.NanoCampo1.Text.Trim.Replace("'", "`") & "', " & _
                "CepEntrega='" & Me.NanoCampo4.Text.Trim.Replace("'", "`") & "', " & _
                "CidadeEntrega='" & Me.ComboBoxEdit1.Text.Trim.Replace("'", "`") & "', " & _
                "EstadoEntrega='" & Me.ComboBoxEdit2.Text.Trim.Replace("'", "`") & "' where Codigo = " & intCodCli) = True Then
                    If Me.txtNome.Text.Trim <> strNome.Trim Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "','" & Me.txtNome.Text.Trim & "','NOME','CLIENTE','ALTERAÇÃO'," & CodConfig & ")")
                    End If

                    'If ImprimirCupomFiscal = True Then
                    '    ArqCliente("UNICO", False, intCodCli)
                    'End If


                    If Me.txtPlaca.Text <> "" Then

                        SalvarCarro(intCodCli)
                        bolAlteradoCarro = False
                        'LimparCarro()

                        FiltroCarro()
                        FiltroCarro()
                    End If

                    If Me.Tag = "VENDA" Then
                        NomeDoCliente = Me.txtNome.Text.Trim
                        CpfDoCliente = Me.txtCPF.Text.Trim
                        Me.Close()
                    End If
                    If Me.Tag = "PESQUISACOMANDA" Then
                        RetornaComanda(Me.txtNome.Text.Trim)
                        Exit Sub
                    End If

                    MsgBox("Cliente " & Me.txtNome.Text & " alterado com sucesso!", MsgBoxStyle.Information)
                Else
                    MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
                    Exit Sub
                End If

            End If


            If Me.picImagem.Image Is Nothing = False Then
                Dim imagem As Byte() = converteimagem(Me.picImagem.Image)
                InserirImagem("UPDATE Cliente set Imagem = @Img where Codigo = " & intCodCli, imagem)

            End If
            bolSoCarro = False
        Else
            MsgBox("Os dados não foram salvos! Nome do cliente é obrigatório", MsgBoxStyle.Information)
        End If

        'SalvarBairro()

        'If Me.txtPlaca.Text <> "" Then

        '    SalvarCarro(intCodCli)
        '    bolAlteradoCarro = False
        '    'LimparCarro()

        '    FiltroCarro()
        '    FiltroCarro()
        'End If

        bolAlterado = False
        AtualizarGrid()
        Limpar(bolSoCarro)
    End Sub
    Private Sub SalvarBairro(ByVal parBairro As String)
        If TipoNano = "1" Then
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
    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar(False)
        End If
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        'Alterar()
        Select Case Me.tbbCliente.SelectedTabPageIndex
            Case 0
                Alterar()
            Case 1
                AlterarCarro()
        End Select
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Select Case Me.tbbCliente.SelectedTabPageIndex
            Case 0
                If grd1.RowCount = 0 Then Exit Sub
                Dim Index As Integer = grd1.FocusedRowHandle
                If Index < 0 Then Exit Sub

                Dim intCod As Integer = grd1.GetRowCellDisplayText(Index, Me.colCodigo)
                If intCod = 1 Then
                    MsgBox("Não é possivel excluir o cliente CONSUMIDOR!", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Dim dtVerifica As DataTable = CarregarDataTable("Select Data from Total where CodCli = " & intCod)

                If dtVerifica.Rows.Count > 0 Then
                    MsgBox("Não é possivel excluir esse cliente pois existem vendas realizadas em seu nome!", MsgBoxStyle.Information)
                    Exit Sub
                End If

                Dim strCliente As String = grd1.GetRowCellDisplayText(Index, Me.colNome)

                If MsgBox("Deseja realmente excluir o Cliente " & strCliente & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If Excluir("Delete from Cliente where Codigo = " & intCod) = True Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strCliente & "','EXCLUÍDO','NOME','CLIENTE','EXCLUSÃO'," & CodConfig & ")")

                        'If ImprimirCupomFiscal = True Then
                        '    ArqCliente("UNICO", True, intCod)
                        'End If

                        MsgBox("Cliente excluído com sucesso!", MsgBoxStyle.Information)
                    End If

                    AtualizarGrid()
                End If

            Case 1

                If grd1.RowCount = 0 Then Exit Sub

                Dim strPlac As String
                strPlac = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, Me.colPlaca)

                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM TotalConsig where Placa = '" & strPlac & "'")
                If dt.Rows.Count > 0 Then
                    MsgBox("Não é possível excluir, pois existem pedidos vinculados a este veículo!", MsgBoxStyle.Information)
                    Exit Sub
                End If

                If MsgBox("Tem certeza que deseja excluir o veículo " & strPlac & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    'Deletar("Carro", "Placa", strPlac, grd1, grd1.FocusedRowHandle)
                    Excluir("DELETE FROM Carro where Placa = '" & strPlac & "' and CodConfig = " & Me.GridView1.GetRowCellDisplayText(Me.GridView1.FocusedRowHandle, Me.colCodConfig))
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strPlac & "','EXCLUÍDO','CARRO','CARRO','EXCLUSÃO'," & CodConfig & ")")
                    AtualizarGridCarro()
                    'CarregarDados("Select * From Carro", Me.CarroGridControl)
                    'CarregarDados("SELECT Codigo as CodigoCarro, Placa, Modelo, Cor, Ano, KM, Data, Cliente.CPF as CPFCliente, Cliente.Nome as NomeCliente, Fabricante, " & _
                    '"Combustivel, Motor, Cilindros, Valvulas, Chassi, Obs, Opcionais, KMMes, CodConfig FROM Carro left join Cliente on Carro.CodCli = Cliente.Codigo", Me.CarroGridControl)
                    ''Me.CarroTableAdapter.Fill(Me.DsMecanica.Carro)
                End If
        End Select
        
    End Sub

    Private Sub ClienteGridControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClienteGridControl.DoubleClick
        Alterar()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        RetornaPesquisa()
    End Sub

    Private Sub RetornaPesquisa()
        If grd1.FocusedRowHandle < 0 Then Exit Sub

        If bolAlterarClienteVeiculo = True Then
            intCodCli = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
            Me.txtCli.Text = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colNome)
            Me.txtNome.Text = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colNome)
            Alterar()
            bolAlterarClienteVeiculo = False
            Me.tbbCliente.SelectedTabPageIndex = 1
        Else
            If Me.Tag.ToString.Contains("PESQUISA") = True Then
                If grd1.GetRowCellValue(grd1.FocusedRowHandle, Me.colInativo) = False Then
                    If Me.Tag <> "PESQUISADEVOLUCAO" Then
                        If Me.Tag = "PESQUISACOMANDA" Then
                            RetornaComanda(grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colNome))
                            Exit Sub
                        End If
                        If grd1.GetRowCellValue(grd1.FocusedRowHandle, Me.colInadimplente) = True Then
                            If NomeEmpresa.Contains("PREMIER") = False Then

                                If NomeEmpresa.Contains("TAUÁ") = True Then
                                    If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCredito).ToString = "" Or Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCredito).ToString = "0,00" Then
                                        Exit Sub
                                    End If

                                Else
                                    If Me.Tag.ToString.Contains("VENDA") = False Then
                                        If ComSenha() = False Then Exit Sub
                                    End If

                                End If
                            End If

                        Else
                            Dim dt As DataTable = CarregarDataTable("Select Codigo from ContaReceber where RecebidoOK ='False' and Vencimento <'" & Date.Today.AddDays(-Tolerancia) & "' and CodCli =" & grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo))
                            If dt.Rows.Count > 0 Then
                                Atualizar("Update Cliente set Inadimplente ='True' where Codigo =" & grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo))

                                If NomeEmpresa.Contains("TAUÁ") = True Then Exit Sub
                                If NomeEmpresa.Contains("LUCIA FREITAS") = True Then Exit Sub

                                If Me.Tag.ToString.Contains("VENDA") = False Then
                                    If ComSenha() = False Then Exit Sub
                                End If

                            End If
                        End If
                    End If
                 
                    CodigoDoCliente = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
                    Me.Close()
                    Exit Sub
                Else
                    MsgBox("Cliente inativo!", MsgBoxStyle.Information)
                    Exit Sub
                End If

            Else
                Alterar()
                'AlterarCarro()
            End If
        End If
        
    End Sub


    Private Sub rdgDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDoc.SelectedIndexChanged

        Select Case Me.rdgDoc.SelectedIndex
            Case 0
                strCpfCnpj = "Cpf"
                Me.chkIsento.Visible = False
                Me.chkIsento.Checked = False
            Case 1
                strCpfCnpj = "Cnpj"
                Me.chkIsento.Visible = True
        End Select
        Me.txtCPF.ResetText()
        Me.txtCPF.Focus()
    End Sub

    Private Sub txtAlterar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlterar.KeyDown
        If e.KeyCode = Keys.Enter Then
            RetornaPesquisa()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Tag.ToString.Contains("PESQUISA") = True Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            If NomeEmpresa.Contains("TAUÁ") = True Then
                grd1.FocusedColumn = Me.colCPF
            Else
                grd1.FocusedColumn = Me.colNome
            End If

            grd1.ShowEditor()


        ElseIf Me.Tag.ToString.Contains("VEICULO") = True Then
            Me.tbbCliente.SelectedTabPageIndex = 1
            'Dim index As Integer = -999997
            'Me.GridView1.FocusedRowHandle = index
            'Me.GridView1.FocusedColumn = Me.colPlaca
            'Me.GridView1.ShowEditor()

            FiltroCarro()
            Me.txtPlaca.Focus()
        ElseIf Me.Tag = "CARRO" Then
            Me.tbbCliente.SelectedTabPageIndex = 1
            Me.txtPlaca.Focus()

        Else

            Me.txtNome.Focus()
        End If

        Timer1.Stop()
    End Sub

    Private Sub chkCPF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCPF.CheckedChanged
        Select Case Me.chkCPF.Checked
            Case True
                Me.txtCPF.Enabled = True
                Me.chkCPF.BackColor = Color.White
            Case False
                Me.chkCPF.BackColor = Color.Transparent
                Me.txtCPF.Enabled = False
                Me.txtCPF.Text = Me.chkCPF.Tag
        End Select
    End Sub

    Private Sub chkIsento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsento.CheckedChanged
        If Me.chkIsento.Checked = True Then
            Me.chkIsento.BackColor = Color.Transparent
            Me.txtRGIE.ResetText()
            Me.txtRGIE.Text = "ISENTO"
            Me.txtRGIE.Properties.ReadOnly = True
        Else
            Me.chkIsento.BackColor = Color.White
            Me.txtRGIE.ResetText()
            Me.txtRGIE.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub cboUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged
        Me.cboCidade.Properties.Items.Clear()
        Me.cboCidade.SelectedIndex = -1
        CarregarComboCidade(Me.cboUF.Text, Me.cboCidade)
        If Me.txtRGIE.Text = "ISENTO" Or Me.txtRGIE.Text = "" Then Exit Sub
        Me.txtRGIE.ResetText()
        Me.txtRGIE.Focus()
    End Sub



    Private Sub txtCep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCep.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarCep(Me.txtCep)

    End Sub

    Private Sub txtCep_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCep.Leave
        If ValidarCep = True Then
            Try
                If My.Computer.Network.IsAvailable = False Then Exit Sub
            Catch ex As Exception
                Exit Sub
            End Try


            Dim ht As Hashtable = BuscaCep3(Me.txtCep.Text.Trim)
            Dim strCidade, strEnd, strBairro As String

            If ht Is Nothing Then
                ht = BuscaCep2(Me.txtCep.Text.Trim)
            End If
            Try
                If ht.Count > 0 Then
                    strEnd = ht("tipologradouro") & " " & ht("logradouro")
                    strBairro = ht("bairro")
                    'strCidade = ht("localidade")
                    strCidade = ht("cidade")
                    Me.txtEnd.Text = strEnd.ToUpper.Replace("'", "´")
                    Me.txtBairro.Text = strBairro.ToUpper.Replace("'", "´")
                    Me.cboCidade.Text = strCidade.ToUpper.Replace("'", "´")
                    Me.cboUF.Text = ht("UF")
                    Me.txtNum.Focus()
                    CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)

                    SalvarBairro(Me.txtBairro.Text)


                    Exit Sub
                End If
            Catch ex As Exception

            End Try

            Me.cboUF.Focus()
        End If
    End Sub

    Private Sub NanoCampo4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NanoCampo4.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarCep(Me.NanoCampo4)

    End Sub

    Private Sub NanoCampo4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NanoCampo4.Leave
        If ValidarCep = True Then
            Try
                If My.Computer.Network.IsAvailable = False Then Exit Sub
            Catch ex As Exception
                Exit Sub
            End Try


            Dim ht As Hashtable = BuscaCep3(Me.NanoCampo4.Text.Trim)
            Dim strCidade, strEnd, strBairro As String

            If ht Is Nothing Then
                ht = BuscaCep2(Me.NanoCampo4.Text.Trim)
            End If
            Try
                If ht.Count > 0 Then
                    strEnd = ht("tipologradouro") & " " & ht("logradouro")
                    strBairro = ht("bairro")
                    'strCidade = ht("localidade")
                    strCidade = ht("cidade")
                    Me.NanoCampo5.Text = strEnd.ToUpper.Trim.Replace("'", "´")
                    Me.NanoCampo1.Text = strBairro.ToUpper.Replace("'", "´")
                    Me.ComboBoxEdit1.Text = strCidade.ToUpper.Replace("'", "´")
                    Me.ComboBoxEdit2.Text = ht("UF")
                    Me.NanoCampo3.Focus()
                    CodigoMunicipio(Me.ComboBoxEdit1.Text, Me.ComboBoxEdit2.Text)
                    SalvarBairro(Me.NanoCampo1.Text)
                    Exit Sub
                End If
            Catch ex As Exception

            End Try

            Me.cboUF.Focus()
        End If
    End Sub

    Private Sub txtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress

        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarDocumento(Me.txtCPF, strCpfCnpj)
    End Sub

    Private Sub txtCPF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPF.Leave
        If Me.txtCPF.Text.Trim = "" Then Exit Sub
        If PesquisarCliente(txtCPF) = False Then Exit Sub
        If ValidaCPF(Me.txtCPF.Text.Trim) = False Then
            Me.txtCPF.ResetText()
            Me.txtCPF.Focus()
            Exit Sub
        End If

        If Me.txtCPF.Text.Trim = "000.000.000-00" Or Me.txtCPF.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCPF.ResetText()
            Exit Sub
        End If




        'If My.Computer.Network.IsAvailable = False Then
        '    Exit Sub
        'End If

        'If My.Computer.Network.Ping("www.terra.com.br") = False Then
        '    Exit Sub
        'End If

        If Me.rdgDoc.SelectedIndex = 1 Then
            If BuscaCpfCnpj.Contains("CNPJ") = True Then
                BuscaCNPJ(Me.cboUF.Text, Me.txtCPF.Text, Me.Name, "01/01/1900")
            End If

        Else
            If BuscaCpfCnpj.Contains("CPF") = True Then
                If Me.dtNasc.Text <> "" Then

                    BuscaCNPJ("CPF", Me.txtCPF.Text, Me.Name, Me.dtNasc.EditValue)
                End If

            End If

        End If


    End Sub

    Private Sub txtFant_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFant.Leave
        Me.txtCPF.Focus()
    End Sub


    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        If Me.cboMes.Text = "" Then
            AtualizarGrid()
        Else
            CarregarDados("SELECT * FROM Cliente where Month(Nascimento) = '" & Me.cboMes.SelectedIndex & "'", Me.ClienteGridControl)
        End If
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click

        Dim rel As New relAniversariantes
        rel.picLogo.Image = LogoTipo

        Dim I, J, intQtd As Integer
        J = 0
        With rel.tbAniv.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colNascimento) <> "" Then
                    Dim dta As Date = Me.grd1.GetRowCellDisplayText(I, Me.colNascimento)

                    .Add()
                    .Item(J).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                    .Item(J).Item("Data") = String.Format("{0:dd/MM}", dta)
                    .Item(J).Item("Email") = Me.grd1.GetRowCellDisplayText(I, Me.colEmail)
                    .Item(J).Item("Tel1") = Me.grd1.GetRowCellDisplayText(I, Me.colTelefone)
                    .Item(J).Item("Tel2") = Me.grd1.GetRowCellDisplayText(I, Me.colCelular)
                    J += 1
                    intQtd += 1
                End If
            Next
        End With

        rel.lblTotal.Text = intQtd
        rel.ShowPreview()
    End Sub

    Private Sub txtLimite_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimite.Leave
        If Me.txtLimite.Text.Trim = "" Then Exit Sub
        If Me.txtSalDev.Text.Trim = "" Then Exit Sub

        Me.txtLimCli.Text = (CDbl(Me.txtLimite.Text) + CDbl(Me.txtSalDev.Text)).ToString("0.00")

    End Sub

    Private Sub chkInativar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInativar.CheckedChanged
        If Me.chkInativar.Checked = True Then
            If NomeEmpresa.Contains("TAUÁ") = True Then
                If Master = False Then
                    Me.chkInativar.Properties.ReadOnly = True
                End If
            End If
        Else

        End If
    End Sub


    Private Sub btnRelCli_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCli.ItemClick
        Dim I As Integer
        Dim rel As New relDadosCliente
        With rel.DsNanoCommerce.Cliente.Rows
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                .Item(I).Item("CPF") = Me.grd1.GetRowCellDisplayText(I, Me.colCPF)
                .Item(I).Item("RGIE") = Me.grd1.GetRowCellDisplayText(I, Me.colRGIE)

                If Me.grd1.GetRowCellDisplayText(I, Me.colNascimento) <> "" Then
                    .Item(I).Item("Nascimento") = Me.grd1.GetRowCellDisplayText(I, Me.colNascimento)
                End If

                .Item(I).Item("Endereco") = Me.grd1.GetRowCellDisplayText(I, Me.colEndereco)
                .Item(I).Item("Numero") = Me.grd1.GetRowCellDisplayText(I, Me.colNumero)
                .Item(I).Item("Bairro") = Me.grd1.GetRowCellDisplayText(I, Me.colBairro)
                .Item(I).Item("Cidade") = Me.grd1.GetRowCellDisplayText(I, Me.colCidade)
                .Item(I).Item("Cep") = Me.grd1.GetRowCellDisplayText(I, Me.colCep)
                .Item(I).Item("Estado") = Me.grd1.GetRowCellDisplayText(I, Me.colEstado)
                .Item(I).Item("Telefone") = Me.grd1.GetRowCellDisplayText(I, Me.colTelefone)
                .Item(I).Item("Celular") = Me.grd1.GetRowCellDisplayText(I, Me.colCelular)
                .Item(I).Item("Fax") = Me.grd1.GetRowCellDisplayText(I, Me.colFax)
                .Item(I).Item("Email") = Me.grd1.GetRowCellDisplayText(I, Me.colEmail)
                If Me.grd1.GetRowCellDisplayText(I, Me.colData) <> "" Then
                    .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                End If
            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.ClienteGridControl.ShowPrintPreview()
    End Sub

    Private Sub txtAlterar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlterar.KeyPress
        If Me.Tag.ToString = "CADASTRO" Then Exit Sub

        If NomeEmpresa.Contains("TAUÁ") = True Then
            If Me.grd1.FocusedColumn.Name = "colNome" Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtRGIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRGIE.KeyPress
        If strCpfCnpj = "Cnpj" Then
            Select Case Me.cboUF.Text
                'Case "AC"    ' Acre
                '    Me.txtRGIE.Properties.MaxLength = 17
                'Case "AL", "AP", "BA", "ES", "MA", "MS", "PI"   ' Alagoas
                '    Me.txtRGIE.Properties.MaxLength = 9
                'Case "AM", "RN", "MT", "GO"  ' Amazonas
                '    Me.txtRGIE.Properties.MaxLength = 12
                'Case "CE", "PB", "RR" ' Ceara
                '    Me.txtRGIE.Properties.MaxLength = 10
                'Case "DF"    ' Distrito Federal
                '    Me.txtRGIE.Properties.MaxLength = 14
                'Case "MG"    ' Minas Gerais
                '    Me.txtRGIE.Properties.MaxLength = 16
                'Case "PA", "PR", "RJ", "RO", "RS", "SC", "SE", "TO"  ' Para
                '    Me.txtRGIE.Properties.MaxLength = 11
                'Case "PE"    ' Pernambuco
                ' Me.txtRGIE.Properties.MaxLength = 18
                Case "SP"    ' São Paulo
                    Me.txtRGIE.Properties.MaxLength = 15
            End Select
            If IsNumeric(e.KeyChar) AndAlso Me.txtRGIE.Text.Length < Me.txtRGIE.Properties.MaxLength Then
                Me.txtRGIE.Text &= e.KeyChar
                Me.txtRGIE.SelectionStart = Me.txtRGIE.Text.Length
                formataIE(Me.txtRGIE, Me.cboUF.Text)
            End If
            If e.KeyChar = vbBack Then Exit Sub
            e.Handled = True
        End If
    End Sub

    Private Sub txtRGIE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRGIE.Leave

        If strCpfCnpj = "Cnpj" Then
            If Me.txtRGIE.Text = "" Then Exit Sub
            If ChecaInscrE(Me.cboUF.Text, Me.txtRGIE.Text) = False Then
                MsgBox("Inscrição Estadual informada não é valida, insira todos os ponto e verifique se a UF selecionada é a UF do cliente.", MsgBoxStyle.Information)
                Me.txtRGIE.ResetText()
                Me.txtRGIE.Focus()
            End If
        End If
    End Sub

    Private Sub txtLimCli_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimCli.Leave
        If Me.txtLimCli.Text.Trim = "" Then Exit Sub
        If Me.txtSalDev.Text.Trim = "" Then
            Me.txtSalDev.Text = "0,00"
        End If


        Me.txtLimite.Text = (CDbl(Me.txtLimCli.Text) - CDbl(Me.txtSalDev.Text)).ToString("0.00")
    End Sub

    Private Sub cboPais_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPais.EditValueChanged
        If EmiteNFE = True Then
            Dim dt As DataTable = CarregarDataTable("SELECT CodIBGE FROM Pais where Nome = '" & Me.cboPais.Text & "'")
            If dt.Rows.Count > 0 Then
                Me.txtCodPais.Text = dt.Rows.Item(0).Item("CodIBGE").ToString
            Else
                Me.txtCodPais.ResetText()
            End If
        End If
    End Sub

    Private Sub tbbCli_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbbCli.Click
        If Me.tbbCli.SelectedTabPageIndex = 2 Then
            CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)
        End If
    End Sub

    Private Sub CodigoMunicipio(ByVal parCidade As String, ByVal parUF As String)
        If parCidade <> "" Then
            Dim dt As DataTable = CarregarDataTable("SELECT CodIBGE FROM Cidade where Nome = '" & parCidade.Replace("'", "´") & "' and UF = '" & parUF & "'")
            If dt.Rows.Count > 0 Then
                Me.txtCodMun.Text = dt.Rows.Item(0).Item("CodIBGE").ToString
            End If
        End If
    End Sub

    Private Sub cboCidade_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCidade.Leave
        CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)
    End Sub

    Private Sub txtObs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObs.KeyPress, cboCidade.KeyPress, cboPais.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodPais_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPais.EditValueChanged
        If EmiteNFE = True Then
            Dim dt As DataTable = CarregarDataTable("SELECT Nome FROM Pais where CodIBGE = '" & Me.txtCodPais.Text & "'")
            If dt.Rows.Count > 0 Then
                Me.cboPais.Text = dt.Rows.Item(0).Item("Nome").ToString
            Else
                Me.cboPais.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub btnEmail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmail.ItemClick
        Dim I As Integer
        EnviarEmail = ""
        Dim intQtd As Integer = 0
        For I = 0 To Me.grd1.RowCount - 1
            If Me.grd1.GetRowCellDisplayText(I, Me.colEmail) <> "" Then
                If EnviarEmail = "" Then
                    EnviarEmail = Me.grd1.GetRowCellDisplayText(I, Me.colEmail).ToLower
                Else
                    EnviarEmail += ";" & Me.grd1.GetRowCellDisplayText(I, Me.colEmail).ToLower
                End If
                intQtd += 1
            End If
        Next
        frmEmail.intQtdCliente = intQtd
        Me.Close()
    End Sub

    Private Sub btnEti_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEti.ItemClick


        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If ProcuraForm("frmImpProd") <> "frmImpProd" Then


            frmImpProd.intCodCli = 0

            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim <> "" Then
                If CodigoClienteEtiqueta = "" Then
                    CodigoClienteEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                End If
                frmImpProd.Tag = "Cliente"
                Select Case Me.cboModelo.EditValue
                    Case "DUPLA"
                        frmImpProd.strTipoEtiqueta = Me.cboModelo.EditValue
                    Case "TRIPLA"
                        frmImpProd.strTipoEtiqueta = Me.cboModelo.EditValue
                    Case Else
                        MsgBox("Selecione o modelo da etiqueta!", MsgBoxStyle.Information)
                        Exit Sub
                End Select

                frmImpProd.Show()
            End If
        End If
    End Sub
    Private Function ProcuraForm(ByVal form_name As String) As String
        Dim i As Integer

        ProcuraForm = ""

        For i = 0 To My.Application.OpenForms.Count - 1
            Dim strForm As String = My.Application.OpenForms.Item(i).Name
            If strForm = form_name Then
                ProcuraForm = strForm
                Exit For
            End If
        Next

    End Function

    Private Sub btnAddEtiq_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddEtiq.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub


        If ProcuraForm("frmImpProd") = "frmImpProd" Then
            CodigoClienteEtiqueta = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        Else
            CodigoClienteEtiqueta &= Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo) & "|"
        End If

    End Sub

    Private Sub btnEtiquetaGeral_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEtiquetaGeral.ItemClick
        Select Case Me.cboModelo.EditValue
            Case "DUPLA"
                Dim rel As New relImp2

                Dim I As Integer

                For I = 0 To Me.grd1.RowCount - 1


                    rel.DsMecanica1.Produto.Rows.Add()
                    rel.DsMecanica1.Produto.Rows.Item(rel.DsMecanica1.Produto.Rows.Count - 1).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome).Trim
                    rel.DsMecanica1.Produto.Rows.Item(rel.DsMecanica1.Produto.Rows.Count - 1).Item("Grupo") = Me.grd1.GetRowCellDisplayText(I, Me.colEndereco).Trim & ", " & Me.grd1.GetRowCellDisplayText(I, Me.colNumero).Trim
                    rel.DsMecanica1.Produto.Rows.Item(rel.DsMecanica1.Produto.Rows.Count - 1).Item("Fabricante") = Me.grd1.GetRowCellDisplayText(I, Me.colBairro).Trim & " - " & Me.grd1.GetRowCellDisplayText(I, Me.colComplemento).Trim
                    rel.DsMecanica1.Produto.Rows.Item(rel.DsMecanica1.Produto.Rows.Count - 1).Item("Obs") = Me.grd1.GetRowCellDisplayText(I, Me.colCidade).Trim & " - " & Me.grd1.GetRowCellDisplayText(I, Me.colCep).ToString.Replace(".", "").Trim & " - " & Me.grd1.GetRowCellDisplayText(I, Me.colEstado).Trim

                Next

                rel.ShowPreview()
            Case "TRIPLA"

                Dim rel As New relPimacoTripla

                Dim I As Integer

                For I = 0 To Me.grd1.RowCount - 1

                    rel.tbProd.Rows.Add()
                    rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome).Trim
                    rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Rua") = Me.grd1.GetRowCellDisplayText(I, Me.colEndereco).Trim
                    rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Bairro") = Me.grd1.GetRowCellDisplayText(I, Me.colBairro).Trim
                    rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Cidade") = Me.grd1.GetRowCellDisplayText(I, Me.colCidade).Trim
                    rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Num") = Me.grd1.GetRowCellDisplayText(I, Me.colNumero).Trim
                    rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Cep") = Me.grd1.GetRowCellDisplayText(I, Me.colCep).ToString.Replace(".", "").Trim
                    rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Complemento") = Me.grd1.GetRowCellDisplayText(I, Me.colComplemento).Trim

                Next

                rel.ShowPreview()

            Case Else
                MsgBox("Selecione o modelo da etiqueta!", MsgBoxStyle.Information)
                Exit Sub
        End Select

    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub btnConCPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConCPF.Click
        If Me.txtCPF.Text.Trim = "" Then
            MsgBox("CPF/CNPJ é obrigatório!", MsgBoxStyle.Information)
            Exit Sub
        End If

        'If My.Computer.Network.IsAvailable = False Then
        '    MsgBox("Verifique a conexão com a internet!", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'If My.Computer.Network.Ping("www.terra.com.br") = False Then
        '    MsgBox("erifique a conexão com a internet!", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.rdgDoc.SelectedIndex = 1 Then
            'If BuscaCpfCnpj.Contains("CNPJ") = True Then
            BuscaCNPJ(Me.cboUF.Text, Me.txtCPF.Text, Me.Name, "01/01/1900")
            'End If

        Else
            'If BuscaCpfCnpj.Contains("CPF") = True Then
            If Me.dtNasc.Text <> "" Then
                BuscaCNPJ("CPF", Me.txtCPF.Text, Me.Name, Me.dtNasc.EditValue)
            Else
                MsgBox("Nascimento é obrigatório!", MsgBoxStyle.Information)
            End If

            'End If

        End If
    End Sub
    Private Sub nbcImagem_NavPaneStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbcImagem.NavPaneStateChanged
        If nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then


            Me.nbgImagem.GroupClientHeight = 80
            Me.btnOcultar.Visible = False
            'Me.nbcImagem.Size = New System.Drawing.Size(37, 247)
            Me.nbcImagem.Size = New System.Drawing.Size(37, 276)
            Me.nbcImagem.Location = New System.Drawing.Point(952, 0)

            'Me.txtFant.Size = New System.Drawing.Size(303, 20)
            'Me.txtEnd.Size = New System.Drawing.Size(303, 20)
            'Me.txtBairro.Size = New System.Drawing.Size(303, 20)
            'Me.txtWeb.Size = New System.Drawing.Size(303, 20)
            'Me.PanelControl1.Size = New System.Drawing.Size(944, 5)
            Me.XtraTabControl1.Size = New System.Drawing.Size(944, 96)

            Me.GroupControl2.Size = New System.Drawing.Size(944, 54)

        Else
            Me.btnOcultar.Visible = True

            Me.nbcImagem.PaintStyleName = "ExplorerBarView"

            Me.nbcImagem.Appearance.GroupBackground.BackColor = Color.Transparent
            Me.nbcImagem.Appearance.Background.BackColor = Color.Transparent
            Me.nbgImagem.GroupClientHeight = 218

            Me.nbgImagem.Appearance.BackColor = Color.Transparent

            Me.nbgImagem.Expanded = True


            'Me.txtFant.Size = New System.Drawing.Size(127, 20)
            'Me.txtEnd.Size = New System.Drawing.Size(127, 20)
            'Me.txtBairro.Size = New System.Drawing.Size(127, 20)
            'Me.txtWeb.Size = New System.Drawing.Size(127, 20)
            'Me.PanelControl1.Size = New System.Drawing.Size(570, 5)
            Me.XtraTabControl1.Size = New System.Drawing.Size(570, 96)
            Me.GroupControl2.Size = New System.Drawing.Size(570, 54)
        End If
    End Sub
    Private Sub nbcImagem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbcImagem.Click
        Try
            If Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
                If Me.nbcImagem.NavPaneForm.ExpandedGroup.Expanded = True Then
                    Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultar.Click
        Me.nbcImagem.PaintStyleName = "SkinNavigationPane"
        Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
    End Sub

    Private Sub btnTirar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTirar.Click
        frmWebCam.Tag = "CLIENTE"
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\MyCam") = True Then
            Dim startInfo As New ProcessStartInfo(My.Application.Info.DirectoryPath & "\MyCam\MyCam.exe")
            startInfo.WindowStyle = ProcessWindowStyle.Hidden

            Process.Start(startInfo)
            Me.Cursor = Cursors.WaitCursor
            Timer2.Start()
        Else
            frmWebCam.ShowDialog()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim processo As Process() = Process.GetProcessesByName("MyCam")
        Dim bolAbriu As Boolean = False
        ' While bolAbriu = False
        If processo.Length > 0 Then
            bolAbriu = True
            Timer2.Stop()
            Me.Cursor = Cursors.Default
            frmWebCam.ShowDialog()
            Timer2.Stop()
        End If
        'End While

        Timer2.Stop()
    End Sub
    Private Sub btnCarregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Try
            Me.OpenFileDialog1.FileName = ""
            OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                Me.picImagem.Image = System.Drawing.Bitmap.FromFile(Me.OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnRelVendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelVendas.Click
        If bolAlterado = False Then MsgBox("Selecione o cliente!", MsgBoxStyle.Information) : Exit Sub
        CodigoDoCliente = intCodCli
        NomeDoCliente = Me.txtNome.Text
        Dim rel As New frmConPedido
        rel.Tag = "CLIENTE"
        rel.Show()
    End Sub

    Private Sub btnConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsumo.Click
        If bolAlterado = False Then MsgBox("Selecione o cliente!", MsgBoxStyle.Information) : Exit Sub
        NomeDoCliente = Me.txtNome.Text
        CodigoDoCliente = intCodCli
        Dim rel As New frmRelConsumo
        rel.Tag = "CLIENTE"
        rel.Show()
    End Sub

    Private Sub txtPerDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPerDesc.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPerDesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPerDesc.Leave
        Preco(txtPerDesc)
        If txtPerDesc.Text = "" Then Exit Sub
        If DescontoMaximo <> "" Then
            If CDbl(txtPerDesc.Text) > CDbl(DescontoMaximo) Then
                If Nivel = "USUÁRIO" Then
                    MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                    If SenhaEstaOK() = False Then
                        MsgBox("Desconto maior que o permitido!", MsgBoxStyle.Information)
                        Me.txtPerDesc.Text = ""
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub btnRelCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCliente.ItemClick
        Dim rel As New relCliente

        rel.picLogo.Image = LogoTipo

        With rel.tbCliente.Rows
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                .Item(I).Item("CPF") = Me.grd1.GetRowCellDisplayText(I, Me.colCPF)
                .Item(I).Item("RGIE") = Me.grd1.GetRowCellDisplayText(I, Me.colRGIE)
                .Item(I).Item("Endereco") = Me.grd1.GetRowCellDisplayText(I, Me.colEndereco)
                .Item(I).Item("Numero") = Me.grd1.GetRowCellDisplayText(I, Me.colNumero)
                .Item(I).Item("Cidade") = Me.grd1.GetRowCellDisplayText(I, Me.colCidade)
                .Item(I).Item("Telefone") = Me.grd1.GetRowCellDisplayText(I, Me.colTelefone)
                .Item(I).Item("Email") = Me.grd1.GetRowCellDisplayText(I, Me.colEmail)
            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub tab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab.Click
        Select Case Me.tab.SelectedTabPageIndex
            Case 2
                Me.tab.Dock = DockStyle.Fill
                Me.GroupControl7.Visible = False
            Case Else
                Me.tab.Dock = DockStyle.Top
                Me.GroupControl7.Visible = True
        End Select
    End Sub

    Private Sub tbbCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbCliente.Click
        Me.tab.SelectedTabPageIndex = 0
        Me.tbbCli.SelectedTabPageIndex = 0
        Me.tab.Dock = DockStyle.Top
        Me.GroupControl7.Visible = True

        FiltroCarro()

    End Sub

    Private Sub txtPlaca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlaca.Leave
        If txtPlaca.Text = "" Then Exit Sub
        If txtPlaca.Text.Length < 7 Then
            MsgBox("Formato de Placa incorreto!", MsgBoxStyle.Critical)
            txtPlaca.Focus()
            Exit Sub
        End If

        If txtPlaca.Properties.ReadOnly = False Then
            PesquisarCarro(txtPlaca)
        End If
    End Sub

    Private Sub txtPlaca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlaca.KeyPress
        If txtPlaca.Text.Length <= 2 Then
            If Char.IsLetter(e.KeyChar) = False And e.KeyChar <> vbBack Then
                e.Handled = True
            End If
        ElseIf txtPlaca.Text.Length = 3 Then
            If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
                e.Handled = True
            End If

        ElseIf txtPlaca.Text.Length > 4 Then
            If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CarregarImagem(ByVal parCampo As DevExpress.XtraEditors.PictureEdit)
        ofdImagem.FileName = ""
        ofdImagem.ShowDialog()
        If ofdImagem.FileName <> "" Then
            Dim img As String = ofdImagem.FileName
            parCampo.Image = System.Drawing.Bitmap.FromFile(img)
        End If
    End Sub

    Private Sub btnImagem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem1.Click
        CarregarImagem(Me.picImagem1)
    End Sub

    Private Sub btnImagem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem2.Click
        CarregarImagem(Me.picImagem2)
    End Sub

    Private Sub btnImagem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem3.Click
        CarregarImagem(Me.picImagem3)
    End Sub

    Private Sub btnImagem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem4.Click
        CarregarImagem(Me.picImagem4)
    End Sub

    Private Sub btnImagem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem5.Click
        CarregarImagem(Me.picImagem5)
    End Sub

    Private Sub btnImagem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem6.Click
        CarregarImagem(Me.picImagem6)
    End Sub

    Private Sub CarregarImagemCentral(ByVal parCampo As DevExpress.XtraEditors.PictureEdit)
        If parCampo.Image Is Nothing = True Then Exit Sub
        Me.PictureEdit1.Image = parCampo.Image
    End Sub
    Private Sub picImagem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagem1.Click
        CarregarImagemCentral(Me.picImagem1)
    End Sub

    Private Sub picImagem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagem2.Click
        CarregarImagemCentral(Me.picImagem2)
    End Sub

    Private Sub picImagem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagem3.Click
        CarregarImagemCentral(Me.picImagem3)
    End Sub

    Private Sub picImagem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagem4.Click
        CarregarImagemCentral(Me.picImagem4)
    End Sub

    Private Sub picImagem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagem5.Click
        CarregarImagemCentral(Me.picImagem5)
    End Sub

    Private Sub picImagem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagem6.Click
        CarregarImagemCentral(Me.picImagem6)
    End Sub

    Private Sub RepositoryItemTextEdit1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.DoubleClick
        AlterarCarro()
    End Sub

    Private Sub txtCli_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCli.ButtonClick
        AbreCliente()
    End Sub
    Dim bolAlterarClienteVeiculo As Boolean = False
    Private Sub AbreCliente()
        bolAlterarClienteVeiculo = True
        Me.tbbCliente.SelectedTabPageIndex = 0
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colNome
        grd1.ShowEditor()

    End Sub

    Private Sub chkCli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCli.CheckedChanged
        Select Case Me.chkCli.Checked
            Case True
                Me.txtCli.Enabled = True
                Me.chkCli.BackColor = Color.White
                'Me.txtCli.BackColor = Color.White
            Case False
                'Me.txtCli.Text = Me.chkCPF.Tag
                Me.txtCli.Enabled = False
                Me.chkCli.BackColor = Color.WhiteSmoke
        End Select
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim I As Integer

        For I = 0 To Me.lstOpc.ItemCount - 1
            If Me.lstOpc.Items.Item(I).CheckState = CheckState.Checked Then
                Me.lstItens.Items.Add(Me.lstOpc.Items.Item(I).Value)
            End If
        Next

        For I = 0 To Me.lstOpc.ItemCount - 1
            Me.lstOpc.Items.Item(I).CheckState = CheckState.Unchecked
        Next
    End Sub

    Private Sub btnRem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRem.Click
        If Me.lstItens.ItemCount = 0 Then Exit Sub
        Me.lstItens.Items.RemoveAt(Me.lstItens.SelectedIndex)
    End Sub

    Private Sub btnRemTudo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemTudo.Click
        Me.lstItens.Items.Clear()
    End Sub


    Private Sub RetornaComanda(ByVal parNome As String)
        FecharTeclado()
        Me.Close()

        frmAbrirComanda.txtCliente.Text = parNome
        frmAbrirComanda.txtComanda.Text = strComanda
        frmAbrirComanda.txtMesa.Text = strMesa
        frmAbrirComanda.MdiParent = MDIComanda
        frmAbrirComanda.Show()
        frmAbrirComanda.Dock = DockStyle.Fill
    End Sub

    Private Sub btnCadBairro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBairro.Click
        frmGrupo.strBairro = TirarAcento(Me.txtBairro.Text)
        frmGrupo.Tag = "BAIRRO"
        frmGrupo.ShowDialog()
        Me.txtBairro.Properties.Items.Clear()
        PreencherGrupoSetorCusto("B", Me.txtBairro)

        Me.NanoCampo1.Properties.Items.Clear()
        PreencherGrupoSetorCusto("B", Me.NanoCampo1)

        Me.txtBairro.Focus()
    End Sub

    Private Sub btnCadBairro2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBairro2.Click
        frmGrupo.strBairro = TirarAcento(Me.NanoCampo1.Text)
        frmGrupo.Tag = "BAIRRO"
        frmGrupo.ShowDialog()
        Me.txtBairro.Properties.Items.Clear()
        PreencherGrupoSetorCusto("B", Me.txtBairro)

        Me.NanoCampo1.Properties.Items.Clear()
        PreencherGrupoSetorCusto("B", Me.NanoCampo1)

        Me.NanoCampo1.Focus()
    End Sub

    Private Sub txtBairro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBairro.Leave
        SalvarBairro(TirarAcento(Me.txtBairro.Text))
    End Sub

    Private Sub NanoCampo1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NanoCampo1.Leave
        SalvarBairro(TirarAcento(Me.NanoCampo1.Text))
    End Sub
End Class