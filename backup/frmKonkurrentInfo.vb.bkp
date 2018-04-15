Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Documents.Excel
Imports System.Diagnostics
Imports System.IO

Public Class frmKonkurrentInfo
  Private _isLoading As Boolean = True
  Private _mediePlanNr As String = ""
  Private antalGroupByColumns = 0
  Private currentRow As Integer = 1
  Private currentColumn As Integer = 0
  Private workbook As New Workbook()
  Private workSheet As Worksheet
  Private huskSumRow As Integer = 0
  Private faktor As Integer = 36 'Width faktor som grd kolonne skal ganges med for at give excel kolonne width

  Private Sub frmKonkurrentInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    Dim aktivPlan As frmMedieplan = frmMain.ActiveMdiChild
    _mediePlanNr = aktivPlan.lblMedieplanNr.Text

    ' grdRapport.DisplayLayout.Load(My.Application.Info.DirectoryPath & "\KonkurrentInfoGridLayout.lyt")
    frmMain.ActiveWindows = Me
    grdRapport.Text = "Medieplan nr.: " & _mediePlanNr
    If _mediePlanNr = "- ikke tildelt -" Then _mediePlanNr = ""

    If _mediePlanNr.Length > 0 Then grdRapport.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True
    For Each Konkurrent As KonkurrentData In KonkurrentDataListe
      clbKonkurrenter.Items.Add(Konkurrent.KonkurrentNavn)
    Next
    DataSourceKonkurrentInfo.AddColumns()
    Dim summ As SummarySettings = grdRapport.DisplayLayout.Bands(0).Summaries.Add(SummaryType.Sum, Nothing, grdRapport.DisplayLayout.Bands(0).Columns(3), SummaryPosition.UseSummaryPositionColumn, grdRapport.DisplayLayout.Bands(0).Columns(3))
    summ.DisplayFormat = "{0:#,##0}"
    summ.GroupBySummaryValueAppearance.TextHAlign = Infragistics.Win.HAlign.Right
    For Each col As UltraGridColumn In grdRapport.DisplayLayout.Bands(0).Columns
      col.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
      If col.Index > 4 Then
        col.Hidden = True
        col.ProportionalResize = True
        col.MinWidth = 50
        col.MaxWidth = 100
        col.Width = 100
        col.CellActivation = Activation.NoEdit
        col.Format = "#,##0"
      End If
    Next

    DataSourceKonkurrentInfo.LoadData(0, UgeavisIDListeFraAktivMedieplan, False, True)
    grdRapport.DisplayLayout.Bands(0).Columns(0).Hidden = True
    grdRapport.DisplayLayout.Bands(0).Columns(1).Hidden = True
    _isLoading = False
  End Sub

  Private Sub clbKonkurrenter_ItemCheck(sender As System.Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles clbKonkurrenter.ItemCheck
    If e.NewValue = CheckState.Checked Then
      grdRapport.DisplayLayout.Bands(0).Columns(e.Index + 5).Hidden = False
    Else
      grdRapport.DisplayLayout.Bands(0).Columns(e.Index + 5).Hidden = True
    End If
  End Sub

  Private Sub optRapportType_ValueChanged(sender As System.Object, e As System.EventArgs) Handles optRapportType.ValueChanged
    If _isLoading Then Exit Sub
    grdRapport.DisplayLayout.Bands(0).SortedColumns.Clear()
    DataSourceKonkurrentInfo.LoadData(optRapportType.Value, UgeavisIDListeFraAktivMedieplan, optMedtag.Value, optTal.Value)
    If optRapportType.Value = 0 Then
      grdRapport.DisplayLayout.Bands(0).Columns(1).Hidden = True
      grdRapport.DisplayLayout.Bands(0).Columns(2).Hidden = False
      grdRapport.DisplayLayout.Bands(0).Columns(3).Hidden = False
      optMedtag.Visible = False
      optTal.Visible = True
      optTal.Location = New Point(13, 155)
      'ElseIf optRapportType.Value = 1 Then
      '  grdRapport.DisplayLayout.Bands(0).Columns(1).Hidden = False
      '  grdRapport.DisplayLayout.Bands(0).Columns(2).Hidden = True
      '  grdRapport.DisplayLayout.Bands(0).Columns(3).Hidden = True
      '  optMedtag.Visible = True
      '  optTal.Visible = False
    ElseIf optRapportType.Value = 2 Then
      grdRapport.DisplayLayout.Bands(0).Columns(1).Hidden = False
      grdRapport.DisplayLayout.Bands(0).Columns(2).Hidden = False
      grdRapport.DisplayLayout.Bands(0).Columns(3).Hidden = False
      optMedtag.Visible = False
      optTal.Visible = True
      optTal.Location = New Point(88, 155)
      grdRapport.DisplayLayout.Bands(0).SortedColumns.Add("Ugeavis", False, True)
    End If
  End Sub

  Private Sub optMedtag_ValueChanged(sender As System.Object, e As System.EventArgs) Handles optMedtag.ValueChanged
    If _isLoading Then Exit Sub
    DataSourceKonkurrentInfo.LoadData(optRapportType.Value, UgeavisIDListeFraAktivMedieplan, optMedtag.Value, optTal.Value)
  End Sub

  Private Sub optTal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles optTal.ValueChanged
    If _isLoading Then Exit Sub
    DataSourceKonkurrentInfo.LoadData(optRapportType.Value, UgeavisIDListeFraAktivMedieplan, optMedtag.Value, optTal.Value)
    grdRapport.DisplayLayout.Bands(0).Summaries.Clear()
    If optTal.Value Then
      Dim summ As SummarySettings = grdRapport.DisplayLayout.Bands(0).Summaries.Add(SummaryType.Sum, Nothing, grdRapport.DisplayLayout.Bands(0).Columns(3), SummaryPosition.UseSummaryPositionColumn, grdRapport.DisplayLayout.Bands(0).Columns(3))
      summ.DisplayFormat = "{0:#,##0}"
      summ.GroupBySummaryValueAppearance.TextHAlign = Infragistics.Win.HAlign.Right
    Else
      For Each col As UltraGridColumn In grdRapport.DisplayLayout.Bands(0).Columns
        col.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        If col.Index > 2 Then
          Dim summ As SummarySettings = grdRapport.DisplayLayout.Bands(0).Summaries.Add(SummaryType.Sum, Nothing, col, SummaryPosition.UseSummaryPositionColumn, col)
          summ.DisplayFormat = "{0:#,##0}"
          summ.GroupBySummaryValueAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        End If
      Next
    End If
  End Sub

  Private Sub btnTilExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnTilExcel.Click
    Dim fileName As String
    Dim filNavn As String

    btnTilExcel.Text = "Eksporterer"
    btnTilExcel.Enabled = False
    Application.DoEvents()

    If _mediePlanNr.Length > 0 Then
      fileName = String.Format("M:\Plan nr. {0} Dækning pr. ", _mediePlanNr)
    Else
      fileName = "M:\Dækning pr. "
    End If
    If optRapportType.Value = 0 Then
      fileName = fileName & "Post nr. - "
      'ElseIf optRapportType.Value = 1 Then
      '  fileName = fileName & "Lokal Ugeavis"
    ElseIf optRapportType.Value = 2 Then
      fileName = fileName & "Ugeavis & post nr. - "
    End If
    If optTal.Value Then
      fileName = fileName & "Dækningsgrader"
    Else
      fileName = fileName & "Oplag"
    End If
    workbook.Worksheets.Clear()

    If _mediePlanNr.Length > 0 Then
      workSheet = workbook.Worksheets.Add(String.Format("Dækning MedieplanNr. {0}", _mediePlanNr))
    Else
      workSheet = workbook.Worksheets.Add("Dækning")
    End If

    Dim filCount As Integer = 0
    Do
      If filCount = 0 Then
        filNavn = fileName & ".xls"
      Else
        filNavn = fileName & " v." & filCount.ToString & ".xls"
      End If
      filCount = filCount + 1
    Loop While File.Exists(filNavn)

    ExcelExporter.Export(grdRapport, filNavn)
    workbook.Save(filNavn) 'Overskriv fil dannet af ExcelExporter

    Dim myProcess As New Process

    myProcess.StartInfo.FileName = filNavn
    myProcess.Start()

    btnTilExcel.Text = "Send til Excel"
    btnTilExcel.Enabled = True
  End Sub

  Private Sub ExcelExporter_ExportStarted(sender As Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportStartedEventArgs) Handles ExcelExporter.ExportStarted
    e.Layout.Override.SummaryDisplayArea = SummaryDisplayAreas.Bottom
    If _mediePlanNr.Length > 0 Then
      workSheet.Rows(0).Cells(0).Value = String.Format("Medieplan nr. {0}", _mediePlanNr)
    Else
      workSheet.Rows(0).Cells(0).Value = "Medieplan ikke gemt"
    End If
    workSheet.Rows(0).Cells(0).CellFormat.Font.Bold = ExcelDefaultableBoolean.True
    If optRapportType.Value = 0 Then
      antalGroupByColumns = 0
      If optTal.Value Then
        workSheet.Rows(1).Cells(0).Value = "Dækningsoversigt i procent"
      Else
        workSheet.Rows(1).Cells(0).Value = "Dækningsoversigt i oplag"
      End If
    ElseIf optRapportType.Value = 2 Then
      antalGroupByColumns = 1
      If optTal.Value Then
        workSheet.Rows(1).Cells(0).Value = "Dækningsoversigt i procent pr. blad"
      Else
        workSheet.Rows(1).Cells(0).Value = "Dækningsoversigt i oplag pr.blad"
      End If
      workSheet.Columns(0).Width = 200 * faktor
      workSheet.Rows(2).Cells(0).Value = "Lokal Ugeavis"
      workSheet.Rows(2).Cells(0).CellFormat.Font.Bold = ExcelDefaultableBoolean.True
      workSheet.Rows(2).Cells(0).CellFormat.Alignment = HorizontalCellAlignment.Center
    End If
    currentRow = 3
  End Sub

  Private Sub ExcelExporter_CellExporting(sender As Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.CellExportingEventArgs) Handles ExcelExporter.CellExporting
    e.Cancel = True
  End Sub

  Private Sub ExcelExporter_ExportEnding(sender As Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndingEventArgs) Handles ExcelExporter.ExportEnding
    If Not e.Canceled Then
      workSheet.Rows(currentRow + 2).Cells(0).Value = "Kilde: Dansk Oplagskontrol og Post Danmark"
      workSheet.Rows(currentRow + 2).Cells(0).CellFormat.Font.Height = 160
      workSheet.Rows(currentRow + 2).Cells(0).CellFormat.Font.Italic = ExcelDefaultableBoolean.True
    End If
  End Sub

  Private Sub ExcelExporter_HeaderCellExporting(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.HeaderCellExportingEventArgs) Handles ExcelExporter.HeaderCellExporting
    e.Cancel = True
  End Sub

  Private Sub ExcelExporter_HeaderRowExporting(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.HeaderRowExportingEventArgs) Handles ExcelExporter.HeaderRowExporting
    e.Cancel = True
    currentColumn = antalGroupByColumns
    For Each column As UltraGridColumn In grdRapport.DisplayLayout.Bands(0).Columns
      If Not column.Hidden Then
        workSheet.Rows(2).Cells(currentColumn).Value = column.Header.Caption
        workSheet.Rows(2).Cells(currentColumn).CellFormat.Font.Bold = ExcelDefaultableBoolean.True
        workSheet.Rows(2).Cells(currentColumn).CellFormat.Alignment = HorizontalCellAlignment.Center
        workSheet.Columns(currentColumn).Width = column.Width * faktor
        currentColumn = currentColumn + 1
      End If
    Next
  End Sub

  Private Sub ExcelExporter_RowExporting(sender As Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles ExcelExporter.RowExporting
    e.Cancel = True
    currentColumn = antalGroupByColumns
    If Not TypeOf e.GridRow Is UltraGridGroupByRow Then
      For Each cell As UltraGridCell In e.GridRow.Cells
        If Not cell.Column.Hidden Then
          workSheet.Rows(currentRow).Cells(currentColumn).Value = cell.Value
          workSheet.Rows(currentRow).Cells(currentColumn).CellFormat.FormatString = "#,###"
          currentColumn = currentColumn + 1
        End If
      Next
    Else
      workSheet.Rows(currentRow).Cells(0).Value = e.GridRow.Description
      huskSumRow = currentRow
    End If
    currentRow = currentRow + 1
  End Sub

  Private Sub ExcelExporter_SummaryCellExporting(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.SummaryCellExportingEventArgs) Handles ExcelExporter.SummaryCellExporting
    e.Cancel = True
    If e.Summary IsNot Nothing Then
      If huskSumRow > 1 Then
        workSheet.Rows(huskSumRow).Cells(e.CurrentColumnIndex + antalGroupByColumns).Value = e.Summary.Value
        workSheet.Rows(huskSumRow).Cells(e.CurrentColumnIndex + antalGroupByColumns).CellFormat.FormatString = "#,###"
      End If
    End If
  End Sub

  Private Sub ExcelExporter_SummaryRowExported(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.SummaryRowExportedEventArgs) Handles ExcelExporter.SummaryRowExported
    huskSumRow = 1
  End Sub

End Class