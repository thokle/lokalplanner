Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Imports Rebex.Net
Imports System.Data.SqlClient

Public Class frmMaterialeUdsending
  Inherits System.Windows.Forms.Form
  Private _medieplanNr As Integer = 0
  Private _version As Integer = 0
  Private _kundeNavn As String = ""
  Private _sendeUge As String = ""
  Private _kontakt As String = ""
  Private _hoejde As String = ""
  Private _bredde As String = ""
  Private _farve As String = ""
  Private filSti As String = ""
  Private _afsender As String = ""
  Private currentSti As String = ""
  Private sending As Udsending() = New Udsending(249) {}
  Private antalAviser As Integer = 0
  Private currentAvis As Integer = 1
  Private previousAvis As Integer = 1
  Private noUpdate As Boolean = False
  Private [error] As Boolean = False
  Private f As New frmCheckTekst("Status oversigt." & vbCrLf)
  Private fileSize As Decimal = 0
  Private masterRetry As Integer = 0

  Public Sub New(ByVal _datavalues As clsMedieplanHoved)
    InitializeComponent()
    _medieplanNr = _datavalues.MedieplanNr
    _version = _datavalues.Version
    _kundeNavn = _datavalues.AnnoncørNavn
    _sendeUge = _datavalues.IndrykningsUge
    _kontakt = frmMain.BrugerFuldeNavn
    _hoejde = _datavalues.Format2
    _bredde = _datavalues.Format1
    _farve = _datavalues.AntalFarver
    _afsender = frmMain.BrugerEmail

    Cursor.Current = Cursors.AppStarting
    sqlConn.ConnectionString = My.Settings.DiMPdotNetConnectionString 'ConfigurationSettings.AppSettings("SqlConn")
    Dim reader As SqlDataReader
    Me.Text = "Materialeudsendelse for Ordre Nr. " + _medieplanNr.ToString()
    lblOrdreInfo.Text = "Materialeudsendelse for Ordre Nr. " + _medieplanNr.ToString() + " kunde : " + _kundeNavn
    _kundeNavn = _kundeNavn.Trim().Replace("\", "-").Replace("/", "-")
    SetDirectory("Z:\Annoncemateriale\")
    sqlComm.Parameters("@MedieplanNr").Value = _medieplanNr
    sqlComm.Parameters("@Version").Value = _version
    sqlConn.Open()
    reader = sqlComm.ExecuteReader()
    Try
      While reader.Read()
        antalAviser += 1
        sending(antalAviser).bladID = reader.GetInt32(0)
        sending(antalAviser).bladNavn = reader.GetString(1)
        sending(antalAviser).bureauOrdreNr = reader.GetString(2)
        If Not reader.IsDBNull(3) Then
          sending(antalAviser).filNavn = reader.GetString(3)
        Else
          sending(antalAviser).filNavn = ""
        End If
        If Not reader.IsDBNull(4) Then
          sending(antalAviser).erSendt = reader.GetBoolean(4)
        Else
          sending(antalAviser).erSendt = False
        End If
        If Not reader.IsDBNull(5) Then
          sending(antalAviser).medieNetID = reader.GetString(5)
        Else
          sending(antalAviser).medieNetID = ""
        End If
        If Not reader.IsDBNull(6) Then
          sending(antalAviser).eMail = reader.GetString(6)
        Else
          sending(antalAviser).eMail = ""
        End If
        If Not reader.IsDBNull(7) Then
          sending(antalAviser).filSti = reader.GetString(7)
        Else
          sending(antalAviser).filSti = ""
        End If
        If Not reader.IsDBNull(8) Then
          sending(antalAviser).skalSendes = reader.GetBoolean(8)
        Else
          sending(antalAviser).skalSendes = False
        End If
        If Not reader.IsDBNull(9) Then
          sending(antalAviser).materialeID = reader.GetString(9)
        Else
          MessageBox.Show("Der mangler materiale nr. på et eller flere blade!" & vbCrLf & "Dette er en fejl der skal rettes før der kan sendes.", "Mangler materiale nr.", MessageBoxButtons.OK, MessageBoxIcon.Error)
          Me.Close()
          Exit Sub
        End If
      End While
    Catch ex As Exception
      Cursor.Current = Cursors.Default
      MessageBox.Show(ex.Message)
    Finally
      reader.Close()
      sqlConn.Close()
    End Try
    Dim i As Integer = 2
    pnlControls.SuspendLayout()
    txtBureauordrenr1.Visible = _datavalues.BureauNO_ <> ""
    chkSammeNr.Visible = _datavalues.BureauNO_ <> ""
    lblBureauOrdreNr.visible = _datavalues.BureauNO_ <> ""
    While i <= antalAviser
      Dim nyY As Integer = (i * 23) - 22
      Dim lbl As New Label()
      lbl.Location = New System.Drawing.Point(8, nyY)
      lbl.Name = "lblAvisnavn" + i.ToString()
      lbl.Size = lblAvisnavn1.Size
      lbl.Text = "AvisNavn"
      lbl.Tag = i.ToString()
      AddHandler lbl.Click, AddressOf lblAvisnavn_Click
      Dim tb As New TextBox()
      tb.Location = New System.Drawing.Point(txtBureauordrenr1.Location.X, nyY)
      tb.MaxLength = 20
      tb.Name = "txtBureauordrenr" + i.ToString()
      tb.Size = txtBureauordrenr1.Size
      tb.Text = ""
      tb.Tag = i.ToString()
      tb.TabIndex = i
      tb.ReadOnly = True
      tb.Visible = _datavalues.BureauNO_ <> ""
      Dim txt As New TextBox()
      txt.AllowDrop = True
      txt.Location = New System.Drawing.Point(txtFilnavn1.Location.X, nyY)
      txt.MaxLength = 250
      txt.Name = "txtFilnavn" + i.ToString()
      txt.Tag = i.ToString()
      txt.Size = txtFilnavn1.Size
      txt.Text = ""
      txt.TabStop = False
      txt.ReadOnly = True
      AddHandler txt.MouseDown, AddressOf txtFilnavn_MouseDown
      AddHandler txt.DragDrop, AddressOf txtFilnavn_DragDrop
      AddHandler txt.DragEnter, AddressOf txtFilnavn_DragEnter
      Dim cb As New CheckBox()
      cb.Location = New System.Drawing.Point(chkSend1.Location.X, nyY)
      cb.Name = "chkSend" + i.ToString()
      cb.Size = chkSend1.Size
      cb.Tag = i.ToString
      cb.TabStop = False
      AddHandler cb.CheckedChanged, AddressOf chkSend_CheckedChanged
      Dim chk As New CheckBox()
      'chk.AutoCheck = False
      chk.Location = New System.Drawing.Point(chkErSendt1.Location.X, nyY)
      chk.Name = "chkErSendt" + i.ToString()
      chk.Size = chkErSendt1.Size
      chk.Tag = i.ToString()
      chk.TabStop = False
      AddHandler chk.CheckedChanged, AddressOf chkErSendt_CheckedChanged
      Me.pnlControls.Controls.AddRange(New System.Windows.Forms.Control() {lbl, tb, txt, cb, chk})
      i += 1
    End While
    pnlControls.ResumeLayout()
    FyldData()
    chkSammeFil.Checked = _datavalues.SammeMateriale
    If antalAviser = 1 Then
      chkSammeFil.Checked = True
    End If
    chkSammeNr.Checked = _datavalues.SammeBureauOrdreNr
    btnSendMateriale.Enabled = True
  End Sub

  Private Sub FyldData()
    Cursor.Current = Cursors.WaitCursor
    noUpdate = True
    pnlControls.SuspendLayout()
    For i As Integer = 1 To antalAviser
      For Each ctl As Control In pnlControls.Controls
        If ctl.Name = "lblAvisnavn" + i.ToString() Then
          ctl.Text = sending(i).bladNavn
          Continue For
        End If
        If ctl.Name = "txtBureauordrenr" + i.ToString() Then
          ctl.Text = sending(i).bureauOrdreNr
          Continue For
        End If
        If ctl.Name = "txtFilnavn" + i.ToString() Then
          ctl.Text = sending(i).filNavn
          Continue For
        End If
        If ctl.Name = "chkSend" + i.ToString() Then
          Dim cb As CheckBox = DirectCast(ctl, CheckBox)
          cb.Checked = sending(i).skalSendes
          Continue For
        End If
        If ctl.Name = "chkErSendt" + i.ToString() Then
          Dim cb As CheckBox = DirectCast(ctl, CheckBox)
          cb.Checked = sending(i).erSendt
        End If
      Next
    Next
    pnlControls.ResumeLayout()
    noUpdate = False
    Cursor.Current = Cursors.Default
  End Sub

  Private Sub listBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listBox1.MouseDown
    Dim pt As New Point(e.X, e.Y)
    Dim index As Integer = listBox1.IndexFromPoint(pt)
    filSti = currentSti
    If e.Clicks = 1 Then
      If index >= 0 Then
        listBox1.DoDragDrop(listBox1.Items(index).ToString(), DragDropEffects.Copy)
      End If
    Else
      sending(currentAvis).filNavn = listBox1.Items(index).ToString()
      sending(currentAvis).filSti = filSti
      sending(currentAvis).skalSendes = True
      If currentAvis < antalAviser Then
        currentAvis += 1
      Else
        currentAvis = 1
      End If
      listBox1.Items.RemoveAt(index)
      FyldData()
      SetCurrent()
    End If
  End Sub

  Private Sub txtFilnavn_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtFilnavn1.DragDrop
    Dim tb As TextBox = DirectCast(sender, TextBox)
    tb.Text = DirectCast(e.Data.GetData("Text"), String)
    Dim controlNr As Integer = Int32.Parse(tb.Tag.ToString())
    sending(controlNr).filNavn = tb.Text
    sending(controlNr).filSti = filSti
    listBox1.Items.Remove(tb.Text)
    sending(controlNr).skalSendes = True
    currentAvis = controlNr
    If currentAvis < antalAviser Then
      currentAvis += 1
    Else
      currentAvis = 1
    End If
    FyldData()
    SetCurrent()
  End Sub

  Private Sub txtFilnavn_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtFilnavn1.DragEnter
    If e.Data.GetDataPresent("Text") Then
      e.Effect = DragDropEffects.Copy
    End If
  End Sub

  Private Sub txtFilnavn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFilnavn1.MouseDown
    Dim tb As TextBox = DirectCast(sender, TextBox)
    Dim controlNr As Integer = Int32.Parse(tb.Tag.ToString())
    filSti = sending(controlNr).filSti
    tb.DoDragDrop(tb.Text, DragDropEffects.Copy)
  End Sub

  Private Sub chkSend_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSend1.CheckedChanged
    If noUpdate Then
      Return
    End If
    Dim cb As CheckBox = DirectCast(sender, CheckBox)
    Dim controlNr As Integer = Int32.Parse(cb.Tag.ToString())
    sending(controlNr).skalSendes = cb.Checked
  End Sub

  Private Sub chkErSendt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkErSendt1.CheckedChanged
    If noUpdate Then
      Return
    End If
    Dim cb As CheckBox = DirectCast(sender, CheckBox)
    Dim controlNr As Integer = Int32.Parse(cb.Tag.ToString())
    sending(controlNr).erSendt = cb.Checked
  End Sub

  Private Sub btnSkiftDirectory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSkiftDirectory.Click
    openFile.ShowDialog()
    If openFile.FileName.Length > 0 Then
      Dim sti As String = openFile.FileName.Substring(0, openFile.FileName.LastIndexOf("\"))
      sti = sti + "\"
      SetDirectory(sti)
    End If
  End Sub

  Private Sub SetDirectory(ByVal stiNavn As String)
    Dim fileEntries As String() = Directory.GetFiles(stiNavn)
    listBox1.BeginUpdate()
    listBox1.Items.Clear()
    For Each filNavn As String In fileEntries
      listBox1.Items.Add(filNavn.Remove(0, stiNavn.Length))
    Next
    listBox1.EndUpdate()
    filSti = stiNavn
    currentSti = stiNavn
  End Sub

  Private Sub chkSendAlle_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSendAlle.CheckedChanged
    For i As Integer = 1 To antalAviser
      sending(i).skalSendes = chkSendAlle.Checked
    Next
    FyldData()
  End Sub

  Private Sub chkSammeFil_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSammeFil.CheckedChanged
    Cursor.Current = Cursors.WaitCursor
    For i As Integer = 1 To antalAviser
      sending(i).filNavn = txtFilnavn1.Text
    Next
    pnlControls.SuspendLayout()
    For i As Integer = 2 To antalAviser
      For Each ctl As Control In pnlControls.Controls
        If ctl.Name = "txtFilnavn" + i.ToString() Then
          ctl.Visible = Not chkSammeFil.Checked
        End If
      Next
    Next
    pnlControls.ResumeLayout()
    If chkSammeFil.Checked Then
      FyldData()
    End If
    Cursor.Current = Cursors.Default
  End Sub

  Private Sub chkSammeNr_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSammeNr.CheckedChanged
    Cursor.Current = Cursors.WaitCursor
    For i As Integer = 1 To antalAviser
      sending(i).bureauOrdreNr = txtBureauordrenr1.Text
    Next
    pnlControls.SuspendLayout()
    For i As Integer = 2 To antalAviser
      For Each ctl As Control In pnlControls.Controls
        If ctl.Name = "txtBureauordrenr" + i.ToString() Then
          ctl.Visible = Not chkSammeNr.Checked
        End If
      Next
    Next
    pnlControls.ResumeLayout()
    If chkSammeNr.Checked Then
      FyldData()
    End If
    Cursor.Current = Cursors.Default
  End Sub

  Private Sub btnSendMateriale_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSendMateriale.Click
    Dim retry As Integer = 1
    Dim success As Boolean = False
    Dim masterError As Boolean = False
    Dim bladFejl As String = ""
    btnSendMateriale.Enabled = False
    btnSkiftDirectory.Enabled = False
    btnLuk.Enabled = False
    Cursor.Current = Cursors.WaitCursor
    Dim checkTekst As New StringBuilder(500)
    Dim nyMappe As String
    nyMappe = "Z:\AnnoncematerialeUdsendt\" + _kundeNavn + "\" + _sendeUge.ToString() + "\" + _medieplanNr.ToString
    Directory.CreateDirectory(nyMappe)
    SaveData()
    btnSendMateriale.Enabled = False
    Cursor.Current = Cursors.WaitCursor
    f.Show()
    f.btnLuk.Enabled = False
    f.txtTekst.AppendText("Materiale sendes...." & vbCrLf)
    pbTransfer.Visible = True
    If chkSammeFil.Checked Then
      f.txtTekst.AppendText("SAMME FIL SENDES TIL ALLE (" + antalAviser.ToString() + ") AVISER. " & vbCrLf)
      Dim receivers As New StringBuilder(100)
      Dim scriptFile As New StringBuilder(500)
      Dim receiversString As String
      Dim medieNetName As String = _medieplanNr.ToString()
      If Not File.Exists(nyMappe + "\" + medieNetName + ".pdf") Then
        File.Move(sending(1).filSti + sending(1).filNavn, nyMappe + "\" + medieNetName + ".pdf")
      Else
        If sending(1).filSti + sending(1).filNavn <> nyMappe + "\" + medieNetName + ".pdf" Then
          File.Copy(sending(1).filSti + sending(1).filNavn, nyMappe + "\" + medieNetName + ".pdf", True)
          If Not sending(1).filSti.StartsWith("Z:\AnnoncematerialeUdsendt") Then
            File.Delete(sending(1).filSti + sending(1).filNavn)
          End If
        End If
      End If
      sending(1).filSti = nyMappe + "\"
      sending(1).filNavn = medieNetName + ".pdf"
      f.txtTekst.AppendText("Danner description fil til medienet og sender via mail til aviser der ikke er på medienet." & vbCrLf)
      receivers.Append("receivers=")
      For i As Integer = 1 To antalAviser
        sending(i).filSti = sending(1).filSti
        sending(i).filNavn = sending(1).filNavn
        sending(i).fejl = False
        If sending(i).skalSendes = True Then
          If sending(i).medieNetID.Length > 0 Then
            If Not InStr(receivers.ToString, sending(i).medieNetID & ";") > 0 Then
              receivers.Append(sending(i).medieNetID)
              receivers.Append(";")
              scriptFile.Append("MNF.BureauOrdrenummer.")
              scriptFile.Append(sending(i).medieNetID)
              scriptFile.Append("=")
              scriptFile.Append(medieNetName)
              scriptFile.AppendFormat(vbCrLf)
              scriptFile.Append("MNF.IndrykningsUge.")
              scriptFile.Append(sending(i).medieNetID)
              scriptFile.Append("=")
              scriptFile.Append(_sendeUge)
              scriptFile.AppendFormat(vbCrLf)
              scriptFile.Append("MNF.VersionInfo.")
              scriptFile.Append(sending(i).medieNetID)
              scriptFile.Append("=")
              If sending(i).erSendt Then
                scriptFile.Append("J")
              Else
                scriptFile.Append("N")
              End If
              scriptFile.AppendFormat(vbCrLf)
              checkTekst.Append("Sendt via Medienet til " + sending(i).bladNavn)
              checkTekst.AppendFormat(vbCrLf)
            End If
          Else
            f.txtTekst.AppendText(sending(i).bladNavn + " skal have filen via e-mail.")
            Dim eMail As New clsEmail()
            eMail.Til = sending(i).eMail
            eMail.From = _afsender
            eMail.BodyMappe = nyMappe
            eMail.BodyFilNavn = "MaterialeEmail" + i.ToString()
            If sending(i).erSendt = True Then
              eMail.Subject = "NYT materiale til ordre " + sending(i).materialeID
              eMail.Body = "<h2>" + sending(i).bladNavn + "</h2><br><br>" + "NYT materiale til ordre " + sending(i).materialeID
            Else
              eMail.Subject = "Materiale til ordre " + sending(i).materialeID
              eMail.Body = "<h2>" + sending(i).bladNavn + "</h2><br><br>" + "Materiale til ordre " + sending(i).materialeID
            End If
            eMail.VedhæftetFilSti = sending(1).filSti + sending(1).filNavn
            eMail.Send()
            f.txtTekst.AppendText(sending(i).bladNavn + " har fået tilsendt filen via e-mail.")
            checkTekst.Append("Sendt via eMail til " + sending(i).bladNavn)
            checkTekst.AppendFormat(vbCrLf)
          End If
        End If
      Next
      receiversString = receivers.ToString()
      receiversString = receiversString.Remove(receiversString.Length - 1, 1)
      If receiversString <> "receivers" Then
        scriptFile.Append("MNF.Kontakt=")
        scriptFile.Append(_kontakt)
        scriptFile.AppendFormat(vbCrLf)
        scriptFile.Append("MNF.email=")
        scriptFile.Append(_afsender)
        scriptFile.AppendFormat(vbCrLf)
        scriptFile.Append("MNF.Tlf=35259595")
        scriptFile.AppendFormat(vbCrLf)
        scriptFile.Append("MNF.Annoncoer=")
        scriptFile.Append(_kundeNavn)
        scriptFile.AppendFormat(vbCrLf)
        scriptFile.Append("MNF.Hoejde=")
        scriptFile.Append(_hoejde)
        scriptFile.AppendFormat(vbCrLf)
        scriptFile.Append("MNF.Bredde=")
        scriptFile.Append(_bredde)
        scriptFile.AppendFormat(vbCrLf)
        scriptFile.Append("MNF.Farve=")
        scriptFile.Append(_farve)
        scriptFile.AppendFormat(vbCrLf)
        Dim myFile As New StreamWriter("H:\dsc")
        myFile.WriteLine(receiversString)
        myFile.WriteLine(scriptFile.ToString())
        myFile.Close()
        Dim ftp As New Ftp()
        ftp.Passive = True
        AddHandler ftp.CommandSent, AddressOf ftp_CommandSent
        AddHandler ftp.ResponseRead, AddressOf ftp_ResponseRead
        AddHandler ftp.StateChanged, AddressOf ftp_StateChanged
        AddHandler ftp.TransferProgress, AddressOf ftp_TransferProgress
        Try
          Try
            f.txtTekst.AppendText("Forsøger Connection ..." & vbCrLf)
            Dim ar As IAsyncResult = ftp.BeginConnect("www.medienet.net", 21, Nothing, Nothing)
            While Not ar.IsCompleted
              Application.DoEvents()
              System.Threading.Thread.Sleep(1)
            End While
            ftp.EndConnect(ar)
            f.txtTekst.AppendText("Connection lykkedes...." & vbCrLf)
          Catch ex As Exception
            f.txtTekst.AppendText("FEJL!!! Connection mislykkedes...." & vbCrLf)
            Throw (ex)
          End Try
          Try
            f.txtTekst.AppendText("Forsøger Login ..." & vbCrLf)
            Dim ar As IAsyncResult = ftp.BeginLogin("distrikt", "hj47yg", Nothing, Nothing)
            While Not ar.IsCompleted
              Application.DoEvents()
              System.Threading.Thread.Sleep(1)
            End While
            ftp.EndLogin(ar)
            f.txtTekst.AppendText("Login lykkedes...." & vbCrLf)
          Catch ex As Exception
            f.txtTekst.AppendText("FEJL!!! Login mislykkedes...." & vbCrLf)
            Throw (ex)
          End Try
          Try
            f.txtTekst.AppendText("Forsøger at sætte TransferType til Binary ..." & vbCrLf)
            ftp.TransferType = FtpTransferType.Binary
            'Dim ar As IAsyncResult = ftp.BeginSetTransferType(FtpTransferType.Binary, Nothing, Nothing)
            'While Not ar.IsCompleted
            '  Application.DoEvents()
            '  System.Threading.Thread.Sleep(1)
            'End While
            'ftp.EndSetTransferType(ar)
            f.txtTekst.AppendText("TransferType er sat til Binary...." & vbCrLf)
          Catch ex As Exception
            f.txtTekst.AppendText("FEJL!!! TransferType kunne ikke sættes til Binary...." & vbCrLf)
            Throw (ex)
          End Try
          Try
            f.txtTekst.AppendText("Forsøger at oprette mappen " + Chr(34) + medieNetName + ".pdf" + Chr(34) + " på serveren ..." & vbCrLf)
            Dim ar As IAsyncResult = ftp.BeginCreateDirectory(medieNetName + ".pdf", Nothing, Nothing)
            While Not ar.IsCompleted
              Application.DoEvents()
              System.Threading.Thread.Sleep(1)
            End While
            ftp.EndCreateDirectory(ar)
            f.txtTekst.AppendText("Mappen er oprettet...." & vbCrLf)
          Catch ex As Exception
            Dim fx As FtpException = TryCast(ex, FtpException)
            If fx.Status = FtpExceptionStatus.ProtocolError AndAlso fx.Response.Code = 521 Then
              f.txtTekst.AppendText("Mappen findes allerede. Oprettes ikke.")
            Else
              f.txtTekst.AppendText("FEJL!!! Mappen kunne ikke oprettes...." & vbCrLf)
              Throw (ex)
            End If
          End Try
          Try
            f.txtTekst.AppendText("Forsøger at skifte til mappen " + Chr(34) + medieNetName + ".pdf" + Chr(34) + " på serveren ..." & vbCrLf)
            Dim ar As IAsyncResult = ftp.BeginChangeDirectory(medieNetName + ".pdf", Nothing, Nothing)
            While Not ar.IsCompleted
              Application.DoEvents()
              System.Threading.Thread.Sleep(1)
            End While
            ftp.EndChangeDirectory(ar)
            f.txtTekst.AppendText("Der er skiftet til mappen...." & vbCrLf)
          Catch ex As Exception
            f.txtTekst.AppendText("FEJL!!! Der kunne ikke skiftes til mappen...." & vbCrLf)
            Throw (ex)
          End Try
          Dim directory As New DirectoryInfo(sending(1).filSti)
          Dim list As FileInfo() = directory.GetFiles()
          fileSize = 0
          For c As Integer = 0 To list.Length - 1
            If list(c).Name = sending(1).filNavn Then
              fileSize = list(c).Length
            End If
          Next
          While Not success
            Try
              f.txtTekst.AppendText("Forsøger at uploade filen " + Chr(34) + sending(1).filNavn + Chr(34) + " på serveren " + retry.ToString() + ". gang ..." & vbCrLf)
              Dim ar As IAsyncResult = ftp.BeginPutFile(sending(1).filSti + sending(1).filNavn, medieNetName + ".pdf", Nothing, Nothing)
              While Not ar.IsCompleted
                Application.DoEvents()
                System.Threading.Thread.Sleep(1)
              End While
              ftp.EndPutFile(ar)
              f.txtTekst.AppendText("Filen er overført...." & vbCrLf)
              success = True
            Catch ex As Exception
              f.txtTekst.AppendText("FEJL!!! Filen kunne ikke overføres...." & vbCrLf)
              retry += 1
              If retry = 4 Then
                Throw (ex)
              End If
            End Try
          End While
          retry = 1
          success = False
          While Not success
            Try
              f.txtTekst.AppendText("Forsøger at uploade description filen på serveren " + retry.ToString() + ". gang ..." & vbCrLf)
              Dim ar As IAsyncResult = ftp.BeginPutFile("H:\dsc", "dsc", Nothing, Nothing)
              While Not ar.IsCompleted
                Application.DoEvents()
                System.Threading.Thread.Sleep(1)
              End While
              ftp.EndPutFile(ar)
              f.txtTekst.AppendText("Description filen er overført...." & vbCrLf)
              success = True
            Catch ex As Exception
              f.txtTekst.AppendText("FEJL!!! Description filen kunne ikke overføres...." & vbCrLf)
              retry += 1
              If retry = 4 Then
                Throw (ex)
              End If
            End Try
          End While
          retry = 1
          success = False
          fileSize = 1
          While Not success
            Try
              f.txtTekst.AppendText("Forsøger at uploade done filen på serveren " + retry.ToString() + ". gang ..." & vbCrLf)
              Dim ar As IAsyncResult = ftp.BeginPutFile("H:\done", "done", Nothing, Nothing)
              While Not ar.IsCompleted
                Application.DoEvents()
                System.Threading.Thread.Sleep(1)
              End While
              ftp.EndPutFile(ar)
              f.txtTekst.AppendText("Done filen er overført...." & vbCrLf)
              success = True
            Catch ex As Exception
              f.txtTekst.AppendText("FEJL!!! Done filen kunne ikke overføres...." & vbCrLf)
              retry += 1
              If retry = 4 Then
                Throw (ex)
              End If
            End Try
          End While
          ftp.Disconnect()
        Catch
          masterError = True
          For i As Integer = 1 To antalAviser
            sending(i).fejl = True
          Next
        End Try
      End If
    Else
      f.txtTekst.AppendText("FORSKELLIGT MATERIALE..." & vbCrLf)
      Dim receivers As String
      Dim ftp As New Ftp()
      ftp.Passive = True
      AddHandler ftp.CommandSent, AddressOf ftp_CommandSent
      AddHandler ftp.ResponseRead, AddressOf ftp_ResponseRead
      AddHandler ftp.StateChanged, AddressOf ftp_StateChanged
      AddHandler ftp.TransferProgress, AddressOf ftp_TransferProgress
      Try
        Try
          f.txtTekst.AppendText("Forsøger Connection ..." & vbCrLf)
          Dim ar As IAsyncResult = ftp.BeginConnect("www.medienet.net", 21, Nothing, Nothing)
          While Not ar.IsCompleted
            Application.DoEvents()
            System.Threading.Thread.Sleep(1)
          End While
          ftp.EndConnect(ar)
          f.txtTekst.AppendText("Connection lykkedes...." & vbCrLf)
        Catch ex As Exception
          f.txtTekst.AppendText("FEJL!!! Connection mislykkedes...." & vbCrLf)
          Throw (ex)
        End Try
        Try
          f.txtTekst.AppendText("Forsøger Login ..." & vbCrLf)
          Dim ar As IAsyncResult = ftp.BeginLogin("distrikt", "hj47yg", Nothing, Nothing)
          While Not ar.IsCompleted
            Application.DoEvents()
            System.Threading.Thread.Sleep(1)
          End While
          ftp.EndLogin(ar)
          f.txtTekst.AppendText("Login lykkedes...." & vbCrLf)
        Catch ex As Exception
          f.txtTekst.AppendText("FEJL!!! Login mislykkedes...." & vbCrLf)
          Throw (ex)
        End Try
        Try
          f.txtTekst.AppendText("Forsøger at sætte TransferType til Binary ..." & vbCrLf)
          ftp.TransferType = FtpTransferType.Binary
          'Dim ar As IAsyncResult = ftp.BeginSetTransferType(FtpTransferType.Binary, Nothing, Nothing)
          'While Not ar.IsCompleted
          '  Application.DoEvents()
          '  System.Threading.Thread.Sleep(1)
          'End While
          'ftp.EndSetTransferType(ar)
          f.txtTekst.AppendText("TransferType er sat til Binary...." & vbCrLf)
        Catch ex As Exception
          f.txtTekst.AppendText("FEJL!!! TransferType kunne ikke sættes til Binary...." & vbCrLf)
          Throw (ex)
        End Try
      Catch exc As Exception
        ErrorMail(exc.Message)
      End Try
      For i As Integer = 1 To antalAviser
        sending(i).fejl = True
        If sending(i).skalSendes = True Then
          Dim medieNetName As String = sending(i).materialeID
          For j As Integer = antalAviser To i + 1 Step -1
            If sending(i).filNavn = sending(j).filNavn AndAlso sending(i).filSti = sending(j).filSti AndAlso sending(j).skalSendes = True Then
              File.Copy(sending(j).filSti + sending(j).filNavn, sending(j).filSti + sending(j).materialeID + ".pdf", True)
              sending(j).filNavn = sending(j).materialeID + ".pdf"
            End If
          Next
          If Not File.Exists(nyMappe + "\" + medieNetName + ".pdf") Then
            File.Move(sending(i).filSti + sending(i).filNavn, nyMappe + "\" + medieNetName + ".pdf")
          Else
            If sending(i).filSti + sending(i).filNavn <> nyMappe + "\" + medieNetName + ".pdf" Then
              File.Copy(sending(i).filSti + sending(i).filNavn, nyMappe + "\" + medieNetName + ".pdf", True)
              If Not sending(i).filSti.StartsWith("Z:\AnnoncematerialeUdsendt") Then
                File.Delete(sending(i).filSti + sending(i).filNavn)
              End If
            End If
          End If
          sending(i).filSti = nyMappe + "\"
          sending(i).filNavn = medieNetName + ".pdf"
          Dim scriptFile As New StringBuilder(100)
          If sending(i).medieNetID.Length > 0 Then
            receivers = "receivers=" + (sending(i).medieNetID)
            scriptFile.Append("MNF.BureauOrdrenummer.")
            scriptFile.Append(sending(i).medieNetID)
            scriptFile.Append("=")
            scriptFile.Append(medieNetName)
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.IndrykningsUge.")
            scriptFile.Append(sending(i).medieNetID)
            scriptFile.Append("=")
            scriptFile.Append(_sendeUge)
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.VersionInfo.")
            scriptFile.Append(sending(i).medieNetID)
            scriptFile.Append("=")
            If sending(i).erSendt Then
              scriptFile.Append("J")
            Else
              scriptFile.Append("N")
            End If
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.Kontakt=")
            scriptFile.Append(_kontakt)
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.email=")
            scriptFile.Append(_afsender)
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.Tlf=35259595")
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.Annoncoer=")
            scriptFile.Append(_kundeNavn)
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.Hoejde=")
            scriptFile.Append(_hoejde)
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.Bredde=")
            scriptFile.Append(_bredde)
            scriptFile.AppendFormat(vbCrLf)
            scriptFile.Append("MNF.Farve=")
            scriptFile.Append(_farve)
            scriptFile.AppendFormat(vbCrLf)
            Dim myFile As New StreamWriter("H:\dsc")
            myFile.WriteLine(receivers)
            myFile.WriteLine(scriptFile.ToString())
            myFile.Close()
            Try
              Try
                f.txtTekst.AppendText("Forsøger at oprette mappen " + Chr(34) + medieNetName + ".pdf" + Chr(34) + " på serveren ..." & vbCrLf)
                Dim ar As IAsyncResult = ftp.BeginCreateDirectory(medieNetName + ".pdf", Nothing, Nothing)
                While Not ar.IsCompleted
                  Application.DoEvents()
                  System.Threading.Thread.Sleep(1)
                End While
                ftp.EndCreateDirectory(ar)
                f.txtTekst.AppendText("Mappen er oprettet...." & vbCrLf)
              Catch ex As Exception
                Dim fx As FtpException = TryCast(ex, FtpException)
                If fx.Status = FtpExceptionStatus.ProtocolError AndAlso fx.Response.Code = 521 Then
                  f.txtTekst.AppendText("Mappen findes allerede. Oprettes ikke.")
                Else
                  f.txtTekst.AppendText("FEJL!!! Mappen kunne ikke oprettes...." & vbCrLf)
                  Throw (ex)
                End If
              End Try
              Try
                f.txtTekst.AppendText("Forsøger at skifte til mappen " + Chr(34) + medieNetName + ".pdf" + Chr(34) + " på serveren ..." & vbCrLf)
                Dim ar As IAsyncResult = ftp.BeginChangeDirectory(medieNetName + ".pdf", Nothing, Nothing)
                While Not ar.IsCompleted
                  Application.DoEvents()
                  System.Threading.Thread.Sleep(1)
                End While
                ftp.EndChangeDirectory(ar)
                f.txtTekst.AppendText("Der er skiftet til mappen...." & vbCrLf)
              Catch ex As Exception
                f.txtTekst.AppendText("FEJL!!! Der kunne ikke skiftes til mappen...." & vbCrLf)
                Throw (ex)
              End Try
              Dim directory As New DirectoryInfo(sending(i).filSti)
              Dim list As FileInfo() = directory.GetFiles()
              fileSize = 0
              For c As Integer = 0 To list.Length - 1
                If list(c).Name = sending(i).filNavn Then
                  fileSize = list(c).Length
                End If
              Next
              retry = 1
              success = False
              While Not success
                Try
                  f.txtTekst.AppendText("Forsøger at uploade filen " + Chr(34) + sending(i).filNavn + Chr(34) + " på serveren " + retry.ToString() + ". gang ..." & vbCrLf)
                  Dim ar As IAsyncResult = ftp.BeginPutFile(sending(i).filSti + sending(i).filNavn, medieNetName + ".pdf", Nothing, Nothing)
                  While Not ar.IsCompleted
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(1)
                  End While
                  ftp.EndPutFile(ar)
                  f.txtTekst.AppendText("Filen er overført...." & vbCrLf)
                  success = True
                Catch ex As Exception
                  f.txtTekst.AppendText("FEJL!!! Filen kunne ikke overføres...." & vbCrLf)
                  retry += 1
                  If retry = 4 Then
                    Throw (ex)
                  End If
                End Try
              End While
              retry = 1
              success = False
              While Not success
                Try
                  f.txtTekst.AppendText("Forsøger at uploade description filen på serveren " + retry.ToString() + ". gang ..." & vbCrLf)
                  Dim ar As IAsyncResult = ftp.BeginPutFile("H:\dsc", "dsc", Nothing, Nothing)
                  While Not ar.IsCompleted
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(1)
                  End While
                  ftp.EndPutFile(ar)
                  f.txtTekst.AppendText("Description filen er overført...." & vbCrLf)
                  success = True
                Catch ex As Exception
                  f.txtTekst.AppendText("FEJL!!! Description filen kunne ikke overføres...." & vbCrLf)
                  retry += 1
                  If retry = 4 Then
                    Throw (ex)
                  End If
                End Try
              End While
              retry = 1
              success = False
              fileSize = 1
              While Not success
                Try
                  f.txtTekst.AppendText("Forsøger at uploade done filen på serveren " + retry.ToString() + ". gang ..." & vbCrLf)
                  Dim ar As IAsyncResult = ftp.BeginPutFile("H:\done", "done", Nothing, Nothing)
                  While Not ar.IsCompleted
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(1)
                  End While
                  ftp.EndPutFile(ar)
                  f.txtTekst.AppendText("Done filen er overført...." & vbCrLf)
                  success = True
                Catch ex As Exception
                  f.txtTekst.AppendText("FEJL!!! Done filen kunne ikke overføres...." & vbCrLf)
                  retry += 1
                  If retry = 4 Then
                    Throw (ex)
                  End If
                End Try
              End While
              Try
                f.txtTekst.AppendText("Forsøger at skifte tilbage til hovedmappen på serveren ..." & vbCrLf)
                Dim ar As IAsyncResult = ftp.BeginChangeDirectory("..", Nothing, Nothing)
                While Not ar.IsCompleted
                  Application.DoEvents()
                  System.Threading.Thread.Sleep(1)
                End While
                ftp.EndChangeDirectory(ar)
                f.txtTekst.AppendText("Der er skiftet tilbage til hovedmappen...." & vbCrLf)
              Catch ex As Exception
                f.txtTekst.AppendText("FEJL!!! Der kunne ikke skiftes tilbage til hovedmappen...." & vbCrLf)
                Throw (ex)
              End Try
            Catch exc As Exception
              masterError = True
              checkTekst.Append("FEJL!!! Ikke sendt via Medienet til " + sending(i).bladNavn + " Fejlmed.: " + exc.Message)
              checkTekst.AppendFormat(vbCrLf)
              success = False
            End Try
            If success Then
              sending(i).fejl = False
              checkTekst.Append("Sendt via Medienet til " + sending(i).bladNavn)
              checkTekst.AppendFormat(vbCrLf)
            Else
              sending(i).fejl = True
              bladFejl = bladFejl + sending(i).bladNavn + "<br>"
            End If
          Else
            f.txtTekst.AppendText(sending(i).bladNavn + " skal have filen via e-mail..." & vbCrLf)
            Dim eMail As New clsEmail()
            eMail.Til = sending(i).eMail
            eMail.From = _afsender
            eMail.BodyMappe = nyMappe
            eMail.BodyFilNavn = "MaterialeEmail" + i.ToString()
            If sending(i).erSendt = True Then
              eMail.Subject = "NYT materiale til ordre " + sending(i).materialeID
              eMail.Body = "<h2>" + sending(i).bladNavn + "</h2><br><br>" + "NYT materiale til ordre " + sending(i).materialeID
            Else
              eMail.Subject = "Materiale til ordre " + sending(i).materialeID
              eMail.Body = "<h2>" + sending(i).bladNavn + "</h2><br><br>" + "Materiale til ordre " + sending(i).materialeID
            End If
            eMail.VedhæftetFilSti = sending(i).filSti + sending(i).filNavn
            eMail.Send()
            f.txtTekst.AppendText(sending(i).bladNavn + " har fået tilsendt filen via e-mail..." & vbCrLf)
            sending(i).fejl = False
            checkTekst.Append("Sendt via eMail til " + sending(i).bladNavn)
            checkTekst.AppendFormat(vbCrLf)
          End If
        End If
      Next
      ftp.Disconnect()
    End If
    Dim eMailKopi As String() = New String(antalAviser) {}
    For i As Integer = 1 To antalAviser
      eMailKopi(i) = sending(i).eMail
    Next
    For i As Integer = 1 To antalAviser
      If sending(i).skalSendes AndAlso Not sending(i).fejl Then
        If sending(i).medieNetID.Length > 0 Then
          If eMailKopi(i).Length > 0 Then
            Dim eMail As New clsEmail()
            Dim htmlTekst As New StringBuilder(200)
            eMail.Til = eMailKopi(i)
            eMail.From = _afsender
            eMail.BodyMappe = nyMappe
            eMail.BodyFilNavn = "MaterialeBesked" + i.ToString()
            htmlTekst.Append("<h2>Husk at materialet skal hentes inden <b>3 dage.</b></h2>")
            If sending(i).erSendt = True Then
              eMail.Subject = "Der er sendt NYT materiale til ordre " & sending(i).materialeID & " på medienet."
              htmlTekst.Append("Der er sendt NYT materiale til ordre " & sending(i).materialeID & " på medienet.<br><br>")
            Else
              eMail.Subject = "Der er sendt materiale til ordre " & sending(i).materialeID & " på medienet."
              htmlTekst.Append("Der er sendt materiale til ordre " & sending(i).materialeID & " på medienet.<br><br>")
            End If
            htmlTekst.Append("Materiale til følgende aviser:<br>")
            For j As Integer = i To antalAviser
              If eMailKopi(i) = eMailKopi(j) Then
                If sending(j).skalSendes Then
                  If sending(j).medieNetID.Length > 0 Then
                    htmlTekst.Append(sending(j).bladNavn & "<br>")
                    checkTekst.Append("Mail sendt til " & sending(j).bladNavn)
                    checkTekst.AppendFormat(vbCrLf)
                  End If
                  sending(j).skalSendes = False
                  sending(j).erSendt = True
                End If
                eMailKopi(j) = ""
              End If
            Next
            eMail.Body = htmlTekst.ToString()
            eMail.Send()
            checkTekst.Append(htmlTekst.ToString().Replace("<br>", vbCrLf))
            checkTekst.AppendFormat(vbCrLf)
            checkTekst.AppendFormat(vbCrLf)
          End If
        End If
        sending(i).skalSendes = False
        sending(i).erSendt = True
      End If
    Next
    f.txtTekst.AppendText(checkTekst.ToString())
    SaveData()
    FyldData()
    Cursor.Current = Cursors.Default
    f.btnLuk.Enabled = True
    btnSendMateriale.Enabled = True
    btnSkiftDirectory.Enabled = True
    btnLuk.Enabled = True
    If masterError Then
      timer.Enabled = True
    Else
      Dim checkFil As New StreamWriter(nyMappe + "\CheckTekst.txt")
      checkFil.Write(f.txtTekst.Text)
      checkFil.Close()
      pbTransfer.Visible = False
      f.pgbFile.Visible = False
    End If
  End Sub

  Private Sub ErrorMail(ByVal fejlTekst As String)
    Dim eMail As New clsEmail()
    storeData()
    eMail.Til = "C_ews@hotmail.com"
    eMail.From = "error@materialesender.dk"
    eMail.BodyMappe = "Z:\Errors"
    eMail.BodyFilNavn = "Error" & Me._medieplanNr.ToString()
    eMail.Body = "Der opstod en fejl med teksten: " + Chr(34) & fejlTekst & Chr(34) & vbCrLf & vbCrLf & "Logfil for udsending:" & vbCrLf & f.txtTekst.Text
    eMail.Subject = "Fejl ved udsendelse af materiale til ordre " & Me._medieplanNr.ToString()
    eMail.Send()
    MessageBox.Show("Der opstod en uventet fejl med teksten:" & vbCrLf & fejlTekst & vbCrLf & "Mail er sendt til Carl-Erik.")
    Application.Exit()
  End Sub

  Private Sub ErrorMail2(ByVal fejlTekst As String)
    Dim eMail As New clsEmail()
    storeData()
    eMail.Til = _afsender
    eMail.From = "error@materialesender.dk"
    eMail.BodyMappe = "Z:\Errors"
    eMail.BodyFilNavn = "Error" & Me._medieplanNr.ToString()
    eMail.Body = "Følgende blade har ikke fået materiale:" & vbCrLf & " " & fejlTekst
    eMail.Subject = "Fejl ved udsendelse af materiale til ordre " & Me._medieplanNr.ToString()
    eMail.Send()
    MessageBox.Show("Der opstod en fejl ved udsendelsen." & vbCrLf & "Mail er sendt til din indbakke.")
  End Sub

  Private Sub SaveData()
    Cursor.Current = Cursors.WaitCursor
    [error] = False
    For i As Integer = 1 To antalAviser
      If chkSammeFil.Checked Then
        sending(i).filNavn = sending(1).filNavn
        sending(i).filSti = sending(1).filSti
      End If
    Next
    If Not [error] Then
      Cursor.Current = Cursors.WaitCursor
      storeData()
    End If
    Cursor.Current = Cursors.Default
  End Sub

  Private Sub storeData()
    Dim antalSendte As Integer = 0
    sqlDelMateriale.Parameters("@MedieplanNr").Value = _medieplanNr
    sqlConn.Open()
    sqlDelMateriale.ExecuteNonQuery()
    For i As Integer = 1 To antalAviser
      sqlInsertMateriale.Parameters("@MedieplanNr").Value = _medieplanNr
      sqlInsertMateriale.Parameters("@BladID").Value = sending(i).bladID
      sqlInsertMateriale.Parameters("@FilNavn").Value = sending(i).filNavn
      sqlInsertMateriale.Parameters("@ErSendt").Value = sending(i).erSendt
      sqlInsertMateriale.Parameters("@filSti").Value = sending(i).filSti
      sqlInsertMateriale.Parameters("@skalSendes").Value = sending(i).skalSendes
      sqlInsertMateriale.ExecuteNonQuery()
      If sending(i).erSendt Then
        antalSendte += 1
      End If
    Next
    sqlConn.Close()
  End Sub

  Private Sub btnLuk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuk.Click
    SaveData()
    If Not [error] Then
      Me.Close()
    End If
  End Sub

  Private Sub lblAvisnavn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAvisnavn1.Click
    Dim lb As Label = DirectCast(sender, Label)
    Dim controlNr As Integer = Int32.Parse(lb.Tag.ToString())
    currentAvis = controlNr
    SetCurrent()
  End Sub

  Private Sub SetCurrent()
    For Each ctl As Control In pnlControls.Controls
      If ctl.Name = "lblAvisnavn" + currentAvis.ToString() Then
        ctl.BackColor = System.Drawing.SystemColors.Highlight
        ctl.ForeColor = System.Drawing.SystemColors.HighlightText
        Continue For
      End If
      If ctl.Name = "lblAvisnavn" + previousAvis.ToString() Then
        ctl.BackColor = System.Drawing.SystemColors.Control
        ctl.ForeColor = System.Drawing.SystemColors.ControlText
        Continue For
      End If
    Next
    previousAvis = currentAvis
  End Sub

  Private Sub toggleVisible(ByVal synlig As Boolean)
    pnlControls.SuspendLayout()
    For i As Integer = 1 To antalAviser
      For Each ctl As Control In pnlControls.Controls
        If ctl.Name = "txtFilnavn" + i.ToString() OrElse ctl.Name = "chkSend" + i.ToString() OrElse ctl.Name = "chkErSendt" + i.ToString() Then
          ctl.Visible = synlig
        End If
      Next
    Next
    pnlControls.ResumeLayout()
    lblErSendt.Visible = synlig
    chkSendAlle.Visible = synlig
    lblSendAlle.Visible = synlig
    chkSammeFil.Visible = synlig
    lblFilnavn.Visible = synlig
  End Sub

  Private Sub ftp_CommandSent(ByVal sender As Object, ByVal e As FtpCommandSentEventArgs)
    f.txtTekst.AppendText("Sendt kommando : " & e.Command & vbCrLf)
  End Sub

  Private Sub ftp_ResponseRead(ByVal sender As Object, ByVal e As FtpResponseReadEventArgs)
    f.txtTekst.AppendText("Modtaget svar : " & e.Response & vbCrLf)
  End Sub

  Private Sub ftp_StateChanged(ByVal sender As Object, ByVal e As FtpStateChangedEventArgs)
    f.txtTekst.AppendText("Status ændret fra : " & e.OldState & " til " & e.NewState & vbCrLf)
  End Sub

  Private Sub ftp_TransferProgress(ByVal sender As Object, ByVal e As FtpTransferProgressEventArgs)
    If e.State <> FtpTransferState.None AndAlso fileSize > 0 Then
      Dim index As Decimal = CDec(e.BytesTransfered) / CDec(fileSize)
      pbTransfer.Value = CInt((index * pbTransfer.Maximum))
      f.pgbFile.Value = CInt((index * f.pgbFile.Maximum))
      Application.DoEvents()
    End If
  End Sub

  Private Sub timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer.Tick
    timer.Enabled = False
    masterRetry += 1
    If masterRetry < 4 Then
      btnSendMateriale.PerformClick()
    Else
      ErrorMail("3 retry stadig ikke nok!!!")
    End If
  End Sub

End Class

