Imports Infragistics.Win.UltraWinGrid

Public Class frmBerskeAfstemning

  Private Sub frmSkalSendes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    numFraUge.Value = frmMain.DenneUge
    numTilUge.Value = frmMain.DenneUge + 1
    num≈r.Value = frmMain.Dette≈r
    grdAfstemning.Text = "Bergske Afstemning Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
    Me.Text = "Bergske Afstemning Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
    Me.TblBergskeAfstemningTableAdapter.FillByUgeOg≈r(DstBergskeAfstemning.tblBergskeAfstemning, num≈r.Value, numFraUge.Value, numTilUge.Value)
  End Sub

  Private Sub btnOpdater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpdater.Click
    If numFraUge.Value - numTilUge.Value = 0 Then
      grdAfstemning.Text = "Bergske Afstemning Uge " & numFraUge.Value.ToString
      Me.Text = "Bergske Afstemning Uge " & numFraUge.Value.ToString
    Else
      grdAfstemning.Text = "Bergske Afstemning Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
      Me.Text = "Bergske Afstemning Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString
    End If
    Me.TblBergskeAfstemningTableAdapter.FillByUgeOg≈r(DstBergskeAfstemning.tblBergskeAfstemning, num≈r.Value, numFraUge.Value, numTilUge.Value)
  End Sub

  Private Sub btnLuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub

  Private Sub btnTilExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnTilExcel.Click
    Dim _filNavn As String = "M:\Bergske Afstemning Uge " & numFraUge.Value.ToString & " til " & numTilUge.Value.ToString & " " & num≈r.Value.ToString & ".xls"
    ExcelExporter.Export(grdAfstemning, _filNavn)
    MessageBox.Show("Afstemninger er ekporteret til Excel med navnet:" & vbCrLf & _filNavn, "Excel Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub
End Class