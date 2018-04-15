<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingListe
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
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("viewBookingListe", -1)
    Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedieplanNr")
    Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Version")
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnnoncørNo_", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BureauNo_")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Format")
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalFarver")
    Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge")
    Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SamletPris")
    Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdreAnsvarlig")
    Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalgsAnsvarlig")
    Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nr")
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookingListe))
    Me.numTilUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Me.numFraUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Me.lblTilUge = New Infragistics.Win.Misc.UltraLabel
    Me.lblFraUge = New Infragistics.Win.Misc.UltraLabel
    Me.btnOpdater = New Infragistics.Win.Misc.UltraButton
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton
    Me.grdOversigt = New Infragistics.Win.UltraWinGrid.UltraGrid
    Me.ViewBookingListeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstBookingListe = New WinPlanner.dstBookingListe
    Me.numÅr = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
    Me.ExcelExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
    Me.btnTilExcel = New Infragistics.Win.Misc.UltraButton
    Me.ViewBookingListeTableAdapter = New WinPlanner.dstBookingListeTableAdapters.viewBookingListeTableAdapter
    CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdOversigt, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ViewBookingListeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstBookingListe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numÅr, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'numTilUge
    '
    Me.numTilUge.Location = New System.Drawing.Point(123, 8)
    Me.numTilUge.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
    Me.numTilUge.MaskInput = "nn"
    Me.numTilUge.MaxValue = 53
    Me.numTilUge.MinValue = 1
    Me.numTilUge.Name = "numTilUge"
    Me.numTilUge.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.numTilUge.Size = New System.Drawing.Size(58, 21)
    Me.numTilUge.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
    Me.numTilUge.SpinWrap = True
    Me.numTilUge.TabIndex = 347
    Me.numTilUge.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
    Me.numTilUge.Value = 1
    '
    'numFraUge
    '
    Me.numFraUge.Location = New System.Drawing.Point(56, 8)
    Me.numFraUge.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
    Me.numFraUge.MaskInput = "nn"
    Me.numFraUge.MaxValue = 53
    Me.numFraUge.MinValue = 1
    Me.numFraUge.Name = "numFraUge"
    Me.numFraUge.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.numFraUge.Size = New System.Drawing.Size(58, 21)
    Me.numFraUge.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
    Me.numFraUge.SpinWrap = True
    Me.numFraUge.TabIndex = 345
    Me.numFraUge.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
    Me.numFraUge.Value = 1
    '
    'lblTilUge
    '
    Me.lblTilUge.AutoSize = True
    Me.lblTilUge.Location = New System.Drawing.Point(112, 6)
    Me.lblTilUge.Name = "lblTilUge"
    Me.lblTilUge.Size = New System.Drawing.Size(10, 14)
    Me.lblTilUge.TabIndex = 346
    Me.lblTilUge.Text = "_"
    '
    'lblFraUge
    '
    Me.lblFraUge.AutoSize = True
    Me.lblFraUge.Location = New System.Drawing.Point(4, 12)
    Me.lblFraUge.Name = "lblFraUge"
    Me.lblFraUge.Size = New System.Drawing.Size(43, 14)
    Me.lblFraUge.TabIndex = 344
    Me.lblFraUge.Text = "Fra uge"
    '
    'btnOpdater
    '
    Me.btnOpdater.Location = New System.Drawing.Point(280, 7)
    Me.btnOpdater.Name = "btnOpdater"
    Me.btnOpdater.ShowFocusRect = False
    Me.btnOpdater.ShowOutline = False
    Me.btnOpdater.Size = New System.Drawing.Size(87, 24)
    Me.btnOpdater.TabIndex = 343
    Me.btnOpdater.Text = "Opdater"
    Me.btnOpdater.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnLuk.Location = New System.Drawing.Point(806, 461)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.ShowFocusRect = False
    Me.btnLuk.ShowOutline = False
    Me.btnLuk.Size = New System.Drawing.Size(87, 24)
    Me.btnLuk.TabIndex = 348
    Me.btnLuk.Text = "Luk"
    Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'grdOversigt
    '
    Me.grdOversigt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdOversigt.DataSource = Me.ViewBookingListeBindingSource
    UltraGridColumn1.Header.Caption = "Medieplan Nr"
    UltraGridColumn1.Header.Fixed = True
    UltraGridColumn1.Header.VisiblePosition = 8
    UltraGridColumn1.Hidden = True
    UltraGridColumn1.Width = 77
    UltraGridColumn2.Header.Fixed = True
    UltraGridColumn2.Header.VisiblePosition = 10
    UltraGridColumn2.Hidden = True
    UltraGridColumn3.Header.Caption = "Annoncør"
    UltraGridColumn3.Header.VisiblePosition = 0
    UltraGridColumn3.Width = 154
    UltraGridColumn4.Header.Caption = "Bureau"
    UltraGridColumn4.Header.VisiblePosition = 1
    UltraGridColumn4.Width = 179
    UltraGridColumn5.Header.VisiblePosition = 2
    UltraGridColumn5.Width = 105
    UltraGridColumn6.Header.Caption = "Farver"
    UltraGridColumn6.Header.VisiblePosition = 3
    UltraGridColumn6.Width = 94
    UltraGridColumn7.Header.Caption = "Uge"
    UltraGridColumn7.Header.VisiblePosition = 9
    UltraGridColumn7.Width = 39
    Appearance1.TextHAlignAsString = "Right"
    UltraGridColumn8.CellAppearance = Appearance1
    UltraGridColumn8.Format = "#,##0"
    UltraGridColumn8.Header.Caption = "Kr"
    UltraGridColumn8.Header.VisiblePosition = 4
    UltraGridColumn8.Width = 77
    UltraGridColumn9.Header.Caption = "Ordre Ansv."
    UltraGridColumn9.Header.VisiblePosition = 6
    UltraGridColumn9.Width = 105
    UltraGridColumn10.Header.Caption = "Salgs Ansv."
    UltraGridColumn10.Header.VisiblePosition = 5
    UltraGridColumn10.Width = 105
    UltraGridColumn11.Header.Caption = "Medieplan Nr"
    UltraGridColumn11.Header.VisiblePosition = 7
    UltraGridColumn11.Width = 98
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
    UltraGridBand1.ScrollTipField = "MedieplanNr"
    Me.grdOversigt.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdOversigt.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
    Me.grdOversigt.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
    Me.grdOversigt.DisplayLayout.GroupByBox.Hidden = True
    Me.grdOversigt.DisplayLayout.MaxColScrollRegions = 1
    Me.grdOversigt.DisplayLayout.MaxRowScrollRegions = 1
    Me.grdOversigt.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdOversigt.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOversigt.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOversigt.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.grdOversigt.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdOversigt.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOversigt.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
    Me.grdOversigt.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
    Me.grdOversigt.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
    Me.grdOversigt.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Both
    Me.grdOversigt.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdOversigt.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdOversigt.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
    Me.grdOversigt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdOversigt.Location = New System.Drawing.Point(0, 40)
    Me.grdOversigt.Name = "grdOversigt"
    Me.grdOversigt.Size = New System.Drawing.Size(872, 415)
    Me.grdOversigt.TabIndex = 349
    Me.grdOversigt.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
    '
    'ViewBookingListeBindingSource
    '
    Me.ViewBookingListeBindingSource.DataMember = "viewBookingListe"
    Me.ViewBookingListeBindingSource.DataSource = Me.DstBookingListe
    '
    'DstBookingListe
    '
    Me.DstBookingListe.DataSetName = "dstBookingListe"
    Me.DstBookingListe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'numÅr
    '
    Me.numÅr.Location = New System.Drawing.Point(216, 8)
    Me.numÅr.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
    Me.numÅr.MaskInput = "nnnn"
    Me.numÅr.MaxValue = 2020
    Me.numÅr.MinValue = 2005
    Me.numÅr.Name = "numÅr"
    Me.numÅr.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.numÅr.Size = New System.Drawing.Size(58, 21)
    Me.numÅr.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
    Me.numÅr.SpinWrap = True
    Me.numÅr.TabIndex = 350
    Me.numÅr.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
    Me.numÅr.Value = 2009
    '
    'UltraLabel1
    '
    Me.UltraLabel1.AutoSize = True
    Me.UltraLabel1.Location = New System.Drawing.Point(195, 12)
    Me.UltraLabel1.Name = "UltraLabel1"
    Me.UltraLabel1.Size = New System.Drawing.Size(15, 14)
    Me.UltraLabel1.TabIndex = 351
    Me.UltraLabel1.Text = "År"
    '
    'btnTilExcel
    '
    Me.btnTilExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnTilExcel.Location = New System.Drawing.Point(800, 6)
    Me.btnTilExcel.Name = "btnTilExcel"
    Me.btnTilExcel.ShowFocusRect = False
    Me.btnTilExcel.ShowOutline = False
    Me.btnTilExcel.Size = New System.Drawing.Size(87, 24)
    Me.btnTilExcel.TabIndex = 375
    Me.btnTilExcel.Text = "Send til Excel"
    Me.btnTilExcel.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    Me.btnTilExcel.UseMnemonic = False
    '
    'ViewBookingListeTableAdapter
    '
    Me.ViewBookingListeTableAdapter.ClearBeforeFill = True
    '
    'frmBookingListe
    '
    Me.AcceptButton = Me.btnOpdater
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.CancelButton = Me.btnLuk
    Me.ClientSize = New System.Drawing.Size(899, 490)
    Me.Controls.Add(Me.btnTilExcel)
    Me.Controls.Add(Me.UltraLabel1)
    Me.Controls.Add(Me.numÅr)
    Me.Controls.Add(Me.grdOversigt)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.numTilUge)
    Me.Controls.Add(Me.numFraUge)
    Me.Controls.Add(Me.lblTilUge)
    Me.Controls.Add(Me.lblFraUge)
    Me.Controls.Add(Me.btnOpdater)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmBookingListe"
    Me.Text = "Booking Liste"
    CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdOversigt, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ViewBookingListeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstBookingListe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numÅr, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents numTilUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents numFraUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lblTilUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblFraUge As Infragistics.Win.Misc.UltraLabel
  Private WithEvents btnOpdater As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
  Friend WithEvents grdOversigt As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents DstBookingListe As WinPlanner.dstBookingListe
  Friend WithEvents ViewBookingListeBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents ViewBookingListeTableAdapter As WinPlanner.dstBookingListeTableAdapters.viewBookingListeTableAdapter
  Friend WithEvents numÅr As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents ExcelExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
  Private WithEvents btnTilExcel As Infragistics.Win.Misc.UltraButton
End Class
