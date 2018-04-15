'Imports System.Media

'Namespace My

'  Partial Friend Class MyApplication

'    Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
'      If e.IsNetworkAvailable = False Then
'        MessageBox.Show(frmMain, "Netværket er ikke tilgængeligt." & vbCrLf & "Lokal Planner er nød til at lukke." & vbCrLf & vbCrLf & "Klik på OK for at lukke Lokal Planner.", "Netværks fejl!", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        My.Application.Log.WriteEntry("Netværket er ikke tilgængeligt. Lokal Planner lukket kl. " & My.Computer.Clock.LocalTime.ToString, TraceEventType.Error)
'        System.Windows.Forms.Application.Exit()
'      End If
'    End Sub

'    Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
'      My.Computer.Audio.Play(My.Resources.Jubel, AudioPlayMode.WaitToComplete)
'    End Sub

'    Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
'      MessageBox.Show(frmMain, "Der opstod en uventet fejl." & vbCrLf & "Lokal Planner skal genstartes." & vbCrLf & vbCrLf & "Klik på OK for at lukke Lokal Planner.", "Uventet Fejl!", MessageBoxButtons.OK, MessageBoxIcon.Error)
'      My.Application.Log.WriteException(e.Exception, TraceEventType.Error, "Lokal Planner lukket kl. " & My.Computer.Clock.LocalTime.ToString)
'      e.ExitApplication = True
'    End Sub
'  End Class

'End Namespace

