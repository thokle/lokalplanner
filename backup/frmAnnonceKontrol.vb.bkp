Imports Infragistics.Win.UltraWinGrid

Public Class frmAnnonceKontrol
    Private vist As Boolean = False

    Private Sub frmAnnonceKontrol_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        Me.TblManglerKontrolTableAdapter.FillByUge(Me.DstManglerAnnonceKontrol.tblManglerKontrol, frmMain.DenneUge)
    End Sub

    Private Sub grdAnnoncekontrol_DoubleClickRow(ByVal sender As Object, ByVal e As DoubleClickRowEventArgs) Handles grdAnnoncekontrol.DoubleClickRow
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = "http://dimp.dk/Annoncekontrol.aspx?Query=" & e.Row.Cells("BladID").Value & "*" & e.Row.Cells("IndrykningsUge").Value & "*" & frmMain.BrugerEmail & "*999"
        vist = True
        myProcess.Start()
    End Sub

    Private Sub grdAnnoncekontrol_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles grdAnnoncekontrol.MouseDown
        If vist Then
            vist = False
            Me.TblManglerKontrolTableAdapter.FillByUge(Me.DstManglerAnnonceKontrol.tblManglerKontrol, frmMain.DenneUge)
        End If
    End Sub
End Class