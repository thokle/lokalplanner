<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFakturaBem�rkning
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
    Dim lblBem�rkning As Infragistics.Win.Misc.UltraLabel
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFakturaBem�rkning))
    Me.btnGem = New Infragistics.Win.Misc.UltraButton
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton
    Me.txtFakturaBem�rkning1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.txtFakturaBem�rkning2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    lblBem�rkning = New Infragistics.Win.Misc.UltraLabel
    CType(Me.txtFakturaBem�rkning1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFakturaBem�rkning2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblBem�rkning
    '
    lblBem�rkning.AutoSize = True
    lblBem�rkning.Location = New System.Drawing.Point(12, 12)
    lblBem�rkning.Name = "lblBem�rkning"
    lblBem�rkning.Size = New System.Drawing.Size(77, 15)
    lblBem�rkning.TabIndex = 342
    lblBem�rkning.Text = "Bem�rkning"
    '
    'btnGem
    '
    Me.btnGem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGem.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnGem.Location = New System.Drawing.Point(238, 89)
    Me.btnGem.Name = "btnGem"
    Me.btnGem.ShowFocusRect = False
    Me.btnGem.ShowOutline = False
    Me.btnGem.Size = New System.Drawing.Size(101, 24)
    Me.btnGem.TabIndex = 5
    Me.btnGem.Text = "Gem"
    Me.btnGem.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnAnnuller
    '
    Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 89)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(101, 24)
    Me.btnAnnuller.TabIndex = 4
    Me.btnAnnuller.Text = "Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'txtFakturaBem�rkning1
    '
    Me.txtFakturaBem�rkning1.Location = New System.Drawing.Point(12, 27)
    Me.txtFakturaBem�rkning1.MaxLength = 50
    Me.txtFakturaBem�rkning1.Name = "txtFakturaBem�rkning1"
    Me.txtFakturaBem�rkning1.NullText = "- Skriv bem�rkning linie 1 -"
    Me.txtFakturaBem�rkning1.Size = New System.Drawing.Size(327, 22)
    Me.txtFakturaBem�rkning1.TabIndex = 0
    '
    'txtFakturaBem�rkning2
    '
    Me.txtFakturaBem�rkning2.Location = New System.Drawing.Point(12, 55)
    Me.txtFakturaBem�rkning2.MaxLength = 50
    Me.txtFakturaBem�rkning2.Name = "txtFakturaBem�rkning2"
    Me.txtFakturaBem�rkning2.NullText = "- Skriv bem�rkning linie 2 -"
    Me.txtFakturaBem�rkning2.Size = New System.Drawing.Size(327, 22)
    Me.txtFakturaBem�rkning2.TabIndex = 343
    '
    'frmFakturaBem�rkning
    '
    Me.AcceptButton = Me.btnGem
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(351, 120)
    Me.Controls.Add(Me.txtFakturaBem�rkning2)
    Me.Controls.Add(Me.txtFakturaBem�rkning1)
    Me.Controls.Add(lblBem�rkning)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnGem)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmFakturaBem�rkning"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Faktura bem�rkning"
    Me.TopMost = True
    CType(Me.txtFakturaBem�rkning1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFakturaBem�rkning2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Private WithEvents btnGem As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtFakturaBem�rkning1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtFakturaBem�rkning2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
