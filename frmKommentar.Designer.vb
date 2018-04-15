<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKommentar
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
    Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKommentar))
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
    Me.btnGem = New Infragistics.Win.Misc.UltraButton()
    Me.txtKommentar = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    CType(Me.txtKommentar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnAnnuller
    '
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(3, 76)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(101, 24)
    Me.btnAnnuller.TabIndex = 381
    Me.btnAnnuller.Text = "Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnGem
    '
    Me.btnGem.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnGem.Enabled = False
    Me.btnGem.Location = New System.Drawing.Point(233, 76)
    Me.btnGem.Name = "btnGem"
    Me.btnGem.ShowFocusRect = False
    Me.btnGem.ShowOutline = False
    Me.btnGem.Size = New System.Drawing.Size(101, 24)
    Me.btnGem.TabIndex = 380
    Me.btnGem.Text = "Gem"
    Me.btnGem.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'txtKommentar
    '
    Me.txtKommentar.Location = New System.Drawing.Point(3, 3)
    Me.txtKommentar.MaxLength = 250
    Me.txtKommentar.Multiline = True
    Me.txtKommentar.Name = "txtKommentar"
    Me.txtKommentar.NullText = "- Skriv en intern Kommentar -"
    Appearance1.TextHAlignAsString = "Center"
    Appearance1.TextVAlignAsString = "Middle"
    Me.txtKommentar.NullTextAppearance = Appearance1
    Me.txtKommentar.Size = New System.Drawing.Size(331, 67)
    Me.txtKommentar.TabIndex = 400
    '
    'frmKommentar
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(337, 105)
    Me.Controls.Add(Me.txtKommentar)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnGem)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmKommentar"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Kommentar"
    Me.TopMost = True
    CType(Me.txtKommentar, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnGem As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtKommentar As Infragistics.Win.UltraWinEditors.UltraTextEditor

End Class
