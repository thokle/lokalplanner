Imports Infragistics.Win.UltraWinGrid

Public Class clsCountNotDeleted
  Implements ICustomSummaryCalculator

  Private antal As Integer = 0

  Public Sub New()
  End Sub

  Private Sub BeginCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.BeginCustomSummary
    Me.antal = 0
  End Sub

  Private Sub AggregateCustomSummary(ByVal summarySettings As SummarySettings, ByVal row As UltraGridRow) Implements ICustomSummaryCalculator.AggregateCustomSummary
    If row.Cells("RowState").Value <> "Deleted" Then antal += 1
  End Sub

  Private Function EndCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.EndCustomSummary
    Return Me.antal
  End Function
End Class

Public Class clsCalculateDiffMm
  Implements ICustomSummaryCalculator

  Private mmGammel As Integer = 0
  Private mmNy As Integer = 0

  Public Sub New()
  End Sub

  Private Sub BeginCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.BeginCustomSummary
    Me.mmGammel = 0
    Me.mmNy = 0
  End Sub

  Private Sub AggregateCustomSummary(ByVal summarySettings As SummarySettings, ByVal row As UltraGridRow) Implements ICustomSummaryCalculator.AggregateCustomSummary
    mmGammel += row.Cells("MmÅrGammel").Value
    mmNy += row.Cells("MmÅrNy").Value
  End Sub

  Private Function EndCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.EndCustomSummary
    Dim diff As Double
    diff = mmNy - mmGammel
    Return diff
  End Function
End Class

Public Class clsCalculateDiffKr
  Implements ICustomSummaryCalculator

  Private krGammel As Decimal = 0
  Private krNy As Decimal = 0

  Public Sub New()
  End Sub

  Private Sub BeginCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.BeginCustomSummary
    Me.krGammel = 0
    Me.krNy = 0
  End Sub

  Private Sub AggregateCustomSummary(ByVal summarySettings As SummarySettings, ByVal row As UltraGridRow) Implements ICustomSummaryCalculator.AggregateCustomSummary
    krGammel += row.Cells("PrisÅrGammel").Value
    krNy += row.Cells("PrisÅrNy").Value
  End Sub

  Private Function EndCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.EndCustomSummary
    Dim diff As Decimal
    diff = krNy - krGammel
    Return diff
  End Function
End Class

Public Class clsCalculateDiffMmProcent
  Implements ICustomSummaryCalculator

  Private mmGammel As Integer = 0
  Private mmNy As Integer = 0

  Public Sub New()
  End Sub

  Private Sub BeginCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.BeginCustomSummary
    Me.mmGammel = 0
    Me.mmNy = 0
  End Sub

  Private Sub AggregateCustomSummary(ByVal summarySettings As SummarySettings, ByVal row As UltraGridRow) Implements ICustomSummaryCalculator.AggregateCustomSummary
    mmGammel += row.Cells("MmÅrGammel").Value
    mmNy += row.Cells("MmÅrNy").Value
  End Sub

  Private Function EndCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.EndCustomSummary
    Dim diff As Double
    If mmGammel < 0.1 Then
      If mmNy > 0 Then
        Return 100
      Else '
        Return 0
      End If
    ElseIf mmNy < 0.1 Then
      Return -100
    Else
      diff = (mmNy - mmGammel) / mmGammel
      Return diff * 100
    End If
  End Function
End Class

Public Class clsCalculateDiffKrProcent
  Implements ICustomSummaryCalculator

  Private krGammel As Decimal = 0
  Private krNy As Decimal = 0

  Public Sub New()
  End Sub

  Private Sub BeginCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.BeginCustomSummary
    Me.krGammel = 0
    Me.krNy = 0
  End Sub

  Private Sub AggregateCustomSummary(ByVal summarySettings As SummarySettings, ByVal row As UltraGridRow) Implements ICustomSummaryCalculator.AggregateCustomSummary
    krGammel += row.Cells("PrisÅrGammel").Value
    krNy += row.Cells("PrisÅrNy").Value
  End Sub

  Private Function EndCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.EndCustomSummary
    Dim diff As Decimal
    If krGammel < 0.1 Then
      If krNy > 0 Then
        Return 100
      Else '
        Return 0
      End If
    ElseIf krNy < 0.1 Then
      Return -100
    Else
      diff = (krNy - krGammel) / krGammel
      Return diff * 100
    End If
  End Function
End Class