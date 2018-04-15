Public Class frmGemSom
  Private _annonc�rFindes As Boolean
  Private _bureauFindes As Boolean


  Public WriteOnly Property Annonc�rFindes() As Boolean
    Set(ByVal value As Boolean)
      _annonc�rFindes = value
    End Set
  End Property

  Public WriteOnly Property BureauFindes() As Boolean
    Set(ByVal value As Boolean)
      _bureauFindes = value
    End Set
  End Property

  Public Property KontaktpersonTilh�rer() As Byte
    Get
      Return optAnnonc�rEllerBureau.Value
    End Get
    Set(ByVal value As Byte)
      optAnnonc�rEllerBureau.Value = value
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

  Private Sub chkOptAnnonc�rEllerBureauVisible()
    If _annonc�rFindes AndAlso _bureauFindes Then
      optAnnonc�rEllerBureau.Visible = True
    Else
      optAnnonc�rEllerBureau.Visible = False
      If _annonc�rFindes Then
        txtKontaktpersonNavn.NullText = "- Skriv Annonc�r Kontaktperson -"
        optAnnonc�rEllerBureau.CheckedIndex = 0
      ElseIf _bureauFindes Then
        txtKontaktpersonNavn.NullText = "- Skriv Bureau Kontaktperson -"
        optAnnonc�rEllerBureau.CheckedIndex = 1
      Else
        txtKontaktpersonNavn.NullText = "- Skriv Kontaktperson -"
        optAnnonc�rEllerBureau.CheckedIndex = -1
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
      Case optAnnonc�rEllerBureau.Visible AndAlso optAnnonc�rEllerBureau.CheckedIndex = -1
        isValid = False
    End Select
    If optAnnonc�rEllerBureau.Visible Then
      If optAnnonc�rEllerBureau.CheckedIndex = -1 Then
        txtBeskrivelse.NullText = "- V�lg Annonc�r eller Bureau -"
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
    chkOptAnnonc�rEllerBureauVisible()
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

  Private Sub optAnnonc�rEllerBureau_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAnnonc�rEllerBureau.ValueChanged
    chkValid()
  End Sub

  Private Sub txtBeskrivelse_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeskrivelse.ValueChanged
    chkValid()
  End Sub

End Class