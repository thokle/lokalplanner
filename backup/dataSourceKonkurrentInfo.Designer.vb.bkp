Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win
Imports System.Data.SqlClient

Partial Class dataSourceKonkurrentInfo
  Inherits UltraDataSource

#Region " Required code"
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
#End Region

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



  Private Sub InitSchema()
    MyBase.Band.Key = "KonkurrentLinjer"
    With MyBase.Band.Columns
      .Add("RowID", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
      .Add("Ugeavis", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("PostNr", GetType(String)).AllowDBNull = DefaultableBoolean.False
      .Add("Husstande", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
      .Add("DLU", GetType(Integer)).AllowDBNull = DefaultableBoolean.False
    End With
  End Sub

  Friend Sub AddColumns()
    For Each Konkurrent As KonkurrentData In KonkurrentDataListe
      MyBase.Band.Columns.Add(Konkurrent.KonkurrentKode, GetType(Integer)).AllowDBNull = DefaultableBoolean.True
    Next
  End Sub

  Public Function LoadData(ByVal rapportType As Integer, ByVal UgeavisIDListe As String, ByVal MedtagAlle As Boolean, ByVal VisOplag As Boolean) As Boolean
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim RowID As Integer
    Dim Ugeavis As String = ""
    Dim PostNr As String = ""
    Dim Husstande As Integer
    Dim DLU As Integer

    Dim SQLTekst As String = ""
    Dim UgeavisID() As String = Split(UgeavisIDListe, ";")

    If rapportType = 0 Then
      SQLTekst = "SELECT tblPostNr.PostNr, tblPostNr.PostBy, tblPostNr.Husstande, MAX(tblBladDækning."
      If VisOplag Then
        SQLTekst = SQLTekst & "DækningsGrad"
      Else
        SQLTekst = SQLTekst & "Oplag"
      End If
      SQLTekst = SQLTekst & ") AS DLU"
      For Each Konkurrent As KonkurrentData In KonkurrentDataListe
        SQLTekst = SQLTekst & ", (SELECT "
        If VisOplag Then
          SQLTekst = SQLTekst & "DækningsGrad "
        Else
          SQLTekst = SQLTekst & "Oplag "
        End If
        SQLTekst = SQLTekst & "FROM tblKonkurrentDækning WHERE (KonkurrentID = " & Konkurrent.KonkurrentID & ") AND (PostNr = tblPostNr.PostNr)) AS " & Konkurrent.KonkurrentKode
      Next
      SQLTekst = SQLTekst & " FROM tblPostNr INNER JOIN tblBladDækning ON tblPostNr.PostNr = tblBladDækning.PostNr WHERE ("
      For Each ID As String In UgeavisID
        SQLTekst = SQLTekst & "tblBladDækning.BladID = " & Trim(ID) & " OR "
      Next
      SQLTekst = SQLTekst.Substring(0, SQLTekst.Length - 4)
      SQLTekst = SQLTekst & ") GROUP BY tblPostNr.PostNr, tblPostNr.Husstande, tblPostNr.PostBy ORDER BY tblPostNr.PostNr"
    ElseIf rapportType = 1 Then
      SQLTekst = "SELECT tblBladStamdata.Navn, SUM(DLUDækning.Oplag) AS DLU"
      For Each Konkurrent As KonkurrentData In KonkurrentDataListe
        SQLTekst = SQLTekst & ", (SELECT SUM(tblKonkurrentDækning.Oplag) AS EXPR1 FROM tblKonkurrentDækning INNER JOIN tblBladDækning ON tblKonkurrentDækning.PostNr = tblBladDækning.PostNr WHERE "
        If Not MedtagAlle Then SQLTekst = SQLTekst & "(tblBladDækning.DækningsGrad >= 80) AND "
        SQLTekst = SQLTekst & "(tblKonkurrentDækning.KonkurrentID = " & Konkurrent.KonkurrentID & ") AND (tblBladDækning.BladID = tblBladStamdata.BladID)) AS " & Konkurrent.KonkurrentKode
      Next
      SQLTekst = SQLTekst & " FROM tblBladDækning AS DLUDækning INNER JOIN tblBladStamdata ON DLUDækning.BladID = tblBladStamdata.BladID WHERE "
      If MedtagAlle Then
        SQLTekst = SQLTekst & "("
      Else
        SQLTekst = SQLTekst & "(DLUDækning.DækningsGrad >= 80) AND ("
      End If
      For Each ID As String In UgeavisID
        SQLTekst = SQLTekst & "DLUDækning.BladID = " & Trim(ID) & " OR "
      Next
      SQLTekst = SQLTekst.Substring(0, SQLTekst.Length - 4)
      SQLTekst = SQLTekst & ") GROUP BY tblBladStamdata.Navn, tblBladStamdata.BladID ORDER BY tblBladStamdata.Navn"

    ElseIf rapportType = 2 Then
      SQLTekst = "SELECT tblBladStamdata.Navn, tblBladDækning.PostNr, tblPostNr.PostBy, tblPostNr.Husstande, tblBladDækning."
      If VisOplag Then
        SQLTekst = SQLTekst & "DækningsGrad "
      Else
        SQLTekst = SQLTekst & "Oplag "
      End If
      SQLTekst = SQLTekst & "AS DLU"
      For Each Konkurrent As KonkurrentData In KonkurrentDataListe
        SQLTekst = SQLTekst & ", (SELECT "
        If VisOplag Then
          SQLTekst = SQLTekst & "DækningsGrad "
        Else
          SQLTekst = SQLTekst & "Oplag "
        End If
        SQLTekst = SQLTekst & "FROM tblKonkurrentDækning WHERE (KonkurrentID = " & Konkurrent.KonkurrentID & ") AND (PostNr = tblPostNr.PostNr)) AS " & Konkurrent.KonkurrentKode
      Next
      SQLTekst = SQLTekst & " FROM tblBladDækning INNER JOIN tblBladStamdata ON tblBladDækning.BladID = tblBladStamdata.BladID INNER JOIN tblPostNr ON tblBladDækning.PostNr = tblPostNr.PostNr WHERE ("
      For Each ID As String In UgeavisID
        SQLTekst = SQLTekst & "tblBladDækning.BladID = " & Trim(ID) & " OR "
      Next
      SQLTekst = SQLTekst.Substring(0, SQLTekst.Length - 4)
      SQLTekst = SQLTekst & ") ORDER BY tblBladStamdata.Navn, tblPostNr.PostNr"

    End If

    cm.CommandText = SQLTekst

    cm.CommandType = CommandType.Text
    MyBase.SuspendBindingNotifications()
    Try
      MyBase.Rows.Clear()
      cn.Open()
      Dim dr As SqlDataReader = cm.ExecuteReader(CommandBehavior.Default)
      Dim rowCount As Integer = 0
      While dr.Read
        rowCount += 1
        RowID = rowCount
        If rapportType = 0 Then
          Ugeavis = ""
          PostNr = dr("PostNr") & " " & dr("PostBy")
          Husstande = dr("Husstande")
        ElseIf rapportType = 1 Then
          Ugeavis = dr("Navn")
          PostNr = ""
          Husstande = 0
        ElseIf rapportType = 2 Then
          Ugeavis = dr("Navn")
          PostNr = dr("PostNr") & " " & dr("PostBy")
          Husstande = dr("Husstande")
        End If
        DLU = dr("DLU")

        Dim newRow As UltraDataRow = MyBase.Rows.Add(New Object() {RowID, Ugeavis, PostNr, Husstande, DLU})
        For Each Konkurrent As KonkurrentData In KonkurrentDataListe
          newRow(Konkurrent.KonkurrentKode) = dr(Konkurrent.KonkurrentKode)
        Next
      End While
      dr.Close()
      MyBase.Rows.SetCount(rowCount)
    Catch e As Exception
      Return False
    Finally
      cn.Close()
      cn.Dispose()
      MyBase.ResumeBindingNotifications()
    End Try
    Return True
  End Function



End Class