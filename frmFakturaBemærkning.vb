Imports System.Data.SqlClient

Public Class frmFakturaBemærkning
  Private _medieplanNr As Integer

  Public Sub New(ByVal medieplanNr As Integer)
    InitializeComponent()
    _medieplanNr = medieplanNr
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT FakturaBemærkning1, FakturaBemærkning2, FakturaBemærkning3 FROM tblMedieplanNr WHERE (MedieplanNr = " & medieplanNr.ToString & ")"
    Dim dr As SqlDataReader
    cn.Open()
    dr = cm.ExecuteReader
    dr.Read()
    If IsDBNull(dr("FakturaBemærkning2")) Then
      txtFakturaBemærkning1.Text = ""
    Else
      txtFakturaBemærkning1.Text = dr("FakturaBemærkning2")
    End If
    If IsDBNull(dr("FakturaBemærkning3")) Then
      txtFakturaBemærkning2.Text = ""
    Else
      txtFakturaBemærkning2.Text = dr("FakturaBemærkning3")
    End If
    dr.Close()
    cn.Close()
    cn.Dispose()
    cm.Dispose()
  End Sub

  Private Sub frmFakturaBemærkning_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnGem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGem.Click
    Me.Cursor = Cursors.WaitCursor
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    cm.CommandType = CommandType.Text
    If txtFakturaBemærkning1.TextLength > 0 OrElse txtFakturaBemærkning2.TextLength > 0 Then
      cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBemærkning1 = 'Fakturabemærkning:', FakturaBemærkning2 = '" & txtFakturaBemærkning1.Text.Replace("'", "''") & "', FakturaBemærkning3 = '" & txtFakturaBemærkning2.Text.Replace("'", "''") & "' WHERE (MedieplanNr = " & _medieplanNr.ToString & ")"
    Else
      cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBemærkning1 = '', FakturaBemærkning2 = '', FakturaBemærkning3 = '' WHERE (MedieplanNr = " & _medieplanNr.ToString & ")"
    End If
    cn.Open()
    cm.ExecuteNonQuery()
    cn.Close()
    cn.Dispose()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.Close()
  End Sub
End Class