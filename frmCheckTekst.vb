Public Class frmCheckTekst
  Public sendAfbryd As Boolean = False

  Public Sub New(ByVal tekst As String)
    InitializeComponent()
    txtTekst.Text = tekst
  End Sub

  Public Sub New(ByVal tekst As String, ByVal overskrift As String)
    Me.New(tekst)
    Me.Text = overskrift
  End Sub

  Private Sub btnLuk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    If sendAfbryd Then frmSletFiler.afbryd = True
    Me.Hide()
  End Sub

  Private Sub txtTekst_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTekst.TextChanged
    txtTekst.ScrollToCaret()
  End Sub
End Class
