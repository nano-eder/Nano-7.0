Imports Nano.clsFuncoes
Public Class frmRelProdTamanho
    Dim A As Integer = 5
    Dim bolFiltro As Boolean = False
    Private Sub frmRelProdTamanho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.nbcAvisos.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        Dim dtGrupo As DataTable = CarregarDataTable("SELECT Nome FROM Grupo where Tipo = 'G'")
        Dim I As Integer
        With Me.tbGrupo.Rows
            For I = 0 To dtGrupo.Rows.Count - 1
                .Add()
                .Item(.Count - 1).Item("Grupo") = dtGrupo.Rows.Item(I).Item("Nome").ToString
                .Item(.Count - 1).Item("Ok") = True


            Next
        End With
        Me.chkTupo.Checked = True
        ' Me.nbcAvisos.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        If Me.Tag = "ESTOQUE" Then
            Me.dtFinal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.dtInicial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnFiltrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.Text = Me.Text & " Vendidos"
        End If
        AtualizarGrid("")

    End Sub
    Private Sub AtualizarGrid(ByVal parcondicao As String)

        'Dim dt As DataTable = CarregarDataTable("SELECT Nome, Fabricante, Setor, Grupo, convert(Numeric(15),sum(Qtd)) as Qtd " & _
        '"FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' and Qtde.CodConfig = " & CodConfig & _
        '"" & parcondicao & " GROUP BY Nome, Fabricante, Setor, Grupo order by Nome")

        Dim dt As DataTable
        If Me.Tag = "ESTOQUE" Then
            dt = CarregarDataTable("SELECT Nome, Fabricante, Setor, Grupo, convert(Numeric(15),sum(Qtd)) as Qtd " & _
     "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' and Qtde.CodConfig = " & CodConfig & _
     "" & parcondicao & " GROUP BY Nome, Fabricante, Setor, Grupo order by Nome")

        Else
            dt = CarregarDataTable("SELECT Pedido.Produto as Nome, Produto.Fabricante, Produto.Setor, Produto.Grupo, convert(Numeric(15),sum(Pedido.Qtd)) as Qtd " & _
        "FROM (Pedido left join Produto on Pedido.CodProd = Produto.Codigo) left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = total.CodConfig where Produto.Inativo = 'False' and Pedido.CodConfig = " & CodConfig & _
        "" & parcondicao & " GROUP BY Pedido.Produto, Fabricante, Setor, Grupo order by Nome")
        End If

   
        Dim bolLoad As Boolean = True
        If parcondicao <> "" Then
            bolLoad = False
        End If


        Dim I As Integer
        Me.tbProd.Rows.Clear()
        Dim strDesc As String = ""
        Dim strTamanhoQtde As String = ""
        With Me.tbProd.Rows


            For I = 0 To dt.Rows.Count - 1

                Dim strProduto As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString
                Dim strSetor As String = dt.Rows.Item(I).Item("Setor").ToString
                If strSetor = "NULL" Then
                    strSetor = ""
                End If
                Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString

                Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString

                Dim vetProduto As Array = Split(strProduto, "-")

                Dim strDescricao As String = ""
                Dim strTam As String = ""
                Select Case vetProduto.Length
                    Case 1
                        'strTam = Dir("Tam.: -", 12) & Dir("Qtd: " & strQtd, 15)
                        strTam = "-"

                        strDescricao = vetProduto(0).ToString.Trim
                    Case 2
                        'If VerificaTamanho(vetProduto(1).ToString.Trim) = True Then
                        ' strTam = Dir("Tam.: " & vetProduto(1).ToString.Trim, 12) & Dir("Qtd: " & strQtd, 15)
                        strTam = vetProduto(1).ToString.Trim

                        strDescricao = vetProduto(0).ToString.Trim
                        'Else
                        'strDescricao = strProduto
                        'End If
                    Case 3
                        'If VerificaTamanho(vetProduto(2).ToString.Trim) = True Then
                        ' strTam = Dir("Tam.: " & vetProduto(2).ToString.Trim, 12) & Dir("Qtd: " & strQtd, 15)
                        strTam = vetProduto(2).ToString.Trim

                        strDescricao = vetProduto(0).ToString.Trim & " - " & vetProduto(1).ToString.Trim
                        'Else
                        'strDescricao = strProduto
                        'End If
                    Case 4
                        ' If VerificaTamanho(vetProduto(3).ToString.Trim) = True Then
                        ' strTam = Dir("Tam.: " & vetProduto(3).ToString.Trim, 12) & Dir("Qtd: " & strQtd, 15)
                        strTam = vetProduto(3).ToString.Trim

                        strDescricao = vetProduto(0).ToString.Trim & " - " & vetProduto(1).ToString.Trim & " - " & vetProduto(2).ToString.Trim
                        'Else
                        'strDescricao = strProduto
                        'End If
                    Case 5
                        ' If VerificaTamanho(vetProduto(4).ToString.Trim) = True Then
                        'strTam = Dir("Tam.: " & vetProduto(4).ToString.Trim, 12) & Dir("Qtd: " & strQtd, 15)
                        strTam = vetProduto(4).ToString.Trim

                        strDescricao = vetProduto(0).ToString.Trim & " - " & vetProduto(1).ToString.Trim & " - " & vetProduto(2).ToString.Trim & " - " & vetProduto(3).ToString.Trim
                        'Else
                        'strDescricao = strProduto
                        'End If

                    Case 6
                        ' If VerificaTamanho(vetProduto(4).ToString.Trim) = True Then
                        'strTam = Dir("Tam.: " & vetProduto(5).ToString.Trim, 12) & Dir("Qtd: " & strQtd, 15)
                        strTam = vetProduto(5).ToString.Trim
                        strDescricao = vetProduto(0).ToString.Trim & " - " & vetProduto(1).ToString.Trim & " - " & vetProduto(2).ToString.Trim & " - " & vetProduto(3).ToString.Trim & " - " & vetProduto(4).ToString.Trim
                        'Else
                        'strDescricao = strProduto
                        'End If
                    Case 7
                        ' If VerificaTamanho(vetProduto(4).ToString.Trim) = True Then
                        ' strTam = Dir("Tam.: " & vetProduto(6).ToString.Trim, 12) & Dir("Qtd: " & strQtd, 15)
                        strTam = vetProduto(6).ToString.Trim
                        strDescricao = vetProduto(0).ToString.Trim & " - " & vetProduto(1).ToString.Trim & " - " & vetProduto(2).ToString.Trim & " - " & vetProduto(3).ToString.Trim & " - " & vetProduto(4).ToString.Trim & " - " & vetProduto(5).ToString.Trim
                        'Else
                        'strDescricao = strProduto
                        'End If
                End Select


                If strDesc <> strDescricao Then
                    strDesc = strDescricao
                    .Add()
                    .Item(.Count - 1).Item("Fornecedor") = strFabricante
                    .Item(.Count - 1).Item("Produto") = strDescricao
                    .Item(.Count - 1).Item("Grupo") = strGrupo
                    .Item(.Count - 1).Item("Setor") = strSetor
                    .Item(.Count - 1).Item("Tamanho") = strTam


                    VerificaColuna(strTam, A, strQtd, bolLoad)

                Else
                    Dim strTamanho As String = .Item(.Count - 1).Item("Tamanho")
                    .Item(.Count - 1).Item("Tamanho") = strTamanho & strTam

                    VerificaColuna(strTam, A, strQtd, bolLoad)

                End If
            Next
        End With
     
        Me.GridView1.ExpandAllGroups()
    End Sub
    Private Sub VerificaColuna(ByVal parTamanho As String, ByVal parColuna As Integer, ByVal parQtd As String, ByVal parLoad As Boolean)
        If parTamanho = "" Then Exit Sub
        Dim I As Integer
        If parLoad = True Then

            Dim bolColuna As Boolean = False
            Dim strC As String = ""
            For I = 0 To parColuna - 1
                Dim strNomeColuna As String = Me.GridView1.Columns.Item(I).Caption.Trim
                strC &= strNomeColuna
                If strNomeColuna = parTamanho Then
                    bolColuna = True
                End If
            Next

            If bolColuna = False Then
                Dim colId As New DevExpress.XtraGrid.Columns.GridColumn
                'colId.Name = "col" & parTamanho
                colId.FieldName = parTamanho
                colId.Caption = parTamanho.Trim
                colId.Width = 60
                colId.Visible = True
                colId.VisibleIndex = A
                colId.OptionsColumn.ReadOnly = True
                colId.AppearanceCell.TextOptions.HAlignment = 3

                colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                colId.SummaryItem.DisplayFormat = "{0:0}"
                colId.SummaryItem.FieldName = parTamanho
                colId.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum


               

                Me.GridView1.Columns.Add(colId)

           


                Me.tbProd.Columns.Add(parTamanho)
                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item(parTamanho) = parQtd

                Dim grpitem As New DevExpress.XtraGrid.GridGroupSummaryItem

                grpitem.FieldName = parTamanho
                grpitem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                grpitem.ShowInGroupColumnFooter = GridView1.Columns.Item(parTamanho)
                grpitem.DisplayFormat = "{0:0}"
                GridView1.GroupSummary.Add(grpitem)

                A += 1
            Else

                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item(parTamanho) = parQtd

            End If
        Else
            For I = 0 To A - 1
                If Me.GridView1.Columns.Item(I).Caption.Trim = parTamanho Then
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item(parTamanho) = parQtd
                End If
            Next
        End If
       
    End Sub
    Private Shared Function VerificaTamanho(ByVal parTamanho As String) As Boolean
        Select Case parTamanho

            Case "16", "178", "19", "20", "21", "22", "234", "256", "290", "3", "4", "334", "356", "378", _
            "390", "341", "35", "36", "37", "38", "39", "40", "41", "42", "391", "401", "411", "42", "43", _
            "44", "434", "456", "P", "M", "G", "GG", "033", "034", "035", "036", "037", "038", "043", "044", _
            "039", "040", "041", "042"
                Return True
            Case Else
                Return False
        End Select


    End Function

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick

        Me.GridControl1.ShowPrintPreview()

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relProdTamanho
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        With rel.tbProd.Rows
            For I = 0 To Me.GridView1.RowCount - 1
                .Add()
                .Item(I).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Setor") = Me.GridView1.GetRowCellDisplayText(I, Me.colSetor)
                .Item(I).Item("Fornecedor") = Me.GridView1.GetRowCellDisplayText(I, Me.colFornecedor)
                .Item(I).Item("Grupo") = Me.GridView1.GetRowCellDisplayText(I, Me.colGrupo)
                .Item(I).Item("Tamanho") = Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho)
            Next
        End With

        rel.ShowPreview()
    End Sub
    Private Sub LimparColuna()
        Dim I As Integer
        Dim bolTirar As Boolean = False
        Dim B As Integer = 0
        For B = 0 To A - 1

            Dim strColuna As String = Me.GridView1.Columns(B).FieldName
         
            bolTirar = False
            For I = 0 To Me.GridView1.RowCount - 1

                If Me.GridView1.GetRowCellDisplayText(I, strColuna) <> "" Then
                    bolTirar = True
                    Exit For
                End If

            Next

            If bolTirar = False Then
                Me.GridView1.Columns(B).Visible = False
            End If
        Next
    End Sub
    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click

        LimparColuna()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Dim B As Integer = 0
        For B = 0 To A - 1
            If Me.GridView1.Columns(B).FieldName <> "Tamanho" Then
                Me.GridView1.Columns(B).Visible = True
            End If

        Next
    End Sub

    Private Sub GridView1_RowCellDefaultAlignment(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs) Handles GridView1.RowCellDefaultAlignment
        If Not e.Column.FieldName Is "Fornecedor" And Not e.Column.FieldName Is "Setor" And Not e.Column.FieldName Is "Grupo" And Not e.Column.FieldName Is "Produto" Then

            e.HorzAlignment = DevExpress.Utils.HorzAlignment.Far

        End If
    End Sub

    
    Private Sub btnAtualizarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizarGrid.Click
        Dim index As Integer = -999997
        GridView3.FocusedRowHandle = index
        GridView3.FocusedColumn = Me.colGrupo1
        GridView3.ShowEditor()

        Me.GridView3.ClearColumnsFilter()

        Dim I As Integer
        Dim strGrupo As String = ""
        For I = 0 To Me.GridView3.RowCount - 1

            If Me.GridView3.GetRowCellValue(I, Me.colOk) = True Then
                If strGrupo = "" Then
                    strGrupo &= " and Produto.Grupo = '" & Me.GridView3.GetRowCellDisplayText(I, Me.colGrupo1) & "'"
                Else
                    strGrupo &= " or Produto.Grupo = '" & Me.GridView3.GetRowCellDisplayText(I, Me.colGrupo1) & "'"
                End If

            End If

        Next
        Dim strData As String = ""
        If bolFiltro = True Then
            strData = String.Format(" and Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue)
        End If
        AtualizarGrid(strData & strGrupo)

        LimparColuna()
    End Sub

    Private Sub chkTupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTupo.CheckedChanged
        Dim I As Integer
        Select Case Me.chkTupo.Checked
            Case True
                For I = 0 To Me.GridView3.RowCount - 1
                    Me.GridView3.SetRowCellValue(I, Me.colOk, True)
                Next
            Case False
                For I = 0 To Me.GridView3.RowCount - 1
                    Me.GridView3.SetRowCellValue(I, Me.colOk, False)
                Next
        End Select
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
        Dim strData As String = String.Format(" and Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue)

        AtualizarGrid(strData)
        bolFiltro = True
    End Sub
End Class