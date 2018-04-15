Imports System.Data.SqlClient
Imports System.Text

Public Class clsMedieplanHoved
  Private _NyeVærdier As New MedieplanData
  Private _OldVærdier As New MedieplanData

  Private _hasChanges As Boolean
  Private _isValid As Boolean
  Private _mediePlanNr As Integer
  Private _version As Integer
  Private _brugerCode As String
  'Private _tilladFarveSærRabat As Boolean = False
  Private _rettelserEfterAnnoncekontrol As Boolean = False
  Private _modul As String
  Private _samletPris As Double = 0
  Private _status As StatusKoder = StatusKoder.stsNyMedieplan
  Private _salgsAnsvarlig As String = ""
  Private _salgsAnsvarligTlf As String = ""
  Private _annoncørNavn As String = ""
  Private _annoncørAdresse As String = ""
  Private _annoncørPostNr As String = ""
  Private _annoncørPostBy As String = ""
  Private _annoncørTlf As String = ""
  Private _annoncørCVR As String = ""
  Private _annoncørEAN As String = ""
  Private _betalingsBetingelse As String = ""
  Private _infoGodtgørelse As Boolean
  Private _sikkerhedsGodtgørelse As Boolean
  Private _bureauNavn As String = ""
  Private _bureauAdresse As String = ""
  Private _bureauPostNr As String = ""
  Private _bureauPostBy As String = ""
  Private _bureauTlf As String = ""
  Private _bureauCVR As String = ""
  Private _oprindeligtMiljøTillæg As Double

  Public Event HasChanges(ByVal changes As Boolean)
  Public Event Validated(ByVal valid As Boolean)
  Public Event AndenBetalerFundet(ByVal ID As String)
  Public Event DårligBetalerFundet(ByVal betalingsBetingelse As String)

#Region "Readonly properties til Annoncør og Bureau + Info og Sikkerheds g.g."
  Public ReadOnly Property SalgsAnsvarlig() As String
    Get
      Return _salgsAnsvarlig
    End Get
  End Property

  Public ReadOnly Property SalgsAnsvarligTlf() As String
    Get
      Return _salgsAnsvarligTlf
    End Get
  End Property

  Public ReadOnly Property AnnoncørNavn() As String
    Get
      Return _annoncørNavn
    End Get
  End Property

  Public ReadOnly Property AnnoncørAdresse() As String
    Get
      Return _annoncørAdresse
    End Get
  End Property

  Public ReadOnly Property AnnoncørPostNr() As String
    Get
      Return _annoncørPostNr
    End Get
  End Property

  Public ReadOnly Property AnnoncørPostBy() As String
    Get
      Return _annoncørPostBy
    End Get
  End Property

  Public ReadOnly Property AnnoncørTlf() As String
    Get
      Return _annoncørTlf
    End Get
  End Property

  Public ReadOnly Property AnnoncørCVR() As String
    Get
      Return _annoncørCVR
    End Get
  End Property

  Public ReadOnly Property AnnoncørEAN() As String
    Get
      Return _annoncørEAN
    End Get
  End Property

  Public ReadOnly Property BureauNavn() As String
    Get
      Return _bureauNavn
    End Get
  End Property

  Public ReadOnly Property BureauAdresse() As String
    Get
      Return _bureauAdresse
    End Get
  End Property

  Public ReadOnly Property BureauPostNr() As String
    Get
      Return _bureauPostNr
    End Get
  End Property

  Public ReadOnly Property BureauPostBy() As String
    Get
      Return _bureauPostBy
    End Get
  End Property

  Public ReadOnly Property BureauTlf() As String
    Get
      Return _bureauTlf
    End Get
  End Property

  Public ReadOnly Property BureauCVR() As String
    Get
      Return _bureauCVR
    End Get
  End Property

  Public ReadOnly Property InfoGodtgørelse() As Boolean
    Get
      Return _infoGodtgørelse
    End Get
  End Property

  Public ReadOnly Property SikkerhedsGodtgørelse() As Boolean
    Get
      Return _sikkerhedsGodtgørelse
    End Get
  End Property
