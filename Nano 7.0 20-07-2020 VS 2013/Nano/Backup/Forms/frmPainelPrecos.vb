Imports Nano.clsFuncoes
Public Class frmPainelPrecos
    Dim intCont As Integer = 0
    Dim intContPag As Integer = 0
    Dim intPagina As Integer
    Dim intTotalPagina As Integer
    Private Sub frmPainelPrecos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmPainelPrecos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.grd1.OptionsSelection.EnableAppearanceHideSelection = False
        Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = False

        CarregarGrid()
        Timer1.Start()
        Timer2.Start()
        Me.grd1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
    End Sub

    Private Sub CarregarGrid()
        'CarregarDados("SELECT CodigoInterno, Nome as Produto, convert(numeric(15,2),Valor) as ValorUnitario, UnidadeMedida as UM, 'R$' as RS FROM Produto where UnidadeMedida = 'KG'", Me.GridControl2)


        Dim dtProd As DataTable = CarregarDataTable("SELECT CodigoInterno, Nome as Produto, convert(numeric(15,2),Valor) as ValorUnitario, UnidadeMedida as UM, 'R$' as RS FROM Produto where UnidadeMedida = 'KG'")

        Dim intProd As Integer = dtProd.Rows.Count
        intProd = intProd + (10 - (intProd Mod 10))
        intTotalPagina = intProd / 10
        intPagina = 1
        Dim I As Integer
        For I = 0 To intProd - 1
            Me.tbProd.Rows.Add()
            If I > dtProd.Rows.Count - 1 Then
                Me.tbProd.Rows.Item(I).Item("CodigoInterno") = ""
                Me.tbProd.Rows.Item(I).Item("Produto") = ""
                Me.tbProd.Rows.Item(I).Item("ValorUnitario") = ""
                Me.tbProd.Rows.Item(I).Item("UM") = ""
                Me.tbProd.Rows.Item(I).Item("RS") = ""
            Else
                Me.tbProd.Rows.Item(I).Item("CodigoInterno") = dtProd.Rows.Item(I).Item("CodigoInterno").ToString
                Me.tbProd.Rows.Item(I).Item("Produto") = dtProd.Rows.Item(I).Item("Produto").ToString
                Me.tbProd.Rows.Item(I).Item("ValorUnitario") = dtProd.Rows.Item(I).Item("ValorUnitario").ToString & "  "
                Me.tbProd.Rows.Item(I).Item("UM") = dtProd.Rows.Item(I).Item("UM").ToString
                Me.tbProd.Rows.Item(I).Item("RS") = dtProd.Rows.Item(I).Item("RS").ToString

            End If
        Next
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If intTotalPagina > 1 Then
            If intContPag >= 30 Then
                intContPag = 0

                If intPagina <> intTotalPagina Then

                    'Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = True
                    'Me.grd1.OptionsSelection.EnableAppearanceHideSelection = True
                    'Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = True
                    'Me.grd1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always

                    Dim intRowHandle As Integer = (intPagina * 10)
                    'If intPagina = 1 Then
                    '    intRowHandle = 10
                    'End If
                    'Me.grd1.ClearSelection()
                    'Me.grd1.SelectRow(intRowHandle)
                    'Me.grd1.FocusedRowHandle = intRowHandle
                    ''Me.grd1.ShowEditor()
                    'Me.grd1.MakeRowVisible(intRowHandle, False)
                    Me.grd1.TopRowIndex = intRowHandle
                    'Me.grd1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
                    'Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = False
                    'Me.grd1.OptionsSelection.EnableAppearanceHideSelection = False
                    'Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = False
                    intPagina += 1
                Else
                    intPagina = 1
                    Me.grd1.TopRowIndex = intPagina - 1
                    'Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = True
                    'Me.grd1.OptionsSelection.EnableAppearanceHideSelection = True
                    'Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = True
                    ''Me.grd1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
                    'Dim intRowHandle As Integer = (1) - 1
                    'Me.grd1.ClearSelection()
                    'Me.grd1.SelectRow(intRowHandle)
                    'Me.grd1.FocusedRowHandle = intRowHandle
                    'Me.grd1.MakeRowVisible(intRowHandle, False)
                    'Me.grd1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
                    'Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = False
                    'Me.grd1.OptionsSelection.EnableAppearanceHideSelection = False
                    'Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = False

                End If

            End If
            intContPag += 1
        End If
    
        If intCont >= 900 Then
            CarregarGrid()
            intCont = 0
        End If

        intCont += 1
    End Sub
    Dim bolCalc As Boolean = False
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If bolCalc = False Then
            bolCalc = True
            Dim intH As Integer = Me.GridControl2.Size.Height
            intH = ((intH Mod 100) Mod 10) / 2
            Me.SimpleButton1.Size = New System.Drawing.Size(Me.SimpleButton1.Size.Width, Me.SimpleButton1.Size.Height + intH)
            Me.SimpleButton3.Size = New System.Drawing.Size(Me.SimpleButton3.Size.Width, Me.SimpleButton3.Size.Height + intH)

            Me.grd1.RowHeight = Me.GridControl2.Size.Height / 10
        End If
     

        SimpleButton1.Text = Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm") & "    "
    End Sub
End Class