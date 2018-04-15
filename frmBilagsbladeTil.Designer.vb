<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilagsbladeTil
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBilagsbladeTil))
    Me.lblNavn = New Infragistics.Win.Misc.UltraLabel
    Me.txtNavn = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.txtAdresse = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.lblAdresse = New Infragistics.Win.Misc.UltraLabel
    Me.txtPostNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.lblPostNr = New Infragistics.Win.Misc.UltraLabel
    Me.btnAnnuller = New System.Windows.Forms.Button
    Me.btnOk = New Infragistics.Win.Misc.UltraButton
    CType(Me.txtNavn, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAdresse, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPostNr, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblNavn
    '
    Me.lblNavn.AutoSize = True
    Me.lblNavn.Location = New System.Drawing.Point(12, 10)
    Me.lblNavn.Name = "lblNavn"
    Me.lblNavn.Size = New System.Drawing.Size(31, 14)
    Me.lblNavn.TabIndex = 0
    Me.lblNavn.Text = "Navn"
    '
    'txtNavn
    '
    Me.txtNavn.Location = New System.Drawing.Point(12, 23)
    Me.txtNavn.MaxLength = 30
    Me.txtNavn.Name = "txtNavn"
    Me.txtNavn.NullText = "- Skriv navn på modtager -"
    Me.txtNavn.Size = New System.Drawing.Size(260, 21)
    Me.txtNavn.TabIndex = 1
    '
    'txtAdresse
    '
    Me.txtAdresse.Location = New System.Drawing.Point(12, 65)
    Me.txtAdresse.MaxLength = 30
    Me.txtAdresse.Name = "txtAdresse"
    Me.txtAdresse.NullText = "- Skriv adresse -"
    Me.txtAdresse.Size = New System.Drawing.Size(260, 21)
    Me.txtAdresse.TabIndex = 3
    '
    'lblAdresse
    '
    Me.lblAdresse.AutoSize = True
    Me.lblAdresse.Location = New System.Drawing.Point(12, 52)
    Me.lblAdresse.Name = "lblAdresse"
    Me.lblAdresse.Size = New System.Drawing.Size(46, 14)
    Me.lblAdresse.TabIndex = 2
    Me.lblAdresse.Text = "Adresse"
    '
    'txtPostNr
    '
    Me.txtPostNr.Location = New System.Drawing.Point(12, 106)
    Me.txtPostNr.MaxLength = 4
    Me.txtPostNr.Name = "txtPostNr"
    Me.txtPostNr.NullText = "- Skriv post nr. -"
    Me.txtPostNr.Size = New System.Drawing.Size(93, 21)
    Me.txtPostNr.TabIndex = 5
    '
    'lblPostNr
    '
    Me.lblPostNr.AutoSize = True
    Me.lblPostNr.Location = New System.Drawing.Point(12, 93)
    Me.lblPostNr.Name = "lblPostNr"
    Me.lblPostNr.Size = New System.Drawing.Size(43, 14)
    Me.lblPostNr.TabIndex = 4
    Me.lblPostNr.Text = "Post nr."
    '
    'btnAnnuller
    '
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(13, 134)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.Size = New System.Drawing.Size(75, 23)
    Me.btnAnnuller.TabIndex = 6
    Me.btnAnnuller.Text = "Annuller"
    Me.btnAnnuller.UseVisualStyleBackColor = True
    '
    'btnOk
    '
    Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnOk.Location = New System.Drawing.Point(197, 134)
    Me.btnOk.Name = "btnOk"
    Me.btnOk.Size = New System.Drawing.Size(75, 23)
    Me.btnOk.TabIndex = 7
    Me.btnOk.Text = "Ok"
    '
    'frmBilagsbladeTil
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 171)
    Me.ControlBox = False
    Me.Controls.Add(Me.btnOk)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.txtPostNr)
    Me.Controls.Add(Me.lblPostNr)
    Me.Controls.Add(Me.txtAdresse)
    Me.Controls.Add(Me.lblAdresse)
    Me.Controls.Add(Me.txtNavn)
    Me.Controls.Add(Me.lblNavn)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmBilagsbladeTil"
    Me.ShowInTaskbar = False
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Bilags blad modtager"
    CType(Me.txtNavn, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAdresse, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPostNr, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblNavn As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtNavn As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtAdresse As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblAdresse As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtPostNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblPostNr As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents btnAnnuller As System.Windows.Forms.Button
  Friend WithEvents btnOk As Infragistics.Win.Misc.UltraButton
End Class
