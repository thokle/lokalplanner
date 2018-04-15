<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFejlListe
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
    Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblLinjerMedFejl", -1)
    Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedieplanNr")
    Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Version")
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UgeavisID")
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Navn")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnnoncørNo_")
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FejlTekst")
    Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nr")
    Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge")
    Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFejlListe))
    Me.grdFejlListe = New Infragistics.Win.UltraWinGrid.UltraGrid
    Me.TblLinjerMedFejlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstFindLinjerMedFejl = New WinPlanner.dstFindLinjerMedFejl
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton
    Me.TblLinjerMedFejlTableAdapter = New WinPlanner.dstFindLinjerMedFejlTableAdapters.tblLinjerMedFejlTableAdapter
    CType(Me.grdFejlListe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblLinjerMedFejlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstFindLinjerMedFejl, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdFejlListe
    '
    Me.grdFejlListe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdFejlListe.DataSource = Me.TblLinjerMedFejlBindingSource
    Appearance49.BackColor = System.Drawing.SystemColors.Window
    Appearance49.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdFejlListe.DisplayLayout.Appearance = Appearance49
    Me.grdFejlListe.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
    UltraGridColumn1.Header.VisiblePosition = 1
    UltraGridColumn1.Hidden = True
    UltraGridColumn1.Width = 212
    UltraGridColumn2.Header.VisiblePosition = 2
    UltraGridColumn2.Hidden = True
    UltraGridColumn2.Width = 121
    UltraGridColumn3.Header.VisiblePosition = 3
    UltraGridColumn3.Hidden = True
    UltraGridColumn3.Width = 173
    UltraGridColumn4.Header.Caption = "Ugeavis"
    UltraGridColumn4.Header.VisiblePosition = 4
    UltraGridColumn4.Width = 291
    UltraGridColumn5.Header.Caption = "Annoncør"
    UltraGridColumn5.Header.VisiblePosition = 5
    UltraGridColumn5.Width = 273
    UltraGridColumn6.Header.Caption = "Fejl Tekst"
    UltraGridColumn6.Header.VisiblePosition = 6
    UltraGridColumn6.Width = 286
    UltraGridColumn7.Header.Caption = "Medieplan Nr"
    UltraGridColumn7.Header.VisiblePosition = 0
    UltraGridColumn7.Width = 95
    UltraGridColumn8.Header.Caption = "Uge"
    UltraGridColumn8.Header.VisiblePosition = 7
    UltraGridColumn8.Width = 93
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
    UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    UltraGridBand1.ScrollTipField = "MedieplanNr"
    Me.grdFejlListe.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdFejlListe.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdFejlListe.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance50.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance50.BorderColor = System.Drawing.SystemColors.Window
    Me.grdFejlListe.DisplayLayout.GroupByBox.Appearance = Appearance50
    Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdFejlListe.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance51
    Me.grdFejlListe.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdFejlListe.DisplayLayout.GroupByBox.Hidden = True
    Appearance52.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance52.BackColor2 = System.Drawing.SystemColors.Control
    Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdFejlListe.DisplayLayout.GroupByBox.PromptAppearance = Appearance52
    Me.grdFejlListe.DisplayLayout.MaxColScrollRegions = 1
    Me.grdFejlListe.DisplayLayout.MaxRowScrollRegions = 1
    Appearance53.BackColor = System.Drawing.SystemColors.Window
    Appearance53.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdFejlListe.DisplayLayout.Override.ActiveCellAppearance = Appearance53
    Appearance54.BackColor = System.Drawing.SystemColors.Highlight
    Appearance54.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdFejlListe.DisplayLayout.Override.ActiveRowAppearance = Appearance54
    Me.grdFejlListe.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdFejlListe.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance55.BackColor = System.Drawing.SystemColors.Window
    Me.grdFejlListe.DisplayLayout.Override.CardAreaAppearance = Appearance55
    Appearance56.BorderColor = System.Drawing.Color.Silver
    Appearance56.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdFejlListe.DisplayLayout.Override.CellAppearance = Appearance56
    Me.grdFejlListe.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.grdFejlListe.DisplayLayout.Override.CellPadding = 0
    Appearance57.BackColor = System.Drawing.SystemColors.Control
    Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance57.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance57.BorderColor = System.Drawing.SystemColors.Window
    Me.grdFejlListe.DisplayLayout.Override.GroupByRowAppearance = Appearance57
    Appearance58.TextHAlignAsString = "Left"
    Me.grdFejlListe.DisplayLayout.Override.HeaderAppearance = Appearance58
    Me.grdFejlListe.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdFejlListe.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance59.BackColor = System.Drawing.SystemColors.Window
    Appearance59.BorderColor = System.Drawing.Color.Silver
    Me.grdFejlListe.DisplayLayout.Override.RowAppearance = Appearance59
    Me.grdFejlListe.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdFejlListe.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
    Me.grdFejlListe.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
    Appearance60.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdFejlListe.DisplayLayout.Override.TemplateAddRowAppearance = Appearance60
    Me.grdFejlListe.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
    Me.grdFejlListe.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdFejlListe.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdFejlListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdFejlListe.Location = New System.Drawing.Point(0, -1)
    Me.grdFejlListe.Name = "grdFejlListe"
    Me.grdFejlListe.Size = New System.Drawing.Size(1059, 420)
    Me.grdFejlListe.TabIndex = 0
    '
    'TblLinjerMedFejlBindingSource
    '
    Me.TblLinjerMedFejlBindingSource.DataMember = "tblLinjerMedFejl"
    Me.TblLinjerMedFejlBindingSource.DataSource = Me.DstFindLinjerMedFejl
    '
    'DstFindLinjerMedFejl
    '
    Me.DstFindLinjerMedFejl.DataSetName = "dstFindLinjerMedFejl"
    Me.DstFindLinjerMedFejl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.Location = New System.Drawing.Point(959, 425)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.ShowFocusRect = False
    Me.btnLuk.ShowOutline = False
    Me.btnLuk.Size = New System.Drawing.Size(87, 24)
    Me.btnLuk.TabIndex = 338
    Me.btnLuk.Text = "Luk"
    Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'TblLinjerMedFejlTableAdapter
    '
    Me.TblLinjerMedFejlTableAdapter.ClearBeforeFill = True
    '
    'frmFejlListe
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1058, 461)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.grdFejlListe)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmFejlListe"
    Me.Text = "Fejl Liste"
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.grdFejlListe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblLinjerMedFejlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstFindLinjerMedFejl, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grdFejlListe As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents DstFindLinjerMedFejl As WinPlanner.dstFindLinjerMedFejl
  Friend WithEvents TblLinjerMedFejlBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblLinjerMedFejlTableAdapter As WinPlanner.dstFindLinjerMedFejlTableAdapters.tblLinjerMedFejlTableAdapter
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
End Class
