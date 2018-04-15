<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOmsætning
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
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Omsætning", -1)
    Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Annoncør", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
    Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bureau")
    Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ugeavis")
    Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOmrådeKode")
    Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOmrådeSortKey")
    Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HovedGruppeNavn")
    Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HovedGruppeSortKey")
    Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeNavn")
    Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeSortKey")
    Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Konsulent")
    Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge")
    Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsÅr")
    Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MmÅrNy")
    Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MmÅrGammel")
    Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrisÅrNy")
    Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrisÅrGammel")
    Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejerforhold")
    Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SidePlaceringen")
    Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MiljøTillægNy")
    Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MiljøTillægGammel")
    Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GodtgørelseNy")
    Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GodtgørelseGammel")
    Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalIndrykningerNy")
    Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalIndrykningerGammel")
    Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Format")
    Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiffMm", 0)
    Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiffKr", 1)
    Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiffMmProcent", 2)
    Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiffKrProcent", 3)
    Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Ugeavis", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "Ugeavis", 2, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Ugeavis", 2, True)
    Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("MmÅrNy", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MmÅrNy", 12, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MmÅrNy", 12, True)
    Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("MmÅrGammel", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MmÅrGammel", 13, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MmÅrGammel", 13, True)
    Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("PrisÅrNy", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "PrisÅrNy", 14, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "PrisÅrNy", 14, True)
    Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings5 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("PrisÅrGammel", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "PrisÅrGammel", 15, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "PrisÅrGammel", 15, True)
    Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings6 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("DiffMm", Infragistics.Win.UltraWinGrid.SummaryType.Average, Nothing, "DiffMm", 0, False, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DiffMm", 0, False)
    Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings7 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("DiffKr", Infragistics.Win.UltraWinGrid.SummaryType.Average, Nothing, "DiffKr", 1, False, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DiffKr", 1, False)
    Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings8 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("MiljøTillægNy", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MiljøTillægNy", 18, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MiljøTillægNy", 18, True)
    Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings9 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("MiljøTillægGammel", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MiljøTillægGammel", 19, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MiljøTillægGammel", 19, True)
    Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings10 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("GodtgørelseNy", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "GodtgørelseNy", 20, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "GodtgørelseNy", 20, True)
    Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings11 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("GodtgørelseGammel", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "GodtgørelseGammel", 21, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "GodtgørelseGammel", 21, True)
    Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings12 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("DiffMmProcent", Infragistics.Win.UltraWinGrid.SummaryType.Average, Nothing, "DiffMmProcent", 2, False, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DiffMmProcent", 2, False)
    Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings13 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("DiffKrProcent", Infragistics.Win.UltraWinGrid.SummaryType.Average, Nothing, "DiffKrProcent", 3, False, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DiffKrProcent", 3, False)
    Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings14 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("AntalIndrykningerNy", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "AntalIndrykningerNy", 22, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "AntalIndrykningerNy", 22, True)
    Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim SummarySettings15 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("AntalIndrykningerGammel", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "AntalIndrykningerGammel", 23, True, "Omsætning", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "AntalIndrykningerGammel", 23, True)
    Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOmsætning))
    Me.grdOmsætning = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.FillByUgeÅrToolStrip = New System.Windows.Forms.ToolStrip()
    Me.ÅrToolStripLabel = New System.Windows.Forms.ToolStripLabel()
    Me.ÅrToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
    Me.FraUgeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
    Me.FraUgeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
    Me.TilUgeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
    Me.TilUgeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
    Me.btnOpdater = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.cboRapporter = New System.Windows.Forms.ToolStripComboBox()
    Me.btnGem = New System.Windows.Forms.ToolStripButton()
    Me.btnLuk = New System.Windows.Forms.ToolStripButton()
    Me.btnExcelExport = New System.Windows.Forms.ToolStripButton()
    Me.sfdGridViews = New System.Windows.Forms.SaveFileDialog()
    Me.btnLuk2 = New Infragistics.Win.Misc.UltraButton()
    Me.btnOpdater2 = New Infragistics.Win.Misc.UltraButton()
    Me.ExcelExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
    Me.OmsætningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstOmsætning = New WinPlanner.dstOmsætning()
    Me.OmsætningTableAdapter = New WinPlanner.dstOmsætningTableAdapters.OmsætningTableAdapter()
    CType(Me.grdOmsætning, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.FillByUgeÅrToolStrip.SuspendLayout()
    CType(Me.OmsætningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstOmsætning, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdOmsætning
    '
    Me.grdOmsætning.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdOmsætning.DataSource = Me.OmsætningBindingSource
    Appearance1.BackColor = System.Drawing.SystemColors.Window
    Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdOmsætning.DisplayLayout.Appearance = Appearance1
    UltraGridColumn57.Header.VisiblePosition = 0
    UltraGridColumn57.Width = 188
    UltraGridColumn58.Header.VisiblePosition = 17
    UltraGridColumn58.Width = 79
    UltraGridColumn59.Header.VisiblePosition = 14
    UltraGridColumn59.Width = 70
    UltraGridColumn60.Header.Caption = "Delområde"
    UltraGridColumn60.Header.VisiblePosition = 21
    UltraGridColumn60.Hidden = True
    UltraGridColumn60.Width = 71
    UltraGridColumn61.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
    UltraGridColumn61.Header.VisiblePosition = 18
    UltraGridColumn61.Hidden = True
    UltraGridColumn62.Header.Caption = "DD el. DL"
    UltraGridColumn62.Header.VisiblePosition = 20
    UltraGridColumn62.Width = 55
    UltraGridColumn63.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
    UltraGridColumn63.Header.VisiblePosition = 22
    UltraGridColumn63.Hidden = True
    UltraGridColumn64.Header.Caption = "Geokode"
    UltraGridColumn64.Header.VisiblePosition = 24
    UltraGridColumn64.Hidden = True
    UltraGridColumn64.Width = 66
    UltraGridColumn65.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
    UltraGridColumn65.Header.VisiblePosition = 27
    UltraGridColumn65.Hidden = True
    UltraGridColumn66.Header.VisiblePosition = 9
    UltraGridColumn66.Width = 58
    UltraGridColumn67.Header.Caption = "Uge"
    UltraGridColumn67.Header.VisiblePosition = 15
    UltraGridColumn67.Width = 43
    UltraGridColumn68.Header.Caption = "År"
    UltraGridColumn68.Header.VisiblePosition = 28
    UltraGridColumn68.Hidden = True
    UltraGridColumn68.Width = 103
    UltraGridColumn69.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
    UltraGridColumn69.Format = "#,##0"
    UltraGridColumn69.Header.Caption = "Mm 2009"
    UltraGridColumn69.Header.VisiblePosition = 10
    UltraGridColumn69.Width = 72
    UltraGridColumn70.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
    UltraGridColumn70.Format = "#,##0"
    UltraGridColumn70.Header.Caption = "Mm 2008"
    UltraGridColumn70.Header.VisiblePosition = 11
    UltraGridColumn70.Width = 76
    UltraGridColumn71.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
    UltraGridColumn71.Format = "#,##0"
    UltraGridColumn71.Header.Caption = "Kr 2009"
    UltraGridColumn71.Header.VisiblePosition = 1
    UltraGridColumn71.Width = 62
    UltraGridColumn72.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
    UltraGridColumn72.Format = "#,##0"
    UltraGridColumn72.Header.Caption = "Kr 2008"
    UltraGridColumn72.Header.VisiblePosition = 4
    UltraGridColumn72.Width = 77
    UltraGridColumn73.Header.VisiblePosition = 19
    UltraGridColumn74.Header.Caption = "Side"
    UltraGridColumn74.Header.VisiblePosition = 16
    UltraGridColumn74.Hidden = True
    UltraGridColumn75.Format = "#,##0"
    UltraGridColumn75.Header.Caption = "Tillæg 2009"
    UltraGridColumn75.Header.VisiblePosition = 2
    UltraGridColumn75.Hidden = True
    UltraGridColumn75.Width = 71
    UltraGridColumn76.Format = "#,##0"
    UltraGridColumn76.Header.Caption = "Tillæg 2008"
    UltraGridColumn76.Header.VisiblePosition = 5
    UltraGridColumn76.Hidden = True
    UltraGridColumn77.Format = "#,##0"
    UltraGridColumn77.Header.Caption = "Godtgørelse 2009"
    UltraGridColumn77.Header.VisiblePosition = 3
    UltraGridColumn77.Hidden = True
    UltraGridColumn78.Format = "#,##0"
    UltraGridColumn78.Header.Caption = "Godtgørelse 2008"
    UltraGridColumn78.Header.VisiblePosition = 6
    UltraGridColumn78.Hidden = True
    UltraGridColumn79.Header.VisiblePosition = 23
    UltraGridColumn80.Header.VisiblePosition = 26
    UltraGridColumn81.Header.VisiblePosition = 25
    UltraGridColumn82.DataType = GetType(Integer)
    UltraGridColumn82.DefaultCellValue = 0
    UltraGridColumn82.Header.Caption = "Mm Diff"
    UltraGridColumn82.Header.VisiblePosition = 12
    UltraGridColumn82.Width = 60
    UltraGridColumn83.DataType = GetType(Decimal)
    UltraGridColumn83.Header.Caption = "Kr Diff"
    UltraGridColumn83.Header.VisiblePosition = 7
    UltraGridColumn83.Width = 60
    UltraGridColumn84.DataType = GetType(Integer)
    UltraGridColumn84.DefaultCellValue = 0
    UltraGridColumn84.Header.Caption = "% Mm Diff"
    UltraGridColumn84.Header.VisiblePosition = 13
    UltraGridColumn84.Width = 60
    UltraGridColumn85.DataType = GetType(Integer)
    UltraGridColumn85.Header.Caption = "% Kr Diff"
    UltraGridColumn85.Header.VisiblePosition = 8
    UltraGridColumn85.Width = 60
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85})
    Appearance2.TextHAlignAsString = "Right"
    SummarySettings1.Appearance = Appearance2
    SummarySettings1.DisplayFormat = "{0}"
    SummarySettings1.GroupBySummaryValueAppearance = Appearance3
    Appearance4.TextHAlignAsString = "Right"
    SummarySettings2.Appearance = Appearance4
    SummarySettings2.DisplayFormat = "{0:#,##0}"
    SummarySettings2.GroupBySummaryValueAppearance = Appearance5
    Appearance6.TextHAlignAsString = "Right"
    SummarySettings3.Appearance = Appearance6
    SummarySettings3.DisplayFormat = "{0:#,##0}"
    SummarySettings3.GroupBySummaryValueAppearance = Appearance7
    Appearance8.TextHAlignAsString = "Right"
    SummarySettings4.Appearance = Appearance8
    SummarySettings4.DisplayFormat = "{0:#,##0}"
    SummarySettings4.GroupBySummaryValueAppearance = Appearance9
    Appearance10.TextHAlignAsString = "Right"
    SummarySettings5.Appearance = Appearance10
    SummarySettings5.DisplayFormat = "{0:#,##0}"
    SummarySettings5.GroupBySummaryValueAppearance = Appearance11
    Appearance12.TextHAlignAsString = "Right"
    SummarySettings6.Appearance = Appearance12
    SummarySettings6.DisplayFormat = "{0:#,##0}"
    SummarySettings6.GroupBySummaryValueAppearance = Appearance13
    Appearance14.TextHAlignAsString = "Right"
    SummarySettings7.Appearance = Appearance14
    SummarySettings7.DisplayFormat = "{0:#,##0}"
    SummarySettings7.GroupBySummaryValueAppearance = Appearance15
    Appearance16.TextHAlignAsString = "Right"
    SummarySettings8.Appearance = Appearance16
    SummarySettings8.DisplayFormat = "{0:#,##0}"
    SummarySettings8.GroupBySummaryValueAppearance = Appearance17
    Appearance18.TextHAlignAsString = "Right"
    SummarySettings9.Appearance = Appearance18
    SummarySettings9.DisplayFormat = "{0:#,##0}"
    SummarySettings9.GroupBySummaryValueAppearance = Appearance19
    Appearance20.TextHAlignAsString = "Right"
    SummarySettings10.Appearance = Appearance20
    SummarySettings10.DisplayFormat = "{0:#,##0}"
    SummarySettings10.GroupBySummaryValueAppearance = Appearance21
    Appearance22.TextHAlignAsString = "Right"
    SummarySettings11.Appearance = Appearance22
    SummarySettings11.DisplayFormat = "{0:#,##0}"
    SummarySettings11.GroupBySummaryValueAppearance = Appearance23
    Appearance24.TextHAlignAsString = "Right"
    SummarySettings12.Appearance = Appearance24
    SummarySettings12.DisplayFormat = "{0:#,##0}"
    SummarySettings12.GroupBySummaryValueAppearance = Appearance25
    Appearance26.TextHAlignAsString = "Right"
    SummarySettings13.Appearance = Appearance26
    SummarySettings13.DisplayFormat = "{0:#,##0}"
    SummarySettings13.GroupBySummaryValueAppearance = Appearance27
    Appearance28.TextHAlignAsString = "Right"
    SummarySettings14.Appearance = Appearance28
    SummarySettings14.DisplayFormat = "{0}"
    SummarySettings14.GroupBySummaryValueAppearance = Appearance29
    Appearance30.TextHAlignAsString = "Right"
    SummarySettings15.Appearance = Appearance30
    SummarySettings15.DisplayFormat = "{0}"
    SummarySettings15.GroupBySummaryValueAppearance = Appearance31
    UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4, SummarySettings5, SummarySettings6, SummarySettings7, SummarySettings8, SummarySettings9, SummarySettings10, SummarySettings11, SummarySettings12, SummarySettings13, SummarySettings14, SummarySettings15})
    UltraGridBand1.SummaryFooterCaption = "I Alt"
    Me.grdOmsætning.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdOmsætning.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOmsætning.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
    Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance32.BorderColor = System.Drawing.SystemColors.Window
    Me.grdOmsætning.DisplayLayout.GroupByBox.Appearance = Appearance32
    Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdOmsætning.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
    Me.grdOmsætning.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance34.BackColor2 = System.Drawing.SystemColors.Control
    Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdOmsætning.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
    Me.grdOmsætning.DisplayLayout.MaxColScrollRegions = 1
    Me.grdOmsætning.DisplayLayout.MaxRowScrollRegions = 1
    Appearance35.BackColor = System.Drawing.SystemColors.Window
    Appearance35.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdOmsætning.DisplayLayout.Override.ActiveCellAppearance = Appearance35
    Appearance36.BackColor = System.Drawing.SystemColors.Highlight
    Appearance36.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdOmsætning.DisplayLayout.Override.ActiveRowAppearance = Appearance36
    Me.grdOmsætning.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    Me.grdOmsætning.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
    Me.grdOmsætning.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOmsætning.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOmsætning.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOmsætning.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdOmsætning.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdOmsætning.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    Me.grdOmsætning.DisplayLayout.Override.CellPadding = 0
    Me.grdOmsætning.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
    Me.grdOmsætning.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
    Me.grdOmsætning.DisplayLayout.Override.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo
    Me.grdOmsætning.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
    Me.grdOmsætning.DisplayLayout.Override.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden
    Me.grdOmsætning.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
    Me.grdOmsætning.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.Button
    Me.grdOmsætning.DisplayLayout.Override.GroupByColumnsHidden = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOmsætning.DisplayLayout.Override.GroupByRowDescriptionMask = "[Value]"
    Me.grdOmsætning.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
    Appearance37.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
    Appearance37.TextHAlignAsString = "Right"
    Me.grdOmsætning.DisplayLayout.Override.GroupBySummaryValueAppearance = Appearance37
    Appearance38.TextHAlignAsString = "Left"
    Me.grdOmsætning.DisplayLayout.Override.HeaderAppearance = Appearance38
    Me.grdOmsætning.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdOmsætning.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance39.BackColor = System.Drawing.SystemColors.Window
    Appearance39.BorderColor = System.Drawing.Color.Silver
    Me.grdOmsætning.DisplayLayout.Override.RowAppearance = Appearance39
    Me.grdOmsætning.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
    Me.grdOmsætning.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
    Me.grdOmsætning.DisplayLayout.Override.SequenceFilterRow = 1
    Me.grdOmsætning.DisplayLayout.Override.SequenceSummaryRow = 2
    Me.grdOmsætning.DisplayLayout.Override.SummaryDisplayArea = CType((((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom) _
            Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.InGroupByRows) _
            Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
    Me.grdOmsætning.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Me.grdOmsætning.DisplayLayout.Override.SummaryFooterSpacingBefore = 10
    Appearance40.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdOmsætning.DisplayLayout.Override.TemplateAddRowAppearance = Appearance40
    Me.grdOmsætning.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Both
    Me.grdOmsætning.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdOmsætning.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdOmsætning.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
    Me.grdOmsætning.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdOmsætning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdOmsætning.Location = New System.Drawing.Point(0, 28)
    Me.grdOmsætning.Name = "grdOmsætning"
    Me.grdOmsætning.Size = New System.Drawing.Size(947, 596)
    Me.grdOmsætning.TabIndex = 0
    '
    'FillByUgeÅrToolStrip
    '
    Me.FillByUgeÅrToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÅrToolStripLabel, Me.ÅrToolStripTextBox, Me.FraUgeToolStripLabel, Me.FraUgeToolStripTextBox, Me.TilUgeToolStripLabel, Me.TilUgeToolStripTextBox, Me.btnOpdater, Me.ToolStripSeparator1, Me.cboRapporter, Me.btnGem, Me.btnLuk, Me.btnExcelExport})
    Me.FillByUgeÅrToolStrip.Location = New System.Drawing.Point(0, 0)
    Me.FillByUgeÅrToolStrip.Name = "FillByUgeÅrToolStrip"
    Me.FillByUgeÅrToolStrip.Size = New System.Drawing.Size(959, 25)
    Me.FillByUgeÅrToolStrip.TabIndex = 1
    Me.FillByUgeÅrToolStrip.Text = "FillByUgeÅrToolStrip"
    '
    'ÅrToolStripLabel
    '
    Me.ÅrToolStripLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ÅrToolStripLabel.Name = "ÅrToolStripLabel"
    Me.ÅrToolStripLabel.Size = New System.Drawing.Size(21, 22)
    Me.ÅrToolStripLabel.Text = "År:"
    '
    'ÅrToolStripTextBox
    '
    Me.ÅrToolStripTextBox.MaxLength = 4
    Me.ÅrToolStripTextBox.Name = "ÅrToolStripTextBox"
    Me.ÅrToolStripTextBox.Size = New System.Drawing.Size(50, 25)
    '
    'FraUgeToolStripLabel
    '
    Me.FraUgeToolStripLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FraUgeToolStripLabel.Name = "FraUgeToolStripLabel"
    Me.FraUgeToolStripLabel.Size = New System.Drawing.Size(49, 22)
    Me.FraUgeToolStripLabel.Text = "Fra uge"
    '
    'FraUgeToolStripTextBox
    '
    Me.FraUgeToolStripTextBox.MaxLength = 2
    Me.FraUgeToolStripTextBox.Name = "FraUgeToolStripTextBox"
    Me.FraUgeToolStripTextBox.Size = New System.Drawing.Size(25, 25)
    '
    'TilUgeToolStripLabel
    '
    Me.TilUgeToolStripLabel.Name = "TilUgeToolStripLabel"
    Me.TilUgeToolStripLabel.Size = New System.Drawing.Size(43, 22)
    Me.TilUgeToolStripLabel.Text = "Til uge"
    '
    'TilUgeToolStripTextBox
    '
    Me.TilUgeToolStripTextBox.MaxLength = 2
    Me.TilUgeToolStripTextBox.Name = "TilUgeToolStripTextBox"
    Me.TilUgeToolStripTextBox.Size = New System.Drawing.Size(26, 25)
    '
    'btnOpdater
    '
    Me.btnOpdater.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.btnOpdater.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnOpdater.Name = "btnOpdater"
    Me.btnOpdater.Size = New System.Drawing.Size(55, 22)
    Me.btnOpdater.Text = "Opdater"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'cboRapporter
    '
    Me.cboRapporter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cboRapporter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
    Me.cboRapporter.AutoToolTip = True
    Me.cboRapporter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboRapporter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboRapporter.Name = "cboRapporter"
    Me.cboRapporter.Size = New System.Drawing.Size(121, 25)
    Me.cboRapporter.Sorted = True
    Me.cboRapporter.Visible = False
    '
    'btnGem
    '
    Me.btnGem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnGem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGem.Name = "btnGem"
    Me.btnGem.Size = New System.Drawing.Size(100, 22)
    Me.btnGem.Text = "Gem opsætning"
    Me.btnGem.Visible = False
    '
    'btnLuk
    '
    Me.btnLuk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLuk.Image = Global.WinPlanner.My.Resources.Resources.Cancel
    Me.btnLuk.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.Size = New System.Drawing.Size(47, 22)
    Me.btnLuk.Text = "Luk"
    '
    'btnExcelExport
    '
    Me.btnExcelExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnExcelExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.btnExcelExport.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnExcelExport.Name = "btnExcelExport"
    Me.btnExcelExport.Size = New System.Drawing.Size(78, 22)
    Me.btnExcelExport.Text = "Gem Excel fil"
    Me.btnExcelExport.ToolTipText = "Gem Excel fil på dit m: drev"
    '
    'sfdGridViews
    '
    Me.sfdGridViews.AutoUpgradeEnabled = False
    Me.sfdGridViews.DefaultExt = "bin"
    Me.sfdGridViews.Filter = "Grid files|*.bin"
    Me.sfdGridViews.InitialDirectory = "Z:\GridViews"
    Me.sfdGridViews.Title = "Gem opsætning"
    '
    'btnLuk2
    '
    Me.btnLuk2.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnLuk2.Location = New System.Drawing.Point(474, 0)
    Me.btnLuk2.Name = "btnLuk2"
    Me.btnLuk2.Size = New System.Drawing.Size(56, 23)
    Me.btnLuk2.TabIndex = 2
    Me.btnLuk2.Text = "Luk 2"
    Me.btnLuk2.Visible = False
    '
    'btnOpdater2
    '
    Me.btnOpdater2.Location = New System.Drawing.Point(618, -1)
    Me.btnOpdater2.Name = "btnOpdater2"
    Me.btnOpdater2.Size = New System.Drawing.Size(75, 23)
    Me.btnOpdater2.TabIndex = 3
    Me.btnOpdater2.Text = "Opdater 2"
    Me.btnOpdater2.Visible = False
    '
    'ExcelExporter
    '
    Me.ExcelExporter.FileLimitBehaviour = Infragistics.Win.UltraWinGrid.ExcelExport.FileLimitBehaviour.TruncateData
    '
    'OmsætningBindingSource
    '
    Me.OmsætningBindingSource.DataMember = "Omsætning"
    Me.OmsætningBindingSource.DataSource = Me.DstOmsætning
    '
    'DstOmsætning
    '
    Me.DstOmsætning.DataSetName = "dstOmsætning"
    Me.DstOmsætning.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'OmsætningTableAdapter
    '
    Me.OmsætningTableAdapter.ClearBeforeFill = True
    '
    'frmOmsætning
    '
    Me.AcceptButton = Me.btnOpdater2
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnLuk2
    Me.ClientSize = New System.Drawing.Size(959, 624)
    Me.Controls.Add(Me.btnOpdater2)
    Me.Controls.Add(Me.btnLuk2)
    Me.Controls.Add(Me.FillByUgeÅrToolStrip)
    Me.Controls.Add(Me.grdOmsætning)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmOmsætning"
    Me.Text = " "
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.grdOmsætning, System.ComponentModel.ISupportInitialize).EndInit()
    Me.FillByUgeÅrToolStrip.ResumeLayout(False)
    Me.FillByUgeÅrToolStrip.PerformLayout()
    CType(Me.OmsætningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstOmsætning, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents DstOmsætning As WinPlanner.dstOmsætning
  Friend WithEvents OmsætningBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents OmsætningTableAdapter As WinPlanner.dstOmsætningTableAdapters.OmsætningTableAdapter
  Friend WithEvents FillByUgeÅrToolStrip As System.Windows.Forms.ToolStrip
  Friend WithEvents ÅrToolStripLabel As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ÅrToolStripTextBox As System.Windows.Forms.ToolStripTextBox
  Friend WithEvents FraUgeToolStripLabel As System.Windows.Forms.ToolStripLabel
  Friend WithEvents FraUgeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
  Friend WithEvents btnOpdater As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents cboRapporter As System.Windows.Forms.ToolStripComboBox
  Friend WithEvents btnGem As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnLuk As System.Windows.Forms.ToolStripButton
  Friend WithEvents sfdGridViews As System.Windows.Forms.SaveFileDialog
  Friend WithEvents btnLuk2 As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnOpdater2 As Infragistics.Win.Misc.UltraButton
  Friend WithEvents TilUgeToolStripLabel As System.Windows.Forms.ToolStripLabel
  Friend WithEvents TilUgeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
  Friend WithEvents btnExcelExport As System.Windows.Forms.ToolStripButton
  Friend WithEvents ExcelExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
  Private WithEvents grdOmsætning As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
