Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win
Imports System.Data.SqlClient
Imports System.Math

Partial Class dataSourceMedieplan
  Inherits UltraDataSource

  Private _next As Integer = 0
  Private _placering As Integer = 1
  Private _antalMm As Integer = 100
  Private _antalMm360 As Integer = 360
  Private _antalFarver As Integer = 0
  Private _MediePlanNr As Integer = 0
  Private _is365 As Boolean = False
  Private _Version As Integer = 0
  Private _hasChanges As Boolean = False
  Private _uge As Integer = 0
  Private _år As Integer = 0
  Private _antalBladeIGruppe() As Integer
  Private _sammeBureauOrdreNr As Boolean = False
  Private _fællesBureauOrdreNr As String = ""
  Private _modul As String
  Private _BureauValgt As Boolean = False
  Private _annoncørPostNr As Integer = 0
  Private _gblade() As BladData
  Private _IsLoading As Boolean = False
  Private _status As StatusKoder
  Private _farvePlacering As Integer
  Private _farvePrisListe As Integer
  Private _kolonner As Integer
  Private _brugtGruppeVersion As Integer
  Private _SammeMateriale As Boolean = True

  Private _anvendtMiljøTillæg As Double = 0
  Private _opkrævHelsingørMiljøTillæg As Boolean = True
  Private _opkrævJyskeMiljøTillæg As Boolean = True
  Private _opkrævFynskeMiljøTillæg As Boolean = True
  Private _opkrævNorthMiljøTillæg As Boolean = True
  Private _opkrævDSVPMiljøTillæg As Boolean = True
  Private _opkrævJyskeMedierASTillæg As Boolean = True
  Public Event HasChanges(ByVal changes As Boolean)
  Public Event BureauOrdreNrIndtastet()
  Public Event AnsvarIndtastet()
  Public Event MarkerMinPris(ByVal UgeavisID As Integer, ByVal ErUnderMin As Boolean)
  Public Event MåGiveMmRabatÆndret()

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New(ByVal container As System.ComponentModel.IContainer)
    MyClass.New()

    'Required for Windows.Forms Class Composition Designer support
    If (container IsNot Nothing) Then
      container.Add(Me)
    End If

  End Sub

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()

    'This call is required by the Component Designer.
    InitializeComponent()
    InitSchema()
  End Sub

  'Component overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Component Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Component Designer
  'It can be modified using the Component Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    components = New System.ComponentModel.Container()
  End Sub

