Imports Infragistics.Win.UltraWinGrid

Public Class frmTilBlade
  Private _modul As String
  Private _rowList As List(Of UltraGridRow)

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

  Public ReadOnly Property SvarDato() As Date
    Get
      Return CDate(Strings.Left(calDato.Value, 10)) + " " + CDate(cboKl.Text)
    End Get
  End Property

  Public ReadOnly Property VisPlaceringUB() As Boolean
    Get
      Return chkPlaceringUB.Checked
    End Get
  End Property

  Public ReadOnly Property AntalIndrykninger() As Integer
    Get
      Return CInt(txtAntalIndrykninger.Text)
    End Get
  End Property

  Public ReadOnly Property UdsendelsesType() As Integer
    Get
      If _modul = "Medieplan" Then
        Return optOrienteringsTypeMedieplan.Value
      Else
        Return optOrienteringsTypeBooking.Value
      End If
    End Get
  End Property

  Public Sub New(ByVal modul As String, ByVal rows As List(Of UltraGridRow), ByVal version As Integer)
    InitializeComponent()
    Dim i As Integer
    _rowList = rows
    calDato.Value = CDate(Now)
    For i = 9 To 17
      cboKl.Items.Add(i.ToString("00") & ":00")
      cboKl.Items.Add(i.ToString("00") & ":30")
    Next
    _modul = modul
    If _modul = "Medieplan" Then
      optOrienteringsTypeMedieplan.Visible = True
      If version > 1 Then
        optOrienteringsTypeMedieplan.Items.RemoveAt(2)
      End If
      optOrienteringsTypeBooking.Visible = False
      optEmailTilAlle.Visible = True
    Else
      optOrienteringsTypeMedieplan.Visible = False
      optOrienteringsTypeBooking.Visible = True
      optEmailTilAlle.Visible = True
    End If
  End Sub

  Private Sub txtEmne_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmne.ValueChanged
    chkValid()
  End Sub

  Private Sub chkValid()
    If optOrienteringsTypeBooking.Value = 1 Then
      btnSend.Enabled = True
    Else
      'If txtEmne.TextLength > 0 AndAlso txtTekst.TextLength > 0 Then
      If txtTekst.TextLength > 0 Then
        If optOrienteringsTypeMedieplan.Value = 2 Then
          If cboKl.Text.Length > 0 AndAlso txtAntalIndrykninger.TextLength > 0 Then
            btnSend.Enabled = True
          Else
            btnSend.Enabled = False
          End If
        Else
          If optOrienteringsTypeMedieplan.Value = 1 Then
            btnSend.Enabled = True
          Else
            If txtEmne.TextLength > 0 Then
              btnSend.Enabled = True
            Else
              btnSend.Enabled = False
            End If
          End If
        End If
      Else
        btnSend.Enabled = False
      End If
    End If
  End Sub

  Private Sub txtTekst_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTekst.ValueChanged
    chkValid()
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.Close()
  End Sub

  Private Sub optOrienteringsTypeMedieplan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrienteringsTypeMedieplan.ValueChanged
    If optOrienteringsTypeMedieplan.Value = 2 Then
      lblSvarSenest.Visible = True
      lblKl.Visible = True
      calDato.Visible = True
      cboKl.Visible = True
      lblAntalIndrykninger.Visible = True
      chkPlaceringUB.Visible = True
      txtAntalIndrykninger.Visible = True
      lblEmne.Visible = False
      txtEmne.Visible = False
      optEmailTilAlle.Visible = True
    Else
      lblSvarSenest.Visible = False
      lblKl.Visible = False
      calDato.Visible = False
      cboKl.Visible = False
      lblAntalIndrykninger.Visible = False
      chkPlaceringUB.Visible = False
      txtAntalIndrykninger.Visible = False
      If optOrienteringsTypeMedieplan.Value = 1 Then
        lblEmne.Visible = False
        txtEmne.Visible = False
        optEmailTilAlle.Visible = False
      Else
        lblEmne.Visible = True
        txtEmne.Visible = True
        optEmailTilAlle.Visible = True
      End If
    End If
    chkValid()
  End Sub

  Private Sub cboKl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKl.SelectedIndexChanged
    chkValid()
  End Sub

  Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
    Me.Hide()
  End Sub

  Private Sub txtAntalIndrykninger_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAntalIndrykninger.ValueChanged
    chkValid()
  End Sub

  Private Sub calDato_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calDato.ValueChanged
    chkValid()
  End Sub

  Private Sub optOrienteringsTypeBooking_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrienteringsTypeBooking.ValueChanged
    Dim i As Integer

    If optOrienteringsTypeBooking.Value = 1 Then
      lblEmne.Visible = False
      txtEmne.Visible = False
      optEmailTilAlle.Visible = False
      lblTekst.Text = "Reminder sendes til følgende blade:"
      For i = 0 To _rowList.Count - 1
        txtTekst.Text = txtTekst.Text + _rowList(i).Cells("UgeavisID").Text + vbCrLf
      Next
      txtTekst.ReadOnly = True
    Else
      lblEmne.Visible = True
      txtEmne.Visible = True
      optEmailTilAlle.Visible = True
      lblTekst.Text = "Tekst"
      txtTekst.Text = ""
      txtTekst.ReadOnly = False
    End If
    chkValid()
  End Sub

  Private Sub chkPlaceringUB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlaceringUB.CheckedChanged
    chkValid()
  End Sub

End Class