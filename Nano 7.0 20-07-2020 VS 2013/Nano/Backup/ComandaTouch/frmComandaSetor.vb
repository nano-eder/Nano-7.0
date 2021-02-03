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

Public Class frmComandaSetor
    Dim riPictureEdit As RepositoryItemPictureEdit
    Dim strSetor As String
    Dim meMemoEdit As RepositoryItemMemoEdit
    Public strCodComanda As String

    Private Sub frmfrmComandaSetor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormAberto = Me.Name
        Me.GridControl1.MainView = Me.LayoutView1
        LayoutView1.OptionsBehavior.AutoPopulateColumns = False

        CarregarDados("SELECT Codigo, Nome, Imagem FROM Grupo where Tipo = 'S'", Me.GridControl1)
        LayoutView1.OptionsView.ShowCardCaption = False
        LayoutView1.OptionsView.ShowCardExpandButton = False
        GridControl1.Dock = DockStyle.Fill
        GridControl1.BackColor = CorFundo
        ' Create columns.
        Dim colFirstName As LayoutViewColumn = LayoutView1.Columns.AddField("Codigo")
        Dim colLastName As LayoutViewColumn = LayoutView1.Columns.AddField("Nome")
        Dim colPhoto As LayoutViewColumn = LayoutView1.Columns.AddField("Imagem")
        ' Access corresponding card fields.
        Dim fieldFirstName As LayoutViewField = colFirstName.LayoutViewField
        Dim fieldLastName As LayoutViewField = colLastName.LayoutViewField
        Dim fieldPhoto As LayoutViewField = colPhoto.LayoutViewField

        ' Make the Photo field visible.
        colFirstName.Visible = False
        colPhoto.Visible = True

        colLastName.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
        colLastName.AppearanceCell.ForeColor = CorFonte

        fieldPhoto.SizeConstraintsType = SizeConstraintsType.Custom
        fieldPhoto.MaxSize = New System.Drawing.Size(150, 100)
        fieldPhoto.MinSize = fieldPhoto.MaxSize


        fieldLastName.SizeConstraintsType = SizeConstraintsType.Custom
        fieldLastName.MaxSize = New System.Drawing.Size(250, 100)
        fieldLastName.MinSize = fieldPhoto.MaxSize

        '' Position the FirstName field to the right of the Photo field.
        'fieldFirstName.Move(New LayoutItemDragController(fieldFirstName, fieldPhoto, _
        '    InsertLocation.After, LayoutType.Horizontal))
        ' Position the LastName field below the FirstName field.
        fieldLastName.Move(New LayoutItemDragController(fieldLastName, fieldPhoto, _
            InsertLocation.After, LayoutType.Horizontal))
        ' Create an Address Info group.



        meMemoEdit = Me.GridControl1.RepositoryItems.Add("MemoEdit")
        meMemoEdit.ScrollBars = ScrollBars.None
        colLastName.ColumnEdit = meMemoEdit

        ' Assign editors to card fields.
        riPictureEdit = Me.GridControl1.RepositoryItems.Add("PictureEdit")
        'Select Case Me.cboImagem.SelectedIndex
        '    Case 0
        '        riPictureEdit.SizeMode = PictureSizeMode.Clip
        '    Case 1
        riPictureEdit.SizeMode = PictureSizeMode.Stretch
        '    Case 2
        '        riPictureEdit.SizeMode = PictureSizeMode.Zoom
        '    Case 3
        '        riPictureEdit.SizeMode = PictureSizeMode.StretchHorizontal
        '    Case 4
        '        riPictureEdit.SizeMode = PictureSizeMode.StretchVertical
        '    Case 5
        '        riPictureEdit.SizeMode = PictureSizeMode.Squeeze
        'End Select
        'riPictureEdit.AutoHeight = False
        riPictureEdit.CustomHeight = 50
        riPictureEdit.BestFitWidth = 50
        colPhoto.ColumnEdit = riPictureEdit

        colLastName.OptionsColumn.AllowFocus = False

        ' Customize card field options.
        colFirstName.Caption = "Código"
        colLastName.Caption = "Grupo"

        colLastName.OptionsColumn.ReadOnly = True

        colFirstName.Visible = False
        fieldFirstName.TextVisible = False

        fieldFirstName.Visibility = LayoutVisibility.Never

        fieldLastName.TextVisible = False
        colLastName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        'colLastName.AppearanceCell.BackColor = Color.RoyalBlue

        'colLastName.AppearanceCell.BackColor = Color.Transparent
        fieldPhoto.TextVisible = False



        ' Set the card's minimum size.
        'altura/largura'
        LayoutView1.CardMinSize = New Size(30, 100)
        LayoutView1.Appearance.ViewBackground.BackColor = CorFundo
        LayoutView1.Appearance.ViewBackground.BackColor2 = CorFundo
        LayoutView1.BorderStyle = BorderStyles.NoBorder
        'LayoutView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.ShowAlways

        GridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        LayoutView1.Appearance.Card.BackColor = Color.Transparent
        'LayoutView1.Appearance.CardCaption.BackColor = Color.Transparent

        LayoutView1.Appearance.CardCaption.BackColor = CorGrupo
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
        ' LayoutView1.BorderStyle = BorderStyles.NoBorder

        LayoutView1.OptionsBehavior.ScrollVisibility = ScrollVisibility.Never

        LayoutView1.OptionsHeaderPanel.ShowPanButton = False
        LayoutView1.OptionsHeaderPanel.ShowCustomizeButton = False

        'LayoutView1.OptionsCarouselMode.RollAngle = 0.5
        'LayoutView1.OptionsCarouselMode.PitchAngle = 1.5
        LayoutView1.OptionsView.ShowCardLines = False
        LayoutView1.CheckLoaded()
        LayoutView1.CardHorzInterval = 15
        LayoutView1.CardVertInterval = 5

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
        Me.txtCliente.Text = "Digite o nome do grupo"
    End Sub

    Dim downLocation2 As Point

    Dim SenderTeste As Object
    Dim eTeste As System.Windows.Forms.MouseEventArgs
    Private Sub LayoutView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LayoutView1.MouseDown
        StartScrolling()
        Dim hi As LayoutViewHitInfo = LayoutView1.CalcHitInfo(e.Location)
        If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left AndAlso hi.InField Then
            DXMouseEventArgs.GetMouseArgs(e).Handled = True
            LayoutView1.FocusedColumn = hi.Column
            LayoutView1.FocusedRowHandle = hi.RowHandle
        End If
        If e.Clicks = 2 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left AndAlso hi.InField Then
            LayoutView1.FocusedColumn = hi.Column
            LayoutView1.FocusedRowHandle = hi.RowHandle
            LayoutView1.ShowEditor()

            strSetor = Me.LayoutView1.GetRowCellDisplayText(LayoutView1.FocusedRowHandle, "Nome")
          
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

    'Private Sub LayoutView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles LayoutView1.SelectionChanged
    '    Dim D As String = ""
    'End Sub

    'Private Sub LayoutView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles LayoutView1.FocusedRowChanged
    '    Dim D As String = ""
    'End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'FecharTeclado()
        FecharTecladoArquivo(False)

        Me.Close()


        frmComandaProduto.MdiParent = MDIComanda
        frmComandaProduto.strCodComanda = strCodComanda
        frmComandaProduto.strSetor = strSetor
        frmComandaProduto.Show()
        frmComandaProduto.Dock = DockStyle.Fill
        Timer2.Stop()
    End Sub

    'Private Sub ColorEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorEdit1.EditValueChanged
    '    GridControl1.BackColor = Me.ColorEdit1.EditValue
    '    LayoutView1.Appearance.ViewBackground.BackColor = Me.ColorEdit1.EditValue
    '    CorTela = Me.ColorEdit1.EditValue
    'End Sub

    Private Sub txtCliente_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.EditValueChanged
        ' LayoutView1.ActiveFilter.Clear()
        Dim strd As String = LayoutView1.ActiveFilterString

        If Me.txtCliente.Text <> "" And Me.txtCliente.Text <> "Digite o nome do grupo" Then
            Me.txtCliente.Properties.CharacterCasing = CharacterCasing.Upper
            Dim strFiltro As String = Me.txtCliente.Text
            If strFiltro.Contains(" ") Then

                Dim vetFiltro As Array = Split(strFiltro.Trim, " ")
                Select Case vetFiltro.Length
                    Case 1
                        LayoutView1.ActiveFilterString = "[Nome] like '%" & vetFiltro(0) & "%'"

                    Case 2
                        LayoutView1.ActiveFilterString = "[Nome] like '%" & vetFiltro(0) & "%' or [Nome] like '%" & vetFiltro(1) & "%'"

                    Case 3
                        LayoutView1.ActiveFilterString = "[Nome] like '%" & vetFiltro(0) & "%' or [Nome] like '%" & vetFiltro(1) & "%' or [Nome] like '%" & vetFiltro(2) & "%'"
                    Case Else
                        LayoutView1.ActiveFilterString = "[Nome] like '%" & strFiltro & "%'"
                End Select

            Else

                LayoutView1.ActiveFilterString = "[Nome] like '%" & strFiltro & "%'"
            End If
        Else

            LayoutView1.ActiveFilterString = ""

        End If
        LayoutView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
        Me.txtCliente.SelectionStart = Me.txtCliente.Text.Length
    End Sub

    Private Sub txtCliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.Leave
        If Me.txtCliente.Text = "" Then
            Me.txtCliente.Properties.Appearance.ForeColor = Color.LightGray
            Me.txtCliente.Properties.CharacterCasing = CharacterCasing.Normal
            Me.txtCliente.Text = "Digite o nome do grupo"
        End If
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = False
            'FecharTeclado()
            FecharTecladoArquivo(False)

        End If
    
    End Sub


    'Private Sub txtCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.GotFocus
    '    If Me.txtCliente.Text = "Digite o nome do grupo" Then
    '        Me.txtCliente.Text = ""

    '        Me.txtCliente.Properties.Appearance.ForeColor = Color.Gray
    '    End If
    '    Me.pnlTeclado.Visible = True
    '    IniciaThreadTeclado()
    'End Sub

    'Private Sub txtCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.LostFocus
    '    If Me.txtCliente.Text = "" Then
    '        Me.txtCliente.Properties.Appearance.ForeColor = Color.LightGray
    '        Me.txtCliente.Properties.CharacterCasing = CharacterCasing.Normal
    '        Me.txtCliente.Text = "Digite o nome do grupo"
    '    End If
    '    Me.pnlTeclado.Visible = False
    '    FecharTeclado()
    'End Sub

    Private Sub txtCliente_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCliente.MouseDown
        If Me.txtCliente.Text = "Digite o nome do grupo" Then
            Me.txtCliente.Text = ""

            Me.txtCliente.Properties.Appearance.ForeColor = Color.Gray
        End If
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = True
            'IniciaThreadTeclado()
            AbrirTecladoArquivo(True)
        End If
  
    End Sub
End Class