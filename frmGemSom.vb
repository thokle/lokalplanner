Public Class frmGemSom
  Private _annoncørFindes As Boolean
  Private _bureauFindes As Boolean


  Public WriteOnly Property AnnoncørFindes() As Boolean
    Set(ByVal value As Boolean)
      _annoncørFindes = value
    End Set
  End Property

  Public WriteOnly Property BureauFindes() As Boolean
    Set(ByVal value As Boolean)
      _bureauFindes = value
    End Set
  End Property

  Public Property KontaktpersonTilhører() As Byte
    Get
      Return optAnnoncørEllerBureau.Value
    End Get
    Set(ByVal value As Byte)
      optAnnoncørEllerBureau.Value = value
    End Set
  End Property

  Public Property KontaktpersonNavn() As String
    Get
      Return txtKontaktpersonNavn.Text
    End Get
    Set(ByVal value As String)
      txtKontaktpersonNavn.Text = value
    End Set
  End Property

  Public Property Beskrivelse() As String
    Get
      Return txtBeskrivelse.Text
    End Get
    Set(ByVal value As String)
      txtBeskrivelse.Text = value
    End Set
  End Property

  Private Sub chkOptAnnoncørEllerBureauVisible()
    If _annoncørFindes AndAlso _bureauFindes Then
      optAnnoncørEllerBureau.Visible = True
    Else
      optAnnoncørEllerBureau.Visible = False
      If _annoncørFindes Then
        txtKontaktpersonNavn.NullText = "- Skriv Annoncør Kontaktperson -"
        optAnnoncørEllerBureau.CheckedIndex = 0
      ElseIf _bureauFindes Then
        txtKontaktpersonNavn.NullText = "- Skriv Bureau Kontaktperson -"
        optAnnoncørEllerBureau.CheckedIndex = 1
      Else
        txtKontaktpersonNavn.NullText = "- Skriv Kontaktperson -"
        optAnnoncørEllerBureau.CheckedIndex = -1
      End If
    End If
  End Sub

  Private Sub txtKontaktpersonNavn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKontaktpersonNavn.ValueChanged
    chkValid()
  End Sub

  Private Sub chkValid()
    Dim isValid = True
    Select Case True
      Case txtBeskrivelse.TextLength = 0
        isValid = False
      Case txtKontaktpersonNavn.TextLength = 0
        isValid = False
      Case optAnnoncørEllerBureau.Visible AndAlso optAnnoncørEllerBureau.CheckedIndex = -1
        isValid = False
    End Select
    If optAnnoncørEllerBureau.Visible Then
      If optAnnoncørEllerBureau.CheckedIndex = -1 Then
        txtBeskrivelse.NullText = "- Vælg Annoncør eller Bureau -"
      Else
        txtBeskrivelse.NullText = "- Skriv Beskrivelse -"
      End If
    Else
      txtBeskrivelse.NullText = "- Skriv Beskrivelse -"
    End If
    btnGem.Enabled = isValid
  End Sub

  Private Sub frmGemSom_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.Cursor = Cursors.Default
    timer.Enabled = True
  End Sub

  Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
    timer.Enabled = False
    chkOptAnnoncørEllerBureauVisible()
    chkValid()
    If txtKontaktpersonNavn.TextLength = 0 Then
      txtKontaktpersonNavn.Focus()
      txtKontaktpersonNavn.SelectAll()
    Else
      txtBeskrivelse.Focus()
      txtBeskrivelse.SelectAll()
    End If
  End Sub

  Private Sub btnGem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGem.Click
    Me.Cursor = Cursors.WaitCursor
  End Sub

  Private Sub optAnnoncørEllerBureau_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAnnoncørEllerBureau.ValueChanged
    chkValid()
  End Sub

  Private Sub txtBeskrivelse_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeskrivelse.ValueChanged
    chkValid()
  End Sub

End Class