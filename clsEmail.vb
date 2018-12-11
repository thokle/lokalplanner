Imports System.Globalization
Imports System.IO

Public Class clsEmail
  Public Til As String = ""
  Public From As String = ""
  Public Subject As String = ""
  Public Body As String = ""
  Public VedhæftetFilSti As String = ""
  Public BodyMappe As String = ""
  Public BodyFilNavn As String = ""
  Public BodyTitle As String = ""
  Private sqlInsertMail As System.Data.SqlClient.SqlCommand
  Private sqlConn As System.Data.SqlClient.SqlConnection
  Private writeBody As String = ""
  Private BodySti As String = ""

  Public Sub New()
    Me.sqlConn = New System.Data.SqlClient.SqlConnection()
    Me.sqlInsertMail = New System.Data.SqlClient.SqlCommand()
    Me.sqlConn.ConnectionString = My.Settings.dimpSQLConnectionString
        Me.sqlInsertMail.CommandText = "INSERT INTO tblMail (SendTo, Subject, Body, Attachfile1, SendFrom) VALUES (@Modtager, @Emne, @StiTilTekst, @StiTilPDF, @Afsender)"
    Me.sqlInsertMail.Connection = Me.sqlConn
    Me.sqlInsertMail.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modtager", System.Data.SqlDbType.NVarChar, 50, "SendTo"))
    Me.sqlInsertMail.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Emne", System.Data.SqlDbType.NVarChar, 100, "Subject"))
    Me.sqlInsertMail.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StiTilTekst", System.Data.SqlDbType.NVarChar, 300, "Body"))
    Me.sqlInsertMail.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StiTilPDF", System.Data.SqlDbType.NVarChar, 200, "Attachfile1"))
    Me.sqlInsertMail.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Afsender", System.Data.SqlDbType.NVarChar, 50, "SendFrom"))
  End Sub

  Public Function Send() As Boolean
    If Body.Length > 0 Then
      If BodyTitle.Length = 0 Then
        writeBody = "<HTML><head><meta http-equiv=" & """Content-Type""" & " content=" & """text/html; charset=utf-8""" & "></head><Body>" + convertDanishHTML(Body) + "</Body></HTML>"
      Else
        writeBody = "<HTML><head><meta http-equiv=" & """Content-Type""" & " content=" & """text/html; charset=utf-8""" & "><title>" + convertDanishHTML(BodyTitle) + "</title></head><Body>" + convertDanishHTML(Body) + "</Body></HTML>"
      End If
      Directory.CreateDirectory(BodyMappe)
      BodySti = BodyMappe + "\" + fjernUlovligeTegnFraString(BodyFilNavn) + ".html"
      Dim myFile As New StreamWriter(BodySti)
      myFile.WriteLine(writeBody)
      myFile.Close()
    Else
      BodySti = ""
    End If
    Try
      sqlInsertMail.Parameters("@Modtager").Value = Til ' "nr@delokaleugeaviser.dk" 
      sqlInsertMail.Parameters("@Emne").Value = Subject
      sqlInsertMail.Parameters("@StiTilTekst").Value = BodySti
      sqlInsertMail.Parameters("@StiTilPDF").Value = VedhæftetFilSti
      sqlInsertMail.Parameters("@Afsender").Value = From
      Me.sqlConn.Open()
            sqlInsertMail.ExecuteNonQuery()
    Catch
      Return False
    Finally
      sqlConn.Close()
    End Try
    Return True
  End Function
End Class


