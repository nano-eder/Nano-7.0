Imports Nano.clsFuncoes
Imports Nano.clsFuncoesBematech
Imports System.Text
Public Class frmAbertura

    Private Sub frmAbertura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtValRec.ResetText()
        Select Case Me.Tag
            Case "Entrada"
                Me.Text = "Entrada do Operador"
            Case "Suprimento"
                Me.Text = "Suprimento"
            Case "Sangria"
                Me.Text = "Sangria"
            Case "Saida"
                Me.Text = "Saída do Operador"
        End Select
    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If Me.txtValRec.Text = "" Then Exit Sub
        PrecoECF(Me.txtValRec)
        Dim strValor As String = Me.txtValRec.Text
        Dim strData As String

        If VerificaImpressora() = False Then Exit Sub

        If VerificaAbertura("Operador") = False Then Exit Sub

        Select Case Me.Tag
            Case "Entrada"
                'Dim DataMovimento As String = Space(7)
                'Retorno = Bematech_FI_DataMovimento(DataMovimento)
                Dim strDataAtual As String = Format(Date.Today, "dd/MM/yy")
                strDataAtual = strDataAtual.Replace("/", "")
                'DataMovimento = DataMovimento.Substring(0, 6)

                strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1))

                Dim dt As DataTable = CarregarDataTable("SELECT Operador, Tipo FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData & " and Tipo <> 'Suprimento' and Tipo <> 'Sangria' and Tipo <> 'ValorLiquido' and CodConfig = " & CodConfig & " order by Codigo Desc")

                If dt.Rows.Count > 0 Then
                    Dim strTipo As String = dt.Rows.Item(0).Item("Tipo").ToString
                    Dim strOperador As String = dt.Rows.Item(0).Item("Operador").ToString

                    If strTipo = "Entrada" Then
                        MsgBox("Já exite movimento para este dia!", MsgBoxStyle.Information)
                        Me.Close()
                        Exit Sub
                    ElseIf strTipo = "Saida" Then

                        If TipoImpressoraFiscal = "DARUMA" Then
                            DarumaFiscal.iRetorno = DarumaFiscal.iSuprimento_ECF_Daruma(strValor, "")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            Retorno = Bematech_FI_Suprimento(strValor, "")
                        End If

                        SalvarOperacao("Entrada", Me.txtValRec.Text)
                        Me.txtValRec.ResetText()
                        MsgBox("Entrada do operador concluída com sucesso!", MsgBoxStyle.Information)
                        Me.Close()
                    Else
                        Dim strDataUltimaRZ As String = ""
                        If TipoImpressoraFiscal = "DARUMA" Then
                            Dim strDataUlt As New StringBuilder(" ", 14)
                            strDataUlt.Length = 14
                            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("154", strDataUlt)
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            Dim strDataUlt As String = Space(7)
                            Retorno = Bematech_FI_DataMovimentoUltimaReducaoMFD(strDataUltimaRZ)
                            strDataUltimaRZ = strDataUlt.Substring(0, 6)
                        End If
                       

                        If strDataUltimaRZ = strDataAtual Then
                            MsgBox("Redução Z já emitida, ecf bloqueada até " & Date.Today & " 23:59:59.", MsgBoxStyle.Information)
                            Me.Close()
                            Exit Sub
                        Else
                            If TipoImpressoraFiscal = "DARUMA" Then
                                DarumaFiscal.iRetorno = DarumaFiscal.iLeituraX_ECF_Daruma()
                                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                                DarumaFiscal.iRetorno = DarumaFiscal.iSuprimento_ECF_Daruma(strValor, "")
                                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                            Else
                                Retorno = Bematech_FI_AberturaDoDia(strValor, "")
                            End If

                            SalvarOperacao("Entrada", Me.txtValRec.Text)
                            Me.txtValRec.ResetText()
                            MsgBox("Entrada do operador concluída com sucesso!", MsgBoxStyle.Information)
                            Me.Close()
                        End If


                    End If
                Else


                    If TipoImpressoraFiscal = "DARUMA" Then
                        DarumaFiscal.iRetorno = DarumaFiscal.iLeituraX_ECF_Daruma()
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        DarumaFiscal.iRetorno = DarumaFiscal.iSuprimento_ECF_Daruma(strValor, "")
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                    Else
                        Retorno = Bematech_FI_AberturaDoDia(strValor, "")
                    End If
                    SalvarOperacao("Entrada", Me.txtValRec.Text)
                    Me.txtValRec.ResetText()
                    MsgBox("Entrada do operador concluída com sucesso!", MsgBoxStyle.Information)
                    Me.Close()
                End If
           
            Case "Suprimento", "Sangria", "Saida"
                strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1))

                Dim dt As DataTable = CarregarDataTable("SELECT Operador, Tipo From Operador where CodConfigECF = " & CodConfigECF & " and " & strData & " and Tipo <> 'Suprimento' and Tipo <> 'Sangria' and Tipo <> 'ValorLiquido' and CodConfig = " & CodConfig & " order by Codigo Desc")
                If dt.Rows.Count > 0 Then
                    Dim strTipo As String = dt.Rows.Item(0).Item("Tipo").ToString
                    Dim strOperador As String = dt.Rows.Item(0).Item("Operador").ToString
                    If strTipo = "Saida" Or strTipo = "Fechamento" Then
                        MsgBox("É nescessário dar entrada no operador!", MsgBoxStyle.Information)
                        Me.Close()
                        Exit Sub
                    End If
                Else
                    MsgBox("É nescessário dar entrada no operador!", MsgBoxStyle.Information)
                    Me.Close()
                    Exit Sub
                End If

                Select Case Me.Tag
                    Case "Suprimento"
                        If TipoImpressoraFiscal = "DARUMA" Then
                            DarumaFiscal.iRetorno = DarumaFiscal.iSuprimento_ECF_Daruma(strValor, "")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            Retorno = Bematech_FI_Suprimento(strValor, "")
                        End If
                        SalvarOperacao("Suprimento", Me.txtValRec.Text)
                        Me.txtValRec.ResetText()
                        MsgBox("Suprimento realizado com sucesso!", MsgBoxStyle.Information)
                        Me.Close()
                    Case "Sangria"
                        If TipoImpressoraFiscal = "DARUMA" Then
                            DarumaFiscal.iRetorno = DarumaFiscal.iSangria_ECF_Daruma(strValor, "")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            Retorno = Bematech_FI_Sangria(strValor)
                        End If

                        SalvarOperacao("Sangria", Me.txtValRec.Text)
                        Me.txtValRec.ResetText()
                        MsgBox("Sangria realizada com sucesso!", MsgBoxStyle.Information)
                        Me.Close()
                    Case "Saida"
                        If TipoImpressoraFiscal = "DARUMA" Then
                            DarumaFiscal.iRetorno = DarumaFiscal.iSangria_ECF_Daruma(strValor, "")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            Retorno = Bematech_FI_Sangria(strValor)
                        End If
                        SalvarOperacao("Saida", Me.txtValRec.Text)
                        Me.txtValRec.ResetText()

                        SaidaOperador()

                        MsgBox("Saida do operador realizada com sucesso!", MsgBoxStyle.Information)
                        Me.Close()
                End Select


        End Select
        SalvarDocumento("RG")
        'SalvarDocumento("CN")

    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub
End Class