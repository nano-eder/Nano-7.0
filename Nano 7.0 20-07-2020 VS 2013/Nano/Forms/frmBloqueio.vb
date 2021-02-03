Imports Nano.clsFuncoes
Public Class frmBloqueio

    Private Sub frmBloqueio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "82")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub





    Private Sub frmBloqueio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        If Master = True Then
            CarregarDadosLue("Select Codigo, Nome from Usuario where Login <> 'ADM' and Inativo = 'False'", Me.lueFunc)
        Else
            CarregarDadosLue("Select Codigo, Nome from Usuario where Login <> 'ADM' and Inativo = 'False' and CodConfig =" & CodConfig, Me.lueFunc)
        End If


        Dim I As Integer

        Dim dt As DataTable = CarregarDataTable("Select Principal from Bloqueios")

        For I = 0 To dt.Rows.Count - 1
            If dt.Rows.Item(I).ItemArray(0).ToString.Trim <> "" Then
                Me.lstPrin.Items.Add(dt.Rows.Item(I).ItemArray(0).ToString.Trim)
            End If
        Next

        dt = CarregarDataTable("Select Relatorios from Bloqueios")

        For I = 0 To dt.Rows.Count - 1
            If dt.Rows.Item(I).ItemArray(0).ToString.Trim <> "" Then
                Me.lstRel.Items.Add(dt.Rows.Item(I).ItemArray(0).ToString.Trim)
            End If
        Next

    End Sub

    Private Sub lueFunc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFunc.EditValueChanged
        Dim dt As DataTable
        Dim vetPrin, vetRel As Array
        Dim I As Integer
        Dim Index As Integer

        For I = 0 To Me.lstPrin.ItemCount - 1
            Me.lstPrin.Items.Item(I).CheckState = CheckState.Unchecked
        Next

        For I = 0 To Me.lstRel.ItemCount - 1
            Me.lstRel.Items.Item(I).CheckState = CheckState.Unchecked
        Next

        If Me.lueFunc.Text = "" Then Exit Sub
        Dim strttt As String = Me.lueFunc.GetColumnValue("Codigo")
        dt = CarregarDataTable("Select Principal, Consultas, Relatorios from Usuario where Codigo =" & Me.lueFunc.GetColumnValue("Codigo"))

        vetPrin = Split(dt.Rows.Item(0).Item(0).ToString, "|")
        vetRel = Split(dt.Rows.Item(0).Item(2).ToString, "|")

        For I = 0 To vetPrin.Length - 1
            If vetPrin(I).ToString <> "" Then
                Index = vetPrin(I)
                Try
                    Me.lstPrin.Items.Item(Index).CheckState = CheckState.Checked
                Catch ex As Exception

                End Try

            End If
        Next

        For I = 0 To vetRel.Length - 1
            If vetRel(I).ToString <> "" Then
                Index = vetRel(I)
                Try
                    Me.lstRel.Items.Item(Index).CheckState = CheckState.Checked
                Catch ex As Exception

                End Try

            End If
        Next


    End Sub

    Private Sub btnBloqueio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBloqueio.ItemClick

        If Validar(Me.lueFunc) = False Then Exit Sub

        Dim I As Integer
        Dim strPrinc As String = ""
        Dim strRel As String = ""

        For I = 0 To Me.lstPrin.ItemCount - 1
            If Me.lstPrin.Items.Item(I).CheckState = CheckState.Checked Then
                strPrinc &= I & "|"
            End If
        Next

        For I = 0 To Me.lstRel.ItemCount - 1
            If Me.lstRel.Items.Item(I).CheckState = CheckState.Checked Then
                strRel &= I & "|"
            End If
        Next

        Dim strttt As String = Me.lueFunc.GetColumnValue("Codigo")
        Atualizar("Update Usuario set Principal ='" & strPrinc & "', Consultas ='" & "" & "', Relatorios ='" & strRel & "' where Codigo =" & Me.lueFunc.GetColumnValue("Codigo"))

        MsgBox("Bloqueios inseridos com sucesso!", MsgBoxStyle.Information)

        Me.lueFunc.EditValue = DBNull.Value

    End Sub
End Class