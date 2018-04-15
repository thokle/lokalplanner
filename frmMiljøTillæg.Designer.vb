<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiljøTillæg
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMiljøTillæg))
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton()
    Me.btnGem = New Infragistics.Win.Misc.UltraButton()
    Me.lblMiljøtillæg = New Infragistics.Win.Misc.UltraLabel()
    Me.txtMiljøtillæg = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblBemærk = New Infragistics.Win.Misc.UltraLabel()
    CType(Me.txtMiljøtillæg, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnLuk.Location = New System.Drawing.Point(12, 68)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.ShowFocusRect = False
    Me.btnLuk.ShowOutline = False
    Me.btnLuk.Size = New System.Drawing.Size(87, 24)
    Me.btnLuk.TabIndex = 342
    Me.btnLuk.Text = "&Luk"
    Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnGem
    '
    Me.btnGem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGem.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnGem.Enabled = False
    Me.btnGem.Location = New System.Drawing.Point(123, 68)
    Me.btnGem.Name = "btnGem"
    Me.btnGem.ShowFocusRect = False
    Me.btnGem.ShowOutline = False
    Me.btnGem.Size = New System.Drawing.Size(87, 24)
    Me.btnGem.TabIndex = 341
    Me.btnGem.Text = "&Gem"
    Me.btnGem.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    Me.btnGem.Visible = False
    '
    'lblMiljøtillæg
    '
    Me.lblMiljøtillæg.AutoSize = True
    Me.lblMiljøtillæg.Location = New System.Drawing.Point(13, 13)
    Me.lblMiljøtillæg.Name = "lblMiljøtillæg"
    Me.lblMiljøtillæg.Size = New System.Drawing.Size(90, 14)
    Me.lblMiljøtillæg.TabIndex = 343
    Me.lblMiljøtillæg.Text = "Miljø tillæg er kr.:"
    '
    'txtMiljøtillæg
    '
    Me.txtMiljøtillæg.Location = New System.Drawing.Point(109, 9)
    Me.txtMiljøtillæg.Name = "txtMiljøtillæg"
    Me.txtMiljøtillæg.ReadOnly = True
    Me.txtMiljøtillæg.Size = New System.Drawing.Size(36, 21)
    Me.txtMiljøtillæg.TabIndex = 344
    '
    'lblBemærk
    '
    Me.lblBemærk.Location = New System.Drawing.Point(13, 34)
    Me.lblBemærk.Name = "lblBemærk"
    Me.lblBemærk.Size = New System.Drawing.Size(197, 28)
    Me.lblBemærk.TabIndex = 345
    Me.lblBemærk.Text = "Bemærk: Det ændrede miljø tillæg træder i kraft, når du har gemt."
    Me.lblBemærk.Visible = False
    '
    'frmMiljøTillæg
    '
    Me.AcceptButton = Me.btnGem
    Me.AllowDrop = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnLuk
    Me.ClientSize = New System.Drawing.Size(222, 104)
    Me.Controls.Add(Me.lblBemærk)
    Me.Controls.Add(Me.txtMiljøtillæg)
    Me.Controls.Add(Me.lblMiljøtillæg)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.btnGem)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmMiljøTillæg"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Miljø tillæg"
    CType(Me.txtMiljøtillæg, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnGem As Infragistics.Win.Misc.UltraButton
  Friend WithEvents lblMiljøtillæg As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtMiljøtillæg As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblBemærk As Infragistics.Win.Misc.UltraLabel
End Class
