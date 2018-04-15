Imports System.Data.SqlClient

Public Class frmFakturaRettelse
  Private _medieplanNr As Integer
  Private _version As Integer
  Private _ugeavisID As Integer

  Public Sub New(ByVal medieplanNr As Integer, ByVal version As Integer, ByVal ugeavisID As Integer, ByVal ugeavisNavn As String, ByVal rettelse As String)
    InitializeComponent()
    _medieplanNr = medieplanNr
    _version = version
    _ugeavisID = ugeavisID
    lblRettelse.Text = "På avisen """ & Trim(ugeavisNavn) & """ er der registreret denne ændring:" & vbCrLf & rettelse
  End Sub

  Private Sub frmFakturaRettelse_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnGem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGem.Click
    Me.Cursor = Cursors.WaitCursor
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim versionEt As Integer = (Int(_version / 10) * 10) + 1
    cm.CommandType = CommandType.Text
    Try
      cn.Open()
      cm.CommandText = "INSERT INTO tblFakturaFejl (MedieplanNr, Version, UgeavisID, FejlKode, Ansvarlig) VALUES (" & _medieplanNr.ToString() & "," & _version.ToString() & "," & _ugeavisID.ToString() & "," & cboFejl.Value & ",'" & cboAnsvarlig.Text & "')"
      cm.ExecuteNonQuery()
      cm.CommandText = "DELETE FROM tblFakturaFejl WHERE (MedieplanNr = " & _medieplanNr.ToString() & ") AND (Version = " & versionEt.ToString() & ") AND (UgeavisID = " & _ugeavisID.ToString() & ")"
      cm.ExecuteNonQuery()
      cm.CommandText = "INSERT INTO tblFakturaFejl (MedieplanNr, Version, UgeavisID, FejlKode, Ansvarlig) VALUES (" & _medieplanNr.ToString() & ", " & versionEt.ToString() & ", " & _ugeavisID.ToString() & ", 0,'')"
      cm.ExecuteNonQuery()
    Catch
      MessageBox.Show("Der opstod en fejl da systemet skulle gemme ansvarskode og fejlkode." & vbCrLf & "Fejlkode:" & cboFejl.Value & " Ansvarlig:" & cboAnsvarlig.Text, "Fejl ved Gem", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      cn.Close()
      cn.Dispose()
      Me.Cursor = Cursors.Default
    End Try
    Me.Close()
  End Sub

  Private Sub frmFakturaRettelse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    Dim dr As SqlDataReader

    cm.CommandType = CommandType.Text

    Me.TblFakturaFejlTekstTableAdapter.Fill(Me.DstFakturaFejl.tblFakturaFejlTekst)
    cm.CommandText = "SELECT Code FROM Salesperson WHERE (Status = 0)"
    cn.Open()
    dr = cm.ExecuteReader
    While dr.Read
      cboAnsvarlig.Items.Add(UCase(dr(0).ToString))
    End While
    dr.Close()
    cn.Close()
    cm.Dispose()
    cn.Dispose()
  End Sub

  Private Sub cboFejl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFejl.ValueChanged
    chkValid()
  End Sub

  Private Sub cboAnsvarlig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnsvarlig.SelectedIndexChanged
    chkValid()
  End Sub

  Private Sub chkvalid()
    If cboFejl.Value > 0 AndAlso cboAnsvarlig.Text <> "" Then
      btnGem.Enabled = True
    Else
      btnGem.Enabled = False
    End If
  End Sub
End Class