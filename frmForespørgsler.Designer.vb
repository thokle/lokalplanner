<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForespørgsler
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblWEBForespørgsel", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ForespørgselID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Type")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedieplanNr", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mediebureau")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KonsulentCode")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalBlade")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Format")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalFarver")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalIndrykninger")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SvarInden")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Afsluttet")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bemærkning")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Name")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Betegnelse")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tblWEBForespørgselLinjer_tblWEBForespørgsel")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblWEBForespørgselLinjer_tblWEBForespørgsel", 0)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ForespørgselID")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DLUMmPris")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DLUMmRabat")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DLUFarveTillæg")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DLUFarveRabat")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladMmPris")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladMmRabat")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladFarveTillæg")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladFarveRabat")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladBemærkning")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Navn", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PersonNavn")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlaceringUdenBeregning")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForespørgsler))
        Me.grdForespørgsler = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TblWEBForespørgselBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstForespørgsler = New WinPlanner.dstForespørgsler()
        Me.TblWEBForespørgselTableAdapter = New WinPlanner.dstForespørgslerTableAdapters.tblWEBForespørgselTableAdapter()
        Me.TblWEBForespørgselLinjerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblWEBForespørgselLinjerTableAdapter = New WinPlanner.dstForespørgslerTableAdapters.tblWEBForespørgselLinjerTableAdapter()
        Me.btnSendRykker = New Infragistics.Win.Misc.UltraButton()
        CType(Me.grdForespørgsler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblWEBForespørgselBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstForespørgsler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblWEBForespørgselLinjerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdForespørgsler
        '
        Me.grdForespørgsler.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdForespørgsler.DataSource = Me.TblWEBForespørgselBindingSource
        Me.grdForespørgsler.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "Medieplan Nr"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn5.Header.Caption = "Konsulent"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 70
        UltraGridColumn6.Header.Caption = "Antal blade"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn8.Header.Caption = "Antal farver"
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Width = 87
        UltraGridColumn9.Header.Caption = "Antal indrykninger"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Width = 106
        UltraGridColumn10.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.PlainText
        UltraGridColumn10.Format = ""
        UltraGridColumn10.Header.Caption = "Svar inden"
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Width = 113
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Width = 165
        UltraGridColumn13.Header.Caption = "Annoncør"
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.Header.Caption = "Placering"
        UltraGridColumn14.Header.VisiblePosition = 7
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridBand1.ScrollTipField = "ForespørgselID"
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.Hidden = True
        Appearance9.BackColor = System.Drawing.Color.LightSkyBlue
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance9
        UltraGridColumn18.Format = "#0.00"
        UltraGridColumn18.Header.Caption = "Mm Pris"
        UltraGridColumn18.Header.VisiblePosition = 3
        Appearance10.BackColor = System.Drawing.Color.LightSkyBlue
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance10
        UltraGridColumn19.Format = "#0.00"
        UltraGridColumn19.Header.Caption = "Mm Rabat"
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Width = 70
        Appearance11.BackColor = System.Drawing.Color.LightSkyBlue
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance11
        UltraGridColumn20.Format = "#0.00"
        UltraGridColumn20.Header.Caption = "Farve Pris"
        UltraGridColumn20.Header.VisiblePosition = 7
        Appearance12.BackColor = System.Drawing.Color.LightSkyBlue
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance12
        UltraGridColumn21.Format = "#0.00"
        UltraGridColumn21.Header.Caption = "Farve Rabat"
        UltraGridColumn21.Header.VisiblePosition = 9
        UltraGridColumn21.Width = 87
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance13
        UltraGridColumn22.Format = "#0.00"
        UltraGridColumn22.Header.Caption = "Mm Pris"
        UltraGridColumn22.Header.VisiblePosition = 4
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance14
        UltraGridColumn23.Format = "#0.00"
        UltraGridColumn23.Header.Caption = "Mm Rabat"
        UltraGridColumn23.Header.VisiblePosition = 6
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance15
        UltraGridColumn24.Format = "#0.00"
        UltraGridColumn24.Header.Caption = "Farve Pris"
        UltraGridColumn24.Header.VisiblePosition = 8
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance16
        UltraGridColumn25.Format = "#0.00"
        UltraGridColumn25.Header.Caption = "Farve Rabat"
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn25.Width = 102
        UltraGridColumn26.Header.Caption = "Bemærkning fra blad"
        UltraGridColumn26.Header.VisiblePosition = 12
        UltraGridColumn27.Header.Caption = "Ugeavis"
        UltraGridColumn27.Header.VisiblePosition = 2
        UltraGridColumn27.Width = 175
        UltraGridColumn28.Header.Caption = "Besvaret af"
        UltraGridColumn28.Header.VisiblePosition = 13
        UltraGridColumn28.Width = 91
        UltraGridColumn29.Header.Caption = "PlaceringUB"
        UltraGridColumn29.Header.VisiblePosition = 11
        UltraGridColumn29.Width = 84
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        Me.grdForespørgsler.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdForespørgsler.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grdForespørgsler.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdForespørgsler.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Me.grdForespørgsler.DisplayLayout.GroupByBox.Hidden = True
        Me.grdForespørgsler.DisplayLayout.MaxColScrollRegions = 1
        Me.grdForespørgsler.DisplayLayout.MaxRowScrollRegions = 1
        Me.grdForespørgsler.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdForespørgsler.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grdForespørgsler.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdForespørgsler.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdForespørgsler.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdForespørgsler.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdForespørgsler.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdForespørgsler.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdForespørgsler.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grdForespørgsler.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdForespørgsler.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdForespørgsler.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdForespørgsler.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdForespørgsler.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdForespørgsler.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
        Me.grdForespørgsler.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdForespørgsler.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdForespørgsler.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grdForespørgsler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdForespørgsler.Location = New System.Drawing.Point(0, 0)
        Me.grdForespørgsler.Name = "grdForespørgsler"
        Me.grdForespørgsler.Size = New System.Drawing.Size(898, 439)
        Me.grdForespørgsler.TabIndex = 1
        '
        'TblWEBForespørgselBindingSource
        '
        Me.TblWEBForespørgselBindingSource.DataMember = "tblWEBForespørgsel"
        Me.TblWEBForespørgselBindingSource.DataSource = Me.DstForespørgsler
        '
        'DstForespørgsler
        '
        Me.DstForespørgsler.DataSetName = "dstForespørgsler"
        Me.DstForespørgsler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblWEBForespørgselTableAdapter
        '
        Me.TblWEBForespørgselTableAdapter.ClearBeforeFill = True
        '
        'TblWEBForespørgselLinjerBindingSource
        '
        Me.TblWEBForespørgselLinjerBindingSource.DataMember = "tblWEBForespørgselLinjer"
        Me.TblWEBForespørgselLinjerBindingSource.DataSource = Me.DstForespørgsler
        '
        'TblWEBForespørgselLinjerTableAdapter
        '
        Me.TblWEBForespørgselLinjerTableAdapter.ClearBeforeFill = True
        '
        'btnSendRykker
        '
        Me.btnSendRykker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSendRykker.Enabled = False
        Me.btnSendRykker.Location = New System.Drawing.Point(12, 445)
        Me.btnSendRykker.Name = "btnSendRykker"
        Me.btnSendRykker.ShowFocusRect = False
        Me.btnSendRykker.ShowOutline = False
        Me.btnSendRykker.Size = New System.Drawing.Size(87, 24)
        Me.btnSendRykker.TabIndex = 337
        Me.btnSendRykker.Text = "&Send rykker"
        Me.btnSendRykker.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'frmForespørgsler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 481)
        Me.Controls.Add(Me.btnSendRykker)
        Me.Controls.Add(Me.grdForespørgsler)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmForespørgsler"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Forespørgsler"
        CType(Me.grdForespørgsler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblWEBForespørgselBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstForespørgsler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblWEBForespørgselLinjerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents DstForespørgsler As WinPlanner.dstForespørgsler
  Friend WithEvents TblWEBForespørgselBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblWEBForespørgselTableAdapter As WinPlanner.dstForespørgslerTableAdapters.tblWEBForespørgselTableAdapter
  Friend WithEvents grdForespørgsler As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents TblWEBForespørgselLinjerBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblWEBForespørgselLinjerTableAdapter As WinPlanner.dstForespørgslerTableAdapters.tblWEBForespørgselLinjerTableAdapter
  Private WithEvents btnSendRykker As Infragistics.Win.Misc.UltraButton
End Class
