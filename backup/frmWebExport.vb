Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports Microsoft.VisualBasic

Public Class frmWebExport

  Private Sub btnSendTilWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendTilWeb.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim cm2 As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader
    Dim dr2 As SqlDataReader
    Dim BladID As Integer
    Dim bladNavn As String
    Dim detteÅr As Integer = frmMain.DetteÅr
    Dim typelist(14) As Integer
    Dim counter As Integer
    Dim prislisteNavn As String
    Dim pris As Double
    Dim huskPris As Double
    Dim farveMin As Double
    Dim farveMax As Double
    Dim farvePris As Double
    Dim antalAviser As Integer
    Dim printFile As New StringBuilder(20000)
    Dim dækning As String
    Dim first As Boolean

    If btnSendTilWeb.Text = "Ok" Then
      Me.Close()
      Exit Sub
    End If

    Cursor = Cursors.WaitCursor
    txtMessages.Text = txtMessages.Text + "Eksporterer data til WEB" & vbCrLf

    cm.CommandType = CommandType.Text
    cm2.CommandType = CommandType.Text
    cm2.CommandText = "SELECT count(*) FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0) AND (VisPåWWW = 1)"
    cn.Open()
    antalAviser = cm2.ExecuteScalar
    pgbEksport.Maximum = antalAviser

    If frmMain.DenneUge < 25 OrElse frmMain.DenneUge > 49 Then
      If frmMain.DenneUge > 49 Then detteÅr = detteÅr + 1
      prislisteNavn = "Hele året"
    Else
      prislisteNavn = "2. Halvår"
    End If
    typelist(1) = 1
    typelist(2) = 2
    typelist(3) = 3
    typelist(4) = 4
    typelist(5) = 5
    typelist(6) = 12
    typelist(7) = 13
    typelist(8) = 15
    typelist(9) = 14
    typelist(10) = 11
    typelist(11) = 1
    typelist(12) = 1
    typelist(13) = 15
    typelist(14) = 18

    cm2.CommandText = "SELECT BladID FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0) AND (VisPåWWW = 1)"
    dr = cm2.ExecuteReader
    txtMessages.Text = String.Format("{0} Exporterer tblPrisEle.csv{1}", txtMessages.Text, vbCrLf)
    Application.DoEvents()

    antalAviser = 0

    While dr.Read
      antalAviser = antalAviser + 1
      pgbEksport.Value = antalAviser
      Application.DoEvents()
      BladID = dr("BladID")
      cm.CommandText = String.Format("SELECT tblBladDækning.PostNr, tblPostNr.PostBy FROM tblBladDækning INNER JOIN tblPostNr ON tblBladDækning.PostNr = tblPostNr.PostNr WHERE(tblBladDækning.BladID = {0}) ORDER BY tblBladDækning.PostNr", BladID)
      dr2 = cm.ExecuteReader
      dækning = ""
      first = True
      While dr2.Read
        If first Then
          dækning = String.Format("{0} {1}", dr2(0), dr2(1))
          first = False
        Else
          dækning = String.Format("{0}, {1} {2}", dækning, dr2(0), dr2(1))
        End If
      End While
      dr2.Close()

      cm.CommandText = String.Format("UPDATE tblBladStamdata SET WWWDækningSomTekst = N'{0}' WHERE (BladID = {1})", dækning, BladID)
      cm.ExecuteNonQuery()

      printFile.Append(BladID.ToString & ";") '     Print #1, BladID & ";";
      For counter = 1 To 14
        If counter < 11 OrElse counter > 12 Then
          cm.CommandText = "SELECT tblPriser.mmPris FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE (tblPriser.BladID = " & BladID & ") AND (tblPriser.År = " & detteÅr & ") AND (tblPriser.PlaceringID = " & typelist(counter) & ") AND (tblPriser.FormatFra < 2) AND (tblPrislister.PrislisteNavn = N'" & prislisteNavn & "')"

          If IsDBNull(cm.ExecuteScalar) Then
            printFile.Append("0")
            If counter = 14 Then
              printFile.AppendLine()
            Else
              printFile.Append(";")
            End If
          Else
            pris = cm.ExecuteScalar
            If counter = 1 Or counter = 10 Then
              huskPris = pris
            Else
              If pris = 0 Then pris = huskPris
            End If
            printFile.Append(pris.ToString("###0.00"))
            If counter = 14 Then
              printFile.AppendLine()
            Else
              printFile.Append(";")
            End If
          End If
        Else
          If counter = 11 Then
            cm.CommandText = "SELECT tblPriser.FarvePris FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE (tblPriser.BladID = " & BladID & ") AND (tblPriser.År = " & detteÅr & ") AND (tblPriser.PlaceringID = 1) AND (tblPriser.FormatFra < 2) AND (tblPrislister.PrislisteNavn = N'" & prislisteNavn & "')"
          Else
            cm.CommandText = "SELECT tblPriser.Farve4Pris FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE (tblPriser.BladID = " & BladID & ") AND (tblPriser.År = " & detteÅr & ") AND (tblPriser.PlaceringID = 1) AND (tblPriser.FormatFra < 2) AND (tblPrislister.PrislisteNavn = N'" & prislisteNavn & "')"
          End If
          If IsDBNull(cm.ExecuteScalar()) Then
            farvePris = 0
          Else
            farvePris = cm.ExecuteScalar
          End If
          If farvePris < 20 Then
            If farvePris > 0 Then
              printFile.Append("+" & farvePris.ToString("###0.00") & "/mm")
              If counter = 11 Then
                cm.CommandText = "SELECT tblPriser.FarveMin FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE (tblPriser.BladID = " & BladID & ") AND (tblPriser.År = " & detteÅr & ") AND (tblPriser.PlaceringID = 1) AND (tblPriser.FormatFra < 2) AND (tblPrislister.PrislisteNavn = N'" & prislisteNavn & "')"
              Else
                cm.CommandText = "SELECT tblPriser.Farve4Min FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE (tblPriser.BladID = " & BladID & ") AND (tblPriser.År = " & detteÅr & ") AND (tblPriser.PlaceringID = 1) AND (tblPriser.FormatFra < 2) AND (tblPrislister.PrislisteNavn = N'" & prislisteNavn & "')"
              End If
              If IsDBNull(cm.ExecuteScalar) Then
                farveMin = 0
              Else
                farveMin = cm.ExecuteScalar
              End If
              If counter = 11 Then
                cm.CommandText = "SELECT tblPriser.FarveMax FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE (tblPriser.BladID = " & BladID & ") AND (tblPriser.År = " & detteÅr & ") AND (tblPriser.PlaceringID = 1) AND (tblPriser.FormatFra < 2) AND (tblPrislister.PrislisteNavn = N'" & prislisteNavn & "')"
              Else
                cm.CommandText = "SELECT tblPriser.Farve4Max FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE (tblPriser.BladID = " & BladID & ") AND (tblPriser.År = " & detteÅr & ") AND (tblPriser.PlaceringID = 1) AND (tblPriser.FormatFra < 2) AND (tblPrislister.PrislisteNavn = N'" & prislisteNavn & "')"
              End If
              If IsDBNull(cm.ExecuteScalar()) Then
                farveMax = 0
              Else
                farveMax = cm.ExecuteScalar
              End If
              If farveMin > 0 Then
                printFile.Append(" (Min. " & farveMin.ToString("#,##0"))
                If farveMax > 0 Then
                  printFile.Append(" Max. " & farveMax.ToString("#,##0") & ");")
                Else
                  printFile.Append(");")
                End If
              ElseIf farveMax > 0 Then
                printFile.Append("(Max. " & farveMax.ToString("#,##0") & ");")
              Else
                printFile.Append(";")
              End If
            Else
              printFile.Append("-;")
            End If
          Else
            printFile.Append(farvePris.ToString("#,##0") & ",-;")
          End If
        End If
      Next counter
    End While
    dr.Close()
    File.WriteAllText("M:\tblPrisEle.csv", printFile.ToString)

    FTPPlanner.Execute("", "cd www", "", "")
    Do Until FTPPlanner.StillExecuting = False
      Application.DoEvents()
    Loop

    FTPPlanner.Execute("", "cd process", "", "")
    Do Until FTPPlanner.StillExecuting = False
      Application.DoEvents()
    Loop

    FTP.Execute("", "put """ & "M:\tblPrisEle.csv" & """ " & "tblPrisEle.csv", "", "")
    Do Until FTP.StillExecuting = False
      Application.DoEvents()
    Loop
    txtMessages.Text = txtMessages.Text & "tblPrisEle.csv er eksporteret til siteworks.." & vbCrLf

    FTPPlanner.Execute("", "put """ & "M:\tblPrisEle.csv" & """ " & "tblPrisEle.csv", "", "")
    Do Until FTPPlanner.StillExecuting = False
      Application.DoEvents()
    Loop
    txtMessages.Text = txtMessages.Text & "tblPrisEle.csv er eksporteret til Planner.." & vbCrLf

    'cm.CommandText = "SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.Adresse, tblBladStamdata.PostNr, tblPostNr.PostBy, tblBladStamdata.Tlf, tblBladStamdata.Fax, tblBladStamdata.OrdreEmail AS Email, tblBladStamdata.Hjemmeside, tblDage.DagNavn, CASE WHEN tblDelOmråde.DelOmrådeKode = 'Y' THEN 'delomraade_fyn' WHEN tblDelOmråde.DelOmrådeKode = 'N' THEN 'delomraade_nord' WHEN tblDelOmråde.DelOmrådeKode = 'S' THEN 'delomraade_syd' WHEN tblDelOmråde.DelOmrådeKode = 'Ø' THEN 'delomraade_ost' WHEN tblDelOmråde.DelOmrådeKode = 'V' THEN 'delomraade_vest' WHEN tblDelOmråde.DelOmrådeKode = 'J' THEN 'delomraade_bornholm' ELSE 'delomraade_' + lower(tblDelOmråde.DelOmrådeKode) END AS delomraade, tblBladStamdata.WWWDækningSomTekst, 0 AS KortNr, tblBladStamdata.Oplag, tblBladStamdata.RedaktionEmail FROM tblPostNr INNER JOIN tblBladStamdata ON tblPostNr.PostNr = tblBladStamdata.PostNr INNER JOIN tblDage ON tblBladStamdata.UgedagID = tblDage.DagID INNER JOIN tblDelOmråde ON tblBladStamdata.DelOmrådeID = tblDelOmråde.DelOmrådeID WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (tblBladStamdata.VisPåWWW = 1)"
    cm.CommandText = "SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.Adresse, tblBladStamdata.PostNr, tblPostNr.PostBy, tblBladStamdata.Tlf, tblBladStamdata.Fax, tblBladStamdata.AnnonceEmail AS Email, tblBladStamdata.Hjemmeside, tblDage.DagNavn, CASE WHEN tblDelOmråde.DelOmrådeKode = 'Y' THEN 'delomraade_fyn' WHEN tblDelOmråde.DelOmrådeKode = 'N' THEN 'delomraade_nord' WHEN tblDelOmråde.DelOmrådeKode = 'S' THEN 'delomraade_syd' WHEN tblDelOmråde.DelOmrådeKode = 'M' THEN 'delomraade_midt' WHEN tblDelOmråde.DelOmrådeKode = 'J' THEN 'delomraade_bornholm' ELSE 'delomraade_' + lower(tblDelOmråde.DelOmrådeKode) END AS delomraade, tblBladStamdata.WWWDækningSomTekst, 0 AS KortNr, tblBladStamdata.Oplag, tblBladStamdata.RedaktionEmail FROM tblPostNr INNER JOIN tblBladStamdata ON tblPostNr.PostNr = tblBladStamdata.PostNr INNER JOIN tblDage ON tblBladStamdata.UgedagID = tblDage.DagID INNER JOIN tblDelOmråde ON tblBladStamdata.DelOmrådeID = tblDelOmråde.DelOmrådeID WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (tblBladStamdata.VisPåWWW = 1)"
    dr = cm.ExecuteReader
    ExportFile(dr, "tblHovedEle.csv")
    dr.Close()

    cm.CommandText = "SELECT BladID, Totalområde, TotalområdePct, 'Kommuner' AS PrimaerKommuner, Primær, PrimærPct FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0) AND (VisPåWWW = 1)"
    dr = cm.ExecuteReader
    ExportFile(dr, "tblLaesertalEle.csv")
    dr.Close()

    cm.CommandText = "SELECT BladID, GruppeRabat, SamannonceringsRabat FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0) AND (VisPåWWW = 1)"
    dr = cm.ExecuteReader
    ExportFile(dr, "tblRabatEle.csv")
    dr.Close()

    cm.CommandText = "SELECT BladID, Kontaktperson, Ejerforhold, Format, '' AS satssted, '' AS tryksted, OrdredeadlineTekst, OrdredeadlineRubrik FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0) AND (VisPåWWW = 1)"
    dr = cm.ExecuteReader
    ExportFile(dr, "tblTekniskEle.csv")
    dr.Close()

    cm.CommandText = "SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.PostNr AS BladPostNr, tblPostNr.PostBy, tblPostNr.PostNr FROM tblBladStamdata INNER JOIN tblBladDækning ON tblBladStamdata.BladID = tblBladDækning.BladID INNER JOIN tblPostNr ON tblBladDækning.PostNr = tblPostNr.PostNr WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (tblBladStamdata.VisPåWWW = 1) AND (tblBladDækning.DækningsGrad >= 80)"
    dr = cm.ExecuteReader
    ExportFile(dr, "PrimaerDaekning.csv")
    dr.Close()

    '    cm.CommandText = "SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.PostNr AS BladPostNr, tblPostNr.PostBy, tblPostNr.PostNr FROM tblBladStamdata INNER JOIN tblBladDækning ON tblBladStamdata.BladID = tblBladDækning.BladID INNER JOIN tblPostNr ON tblBladDækning.PostNr = tblPostNr.PostNr WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (tblBladStamdata.VisPåWWW = 1) AND (tblBladDækning.DækningsGrad < 80)"
    '   dr = cm.ExecuteReader
    '  ExportFile(dr, "SekundaerDaekning.csv")
    ' dr.Close()

    cm.CommandText = "SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.Adresse, tblBladStamdata.PostNr, tblPostNr.PostBy, tblBladStamdata.Tlf, tblBladStamdata.Fax, tblBladStamdata.AnnonceEmail AS Email, tblBladStamdata.Hjemmeside, tblDage.DagNavn, CASE WHEN tblDelOmråde.DelOmrådeKode = 'Y' THEN 'delomraade_fyn' WHEN tblDelOmråde.DelOmrådeKode = 'N' THEN 'delomraade_nord' WHEN tblDelOmråde.DelOmrådeKode = 'S' THEN 'delomraade_syd' WHEN tblDelOmråde.DelOmrådeKode = 'M' THEN 'delomraade_midt' WHEN tblDelOmråde.DelOmrådeKode = 'J' THEN 'delomraade_bornholm' ELSE 'delomraade_' + lower(tblDelOmråde.DelOmrådeKode) END AS delomraade, tblBladStamdata.Oplag, tblBladStamdata.RedaktionEmail, tblBladStamdata.Totalområde, tblBladStamdata.TotalområdePct, 'Kommuner' AS 'Kommuner', tblBladStamdata.Primær, tblBladStamdata.PrimærPct, (SELECT mmPris FROM tblPriser WHERE (PlaceringID = 1) AND (År = YEAR(GETDATE())) AND (PrislisteID = 1) AND (FormatFra < 2) AND (BladID = tblBladStamdata.BladID)) AS TekstPris, (SELECT mmPris FROM tblPriser WHERE (PlaceringID = 11) AND (År = YEAR(GETDATE())) AND (PrislisteID = 1) AND (FormatFra < 2) AND (BladID = tblBladStamdata.BladID)) AS RubrikPris, (SELECT FarvePris FROM tblPriser WHERE (PlaceringID = 1) AND (År = YEAR(GETDATE())) AND (PrislisteID = 1) AND (FormatFra < 2) AND (BladID = tblBladStamdata.BladID)) AS FarvePris, (SELECT Farve4Pris FROM tblPriser WHERE (PlaceringID = 1) AND (År = YEAR(GETDATE())) AND (PrislisteID = 1) AND (FormatFra < 2) AND (BladID = tblBladStamdata.BladID)) AS Farve4Pris, tblBladStamdata.Kontaktperson FROM tblPostNr INNER JOIN tblBladStamdata ON tblPostNr.PostNr = tblBladStamdata.PostNr INNER JOIN tblDage ON tblBladStamdata.UgedagID = tblDage.DagID INNER JOIN tblDelOmråde ON tblBladStamdata.DelOmrådeID = tblDelOmråde.DelOmrådeID WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0)"

    Dim xmlTekst As String = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & "?><root>"
    Dim bladTekst As String = ""
    Dim covered As String = ""

    dr = cm.ExecuteReader
    While dr.Read
      bladNavn = Trim(dr(1))
      bladNavn = bladNavn.Replace("&", "&amp;")
      bladTekst = "<paper id=""" & dr(0) & """ Name=""" & bladNavn & """ adresse=""" & Trim(dr(2)) & """ postnr=""" & dr(3) & """ bynavn=""" & dr(4) & """ telefonnr=""" & Trim(dr(5)) & """ telefax=""" & Trim(dr(6)) & """ email=""" & dr(7) & """ homepage=""" & dr(8) & """ udgivelsesdag=""" & dr(9) & """ delomraade=""" & dr(10) & """ oplag=""" & dr(11) & """ redemail=""" & dr(12) & """ antal_modtager=""" & dr(13) & """ laesedaekning=""" & dr(14) & """ primaerkommuner=""" & dr(15) & """ modtager_pri=""" & dr(16) & """ laesedaekning_pri=""" & dr(17) & """ tekstside=""" & dr(18) & """ rubrik=""" & dr(19) & """ farvetillaeg=""" & dr(20) & """ firefarvetillaeg=""" & dr(21) & """ kontaktper=""" & dr(22) & """ "

      cm2.CommandText = "SELECT PostNr, DækningsGrad FROM tblBladDækning WHERE (BladID = " & dr(0) & ")"
      dr2 = cm2.ExecuteReader()
      covered = "zipsCovered="""
      While dr2.Read
        covered = covered & dr2(0) & "|" & dr2(1) & ","
      End While
      dr2.Close()
      If covered.Length > 13 Then covered = covered.Substring(0, covered.Length - 1) & """/>" & vbCrLf
      xmlTekst = xmlTekst & bladTekst & covered
    End While
    xmlTekst = xmlTekst & "</root>"
    dr.Close()
    File.WriteAllText("M:\bladdata.xml", xmlTekst.ToString)


    FTPPlanner.Execute("", "cd www", "", "")
    Do Until FTPPlanner.StillExecuting = False
      Application.DoEvents()
    Loop

    FTPPlanner.Execute("", "cd process", "", "")
    Do Until FTPPlanner.StillExecuting = False
      Application.DoEvents()
    Loop

    FTPPlanner.Execute("", "put """ & "M:\bladdata.xml" & """ " & "bladdata.xml", "", "")
    Do Until FTPPlanner.StillExecuting = False
      Application.DoEvents()
    Loop
    txtMessages.Text = txtMessages.Text & "bladdata.xml er eksporteret til Planner.." & vbCrLf


    Web.Visible = True
    txtMessages.Text = txtMessages.Text + "Starting PHP engine on the web...." & vbCrLf
    Web.Navigate("http://lokalplanner.dk/loaddatainto.php?action=initial")
    dr.Close()
    cm2.Dispose()
    cm.Dispose()
    cn.Close()
    cn.Dispose()
  End Sub

  Private Sub ExportFile(ByVal dr As SqlDataReader, ByVal tabelNavn As String)
    Dim huskBladId As Integer
    '  Dim kommune As String
    Dim counter As Integer
    Dim PrintStreng As String
    Dim printFile As New StringBuilder(10000)
    Dim antalAviser As Integer = 0

    'On Error GoTo errHandler
    txtMessages.Text = txtMessages.Text + " Exporterer " & tabelNavn & vbCrLf

    FileOpen(1, "M:\" & tabelNavn, OpenMode.Output)

    While dr.Read
      antalAviser = antalAviser + 1
      If antalAviser <= pgbEksport.Maximum Then pgbEksport.Value = antalAviser
      Application.DoEvents()
      For counter = 0 To dr.FieldCount - 1
        PrintStreng = Trim(Replace(dr.GetValue(counter).ToString & "", vbCrLf, ""))
        PrintStreng = Trim(Replace(PrintStreng, vbLf, ""))
        PrintStreng = Replace(PrintStreng, ";", ":") ' Der må ikke være ; i felterne da det bruges som skilletegn
        ' If tabelNavn = "tblLaesertalEle.csv" Then
        'If dr.GetName(counter) = "PrimaerKommuner" Then 'If rs.Fields(counter).name = "PrimaerKommuner" Then
        '  deDimpDB.getPrimaerKommuner(huskBladId)
        '  kommune = ""
        '  While Not deDimpDB.rsgetPrimaerKommuner.EOF
        '    kommune = kommune + Trim(deDimpDB.rsgetPrimaerKommuner("Kommune")) + ", "
        '    deDimpDB.rsgetPrimaerKommuner.MoveNext()
        '  End While
        '  If kommune = "" Then Err.Raise(vbObjectError + 2, , "Der er ikke afkrydset nogen" & vbCrLf & "Primærkommune i kommuneboksen. For bladid = " & huskBladId)
        '  kommune = Left(kommune, Len(kommune) - 2)
        '  kommune = Replace(kommune, "(dele af)", " ")
        '  Print #1, Trim(kommune & ";");
        '  deDimpDB.rsgetPrimaerKommuner.Close()
        'ElseIf rs.Fields(counter).name = "BladId" Then
        '  huskBladId = rs.Fields(counter).Value
        '  Print #1, PrintStreng & ";";
        'Else
        '  Print #1, PrintStreng;
        '  If counter < rs.Fields.count - 1 Then Print #1, ";";
        'End If
        'Else
        If tabelNavn = "tblHovedEle.csv" Then
          If dr.GetName(counter) = "Email" Then 'If rs.Fields(counter).name = "Email" Then
            Print(1, PrintStreng & ";")
          ElseIf dr.GetName(counter) = "BladID" Then 'ElseIf rs.Fields(counter).name = "BladId" Then
            huskBladId = dr.GetValue(counter) 'rs.Fields(counter).Value
            Print(1, PrintStreng & ";")
          Else
            Print(1, PrintStreng)
            If counter < dr.FieldCount - 1 Then Print(1, ";") 'printFile.Append(";") 'If counter < rs.Fields.count - 1 Then Print #1, ";";

          End If
        Else
          Print(1, PrintStreng)
          If counter < dr.FieldCount - 1 Then Print(1, ";") ' printFile.Append(";") 'If counter < rs.Fields.count - 1 Then Print #1, ";";
        End If
      Next counter
      PrintLine(1)
    End While

    Print(1, printFile.ToString())
    FileClose(1)

    If tabelNavn.StartsWith("tbl") Then
      FTP.Execute("", "put """ & "M:\" & tabelNavn & """ " & tabelNavn, "", "")
      Do Until FTP.StillExecuting = False
        Application.DoEvents()
      Loop
      txtMessages.Text = txtMessages.Text + tabelNavn & " er eksporteret til siteworks.." & vbCrLf
    End If

    FTPPlanner.Execute("", "put """ & "M:\" & tabelNavn & """ " & tabelNavn, "", "")
    Do Until FTPPlanner.StillExecuting = False
      Application.DoEvents()
    Loop
    txtMessages.Text = txtMessages.Text + tabelNavn & " er eksporteret til Planner.." & vbCrLf
  End Sub

  Private Sub Web_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles Web.Navigated
    txtMessages.Text = txtMessages.Text + "Data indlæst via PHP-engine....." & vbCrLf & vbCrLf & "Eksport er fuldført..."
    Me.Text = "Eksport er fuldført"
    btnSendTilWeb.Text = "Ok"
    pgbEksport.Value = 0
    Cursor = Cursors.Default
  End Sub
End Class