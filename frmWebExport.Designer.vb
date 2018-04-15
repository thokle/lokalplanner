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
    Me.btnSendTilWeb = New Infragistics.Win.Misc.UltraButton()
    Me.txtMessages = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.Web = New System.Windows.Forms.WebBrowser()
    Me.pgbEksport = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
    CType(Me.txtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnSendTilWeb
    '
    Me.btnSendTilWeb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.btnSendTilWeb.Location = New System.Drawing.Point(333, 557)
    Me.btnSendTilWeb.Name = "btnSendTilWeb"
    Me.btnSendTilWeb.ShowFocusRect = False
    Me.btnSendTilWeb.ShowOutline = False
    Me.btnSendTilWeb.Size = New System.Drawing.Size(87, 24)
    Me.btnSendTilWeb.TabIndex = 370
    Me.btnSendTilWeb.Text = "&Send til Web"
    Me.btnSendTilWeb.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'txtMessages
    '
    Me.txtMessages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtMessages.Location = New System.Drawing.Point(13, 12)
    Me.txtMessages.Multiline = True
    Me.txtMessages.Name = "txtMessages"
    Me.txtMessages.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtMessages.Size = New System.Drawing.Size(729, 493)
    Me.txtMessages.TabIndex = 372
    '
    'Web
    '
    Me.Web.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Web.Location = New System.Drawing.Point(13, 543)
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
    Me.pgbEksport.Location = New System.Drawing.Point(13, 516)
    Me.pgbEksport.Name = "pgbEksport"
    Me.pgbEksport.Size = New System.Drawing.Size(729, 21)
    Me.pgbEksport.TabIndex = 374
    Me.pgbEksport.Text = "[Formatted]"
    '
    'frmWebExport
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(754, 593)
    Me.Controls.Add(Me.pgbEksport)
    Me.Controls.Add(Me.Web)
    Me.Controls.Add(Me.txtMessages)
    Me.Controls.Add(Me.btnSendTilWeb)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmWebExport"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.Text = "Eksporter stamdata til web"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.txtMessages, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnSendTilWeb As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtMessages As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents Web As System.Windows.Forms.WebBrowser
  Friend WithEvents pgbEksport As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
End Class
