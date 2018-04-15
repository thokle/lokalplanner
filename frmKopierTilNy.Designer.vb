<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKopierTilNy
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
    Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKopierTilNy))
    Me.btnOk = New Infragistics.Win.Misc.UltraButton()
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
    Me.optGenberegn = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.optModul = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.optBureauOrdreNr = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.optBemærkning = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.lblBemærkning = New Infragistics.Win.Misc.UltraLabel()
    Me.txtBemærkning = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.optMiljøTillæg = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.lblMiljøTillæg = New Infragistics.Win.Misc.UltraLabel()
    CType(Me.optGenberegn, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optModul, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optBureauOrdreNr, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optBemærkning, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBemærkning, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optMiljøTillæg, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnOk
    '
    Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnOk.Enabled = False
    Me.btnOk.Location = New System.Drawing.Point(185, 311)
    Me.btnOk.Name = "btnOk"
    Me.btnOk.ShowFocusRect = False
    Me.btnOk.ShowOutline = False
    Me.btnOk.Size = New System.Drawing.Size(87, 24)
    Me.btnOk.TabIndex = 337
    Me.btnOk.Text = "&Ok"
    Me.btnOk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnAnnuller
    '
    Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 310)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(87, 24)
    Me.btnAnnuller.TabIndex = 338
    Me.btnAnnuller.Text = "&Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'optGenberegn
    '
    ValueListItem1.DataValue = 0
    ValueListItem1.DisplayText = "Genberegn rabatter"
    ValueListItem2.DataValue = 1
    ValueListItem2.DisplayText = "Behold rabatter"
    Me.optGenberegn.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
    Me.optGenberegn.Location = New System.Drawing.Point(12, 12)
    Me.optGenberegn.Name = "optGenberegn"
    Me.optGenberegn.Size = New System.Drawing.Size(261, 32)
    Me.optGenberegn.TabIndex = 339
    '
    'optModul
    '
    ValueListItem3.DataValue = 0
    ValueListItem3.DisplayText = "Åben i medieplan modul"
    ValueListItem4.DataValue = 1
    ValueListItem4.DisplayText = "Åben i booking modul"
    Me.optModul.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
    Me.optModul.Location = New System.Drawing.Point(12, 51)
    Me.optModul.Name = "optModul"
    Me.optModul.Size = New System.Drawing.Size(261, 32)
    Me.optModul.TabIndex = 340
    '
    'optBureauOrdreNr
    '
    Me.optBureauOrdreNr.CheckedIndex = 0
    ValueListItem5.DataValue = 0
    ValueListItem5.DisplayText = "Nulstil bureau ordre nr."
    ValueListItem6.DataValue = 1
    ValueListItem6.DisplayText = "Behold bureau ordre nr."
    Me.optBureauOrdreNr.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
    Me.optBureauOrdreNr.Location = New System.Drawing.Point(12, 89)
    Me.optBureauOrdreNr.Name = "optBureauOrdreNr"
    Me.optBureauOrdreNr.Size = New System.Drawing.Size(261, 32)
    Me.optBureauOrdreNr.TabIndex = 341
    Me.optBureauOrdreNr.Text = "Nulstil bureau ordre nr."
    '
    'optBemærkning
    '
    Me.optBemærkning.CheckedIndex = 0
    ValueListItem7.DataValue = 0
    ValueListItem7.DisplayText = "Medtag bemærkning"
    ValueListItem8.DataValue = 1
    ValueListItem8.DisplayText = "Slet bemærkning"
    Me.optBemærkning.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7, ValueListItem8})
    Me.optBemærkning.Location = New System.Drawing.Point(12, 206)
    Me.optBemærkning.Name = "optBemærkning"
    Me.optBemærkning.Size = New System.Drawing.Size(261, 32)
    Me.optBemærkning.TabIndex = 342
    Me.optBemærkning.Text = "Medtag bemærkning"
    '
    'lblBemærkning
    '
    Me.lblBemærkning.AutoSize = True
    Me.lblBemærkning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBemærkning.Location = New System.Drawing.Point(12, 132)
    Me.lblBemærkning.Name = "lblBemærkning"
    Me.lblBemærkning.Size = New System.Drawing.Size(71, 14)
    Me.lblBemærkning.TabIndex = 343
    Me.lblBemærkning.Text = "Bemærkning"
    '
    'txtBemærkning
    '
    Me.txtBemærkning.Location = New System.Drawing.Point(12, 147)
    Me.txtBemærkning.Multiline = True
    Me.txtBemærkning.Name = "txtBemærkning"
    Me.txtBemærkning.NullText = "- Ingen bemærkning fundet -"
    Me.txtBemærkning.ReadOnly = True
    Me.txtBemærkning.Size = New System.Drawing.Size(261, 53)
    Me.txtBemærkning.TabIndex = 344
    '
    'optMiljøTillæg
    '
    Me.optMiljøTillæg.CheckedIndex = 0
    ValueListItem10.DataValue = 0
    ValueListItem10.DisplayText = "Geberegn tillæg"
    ValueListItem9.DataValue = 1
    ValueListItem9.DisplayText = "Behold  tillæg"
    Me.optMiljøTillæg.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem10, ValueListItem9})
    Me.optMiljøTillæg.Location = New System.Drawing.Point(12, 265)
    Me.optMiljøTillæg.Name = "optMiljøTillæg"
    Me.optMiljøTillæg.Size = New System.Drawing.Size(261, 32)
    Me.optMiljøTillæg.TabIndex = 345
    Me.optMiljøTillæg.Text = "Geberegn tillæg"
    Me.optMiljøTillæg.Visible = False
    '
    'lblMiljøTillæg
    '
    Me.lblMiljøTillæg.AutoSize = True
    Me.lblMiljøTillæg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMiljøTillæg.Location = New System.Drawing.Point(12, 250)
    Me.lblMiljøTillæg.Name = "lblMiljøTillæg"
    Me.lblMiljøTillæg.Size = New System.Drawing.Size(57, 14)
    Me.lblMiljøTillæg.TabIndex = 346
    Me.lblMiljøTillæg.Text = "Miljøtillæg"
    Me.lblMiljøTillæg.Visible = False
    '
    'frmKopierTilNy
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(284, 347)
    Me.Controls.Add(Me.lblMiljøTillæg)
    Me.Controls.Add(Me.optMiljøTillæg)
    Me.Controls.Add(Me.txtBemærkning)
    Me.Controls.Add(Me.lblBemærkning)
    Me.Controls.Add(Me.optBemærkning)
    Me.Controls.Add(Me.optBureauOrdreNr)
    Me.Controls.Add(Me.optModul)
    Me.Controls.Add(Me.optGenberegn)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnOk)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmKopierTilNy"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Kopier til ny"
    Me.TopMost = True
    CType(Me.optGenberegn, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optModul, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optBureauOrdreNr, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optBemærkning, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBemærkning, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optMiljøTillæg, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnOk As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Friend WithEvents optGenberegn As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents optModul As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents optBureauOrdreNr As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents optBemærkning As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents lblBemærkning As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtBemærkning As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents optMiljøTillæg As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents lblMiljøTillæg As Infragistics.Win.Misc.UltraLabel

End Class
