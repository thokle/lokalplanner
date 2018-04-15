Public Class frmFaktureringsBilagListe
  Private vist As Boolean = False

  Private Sub frmFejlListe_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.TblFaktureringsBilagTableAdapter.Fill(Me.DstFaktureringsBilagListe.tblFaktureringsBilag)
  End Sub

  Private Sub frmFejlListe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    grdFaktureringsBilag.DrawFilter = New SortIndicatorDrawFilter
  End Sub

  Private Sub grdFejlListe_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdFaktureringsBilag.DoubleClickRow
    Dim mediePlanNr As Integer
    Integer.TryParse(e.Row.Cells("MedieplanNr").Value, mediePlanNr)
    Dim version As Integer
    Integer.TryParse(e.Row.Cells("Version").Value, version)

    If mediePlanNr > 0 AndAlso version > 0 Then
      Me.Cursor = Cursors.WaitCursor
      If version > 10 Then frmMain.AktivtModul = "Booking"
      If version > 110 Then frmMain.AktivtModul = "Fakturering"
      Dim nyFrmMedieplan As New frmMedieplan(frmMain.AktivtModul, mediePlanNr, version)
      nyFrmMedieplan.MdiParent = My.Forms.frmMain
      nyFrmMedieplan.Show()
      nyFrmMedieplan.WindowState = FormWindowState.Maximized
      vist = True
      Me.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub grdFejlListe_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdFaktureringsBilag.MouseDown
    If vist Then
      vist = False
      Me.TblFaktureringsBilagTableAdapter.Fill(Me.DstFaktureringsBilagListe.tblFaktureringsBilag)
    End If
  End Sub

  Private Sub btnLuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub
End Class