<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim panFindMedieplan As System.Windows.Forms.Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim panFindMedieplanBooking As System.Windows.Forms.Panel
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblBladStamdata", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Navn", -1, Nothing, 1, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Oplag")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostBy")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DækningsGrad")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeNavn", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, True)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeSortKey")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HovedGruppeNavn")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HovedGruppeSortKey")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOmrådeNavn")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOmrådeSortKey")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DagNavn")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GruppeNavn")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Navn2")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Adresse")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Adresse2")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tlf")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fax")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CVR")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegionNavn")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegionSortKey")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kontaktperson")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdredeadlineTekst")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdredeadlineRubrik")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialedeadlineTekst")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialedeadlineRubrik")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostNr")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejerforhold")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblFundneplaner", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedieplanNr")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Version")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnnoncørNo_")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BureauNo_")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalFarver")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KonsulentCode")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nr", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Betegnelse")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Format")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AntalUgeaviser")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Beskrivelse")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Overskrift")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RettelserEfterAnnoncekontrol")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalgsAnsvarlig")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OprettetDato")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DockAreaPane1 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedRight, New System.Guid("b2664696-b27a-40be-9f95-e97f5945202e"))
        Dim DockableControlPane1 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("ea4ad265-f5da-4f6b-a432-0e9b94e66803"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("b2664696-b27a-40be-9f95-e97f5945202e"), -1)
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("251d89e7-ee9a-4c39-8bc6-6c3e46366933"))
        Dim DockableControlPane2 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("0a6e6a75-d205-4654-a8ae-bdfd8d1d72a2"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("251d89e7-ee9a-4c39-8bc6-6c3e46366933"), -1)
        Dim DockAreaPane3 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.Floating, New System.Guid("a282e16c-c2b3-4bf8-ad65-18aa87d1182d"))
        Dim DockAreaPane4 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("73267377-eb04-48b6-ad4d-9225f16b46b8"))
        Dim DockableControlPane3 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("98159095-01fc-4aa0-bfe6-342acc8f9c00"), New System.Guid("a282e16c-c2b3-4bf8-ad65-18aa87d1182d"), -1, New System.Guid("73267377-eb04-48b6-ad4d-9225f16b46b8"), 0)
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel2 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("mainmenu")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("File")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Medieplan")
        Dim PopupMenuTool4 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Booking")
        Dim PopupMenuTool5 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Fakturering")
        Dim PopupMenuTool6 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Rapportering")
        Dim PopupMenuTool7 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Administration")
        Dim PopupMenuTool8 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Åbne Vinduer")
        Dim PopupMenuTool9 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("File")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Afslut")
        Dim PopupMenuTool11 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Medieplan")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Opret Medieplan")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Find Medieplan")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Vis Forespørgsler")
        Dim ButtonTool48 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Konkurrent Info")
        Dim PopupMenuTool12 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Booking")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Opret Medieplan Booking")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Find Medieplan Booking")
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Skal Sendes")
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Er Sendt")
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Booking Liste")
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Gen Udsending")
        Dim PopupMenuTool13 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Rapportering")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Annoncør omsætning")
        Dim ButtonTool50 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Bergske afstemning")
        Dim PopupMenuTool14 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Fakturering")
        Dim ButtonTool36 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Find Medieplan Fakturering")
        Dim ButtonTool38 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Mangler Annoncekontrol")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Vis Fejl")
        Dim ButtonTool44 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Vis Åbne Fakturerings Bilag")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Send til Navision")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Fjern overført ordre")
        Dim ButtonTool35 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Skift Status")
        Dim PopupMenuTool15 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Administration")
        Dim ButtonTool46 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ugeavis Stamdata")
        Dim ButtonTool54 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Kontakter")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Send til Web")
        Dim ButtonTool40 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Rabatformer")
        Dim ButtonTool52 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Miljøtillæg")
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Om Lokalplanner")
        Dim ButtonTool56 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("OpdateringsTekst")
        Dim ButtonTool59 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Slet Filer")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Afslut")
        Dim PopupMenuTool16 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Åbne Vinduer")
        Dim MdiWindowListTool1 As Infragistics.Win.UltraWinToolbars.MdiWindowListTool = New Infragistics.Win.UltraWinToolbars.MdiWindowListTool("MDIVinduer")
        Dim MdiWindowListTool2 As Infragistics.Win.UltraWinToolbars.MdiWindowListTool = New Infragistics.Win.UltraWinToolbars.MdiWindowListTool("MDIVinduer")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Opret Medieplan")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Find Medieplan")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Opret Medieplan Booking")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Find Medieplan Booking")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Vis Fejl")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Oversigt")
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Send til Navision")
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Udsending")
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Gen Udsending")
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Skal Sendes")
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Er Sendt")
        Dim ButtonTool30 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Om Lokalplanner")
        Dim ButtonTool33 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Booking Liste")
        Dim ButtonTool37 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Avis Grupper")
        Dim ButtonTool39 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Mangler Annoncekontrol")
        Dim ButtonTool41 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Rabatformer")
        Dim ButtonTool42 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Find Medieplan Fakturering")
        Dim ButtonTool47 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Ugeavis Stamdata")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Vis Forespørgsler")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Annoncør omsætning")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Send til Web")
        Dim ButtonTool34 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Fjern overført ordre")
        Dim ButtonTool43 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Skift Status")
        Dim ButtonTool45 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Vis Åbne Fakturerings Bilag")
        Dim ButtonTool49 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Konkurrent Info")
        Dim ButtonTool51 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Bergske afstemning")
        Dim ButtonTool53 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Miljøtillæg")
        Dim ButtonTool55 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Se ændringer")
        Dim ButtonTool57 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("OpdateringsTekst")
        Dim ButtonTool58 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Kontakter")
        Dim ButtonTool60 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Slet Filer")
        Me.chkVisInAktive = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkMedtagRettelser = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lblMedtagVersion = New Infragistics.Win.Misc.UltraLabel()
        Me.chkFakturering = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkBooking = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkMedieplan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtKonsulent = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblKonsulent = New Infragistics.Win.Misc.UltraLabel()
        Me.numTilUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.numFraUge = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblTilUge = New Infragistics.Win.Misc.UltraLabel()
        Me.lblFraUge = New Infragistics.Win.Misc.UltraLabel()
        Me.lblÅr = New Infragistics.Win.Misc.UltraLabel()
        Me.numÅr = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.cboBureau = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TblBureauerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BureauListeDropdown = New WinPlanner.BureauListeDropdown()
        Me.cboAnnoncør = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TblAnnoncørerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnnoncørListeDropdown = New WinPlanner.AnnoncørListeDropdown()
        Me.lblBureau = New Infragistics.Win.Misc.UltraLabel()
        Me.picPipeline = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.btnFind = New Infragistics.Win.Misc.UltraButton()
        Me.txtMedieplanNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblAnnoncør = New Infragistics.Win.Misc.UltraLabel()
        Me.lblMedieplanNr = New Infragistics.Win.Misc.UltraLabel()
        Me.chkVisInAktiveBooking = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkMedtagRettelserBooking = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lblMedtagVersionerBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.chkFaktureringBooking = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkBookingBooking = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkMedieplanBooking = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtKonsulentBooking = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblKonsulentBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.btnFindBooking = New Infragistics.Win.Misc.UltraButton()
        Me.numTilUgeBooking = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.numFraUgeBooking = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblTilUgeBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.lblFraUgeBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.lblÅrBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.numÅrBooking = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.cboBureauBooking = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboAnnoncørBooking = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblUgeavisBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.cboUgeavisBooking = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TblUgeaviserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UgeavisListeDropdown = New WinPlanner.UgeavisListeDropdown()
        Me.lblBureauBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.picPipelineBooking = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.txtMedieplanNrBooking = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtBureauordreNrBooking = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblBureauordreNrBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.lblAnnoncørBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.lblMedieplanNrBooking = New Infragistics.Win.Misc.UltraLabel()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.btnTilExcel = New Infragistics.Win.Misc.UltraButton()
        Me.btnGrupper = New Infragistics.Win.Misc.UltraButton()
        Me.btnFindUgeavis = New Infragistics.Win.Misc.UltraButton()
        Me.txtPostBy = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblVælgByer = New Infragistics.Win.Misc.UltraLabel()
        Me.numDækningsGrad = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblDækningsgrad = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPostNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblPostNr = New Infragistics.Win.Misc.UltraLabel()
        Me.chkMedtagOphørte = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.grdFindUgeavis = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.btnOverførBlade = New Infragistics.Win.Misc.UltraButton()
        Me.grdFundnePlaner = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TblFundneplanerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstFindMedieplaner = New WinPlanner.dstFindMedieplaner()
        Me.dockManager = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._frmMainUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._frmMainUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._frmMainUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._frmMainUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._frmMainAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.DockableWindow4 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.DockableWindow2 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.DockableWindow3 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.AppStylist = New Infragistics.Win.AppStyling.Runtime.AppStylistRuntime(Me.components)
        Me.statusBar = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        Me.timerOmsætning = New System.Windows.Forms.Timer(Me.components)
        Me.ExcelExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me._frmMain_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.toolbarManager = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmMain_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmMain_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmMain_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.TblAnnoncørerTableAdapter = New WinPlanner.AnnoncørListeDropdownTableAdapters.tblAnnoncørerTableAdapter()
        Me.TblUgeaviserTableAdapter = New WinPlanner.UgeavisListeDropdownTableAdapters.tblUgeaviserTableAdapter()
        Me.TblFundneplanerTableAdapter = New WinPlanner.dstFindMedieplanerTableAdapters.tblFundneplanerTableAdapter()
        Me.TblBureauerTableAdapter = New WinPlanner.BureauListeDropdownTableAdapters.tblBureauerTableAdapter()
        Me.WindowDockingArea6 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.WindowDockingArea5 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.WindowDockingArea2 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DiMPdotNetDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiMPdotNetDataSet = New WinPlanner.DiMPdotNetDataSet()
        Me.WindowDockingArea4 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.TblBladStamdataTableAdapter = New WinPlanner.DiMPdotNetDataSetTableAdapters.tblBladStamdataTableAdapter()
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow()
        panFindMedieplan = New System.Windows.Forms.Panel()
        panFindMedieplanBooking = New System.Windows.Forms.Panel()
        panFindMedieplan.SuspendLayout()
        CType(Me.chkVisInAktive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedtagRettelser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFakturering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedieplan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKonsulent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numÅr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBureau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBureauerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BureauListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAnnoncør, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAnnoncørerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnnoncørListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedieplanNr, System.ComponentModel.ISupportInitialize).BeginInit()
        panFindMedieplanBooking.SuspendLayout()
        CType(Me.chkVisInAktiveBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedtagRettelserBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFaktureringBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBookingBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedieplanBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKonsulentBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTilUgeBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFraUgeBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numÅrBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBureauBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAnnoncørBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUgeavisBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUgeaviserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UgeavisListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedieplanNrBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBureauordreNrBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        CType(Me.txtPostBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDækningsGrad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostNr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedtagOphørte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFindUgeavis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFundnePlaner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFundneplanerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstFindMedieplaner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._frmMainAutoHideControl.SuspendLayout()
        Me.DockableWindow2.SuspendLayout()
        Me.DockableWindow3.SuspendLayout()
        CType(Me.statusBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toolbarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiMPdotNetDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiMPdotNetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockableWindow1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panFindMedieplan
        '
        panFindMedieplan.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        panFindMedieplan.Controls.Add(Me.chkVisInAktive)
        panFindMedieplan.Controls.Add(Me.chkMedtagRettelser)
        panFindMedieplan.Controls.Add(Me.lblMedtagVersion)
        panFindMedieplan.Controls.Add(Me.chkFakturering)
        panFindMedieplan.Controls.Add(Me.chkBooking)
        panFindMedieplan.Controls.Add(Me.chkMedieplan)
        panFindMedieplan.Controls.Add(Me.txtKonsulent)
        panFindMedieplan.Controls.Add(Me.lblKonsulent)
        panFindMedieplan.Controls.Add(Me.numTilUge)
        panFindMedieplan.Controls.Add(Me.numFraUge)
        panFindMedieplan.Controls.Add(Me.lblTilUge)
        panFindMedieplan.Controls.Add(Me.lblFraUge)
        panFindMedieplan.Controls.Add(Me.lblÅr)
        panFindMedieplan.Controls.Add(Me.numÅr)
        panFindMedieplan.Controls.Add(Me.cboBureau)
        panFindMedieplan.Controls.Add(Me.cboAnnoncør)
        panFindMedieplan.Controls.Add(Me.lblBureau)
        panFindMedieplan.Controls.Add(Me.picPipeline)
        panFindMedieplan.Controls.Add(Me.btnFind)
        panFindMedieplan.Controls.Add(Me.txtMedieplanNr)
        panFindMedieplan.Controls.Add(Me.lblAnnoncør)
        panFindMedieplan.Controls.Add(Me.lblMedieplanNr)
        panFindMedieplan.Dock = System.Windows.Forms.DockStyle.Fill
        panFindMedieplan.Location = New System.Drawing.Point(0, 18)
        panFindMedieplan.Name = "panFindMedieplan"
        panFindMedieplan.Size = New System.Drawing.Size(993, 82)
        panFindMedieplan.TabIndex = 44
        '
        'chkVisInAktive
        '
        Me.chkVisInAktive.Location = New System.Drawing.Point(518, 64)
        Me.chkVisInAktive.Name = "chkVisInAktive"
        Me.chkVisInAktive.Size = New System.Drawing.Size(177, 15)
        Me.chkVisInAktive.TabIndex = 352
        Me.chkVisInAktive.Text = "Vís InAktive Annoncører"
        '
        'chkMedtagRettelser
        '
        Me.chkMedtagRettelser.Checked = True
        Me.chkMedtagRettelser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMedtagRettelser.Location = New System.Drawing.Point(787, 45)
        Me.chkMedtagRettelser.Name = "chkMedtagRettelser"
        Me.chkMedtagRettelser.Size = New System.Drawing.Size(98, 15)
        Me.chkMedtagRettelser.TabIndex = 351
        Me.chkMedtagRettelser.Text = "+ ret fra AK"
        '
        'lblMedtagVersion
        '
        Me.lblMedtagVersion.AutoSize = True
        Me.lblMedtagVersion.Location = New System.Drawing.Point(711, 5)
        Me.lblMedtagVersion.Name = "lblMedtagVersion"
        Me.lblMedtagVersion.Size = New System.Drawing.Size(103, 15)
        Me.lblMedtagVersion.TabIndex = 350
        Me.lblMedtagVersion.Text = "Medtag versioner"
        '
        'chkFakturering
        '
        Me.chkFakturering.Checked = True
        Me.chkFakturering.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFakturering.Location = New System.Drawing.Point(711, 64)
        Me.chkFakturering.Name = "chkFakturering"
        Me.chkFakturering.Size = New System.Drawing.Size(92, 15)
        Me.chkFakturering.TabIndex = 349
        Me.chkFakturering.Text = "Fakturering"
        '
        'chkBooking
        '
        Me.chkBooking.Checked = True
        Me.chkBooking.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBooking.Location = New System.Drawing.Point(711, 45)
        Me.chkBooking.Name = "chkBooking"
        Me.chkBooking.Size = New System.Drawing.Size(70, 15)
        Me.chkBooking.TabIndex = 348
        Me.chkBooking.Text = "Booking"
        '
        'chkMedieplan
        '
        Me.chkMedieplan.Checked = True
        Me.chkMedieplan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMedieplan.Location = New System.Drawing.Point(711, 26)
        Me.chkMedieplan.Name = "chkMedieplan"
        Me.chkMedieplan.Size = New System.Drawing.Size(85, 15)
        Me.chkMedieplan.TabIndex = 347
        Me.chkMedieplan.Text = "Medieplan"
        '
        'txtKonsulent
        '
        Me.txtKonsulent.Location = New System.Drawing.Point(101, 32)
        Me.txtKonsulent.Name = "txtKonsulent"
        Me.txtKonsulent.NullText = "- init. -"
        Me.txtKonsulent.Size = New System.Drawing.Size(68, 22)
        Me.txtKonsulent.TabIndex = 344
        Me.txtKonsulent.WordWrap = False
        '
        'lblKonsulent
        '
        Me.lblKonsulent.AutoSize = True
        Me.lblKonsulent.Location = New System.Drawing.Point(30, 36)
        Me.lblKonsulent.Name = "lblKonsulent"
        Me.lblKonsulent.Size = New System.Drawing.Size(61, 15)
        Me.lblKonsulent.TabIndex = 343
        Me.lblKonsulent.Text = "Konsulent"
        '
        'numTilUge
        '
        Me.numTilUge.Location = New System.Drawing.Point(637, 5)
        Me.numTilUge.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numTilUge.MaskInput = "nn"
        Me.numTilUge.MaxValue = 54
        Me.numTilUge.MinValue = 1
        Me.numTilUge.Name = "numTilUge"
        Me.numTilUge.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numTilUge.Size = New System.Drawing.Size(58, 22)
        Me.numTilUge.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numTilUge.SpinWrap = True
        Me.numTilUge.TabIndex = 5
        Me.numTilUge.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numTilUge.Value = 1
        '
        'numFraUge
        '
        Me.numFraUge.Location = New System.Drawing.Point(570, 5)
        Me.numFraUge.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numFraUge.MaskInput = "nn"
        Me.numFraUge.MaxValue = 53
        Me.numFraUge.MinValue = 1
        Me.numFraUge.Name = "numFraUge"
        Me.numFraUge.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numFraUge.Size = New System.Drawing.Size(58, 22)
        Me.numFraUge.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numFraUge.SpinWrap = True
        Me.numFraUge.TabIndex = 4
        Me.numFraUge.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numFraUge.Value = 1
        '
        'lblTilUge
        '
        Me.lblTilUge.AutoSize = True
        Me.lblTilUge.Location = New System.Drawing.Point(626, 3)
        Me.lblTilUge.Name = "lblTilUge"
        Me.lblTilUge.Size = New System.Drawing.Size(11, 15)
        Me.lblTilUge.TabIndex = 7
        Me.lblTilUge.Text = "_"
        '
        'lblFraUge
        '
        Me.lblFraUge.AutoSize = True
        Me.lblFraUge.Location = New System.Drawing.Point(518, 9)
        Me.lblFraUge.Name = "lblFraUge"
        Me.lblFraUge.Size = New System.Drawing.Size(47, 15)
        Me.lblFraUge.TabIndex = 5
        Me.lblFraUge.Text = "Fra uge"
        '
        'lblÅr
        '
        Me.lblÅr.AutoSize = True
        Me.lblÅr.Location = New System.Drawing.Point(525, 36)
        Me.lblÅr.Name = "lblÅr"
        Me.lblÅr.Size = New System.Drawing.Size(37, 15)
        Me.lblÅr.TabIndex = 342
        Me.lblÅr.Text = "Årstal"
        '
        'numÅr
        '
        Me.numÅr.Location = New System.Drawing.Point(570, 32)
        Me.numÅr.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numÅr.MaskInput = "nnnn"
        Me.numÅr.MaxValue = 2020
        Me.numÅr.MinValue = 1996
        Me.numÅr.Name = "numÅr"
        Me.numÅr.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numÅr.Size = New System.Drawing.Size(68, 22)
        Me.numÅr.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numÅr.SpinWrap = True
        Me.numÅr.TabIndex = 341
        Me.numÅr.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numÅr.Value = 2007
        '
        'cboBureau
        '
        Me.cboBureau.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBureau.DataSource = Me.TblBureauerBindingSource
        Me.cboBureau.DisplayMember = "Annoncør"
        Me.cboBureau.Location = New System.Drawing.Point(257, 32)
        Me.cboBureau.Name = "cboBureau"
        Me.cboBureau.NullText = "- Vælg bureau -"
        Me.cboBureau.ShowOverflowIndicator = True
        Me.cboBureau.Size = New System.Drawing.Size(237, 22)
        Me.cboBureau.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboBureau.TabIndex = 3
        Me.cboBureau.ValueMember = "AnnoncørID"
        '
        'TblBureauerBindingSource
        '
        Me.TblBureauerBindingSource.AllowNew = True
        Me.TblBureauerBindingSource.DataMember = "tblBureauer"
        Me.TblBureauerBindingSource.DataSource = Me.BureauListeDropdown
        '
        'BureauListeDropdown
        '
        Me.BureauListeDropdown.DataSetName = "BureauListeDropdown"
        Me.BureauListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboAnnoncør
        '
        Me.cboAnnoncør.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAnnoncør.DataSource = Me.TblAnnoncørerBindingSource
        Me.cboAnnoncør.DisplayMember = "Annoncør"
        Me.cboAnnoncør.Location = New System.Drawing.Point(257, 5)
        Me.cboAnnoncør.Name = "cboAnnoncør"
        Me.cboAnnoncør.NullText = "- Vælg annoncør -"
        Me.cboAnnoncør.ShowOverflowIndicator = True
        Me.cboAnnoncør.Size = New System.Drawing.Size(237, 22)
        Me.cboAnnoncør.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboAnnoncør.TabIndex = 2
        Me.cboAnnoncør.ValueMember = "AnnoncørID"
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
        'lblBureau
        '
        Me.lblBureau.AutoSize = True
        Me.lblBureau.Location = New System.Drawing.Point(202, 36)
        Me.lblBureau.Name = "lblBureau"
        Me.lblBureau.Size = New System.Drawing.Size(45, 15)
        Me.lblBureau.TabIndex = 328
        Me.lblBureau.Text = "Bureau"
        '
        'picPipeline
        '
        Me.picPipeline.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPipeline.AutoSize = True
        Me.picPipeline.BorderShadowColor = System.Drawing.Color.Empty
        Me.picPipeline.Image = CType(resources.GetObject("picPipeline.Image"), Object)
        Me.picPipeline.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.picPipeline.Location = New System.Drawing.Point(820, 1)
        Me.picPipeline.Name = "picPipeline"
        Me.picPipeline.ScaleImage = Infragistics.Win.ScaleImage.Never
        Me.picPipeline.Size = New System.Drawing.Size(145, 26)
        Me.picPipeline.TabIndex = 327
        '
        'btnFind
        '
        Me.btnFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFind.Location = New System.Drawing.Point(868, 59)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.ShowFocusRect = False
        Me.btnFind.ShowOutline = False
        Me.btnFind.Size = New System.Drawing.Size(97, 23)
        Me.btnFind.TabIndex = 24
        Me.btnFind.Text = "Find"
        Me.btnFind.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'txtMedieplanNr
        '
        Me.txtMedieplanNr.Location = New System.Drawing.Point(101, 5)
        Me.txtMedieplanNr.Name = "txtMedieplanNr"
        Me.txtMedieplanNr.NullText = "- nr -"
        Me.txtMedieplanNr.Size = New System.Drawing.Size(68, 22)
        Me.txtMedieplanNr.TabIndex = 0
        Me.txtMedieplanNr.WordWrap = False
        '
        'lblAnnoncør
        '
        Me.lblAnnoncør.AutoSize = True
        Me.lblAnnoncør.Location = New System.Drawing.Point(188, 9)
        Me.lblAnnoncør.Name = "lblAnnoncør"
        Me.lblAnnoncør.Size = New System.Drawing.Size(58, 15)
        Me.lblAnnoncør.TabIndex = 2
        Me.lblAnnoncør.Text = "Annoncør"
        '
        'lblMedieplanNr
        '
        Me.lblMedieplanNr.AutoSize = True
        Me.lblMedieplanNr.Location = New System.Drawing.Point(13, 9)
        Me.lblMedieplanNr.Name = "lblMedieplanNr"
        Me.lblMedieplanNr.Size = New System.Drawing.Size(78, 15)
        Me.lblMedieplanNr.TabIndex = 1
        Me.lblMedieplanNr.Text = "Medieplan nr"
        '
        'panFindMedieplanBooking
        '
        panFindMedieplanBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        panFindMedieplanBooking.Controls.Add(Me.chkVisInAktiveBooking)
        panFindMedieplanBooking.Controls.Add(Me.chkMedtagRettelserBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblMedtagVersionerBooking)
        panFindMedieplanBooking.Controls.Add(Me.chkFaktureringBooking)
        panFindMedieplanBooking.Controls.Add(Me.chkBookingBooking)
        panFindMedieplanBooking.Controls.Add(Me.chkMedieplanBooking)
        panFindMedieplanBooking.Controls.Add(Me.txtKonsulentBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblKonsulentBooking)
        panFindMedieplanBooking.Controls.Add(Me.btnFindBooking)
        panFindMedieplanBooking.Controls.Add(Me.numTilUgeBooking)
        panFindMedieplanBooking.Controls.Add(Me.numFraUgeBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblTilUgeBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblFraUgeBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblÅrBooking)
        panFindMedieplanBooking.Controls.Add(Me.numÅrBooking)
        panFindMedieplanBooking.Controls.Add(Me.cboBureauBooking)
        panFindMedieplanBooking.Controls.Add(Me.cboAnnoncørBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblUgeavisBooking)
        panFindMedieplanBooking.Controls.Add(Me.cboUgeavisBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblBureauBooking)
        panFindMedieplanBooking.Controls.Add(Me.picPipelineBooking)
        panFindMedieplanBooking.Controls.Add(Me.txtMedieplanNrBooking)
        panFindMedieplanBooking.Controls.Add(Me.txtBureauordreNrBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblBureauordreNrBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblAnnoncørBooking)
        panFindMedieplanBooking.Controls.Add(Me.lblMedieplanNrBooking)
        panFindMedieplanBooking.Location = New System.Drawing.Point(0, 246)
        panFindMedieplanBooking.Name = "panFindMedieplanBooking"
        panFindMedieplanBooking.Size = New System.Drawing.Size(987, 82)
        panFindMedieplanBooking.TabIndex = 0
        panFindMedieplanBooking.Visible = False
        '
        'chkVisInAktiveBooking
        '
        Me.chkVisInAktiveBooking.Location = New System.Drawing.Point(560, 64)
        Me.chkVisInAktiveBooking.Name = "chkVisInAktiveBooking"
        Me.chkVisInAktiveBooking.Size = New System.Drawing.Size(177, 15)
        Me.chkVisInAktiveBooking.TabIndex = 356
        Me.chkVisInAktiveBooking.Text = "Vís InAktive Annoncører"
        '
        'chkMedtagRettelserBooking
        '
        Me.chkMedtagRettelserBooking.Checked = True
        Me.chkMedtagRettelserBooking.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMedtagRettelserBooking.Location = New System.Drawing.Point(828, 45)
        Me.chkMedtagRettelserBooking.Name = "chkMedtagRettelserBooking"
        Me.chkMedtagRettelserBooking.Size = New System.Drawing.Size(98, 15)
        Me.chkMedtagRettelserBooking.TabIndex = 355
        Me.chkMedtagRettelserBooking.Text = "+ ret fra AK"
        '
        'lblMedtagVersionerBooking
        '
        Me.lblMedtagVersionerBooking.AutoSize = True
        Me.lblMedtagVersionerBooking.Location = New System.Drawing.Point(752, 5)
        Me.lblMedtagVersionerBooking.Name = "lblMedtagVersionerBooking"
        Me.lblMedtagVersionerBooking.Size = New System.Drawing.Size(103, 15)
        Me.lblMedtagVersionerBooking.TabIndex = 354
        Me.lblMedtagVersionerBooking.Text = "Medtag versioner"
        '
        'chkFaktureringBooking
        '
        Me.chkFaktureringBooking.Checked = True
        Me.chkFaktureringBooking.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFaktureringBooking.Location = New System.Drawing.Point(752, 64)
        Me.chkFaktureringBooking.Name = "chkFaktureringBooking"
        Me.chkFaktureringBooking.Size = New System.Drawing.Size(92, 15)
        Me.chkFaktureringBooking.TabIndex = 353
        Me.chkFaktureringBooking.Text = "Fakturering"
        '
        'chkBookingBooking
        '
        Me.chkBookingBooking.Checked = True
        Me.chkBookingBooking.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBookingBooking.Location = New System.Drawing.Point(752, 45)
        Me.chkBookingBooking.Name = "chkBookingBooking"
        Me.chkBookingBooking.Size = New System.Drawing.Size(70, 15)
        Me.chkBookingBooking.TabIndex = 352
        Me.chkBookingBooking.Text = "Booking"
        '
        'chkMedieplanBooking
        '
        Me.chkMedieplanBooking.Checked = True
        Me.chkMedieplanBooking.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMedieplanBooking.Location = New System.Drawing.Point(752, 26)
        Me.chkMedieplanBooking.Name = "chkMedieplanBooking"
        Me.chkMedieplanBooking.Size = New System.Drawing.Size(85, 15)
        Me.chkMedieplanBooking.TabIndex = 351
        Me.chkMedieplanBooking.Text = "Medieplan"
        '
        'txtKonsulentBooking
        '
        Me.txtKonsulentBooking.Location = New System.Drawing.Point(101, 59)
        Me.txtKonsulentBooking.Name = "txtKonsulentBooking"
        Me.txtKonsulentBooking.NullText = "- init. -"
        Me.txtKonsulentBooking.Size = New System.Drawing.Size(68, 22)
        Me.txtKonsulentBooking.TabIndex = 346
        Me.txtKonsulentBooking.WordWrap = False
        '
        'lblKonsulentBooking
        '
        Me.lblKonsulentBooking.AutoSize = True
        Me.lblKonsulentBooking.Location = New System.Drawing.Point(30, 63)
        Me.lblKonsulentBooking.Name = "lblKonsulentBooking"
        Me.lblKonsulentBooking.Size = New System.Drawing.Size(61, 15)
        Me.lblKonsulentBooking.TabIndex = 345
        Me.lblKonsulentBooking.Text = "Konsulent"
        '
        'btnFindBooking
        '
        Me.btnFindBooking.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindBooking.Location = New System.Drawing.Point(864, 59)
        Me.btnFindBooking.Name = "btnFindBooking"
        Me.btnFindBooking.ShowFocusRect = False
        Me.btnFindBooking.ShowOutline = False
        Me.btnFindBooking.Size = New System.Drawing.Size(97, 22)
        Me.btnFindBooking.TabIndex = 18
        Me.btnFindBooking.Text = "Find"
        Me.btnFindBooking.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'numTilUgeBooking
        '
        Me.numTilUgeBooking.Location = New System.Drawing.Point(679, 5)
        Me.numTilUgeBooking.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numTilUgeBooking.MaskInput = "nn"
        Me.numTilUgeBooking.MaxValue = 54
        Me.numTilUgeBooking.MinValue = 1
        Me.numTilUgeBooking.Name = "numTilUgeBooking"
        Me.numTilUgeBooking.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numTilUgeBooking.Size = New System.Drawing.Size(58, 22)
        Me.numTilUgeBooking.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numTilUgeBooking.SpinWrap = True
        Me.numTilUgeBooking.TabIndex = 13
        Me.numTilUgeBooking.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numTilUgeBooking.Value = 1
        '
        'numFraUgeBooking
        '
        Me.numFraUgeBooking.Location = New System.Drawing.Point(612, 5)
        Me.numFraUgeBooking.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numFraUgeBooking.MaskInput = "nn"
        Me.numFraUgeBooking.MaxValue = 53
        Me.numFraUgeBooking.MinValue = 1
        Me.numFraUgeBooking.Name = "numFraUgeBooking"
        Me.numFraUgeBooking.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numFraUgeBooking.Size = New System.Drawing.Size(58, 22)
        Me.numFraUgeBooking.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numFraUgeBooking.SpinWrap = True
        Me.numFraUgeBooking.TabIndex = 11
        Me.numFraUgeBooking.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numFraUgeBooking.Value = 1
        '
        'lblTilUgeBooking
        '
        Me.lblTilUgeBooking.AutoSize = True
        Me.lblTilUgeBooking.Location = New System.Drawing.Point(668, 3)
        Me.lblTilUgeBooking.Name = "lblTilUgeBooking"
        Me.lblTilUgeBooking.Size = New System.Drawing.Size(11, 15)
        Me.lblTilUgeBooking.TabIndex = 12
        Me.lblTilUgeBooking.Text = "_"
        '
        'lblFraUgeBooking
        '
        Me.lblFraUgeBooking.AutoSize = True
        Me.lblFraUgeBooking.Location = New System.Drawing.Point(560, 9)
        Me.lblFraUgeBooking.Name = "lblFraUgeBooking"
        Me.lblFraUgeBooking.Size = New System.Drawing.Size(47, 15)
        Me.lblFraUgeBooking.TabIndex = 10
        Me.lblFraUgeBooking.Text = "Fra uge"
        '
        'lblÅrBooking
        '
        Me.lblÅrBooking.AutoSize = True
        Me.lblÅrBooking.Location = New System.Drawing.Point(567, 36)
        Me.lblÅrBooking.Name = "lblÅrBooking"
        Me.lblÅrBooking.Size = New System.Drawing.Size(37, 15)
        Me.lblÅrBooking.TabIndex = 14
        Me.lblÅrBooking.Text = "Årstal"
        '
        'numÅrBooking
        '
        Me.numÅrBooking.Location = New System.Drawing.Point(612, 32)
        Me.numÅrBooking.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numÅrBooking.MaskInput = "nnnn"
        Me.numÅrBooking.MaxValue = 2020
        Me.numÅrBooking.MinValue = 1996
        Me.numÅrBooking.Name = "numÅrBooking"
        Me.numÅrBooking.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numÅrBooking.Size = New System.Drawing.Size(68, 22)
        Me.numÅrBooking.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numÅrBooking.SpinWrap = True
        Me.numÅrBooking.TabIndex = 15
        Me.numÅrBooking.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numÅrBooking.Value = 2007
        '
        'cboBureauBooking
        '
        Me.cboBureauBooking.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBureauBooking.DataSource = Me.TblBureauerBindingSource
        Me.cboBureauBooking.DisplayMember = "Annoncør"
        Me.cboBureauBooking.Location = New System.Drawing.Point(320, 32)
        Me.cboBureauBooking.Name = "cboBureauBooking"
        Me.cboBureauBooking.NullText = "- Vælg bureau -"
        Me.cboBureauBooking.ShowOverflowIndicator = True
        Me.cboBureauBooking.Size = New System.Drawing.Size(232, 22)
        Me.cboBureauBooking.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboBureauBooking.TabIndex = 5
        Me.cboBureauBooking.ValueMember = "AnnoncørID"
        '
        'cboAnnoncørBooking
        '
        Me.cboAnnoncørBooking.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAnnoncørBooking.DataSource = Me.TblAnnoncørerBindingSource
        Me.cboAnnoncørBooking.DisplayMember = "Annoncør"
        Me.cboAnnoncørBooking.Location = New System.Drawing.Point(320, 5)
        Me.cboAnnoncørBooking.Name = "cboAnnoncørBooking"
        Me.cboAnnoncørBooking.NullText = "- Vælg annoncør -"
        Me.cboAnnoncørBooking.Size = New System.Drawing.Size(232, 22)
        Me.cboAnnoncørBooking.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboAnnoncørBooking.TabIndex = 3
        Me.cboAnnoncørBooking.ValueMember = "AnnoncørID"
        '
        'lblUgeavisBooking
        '
        Me.lblUgeavisBooking.AutoSize = True
        Me.lblUgeavisBooking.Location = New System.Drawing.Point(258, 63)
        Me.lblUgeavisBooking.Name = "lblUgeavisBooking"
        Me.lblUgeavisBooking.Size = New System.Drawing.Size(49, 15)
        Me.lblUgeavisBooking.TabIndex = 8
        Me.lblUgeavisBooking.Text = "Ugeavis"
        '
        'cboUgeavisBooking
        '
        Me.cboUgeavisBooking.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboUgeavisBooking.DataSource = Me.TblUgeaviserBindingSource
        Me.cboUgeavisBooking.DisplayMember = "Navn"
        Me.cboUgeavisBooking.Location = New System.Drawing.Point(320, 59)
        Me.cboUgeavisBooking.Name = "cboUgeavisBooking"
        Me.cboUgeavisBooking.NullText = "- Vælg ugeavis -"
        Me.cboUgeavisBooking.ShowOverflowIndicator = True
        Me.cboUgeavisBooking.Size = New System.Drawing.Size(169, 22)
        Me.cboUgeavisBooking.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboUgeavisBooking.TabIndex = 9
        Me.cboUgeavisBooking.ValueMember = "BladID"
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
        'lblBureauBooking
        '
        Me.lblBureauBooking.AutoSize = True
        Me.lblBureauBooking.Location = New System.Drawing.Point(258, 36)
        Me.lblBureauBooking.Name = "lblBureauBooking"
        Me.lblBureauBooking.Size = New System.Drawing.Size(45, 15)
        Me.lblBureauBooking.TabIndex = 4
        Me.lblBureauBooking.Text = "Bureau"
        '
        'picPipelineBooking
        '
        Me.picPipelineBooking.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPipelineBooking.AutoSize = True
        Me.picPipelineBooking.BorderShadowColor = System.Drawing.Color.Empty
        Me.picPipelineBooking.Image = CType(resources.GetObject("picPipelineBooking.Image"), Object)
        Me.picPipelineBooking.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.picPipelineBooking.Location = New System.Drawing.Point(816, 3)
        Me.picPipelineBooking.Name = "picPipelineBooking"
        Me.picPipelineBooking.ScaleImage = Infragistics.Win.ScaleImage.Never
        Me.picPipelineBooking.Size = New System.Drawing.Size(145, 26)
        Me.picPipelineBooking.TabIndex = 19
        '
        'txtMedieplanNrBooking
        '
        Me.txtMedieplanNrBooking.Location = New System.Drawing.Point(101, 5)
        Me.txtMedieplanNrBooking.Name = "txtMedieplanNrBooking"
        Me.txtMedieplanNrBooking.NullText = "- nr -"
        Me.txtMedieplanNrBooking.Size = New System.Drawing.Size(68, 22)
        Me.txtMedieplanNrBooking.TabIndex = 1
        Me.txtMedieplanNrBooking.WordWrap = False
        '
        'txtBureauordreNrBooking
        '
        Me.txtBureauordreNrBooking.Location = New System.Drawing.Point(101, 32)
        Me.txtBureauordreNrBooking.Name = "txtBureauordreNrBooking"
        Me.txtBureauordreNrBooking.NullText = " - Bureauordre nr -"
        Me.txtBureauordreNrBooking.Size = New System.Drawing.Size(152, 22)
        Me.txtBureauordreNrBooking.TabIndex = 7
        Me.txtBureauordreNrBooking.WordWrap = False
        '
        'lblBureauordreNrBooking
        '
        Me.lblBureauordreNrBooking.AutoSize = True
        Me.lblBureauordreNrBooking.Location = New System.Drawing.Point(5, 36)
        Me.lblBureauordreNrBooking.Name = "lblBureauordreNrBooking"
        Me.lblBureauordreNrBooking.Size = New System.Drawing.Size(91, 15)
        Me.lblBureauordreNrBooking.TabIndex = 6
        Me.lblBureauordreNrBooking.Text = "Bureauordre nr"
        '
        'lblAnnoncørBooking
        '
        Me.lblAnnoncørBooking.AutoSize = True
        Me.lblAnnoncørBooking.Location = New System.Drawing.Point(258, 9)
        Me.lblAnnoncørBooking.Name = "lblAnnoncørBooking"
        Me.lblAnnoncørBooking.Size = New System.Drawing.Size(58, 15)
        Me.lblAnnoncørBooking.TabIndex = 2
        Me.lblAnnoncørBooking.Text = "Annoncør"
        '
        'lblMedieplanNrBooking
        '
        Me.lblMedieplanNrBooking.AutoSize = True
        Me.lblMedieplanNrBooking.Location = New System.Drawing.Point(5, 9)
        Me.lblMedieplanNrBooking.Name = "lblMedieplanNrBooking"
        Me.lblMedieplanNrBooking.Size = New System.Drawing.Size(78, 15)
        Me.lblMedieplanNrBooking.TabIndex = 0
        Me.lblMedieplanNrBooking.Text = "Medieplan nr"
        '
        'splitContainer
        '
        Me.splitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer.IsSplitterFixed = True
        Me.splitContainer.Location = New System.Drawing.Point(0, 18)
        Me.splitContainer.Name = "splitContainer"
        Me.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer.Panel1
        '
        Me.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.splitContainer.Panel1.Controls.Add(Me.btnTilExcel)
        Me.splitContainer.Panel1.Controls.Add(Me.btnGrupper)
        Me.splitContainer.Panel1.Controls.Add(Me.btnFindUgeavis)
        Me.splitContainer.Panel1.Controls.Add(Me.txtPostBy)
        Me.splitContainer.Panel1.Controls.Add(Me.lblVælgByer)
        Me.splitContainer.Panel1.Controls.Add(Me.numDækningsGrad)
        Me.splitContainer.Panel1.Controls.Add(Me.lblDækningsgrad)
        Me.splitContainer.Panel1.Controls.Add(Me.txtPostNr)
        Me.splitContainer.Panel1.Controls.Add(Me.lblPostNr)
        Me.splitContainer.Panel1.Controls.Add(Me.chkMedtagOphørte)
        Me.splitContainer.Panel1MinSize = 80
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.grdFindUgeavis)
        Me.splitContainer.Panel2.Controls.Add(Me.btnOverførBlade)
        Me.splitContainer.Size = New System.Drawing.Size(326, 651)
        Me.splitContainer.SplitterDistance = 80
        Me.splitContainer.TabIndex = 32
        '
        'btnTilExcel
        '
        Me.btnTilExcel.Location = New System.Drawing.Point(321, 57)
        Me.btnTilExcel.Name = "btnTilExcel"
        Me.btnTilExcel.ShowFocusRect = False
        Me.btnTilExcel.ShowOutline = False
        Me.btnTilExcel.Size = New System.Drawing.Size(66, 22)
        Me.btnTilExcel.TabIndex = 19
        Me.btnTilExcel.Text = "Til Excel"
        Me.btnTilExcel.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnGrupper
        '
        Me.btnGrupper.Location = New System.Drawing.Point(254, 57)
        Me.btnGrupper.Name = "btnGrupper"
        Me.btnGrupper.ShowFocusRect = False
        Me.btnGrupper.ShowOutline = False
        Me.btnGrupper.Size = New System.Drawing.Size(66, 22)
        Me.btnGrupper.TabIndex = 17
        Me.btnGrupper.Text = "Grupper"
        Me.btnGrupper.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnFindUgeavis
        '
        Me.btnFindUgeavis.Location = New System.Drawing.Point(187, 57)
        Me.btnFindUgeavis.Name = "btnFindUgeavis"
        Me.btnFindUgeavis.ShowFocusRect = False
        Me.btnFindUgeavis.ShowOutline = False
        Me.btnFindUgeavis.Size = New System.Drawing.Size(66, 22)
        Me.btnFindUgeavis.TabIndex = 13
        Me.btnFindUgeavis.Text = "Find"
        Me.btnFindUgeavis.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'txtPostBy
        '
        Me.txtPostBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPostBy.Location = New System.Drawing.Point(71, 30)
        Me.txtPostBy.Name = "txtPostBy"
        Me.txtPostBy.NullText = "- Skriv bynavne -"
        Me.txtPostBy.Size = New System.Drawing.Size(12427, 22)
        Me.txtPostBy.TabIndex = 11
        Me.txtPostBy.WordWrap = False
        '
        'lblVælgByer
        '
        Me.lblVælgByer.AutoSize = True
        Me.lblVælgByer.Location = New System.Drawing.Point(3, 34)
        Me.lblVælgByer.Name = "lblVælgByer"
        Me.lblVælgByer.Size = New System.Drawing.Size(58, 15)
        Me.lblVælgByer.TabIndex = 16
        Me.lblVælgByer.Text = "Post byer"
        '
        'numDækningsGrad
        '
        Me.numDækningsGrad.Location = New System.Drawing.Point(101, 57)
        Me.numDækningsGrad.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.numDækningsGrad.MaskInput = "nnn"
        Me.numDækningsGrad.MaxValue = 100
        Me.numDækningsGrad.MinValue = 0
        Me.numDækningsGrad.Name = "numDækningsGrad"
        Me.numDækningsGrad.NullText = "Alle"
        Me.numDækningsGrad.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numDækningsGrad.Size = New System.Drawing.Size(78, 22)
        Me.numDækningsGrad.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numDækningsGrad.TabIndex = 12
        '
        'lblDækningsgrad
        '
        Me.lblDækningsgrad.AutoSize = True
        Me.lblDækningsgrad.Location = New System.Drawing.Point(3, 61)
        Me.lblDækningsgrad.Name = "lblDækningsgrad"
        Me.lblDækningsgrad.Size = New System.Drawing.Size(87, 15)
        Me.lblDækningsgrad.TabIndex = 15
        Me.lblDækningsgrad.Text = "Dækningsgrad"
        '
        'txtPostNr
        '
        Me.txtPostNr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPostNr.Location = New System.Drawing.Point(71, 3)
        Me.txtPostNr.Name = "txtPostNr"
        Me.txtPostNr.NullText = "- Skriv postnr -"
        Me.txtPostNr.Size = New System.Drawing.Size(12427, 22)
        Me.txtPostNr.TabIndex = 10
        Me.txtPostNr.WordWrap = False
        '
        'lblPostNr
        '
        Me.lblPostNr.AutoSize = True
        Me.lblPostNr.Location = New System.Drawing.Point(17, 7)
        Me.lblPostNr.Name = "lblPostNr"
        Me.lblPostNr.Size = New System.Drawing.Size(44, 15)
        Me.lblPostNr.TabIndex = 14
        Me.lblPostNr.Text = "Post nr"
        '
        'chkMedtagOphørte
        '
        Me.chkMedtagOphørte.Location = New System.Drawing.Point(3, 58)
        Me.chkMedtagOphørte.Name = "chkMedtagOphørte"
        Me.chkMedtagOphørte.Size = New System.Drawing.Size(176, 19)
        Me.chkMedtagOphørte.TabIndex = 18
        Me.chkMedtagOphørte.Text = "Medtag ophørte aviser"
        Me.chkMedtagOphørte.Visible = False
        '
        'grdFindUgeavis
        '
        Me.toolbarManager.SetContextMenuUltra(Me.grdFindUgeavis, "Edit")
        Me.grdFindUgeavis.DataMember = "tblBladStamdata"
        Me.grdFindUgeavis.DataSource = Me.DiMPdotNetDataSetBindingSource
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn19.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn19.Header.Caption = "Lokal Ugeavis"
        UltraGridColumn19.Header.Fixed = True
        UltraGridColumn19.Header.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Width = 199
        UltraGridColumn20.Header.VisiblePosition = 9
        UltraGridColumn21.Header.Caption = "Post by"
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn22.Header.Caption = "Dækningsgrad"
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn23.Header.Caption = "Geokode"
        UltraGridColumn23.Header.VisiblePosition = 2
        UltraGridColumn24.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn24.Header.VisiblePosition = 10
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn25.Header.Caption = "DD el. DL"
        UltraGridColumn25.Header.VisiblePosition = 5
        UltraGridColumn25.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn26.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn27.Header.Caption = "Delområde"
        UltraGridColumn27.Header.VisiblePosition = 4
        UltraGridColumn27.Width = 81
        UltraGridColumn28.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn28.Header.VisiblePosition = 12
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn29.Header.Caption = "Ugedag"
        UltraGridColumn29.Header.VisiblePosition = 13
        UltraGridColumn30.Header.Caption = "Faktura Gruppe"
        UltraGridColumn30.Header.VisiblePosition = 14
        UltraGridColumn31.Header.Caption = "Navn 2"
        UltraGridColumn31.Header.VisiblePosition = 15
        UltraGridColumn32.Header.VisiblePosition = 16
        UltraGridColumn33.Header.Caption = "Adresse 2"
        UltraGridColumn33.Header.VisiblePosition = 17
        UltraGridColumn34.Header.VisiblePosition = 18
        UltraGridColumn35.Header.VisiblePosition = 19
        UltraGridColumn36.Header.VisiblePosition = 20
        UltraGridColumn37.Header.Caption = "Region"
        UltraGridColumn37.Header.VisiblePosition = 3
        UltraGridColumn38.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn38.Header.VisiblePosition = 21
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn39.Header.VisiblePosition = 22
        UltraGridColumn40.Header.Caption = "Ordredeadline Tekst"
        UltraGridColumn40.Header.VisiblePosition = 23
        UltraGridColumn41.Header.Caption = "Ordredeadline Rubrik"
        UltraGridColumn41.Header.VisiblePosition = 24
        UltraGridColumn42.Header.Caption = "Materialedeadline Tekst"
        UltraGridColumn42.Header.VisiblePosition = 25
        UltraGridColumn43.Header.Caption = "Materialedeadline Rubrik"
        UltraGridColumn43.Header.VisiblePosition = 26
        UltraGridColumn44.Header.Caption = "Post nr"
        UltraGridColumn44.Header.VisiblePosition = 6
        UltraGridColumn44.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn62.Header.VisiblePosition = 27
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn62})
        UltraGridBand2.IndentationGroupByRow = 0
        UltraGridBand2.IndentationGroupByRowExpansionIndicator = 0
        UltraGridBand2.ScrollTipField = "Navn"
        Me.grdFindUgeavis.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grdFindUgeavis.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdFindUgeavis.DisplayLayout.ClipboardCellDelimiter = "'"
        Me.grdFindUgeavis.DisplayLayout.ClipboardCellSeparator = ";"
        Me.grdFindUgeavis.DisplayLayout.ClipboardRowSeparator = ""
        Me.grdFindUgeavis.DisplayLayout.GroupByBox.Prompt = "Træk en kolonne herop, for at gruppere"
        Me.grdFindUgeavis.DisplayLayout.GroupByBox.Style = Infragistics.Win.UltraWinGrid.GroupByBoxStyle.Compact
        Me.grdFindUgeavis.DisplayLayout.InterBandSpacing = 0
        Me.grdFindUgeavis.DisplayLayout.MaxColScrollRegions = 1
        Me.grdFindUgeavis.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdFindUgeavis.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdFindUgeavis.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdFindUgeavis.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdFindUgeavis.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.WithinBand
        Me.grdFindUgeavis.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grdFindUgeavis.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdFindUgeavis.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdFindUgeavis.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdFindUgeavis.DisplayLayout.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        Me.grdFindUgeavis.DisplayLayout.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        Me.grdFindUgeavis.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grdFindUgeavis.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdFindUgeavis.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.grdFindUgeavis.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BorderColor = System.Drawing.Color.Silver
        Appearance7.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdFindUgeavis.DisplayLayout.Override.CellAppearance = Appearance7
        Me.grdFindUgeavis.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdFindUgeavis.DisplayLayout.Override.CellPadding = 0
        Me.grdFindUgeavis.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.grdFindUgeavis.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.grdFindUgeavis.DisplayLayout.Override.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Edit
        Me.grdFindUgeavis.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grdFindUgeavis.DisplayLayout.Override.FilterOperatorDropDownItems = Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.None
        Me.grdFindUgeavis.DisplayLayout.Override.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden
        Me.grdFindUgeavis.DisplayLayout.Override.FilterRowPrompt = "Indtast søgekriterier i denne linie"
        Me.grdFindUgeavis.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grdFindUgeavis.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
        Me.grdFindUgeavis.DisplayLayout.Override.FixedRowSortOrder = Infragistics.Win.UltraWinGrid.FixedRowSortOrder.Sorted
        Me.grdFindUgeavis.DisplayLayout.Override.FixedRowStyle = Infragistics.Win.UltraWinGrid.FixedRowStyle.Top
        Me.grdFindUgeavis.DisplayLayout.Override.GroupByRowDescriptionMask = "[value] ([count] [count,ugeaviser,ugeavis,ugeaviser])"
        Me.grdFindUgeavis.DisplayLayout.Override.GroupByRowExpansionStyle = Infragistics.Win.UltraWinGrid.GroupByRowExpansionStyle.ExpansionIndicatorAndDoubleClick
        Me.grdFindUgeavis.DisplayLayout.Override.GroupByRowInitialExpansionState = Infragistics.Win.UltraWinGrid.GroupByRowInitialExpansionState.Expanded
        Me.grdFindUgeavis.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdFindUgeavis.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.HideFilteredOutRows
        Me.grdFindUgeavis.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdFindUgeavis.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grdFindUgeavis.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdFindUgeavis.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFixed
        Me.grdFindUgeavis.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdFindUgeavis.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdFindUgeavis.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdFindUgeavis.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdFindUgeavis.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.None
        Me.grdFindUgeavis.DisplayLayout.Override.TipStyleHeader = Infragistics.Win.UltraWinGrid.TipStyle.Show
        Me.grdFindUgeavis.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
        Me.grdFindUgeavis.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdFindUgeavis.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdFindUgeavis.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grdFindUgeavis.DisplayLayout.UseFixedHeaders = True
        Me.grdFindUgeavis.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grdFindUgeavis.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdFindUgeavis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFindUgeavis.Location = New System.Drawing.Point(0, 0)
        Me.grdFindUgeavis.Margin = New System.Windows.Forms.Padding(0)
        Me.grdFindUgeavis.Name = "grdFindUgeavis"
        Me.grdFindUgeavis.Size = New System.Drawing.Size(326, 545)
        Me.grdFindUgeavis.TabIndex = 0
        Me.grdFindUgeavis.Text = "Find Ugeavis"
        Me.grdFindUgeavis.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnUpdate
        '
        'btnOverførBlade
        '
        Me.btnOverførBlade.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOverførBlade.Location = New System.Drawing.Point(0, 545)
        Me.btnOverførBlade.Name = "btnOverførBlade"
        Me.btnOverførBlade.ShowFocusRect = False
        Me.btnOverførBlade.ShowOutline = False
        Me.btnOverførBlade.Size = New System.Drawing.Size(326, 22)
        Me.btnOverførBlade.TabIndex = 17
        Me.btnOverførBlade.Text = "Overfør valgte blade"
        Me.btnOverførBlade.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'grdFundnePlaner
        '
        Me.grdFundnePlaner.DataSource = Me.TblFundneplanerBindingSource
        Me.grdFundnePlaner.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 33
        UltraGridColumn2.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn2.Header.VisiblePosition = 12
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 49
        UltraGridColumn3.Header.Caption = "Annoncør"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.ProportionalResize = True
        UltraGridColumn3.Width = 210
        UltraGridColumn4.Header.Caption = "Bureau"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.ProportionalResize = True
        UltraGridColumn4.Width = 176
        UltraGridColumn5.Header.Caption = "Farver"
        UltraGridColumn5.Header.VisiblePosition = 7
        UltraGridColumn5.ProportionalResize = True
        UltraGridColumn5.Width = 105
        UltraGridColumn6.Header.Caption = "Uge"
        UltraGridColumn6.Header.VisiblePosition = 10
        UltraGridColumn6.ProportionalResize = True
        UltraGridColumn6.Width = 37
        UltraGridColumn7.Header.Caption = "Ordre ansv."
        UltraGridColumn7.Header.VisiblePosition = 9
        UltraGridColumn7.ProportionalResize = True
        UltraGridColumn7.Width = 57
        UltraGridColumn8.Header.VisiblePosition = 11
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.ProportionalResize = True
        UltraGridColumn8.Width = 75
        UltraGridColumn9.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn9.Header.Caption = "Medieplan nr"
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.ProportionalResize = True
        UltraGridColumn9.Width = 104
        UltraGridColumn10.Header.Caption = "Placering"
        UltraGridColumn10.Header.VisiblePosition = 5
        UltraGridColumn10.ProportionalResize = True
        UltraGridColumn10.Width = 62
        UltraGridColumn11.Header.VisiblePosition = 6
        UltraGridColumn11.ProportionalResize = True
        UltraGridColumn11.Width = 77
        UltraGridColumn12.Header.Caption = "Antal aviser"
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.ProportionalResize = True
        UltraGridColumn12.Width = 67
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn15.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Salgs Ansvarlig"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.Header.Caption = "Oprettet Dato"
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.grdFundnePlaner.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdFundnePlaner.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdFundnePlaner.DisplayLayout.ColumnChooserEnabled = Infragistics.Win.DefaultableBoolean.[True]
        Appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.BorderColor = System.Drawing.SystemColors.Window
        Me.grdFundnePlaner.DisplayLayout.GroupByBox.Appearance = Appearance1
        Appearance2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdFundnePlaner.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance2
        Me.grdFundnePlaner.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdFundnePlaner.DisplayLayout.GroupByBox.Hidden = True
        Appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance3.BackColor2 = System.Drawing.SystemColors.Control
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdFundnePlaner.DisplayLayout.GroupByBox.PromptAppearance = Appearance3
        Me.grdFundnePlaner.DisplayLayout.MaxColScrollRegions = 1
        Me.grdFundnePlaner.DisplayLayout.MaxRowScrollRegions = 1
        Me.grdFundnePlaner.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdFundnePlaner.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdFundnePlaner.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdFundnePlaner.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grdFundnePlaner.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdFundnePlaner.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdFundnePlaner.DisplayLayout.Override.CellPadding = 0
        Me.grdFundnePlaner.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdFundnePlaner.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grdFundnePlaner.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFixed
        Me.grdFundnePlaner.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdFundnePlaner.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdFundnePlaner.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdFundnePlaner.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdFundnePlaner.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdFundnePlaner.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdFundnePlaner.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grdFundnePlaner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFundnePlaner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grdFundnePlaner.Location = New System.Drawing.Point(0, 18)
        Me.grdFundnePlaner.Name = "grdFundnePlaner"
        Me.grdFundnePlaner.Size = New System.Drawing.Size(326, 651)
        Me.grdFundnePlaner.TabIndex = 84
        Me.grdFundnePlaner.Text = "Fundne planer"
        Me.grdFundnePlaner.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnUpdate
        '
        'TblFundneplanerBindingSource
        '
        Me.TblFundneplanerBindingSource.DataMember = "tblFundneplaner"
        Me.TblFundneplanerBindingSource.DataSource = Me.DstFindMedieplaner
        '
        'DstFindMedieplaner
        '
        Me.DstFindMedieplaner.DataSetName = "dstFindMedieplaner"
        Me.DstFindMedieplaner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dockManager
        '
        Me.dockManager.AutoHideDelay = 0
        DockAreaPane1.DockedBefore = New System.Guid("251d89e7-ee9a-4c39-8bc6-6c3e46366933")
        DockableControlPane1.Control = Me.splitContainer
        DockableControlPane1.FlyoutSize = New System.Drawing.Size(326, -1)
        DockableControlPane1.Key = "Find Ugeavis"
        DockableControlPane1.OriginalControlBounds = New System.Drawing.Rectangle(424, 240, 150, 100)
        DockableControlPane1.Pinned = False
        DockableControlPane1.Size = New System.Drawing.Size(100, 100)
        DockableControlPane1.Text = "Find Ugeavis"
        DockAreaPane1.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane1})
        DockAreaPane1.Size = New System.Drawing.Size(399, 665)
        DockAreaPane2.DockedBefore = New System.Guid("a282e16c-c2b3-4bf8-ad65-18aa87d1182d")
        DockableControlPane2.Control = panFindMedieplan
        DockableControlPane2.FlyoutSize = New System.Drawing.Size(-1, 100)
        DockableControlPane2.Key = "Find Medieplan"
        DockableControlPane2.OriginalControlBounds = New System.Drawing.Rectangle(423, 23, 412, 188)
        DockableControlPane2.Pinned = False
        DockableControlPane2.Size = New System.Drawing.Size(100, 100)
        DockableControlPane2.Text = "Find medieplan"
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane2})
        DockAreaPane2.Size = New System.Drawing.Size(993, 100)
        DockAreaPane3.DockedBefore = New System.Guid("73267377-eb04-48b6-ad4d-9225f16b46b8")
        DockAreaPane3.SelectedTabIndex = -1
        DockAreaPane3.Size = New System.Drawing.Size(100, 100)
        DockableControlPane3.Control = Me.grdFundnePlaner
        DockableControlPane3.FlyoutSize = New System.Drawing.Size(-1, 119)
        DockableControlPane3.Key = "Fundne Planer"
        DockableControlPane3.OriginalControlBounds = New System.Drawing.Rectangle(161, 449, 688, 166)
        DockableControlPane3.Pinned = False
        DockableControlPane3.Size = New System.Drawing.Size(100, 100)
        DockableControlPane3.Text = "Fundet 0 planer"
        DockAreaPane4.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane3})
        DockAreaPane4.Size = New System.Drawing.Size(993, 181)
        Me.dockManager.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1, DockAreaPane2, DockAreaPane3, DockAreaPane4})
        Me.dockManager.DragWindowStyle = Infragistics.Win.UltraWinDock.DragWindowStyle.LayeredWindowWithIndicators
        Me.dockManager.HostControl = Me
        Me.dockManager.SaveSettings = True
        Me.dockManager.SaveSettingsFormat = Infragistics.Win.SaveSettingsFormat.Xml
        Me.dockManager.SettingsKey = "dockManager"
        Me.dockManager.ShowCloseButton = False
        Me.dockManager.ShowDisabledButtons = False
        Me.dockManager.ShowMenuButton = Infragistics.Win.DefaultableBoolean.[False]
        Me.dockManager.UseDefaultContextMenus = False
        '
        '_frmMainUnpinnedTabAreaLeft
        '
        Me._frmMainUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._frmMainUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 23)
        Me._frmMainUnpinnedTabAreaLeft.Name = "_frmMainUnpinnedTabAreaLeft"
        Me._frmMainUnpinnedTabAreaLeft.Owner = Me.dockManager
        Me._frmMainUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 690)
        Me._frmMainUnpinnedTabAreaLeft.TabIndex = 33
        '
        '_frmMainUnpinnedTabAreaRight
        '
        Me._frmMainUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._frmMainUnpinnedTabAreaRight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainUnpinnedTabAreaRight.Location = New System.Drawing.Point(993, 23)
        Me._frmMainUnpinnedTabAreaRight.Name = "_frmMainUnpinnedTabAreaRight"
        Me._frmMainUnpinnedTabAreaRight.Owner = Me.dockManager
        Me._frmMainUnpinnedTabAreaRight.Size = New System.Drawing.Size(21, 690)
        Me._frmMainUnpinnedTabAreaRight.TabIndex = 34
        '
        '_frmMainUnpinnedTabAreaTop
        '
        Me._frmMainUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._frmMainUnpinnedTabAreaTop.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 23)
        Me._frmMainUnpinnedTabAreaTop.Name = "_frmMainUnpinnedTabAreaTop"
        Me._frmMainUnpinnedTabAreaTop.Owner = Me.dockManager
        Me._frmMainUnpinnedTabAreaTop.Size = New System.Drawing.Size(993, 21)
        Me._frmMainUnpinnedTabAreaTop.TabIndex = 35
        '
        '_frmMainUnpinnedTabAreaBottom
        '
        Me._frmMainUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._frmMainUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 713)
        Me._frmMainUnpinnedTabAreaBottom.Name = "_frmMainUnpinnedTabAreaBottom"
        Me._frmMainUnpinnedTabAreaBottom.Owner = Me.dockManager
        Me._frmMainUnpinnedTabAreaBottom.Size = New System.Drawing.Size(993, 0)
        Me._frmMainUnpinnedTabAreaBottom.TabIndex = 36
        '
        '_frmMainAutoHideControl
        '
        Me._frmMainAutoHideControl.Controls.Add(Me.DockableWindow4)
        Me._frmMainAutoHideControl.Controls.Add(Me.DockableWindow3)
        Me._frmMainAutoHideControl.Controls.Add(Me.DockableWindow2)
        Me._frmMainAutoHideControl.Controls.Add(Me.DockableWindow1)
        Me._frmMainAutoHideControl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainAutoHideControl.Location = New System.Drawing.Point(982, 44)
        Me._frmMainAutoHideControl.Name = "_frmMainAutoHideControl"
        Me._frmMainAutoHideControl.Owner = Me.dockManager
        Me._frmMainAutoHideControl.Size = New System.Drawing.Size(11, 669)
        Me._frmMainAutoHideControl.TabIndex = 37
        '
        'DockableWindow4
        '
        Me.DockableWindow4.Location = New System.Drawing.Point(-10000, 0)
        Me.DockableWindow4.Name = "DockableWindow4"
        Me.DockableWindow4.Owner = Me.dockManager
        Me.DockableWindow4.Size = New System.Drawing.Size(326, 669)
        Me.DockableWindow4.TabIndex = 85
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(panFindMedieplan)
        Me.DockableWindow2.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.dockManager
        Me.DockableWindow2.Size = New System.Drawing.Size(0, 0)
        Me.DockableWindow2.TabIndex = 93
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.splitContainer)
        Me.DockableWindow3.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.dockManager
        Me.DockableWindow3.Size = New System.Drawing.Size(0, 0)
        Me.DockableWindow3.TabIndex = 92
        '
        'statusBar
        '
        Me.statusBar.Location = New System.Drawing.Point(0, 713)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Padding = New Infragistics.Win.UltraWinStatusBar.UIElementMargins(0, 1, 0, 0)
        UltraStatusPanel1.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Spring
        UltraStatusPanel1.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.MDIList
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 9.0!
        UltraStatusPanel2.Appearance = Appearance4
        UltraStatusPanel2.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Automatic
        UltraStatusPanel2.Text = "Omsætning"
        Me.statusBar.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1, UltraStatusPanel2})
        Me.statusBar.Size = New System.Drawing.Size(1014, 23)
        Me.statusBar.SizeGripVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.statusBar.TabIndex = 82
        '
        'timerOmsætning
        '
        Me.timerOmsætning.Enabled = True
        Me.timerOmsætning.Interval = 60000
        '
        '_frmMain_Toolbars_Dock_Area_Left
        '
        Me._frmMain_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMain_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.ControlLight
        Me._frmMain_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmMain_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMain_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 23)
        Me._frmMain_Toolbars_Dock_Area_Left.Name = "_frmMain_Toolbars_Dock_Area_Left"
        Me._frmMain_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 690)
        Me._frmMain_Toolbars_Dock_Area_Left.ToolbarsManager = Me.toolbarManager
        '
        'toolbarManager
        '
        Me.toolbarManager.AlwaysShowMenusExpanded = Infragistics.Win.DefaultableBoolean.[True]
        Me.toolbarManager.DesignerFlags = 1
        Me.toolbarManager.DockWithinContainer = Me
        Me.toolbarManager.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.toolbarManager.LockToolbars = True
        Me.toolbarManager.MdiMergeable = False
        Me.toolbarManager.MenuAnimationStyle = Infragistics.Win.UltraWinToolbars.MenuAnimationStyle.Random
        Me.toolbarManager.MiniToolbar.ToolRowCount = 1
        Me.toolbarManager.Office2007UICompatibility = False
        Me.toolbarManager.RuntimeCustomizationOptions = Infragistics.Win.UltraWinToolbars.RuntimeCustomizationOptions.None
        Me.toolbarManager.SaveSettingsFormat = Infragistics.Win.SaveSettingsFormat.Xml
        Me.toolbarManager.SettingsKey = "toolbarManager"
        Me.toolbarManager.ShowFullMenusDelay = 0
        Me.toolbarManager.ShowQuickCustomizeButton = False
        Me.toolbarManager.ShowShortcutsInToolTips = True
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(295, 166)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(413, 42)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.IsStockToolbar = False
        PopupMenuTool1.InstanceProps.RecentlyUsed = False
        PopupMenuTool3.InstanceProps.RecentlyUsed = False
        PopupMenuTool4.InstanceProps.RecentlyUsed = False
        PopupMenuTool5.InstanceProps.RecentlyUsed = False
        PopupMenuTool6.InstanceProps.RecentlyUsed = False
        PopupMenuTool7.InstanceProps.RecentlyUsed = False
        PopupMenuTool8.InstanceProps.RecentlyUsed = False
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool1, PopupMenuTool3, PopupMenuTool4, PopupMenuTool5, PopupMenuTool6, PopupMenuTool7, PopupMenuTool8})
        UltraToolbar1.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolbar1.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.FillEntireRow = Infragistics.Win.DefaultableBoolean.[True]
        UltraToolbar1.Settings.PaddingBottom = 1
        UltraToolbar1.Settings.PaddingLeft = 1
        UltraToolbar1.Settings.PaddingRight = 1
        UltraToolbar1.Settings.PaddingTop = 1
        UltraToolbar1.ShowInToolbarList = False
        UltraToolbar1.Text = "mainmenu"
        Me.toolbarManager.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Me.toolbarManager.ToolbarSettings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        Me.toolbarManager.ToolbarSettings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        Me.toolbarManager.ToolbarSettings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        Me.toolbarManager.ToolbarSettings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        Me.toolbarManager.ToolbarSettings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[True]
        Me.toolbarManager.ToolbarSettings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        Me.toolbarManager.ToolbarSettings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        Me.toolbarManager.ToolbarSettings.FillEntireRow = Infragistics.Win.DefaultableBoolean.[True]
        PopupMenuTool9.SharedPropsInternal.Caption = "Fil"
        ButtonTool1.InstanceProps.RecentlyUsed = False
        PopupMenuTool9.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1})
        PopupMenuTool11.SharedPropsInternal.Caption = "Medieplan"
        ButtonTool5.InstanceProps.RecentlyUsed = False
        ButtonTool6.InstanceProps.RecentlyUsed = False
        ButtonTool2.InstanceProps.IsFirstInGroup = True
        ButtonTool48.InstanceProps.IsFirstInGroup = True
        ButtonTool48.InstanceProps.RecentlyUsed = False
        PopupMenuTool11.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5, ButtonTool6, ButtonTool2, ButtonTool48})
        PopupMenuTool12.SharedPropsInternal.Caption = "Booking"
        ButtonTool7.InstanceProps.RecentlyUsed = False
        ButtonTool8.InstanceProps.RecentlyUsed = False
        ButtonTool23.InstanceProps.IsFirstInGroup = True
        ButtonTool25.InstanceProps.IsFirstInGroup = True
        PopupMenuTool12.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool7, ButtonTool8, ButtonTool23, ButtonTool27, ButtonTool31, ButtonTool25})
        PopupMenuTool13.SharedPropsInternal.Caption = "Rapportering"
        PopupMenuTool13.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool4, ButtonTool50})
        PopupMenuTool14.SharedPropsInternal.Caption = "Fakturering"
        ButtonTool38.InstanceProps.IsFirstInGroup = True
        ButtonTool17.InstanceProps.RecentlyUsed = False
        ButtonTool19.InstanceProps.IsFirstInGroup = True
        PopupMenuTool14.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool36, ButtonTool38, ButtonTool17, ButtonTool44, ButtonTool21, ButtonTool19, ButtonTool35})
        PopupMenuTool15.SharedPropsInternal.Caption = "Administration"
        ButtonTool46.InstanceProps.IsFirstInGroup = True
        ButtonTool52.InstanceProps.IsFirstInGroup = True
        ButtonTool32.InstanceProps.IsFirstInGroup = True
        ButtonTool59.InstanceProps.IsFirstInGroup = True
        PopupMenuTool15.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool46, ButtonTool54, ButtonTool11, ButtonTool40, ButtonTool52, ButtonTool32, ButtonTool56, ButtonTool59})
        ButtonTool9.SharedPropsInternal.Caption = "Afslut"
        PopupMenuTool16.SharedPropsInternal.Caption = "Åbne Vinduer"
        MdiWindowListTool1.InstanceProps.RecentlyUsed = False
        PopupMenuTool16.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {MdiWindowListTool1})
        MdiWindowListTool2.DisplayArrangeIconsCommand = Infragistics.Win.UltraWinToolbars.MdiWindowListCommandDisplayStyle.Hide
        MdiWindowListTool2.DisplayCascadeCommand = Infragistics.Win.UltraWinToolbars.MdiWindowListCommandDisplayStyle.Hide
        MdiWindowListTool2.MoreItemsText = "&Flere Vinduer..."
        MdiWindowListTool2.SharedPropsInternal.Caption = "MDIVinduer"
        ButtonTool13.SharedPropsInternal.Caption = "Opret Medieplan"
        ButtonTool14.SharedPropsInternal.Caption = "Find Medieplan"
        ButtonTool15.SharedPropsInternal.Caption = "Opret Medieplan"
        ButtonTool16.SharedPropsInternal.Caption = "Find Medieplan"
        ButtonTool18.SharedPropsInternal.Caption = "Vis fejl"
        ButtonTool20.SharedPropsInternal.Caption = "Oversigt"
        ButtonTool22.SharedPropsInternal.Caption = "Send til Navision"
        ButtonTool24.SharedPropsInternal.Caption = "Udsending"
        ButtonTool26.SharedPropsInternal.Caption = "Genudsend lister"
        ButtonTool28.SharedPropsInternal.Caption = "Skal Sendes"
        ButtonTool29.SharedPropsInternal.Caption = "Er Sendt"
        ButtonTool30.SharedPropsInternal.Caption = "Om Lokalplanner"
        ButtonTool33.SharedPropsInternal.Caption = "Booking Liste"
        ButtonTool37.SharedPropsInternal.Caption = "Avis Grupper"
        ButtonTool39.SharedPropsInternal.Caption = "Mangler Annoncekontrol"
        ButtonTool39.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.DefaultForToolType
        ButtonTool41.SharedPropsInternal.Caption = "Rabatformer"
        ButtonTool42.SharedPropsInternal.Caption = "Find Medieplan"
        ButtonTool47.SharedPropsInternal.Caption = "Ugeavis Stamdata"
        ButtonTool47.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        ButtonTool3.SharedPropsInternal.Caption = "Vis Forespørgsler"
        ButtonTool10.SharedPropsInternal.Caption = "Annoncør omsætning"
        ButtonTool12.SharedPropsInternal.Caption = "Send til Web"
        ButtonTool34.SharedPropsInternal.Caption = "Fjern overført ordre"
        ButtonTool43.SharedPropsInternal.Caption = "Skift Status"
        ButtonTool45.SharedPropsInternal.Caption = "Vis Åbne Fakturerings Bilag"
        ButtonTool49.SharedPropsInternal.Caption = "Konkurrent Info"
        ButtonTool49.SharedPropsInternal.Visible = False
        ButtonTool51.SharedPropsInternal.Caption = "Bergske afstemning"
        ButtonTool53.SharedPropsInternal.Caption = "Miljøtillæg"
        ButtonTool55.SharedPropsInternal.Caption = "Se ændringer"
        ButtonTool57.SharedPropsInternal.Caption = "Se nyheder/ændringer"
        ButtonTool58.SharedPropsInternal.Caption = "Kontakter"
        ButtonTool60.SharedPropsInternal.Caption = "Slet Filer"
        Me.toolbarManager.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool9, PopupMenuTool11, PopupMenuTool12, PopupMenuTool13, PopupMenuTool14, PopupMenuTool15, ButtonTool9, PopupMenuTool16, MdiWindowListTool2, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool16, ButtonTool18, ButtonTool20, ButtonTool22, ButtonTool24, ButtonTool26, ButtonTool28, ButtonTool29, ButtonTool30, ButtonTool33, ButtonTool37, ButtonTool39, ButtonTool41, ButtonTool42, ButtonTool47, ButtonTool3, ButtonTool10, ButtonTool12, ButtonTool34, ButtonTool43, ButtonTool45, ButtonTool49, ButtonTool51, ButtonTool53, ButtonTool55, ButtonTool57, ButtonTool58, ButtonTool60})
        Me.toolbarManager.TransitionAreas = Infragistics.Win.UltraWinToolbars.ToolbarTransitionAreas.MainMenuTools
        '
        '_frmMain_Toolbars_Dock_Area_Right
        '
        Me._frmMain_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMain_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.ControlLight
        Me._frmMain_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmMain_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMain_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1014, 23)
        Me._frmMain_Toolbars_Dock_Area_Right.Name = "_frmMain_Toolbars_Dock_Area_Right"
        Me._frmMain_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 690)
        Me._frmMain_Toolbars_Dock_Area_Right.ToolbarsManager = Me.toolbarManager
        '
        '_frmMain_Toolbars_Dock_Area_Top
        '
        Me._frmMain_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMain_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.ControlLight
        Me._frmMain_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmMain_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMain_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmMain_Toolbars_Dock_Area_Top.Name = "_frmMain_Toolbars_Dock_Area_Top"
        Me._frmMain_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1014, 23)
        Me._frmMain_Toolbars_Dock_Area_Top.ToolbarsManager = Me.toolbarManager
        '
        '_frmMain_Toolbars_Dock_Area_Bottom
        '
        Me._frmMain_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMain_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.ControlLight
        Me._frmMain_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmMain_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMain_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 713)
        Me._frmMain_Toolbars_Dock_Area_Bottom.Name = "_frmMain_Toolbars_Dock_Area_Bottom"
        Me._frmMain_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1014, 0)
        Me._frmMain_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.toolbarManager
        '
        'TblAnnoncørerTableAdapter
        '
        Me.TblAnnoncørerTableAdapter.ClearBeforeFill = True
        '
        'TblUgeaviserTableAdapter
        '
        Me.TblUgeaviserTableAdapter.ClearBeforeFill = True
        '
        'TblFundneplanerTableAdapter
        '
        Me.TblFundneplanerTableAdapter.ClearBeforeFill = True
        '
        'TblBureauerTableAdapter
        '
        Me.TblBureauerTableAdapter.ClearBeforeFill = True
        '
        'WindowDockingArea6
        '
        Me.WindowDockingArea6.Dock = System.Windows.Forms.DockStyle.Right
        Me.WindowDockingArea6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea6.Location = New System.Drawing.Point(589, 44)
        Me.WindowDockingArea6.Name = "WindowDockingArea6"
        Me.WindowDockingArea6.Owner = Me.dockManager
        Me.WindowDockingArea6.Size = New System.Drawing.Size(404, 665)
        Me.WindowDockingArea6.TabIndex = 0
        '
        'WindowDockingArea5
        '
        Me.WindowDockingArea5.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea5.Location = New System.Drawing.Point(0, 44)
        Me.WindowDockingArea5.Name = "WindowDockingArea5"
        Me.WindowDockingArea5.Owner = Me.dockManager
        Me.WindowDockingArea5.Size = New System.Drawing.Size(993, 105)
        Me.WindowDockingArea5.TabIndex = 91
        '
        'WindowDockingArea2
        '
        Me.WindowDockingArea2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowDockingArea2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea2.Location = New System.Drawing.Point(0, 44)
        Me.WindowDockingArea2.Name = "WindowDockingArea2"
        Me.WindowDockingArea2.Owner = Me.dockManager
        Me.WindowDockingArea2.Size = New System.Drawing.Size(100, 100)
        Me.WindowDockingArea2.TabIndex = 76
        '
        'DiMPdotNetDataSetBindingSource
        '
        Me.DiMPdotNetDataSetBindingSource.DataSource = Me.DiMPdotNetDataSet
        Me.DiMPdotNetDataSetBindingSource.Position = 0
        '
        'DiMPdotNetDataSet
        '
        Me.DiMPdotNetDataSet.DataSetName = "DiMPdotNetDataSet"
        Me.DiMPdotNetDataSet.EnforceConstraints = False
        Me.DiMPdotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WindowDockingArea4
        '
        Me.WindowDockingArea4.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea4.Location = New System.Drawing.Point(0, 44)
        Me.WindowDockingArea4.Name = "WindowDockingArea4"
        Me.WindowDockingArea4.Owner = Me.dockManager
        Me.WindowDockingArea4.Size = New System.Drawing.Size(993, 186)
        Me.WindowDockingArea4.TabIndex = 0
        '
        'TblBladStamdataTableAdapter
        '
        Me.TblBladStamdataTableAdapter.ClearBeforeFill = True
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.grdFundnePlaner)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.dockManager
        Me.DockableWindow1.Size = New System.Drawing.Size(0, 0)
        Me.DockableWindow1.TabIndex = 94
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnFind
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1014, 736)
        Me.toolbarManager.SetContextMenuUltra(Me, "Edit")
        Me.Controls.Add(Me.WindowDockingArea5)
        Me.Controls.Add(Me._frmMainAutoHideControl)
        Me.Controls.Add(panFindMedieplanBooking)
        Me.Controls.Add(Me.WindowDockingArea4)
        Me.Controls.Add(Me.WindowDockingArea6)
        Me.Controls.Add(Me._frmMainUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._frmMainUnpinnedTabAreaTop)
        Me.Controls.Add(Me._frmMainUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._frmMainUnpinnedTabAreaRight)
        Me.Controls.Add(Me._frmMain_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmMain_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmMain_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me._frmMain_Toolbars_Dock_Area_Top)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lokal planner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        panFindMedieplan.ResumeLayout(False)
        panFindMedieplan.PerformLayout()
        CType(Me.chkVisInAktive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedtagRettelser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFakturering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedieplan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKonsulent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTilUge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFraUge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numÅr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBureau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBureauerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BureauListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAnnoncør, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAnnoncørerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnnoncørListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedieplanNr, System.ComponentModel.ISupportInitialize).EndInit()
        panFindMedieplanBooking.ResumeLayout(False)
        panFindMedieplanBooking.PerformLayout()
        CType(Me.chkVisInAktiveBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedtagRettelserBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFaktureringBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBookingBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedieplanBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKonsulentBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTilUgeBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFraUgeBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numÅrBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBureauBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAnnoncørBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUgeavisBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUgeaviserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UgeavisListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedieplanNrBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBureauordreNrBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel1.PerformLayout()
        Me.splitContainer.Panel2.ResumeLayout(False)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        CType(Me.txtPostBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDækningsGrad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostNr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedtagOphørte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFindUgeavis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFundnePlaner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFundneplanerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstFindMedieplaner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockManager, System.Configuration.IPersistComponentSettings).LoadComponentSettings()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me._frmMainAutoHideControl.ResumeLayout(False)
        Me.DockableWindow2.ResumeLayout(False)
        Me.DockableWindow3.ResumeLayout(False)
        CType(Me.statusBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toolbarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiMPdotNetDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiMPdotNetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockableWindow1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents toolbarManager As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
  Friend WithEvents _frmMain_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
  Friend WithEvents _frmMain_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
  Friend WithEvents _frmMain_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
  Friend WithEvents _frmMain_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
  Friend WithEvents DiMPdotNetDataSetBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents DiMPdotNetDataSet As WinPlanner.DiMPdotNetDataSet
  Friend WithEvents TblBladStamdataTableAdapter As WinPlanner.DiMPdotNetDataSetTableAdapters.tblBladStamdataTableAdapter
  Friend WithEvents splitContainer As System.Windows.Forms.SplitContainer
  Friend WithEvents _frmMainAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
  Friend WithEvents dockManager As Infragistics.Win.UltraWinDock.UltraDockManager
  Friend WithEvents _frmMainUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
  Friend WithEvents _frmMainUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
  Friend WithEvents _frmMainUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
  Friend WithEvents _frmMainUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
  Friend WithEvents grdFindUgeavis As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblTilUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblFraUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblAnnoncør As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblMedieplanNr As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtMedieplanNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents btnFind As Infragistics.Win.Misc.UltraButton
  Friend WithEvents picPipeline As Infragistics.Win.UltraWinEditors.UltraPictureBox
  Friend WithEvents picPipelineBooking As Infragistics.Win.UltraWinEditors.UltraPictureBox
  Friend WithEvents btnFindBooking As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtMedieplanNrBooking As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtBureauordreNrBooking As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblBureauordreNrBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblTilUgeBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblFraUgeBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblAnnoncørBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblMedieplanNrBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblBureau As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblBureauBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents numFraUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents numTilUge As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents numTilUgeBooking As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents numFraUgeBooking As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lblUgeavisBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents cboUgeavisBooking As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents cboAnnoncør As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents AnnoncørListeDropdown As WinPlanner.AnnoncørListeDropdown
  Friend WithEvents TblAnnoncørerBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblAnnoncørerTableAdapter As WinPlanner.AnnoncørListeDropdownTableAdapters.tblAnnoncørerTableAdapter
  Friend WithEvents cboBureau As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents cboAnnoncørBooking As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents BureauListeDropdown As WinPlanner.BureauListeDropdown
  Friend WithEvents TblBureauerBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblBureauerTableAdapter As WinPlanner.BureauListeDropdownTableAdapters.tblBureauerTableAdapter
  Friend WithEvents cboBureauBooking As Infragistics.Win.UltraWinEditors.UltraComboEditor
  Friend WithEvents UgeavisListeDropdown As WinPlanner.UgeavisListeDropdown
  Friend WithEvents TblUgeaviserBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblUgeaviserTableAdapter As WinPlanner.UgeavisListeDropdownTableAdapters.tblUgeaviserTableAdapter
  Friend WithEvents lblÅrBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents numÅrBooking As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lblÅr As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents numÅr As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents WindowDockingArea2 As Infragistics.Win.UltraWinDock.WindowDockingArea
  Friend WithEvents AppStylist As Infragistics.Win.AppStyling.Runtime.AppStylistRuntime
  Friend WithEvents statusBar As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
  Friend WithEvents grdFundnePlaner As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents WindowDockingArea5 As Infragistics.Win.UltraWinDock.WindowDockingArea
  Friend WithEvents WindowDockingArea4 As Infragistics.Win.UltraWinDock.WindowDockingArea
  Friend WithEvents btnFindUgeavis As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtPostBy As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblVælgByer As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents numDækningsGrad As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lblDækningsgrad As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtPostNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblPostNr As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtKonsulent As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblKonsulent As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents DstFindMedieplaner As WinPlanner.dstFindMedieplaner
  Friend WithEvents TblFundneplanerBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblFundneplanerTableAdapter As WinPlanner.dstFindMedieplanerTableAdapters.tblFundneplanerTableAdapter
  Friend WithEvents WindowDockingArea6 As Infragistics.Win.UltraWinDock.WindowDockingArea
  Friend WithEvents btnOverførBlade As Infragistics.Win.Misc.UltraButton
  Friend WithEvents btnGrupper As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtKonsulentBooking As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblKonsulentBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents chkMedieplan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkFakturering As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkBooking As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents lblMedtagVersion As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents lblMedtagVersionerBooking As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents chkFaktureringBooking As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkBookingBooking As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkMedieplanBooking As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkMedtagOphørte As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkMedtagRettelser As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkMedtagRettelserBooking As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents timerOmsætning As System.Windows.Forms.Timer
  Friend WithEvents DockableWindow4 As Infragistics.Win.UltraWinDock.DockableWindow
  Friend WithEvents btnTilExcel As Infragistics.Win.Misc.UltraButton
  Friend WithEvents ExcelExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
  Friend WithEvents chkVisInAktive As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkVisInAktiveBooking As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents DockableWindow3 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
End Class