#Region " Serialization Duplicate Control "

  ' Return False to stop serialization on the form's InitializeComponent
  Protected Shadows Function ShouldSerializeBand() As Boolean
    Return False
  End Function

  ' Stop serialization on the form's InitializeComponent to avoid duplicates
  <System.ComponentModel.DesignerSerializationVisibility( _
    System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
  Public Shadows ReadOnly Property Band() As Infragistics.Win.UltraWinDataSource.UltraDataBand
    Get
      Return MyBase.Band ' Wrap the Band with a NON-serializable version
    End Get
  End Property

#End Region

#Region " Properties "
  Private ReadOnly Property NextAutoNumber() As Integer
    Get
      _next -= 1
      Return _next
    End Get
  End Property

  Public WriteOnly Property Modul() As String
    Set(ByVal value As String)
      _modul = value
    End Set
  End Property

  Public Property Placering() As Integer
    Get
      Return _placering
    End Get
    Set(ByVal value As Integer)
      _placering = value
      BeregnAntalMm()
      getPriser()
      'ScanWeekendGruppe()
    End Set
  End Property

  Public Property Is365() As Boolean
    Get
      Return _is365
    End Get
    Set(ByVal value As Boolean)
      _is365 = value
    End Set
  End Property

  Public WriteOnly Property AntalMm360() As Integer
    Set(ByVal value As Integer)
      _antalMm360 = value
    End Set
  End Property

  Public Property AntalMm() As Integer
    Get
      Return _antalMm
    End Get
    Set(ByVal value As Integer)
      _antalMm = value
      If _antalMm > 0 Then
        BeregnAntalMm()
        getPriser()
      End If
    End Set
  End Property

  Private Sub BeregnAntalMm()
    For Each arow As UltraDataRow In MyBase.Rows
      If _is365 Then
        If arow("Is365") = True Then
          arow("Mm") = _antalMm
        Else
          arow("Mm") = _antalMm360
        End If
      Else
        arow("Mm") = _antalMm
      End If
      If arow("Ejerforhold") = "Helsingør Dagblad" OrElse arow("Ejerforhold") = "Midtjyske Medier" OrElse arow("Ejerforhold") = "Berlingske Lokalaviser" OrElse arow("Ejerforhold") = "Den Sydvestjyske Venstrepresse" OrElse arow("Ejerforhold") = "Fynske Medier" OrElse arow("Ejerforhold") = "North Media" OrElse arow("Ejerforhold") = "Jyske Medier A/S" Then

        If arow("Ejerforhold") = "Midtjyske Medier" OrElse arow("Ejerforhold") = "Berlingske Lokalaviser" Then
          If _placering = 11 OrElse _placering > 12 Then
            If Not (_is365 AndAlso _kolonner = 6) Then
              arow("Mm") = arow("Mm") + 4 * _kolonner
            End If
          End If
        End If
        If arow("Ejerforhold") = "Helsingør Dagblad" Then
          If _opkrævHelsingørMiljøTillæg Then
            arow("MiljøTillæg") = arow("Mm") * 0.06 '_anvendtMiljøTillæg
          Else
            arow("MiljøTillæg") = 0
          End If
        ElseIf arow("Ejerforhold") = "Midtjyske Medier" OrElse arow("Ejerforhold") = "Berlingske Lokalaviser" Then
          If _opkrævJyskeMiljøTillæg Then
            'If arow("UgeavisID") <> 81 AndAlso arow("UgeavisID") <> 275 AndAlso arow("UgeavisID") <> 191 Then
            arow("MiljøTillæg") = arow("Mm") * _anvendtMiljøTillæg
            'Else
            '  arow("MiljøTillæg") = 0
            'End If
          Else
            arow("MiljøTillæg") = 0
          End If
        ElseIf arow("Ejerforhold") = "Fynske Medier" Then
          If _opkrævFynskeMiljøTillæg Then
            arow("MiljøTillæg") = arow("Mm") * _anvendtMiljøTillæg
          Else
            arow("MiljøTillæg") = 0
          End If
        ElseIf arow("Ejerforhold") = "North Media" Then
          If _opkrævNorthMiljøTillæg Then
            arow("MiljøTillæg") = arow("Mm") * 0.06 '_anvendtMiljøTillæg
          Else
            arow("MiljøTillæg") = 0
          End If
        ElseIf arow("Ejerforhold") = "Den Sydvestjyske Venstrepresse" Then
          If _opkrævDSVPMiljøTillæg Then
            arow("MiljøTillæg") = arow("Mm") * _anvendtMiljøTillæg
          Else
            arow("MiljøTillæg") = 0
          End If
        ElseIf arow("Ejerforhold") = "Jyske Medier A/S" Then
          If _opkrævJyskeMedierASTillæg Then
            arow("MiljøTillæg") = arow("Mm") * _anvendtMiljøTillæg
          Else
            arow("MiljøTillæg") = 0
          End If
        End If
      Else
        arow("MiljøTillæg") = 0
        End If
    Next
    Beregn()
  End Sub

  Public WriteOnly Property Kolonner() As Integer
    Set(ByVal value As Integer)
      _kolonner = value
    End Set
  End Property

  Public Property AntalFarver() As Integer
    Get
      Return _antalFarver
    End Get
    Set(ByVal value As Integer)
      _antalFarver = value
      getPriser()
    End Set
  End Property

  Public Property MedieplanNr() As Integer
    Get
      Return _MediePlanNr
    End Get
    Set(ByVal value As Integer)
      _MediePlanNr = value
    End Set
  End Property

  Public Property Version() As Integer
    Get
      Return _Version
    End Get
    Set(ByVal value As Integer)
      _Version = value
    End Set
  End Property

  Public WriteOnly Property Uge()
    Set(ByVal value)
      _uge = value
      FindPrislisteID()
      getPriser()
    End Set
  End Property

  Public WriteOnly Property År()
    Set(ByVal value)
      _år = value
      FindPrislisteID()
      getPriser()
    End Set
  End Property

  Public WriteOnly Property SammeBureauOrdreNr() As Boolean
    Set(ByVal value As Boolean)
      _sammeBureauOrdreNr = value
    End Set
  End Property

  Public WriteOnly Property FællesBureauOrdreNr() As String
    Set(ByVal value As String)
      _fællesBureauOrdreNr = value
      If _sammeBureauOrdreNr Then
        For Each arow As UltraDataRow In MyBase.Rows
          If value Is Nothing Then
            arow("New BureauOrdreNr") = ""
          Else
            arow("New BureauOrdreNr") = value
          End If
        Next
      End If
    End Set
  End Property

  Public WriteOnly Property BureauValgt() As Boolean
    Set(ByVal value As Boolean)
      _BureauValgt = value
    End Set
  End Property

  Public WriteOnly Property AnnoncørPostNr() As Integer
    Set(ByVal value As Integer)
      _annoncørPostNr = value
      If value > 999 Then
        ScanWeekendGruppe()
      End If
    End Set
  End Property

  Public WriteOnly Property Status() As StatusKoder
    Set(ByVal value As StatusKoder)
      _status = value
    End Set
  End Property

  Public ReadOnly Property IsValid() As Boolean
    Get
      Dim _isValid As Boolean = True
      Select Case True
        Case MyBase.Rows.Count < 1
          _isValid = False
        Case _modul = "Booking" AndAlso _status = StatusKoder.stsFærdigTjekketOrdre
          For Each brow As UltraDataRow In MyBase.Rows
            If IsDBNull(brow("New Ansvar")) Then
              _isValid = False
              Exit For
            ElseIf brow("FejlTekst") <> "" AndAlso brow("New Ansvar") = "" Then
              _isValid = False
              Exit For
            End If
          Next
        Case Not _sammeBureauOrdreNr AndAlso _modul = "Booking" AndAlso _BureauValgt
          For Each arow As UltraDataRow In MyBase.Rows
            If arow("New BureauOrdreNr") = "" Then
              _isValid = False
              Exit For
            End If
          Next
      End Select
      Return _isValid
    End Get
  End Property

  Public ReadOnly Property HasChanged() As Boolean
    Get
      Return _hasChanges
    End Get
  End Property

  Public Property BrugtGruppeVersion() As Integer
    Get
      Return _brugtGruppeVersion
    End Get
    Set(ByVal value As Integer)
      _brugtGruppeVersion = value
    End Set
  End Property

  Public WriteOnly Property SammeMateriale() As Boolean
    Set(ByVal value As Boolean)
      _SammeMateriale = value
      ScanWeekendGruppe()
      '  FindHvilkenAvisWebtillægSkalFaktureresPå()
    End Set
  End Property

  Public WriteOnly Property AnvendtMiljøTillæg As Double
    Set(value As Double)
      _anvendtMiljøTillæg = value
      BeregnAntalMm()
    End Set
  End Property

  Public WriteOnly Property OpkrævJyskeMiljøTillæg As Boolean
    Set(value As Boolean)
      _opkrævJyskeMiljøTillæg = value
      BeregnAntalMm()
    End Set
  End Property

  Public WriteOnly Property OpkrævFynskeMiljøTillæg As Boolean
    Set(value As Boolean)
      _opkrævFynskeMiljøTillæg = value
      BeregnAntalMm()
    End Set
  End Property

  Public WriteOnly Property OpkrævNorthMiljøTillæg As Boolean
    Set(value As Boolean)
      _opkrævNorthMiljøTillæg = value
      BeregnAntalMm()
    End Set
  End Property

  Public WriteOnly Property OpkrævDSVPMiljøTillæg As Boolean
    Set(value As Boolean)
      _opkrævDSVPMiljøTillæg = value
      BeregnAntalMm()
    End Set
  End Property

  Public WriteOnly Property OpkrævJyskeMedierASTillæg As Boolean
    Set(value As Boolean)
      _opkrævJyskeMedierASTillæg = value
      BeregnAntalMm()
    End Set
  End Property

  Public WriteOnly Property OpkrævHelsingørTillæg As Boolean
    Set(value As Boolean)
      _opkrævHelsingørMiljøTillæg = value
      BeregnAntalMm()
    End Set
  End Property
#End Region

  Private Sub FindPrislisteID()
    Dim prisListeID As Integer

    For Each arow As UltraDataRow In MyBase.Rows
      prisListeID = FindPrisListeIDForBlad(arow("UgeavisID"))
      If prisListeID <> arow("PrisListeID") Then
        arow("PrisListeID") = prisListeID
      End If
    Next
  End Sub

  Private Function FindPrisListeIDForBlad(ByVal UgeavisID As Integer) As Integer
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim prisListeID As Integer

    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT PrislisteID FROM tblPrislisterPrBladPrUge WHERE (BladID = " & UgeavisID & ") AND (Uge = " & _uge & ") AND (År = " & _år & ")"
    cn.Open()
    prisListeID = cm.ExecuteScalar
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    Return prisListeID
  End Function

  Private Sub getPriser()
    Dim pris As Double

    For Each arow As UltraDataRow In MyBase.Rows
      'If Not arow("PrisLåst") Then
      pris = getPris("mmPris", arow("UgeavisID"), arow("PrisListeID"))
      If pris > 20 Then
        pris = pris / arow("Mm")
        arow("MåGiveMmRabat") = False
        '   arow("New MmRabat") = 0
      Else
        arow("MåGiveMmRabat") = True
      End If
      arow("NormalMmPris") = pris
      If _antalFarver = 0 Then
        arow("New FarveRabat") = 0
        arow("FarveTillæg") = 0
      ElseIf _antalFarver = 1 Then
        arow("FarveTillæg") = getPris("FarvePris", arow("UgeavisID"), arow("PrisListeID"))
        If _farvePlacering > 0 AndAlso _farvePrisListe > 0 Then
          If IsDBNull(arow("FarveMin")) OrElse arow("FarveMin") >= 0 Then
            arow("FarveMin") = getPrisFromSQL("FarveMin", arow("UgeavisID"), _farvePlacering, _farvePrisListe)
            arow("FarveMax") = getPrisFromSQL("FarveMax", arow("UgeavisID"), _farvePlacering, _farvePrisListe)
            If arow("FarveMin") <= 0 Then arow("FarveMin") = Nothing
            If arow("FarveMax") <= 0 Then arow("FarveMax") = Nothing
          End If
        End If
      Else
        arow("FarveTillæg") = getPris("Farve4Pris", arow("UgeavisID"), arow("PrisListeID"))
        If _farvePlacering > 0 AndAlso _farvePrisListe > 0 Then
          If IsDBNull(arow("FarveMin")) OrElse arow("FarveMin") >= 0 Then
            arow("FarveMin") = getPrisFromSQL("Farve4Min", arow("UgeavisID"), _farvePlacering, _farvePrisListe)
            arow("FarveMax") = getPrisFromSQL("Farve4Max", arow("UgeavisID"), _farvePlacering, _farvePrisListe)
            If arow("FarveMin") <= 0 Then arow("FarveMin") = Nothing
            If arow("FarveMax") <= 0 Then arow("FarveMax") = Nothing
          End If
        End If
      End If
      arow("New MmPris") = arow("NormalMmPris")
      'End If
    Next
    ScanGrupper()
  End Sub

  Friend Sub Beregn()
    MyBase.SuspendBindingNotifications()
    For Each arow As UltraDataRow In MyBase.Rows
      arow("New MmTotal") = (arow("New MmPris") * (1 - (arow("New MmRabat") / 100))) * arow("Mm") ' _antalMm
      If _antalFarver > 0 Then
        If arow("FarveTillæg") < 20 Then
          arow("New FarvePris") = arow("FarveTillæg") * arow("Mm")
          If Not IsDBNull(arow("FarveMin")) Then
            If arow("FarveMin") > 0 Then
              If _MediePlanNr > 75000 AndAlso _MediePlanNr < 76745 Then
                If arow("New FarvePris") * (1 - (arow("New FarveRabat") / 100)) < arow("FarveMin") Then
                  arow("New FarvePris") = arow("FarveMin")
                  arow("New FarveRabat") = 0
                End If
              Else
                If arow("New FarvePris") < arow("FarveMin") Then
                  arow("New FarvePris") = arow("FarveMin")
                End If
              End If
            End If
          End If
          If Not IsDBNull(arow("FarveMax")) Then
            If arow("FarveMax") > 0 Then
              If arow("New FarvePris") > arow("FarveMax") Then arow("New FarvePris") = arow("FarveMax")
            End If
          End If
        Else
          arow("New FarvePris") = arow("FarveTillæg")
        End If
        arow("New FarveTotal") = (arow("New FarvePris") * (1 - (arow("New FarveRabat") / 100)))
      Else
        arow("New FarvePris") = 0
        arow("New FarveTotal") = 0
      End If
      arow("New Total") = arow("New MmTotal") + arow("New FarveTotal")
      If arow("New Total") = 0 Then arow("MiljøTillæg") = 0
      arow("TotalInclTillæg") = arow("New Total") + arow("MiljøTillæg")
      arow("KontaktprisOplag") = (arow("TotalInclTillæg") / arow("Oplag")) * 1000
      arow("KontaktprisLæsertal") = (arow("TotalInclTillæg") / arow("Læsertal")) * 1000
    Next
    MyBase.ResumeBindingNotifications()
    RaiseEvent MåGiveMmRabatÆndret()
    checkChanges()
  End Sub

  Private Function getPris(ByVal PrisFelt As String, ByVal UgeavisID As Integer, ByVal PrisListeID As Integer) As Double
    Dim pris As Double
    _farvePlacering = 0
    _farvePrisListe = 0
    pris = getPrisFromSQL(PrisFelt, UgeavisID, _placering, PrisListeID)
    If pris = -1 Then
      _farvePlacering = _placering
      _farvePrisListe = PrisListeID
      Return 0
    End If
    If pris > 0 Then
      _farvePlacering = _placering
      _farvePrisListe = PrisListeID
      Return pris
    End If
    If _placering > 11 Then
      pris = getPrisFromSQL(PrisFelt, UgeavisID, 11, PrisListeID)
      If pris = -1 Then
        _farvePlacering = 11
        _farvePrisListe = PrisListeID
        Return 0
      End If
      If pris > 0 Then
        _farvePlacering = 11
        _farvePrisListe = PrisListeID
        Return pris
      End If
    End If
    pris = getPrisFromSQL(PrisFelt, UgeavisID, 1, PrisListeID)
    If pris = -1 Then
      _farvePlacering = 1
      _farvePrisListe = PrisListeID
      Return 0
    End If
    If pris > 0 Then
      _farvePlacering = 1
      _farvePrisListe = PrisListeID
      Return pris
    End If
    'If PrisListeID > 1 Then
    '  If _placering > 11 Then
    '    pris = getPrisFromSQL(PrisFelt, UgeavisID, 11, 1)
    '    If pris > 0 Then
    '      _farvePlacering = 11
    '      _farvePrisListe = 1
    '      Return pris
    '    End If
    '  End If
    '  pris = getPrisFromSQL(PrisFelt, UgeavisID, 1, 1)
    '  If pris > 0 Then
    '    _farvePlacering = 1
    '    _farvePrisListe = 1
    '  End If
    'Else
    '  Return 0
    'End If
    'If pris > 0 Then Return pris
    Return 0
  End Function

  Private Function getPrisFromSQL(ByVal PrisFelt As String, ByVal UgeavisID As Integer, ByVal PlaceringID As Integer, ByVal PrisListeID As Integer) As Double
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim pris As Double = 0

    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT " & PrisFelt & " FROM tblPriser WHERE (BladID = " & UgeavisID & ") AND (PlaceringID = " & PlaceringID & ") AND (År = " & _år & ") AND (PrislisteID = " & PrisListeID & ") AND (FormatFra <= " & _antalMm & ") AND (FormatTil >= " & _antalMm & ")"
    cn.Open()
    If IsDBNull(cm.ExecuteScalar) Then
      pris = 0
    Else
      pris = cm.ExecuteScalar()
    End If
    If pris = 0 Then
      cm.CommandText = "SELECT " & PrisFelt & " FROM tblPriser WHERE (BladID = " & UgeavisID & ") AND (PlaceringID = " & PlaceringID & ") AND (År = " & _år & ") AND (PrislisteID = " & PrisListeID & ") AND (FormatFra <2) AND (FormatTil > 1)"
      If IsDBNull(cm.ExecuteScalar) Then
        pris = 0
      Else
        pris = cm.ExecuteScalar()
      End If
    End If
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    Return pris
  End Function

  Private Sub InitSchema()
    'So the columns show on the subclassed component
    'and we work with a strongly typed structure
    MyBase.Band.Key = "OrdreLinjer"
    With MyBase.Band.Columns
      .Add("RowID", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
      .Add("UgeavisID", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
      .Add("GeoKodeNavn", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("GeoKodeSortKey", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
      .Add("HovedGruppeNavn", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("HovedGruppeSortKey", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
      .Add("RabatGruppe", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("Mm", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
      .Add("NormalMmPris", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("New MmPris", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("Old MmPris", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("New MmRabat", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("Old MmRabat", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("New MmTotal", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("Old MmTotal", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("FarveTillæg", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("New FarvePris", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("Old FarvePris", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("New FarveRabat", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("Old FarveRabat", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("New FarveTotal", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("Old FarveTotal", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("New Total", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("Old Total", GetType(Double)).AllowDBNull = DefaultableBoolean.False
      .Add("MåGiveFarveRabat", GetType(Boolean)).AllowDBNull = DefaultableBoolean.False
      .Add("MåGiveMmRabat", GetType(Boolean)).AllowDBNull = DefaultableBoolean.False
      .Add("New Bemærkning", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("Old Bemærkning", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("New BureauOrdreNr", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("Old BureauOrdreNr", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("RowState", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("FejlTekst", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("New Ansvar", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("Old Ansvar", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("ManueltÆndret", GetType(Boolean)).AllowDBNull = DefaultableBoolean.True
      .Add("SendeGruppe", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("FarveMin", GetType(Double)).AllowDBNull = DefaultableBoolean.True
      .Add("FarveMax", GetType(Double)).AllowDBNull = DefaultableBoolean.True
      .Add("MedIGrupper", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("Email", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("PrisforespørgselEmails", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("MaterialeNr", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("MedienetKode", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("PrislisteID", GetType(Integer)).AllowDBNull = DefaultableBoolean.True
      .Add("Is365", GetType(Boolean)).AllowDBNull = DefaultableBoolean.False
      .Add("Ejerforhold", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("FakturaGruppe", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("Change Reason", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("Faktureringsbilag", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("UdgivelsesDag", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
      .Add("ErWeekendGruppe", GetType(Boolean)).AllowDBNull = DefaultableBoolean.False
      .Add("WebtillægFaktureresHer", GetType(Boolean)).AllowDBNull = DefaultableBoolean.False
      .Add("BemærkningFraPrisforespørgsel", GetType(String)).AllowDBNull = DefaultableBoolean.True
      .Add("MiljøTillæg", GetType(Double)).AllowDBNull = DefaultableBoolean.True
      .Add("TotalInclTillæg", GetType(Double)).AllowDBNull = DefaultableBoolean.True
      .Add("MaterialeDeadline", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("Oplag", GetType(Double)).AllowDBNull = DefaultableBoolean.True
      .Add("Læsertal", GetType(Double)).AllowDBNull = DefaultableBoolean.True
      .Add("KontaktprisOplag", GetType(Double)).AllowDBNull = DefaultableBoolean.True
      .Add("KontaktprisLæsertal", GetType(Double)).AllowDBNull = DefaultableBoolean.True
      .Add("PrisLåst", GetType(Boolean)).AllowDBNull = DefaultableBoolean.False
    End With

  End Sub

  Public Sub ResetData(ByVal låsRabatter As Boolean, ByVal NulstilBureauOrdreNr As Boolean)
    Dim cn2 As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm2 As SqlCommand = cn2.CreateCommand
    cm2.CommandType = CommandType.Text
    cn2.Open()
    MyBase.SuspendBindingNotifications()
    ReDim _gblade(0)
    For Each arow As UltraDataRow In MyBase.Rows
      If NulstilBureauOrdreNr Then
        arow("New BureauOrdreNr") = ""
        arow("Old BureauOrdreNr") = ""
      End If
      arow("ManueltÆndret") = låsRabatter
      arow("RowState") = "Added"
      arow("Old MmPris") = 0
      FindGrupperForAvis(arow("UgeavisID"))
      cm2.CommandText = "SELECT MaterialedeadlineTekst FROM tblBladStamdata WHERE (BladID = " & arow("UgeavisID") & ")"
      If IsDBNull(cm2.ExecuteScalar) Then
        arow("MaterialeDeadline") = "Mangler"
      Else
        arow("MaterialeDeadline") = cm2.ExecuteScalar
      End If
    Next
    MyBase.ResumeBindingNotifications()
    cn2.Close()
    cm2.Dispose()
    cn2.Dispose()
    BeregnAntalMm()
    ScanGrupper()
  End Sub

  Public Function LoadData() As Boolean
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim RowID As Integer
    Dim UgeavisID As Integer
    Dim Mm As Integer
    Dim NormalMmPris As Double
    Dim NewAnvendtPris As Double
    Dim OldAnvendtPris As Double
    Dim NewMmRabat As Double
    Dim OldMmRabat As Double
    Dim NewMmTotal As Double
    Dim OldMmTotal As Double
    Dim FarveTillæg As Double
    Dim NewFarvePris As Double
    Dim OldFarvePris As Double
    Dim NewFarveRabat As Double
    Dim OldFarveRabat As Double
    Dim NewFarveTotal As Double
    Dim OldFarveTotal As Double
    Dim NewTotal As Double
    Dim OldTotal As Double
    Dim MåGiveFarveRabat As Boolean
    Dim MåGiveMmRabat As Boolean = True
    Dim NewBemærkning As String
    Dim OldBemærkning As String
    Dim NewBureauOrdreNr As String
    Dim OldBureauOrdreNr As String
    Dim GeoKodeNavn As String
    Dim GeoKodeSortKey As Integer
    Dim HovedGruppeNavn As String
    Dim HovedGruppeSortKey As Integer
    Dim RabatGruppe As String
    Dim RowState As String
    Dim fejlTekst As String
    Dim NewAnsvar As String
    Dim OldAnsvar As String
    Dim ManueltÆndret As Boolean
    Dim eMail As String
    Dim PrisforespørgselEmails As String
    Dim MedieNetKode As String
    Dim MaterialeNr As String
    Dim Formatet As String
    Dim prislisteID As Integer
    Dim is365 As Boolean
    Dim ejerforhold As String
    Dim farveMin As Double
    Dim farveMax As Double
    Dim SendeGruppe As String
    Dim MedIGrupper As String
    Dim FakturaGruppe As String
    Dim UdgivelsesDag As Integer
    Dim ErWeekendGruppe As Boolean
    Dim WebtillægFaktureresHer As Boolean
    Dim BemærkningFraPrisforespørgsel As String
    Dim MiljøTillæg As Double
    Dim TotalInclTillæg As Double
    Dim MaterialeDeadline As String
    Dim Oplag As Double
    Dim Læsertal As Double
    Dim KontaktprisOplag As Double
    Dim KontaktprisLæsertal As Double
    Dim PrisLåst As Boolean

    Dim dummy As Double
    cm.CommandText = "SELECT tblMedieplanLinjer.UgeavisID, tblGeoKode.GeoKodeNavn, tblGeoKode.GeoKodeSortKey, tblHovedGruppe.HovedGruppeNavn, tblHovedGruppe.HovedGruppeSortKey, tblMedieplanLinjer.Mm, tblMedieplanLinjer.NormalMmPris, tblMedieplanLinjer.MmPris, tblMedieplanLinjer.MmRabat, tblMedieplanLinjer.MmTotal, tblMedieplanLinjer.FarveTillæg, tblMedieplanLinjer.FarvePris, tblMedieplanLinjer.FarveRabat, tblMedieplanLinjer.FarveMin, tblMedieplanLinjer.FarveMax, tblMedieplanLinjer.FarveTotal, tblMedieplanLinjer.Total, tblBladStamdata.MåGiveFarveRabat, tblMedieplanLinjer.MåGiveMmRabat, tblMedieplanLinjer.ManueltÆndret, tblMedieplanLinjer.SendeGruppe, tblMedieplanLinjer.RabatGruppe, tblMedieplanLinjer.MedIGrupper, tblMedieplanLinjer.BureauOrdreNr, tblMedieplanLinjer.Bemærkning, tblBladStamdata.OrdreEmail, tblBladStamdata.PrisforespørgselEmails, tblBladStamdata.MedieNetKode, tblMedieplanLinjer.MaterialeNr, tblMedieplanLinjer.ErWeekendGruppe, tblBladStamdata.Format, tblBladStamdata.Ejerforhold, tblBladStamdata.MaterialedeadlineTekst, tblBladStamdata.Oplag, tblBladStamdata.Totalområde, tblFejlTekst.FejlTekst, tblAnnoncekontrol.Ansvar, tblGrupper.GruppeNavn AS FakturaGruppe, tblBladStamdata.UgedagID AS UdgivelsesDag, tblMedieplanLinjer.WebtillægFaktureresHer, tblWEBForespørgselLinjer.BladBemærkning, tblMedieplanLinjer.MiljøTillæg, tblMedieplanLinjer.TotalInclTillæg, tblMedieplanLinjer.PrisLåst FROM tblWEBForespørgsel INNER JOIN tblWEBForespørgselLinjer ON tblWEBForespørgsel.ForespørgselID = tblWEBForespørgselLinjer.ForespørgselID RIGHT OUTER JOIN tblMedieplanLinjer INNER JOIN tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID INNER JOIN tblGeoKode ON tblBladStamdata.GeoKodeID = tblGeoKode.GeoKodeID INNER JOIN tblHovedGruppe ON tblBladStamdata.HovedgruppeID = tblHovedGruppe.HovedGruppeID ON tblWEBForespørgselLinjer.BladID = tblMedieplanLinjer.UgeavisID AND tblWEBForespørgsel.MedieplanNr = tblMedieplanLinjer.MedieplanNr LEFT OUTER JOIN tblGrupper ON tblBladStamdata.FakturaGruppeID = tblGrupper.GruppeID LEFT OUTER JOIN tblFejlTekst INNER JOIN tblAnnoncekontrol ON tblFejlTekst.Fejlkode = tblAnnoncekontrol.Fejlkode ON tblMedieplanLinjer.MedieplanNr = tblAnnoncekontrol.MedieplanNr AND tblMedieplanLinjer.UgeavisID = tblAnnoncekontrol.UgeavisID WHERE (tblMedieplanLinjer.MedieplanNr = " & _MediePlanNr & ") AND (tblMedieplanLinjer.Version = " & _Version & ")  AND (tblGrupper.Version = 1)"
    cm.CommandType = CommandType.Text
    MyBase.SuspendBindingNotifications()
    Try
      _IsLoading = True
      MyBase.Rows.Clear()
      cn.Open()
      Dim dr As SqlDataReader = cm.ExecuteReader(CommandBehavior.Default)
      Dim rowCount As Integer = 0
      While dr.Read
        rowCount += 1
        RowID = rowCount
        UgeavisID = dr("UgeavisID")
        Mm = dr("Mm")
        NormalMmPris = dr("NormalMmPris")
        NewAnvendtPris = dr("MmPris")
        OldAnvendtPris = dr("MmPris")
        NewMmRabat = dr("MmRabat")
        OldMmRabat = dr("MmRabat")
        NewMmTotal = dr("MmTotal")
        OldMmTotal = dr("MmTotal")
        FarveTillæg = dr("FarveTillæg")
        NewFarvePris = dr("FarvePris")
        OldFarvePris = dr("FarvePris")
        NewFarveRabat = dr("FarveRabat")
        OldFarveRabat = dr("FarveRabat")
        If IsDBNull(dr("FarveMin")) Then
          farveMin = -1
        Else
          farveMin = dr("FarveMin")
        End If
        If IsDBNull(dr("FarveMax")) Then
          farveMax = Nothing
        Else
          farveMax = dr("FarveMax")
        End If
        NewFarveTotal = dr("FarveTotal")
        OldFarveTotal = dr("FarveTotal")
        NewTotal = dr("Total")
        OldTotal = dr("Total")
        MåGiveFarveRabat = dr("MåGiveFarveRabat")
        ManueltÆndret = dr("ManueltÆndret")
        SendeGruppe = dr("SendeGruppe")
        MedIGrupper = dr("MedIGrupper")
        NewBemærkning = dr("Bemærkning")
        OldBemærkning = dr("Bemærkning")
        NewBureauOrdreNr = dr("BureauOrdreNr")
        OldBureauOrdreNr = dr("BureauOrdreNr")
        GeoKodeNavn = dr("GeoKodeNavn")
        GeoKodeSortKey = dr("GeoKodeSortKey")
        HovedGruppeNavn = dr("HovedGruppeNavn")
        HovedGruppeSortKey = dr("HovedGruppeSortKey")
        If IsDBNull(dr("RabatGruppe")) Then
          RabatGruppe = ""
        Else
          RabatGruppe = dr("RabatGruppe")
        End If
        If IsDBNull(dr("FejlTekst")) Then
          fejlTekst = ""
        Else
          fejlTekst = dr("FejlTekst")
          If fejlTekst = "Ingen valgt" Then fejlTekst = ""
        End If
        If IsDBNull(dr("Ansvar")) Then
          NewAnsvar = ""
        Else
          NewAnsvar = dr("Ansvar")
        End If
        OldAnsvar = NewAnsvar
        RowState = "UnChanged"
        eMail = dr("OrdreEmail")
        If IsDBNull(dr("PrisforespørgselEmails")) Then
          PrisforespørgselEmails = ""
        Else
          PrisforespørgselEmails = dr("PrisforespørgselEmails")
        End If
        If IsDBNull(dr("MedieNetKode")) Then
          MedieNetKode = ""
        Else
          MedieNetKode = dr("MedieNetKode")
        End If
        If IsDBNull(dr("MaterialeNr")) Then
          MaterialeNr = ""
        Else
          MaterialeNr = dr("MaterialeNr")
        End If
        If IsDBNull(dr("Format")) Then
          Formatet = ""
        Else
          Formatet = dr("Format")
        End If
        prislisteID = FindPrisListeIDForBlad(UgeavisID)
        If Formatet.Contains("365") Then
          is365 = True
        Else
          is365 = False
        End If
        If IsDBNull(dr("Ejerforhold")) Then
          ejerforhold = ""
        Else
          ejerforhold = dr("Ejerforhold")
        End If
        If IsDBNull(dr("FakturaGruppe")) Then
          FakturaGruppe = ""
        Else
          FakturaGruppe = dr("FakturaGruppe")
          If FakturaGruppe = "Ikke i Gruppe" Then FakturaGruppe = ""
        End If
        If NewFarveRabat < 100 AndAlso farveMin = 0 Then
          If _antalFarver = 1 Then
            dummy = getPris("FarvePris", UgeavisID, prislisteID)
            farveMin = getPrisFromSQL("FarveMin", UgeavisID, _farvePlacering, _farvePrisListe)
            farveMax = getPrisFromSQL("FarveMax", UgeavisID, _farvePlacering, _farvePrisListe)
            If farveMin <= 0 Then farveMin = Nothing
            If farveMax <= 0 Then farveMax = Nothing
          ElseIf _antalFarver = 4 Then
            dummy = getPris("Farve4Pris", UgeavisID, prislisteID)
            farveMin = getPrisFromSQL("Farve4Min", UgeavisID, _farvePlacering, _farvePrisListe)
            farveMax = getPrisFromSQL("Farve4Max", UgeavisID, _farvePlacering, _farvePrisListe)
            If farveMin <= 0 Then farveMin = Nothing
            If farveMax <= 0 Then farveMax = Nothing
          End If
        End If
        If IsDBNull(dr("MåGiveMmRabat")) Then
          dummy = getPris("mmPris", UgeavisID, prislisteID)
          If dummy > 20 Then
            MåGiveMmRabat = False
          Else
            MåGiveMmRabat = True
          End If
        Else
          MåGiveMmRabat = dr("MåGiveMmRabat")
        End If
        ErWeekendGruppe = dr("ErWeekendGruppe")
        UdgivelsesDag = dr("UdgivelsesDag")
        If UdgivelsesDag > 7 Then UdgivelsesDag = UdgivelsesDag - 7
        WebtillægFaktureresHer = dr("WebtillægFaktureresHer")
        If IsDBNull(dr("BladBemærkning")) Then
          BemærkningFraPrisforespørgsel = ""
        Else
          BemærkningFraPrisforespørgsel = dr("BladBemærkning")
        End If
        If IsDBNull(dr("MiljøTillæg")) Then
          MiljøTillæg = 0
        Else
          MiljøTillæg = dr("MiljøTillæg")
        End If
        If IsDBNull(dr("TotalInclTillæg")) Then
          TotalInclTillæg = 0
        Else
          TotalInclTillæg = dr("TotalInclTillæg")
        End If
        If IsDBNull(dr("MaterialedeadlineTekst")) Then
          MaterialeDeadline = "Mangler"
        Else
          MaterialeDeadline = dr("MaterialedeadlineTekst")
        End If
        Oplag = dr("Oplag")
        Læsertal = dr("Totalområde")
        KontaktprisOplag = (TotalInclTillæg / Oplag) * 1000
        KontaktprisLæsertal = (TotalInclTillæg / Læsertal) * 1000
        PrisLåst = dr("PrisLåst")
        MyBase.Rows.Add(New Object() {RowID, UgeavisID, GeoKodeNavn, GeoKodeSortKey, HovedGruppeNavn, HovedGruppeSortKey, RabatGruppe, Mm, NormalMmPris, NewAnvendtPris, OldAnvendtPris, NewMmRabat, OldMmRabat, NewMmTotal, OldMmTotal, FarveTillæg, NewFarvePris, OldFarvePris, NewFarveRabat, OldFarveRabat, NewFarveTotal, OldFarveTotal, NewTotal, OldTotal, MåGiveFarveRabat, MåGiveMmRabat, NewBemærkning, OldBemærkning, NewBureauOrdreNr, OldBureauOrdreNr, RowState, fejlTekst, NewAnsvar, OldAnsvar, ManueltÆndret, SendeGruppe, farveMin, farveMax, MedIGrupper, eMail, PrisforespørgselEmails, MaterialeNr, MedieNetKode, prislisteID, is365, ejerforhold, FakturaGruppe, "", "Fak. bilag", UdgivelsesDag, ErWeekendGruppe, WebtillægFaktureresHer, BemærkningFraPrisforespørgsel, MiljøTillæg, TotalInclTillæg, MaterialeDeadline, Oplag, Læsertal, KontaktprisOplag, KontaktprisLæsertal, PrisLåst})
        FindGrupperForAvis(UgeavisID)
      End While
      dr.Close()
      MyBase.Rows.SetCount(rowCount)
    Catch e As Exception
      Return False
    Finally
      cn.Close()
      cn.Dispose()
      If _MediePlanNr < 75550 Then ScanGrupper()
      For Each arow As UltraDataRow In MyBase.Rows
        arow("Old MmPris") = arow("New MmPris")
        arow("Old MmRabat") = arow("New MmRabat")
        arow("Old MmTotal") = arow("New MmTotal")
        arow("Old FarvePris") = arow("New FarvePris")
        arow("Old FarveRabat") = arow("New FarveRabat")
        arow("Old FarveTotal") = arow("New FarveTotal")
        arow("Old Total") = arow("New Total")
        arow("Old BureauOrdreNr") = arow("New BureauOrdreNr")
        arow("Old Bemærkning") = arow("New Bemærkning")
        arow("Old Ansvar") = arow("New Ansvar")
        arow("RowState") = "UnChanged"
      Next
      _IsLoading = False
      MyBase.ResumeBindingNotifications()
    End Try
    Return True
  End Function

  Public Function SaveData() As Boolean
    Dim ta As New dstMedieplanLinjerTableAdapters.tblMedieplanLinjerTableAdapter
    Dim rowsSaved As Integer = 0
    Dim arow As Infragistics.Win.UltraWinDataSource.UltraDataRow

    For Each arow In MyBase.Rows
      If arow("RowState") <> "Deleted" Then
        If _sammeBureauOrdreNr Then
          If _fællesBureauOrdreNr Is Nothing Then
            arow("New BureauOrdreNr") = ""
          Else
            arow("New BureauOrdreNr") = _fællesBureauOrdreNr
          End If
        End If
        If IsDBNull(arow("FarveMin")) Then arow("FarveMin") = 0
        If IsDBNull(arow("FarveMax")) Then arow("FarveMax") = 0
        'If ta.Insert(_MediePlanNr, _Version, arow("UgeavisID"), arow("Mm"), arow("NormalMmPris"), arow("New MmPris"), arow("New MmRabat"), arow("New MmTotal"), arow("FarveTillæg"), arow("New FarvePris"), arow("New FarveRabat"), arow("FarveMin"), arow("FarveMax"), arow("New FarveTotal"), arow("New Total"), arow("New BureauOrdreNr"), arow("MaterialeNr"), arow("New Bemærkning"), arow("ManueltÆndret"), arow("SendeGruppe"), arow("RabatGruppe"), arow("MedIGrupper"), arow("MåGiveMmRabat"), arow("ErWeekendGruppe"), arow("WebtillægFaktureresHer"), arow("MiljøTillæg"), arow("TotalInclTillæg"), arow("PrisLåst")) > 0 Then
        If ta.Insert(_MediePlanNr, _Version, arow("UgeavisID"), arow("Mm"), arow("NormalMmPris"), arow("New MmPris"), arow("New MmRabat"), arow("New MmTotal"), arow("FarveTillæg"), arow("New FarvePris"), arow("New FarveRabat"), arow("FarveMin"), arow("FarveMax"), arow("New FarveTotal"), arow("New Total"), arow("New BureauOrdreNr"), arow("MaterialeNr"), arow("New Bemærkning"), arow("ManueltÆndret"), arow("SendeGruppe"), arow("RabatGruppe"), arow("MedIGrupper"), arow("MåGiveMmRabat"), arow("ErWeekendGruppe"), arow("WebtillægFaktureresHer"), arow("MiljøTillæg"), arow("TotalInclTillæg"), False) > 0 Then
          If _status = StatusKoder.stsFærdigTjekketOrdre AndAlso arow("FejlTekst") <> "" Then
            Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
            Dim cm As SqlCommand = cn.CreateCommand
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE tblAnnoncekontrol SET Ansvar = '" & arow("New Ansvar") & "' WHERE (MedieplanNr = " & _MediePlanNr & ") AND (UgeavisID = " & arow("UgeavisID") & ")"
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            cm.Dispose()
            cn.Dispose()
          ElseIf _status = StatusKoder.stsFaktureretOrdre AndAlso arow("FejlTekst") <> "" Then
            Dim fejlKode As Integer
            Select Case arow("FejlTekst")
              Case "Bestilt for sent - ikke bragt"
                fejlKode = 1
              Case "Ordre ikke modtaget"
                fejlKode = 2
              Case "Glemt annonce"
                fejlKode = 3
              Case "DLU har fremsendt forkert matr."
                fejlKode = 4
              Case "Vi har indrykket forkert matr."
                fejlKode = 5
              Case "Forkert farve"
                fejlKode = 6
              Case "Forkert placering"
                fejlKode = 7
              Case "Forkert annonce format"
                fejlKode = 8
              Case "Glemt farve"
                fejlKode = 9
              Case "Forkert Pris"
                fejlKode = 10
              Case "System Fejl"
                fejlKode = 11
              Case Else
                fejlKode = 0
            End Select
            Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
            Dim cm As SqlCommand = cn.CreateCommand
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE tblAnnoncekontrol SET Ansvar = '" & arow("New Ansvar") & "', Fejlkode = " & fejlKode & " WHERE (MedieplanNr = " & _MediePlanNr & ") AND (UgeavisID = " & arow("UgeavisID") & ")"
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            cm.Dispose()
            cn.Dispose()
          End If
          rowsSaved = rowsSaved + 1
        End If
      End If
    Next
    If rowsSaved > 0 Then
      '     MessageBox.Show("Har gemt " & rowsSaved.ToString & " linjer.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information)
      _hasChanges = False
      Return True
    Else
      Return False
    End If
  End Function

  Public Sub ResetRowState()
    Dim arow As Infragistics.Win.UltraWinDataSource.UltraDataRow

    For Each arow In MyBase.Rows
      arow("Old MmPris") = arow("New MmPris")
      arow("Old MmRabat") = arow("New MmRabat")
      arow("Old MmTotal") = arow("New MmTotal")
      arow("Old FarvePris") = arow("New FarvePris")
      arow("Old FarveRabat") = arow("New FarveRabat")
      arow("Old FarveTotal") = arow("New FarveTotal")
      arow("Old Total") = arow("New Total")
      arow("Old BureauOrdreNr") = arow("New BureauOrdreNr")
      arow("Old Bemærkning") = arow("New Bemærkning")
      arow("Old Ansvar") = arow("New Ansvar")
      If arow("RowState") <> "Deleted" Then arow("RowState") = "UnChanged"
    Next
  End Sub

  Protected Overrides Sub OnRowAdded(ByVal e As Infragistics.Win.UltraWinDataSource.RowAddedEventArgs)
    MyBase.OnRowAdded(e)
    Dim cn2 As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm2 As SqlCommand = cn2.CreateCommand
    Dim pris As Double
    Dim bladFormat As String
    Dim prisListeID As Integer

    prisListeID = FindPrisListeIDForBlad(e.Row.Item("UgeavisID"))
    e.Row.Item("PrisListeID") = prisListeID
    pris = getPris("mmPris", e.Row.Item("UgeavisID"), prisListeID)
    cm2.CommandType = CommandType.Text
    cn2.Open()
    MyBase.SuspendBindingNotifications()
    cm2.CommandText = "SELECT OrdreEmail FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
    e.Row.Item("Email") = cm2.ExecuteScalar
    cm2.CommandText = "SELECT PrisforespørgselEmails FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
    e.Row.Item("PrisforespørgselEmails") = cm2.ExecuteScalar
    cm2.CommandText = "SELECT MedieNetKode FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
    If IsDBNull(cm2.ExecuteScalar) Then
      e.Row.Item("MedieNetKode") = ""
    Else
      e.Row.Item("MedieNetKode") = cm2.ExecuteScalar
    End If
    cm2.CommandText = "SELECT MaterialedeadlineTekst FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
    If IsDBNull(cm2.ExecuteScalar) Then
      e.Row.Item("MaterialeDeadline") = "Mangler"
    Else
      e.Row.Item("MaterialeDeadline") = cm2.ExecuteScalar
    End If
    cm2.CommandText = "SELECT Oplag FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
    e.Row.Item("Oplag") = cm2.ExecuteScalar
    cm2.CommandText = "SELECT Totalområde FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
    e.Row.Item("Læsertal") = cm2.ExecuteScalar
    cm2.CommandText = "SELECT Format FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
    bladFormat = cm2.ExecuteScalar
    cm2.CommandText = "SELECT Ejerforhold FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
    If IsDBNull(cm2.ExecuteScalar) Then
      e.Row.Item("Ejerforhold") = ""
    Else
      e.Row.Item("Ejerforhold") = cm2.ExecuteScalar
    End If
    cm2.CommandText = "SELECT tblGrupper.GruppeNavn AS FakturaGruppe FROM tblBladStamdata INNER JOIN tblGrupper ON tblBladStamdata.FakturaGruppeID = tblGrupper.GruppeID WHERE (tblGrupper.GruppeID > 0) AND (tblBladStamdata.BladID = " & e.Row.Item("UgeavisID") & ")"
    If IsDBNull(cm2.ExecuteScalar) Then
      e.Row.Item("FakturaGruppe") = ""
    Else
      e.Row.Item("FakturaGruppe") = cm2.ExecuteScalar
    End If
    If bladFormat.Contains("365") Then
      e.Row.Item("Is365") = True
    Else
      e.Row.Item("Is365") = False
    End If
    If _is365 Then
      If e.Row.Item("Is365") = True Then
        e.Row.Item("Mm") = _antalMm
      Else
        e.Row.Item("Mm") = _antalMm360
      End If
    Else
      e.Row.Item("Mm") = _antalMm
    End If
    If e.Row.Item("Ejerforhold") = "Helsingør Dagblad" OrElse e.Row.Item("Ejerforhold") = "Midtjyske Medier" OrElse e.Row.Item("Ejerforhold") = "Berlingske Lokalaviser" OrElse e.Row.Item("Ejerforhold") = "Den Sydvestjyske Venstrepresse" OrElse e.Row.Item("Ejerforhold") = "Fynske Medier" OrElse e.Row.Item("Ejerforhold") = "North Media" OrElse e.Row.Item("Ejerforhold") = "Jyske Medier A/S" Then
      If e.Row.Item("Ejerforhold") = "Midtjyske Medier" OrElse e.Row.Item("Ejerforhold") = "Berlingske Lokalaviser" Then
        If _placering = 11 OrElse _placering > 12 Then
          If Not (_is365 AndAlso _kolonner = 6) Then
            e.Row.Item("Mm") = e.Row.Item("Mm") + 4 * _kolonner
          End If
        End If
      End If
      If e.Row.Item("Ejerforhold") = "Helsingør Dagblad" Then
        If _opkrævHelsingørMiljøTillæg Then
          'If e.Row.Item("UgeavisID") <> 81 AndAlso e.Row.Item("UgeavisID") <> 275 AndAlso e.Row.Item("UgeavisID") <> 191 Then
          e.Row.Item("MiljøTillæg") = e.Row.Item("Mm") * 0.06
        Else
          e.Row.Item("MiljøTillæg") = 0
          'End If
        End If
      ElseIf e.Row.Item("Ejerforhold") = "Midtjyske Medier" OrElse e.Row.Item("Ejerforhold") = "Berlingske Lokalaviser" Then
        If _opkrævJyskeMiljøTillæg Then
          'If e.Row.Item("UgeavisID") <> 81 AndAlso e.Row.Item("UgeavisID") <> 275 AndAlso e.Row.Item("UgeavisID") <> 191 Then
          e.Row.Item("MiljøTillæg") = e.Row.Item("Mm") * _anvendtMiljøTillæg
        Else
          e.Row.Item("MiljøTillæg") = 0
          'End If
        End If
      ElseIf e.Row.Item("Ejerforhold") = "Fynske Medier" Then
        If _opkrævFynskeMiljøTillæg Then
          e.Row.Item("MiljøTillæg") = e.Row.Item("Mm") * _anvendtMiljøTillæg
        Else
          e.Row.Item("MiljøTillæg") = 0
        End If
      ElseIf e.Row.Item("Ejerforhold") = "North Media" Then
        If _opkrævNorthMiljøTillæg Then
          e.Row.Item("MiljøTillæg") = e.Row.Item("Mm") * 0.06 ' _anvendtMiljøTillæg
        Else
          e.Row.Item("MiljøTillæg") = 0
        End If
      ElseIf e.Row.Item("Ejerforhold") = "Den Sydvestjyske Venstrepresse" Then
        If _opkrævDSVPMiljøTillæg Then
          e.Row.Item("MiljøTillæg") = e.Row.Item("Mm") * _anvendtMiljøTillæg
        Else
          e.Row.Item("MiljøTillæg") = 0
        End If
      ElseIf e.Row.Item("Ejerforhold") = "Jyske Medier A/S" Then
        If _opkrævJyskeMedierASTillæg Then
          e.Row.Item("MiljøTillæg") = e.Row.Item("Mm") * _anvendtMiljøTillæg
        Else
          e.Row.Item("MiljøTillæg") = 0
        End If
      End If
    Else
      e.Row.Item("MiljøTillæg") = 0
    End If
      e.Row.Item("SendeGruppe") = ""
      e.Row.Item("RowID") = NextAutoNumber
      cm2.CommandText = "SELECT MåGiveFarveRabat FROM tblBladStamdata WHERE (BladID = " & e.Row.Item("UgeavisID") & ")"
      e.Row.Item("MåGiveFarveRabat") = cm2.ExecuteScalar
      If pris > 20 Then
        pris = pris / e.Row.Item("Mm")
        e.Row.Item("MåGiveMmRabat") = False
      Else
        e.Row.Item("MåGiveMmRabat") = True
      End If
      e.Row.Item("NormalMmPris") = pris
      e.Row.Item("New MmPris") = pris
      e.Row.Item("Old MmPris") = pris
      e.Row.Item("New MmRabat") = 0
      e.Row.Item("Old MmRabat") = 0

      e.Row.Item("New MmTotal") = (e.Row.Item("New MmPris") * (1 - (e.Row.Item("New MmRabat") / 100))) * e.Row.Item("Mm") '_antalMm
      If _antalFarver = 0 Then
        e.Row.Item("FarveTillæg") = 0
        e.Row.Item("New FarvePris") = 0
      ElseIf _antalFarver = 1 Then
        e.Row.Item("FarveTillæg") = getPris("FarvePris", e.Row.Item("UgeavisID"), prisListeID)
        If _farvePlacering > 0 AndAlso _farvePrisListe > 0 Then
          e.Row.Item("FarveMin") = getPrisFromSQL("FarveMin", e.Row.Item("UgeavisID"), _farvePlacering, _farvePrisListe) 'cm.ExecuteScalar
          e.Row.Item("FarveMax") = getPrisFromSQL("FarveMax", e.Row.Item("UgeavisID"), _farvePlacering, _farvePrisListe) ' cm.ExecuteScalar
          If e.Row.Item("FarveMin") <= 0 Then e.Row.Item("FarveMin") = Nothing
          If e.Row.Item("FarveMax") <= 0 Then e.Row.Item("FarveMax") = Nothing
        Else
          e.Row.Item("FarveMin") = Nothing
          e.Row.Item("FarveMax") = Nothing
        End If
      Else
        e.Row.Item("FarveTillæg") = getPris("Farve4Pris", e.Row.Item("UgeavisID"), prisListeID)
        If _farvePlacering > 0 AndAlso _farvePrisListe > 0 Then
          e.Row.Item("FarveMin") = getPrisFromSQL("Farve4Min", e.Row.Item("UgeavisID"), _farvePlacering, _farvePrisListe) 'cm.ExecuteScalar
          e.Row.Item("FarveMax") = getPrisFromSQL("Farve4Max", e.Row.Item("UgeavisID"), _farvePlacering, _farvePrisListe) ' cm.ExecuteScalar
          If e.Row.Item("FarveMin") <= 0 Then e.Row.Item("FarveMin") = Nothing
          If e.Row.Item("FarveMax") <= 0 Then e.Row.Item("FarveMax") = Nothing
        Else
          e.Row.Item("FarveMin") = Nothing
          e.Row.Item("FarveMax") = Nothing
        End If
      End If
      e.Row.Item("New FarveRabat") = 0
      e.Row.Item("Old FarveRabat") = 0

      If _antalFarver > 0 Then
        If e.Row.Item("FarveTillæg") < 20 Then
          e.Row.Item("New FarvePris") = e.Row.Item("FarveTillæg") * e.Row.Item("Mm")
          If Not IsDBNull(e.Row.Item("FarveMin")) Then
            If e.Row.Item("FarveMin") > 0 Then
              If _MediePlanNr > 75000 AndAlso _MediePlanNr < 76745 Then
                If e.Row.Item("New FarvePris") * (1 - (e.Row.Item("New FarveRabat") / 100)) < e.Row.Item("FarveMin") Then
                  e.Row.Item("New FarvePris") = e.Row.Item("FarveMin")
                  e.Row.Item("New FarveRabat") = 0
                End If
              Else
                If e.Row.Item("New FarvePris") < e.Row.Item("FarveMin") Then
                  e.Row.Item("New FarvePris") = e.Row.Item("FarveMin")
                End If
              End If
            End If
          End If
          If Not IsDBNull(e.Row.Item("FarveMax")) Then
            If e.Row.Item("FarveMax") > 0 Then
              If e.Row.Item("New FarvePris") > e.Row.Item("FarveMax") Then e.Row.Item("New FarvePris") = e.Row.Item("FarveMax")
            End If
          End If
        Else
          e.Row.Item("New FarvePris") = e.Row.Item("FarveTillæg")
        End If
        e.Row.Item("New FarveTotal") = (e.Row.Item("New FarvePris") * (1 - (e.Row.Item("New FarveRabat") / 100)))
      Else
        e.Row.Item("New FarveTotal") = 0
      End If
      e.Row.Item("Old FarvePris") = e.Row.Item("New FarvePris")
      e.Row.Item("ErWeekendGruppe") = False
      e.Row.Item("New Total") = e.Row.Item("New MmTotal") + e.Row.Item("New FarveTotal")
      e.Row.Item("TotalInclTillæg") = e.Row.Item("New Total") + e.Row.Item("MiljøTillæg")
      e.Row.Item("KontaktprisOplag") = (e.Row.Item("TotalInclTillæg") / e.Row.Item("Oplag")) * 1000
      e.Row.Item("KontaktprisLæsertal") = (e.Row.Item("TotalInclTillæg") / e.Row.Item("Læsertal")) * 1000
      e.Row.Item("New BureauOrdreNr") = ""
      e.Row.Item("Old BureauOrdreNr") = ""
      e.Row.Item("New Bemærkning") = ""
      e.Row.Item("Old Bemærkning") = ""
      e.Row.Item("RowState") = "Added"
      e.Row.Item("FejlTekst") = ""
      e.Row.Item("New Ansvar") = ""
      e.Row.Item("Old Ansvar") = ""
      e.Row.Item("ManueltÆndret") = False
      e.Row.Item("Old MmTotal") = e.Row.Item("New MmTotal")
      e.Row.Item("Old FarveTotal") = e.Row.Item("New FarveTotal")
      e.Row.Item("Old Total") = e.Row.Item("New Total")
      e.Row.Item("MedIGrupper") = ""
      e.Row.Item("WebtillægFaktureresHer") = False
      e.Row.Item("BemærkningFraPrisforespørgsel") = False
      FindGrupperForAvis(e.Row.Item("UgeavisID"))
      cn2.Close()
      cn2.Dispose()
      ScanGrupper()
      MyBase.ResumeBindingNotifications()
      checkChanges()
  End Sub

  Private Sub FindGrupperForAvis(ByVal UgeavisID As Integer)
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand
    Dim i As Integer
    Dim j As Integer = 0

    If _gblade Is Nothing Then
      i = 0
    Else
      i = UBound(_gblade) + 1
    End If
    ReDim Preserve _gblade(i)
    _gblade(i).BladID = UgeavisID
    cm.CommandText = "SELECT tblMedIGruppe.GruppeID, tblMedIGruppe.ErTillægsAvis FROM tblMedIGruppe INNER JOIN tblGrupper ON tblMedIGruppe.GruppeID = tblGrupper.GruppeID AND tblMedIGruppe.Version = tblGrupper.Version WHERE (tblMedIGruppe.ID = " & UgeavisID & ") AND (tblGrupper.GruppeType = N'Rabatform') AND (tblMedIGruppe.Version = " & _brugtGruppeVersion & ")"
    cm.CommandType = CommandType.Text
    cn.Open()
    Dim dr As SqlDataReader = cm.ExecuteReader(CommandBehavior.Default)
    While dr.Read
      ReDim Preserve _gblade(i).MedIGruppe(j)
      ReDim Preserve _gblade(i).ErTillægsAvis(j)
      _gblade(i).MedIGruppe(j) = dr("GruppeID")
      _gblade(i).ErTillægsAvis(j) = dr("ErTillægsAvis")
      j = j + 1
    End While

    cm.CommandText = "SELECT PostNr FROM tblBladDækning WHERE (BladID = " & UgeavisID & ")"
    dr.Close()
    dr = cm.ExecuteReader(CommandBehavior.Default)
    j = 0
    While dr.Read
      ReDim Preserve _gblade(i).DæknigsOmrådePostNr(j)
      _gblade(i).DæknigsOmrådePostNr(j) = dr("PostNr")
      j = j + 1
    End While

    dr.Close()
    cn.Close()
    cn.Dispose()
  End Sub

  Private Sub ScanGrupper()
    Dim i As Integer
    Dim j As Integer
    Dim k As Integer
    Dim htområde As Integer = 0
    Dim sjællandområde As Integer = 0
    Dim htrabat As Integer = 0
    Dim htfarverabat As Integer = 0
    Dim sjællandrabat As Integer = 0
    Dim delområde As String
    Dim blad As Integer
    Dim _gbladeKopi() As BladData
    Dim placering As Integer


    If _gblade Is Nothing Then Exit Sub
    If _status >= StatusKoder.stsFærdigTjekketOrdre Then
      Beregn()
      Exit Sub
    End If
    'FindHvilkenAvisWebtillægSkalFaktureresPå()
    ''Find hvilken avis der skal faktureres for webtillæg
    'Find rabatgrupper
    ReDim _gbladeKopi(UBound(_gblade))
    ReDim _antalBladeIGruppe(_gruppeVersion(_brugtGruppeVersion).MaxID)
    For i = 0 To UBound(_gblade)
      _gbladeKopi(i).BladID = _gblade(i).BladID
      If _gblade(i).MedIGruppe IsNot Nothing AndAlso _gblade(i).BladID > 0 Then
        ReDim Preserve _gbladeKopi(i).MedIGruppe(UBound(_gblade(i).MedIGruppe))
        ReDim Preserve _gbladeKopi(i).ErTillægsAvis(UBound(_gblade(i).ErTillægsAvis))
        For j = 0 To UBound(_gblade(i).MedIGruppe)
          _antalBladeIGruppe(_gblade(i).MedIGruppe(j)) = _antalBladeIGruppe(_gblade(i).MedIGruppe(j)) + 1
          _gbladeKopi(i).MedIGruppe(j) = _gblade(i).MedIGruppe(j)
          _gbladeKopi(i).ErTillægsAvis(j) = _gblade(i).ErTillægsAvis(j)
        Next
      End If
    Next
    'Delområde rabatter
    'Hvilke delområder opfylder antalaviser krav?
    For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe)
      _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Valgt = 0
      If _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Type = "Delområde" Then
        If _antalBladeIGruppe(i) >= _gruppeVersion(_brugtGruppeVersion)._gruppe(i).AntalAviserDerSkalVælges Then
          _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Valgt = 1
        End If
      End If
    Next
    'Tæl antal af delområder i region ht og sjælland
    For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe)
      If _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Type = "Delområde" AndAlso _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Valgt = 1 Then
        delområde = LCase(Right(_gruppeVersion(_brugtGruppeVersion)._gruppe(i).Navn, 2))
        Select Case delområde
          Case " a", " b", " c", " d", " e", " f"
            htområde = htområde + 1
          Case " g", " h", " i", " j"
            sjællandområde = sjællandområde + 1
        End Select
      End If
    Next
    Select Case htområde
      Case 1
        htrabat = 25
        htfarverabat = 0
      Case 2
        htrabat = 30
        htfarverabat = 0
      Case 3
        htrabat = 35
        htfarverabat = 25
      Case 4, 5
        htrabat = 35
        htfarverabat = 30
      Case 6
        htrabat = 35
        htfarverabat = 35
    End Select
    Select Case sjællandområde
      Case 1
        sjællandrabat = 15
      Case 2
        sjællandrabat = 20
      Case 3
        sjællandrabat = 25
      Case 4
        sjællandrabat = 30
    End Select
    MyBase.SuspendBindingNotifications()
    For Each arow As UltraDataRow In MyBase.Rows
      If arow("RowState") <> "Deleted" AndAlso _status < StatusKoder.stsUdsendtOrdre Then arow("SendeGruppe") = ""
      If arow("ManueltÆndret") = False Then ' AndAlso arow("PrisLåst") = False Then
        arow("New MmRabat") = 0
        arow("New FarveRabat") = 0
        If arow("MåGiveMmRabat") = True Then
          For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe)
            If _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Type = "Delområde" AndAlso _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Valgt = 1 Then
              blad = FindBladI_gBlade(arow("UgeavisID"))
              If blad > -1 Then
                If _gblade(blad).MedIGruppe IsNot Nothing Then
                  For j = 0 To UBound(_gblade(blad).MedIGruppe)
                    If _gblade(blad).MedIGruppe(j) = i Then
                      Select Case LCase(Right(_gruppeVersion(_brugtGruppeVersion)._gruppe(i).Navn, 2))
                        Case " a"
                          'arow("New MmRabat") = 35
                          'arow("New FarveRabat") = htfarverabat
                        Case " b", " c", " d", " e", " f"
                          arow("New MmRabat") = htrabat
                          arow("New FarveRabat") = htfarverabat
                        Case " g", " h", " i", " j"
                          arow("New MmRabat") = sjællandrabat
                        Case "rd", "yd", "dt"
                          arow("New MmRabat") = 25
                      End Select
                    End If
                  Next
                End If
              End If
            End If
          Next
        End If
      End If
    Next

    'Andre rabatformer undersøges
    'Hvilke rabatformer opfylder antalaviser krav?
    Dim fundetNogen As Boolean = False
    Do
      ReDim _antalBladeIGruppe(_gruppeVersion(_brugtGruppeVersion).MaxID)
      For i = 0 To UBound(_gbladeKopi)
        If _gbladeKopi(i).MedIGruppe IsNot Nothing AndAlso _gbladeKopi(i).BladID > 0 Then
          For j = 0 To UBound(_gbladeKopi(i).MedIGruppe)
            If _gbladeKopi(i).MedIGruppe(j) > -1 AndAlso _gbladeKopi(i).ErTillægsAvis(j) = 0 Then
              _antalBladeIGruppe(_gbladeKopi(i).MedIGruppe(j)) = _antalBladeIGruppe(_gbladeKopi(i).MedIGruppe(j)) + 1
            End If
          Next
        End If
      Next

      For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe)
        _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Valgt = 0
        If _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Type = "Rabat" Then
          If _antalBladeIGruppe(i) >= _gruppeVersion(_brugtGruppeVersion)._gruppe(i).AntalAviserDerSkalVælges Then
            _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Valgt = 1
          End If
        End If
      Next
      'Find gruppe med flest aviser
      Dim gruppeMedFlestBlade As Integer = 0
      Dim valgtRabat As Integer = -1
      fundetNogen = False
      For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe)
        If _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Type = "Rabat" AndAlso _gruppeVersion(_brugtGruppeVersion)._gruppe(i).Valgt Then
          If _antalBladeIGruppe(i) > _antalBladeIGruppe(gruppeMedFlestBlade) Then
            gruppeMedFlestBlade = i
            fundetNogen = True
          End If
        End If
      Next
      'Find rabat for gruppe med flest blade   
      If _placering < 11 Then
        placering = 1
      Else
        placering = 11
      End If
      If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter IsNot Nothing Then
        For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter)
          If _antalBladeIGruppe(gruppeMedFlestBlade) >= _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(i).AntalFra _
             AndAlso _antalBladeIGruppe(gruppeMedFlestBlade) <= _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(i).AntalTil _
             AndAlso _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(i).PlaceringID = placering Then
            valgtRabat = i
            Exit For
          End If
        Next
        If Not valgtRabat > -1 Then 'Find rabat uden placering
          For i = 0 To UBound(_gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter)
            If _antalBladeIGruppe(gruppeMedFlestBlade) >= _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(i).AntalFra _
               AndAlso _antalBladeIGruppe(gruppeMedFlestBlade) <= _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(i).AntalTil Then
              valgtRabat = i
              Exit For
            End If
          Next
        End If
        For Each arow As UltraDataRow In MyBase.Rows
          arow("MedIGrupper") = ""
          blad = FindBladI_gBlade(arow("UgeavisID"))
          If blad > -1 Then
            If _gblade(blad).MedIGruppe IsNot Nothing Then
              For j = 0 To UBound(_gblade(blad).MedIGruppe)
                arow("MedIGrupper") = arow("MedIGrupper") + _gruppeVersion(_brugtGruppeVersion)._gruppe(_gblade(blad).MedIGruppe(j)).Navn & ", "
              Next
              If arow("MedIGrupper") <> "" Then
                arow("MedIGrupper") = Left(arow("MedIGrupper"), Len(arow("MedIGrupper")) - 2)
              End If
            End If
            If _gbladeKopi(blad).MedIGruppe IsNot Nothing Then
              For j = 0 To UBound(_gbladeKopi(blad).MedIGruppe)
                If _gbladeKopi(blad).MedIGruppe(j) = gruppeMedFlestBlade Then
                  If valgtRabat > -1 Then
                    If arow("ManueltÆndret") = False Then ' AndAlso arow("PrisLåst") = False Then
                      If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).MmRabat > 0 _
                        AndAlso _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).MmRabat > arow("New MmRabat") Then
                        arow("New MmRabat") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).MmRabat
                      End If
                      If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveRabat > 0 _
                        AndAlso _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveRabat > arow("New FarveRabat") Then
                        arow("New FarveRabat") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveRabat
                        If arow("New FarveRabat") = 100 Then arow("FarveMin") = Nothing
                      End If
                    End If
                    '  If arow("PrisLåst") = False Then
                    If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).MmPris > 0 Then
                      arow("New MmPris") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).MmPris / _antalBladeIGruppe(gruppeMedFlestBlade)
                      If arow("ManueltÆndret") = False Then
                        arow("New MmRabat") = 0
                        arow("MåGiveMmRabat") = False
                      End If
                    End If
                    If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveTillæg > 0 Then
                      arow("FarveTillæg") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveTillæg / _antalBladeIGruppe(gruppeMedFlestBlade)
                      If arow("ManueltÆndret") = False Then arow("New FarveRabat") = 0
                      If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveMin > 0 Then
                        arow("FarveMin") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveMin / _antalBladeIGruppe(gruppeMedFlestBlade)
                      Else
                        arow("FarveMin") = Nothing
                      End If
                      If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveMax > 0 Then
                        arow("FarveMax") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Rabatter(valgtRabat).FarveMax / _antalBladeIGruppe(gruppeMedFlestBlade)
                      Else
                        arow("FarveMax") = Nothing
                      End If
                    End If
                    'End If
                    arow("RabatGruppe") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Navn
                  End If
                  If _gbladeKopi(blad).ErTillægsAvis(j) = False Then
                    If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).OrdreModtager IsNot Nothing Then
                      If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Navn = "Lokalaviserne Østjylland" Then
                        arow("SendeGruppe") = "Politikens Lokalaviser"
                      Else
                        arow("SendeGruppe") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Navn
                      End If
                      If _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Navn = "Midtjyske Medier" Then
                        If arow("UgeavisID") = 81 OrElse arow("UgeavisID") = 191 OrElse arow("UgeavisID") = 275 OrElse arow("UgeavisID") = 297 OrElse arow("UgeavisID") = 310 Then
                          arow("SendeGruppe") = _gruppeVersion(_brugtGruppeVersion)._gruppe(gruppeMedFlestBlade).Navn
                        Else
                          arow("SendeGruppe") = ""
                        End If
                      End If
                    Else
                      arow("SendeGruppe") = ""
                    End If
                  End If
                End If
              Next
            End If
          End If
        Next
      End If
      For i = 0 To UBound(_gbladeKopi)
        If _gbladeKopi(i).MedIGruppe IsNot Nothing Then
          For k = 0 To UBound(_gbladeKopi(i).MedIGruppe)
            If _gbladeKopi(i).MedIGruppe(k) = gruppeMedFlestBlade Then
              _gbladeKopi(i).MedIGruppe(k) = -1
            End If
          Next
        End If
      Next
    Loop While fundetNogen
    ScanWeekendGruppe()
    MyBase.ResumeBindingNotifications()
  End Sub

  'Private Sub FindHvilkenAvisWebtillægSkalFaktureresPå()
  '  Dim fundneEjerforhold As New List(Of String)
  '  Dim fundetEjerforhold As Boolean = False
  '  Dim findEjerforhold As String

  '  For Each arow As UltraDataRow In MyBase.Rows
  '    arow("WebtillægFaktureresHer") = False
  '    If arow("RowState") <> "Deleted" Then
  '      If arow("Ejerforhold") <> "" Then
  '        findEjerforhold = arow("Ejerforhold")
  '        fundetEjerforhold = False
  '        For Each Ejerforhold As String In fundneEjerforhold
  '          If findEjerforhold = Ejerforhold Then
  '            fundetEjerforhold = True
  '          End If
  '        Next
  '        If Not fundetEjerforhold Then
  '          fundneEjerforhold.Add(findEjerforhold)
  '          arow("WebtillægFaktureresHer") = True
  '        End If
  '      End If
  '    End If
  '  Next
  'End Sub

  Private Sub ScanWeekendGruppe()
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim k As Integer = 0
    Dim blad As Integer = -1
    Dim PolaHovedblad As Integer
    Dim count As Integer = 0
    Dim PolaBlade(9) As Integer
    Dim OdenseUgeavisFundet As Boolean = False

    Dim weekendGruppe(9) As Integer
    weekendGruppe(0) = 460
    weekendGruppe(1) = 392
    weekendGruppe(2) = 556
    weekendGruppe(3) = 465
    weekendGruppe(4) = 461
    weekendGruppe(5) = 466
    weekendGruppe(6) = 468
    weekendGruppe(7) = 467
    weekendGruppe(8) = 564

    Dim weekendCounter As Integer
    Dim supplerendePris As Double
    Dim hverdagGruppe(11) As Integer
    hverdagGruppe(0) = 14
    hverdagGruppe(1) = 21
    hverdagGruppe(2) = 25
    hverdagGruppe(3) = 29
    hverdagGruppe(4) = 47
    hverdagGruppe(5) = 104
    hverdagGruppe(6) = 112
    hverdagGruppe(7) = 127
    hverdagGruppe(8) = 385
    hverdagGruppe(9) = 395
    hverdagGruppe(10) = 455
    hverdagGruppe(11) = 491

    'Hardkodet weekendgruppe
    If _gblade Is Nothing Then Exit Sub
    MyBase.SuspendBindingNotifications()

    For i = 0 To UBound(_gblade)
      If _gblade(i).BladID = 11 Then OdenseUgeavisFundet = True
      If _gblade(i).MedIGruppe IsNot Nothing AndAlso _gblade(i).BladID > 0 Then
        For j = 0 To UBound(_gblade(i).MedIGruppe)
          If _gblade(i).MedIGruppe(j) = 6 Then
            PolaBlade(count) = _gblade(i).BladID
            count = count + 1
            If _gblade(i).DæknigsOmrådePostNr IsNot Nothing Then
              For k = 0 To UBound(_gblade(i).DæknigsOmrådePostNr) - 1
                If _gblade(i).DæknigsOmrådePostNr(j) = _annoncørPostNr Then
                  '  MsgBox("Bladet " & gBlade(i).strBladNavn & " ligger i kundens dækningsområde og er valgt som hovedblad.")
                  PolaHovedblad = _gblade(i).BladID
                End If
              Next k
            End If
          End If
        Next j
      End If
    Next i
    If count > 0 Then 'Er der fundet blade i gruppen?
      If _MediePlanNr = 0 OrElse _MediePlanNr > 83840 Then
        For i = 0 To UBound(_gblade)  'Hvis der er en hverdag med, skal alle weekend være supplerende
          If _gblade(i).BladID > 0 Then
            For j = 0 To 11
              If _gblade(i).BladID = hverdagGruppe(j) Then
                PolaHovedblad = -1
                Exit For
              End If
            Next
          End If
          If PolaHovedblad = -1 Then Exit For
        Next
      End If
      Do While PolaHovedblad = 0 'Hvis den er 0, er der ikke fundet en hverdag, så led efter weekend
        For i = 0 To count - 1
          If PolaBlade(i) = weekendGruppe(weekendCounter) Then PolaHovedblad = weekendGruppe(weekendCounter)
        Next i
        weekendCounter = weekendCounter + 1
        If weekendCounter > 8 Then Exit Do
      Loop
      If PolaHovedblad = 0 Then
        MsgBox("Har fundet pola weekend blade, men kan ikke finde hovedblad.")
      Else
        For Each arow As UltraDataRow In MyBase.Rows
          blad = FindBladI_gBlade(arow("UgeavisID"))
          If blad > -1 Then
            If _gblade(blad).MedIGruppe IsNot Nothing AndAlso _gblade(blad).BladID > 0 Then
              For j = 0 To UBound(_gblade(blad).MedIGruppe)
                If _gblade(blad).MedIGruppe(j) = 6 Then
                  'If arow("ManueltÆndret") = False Then
                  'If arow("PrisLåst") = False Then

                  If _placering = 5 Then  'Højre side priser
                    supplerendePris = getPrisFromSQL("mmPris", _gblade(blad).BladID, 7, arow("PrislisteID"))
                  Else
                    supplerendePris = getPrisFromSQL("mmPris", _gblade(blad).BladID, 6, arow("PrislisteID"))
                  End If
                  If _gblade(blad).BladID = PolaHovedblad OrElse _SammeMateriale = False Then
                    arow("New MmPris") = getPris("mmPris", _gblade(blad).BladID, arow("PrislisteID")) 'hovedPris
                  Else
                    arow("New MmPris") = supplerendePris
                    arow("New FarvePris") = 0
                    arow("FarveTillæg") = 0
                    arow("MåGiveFarveRabat") = False
                    arow("FarveMin") = 0
                    arow("FarveMax") = 0
                    arow("New FarveRabat") = 0
                  End If
                  '  If arow("ManueltÆndret") = False Then arow("New FarveRabat") = 0
                  If arow("ManueltÆndret") = False Then arow("New MmRabat") = 0
                  'End If
                  'End If
                  arow("ErWeekendGruppe") = True
                  arow("RabatGruppe") = "Politiken Weekend"
                  arow("SendeGruppe") = "Politikens Lokalaviser"
                End If
              Next j
            End If
          End If
        Next
      End If
    End If
    For Each arow As UltraDataRow In MyBase.Rows
      'If arow("PrisLåst") = False Then
      If arow("UgeavisID") = 565 Then
        If OdenseUgeavisFundet AndAlso _SammeMateriale Then
          If _placering = 5 Then
            arow("New MmPris") = getPrisFromSQL("mmPris", 565, 7, arow("PrislisteID"))
          Else
            arow("New MmPris") = getPrisFromSQL("mmPris", 565, 6, arow("PrislisteID"))
          End If
        Else
          If arow("ManueltÆndret") = False Then
            arow("New MmPris") = getPris("mmPris", 565, arow("PrislisteID"))
          End If
        End If
      End If
      'End If
    Next

    scanNorthMediaGruppe()
    MyBase.ResumeBindingNotifications()
  End Sub

  Private Sub scanNorthMediaGruppe()
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim k As Integer = 0
    Dim blad As Integer = -1
    Dim NorthMediaHovedblad As Integer
    Dim count As Integer = 0
    Dim NorthMediaBlade(9) As Integer

    Dim weekendGruppe(5) As Integer
    weekendGruppe(0) = 566
    weekendGruppe(1) = 567
    weekendGruppe(2) = 571
    weekendGruppe(3) = 568
    weekendGruppe(4) = 569
    weekendGruppe(5) = 570


    Dim weekendCounter As Integer
    Dim supplerendePris As Double
    Dim hverdagGruppe(8) As Integer
    hverdagGruppe(0) = 15
    hverdagGruppe(1) = 20
    hverdagGruppe(2) = 24
    hverdagGruppe(3) = 44
    hverdagGruppe(4) = 47
    hverdagGruppe(5) = 45
    hverdagGruppe(6) = 46
    hverdagGruppe(7) = 48
    hverdagGruppe(8) = 404


    'Hardkodet weekendgruppe
    If _gblade Is Nothing Then Exit Sub
    MyBase.SuspendBindingNotifications()

    For i = 0 To UBound(_gblade)
      If _gblade(i).MedIGruppe IsNot Nothing AndAlso _gblade(i).BladID > 0 Then
        For j = 0 To UBound(_gblade(i).MedIGruppe)
          If _gblade(i).MedIGruppe(j) = 61 Then
            NorthMediaBlade(count) = _gblade(i).BladID
            count = count + 1
            If _gblade(i).DæknigsOmrådePostNr IsNot Nothing Then
              For k = 0 To UBound(_gblade(i).DæknigsOmrådePostNr) - 1
                If _gblade(i).DæknigsOmrådePostNr(j) = _annoncørPostNr Then
                  '  MsgBox("Bladet " & gBlade(i).strBladNavn & " ligger i kundens dækningsområde og er valgt som hovedblad.")
                  NorthMediaHovedblad = _gblade(i).BladID
                End If
              Next k
            End If
          End If
        Next j
      End If
    Next i
    If count > 0 Then 'Er der fundet blade i gruppen?
      If _MediePlanNr = 0 OrElse _MediePlanNr > 83840 Then
        For i = 0 To UBound(_gblade)  'Hvis der er en hverdag med, skal alle weekend være supplerende
          If _gblade(i).BladID > 0 Then
            For j = 0 To 8
              If _gblade(i).BladID = hverdagGruppe(j) Then
                NorthMediaHovedblad = -1
                Exit For
              End If
            Next
          End If
          If NorthMediaHovedblad = -1 Then Exit For
        Next
      End If
      Do While NorthMediaHovedblad = 0 'Hvis den er 0, er der ikke fundet en hverdag, så led efter weekend
        For i = 0 To count - 1
          If NorthMediaBlade(i) = weekendGruppe(weekendCounter) Then NorthMediaHovedblad = weekendGruppe(weekendCounter)
        Next i
        weekendCounter = weekendCounter + 1
        If weekendCounter > 5 Then Exit Do
      Loop
      If NorthMediaHovedblad = 0 Then
        MsgBox("Har fundet NorthMedia weekend blade, men kan ikke finde hovedblad.")
      Else
        For Each arow As UltraDataRow In MyBase.Rows
          blad = FindBladI_gBlade(arow("UgeavisID"))
          If blad > -1 Then
            If _gblade(blad).MedIGruppe IsNot Nothing AndAlso _gblade(blad).BladID > 0 Then
              For j = 0 To UBound(_gblade(blad).MedIGruppe)
                If _gblade(blad).MedIGruppe(j) = 61 Then
                  'If arow("PrisLåst") = False Then
                  'If arow("ManueltÆndret") = False Then
                  If _placering = 5 Then  'Højre side priser
                    supplerendePris = getPrisFromSQL("mmPris", _gblade(blad).BladID, 7, arow("PrislisteID"))
                  Else
                    supplerendePris = getPrisFromSQL("mmPris", _gblade(blad).BladID, 6, arow("PrislisteID"))
                  End If
                  If _gblade(blad).BladID = NorthMediaHovedblad Then 'OrElse _SammeMateriale = False Then
                    arow("New MmPris") = getPris("mmPris", _gblade(blad).BladID, arow("PrislisteID")) 'hovedPris
                  Else
                    arow("New MmPris") = supplerendePris
                    arow("New FarvePris") = 0
                    arow("FarveTillæg") = 0
                    arow("MåGiveFarveRabat") = False
                    arow("FarveMin") = 0
                    arow("FarveMax") = 0
                    arow("New FarveRabat") = 0
                  End If
                  '  If arow("ManueltÆndret") = False Then arow("New FarveRabat") = 0
                  If arow("ManueltÆndret") = False Then arow("New MmRabat") = 0
                  'End If
                  'End If
                  arow("ErWeekendGruppe") = True
                  arow("RabatGruppe") = "North Media Weekend"
                  arow("SendeGruppe") = "North Media"
                End If
              Next j
            End If
          End If
        Next
      End If
    End If
    Beregn()
    MyBase.ResumeBindingNotifications()
  End Sub


  Public Sub DeleteAvis(ByVal UgeavisID As Integer)
    Dim blad As Integer = FindBladI_gBlade(UgeavisID)
    If blad > -1 Then
      _gblade(blad).BladID = 0
      ScanGrupper()
    End If
  End Sub

  Public Sub ReInsertAvis(ByVal UgeavisID As Integer)
    FindGrupperForAvis(UgeavisID)
    ScanGrupper()
  End Sub

  Private Function FindBladI_gBlade(ByVal UgeavisID As Integer) As Integer
    Dim j As Integer

    For j = 0 To UBound(_gblade)
      If _gblade(j).BladID = UgeavisID Then
        Return j
      End If
    Next
    Return -1
  End Function

  Protected Overrides Sub OnCellDataUpdated(ByVal e As Infragistics.Win.UltraWinDataSource.CellDataUpdatedEventArgs)
    MyBase.OnCellDataUpdated(e)
    Dim tidligerePris As Double
    Dim diff As Double

    Select Case e.Column.Key
      Case "New MmTotal"
        tidligerePris = e.Row("New MmPris") * e.Row("Mm") '_antalMm
        diff = tidligerePris - e.NewValue
        If diff > 0 Then
          e.Row("New MmRabat") = (diff / tidligerePris) * 100
        Else
          e.Row("New MmPris") = e.NewValue / e.Row("Mm") '_antalMm
          e.Row("New MmRabat") = 0
        End If
      Case "New FarveTotal"
        e.Row("FarveMin") = -1 'Nothing
        If e.Row("FarveTillæg") < 20 Then
          tidligerePris = e.Row("FarveTillæg") * e.Row("Mm") '_antalMm
          If Not IsDBNull(e.Row("FarveMin")) Then
            If e.Row("FarveMin") > 0 Then
              If tidligerePris < e.Row("FarveMin") Then
                tidligerePris = e.Row("FarveMin")
              End If
            End If
          End If
          If Not IsDBNull(e.Row("FarveMax")) Then
            If e.Row("FarveMax") > 0 Then
              If tidligerePris > e.Row("FarveMax") Then tidligerePris = e.Row("FarveMax")
            End If
          End If
        Else
          tidligerePris = e.Row("FarveTillæg")
        End If
        diff = tidligerePris - e.NewValue
        If diff > 0 Then
          e.Row("New FarveRabat") = (diff / tidligerePris) * 100
        Else
          e.Row("New FarvePris") = e.NewValue
          e.Row("New FarveRabat") = 0
        End If
      Case "New FarveRabat"
        If _MediePlanNr > 75000 AndAlso _MediePlanNr < 76745 Then
          If e.Row("New FarveRabat") = 100 Then e.Row("FarveMin") = -1 'Nothing
        End If
      Case "New Total"
        e.Row("FarveMin") = -1 'Nothing
        If e.NewValue >= e.Row("New MmPris") * e.Row("Mm") Then
          If e.Row("New FarvePris") > 0 Then   'hele rabatten kan gives på farve
            If e.Row("FarveTillæg") < 20 Then
              tidligerePris = e.Row("FarveTillæg") * e.Row("Mm") '_antalMm
              If Not IsDBNull(e.Row("FarveMin")) Then
                If e.Row("FarveMin") > 0 Then
                  If tidligerePris < e.Row("FarveMin") Then
                    tidligerePris = e.Row("FarveMin")
                  End If
                End If
              End If
              If Not IsDBNull(e.Row("FarveMax")) Then
                If e.Row("FarveMax") > 0 Then
                  If tidligerePris > e.Row("FarveMax") Then tidligerePris = e.Row("FarveMax")
                End If
              End If
            Else
              tidligerePris = e.Row("FarveTillæg")
            End If
            diff = tidligerePris - (e.NewValue - (e.Row("New MmPris") * e.Row("Mm")))
            e.Row("New FarveRabat") = (diff / tidligerePris) * 100
          Else
            e.Row("New MmPris") = e.NewValue / e.Row("Mm") '_antalMm
          End If
          e.Row("New MmRabat") = 0
        Else
          e.Row("New FarveRabat") = 100
          tidligerePris = e.Row("New MmPris") * e.Row("Mm") ' _antalMm 'e.Row("New MmTotal")
          diff = tidligerePris - e.NewValue
          If diff > 0 Then
            e.Row("New MmRabat") = (diff / tidligerePris) * 100
          Else
            e.Row("New MmPris") = e.NewValue / e.Row("Mm") '_antalMm
            e.Row("New MmRabat") = 0
          End If
        End If
      Case "New BureauOrdreNr"
        RaiseEvent BureauOrdreNrIndtastet()
      Case "New Ansvar"
        RaiseEvent AnsvarIndtastet()
      Case "New FarvePris"
        e.Row("FarveTillæg") = e.Row("New FarvePris")
    End Select
    If e.Column.Key <> "New Bemærkning" AndAlso e.Column.Key <> "New BureauOrdreNr" AndAlso e.Column.Key <> "MaterialeNr" AndAlso e.Column.Key <> "Mm" Then
      e.Row("ManueltÆndret") = True
    End If
    e.Row("New MmTotal") = (e.Row("New MmPris") * (1 - (e.Row("New MmRabat") / 100))) * e.Row("Mm") ' _antalMm
    'Farve beregning incl. min og max

    If _antalFarver > 0 Then
      If e.Row("FarveTillæg") < 20 Then
        e.Row("New FarvePris") = e.Row("FarveTillæg") * e.Row("Mm")
        If Not IsDBNull(e.Row("FarveMin")) Then
          If e.Row("FarveMin") > 0 Then
            If _MediePlanNr > 75000 AndAlso _MediePlanNr < 76745 Then
              If e.Row("New FarvePris") * (1 - (e.Row("New FarveRabat") / 100)) < e.Row("FarveMin") Then
                e.Row("New FarvePris") = e.Row("FarveMin")
                e.Row("New FarveRabat") = 0
              End If
            Else
              If e.Row("New FarvePris") < e.Row("FarveMin") Then
                e.Row("New FarvePris") = e.Row("FarveMin")
              End If
            End If
          End If
        End If
        If Not IsDBNull(e.Row("FarveMax")) Then
          If e.Row("FarveMax") > 0 Then
            If e.Row("New FarvePris") > e.Row("FarveMax") Then e.Row("New FarvePris") = e.Row("FarveMax")
          End If
        End If
      Else
        e.Row("New FarvePris") = e.Row("FarveTillæg")
      End If
      e.Row("New FarveTotal") = (e.Row("New FarvePris") * (1 - (e.Row("New FarveRabat") / 100)))
      If Not IsDBNull(e.Row("FarveMin")) Then
        If e.Row("FarveMin") > 0 Then
          If e.Row("New FarveTotal") < e.Row("FarveMin") Then
            RaiseEvent MarkerMinPris(e.Row("UgeavisID"), True)
          Else
            RaiseEvent MarkerMinPris(e.Row("UgeavisID"), False)
          End If
        End If
      End If
    Else
      e.Row("New FarveTotal") = 0
    End If
    e.Row("New Total") = e.Row("New MmTotal") + e.Row("New FarveTotal")
    If e.Row("New Total") = 0 Then e.Row("MiljøTillæg") = 0
    e.Row("TotalInclTillæg") = e.Row("New Total") + e.Row("MiljøTillæg")
    e.Row("KontaktprisOplag") = (e.Row("TotalInclTillæg") / e.Row("Oplag")) * 1000
    e.Row("KontaktprisLæsertal") = (e.Row("TotalInclTillæg") / e.Row("Læsertal")) * 1000
    'If Not _IsLoading AndAlso e.Row("RowState") = "UnChanged" Then e.Row("RowState") = "Changed"
    checkChanges()
  End Sub

  Private Sub checkChanges()
    _hasChanges = False
    Dim changeFound As Boolean = False
    Dim arow As Infragistics.Win.UltraWinDataSource.UltraDataRow
    For Each arow In MyBase.Rows
      changeFound = False
      If _antalFarver > 0 Then
        If Round(arow("New MmPris"), 2) <> Round(arow("Old MmPris"), 2) OrElse Round(arow("New MmRabat"), 2) <> Round(arow("Old MmRabat"), 2) OrElse Round(arow("New FarvePris"), 2) <> Round(arow("Old FarvePris"), 2) OrElse Round(arow("New FarveRabat"), 2) <> Round(arow("Old FarveRabat"), 2) OrElse arow("New Bemærkning") <> arow("Old Bemærkning") OrElse Abs(Round(arow("New MmTotal"), 2) - Round(arow("Old MmTotal"), 2)) > 0.09 OrElse Abs(Round(arow("New FarveTotal"), 2) - Round(arow("Old FarveTotal"), 2)) > 0.09 OrElse Abs(Round(arow("New Total"), 2) - Round(arow("Old Total"), 2)) > 0.09 OrElse arow("New Ansvar") <> arow("Old Ansvar") OrElse arow("New BureauOrdreNr") <> arow("Old BureauOrdreNr") Then
          changeFound = True
        End If
      Else
        If Round(arow("New MmPris"), 2) <> Round(arow("Old MmPris"), 2) OrElse Round(arow("New MmRabat"), 2) <> Round(arow("Old MmRabat"), 2) OrElse arow("New Bemærkning") <> arow("Old Bemærkning") OrElse Abs(Round(arow("New MmTotal"), 2) - Round(arow("Old MmTotal"), 2)) > 0.09 OrElse Abs(Round(arow("New Total"), 2) - Round(arow("Old Total"), 2)) > 0.09 OrElse arow("New Ansvar") <> arow("Old Ansvar") OrElse arow("New BureauOrdreNr") <> arow("Old BureauOrdreNr") Then changeFound = True
      End If
      If changeFound Then
        If Not _IsLoading AndAlso arow("RowState") = "UnChanged" Then
          arow("RowState") = "Changed"
          'arow("Change Reason") = ""
          'If Round(arow("New MmPris"), 2) <> Round(arow("Old MmPris"), 2) Then arow("Change Reason") = "Mm Pris, "
          'If Round(arow("New MmRabat"), 2) <> Round(arow("Old MmRabat"), 2) Then arow("Change Reason") = arow("Change Reason") + "Mm Rabat, "
          'If _antalFarver > 0 AndAlso Round(arow("New FarvePris"), 2) <> Round(arow("Old FarvePris"), 2) Then arow("Change Reason") = arow("Change Reason") + "Farve Pris, "
          'If _antalFarver > 0 AndAlso Round(arow("New FarveRabat"), 2) <> Round(arow("Old FarveRabat"), 2) Then arow("Change Reason") = arow("Change Reason") + "Farve Rabat, "
          'If arow("New Bemærkning") <> arow("Old Bemærkning") Then arow("Change Reason") = arow("Change Reason") + "Bemærkning, "
          'If Round(arow("New MmTotal"), 2) <> Round(arow("Old MmTotal"), 2) Then arow("Change Reason") = arow("Change Reason") & "Mm Total fra " & Round(arow("Old MmTotal"), 2) & " til " & Round(arow("New MmTotal"), 2) & ", "
          'If _antalFarver > 0 AndAlso Round(arow("New FarveTotal"), 2) <> Round(arow("Old FarveTotal"), 2) Then arow("Change Reason") = arow("Change Reason") & "Farve Total fra " & Round(arow("Old FarveTotal"), 2) & " til " & Round(arow("New FarveTotal"), 2) & ", "
          'If Round(arow("New Total"), 2) <> Round(arow("Old Total"), 2) Then arow("Change Reason") = arow("Change Reason") & "Total fra " & Round(arow("Old Total"), 2) & " til " & Round(arow("New Total"), 2) & ", "
          'If arow("New Ansvar") <> arow("Old Ansvar") Then arow("Change Reason") = arow("Change Reason") + "Ansvar, "
          'If arow("Change Reason").ToString.Length > 0 Then arow("Change Reason") = arow("Change Reason").ToString.Remove(arow("Change Reason").ToString.Length - 2, 2)
        End If
      Else
        If Not _IsLoading AndAlso arow("RowState") = "Changed" Then arow("RowState") = "UnChanged"
      End If
    Next
    For Each arow In MyBase.Rows
      If arow("RowState") <> "UnChanged" Then
        _hasChanges = True
        RaiseEvent HasChanges(True)
        Exit Sub
      End If
    Next
    RaiseEvent HasChanges(False)
  End Sub
End Class