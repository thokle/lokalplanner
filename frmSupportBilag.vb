Imports System.Data.SqlClient

Public Class frmSupportBilag
  Private _modul As String
  Private _DialogSvar As String = "Annuller"
  Private _SammeMaterialePåMedieplan As Boolean
  Private _nulstiller As Boolean = True
  Public _år As Integer

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
      optMaterialeFølgerFra.Value = 1
      txtBrugMaterialeFraUge.Text = ""
      txtMaterialeFølgerFraLeverandør.Text = ""
      optSammeMateriale.Value = True
      chkKunForhandlerBundForskellig.Checked = True
      txtBemærkningTilUgeaviserne.Text = ""
      txtBemærkningTilSupport.Text = ""
      txtLøbendeOrdre.Text = ""
      chkLiggerIIndbakke.CheckState = CheckState.Unchecked
      txtOverskrift.Text = ""
      optBilagsBladeTil.Value = 0
      _DialogSvar = "Annuller"
      _modul = value
      If _modul = "Medieplan" Then
        btnSend.Text = "Send"
        LockControls(False)
      Else
        btnSend.Text = "Overfør"
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

  Public Property Annoncør()
    Get
      Return txtAnnoncør.Text
    End Get
    Set(ByVal value)
      txtAnnoncør.Text = value
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

  Public WriteOnly Property SammeMaterialePåMedieplan() As Boolean
    Set(ByVal value As Boolean)
      _SammeMaterialePåMedieplan = value
      optSammeMateriale.Value = value
      'If _år > 2010 Then
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
      txtBemærkningTilSupport.Enabled = True
      txtBemærkningTilSupport.ReadOnly = True
    Else
      txtBemærkningTilSupport.ReadOnly = False
    End If
    Me.Select()
  End Sub

  Private Sub optMaterialeFølgerFra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMaterialeFølgerFra.ValueChanged
    If optMaterialeFølgerFra.Value > 0 Then
      txtBrugMaterialeFraUge.Text = Nothing
      txtBrugMaterialeFraUge.Visible = False
      lblMatFraUge.Visible = False
      optSammeMateriale.Visible = True
      'If _år > 2010 Then
      '  If optSammeMateriale.Value Then
      '    chkKunForhandlerBundForskellig.Visible = False
      '  Else
      '    chkKunForhandlerBundForskellig.Visible = True
      '  End If
      'Else
      '  chkKunForhandlerBundForskellig.Visible = False
      'End If
      If optMaterialeFølgerFra.Value = 1 Then
        txtMaterialeFølgerFraLeverandør.NullText = "- Skriv mat. leverandør (til DLU) -"
      Else
        txtMaterialeFølgerFraLeverandør.NullText = "- Skriv mat. leverandør (til Ugeaviserne) -"
      End If
      txtMaterialeFølgerFraLeverandør.Visible = True
    Else
      txtBrugMaterialeFraUge.Visible = True
      lblMatFraUge.Visible = True
      txtMaterialeFølgerFraLeverandør.Text = Nothing
      txtMaterialeFølgerFraLeverandør.Visible = False
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
      If txtMaterialeFølgerFraLeverandør.TextLength < 1 Then txtMaterialeFølgerFraLeverandør.Text = ""
      cn.Open()
      cm.CommandText = "DELETE FROM tblSupportBilag WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      cm.CommandType = CommandType.Text
      cm.ExecuteNonQuery()
      If optSammeMateriale.Value Then
        sammeMaterialeValue = 1
      Else
        sammeMaterialeValue = 0
      End If
      sqlString = "INSERT INTO tblSupportBilag (MedieplanNr, IndrykningsUge, MaterialeFølgerFra, MaterialeFølgerFraLeverandør, BrugMaterialeFraUge, SammeMateriale, KunForhandlerBundForskellig, Fakturering, BureauOrdresedlerLiggerIIndbakke, Bilagsblade, BilagsbladeAtt, LøbendeOrdre, BemærkningTilBlade, BemærkningTilSupport, Overskrift, BilagsBladeTil, BilagsBladeTilNavn, BilagsBladeTilAdresse, BilagsBladeTilPostNr) "
      sqlString = sqlString & "VALUES (" & txtMedieplanNr.Text & ",'" & txtUgeNr.Text & "', " & optMaterialeFølgerFra.Value & ",'" & txtMaterialeFølgerFraLeverandør.Text & "','" & txtBrugMaterialeFraUge.Text & "'," & sammeMaterialeValue & "," & chkKunForhandlerBundForskellig.CheckState & "," & chkBladeneSkalFakturere.CheckState & "," & chkLiggerIIndbakke.CheckState & "," & chkBilagsblade.CheckState & ",'" & txtBilagsBladeAtt.Text & "','" & txtLøbendeOrdre.Text & "','" & txtBemærkningTilUgeaviserne.Text.Replace("'", "''") & "','" & txtBemærkningTilSupport.Text.Replace("'", "''") & "','" & txtOverskrift.Text & "'," & BilagsBladeTil & ",'" & txtNavn.Text & "','" & txtAdresse.Text & "'," & PostNr & ")"
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
      If txtFakturaBemærkning1.TextLength > 0 OrElse txtFakturaBemærkning2.TextLength > 0 Then
        cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBemærkning1 = 'Fakturabemærkning:', FakturaBemærkning2 = '" & txtFakturaBemærkning1.Text.Replace("'", "''") & "', FakturaBemærkning3 = '" & txtFakturaBemærkning2.Text.Replace("'", "''") & "' WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      Else
        cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBemærkning1 = '', FakturaBemærkning2 = '', FakturaBemærkning3 = '' WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      End If
      cm.ExecuteNonQuery()
      _DialogSvar = "Gemt"
    Else
      _DialogSvar = "Overfør"
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
      cm.CommandText = "SELECT IndrykningsUge, MaterialeFølgerFra, MaterialeFølgerFraLeverandør, BrugMaterialeFraUge, SammeMateriale, KunForhandlerBundForskellig, Fakturering, BureauOrdresedlerLiggerIIndbakke, Bilagsblade, BilagsbladeAtt, LøbendeOrdre, BemærkningTilBlade, BemærkningTilSupport, Overskrift, BilagsBladeTil, BilagsBladeTilNavn, BilagsBladeTilAdresse, BilagsBladeTilPostNr FROM tblSupportBilag WHERE (MedieplanNr = " & txtMedieplanNr.Text & ")"
      dr = cm.ExecuteReader
      dr.Read()
      txtUgeNr.Text = dr(0)
      optMaterialeFølgerFra.Value = dr(1)
      txtMaterialeFølgerFraLeverandør.Text = dr(2)
      txtBrugMaterialeFraUge.Text = dr(3)
      optSammeMateriale.Value = dr(4)
      chkKunForhandlerBundForskellig.Checked = dr(5)
      chkBladeneSkalFakturere.CheckState = dr(6)
      chkLiggerIIndbakke.CheckState = dr(7)
      chkBilagsblade.CheckState = dr(8)
      txtBilagsBladeAtt.Text = dr(9)
      txtLøbendeOrdre.Text = dr(10)
      txtBemærkningTilUgeaviserne.Text = dr(11)
      txtBemærkningTilSupport.Text = dr(12)
      txtOverskrift.Text = dr(13)
      optBilagsBladeTil.Value = dr(14)
      txtNavn.Text = dr(15)
      txtAdresse.Text = dr(16)
      txtPostNr.Text = dr(17)

      dr.Close()
      cm.CommandText = "SELECT FakturaBemærkning1, FakturaBemærkning2, FakturaBemærkning3 FROM tblMedieplanNr WHERE (MedieplanNr = " & MedieplanNr.ToString & ")"
      dr = cm.ExecuteReader
      dr.Read()
      If IsDBNull(dr("FakturaBemærkning2")) Then
        txtFakturaBemærkning1.Text = ""
      Else
        txtFakturaBemærkning1.Text = dr("FakturaBemærkning2")
      End If
      If IsDBNull(dr("FakturaBemærkning3")) Then
        txtFakturaBemærkning2.Text = ""
      Else
        txtFakturaBemærkning2.Text = dr("FakturaBemærkning3")
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

  Private Sub txtMaterialeFølgerFraLeverandør_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaterialeFølgerFraLeverandør.ValueChanged
    chkValid()
  End Sub

  Private Sub optSammeMateriale_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSammeMateriale.ValueChanged
    If _nulstiller Then Exit Sub
    'If _år > 2010 Then
    '  If optSammeMateriale.Value Then
    '    chkKunForhandlerBundForskellig.Visible = False
    '  Else
    '    chkKunForhandlerBundForskellig.Visible = True
    '  End If
    'Else
    '  chkKunForhandlerBundForskellig.Visible = False
    'End If
    If optSammeMateriale.Value <> _SammeMaterialePåMedieplan Then
      If MessageBox.Show("Du har ændret på samme eller forskelligt materiale i forhold til Medieplan" & vbCrLf & "Er dette korrekt?", "Ændret i materiale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        chkValid()
      Else
        optSammeMateriale.Value = _SammeMaterialePåMedieplan
      End If
    Else
      chkValid()
    End If
  End Sub

  Private Sub txtBemærkningTilUgeaviserne_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBemærkningTilUgeaviserne.ValueChanged
    chkValid()
  End Sub

  Private Sub txtBemærkningTilSupport_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBemærkningTilSupport.ValueChanged
    chkValid()
  End Sub

  Private Sub txtLøbendeOrdre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLøbendeOrdre.ValueChanged
    chkValid()
  End Sub

  Private Sub chkValid()
    Dim isValid As Boolean = True

    Select Case True
      Case txtUgeNr.TextLength < 1 AndAlso chkLiggerIIndbakke.CheckState = CheckState.Unchecked
        isValid = False
        'Case (optMaterialeFølgerFra.Value = 0 AndAlso txtBrugMaterialeFraUge.TextLength = 0 AndAlso chkLiggerIIndbakke.CheckState = CheckState.Unchecked) OrElse _
        '(optMaterialeFølgerFra.Value > 0 AndAlso txtBrugMaterialeFraUge.TextLength = 0 AndAlso txtMaterialeFølgerFraLeverandør.TextLength = 0 AndAlso chkLiggerIIndbakke.CheckState = CheckState.Unchecked)
      Case (optMaterialeFølgerFra.Value = 0 AndAlso txtBrugMaterialeFraUge.TextLength = 0 AndAlso chkLiggerIIndbakke.CheckState = CheckState.Unchecked) 
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

  Private Sub txtFakturaBemærkning1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtFakturaBemærkning1.ValueChanged
    chkValid()
  End Sub

  Private Sub txtFakturaBemærkning2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtFakturaBemærkning2.ValueChanged
    chkValid()
  End Sub
End Class