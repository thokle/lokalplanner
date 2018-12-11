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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblGruppeRabatter", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RabatFormID")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GruppeID")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalFra")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalTil")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MmRabat")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveRabat")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MmPris")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveMin")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveMax")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveTillæg")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrisInclFarver")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlaceringID")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Version")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.grdGruppeRabatter = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.tabPlacering = New Infragistics.Win.UltraWinTabControl.UltraTabStripControl()
        Me.tbpPlaceringShared = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.TblGruppeRabatterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstGruppeRabatter = New WinPlanner.dstGruppeRabatter()
        Me.TblGruppeRabatterTableAdapter = New WinPlanner.dstGruppeRabatterTableAdapters.tblGruppeRabatterTableAdapter()
        CType(Me.grdGruppeRabatter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPlacering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPlacering.SuspendLayout()
        Me.tbpPlaceringShared.SuspendLayout()
        CType(Me.TblGruppeRabatterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstGruppeRabatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdGruppeRabatter
        '
        Me.grdGruppeRabatter.DataSource = Me.TblGruppeRabatterBindingSource
        Me.grdGruppeRabatter.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdGruppeRabatter.DisplayLayout.Appearance = Appearance1
        Me.grdGruppeRabatter.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.Width = 78
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 62
        UltraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance2.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn29.CellAppearance = Appearance2
        UltraGridColumn29.Header.Caption = "Fra"
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn29.Width = 19
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance3.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn30.CellAppearance = Appearance3
        UltraGridColumn30.Header.Caption = "Til"
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Width = 22
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance4.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn31.CellAppearance = Appearance4
        UltraGridColumn31.Format = ""
        UltraGridColumn31.Header.Caption = "Mm Rabat"
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn31.Width = 44
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance5.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn32.CellAppearance = Appearance5
        UltraGridColumn32.Header.Caption = "F Rabat"
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridColumn32.Width = 40
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance6.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn33.CellAppearance = Appearance6
        UltraGridColumn33.Format = "0.00"
        UltraGridColumn33.Header.Caption = "Mm Pris"
        UltraGridColumn33.Header.VisiblePosition = 6
        UltraGridColumn33.Width = 47
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance7.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn34.CellAppearance = Appearance7
        UltraGridColumn34.Format = "####"
        UltraGridColumn34.Header.Caption = "Min"
        UltraGridColumn34.Header.VisiblePosition = 8
        UltraGridColumn34.Width = 38
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance8.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn35.CellAppearance = Appearance8
        UltraGridColumn35.Format = "####"
        UltraGridColumn35.Header.Caption = "Max"
        UltraGridColumn35.Header.VisiblePosition = 9
        UltraGridColumn35.Width = 45
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance9.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn36.CellAppearance = Appearance9
        UltraGridColumn36.Format = "###0.00"
        UltraGridColumn36.Header.Caption = "F Tillæg"
        UltraGridColumn36.Header.VisiblePosition = 7
        UltraGridColumn36.Width = 48
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance10.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn37.CellAppearance = Appearance10
        UltraGridColumn37.Format = "#0.00"
        UltraGridColumn37.Header.Caption = "Pris Incl. Farver"
        UltraGridColumn37.Header.VisiblePosition = 10
        UltraGridColumn37.Width = 62
        UltraGridColumn38.Header.VisiblePosition = 11
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.Width = 83
        UltraGridColumn39.Header.VisiblePosition = 12
        UltraGridColumn39.Width = 58
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39})
        Me.grdGruppeRabatter.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdGruppeRabatter.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdGruppeRabatter.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdGruppeRabatter.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdGruppeRabatter.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Appearance11.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.BorderColor = System.Drawing.SystemColors.Window
        Me.grdGruppeRabatter.DisplayLayout.GroupByBox.Appearance = Appearance11
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdGruppeRabatter.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance12
        Me.grdGruppeRabatter.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdGruppeRabatter.DisplayLayout.GroupByBox.Hidden = True
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance13.BackColor2 = System.Drawing.SystemColors.Control
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdGruppeRabatter.DisplayLayout.GroupByBox.PromptAppearance = Appearance13
        Me.grdGruppeRabatter.DisplayLayout.MaxColScrollRegions = 1
        Me.grdGruppeRabatter.DisplayLayout.MaxRowScrollRegions = 1
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdGruppeRabatter.DisplayLayout.Override.ActiveCellAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.SystemColors.Highlight
        Appearance15.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdGruppeRabatter.DisplayLayout.Override.ActiveRowAppearance = Appearance15
        Me.grdGruppeRabatter.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdGruppeRabatter.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdGruppeRabatter.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdGruppeRabatter.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdGruppeRabatter.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Me.grdGruppeRabatter.DisplayLayout.Override.CardAreaAppearance = Appearance16
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Appearance17.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdGruppeRabatter.DisplayLayout.Override.CellAppearance = Appearance17
        Me.grdGruppeRabatter.DisplayLayout.Override.CellPadding = 0
        Appearance18.BackColor = System.Drawing.SystemColors.Control
        Appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance18.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance18.BorderColor = System.Drawing.SystemColors.Window
        Me.grdGruppeRabatter.DisplayLayout.Override.GroupByRowAppearance = Appearance18
        Appearance19.TextHAlignAsString = "Left"
        Me.grdGruppeRabatter.DisplayLayout.Override.HeaderAppearance = Appearance19
        Me.grdGruppeRabatter.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Me.grdGruppeRabatter.DisplayLayout.Override.RowAppearance = Appearance20
        Me.grdGruppeRabatter.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdGruppeRabatter.DisplayLayout.Override.TemplateAddRowAppearance = Appearance21
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
        'TblGruppeRabatterBindingSource
        '
        Me.TblGruppeRabatterBindingSource.DataMember = "tblGruppeRabatter"
        Me.TblGruppeRabatterBindingSource.DataSource = Me.DstGruppeRabatter
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
        CType(Me.tabPlacering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPlacering.ResumeLayout(False)
        Me.tbpPlaceringShared.ResumeLayout(False)
        CType(Me.TblGruppeRabatterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstGruppeRabatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents grdGruppeRabatter As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents DstGruppeRabatter As WinPlanner.dstGruppeRabatter
  Friend WithEvents TblGruppeRabatterTableAdapter As WinPlanner.dstGruppeRabatterTableAdapters.tblGruppeRabatterTableAdapter
  Friend WithEvents TblGruppeRabatterBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents tabPlacering As Infragistics.Win.UltraWinTabControl.UltraTabStripControl
  Friend WithEvents tbpPlaceringShared As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
End Class
