<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSletFiler
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
    Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSletFiler))
    Me.optVælgSletFra = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.lblVælgSletFra = New Infragistics.Win.Misc.UltraLabel()
    Me.lblVælgDato = New Infragistics.Win.Misc.UltraLabel()
    Me.calDato = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
    Me.calInfo = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
    Me.btnSletFiler = New Infragistics.Win.Misc.UltraButton()
    Me.btnLuk = New Infragistics.Win.Misc.UltraButton()
    Me.btnVisFiler = New Infragistics.Win.Misc.UltraButton()
    CType(Me.optVælgSletFra, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.calDato, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'optVælgSletFra
    '
    ValueListItem1.DataValue = CType(0, Byte)
    ValueListItem1.DisplayText = "Annoncemateriale Udsendt"
    ValueListItem2.DataValue = CType(1, Byte)
    ValueListItem2.DisplayText = "M: Drev"
    ValueListItem3.DataValue = CType(2, Byte)
    ValueListItem3.DisplayText = "H: Drev"
    Me.optVælgSletFra.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
    Me.optVælgSletFra.Location = New System.Drawing.Point(12, 32)
    Me.optVælgSletFra.Name = "optVælgSletFra"
    Me.optVælgSletFra.Size = New System.Drawing.Size(169, 51)
    Me.optVælgSletFra.TabIndex = 0
    '
    'lblVælgSletFra
    '
    Me.lblVælgSletFra.AutoSize = True
    Me.lblVælgSletFra.Location = New System.Drawing.Point(13, 12)
    Me.lblVælgSletFra.Name = "lblVælgSletFra"
    Me.lblVælgSletFra.Size = New System.Drawing.Size(137, 14)
    Me.lblVælgSletFra.TabIndex = 1
    Me.lblVælgSletFra.Text = "Vælg hvor du vil slette filer"
    '
    'lblVælgDato
    '
    Me.lblVælgDato.Location = New System.Drawing.Point(13, 115)
    Me.lblVælgDato.Name = "lblVælgDato"
    Me.lblVælgDato.Size = New System.Drawing.Size(201, 23)
    Me.lblVælgDato.TabIndex = 2
    Me.lblVælgDato.Text = "Vælg den dato filerne skal slettes før"
    '
    'calDato
    '
    Me.calDato.AutoSelectionUpdate = True
    Me.calDato.CalendarInfo = Me.calInfo
    Me.calDato.DateButtons.Add(DateButton1)
    Me.calDato.Location = New System.Drawing.Point(207, 112)
    Me.calDato.MonthScrollButtonsVisible = Infragistics.Win.DefaultableBoolean.[True]
    Me.calDato.MonthScrollChange = 1
    Me.calDato.Name = "calDato"
    Me.calDato.NonAutoSizeHeight = 21
    Me.calDato.Size = New System.Drawing.Size(121, 21)
    Me.calDato.TabIndex = 3
    Me.calDato.Value = New Date(2016, 7, 14, 0, 0, 0, 0)
    Me.calDato.WeekNumbersVisible = True
    Me.calDato.YearScrollButtonsVisible = Infragistics.Win.DefaultableBoolean.[True]
    Me.calDato.YearScrollChange = 1
    '
    'calInfo
    '
    Me.calInfo.DataBindingsForAppointments.BindingContextControl = Me
    Me.calInfo.DataBindingsForOwners.BindingContextControl = Me
    Me.calInfo.MaxDate = New Date(2016, 7, 14, 0, 0, 0, 0)
    Me.calInfo.SelectTypeActivity = Infragistics.Win.UltraWinSchedule.SelectType.None
    Me.calInfo.SelectTypeDay = Infragistics.Win.UltraWinSchedule.SelectType.[Single]
    '
    'btnSletFiler
    '
    Me.btnSletFiler.Enabled = False
    Me.btnSletFiler.Location = New System.Drawing.Point(169, 144)
    Me.btnSletFiler.Name = "btnSletFiler"
    Me.btnSletFiler.Size = New System.Drawing.Size(75, 23)
    Me.btnSletFiler.TabIndex = 4
    Me.btnSletFiler.Text = "Slet Filer"
    '
    'btnLuk
    '
    Me.btnLuk.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnLuk.Location = New System.Drawing.Point(328, 176)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.Size = New System.Drawing.Size(75, 23)
    Me.btnLuk.TabIndex = 5
    Me.btnLuk.Text = "Luk"
    '
    'btnVisFiler
    '
    Me.btnVisFiler.Enabled = False
    Me.btnVisFiler.Location = New System.Drawing.Point(13, 144)
    Me.btnVisFiler.Name = "btnVisFiler"
    Me.btnVisFiler.Size = New System.Drawing.Size(75, 23)
    Me.btnVisFiler.TabIndex = 6
    Me.btnVisFiler.Text = "Vis Filer"
    '
    'frmSletFiler
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnLuk
    Me.ClientSize = New System.Drawing.Size(415, 211)
    Me.Controls.Add(Me.btnVisFiler)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.btnSletFiler)
    Me.Controls.Add(Me.calDato)
    Me.Controls.Add(Me.lblVælgDato)
    Me.Controls.Add(Me.lblVælgSletFra)
    Me.Controls.Add(Me.optVælgSletFra)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmSletFiler"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Slet Filer"
    CType(Me.optVælgSletFra, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.calDato, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents optVælgSletFra As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents lblVælgSletFra As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblVælgDato As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents calDato As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
  Friend WithEvents calInfo As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
  Friend WithEvents btnSletFiler As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnVisFiler As Infragistics.Win.Misc.UltraButton
End Class
