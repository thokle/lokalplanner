Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Data.SqlClient

Public Module basDiverse
  Public Enum StatusKoder
    stsNyMedieplan = 0
    stsMedieplan = 1
    stsOrdreIkkeSendt = 2
    stsUdsendtOrdre = 3
    stsStandsetOrdre = 4
    stsFærdigTjekketOrdre = 5
    stsFaktureretOrdre = 6   '  Ændres til Klar til Fakturering
    stsUbetaltOrdre = 7
    stsAfsluttetOrdre = 99
  End Enum

  Public Structure Udsending
    Public bladID As Integer
    Public bladNavn As String
    Public bureauOrdreNr As String
    Public materialeID As String
    Public filNavn As String
    Public filSti As String
    Public erSendt As Boolean
    Public skalSendes As Boolean
    Public eMail As String
    Public medieNetID As String
    Public fejl As Boolean
  End Structure

  Public Structure GruppeRabat
    Public PlaceringID As Integer
    Public AntalFra As Integer
    Public AntalTil As Integer
    Public MmRabat As Double
    Public FarveRabat As Double
    Public MmPris As Double
    Public FarveTillæg As Double
    Public FarveMin As Double
    Public FarveMax As Double
    Public PrisInclFarver As Double
  End Structure

  Public Structure Gruppe
    Public Navn As String
    Public Type As String
    Public AntalAviserDerSkalVælges As Integer
    Public OrdreModtager As String
    Public MaterialeModtager As String
    Public Valgt As Integer
    Public Rabatter() As GruppeRabat
  End Structure

  Public Structure BladData
    Public BladID As Integer
    Public DæknigsOmrådePostNr() As Integer
    Public MedIGruppe() As Integer
    Public ErTillægsAvis() As Boolean
  End Structure

  Public Structure Grupper
    Public MaxID As Integer
    Public _gruppe() As Gruppe
  End Structure

  Public Structure KonkurrentData
    Friend KonkurrentID As Integer
    Friend KonkurrentNavn As String
    Friend KonkurrentKode As String
  End Structure

  Public KonkurrentDataListe As List(Of KonkurrentData) = New List(Of KonkurrentData)

  Public _gruppeVersion() As Grupper

  Public UgeavisIDListeFraAktivMedieplan As String

  Public LPVersion As String = "2010.10.28.709"

  Public Ugedage() As String = {"Man", "Tir", "Ons", "Tor", "Fre", "Lør", "Søn"}

  Public HentBrugersIndstillinger As Boolean

  Public Function getMedieplanString(ByVal mediePlanNr As Integer, ByVal version As Integer) As String
    Dim medieplanversion As Integer
    Dim bookingplanversion As Integer
    Dim fakturaplanversion As Integer

    If mediePlanNr = 0 Then
      Return Nothing
    Else
      If version < 10 Then
        Return mediePlanNr.ToString & "-" & version.ToString
      ElseIf version < 100 Then
        medieplanversion = Int(version / 10)
        bookingplanversion = version - (medieplanversion * 10)
        Return mediePlanNr.ToString & "-" & medieplanversion.ToString & "-" & bookingplanversion.ToString
      Else
        medieplanversion = Int(version / 100)
        bookingplanversion = Int((version - (medieplanversion * 100)) / 10)
        fakturaplanversion = version - (medieplanversion * 100) - (bookingplanversion * 10)
        Return mediePlanNr.ToString & "-" & medieplanversion.ToString & "-" & bookingplanversion.ToString & "-" & fakturaplanversion.ToString
      End If
    End If
  End Function

  Public Function fjernUlovligeTegnFraString(ByVal inString As String) As String
    Dim temp As String
    temp = inString.Replace("/", "-")
    temp = temp.Replace("\", "-")
    temp = temp.Replace("""", "'")
    temp = temp.Replace(":", "-")
    Return temp
  End Function

  Public Function convertDanishHTML(ByVal htmlString As String) As String
    htmlString = Replace(htmlString, "ø", "&oslash;")
    htmlString = Replace(htmlString, "æ", "&aelig;")
    htmlString = Replace(htmlString, "å", "&aring;")
    htmlString = Replace(htmlString, "Ø", "&Oslash;")
    htmlString = Replace(htmlString, "Æ", "&AElig;")
    htmlString = Replace(htmlString, "Å", "&Aring;")
    htmlString = Replace(htmlString, "ä", "&auml;")
    convertDanishHTML = htmlString
  End Function

  Public Function FindPostBy(ByVal PostNr As Integer) As String
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As New SqlCommand()
    Dim postBy As String
    cm = cn.CreateCommand
    cm.CommandType = CommandType.Text
    cm.CommandText = "SELECT PostBy FROM tblPostNr WHERE (PostNr = " & PostNr & ")"
    cn.Open()
    If IsDBNull(cm.ExecuteScalar) Then
      postBy = "Ukendt"
    Else
      postBy = cm.ExecuteScalar
    End If
    cn.Close()
    cm.Dispose()
    cn.Dispose()
    Return postBy
  End Function

  Public Function BeregnWebChecksum(ByVal BladNavn As String) As Integer
    Dim i As Integer
    Dim checksum As Integer
    '  BladNavn = Trim(BladNavn)

    For i = 1 To Len(BladNavn)
      checksum = (checksum + (Asc(Mid(BladNavn, i, 1)))) Mod 255
    Next
    Return checksum
  End Function


  Public Class ScreenCapture
    Public Function CaptureScreen() As Image
      Return CaptureWindow(User32.GetDesktopWindow())
    End Function

    Public Function CaptureWindow(ByVal handle As IntPtr) As Image
      ' get te hDC of the target window 
      Dim hdcSrc As IntPtr = User32.GetWindowDC(handle)
      ' get the size 
      Dim windowRect As New User32.RECT()
      User32.GetWindowRect(handle, windowRect)
      Dim width As Integer = windowRect.right - windowRect.left
      Dim height As Integer = windowRect.bottom - windowRect.top
      ' create a device context we can copy to 
      Dim hdcDest As IntPtr = GDI32.CreateCompatibleDC(hdcSrc)
      ' create a bitmap we can copy it to, 
      ' using GetDeviceCaps to get the width/height 
      Dim hBitmap As IntPtr = GDI32.CreateCompatibleBitmap(hdcSrc, width, height)
      ' select the bitmap object 
      Dim hOld As IntPtr = GDI32.SelectObject(hdcDest, hBitmap)
      ' bitblt over 
      GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY)
      ' restore selection 
      GDI32.SelectObject(hdcDest, hOld)
      ' clean up 
      GDI32.DeleteDC(hdcDest)
      User32.ReleaseDC(handle, hdcSrc)
      ' get a .NET image object for it 
      Dim img As Image = Image.FromHbitmap(hBitmap)
      ' free up the Bitmap object 
      GDI32.DeleteObject(hBitmap)
      Return img
    End Function
   
    Public Sub CaptureWindowToFile(ByVal handle As IntPtr, ByVal filename As String, ByVal format As ImageFormat)
      Dim img As Image = CaptureWindow(handle)
      img.Save(filename, format)
    End Sub
  
    Public Sub CaptureScreenToFile(ByVal filename As String, ByVal format As ImageFormat)
      Dim img As Image = CaptureScreen()
      img.Save(filename, format)
    End Sub

    Private Class GDI32

      Public Const SRCCOPY As Integer = 13369376
      ' BitBlt dwRop parameter 
      <DllImport("gdi32.dll")> _
      Public Shared Function BitBlt(ByVal hObject As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hObjectSource As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Boolean
      End Function
      <DllImport("gdi32.dll")> _
      Public Shared Function CreateCompatibleBitmap(ByVal hDC As IntPtr, ByVal nWidth As Integer, ByVal nHeight As Integer) As IntPtr
      End Function
      <DllImport("gdi32.dll")> _
      Public Shared Function CreateCompatibleDC(ByVal hDC As IntPtr) As IntPtr
      End Function
      <DllImport("gdi32.dll")> _
      Public Shared Function DeleteDC(ByVal hDC As IntPtr) As Boolean
      End Function
      <DllImport("gdi32.dll")> _
      Public Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
      End Function
      <DllImport("gdi32.dll")> _
      Public Shared Function SelectObject(ByVal hDC As IntPtr, ByVal hObject As IntPtr) As IntPtr
      End Function
    End Class

    Private Class User32
      <StructLayout(LayoutKind.Sequential)> _
      Public Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
      End Structure
      <DllImport("user32.dll")> _
      Public Shared Function GetDesktopWindow() As IntPtr
      End Function
      <DllImport("user32.dll")> _
      Public Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
      End Function
      <DllImport("user32.dll")> _
      Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As IntPtr
      End Function
      <DllImport("user32.dll")> _
      Public Shared Function GetWindowRect(ByVal hWnd As IntPtr, ByRef rect As RECT) As IntPtr
      End Function
    End Class
  End Class
End Module