Imports Infragistics.Win.UltraWinGrid

Public Class sortBySortKey
  Implements IComparer

  Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

    Dim xCell As UltraGridCell = DirectCast(x, UltraGridCell)
    Dim yCell As UltraGridCell = DirectCast(y, UltraGridCell)
    Dim findSortKeyKol As String = xCell.Column.Key.Replace("Navn", "SortKey")

    Dim xValue As Integer = xCell.Row.Cells(findSortKeyKol).Value
    Dim yValue As Integer = yCell.Row.Cells(findSortKeyKol).Value

    If xValue > yValue Then
      Return 1
    ElseIf xValue = yValue Then
      Return 0
    Else
      Return -1
    End If

  End Function

End Class

Public Class sortByRowState
  Implements IComparer

  Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

    Dim xCell As UltraGridCell = DirectCast(x, UltraGridCell)
    Dim yCell As UltraGridCell = DirectCast(y, UltraGridCell)

    If xCell.Row.Cells("RowState").Value = "Deleted" AndAlso yCell.Row.Cells("RowState").Value <> "Deleted" Then
      Return 1
    ElseIf yCell.Row.Cells("RowState").Value = "Deleted" AndAlso xCell.Row.Cells("RowState").Value <> "Deleted" Then
      Return -1
    Else
      Dim xValue As String = xCell.Row.Cells("UgeavisID").Text
      Dim yValue As String = yCell.Row.Cells("UgeavisID").Text
      If xValue > yValue Then
        Return 1
      ElseIf xValue = yValue Then
        Return 0
      Else
        Return -1
      End If
    End If
  End Function
End Class


Public Class sortByDeadline
  Implements IComparer


  Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

    Dim xCell As UltraGridCell = DirectCast(x, UltraGridCell)
    Dim yCell As UltraGridCell = DirectCast(y, UltraGridCell)

    Dim xDag As String = Left(xCell.Text, 3)
    Dim yDag As String = Left(yCell.Text, 3)

    Dim xValue As Integer = 0
    Dim yValue As Integer = 0

    For i As Integer = 0 To 6
      If xDag = Ugedage(i) Then xValue = i + 1
      If yDag = Ugedage(i) Then yValue = i + 1
    Next

    If xValue > yValue Then
      Return 1
    ElseIf xValue = yValue Then
      Dim xKl As String = Right(xCell.Text, 5)
      Dim yKl As String = Right(yCell.Text, 5)

      If xKl > yKl Then
        Return 1
      ElseIf xKl = yKl Then
        Return 0
      Else
        Return -1
      End If
    Else
      Return -1
    End If

  End Function
End Class