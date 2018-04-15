<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRapportVisning
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRapportVisning))
    Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.MedieplanMedOplagUdenTillæg = New WinPlanner.MedieplanMedOplagUdenTillæg()
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton()
    Me.lblMedieplan = New Infragistics.Win.Misc.UltraLabel()
    Me.btnUdskriv = New Infragistics.Win.Misc.UltraButton()
    Me.btnGemPDF = New Infragistics.Win.Misc.UltraButton()
    Me.lblBilag = New Infragistics.Win.Misc.UltraLabel()
    Me.optLæsertal = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.optPostNr = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.lblSortering = New Infragistics.Win.Misc.UltraLabel()
    Me.optSortering = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.chkLinier = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
    Me.optMedieplan = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    CType(Me.optLæsertal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optPostNr, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optSortering, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkLinier, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optMedieplan, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'CRViewer
    '
    Me.CRViewer.ActiveViewIndex = 0
    Me.CRViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CRViewer.Cursor = System.Windows.Forms.Cursors.Default
    Me.CRViewer.EnableDrillDown = False
    Me.CRViewer.EnableToolTips = False
    Me.CRViewer.Location = New System.Drawing.Point(0, 0)
    Me.CRViewer.Name = "CRViewer"
    Me.CRViewer.ReportSource = Me.MedieplanMedOplagUdenTillæg
    Me.CRViewer.ShowCloseButton = False
    Me.CRViewer.ShowGotoPageButton = False
    Me.CRViewer.ShowGroupTreeButton = False
    Me.CRViewer.ShowParameterPanelButton = False
    Me.CRViewer.ShowRefreshButton = False
    Me.CRViewer.Size = New System.Drawing.Size(1008, 590)
    Me.CRViewer.TabIndex = 0
    Me.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnLuk.Location = New System.Drawing.Point(909, 606)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.ShowFocusRect = False
    Me.btnLuk.ShowOutline = False
    Me.btnLuk.Size = New System.Drawing.Size(87, 24)
    Me.btnLuk.TabIndex = 339
    Me.btnLuk.Text = "Luk"
    Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'lblMedieplan
    '
    Me.lblMedieplan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblMedieplan.AutoSize = True
    Me.lblMedieplan.Location = New System.Drawing.Point(12, 596)
    Me.lblMedieplan.Name = "lblMedieplan"
    Me.lblMedieplan.Size = New System.Drawing.Size(62, 15)
    Me.lblMedieplan.TabIndex = 341
    Me.lblMedieplan.Text = "Medieplan"
    '
    'btnUdskriv
    '
    Me.btnUdskriv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnUdskriv.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnUdskriv.Location = New System.Drawing.Point(816, 606)
    Me.btnUdskriv.Name = "btnUdskriv"
    Me.btnUdskriv.ShowFocusRect = False
    Me.btnUdskriv.ShowOutline = False
    Me.btnUdskriv.Size = New System.Drawing.Size(87, 24)
    Me.btnUdskriv.TabIndex = 342
    Me.btnUdskriv.Text = "Udskriv"
    Me.btnUdskriv.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnGemPDF
    '
    Me.btnGemPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGemPDF.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnGemPDF.Location = New System.Drawing.Point(723, 606)
    Me.btnGemPDF.Name = "btnGemPDF"
    Me.btnGemPDF.ShowFocusRect = False
    Me.btnGemPDF.ShowOutline = False
    Me.btnGemPDF.Size = New System.Drawing.Size(87, 24)
    Me.btnGemPDF.TabIndex = 343
    Me.btnGemPDF.Text = "Gem PDF"
    Me.btnGemPDF.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'lblBilag
    '
    Me.lblBilag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblBilag.AutoSize = True
    Me.lblBilag.Location = New System.Drawing.Point(210, 596)
    Me.lblBilag.Name = "lblBilag"
    Me.lblBilag.Size = New System.Drawing.Size(32, 15)
    Me.lblBilag.TabIndex = 344
    Me.lblBilag.Text = "Bilag"
    '
    'optLæsertal
    '
    Me.optLæsertal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    ValueListItem1.DataValue = CType(0, Byte)
    ValueListItem1.DisplayText = "Uden læsertal"
    ValueListItem2.DataValue = CType(1, Byte)
    ValueListItem2.DisplayText = "Med læsertal"
    Me.optLæsertal.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
    Me.optLæsertal.Location = New System.Drawing.Point(248, 594)
    Me.optLæsertal.Name = "optLæsertal"
    Me.optLæsertal.Size = New System.Drawing.Size(104, 44)
    Me.optLæsertal.TabIndex = 345
    '
    'optPostNr
    '
    Me.optPostNr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    ValueListItem3.DataValue = CType(0, Byte)
    ValueListItem3.DisplayText = "Uden post nr."
    ValueListItem4.DataValue = CType(1, Byte)
    ValueListItem4.DisplayText = "Med post nr."
    Me.optPostNr.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
    Me.optPostNr.Location = New System.Drawing.Point(358, 594)
    Me.optPostNr.Name = "optPostNr"
    Me.optPostNr.Size = New System.Drawing.Size(104, 44)
    Me.optPostNr.TabIndex = 346
    '
    'lblSortering
    '
    Me.lblSortering.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblSortering.AutoSize = True
    Me.lblSortering.Location = New System.Drawing.Point(468, 596)
    Me.lblSortering.Name = "lblSortering"
    Me.lblSortering.Size = New System.Drawing.Size(57, 15)
    Me.lblSortering.TabIndex = 347
    Me.lblSortering.Text = "Sortering"
    '
    'optSortering
    '
    Me.optSortering.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.optSortering.CheckedIndex = 0
    ValueListItem5.DataValue = CType(0, Byte)
    ValueListItem5.DisplayText = "Alfabetisk"
    ValueListItem6.DataValue = CType(1, Byte)
    ValueListItem6.DisplayText = "Geokode"
    Me.optSortering.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
    Me.optSortering.Location = New System.Drawing.Point(531, 594)
    Me.optSortering.Name = "optSortering"
    Me.optSortering.Size = New System.Drawing.Size(104, 44)
    Me.optSortering.TabIndex = 348
    Me.optSortering.Text = "Alfabetisk"
    '
    'chkLinier
    '
    Me.chkLinier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkLinier.Location = New System.Drawing.Point(5, 610)
    Me.chkLinier.Name = "chkLinier"
    Me.chkLinier.Size = New System.Drawing.Size(69, 20)
    Me.chkLinier.TabIndex = 349
    Me.chkLinier.Text = "+ linier"
    '
    'optMedieplan
    '
    Me.optMedieplan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.optMedieplan.CheckedIndex = 0
    ValueListItem7.DataValue = CType(0, Byte)
    ValueListItem7.DisplayText = "Medieplan"
    Me.optMedieplan.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7})
    Me.optMedieplan.Location = New System.Drawing.Point(89, 594)
    Me.optMedieplan.Name = "optMedieplan"
    Me.optMedieplan.Size = New System.Drawing.Size(104, 18)
    Me.optMedieplan.TabIndex = 350
    Me.optMedieplan.Text = "Medieplan"
    '
    'frmRapportVisning
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.CancelButton = Me.btnLuk
    Me.ClientSize = New System.Drawing.Size(1008, 642)
    Me.Controls.Add(Me.optMedieplan)
    Me.Controls.Add(Me.chkLinier)
    Me.Controls.Add(Me.optSortering)
    Me.Controls.Add(Me.lblSortering)
    Me.Controls.Add(Me.optPostNr)
    Me.Controls.Add(Me.optLæsertal)
    Me.Controls.Add(Me.lblBilag)
    Me.Controls.Add(Me.btnGemPDF)
    Me.Controls.Add(Me.btnUdskriv)
    Me.Controls.Add(Me.lblMedieplan)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.CRViewer)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmRapportVisning"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.TopMost = True
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.optLæsertal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optPostNr, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optSortering, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkLinier, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optMedieplan, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
  Friend WithEvents lblMedieplan As Infragistics.Win.Misc.UltraLabel
  Private WithEvents btnUdskriv As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnGemPDF As Infragistics.Win.Misc.UltraButton
  Friend WithEvents lblBilag As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents optLæsertal As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents optPostNr As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents lblSortering As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents optSortering As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents chkLinier As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents optMedieplan As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents MedieplanMedOplagUdenTillæg As WinPlanner.MedieplanMedOplagUdenTillæg
  'Friend WithEvents rptMedieplan As WinPlanner.Medieplan
End Class
