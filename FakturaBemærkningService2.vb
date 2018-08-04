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
                Sb.Append(" ")

            End If

            If Not String.IsNullOrEmpty(table(0).FakturaBemærkning3) Then
                Sb.Append(table(0).FakturaBemærkning3)


            End If
        End If
        Return Sb.ToString
    End Function








End Class
