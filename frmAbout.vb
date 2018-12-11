Imports System.Data.SqlClient
Imports System.Text
Imports System.IO


Public NotInheritable Class frmAbout

  Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    ' Set the title of the form.
    Dim ApplicationTitle As String
    If My.Application.Info.Title <> "" Then
      ApplicationTitle = My.Application.Info.Title
    Else
      ApplicationTitle = Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
    End If
    Me.Text = String.Format("Om {0}", ApplicationTitle)
    ' Initialize all of the text displayed on the About Box.
    ' TODO: Customize the application's assembly information in the "Application" pane of the project 
    '    properties dialog (under the "Project" menu).
    Me.LabelProductName.Text = My.Application.Info.ProductName
    Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    '  Me.LabelVersion.Text = System.String.Format(LabelVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
    ' Me.LabelVersion.Text = "05:07:18:2008"
    Me.LabelCopyright.Text = My.Application.Info.Copyright
    ' Me.LabelCompanyName.Text = My.Application.Info.CompanyName
    Me.TextBoxDescription.Text = My.Application.Info.Description
  End Sub

  Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
    Me.Close()
  End Sub

  Private Sub Deadlines()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader
    Dim BladID As Integer
    Dim BladNavn As String
    Dim eMail As String
    Dim sendHTML As String
    Dim queryStr As String

    cm.CommandType = CommandType.Text
    'cm.CommandText = "SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.StamdataEmail FROM tblBladStamdata INNER JOIN tblFarveTillægWebApp ON tblBladStamdata.BladID = tblFarveTillægWebApp.BladID WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0)" Mangler farvetillægwebapp parameter

    pgbBlade.Visible = True
    cm.CommandText = "SELECT DISTINCT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.StamdataEmail FROM tblBladStamdata LEFT OUTER JOIN dimpSQL.dbo.tblWEBUdgivelse ON tblBladStamdata.BladID = dimpSQL.dbo.tblWEBUdgivelse.BladID WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (dimpSQL.dbo.tblWEBUdgivelse.BladID IS NULL)"
    cn.Open()
    dr = cm.ExecuteReader
    While dr.Read
      pgbBlade.Value = pgbBlade.Value + 1
            Application.DoEvents()
            BladID = dr("BladID")
            BladNavn = dr("Navn")
            eMail = dr("StamdataEmail")
            If eMail.Length > 0 Then
                Dim mail As New clsEmail
                'VIGTIGT !!
                'VIGTIGT !!
                'HUSK AT SKIFTE LINK AFHÆNGIG AF OM DET ER HELLIGDAGE ELLER "NORMALE" DEADLINES
                'HUSK AT SKIFTE MAPPEN HVOR UDSENDELSERNE GEMMES

                mail.Subject = "RYKKER!! Deadlines for udgivelser omkring forårets helligdage 2018"
                'mail.Subject = "Vigtigt!! Opdatering af generelle Deadlines til DLU."
                mail.Til = eMail
                mail.BodyTitle = "Deadlines for udgivelser omkring forårets helligdage 2018"
                'mail.BodyTitle = "Deadlines til DLU."
                sendHTML = "<h2>Deadlines for udgivelser omkring forårets helligdage 2018.</h2>"
                sendHTML = sendHTML + "<b>Uge 17+18</b> St. Bededag - <b>Uge 19+20</b> - Kr. Himmelfart - <b>Uge 21</b> pinse<br><br>"
                '  sendHTML = sendHTML + "Vi har desværre endnu ikke modtaget din indtastning af ordre- og materiale deadlines for påske og helligdage 2018 – så indtast venligst senest <b>mandag d. 19. februar kl. 12.00</b>, tak.<br><br>"
                sendHTML = sendHTML + "Vi har brug for din indtastning af ordre- og materiale deadlines for helligdage 2018 – så indtast venligst <b>senest onsdag d. 4. april kl. 12.00</b>, tak.<br><br>"
                sendHTML = sendHTML + "En samlet oversigt på deadlines for påske og helligdage 2018 lægges på vores hjemmeside og bliver samtidig sendt til mediebureauerne.<br><br>"
                sendHTML = sendHTML + "Klik ind på nedenstående link og <b>husk at opdatere</b> for afslutning, så sendes dine indtastninger direkte til os.<br><br>"
                sendHTML = sendHTML + "<b>Uge 17+18</b> St. Bededag - <b>Uge 19+20</b> - Kr. Himmelfart - <b>Uge 21</b> pinse<br><br>"
                'sendHTML = sendHTML + "<b>Alle ugerne fra påsken i uge 15 til og med 2. pinsedag i uge 23 skal udfyldes – også selvom<br>"


                'Rykker
                'sendHTML = sendHTML + "Vi har endnu ikke modtaget deadlines fra jeres blad omkring julen 2016.<br>"
                '  sendHTML = sendHTML + "Hvis årsagen til manglende svar skyldes I ikke har oplysningerne endnu, må I meget skrive hvornår<br> det forventes afklaret til lvl@delokaleugeaviser.dk, mange tak.<br>"
                'sendHTML = sendHTML + "<b>Fra påsken i uge 15-2017 frem til pinsen i uge 23-2017.</b><br><br>"

                '    sendHTML = "<h2>Generelle deadlines for ordrer og annoncemateriale</h2>"
                '  sendHTML = sendHTML + "Vi har endnu ikke modtaget deadlines fra jeres avis.<br><br>"
                '   sendHTML = sendHTML + "Kære " & BladNavn & "<br><br>"
                '  sendHTML = sendHTML + "Vi vil meget gerne sikre, at vi har de korrekte deadlines for modtagelse<br>af ordrer og annoncemateriale registreret i vores ordresystem.<br><br>"
                ' sendHTML = sendHTML + "Det er oplysninger, som vi bruger hele tiden i dialogen med kunder, reklame-<br>og mediebureauer og det er derfor meget vigtigt, at de altid er opdaterede.<br><br>"
                ' sendHTML = sendHTML + "I bedes venligst melde de officielle deadlines ind for hhv. <b>annonceordrer</b><br>og <b>annoncemateriale</b> via nedenstående link.<br><br>"
                'sendHTML = sendHTML + "Skemaet udfyldes ved at vælge <b>ugedag</b> og <b>tidspunkt</b> i ""rullegardinerne"":<br><br>"


                'sendHTML = sendHTML + "Benyt nedenstående link og angiv uger og ændringer i deadlines, i forbindelse med de nævnte helligdage.<br><br>"
                'sendHTML = sendHTML + "<b>Klik på linket herunder og udfyld skemaet:</b><br><br>"


                'sendHTML = sendHTML + "1) Vælg udgivelses ugen i rullegardinet.<br>"
                '   sendHTML = sendHTML + "<b>Alle ugerne fra påske til og med 2. pinsedag i uge 20 skal udfyldes – også selvom der ikke er ændringer i forhold til den normale deadline.</b><br>"
                'sendHTML = sendHTML + "2) <i><b>Hvis</b></i> avisen ikke udkommer markeres dette i afkrydsningsfeltet.<br>"
                'sendHTML = sendHTML + "<small>(De resterende felter for ugen deaktiveres)</small><br>"
                'sendHTML = sendHTML + "3) Ellers - vælg dato for udgivelsesdag i rullegardinet.<br>"
                'sendHTML = sendHTML + "4) vælg dato for deadline for annoncer i rullegardinet.<br>"
                'sendHTML = sendHTML + "5) vælg dato for deadline for materiale i rullegardinet.<br><br>"
                'sendHTML = sendHTML + "1) Ordre deadline for <I>Tekstside annoncer</I><br>"
                'sendHTML = sendHTML + "2) Materiale deadline for <I>Tekstside materiale</I><br>"
                'sendHTML = sendHTML + "3) Ordre deadline for <I>Rubrik annoncer</I><br>"
                'sendHTML = sendHTML + "4) Materiale deadline for <I>Rubrik materiale</I><br><br>"
                'sendHTML = sendHTML + "Afslut med tryk på ""Opdater"" og dine indtastninger sendes automatisk til De Lokale Ugeaviser.<br><br>"
                'sendHTML = sendHTML + "Vi vil gerne bede om at få udfyldt skemaet senest <b><u>onsdag den 28. juni 2017.</u></b><br><br>"

                'VIGTIGT !!
                'VIGTIGT !!
                'HUSK AT SKIFTE LINK AFHÆNGIG AF OM DET ER HELLIGDAGE ELLER "NORMALE" DEADLINES
                'Deadline ændres til Deadline2 hvis det er "Normale"
                queryStr = "http://www.DiMP.dk/Deadline.aspx?Query=" & BladID.ToString & "*" & BeregnWebChecksum(BladNavn)
                ' sendHTML = sendHTML + "<h4>Alternativt Link:</h4>"
                ' sendHTML = sendHTML + "<small>Prøv dette link, hvis ikke det første virker.</small><br>"
                ' sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">Klik på dette Link.</A><br><br>"
                ' sendHTML = sendHTML + "<b><i>Hvis du ikke kan komme ind på siden, eller den melder en fejl, så læs dette:</i></b><br>"
                ' sendHTML = sendHTML + "Oversigten over deadlines vil blive sendt til mediebureauerne og lagt ud på vores hjemmeside.<br><br>"
                'sendHTML = sendHTML + "http://www.DiMP.dk/OrdreApp/mmPriser.aspx?Query=" & BladID.ToString & "*" & BeregnWebChecksum(BladNavn) & "*0"
                sendHTML = sendHTML + "Har du spørgsmål, er du velkommen til at kontakte mig på tlf. 3525 9589 eller mail: lej@delokaleugeaviser.dk<br><br>"
                sendHTML = sendHTML + "<i><b>Dine oplysninger er vigtige, for vores kunder er afhængige af dem!</b></i><br><br>"
                sendHTML = sendHTML + "På forhånd tak.<br><br>Med venlig hilsen<br><br>Lone Ek Jensen<br>De Lokale Ugeaviser<br><br>"
                sendHTML = sendHTML + "<br><h3>Link:</h3>"
                sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">Klik på dette Link for at angive deadlines</A><br>"
                mail.Body = sendHTML 'convertDanishHTML(sendHTML)
                'HUSK AT SKIFTE MAPPEN HVOR UDSENDELSERNE GEMMES    FORMATET ER EN RYKKER UNDERMAPPE
                mail.BodyMappe = "Z:\Forsendelser\Deadlines\Påske 2018\Helligdage\Rykker"
                mail.BodyFilNavn = Trim(BladNavn) & " [" & eMail & "]"
                mail.From = "lej@delokaleugeaviser.dk"
                mail.Send()
            End If
    End While
    dr.Close()
    cn.Close()
    cm.Dispose()
    cn.Dispose()
  End Sub

  Private Sub sendPrimærOmråder()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader
    Dim BladID As Integer
    Dim BladNavn As String
    Dim eMail As String
    Dim sendHTML As String
    Dim queryStr As String

    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT tblBlade.BladId, tblBlade.Navn, tblBlade.ForsendelsesEmail FROM tblBlade"
    cn.Open()
    dr = cm.ExecuteReader
    While dr.Read
      BladID = dr("BladID")
      BladNavn = dr("Navn")
      eMail = dr("ForsendelsesEmail")
      If eMail.Length > 0 Then
        Dim mail As New clsEmail

        mail.Subject = BladNavn & " Primære dækningsområder 2011"
        mail.Til = eMail
        mail.BodyTitle = "Primære dækningsområder for " & BladNavn & " 2011."
        sendHTML = "<h3>Primære dækningsområder 2011 for " & BladNavn & ".</h3>"
        sendHTML = sendHTML + "I forbindelse med læsertallene for 2010 vil vi bede dig, via medfølgende link,<br>"
        sendHTML = sendHTML + "at indtaste det eller de postnumre, som for jer er de primære postnumre, i jeres dækningsområde.<br>"
        sendHTML = sendHTML + "Det kan enten være ud fra et dækningsmæssigt eller redaktionelt synspunkt.<br><br>"
        sendHTML = sendHTML + "Vær opmærksom på at jo mindre det primære dækningsområde er - desto større er muligheden,<br>"
        sendHTML = sendHTML + "for en stor usikkerhed i læsertallet.<br><br>"
        sendHTML = sendHTML + "Du bedes indtaste det primære dækningsområde senest d. 14. januar 2011.<br>"

        sendHTML = sendHTML + "<br><h3>Link:</h3>"
        queryStr = "http://www.DiMP.dk/PrimaerOmraader.aspx?BladID=" & BladID.ToString & "&Chk=" & BeregnWebChecksum(BladNavn)
        sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">Klik på dette Link.</A><br>"
        sendHTML = sendHTML + "<h4>Alternativt Link:</h4>"
        sendHTML = sendHTML + "<small>Prøv dette link, hvis ikke det første virker.</small><br>"
        sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">" & queryStr & "</A><br><br>"
        sendHTML = sendHTML + "<b><i>Hvis du ikke kan komme ind på siden, eller den melder en fejl, så læs dette:</i></b><br>"
        sendHTML = sendHTML + "Kopier linjen herunder og indsæt det i adresselinjen på din browser.<br><br>"
        sendHTML = sendHTML + "http://www.DiMP.dk/PrimaerOmraader.aspx?BladID=" & BladID.ToString & "&Chk=" & BeregnWebChecksum(BladNavn)

        mail.Body = sendHTML 'convertDanishHTML(sendHTML)
        mail.BodyMappe = "Z:\Forsendelser\Dækning"
        mail.BodyFilNavn = BladNavn & " [" & eMail & "]"
        mail.From = "nr@delokaleugeaviser.dk"
        mail.Send()
      End If
    End While
    dr.Close()
    cn.Close()
    cm.Dispose()
    cn.Dispose()
  End Sub


  Private Sub NyePriser()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader
    Dim BladID As Integer
    Dim BladNavn As String
    Dim eMail As String
    Dim sendHTML As String
    Dim queryStr As String
    pgbBlade.Visible = True
    Me.Cursor = Cursors.WaitCursor

    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT Count(*) AS AntalAviser FROM tblBladStamdata INNER JOIN tblFarveTillægWebApp ON tblBladStamdata.BladID = tblFarveTillægWebApp.BladID WHERE (tblFarveTillægWebApp.Godkendt = 0) AND (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (tblBladStamdata.BladID <> 406)"
    cn.Open()

    pgbBlade.Maximum = cm.ExecuteScalar + 1
    pgbBlade.Value = pgbBlade.Minimum

    cm.CommandText = "SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.StamdataEmail FROM tblBladStamdata INNER JOIN tblFarveTillægWebApp ON tblBladStamdata.BladID = tblFarveTillægWebApp.BladID WHERE (tblFarveTillægWebApp.Godkendt = 0) AND (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (tblBladStamdata.BladID <> 406)"
    dr = cm.ExecuteReader
    While dr.Read
      pgbBlade.Value = pgbBlade.Value + 1
      Application.DoEvents()
      BladID = dr("BladID")
      BladNavn = dr("Navn")
      eMail = dr("StamdataEmail")
      If eMail.Length > 0 Then
        Dim mail As New clsEmail
        '!!VIGTIGT !!
        'HUSK AT KØRE OPDATERING PÅ tblFarveTillægWebApp, SÅ EVT. NYE BLADID ER OPDATERET!!
        '!!VIGTIGT!!
                mail.Subject = "Prisopdatering pr. 1. januar 2019. " & BladNavn
        mail.Til = eMail
                mail.BodyTitle = "Prisopdatering pr. 1. januar 2019.9."
                sendHTML = "<h3>Prisopdatering pr. 1. januar 2019.</h3>"

                sendHTML = sendHTML + "Vi har endnu ikke modtaget priser pr. 1/1 2019 fra jeres blad.<br><br>"
                sendHTML = sendHTML + "For at ændre priser, skal I benytte linket nederst i denne mail.<br><br>"

        'sendHTML = sendHTML + "Kære alle."
        'sendHTML = sendHTML + "Som nogen af jer har opdaget, er fristen på den tidligere mail forkert.<br>Vi beklager fejlen.<br><br>"
        'sendHTML = sendHTML + "Grundet bureauernes meget stor efterspørgsel på priser pr. 1.januar 2014,<br>skal vi derfor bede dig om at indtaste disse allerede i dag."
                sendHTML = sendHTML + "De nævnte priser er de p.t. gældende mm-priser og såfremt der ikke er nogen ændringer (priser, farvetillæg) skal I derfor blot godkende disse.</b></u><br><br>"

                sendHTML = sendHTML + "Indtast venligst priserne <b><u>senest onsdag d. 21 november 2018.</u></b><br><br>"
                sendHTML = sendHTML + "Det er vigtigt at pointere, at eventuelle prisændringer skal lægges ind via linket.<br><br>"
        '       sendHTML = sendHTML + "Der må kun bruges kommatal i priserne, hvis der er min/max priser for farver, skal dette være heltal.<br><br>"
                sendHTML = sendHTML + "<b>Det er altså ikke nok at sende en e-mail med priser/ændringer til DLU.</B><br><br>"

                '  sendHTML = sendHTML + "<h3>OBS	OBS	Sommerpriser</h3>"
                ' sendHTML = sendHTML + "Hvis der er forhøjede priser i sommerperioden skal disse indberettes manuelt<br>i en excel fil på mail til lej@delokaleugeaviser.dk<br><br>"
        '  sendHTML = sendHTML + "Har I endnu ikke de nye priser så meld venligst tilbage på lej@delokaleugeaviser.dk<br><br>"

                sendHTML = sendHTML + "På forhånd tak<br>tlf: 35 25 95 89<br><br>"
                sendHTML = sendHTML + "Lars Jensen<br><br>"


        sendHTML = sendHTML + "<br><h3>Link:</h3>"
        queryStr = "http://www.DiMP.dk/mmPriser.aspx?Query=" & BladID.ToString & "*" & BeregnWebChecksum(BladNavn) & "*0"
        '  sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">" & queryStr & "</A><br>"
        ' sendHTML = sendHTML + "<h4>Alternativt Link:</h4>"
        'sendHTML = sendHTML + "<small>Prøv dette link, hvis ikke det første virker.</small><br>"
        sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">Klik på dette Link for at indtaste priser.</A><br><br>"
       ' sendHTML = sendHTML + "<b><i>Hvis du ikke kan komme ind på siden, eller den melder en fejl, så læs dette:</i></b><br>"
        sendHTML = sendHTML + "Kopier linjen herunder og indsæt det i adresselinjen på din browser.<br><br>"
        sendHTML = sendHTML + "http://www.DiMP.dk/mmPriser.aspx?Query=" & BladID.ToString & "*" & BeregnWebChecksum(BladNavn) & "*0"

        mail.Body = sendHTML 'convertDanishHTML(sendHTML)
                mail.BodyMappe = "Z:\Forsendelser\mmPriser\01-01-2019 Rykker"
        mail.BodyFilNavn = Trim(BladNavn) & " [" & eMail & "]"
                mail.From = "lhj@delokaleugeaviser.dk"
                mail.Send()
      End If
    End While
    dr.Close()
    cn.Close()
    cm.Dispose()
    cn.Dispose()
        Cursor = Cursors.Default
      

    End Sub



  Private Sub btnNyePriser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNyePriser.Click
    ' TestAfIndrykningsDato()
    'Deadlines()

    'DataTilWeb()
        NyePriser()
    ' sendTjeklister()
    'sendPrimærOmråder()
  End Sub

  Private Sub TestAfIndrykningsDato()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    cn.Open()
    cm.CommandType = CommandType.Text
    cm.CommandText = "SET DATEFIRST 1 INSERT INTO TestIndrykningsDato (IndrykningsDato, MediePlanNr, OrdreDato) SELECT (DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4 - DATEPART(dw, DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4) + 1) + tblBladStamdata.UgedagID % 7 - 1 AS IndrykningsDato, tblMedieplanNr.MedieplanNr, tblMedieplan.OrdreDato FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version INNER JOIN tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID WHERE (tblMedieplanNr.MedieplanNr > 134827)"
    cm.ExecuteNonQuery()
    cn.Close()
    cm.Dispose()
    cn.Dispose()


  End Sub

  Private Sub sendTjeklister()
    Dim startTid As Date = Now
    Dim timen As Integer = Hour(startTid)
    Dim minut As Integer = Minute(startTid)
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim ordreCM As SqlCommand = cn.CreateCommand()
    Dim ordreDR As SqlDataReader
    Dim bladCM As SqlCommand = cn.CreateCommand()
    Dim bladDR As SqlDataReader
    Dim bladID As Integer
    Dim bladNavn As String
    Dim eMail As String
    Dim antalEmailSendt As Integer = 0
    '   Dim SendIndeværendeUge As Boolean
    Dim denneUge As Integer
    '  Dim sendeUge As Integer
    Dim first As Boolean = True
    '   Dim mail As New clsEmail
    Dim succes As Boolean
    Dim j As Integer
    Dim HTMLTekst As New StringBuilder(1000)
    Dim logTekst As New StringBuilder(2000)

    ordreCM.CommandType = CommandType.Text
    bladCM.CommandType = CommandType.Text
    bladCM.CommandText = "SELECT BladID, Navn, OrdreEmail FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0) AND (BladID <> 476)"
    cn.Open()
    bladDR = bladCM.ExecuteReader
    denneUge = frmMain.DenneUge
    If bladDR.HasRows Then
      logTekst.AppendLine("Tjekliste udsending påbegyndt.")
      While bladDR.Read
        '   Try
        Dim modtagere() As String
        bladID = bladDR.GetInt32(0)
        bladNavn = bladDR.GetString(1) & ""
        eMail = bladDR.GetString(2) & ""
        ' SendIndeværendeUge = bladDR.GetBoolean(3)
        If eMail <> "" Then
          ' If SendIndeværendeUge Then
          '  sendeUge = denneUge
          ' Else
          '  sendeUge = denneUge + 1
          ' End If
          ordreCM.CommandText = "SELECT tblMedieplanNr.MedieplanNr, NavisionContact.Name AS Annoncør, tblMedieplan.AntalFarver, LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.IndrykningsUge FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplanNr.Status > 2) AND (tblMedieplanNr.Status <> 4) AND (tblMedieplan.IndrykningsÅr = 2010) AND (tblMedieplan.IndrykningsUge > 28) AND (tblMedieplanLinjer.UgeavisID = " & bladID & ") ORDER BY tblMedieplan.IndrykningsUge"
          first = True
          HTMLTekst.Remove(0, HTMLTekst.Length)
          ordreDR = ordreCM.ExecuteReader()
          While ordreDR.Read()
            If first Then
              HTMLTekst.Append("Kære Medlemmer.<br><br>")
              HTMLTekst.Append("Vi oplevede desværre en alvorlig systemfejl i Lokalplanneren i sidste uge, hvilket bevirkede at en del annonceordrer alligevel ikke var udsendt fra vores side. Det blev vi desværre for sent opmærksomme på, men med jeres hjælp var det kun få annoncer, der ikke bliver indrykket her i uge 28.<br><br>")
              HTMLTekst.Append("For at vi nu kan være sikre på, at I har modtaget alle annonceordrer i fremtiden fra uge 29 og frem, beder vi jer om at gennemgå medsendte oversigt for at afstemme, om I har modtaget alle annonceordrer fra DLU.<br>")
              HTMLTekst.Append("Hvis der er unøjagtigheder bedes I straks kontakte Christa i support på telefonnr. 3525 9591, så vi kan få rettet det.<br>Samtidig beder jeg jer om, at være ekstra opmærksomme på tjeklisterne for de kommende uger.<br><br>")
              HTMLTekst.Append("Jeg beklager de gener, I måtte have haft af ovenstående, men noterer mig med glæde den store hjælpsomhed, der er udvist for at løse dette sammen med De Lokale Ugeaviser.<br><br><br>")
              HTMLTekst.Append("Med venlig hilsen<br>Lars Winther<br><br><br>")
              HTMLTekst.Append("<Table border=""1"" cellpadding=""0"" cellspacing=""0"" width=""90%""><TR><TD Width=""10%""><B>Uge</B></TD><TD Width=""10%""><B>Ordre Nr</B></TD><TD Width=""50%""><B>Annoncør</B></TD><TD Width=""20%""><B>Format</B></TD><TD Width=""10%""><B>Farver</B></TD></TR>")
              first = False
            End If
            HTMLTekst.Append("<TR>")
            HTMLTekst.Append("<TD>" & ordreDR("IndrykningsUge").ToString() & "</TD>")
            HTMLTekst.Append("<TD>" & ordreDR("MedieplanNr").ToString() & "</TD>")
            HTMLTekst.Append("<TD>" & ordreDR("Annoncør").ToString() & "</TD>")
            HTMLTekst.Append("<TD align=""right"">" & ordreDR("Format").ToString() & "</TD>")
            HTMLTekst.Append("<TD align=""right"">" & ordreDR("AntalFarver").ToString() & "</TD>")
            HTMLTekst.Append("</TR>")
          End While
          ordreDR.Close()
          If Not first Then
            HTMLTekst.Append("</TABLE>")
            modtagere = Split(eMail, ";")
            For j = 0 To UBound(modtagere)
              Dim mail As New clsEmail
              mail.Til = modtagere(j) ' mailModtager
              mail.Subject = "VIGTIGT! Annonceordre i uge 29 og frem for " & bladNavn
              mail.From = "cpn@delokaleugeaviser.dk"
              mail.BodyMappe = "Z:\Forsendelser\Tjeklister\Samlet"
              mail.BodyFilNavn = bladNavn & " [" & modtagere(j) & "]"
              mail.Body = HTMLTekst.ToString
              succes = mail.Send()
              If succes Then
                logTekst.AppendLine("Sendt til " & bladNavn & " på eMail " & modtagere(j))
                antalEmailSendt = antalEmailSendt + 1
              Else
                logTekst.AppendLine("IKKE sendt til " & bladNavn)
              End If

            Next j
          End If
          'End If
        Else
          logTekst.AppendLine("Mangler email for " & bladNavn)
        End If
        ' Catch ex As Exception
        ' logTekst.AppendLine("Der opstod en fejl med teksten: " & ex.Message)
        ' End Try
      End While
      logTekst.AppendLine("Tjekliste sending færdig. Har afsendt " & antalEmailSendt.ToString & " emails i denne sending.")
      MessageBox.Show(logTekst.ToString, "Send Log", MessageBoxButtons.OK)
    End If
    bladDR.Close()
    cn.Close()
    ordreCM.Dispose()
    bladCM.Dispose()
    cn.Dispose()
  End Sub

  Private Sub DataTilWeb()
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim cm2 As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader
    Dim dr2 As SqlDataReader
    cm.CommandType = CommandType.Text
    cm2.CommandType = CommandType.Text
    cn.Open()

    cm.CommandText = "SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.Adresse, tblBladStamdata.PostNr, tblPostNr.PostBy, tblBladStamdata.Tlf, tblBladStamdata.Fax, tblBladStamdata.AnnonceEmail AS Email, tblBladStamdata.Hjemmeside, tblDage.DagNavn, CASE WHEN tblDelOmråde.DelOmrådeKode = 'Y' THEN 'delomraade_fyn' WHEN tblDelOmråde.DelOmrådeKode = 'N' THEN 'delomraade_nord' WHEN tblDelOmråde.DelOmrådeKode = 'S' THEN 'delomraade_syd' WHEN tblDelOmråde.DelOmrådeKode = 'M' THEN 'delomraade_midt' WHEN tblDelOmråde.DelOmrådeKode = 'J' THEN 'delomraade_bornholm' ELSE 'delomraade_' + lower(tblDelOmråde.DelOmrådeKode) END AS delomraade, tblBladStamdata.Oplag, tblBladStamdata.RedaktionEmail, tblBladStamdata.Totalområde, tblBladStamdata.TotalområdePct, 'Kommuner' AS 'Kommuner', tblBladStamdata.Primær, tblBladStamdata.PrimærPct, (SELECT mmPris FROM tblPriser WHERE (PlaceringID = 1) AND (År = YEAR(GETDATE())) AND (PrislisteID = 1) AND (FormatFra < 2) AND (BladID = tblBladStamdata.BladID)) AS TekstPris, (SELECT mmPris FROM tblPriser WHERE (PlaceringID = 11) AND (År = YEAR(GETDATE())) AND (PrislisteID = 1) AND (FormatFra < 2) AND (BladID = tblBladStamdata.BladID)) AS RubrikPris, (SELECT FarvePris FROM tblPriser WHERE (PlaceringID = 1) AND (År = YEAR(GETDATE())) AND (PrislisteID = 1) AND (FormatFra < 2) AND (BladID = tblBladStamdata.BladID)) AS FarvePris, (SELECT Farve4Pris FROM tblPriser WHERE (PlaceringID = 1) AND (År = YEAR(GETDATE())) AND (PrislisteID = 1) AND (FormatFra < 2) AND (BladID = tblBladStamdata.BladID)) AS Farve4Pris, tblBladStamdata.Kontaktperson FROM tblPostNr INNER JOIN tblBladStamdata ON tblPostNr.PostNr = tblBladStamdata.PostNr INNER JOIN tblDage ON tblBladStamdata.UgedagID = tblDage.DagID INNER JOIN tblDelOmråde ON tblBladStamdata.DelOmrådeID = tblDelOmråde.DelOmrådeID WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0)"

    Dim xmlTekst As String = "<?xml version=""""1.0"""" encoding=""""UTF-8""""?><root>"
    Dim bladTekst As String = ""
    Dim covered As String = ""
    Dim tekstside As Double
    Dim rubrik As Double
    Dim farvepris As Double
    Dim farve4pris As Double


    dr = cm.ExecuteReader
    While dr.Read
      If IsDBNull(dr(18)) Then
        tekstside = 0
      Else
        tekstside = CDbl(dr(18))
      End If
      If IsDBNull(dr(19)) Then
        rubrik = 0
      Else
        rubrik = CDbl(dr(19))
      End If
      If IsDBNull(dr(20)) Then
        farvepris = 0
      Else
        farvepris = CDbl(dr(20))
      End If
      If IsDBNull(dr(21)) Then
        farve4pris = 0
      Else
        farve4pris = CDbl(dr(21))
      End If

      bladTekst = "<paper id=""" & dr(0) & """ Name=""" & dr(1) & """ adresse=""" & dr(2) & """ postnr=""" & dr(3) & """ bynavn=""" & dr(4) & """ telefonnr=""" & dr(5) & """ telefax=""" & dr(6) & """ email=""" & dr(7) & """ homepage=""" & dr(8) & """ udgivelsesdag=""" & dr(9) & """ delomraade=""" & dr(10) & """ oplag=""" & dr(11) & """ redemail=""" & dr(12) & """ antal_modtager=""" & dr(13) & """ laesedaekning=""" & dr(14) & """ primaerkommuner=""" & dr(15) & """ modtager_pri=""" & dr(16) & """ laesedaekning_pri=""" & dr(17) & """ tekstside=""" & tekstside.ToString("#,##0.00") & """ rubrik=""" & rubrik.ToString("#,##0.00") & """ farvetillaeg=""" & farvepris.ToString("#,##0.00") & """ firefarvetillaeg=""" & farve4pris.ToString("#,##0.00") & """ kontaktper=""" & dr(22) & """ "

      cm2.CommandText = "SELECT PostNr, DækningsGrad FROM tblBladDækning WHERE (BladID = " & dr(0) & ")"
      dr2 = cm2.ExecuteReader
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
    File.WriteAllText("c:\bladdata.xml", xmlTekst.ToString)
    cn.Close()
    cn.Dispose()
  End Sub

End Class
