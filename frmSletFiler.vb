Imports System.IO


Public Class frmSletFiler
  Dim f As New frmCheckTekst("Sletter filer" & vbCrLf, "Slet Filer")
  Public afbryd As Boolean = False
  Private sletFiler As Boolean = False
  Private filedate As Date

  Private Sub frmSletFiler_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    calInfo.MaxDate = DateAdd(DateInterval.Year, -1, Now)
    calDato.Value = DateAdd(DateInterval.Year, -1, Now)
  End Sub

  Sub DeleteFilesFromFolder(Folder As String)
    If Not afbryd AndAlso Directory.Exists(Folder) Then
      For Each _file As String In Directory.GetFiles(Folder)
        filedate = File.GetLastWriteTime(_file)
        If filedate < calDato.Value Then
          If sletFiler Then File.Delete(_file)
          f.txtTekst.AppendText("Sletter : " & _file & " - Date:" & filedate & vbCrLf)
        Else
          f.txtTekst.AppendText("Beholder : " & _file & " - Date:" & filedate & vbCrLf)
        End If
      Next
      Application.DoEvents()
      For Each _folder As String In Directory.GetDirectories(Folder)
        DeleteFilesFromFolder(_folder)
        If Directory.GetFileSystemEntries(_folder).Length < 1 Then
          f.txtTekst.AppendText("Sletter tom mappe: " & _folder & vbCrLf)
          If sletFiler Then Directory.Delete(_folder)
        Else
          f.txtTekst.AppendText("Mappe er ikke tom:" & _folder & vbCrLf)
        End If
      Next
    End If
  End Sub

  Private Sub btnSletFiler_Click(sender As System.Object, e As System.EventArgs) Handles btnSletFiler.Click
    afbryd = False
    sletFiler = True
    f.Show()
    f.txtTekst.Text = ""
    f.sendAfbryd = True
    f.btnLuk.Enabled = True
    If optVælgSletFra.Value = 0 Then
      DeleteFilesFromFolder("Z:\AnnoncematerialeUdsendt")
    ElseIf optVælgSletFra.Value = 1 Then
      DeleteFilesFromFolder("M:\")
    Else
      DeleteFilesFromFolder("H:\")
    End If
    f.sendAfbryd = False
  End Sub

  Private Sub optVælgSletFra_ValueChanged(sender As System.Object, e As System.EventArgs) Handles optVælgSletFra.ValueChanged
    If optVælgSletFra.CheckedIndex >= 0 Then
      btnSletFiler.Enabled = True
      btnVisFiler.Enabled = True
    Else
      btnSletFiler.Enabled = False
      btnVisFiler.Enabled = False
    End If
  End Sub

  Private Sub btnLuk_Click(sender As System.Object, e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub

  Private Sub btnVisFiler_Click(sender As System.Object, e As System.EventArgs) Handles btnVisFiler.Click
    afbryd = False
    sletFiler = False
    f.Show()
    f.txtTekst.Text = ""
    f.sendAfbryd = True
    f.btnLuk.Enabled = True
    If optVælgSletFra.Value = 0 Then
      DeleteFilesFromFolder("Z:\AnnoncematerialeUdsendt")
    ElseIf optVælgSletFra.Value = 1 Then
      DeleteFilesFromFolder("M:\")
    Else
      DeleteFilesFromFolder("H:\")
    End If
    f.sendAfbryd = False
  End Sub
End Class