#End Region

  Public Property AnnoncørNO_() As String
    Get
      Return _NyeVærdier.AnnoncørNo_
    End Get
    Set(ByVal value As String)
      _NyeVærdier.AnnoncørNo_ = makeNullEmpty(value)
      If _NyeVærdier.AnnoncørNo_ <> "" Then
        Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
        Dim cm As New SqlCommand()
        cm = cn.CreateCommand
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT dbo.NavisionContact.Name AS AnnoncørNavn, dbo.NavisionContact.Address, dbo.NavisionContact.[Post Code] AS PostNr, dbo.NavisionContact.City AS PostBy, dbo.NavisionContact.[Phone No_] AS TlfNr, dbo.NavisionContact.[VAT Registration No_] AS CVR, dbo.NavisionContact.[EAN-nummer] AS EAN, dbo.Salesperson.Name AS Kundeansvarlig, dbo.Salesperson.[Phone No_] AS KundeansvarligTlf, dbo.NavisionContact.Infogodtgørelse, dbo.NavisionContact.Sikkerhedsgodtgørelse, dbo.NavisionContact.[Bill-to Contact No_] AS AndenBetaler, dbo.NavisionContact.[Payment Terms Code] AS BetalingsBetingelse FROM dbo.NavisionContact LEFT OUTER JOIN dbo.Salesperson ON dbo.NavisionContact.[Salesperson Code] = dbo.Salesperson.Code WHERE (dbo.NavisionContact.No_ = '" & value & "')"
        Dim dr As SqlDataReader
        cn.Open()
        dr = cm.ExecuteReader(CommandBehavior.SingleRow)
        dr.Read()
        If IsDBNull(dr("Kundeansvarlig")) Then
          _salgsAnsvarlig = ""
          MessageBox.Show("Der mangler salgsansvalig på denne annoncør." & vbCrLf & "Venligst sørg for at rette dette i Navision.", "Salgsansvarlig mangler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
          _salgsAnsvarlig = dr("Kundeansvarlig")
        End If
        If IsDBNull(dr("KundeansvarligTlf")) Then
          _salgsAnsvarligTlf = ""
        Else
          _salgsAnsvarligTlf = dr("KundeansvarligTlf")
        End If
        _annoncørNavn = dr("AnnoncørNavn")
        _annoncørAdresse = dr("Address")
        _annoncørPostNr = dr("PostNr")
        _annoncørPostBy = dr("PostBy")
        _annoncørTlf = dr("TlfNr")
        _annoncørCVR = dr("CVR")
        _annoncørEAN = dr("EAN")
        Dim andenBetaler As String = dr("AndenBetaler")
        If Not String.IsNullOrEmpty(andenBetaler) Then
          RaiseEvent AndenBetalerFundet(andenBetaler)
        Else
          RaiseEvent AndenBetalerFundet("")
        End If
        _betalingsBetingelse = dr("BetalingsBetingelse")
        If _betalingsBetingelse = "SP" Then
          RaiseEvent DårligBetalerFundet("Spærret")
        ElseIf _betalingsBetingelse = "FB" OrElse _betalingsBetingelse = "NK" Then
          RaiseEvent DårligBetalerFundet("Forud")
        Else
          RaiseEvent DårligBetalerFundet("")
        End If
        dr.Close()
        cm.Dispose()
        cn.Dispose()
      End If
      checkValid()
    End Set
  End Property

  Private Function makeNullEmpty(ByVal inValue As String) As String
    If inValue = Nothing Then
      Return ""
    Else
      Return inValue
    End If
  End Function

  Public Property BureauNO_() As String
    Get
      Return _NyeVærdier.BureauNo_
    End Get
    Set(ByVal value As String)
      _NyeVærdier.BureauNo_ = makeNullEmpty(value)
      If _NyeVærdier.BureauNo_ <> "" Then
        Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
        Dim cm As New SqlCommand()
        cm = cn.CreateCommand
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT dbo.NavisionContact.Name AS BureauNavn, dbo.NavisionContact.Address, dbo.NavisionContact.[Post Code] AS PostNr, dbo.NavisionContact.City AS PostBy, dbo.NavisionContact.[Phone No_] AS TlfNr, dbo.NavisionContact.[VAT Registration No_] AS CVR, dbo.NavisionContact.Infogodtgørelse, dbo.NavisionContact.Sikkerhedsgodtgørelse FROM dbo.NavisionContact WHERE (dbo.NavisionContact.No_ = '" & value & "')"
        Dim dr As SqlDataReader
        cn.Open()
        dr = cm.ExecuteReader(CommandBehavior.SingleRow)
        dr.Read()
        _bureauNavn = dr("BureauNavn")
        _bureauAdresse = dr("Address")
        _bureauPostNr = dr("PostNr")
        _bureauPostBy = dr("PostBy")
        _bureauTlf = dr("TlfNr")
        _bureauCVR = dr("CVR")
        _infoGodtgørelse = dr("Infogodtgørelse")
        _sikkerhedsGodtgørelse = dr("Sikkerhedsgodtgørelse")
        cm.Dispose()
        cn.Dispose()
      Else
        _infoGodtgørelse = False
        _sikkerhedsGodtgørelse = False
      End If
      checkValid()
    End Set
  End Property

  Public Property Format1() As Integer
    Get
      Return _NyeVærdier.Format1
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.Format1 = value
      checkValid()
    End Set
  End Property

  Public Property Format2() As Integer
    Get
      Return _NyeVærdier.Format2
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.Format2 = value
      checkValid()
    End Set
  End Property

  Public ReadOnly Property FormatHasChanged() As Boolean
    Get
      If _NyeVærdier.Format1 <> _OldVærdier.Format1 OrElse _NyeVærdier.Format2 <> _OldVærdier.Format2 Then
        Return True
      Else
        Return False
      End If
    End Get
  End Property

  Public Property AntalFarver() As Integer
    Get
      Return _NyeVærdier.AntalFarver
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.AntalFarver = value
      checkValid()
    End Set
  End Property

  Public ReadOnly Property AntalFarverHasChanged() As Boolean
    Get
      Return _NyeVærdier.AntalFarver <> _OldVærdier.AntalFarver
    End Get
  End Property

  Public Property DPKulørID() As Integer
    Get
      Return _NyeVærdier.DPKulørID
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.DPKulørID = value
      checkValid()
    End Set
  End Property

  Public ReadOnly Property DPKulørIDHasChanged() As Boolean
    Get
      Return _NyeVærdier.DPKulørID <> _OldVærdier.DPKulørID
    End Get
  End Property

  Public Property PlaceringID() As Integer
    Get
      Return _NyeVærdier.PlaceringID
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.PlaceringID = value
      checkChanges()
    End Set
  End Property

  Public ReadOnly Property PlaceringIDHasChanged() As Boolean
    Get
      Return _NyeVærdier.PlaceringID <> _OldVærdier.PlaceringID
    End Get
  End Property

  Public Property IndrykningsUge() As Integer
    Get
      Return _NyeVærdier.IndrykningsUge
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.IndrykningsUge = value
      If _OldVærdier.IndrykningsUge = 0 Then _OldVærdier.IndrykningsUge = _NyeVærdier.IndrykningsUge
      checkValid()
    End Set
  End Property

  Public ReadOnly Property IndrykningsUgeHasChanged() As Boolean
    Get
      Return _NyeVærdier.IndrykningsUge <> _OldVærdier.IndrykningsUge
    End Get
  End Property

  Public Property IndrykningsÅr() As Integer
    Get
      Return _NyeVærdier.IndrykningsÅr
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.IndrykningsÅr = value
      If _OldVærdier.IndrykningsÅr = 0 Then _OldVærdier.IndrykningsÅr = _NyeVærdier.IndrykningsÅr
      checkValid()
    End Set
  End Property

  Public ReadOnly Property IndrykningsÅrHasChanged() As Boolean
    Get
      Return _OldVærdier.IndrykningsÅr <> _NyeVærdier.IndrykningsÅr
    End Get
  End Property

  Public Property BemærkningTilAnnoncør() As String
    Get
      Return _NyeVærdier.BemærkningTilAnnoncør
    End Get
    Set(ByVal value As String)
      _NyeVærdier.BemærkningTilAnnoncør = makeNullEmpty(value)
      checkChanges()
    End Set
  End Property

  Public Property BemærkningTilUgeavis() As String
    Get
      Return _NyeVærdier.BemærkningTilUgeavis
    End Get
    Set(ByVal value As String)
      _NyeVærdier.BemærkningTilUgeavis = makeNullEmpty(value)
      checkChanges()
    End Set
  End Property

  Public Property Overskrift() As String
    Get
      Return _NyeVærdier.Overskrift
    End Get
    Set(ByVal value As String)
      _NyeVærdier.Overskrift = makeNullEmpty(value)
      checkChanges()
    End Set
  End Property

  Public ReadOnly Property OverskriftHasChanged() As Boolean
    Get
      Return _NyeVærdier.Overskrift <> _OldVærdier.Overskrift
    End Get
  End Property

  Public Property Beskrivelse() As String
    Get
      Return _NyeVærdier.Beskrivelse
    End Get
    Set(ByVal value As String)
      _NyeVærdier.Beskrivelse = makeNullEmpty(value)
      checkValid()
    End Set
  End Property

  Public Property Kontaktperson() As String
    Get
      Return _NyeVærdier.KontaktPerson
    End Get
    Set(ByVal value As String)
      _NyeVærdier.KontaktPerson = makeNullEmpty(value)
      checkValid()
    End Set
  End Property

  Public Property KontaktpersonTilhører() As Integer
    Get
      Return _NyeVærdier.KontaktpersonTilhører
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.KontaktpersonTilhører = value
      checkChanges()
    End Set
  End Property

  Public Property Fakturering() As Integer
    Get
      Return _NyeVærdier.Fakturering
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.Fakturering = value
      checkChanges()
    End Set
  End Property

  Public ReadOnly Property FaktureringHasChanged() As Boolean
    Get
      Return _NyeVærdier.Fakturering <> _OldVærdier.Fakturering
    End Get
  End Property

  Public Property RekvisitionsNr() As String
    Get
      Return _NyeVærdier.RekvisitionsNr
    End Get
    Set(ByVal value As String)
      _NyeVærdier.RekvisitionsNr = makeNullEmpty(value)
      checkChanges()
    End Set
  End Property

  Public Property BilagsBladeTil() As Integer
    Get
      Return _NyeVærdier.BilagsBladeTil
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.BilagsBladeTil = value
      checkChanges()
    End Set
  End Property

  Public ReadOnly Property BilagsBladeTilHasChanged() As Boolean
    Get
      Return _NyeVærdier.BilagsBladeTil <> _OldVærdier.BilagsBladeTil
    End Get
  End Property

  Public Property BilagsBladeTilNavn() As String
    Get
      Return _NyeVærdier.BilagsBladeTilNavn
    End Get
    Set(ByVal value As String)
      _NyeVærdier.BilagsBladeTilNavn = makeNullEmpty(value)
      checkChanges()
    End Set
  End Property

  Public Property BilagsBladeTilAdresse() As String
    Get
      Return _NyeVærdier.BilagsBladeTilAdresse
    End Get
    Set(ByVal value As String)
      _NyeVærdier.BilagsBladeTilAdresse = makeNullEmpty(value)
      checkChanges()
    End Set
  End Property

  Public Property BilagsBladeTilPostNr() As Integer
    Get
      Return _NyeVærdier.BilagsBladeTilPostNr
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.BilagsBladeTilPostNr = value
      checkChanges()
    End Set
  End Property

  Public Property BilagsBladeAtt() As String
    Get
      Return _NyeVærdier.BilagsBladeAtt
    End Get
    Set(ByVal value As String)
      _NyeVærdier.BilagsBladeAtt = makeNullEmpty(value)
      checkChanges()
    End Set
  End Property

  Public Property MaterialeFølgerFra() As Integer
    Get
      Return _NyeVærdier.MaterialeFølgerFra
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.MaterialeFølgerFra = value
      checkValid()
    End Set
  End Property

  Public ReadOnly Property MaterialeFølgerFraHasChanged() As Boolean
    Get
      Return _NyeVærdier.MaterialeFølgerFra <> _OldVærdier.MaterialeFølgerFra
    End Get
  End Property

  Public Property MaterialeFølgerFraLeverandør() As String
    Get
      Return _NyeVærdier.MaterialeFølgerFraLeverandør
    End Get
    Set(ByVal value As String)
      _NyeVærdier.MaterialeFølgerFraLeverandør = makeNullEmpty(value)
      checkValid()
    End Set
  End Property

  Public Property BrugMaterialeFraUge() As Integer
    Get
      Return _NyeVærdier.BrugMaterialeFraUge
    End Get
    Set(ByVal value As Integer)
      _NyeVærdier.BrugMaterialeFraUge = value
      checkValid()
    End Set
  End Property

  Public ReadOnly Property BrugMaterialeFraUgeHasChanged() As Boolean
    Get
      Return _NyeVærdier.BrugMaterialeFraUge <> _OldVærdier.BrugMaterialeFraUge
    End Get
  End Property

  Public Property TilladFarveSærRabat() As Boolean
    Get
      Return _NyeVærdier.TilladFarveSærRabat
    End Get
    Set(ByVal value As Boolean)
      _NyeVærdier.TilladFarveSærRabat = value
      checkChanges()
    End Set
  End Property

  Public Property TilladMmSærRabat() As Boolean
    Get
      Return _NyeVærdier.TilladMmSærRabat
    End Get
    Set(ByVal value As Boolean)
      _NyeVærdier.TilladMmSærRabat = value
      checkChanges()
    End Set
  End Property

  Public Property SammeMateriale() As Boolean
    Get
      Return _NyeVærdier.SammeMateriale
    End Get
    Set(ByVal value As Boolean)
      _NyeVærdier.SammeMateriale = value
      checkValid()
    End Set
  End Property

  Public Property KunForhandlerBundForskellig() As Boolean
    Get
      Return _NyeVærdier.KunForhandlerBundForskellig
    End Get
    Set(ByVal value As Boolean)
      _NyeVærdier.KunForhandlerBundForskellig = value
      checkValid()
    End Set
  End Property

  Public Property SammeBureauOrdreNr() As Boolean
    Get
      Return _NyeVærdier.SammeBureauOrdreNr
    End Get
    Set(ByVal value As Boolean)
      _NyeVærdier.SammeBureauOrdreNr = value
      checkChanges()
    End Set
  End Property

  Public Property FællesBureauOrdreNr() As String
    Get
      Return _NyeVærdier.FællesBureauOrdreNr
    End Get
    Set(ByVal value As String)
      _NyeVærdier.FællesBureauOrdreNr = makeNullEmpty(value)
      checkChanges()
    End Set
  End Property

  Public ReadOnly Property FællesBureauOrdreNrHasChanged() As Boolean
    Get
      Return _NyeVærdier.FællesBureauOrdreNr <> _OldVærdier.FællesBureauOrdreNr
    End Get
  End Property

  Public Property Version() As Integer
    Get
      Return _version
    End Get
    Set(ByVal value As Integer)
      _version = value
    End Set
  End Property

  'Public Property WebTillægOpkræves() As Boolean
  '  Get
  '    Return _NyeVærdier.WebTillægOpkræves
  '  End Get
  '  Set(ByVal value As Boolean)
  '    _NyeVærdier.WebTillægOpkræves = value
  '    checkValid()
  '  End Set
  'End Property

  Public Property MiljøTillægOpkræves As Boolean
    Get
      Return _NyeVærdier.MiljøTillægOpkræves
    End Get
    Set(value As Boolean)
      _NyeVærdier.MiljøTillægOpkræves = value
      checkValid()
    End Set
  End Property

  Public Property OpkrævJyskeMiljøTillæg As Boolean
    Get
      Return _NyeVærdier.OpkrævJyskeMiljøTillæg
    End Get
    Set(value As Boolean)
      _NyeVærdier.OpkrævJyskeMiljøTillæg = value
      checkValid()
    End Set
  End Property

  Public Property OpkrævFynskeMiljøTillæg As Boolean
    Get
      Return _NyeVærdier.OpkrævFynskeMiljøTillæg
    End Get
    Set(value As Boolean)
      _NyeVærdier.OpkrævFynskeMiljøTillæg = value
      checkValid()
    End Set
  End Property

  Public Property OpkrævNorthMiljøTillæg As Boolean
    Get
      Return _NyeVærdier.OpkrævNorthMiljøTillæg
    End Get
    Set(value As Boolean)
      _NyeVærdier.OpkrævNorthMiljøTillæg = value
      checkValid()
    End Set
  End Property

  Public Property OpkrævDSVPMiljøTillæg As Boolean
    Get
      Return _NyeVærdier.OpkrævDSVPMiljøTillæg
    End Get
    Set(value As Boolean)
      _NyeVærdier.OpkrævDSVPMiljøTillæg = value
      checkValid()
    End Set
  End Property

  Public Property OpkrævJyskeMedierASTillæg As Boolean
    Get
      Return _NyeVærdier.OpkrævJyskeMedierASTillæg
    End Get
    Set(value As Boolean)
      _NyeVærdier.OpkrævJyskeMedierASTillæg = value
      checkValid()
    End Set
  End Property

  Public Property Status() As StatusKoder
    Get
      Return _status
    End Get
    Set(ByVal value As StatusKoder)
      _status = value
    End Set
  End Property

  Public Property MedieplanNr() As Integer
    Get
      Return _mediePlanNr
    End Get
    Set(ByVal value As Integer)
      _mediePlanNr = value
    End Set
  End Property

  Public WriteOnly Property Modul() As String
    Set(ByVal value As String)
      _modul = value
    End Set
  End Property

  Public WriteOnly Property RettelserEfterAnnoncekontrol() As Boolean
    Set(ByVal value As Boolean)
      _rettelserEfterAnnoncekontrol = value
    End Set
  End Property

  Public WriteOnly Property BrugerCode() As String
    Set(ByVal value As String)
      If value.Length > 10 Then
        _brugerCode = UCase(value.Substring(0, 10))
      Else
        _brugerCode = UCase(value)
      End If
    End Set
  End Property

  Public WriteOnly Property SamletPris() As Double
    Set(ByVal value As Double)
      _samletPris = value
    End Set
  End Property

  Public ReadOnly Property HasChanged() As Boolean
    Get
      _hasChanges = False
      If _NyeVærdier <> _OldVærdier Then ' OrElse _rowsDeleted Then '
        _hasChanges = True
      End If
      Return _hasChanges
    End Get
  End Property

  Public ReadOnly Property IsValid() As Boolean
    Get
      Return _isValid
    End Get
  End Property

  Public Property OprindeligtMiljøTillæg() As Double
    Get
      Return _oprindeligtMiljøTillæg
    End Get
    Set(ByVal value As Double)
      _oprindeligtMiljøTillæg = value
    End Set
  End Property


  Public Function NotValidText(ByVal counter As Integer) As String
    Dim _notValidText As String = ""

    If Not _isValid Then
      counter = counter + 1

      If _modul = "Medieplan" AndAlso _NyeVærdier.AnnoncørNo_.Length < 1 AndAlso _NyeVærdier.BureauNo_.Length < 1 Then
        _notValidText = _notValidText & counter.ToString & ". Hverken en <b>Annoncør</b> eller et <b>Bureau</b> er valgt.<br/>"
        counter = counter + 1
      End If
      If _modul = "Booking" AndAlso _NyeVærdier.AnnoncørNo_.Length < 1 Then
        _notValidText = _notValidText & counter.ToString & ". Du skal vælge en <b>Annoncør</b>.<br/>"
        counter = counter + 1
      End If
      'If _modul = "Medieplan" AndAlso _NyeVærdier.Beskrivelse = "" Then
      '  _notValidText = _notValidText & counter.ToString & ". Der skal indtastes en beskrivelse."
      '  counter = counter + 1
      'End If
      If _NyeVærdier.Format1 <= 0 Then
        _notValidText = _notValidText & counter.ToString & ". <b>Kolonner</b> i <i>Format</i> skal være større end 0.<br/>"
        counter = counter + 1
      End If
      If _NyeVærdier.Format2 <= 0 Then
        _notValidText = _notValidText & counter.ToString & ". <b>Spaltehøjde</b> i <i>Format</i> skal være større end 0.<br/>"
        counter = counter + 1
      End If
      If (_NyeVærdier.AntalFarver = 1 AndAlso _NyeVærdier.DPKulørID = 0) Then
        _notValidText = _notValidText & counter.ToString & ". <i>1 farve</i> er valgt, men der mangler valg af <b>DP-Kulør</b>.<br/>"
        counter = counter + 1
      End If
      If (_modul = "Booking") Then
        If (_NyeVærdier.BrugMaterialeFraUge = 0 AndAlso _NyeVærdier.MaterialeFølgerFra < 1) Then
          _notValidText = _notValidText & counter.ToString & ". : Du skal angive hvilken <i>uge</i> <b>materiale følger fra</b>.<br/>"
          counter = counter + 1
        End If
        If (_NyeVærdier.BrugMaterialeFraUge = 0 AndAlso _NyeVærdier.MaterialeFølgerFra > 0 AndAlso _NyeVærdier.MaterialeFølgerFraLeverandør = "") Then
          If _NyeVærdier.MaterialeFølgerFra = 1 Then
            _notValidText = _notValidText & counter.ToString & ". <b>Materiale leverandør</b> til <i>DLU</i>, er ikke udfyldt.<br/>"
          Else
            _notValidText = _notValidText & counter.ToString & ". <b>Materiale leverandør</b> til <i>Ugeaviserne</i>, er ikke udfyldt.<br/>"
          End If
          counter = counter + 1
        End If
      End If
      If (_modul = "Booking" AndAlso _NyeVærdier.BureauNo_.Length > 0 AndAlso _NyeVærdier.SammeBureauOrdreNr AndAlso _NyeVærdier.FællesBureauOrdreNr.Length < 1) Then
        _notValidText = _notValidText & counter.ToString & ". <b>Fælles Bureauordrenr</b> er ikke udfyldt.<br/>"
        counter = counter + 1
      End If
    End If
    Return _notValidText
  End Function

  Public Sub checkValid()
    _isValid = True
    Select Case True
      Case (_modul = "Medieplan" AndAlso _NyeVærdier.AnnoncørNo_.Length < 1 AndAlso _NyeVærdier.BureauNo_.Length < 1)
        _isValid = False
      Case (_modul = "Booking" AndAlso _NyeVærdier.AnnoncørNo_.Length < 1)
        _isValid = False
      Case (_NyeVærdier.Format1 <= 0 OrElse _NyeVærdier.Format2 <= 0)
        _isValid = False
      Case (_NyeVærdier.AntalFarver = 1 AndAlso _NyeVærdier.DPKulørID = 0)
        _isValid = False
      Case (_modul = "Booking" AndAlso _NyeVærdier.BureauNo_.Length > 0 AndAlso _NyeVærdier.SammeBureauOrdreNr AndAlso _NyeVærdier.FællesBureauOrdreNr.Length < 1)
        _isValid = False
        'Case (_modul = "Medieplan" AndAlso _NyeVærdier.Beskrivelse = "")
        '  _isValid = False
      Case (_modul = "Booking" AndAlso _NyeVærdier.BrugMaterialeFraUge = 0 AndAlso _NyeVærdier.MaterialeFølgerFra < 1) OrElse _
           (_modul = "Booking" AndAlso _NyeVærdier.BrugMaterialeFraUge = 0 AndAlso _NyeVærdier.MaterialeFølgerFra > 0 AndAlso _NyeVærdier.MaterialeFølgerFraLeverandør = "")
        _isValid = False
    End Select
    RaiseEvent Validated(_isValid)
    checkChanges()
  End Sub

  Private Sub checkChanges()
    _hasChanges = False
    If _NyeVærdier <> _OldVærdier Then ' OrElse _rowsDeleted Then '
      _hasChanges = True
    End If
    RaiseEvent HasChanges(_hasChanges)
  End Sub

  Public Function SaveData() As Boolean
    Dim ta As New dstMedieplanTableAdapters.tblMedieplanTableAdapter

    If ta.Insert(_mediePlanNr, _version, _NyeVærdier.AnnoncørNo_, _NyeVærdier.BureauNo_, _NyeVærdier.Format1, _NyeVærdier.Format2, _NyeVærdier.AntalFarver, _NyeVærdier.DPKulørID, _NyeVærdier.PlaceringID, _NyeVærdier.IndrykningsUge, _NyeVærdier.IndrykningsÅr, _NyeVærdier.Overskrift, _NyeVærdier.Fakturering, _NyeVærdier.RekvisitionsNr, _NyeVærdier.BilagsBladeTil, _NyeVærdier.BilagsBladeAtt, _NyeVærdier.MaterialeFølgerFra, _NyeVærdier.BrugMaterialeFraUge, _samletPris, _brugerCode, _NyeVærdier.TilladFarveSærRabat, _NyeVærdier.SammeMateriale, _NyeVærdier.SammeBureauOrdreNr, _NyeVærdier.FællesBureauOrdreNr, _NyeVærdier.MaterialeFølgerFraLeverandør, _status, _NyeVærdier.Beskrivelse, _NyeVærdier.KontaktPerson, _NyeVærdier.KontaktpersonTilhører, _NyeVærdier.BemærkningTilAnnoncør, _NyeVærdier.BemærkningTilUgeavis, _NyeVærdier.BilagsBladeTilNavn, _NyeVærdier.BilagsBladeTilAdresse, _NyeVærdier.BilagsBladeTilPostNr, _rettelserEfterAnnoncekontrol, _sikkerhedsGodtgørelse, _infoGodtgørelse, _NyeVærdier.TilladMmSærRabat, _NyeVærdier.KunForhandlerBundForskellig, False, _NyeVærdier.MiljøTillægOpkræves, _NyeVærdier.OpkrævJyskeMiljøTillæg, _NyeVærdier.OpkrævFynskeMiljøTillæg, _NyeVærdier.OpkrævNorthMiljøTillæg, _NyeVærdier.OpkrævDSVPMiljøTillæg, _NyeVærdier.OpkrævJyskeMedierASTillæg) > 0 Then
      _isValid = True
      If _NyeVærdier.RekvisitionsNr <> "" Then
        Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
        Dim cm As SqlCommand = cn.CreateCommand()
        Try
          cm.CommandType = CommandType.Text
          cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBemærkning3 = 'Rekvisitions nr.: " & _NyeVærdier.RekvisitionsNr.Replace("'", "''") & "' WHERE (MedieplanNr = " & _mediePlanNr.ToString & ")"
          cn.Open()
          cm.ExecuteNonQuery()
        Catch
        Finally
          cn.Close()
          cn.Dispose()
        End Try
      End If
      Return True
    Else
      Return False
    End If
  End Function

  Public Sub SetOldValuesToNewValues()
    _OldVærdier.AnnoncørNo_ = _NyeVærdier.AnnoncørNo_
    _OldVærdier.BureauNo_ = _NyeVærdier.BureauNo_
    _OldVærdier.Format1 = _NyeVærdier.Format1
    _OldVærdier.Format2 = _NyeVærdier.Format2
    _OldVærdier.AntalFarver = _NyeVærdier.AntalFarver
    _OldVærdier.DPKulørID = _NyeVærdier.DPKulørID
    _OldVærdier.PlaceringID = _NyeVærdier.PlaceringID
    _OldVærdier.IndrykningsUge = _NyeVærdier.IndrykningsUge
    _OldVærdier.IndrykningsÅr = _NyeVærdier.IndrykningsÅr
    _OldVærdier.BemærkningTilAnnoncør = _NyeVærdier.BemærkningTilAnnoncør
    _OldVærdier.BemærkningTilUgeavis = _NyeVærdier.BemærkningTilUgeavis
    _OldVærdier.Overskrift = _NyeVærdier.Overskrift
    _OldVærdier.Beskrivelse = _NyeVærdier.Beskrivelse
    _OldVærdier.KontaktPerson = _NyeVærdier.KontaktPerson
    _OldVærdier.KontaktpersonTilhører = _NyeVærdier.KontaktpersonTilhører
    _OldVærdier.Fakturering = _NyeVærdier.Fakturering
    _OldVærdier.RekvisitionsNr = _NyeVærdier.RekvisitionsNr
    _OldVærdier.BilagsBladeTil = _NyeVærdier.BilagsBladeTil
    _OldVærdier.BilagsBladeAtt = _NyeVærdier.BilagsBladeAtt
    _OldVærdier.BilagsBladeTilNavn = _NyeVærdier.BilagsBladeTilNavn
    _OldVærdier.BilagsBladeTilAdresse = _NyeVærdier.BilagsBladeTilAdresse
    _OldVærdier.BilagsBladeTilPostNr = _NyeVærdier.BilagsBladeTilPostNr
    _OldVærdier.MaterialeFølgerFra = _NyeVærdier.MaterialeFølgerFra
    _OldVærdier.MaterialeFølgerFraLeverandør = _NyeVærdier.MaterialeFølgerFraLeverandør
    _OldVærdier.BrugMaterialeFraUge = _NyeVærdier.BrugMaterialeFraUge
    _OldVærdier.TilladFarveSærRabat = _NyeVærdier.TilladFarveSærRabat
    _OldVærdier.SammeMateriale = _NyeVærdier.SammeMateriale
    _OldVærdier.KunForhandlerBundForskellig = _NyeVærdier.KunForhandlerBundForskellig
    _OldVærdier.SammeBureauOrdreNr = _NyeVærdier.SammeBureauOrdreNr
    _OldVærdier.FællesBureauOrdreNr = _NyeVærdier.FællesBureauOrdreNr
    '   _OldVærdier.WebTillægOpkræves = _NyeVærdier.WebTillægOpkræves
    _OldVærdier.MiljøTillægOpkræves = _NyeVærdier.MiljøTillægOpkræves
    _OldVærdier.OpkrævJyskeMiljøTillæg = _NyeVærdier.OpkrævJyskeMiljøTillæg
    _OldVærdier.OpkrævFynskeMiljøTillæg = _NyeVærdier.OpkrævFynskeMiljøTillæg
    _OldVærdier.OpkrævNorthMiljøTillæg = _NyeVærdier.OpkrævNorthMiljøTillæg
    _OldVærdier.OpkrævDSVPMiljøTillæg = _NyeVærdier.OpkrævDSVPMiljøTillæg
    _OldVærdier.OpkrævJyskeMedierASTillæg = _NyeVærdier.OpkrævJyskeMedierASTillæg
    _hasChanges = False
  End Sub

  Public Function GetChangeTekst(ByVal forHover As Boolean) As String
    Dim tekst As New StringBuilder(1000)

    Dim newLine As String
    If forHover Then
      newLine = "<br/>"
    Else
      newLine = vbCrLf
    End If
    If _NyeVærdier.AnnoncørNo_ <> _OldVærdier.AnnoncørNo_ Then
      tekst.Append("Annoncør er ændret." & newLine)
    End If
    If _NyeVærdier.BureauNo_ <> _OldVærdier.BureauNo_ Then
      tekst.Append("Bureau er ændret." & newLine)
    End If
    If _NyeVærdier.Format1 <> _OldVærdier.Format1 OrElse _NyeVærdier.Format2 <> _OldVærdier.Format2 Then
      tekst.AppendFormat("Format er ændret fra {0}x{1} til {2}x{3}. " & newLine, _OldVærdier.Format1, _OldVærdier.Format2, _NyeVærdier.Format1, _NyeVærdier.Format2)
    End If
    If _NyeVærdier.AntalFarver <> _OldVærdier.AntalFarver Then
      tekst.AppendFormat("Antal farver er ændret fra {0} til {1}. " & newLine, _OldVærdier.AntalFarver, _NyeVærdier.AntalFarver)
    End If
    If _NyeVærdier.DPKulørID <> _OldVærdier.DPKulørID Then
      tekst.Append("DP-kulør er ændret. " & newLine)
    End If
    If _NyeVærdier.PlaceringID <> _OldVærdier.PlaceringID Then
      tekst.Append("Placeringen er ændret. " & newLine)
    End If
    If _NyeVærdier.IndrykningsUge <> _OldVærdier.IndrykningsUge Then
      tekst.AppendFormat("Indrykningsuge er ændret fra {0} til {1}. " & newLine, _OldVærdier.IndrykningsUge, _NyeVærdier.IndrykningsUge)
    End If
    If _NyeVærdier.BemærkningTilAnnoncør <> _OldVærdier.BemærkningTilAnnoncør OrElse _NyeVærdier.BemærkningTilUgeavis <> _OldVærdier.BemærkningTilUgeavis Then
      tekst.Append("Bemærkning er ændret." & newLine)
    End If
    If _NyeVærdier.Overskrift <> _OldVærdier.Overskrift Then
      tekst.AppendFormat("Overskrift er ændret fra {0} til {1}. " & newLine, _OldVærdier.Overskrift, _NyeVærdier.Overskrift)
    End If
    If _NyeVærdier.MaterialeFølgerFra <> _OldVærdier.MaterialeFølgerFra Then
      tekst.Append("Materiale følger fra er ændret. " & newLine)
    End If
    If _NyeVærdier.BrugMaterialeFraUge <> _OldVærdier.BrugMaterialeFraUge AndAlso _NyeVærdier.BrugMaterialeFraUge > 0 AndAlso _OldVærdier.BrugMaterialeFraUge > 0 Then
      tekst.AppendFormat("Brug materiale fra uge er ændret fra {0} til {1}. " & newLine, _OldVærdier.BrugMaterialeFraUge, _NyeVærdier.BrugMaterialeFraUge)
    End If
    If _NyeVærdier.SammeMateriale <> _OldVærdier.SammeMateriale Then
      If _OldVærdier.SammeMateriale Then
        tekst.Append("Materiale er ændret fra ens til forskelligt." & newLine)
      Else
        tekst.Append("Materiale er ændret fra forskellig til ens." & newLine)
      End If
    End If
    If Not _NyeVærdier.SammeMateriale Then
      If _NyeVærdier.KunForhandlerBundForskellig <> _OldVærdier.KunForhandlerBundForskellig Then
        If _OldVærdier.KunForhandlerBundForskellig Then
          tekst.Append("""Kun forhandlerbund forskellig"" er ændret til Forskelligt materiale." & newLine)
        Else
          tekst.Append("Forskelligt materiale er ændret til ""Kun forhandlerbund forskellig.""" & newLine)
        End If
      End If
    End If
    If _NyeVærdier.BilagsBladeTil <> _OldVærdier.BilagsBladeTil Then
      tekst.Append("Send bilagsblade til er ændret. " & newLine)
    End If
    If _NyeVærdier.Fakturering <> _OldVærdier.Fakturering Then
      tekst.Append("Fakturering er ændret. " & newLine)
    End If
    'If _NyeVærdier.IndrykningsÅr > 2010 Then
    '  If _NyeVærdier.WebTillægOpkræves <> _OldVærdier.WebTillægOpkræves Then
    '    If _OldVærdier.WebTillægOpkræves Then
    '      tekst.Append("Webtillæg er ændret til ikke at skulle opkræves." & newLine)
    '    Else
    '      tekst.Append("Webtillæg er ændret til at skulle opkræves." & newLine)
    '    End If
    '  End If
    'End If
    If _NyeVærdier.MiljøTillægOpkræves <> _OldVærdier.MiljøTillægOpkræves Then
      If _OldVærdier.MiljøTillægOpkræves Then
        tekst.Append("Miljøtillæg er ændret til ikke at skulle opkræves." & newLine)
      Else
        tekst.Append("Miljøtillæg er ændret til at skulle opkræves." & newLine)
      End If
    End If
    If _NyeVærdier.OpkrævJyskeMiljøTillæg <> _OldVærdier.OpkrævJyskeMiljøTillæg Then
      If _OldVærdier.OpkrævJyskeMiljøTillæg Then
        tekst.Append("Miljøtillæg for Midtjyske Medier er ændret til ikke at skulle opkræves." & newLine)
      Else
        tekst.Append("Miljøtillæg for Midtjyske Medier er ændret til at skulle opkræves." & newLine)
      End If
    End If
    If _NyeVærdier.OpkrævFynskeMiljøTillæg <> _OldVærdier.OpkrævFynskeMiljøTillæg Then
      If _OldVærdier.OpkrævFynskeMiljøTillæg Then
        tekst.Append("Miljøtillæg for Fynske Medier er ændret til ikke at skulle opkræves." & newLine)
      Else
        tekst.Append("Miljøtillæg for Fynske Medier er ændret til at skulle opkræves." & newLine)
      End If
    End If
    If _NyeVærdier.OpkrævNorthMiljøTillæg <> _OldVærdier.OpkrævNorthMiljøTillæg Then
      If _OldVærdier.OpkrævNorthMiljøTillæg Then
        tekst.Append("Miljøtillæg for North Media er ændret til ikke at skulle opkræves." & newLine)
      Else
        tekst.Append("Miljøtillæg for North Media er ændret til at skulle opkræves." & newLine)
      End If
    End If
    If _NyeVærdier.OpkrævDSVPMiljøTillæg <> _OldVærdier.OpkrævDSVPMiljøTillæg Then
      If _OldVærdier.OpkrævDSVPMiljøTillæg Then
        tekst.Append("Miljøtillæg for DSVP er ændret til ikke at skulle opkræves." & newLine)
      Else
        tekst.Append("Miljøtillæg for DSVP er ændret til at skulle opkræves." & newLine)
      End If
    End If
    If _NyeVærdier.OpkrævJyskeMedierASTillæg <> _OldVærdier.OpkrævJyskeMedierASTillæg Then
      If _OldVærdier.OpkrævJyskeMedierASTillæg Then
        tekst.Append("Miljøtillæg for Jyske Medier A/S er ændret til ikke at skulle opkræves." & newLine)
      Else
        tekst.Append("Miljøtillæg for Jyske Medier A/S er ændret til at skulle opkræves." & newLine)
      End If
    End If
    Return tekst.ToString
  End Function
End Class
