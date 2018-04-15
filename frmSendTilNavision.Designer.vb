<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendTilNavision
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendTilNavision))
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton
    Me.btnSend = New Infragistics.Win.Misc.UltraButton
    Me.lblUge = New Infragistics.Win.Misc.UltraLabel
    Me.txtUge = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    CType(Me.txtUge, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnAnnuller
    '
    Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 51)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(87, 24)
    Me.btnAnnuller.TabIndex = 340
    Me.btnAnnuller.Text = "&Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnSend
    '
    Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnSend.Enabled = False
    Me.btnSend.Location = New System.Drawing.Point(168, 51)
    Me.btnSend.Name = "btnSend"
    Me.btnSend.ShowFocusRect = False
    Me.btnSend.ShowOutline = False
    Me.btnSend.Size = New System.Drawing.Size(87, 24)
    Me.btnSend.TabIndex = 339
    Me.btnSend.Text = "&Send"
    Me.btnSend.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'lblUge
    '
    Me.lblUge.AutoSize = True
    Me.lblUge.Location = New System.Drawing.Point(12, 12)
    Me.lblUge.Name = "lblUge"
    Me.lblUge.Size = New System.Drawing.Size(191, 14)
    Me.lblUge.TabIndex = 341
    Me.lblUge.Text = "Indtast hvilken uge der skal overføres"
    '
    'txtUge
    '
    Me.txtUge.Location = New System.Drawing.Point(209, 8)
    Me.txtUge.MaxLength = 2
    Me.txtUge.Name = "txtUge"
    Me.txtUge.Nullable = False
    Me.txtUge.Size = New System.Drawing.Size(26, 21)
    Me.txtUge.TabIndex = 342
    '
    'frmSendTilNavision
    '
    Me.AcceptButton = Me.btnSend
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(267, 87)
    Me.Controls.Add(Me.txtUge)
    Me.Controls.Add(Me.lblUge)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnSend)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmSendTilNavision"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Send til Navision"
    Me.TopMost = True
    CType(Me.txtUge, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnSend As Infragistics.Win.Misc.UltraButton
  Friend WithEvents lblUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtUge As Infragistics.Win.UltraWinEditors.UltraTextEditor

End Class
