<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTilBlade
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
    Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
    Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTilBlade))
    Me.lblTekst = New Infragistics.Win.Misc.UltraLabel()
    Me.lblEmne = New Infragistics.Win.Misc.UltraLabel()
    Me.optOrienteringsTypeMedieplan = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.txtTekst = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.txtEmne = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblOrienteringsType = New Infragistics.Win.Misc.UltraLabel()
    Me.btnSend = New Infragistics.Win.Misc.UltraButton()
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
    Me.optOrienteringsTypeBooking = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.UltraCalendarLook1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarLook(Me.components)
    Me.calDato = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
    Me.UltraCalendarInfo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
    Me.lblSvarSenest = New Infragistics.Win.Misc.UltraLabel()
    Me.lblKl = New Infragistics.Win.Misc.UltraLabel()
    Me.cboKl = New System.Windows.Forms.ComboBox()
    Me.lblAntalIndrykninger = New Infragistics.Win.Misc.UltraLabel()
    Me.txtAntalIndrykninger = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.chkPlaceringUB = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
    Me.optEmailTilAlle = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    CType(Me.optOrienteringsTypeMedieplan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTekst, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtEmne, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optOrienteringsTypeBooking, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.calDato, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAntalIndrykninger, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkPlaceringUB, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optEmailTilAlle, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblTekst
    '
    Me.lblTekst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTekst.AutoSize = True
    Me.lblTekst.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTekst.Location = New System.Drawing.Point(9, 135)
    Me.lblTekst.Name = "lblTekst"
    Me.lblTekst.Size = New System.Drawing.Size(35, 15)
    Me.lblTekst.TabIndex = 368
    Me.lblTekst.Text = "Tekst"
    '
    'lblEmne
    '
    Me.lblEmne.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblEmne.AutoSize = True
    Me.lblEmne.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEmne.Location = New System.Drawing.Point(9, 87)
    Me.lblEmne.Name = "lblEmne"
    Me.lblEmne.Size = New System.Drawing.Size(36, 15)
    Me.lblEmne.TabIndex = 367
    Me.lblEmne.Text = "Emne"
    '
    'optOrienteringsTypeMedieplan
    '
    Me.optOrienteringsTypeMedieplan.CheckedIndex = 0
    ValueListItem1.DataValue = CType(0, Byte)
    ValueListItem1.DisplayText = "Email"
    ValueListItem2.DataValue = CType(1, Byte)
    ValueListItem2.DisplayText = "Orientering om tilbud"
    ValueListItem3.DataValue = CType(2, Byte)
    ValueListItem3.DisplayText = "Forespørgsel"
    Me.optOrienteringsTypeMedieplan.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
    Me.optOrienteringsTypeMedieplan.ItemSpacingHorizontal = 45
    Me.optOrienteringsTypeMedieplan.Location = New System.Drawing.Point(5, 31)
    Me.optOrienteringsTypeMedieplan.Name = "optOrienteringsTypeMedieplan"
    Me.optOrienteringsTypeMedieplan.Size = New System.Drawing.Size(386, 24)
    Me.optOrienteringsTypeMedieplan.TabIndex = 365
    Me.optOrienteringsTypeMedieplan.Text = "Email"
    '
    'txtTekst
    '
    Me.txtTekst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTekst.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTekst.Location = New System.Drawing.Point(9, 151)
    Me.txtTekst.MaxLength = 1999
    Me.txtTekst.Multiline = True
    Me.txtTekst.Name = "txtTekst"
    Me.txtTekst.NullText = "- Skriv teksten til modtagerne -"
    Me.txtTekst.ShowOverflowIndicator = True
    Me.txtTekst.Size = New System.Drawing.Size(381, 110)
    Me.txtTekst.TabIndex = 363
    '
    'txtEmne
    '
    Me.txtEmne.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtEmne.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtEmne.Location = New System.Drawing.Point(9, 103)
    Me.txtEmne.Name = "txtEmne"
    Me.txtEmne.NullText = "- Skriv kort hvad denne udsendelse drejer sig om -"
    Me.txtEmne.Size = New System.Drawing.Size(383, 22)
    Me.txtEmne.TabIndex = 362
    '
    'lblOrienteringsType
    '
    Me.lblOrienteringsType.AutoSize = True
    Me.lblOrienteringsType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOrienteringsType.Location = New System.Drawing.Point(9, 8)
    Me.lblOrienteringsType.Name = "lblOrienteringsType"
    Me.lblOrienteringsType.Size = New System.Drawing.Size(38, 17)
    Me.lblOrienteringsType.TabIndex = 369
    Me.lblOrienteringsType.Text = "Type"
    '
    'btnSend
    '
    Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnSend.Enabled = False
    Me.btnSend.Location = New System.Drawing.Point(289, 320)
    Me.btnSend.Name = "btnSend"
    Me.btnSend.ShowFocusRect = False
    Me.btnSend.ShowOutline = False
    Me.btnSend.Size = New System.Drawing.Size(101, 24)
    Me.btnSend.TabIndex = 371
    Me.btnSend.Text = "Send"
    Me.btnSend.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnAnnuller
    '
    Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(9, 320)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(101, 24)
    Me.btnAnnuller.TabIndex = 372
    Me.btnAnnuller.Text = "Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'optOrienteringsTypeBooking
    '
    Me.optOrienteringsTypeBooking.CheckedIndex = 0
    ValueListItem4.DataValue = CType(0, Byte)
    ValueListItem4.DisplayText = "Email"
    ValueListItem5.DataValue = CType(1, Byte)
    ValueListItem5.DisplayText = "Bilagsblad reminder"
    Me.optOrienteringsTypeBooking.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem5})
    Me.optOrienteringsTypeBooking.ItemSpacingHorizontal = 190
    Me.optOrienteringsTypeBooking.Location = New System.Drawing.Point(8, 32)
    Me.optOrienteringsTypeBooking.Name = "optOrienteringsTypeBooking"
    Me.optOrienteringsTypeBooking.Size = New System.Drawing.Size(383, 24)
    Me.optOrienteringsTypeBooking.TabIndex = 373
    Me.optOrienteringsTypeBooking.Text = "Email"
    Me.optOrienteringsTypeBooking.Visible = False
    '
    'UltraCalendarLook1
    '
    Me.UltraCalendarLook1.ViewStyle = Infragistics.Win.UltraWinSchedule.ViewStyle.Standard
    '
    'calDato
    '
    Me.calDato.AllowWeekSelection = True
    Me.calDato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.calDato.CalendarInfo = Me.UltraCalendarInfo1
    Me.calDato.CalendarLook = Me.UltraCalendarLook1
    DateButton1.Caption = "I dag"
    Me.calDato.DateButtons.Add(DateButton1)
    Me.calDato.Format = "dd-MMM-yyyy"
    Me.calDato.Location = New System.Drawing.Point(86, 264)
    Me.calDato.Name = "calDato"
    Me.calDato.NonAutoSizeHeight = 21
    Me.calDato.Size = New System.Drawing.Size(121, 21)
    Me.calDato.SpinButtonsVisible = True
    Me.calDato.TabIndex = 374
    Me.calDato.TipStyle = Infragistics.Win.UltraWinSchedule.TipStyleDay.Holidays
    Me.calDato.Value = "12-06-2008 00:00:00"
    Me.calDato.WeekNumbersVisible = True
    '
    'UltraCalendarInfo1
    '
    Me.UltraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = Me
    Me.UltraCalendarInfo1.DataBindingsForOwners.BindingContextControl = Me
    Me.UltraCalendarInfo1.SelectTypeActivity = Infragistics.Win.UltraWinSchedule.SelectType.[Single]
    Me.UltraCalendarInfo1.SelectTypeDay = Infragistics.Win.UltraWinSchedule.SelectType.[Single]
    '
    'lblSvarSenest
    '
    Me.lblSvarSenest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblSvarSenest.AutoSize = True
    Me.lblSvarSenest.Location = New System.Drawing.Point(9, 267)
    Me.lblSvarSenest.Name = "lblSvarSenest"
    Me.lblSvarSenest.Size = New System.Drawing.Size(71, 15)
    Me.lblSvarSenest.TabIndex = 4
    Me.lblSvarSenest.Text = "Svar senest"
    '
    'lblKl
    '
    Me.lblKl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblKl.AutoSize = True
    Me.lblKl.Location = New System.Drawing.Point(213, 267)
    Me.lblKl.Name = "lblKl"
    Me.lblKl.Size = New System.Drawing.Size(18, 15)
    Me.lblKl.TabIndex = 3
    Me.lblKl.Text = "kl."
    '
    'cboKl
    '
    Me.cboKl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cboKl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboKl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboKl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboKl.Location = New System.Drawing.Point(237, 264)
    Me.cboKl.MaxDropDownItems = 12
    Me.cboKl.Name = "cboKl"
    Me.cboKl.Size = New System.Drawing.Size(121, 21)
    Me.cboKl.TabIndex = 2
    '
    'lblAntalIndrykninger
    '
    Me.lblAntalIndrykninger.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblAntalIndrykninger.AutoSize = True
    Me.lblAntalIndrykninger.Location = New System.Drawing.Point(205, 295)
    Me.lblAntalIndrykninger.Name = "lblAntalIndrykninger"
    Me.lblAntalIndrykninger.Size = New System.Drawing.Size(109, 15)
    Me.lblAntalIndrykninger.TabIndex = 1
    Me.lblAntalIndrykninger.Text = "Antal indrykninger"
    '
    'txtAntalIndrykninger
    '
    Me.txtAntalIndrykninger.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtAntalIndrykninger.Location = New System.Drawing.Point(320, 291)
    Me.txtAntalIndrykninger.Name = "txtAntalIndrykninger"
    Me.txtAntalIndrykninger.Size = New System.Drawing.Size(38, 22)
    Me.txtAntalIndrykninger.TabIndex = 0
    '
    'chkPlaceringUB
    '
    Me.chkPlaceringUB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkPlaceringUB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.chkPlaceringUB.Location = New System.Drawing.Point(58, 293)
    Me.chkPlaceringUB.Name = "chkPlaceringUB"
    Me.chkPlaceringUB.Size = New System.Drawing.Size(121, 20)
    Me.chkPlaceringUB.TabIndex = 375
    Me.chkPlaceringUB.Text = "Vís placering U/B"
    '
    'optEmailTilAlle
    '
    Me.optEmailTilAlle.CheckedIndex = 0
    ValueListItem6.DataValue = True
    ValueListItem6.DisplayText = "Send email til alle"
    ValueListItem7.DataValue = False
    ValueListItem7.DisplayText = "Send email til valgte"
    Me.optEmailTilAlle.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem6, ValueListItem7})
    Me.optEmailTilAlle.Location = New System.Drawing.Point(13, 63)
    Me.optEmailTilAlle.Name = "optEmailTilAlle"
    Me.optEmailTilAlle.Size = New System.Drawing.Size(319, 18)
    Me.optEmailTilAlle.TabIndex = 376
    Me.optEmailTilAlle.Text = "Send email til alle"
    Me.optEmailTilAlle.Visible = False
    '
    'frmTilBlade
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(405, 353)
    Me.Controls.Add(Me.optEmailTilAlle)
    Me.Controls.Add(Me.chkPlaceringUB)
    Me.Controls.Add(Me.txtAntalIndrykninger)
    Me.Controls.Add(Me.lblAntalIndrykninger)
    Me.Controls.Add(Me.cboKl)
    Me.Controls.Add(Me.lblKl)
    Me.Controls.Add(Me.lblSvarSenest)
    Me.Controls.Add(Me.calDato)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnSend)
    Me.Controls.Add(Me.lblOrienteringsType)
    Me.Controls.Add(Me.lblTekst)
    Me.Controls.Add(Me.lblEmne)
    Me.Controls.Add(Me.optOrienteringsTypeMedieplan)
    Me.Controls.Add(Me.txtTekst)
    Me.Controls.Add(Me.txtEmne)
    Me.Controls.Add(Me.optOrienteringsTypeBooking)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmTilBlade"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Orientering"
    Me.TopMost = True
    CType(Me.optOrienteringsTypeMedieplan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTekst, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtEmne, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optOrienteringsTypeBooking, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.calDato, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAntalIndrykninger, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkPlaceringUB, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optEmailTilAlle, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblTekst As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblEmne As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents optOrienteringsTypeMedieplan As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents txtTekst As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtEmne As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblOrienteringsType As Infragistics.Win.Misc.UltraLabel
  Private WithEvents btnSend As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Friend WithEvents optOrienteringsTypeBooking As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents UltraCalendarLook1 As Infragistics.Win.UltraWinSchedule.UltraCalendarLook
  Friend WithEvents calDato As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
  Friend WithEvents UltraCalendarInfo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
  Friend WithEvents lblKl As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblSvarSenest As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents cboKl As System.Windows.Forms.ComboBox
  Friend WithEvents lblAntalIndrykninger As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtAntalIndrykninger As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents chkPlaceringUB As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents optEmailTilAlle As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
