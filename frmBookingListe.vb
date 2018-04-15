Imports Infragistics.Win.UltraWinGrid

Public Class frmBookingListe

  Private Sub frmBookingListe_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.Cursor = Cursors.WaitCursor
    Me.ViewBookingListeTableAdapter.FillByUger(Me.DstBookingListe.viewBookingListe, numFraUge.Value, numTilUge.Value, numÅr.Value)
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub frmBookingListe_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Me.grdOversigt.DisplayLayout.Save(My.Settings.PathGridUserSettings & "BookingListeGrid.bin", PropertyCategories.All)
  End Sub

  Private Sub frmBookingListe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    If HentBrugersIndstillinger AndAlso My.Computer.FileSystem.FileExists(My.Settings.PathGridUserSettings & "BookingListeGrid.bin") Then
      Me.grdOversigt.DisplayLayout.Load(My.Settings.PathGridUserSettings & "BookingListeGrid.bin")
    End If
    numFraUge.Value = frmMain.DenneUge + 1
    numTilUge.Value = frmMain.DenneUge + 1
    numÅr.Value = frmMain.DetteÅr
    grdOversigt.Text = "Booking Liste Uge " & numFraUge.Value.ToString
    Me.Text = "Booking Liste Uge " & numFraUge.Value.ToString
  End Sub

  Private Sub btnOpdater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpdater.Click
    If numFraUge.Value - numTilUge.Value = 0 Then
      grdOversigt.Text = "Booking Liste Uge " & numFraUge.Value.ToString
      Me.Text = "Booking Liste Uge " & numFraUge.Value.ToString
    Else
      grdOversigt.Text = "Booking Liste Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
      Me.Text = "Booking Liste Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
    End If
    Me.ViewBookingListeTableAdapter.FillByUger(Me.DstBookingListe.viewBookingListe, numFraUge.Value, numTilUge.Value, numÅr.Value)
  End Sub

  Private Sub btnLuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub

  Private Sub grdOversigt_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdOversigt.DoubleClickRow
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

  Private Sub btnTilExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTilExcel.Click
    Dim filNavn As String
    If numFraUge.Value - numTilUge.Value = 0 Then
      filNavn = "M:\Booking Liste Uge " & numFraUge.Value.ToString & ".xls"
    Else
      filNavn = "M:\Booking Liste Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString & ".xls"
    End If
    ExcelExporter.Export(grdOversigt, filNavn)
    MessageBox.Show("Bookingliste gemt som: " & filNavn, "Eksport", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub
End Class