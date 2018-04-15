<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisRabatter
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
    Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblGruppeRabatter", -1)
    Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RabatFormID")
    Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GruppeID")
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalFra")
    Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalTil")
    Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MmRabat")
    Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveRabat")
    Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MmPris")
    Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveMin")
    Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveMax")
    Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveTillæg")
    Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrisInclFarver")
    Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlaceringID")
    Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
    Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
    Me.grdGruppeRabatter = New Infragistics.Win.UltraWinGrid.UltraGrid
    Me.DstGruppeRabatter = New WinPlanner.dstGruppeRabatter
    Me.TblGruppeRabatterTableAdapter = New WinPlanner.dstGruppeRabatterTableAdapters.tblGruppeRabatterTableAdapter
    Me.TblGruppeRabatterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.tabPlacering = New Infragistics.Win.UltraWinTabControl.UltraTabStripControl
    Me.tbpPlaceringShared = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    CType(Me.grdGruppeRabatter, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstGruppeRabatter, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblGruppeRabatterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.tabPlacering, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tabPlacering.SuspendLayout()
    Me.tbpPlaceringShared.SuspendLayout()
    Me.SuspendLayout()
    '
    'grdGruppeRabatter
    '
    Me.grdGruppeRabatter.DataSource = Me.TblGruppeRabatterBindingSource
    Me.grdGruppeRabatter.DisplayLayout.AddNewBox.Prompt = " "
    Appearance31.BackColor = System.Drawing.SystemColors.Window
    Appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdGruppeRabatter.DisplayLayout.Appearance = Appearance31
    Me.grdGruppeRabatter.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
    UltraGridColumn1.Header.VisiblePosition = 0
    UltraGridColumn1.Hidden = True
    UltraGridColumn1.Width = 78
    UltraGridColumn2.Header.VisiblePosition = 1
    UltraGridColumn2.Hidden = True
    UltraGridColumn2.Width = 62
    UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
    UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance22.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn3.CellAppearance = Appearance22
    UltraGridColumn3.Header.Caption = "Fra"
    UltraGridColumn3.Header.VisiblePosition = 2
    UltraGridColumn3.Width = 28
    UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance23.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn4.CellAppearance = Appearance23
    UltraGridColumn4.Header.Caption = "Til"
    UltraGridColumn4.Header.VisiblePosition = 3
    UltraGridColumn4.Width = 25
    UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance24.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn5.CellAppearance = Appearance24
    UltraGridColumn5.Format = ""
    UltraGridColumn5.Header.Caption = "Mm Rabat"
    UltraGridColumn5.Header.VisiblePosition = 4
    UltraGridColumn5.Width = 50
    UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance25.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn6.CellAppearance = Appearance25
    UltraGridColumn6.Header.Caption = "F Rabat"
    UltraGridColumn6.Header.VisiblePosition = 5
    UltraGridColumn6.Width = 46
    UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance26.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn7.CellAppearance = Appearance26
    UltraGridColumn7.Format = "0.00"
    UltraGridColumn7.Header.Caption = "Mm Pris"
    UltraGridColumn7.Header.VisiblePosition = 6
    UltraGridColumn7.Width = 54
    UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance27.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn8.CellAppearance = Appearance27
    UltraGridColumn8.Format = "####"
    UltraGridColumn8.Header.Caption = "Min"
    UltraGridColumn8.Header.VisiblePosition = 8
    UltraGridColumn8.Width = 43
    UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance28.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn9.CellAppearance = Appearance28
    UltraGridColumn9.Format = "####"
    UltraGridColumn9.Header.Caption = "Max"
    UltraGridColumn9.Header.VisiblePosition = 9
    UltraGridColumn9.Width = 51
    UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance29.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn10.CellAppearance = Appearance29
    UltraGridColumn10.Format = "###0.00"
    UltraGridColumn10.Header.Caption = "F Tillæg"
    UltraGridColumn10.Header.VisiblePosition = 7
    UltraGridColumn10.Width = 55
    UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    Appearance30.ForeColorDisabled = System.Drawing.Color.Black
    UltraGridColumn11.CellAppearance = Appearance30
    UltraGridColumn11.Format = "#0.00"
    UltraGridColumn11.Header.Caption = "Pris Incl. Farver"
    UltraGridColumn11.Header.VisiblePosition = 10
    UltraGridColumn11.Width = 71
    UltraGridColumn12.Header.VisiblePosition = 11
    UltraGridColumn12.Hidden = True
    UltraGridColumn12.Width = 83
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
    Me.grdGruppeRabatter.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdGruppeRabatter.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdGruppeRabatter.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdGruppeRabatter.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
    Me.grdGruppeRabatter.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
    Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance32.BorderColor = System.Drawing.SystemColors.Window
    Me.grdGruppeRabatter.DisplayLayout.GroupByBox.Appearance = Appearance32
    Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdGruppeRabatter.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
    Me.grdGruppeRabatter.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdGruppeRabatter.DisplayLayout.GroupByBox.Hidden = True
    Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance34.BackColor2 = System.Drawing.SystemColors.Control
    Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdGruppeRabatter.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
    Me.grdGruppeRabatter.DisplayLayout.MaxColScrollRegions = 1
    Me.grdGruppeRabatter.DisplayLayout.MaxRowScrollRegions = 1
    Appearance35.BackColor = System.Drawing.SystemColors.Window
    Appearance35.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdGruppeRabatter.DisplayLayout.Override.ActiveCellAppearance = Appearance35
    Appearance36.BackColor = System.Drawing.SystemColors.Highlight
    Appearance36.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdGruppeRabatter.DisplayLayout.Override.ActiveRowAppearance = Appearance36
    Me.grdGruppeRabatter.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdGruppeRabatter.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdGruppeRabatter.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdGruppeRabatter.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdGruppeRabatter.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance37.BackColor = System.Drawing.SystemColors.Window
    Me.grdGruppeRabatter.DisplayLayout.Override.CardAreaAppearance = Appearance37
    Appearance38.BorderColor = System.Drawing.Color.Silver
    Appearance38.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdGruppeRabatter.DisplayLayout.Override.CellAppearance = Appearance38
    Me.grdGruppeRabatter.DisplayLayout.Override.CellPadding = 0
    Appearance39.BackColor = System.Drawing.SystemColors.Control
    Appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance39.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance39.BorderColor = System.Drawing.SystemColors.Window
    Me.grdGruppeRabatter.DisplayLayout.Override.GroupByRowAppearance = Appearance39
    Appearance40.TextHAlignAsString = "Left"
    Me.grdGruppeRabatter.DisplayLayout.Override.HeaderAppearance = Appearance40
    Me.grdGruppeRabatter.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance41.BackColor = System.Drawing.SystemColors.Window
    Appearance41.BorderColor = System.Drawing.Color.Silver
    Me.grdGruppeRabatter.DisplayLayout.Override.RowAppearance = Appearance41
    Me.grdGruppeRabatter.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Appearance42.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdGruppeRabatter.DisplayLayout.Override.TemplateAddRowAppearance = Appearance42
    Me.grdGruppeRabatter.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdGruppeRabatter.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdGruppeRabatter.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
    Me.grdGruppeRabatter.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdGruppeRabatter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdGruppeRabatter.Location = New System.Drawing.Point(0, 0)
    Me.grdGruppeRabatter.Name = "grdGruppeRabatter"
    Me.grdGruppeRabatter.Size = New System.Drawing.Size(425, 194)
    Me.grdGruppeRabatter.TabIndex = 310
    '
    'DstGruppeRabatter
    '
    Me.DstGruppeRabatter.DataSetName = "dstGruppeRabatter"
    Me.DstGruppeRabatter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'TblGruppeRabatterTableAdapter
    '
    Me.TblGruppeRabatterTableAdapter.ClearBeforeFill = True
    '
    'TblGruppeRabatterBindingSource
    '
    Me.TblGruppeRabatterBindingSource.DataMember = "tblGruppeRabatter"
    Me.TblGruppeRabatterBindingSource.DataSource = Me.DstGruppeRabatter
    '
    'tabPlacering
    '
    Me.tabPlacering.Controls.Add(Me.tbpPlaceringShared)
    Me.tabPlacering.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tabPlacering.Location = New System.Drawing.Point(0, 0)
    Me.tabPlacering.Name = "tabPlacering"
    Me.tabPlacering.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.grdGruppeRabatter})
    Me.tabPlacering.SharedControlsPage = Me.tbpPlaceringShared
    Me.tabPlacering.Size = New System.Drawing.Size(427, 215)
    Me.tabPlacering.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
    Me.tabPlacering.TabIndex = 344
    UltraTab3.Text = "Tekstside"
    UltraTab4.Text = "Rubrik"
    Me.tabPlacering.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
    '
    'tbpPlaceringShared
    '
    Me.tbpPlaceringShared.Controls.Add(Me.grdGruppeRabatter)
    Me.tbpPlaceringShared.Location = New System.Drawing.Point(1, 20)
    Me.tbpPlaceringShared.Name = "tbpPlaceringShared"
    Me.tbpPlaceringShared.Size = New System.Drawing.Size(425, 194)
    '
    'frmVisRabatter
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(427, 215)
    Me.Controls.Add(Me.tabPlacering)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmVisRabatter"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    CType(Me.grdGruppeRabatter, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstGruppeRabatter, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblGruppeRabatterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.tabPlacering, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tabPlacering.ResumeLayout(False)
    Me.tbpPlaceringShared.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grdGruppeRabatter As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents DstGruppeRabatter As WinPlanner.dstGruppeRabatter
  Friend WithEvents TblGruppeRabatterTableAdapter As WinPlanner.dstGruppeRabatterTableAdapters.tblGruppeRabatterTableAdapter
  Friend WithEvents TblGruppeRabatterBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents tabPlacering As Infragistics.Win.UltraWinTabControl.UltraTabStripControl
  Friend WithEvents tbpPlaceringShared As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
End Class
