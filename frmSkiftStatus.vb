Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmSkiftStatus
  Private _status As Integer

  Private Sub btnSkift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkift.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand

    cm = cn.CreateCommand()
    cm.CommandType = CommandType.Text
    If _status = 3 Then
      cm.CommandText = "UPDATE tblMedieplanNr SET Status = 6 WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
    Else
      cm.CommandText = "UPDATE tblMedieplanNr SET Status = 3 WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
    End If
    Try
      cn.Open()
      cm.ExecuteNonQuery()
      If _status = 3 Then
        cm.CommandText = "UPDATE tblMedieplan SET Status = 6 FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion WHERE (tblMedieplan.MedieplanNr = " & txtMedieplanNr.Text & ")"
      Else
        cm.CommandText = "UPDATE tblMedieplan SET Status = 3 FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion WHERE (tblMedieplan.MedieplanNr = " & txtMedieplanNr.Text & ")"
      End If
      cm.ExecuteNonQuery()
      cn.Close()
    Catch ex As Exception
      MessageBox.Show("Der opstod en fejl da status skulle ændres i databasen.", "Fejl i opdatering", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
      Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
      Dim cm As SqlCommand
      cm = cn.CreateCommand()
      _status = 0
      cm.CommandType = CommandType.Text
      cm.CommandText = "SELECT Status FROM tblMedieplanNr WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      Try
        cn.Open()
        _status = cm.ExecuteScalar()
        cn.Close()
      Catch ex As Exception
      Finally
        cm.Dispose()
        cn.Dispose()
      End Try
      If _status = 3 Or _status = 6 Then
        If _status = 3 Then
          lblStatus.Text = "Status ændres til 6 ved tryk på Skift"
        Else
          lblStatus.Text = "Status ændres til 3 ved tryk på Skift"
        End If
        btnSkift.Enabled = True
      Else
        lblStatus.Text = "Status kan kun ændres hvis den er 3 eller 6"
        btnSkift.Enabled = False
      End If
    Else
      btnSkift.Enabled = False
    End If
  End Sub

  Private Sub frmSkiftStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    txtMedieplanNr.Value = Nothing
    lblStatus.Text = ""
    txtMedieplanNr.Focus()
  End Sub
End Class
