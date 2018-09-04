Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.Shared

Public Class frmPrintRapport
  Friend WithEvents Bilag As FakturaBilagInclAnnoncekontrolFejl
  Friend WithEvents Bilag2 As FakturaBilag2InclAnnoncekontrolFejl
  'Friend WithEvents webTillægBilag As WebtillægBilag
  Friend WithEvents rpt As ReportClass
  'Friend WithEvents webrpt As ReportClass
  Private _medieplanNr As Integer
  Private _version As Integer

  Private Sub frmPrintRapport_Load ( ByVal sender As Object , _
                                     ByVal e As EventArgs ) Handles Me.Load
    _medieplanNr = CInt(My.Application.CommandLineArgs(0))
    _version = CInt(My.Application.CommandLineArgs(1))
    If _medieplanNr = 0 Or _version = 0 Then
      Dim _dialogResult As DialogResult = MessageBox.Show("Parameterfejl!! Ingen udskrift!!", "Fejl!!", MessageBoxButtons.OK)
      slutTimer.Enabled = True
    Else
      startTimer.Enabled = True
    End If
  End Sub

  Private Sub showReport()
    Dim cn As New SqlConnection ( My.Settings.DiMPdotNetConnectionString )
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim bilagsType As Integer

    cm.CommandType = CommandType.Text
    cm.CommandText = _
      "SELECT NavisionContact.[Invoice Document Type] FROM tblMedieplan INNER JOIN NavisionContact ON tblMedieplan.BureauNo_ = NavisionContact.No_ WHERE (tblMedieplan.MedieplanNr = " & _medieplanNr & ") AND (tblMedieplan.Version = " & _version & ")"
    cn.Open()
    bilagsType = CInt ( cm.ExecuteScalar() )
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    If bilagsType = 0 Then
      rpt = New FakturaBilagInclAnnoncekontrolFejl
    Else
      rpt = New FakturaBilag2InclAnnoncekontrolFejl
    End If
    If rpt IsNot Nothing Then
      rpt.SetDatabaseLogon("LocalPlanner", "lp4DLU")
      rpt.SetParameterValue ( "MedieplanNrParam" , _medieplanNr )
      rpt.SetParameterValue ( "VersionParam" , _version )
      rpt.PrintOptions.PaperOrientation = PaperOrientation.Landscape
      '   rpt.PrintOptions.PaperSource = PaperSource.Lower
      '    If Not withLogo Then
      '      rpt.ReportDefinition.ReportObjects.Item("picLogo").ObjectFormat.EnableSuppress = True
      '    Else
      '      rpt.ReportDefinition.ReportObjects.Item("picLogo").ObjectFormat.EnableSuppress = False
      '    End If
      '    Dim _sortFieldGeo As FieldDefinition = rpt.Database.Tables.Item("tblGeoKode").Fields.Item("GeoKodeSortKey")
      '    Dim _sortFieldNavn As FieldDefinition = rpt.Database.Tables.Item("tblBladStamdata").Fields.Item("Navn")
      '    rpt.DataDefinition.SortFields.Reset()
      '    If optSortering.CheckedIndex = 0 Then
      '      rpt.DataDefinition.SortFields.Item(0).Field = _sortFieldNavn
      '    Else
      '      rpt.DataDefinition.SortFields.Item(0).Field = _sortFieldGeo
      '      rpt.DataDefinition.SortFields.Item(1).Field = _sortFieldNavn
      '    End If
      '    Me.Text = "U: " & getMedieplanString(_medieplanNr, _version)
      crViewer.ReportSource = rpt
      crViewer.Zoom ( 2 )
      '  crViewer.PrintReport()
      rpt.PrintToPrinter(1, False, 1, 10)
      rpt.Close()
      'bilagTimer.Enabled = True
      slutTimer.Enabled = True
    End If
  End Sub

  Private Sub startTimer_Tick ( ByVal sender As Object , ByVal e As EventArgs ) _
    Handles startTimer.Tick
    startTimer.Enabled = False
    showReport()
  End Sub

  Private Sub slutTimer_Tick ( ByVal sender As Object , ByVal e As EventArgs ) _
    Handles slutTimer.Tick
    slutTimer.Enabled = False
    Application.Exit()
  End Sub

  'Private Sub bilagTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) _
  '  'Handles bilagTimer.Tick
  '  'webrpt = New WebtillægBilag
  '  'webrpt.SetDatabaseLogon ( "sa" , "hydeliFyt12" )
  '  'webrpt.SetParameterValue ( "MedieplanNrParam" , _medieplanNr )
  '  'webrpt.SetParameterValue ( "VersionParam" , _version )
  '  'webrpt.PrintOptions.PaperOrientation = PaperOrientation.Landscape
  '  'crViewer.ReportSource = webrpt
  '  'crViewer.Zoom ( 2 )
  '  ''  crViewer.PrintReport()
  '  'webrpt.PrintToPrinter ( 1 , False , 0 , 0 )
  '  'slutTimer.Enabled = True
  'End Sub

End Class
