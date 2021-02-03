Imports Nano.clsFuncoes
Public Class frmCompromisso
    Public strCodPedido As String
    Dim bolAlteracao As Boolean = False
    Dim strCodOrdem As String
    Dim bolAlt As Boolean = False
    Private Sub frmCompromisso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpar()
        If Me.Tag <> "CADASTRA" Then


            Dim dt As DataTable = CarregarDataTable("SELECT CodOrdem, Subject, StartDate, Description FROM Agenda where Subject = 'Nº Pedido " & strCodPedido & "'")
            If dt.Rows.Count > 0 Then
                strCodOrdem = dt.Rows.Item(0).Item("CodOrdem").ToString
                Me.txtCodPedido.Text = strCodPedido
                Me.dtData.EditValue = dt.Rows.Item(0).Item("StartDate")
                Me.memDescricao.Text = dt.Rows.Item(0).Item("Description").ToString
                bolAlteracao = True
            End If
        Else
            If dtData.EditValue = Nothing Then
                Me.dtData.EditValue = My.Computer.Clock.LocalTime
                bolAlt = False
            Else
                bolAlt = True
            End If
        End If
        Me.memDescricao.Focus()
    End Sub
    Private Sub Limpar()
        strCodOrdem = 0
        bolAlteracao = False
        Me.txtCodPedido.Text = strCodPedido
        Me.dtData.EditValue = My.Computer.Clock.LocalTime
        Me.memDescricao.ResetText()
    End Sub
    Private Sub btnSalvar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.dtData) = False Then Exit Sub
        If Validar(Me.memDescricao) = False Then Exit Sub
        Dim strRemider As String = ""
        If Me.cboLembrete.Text <> "" Then
            strRemider = Me.cboLembrete.Text
            Dim vetTempo As Array
            Dim dblTempo As Double
            If strRemider.ToUpper.Contains("MINUTO") Then
                vetTempo = Split(strRemider.ToUpper, "MINUTO")

                dblTempo = vetTempo(0)
                strRemider = "00:" & Format(dblTempo, "00") & ":00"
            ElseIf strRemider.ToUpper.Contains("HORA") Then
                vetTempo = Split(strRemider.ToUpper, "HORA")

                dblTempo = vetTempo(0)
                strRemider = Format(dblTempo, "00") & ":00:00"
            ElseIf strRemider.ToUpper.Contains("DIA") Then
                vetTempo = Split(strRemider.ToUpper, "DIA")
                If vetTempo(0).ToString.Contains(",") Then
                    dblTempo = vetTempo(0)
                    dblTempo = dblTempo * 24
                    strRemider = Format(dblTempo, "00") & ":00:00"
                Else
                    dblTempo = vetTempo(0)
                    strRemider = Format(dblTempo, "00") & ".00:00:00"
                End If

            ElseIf strRemider.ToUpper.Contains("SEMANA") Then
                vetTempo = Split(strRemider.ToUpper, "DIA")

                dblTempo = vetTempo(0)
                dblTempo = dblTempo * 7
                strRemider = Format(dblTempo, "00") & ".00:00:00"
            End If

            If strRemider <> "" Then
                If strRemider.Contains(".") = True Then
                    Dim vetRemider As Array = Split(strRemider, ".")
                    Dim intDia As Integer = vetRemider(0)
                    Dim dtRemider As Date = Me.dtData.EditValue

                    strRemider = Format(dtRemider.AddDays(-intDia), "MM/dd/yyyy HH:mm:ss")


                    strRemider = "<Reminders><Reminder AlertTime=""" & strRemider & """ /></Reminders>"
                Else
                    Dim dtRemider As Date = Me.dtData.EditValue
                    Dim strHora1 As String = Format(dtRemider, "HH:mm:ss")
                    Dim strHora2 As String = strRemider

                    strRemider = CalcularHora(strHora1, strHora2)

                    Dim dtHora As Date = strRemider
                    Dim dtHoraIni As Date = strHora1



                    If dtHora > dtHoraIni Then
                        dtRemider = dtRemider.AddDays(-1)
                        strRemider = Format(dtRemider, "MM/dd/yyyy") & " " & strRemider
                    Else
                        strRemider = Format(dtRemider, "MM/dd/yyyy") & " " & strRemider
                    End If
                    strRemider = "<Reminders><Reminder AlertTime=""" & strRemider & """ /></Reminders>"

                End If
            End If
        End If


        If Me.Tag = "CADASTRA" Then

            DataCompromisso = Me.dtData.EditValue
            DescricaoCompromisso = Me.memDescricao.Text.Replace("'", "")
            LembreteCompromisso = strRemider
        Else
            If bolAlteracao = True Then
                Atualizar("UPDATE Agenda SET StartDate = '" & Me.dtData.EditValue & "', EndDate = '" & Me.dtData.DateTime.AddHours(1) & "', Description = '" & Me.memDescricao.Text.Replace("'", "") & "' WHERE CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig)
            Else
                Dim strCodOrdemAgenda As Integer = GerarCodigo("Agenda", "CodOrdem", CodConfig)

                Inserir("INSERT INTO Agenda (CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, " & _
               "Status, Label, Conta, ReminderInfo, CodConfig) VALUES (" & strCodOrdemAgenda & ",0,'" & Me.dtData.EditValue & "','" & Me.dtData.DateTime.AddHours(1) & "'," & _
               "'False','Nº Pedido " & Me.txtCodPedido.Text & "','','" & Me.memDescricao.Text.Replace("'", "") & "',2,0,'False','" & strRemider & "'," & CodConfig & ")")

            End If
          

        End If

        MsgBox("Compromisso salvo com sucesso!", MsgBoxStyle.Information)
        Limpar()
        Me.Close()

    End Sub
    Private Shared Function CalcularHora(ByVal parIni As String, ByVal parTer As String) As String

        Dim HoraIni, HoraFim As DateTime
        Dim tsTotal As TimeSpan

        Try
            HoraIni = parIni
            HoraFim = parTer

        Catch ex As Exception
            MsgBox("Os campos de Hora devem estar preenchidos e no formato correto!", MsgBoxStyle.Information)

        End Try

        tsTotal = HoraFim.Subtract(HoraIni)
        Dim strDuracao As String



        strDuracao = tsTotal.Hours.ToString("00").Replace("-", "") & ":" & tsTotal.Minutes.ToString("00").Replace("-", "")

        If HoraIni < HoraFim Then
            HoraFim = "23:59:59"
            strDuracao = HoraFim.Subtract(tsTotal)
            HoraFim = strDuracao
            strDuracao = HoraFim.AddSeconds(1)

        End If

        Dim strHoraIni(1) As String

        strHoraIni = strDuracao.Split(":"(0))


        If strHoraIni.Length = 1 Then
            MsgBox("Formato de Hora incorreto, favor informar a quantidade de horas no padrão 00:00!", MsgBoxStyle.Information)
            Return ""
            Exit Function
        End If


        Dim strHoras As String = strHoraIni(1)

        If strHoras = "" Or strHoras.Length = 1 Or strHoras.Length > 2 Then
            MsgBox("Formato de Hora incorreto, favor informar a quantidade de horas no padrão 00:00!", MsgBoxStyle.Information)
            Return ""
            Exit Function
        End If
        Return strDuracao
    End Function
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        If Me.Tag = "CADASTRA" Then
            If bolAlt = False Then
                DataCompromisso = Nothing
                DescricaoCompromisso = ""
                LembreteCompromisso = ""
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If Me.Tag = "CADASTRA" Then
            DataCompromisso = Nothing
            DescricaoCompromisso = ""
            LembreteCompromisso = ""
            Exit Sub
        End If
        If MsgBox("Deseja realmente excluir este compromisso?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Excluir("DELETE FROM Agenda WHERE CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig)
        End If
        MsgBox("Compromisso excluído com sucesso!", MsgBoxStyle.Information)
        Limpar()
    End Sub
End Class