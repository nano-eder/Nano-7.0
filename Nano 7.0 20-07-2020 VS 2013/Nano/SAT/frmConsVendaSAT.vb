Imports Nano.clsFuncoes
Imports System.Runtime.InteropServices
Public Class frmConsVendaSAT

    Private Sub frmConsVendaSAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick


        Dim strChave As String = ""
        Dim strQrCode As String = ""
        Dim strCPF As String = ""
        Dim dblValorTotal As Double = 0
        Dim strData As String = ""
        Dim dtData As Date

        Dim cmdLineStr As IntPtr = clsDimepSatDLL.ConsultarNumeroSessao(Me.txtPed.Text & "0000", NumeroSerieECF, Me.txtPed.Text)
        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        If SatRetorno.Contains("Emitido com sucesso") = True Then
            Try

                Dim vetChave As Array = Split(SatRetorno, "|")

                strChave = vetChave(8).ToString.Replace("CFe", "")
                dblValorTotal = vetChave(9)
                strCPF = vetChave(10)
                strData = vetChave(7)
                Dim strData2 As String = ""
                Dim I As Integer
                For I = 0 To 13
                    Dim strChar As String = strData.Substring(I, 1)
                    strData2 &= strChar
                    Select Case I
                        Case 3, 5
                            strData2 &= "/"
                        Case 7
                            strData2 &= " "
                        Case 9, 11
                            strData2 &= ":"
                    End Select
                Next
                dtData = strData2
                strQrCode = vetChave(11).ToString

               
                cmdLineStr = clsDimepSatDLL.Base64ToAscii()
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            Catch ex2 As Exception
                MsgBox("Verificar status sat!", MsgBoxStyle.Information)
                Exit Sub
            End Try



            If strChave <> "" Then
                If IO.File.Exists(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml") = False Then
                    Call SalvarArquivo(SatRetorno, CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", False)
                End If

                'Atualizar("UPDATE Total Set ChaveSAT = '" & strChave & "' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                If IO.Directory.Exists(CaminhoPastaSAT.Replace("Remessas", "Backup")) = False Then
                    IO.Directory.CreateDirectory(CaminhoPastaSAT.Replace("Remessas", "Backup"))
                End If
                If IO.File.Exists(CaminhoPastaSAT.Replace("Remessas", "Backup") & "\CFe" & strChave & ".xml") = False Then
                    IO.File.Copy(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", CaminhoPastaSAT.Replace("Remessas", "Backup") & "\CFe" & strChave & ".xml")

                End If

                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM SATFiscal where CodOrdem = " & Me.txtPed.Text & " and CodConfig=" & CodConfig)
                If dt.Rows.Count = 0 Then
                    Inserir("INSERT INTO SATFiscal(CodOrdem, Chave, NumeroSerie, NumeroCaixa, CNPJ, Data, " & _
                    "NumeroCupom, ValorTotal, CFPDest, AssinaturaQrCode, CodConfig) VALUES (" & Me.txtPed.Text & "," & _
                    "'" & strChave & "','" & NumeroSerieECF & "','" & NumeroEcfECF & "','" & CNPJECF & "'," & _
                    "'" & dtData & "','" & "" & "'," & Num(dblValorTotal) & ",'" & strCPF & "'," & _
                    "'" & strQrCode & "'," & CodConfig & ")")
                End If




            End If
            Dim bolSatEmitido As Boolean = False

            Try
                GerarSat.GerarCupomSat(SatRetorno, strChave)
                bolSatEmitido = True
            Catch ex As Exception
                bolSatEmitido = False
            End Try

            If bolSatEmitido = False Then
                Try
                    GerarSat.GerarCupomSat(SatRetorno, strChave)
                Catch ex As Exception
                    MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                End Try

            End If
            Me.Close()
        Else
            Dim vetSat As Array = Split(SatRetorno, "|")

            If vetSat.Length > 3 Then
                Dim strMensagem As String = vetSat(3)

                If strMensagem.ToUpper.Contains("BLOQUEADO") Then
                    MsgBox("SAT Bloqueado." & vbCrLf & "!", MsgBoxStyle.Information)
                Else
                    MsgBox(SatRetorno, MsgBoxStyle.Information)
                End If
            Else
                MsgBox(SatRetorno, MsgBoxStyle.Information)
            End If
        End If



    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class