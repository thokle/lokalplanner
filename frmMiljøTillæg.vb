Imports System.Data.SqlClient

Public Class frmMiljøTillæg

  Private _miljøTillæg As Double

  Private Sub btnLuk_Click(sender As System.Object, e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub

  Private Sub txtMiljøtillæg_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtMiljøtillæg.ValueChanged
    If txtMiljøtillæg.Value <> _miljøTillæg Then
      btnGem.Enabled = True
      lblBemærk.Visible = True
    Else
      btnGem.Enabled = False
      lblBemærk.Visible = False
    End If
  End Sub

  Private Sub btnGem_Click(sender As System.Object, e As System.EventArgs) Handles btnGem.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    cm.CommandType = CommandType.Text
    cm.CommandText = "UPDATE tblAktiveVærdier SET MiljøTillæg='" & txtMiljøtillæg.Value & "'"
    cm.ExecuteNonQuery()

    MessageBox.Show("Det nye miljøtillæg vil nu blive brugt" & vbCrLf & "i de fremtidige medieplaner.", "Miljø tillæg gemt.", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub frmMiljøTillæg_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
    If frmMain.HarRollen("Admin") Then
      btnGem.Visible = True
      txtMiljøtillæg.ReadOnly = False
    Else
      btnGem.Visible = False
      txtMiljøtillæg.ReadOnly = True
    End If

    _miljøTillæg = frmMain.AktivMiljøTillæg
    txtMiljøtillæg.Value = frmMain.AktivMiljøTillæg
  End Sub
End Class