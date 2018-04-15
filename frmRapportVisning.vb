Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmRapportVisning
  Friend WithEvents rptMedieplanMedOplagUdenTillæg As WinPlanner.MedieplanMedOplagUdenTillæg
  Friend WithEvents rptMedieplanMedOplagMedTillæg As WinPlanner.MedieplanMedOplagMedTillæg
  Friend WithEvents rptBilagUdenLæsertalUdenPostNr As WinPlanner.BilagUdenLæsertalUdenPostNr
  Friend WithEvents rptBilagMedLæsertalUdenPostNr As WinPlanner.BilagMedLæsertalUdenPostNr
  Friend WithEvents rptBilagUdenLæsertalMedPostNr As WinPlanner.BilagUdenLæsertalMedPostNr
  Friend WithEvents rptBilagMedLæsertalMedPostNr As WinPlanner.BilagMedLæsertalMedPostNr
  ' Friend WithEvents rptWebTillæg As WinPlanner.WebtillægBilag
  Friend WithEvents rpt As ReportClass
  Private _medieplanNr As Integer
  Private _version As Integer
  Private _filNavn As String
  Private _beskrivelse As String
  Private _status As StatusKoder
  Private _år As Integer
  'Private _webTillægOpkræves As Boolean
  'Private _webTillægVises As Boolean = False
  Private _miljøTillægVises As Boolean = True
  Private _tillægPåRapport As Boolean

  Public WriteOnly Property Beskrivelse() As String
    Set(ByVal value As String)
      _beskrivelse = value
    End Set
  End Property

  'Public Sub New(ByVal MedieplanNr As Integer, ByVal Version As Integer, ByVal status As StatusKoder, ByVal år As Integer, ByVal WebTillægOpkræves As Boolean, ByVal MiljøTillægVises As Boolean)
  Public Sub New(ByVal MedieplanNr As Integer, ByVal Version As Integer, ByVal status As StatusKoder, ByVal år As Integer, ByVal MiljøTillægVises As Boolean)

    InitializeComponent()

    _medieplanNr = MedieplanNr
    _version = Version
    _status = status
    _år = år
    '_webTillægOpkræves = WebTillægOpkræves
    _miljøTillægVises = MiljøTillægVises
    'If _år > 2010 Then
    '  If _webTillægOpkræves Then
    '    btnWebTillæg.Visible = True
    '  Else
    '    btnWebTillæg.Visible = False
    '  End If
    'Else
    '  btnWebTillæg.Visible = False
    'End If
    If _status > StatusKoder.stsFærdigTjekketOrdre Then
      lblMedieplan.Visible = False
      lblBilag.Visible = False
      optLæsertal.Visible = False
      optPostNr.Visible = False
      chkLinier.Visible = False
    End If
    showReport(True)
  End Sub

  Private Sub btnLuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    Me.Close()
  End Sub

  Private Sub showReport(ByVal withLogo As Boolean)
    'If Not _webTillægVises Then
    If _status < StatusKoder.stsFaktureretOrdre Then
      Select Case True
        Case optMedieplan.CheckedIndex = 0
          If _miljøTillægVises Then
            rpt = New WinPlanner.MedieplanMedOplagMedTillæg
          Else
            rpt = New WinPlanner.MedieplanMedOplagUdenTillæg
          End If
        Case optLæsertal.CheckedIndex = 0 AndAlso optPostNr.CheckedIndex = 0
          rpt = New WinPlanner.BilagUdenLæsertalUdenPostNr
        Case optLæsertal.CheckedIndex = 0 AndAlso optPostNr.CheckedIndex = 1
          rpt = New WinPlanner.BilagUdenLæsertalMedPostNr
        Case optLæsertal.CheckedIndex = 1 AndAlso optPostNr.CheckedIndex = 0
          rpt = New WinPlanner.BilagMedLæsertalUdenPostNr
        Case optLæsertal.CheckedIndex = 1 AndAlso optPostNr.CheckedIndex = 1
          rpt = New WinPlanner.BilagMedLæsertalMedPostNr
      End Select
    Else
      Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
      Dim cm As SqlCommand = cn.CreateCommand()
      Dim bilagsType As Integer

      cm.CommandType = Data.CommandType.Text
      cm.CommandText = "SELECT NavisionContact.[Invoice Document Type] FROM tblMedieplan INNER JOIN NavisionContact ON tblMedieplan.BureauNo_ = NavisionContact.No_ WHERE (tblMedieplan.MedieplanNr = " & _medieplanNr & ") AND (tblMedieplan.Version = " & _version & ")"
      cn.Open()
      bilagsType = CInt(cm.ExecuteScalar())
      cn.Close()
      cm.Dispose()
      cn.Dispose()
      If _status = StatusKoder.stsFaktureretOrdre Then
        If bilagsType = 0 Then
          rpt = New WinPlanner.FakturaBilagInclAnnoncekontrolFejl
        Else
          rpt = New WinPlanner.FakturaBilag2InclAnnoncekontrolFejl
        End If
      Else
        If bilagsType = 0 Then
          rpt = New WinPlanner.FakturaBilagInclFaktureringsFejl
        Else
          rpt = New WinPlanner.FakturaBilag2InclFaktureringsFejl
        End If
      End If
    End If
    'Else
    'rpt = New WinPlanner.WebtillægBilag
    'End If

    If rpt IsNot Nothing Then
      rpt.SetDatabaseLogon("LocalPlanner", "lp4DLU")
      rpt.SetParameterValue("MedieplanNrParam", _medieplanNr)
      rpt.SetParameterValue("VersionParam", _version)
      'If Not withLogo Then
      '  rpt.ReportDefinition.ReportObjects.Item("picLogo").ObjectFormat.EnableSuppress = True
      'Else
      '  rpt.ReportDefinition.ReportObjects.Item("picLogo").ObjectFormat.EnableSuppress = False
      'End If
      'If Not _webTillægVises Then
      If _status < StatusKoder.stsFaktureretOrdre Then
        If chkLinier.Enabled Then
          If chkLinier.Checked Then
            rpt.ReportDefinition.ReportObjects.Item("ItemLine").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects.Item("txtBureauOrdreNr").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects.Item("BureauOrdreNr").ObjectFormat.EnableSuppress = False
          Else
            rpt.ReportDefinition.ReportObjects.Item("ItemLine").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects.Item("txtBureauOrdreNr").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects.Item("BureauOrdreNr").ObjectFormat.EnableSuppress = True
          End If
        End If
      End If
      Dim _sortFieldGeo As FieldDefinition = rpt.Database.Tables.Item("tblGeoKode").Fields.Item("GeoKodeSortKey")
      Dim _sortFieldNavn As FieldDefinition = rpt.Database.Tables.Item("tblBladStamdata").Fields.Item("Navn")
      rpt.DataDefinition.SortFields.Reset()
      If optSortering.CheckedIndex = 0 Then
        rpt.DataDefinition.SortFields.Item(0).Field = _sortFieldNavn
      Else
        rpt.DataDefinition.SortFields.Item(0).Field = _sortFieldGeo
        rpt.DataDefinition.SortFields.Item(1).Field = _sortFieldNavn
      End If
      Me.Text = "U: " & getMedieplanString(_medieplanNr, _version)
      'Else
      '  Me.Text = "Web: " & getMedieplanString(_medieplanNr, _version)
      'End If
      CRViewer.ReportSource = rpt
      CRViewer.Zoom(1)
    End If
  End Sub

  Private Sub btnUdskriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUdskriv.Click
    showReport(False)
    CRViewer.PrintReport()
    showReport(True)
  End Sub

  Private Sub btnGemPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGemPDF.Click
    'If Not _webTillægVises Then
    If optMedieplan.CheckedIndex > -1 Then
      _filNavn = getMedieplanString(_medieplanNr, _version) & " " & _beskrivelse & ".pdf"
    Else
      _filNavn = getMedieplanString(_medieplanNr, _version) & " Bilag.pdf"
    End If
    'Else
    '_filNavn = getMedieplanString(_medieplanNr, _version) & " Webtillæg bilag.pdf"
    'End If
    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "M:\" & fjernUlovligeTegnFraString(_filNavn))
    MessageBox.Show("Gemt PDF fil som M:\" & fjernUlovligeTegnFraString(_filNavn), "PDF gemt", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub optMedieplan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMedieplan.ValueChanged
    If optMedieplan.CheckedIndex > -1 Then
      optLæsertal.CheckedIndex = -1
      optPostNr.CheckedIndex = -1
      chkLinier.Enabled = True
      showReport(True)
    End If
  End Sub

  Private Sub optLæsertal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optLæsertal.ValueChanged
    If optLæsertal.CheckedIndex > -1 Then
      optMedieplan.CheckedIndex = -1
      chkLinier.Enabled = False
      If optPostNr.CheckedIndex = -1 Then
        optPostNr.CheckedIndex = 0
      Else
        showReport(True)
      End If
    End If
  End Sub

  Private Sub optPostNr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPostNr.ValueChanged
    If optPostNr.CheckedIndex > -1 Then
      optMedieplan.CheckedIndex = -1
      chkLinier.Enabled = False
      If optLæsertal.CheckedIndex = -1 Then
        optLæsertal.CheckedIndex = 0
      Else
        showReport(True)
      End If
    End If
  End Sub

  Private Sub optSortering_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSortering.ValueChanged
    showReport(True)
  End Sub

  Private Sub chkLinier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLinier.CheckedChanged
    showReport(True)
  End Sub

  'Private Sub btnWebTillæg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If _webTillægVises Then
  '    _webTillægVises = False
  '    'btnWebTillæg.Text = "Vís Webtillæg"
  '    lblMedieplan.Visible = True
  '    chkLinier.Visible = True
  '    optMedieplan.Visible = True
  '    lblBilag.Visible = True
  '    optLæsertal.Visible = True
  '    optPostNr.Visible = True
  '    lblSortering.Visible = True
  '    optSortering.Visible = True
  '  Else
  '    _webTillægVises = True
  '    'btnWebTillæg.Text = "Vís Medieplan"
  '    lblMedieplan.Visible = False
  '    chkLinier.Visible = False
  '    optMedieplan.Visible = False
  '    lblBilag.Visible = False
  '    optLæsertal.Visible = False
  '    optPostNr.Visible = False
  '    lblSortering.Visible = False
  '    optSortering.Visible = False
  '  End If
  '  showReport(True)
  'End Sub

  Private Sub frmRapportVisning_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    rpt.Dispose()
    CRViewer.Dispose()
  End Sub
End Class