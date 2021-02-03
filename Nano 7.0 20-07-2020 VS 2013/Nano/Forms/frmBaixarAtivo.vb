Imports Nano.clsFuncoes
Imports Nano.clsDarBaixa
Imports Nano.clsGerarArqs
Imports System.Globalization
Imports System
Imports System.IO
Imports System.Math
Imports Nano.clsFuncoesBematech
Public Class frmBaixarAtivo
   
    Dim dtProduto As DataTable
    Dim intCont As Integer
  
    Private Sub frmVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        Me.lblOper.Caption = Dir(UserNano, 60)

        Timer1.Start()

    End Sub

    Private Sub frmVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
  
        If e.KeyCode = Keys.F3 Then
            Finalizar()
        End If

    End Sub

    Private Sub InserirProduto(ByVal parPesquisaPorNome As Boolean, ByVal parConsignacao As Boolean, Optional ByVal parTamanho As String = "", Optional ByVal parComanda As Boolean = False, Optional ByVal parPreco As Double = 0)

        Dim dtProd As DataTable

        If parPesquisaPorNome = False Then
            If Me.txtCodPro.Text.Trim = "" Then Exit Sub

            dtProd = CarregarDataTable("Select AtivoConsig.CodOrdens, AtivoConsig.Codigo, AtivoConsig.Nome, " & _
            "AtivoConsig.CodPadrao, convert(Varchar(10),AtivoConsig.Vencimento,103) as Vencimento, AtivoConsig.Status, " & _
            "ItensConsig.Produto from AtivoConsig left join ItensConsig on AtivoConsig.CodPedAut = ItensConsig.Codigo " & _
            "and AtivoConsig.CodConfig = ItensConsig.CodConfig where AtivoConsig.CodPadrao = '" & Me.txtCodPro.Text.Trim & "' " & _
            "and AtivoConsig.CodConfig = " & CodConfig)

        Else
            dtProd = CarregarDataTable("Select AtivoConsig.CodOrdens, AtivoConsig.Codigo, AtivoConsig.Nome, " & _
            "AtivoConsig.CodPadrao, convert(Varchar(10),AtivoConsig.Vencimento,103) as Vencimento, AtivoConsig.Status, " & _
            "ItensConsig.Produto from AtivoConsig left join ItensConsig on AtivoConsig.CodPedAut = ItensConsig.Codigo " & _
            "and AtivoConsig.CodConfig = ItensConsig.CodConfig where AtivoConsig.Codigo = '" & CodigoAtivo & "' " & _
            "and AtivoConsig.CodConfig = " & CodConfig)

            If dtProd.Rows.Count > 0 Then
                Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodPadrao")
            End If
        End If


        Dim I As Integer
        For I = 0 To Me.grd1.RowCount - 1
            Dim strCPadrao As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodPadrao)
            If strCPadrao = Me.txtCodPro.Text.Trim Then
                MsgBox("Ativo já adicionado!", MsgBoxStyle.Information)
                Me.txtCodPro.ResetText()
                Exit Sub
            End If
        Next
        If dtProd.Rows.Count > 0 Then
            intCont = 0
            Dim strStatus As String = dtProd.Rows.Item(0).Item("Status").ToString

            If strStatus = "Devolvido" Then MsgBox("Ativo já develvido!", MsgBoxStyle.Information) : Me.txtCodPro.ResetText() : Exit Sub

            Dim strCodOrdens As String = dtProd.Rows.Item(0).Item("CodOrdens").ToString
            Dim strCliente As String = ""
            Me.txtProd.Text = dtProd.Rows.Item(0).Item("Nome").ToString
            With Me.tbItens.Rows
                .Add()

                .Item(.Count - 1).Item("Codigo") = dtProd.Rows.Item(0).Item("Codigo").ToString
                .Item(.Count - 1).Item("CodOrdem") = strCodOrdens
                .Item(.Count - 1).Item("CodPadrao") = dtProd.Rows.Item(0).Item("CodPadrao").ToString
                .Item(.Count - 1).Item("Descricao") = dtProd.Rows.Item(0).Item("Nome").ToString
                .Item(.Count - 1).Item("Produto") = dtProd.Rows.Item(0).Item("Produto").ToString
                .Item(.Count - 1).Item("Vencimento") = dtProd.Rows.Item(0).Item("Vencimento").ToString
                Dim dtCli As DataTable = CarregarDataTable("SELECT Nome FROM Totalconsig left join Cliente " & _
                "on TotalConsig.CodCli = Cliente.Codigo where CodOrdens = " & strCodOrdens & " and TotalConsig.CodConfig = " & CodConfig)

                If dtCli.Rows.Count > 0 Then
                    strCliente = dtCli.Rows.Item(0).Item("Nome").ToString
                End If
                .Item(.Count - 1).Item("Cliente") = strCliente
            End With
        Else
            Me.txtProd.Text = "INEXISTENTE"
            Me.txtCodPro.ResetText()
            Exit Sub
        End If

        'CALCULOS ANTES DE ADICIONAR


        Me.picFundo.Visible = False

        Me.txtCodPro.Tag = ""
        Me.txtCodPro.ResetText()

        intCont = 0

        Calcular()

    End Sub
   
    Private Sub Calcular()

        Me.grpItens.Text = "Nº Itens : " & Me.grd1.RowCount & " "

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If intCont = 10 Then
            Me.txtProd.ResetText()
        End If

        intCont += 1
        Me.lblHora.Caption = My.Computer.Clock.LocalTime
    End Sub

    Private Sub txtCodPro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodPro.KeyDown
        If e.KeyCode = Keys.F10 Then
            Dim frm As New frmConAtivos
            frm.Tag = "BAIXA"
            CodigoAtivo = ""
            frm.ShowDialog()
            If CodigoAtivo = "" Then Exit Sub
            InserirProduto(True, False)
        End If

        If e.KeyCode = Keys.Enter Then
            If Me.txtCodPro.Text.Trim = "" Then
                Me.txtProd.Focus()
                Exit Sub
            End If

            InserirProduto(False, False)

        End If
    End Sub

    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If Me.grd1.RowCount = 0 Then Exit Sub

        If MsgBox("Deseja realmente excluir o item selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.grd1.DeleteRow(grd1.FocusedRowHandle)
            Calcular()
        End If

        If Me.grd1.RowCount = 0 Then
            Me.picFundo.Visible = True
        End If
        Me.txtCodPro.Focus()
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If grd1.RowCount = 0 Then Exit Sub
        If MsgBox("Deseja realmente CANCELAR a baixa atual?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If MsgBox("Você tem certeza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Limpar()
            End If
        End If
    End Sub

    Private Sub Limpar()
        Me.picFundo.Visible = True
        intCont = 0
        Me.txtCodPro.ResetText()
        Me.txtProd.ResetText()
        Me.tbItens.Rows.Clear()
        Me.grpItens.Text = "Nº de Itens: 0 "
        Me.txtCodPro.Focus()
    End Sub

    Private Sub btnFinalizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFinalizar.ItemClick

        If TesteConexao() = False Then Exit Sub

        Finalizar()
    End Sub

    Private Sub Finalizar()

        If Me.grd1.RowCount = 0 Then Exit Sub

        Dim I As Integer

        For I = 0 To Me.grd1.RowCount - 1

            Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)

            Atualizar("UPDATE AtivoConsig SET Status = 'Devolvido' where Codigo = " & strCodigo & " and CodConfig = " & CodConfig)

        Next

        MsgBox("Barril/Chopeira baixados com sucesso!", MsgBoxStyle.Information)

        If MsgBox("Deseja imprimir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Imprimir("Devolvido")
        End If
        Limpar()

    End Sub

    Private Sub Imprimir(ByVal parStatus As String)
        Dim rel As New relAtivo

        rel.picLogo.Image = LogoTipo

        With rel.tbItens.Rows
            Dim I As Integer

            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("CodPadrao") = Me.grd1.GetRowCellDisplayText(I, Me.colCodPadrao)
                .Item(I).Item("Descricao") = Me.grd1.GetRowCellDisplayText(I, Me.colDescricao)
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("Vencimento") = Me.grd1.GetRowCellDisplayText(I, Me.colVencimento)
                .Item(I).Item("Status") = parStatus
            Next

        End With

        rel.ShowPreview()
    End Sub

   Private Sub btnRelVend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelVend.ItemClick
        Imprimir("Entregue")
    End Sub

End Class