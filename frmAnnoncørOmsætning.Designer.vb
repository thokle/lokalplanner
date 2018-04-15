<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnoncørOmsætning
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
    Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
    Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
    Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnnoncørOmsætning))
    Me.btnGemExcel = New Infragistics.Win.Misc.UltraButton
    Me.btnUdskriv = New Infragistics.Win.Misc.UltraButton
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton
    Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.lblFraUge = New Infragistics.Win.Misc.UltraLabel
    Me.txtFraUge = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.lblTil = New Infragistics.Win.Misc.UltraLabel
    Me.txtTilUge = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.lblÅr = New Infragistics.Win.Misc.UltraLabel
    Me.txtÅr = New Infragistics.Win.UltraWinEditors.UltraTextEditor
    Me.grpVisninger = New Infragistics.Win.Misc.UltraGroupBox
    Me.UltraOptionSet1 = New Infragistics.Win.UltraWinEditors.UltraOptionSet
    CType(Me.txtFraUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTilUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtÅr, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpVisninger, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpVisninger.SuspendLayout()
    CType(Me.UltraOptionSet1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnGemExcel
    '
    Me.btnGemExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGemExcel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnGemExcel.Location = New System.Drawing.Point(707, 606)
    Me.btnGemExcel.Name = "btnGemExcel"
    Me.btnGemExcel.ShowFocusRect = False
    Me.btnGemExcel.ShowOutline = False
    Me.btnGemExcel.Size = New System.Drawing.Size(87, 24)
    Me.btnGemExcel.TabIndex = 347
    Me.btnGemExcel.Text = "Gem Excel"
    Me.btnGemExcel.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnUdskriv
    '
    Me.btnUdskriv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnUdskriv.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnUdskriv.Location = New System.Drawing.Point(800, 606)
    Me.btnUdskriv.Name = "btnUdskriv"
    Me.btnUdskriv.ShowFocusRect = False
    Me.btnUdskriv.ShowOutline = False
    Me.btnUdskriv.Size = New System.Drawing.Size(87, 24)
    Me.btnUdskriv.TabIndex = 346
    Me.btnUdskriv.Text = "Udskriv"
    Me.btnUdskriv.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnLuk.Location = New System.Drawing.Point(893, 606)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.ShowFocusRect = False
    Me.btnLuk.ShowOutline = False
    Me.btnLuk.Size = New System.Drawing.Size(87, 24)
    Me.btnLuk.TabIndex = 345
    Me.btnLuk.Text = "Luk"
    Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'CRViewer
    '
    Me.CRViewer.ActiveViewIndex = -1
    Me.CRViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CRViewer.DisplayBackgroundEdge = False
    Me.CRViewer.EnableDrillDown = False
    Me.CRViewer.EnableToolTips = False
    Me.CRViewer.Location = New System.Drawing.Point(0, 0)
    Me.CRViewer.Name = "CRViewer"
    Me.CRViewer.SelectionFormula = ""
    Me.CRViewer.ShowGotoPageButton = False
    Me.CRViewer.ShowPrintButton = False
    Me.CRViewer.Size = New System.Drawing.Size(992, 590)
    Me.CRViewer.TabIndex = 344
    Me.CRViewer.ViewTimeSelectionFormula = ""
    '
    'lblFraUge
    '
    Me.lblFraUge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblFraUge.AutoSize = True
    Me.lblFraUge.Location = New System.Drawing.Point(12, 611)
    Me.lblFraUge.Name = "lblFraUge"
    Me.lblFraUge.Size = New System.Drawing.Size(43, 14)
    Me.lblFraUge.TabIndex = 348
    Me.lblFraUge.Text = "Fra uge"
    '
    'txtFraUge
    '
    Me.txtFraUge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtFraUge.Location = New System.Drawing.Point(61, 609)
    Me.txtFraUge.Name = "txtFraUge"
    Me.txtFraUge.Size = New System.Drawing.Size(25, 21)
    Me.txtFraUge.TabIndex = 349
    '
    'lblTil
    '
    Me.lblTil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTil.AutoSize = True
    Me.lblTil.Location = New System.Drawing.Point(92, 611)
    Me.lblTil.Name = "lblTil"
    Me.lblTil.Size = New System.Drawing.Size(12, 14)
    Me.lblTil.TabIndex = 350
    Me.lblTil.Text = "til"
    '
    'txtTilUge
    '
    Me.txtTilUge.Location = New System.Drawing.Point(110, 609)
    Me.txtTilUge.Name = "txtTilUge"
    Me.txtTilUge.Size = New System.Drawing.Size(25, 21)
    Me.txtTilUge.TabIndex = 351
    '
    'lblÅr
    '
    Me.lblÅr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblÅr.AutoSize = True
    Me.lblÅr.Location = New System.Drawing.Point(141, 611)
    Me.lblÅr.Name = "lblÅr"
    Me.lblÅr.Size = New System.Drawing.Size(15, 14)
    Me.lblÅr.TabIndex = 352
    Me.lblÅr.Text = "År"
    '
    'txtÅr
    '
    Me.txtÅr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtÅr.Location = New System.Drawing.Point(162, 609)
    Me.txtÅr.Name = "txtÅr"
    Me.txtÅr.Size = New System.Drawing.Size(34, 21)
    Me.txtÅr.TabIndex = 353
    '
    'grpVisninger
    '
    Me.grpVisninger.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.grpVisninger.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded
    Me.grpVisninger.Controls.Add(Me.UltraOptionSet1)
    Me.grpVisninger.Location = New System.Drawing.Point(218, 596)
    Me.grpVisninger.Name = "grpVisninger"
    Me.grpVisninger.Size = New System.Drawing.Size(294, 34)
    Me.grpVisninger.TabIndex = 354
    Me.grpVisninger.Text = "Visninger"
    '
    'UltraOptionSet1
    '
    Me.UltraOptionSet1.CheckedIndex = 0
    ValueListItem1.DataValue = CType(0, Byte)
    ValueListItem1.DisplayText = "pr. Annoncør"
    ValueListItem2.DataValue = CType(1, Byte)
    ValueListItem2.DisplayText = "pr.  Region"
    ValueListItem3.DataValue = CType(2, Byte)
    ValueListItem3.DisplayText = "pr. Mediehus"
    Me.UltraOptionSet1.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
    Me.UltraOptionSet1.Location = New System.Drawing.Point(25, 13)
    Me.UltraOptionSet1.Name = "UltraOptionSet1"
    Me.UltraOptionSet1.Size = New System.Drawing.Size(256, 19)
    Me.UltraOptionSet1.TabIndex = 0
    Me.UltraOptionSet1.Text = "pr. Annoncør"
    '
    'frmAnnoncørOmsætning
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.CancelButton = Me.btnLuk
    Me.ClientSize = New System.Drawing.Size(992, 642)
    Me.Controls.Add(Me.grpVisninger)
    Me.Controls.Add(Me.txtÅr)
    Me.Controls.Add(Me.lblÅr)
    Me.Controls.Add(Me.txtTilUge)
    Me.Controls.Add(Me.lblTil)
    Me.Controls.Add(Me.txtFraUge)
    Me.Controls.Add(Me.lblFraUge)
    Me.Controls.Add(Me.btnGemExcel)
    Me.Controls.Add(Me.btnUdskriv)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.CRViewer)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmAnnoncørOmsætning"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Annoncør omsætning"
    Me.TopMost = True
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.txtFraUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTilUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtÅr, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpVisninger, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpVisninger.ResumeLayout(False)
    CType(Me.UltraOptionSet1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnGemExcel As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnUdskriv As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
  Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents lblFraUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtFraUge As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblTil As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtTilUge As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblÅr As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtÅr As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents grpVisninger As Infragistics.Win.Misc.UltraGroupBox
  Friend WithEvents UltraOptionSet1 As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
