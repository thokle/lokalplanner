Imports Infragistics.Win.UltraWinDataSource
Imports System.Data.SqlClient
Imports System.Globalization
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.IO
Imports System.Text
Imports System.Drawing.Text

Public Class frmMain
  Private _Mainwindow As Form
  Private _AktivtModul As String
  Private _DenneUge As Integer
  Private _DetteÅr As Integer
  Private _AntalUgerIÅr As Integer
  Private _DenneUgeDag As Integer
  Private _BrugerNavn As String
  Private _BrugerFuldeNavn As String
  Private _BrugerTlf As String
  Private _BrugerEmail As String
  Private _BrugerRoller As New Collection
  Private _GrupperVisning As Boolean = False
  Private _VisningIBladGrid As String = "Fill"
  Private _VisMedieplanVersioner As Boolean = True
  Private _VisBookingVersioner As Boolean = True
  Private _VisFaktureringVersioner As Boolean = True
  Private _MedtagRettelser As Boolean = True
  Private _AktivGruppeVersion As Integer
  Private _BrugersLPVersion As String
  Private _LPVersion As String
  Private _AktivMiljøTillæg As Double
  Private _VisInAktive As Boolean = False

  Public ReadOnly Property BrugerTlf() As String
    Get
      Return _BrugerTlf
    End Get
  End Property

  Public ReadOnly Property BrugerEmail() As String
    Get
      Return _BrugerEmail
    End Get
  End Property

  Public ReadOnly Property BrugerFuldeNavn() As String
    Get
      Return _BrugerFuldeNavn
    End Get
  End Property

  Public ReadOnly Property BrugerNavn() As String
    Get
      Return _BrugerNavn
    End Get
  End Property

  Public ReadOnly Property AntalUgerIÅr() As Integer
    Get
      Return _AntalUgerIÅr
    End Get
  End Property

  Public ReadOnly Property DetteÅr() As Integer
    Get
      Return _DetteÅr
    End Get
  End Property

  Public ReadOnly Property DenneUge() As Integer
    Get
      Return _DenneUge
    End Get
  End Property

  Public ReadOnly Property DenneUgeDag() As Integer
    Get
      Return _DenneUgeDag
    End Get
  End Property

  Public Property ActiveWindows() As Form
    Get
      Return _Mainwindow
    End Get
    Set(ByVal value As Form)
      _Mainwindow = value
    End Set
  End Property

  Public Function HarRollen(ByVal Rolle As String) As Boolean
    If _BrugerRoller.Contains(UCase(Rolle)) Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Property AktivtModul() As String
    Get
      Return _AktivtModul
    End Get
    Set(ByVal value As String)
      If _AktivtModul <> value Then
        _AktivtModul = value
        Dim fundenKontrol As Control()

        Select Case _AktivtModul
          Case "Medieplan"
            fundenKontrol = Me.Controls.Find("panFindMedieplanBooking", True)
            If fundenKontrol IsNot Nothing Then
              fundenKontrol(0).Visible = False
            End If
            fundenKontrol = Me.Controls.Find("panFindMedieplan", True)
            If fundenKontrol IsNot Nothing Then
              Me.dockManager.ControlPanes(1).DockAreaPane.Size = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).FlyoutSize = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).Size = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).Control = fundenKontrol(0)
              fundenKontrol(0).Dock = DockStyle.Fill
              fundenKontrol(0).Visible = True
              chkMedieplan.Checked = _VisMedieplanVersioner
              chkBooking.Checked = _VisBookingVersioner
              chkMedtagRettelser.Checked = _MedtagRettelser
              chkFakturering.Checked = _VisFaktureringVersioner
              chkVisInAktive.Checked = _VisInAktive
            End If
          Case "Booking"
            fundenKontrol = Me.Controls.Find("panFindMedieplan", True)
            If fundenKontrol IsNot Nothing Then
              fundenKontrol(0).Visible = False
            End If
            fundenKontrol = Me.Controls.Find("panFindMedieplanBooking", True)
            If fundenKontrol IsNot Nothing Then
              picPipelineBooking.Image = My.Resources.BookingHeader
              Me.dockManager.ControlPanes(1).DockAreaPane.Size = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).FlyoutSize = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).Size = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).Control = fundenKontrol(0)
              fundenKontrol(0).Dock = DockStyle.Fill
              fundenKontrol(0).Visible = True
              chkMedieplanBooking.Checked = _VisMedieplanVersioner
              chkBookingBooking.Checked = _VisBookingVersioner
              chkMedtagRettelserBooking.Checked = _MedtagRettelser
              chkFaktureringBooking.Checked = _VisFaktureringVersioner
              chkVisInAktiveBooking.Checked = _VisInAktive
            End If
          Case "Fakturering"
            fundenKontrol = Me.Controls.Find("panFindMedieplan", True)
            If fundenKontrol IsNot Nothing Then
              fundenKontrol(0).Visible = False
            End If
            fundenKontrol = Me.Controls.Find("panFindMedieplanBooking", True)
            If fundenKontrol IsNot Nothing Then
              picPipelineBooking.Image = My.Resources.FaktureringHeader
              Me.dockManager.ControlPanes(1).DockAreaPane.Size = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).FlyoutSize = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).Size = New Size(-1, 102)
              Me.dockManager.ControlPanes(1).Control = fundenKontrol(0)
              fundenKontrol(0).Dock = DockStyle.Fill
              fundenKontrol(0).Visible = True
              chkMedieplanBooking.Checked = _VisMedieplanVersioner
              chkBookingBooking.Checked = _VisBookingVersioner
              chkMedtagRettelserBooking.Checked = _MedtagRettelser
              chkFaktureringBooking.Checked = _VisFaktureringVersioner
              chkVisInAktiveBooking.Checked = _VisInAktive
            End If
        End Select
      End If
    End Set
  End Property

  Public ReadOnly Property AktivGruppeVersion()
    Get
      Return _AktivGruppeVersion
    End Get
  End Property

  Public ReadOnly Property AktivMiljøTillæg
    Get
      Return _AktivMiljøTillæg
    End Get
  End Property

  Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Dim stiTilBrugersLayout As String = My.Settings.PathGridUserSettings

    Me.grdFindUgeavis.DisplayLayout.SaveAsXml(stiTilBrugersLayout & "BladGrid.xml")
    Me.grdFundnePlaner.DisplayLayout.SaveAsXml(stiTilBrugersLayout & "FundnePlanergrid.xml")
    Me.dockManager.SaveComponentSettings()
    Me.dockManager.SaveAsXML(stiTilBrugersLayout & "Docking.xml")
    Try
      LPSplashScreen.Close()
    Catch
    End Try
  End Sub

  Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    CheckForIllegalCrossThreadCalls = False

    My.Application.ChangeCulture("da-DK")
    '  MessageBox.Show(Now.ToString("dd\/M kl. hh:mm"))

    _BrugerNavn = UCase(My.User.Name.Substring(My.User.Name.LastIndexOf("\") + 1))
    If _BrugerNavn = "CARL-ERIK SØRENSEN" OrElse _BrugerNavn = "ADMINISTRATOR" OrElse _BrugerNavn = "CWS" Then
      _BrugerNavn = "CWS"
      _BrugerRoller.Add("Admin", "Admin")
    End If
    cm.CommandText = "SELECT Name, [E-Mail] AS Email, [Phone No_] AS TlfNr, SidsteLoginVersion, NulstilLayout FROM Salesperson WHERE (Code = '" & UCase(_BrugerNavn) & "')"
    cm.CommandType = CommandType.Text
    Try
      cn.Open()
      Dim dr As SqlDataReader = cm.ExecuteReader()
      While dr.Read
        _BrugerFuldeNavn = dr("Name")
        _BrugerTlf = dr("TlfNr")
        _BrugerEmail = dr("Email")
        If IsDBNull(dr("SidsteLoginVersion")) Then
          _BrugersLPVersion = "0000000000"
        Else
          _BrugersLPVersion = dr("SidsteLoginVersion")
        End If
        If IsDBNull(dr("NulstilLayout")) Then
          HentBrugersIndstillinger = True
        Else
          HentBrugersIndstillinger = Not (dr("NulstilLayout"))
        End If
      End While
      dr.Close()
    Catch ex As Exception
      MsgBox("Der opstod en fejl da bruger oplysninger skulle findes for " & _BrugerNavn & ".", MsgBoxStyle.Exclamation, "Fejl ved navn!")
    End Try

    If _BrugersLPVersion = "0000000000" Then
      cm.CommandText = "INSERT INTO tblBrugerData (Initialer, SidsteLoginVersion, NulstilLayout) VALUES ('" & _BrugerNavn & "','0000000001', '0')"
      cm.ExecuteNonQuery()
    End If

    cm.CommandText = "SELECT GruppeVersion FROM tblAktiveVærdier"
    _AktivGruppeVersion = cm.ExecuteScalar
    cm.CommandText = "SELECT MiljøTillæg FROM tblAktiveVærdier"
    _AktivMiljøTillæg = cm.ExecuteScalar

    Dim sourceDir As String = "D:\users\" & _BrugerNavn & "\appdata\local\temp"
    If _BrugerNavn <> "CWS" Then
      Try
        cm.CommandText = "SELECT [Role ID] AS Rolle FROM LPRoller WHERE ([User ID] = '" & UCase(_BrugerNavn) & "')"
        Dim dr2 As SqlDataReader = cm.ExecuteReader()
        While dr2.Read()
          _BrugerRoller.Add(dr2("Rolle").ToString.Substring(3), dr2("Rolle").ToString.Substring(3))
        End While
        dr2.Close()
      Catch ex2 As Exception
        MsgBox("Der opstod en fejl da bruger roller skulle findes for " & _BrugerNavn & ".", MsgBoxStyle.Exclamation, "Fejl ved roller!")
            End Try
            If _BrugerNavn.Equals("TK") Then

                sourceDir = "C:\users\" & _BrugerNavn & "\appdata\local\temp"
            End If
    Else
      sourceDir = "C:\users\" & _BrugerNavn & "\appdata\local\temp"
    End If

    Dim tmpList As String() = Directory.GetFiles(sourceDir, "*.tmp")

    For Each f As String In tmpList
      Try
        File.Delete(f)
      Catch
      End Try
    Next
    Dim cvrList As String() = Directory.GetFiles(sourceDir, "*.cvr")

    For Each f As String In cvrList
      Try
        File.Delete(f)
      Catch
      End Try
    Next

    Dim tmpDirList As String() = Directory.GetDirectories(sourceDir, "*.tmp")

    For Each f As String In tmpDirList
      Try
        Directory.Delete(f, True)
      Catch
      End Try
    Next

    If _BrugerFuldeNavn = Nothing OrElse _BrugerTlf = Nothing OrElse _BrugerEmail = Nothing Then
      MessageBox.Show("Brugeren " & _BrugerNavn & " er ikke oprettet i Navision." & vbCrLf & "Opret brugeren i Navision for at bruge Lokal planner.", "Bruger ikke oprettet.", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Application.Exit()
      Exit Sub
    End If
    If _BrugerFuldeNavn.Length = 0 OrElse _BrugerTlf.Length = 0 OrElse _BrugerEmail.Length = 0 Then
      MessageBox.Show("Der mangler vigtige oplysninger om brugeren " & _BrugerNavn & "." & vbCrLf & "Dette skal rettes i Navision, før Lokal planner kan bruges." & vbCrLf & vbCrLf & "Fundne oplysninger:" & vbCrLf & "Fulde navn: " & _BrugerFuldeNavn & vbCrLf & "Tlf: " & _BrugerTlf & vbCrLf & "eMail: " & _BrugerEmail, "Oplysninger mangler.", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Application.Exit()
      Exit Sub
    End If
    If _BrugerRoller.Count < 1 Then
      MsgBox("Der kunne ikke findes bruger roller for " & _BrugerNavn & ".", MsgBoxStyle.Exclamation, "Fejl ved roller!")
      Application.Exit()
      Exit Sub
    End If

    If Not My.Computer.FileSystem.DirectoryExists(My.Settings.PathGridUserSettings) Then
      My.Computer.FileSystem.CreateDirectory(My.Settings.PathGridUserSettings)
      My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.CurrentDirectory & "OversigtSkalSendesGrid.bin", My.Settings.PathGridUserSettings & "OversigtSkalSendesGrid.bin", True)
    End If

    'If HentBrugersIndstillinger Then
    '  If My.Computer.FileSystem.FileExists(My.Settings.PathGridUserSettings & "BladGrid.xml") Then Me.grdFindUgeavis.DisplayLayout.LoadFromXml(My.Settings.PathGridUserSettings & "BladGrid.xml")
    '  If My.Computer.FileSystem.FileExists(My.Settings.PathGridUserSettings & "FundnePlanerGrid.xml") Then Me.grdFundnePlaner.DisplayLayout.LoadFromXml(My.Settings.PathGridUserSettings & "FundnePlanerGrid.xml")
    '  Me.dockManager.LoadComponentSettings()
    '  If My.Computer.FileSystem.FileExists(My.Settings.PathGridUserSettings & "Docking.xml") Then Me.dockManager.LoadFromXML(My.Settings.PathGridUserSettings & "Docking.xml")
    'End If

    Me.TblUgeaviserTableAdapter.Fill(Me.UgeavisListeDropdown.tblUgeaviser)
    Me.TblBureauerTableAdapter.Fill(Me.BureauListeDropdown.tblBureauer)
    Me.TblAnnoncørerTableAdapter.Fill(Me.AnnoncørListeDropdown.tblAnnoncører)
    Me.TblBladStamdataTableAdapter.Fill(Me.DiMPdotNetDataSet.tblBladStamdata)

    Dim myCI As New CultureInfo("da-DK")
    Dim myCal As Calendar = myCI.Calendar
    Dim myCWR As CalendarWeekRule = myCI.DateTimeFormat.CalendarWeekRule
    Dim myFirstDOW As DayOfWeek = myCI.DateTimeFormat.FirstDayOfWeek
    Dim sidsteDagIÅr = New DateTime(DateTime.Now.Year, 12, 31)
    _DenneUge = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW)
    _DenneUgeDag = myCal.GetDayOfWeek(DateTime.Now)
    '    _AntalUgerIÅr = myCal.GetWeekOfYear(sidsteDagIÅr, myCWR, myFirstDOW)
    _DetteÅr = Date.Now.Year
    _AntalUgerIÅr = 53
    numÅr.Value = _DetteÅr
    numÅrBooking.Value = _DetteÅr
    numTilUge.Value = _DenneUge + 1
    numTilUgeBooking.Value = _DenneUge + 1
    If _DenneUge > 12 Then
      numFraUge.Value = _DenneUge - 12
      numFraUgeBooking.Value = _DenneUge - 12
    Else
      numFraUge.Value = _AntalUgerIÅr - (12 - _DenneUge)
      numFraUgeBooking.Value = _AntalUgerIÅr - (12 - _DenneUge)
    End If
    numTilUge.MaxValue = _AntalUgerIÅr
    numFraUge.MaxValue = _AntalUgerIÅr
    numTilUgeBooking.MaxValue = _AntalUgerIÅr
    numFraUgeBooking.MaxValue = _AntalUgerIÅr

    Dim rc As Infragistics.Shared.ResourceCustomizer
    rc = Infragistics.Win.UltraWinGrid.Resources.Customizer
    rc.SetCustomizedString("ColumnChooserButtonToolTip", "Klik her for at vælge kolonner")
    rc.SetCustomizedString("FilterClearButtonToolTip_RowSelector", "Klik her for at nulstille søgefelter")
    rc.SetCustomizedString("ColumnChooserDialogCaption", "Kolonne vælger")
    rc.SetCustomizedString("AllRowsFilteredOut", "Ingen Ugeaviser fundet")
    rc.SetCustomizedString("ColumnChooserAllBandsItem", "Alle")
    rc.SetCustomizedString("DeleteMultipleRowsPrompt", "Du har markeret at du vil slette {0} Ugeaviser. Vælg Ja for at slette eller Nej for at fortryde.")
    rc.SetCustomizedString("DeleteRowsMessageTitle", "Slet Ugeaviser")
    rc.SetCustomizedString("DeleteSingleRowMessageTitle", "Slet Ugeavis")
    rc.SetCustomizedString("DeleteSingleRowPrompt", "Du har markeret at du vil slette 1 Ugeavis. Vælg Ja for at slette eller Nej for at fortryde.")
    rc.SetCustomizedString("GroupByBoxDefaultPrompt", "Træk en kolonne herop, for at gruppere på den.")
    rc.SetCustomizedString("GroupByButtonToolTip", "Klik for at skifte sorterings rækkefølge")
    rc = Infragistics.Win.UltraWinDock.Resources.Customizer
    rc.SetCustomizedString("NavigatorDefaultMdiListCaption", "Åbne Vinduer")
    rc.SetCustomizedString("PaneButtonToolTipClose", "Luk")
    rc.SetCustomizedString("PaneButtonToolTipPin", "Fastgør")
    rc.SetCustomizedString("PaneButtonToolTipUnpin", "Skjul Automatisk")

    Infragistics.Win.AppStyling.StyleManager.Load("Lokal planner.Net.isl")

    Me.AktivtModul = "Medieplan"
    grdFindUgeavis.DrawFilter = New SortIndicatorDrawFilter
    grdFundnePlaner.DrawFilter = New SortIndicatorDrawFilter
    grdFindUgeavis.DisplayLayout.Bands(0).Columns("RegionNavn").SortComparer = New sortBySortKey
    grdFindUgeavis.DisplayLayout.Bands(0).Columns("GeoKodeNavn").SortComparer = New sortBySortKey
    grdFindUgeavis.DisplayLayout.Bands(0).Columns("HovedGruppeNavn").SortComparer = New sortBySortKey
    grdFindUgeavis.DisplayLayout.Bands(0).Columns("DelOmrådeNavn").SortComparer = New sortBySortKey
    grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Clear()
    grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
    grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("Navn", False, False)
    Me.dockManager.ControlPanes("Fundne Planer").DockAreaPane.Size = New Size(-1, 40)
    Me.dockManager.ControlPanes("Fundne Planer").FlyoutSize = New Size(-1, 40)
    Me.dockManager.ControlPanes("Fundne Planer").Size = New Size(-1, 40)

    'Indlæs alle grupper og deres data
    Dim ta As New GruppeListeDropdownTableAdapters.tblGrupperTableAdapter
    Dim table As New GruppeListeDropdown.tblGrupperDataTable
    Dim tarabat As New dstGruppeRabatterTableAdapters.tblGruppeRabatterTableAdapter
    Dim tablerabat As New dstGruppeRabatter.tblGruppeRabatterDataTable
    Dim i As Integer
    Dim j As Integer
    Dim ID As Integer
    Dim versioner As Integer
    Dim minVersion As Integer = 1
    Dim maxVersion As Integer = ta.GetMaxVersion()

    If _BrugerNavn = "CARL-ERIK SØRENSEN" OrElse _BrugerNavn = "ADMINISTRATOR" OrElse _BrugerNavn = "CWS" Then minVersion = maxVersion

    For versioner = minVersion To maxVersion
      ReDim Preserve _gruppeVersion(versioner)

      If ta.Fill(table, versioner) > 0 Then
        For i = 0 To table.Count - 1
          ID = table(i).GruppeID
          If ID > _gruppeVersion(versioner).MaxID Then
            _gruppeVersion(versioner).MaxID = ID
            ReDim Preserve _gruppeVersion(versioner)._gruppe(_gruppeVersion(versioner).MaxID)
          End If
          _gruppeVersion(versioner)._gruppe(ID).Navn = table(i).GruppeNavn
          If LCase(Strings.Left(_gruppeVersion(versioner)._gruppe(ID).Navn, 3)) = "del" Then
            _gruppeVersion(versioner)._gruppe(ID).Type = "Delområde"
          Else
            _gruppeVersion(versioner)._gruppe(ID).Type = "Rabat"
          End If
          _gruppeVersion(versioner)._gruppe(ID).AntalAviserDerSkalVælges = table(i).AntalBladeForValg
          _gruppeVersion(versioner)._gruppe(ID).OrdreModtager = table(i).OrdreEmail
          _gruppeVersion(versioner)._gruppe(ID).MaterialeModtager = table(i).MaterialeModtager
          If tarabat.FillByGruppeID(tablerabat, ID, versioner) > 0 Then
            ReDim Preserve _gruppeVersion(versioner)._gruppe(ID).Rabatter(tablerabat.Count - 1)
            For j = 0 To tablerabat.Count - 1
              _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).PlaceringID = tablerabat(j).PlaceringID
              _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).AntalFra = tablerabat(j).AntalFra
              _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).AntalTil = tablerabat(j).AntalTil
              If tablerabat(j).IsMmPrisNull Then
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).MmPris = 0
              Else
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).MmPris = tablerabat(j).MmPris
              End If
              If tablerabat(j).IsMmRabatNull Then
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).MmRabat = 0
              Else
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).MmRabat = tablerabat(j).MmRabat
              End If
              If tablerabat(j).IsFarveTillægNull Then
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).FarveTillæg = 0
              Else
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).FarveTillæg = tablerabat(j).FarveTillæg
              End If
              If tablerabat(j).IsFarveRabatNull Then
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).FarveRabat = 0
              Else
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).FarveRabat = tablerabat(j).FarveRabat
              End If
              If tablerabat(j).IsFarveMinNull Then
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).FarveMin = 0
              Else
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).FarveMin = tablerabat(j).FarveMin
              End If
              If tablerabat(j).IsFarveMaxNull Then
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).FarveMax = 0
              Else
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).FarveMax = tablerabat(j).FarveMax
              End If
              If tablerabat(j).IsPrisInclFarverNull Then
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).PrisInclFarver = 0
              Else
                _gruppeVersion(versioner)._gruppe(ID).Rabatter(j).PrisInclFarver = tablerabat(j).PrisInclFarver
              End If
            Next
          End If
        Next
      End If
    Next

    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT KonkurrentID, KonkurrentNavn, KonkurentKode FROM tblKonkurrenter ORDER BY KonkurrentID"
    Dim dr3 As SqlDataReader = cm.ExecuteReader()
    While dr3.Read
      Dim Konkurrent As New KonkurrentData
      Konkurrent.KonkurrentID = dr3(0)
      Konkurrent.KonkurrentNavn = dr3(1)
      Konkurrent.KonkurrentKode = dr3(2)
      KonkurrentDataListe.Add(Konkurrent)
    End While
    dr3.Close()

    'Check om der er sendt BilagsbladeReminder i indeværende uge og send hvis ikke.
    cm.CommandText = "SELECT BilagsBladeSendeUge FROM tblAktiveVærdier"
    If _DenneUge <> cm.ExecuteScalar() Then
      cm.CommandText = "UPDATE tblAktiveVærdier SET BilagsBladeSendeUge = " & _DenneUge.ToString
      cm.ExecuteNonQuery()

      Dim cn2 As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
      Dim ordreCM As SqlCommand = cn2.CreateCommand()
      Dim bladDR As SqlDataReader
      Dim ordreDR As SqlDataReader
      Dim bladID As Integer
      Dim bladNavn As String
      Dim HTMLTekst As New StringBuilder(1000)
      Dim eMail As String
      Dim first As Boolean
      Dim succes As Boolean

      cn2.Open()
      cm.CommandText = "SELECT BladID, Navn, BilagsbladeEmail FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0)"
      bladDR = cm.ExecuteReader(CommandBehavior.Default)
      While bladDR.Read()
        eMail = bladDR("BilagsbladeEmail")
        bladID = bladDR("BladID")
        bladNavn = bladDR("Navn")
        If eMail <> "" Then
          ordreCM.CommandText = "SELECT CASE WHEN BilagsBladeTil = 1 THEN NavisionContact.Name WHEN BilagsBladeTil = 2 THEN NavisionContact_1.Name WHEN BilagsBladeTil = 3 THEN BilagsBladeTilNavn END AS Navn, CASE WHEN BilagsBladeTil = 1 THEN NavisionContact.Address WHEN BilagsBladeTil = 2 THEN NavisionContact_1.Address WHEN BilagsBladeTil = 3 THEN BilagsBladeTilAdresse END AS Adresse, CASE WHEN BilagsBladeTil = 1 THEN NavisionContact.[Post Code] WHEN BilagsBladeTil = 2 THEN NavisionContact_1.[Post Code] WHEN BilagsBladeTil = 3 THEN BilagsBladeTilPostNr END AS PostNr, CASE WHEN BilagsBladeTil = 1 THEN NavisionContact.City COLLATE Danish_Norwegian_CS_AS WHEN BilagsBladeTil = 2 THEN NavisionContact_1.City WHEN BilagsBladeTil = 3 THEN PostBy END AS PostByen, tblMedieplan.BilagsBladeATT, tblMedieplan.BureauNo_ AS BureauNo, NavisionContact.Name AS Annoncør, tblMedieplan.BilagsBladeTil FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version LEFT OUTER JOIN tblPostNr ON tblMedieplan.BilagsBladeTilPostNr = tblPostNr.PostNr LEFT OUTER JOIN NavisionContact AS NavisionContact_1 ON tblMedieplan.BureauNo_ = NavisionContact_1.No_ LEFT OUTER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplan.IndrykningsUge = " & _DenneUge & ") AND (tblMedieplan.IndrykningsÅr = " & _DetteÅr & ") AND (tblMedieplan.BilagsBladeTil > - 1) AND (tblMedieplanNr.Status = 3 OR tblMedieplanNr.Status > 4) AND (tblMedieplanLinjer.UgeavisID = " & bladID & ")"
          first = True
          HTMLTekst.Remove(0, HTMLTekst.Length)
          ordreDR = ordreCM.ExecuteReader(CommandBehavior.Default)
          While ordreDR.Read()
            If first Then
              HTMLTekst.Append("<b>" & bladNavn & "<br>")
              HTMLTekst.Append("Bilagsblade i uge " & _DenneUge.ToString & " skal sendes til.</b><br><br>")
              HTMLTekst.Append("<Table border=""1"" cellpadding=""0"" cellspacing=""0"" width=""90%""><TR><TD Width=""30%""><B>Navn</B></TD><TD Width=""30%""><B>Adresse</B></TD><TD Width=""10%""><B>PostNr</B></TD><TD Width=""15%""><B>ATT</B></TD><TD Width=""15%""><B>Annoncør</B></TD></TR>")
              first = False
            End If
            HTMLTekst.Append("<TR>")
            If Trim(ordreDR("BilagsBladeTil").ToString()) = "2" Then
              Select Case Trim(ordreDR("BureauNo").ToString())
                Case "E00001"
                  HTMLTekst.Append("<TD>Carat Danmark A/S</TD><TD>Åboulevarden 20 2.sal</TD><TD>8000 Århus C</TD><TD></TD><TD>" & ordreDR("Annoncør").ToString & "</TD>")
                Case "E00004", "E00005", "E00009", "E00012", "E00848", "E00852", "E01890", "E02220"
                  HTMLTekst.Append("<TD>GroupM</TD><TD>Antonigade 4, 4. sal</TD><TD>1106 København K</TD><TD>Jessie Lund - Annoncekontrol</TD><TD>" & ordreDR("Annoncør").ToString & "</TD>")
                Case Else
                  HTMLTekst.Append("<TD>" & ordreDR("Navn").ToString() & "</TD>")
                  HTMLTekst.Append("<TD>" & ordreDR("Adresse").ToString() & "</TD>")
                  HTMLTekst.Append("<TD>" & ordreDR("PostNr").ToString() & " " & ordreDR("PostByen").ToString & "</TD>")
                  HTMLTekst.Append("<TD>" & ordreDR("BilagsBladeAtt").ToString() & "</TD>")
                  HTMLTekst.Append("<TD>" & ordreDR("Annoncør").ToString() & "</TD>")
              End Select
            Else
              HTMLTekst.Append("<TD>" & ordreDR("Navn").ToString() & "</TD>")
              HTMLTekst.Append("<TD>" & ordreDR("Adresse").ToString() & "</TD>")
              HTMLTekst.Append("<TD>" & ordreDR("PostNr").ToString() & " " & ordreDR("PostByen").ToString & "</TD>")
              HTMLTekst.Append("<TD>" & ordreDR("BilagsBladeAtt").ToString() & "</TD>")
              HTMLTekst.Append("<TD>" & ordreDR("Annoncør").ToString() & "</TD>")
            End If
            HTMLTekst.Append("</TR>")
          End While
          ordreDR.Close()
          If Not first Then
            HTMLTekst.Append("</TABLE><br>")
            HTMLTekst.Append("<b>Bemærk:</b> Hvis samme modtager optræder flere gange, skal denne modtage flere bilagsblade.<br>")
            Dim mail As New clsEmail

            mail.Til = eMail
            mail.Subject = bladNavn & ": Bilagsblad reminder for uge " & _DenneUge.ToString
            mail.From = "OrdreUdsending@DeLokaleUgeaviser.dk"
            mail.BodyMappe = "Z:\Forsendelser\BilagsBladRemindere\" & _DetteÅr.ToString & "\" & _DenneUge.ToString
            mail.BodyFilNavn = bladNavn & " [" & eMail & "]"
            mail.Body = HTMLTekst.ToString
            succes = mail.Send()
          End If
        End If
      End While
      cn2.Close()
      ordreCM.Dispose()
      bladDR.Dispose()
      cn2.Dispose()
    End If

    _LPVersion = System.String.Format("{0:00}{1:00}{2:00}{3:0000}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
    'cm.CommandText = "SELECT TOP 1 LPVersion FROM OpdateringsTekst ORDER BY LPVersion DESC"

    If _LPVersion <> _BrugersLPVersion Then
      VisOpdateringsTekst()
      'ElseIf _LPVersion < cm.ExecuteScalar Then
      '  Me.Text = "Lokal Planner - Opdater til den nyeste version."
    End If
    cm.CommandText = "UPDATE tblBrugerData SET SidsteLoginVersion = '" & _LPVersion & "', NulstilLayout = '0' WHERE (Initialer = '" & BrugerNavn & "')"
    cm.ExecuteNonQuery()
    cm.Dispose()
    cn.Close()
    cn.Dispose()

    Dim oms As Double = getOmsætning()
    statusBar.Panels(1).Text = "Oms. uge " & _DenneUge + 1 & ": " & oms.ToString("#,##0.00")

    'Me.AppStylist.LoadFromStyleManager()
    'Me.AppStylist.ShowRuntimeApplicationStylingEditor(Me, "Lokal planner.ISL")
  End Sub

  Private Sub VisOpdateringsTekst()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim opdateringDR As SqlDataReader
    Dim f As New frmCheckTekst("Din Lokalplanner er blevet opdateret." & vbCrLf, "Ændringer i versioner.")

    cn.Open()
    cm.CommandText = "SELECT LPVersion, Beskrivelse FROM OpdateringsTekst ORDER BY LPVersion DESC"
    opdateringDR = cm.ExecuteReader(CommandBehavior.Default)
    While opdateringDR.Read
      f.txtTekst.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" & vbCrLf)
      f.txtTekst.AppendText(opdateringDR("LPVersion") & ":" & vbCrLf & opdateringDR("Beskrivelse").ToString.Replace("<br>", vbCrLf) & vbCrLf)
    End While
    opdateringDR.Close()
    opdateringDR.Dispose()
    cm.Dispose()
    cn.Close()
    cn.Dispose()
    f.Show()
    f.btnLuk.Enabled = True
  End Sub

  Private Function getOmsætning() As Double
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim omsætning As Double

    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT SUM(tblMedieplan.SamletPris) AS Omsætning FROM tblMedieplanNr INNER JOIN tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version WHERE (tblMedieplanNr.Status = 3 OR tblMedieplanNr.Status > 4) AND (tblMedieplan.IndrykningsUge = " & _DenneUge + 1 & ") AND (tblMedieplan.IndrykningsÅr = " & _DetteÅr & ")"
    cn.Open()
    If IsDBNull(cm.ExecuteScalar) Then
      omsætning = 0
    Else
      omsætning = cm.ExecuteScalar
    End If
    cm.CommandText = "SELECT TOP 1 LPVersion FROM OpdateringsTekst ORDER BY LPVersion DESC"
    If _LPVersion < cm.ExecuteScalar Then
      Me.Text = "Lokal Planner - Opdater til den nyeste version."
    End If
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    Return omsætning
  End Function

  Private Sub grdFindUgeavis_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdFindUgeavis.DoubleClickRow
    If TypeOf (Me.ActiveMdiChild) Is FrmBladStamData Then
      Dim tempChild As FrmBladStamData = Me.ActiveMdiChild
      If tempChild.LockStatus = True Then
        tempChild.TblBladStamdataBindingSource.Filter = "BladID = " & e.Row.Cells("BladID").Value
      Else
        Dim nyfrmBladStamdata As New FrmBladStamData(e.Row.Cells("BladID").Value)
        nyfrmBladStamdata.MdiParent = Me
        nyfrmBladStamdata.LockStatus = False
        nyfrmBladStamdata.Show()
      End If
    ElseIf TypeOf (Me.ActiveMdiChild) Is frmRabatformer Then
      Dim tempChild As frmRabatformer = Me.ActiveMdiChild
      Dim found As Boolean = False
      If HarRollen("Admin") Then
        If tempChild.cboRabatformer.SelectedIndex >= 0 Then
          For Each arow As UltraGridRow In tempChild.grdBladeMedIRabatform.Rows.GetAllNonGroupByRows
            If arow.Cells("BladID").Value = e.Row.Cells("BladID").Value Then found = True
          Next
          If Not found Then
            tempChild.DstBladeMedIRabatform.Tables(0).Rows.Add(New Object() {e.Row.Cells("BladID").Value, e.Row.Cells("Navn").Value, False})
            tempChild.TblBladeMedIRabatformTableAdapter.InsertQuery(tempChild.cboRabatformer.Value, e.Row.Cells("BladID").Value, tempChild.tscVersion.SelectedTab.Key)
          End If
        End If
      End If
    Else
      If e.Row.IsDataRow Then
        OverførEnkeltUgeavisFraRow(e.Row)
      ElseIf e.Row.IsGroupByRow Then
        If _GrupperVisning Then
          Dim i As Integer
          Dim fundetGruppe As Integer = -1
          Dim arow As UltraGridGroupByRow = CType(e.Row, UltraGridGroupByRow)

          For i = 0 To UBound(_gruppeVersion(_AktivGruppeVersion)._gruppe)
            If _gruppeVersion(_AktivGruppeVersion)._gruppe(i).Navn = arow.Value Then
              fundetGruppe = i
              Exit For
            End If
          Next
          If fundetGruppe > -1 Then
            If _gruppeVersion(_AktivGruppeVersion)._gruppe(fundetGruppe).Rabatter IsNot Nothing Then
              For Each frm As Form In My.Application.OpenForms
                If frm.Name = "frm" & arow.Value Then
                  frm.BringToFront()
                  Exit Sub
                End If
              Next
              Dim nyRabatVindue As New frmVisRabatter(fundetGruppe)
              nyRabatVindue.Text = "Rabatter for " & arow.Value
              nyRabatVindue.Name = "frm" & arow.Value
              Dim xLoc As Integer = Me.Width - nyRabatVindue.Width
              Dim yLoc As Integer = Cursor.Position.Y
              Dim yHeight As Integer = 100 + UBound(_gruppeVersion(_AktivGruppeVersion)._gruppe(fundetGruppe).Rabatter) * 18
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
    End If
  End Sub

  Private Sub OverførEnkeltUgeavisFraRow(ByVal therow As UltraGridRow)
    Dim found As Boolean = False

    Me.Cursor = Cursors.WaitCursor
    If TypeOf (Me.ActiveMdiChild) Is frmMedieplan Then
      Dim tempChild As frmMedieplan = Me.ActiveMdiChild

      If tempChild.IsAktiv Then
        If tempChild.Is6Spaltet AndAlso (therow.Cells("BladID").Value = 246 OrElse therow.Cells("BladID").Value = 417) Then
          MessageBox.Show("Kan ikke tilføje 5 spaltet avis til 6 spaltet plan.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
          Exit Sub
        End If
        For Each arow As UltraDataRow In tempChild.DataSourceMedieplan.Rows
          If arow.Item("UgeavisID") = therow.Cells("BladID").Value Then
            found = True
            Exit For
          End If
        Next
        If Not found Then
          If tempChild.Status = StatusKoder.stsUdsendtOrdre OrElse (tempChild.Status = StatusKoder.stsOrdreIkkeSendt AndAlso tempChild.Version > 1) Then
            If MessageBox.Show("Skal rabatter låses for automatiske ændringer?", "Lås rabatter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
              tempChild.LåsDataFelter()
            End If
          End If
          tempChild.DataSourceMedieplan.Rows.Add(True, New Object() {0, therow.Cells("BladID").Value, therow.Cells("GeoKodeNavn").Value, therow.Cells("GeoKodeSortKey").Value, therow.Cells("HovedGruppeNavn").Value, therow.Cells("HovedGruppeSortKey").Value, ""})
        End If
      End If
    Else
      Dim nyfrmMedieplan As New frmMedieplan(Me.AktivtModul)

      nyfrmMedieplan.MdiParent = Me
      nyfrmMedieplan.DataSourceMedieplan.Rows.Add(True, New Object() {0, therow.Cells("BladID").Value, therow.Cells("GeoKodeNavn").Value, therow.Cells("GeoKodeSortKey").Value, therow.Cells("HovedGruppeNavn").Value, therow.Cells("HovedGruppeSortKey").Value, ""})
      nyfrmMedieplan.Show()
      nyfrmMedieplan.WindowState = FormWindowState.Maximized
    End If
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnFindUgeavis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindUgeavis.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    Me.Cursor = Cursors.WaitCursor
    Try
      cm.CommandText = "DELETE FROM tblPostNrSøgning WHERE BrugerNavn='" & _BrugerNavn & "'"
      cm.CommandType = CommandType.Text
      cn.Open()
      cm.ExecuteNonQuery()

      If txtPostNr.Text.Length > 0 Then
        Dim PostNr() As String
        Dim i As Integer
        Dim etPostNr As Integer
        Dim andetPostNr As Integer
        Dim flerePostNr() As String

        PostNr = Split(txtPostNr.Text, ",")

        For i = 0 To UBound(PostNr)
          If InStr(PostNr(i), "-") > 0 Then
            flerePostNr = Split(PostNr(i), "-")
            etPostNr = CInt(flerePostNr(0))
            andetPostNr = CInt(flerePostNr(1))
            cm.CommandText = "INSERT INTO tblPostNrSøgning (BrugerNavn, PostNr) SELECT '" & _BrugerNavn & "', PostNr FROM tblPostNr WHERE PostNr BETWEEN " & etPostNr & " AND " & andetPostNr
          Else
            etPostNr = CInt(PostNr(i))
            cm.CommandText = "INSERT INTO tblPostNrSøgning (BrugerNavn, PostNr) VALUES ('" & _BrugerNavn & "'," & etPostNr & ")"
          End If
          cm.ExecuteNonQuery()
        Next i
      End If
      If txtPostBy.Text.Length > 0 Then
        Dim PostBy() As String
        Dim i As Integer
        Dim enPostBy As String

        PostBy = Split(txtPostBy.Text, ",")

        For i = 0 To UBound(PostBy)
          enPostBy = "%" & LCase(PostBy(i)) & "%"
          cm.CommandText = "INSERT INTO tblPostNrSøgning (BrugerNavn, PostNr) SELECT '" & _BrugerNavn & "', PostNr FROM tblPostNr WHERE LOWER(PostBy) LIKE '" & enPostBy & "'"
          cm.ExecuteNonQuery()
        Next i
      End If

      If txtPostNr.Text.Length > 0 OrElse txtPostBy.Text.Length > 0 Then
        Me.TblBladStamdataTableAdapter.FillByPostNrMedDækningsgrad(Me.DiMPdotNetDataSet.tblBladStamdata, numDækningsGrad.Value, _BrugerNavn)
      Else
        Me.TblBladStamdataTableAdapter.FillByDækningsGrad(Me.DiMPdotNetDataSet.tblBladStamdata, numDækningsGrad.Value)
      End If
      'grdFindUgeavis.DisplayLayout.Bands(0).Columns("PostNr").Hidden = False
      'grdFindUgeavis.DisplayLayout.Bands(0).Columns("PostBy").Hidden = False
      grdFindUgeavis.DisplayLayout.Bands(0).Columns("DækningsGrad").Hidden = False
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Clear()
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("Navn", False, False)
    Catch
    Finally
      cn.Close()
      cn.Dispose()
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub toolbarManager_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles toolbarManager.ToolClick
    Select Case e.Tool.Key
      Case "Afslut"
        Application.Exit()

      Case "Opret Medieplan"
        Me.AktivtModul = "Medieplan"
        Dim nyFrmMedieplan As New frmMedieplan("Medieplan")
        nyFrmMedieplan.MdiParent = Me
        nyFrmMedieplan.Show()
        nyFrmMedieplan.WindowState = FormWindowState.Maximized

      Case "Find Medieplan"
        Me.AktivtModul = "Medieplan"
        If dockManager.ControlPanes("Find Medieplan").Pinned = False Then
          Me.dockManager.ControlPanes("Find Medieplan").Flyout(True, True)
        Else
          dockManager.ControlPanes("Find Medieplan").Show()
        End If

      Case "Vis Forespørgsler"
        frmForespørgsler.MdiParent = Me
        frmForespørgsler.Show()
        frmForespørgsler.WindowState = FormWindowState.Maximized

      Case "Konkurrent Info"
        '   UgeavisIDListeFraAktivMedieplan = "5;10;15;25;30;35;40;100;150;200;250;300"
        If TypeOf (Me.ActiveMdiChild) Is frmMedieplan Then
          Dim aktivPlan As frmMedieplan = Me.ActiveMdiChild
          UgeavisIDListeFraAktivMedieplan = aktivPlan.UgeavisIDListe
          If UgeavisIDListeFraAktivMedieplan.Length > 0 Then
            frmKonkurrentInfo.MdiParent = Me
            frmKonkurrentInfo.Show()
            frmKonkurrentInfo.WindowState = FormWindowState.Maximized
          End If
        End If

      Case "Opret Medieplan Booking"
        Me.AktivtModul = "Booking"
        Dim nyFrmMedieplan As New frmMedieplan("Booking")
        nyFrmMedieplan.MdiParent = Me
        nyFrmMedieplan.Show()
        nyFrmMedieplan.WindowState = FormWindowState.Maximized

      Case "Find Medieplan Booking"
        Me.AktivtModul = "Booking"
        If dockManager.ControlPanes("Find Medieplan").Pinned = False Then
          Me.dockManager.ControlPanes("Find Medieplan").Flyout(True, True)
        Else
          dockManager.ControlPanes("Find Medieplan").Show()
        End If

      Case "Find Medieplan Fakturering"
        Me.AktivtModul = "Fakturering"
        If dockManager.ControlPanes("Find Medieplan").Pinned = False Then
          Me.dockManager.ControlPanes("Find Medieplan").Flyout(True, True)
        Else
          dockManager.ControlPanes("Find Medieplan").Show()
        End If

      Case "Mangler Annoncekontrol"
        frmAnnonceKontrol.MdiParent = Me
        frmAnnonceKontrol.Show()
        frmAnnonceKontrol.WindowState = FormWindowState.Maximized

      Case "Vis Fejl"
        frmFejlListe.MdiParent = Me
        frmFejlListe.Show()
        frmFejlListe.WindowState = FormWindowState.Maximized

      Case "Vis Åbne Fakturerings Bilag"
        frmFaktureringsBilagListe.MdiParent = Me
        frmFaktureringsBilagListe.Show()
        frmFaktureringsBilagListe.WindowState = FormWindowState.Maximized

      Case "Skal Sendes"
        frmSkalSendes.MdiParent = Me
        frmSkalSendes.Show()
        frmSkalSendes.WindowState = FormWindowState.Maximized

      Case "Er Sendt"
        frmErSendt.MdiParent = Me
        frmErSendt.Show()
        frmErSendt.WindowState = FormWindowState.Maximized

      Case "Booking Liste"
        frmBookingListe.MdiParent = Me
        frmBookingListe.Show()
        frmBookingListe.WindowState = FormWindowState.Maximized

      Case "Send til Navision"
        frmSendTilNavision.ShowDialog()

      Case "Fjern overført ordre"
        frmFjernOverførtOrdre.ShowDialog()

      Case "Skift Status"
        frmSkiftStatus.ShowDialog()

      Case "Gen Udsending"
        frmUdsending.MdiParent = Me
        frmUdsending.Show()

      Case "Annoncør omsætning"
        frmOmsætning.MdiParent = Me
        frmOmsætning.Show()
        frmOmsætning.WindowState = FormWindowState.Maximized

      Case "Bergske afstemning"
        frmBerskeAfstemning.MdiParent = Me
        frmBerskeAfstemning.Show()
        frmBerskeAfstemning.WindowState = FormWindowState.Maximized

      Case ("Ugeavis Stamdata")
        Me.Cursor = Cursors.WaitCursor
        FrmBladStamData.MdiParent = Me
        FrmBladStamData.Show()
        Me.Cursor = Cursors.Default

      Case "Kontakter"
        Me.AktivtModul = "Kontakter"
        Dim nyFrmKontakter As New frmOpretKontakt
        nyFrmKontakter.MdiParent = Me
        nyFrmKontakter.Show()
 

      Case "Send til Web"
        frmWebExport.MdiParent = Me
        frmWebExport.Show()

      Case "Rabatformer"
        frmRabatformer.MdiParent = Me
        frmRabatformer.Show()
        frmRabatformer.WindowState = FormWindowState.Maximized

      Case "Miljøtillæg"
        frmMiljøTillæg.MdiParent = Me
        frmMiljøTillæg.Show()

      Case "Om Lokalplanner"
        frmAbout.ShowDialog()

      Case "OpdateringsTekst"
        VisOpdateringsTekst()

      Case "Slet Filer"
        frmSletFiler.ShowDialog()

    End Select
  End Sub

  Private Sub NulstilSelectedText(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.ValidationErrorEventArgs) _
                                  Handles cboAnnoncør.ItemNotInList, _
                                          cboAnnoncørBooking.ItemNotInList, _
                                          cboBureau.ItemNotInList, _
                                          cboBureauBooking.ItemNotInList, _
                                          cboUgeavisBooking.ItemNotInList
    sender.text = e.LastValidValue
  End Sub

  Private Sub grdFindUgeavis_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdFindUgeavis.MouseUp
    Dim elementFromPoint As UIElement = grdFindUgeavis.DisplayLayout.UIElement.ElementFromPoint(e.Location)

    If (elementFromPoint IsNot Nothing) Then
      If (TypeOf elementFromPoint.GetAncestor(GetType(FilterClearButtonUIElement)) Is FilterClearButtonUIElement) Then
        Me.Cursor = Cursors.WaitCursor
        NulstilBladGrid()
        Me.Cursor = Cursors.Default
      End If
    End If
  End Sub

  Private Sub NulstilBladGrid()
    txtPostNr.Text = ""
    txtPostBy.Text = ""
    numDækningsGrad.Value = 0
    If Not _GrupperVisning Then
      Me.TblBladStamdataTableAdapter.Fill(Me.DiMPdotNetDataSet.tblBladStamdata)
      grdFindUgeavis.DisplayLayout.Bands(0).Columns("DækningsGrad").Hidden = True
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Clear()
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("Navn", False, False)
      grdFindUgeavis.DisplayLayout.Override.GroupByRowExpansionStyle = GroupByRowExpansionStyle.ExpansionIndicatorAndDoubleClick
    Else
      Me.TblBladStamdataTableAdapter.FillGrupper(Me.DiMPdotNetDataSet.tblBladStamdata)
      grdFindUgeavis.DisplayLayout.Bands(0).Columns("DækningsGrad").Hidden = True
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Clear()
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GruppeNavn", False, True)
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("Navn", False, False)
      grdFindUgeavis.DisplayLayout.Override.GroupByRowExpansionStyle = GroupByRowExpansionStyle.Disabled
    End If
  End Sub

  Private Sub btnSøg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click, btnFindBooking.Click
    Dim antalRows As Integer
    Dim versionFra As Integer = 0
    Dim versionTil As Integer = 999
    Dim ugeStart As Integer
    Dim årStart As Integer
    Dim ugeSlut As Integer
    Dim årSlut As Integer

    Me.Cursor = Cursors.WaitCursor
    If _VisMedieplanVersioner Then
      versionFra = 1
      versionTil = 9
      If _VisBookingVersioner Then
        versionTil = 99
        If _VisFaktureringVersioner Then
          versionTil = 999
        End If
      Else
        If _VisFaktureringVersioner Then
          versionTil = 999
        End If
      End If
    Else
      If _VisBookingVersioner Then
        versionFra = 11
        versionTil = 99
        If _VisFaktureringVersioner Then
          versionTil = 999
        End If
      Else
        If _VisFaktureringVersioner Then
          versionFra = 111
          versionTil = 999
        Else
          versionFra = 0
          versionTil = 0
        End If
      End If
    End If
    Me.TblFundneplanerTableAdapter.ClearBeforeFill = True
    If Me.AktivtModul = "Medieplan" Then
      If numFraUge.Value > numTilUge.Value Then
        årStart = numÅr.Value - 1
        årSlut = numÅr.Value
      Else
        årStart = numÅr.Value
        årSlut = numÅr.Value
      End If
      ugeStart = numFraUge.Value
      ugeSlut = numTilUge.Value
      Select Case True
        Case txtMedieplanNr.TextLength > 0
          antalRows = Me.TblFundneplanerTableAdapter.FillByMedieplanNr(Me.DstFindMedieplaner.tblFundneplaner, txtMedieplanNr.Text, versionFra, versionTil, _MedtagRettelser)

        Case cboAnnoncør.TextLength > 0 AndAlso cboBureau.TextLength > 0 AndAlso txtKonsulent.TextLength > 0
          'alle valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, cboBureau.Value, UCase(txtKonsulent.Text), ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, cboBureau.Value, UCase(txtKonsulent.Text), ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, cboBureau.Value, UCase(txtKonsulent.Text), 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncør.TextLength > 0 AndAlso cboBureau.TextLength > 0
          'anon bure valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, cboBureau.Value, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, cboBureau.Value, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, cboBureau.Value, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncør.TextLength > 0 AndAlso txtKonsulent.TextLength > 0
          'anon kons valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, txtKonsulent.Text, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, txtKonsulent.Text, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, txtKonsulent.Text, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboBureau.TextLength > 0 AndAlso txtKonsulent.TextLength > 0
          'bure kons valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboBureau.Value, txtKonsulent.Text, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboBureau.Value, txtKonsulent.Text, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboBureau.Value, txtKonsulent.Text, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncør.TextLength > 0
          'anon valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncør.Value, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboBureau.TextLength > 0
          'bure valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboBureau.Value, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboBureau.Value, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboBureau.Value, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case txtKonsulent.TextLength > 0
          'kons valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, UCase(txtKonsulent.Text), ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, UCase(txtKonsulent.Text), ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, UCase(txtKonsulent.Text), 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case Else
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByUger(Me.DstFindMedieplaner.tblFundneplaner, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByUger(Me.DstFindMedieplaner.tblFundneplaner, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByUger(Me.DstFindMedieplaner.tblFundneplaner, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If
      End Select
    Else
      If numFraUgeBooking.Value > numTilUgeBooking.Value Then
        årStart = numÅrBooking.Value - 1
        årSlut = numÅrBooking.Value
      Else
        årStart = numÅrBooking.Value
        årSlut = numÅrBooking.Value
      End If
      ugeStart = numFraUgeBooking.Value
      ugeSlut = numTilUgeBooking.Value
      Select Case True
        Case txtMedieplanNrBooking.TextLength > 0
          antalRows = Me.TblFundneplanerTableAdapter.FillByMedieplanNr(Me.DstFindMedieplaner.tblFundneplaner, txtMedieplanNrBooking.Text, versionFra, versionTil, _MedtagRettelser)

        Case txtBureauordreNrBooking.TextLength > 0
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauOrdreNr(Me.DstFindMedieplaner.tblFundneplaner, ugeStart, ugeSlut, årStart, txtBureauordreNrBooking.Text, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauOrdreNr(Me.DstFindMedieplaner.tblFundneplaner, ugeStart, 53, årStart, txtBureauordreNrBooking.Text, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByBureauOrdreNr(Me.DstFindMedieplaner.tblFundneplaner, 1, ugeSlut, årSlut, txtBureauordreNrBooking.Text, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncørBooking.TextLength > 0 AndAlso cboBureauBooking.TextLength > 0 AndAlso cboUgeavisBooking.TextLength > 0
          'alle valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, ugeStart, ugeSlut, årStart, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, ugeStart, 53, årStart, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, 1, ugeSlut, årSlut, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncørBooking.TextLength > 0 AndAlso cboBureauBooking.TextLength > 0 AndAlso txtKonsulentBooking.TextLength > 0
          'alle valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, UCase(txtKonsulentBooking.Text), ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, UCase(txtKonsulentBooking.Text), ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, UCase(txtKonsulentBooking.Text), 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncørBooking.TextLength > 0 AndAlso txtKonsulentBooking.TextLength > 0
          'anon kons valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, txtKonsulentBooking.Text, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, txtKonsulentBooking.Text, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, txtKonsulentBooking.Text, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncørBooking.TextLength > 0 AndAlso cboBureauBooking.TextLength > 0
          'anon bure valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNoBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, cboBureauBooking.Value, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncørBooking.TextLength > 0 AndAlso cboUgeavisBooking.TextLength > 0
          'anon ugea valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, ugeStart, ugeSlut, årStart, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, ugeStart, 53, årStart, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, 1, ugeSlut, årSlut, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboBureauBooking.TextLength > 0 AndAlso txtKonsulentBooking.TextLength > 0
          'bure kons valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, txtKonsulentBooking.Text, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, txtKonsulentBooking.Text, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByBureauNoKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, txtKonsulentBooking.Text, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboBureauBooking.TextLength > 0 AndAlso cboUgeavisBooking.TextLength > 0
          'bure ugea valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, ugeStart, ugeSlut, årStart, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, ugeStart, 53, årStart, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByBureauNoUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, 1, ugeSlut, årSlut, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboAnnoncørBooking.TextLength > 0
          'anon valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByAnnoncørNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByAnnoncørNo(Me.DstFindMedieplaner.tblFundneplaner, cboAnnoncørBooking.Value, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboBureauBooking.TextLength > 0
          'bure valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByBureauNo(Me.DstFindMedieplaner.tblFundneplaner, cboBureauBooking.Value, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case cboUgeavisBooking.TextLength > 0
          'ugea valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, ugeStart, ugeSlut, årStart, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, ugeStart, 53, årStart, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByUgeavisID(Me.DstFindMedieplaner.tblFundneplaner, 1, ugeSlut, årSlut, cboUgeavisBooking.Value, versionFra, versionTil, _MedtagRettelser)
          End If

        Case txtKonsulentBooking.TextLength > 0
          'kons valgt
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, UCase(txtKonsulentBooking.Text), ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, UCase(txtKonsulentBooking.Text), ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByKonsulentCode(Me.DstFindMedieplaner.tblFundneplaner, UCase(txtKonsulentBooking.Text), 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If

        Case Else
          If ugeStart <= ugeSlut Then
            antalRows = Me.TblFundneplanerTableAdapter.FillByUger(Me.DstFindMedieplaner.tblFundneplaner, ugeStart, ugeSlut, årStart, versionFra, versionTil, _MedtagRettelser)
          Else
            antalRows = Me.TblFundneplanerTableAdapter.FillByUger(Me.DstFindMedieplaner.tblFundneplaner, ugeStart, 53, årStart, versionFra, versionTil, _MedtagRettelser)
            Me.TblFundneplanerTableAdapter.ClearBeforeFill = False
            antalRows = antalRows + Me.TblFundneplanerTableAdapter.FillByUger(Me.DstFindMedieplaner.tblFundneplaner, 1, ugeSlut, årSlut, versionFra, versionTil, _MedtagRettelser)
          End If
      End Select
    End If
    If antalRows <> 1 Then
      Me.dockManager.ControlPanes("Fundne Planer").Text = String.Format("Fundet {0} planer via {1} søgning", antalRows, Me.AktivtModul)
    Else
      Me.dockManager.ControlPanes("Fundne Planer").Text = String.Format("Fundet 1 plan via {0} søgning", Me.AktivtModul)
    End If
    If antalRows > 20 Then
      antalRows = 20
    End If
    Me.dockManager.ControlPanes("Fundne Planer").DockAreaPane.Size = New Size(-1, (antalRows * 18) + 40)
    Me.dockManager.ControlPanes("Fundne Planer").FlyoutSize = New Size(-1, (antalRows * 18) + 40)
    Me.dockManager.ControlPanes("Fundne Planer").Size = New Size(-1, (antalRows * 18) + 40)
    If dockManager.ControlPanes("Fundne Planer").Pinned = False Then
      Me.dockManager.ControlPanes("Fundne Planer").Flyout(True, True)
    Else
      dockManager.ControlPanes("Fundne Planer").Show()
    End If
    If antalRows > 0 Then grdFundnePlaner.ActiveRow = grdFundnePlaner.Rows.Item(grdFundnePlaner.Rows.Count - 1)
    'Nulstil søgefelter
    txtMedieplanNr.Text = ""
    txtMedieplanNrBooking.Text = ""
    cboAnnoncør.Value = Nothing
    cboAnnoncørBooking.Value = Nothing
    cboBureau.Value = Nothing
    cboBureauBooking.Value = Nothing
    txtKonsulent.Text = ""
    txtKonsulentBooking.Text = ""
    cboUgeavisBooking.Value = Nothing
    txtBureauordreNrBooking.Text = ""
    Me.AcceptButton = Nothing
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub grdFundnePlaner_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdFundnePlaner.DoubleClickRow
    Dim mediePlanNr As Integer
    Dim version As Integer

    Integer.TryParse(e.Row.Cells("MedieplanNr").Value, mediePlanNr)
    Integer.TryParse(e.Row.Cells("Version").Value, version)
    ÅbenPlan(mediePlanNr, version)
  End Sub

  Private Sub ÅbenPlan(ByVal mediePlanNr As Integer, ByVal version As Integer)
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim _aktivVersion As Integer

    If mediePlanNr > 0 AndAlso version > 0 Then
      Me.Cursor = Cursors.WaitCursor
      cm.CommandType = CommandType.Text
      cm.CommandText = "SELECT AktivVersion FROM tblMedieplanNr WHERE (MedieplanNr = " & mediePlanNr & ")"
      cn.Open()
      _aktivVersion = cm.ExecuteScalar
      cn.Close()
      cm.Dispose()
      cn.Dispose()
      If version < 10 AndAlso version <> _aktivVersion Then Me.AktivtModul = "Medieplan"
      If version > 10 Then Me.AktivtModul = "Booking"
      If version > 110 Then Me.AktivtModul = "Fakturering"
      Dim nyFrmMedieplan As New frmMedieplan(Me.AktivtModul, mediePlanNr, version)
      nyFrmMedieplan.MdiParent = Me
      nyFrmMedieplan.Show()
      nyFrmMedieplan.WindowState = FormWindowState.Maximized
      Me.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub dockManager_PaneActivate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinDock.ControlPaneEventArgs) Handles dockManager.PaneActivate
    Select Case e.Pane.Control.Name
      Case "panFindMedieplan"
        Me.AcceptButton = btnFind
      Case "panFindMedieplanBooking"
        Me.AcceptButton = btnFindBooking
      Case "grdFundnePlaner"
        Me.AcceptButton = Nothing
    End Select
  End Sub

  Private Sub grdFindUgeavis_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdFindUgeavis.GotFocus
    Me.AcceptButton = btnOverførBlade
  End Sub

  Private Sub txtPostNr_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPostNr.Enter
    Me.AcceptButton = btnFindUgeavis
  End Sub

  Private Sub txtPostBy_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPostBy.Enter
    Me.AcceptButton = btnFindUgeavis
  End Sub

  Private Sub btnOverførBlade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverførBlade.Click
    If TypeOf (Me.ActiveMdiChild) Is FrmBladStamData Then
      Dim tempChild As FrmBladStamData = Me.ActiveMdiChild
      Dim findString As String = ""
      If tempChild.LockStatus = True Then
        If grdFindUgeavis.Rows.FilteredInNonGroupByRowCount = 1 Then
          tempChild.TblBladStamdataBindingSource.Filter = "BladID = " & grdFindUgeavis.Rows.GetFilteredInNonGroupByRows()(0).Cells("BladID").Value
        Else
          For Each arow As UltraGridRow In grdFindUgeavis.Selected.Rows
            findString = findString & "BladID = " & arow.Cells("BladID").Value & " OR "
            arow.Selected = False
          Next
          If findString.Length > 3 Then
            tempChild.TblBladStamdataBindingSource.Filter = findString.Remove(findString.Length - 4, 4)
          Else
            tempChild.TblBladStamdataBindingSource.Filter = ""
          End If
        End If
      Else
        If grdFindUgeavis.Rows.FilteredInNonGroupByRowCount = 1 Then
          Dim nyfrmBladStamdata As New FrmBladStamData(grdFindUgeavis.Rows.GetFilteredInNonGroupByRows()(0).Cells("BladID").Value)
          nyfrmBladStamdata.MdiParent = Me
          nyfrmBladStamdata.LockStatus = False
          nyfrmBladStamdata.Show()
        Else
          For Each arow As UltraGridRow In grdFindUgeavis.Selected.Rows
            Dim nyfrmBladStamdata As New FrmBladStamData(arow.Cells("BladID").Value)
            nyfrmBladStamdata.MdiParent = Me
            nyfrmBladStamdata.LockStatus = False
            nyfrmBladStamdata.Show()
          Next
        End If
      End If
    Else
      If grdFindUgeavis.Rows.FilteredInNonGroupByRowCount = 1 Then
        OverførEnkeltUgeavisFraRow(grdFindUgeavis.Rows.GetFilteredInNonGroupByRows()(0))
        grdFindUgeavis.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        grdFindUgeavis.Rows.FilterRow.Cells(0).Selected = True
      Else
        Me.Cursor = Cursors.WaitCursor
        For Each arow As UltraGridRow In grdFindUgeavis.Selected.Rows
          OverførEnkeltUgeavisFraRow(arow)
          arow.Selected = False
        Next
        Me.Cursor = Cursors.Default
      End If
    End If
  End Sub

  Private Sub grdFundnePlaner_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdFundnePlaner.GotFocus
    Me.AcceptButton = Nothing
  End Sub

  Private Sub grdFundnePlaner_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles grdFundnePlaner.InitializeRow
    If e.ReInitialize Then Exit Sub
    If e.Row.Cells("RettelserEfterAnnoncekontrol").Value = True Then
      e.Row.Appearance.BackColor = Color.OrangeRed
    End If
  End Sub

  Private Sub grdFundnePlaner_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdFundnePlaner.KeyDown
    Dim mediePlanNr As Integer
    Dim version As Integer
    If e.KeyCode = Keys.Return OrElse e.KeyCode = Keys.Enter Then
      Integer.TryParse(grdFundnePlaner.ActiveRow.Cells("MedieplanNr").Value, mediePlanNr)
      Integer.TryParse(grdFundnePlaner.ActiveRow.Cells("Version").Value, version)
      If mediePlanNr > 0 Then ÅbenPlan(mediePlanNr, version)
    End If
  End Sub

  Private Sub btnGrupper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupper.Click
    If _GrupperVisning Then
      _GrupperVisning = False
      btnGrupper.Text = "Grupper"
      chkMedtagOphørte.Enabled = True
      Me.TblBladStamdataTableAdapter.Fill(Me.DiMPdotNetDataSet.tblBladStamdata)
      grdFindUgeavis.DisplayLayout.Bands(0).Columns("DækningsGrad").Hidden = True
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Clear()
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("Navn", False, False)
      grdFindUgeavis.DisplayLayout.Override.GroupByRowExpansionStyle = GroupByRowExpansionStyle.ExpansionIndicatorAndDoubleClick
    Else
      _GrupperVisning = True
      btnGrupper.Text = "Aviser"
      chkMedtagOphørte.Checked = False
      chkMedtagOphørte.Enabled = False
      Me.TblBladStamdataTableAdapter.FillGrupper(Me.DiMPdotNetDataSet.tblBladStamdata)
      grdFindUgeavis.DisplayLayout.Bands(0).Columns("DækningsGrad").Hidden = True
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Clear()
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GruppeNavn", False, True)
      grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("Navn", False, False)
      grdFindUgeavis.DisplayLayout.Override.GroupByRowExpansionStyle = GroupByRowExpansionStyle.Disabled
    End If
  End Sub

  Private Sub grdFindUgeavis_InitializeGroupByRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles grdFindUgeavis.InitializeGroupByRow
    If e.ReInitialize Then Exit Sub
    If _GrupperVisning Then
      If e.Row.Column.Key = "GeoKodeNavn" Then
        If e.Row.Rows.Count = 1 Then
          e.Row.Description = e.Row.Value & " (" & e.Row.Rows.Count & " gruppe)"
        Else
          e.Row.Description = e.Row.Value & " (" & e.Row.Rows.Count & " grupper)"
        End If
      End If
    End If
  End Sub

  Private Sub frmMain_MdiChildActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
    If TypeOf (Me.ActiveMdiChild) Is FrmBladStamData Then
      lblDækningsgrad.Visible = False
      numDækningsGrad.Visible = False
      chkMedtagOphørte.Visible = True
      If chkMedtagOphørte.Checked Then
        If _VisningIBladGrid <> "FillAlle" Then
          Me.TblBladStamdataTableAdapter.FillAlle(Me.DiMPdotNetDataSet.tblBladStamdata)
          _VisningIBladGrid = "FillAlle"
        End If
      Else
        If _VisningIBladGrid <> "Fill" Then
          Me.TblBladStamdataTableAdapter.Fill(Me.DiMPdotNetDataSet.tblBladStamdata)
          _VisningIBladGrid = "Fill"
        End If
      End If
    Else
      lblDækningsgrad.Visible = True
      numDækningsGrad.Visible = True
      chkMedtagOphørte.Visible = False
      If _GrupperVisning Then
        If _VisningIBladGrid <> "FillGrupper" Then
          Me.TblBladStamdataTableAdapter.FillGrupper(Me.DiMPdotNetDataSet.tblBladStamdata)
          _VisningIBladGrid = "FillGrupper"
        End If
      Else
        If _VisningIBladGrid <> "Fill" Then
          Me.TblBladStamdataTableAdapter.Fill(Me.DiMPdotNetDataSet.tblBladStamdata)
          _VisningIBladGrid = "Fill"
        End If
      End If
    End If
    If TypeOf (Me.ActiveMdiChild) Is frmMedieplan Then
      Dim aktivPlan As frmMedieplan = Me.ActiveMdiChild
      If aktivPlan.Modul = "Medieplan" Then
        toolbarManager.Tools(33).SharedProps.Visible = True
      Else
        toolbarManager.Tools(33).SharedProps.Visible = False
      End If
    Else
      toolbarManager.Tools(33).SharedProps.Visible = False
    End If
  End Sub

  Private Sub chkMedieplan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedieplan.CheckedChanged
    _VisMedieplanVersioner = chkMedieplan.Checked
  End Sub

  Private Sub chkMedieplanBooking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedieplanBooking.CheckedChanged
    _VisMedieplanVersioner = chkMedieplanBooking.Checked
  End Sub

  Private Sub chkBooking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBooking.CheckedChanged
    _VisBookingVersioner = chkBooking.Checked
  End Sub

  Private Sub chkBookingBooking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBookingBooking.CheckedChanged
    _VisBookingVersioner = chkBookingBooking.Checked
  End Sub

  Private Sub chkMedtagRettelser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedtagRettelser.CheckedChanged
    _MedtagRettelser = chkMedtagRettelser.Checked
  End Sub

  Private Sub chkMedtagRettelserBooking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedtagRettelserBooking.CheckedChanged
    _MedtagRettelser = chkMedtagRettelserBooking.Checked
  End Sub

  Private Sub chkFakturering_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFakturering.CheckedChanged
    _VisFaktureringVersioner = chkFakturering.Checked
  End Sub

  Private Sub chkFaktureringBooking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFaktureringBooking.CheckedChanged
    _VisFaktureringVersioner = chkFaktureringBooking.Checked
  End Sub

  Private Sub chkVisInAktive_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkVisInAktive.CheckedChanged
    _VisInAktive = chkVisInAktive.Checked
    If _VisInAktive Then
      cboAnnoncør.DataSource = TblBureauerBindingSource
      cboAnnoncørBooking.DataSource = TblBureauerBindingSource
    Else
      cboAnnoncør.DataSource = TblAnnoncørerBindingSource
      cboAnnoncørBooking.DataSource = TblAnnoncørerBindingSource
    End If
    cboAnnoncør.DataBind()
    cboAnnoncørBooking.DataBind()
  End Sub

  Private Sub chkVisInAktiveBooking_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkVisInAktiveBooking.CheckedChanged
    _VisInAktive = chkVisInAktiveBooking.Checked
    If _VisInAktive Then
      cboAnnoncør.DataSource = TblBureauerBindingSource
      cboAnnoncørBooking.DataSource = TblBureauerBindingSource
    Else
      cboAnnoncør.DataSource = TblAnnoncørerBindingSource
      cboAnnoncørBooking.DataSource = TblAnnoncørerBindingSource
    End If
    cboAnnoncør.DataBind()
    cboAnnoncørBooking.DataBind()
  End Sub

  Private Sub chkMedtagOphørte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedtagOphørte.CheckedChanged
    If chkMedtagOphørte.Checked Then
      If _VisningIBladGrid <> "FillAlle" Then
        Me.TblBladStamdataTableAdapter.FillAlle(Me.DiMPdotNetDataSet.tblBladStamdata)
        _VisningIBladGrid = "FillAlle"
      End If
    Else
      If _VisningIBladGrid <> "Fill" Then
        Me.TblBladStamdataTableAdapter.Fill(Me.DiMPdotNetDataSet.tblBladStamdata)
        _VisningIBladGrid = "Fill"
      End If
    End If
    grdFindUgeavis.DisplayLayout.Bands(0).Columns("DækningsGrad").Hidden = True
    grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Clear()
    grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("GeoKodeNavn", False, True)
    grdFindUgeavis.DisplayLayout.Bands(0).SortedColumns.Add("Navn", False, False)
    grdFindUgeavis.DisplayLayout.Override.GroupByRowExpansionStyle = GroupByRowExpansionStyle.ExpansionIndicatorAndDoubleClick
  End Sub

  Private Sub timerOmsætning_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerOmsætning.Tick
    Dim oms As Double = getOmsætning()
    statusBar.Panels(1).Text = "Oms. uge " & _DenneUge + 1 & ": " & oms.ToString("#,##0.00")
  End Sub

  Private Sub btnTilExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTilExcel.Click
    Dim fileName As String
    fileName = "M:\Bladliste.xls"
    ExcelExporter.Export(grdFindUgeavis, fileName)
    MessageBox.Show("Gemt som " & fileName, "Excel eksport", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub DiMPdotNetDataSetBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles DiMPdotNetDataSetBindingSource.CurrentChanged

  End Sub
End Class
