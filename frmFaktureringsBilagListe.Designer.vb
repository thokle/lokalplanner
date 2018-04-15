<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaktureringsBilagListe
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
    Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblFaktureringsBilag", -1)
    Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedieplanNr")
    Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BemærkningNr")
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UgeavisNavn")
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Oprettet")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OprettetAf")
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Version", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
    Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge")
    Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaktureringsBilagListe))
    Me.grdFaktureringsBilag = New Infragistics.Win.UltraWinGrid.UltraGrid
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton
    Me.TblFaktureringsBilagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstFaktureringsBilagListe = New WinPlanner.dstFaktureringsBilagListe
    Me.TblFaktureringsBilagTableAdapter = New WinPlanner.dstFaktureringsBilagListeTableAdapters.tblFaktureringsBilagTableAdapter
    CType(Me.grdFaktureringsBilag, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblFaktureringsBilagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstFaktureringsBilagListe, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdFaktureringsBilag
    '
    Me.grdFaktureringsBilag.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdFaktureringsBilag.DataSource = Me.TblFaktureringsBilagBindingSource
    Appearance21.BackColor = System.Drawing.SystemColors.Window
    Appearance21.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdFaktureringsBilag.DisplayLayout.Appearance = Appearance21
    UltraGridColumn1.Header.Caption = "Medieplan Nr."
    UltraGridColumn1.Header.VisiblePosition = 0
    UltraGridColumn2.Header.Caption = "Bemærkning Nr."
    UltraGridColumn2.Header.VisiblePosition = 1
    UltraGridColumn3.Header.Caption = "Ugeavis"
    UltraGridColumn3.Header.VisiblePosition = 2
    UltraGridColumn4.Header.Caption = "Oprettet dato"
    UltraGridColumn4.Header.VisiblePosition = 3
    UltraGridColumn4.Width = 159
    UltraGridColumn5.Header.Caption = "Oprettet af"
    UltraGridColumn5.Header.VisiblePosition = 4
    UltraGridColumn6.Header.VisiblePosition = 5
    UltraGridColumn6.Hidden = True
    UltraGridColumn7.Header.Caption = "Indryknings Uge"
    UltraGridColumn7.Header.VisiblePosition = 6
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
    Me.grdFaktureringsBilag.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdFaktureringsBilag.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdFaktureringsBilag.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance22.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance22.BorderColor = System.Drawing.SystemColors.Window
    Me.grdFaktureringsBilag.DisplayLayout.GroupByBox.Appearance = Appearance22
    Appearance23.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdFaktureringsBilag.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance23
    Me.grdFaktureringsBilag.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdFaktureringsBilag.DisplayLayout.GroupByBox.Hidden = True
    Appearance24.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance24.BackColor2 = System.Drawing.SystemColors.Control
    Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance24.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdFaktureringsBilag.DisplayLayout.GroupByBox.PromptAppearance = Appearance24
    Me.grdFaktureringsBilag.DisplayLayout.MaxColScrollRegions = 1
    Me.grdFaktureringsBilag.DisplayLayout.MaxRowScrollRegions = 1
    Appearance13.BackColor = System.Drawing.SystemColors.Window
    Appearance13.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdFaktureringsBilag.DisplayLayout.Override.ActiveCellAppearance = Appearance13
    Appearance14.BackColor = System.Drawing.SystemColors.Highlight
    Appearance14.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdFaktureringsBilag.DisplayLayout.Override.ActiveRowAppearance = Appearance14
    Me.grdFaktureringsBilag.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdFaktureringsBilag.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdFaktureringsBilag.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdFaktureringsBilag.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdFaktureringsBilag.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdFaktureringsBilag.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance15.BackColor = System.Drawing.SystemColors.Window
    Me.grdFaktureringsBilag.DisplayLayout.Override.CardAreaAppearance = Appearance15
    Appearance16.BorderColor = System.Drawing.Color.Silver
    Appearance16.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdFaktureringsBilag.DisplayLayout.Override.CellAppearance = Appearance16
    Me.grdFaktureringsBilag.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    Me.grdFaktureringsBilag.DisplayLayout.Override.CellPadding = 0
    Appearance17.BackColor = System.Drawing.SystemColors.Control
    Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance17.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance17.BorderColor = System.Drawing.SystemColors.Window
    Me.grdFaktureringsBilag.DisplayLayout.Override.GroupByRowAppearance = Appearance17
    Appearance18.TextHAlignAsString = "Left"
    Me.grdFaktureringsBilag.DisplayLayout.Override.HeaderAppearance = Appearance18
    Me.grdFaktureringsBilag.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdFaktureringsBilag.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance19.BackColor = System.Drawing.SystemColors.Window
    Appearance19.BorderColor = System.Drawing.Color.Silver
    Me.grdFaktureringsBilag.DisplayLayout.Override.RowAppearance = Appearance19
    Me.grdFaktureringsBilag.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdFaktureringsBilag.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdFaktureringsBilag.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdFaktureringsBilag.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdFaktureringsBilag.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
    Appearance20.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdFaktureringsBilag.DisplayLayout.Override.TemplateAddRowAppearance = Appearance20
    Me.grdFaktureringsBilag.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdFaktureringsBilag.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdFaktureringsBilag.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
    Me.grdFaktureringsBilag.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdFaktureringsBilag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdFaktureringsBilag.Location = New System.Drawing.Point(3, 5)
    Me.grdFaktureringsBilag.Name = "grdFaktureringsBilag"
    Me.grdFaktureringsBilag.Size = New System.Drawing.Size(943, 464)
    Me.grdFaktureringsBilag.TabIndex = 0
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.Location = New System.Drawing.Point(842, 475)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.ShowFocusRect = False
    Me.btnLuk.ShowOutline = False
    Me.btnLuk.Size = New System.Drawing.Size(87, 24)
    Me.btnLuk.TabIndex = 339
    Me.btnLuk.Text = "Luk"
    Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'TblFaktureringsBilagBindingSource
    '
    Me.TblFaktureringsBilagBindingSource.DataMember = "tblFaktureringsBilag"
    Me.TblFaktureringsBilagBindingSource.DataSource = Me.DstFaktureringsBilagListe
    '
    'DstFaktureringsBilagListe
    '
    Me.DstFaktureringsBilagListe.DataSetName = "dstFaktureringsBilagListe"
    Me.DstFaktureringsBilagListe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'TblFaktureringsBilagTableAdapter
    '
    Me.TblFaktureringsBilagTableAdapter.ClearBeforeFill = True
    '
    'frmFakturaBilagListe
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(941, 511)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.grdFaktureringsBilag)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmFakturaBilagListe"
    Me.Text = "Åbne Faktura Bilag"
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.grdFaktureringsBilag, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblFaktureringsBilagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstFaktureringsBilagListe, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grdFaktureringsBilag As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents DstFaktureringsBilagListe As WinPlanner.dstFaktureringsBilagListe
  Friend WithEvents TblFaktureringsBilagBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblFaktureringsBilagTableAdapter As WinPlanner.dstFaktureringsBilagListeTableAdapters.tblFaktureringsBilagTableAdapter
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
End Class
