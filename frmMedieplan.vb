Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win.UltraWinToolTip
Imports Infragistics.Win
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmMedieplan
  Private _inputString As String
  Private _minMax As Boolean = False
  Private _version As Integer = 0
  Private _medieplanNr As Integer = 0
  Private _modul As String
  Private _status As StatusKoder = StatusKoder.stsNyMedieplan
  Private _aktivVersion As Integer = 0
  Private WithEvents _DataValues As New clsMedieplanHoved
  Private _activeRow As UltraGridRow
  Private _activeCell As UltraGridCell
  Private _visSupportBilag As Boolean = False
  Private ReadOnly _supportBilagVedlagt As Boolean = False
  Private _supportBilagVist As Integer = 0
  Private _IsAktiv As Boolean = True
  Private _IsLoading As Boolean = False
  Private logTekst As String = ""
  Private _IsGenberegning As Boolean = False
  Private standsningsBemærkning As String = ""
  Private SupportBilagDialogSvar As String
  Private _optBilagsBladeTilValueChanged As Boolean = False
  Private _brugtGruppeVersion As Integer = 0
  Private ReadOnly _overførtFraPrisforespørgsel As Boolean = False
  Private _anvendtMiljøTillæg As Double = 0
    Private _Kommentar As String = ""
    Private _fakService As FakturaBemærkningService = New FakturaBemærkningService

  Public ReadOnly Property Version() As Integer
    Get
      Return _version
    End Get
  End Property

  Public ReadOnly Property Status() As StatusKoder
    Get
      Return _status
    End Get
  End Property

  Public ReadOnly Property IsAktiv() As Boolean
    Get
      Return _IsAktiv
    End Get
  End Property

  Public ReadOnly Property Is6Spaltet() As Boolean
    Get
      Return _DataValues.Format1 = 6
    End Get
  End Property

  Public ReadOnly Property Modul As String
    Get
      Return _modul
    End Get
  End Property

  Public ReadOnly Property UgeavisIDListe As String
    Get
      Dim liste As String = ""
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        liste = liste + Trim(CStr(arow.Cells("UgeavisID").Value)) & ";"
      Next
      If Not liste.Length = 0 Then
        Return liste.Substring(0, liste.Length - 1)
      Else
        Return ""
      End If
    End Get
  End Property

  Public Sub New(ByVal modul As String)
    _modul = modul
    InitializeComponent()
    frmBilagsbladeTil.ResetData()
    _DataValues.Modul = modul
    DataSourceMedieplan.Modul = modul
    frmMain.ActiveWindows = Me
    If _modul = "Booking" Then
      picPipeline.Image = My.Resources.BookingHeader
      For Each ctrl As Control In grpMedieplanHoved.Controls
        If ctrl.Tag = "Toggle" Then ctrl.Visible = Not ctrl.Visible
      Next
      _status = StatusKoder.stsOrdreIkkeSendt
      DataSourceMedieplan.Status = StatusKoder.stsOrdreIkkeSendt
      txtBeskrivelse.Visible = False
      lblBeskrivelse.Visible = False
      lblBemærkningTilAnnoncør.Visible = False
      txtBemærkningTilAnnoncør.Visible = False
    End If
    If _modul = "Medieplan" Then
      btnMateriale.Visible = False
      txtMaterialeFølgerFraLeverandør.Visible = False
            optSammeMateriale.Visible = True
            lblRekvisitionsNr.Visible = False

            txtFakturaBemærkning.Visible = False


    End If
    If _modul = "Fakturering" Then
      picPipeline.Image = My.Resources.FaktureringHeader
      btnMateriale.Visible = False
      txtMaterialeFølgerFraLeverandør.Visible = False
      optSammeMateriale.Visible = False
      txtBemærkningTilAnnoncør.Visible = False
      lblBemærkningTilAnnoncør.Visible = False
      lblRekvisitionsNr.Visible = True

            txtFakturaBemærkning.Visible = True
      txtHistorik.Visible = True
    End If
    Me.TblUgeaviserTableAdapter.Fill(Me.UgeavisListeDropdown.tblUgeaviser)
    Me.TblBureauerTableAdapter.Fill(Me.BureauListeDropdown.tblBureauer)
    Me.TblAnnoncørerTableAdapter.Fill(Me.AnnoncørListeDropdown.tblAnnoncører)
    Me.TblPlaceringTableAdapter.Fill(Me.PlaceringListeDropdown.tblPlacering)
    Me.TblDPKulørTableAdapter.Fill(Me.DPKulørListeDropDown.tblDPKulør)
    Me.grdOrdreLinjer.DataSource = Me.DataSourceMedieplan
    numIndrykningsUge.MaxValue = 53 'frmMain.AntalUgerIÅr
    numIndrykningsUge.Value = frmMain.DenneUge + 1
    numIndrykningsÅr.MaxValue = frmMain.DetteÅr + 1
    numIndrykningsÅr.Value = frmMain.DetteÅr
    cboPlaceringID.Value = 1
    Me.DataSourceMedieplan.AntalMm = 100
    Me.DataSourceMedieplan.Uge = numIndrykningsUge.Value
    Me.DataSourceMedieplan.År = numIndrykningsÅr.Value
    _DataValues.BrugerCode = frmMain.BrugerNavn
    _brugtGruppeVersion = frmMain.AktivGruppeVersion
    DataSourceMedieplan.BrugtGruppeVersion = frmMain.AktivGruppeVersion
    _anvendtMiljøTillæg = frmMain.AktivMiljøTillæg
    DataSourceMedieplan.AnvendtMiljøTillæg = frmMain.AktivMiljøTillæg
    _DataValues.OprindeligtMiljøTillæg = _anvendtMiljøTillæg
    setStatus(_status)
    clbMiljøTillægOpkræves.SetItemChecked(0, True)
    _DataValues.OpkrævJyskeMiljøTillæg = True
    DataSourceMedieplan.OpkrævJyskeMiljøTillæg = True
    clbMiljøTillægOpkræves.SetItemChecked(1, True)
    _DataValues.OpkrævFynskeMiljøTillæg = True
    DataSourceMedieplan.OpkrævFynskeMiljøTillæg = True
    clbMiljøTillægOpkræves.SetItemChecked(2, True)
    _DataValues.OpkrævNorthMiljøTillæg = True
    DataSourceMedieplan.OpkrævNorthMiljøTillæg = True
    clbMiljøTillægOpkræves.SetItemChecked(3, True)
    _DataValues.OpkrævDSVPMiljøTillæg = True
    DataSourceMedieplan.OpkrævDSVPMiljøTillæg = True
    clbMiljøTillægOpkræves.SetItemChecked(4, True)
    _DataValues.OpkrævJyskeMedierASTillæg = True
    DataSourceMedieplan.OpkrævJyskeMedierASTillæg = True
    Me.Text = "P: Ny"

    If frmMain.Width > 1200 Then
      lblKommentar.Visible = True
      txtKommentar.Visible = True
      If frmMain.Width < 1480 Then
        Dim bredde As Integer = frmMain.Width - 1130
        Dim tegnPrLinje As Integer = bredde / 7
        Dim antalLinjer As Integer = 250 / tegnPrLinje
        Dim højde As Integer = antalLinjer * 15
        txtKommentar.Height = højde - 7
      End If
    Else
      btnKommentar.Visible = True
    End If

    txtHistorik.Height = 174

    Me.Cursor = Cursors.Default
  End Sub

  Private Sub LockControls(ByVal lock As Boolean)
    For Each ctrl As Control In Me.Controls
      ctrl.Enabled = Not lock
      If lock Then
        ctrl.Cursor = Cursors.No
      Else
        ctrl.Cursor = Cursors.Default
      End If
    Next
    grpMedieplanHoved.Enabled = True
    grpMedieplanHoved.Cursor = Cursors.Default
    For Each ctrl As Control In grpMedieplanHoved.Controls
      ctrl.Enabled = Not lock
      If lock Then
        ctrl.Cursor = Cursors.No
      Else
        ctrl.Cursor = Cursors.Default
      End If
    Next
  End Sub

  Public Sub New(ByVal modul As String, ByVal planNr As Integer, ByVal version As Integer)
    Me.New(modul)
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader

    Me.Cursor = Cursors.WaitCursor
    _medieplanNr = planNr
    _version = version
    _IsLoading = True
    cm.CommandType = CommandType.Text
    cm.CommandText = String.Format("SELECT AktivVersion, SupportBilagVedlagt, SupportBilagVist, MaterialeModtaget, BrugtGruppeVersion, OverførtFraPrisforespørgsel, AnvendtMiljøTillæg, Kommentar FROM tblMedieplanNr WHERE (MedieplanNr = {0})", _medieplanNr)
    cn.Open()
    dr = cm.ExecuteReader
    dr.Read()
    _aktivVersion = dr(0)
    _supportBilagVedlagt = dr(1)
    _supportBilagVist = dr(2)
    chkMaterialeModtaget.Checked = dr(3)
    _brugtGruppeVersion = dr(4)
    DataSourceMedieplan.BrugtGruppeVersion = dr(4)
    _overførtFraPrisforespørgsel = dr(5)
    _anvendtMiljøTillæg = dr(6)
    _Kommentar = dr(7)
    DataSourceMedieplan.AnvendtMiljøTillæg = _anvendtMiljøTillæg
    _DataValues.OprindeligtMiljøTillæg = _anvendtMiljøTillæg
    dr.Close()
    If Not Me.LoadData() Then Me.Close()
    If _version > 1 Then
      If modul = "Medieplan" Then
        cm.CommandText = String.Format("SELECT TOP (100) PERCENT CASE WHEN tblMedieplanÆndringer.Version < 10 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplanÆndringer.Version)) WHEN tblMedieplanÆndringer.Version > 10 AND tblMedieplanÆndringer.Version < 100 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version), 1) WHEN tblMedieplanÆndringer.Version > 100 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version), 1) END AS Nr, ÆndringsTekst FROM tblMedieplanÆndringer WHERE (MedieplanNr = {0}) AND (Version > 1 AND Version < 10) ORDER BY tblMedieplanÆndringer.Version DESC", _medieplanNr)
      ElseIf modul = "Booking" Then
        cm.CommandText = String.Format("SELECT TOP (100) PERCENT CASE WHEN tblMedieplanÆndringer.Version < 10 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplanÆndringer.Version)) WHEN tblMedieplanÆndringer.Version > 10 AND tblMedieplanÆndringer.Version < 100 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version), 1) WHEN tblMedieplanÆndringer.Version > 100 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version), 1) END AS Nr, ÆndringsTekst FROM tblMedieplanÆndringer WHERE (MedieplanNr = {0}) AND (Version > 11 AND Version < 100) ORDER BY tblMedieplanÆndringer.Version DESC", _medieplanNr)
      Else
        cm.CommandText = String.Format("SELECT TOP (100) PERCENT CASE WHEN tblMedieplanÆndringer.Version < 10 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplanÆndringer.Version)) WHEN tblMedieplanÆndringer.Version > 10 AND tblMedieplanÆndringer.Version < 100 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version), 1) WHEN tblMedieplanÆndringer.Version > 100 THEN LTRIM(STR(tblMedieplanÆndringer.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplanÆndringer.Version), 1) END AS Nr, ÆndringsTekst FROM tblMedieplanÆndringer WHERE (MedieplanNr = {0}) AND (Version > 11) ORDER BY tblMedieplanÆndringer.Version DESC", _medieplanNr)
      End If
      dr = cm.ExecuteReader
      While dr.Read
        txtHistorik.Text = txtHistorik.Text & dr(0) & " >> " & dr(1)
      End While
      dr.Close()
      btnHistorik.Visible = True
    Else
      btnHistorik.Visible = False
    End If
    If _status >= StatusKoder.stsUdsendtOrdre AndAlso numIndrykningsUge.Value <= frmMain.DenneUge Then
      If frmMain.HarRollen("Salg") Then
        'grdOrdreLinjer.DisplayLayout.Bands(0).Columns("Faktureringsbilag").Hidden = False
        DeAktiverPlan()
        grdOrdreLinjer.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
        grdOrdreLinjer.DisplayLayout.Override.AllowDelete = DefaultableBoolean.False
        grdOrdreLinjer.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
      End If
      'If frmMain.HarRollen("Support") And Not frmMain.HarRollen("Admin") Then
      '  grdOrdreLinjer.DisplayLayout.Bands(0).Columns("Faktureringsbilag").Hidden = False
      '  ' DeAktiverPlan()
      '  'If _status = StatusKoder.stsUdsendtOrdre AndAlso numIndrykningsUge.Value = frmMain.DenneUge AndAlso frmMain.DenneUgeDag < 4 Then
      '  '  Dim foundSpærretAvis As Boolean = False
      '  '  For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      '  '    If arow.Cells("UdgivelsesDag").Value < 4 Then
      '  '      arow.Activation = Activation.ActivateOnly
      '  '      arow.Cells("Faktureringsbilag").IgnoreRowColActivation = True
      '  '      foundSpærretAvis = True
      '  '    Else
      '  '      arow.Cells("Faktureringsbilag").Activation = Activation.Disabled
      '  '      arow.Cells("Faktureringsbilag").Style = ColumnStyle.Edit
      '  '      arow.Cells("Faktureringsbilag").Hidden = True
      '  '    End If
      '  '  Next
      '  '  If foundSpærretAvis Then DeAktiverPlan()
      '  'Else
      '  '  grdOrdreLinjer.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
      '  '  grdOrdreLinjer.DisplayLayout.Override.AllowDelete = DefaultableBoolean.False
      '  '  grdOrdreLinjer.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
      '  'End If
      'End If
      ''If frmMain.HarRollen("Fakturering") Or frmMain.HarRollen("Admin") Then
      '  grdOrdreLinjer.DisplayLayout.Bands(0).Columns("Faktureringsbilag").Hidden = False
      '  cm.CommandText = "SELECT MedieplanNr FROM tblFaktureringsBilag WHERE (BemærkningNr = 1) AND (MedieplanNr = " & _medieplanNr & ")"
      '  If IsDBNull(cm.ExecuteScalar) Then
      '    btnVisFaktureringsBilag.Visible = False
      '  Else
      '    btnVisFaktureringsBilag.Visible = True
      '  End If
      'End If
    End If

    grdOrdreLinjer.DisplayLayout.ValueLists.Add("AnsvarListe")
    If _status = StatusKoder.stsFærdigTjekketOrdre Then
      cm.CommandText = "SELECT Code FROM Salesperson WHERE (Status = 0)"
      dr = cm.ExecuteReader
      While dr.Read
        grdOrdreLinjer.DisplayLayout.ValueLists("AnsvarListe").ValueListItems.Add(dr(0))
      End While
      dr.Close()
    End If
    grdOrdreLinjer.DisplayLayout.ValueLists("AnsvarListe").ValueListItems.Add("U")
    grdOrdreLinjer.DisplayLayout.ValueLists("AnsvarListe").ValueListItems.Add("M")
    grdOrdreLinjer.DisplayLayout.ValueLists("AnsvarListe").ValueListItems.Add("A")
    grdOrdreLinjer.DisplayLayout.ValueLists("AnsvarListe").ValueListItems.Add("DLU")
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New Ansvar").ValueList = grdOrdreLinjer.DisplayLayout.ValueLists("AnsvarListe")
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    If _supportBilagVedlagt AndAlso modul = "Booking" Then
      btnSupportBilag.Visible = True
      _visSupportBilag = True
    Else
      btnSupportBilag.Visible = False
      _visSupportBilag = False
    End If

    If frmMain.Width > 1200 Then
      If String.IsNullOrEmpty(_Kommentar) Then
        txtKommentar.Value = Nothing
      Else
        txtKommentar.Text = _Kommentar
      End If
    Else
      KommentarToolTip()
    End If

    If _status = StatusKoder.stsFaktureretOrdre AndAlso frmMain.HarRollen("Fakturering") OrElse frmMain.HarRollen("Admin") Then
      grdOrdreLinjer.DisplayLayout.ValueLists.Add("FejlListe")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Bestilt for sent - ikke bragt")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Ordre ikke modtaget")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Glemt Annonce")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("DLU har fremsendt forkert matr.")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Vi har indrykket forkert matr.")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Forkert farve")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Forkert placering")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Forkert annonce format")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Glemt farve")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("Forkert Pris")
      grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe").ValueListItems.Add("System Fejl")
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("FejlTekst").ValueList = grdOrdreLinjer.DisplayLayout.ValueLists("FejlListe")
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("FejlTekst").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("FejlTekst").Style = ColumnStyle.DropDownValidate
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("FejlTekst").CellActivation = Activation.AllowEdit
    End If
    If modul = "Medieplan" AndAlso _overførtFraPrisforespørgsel Then
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("BemærkningFraPrisforespørgsel").Hidden = False
      DataSourceMedieplan.Beregn()
    Else
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("BemærkningFraPrisforespørgsel").Hidden = True
    End If
    If _aktivVersion > _version AndAlso _aktivVersion > 10 Then DeAktiverPlan()
    _DataValues.checkValid()
    setStatus(_status)
    _IsLoading = False
    Me.Cursor = Cursors.Default
    If _DataValues.MaterialeFølgerFra = 1 Then btnMateriale.Enabled = True
  End Sub

  Private Sub KommentarToolTip()
    If _Kommentar.Length > 0 Then
      btnKommentar.BackColor = Color.Yellow
      btnKommentar.BackgroundImageLayout = ImageLayout.Center

      Dim ord() As String = _Kommentar.Split(" ")
      Dim linje(5) As String
      Dim j As Integer = 0

      linje(0) = ord(0)
      For i As Integer = 1 To UBound(ord)
        If Len(linje(j) & " " & ord(i)) <= 50 Then
          linje(j) = linje(j) & " " & ord(i)
        Else
          linje(j) = linje(j) & "<br>"
          j = j + 1
          linje(j) = ord(i)
        End If
      Next

      Dim toolTipInfo As UltraToolTipInfo = ToolTipManager.GetUltraToolTip(btnKommentar)
      toolTipInfo.ToolTipTextFormatted = "Klik her for at <B>redigere</B> denne interne Kommentar:<br>" & linje(0) & linje(1) & linje(2) & linje(3) & linje(4) & linje(5)
      ToolTipManager.SetUltraToolTip(btnKommentar, toolTipInfo)
    End If
  End Sub

  Private Sub DeAktiverPlan()
    _IsAktiv = False
    LockControls(True)
    btnKopierTilNy.Enabled = True
    btnAnnuller.Enabled = True
    btnLuk.Enabled = True
    btnUdskriv.Enabled = True
    btnDækningskort.Enabled = True
    btnHistorik.Enabled = True
    grdOrdreLinjer.Enabled = True
    grdOrdreLinjer.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
    grdOrdreLinjer.DisplayLayout.Override.AllowDelete = DefaultableBoolean.False
    grdOrdreLinjer.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
    'btnVisFaktureringsBilag.Enabled = True
    If _DataValues.MaterialeFølgerFra = 1 Then
      btnMateriale.Enabled = True
      btnMateriale.Cursor = Cursors.Default
    End If
    btnTilBlade.Enabled = True
    btnGenUdsend.Enabled = True
    picMinMax.Enabled = True
    grdCC.Enabled = True

    btnTilExcel.Enabled = True

    btnKopierTilNy.Cursor = Cursors.Default
    btnAnnuller.Cursor = Cursors.Default
    btnLuk.Cursor = Cursors.Default
    btnUdskriv.Cursor = Cursors.Default
    btnDækningskort.Cursor = Cursors.Default
    btnHistorik.Cursor = Cursors.Default
    grdOrdreLinjer.Cursor = Cursors.Default
    'btnVisFaktureringsBilag.Cursor = Cursors.Default
    btnTilBlade.Cursor = Cursors.Default
    picMinMax.Cursor = Cursors.Default
    btnGenUdsend.Cursor = Cursors.Default
    grdCC.Cursor = Cursors.Default

    btnTilExcel.Cursor = Cursors.Default
  End Sub

  Private Function LoadData() As Boolean
    Dim ta As New dstMedieplanTableAdapters.tblMedieplanTableAdapter
    Dim table As New dstMedieplan.tblMedieplanDataTable
        Dim fak As String = _fakService.getFakturaBemærkng(_medieplanNr)

      
        txtFakturaBemærkning.Value = fak

      


        DataSourceMedieplan.MedieplanNr = _medieplanNr
        DataSourceMedieplan.Version = _version
        _DataValues.MedieplanNr = _medieplanNr
        _DataValues.Version = _version
        resetGridCellFont()
        If ta.Fill(table, _medieplanNr, _version) > 0 Then
            cboAnnoncørNO_.Value = table(0).AnnoncørNo_
            cboBureauNO_.Value = table(0).BureauNo_
            txtFormat1.Value = table(0).Format1
            txtFormat2.Value = table(0).Format2
            optAntalFarver.Value = table(0).AntalFarver
            cboDPKulørID.Value = table(0).DPKulørID
            cboPlaceringID.Value = table(0).PlaceringID
            numIndrykningsUge.Value = table(0).IndrykningsUge
            numIndrykningsÅr.Value = table(0).IndrykningsÅr
            txtBemærkningTilAnnoncør.Value = table(0).BemærkningTilAnnoncør
            txtBemærkningTilUgeavis.Value = table(0).BemærkningTilBlade
            txtBeskrivelse.Value = table(0).Beskrivelse
            _DataValues.Kontaktperson = table(0).Kontaktperson
            _DataValues.KontaktpersonTilhører = table(0).KontaktpersonTilhører
            txtOverskrift.Value = table(0).Overskrift
            optFakturering.Value = table(0).Fakturering

            optBilagsBladeTil.Value = table(0).BilagsBladeTil
            _DataValues.BilagsBladeTilNavn = table(0).BilagsBladeTilNavn
            _DataValues.BilagsBladeTilAdresse = table(0).BilagsBladeTilAdresse
            _DataValues.BilagsBladeTilPostNr = table(0).BilagsBladeTilPostNr
            txtBilagsBladeAtt.Value = table(0).BilagsBladeATT
            optMaterialeFølgerFra.Value = table(0).MaterialeFølgerFra
            txtMaterialeFølgerFraLeverandør.Value = table(0).MaterialeFølgerFraLeverandør
            txtBrugMaterialeFraUge.Value = table(0).BrugMaterialeFraUge
            optSammeMateriale.Value = table(0).SammeMateriale
            chkKunForhandlerBundForskellig.Checked = table(0).KunForhandlerBundForskellig
            txtFællesBureauOrdreNr.Value = table(0).FællesBureauOrdreNr
            chkFarveSærRabat.Checked = table(0).TilladFarveSærRabat
            chkMmSærRabat.Checked = table(0).TilladMmSærRabat
            'chkWebTillægOpkræves.Checked = table(0).WebTillægOpkræves
            chkMiljøTillægOpkræves.Checked = table(0).MiljøTillægOpkræves
            clbMiljøTillægOpkræves.SetItemChecked(0, table(0).OpkrævJyskeMiljøTillæg)
            _DataValues.OpkrævJyskeMiljøTillæg = table(0).OpkrævJyskeMiljøTillæg
            DataSourceMedieplan.OpkrævJyskeMiljøTillæg = table(0).OpkrævJyskeMiljøTillæg
            clbMiljøTillægOpkræves.SetItemChecked(1, table(0).OpkrævFynskeMiljøTillæg)
            _DataValues.OpkrævFynskeMiljøTillæg = table(0).OpkrævFynskeMiljøTillæg
            DataSourceMedieplan.OpkrævFynskeMiljøTillæg = table(0).OpkrævFynskeMiljøTillæg
            clbMiljøTillægOpkræves.SetItemChecked(2, table(0).OpkrævNorthMiljøTillæg)
            _DataValues.OpkrævNorthMiljøTillæg = table(0).OpkrævNorthMiljøTillæg
            DataSourceMedieplan.OpkrævNorthMiljøTillæg = table(0).OpkrævNorthMiljøTillæg
            clbMiljøTillægOpkræves.SetItemChecked(3, table(0).OpkrævDSVPMiljøTillæg)
            _DataValues.OpkrævDSVPMiljøTillæg = table(0).OpkrævDSVPMiljøTillæg
            DataSourceMedieplan.OpkrævDSVPMiljøTillæg = table(0).OpkrævDSVPMiljøTillæg
            clbMiljøTillægOpkræves.SetItemChecked(4, table(0).OpkrævJyskeMedierASTillæg)
            _DataValues.OpkrævJyskeMedierASTillæg = table(0).OpkrævJyskeMedierASTillæg
            DataSourceMedieplan.OpkrævJyskeMedierASTillæg = table(0).OpkrævJyskeMedierASTillæg
            _DataValues.TilladFarveSærRabat = table(0).TilladFarveSærRabat
            _DataValues.TilladMmSærRabat = table(0).TilladMmSærRabat
            _status = table(0).Status
            _DataValues.RettelserEfterAnnoncekontrol = table(0).RettelserEfterAnnoncekontrol
            DataSourceMedieplan.Status = table(0).Status
            _DataValues.Status = _status
            _DataValues.SetOldValuesToNewValues()
            lblMedieplanNr.Text = getMedieplanString(_medieplanNr, _version)
            Me.Text = "P:" & getMedieplanString(_medieplanNr, _version)
            picGul.Tag = "Off"
            picGul.Image = My.Resources.StatusLedYellowOff
            picGrøn.Tag = "On"
            picGrøn.Image = My.Resources.StatusLedGreenOn
            picRød.Tag = "Off"
            picRød.Image = My.Resources.StatusLedRedOff
            If DataSourceMedieplan.LoadData() Then
                setStatus(_status)
                timer365.Enabled = True
                Return True
            Else
                MsgBox("Fejl ved indlæsning af plan Linjer")
                Return False
            End If
        Else
            MsgBox("Fejl ved indlæsning af plan Hoved")
            Return False
        End If
  End Function

  Private Sub setStatus(ByVal status As StatusKoder)
    Me.SuspendLayout()
    btnGem.Text = "&Gem"
    btnTilBooking.Visible = True
    btnGenberegn.Visible = False
    btnDækningskort.Text = "&Dækningskort"

    Select Case status
      Case StatusKoder.stsNyMedieplan
        picStatusKode.Image = My.Resources.StaKodeNyMedieplan
        btnTilBooking.Text = "Til &Booking"
        btnDækningskort.Visible = True
        btnTilBlade.Visible = True
        btnMateriale.Visible = False
        If frmMain.HarRollen("Support") Then
          If optMaterialeFølgerFra.Value = 1 Then
            chkMaterialeModtaget.Visible = True
          Else
            chkMaterialeModtaget.Visible = False
          End If
        End If
      Case StatusKoder.stsMedieplan
        btnMateriale.Visible = False
        picStatusKode.Image = My.Resources.StaKodeMedieplan
        If _modul = "Medieplan" Then
          btnTilBooking.Text = "Til &Booking"
          btnTilBooking.Visible = True
        Else
          btnTilBooking.Visible = False
        End If
        If frmMain.HarRollen("Support") Then
          If optMaterialeFølgerFra.Value = 1 Then
            If picGrøn.Tag = "On" Then
              chkMaterialeModtaget.Visible = True
            Else
              chkMaterialeModtaget.Visible = False
            End If
          End If
        End If
      Case StatusKoder.stsOrdreIkkeSendt
        picStatusKode.Image = My.Resources.StaKodeOrdreIkkeSendt
        btnMateriale.Visible = False
        If _modul = "Medieplan" Then
          If _aktivVersion < 10 Then
            btnTilBooking.Text = "Til &Booking"
            btnTilBooking.Visible = True
          Else
            btnTilBooking.Visible = False
          End If
          If frmMain.HarRollen("Support") Then
            If optMaterialeFølgerFra.Value = 1 Then
              If picGrøn.Tag = "On" Then
                chkMaterialeModtaget.Visible = True
              Else
                chkMaterialeModtaget.Visible = False
              End If
            End If
          End If
        Else
          btnTilBooking.Text = "Ud&send Ordre"
          If _aktivVersion > _version AndAlso _aktivVersion > 10 Then
            btnTilBooking.Visible = False
          Else
            btnTilBooking.Visible = True
          End If
          If picGrøn.Tag = "On" Then btnTilBooking.Enabled = True
          If frmMain.HarRollen("Support") Then
            If optMaterialeFølgerFra.Value = 1 Then
              If picGrøn.Tag = "On" Then
                chkMaterialeModtaget.Visible = True
              Else
                chkMaterialeModtaget.Visible = False
              End If
            End If
          End If
        End If

      Case StatusKoder.stsUdsendtOrdre
        btnMateriale.Visible = True
        picStatusKode.Image = My.Resources.StaKodeUdsendtOrdre
        btnTilBooking.Text = "&Stands Ordre"
        If _aktivVersion > _version AndAlso _aktivVersion > 10 Then
          btnTilBooking.Visible = False
        Else
          btnTilBooking.Visible = True
        End If
        btnGem.Text = "Send og Gem"
        If optMaterialeFølgerFra.Value = 1 Then
          If picGrøn.Tag = "On" Then
            chkMaterialeModtaget.Visible = True
            btnMateriale.Enabled = True
          Else
            chkMaterialeModtaget.Visible = False
            btnMateriale.Enabled = False
          End If
        Else
          btnMateriale.Enabled = False
        End If
        btnGenUdsend.Visible = True
      Case StatusKoder.stsStandsetOrdre
        picStatusKode.Image = My.Resources.StaKodeStandsetOrdre
        DeAktiverPlan()
        btnTilBooking.Visible = False
        btnGenUdsend.Visible = True
      Case StatusKoder.stsFærdigTjekketOrdre
        picStatusKode.Image = My.Resources.StaKodeFærdigTjekketOrdre
        btnTilBooking.Visible = False
        btnDækningskort.Visible = False
        'btnTilBlade.Visible = False
        ÅbenForFakturaRettelser()
        btnGem.Text = "Send og Gem"
      Case StatusKoder.stsFaktureretOrdre
        picStatusKode.Image = My.Resources.StaKodeFaktureretOrdre
        ÅbenForFakturaRettelser()
        If _version > 100 AndAlso _version Mod 10 = 1 Then
          btnDækningskort.Visible = True
          btnDækningskort.Text = "Træk tilbage"
        Else
          btnDækningskort.Visible = False
        End If
        btnTilBooking.Visible = False
        'btnTilBlade.Visible = False
        btnGenUdsend.Visible = True
        btnGenberegn.Visible = True
        btnGem.Text = "Send og Gem"
      Case StatusKoder.stsUbetaltOrdre
        picStatusKode.Image = My.Resources.StaKodeUbetaltOrdre
        'If _version > 100 AndAlso _version Mod 10 = 1 Then
        '  btnDækningskort.Visible = True
        '  btnDækningskort.Text = "Træk tilbage"
        'Else
        btnDækningskort.Visible = False
        'End If
        btnTilBooking.Visible = False
        'btnTilBlade.Visible = False
        btnGenberegn.Visible = True
        btnGem.Text = "Send og Gem"
      Case StatusKoder.stsAfsluttetOrdre
        picStatusKode.Image = My.Resources.StaKodeAfsluttetOrdre
        btnTilBooking.Visible = False
        btnDækningskort.Visible = False
        btnTilBlade.Visible = False
        btnGem.Text = "Send og Gem"
    End Select
    If Not _IsAktiv Then
      ' btnTilBlade.Enabled = False
      btnTilBooking.Enabled = False
    End If
    Me.ResumeLayout()
  End Sub

  Private Sub ÅbenForFakturaRettelser()
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New Bemærkning").Hidden = True
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("FejlTekst").Hidden = False
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New Ansvar").Hidden = False
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("Mm").Hidden = False
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("MedIGrupper").Hidden = True
  End Sub

  Private Sub LukForFakturaRettelser()
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New Bemærkning").Hidden = False
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("FejlTekst").Hidden = True
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New Ansvar").Hidden = True
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("Mm").Hidden = True
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("MedIGrupper").Hidden = False
  End Sub

  Private Sub OpdaterStatusIMedieplanTabeller(ByVal status As StatusKoder)
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    cm.CommandType = CommandType.Text
    cm.CommandText = String.Format("UPDATE tblMedieplan SET Status = " & _status & " WHERE (MedieplanNr = {0} AND Version = {1})", _medieplanNr, _version)
    cn.Open()
    cm.ExecuteNonQuery()
    cm.CommandText = String.Format("UPDATE tblMedieplanNr SET Status = " & _status & " WHERE (MedieplanNr = {0})", _medieplanNr)
    cm.ExecuteNonQuery()
    cn.Close()
    cm.Dispose()
    cn.Dispose()
  End Sub

  Private Sub frmMedieplan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    If _visSupportBilag Then 'Vis bilag hvis det findes
      _visSupportBilag = False
      If _supportBilagVist = 0 Then
        _supportBilagVist = 1
        OpdaterMedieplanNrTabel()
        timerSupportBilag.Enabled = True
      End If
    End If
  End Sub

  Private Sub frmMedieplan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    grdOrdreLinjer.DrawFilter = New SortIndicatorDrawFilter

    If _DataValues.AntalFarver = 0 Then
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarvePris").Hidden = True
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveRabat").Hidden = True
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveTotal").Hidden = True
    Else
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarvePris").Hidden = False
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveRabat").Hidden = False
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveTotal").Hidden = False
    End If
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("GeoKodeNavn").SortComparer = New sortBySortKey
    grdOrdreLinjer.DisplayLayout.Bands(0).Columns("UgeavisID").SortComparer = New sortByRowState
    Dim summary As SummarySettings = grdOrdreLinjer.DisplayLayout.Bands(0).Summaries("Aviser")
    summary.CustomSummaryCalculator = New clsCountNotDeleted
    summary.SummaryType = SummaryType.Custom
    grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.RefreshSort(True)
  End Sub

  Private Sub txtFormat_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFormat1.ValueChanged, txtFormat2.ValueChanged
    Integer.TryParse(txtFormat1.Text, _DataValues.Format1)
    Integer.TryParse(txtFormat2.Text, _DataValues.Format2)
    If txtFormat1.TextLength > 0 AndAlso txtFormat2.TextLength > 0 Then
      If txtFormat1.Text = "6" Then 'Se om der er 5 spaltede aviser på planen
        For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
          If arow.Cells("UgeavisID").Value = 417 OrElse arow.Cells("UgeavisID").Value = 246 Then
            arow.Delete()
          End If
        Next
      End If
      Me.DataSourceMedieplan.Kolonner = CInt(txtFormat1.Text)
      If txtFormat2.Text = "365" Then
        Me.DataSourceMedieplan.Is365 = True
      Else
        Me.DataSourceMedieplan.Is365 = False
      End If
      Me.DataSourceMedieplan.AntalMm360 = CInt(txtFormat1.Text) * 360
      Me.DataSourceMedieplan.AntalMm = CInt(txtFormat1.Text) * CInt(txtFormat2.Text)
    Else
      Me.DataSourceMedieplan.Is365 = False
      Me.DataSourceMedieplan.AntalMm360 = 0
      Me.DataSourceMedieplan.AntalMm = 0
    End If
    BoldItalicLinjer()
    MarkerFarveMin()
  End Sub

  Private Sub optAntalFarver_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAntalFarver.ValueChanged
    Try
      Select Case optAntalFarver.CheckedIndex
        Case 0
          cboDPKulørID.Visible = False
          lblDPKulør.Visible = False
          chkFarveSærRabat.Visible = False
          DataSourceMedieplan.AntalFarver = 0
          _DataValues.AntalFarver = 0
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarvePris").Hidden = True
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveRabat").Hidden = True
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveTotal").Hidden = True
        Case 1
          cboDPKulørID.Visible = True
          lblDPKulør.Visible = True
          chkFarveSærRabat.Visible = True
          DataSourceMedieplan.AntalFarver = 1
          _DataValues.AntalFarver = 1
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarvePris").Hidden = False
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveRabat").Hidden = False
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveTotal").Hidden = False
          MarkerFarveMin()
        Case 2
          cboDPKulørID.Visible = False
          lblDPKulør.Visible = False
          chkFarveSærRabat.Visible = True
          DataSourceMedieplan.AntalFarver = 4
          _DataValues.AntalFarver = 4
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarvePris").Hidden = False
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveRabat").Hidden = False
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New FarveTotal").Hidden = False
          MarkerFarveMin()
      End Select
    Catch
    End Try
  End Sub

  Private Sub grdOrdreLinjer_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grdOrdreLinjer.AfterCellUpdate
    If Not IsDBNull(e.Cell.Value) Then
      If e.Cell.Column.Key.StartsWith("New") Then
        If e.Cell.Value <> e.Cell.Row.Cells(e.Cell.Column.Key.Replace("New", "Old")).Value Then
          e.Cell.Appearance.FontData.Italic = DefaultableBoolean.True
          e.Cell.Appearance.FontData.Bold = DefaultableBoolean.True
          e.Cell.ToolTipText = e.Cell.Row.Cells(e.Cell.Column.Key.Replace("New", "Old")).Value
        Else
          e.Cell.Appearance.FontData.Bold = DefaultableBoolean.False
          e.Cell.Appearance.FontData.Italic = DefaultableBoolean.False
          e.Cell.ToolTipText = ""
        End If
        'ElseIf e.Cell.Column.Key = "PrisLåst" Then
        '  If e.Cell.Value Then
        '    e.Cell.Appearance.BackColor = Color.Red
        '  Else
        '    e.Cell.Appearance.BackColor = Nothing
        '  End If
      End If
    End If
  End Sub

  Private Sub grdOrdreLinjer_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdOrdreLinjer.DoubleClickRow
    If e.Row.IsGroupByRow Then
      If optGruppering.Value > 0 Then
        Dim i As Integer
        Dim fundetGruppe As Integer = -1
        Dim arow As UltraGridGroupByRow = CType(e.Row, UltraGridGroupByRow)

        For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe)
          If _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Navn = arow.Value Then
            fundetGruppe = i
            Exit For
          End If
        Next
        If fundetGruppe > -1 Then
          If _gruppeVersion(_brugtGruppeVersion)._gruppe(fundetGruppe).Rabatter IsNot Nothing Then
            For Each frm As Form In My.Application.OpenForms
              If frm.Name = "frm" & arow.Value Then
                frm.BringToFront()
                Exit Sub
              End If
            Next
            Dim nyRabatVindue As New frmVisRabatter(fundetGruppe) With {.Text = "Rabatter for " & arow.Value, .Name = "frm" & arow.Value}
            Dim xLoc As Integer = Cursor.Position.X
            Dim yLoc As Integer = Cursor.Position.Y
            Dim yHeight As Integer = 100 + UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe(fundetGruppe).Rabatter) * 18
            nyRabatVindue.Height = yHeight
            If yLoc + nyRabatVindue.Height > Me.Height Then
              yLoc = yLoc - nyRabatVindue.Height
            End If
            nyRabatVindue.Location = New Point(xLoc, yLoc)
            nyRabatVindue.Owner = Me
            nyRabatVindue.Show()
          End If
        End If
      End If
    End If
  End Sub

  Private Sub grdOrdreLinjer_KeyDownExtracted()
    If grdOrdreLinjer.Selected.Columns.Count > 0 Then
      For Each colHead As ColumnHeader In grdOrdreLinjer.Selected.Columns
        If grdOrdreLinjer.Rows.Count > 0 Then
          For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
            Select Case colHead.Column.DataType.Name
              Case "String"
                arow.Cells(colHead.Column.Key).Value = _inputString
              Case "Integer"
                arow.Cells(colHead.Column.Key).Value = CInt(_inputString)
              Case "Double"
                arow.Cells(colHead.Column.Key).Value = CDbl(_inputString)
              Case "Decimal"
                arow.Cells(colHead.Column.Key).Value = CDec(_inputString)
            End Select
          Next
        End If
      Next
    ElseIf grdOrdreLinjer.Selected.Cells.Count > 0 Then
      For Each acell As UltraGridCell In grdOrdreLinjer.Selected.Cells
        Select Case acell.Column.DataType.Name
          Case "String"
            acell.Value = _inputString
          Case "Integer"
            Integer.TryParse(_inputString, acell.Value)
          Case "Double"
            Double.TryParse(_inputString, acell.Value)
          Case "Decimal"
            Decimal.TryParse(_inputString, acell.Value)
        End Select
      Next
    End If
  End Sub

  Private Sub grdOrdreLinjer_KeyDown_Reset()
    If grdOrdreLinjer.Selected.Rows.Count > 0 Then
      For Each arow As UltraGridRow In grdOrdreLinjer.Selected.Rows
        arow.Update()
      Next
    ElseIf grdOrdreLinjer.Selected.Columns.Count > 0 Then
      For Each colHead As ColumnHeader In grdOrdreLinjer.Selected.Columns
        If grdOrdreLinjer.Rows.Count > 0 Then
          For Each arow As UltraGridRow In Me.grdOrdreLinjer.Rows.GetAllNonGroupByRows
            arow.Update()
          Next
        End If
      Next
    ElseIf grdOrdreLinjer.Selected.Cells.Count > 0 Then
      For Each acell As UltraGridCell In grdOrdreLinjer.Selected.Cells
        acell.Row.Update()
      Next
    End If
  End Sub

  Private Sub grdOrdreLinjer_BeforeSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles grdOrdreLinjer.BeforeSelectChange
    _inputString = ""
    grdOrdreLinjer_KeyDown_Reset()
  End Sub

  Private Sub grdOrdreLinjer_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grdOrdreLinjer.AfterSelectChange
    If _status > StatusKoder.stsOrdreIkkeSendt AndAlso grdOrdreLinjer.Selected.Rows.Count > 0 AndAlso picGrøn.Tag = "On" Then
      btnGenUdsend.Enabled = True
    Else
      btnGenUdsend.Enabled = False
    End If
  End Sub

  Private Sub grdOrdreLinjer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdOrdreLinjer.KeyDown
    Select Case e.KeyValue
      Case Keys.Tab
        If e.Modifiers = Keys.Shift Or e.Modifiers = Keys.ShiftKey Then
          grdOrdreLinjer.PerformAction(ExitEditMode, False, False)
          grdOrdreLinjer.PerformAction(PrevCellByTab, False, False)
          e.Handled = True
          grdOrdreLinjer.PerformAction(EnterEditMode, False, False)
        Else
          grdOrdreLinjer.PerformAction(ExitEditMode, False, False)
          grdOrdreLinjer.PerformAction(NextCellByTab, False, False)
          e.Handled = True
          grdOrdreLinjer.PerformAction(EnterEditMode, False, False)
        End If
      Case Keys.Up
        If grdOrdreLinjer.ActiveCell IsNot Nothing Then
          grdOrdreLinjer.PerformAction(ExitEditMode, False, False)
          grdOrdreLinjer.PerformAction(AboveCell, False, False)
          e.Handled = True
          grdOrdreLinjer.PerformAction(EnterEditMode, False, False)
        Else
          e.Handled = False
        End If
      Case Keys.Down
        If grdOrdreLinjer.ActiveCell IsNot Nothing Then
          grdOrdreLinjer.PerformAction(ExitEditMode, False, False)
          grdOrdreLinjer.PerformAction(BelowCell, False, False)
          e.Handled = True
          grdOrdreLinjer.PerformAction(EnterEditMode, False, False)
        Else
          e.Handled = False
        End If
      Case Keys.Right
        grdOrdreLinjer.PerformAction(ExitEditMode, False, False)
        grdOrdreLinjer.PerformAction(NextCellByTab, False, False)
        e.Handled = True
        grdOrdreLinjer.PerformAction(EnterEditMode, False, False)
      Case Keys.Left
        grdOrdreLinjer.PerformAction(ExitEditMode, False, False)
        grdOrdreLinjer.PerformAction(PrevCellByTab, False, False)
        e.Handled = True
        grdOrdreLinjer.PerformAction(EnterEditMode, False, False)
      Case Keys.D0 To Keys.D9
        _inputString = _inputString + CStr(e.KeyValue - 48)
        e.Handled = True
        grdOrdreLinjer_KeyDownExtracted()
      Case Keys.NumPad0 To Keys.NumPad9
        _inputString = _inputString + CStr(e.KeyValue - 96)
        e.Handled = True
        grdOrdreLinjer_KeyDownExtracted()
      Case Keys.Decimal, Keys.Oemcomma
        e.Handled = True
        If Not String.IsNullOrEmpty(_inputString) Then
          If _inputString.IndexOf(",") <= 0 Then _inputString = _inputString + ","
        Else
          _inputString = "0,"
        End If
        grdOrdreLinjer_KeyDownExtracted()
      Case Keys.Back
        e.Handled = True
        If Not String.IsNullOrEmpty(_inputString) Then
          If _inputString.Length > 0 Then
            _inputString = _inputString.Remove(_inputString.Length - 1, 1)
            If _inputString.Length = 0 Then _inputString = ""
            grdOrdreLinjer_KeyDownExtracted()
          End If
        End If
      Case Keys.Delete
        If grdOrdreLinjer.Selected.Rows.Count > 0 Then
          e.Handled = True
          grdOrdreLinjer.PerformAction(ExitEditMode, False, False)
          grdOrdreLinjer.PerformAction(DeleteRows, False, False)
        Else
          e.Handled = False
        End If
      Case Keys.A To Keys.Z
        If e.Modifiers = Keys.Shift Or e.Modifiers = Keys.ShiftKey Then
          _inputString = _inputString + UCase(Chr(e.KeyValue))
        Else
          _inputString = _inputString + LCase(Chr(e.KeyValue))
        End If
        e.Handled = True
        grdOrdreLinjer_KeyDownExtracted()
      Case Keys.Space
        _inputString = _inputString + " "
        e.Handled = True
        grdOrdreLinjer_KeyDownExtracted()
      Case Keys.Oemtilde 'æ
        If e.Modifiers = Keys.Shift Or e.Modifiers = Keys.ShiftKey Then
          _inputString = _inputString + "Æ"
        Else
          _inputString = _inputString + "æ"
        End If
        e.Handled = True
        grdOrdreLinjer_KeyDownExtracted()
      Case Keys.OemQuotes  'ø
        If e.Modifiers = Keys.Shift Or e.Modifiers = Keys.ShiftKey Then
          _inputString = _inputString + "Ø"
        Else
          _inputString = _inputString + "ø"
        End If
        e.Handled = True
        grdOrdreLinjer_KeyDownExtracted()
      Case Keys.OemCloseBrackets  'å
        If e.Modifiers = Keys.Shift Or e.Modifiers = Keys.ShiftKey Then
          _inputString = _inputString + "Å"
        Else
          _inputString = _inputString + "å"
        End If
        e.Handled = True
        grdOrdreLinjer_KeyDownExtracted()
      Case Keys.Shift, Keys.ShiftKey, Keys.Return
        e.Handled = True
      Case Else
        _inputString = ""
        e.Handled = True
        grdOrdreLinjer_KeyDown_Reset()
    End Select
  End Sub

  Private Sub cboPlaceringID_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlaceringID.ValueChanged
    _DataValues.PlaceringID = cboPlaceringID.Value
    DataSourceMedieplan.Placering = cboPlaceringID.Value
    BoldItalicLinjer()
    MarkerFarveMin()
  End Sub

  Private Sub txtBrugMaterialeFraUge_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrugMaterialeFraUge.ValueChanged
    Integer.TryParse(txtBrugMaterialeFraUge.Text, _DataValues.BrugMaterialeFraUge)
    If txtBrugMaterialeFraUge.TextLength > 0 Then
      If txtBrugMaterialeFraUge.Text <> "0" Then
        optMaterialeFølgerFra.Value = 0
      End If
    End If
  End Sub

  Private Sub optMaterialeFølgerFra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMaterialeFølgerFra.ValueChanged
    _DataValues.MaterialeFølgerFra = optMaterialeFølgerFra.Value
    If _modul <> "Medieplan" Then
      If optMaterialeFølgerFra.Value > 0 Then
        txtBrugMaterialeFraUge.Text = ""
        txtBrugMaterialeFraUge.Visible = False
        lblMatFraUge.Visible = False
        optSammeMateriale.Visible = True
        If optMaterialeFølgerFra.Value = 1 Then
          txtMaterialeFølgerFraLeverandør.NullText = "- Skriv mat. leverandør (til DLU) -"
          chkMaterialeModtaget.Visible = True
          btnMateriale.Visible = True
        Else
          txtMaterialeFølgerFraLeverandør.NullText = "- Skriv mat. leverandør (til Ugeaviserne) -"
          chkMaterialeModtaget.Visible = False
          btnMateriale.Visible = False
        End If
        txtMaterialeFølgerFraLeverandør.Visible = True
      Else
        txtBrugMaterialeFraUge.Visible = True
        lblMatFraUge.Visible = True
        txtMaterialeFølgerFraLeverandør.Text = Nothing
        txtMaterialeFølgerFraLeverandør.Visible = False
        chkMaterialeModtaget.Visible = False
        btnMateriale.Visible = False
      End If
      checkOmDerMåVæreFællesBureauOrdreNr()
    Else
      If optMaterialeFølgerFra.Value = 1 Then
        txtMaterialeFølgerFraLeverandør.NullText = "- Skriv mat. leverandør (til DLU) -"
      Else
        txtMaterialeFølgerFraLeverandør.NullText = "- Skriv mat. leverandør (til Ugeaviserne) -"
      End If
      txtMaterialeFølgerFraLeverandør.Visible = True
    End If
  End Sub

  Private Sub grdOrdreLinjer_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles grdOrdreLinjer.InitializeRow
    If e.ReInitialize Then Exit Sub
    grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.RefreshSort(True)
    If grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden Then
      _activeCell = e.Row.Cells("New MmPris")
    Else
      _activeCell = e.Row.Cells("New BureauOrdreNr")
    End If
    'If e.Row.Cells("PrisLåst").Value = True Then
    '  e.Row.Cells("PrisLåst").Appearance.BackColor = Color.Red
    'Else
    '  e.Row.Cells("PrisLåst").Appearance.BackColor = Nothing
    'End If
    If e.Row.Cells("MåGiveFarveRabat").Value = False AndAlso _DataValues.TilladFarveSærRabat = False Then
      e.Row.Cells("New FarveRabat").Activation = Activation.Disabled
      e.Row.Cells("New FarveRabat").Appearance.ForeColorDisabled = Color.Gray
    Else
      e.Row.Cells("New FarveRabat").Activation = Activation.AllowEdit
      e.Row.Cells("New FarveRabat").Appearance.ForeColorDisabled = Color.Black
    End If
    If e.Row.Cells("MåGiveMmRabat").Value = False AndAlso _DataValues.TilladMmSærRabat = False Then
      e.Row.Cells("New MmRabat").Activation = Activation.Disabled
      e.Row.Cells("New MmRabat").Appearance.ForeColorDisabled = Color.Gray
    Else
      e.Row.Cells("New MmRabat").Activation = Activation.AllowEdit
      e.Row.Cells("New MmRabat").Appearance.ForeColorDisabled = Color.Black
    End If
    'If Not IsDBNull(e.Row.Cells("FarveMin").Value) AndAlso e.Row.Cells("FarveMin").Value > 0 AndAlso e.Row.Cells("New FarvePris").Value = e.Row.Cells("FarveMin").Value Then
    '  e.Row.Cells("New FarvePris").Appearance.BackColor = Color.Orange
    'End If
    If _status = StatusKoder.stsFærdigTjekketOrdre Then
      If e.Row.Cells("FejlTekst").Value <> "" Then
        e.Row.Activation = Activation.AllowEdit
      Else
        e.Row.Cells("UgeavisID").Appearance.ForeColorDisabled = Color.LightGray
        e.Row.Activation = Activation.ActivateOnly
      End If
    End If
    _activeRow = e.Row
    If _modul <> "Medieplan" Then Timer.Enabled = True 'Gør mmpris aktiv hvis vi ikke er i medieplanmodul
  End Sub

  Private Sub grdOrdreLinjer_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdOrdreLinjer.InitializeLayout
    grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Clear()
    Select Case optGruppering.CheckedIndex
      Case 0
        grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
      Case 1
        grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Add("RabatGruppe", False, True)
      Case 2
        grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Add("SendeGruppe", False, True)
    End Select
    grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Add("UgeavisID", False, False)
  End Sub

  Private Sub btnGem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGem.Click
    Me.Cursor = Cursors.WaitCursor
    If _status >= StatusKoder.stsFærdigTjekketOrdre Then
      _DataValues.RettelserEfterAnnoncekontrol = True
    Else
      _DataValues.RettelserEfterAnnoncekontrol = False
    End If
    grdOrdreLinjer.DisplayLayout.RefreshSummaries()
    If _medieplanNr = 0 AndAlso _modul = "Booking" Then
      frmGemSom.Beskrivelse = _DataValues.Beskrivelse
      frmGemSom.AnnoncørFindes = cboAnnoncørNO_.TextLength > 0
      frmGemSom.BureauFindes = cboBureauNO_.TextLength > 0
      frmGemSom.KontaktpersonNavn = _DataValues.Kontaktperson
      frmGemSom.KontaktpersonTilhører = _DataValues.KontaktpersonTilhører
      frmGemSom.ShowDialog()
      If frmGemSom.DialogResult = Windows.Forms.DialogResult.OK Then
        _DataValues.Beskrivelse = frmGemSom.Beskrivelse
        _DataValues.Kontaktperson = frmGemSom.KontaktpersonNavn
        _DataValues.KontaktpersonTilhører = frmGemSom.KontaktpersonTilhører
        FindNæsteVersionsNr()
        SaveData()
        _status = StatusKoder.stsOrdreIkkeSendt
        DataSourceMedieplan.Status = StatusKoder.stsOrdreIkkeSendt
        _DataValues.Status = StatusKoder.stsOrdreIkkeSendt
        OpdaterStatusIMedieplanTabeller(_status)
        FindNæsteVersionsNr()
        SaveData()
        DataSourceMedieplan.ResetRowState()
        _DataValues.SetOldValuesToNewValues()
        setStatus(_status)
      End If
    ElseIf _modul = "Medieplan" OrElse _modul = "Booking" Then
      If _status = StatusKoder.stsFærdigTjekketOrdre Then 'Fakturarettelser er sket
        FindNæsteVersionsNr()
        If SaveData() Then
          UdsendOrdreRettelser()
          DataSourceMedieplan.ResetRowState()
          _DataValues.SetOldValuesToNewValues()
          resetGridCellFont()
        End If
        If grdOrdreLinjer.Rows.SummaryValues("New Total").Value < 1 Then 'Alle aviser er nulstillede
          _status = StatusKoder.stsAfsluttetOrdre
          DataSourceMedieplan.Status = StatusKoder.stsAfsluttetOrdre
          _DataValues.Status = StatusKoder.stsAfsluttetOrdre
          OpdaterStatusIMedieplanTabeller(StatusKoder.stsAfsluttetOrdre)
          setStatus(StatusKoder.stsAfsluttetOrdre)
        Else
          _status = StatusKoder.stsFaktureretOrdre
          DataSourceMedieplan.Status = StatusKoder.stsFaktureretOrdre
          _DataValues.Status = StatusKoder.stsFaktureretOrdre
          OpdaterStatusIMedieplanTabeller(StatusKoder.stsFaktureretOrdre)
          setStatus(StatusKoder.stsFaktureretOrdre)
        End If
      Else
        frmGemSom.Beskrivelse = _DataValues.Beskrivelse
        frmGemSom.AnnoncørFindes = cboAnnoncørNO_.TextLength > 0
        frmGemSom.BureauFindes = cboBureauNO_.TextLength > 0
        frmGemSom.KontaktpersonNavn = _DataValues.Kontaktperson
        frmGemSom.KontaktpersonTilhører = _DataValues.KontaktpersonTilhører
        frmGemSom.ShowDialog()
        If frmGemSom.DialogResult = Windows.Forms.DialogResult.OK Then
          _DataValues.Beskrivelse = frmGemSom.Beskrivelse
          _DataValues.Kontaktperson = frmGemSom.KontaktpersonNavn
          _DataValues.KontaktpersonTilhører = frmGemSom.KontaktpersonTilhører
          FindNæsteVersionsNr()
          SætMaterialeID()
          If SaveData() Then
            If _status > StatusKoder.stsOrdreIkkeSendt Then UdsendOrdreRettelser()
            DataSourceMedieplan.ResetRowState()
            _DataValues.SetOldValuesToNewValues()
            resetGridCellFont()
          End If
          If _modul = "Booking" AndAlso _status < StatusKoder.stsOrdreIkkeSendt Then
            _status = StatusKoder.stsOrdreIkkeSendt
            DataSourceMedieplan.Status = StatusKoder.stsOrdreIkkeSendt
            _DataValues.Status = StatusKoder.stsOrdreIkkeSendt
            OpdaterStatusIMedieplanTabeller(_status)
            setStatus(_status)
          End If
        End If
      End If
    Else 'Faktura modul
      Dim svar As DialogResult
      Dim huskVersion As Integer = _version
      svar = MessageBox.Show("Skal der oprettes en ny faktura (100% kreditering)?", "Ny Faktura", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

      FindNæsteVersionsNr()
      If SaveData() Then
        Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
        Dim cm As SqlCommand = cn.CreateCommand()
        cn.Open()
        Dim trans As SqlTransaction = cn.BeginTransaction()

        UdsendOrdreRettelser()

        cm.CommandType = CommandType.Text
        cm.Transaction = trans
        Try
          'Opdater TotalPris i de rækker hvor den mangler. Sættes til sidst udregnede pris for avisen
          cm.CommandText = "UPDATE tblMedieplanLinjer SET TotalPris = (SELECT TOP (1) TotalPris FROM tblMedieplanLinjer AS tblMedieplanLinjer_1 WHERE (MedieplanNr = tblMedieplanLinjer.MedieplanNr) AND (TotalPris IS NOT NULL) AND (Version < tblMedieplanLinjer.Version) AND (UgeavisID = tblMedieplanLinjer.UgeavisID) ORDER BY Version DESC) WHERE (TotalPris IS NULL) AND (Version > 11)"
          cm.ExecuteNonQuery()
          If svar = Windows.Forms.DialogResult.Yes Then
            'kredit nota i Navision
            cm.CommandText = String.Format("INSERT INTO tblOrdreNavision (OrdreNr, Version, [Document Type], AnnoncørID, Uge, AntalFarver, OrdreDato, SamletPris, SælgerKode, SikkerhedsGodt, InfoGodt, BureauOrdreNr, Bureau, EnOrdre, Status, FakBem1, FakBem2, FakBem3, MaterialeGodtgørelseTil, [Previous Order No], [Credit Reason], [Previous Version], [Item Description], SammeBureauOrdreNr) SELECT tblMedieplan.MedieplanNr AS OrdreNr, {0} AS Version, 2 AS DokType, tblMedieplan.AnnoncørNo_, tblMedieplan.IndrykningsUge AS Uge, tblMedieplan.AntalFarver, tblMedieplan.OrdreDato, tblMedieplan.SamletPris, NavisionContact.[Salesperson Code], tblMedieplan.SikkerhedsGodt, tblMedieplan.InfoGodt, tblMedieplan.FællesBureauOrdreNr AS BureauOrdreNr, tblMedieplan.BureauNo_ AS Bureau, tblMedieplan.Fakturering AS EnOrdre, 6 AS Status, '' AS FB1, '' AS FB2, '' AS FB3, 1 AS MatTil, tblMedieplan.MedieplanNr AS [Previous Order No], '' AS EXPR1, (SELECT TOP (1) Version FROM tblOrdreNavision WHERE (OrdreNr = tblMedieplan.MedieplanNr) AND ([Document Type] = 0) ORDER BY Version DESC) AS PreVersion, '' AS EXPR3, tblMedieplan.SammeBureauOrdreNr FROM tblMedieplan INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplan.MedieplanNr = {1}) AND (tblMedieplan.Version = {2})", _version, _medieplanNr, huskVersion)
            cm.ExecuteNonQuery()

            cm.CommandText = String.Format("SET DATEFIRST 1 INSERT INTO tblOrdreLinjerNavision (OrdreNr, Version, [Document Type], BladId, Format, Mm, AnvendtPris, SpecialRabat, FarveTillægsPris, FarveTillægsRabat, MaterialeGodt, TotalPris, MaterialePris, [Previous Order No], [Previous Version], BureauOrdreNr, FirstTime) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, {0} AS Version, 2 AS DokType, tblMedieplanLinjer.UgeavisID AS BladId, LTRIM(STR(tblMedieplan.Format1)) + 'x' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplanLinjer.Mm, tblMedieplanLinjer.MmPris AS AnvendtPris, tblMedieplanLinjer.MmRabat AS SpecialRabat, tblMedieplanLinjer.FarvePris AS FarveTillægsPris, tblMedieplanLinjer.FarveRabat AS FarveTillægsRabat, tblMedieplanLinjer.SkalGiveMaterialeGodtgørelse AS MaterialeGodt, tblMedieplanLinjer.TotalPris, tblMedieplanLinjer.MaterialeGodtgørelsePris AS MaterialePris, tblMedieplan.MedieplanNr, (SELECT TOP (1) Version FROM tblOrdreLinjerNavision WHERE (OrdreNr = tblMedieplanLinjer.MedieplanNr) AND (BladId = tblMedieplanLinjer.UgeavisID) ORDER BY Version DESC) AS PreVersion, tblMedieplanLinjer.BureauOrdreNr,(DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4 - DATEPART(dw, DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4) + 1) + tblBladStamdata.UgedagID % 7 - 1 AS IndrykningsDato FROM tblMedieplanLinjer INNER JOIN tblMedieplan ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version INNER JOIN tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID WHERE (tblMedieplan.MedieplanNr = {1}) AND (tblMedieplan.Version = {2})", _version, _medieplanNr, huskVersion)
            cm.ExecuteNonQuery()

            cm.CommandText = String.Format("INSERT INTO tblOrdreGebyrNavision (OrdreNr, Version, [Document Type], Type, BladId, Description, Amount) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, {0} AS Version, 2 AS DokType, 2 AS Type, tblMedieplanLinjer.UgeavisID AS BladId, 'Miljø tillæg' AS Description, tblMedieplanLinjer.MiljøTillæg AS Amount FROM tblMedieplanLinjer WHERE (tblMedieplanLinjer.MiljøTillæg > 0) AND (tblMedieplanLinjer.MedieplanNr = {1}) AND (tblMedieplanLinjer.Version = {2})", _version, _medieplanNr, huskVersion)
            cm.ExecuteNonQuery()

            'Ny faktura i Navision
            cm.CommandText = String.Format("INSERT INTO tblOrdreNavision (OrdreNr, Version, [Document Type], AnnoncørID, Uge, AntalFarver, OrdreDato, SamletPris, SælgerKode, SikkerhedsGodt, InfoGodt, BureauOrdreNr, Bureau, EnOrdre, Status, FakBem1, FakBem2, FakBem3, MaterialeGodtgørelseTil, [Previous Order No], [Credit Reason], [Previous Version], [Item Description], SammeBureauOrdreNr) SELECT tblMedieplan.MedieplanNr AS OrdreNr, tblMedieplan.Version, 0 AS DokType, tblMedieplan.AnnoncørNo_, tblMedieplan.IndrykningsUge AS Uge, tblMedieplan.AntalFarver, tblMedieplan.OrdreDato, tblMedieplan.SamletPris, NavisionContact.[Salesperson Code], tblMedieplan.SikkerhedsGodt, tblMedieplan.InfoGodt, tblMedieplan.FællesBureauOrdreNr AS BureauOrdreNr, tblMedieplan.BureauNo_ AS Bureau, tblMedieplan.Fakturering AS EnOrdre, 6 AS Status, tblMedieplanNr.FakturaBemærkning1 AS FakBem1, tblMedieplanNr.FakturaBemærkning2 AS FakBem2, tblMedieplanNr.FakturaBemærkning3 AS FakBem3, 1 AS MatTil, 0 AS [Previous Order No], '' AS EXPR1, 0 AS PreVersion, '' AS EXPR3, tblMedieplan.SammeBureauOrdreNr FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplanNr.MedieplanNr = {0}) AND (tblMedieplan.Version = {1})", _medieplanNr, _version)
            cm.ExecuteNonQuery()

            'Kopier til Navision ordre linjer
            cm.CommandText = String.Format("SET DATEFIRST 1 INSERT INTO tblOrdreLinjerNavision (OrdreNr, Version, [Document Type], BladId, Format, Mm, AnvendtPris, SpecialRabat, FarveTillægsPris, FarveTillægsRabat, MaterialeGodt, TotalPris, MaterialePris, [Previous Order No], [Previous Version], BureauOrdreNr, FirstTime) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version, 0 AS DokType, tblMedieplanLinjer.UgeavisID AS BladId, LTRIM(STR(tblMedieplan.Format1)) + 'x' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplanLinjer.Mm, tblMedieplanLinjer.MmPris AS AnvendtPris, tblMedieplanLinjer.MmRabat AS SpecialRabat, tblMedieplanLinjer.FarvePris AS FarveTillægsPris, tblMedieplanLinjer.FarveRabat AS FarveTillægsRabat, tblMedieplanLinjer.SkalGiveMaterialeGodtgørelse AS MaterialeGodt, tblMedieplanLinjer.TotalPris, tblMedieplanLinjer.MaterialeGodtgørelsePris AS MaterialePris, 0 AS [Previous Order No] , 0 AS PreVersion, tblMedieplanLinjer.BureauOrdreNr, (DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4 - DATEPART(dw, DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4) + 1) + tblBladStamdata.UgedagID % 7 - 1 AS IndrykningsDato FROM tblMedieplanLinjer INNER JOIN tblMedieplan ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID WHERE (tblMedieplanNr.MedieplanNr = {0}) AND (tblMedieplan.Version = {1})", _medieplanNr, _version)
            cm.ExecuteNonQuery()

            cm.CommandText = String.Format("INSERT INTO tblOrdreGebyrNavision (OrdreNr, Version, [Document Type], Type, BladId, Description, Amount) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version, 0 AS DokType, 2 AS Type, tblMedieplanLinjer.UgeavisID AS BladId, 'Miljø tillæg' AS Description, tblMedieplanLinjer.MiljøTillæg AS Amount FROM tblMedieplanLinjer WHERE (tblMedieplanLinjer.MiljøTillæg > 0) AND (tblMedieplanLinjer.MedieplanNr = {0}) AND (tblMedieplanLinjer.Version = {1})", _medieplanNr, _version)
            cm.ExecuteNonQuery()
          Else ' Del kreditering
            'Kopier til Navision ordre  ''MaterialegodtgørelseTil feltet er her altid tændt!!
            cm.CommandText = String.Format("INSERT INTO tblOrdreNavision (OrdreNr, Version, [Document Type], AnnoncørID, Uge, AntalFarver, OrdreDato, SamletPris, SælgerKode, SikkerhedsGodt, InfoGodt, BureauOrdreNr, Bureau, EnOrdre, Status, FakBem1, FakBem2, FakBem3, MaterialeGodtgørelseTil, [Previous Order No], [Credit Reason], [Previous Version], [Item Description], SammeBureauOrdreNr) SELECT tblMedieplan.MedieplanNr AS OrdreNr, tblMedieplan.Version, 1 AS DokType, tblMedieplan.AnnoncørNo_, tblMedieplan.IndrykningsUge AS Uge, tblMedieplan.AntalFarver, tblMedieplan.OrdreDato, ROUND((SELECT SamletPris AS OldSamletPris FROM tblMedieplan WHERE (MedieplanNr = {0}) AND (Version = {1})) - (SELECT SamletPris AS NewSamletPris FROM tblMedieplan AS temp WHERE (MedieplanNr = {0}) AND (Version = {2})),2) AS DiffPris, NavisionContact.[Salesperson Code], tblMedieplan.SikkerhedsGodt, tblMedieplan.InfoGodt, tblMedieplan.FællesBureauOrdreNr AS BureauOrdreNr, tblMedieplan.BureauNo_ AS Bureau, tblMedieplan.Fakturering AS EnOrdre, 6 AS Status, tblMedieplanNr.FakturaBemærkning1 AS FakBem1, tblMedieplanNr.FakturaBemærkning2 AS FakBem2, tblMedieplanNr.FakturaBemærkning3 AS FakBem3, 1 AS MatTil, tblMedieplan.MedieplanNr AS [Previous Order No], '' AS EXPR1, (SELECT TOP (1) Version FROM tblOrdreNavision WHERE (OrdreNr = tblMedieplan.MedieplanNr) AND ([Document Type] = 0) ORDER BY Version DESC) AS PreVersion, '' AS EXPR3, tblMedieplan.SammeBureauOrdreNr FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplanNr.MedieplanNr = {0}) AND (tblMedieplan.Version = {2})", _medieplanNr, _version - 1, _version)
            cm.ExecuteNonQuery()
            'Kopier til Navision ordre linjer
            Dim udsendteGrupper As New List(Of String)
            Dim fundetGruppe As Boolean = False
            Dim findGruppe As String

            For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
              If arow.Cells("RowState").Value = "Changed" Then
                If arow.Cells("FakturaGruppe").Value = "" Then
                  cm.CommandText = String.Format("SET DATEFIRST 1 INSERT INTO tblOrdreLinjerNavision (OrdreNr, Version, [Document Type], BladId, Format, Mm, AnvendtPris, SpecialRabat, FarveTillægsPris, FarveTillægsRabat, MaterialeGodt, TotalPris, MaterialePris, [Previous Order No], [Previous Version], BureauOrdreNr, FirstTime) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version, 1 AS DokType, tblMedieplanLinjer.UgeavisID AS BladId, LTRIM(STR(tblMedieplan.Format1)) + 'x' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplanLinjer.Mm, tblMedieplanLinjer.MmPris AS AnvendtPris, tblMedieplanLinjer.MmRabat AS SpecialRabat, tblMedieplanLinjer.FarvePris AS FarveTillægsPris, tblMedieplanLinjer.FarveRabat AS FarveTillægsRabat, tblMedieplanLinjer.SkalGiveMaterialeGodtgørelse AS MaterialeGodt, tblMedieplanLinjer.TotalPris, tblMedieplanLinjer.MaterialeGodtgørelsePris AS MaterialePris, tblMedieplan.MedieplanNr, (SELECT TOP (1) Version FROM tblOrdreLinjerNavision WHERE (OrdreNr = tblMedieplanLinjer.MedieplanNr) AND (BladId = tblMedieplanLinjer.UgeavisID) ORDER BY Version DESC) AS PreVersion, tblMedieplanLinjer.BureauOrdreNr, (DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4 - DATEPART(dw, DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4) + 1) + tblBladStamdata.UgedagID % 7 - 1 AS IndrykningsDato FROM tblMedieplanLinjer INNER JOIN tblMedieplan ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID WHERE (tblMedieplanNr.MedieplanNr = {0}) AND (tblMedieplan.Version = {1}) AND (tblMedieplanLinjer.UgeavisID = {2})", _medieplanNr, _version, arow.Cells("UgeavisID").Value)
                  cm.ExecuteNonQuery()
                Else
                  findGruppe = arow.Cells("FakturaGruppe").Value
                  fundetGruppe = False
                  For Each gruppe As String In udsendteGrupper
                    If gruppe = findGruppe Then
                      fundetGruppe = True
                    End If
                  Next
                  If Not fundetGruppe Then
                    udsendteGrupper.Add(findGruppe)
                    For Each brow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
                      If brow.Cells("FakturaGruppe").Value = findGruppe Then
                        cm.CommandText = String.Format("SET DATEFIRST 1 INSERT INTO tblOrdreLinjerNavision (OrdreNr, Version, [Document Type], BladId, Format, Mm, AnvendtPris, SpecialRabat, FarveTillægsPris, FarveTillægsRabat, MaterialeGodt, TotalPris, MaterialePris, [Previous Order No], [Previous Version],  BureauOrdreNr, FirstTime) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version, 1 AS DokType, tblMedieplanLinjer.UgeavisID AS BladId, LTRIM(STR(tblMedieplan.Format1)) + 'x' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplanLinjer.Mm, tblMedieplanLinjer.MmPris AS AnvendtPris, tblMedieplanLinjer.MmRabat AS SpecialRabat, tblMedieplanLinjer.FarvePris AS FarveTillægsPris, tblMedieplanLinjer.FarveRabat AS FarveTillægsRabat, tblMedieplanLinjer.SkalGiveMaterialeGodtgørelse AS MaterialeGodt, tblMedieplanLinjer.TotalPris, tblMedieplanLinjer.MaterialeGodtgørelsePris AS MaterialePris, tblMedieplan.MedieplanNr, (SELECT TOP (1) Version FROM tblOrdreLinjerNavision WHERE (OrdreNr = tblMedieplanLinjer.MedieplanNr) AND (BladId = tblMedieplanLinjer.UgeavisID) ORDER BY Version DESC) AS PreVersion, tblMedieplanLinjer.BureauOrdreNr, (DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4 - DATEPART(dw, DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4) + 1) + tblBladStamdata.UgedagID % 7 - 1 AS IndrykningsDato FROM tblMedieplanLinjer INNER JOIN tblMedieplan ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID WHERE (tblMedieplanNr.MedieplanNr = {0}) AND (tblMedieplan.Version = {1}) AND (tblMedieplanLinjer.UgeavisID = {2})", _medieplanNr, _version, brow.Cells("UgeavisID").Value)
                        cm.ExecuteNonQuery()
                      End If
                    Next
                  End If
                End If
              End If
            Next
          End If
          'Opdater Navision ordre dato så kl. sættes til 00:00:00, Advertiser med annoncørnavn og Placement med placerings betegnelse
          cm.CommandText = String.Format("UPDATE tblOrdreNavision SET OrdreDato = CONVERT(DATETIME, CONVERT(NVARCHAR, tblOrdreNavision.OrdreDato, 105) + ' 00:00:00', 105), Advertiser = NavisionContact.Name, Placement = tblPlacering.Betegnelse FROM tblOrdreNavision INNER JOIN tblMedieplan ON tblOrdreNavision.Version = tblMedieplan.Version AND tblOrdreNavision.OrdreNr = tblMedieplan.MedieplanNr INNER JOIN tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblOrdreNavision.OrdreNr = {0})", _medieplanNr)
          cm.ExecuteNonQuery()
          trans.Commit()
          MessageBox.Show("Ordren er sendt til Navision. Den skal nu importeres i Navision", "Overførsel slut", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
          trans.Rollback()
          MessageBox.Show("Der opstod en fejl ved overførsel til Navision." & vbCrLf & "Fejltekst:" & ex.Message, "Overførsel fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          trans.Dispose()
          cn.Close()
          cm.Dispose()
          cn.Dispose()
        End Try
        DataSourceMedieplan.ResetRowState()
        _DataValues.SetOldValuesToNewValues()
        resetGridCellFont()
      End If
    End If
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub SætMaterialeID()
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If optSammeMateriale.Value = True Then
        If optMaterialeFølgerFra.Value = 1 Then
          arow.Cells("MaterialeNr").Value = _medieplanNr.ToString
        ElseIf optMaterialeFølgerFra.Value = 2 Then
          arow.Cells("MaterialeNr").Value = arow.Cells("New BureauOrdreNr").Value
        Else
          arow.Cells("MaterialeNr").Value = ""
        End If
      Else
        If optMaterialeFølgerFra.Value = 1 Then
          arow.Cells("MaterialeNr").Value = _medieplanNr.ToString & arow.Cells("UgeavisID").Value.ToString
        ElseIf optMaterialeFølgerFra.Value = 2 Then
          arow.Cells("MaterialeNr").Value = arow.Cells("New BureauOrdreNr").Value
        Else
          arow.Cells("MaterialeNr").Value = ""
        End If
      End If
      arow.Update()
    Next
  End Sub

  Public Sub LåsDataFelter()
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      arow.Cells("ManueltÆndret").Value = True
    Next
  End Sub

  Private Function SaveData() As Boolean
    Me.Cursor = Cursors.WaitCursor
    _DataValues.MedieplanNr = _medieplanNr
    _DataValues.Version = _version
    _DataValues.SamletPris = grdOrdreLinjer.Rows.SummaryValues("New Total").Value
    _DataValues.Status = _status
    SætMaterialeID()
    DataSourceMedieplan.MedieplanNr = _medieplanNr
    DataSourceMedieplan.Version = _version
    If _DataValues.SaveData Then
      If DataSourceMedieplan.SaveData() Then
        lblMedieplanNr.Text = getMedieplanString(_medieplanNr, _version)
        picGul.Tag = "Off"
        picGul.Image = My.Resources.StatusLedYellowOff
        picGrøn.Tag = "On"
        picGrøn.Image = My.Resources.StatusLedGreenOn
        setStatus(_status)
        resetGridCellFont()
        timer365.Enabled = True
        OpdaterMedieplanNrTabel()
        Me.Text = getMedieplanString(_medieplanNr, _version)
        Return True
      Else
        Me.Cursor = Cursors.Default
        MsgBox("Fejl ved save af plan Linjer")
        Return False
      End If
    Else
      Me.Cursor = Cursors.Default
      MsgBox("Fejl ved save af plan Hoved")
      Return False
    End If
  End Function

  Private Sub FindNæsteVersionsNr()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    cn.Open()
    If _medieplanNr = 0 Then
      'Opret ny medieplan med næste frie medieplan nr og version = 1
      cm.CommandText = "OpretNyMediePlan"
      cm.CommandType = CommandType.StoredProcedure
      _medieplanNr = cm.ExecuteScalar
      _version = 1
      _status = StatusKoder.stsMedieplan
      DataSourceMedieplan.Status = StatusKoder.stsMedieplan
    Else
      'Find næste frie versions nr. 
      cm.CommandType = CommandType.Text
      cm.CommandText = "SELECT MAX(Version) + 1 AS NæsteFriVersionNr FROM tblMedieplan WHERE MedieplanNr = " & _medieplanNr
      If _modul = "Medieplan" Then
        _version = cm.ExecuteScalar
      ElseIf _modul = "Booking" Then
        If _version < 10 Then
          _version = (_version * 10) + 1
          '          LåsDataFelter()
        Else
          _version = cm.ExecuteScalar
        End If
      Else '_ modul = Fakturering
        If _version < 100 Then
          _version = (_version * 10) + 1
        Else
          _version = cm.ExecuteScalar
        End If
      End If
      If _version > 1 Then
        Dim Tekst As New StringBuilder(1000)

        Tekst.Append(_DataValues.GetChangeTekst(False))

        For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
          If arow.Cells("RowState").Value = "Added" Then
            Tekst.Append(Trim(arow.Cells("UgeavisID").Text) + " tilføjet. " + vbCrLf)
          ElseIf arow.Cells("RowState").Value = "Deleted" Then
            Tekst.Append(Trim(arow.Cells("UgeavisID").Text) + " fjernet. " + vbCrLf)
          ElseIf arow.Cells("RowState").Value <> "UnChanged" AndAlso bladRettelse(arow) <> "" Then
            Tekst.Append(Trim(arow.Cells("UgeavisID").Text) + ": " + bladRettelse(arow) + vbCrLf)
          End If
        Next
        cm.CommandType = CommandType.Text
        cm.CommandText = "DELETE FROM tblMedieplanÆndringer WHERE (MedieplanNr = " & _medieplanNr & ") AND (Version = " & _version & ")"
        cm.ExecuteNonQuery()
        cm.CommandText = "INSERT INTO tblMedieplanÆndringer (MedieplanNr, Version, ÆndringsTekst) VALUES (" & _medieplanNr & "," & _version & ",'" & Tekst.ToString & "')"
        cm.ExecuteNonQuery()
      End If
    End If
    cn.Close()
    cm.Dispose()
    cn.Dispose()
  End Sub

  Private Sub saveXmlFile()
    Const kortSti = "Z:\Kort\"
    Dim xmlString As String
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader
    Dim ugeavisID As Integer = 0
    Dim sidsteUgeavisId As Integer = 0
    Dim first As Boolean = True
    Dim coverPct As Integer
    Dim whereString As String = ""

    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If arow.Cells("RowState").Value <> "Deleted" Then
        If Not first Then
          whereString = whereString & " OR "
        End If
        first = False
        whereString = whereString & "(tblBladDækning.BladID = " & arow.Cells("UgeavisID").Value.ToString & ")"
      End If
    Next
    first = True
    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT TOP (100) PERCENT tblBladDækning.BladID, tblBladDækning.PostNr, tblPostNr.PostBy, tblBladDækning.DækningsGrad, tblBladStamdata.Navn FROM tblBladDækning INNER JOIN tblPostNr ON tblBladDækning.PostNr = tblPostNr.PostNr INNER JOIN tblBladStamdata ON tblBladDækning.BladID = tblBladStamdata.BladID WHERE " & whereString & " ORDER BY tblBladDækning.BladID"
    Directory.CreateDirectory(kortSti & _medieplanNr.ToString)
    xmlString = "<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>" & vbCrLf & "<root>" & vbCrLf
    cn.Open()
    dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
    While dr.Read
      ugeavisID = dr(0)
      If ugeavisID <> sidsteUgeavisId Then
        If Not first Then
          xmlString = xmlString + "</zips>" & vbCrLf & "</paper>" & vbCrLf
        End If
        '  xmlString = xmlString + "<paper>" & vbCrLf & "<id>" & ugeavisID.ToString & "</id>" & vbCrLf & "<zips>" & vbCrLf
        xmlString = xmlString + "<paper>" & vbCrLf & "<id>" & ugeavisID.ToString & "</id>" & vbCrLf & "<paperName>" & dr(4) & "</paperName>" & vbCrLf & "<zips>" & vbCrLf
        sidsteUgeavisId = ugeavisID
        first = False
      End If
      xmlString = xmlString + "<zipCity>" & vbCrLf & "<name>" & dr(2).ToString & "</name>" & vbCrLf
      xmlString = xmlString + "<zip>" & dr(1).ToString & "</zip>" & vbCrLf
      coverPct = dr(3)
      If coverPct > 100 Then coverPct = 100
      xmlString = xmlString + "<cover_pct>" & coverPct.ToString & "</cover_pct>" & vbCrLf & "</zipCity>" & vbCrLf
    End While
    xmlString = xmlString + "</zips>" & vbCrLf & "</paper>" & vbCrLf & "</root>"
    File.WriteAllText(kortSti & _medieplanNr.ToString & "\" & _version.ToString & ".xml", xmlString)
  End Sub

  Private Sub OpdaterMedieplanNrTabel()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    cm.CommandType = CommandType.Text
    cm.CommandText = String.Format("UPDATE tblMedieplanNr SET AktivVersion = {0} , Status = " & _status & " , SupportBilagVist = {1} , BrugtGruppeVersion = {2} , Kommentar = '" & _Kommentar.Replace("'", "''") & "' WHERE (MedieplanNr = {3})", _version, _supportBilagVist, _brugtGruppeVersion, _medieplanNr)
    cn.Open()
    cm.ExecuteNonQuery()
    cm.CommandText = "UPDATE tblMedieplanNr SET AnvendtMiljøTillæg = @MiljøTillæg WHERE MedieplanNr = @PlanNr"
    cm.Parameters.AddWithValue("@MiljøTillæg", _anvendtMiljøTillæg)
    cm.Parameters.AddWithValue("@PlanNr", _medieplanNr)

    'cm.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MiljøTillæg", SqlDbType.SmallMoney, "AnvendtMiljøTillæg"))
    'cm.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PlanNr", SqlDbType.Int, "MedieplanNr"))
    'cm.Parameters("@MiljøTillæg").Value = _anvendtMiljøTillæg
    'cm.Parameters("@PlanNr").Value = _medieplanNr

    cm.ExecuteNonQuery()
    cn.Close()
    cm.Dispose()
    cn.Dispose()
  End Sub

  Private Sub cboDPKulørID_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDPKulørID.ValueChanged
    _DataValues.DPKulørID = cboDPKulørID.Value
  End Sub

  Private Sub numIndrykningsUge_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numIndrykningsUge.ValueChanged
    Try
      _DataValues.IndrykningsUge = numIndrykningsUge.Value
      DataSourceMedieplan.Uge = numIndrykningsUge.Value
    Catch
    End Try
    MarkerFarveMin()
  End Sub

  Private Sub txtBemærkningTilAnnoncør_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBemærkningTilAnnoncør.TextChanged
    _DataValues.BemærkningTilAnnoncør = txtBemærkningTilAnnoncør.Text
  End Sub

  Private Sub txtBeskrivelse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeskrivelse.TextChanged
    _DataValues.Beskrivelse = txtBeskrivelse.Text
  End Sub

  Private Sub optFakturering_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFakturering.ValueChanged
    _DataValues.Fakturering = optFakturering.Value
  End Sub

    'Private Sub txtRekvisitionsNr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRekvisitionsNr.TextChanged
    '  Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    '  Dim cm As SqlCommand = cn.CreateCommand()

    '  _DataValues.RekvisitionsNr = txtRekvisitionsNr.Text

    '  If _medieplanNr > 0 AndAlso _version > 0 Then
    '    Try
    '      cm.CommandType = CommandType.Text
    '      cm.CommandText = "UPDATE tblMedieplan SET RekvisitionsNr = '" & txtRekvisitionsNr.Text & "" & "' WHERE (MedieplanNr = " & _medieplanNr & " AND Version = " & _version & ")"
    '      cn.Open()
    '      cm.ExecuteNonQuery()
    '      If txtRekvisitionsNr.TextLength > 0 Then
    '        cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBemærkning3 = 'Rekvisitions nr.: " & txtRekvisitionsNr.Text.Replace("'", "''") & "' WHERE (MedieplanNr = " & _medieplanNr & ")"
    '      Else
    '        cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBemærkning3 = '' WHERE (MedieplanNr = " & _medieplanNr & ")"
    '      End If
    '      cm.ExecuteNonQuery()
    '      cn.Close()
    '    Catch ex As Exception
    '      MessageBox.Show("Der opstod en fejl da feltet skulle opdateres.", "SQL fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '      cm.Dispose()
    '      cn.Dispose()
    '    End Try
    '  End If
    'End Sub

  Private Sub optBilagsBladeTil_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBilagsBladeTil.ValueChanged
    If Not _IsLoading Then
      If optBilagsBladeTil.Value = 3 Then
        frmBilagsbladeTil.Navn = _DataValues.BilagsBladeTilNavn
        frmBilagsbladeTil.Adresse = _DataValues.BilagsBladeTilAdresse
        frmBilagsbladeTil.PostNr = _DataValues.BilagsBladeTilPostNr
        frmBilagsbladeTil.ShowDialog()
        If frmBilagsbladeTil.DialogResult = Windows.Forms.DialogResult.OK Then
          _DataValues.BilagsBladeTilNavn = frmBilagsbladeTil.Navn
          _DataValues.BilagsBladeTilAdresse = frmBilagsbladeTil.Adresse
          _DataValues.BilagsBladeTilPostNr = frmBilagsbladeTil.PostNr
        Else
          _DataValues.BilagsBladeTilNavn = ""
          _DataValues.BilagsBladeTilAdresse = ""
          _DataValues.BilagsBladeTilPostNr = 0
          optBilagsBladeTil.CheckedIndex = -1
        End If
      End If
    End If
    If optBilagsBladeTil.Value > 0 Then
      _DataValues.BilagsBladeTil = optBilagsBladeTil.Value
      _optBilagsBladeTilValueChanged = True
    Else
      _DataValues.BilagsBladeTil = -1
    End If
  End Sub

  Private Sub txtBilagsBladeAtt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBilagsBladeAtt.TextChanged
    _DataValues.BilagsBladeAtt = txtBilagsBladeAtt.Text
  End Sub

  Private Sub txtMaterialeFølgerFraLeverandør_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaterialeFølgerFraLeverandør.ValueChanged
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    _DataValues.MaterialeFølgerFraLeverandør = txtMaterialeFølgerFraLeverandør.Text
    If _DataValues.MaterialeFølgerFra = 1 Then
      If _medieplanNr > 0 AndAlso _version > 0 Then
        Try
          cm.CommandType = CommandType.Text
          cm.CommandText = "UPDATE tblMedieplan SET MaterialeFølgerFraLeverandør = '" & txtMaterialeFølgerFraLeverandør.Text + "" & "' WHERE (MedieplanNr = " & _medieplanNr & " AND Version = " & _version & ")"
          cn.Open()
          cm.ExecuteNonQuery()
          cn.Close()
        Catch ex As Exception
          MessageBox.Show("Der opstod en fejl da feltet skulle opdateres.", "SQL fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          cm.Dispose()
          cn.Dispose()
        End Try
      End If
    End If
  End Sub

  Private Sub optSammeMateriale_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSammeMateriale.ValueChanged
    _DataValues.SammeMateriale = optSammeMateriale.Value
    DataSourceMedieplan.SammeMateriale = optSammeMateriale.Value
    'If _DataValues.IndrykningsÅr > 2010 Then
    '  If optSammeMateriale.Value Then
    '    chkKunForhandlerBundForskellig.Visible = False
    '  Else
    '    chkKunForhandlerBundForskellig.Visible = True
    '  End If
    'End If
    checkOmDerMåVæreFællesBureauOrdreNr()
  End Sub

  Private Sub optGruppering_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGruppering.ValueChanged
    Try
      grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Clear()
      Select Case optGruppering.CheckedIndex
        Case 0
          grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
        Case 1
          grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Add("RabatGruppe", False, True)
        Case 2
          grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Add("SendeGruppe", False, True)
      End Select
      grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.Add("UgeavisID", False, False)
    Catch
    End Try
  End Sub

  Private Sub resetGridCellFont()
    grdOrdreLinjer.DisplayLayout.Appearance.ResetFontData()
    grdOrdreLinjer.DisplayLayout.Appearance.ResetBackColor()
    grdOrdreLinjer.DisplayLayout.Appearance.ResetForeColor()
    grdOrdreLinjer.DisplayLayout.Appearance.ResetForeColorDisabled()
  End Sub

  Private Sub checkOmDerMåVæreFællesBureauOrdreNr()
    If optSammeMateriale.Value = False AndAlso optMaterialeFølgerFra.Value = 2 Then
      txtFællesBureauOrdreNr.Text = ""
      txtFællesBureauOrdreNr.Visible = False
    End If
  End Sub

  Private Sub txtFællesBureauOrdreNr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFællesBureauOrdreNr.ValueChanged
    ÅbneLukkeBureauOrdreNr()
  End Sub

  Private Sub ÅbneLukkeBureauOrdreNr()
    If txtFællesBureauOrdreNr.TextLength > 0 Then
      _DataValues.SammeBureauOrdreNr = True
      DataSourceMedieplan.SammeBureauOrdreNr = True
      DataSourceMedieplan.FællesBureauOrdreNr = txtFællesBureauOrdreNr.Text
      _DataValues.FællesBureauOrdreNr = txtFællesBureauOrdreNr.Text
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden = True
    Else
      _DataValues.SammeBureauOrdreNr = False
      DataSourceMedieplan.SammeBureauOrdreNr = False
      DataSourceMedieplan.FællesBureauOrdreNr = Nothing
      _DataValues.FællesBureauOrdreNr = Nothing
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden = False
    End If
  End Sub

  Private Sub NulstilSelectedText(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.ValidationErrorEventArgs) Handles cboAnnoncørNO_.ItemNotInList, cboBureauNO_.ItemNotInList, cboDPKulørID.ItemNotInList
    If e.InvalidText.Length = 0 Then
      e.RetainFocus = False
      sender.value = Nothing
    Else
      If e.LastValidValue IsNot Nothing Then
        e.RetainFocus = True
        e.Beep = True
        MessageBox.Show(e.InvalidText & " findes ikke i listen og kan derfor ikke vælges.", "Værdi ikke i liste", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Else
        e.RetainFocus = False
      End If
      sender.text = e.LastValidValue
    End If
  End Sub

  Private Sub cboBureauNO__ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBureauNO_.ValueChanged
    If cboBureauNO_.TextLength > 0 AndAlso cboBureauNO_.IsItemInList(cboBureauNO_.Text) Then
      If _modul = "Booking" Then
        If _DataValues.SammeBureauOrdreNr Then
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden = True
        Else
          grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden = False
        End If
        txtBemærkningTilAnnoncør.Size = New System.Drawing.Size(250, 21)
        lblFællesBureauOrdreNr.Visible = True
        txtFællesBureauOrdreNr.Visible = True
      Else
        grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden = True
        lblFællesBureauOrdreNr.Visible = False
        txtFællesBureauOrdreNr.Visible = False
        txtBemærkningTilAnnoncør.Size = New System.Drawing.Size(280, 55)
      End If
      _DataValues.BureauNO_ = cboBureauNO_.Value
      DataSourceMedieplan.BureauValgt = True
    Else
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden = True
      lblFællesBureauOrdreNr.Visible = False
      txtFællesBureauOrdreNr.Visible = False
      txtBemærkningTilAnnoncør.Size = New System.Drawing.Size(280, 55)
      _DataValues.BureauNO_ = Nothing
      DataSourceMedieplan.BureauValgt = False
    End If
  End Sub

  Private Sub cboAnnoncørNO__ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAnnoncørNO_.ValueChanged
    If cboAnnoncørNO_.IsItemInList(cboAnnoncørNO_.Text) Then
      _DataValues.AnnoncørNO_ = cboAnnoncørNO_.Value
      If _DataValues.AnnoncørPostNr.Length > 0 Then
        DataSourceMedieplan.AnnoncørPostNr = _DataValues.AnnoncørPostNr
      Else
        DataSourceMedieplan.AnnoncørPostNr = Nothing
      End If
    Else
      _DataValues.AnnoncørNO_ = Nothing
      DataSourceMedieplan.AnnoncørPostNr = Nothing
    End If
  End Sub

  Private Sub btnLuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Dim svar As MsgBoxResult
    If picGrøn.Tag = "Off" Then
      svar = MsgBox("Du har ændringer der ikke er gemt!" & vbCrLf & "Klik på 'OK' for at lukke uden at gemme.", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal, "Annuller ændringer.")
      If svar = MsgBoxResult.Ok Then Me.Close()
    Else
      Me.Close()
    End If
  End Sub

  Private Sub picGrøn_ImageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles picGrøn.ImageChanged
    If picGrøn.Tag = "On" Then
      btnKopierTilNy.Enabled = True
      btnLuk.Enabled = True
      btnUdskriv.Enabled = True
      btnMateriale.Enabled = True

      If _IsAktiv Then btnTilBlade.Enabled = True
      btnTilExcel.Enabled = True
      If _modul <> "Medieplan" Then
        If _version >= _aktivVersion Then
          btnTilBooking.Enabled = True
        Else
          btnTilBooking.Enabled = False
        End If
      Else
        btnTilBooking.Enabled = True
      End If
    Else
      btnLuk.Enabled = False
      btnMateriale.Enabled = False
      btnUdskriv.Enabled = False
      btnTilBooking.Enabled = False
      btnTilBlade.Enabled = False
      btnGenUdsend.Enabled = False
      btnTilExcel.Enabled = False

    End If
  End Sub

  Private Sub picGul_ImageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles picGul.ImageChanged
    If picGul.Tag = "Off" Then
      btnGem.Enabled = False
    Else
      If picRød.Tag = "On" Then
        btnGem.Enabled = False
      Else
        btnGem.Enabled = True
      End If
    End If
  End Sub

  Private Sub btnGem_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGem.EnabledChanged
    If picRød.Tag = "On" Then
      btnGem.Enabled = False
    End If
  End Sub

  Private Sub DataSourceMedieplan_AnsvarIndtastet() Handles DataSourceMedieplan.AnsvarIndtastet
    _DataValues.checkValid()
  End Sub

  Private Sub DataSourceMedieplan_BureauOrdreNrIndtastet() Handles DataSourceMedieplan.BureauOrdreNrIndtastet
    Dim fundetEtBureauOrdreNr As Boolean = False

    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If arow.Cells("RowState").Value <> "Deleted" Then
        If arow.Cells("New BureauOrdreNr").Value <> "" Then
          fundetEtBureauOrdreNr = True
          Exit For
        End If
      End If
    Next
    If fundetEtBureauOrdreNr Then
      txtFællesBureauOrdreNr.Text = ""
      _DataValues.SammeBureauOrdreNr = False
      DataSourceMedieplan.SammeBureauOrdreNr = False
      _DataValues.FællesBureauOrdreNr = Nothing
      txtFællesBureauOrdreNr.Visible = False
      lblFællesBureauOrdreNr.Visible = False
    Else
      If optSammeMateriale.Value = False AndAlso optMaterialeFølgerFra.Value = 2 Then
        txtFællesBureauOrdreNr.Text = ""
        _DataValues.SammeBureauOrdreNr = False
        DataSourceMedieplan.SammeBureauOrdreNr = False
        _DataValues.FællesBureauOrdreNr = Nothing
        txtFællesBureauOrdreNr.Visible = False
        lblFællesBureauOrdreNr.Visible = False
      Else
        _DataValues.SammeBureauOrdreNr = True
        DataSourceMedieplan.SammeBureauOrdreNr = True
        txtFællesBureauOrdreNr.Visible = True
        lblFællesBureauOrdreNr.Visible = True
      End If
    End If
  End Sub

  Private Sub DataSourceMedieplan_CellDataUpdated(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinDataSource.CellDataUpdatedEventArgs) Handles DataSourceMedieplan.CellDataUpdated
    If e.Column.Key.StartsWith("New") AndAlso Not IsDBNull(e.NewValue) Then
      If e.NewValue <> e.Row.GetCellValue(e.Column.Key.Replace("New", "Old")) Then
        e.Row.SetCellValue(e.Column.Key, e.NewValue)
      End If
    End If
  End Sub

  Private Sub _DataValues_AndenBetalerFundet(ByVal ID As String) Handles _DataValues.AndenBetalerFundet
    cboBureauNO_.Value = ID
  End Sub

  Private Sub _DataValues_DårligBetalerFundet(ByVal betalingsBetingelse As String) Handles _DataValues.DårligBetalerFundet
    Select Case betalingsBetingelse
      Case "Spærret"
        lblAnnoncør.Appearance.BackColor = Color.Red
      Case "Forud"
        lblAnnoncør.Appearance.BackColor = Color.Yellow
      Case Else
        lblAnnoncør.Appearance.BackColor = Nothing
    End Select
  End Sub

  Private Sub Medieplan_HasChanges(ByVal changes As Boolean) Handles DataSourceMedieplan.HasChanges, _DataValues.HasChanges
    If DataSourceMedieplan.HasChanged OrElse _DataValues.HasChanged Then
      '   If changes Then
      picGul.Tag = "On"
      picGul.Image = My.Resources.StatusLedYellowOn
      picGrøn.Tag = "Off"
      picGrøn.Image = My.Resources.StatusLedGreenOff
      If _DataValues.IsValid AndAlso DataSourceMedieplan.IsValid Then
        picRød.Tag = "Off"
        picRød.Image = My.Resources.StatusLedRedOff
      Else
        picRød.Tag = "On"
        picRød.Image = My.Resources.StatusLedRedOn
        picGrøn.Tag = "Off"
        picGrøn.Image = My.Resources.StatusLedGreenOff
      End If
    Else
      picGul.Tag = "Off"
      picGul.Image = My.Resources.StatusLedYellowOff
      If picRød.Tag = "Off" Then
        picGrøn.Tag = "On"
        picGrøn.Image = My.Resources.StatusLedGreenOn
      End If
    End If
  End Sub

  Private Sub picRød_ImageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRød.ImageChanged
    If picRød.Tag = "On" Then
      btnGem.Enabled = False
    Else
      If picGul.Tag = "On" Then
        btnGem.Enabled = True
      Else
        btnGem.Enabled = False
      End If
    End If
  End Sub

  Private Sub picRød_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRød.MouseHover
    Dim toolTipInfo As UltraToolTipInfo = ToolTipManager.GetUltraToolTip(picRød)

    If _DataValues.IsValid AndAlso DataSourceMedieplan.IsValid Then 'Me.DataSourceMedieplan.Rows.Count > 0 Then
      toolTipInfo.Enabled = DefaultableBoolean.False
      ToolTipManager.SetUltraToolTip(picRød, toolTipInfo)
    Else
      toolTipInfo.Enabled = DefaultableBoolean.True
      toolTipInfo.ToolTipImage = ToolTipImage.Error
      toolTipInfo.ToolTipTitle = "Mangler på medieplan:"
      If DataSourceMedieplan.Rows.Count < 1 Then
        toolTipInfo.ToolTipTextFormatted = "1. Der er ikke valgt mindst én <b>ugeavis</b> til planen.<br/>" & _DataValues.NotValidText(1)
      Else
        If _status = StatusKoder.stsFærdigTjekketOrdre AndAlso Not DataSourceMedieplan.IsValid Then
          toolTipInfo.ToolTipTextFormatted = "1. Der mangler <b>Ansvar</b> på mindst én ugeavis.<br/>"
        Else
          If Not _DataValues.SammeBureauOrdreNr AndAlso Not DataSourceMedieplan.IsValid Then
            toolTipInfo.ToolTipTextFormatted = "1. Der mangler <b>Bureauordrenr.</b> på mindst én ugeavis.<br/>" & _DataValues.NotValidText(1)
          Else
            toolTipInfo.ToolTipTextFormatted = _DataValues.NotValidText(0)
          End If
        End If
      End If
      toolTipInfo.ToolTipTextStyle = ToolTipTextStyle.Formatted
      ToolTipManager.SetUltraToolTip(picRød, toolTipInfo)
      ToolTipManager.ShowToolTip(picRød)
    End If
  End Sub

  Private Sub _DataValues_Validated(ByVal valid As Boolean) Handles _DataValues.Validated
    If valid AndAlso DataSourceMedieplan.IsValid Then ' Me.DataSourceMedieplan.Rows.Count > 0 Then
      picRød.Tag = "Off"
      picRød.Image = My.Resources.StatusLedRedOff
    Else
      picRød.Tag = "On"
      picRød.Image = My.Resources.StatusLedRedOn
      picGrøn.Tag = "Off"
      picGrøn.Image = My.Resources.StatusLedGreenOff
    End If
  End Sub

  Private Sub btnUdskriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUdskriv.Click
    Dim TillægPåRapport As Boolean

    If chkMiljøTillægOpkræves.Visible = True AndAlso chkMiljøTillægOpkræves.Checked = True Then
      TillægPåRapport = True
    Else
      TillægPåRapport = False
    End If

    'Dim nyRapport As New frmRapportVisning(_medieplanNr, _version, _status, numIndrykningsÅr.Value, chkWebTillægOpkræves.Checked, TillægPåRapport)
    Dim nyRapport As New frmRapportVisning(_medieplanNr, _version, _status, numIndrykningsÅr.Value, TillægPåRapport)

    nyRapport.MdiParent = My.Forms.frmMain
    If cboBureauNO_.TextLength > 0 Then
      If cboAnnoncørNO_.TextLength > 0 Then
        nyRapport.Beskrivelse = cboBureauNO_.Text & " - " & cboAnnoncørNO_.Text
      Else
        nyRapport.Beskrivelse = cboBureauNO_.Text
      End If
    Else
      nyRapport.Beskrivelse = cboAnnoncørNO_.Text
    End If
    nyRapport.Show()
    nyRapport.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub btnTilBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTilBooking.Click
    If _modul = "Medieplan" Then
      If _status <= StatusKoder.stsOrdreIkkeSendt Then
        VisSupportBilag()
        If SupportBilagDialogSvar <> "Annuller" Then
          _status = StatusKoder.stsOrdreIkkeSendt
          DataSourceMedieplan.Status = StatusKoder.stsOrdreIkkeSendt
          setStatus(_status)
          OpdaterStatusIMedieplanTabeller(_status)
          OpdaterMedieplanNrTabel()
          Me.Close()
        End If
      End If
    Else
      If _status < StatusKoder.stsUdsendtOrdre Then
        UdsendOrdre()
        _status = StatusKoder.stsUdsendtOrdre
        DataSourceMedieplan.Status = StatusKoder.stsUdsendtOrdre
        setStatus(_status)
        OpdaterStatusIMedieplanTabeller(_status)
      ElseIf _status = StatusKoder.stsUdsendtOrdre Then
        If MessageBox.Show("Er du sikker på du vil standse denne ordre?", "Stands ordre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          'standsningsBemærkning = InputBox("Skriv en bemærkning til denne standsning", "Standsning")
          _status = StatusKoder.stsStandsetOrdre
          DataSourceMedieplan.Status = StatusKoder.stsStandsetOrdre
          setStatus(_status)
          OpdaterStatusIMedieplanTabeller(_status)
          OpdaterMedieplanNrTabel()
          UdsendOrdre()
        End If
      End If
    End If
  End Sub

  Private Sub UdsendOrdre()
    Dim rowList As New List(Of UltraGridRow)
    Dim udsendteGrupper As New List(Of String)
    Dim fundetGruppe As Boolean = False
    Dim findGruppe As String
    Dim herningBladetFundet As Boolean = False
    Dim huskHerningBladetSendeGruppe As String = ""

    Me.Cursor = Cursors.WaitCursor
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If arow.Cells("UgeavisID").Value = 191 Then
        herningBladetFundet = True
        huskHerningBladetSendeGruppe = arow.Cells("SendeGruppe").Value
        arow.Cells("SendeGruppe").Value = ""
      End If
      If arow.Cells("SendeGruppe").Value = "" AndAlso arow.Cells("RowState").Value <> "Deleted" Then
        rowList.Clear()
        rowList.Add(arow)
        SendOrdreSeddel(rowList, _status)
      End If
    Next
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If arow.Cells("SendeGruppe").Value <> "" AndAlso arow.Cells("RowState").Value <> "Deleted" Then
        findGruppe = arow.Cells("SendeGruppe").Value
        fundetGruppe = False
        For Each gruppe As String In udsendteGrupper
          If gruppe = findGruppe Then
            fundetGruppe = True
          End If
        Next
        If Not fundetGruppe Then
          udsendteGrupper.Add(findGruppe)
          rowList.Clear()
          For Each brow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
            If brow.Cells("SendeGruppe").Value = findGruppe AndAlso brow.Cells("RowState").Value <> "Deleted" Then
              rowList.Add(brow)
            End If
          Next
          SendOrdreSeddel(rowList, _status)
        End If
      End If
    Next
    Me.Cursor = Cursors.Default
    If herningBladetFundet Then
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        If arow.Cells("UgeavisID").Value = 191 Then
          arow.Cells("SendeGruppe").Value = huskHerningBladetSendeGruppe
          Exit For
        End If
      Next
    End If
    If Not _IsGenberegning Then
      If _status = StatusKoder.stsStandsetOrdre Then
        MessageBox.Show("Standsninger er udsendt.", "Udsendt", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        MessageBox.Show("Ordresedler er udsendt.", "Udsendt", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub UdsendOrdreRettelser()
    Dim rowList As New List(Of UltraGridRow)
    Dim udsendteGrupper As New List(Of String)
    Dim fundetGruppe As Boolean = False
    Dim findGruppe As String
    Dim herningBladetFundet As Boolean = False
    Dim huskHerningBladetSendeGruppe As String = ""

    Me.Cursor = Cursors.WaitCursor
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If arow.Cells("UgeavisID").Value = 191 Then
        herningBladetFundet = True
        huskHerningBladetSendeGruppe = arow.Cells("SendeGruppe").Value
        arow.Cells("SendeGruppe").Value = ""
      End If
      If arow.Cells("SendeGruppe").Value = "" Then
        If arow.Cells("RowState").Value <> "UnChanged" OrElse _DataValues.HasChanged Then
          rowList.Clear()
          rowList.Add(arow)
          SendOrdreSeddel(rowList, _status)
        End If
      End If
    Next
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If arow.Cells("SendeGruppe").Value <> "" Then
        If arow.Cells("RowState").Value <> "UnChanged" OrElse _DataValues.HasChanged Then
          findGruppe = arow.Cells("SendeGruppe").Value
          fundetGruppe = False
          For Each gruppe As String In udsendteGrupper
            If gruppe = findGruppe Then
              fundetGruppe = True
            End If
          Next
          If Not fundetGruppe Then
            udsendteGrupper.Add(findGruppe)
            rowList.Clear()
            For Each brow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
              If brow.Cells("SendeGruppe").Value = findGruppe Then
                rowList.Add(brow)
              End If
            Next
            SendOrdreSeddel(rowList, _status)
          End If
        End If
      End If
    Next
    If herningBladetFundet Then
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        If arow.Cells("UgeavisID").Value = 191 Then
          arow.Cells("SendeGruppe").Value = huskHerningBladetSendeGruppe
          Exit For
        End If
      Next
    End If
    Me.Cursor = Cursors.Default
    MessageBox.Show("Rettelser er udsendt.", "Rettelser", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub GenUdsendOrdre()
    Dim rowList As New List(Of UltraGridRow)
    Dim udsendteGrupper As New List(Of String)
    Dim fundetGruppe As Boolean = False
    Dim findGruppe As String
    Dim herningBladetFundet As Boolean = False
    Dim huskHerningBladetSendeGruppe As String = ""

    Me.Cursor = Cursors.WaitCursor
    For Each arow As UltraGridRow In grdOrdreLinjer.Selected.Rows
      If arow.Cells("UgeavisID").Value = 191 Then
        herningBladetFundet = True
        huskHerningBladetSendeGruppe = arow.Cells("SendeGruppe").Value
        arow.Cells("SendeGruppe").Value = ""
      End If
      If arow.Cells("SendeGruppe").Value = "" AndAlso arow.Cells("RowState").Value <> "Deleted" Then
        rowList.Clear()
        rowList.Add(arow)
        SendOrdreSeddel(rowList, StatusKoder.stsOrdreIkkeSendt)
      End If
    Next
    For Each arow As UltraGridRow In grdOrdreLinjer.Selected.Rows
      If arow.Cells("SendeGruppe").Value <> "" AndAlso arow.Cells("RowState").Value <> "Deleted" Then
        findGruppe = arow.Cells("SendeGruppe").Value
        fundetGruppe = False
        For Each gruppe As String In udsendteGrupper
          If gruppe = findGruppe Then
            fundetGruppe = True
          End If
        Next
        If Not fundetGruppe Then
          udsendteGrupper.Add(findGruppe)
          rowList.Clear()
          For Each brow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
            If brow.Cells("SendeGruppe").Value = findGruppe AndAlso brow.Cells("RowState").Value <> "Deleted" Then
              rowList.Add(brow)
            End If
          Next
          SendOrdreSeddel(rowList, StatusKoder.stsOrdreIkkeSendt)
        End If
      End If
    Next
    If herningBladetFundet Then
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        If arow.Cells("UgeavisID").Value = 191 Then
          arow.Cells("SendeGruppe").Value = huskHerningBladetSendeGruppe
          Exit For
        End If
      Next
    End If
    Me.Cursor = Cursors.Default
    If Not _IsGenberegning Then MessageBox.Show("Ordresedler er genudsendt.", "Genudsendt", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub SendOrdreSeddel(ByVal rows As List(Of UltraGridRow), ByVal status As StatusKoder)
    'Const sletHTML As String = ""
    Dim sHTML As New StringBuilder(3000)
    Dim gruppeHTML(25) As String
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim Tr As String
    Tr = "<TR>"
    Dim rT As String
    rT = "</TR>"
    Dim Bo As String
    Bo = "<B>"
    Dim oB As String
    oB = "</B>"
    Dim Br As String
    Br = "<BR>"
    Dim tD As String
    tD = "<TD>"
    Dim dT As String
    dT = "</TD>"
    Dim Fo As String
    Fo = "<b><font size=" & Chr(34) & "2" & Chr(34) & ">"
    Dim oFo As String
    oFo = "</font></b>"
    Dim beginTable As String
    beginTable = "<table border=" & """0""" & " cellpadding=" & """0""" & " cellspacing=" & """0""" & " width=" & """100%""" & ">"
    Dim endTable As String
    endTable = "</table>"
    Dim nb As String
    nb = "&nbsp;"
    Dim sendFrom As String = ""
    Dim sendTilHovedBlad As String = ""
    Dim Sti As String = ""
    Dim svar As Long = 0
    Dim bemærkning As String = ""
    Dim succes As Boolean = False
    Dim ordreRettelse As String = ""
    Dim eMailAdr As String = ""
    Dim SendeGruppe As String = ""
    Dim checkLog As String = ""
    Dim farvepris As Double = 0
    Dim farveRabat As Double = 0
    Dim farverabatpris As Double = 0
    Dim godtpris As Double = 0
    Dim sikpris As Double = 0
    Dim infpris As Double = 0
    Dim moms As Double = 0
    Dim momsbeløb As Double = 0
    Dim mmpris As Double = 0
    Dim webtillægpris As Double = 0
    Dim miljøtillægpris As Double = 0
    Dim mmrabat As Double = 0
    Dim mmrabatpris As Double = 0
    Dim antalmm As Integer = 0
    Dim sendPris As String = ""
    Dim total As Double = 0
    Dim gruppeTotal As Double = 0
    Dim medtagBem As Boolean = False
    Dim filNavn As String = ""
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand
    Dim webCM As SqlCommand = cn.CreateCommand

    Dim modtagere() As String

    Dim erGruppe As Boolean = rows.Count > 1 'Hvis det er gruppe er der flere rækker
    Dim row As UltraGridRow = rows(0) ' kun første række skal bruges her
    Dim visÆndringer As Boolean = True

    Dim fundetIkkeAdded As Boolean = False
    Dim fundetIkkeDeleted As Boolean = False
    For i = 0 To rows.Count - 1
      If rows(i).Cells("RowState").Value <> "Added" Then fundetIkkeAdded = True
      If rows(i).Cells("RowState").Value <> "Deleted" Then fundetIkkeDeleted = True
    Next
    If Not fundetIkkeAdded Then status = StatusKoder.stsOrdreIkkeSendt
    If Not fundetIkkeDeleted Then status = StatusKoder.stsStandsetOrdre
    '  If Not erGruppe AndAlso status = StatusKoder.stsUdsendtOrdre AndAlso row.Cells("New Total").Value < 1 Then status = StatusKoder.stsStandsetOrdre
    For i = 0 To rows.Count - 1
      If IsDBNull(rows(i).Cells("MaterialeNr").Value) OrElse rows(i).Cells("MaterialeNr").Value = "0" Then
        MessageBox.Show("Der er ikke materialenr. på et eller flere blade." & vbCrLf & "Intet sendes ud.", "Mangler materiale nr.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
      End If
    Next
    If status = StatusKoder.stsOrdreIkkeSendt OrElse status = StatusKoder.stsStandsetOrdre Then visÆndringer = False

    SendeGruppe = row.Cells("SendeGruppe").Value

    If erGruppe Then
      sHTML.AppendFormat("<html><head><meta http-equiv=" & """Content-Type""" & " content=" & """text/html; charset=utf-8""" & "><title>DLU Gruppeordre Nr.: {0}", _medieplanNr.ToString)
    Else
      sHTML.AppendFormat("<html><head><meta http-equiv=" & """Content-Type""" & " content=" & """text/html; charset=utf-8""" & "><title>DLU Ordre Nr.: {0}-{1}", _medieplanNr.ToString, row.Cells("UgeavisID").Value)
    End If
    sHTML.Append("</title></head><body><Font Size=" & """3""" & ">")
    sHTML.Append(beginTable & Tr)
    sHTML.Append("<td width=" & """33%""" & " align=" & """left""" & ">")
    sHTML.Append("<font size=" & """5""" & ">")

    If status = StatusKoder.stsStandsetOrdre Then
      If erGruppe Then
        filNavn = SendeGruppe & " Standsning"
        sHTML.AppendFormat(Bo & "Standsning til {0}" & oB, SendeGruppe)
      Else
        filNavn = Trim(row.Cells("UgeavisID").Text) & " Standsning"
        sHTML.Append(Bo & "Standsning" & oB)
      End If
    ElseIf status = StatusKoder.stsOrdreIkkeSendt Then  'Nye ordrer sendes
      If erGruppe Then
        filNavn = SendeGruppe & " Annonceordre"
        sHTML.AppendFormat("Annonceordre til {0}", SendeGruppe)
      Else
        filNavn = Trim(row.Cells("UgeavisID").Text) & " Annonceordre"
        sHTML.Append("Annonceordre")
      End If
    Else
      If status = StatusKoder.stsUdsendtOrdre Then 'Rettelser
        If erGruppe Then
          filNavn = SendeGruppe & " Rettelse Version:" & _version
          sHTML.Append(Bo & "Rettelse" & oB)
        Else
          filNavn = Trim(row.Cells("UgeavisID").Text) & " Rettelse Version:" & _version
          sHTML.Append(Bo & "Rettelse" & oB)
        End If
      Else
        If erGruppe Then
          filNavn = SendeGruppe & " Fakturarettelse Version:" & _version
        Else
          filNavn = Trim(row.Cells("UgeavisID").Text) & " Fakturarettelse Version:" & _version
        End If
        sHTML.Append(Bo & "Fakturarettelse" & oB)
      End If
      If erGruppe Then
        sHTML.AppendFormat(" til {0} <br> se rettelser", SendeGruppe)
      Else
        sHTML.Append(Br & " se rettelser")
      End If
    End If
    sHTML.Append(oB + "</font>" + dT)
    sHTML.Append("<td width=" & """33%""" & " align=" & """middle""" & ">")
    sHTML.Append(Bo + "Udsendt : " & oB & Now() & dT)
    sHTML.Append("<td width=" & """33%""" & " align=" & """right""" & ">")
    If erGruppe Then
      sHTML.AppendFormat(Bo & "Ordrenr.: " & oB & "{0}", _medieplanNr.ToString)
    Else
      sHTML.AppendFormat(Bo & "Ordrenr.: " & oB & "{0}-{1}", _medieplanNr.ToString, row.Cells("UgeavisID").Value)
      If status <> StatusKoder.stsStandsetOrdre AndAlso Not IsDBNull(row.Cells("MaterialeNr").Value) Then
        sHTML.AppendFormat(Br + "Materialenr.: {0}", row.Cells("MaterialeNr").Value)
      End If
    End If
    sHTML.Append(dT & rT & endTable)
    sHTML.Append("<table border=" & """1""" & " cellpadding=" & """5""" & " cellspacing=" & """0""" & " width=" & """100%""" & ">")

    If visÆndringer Then
      sHTML.Append(Tr)
      sHTML.Append("<td width=" & """100%""" & " colspan=" & """4""" & " valign=" & """top""" & ">")
      sHTML.Append(Fo & "Rettelser " & oFo)
      sHTML.Append(_DataValues.GetChangeTekst(False))
      If erGruppe Then
        Dim standsningFundet As Boolean = False
        For i = 0 To rows.Count - 1
          If rows(i).Cells("RowState").Value = "Added" Then
            sHTML.Append(Br & Bo & Fo & rows(i).Cells("UgeavisID").Text & " er tilføjet." & oFo & oB)
          ElseIf rows(i).Cells("RowState").Value = "Deleted" Then
            sHTML.Append(Br & Bo & Fo & rows(i).Cells("UgeavisID").Text & " er standset." & oFo & oB)
            standsningFundet = True
          Else
            If bladRettelse(rows(i)) <> "" Then
              If _status >= StatusKoder.stsUbetaltOrdre Then
                Dim nyfrmFakturaRettelse As New frmFakturaRettelse(_medieplanNr, _version, rows(i).Cells("UgeavisID").Value, rows(i).Cells("UgeavisID").Text, bladRettelse(rows(i)))
                nyfrmFakturaRettelse.ShowDialog()
              End If
              sHTML.Append(Br & Bo & Fo & "Rettelser til " & rows(i).Cells("UgeavisID").Text & oFo & oB & nb & nb & "<I>" & bladRettelse(rows(i)) & "</I>")
            End If
          End If
        Next i
        If standsningFundet Then
          If standsningsBemærkning.Length = 0 Then
            standsningsBemærkning = InputBox("Skriv en bemærkning til standsningen." & vbCrLf & "(Denne bemærkning vil påføres alle standsninger i denne udsendelse.)", "Standsning")
          End If
          If standsningsBemærkning.Length > 0 Then
            sHTML.Append(Br & Br & Fo & "Standsnings bemærkning: " & oFo)
            sHTML.Append(standsningsBemærkning)
          End If
        End If
      Else
        If bladRettelse(row) <> "" Then
          If _status >= StatusKoder.stsUbetaltOrdre Then
            Dim nyfrmFakturaRettelse As New frmFakturaRettelse(_medieplanNr, _version, row.Cells("UgeavisID").Value, row.Cells("UgeavisID").Text, bladRettelse(row))
            nyfrmFakturaRettelse.ShowDialog()
          End If
          sHTML.Append(Br & "<i>" & bladRettelse(row) & "</i>")
        End If
      End If
      sHTML.Append(dT & rT)
      sHTML.Append(rT)
    Else
      If status = StatusKoder.stsStandsetOrdre Then
        If standsningsBemærkning.Length = 0 Then
          standsningsBemærkning = InputBox("Skriv en bemærkning til standsningen." & vbCrLf & "(Denne bemærkning vil påføres alle standsninger i denne udsendelse.)", "Standsning")
        End If
        If standsningsBemærkning.Length > 0 Then
          sHTML.Append(Tr)
          sHTML.Append("<td width=" & """100%""" & " colspan=" & """4""" & " valign=" & """top""" & ">")
          sHTML.Append(Fo & "Standsnings bemærkning: " & oFo)
          sHTML.Append(standsningsBemærkning)
          sHTML.Append(dT & rT)
          sHTML.Append(rT)
        End If
      End If
    End If

    sHTML.Append(Tr)
    sHTML.Append("<td width=" & """50%""" & " colspan=" & """2""" & " valign=" & """top""" & ">")
    sHTML.Append(Fo & "Fra" & oFo & Br & "De Lokale Ugeaviser<br>Strandboulevarden 89 2100 København Ø<br>CVR : 10030749" & dT)
    sHTML.Append("<td width=" & """50%""" & " colspan=" & """2""" & " valign=" & """top""" & ">")

    sHTML.Append(Fo & "Alle henvendelser rettes til" & oFo & Br & "Matr./ordre: " & frmMain.BrugerFuldeNavn & " tlf.: " & frmMain.BrugerTlf & Br)
    sHTML.Append("Kundeinfo: " & _DataValues.SalgsAnsvarlig & " tlf.: " & _DataValues.SalgsAnsvarligTlf & dT)
    sHTML.Append(rT)
    sHTML.Append(Tr)
    sHTML.Append("<td colspan=" & """4""" & " width=" & """100%""" & ">")
    sHTML.Append(beginTable)
    sHTML.Append(Tr)
    sHTML.Append("<TD width=" & """50%""" & " valign=" & """top""" & ">")
    sHTML.Append(beginTable & Tr + tD + Fo + "Annoncør" + oFo + dT + rT)
    sHTML.Append(Tr & tD)
    sHTML.Append(_DataValues.AnnoncørNavn & Br & _DataValues.AnnoncørAdresse & Br & _DataValues.AnnoncørPostNr & " " & _DataValues.AnnoncørPostBy)
    sHTML.Append(dT & rT & endTable & dT)
    sHTML.Append("<td width=" & """50%""" & ">")
    sHTML.Append("<table border=" & """0""" & " cellpadding=" & """5""" & " cellspacing=" & """0""" & " width=" & """100%""" & ">")
    sHTML.Append(Tr & "<td valign=" & """middle""" & ">Tlf.: " & _DataValues.AnnoncørTlf & Br & "CVR :" & _DataValues.AnnoncørCVR & Br & "EAN :" & _DataValues.AnnoncørEAN & dT & rT & endTable)
    sHTML.Append(dT & rT)
    sHTML.Append("</table>")
    sHTML.Append(dT)
    sHTML.Append(rT)
    sHTML.Append(Tr)
    sHTML.Append("<td width=" & """25%""" & ">")
    sHTML.Append(beginTable)
    sHTML.Append(Tr & tD & Fo & "Indrykningsuge" & oFo & dT & rT & Tr & "<td align=" & """middle""" & ">")
    If visÆndringer AndAlso _DataValues.IndrykningsUgeHasChanged Then sHTML.Append(Bo)
    sHTML.Append(_DataValues.IndrykningsUge & " " & _DataValues.IndrykningsÅr)
    If visÆndringer AndAlso _DataValues.IndrykningsUgeHasChanged Then sHTML.Append(oB)
    sHTML.Append(dT & rT)
    sHTML.Append(endTable)
    sHTML.Append(dT)
    sHTML.Append("<td width=" & """25%""" & ">")
    sHTML.Append(beginTable)
    sHTML.Append(Tr & tD & Fo & "Annonceformat" & oFo & dT & rT & Tr & "<td align=" & """middle""" & ">")
    If visÆndringer AndAlso _DataValues.FormatHasChanged Then sHTML.Append(Bo)
    If _DataValues.Format2 = 365 Then
      If erGruppe Then
        sHTML.Append(_DataValues.Format1 & "x" & _DataValues.Format2)
      Else
        If row.Cells("Is365").Value = True Then
          sHTML.Append(_DataValues.Format1 & "x" & _DataValues.Format2)
        Else
          sHTML.Append(_DataValues.Format1 & "x360")
        End If
      End If
    Else
      sHTML.Append(_DataValues.Format1 & "x" & _DataValues.Format2)
    End If
    If visÆndringer AndAlso _DataValues.FormatHasChanged Then sHTML.Append(oB)
    sHTML.Append(dT & rT)
    sHTML.Append(endTable)
    sHTML.Append(dT)
    sHTML.Append("<td width=" & """25%""" & ">")
    sHTML.Append(beginTable)
    sHTML.Append(Tr & tD & Fo & "Antal farver" & oFo & dT & rT & Tr & "<td align=" & """middle""" & ">")
    If visÆndringer AndAlso _DataValues.AntalFarverHasChanged Then sHTML.Append(Bo)
    If _DataValues.AntalFarver = 1 Then
      If visÆndringer AndAlso _DataValues.DPKulørIDHasChanged Then sHTML.Append(Bo)
      sHTML.Append(cboDPKulørID.Text)
      If visÆndringer AndAlso _DataValues.DPKulørIDHasChanged Then sHTML.Append(oB)
    Else
      sHTML.Append(_DataValues.AntalFarver & " ")
    End If
    If visÆndringer AndAlso _DataValues.AntalFarverHasChanged Then sHTML.Append(oB)

    sHTML.Append(dT & rT & endTable)
    sHTML.Append(dT)
    sHTML.Append("<td width=" & """25%""" & ">")
    sHTML.Append(beginTable)
    sHTML.Append(Tr & tD & Fo & "Placering" & oFo & dT & rT & Tr & "<td align=" & """middle""" & ">")
    If visÆndringer AndAlso _DataValues.PlaceringIDHasChanged Then sHTML.Append(Bo)
    sHTML.Append(cboPlaceringID.Text)
    If visÆndringer AndAlso _DataValues.PlaceringIDHasChanged Then sHTML.Append(oB)
    sHTML.Append(dT & rT)
    sHTML.Append(endTable)
    sHTML.Append(dT)
    sHTML.Append(rT)
    sHTML.Append(Tr)
    sHTML.Append("<TD colspan=" & """4""" & " width=" & """100%""" & ">" + Fo + "Annonceoverskrift : " & oFo)
    If visÆndringer AndAlso _DataValues.OverskriftHasChanged Then sHTML.Append(Bo)
    sHTML.Append(txtOverskrift.Text)
    If visÆndringer AndAlso _DataValues.OverskriftHasChanged Then sHTML.Append(oB)
    sHTML.Append(dT & rT)
    sHTML.Append(Tr)

    sHTML.Append("<td width=" & """50%""" & " colspan=" & """2""" & " valign=" & """top""" & ">")
    sHTML.Append(beginTable & Tr & tD & Fo & "Bureau" & oFo & dT & rT)
    sHTML.Append(Tr & tD)
    sHTML.Append(_DataValues.BureauNavn & Br & _DataValues.BureauAdresse & Br & _DataValues.BureauPostNr & " " & _DataValues.BureauPostBy)
    sHTML.Append(dT & rT & endTable & dT)

    sHTML.Append("<td width=" & """25%""" & " valign=" & """top""" & ">")
    sHTML.Append(beginTable)
    sHTML.Append(Tr)
    sHTML.Append("<td width=" & """20%""" & ">" & Fo & "Tlf" & oFo & dT)
    sHTML.Append("<td width=" & """80%""" & ">" & _DataValues.BureauTlf & dT & rT & endTable & dT)
    sHTML.Append("<td width=" & """25%""" & " valign=" & """top""" & ">")
    sHTML.Append(beginTable)
    sHTML.Append(Tr & tD & Fo & "Materiale" & oFo & dT & rT & Tr & "<td align=" & """middle""" & ">")
    If visÆndringer AndAlso _DataValues.MaterialeFølgerFraHasChanged Then sHTML.Append(Bo)
    Select Case _DataValues.MaterialeFølgerFra
      Case 0
        sHTML.Append("Brug materiale fra uge ")
        If visÆndringer AndAlso _DataValues.BrugMaterialeFraUgeHasChanged Then sHTML.Append(Bo)
        sHTML.Append(_DataValues.BrugMaterialeFraUge)
        If visÆndringer AndAlso _DataValues.BrugMaterialeFraUgeHasChanged Then sHTML.Append(oB)
      Case 1
        sHTML.Append("Følger fra DLU")
      Case 2
        sHTML.Append("Følger fra Bureau")
        If _DataValues.MaterialeFølgerFraLeverandør.Length > 0 Then sHTML.AppendFormat("<br>{0}", _DataValues.MaterialeFølgerFraLeverandør)
      Case 3
        sHTML.Append("Følger fra Annoncør")
        If _DataValues.MaterialeFølgerFraLeverandør.Length > 0 Then sHTML.AppendFormat("<br>{0}", _DataValues.MaterialeFølgerFraLeverandør)
    End Select
    If visÆndringer AndAlso _DataValues.MaterialeFølgerFraHasChanged Then sHTML.Append(oB)
    If _DataValues.MaterialeFølgerFra = 1 Then
      If Not IsDBNull(row.Cells("MedienetKode").Value) Then
        If row.Cells("MedienetKode").Value <> "" Then
          sHTML.Append(" via MedieNet")
        Else
          If optFakturering.CheckedIndex = 0 Then sHTML.Append(" via eMail")
        End If
      Else
        If optFakturering.CheckedIndex = 0 Then sHTML.Append(" via eMail")
      End If
    End If
    If erGruppe AndAlso Not _DataValues.SammeMateriale Then sHTML.Append(Br & Bo & "Forskelligt materiale pr. blad" & oB)
    sHTML.Append(dT & rT & endTable & dT)
    sHTML.Append(rT)
    sHTML.Append(Tr)
    sHTML.Append("<td width=" & """100%""" & " colspan=" & """4""" & " valign=" & """top""" & ">")
    sHTML.Append(Fo & "Fakturering" & oFo)
    If visÆndringer AndAlso _DataValues.FaktureringHasChanged Then sHTML.Append(Bo)
    If optFakturering.CheckedIndex = 0 Then
      sHTML.Append(" De Lokale Ugeaviser fakturerer kunden.")
    Else
      sHTML.Append(" I skal sende faktura til ")
      If cboBureauNO_.Text = "" Then ' Der er intet bureau så det skal være annoncør
        sHTML.Append("Annoncør")
      Else
        sHTML.Append("Bureau")
      End If
    End If
    If visÆndringer AndAlso _DataValues.FaktureringHasChanged Then sHTML.Append(oB)
    sHTML.Append(dT & rT)

    If optBilagsBladeTil.CheckedIndex > -1 Then
      sHTML.Append(Tr)
      sHTML.Append("<td width=" & """100%""" & " colspan=" & """4""" & " valign=" & """top""" & ">")
      sHTML.Append(Fo & "Bilagsblade skal sendes til" & oFo)
      If visÆndringer AndAlso _DataValues.BilagsBladeTilHasChanged Then sHTML.Append(Bo)
      Select Case optBilagsBladeTil.Value
        Case 1
          sHTML.Append(" Annoncør.")
        Case 2
          Select Case Trim(_DataValues.BureauNO_)
            Case "E00004", "E00005", "E00009", "E00012", "E00848", "E00852", "E01890", "E02220"
              sHTML.Append(" GroupM  Antonigade 4, 4. sal  1106 København K  ATT: Jessie Lund - Annoncekontrol")
            Case Else
              sHTML.Append(" Bureau.")
          End Select
        Case 3
          sHTML.Append(" " & _DataValues.BilagsBladeTilNavn & nb & nb & _DataValues.BilagsBladeTilAdresse & nb & nb & _DataValues.BilagsBladeTilPostNr & nb & FindPostBy(_DataValues.BilagsBladeTilPostNr))
      End Select
      If visÆndringer AndAlso _DataValues.FaktureringHasChanged Then sHTML.Append(oB)
      If _DataValues.BilagsBladeAtt <> "" Then sHTML.Append(" ATT: " & _DataValues.BilagsBladeAtt)
      sHTML.Append(dT & rT)
    End If

    sHTML.Append(Tr)
    sHTML.Append("<td width=" & """100%""" & " colspan=" & """4""" & " valign=" & """top""" & ">")
    sHTML.Append(Fo & "Bemærkninger " & oFo & _DataValues.BemærkningTilUgeavis)
    If erGruppe Then
      For i = 0 To rows.Count - 1
        If rows(i).Cells("New Bemærkning").Value <> "" AndAlso rows(i).Cells("RowState").Value <> "Deleted" Then
          sHTML.Append(Br & Bo & Fo & "Bemærkning til " & rows(i).Cells("UgeavisID").Text & oFo & oB & nb & nb & "<I>" & rows(i).Cells("New Bemærkning").Value & "</I>")
        End If
      Next i
    Else
      If row.Cells("New Bemærkning").Value <> "" Then
        If row.Cells("RowState").Value = "Deleted" Then
          sHTML.Append(Br & "Ordren er standset." & Br)
        Else
          sHTML.Append(Br & "<I>" & row.Cells("New Bemærkning").Value & "</I>" & Br)
        End If
      End If
    End If
    sHTML.Append(dT & rT)
    sHTML.Append(rT)
    sHTML.Append(endTable)

    sHTML.Append(Br)

    sHTML.Append("<table border=" & """1""" & " cellpadding=" & """5""" & " cellspacing=" & """0""" & " width=" & """100%""" & ">")
    sHTML.Append(Tr)
    If status <> StatusKoder.stsStandsetOrdre Then
      sHTML.Append("<td width=" & """50%""" & ">" & Bo & Fo & "Indrykkes i følgende blade" & oFo & oB & dT)
    Else
      sHTML.Append("<td width=" & """50%""" & ">" & Bo & Fo & "Standses i følgende blade" & oFo & oB & dT)
    End If
    sHTML.Append("<td width=" & """25%""" & ">" & Bo & Fo & "Materialenr." & oFo & oB & dT)
    sHTML.Append("<td width=" & """25%""" & ">" & Bo & Fo & "Bureauordrenr." & oFo & oB & dT)
    sHTML.Append(rT)
    For i = 0 To rows.Count - 1
      If rows(i).Cells("RowState").Value <> "Deleted" OrElse status = StatusKoder.stsStandsetOrdre Then
        sHTML.Append(Tr)
        sHTML.Append(tD & rows(i).Cells("UgeavisID").Text & dT)
        sHTML.Append("<td align=" & """center""" & ">" & rows(i).Cells("MaterialeNr").Value & nb & dT)
        If _DataValues.SammeBureauOrdreNr Then
          If visÆndringer AndAlso _DataValues.FællesBureauOrdreNrHasChanged Then sHTML.Append(Bo)
          sHTML.Append("<td align=" & """center""" & ">" & _DataValues.FællesBureauOrdreNr & nb & dT)
          If visÆndringer AndAlso _DataValues.FællesBureauOrdreNrHasChanged Then sHTML.Append(oB)
        Else
          If visÆndringer AndAlso rows(i).Cells("New BureauOrdreNr").Value <> rows(i).Cells("Old BureauOrdreNr").Value Then sHTML.Append(Bo)
          sHTML.Append("<td align=" & """center""" & ">" & rows(i).Cells("New BureauOrdreNr").Value & nb & dT)
          If visÆndringer AndAlso rows(i).Cells("New BureauOrdreNr").Value <> rows(i).Cells("Old BureauOrdreNr").Value Then sHTML.Append(oB)
        End If
        sHTML.Append(rT)
      End If
    Next
    sHTML.Append(endTable)

    cm.CommandType = CommandType.Text
    webCM.CommandType = CommandType.Text
    cm.Parameters.Add("@TotalPris", SqlDbType.Money)
    cn.Open()

    sHTML.Append(Br & Br)
    sHTML.Append("<P><b><u><Font size=" & """5""" & ">Afregningsbilag</font></u></b>")
    For i = 0 To rows.Count - 1
      If rows(i).Cells("RowState").Value <> "Deleted" OrElse status = StatusKoder.stsStandsetOrdre Then
        sHTML.Append(Br)
        sHTML.Append(Bo & "Ugeavis: " & oB)
        sHTML.Append(rows(i).Cells("UgeavisID").Text & nb & nb)
        sHTML.Append("</P>")
        farvepris = 0
        farverabatpris = 0
        godtpris = 0
        sikpris = 0
        infpris = 0
        moms = 0
        momsbeløb = 0
        mmpris = 0
        mmrabatpris = 0
        antalmm = 0
        sHTML.Append("<table border=" & """1""" & " cellpadding=" & """0""" & " cellspacing=" & """0""" & " width=" & """100%""" & ">")
        sHTML.Append(Tr)
        antalmm = rows(i).Cells("Mm").Value '_DataValues.Format1 * _DataValues.Format2
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable & Tr)
        sHTML.Append("<TD width=" & """40%""" & ">" & nb & dT)
        sHTML.Append("<TD width=" & """20%""" & ">" & Fo & "Beløb" + oFo + dT)
        sHTML.Append("<TD width=" & """25%""" & ">" & Fo & "Beregning" + oFo + dT)
        sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & Fo & "Total" & oFo & dT)
        sHTML.Append(rT)

        sHTML.Append(Tr)
        sHTML.Append(tD & Fo & "Antal mm." & oFo & dT)
        If visÆndringer AndAlso _DataValues.FormatHasChanged Then sHTML.Append(Bo)
        sHTML.Append(tD & antalmm.ToString("#,###")) 'String.Format("#,###", antalmm) & dT)
        If visÆndringer AndAlso _DataValues.FormatHasChanged Then sHTML.Append(oB)
        sHTML.Append(tD & nb & dT)
        sHTML.Append(tD & nb & dT)
        sHTML.Append(rT)

        sHTML.Append(Tr)
        sHTML.Append(tD & Fo & "Mm. pris" & oFo & dT)
        mmpris = rows(i).Cells("New MmPris").Value
        sHTML.Append(tD)
        If visÆndringer AndAlso rows(i).Cells("New MmPris").Value <> rows(i).Cells("Old MmPris").Value Then sHTML.Append(Bo)
        sHTML.Append(mmpris.ToString("#,##0.00"))
        If visÆndringer AndAlso rows(i).Cells("New MmPris").Value <> rows(i).Cells("Old MmPris").Value Then sHTML.Append(oB)
        sHTML.Append(dT)
        sHTML.Append(tD & mmpris.ToString("#,##0.00") & "x" & antalmm.ToString("#,###") & dT)
        mmpris = antalmm.ToString("#,###") * mmpris
        sHTML.Append("<TD align=" & """right""" & ">" & mmpris.ToString("#,##0.00") & dT)
        sHTML.Append(rT)
        sHTML.Append(endTable & dT & rT)

        sHTML.Append(Tr)
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable + Tr)
        sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Rabat" & oFo & dT)
        If rows(i).Cells("New MmRabat").Value > 0 Then
          mmrabat = rows(i).Cells("New MmRabat").Value
          sHTML.Append("<TD width=" & """20%""" & ">")
          If visÆndringer AndAlso rows(i).Cells("New MmRabat").Value <> rows(i).Cells("Old MmRabat").Value Then sHTML.Append(Bo)
          sHTML.Append(mmrabat.ToString("#,##0.00") & "%") 'sHTML.Append(rows(i).Cells("New MmRabat").Value & "%")
          If visÆndringer AndAlso rows(i).Cells("New MmRabat").Value <> rows(i).Cells("Old MmRabat").Value Then sHTML.Append(oB)
          sHTML.Append(dT)
          sHTML.Append("<TD width=" & """25%""" & ">" & mmrabat.ToString("#,##0.00") & "% af " & mmpris.ToString("#,##0.00") & dT)
          mmrabatpris = mmpris * rows(i).Cells("New MmRabat").Value / 100
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & mmrabatpris.ToString("-#,##0.00") & dT)
        Else
          sHTML.Append("<TD width=" & """20%""" & ">" & nb & dT)
          sHTML.Append("<TD width=" & """25%""" & ">" & nb & dT)
          sHTML.Append("<TD width=" & """15%""" & " align=" & """rigth""" & ">" & nb & dT)
        End If
        sHTML.Append(rT & endTable & dT & rT)

        sHTML.Append(Tr)
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable & Tr)
        sHTML.Append("<td colspan=" & """4""" & ">" & nb & dT)
        sHTML.Append(rT)

        sHTML.Append(Tr)
        sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Farvetillæg" & oFo & dT)

        farvepris = rows(i).Cells("New FarvePris").Value
        If farvepris > 0 Then
          sHTML.Append("<TD width=" & """20%""" & ">")
          If visÆndringer AndAlso rows(i).Cells("New FarvePris").Value <> rows(i).Cells("Old FarvePris").Value Then sHTML.Append(Bo)
          sHTML.Append(farvepris.ToString("#,##0.00"))
          If visÆndringer AndAlso rows(i).Cells("New FarvePris").Value <> rows(i).Cells("Old FarvePris").Value Then sHTML.Append(oB)
          sHTML.Append(dT)
        Else
          sHTML.Append("<TD width=" & """20%""" & ">" & nb & dT)
        End If
        If farvepris < 20 Then
          If farvepris > 0 Then
            sendPris = "<TD width=" & """25%""" & ">" & farvepris.ToString("0.00") & "x" & antalmm.ToString("#,###")
            farvepris = farvepris * antalmm
            If Not IsDBNull(rows(i).Cells("FarveMin").Value) AndAlso rows(i).Cells("FarveMin").Value > farvepris Then
              farvepris = rows(i).Cells("FarveMin").Value
              sendPris = sendPris & "(Min. " & farvepris.ToString("#,###") & ")"
            End If
            If Not IsDBNull(rows(i).Cells("FarveMax").Value) AndAlso rows(i).Cells("FarveMax").Value < farvepris AndAlso rows(i).Cells("FarveMax").Value > 0 Then
              farvepris = rows(i).Cells("FarveMax").Value
              sendPris = sendPris + "(Max. " & farvepris.ToString("#,###") & ")"
            End If
          Else
            sendPris = "<TD width=" & """20%""" & ">" & nb & dT
          End If
          sHTML.Append(sendPris & dT)
        Else
          sHTML.Append("<TD width=" & """25%""" & ">" & nb & dT)
          farvepris = farvepris.ToString("#,##0.00")
        End If
        If farvepris > 0 Then
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & farvepris.ToString("#,##0.00") & dT)
        Else
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & nb & dT)
        End If

        sHTML.Append(rT & endTable & dT & rT)

        sHTML.Append(Tr)
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable & Tr)
        sHTML.Append("<TD width=" & """40%""" & ">" & Fo + "Rabat" & oFo & dT)
        If rows(i).Cells("New FarveRabat").Value > 0 And farvepris > 0 Then
          farveRabat = rows(i).Cells("New FarveRabat").Value
          sHTML.Append("<TD width=" & """20%""" & ">")
          If visÆndringer AndAlso rows(i).Cells("New FarveRabat").Value <> rows(i).Cells("Old FarveRabat").Value Then sHTML.Append(Bo)
          sHTML.Append(farveRabat.ToString("#,##0.00") & "%")
          If visÆndringer AndAlso rows(i).Cells("New FarveRabat").Value <> rows(i).Cells("Old FarveRabat").Value Then sHTML.Append(oB)
          sHTML.Append(dT)
          sHTML.Append("<TD width=" & """25%""" & ">" & farveRabat.ToString("#,##0.00") & "% af " & farvepris.ToString("#,##0.00") & dT)
          farverabatpris = farvepris * rows(i).Cells("New FarveRabat").Value / 100
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & farverabatpris.ToString("-#,##0.00") & dT)
        Else
          sHTML.Append("<TD width=" & """20%""" & ">" & nb & dT)
          sHTML.Append("<TD width=" & """25%""" & ">" & nb & dT)
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & nb & dT)
        End If
        sHTML.Append(rT & endTable & dT & rT)

        webtillægpris = 0
        'If _DataValues.IndrykningsÅr > 2010 Then
        '  If _DataValues.WebTillægOpkræves Then
        '    If _DataValues.SammeMateriale Then
        '      If rows(i).Cells("WebTillægFaktureresHer").Value = True Then
        '        If _DataValues.PlaceringID < 11 Then  'Tekst eller Rubrik
        '          webCM.CommandText = "SELECT WebTillægTekst FROM tblEjerforhold WHERE (Ejerforhold = N'" & rows(i).Cells("Ejerforhold").Value & "')"
        '        Else
        '          webCM.CommandText = "SELECT WebTillægRubrik FROM tblEjerforhold WHERE (Ejerforhold = N'" & rows(i).Cells("Ejerforhold").Value & "')"
        '        End If
        '        If Not IsDBNull(webCM.ExecuteScalar) Then webtillægpris = webCM.ExecuteScalar
        '        If webtillægpris > 0 Then 'Så skulle alt være i orden, så linjen kan skrives
        '          sHTML.Append(Tr)
        '          sHTML.Append("<td width=" & """100%""" & ">")
        '          sHTML.Append(beginTable & Tr)
        '          sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Webtillæg" & oFo & dT)
        '          sHTML.Append("<TD width=" & """20%""" & ">" & dT)
        '          sHTML.Append("<TD width=" & """25%""" & ">" & dT)
        '          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & webtillægpris.ToString("#,##0.00") & dT)
        '          sHTML.Append(rT & endTable & dT & rT)
        '        End If
        '      End If
        '    Else
        '      If _DataValues.KunForhandlerBundForskellig Then
        '        If rows(i).Cells("WebTillægFaktureresHer").Value = True Then
        '          If _DataValues.PlaceringID < 11 Then  'Tekst eller Rubrik
        '            webCM.CommandText = "SELECT WebTillægTekst FROM tblEjerforhold WHERE (Ejerforhold = N'" & rows(i).Cells("Ejerforhold").Value & "')"
        '          Else
        '            webCM.CommandText = "SELECT WebTillægRubrik FROM tblEjerforhold WHERE (Ejerforhold = N'" & rows(i).Cells("Ejerforhold").Value & "')"
        '          End If
        '          If Not IsDBNull(webCM.ExecuteScalar) Then webtillægpris = webCM.ExecuteScalar
        '          If webtillægpris > 0 Then 'Så skulle alt være i orden, så linjen kan skrives
        '            sHTML.Append(Tr)
        '            sHTML.Append("<td width=" & """100%""" & ">")
        '            sHTML.Append(beginTable & Tr)
        '            sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Webtillæg" & oFo & dT)
        '            sHTML.Append("<TD width=" & """20%""" & ">" & dT)
        '            sHTML.Append("<TD width=" & """25%""" & ">" & dT)
        '            sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & webtillægpris.ToString("#,##0.00") & dT)
        '            sHTML.Append(rT & endTable & dT & rT)
        '          End If
        '        End If
        '      Else 'Forskelligt materiale
        '        If _DataValues.PlaceringID < 11 Then  'Tekst eller Rubrik
        '          webCM.CommandText = "SELECT WebTillægTekst FROM tblEjerforhold WHERE (Ejerforhold = N'" & rows(i).Cells("Ejerforhold").Value & "')"
        '        Else
        '          webCM.CommandText = "SELECT WebTillægRubrik FROM tblEjerforhold WHERE (Ejerforhold = N'" & rows(i).Cells("Ejerforhold").Value & "')"
        '        End If
        '        If Not IsDBNull(webCM.ExecuteScalar) Then webtillægpris = webCM.ExecuteScalar
        '        If webtillægpris > 0 Then 'Så skulle alt være i orden, så linjen kan skrives
        '          sHTML.Append(Tr)
        '          sHTML.Append("<td width=" & """100%""" & ">")
        '          sHTML.Append(beginTable & Tr)
        '          sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Webtillæg" & oFo & dT)
        '          sHTML.Append("<TD width=" & """20%""" & ">" & dT)
        '          sHTML.Append("<TD width=" & """25%""" & ">" & dT)
        '          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & webtillægpris.ToString("#,##0.00") & dT)
        '          sHTML.Append(rT & endTable & dT & rT)
        '        End If
        '      End If
        '    End If
        '  End If
        'End If

        miljøtillægpris = 0
        If _DataValues.MiljøTillægOpkræves Then
          If rows(i).Cells("MiljøTillæg").Value > 0 Then
            sHTML.Append(Tr)
            sHTML.Append("<td width=" & """100%""" & ">")
            sHTML.Append(beginTable & Tr)
            sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Miljøtillæg" & oFo & dT)
            If rows(i).Cells("Ejerforhold").Value = "North Media" Then
              sHTML.Append("<TD width=" & """20%""" & ">0,06" & dT)
              sHTML.Append("<TD width=" & """25%""" & ">0,06x" & antalmm.ToString("#,###") & dT)
              miljøtillægpris = antalmm * 0.06
            Else
              sHTML.Append("<TD width=" & """20%""" & ">" & _anvendtMiljøTillæg.ToString("0.00") & dT)
              sHTML.Append("<TD width=" & """25%""" & ">" & _anvendtMiljøTillæg.ToString("0.00") & "x" & antalmm.ToString("#,###") & dT)
              miljøtillægpris = antalmm * _anvendtMiljøTillæg
            End If
            sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & miljøtillægpris.ToString("#,##0.00") & dT)
            sHTML.Append(rT & endTable & dT & rT)
          End If
        End If
        sHTML.Append(Tr)
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable & Tr)
        sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Sikkerhedsgodtgørelse " & oFo & dT)
        If _DataValues.SikkerhedsGodtgørelse Then
          sHTML.Append("<TD width=" & """20%""" & ">" & "1%" & dT)
          godtpris = mmpris - mmrabatpris + farvepris - farverabatpris + webtillægpris + miljøtillægpris
          sHTML.Append("<TD width=" & """25%""" & ">" & "1% af " & godtpris.ToString("#,##0.00") & dT)
          sikpris = godtpris / 100
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & sikpris.ToString("-#,##0.00") & dT)
        Else
          sHTML.Append("<TD width=" & """20%""" & ">" & nb & dT)
          sHTML.Append("<TD width=" & """25%""" & ">" & nb & dT)
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & nb & dT)
        End If
        sHTML.Append(rT & endTable & dT & rT)

        sHTML.Append(Tr)
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable & Tr)
        sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Informationsgodtgørelse " + oFo & dT)
        If _DataValues.InfoGodtgørelse Then
          sHTML.Append("<TD width=" & """20%""" & ">" & "1%" & dT)
          godtpris = mmpris - mmrabatpris + farvepris - farverabatpris + webtillægpris + miljøtillægpris
          sHTML.Append("<TD width=" & """25%""" & ">" & "1% af " & godtpris.ToString("#,##0.00") & dT)
          infpris = godtpris / 100
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & infpris.ToString("-#,##0.00") & dT)
        Else
          sHTML.Append("<TD width=" & """20%""" & ">" & nb & dT)
          sHTML.Append("<TD width=" & """25%""" & ">" & nb & dT)
          sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & nb & dT)
        End If
        sHTML.Append(rT & endTable & dT & rT)

        sHTML.Append(Tr)
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable & Tr)
        sHTML.Append("<td colspan=" & """4""" & ">" & nb & dT)
        sHTML.Append(rT)

        momsbeløb = mmpris - mmrabatpris + farvepris - farverabatpris + webtillægpris + miljøtillægpris - sikpris - infpris
        sHTML.Append(Tr)

        sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Momspligtigt beløb" & oFo & dT)
        sHTML.Append("<TD width=" & """20%""" & ">" & nb & dT)
        sHTML.Append("<TD width=" & """25%""" & ">" & nb & dT)
        sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & momsbeløb.ToString("#,##0.00") & dT)
        sHTML.Append(rT & endTable & dT & rT)

        sHTML.Append(Tr)
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable & Tr)
        sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Momssats" + oFo & dT)
        sHTML.Append("<TD width=" & """20%""" & ">25%" & dT)
        sHTML.Append("<TD width=" & """25%""" & ">" & "25% af " & momsbeløb.ToString("#,##0.00") & dT)
        moms = momsbeløb.ToString("#,##0.00") * 25 / 100
        sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & ">" & moms.ToString("#,##0.00") & dT)
        sHTML.Append(rT & endTable & dT & rT)

        sHTML.Append(Tr)
        sHTML.Append("<td width=" & """100%""" & ">")
        sHTML.Append(beginTable & Tr)
        sHTML.Append("<td colspan=" & """4""" & ">" & nb & dT)
        sHTML.Append(rT)
        sHTML.Append(Tr)

        sHTML.Append("<TD width=" & """40%""" & ">" & Fo & "Total" & oFo & dT)
        sHTML.Append("<TD width=" & """20%""" & ">" & nb & dT)
        sHTML.Append("<TD width=" & """25%""" & ">" & momsbeløb.ToString("#,##0.00") & "+" & moms.ToString("#,##0.00") & dT)
        total = momsbeløb + moms
        If total < 1 Then total = 0
        sHTML.Append("<TD width=" & """15%""" & " align=" & """right""" & "><U>" & Bo & total.ToString("#,##0.00") & oB & "</U>" & dT)
        sHTML.Append(rT & endTable & dT & rT)
        sHTML.Append("</table>")
        cm.CommandText = "UPDATE tblMedieplanLinjer SET TotalPris = @TotalPris WHERE (MedieplanNr = " & _medieplanNr & ") AND (Version = " & _version & ") AND (UgeavisID = " & rows(i).Cells("UgeavisID").Value & ")"
        cm.Parameters("@TotalPris").Value = total
        cm.ExecuteNonQuery()
        gruppeTotal = gruppeTotal + total
      End If
    Next i
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    If erGruppe Then
      sHTML.Append(Br & Br & Br & "Samlet Total = " & gruppeTotal.ToString("#,##0.00"))
    End If
    sHTML.Append("</body></html>")

    If Not _IsGenberegning Then
      Dim htmlFile As String = sHTML.ToString 'convertDanishHTML(sHTML.ToString)
      Directory.CreateDirectory("Z:\" & frmMain.BrugerNavn & "\" & _medieplanNr.ToString)
      Dim myFile As New StreamWriter("Z:\" & frmMain.BrugerNavn & "\" & _medieplanNr.ToString & "\" & fjernUlovligeTegnFraString(filNavn) & ".html")
      myFile.WriteLine(htmlFile)
      myFile.Close()
      Dim mailModtager As String = ""

      If erGruppe Then
        Dim gruppeFundet As Boolean = False
        For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe)
          If SendeGruppe = _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Navn Then
            If _gruppeVersion(_brugtGruppeVersion)._gruppe(i).OrdreModtager.Length > 0 Then
              mailModtager = _gruppeVersion(_brugtGruppeVersion)._gruppe(i).OrdreModtager
            Else
              MessageBox.Show("Kan ikke finde email for gruppen " & _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Navn, "Mangler email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            gruppeFundet = True
            Exit For
          End If
        Next
        If Not gruppeFundet Then MessageBox.Show("Kan ikke finde data for gruppen " & SendeGruppe, "Gruppe ikke fundet", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Else
        If row.Cells("eMail").Value <> "" Then
          mailModtager = row.Cells("eMail").Value
        Else
          MessageBox.Show("Mangler email til " & row.Cells("UgeavisID").Text, "Mangler eMail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
      End If
      If mailModtager.Length > 0 Then
        modtagere = Split(mailModtager, ";")
        For j = 0 To UBound(modtagere)
          Dim mail As New clsEmail
          mail.Til = modtagere(j) ' mailModtager
          mail.Subject = _medieplanNr.ToString & " " & filNavn & " Uge " & _DataValues.IndrykningsUge
          mail.From = frmMain.BrugerEmail
          '     mail.BodyMappe = "Z:\" & frmMain.BrugerNavn & "\" & _medieplanNr.ToString
          '     mail.BodyFilNavn = "AnnonceeMail " & fjernUlovligeTegnFraString(filNavn)
          mail.VedhæftetFilSti = "Z:\" & frmMain.BrugerNavn & "\" & _medieplanNr.ToString & "\" & fjernUlovligeTegnFraString(filNavn) & ".html"
          mail.Body = ""
          mail.Send()
        Next j
      End If
    End If
  End Sub

  Private Function bladRettelse(ByVal row As UltraGridRow) As String
    Dim rettelse As String = ""
    Dim newMmPris As Double = (Int(row.Cells("New MmPris").Value * 100)) / 100
    Dim oldMmPris As Double = (Int(row.Cells("Old MmPris").Value * 100)) / 100
    Dim newMmRabat As Double = (Int(row.Cells("New MmRabat").Value * 100)) / 100
    Dim oldMmRabat As Double = (Int(row.Cells("Old MmRabat").Value * 100)) / 100
    Dim newFarvePris As Double = (Int(row.Cells("New FarvePris").Value * 100)) / 100
    Dim oldFarvePris As Double = (Int(row.Cells("Old FarvePris").Value * 100)) / 100
    Dim newFarveRabat As Double = (Int(row.Cells("New FarveRabat").Value * 100)) / 100
    Dim oldFarveRabat As Double = (Int(row.Cells("Old FarveRabat").Value * 100)) / 100

    If newMmPris <> oldMmPris Then rettelse = rettelse + "Mm. pris er ændret fra " & oldMmPris & " til " & newMmPris & ". "
    If newMmRabat <> oldMmRabat Then rettelse = rettelse + "Mm. rabat er ændret fra " & oldMmRabat & " til " & newMmRabat & ". "
    If _DataValues.AntalFarver > 0 AndAlso newFarvePris <> oldFarvePris Then rettelse = rettelse + "Farve pris er ændret fra " & oldFarvePris & " til " & newFarvePris & ". "
    If _DataValues.AntalFarver > 0 AndAlso newFarveRabat <> oldFarveRabat Then rettelse = rettelse + "Farve rabat er ændret fra " & oldFarveRabat & " til " & newFarveRabat & ". "
    If row.Cells("RowState").Value = "Added" Then rettelse = "Tilføjet. "
    If row.Cells("RowState").Value = "Deleted" Then rettelse = "Fjernet. "
    Return rettelse
  End Function

  Private Sub btnKopierTilNy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKopierTilNy.Click
    Dim nyFrmKopierTilNy As New frmKopierTilNy(_modul, _DataValues.BemærkningTilUgeavis, _anvendtMiljøTillæg)

    If nyFrmKopierTilNy.ShowDialog() = Windows.Forms.DialogResult.OK Then
      Me.Cursor = Cursors.WaitCursor
      LockControls(False)
      _brugtGruppeVersion = frmMain.AktivGruppeVersion
      DataSourceMedieplan.BrugtGruppeVersion = frmMain.AktivGruppeVersion
      If nyFrmKopierTilNy.Genberegn Then
        DataSourceMedieplan.ResetData(False, nyFrmKopierTilNy.NulstilBureauOrdreNr)
      Else
        DataSourceMedieplan.ResetData(True, nyFrmKopierTilNy.NulstilBureauOrdreNr)
      End If
      If nyFrmKopierTilNy.NulstilBureauOrdreNr Then txtFællesBureauOrdreNr.Text = ""
      If Not nyFrmKopierTilNy.MedtagBemærkning Then
        txtBemærkningTilUgeavis.Text = ""
        _DataValues.BemærkningTilUgeavis = ""
      End If
      txtBemærkningTilAnnoncør.Text = ""
      _DataValues.BemærkningTilAnnoncør = ""
      If Not nyFrmKopierTilNy.BeholdMiljøTillæg Then
        _anvendtMiljøTillæg = frmMain.AktivMiljøTillæg
        _DataValues.OprindeligtMiljøTillæg = _anvendtMiljøTillæg
        DataSourceMedieplan.AnvendtMiljøTillæg = _anvendtMiljøTillæg
      End If
      _medieplanNr = 0
      DataSourceMedieplan.MedieplanNr = 0
      'Nu kan hakket fjernes i materiale modtaget uden at der opdateres forkert i db
      chkMaterialeModtaget.Checked = False
      LukForFakturaRettelser()
      grdOrdreLinjer.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
      grdOrdreLinjer.DisplayLayout.Override.AllowDelete = DefaultableBoolean.True
      grdOrdreLinjer.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        arow.Cells("UgeavisID").Appearance.ForeColorDisabled = Color.Black
        arow.Activation = Activation.AllowEdit
      Next
      _version = 0
      DataSourceMedieplan.Version = 0
      _aktivVersion = 0
      _IsAktiv = True
      numIndrykningsÅr.Value = frmMain.DetteÅr
      If _modul = "Booking" Then
        If nyFrmKopierTilNy.ÅbenIModul = "Medieplan" Then
          _status = StatusKoder.stsNyMedieplan
          DataSourceMedieplan.Status = StatusKoder.stsNyMedieplan
          _modul = "Medieplan"
          frmMain.AktivtModul = "Medieplan"
          _DataValues.Modul = _modul
          DataSourceMedieplan.Modul = _modul
          picPipeline.Image = My.Resources.MedieplanHeader
          For Each ctrl As Control In grpMedieplanHoved.Controls
            If ctrl.Tag = "Toggle" Then ctrl.Visible = Not ctrl.Visible
          Next
          lblFællesBureauOrdreNr.Visible = False
          txtFællesBureauOrdreNr.Visible = False
          btnMateriale.Visible = False
          lblMatFraUge.Visible = False
          txtBrugMaterialeFraUge.Visible = False
          txtMaterialeFølgerFraLeverandør.Visible = False
          optSammeMateriale.Visible = True
          lblBemærkningTilAnnoncør.Visible = True
          txtBemærkningTilAnnoncør.Visible = True
        Else
          picPipeline.Image = My.Resources.BookingHeader
          _status = StatusKoder.stsOrdreIkkeSendt
          DataSourceMedieplan.Status = StatusKoder.stsOrdreIkkeSendt
        End If
      ElseIf _modul = "Medieplan" Then
        _status = StatusKoder.stsNyMedieplan
        DataSourceMedieplan.Status = StatusKoder.stsNyMedieplan
      Else 'modul = fakturering
        If nyFrmKopierTilNy.ÅbenIModul = "Booking" Then
          picPipeline.Image = My.Resources.BookingHeader
          For Each ctrl As Control In grpMedieplanHoved.Controls
            If ctrl.Tag = "Toggle" Then ctrl.Visible = Not ctrl.Visible
          Next
          _modul = "Booking"
          frmMain.AktivtModul = "Booking"
          _DataValues.Modul = _modul
          DataSourceMedieplan.Modul = _modul
          _status = StatusKoder.stsOrdreIkkeSendt
          DataSourceMedieplan.Status = StatusKoder.stsOrdreIkkeSendt
          txtBeskrivelse.Visible = False
          lblBeskrivelse.Visible = False
          lblBemærkningTilAnnoncør.Visible = False
          txtBemærkningTilAnnoncør.Visible = False
        Else
          _status = StatusKoder.stsNyMedieplan
          DataSourceMedieplan.Status = StatusKoder.stsNyMedieplan
          _modul = "Medieplan"
          frmMain.AktivtModul = "Medieplan"
          _DataValues.Modul = _modul
          DataSourceMedieplan.Modul = _modul
          picPipeline.Image = My.Resources.MedieplanHeader
          btnMateriale.Visible = False
          lblMatFraUge.Visible = False
          txtBrugMaterialeFraUge.Visible = False
          txtMaterialeFølgerFraLeverandør.Visible = False
          optSammeMateriale.Visible = True
          lblBemærkningTilAnnoncør.Visible = True
          txtBemærkningTilAnnoncør.Visible = True
        End If
      End If
      setStatus(_status)
      txtHistorik.Text = ""
      btnHistorik.Visible = False
      txtHistorik.Visible = False
      _DataValues.Beskrivelse = ""
      lblMedieplanNr.Text = getMedieplanString(_medieplanNr, _version)
      Me.Text = "P: Ny"
      Me.Cursor = Cursors.Default
    End If
    ÅbneLukkeBureauOrdreNr()
    If _DataValues.SammeBureauOrdreNr Then
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden = True
    Else
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("New BureauOrdreNr").Hidden = False
    End If
    'chkWebTillægOpkræves.Checked = True
    '_DataValues.WebTillægOpkræves = chkWebTillægOpkræves.Checked
    chkMiljøTillægOpkræves.Checked = True
    _DataValues.MiljøTillægOpkræves = chkMiljøTillægOpkræves.Checked
    clbMiljøTillægOpkræves.SetItemChecked(0, True)
    _DataValues.OpkrævJyskeMiljøTillæg = True
    DataSourceMedieplan.OpkrævJyskeMiljøTillæg = True
    clbMiljøTillægOpkræves.SetItemChecked(1, True)
    _DataValues.OpkrævFynskeMiljøTillæg = True
    DataSourceMedieplan.OpkrævFynskeMiljøTillæg = True
    clbMiljøTillægOpkræves.SetItemChecked(2, True)
    _DataValues.OpkrævNorthMiljøTillæg = True
    DataSourceMedieplan.OpkrævNorthMiljøTillæg = True
    clbMiljøTillægOpkræves.SetItemChecked(3, True)
    _DataValues.OpkrævDSVPMiljøTillæg = True
    DataSourceMedieplan.OpkrævDSVPMiljøTillæg = True
    clbMiljøTillægOpkræves.SetItemChecked(4, True)
    _DataValues.OpkrævJyskeMedierASTillæg = True
    DataSourceMedieplan.OpkrævJyskeMedierASTillæg = True
    setStatus(_status)
    nyFrmKopierTilNy.Close()
    nyFrmKopierTilNy.Dispose()
  End Sub

  Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
    Timer.Enabled = False
    grdOrdreLinjer.ActiveRow = _activeRow
    grdOrdreLinjer.ActiveCell = _activeCell
    grdOrdreLinjer.PerformAction(EnterEditMode, False, False)
  End Sub

  Private Sub btnTilBlade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTilBlade.Click
    Dim rowList As New List(Of UltraGridRow)

    Me.Cursor = Cursors.WaitCursor
    For Each arow As UltraGridRow In grdOrdreLinjer.Selected.Rows
      rowList.Add(arow)
    Next

    Dim nyFrmTilBlade As New frmTilBlade(_modul, rowList, _version)

    If nyFrmTilBlade.ShowDialog() = Windows.Forms.DialogResult.OK Then
      If _modul = "Medieplan" Then
        If nyFrmTilBlade.UdsendelsesType = 0 Then UdsendEmailTilbud(nyFrmTilBlade.Tekst, nyFrmTilBlade.Emne, nyFrmTilBlade.optEmailTilAlle.Value)
        If nyFrmTilBlade.UdsendelsesType = 1 Then UdsendTilbud(nyFrmTilBlade.Tekst)
        'If nyFrmTilBlade.UdsendelsesType = 2 Then OpretForespørgsel(nyFrmTilBlade.AntalIndrykninger, nyFrmTilBlade.SvarDato, nyFrmTilBlade.VisPlaceringUB, nyFrmTilBlade.Tekst, nyFrmTilBlade.Emne)
        If nyFrmTilBlade.UdsendelsesType = 2 Then OpretForespørgsel(nyFrmTilBlade.AntalIndrykninger, nyFrmTilBlade.SvarDato, nyFrmTilBlade.VisPlaceringUB, nyFrmTilBlade.Tekst, nyFrmTilBlade.optEmailTilAlle.Value)
      Else
        If nyFrmTilBlade.UdsendelsesType = 0 Then UdsendEmail(nyFrmTilBlade.Tekst, nyFrmTilBlade.Emne, nyFrmTilBlade.optEmailTilAlle.Value)
        If nyFrmTilBlade.UdsendelsesType = 1 Then UdsendBilagsbladReminder(rowList)
      End If
    End If
    nyFrmTilBlade.Close()
    nyFrmTilBlade.Dispose()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub UdsendEmail(ByVal Tekst As String, ByVal Emne As String, ByVal EmailTilAlle As Boolean)
    Dim rowList As New List(Of UltraGridRow)
    Dim udsendteGrupper As New List(Of String)
    Dim fundetGruppe As Boolean = False
    Dim findGruppe As String

    logTekst = ""
    Me.Cursor = Cursors.WaitCursor
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If EmailTilAlle OrElse arow.Selected Then
        If arow.Cells("SendeGruppe").Value = "" AndAlso arow.Cells("RowState").Value <> "Deleted" Then
          rowList.Clear()
          rowList.Add(arow)
          SendEmail(rowList, Tekst, Emne)
        End If
      End If
    Next
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If EmailTilAlle OrElse arow.Selected Then
        If arow.Cells("SendeGruppe").Value <> "" AndAlso arow.Cells("RowState").Value <> "Deleted" Then
          findGruppe = arow.Cells("SendeGruppe").Value
          fundetGruppe = False
          For Each gruppe As String In udsendteGrupper
            If gruppe = findGruppe Then
              fundetGruppe = True
            End If
          Next
          If Not fundetGruppe Then
            udsendteGrupper.Add(findGruppe)
            rowList.Clear()
            For Each brow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
              If brow.Cells("SendeGruppe").Value = findGruppe AndAlso brow.Cells("RowState").Value <> "Deleted" Then
                rowList.Add(brow)
              End If
            Next
            SendEmail(rowList, Tekst, Emne)
          End If
        End If
      End If
    Next
    Me.Cursor = Cursors.Default
    MessageBox.Show(logTekst, "Email udsendt", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub SendEmail(ByVal rows As List(Of UltraGridRow), ByVal Tekst As String, ByVal Emne As String)
    Dim erGruppe As Boolean = rows.Count > 1 'Hvis det er gruppe er der flere rækker
    Dim mailModtager As String = ""
    Dim i As Integer
    Dim SendeGruppe As String = rows(0).Cells("SendeGruppe").Value
    Dim row As UltraGridRow = rows(0)
    Dim succes As Boolean = False

    If erGruppe Then
      Dim gruppeFundet As Boolean = False
      For i = 1 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe)
        If SendeGruppe = _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Navn Then
          If _gruppeVersion(_brugtGruppeVersion)._gruppe(i).OrdreModtager.Length > 0 Then
            mailModtager = _gruppeVersion(_brugtGruppeVersion)._gruppe(i).OrdreModtager
          Else
            MessageBox.Show("Kan ikke finde email for gruppen " & _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Navn, "Mangler email", MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If
          gruppeFundet = True
          Exit For
        End If
      Next
      If Not gruppeFundet Then MessageBox.Show("Kan ikke finde data for gruppen " & SendeGruppe, "Gruppe ikke fundet", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Else
      If row.Cells("eMail").Value <> "" Then
        mailModtager = row.Cells("eMail").Value
      Else
        MessageBox.Show("Mangler email til " & row.Cells("UgeavisID").Text, "Mangler eMail", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    End If
    If mailModtager.Length > 0 Then
      Dim mail As New clsEmail
      mail.Til = mailModtager
      mail.Subject = Emne
      mail.From = frmMain.BrugerEmail
      mail.BodyMappe = "Z:\Forsendelser\Email\" & _medieplanNr.ToString
      If erGruppe Then
        mail.BodyFilNavn = Trim(SendeGruppe) & " [" & mailModtager & "]"
      Else
        mail.BodyFilNavn = Trim(row.Cells("UgeavisID").Text) & " [" & mailModtager & "]"
      End If
      mail.Body = Tekst
      succes = mail.Send()
      If succes Then
        If erGruppe Then
          logTekst = logTekst + "Email sendt til " & Trim(SendeGruppe) & " [" & mailModtager & "]" & vbCrLf
        Else
          logTekst = logTekst + "Email sendt til " & Trim(row.Cells("UgeavisID").Text) & " [" & mailModtager & "]" & vbCrLf
        End If
      Else
        If erGruppe Then
          logTekst = logTekst + "Email IKKE sendt til " & Trim(SendeGruppe) & " [" & mailModtager & "]" & vbCrLf
        Else
          logTekst = logTekst + "Email IKKE sendt til " & Trim(row.Cells("UgeavisID").Text) & " [" & mailModtager & "]" & vbCrLf
        End If
      End If
    End If
  End Sub

  Private Sub UdsendEmailTilbud(ByVal Tekst As String, ByVal Emne As String, ByVal EmailTilAlle As Boolean)
    Dim modtager() As String
    Dim j As Integer
    Dim succes As Boolean = False
    Dim mappe As String

    logTekst = ""
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If EmailTilAlle OrElse arow.Selected Then
        If arow.Cells("PrisforespørgselEmails").Value <> "" Then
          modtager = Split(arow.Cells("PrisforespørgselEmails").Value, ";")
          For j = 0 To UBound(modtager)
            If modtager(j) <> "" Then
              Dim mail As New clsEmail

              mail.Subject = "Vedr. " & _DataValues.AnnoncørNavn & " i " & arow.Cells("UgeavisID").Text & "  " & Emne
              mail.Til = modtager(j)
              mail.BodyTitle = Emne
              mail.Body = Tekst
              mappe = Replace(_DataValues.AnnoncørNavn, "/", "-")

              mail.BodyMappe = "Z:\Forsendelser\eMailTilbud\" & Replace(mappe, "\", "-") & "\" & _medieplanNr
              mail.BodyFilNavn = Trim(arow.Cells("UgeavisID").Text) & " [" & modtager(j) & "]"
              mail.From = frmMain.BrugerEmail
              succes = mail.Send()
              If succes Then
                logTekst = logTekst + "Email sendt til " & arow.Cells("UgeavisID").Text & " på email : " & modtager(j) & vbCrLf
              Else
                logTekst = logTekst + "Email ikke sendt til " & arow.Cells("UgeavisID").Text & " Ukendt fejl!" & vbCrLf
              End If
            End If
          Next j
        Else
          logTekst = logTekst + "Email ikke sendt til " & arow.Cells("UgeavisID").Text & " Email mangler!" & vbCrLf
        End If
      End If
    Next
    MessageBox.Show(logTekst, "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub


  Private Sub UdsendTilbud(ByVal Tekst As String)
    Dim modtager() As String
    Dim j As Integer
    Dim sendHTML As New StringBuilder(500)
    Dim succes As Boolean = False
    Dim mmPris As Double
    Dim mmRabat As Double
    Dim farvePris As Double
    Dim farveRabat As Double
    Dim mappe As String

    logTekst = ""
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If arow.Cells("PrisforespørgselEmails").Value <> "" Then
        modtager = Split(arow.Cells("PrisforespørgselEmails").Value, ";")
        For j = 0 To UBound(modtager)
          If modtager(j) <> "" Then
            Dim mail As New clsEmail

            mail.Subject = "Orientering vedr. " & _DataValues.AnnoncørNavn & " i " & arow.Cells("UgeavisID").Text
            mail.Til = modtager(j)
            sendHTML.Remove(0, sendHTML.Length)
            mail.BodyTitle = "DLU afgivet tilbud."
            sendHTML.Append("<B>DLU har afgivet følgende tilbud:</b><br>")
            sendHTML.Append("<TABLE cellspacing=""0"" cellpadding=""0"" width=""90%"" border=""0"">")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.Append("<TD width=""15%"">Annoncør</TD>")
            sendHTML.AppendFormat("<TD width=""85%"">{0}</TD>", _DataValues.AnnoncørNavn)
            sendHTML.Append("</TR>")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.Append("<TD>Mediebureau</TD>")
            sendHTML.AppendFormat("<TD>{0}</TD>", _DataValues.BureauNavn)
            sendHTML.Append("</TR>")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.Append("<TD>Format</TD>")
            sendHTML.AppendFormat("<TD>{0}x{1}</TD>", _DataValues.Format1, _DataValues.Format2)
            sendHTML.Append("</TR>")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.Append("<TD>Farver</TD>")
            sendHTML.AppendFormat("<TD>{0}</TD>", _DataValues.AntalFarver)
            sendHTML.Append("</TR>")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.Append("<TD>Placering</TD>")
            sendHTML.AppendFormat("<TD>{0}</TD>", cboPlaceringID.Text)
            sendHTML.Append("</TR>")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.Append("<TD><BR></TD>")
            sendHTML.Append("<TD></TD>")
            sendHTML.Append("</TR>")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.Append("<TD>Bemærkning</TD>")
            sendHTML.AppendFormat("<TD>{0}</TD>", Tekst)
            sendHTML.Append("</TR>")
            sendHTML.Append("</TABLE>")
            sendHTML.Append("<BR><BR>")
            sendHTML.Append("<TABLE cellpadding=""0"" cellspacing=""0"" border=""0"" width=""60%"">")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.Append("<TD width=""32%""><B>Tilbud</B></TD>")
            sendHTML.Append("<TD width=""17%""><B>kr./mm</B></TD>")
            sendHTML.Append("<TD width=""17%""><B>rabat</B></TD>")
            sendHTML.Append("<TD width=""17%""><B>farvetillæg</B></TD>")
            sendHTML.Append("<TD width=""17%""><B>rabat</B></TD>")
            sendHTML.Append("</TR>")
            sendHTML.Append("<TR valign=""top"">")
            sendHTML.AppendFormat("<TD>{0}</TD>", arow.Cells("UgeavisID").Text)
            mmPris = arow.Cells("New MmPris").Value
            sendHTML.AppendFormat("<TD>{0}</TD>", mmPris.ToString("#0.00"))
            mmRabat = arow.Cells("New MmRabat").Value
            sendHTML.AppendFormat("<TD>{0}</TD>", mmRabat.ToString("#0.00"))
            farvePris = arow.Cells("New FarvePris").Value
            sendHTML.AppendFormat("<TD>{0}</TD>", farvePris.ToString("#,##0.00"))
            farveRabat = arow.Cells("New FarveRabat").Value
            sendHTML.AppendFormat("<TD>{0}</TD>", farveRabat.ToString("#0.00"))
            sendHTML.Append("</TR>")
            sendHTML.Append("</TABLE>")
            sendHTML.Append("<BR>")

            mail.Body = sendHTML.ToString  'convertDanishHTML(sendHTML)

            mappe = Replace(_DataValues.AnnoncørNavn, "/", "-")

            mail.BodyMappe = "Z:\Forsendelser\OrienteringOmTilbud\" & Replace(mappe, "\", "-") & "\" & _medieplanNr
            mail.BodyFilNavn = Trim(arow.Cells("UgeavisID").Text) & " [" & modtager(j) & "]"
            mail.From = frmMain.BrugerEmail
            succes = mail.Send()
            If succes Then
              logTekst = logTekst + "Tilbud sendt til " & arow.Cells("UgeavisID").Text & " på email : " & modtager(j) & vbCrLf
            Else
              logTekst = logTekst + "Tilbud ikke sendt til " & arow.Cells("UgeavisID").Text & " Ukendt fejl!" & vbCrLf
            End If
          End If
        Next j
      Else
        logTekst = logTekst + "Tilbud ikke sendt til " & arow.Cells("UgeavisID").Text & " Email mangler!" & vbCrLf
      End If
    Next
    MessageBox.Show(logTekst, "Tilbud", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub OpretForespørgsel(ByVal AntalIndrykninger As Integer, ByVal SvarInden As Date, ByVal VisPlaceringUB As Boolean, ByVal Tekst As String, ByVal EmailTilAlle As Boolean)
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim cm2 As SqlCommand = cn.CreateCommand
    Dim forespørgselID As Integer
    Dim modtager() As String
    Dim personID As Integer
    Dim j As Integer
    Dim sendHTML As String
    Dim queryStr As String
    Dim succes As Boolean = False
    Dim emne As String

    logTekst = ""
    cn.Open()
    cm.CommandText = "OpretForespørgsel"
    cm.CommandType = CommandType.StoredProcedure
    cm2.CommandType = CommandType.Text
    cm.Parameters.AddWithValue("@Type", 1)
    cm.Parameters.AddWithValue("@MedieplanNr", _medieplanNr)
    cm.Parameters.AddWithValue("@AnnoncørNo_", _DataValues.AnnoncørNO_)
    cm.Parameters.AddWithValue("@Mediebureau", cboBureauNO_.Text)
    cm.Parameters.AddWithValue("@KonsulentCode", frmMain.BrugerNavn)
    cm.Parameters.AddWithValue("@AntalBlade", grdOrdreLinjer.Rows.SummaryValues("Aviser").Value)
    cm.Parameters.AddWithValue("@Format", _DataValues.Format1 & " X " & _DataValues.Format2)
    cm.Parameters.AddWithValue("@AntalFarver", _DataValues.AntalFarver)
    cm.Parameters.AddWithValue("@PlaceringID", _DataValues.PlaceringID)
    cm.Parameters.AddWithValue("@AntalIndrykninger", AntalIndrykninger)
    cm.Parameters.AddWithValue("@SvarInden", SvarInden)
    cm.Parameters.AddWithValue("@Bemærkning", Tekst)
    cm.Parameters.AddWithValue("@VisPlaceringUB", VisPlaceringUB)

    forespørgselID = cm.ExecuteScalar

    cm.CommandText = "OpretForespørgselsLinjer"
    cm.Parameters.Clear()
    cm.Parameters.Add("@ForespørgselID", SqlDbType.Int)
    cm.Parameters.Add("@BladID", SqlDbType.Int)
    cm.Parameters.Add("@DLUMmPris", SqlDbType.Money)
    cm.Parameters.Add("@DLUMmRabat", SqlDbType.Float)
    cm.Parameters.Add("@DLUFarveTillæg", SqlDbType.Money)
    cm.Parameters.Add("@DLUFarveRabat", SqlDbType.Float)

    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If EmailTilAlle OrElse arow.Selected Then
        If arow.Cells("PrisforespørgselEmails").Value <> "" Then
          cm.Parameters("@ForespørgselID").Value = forespørgselID
          cm.Parameters("@BladID").Value = arow.Cells("UgeavisID").Value
          cm.Parameters("@DLUMmPris").Value = arow.Cells("New MmPris").Value
          cm.Parameters("@DLUMmRabat").Value = arow.Cells("New MmRabat").Value
          cm.Parameters("@DLUFarveTillæg").Value = arow.Cells("New FarvePris").Value
          cm.Parameters("@DLUFarveRabat").Value = arow.Cells("New FarveRabat").Value
          cm.ExecuteNonQuery()

          modtager = Split(arow.Cells("PrisforespørgselEmails").Value, ";")
          For j = 0 To UBound(modtager)
            personID = 0
            If modtager(j) <> "" Then
              cm2.CommandText = "SELECT PersonID FROM tblWEBeMails WHERE eMail = '" & modtager(j) & "'"
              personID = cm2.ExecuteScalar
              If personID = 0 Then
                cm2.CommandText = "INSERT INTO tblWEBeMails (eMail, PersonNavn) VALUES ('" & modtager(j) & "', N'')"
                cm2.ExecuteNonQuery()
                cm2.CommandText = "SELECT PersonID FROM tblWEBeMails WHERE eMail = '" & modtager(j) & "'"
                personID = cm2.ExecuteScalar
              End If
              Dim mail As New clsEmail
              emne = "Prisforespørgsel for " & _DataValues.AnnoncørNavn & " i " & Trim(arow.Cells("UgeavisID").Text) & " Uge " & _DataValues.IndrykningsUge & "-" & _DataValues.IndrykningsÅr
              If emne.Length > 100 Then
                mail.Subject = emne.Substring(0, 100)
              Else
                mail.Subject = emne
              End If

              mail.Til = modtager(j)
              '        sendHTML = "<html><head><META http-equiv=" + Chr(34) + "Content-Type" + Chr(34) + " content=" + Chr(34) + "text/html; charset=windows-1250" + Chr(34) + ">"
              mail.BodyTitle = "Prisforespørgsel fra DLU."
              sendHTML = "<center><B><big><u>Prisforespørgsel fra DLU.</u></big></B></center><br><br>"
              sendHTML = sendHTML + "Besvares senest " & SvarInden.ToString("dddd \d. dd. MMMM yyyy kl. HH:mm") + "<br>"
              'If Emne <> "" Then
              '  sendHTML = sendHTML + "<Br><i>" + Emne + "</i><br>"
              'End If
              If Tekst <> "" Then
                sendHTML = sendHTML + Replace(Tekst, vbCrLf, "<br>") + "<BR>"
              End If
              '         navn = gBlade(i).strBladNavn
              sendHTML = sendHTML + "<br><h3>Link:</h3>"
              queryStr = "http://www.DiMP.dk/PF.aspx?Query=" & arow.Cells("UgeavisID").Value & "*" & BeregnWebChecksum(arow.Cells("UgeavisID").Text) & "*" & forespørgselID & "*" & personID
              sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">" & queryStr & "</A><br>"
              sendHTML = sendHTML + "<h4>Alternativt Link:</h4>"
              sendHTML = sendHTML + "<small>Prøv dette link, hvis ikke det første virker.</small><br>"
              sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">Klik på dette Link.</A><br><br>"
              sendHTML = sendHTML + "<b><i>Hvis du ikke kan komme ind på siden, eller den melder en fejl, så læs dette:</i></b><br>"
              sendHTML = sendHTML + "Kopier linjen herunder og indsæt det i adresselinjen på din browser.<br><br>"
              sendHTML = sendHTML + "http://www.DiMP.dk/PF.aspx?Query=" & arow.Cells("UgeavisID").Value & "*" & BeregnWebChecksum(arow.Cells("UgeavisID").Text) & "*" & forespørgselID & "*" & personID & "<br>"
              sendHTML = sendHTML + "<BR>Med venlig hilsen<BR>" & frmMain.BrugerFuldeNavn & "<BR>"
              'sendHTML = sendHTML + "De Lokale Ugeaviser - " & String.Format(frmMain.BrugerTlf, "## ## ## ##")

              mail.Body = sendHTML 'convertDanishHTML(sendHTML)
              mail.BodyMappe = "Z:\Forsendelser\Forespørgsler\" & _medieplanNr
              mail.BodyFilNavn = Trim(arow.Cells("UgeavisID").Text) & " [" & modtager(j) & "]"
              mail.From = frmMain.BrugerEmail
              succes = mail.Send()
              If succes Then
                logTekst = logTekst + "Forespørgsel sendt til " & arow.Cells("UgeavisID").Text & " på email : " & modtager(j) & vbCrLf
              Else
                logTekst = logTekst + "Forespørgsel ikke sendt til " & arow.Cells("UgeavisID").Text & " Ukendt fejl!" & vbCrLf
              End If
            End If
          Next j
        Else
          logTekst = logTekst + "Forespørgsel ikke sendt til " & arow.Cells("UgeavisID").Text & " Email mangler!" & vbCrLf
        End If
      End If
    Next
    cn.Close()
    cm.Dispose()
    cm2.Dispose()
    cn.Dispose()
    MessageBox.Show(logTekst, "Forespørgsel", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub UdsendBilagsbladReminder(ByVal rows As List(Of UltraGridRow))
    Dim i As Integer
    Dim j As Integer
    Dim mailModtager As String
    Dim succes As Boolean = False
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim antalRemindere As Integer
    Dim sendHTML As String
    Dim first As Boolean
    Dim Modtagere() As String

    logTekst = ""
    cn.Open()
    cm.CommandType = CommandType.Text
    For i = 0 To rows.Count - 1
      first = True
      Modtagere = Split(rows(i).Cells("eMail").Value, ";")
      cm.CommandText = "SELECT AntalRemindere FROM tblRemindereSendt WHERE (ReminderType = 1) AND (MedieplanNr = " & _medieplanNr & ") AND (UgeavisID = " & rows(i).Cells("UgeavisID").Value & ")"
      antalRemindere = cm.ExecuteScalar
      For j = 0 To UBound(Modtagere)
        mailModtager = Modtagere(j)
        Dim mail As New clsEmail
        mail.Til = mailModtager
        mail.Subject = "Reminder! " & rows(i).Cells("UgeavisID").Text & " mangler at sende bilagsblad til ordre nr.:" & _medieplanNr
        mail.From = frmMain.BrugerEmail
        mail.BodyMappe = "Z:\Forsendelser\BilagsbladRemindere\" & _medieplanNr.ToString
        mail.BodyFilNavn = rows(i).Cells("UgeavisID").Text & " [" & mailModtager & "]"
        sendHTML = "Vi har modtaget henvendelse fra <b>"
        If _DataValues.BilagsBladeTil = 1 Then
          sendHTML = sendHTML + _DataValues.AnnoncørNavn
        ElseIf _DataValues.BilagsBladeTil = 2 Then
          Select Case Trim(_DataValues.BureauNO_)
            Case "E00004", "E00005", "E00009", "E00012", "E00848", "E00852", "E01890", "E02220"
              sendHTML = sendHTML + "GroupM"
            Case Else
              sendHTML = sendHTML + _DataValues.BureauNavn
          End Select
        ElseIf _DataValues.BilagsBladeTil = 3 Then
          sendHTML = sendHTML + _DataValues.BilagsBladeTilNavn
        Else
          MessageBox.Show("Bilagsblad modtager ikke valgt!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
          Exit For
        End If
        sendHTML = sendHTML + "</b> om at de endnu ikke har modtaget bilagsblad fra avisen " & rows(i).Cells("UgeavisID").Text & " til ordre nr.: <b>" & _medieplanNr & "</b> i uge <b>" & _DataValues.IndrykningsUge & "</b><br><br>"
        sendHTML = sendHTML + "Det vil vi bede jer om at få gjort hurtigst muligt.<br><br>"
        sendHTML = sendHTML + "Modtagers adresse:<br><b>"
        If _DataValues.BilagsBladeTil = 1 Then
          sendHTML = sendHTML + _DataValues.AnnoncørNavn & "<br>"
          sendHTML = sendHTML + _DataValues.AnnoncørAdresse & "<br>"
          sendHTML = sendHTML + _DataValues.AnnoncørPostNr & " " & _DataValues.AnnoncørPostBy & "<br>"
          sendHTML = sendHTML + "ATT: " & _DataValues.BilagsBladeAtt & "</b><br><br>"
        ElseIf _DataValues.BilagsBladeTil = 2 Then
          Select Case Trim(_DataValues.BureauNO_)
            Case "E00001"
              sendHTML = sendHTML + "Carat Danmark A/S<br>Åboulevarden 20 2.sal<br>8000 Århus C</b><br><br>"
            Case "E00004", "E00005", "E00009", "E00012", "E00848", "E00852", "E01890", "E02220"
              sendHTML = sendHTML + "GroupM<Br>Antonigade 4, 4. sal<Br>1106 København K<br>ATT: Jessie Lund - Annoncekontrol</b><br><br>"
            Case Else
              sendHTML = sendHTML + _DataValues.BureauNavn & "<br>"
              sendHTML = sendHTML + _DataValues.BureauAdresse & "<br>"
              sendHTML = sendHTML + _DataValues.BureauPostNr & " " & _DataValues.BureauPostBy & "<br>"
              sendHTML = sendHTML + "ATT: " & _DataValues.BilagsBladeAtt & "</b><br><br>"
          End Select
        ElseIf _DataValues.BilagsBladeTil = 3 Then
          sendHTML = sendHTML + _DataValues.BilagsBladeTilNavn & "<br>"
          sendHTML = sendHTML + _DataValues.BilagsBladeTilAdresse & "<br>"
          sendHTML = sendHTML + _DataValues.BilagsBladeTilPostNr.ToString & " " & FindPostBy(_DataValues.BilagsBladeTilPostNr) & "<br>"
          sendHTML = sendHTML + "ATT: " & _DataValues.BilagsBladeAtt & "</b><br><br>"
        Else
          MessageBox.Show("Bilagsblad modtager ikke valgt!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
          Exit For
        End If
        sendHTML = sendHTML + "Med venlig hilsen<br>De lokale ugeaviser<br>" & frmMain.BrugerFuldeNavn & "<br>Tlf.: " & frmMain.BrugerTlf
        mail.BodyTitle = "Bilagsblad reminder fra DLU."
        mail.Body = sendHTML
        succes = mail.Send()
        If succes Then
          logTekst = logTekst + "Reminder sendt til " & mailModtager & vbCrLf
          If first Then
            cm.CommandText = "DELETE FROM tblRemindereSendt WHERE (ReminderType = 1) AND (MedieplanNr = " & _medieplanNr & ") AND (UgeavisID = " & rows(i).Cells("UgeavisID").Value & ")"
            cm.ExecuteNonQuery()
            antalRemindere = antalRemindere + 1
            cm.CommandText = "INSERT INTO tblRemindereSendt (MedieplanNr, UgeavisID, ReminderType, AntalRemindere) VALUES (" & _medieplanNr & "," & rows(i).Cells("UgeavisID").Value & ",1," & antalRemindere & ")"
            cm.ExecuteNonQuery()
            first = False
          End If
        Else
          logTekst = logTekst + "Reminder ikke sendt til " & mailModtager & vbCrLf
        End If
      Next
    Next
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    MessageBox.Show(logTekst, "Bilagsblad remindere", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub txtBemærkningTilUgeavis_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBemærkningTilUgeavis.TextChanged
    _DataValues.BemærkningTilUgeavis = txtBemærkningTilUgeavis.Text
  End Sub

  Private Sub txtOverskrift_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOverskrift.TextChanged
    _DataValues.Overskrift = txtOverskrift.Text
  End Sub

  Private Sub btnDækningskort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDækningskort.Click
    If _status = StatusKoder.stsFaktureretOrdre Then 'OrElse _status = StatusKoder.stsUbetaltOrdre Then
      If MessageBox.Show("Er du sikker på at du vil trække denne ordre tilbage?", "Træk tilbage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
        Dim cm As SqlCommand = cn.CreateCommand()
        cn.Open()
        Dim trans As SqlTransaction = cn.BeginTransaction()

        cm.CommandType = CommandType.Text
        cm.Transaction = trans
        Try
          cm.CommandText = "DELETE FROM tblMedieplan WHERE (MedieplanNr = " & _medieplanNr & ") AND (Version = " & _version & ")"
          cm.ExecuteNonQuery()
          cm.CommandText = "DELETE FROM tblOrdreNavision WHERE (OrdreNr = " & _medieplanNr & ") AND (Version = " & _version & ")"
          cm.ExecuteNonQuery()
          'cm.CommandText = "DELETE FROM tblOrdreLinjerNavision WHERE (OrdreNr = " & _medieplanNr & ") AND (Version = " & _version & ")"
          'cm.ExecuteNonQuery()
          'Opdater Version og Status
          cm.CommandText = "UPDATE tblMedieplanNr SET AktivVersion = (AktivVersion / 10), Status = 6 WHERE (MedieplanNr = " & _medieplanNr & ")"
          cm.ExecuteNonQuery()
          trans.Commit()
          MessageBox.Show("Ordren er trukket tilbage.", "Trukket tilbage", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
          trans.Rollback()
          MessageBox.Show("Der opstod en fejl da ordren skulle trækkes tilbage." & vbCrLf & "Fejltekst:" & ex.Message, "Overførsel fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          trans.Dispose()
          cn.Close()
          cm.Dispose()
          cn.Dispose()
        End Try
        Me.Close()
      End If
    Else
      saveXmlFile()
      Dim myProcess As New Process

      myProcess.StartInfo.FileName = "C:\Program Files\DLUAIR\DLUAIR.exe"
      myProcess.StartInfo.Arguments = _medieplanNr.ToString & " " & _version.ToString
      myProcess.Start()
    End If
  End Sub

  Private Sub btnSupportBilag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupportBilag.Click
    VisSupportBilag()
  End Sub

  Private Sub VisSupportBilag()
    frmSupportBilag._år = numIndrykningsÅr.Value
    frmSupportBilag.Annoncør = cboAnnoncørNO_.Text
    frmSupportBilag.MedieplanNr = _medieplanNr.ToString
    frmSupportBilag.Modul = _modul
    frmSupportBilag.chkMaterialeModtaget.Checked = chkMaterialeModtaget.Checked
    frmSupportBilag.SammeMaterialePåMedieplan = optSammeMateriale.Value
    frmSupportBilag.chkKunForhandlerBundForskellig.Checked = chkKunForhandlerBundForskellig.Checked
    frmSupportBilag.ShowDialog()
    SupportBilagDialogSvar = frmSupportBilag.DialogSvar
    If frmSupportBilag.DialogSvar = "Overfør" Then
      If frmSupportBilag.txtUgeNr.TextLength > 0 Then numIndrykningsUge.Value = frmSupportBilag.txtUgeNr.Value
      optMaterialeFølgerFra.Value = frmSupportBilag.optMaterialeFølgerFra.Value
      txtBrugMaterialeFraUge.Text = frmSupportBilag.txtBrugMaterialeFraUge.Text
      txtMaterialeFølgerFraLeverandør.Text = frmSupportBilag.txtMaterialeFølgerFraLeverandør.Text
      'If frmSupportBilag.optSammeMateriale.Value = 1 Then
      '  optSammeMateriale.Value = True
      'Else
      '  optSammeMateriale.Value = False
      'End If
      optSammeMateriale.Value = frmSupportBilag.optSammeMateriale.Value
      chkKunForhandlerBundForskellig.Checked = frmSupportBilag.chkKunForhandlerBundForskellig.Checked
      If frmSupportBilag.chkBladeneSkalFakturere.CheckState = CheckState.Checked Then
        optFakturering.Value = 0
      Else
        optFakturering.Value = 1
      End If
      'If frmSupportBilag.chkBilagsblade.CheckState = CheckState.Checked Then
      '  optBilagsBladeTil.Value = 1
      '  txtBilagsBladeAtt.Text = frmSupportBilag.txtBilagsBladeAtt.Text
      'End If
      txtBemærkningTilUgeavis.Text = frmSupportBilag.txtBemærkningTilUgeaviserne.Text
      txtOverskrift.Text = frmSupportBilag.txtOverskrift.Text
      _IsLoading = True
      optBilagsBladeTil.Value = frmSupportBilag.optBilagsBladeTil.Value
      _IsLoading = False
      txtBilagsBladeAtt.Text = frmSupportBilag.txtBilagsBladeAtt.Text
      _DataValues.BilagsBladeAtt = frmSupportBilag.txtBilagsBladeAtt.Text
      _DataValues.BilagsBladeTilNavn = frmSupportBilag.txtNavn.Text
      _DataValues.BilagsBladeTilAdresse = frmSupportBilag.txtAdresse.Text
      _DataValues.BilagsBladeTilPostNr = frmSupportBilag.txtPostNr.Text
    ElseIf frmSupportBilag.DialogSvar = "Gemt" Then
      If frmSupportBilag.txtUgeNr.TextLength > 0 AndAlso frmSupportBilag.txtUgeNr.Value <> numIndrykningsUge.Value Then
        Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
        Dim cm As SqlCommand = cn.CreateCommand()
        cn.Open()
        cm.CommandText = "UPDATE tblMedieplan SET IndrykningsUge = " & frmSupportBilag.txtUgeNr.Value & " WHERE (MedieplanNr = " & _medieplanNr & ") AND (Version = " & _version & ")"
        cm.CommandType = CommandType.Text
        cm.ExecuteNonQuery()
        cm.Dispose()
        cn.Close()
        cn.Dispose()
      End If
    End If
    frmSupportBilag.Close()
    Me.Select()
    Me.WindowState = FormWindowState.Minimized
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub timerSupportBilag_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerSupportBilag.Tick
    timerSupportBilag.Enabled = False
    VisSupportBilag()
  End Sub

  Private Sub numIndrykningsÅr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numIndrykningsÅr.ValueChanged
    Try
      If numIndrykningsÅr.Value <> _DataValues.IndrykningsÅr Then
        _DataValues.IndrykningsÅr = numIndrykningsÅr.Value
        DataSourceMedieplan.År = numIndrykningsÅr.Value
        'If numIndrykningsÅr.Value > 2010 Then
        '  chkWebTillægOpkræves.Visible = True
        '  If optSammeMateriale.Value Then
        '    chkKunForhandlerBundForskellig.Visible = False
        '  Else
        '    chkKunForhandlerBundForskellig.Visible = True
        '  End If
        'Else
        '  chkWebTillægOpkræves.Visible = False
        'End If
      End If
    Catch
    End Try
    MarkerFarveMin()
  End Sub

  Private Sub grdOrdreLinjer_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grdOrdreLinjer.BeforeRowsDeleted
    Dim nextActiveRow As UltraGridRow = Nothing
    e.DisplayPromptMsg = True

    For Each arow As UltraGridRow In e.Rows
      If arow.Cells("RowState").Value = "Deleted" Then
        DataSourceMedieplan.ReInsertAvis(arow.Cells("UgeavisID").Value)
        arow.Cells("RowState").Value = "UnChanged"
        arow.Cells("New MmPris").Value = arow.Cells("Old MmPris").Value
        arow.Cells("New MmRabat").Value = arow.Cells("Old MmRabat").Value
        arow.Cells("New FarvePris").Value = arow.Cells("Old FarvePris").Value
        arow.Cells("New FarveRabat").Value = arow.Cells("Old FarveRabat").Value
        arow.Appearance.ResetBackColor()
        arow.Appearance.ResetForeColor()
        arow.Appearance.ResetForeColorDisabled()
        arow.Cells("New MmRabat").Appearance.ResetFontData()
        arow.Cells("New FarveRabat").Appearance.ResetFontData()
        arow.Cells("New MmPris").Appearance.ResetFontData()
        arow.Cells("New FarvePris").Appearance.ResetFontData()
        nextActiveRow = arow
        e.Cancel = True
      ElseIf arow.Cells("RowState").Value = "Added" Then
        DataSourceMedieplan.DeleteAvis(arow.Cells("UgeavisID").Value)
        e.DisplayPromptMsg = False
        e.Cancel = False
      Else
        If _status = StatusKoder.stsOrdreIkkeSendt OrElse _status = StatusKoder.stsUdsendtOrdre Then
          If MessageBox.Show("Skal rabatter låses for automatiske ændringer?", "Lås rabatter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LåsDataFelter()
          End If
        End If
        arow.Cells("FarveMin").Value = 0
        DataSourceMedieplan.DeleteAvis(arow.Cells("UgeavisID").Value)
        arow.Cells("Old MmPris").Value = arow.Cells("New MmPris").Value
        arow.Cells("Old MmRabat").Value = arow.Cells("New MmRabat").Value
        arow.Cells("Old MmTotal").Value = arow.Cells("New MmTotal").Value
        arow.Cells("Old FarvePris").Value = arow.Cells("New FarvePris").Value
        arow.Cells("Old FarveRabat").Value = arow.Cells("New FarveRabat").Value
        arow.Cells("Old FarveTotal").Value = arow.Cells("New FarveTotal").Value
        If _status <= StatusKoder.stsFærdigTjekketOrdre Then
          arow.Cells("RowState").Value = "Deleted"
          arow.Cells("New MmPris").Value = 0
          arow.Cells("New FarvePris").Value = 0
          arow.Cells("New MmRabat").Value = 0
          arow.Cells("New FarveRabat").Value = 0
          arow.Appearance.BackColor = Color.Red
        Else
          arow.Cells("RowState").Value = "Changed"
          arow.Cells("New MmRabat").Value = 100
          arow.Cells("New FarveRabat").Value = 100
          arow.Cells("MiljøTillæg").Value = 0
        End If
        arow.Selected = False
        nextActiveRow = arow.GetSibling(SiblingRow.Next)
        e.Cancel = True
      End If
      arow.Update()
    Next
    grdOrdreLinjer.DisplayLayout.Bands(0).SortedColumns.RefreshSort(True)
    If nextActiveRow IsNot Nothing Then
      grdOrdreLinjer.ActiveRow = nextActiveRow
      nextActiveRow.Selected = True
    End If
    DataSourceMedieplan.Beregn()
  End Sub

  Private Sub btnMateriale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMateriale.Click
    Dim nyfrmMaterialeUdsending As New frmMaterialeUdsending(_DataValues)
    nyfrmMaterialeUdsending.MdiParent = My.Forms.frmMain
    nyfrmMaterialeUdsending.WindowState = FormWindowState.Maximized
    nyfrmMaterialeUdsending.TopMost = True
    nyfrmMaterialeUdsending.Show()
  End Sub

  Private Sub picGul_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGul.MouseHover
    Dim toolTipInfo As UltraToolTipInfo = ToolTipManager.GetUltraToolTip(picGul)

    If picGul.Tag = "Off" Then
      toolTipInfo.Enabled = DefaultableBoolean.False
      ToolTipManager.SetUltraToolTip(picGul, toolTipInfo)
    Else
      If _version > 0 Then
        toolTipInfo.Enabled = DefaultableBoolean.True
        toolTipInfo.ToolTipImage = ToolTipImage.Info
        Dim hoverTekst As New StringBuilder(1000)

        hoverTekst.Append(_DataValues.GetChangeTekst(True))
        For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
          If arow.Cells("RowState").Value <> "UnChanged" AndAlso bladRettelse(arow) <> "" Then
            hoverTekst.Append("<B>" + arow.Cells("UgeavisID").Text + "</B>: " + bladRettelse(arow) + "<br/>")
          End If
        Next
        toolTipInfo.ToolTipTitle = "Ændret på medieplan:"
        toolTipInfo.ToolTipTextFormatted = hoverTekst.ToString
        toolTipInfo.ToolTipTextStyle = ToolTipTextStyle.Formatted
        ToolTipManager.SetUltraToolTip(picGul, toolTipInfo)
        ToolTipManager.ShowToolTip(picGul)
      Else
        toolTipInfo.Enabled = DefaultableBoolean.False
        ToolTipManager.SetUltraToolTip(picGul, toolTipInfo)
      End If
    End If
  End Sub

  Private Sub DataSourceMedieplan_MarkerMinPris(ByVal UgeavisID As Integer, ByVal ErUnderMin As Boolean) Handles DataSourceMedieplan.MarkerMinPris
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If arow.Cells("UgeavisID").Value = UgeavisID Then
        If ErUnderMin Then
          arow.Cells("New FarvePris").Appearance.BackColor = Color.Orange
          arow.Cells("New FarvePris").ToolTipText = arow.Cells("FarveMin").Value.ToString
        Else
          arow.Cells("New FarvePris").Appearance.BackColor = Nothing
          arow.Cells("New FarvePris").ToolTipText = ""
        End If
      End If
    Next
  End Sub

  Private Sub DataSourceMedieplan_MåGiveMmRabatÆndret() Handles DataSourceMedieplan.MåGiveMmRabatÆndret
    If chkMmSærRabat.CheckState = CheckState.Checked Then
      _DataValues.TilladMmSærRabat = True
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        arow.Cells("New MmRabat").Activation = Activation.AllowEdit
      Next
    Else
      _DataValues.TilladMmSærRabat = False
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        If arow.Cells("MåGiveMmRabat").Value = False Then
          arow.Cells("New MmRabat").Activation = Activation.Disabled
          arow.Cells("New MmRabat").Appearance.ForeColorDisabled = Color.Gray
        Else
          arow.Cells("New MmRabat").Activation = Activation.AllowEdit
          arow.Cells("New MmRabat").Appearance.ForeColorDisabled = Color.Black
        End If
      Next
    End If
  End Sub

  Private Sub DataSourceMedieplan_RowAdded(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinDataSource.RowAddedEventArgs) Handles DataSourceMedieplan.RowAdded
    timer365.Enabled = True
  End Sub

  Private Sub timer365_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer365.Tick
    timer365.Enabled = False
    BoldItalicLinjer()
    'For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
    '  If arow.Cells("PrisLåst").Value Then
    '    chkVisLåstePriser.Checked = True
    '    Exit For
    '  End If
    'Next
  End Sub

  Private Sub MarkerFarveMin()
    For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
      If Not IsDBNull(arow.Cells("FarveMin").Value) AndAlso arow.Cells("FarveMin").Value > 0 AndAlso arow.Cells("New FarveTotal").Value < arow.Cells("FarveMin").Value Then
        arow.Cells("New FarvePris").Appearance.BackColor = Color.Orange
        arow.Cells("New FarvePris").ToolTipText = arow.Cells("FarveMin").Value.ToString
      Else
        arow.Cells("New FarvePris").Appearance.BackColor = Nothing
        arow.Cells("New FarvePris").ToolTipText = ""
      End If
    Next
  End Sub

  Private Sub BoldItalicLinjer()
    Dim fundetMiljøTillæg As Boolean = False

    If txtFormat1.TextLength > 0 AndAlso txtFormat2.TextLength > 0 Then
      If txtFormat2.Text = "365" Then
        Me.DataSourceMedieplan.Is365 = True
        Me.DataSourceMedieplan.AntalMm360 = CInt(txtFormat1.Text) * 360
        For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
          If arow.Cells("Is365").Value = False Then
            arow.Cells("UgeavisID").Appearance.FontData.Italic = DefaultableBoolean.True
          End If
          If arow.Cells("Ejerforhold").Value = "Midtjyske Medier" OrElse arow.Cells("Ejerforhold").Value = "Berlingske Lokalaviser" OrElse arow.Cells("Ejerforhold").Value = "Den Sydvestjyske Venstrepresse" OrElse arow.Cells("Ejerforhold").Value = "Fynske Medier" OrElse arow.Cells("Ejerforhold").Value = "North Media" OrElse arow.Cells("Ejerforhold").Value = "Jyske Medier A/S" Then
            If arow.Cells("Ejerforhold").Value = "Midtjyske Medier" OrElse arow.Cells("Ejerforhold").Value = "Berlingske Lokalaviser" Then
              If Me.DataSourceMedieplan.Placering = 11 OrElse DataSourceMedieplan.Placering > 12 Then
                If txtFormat1.Text <> "6" Then
                  arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.True
                Else
                  arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.False
                End If
              Else
                arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.False
              End If
            Else
              arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.False
            End If
            If arow.Cells("UgeavisID").Value <> 81 AndAlso arow.Cells("UgeavisID").Value <> 275 AndAlso arow.Cells("UgeavisID").Value <> 191 Then fundetMiljøTillæg = True
          Else
            arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.False
          End If
        Next
      Else
        Me.DataSourceMedieplan.Is365 = False
        For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
          If arow.Cells("Is365").Value = False Then
            arow.Cells("UgeavisID").Appearance.FontData.Italic = DefaultableBoolean.False
          End If
          If arow.Cells("Ejerforhold").Value = "Midtjyske Medier" OrElse arow.Cells("Ejerforhold").Value = "Berlingske Lokalaviser" OrElse arow.Cells("Ejerforhold").Value = "Den Sydvestjyske Venstrepresse" OrElse arow.Cells("Ejerforhold").Value = "Fynske Medier" OrElse arow.Cells("Ejerforhold").Value = "North Media" OrElse arow.Cells("Ejerforhold").Value = "Jyske Medier A/S" Then
            If arow.Cells("Ejerforhold").Value = "Midtjyske Medier" OrElse arow.Cells("Ejerforhold").Value = "Berlingske Lokalaviser" Then
              If Me.DataSourceMedieplan.Placering = 11 OrElse DataSourceMedieplan.Placering > 12 Then
                arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.True
              Else
                arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.False
              End If
            Else
              arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.False
            End If
            If arow.Cells("UgeavisID").Value <> 81 AndAlso arow.Cells("UgeavisID").Value <> 275 AndAlso arow.Cells("UgeavisID").Value <> 191 Then fundetMiljøTillæg = True
          Else
            arow.Cells("UgeavisID").Appearance.FontData.Bold = DefaultableBoolean.False
          End If
        Next
      End If
    End If
    chkMiljøTillægOpkræves.Visible = fundetMiljøTillæg
    clbMiljøTillægOpkræves.Visible = fundetMiljøTillæg
  End Sub

  Private Sub btnGenUdsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenUdsend.Click
    GenUdsendOrdre()
  End Sub

  Private Sub btnTilExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTilExcel.Click
    Dim fileName As String
    fileName = "M:\" & getMedieplanString(_medieplanNr, _version) & ".xls"
    ExcelExporter.Export(grdOrdreLinjer, fileName)
    MessageBox.Show("Gemt som " & fileName, "Excel eksport", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub chkFarveSærRabat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFarveSærRabat.CheckedChanged
    If chkFarveSærRabat.CheckState = CheckState.Checked Then
      _DataValues.TilladFarveSærRabat = True
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        arow.Cells("New FarveRabat").Activation = Activation.AllowEdit
      Next
    Else
      _DataValues.TilladFarveSærRabat = False
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        If arow.Cells("MåGiveFarveRabat").Value = False Then
          arow.Cells("New FarveRabat").Activation = Activation.Disabled
          arow.Cells("New FarveRabat").Appearance.ForeColorDisabled = Color.Gray
        Else
          arow.Cells("New FarveRabat").Activation = Activation.AllowEdit
          arow.Cells("New FarveRabat").Appearance.ForeColorDisabled = Color.Black
        End If
      Next
    End If
  End Sub

  Private Sub btnHistorik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistorik.Click
    If txtHistorik.Visible = False Then
      txtHistorik.Visible = True
    Else
      txtHistorik.Visible = False
    End If
  End Sub

    Private Sub btnFakturaBemærkning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nyFrmFakturaBemærkning As New frmFakturaBemærkning(_medieplanNr)
        nyFrmFakturaBemærkning.ShowDialog()
    End Sub

  Private Sub lblAnnoncør_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnnoncør.Click
    cboAnnoncørNO_.Appearance.BackColor = Color.AliceBlue
    lblAnnoncør.Appearance.BackColor = Color.Aqua
  End Sub

  Private Sub btnGenberegn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenberegn.Click
    _IsGenberegning = True
    UdsendOrdre()
    _IsGenberegning = False

    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    cm.CommandType = Data.CommandType.Text
    cm.CommandText = "UPDATE tblOrdreLinjerNavision SET TotalPris = tblMedieplanLinjer.TotalPris FROM tblOrdreLinjerNavision INNER JOIN tblMedieplanLinjer ON tblOrdreLinjerNavision.Version = tblMedieplanLinjer.Version AND tblOrdreLinjerNavision.OrdreNr = tblMedieplanLinjer.MedieplanNr And tblOrdreLinjerNavision.BladId = tblMedieplanLinjer.UgeavisID WHERE (tblOrdreLinjerNavision.OrdreNr = " & _medieplanNr & ") AND(tblOrdreLinjerNavision.Version = " & _version & ")"
    cn.Open()
    cm.ExecuteNonQuery()
    cm.CommandText = "UPDATE tblOrdreNavision SET Status = 6 WHERE (OrdreNr = " & _medieplanNr & ") AND (Version = " & _version & ")"
    cm.ExecuteNonQuery()
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    MessageBox.Show("Medieplanen er genberegnet.", "Genberegning", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub picMinMax_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picMinMax.MouseClick
    If e.Button = Windows.Forms.MouseButtons.Right Then
      grdCC.Visible = Not grdCC.Visible
      grdCC.BringToFront()
    Else
      If _minMax Then
        lblAnnoncør.Visible = True
        cboAnnoncørNO_.Visible = True
        btnTilExcel.Visible = True
        chkFarveSærRabat.Visible = True
        If _modul = "Medieplan" Then
          lblBemærkningTilAnnoncør.Visible = True
          txtBemærkningTilAnnoncør.Visible = True
        Else
          lblBeskrivelse.Visible = True
          txtBeskrivelse.Visible = True
        End If
        lblGruppering.Location = New Point(1, 224)
        optGruppering.Location = New Point(64, 215)
        grdOrdreLinjer.Location = New Point(0, 248)
        grdOrdreLinjer.Size = New Size(Me.Width - 17, Me.Height - 321)
        picMinMax.Image = My.Resources.pilgridop
        picMinMax.Location = New Point(1, 248)
        grpMedieplanHoved.BringToFront()
        _minMax = False
      Else
        grpMedieplanHoved.SendToBack()
        lblAnnoncør.Visible = False
        cboAnnoncørNO_.Visible = False
        btnTilExcel.Visible = False
        chkFarveSærRabat.Visible = False
        If _modul = "Medieplan" Then
          lblBemærkningTilAnnoncør.Visible = False
          txtBemærkningTilAnnoncør.Visible = False
        Else
          lblBeskrivelse.Visible = False
          txtBeskrivelse.Visible = False
        End If
        lblGruppering.Location = New Point(1, 39)
        optGruppering.Location = New Point(64, 30)
        grdOrdreLinjer.Location = New Point(0, 63)
        grdOrdreLinjer.Size = New Size(Me.Width - 17, Me.Height - 136)
        picMinMax.Image = My.Resources.pilgridned
        picMinMax.Location = New Point(1, 63)
        _minMax = True
      End If
    End If
  End Sub

  Private Sub chkMmSærRabat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMmSærRabat.CheckedChanged
    If chkMmSærRabat.CheckState = CheckState.Checked Then
      _DataValues.TilladMmSærRabat = True
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        arow.Cells("New MmRabat").Activation = Activation.AllowEdit
      Next
    Else
      _DataValues.TilladMmSærRabat = False
      For Each arow As UltraGridRow In grdOrdreLinjer.Rows.GetAllNonGroupByRows
        If arow.Cells("MåGiveMmRabat").Value = False Then
          arow.Cells("New MmRabat").Activation = Activation.Disabled
          arow.Cells("New MmRabat").Appearance.ForeColorDisabled = Color.Gray
        Else
          arow.Cells("New MmRabat").Activation = Activation.AllowEdit
          arow.Cells("New MmRabat").Appearance.ForeColorDisabled = Color.Black
        End If
      Next
    End If
  End Sub

  Private Sub chkMaterialeModtaget_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMaterialeModtaget.CheckedChanged
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    If _medieplanNr > 0 AndAlso _version > 0 Then
      Try
        cm.CommandType = CommandType.Text
        If chkMaterialeModtaget.Checked Then
          cm.CommandText = "UPDATE tblMedieplanNr SET MaterialeModtaget = 1 WHERE (MedieplanNr = " & _medieplanNr & ")"
        Else
          cm.CommandText = "UPDATE tblMedieplanNr SET MaterialeModtaget = 0 WHERE (MedieplanNr = " & _medieplanNr & ")"
        End If
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
      Catch ex As Exception
        MessageBox.Show("Der opstod en fejl da feltet skulle opdateres.", "SQL fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        cm.Dispose()
        cn.Dispose()
      End Try
    End If
  End Sub

  'Private Sub grdOrdreLinjer_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grdOrdreLinjer.ClickCellButton
  '  'If _UgeavisIDer = "" Then _UgeavisIDer = e.Cell.Row.Cells("UgeavisID").Value

  '  Dim FaktureringsBilag As New frmFaktureringsBilag(_medieplanNr, True, e.Cell.Row.Cells("UgeavisID").Text)
  '  FaktureringsBilag.ShowDialog()
  'End Sub

  'Private Sub btnVisFaktureringsBilag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisFaktureringsBilag.Click
  '  Dim FaktureringsBilag As New frmFaktureringsBilag(_medieplanNr, False, "")
  '  FaktureringsBilag.Show()
  'End Sub

  Private Sub optBilagsBladeTil_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles optBilagsBladeTil.MouseUp
    If Not _optBilagsBladeTilValueChanged Then
      If (e.X <= 70 AndAlso optBilagsBladeTil.Value = 1) OrElse (e.X >= 80 AndAlso e.X <= 130 AndAlso optBilagsBladeTil.Value = 2) OrElse (e.X >= 140 AndAlso optBilagsBladeTil.Value = 3) Then
        _DataValues.BilagsBladeTilNavn = ""
        _DataValues.BilagsBladeTilAdresse = ""
        _DataValues.BilagsBladeTilPostNr = 0
        optBilagsBladeTil.CheckedIndex = -1
      End If
    Else
      _optBilagsBladeTilValueChanged = False
    End If
  End Sub

  Private Sub optBilagsBladeTil_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBilagsBladeTil.MouseHover, lblBilagsbladTil.MouseHover
    Dim toolTipInfo As UltraToolTipInfo = ToolTipManager.GetUltraToolTip(lblBilagsbladTil)

    If optBilagsBladeTil.Value = 3 Then 'AndAlso optBilagsBladeTil.PointToClient(MousePosition).X >= 140 Then
      toolTipInfo.Enabled = DefaultableBoolean.True
      toolTipInfo.ToolTipImage = ToolTipImage.Info
      toolTipInfo.ToolTipTitle = "Bilagsblad modtager"
      toolTipInfo.ToolTipTextStyle = ToolTipTextStyle.Formatted
      toolTipInfo.ToolTipTextFormatted = _DataValues.BilagsBladeTilNavn.Replace("&", "og") & "<br/>"
      toolTipInfo.ToolTipTextFormatted = toolTipInfo.ToolTipTextFormatted & _DataValues.BilagsBladeTilAdresse & "<br/>"
      toolTipInfo.ToolTipTextFormatted = toolTipInfo.ToolTipTextFormatted & _DataValues.BilagsBladeTilPostNr & "<br/>"

      ToolTipManager.SetUltraToolTip(lblBilagsbladTil, toolTipInfo)
      ToolTipManager.ShowToolTip(lblBilagsbladTil)
    Else
      toolTipInfo.Enabled = DefaultableBoolean.False
      ToolTipManager.SetUltraToolTip(lblBilagsbladTil, toolTipInfo)
    End If
  End Sub

  ' Private Sub chkKunForhandlerBundForskellig_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKunForhandlerBundForskellig.CheckedChanged
  '  _DataValues.KunForhandlerBundForskellig = chkKunForhandlerBundForskellig.Checked
  'End Sub

  'Private Sub chkWebTillægOpkræves_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWebTillægOpkræves.CheckedChanged
  '  _DataValues.WebTillægOpkræves = chkWebTillægOpkræves.Checked
  'End Sub

  Private Sub chkMiljøTillægOpkræves_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMiljøTillægOpkræves.CheckedChanged
    _DataValues.MiljøTillægOpkræves = chkMiljøTillægOpkræves.Checked
    If chkMiljøTillægOpkræves.Checked Then
      If _DataValues.OprindeligtMiljøTillæg = 0 Then
        _anvendtMiljøTillæg = frmMain.AktivMiljøTillæg
      Else
        _anvendtMiljøTillæg = _DataValues.OprindeligtMiljøTillæg
      End If
      DataSourceMedieplan.AnvendtMiljøTillæg = _anvendtMiljøTillæg
    Else
      _anvendtMiljøTillæg = 0
      DataSourceMedieplan.AnvendtMiljøTillæg = 0
    End If
    skalMiljøTillægVisesCheckVises()
  End Sub

  Private Sub chkMiljøTillægOpkræves_VisibleChanged(sender As Object, e As System.EventArgs) Handles chkMiljøTillægOpkræves.VisibleChanged
    skalMiljøTillægVisesCheckVises()
  End Sub

  Private Sub skalMiljøTillægVisesCheckVises()
    If chkMiljøTillægOpkræves.Visible = True AndAlso chkMiljøTillægOpkræves.Checked = True Then
      chkMiljøTillægVises.Visible = True
      clbMiljøTillægOpkræves.Visible = True
    Else
      chkMiljøTillægVises.Visible = False
      clbMiljøTillægOpkræves.Visible = False
      chkMiljøTillægVises.Checked = False
    End If
  End Sub

  Private Sub chkMiljøTillægVises_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMiljøTillægVises.CheckedChanged
    If chkMiljøTillægVises.Checked = True Then
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("MiljøTillæg").Hidden = False
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("TotalInclTillæg").Hidden = False
    Else
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("MiljøTillæg").Hidden = True
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("TotalInclTillæg").Hidden = True
    End If
  End Sub

  Private Sub clbMiljøTillægOpkræves_ItemCheck(sender As System.Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles clbMiljøTillægOpkræves.ItemCheck
    If e.Index = 0 Then
      If e.NewValue = CheckState.Checked Then
        DataSourceMedieplan.OpkrævJyskeMiljøTillæg = True
      Else
        DataSourceMedieplan.OpkrævJyskeMiljøTillæg = False
      End If
    ElseIf e.Index = 1 Then
      If e.NewValue = CheckState.Checked Then
        DataSourceMedieplan.OpkrævFynskeMiljøTillæg = True
      Else
        DataSourceMedieplan.OpkrævFynskeMiljøTillæg = False
      End If
    ElseIf e.Index = 2 Then
      If e.NewValue = CheckState.Checked Then
        DataSourceMedieplan.OpkrævNorthMiljøTillæg = True
      Else
        DataSourceMedieplan.OpkrævNorthMiljøTillæg = False
      End If
    ElseIf e.Index = 3 Then
      If e.NewValue = CheckState.Checked Then
        DataSourceMedieplan.OpkrævDSVPMiljøTillæg = True
      Else
        DataSourceMedieplan.OpkrævDSVPMiljøTillæg = False
      End If
    ElseIf e.Index = 4 Then
      If e.NewValue = CheckState.Checked Then
        DataSourceMedieplan.OpkrævJyskeMedierASTillæg = True
      Else
        DataSourceMedieplan.OpkrævJyskeMedierASTillæg = False
      End If
    End If
  End Sub

  Private Sub txtKommentar_AfterExitEditMode(sender As Object, e As System.EventArgs) Handles txtKommentar.AfterExitEditMode
    _Kommentar = txtKommentar.Text
    If String.IsNullOrEmpty(_Kommentar) Then
      txtKommentar.Value = Nothing
    Else
      txtKommentar.Text = _Kommentar
    End If
    SaveKommentar()
  End Sub

  Private Sub SaveKommentar()
    If _medieplanNr > 0 Then
      Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
      Dim cm As SqlCommand = cn.CreateCommand()

      cm.CommandType = CommandType.Text
      If String.IsNullOrEmpty(_Kommentar) Then
        cm.CommandText = String.Format("UPDATE tblMedieplanNr SET Kommentar = {0} WHERE (MedieplanNr = {1})", "", _medieplanNr)
      Else
        cm.CommandText = String.Format("UPDATE tblMedieplanNr SET Kommentar = {0} WHERE (MedieplanNr = {1})", _Kommentar, _medieplanNr)
      End If
      cn.Open()
      cm.ExecuteNonQuery()
      cn.Close()
      cm.Dispose()
      cn.Dispose()
    End If
  End Sub

  Private Sub btnKommentar_Click(sender As System.Object, e As System.EventArgs) Handles btnKommentar.Click
    frmKommentar.Kommentar = _Kommentar
    frmKommentar.ShowDialog()

    If frmKommentar.DialogResult = DialogResult.OK Then
      _Kommentar = frmKommentar.Kommentar
      SaveKommentar()
      KommentarToolTip()
    End If

  End Sub

  Private Sub chkVisLåstePriser_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkVisLåstePriser.CheckedChanged
    If chkVisLåstePriser.Checked Then
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("PrisLåst").Hidden = False
    Else
      grdOrdreLinjer.DisplayLayout.Bands(0).Columns("PrisLåst").Hidden = True
    End If
  End Sub

    Private Sub updateFakturaBemTekst(semder As System.Object, e As System.EventArgs) Handles btnLuk.Click







            Dim valn As String = txtFakturaBemærkning.Value



        If Not IsNothing(valn) Then
            Dim lastIndexOf = valn.LastIndexOf(",")
            If lastIndexOf >= 0 Then
                Dim before = valn.Substring(0, lastIndexOf - 1).TrimEnd().TrimStart()
                Dim after = valn.Substring(lastIndexOf + 1, valn.Length - lastIndexOf - 1).TrimEnd().TrimStart()
                _fakService.UpdateFakuraBemærkning(before, after, _medieplanNr)
            Else

                _fakService.UpdateFakuraBemærkning(valn, _medieplanNr)
            End If

        End If





    End Sub

End Class
