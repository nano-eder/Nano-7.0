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

Public Class frmComandaProduto
    Dim meMemoEdit As RepositoryItemMemoEdit
    Dim riPictureEdit As RepositoryItemPictureEdit
    Public strSetor As String
    Public strCodComanda As String
    Dim strProduto As String
    Dim strCodProduto As String


    Dim intCodProd1 As Integer
    Dim intCodProd2 As Integer
    Dim intCodProd3 As Integer
    Dim intCodProd4 As Integer

    Private Sub frmfrmComandaProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intCodProd1 = 0
        intCodProd2 = 0
        intCodProd3 = 0
        intCodProd4 = 0

        Me.cboMisto.SelectedIndex = 0
        FormAberto = Me.Name
        Me.GridControl1.MainView = Me.LayoutView1
        LayoutView1.OptionsBehavior.AutoPopulateColumns = False

        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor FROM Produto where Setor = '" & strSetor & "' and Inativo = 'False'", Me.GridControl1)
        LayoutView1.OptionsView.ShowCardCaption = False
        LayoutView1.OptionsView.ShowCardExpandButton = False
        GridControl1.Dock = DockStyle.Fill
        GridControl1.BackColor = CorFundo

        ' Create columns.
        Dim colFirstName As LayoutViewColumn = LayoutView1.Columns.AddField("Codigo")
        Dim colLastName As LayoutViewColumn = LayoutView1.Columns.AddField("Nome")
        Dim colPhoto As LayoutViewColumn = LayoutView1.Columns.AddField("Imagem")
        Dim colValor As LayoutViewColumn = LayoutView1.Columns.AddField("Valor")
       
        ' Access corresponding card fields.
        Dim fieldFirstName As LayoutViewField = colFirstName.LayoutViewField
        Dim fieldLastName As LayoutViewField = colLastName.LayoutViewField
        Dim fieldPhoto As LayoutViewField = colPhoto.LayoutViewField
        Dim fieldValor As LayoutViewField = colValor.LayoutViewField
      
        ' Make the Photo field visible.
        colFirstName.Visible = False
        colPhoto.Visible = True
        colValor.Visible = True
       
        colLastName.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
        colLastName.AppearanceCell.ForeColor = CorFonte
        colValor.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
        colValor.AppearanceCell.ForeColor = CorFonte

        fieldPhoto.SizeConstraintsType = SizeConstraintsType.Custom
        fieldPhoto.MaxSize = New System.Drawing.Size(150, 100)
        fieldPhoto.MinSize = fieldPhoto.MaxSize

        fieldLastName.SizeConstraintsType = SizeConstraintsType.Custom
        fieldLastName.MaxSize = New System.Drawing.Size(150, 70)
        fieldLastName.MinSize = fieldLastName.MaxSize

        meMemoEdit = Me.GridControl1.RepositoryItems.Add("MemoEdit")
        meMemoEdit.ScrollBars = ScrollBars.None
        colLastName.ColumnEdit = meMemoEdit

        '' Position the FirstName field to the right of the Photo field.
        'fieldFirstName.Move(New LayoutItemDragController(fieldFirstName, fieldPhoto, _
        '    InsertLocation.After, LayoutType.Vertical))
        '' Position the LastName field below the FirstName field.
        'fieldLastName.Move(New LayoutItemDragController(fieldLastName, fieldPhoto, _
        '    InsertLocation.After, LayoutType.Vertical))

        fieldLastName.Move(New LayoutItemDragController(fieldLastName, fieldPhoto, _
           InsertLocation.After, LayoutType.Horizontal))
        fieldLastName.Move(New LayoutItemDragController(fieldValor, fieldPhoto, _
                InsertLocation.After, LayoutType.Horizontal))

        fieldLastName.Move(New LayoutItemDragController(fieldValor, fieldLastName, _
               InsertLocation.After, LayoutType.Vertical))



        ' Create an Address Info group.

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
        riPictureEdit.CustomHeight = 50
        colPhoto.ColumnEdit = riPictureEdit


        colLastName.OptionsColumn.AllowFocus = False
        colValor.OptionsColumn.AllowFocus = False

        ' Customize card field options.
        colFirstName.Caption = "Código"
        colLastName.Caption = "Grupo"

        colLastName.OptionsColumn.ReadOnly = True
        'colValor.OptionsColumn.ReadOnly = True

        colFirstName.Visible = False
        fieldFirstName.TextVisible = False
        fieldValor.TextVisible = False

        fieldFirstName.Visibility = LayoutVisibility.Never

        fieldLastName.TextVisible = False
        colLastName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

        'colLastName.AppearanceCell.BackColor = Color.RoyalBlue

        'colLastName.AppearanceCell.BackColor = Color.Transparent
        fieldPhoto.TextVisible = False


        ' Set the card's minimum size.
        'altura/largura'
        LayoutView1.CardMinSize = New Size(30, 100)
        colLastName.OptionsColumn.FixedWidth = True
        LayoutView1.Appearance.ViewBackground.BackColor = CorFundo
        'LayoutView1.Appearance.ViewBackground.BackColor2 = Color.AliceBlue

        LayoutView1.Appearance.FocusedCardCaption.BackColor = Color.Orange
        LayoutView1.Appearance.HideSelectionCardCaption.BackColor = Color.Orange

        LayoutView1.Appearance.FieldEditingValue.BackColor = Color.Orange
        LayoutView1.Appearance.FieldEditingValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
        LayoutView1.Appearance.FieldEditingValue.ForeColor = CorFonte

        GridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        LayoutView1.BorderStyle = BorderStyles.NoBorder
        LayoutView1.Appearance.Card.BackColor = Color.Transparent
        LayoutView1.Appearance.CardCaption.BackColor = CorProduto
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
        Me.txtCliente.Text = "Digite o nome do produto"

        Me.cboMisto.BackColor = CorFundo
        Me.cboMisto.Properties.Appearance.BorderColor = CorProduto
        Me.cboMisto.Properties.Appearance.ForeColor = Color.LightGray

        GridMisto()
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

            strProduto = Me.LayoutView1.GetRowCellDisplayText(LayoutView1.FocusedRowHandle, "Nome")
            strCodProduto = Me.LayoutView1.GetRowCellDisplayText(LayoutView1.FocusedRowHandle, "Codigo")


            Select Case Me.cboMisto.SelectedIndex
                Case 0
                    Timer2.Start()
                Case 1
                    If intCodProd1 = 0 Then
                        intCodProd1 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' union all SELECT top 1 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)

                    Else
                        intCodProd2 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd2 & " and Inativo = 'False'", Me.GridControl2)

                        Timer2.Start()
                    End If
                Case 2
                    If intCodProd1 = 0 Then
                        intCodProd1 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' union all SELECT top 2 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)
                    ElseIf intCodProd2 = 0 Then
                        intCodProd2 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd2 & " and Inativo = 'False' union all SELECT top 1 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)
                    Else
                        intCodProd3 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd2 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd3 & " and Inativo = 'False'", Me.GridControl2)
                        Timer2.Start()
                    End If
                Case 3
                    If intCodProd1 = 0 Then
                        intCodProd1 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' union all SELECT top 3 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)
                    ElseIf intCodProd2 = 0 Then
                        intCodProd2 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd2 & " and Inativo = 'False' union all SELECT top 2 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)
                    ElseIf intCodProd3 = 0 Then
                        intCodProd3 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd2 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd3 & " and Inativo = 'False' union all SELECT top 1 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)
                    Else
                        intCodProd4 = strCodProduto
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd2 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd3 & " and Inativo = 'False' " & _
                        "UNION ALL SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd4 & " and Inativo = 'False'", Me.GridControl2)
                        Timer2.Start()
                    End If
            End Select

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

    Private Sub txtCliente_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.EditValueChanged
        If Me.txtCliente.Text <> "" And Me.txtCliente.Text <> "Digite o nome do produto" Then
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
            Me.txtCliente.Text = "Digite o nome do produto"
        End If
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = False
            'FecharTeclado()

            FecharTecladoArquivo(False)

        End If
     
    End Sub
    'Private Sub txtCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.GotFocus
    '    If Me.txtCliente.Text = "Digite o nome do produto" Then
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
    '        Me.txtCliente.Text = "Digite o nome do produto"
    '    End If
    '    Me.pnlTeclado.Visible = False
    '    FecharTeclado()
    'End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'FecharTeclado()
        Dim bolMisto As Boolean = False
        If Me.cboMisto.SelectedIndex > 0 Then
            bolMisto = True
            LayoutView2.Columns.Item("Valor2").SortOrder = DevExpress.Data.ColumnSortOrder.Descending

            Dim I As Integer
            For I = 0 To LayoutView2.RowCount - 1

                Dim dblValor As Double = LayoutView2.GetRowCellDisplayText(I, "Valor2")

                If I = 0 Then
                    strCodProduto = LayoutView2.GetRowCellDisplayText(I, "Codigo")
                    strProduto = LayoutView2.GetRowCellDisplayText(I, "Nome")
                Else
                    strProduto &= "|" & LayoutView2.GetRowCellDisplayText(I, "Nome")
                End If

            Next
        End If


        FecharTecladoArquivo(False)

        Me.Close()

        frmComandaQtde.MdiParent = MDIComanda
        frmComandaQtde.txtQtde.Text = "1"
        frmComandaQtde.strSetor = strSetor
        frmComandaQtde.strCodComanda = strCodComanda
        frmComandaQtde.txtProduto.Text = strProduto
        frmComandaQtde.strCodProduto = strCodProduto
        frmComandaQtde.bolMisto = bolMisto
        frmComandaQtde.Show()
        frmComandaQtde.Dock = DockStyle.Fill
        Timer2.Stop()
    End Sub

    'Private Sub txtCliente_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles txtCliente.Paint
    '    Dim rec As RectangleF = e.Graphics.ClipBounds
    '    rec.Inflate(-1, -1)
    '    e.Graphics.DrawRectangle(Pens.Red, rec.Left, rec.Top, rec.Width, rec.Height)
    'End Sub

    Private Sub txtCliente_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCliente.MouseDown
        If Me.txtCliente.Text = "Digite o nome do produto" Then
            Me.txtCliente.Text = ""

            Me.txtCliente.Properties.Appearance.ForeColor = Color.Gray
        End If
        If TecladoVirtual = True Then
            Me.pnlTeclado.Visible = True
            'IniciaThreadTeclado()

            AbrirTecladoArquivo(True)

        End If
   
    End Sub

    Private Sub cboMisto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMisto.SelectedIndexChanged
        intCodProd1 = 0
        intCodProd2 = 0
        intCodProd3 = 0
        intCodProd4 = 0
        Select Case Me.cboMisto.SelectedIndex
            Case 0
                Me.PanelControl2.Visible = False
            Case 1
                Me.PanelControl2.Visible = True
                CarregarDados("SELECT top 2 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor FROM Produto", Me.GridControl2)

            Case 2
                Me.PanelControl2.Visible = True
                CarregarDados("SELECT top 3 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor FROM Produto", Me.GridControl2)

            Case 3
                Me.PanelControl2.Visible = True
                CarregarDados("SELECT top 4 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor FROM Produto", Me.GridControl2)

        End Select
        'Dim intCardH As Integer = Me.LayoutView1.Items(0).Size.Height
        'Dim intCardW As Integer = Me.LayoutView1.Items(0).Size.Width



    End Sub

    Private Sub GridMisto()
        Me.GridControl2.MainView = Me.LayoutView2
        LayoutView2.OptionsBehavior.AutoPopulateColumns = False

        'CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor FROM Produto where Setor = '" & strSetor & "' and Inativo = 'False'", Me.GridControl1)
        LayoutView2.OptionsView.ShowCardCaption = False
        LayoutView2.OptionsView.ShowCardExpandButton = False
        GridControl2.Dock = DockStyle.Fill
        GridControl2.BackColor = CorFundo

        ' Create columns.
        Dim colFirstName2 As LayoutViewColumn = LayoutView2.Columns.AddField("Codigo")
        Dim colLastName2 As LayoutViewColumn = LayoutView2.Columns.AddField("Nome")
        Dim colPhoto2 As LayoutViewColumn = LayoutView2.Columns.AddField("Imagem")
        Dim colValor2 As LayoutViewColumn = LayoutView2.Columns.AddField("Valor")
        Dim colValorR As LayoutViewColumn = LayoutView2.Columns.AddField("Valor2")

        ' Access corresponding card fields.
        Dim fieldFirstName2 As LayoutViewField = colFirstName2.LayoutViewField
        Dim fieldLastName2 As LayoutViewField = colLastName2.LayoutViewField
        Dim fieldPhoto2 As LayoutViewField = colPhoto2.LayoutViewField
        Dim fieldValor2 As LayoutViewField = colValor2.LayoutViewField
        Dim fieldValorR As LayoutViewField = colValorR.LayoutViewField

        ' Make the Photo field visible.
        colFirstName2.Visible = False
        colPhoto2.Visible = True
        colValor2.Visible = True
        colValorR.Visible = False

        colLastName2.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
        colLastName2.AppearanceCell.ForeColor = CorFonte
        colValor2.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
        colValor2.AppearanceCell.ForeColor = CorFonte

        fieldPhoto2.SizeConstraintsType = SizeConstraintsType.Custom
        fieldPhoto2.MaxSize = New System.Drawing.Size(150, 100)
        fieldPhoto2.MinSize = fieldPhoto2.MaxSize

        fieldLastName2.SizeConstraintsType = SizeConstraintsType.Custom
        fieldLastName2.MaxSize = New System.Drawing.Size(150, 70)
        fieldLastName2.MinSize = fieldLastName2.MaxSize


        Dim meMemoEdit2 As RepositoryItemMemoEdit
        Dim riPictureEdit2 As RepositoryItemPictureEdit

        meMemoEdit2 = Me.GridControl1.RepositoryItems.Add("MemoEdit")
        meMemoEdit2.ScrollBars = ScrollBars.None
        colLastName2.ColumnEdit = meMemoEdit2

        '' Position the FirstName field to the right of the Photo field.
        'fieldFirstName.Move(New LayoutItemDragController(fieldFirstName, fieldPhoto, _
        '    InsertLocation.After, LayoutType.Vertical))
        '' Position the LastName field below the FirstName field.
        'fieldLastName.Move(New LayoutItemDragController(fieldLastName, fieldPhoto, _
        '    InsertLocation.After, LayoutType.Vertical))

        fieldLastName2.Move(New LayoutItemDragController(fieldLastName2, fieldPhoto2, _
           InsertLocation.After, LayoutType.Horizontal))
        fieldLastName2.Move(New LayoutItemDragController(fieldValor2, fieldPhoto2, _
                InsertLocation.After, LayoutType.Horizontal))

        fieldLastName2.Move(New LayoutItemDragController(fieldValor2, fieldLastName2, _
               InsertLocation.After, LayoutType.Vertical))



        ' Create an Address Info group.

        ' Assign editors to card fields.
        riPictureEdit2 = Me.GridControl2.RepositoryItems.Add("PictureEdit")
        'Select Case Me.cboImagem.SelectedIndex
        '    Case 0
        '        riPictureEdit.SizeMode = PictureSizeMode.Clip
        '    Case 1
        riPictureEdit2.SizeMode = PictureSizeMode.Stretch
        '    Case 2
        '        riPictureEdit.SizeMode = PictureSizeMode.Zoom
        '    Case 3
        '        riPictureEdit.SizeMode = PictureSizeMode.StretchHorizontal
        '    Case 4
        '        riPictureEdit.SizeMode = PictureSizeMode.StretchVertical
        '    Case 5
        '        riPictureEdit.SizeMode = PictureSizeMode.Squeeze
        'End Select
        riPictureEdit2.CustomHeight = 50
        colPhoto2.ColumnEdit = riPictureEdit2


        colLastName2.OptionsColumn.AllowFocus = False
        colValor2.OptionsColumn.AllowFocus = False

        ' Customize card field options.
        colFirstName2.Caption = "Código"
        colLastName2.Caption = "Grupo"

        colLastName2.OptionsColumn.ReadOnly = True
        'colValor.OptionsColumn.ReadOnly = True

        colFirstName2.Visible = False
        fieldFirstName2.TextVisible = False
        fieldValor2.TextVisible = False

        fieldFirstName2.Visibility = LayoutVisibility.Never

        fieldLastName2.TextVisible = False
        colLastName2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        colValor2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

        'colLastName.AppearanceCell.BackColor = Color.RoyalBlue

        'colLastName.AppearanceCell.BackColor = Color.Transparent
        fieldPhoto2.TextVisible = False


        ' Set the card's minimum size.
        'altura/largura'
        LayoutView2.CardMinSize = New Size(30, 100)
        colLastName2.OptionsColumn.FixedWidth = True
        LayoutView2.Appearance.ViewBackground.BackColor = CorFundo
        'LayoutView1.Appearance.ViewBackground.BackColor2 = Color.AliceBlue

        LayoutView2.Appearance.FocusedCardCaption.BackColor = Color.Orange
        LayoutView2.Appearance.HideSelectionCardCaption.BackColor = Color.Orange

        LayoutView2.Appearance.FieldEditingValue.BackColor = Color.Orange
        LayoutView2.Appearance.FieldEditingValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
        LayoutView2.Appearance.FieldEditingValue.ForeColor = CorFonte

        GridControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        GridControl2.LookAndFeel.UseDefaultLookAndFeel = False
        LayoutView2.BorderStyle = BorderStyles.NoBorder
        LayoutView2.Appearance.Card.BackColor = Color.Transparent
        LayoutView2.Appearance.CardCaption.BackColor = CorComanda
        'LayoutView1.Appearance.FocusedCardCaption.BorderColor = Color.Teal
        'LayoutView1.Appearance.FieldCaption.BackColor = Color.Black
        'LayoutView1.Appearance.FieldEditingValue.BackColor = Color.Red
        'LayoutView1.Appearance.FieldValue.BackColor = Color.Blue


        LayoutView2.Appearance.ViewBackground.GradientMode = Drawing2D.LinearGradientMode.Vertical
        ' LayoutView1.BorderStyle = BorderStyles.NoBorder

        LayoutView2.OptionsBehavior.ScrollVisibility = ScrollVisibility.Never

        LayoutView2.OptionsHeaderPanel.ShowPanButton = False
        LayoutView2.OptionsHeaderPanel.ShowCustomizeButton = False

        'LayoutView1.OptionsCarouselMode.RollAngle = 0.5
        'LayoutView1.OptionsCarouselMode.PitchAngle = 1.5
        LayoutView2.OptionsView.ShowCardLines = False
        LayoutView2.CheckLoaded()
        LayoutView2.CardHorzInterval = 15
        LayoutView2.CardVertInterval = 5

        LayoutView2.OptionsMultiRecordMode.MultiColumnScrollBarOrientation = ScrollBarOrientation.Vertical
        LayoutView2.OptionsView.CardArrangeRule = LayoutCardArrangeRule.ShowWholeCards

        LayoutView2.OptionsView.ViewMode = LayoutViewMode.MultiRow
        'LayoutView1.OptionsMultiRecordMode.MaxCardColumns = 5
        'Me.PanelControl2.Enabled = False
        LayoutView2.OptionsView.ShowHeaderPanel = False

        LayoutView2.OptionsView.ShowCardCaption = False
        LayoutView2.OptionsView.ShowCardExpandButton = False


        LayoutView2.OptionsCustomization.AllowSort = False
        LayoutView2.OptionsCustomization.AllowFilter = False

        Dim t As MyLayoutViewScrollHelper = New MyLayoutViewScrollHelper(LayoutView2)

        LayoutView2.Appearance.FocusedCardCaption.BackColor = CorComanda
        LayoutView2.Appearance.HideSelectionCardCaption.BackColor = CorComanda

        LayoutView2.Appearance.FieldEditingValue.BackColor = CorComanda
    End Sub

    Private Sub LayoutView2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LayoutView2.GotFocus
        LayoutView2.Appearance.FocusedCardCaption.BackColor = Color.Orange
        LayoutView2.Appearance.HideSelectionCardCaption.BackColor = Color.Orange

        LayoutView2.Appearance.FieldEditingValue.BackColor = Color.Orange
    End Sub

 
    Private Sub LayoutView2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LayoutView2.LostFocus

        LayoutView2.Appearance.FocusedCardCaption.BackColor = CorComanda
        LayoutView2.Appearance.HideSelectionCardCaption.BackColor = CorComanda

        LayoutView2.Appearance.FieldEditingValue.BackColor = CorComanda
    
    End Sub


    Private Sub LayoutView2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LayoutView2.MouseDown
        Dim hi As LayoutViewHitInfo = LayoutView2.CalcHitInfo(e.Location)
        If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left AndAlso hi.InField Then
            DXMouseEventArgs.GetMouseArgs(e).Handled = True
            LayoutView2.FocusedColumn = hi.Column
            LayoutView2.FocusedRowHandle = hi.RowHandle
        End If
        If e.Clicks = 2 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left AndAlso hi.InField Then
            LayoutView2.FocusedColumn = hi.Column
            LayoutView2.FocusedRowHandle = hi.RowHandle
            LayoutView2.ShowEditor()

            Dim strCodProduto2 As String = Me.LayoutView2.GetRowCellDisplayText(LayoutView2.FocusedRowHandle, "Codigo")
            Dim I As Integer
            intCodProd1 = 0
            intCodProd2 = 0
            intCodProd3 = 0
            intCodProd4 = 0

            Select Case Me.cboMisto.SelectedIndex
                Case 0
                Case 1
                    CarregarDados("SELECT top 2 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor FROM Produto", Me.GridControl2)
                Case 2


                    For I = 0 To LayoutView2.RowCount - 1

                        Dim strCP As String = LayoutView2.GetRowCellDisplayText(I, "Codigo")
                        If strCP <> "0" Then
                            If strCP <> strCodProduto2 Then
                                intCodProd1 = strCP
                            Else
                                strCodProduto2 = "0"
                            End If

                        End If
                   

                    Next
                    If intCodProd1 > 0 Then
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' union all SELECT top 2 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)
                    Else
                        CarregarDados("SELECT top 3 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor FROM Produto", Me.GridControl2)

                    End If
                Case 3

                    For I = 0 To LayoutView2.RowCount - 1

                        Dim strCP As String = LayoutView2.GetRowCellDisplayText(I, "Codigo")
                        If strCP <> "0" Then
                            If strCP <> strCodProduto2 Then
                                If intCodProd1 > 0 Then
                                    intCodProd2 = strCP
                                Else
                                    intCodProd1 = strCP
                                End If
                            Else
                                strCodProduto2 = "0"
                            End If
                        End If


                    Next

                    If intCodProd2 > 0 Then
                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & "  or  Codigo = " & intCodProd2 & " and Inativo = 'False' union all SELECT top 2 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)
                    ElseIf intCodProd1 > 0 Then

                        CarregarDados("SELECT Codigo, Nome, Imagem1 as Imagem, 'R$ ' + replace(convert(Varchar(20),convert(numeric(15,2),Valor)),'.',',') as Valor, Valor as Valor2 FROM Produto where Codigo = " & intCodProd1 & " and Inativo = 'False' union all SELECT top 3 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor, '0' as Valor2 FROM Produto", Me.GridControl2)
                    Else
                        CarregarDados("SELECT top 4 '0' as Codigo, 'INSERIR PRODUTO' as Nome, null as Imagem, '' as Valor FROM Produto", Me.GridControl2)
                    End If
            End Select

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
End Class