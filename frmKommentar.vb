Imports System.Windows.Forms
Imports System.Runtime.Remoting

Public Class frmKommentar

  Public Property Kommentar As String
    Set(value As String)
      If value.Length = 0 Then
        txtKommentar.Value = Nothing
      Else
        txtKommentar.Text = value
      End If
      btnGem.Enabled = False
    End Set
    Get
      Return txtKommentar.Text
    End Get
  End Property

  Private Sub btnAnnuller_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnuller.Click
    Me.Close()
  End Sub

  Private Sub btnGem_Click(sender As System.Object, e As System.EventArgs) Handles btnGem.Click
    Me.Hide()
  End Sub

  Private Sub txtKommentar_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtKommentar.ValueChanged
    If txtKommentar.Text.Length = 0 Then txtKommentar.Value = Nothing
    btnGem.Enabled = True
  End Sub
End Class
