Imports Infragistics.Win.UltraWinGrid
Imports System.Data.SqlClient
Imports System.Text

Public Class frmUdsending
  Private WithEvents _cfilter As New HeaderCheckBoxCreationFilter

  Private Sub frmUdsending_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.TblUgeaviserTableAdapter.Fill(Me.UgeavisListeDropdown.tblUgeaviser)
    grdBladListe.CreationFilter = _cfilter
    'lblGenudsendelse.Text = "Send Tjeklister for uge " & frmMain.dendeUge + 1
    numUge.Value = frmMain.DenneUge + 1
    numÅr.Value = frmMain.DetteÅr
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.Close()
  End Sub

  Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader
    Dim cn2 As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim ordreCM As SqlCommand = cn2.CreateCommand()
    Dim ordreDR As SqlDataReader
    Dim bladID As Integer
    Dim bladNavn As String
    Dim HTMLTekst As New StringBuilder(1000)
    Dim eMail As String
    Dim SendIndeværendeUge As Boolean
    Dim sendeUge As Integer
    Dim sendeÅr As Integer
    Dim succes As Boolean
    Dim logTekst As String = ""
    Dim first As Boolean

    Me.Cursor = Cursors.WaitCursor
    cm.CommandType = CommandType.Text
    ordreCM.CommandType = CommandType.Text
    cn.Open()

    For Each arow As UltraGridRow In grdBladListe.Rows
      arow.Update()
    Next

    If optUdsendelsesType.CheckedIndex = 0 Then
      For Each arow As UltraGridRow In grdBladListe.Rows
        If arow.Cells("Valgt").Value = True Then
          cm.CommandText = "SELECT OrdrecheckEmail FROM tblBladStamdata WHERE (BladID = " & arow.Cells("BladID").Value & ")"
          If IsDBNull(cm.ExecuteScalar) Then
            eMail = ""
          Else
            eMail = cm.ExecuteScalar()
          End If
          If eMail <> "" Then
            cm.CommandText = "SELECT SendIndeværendeUge FROM tblBladStamdata WHERE (BladID = " & arow.Cells("BladID").Value & ")"
            If IsDBNull(cm.ExecuteScalar()) Then
              SendIndeværendeUge = False
            Else
              SendIndeværendeUge = cm.ExecuteScalar()
            End If
            If SendIndeværendeUge Then
              sendeUge = numUge.Value - 1  'frmMain.DenneUge
            Else
              sendeUge = numUge.Value 'frmMain.DenneUge + 1
            End If
            sendeÅr = numÅr.Value
            cm.CommandText = "SELECT tblMedieplanNr.MedieplanNr, NavisionContact.Name AS Annoncør, tblMedieplan.AntalFarver, LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplanNr.Status > 2) AND (tblMedieplanNr.Status <> 4) AND (tblMedieplan.IndrykningsÅr = " & sendeÅr & ") AND (tblMedieplan.IndrykningsUge = " & sendeUge & ") AND (tblMedieplanLinjer.UgeavisID = " & arow.Cells("BladID").Value & ")"
            first = True
            HTMLTekst.Remove(0, HTMLTekst.Length)
            dr = cm.ExecuteReader(CommandBehavior.Default)
            While dr.Read()
              If first Then
                HTMLTekst.Append("<Table border=""1"" cellpadding=""0"" cellspacing=""0"" width=""90%""><TR><TD Width=""10%""><B>Ordre Nr</B></TD><TD Width=""60%""><B>Annoncør</B></TD><TD Width=""20%""><B>Format</B></TD><TD Width=""10%""><B>Farver</B></TD></TR>")
                first = False
              End If
              HTMLTekst.Append("<TR>")
              HTMLTekst.Append("<TD>" & dr("MedieplanNr").ToString() & "</TD>")
              HTMLTekst.Append("<TD>" & dr("Annoncør") & "</TD>")
              HTMLTekst.Append("<TD align=""right"">" & dr("Format") & "</TD>")
              HTMLTekst.Append("<TD align=""right"">" & dr("AntalFarver") & "</TD>")
              HTMLTekst.Append("</TR>")
            End While
            dr.Close()
            If Not first Then
              HTMLTekst.Append("</TABLE>")
              Dim mail As New clsEmail
              mail.Til = eMail
              mail.Subject = "DLU ordre tjekliste for " & arow.Cells("Navn").Value & " i uge " & sendeUge.ToString
              mail.From = "OrdreUdsending@DeLokaleUgeaviser.dk"
              mail.BodyMappe = "Z:\Forsendelser\Tjeklister\" & sendeUge.ToString
              mail.BodyFilNavn = arow.Cells("Navn").Text & " [" & eMail & "]"
              mail.Body = HTMLTekst.ToString
              succes = mail.Send()
              If succes Then
                logTekst = logTekst + "Tjekliste sendt til " & arow.Cells("Navn").Value & vbCrLf
              Else
                logTekst = logTekst + "Tjekliste ikke sendt til " & arow.Cells("Navn").Value & vbCrLf
              End If
            End If
          Else
            MessageBox.Show("Mangler email for " & arow.Cells("Navn").Value, "Email mangler", MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If
        End If
      Next
      Me.Cursor = Cursors.Default
      MessageBox.Show(logTekst, "Tjeklister sendt", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      sendeUge = numUge.Value
      cn2.Open()
      sendeÅr = numÅr.Value

      For Each arow As UltraGridRow In grdBladListe.Rows
        If arow.Cells("Valgt").Value = True Then
          cm.CommandText = "SELECT BilagsbladeEmail FROM tblBladStamdata WHERE (BladID = " & arow.Cells("BladID").Value & ")"
          If IsDBNull(cm.ExecuteScalar) Then
            eMail = ""
          Else
            eMail = cm.ExecuteScalar()
          End If

          bladID = arow.Cells("BladID").Value
          bladNavn = arow.Cells("Navn").Value
          If eMail <> "" Then
            ordreCM.CommandText = "SELECT CASE WHEN BilagsBladeTil = 1 THEN NavisionContact.Name WHEN BilagsBladeTil = 2 THEN NavisionContact_1.Name WHEN BilagsBladeTil = 3 THEN BilagsBladeTilNavn END AS Navn, CASE WHEN BilagsBladeTil = 1 THEN NavisionContact.Address WHEN BilagsBladeTil = 2 THEN NavisionContact_1.Address WHEN BilagsBladeTil = 3 THEN BilagsBladeTilAdresse END AS Adresse, CASE WHEN BilagsBladeTil = 1 THEN NavisionContact.[Post Code] WHEN BilagsBladeTil = 2 THEN NavisionContact_1.[Post Code] WHEN BilagsBladeTil = 3 THEN BilagsBladeTilPostNr END AS PostNr, CASE WHEN BilagsBladeTil = 1 THEN NavisionContact.City COLLATE Danish_Norwegian_CS_AS WHEN BilagsBladeTil = 2 THEN NavisionContact_1.City WHEN BilagsBladeTil = 3 THEN PostBy END AS PostByen, tblMedieplan.BilagsBladeATT, tblMedieplan.BureauNo_ AS BureauNo, NavisionContact.Name AS Annoncør, tblMedieplan.BilagsBladeTil FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version LEFT OUTER JOIN tblPostNr ON tblMedieplan.BilagsBladeTilPostNr = tblPostNr.PostNr LEFT OUTER JOIN NavisionContact AS NavisionContact_1 ON tblMedieplan.BureauNo_ = NavisionContact_1.No_ LEFT OUTER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplan.IndrykningsUge = " & sendeUge & ") AND (tblMedieplan.IndrykningsÅr = " & sendeÅr & ") AND (tblMedieplan.BilagsBladeTil > - 1) AND (tblMedieplanNr.Status = 3 OR tblMedieplanNr.Status > 4) AND (tblMedieplanLinjer.UgeavisID = " & bladID & ")"
            first = True
            HTMLTekst.Remove(0, HTMLTekst.Length)
            ordreDR = ordreCM.ExecuteReader(CommandBehavior.Default)
            While ordreDR.Read()
              If first Then
                HTMLTekst.Append("<b>" & bladNavn & "<br>")
                HTMLTekst.Append("Bilagsblade i uge " & sendeUge.ToString & " skal sendes til.</b><br><br>")
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
              mail.Subject = bladNavn & ": Bilagsblad reminder for uge " & sendeUge.ToString
              mail.From = "OrdreUdsending@DeLokaleUgeaviser.dk"
              mail.BodyMappe = "Z:\Forsendelser\BilagsBladRemindere\" & sendeÅr.ToString & "\" & sendeUge.ToString
              mail.BodyFilNavn = bladNavn & " [" & eMail & "]"
              mail.Body = HTMLTekst.ToString
              succes = mail.Send()
              If succes Then
                logTekst = logTekst & "Sendt til " & bladNavn & " på eMail " & eMail
              Else
                logTekst = logTekst & "IKKE sendt til " & bladNavn
              End If
            End If
          Else
            MessageBox.Show("Mangler email for " & arow.Cells("Navn").Value, "Email mangler", MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If
        End If
      Next
      Me.Cursor = Cursors.Default
      MessageBox.Show(logTekst, "Remindere sendt", MessageBoxButtons.OK, MessageBoxIcon.Information)
      cn2.Close()
    End If
    ordreCM.Dispose()
    cn2.Dispose()
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    Me.Close()
  End Sub


  Private Sub _cfilter_CheckChanged(ByVal sender As Object, ByVal e As HeaderCheckBoxCreationFilter.HeaderCheckBoxEventArgs) Handles _cfilter.CheckChanged
    If grdBladListe.Selected.Rows.Count > 1 Then
      For Each arow As UltraGridRow In grdBladListe.Selected.Rows
        arow.Cells("Valgt").Value = e.CurrentCheckState
        arow.Update()
      Next
    Else
      For Each arow As UltraGridRow In grdBladListe.Rows
        arow.Cells("Valgt").Value = e.CurrentCheckState
        arow.Update()
      Next
    End If
  End Sub

End Class