Imports Nano.clsFuncoes
Imports JRO
Public Class frmMonitor
    Dim intContador As Integer

    Private Sub frmMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lstLojas.Items.Clear()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim dt As DataTable = CarregarDataTable("Select Descricao from Config")

        Dim strLoja As String = ""
        Dim strPasta As String = ""
        Dim strCaminho As String = ""
        Dim intContLoja As Integer = 0
        Dim I, L As Integer


        intContador += 1

        If intContador = 30 Then
            If MsgBox("O sistema detectou que uma das lojas não está pronta para sincronização, deseja tentar novamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                intContador = 0
            Else
                Cancelar()
                Exit Sub

            End If

        End If

        For I = 0 To dt.Rows.Count - 1

            strLoja = dt.Rows.Item(I).Item("Descricao").ToString

            If My.Computer.FileSystem.FileExists(PastaSincrinizacao & "\" & strLoja & ".txt") = True Then
                Try
                    Me.lstLojas.Items.RemoveAt(I)
                Catch ex As Exception

                End Try


                Me.lstLojas.Items.Insert(I, strLoja & " - OK")
                intContLoja += 1
            Else
                'Me.lstLojas.Items.Clear()
                Exit For
            End If

        Next

        If intContLoja = dt.Rows.Count Then

            Dim JROSinc As JRO.Replica
            Dim con As New ADODB.Connection
            Dim rsCOnflict As New ADODB.Recordset

            con.Open(My.Settings.MecanicaString)

            JROSinc = New JRO.Replica

            JROSinc.ActiveConnection = con

            dt = CarregarDataTable("Select Descricao, PastaSinc from Config")

            For L = 0 To 1

                For I = 0 To dt.Rows.Count - 1
                    strPasta = dt.Rows.Item(I).Item("PastaSinc").ToString
                    strLoja = dt.Rows.Item(I).Item("Descricao").ToString

                    If strLoja.ToUpper.Trim <> "MATRIZ" Then

                        strCaminho = strPasta & "\" & strLoja & ".mdb"
                        JROSinc.Synchronize(strCaminho, SyncTypeEnum.jrSyncTypeImpExp, SyncModeEnum.jrSyncModeDirect)
                    End If
                Next

            Next
            Me.lstLojas.Items.Add("Concluindo a sincronização...")

            intContador = 0

            Timer2.Start()
            Timer1.Stop()
            Exit Sub
        End If


    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        LojasProntas = True
        Me.Close()
    End Sub

    Private Sub btnCalcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcel.Click
        Cancelar()
    End Sub

    Private Sub Cancelar()

        intContador = 0
        Me.lstLojas.Items.Add("A Sincronização foi cancelado!")

        Timer1.Stop()

        Timer2.Start()

    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        intContador += 1

        If intContador = 30 Then
            Me.marquee.Properties.Stopped = True
            Me.lstLojas.Items.Add(" ")
            Me.lstLojas.Items.Add("Clique em 'OK' para concluir!")

            Me.btnOK.Visible = True
            Me.btnCalcel.Visible = False

            Timer2.Stop()
        End If

    End Sub
End Class