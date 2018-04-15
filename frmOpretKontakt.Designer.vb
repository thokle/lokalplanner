<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpretKontakt
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
    Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblBladStamdataKopi", -1)
    Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
    Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Navn")
    Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejerforhold")
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegionNavn")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Funktioner", 0, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
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
    Me.cboArbOmråder = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
    Me.TblKontaktArbOmråderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstKontaktArbOmråder = New WinPlanner.dstKontaktArbOmråder()
    Me.TblKontaktTitlerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstKontaktTitlerDropdown = New WinPlanner.dstKontaktTitlerDropdown()
    Me.cbeFunktioner = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
    Me.TblKontaktFunktionerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstKontaktFunktionerDropdown = New WinPlanner.dstKontaktFunktionerDropdown()
    Me.lblFornavn = New Infragistics.Win.Misc.UltraLabel()
    Me.lblEfternavn = New Infragistics.Win.Misc.UltraLabel()
    Me.lblTlfNr = New Infragistics.Win.Misc.UltraLabel()
    Me.lblMobilNr = New Infragistics.Win.Misc.UltraLabel()
    Me.lblEmail = New Infragistics.Win.Misc.UltraLabel()
    Me.txtFornavn = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.txtEfternavn = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.txtEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.TblKontaktTitlerTableAdapter = New WinPlanner.dstKontaktTitlerDropdownTableAdapters.tblKontaktTitlerTableAdapter()
    Me.TblKontaktFunktionerTableAdapter = New WinPlanner.dstKontaktFunktionerDropdownTableAdapters.tblKontaktFunktionerTableAdapter()
    Me.grdKontakterPrBlad = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.btnOpretTitel = New Infragistics.Win.Misc.UltraButton()
    Me.txtTitel = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.btnAnnullerTitel = New Infragistics.Win.Misc.UltraButton()
    Me.btnGemTitel = New Infragistics.Win.Misc.UltraButton()
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
    Me.btnGem = New Infragistics.Win.Misc.UltraButton()
    Me.cboTitel = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
    Me.TblKontaktArbOmråderTableAdapter = New WinPlanner.dstKontaktArbOmråderTableAdapters.tblKontaktArbOmråderTableAdapter()
    Me.lblTitel = New Infragistics.Win.Misc.UltraLabel()
    Me.lblArbOmråder = New Infragistics.Win.Misc.UltraLabel()
    Me.txtTlfNr = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.txtMobilNr = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.btnOpretArbOmråde = New Infragistics.Win.Misc.UltraButton()
    Me.btnGemArbOmråde = New Infragistics.Win.Misc.UltraButton()
    Me.btnAnnullerArbOmråde = New Infragistics.Win.Misc.UltraButton()
    Me.txtArbOmråde = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.cboEjerforhold = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
    Me.TblBladStamdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.EjerforholdDropdown = New WinPlanner.EjerforholdDropdown()
    Me.DstKontakterPrBladBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstKontakterPrBlad = New WinPlanner.dstKontakterPrBlad()
    Me.TblBladStamdataKopiTableAdapter = New WinPlanner.dstKontakterPrBladTableAdapters.tblBladStamdataKopiTableAdapter()
    Me.TblBladStamdataTableAdapter = New WinPlanner.EjerforholdDropdownTableAdapters.tblBladStamdataTableAdapter()
    Me.lblEjerforhold = New Infragistics.Win.Misc.UltraLabel()
    CType(Me.cboArbOmråder, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblKontaktArbOmråderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstKontaktArbOmråder, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblKontaktTitlerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstKontaktTitlerDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cbeFunktioner, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblKontaktFunktionerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstKontaktFunktionerDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFornavn, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtEfternavn, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdKontakterPrBlad, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTitel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboTitel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtArbOmråde, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboEjerforhold, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblBladStamdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EjerforholdDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstKontakterPrBladBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstKontakterPrBlad, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboArbOmråder
    '
    Me.cboArbOmråder.CheckedListSettings.CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox
    Me.cboArbOmråder.CheckedListSettings.EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems
    Me.cboArbOmråder.CheckedListSettings.ItemCheckArea = Infragistics.Win.ItemCheckArea.Item
    Me.cboArbOmråder.CheckedListSettings.ListSeparator = ";"
    Me.cboArbOmråder.DataSource = Me.TblKontaktArbOmråderBindingSource
    Me.cboArbOmråder.DisplayMember = "ArbOmråde"
    Me.cboArbOmråder.Location = New System.Drawing.Point(82, 170)
    Me.cboArbOmråder.Name = "cboArbOmråder"
    Me.cboArbOmråder.NullText = "- Vælg arbejdsområder -"
    Me.cboArbOmråder.Size = New System.Drawing.Size(205, 21)
    Me.cboArbOmråder.TabIndex = 15
    Me.cboArbOmråder.Tag = "Toggle"
    '
    'TblKontaktArbOmråderBindingSource
    '
    Me.TblKontaktArbOmråderBindingSource.DataMember = "tblKontaktArbOmråder"
    Me.TblKontaktArbOmråderBindingSource.DataSource = Me.DstKontaktArbOmråder
    '
    'DstKontaktArbOmråder
    '
    Me.DstKontaktArbOmråder.DataSetName = "dstKontaktArbOmråder"
    Me.DstKontaktArbOmråder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'TblKontaktTitlerBindingSource
    '
    Me.TblKontaktTitlerBindingSource.DataMember = "tblKontaktTitler"
    Me.TblKontaktTitlerBindingSource.DataSource = Me.DstKontaktTitlerDropdown
    '
    'DstKontaktTitlerDropdown
    '
    Me.DstKontaktTitlerDropdown.DataSetName = "dstKontaktTitlerDropdown"
    Me.DstKontaktTitlerDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'cbeFunktioner
    '
    Me.cbeFunktioner.CheckedListSettings.CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox
    Me.cbeFunktioner.CheckedListSettings.EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems
    Me.cbeFunktioner.CheckedListSettings.ItemCheckArea = Infragistics.Win.ItemCheckArea.Item
    Me.cbeFunktioner.CheckedListSettings.ListSeparator = ";"
    Me.cbeFunktioner.DataSource = Me.TblKontaktFunktionerBindingSource
    Me.cbeFunktioner.DisplayMember = "Funktion"
    Me.cbeFunktioner.Location = New System.Drawing.Point(805, 206)
    Me.cbeFunktioner.Name = "cbeFunktioner"
    Me.cbeFunktioner.NullText = "- Vælg funktioner -"
    Appearance1.BackColorAlpha = Infragistics.Win.Alpha.Transparent
    Appearance1.TextHAlignAsString = "Center"
    Me.cbeFunktioner.NullTextAppearance = Appearance1
    Me.cbeFunktioner.Size = New System.Drawing.Size(144, 21)
    Me.cbeFunktioner.TabIndex = 16
    Me.cbeFunktioner.Visible = False
    '
    'TblKontaktFunktionerBindingSource
    '
    Me.TblKontaktFunktionerBindingSource.DataMember = "tblKontaktFunktioner"
    Me.TblKontaktFunktionerBindingSource.DataSource = Me.DstKontaktFunktionerDropdown
    '
    'DstKontaktFunktionerDropdown
    '
    Me.DstKontaktFunktionerDropdown.DataSetName = "dstKontaktFunktionerDropdown"
    Me.DstKontaktFunktionerDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'lblFornavn
    '
    Me.lblFornavn.AutoSize = True
    Me.lblFornavn.Location = New System.Drawing.Point(12, 39)
    Me.lblFornavn.Name = "lblFornavn"
    Me.lblFornavn.Size = New System.Drawing.Size(46, 14)
    Me.lblFornavn.TabIndex = 1
    Me.lblFornavn.Tag = "Toggle"
    Me.lblFornavn.Text = "Fornavn"
    '
    'lblEfternavn
    '
    Me.lblEfternavn.AutoSize = True
    Me.lblEfternavn.Location = New System.Drawing.Point(12, 66)
    Me.lblEfternavn.Name = "lblEfternavn"
    Me.lblEfternavn.Size = New System.Drawing.Size(53, 14)
    Me.lblEfternavn.TabIndex = 3
    Me.lblEfternavn.Tag = "Toggle"
    Me.lblEfternavn.Text = "Efternavn"
    '
    'lblTlfNr
    '
    Me.lblTlfNr.AutoSize = True
    Me.lblTlfNr.Location = New System.Drawing.Point(12, 119)
    Me.lblTlfNr.Name = "lblTlfNr"
    Me.lblTlfNr.Size = New System.Drawing.Size(36, 14)
    Me.lblTlfNr.TabIndex = 4
    Me.lblTlfNr.Tag = "Toggle"
    Me.lblTlfNr.Text = "Tlf. nr."
    '
    'lblMobilNr
    '
    Me.lblMobilNr.AutoSize = True
    Me.lblMobilNr.Location = New System.Drawing.Point(12, 146)
    Me.lblMobilNr.Name = "lblMobilNr"
    Me.lblMobilNr.Size = New System.Drawing.Size(48, 14)
    Me.lblMobilNr.TabIndex = 5
    Me.lblMobilNr.Tag = "Toggle"
    Me.lblMobilNr.Text = "Mobil nr."
    '
    'lblEmail
    '
    Me.lblEmail.AutoSize = True
    Me.lblEmail.Location = New System.Drawing.Point(12, 12)
    Me.lblEmail.Name = "lblEmail"
    Me.lblEmail.Size = New System.Drawing.Size(33, 14)
    Me.lblEmail.TabIndex = 6
    Me.lblEmail.Text = "Email"
    '
    'txtFornavn
    '
    Me.txtFornavn.Location = New System.Drawing.Point(82, 35)
    Me.txtFornavn.MaxLength = 50
    Me.txtFornavn.Name = "txtFornavn"
    Me.txtFornavn.NullText = "- Indtast fornavn -"
    Me.txtFornavn.Size = New System.Drawing.Size(205, 21)
    Me.txtFornavn.TabIndex = 8
    Me.txtFornavn.Tag = "Toggle"
    '
    'txtEfternavn
    '
    Me.txtEfternavn.Location = New System.Drawing.Point(82, 62)
    Me.txtEfternavn.MaxLength = 50
    Me.txtEfternavn.Name = "txtEfternavn"
    Me.txtEfternavn.NullText = "- Indtast efternavn -"
    Me.txtEfternavn.Size = New System.Drawing.Size(205, 21)
    Me.txtEfternavn.TabIndex = 10
    Me.txtEfternavn.Tag = "Toggle"
    '
    'txtEmail
    '
    Me.txtEmail.Location = New System.Drawing.Point(82, 8)
    Me.txtEmail.MaxLength = 50
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.NullText = "- Indtast email -"
    Me.txtEmail.Size = New System.Drawing.Size(205, 21)
    Me.txtEmail.TabIndex = 14
    '
    'TblKontaktTitlerTableAdapter
    '
    Me.TblKontaktTitlerTableAdapter.ClearBeforeFill = True
    '
    'TblKontaktFunktionerTableAdapter
    '
    Me.TblKontaktFunktionerTableAdapter.ClearBeforeFill = True
    '
    'grdKontakterPrBlad
    '
    Me.grdKontakterPrBlad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdKontakterPrBlad.DataSource = Me.DstKontakterPrBladBindingSource
    Appearance2.BackColor = System.Drawing.SystemColors.Window
    Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdKontakterPrBlad.DisplayLayout.Appearance = Appearance2
    Me.grdKontakterPrBlad.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
    UltraGridColumn1.Header.VisiblePosition = 0
    UltraGridColumn1.Hidden = True
    UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    UltraGridColumn2.Header.Caption = "Ugeavis"
    UltraGridColumn2.Header.VisiblePosition = 1
    UltraGridColumn2.MaxWidth = 185
    UltraGridColumn2.MinWidth = 185
    UltraGridColumn2.Width = 185
    UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    UltraGridColumn3.Header.VisiblePosition = 2
    UltraGridColumn3.MaxWidth = 195
    UltraGridColumn3.MinWidth = 195
    UltraGridColumn3.Width = 195
    UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    UltraGridColumn4.Header.Caption = "Region"
    UltraGridColumn4.Header.VisiblePosition = 3
    UltraGridColumn4.MaxWidth = 80
    UltraGridColumn4.MinWidth = 80
    UltraGridColumn4.Width = 80
    UltraGridColumn5.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
    UltraGridColumn5.Header.VisiblePosition = 4
    UltraGridColumn5.Width = 622
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
    UltraGridBand1.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.None
    Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    UltraGridBand1.Override.FixedRowAppearance = Appearance3
    UltraGridBand1.Override.SpecialRowSeparator = Infragistics.Win.UltraWinGrid.SpecialRowSeparator.FixedRows
    Appearance4.BackColor = System.Drawing.Color.Black
    Appearance4.ForeColor = System.Drawing.Color.Black
    UltraGridBand1.Override.SpecialRowSeparatorAppearance = Appearance4
    UltraGridBand1.Override.SpecialRowSeparatorHeight = 10
    Me.grdKontakterPrBlad.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdKontakterPrBlad.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdKontakterPrBlad.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdKontakterPrBlad.DisplayLayout.FixedRowOffImage = Global.WinPlanner.My.Resources.Resources.unchecked
    Me.grdKontakterPrBlad.DisplayLayout.FixedRowOnImage = Global.WinPlanner.My.Resources.Resources.checked
    Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance5.BorderColor = System.Drawing.SystemColors.Window
    Me.grdKontakterPrBlad.DisplayLayout.GroupByBox.Appearance = Appearance5
    Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdKontakterPrBlad.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
    Me.grdKontakterPrBlad.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance7.BackColor2 = System.Drawing.SystemColors.Control
    Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdKontakterPrBlad.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
    Me.grdKontakterPrBlad.DisplayLayout.MaxColScrollRegions = 1
    Me.grdKontakterPrBlad.DisplayLayout.MaxRowScrollRegions = 1
    Me.grdKontakterPrBlad.DisplayLayout.Override.ActiveCellBorderThickness = 0
    Me.grdKontakterPrBlad.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdKontakterPrBlad.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
    Me.grdKontakterPrBlad.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
    Me.grdKontakterPrBlad.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
    Me.grdKontakterPrBlad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdKontakterPrBlad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdKontakterPrBlad.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
    Me.grdKontakterPrBlad.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.None
    Appearance8.BorderColor = System.Drawing.Color.Silver
    Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdKontakterPrBlad.DisplayLayout.Override.CellAppearance = Appearance8
    Me.grdKontakterPrBlad.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    Me.grdKontakterPrBlad.DisplayLayout.Override.CellPadding = 0
    Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Appearance9.ForeColor = System.Drawing.Color.Black
    Appearance9.ForeColorDisabled = System.Drawing.Color.Black
    Me.grdKontakterPrBlad.DisplayLayout.Override.FixedRowAppearance = Appearance9
    Me.grdKontakterPrBlad.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.Button
    Me.grdKontakterPrBlad.DisplayLayout.Override.FixedRowSortOrder = Infragistics.Win.UltraWinGrid.FixedRowSortOrder.Sorted
    Me.grdKontakterPrBlad.DisplayLayout.Override.FixedRowStyle = Infragistics.Win.UltraWinGrid.FixedRowStyle.Top
    Appearance10.TextHAlignAsString = "Left"
    Me.grdKontakterPrBlad.DisplayLayout.Override.HeaderAppearance = Appearance10
    Me.grdKontakterPrBlad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Appearance11.BackColor = System.Drawing.SystemColors.Window
    Appearance11.BorderColor = System.Drawing.Color.Silver
    Appearance11.ForeColor = System.Drawing.Color.Black
    Appearance11.ForeColorDisabled = System.Drawing.Color.Black
    Me.grdKontakterPrBlad.DisplayLayout.Override.RowAppearance = Appearance11
    Me.grdKontakterPrBlad.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
    Me.grdKontakterPrBlad.DisplayLayout.Override.RowSelectorWidth = 16
    Me.grdKontakterPrBlad.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
    Appearance12.BorderAlpha = Infragistics.Win.Alpha.Transparent
    Me.grdKontakterPrBlad.DisplayLayout.Override.SelectedRowAppearance = Appearance12
    Me.grdKontakterPrBlad.DisplayLayout.Override.SpecialRowSeparator = Infragistics.Win.UltraWinGrid.SpecialRowSeparator.FixedRows
    Appearance13.BackColor = System.Drawing.Color.Black
    Appearance13.ForeColor = System.Drawing.Color.Black
    Me.grdKontakterPrBlad.DisplayLayout.Override.SpecialRowSeparatorAppearance = Appearance13
    Me.grdKontakterPrBlad.DisplayLayout.Override.SpecialRowSeparatorHeight = 10
    Me.grdKontakterPrBlad.DisplayLayout.RowSelectorImages.ActiveRowImage = Global.WinPlanner.My.Resources.Resources.prik
    Me.grdKontakterPrBlad.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdKontakterPrBlad.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdKontakterPrBlad.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
    Me.grdKontakterPrBlad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdKontakterPrBlad.Location = New System.Drawing.Point(12, 259)
    Me.grdKontakterPrBlad.Name = "grdKontakterPrBlad"
    Me.grdKontakterPrBlad.Size = New System.Drawing.Size(1100, 222)
    Me.grdKontakterPrBlad.TabIndex = 17
    Me.grdKontakterPrBlad.Tag = "Toggle"
    Me.grdKontakterPrBlad.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
    '
    'btnOpretTitel
    '
    Me.btnOpretTitel.Location = New System.Drawing.Point(342, 61)
    Me.btnOpretTitel.Name = "btnOpretTitel"
    Me.btnOpretTitel.Size = New System.Drawing.Size(119, 23)
    Me.btnOpretTitel.TabIndex = 19
    Me.btnOpretTitel.Text = "Opret Titel"
    '
    'txtTitel
    '
    Me.txtTitel.Location = New System.Drawing.Point(342, 90)
    Me.txtTitel.MaxLength = 30
    Me.txtTitel.Name = "txtTitel"
    Me.txtTitel.NullText = "- Indtast titel -"
    Me.txtTitel.Size = New System.Drawing.Size(239, 21)
    Me.txtTitel.TabIndex = 21
    Me.txtTitel.Visible = False
    '
    'btnAnnullerTitel
    '
    Me.btnAnnullerTitel.Location = New System.Drawing.Point(342, 119)
    Me.btnAnnullerTitel.Name = "btnAnnullerTitel"
    Me.btnAnnullerTitel.Size = New System.Drawing.Size(69, 23)
    Me.btnAnnullerTitel.TabIndex = 22
    Me.btnAnnullerTitel.Text = "Annuller"
    Me.btnAnnullerTitel.Visible = False
    '
    'btnGemTitel
    '
    Me.btnGemTitel.Enabled = False
    Me.btnGemTitel.Location = New System.Drawing.Point(512, 119)
    Me.btnGemTitel.Name = "btnGemTitel"
    Me.btnGemTitel.Size = New System.Drawing.Size(69, 23)
    Me.btnGemTitel.TabIndex = 23
    Me.btnGemTitel.Text = "Gem"
    Me.btnGemTitel.Visible = False
    '
    'btnAnnuller
    '
    Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 487)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.Size = New System.Drawing.Size(69, 23)
    Me.btnAnnuller.TabIndex = 24
    Me.btnAnnuller.Text = "Annuller"
    '
    'btnGem
    '
    Me.btnGem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGem.Enabled = False
    Me.btnGem.Location = New System.Drawing.Point(1043, 487)
    Me.btnGem.Name = "btnGem"
    Me.btnGem.Size = New System.Drawing.Size(69, 23)
    Me.btnGem.TabIndex = 25
    Me.btnGem.Text = "Gem"
    '
    'cboTitel
    '
    Me.cboTitel.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
    Me.cboTitel.DataSource = Me.TblKontaktTitlerBindingSource
    Me.cboTitel.DisplayMember = "Titel"
    Me.cboTitel.Location = New System.Drawing.Point(82, 89)
    Me.cboTitel.Name = "cboTitel"
    Me.cboTitel.NullText = "- Vælg titel -"
    Me.cboTitel.Size = New System.Drawing.Size(205, 21)
    Me.cboTitel.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
    Me.cboTitel.TabIndex = 27
    Me.cboTitel.Tag = "Toggle"
    Me.cboTitel.ValueMember = "TitelID"
    '
    'TblKontaktArbOmråderTableAdapter
    '
    Me.TblKontaktArbOmråderTableAdapter.ClearBeforeFill = True
    '
    'lblTitel
    '
    Me.lblTitel.AutoSize = True
    Me.lblTitel.Location = New System.Drawing.Point(12, 92)
    Me.lblTitel.Name = "lblTitel"
    Me.lblTitel.Size = New System.Drawing.Size(26, 14)
    Me.lblTitel.TabIndex = 28
    Me.lblTitel.Tag = "Toggle"
    Me.lblTitel.Text = "Titel"
    '
    'lblArbOmråder
    '
    Me.lblArbOmråder.AutoSize = True
    Me.lblArbOmråder.Location = New System.Drawing.Point(12, 174)
    Me.lblArbOmråder.Name = "lblArbOmråder"
    Me.lblArbOmråder.Size = New System.Drawing.Size(67, 14)
    Me.lblArbOmråder.TabIndex = 29
    Me.lblArbOmråder.Tag = "Toggle"
    Me.lblArbOmråder.Text = "Arb.områder"
    '
    'txtTlfNr
    '
    Me.txtTlfNr.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtTlfNr.FormatString = "#### ####"
    Me.txtTlfNr.InputMask = "#### ####"
    Me.txtTlfNr.Location = New System.Drawing.Point(82, 116)
    Me.txtTlfNr.Name = "txtTlfNr"
    Me.txtTlfNr.NonAutoSizeHeight = 20
    Me.txtTlfNr.NullText = "- Indtast Tlf. Nr. -"
    Me.txtTlfNr.Size = New System.Drawing.Size(114, 20)
    Me.txtTlfNr.TabIndex = 30
    Me.txtTlfNr.Tag = "Toggle"
    Me.txtTlfNr.Text = " "
    '
    'txtMobilNr
    '
    Me.txtMobilNr.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtMobilNr.FormatString = "#### ####"
    Me.txtMobilNr.InputMask = "#### ####"
    Me.txtMobilNr.Location = New System.Drawing.Point(82, 143)
    Me.txtMobilNr.Name = "txtMobilNr"
    Me.txtMobilNr.NonAutoSizeHeight = 20
    Me.txtMobilNr.NullText = "- Indtast Mobil Nr. -"
    Me.txtMobilNr.Size = New System.Drawing.Size(114, 20)
    Me.txtMobilNr.TabIndex = 31
    Me.txtMobilNr.Tag = "Toggle"
    Me.txtMobilNr.Text = " "
    '
    'btnOpretArbOmråde
    '
    Me.btnOpretArbOmråde.Location = New System.Drawing.Point(342, 141)
    Me.btnOpretArbOmråde.Name = "btnOpretArbOmråde"
    Me.btnOpretArbOmråde.Size = New System.Drawing.Size(119, 23)
    Me.btnOpretArbOmråde.TabIndex = 32
    Me.btnOpretArbOmråde.Text = "Opret Arb. område"
    '
    'btnGemArbOmråde
    '
    Me.btnGemArbOmråde.Enabled = False
    Me.btnGemArbOmråde.Location = New System.Drawing.Point(512, 199)
    Me.btnGemArbOmråde.Name = "btnGemArbOmråde"
    Me.btnGemArbOmråde.Size = New System.Drawing.Size(69, 23)
    Me.btnGemArbOmråde.TabIndex = 36
    Me.btnGemArbOmråde.Text = "Gem"
    Me.btnGemArbOmråde.Visible = False
    '
    'btnAnnullerArbOmråde
    '
    Me.btnAnnullerArbOmråde.Location = New System.Drawing.Point(342, 199)
    Me.btnAnnullerArbOmråde.Name = "btnAnnullerArbOmråde"
    Me.btnAnnullerArbOmråde.Size = New System.Drawing.Size(69, 23)
    Me.btnAnnullerArbOmråde.TabIndex = 35
    Me.btnAnnullerArbOmråde.Text = "Annuller"
    Me.btnAnnullerArbOmråde.Visible = False
    '
    'txtArbOmråde
    '
    Me.txtArbOmråde.Location = New System.Drawing.Point(342, 170)
    Me.txtArbOmråde.MaxLength = 30
    Me.txtArbOmråde.Name = "txtArbOmråde"
    Me.txtArbOmråde.NullText = "- Indtast arb. område -"
    Me.txtArbOmråde.Size = New System.Drawing.Size(239, 21)
    Me.txtArbOmråde.TabIndex = 34
    Me.txtArbOmråde.Visible = False
    '
    'cboEjerforhold
    '
    Me.cboEjerforhold.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
    Me.cboEjerforhold.DataSource = Me.TblBladStamdataBindingSource
    Me.cboEjerforhold.DisplayMember = "Ejerforhold"
    Me.cboEjerforhold.Location = New System.Drawing.Point(82, 197)
    Me.cboEjerforhold.Name = "cboEjerforhold"
    Me.cboEjerforhold.NullText = "- Vælg ejerforhold -"
    Me.cboEjerforhold.Size = New System.Drawing.Size(205, 21)
    Me.cboEjerforhold.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
    Me.cboEjerforhold.TabIndex = 37
    Me.cboEjerforhold.Tag = "Toggle"
    Me.cboEjerforhold.ValueMember = "Ejerforhold"
    '
    'TblBladStamdataBindingSource
    '
    Me.TblBladStamdataBindingSource.DataMember = "tblBladStamdata"
    Me.TblBladStamdataBindingSource.DataSource = Me.EjerforholdDropdown
    '
    'EjerforholdDropdown
    '
    Me.EjerforholdDropdown.DataSetName = "EjerforholdDropdown"
    Me.EjerforholdDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'DstKontakterPrBladBindingSource
    '
    Me.DstKontakterPrBladBindingSource.DataMember = "tblBladStamdataKopi"
    Me.DstKontakterPrBladBindingSource.DataSource = Me.DstKontakterPrBlad
    '
    'DstKontakterPrBlad
    '
    Me.DstKontakterPrBlad.DataSetName = "dstKontakterPrBlad"
    Me.DstKontakterPrBlad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'TblBladStamdataKopiTableAdapter
    '
    Me.TblBladStamdataKopiTableAdapter.ClearBeforeFill = True
    '
    'TblBladStamdataTableAdapter
    '
    Me.TblBladStamdataTableAdapter.ClearBeforeFill = True
    '
    'lblEjerforhold
    '
    Me.lblEjerforhold.AutoSize = True
    Me.lblEjerforhold.Location = New System.Drawing.Point(12, 201)
    Me.lblEjerforhold.Name = "lblEjerforhold"
    Me.lblEjerforhold.Size = New System.Drawing.Size(59, 14)
    Me.lblEjerforhold.TabIndex = 38
    Me.lblEjerforhold.Tag = "Toggle"
    Me.lblEjerforhold.Text = "Ejerforhold"
    '
    'frmOpretKontakt
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1124, 519)
    Me.Controls.Add(Me.lblEjerforhold)
    Me.Controls.Add(Me.cboEjerforhold)
    Me.Controls.Add(Me.btnGemArbOmråde)
    Me.Controls.Add(Me.btnAnnullerArbOmråde)
    Me.Controls.Add(Me.txtArbOmråde)
    Me.Controls.Add(Me.btnOpretArbOmråde)
    Me.Controls.Add(Me.txtMobilNr)
    Me.Controls.Add(Me.txtTlfNr)
    Me.Controls.Add(Me.lblArbOmråder)
    Me.Controls.Add(Me.lblTitel)
    Me.Controls.Add(Me.cboTitel)
    Me.Controls.Add(Me.btnGem)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnGemTitel)
    Me.Controls.Add(Me.btnAnnullerTitel)
    Me.Controls.Add(Me.txtTitel)
    Me.Controls.Add(Me.btnOpretTitel)
    Me.Controls.Add(Me.grdKontakterPrBlad)
    Me.Controls.Add(Me.cbeFunktioner)
    Me.Controls.Add(Me.cboArbOmråder)
    Me.Controls.Add(Me.txtEmail)
    Me.Controls.Add(Me.txtEfternavn)
    Me.Controls.Add(Me.txtFornavn)
    Me.Controls.Add(Me.lblEmail)
    Me.Controls.Add(Me.lblMobilNr)
    Me.Controls.Add(Me.lblTlfNr)
    Me.Controls.Add(Me.lblEfternavn)
    Me.Controls.Add(Me.lblFornavn)
    Me.Name = "frmOpretKontakt"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.Text = "Kontakter"
    CType(Me.cboArbOmråder, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblKontaktArbOmråderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstKontaktArbOmråder, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblKontaktTitlerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstKontaktTitlerDropdown, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cbeFunktioner, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblKontaktFunktionerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstKontaktFunktionerDropdown, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFornavn, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtEfternavn, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdKontakterPrBlad, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTitel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboTitel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtArbOmråde, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboEjerforhold, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblBladStamdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EjerforholdDropdown, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstKontakterPrBladBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstKontakterPrBlad, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cbeFunktioner As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents DstKontaktFunktionerDropdown As WinPlanner.dstKontaktFunktionerDropdown
  Friend WithEvents TblKontaktFunktionerBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblKontaktFunktionerTableAdapter As WinPlanner.dstKontaktFunktionerDropdownTableAdapters.tblKontaktFunktionerTableAdapter
  Friend WithEvents lblFornavn As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblEfternavn As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblTlfNr As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblMobilNr As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblEmail As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtFornavn As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtEfternavn As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents cboArbOmråder As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents DstKontaktTitlerDropdown As WinPlanner.dstKontaktTitlerDropdown
  Friend WithEvents TblKontaktTitlerBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblKontaktTitlerTableAdapter As WinPlanner.dstKontaktTitlerDropdownTableAdapters.tblKontaktTitlerTableAdapter
  Friend WithEvents grdKontakterPrBlad As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents DstKontakterPrBladBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents DstKontakterPrBlad As WinPlanner.dstKontakterPrBlad
  Friend WithEvents TblBladStamdataKopiTableAdapter As WinPlanner.dstKontakterPrBladTableAdapters.tblBladStamdataKopiTableAdapter
  Friend WithEvents btnOpretTitel As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtTitel As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents btnAnnullerTitel As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnGemTitel As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnGem As Infragistics.Win.Misc.UltraButton
  Friend WithEvents cboTitel As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents DstKontaktArbOmråder As WinPlanner.dstKontaktArbOmråder
  Friend WithEvents TblKontaktArbOmråderBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblKontaktArbOmråderTableAdapter As WinPlanner.dstKontaktArbOmråderTableAdapters.tblKontaktArbOmråderTableAdapter
  Friend WithEvents lblTitel As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblArbOmråder As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtTlfNr As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents txtMobilNr As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents btnOpretArbOmråde As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnGemArbOmråde As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnAnnullerArbOmråde As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtArbOmråde As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents cboEjerforhold As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents EjerforholdDropdown As WinPlanner.EjerforholdDropdown
  Friend WithEvents TblBladStamdataBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblBladStamdataTableAdapter As WinPlanner.EjerforholdDropdownTableAdapters.tblBladStamdataTableAdapter
  Friend WithEvents lblEjerforhold As Infragistics.Win.Misc.UltraLabel
End Class
