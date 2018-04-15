Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class frmFjernOverførtOrdre

  Private Sub btnFjern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFjern.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand
    cm = cn.CreateCommand()

    cm.CommandType = CommandType.Text
    cm.CommandText = "UPDATE tblOrdreNavision SET Status = 7 WHERE (OrdreNr = " & txtMedieplanNr.Text & ")"
    Try
      cn.Open()
      cm.ExecuteNonQuery()
      cn.Close()
    Catch ex As Exception
    Finally
      cm.Dispose()
      cn.Dispose()
    End Try
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub txtMedieplanNr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMedieplanNr.ValueChanged
    If txtMedieplanNr.TextLength > 4 Then
      btnFjern.Enabled = True
    Else
      btnFjern.Enabled = False
    End If
  End Sub

  Private Sub frmFjernOverførtOrdre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    txtMedieplanNr.Value = Nothing
    txtMedieplanNr.Focus()
  End Sub
End Class
