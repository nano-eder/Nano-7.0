Imports Nano.clsFuncoes
Imports Nano.clsGerarArqs

Public Class frmConfig

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNanoCommerce.Config' table. You can move, or remove it, as needed.
        Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        Me.cboTabelaPreco.Properties.Items.Clear()
        PreencherGrupoSetorCusto("T", Me.cboTabelaPreco)
        Me.cboSetor.Properties.Items.Clear()
        PreencherGrupoSetorCusto("S", Me.cboSetor)
        Me.XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.txtNome) = False Then Exit Sub
        If Validar(Me.txtEnd) = False Then Exit Sub
        If Validar(Me.txtTel) = False Then Exit Sub
        If Validar(Me.txtCNPJ) = False Then Exit Sub

        'If Me.cboECF.SelectedIndex = 1 Then
        '    If Validar(Me.cboECF) = False Then Exit Sub
        '    If Validar(Me.cboTef) = False Then Exit Sub
        '    If Validar(Me.txtMestra) = False Then Exit Sub
        'End If
        If Me.chkManterMargemVenda.Checked = True Then
            Me.chkManterPorcProd.Checked = True
        End If
        Me.Validate()
        Me.ConfigBindingSource.EndEdit()
        Me.ConfigTableAdapter.Update(Me.DsNanoCommerce.Config)
        MsgBox("Sistema Configurado com sucesso!" & vbCrLf & "O sistema precisa ser fechado, abra-o novamente.", MsgBoxStyle.Information)
        Me.Close()

    End Sub

    Private Sub txtCNPJ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNPJ.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    'Private Sub btnGerarArqCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarArqCF.Click
    '    Dim intNumArqs As Integer

    '    intNumArqs = ArqUsuario("TUDO", False)

    '    intNumArqs += ArqCliente("TUDO", False)

    '    intNumArqs += ArqProduto("TUDO", False)

    '    intNumArqs += ArqPagamento("TUDO", False)

    '    EscreveArquivosCupom("TUDO", intNumArqs)
    '    MsgBox("Arquivos gerados com sucesso!", MsgBoxStyle.Information)
    'End Sub


    Private Sub btnPastaNotaNfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastaNotaNfe.Click
        Me.fbdOpen.SelectedPath = ""
        Me.fbdOpen.ShowDialog()
        Me.txtPastaNotaNfe.Text = fbdOpen.SelectedPath
    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLogo.Click
        ofdLogo.FileName = ""
        ofdLogo.ShowDialog()
        If ofdLogo.FileName <> "" Then
            Me.imgLogo.ImageLocation = ofdLogo.FileName
        End If
    End Sub


    Private Sub BaixaPorLoteCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBaixaPorLote.CheckedChanged
        Me.chkEstoqueSomado.Checked = False
        Select Case Me.chkBaixaPorLote.Checked
            Case True

                Me.chkEstoqueSomado.Enabled = False
            Case False
                Me.chkEstoqueSomado.Enabled = True
        End Select
    End Sub

    Private Sub ImpressoraComboBoxEdit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboImpressora.SelectedIndexChanged
        Select Case Me.cboImpressora.SelectedIndex
            Case 0
                Me.txtNomeImpressora.Enabled = False
            Case 1 To 6
                Me.lblImp.Visible = False
                Me.lblPorta.Visible = True
                Me.txtNomeImpressora.Enabled = True
            Case Is > 6
                Me.lblImp.Visible = True
                Me.lblPorta.Visible = False
                Me.txtNomeImpressora.Enabled = True

        End Select
    End Sub

    Private Sub btnBoleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoleto.Click
        Me.fbdOpen.SelectedPath = ""
        Me.fbdOpen.ShowDialog()
        Me.txtPastaBoleto.Text = fbdOpen.SelectedPath
    End Sub


    Private Sub CheckEdit4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPAFECF.CheckedChanged
        Me.chkSATFiscal.Checked = False
        If Me.chkPAFECF.Checked = True Then
            Me.chkSATFiscal.Enabled = False
        Else
            Me.chkSATFiscal.Enabled = True
        End If
    End Sub

    Private Sub CheckEdit17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSATFiscal.CheckedChanged
        Me.chkPAFECF.Checked = False
        If Me.chkSATFiscal.Checked = True Then
            Me.chkPAFECF.Enabled = False
        Else
            Me.chkPAFECF.Enabled = True
        End If
    End Sub

    Private Sub btnPastaNFCe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastaNFCe.Click
        Me.fbdOpen.SelectedPath = ""
        Me.fbdOpen.ShowDialog()
        Me.txtPastaNFCe.Text = fbdOpen.SelectedPath
    End Sub

    Private Sub CadastrarCliente()

        'CARREGA DADOS DOS CAMPOS
        Dim strEmpresa, strCNPJ, strEnd, strCidade, strUF, strVesao, strDescricao As String
        Dim bolCupom, bolSat, bolNfe, bolNFCe As Boolean
        Dim dtData As Date

        strEmpresa = Me.txtNome.Text.Trim.ToUpper

        strCNPJ = Me.txtCNPJ.Text.Trim
        If strCNPJ.Length = 14 Then
            strCNPJ = AddPonto(strCNPJ, "J")
        Else
            strCNPJ = AddPonto(strCNPJ, "F")
        End If

        strEnd = Me.txtEnd.Text.Trim.ToUpper
        strCidade = txtCidade.Text.Trim.ToUpper
        strUF = Me.cboUF.Text.Trim
        dtData = Date.Now
        strVesao = Me.txtVersaoNano.Text.Trim
        strDescricao = Me.txtDescricao.Text.Trim.ToUpper

        bolCupom = Me.chkPAFECF.Checked
        bolSat = Me.chkSATFiscal.Checked
        bolNfe = Me.chkNanoNFe.Checked
        bolNFCe = Me.chkNanoNFCe.Checked


        'VERIFICA ULTIMO COD NA TABELA CLIENTE
        Dim dtCod As DataTable = DataTableOnline("Select MAX(Cod) + 1 as Cod From Cliente")

        Dim CodCli As Integer
        If dtCod.Rows.Count > 0 Then
            CodCli = CInt(dtCod.Rows.Item(0).Item("Cod").ToString)
        End If


        'VERIFICA SE CLIENTE ESTA CADASTRADO
        Dim dtCli As DataTable = DataTableOnline("Select Count(*) as Count From Cliente Where CPF ='" & strCNPJ & "'")

        Dim count As Integer = 0
        If dtCli.Rows.Count > 0 Then
            count = CInt(dtCli.Rows.Item(0).Item("Count").ToString)

            If count = 0 Then
                ExecCmdOnline("Insert Into Cliente (Nome, RGIE, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, " & _
                " Estado, Telefone, Fax, Celular, Email, Data, Fantasia, Observacao, Inadimplente, Status, CodProjeto, " & _
                " Mensalista, Nascimento, Inativo, Versao, Funcionario1, Funcionario2, Funcao1, Funcao2, Cupom, Nfe, Cod, " & _
                " Compra, Razao, Ativado, CodFunc, BackupAutomatico, Sincronizacao, SatFiscal, AppTablet, PDV, NFCe, Atualizar) " & _
                " Values('" & strEmpresa & "', '', '" & strCNPJ & "', '" & strEnd & "', '', '', '','', '" & strCidade & "', '" & strUF & "', " & _
                " '', '', '', '', '" & dtData & "', '', '', 0, 3, 10, 1, '1910-01-01', 0, '" & strVesao & "', '', '', '', '', " & _
                " '" & bolCupom & "', '" & bolNfe & "', " & CodCli & ", 'VENDEDOR', '" & strDescricao & "', 1, " & CodigoVendedor & ", " & _
                " 0, 'UNICO', '" & bolSat & "', 0, 0, '" & bolNFCe & "', 0)")

                MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Cliente já cadastrado", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnCadCli_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadCli.ItemClick
        Dim frm As New frmSenhaExcluir
        frm.Tag = "VENDEDOR"
        frm.ShowDialog()

        If CodigoVendedor <> 0 Then
            CadastrarCliente()
        End If
    End Sub
    Private Sub btnBuscaCPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCPF.Click
        BuscaCNPJ(Me.cboUF.Text, Me.txtCNPJ.Text, Me.Name, "01/01/1900")
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Select Case Me.XtraTabControl1.SelectedTabPageIndex
            Case 0
                Me.XtraTabControl1.Size = New System.Drawing.Size(845, 184)
            Case 2
                Me.XtraTabControl1.Size = New System.Drawing.Size(845, 106)
            Case 1, 3, 5, 6
                Me.XtraTabControl1.Size = New System.Drawing.Size(845, 255)
            Case 4
                Me.XtraTabControl1.Size = New System.Drawing.Size(845, 170)
            Case 7
                Me.XtraTabControl1.Size = New System.Drawing.Size(845, 127)
        End Select
    End Sub

    Private Sub Explicacao(ByVal parCampo As String)
        Select Case parCampo
            Case "txtNome"
                Me.lblExplicacao.Text = vbCrLf & "Nome Fantasia da empresa."
            Case "txtDescricao"
                Me.lblExplicacao.Text = vbCrLf & "Descrever se é Matriz ou demais lojas."
            Case "txtCNPJ"
                Me.lblExplicacao.Text = vbCrLf & "CNPJ da empresa."
            Case "txtEnd"
                Me.lblExplicacao.Text = vbCrLf & "Endereço da empresa."
            Case "txtCidade"
                Me.lblExplicacao.Text = vbCrLf & "Cidade da empresa."
            Case "cboUF"
                Me.lblExplicacao.Text = vbCrLf & "Estado que a empresa se localiza."
            Case "txtTel"
                Me.lblExplicacao.Text = vbCrLf & "Telefone e E-mail da empresa."
            Case "imgLogo"
                Me.lblExplicacao.Text = vbCrLf & "Adicionar ou alterar o logotipo da empresa. Duplo clique na imagem para alterar, seleciona a pasta onde está o logotipo da empresa."
            Case "cboTipoNano"
                Me.lblExplicacao.Text = vbCrLf & "Informe qual será o tipo de Nano utilizado, indicado por números de 0 á 5, onde: " & vbCrLf & vbCrLf & "0 - Commerce Padrão" & vbCrLf & "1 - Restaurantes e uso de Comandas" & vbCrLf & "2 - Auto Peças" & vbCrLf & "3 - Veterinárias e Pet Shops" & vbCrLf & "5 - Automotivo e Moto Peças"
            Case "cboSetor"
                Me.lblExplicacao.Text = vbCrLf & "O estoque pode ficar separado por setor. Se informado este campo, nos pedidos a consulta de produtos mostrará apenas produtos desse setor enquanto na venda a consulta ainda apresentará todos os produtos."
            Case "cboTabelaPreco"
                Me.lblExplicacao.Text = vbCrLf & "Informe qual a tabela de preço será a padrão dessa loja. Deixe em branco caso queira deixar com o padrão do sistema."
            Case "cboCPFCliente"
                Me.lblExplicacao.Text = vbCrLf & "Seleciona se o método de busca será por CPF ou CNPJ."
            Case "txtVersaoNano"
                Me.lblExplicacao.Text = vbCrLf & "Versão atual do sistema."
            Case "txtPastaBoleto"
                Me.lblExplicacao.Text = vbCrLf & "Local de destino do Boleto, onde estarão localizados os arquivos de boletos. O caminho deverá ser = C:\Debug\NanoBoleto"
            Case "txtServidor"
                Me.lblExplicacao.Text = vbCrLf & "Informe o nome do servidor principal caso as lojas sejam sincronizadas."
            Case "chkMensalista"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso a empresa seja mensalista."
            Case "chkValidarCep"
                Me.lblExplicacao.Text = vbCrLf & "Busca o endereço pelo CEP."
            Case "chkVincularUser"
                Me.lblExplicacao.Text = vbCrLf & "Habilite essa função para vincular o usuário ao vendedor. Assim os vendedores só poderão ver os pedidos feitos por eles mesmos e não poderão ver os pedidos de outros vendedores."
            Case "chkValidarCPF"
                Me.lblExplicacao.Text = vbCrLf & "Obriga informar o CPF no cadastro do cliente."
            Case "chkSenhaAdm"
                Me.lblExplicacao.Text = vbCrLf & "Teste."
            Case "chkVisTrocoCaixa"
                Me.lblExplicacao.Text = vbCrLf & "Visualizar o troco gerado pela venda no caixa."
            Case "chkDezPorcento"
                Me.lblExplicacao.Text = vbCrLf & "Acrescenta os dez por cento na conta do cliente. (Funciona apenas na comanda)."
            Case "chkUsarBoleto"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso deseje usar boleto."
            Case "chkVisCobranca"
                Me.lblExplicacao.Text = vbCrLf & "Habilite essa função para que o cliente visualize pendências com a Era Systems. Se você for um representante do Nano que emite seus próprios boletos para seus clientes, deixe essa função desabilitada."
            Case "chkAltDataCaixa"
                Me.lblExplicacao.Text = vbCrLf & "Habilite essa função para liberar a edição da data ao adicionar Créditos ou Débitos diretamente pela tela do Caixa."
            Case "txtTolerancia"
                Me.lblExplicacao.Text = vbCrLf & "Número de dias de tolerância para começar a cobrar juros."
            Case "txtJuros"
                Me.lblExplicacao.Text = vbCrLf & "Será a porcentagem de juros cobrado no contas a receber quando uma conta estiver vencida, os juros são calculados diariamente, portanto, o valor da taxa de juros cobrado ao mês tem que ser dividido por 30, que é o número de dias no mês. Por exemplo, se uma taxa de juros ao mês é 4 %, o valor que deverá ser discriminado é de 0,1333 , pois é correspondente à 4/30 = 0,1333."
            Case "txtDescontoMaximo"
                Me.lblExplicacao.Text = vbCrLf & "Máximo de desconto concedido aos clientes pelos usuários."
            Case "txtJurosParcela"
                Me.lblExplicacao.Text = vbCrLf & "Parametriza a partir de qual parcela será cobrado o juros no parcelamento de contas. Exemplo: se colocar o número 3, uma compra parcelada só irá gerar juros se for igual ou maior à 3 vezes o parcelamento."
            Case "txtCredito"
                Me.lblExplicacao.Text = vbCrLf & "É o limite de crédito definido para todos os clientes para compras a prazo."
            Case "cboCasaDecimal"
                Me.lblExplicacao.Text = vbCrLf & "Indica qual a quantidade de casas decimais o cliente precisa nos campos Valor de Venda, Valor de Custo e Qtd."
            Case "cboTipoDesc"
                Me.lblExplicacao.Text = vbCrLf & "Seleciona se é desconto por Itens ou Total na tela de Venda."
            Case "memDescPedido"
                Me.lblExplicacao.Text = vbCrLf & "Acrescenta uma descrição para impressão nos pedidos."
            Case "memDescVenda"
                Me.lblExplicacao.Text = vbCrLf & "Acrescenta uma descrição para impressão nas vendas."
            Case "chkGerarComissao"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso a empresa deseje gerar comissão aos seus funcionários."
            Case "chkEstoqueZerado"
                Me.lblExplicacao.Text = vbCrLf & "Permite que seja vendido produtos com estoque zerado."
            Case "chkAltPrecoPed"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso deseje que seus funcionários alterem o preço dos produtos no pedido."
            Case "chkObsPedVenda"
                Me.lblExplicacao.Text = vbCrLf & "Habilita a impressão da Observação do Pedido na impressão da Venda."
            Case "chkAltNomePed"
                Me.lblExplicacao.Text = vbCrLf & "Altera o nome/descrição do produto no pedido."
            Case "chkAgruparProdutoVenda"
                Me.lblExplicacao.Text = vbCrLf & "Habilita o agrupamento de produtos na venda. O mesmo produto aparecerá em apenas uma linha na tela de venda e será acrescentando apenas na qtd se for adicionado mais de uma vez."
            Case "chkComandaPedido"
                Me.lblExplicacao.Text = vbCrLf & "Utiliza comandas no pedido."
            Case "chkAutorizacaoPedido"
                Me.lblExplicacao.Text = vbCrLf & "Assinatura do cliente na impressão de pedido ou venda."
            Case "chkObsClientePed"
                Me.lblExplicacao.Text = vbCrLf & "Ao habilitar a Observação do cliente será puxada para o pedido ao selecionar o cliente."
            Case "chkAlterarParcelas"
                Me.lblExplicacao.Text = vbCrLf & "Bloqueia a edição dos valores e datas no parcelamento de vendas e contas a receber."
            Case "chkPrecoEntNF"
                Me.lblExplicacao.Text = vbCrLf & "Atualiza o preço do produto pela entrada da Nota Fiscal."
            Case "chkMontarKit"
                Me.lblExplicacao.Text = vbCrLf & "Habilita a produção de Kit, com isso o sistema irá baixar os itens do kit no momento da produção e não da venda."
            Case "chkFiltroProdutoContem"
                Me.lblExplicacao.Text = vbCrLf & "Filtro com pesquisa no começo, meio e fim da frase na coluna nome do produto do cadastro de produto e consulta de produto."
            Case "chkBaixaPorLote"
                Me.lblExplicacao.Text = vbCrLf & "O controle do estoque será feito por lote ou caso o cliente venda seus produtos por tamanho Ex. lojas de roupas."
            Case "chkCompararFornecedor"
                Me.lblExplicacao.Text = vbCrLf & "Compara o Cód. do Fornecedor com o histórico de Entrada de Nota Fiscal e não com o Cód. Fornecedor do cadastro de Produto."
            Case "chkObsProduto"
                Me.lblExplicacao.Text = vbCrLf & "Libera o campo observação no cadastro de produto."
            Case "chkMediaCusto"
                Me.lblExplicacao.Text = vbCrLf & "Habilita o sistema para calcular o preço de custo dos produtos com a média dos preços de compra."
            Case "chkEstoqueSomado"
                Me.lblExplicacao.Text = vbCrLf & "O controle do estoque será por soma. Tudo que entra menos tudo que sai. (Sempre deve ser 'Somado' se o cliente não utilizar venda de produtos por tamanho)."
            Case "chkImpostoItem"
                Me.lblExplicacao.Text = vbCrLf & "O imposto será cobrado por item."
            Case "chkComissaoProd"
                Me.lblExplicacao.Text = vbCrLf & "Libera o campo 'Comissão' no cadastro de produto e configura o sistema para calcular a comissão dos vendedores por produto e não por funcionário."
            Case "chkAcresZero"
                Me.lblExplicacao.Text = vbCrLf & "Acrescentar zero no código de produto. (Isso é importante caso o cliente venha a gerar etiquetas de código de barra pelo sistema)."
            Case "chkManterPorcProd"
                Me.lblExplicacao.Text = vbCrLf & "Mantêm a porcentagem do produto. Se o valor de custo for alterado, a porcentagem concedida no valor de venda se mantêm."
            Case "chkManterMargemVenda"
                Me.lblExplicacao.Text = vbCrLf & "Mantêm a porcentagem do produto e recalcula o valor do produto."

            Case "txtPorcValAprox"
                Me.lblExplicacao.Text = vbCrLf & "Se o cliente desejar, informe uma taxa fixa para o valor aproximado dos tributos. (Se informado esse campo, o cálculo dos tributos será baseado nessa taxa e não na tabela de NCM's)."
            Case "cboModeloSAT"
                Me.lblExplicacao.Text = vbCrLf & "Modelo do SAT instalado."
            Case "txtEmailsArq"
                Me.lblExplicacao.Text = vbCrLf & "Informar o e-mail do contador para envio dos arquivos XML´s das NF-e´s e Sats/NFC-e´s emitidos."
            Case "txtPastaNotaNfe"
                Me.lblExplicacao.Text = vbCrLf & "Local de destino da NF-e , para onde os arquivos das NF-e's serão enviados. O caminho deverá ser = C:\NANONFe\Remessas"
            Case "txtPastaNFCe"
                Me.lblExplicacao.Text = vbCrLf & "Local de destino da NFC-e , para onde os arquivos das NFC-e's serão enviados. O caminho deverá ser = C:\NANONFCe\Remessas"
            Case "chkNanoNFe"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso deseje usar a NF-e."
            Case "chkPDV"
                Me.lblExplicacao.Text = vbCrLf & "Habilita a Função de PDV do Nano, isso limita as funções do sistema para o cliente."
            Case "chkSimplesNacional"
                Me.lblExplicacao.Text = vbCrLf & "Regime tributário simplificado."
            Case "chkTEF"
                Me.lblExplicacao.Text = vbCrLf & "Habilita o uso de TEF no sistema."
            Case "chkOlhoImposto"
                Me.lblExplicacao.Text = vbCrLf & "Selecione De olho no imposto, se NF-e Nano for selecionado."
            Case "chkNanoNFCe"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso deseje usar a NFC-e."
            Case "chkSATFiscal"
                Me.lblExplicacao.Text = vbCrLf & "Cupom Fiscal Eletrônico."
            Case "chkPAFECF"
                Me.lblExplicacao.Text = vbCrLf & "Emissão de Cupom Fiscal."
            Case "cboModeloCarne"
                Me.lblExplicacao.Text = vbCrLf & "Onde 0 é sem carne, 1 é carne em folha de impressão A4, 2 é carne via impressora de cupom."
            Case "cboImpCodBarra"
                Me.lblExplicacao.Text = vbCrLf & "Caso imprima código de barra, selecione o modelo da impressora de código de barra. Tais como: ARGOX OS-214 PLUS: Impressora Térmica de etiquetas e código de barra. Modelos de etiquetas no sistema: Dupla Grande, Dupla Média, Tripla Pequena, Tripla Mini e Tripla Média Argox. Se estiver em rede preencher com o caminho da rede da impressora mais o nome Ex:\\caixa\nomeimpressora , ou se não estiver em rede, colocar a porta de comunicação Ex: COM3. (Preencher a opção 19). ZEBRA TLP 2844: Impressora Térmica de etiquetas e código de barra. Modelo de etiqueta no sistema: Dupla Grande, Tripla Pequena e Gôndula. Se estiver em rede preencher com o caminho da rede da impressora mais o nome Ex:\\caixa\nomeimpressora , ou se não estiver em rede, colocar a porta de comunicação Ex: COM3. (Preencher a opção 19). SMART LABEL PRINTER 440: Impressora Térmica de etiquetas e código de barra. (Não utilizada). BEMA LB-1000: Impressora Térmica de etiquetas e código de barra. Se estiver em rede preencher com o caminho da rede da impressora mais o nome Ex:\\caixa\nomeimpressora , ou se não estiver em rede, colocar a porta de comunicação Ex: COM3. O sistema possui a etiqueta LB 1000 DUPLA, LB 1000 TRIPLA e LB 1000 GÔNDULA.(Preencher a opção 19). IMPRESSORA NORMAL: Impressora jato de tinta ou a laser, que pode ser usada para impressão de etiquetas e códigos de barra. Modelos de etiquetas no sistema: PIMACO A4348, PIMACO A4360 e PIMACO A5Q1219. (Deixar a opção 19 em branco)."
            Case "cboImpressora"
                Me.lblExplicacao.Text = vbCrLf & "Seleciona qual é o tipo da impressão. Tais como: DARUMA: Não usa porta, necessita por o nome do computador que está instalada a impressora (Opção 15). É configurada também pelo arquivo xml, neste arquivo é adicionado a porta localmente. BEMATECH MP-20: Modelo de impressora antiga, não é térmica e utiliza porta da impressora (COM, USB). Preencher o campo Nome Impressora.(Opção 17). BEMATECH MP-4000: Imprime via DLL, preencher o campo Nome Impressora Ex: COM3.(Opção 17). EPSON: Imprime via DLL, preencher o campo Nome Impressora Ex: COM3.(Opção 17). ARQUIVO: Usa impressora virtual, imprime e simula uma impressora, é mais utilizada em rede. NANO PRINT: Sistema de gerenciamento de impressões Nano (Fora de Uso). NANO PRINT ARQUIVO: Sistema de gerenciamento de impressões Nano (Fora de Uso). NANO PRINT ARQUIVO DIRETO: Sistema de gerenciamento de impressões Nano (Fora de Uso). ESC/POS DARUMA: Via Spooler, preencher com o nome da impressora Ex: DR700, se não for utilizada em rede. Ela gera ESC/POS, que são comandos de impressão. ESC/POS BEMATECH: Via Spooler, preencher com o nome da impressora Ex: MP-4200 TH, se não for utilizada em rede. Ela gera ESC/POS, que são comandos de impressão. ESC/POS EPSON: Via Spooler, preencher com o nome da impressora Ex: Epson TM-T20, se não for utilizada em rede. Ela gera ESC/POS , que são comandos de impressão. MATRICIAL: Impressora mais antiga, impressora de agulha. Se estiver em rede preencher o campo Nome Impressora (Opção 17) com o caminho de rede da impressora Ex:\\caixa\nomeimpressora."
            Case "txtNomeImpressora"
                Me.lblExplicacao.Text = vbCrLf & "Nome Impressora ou Porta Impressora: Três possibilidades: 1 - Caminho de rede da impressora Ex: \\caixa\nomeimpressora. 2 - Porta de comunicação com a impressora Ex: COM3 (Deve ser preenchido assim quando a impressora for utilizada via DLL). 3 - Nome da impressora Ex: MP-4200 TH (Deve ser preenchido assim quando a opção 16 acima estiver selecionada com alguma impressão do tipo ESC/POS e a impressora não for utilizada em rede)."
            Case "txtNomePCImpressora"
                Me.lblExplicacao.Text = vbCrLf & "Local onde está a impressora. (Só precisa informar quando a impressora for Daruma e estiver sendo utilizada por DLL)."
            Case "txtPortaImpCodBarra"
                Me.lblExplicacao.Text = vbCrLf & "Caminho de rede que está a impressora de código de barra. (Porta de comunicação com a impressora de código de barra)."
            Case "chkTemImpressora"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso tenha impressora."
            Case "chkImprimirDireto"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso deseje imprimir direto sem fazer pergunta. Se desmarcado o sistema irá sempre perguntar se o usuário deseja fazer a impressão."
            Case "chkTemGuilhotina"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso a impressora tenha Guilhotina."
            Case "chkImpPedCompleto"
                Me.lblExplicacao.Text = vbCrLf & "Imprime o pedido completo. (Com todos os dados do cliente)."
            Case "chkTemGaveta"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso tenha Gaveta."
            Case "chkImpComanda"
                Me.lblExplicacao.Text = vbCrLf & "Imprime comanda ao finalizar a comanda."
            Case "chk2ViaRecibo"
                Me.lblExplicacao.Text = vbCrLf & "Impressão de 2ª via de todas as impressões não fiscais."
            Case "chkImprimeContaPagar"
                Me.lblExplicacao.Text = vbCrLf & "Imprime o comprovante da conta baixada no Contas a Pagar."
            Case "chkCodigoBarraCupom"
                Me.lblExplicacao.Text = vbCrLf & "Selecione caso deseje o código de barra no cupom."
            Case "chkTotalEconomizado"
                Me.lblExplicacao.Text = vbCrLf & "Habilita a impressão do valor sem desconto e com desconto dos produtos no cupom não fiscal da venda e também o valor economizado."
            Case "chkImpPadrao"
                Me.lblExplicacao.Text = vbCrLf & "Impressão Padrão para o pedido com dados do veiculo para Tipo Nano 5 e dados da entraga para os Tipo Nano 0,1,2,3,4."
            Case "chkTemBalanca"
                Me.lblExplicacao.Text = vbCrLf & "Habilita o uso de balança no sistema."
            Case "cboTipoBalanca"
                Me.lblExplicacao.Text = vbCrLf & "Selecione o modelo da balança."
            Case "cboBalancaPor"
                Me.lblExplicacao.Text = vbCrLf & "Seleciona se é por quantidade ou valor a leitura da etiqueta gerada pela balança."
            Case "chkMoto"
                Me.lblExplicacao.Text = vbCrLf & "Habilite caso o cliente seja uma moto peças."
            Case "chkFuni"
                Me.lblExplicacao.Text = vbCrLf & "Habilite caso o cliente seja uma funilaria."
            Case "chkSemCarro"
                Me.lblExplicacao.Text = vbCrLf & "Possibilita que a Pedido seja feito sem informar o veículo e também permite digitar os dados do veículo na tela de pedido, sem a necessidade de cadastrar o veículo."

        End Select
    End Sub


    Private Sub txtNome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.GotFocus
        Explicacao(Me.txtNome.Name)
    End Sub


    Private Sub txtDescricao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescricao.GotFocus
        Explicacao(Me.txtDescricao.Name)
    End Sub

    Private Sub txtCNPJ_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.GotFocus
        Explicacao(Me.txtCNPJ.Name)
    End Sub

    Private Sub txtEnd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnd.GotFocus
        Explicacao(Me.txtEnd.Name)
    End Sub

    Private Sub txtCidade_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCidade.GotFocus
        Explicacao(Me.txtCidade.Name)
    End Sub

    Private Sub cboUF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUF.GotFocus
        Explicacao(Me.cboUF.Name)
    End Sub

    Private Sub txtTel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTel.GotFocus
        Explicacao(Me.txtTel.Name)
    End Sub

    Private Sub imgLogo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLogo.MouseEnter
        Explicacao(Me.imgLogo.Name)
    End Sub

    Private Sub cboTipoNano_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoNano.GotFocus
        Explicacao(Me.cboTipoNano.Name)
    End Sub

    Private Sub cboSetor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSetor.GotFocus
        Explicacao(Me.cboSetor.Name)
    End Sub

    Private Sub cboTabelaPreco_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Explicacao(Me.cboTabelaPreco.Name)
    End Sub

    Private Sub cboCPFCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCPFCliente.GotFocus
        Explicacao(Me.cboCPFCliente.Name)
    End Sub

    Private Sub txtVersaoNano_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVersaoNano.GotFocus
        Explicacao(Me.txtVersaoNano.Name)
    End Sub

    Private Sub txtPastaBoleto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPastaBoleto.GotFocus
        Explicacao(Me.txtPastaBoleto.Name)
    End Sub

    Private Sub txtServidor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtServidor.GotFocus
        Explicacao(Me.txtServidor.Name)
    End Sub

    Private Sub chkMensalista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMensalista.GotFocus
        Explicacao(Me.chkMensalista.Name)
    End Sub

    Private Sub chkValidarCep_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValidarCep.GotFocus
        Explicacao(Me.chkValidarCep.Name)
    End Sub

    Private Sub chkVincularUser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkVincularUser.GotFocus
        Explicacao(Me.chkVincularUser.Name)
    End Sub

    Private Sub chkValidarCPF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValidarCPF.GotFocus
        Explicacao(Me.chkValidarCPF.Name)
    End Sub

    Private Sub chkSenhaAdm_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSenhaAdm.GotFocus
        Explicacao(Me.chkSenhaAdm.Name)
    End Sub

    Private Sub chkVisTrocoCaixa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkVisTrocoCaixa.GotFocus
        Explicacao(Me.chkVisTrocoCaixa.Name)
    End Sub

    Private Sub chkDezPorcento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDezPorcento.GotFocus
        Explicacao(Me.chkDezPorcento.Name)
    End Sub

    Private Sub chkUsarBoleto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUsarBoleto.GotFocus
        Explicacao(Me.chkUsarBoleto.Name)
    End Sub

    Private Sub chkVisCobranca_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkVisCobranca.GotFocus
        Explicacao(Me.chkVisCobranca.Name)
    End Sub

    Private Sub chkAltDataCaixa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAltDataCaixa.GotFocus
        Explicacao(Me.chkAltDataCaixa.Name)
    End Sub

    Private Sub txtTolerancia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTolerancia.GotFocus
        Explicacao(Me.txtTolerancia.Name)
    End Sub

    Private Sub txtJuros_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJuros.GotFocus
        Explicacao(Me.txtJuros.Name)
    End Sub

    Private Sub txtDescontoMaximo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescontoMaximo.GotFocus
        Explicacao(Me.txtDescontoMaximo.Name)
    End Sub

    Private Sub txtJurosParcela_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJurosParcela.GotFocus
        Explicacao(Me.txtJurosParcela.Name)
    End Sub

    Private Sub txtCredito_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCredito.GotFocus
        Explicacao(Me.txtCredito.Name)
    End Sub

    Private Sub cboCasaDecimal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCasaDecimal.GotFocus
        Explicacao(Me.cboCasaDecimal.Name)
    End Sub

    Private Sub cboTipoDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoDesc.GotFocus
        Explicacao(Me.cboTipoDesc.Name)
    End Sub

    Private Sub memDescPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles memDescPedido.GotFocus
        Explicacao(Me.memDescPedido.Name)
    End Sub

    Private Sub memDescVenda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles memDescVenda.GotFocus
        Explicacao(Me.memDescVenda.Name)
    End Sub

    Private Sub chkGerarComissao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGerarComissao.GotFocus
        Explicacao(Me.chkGerarComissao.Name)
    End Sub

    Private Sub chkEstoqueZerado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEstoqueZerado.GotFocus
        Explicacao(Me.chkEstoqueSomado.Name)
    End Sub

    Private Sub chkAltPrecoPed_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAltPrecoPed.GotFocus
        Explicacao(Me.chkAltPrecoPed.Name)
    End Sub

    Private Sub chkObsPedVenda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkObsPedVenda.GotFocus
        Explicacao(Me.chkObsPedVenda.Name)
    End Sub

    Private Sub chkAltNomePed_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAltNomePed.GotFocus
        Explicacao(Me.chkAltNomePed.Name)
    End Sub

    Private Sub chkAgruparProdutoVenda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAgruparProdutoVenda.GotFocus
        Explicacao(Me.chkAgruparProdutoVenda.Name)
    End Sub

    Private Sub chkComandaPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkComandaPedido.GotFocus
        Explicacao(Me.chkComandaPedido.Name)
    End Sub

    Private Sub chkAutorizacaoPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAutorizacaoPedido.GotFocus
        Explicacao(Me.chkAutorizacaoPedido.Name)
    End Sub

    Private Sub chkObsClientePed_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkObsClientePed.GotFocus
        Explicacao(Me.chkObsClientePed.Name)
    End Sub

    Private Sub chkAlterarParcelas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAlterarParcelas.GotFocus
        Explicacao(Me.chkAlterarParcelas.Name)
    End Sub

    Private Sub chkPrecoEntNF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPrecoEntNF.GotFocus
        Explicacao(Me.chkPrecoEntNF.Name)
    End Sub

    Private Sub chkMontarKit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMontarKit.GotFocus
        Explicacao(Me.chkMontarKit.Name)
    End Sub

    Private Sub chkBaixaPorLote_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBaixaPorLote.GotFocus
        Explicacao(Me.chkBaixaPorLote.Name)
    End Sub

    Private Sub chkCompararFornecedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCompararFornecedor.GotFocus
        Explicacao(Me.chkCompararFornecedor.Name)
    End Sub

    Private Sub chkObsProduto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkObsProduto.GotFocus
        Explicacao(Me.chkObsProduto.Name)
    End Sub

    Private Sub chkMediaCusto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMediaCusto.GotFocus
        Explicacao(Me.chkMediaCusto.Name)
    End Sub

    Private Sub chkEstoqueSomado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEstoqueSomado.GotFocus
        Explicacao(Me.chkEstoqueSomado.Name)
    End Sub

    Private Sub chkImpostoItem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkImpostoItem.GotFocus
        Explicacao(Me.chkImpostoItem.Name)
    End Sub

    Private Sub chkComissaoProd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkComissaoProd.GotFocus
        Explicacao(Me.chkComissaoProd.Name)
    End Sub

    Private Sub chkAcresZero_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAcresZero.GotFocus
        Explicacao(Me.chkAcresZero.Name)
    End Sub

    Private Sub chkManterPorcProd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkManterPorcProd.GotFocus
        Explicacao(Me.chkManterPorcProd.Name)
    End Sub

    Private Sub txtPorcValAprox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcValAprox.GotFocus
        Explicacao(Me.txtPorcValAprox.Name)
    End Sub

    Private Sub cboModeloSAT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboModeloSAT.GotFocus
        Explicacao(Me.cboModeloSAT.Name)
    End Sub

    Private Sub txtEmailsArq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmailsArq.GotFocus
        Explicacao(Me.txtEmailsArq.Name)
    End Sub

    Private Sub txtPastaNotaNfe_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPastaNotaNfe.GotFocus
        Explicacao(Me.txtPastaNotaNfe.Name)
    End Sub

    Private Sub txtPastaNFCe_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPastaNFCe.GotFocus
        Explicacao(Me.txtPastaNFCe.Name)
    End Sub

    Private Sub chkNanoNFe_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNanoNFe.GotFocus
        Explicacao(Me.chkNanoNFe.Name)
    End Sub

    Private Sub chkPDV_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPDV.GotFocus
        Explicacao(Me.chkPDV.Name)
    End Sub

    Private Sub chkSimplesNacional_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSimplesNacional.GotFocus
        Explicacao(Me.chkSimplesNacional.Name)
    End Sub

    Private Sub chkTEF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTEF.GotFocus
        Explicacao(Me.chkTEF.Name)
    End Sub

    Private Sub chkOlhoImposto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOlhoImposto.GotFocus
        Explicacao(Me.chkOlhoImposto.Name)
    End Sub

    Private Sub chkNanoNFCe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNanoNFCe.CheckedChanged
        Explicacao(Me.chkNanoNFCe.Name)
    End Sub

    Private Sub chkSATFiscal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSATFiscal.GotFocus
        Explicacao(Me.chkSATFiscal.Name)
    End Sub

    Private Sub chkPAFECF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPAFECF.GotFocus
        Explicacao(Me.chkPAFECF.Name)
    End Sub

    Private Sub cboModeloCarne_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboModeloCarne.GotFocus
        Explicacao(Me.cboModeloCarne.Name)
    End Sub

    Private Sub cboImpCodBarra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboImpCodBarra.GotFocus
        Explicacao(Me.cboImpCodBarra.Name)
    End Sub

    Private Sub cboImpressora_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboImpressora.GotFocus
        Explicacao(Me.cboImpressora.Name)
    End Sub

    Private Sub txtNomeImpressora_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomeImpressora.GotFocus
        Explicacao(Me.txtNomeImpressora.Name)
    End Sub

    Private Sub txtNomePCImpressora_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomePCImpressora.GotFocus
        Explicacao(Me.txtNomePCImpressora.Name)
    End Sub

    Private Sub txtPortaImpCodBarra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPortaImpCodBarra.GotFocus
        Explicacao(Me.txtPortaImpCodBarra.Name)
    End Sub

    Private Sub chkTemImpressora_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTemImpressora.GotFocus
        Explicacao(Me.chkTemImpressora.Name)
    End Sub

    Private Sub chkImprimirDireto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkImprimirDireto.GotFocus
        Explicacao(Me.chkImprimirDireto.Name)
    End Sub

    Private Sub chkTemGuilhotina_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTemGuilhotina.GotFocus
        Explicacao(Me.chkTemGuilhotina.Name)
    End Sub

    Private Sub chkImpPedCompleto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkImpPedCompleto.GotFocus
        Explicacao(Me.chkImpPedCompleto.Name)
    End Sub

    Private Sub chkTemGaveta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTemGaveta.GotFocus
        Explicacao(Me.chkTemGaveta.Name)
    End Sub

    Private Sub chkImpComanda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkImpComanda.GotFocus
        Explicacao(Me.chkImpComanda.Name)
    End Sub

    Private Sub chk2ViaRecibo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk2ViaRecibo.GotFocus
        Explicacao(Me.chk2ViaRecibo.Name)
    End Sub

    Private Sub chkImprimeContaPagar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkImprimeContaPagar.GotFocus
        Explicacao(Me.chkImprimeContaPagar.Name)
    End Sub

    Private Sub chkCodigoBarraCupom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCodigoBarraCupom.GotFocus
        Explicacao(Me.chkCodigoBarraCupom.Name)
    End Sub

    Private Sub chkTotalEconomizado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTotalEconomizado.GotFocus
        Explicacao(Me.chkTotalEconomizado.Name)
    End Sub
    Private Sub chkFiltroProdutoContem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFiltroProdutoContem.GotFocus
        Explicacao(Me.chkFiltroProdutoContem.Name)
    End Sub
    Private Sub chkImpPadrao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkImpPadrao.GotFocus
        Explicacao(Me.chkImpPadrao.Name)
    End Sub

    Private Sub chkTemBalanca_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTemBalanca.GotFocus
        Explicacao(Me.chkTemBalanca.Name)
    End Sub

    Private Sub cboTipoBalanca_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoBalanca.GotFocus
        Explicacao(Me.cboTipoBalanca.Name)
    End Sub

    Private Sub cboBalancaPor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBalancaPor.GotFocus
        Explicacao(Me.cboBalancaPor.Name)
    End Sub

    Private Sub cboTipoNano_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoNano.SelectedIndexChanged
        'Me.chkImpPadrao.Checked = False
        'Me.chkImpPedCompleto.Checked = False
        Select Case Me.cboTipoNano.Text
            Case 5
                Me.pnlAutomotivo.Enabled = True

            Case Else

                Me.pnlAutomotivo.Enabled = False
                Me.chkFuni.Checked = False
                Me.chkMoto.Checked = False
                Me.chkSemCarro.Checked = False
        End Select
    End Sub

    Private Sub chkMoto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMoto.GotFocus
        Explicacao(Me.chkMoto.Name)
    End Sub

    Private Sub chkFuni_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFuni.GotFocus
        Explicacao(Me.chkFuni.Name)
    End Sub

    Private Sub chkSemCarro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSemCarro.GotFocus
        Explicacao(Me.chkSemCarro.Name)
    End Sub

    Private Sub btnImgApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImgApp.Click
        frmImgAPP.ShowDialog()
    End Sub

    'Private Sub chkImpPadrao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImpPadrao.CheckedChanged
    '    Me.chkImpPedCompleto.Checked = False
    '    Select Case Me.chkImpPadrao.Checked
    '        Case True
    '            Me.chkImpPedCompleto.Enabled = False
    '        Case False
    '            Me.chkImpPedCompleto.Enabled = True
    '    End Select
    'End Sub
End Class