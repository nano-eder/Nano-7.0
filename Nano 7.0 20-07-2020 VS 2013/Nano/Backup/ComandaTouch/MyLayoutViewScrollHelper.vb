Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.Events
Public Class MyLayoutViewScrollHelper
    Private _SelectedLayoutView As LayoutView
    Private locked As Boolean
    Private forward As Boolean
    Private visibleIndex As Integer
    Public Property SelectedLayoutView() As LayoutView
        Get
            Return _SelectedLayoutView
        End Get
        Set(ByVal value As LayoutView)
            _SelectedLayoutView = value
        End Set
    End Property

    Public Sub New(ByVal view As LayoutView)
        SelectedLayoutView = view
        AddHandler SelectedLayoutView.VisibleRecordIndexChanged, AddressOf SelectedLayoutView_VisibleRecordIndexChanged
        SelectedLayoutView.OptionsView.ViewMode = LayoutViewMode.MultiRow
        SelectedLayoutView.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical
        locked = False
        visibleIndex = -1
    End Sub

    Private Sub SelectedLayoutView_VisibleRecordIndexChanged(ByVal sender As Object, ByVal e As LayoutViewVisibleRecordIndexChangedEventArgs)
        Dim layoutView As LayoutView = TryCast(sender, LayoutView)
        Dim viewInfo As LayoutViewInfo = TryCast(layoutView.GetViewInfo(), LayoutViewInfo)
        Dim visibleCards As Integer = viewInfo.VisibleCards.Count
        Dim firstRow As Integer = viewInfo.VisibleCards(0).VisibleRow
        Dim lastRow As Integer = viewInfo.VisibleCards(viewInfo.VisibleCards.Count - 1).VisibleRow
        Dim rowCount As Integer = lastRow - firstRow + 1
        Dim itemsInRow As Integer = visibleCards \ rowCount
        If locked Then
            Return
        End If
        locked = True
        If visibleIndex < (TryCast(sender, LayoutView)).VisibleRecordIndex Then
            forward = True
        Else
            forward = False
        End If
        'forward = If (visibleIndex < (TryCast(sender, LayoutView)).VisibleRecordIndex,  True, False)
        layoutView.VisibleRecordIndex = e.PrevVisibleRecordIndex
        If forward = True Then
            layoutView.VisibleRecordIndex += itemsInRow
        Else
            layoutView.VisibleRecordIndex -= itemsInRow
        End If
        locked = False
        visibleIndex = layoutView.VisibleRecordIndex
    End Sub


End Class
