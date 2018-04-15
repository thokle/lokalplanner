<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBerskeAfstemning
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
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblBergskeAfstemning", -1)
    Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nr")
    Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Annonc¯r")
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge")
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ugeavis")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mm")
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Netto", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
    Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBerskeAfstemning))
    Me.grdAfstemning = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton()
    Me.btnOpdater = New Infragistics.Win.Misc.UltraButton()
    Me.numTilUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.numFraUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.lblTilUge = New Infragistics.Win.Misc.UltraLabel()
    Me.lblFraUge = New Infragistics.Win.Misc.UltraLabel()
    Me.num≈r = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.btnTilExcel = New Infragistics.Win.Misc.UltraButton()
    Me.ExcelExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
    Me.DstBergskeAfstemningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstBergskeAfstemning = New WinPlanner.dstBergskeAfstemning()
    Me.TblBergskeAfstemningTableAdapter = New WinPlanner.dstBergskeAfstemningTableAdapters.tblBergskeAfstemningTableAdapter()
    CType(Me.grdAfstemning, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.num≈r, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstBergskeAfstemningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstBergskeAfstemning, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdAfstemning
    '
    Me.grdAfstemning.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdAfstemning.DataSource = Me.DstBergskeAfstemningBindingSource
    UltraGridColumn1.Header.Caption = "Ordre Nr"
    UltraGridColumn1.Header.Fixed = True
    UltraGridColumn1.Header.VisiblePosition = 0
    UltraGridColumn1.Width = 80
    UltraGridColumn2.Header.VisiblePosition = 2
    UltraGridColumn2.Width = 244
    UltraGridColumn3.Header.Caption = "Indryknings Uge"
    UltraGridColumn3.Header.VisiblePosition = 1
    UltraGridColumn3.Width = 92
    UltraGridColumn4.Header.VisiblePosition = 3
    UltraGridColumn4.Width = 164
    UltraGridColumn5.Header.VisiblePosition = 4
    Appearance3.TextHAlignAsString = "Right"
    UltraGridColumn6.CellAppearance = Appearance3
    UltraGridColumn6.Format = "#,##0.00"
    Appearance4.TextHAlignAsString = "Right"
    UltraGridColumn6.Header.Appearance = Appearance4
    UltraGridColumn6.Header.Caption = "Netto bel¯b"
    UltraGridColumn6.Header.VisiblePosition = 5
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
    Appearance2.TextHAlignAsString = "Left"
    UltraGridBand1.Override.HeaderAppearance = Appearance2
    UltraGridBand1.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
    UltraGridBand1.ScrollTipField = "Nr"
    Me.grdAfstemning.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdAfstemning.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
    Me.grdAfstemning.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
    Me.grdAfstemning.DisplayLayout.GroupByBox.Hidden = True
    Me.grdAfstemning.DisplayLayout.MaxColScrollRegions = 1
    Me.grdAfstemning.DisplayLayout.MaxRowScrollRegions = 1
    Me.grdAfstemning.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdAfstemning.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdAfstemning.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdAfstemning.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    Me.grdAfstemning.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdAfstemning.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdAfstemning.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
    Me.grdAfstemning.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
    Me.grdAfstemning.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
    Me.grdAfstemning.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Both
    Me.grdAfstemning.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdAfstemning.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdAfstemning.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
    Me.grdAfstemning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdAfstemning.Location = New System.Drawing.Point(0, 40)
    Me.grdAfstemning.Name = "grdAfstemning"
    Me.grdAfstemning.Size = New System.Drawing.Size(864, 368)
    Me.grdAfstemning.TabIndex = 0
    Me.grdAfstemning.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.Location = New System.Drawing.Point(808, 416)
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
    Me.btnOpdater.Location = New System.Drawing.Point(283, 7)
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
    'num≈r
    '
    Me.num≈r.Location = New System.Drawing.Point(198, 8)
    Me.num≈r.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
    Me.num≈r.MaskInput = "nnnn"
    Me.num≈r.MaxValue = 2020
    Me.num≈r.MinValue = 1996
    Me.num≈r.Name = "num≈r"
    Me.num≈r.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.num≈r.Size = New System.Drawing.Size(68, 21)
    Me.num≈r.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
    Me.num≈r.SpinWrap = True
    Me.num≈r.TabIndex = 343
    Me.num≈r.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
    Me.num≈r.Value = 2007
    '
    'btnTilExcel
    '
    Me.btnTilExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnTilExcel.Location = New System.Drawing.Point(4, 416)
    Me.btnTilExcel.Name = "btnTilExcel"
    Me.btnTilExcel.ShowFocusRect = False
    Me.btnTilExcel.ShowOutline = False
    Me.btnTilExcel.Size = New System.Drawing.Size(87, 24)
    Me.btnTilExcel.TabIndex = 375
    Me.btnTilExcel.Text = "Send til Excel"
    Me.btnTilExcel.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    Me.btnTilExcel.UseMnemonic = False
    '
    'DstBergskeAfstemningBindingSource
    '
    Me.DstBergskeAfstemningBindingSource.DataMember = "tblBergskeAfstemning"
    Me.DstBergskeAfstemningBindingSource.DataSource = Me.DstBergskeAfstemning
    '
    'DstBergskeAfstemning
    '
    Me.DstBergskeAfstemning.DataSetName = "dstBergskeAfstemning"
    Me.DstBergskeAfstemning.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'TblBergskeAfstemningTableAdapter
    '
    Me.TblBergskeAfstemningTableAdapter.ClearBeforeFill = True
    '
    'frmBerskeAfstemning
    '
    Me.AcceptButton = Me.btnOpdater
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(901, 445)
    Me.Controls.Add(Me.btnTilExcel)
    Me.Controls.Add(Me.num≈r)
    Me.Controls.Add(Me.numTilUge)
    Me.Controls.Add(Me.numFraUge)
    Me.Controls.Add(Me.lblTilUge)
    Me.Controls.Add(Me.lblFraUge)
    Me.Controls.Add(Me.btnOpdater)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.grdAfstemning)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmBerskeAfstemning"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Bergske Afstemning"
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.grdAfstemning, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.num≈r, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstBergskeAfstemningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstBergskeAfstemning, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents grdAfstemning As Infragistics.Win.UltraWinGrid.UltraGrid
  Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnOpdater As Infragistics.Win.Misc.UltraButton
  Friend WithEvents numTilUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents numFraUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lblTilUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblFraUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents DstBergskeAfstemningBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents DstBergskeAfstemning As WinPlanner.dstBergskeAfstemning
  Friend WithEvents num≈r As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents TblBergskeAfstemningTableAdapter As WinPlanner.dstBergskeAfstemningTableAdapters.tblBergskeAfstemningTableAdapter
  Private WithEvents btnTilExcel As Infragistics.Win.Misc.UltraButton
  Friend WithEvents ExcelExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
End Class
