Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Text.RegularExpressions

Public Class frmOpretKontakt
  Private KontaktID As Integer = 0

  Private Sub frmOpretKontakt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'EjerforholdDropdown.tblBladStamdata' table. You can move, or remove it, as needed.
    Me.TblBladStamdataTableAdapter.Fill(Me.EjerforholdDropdown.tblBladStamdata)
    'TODO: This line of code loads data into the 'DstKontaktArbOmråder.tblKontaktArbOmråder' table. You can move, or remove it, as needed.
    Me.TblKontaktArbOmråderTableAdapter.Fill(Me.DstKontaktArbOmråder.tblKontaktArbOmråder)
    Me.TblBladStamdataKopiTableAdapter.Fill(Me.DstKontakterPrBlad.tblBladStamdataKopi)
    Me.TblKontaktFunktionerTableAdapter.Fill(Me.DstKontaktFunktionerDropdown.tblKontaktFunktioner)
    Me.TblKontaktTitlerTableAdapter.Fill(Me.DstKontaktTitlerDropdown.tblKontaktTitler)

    grdKontakterPrBlad.DrawFilter = New SortIndicatorDrawFilter
  End Sub

  Private Sub grdKontakterPrBlad_AfterRowFixedStateChanged(sender As Object, e As Infragistics.Win.UltraWinGrid.AfterRowFixedStateChangedEventArgs) Handles grdKontakterPrBlad.AfterRowFixedStateChanged
    If e.Row.Fixed Then
      'e.Row.Cells("Titler").EditorComponent = cbeTitler
      e.Row.Cells("Funktioner").EditorComponent = cbeFunktioner
    Else
      'e.Row.Cells("Titler").EditorComponent = Nothing
      e.Row.Cells("Funktioner").EditorComponent = Nothing
    End If
  End Sub

  Private Sub grdKontakterPrBlad_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdKontakterPrBlad.DoubleClickRow
    If e.Row.Fixed Then
      e.Row.Fixed = False
    Else
      e.Row.Fixed = True
    End If
  End Sub

  'Private Sub chkTilknytTilBlade_CheckedChanged(sender As System.Object, e As System.EventArgs)
  '  If chkTilknytTilBlade.CheckState = CheckState.Unchecked Then
  '    grdKontakterPrBlad.Visible = False
  '    'cboArbOmråder.Visible = True
  '  Else
  '    grdKontakterPrBlad.Visible = True
  '    'cboArbOmråder.Visible = False
  '  End If
  'End Sub

  'Private Sub chkTilknytTilBlade_BeforeCheckStateChanged(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
  '  If chkTilknytTilBlade.CheckState = CheckState.Checked Then
  '    If grdKontakterPrBlad.DisplayLayout.Rows.FixedRows.Count > 0 Then
  '      Dim svar As DialogResult = MessageBox.Show("Er du sikker? Hvis du fortsætter," & vbCrLf & "slettes alle tilknytninger på alle aviser!!", "Slet tilknytninger", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
  '      If svar = DialogResult.No Then e.Cancel = True
  '    End If
  '  End If
  'End Sub

  Public Sub New()
    InitializeComponent()

    ToggleOpretEllerRedigere(False)

  End Sub

  Private Function ValidateEmail(ByVal email As String) As Boolean
    'Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
    Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase)
    Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
    Return emailMatch.Success
  End Function

  Private Sub txtEmail_BeforeExitEditMode(sender As Object, e As Infragistics.Win.BeforeExitEditModeEventArgs) Handles txtEmail.BeforeExitEditMode
    If txtEmail.TextLength > 0 Then
      If Not ValidateEmail(txtEmail.Text) Then
        e.Cancel = True
        MessageBox.Show("Fejl i email adresse!", "Indtastningsfejl!", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Else
        KontaktID = 999
        ToggleOpretEllerRedigere(True)
        txtFornavn.Focus()
      End If
    End If
  End Sub

  Private Sub ToggleOpretEllerRedigere(OnOff As Boolean)

    For Each ctl As Control In Me.Controls
      If ctl.Tag = "Toggle" Then
        ctl.Enabled = OnOff
      End If
    Next
    If KontaktID = 0 Then
      Me.Text = "Opret ny kontakt"
    Else
      Me.Text = "Rediger kontakt ID: " & KontaktID.ToString()
    End If
  End Sub

  'Private Sub txtEmail_Leave(sender As Object, e As System.EventArgs) Handles txtEmail.Leave
  '  Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
  '  Dim cm As SqlCommand = cn.CreateCommand()
  '  Dim emailAdr As SqlParameter = cm.CreateParameter()

  '  If KontaktID = 0 Then
  '    If txtEmail.TextLength > 0 AndAlso ValidateEmail(txtEmail.Text) Then
  '      cn.Open()
  '      cm.CommandText = "OpretKontakt"
  '      cm.CommandType = CommandType.StoredProcedure
  '      emailAdr.ParameterName = "@EmailAdr"
  '      emailAdr.Value =lcase( txtEmail.Text)
  '      emailAdr.Direction = ParameterDirection.Input
  '      cm.Parameters.Add(emailAdr)
  '      Try
  '        KontaktID = cm.ExecuteScalar
  '      Catch
  '        KontaktID = 0
  '        MessageBox.Show("Email adresse findes allerede!", "Indtastningsfejl!", MessageBoxButtons.OK, MessageBoxIcon.Error)
  '      End Try
  '      cn.Close()
  '    End If
  '  End If
  '  cm.Dispose()
  '  cn.Dispose()

  '  If KontaktID > 0 Then
  '    ToggleOpretEllerRedigere(True)
  '    txtFornavn.Focus()
  '  Else
  '    txtEmail.Focus()
  '  End If
  'End Sub

  Private Sub btnOpretTitel_Click(sender As System.Object, e As System.EventArgs) Handles btnOpretTitel.Click
    ToggleOpretEllerRedigere(False)
    txtTitel.Visible = True
    txtTitel.Text = ""
    txtTitel.Focus()
    btnAnnullerTitel.Visible = True
    btnGemTitel.Visible = True
    btnOpretArbOmråde.Visible = False
  End Sub

  Private Sub btnAnnullerTitel_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnullerTitel.Click
    txtTitel.Visible = False
    btnAnnullerTitel.Visible = False
    btnGemTitel.Visible = False
    btnOpretArbOmråde.Visible = True
    ToggleOpretEllerRedigere(True)
    txtEmail.Focus()
  End Sub

  Private Sub txtTitel_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtTitel.ValueChanged
    If txtTitel.TextLength > 0 Then
      btnGemTitel.Enabled = True
    Else
      btnGemTitel.Enabled = False
    End If
  End Sub

  Private Sub btnGemTitel_Click(sender As System.Object, e As System.EventArgs) Handles btnGemTitel.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    cn.Open()
    cm.CommandType = CommandType.Text
    cm.CommandText = "INSERT INTO tblKontaktTitler (Titel) VALUES (N'" & Replace(txtTitel.Text, "'", "''") & "')"
    cm.ExecuteNonQuery()
    cm.Dispose()
    cn.Close()
    cn.Dispose()
    Me.TblKontaktTitlerTableAdapter.ClearBeforeFill = True
    Me.TblKontaktTitlerTableAdapter.Fill(Me.DstKontaktTitlerDropdown.tblKontaktTitler)
    txtTitel.Visible = False
    btnAnnullerTitel.Visible = False
    btnGemTitel.Visible = False
    btnOpretArbOmråde.Visible = True
    ToggleOpretEllerRedigere(True)
    txtEmail.Focus()
  End Sub

  Private Sub btnOpretArbOmråde_Click(sender As System.Object, e As System.EventArgs) Handles btnOpretArbOmråde.Click
    ToggleOpretEllerRedigere(False)
    txtArbOmråde.Visible = True
    txtArbOmråde.Text = ""
    txtArbOmråde.Focus()
    btnAnnullerArbOmråde.Visible = True
    btnGemArbOmråde.Visible = True
    btnOpretTitel.Visible = False
  End Sub

  Private Sub btnAnnullerArbOmråde_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnullerArbOmråde.Click
    txtArbOmråde.Visible = False
    btnAnnullerArbOmråde.Visible = False
    btnGemArbOmråde.Visible = False
    btnOpretTitel.Visible = True
    ToggleOpretEllerRedigere(True)
    txtEmail.Focus()
  End Sub

  Private Sub txtArbOmråde_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtArbOmråde.ValueChanged
    If txtArbOmråde.TextLength > 0 Then
      btnGemArbOmråde.Enabled = True
    Else
      btnGemArbOmråde.Enabled = False
    End If
  End Sub

  Private Sub btnGemArbOmråde_Click(sender As System.Object, e As System.EventArgs) Handles btnGemArbOmråde.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    cn.Open()
    cm.CommandType = CommandType.Text
    cm.CommandText = "INSERT INTO tblKontaktArbOmråder (ArbOmråde) VALUES (N'" & Replace(txtArbOmråde.Text, "'", "''") & "')"
    cm.ExecuteNonQuery()
    cm.Dispose()
    cn.Close()
    cn.Dispose()
    Me.TblKontaktArbOmråderTableAdapter.ClearBeforeFill = True
    Me.TblKontaktArbOmråderTableAdapter.Fill(Me.DstKontaktArbOmråder.tblKontaktArbOmråder)

    txtArbOmråde.Visible = False
    btnAnnullerArbOmråde.Visible = False
    btnGemArbOmråde.Visible = False
    btnOpretTitel.Visible = True
    ToggleOpretEllerRedigere(True)
    txtEmail.Focus()
  End Sub


End Class