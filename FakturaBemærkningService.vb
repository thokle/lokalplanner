Imports System.Data
Imports System.Data.SqlClient


Public Class FakturaBemærkningService



    Public Function getFakturaBemærkng(ByVal medispal As Integer) As String

        Dim Sb As System.Text.StringBuilder = New System.Text.StringBuilder

        Dim ta As New dstFakturaBemærkningTableAdapters.tblMedieplanNrTableAdapter
        Dim table As New dstFakturaBemærkning.tblMedieplanNrDataTable





        If ta.Fill(table, medispal) > 0 Then

            If Not String.IsNullOrEmpty(table(0).FakturaBemærkning1) And Not table(0).FakturaBemærkning1.Contains("Fakturabemærkning") Then
                Sb.Append(table(0).FakturaBemærkning1.ToString)
            End If
            If Not String.IsNullOrEmpty(table(0).FakturaBemærkning2) Then
                Sb.Append(table(0).FakturaBemærkning2)
                Sb.Append(" , ")

            End If

            If Not String.IsNullOrEmpty(table(0).FakturaBemærkning3) Then
                Sb.Append(table(0).FakturaBemærkning3)

            End If
        End If
        Return Sb.ToString
    End Function

    Public Function UpdateFakuraBemærkning(ByVal newFakturaBem As String, ByVal mediaPlan As Integer) As Boolean
      

        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim row As Integer
        'Dim str As String
        con = New SqlConnection(My.Settings.DiMPdotNetConnectionString)
        con.Open()
        cmd = New SqlCommand("update tblMedieplanNr set FakturaBemærkning3 = @FakturaBem Where MedieplanNr=@MediaPlanNr")
        cmd.Parameters.AddWithValue("@FakuraBem", newFakturaBem)
        cmd.Parameters.AddWithValue("@MediaPlanNr", mediaPlan)
        row = cmd.ExecuteNonQuery


        If row > 0 Then
            Return True

        Else
            Return False

        End If





    End Function









End Class