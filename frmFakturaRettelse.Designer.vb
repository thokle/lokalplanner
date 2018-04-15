<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFakturaRettelse
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
    Dim lbl≈rsag As Infragistics.Win.Misc.UltraLabel
    Dim UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFakturaRettelse))
    Me.lblRettelse = New Infragistics.Win.Misc.UltraLabel
    Me.btnGem = New Infragistics.Win.Misc.UltraButton
    Me.DstFakturaFejl = New WinPlanner.dstFakturaFejl
    Me.TblFakturaFejlTekstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.TblFakturaFejlTekstTableAdapter = New WinPlanner.dstFakturaFejlTableAdapters.tblFakturaFejlTekstTableAdapter
    Me.cboFejl = New Infragistics.Win.UltraWinEditors.UltraComboEditor
    Me.cboAnsvarlig = New System.Windows.Forms.ComboBox
    lbl≈rsag = New Infragistics.Win.Misc.UltraLabel
    UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
    CType(Me.DstFakturaFejl, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblFakturaFejlTekstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboFejl, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lbl≈rsag
    '
    lbl≈rsag.AutoSize = True
    lbl≈rsag.Location = New System.Drawing.Point(12, 78)
    lbl≈rsag.Name = "lbl≈rsag"
    lbl≈rsag.Size = New System.Drawing.Size(214, 15)
    lbl≈rsag.TabIndex = 344
    lbl≈rsag.Text = "Angiv fejlen der er Ârsag til rettelsen"
    '
    'UltraLabel1
    '
    UltraLabel1.AutoSize = True
    UltraLabel1.Location = New System.Drawing.Point(12, 121)
    UltraLabel1.Name = "UltraLabel1"
    UltraLabel1.Size = New System.Drawing.Size(178, 15)
    UltraLabel1.TabIndex = 345
    UltraLabel1.Text = "Angiv den ansvarlige for fejlen"
    '
    'lblRettelse
    '
    Me.lblRettelse.Location = New System.Drawing.Point(12, 12)
    Me.lblRettelse.Name = "lblRettelse"
    Me.lblRettelse.Size = New System.Drawing.Size(327, 60)
    Me.lblRettelse.TabIndex = 342
    Me.lblRettelse.Text = "PÂ avisen"
    '
    'btnGem
    '
    Me.btnGem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGem.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnGem.Enabled = False
    Me.btnGem.Location = New System.Drawing.Point(238, 177)
    Me.btnGem.Name = "btnGem"
    Me.btnGem.ShowFocusRect = False
    Me.btnGem.ShowOutline = False
    Me.btnGem.Size = New System.Drawing.Size(101, 24)
    Me.btnGem.TabIndex = 5
    Me.btnGem.Text = "Gem"
    Me.btnGem.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'DstFakturaFejl
    '
    Me.DstFakturaFejl.DataSetName = "dstFakturaFejl"
    Me.DstFakturaFejl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'TblFakturaFejlTekstBindingSource
    '
    Me.TblFakturaFejlTekstBindingSource.DataMember = "tblFakturaFejlTekst"
    Me.TblFakturaFejlTekstBindingSource.DataSource = Me.DstFakturaFejl
    '
    'TblFakturaFejlTekstTableAdapter
    '
    Me.TblFakturaFejlTekstTableAdapter.ClearBeforeFill = True
    '
    'cboFejl
    '
    Me.cboFejl.DataSource = Me.TblFakturaFejlTekstBindingSource
    Me.cboFejl.DisplayMember = "FejlTekst"
    Me.cboFejl.LimitToList = True
    Me.cboFejl.Location = New System.Drawing.Point(12, 93)
    Me.cboFejl.MaxDropDownItems = 12
    Me.cboFejl.Name = "cboFejl"
    Me.cboFejl.NullText = "- VÊlg en fejl -"
    Me.cboFejl.Size = New System.Drawing.Size(326, 22)
    Me.cboFejl.TabIndex = 343
    Me.cboFejl.ValueMember = "FejlKode"
    '
    'cboAnsvarlig
    '
    Me.cboAnsvarlig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboAnsvarlig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboAnsvarlig.FormattingEnabled = True
    Me.cboAnsvarlig.Items.AddRange(New Object() {"A", "M", "U", "DLU", "System"})
    Me.cboAnsvarlig.Location = New System.Drawing.Point(12, 136)
    Me.cboAnsvarlig.MaxDropDownItems = 17
    Me.cboAnsvarlig.Name = "cboAnsvarlig"
    Me.cboAnsvarlig.Size = New System.Drawing.Size(121, 21)
    Me.cboAnsvarlig.TabIndex = 346
    '
    'frmFakturaRettelse
    '
    Me.AcceptButton = Me.btnGem
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(351, 208)
    Me.ControlBox = False
    Me.Controls.Add(Me.cboAnsvarlig)
    Me.Controls.Add(UltraLabel1)
    Me.Controls.Add(lbl≈rsag)
    Me.Controls.Add(Me.cboFejl)
    Me.Controls.Add(Me.lblRettelse)
    Me.Controls.Add(Me.btnGem)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmFakturaRettelse"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Faktura rettelse"
    Me.TopMost = True
    CType(Me.DstFakturaFejl, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblFakturaFejlTekstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboFejl, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Private WithEvents btnGem As Infragistics.Win.Misc.UltraButton
  Friend WithEvents lblRettelse As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents DstFakturaFejl As WinPlanner.dstFakturaFejl
  Friend WithEvents TblFakturaFejlTekstBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblFakturaFejlTekstTableAdapter As WinPlanner.dstFakturaFejlTableAdapters.tblFakturaFejlTekstTableAdapter
  Friend WithEvents cboFejl As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents cboAnsvarlig As System.Windows.Forms.ComboBox
End Class
