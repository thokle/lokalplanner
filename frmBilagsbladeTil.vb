Public Class frmBilagsbladeTil

  Public Sub ResetData()
    txtNavn.Text = ""
    txtAdresse.Text = ""
    txtPostNr.Text = ""
  End Sub

  Public Property Navn() As String
    Get
      Return txtNavn.Text
    End Get
    Set(ByVal value As String)
      If value <> "" Then txtNavn.Text = value
    End Set
  End Property

  Public Property Adresse() As String
    Get
      Return txtAdresse.Text
    End Get
    Set(ByVal value As String)
      If value <> "" Then txtAdresse.Text = value
    End Set
  End Property

  Public Property PostNr() As Integer
    Get
      If txtPostNr.TextLength > 0 Then
        Return CInt(txtPostNr.Text)
      Else
        Return 9999
      End If
    End Get
    Set(ByVal value As Integer)
      If value <> 0 Then txtPostNr.Text = value.ToString
    End Set
  End Property

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    Me.Hide()
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.Hide()
  End Sub
End Class