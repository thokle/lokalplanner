Imports System.Data.SqlClient

Public Class frmSupportBilag
  Private _modul As String
  Private _DialogSvar As String = "Annuller"
  Private _SammeMaterialeP�Medieplan As Boolean
  Private _nulstiller As Boolean = True
  Public _�r As Integer

  Public ReadOnly Property DialogSvar()
    Get
      Return _DialogSvar
    End Get
  End Property

  Public WriteOnly Property Modul()
    Set(ByVal value)
      'Nulstil felter
      _nulstiller = True
      txtUgeNr.Text = ""
      chkBladeneSkalFakturere.CheckState = CheckState.Unchecked
      chkBilagsblade.CheckState = CheckState.Unchecked
      txtBilagsBladeAtt.Text = ""
      optMaterialeF�lgerFra.Value = 1
      txtBrugMaterialeFraUge.Text = ""
      txtMaterialeF�lgerFraLeverand�r.Text = ""
      optSammeMateriale.Value = True
      chkKunForhandlerBundForskellig.Checked = True
      txtBem�rkningTilUgeaviserne.Text = ""
      txtBem�rkningTilSupport.Text = ""
      txtL�bendeOrdre.Text = ""
      chkLiggerIIndbakke.CheckState = CheckState.Unchecked
      txtOverskrift.Text = ""
      optBilagsBladeTil.Value = 0
      _DialogSvar = "Annuller"
      _modul = value
      If _modul = "Medieplan" Then
        btnSend.Text = "Send"
        LockControls(False)
      Else
        btnSend.Text = "Overf�r"
        LockControls(True)
        LoadData()
        picSupportBilag.Enabled = True
        btnSend.Enabled = True
        btnAnnuller.Enabled = True
      End If
      _nulstiller = False
      chkValid()
    End Set
  End Property

  Public Property Annonc�r()
    Get
      Return txtAnnonc�r.Text
    End Get
    Set(ByVal value)
      txtAnnonc�r.Text = value
    End Set
  End Property

  Public Property MedieplanNr()
    Get
      Return txtMedieplanNr.Text
    End Get
    Set(ByVal value)
      txtMedieplanNr.Text = value
    End Set
  End Property

  Public WriteOnly Property SammeMaterialeP�Medieplan() As Boolean
    Set(ByVal value As Boolean)
      _SammeMaterialeP�Medieplan = value
      optSammeMateriale.Value = value
      'If _�r > 2010 Then
      '  If value Then
      '    chkKunForhandlerBundForskellig.Visible = False
      '  Else
      '    chkKunForhandlerBundForskellig.Visible = True
      '  End If
      'Else
      '  chkKunForhandlerBundForskellig.Visible = False
      'End If
    End Set
  End Property


  Private Sub LockControls(ByVal lock As Boolean)
    For Each ctrl As Control In Me.Controls
      ctrl.Enabled = Not lock
    Next
    btnUdskriv.Enabled = True
    If lock Then
      txtBem�rkningTilSupport.Enabled = True
      txtBem�rkningTilSupport.ReadOnly = True
    Else
      txtBem�rkningTilSupport.ReadOnly = False
    End If
    Me.Select()
  End Sub

  Private Sub optMaterialeF�lgerFra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMaterialeF�lgerFra.ValueChanged
    If optMaterialeF�lgerFra.Value > 0 Then
      txtBrugMaterialeFraUge.Text = Nothing
      txtBrugMaterialeFraUge.Visible = False
      lblMatFraUge.Visible = False
      optSammeMateriale.Visible = True
      'If _�r > 2010 Then
      '  If optSammeMateriale.Value Then
      '    chkKunForhandlerBundForskellig.Visible = False
      '  Else
      '    chkKunForhandlerBundForskellig.Visible = True
      '  End If
      'Else
      '  chkKunForhandlerBundForskellig.Visible = False
      'End If
      If optMaterialeF�lgerFra.Value = 1 Then
        txtMaterialeF�lgerFraLeverand�r.NullText = "- Skriv mat. leverand�r (til DLU) -"
      Else
        txtMaterialeF�lgerFraLeverand�r.NullText = "- Skriv mat. leverand�r (til Ugeaviserne) -"
      End If
      txtMaterialeF�lgerFraLeverand�r.Visible = True
    Else
      txtBrugMaterialeFraUge.Visible = True
      lblMatFraUge.Visible = True
      txtMaterialeF�lgerFraLeverand�r.Text = Nothing
      txtMaterialeF�lgerFraLeverand�r.Visible = False
      optSammeMateriale.Visible = False
      chkKunForhandlerBundForskellig.Visible = False
    End If
      chkValid()
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    _DialogSvar = "Annuller"
    Me.Close()
  End Sub

  Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim sqlString As String
    Dim sammeMaterialeValue As Integer

    If _modul = "Medieplan" Then
      Dim PostNr As Integer = 0
      Dim BilagsBladeTil As Integer = -1
      If txtPostNr.TextLength > 0 Then PostNr = CInt(txtPostNr.Text)
      If optBilagsBladeTil.Value > 0 Then BilagsBladeTil = CInt(optBilagsBladeTil.Value)
      If txtMaterialeF�lgerFraLeverand�r.TextLength < 1 Then txtMaterialeF�lgerFraLeverand�r.Text = ""
      cn.Open()
      cm.CommandText = "DELETE FROM tblSupportBilag WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      cm.CommandType = CommandType.Text
      cm.ExecuteNonQuery()
      If optSammeMateriale.Value Then
        sammeMaterialeValue = 1
      Else
        sammeMaterialeValue = 0
      End If
      sqlString = "INSERT INTO tblSupportBilag (MedieplanNr, IndrykningsUge, MaterialeF�lgerFra, MaterialeF�lgerFraLeverand�r, BrugMaterialeFraUge, SammeMateriale, KunForhandlerBundForskellig, Fakturering, BureauOrdresedlerLiggerIIndbakke, Bilagsblade, BilagsbladeAtt, L�bendeOrdre, Bem�rkningTilBlade, Bem�rkningTilSupport, Overskrift, BilagsBladeTil, BilagsBladeTilNavn, BilagsBladeTilAdresse, BilagsBladeTilPostNr) "
      sqlString = sqlString & "VALUES (" & txtMedieplanNr.Text & ",'" & txtUgeNr.Text & "', " & optMaterialeF�lgerFra.Value & ",'" & txtMaterialeF�lgerFraLeverand�r.Text & "','" & txtBrugMaterialeFraUge.Text & "'," & sammeMaterialeValue & "," & chkKunForhandlerBundForskellig.CheckState & "," & chkBladeneSkalFakturere.CheckState & "," & chkLiggerIIndbakke.CheckState & "," & chkBilagsblade.CheckState & ",'" & txtBilagsBladeAtt.Text & "','" & txtL�bendeOrdre.Text & "','" & txtBem�rkningTilUgeaviserne.Text.Replace("'", "''") & "','" & txtBem�rkningTilSupport.Text.Replace("'", "''") & "','" & txtOverskrift.Text & "'," & BilagsBladeTil & ",'" & txtNavn.Text & "','" & txtAdresse.Text & "'," & PostNr & ")"
      cm.CommandText = sqlString
      cm.ExecuteNonQuery()
      cm.CommandText = "UPDATE tblMedieplanNr SET SupportBilagVedlagt = 1 WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      cm.ExecuteNonQuery()
      If chkMaterialeModtaget.Checked Then
        cm.CommandText = "UPDATE tblMedieplanNr SET MaterialeModtaget = 1 WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      Else
        cm.CommandText = "UPDATE tblMedieplanNr SET MaterialeModtaget = 0 WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      End If
      cm.ExecuteNonQuery()
      If txtFakturaBem�rkning1.TextLength > 0 OrElse txtFakturaBem�rkning2.TextLength > 0 Then
        cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBem�rkning1 = 'Fakturabem�rkning:', FakturaBem�rkning2 = '" & txtFakturaBem�rkning1.Text.Replace("'", "''") & "', FakturaBem�rkning3 = '" & txtFakturaBem�rkning2.Text.Replace("'", "''") & "' WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      Else
        cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBem�rkning1 = '', FakturaBem�rkning2 = '', FakturaBem�rkning3 = '' WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      End If
      cm.ExecuteNonQuery()
      _DialogSvar = "Gemt"
    Else
      _DialogSvar = "Overf�r"
    End If
      cm.Dispose()
      cn.Close()
      cn.Dispose()
      Me.Hide()
  End Sub

  Private Sub LoadData()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader

    If txtMedieplanNr.TextLength > 0 Then
      cn.Open()
      cm.CommandText = "SELECT IndrykningsUge, MaterialeF�lgerFra, MaterialeF�lgerFraLeverand�r, BrugMaterialeFraUge, SammeMateriale, KunForhandlerBundForskellig, Fakturering, BureauOrdresedlerLiggerIIndbakke, Bilagsblade, BilagsbladeAtt, L�bendeOrdre, Bem�rkningTilBlade, Bem�rkningTilSupport, Overskrift, BilagsBladeTil, BilagsBladeTilNavn, BilagsBladeTilAdresse, BilagsBladeTilPostNr FROM tblSupportBilag WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      dr = cm.ExecuteReader
      dr.Read()
      txtUgeNr.Text = dr(0)
      optMaterialeF�lgerFra.Value = dr(1)
      txtMaterialeF�lgerFraLeverand�r.Text = dr(2)
      txtBrugMaterialeFraUge.Text = dr(3)
      optSammeMateriale.Value = dr(4)
      chkKunForhandlerBundForskellig.Checked = dr(5)
      chkBladeneSkalFakturere.CheckState = dr(6)
      chkLiggerIIndbakke.CheckState = dr(7)
      chkBilagsblade.CheckState = dr(8)
      txtBilagsBladeAtt.Text = dr(9)
      txtL�bendeOrdre.Text = dr(10)
      txtBem�rkningTilUgeaviserne.Text = dr(11)
      txtBem�rkningTilSupport.Text = dr(12)
      txtOverskrift.Text = dr(13)
      optBilagsBladeTil.Value = dr(14)
      txtNavn.Text = dr(15)
      txtAdresse.Text = dr(16)
      txtPostNr.Text = dr(17)

      dr.Close()
      cm.CommandText = "SELECT FakturaBem�rkning1, FakturaBem�rkning2, FakturaBem�rkning3 FROM tblMedieplanNr WHERE (MedieplanNr = " & MedieplanNr.ToString & ")"
      dr = cm.ExecuteReader
      dr.Read()
      If IsDBNull(dr("FakturaBem�rkning2")) Then
        txtFakturaBem�rkning1.Text = ""
      Else
        txtFakturaBem�rkning1.Text = dr("FakturaBem�rkning2")
      End If
      If IsDBNull(dr("FakturaBem�rkning3")) Then
        txtFakturaBem�rkning2.Text = ""
      Else
        txtFakturaBem�rkning2.Text = dr("FakturaBem�rkning3")
      End If
      dr.Close()
    Else
      MessageBox.Show("Kunne ikke finde support bilaget i databasen.", "Fejl i load.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    cm.Dispose()
    cn.Close()
    cn.Dispose()
  End Sub

  Private Sub txtUgeNr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUgeNr.ValueChanged
    chkValid()
  End Sub

  Private Sub chkBladeneSkalFakturere_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBladeneSkalFakturere.CheckedChanged
    chkValid()
  End Sub

  Private Sub txtBrugMaterialeFraUge_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrugMaterialeFraUge.ValueChanged
    chkValid()
  End Sub

  Private Sub txtMaterialeF�lgerFraLeverand�r_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaterialeF�lgerFraLeverand�r.ValueChanged
    chkValid()
  End Sub

  Private Sub optSammeMateriale_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSammeMateriale.ValueChanged
    If _nulstiller Then Exit Sub
    'If _�r > 2010 Then
    '  If optSammeMateriale.Value Then
    '    chkKunForhandlerBundForskellig.Visible = False
    '  Else
    '    chkKunForhandlerBundForskellig.Visible = True
    '  End If
    'Else
    '  chkKunForhandlerBundForskellig.Visible = False
    'End If
    If optSammeMateriale.Value <> _SammeMaterialeP�Medieplan Then
      If MessageBox.Show("Du har �ndret p� samme eller forskelligt materiale i forhold til Medieplan" & vbCrLf & "Er dette korrekt?", "�ndret i materiale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        chkValid()
      Else
        optSammeMateriale.Value = _SammeMaterialeP�Medieplan
      End If
    Else
      chkValid()
    End If
  End Sub

  Private Sub txtBem�rkningTilUgeaviserne_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBem�rkningTilUgeaviserne.ValueChanged
    chkValid()
  End Sub

  Private Sub txtBem�rkningTilSupport_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBem�rkningTilSupport.ValueChanged
    chkValid()
  End Sub

  Private Sub txtL�bendeOrdre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtL�bendeOrdre.ValueChanged
    chkValid()
  End Sub

  Private Sub chkValid()
    Dim isValid As Boolean = True

    Select Case True
      Case txtUgeNr.TextLength < 1 AndAlso chkLiggerIIndbakke.CheckState = CheckState.Unchecked
        isValid = False
        'Case (optMaterialeF�lgerFra.Value = 0 AndAlso txtBrugMaterialeFraUge.TextLength = 0 AndAlso chkLiggerIIndbakke.CheckState = CheckState.Unchecked) OrElse _
        '(optMaterialeF�lgerFra.Value > 0 AndAlso txtBrugMaterialeFraUge.TextLength = 0 AndAlso txtMaterialeF�lgerFraLeverand�r.TextLength = 0 AndAlso chkLiggerIIndbakke.CheckState = CheckState.Unchecked)
      Case (optMaterialeF�lgerFra.Value = 0 AndAlso txtBrugMaterialeFraUge.TextLength = 0 AndAlso chkLiggerIIndbakke.CheckState = CheckState.Unchecked) 
        isValid = False
    End Select
    btnSend.Enabled = isValid
  End Sub

  Private Sub chkLiggerIIndbakke_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLiggerIIndbakke.CheckedChanged
    chkValid()
  End Sub

  Private Sub chkBilagsblade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBilagsblade.CheckedChanged
    chkValid()
  End Sub

  Private Sub txtBilagsBladeAtt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBilagsBladeAtt.ValueChanged
    chkValid()
  End Sub

  Private Sub btnUdskriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUdskriv.Click
    If _modul <> "Medieplan" Then LockControls(False)
    PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
    PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 10
    PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 10
    PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 10
    PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 10
    PrintDialog1.PrinterSettings = PrintForm1.PrinterSettings
    PrintDialog1.ShowDialog()
    PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
    PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
    If _modul <> "Medieplan" Then LockControls(True)
  End Sub

  Private Sub txtOverskrift_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOverskrift.ValueChanged
    chkValid()
  End Sub

  Private Sub optBilagsBladeTil_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBilagsBladeTil.ValueChanged
    If optBilagsBladeTil.Value = 3 Then
      lblNavn.Visible = True
      txtNavn.Visible = True
      lblAdresse.Visible = True
      txtAdresse.Visible = True
      lblPostNr.Visible = True
      txtPostNr.Visible = True
    Else
      lblNavn.Visible = False
      txtNavn.Visible = False
      lblAdresse.Visible = False
      txtAdresse.Visible = False
      lblPostNr.Visible = False
      txtPostNr.Visible = False
    End If
    chkValid()
  End Sub

  Private Sub txtFakturaBem�rkning1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtFakturaBem�rkning1.ValueChanged
    chkValid()
  End Sub

  Private Sub txtFakturaBem�rkning2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtFakturaBem�rkning2.ValueChanged
    chkValid()
  End Sub
End Class