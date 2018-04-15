<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmail
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmail))
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
    Me.btnSend = New Infragistics.Win.Misc.UltraButton()
    Me.lblTekst = New Infragistics.Win.Misc.UltraLabel()
    Me.lblEmne = New Infragistics.Win.Misc.UltraLabel()
    Me.txtTekst = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.txtEmne = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    CType(Me.txtTekst, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtEmne, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnAnnuller
    '
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 202)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(101, 24)
    Me.btnAnnuller.TabIndex = 378
    Me.btnAnnuller.Text = "Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnSend
    '
    Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnSend.Enabled = False
    Me.btnSend.Location = New System.Drawing.Point(294, 202)
    Me.btnSend.Name = "btnSend"
    Me.btnSend.ShowFocusRect = False
    Me.btnSend.ShowOutline = False
    Me.btnSend.Size = New System.Drawing.Size(101, 24)
    Me.btnSend.TabIndex = 377
    Me.btnSend.Text = "Send"
    Me.btnSend.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'lblTekst
    '
    Me.lblTekst.AutoSize = True
    Me.lblTekst.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTekst.Location = New System.Drawing.Point(12, 65)
    Me.lblTekst.Name = "lblTekst"
    Me.lblTekst.Size = New System.Drawing.Size(35, 15)
    Me.lblTekst.TabIndex = 376
    Me.lblTekst.Text = "Tekst"
    '
    'lblEmne
    '
    Me.lblEmne.AutoSize = True
    Me.lblEmne.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEmne.Location = New System.Drawing.Point(12, 5)
    Me.lblEmne.Name = "lblEmne"
    Me.lblEmne.Size = New System.Drawing.Size(36, 15)
    Me.lblEmne.TabIndex = 375
    Me.lblEmne.Text = "Emne"
    '
    'txtTekst
    '
    Me.txtTekst.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTekst.Location = New System.Drawing.Point(12, 86)
    Me.txtTekst.MaxLength = 999
    Me.txtTekst.Multiline = True
    Me.txtTekst.Name = "txtTekst"
    Me.txtTekst.NullText = "- Skriv teksten til modtagerne -"
    Me.txtTekst.ShowOverflowIndicator = True
    Me.txtTekst.Size = New System.Drawing.Size(383, 110)
    Me.txtTekst.TabIndex = 374
    '
    'txtEmne
    '
    Me.txtEmne.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtEmne.Location = New System.Drawing.Point(12, 26)
    Me.txtEmne.Name = "txtEmne"
    Me.txtEmne.NullText = "- Skriv kort hvad denne udsendelse drejer sig om -"
    Me.txtEmne.Size = New System.Drawing.Size(383, 22)
    Me.txtEmne.TabIndex = 373
    '
    'frmEmail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(408, 236)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnSend)
    Me.Controls.Add(Me.lblTekst)
    Me.Controls.Add(Me.lblEmne)
    Me.Controls.Add(Me.txtTekst)
    Me.Controls.Add(Me.txtEmne)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmEmail"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Email"
    Me.TopMost = True
    CType(Me.txtTekst, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtEmne, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnSend As Infragistics.Win.Misc.UltraButton
  Friend WithEvents lblTekst As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblEmne As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtTekst As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtEmne As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
