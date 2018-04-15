Imports System.Text
Imports System.Data.SqlClient

Public Class clsUdsending
  Dim sendHTML As String
  Dim sletHTML As String
  Dim gruppeHTML(25) As String
  Dim i As Integer
  Dim j As Integer
  Const Tr = "<TR>"
  Const rT = "</TR>"
  Const Bo = "<B>"
  Const oB = "</B>"
  Const Br = "<BR>"
  Const tD = "<TD>"
  Const dT = "</TD>"
  Const Fo = "<b><font size=" & """2""" & ">"
  Const oFo = "</font></b>"
  Const beginTable = "<table border=" & """0""" & " cellpadding=" & """0""" & " cellspacing=" & """0""" & " width=" & """100%""" & ">"
  Const endTable = "</table>"
  Const nb = "&nbsp;"
  Dim sendFrom As String

  Public Sub AnnonceOrdre(ByVal medieplanNr As Integer, ByVal version As Integer, ByVal ugeavisID As Integer)
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    'Dim MaterialeNr As String
    'Dim farvepris As Double
    'Dim farverabatpris As Double
    'Dim matgodtpris As Double
    'Dim godtpris As Double
    'Dim sikpris As Double
    'Dim infpris As Double
    'Dim moms As Double
    'Dim momsbeløb As Double
    'Dim mmpris As Double
    'Dim mmrabatpris As Double
    'Dim antalmm As Integer
    'Dim mat50 As Boolean
    'Dim matpris As Double
    'Dim tysk As Double
    'Dim sendPris As String
    'Dim total As Double

    cm.CommandText = "SELECT  MaterialeNr FROM(dbo.tblMedieplanLinjer) WHERE (MedieplanNr = " & medieplanNr & ") AND (Version = " & version & ") AND (UgeavisID = " & ugeavisID
    cm.CommandType = CommandType.Text
    Try
      cn.Open()
      Dim dr As SqlDataReader = cm.ExecuteReader(CommandBehavior.Default)
      dr.Read()
      ''      MaterialeNr = dr("MaterialeNr")
    Catch
    End Try


    sendHTML = sendHTML + "<html><head><title>DLU Ordre Nr.: " & medieplanNr.ToString & "-" & ugeavisID.ToString
    'If gBlade(i).gruppeID > 0 Then
    '  sendHTML = sendHTML + txtPlanId.Text & "-" & gruppeHovedbladID
    'Else
    '  sendHTML = sendHTML + txtPlanId.Text & "-" & gBlade(i).iBladid
    'End If
    sendHTML = sendHTML + "</title></head>"
    sendHTML = sendHTML + "<body>"
    sendHTML = sendHTML + "<Font Size=" & """3""" & ">"
    sendHTML = sendHTML + beginTable
    sendHTML = sendHTML + Tr
    sendHTML = sendHTML + "<td width=" & """33%""" & " align=" & """left""" & ">"
    sendHTML = sendHTML + "<font size=" & """5""" & ">"
    sendHTML = sendHTML + "Annonceordre"
    sendHTML = sendHTML + oB + "</font>" + dT
    sendHTML = sendHTML + "<td width=" & """33%""" & " align=" & """middle""" & ">"
    sendHTML = sendHTML + Bo + "Udsendt : " & oB & Now() & dT
    sendHTML = sendHTML + "<td width=" & """33%""" & " align=" & """right""" & ">"
    'If gBlade(i).gruppeID > 0 Then
    sendHTML = sendHTML + Bo & "Ordrenr.: " & oB & medieplanNr.ToString & "-" & ugeavisID.ToString
    'Else
    'sendHTML = sendHTML + Bo & "Ordrenr.: " & oB & txtPlanId.Text & "-" & gBlade(i).iBladid
    '' If MaterialeNr <> "" Then sendHTML = sendHTML + Br + "Materialenr.: " & MaterialeNr
    '    End If
    sendHTML = sendHTML + dT + rT + endTable
    sendHTML = sendHTML + "<table border=" & """1""" & " cellpadding=" & """5""" & " cellspacing=" & """0""" & " width=" & """100%""" & ">"
    sendHTML = sendHTML + Tr
    sendHTML = sendHTML + "<td width=" & """50%""" & " colspan=" & """2""" & " valign=" & """top""" & ">"
    sendHTML = sendHTML + Fo & "Fra" & oFo & Br & "De Lokale Ugeaviser<br>Strandboulevarden 89 2100 København Ø<br>CVR : 10030749" & dT
    sendHTML = sendHTML + "<td width=" & """50%""" & " colspan=" & """2""" & " valign=" & """top""" & ">"
    sendHTML = sendHTML + Fo + "Alle henvendelser rettes til" & oFo & Br & "Matr./ordre: " & frmMain.BrugerFuldeNavn & " tlf.: " & frmMain.BrugerTlf & Br
    '    sendHTML = sendHTML + "Kundeinfo: " & ctlAnnoncør.SalgsAnsvarlig & " tlf.: " & deDimpDB.rsgetTlfForSalgsansvarlig("Tlf") & dT

  End Sub
End Class
