<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUdsending
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
    Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblUgeaviser", -1)
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Navn", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
    Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valgt", 0)
    Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUdsending))
    Me.optUdsendelsesType = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.lblGenudsendelse = New Infragistics.Win.Misc.UltraLabel()
    Me.grdBladListe = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.UgeavisListeDropdownBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.UgeavisListeDropdown = New WinPlanner.UgeavisListeDropdown()
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
    Me.btnSend = New Infragistics.Win.Misc.UltraButton()
    Me.TblUgeaviserTableAdapter = New WinPlanner.UgeavisListeDropdownTableAdapters.tblUgeaviserTableAdapter()
    Me.numUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.num≈r = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.lbl≈rBooking = New Infragistics.Win.Misc.UltraLabel()
    CType(Me.optUdsendelsesType, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdBladListe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UgeavisListeDropdownBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UgeavisListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.num≈r, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'optUdsendelsesType
    '
    Me.optUdsendelsesType.CheckedIndex = 0
    ValueListItem1.CheckState = System.Windows.Forms.CheckState.Checked
    ValueListItem1.DataValue = CType(1, Byte)
    ValueListItem1.DisplayText = "Tjekliste"
    ValueListItem3.DataValue = CType(2, Byte)
    ValueListItem3.DisplayText = "BilagsBlad Reminder"
    Me.optUdsendelsesType.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem3})
    Me.optUdsendelsesType.Location = New System.Drawing.Point(8, 32)
    Me.optUdsendelsesType.Name = "optUdsendelsesType"
    Me.optUdsendelsesType.Size = New System.Drawing.Size(448, 24)
    Me.optUdsendelsesType.TabIndex = 0
    Me.optUdsendelsesType.Text = "Tjekliste"
    '
    'lblGenudsendelse
    '
    Me.lblGenudsendelse.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGenudsendelse.Location = New System.Drawing.Point(8, 10)
    Me.lblGenudsendelse.Name = "lblGenudsendelse"
    Me.lblGenudsendelse.Size = New System.Drawing.Size(101, 16)
    Me.lblGenudsendelse.TabIndex = 1
    Me.lblGenudsendelse.Text = "Send for uge"
    '
    'grdBladListe
    '
    Me.grdBladListe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdBladListe.DataSource = Me.UgeavisListeDropdownBindingSource
    Appearance1.BackColor = System.Drawing.SystemColors.Window
    Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdBladListe.DisplayLayout.Appearance = Appearance1
    UltraGridColumn4.Header.VisiblePosition = 0
    UltraGridColumn4.Hidden = True
    UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance2.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn5.CellAppearance = Appearance2
    UltraGridColumn5.Header.VisiblePosition = 1
    UltraGridColumn5.Width = 311
    UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    UltraGridColumn6.DataType = GetType(Boolean)
    UltraGridColumn6.DefaultCellValue = False
    UltraGridColumn6.Header.ToolTipText = "Klik for at vÊlge blade"
    UltraGridColumn6.Header.VisiblePosition = 2
    UltraGridColumn6.Width = 89
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
    UltraGridBand1.ScrollTipField = "Navn"
    Me.grdBladListe.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdBladListe.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdBladListe.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdBladListe.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
    Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance3.BorderColor = System.Drawing.SystemColors.Window
    Me.grdBladListe.DisplayLayout.GroupByBox.Appearance = Appearance3
    Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdBladListe.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
    Me.grdBladListe.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdBladListe.DisplayLayout.GroupByBox.Hidden = True
    Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance5.BackColor2 = System.Drawing.SystemColors.Control
    Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdBladListe.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
    Me.grdBladListe.DisplayLayout.MaxColScrollRegions = 1
    Me.grdBladListe.DisplayLayout.MaxRowScrollRegions = 1
    Appearance6.BackColor = System.Drawing.SystemColors.Window
    Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdBladListe.DisplayLayout.Override.ActiveCellAppearance = Appearance6
    Appearance7.BackColor = System.Drawing.SystemColors.Highlight
    Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdBladListe.DisplayLayout.Override.ActiveRowAppearance = Appearance7
    Me.grdBladListe.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdBladListe.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdBladListe.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdBladListe.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdBladListe.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance8.BackColor = System.Drawing.SystemColors.Window
    Me.grdBladListe.DisplayLayout.Override.CardAreaAppearance = Appearance8
    Appearance9.BorderColor = System.Drawing.Color.Silver
    Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdBladListe.DisplayLayout.Override.CellAppearance = Appearance9
    Me.grdBladListe.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    Me.grdBladListe.DisplayLayout.Override.CellPadding = 0
    Me.grdBladListe.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
    Appearance10.BackColor = System.Drawing.SystemColors.Control
    Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance10.BorderColor = System.Drawing.SystemColors.Window
    Me.grdBladListe.DisplayLayout.Override.GroupByRowAppearance = Appearance10
    Appearance11.TextHAlignAsString = "Left"
    Me.grdBladListe.DisplayLayout.Override.HeaderAppearance = Appearance11
    Me.grdBladListe.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdBladListe.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance12.BackColor = System.Drawing.SystemColors.Window
    Appearance12.BorderColor = System.Drawing.Color.Silver
    Me.grdBladListe.DisplayLayout.Override.RowAppearance = Appearance12
    Me.grdBladListe.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdBladListe.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
    Me.grdBladListe.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdBladListe.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
    Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdBladListe.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
    Me.grdBladListe.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
    Me.grdBladListe.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdBladListe.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdBladListe.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
    Me.grdBladListe.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
    Me.grdBladListe.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdBladListe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdBladListe.Location = New System.Drawing.Point(8, 71)
    Me.grdBladListe.Name = "grdBladListe"
    Me.grdBladListe.Size = New System.Drawing.Size(448, 411)
    Me.grdBladListe.TabIndex = 2
    Me.grdBladListe.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
    '
    'UgeavisListeDropdownBindingSource
    '
    Me.UgeavisListeDropdownBindingSource.DataMember = "tblUgeaviser"
    Me.UgeavisListeDropdownBindingSource.DataSource = Me.UgeavisListeDropdown
    '
    'UgeavisListeDropdown
    '
    Me.UgeavisListeDropdown.DataSetName = "UgeavisListeDropdown"
    Me.UgeavisListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'btnAnnuller
    '
    Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(8, 504)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(101, 24)
    Me.btnAnnuller.TabIndex = 374
    Me.btnAnnuller.Text = "Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnSend
    '
    Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSend.Location = New System.Drawing.Point(356, 504)
    Me.btnSend.Name = "btnSend"
    Me.btnSend.ShowFocusRect = False
    Me.btnSend.ShowOutline = False
    Me.btnSend.Size = New System.Drawing.Size(101, 24)
    Me.btnSend.TabIndex = 373
    Me.btnSend.Text = "Send"
    Me.btnSend.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'TblUgeaviserTableAdapter
    '
    Me.TblUgeaviserTableAdapter.ClearBeforeFill = True
    '
    'numUge
    '
    Me.numUge.Location = New System.Drawing.Point(103, 6)
    Me.numUge.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
    Me.numUge.MaskInput = "nn"
    Me.numUge.MaxValue = 53
    Me.numUge.MinValue = 1
    Me.numUge.Name = "numUge"
    Me.numUge.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.numUge.Size = New System.Drawing.Size(58, 22)
    Me.numUge.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
    Me.numUge.SpinWrap = True
    Me.numUge.TabIndex = 375
    Me.numUge.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
    Me.numUge.Value = 1
    '
    'num≈r
    '
    Me.num≈r.Location = New System.Drawing.Point(219, 6)
    Me.num≈r.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
    Me.num≈r.MaskInput = "nnnn"
    Me.num≈r.MaxValue = 2020
    Me.num≈r.MinValue = 1996
    Me.num≈r.Name = "num≈r"
    Me.num≈r.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.num≈r.Size = New System.Drawing.Size(68, 22)
    Me.num≈r.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
    Me.num≈r.SpinWrap = True
    Me.num≈r.TabIndex = 376
    Me.num≈r.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
    Me.num≈r.Value = 2007
    '
    'lbl≈rBooking
    '
    Me.lbl≈rBooking.AutoSize = True
    Me.lbl≈rBooking.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl≈rBooking.Location = New System.Drawing.Point(167, 10)
    Me.lbl≈rBooking.Name = "lbl≈rBooking"
    Me.lbl≈rBooking.Size = New System.Drawing.Size(46, 17)
    Me.lbl≈rBooking.TabIndex = 377
    Me.lbl≈rBooking.Text = "≈rstal"
    '
    'frmUdsending
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(464, 541)
    Me.Controls.Add(Me.lbl≈rBooking)
    Me.Controls.Add(Me.num≈r)
    Me.Controls.Add(Me.numUge)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnSend)
    Me.Controls.Add(Me.grdBladListe)
    Me.Controls.Add(Me.lblGenudsendelse)
    Me.Controls.Add(Me.optUdsendelsesType)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmUdsending"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Send til Ugeaviser"
    CType(Me.optUdsendelsesType, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdBladListe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UgeavisListeDropdownBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UgeavisListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.num≈r, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents optUdsendelsesType As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents lblGenudsendelse As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents grdBladListe As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents UgeavisListeDropdown As WinPlanner.UgeavisListeDropdown
  Friend WithEvents UgeavisListeDropdownBindingSource As System.Windows.Forms.BindingSource
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnSend As Infragistics.Win.Misc.UltraButton
  Friend WithEvents TblUgeaviserTableAdapter As WinPlanner.UgeavisListeDropdownTableAdapters.tblUgeaviserTableAdapter
  Friend WithEvents numUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents num≈r As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lbl≈rBooking As Infragistics.Win.Misc.UltraLabel
End Class
