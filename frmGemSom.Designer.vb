<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGemSom
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
    Me.components = New System.ComponentModel.Container
    Dim lblKontaktperson As Infragistics.Win.Misc.UltraLabel
    Dim lblBeskrivelse As Infragistics.Win.Misc.UltraLabel
    Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
    Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGemSom))
    Me.btnGem = New Infragistics.Win.Misc.UltraButton
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton
    Me.timer = New System.Windows.Forms.Timer(Me.components)
    Me.txtBeskrivelse = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.optAnnoncørEllerBureau = New Infragistics.Win.UltraWinEditors.UltraOptionSet
    Me.txtKontaktpersonNavn = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    lblKontaktperson = New Infragistics.Win.Misc.UltraLabel
    lblBeskrivelse = New Infragistics.Win.Misc.UltraLabel
    CType(Me.txtBeskrivelse, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optAnnoncørEllerBureau, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontaktpersonNavn, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblKontaktperson
    '
    lblKontaktperson.AutoSize = True
    lblKontaktperson.Location = New System.Drawing.Point(12, 12)
    lblKontaktperson.Name = "lblKontaktperson"
    lblKontaktperson.Size = New System.Drawing.Size(87, 15)
    lblKontaktperson.TabIndex = 342
    lblKontaktperson.Text = "Kontaktperson"
    '
    'lblBeskrivelse
    '
    lblBeskrivelse.AutoSize = True
    lblBeskrivelse.Location = New System.Drawing.Point(12, 75)
    lblBeskrivelse.Name = "lblBeskrivelse"
    lblBeskrivelse.Size = New System.Drawing.Size(68, 15)
    lblBeskrivelse.TabIndex = 345
    lblBeskrivelse.Text = "Beskrivelse"
    '
    'btnGem
    '
    Me.btnGem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGem.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnGem.Enabled = False
    Me.btnGem.Location = New System.Drawing.Point(238, 118)
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
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 118)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(101, 24)
    Me.btnAnnuller.TabIndex = 4
    Me.btnAnnuller.Text = "Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'timer
    '
    Me.timer.Interval = 500
    '
    'txtBeskrivelse
    '
    Me.txtBeskrivelse.Location = New System.Drawing.Point(12, 90)
    Me.txtBeskrivelse.MaxLength = 100
    Me.txtBeskrivelse.Name = "txtBeskrivelse"
    Me.txtBeskrivelse.Size = New System.Drawing.Size(327, 22)
    Me.txtBeskrivelse.TabIndex = 3
    '
    'optAnnoncørEllerBureau
    '
    ValueListItem1.DataValue = CType(1, Byte)
    ValueListItem1.DisplayText = "Annoncør"
    ValueListItem2.DataValue = CType(2, Byte)
    ValueListItem2.DisplayText = "Bureau"
    Me.optAnnoncørEllerBureau.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
    Me.optAnnoncørEllerBureau.ItemSpacingHorizontal = 188
    Me.optAnnoncørEllerBureau.Location = New System.Drawing.Point(12, 48)
    Me.optAnnoncørEllerBureau.Name = "optAnnoncørEllerBureau"
    Me.optAnnoncørEllerBureau.Size = New System.Drawing.Size(328, 21)
    Me.optAnnoncørEllerBureau.TabIndex = 2
    '
    'txtKontaktpersonNavn
    '
    Me.txtKontaktpersonNavn.Location = New System.Drawing.Point(12, 27)
    Me.txtKontaktpersonNavn.MaxLength = 30
    Me.txtKontaktpersonNavn.Name = "txtKontaktpersonNavn"
    Me.txtKontaktpersonNavn.NullText = "- Skriv Kontaktperson -"
    Me.txtKontaktpersonNavn.Size = New System.Drawing.Size(327, 22)
    Me.txtKontaktpersonNavn.TabIndex = 0
    '
    'frmGemSom
    '
    Me.AcceptButton = Me.btnGem
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(351, 149)
    Me.Controls.Add(lblBeskrivelse)
    Me.Controls.Add(Me.txtKontaktpersonNavn)
    Me.Controls.Add(lblKontaktperson)
    Me.Controls.Add(Me.txtBeskrivelse)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnGem)
    Me.Controls.Add(Me.optAnnoncørEllerBureau)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmGemSom"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Gem Som"
    Me.TopMost = True
    CType(Me.txtBeskrivelse, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optAnnoncørEllerBureau, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontaktpersonNavn, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Private WithEvents btnGem As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Friend WithEvents timer As System.Windows.Forms.Timer
  Friend WithEvents txtBeskrivelse As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents optAnnoncørEllerBureau As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents txtKontaktpersonNavn As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
