Public Class frmEmail

  Public ReadOnly Property Emne() As String
    Get
      Return txtEmne.Text
    End Get
  End Property

  Public ReadOnly Property Tekst() As String
    Get
      Return txtTekst.Text
    End Get
  End Property

  Private Sub txtEmne_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmne.ValueChanged
    chkValid()
  End Sub

  Private Sub txtTekst_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTekst.ValueChanged
    chkValid()
  End Sub

  Private Sub chkValid()
    If txtEmne.TextLength > 0 AndAlso txtTekst.TextLength > 0 Then
      btnSend.Enabled = True
    Else
      btnSend.Enabled = False
    End If
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.Close()
  End Sub

  Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
    Me.Hide()
  End Sub

End Class