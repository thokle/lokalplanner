<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebExport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWebExport))
    Me.FTP = New AxInetCtlsObjects.AxInet()
    Me.btnSendTilWeb = New Infragistics.Win.Misc.UltraButton()
    Me.FTPPlanner = New AxInetCtlsObjects.AxInet()
    Me.txtMessages = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.Web = New System.Windows.Forms.WebBrowser()
    Me.pgbEksport = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
    CType(Me.FTP, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.FTPPlanner, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'FTP
    '
    Me.FTP.Enabled = True
    Me.FTP.Location = New System.Drawing.Point(13, 371)
    Me.FTP.Name = "FTP"
    Me.FTP.OcxState = CType(resources.GetObject("FTP.OcxState"), System.Windows.Forms.AxHost.State)
    Me.FTP.Size = New System.Drawing.Size(38, 38)
    Me.FTP.TabIndex = 0
    Me.FTP.Visible = False
    '
    'btnSendTilWeb
    '
    Me.btnSendTilWeb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.btnSendTilWeb.Location = New System.Drawing.Point(152, 385)
    Me.btnSendTilWeb.Name = "btnSendTilWeb"
    Me.btnSendTilWeb.ShowFocusRect = False
    Me.btnSendTilWeb.ShowOutline = False
    Me.btnSendTilWeb.Size = New System.Drawing.Size(87, 24)
    Me.btnSendTilWeb.TabIndex = 370
    Me.btnSendTilWeb.Text = "&Send til Web"
    Me.btnSendTilWeb.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'FTPPlanner
    '
    Me.FTPPlanner.Enabled = True
    Me.FTPPlanner.Location = New System.Drawing.Point(343, 371)
    Me.FTPPlanner.Name = "FTPPlanner"
    Me.FTPPlanner.OcxState = CType(resources.GetObject("FTPPlanner.OcxState"), System.Windows.Forms.AxHost.State)
    Me.FTPPlanner.Size = New System.Drawing.Size(38, 38)
    Me.FTPPlanner.TabIndex = 371
    Me.FTPPlanner.Visible = False
    '
    'txtMessages
    '
    Me.txtMessages.Location = New System.Drawing.Point(13, 12)
    Me.txtMessages.Multiline = True
    Me.txtMessages.Name = "txtMessages"
    Me.txtMessages.Size = New System.Drawing.Size(368, 325)
    Me.txtMessages.TabIndex = 372
    '
    'Web
    '
    Me.Web.Location = New System.Drawing.Point(74, 371)
    Me.Web.MinimumSize = New System.Drawing.Size(20, 20)
    Me.Web.Name = "Web"
    Me.Web.ScrollBarsEnabled = False
    Me.Web.Size = New System.Drawing.Size(56, 38)
    Me.Web.TabIndex = 373
    Me.Web.Visible = False
    Me.Web.WebBrowserShortcutsEnabled = False
    '
    'pgbEksport
    '
    Me.pgbEksport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pgbEksport.Location = New System.Drawing.Point(13, 344)
    Me.pgbEksport.Name = "pgbEksport"
    Me.pgbEksport.Size = New System.Drawing.Size(368, 21)
    Me.pgbEksport.TabIndex = 374
    Me.pgbEksport.Text = "[Formatted]"
    '
    'frmWebExport
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(393, 421)
    Me.Controls.Add(Me.pgbEksport)
    Me.Controls.Add(Me.Web)
    Me.Controls.Add(Me.txtMessages)
    Me.Controls.Add(Me.FTPPlanner)
    Me.Controls.Add(Me.btnSendTilWeb)
    Me.Controls.Add(Me.FTP)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmWebExport"
    Me.Text = "Eksporter stamdata til web"
    CType(Me.FTP, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.FTPPlanner, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMessages, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents FTP As AxInetCtlsObjects.AxInet
  Private WithEvents btnSendTilWeb As Infragistics.Win.Misc.UltraButton
  Friend WithEvents FTPPlanner As AxInetCtlsObjects.AxInet
  Friend WithEvents txtMessages As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents Web As System.Windows.Forms.WebBrowser
  Friend WithEvents pgbEksport As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
End Class
