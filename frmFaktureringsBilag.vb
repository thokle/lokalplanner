Imports System.Data.SqlClient

Public Class frmFaktureringsBilag
  Private _medieplanNr As Integer
  Private _opretNy As Boolean
  Private _ugeavisNavn As String
  Private _brugerNavn As String

  Public Sub New(ByVal MedieplanNr As Integer, ByVal OpretNy As Boolean, ByVal UgeavisNavn As String)
    InitializeComponent()
    _medieplanNr = MedieplanNr
    _opretNy = OpretNy
    _ugeavisNavn = UgeavisNavn
    _brugerNavn = frmMain.BrugerNavn
    If Not _opretNy Then
      Me.TblFaktureringsBilagTableAdapter.FillByMedieplanNr(Me.DstFaktureringsBilag.tblFaktureringsBilag, _medieplanNr)
      lblOprettet.Visible = True
      lblOprettetAf.Visible = True
      lblOprettetDato.Visible = True
      chkErRettet.Visible = True
      txtBilagsTekst.ReadOnly = True
      btnAnnuller.Text = "Luk"
      btnGem.Visible = False
      runOnceTimer.Enabled = True
    Else
      lblOprettet.Visible = False
      lblOprettetAf.Visible = False
      lblOprettetDato.Visible = False
      chkErRettet.Visible = False
      txtBilagsTekst.ReadOnly = False
      btnAnnuller.Text = "Annuller"
      btnGem.Visible = True
    End If
  End Sub

  Private Sub tabBilag_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabBilag.SelectedTabChanged
    Me.BindingSource1.Position = e.Tab.Text - 1
  End Sub

  Private Sub btnGem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGem.Click
    If _opretNy Then
      Dim BemærkningsNr As Integer
      Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
      Dim cm As SqlCommand = cn.CreateCommand()
      cm.CommandType = CommandType.Text
      cm.CommandText = "SELECT MAX(BemærkningNr) + 1 AS BemNr FROM tblFaktureringsBilag WHERE (MedieplanNr = " & _medieplanNr.ToString & ")"
      cn.Open()
      If IsDBNull(cm.ExecuteScalar()) Then
        BemærkningsNr = 1
      Else
        BemærkningsNr = cm.ExecuteScalar
      End If
      Me.TblFaktureringsBilagTableAdapter.Insert(_medieplanNr, BemærkningsNr, Now, frmMain.BrugerNavn, "", False, _ugeavisNavn, Now, txtBilagsTekst.Text)
      cm.Dispose()
      cn.Close()
      cn.Dispose()
    End If
    Me.Close()
    Me.Dispose()
  End Sub

  Private Sub txtBilagsTekst_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBilagsTekst.ValueChanged
    If _opretNy Then
      If txtBilagsTekst.TextLength > 0 Then
        btnGem.Enabled = True
      Else
        btnGem.Enabled = False
      End If
    Else
      btnGem.Enabled = False
    End If
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Private Sub frmFaktureringsBilag_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If Not _opretNy Then
      Me.BindingSource1.EndEdit()
      Me.TblFaktureringsBilagTableAdapter.Update(Me.DstFaktureringsBilag.tblFaktureringsBilag)
    End If
  End Sub

  Private Sub chkErRettet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkErRettet.CheckedChanged
    If chkErRettet.Checked Then
      lblRettetAf.Text = _brugerNavn
      lblRettetKl.Text = Now
      lblAf.Visible = True
    Else
      lblRettetAf.Text = ""
      lblAf.Visible = False
    End If
  End Sub

  'Private Sub chkErRettet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkErRettet.Click
  '  If Not chkErRettet.Checked Then   'Click kaldes før Checked har ændret værdi, bagefter kaldes CheckedChanged
  '    lblRettetAf.Text = frmMain.BrugerNavn
  '    lblRettetKl.Text = Now
  '  Else
  '    lblRettetAf.Text = ""
  '  End If
  'End Sub

  Private Sub runOnceTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles runOnceTimer.Tick
    Dim i As Integer

    runOnceTimer.Enabled = False
    For i = 0 To tabBilag.Tabs.Count - 1
      If tabBilag.Tabs(i).Key = "False" Then
        tabBilag.SelectedTab = tabBilag.Tabs(i)
        Exit For
      Else
        tabBilag.Tabs(i).Appearance.BackColor = Color.LawnGreen
      End If
    Next
  End Sub
End Class