﻿Imports Infragistics.Win.UltraWinGrid
Imports System.Data.SqlClient

Public Class frmForespørgsler
  Private _noDoubleClickRow As Boolean = False

  Private Sub frmForespørgsler_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Me.grdForespørgsler.DisplayLayout.Save(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\ForespørgslerGrid.bin", PropertyCategories.All)
  End Sub

  Private Sub frmForespørgsler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    If HentBrugersIndstillinger AndAlso My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\ForespørgslerGrid.bin") Then
      Me.grdForespørgsler.DisplayLayout.Load(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\ForespørgslerGrid.bin", PropertyCategories.All)
    End If
    Me.TblWEBForespørgselLinjerTableAdapter.Fill(Me.DstForespørgsler.tblWEBForespørgselLinjer)
    Me.TblWEBForespørgselTableAdapter.Fill(Me.DstForespørgsler.tblWEBForespørgsel)
  End Sub

  Private Sub grdForespørgsler_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grdForespørgsler.AfterSelectChange
    If grdForespørgsler.Selected.Rows.Count = 1 Then
      If grdForespørgsler.Selected.Rows(0).Band.Index = 0 Then
        If grdForespørgsler.Selected.Rows(0).Cells("Afsluttet").Value = 0 Then
          btnSendRykker.Enabled = True
        Else
          btnSendRykker.Enabled = False
        End If
      Else
        btnSendRykker.Enabled = False
      End If
    Else
      btnSendRykker.Enabled = False
    End If
  End Sub

  Private Sub grdForespørgsler_DoubleClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles grdForespørgsler.DoubleClickCell
    If e.Cell.Band.Index = 0 Then
      If e.Cell.Column.Header.Caption = "Afsluttet" Then
        If e.Cell.Value = False Then
          Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
          Dim cm As SqlCommand = cn.CreateCommand
          cm.CommandType = CommandType.Text
          If MessageBox.Show("Vil du afslutte forespørgslen?", "Afslut forespørgsel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cn.Open()
            cm.CommandText = "UPDATE tblWEBForespørgsel SET Afsluttet = 1 WHERE (MedieplanNr = " & e.Cell.Row.Cells("MedieplanNr").Value & ")"
            cm.ExecuteNonQuery()
            Me.TblWEBForespørgselTableAdapter.Fill(Me.DstForespørgsler.tblWEBForespørgsel)
            btnSendRykker.Enabled = False
          End If
          cn.Close()
          cm.Dispose()
          cn.Dispose()
        End If
        _noDoubleClickRow = True
      End If
    End If
  End Sub

  Private Sub grdForespørgsler_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdForespørgsler.DoubleClickRow
    If Not _noDoubleClickRow Then
      If e.Row.Band.Index = 0 Then 'Hovedlinje valgt - overfør data
        If MessageBox.Show("Vil du overføre svarene til medieplanen?", "Overfør svar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
          Dim cm As SqlCommand = cn.CreateCommand
          cm.CommandType = CommandType.Text
          cm.CommandText = "UPDATE tblMedieplanLinjer SET MmPris = tblWEBForespørgselLinjer.BladMmPris, MmRabat = tblWEBForespørgselLinjer.BladMmRabat, FarvePris = tblWEBForespørgselLinjer.BladFarveTillæg, FarveRabat = tblWEBForespørgselLinjer.BladFarveRabat FROM tblWEBForespørgsel INNER JOIN tblWEBForespørgselLinjer ON tblWEBForespørgsel.ForespørgselID = tblWEBForespørgselLinjer.ForespørgselID INNER JOIN tblMedieplanLinjer ON tblWEBForespørgsel.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblWEBForespørgselLinjer.BladID = tblMedieplanLinjer.UgeavisID WHERE (tblMedieplanLinjer.Version = 1) AND (tblWEBForespørgselLinjer.BesvaretAf IS NOT NULL) AND (tblMedieplanLinjer.MedieplanNr = " & e.Row.Cells("MedieplanNr").Value & ")"
          Try
            cn.Open()
            cm.ExecuteNonQuery()
            cm.CommandText = "UPDATE tblMedieplanNr SET OverførtFraPrisforespørgsel = 1 WHERE (MedieplanNr = " & e.Row.Cells("MedieplanNr").Value & ")"
            cm.ExecuteNonQuery()
          Catch
            MessageBox.Show("Der opstod en fejl da svarene skulle overføres.", "Overførsel fejl", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
          End Try
          If MessageBox.Show("Vil du afslutte forespørgslen?", "Afslut forespørgsel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cm.CommandText = "UPDATE tblWEBForespørgsel SET Afsluttet = 1 WHERE (MedieplanNr = " & e.Row.Cells("MedieplanNr").Value & ")"
            cm.ExecuteNonQuery()
            Me.TblWEBForespørgselTableAdapter.Fill(Me.DstForespørgsler.tblWEBForespørgsel)
            btnSendRykker.Enabled = False
          End If
          cn.Close()
          cm.Dispose()
          cn.Dispose()
        End If
      Else 'Blad linie valgt - åben web side
        Dim myProcess As New Process
                myProcess.StartInfo.FileName = "http://dimp.dk/PF.aspx?Query=" & e.Row.Cells("BladID").Value & "*" & BeregnWebChecksum(e.Row.Cells("Navn").Value) & "*" & e.Row.Cells("ForespørgselID").Value & "*1" '& personID - Altid DLU der svarer
        myProcess.Start()
        Me.TblWEBForespørgselLinjerTableAdapter.Fill(Me.DstForespørgsler.tblWEBForespørgselLinjer)
        btnSendRykker.Enabled = False
      End If
    Else
      _noDoubleClickRow = False
    End If
  End Sub

  Private Sub grdForespørgsler_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles grdForespørgsler.InitializeRow
    If e.ReInitialize Then Exit Sub
    If e.Row.Band.Index = 1 Then
      If String.IsNullOrEmpty(e.Row.Cells("PersonNavn").Text) Then
        e.Row.Cells("BladMmPris").Appearance.ForegroundAlpha = Infragistics.Win.Alpha.Transparent
        e.Row.Cells("BladMmRabat").Appearance.ForegroundAlpha = Infragistics.Win.Alpha.Transparent
        e.Row.Cells("BladFarveTillæg").Appearance.ForegroundAlpha = Infragistics.Win.Alpha.Transparent
        e.Row.Cells("BladFarveRabat").Appearance.ForegroundAlpha = Infragistics.Win.Alpha.Transparent
      Else
        e.Row.Cells("Navn").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
        If Decimal.Round(e.Row.Cells("DLUMmPris").Value, 2) <> Decimal.Round(e.Row.Cells("BladMmPris").Value, 2) Then
          e.Row.Cells("BladMmPris").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
        Else
          e.Row.Cells("BladMmPris").Appearance.ForegroundAlpha = Infragistics.Win.Alpha.Transparent
        End If
        If Decimal.Round(e.Row.Cells("DLUMmRabat").Value, 2) <> Decimal.Round(e.Row.Cells("BladMmRabat").Value, 2) Then
          e.Row.Cells("BladMmRabat").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
        Else
          e.Row.Cells("BladMmRabat").Appearance.ForegroundAlpha = Infragistics.Win.Alpha.Transparent
        End If
        If Decimal.Round(e.Row.Cells("DLUFarveTillæg").Value, 2) <> Decimal.Round(e.Row.Cells("BladFarveTillæg").Value, 2) Then
          e.Row.Cells("BladFarveTillæg").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
        Else
          e.Row.Cells("BladFarveTillæg").Appearance.ForegroundAlpha = Infragistics.Win.Alpha.Transparent
        End If
        If Decimal.Round(e.Row.Cells("DLUFarveRabat").Value, 2) <> Decimal.Round(e.Row.Cells("BladFarveRabat").Value, 2) Then
          e.Row.Cells("BladFarveRabat").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
        Else
          e.Row.Cells("BladFarveRabat").Appearance.ForegroundAlpha = Infragistics.Win.Alpha.Transparent
        End If
      End If
    End If
  End Sub

  Private Sub btnSendRykker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendRykker.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim cm2 As SqlCommand = cn.CreateCommand
    Dim forespørgselID As Integer
    Dim modtager() As String
    Dim personID As Integer
    Dim AntalUdsendinger As Integer
    Dim j As Integer
    Dim sendHTML As String
    Dim queryStr As String
    Dim succes As Boolean = False
    Dim logTekst As String
    Dim nyFrmEmail As New frmEmail

    If nyFrmEmail.ShowDialog() = Windows.Forms.DialogResult.OK Then
      logTekst = ""
      cn.Open()
      cm.CommandType = CommandType.Text
      forespørgselID = grdForespørgsler.Selected.Rows(0).Cells("ForespørgselID").Value
      cm.CommandText = "SELECT tblWEBForespørgselLinjer.BladID, tblBladStamdata.Navn, tblBladStamdata.PrisforespørgselEmails, tblWEBForespørgsel.AntalUdsendinger FROM tblWEBForespørgselLinjer INNER JOIN tblBladStamdata ON tblWEBForespørgselLinjer.BladID = tblBladStamdata.BladID INNER JOIN tblWEBForespørgsel ON tblWEBForespørgselLinjer.ForespørgselID = tblWEBForespørgsel.ForespørgselID WHERE (tblWEBForespørgselLinjer.BesvaretAf IS NULL) AND (tblWEBForespørgsel.ForespørgselID = " & forespørgselID & ")"
      Dim dr As SqlDataReader = cm.ExecuteReader(CommandBehavior.Default)
      While dr.Read
        If dr("PrisforespørgselEmails") <> "" Then
          modtager = Split(dr("PrisforespørgselEmails"), ";")
          For j = 0 To UBound(modtager)
            personID = 0
            If modtager(j) <> "" Then
              cm2.CommandText = "SELECT PersonID FROM tblWEBeMails WHERE eMail = '" & modtager(j) & "'"
              personID = cm2.ExecuteScalar
              If personID = 0 Then
                cm2.CommandText = "INSERT INTO tblWEBeMails (eMail, PersonNavn) VALUES ('" & modtager(j) & "', N'')"
                cm2.ExecuteNonQuery()
                cm2.CommandText = "SELECT PersonID FROM tblWEBeMails WHERE eMail = '" & modtager(j) & "'"
                personID = cm2.ExecuteScalar
              End If
              Dim mail As New clsEmail
              mail.Subject = nyFrmEmail.Emne
              mail.Til = modtager(j)
              mail.BodyTitle = "Rykker på prisforespørgsel fra DLU."
              sendHTML = "<center><B><big><u>Rykker på prisforespørgsel fra DLU.</u></big></B></center><br><br>"
              If nyFrmEmail.Emne <> "" Then
                sendHTML = sendHTML + "<Br><i>" + nyFrmEmail.Emne + "</i><br>"
              End If
              If nyFrmEmail.Tekst <> "" Then
                sendHTML = sendHTML + Replace(nyFrmEmail.Tekst, vbCrLf, "<br>") + "<BR>"
              End If
              sendHTML = sendHTML + "<br><h3>Link:</h3>"
              queryStr = "http://www.DiMP.dk/PF.aspx?Query=" & dr("BladID") & "*" & BeregnWebChecksum(dr("Navn")) & "*" & forespørgselID & "*" & personID
              sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">" & queryStr & "</A><br>"
              sendHTML = sendHTML + "<h4>Alternativt Link:</h4>"
              sendHTML = sendHTML + "<small>Prøv dette link, hvis ikke det første virker.</small><br>"
              sendHTML = sendHTML + "<A href=" & Chr(34) & queryStr & Chr(34) & ">Klik på dette Link.</A><br><br>"
              sendHTML = sendHTML + "<b><i>Hvis du ikke kan komme ind på siden, eller den melder en fejl, så læs dette:</i></b><br>"
              sendHTML = sendHTML + "Kopier linjen herunder og indsæt det i adresselinjen på din browser.<br><br>"
              sendHTML = sendHTML + "http://www.DiMP.dk/PF.aspx?Query=" & dr("BladID") & "*" & BeregnWebChecksum(dr("Navn")) & "*" & forespørgselID & "*" & personID & "<br>"
              sendHTML = sendHTML + "<BR>Med venlig hilsen<BR>" & frmMain.BrugerFuldeNavn & "<BR>"
              AntalUdsendinger = dr("AntalUdsendinger")
              mail.Body = sendHTML 'convertDanishHTML(sendHTML)
              mail.BodyMappe = "Z:\Forsendelser\Forespørgsler\" & grdForespørgsler.Selected.Rows(0).Cells("MedieplanNr").Value & "\Rykker " & AntalUdsendinger.ToString
              mail.BodyFilNavn = Trim(dr("Navn")) & " [" & modtager(j) & "]"
              mail.From = frmMain.BrugerEmail
              succes = mail.Send()
              If succes Then
                logTekst = logTekst + "Rykker sendt til " & dr("Navn") & " på email : " & modtager(j) & vbCrLf
              Else
                logTekst = logTekst + "Rykker ikke sendt til " & dr("Navn") & " Ukendt fejl!" & vbCrLf
              End If
            End If
          Next j
        Else
          logTekst = logTekst + "Rykker ikke sendt til " & dr("Navn") & " Email mangler!" & vbCrLf
        End If
      End While
      cm2.CommandText = "UPDATE tblWEBForespørgsel SET AntalUdsendinger = " & AntalUdsendinger + 1 & " WHERE (ForespørgselID = " & forespørgselID & ")"
      If AntalUdsendinger > 0 Then cm2.ExecuteNonQuery()
      MessageBox.Show(logTekst, "Forespørgsels rykker", MessageBoxButtons.OK, MessageBoxIcon.Information)
      cn.Close()
    End If
    nyFrmEmail.Close()
    nyFrmEmail.Dispose()
    cm.Dispose()
    cm2.Dispose()
    cn.Dispose()
  End Sub

End Class