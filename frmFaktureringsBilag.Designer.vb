<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaktureringsBilag
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaktureringsBilag))
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton
    Me.chkErRettet = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstFaktureringsBilag = New WinPlanner.dstFaktureringsBilag
    Me.btnGem = New Infragistics.Win.Misc.UltraButton
    Me.lblRabatformer = New System.Windows.Forms.Label
    Me.lblOprettet = New Infragistics.Win.Misc.UltraLabel
    Me.lblOprettetDato = New Infragistics.Win.Misc.UltraLabel
    Me.lblOprettetAf = New Infragistics.Win.Misc.UltraLabel
    Me.lblAf = New Infragistics.Win.Misc.UltraLabel
    Me.lblRettetAf = New Infragistics.Win.Misc.UltraLabel
    Me.runOnceTimer = New System.Windows.Forms.Timer(Me.components)
    Me.tabBilag = New Infragistics.Win.UltraWinTabControl.UltraTabStripControl
    Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Me.txtBilagsTekst = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.TblFaktureringsBilagTableAdapter = New WinPlanner.dstFaktureringsBilagTableAdapters.tblFaktureringsBilagTableAdapter
    Me.lblRettetKl = New Infragistics.Win.Misc.UltraLabel
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstFaktureringsBilag, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.tabBilag, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tabBilag.SuspendLayout()
    Me.UltraTabSharedControlsPage1.SuspendLayout()
    CType(Me.txtBilagsTekst, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnAnnuller
    '
    Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 258)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(87, 24)
    Me.btnAnnuller.TabIndex = 20
    Me.btnAnnuller.Text = "&Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'chkErRettet
    '
    Me.chkErRettet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.chkErRettet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.chkErRettet.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "ErRettet", True))
    Me.chkErRettet.Location = New System.Drawing.Point(299, 236)
    Me.chkErRettet.Name = "chkErRettet"
    Me.chkErRettet.Size = New System.Drawing.Size(63, 20)
    Me.chkErRettet.TabIndex = 22
    Me.chkErRettet.Text = "Er rettet"
    '
    'BindingSource1
    '
    Me.BindingSource1.DataMember = "tblFaktureringsBilag"
    Me.BindingSource1.DataSource = Me.DstFaktureringsBilag
    '
    'DstFaktureringsBilag
    '
    Me.DstFaktureringsBilag.DataSetName = "dstFaktureringsBilag"
    Me.DstFaktureringsBilag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'btnGem
    '
    Me.btnGem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGem.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnGem.Enabled = False
    Me.btnGem.Location = New System.Drawing.Point(338, 258)
    Me.btnGem.Name = "btnGem"
    Me.btnGem.ShowFocusRect = False
    Me.btnGem.ShowOutline = False
    Me.btnGem.Size = New System.Drawing.Size(87, 24)
    Me.btnGem.TabIndex = 23
    Me.btnGem.Text = "&Gem"
    Me.btnGem.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'lblRabatformer
    '
    Me.lblRabatformer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblRabatformer.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblRabatformer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(198, Byte), Integer))
    Me.lblRabatformer.Location = New System.Drawing.Point(179, 9)
    Me.lblRabatformer.Name = "lblRabatformer"
    Me.lblRabatformer.Size = New System.Drawing.Size(262, 32)
    Me.lblRabatformer.TabIndex = 24
    Me.lblRabatformer.Text = "Fakturerings bilag"
    '
    'lblOprettet
    '
    Me.lblOprettet.Location = New System.Drawing.Point(12, 239)
    Me.lblOprettet.Name = "lblOprettet"
    Me.lblOprettet.Size = New System.Drawing.Size(64, 13)
    Me.lblOprettet.TabIndex = 25
    Me.lblOprettet.Text = "Oprettet af"
    '
    'lblOprettetDato
    '
    Me.lblOprettetDato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Oprettet", True))
    Me.lblOprettetDato.Location = New System.Drawing.Point(138, 239)
    Me.lblOprettetDato.Name = "lblOprettetDato"
    Me.lblOprettetDato.Size = New System.Drawing.Size(139, 13)
    Me.lblOprettetDato.TabIndex = 26
    Me.lblOprettetDato.Text = "Oprettet"
    '
    'lblOprettetAf
    '
    Me.lblOprettetAf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "OprettetAf", True))
    Me.lblOprettetAf.Location = New System.Drawing.Point(71, 239)
    Me.lblOprettetAf.Name = "lblOprettetAf"
    Me.lblOprettetAf.Size = New System.Drawing.Size(40, 15)
    Me.lblOprettetAf.TabIndex = 27
    '
    'lblAf
    '
    Me.lblAf.AutoSize = True
    Me.lblAf.Location = New System.Drawing.Point(368, 239)
    Me.lblAf.Name = "lblAf"
    Me.lblAf.Size = New System.Drawing.Size(14, 14)
    Me.lblAf.TabIndex = 28
    Me.lblAf.Text = "af"
    Me.lblAf.Visible = False
    '
    'lblRettetAf
    '
    Me.lblRettetAf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "RettetAf", True))
    Me.lblRettetAf.Location = New System.Drawing.Point(388, 239)
    Me.lblRettetAf.Name = "lblRettetAf"
    Me.lblRettetAf.Size = New System.Drawing.Size(40, 15)
    Me.lblRettetAf.TabIndex = 29
    '
    'runOnceTimer
    '
    Me.runOnceTimer.Interval = 500
    '
    'tabBilag
    '
    Me.tabBilag.Controls.Add(Me.UltraTabSharedControlsPage1)
    Me.tabBilag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Tekst", True))
    Me.tabBilag.DataMember = "tblFaktureringsBilag"
    Me.tabBilag.DataSource = Me.DstFaktureringsBilag
    Me.tabBilag.Location = New System.Drawing.Point(12, 44)
    Me.tabBilag.MaxVisibleTabRows = 50
    Me.tabBilag.Name = "tabBilag"
    Me.tabBilag.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.txtBilagsTekst})
    Me.tabBilag.SharedControlsPage = Me.UltraTabSharedControlsPage1
    Me.tabBilag.Size = New System.Drawing.Size(416, 189)
    Me.tabBilag.TabIndex = 21
    Me.tabBilag.TabKeyMember = "ErRettet"
    Me.tabBilag.TabTextMember = "BemærkningNr"
    Me.tabBilag.ToolTipTextMember = "UgeavisNavn"
    '
    'UltraTabSharedControlsPage1
    '
    Me.UltraTabSharedControlsPage1.Controls.Add(Me.txtBilagsTekst)
    Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(1, 23)
    Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
    Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(412, 163)
    '
    'txtBilagsTekst
    '
    Me.txtBilagsTekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Tekst", True))
    Me.txtBilagsTekst.Location = New System.Drawing.Point(-1, 0)
    Me.txtBilagsTekst.Multiline = True
    Me.txtBilagsTekst.Name = "txtBilagsTekst"
    Me.txtBilagsTekst.Size = New System.Drawing.Size(413, 163)
    Me.txtBilagsTekst.TabIndex = 0
    '
    'TblFaktureringsBilagTableAdapter
    '
    Me.TblFaktureringsBilagTableAdapter.ClearBeforeFill = True
    '
    'lblRettetKl
    '
    Me.lblRettetKl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblRettetKl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "RettetKl", True))
    Me.lblRettetKl.Location = New System.Drawing.Point(27, 267)
    Me.lblRettetKl.Name = "lblRettetKl"
    Me.lblRettetKl.Size = New System.Drawing.Size(49, 15)
    Me.lblRettetKl.TabIndex = 30
    Me.lblRettetKl.Text = "RettetKl"
    '
    'frmFaktureringsBilag
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(440, 294)
    Me.Controls.Add(Me.lblRettetAf)
    Me.Controls.Add(Me.lblAf)
    Me.Controls.Add(Me.lblOprettetAf)
    Me.Controls.Add(Me.lblOprettetDato)
    Me.Controls.Add(Me.lblOprettet)
    Me.Controls.Add(Me.lblRabatformer)
    Me.Controls.Add(Me.btnGem)
    Me.Controls.Add(Me.chkErRettet)
    Me.Controls.Add(Me.tabBilag)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.lblRettetKl)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmFaktureringsBilag"
    Me.ShowInTaskbar = False
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Fakturerings Bilag"
    Me.TopMost = True
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstFaktureringsBilag, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.tabBilag, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tabBilag.ResumeLayout(False)
    Me.UltraTabSharedControlsPage1.ResumeLayout(False)
    Me.UltraTabSharedControlsPage1.PerformLayout()
    CType(Me.txtBilagsTekst, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Friend WithEvents tabBilag As Infragistics.Win.UltraWinTabControl.UltraTabStripControl
  Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
  Friend WithEvents txtBilagsTekst As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents DstFaktureringsBilag As WinPlanner.dstFaktureringsBilag
  Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
  Friend WithEvents TblFaktureringsBilagTableAdapter As WinPlanner.dstFaktureringsBilagTableAdapters.tblFaktureringsBilagTableAdapter
  Friend WithEvents chkErRettet As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Private WithEvents btnGem As Infragistics.Win.Misc.UltraButton
  Friend WithEvents lblRabatformer As System.Windows.Forms.Label
  Friend WithEvents lblOprettet As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblOprettetDato As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblOprettetAf As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblAf As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblRettetAf As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents runOnceTimer As System.Windows.Forms.Timer
  Friend WithEvents lblRettetKl As Infragistics.Win.Misc.UltraLabel
End Class
