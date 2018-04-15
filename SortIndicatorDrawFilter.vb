Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Diagnostics
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

#Region " SortIndicatorDrawFilter "

Public Class SortIndicatorDrawFilter
    Implements IUIElementDrawFilter

#Region " Data "

  'Protected ReadOnly ascendingImage As String
  'Protected ReadOnly descendingImage As String

#End Region

#Region " Constructor "

  'Public Sub New(ByVal ascendingImage As String, ByVal descendingImage As String)
  '    ' Perform some safety checks.
  '    If Not File.Exists(ascendingImage) Then
  '        Throw New ArgumentException("The 'ascendingImage' argument (" & ascendingImage & ") is not an existing file.")
  '    End If

  '    If Not File.Exists(descendingImage) Then
  '        Throw New ArgumentException("The 'descendingImage' argument (" & descendingImage & ") is not an existing file.")
  '    End If

  '    ' Initialize the member data.
  'Me.ascendingImage = ascendingImage
  'Me.descendingImage = descendingImage
  'End Sub

#End Region

#Region " IUIElementDrawFilter members "

#Region " GetPhasesToFilter "

  Overridable Overloads Function GetPhasesToFilter(ByRef drawParams As UIElementDrawParams) As DrawPhase Implements IUIElementDrawFilter.GetPhasesToFilter
    ' If a sort indicator element is about to be rendered, then we want our filter to be used
    ' just before it is actually rendered so that we can provide our own custom rendering.
    If drawParams.Element.GetType().Equals(GetType(SortIndicatorUIElement)) Then
      Return DrawPhase.BeforeDrawElement
    Else
      Return DrawPhase.None
    End If
  End Function

#End Region

#Region " DrawElement "

  ' To return FALSE from this method indicates that the element should draw itself as normal.
  ' To return TRUE  from this method indicates that the element should not draw itself. 
  Overridable Overloads Function DrawElement(ByVal phase As DrawPhase, ByRef drawParams As UIElementDrawParams) As Boolean Implements IUIElementDrawFilter.DrawElement

    ' Get the column header to which the sort indicator belongs.
    Dim header As ColumnHeader = CType(drawParams.Element.GetContext(GetType(ColumnHeader)), ColumnHeader)

    ' Just to be safe...
    If header Is Nothing Or header.Column Is Nothing Then
      Return False
    End If

    ' Find out if the column associated with the column header is being sorted ascending or descending.  
    Dim sortAscending As Boolean
    If header.Column.SortIndicator = SortIndicator.Ascending Then
      sortAscending = True
    Else
      sortAscending = False
    End If

    ' Get the rectangle in which the sort indicator exists and decrease the height a little
    ' so that the bottom of the image does not interfere with the thin line that a header 
    ' draws when the mouse cursor is over it. Increase the width of the rectangle so that the images
    ' are drawn more smoothly.  Also move the rectangle 2 pixels to the left so that the splitter bar 
    ' on the edge of the column header does not overlap the image.  
    Dim rect As Rectangle = drawParams.Element.Rect
    rect.Inflate(+1, -1)
    rect.Offset(-2, 0)

    ' Setup an ImageAttributes and ColorMap so that the blank white area
    ' surrounding the sort indicator image is painted transparently.
    Dim imageAttr As New ImageAttributes()
    Dim clrMap(0) As ColorMap
    clrMap(0) = New ColorMap()
    clrMap(0).OldColor = Color.White
    clrMap(0).NewColor = Color.Transparent
    imageAttr.SetRemapTable(clrMap)

    ' Get the name of the bitmap to render      
    '        Dim imageFile As String
    Dim bmp As Bitmap
    If sortAscending Then
      bmp = My.Resources.miniArrow_down  'Me.ascendingImage
    Else
      bmp = My.Resources.miniArrow_up  '     imageFile = 'Me.descendingImage
    End If

    Try
      ' Load the bitmap and then render it.
      '      bmp = New Bitmap(imageFile)

      drawParams.Graphics.DrawImage( _
       bmp, _
       rect, _
       0, _
       0, _
       bmp.Width, _
       bmp.Height, _
       GraphicsUnit.Pixel, _
       imageAttr _
       )
    Catch ex As Exception
      Debug.Assert(False, _
       "An exception occurred while trying to render a custom sort indicator:\n" + ex.Message, _
       "Was one of the images used for the custom sort indicators deleted or renamed?")

      ' If something went wrong (ex. the image file was deleted) then let the default rendering occur.
      Return False
    Finally
      ' Always dispose of system resources asap
      If bmp IsNot Nothing Then
        bmp.Dispose()
      End If
    End Try

    ' If we get to this point then our custom sort indicator was successfully rendered.
    ' Returning true prevents the normal sort indicator from being rendered on top of what we just drew.
    Return True
  End Function

#End Region

#End Region

End Class

#End Region