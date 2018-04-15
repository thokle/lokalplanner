<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkalSendes
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
    Me.components = New System.ComponentModel.Container()
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("viewOversigt", -1)
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedieplanNr")
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Version")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnnoncørNo_")
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BureauNo_")
    Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Format")
    Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalFarver")
    Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
    Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdreUdsendt")
    Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialeFra")
    Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialeUdsendt")
    Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdreAnsvarlig")
    Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalgsAnsvarlig")
    Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nr")
    Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Overskrift")
    Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Deadline", -1, Nothing, 1, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
    Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kommentar")
    Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkalSendes))
    Me.grdOversigt = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.ViewOversigtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstOversigt = New WinPlanner.dstOversigt()
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton()
    Me.btnOpdater = New Infragistics.Win.Misc.UltraButton()
    Me.numTilUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.numFraUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.lblTilUge = New Infragistics.Win.Misc.UltraLabel()
    Me.lblFraUge = New Infragistics.Win.Misc.UltraLabel()
    Me.ViewOversigtTableAdapter = New WinPlanner.dstOversigtTableAdapters.viewOversigtTableAdapter()
    CType(Me.grdOversigt, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ViewOversigtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstOversigt, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdOversigt
    '
    Me.grdOversigt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdOversigt.DataSource = Me.ViewOversigtBindingSource
    Me.grdOversigt.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
    UltraGridColumn3.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
    UltraGridColumn3.Header.Caption = "Medieplan Nr"
    UltraGridColumn3.Header.Fixed = True
    UltraGridColumn3.Header.VisiblePosition = 1
    UltraGridColumn3.Hidden = True
    UltraGridColumn3.Width = 73
    UltraGridColumn4.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
    UltraGridColumn4.Header.Fixed = True
    UltraGridColumn4.Header.VisiblePosition = 2
    UltraGridColumn4.Hidden = True
    UltraGridColumn5.Header.Caption = "Annoncør"
    UltraGridColumn5.Header.VisiblePosition = 3
    UltraGridColumn5.Width = 76
    UltraGridColumn6.Header.Caption = "Bureau"
    UltraGridColumn6.Header.VisiblePosition = 4
    UltraGridColumn6.Width = 51
    UltraGridColumn7.Header.VisiblePosition = 5
    UltraGridColumn7.Width = 84
    UltraGridColumn8.Header.Caption = "Farver"
    UltraGridColumn8.Header.VisiblePosition = 6
    UltraGridColumn8.Width = 49
    UltraGridColumn9.Header.Caption = "Uge"
    UltraGridColumn9.Header.VisiblePosition = 8
    UltraGridColumn9.Width = 40
    UltraGridColumn10.Header.Caption = "Ordre Udsendt"
    UltraGridColumn10.Header.VisiblePosition = 9
    UltraGridColumn10.Width = 63
    UltraGridColumn11.Header.Caption = "Materiale Fra"
    UltraGridColumn11.Header.VisiblePosition = 10
    UltraGridColumn11.Width = 66
    UltraGridColumn12.Header.Caption = "Materiale Udsendt"
    UltraGridColumn12.Header.VisiblePosition = 11
    UltraGridColumn12.Width = 77
    UltraGridColumn13.Header.Caption = "Ordre Ansv."
    UltraGridColumn13.Header.VisiblePosition = 13
    UltraGridColumn13.Width = 64
    UltraGridColumn14.Header.Caption = "Salgs Ansv."
    UltraGridColumn14.Header.VisiblePosition = 14
    UltraGridColumn14.Width = 70
    UltraGridColumn29.Header.Caption = "Medieplan Nr"
    UltraGridColumn29.Header.VisiblePosition = 0
    UltraGridColumn29.Width = 77
    UltraGridColumn30.Header.VisiblePosition = 7
    UltraGridColumn30.Width = 67
    UltraGridColumn31.Header.VisiblePosition = 12
    UltraGridColumn31.Width = 74
    UltraGridColumn32.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
    UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    UltraGridColumn32.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
    UltraGridColumn32.Header.VisiblePosition = 15
    UltraGridColumn32.NullText = "- Indtast evt. kommentar. - "
    UltraGridColumn32.Width = 80
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
    UltraGridBand1.Override.NoRowsInDataSourceMessageEnabled = Infragistics.Win.DefaultableBoolean.[True]
    UltraGridBand1.Override.NoRowsInDataSourceMessageText = "Der er ingen data, for den valgte periode!"
    UltraGridBand1.ScrollTipField = "MedieplanNr"
    Me.grdOversigt.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdOversigt.DisplayLayout.ColumnChooserEnabled = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOversigt.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
    Me.grdOversigt.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.HideRowSelector
    Me.grdOversigt.DisplayLayout.GroupByBox.Hidden = True
    Me.grdOversigt.DisplayLayout.MaxColScrollRegions = 1
    Me.grdOversigt.DisplayLayout.MaxRowScrollRegions = 1
    Me.grdOversigt.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdOversigt.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.WithinBand
    Me.grdOversigt.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Synchronized
    Me.grdOversigt.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
    Me.grdOversigt.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOversigt.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOversigt.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOversigt.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOversigt.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    Me.grdOversigt.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOversigt.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
    Me.grdOversigt.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.EntireColumn
    Me.grdOversigt.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdOversigt.DisplayLayout.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.FixedOnTop
    Me.grdOversigt.DisplayLayout.Override.InitialSortDirection = Infragistics.Win.UltraWinGrid.SortDirection.Ascending
    Me.grdOversigt.DisplayLayout.Override.InvalidValueBehavior = Infragistics.Win.UltraWinGrid.InvalidValueBehavior.RevertValue
    Me.grdOversigt.DisplayLayout.Override.NoRowsInDataSourceMessageEnabled = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOversigt.DisplayLayout.Override.NoRowsInDataSourceMessageText = "Ingen ordresedler eller materialer mangler at blive sendt, for den valgte periode" & _
    "."
    Me.grdOversigt.DisplayLayout.Override.ReserveSortIndicatorSpaceWhenAutoSizing = Infragistics.Win.UltraWinGrid.ReserveSortIndicatorSpaceWhenAutoSizing.WhenColumnIsSortable
    Me.grdOversigt.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButtonFixedSize
    Me.grdOversigt.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOversigt.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree
    Me.grdOversigt.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.EntireRow
    Me.grdOversigt.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Extended
    Me.grdOversigt.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
    Me.grdOversigt.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
    ScrollBarLook1.ShowMinMaxButtons = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOversigt.DisplayLayout.ScrollBarLook = ScrollBarLook1
    Me.grdOversigt.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Both
    Me.grdOversigt.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdOversigt.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdOversigt.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
    Me.grdOversigt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdOversigt.Location = New System.Drawing.Point(6, 40)
    Me.grdOversigt.Name = "grdOversigt"
    Me.grdOversigt.Size = New System.Drawing.Size(972, 384)
    Me.grdOversigt.TabIndex = 0
    Me.grdOversigt.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
    '
    'ViewOversigtBindingSource
    '
    Me.ViewOversigtBindingSource.AllowNew = False
    Me.ViewOversigtBindingSource.DataMember = "viewOversigt"
    Me.ViewOversigtBindingSource.DataSource = Me.DstOversigt
    '
    'DstOversigt
    '
    Me.DstOversigt.DataSetName = "dstOversigt"
    Me.DstOversigt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.Location = New System.Drawing.Point(891, 432)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.ShowFocusRect = False
    Me.btnLuk.ShowOutline = False
    Me.btnLuk.Size = New System.Drawing.Size(87, 24)
    Me.btnLuk.TabIndex = 337
    Me.btnLuk.Text = "Luk"
    Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnOpdater
    '
    Me.btnOpdater.Location = New System.Drawing.Point(192, 8)
    Me.btnOpdater.Name = "btnOpdater"
    Me.btnOpdater.ShowFocusRect = False
    Me.btnOpdater.ShowOutline = False
    Me.btnOpdater.Size = New System.Drawing.Size(87, 24)
    Me.btnOpdater.TabIndex = 338
    Me.btnOpdater.Text = "Opdater"
    Me.btnOpdater.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
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
    Me.numTilUge.TabIndex = 342
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
    Me.numFraUge.TabIndex = 340
    Me.numFraUge.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
    Me.numFraUge.Value = 1
    '
    'lblTilUge
    '
    Me.lblTilUge.AutoSize = True
    Me.lblTilUge.Location = New System.Drawing.Point(112, 6)
    Me.lblTilUge.Name = "lblTilUge"
    Me.lblTilUge.Size = New System.Drawing.Size(10, 14)
    Me.lblTilUge.TabIndex = 341
    Me.lblTilUge.Text = "_"
    '
    'lblFraUge
    '
    Me.lblFraUge.AutoSize = True
    Me.lblFraUge.Location = New System.Drawing.Point(4, 12)
    Me.lblFraUge.Name = "lblFraUge"
    Me.lblFraUge.Size = New System.Drawing.Size(43, 14)
    Me.lblFraUge.TabIndex = 339
    Me.lblFraUge.Text = "Fra uge"
    '
    'ViewOversigtTableAdapter
    '
    Me.ViewOversigtTableAdapter.ClearBeforeFill = True
    '
    'frmSkalSendes
    '
    Me.AcceptButton = Me.btnOpdater
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(984, 461)
    Me.Controls.Add(Me.numTilUge)
    Me.Controls.Add(Me.numFraUge)
    Me.Controls.Add(Me.lblTilUge)
    Me.Controls.Add(Me.lblFraUge)
    Me.Controls.Add(Me.btnOpdater)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.grdOversigt)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmSkalSendes"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Oversigt Uge"
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.grdOversigt, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ViewOversigtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstOversigt, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents grdOversigt As Infragistics.Win.UltraWinGrid.UltraGrid
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnOpdater As Infragistics.Win.Misc.UltraButton
  Friend WithEvents DstOversigt As WinPlanner.dstOversigt
  Friend WithEvents ViewOversigtBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents ViewOversigtTableAdapter As WinPlanner.dstOversigtTableAdapters.viewOversigtTableAdapter
  Friend WithEvents numTilUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents numFraUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lblTilUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblFraUge As Infragistics.Win.Misc.UltraLabel
End Class
