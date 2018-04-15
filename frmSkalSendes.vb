Imports Infragistics.Win.UltraWinGrid
Imports System.Data.SqlClient

Public Class frmSkalSendes

  Private Sub frmSkalSendes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.Cursor = Cursors.WaitCursor
    Me.ViewOversigtTableAdapter.FillByUger(Me.DstOversigt.viewOversigt, numFraUge.Value, numTilUge.Value)
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub frmSkalSendes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Me.grdOversigt.DisplayLayout.Save(My.Settings.PathGridUserSettings & "OversigtSkalSendesGrid.bin")
  End Sub

  Private Sub frmSkalSendes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    If HentBrugersIndstillinger AndAlso My.Computer.FileSystem.FileExists(My.Settings.PathGridUserSettings & "OversigtSkalSendesGrid.bin") Then
      Me.grdOversigt.DisplayLayout.Load(My.Settings.PathGridUserSettings & "OversigtSkalSendesGrid.bin")
    End If
    numFraUge.Value = frmMain.DenneUge
    numTilUge.Value = frmMain.DenneUge + 1
    grdOversigt.Text = "Skal sendes Oversigt Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
    Me.Text = "Skal sendes Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
    grdOversigt.DisplayLayout.Bands(0).Columns("Deadline").SortComparer = New sortByDeadline()
    grdOversigt.DrawFilter = New SortIndicatorDrawFilter
  End Sub

  Private Sub btnOpdater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpdater.Click
    If numFraUge.Value - numTilUge.Value = 0 Then
      grdOversigt.DisplayLayout.Bands(0).Columns("IndrykningsUge").Hidden = True
      grdOversigt.Text = "Skal sendes Oversigt Uge " & numFraUge.Value.ToString
      Me.Text = "Skal sendes Uge " & numFraUge.Value.ToString
    Else
      grdOversigt.DisplayLayout.Bands(0).Columns("IndrykningsUge").Hidden = False
      grdOversigt.Text = "Skal sendes Oversigt Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
      Me.Text = "Skal sendes Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
    End If
    Me.ViewOversigtTableAdapter.FillByUger(Me.DstOversigt.viewOversigt, numFraUge.Value, numTilUge.Value)
  End Sub

  Private Sub btnLuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub

  Private Sub grdOversigt_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdOversigt.DoubleClickRow
    Dim mediePlanNr As Integer
    Integer.TryParse(e.Row.Cells("MedieplanNr").Value, mediePlanNr)
    Dim version As Integer
    Integer.TryParse(e.Row.Cells("Version").Value, version)

    If mediePlanNr > 0 AndAlso version > 0 Then
      Me.Cursor = Cursors.WaitCursor
      frmMain.AktivtModul = "Booking"
      Dim nyFrmMedieplan As New frmMedieplan(frmMain.AktivtModul, mediePlanNr, version)
      nyFrmMedieplan.MdiParent = My.Forms.frmMain
      nyFrmMedieplan.Show()
      nyFrmMedieplan.WindowState = FormWindowState.Maximized
      Me.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub grdOversigt_AfterCellUpdate(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grdOversigt.AfterCellUpdate
    Dim mediePlanNr As Integer
    Integer.TryParse(e.Cell.Row.Cells("MedieplanNr").Value, mediePlanNr)

    'MessageBox.Show(e.Cell.Column.Key & " - " & e.Cell.Value & " - P:" & mediePlanNr.ToString & "-" & version.ToString)
    If e.Cell.Column.Key = "Kommentar" Then
      Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
      Dim cm As SqlCommand = cn.CreateCommand()
      Dim Tekst As String = e.Cell.Text.Replace("'", "''")

      cm.CommandType = CommandType.Text
      cm.CommandText = String.Format("UPDATE tblMedieplanNr SET Kommentar = '{0}' WHERE (MedieplanNr = {1})", Tekst, mediePlanNr)
      cn.Open()
      cm.ExecuteNonQuery()
      cn.Close()
      cm.Dispose()
      cn.Dispose()
    End If
  End Sub

End Class