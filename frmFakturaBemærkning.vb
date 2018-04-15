Imports System.Data.SqlClient

Public Class frmFakturaBem�rkning
  Private _medieplanNr As Integer

  Public Sub New(ByVal medieplanNr As Integer)
    InitializeComponent()
    _medieplanNr = medieplanNr
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT FakturaBem�rkning1, FakturaBem�rkning2, FakturaBem�rkning3 FROM tblMedieplanNr WHERE (MedieplanNr = " & medieplanNr.ToString & ")"
    Dim dr As SqlDataReader
    cn.Open()
    dr = cm.ExecuteReader
    dr.Read()
    If IsDBNull(dr("FakturaBem�rkning2")) Then
      txtFakturaBem�rkning1.Text = ""
    Else
      txtFakturaBem�rkning1.Text = dr("FakturaBem�rkning2")
    End If
    If IsDBNull(dr("FakturaBem�rkning3")) Then
      txtFakturaBem�rkning2.Text = ""
    Else
      txtFakturaBem�rkning2.Text = dr("FakturaBem�rkning3")
    End If
    dr.Close()
    cn.Close()
    cn.Dispose()
    cm.Dispose()
  End Sub

  Private Sub frmFakturaBem�rkning_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnGem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGem.Click
    Me.Cursor = Cursors.WaitCursor
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()
    cm.CommandType = CommandType.Text
    If txtFakturaBem�rkning1.TextLength > 0 OrElse txtFakturaBem�rkning2.TextLength > 0 Then
      cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBem�rkning1 = 'Fakturabem�rkning:', FakturaBem�rkning2 = '" & txtFakturaBem�rkning1.Text.Replace("'", "''") & "', FakturaBem�rkning3 = '" & txtFakturaBem�rkning2.Text.Replace("'", "''") & "' WHERE (MedieplanNr = " & _medieplanNr.ToString & ")"
    Else
      cm.CommandText = "UPDATE tblMedieplanNr SET FakturaBem�rkning1 = '', FakturaBem�rkning2 = '', FakturaBem�rkning3 = '' WHERE (MedieplanNr = " & _medieplanNr.ToString & ")"
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