Public Class frmTESTECPF 

    Private Sub frmTESTECPF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.wb1.Navigate("https://www.receita.fazenda.gov.br/Aplicacoes/SSL/ATCTA/CPF/ConsultaSituacao/ConsultaPublica.asp")

    End Sub
End Class