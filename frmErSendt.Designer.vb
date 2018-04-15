<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErSendt
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
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("viewOrdreErSendt", -1)
    Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedieplanNr")
    Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Version")
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnnoncørNo_")
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BureauNo_")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Format")
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalFarver")
    Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge")
    Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdreUdsendt")
    Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialeFra")
    Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialeUdsendt")
    Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdreAnsvarlig")
    Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalgsAnsvarlig")
    Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nr")
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErSendt))
    Me.grdOversigt = New Infragistics.Win.UltraWinGrid.UltraGrid
    Me.ViewOrdreErSendtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstErSendt = New WinPlanner.dstErSendt
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton
    Me.btnOpdater = New Infragistics.Win.Misc.UltraButton
    Me.numTilUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Me.numFraUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Me.lblTilUge = New Infragistics.Win.Misc.UltraLabel
    Me.lblFraUge = New Infragistics.Win.Misc.UltraLabel
    Me.ViewOrdreErSendtTableAdapter = New WinPlanner.dstErSendtTableAdapters.viewOrdreErSendtTableAdapter
    CType(Me.grdOversigt, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ViewOrdreErSendtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstErSendt, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdOversigt
    '
    Me.grdOversigt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdOversigt.DataSource = Me.ViewOrdreErSendtBindingSource
    UltraGridColumn1.Header.Caption = "Medieplan Nr"
    UltraGridColumn1.Header.Fixed = True
    UltraGridColumn1.Header.VisiblePosition = 1
    UltraGridColumn1.Hidden = True
    UltraGridColumn1.Width = 70
    UltraGridColumn2.Header.Fixed = True
    UltraGridColumn2.Header.VisiblePosition = 2
    UltraGridColumn2.Hidden = True
    UltraGridColumn3.Header.Caption = "Annoncør"
    UltraGridColumn3.Header.VisiblePosition = 3
    UltraGridColumn3.Width = 91
    UltraGridColumn4.Header.Caption = "Bureau"
    UltraGridColumn4.Header.VisiblePosition = 4
    UltraGridColumn4.Width = 100
    UltraGridColumn5.Header.VisiblePosition = 5
    UltraGridColumn5.Width = 99
    UltraGridColumn6.Header.Caption = "Farver"
    UltraGridColumn6.Header.VisiblePosition = 6
    UltraGridColumn6.Width = 57
    UltraGridColumn7.Header.Caption = "Uge"
    UltraGridColumn7.Header.VisiblePosition = 7
    UltraGridColumn7.Hidden = True
    UltraGridColumn8.Header.Caption = "Ordre Udsendt"
    UltraGridColumn8.Header.VisiblePosition = 8
    UltraGridColumn8.Width = 100
    UltraGridColumn9.Header.Caption = "Materiale Fra"
    UltraGridColumn9.Header.VisiblePosition = 9
    UltraGridColumn9.Width = 99
    UltraGridColumn10.Header.Caption = "Materiale Udsendt"
    UltraGridColumn10.Header.VisiblePosition = 10
    UltraGridColumn10.Width = 119
    UltraGridColumn11.Header.Caption = "Ordre Ansv."
    UltraGridColumn11.Header.VisiblePosition = 11
    UltraGridColumn11.Width = 81
    UltraGridColumn12.Header.Caption = "Salgs Ansv."
    UltraGridColumn12.Header.VisiblePosition = 12
    UltraGridColumn12.Width = 81
    UltraGridColumn13.Header.Caption = "Medieplan Nr"
    UltraGridColumn13.Header.VisiblePosition = 0
    UltraGridColumn13.Width = 98
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
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
    Me.grdOversigt.Size = New System.Drawing.Size(879, 368)
    Me.grdOversigt.TabIndex = 0
    Me.grdOversigt.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
    '
    'ViewOrdreErSendtBindingSource
    '
    Me.ViewOrdreErSendtBindingSource.DataMember = "viewOrdreErSendt"
    Me.ViewOrdreErSendtBindingSource.DataSource = Me.DstErSendt
    '
    'DstErSendt
    '
    Me.DstErSendt.DataSetName = "dstErSendt"
    Me.DstErSendt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.Location = New System.Drawing.Point(810, 416)
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
    'ViewOrdreErSendtTableAdapter
    '
    Me.ViewOrdreErSendtTableAdapter.ClearBeforeFill = True
    '
    'frmErSendt
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(903, 445)
    Me.Controls.Add(Me.numTilUge)
    Me.Controls.Add(Me.numFraUge)
    Me.Controls.Add(Me.lblTilUge)
    Me.Controls.Add(Me.lblFraUge)
    Me.Controls.Add(Me.btnOpdater)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.grdOversigt)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmErSendt"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Oversigt Uge"
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.grdOversigt, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ViewOrdreErSendtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstErSendt, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents grdOversigt As Infragistics.Win.UltraWinGrid.UltraGrid
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnOpdater As Infragistics.Win.Misc.UltraButton
  Friend WithEvents numTilUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents numFraUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lblTilUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblFraUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents DstErSendt As WinPlanner.dstErSendt
  Friend WithEvents ViewOrdreErSendtBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents ViewOrdreErSendtTableAdapter As WinPlanner.dstErSendtTableAdapters.viewOrdreErSendtTableAdapter
End Class
