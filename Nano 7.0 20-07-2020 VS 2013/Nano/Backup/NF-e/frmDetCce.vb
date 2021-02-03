Imports Nano.clsFuncoes
Public Class frmDetCce
    Public strCodOrdem As String
    Public strNumNF As String
    Private Sub frmDetCce_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, CodOrdem, Versao, Id, CUF, TipoAmb, Chave, DEmi, HEmi, TZD, TipoEvento, " & _
                   "NumSeqEvento, CNPJ, DescEvento, Correcao, CondUso FROM Cce where CodConfig = " & CodConfig & " and CodOrdem = " & strCodOrdem & " and NumSeqEvento = '" & Me.txtNumSeqEvento.Text & "'")

        If dt.Rows.Count > 0 Then

            Me.txtCnpj.Text = dt.Rows.Item(0).Item("CNPJ").ToString
            Me.txtCodUF.Text = dt.Rows.Item(0).Item("CUF").ToString
            
            Me.txtVersao.Text = dt.Rows.Item(0).Item("Versao").ToString

            Me.txtChave.Text = dt.Rows.Item(0).Item("Chave").ToString

            Me.txtTZD.Text = dt.Rows.Item(0).Item("TZD").ToString
            Me.txtTipoEvento.Text = dt.Rows.Item(0).Item("TipoEvento").ToString
            Me.txtNumSeqEvento.Text = dt.Rows.Item(0).Item("NumSeqEvento").ToString
            Me.txtDescEvento.Text = dt.Rows.Item(0).Item("DescEvento").ToString
            Me.memCorrecao.Text = dt.Rows.Item(0).Item("Correcao").ToString
            Me.memCondUso.Text = dt.Rows.Item(0).Item("CondUso").ToString

            Me.txtHora.Text = Format(CDate(dt.Rows.Item(0).Item("HEmi")), "HH:mm:ss").ToString
            Me.dtData.Text = Format(CDate(dt.Rows.Item(0).Item("DEmi")), "dd/MM/yyyy").ToString
       
            Me.txtNumNF.Text = strNumNF
        End If

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class