
Partial Class frmMedieplan
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

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("", Infragistics.Win.ToolTipImage.Info, "Bilagsblad modtager", Infragistics.Win.DefaultableBoolean.[True])
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Klik her for at åbne/lukke fakturerings bilag", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("", Infragistics.Win.ToolTipImage.Warning, "For at save:", Infragistics.Win.DefaultableBoolean.[True])
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Der er vedhæftet et support bilag", Infragistics.Win.ToolTipImage.Info, "Bilag vedhæftet", Infragistics.Win.DefaultableBoolean.[True])
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Klik her for at åbne/lukke historik", Infragistics.Win.ToolTipImage.Info, "Historik", Infragistics.Win.DefaultableBoolean.[True])
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("", Infragistics.Win.ToolTipImage.Info, "Kommentar", Infragistics.Win.DefaultableBoolean.[True])
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedieplan))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("OrdreLinjer", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RowID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UgeavisID", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeNavn")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeSortKey")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HovedGruppeNavn")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HovedGruppeSortKey")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RabatGruppe")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mm")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NormalMmPris")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New MmPris")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old MmPris")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New MmRabat")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old MmRabat")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New MmTotal")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old MmTotal")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveTillæg")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New FarvePris")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old FarvePris")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New FarveRabat")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old FarveRabat")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New FarveTotal")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old FarveTotal")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New Total")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old Total")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MåGiveFarveRabat")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MåGiveMmRabat")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New Bemærkning")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old Bemærkning")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New BureauOrdreNr")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old BureauOrdreNr")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RowState")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FejlTekst")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("New Ansvar")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Old Ansvar")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ManueltÆndret")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SendeGruppe")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveMin")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveMax")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedIGrupper")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrisforespørgselEmails")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialeNr")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedienetKode")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrislisteID")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Is365")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejerforhold")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FakturaGruppe")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Change Reason")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Faktureringsbilag")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UdgivelsesDag")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErWeekendGruppe")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("WebtillægFaktureresHer")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BemærkningFraPrisforespørgsel")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MiljøTillæg")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalInclTillæg")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialeDeadline")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Oplag")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Læsertal")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KontaktprisOplag")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KontaktprisLæsertal")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrisLåst")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Aviser", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "UgeavisID", 1, True, "OrdreLinjer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "UgeavisID", 1, True)
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("New MmPris", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "New MmPris", 9, True, "OrdreLinjer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "New MmPris", 9, True)
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("New MmTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "New MmTotal", 13, True, "OrdreLinjer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "New MmTotal", 13, True)
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("New FarvePris", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "New FarvePris", 16, True, "OrdreLinjer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "New FarvePris", 16, True)
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings5 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("New FarveTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "New FarveTotal", 20, True, "OrdreLinjer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "New FarveTotal", 20, True)
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings6 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("New Total", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "New Total", 22, True, "OrdreLinjer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "New Total", 22, True)
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings7 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("MiljøTillæg", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MiljøTillæg", 53, True, "OrdreLinjer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MiljøTillæg", 53, True)
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings8 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("TotalInclTillæg", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "TotalInclTillæg", 54, True, "OrdreLinjer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "TotalInclTillæg", 54, True)
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cboUgebladListe = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TblUgeaviserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UgeavisListeDropdown = New WinPlanner.UgeavisListeDropdown()
        Me.numIndrykningsUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblIndrykningsUge = New Infragistics.Win.Misc.UltraLabel()
        Me.cboDPKulørID = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TblDPKulørBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DPKulørListeDropDown = New WinPlanner.DPKulørListeDropDown()
        Me.lblDPKulør = New Infragistics.Win.Misc.UltraLabel()
        Me.lblAntalFarver = New Infragistics.Win.Misc.UltraLabel()
        Me.cboPlaceringID = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TblPlaceringBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlaceringListeDropdown = New WinPlanner.PlaceringListeDropdown()
        Me.lblX = New Infragistics.Win.Misc.UltraLabel()
        Me.lblFormat = New Infragistics.Win.Misc.UltraLabel()
        Me.lblPlacering = New Infragistics.Win.Misc.UltraLabel()
        Me.lblBureau = New Infragistics.Win.Misc.UltraLabel()
        Me.lblAnnoncør = New Infragistics.Win.Misc.UltraLabel()
        Me.cboAnnoncørNO_ = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TblAnnoncørerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnnoncørListeDropdown = New WinPlanner.AnnoncørListeDropdown()
        Me.cboBureauNO_ = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TblBureauerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BureauListeDropdown = New WinPlanner.BureauListeDropdown()
        Me.optAntalFarver = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.txtFormat2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormat1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblRekvisitionsNr = New Infragistics.Win.Misc.UltraLabel()
        Me.lblAtt = New Infragistics.Win.Misc.UltraLabel()
        Me.lblBilagsbladTil = New Infragistics.Win.Misc.UltraLabel()
        Me.lblBeskrivelse = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRekvisitionsNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtBilagsBladeAtt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtBeskrivelse = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnKopierTilNy = New Infragistics.Win.Misc.UltraButton()
        Me.btnLuk = New Infragistics.Win.Misc.UltraButton()
        Me.btnGem = New Infragistics.Win.Misc.UltraButton()
        Me.grpMedieplanHoved = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtHistorik = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtKommentar = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblKommentar = New Infragistics.Win.Misc.UltraLabel()
        Me.clbMiljøTillægOpkræves = New System.Windows.Forms.CheckedListBox()
        Me.chkMiljøTillægVises = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkMiljøTillægOpkræves = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkKunForhandlerBundForskellig = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkMaterialeModtaget = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnFakturaBemærkning = New Infragistics.Win.Misc.UltraButton()
        Me.lblIndrykningsÅr = New Infragistics.Win.Misc.UltraLabel()
        Me.numIndrykningsÅr = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtOverskrift = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblOverskrift = New Infragistics.Win.Misc.UltraLabel()
        Me.txtBemærkningTilUgeavis = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblBemærkningTilUgeavis = New Infragistics.Win.Misc.UltraLabel()
        Me.txtBemærkningTilAnnoncør = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMaterialeFølgerFraLeverandør = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblFællesBureauOrdreNr = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFællesBureauOrdreNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.optSammeMateriale = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.btnMateriale = New Infragistics.Win.Misc.UltraButton()
        Me.txtBrugMaterialeFraUge = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblMatFraUge = New Infragistics.Win.Misc.UltraLabel()
        Me.optMaterialeFølgerFra = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.lblMaterialeFølgerFra = New Infragistics.Win.Misc.UltraLabel()
        Me.lblBemærkningTilAnnoncør = New Infragistics.Win.Misc.UltraLabel()
        Me.optBilagsBladeTil = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.lblFakturering = New Infragistics.Win.Misc.UltraLabel()
        Me.optFakturering = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.optGruppering = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.lblGruppering = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolTipManager = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.btnVisFaktureringsBilag = New System.Windows.Forms.Button()
        Me.picRød = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.btnSupportBilag = New System.Windows.Forms.Button()
        Me.btnHistorik = New System.Windows.Forms.Button()
        Me.btnKommentar = New System.Windows.Forms.Button()
        Me.btnUdskriv = New Infragistics.Win.Misc.UltraButton()
        Me.btnTilBooking = New Infragistics.Win.Misc.UltraButton()
        Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnTilBlade = New Infragistics.Win.Misc.UltraButton()
        Me.btnDækningskort = New Infragistics.Win.Misc.UltraButton()
        Me.timerSupportBilag = New System.Windows.Forms.Timer(Me.components)
        Me.lblMedieplanNr = New Infragistics.Win.Misc.UltraLabel()
        Me.timer365 = New System.Windows.Forms.Timer(Me.components)
        Me.btnGenUdsend = New Infragistics.Win.Misc.UltraButton()
        Me.ExcelExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.btnTilExcel = New Infragistics.Win.Misc.UltraButton()
        Me.chkFarveSærRabat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnGenberegn = New Infragistics.Win.Misc.UltraButton()
        Me.grdCC = New Infragistics.Win.UltraWinGrid.UltraGridColumnChooser()
        Me.chkMmSærRabat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.TblAnnoncørerTableAdapter = New WinPlanner.AnnoncørListeDropdownTableAdapters.tblAnnoncørerTableAdapter()
        Me.TblBureauerTableAdapter = New WinPlanner.BureauListeDropdownTableAdapters.tblBureauerTableAdapter()
        Me.TblPlaceringTableAdapter = New WinPlanner.PlaceringListeDropdownTableAdapters.tblPlaceringTableAdapter()
        Me.TblDPKulørTableAdapter = New WinPlanner.DPKulørListeDropDownTableAdapters.tblDPKulørTableAdapter()
        Me.TblUgeaviserTableAdapter = New WinPlanner.UgeavisListeDropdownTableAdapters.tblUgeaviserTableAdapter()
        Me.picMinMax = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.picGrøn = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.picGul = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.picStatusKode = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.picStatus = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.picPipeline = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.chkVisLåstePriser = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.grdOrdreLinjer = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.DataSourceMedieplan = New WinPlanner.dataSourceMedieplan(Me.components)
        CType(Me.cboUgebladListe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUgeaviserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UgeavisListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIndrykningsUge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDPKulørID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDPKulørBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DPKulørListeDropDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPlaceringID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPlaceringBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaceringListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAnnoncørNO_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAnnoncørerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnnoncørListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBureauNO_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBureauerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BureauListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optAntalFarver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRekvisitionsNr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBilagsBladeAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBeskrivelse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMedieplanHoved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMedieplanHoved.SuspendLayout()
        CType(Me.txtHistorik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKommentar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMiljøTillægVises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMiljøTillægOpkræves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkKunForhandlerBundForskellig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMaterialeModtaget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIndrykningsÅr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOverskrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBemærkningTilUgeavis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBemærkningTilAnnoncør, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialeFølgerFraLeverandør, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFællesBureauOrdreNr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optSammeMateriale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBrugMaterialeFraUge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optMaterialeFølgerFra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optBilagsBladeTil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optFakturering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optGruppering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFarveSærRabat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMmSærRabat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVisLåstePriser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrdreLinjer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSourceMedieplan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboUgebladListe
        '
        Me.cboUgebladListe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboUgebladListe.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboUgebladListe.DataSource = Me.TblUgeaviserBindingSource
        Me.cboUgebladListe.DisplayMember = "Navn"
        Me.cboUgebladListe.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.cboUgebladListe.Location = New System.Drawing.Point(211, 484)
        Me.cboUgebladListe.Name = "cboUgebladListe"
        Me.cboUgebladListe.Size = New System.Drawing.Size(44, 22)
        Me.cboUgebladListe.TabIndex = 361
        Me.cboUgebladListe.TabStop = False
        Me.cboUgebladListe.ValueMember = "BladID"
        Me.cboUgebladListe.Visible = False
        '
        'TblUgeaviserBindingSource
        '
        Me.TblUgeaviserBindingSource.DataMember = "tblUgeaviser"
        Me.TblUgeaviserBindingSource.DataSource = Me.UgeavisListeDropdown
        '
        'UgeavisListeDropdown
        '
        Me.UgeavisListeDropdown.DataSetName = "UgeavisListeDropdown"
        Me.UgeavisListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'numIndrykningsUge
        '
        Me.numIndrykningsUge.Location = New System.Drawing.Point(111, 130)
        Me.numIndrykningsUge.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numIndrykningsUge.MaskInput = "nnn"
        Me.numIndrykningsUge.MaxValue = 100
        Me.numIndrykningsUge.MinValue = 1
        Me.numIndrykningsUge.Name = "numIndrykningsUge"
        Me.numIndrykningsUge.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numIndrykningsUge.Size = New System.Drawing.Size(50, 22)
        Me.numIndrykningsUge.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numIndrykningsUge.SpinWrap = True
        Me.numIndrykningsUge.TabIndex = 7
        Me.numIndrykningsUge.Value = 1
        '
        'lblIndrykningsUge
        '
        Me.lblIndrykningsUge.AutoSize = True
        Me.lblIndrykningsUge.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblIndrykningsUge.Location = New System.Drawing.Point(24, 134)
        Me.lblIndrykningsUge.Name = "lblIndrykningsUge"
        Me.lblIndrykningsUge.Size = New System.Drawing.Size(57, 15)
        Me.lblIndrykningsUge.TabIndex = 369
        Me.lblIndrykningsUge.Text = "Indr. uge"
        '
        'cboDPKulørID
        '
        Me.cboDPKulørID.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDPKulørID.DataSource = Me.TblDPKulørBindingSource
        Me.cboDPKulørID.DisplayMember = "Kulør"
        Me.cboDPKulørID.DropDownListWidth = -1
        Me.cboDPKulørID.Location = New System.Drawing.Point(243, 82)
        Me.cboDPKulørID.Name = "cboDPKulørID"
        Me.cboDPKulørID.NullText = "- Kulør -"
        Me.cboDPKulørID.Size = New System.Drawing.Size(76, 22)
        Me.cboDPKulørID.TabIndex = 5
        Me.cboDPKulørID.ValueMember = "DPKulørID"
        Me.cboDPKulørID.Visible = False
        '
        'TblDPKulørBindingSource
        '
        Me.TblDPKulørBindingSource.DataMember = "tblDPKulør"
        Me.TblDPKulørBindingSource.DataSource = Me.DPKulørListeDropDown
        '
        'DPKulørListeDropDown
        '
        Me.DPKulørListeDropDown.DataSetName = "DPKulørListeDropDown"
        Me.DPKulørListeDropDown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblDPKulør
        '
        Me.lblDPKulør.AutoSize = True
        Me.lblDPKulør.Location = New System.Drawing.Point(220, 86)
        Me.lblDPKulør.Name = "lblDPKulør"
        Me.lblDPKulør.Size = New System.Drawing.Size(25, 15)
        Me.lblDPKulør.TabIndex = 367
        Me.lblDPKulør.Text = "DP-"
        Me.lblDPKulør.Visible = False
        '
        'lblAntalFarver
        '
        Me.lblAntalFarver.AutoSize = True
        Me.lblAntalFarver.Location = New System.Drawing.Point(24, 86)
        Me.lblAntalFarver.Name = "lblAntalFarver"
        Me.lblAntalFarver.Size = New System.Drawing.Size(71, 15)
        Me.lblAntalFarver.TabIndex = 366
        Me.lblAntalFarver.Text = "Antal farver"
        '
        'cboPlaceringID
        '
        Me.cboPlaceringID.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboPlaceringID.DataSource = Me.TblPlaceringBindingSource
        Me.cboPlaceringID.DisplayMember = "Betegnelse"
        Me.cboPlaceringID.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboPlaceringID.LimitToList = True
        Me.cboPlaceringID.Location = New System.Drawing.Point(111, 106)
        Me.cboPlaceringID.Name = "cboPlaceringID"
        Me.cboPlaceringID.Nullable = False
        Me.cboPlaceringID.NullText = "- Vælg Placering -"
        Me.cboPlaceringID.Size = New System.Drawing.Size(208, 22)
        Me.cboPlaceringID.TabIndex = 6
        Me.cboPlaceringID.ValueMember = "PlaceringID"
        '
        'TblPlaceringBindingSource
        '
        Me.TblPlaceringBindingSource.DataMember = "tblPlacering"
        Me.TblPlaceringBindingSource.DataSource = Me.PlaceringListeDropdown
        '
        'PlaceringListeDropdown
        '
        Me.PlaceringListeDropdown.DataSetName = "PlaceringListeDropdown"
        Me.PlaceringListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(145, 62)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(11, 15)
        Me.lblX.TabIndex = 364
        Me.lblX.Text = "x"
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(24, 62)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(45, 15)
        Me.lblFormat.TabIndex = 363
        Me.lblFormat.Text = "Format"
        '
        'lblPlacering
        '
        Me.lblPlacering.AutoSize = True
        Me.lblPlacering.Location = New System.Drawing.Point(24, 110)
        Me.lblPlacering.Name = "lblPlacering"
        Me.lblPlacering.Size = New System.Drawing.Size(56, 15)
        Me.lblPlacering.TabIndex = 362
        Me.lblPlacering.Text = "Placering"
        '
        'lblBureau
        '
        Me.lblBureau.AutoSize = True
        Me.lblBureau.Location = New System.Drawing.Point(24, 38)
        Me.lblBureau.Name = "lblBureau"
        Me.lblBureau.Size = New System.Drawing.Size(45, 15)
        Me.lblBureau.TabIndex = 361
        Me.lblBureau.Text = "Bureau"
        '
        'lblAnnoncør
        '
        Me.lblAnnoncør.AutoSize = True
        Me.lblAnnoncør.Location = New System.Drawing.Point(24, 14)
        Me.lblAnnoncør.Name = "lblAnnoncør"
        Me.lblAnnoncør.Size = New System.Drawing.Size(58, 15)
        Me.lblAnnoncør.TabIndex = 360
        Me.lblAnnoncør.Text = "Annoncør"
        '
        'cboAnnoncørNO_
        '
        Me.cboAnnoncørNO_.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAnnoncørNO_.DataSource = Me.TblAnnoncørerBindingSource
        Me.cboAnnoncørNO_.DisplayMember = "Annoncør"
        Me.cboAnnoncørNO_.DropDownListWidth = -1
        Me.cboAnnoncørNO_.LimitToList = True
        Me.cboAnnoncørNO_.Location = New System.Drawing.Point(111, 10)
        Me.cboAnnoncørNO_.MaxLength = 30
        Me.cboAnnoncørNO_.Name = "cboAnnoncørNO_"
        Me.cboAnnoncørNO_.NullText = "- Vælg Annoncør -"
        Me.cboAnnoncørNO_.Size = New System.Drawing.Size(208, 22)
        Me.cboAnnoncørNO_.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboAnnoncørNO_.TabIndex = 0
        Me.cboAnnoncørNO_.ValueMember = "AnnoncørID"
        '
        'TblAnnoncørerBindingSource
        '
        Me.TblAnnoncørerBindingSource.DataMember = "tblAnnoncører"
        Me.TblAnnoncørerBindingSource.DataSource = Me.AnnoncørListeDropdown
        '
        'AnnoncørListeDropdown
        '
        Me.AnnoncørListeDropdown.DataSetName = "AnnoncørListeDropdown"
        Me.AnnoncørListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboBureauNO_
        '
        Me.cboBureauNO_.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBureauNO_.DataSource = Me.TblBureauerBindingSource
        Me.cboBureauNO_.DisplayMember = "Annoncør"
        Me.cboBureauNO_.DropDownListWidth = -1
        Me.cboBureauNO_.Location = New System.Drawing.Point(111, 34)
        Me.cboBureauNO_.MaxLength = 30
        Me.cboBureauNO_.Name = "cboBureauNO_"
        Me.cboBureauNO_.NullText = "- Vælg Bureau -"
        Me.cboBureauNO_.Size = New System.Drawing.Size(208, 22)
        Me.cboBureauNO_.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboBureauNO_.TabIndex = 1
        Me.cboBureauNO_.ValueMember = "AnnoncørID"
        '
        'TblBureauerBindingSource
        '
        Me.TblBureauerBindingSource.DataMember = "tblBureauer"
        Me.TblBureauerBindingSource.DataSource = Me.BureauListeDropdown
        '
        'BureauListeDropdown
        '
        Me.BureauListeDropdown.DataSetName = "BureauListeDropdown"
        Me.BureauListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'optAntalFarver
        '
        Me.optAntalFarver.CheckedIndex = 0
        ValueListItem1.DataValue = CType(0, Byte)
        ValueListItem1.DisplayText = "S/H"
        ValueListItem2.DataValue = CType(1, Byte)
        ValueListItem2.DisplayText = "1 Farve"
        ValueListItem3.DataValue = CType(4, Byte)
        ValueListItem3.DisplayText = "4 Farver"
        Me.optAntalFarver.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.optAntalFarver.Location = New System.Drawing.Point(111, 84)
        Me.optAntalFarver.Name = "optAntalFarver"
        Me.optAntalFarver.Size = New System.Drawing.Size(208, 18)
        Me.optAntalFarver.TabIndex = 4
        Me.optAntalFarver.Text = "S/H"
        '
        'txtFormat2
        '
        Me.txtFormat2.Location = New System.Drawing.Point(162, 58)
        Me.txtFormat2.MaxLength = 3
        Me.txtFormat2.Name = "txtFormat2"
        Me.txtFormat2.Size = New System.Drawing.Size(50, 22)
        Me.txtFormat2.TabIndex = 3
        Me.txtFormat2.Text = "100"
        '
        'txtFormat1
        '
        Me.txtFormat1.Location = New System.Drawing.Point(111, 58)
        Me.txtFormat1.MaxLength = 1
        Me.txtFormat1.Name = "txtFormat1"
        Me.txtFormat1.Size = New System.Drawing.Size(31, 22)
        Me.txtFormat1.TabIndex = 2
        Me.txtFormat1.Text = "1"
        '
        'lblRekvisitionsNr
        '
        Me.lblRekvisitionsNr.AutoSize = True
        Me.lblRekvisitionsNr.Location = New System.Drawing.Point(703, 14)
        Me.lblRekvisitionsNr.Name = "lblRekvisitionsNr"
        Me.lblRekvisitionsNr.Size = New System.Drawing.Size(52, 15)
        Me.lblRekvisitionsNr.TabIndex = 365
        Me.lblRekvisitionsNr.Tag = "Toggle"
        Me.lblRekvisitionsNr.Text = "Rekv. nr"
        Me.lblRekvisitionsNr.Visible = False
        '
        'lblAtt
        '
        Me.lblAtt.AutoSize = True
        Me.lblAtt.Location = New System.Drawing.Point(703, 62)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(21, 15)
        Me.lblAtt.TabIndex = 364
        Me.lblAtt.Tag = "Toggle"
        Me.lblAtt.Text = "Att"
        Me.lblAtt.Visible = False
        '
        'lblBilagsbladTil
        '
        Me.lblBilagsbladTil.AutoSize = True
        Me.lblBilagsbladTil.Location = New System.Drawing.Point(702, 38)
        Me.lblBilagsbladTil.Name = "lblBilagsbladTil"
        Me.lblBilagsbladTil.Size = New System.Drawing.Size(69, 15)
        Me.lblBilagsbladTil.TabIndex = 363
        Me.lblBilagsbladTil.Tag = "Toggle"
        Me.lblBilagsbladTil.Text = "Bilagsblade"
        Me.lblBilagsbladTil.Visible = False
        '
        'lblBeskrivelse
        '
        Me.lblBeskrivelse.AutoSize = True
        Me.lblBeskrivelse.Location = New System.Drawing.Point(360, 65)
        Me.lblBeskrivelse.Name = "lblBeskrivelse"
        Me.lblBeskrivelse.Size = New System.Drawing.Size(68, 15)
        Me.lblBeskrivelse.TabIndex = 359
        Me.lblBeskrivelse.Tag = ""
        Me.lblBeskrivelse.Text = "Beskrivelse"
        Me.lblBeskrivelse.Visible = False
        '
        'txtRekvisitionsNr
        '
        Me.txtRekvisitionsNr.Location = New System.Drawing.Point(808, 10)
        Me.txtRekvisitionsNr.MaxLength = 30
        Me.txtRekvisitionsNr.Name = "txtRekvisitionsNr"
        Me.txtRekvisitionsNr.NullText = "- Skriv Rekvisitionsnr -"
        Me.txtRekvisitionsNr.Size = New System.Drawing.Size(176, 22)
        Me.txtRekvisitionsNr.TabIndex = 18
        Me.txtRekvisitionsNr.Tag = "Toggle"
        Me.txtRekvisitionsNr.Visible = False
        '
        'txtBilagsBladeAtt
        '
        Me.txtBilagsBladeAtt.Location = New System.Drawing.Point(808, 58)
        Me.txtBilagsBladeAtt.MaxLength = 30
        Me.txtBilagsBladeAtt.Name = "txtBilagsBladeAtt"
        Me.txtBilagsBladeAtt.NullText = "- Skriv Att. Person -"
        Me.txtBilagsBladeAtt.Size = New System.Drawing.Size(176, 22)
        Me.txtBilagsBladeAtt.TabIndex = 20
        Me.txtBilagsBladeAtt.Tag = "Toggle"
        Me.txtBilagsBladeAtt.Visible = False
        '
        'txtBeskrivelse
        '
        Me.txtBeskrivelse.Location = New System.Drawing.Point(464, 58)
        Me.txtBeskrivelse.MaxLength = 30
        Me.txtBeskrivelse.Name = "txtBeskrivelse"
        Me.txtBeskrivelse.NullText = "- Skriv Beskrivelse -"
        Me.txtBeskrivelse.Size = New System.Drawing.Size(224, 22)
        Me.txtBeskrivelse.TabIndex = 11
        Me.txtBeskrivelse.Tag = ""
        Me.txtBeskrivelse.Visible = False
        '
        'btnKopierTilNy
        '
        Me.btnKopierTilNy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKopierTilNy.Enabled = False
        Me.btnKopierTilNy.Location = New System.Drawing.Point(809, 484)
        Me.btnKopierTilNy.Name = "btnKopierTilNy"
        Me.btnKopierTilNy.ShowFocusRect = False
        Me.btnKopierTilNy.ShowOutline = False
        Me.btnKopierTilNy.Size = New System.Drawing.Size(87, 24)
        Me.btnKopierTilNy.TabIndex = 337
        Me.btnKopierTilNy.Text = "&Kopiér til ny"
        Me.btnKopierTilNy.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnLuk
        '
        Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuk.Enabled = False
        Me.btnLuk.Location = New System.Drawing.Point(105, 484)
        Me.btnLuk.Name = "btnLuk"
        Me.btnLuk.ShowFocusRect = False
        Me.btnLuk.ShowOutline = False
        Me.btnLuk.Size = New System.Drawing.Size(87, 24)
        Me.btnLuk.TabIndex = 338
        Me.btnLuk.Text = "&Luk"
        Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnGem
        '
        Me.btnGem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGem.Enabled = False
        Me.btnGem.Location = New System.Drawing.Point(1188, 484)
        Me.btnGem.Name = "btnGem"
        Me.btnGem.ShowFocusRect = False
        Me.btnGem.ShowOutline = False
        Me.btnGem.Size = New System.Drawing.Size(87, 24)
        Me.btnGem.TabIndex = 336
        Me.btnGem.Text = "&Gem"
        Me.btnGem.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'grpMedieplanHoved
        '
        Me.grpMedieplanHoved.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMedieplanHoved.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Parallel3D
        Me.grpMedieplanHoved.Controls.Add(Me.txtHistorik)
        Me.grpMedieplanHoved.Controls.Add(Me.txtKommentar)
        Me.grpMedieplanHoved.Controls.Add(Me.lblKommentar)
        Me.grpMedieplanHoved.Controls.Add(Me.clbMiljøTillægOpkræves)
        Me.grpMedieplanHoved.Controls.Add(Me.chkMiljøTillægVises)
        Me.grpMedieplanHoved.Controls.Add(Me.chkMiljøTillægOpkræves)
        Me.grpMedieplanHoved.Controls.Add(Me.chkKunForhandlerBundForskellig)
        Me.grpMedieplanHoved.Controls.Add(Me.chkMaterialeModtaget)
        Me.grpMedieplanHoved.Controls.Add(Me.btnFakturaBemærkning)
        Me.grpMedieplanHoved.Controls.Add(Me.lblIndrykningsÅr)
        Me.grpMedieplanHoved.Controls.Add(Me.numIndrykningsÅr)
        Me.grpMedieplanHoved.Controls.Add(Me.txtOverskrift)
        Me.grpMedieplanHoved.Controls.Add(Me.lblOverskrift)
        Me.grpMedieplanHoved.Controls.Add(Me.txtBemærkningTilUgeavis)
        Me.grpMedieplanHoved.Controls.Add(Me.lblBemærkningTilUgeavis)
        Me.grpMedieplanHoved.Controls.Add(Me.txtBemærkningTilAnnoncør)
        Me.grpMedieplanHoved.Controls.Add(Me.txtMaterialeFølgerFraLeverandør)
        Me.grpMedieplanHoved.Controls.Add(Me.lblFællesBureauOrdreNr)
        Me.grpMedieplanHoved.Controls.Add(Me.txtFællesBureauOrdreNr)
        Me.grpMedieplanHoved.Controls.Add(Me.optSammeMateriale)
        Me.grpMedieplanHoved.Controls.Add(Me.cboDPKulørID)
        Me.grpMedieplanHoved.Controls.Add(Me.lblDPKulør)
        Me.grpMedieplanHoved.Controls.Add(Me.btnMateriale)
        Me.grpMedieplanHoved.Controls.Add(Me.txtBrugMaterialeFraUge)
        Me.grpMedieplanHoved.Controls.Add(Me.lblMatFraUge)
        Me.grpMedieplanHoved.Controls.Add(Me.optMaterialeFølgerFra)
        Me.grpMedieplanHoved.Controls.Add(Me.lblMaterialeFølgerFra)
        Me.grpMedieplanHoved.Controls.Add(Me.lblBemærkningTilAnnoncør)
        Me.grpMedieplanHoved.Controls.Add(Me.lblAtt)
        Me.grpMedieplanHoved.Controls.Add(Me.lblFormat)
        Me.grpMedieplanHoved.Controls.Add(Me.txtBilagsBladeAtt)
        Me.grpMedieplanHoved.Controls.Add(Me.optBilagsBladeTil)
        Me.grpMedieplanHoved.Controls.Add(Me.lblFakturering)
        Me.grpMedieplanHoved.Controls.Add(Me.lblBilagsbladTil)
        Me.grpMedieplanHoved.Controls.Add(Me.optFakturering)
        Me.grpMedieplanHoved.Controls.Add(Me.lblRekvisitionsNr)
        Me.grpMedieplanHoved.Controls.Add(Me.numIndrykningsUge)
        Me.grpMedieplanHoved.Controls.Add(Me.lblIndrykningsUge)
        Me.grpMedieplanHoved.Controls.Add(Me.lblAnnoncør)
        Me.grpMedieplanHoved.Controls.Add(Me.cboAnnoncørNO_)
        Me.grpMedieplanHoved.Controls.Add(Me.lblBeskrivelse)
        Me.grpMedieplanHoved.Controls.Add(Me.lblBureau)
        Me.grpMedieplanHoved.Controls.Add(Me.cboBureauNO_)
        Me.grpMedieplanHoved.Controls.Add(Me.optAntalFarver)
        Me.grpMedieplanHoved.Controls.Add(Me.lblAntalFarver)
        Me.grpMedieplanHoved.Controls.Add(Me.cboPlaceringID)
        Me.grpMedieplanHoved.Controls.Add(Me.txtFormat1)
        Me.grpMedieplanHoved.Controls.Add(Me.lblPlacering)
        Me.grpMedieplanHoved.Controls.Add(Me.lblX)
        Me.grpMedieplanHoved.Controls.Add(Me.txtFormat2)
        Me.grpMedieplanHoved.Controls.Add(Me.txtRekvisitionsNr)
        Me.grpMedieplanHoved.Controls.Add(Me.txtBeskrivelse)
        Me.grpMedieplanHoved.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMedieplanHoved.Location = New System.Drawing.Point(0, 27)
        Me.grpMedieplanHoved.Margin = New System.Windows.Forms.Padding(0)
        Me.grpMedieplanHoved.Name = "grpMedieplanHoved"
        Me.grpMedieplanHoved.Size = New System.Drawing.Size(1287, 189)
        Me.grpMedieplanHoved.TabIndex = 364
        '
        'txtHistorik
        '
        Me.txtHistorik.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHistorik.Location = New System.Drawing.Point(339, 8)
        Me.txtHistorik.Multiline = True
        Me.txtHistorik.Name = "txtHistorik"
        Me.txtHistorik.ReadOnly = True
        Me.txtHistorik.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHistorik.Size = New System.Drawing.Size(923, 19)
        Me.txtHistorik.TabIndex = 389
        Me.txtHistorik.Visible = False
        '
        'txtKommentar
        '
        Me.txtKommentar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKommentar.Location = New System.Drawing.Point(1076, 10)
        Me.txtKommentar.MaxLength = 250
        Me.txtKommentar.Multiline = True
        Me.txtKommentar.Name = "txtKommentar"
        Me.txtKommentar.NullText = "- Skriv en intern Kommentar -"
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.txtKommentar.NullTextAppearance = Appearance1
        Me.txtKommentar.Size = New System.Drawing.Size(207, 77)
        Me.txtKommentar.TabIndex = 399
        Me.txtKommentar.Visible = False
        '
        'lblKommentar
        '
        Me.lblKommentar.AutoSize = True
        Me.lblKommentar.Location = New System.Drawing.Point(999, 14)
        Me.lblKommentar.Name = "lblKommentar"
        Me.lblKommentar.Size = New System.Drawing.Size(71, 15)
        Me.lblKommentar.TabIndex = 398
        Me.lblKommentar.Tag = "Toggle"
        Me.lblKommentar.Text = "Kommentar"
        Me.lblKommentar.Visible = False
        '
        'clbMiljøTillægOpkræves
        '
        Me.clbMiljøTillægOpkræves.BackColor = System.Drawing.SystemColors.ControlLight
        Me.clbMiljøTillægOpkræves.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbMiljøTillægOpkræves.ColumnWidth = 87
        Me.clbMiljøTillægOpkræves.FormattingEnabled = True
        Me.clbMiljøTillægOpkræves.Items.AddRange(New Object() {"Midtjyske", "Fynske", "NorthMedia", "DSVP", "Jyske A/S"})
        Me.clbMiljøTillægOpkræves.Location = New System.Drawing.Point(195, 155)
        Me.clbMiljøTillægOpkræves.MultiColumn = True
        Me.clbMiljøTillægOpkræves.Name = "clbMiljøTillægOpkræves"
        Me.clbMiljøTillægOpkræves.Size = New System.Drawing.Size(263, 32)
        Me.clbMiljøTillægOpkræves.TabIndex = 397
        Me.clbMiljøTillægOpkræves.Visible = False
        '
        'chkMiljøTillægVises
        '
        Me.chkMiljøTillægVises.Location = New System.Drawing.Point(38, 173)
        Me.chkMiljøTillægVises.Name = "chkMiljøTillægVises"
        Me.chkMiljøTillægVises.Size = New System.Drawing.Size(151, 15)
        Me.chkMiljøTillægVises.TabIndex = 396
        Me.chkMiljøTillægVises.Text = "Miljøtillæg vises i grid"
        Me.chkMiljøTillægVises.Visible = False
        '
        'chkMiljøTillægOpkræves
        '
        Me.chkMiljøTillægOpkræves.Checked = True
        Me.chkMiljøTillægOpkræves.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMiljøTillægOpkræves.Location = New System.Drawing.Point(24, 153)
        Me.chkMiljøTillægOpkræves.Name = "chkMiljøTillægOpkræves"
        Me.chkMiljøTillægOpkræves.Size = New System.Drawing.Size(140, 20)
        Me.chkMiljøTillægOpkræves.TabIndex = 395
        Me.chkMiljøTillægOpkræves.Text = "Miljøtillæg opkræves"
        Me.chkMiljøTillægOpkræves.Visible = False
        '
        'chkKunForhandlerBundForskellig
        '
        Me.chkKunForhandlerBundForskellig.Checked = True
        Me.chkKunForhandlerBundForskellig.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKunForhandlerBundForskellig.Location = New System.Drawing.Point(703, 169)
        Me.chkKunForhandlerBundForskellig.Name = "chkKunForhandlerBundForskellig"
        Me.chkKunForhandlerBundForskellig.Size = New System.Drawing.Size(202, 18)
        Me.chkKunForhandlerBundForskellig.TabIndex = 393
        Me.chkKunForhandlerBundForskellig.Text = "Kun forhandlerbund forskellig"
        Me.chkKunForhandlerBundForskellig.Visible = False
        '
        'chkMaterialeModtaget
        '
        Me.chkMaterialeModtaget.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMaterialeModtaget.Location = New System.Drawing.Point(528, 108)
        Me.chkMaterialeModtaget.Name = "chkMaterialeModtaget"
        Me.chkMaterialeModtaget.Size = New System.Drawing.Size(110, 20)
        Me.chkMaterialeModtaget.TabIndex = 392
        Me.chkMaterialeModtaget.Tag = "Toggle"
        Me.chkMaterialeModtaget.Text = "Matr. modtaget"
        Me.chkMaterialeModtaget.Visible = False
        '
        'btnFakturaBemærkning
        '
        Me.btnFakturaBemærkning.Location = New System.Drawing.Point(1095, 111)
        Me.btnFakturaBemærkning.Name = "btnFakturaBemærkning"
        Me.btnFakturaBemærkning.Size = New System.Drawing.Size(75, 23)
        Me.btnFakturaBemærkning.TabIndex = 400
        '
        'lblIndrykningsÅr
        '
        Me.lblIndrykningsÅr.AutoSize = True
        Me.lblIndrykningsÅr.Location = New System.Drawing.Point(197, 134)
        Me.lblIndrykningsÅr.Name = "lblIndrykningsÅr"
        Me.lblIndrykningsÅr.Size = New System.Drawing.Size(48, 15)
        Me.lblIndrykningsÅr.TabIndex = 388
        Me.lblIndrykningsÅr.Text = "Indr. år"
        '
        'numIndrykningsÅr
        '
        Me.numIndrykningsÅr.Location = New System.Drawing.Point(251, 130)
        Me.numIndrykningsÅr.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numIndrykningsÅr.MaskInput = "nnnn"
        Me.numIndrykningsÅr.MaxValue = 2020
        Me.numIndrykningsÅr.MinValue = 1996
        Me.numIndrykningsÅr.Name = "numIndrykningsÅr"
        Me.numIndrykningsÅr.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numIndrykningsÅr.Size = New System.Drawing.Size(68, 22)
        Me.numIndrykningsÅr.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numIndrykningsÅr.SpinWrap = True
        Me.numIndrykningsÅr.TabIndex = 8
        Me.numIndrykningsÅr.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numIndrykningsÅr.Value = 2008
        '
        'txtOverskrift
        '
        Me.txtOverskrift.Location = New System.Drawing.Point(464, 10)
        Me.txtOverskrift.MaxLength = 30
        Me.txtOverskrift.Name = "txtOverskrift"
        Me.txtOverskrift.NullText = "- Skriv Overskrift -"
        Me.txtOverskrift.Size = New System.Drawing.Size(224, 22)
        Me.txtOverskrift.TabIndex = 9
        Me.txtOverskrift.Tag = "Toggle"
        Me.txtOverskrift.Visible = False
        '
        'lblOverskrift
        '
        Me.lblOverskrift.AutoSize = True
        Me.lblOverskrift.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblOverskrift.Location = New System.Drawing.Point(360, 14)
        Me.lblOverskrift.Name = "lblOverskrift"
        Me.lblOverskrift.Size = New System.Drawing.Size(60, 15)
        Me.lblOverskrift.TabIndex = 387
        Me.lblOverskrift.Tag = "Toggle"
        Me.lblOverskrift.Text = "Overskrift"
        Me.lblOverskrift.Visible = False
        '
        'txtBemærkningTilUgeavis
        '
        Me.txtBemærkningTilUgeavis.AcceptsReturn = True
        Me.txtBemærkningTilUgeavis.Location = New System.Drawing.Point(808, 88)
        Me.txtBemærkningTilUgeavis.MaxLength = 250
        Me.txtBemærkningTilUgeavis.Multiline = True
        Me.txtBemærkningTilUgeavis.Name = "txtBemærkningTilUgeavis"
        Me.txtBemærkningTilUgeavis.NullText = "- Skriv Bemærkning til Ugeaviserne -"
        Me.txtBemærkningTilUgeavis.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBemærkningTilUgeavis.ShowOverflowIndicator = True
        Me.txtBemærkningTilUgeavis.Size = New System.Drawing.Size(176, 46)
        Me.txtBemærkningTilUgeavis.TabIndex = 21
        Me.txtBemærkningTilUgeavis.Tag = "Toggle"
        Me.txtBemærkningTilUgeavis.Visible = False
        '
        'lblBemærkningTilUgeavis
        '
        Me.lblBemærkningTilUgeavis.AutoSize = True
        Me.lblBemærkningTilUgeavis.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblBemærkningTilUgeavis.Location = New System.Drawing.Point(703, 87)
        Me.lblBemærkningTilUgeavis.Name = "lblBemærkningTilUgeavis"
        Me.lblBemærkningTilUgeavis.Size = New System.Drawing.Size(77, 15)
        Me.lblBemærkningTilUgeavis.TabIndex = 385
        Me.lblBemærkningTilUgeavis.Tag = "Toggle"
        Me.lblBemærkningTilUgeavis.Text = "Bemærkning"
        Me.lblBemærkningTilUgeavis.Visible = False
        '
        'txtBemærkningTilAnnoncør
        '
        Me.txtBemærkningTilAnnoncør.AcceptsReturn = True
        Me.txtBemærkningTilAnnoncør.Location = New System.Drawing.Point(464, 10)
        Me.txtBemærkningTilAnnoncør.MaxLength = 250
        Me.txtBemærkningTilAnnoncør.Multiline = True
        Me.txtBemærkningTilAnnoncør.Name = "txtBemærkningTilAnnoncør"
        Me.txtBemærkningTilAnnoncør.NullText = "- Skriv Bemærkning til Annoncøren -"
        Me.txtBemærkningTilAnnoncør.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBemærkningTilAnnoncør.ShowOverflowIndicator = True
        Me.txtBemærkningTilAnnoncør.Size = New System.Drawing.Size(224, 46)
        Me.txtBemærkningTilAnnoncør.TabIndex = 8
        Me.txtBemærkningTilAnnoncør.Tag = "Toggle"
        '
        'txtMaterialeFølgerFraLeverandør
        '
        Me.txtMaterialeFølgerFraLeverandør.Location = New System.Drawing.Point(464, 130)
        Me.txtMaterialeFølgerFraLeverandør.MaxLength = 30
        Me.txtMaterialeFølgerFraLeverandør.Name = "txtMaterialeFølgerFraLeverandør"
        Me.txtMaterialeFølgerFraLeverandør.NullText = "- Skriv matr. leverandør (til DLU) -"
        Me.txtMaterialeFølgerFraLeverandør.Size = New System.Drawing.Size(224, 22)
        Me.txtMaterialeFølgerFraLeverandør.TabIndex = 16
        Me.txtMaterialeFølgerFraLeverandør.Visible = False
        '
        'lblFællesBureauOrdreNr
        '
        Me.lblFællesBureauOrdreNr.AutoSize = True
        Me.lblFællesBureauOrdreNr.Location = New System.Drawing.Point(703, 148)
        Me.lblFællesBureauOrdreNr.Name = "lblFællesBureauOrdreNr"
        Me.lblFællesBureauOrdreNr.Size = New System.Drawing.Size(95, 15)
        Me.lblFællesBureauOrdreNr.TabIndex = 384
        Me.lblFællesBureauOrdreNr.Tag = ""
        Me.lblFællesBureauOrdreNr.Text = "Bureau ordre nr"
        Me.lblFællesBureauOrdreNr.Visible = False
        '
        'txtFællesBureauOrdreNr
        '
        Me.txtFællesBureauOrdreNr.Location = New System.Drawing.Point(808, 144)
        Me.txtFællesBureauOrdreNr.MaxLength = 30
        Me.txtFællesBureauOrdreNr.Name = "txtFællesBureauOrdreNr"
        Me.txtFællesBureauOrdreNr.NullText = " - Skriv Bureauordrenr -"
        Me.txtFællesBureauOrdreNr.Size = New System.Drawing.Size(176, 22)
        Me.txtFællesBureauOrdreNr.TabIndex = 22
        Me.txtFællesBureauOrdreNr.Tag = ""
        Me.txtFællesBureauOrdreNr.Visible = False
        '
        'optSammeMateriale
        '
        Me.optSammeMateriale.CheckedIndex = 0
        ValueListItem8.DataValue = True
        ValueListItem8.DisplayText = "Samme"
        ValueListItem9.DataValue = False
        ValueListItem9.DisplayText = "Forskelligt"
        Me.optSammeMateriale.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem8, ValueListItem9})
        Me.optSammeMateriale.Location = New System.Drawing.Point(464, 153)
        Me.optSammeMateriale.Name = "optSammeMateriale"
        Me.optSammeMateriale.Size = New System.Drawing.Size(150, 18)
        Me.optSammeMateriale.TabIndex = 17
        Me.optSammeMateriale.Tag = ""
        Me.optSammeMateriale.Text = "Samme"
        '
        'btnMateriale
        '
        Me.btnMateriale.Location = New System.Drawing.Point(360, 130)
        Me.btnMateriale.Name = "btnMateriale"
        Me.btnMateriale.ShowFocusRect = False
        Me.btnMateriale.ShowOutline = False
        Me.btnMateriale.Size = New System.Drawing.Size(87, 22)
        Me.btnMateriale.TabIndex = 15
        Me.btnMateriale.Text = "Send &Matr."
        Me.btnMateriale.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        Me.btnMateriale.Visible = False
        '
        'txtBrugMaterialeFraUge
        '
        Me.txtBrugMaterialeFraUge.Location = New System.Drawing.Point(464, 106)
        Me.txtBrugMaterialeFraUge.Name = "txtBrugMaterialeFraUge"
        Me.txtBrugMaterialeFraUge.NullText = "- Uge -"
        Me.txtBrugMaterialeFraUge.Size = New System.Drawing.Size(58, 22)
        Me.txtBrugMaterialeFraUge.TabIndex = 14
        Me.txtBrugMaterialeFraUge.Tag = ""
        Me.txtBrugMaterialeFraUge.Visible = False
        '
        'lblMatFraUge
        '
        Me.lblMatFraUge.AutoSize = True
        Me.lblMatFraUge.Location = New System.Drawing.Point(360, 110)
        Me.lblMatFraUge.Name = "lblMatFraUge"
        Me.lblMatFraUge.Size = New System.Drawing.Size(79, 15)
        Me.lblMatFraUge.TabIndex = 380
        Me.lblMatFraUge.Tag = ""
        Me.lblMatFraUge.Text = "Matr. fra uge"
        Me.lblMatFraUge.Visible = False
        '
        'optMaterialeFølgerFra
        '
        Me.optMaterialeFølgerFra.CheckedIndex = 1
        ValueListItem10.DataValue = CType(0, Byte)
        ValueListItem10.DisplayText = "Tidligere Uge"
        ValueListItem11.DataValue = CType(1, Byte)
        ValueListItem11.DisplayText = "DLU"
        ValueListItem12.DataValue = CType(2, Byte)
        ValueListItem12.DisplayText = "Bur."
        ValueListItem13.DataValue = CType(3, Byte)
        ValueListItem13.DisplayText = "Ann."
        Me.optMaterialeFølgerFra.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem10, ValueListItem11, ValueListItem12, ValueListItem13})
        Me.optMaterialeFølgerFra.Location = New System.Drawing.Point(464, 84)
        Me.optMaterialeFølgerFra.Name = "optMaterialeFølgerFra"
        Me.optMaterialeFølgerFra.Size = New System.Drawing.Size(242, 18)
        Me.optMaterialeFølgerFra.TabIndex = 13
        Me.optMaterialeFølgerFra.Tag = "Toggle"
        Me.optMaterialeFølgerFra.Text = "DLU"
        Me.optMaterialeFølgerFra.Visible = False
        '
        'lblMaterialeFølgerFra
        '
        Me.lblMaterialeFølgerFra.AutoSize = True
        Me.lblMaterialeFølgerFra.Location = New System.Drawing.Point(360, 86)
        Me.lblMaterialeFølgerFra.Name = "lblMaterialeFølgerFra"
        Me.lblMaterialeFølgerFra.Size = New System.Drawing.Size(90, 15)
        Me.lblMaterialeFølgerFra.TabIndex = 378
        Me.lblMaterialeFølgerFra.Tag = "Toggle"
        Me.lblMaterialeFølgerFra.Text = "Matr. følger fra"
        Me.lblMaterialeFølgerFra.Visible = False
        '
        'lblBemærkningTilAnnoncør
        '
        Me.lblBemærkningTilAnnoncør.AutoSize = True
        Me.lblBemærkningTilAnnoncør.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblBemærkningTilAnnoncør.Location = New System.Drawing.Point(360, 14)
        Me.lblBemærkningTilAnnoncør.Name = "lblBemærkningTilAnnoncør"
        Me.lblBemærkningTilAnnoncør.Size = New System.Drawing.Size(77, 15)
        Me.lblBemærkningTilAnnoncør.TabIndex = 374
        Me.lblBemærkningTilAnnoncør.Tag = "Toggle"
        Me.lblBemærkningTilAnnoncør.Text = "Bemærkning"
        '
        'optBilagsBladeTil
        '
        ValueListItem14.DataValue = CType(1, Byte)
        ValueListItem14.DisplayText = "Annoncør"
        ValueListItem15.DataValue = CType(2, Byte)
        ValueListItem15.DisplayText = "Bureau"
        ValueListItem16.DataValue = CType(3, Byte)
        ValueListItem16.DisplayText = "Anden"
        Me.optBilagsBladeTil.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem14, ValueListItem15, ValueListItem16})
        Me.optBilagsBladeTil.Location = New System.Drawing.Point(785, 36)
        Me.optBilagsBladeTil.Name = "optBilagsBladeTil"
        Me.optBilagsBladeTil.Size = New System.Drawing.Size(199, 18)
        Me.optBilagsBladeTil.TabIndex = 19
        Me.optBilagsBladeTil.Tag = "Toggle"
        UltraToolTipInfo6.Enabled = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolTipInfo6.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo6.ToolTipTextFormatted = "<span style=""font-weight:bold;"">Sendes Til:<span style=""font-weight:normal;""><br/" & _
    "></span><br/><br/></span>"
        UltraToolTipInfo6.ToolTipTextStyle = Infragistics.Win.ToolTipTextStyle.Formatted
        UltraToolTipInfo6.ToolTipTitle = "Bilagsblad modtager"
        Me.ToolTipManager.SetUltraToolTip(Me.optBilagsBladeTil, UltraToolTipInfo6)
        Me.optBilagsBladeTil.Visible = False
        '
        'lblFakturering
        '
        Me.lblFakturering.AutoSize = True
        Me.lblFakturering.Location = New System.Drawing.Point(360, 38)
        Me.lblFakturering.Name = "lblFakturering"
        Me.lblFakturering.Size = New System.Drawing.Size(70, 15)
        Me.lblFakturering.TabIndex = 372
        Me.lblFakturering.Tag = "Toggle"
        Me.lblFakturering.Text = "Fakturering"
        Me.lblFakturering.Visible = False
        '
        'optFakturering
        '
        Me.optFakturering.CheckedIndex = 0
        ValueListItem17.DataValue = CType(1, Byte)
        ValueListItem17.DisplayText = "DLU"
        ValueListItem18.DataValue = CType(0, Byte)
        ValueListItem18.DisplayText = "Blad"
        Me.optFakturering.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem17, ValueListItem18})
        Me.optFakturering.Location = New System.Drawing.Point(464, 36)
        Me.optFakturering.Name = "optFakturering"
        Me.optFakturering.Size = New System.Drawing.Size(102, 18)
        Me.optFakturering.TabIndex = 10
        Me.optFakturering.Tag = "Toggle"
        Me.optFakturering.Text = "DLU"
        Me.optFakturering.Visible = False
        '
        'optGruppering
        '
        Me.optGruppering.CheckedIndex = 0
        ValueListItem4.DataValue = CType(0, Byte)
        ValueListItem4.DisplayText = "Regioner"
        ValueListItem5.DataValue = CType(1, Byte)
        ValueListItem5.DisplayText = "Rabatformer"
        ValueListItem6.DataValue = CType(2, Byte)
        ValueListItem6.DisplayText = "Udsendingsgrupper"
        ValueListItem7.DataValue = CType(3, Byte)
        ValueListItem7.DisplayText = "Ingen"
        Me.optGruppering.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7})
        Me.optGruppering.Location = New System.Drawing.Point(64, 215)
        Me.optGruppering.Name = "optGruppering"
        Me.optGruppering.Size = New System.Drawing.Size(255, 39)
        Me.optGruppering.TabIndex = 365
        Me.optGruppering.TabStop = False
        Me.optGruppering.Text = "Regioner"
        Me.optGruppering.ValueMember = ""
        '
        'lblGruppering
        '
        Me.lblGruppering.AutoSize = True
        Me.lblGruppering.Location = New System.Drawing.Point(1, 224)
        Me.lblGruppering.Name = "lblGruppering"
        Me.lblGruppering.Size = New System.Drawing.Size(57, 15)
        Me.lblGruppering.TabIndex = 366
        Me.lblGruppering.Text = "Sortering"
        '
        'ToolTipManager
        '
        Appearance2.FontData.SizeInPoints = 10.0!
        Me.ToolTipManager.Appearance = Appearance2
        Me.ToolTipManager.AutoPopDelay = 50000
        Me.ToolTipManager.ContainingControl = Me
        Me.ToolTipManager.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.ToolTipManager.InitialDelay = 0
        Me.ToolTipManager.ToolTipTextStyle = Infragistics.Win.ToolTipTextStyle.Formatted
        Appearance60.FontData.BoldAsString = "True"
        Appearance60.FontData.SizeInPoints = 14.0!
        Appearance60.FontData.UnderlineAsString = "True"
        Me.ToolTipManager.ToolTipTitleAppearance = Appearance60
        '
        'btnVisFaktureringsBilag
        '
        Me.btnVisFaktureringsBilag.Image = Global.WinPlanner.My.Resources.Resources.file
        Me.btnVisFaktureringsBilag.Location = New System.Drawing.Point(886, 4)
        Me.btnVisFaktureringsBilag.Name = "btnVisFaktureringsBilag"
        Me.btnVisFaktureringsBilag.Size = New System.Drawing.Size(25, 28)
        Me.btnVisFaktureringsBilag.TabIndex = 380
        Me.btnVisFaktureringsBilag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        UltraToolTipInfo1.ToolTipText = "Klik her for at åbne/lukke fakturerings bilag"
        UltraToolTipInfo1.ToolTipTextStyle = Infragistics.Win.ToolTipTextStyle.Raw
        Me.ToolTipManager.SetUltraToolTip(Me.btnVisFaktureringsBilag, UltraToolTipInfo1)
        Me.btnVisFaktureringsBilag.UseVisualStyleBackColor = True
        Me.btnVisFaktureringsBilag.Visible = False
        '
        'picRød
        '
        Me.picRød.AutoSize = True
        Me.picRød.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.picRød.BorderShadowColor = System.Drawing.Color.Empty
        Me.picRød.Image = CType(resources.GetObject("picRød.Image"), Object)
        Me.picRød.Location = New System.Drawing.Point(734, 7)
        Me.picRød.Name = "picRød"
        Me.picRød.Size = New System.Drawing.Size(26, 22)
        Me.picRød.TabIndex = 332
        Me.picRød.Tag = "On"
        UltraToolTipInfo2.Enabled = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolTipInfo2.ToolTipImage = Infragistics.Win.ToolTipImage.Warning
        UltraToolTipInfo2.ToolTipTextStyle = Infragistics.Win.ToolTipTextStyle.Formatted
        UltraToolTipInfo2.ToolTipTitle = "For at save:"
        Me.ToolTipManager.SetUltraToolTip(Me.picRød, UltraToolTipInfo2)
        '
        'btnSupportBilag
        '
        Me.btnSupportBilag.Image = Global.WinPlanner.My.Resources.Resources.MultiplePagesImage
        Me.btnSupportBilag.Location = New System.Drawing.Point(766, 9)
        Me.btnSupportBilag.Name = "btnSupportBilag"
        Me.btnSupportBilag.Size = New System.Drawing.Size(22, 22)
        Me.btnSupportBilag.TabIndex = 371
        Me.btnSupportBilag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        UltraToolTipInfo3.Enabled = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolTipInfo3.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo3.ToolTipText = "Der er vedhæftet et support bilag"
        UltraToolTipInfo3.ToolTipTextStyle = Infragistics.Win.ToolTipTextStyle.Raw
        UltraToolTipInfo3.ToolTipTitle = "Bilag vedhæftet"
        Me.ToolTipManager.SetUltraToolTip(Me.btnSupportBilag, UltraToolTipInfo3)
        Me.btnSupportBilag.UseVisualStyleBackColor = True
        Me.btnSupportBilag.Visible = False
        '
        'btnHistorik
        '
        Me.btnHistorik.Image = CType(resources.GetObject("btnHistorik.Image"), System.Drawing.Image)
        Me.btnHistorik.Location = New System.Drawing.Point(793, 6)
        Me.btnHistorik.Name = "btnHistorik"
        Me.btnHistorik.Size = New System.Drawing.Size(25, 25)
        Me.btnHistorik.TabIndex = 376
        Me.btnHistorik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        UltraToolTipInfo4.Enabled = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolTipInfo4.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo4.ToolTipText = "Klik her for at åbne/lukke historik"
        UltraToolTipInfo4.ToolTipTextStyle = Infragistics.Win.ToolTipTextStyle.Raw
        UltraToolTipInfo4.ToolTipTitle = "Historik"
        Me.ToolTipManager.SetUltraToolTip(Me.btnHistorik, UltraToolTipInfo4)
        Me.btnHistorik.UseVisualStyleBackColor = True
        Me.btnHistorik.Visible = False
        '
        'btnKommentar
        '
        Me.btnKommentar.BackgroundImage = Global.WinPlanner.My.Resources.Resources.file
        Me.btnKommentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKommentar.Location = New System.Drawing.Point(824, 3)
        Me.btnKommentar.Name = "btnKommentar"
        Me.btnKommentar.Size = New System.Drawing.Size(28, 28)
        Me.btnKommentar.TabIndex = 381
        Me.btnKommentar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        UltraToolTipInfo5.Enabled = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolTipInfo5.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo5.ToolTipTextFormatted = "Klik her for at <b>skrive</b> en intern Kommentar."
        UltraToolTipInfo5.ToolTipTextStyle = Infragistics.Win.ToolTipTextStyle.Formatted
        UltraToolTipInfo5.ToolTipTitle = "Kommentar"
        Me.ToolTipManager.SetUltraToolTip(Me.btnKommentar, UltraToolTipInfo5)
        Me.btnKommentar.UseVisualStyleBackColor = False
        Me.btnKommentar.Visible = False
        '
        'btnUdskriv
        '
        Me.btnUdskriv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUdskriv.Enabled = False
        Me.btnUdskriv.Location = New System.Drawing.Point(1095, 484)
        Me.btnUdskriv.Name = "btnUdskriv"
        Me.btnUdskriv.ShowFocusRect = False
        Me.btnUdskriv.ShowOutline = False
        Me.btnUdskriv.Size = New System.Drawing.Size(87, 24)
        Me.btnUdskriv.TabIndex = 367
        Me.btnUdskriv.Text = "&Udskriv"
        Me.btnUdskriv.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnTilBooking
        '
        Me.btnTilBooking.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTilBooking.Enabled = False
        Me.btnTilBooking.Location = New System.Drawing.Point(902, 484)
        Me.btnTilBooking.Name = "btnTilBooking"
        Me.btnTilBooking.ShowFocusRect = False
        Me.btnTilBooking.ShowOutline = False
        Me.btnTilBooking.Size = New System.Drawing.Size(87, 24)
        Me.btnTilBooking.TabIndex = 368
        Me.btnTilBooking.Text = "Til &Booking"
        Me.btnTilBooking.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnAnnuller
        '
        Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnnuller.Location = New System.Drawing.Point(12, 484)
        Me.btnAnnuller.Name = "btnAnnuller"
        Me.btnAnnuller.ShowFocusRect = False
        Me.btnAnnuller.ShowOutline = False
        Me.btnAnnuller.Size = New System.Drawing.Size(87, 24)
        Me.btnAnnuller.TabIndex = 19
        Me.btnAnnuller.Text = "&Annuller"
        Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'Timer
        '
        Me.Timer.Interval = 300
        '
        'btnTilBlade
        '
        Me.btnTilBlade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTilBlade.Enabled = False
        Me.btnTilBlade.Location = New System.Drawing.Point(705, 484)
        Me.btnTilBlade.Name = "btnTilBlade"
        Me.btnTilBlade.ShowFocusRect = False
        Me.btnTilBlade.ShowOutline = False
        Me.btnTilBlade.Size = New System.Drawing.Size(87, 24)
        Me.btnTilBlade.TabIndex = 369
        Me.btnTilBlade.Text = "&Til Blade"
        Me.btnTilBlade.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnDækningskort
        '
        Me.btnDækningskort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDækningskort.Location = New System.Drawing.Point(995, 484)
        Me.btnDækningskort.Name = "btnDækningskort"
        Me.btnDækningskort.ShowFocusRect = False
        Me.btnDækningskort.ShowOutline = False
        Me.btnDækningskort.Size = New System.Drawing.Size(94, 24)
        Me.btnDækningskort.TabIndex = 370
        Me.btnDækningskort.Text = "&Dækningskort"
        Me.btnDækningskort.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'timerSupportBilag
        '
        Me.timerSupportBilag.Interval = 500
        '
        'lblMedieplanNr
        '
        Appearance59.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMedieplanNr.Appearance = Appearance59
        Me.lblMedieplanNr.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedieplanNr.Location = New System.Drawing.Point(105, 12)
        Me.lblMedieplanNr.Name = "lblMedieplanNr"
        Me.lblMedieplanNr.Size = New System.Drawing.Size(101, 14)
        Me.lblMedieplanNr.TabIndex = 372
        Me.lblMedieplanNr.Text = "- ikke tildelt -"
        Me.lblMedieplanNr.UseAppStyling = False
        '
        'timer365
        '
        Me.timer365.Interval = 500
        '
        'btnGenUdsend
        '
        Me.btnGenUdsend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenUdsend.Enabled = False
        Me.btnGenUdsend.Location = New System.Drawing.Point(612, 484)
        Me.btnGenUdsend.Name = "btnGenUdsend"
        Me.btnGenUdsend.ShowFocusRect = False
        Me.btnGenUdsend.ShowOutline = False
        Me.btnGenUdsend.Size = New System.Drawing.Size(87, 24)
        Me.btnGenUdsend.TabIndex = 373
        Me.btnGenUdsend.Text = "Genudsend"
        Me.btnGenUdsend.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        Me.btnGenUdsend.Visible = False
        '
        'btnTilExcel
        '
        Me.btnTilExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTilExcel.Enabled = False
        Me.btnTilExcel.Location = New System.Drawing.Point(1188, 220)
        Me.btnTilExcel.Name = "btnTilExcel"
        Me.btnTilExcel.ShowFocusRect = False
        Me.btnTilExcel.ShowOutline = False
        Me.btnTilExcel.Size = New System.Drawing.Size(87, 24)
        Me.btnTilExcel.TabIndex = 374
        Me.btnTilExcel.Text = "Send til Excel"
        Me.btnTilExcel.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        Me.btnTilExcel.UseMnemonic = False
        '
        'chkFarveSærRabat
        '
        Me.chkFarveSærRabat.Location = New System.Drawing.Point(635, 222)
        Me.chkFarveSærRabat.Name = "chkFarveSærRabat"
        Me.chkFarveSærRabat.Size = New System.Drawing.Size(172, 20)
        Me.chkFarveSærRabat.TabIndex = 375
        Me.chkFarveSærRabat.Text = "Alle må give farverabat"
        Me.chkFarveSærRabat.Visible = False
        '
        'btnGenberegn
        '
        Me.btnGenberegn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenberegn.Location = New System.Drawing.Point(1080, 220)
        Me.btnGenberegn.Name = "btnGenberegn"
        Me.btnGenberegn.ShowFocusRect = False
        Me.btnGenberegn.ShowOutline = False
        Me.btnGenberegn.Size = New System.Drawing.Size(87, 24)
        Me.btnGenberegn.TabIndex = 377
        Me.btnGenberegn.Text = "Genberegn"
        Me.btnGenberegn.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        Me.btnGenberegn.Visible = False
        '
        'grdCC
        '
        Me.grdCC.ColumnDisplayOrder = Infragistics.Win.UltraWinGrid.ColumnDisplayOrder.SameAsGrid
        Appearance3.ForeColorDisabled = System.Drawing.Color.Black
        Me.grdCC.DisplayLayout.Appearance = Appearance3
        Me.grdCC.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.grdCC.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdCC.DisplayLayout.MaxColScrollRegions = 1
        Me.grdCC.DisplayLayout.MaxRowScrollRegions = 1
        Me.grdCC.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdCC.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.grdCC.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdCC.DisplayLayout.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdCC.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdCC.DisplayLayout.Override.CellPadding = 2
        Me.grdCC.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.Never
        Me.grdCC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.[Select]
        Me.grdCC.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdCC.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFixed
        Me.grdCC.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdCC.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdCC.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdCC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.grdCC.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdCC.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdCC.Location = New System.Drawing.Point(186, 185)
        Me.grdCC.MultipleBandSupport = Infragistics.Win.UltraWinGrid.MultipleBandSupport.SingleBandOnly
        Me.grdCC.Name = "grdCC"
        Me.grdCC.SerializedCurrentBandKey = "OrdreLinjer"
        Me.grdCC.Size = New System.Drawing.Size(179, 232)
        Me.grdCC.SourceGrid = Me.grdOrdreLinjer
        Me.grdCC.StyleLibraryName = ""
        Me.grdCC.StyleSetName = ""
        Me.grdCC.TabIndex = 378
        Me.grdCC.Text = "Vælg Kolonner"
        Me.grdCC.Visible = False
        '
        'chkMmSærRabat
        '
        Me.chkMmSærRabat.Location = New System.Drawing.Point(422, 222)
        Me.chkMmSærRabat.Name = "chkMmSærRabat"
        Me.chkMmSærRabat.Size = New System.Drawing.Size(172, 20)
        Me.chkMmSærRabat.TabIndex = 379
        Me.chkMmSærRabat.Text = "Alle må give mm rabat"
        '
        'TblAnnoncørerTableAdapter
        '
        Me.TblAnnoncørerTableAdapter.ClearBeforeFill = True
        '
        'TblBureauerTableAdapter
        '
        Me.TblBureauerTableAdapter.ClearBeforeFill = True
        '
        'TblPlaceringTableAdapter
        '
        Me.TblPlaceringTableAdapter.ClearBeforeFill = True
        '
        'TblDPKulørTableAdapter
        '
        Me.TblDPKulørTableAdapter.ClearBeforeFill = True
        '
        'TblUgeaviserTableAdapter
        '
        Me.TblUgeaviserTableAdapter.ClearBeforeFill = True
        '
        'picMinMax
        '
        Me.picMinMax.BorderShadowColor = System.Drawing.Color.Empty
        Me.picMinMax.Image = CType(resources.GetObject("picMinMax.Image"), Object)
        Me.picMinMax.Location = New System.Drawing.Point(1, 248)
        Me.picMinMax.Margin = New System.Windows.Forms.Padding(0)
        Me.picMinMax.Name = "picMinMax"
        Me.picMinMax.Size = New System.Drawing.Size(22, 22)
        Me.picMinMax.TabIndex = 362
        '
        'picGrøn
        '
        Me.picGrøn.BorderShadowColor = System.Drawing.Color.Empty
        Me.picGrøn.Image = CType(resources.GetObject("picGrøn.Image"), Object)
        Me.picGrøn.Location = New System.Drawing.Point(687, 7)
        Me.picGrøn.Name = "picGrøn"
        Me.picGrøn.Size = New System.Drawing.Size(28, 22)
        Me.picGrøn.TabIndex = 330
        Me.picGrøn.Tag = "Off"
        '
        'picGul
        '
        Me.picGul.AutoSize = True
        Me.picGul.BorderShadowColor = System.Drawing.Color.Empty
        Me.picGul.Image = CType(resources.GetObject("picGul.Image"), Object)
        Me.picGul.Location = New System.Drawing.Point(715, 7)
        Me.picGul.Name = "picGul"
        Me.picGul.Size = New System.Drawing.Size(18, 22)
        Me.picGul.TabIndex = 331
        Me.picGul.Tag = "Off"
        '
        'picStatusKode
        '
        Me.picStatusKode.AutoSize = True
        Me.picStatusKode.BorderShadowColor = System.Drawing.Color.Empty
        Me.picStatusKode.Image = CType(resources.GetObject("picStatusKode.Image"), Object)
        Me.picStatusKode.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picStatusKode.Location = New System.Drawing.Point(261, 14)
        Me.picStatusKode.Name = "picStatusKode"
        Me.picStatusKode.Size = New System.Drawing.Size(221, 10)
        Me.picStatusKode.TabIndex = 339
        '
        'picStatus
        '
        Me.picStatus.AutoSize = True
        Me.picStatus.BorderShadowColor = System.Drawing.Color.Empty
        Me.picStatus.Image = CType(resources.GetObject("picStatus.Image"), Object)
        Me.picStatus.Location = New System.Drawing.Point(17, 7)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.Size = New System.Drawing.Size(750, 23)
        Me.picStatus.TabIndex = 329
        '
        'picPipeline
        '
        Me.picPipeline.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPipeline.AutoSize = True
        Me.picPipeline.BorderShadowColor = System.Drawing.Color.Empty
        Me.picPipeline.Image = CType(resources.GetObject("picPipeline.Image"), Object)
        Me.picPipeline.Location = New System.Drawing.Point(1143, 2)
        Me.picPipeline.Name = "picPipeline"
        Me.picPipeline.ScaleImage = Infragistics.Win.ScaleImage.Never
        Me.picPipeline.Size = New System.Drawing.Size(145, 26)
        Me.picPipeline.TabIndex = 326
        '
        'chkVisLåstePriser
        '
        Me.chkVisLåstePriser.Location = New System.Drawing.Point(326, 224)
        Me.chkVisLåstePriser.Name = "chkVisLåstePriser"
        Me.chkVisLåstePriser.Size = New System.Drawing.Size(102, 20)
        Me.chkVisLåstePriser.TabIndex = 382
        Me.chkVisLåstePriser.Text = "Vis Lås priser"
        Me.chkVisLåstePriser.Visible = False
        '
        'grdOrdreLinjer
        '
        Me.grdOrdreLinjer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOrdreLinjer.DataMember = "OrdreLinjer"
        Me.grdOrdreLinjer.DataSource = Me.DataSourceMedieplan
        Me.grdOrdreLinjer.DisplayLayout.AddNewBox.Prompt = "Tilføj..."
        Appearance4.ForeColorDisabled = System.Drawing.Color.Black
        Me.grdOrdreLinjer.DisplayLayout.Appearance = Appearance4
        Me.grdOrdreLinjer.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn1.Header.VisiblePosition = 2
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn2.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance5.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance5
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn2.EditorComponent = Me.cboUgebladListe
        UltraGridColumn2.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance6.TextHAlignAsString = "Left"
        UltraGridColumn2.Header.Appearance = Appearance6
        UltraGridColumn2.Header.Caption = "Ugeavis Titel"
        UltraGridColumn2.Header.Fixed = True
        UltraGridColumn2.Header.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Width = 300
        UltraGridColumn3.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn9.Header.Caption = "Normal Mm Pris"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance7
        UltraGridColumn10.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn10.Format = "#0.00"
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn10.Header.Appearance = Appearance8
        UltraGridColumn10.Header.Caption = "Mm Pris"
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn11.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Hidden = True
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance9
        UltraGridColumn12.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn12.Format = "##0.00"
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn12.Header.Appearance = Appearance10
        UltraGridColumn12.Header.Caption = "Mm Rabat"
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn13.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Hidden = True
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance11
        UltraGridColumn14.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn14.Format = "#,##0.00"
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn14.Header.Appearance = Appearance12
        UltraGridColumn14.Header.Caption = "Mm Total"
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn15.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn16.Header.Caption = "Farve Tillæg"
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance13
        UltraGridColumn17.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn17.Format = "#,##0.00"
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn17.Header.Appearance = Appearance14
        UltraGridColumn17.Header.Caption = "Farve Pris"
        UltraGridColumn17.Header.VisiblePosition = 18
        UltraGridColumn18.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn18.Header.VisiblePosition = 19
        UltraGridColumn18.Hidden = True
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance15
        UltraGridColumn19.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn19.Format = "##0.00"
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn19.Header.Appearance = Appearance16
        UltraGridColumn19.Header.Caption = "Farve Rabat"
        UltraGridColumn19.Header.VisiblePosition = 20
        UltraGridColumn20.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn20.Hidden = True
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance17
        UltraGridColumn21.ColumnChooserCaption = "Farve Total"
        UltraGridColumn21.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn21.Format = "#,##0.00"
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn21.Header.Appearance = Appearance18
        UltraGridColumn21.Header.Caption = "Farve Total"
        UltraGridColumn21.Header.VisiblePosition = 22
        UltraGridColumn22.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn22.Header.VisiblePosition = 23
        UltraGridColumn22.Hidden = True
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance19
        UltraGridColumn23.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn23.Format = "#,##0.00"
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn23.Header.Appearance = Appearance20
        UltraGridColumn23.Header.Caption = "Total"
        UltraGridColumn23.Header.VisiblePosition = 24
        UltraGridColumn24.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn24.Header.VisiblePosition = 31
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn25.Header.VisiblePosition = 32
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn26.Header.VisiblePosition = 33
        UltraGridColumn26.Hidden = True
        Appearance21.TextHAlignAsString = "Left"
        UltraGridColumn27.CellAppearance = Appearance21
        UltraGridColumn27.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance22.TextHAlignAsString = "Left"
        UltraGridColumn27.Header.Appearance = Appearance22
        UltraGridColumn27.Header.Caption = "Bemærkning til Ugeavis"
        UltraGridColumn27.Header.VisiblePosition = 34
        UltraGridColumn27.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString
        UltraGridColumn27.SupportDataErrorInfo = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn27.Width = 400
        UltraGridColumn28.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn28.Header.VisiblePosition = 35
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[False]
        UltraGridColumn29.Header.Caption = "Bureau ordre nr"
        UltraGridColumn29.Header.VisiblePosition = 3
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString
        UltraGridColumn29.SupportDataErrorInfo = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn30.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn30.Header.VisiblePosition = 37
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn31.Header.VisiblePosition = 38
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance23.TextHAlignAsString = "Left"
        UltraGridColumn32.Header.Appearance = Appearance23
        UltraGridColumn32.Header.Caption = "Fejl Tekst"
        UltraGridColumn32.Header.VisiblePosition = 27
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance24.TextHAlignAsString = "Left"
        UltraGridColumn33.Header.Appearance = Appearance24
        UltraGridColumn33.Header.Caption = "Ansvar"
        UltraGridColumn33.Header.VisiblePosition = 30
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString
        UltraGridColumn33.SupportDataErrorInfo = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn34.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn34.Header.VisiblePosition = 39
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn35.Header.VisiblePosition = 40
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn36.Header.VisiblePosition = 41
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn37.Header.VisiblePosition = 42
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn38.Header.VisiblePosition = 43
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance25.ForeColorDisabled = System.Drawing.Color.DarkGray
        UltraGridColumn39.CellAppearance = Appearance25
        Appearance26.TextHAlignAsString = "Left"
        UltraGridColumn39.Header.Appearance = Appearance26
        UltraGridColumn39.Header.Caption = "Med i grupperne"
        UltraGridColumn39.Header.VisiblePosition = 44
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn40.Header.VisiblePosition = 45
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn41.Header.VisiblePosition = 46
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn42.Header.VisiblePosition = 47
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn43.Header.VisiblePosition = 48
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn44.Header.VisiblePosition = 49
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn45.Header.VisiblePosition = 50
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance27.ForeColorDisabled = System.Drawing.Color.DarkGray
        UltraGridColumn46.CellAppearance = Appearance27
        Appearance28.TextHAlignAsString = "Left"
        UltraGridColumn46.Header.Appearance = Appearance28
        UltraGridColumn46.Header.VisiblePosition = 51
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        UltraGridColumn47.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn47.Header.VisiblePosition = 52
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn48.Header.VisiblePosition = 53
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn49.Header.VisiblePosition = 54
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn50.Header.VisiblePosition = 55
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn51.Header.VisiblePosition = 56
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn52.Header.VisiblePosition = 57
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn53.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn53.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance29.TextHAlignAsString = "Left"
        UltraGridColumn53.Header.Appearance = Appearance29
        UltraGridColumn53.Header.Caption = "Bemærkning fra prisforespørgsel"
        UltraGridColumn53.Header.VisiblePosition = 58
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.Width = 300
        UltraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance30.ForeColor = System.Drawing.Color.Black
        Appearance30.ForeColorDisabled = System.Drawing.Color.Black
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn54.CellAppearance = Appearance30
        UltraGridColumn54.ColumnChooserCaption = "Miljø Tillæg"
        UltraGridColumn54.Format = "#,##0.00"
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn54.Header.Appearance = Appearance31
        UltraGridColumn54.Header.Caption = "Miljøtillæg"
        UltraGridColumn54.Header.VisiblePosition = 25
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.Width = 71
        UltraGridColumn55.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance32.ForeColor = System.Drawing.Color.Black
        Appearance32.ForeColorDisabled = System.Drawing.Color.Black
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn55.CellAppearance = Appearance32
        UltraGridColumn55.ColumnChooserCaption = "Total incl. Tillæg"
        UltraGridColumn55.Format = "#,##0.00"
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn55.Header.Appearance = Appearance33
        UltraGridColumn55.Header.Caption = "Total incl. tillæg"
        UltraGridColumn55.Header.VisiblePosition = 26
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.Width = 97
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance34.ForeColor = System.Drawing.Color.Black
        Appearance34.ForeColorDisabled = System.Drawing.Color.Black
        UltraGridColumn56.CellAppearance = Appearance34
        UltraGridColumn56.ColumnChooserCaption = "Materiale deadline"
        UltraGridColumn56.Header.Caption = "Mat. deadline"
        UltraGridColumn56.Header.VisiblePosition = 36
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance35.ForeColor = System.Drawing.Color.Black
        Appearance35.ForeColorDisabled = System.Drawing.Color.Black
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn57.CellAppearance = Appearance35
        UltraGridColumn57.Format = "#,##0"
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn57.Header.Appearance = Appearance36
        UltraGridColumn57.Header.VisiblePosition = 59
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance37.ForeColor = System.Drawing.Color.Black
        Appearance37.ForeColorDisabled = System.Drawing.Color.Black
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn58.CellAppearance = Appearance37
        UltraGridColumn58.Format = "#,##0"
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn58.Header.Appearance = Appearance38
        UltraGridColumn58.Header.VisiblePosition = 60
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance39.ForeColor = System.Drawing.Color.Black
        Appearance39.ForeColorDisabled = System.Drawing.Color.Black
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn59.CellAppearance = Appearance39
        UltraGridColumn59.ColumnChooserCaption = "Kontaktpris Oplag"
        UltraGridColumn59.Format = "#,##0.00"
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn59.Header.Appearance = Appearance40
        UltraGridColumn59.Header.Caption = "Kon. Oplag"
        UltraGridColumn59.Header.VisiblePosition = 28
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        Appearance41.ForeColor = System.Drawing.Color.Black
        Appearance41.ForeColorDisabled = System.Drawing.Color.Black
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn60.CellAppearance = Appearance41
        UltraGridColumn60.ColumnChooserCaption = "Kontaktpris Læsertal"
        UltraGridColumn60.Format = "#,##0.00"
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn60.Header.Appearance = Appearance42
        UltraGridColumn60.Header.Caption = "Kon. Læser"
        UltraGridColumn60.Header.VisiblePosition = 29
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.Caption = "Lås"
        UltraGridColumn61.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.RowsCollection
        UltraGridColumn61.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn61.Header.VisiblePosition = 1
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.Width = 40
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61})
        UltraGridBand1.Indentation = 0
        UltraGridBand1.IndentationGroupByRow = 0
        UltraGridBand1.IndentationGroupByRowExpansionIndicator = 0
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridBand1.Override.GroupByRowExpansionStyle = Infragistics.Win.UltraWinGrid.GroupByRowExpansionStyle.Disabled
        UltraGridBand1.Override.GroupByRowInitialExpansionState = Infragistics.Win.UltraWinGrid.GroupByRowInitialExpansionState.Expanded
        UltraGridBand1.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        UltraGridBand1.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.RepeatOnBreak
        UltraGridBand1.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.None
        UltraGridBand1.ScrollTipField = "UgeavisID"
        Appearance43.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance43
        SummarySettings1.DisplayFormat = "{0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance44
        Appearance45.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance45
        SummarySettings2.DisplayFormat = "{0:#,##0.00}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance46
        Appearance47.TextHAlignAsString = "Right"
        SummarySettings3.Appearance = Appearance47
        SummarySettings3.DisplayFormat = "{0:#,##0.00}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance48
        Appearance49.TextHAlignAsString = "Right"
        SummarySettings4.Appearance = Appearance49
        SummarySettings4.DisplayFormat = "{0:#,##0.00}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance50
        Appearance51.TextHAlignAsString = "Right"
        SummarySettings5.Appearance = Appearance51
        SummarySettings5.DisplayFormat = "{0:#,##0.00}"
        SummarySettings5.GroupBySummaryValueAppearance = Appearance52
        Appearance53.TextHAlignAsString = "Right"
        SummarySettings6.Appearance = Appearance53
        SummarySettings6.DisplayFormat = "{0:#,##0.00}"
        SummarySettings6.GroupBySummaryValueAppearance = Appearance54
        Appearance55.TextHAlignAsString = "Right"
        SummarySettings7.Appearance = Appearance55
        SummarySettings7.DisplayFormat = "{0:#,##0.00}"
        SummarySettings7.GroupBySummaryValueAppearance = Appearance56
        Appearance57.TextHAlignAsString = "Right"
        SummarySettings8.Appearance = Appearance57
        SummarySettings8.DisplayFormat = "{0:#,##0.00}"
        SummarySettings8.GroupBySummaryValueAppearance = Appearance58
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4, SummarySettings5, SummarySettings6, SummarySettings7, SummarySettings8})
        UltraGridBand1.SummaryFooterCaption = "I alt"
        Me.grdOrdreLinjer.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdOrdreLinjer.DisplayLayout.ColumnChooserEnabled = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdOrdreLinjer.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdOrdreLinjer.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.PrefixWithEmptyCell
        Me.grdOrdreLinjer.DisplayLayout.GroupByBox.Hidden = True
        Me.grdOrdreLinjer.DisplayLayout.GroupByBox.ShowBandLabels = Infragistics.Win.UltraWinGrid.ShowBandLabels.AllWithGroupByColumnsOnly
        Me.grdOrdreLinjer.DisplayLayout.GroupByBox.Style = Infragistics.Win.UltraWinGrid.GroupByBoxStyle.Compact
        Me.grdOrdreLinjer.DisplayLayout.InterBandSpacing = 0
        Me.grdOrdreLinjer.DisplayLayout.MaxBandDepth = 5
        Me.grdOrdreLinjer.DisplayLayout.MaxColScrollRegions = 1
        Me.grdOrdreLinjer.DisplayLayout.MaxRowScrollRegions = 1
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowMultiCellOperations = CType((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy Or Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders), Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)
        Me.grdOrdreLinjer.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdOrdreLinjer.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdOrdreLinjer.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.Never
        Me.grdOrdreLinjer.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.grdOrdreLinjer.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
        Me.grdOrdreLinjer.DisplayLayout.Override.GroupByColumnsHidden = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdOrdreLinjer.DisplayLayout.Override.GroupByRowDescriptionMask = "[value] ([count] [count,ugeaviser,ugeavis,ugeaviser])"
        Me.grdOrdreLinjer.DisplayLayout.Override.GroupByRowExpansionStyle = Infragistics.Win.UltraWinGrid.GroupByRowExpansionStyle.Disabled
        Me.grdOrdreLinjer.DisplayLayout.Override.GroupByRowInitialExpansionState = Infragistics.Win.UltraWinGrid.GroupByRowInitialExpansionState.Expanded
        Me.grdOrdreLinjer.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Me.grdOrdreLinjer.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdOrdreLinjer.DisplayLayout.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.RepeatOnBreak
        Me.grdOrdreLinjer.DisplayLayout.Override.InvalidValueBehavior = Infragistics.Win.UltraWinGrid.InvalidValueBehavior.RetainValueAndFocus
        Me.grdOrdreLinjer.DisplayLayout.Override.MultiCellSelectionMode = Infragistics.Win.UltraWinGrid.MultiCellSelectionMode.Standard
        Me.grdOrdreLinjer.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdOrdreLinjer.DisplayLayout.Override.RowSelectorWidth = 22
        Me.grdOrdreLinjer.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFixed
        Me.grdOrdreLinjer.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdOrdreLinjer.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdOrdreLinjer.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdOrdreLinjer.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdOrdreLinjer.DisplayLayout.Override.SummaryDisplayArea = CType(((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.HideDataRowFooters) _
            Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Me.grdOrdreLinjer.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdOrdreLinjer.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.None
        Me.grdOrdreLinjer.DisplayLayout.Override.TipStyleCell = Infragistics.Win.UltraWinGrid.TipStyle.Show
        Me.grdOrdreLinjer.DisplayLayout.Override.TipStyleHeader = Infragistics.Win.UltraWinGrid.TipStyle.Show
        Me.grdOrdreLinjer.DisplayLayout.Override.TipStyleRowConnector = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdOrdreLinjer.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
        Me.grdOrdreLinjer.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.grdOrdreLinjer.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Both
        Me.grdOrdreLinjer.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdOrdreLinjer.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdOrdreLinjer.DisplayLayout.UseFixedHeaders = True
        Me.grdOrdreLinjer.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grdOrdreLinjer.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdOrdreLinjer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdOrdreLinjer.Location = New System.Drawing.Point(0, 248)
        Me.grdOrdreLinjer.Name = "grdOrdreLinjer"
        Me.grdOrdreLinjer.Size = New System.Drawing.Size(1286, 229)
        Me.grdOrdreLinjer.TabIndex = 20
        Me.grdOrdreLinjer.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnUpdate
        '
        'DataSourceMedieplan
        '
        Me.DataSourceMedieplan.AntalFarver = 0
        Me.DataSourceMedieplan.AntalMm = 100
        Me.DataSourceMedieplan.BrugtGruppeVersion = 0
        Me.DataSourceMedieplan.Is365 = False
        Me.DataSourceMedieplan.MedieplanNr = 0
        Me.DataSourceMedieplan.Placering = 1
        Me.DataSourceMedieplan.Version = 0
        '
        'frmMedieplan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1287, 516)
        Me.Controls.Add(Me.chkVisLåstePriser)
        Me.Controls.Add(Me.picMinMax)
        Me.Controls.Add(Me.grdCC)
        Me.Controls.Add(Me.grdOrdreLinjer)
        Me.Controls.Add(Me.grpMedieplanHoved)
        Me.Controls.Add(Me.btnVisFaktureringsBilag)
        Me.Controls.Add(Me.optGruppering)
        Me.Controls.Add(Me.chkMmSærRabat)
        Me.Controls.Add(Me.btnGenberegn)
        Me.Controls.Add(Me.chkFarveSærRabat)
        Me.Controls.Add(Me.btnTilExcel)
        Me.Controls.Add(Me.btnGenUdsend)
        Me.Controls.Add(Me.lblMedieplanNr)
        Me.Controls.Add(Me.btnDækningskort)
        Me.Controls.Add(Me.btnTilBlade)
        Me.Controls.Add(Me.btnAnnuller)
        Me.Controls.Add(Me.btnTilBooking)
        Me.Controls.Add(Me.picGrøn)
        Me.Controls.Add(Me.picGul)
        Me.Controls.Add(Me.btnUdskriv)
        Me.Controls.Add(Me.lblGruppering)
        Me.Controls.Add(Me.picStatusKode)
        Me.Controls.Add(Me.picRød)
        Me.Controls.Add(Me.picStatus)
        Me.Controls.Add(Me.cboUgebladListe)
        Me.Controls.Add(Me.btnKopierTilNy)
        Me.Controls.Add(Me.btnLuk)
        Me.Controls.Add(Me.btnGem)
        Me.Controls.Add(Me.btnSupportBilag)
        Me.Controls.Add(Me.btnHistorik)
        Me.Controls.Add(Me.btnKommentar)
        Me.Controls.Add(Me.picPipeline)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMedieplan"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.cboUgebladListe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUgeaviserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UgeavisListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIndrykningsUge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDPKulørID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDPKulørBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DPKulørListeDropDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPlaceringID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPlaceringBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaceringListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAnnoncørNO_, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAnnoncørerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnnoncørListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBureauNO_, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBureauerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BureauListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optAntalFarver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRekvisitionsNr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBilagsBladeAtt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBeskrivelse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMedieplanHoved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMedieplanHoved.ResumeLayout(False)
        Me.grpMedieplanHoved.PerformLayout()
        CType(Me.txtHistorik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKommentar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMiljøTillægVises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMiljøTillægOpkræves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkKunForhandlerBundForskellig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMaterialeModtaget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIndrykningsÅr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOverskrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBemærkningTilUgeavis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBemærkningTilAnnoncør, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialeFølgerFraLeverandør, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFællesBureauOrdreNr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optSammeMateriale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBrugMaterialeFraUge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optMaterialeFølgerFra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optBilagsBladeTil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optFakturering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optGruppering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFarveSærRabat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMmSærRabat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVisLåstePriser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrdreLinjer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSourceMedieplan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSourceMedieplan As WinPlanner.dataSourceMedieplan
    Friend WithEvents picPipeline As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents picGul As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents picGrøn As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents picStatus As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents picRød As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Private WithEvents btnKopierTilNy As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnGem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtFormat1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormat2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents optAntalFarver As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents txtBeskrivelse As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRekvisitionsNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtBilagsBladeAtt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents picStatusKode As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents AnnoncørListeDropdown As WinPlanner.AnnoncørListeDropdown
    Friend WithEvents TblAnnoncørerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAnnoncørerTableAdapter As WinPlanner.AnnoncørListeDropdownTableAdapters.tblAnnoncørerTableAdapter
    Friend WithEvents cboBureauNO_ As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboAnnoncørNO_ As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents BureauListeDropdown As WinPlanner.BureauListeDropdown
    Friend WithEvents TblBureauerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblBureauerTableAdapter As WinPlanner.BureauListeDropdownTableAdapters.tblBureauerTableAdapter
    Friend WithEvents lblBureau As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblAnnoncør As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblX As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblFormat As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPlacering As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboPlaceringID As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblAntalFarver As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboDPKulørID As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblDPKulør As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblIndrykningsUge As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numIndrykningsUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblBeskrivelse As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblAtt As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblBilagsbladTil As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblRekvisitionsNr As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grdOrdreLinjer As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cboUgebladListe As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UgeavisListeDropdown As WinPlanner.UgeavisListeDropdown
    Friend WithEvents TblUgeaviserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUgeaviserTableAdapter As WinPlanner.UgeavisListeDropdownTableAdapters.tblUgeaviserTableAdapter
    Friend WithEvents picMinMax As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents grpMedieplanHoved As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtBemærkningTilAnnoncør As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblBemærkningTilAnnoncør As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents optBilagsBladeTil As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblFakturering As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents optFakturering As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblMatFraUge As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents optMaterialeFølgerFra As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblMaterialeFølgerFra As Infragistics.Win.Misc.UltraLabel
    Private WithEvents btnMateriale As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtBrugMaterialeFraUge As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents PlaceringListeDropdown As WinPlanner.PlaceringListeDropdown
    Friend WithEvents TblPlaceringBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPlaceringTableAdapter As WinPlanner.PlaceringListeDropdownTableAdapters.tblPlaceringTableAdapter
    Friend WithEvents optSammeMateriale As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents optGruppering As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblGruppering As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblFællesBureauOrdreNr As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtFællesBureauOrdreNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents DPKulørListeDropDown As WinPlanner.DPKulørListeDropDown
    Friend WithEvents TblDPKulørBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDPKulørTableAdapter As WinPlanner.DPKulørListeDropDownTableAdapters.tblDPKulørTableAdapter
    Friend WithEvents txtMaterialeFølgerFraLeverandør As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ToolTipManager As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Private WithEvents btnUdskriv As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnTilBooking As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Private WithEvents btnTilBlade As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblBemærkningTilUgeavis As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtBemærkningTilUgeavis As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblOverskrift As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtOverskrift As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents btnDækningskort As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSupportBilag As System.Windows.Forms.Button
    Friend WithEvents timerSupportBilag As System.Windows.Forms.Timer
    Friend WithEvents lblIndrykningsÅr As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numIndrykningsÅr As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblMedieplanNr As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents timer365 As System.Windows.Forms.Timer
    Private WithEvents btnGenUdsend As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtHistorik As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents btnTilExcel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ExcelExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents chkFarveSærRabat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnHistorik As System.Windows.Forms.Button
    Private WithEvents btnFakturaBemærkning As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnGenberegn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grdCC As Infragistics.Win.UltraWinGrid.UltraGridColumnChooser
    Friend WithEvents chkMmSærRabat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkMaterialeModtaget As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnVisFaktureringsBilag As System.Windows.Forms.Button
    Friend WithEvents chkKunForhandlerBundForskellig As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkMiljøTillægOpkræves As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkMiljøTillægVises As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents clbMiljøTillægOpkræves As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtKommentar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblKommentar As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnKommentar As System.Windows.Forms.Button
    Friend WithEvents chkVisLåstePriser As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
