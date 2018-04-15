Public NotInheritable Class LPSplashScreen

  Private Sub LPSplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    My.Application.MinimumSplashScreenDisplayTime = 5000
    Dim ApplicationTitle As String
    If My.Application.Info.Title <> "" Then
      ApplicationTitle = My.Application.Info.Title
    Else
      ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
    End If
    'Me.Text = String.Format("Om {0}", ApplicationTitle)
    Me.LabelProductName.Text = My.Application.Info.ProductName
    Me.LabelVersion.Text = System.String.Format(LabelVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
    ' Me.LabelVersion.Text = "05:07:18:2008"
    Me.LabelCopyright.Text = My.Application.Info.Copyright
    Me.TextBoxDescription.Text = My.Application.Info.Description
  End Sub

End Class
