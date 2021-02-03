Imports Nano.clsFuncoes
Public Class frmRelLog
    Dim strFiltro As String = ""

    Private Sub frmRelLog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
       If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "57")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmRelLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        If EstoqueSomado = True Then
            strFiltro = " where Tabela <> 'QTDE'"
        Else
            strFiltro = " where Coluna <> 'QTDE AJUSTE'"
        End If
        If Master = False Then
            strFiltro &= " and Log.CodConfig =" & CodConfig
        End If

      
        CarregarDados("SELECT Log.Codigo, Data, CodUser, Usuario.Nome as Usuario, Antigo, Novo, Coluna, Tabela, Motivo, Log.CodConfig FROM Log inner join Usuario on Log.CodUser = Usuario.Codigo" & strFiltro, Me.GridControl1)

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

        If TesteConexao() = False Then Exit Sub
        If EstoqueSomado = True Then
            strFiltro = " and Tabela <> 'QTDE'"
        Else
            strFiltro = " and Coluna <> 'QTDE AJUSTE'"
        End If
        If Master = False Then
            strFiltro &= " and Log.CodConfig =" & CodConfig
        End If
        Dim strData As String
        strData = String.Format("Convert(smalldatetime, Data) >= '{0:dd/MM/yyyy}' AND Convert(smalldatetime, Data) <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, dataFim.AddDays(1))

        CarregarDados("SELECT Log.Codigo, Data, CodUser, Usuario.Nome as Usuario, Antigo, Novo, Coluna, Tabela, Motivo FROM Log inner join Usuario on Log.CodUser = Usuario.Codigo where " & strData & strFiltro, Me.GridControl1)
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRelLog_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelLog.ItemClick
        Dim rel As New relLog
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo
        With rel.tbRelLog.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Usuario") = grd1.GetRowCellDisplayText(I, Me.colUsuario)
                .Item(I).Item("Antigo") = grd1.GetRowCellDisplayText(I, Me.colAntigo)
                .Item(I).Item("Novo") = grd1.GetRowCellDisplayText(I, Me.colNovo)
                .Item(I).Item("Coluna") = grd1.GetRowCellDisplayText(I, Me.colColuna)
                .Item(I).Item("Tabela") = grd1.GetRowCellDisplayText(I, Me.colTabela)
                .Item(I).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
            Next
            rel.ShowPreview()
        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
End Class