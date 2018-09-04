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

    Public Function UpdateFakuraBemærkning(Optional ByVal before As String = "", Optional newFakturaBem As String = "", Optional ByVal mediaPlan As Integer = 0) As Boolean


        If Not IsNothing(newFakturaBem) Then



            Dim con As SqlConnection
            Dim cmd As SqlCommand
            Dim row As Integer

            con = New SqlConnection(My.Settings.DiMPdotNetConnectionString)
            cmd = con.CreateCommand()
            con.Open()

            If before.Length > 0 Then
                cmd.CommandText = "update tblMedieplanNr set FakturaBemærkning2=@before,  FakturaBemærkning3 = @fakurabem Where MedieplanNr=@mediePlanNr"

                cmd.Parameters.AddWithValue("@fakurabem", newFakturaBem)
                cmd.Parameters.AddWithValue("@mediePlanNr", mediaPlan)
                cmd.Parameters.AddWithValue("@before", before)

            Else

                cmd.CommandText = "update tblMedieplanNr set  FakturaBemærkning3 = @fakurabem Where MedieplanNr=@mediePlanNr"

                cmd.Parameters.AddWithValue("@fakurabem", newFakturaBem)
                cmd.Parameters.AddWithValue("@mediePlanNr", mediaPlan)


            End If


            row = cmd.ExecuteNonQuery


            If row > 0 Then
                Return True

            Else
                Return False

            End If

        End If




    End Function









End Class