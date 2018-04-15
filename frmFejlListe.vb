Public Class frmFejlListe
  Private vist As Boolean = False

  Private Sub frmFejlListe_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.TblLinjerMedFejlTableAdapter.Fill(Me.DstFindLinjerMedFejl.tblLinjerMedFejl)
  End Sub

  Private Sub frmFejlListe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    grdFejlListe.DrawFilter = New SortIndicatorDrawFilter
  End Sub

  Private Sub grdFejlListe_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdFejlListe.DoubleClickRow
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
      vist = True
      Me.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub grdFejlListe_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdFejlListe.MouseDown
    If vist Then
      vist = False
      Me.TblLinjerMedFejlTableAdapter.Fill(Me.DstFindLinjerMedFejl.tblLinjerMedFejl)
    End If
  End Sub

  Private Sub btnLuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub
End Class