<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUdvælgKontakter
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
    Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
    Me.lblEjerforhold = New Infragistics.Win.Misc.UltraLabel()
    Me.cboEjerforhold = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
    Me.lblArbOmråde = New Infragistics.Win.Misc.UltraLabel()
    Me.cboArbOmråder = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
    Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
    Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
    Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton()
    Me.UltraCheckEditor1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
    Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
    Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
    Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
    Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
    Me.UltraComboEditor1 = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
    CType(Me.cboEjerforhold, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboArbOmråder, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblEjerforhold
    '
    Me.lblEjerforhold.AutoSize = True
    Me.lblEjerforhold.Location = New System.Drawing.Point(513, 118)
    Me.lblEjerforhold.Name = "lblEjerforhold"
    Me.lblEjerforhold.Size = New System.Drawing.Size(59, 14)
    Me.lblEjerforhold.TabIndex = 42
    Me.lblEjerforhold.Tag = "Toggle"
    Me.lblEjerforhold.Text = "Ejerforhold"
    '
    'cboEjerforhold
    '
    Me.cboEjerforhold.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
    Me.cboEjerforhold.DisplayMember = "Ejerforhold"
    Me.cboEjerforhold.Location = New System.Drawing.Point(583, 114)
    Me.cboEjerforhold.Name = "cboEjerforhold"
    Me.cboEjerforhold.NullText = "- Vælg ejerforhold -"
    Me.cboEjerforhold.Size = New System.Drawing.Size(205, 21)
    Me.cboEjerforhold.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
    Me.cboEjerforhold.TabIndex = 41
    Me.cboEjerforhold.Tag = "Toggle"
    Me.cboEjerforhold.ValueMember = "Ejerforhold"
    '
    'lblArbOmråde
    '
    Me.lblArbOmråde.AutoSize = True
    Me.lblArbOmråde.Location = New System.Drawing.Point(513, 91)
    Me.lblArbOmråde.Name = "lblArbOmråde"
    Me.lblArbOmråde.Size = New System.Drawing.Size(63, 14)
    Me.lblArbOmråde.TabIndex = 40
    Me.lblArbOmråde.Tag = "Toggle"
    Me.lblArbOmråde.Text = "Arb.område"
    '
    'cboArbOmråder
    '
    Me.cboArbOmråder.CheckedListSettings.CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox
    Me.cboArbOmråder.CheckedListSettings.EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems
    Me.cboArbOmråder.CheckedListSettings.ItemCheckArea = Infragistics.Win.ItemCheckArea.Item
    Me.cboArbOmråder.CheckedListSettings.ListSeparator = ";"
    Me.cboArbOmråder.DisplayMember = "ArbOmråde"
    Me.cboArbOmråder.Location = New System.Drawing.Point(583, 87)
    Me.cboArbOmråder.Name = "cboArbOmråder"
    Me.cboArbOmråder.NullText = "- Vælg arbejdsområder -"
    Me.cboArbOmråder.Size = New System.Drawing.Size(205, 21)
    Me.cboArbOmråder.TabIndex = 39
    Me.cboArbOmråder.Tag = "Toggle"
    '
    'UltraGrid1
    '
    Appearance1.BackColor = System.Drawing.SystemColors.Window
    Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.UltraGrid1.DisplayLayout.Appearance = Appearance1
    Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance2.BorderColor = System.Drawing.SystemColors.Window
    Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance2
    Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
    Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
    Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance4.BackColor2 = System.Drawing.SystemColors.Control
    Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
    Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
    Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
    Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
    Appearance5.BackColor = System.Drawing.SystemColors.Window
    Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
    Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance5
    Appearance6.BackColor = System.Drawing.SystemColors.Highlight
    Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance6
    Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance7.BackColor = System.Drawing.SystemColors.Window
    Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance7
    Appearance8.BorderColor = System.Drawing.Color.Silver
    Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance8
    Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
    Appearance9.BackColor = System.Drawing.SystemColors.Control
    Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance9.BorderColor = System.Drawing.SystemColors.Window
    Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance9
    Appearance10.TextHAlignAsString = "Left"
    Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance10
    Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance11.BackColor = System.Drawing.SystemColors.Window
    Appearance11.BorderColor = System.Drawing.Color.Silver
    Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance11
    Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
    Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
    Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.UltraGrid1.Location = New System.Drawing.Point(12, 219)
    Me.UltraGrid1.Name = "UltraGrid1"
    Me.UltraGrid1.Size = New System.Drawing.Size(1149, 335)
    Me.UltraGrid1.TabIndex = 43
    Me.UltraGrid1.Text = "UltraGrid1"
    '
    'UltraButton1
    '
    Me.UltraButton1.Location = New System.Drawing.Point(12, 12)
    Me.UltraButton1.Name = "UltraButton1"
    Me.UltraButton1.Size = New System.Drawing.Size(75, 23)
    Me.UltraButton1.TabIndex = 44
    Me.UltraButton1.Text = "Valg 1"
    '
    'UltraButton2
    '
    Me.UltraButton2.Location = New System.Drawing.Point(105, 12)
    Me.UltraButton2.Name = "UltraButton2"
    Me.UltraButton2.Size = New System.Drawing.Size(75, 23)
    Me.UltraButton2.TabIndex = 45
    Me.UltraButton2.Text = "Valg 2"
    '
    'UltraButton3
    '
    Me.UltraButton3.Location = New System.Drawing.Point(199, 12)
    Me.UltraButton3.Name = "UltraButton3"
    Me.UltraButton3.Size = New System.Drawing.Size(75, 23)
    Me.UltraButton3.TabIndex = 46
    Me.UltraButton3.Text = "Valg 3"
    '
    'UltraCheckEditor1
    '
    Me.UltraCheckEditor1.Location = New System.Drawing.Point(22, 87)
    Me.UltraCheckEditor1.Name = "UltraCheckEditor1"
    Me.UltraCheckEditor1.Size = New System.Drawing.Size(120, 20)
    Me.UltraCheckEditor1.TabIndex = 47
    Me.UltraCheckEditor1.Text = "Alle"
    '
    'UltraLabel1
    '
    Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UltraLabel1.Location = New System.Drawing.Point(13, 60)
    Me.UltraLabel1.Name = "UltraLabel1"
    Me.UltraLabel1.Size = New System.Drawing.Size(74, 21)
    Me.UltraLabel1.TabIndex = 48
    Me.UltraLabel1.Text = "Avis"
    '
    'UltraLabel2
    '
    Me.UltraLabel2.AutoSize = True
    Me.UltraLabel2.Location = New System.Drawing.Point(22, 114)
    Me.UltraLabel2.Name = "UltraLabel2"
    Me.UltraLabel2.Size = New System.Drawing.Size(69, 14)
    Me.UltraLabel2.TabIndex = 49
    Me.UltraLabel2.Text = "MedieplanNr"
    '
    'UltraTextEditor1
    '
    Me.UltraTextEditor1.Location = New System.Drawing.Point(93, 110)
    Me.UltraTextEditor1.Name = "UltraTextEditor1"
    Me.UltraTextEditor1.Size = New System.Drawing.Size(49, 21)
    Me.UltraTextEditor1.TabIndex = 50
    '
    'UltraLabel3
    '
    Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UltraLabel3.Location = New System.Drawing.Point(504, 60)
    Me.UltraLabel3.Name = "UltraLabel3"
    Me.UltraLabel3.Size = New System.Drawing.Size(74, 21)
    Me.UltraLabel3.TabIndex = 51
    Me.UltraLabel3.Text = "Kontakt"
    '
    'UltraLabel4
    '
    Me.UltraLabel4.AutoSize = True
    Me.UltraLabel4.Location = New System.Drawing.Point(22, 143)
    Me.UltraLabel4.Name = "UltraLabel4"
    Me.UltraLabel4.Size = New System.Drawing.Size(40, 14)
    Me.UltraLabel4.TabIndex = 52
    Me.UltraLabel4.Text = "Region"
    '
    'UltraComboEditor1
    '
    Me.UltraComboEditor1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
    Me.UltraComboEditor1.DisplayMember = "Ejerforhold"
    Me.UltraComboEditor1.Location = New System.Drawing.Point(93, 139)
    Me.UltraComboEditor1.Name = "UltraComboEditor1"
    Me.UltraComboEditor1.NullText = "- Vælg region -"
    Me.UltraComboEditor1.Size = New System.Drawing.Size(108, 21)
    Me.UltraComboEditor1.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
    Me.UltraComboEditor1.TabIndex = 53
    Me.UltraComboEditor1.Tag = "Toggle"
    Me.UltraComboEditor1.ValueMember = "Ejerforhold"
    '
    'frmUdvælgKontakter
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1173, 566)
    Me.Controls.Add(Me.UltraComboEditor1)
    Me.Controls.Add(Me.UltraLabel4)
    Me.Controls.Add(Me.UltraLabel3)
    Me.Controls.Add(Me.UltraTextEditor1)
    Me.Controls.Add(Me.UltraLabel2)
    Me.Controls.Add(Me.UltraLabel1)
    Me.Controls.Add(Me.UltraCheckEditor1)
    Me.Controls.Add(Me.UltraButton3)
    Me.Controls.Add(Me.UltraButton2)
    Me.Controls.Add(Me.UltraButton1)
    Me.Controls.Add(Me.UltraGrid1)
    Me.Controls.Add(Me.lblEjerforhold)
    Me.Controls.Add(Me.cboEjerforhold)
    Me.Controls.Add(Me.lblArbOmråde)
    Me.Controls.Add(Me.cboArbOmråder)
    Me.Name = "frmUdvælgKontakter"
    Me.Text = "Udvælg Kontakter"
    CType(Me.cboEjerforhold, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboArbOmråder, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblEjerforhold As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents cboEjerforhold As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents lblArbOmråde As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents cboArbOmråder As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
  Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
  Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
  Friend WithEvents UltraCheckEditor1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents UltraComboEditor1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
