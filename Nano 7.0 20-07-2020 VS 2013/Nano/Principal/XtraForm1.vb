Imports System.Diagnostics
Imports System.IO


Public Class XtraForm1

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ' Create object, passing in text
        Dim MyPrintObject As New TextPrint("<B>this will be bold</B>" + vbCrLf + "<ST=400>this will start at 400 pixels" & vbCrLf & "<e>Para sinalizar Expandido</e>")
        ' Set font, defaults to times new roman, 12 if omitted
        MyPrintObject.Font = New Font("Tahoma", 8)
        ' Issue print command
        MyPrintObject.Print()


    End Sub


    Public Class TextPrint
        ' Inherits all the functionality of a PrintDocument
        Inherits Printing.PrintDocument
        ' Private variables to hold default font and text
        Private fntPrintFont As Font
        Private strText As String
        Dim MySplitLine As String()
        Dim varStart As Integer = 0
        Dim varChar As Integer = 0
        ' New constructor
        Public Sub New(ByVal Text As String)
            ' Sets the file stream
            MyBase.New()
            varStart = 0
            strText = Text
            MySplitLine = strText.Split(vbCrLf)
        End Sub
        Public Property Text() As String
            Get
                Return strText
            End Get
            Set(ByVal Value As String)
                strText = Value
                MySplitLine = strText.Split(vbCrLf)
            End Set
        End Property
        Protected Overrides Sub OnBeginPrint(ByVal ev As Printing.PrintEventArgs)
            ' Run base code
            MyBase.OnBeginPrint(ev)
            ' Sets the default font
            If fntPrintFont Is Nothing Then
                fntPrintFont = New Font("Times New Roman", 12, FontStyle.Regular, GraphicsUnit.Point)
            End If
        End Sub
        Public Property Font() As Font
            ' Allows the user to override the default font
            Get
                Return fntPrintFont
            End Get
            Set(ByVal Value As Font)
                fntPrintFont = Value
            End Set
        End Property

        Protected Overrides Sub OnPrintPage(ByVal e As Printing.PrintPageEventArgs)
            ' Provides the print logic for our document

            ' Run base code
            MyBase.OnPrintPage(e)

            ' Draw the margins (for debugging).
            'e.Graphics.DrawRectangle(Pens.Red, e.MarginBounds)

            Dim the_font As Font = fntPrintFont
            Dim string_format As New StringFormat

            ' Draw the text left justified,
            ' wrap at words, and don't draw partial lines.
            string_format.Alignment = StringAlignment.Near
            string_format.FormatFlags = StringFormatFlags.LineLimit
            string_format.Trimming = StringTrimming.Word

            ' Draw some text.
            Dim ymin As Integer = e.MarginBounds.Top
            Dim layout_rect As RectangleF
            Dim text_size As SizeF
            Dim characters_fitted As Integer
            Dim lines_filled As Integer

            Static i As Integer
            For i = varStart To MySplitLine.GetUpperBound(0)
                ' get ready for the 1 char printing
                Dim smallArray As String(,)
                Dim xmin As Integer = e.MarginBounds.Left
                Dim varWord As RectangleF()
                ReDim varWord(1)
                Dim wordCountForLine As Integer = 0
                ' make sure a space prints if a two vbcrlf's are in a row
                If Trim(Len(MySplitLine(i))) = 1 Then
                    ReDim smallArray(3, 1)
                    smallArray(0, 0) = ""
                    smallArray(1, 0) = FontStyle.Regular
                    smallArray(2, 0) = -1
                    ymin += CInt(the_font.Height)
                Else
                    '***Special print 1 char at a time for formatting***
                    smallArray = checkBold(Trim(MySplitLine(i).ToString), fntPrintFont)
                    '***END print 1 char at a time for formatting***
                End If
                Dim x As Integer
                For x = varChar To smallArray.GetUpperBound(1) - 1
                    'remove blanks so ascii works
                    If smallArray(0, x).Length = 0 Then smallArray(0, x) = Chr(0)
                    ' Get the font for measurement.
                    the_font = New Font(fntPrintFont.Name, fntPrintFont.Size, _
                            CInt(smallArray(1, x)), fntPrintFont.Unit)
                    ' Set the text start location if desired
                    If CInt(smallArray(2, x)) > -1 Then xmin = CInt(smallArray(2, x))
                    ' Get the area available for this text.
                    layout_rect = New RectangleF(xmin, ymin, e.MarginBounds.Right - xmin, the_font.Height)
                    ' If the layout rectangle's height < 1, make it 1.
                    If layout_rect.Height < 1 Then layout_rect.Height = 1
                    ' See how big the text will be and
                    ' how many characters will fit.
                    text_size = e.Graphics.MeasureString(smallArray(0, x).ToString, the_font, _
                        New SizeF(layout_rect.Width, layout_rect.Height), _
                        string_format, characters_fitted, lines_filled)

                    ' See if any characters will fit.
                    If characters_fitted > 0 Then
                        ' start accumulating the print location
                        varWord(varWord.GetUpperBound(0) - 1) = layout_rect

                        ' ************Draw the word when finished.************
                        If Asc(smallArray(0, x).Chars(0)) = 32 Or x = smallArray.GetUpperBound(1) - 1 Then
                            Dim z As Integer
                            For z = x - (varWord.GetUpperBound(0) - 1) To x
                                ' Get the font for measurement.
                                the_font = New Font(fntPrintFont.Name, fntPrintFont.Size, _
                                       CInt(smallArray(1, z)), fntPrintFont.Unit)
                                ' actually print the character on the page.
                                e.Graphics.DrawString(smallArray(0, z), _
                                    the_font, Brushes.Black, _
                                    varWord((z - x) + (varWord.GetUpperBound(0) - 1)), string_format)
                            Next
                            xmin += 4
                            ReDim varWord(0)
                            wordCountForLine += 1
                        End If

                        '' Draw a rectangle around the text (for debugging).
                        'e.Graphics.DrawRectangle(Pens.Green, _
                        '    layout_rect.Left, _
                        '    layout_rect.Top, _
                        '    text_size.Width, _
                        '    text_size.Height)

                        ' Increase the location where we can start.
                        xmin += CInt(text_size.Width) - 4
                        ReDim Preserve varWord(varWord.GetUpperBound(0) + 1)
                    ElseIf Asc(smallArray(0, x).Chars(0)) < 30 Then
                        ' make sure to dispose of odd char's in the array
                    Else ' See if some of the paragraph didn't fit
                        ' ********Draw the word if longer than one line.**********
                        If wordCountForLine = 0 Then
                            varWord(varWord.GetUpperBound(0) - 1) = layout_rect
                            Dim z As Integer
                            For z = x - (varWord.GetUpperBound(0) - 1) To x
                                e.Graphics.DrawString(smallArray(0, z), _
                                    the_font, Brushes.Black, _
                                    varWord((z - x) + (varWord.GetUpperBound(0) - 1)), string_format)
                            Next
                            ReDim varWord(0)
                        End If

                        '*******reset the variables*********
                        wordCountForLine = 0
                        x -= varWord.GetUpperBound(0)
                        ReDim varWord(1)
                        xmin = e.MarginBounds.Left
                        ymin += CInt(the_font.Height) ' move to the next line
                        'see if there are more lines available
                        If (e.MarginBounds.Bottom - ymin) < the_font.Height Then
                            Exit For ' exit for loop so page can print
                        End If
                    End If
                Next
                ymin += CInt(the_font.Height) ' move to the next line
                If (e.MarginBounds.Bottom - ymin) < the_font.Height Then
                    varChar = x 'save character location
                    varStart = i 'save line location
                    e.HasMorePages = True 'after printing page, run sub again
                    Exit For ' exit for loop so page can print
                Else
                    varChar = 0
                    e.HasMorePages = False
                End If
            Next
        End Sub
        Private Function checkBold(ByVal varString As String, ByVal startFont As Font) As String(,)
            Dim aryString As String(,)
            ReDim aryString(3, 1)
            Dim printStyle As FontStyle = FontStyle.Regular
            Dim varStartPlace As Integer = -1

            aryString(0, 0) = "" 'initialize the array to avoid errors
            aryString(1, 0) = printStyle
            aryString(2, 0) = varStartPlace

            Dim varPlace As Integer = 0
            For varPlace = 1 To varString.Length
                If Mid(varString, varPlace, 3) = "<B>" Then
                    printStyle = FontStyle.Bold
                    varPlace += 2
                ElseIf Mid(varString, varPlace, 4) = "</B>" Then
                    printStyle = FontStyle.Regular
                    varPlace += 3
                ElseIf Mid(varString, varPlace, 4) = "<ST=" Then
                    varStartPlace = CInt(Mid(varString, varPlace + 4, _
                         InStr(varPlace + 4, varString, ">") - (varPlace + 4)))
                    varPlace += 4 + varStartPlace.ToString.Length
                Else
                    ReDim Preserve aryString(3, aryString.GetUpperBound(1) + 1)
                    aryString(0, aryString.GetUpperBound(1) - 1) = Mid(varString, varPlace, 1)
                    aryString(1, aryString.GetUpperBound(1) - 1) = printStyle
                    aryString(2, aryString.GetUpperBound(1) - 1) = varStartPlace
                    varStartPlace = -1
                End If
            Next
            checkBold = aryString

        End Function

    End Class

End Class