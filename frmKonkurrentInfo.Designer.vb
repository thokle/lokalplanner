<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKonkurrentInfo
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
    Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("KonkurrentLinjer", -1)
    Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RowID")
    Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ugeavis")
    Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostNr", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
    Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Husstande")
    Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DLU")
    Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKonkurrentInfo))
    Me.clbKonkurrenter = New System.Windows.Forms.CheckedListBox()
    Me.optRapportType = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.optMedtag = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.btnTilExcel = New Infragistics.Win.Misc.UltraButton()
    Me.ExcelExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
    Me.optTal = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.grdRapport = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.DataSourceKonkurrentInfo = New WinPlanner.dataSourceKonkurrentInfo(Me.components)
    CType(Me.optRapportType, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optMedtag, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optTal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdRapport, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataSourceKonkurrentInfo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'clbKonkurrenter
    '
    Me.clbKonkurrenter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.clbKonkurrenter.CheckOnClick = True
    Me.clbKonkurrenter.ColumnWidth = 200
    Me.clbKonkurrenter.Location = New System.Drawing.Point(12, 12)
    Me.clbKonkurrenter.MultiColumn = True
    Me.clbKonkurrenter.Name = "clbKonkurrenter"
    Me.clbKonkurrenter.ScrollAlwaysVisible = True
    Me.clbKonkurrenter.Size = New System.Drawing.Size(705, 116)
    Me.clbKonkurrenter.TabIndex = 2
    '
    'optRapportType
    '
    Me.optRapportType.CheckedIndex = 0
    ValueListItem1.DataValue = CType(0, Byte)
    ValueListItem1.DisplayText = "Post nr."
    ValueListItem2.DataValue = CType(2, Byte)
    ValueListItem2.DisplayText = "Ugeavis & post nr."
    Me.optRapportType.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
    Me.optRapportType.ItemSpacingHorizontal = 10
    Me.optRapportType.Location = New System.Drawing.Point(13, 135)
    Me.optRapportType.Name = "optRapportType"
    Me.optRapportType.Size = New System.Drawing.Size(409, 18)
    Me.optRapportType.TabIndex = 3
    Me.optRapportType.Text = "Post nr."
    '
    'optMedtag
    '
    Me.optMedtag.CheckedIndex = 0
    ValueListItem3.DataValue = False
    ValueListItem3.DisplayText = "Kun primære"
    ValueListItem4.DataValue = True
    ValueListItem4.DisplayText = "Alle"
    Me.optMedtag.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
    Me.optMedtag.Location = New System.Drawing.Point(88, 155)
    Me.optMedtag.Name = "optMedtag"
    Me.optMedtag.Size = New System.Drawing.Size(149, 18)
    Me.optMedtag.TabIndex = 5
    Me.optMedtag.Text = "Kun primære"
    Me.optMedtag.Visible = False
    '
    'btnTilExcel
    '
    Me.btnTilExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnTilExcel.Location = New System.Drawing.Point(630, 133)
    Me.btnTilExcel.Name = "btnTilExcel"
    Me.btnTilExcel.ShowFocusRect = False
    Me.btnTilExcel.ShowOutline = False
    Me.btnTilExcel.Size = New System.Drawing.Size(87, 24)
    Me.btnTilExcel.TabIndex = 375
    Me.btnTilExcel.Text = "Send til Excel"
    Me.btnTilExcel.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    Me.btnTilExcel.UseMnemonic = False
    '
    'ExcelExporter
    '
    '
    'optTal
    '
    Me.optTal.CheckedIndex = 0
    ValueListItem5.DataValue = True
    ValueListItem5.DisplayText = "Dækningsgrader"
    ValueListItem6.DataValue = False
    ValueListItem6.DisplayText = "Oplag"
    Me.optTal.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
    Me.optTal.Location = New System.Drawing.Point(13, 155)
    Me.optTal.Name = "optTal"
    Me.optTal.Size = New System.Drawing.Size(180, 18)
    Me.optTal.TabIndex = 376
    Me.optTal.Text = "Dækningsgrader"
    '
    'grdRapport
    '
    Me.grdRapport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdRapport.DataSource = Me.DataSourceKonkurrentInfo
    Me.grdRapport.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
    UltraGridColumn1.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
    UltraGridColumn1.Header.VisiblePosition = 0
    UltraGridColumn1.Hidden = True
    UltraGridColumn1.Width = 138
    UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance1.ForeColorDisabled = System.Drawing.Color.Black
    Appearance1.TextHAlignAsString = "Left"
    UltraGridColumn2.CellAppearance = Appearance1
    UltraGridColumn2.Header.VisiblePosition = 1
    UltraGridColumn2.Hidden = True
    UltraGridColumn2.MaxWidth = 200
    UltraGridColumn2.MinWidth = 200
    UltraGridColumn2.Width = 200
    UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance2.ForeColorDisabled = System.Drawing.Color.Black
    Appearance2.TextHAlignAsString = "Left"
    UltraGridColumn3.CellAppearance = Appearance2
    UltraGridColumn3.Header.Caption = "Post nr."
    UltraGridColumn3.Header.VisiblePosition = 2
    UltraGridColumn3.MaxWidth = 200
    UltraGridColumn3.MinWidth = 150
    UltraGridColumn3.Width = 200
    UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance3.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn4.CellAppearance = Appearance3
    UltraGridColumn4.Format = "#,##0"
    UltraGridColumn4.Header.VisiblePosition = 3
    UltraGridColumn4.MaxWidth = 100
    UltraGridColumn4.MinWidth = 75
    UltraGridColumn4.ProportionalResize = True
    UltraGridColumn4.Width = 100
    UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance4.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn5.CellAppearance = Appearance4
    UltraGridColumn5.Format = "#,##0"
    UltraGridColumn5.Header.VisiblePosition = 4
    UltraGridColumn5.MaxWidth = 100
    UltraGridColumn5.MinWidth = 75
    UltraGridColumn5.ProportionalResize = True
    UltraGridColumn5.Width = 100
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
    UltraGridBand1.Indentation = 0
    UltraGridBand1.IndentationGroupByRow = 0
    UltraGridBand1.IndentationGroupByRowExpansionIndicator = 0
    UltraGridBand1.Override.DefaultColWidth = 50
    Appearance5.TextHAlignAsString = "Center"
    UltraGridBand1.Override.HeaderAppearance = Appearance5
    UltraGridBand1.SummaryFooterCaption = ""
    Me.grdRapport.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdRapport.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdRapport.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
    Me.grdRapport.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
    Appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance6.BorderColor = System.Drawing.SystemColors.Window
    Me.grdRapport.DisplayLayout.GroupByBox.Appearance = Appearance6
    Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdRapport.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance7
    Me.grdRapport.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdRapport.DisplayLayout.GroupByBox.Hidden = True
    Appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance8.BackColor2 = System.Drawing.SystemColors.Control
    Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdRapport.DisplayLayout.GroupByBox.PromptAppearance = Appearance8
    Me.grdRapport.DisplayLayout.InterBandSpacing = 0
    Me.grdRapport.DisplayLayout.MaxColScrollRegions = 1
    Me.grdRapport.DisplayLayout.MaxRowScrollRegions = 1
    Me.grdRapport.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdRapport.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
    Me.grdRapport.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Synchronized
    Me.grdRapport.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
    Me.grdRapport.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdRapport.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdRapport.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
    Me.grdRapport.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
    Appearance9.TextHAlignAsString = "Right"
    Me.grdRapport.DisplayLayout.Override.CellAppearance = Appearance9
    Me.grdRapport.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    Me.grdRapport.DisplayLayout.Override.CellPadding = 0
    Me.grdRapport.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
    Me.grdRapport.DisplayLayout.Override.DefaultColWidth = 75
    Me.grdRapport.DisplayLayout.Override.GroupByRowDescriptionMask = "[value]"
    Me.grdRapport.DisplayLayout.Override.GroupByRowExpansionStyle = Infragistics.Win.UltraWinGrid.GroupByRowExpansionStyle.ExpansionIndicatorAndDoubleClick
    Me.grdRapport.DisplayLayout.Override.GroupByRowInitialExpansionState = Infragistics.Win.UltraWinGrid.GroupByRowInitialExpansionState.Expanded
    Me.grdRapport.DisplayLayout.Override.GroupByRowPadding = 0
    Me.grdRapport.DisplayLayout.Override.GroupByRowSpacingAfter = 0
    Me.grdRapport.DisplayLayout.Override.GroupByRowSpacingBefore = 0
    Me.grdRapport.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
    Appearance10.TextHAlignAsString = "Left"
    Me.grdRapport.DisplayLayout.Override.HeaderAppearance = Appearance10
    Me.grdRapport.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdRapport.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance11.BackColor = System.Drawing.SystemColors.Window
    Appearance11.BorderColor = System.Drawing.Color.Silver
    Me.grdRapport.DisplayLayout.Override.RowAppearance = Appearance11
    Me.grdRapport.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
    Me.grdRapport.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdRapport.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
    Me.grdRapport.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdRapport.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdRapport.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdRapport.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdRapport.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.InGroupByRows
    Me.grdRapport.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdRapport.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
    Me.grdRapport.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
    Me.grdRapport.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdRapport.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdRapport.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
    Me.grdRapport.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
    Me.grdRapport.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdRapport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdRapport.Location = New System.Drawing.Point(12, 185)
    Me.grdRapport.Name = "grdRapport"
    Me.grdRapport.Size = New System.Drawing.Size(705, 348)
    Me.grdRapport.TabIndex = 4
    Me.grdRapport.Text = "Medieplan Nr"
    '
    'frmKonkurrentInfo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(729, 545)
    Me.Controls.Add(Me.optTal)
    Me.Controls.Add(Me.btnTilExcel)
    Me.Controls.Add(Me.optMedtag)
    Me.Controls.Add(Me.grdRapport)
    Me.Controls.Add(Me.optRapportType)
    Me.Controls.Add(Me.clbKonkurrenter)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmKonkurrentInfo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Konkurrent Info"
    Me.TopMost = True
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.optRapportType, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optMedtag, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optTal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdRapport, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataSourceKonkurrentInfo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents clbKonkurrenter As System.Windows.Forms.CheckedListBox
  Friend WithEvents optRapportType As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents DataSourceKonkurrentInfo As WinPlanner.dataSourceKonkurrentInfo
  Friend WithEvents grdRapport As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents optMedtag As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Private WithEvents btnTilExcel As Infragistics.Win.Misc.UltraButton
  Friend WithEvents ExcelExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
  Friend WithEvents optTal As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
