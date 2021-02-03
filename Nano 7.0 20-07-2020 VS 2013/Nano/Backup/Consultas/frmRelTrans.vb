Imports Nano.clsFuncoes
Public Class frmRelTrans
    Dim strFiltro As String = ""

    Private Sub frmRelTrans_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    If Me.Tag = "ENVIADA" Then
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "53")
                    Else
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "54")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)

        Me.colCodConfig.Visible = Master

        If Master = False Then
            strFiltro = " and Transferencia.CodConfig =" & CodConfig
        End If

        If Me.Tag = "ENVIADA" Then
            CarregarDados("SELECT Transferencia.Codigo, Transferencia.Lote , Transferencia.CodOrdem, Transferencia.Data, Transferencia.CodProd, Convert(Numeric(15,2),Transferencia.Qtd) as Qtd, Convert(Numeric(15,2),Transferencia.ValorCusto) as Custo, Transferencia.Tamanho, Convert(Numeric(15,2),(Transferencia.Qtd * Transferencia.ValorCusto)) as ValorCusto, Transferencia.CodLoja, Transferencia.CodUserSaida, Produto.CodigoInterno, Produto.Nome as Produto, Config.Descricao as Loja, Usuario.Nome as Usuario, Transferencia.CodConfig FROM ((Transferencia left join Produto on Transferencia.CodProd = Produto.Codigo) left join Config on Transferencia.CodLoja = Config.Codigo) left join Usuario on Transferencia.CodUserSaida = Usuario.Codigo where Status <> 'Pendente' and EntSai = 'S'" & strFiltro, Me.GridControl1)
            Me.Text = "Relatório de Transferências Enviadas"

            Me.colCodConfig.Caption = "Loja Enviou"
            Me.colLoja.Caption = "Loja Enviada"
        Else
            CarregarDados("SELECT Transferencia.Codigo, Transferencia.Lote , Transferencia.CodOrdem, Transferencia.Data, Transferencia.CodProd, Convert(Numeric(15,2),Transferencia.Qtd) as Qtd, Convert(Numeric(15,2),Transferencia.ValorCusto) as Custo, Transferencia.Tamanho, Convert(Numeric(15,2),(Transferencia.Qtd * Transferencia.ValorCusto)) as ValorCusto, Transferencia.CodLoja, Transferencia.CodUserSaida, Produto.CodigoInterno, Produto.Nome as Produto, Config.Descricao as Loja, Usuario.Nome as Usuario, Transferencia.CodConfig FROM ((Transferencia left join Produto on Transferencia.CodProd = Produto.Codigo) left join Config on Transferencia.Codloja = Config.Codigo) left join Usuario on Transferencia.CodUserEntrada = Usuario.Codigo where Status <> 'Pendente' and EntSai = 'E'" & strFiltro, Me.GridControl1)
            Me.Text = "Relatório de Transferências Recebidas"
            Me.colCodConfig.Caption = "Loja Recebeu"
            Me.colLoja.Caption = "Loja Enviou"
        End If

    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim strData As String
        strData = String.Format("Transferencia.Data >= '{0:dd/MM/yyyy}' AND Transferencia.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        If Me.Tag = "ENVIADA" Then
            CarregarDados("SELECT Transferencia.Codigo, Transferencia.Lote , Transferencia.CodOrdem, Transferencia.Data, Transferencia.CodProd, Convert(Numeric(15,2),Transferencia.Qtd) as Qtd, Convert(Numeric(15,2),Transferencia.ValorCusto) as Custo, Transferencia.Tamanho, Convert(Numeric(15,2),(Transferencia.Qtd * Transferencia.ValorCusto)) as ValorCusto, Transferencia.CodLoja, Transferencia.CodUserSaida, Produto.CodigoInterno, Produto.Nome as Produto, Config.Descricao as Loja, Usuario.Nome as Usuario, Transferencia.CodConfig  FROM ((Transferencia left join Produto on Transferencia.CodProd = Produto.Codigo) left join Config on Transferencia.CodLoja = Config.Codigo) left join Usuario on Transferencia.CodUserSaida = Usuario.Codigo where Status <> 'Pendente' and EntSai = 'S' and " & strData & strFiltro, Me.GridControl1)
        Else
            CarregarDados("SELECT Transferencia.Codigo, Transferencia.Lote , Transferencia.CodOrdem, Transferencia.Data, Transferencia.CodProd, Convert(Numeric(15,2),Transferencia.Qtd) as Qtd, Convert(Numeric(15,2),Transferencia.ValorCusto) as Custo, Transferencia.Tamanho, Convert(Numeric(15,2),(Transferencia.Qtd * Transferencia.ValorCusto)) as ValorCusto, Transferencia.CodLoja, Transferencia.CodUserSaida, Produto.CodigoInterno, Produto.Nome as Produto, Config.Descricao as Loja, Usuario.Nome as Usuario, Transferencia.CodConfig FROM ((Transferencia left join Produto on Transferencia.CodProd = Produto.Codigo) left join Config on Transferencia.CodLoja = Config.Codigo) left join Usuario on Transferencia.CodUserEntrada = Usuario.Codigo where Status <> 'Pendente' and EntSai = 'E' and " & strData & strFiltro, Me.GridControl1)
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRelTra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelTra.ItemClick
        Dim rel As New relTrans
        rel.picLogo.Image = LogoTipo
        rel.lblTitulo.Text = Me.Text

        Dim I As Integer

        With rel.tbTrans.Rows

            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("CodigoInterno") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("ValorCusto") = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                .Item(I).Item("Loja") = Me.grd1.GetRowCellDisplayText(I, Me.colLoja)
                .Item(I).Item("Usuario") = Me.grd1.GetRowCellDisplayText(I, Me.colUsuario)
                .Item(I).Item("Lote") = Me.grd1.GetRowCellDisplayText(I, Me.colLote)
            Next
        End With


        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
End Class