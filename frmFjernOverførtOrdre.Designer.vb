<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFjernOverførtOrdre
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
    Dim lblMedieplanNr As Infragistics.Win.Misc.UltraLabel
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFjernOverførtOrdre))
    Me.btnFjern = New System.Windows.Forms.Button
    Me.btnAnnuller = New System.Windows.Forms.Button
    Me.txtMedieplanNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    lblMedieplanNr = New Infragistics.Win.Misc.UltraLabel
    CType(Me.txtMedieplanNr, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblMedieplanNr
    '
    lblMedieplanNr.Location = New System.Drawing.Point(13, 16)
    lblMedieplanNr.Name = "lblMedieplanNr"
    lblMedieplanNr.Size = New System.Drawing.Size(128, 15)
    lblMedieplanNr.TabIndex = 2
    lblMedieplanNr.Text = "Indtast medieplan nr"
    '
    'btnFjern
    '
    Me.btnFjern.Enabled = False
    Me.btnFjern.Location = New System.Drawing.Point(153, 63)
    Me.btnFjern.Name = "btnFjern"
    Me.btnFjern.Size = New System.Drawing.Size(67, 23)
    Me.btnFjern.TabIndex = 0
    Me.btnFjern.Text = "&Fjern"
    '
    'btnAnnuller
    '
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(13, 63)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.Size = New System.Drawing.Size(67, 23)
    Me.btnAnnuller.TabIndex = 1
    Me.btnAnnuller.Text = "&Annuller"
    '
    'txtMedieplanNr
    '
    Me.txtMedieplanNr.Location = New System.Drawing.Point(136, 12)
    Me.txtMedieplanNr.Name = "txtMedieplanNr"
    Me.txtMedieplanNr.NullText = "- Indtast nr. -"
    Me.txtMedieplanNr.Size = New System.Drawing.Size(100, 21)
    Me.txtMedieplanNr.TabIndex = 3
    '
    'frmFjernOverførtOrdre
    '
    Me.AcceptButton = Me.btnFjern
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(248, 95)
    Me.Controls.Add(Me.txtMedieplanNr)
    Me.Controls.Add(lblMedieplanNr)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnFjern)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmFjernOverførtOrdre"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Fjern overført ordre"
    Me.TopMost = True
    CType(Me.txtMedieplanNr, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnFjern As System.Windows.Forms.Button
  Friend WithEvents btnAnnuller As System.Windows.Forms.Button
  Friend WithEvents txtMedieplanNr As Infragistics.Win.UltraWinEditors.UltraTextEditor

End Class
