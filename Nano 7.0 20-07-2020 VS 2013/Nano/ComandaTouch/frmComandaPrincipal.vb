Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base


Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls

Imports DevExpress.XtraLayout.LayoutGroup
Imports Nano.clsFuncoes

Imports DevExpress.Utils
Imports System.Web.UI.ControlCollection
Imports System.Web.UI.Control
Imports System.Collections
Imports DevExpress.XtraEditors



Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.Events
Public Class frmComandaPrincipal
    Dim riPictureEdit As RepositoryItemMemoEdit
    Dim riPictureEdit1 As RepositoryItemPictureEdit

    Dim riMemoValor As RepositoryItemMemoEdit
    Dim strCodComanda As String

    Private Sub frmComandaPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormAberto = Me.Name
        Me.GridControl1.MainView = Me.LayoutView1
        LayoutView1.OptionsBehavior.AutoPopulateColumns = False
        'Dim imagem As Byte() = converteimagem(Me.PictureEdit4.Image)
        'CarregarDados("SELECT CodOrdens, case when Nome <> '' then Nome else 'CONSUMIDOR' end as Nome, " & _
        '"'Comanda Nº - ' + convert(varchar(10),CodComanda) + ' ' + CHAR(13)+CHAR(10) + CHAR(13)+CHAR(10) + 'Mesa Nº - ' + convert(varchar(10), " & _
        '"case when Mesa is null then '' else Mesa end) as Teste, (SElect Top 1 B.Imagem1 FROM Comanda B where B.CodOrdens = Comanda.CodOrdens) as Imagem1 FROM Comanda where Status = 'Aberto' " & _
        '"group by CodComanda, Mesa, Nome, CodOrdens", Me.GridControl1)


        CarregarDados("SELECT CodOrdens, case when Nome <> '' then Nome else 'CONSUMIDOR' end as Nome, " & _
        "'Comanda ' + convert(varchar(10),CodComanda) + ' ' +  CHAR(13)+CHAR(10) + 'Mesa ' + convert(varchar(10), " & _
        "case when Mesa is null then '' else Mesa end) as Teste, 'TOTAL R$'  + ' ' + CHAR(13)+CHAR(10) +  " & _
        "convert(Varchar(10),convert(numeric(15,2),sum(Qtd * ValorUnitario) + + (Select ValorEstorno FROM R7 where R7.CodUser = Comanda.CodOrdens and R7.CodConfig = Comanda.CodConfig))) as Valor, (SElect Top 1 B.Imagem1 " & _
        "FROM Comanda B where B.CodOrdens = Comanda.CodOrdens) as Imagem1, UPPER(Status) as Status FROM Comanda where Status <> 'Faturado' and Comanda.CodConfig = " & CodConfig & " " & _
        "group by CodComanda, Mesa, Nome, CodOrdens, Status, Comanda.CodConfig order by convert(integer,CodComanda)", Me.GridControl1)

        '    CarregarDados("SELECT CodOrdens, case when Nome <> '' then Nome else 'CONSUMIDOR' end as Nome, " & _
        '"CHAR(13)+CHAR(10) + 'Comanda ' + convert(varchar(10),CodComanda) + ' ' +  CHAR(13)+CHAR(10) + 'Mesa ' + convert(varchar(10), " & _
        '"case when Mesa is null then '' else Mesa end) + CHAR(13)+CHAR(10) + CHAR(13)+CHAR(10) +  ' ' + Status as Teste, 'TOTAL R$'  + ' ' + CHAR(13)+CHAR(10) +  " & _
        '"convert(Varchar(10),convert(numeric(15,2),sum(Qtd * ValorUnitario))) as Valor, (SElect Top 1 B.Imagem1 " & _
        '"FROM Comanda B where B.CodOrdens = Comanda.CodOrdens) as Imagem1, Status FROM Comanda where Status <> 'Faturado' " & _
        '"group by CodComanda, Mesa, Nome, CodOrdens, Status order by CodComanda", Me.GridControl1)


        LayoutView1.OptionsView.ShowCardCaption = False
        LayoutView1.OptionsView.ShowCardExpandButton = False
        GridControl1.Dock = DockStyle.Fill
        GridControl1.BackColor = CorFundo



        ' Create columns.
        Dim colFirstName As LayoutViewColumn = LayoutView1.Columns.AddField("CodOrdens")
        Dim colLastName As LayoutViewColumn = LayoutView1.Columns.AddField("Nome")
        Dim colPhoto As LayoutViewColumn = LayoutView1.Columns.AddField("Teste")
        Dim colImagem1 As LayoutViewColumn = LayoutView1.Columns.AddField("Imagem1")
        Dim colValor As LayoutViewColumn = LayoutView1.Columns.AddField("Valor")
        Dim colStatus As LayoutViewColumn = LayoutView1.Columns.AddField("Status")

        ' Access corresponding card fields.
        Dim fieldFirstName As LayoutViewField = colFirstName.LayoutViewField
        Dim fieldLastName As LayoutViewField = colLastName.LayoutViewField
        Dim fieldPhoto As LayoutViewField = colPhoto.LayoutViewField
        Dim fieldImagem1 As LayoutViewField = colImagem1.LayoutViewField
        Dim fieldValor As LayoutViewField = colValor.LayoutViewField
        Dim fieldStatus As LayoutViewField = colStatus.LayoutViewField


        Dim StyleFormatCondition As New StyleFormatCondition
        Me.LayoutView1.FormatConditions.Add(StyleFormatCondition)
        StyleFormatCondition.Column = colStatus
        StyleFormatCondition.Condition = FormatConditionEnum.Equal
        StyleFormatCondition.Value1 = "FECHADO"
        StyleFormatCondition.Appearance.BackColor = Color.Tomato
        StyleFormatCondition.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
        StyleFormatCondition.Appearance.ForeColor = CorFonte
        StyleFormatCondition.Appearance.TextOptions.HAlignment = HorzAlignment.Center

        'StyleFormatCondition.ApplyToRow = True


        ' Make the Photo field visible.
        colFirstName.Visible = False
        colLastName.Visible = True
        colPhoto.Visible = True
        colImagem1.Visible = True
        colValor.Visible = True
        colStatus.Visible = True

        'fieldLastName.Move(New LayoutItemDragController(fieldPhoto, fieldImagem1, _
        '    InsertLocation.After, LayoutType.Horizontal))

        'fieldLastName.Move(New LayoutItemDragController(fieldLastName, fieldImagem1, _
        '        InsertLocation.After, LayoutType.Horizontal))

        'fieldLastName.Move(New LayoutItemDragController(fieldLastName, fieldPhoto, _
        '       InsertLocation.After, LayoutType.Vertical))


        fieldLastName.Move(New LayoutItemDragController(fieldPhoto, fieldImagem1, _
        InsertLocation.After, LayoutType.Horizontal))

        fieldLastName.Move(New LayoutItemDragController(fieldLastName, fieldImagem1, _
                InsertLocation.After, LayoutType.Horizontal))

        fieldLastName.Move(New LayoutItemDragController(fieldLastName, fieldPhoto, _
               InsertLocation.After, LayoutType.Vertical))

        fieldLastName.Move(New LayoutItemDragController(fieldValor, fieldImagem1, _
             InsertLocation.After, LayoutType.Vertical))


        'fieldLastName.Move(New LayoutItemDragController(fieldStatus, fieldLastName, _
        '    InsertLocation.After, LayoutType.Vertical))

        'Dim riMemoValor As RepositoryItemMemoEdit
        riMemoValor = Me.GridControl1.RepositoryItems.Add("MemoEdit")
        riMemoValor.ScrollBars = ScrollBars.None
        'riMemoValor.AutoHeight = True
        colValor.ColumnEdit = riMemoValor
        colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        colValor.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        colValor.OptionsColumn.ReadOnly = True
        colStatus.OptionsColumn.ReadOnly = True


        Dim riMemoNome As RepositoryItemMemoEdit = Me.GridControl1.RepositoryItems.Add("MemoEdit")
        riMemoNome.ScrollBars = ScrollBars.None
        'riMemoValor.AutoHeight = True
        colLastName.ColumnEdit = riMemoNome
        colLastName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        colLastName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        colLastName.OptionsColumn.ReadOnly = True

        riPictureEdit = Me.GridControl1.RepositoryItems.Add("MemoEdit")
        riPictureEdit.ScrollBars = ScrollBars.None
        riPictureEdit.AutoHeight = True
        colPhoto.ColumnEdit = riPictureEdit
        colPhoto.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        colPhoto.AppearanceCell.TextOptions.VAlignment = HorzAlignment.Center
        colPhoto.OptionsColumn.ReadOnly = True


        riPictureEdit1 = Me.GridControl1.RepositoryItems.Add("PictureEdit")
        riPictureEdit1.SizeMode = PictureSizeMode.Stretch
        riPictureEdit1.CustomHeight = 50
        colImagem1.ColumnEdit = riPictureEdit1


        fieldValor.SizeConstraintsType = SizeConstraintsType.Custom
        fieldValor.MaxSize = New System.Drawing.Size(70, 50)
        fieldValor.MinSize = fieldValor.MaxSize
        fieldValor.TextVisible = False

        fieldImagem1.SizeConstraintsType = SizeConstraintsType.Custom
        fieldImagem1.MaxSize = New System.Drawing.Size(70, 50)
        fieldImagem1.MinSize = fieldImagem1.MaxSize
        fieldImagem1.TextVisible = False

        fieldPhoto.SizeConstraintsType = SizeConstraintsType.Custom
        fieldPhoto.MaxSize = New System.Drawing.Size(180, 80)
        fieldPhoto.MinSize = fieldPhoto.MaxSize
        fieldPhoto.TextVisible = False

        fieldLastName.SizeConstraintsType = SizeConstraintsType.Custom
        fieldLastName.MaxSize = New System.Drawing.Size(180, 50)
        fieldLastName.MinSize = fieldLastName.MaxSize
        fieldLastName.TextVisible = False

        fieldStatus.SizeConstraintsType = SizeConstraintsType.Custom
        fieldStatus.MaxSize = New System.Drawing.Size(180, 10)
        fieldStatus.MinSize = fieldStatus.MaxSize
        fieldStatus.TextVisible = False

        colPhoto.OptionsColumn.AllowFocus = False
        colFirstName.OptionsColumn.AllowFocus = False
        colLastName.OptionsColumn.AllowFocus = False
        colValor.OptionsColumn.AllowFocus = False
        colStatus.OptionsColumn.AllowFocus = False

        colFirstName.Caption = "Código"
        colLastName.Caption = "Grupo"

        colLastName.OptionsColumn.ReadOnly = True
        colPhoto.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point)
        colLastName.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
        colValor.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
        colStatus.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)


        colLastName.AppearanceCell.ForeColor = CorFonte
        colPhoto.AppearanceCell.ForeColor = CorFonte
        colValor.AppearanceCell.ForeColor = CorFonte
        colStatus.AppearanceCell.ForeColor = CorFonte

        colFirstName.Visible = False
        fieldFirstName.TextVisible = False
        fieldPhoto.TextVisible = False
        fieldValor.TextVisible = False

        fieldStatus.TextVisible = False


        fieldFirstName.Visibility = LayoutVisibility.Never

        fieldLastName.TextVisible = False
        'colLastName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        'colLastName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        ''colLastName.AppearanceCell.BackColor = Color.RoyalBlue
        colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        ' Set the card's minimum size.
        'LayoutView1.CardMinSize = New Size(30, 100)
        'altura/largura'

        LayoutView1.CardMinSize = New Size(250, 150)
        'LayoutView1.Appearance.ViewBackground.BackColor = Color.SkyBlue
        LayoutView1.Appearance.ViewBackground.BackColor = CorFundo
        'LayoutView1.Appearance.ViewBackground.BackColor2 = Color.AliceBlue

        LayoutView1.BorderStyle = BorderStyles.NoBorder

        GridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        GridControl1.LookAndFeel.UseDefaultLookAndFeel = False

        LayoutView1.Appearance.Card.BackColor = Color.Transparent
        LayoutView1.Appearance.CardCaption.BackColor = CorComanda
        LayoutView1.Appearance.CardCaption.BackColor2 = CorComanda
        LayoutView1.Appearance.CardCaption.GradientMode = Drawing2D.LinearGradientMode.Vertical

        'LayoutView1.Appearance.Card.Font = New System.Drawing.Font("Microsoft Sans Serif", 25, FontStyle.Bold, GraphicsUnit.Point)

        LayoutView1.Appearance.FocusedCardCaption.BackColor = Color.Orange
        LayoutView1.Appearance.HideSelectionCardCaption.BackColor = Color.Orange

        LayoutView1.Appearance.FieldEditingValue.BackColor = Color.Orange
        LayoutView1.Appearance.FieldEditingValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)

        LayoutView1.Appearance.FieldEditingValue.ForeColor = CorFonte
        'LayoutView1.Appearance.FocusedCardCaption.BorderColor = Color.Teal
        'LayoutView1.Appearance.FieldCaption.BackColor = Color.Black
        'LayoutView1.Appearance.FieldEditingValue.BackColor = Color.Red
        'LayoutView1.Appearance.FieldValue.BackColor = Color.Blue

        LayoutView1.Appearance.ViewBackground.GradientMode = Drawing2D.LinearGradientMode.Vertical


        LayoutView1.OptionsBehavior.ScrollVisibility = ScrollVisibility.Never

        LayoutView1.OptionsHeaderPanel.ShowPanButton = False
        LayoutView1.OptionsHeaderPanel.ShowCustomizeButton = False

        'LayoutView1.OptionsCarouselMode.RollAngle = 0.5
        'LayoutView1.OptionsCarouselMode.PitchAngle = 1.5
        LayoutView1.OptionsView.ShowCardLines = False
        LayoutView1.CheckLoaded()
        LayoutView1.CardHorzInterval = 20
        'LayoutView1.CardVertInterval = 5



        LayoutView1.OptionsMultiRecordMode.MultiColumnScrollBarOrientation = ScrollBarOrientation.Vertical
        LayoutView1.OptionsView.CardArrangeRule = LayoutCardArrangeRule.ShowWholeCards

        LayoutView1.OptionsView.ViewMode = LayoutViewMode.MultiRow
        'LayoutView1.OptionsMultiRecordMode.MaxCardColumns = 5
        'Me.PanelControl2.Enabled = False
        LayoutView1.OptionsView.ShowHeaderPanel = False

        LayoutView1.OptionsView.ShowCardCaption = False
        LayoutView1.OptionsView.ShowCardExpandButton = False


        LayoutView1.OptionsCustomization.AllowSort = False
        LayoutView1.OptionsCustomization.AllowFilter = False


        Dim t As MyLayoutViewScrollHelper = New MyLayoutViewScrollHelper(LayoutView1)

        Me.PictureEdit1.BackColor = CorFundo
        Me.PictureEdit2.BackColor = CorFundo
        Me.PictureEdit3.BackColor = CorFundo
        Me.txtCliente.BackColor = CorFundo
        Me.txtCliente.Properties.Appearance.BorderColor = CorProduto
        Me.txtCliente.Properties.Appearance.ForeColor = Color.LightGray
        Me.txtCliente.Properties.CharacterCasing = CharacterCasing.Normal
        Me.txtCliente.Text = "Digite o número da comanda/mesa"

        Dim I As Integer
        For I = 0 To LayoutView1.RowCount - 1
            If I = LayoutView1.FocusedRowHandle Then
                LayoutView1.SetRowCellValue(I, "Imagem1", Imagem2Comanda)

            Else
                LayoutView1.SetRowCellValue(I, "Imagem1", Imagem1Comanda)

            End If
        Next
    End Sub


    Private Sub LayoutView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LayoutView1.MouseDown
        StartScrolling()
        Dim hi As LayoutViewHitInfo = LayoutView1.CalcHitInfo(e.Location)
        If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left AndAlso hi.InField Then
            DXMouseEventArgs.GetMouseArgs(e).Handled = True
            LayoutView1.FocusedColumn = hi.Column
            LayoutView1.FocusedRowHandle = hi.RowHandle

            Dim I As Integer
            For I = 0 To LayoutView1.RowCount - 1
                If I = hi.RowHandle Then
                    LayoutView1.SetRowCellValue(I, "Imagem1", Imagem2Comanda)

                Else
                    LayoutView1.SetRowCellValue(I, "Imagem1", Imagem1Comanda)

                End If

           Next

        End If
        If e.Clicks = 2 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left AndAlso hi.InField Then
            LayoutView1.FocusedColumn = hi.Column
            LayoutView1.FocusedRowHandle = hi.RowHandle
            LayoutView1.ShowEditor()


            strCodComanda = Me.LayoutView1.GetRowCellDisplayText(LayoutView1.FocusedRowHandle, "CodOrdens")

            Dim dt As DataTable = CarregarDataTable("SELECT Status FROM Comanda where CodOrdens = " & strCodComanda & " and CodConfig = " & CodConfig)
            Dim strStatus As String = Me.LayoutView1.GetRowCellDisplayText(LayoutView1.FocusedRowHandle, "Status")
            If dt.Rows.Count > 0 Then
                strStatus = dt.Rows.Item(0).Item("Status").ToString.ToUpper
            End If

            If strStatus = "FECHADO" Then
                frmComandaMensagem.Tag = ""
                frmComandaMensagem.lblMensagem.Text = "Comanda fechada, não é possível alterar!"
                frmComandaMensagem.btnSim.Visible = False
                frmComandaMensagem.btnNao.Text = "Ok"
                frmComandaMensagem.Size = New System.Drawing.Size(572, 210)
                frmComandaMensagem.btnNao.Location = New System.Drawing.Point(194, 107)
                frmComandaMensagem.ShowDialog()
                Exit Sub
            End If
         
            Timer2.Start()
        End If
        'DXMouseEventArgs.GetMouseArgs(eTeste).Handled = True
        'downLocation2 = Control.MousePosition
        'SenderTeste = sender
        'eTeste = e
        'StartScrolling()

        'DXMouseEventArgs.GetMouseArgs(e).Handled = True
        ''If downLocation = downLocation2 Then
        ''    Dim view As LayoutView = TryCast(sender, LayoutView)
        ''    Dim hitInfo As LayoutViewHitInfo = view.CalcHitInfo(e.Location)
        ''    DXMouseEventArgs.GetMouseArgs(e).Handled = (hitInfo.HitTest = LayoutViewHitTest.LayoutItem OrElse hitInfo.HitTest = LayoutViewHitTest.CardCaption) AndAlso hitInfo.RowHandle = view.FocusedRowHandle
        ''Else
        ''    DXMouseEventArgs.GetMouseArgs(e).Handled = True
        ''End If
        'Dim view As LayoutView = TryCast(sender, LayoutView)
        'Dim hitInfo As LayoutViewHitInfo = view.CalcHitInfo(e.Location)
        'DXMouseEventArgs.GetMouseArgs(e).Handled = (hitInfo.HitTest = LayoutViewHitTest.LayoutItem OrElse hitInfo.HitTest = LayoutViewHitTest.CardCaption) AndAlso hitInfo.RowHandle = view.FocusedRowHandle

    End Sub

    Private Sub LayoutView1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LayoutView1.MouseLeave
        StopScrolling()
        'If downLocation2 = downLocation Then
        '    Dim view As LayoutView = TryCast(SenderTeste, LayoutView)
        '    Dim hitInfo As LayoutViewHitInfo = view.CalcHitInfo(eTeste.Location)
        '    DXMouseEventArgs.GetMouseArgs(eTeste).Handled = (hitInfo.HitTest = LayoutViewHitTest.LayoutItem OrElse hitInfo.HitTest = LayoutViewHitTest.CardCaption) AndAlso hitInfo.RowHandle = view.FocusedRowHandle
        'End If

    End Sub

    Private Sub LayoutView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LayoutView1.MouseUp
        StopScrolling()
        'If downLocation2 = downLocation Then
        '    Dim view As LayoutView = TryCast(SenderTeste, LayoutView)
        '    Dim hitInfo As LayoutViewHitInfo = view.CalcHitInfo(eTeste.Location)
        '    DXMouseEventArgs.GetMouseArgs(eTeste).Handled = (hitInfo.HitTest = LayoutViewHitTest.LayoutItem OrElse hitInfo.HitTest = LayoutViewHitTest.CardCaption) AndAlso hitInfo.RowHandle = view.FocusedRowHandle
        'End If
    End Sub

    'Private Sub LayoutView1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles LayoutView1.MouseWheel
    '    'Dim view As LayoutView = TryCast(sender, LayoutView)
    '    StartScrolling()
    '    DXMouseEventArgs.GetMouseArgs(e).Handled = True
    '    'Dim scrollBar As DevExpress.XtraEditors.VScrollBar = view.GridControl.Controls.OfType(Of DevExpress.XtraEditors.VScrollBar)().FirstOrDefault()
    '    'If scrollBar IsNot Nothing Then
    '    '    scrollBar.Value -= scrollBar.SmallChange * Math.Sign(e.Delta)
    '    'End If
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ScrollLayoutView()
    End Sub
    Private downLocation As Point
    Private timer As Timer = New Timer()

    Private Sub StartScrolling()
        downLocation = Control.MousePosition
        Timer1.Start()
    End Sub
    Private Sub StopScrolling()
        Timer1.[Stop]()
    End Sub

    Private Sub ScrollLayoutView()
        Dim delta As Integer = (downLocation.Y - Control.MousePosition.Y) / 50

        If delta <> 0 Then
            downLocation = Control.MousePosition
            LayoutView1.VisibleRecordIndex += delta
        End If
    End Sub

    'Private Sub ColorEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorEdit1.EditValueChanged
    '    GridControl1.BackColor = Me.ColorEdit1.EditValue
    '    LayoutView1.Appearance.ViewBackground.BackColor = Me.ColorEdit1.EditValue
    '    CorTela = Me.ColorEdit1.EditValue
    'End Sub

    'Private Sub ColorEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorEdit2.EditValueChanged
    '    LayoutView1.Appearance.CardCaption.BackColor = Me.ColorEdit2.EditValue
    '    CorCard = Me.ColorEdit2.EditValue
    'End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'FecharTeclado()
        'Me.Close()


        'frmComandaItens.MdiParent = MDIComanda
        'frmComandaItens.strCodComanda = strCodComanda
        'frmComandaItens.Show()
        'frmComandaItens.Dock = DockStyle.Fill
        'Dim proc As Process
        'For Each proc In Process.GetProcesses
        '    If proc.ProcessName = "TecladoNano" Then
        '        Try
        '            proc.Kill()
        '            proc.Close()
        '        Catch ex As Exception

        '        End Try
        '    End If
        'Next

        'FecharTeclado()
        Me.Close()
        frmComandaSetor.MdiParent = MDIComanda
        frmComandaSetor.strCodComanda = strCodComanda

        frmComandaSetor.Show()
        frmComandaSetor.Dock = DockStyle.Fill
        Timer2.Stop()
    End Sub


    Private Sub txtCliente_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.EditValueChanged
        ' LayoutView1.ActiveFilter.Clear()
        Dim strd As String = LayoutView1.ActiveFilterString

        If Me.txtCliente.Text <> "" And Me.txtCliente.Text <> "Digite o número da comanda/mesa" Then
            Me.txtCliente.Properties.CharacterCasing = CharacterCasing.Upper
            Dim strFiltro As String = Me.txtCliente.Text
            If strFiltro.Contains(" ") Then

                Dim vetFiltro As Array = Split(strFiltro.Trim, " ")
                Select Case vetFiltro.Length
                    Case 1
                        LayoutView1.ActiveFilterString = "[Teste] like '%" & vetFiltro(0) & "%'"

                    Case 2
                        LayoutView1.ActiveFilterString = "[Teste] like '%" & vetFiltro(0) & "%' or [Teste] like '%" & vetFiltro(1) & "%'"

                    Case 3
                        LayoutView1.ActiveFilterString = "[Teste] like '%" & vetFiltro(0) & "%' or [Teste] like '%" & vetFiltro(1) & "%' or [Nome] like '%" & vetFiltro(2) & "%'"
                    Case Else
                        LayoutView1.ActiveFilterString = "[Teste] like '%" & strFiltro & "%'"
                End Select

            Else

                LayoutView1.ActiveFilterString = "[Teste] like '%" & strFiltro & "%'"
            End If
        Else

            LayoutView1.ActiveFilterString = ""

        End If
        LayoutView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
        Me.txtCliente.SelectionStart = Me.txtCliente.Text.Length
    End Sub


    'Private Sub txtCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.GotFocus
    'If Me.txtCliente.Text = "Digite o numero da comanda/mesa" Then
    '    Me.txtCliente.Text = ""

    '    Me.txtCliente.Properties.Appearance.ForeColor = Color.Gray
    'End If

    'Me.pnlTeclado.Visible = True
    'System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\TecladoNano.exe")
    ''IniciaThreadTeclado()
    'End Sub

    Private Sub txtCliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.Leave
        If Me.txtCliente.Text = "" Then
            Me.txtCliente.Properties.Appearance.ForeColor = Color.LightGray
            Me.txtCliente.Properties.CharacterCasing = CharacterCasing.Normal
            Me.txtCliente.Text = "Digite o número da comanda/mesa"
        End If
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = False
            'FecharTeclado()
            FecharTecladoArquivo(False)

        End If
   
        Dim I As Integer
        For I = 0 To LayoutView1.RowCount - 1
            If I = LayoutView1.FocusedRowHandle Then
                LayoutView1.SetRowCellValue(I, "Imagem1", Imagem2Comanda)

            Else
                LayoutView1.SetRowCellValue(I, "Imagem1", Imagem1Comanda)

            End If
        Next
    End Sub

    'Private Sub txtCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.LostFocus
    'If Me.txtCliente.Text = "" Then
    '    Me.txtCliente.Properties.Appearance.ForeColor = Color.LightGray
    '    Me.txtCliente.Properties.CharacterCasing = CharacterCasing.Normal
    '    Me.txtCliente.Text = "Digite o numero da comanda/mesa"
    'End If

    'Me.pnlTeclado.Visible = False
    ''FecharTeclado()
    'Dim proc As Process
    'For Each proc In Process.GetProcesses
    '    If proc.ProcessName = "TecladoNano" Then
    '        Try
    '            proc.Kill()
    '            proc.Close()
    '        Catch ex As Exception

    '        End Try
    '    End If
    ''Next
    ' End Sub


    'Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
    '    If LayoutView1.FocusedRowHandle < 0 Then Exit Sub

    '    strCodComanda = Me.LayoutView1.GetRowCellDisplayText(LayoutView1.FocusedRowHandle, "CodOrdens")

    '    FecharTeclado()
    '    Me.Close()
    '    frmComandaItens.MdiParent = MDIComanda
    '    frmComandaItens.strCodComanda = strCodComanda
    '    frmComandaItens.Show()
    '    frmComandaItens.Dock = DockStyle.Fill
    'End Sub


    Private Sub txtCliente_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCliente.MouseDown
        If Me.txtCliente.Text = "Digite o número da comanda/mesa" Then
            Me.txtCliente.Text = ""

            Me.txtCliente.Properties.Appearance.ForeColor = Color.Gray
        End If
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = True
            'System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\TecladoNano.exe")
            AbrirTecladoArquivo(True)

        End If
   
        'IniciaThreadTeclado()
    End Sub

End Class