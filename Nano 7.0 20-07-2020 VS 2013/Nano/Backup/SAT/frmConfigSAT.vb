Imports Nano.clsFuncoes
Public Class frmConfigSAT
    Dim bolAlterar As Boolean = False
    Dim bolAlt As Boolean = False
    Private Sub CarregarGrid()

        CarregarDados("SELECT CNPJ as Cnpj, IE, NumeroSerie as NumSerie, Assinatura, ModeloImpSAT, " & _
        "CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, VersaoXmlSAT, MensImpCupomSAT, ModeloSAT, Regime FROM ConfigECF " & _
        "group by CNPJ, IE, NumeroSerie, Assinatura, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, " & _
        "ImpDiretoSAT, VersaoXmlSAT, MensImpCupomSAT, ModeloSAT, Regime", Me.GridControl1)

    End Sub
    Private Sub frmConfigSAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarGrid()
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.cboModSAT) = False Then Exit Sub
        If Validar(Me.txtCNPJ) = False Then Exit Sub
        If Validar(Me.txtAssinatura) = False Then Exit Sub
        If Validar(Me.txtNumSerie) = False Then Exit Sub
        If Validar(Me.cboRegime) = False Then Exit Sub
        If Me.grd2.RowCount = 0 Then MsgBox("Inserir pelo menos um computador", MsgBoxStyle.Information) : Exit Sub

        Dim I As Integer

        If bolAlterar = False Then

            For I = 0 To Me.grd2.RowCount - 1
                Dim strComputador As String = Me.grd2.GetRowCellDisplayText(I, Me.colComputador)
                Dim strNumCaixa As String = Me.grd2.GetRowCellDisplayText(I, Me.colNumCaixa)
                Dim strModeloImp As String = Me.grd2.GetRowCellDisplayText(I, Me.colModeloImpSAT)
                Dim strNomeImp As String = Me.grd2.GetRowCellDisplayText(I, Me.colNomeImpSAT)
                Dim strCaminhoPastaSAT As String = Me.grd2.GetRowCellDisplayText(I, Me.colCaminhoPastaSAT)
                Dim bolImpDiretoSAT As Boolean = Me.grd2.GetRowCellValue(I, Me.colImpDiretoSAT)
                Dim bolMensImpCupomSAT As Boolean = Me.grd2.GetRowCellValue(I, Me.colMensImpCupomSAT)
                Dim strModeloSAT As String = Me.grd2.GetRowCellValue(I, Me.colModeloSAT)
                Inserir("INSERT INTO ConfigECF (CNPJ, IE, NumeroSerie, Assinatura, Computador, " & _
                "NumeroECF, CodConfig, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, " & _
                "VersaoXmlSAT, MensImpCupomSAT, ModeloSAT, Regime) VALUES ('" & Me.txtCNPJ.Text & "','" & Me.txtIE.Text & "'," & _
                "'" & Me.txtNumSerie.Text & "','" & Me.txtAssinatura.Text & "','" & strComputador & "'," & _
                "'" & strNumCaixa & "'," & CodConfig & ",'" & strModeloImp & "','" & strCaminhoPastaSAT & "'," & _
                "'" & strNomeImp & "','" & bolImpDiretoSAT & "','" & Me.txtVersaoXml.Text & "'," & _
                "'" & bolMensImpCupomSAT & "','" & Me.cboModSAT.Text & "','" & Me.cboRegime.Text & "')")
            Next

        Else
            For I = 0 To Me.grd2.RowCount - 1
                Dim strComputador As String = Me.grd2.GetRowCellDisplayText(I, Me.colComputador)
                Dim strNumCaixa As String = Me.grd2.GetRowCellDisplayText(I, Me.colNumCaixa)
                Dim strCodigo As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodigo)

                Dim strModeloImp As String = Me.grd2.GetRowCellDisplayText(I, Me.colModeloImpSAT)
                Dim strNomeImp As String = Me.grd2.GetRowCellDisplayText(I, Me.colNomeImpSAT)
                Dim strCaminhoPastaSAT As String = Me.grd2.GetRowCellDisplayText(I, Me.colCaminhoPastaSAT)
                Dim bolImpDiretoSAT As Boolean = Me.grd2.GetRowCellValue(I, Me.colImpDiretoSAT)
                Dim strModeloSAT As String = Me.grd2.GetRowCellValue(I, Me.colModeloSAT)
                Dim bolMensImpCupomSAT As Boolean = Me.grd2.GetRowCellValue(I, Me.colMensImpCupomSAT)
                If strCodigo = "" Then
                    Inserir("INSERT INTO ConfigECF (CNPJ, IE, NumeroSerie, Assinatura, Computador, " & _
                    "NumeroECF, CodConfig, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, ImpDiretoSat, " & _
                    "VersaoXmlSAT, MensImpCupomSAT, ModeloSAT, Regime) VALUES (" & _
                    "'" & Me.txtCNPJ.Text & "','" & Me.txtIE.Text & "','" & Me.txtNumSerie.Text & "'," & _
                    "'" & Me.txtAssinatura.Text & "','" & strComputador & "','" & strNumCaixa & "'," & CodConfig & "," & _
                    "'" & strModeloImp & "','" & strCaminhoPastaSAT & "','" & strNomeImp & "','" & bolImpDiretoSAT & "'," & _
                    "'" & Me.txtVersaoXml.Text & "','" & bolMensImpCupomSAT & "','" & Me.cboModSAT.Text & "','" & Me.cboRegime.Text & "')")
                Else
                    Atualizar("UPDATE ConfigECF SET CNPJ = '" & Me.txtCNPJ.Text & "', IE = '" & Me.txtIE.Text & "', " & _
                    "NumeroSerie = '" & Me.txtNumSerie.Text & "', Assinatura = '" & Me.txtAssinatura.Text & "', " & _
                    "Computador = '" & strComputador & "', NumeroECF = '" & strNumCaixa & "', " & _
                    "ModeloImpSAT = '" & strModeloImp & "', CaminhoPastaSAT = '" & strCaminhoPastaSAT & "', " & _
                    "NomeImpSAT = '" & strNomeImp & "', ImpDiretoSAT = '" & bolImpDiretoSAT & "', " & _
                    "VersaoXmlSAT = '" & Me.txtVersaoXml.Text & "', MensImpCupomSAT = '" & bolMensImpCupomSAT & "', " & _
                    "ModeloSAT = '" & Me.cboModSAT.Text & "', Regime = '" & Me.cboRegime.Text & "' where Codigo = " & strCodigo)
                End If

            Next
        End If

        MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)
        Limpar()
        CarregarGrid()
        CarregarDadosSAT()
        Atualizar("UPDATE Ordens set CodEmitente = " & CodConfigECF & " where Tabela = 'Sat' and CodConfig = " & CodConfig & " and CodEmitente = ''")
        Atualizar("UPDATE Ordens set CodEmitente = " & CodConfigECF & " where Tabela = 'Sat' and CodConfig = " & CodConfig & " and CodEmitente is null")

    End Sub
    Private Sub CarregarDadosSAT()
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, CNPJ, IE, NumeroSerie, NumeroECF, " & _
        "Computador, Assinatura, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, VersaoXmlSAT, MensImpCupomSAT, ModeloSAT, Regime FROM ConfigECF " & _
        "where Computador = '" & My.Computer.Name.ToUpper & "' and CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then

            CodConfigECF = dt.Rows.Item(0).Item("Codigo").ToString
            CNPJECF = dt.Rows.Item(0).Item("CNPJ").ToString
            IEECF = dt.Rows.Item(0).Item("IE").ToString
            NumeroSerieECF = dt.Rows.Item(0).Item("NumeroSerie").ToString
            NumeroEcfECF = dt.Rows.Item(0).Item("NumeroECF").ToString
            ComputadorECF = dt.Rows.Item(0).Item("Computador").ToString.ToUpper
            AssinaturaAC = dt.Rows.Item(0).Item("Assinatura").ToString
            ModeloImpSAT = dt.Rows.Item(0).Item("ModeloImpSAT").ToString
            CaminhoPastaSAT = dt.Rows.Item(0).Item("CaminhoPastaSAT").ToString
            NomeImpSAT = dt.Rows.Item(0).Item("NomeImpSAT").ToString
            ImpDiretoSAT = dt.Rows.Item(0).Item("ImpDiretoSAT").ToString
            VersaoXmlSAT = dt.Rows.Item(0).Item("VersaoXmlSAT").ToString
            MensImpCupomSAT = dt.Rows.Item(0).Item("MensImpCupomSAT").ToString
            ModeloSAT = dt.Rows.Item(0).Item("ModeloSAT").ToString
            RegimeSAT = dt.Rows.Item(0).Item("Regime").ToString
            If ModeloImpSAT = "NORMAL" Or ModeloImpSAT = "TERMICA" Or ModeloImpSAT = "TERMICA MARGEM" Then
                GerarSATCrystal = True
            Else
                GerarSATCrystal = False
            End If
        End If
    End Sub
    Private Sub Limpar()
        bolAlterar = False
        Me.txtCNPJ.ResetText()
        Me.txtIE.ResetText()
        Me.txtNumSerie.ResetText()
        Me.txtComputador.ResetText()
        Me.txtNumCaixa.ResetText()
        Me.txtAssinatura.ResetText()
        Me.txtVersaoXml.SelectedIndex = -1
        Me.cboModeloImp.SelectedIndex = -1
        Me.txtNomeImp.ResetText()
        Me.txtPastaSAT.ResetText()
        Me.cboModSAT.SelectedIndex = -1
        Me.cboRegime.SelectedIndex = -1

        Me.tbComp.Rows.Clear()
        Me.txtCNPJ.Focus()
    End Sub
    Private Sub Alterar()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim intIndex As Integer = grd1.FocusedRowHandle
        bolAlterar = True
        Me.txtCNPJ.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCnpj)
        Me.txtIE.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colIE)
        Me.txtNumSerie.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNumSerie)
        Me.txtAssinatura.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAssinatura)
        Me.txtVersaoXml.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colVersaoXmlSAT)
        Me.cboModSAT.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colModeloSAT)
        Me.cboRegime.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colRegime)
        'Me.txtPastaSAT.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCaminhoPastaSATServ)
        Dim dtComp As DataTable = CarregarDataTable("SELECT Codigo, Computador, NumeroECF, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, MensImpCupomSAT FROM ConfigECF where CNPJ = '" & Me.txtCNPJ.Text & "' and " & _
        "NumeroSerie = '" & Me.txtNumSerie.Text & "' and ModeloSAT = '" & Me.cboModSAT.Text & "'")
        Dim I As Integer
        Me.tbComp.Rows.Clear()
        If dtComp.Rows.Count > 0 Then
            For I = 0 To dtComp.Rows.Count - 1
                Me.tbComp.Rows.Add()
                Me.tbComp.Rows.Item(I).Item("Computador") = dtComp.Rows.Item(I).Item("Computador").ToString
                Me.tbComp.Rows.Item(I).Item("NumCaixa") = dtComp.Rows.Item(I).Item("NumeroECF").ToString
                Me.tbComp.Rows.Item(I).Item("Codigo") = dtComp.Rows.Item(I).Item("Codigo").ToString
                Me.tbComp.Rows.Item(I).Item("CaminhoPastaSAT") = dtComp.Rows.Item(I).Item("CaminhoPastaSAT").ToString

                Me.tbComp.Rows.Item(I).Item("ModeloImpSAT") = dtComp.Rows.Item(I).Item("ModeloImpSAT").ToString
                Me.tbComp.Rows.Item(I).Item("NomeImpSAT") = dtComp.Rows.Item(I).Item("NomeImpSAT").ToString
                Me.tbComp.Rows.Item(I).Item("ImpDiretoSAT") = dtComp.Rows.Item(I).Item("ImpDiretoSAT").ToString
                Me.tbComp.Rows.Item(I).Item("MensImpCupomSAT") = dtComp.Rows.Item(I).Item("MensImpCupomSAT").ToString
            Next
        End If

    End Sub
    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExclui_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExclui.ItemClick
        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle
        If Index < 0 Then Exit Sub

        Dim strCnpj As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCnpj)
        Dim strNumSerie As String = Me.grd1.GetRowCellDisplayText(Index, Me.colNumSerie)

        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Excluir("Delete from ConfigECF where Cnpj = '" & strCnpj & "' and NumerioSerie = '" & strNumSerie & "'") = True Then
                MsgBox("Dado excluído com sucesso!", MsgBoxStyle.Information)
            End If

            CarregarGrid()

        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Validar(Me.txtComputador) = False Then Exit Sub
        If Validar(Me.txtNumCaixa) = False Then Exit Sub

        If bolAlt = False Then
            Me.tbComp.Rows.Add()
            Me.tbComp.Rows.Item(Me.tbComp.Rows.Count - 1).Item("Computador") = Me.txtComputador.Text
            Me.tbComp.Rows.Item(Me.tbComp.Rows.Count - 1).Item("NumCaixa") = Me.txtNumCaixa.Text
            Me.tbComp.Rows.Item(Me.tbComp.Rows.Count - 1).Item("ModeloImpSAT") = Me.cboModeloImp.Text
            Me.tbComp.Rows.Item(Me.tbComp.Rows.Count - 1).Item("CaminhoPastaSAT") = Me.txtPastaSAT.Text
            Me.tbComp.Rows.Item(Me.tbComp.Rows.Count - 1).Item("NomeImpSAT") = Me.txtNomeImp.Text
            Me.tbComp.Rows.Item(Me.tbComp.Rows.Count - 1).Item("ImpDiretoSAT") = Me.chkDireto.Checked
            Me.tbComp.Rows.Item(Me.tbComp.Rows.Count - 1).Item("MensImpCupomSAT") = Me.chkDireto.Checked

        Else
            Me.grd2.SetRowCellValue(Me.grd2.FocusedRowHandle, Me.colComputador, Me.txtComputador.Text)
            Me.grd2.SetRowCellValue(Me.grd2.FocusedRowHandle, Me.colNumCaixa, Me.txtNumCaixa.Text)

            Me.grd2.SetRowCellValue(Me.grd2.FocusedRowHandle, Me.colModeloImpSAT, Me.cboModeloImp.Text)
            Me.grd2.SetRowCellValue(Me.grd2.FocusedRowHandle, Me.colNomeImpSAT, Me.txtNomeImp.Text)
            Me.grd2.SetRowCellValue(Me.grd2.FocusedRowHandle, Me.colCaminhoPastaSAT, Me.txtPastaSAT.Text)
            Me.grd2.SetRowCellValue(Me.grd2.FocusedRowHandle, Me.colImpDiretoSAT, Me.chkDireto.Checked)
            Me.grd2.SetRowCellValue(Me.grd2.FocusedRowHandle, Me.colMensImpCupomSAT, Me.chkMensImpCupomSAT.Checked)
        End If

        bolAlt = False
        Me.txtComputador.ResetText()
        Me.txtNumCaixa.ResetText()
        Me.chkDireto.Checked = False
        Me.chkMensImpCupomSAT.Checked = False
        Me.cboModeloImp.SelectedIndex = -1
        Me.txtNomeImp.ResetText()
        Me.txtPastaSAT.ResetText()

        Me.txtComputador.Focus()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Alterar()
    End Sub

    Private Sub txtAlt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlt.DoubleClick
        If Me.grd2.FocusedRowHandle < 0 Then Exit Sub
        Dim intIndex As Integer = grd2.FocusedRowHandle

        Me.txtComputador.Text = Me.grd2.GetRowCellDisplayText(intIndex, Me.colComputador)
        Me.txtNumCaixa.Text = Me.grd2.GetRowCellDisplayText(intIndex, Me.colNumCaixa)
        Me.cboModeloImp.Text = Me.grd2.GetRowCellDisplayText(intIndex, Me.colModeloImpSAT)
        Me.txtPastaSAT.Text = Me.grd2.GetRowCellDisplayText(intIndex, Me.colCaminhoPastaSAT)
        Me.txtNomeImp.Text = Me.grd2.GetRowCellDisplayText(intIndex, Me.colNomeImpSAT)
        Me.chkDireto.Checked = Me.grd2.GetRowCellValue(intIndex, Me.colImpDiretoSAT)
        Me.chkMensImpCupomSAT.Checked = Me.grd2.GetRowCellValue(intIndex, Me.colMensImpCupomSAT)
        bolAlt = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grd2.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd2.FocusedRowHandle
        If Index < 0 Then Exit Sub

        Dim strCodigo As String = Me.grd2.GetRowCellDisplayText(Index, Me.colCodigo)

      
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.grd2.DeleteRow(Index)
            If strCodigo <> "" Then

                If Excluir("Delete from ConfigECF where Codigo = " & strCodigo) = True Then
                    MsgBox("Dado excluído com sucesso!", MsgBoxStyle.Information)
                End If

            End If
        End If
    End Sub
    Private Sub btnSAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAT.Click
        Me.fbdOpen.SelectedPath = ""
        Me.fbdOpen.ShowDialog()
        Me.txtPastaSAT.Text = fbdOpen.SelectedPath
    End Sub

    Private Sub btnSatServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSatServ.Click
        Me.fbdOpen.SelectedPath = ""
        Me.fbdOpen.ShowDialog()
        Me.txtCaminhoPastaSATServ.Text = fbdOpen.SelectedPath
    End Sub

    Private Sub btnNomePc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNomePc.Click
        Me.txtComputador.Text = My.Computer.Name.ToUpper
    End Sub

    Private Sub txtCNPJ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNPJ.KeyPress

        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarDocumento(Me.txtCNPJ, "Cnpj")
    End Sub

    Private Sub txtCNPJ_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.Leave
        If Me.txtCNPJ.Text.Trim = "" Then Exit Sub

        If ValidaCPF(Me.txtCNPJ.Text.Trim) = False Then
            Me.txtCNPJ.ResetText()
            Me.txtCNPJ.Focus()
            Exit Sub
        End If

        If Me.txtCNPJ.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCNPJ.ResetText()
            Exit Sub
        End If
    End Sub

    Private Sub txtIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIE.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
End Class