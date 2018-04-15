Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmSendTilNavision
  Private IndrykningsUge As Integer = 0

  Private Sub txtUge_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUge.ValueChanged
    If txtUge.TextLength > 0 Then
      If Integer.TryParse(txtUge.Text, IndrykningsUge) Then
        btnSend.Enabled = True
      Else
        btnSend.Enabled = False
      End If
    Else
      btnSend.Enabled = False
    End If
  End Sub

  Private Sub frmSendTilNavision_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    txtUge.Text = frmMain.DenneUge - 1
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.Close()
  End Sub

  Private Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSend.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    cn.Open()
    Dim trans As SqlTransaction = cn.BeginTransaction()

    cm.CommandType = CommandType.Text
    cm.Transaction = trans
    Try
      'Opdater TotalPris i de rækker hvor den mangler. Sættes til sidst udregnede pris for avisen
      cm.CommandText = "UPDATE tblMedieplanLinjer SET TotalPris = (SELECT TOP (1) TotalPris FROM tblMedieplanLinjer AS tblMedieplanLinjer_1 WHERE (MedieplanNr = tblMedieplanLinjer.MedieplanNr) AND (TotalPris IS NOT NULL) AND (Version < tblMedieplanLinjer.Version) AND (UgeavisID = tblMedieplanLinjer.UgeavisID) ORDER BY Version DESC) WHERE (TotalPris IS NULL) AND (Version > 11)"
      cm.ExecuteNonQuery()
      'Kopier medieplaner
      cm.CommandText = "INSERT INTO tblMedieplan (MedieplanNr, Version, AnnoncørNo_, BureauNo_, Format1, Format2, AntalFarver, DPKulørID, PlaceringID, IndrykningsUge, IndrykningsÅr, Beskrivelse, Overskrift, Kontaktperson, KontaktpersonTilhører, Fakturering, RekvisitionsNr, BilagsBladeTil, BilagsBladeTilNavn, BilagsBladeTilAdresse, BilagsBladeTilPostNr, BilagsBladeATT, MaterialeGodtgørelseTil, MaterialeFølgerFra, MaterialeFølgerFraLeverandør, BrugMaterialeFraUge, MaterialeGodtgørelseAlle, SikkerhedsGodt, InfoGodt, SamletPris, OprettetDato, OrdreDato, KonsulentCode, Status, RettelserEfterAnnoncekontrol, TilladFarveSærRabat, TilladMmSærRabat, [Document Type], [Credit Reason], [Previous Version], SammeMateriale, KunForhandlerBundForskellig, SammeBureauOrdreNr, FællesBureauOrdreNr, BemærkningTilAnnoncør, BemærkningTilBlade, WebTillægOpkræves, MiljøTillægOpkræves, OpkrævJyskeMiljøTillæg, OpkrævFynskeMiljøTillæg, OpkrævNorthMiljøTillæg, OpkrævDSVPMiljøTillæg) SELECT tblMedieplan_1.MedieplanNr, tblMedieplan_1.Version * 10 + 1 AS EXPR1, tblMedieplan_1.AnnoncørNo_, tblMedieplan_1.BureauNo_, tblMedieplan_1.Format1, tblMedieplan_1.Format2, tblMedieplan_1.AntalFarver, tblMedieplan_1.DPKulørID, tblMedieplan_1.PlaceringID, tblMedieplan_1.IndrykningsUge, tblMedieplan_1.IndrykningsÅr, tblMedieplan_1.Beskrivelse, tblMedieplan_1.Overskrift, tblMedieplan_1.Kontaktperson,tblMedieplan_1. KontaktpersonTilhører, tblMedieplan_1.Fakturering, tblMedieplan_1.RekvisitionsNr, tblMedieplan_1.BilagsBladeTil, tblMedieplan_1.BilagsBladeTilNavn, tblMedieplan_1.BilagsBladeTilAdresse, tblMedieplan_1.BilagsBladeTilPostNr, tblMedieplan_1.BilagsBladeATT, tblMedieplan_1.MaterialeGodtgørelseTil, tblMedieplan_1.MaterialeFølgerFra, tblMedieplan_1.MaterialeFølgerFraLeverandør, tblMedieplan_1.BrugMaterialeFraUge, tblMedieplan_1.MaterialeGodtgørelseAlle, tblMedieplan_1.SikkerhedsGodt, tblMedieplan_1.InfoGodt, tblMedieplan_1.SamletPris, tblMedieplan_1.OprettetDato, tblMedieplan_1.OrdreDato, tblMedieplan_1.KonsulentCode, tblMedieplan_1.Status, tblMedieplan_1.RettelserEfterAnnoncekontrol, tblMedieplan_1.TilladFarveSærRabat, tblMedieplan_1.TilladMmSærRabat, tblMedieplan_1.[Document Type], tblMedieplan_1.[Credit Reason], tblMedieplan_1.[Previous Version], tblMedieplan_1.SammeMateriale, tblMedieplan_1. KunForhandlerBundForskellig, tblMedieplan_1.SammeBureauOrdreNr, tblMedieplan_1.FællesBureauOrdreNr, tblMedieplan_1.BemærkningTilAnnoncør, tblMedieplan_1.BemærkningTilBlade, tblMedieplan_1.WebTillægOpkræves, tblMedieplan_1.MiljøTillægOpkræves, tblMedieplan_1.OpkrævJyskeMiljøTillæg, tblMedieplan_1.OpkrævFynskeMiljøTillæg, tblMedieplan_1.OpkrævNorthMiljøTillæg, tblMedieplan_1.OpkrævDSVPMiljøTillæg FROM tblMedieplan AS tblMedieplan_1 INNER JOIN tblMedieplanNr ON tblMedieplan_1.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan_1.Version = tblMedieplanNr.AktivVersion WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan_1.IndrykningsUge = " & IndrykningsUge & ")"
      cm.ExecuteNonQuery()
      'Kopier medieplanlinjer
      cm.CommandText = "INSERT INTO tblMedieplanLinjer (MedieplanNr, Version, UgeavisID, Mm, NormalMmPris, MmPris, MmRabat, MåGiveMmRabat, MmTotal, FarveTillæg, FarvePris, FarveRabat, FarveMin, FarveMax, FarveTotal, Total, MåGiveMaterialeGodtgørelse, SkalGiveMaterialeGodtgørelse, MaterialeGodtgørelsePris, TotalPris, ManueltÆndret, ErWeekendGruppe, WebtillægFaktureresHer, SendeGruppe, RabatGruppe, MedIGrupper, BureauOrdreNr, MaterialeNr, Bemærkning, MiljøTillæg, TotalInclTillæg) SELECT tblMedieplanLinjer_1.MedieplanNr, tblMedieplanLinjer_1.Version * 10 + 1 AS EXPR1, tblMedieplanLinjer_1.UgeavisID, tblMedieplanLinjer_1.Mm, tblMedieplanLinjer_1.NormalMmPris, tblMedieplanLinjer_1.MmPris, tblMedieplanLinjer_1.MmRabat, tblMedieplanLinjer_1.MåGiveMmRabat, tblMedieplanLinjer_1.MmTotal, tblMedieplanLinjer_1.FarveTillæg, tblMedieplanLinjer_1.FarvePris, tblMedieplanLinjer_1.FarveRabat, tblMedieplanLinjer_1.FarveMin, tblMedieplanLinjer_1.FarveMax, tblMedieplanLinjer_1.FarveTotal, tblMedieplanLinjer_1.Total, tblMedieplanLinjer_1.MåGiveMaterialeGodtgørelse, tblMedieplanLinjer_1.SkalGiveMaterialeGodtgørelse, tblMedieplanLinjer_1.MaterialeGodtgørelsePris, tblMedieplanLinjer_1.TotalPris, tblMedieplanLinjer_1.ManueltÆndret, tblMedieplanLinjer_1.ErWeekendGruppe, tblMedieplanLinjer_1.WebtillægFaktureresHer, tblMedieplanLinjer_1.SendeGruppe, tblMedieplanLinjer_1.RabatGruppe, tblMedieplanLinjer_1.MedIGrupper, tblMedieplanLinjer_1.BureauOrdreNr, tblMedieplanLinjer_1.MaterialeNr, tblMedieplanLinjer_1.Bemærkning, tblMedieplanLinjer_1.MiljøTillæg, tblMedieplanLinjer_1.TotalInclTillæg FROM tblMedieplanLinjer AS tblMedieplanLinjer_1 INNER JOIN tblMedieplan ON tblMedieplanLinjer_1.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer_1.Version = tblMedieplan.Version INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge = " & IndrykningsUge & ")"
      cm.ExecuteNonQuery()
      'Kopier til Navision ordre  ''MaterialegodtgørelseTil feltet er her altid tændt!!
      cm.CommandText = "INSERT INTO tblOrdreNavision (OrdreNr, Version, [Document Type], AnnoncørID, Uge, AntalFarver, OrdreDato, SamletPris, SælgerKode, SikkerhedsGodt, InfoGodt, BureauOrdreNr, Bureau, EnOrdre, Status, FakBem1, FakBem2, FakBem3, MaterialeGodtgørelseTil, [Previous Order No], [Credit Reason], [Previous Version], [Item Description], SammeBureauOrdreNr) SELECT tblMedieplan.MedieplanNr AS OrdreNr, tblMedieplan.Version * 10 + 1 AS EXPR1, tblMedieplan.[Document Type], tblMedieplan.AnnoncørNo_, tblMedieplan.IndrykningsUge AS Uge, tblMedieplan.AntalFarver, tblMedieplan.OrdreDato, tblMedieplan.SamletPris, NavisionContact.[Salesperson Code], tblMedieplan.SikkerhedsGodt, tblMedieplan.InfoGodt, tblMedieplan.FællesBureauOrdreNr AS BureauOrdreNr, tblMedieplan.BureauNo_ AS Bureau, tblMedieplan.Fakturering AS EnOrdre, tblMedieplanNr.Status, tblMedieplanNr.FakturaBemærkning1 AS FakBem1, tblMedieplanNr.FakturaBemærkning2 AS FakBem2, tblMedieplanNr.FakturaBemærkning3 AS FakBem3, 1 AS MatTil, tblMedieplan.MedieplanNr AS [Previous Order No], '' AS EXPR1, 0 AS EXPR2, '' AS EXPR3, tblMedieplan.SammeBureauOrdreNr FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge = " & IndrykningsUge & ")"
      cm.ExecuteNonQuery()
      'Kopier til Navision ordre linjer
      cm.CommandText = "SET DATEFIRST 1 INSERT INTO tblOrdreLinjerNavision (OrdreNr, Version, [Document Type], BladId, Format, Mm, AnvendtPris, SpecialRabat, FarveTillægsPris, FarveTillægsRabat, MaterialeGodt, TotalPris, MaterialePris, BureauOrdreNr, FirstTime) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version * 10 + 1 AS EXPR1, tblMedieplan.[Document Type], tblMedieplanLinjer.UgeavisID AS BladId, LTRIM(STR(tblMedieplan.Format1)) + 'x' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplanLinjer.Mm, tblMedieplanLinjer.MmPris AS AnvendtPris, tblMedieplanLinjer.MmRabat AS SpecialRabat, tblMedieplanLinjer.FarvePris AS FarveTillægsPris, tblMedieplanLinjer.FarveRabat AS FarveTillægsRabat, tblMedieplanLinjer.SkalGiveMaterialeGodtgørelse AS MaterialeGodt, tblMedieplanLinjer.TotalPris, tblMedieplanLinjer.MaterialeGodtgørelsePris AS MaterialePris, tblMedieplanLinjer.BureauOrdreNr, (DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4 - DATEPART(dw, DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4) + 1) + tblBladStamdata.UgedagID % 7 - 1 AS IndrykningsDato FROM tblMedieplanLinjer INNER JOIN tblMedieplan ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge = " & IndrykningsUge & ")"
      cm.ExecuteNonQuery()
      ''Indsæt Webtillægs linier i Navision tabel
      'cm.CommandText = "INSERT INTO tblOrdreGebyrNavision (OrdreNr, Version, [Document Type], Type, BladId, Description, Amount) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version * 10 + 1 AS Version, tblMedieplan.[Document Type], 1 AS Type, tblMedieplanLinjer.UgeavisID AS BladId, 'Webtillæg for ' + tblBladStamdata.Ejerforhold AS Description, CASE WHEN tblMedieplan.PlaceringID < 11 THEN tblEjerforhold.WebTillægTekst ELSE tblEjerforhold.WebTillægRubrik END AS Amount FROM tblBladStamdata INNER JOIN tblMedieplanLinjer ON tblBladStamdata.BladID = tblMedieplanLinjer.UgeavisID INNER JOIN tblMedieplan ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblEjerforhold ON tblBladStamdata.Ejerforhold = tblEjerforhold.Ejerforhold WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge = " & IndrykningsUge & ") AND (tblMedieplan.WebTillægOpkræves = 1) AND  (tblMedieplanLinjer.WebtillægFaktureresHer = 1) OR (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge = " & IndrykningsUge & ") AND (tblMedieplan.WebTillægOpkræves = 1) AND (tblMedieplan.SammeMateriale = 0) AND (tblMedieplan.KunForhandlerBundForskellig = 0)"
      'cm.ExecuteNonQuery()
      ''Indsæt Miljøtillæg i Navision tabel
      cm.CommandText = "INSERT INTO tblOrdreGebyrNavision (OrdreNr, Version, [Document Type], Type, BladId, Description, Amount) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version * 10 + 1 AS Version, 0 AS DokType, 2 AS Type, tblMedieplanLinjer.UgeavisID AS BladId, 'Miljø tillæg' AS Description, tblMedieplanLinjer.MiljøTillæg AS Amount FROM tblMedieplanNr INNER JOIN tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version INNER JOIN tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version WHERE (tblMedieplan.MiljøTillægOpkræves = 1) AND (tblMedieplanLinjer.MiljøTillæg > 0) AND (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge = " & IndrykningsUge & ")"
      cm.ExecuteNonQuery()
        'Opdater Navision ordre dato så kl. sættes til 00:00:00, Advertiser med annoncørnavn og Placement med placerings betegnelse
      cm.CommandText = "UPDATE tblOrdreNavision SET OrdreDato = CONVERT(DATETIME, CONVERT(NVARCHAR, tblOrdreNavision.OrdreDato, 105) + ' 00:00:00', 105), Advertiser = NavisionContact.Name, Placement = tblPlacering.Betegnelse FROM tblOrdreNavision INNER JOIN tblMedieplan ON tblOrdreNavision.Version = tblMedieplan.Version AND tblOrdreNavision.OrdreNr = tblMedieplan.MedieplanNr INNER JOIN tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_"
      cm.ExecuteNonQuery()
        'Opdater Version
      cm.CommandText = "UPDATE tblMedieplanNr SET AktivVersion = tblMedieplanNr.AktivVersion * 10 + 1 FROM tblMedieplanNr INNER JOIN tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge = " & IndrykningsUge & ")"
      cm.ExecuteNonQuery()
      trans.Commit()
      MessageBox.Show("Ordre er sendt til Navision. De skal nu importeres i Navision", "Overførsel slut", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      trans.Rollback()
      MessageBox.Show("Der opstod en fejl ved overførsel til Navision." & vbCrLf & "Fejltekst:" & ex.Message, "Overførsel fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      trans.Dispose()
      cn.Close()
      cm.Dispose()
      cn.Dispose()
    End Try
    Me.Close()
  End Sub
End Class
