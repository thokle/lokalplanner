<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBladStamData
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
        Dim lblPrimærPct As System.Windows.Forms.Label
        Dim lblPrimær As System.Windows.Forms.Label
        Dim lblTotalområdePct As System.Windows.Forms.Label
        Dim lblTotalområde As System.Windows.Forms.Label
        Dim lblGeokode As System.Windows.Forms.Label
        Dim lblDelområde As System.Windows.Forms.Label
        Dim lblRegion As System.Windows.Forms.Label
        Dim lblMedlemSiden As System.Windows.Forms.Label
        Dim lblHovedgruppe As System.Windows.Forms.Label
        Dim lblStamdata As System.Windows.Forms.Label
        Dim lblKontaktperson As System.Windows.Forms.Label
        Dim lblFIK As System.Windows.Forms.Label
        Dim lblCVR As System.Windows.Forms.Label
        Dim lblFax As System.Windows.Forms.Label
        Dim lblTlf As System.Windows.Forms.Label
        Dim lblAdresse2 As System.Windows.Forms.Label
        Dim lblAdresse As System.Windows.Forms.Label
        Dim lblNavn As System.Windows.Forms.Label
        Dim lblBladID As System.Windows.Forms.Label
        Dim lblPostNr As System.Windows.Forms.Label
        Dim lblMaterialedeadlineRubrik As System.Windows.Forms.Label
        Dim lblMaterialedeadlineTekst As System.Windows.Forms.Label
        Dim lblOrdredeadlineRubrik As System.Windows.Forms.Label
        Dim lblOrdredeadlineTekst As System.Windows.Forms.Label
        Dim lblTekniskeDataFormat As System.Windows.Forms.Label
        Dim lblUgedag As System.Windows.Forms.Label
        Dim lblOplag As System.Windows.Forms.Label
        Dim lblOrdrecheckEmail As System.Windows.Forms.Label
        Dim lblOrdreEmail As System.Windows.Forms.Label
        Dim lblEjerforhold As System.Windows.Forms.Label
        Dim lblBilagsbladeEmail As System.Windows.Forms.Label
        Dim lblAnnoncekontrolEmail As System.Windows.Forms.Label
        Dim lblMaterialeEmail As System.Windows.Forms.Label
        Dim lblDiverseOplysninger As System.Windows.Forms.Label
        Dim lblFormat As Infragistics.Win.Misc.UltraLabel
        Dim lblFarveTillæg As Infragistics.Win.Misc.UltraLabel
        Dim lblMmPris As Infragistics.Win.Misc.UltraLabel
        Dim lblFormatTil As Infragistics.Win.Misc.UltraLabel
        Dim lblFormatFra As Infragistics.Win.Misc.UltraLabel
        Dim lblDækningsområde As Infragistics.Win.Misc.UltraLabel
        Dim lblGeografiskeData As Infragistics.Win.Misc.UltraLabel
        Dim lblLæsertal As Infragistics.Win.Misc.UltraLabel
        Dim lblBeskrivelseAfDækningsområdet As Infragistics.Win.Misc.UltraLabel
        Dim lblOplysningerTilDLUsHjemmeside As Infragistics.Win.Misc.UltraLabel
        Dim lblHjemmeside As Infragistics.Win.Misc.UltraLabel
        Dim lblRedaktionsEmail As Infragistics.Win.Misc.UltraLabel
        Dim lblBladetsAnnonceEmail As Infragistics.Win.Misc.UltraLabel
        Dim lblForMateriale As Infragistics.Win.Misc.UltraLabel
        Dim lblForOrdrer As Infragistics.Win.Misc.UltraLabel
        Dim lblDeadlines As Infragistics.Win.Misc.UltraLabel
        Dim lblTekniskeData As Infragistics.Win.Misc.UltraLabel
        Dim lblBogholderiEmails As Infragistics.Win.Misc.UltraLabel
        Dim lblKontaktpersonerEmails As Infragistics.Win.Misc.UltraLabel
        Dim lblEmails As Infragistics.Win.Misc.UltraLabel
        Dim lblOrienteringEmails As Infragistics.Win.Misc.UltraLabel
        Dim lblMedienet As Infragistics.Win.Misc.UltraLabel
        Dim lblMedienetID As Infragistics.Win.Misc.UltraLabel
        Dim lblAnsvarligFor As Infragistics.Win.Misc.UltraLabel
        Dim lblAnsvarligForStamdataEmail As Infragistics.Win.Misc.UltraLabel
        Dim lblPrisforespørgselEmails As Infragistics.Win.Misc.UltraLabel
        Dim lblUdsending As Infragistics.Win.Misc.UltraLabel
        Dim lblUdsendelsesTidspunkt As Infragistics.Win.Misc.UltraLabel
        Dim lblPrisLister As System.Windows.Forms.Label
        Dim lblPrislistePrUge As System.Windows.Forms.Label
        Dim lblÅr As System.Windows.Forms.Label
        Dim lblFarveRabatMåGives As Infragistics.Win.Misc.UltraLabel
        Dim lblKoncern As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblPostNr", -1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostNr")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostBy")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Husstande")
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("FK_tblPrislisterPrBladPrÅr_tblBladStamdata", -1)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("År")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrislisteID")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrislisteNavn")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblPostNr", -1)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostNr")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostBy")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Husstande")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem19 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem20 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem21 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem22 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem23 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem24 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem25 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem26 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem27 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem28 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem41 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem29 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem30 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem31 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem32 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem33 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem34 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem35 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem36 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem37 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem38 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem39 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem40 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblGeoKode", -1)
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeID")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeNavn")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeoKodeSortKey")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("timestamp")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblDelOmråde", -1)
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOmrådeID")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOmrådeKode")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOmrådeNavn")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOmrådeSortKey")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("timestamp")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblRegion", -1)
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegionID")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegionNavn")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegionSortKey")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("timestamp")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("FK_tblBladDækning_tblBladStamdata", -1)
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostNr")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Oplag")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DækningsGrad")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("FK_tblPrislisterPrBladPrÅr_tblBladStamdata", -1)
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("År")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrislisteID")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrislisteNavn")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("FK_tblPrislisterPrBladPrUge_tblBladStamdata", -1)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("År")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Uge")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrislisteID")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab(True)
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab20 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblBladStamdata_tableMedAllePriser", -1)
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrislisteNavn", -1, Nothing, 1, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, True)
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Betegnelse")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FormatFra")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FormatTil")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("mmPris")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarvePris")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveMin")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FarveMax")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Farve4Pris")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Farve4Min")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Farve4Max")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("År", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, True)
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlaceringID", -1, Nothing, 2, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblDage", -1)
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DagID")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DagNavn")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DagType")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("timestamp")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblDage", -1)
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DagID")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DagNavn")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DagType")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("timestamp")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBladStamData))
        Me.cboPostNrDækning = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.TblPostNrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PostNrListeDropdown = New WinPlanner.PostNrListeDropdown()
        Me.cboPrislisterPrÅr = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbpTekstside = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grpPriser = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt4FarvertillægMax8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMin8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4Farvertillæg8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMax8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMin8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMmPris8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatTil8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatFra8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1Farvetillæg8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMax7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMin7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4Farvertillæg7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMax7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMin7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMmPris7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatTil7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatFra7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1Farvetillæg7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.optFarverabatMåGives = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.txt4FarvertillægMax6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMin6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4Farvertillæg6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMax6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMin6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMmPris6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatTil6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatFra6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1Farvetillæg6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMax5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMin5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4Farvertillæg5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMax5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMin5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMmPris5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatTil5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatFra5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1Farvetillæg5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMax4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMin4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4Farvertillæg4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMax4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMin4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMmPris4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatTil4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatFra4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1Farvetillæg4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMax3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMin3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4Farvertillæg3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMax3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMin3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMmPris3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatTil3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatFra3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1Farvetillæg3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMax2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMin2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4Farvertillæg2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMax2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMin2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMmPris2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatTil2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatFra2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1Farvetillæg2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMax1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4FarvertillægMin1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt4Farvertillæg1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMax1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1FarvetillægMin1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMmPris1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatTil1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormatFra1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt1Farvetillæg1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lbl4FarvertillægMax = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl4Farver = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl1Farve = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl1FarvetillægMin = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl4FarvertillægMin = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl1FarvetillægMax = New Infragistics.Win.Misc.UltraLabel()
        Me.tbpSide3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpSide5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpSide7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpHøjreSide = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpRubrik = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpMotor = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpForlystelser = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpOfficielle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpStillinger = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpBolig = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpUddannelse = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tbpNavnAdresse = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txtKoncern = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboPostNr = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtEjerforhold = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.optHovedgruppe = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.txtUgeavisID = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboÅr = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboMåned = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chkOphørt = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkMedPåWWW = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtKontaktperson = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFIK = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCVR = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.medFax = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.medTlf = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtAdresse = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNavn = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtAdresse2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtBynavn = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tbpDækningsområde = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cboGeoKode = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.TblGeoKodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeoKodeListeDropdown = New WinPlanner.GeoKodeListeDropdown()
        Me.cboDelområde = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.TblDelOmrådeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DelområdeListeDropdown = New WinPlanner.DelområdeListeDropdown()
        Me.cboRegion = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.TblRegionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegionListeDropdown = New WinPlanner.RegionListeDropdown()
        Me.grdDækning = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TblBladDækningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotalområdePct = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtPrimærPct = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtTotalområde = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.WWWDækningSomTekstUltraFormattedTextEditor = New Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor()
        Me.txtPrimær = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tbpPriser = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cboPriserÅr = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.FKtblÅrMedPrisertblBladStamdataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboPrislister = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.TblPrislisterPrBladPrUgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPrislisterPrBladPrUgeUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.btnTilføjPrisliste = New Infragistics.Win.Misc.UltraButton()
        Me.tabPriser = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.tbpPriserOversigt = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grdAllePriser = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TableMedAllePriserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbpTekniskeData = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cboUgedag = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.TblDageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UgedagListeDropdown = New WinPlanner.UgedagListeDropdown()
        Me.txtOplag = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtHjemmeside = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRedaktionsEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtBladetsAnnonceEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMaterialedeadlineRubrik = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMaterialedeadlineTekst = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtOrdredeadlineRubrik = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtOrdredeadlineTekst = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFormat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tbpUdsending = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cboTjeklisteDag = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtBogholderiEmails = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtKontaktpersonerEmails = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtEmails = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtOrienteringsEmails = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtBilagsbladeEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtAnnoncekontrolEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMaterialeEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMedienetID = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtAnsvarligForStamdataEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtPrisforespørgselEmails = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtOrdrecheckEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtOrdreEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboUdsendelsesTidspunkt = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chkSendIndeværendeUge = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.FKtblÅrMedPrisertblBladStamdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabStamdata = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.TblBladStamdataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblBladStamdataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslAvisNavn = New System.Windows.Forms.ToolStripLabel()
        Me.lblBigStamdata = New System.Windows.Forms.Label()
        Me.imgChain = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.imgLock = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.btnGem = New Infragistics.Win.Misc.UltraButton()
        Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
        Me.btnLuk = New Infragistics.Win.Misc.UltraButton()
        Me.btnUdskriv = New Infragistics.Win.Misc.UltraButton()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.Label_Status = New System.Windows.Forms.Label()
        Me.TblPostNrTableAdapter = New WinPlanner.PostNrListeDropdownTableAdapters.tblPostNrTableAdapter()
        Me.TblRegionTableAdapter = New WinPlanner.RegionListeDropdownTableAdapters.tblRegionTableAdapter()
        Me.TblDelOmrådeTableAdapter = New WinPlanner.DelområdeListeDropdownTableAdapters.tblDelOmrådeTableAdapter()
        Me.TblGeoKodeTableAdapter = New WinPlanner.GeoKodeListeDropdownTableAdapters.tblGeoKodeTableAdapter()
        Me.TblDageTableAdapter = New WinPlanner.UgedagListeDropdownTableAdapters.tblDageTableAdapter()
        Me.TblBladStamdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstBladStamdata = New WinPlanner.dstBladStamdata()
        Me.TblBladStamdataTableAdapter = New WinPlanner.dstBladStamdataTableAdapters.tblBladStamdataTableAdapter()
        Me.TblBladDækningTableAdapter = New WinPlanner.dstBladStamdataTableAdapters.tblBladDækningTableAdapter()
        Me.TblPrislisterPrBladPrUgeTableAdapter = New WinPlanner.dstBladStamdataTableAdapters.tblPrislisterPrBladPrUgeTableAdapter()
        Me.TableMedAllePriserTableAdapter = New WinPlanner.dstBladStamdataTableAdapters.tableMedAllePriserTableAdapter()
        Me.TblPrislisterPrBladPrÅrTableAdapter = New WinPlanner.dstBladStamdataTableAdapters.tblPrislisterPrBladPrÅrTableAdapter()
        Me.TblÅrMedPriserTableAdapter = New WinPlanner.dstBladStamdataTableAdapters.tblÅrMedPriserTableAdapter()
        lblPrimærPct = New System.Windows.Forms.Label()
        lblPrimær = New System.Windows.Forms.Label()
        lblTotalområdePct = New System.Windows.Forms.Label()
        lblTotalområde = New System.Windows.Forms.Label()
        lblGeokode = New System.Windows.Forms.Label()
        lblDelområde = New System.Windows.Forms.Label()
        lblRegion = New System.Windows.Forms.Label()
        lblMedlemSiden = New System.Windows.Forms.Label()
        lblHovedgruppe = New System.Windows.Forms.Label()
        lblStamdata = New System.Windows.Forms.Label()
        lblKontaktperson = New System.Windows.Forms.Label()
        lblFIK = New System.Windows.Forms.Label()
        lblCVR = New System.Windows.Forms.Label()
        lblFax = New System.Windows.Forms.Label()
        lblTlf = New System.Windows.Forms.Label()
        lblAdresse2 = New System.Windows.Forms.Label()
        lblAdresse = New System.Windows.Forms.Label()
        lblNavn = New System.Windows.Forms.Label()
        lblBladID = New System.Windows.Forms.Label()
        lblPostNr = New System.Windows.Forms.Label()
        lblMaterialedeadlineRubrik = New System.Windows.Forms.Label()
        lblMaterialedeadlineTekst = New System.Windows.Forms.Label()
        lblOrdredeadlineRubrik = New System.Windows.Forms.Label()
        lblOrdredeadlineTekst = New System.Windows.Forms.Label()
        lblTekniskeDataFormat = New System.Windows.Forms.Label()
        lblUgedag = New System.Windows.Forms.Label()
        lblOplag = New System.Windows.Forms.Label()
        lblOrdrecheckEmail = New System.Windows.Forms.Label()
        lblOrdreEmail = New System.Windows.Forms.Label()
        lblEjerforhold = New System.Windows.Forms.Label()
        lblBilagsbladeEmail = New System.Windows.Forms.Label()
        lblAnnoncekontrolEmail = New System.Windows.Forms.Label()
        lblMaterialeEmail = New System.Windows.Forms.Label()
        lblDiverseOplysninger = New System.Windows.Forms.Label()
        lblFormat = New Infragistics.Win.Misc.UltraLabel()
        lblFarveTillæg = New Infragistics.Win.Misc.UltraLabel()
        lblMmPris = New Infragistics.Win.Misc.UltraLabel()
        lblFormatTil = New Infragistics.Win.Misc.UltraLabel()
        lblFormatFra = New Infragistics.Win.Misc.UltraLabel()
        lblDækningsområde = New Infragistics.Win.Misc.UltraLabel()
        lblGeografiskeData = New Infragistics.Win.Misc.UltraLabel()
        lblLæsertal = New Infragistics.Win.Misc.UltraLabel()
        lblBeskrivelseAfDækningsområdet = New Infragistics.Win.Misc.UltraLabel()
        lblOplysningerTilDLUsHjemmeside = New Infragistics.Win.Misc.UltraLabel()
        lblHjemmeside = New Infragistics.Win.Misc.UltraLabel()
        lblRedaktionsEmail = New Infragistics.Win.Misc.UltraLabel()
        lblBladetsAnnonceEmail = New Infragistics.Win.Misc.UltraLabel()
        lblForMateriale = New Infragistics.Win.Misc.UltraLabel()
        lblForOrdrer = New Infragistics.Win.Misc.UltraLabel()
        lblDeadlines = New Infragistics.Win.Misc.UltraLabel()
        lblTekniskeData = New Infragistics.Win.Misc.UltraLabel()
        lblBogholderiEmails = New Infragistics.Win.Misc.UltraLabel()
        lblKontaktpersonerEmails = New Infragistics.Win.Misc.UltraLabel()
        lblEmails = New Infragistics.Win.Misc.UltraLabel()
        lblOrienteringEmails = New Infragistics.Win.Misc.UltraLabel()
        lblMedienet = New Infragistics.Win.Misc.UltraLabel()
        lblMedienetID = New Infragistics.Win.Misc.UltraLabel()
        lblAnsvarligFor = New Infragistics.Win.Misc.UltraLabel()
        lblAnsvarligForStamdataEmail = New Infragistics.Win.Misc.UltraLabel()
        lblPrisforespørgselEmails = New Infragistics.Win.Misc.UltraLabel()
        lblUdsending = New Infragistics.Win.Misc.UltraLabel()
        lblUdsendelsesTidspunkt = New Infragistics.Win.Misc.UltraLabel()
        lblPrisLister = New System.Windows.Forms.Label()
        lblPrislistePrUge = New System.Windows.Forms.Label()
        lblÅr = New System.Windows.Forms.Label()
        lblFarveRabatMåGives = New Infragistics.Win.Misc.UltraLabel()
        lblKoncern = New System.Windows.Forms.Label()
        CType(Me.cboPostNrDækning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPostNrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostNrListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPrislisterPrÅr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpTekstside.SuspendLayout()
        CType(Me.grpPriser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPriser.SuspendLayout()
        CType(Me.txt4FarvertillægMax8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMin8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4Farvertillæg8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMax8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMin8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMmPris8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatTil8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatFra8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1Farvetillæg8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMax7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMin7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4Farvertillæg7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMax7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMin7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMmPris7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatTil7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatFra7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1Farvetillæg7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optFarverabatMåGives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMax6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMin6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4Farvertillæg6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMax6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMin6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMmPris6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatTil6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatFra6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1Farvetillæg6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMax5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMin5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4Farvertillæg5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMax5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMin5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMmPris5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatTil5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatFra5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1Farvetillæg5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMax4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMin4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4Farvertillæg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMax4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMin4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMmPris4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatTil4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatFra4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1Farvetillæg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMax3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMin3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4Farvertillæg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMax3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMin3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMmPris3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatTil3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatFra3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1Farvetillæg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMax2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4Farvertillæg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMax2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMmPris2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatTil2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatFra2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1Farvetillæg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMax1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4FarvertillægMin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4Farvertillæg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMax1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1FarvetillægMin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMmPris1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatTil1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatFra1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1Farvetillæg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpNavnAdresse.SuspendLayout()
        CType(Me.txtKoncern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPostNr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEjerforhold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optHovedgruppe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUgeavisID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboÅr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMåned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOphørt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedPåWWW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKontaktperson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFIK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCVR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdresse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdresse2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBynavn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDækningsområde.SuspendLayout()
        CType(Me.cboGeoKode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGeoKodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeoKodeListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDelområde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDelOmrådeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelområdeListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRegionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegionListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDækning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBladDækningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalområdePct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrimærPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalområde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrimær, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPriser.SuspendLayout()
        CType(Me.cboPriserÅr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblÅrMedPrisertblBladStamdataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPrislister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPrislisterPrBladPrUgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPrislisterPrBladPrUgeUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPriser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPriser.SuspendLayout()
        Me.UltraTabSharedControlsPage3.SuspendLayout()
        Me.tbpPriserOversigt.SuspendLayout()
        CType(Me.grdAllePriser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableMedAllePriserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpTekniskeData.SuspendLayout()
        CType(Me.cboUgedag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UgedagListeDropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOplag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHjemmeside, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRedaktionsEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBladetsAnnonceEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialedeadlineRubrik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialedeadlineTekst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdredeadlineRubrik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdredeadlineTekst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpUdsending.SuspendLayout()
        CType(Me.cboTjeklisteDag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBogholderiEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKontaktpersonerEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrienteringsEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBilagsbladeEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnnoncekontrolEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialeEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedienetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnsvarligForStamdataEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrisforespørgselEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdrecheckEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdreEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUdsendelsesTidspunkt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSendIndeværendeUge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblÅrMedPrisertblBladStamdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabStamdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabStamdata.SuspendLayout()
        CType(Me.TblBladStamdataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblBladStamdataBindingNavigator.SuspendLayout()
        CType(Me.TblBladStamdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstBladStamdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrimærPct
        '
        lblPrimærPct.AutoSize = True
        lblPrimærPct.Location = New System.Drawing.Point(15, 260)
        lblPrimærPct.Name = "lblPrimærPct"
        lblPrimærPct.Size = New System.Drawing.Size(70, 13)
        lblPrimærPct.TabIndex = 4
        lblPrimærPct.Text = "Primær Pct"
        '
        'lblPrimær
        '
        lblPrimær.AutoSize = True
        lblPrimær.Location = New System.Drawing.Point(15, 232)
        lblPrimær.Name = "lblPrimær"
        lblPrimær.Size = New System.Drawing.Size(49, 13)
        lblPrimær.TabIndex = 4
        lblPrimær.Text = "Primær"
        '
        'lblTotalområdePct
        '
        lblTotalområdePct.AutoSize = True
        lblTotalområdePct.Location = New System.Drawing.Point(15, 205)
        lblTotalområdePct.Name = "lblTotalområdePct"
        lblTotalområdePct.Size = New System.Drawing.Size(100, 13)
        lblTotalområdePct.TabIndex = 4
        lblTotalområdePct.Text = "Totalområde Pct"
        '
        'lblTotalområde
        '
        lblTotalområde.AutoSize = True
        lblTotalområde.Location = New System.Drawing.Point(15, 176)
        lblTotalområde.Name = "lblTotalområde"
        lblTotalområde.Size = New System.Drawing.Size(79, 13)
        lblTotalområde.TabIndex = 4
        lblTotalområde.Text = "Totalområde"
        '
        'lblGeokode
        '
        lblGeokode.AutoSize = True
        lblGeokode.Location = New System.Drawing.Point(15, 100)
        lblGeokode.Name = "lblGeokode"
        lblGeokode.Size = New System.Drawing.Size(58, 13)
        lblGeokode.TabIndex = 4
        lblGeokode.Text = "Geokode"
        '
        'lblDelområde
        '
        lblDelområde.AutoSize = True
        lblDelområde.Location = New System.Drawing.Point(15, 71)
        lblDelområde.Name = "lblDelområde"
        lblDelområde.Size = New System.Drawing.Size(70, 13)
        lblDelområde.TabIndex = 4
        lblDelområde.Text = "Delområde"
        '
        'lblRegion
        '
        lblRegion.AutoSize = True
        lblRegion.Location = New System.Drawing.Point(15, 42)
        lblRegion.Name = "lblRegion"
        lblRegion.Size = New System.Drawing.Size(46, 13)
        lblRegion.TabIndex = 4
        lblRegion.Text = "Region"
        '
        'lblMedlemSiden
        '
        lblMedlemSiden.AutoSize = True
        lblMedlemSiden.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMedlemSiden.Location = New System.Drawing.Point(448, 98)
        lblMedlemSiden.Name = "lblMedlemSiden"
        lblMedlemSiden.Size = New System.Drawing.Size(96, 13)
        lblMedlemSiden.TabIndex = 117
        lblMedlemSiden.Text = "Medlem siden"
        '
        'lblHovedgruppe
        '
        lblHovedgruppe.AutoSize = True
        lblHovedgruppe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblHovedgruppe.Location = New System.Drawing.Point(448, 15)
        lblHovedgruppe.Name = "lblHovedgruppe"
        lblHovedgruppe.Size = New System.Drawing.Size(94, 13)
        lblHovedgruppe.TabIndex = 111
        lblHovedgruppe.Text = "Hovedgruppe"
        '
        'lblStamdata
        '
        lblStamdata.AutoSize = True
        lblStamdata.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStamdata.Location = New System.Drawing.Point(12, 15)
        lblStamdata.Name = "lblStamdata"
        lblStamdata.Size = New System.Drawing.Size(69, 13)
        lblStamdata.TabIndex = 13
        lblStamdata.Text = "Stamdata"
        '
        'lblKontaktperson
        '
        lblKontaktperson.AutoSize = True
        lblKontaktperson.Location = New System.Drawing.Point(15, 292)
        lblKontaktperson.Name = "lblKontaktperson"
        lblKontaktperson.Size = New System.Drawing.Size(90, 13)
        lblKontaktperson.TabIndex = 9
        lblKontaktperson.Text = "Kontaktperson"
        '
        'lblFIK
        '
        lblFIK.AutoSize = True
        lblFIK.Location = New System.Drawing.Point(15, 264)
        lblFIK.Name = "lblFIK"
        lblFIK.Size = New System.Drawing.Size(26, 13)
        lblFIK.TabIndex = 8
        lblFIK.Text = "FIK"
        '
        'lblCVR
        '
        lblCVR.AutoSize = True
        lblCVR.Location = New System.Drawing.Point(15, 236)
        lblCVR.Name = "lblCVR"
        lblCVR.Size = New System.Drawing.Size(32, 13)
        lblCVR.TabIndex = 10
        lblCVR.Text = "CVR"
        '
        'lblFax
        '
        lblFax.AutoSize = True
        lblFax.Location = New System.Drawing.Point(15, 208)
        lblFax.Name = "lblFax"
        lblFax.Size = New System.Drawing.Size(27, 13)
        lblFax.TabIndex = 12
        lblFax.Text = "Fax"
        '
        'lblTlf
        '
        lblTlf.AutoSize = True
        lblTlf.Location = New System.Drawing.Point(15, 181)
        lblTlf.Name = "lblTlf"
        lblTlf.Size = New System.Drawing.Size(21, 13)
        lblTlf.TabIndex = 11
        lblTlf.Text = "Tlf"
        '
        'lblAdresse2
        '
        lblAdresse2.AutoSize = True
        lblAdresse2.Location = New System.Drawing.Point(15, 126)
        lblAdresse2.Name = "lblAdresse2"
        lblAdresse2.Size = New System.Drawing.Size(64, 13)
        lblAdresse2.TabIndex = 7
        lblAdresse2.Text = "Adresse 2"
        '
        'lblAdresse
        '
        lblAdresse.AutoSize = True
        lblAdresse.Location = New System.Drawing.Point(15, 98)
        lblAdresse.Name = "lblAdresse"
        lblAdresse.Size = New System.Drawing.Size(53, 13)
        lblAdresse.TabIndex = 3
        lblAdresse.Text = "Adresse"
        '
        'lblNavn
        '
        lblNavn.AutoSize = True
        lblNavn.Location = New System.Drawing.Point(15, 70)
        lblNavn.Name = "lblNavn"
        lblNavn.Size = New System.Drawing.Size(36, 13)
        lblNavn.TabIndex = 2
        lblNavn.Text = "Navn"
        '
        'lblBladID
        '
        lblBladID.AutoSize = True
        lblBladID.Location = New System.Drawing.Point(15, 42)
        lblBladID.Name = "lblBladID"
        lblBladID.Size = New System.Drawing.Size(50, 13)
        lblBladID.TabIndex = 4
        lblBladID.Text = "Blad ID"
        '
        'lblPostNr
        '
        lblPostNr.AutoSize = True
        lblPostNr.Location = New System.Drawing.Point(15, 154)
        lblPostNr.Name = "lblPostNr"
        lblPostNr.Size = New System.Drawing.Size(48, 13)
        lblPostNr.TabIndex = 5
        lblPostNr.Text = "Post Nr"
        '
        'lblMaterialedeadlineRubrik
        '
        lblMaterialedeadlineRubrik.AutoSize = True
        lblMaterialedeadlineRubrik.Location = New System.Drawing.Point(18, 291)
        lblMaterialedeadlineRubrik.Name = "lblMaterialedeadlineRubrik"
        lblMaterialedeadlineRubrik.Size = New System.Drawing.Size(44, 13)
        lblMaterialedeadlineRubrik.TabIndex = 77
        lblMaterialedeadlineRubrik.Text = "Rubrik"
        '
        'lblMaterialedeadlineTekst
        '
        lblMaterialedeadlineTekst.AutoSize = True
        lblMaterialedeadlineTekst.Location = New System.Drawing.Point(18, 263)
        lblMaterialedeadlineTekst.Name = "lblMaterialedeadlineTekst"
        lblMaterialedeadlineTekst.Size = New System.Drawing.Size(38, 13)
        lblMaterialedeadlineTekst.TabIndex = 76
        lblMaterialedeadlineTekst.Text = "Tekst"
        '
        'lblOrdredeadlineRubrik
        '
        lblOrdredeadlineRubrik.AutoSize = True
        lblOrdredeadlineRubrik.Location = New System.Drawing.Point(18, 216)
        lblOrdredeadlineRubrik.Name = "lblOrdredeadlineRubrik"
        lblOrdredeadlineRubrik.Size = New System.Drawing.Size(44, 13)
        lblOrdredeadlineRubrik.TabIndex = 70
        lblOrdredeadlineRubrik.Text = "Rubrik"
        '
        'lblOrdredeadlineTekst
        '
        lblOrdredeadlineTekst.AutoSize = True
        lblOrdredeadlineTekst.Location = New System.Drawing.Point(18, 188)
        lblOrdredeadlineTekst.Name = "lblOrdredeadlineTekst"
        lblOrdredeadlineTekst.Size = New System.Drawing.Size(38, 13)
        lblOrdredeadlineTekst.TabIndex = 71
        lblOrdredeadlineTekst.Text = "Tekst"
        '
        'lblTekniskeDataFormat
        '
        lblTekniskeDataFormat.AutoSize = True
        lblTekniskeDataFormat.Location = New System.Drawing.Point(15, 98)
        lblTekniskeDataFormat.Name = "lblTekniskeDataFormat"
        lblTekniskeDataFormat.Size = New System.Drawing.Size(47, 13)
        lblTekniskeDataFormat.TabIndex = 5
        lblTekniskeDataFormat.Text = "Format"
        '
        'lblUgedag
        '
        lblUgedag.AutoSize = True
        lblUgedag.Location = New System.Drawing.Point(15, 70)
        lblUgedag.Name = "lblUgedag"
        lblUgedag.Size = New System.Drawing.Size(50, 13)
        lblUgedag.TabIndex = 3
        lblUgedag.Text = "Ugedag"
        '
        'lblOplag
        '
        lblOplag.AutoSize = True
        lblOplag.Location = New System.Drawing.Point(15, 42)
        lblOplag.Name = "lblOplag"
        lblOplag.Size = New System.Drawing.Size(40, 13)
        lblOplag.TabIndex = 4
        lblOplag.Text = "Oplag"
        '
        'lblOrdrecheckEmail
        '
        lblOrdrecheckEmail.AutoSize = True
        lblOrdrecheckEmail.Location = New System.Drawing.Point(15, 98)
        lblOrdrecheckEmail.Name = "lblOrdrecheckEmail"
        lblOrdrecheckEmail.Size = New System.Drawing.Size(90, 13)
        lblOrdrecheckEmail.TabIndex = 105
        lblOrdrecheckEmail.Text = "Tjekliste email"
        '
        'lblOrdreEmail
        '
        lblOrdreEmail.AutoSize = True
        lblOrdreEmail.Location = New System.Drawing.Point(15, 42)
        lblOrdreEmail.Name = "lblOrdreEmail"
        lblOrdreEmail.Size = New System.Drawing.Size(75, 13)
        lblOrdreEmail.TabIndex = 106
        lblOrdreEmail.Text = "Ordre email"
        '
        'lblEjerforhold
        '
        lblEjerforhold.AutoSize = True
        lblEjerforhold.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEjerforhold.Location = New System.Drawing.Point(448, 181)
        lblEjerforhold.Name = "lblEjerforhold"
        lblEjerforhold.Size = New System.Drawing.Size(81, 13)
        lblEjerforhold.TabIndex = 120
        lblEjerforhold.Text = "Ejerforhold"
        '
        'lblBilagsbladeEmail
        '
        lblBilagsbladeEmail.AutoSize = True
        lblBilagsbladeEmail.Location = New System.Drawing.Point(15, 204)
        lblBilagsbladeEmail.Name = "lblBilagsbladeEmail"
        lblBilagsbladeEmail.Size = New System.Drawing.Size(107, 13)
        lblBilagsbladeEmail.TabIndex = 133
        lblBilagsbladeEmail.Text = "Bilagsblade email"
        '
        'lblAnnoncekontrolEmail
        '
        lblAnnoncekontrolEmail.AutoSize = True
        lblAnnoncekontrolEmail.Location = New System.Drawing.Point(15, 176)
        lblAnnoncekontrolEmail.Name = "lblAnnoncekontrolEmail"
        lblAnnoncekontrolEmail.Size = New System.Drawing.Size(131, 13)
        lblAnnoncekontrolEmail.TabIndex = 131
        lblAnnoncekontrolEmail.Text = "Annoncekontrol email"
        '
        'lblMaterialeEmail
        '
        lblMaterialeEmail.AutoSize = True
        lblMaterialeEmail.Location = New System.Drawing.Point(15, 70)
        lblMaterialeEmail.Name = "lblMaterialeEmail"
        lblMaterialeEmail.Size = New System.Drawing.Size(94, 13)
        lblMaterialeEmail.TabIndex = 129
        lblMaterialeEmail.Text = "Materiale email"
        '
        'lblDiverseOplysninger
        '
        lblDiverseOplysninger.AutoSize = True
        lblDiverseOplysninger.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDiverseOplysninger.Location = New System.Drawing.Point(448, 294)
        lblDiverseOplysninger.Name = "lblDiverseOplysninger"
        lblDiverseOplysninger.Size = New System.Drawing.Size(138, 13)
        lblDiverseOplysninger.TabIndex = 122
        lblDiverseOplysninger.Text = "Diverse oplysninger"
        '
        'lblFormat
        '
        lblFormat.AutoSize = True
        lblFormat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFormat.Location = New System.Drawing.Point(150, 20)
        lblFormat.Name = "lblFormat"
        lblFormat.Size = New System.Drawing.Size(50, 15)
        lblFormat.TabIndex = 288
        lblFormat.Text = "Format"
        '
        'lblFarveTillæg
        '
        lblFarveTillæg.AutoSize = True
        lblFarveTillæg.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFarveTillæg.Location = New System.Drawing.Point(382, 20)
        lblFarveTillæg.Name = "lblFarveTillæg"
        lblFarveTillæg.Size = New System.Drawing.Size(76, 15)
        lblFarveTillæg.TabIndex = 273
        lblFarveTillæg.Text = "Farvetillæg"
        '
        'lblMmPris
        '
        lblMmPris.AutoSize = True
        lblMmPris.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMmPris.Location = New System.Drawing.Point(294, 20)
        lblMmPris.Name = "lblMmPris"
        lblMmPris.Size = New System.Drawing.Size(59, 15)
        lblMmPris.TabIndex = 275
        lblMmPris.Text = "Mm. pris"
        '
        'lblFormatTil
        '
        lblFormatTil.AutoSize = True
        lblFormatTil.Location = New System.Drawing.Point(201, 36)
        lblFormatTil.Name = "lblFormatTil"
        lblFormatTil.Size = New System.Drawing.Size(17, 15)
        lblFormatTil.TabIndex = 286
        lblFormatTil.Text = "Til"
        '
        'lblFormatFra
        '
        lblFormatFra.AutoSize = True
        lblFormatFra.Location = New System.Drawing.Point(150, 36)
        lblFormatFra.Name = "lblFormatFra"
        lblFormatFra.Size = New System.Drawing.Size(22, 15)
        lblFormatFra.TabIndex = 287
        lblFormatFra.Text = "Fra"
        '
        'lblDækningsområde
        '
        lblDækningsområde.AutoSize = True
        lblDækningsområde.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDækningsområde.Location = New System.Drawing.Point(448, 15)
        lblDækningsområde.Name = "lblDækningsområde"
        lblDækningsområde.Size = New System.Drawing.Size(116, 15)
        lblDækningsområde.TabIndex = 329
        lblDækningsområde.Text = "Dækningsområde"
        '
        'lblGeografiskeData
        '
        lblGeografiskeData.AutoSize = True
        lblGeografiskeData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblGeografiskeData.Location = New System.Drawing.Point(12, 15)
        lblGeografiskeData.Name = "lblGeografiskeData"
        lblGeografiskeData.Size = New System.Drawing.Size(114, 15)
        lblGeografiskeData.TabIndex = 8
        lblGeografiskeData.Text = "Geografiske Data"
        '
        'lblLæsertal
        '
        lblLæsertal.AutoSize = True
        lblLæsertal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLæsertal.Location = New System.Drawing.Point(12, 149)
        lblLæsertal.Name = "lblLæsertal"
        lblLæsertal.Size = New System.Drawing.Size(59, 15)
        lblLæsertal.TabIndex = 7
        lblLæsertal.Text = "Læsertal"
        '
        'lblBeskrivelseAfDækningsområdet
        '
        lblBeskrivelseAfDækningsområdet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblBeskrivelseAfDækningsområdet.Location = New System.Drawing.Point(15, 309)
        lblBeskrivelseAfDækningsområdet.Name = "lblBeskrivelseAfDækningsområdet"
        lblBeskrivelseAfDækningsområdet.Size = New System.Drawing.Size(304, 16)
        lblBeskrivelseAfDækningsområdet.TabIndex = 6
        lblBeskrivelseAfDækningsområdet.Text = "Beskrivelse af dækningsområde / internettet"
        '
        'lblOplysningerTilDLUsHjemmeside
        '
        lblOplysningerTilDLUsHjemmeside.AutoSize = True
        lblOplysningerTilDLUsHjemmeside.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblOplysningerTilDLUsHjemmeside.Location = New System.Drawing.Point(448, 15)
        lblOplysningerTilDLUsHjemmeside.Name = "lblOplysningerTilDLUsHjemmeside"
        lblOplysningerTilDLUsHjemmeside.Size = New System.Drawing.Size(219, 15)
        lblOplysningerTilDLUsHjemmeside.TabIndex = 131
        lblOplysningerTilDLUsHjemmeside.Text = "Oplysninger til DLU's hjemmeside"
        '
        'lblHjemmeside
        '
        lblHjemmeside.AutoSize = True
        lblHjemmeside.Location = New System.Drawing.Point(451, 42)
        lblHjemmeside.Name = "lblHjemmeside"
        lblHjemmeside.Size = New System.Drawing.Size(75, 15)
        lblHjemmeside.TabIndex = 129
        lblHjemmeside.Text = "Hjemmeside"
        '
        'lblRedaktionsEmail
        '
        lblRedaktionsEmail.AutoSize = True
        lblRedaktionsEmail.Location = New System.Drawing.Point(451, 70)
        lblRedaktionsEmail.Name = "lblRedaktionsEmail"
        lblRedaktionsEmail.Size = New System.Drawing.Size(102, 15)
        lblRedaktionsEmail.TabIndex = 128
        lblRedaktionsEmail.Text = "Redaktions email"
        '
        'lblBladetsAnnonceEmail
        '
        lblBladetsAnnonceEmail.AutoSize = True
        lblBladetsAnnonceEmail.Location = New System.Drawing.Point(451, 99)
        lblBladetsAnnonceEmail.Name = "lblBladetsAnnonceEmail"
        lblBladetsAnnonceEmail.Size = New System.Drawing.Size(133, 15)
        lblBladetsAnnonceEmail.TabIndex = 130
        lblBladetsAnnonceEmail.Text = "Bladets annonce email"
        '
        'lblForMateriale
        '
        lblForMateriale.AutoSize = True
        lblForMateriale.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblForMateriale.Location = New System.Drawing.Point(18, 245)
        lblForMateriale.Name = "lblForMateriale"
        lblForMateriale.Size = New System.Drawing.Size(86, 15)
        lblForMateriale.TabIndex = 75
        lblForMateriale.Text = "for Materiale"
        '
        'lblForOrdrer
        '
        lblForOrdrer.AutoSize = True
        lblForOrdrer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblForOrdrer.Location = New System.Drawing.Point(18, 170)
        lblForOrdrer.Name = "lblForOrdrer"
        lblForOrdrer.Size = New System.Drawing.Size(68, 15)
        lblForOrdrer.TabIndex = 74
        lblForOrdrer.Text = "for Ordrer"
        '
        'lblDeadlines
        '
        lblDeadlines.AutoSize = True
        lblDeadlines.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDeadlines.Location = New System.Drawing.Point(12, 149)
        lblDeadlines.Name = "lblDeadlines"
        lblDeadlines.Size = New System.Drawing.Size(67, 15)
        lblDeadlines.TabIndex = 9
        lblDeadlines.Text = "Deadlines"
        '
        'lblTekniskeData
        '
        lblTekniskeData.AutoSize = True
        lblTekniskeData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTekniskeData.Location = New System.Drawing.Point(12, 15)
        lblTekniskeData.Name = "lblTekniskeData"
        lblTekniskeData.Size = New System.Drawing.Size(94, 15)
        lblTekniskeData.TabIndex = 0
        lblTekniskeData.Text = "Tekniske Data"
        '
        'lblBogholderiEmails
        '
        lblBogholderiEmails.AutoSize = True
        lblBogholderiEmails.Location = New System.Drawing.Point(15, 405)
        lblBogholderiEmails.Name = "lblBogholderiEmails"
        lblBogholderiEmails.Size = New System.Drawing.Size(105, 15)
        lblBogholderiEmails.TabIndex = 141
        lblBogholderiEmails.Text = "Bogholderi emails"
        '
        'lblKontaktpersonerEmails
        '
        lblKontaktpersonerEmails.AutoSize = True
        lblKontaktpersonerEmails.Location = New System.Drawing.Point(15, 377)
        lblKontaktpersonerEmails.Name = "lblKontaktpersonerEmails"
        lblKontaktpersonerEmails.Size = New System.Drawing.Size(139, 15)
        lblKontaktpersonerEmails.TabIndex = 139
        lblKontaktpersonerEmails.Text = "Kontaktpersoner emails"
        '
        'lblEmails
        '
        lblEmails.AutoSize = True
        lblEmails.Location = New System.Drawing.Point(15, 349)
        lblEmails.Name = "lblEmails"
        lblEmails.Size = New System.Drawing.Size(41, 15)
        lblEmails.TabIndex = 137
        lblEmails.Text = "Emails"
        '
        'lblOrienteringEmails
        '
        lblOrienteringEmails.AutoSize = True
        lblOrienteringEmails.Location = New System.Drawing.Point(15, 321)
        lblOrienteringEmails.Name = "lblOrienteringEmails"
        lblOrienteringEmails.Size = New System.Drawing.Size(109, 15)
        lblOrienteringEmails.TabIndex = 135
        lblOrienteringEmails.Text = "Orientering emails"
        '
        'lblMedienet
        '
        lblMedienet.AutoSize = True
        lblMedienet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMedienet.Location = New System.Drawing.Point(448, 71)
        lblMedienet.Name = "lblMedienet"
        lblMedienet.Size = New System.Drawing.Size(63, 15)
        lblMedienet.TabIndex = 128
        lblMedienet.Text = "Medienet"
        '
        'lblMedienetID
        '
        lblMedienetID.AutoSize = True
        lblMedienetID.Location = New System.Drawing.Point(451, 98)
        lblMedienetID.Name = "lblMedienetID"
        lblMedienetID.Size = New System.Drawing.Size(73, 15)
        lblMedienetID.TabIndex = 119
        lblMedienetID.Text = "Medienet ID"
        '
        'lblAnsvarligFor
        '
        lblAnsvarligFor.AutoSize = True
        lblAnsvarligFor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAnsvarligFor.Location = New System.Drawing.Point(12, 238)
        lblAnsvarligFor.Name = "lblAnsvarligFor"
        lblAnsvarligFor.Size = New System.Drawing.Size(86, 15)
        lblAnsvarligFor.TabIndex = 117
        lblAnsvarligFor.Text = "Ansvarlig for"
        '
        'lblAnsvarligForStamdataEmail
        '
        lblAnsvarligForStamdataEmail.AutoSize = True
        lblAnsvarligForStamdataEmail.Location = New System.Drawing.Point(15, 266)
        lblAnsvarligForStamdataEmail.Name = "lblAnsvarligForStamdataEmail"
        lblAnsvarligForStamdataEmail.Size = New System.Drawing.Size(94, 15)
        lblAnsvarligForStamdataEmail.TabIndex = 118
        lblAnsvarligForStamdataEmail.Text = "Stamdata email"
        '
        'lblPrisforespørgselEmails
        '
        lblPrisforespørgselEmails.AutoSize = True
        lblPrisforespørgselEmails.Location = New System.Drawing.Point(15, 293)
        lblPrisforespørgselEmails.Name = "lblPrisforespørgselEmails"
        lblPrisforespørgselEmails.Size = New System.Drawing.Size(135, 15)
        lblPrisforespørgselEmails.TabIndex = 114
        lblPrisforespørgselEmails.Text = "Prisforespørgsel emails"
        '
        'lblUdsending
        '
        lblUdsending.AutoSize = True
        lblUdsending.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUdsending.Location = New System.Drawing.Point(12, 15)
        lblUdsending.Name = "lblUdsending"
        lblUdsending.Size = New System.Drawing.Size(71, 15)
        lblUdsending.TabIndex = 111
        lblUdsending.Text = "Udsending"
        '
        'lblUdsendelsesTidspunkt
        '
        lblUdsendelsesTidspunkt.Location = New System.Drawing.Point(15, 124)
        lblUdsendelsesTidspunkt.Name = "lblUdsendelsesTidspunkt"
        lblUdsendelsesTidspunkt.Size = New System.Drawing.Size(137, 26)
        lblUdsendelsesTidspunkt.TabIndex = 113
        lblUdsendelsesTidspunkt.Text = "Tjekliste udsendelses tidspunkt"
        '
        'lblPrisLister
        '
        lblPrisLister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        lblPrisLister.AutoSize = True
        lblPrisLister.Location = New System.Drawing.Point(15, 276)
        lblPrisLister.Name = "lblPrisLister"
        lblPrisLister.Size = New System.Drawing.Size(56, 13)
        lblPrisLister.TabIndex = 360
        lblPrisLister.Text = "Prislister"
        '
        'lblPrislistePrUge
        '
        lblPrislistePrUge.AutoSize = True
        lblPrislistePrUge.Location = New System.Drawing.Point(264, 22)
        lblPrislistePrUge.Name = "lblPrislistePrUge"
        lblPrislistePrUge.Size = New System.Drawing.Size(97, 13)
        lblPrislistePrUge.TabIndex = 359
        lblPrislistePrUge.Text = "Prisliste pr. Uge"
        '
        'lblÅr
        '
        lblÅr.AutoSize = True
        lblÅr.Location = New System.Drawing.Point(15, 22)
        lblÅr.Name = "lblÅr"
        lblÅr.Size = New System.Drawing.Size(20, 13)
        lblÅr.TabIndex = 357
        lblÅr.Text = "År"
        '
        'lblFarveRabatMåGives
        '
        lblFarveRabatMåGives.AutoSize = True
        lblFarveRabatMåGives.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFarveRabatMåGives.Location = New System.Drawing.Point(699, 20)
        lblFarveRabatMåGives.Name = "lblFarveRabatMåGives"
        lblFarveRabatMåGives.Size = New System.Drawing.Size(130, 15)
        lblFarveRabatMåGives.TabIndex = 365
        lblFarveRabatMåGives.Text = "Farverabat må ydes"
        '
        'lblKoncern
        '
        lblKoncern.AutoSize = True
        lblKoncern.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblKoncern.Location = New System.Drawing.Point(448, 241)
        lblKoncern.Name = "lblKoncern"
        lblKoncern.Size = New System.Drawing.Size(60, 13)
        lblKoncern.TabIndex = 123
        lblKoncern.Text = "Koncern"
        '
        'cboPostNrDækning
        '
        Me.cboPostNrDækning.DataSource = Me.TblPostNrBindingSource
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboPostNrDækning.DisplayLayout.Appearance = Appearance1
        Me.cboPostNrDækning.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridColumn32.Header.VisiblePosition = 1
        UltraGridColumn33.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn31, UltraGridColumn32, UltraGridColumn33})
        Me.cboPostNrDækning.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cboPostNrDækning.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboPostNrDækning.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPostNrDækning.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPostNrDækning.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.cboPostNrDækning.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPostNrDækning.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.cboPostNrDækning.DisplayLayout.MaxColScrollRegions = 1
        Me.cboPostNrDækning.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboPostNrDækning.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboPostNrDækning.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.cboPostNrDækning.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboPostNrDækning.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.cboPostNrDækning.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboPostNrDækning.DisplayLayout.Override.CellAppearance = Appearance8
        Me.cboPostNrDækning.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboPostNrDækning.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPostNrDækning.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.cboPostNrDækning.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.cboPostNrDækning.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboPostNrDækning.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.cboPostNrDækning.DisplayLayout.Override.RowAppearance = Appearance11
        Me.cboPostNrDækning.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboPostNrDækning.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.cboPostNrDækning.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboPostNrDækning.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboPostNrDækning.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.cboPostNrDækning.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboPostNrDækning.DisplayMember = "PostNr"
        Me.cboPostNrDækning.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPostNrDækning.LimitToList = True
        Me.cboPostNrDækning.Location = New System.Drawing.Point(128, 419)
        Me.cboPostNrDækning.Name = "cboPostNrDækning"
        Me.cboPostNrDækning.Size = New System.Drawing.Size(100, 23)
        Me.cboPostNrDækning.TabIndex = 342
        Me.cboPostNrDækning.ValueMember = "PostNr"
        Me.cboPostNrDækning.Visible = False
        '
        'TblPostNrBindingSource
        '
        Me.TblPostNrBindingSource.DataMember = "tblPostNr"
        Me.TblPostNrBindingSource.DataSource = Me.PostNrListeDropdown
        '
        'PostNrListeDropdown
        '
        Me.PostNrListeDropdown.DataSetName = "PostNrListeDropdown"
        Me.PostNrListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboPrislisterPrÅr
        '
        Me.cboPrislisterPrÅr.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        Me.cboPrislisterPrÅr.AutoSize = False
        Me.cboPrislisterPrÅr.DataSource = Me.FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboPrislisterPrÅr.DisplayLayout.Appearance = Appearance13
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn34.Header.VisiblePosition = 0
        UltraGridColumn34.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 1
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 2
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn34, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64})
        Me.cboPrislisterPrÅr.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cboPrislisterPrÅr.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboPrislisterPrÅr.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPrislisterPrÅr.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPrislisterPrÅr.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.cboPrislisterPrÅr.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPrislisterPrÅr.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.cboPrislisterPrÅr.DisplayLayout.MaxColScrollRegions = 1
        Me.cboPrislisterPrÅr.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboPrislisterPrÅr.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboPrislisterPrÅr.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.cboPrislisterPrÅr.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboPrislisterPrÅr.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.cboPrislisterPrÅr.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboPrislisterPrÅr.DisplayLayout.Override.CellAppearance = Appearance20
        Me.cboPrislisterPrÅr.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboPrislisterPrÅr.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPrislisterPrÅr.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.cboPrislisterPrÅr.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.cboPrislisterPrÅr.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboPrislisterPrÅr.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.cboPrislisterPrÅr.DisplayLayout.Override.RowAppearance = Appearance23
        Me.cboPrislisterPrÅr.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboPrislisterPrÅr.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.cboPrislisterPrÅr.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboPrislisterPrÅr.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboPrislisterPrÅr.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboPrislisterPrÅr.DisplayMember = "PrislisteNavn"
        Me.cboPrislisterPrÅr.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboPrislisterPrÅr.Location = New System.Drawing.Point(77, 136)
        Me.cboPrislisterPrÅr.Name = "cboPrislisterPrÅr"
        Me.cboPrislisterPrÅr.Size = New System.Drawing.Size(100, 23)
        Me.cboPrislisterPrÅr.TabIndex = 363
        Me.cboPrislisterPrÅr.ValueMember = "PrislisteID"
        Me.cboPrislisterPrÅr.Visible = False
        '
        'FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource
        '
        Me.FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource.DataMember = "FK_tblPrislisterPrBladPrÅr_tblBladStamdata"
        Me.FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource.DataSource = Me.TblBladStamdataBindingSource
        '
        'tbpTekstside
        '
        Me.tbpTekstside.Controls.Add(Me.grpPriser)
        Me.tbpTekstside.Location = New System.Drawing.Point(1, 20)
        Me.tbpTekstside.Name = "tbpTekstside"
        Me.tbpTekstside.Size = New System.Drawing.Size(856, 309)
        '
        'grpPriser
        '
        Me.grpPriser.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Header3D
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMax8)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMin8)
        Me.grpPriser.Controls.Add(Me.txt4Farvertillæg8)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMax8)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMin8)
        Me.grpPriser.Controls.Add(Me.txtMmPris8)
        Me.grpPriser.Controls.Add(Me.txtFormatTil8)
        Me.grpPriser.Controls.Add(Me.txtFormatFra8)
        Me.grpPriser.Controls.Add(Me.txt1Farvetillæg8)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMax7)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMin7)
        Me.grpPriser.Controls.Add(Me.txt4Farvertillæg7)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMax7)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMin7)
        Me.grpPriser.Controls.Add(Me.txtMmPris7)
        Me.grpPriser.Controls.Add(Me.txtFormatTil7)
        Me.grpPriser.Controls.Add(Me.txtFormatFra7)
        Me.grpPriser.Controls.Add(Me.txt1Farvetillæg7)
        Me.grpPriser.Controls.Add(Me.optFarverabatMåGives)
        Me.grpPriser.Controls.Add(lblFarveRabatMåGives)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMax6)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMin6)
        Me.grpPriser.Controls.Add(Me.txt4Farvertillæg6)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMax6)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMin6)
        Me.grpPriser.Controls.Add(Me.txtMmPris6)
        Me.grpPriser.Controls.Add(Me.txtFormatTil6)
        Me.grpPriser.Controls.Add(Me.txtFormatFra6)
        Me.grpPriser.Controls.Add(Me.txt1Farvetillæg6)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMax5)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMin5)
        Me.grpPriser.Controls.Add(Me.txt4Farvertillæg5)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMax5)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMin5)
        Me.grpPriser.Controls.Add(Me.txtMmPris5)
        Me.grpPriser.Controls.Add(Me.txtFormatTil5)
        Me.grpPriser.Controls.Add(Me.txtFormatFra5)
        Me.grpPriser.Controls.Add(Me.txt1Farvetillæg5)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMax4)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMin4)
        Me.grpPriser.Controls.Add(Me.txt4Farvertillæg4)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMax4)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMin4)
        Me.grpPriser.Controls.Add(Me.txtMmPris4)
        Me.grpPriser.Controls.Add(Me.txtFormatTil4)
        Me.grpPriser.Controls.Add(Me.txtFormatFra4)
        Me.grpPriser.Controls.Add(Me.txt1Farvetillæg4)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMax3)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMin3)
        Me.grpPriser.Controls.Add(Me.txt4Farvertillæg3)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMax3)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMin3)
        Me.grpPriser.Controls.Add(Me.txtMmPris3)
        Me.grpPriser.Controls.Add(Me.txtFormatTil3)
        Me.grpPriser.Controls.Add(Me.txtFormatFra3)
        Me.grpPriser.Controls.Add(Me.txt1Farvetillæg3)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMax2)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMin2)
        Me.grpPriser.Controls.Add(Me.txt4Farvertillæg2)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMax2)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMin2)
        Me.grpPriser.Controls.Add(Me.txtMmPris2)
        Me.grpPriser.Controls.Add(Me.txtFormatTil2)
        Me.grpPriser.Controls.Add(Me.txtFormatFra2)
        Me.grpPriser.Controls.Add(Me.txt1Farvetillæg2)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMax1)
        Me.grpPriser.Controls.Add(Me.txt4FarvertillægMin1)
        Me.grpPriser.Controls.Add(Me.txt4Farvertillæg1)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMax1)
        Me.grpPriser.Controls.Add(Me.txt1FarvetillægMin1)
        Me.grpPriser.Controls.Add(Me.txtMmPris1)
        Me.grpPriser.Controls.Add(Me.txtFormatTil1)
        Me.grpPriser.Controls.Add(Me.txtFormatFra1)
        Me.grpPriser.Controls.Add(Me.txt1Farvetillæg1)
        Me.grpPriser.Controls.Add(lblFormat)
        Me.grpPriser.Controls.Add(lblFarveTillæg)
        Me.grpPriser.Controls.Add(Me.lbl4FarvertillægMax)
        Me.grpPriser.Controls.Add(lblMmPris)
        Me.grpPriser.Controls.Add(Me.lbl4Farver)
        Me.grpPriser.Controls.Add(Me.lbl1Farve)
        Me.grpPriser.Controls.Add(lblFormatTil)
        Me.grpPriser.Controls.Add(lblFormatFra)
        Me.grpPriser.Controls.Add(Me.lbl1FarvetillægMin)
        Me.grpPriser.Controls.Add(Me.lbl4FarvertillægMin)
        Me.grpPriser.Controls.Add(Me.lbl1FarvetillægMax)
        Me.grpPriser.Location = New System.Drawing.Point(12, 3)
        Me.grpPriser.Name = "grpPriser"
        Me.grpPriser.Size = New System.Drawing.Size(833, 291)
        Me.grpPriser.TabIndex = 0
        Me.grpPriser.Text = "Priser"
        '
        'txt4FarvertillægMax8
        '
        Me.txt4FarvertillægMax8.Enabled = False
        Me.txt4FarvertillægMax8.Location = New System.Drawing.Point(646, 245)
        Me.txt4FarvertillægMax8.Name = "txt4FarvertillægMax8"
        Me.txt4FarvertillægMax8.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMax8.TabIndex = 386
        Me.txt4FarvertillægMax8.Visible = False
        '
        'txt4FarvertillægMin8
        '
        Me.txt4FarvertillægMin8.Enabled = False
        Me.txt4FarvertillægMin8.Location = New System.Drawing.Point(595, 245)
        Me.txt4FarvertillægMin8.Name = "txt4FarvertillægMin8"
        Me.txt4FarvertillægMin8.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMin8.TabIndex = 385
        Me.txt4FarvertillægMin8.Visible = False
        '
        'txt4Farvertillæg8
        '
        Me.txt4Farvertillæg8.Location = New System.Drawing.Point(544, 245)
        Me.txt4Farvertillæg8.Name = "txt4Farvertillæg8"
        Me.txt4Farvertillæg8.Size = New System.Drawing.Size(45, 22)
        Me.txt4Farvertillæg8.TabIndex = 384
        Me.txt4Farvertillæg8.Visible = False
        '
        'txt1FarvetillægMax8
        '
        Me.txt1FarvetillægMax8.Enabled = False
        Me.txt1FarvetillægMax8.Location = New System.Drawing.Point(484, 245)
        Me.txt1FarvetillægMax8.Name = "txt1FarvetillægMax8"
        Me.txt1FarvetillægMax8.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMax8.TabIndex = 383
        Me.txt1FarvetillægMax8.Visible = False
        '
        'txt1FarvetillægMin8
        '
        Me.txt1FarvetillægMin8.Enabled = False
        Me.txt1FarvetillægMin8.Location = New System.Drawing.Point(433, 245)
        Me.txt1FarvetillægMin8.Name = "txt1FarvetillægMin8"
        Me.txt1FarvetillægMin8.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMin8.TabIndex = 382
        Me.txt1FarvetillægMin8.Visible = False
        '
        'txtMmPris8
        '
        Me.txtMmPris8.Location = New System.Drawing.Point(294, 245)
        Me.txtMmPris8.Name = "txtMmPris8"
        Me.txtMmPris8.Size = New System.Drawing.Size(45, 22)
        Me.txtMmPris8.TabIndex = 380
        Me.txtMmPris8.Visible = False
        '
        'txtFormatTil8
        '
        Me.txtFormatTil8.Location = New System.Drawing.Point(201, 245)
        Me.txtFormatTil8.Name = "txtFormatTil8"
        Me.txtFormatTil8.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatTil8.TabIndex = 379
        Me.txtFormatTil8.Visible = False
        '
        'txtFormatFra8
        '
        Me.txtFormatFra8.Location = New System.Drawing.Point(150, 245)
        Me.txtFormatFra8.Name = "txtFormatFra8"
        Me.txtFormatFra8.ReadOnly = True
        Me.txtFormatFra8.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatFra8.TabIndex = 387
        Me.txtFormatFra8.Visible = False
        '
        'txt1Farvetillæg8
        '
        Me.txt1Farvetillæg8.Location = New System.Drawing.Point(382, 245)
        Me.txt1Farvetillæg8.Name = "txt1Farvetillæg8"
        Me.txt1Farvetillæg8.Size = New System.Drawing.Size(45, 22)
        Me.txt1Farvetillæg8.TabIndex = 381
        Me.txt1Farvetillæg8.Visible = False
        '
        'txt4FarvertillægMax7
        '
        Me.txt4FarvertillægMax7.Enabled = False
        Me.txt4FarvertillægMax7.Location = New System.Drawing.Point(646, 217)
        Me.txt4FarvertillægMax7.Name = "txt4FarvertillægMax7"
        Me.txt4FarvertillægMax7.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMax7.TabIndex = 377
        Me.txt4FarvertillægMax7.Visible = False
        '
        'txt4FarvertillægMin7
        '
        Me.txt4FarvertillægMin7.Enabled = False
        Me.txt4FarvertillægMin7.Location = New System.Drawing.Point(595, 217)
        Me.txt4FarvertillægMin7.Name = "txt4FarvertillægMin7"
        Me.txt4FarvertillægMin7.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMin7.TabIndex = 376
        Me.txt4FarvertillægMin7.Visible = False
        '
        'txt4Farvertillæg7
        '
        Me.txt4Farvertillæg7.Location = New System.Drawing.Point(544, 217)
        Me.txt4Farvertillæg7.Name = "txt4Farvertillæg7"
        Me.txt4Farvertillæg7.Size = New System.Drawing.Size(45, 22)
        Me.txt4Farvertillæg7.TabIndex = 375
        Me.txt4Farvertillæg7.Visible = False
        '
        'txt1FarvetillægMax7
        '
        Me.txt1FarvetillægMax7.Enabled = False
        Me.txt1FarvetillægMax7.Location = New System.Drawing.Point(484, 217)
        Me.txt1FarvetillægMax7.Name = "txt1FarvetillægMax7"
        Me.txt1FarvetillægMax7.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMax7.TabIndex = 374
        Me.txt1FarvetillægMax7.Visible = False
        '
        'txt1FarvetillægMin7
        '
        Me.txt1FarvetillægMin7.Enabled = False
        Me.txt1FarvetillægMin7.Location = New System.Drawing.Point(433, 217)
        Me.txt1FarvetillægMin7.Name = "txt1FarvetillægMin7"
        Me.txt1FarvetillægMin7.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMin7.TabIndex = 373
        Me.txt1FarvetillægMin7.Visible = False
        '
        'txtMmPris7
        '
        Me.txtMmPris7.Location = New System.Drawing.Point(294, 217)
        Me.txtMmPris7.Name = "txtMmPris7"
        Me.txtMmPris7.Size = New System.Drawing.Size(45, 22)
        Me.txtMmPris7.TabIndex = 371
        Me.txtMmPris7.Visible = False
        '
        'txtFormatTil7
        '
        Me.txtFormatTil7.Location = New System.Drawing.Point(201, 217)
        Me.txtFormatTil7.Name = "txtFormatTil7"
        Me.txtFormatTil7.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatTil7.TabIndex = 370
        Me.txtFormatTil7.Visible = False
        '
        'txtFormatFra7
        '
        Me.txtFormatFra7.Location = New System.Drawing.Point(150, 217)
        Me.txtFormatFra7.Name = "txtFormatFra7"
        Me.txtFormatFra7.ReadOnly = True
        Me.txtFormatFra7.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatFra7.TabIndex = 378
        Me.txtFormatFra7.Visible = False
        '
        'txt1Farvetillæg7
        '
        Me.txt1Farvetillæg7.Location = New System.Drawing.Point(382, 217)
        Me.txt1Farvetillæg7.Name = "txt1Farvetillæg7"
        Me.txt1Farvetillæg7.Size = New System.Drawing.Size(45, 22)
        Me.txt1Farvetillæg7.TabIndex = 372
        Me.txt1Farvetillæg7.Visible = False
        '
        'optFarverabatMåGives
        '
        Me.optFarverabatMåGives.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "MåGiveFarveRabat", True))
        ValueListItem1.DataValue = True
        ValueListItem1.DisplayText = "Ja"
        ValueListItem2.DataValue = False
        ValueListItem2.DisplayText = "Nej"
        Me.optFarverabatMåGives.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.optFarverabatMåGives.ItemSpacingHorizontal = 35
        Me.optFarverabatMåGives.Location = New System.Drawing.Point(711, 36)
        Me.optFarverabatMåGives.Name = "optFarverabatMåGives"
        Me.optFarverabatMåGives.Size = New System.Drawing.Size(118, 22)
        Me.optFarverabatMåGives.TabIndex = 369
        '
        'txt4FarvertillægMax6
        '
        Me.txt4FarvertillægMax6.Enabled = False
        Me.txt4FarvertillægMax6.Location = New System.Drawing.Point(646, 189)
        Me.txt4FarvertillægMax6.Name = "txt4FarvertillægMax6"
        Me.txt4FarvertillægMax6.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMax6.TabIndex = 47
        Me.txt4FarvertillægMax6.Visible = False
        '
        'txt4FarvertillægMin6
        '
        Me.txt4FarvertillægMin6.Enabled = False
        Me.txt4FarvertillægMin6.Location = New System.Drawing.Point(595, 189)
        Me.txt4FarvertillægMin6.Name = "txt4FarvertillægMin6"
        Me.txt4FarvertillægMin6.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMin6.TabIndex = 46
        Me.txt4FarvertillægMin6.Visible = False
        '
        'txt4Farvertillæg6
        '
        Me.txt4Farvertillæg6.Location = New System.Drawing.Point(544, 189)
        Me.txt4Farvertillæg6.Name = "txt4Farvertillæg6"
        Me.txt4Farvertillæg6.Size = New System.Drawing.Size(45, 22)
        Me.txt4Farvertillæg6.TabIndex = 45
        Me.txt4Farvertillæg6.Visible = False
        '
        'txt1FarvetillægMax6
        '
        Me.txt1FarvetillægMax6.Enabled = False
        Me.txt1FarvetillægMax6.Location = New System.Drawing.Point(484, 189)
        Me.txt1FarvetillægMax6.Name = "txt1FarvetillægMax6"
        Me.txt1FarvetillægMax6.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMax6.TabIndex = 44
        Me.txt1FarvetillægMax6.Visible = False
        '
        'txt1FarvetillægMin6
        '
        Me.txt1FarvetillægMin6.Enabled = False
        Me.txt1FarvetillægMin6.Location = New System.Drawing.Point(433, 189)
        Me.txt1FarvetillægMin6.Name = "txt1FarvetillægMin6"
        Me.txt1FarvetillægMin6.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMin6.TabIndex = 43
        Me.txt1FarvetillægMin6.Visible = False
        '
        'txtMmPris6
        '
        Me.txtMmPris6.Location = New System.Drawing.Point(294, 189)
        Me.txtMmPris6.Name = "txtMmPris6"
        Me.txtMmPris6.Size = New System.Drawing.Size(45, 22)
        Me.txtMmPris6.TabIndex = 41
        Me.txtMmPris6.Visible = False
        '
        'txtFormatTil6
        '
        Me.txtFormatTil6.Location = New System.Drawing.Point(201, 189)
        Me.txtFormatTil6.Name = "txtFormatTil6"
        Me.txtFormatTil6.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatTil6.TabIndex = 40
        Me.txtFormatTil6.Visible = False
        '
        'txtFormatFra6
        '
        Me.txtFormatFra6.Location = New System.Drawing.Point(150, 189)
        Me.txtFormatFra6.Name = "txtFormatFra6"
        Me.txtFormatFra6.ReadOnly = True
        Me.txtFormatFra6.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatFra6.TabIndex = 368
        Me.txtFormatFra6.Visible = False
        '
        'txt1Farvetillæg6
        '
        Me.txt1Farvetillæg6.Location = New System.Drawing.Point(382, 189)
        Me.txt1Farvetillæg6.Name = "txt1Farvetillæg6"
        Me.txt1Farvetillæg6.Size = New System.Drawing.Size(45, 22)
        Me.txt1Farvetillæg6.TabIndex = 42
        Me.txt1Farvetillæg6.Visible = False
        '
        'txt4FarvertillægMax5
        '
        Me.txt4FarvertillægMax5.Enabled = False
        Me.txt4FarvertillægMax5.Location = New System.Drawing.Point(646, 161)
        Me.txt4FarvertillægMax5.Name = "txt4FarvertillægMax5"
        Me.txt4FarvertillægMax5.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMax5.TabIndex = 39
        Me.txt4FarvertillægMax5.Visible = False
        '
        'txt4FarvertillægMin5
        '
        Me.txt4FarvertillægMin5.Enabled = False
        Me.txt4FarvertillægMin5.Location = New System.Drawing.Point(595, 161)
        Me.txt4FarvertillægMin5.Name = "txt4FarvertillægMin5"
        Me.txt4FarvertillægMin5.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMin5.TabIndex = 38
        Me.txt4FarvertillægMin5.Visible = False
        '
        'txt4Farvertillæg5
        '
        Me.txt4Farvertillæg5.Location = New System.Drawing.Point(544, 161)
        Me.txt4Farvertillæg5.Name = "txt4Farvertillæg5"
        Me.txt4Farvertillæg5.Size = New System.Drawing.Size(45, 22)
        Me.txt4Farvertillæg5.TabIndex = 37
        Me.txt4Farvertillæg5.Visible = False
        '
        'txt1FarvetillægMax5
        '
        Me.txt1FarvetillægMax5.Enabled = False
        Me.txt1FarvetillægMax5.Location = New System.Drawing.Point(484, 161)
        Me.txt1FarvetillægMax5.Name = "txt1FarvetillægMax5"
        Me.txt1FarvetillægMax5.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMax5.TabIndex = 36
        Me.txt1FarvetillægMax5.Visible = False
        '
        'txt1FarvetillægMin5
        '
        Me.txt1FarvetillægMin5.Enabled = False
        Me.txt1FarvetillægMin5.Location = New System.Drawing.Point(433, 161)
        Me.txt1FarvetillægMin5.Name = "txt1FarvetillægMin5"
        Me.txt1FarvetillægMin5.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMin5.TabIndex = 35
        Me.txt1FarvetillægMin5.Visible = False
        '
        'txtMmPris5
        '
        Me.txtMmPris5.Location = New System.Drawing.Point(294, 161)
        Me.txtMmPris5.Name = "txtMmPris5"
        Me.txtMmPris5.Size = New System.Drawing.Size(45, 22)
        Me.txtMmPris5.TabIndex = 33
        Me.txtMmPris5.Visible = False
        '
        'txtFormatTil5
        '
        Me.txtFormatTil5.Location = New System.Drawing.Point(201, 161)
        Me.txtFormatTil5.Name = "txtFormatTil5"
        Me.txtFormatTil5.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatTil5.TabIndex = 32
        Me.txtFormatTil5.Visible = False
        '
        'txtFormatFra5
        '
        Me.txtFormatFra5.Location = New System.Drawing.Point(150, 161)
        Me.txtFormatFra5.Name = "txtFormatFra5"
        Me.txtFormatFra5.ReadOnly = True
        Me.txtFormatFra5.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatFra5.TabIndex = 354
        Me.txtFormatFra5.Visible = False
        '
        'txt1Farvetillæg5
        '
        Me.txt1Farvetillæg5.Location = New System.Drawing.Point(382, 161)
        Me.txt1Farvetillæg5.Name = "txt1Farvetillæg5"
        Me.txt1Farvetillæg5.Size = New System.Drawing.Size(45, 22)
        Me.txt1Farvetillæg5.TabIndex = 34
        Me.txt1Farvetillæg5.Visible = False
        '
        'txt4FarvertillægMax4
        '
        Me.txt4FarvertillægMax4.Enabled = False
        Me.txt4FarvertillægMax4.Location = New System.Drawing.Point(646, 133)
        Me.txt4FarvertillægMax4.Name = "txt4FarvertillægMax4"
        Me.txt4FarvertillægMax4.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMax4.TabIndex = 31
        Me.txt4FarvertillægMax4.Visible = False
        '
        'txt4FarvertillægMin4
        '
        Me.txt4FarvertillægMin4.Enabled = False
        Me.txt4FarvertillægMin4.Location = New System.Drawing.Point(595, 133)
        Me.txt4FarvertillægMin4.Name = "txt4FarvertillægMin4"
        Me.txt4FarvertillægMin4.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMin4.TabIndex = 30
        Me.txt4FarvertillægMin4.Visible = False
        '
        'txt4Farvertillæg4
        '
        Me.txt4Farvertillæg4.Location = New System.Drawing.Point(544, 133)
        Me.txt4Farvertillæg4.Name = "txt4Farvertillæg4"
        Me.txt4Farvertillæg4.Size = New System.Drawing.Size(45, 22)
        Me.txt4Farvertillæg4.TabIndex = 29
        Me.txt4Farvertillæg4.Visible = False
        '
        'txt1FarvetillægMax4
        '
        Me.txt1FarvetillægMax4.Enabled = False
        Me.txt1FarvetillægMax4.Location = New System.Drawing.Point(484, 133)
        Me.txt1FarvetillægMax4.Name = "txt1FarvetillægMax4"
        Me.txt1FarvetillægMax4.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMax4.TabIndex = 28
        Me.txt1FarvetillægMax4.Visible = False
        '
        'txt1FarvetillægMin4
        '
        Me.txt1FarvetillægMin4.Enabled = False
        Me.txt1FarvetillægMin4.Location = New System.Drawing.Point(433, 133)
        Me.txt1FarvetillægMin4.Name = "txt1FarvetillægMin4"
        Me.txt1FarvetillægMin4.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMin4.TabIndex = 27
        Me.txt1FarvetillægMin4.Visible = False
        '
        'txtMmPris4
        '
        Me.txtMmPris4.Location = New System.Drawing.Point(294, 133)
        Me.txtMmPris4.Name = "txtMmPris4"
        Me.txtMmPris4.Size = New System.Drawing.Size(45, 22)
        Me.txtMmPris4.TabIndex = 25
        Me.txtMmPris4.Visible = False
        '
        'txtFormatTil4
        '
        Me.txtFormatTil4.Location = New System.Drawing.Point(201, 133)
        Me.txtFormatTil4.Name = "txtFormatTil4"
        Me.txtFormatTil4.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatTil4.TabIndex = 24
        Me.txtFormatTil4.Visible = False
        '
        'txtFormatFra4
        '
        Me.txtFormatFra4.Location = New System.Drawing.Point(150, 133)
        Me.txtFormatFra4.Name = "txtFormatFra4"
        Me.txtFormatFra4.ReadOnly = True
        Me.txtFormatFra4.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatFra4.TabIndex = 340
        Me.txtFormatFra4.Visible = False
        '
        'txt1Farvetillæg4
        '
        Me.txt1Farvetillæg4.Location = New System.Drawing.Point(382, 133)
        Me.txt1Farvetillæg4.Name = "txt1Farvetillæg4"
        Me.txt1Farvetillæg4.Size = New System.Drawing.Size(45, 22)
        Me.txt1Farvetillæg4.TabIndex = 26
        Me.txt1Farvetillæg4.Visible = False
        '
        'txt4FarvertillægMax3
        '
        Me.txt4FarvertillægMax3.Enabled = False
        Me.txt4FarvertillægMax3.Location = New System.Drawing.Point(646, 105)
        Me.txt4FarvertillægMax3.Name = "txt4FarvertillægMax3"
        Me.txt4FarvertillægMax3.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMax3.TabIndex = 23
        Me.txt4FarvertillægMax3.Visible = False
        '
        'txt4FarvertillægMin3
        '
        Me.txt4FarvertillægMin3.Enabled = False
        Me.txt4FarvertillægMin3.Location = New System.Drawing.Point(595, 105)
        Me.txt4FarvertillægMin3.Name = "txt4FarvertillægMin3"
        Me.txt4FarvertillægMin3.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMin3.TabIndex = 22
        Me.txt4FarvertillægMin3.Visible = False
        '
        'txt4Farvertillæg3
        '
        Me.txt4Farvertillæg3.Location = New System.Drawing.Point(544, 105)
        Me.txt4Farvertillæg3.Name = "txt4Farvertillæg3"
        Me.txt4Farvertillæg3.Size = New System.Drawing.Size(45, 22)
        Me.txt4Farvertillæg3.TabIndex = 21
        Me.txt4Farvertillæg3.Visible = False
        '
        'txt1FarvetillægMax3
        '
        Me.txt1FarvetillægMax3.Enabled = False
        Me.txt1FarvetillægMax3.Location = New System.Drawing.Point(484, 105)
        Me.txt1FarvetillægMax3.Name = "txt1FarvetillægMax3"
        Me.txt1FarvetillægMax3.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMax3.TabIndex = 20
        Me.txt1FarvetillægMax3.Visible = False
        '
        'txt1FarvetillægMin3
        '
        Me.txt1FarvetillægMin3.Enabled = False
        Me.txt1FarvetillægMin3.Location = New System.Drawing.Point(433, 105)
        Me.txt1FarvetillægMin3.Name = "txt1FarvetillægMin3"
        Me.txt1FarvetillægMin3.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMin3.TabIndex = 19
        Me.txt1FarvetillægMin3.Visible = False
        '
        'txtMmPris3
        '
        Me.txtMmPris3.Location = New System.Drawing.Point(294, 105)
        Me.txtMmPris3.Name = "txtMmPris3"
        Me.txtMmPris3.Size = New System.Drawing.Size(45, 22)
        Me.txtMmPris3.TabIndex = 17
        Me.txtMmPris3.Visible = False
        '
        'txtFormatTil3
        '
        Me.txtFormatTil3.Location = New System.Drawing.Point(201, 105)
        Me.txtFormatTil3.Name = "txtFormatTil3"
        Me.txtFormatTil3.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatTil3.TabIndex = 16
        Me.txtFormatTil3.Visible = False
        '
        'txtFormatFra3
        '
        Me.txtFormatFra3.Location = New System.Drawing.Point(150, 105)
        Me.txtFormatFra3.Name = "txtFormatFra3"
        Me.txtFormatFra3.ReadOnly = True
        Me.txtFormatFra3.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatFra3.TabIndex = 326
        Me.txtFormatFra3.Visible = False
        '
        'txt1Farvetillæg3
        '
        Me.txt1Farvetillæg3.Location = New System.Drawing.Point(382, 105)
        Me.txt1Farvetillæg3.Name = "txt1Farvetillæg3"
        Me.txt1Farvetillæg3.Size = New System.Drawing.Size(45, 22)
        Me.txt1Farvetillæg3.TabIndex = 18
        Me.txt1Farvetillæg3.Visible = False
        '
        'txt4FarvertillægMax2
        '
        Me.txt4FarvertillægMax2.Enabled = False
        Me.txt4FarvertillægMax2.Location = New System.Drawing.Point(646, 77)
        Me.txt4FarvertillægMax2.Name = "txt4FarvertillægMax2"
        Me.txt4FarvertillægMax2.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMax2.TabIndex = 15
        Me.txt4FarvertillægMax2.Visible = False
        '
        'txt4FarvertillægMin2
        '
        Me.txt4FarvertillægMin2.Enabled = False
        Me.txt4FarvertillægMin2.Location = New System.Drawing.Point(595, 77)
        Me.txt4FarvertillægMin2.Name = "txt4FarvertillægMin2"
        Me.txt4FarvertillægMin2.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMin2.TabIndex = 14
        Me.txt4FarvertillægMin2.Visible = False
        '
        'txt4Farvertillæg2
        '
        Me.txt4Farvertillæg2.Location = New System.Drawing.Point(544, 77)
        Me.txt4Farvertillæg2.Name = "txt4Farvertillæg2"
        Me.txt4Farvertillæg2.Size = New System.Drawing.Size(45, 22)
        Me.txt4Farvertillæg2.TabIndex = 13
        Me.txt4Farvertillæg2.Visible = False
        '
        'txt1FarvetillægMax2
        '
        Me.txt1FarvetillægMax2.Enabled = False
        Me.txt1FarvetillægMax2.Location = New System.Drawing.Point(484, 77)
        Me.txt1FarvetillægMax2.Name = "txt1FarvetillægMax2"
        Me.txt1FarvetillægMax2.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMax2.TabIndex = 12
        Me.txt1FarvetillægMax2.Visible = False
        '
        'txt1FarvetillægMin2
        '
        Me.txt1FarvetillægMin2.Enabled = False
        Me.txt1FarvetillægMin2.Location = New System.Drawing.Point(433, 77)
        Me.txt1FarvetillægMin2.Name = "txt1FarvetillægMin2"
        Me.txt1FarvetillægMin2.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMin2.TabIndex = 11
        Me.txt1FarvetillægMin2.Visible = False
        '
        'txtMmPris2
        '
        Me.txtMmPris2.Location = New System.Drawing.Point(294, 77)
        Me.txtMmPris2.Name = "txtMmPris2"
        Me.txtMmPris2.Size = New System.Drawing.Size(45, 22)
        Me.txtMmPris2.TabIndex = 9
        Me.txtMmPris2.Visible = False
        '
        'txtFormatTil2
        '
        Me.txtFormatTil2.Location = New System.Drawing.Point(201, 77)
        Me.txtFormatTil2.Name = "txtFormatTil2"
        Me.txtFormatTil2.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatTil2.TabIndex = 8
        Me.txtFormatTil2.Visible = False
        '
        'txtFormatFra2
        '
        Me.txtFormatFra2.Location = New System.Drawing.Point(150, 77)
        Me.txtFormatFra2.Name = "txtFormatFra2"
        Me.txtFormatFra2.ReadOnly = True
        Me.txtFormatFra2.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatFra2.TabIndex = 312
        Me.txtFormatFra2.Visible = False
        '
        'txt1Farvetillæg2
        '
        Me.txt1Farvetillæg2.Location = New System.Drawing.Point(382, 77)
        Me.txt1Farvetillæg2.Name = "txt1Farvetillæg2"
        Me.txt1Farvetillæg2.Size = New System.Drawing.Size(45, 22)
        Me.txt1Farvetillæg2.TabIndex = 10
        Me.txt1Farvetillæg2.Visible = False
        '
        'txt4FarvertillægMax1
        '
        Me.txt4FarvertillægMax1.Enabled = False
        Me.txt4FarvertillægMax1.Location = New System.Drawing.Point(646, 49)
        Me.txt4FarvertillægMax1.Name = "txt4FarvertillægMax1"
        Me.txt4FarvertillægMax1.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMax1.TabIndex = 7
        '
        'txt4FarvertillægMin1
        '
        Me.txt4FarvertillægMin1.Enabled = False
        Me.txt4FarvertillægMin1.Location = New System.Drawing.Point(595, 49)
        Me.txt4FarvertillægMin1.Name = "txt4FarvertillægMin1"
        Me.txt4FarvertillægMin1.Size = New System.Drawing.Size(45, 22)
        Me.txt4FarvertillægMin1.TabIndex = 6
        '
        'txt4Farvertillæg1
        '
        Me.txt4Farvertillæg1.Location = New System.Drawing.Point(544, 49)
        Me.txt4Farvertillæg1.Name = "txt4Farvertillæg1"
        Me.txt4Farvertillæg1.Size = New System.Drawing.Size(45, 22)
        Me.txt4Farvertillæg1.TabIndex = 5
        '
        'txt1FarvetillægMax1
        '
        Me.txt1FarvetillægMax1.Enabled = False
        Me.txt1FarvetillægMax1.Location = New System.Drawing.Point(484, 49)
        Me.txt1FarvetillægMax1.Name = "txt1FarvetillægMax1"
        Me.txt1FarvetillægMax1.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMax1.TabIndex = 4
        '
        'txt1FarvetillægMin1
        '
        Me.txt1FarvetillægMin1.Enabled = False
        Me.txt1FarvetillægMin1.Location = New System.Drawing.Point(433, 49)
        Me.txt1FarvetillægMin1.Name = "txt1FarvetillægMin1"
        Me.txt1FarvetillægMin1.Size = New System.Drawing.Size(45, 22)
        Me.txt1FarvetillægMin1.TabIndex = 3
        '
        'txtMmPris1
        '
        Me.txtMmPris1.Location = New System.Drawing.Point(294, 49)
        Me.txtMmPris1.Name = "txtMmPris1"
        Me.txtMmPris1.Size = New System.Drawing.Size(45, 22)
        Me.txtMmPris1.TabIndex = 1
        '
        'txtFormatTil1
        '
        Me.txtFormatTil1.Location = New System.Drawing.Point(201, 49)
        Me.txtFormatTil1.Name = "txtFormatTil1"
        Me.txtFormatTil1.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatTil1.TabIndex = 0
        '
        'txtFormatFra1
        '
        Me.txtFormatFra1.Location = New System.Drawing.Point(150, 49)
        Me.txtFormatFra1.Name = "txtFormatFra1"
        Me.txtFormatFra1.ReadOnly = True
        Me.txtFormatFra1.Size = New System.Drawing.Size(45, 22)
        Me.txtFormatFra1.TabIndex = 279
        Me.txtFormatFra1.Text = "0"
        '
        'txt1Farvetillæg1
        '
        Me.txt1Farvetillæg1.Location = New System.Drawing.Point(382, 49)
        Me.txt1Farvetillæg1.Name = "txt1Farvetillæg1"
        Me.txt1Farvetillæg1.Size = New System.Drawing.Size(45, 22)
        Me.txt1Farvetillæg1.TabIndex = 2
        '
        'lbl4FarvertillægMax
        '
        Me.lbl4FarvertillægMax.AutoSize = True
        Me.lbl4FarvertillægMax.Enabled = False
        Me.lbl4FarvertillægMax.Location = New System.Drawing.Point(646, 36)
        Me.lbl4FarvertillægMax.Name = "lbl4FarvertillægMax"
        Me.lbl4FarvertillægMax.Size = New System.Drawing.Size(33, 15)
        Me.lbl4FarvertillægMax.TabIndex = 274
        Me.lbl4FarvertillægMax.Text = "max."
        '
        'lbl4Farver
        '
        Me.lbl4Farver.AutoSize = True
        Me.lbl4Farver.Enabled = False
        Me.lbl4Farver.Location = New System.Drawing.Point(544, 36)
        Me.lbl4Farver.Name = "lbl4Farver"
        Me.lbl4Farver.Size = New System.Drawing.Size(49, 15)
        Me.lbl4Farver.TabIndex = 276
        Me.lbl4Farver.Text = "4 farver"
        '
        'lbl1Farve
        '
        Me.lbl1Farve.AutoSize = True
        Me.lbl1Farve.Enabled = False
        Me.lbl1Farve.Location = New System.Drawing.Point(382, 36)
        Me.lbl1Farve.Name = "lbl1Farve"
        Me.lbl1Farve.Size = New System.Drawing.Size(44, 15)
        Me.lbl1Farve.TabIndex = 285
        Me.lbl1Farve.Text = "1 farve"
        '
        'lbl1FarvetillægMin
        '
        Me.lbl1FarvetillægMin.AutoSize = True
        Me.lbl1FarvetillægMin.Enabled = False
        Me.lbl1FarvetillægMin.Location = New System.Drawing.Point(433, 36)
        Me.lbl1FarvetillægMin.Name = "lbl1FarvetillægMin"
        Me.lbl1FarvetillægMin.Size = New System.Drawing.Size(30, 15)
        Me.lbl1FarvetillægMin.TabIndex = 305
        Me.lbl1FarvetillægMin.Text = "min."
        '
        'lbl4FarvertillægMin
        '
        Me.lbl4FarvertillægMin.AutoSize = True
        Me.lbl4FarvertillægMin.Enabled = False
        Me.lbl4FarvertillægMin.Location = New System.Drawing.Point(595, 36)
        Me.lbl4FarvertillægMin.Name = "lbl4FarvertillægMin"
        Me.lbl4FarvertillægMin.Size = New System.Drawing.Size(30, 15)
        Me.lbl4FarvertillægMin.TabIndex = 306
        Me.lbl4FarvertillægMin.Text = "min."
        '
        'lbl1FarvetillægMax
        '
        Me.lbl1FarvetillægMax.AutoSize = True
        Me.lbl1FarvetillægMax.Enabled = False
        Me.lbl1FarvetillægMax.Location = New System.Drawing.Point(484, 36)
        Me.lbl1FarvetillægMax.Name = "lbl1FarvetillægMax"
        Me.lbl1FarvetillægMax.Size = New System.Drawing.Size(33, 15)
        Me.lbl1FarvetillægMax.TabIndex = 307
        Me.lbl1FarvetillægMax.Text = "max."
        '
        'tbpSide3
        '
        Me.tbpSide3.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpSide3.Name = "tbpSide3"
        Me.tbpSide3.Size = New System.Drawing.Size(856, 309)
        '
        'tbpSide5
        '
        Me.tbpSide5.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpSide5.Name = "tbpSide5"
        Me.tbpSide5.Size = New System.Drawing.Size(856, 309)
        '
        'tbpSide7
        '
        Me.tbpSide7.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpSide7.Name = "tbpSide7"
        Me.tbpSide7.Size = New System.Drawing.Size(856, 309)
        '
        'tbpHøjreSide
        '
        Me.tbpHøjreSide.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpHøjreSide.Name = "tbpHøjreSide"
        Me.tbpHøjreSide.Size = New System.Drawing.Size(856, 309)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(856, 309)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(856, 309)
        '
        'tbpRubrik
        '
        Me.tbpRubrik.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpRubrik.Name = "tbpRubrik"
        Me.tbpRubrik.Size = New System.Drawing.Size(856, 309)
        '
        'tbpMotor
        '
        Me.tbpMotor.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpMotor.Name = "tbpMotor"
        Me.tbpMotor.Size = New System.Drawing.Size(856, 309)
        '
        'tbpForlystelser
        '
        Me.tbpForlystelser.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpForlystelser.Name = "tbpForlystelser"
        Me.tbpForlystelser.Size = New System.Drawing.Size(856, 309)
        '
        'tbpOfficielle
        '
        Me.tbpOfficielle.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpOfficielle.Name = "tbpOfficielle"
        Me.tbpOfficielle.Size = New System.Drawing.Size(856, 309)
        '
        'tbpStillinger
        '
        Me.tbpStillinger.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpStillinger.Name = "tbpStillinger"
        Me.tbpStillinger.Size = New System.Drawing.Size(856, 309)
        '
        'tbpBolig
        '
        Me.tbpBolig.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpBolig.Name = "tbpBolig"
        Me.tbpBolig.Size = New System.Drawing.Size(856, 309)
        '
        'tbpUddannelse
        '
        Me.tbpUddannelse.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpUddannelse.Name = "tbpUddannelse"
        Me.tbpUddannelse.Size = New System.Drawing.Size(856, 309)
        '
        'tbpNavnAdresse
        '
        Me.tbpNavnAdresse.Controls.Add(Me.txtKoncern)
        Me.tbpNavnAdresse.Controls.Add(lblKoncern)
        Me.tbpNavnAdresse.Controls.Add(Me.cboPostNr)
        Me.tbpNavnAdresse.Controls.Add(lblDiverseOplysninger)
        Me.tbpNavnAdresse.Controls.Add(Me.txtEjerforhold)
        Me.tbpNavnAdresse.Controls.Add(lblEjerforhold)
        Me.tbpNavnAdresse.Controls.Add(Me.optHovedgruppe)
        Me.tbpNavnAdresse.Controls.Add(Me.txtUgeavisID)
        Me.tbpNavnAdresse.Controls.Add(lblMedlemSiden)
        Me.tbpNavnAdresse.Controls.Add(lblHovedgruppe)
        Me.tbpNavnAdresse.Controls.Add(Me.cboÅr)
        Me.tbpNavnAdresse.Controls.Add(Me.cboMåned)
        Me.tbpNavnAdresse.Controls.Add(Me.chkOphørt)
        Me.tbpNavnAdresse.Controls.Add(Me.chkMedPåWWW)
        Me.tbpNavnAdresse.Controls.Add(Me.txtKontaktperson)
        Me.tbpNavnAdresse.Controls.Add(Me.txtFIK)
        Me.tbpNavnAdresse.Controls.Add(Me.txtCVR)
        Me.tbpNavnAdresse.Controls.Add(Me.medFax)
        Me.tbpNavnAdresse.Controls.Add(Me.medTlf)
        Me.tbpNavnAdresse.Controls.Add(Me.txtAdresse)
        Me.tbpNavnAdresse.Controls.Add(Me.txtNavn)
        Me.tbpNavnAdresse.Controls.Add(Me.txtAdresse2)
        Me.tbpNavnAdresse.Controls.Add(Me.txtBynavn)
        Me.tbpNavnAdresse.Controls.Add(lblStamdata)
        Me.tbpNavnAdresse.Controls.Add(lblKontaktperson)
        Me.tbpNavnAdresse.Controls.Add(lblFIK)
        Me.tbpNavnAdresse.Controls.Add(lblCVR)
        Me.tbpNavnAdresse.Controls.Add(lblFax)
        Me.tbpNavnAdresse.Controls.Add(lblTlf)
        Me.tbpNavnAdresse.Controls.Add(lblAdresse2)
        Me.tbpNavnAdresse.Controls.Add(lblAdresse)
        Me.tbpNavnAdresse.Controls.Add(lblNavn)
        Me.tbpNavnAdresse.Controls.Add(lblBladID)
        Me.tbpNavnAdresse.Controls.Add(lblPostNr)
        Me.tbpNavnAdresse.Location = New System.Drawing.Point(1, 20)
        Me.tbpNavnAdresse.Name = "tbpNavnAdresse"
        Me.tbpNavnAdresse.Size = New System.Drawing.Size(893, 642)
        '
        'txtKoncern
        '
        Me.txtKoncern.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Koncern", True))
        Me.txtKoncern.Location = New System.Drawing.Point(451, 260)
        Me.txtKoncern.Name = "txtKoncern"
        Me.txtKoncern.NullText = "- Skriv koncern -"
        Me.txtKoncern.Size = New System.Drawing.Size(213, 22)
        Me.txtKoncern.TabIndex = 124
        '
        'cboPostNr
        '
        Me.cboPostNr.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "PostNr", True))
        Me.cboPostNr.DataSource = Me.TblPostNrBindingSource
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboPostNr.DisplayLayout.Appearance = Appearance25
        UltraGridColumn65.Header.Caption = "Post nr"
        UltraGridColumn65.Header.VisiblePosition = 0
        UltraGridColumn66.Header.Caption = "By"
        UltraGridColumn66.Header.VisiblePosition = 1
        UltraGridColumn67.Header.VisiblePosition = 2
        UltraGridColumn67.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn65, UltraGridColumn66, UltraGridColumn67})
        Me.cboPostNr.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cboPostNr.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboPostNr.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPostNr.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPostNr.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.cboPostNr.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPostNr.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.cboPostNr.DisplayLayout.MaxColScrollRegions = 1
        Me.cboPostNr.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboPostNr.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboPostNr.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.cboPostNr.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboPostNr.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.cboPostNr.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboPostNr.DisplayLayout.Override.CellAppearance = Appearance32
        Me.cboPostNr.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboPostNr.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPostNr.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.cboPostNr.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.cboPostNr.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboPostNr.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.cboPostNr.DisplayLayout.Override.RowAppearance = Appearance35
        Me.cboPostNr.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboPostNr.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.cboPostNr.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboPostNr.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboPostNr.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboPostNr.DisplayMember = "PostNr"
        Me.cboPostNr.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPostNr.LimitToList = True
        Me.cboPostNr.Location = New System.Drawing.Point(170, 149)
        Me.cboPostNr.Name = "cboPostNr"
        Me.cboPostNr.Size = New System.Drawing.Size(69, 23)
        Me.cboPostNr.TabIndex = 4
        Me.cboPostNr.ValueMember = "PostNr"
        '
        'txtEjerforhold
        '
        Me.txtEjerforhold.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Ejerforhold", True))
        Me.txtEjerforhold.Location = New System.Drawing.Point(451, 204)
        Me.txtEjerforhold.Name = "txtEjerforhold"
        Me.txtEjerforhold.NullText = "- Skriv ejerforhold -"
        Me.txtEjerforhold.Size = New System.Drawing.Size(213, 22)
        Me.txtEjerforhold.TabIndex = 13
        '
        'optHovedgruppe
        '
        Me.optHovedgruppe.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "HovedgruppeID", True))
        Me.optHovedgruppe.DisplayMember = ""
        ValueListItem3.DataValue = CType(0, Byte)
        ValueListItem3.DisplayText = "DD"
        ValueListItem4.DataValue = CType(1, Byte)
        ValueListItem4.DisplayText = "DL"
        ValueListItem5.DataValue = CType(2, Byte)
        ValueListItem5.DisplayText = "Øvrige"
        Me.optHovedgruppe.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4, ValueListItem5})
        Me.optHovedgruppe.Location = New System.Drawing.Point(451, 40)
        Me.optHovedgruppe.Name = "optHovedgruppe"
        Me.optHovedgruppe.Size = New System.Drawing.Size(155, 22)
        Me.optHovedgruppe.TabIndex = 10
        '
        'txtUgeavisID
        '
        Me.txtUgeavisID.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "BladID", True))
        Me.txtUgeavisID.Location = New System.Drawing.Point(170, 38)
        Me.txtUgeavisID.Name = "txtUgeavisID"
        Me.txtUgeavisID.NullText = "- Ugeavisens ID -"
        Me.txtUgeavisID.ReadOnly = True
        Me.txtUgeavisID.Size = New System.Drawing.Size(213, 22)
        Me.txtUgeavisID.TabIndex = 0
        '
        'cboÅr
        '
        Me.cboÅr.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "MedlemÅr", True))
        ValueListItem6.DataValue = CType(86, Byte)
        ValueListItem6.DisplayText = "1986"
        ValueListItem7.DataValue = CType(87, Byte)
        ValueListItem7.DisplayText = "1987"
        ValueListItem8.DataValue = CType(88, Byte)
        ValueListItem8.DisplayText = "1988"
        ValueListItem9.DataValue = CType(89, Byte)
        ValueListItem9.DisplayText = "1989"
        ValueListItem10.DataValue = CType(90, Byte)
        ValueListItem10.DisplayText = "1990"
        ValueListItem11.DataValue = CType(91, Byte)
        ValueListItem11.DisplayText = "1991"
        ValueListItem12.DataValue = CType(92, Byte)
        ValueListItem12.DisplayText = "1992"
        ValueListItem13.DataValue = CType(93, Byte)
        ValueListItem13.DisplayText = "1993"
        ValueListItem14.DataValue = CType(94, Byte)
        ValueListItem14.DisplayText = "1994"
        ValueListItem15.DataValue = CType(95, Byte)
        ValueListItem15.DisplayText = "1995"
        ValueListItem16.DataValue = CType(96, Byte)
        ValueListItem16.DisplayText = "1996"
        ValueListItem17.DataValue = CType(97, Byte)
        ValueListItem17.DisplayText = "1997"
        ValueListItem18.DataValue = CType(98, Byte)
        ValueListItem18.DisplayText = "1998"
        ValueListItem19.DataValue = CType(99, Byte)
        ValueListItem19.DisplayText = "1999"
        ValueListItem20.DataValue = CType(0, Byte)
        ValueListItem20.DisplayText = "2000"
        ValueListItem21.DataValue = CType(1, Byte)
        ValueListItem21.DisplayText = "2001"
        ValueListItem22.DataValue = CType(2, Byte)
        ValueListItem22.DisplayText = "2002"
        ValueListItem23.DataValue = CType(3, Byte)
        ValueListItem23.DisplayText = "2003"
        ValueListItem24.DataValue = CType(4, Byte)
        ValueListItem24.DisplayText = "2004"
        ValueListItem25.DataValue = CType(0, Byte)
        ValueListItem25.DisplayText = "2005"
        ValueListItem26.DataValue = CType(6, Byte)
        ValueListItem26.DisplayText = "2006"
        ValueListItem27.DataValue = CType(7, Byte)
        ValueListItem27.DisplayText = "2007"
        ValueListItem28.DataValue = CType(8, Byte)
        ValueListItem28.DisplayText = "2008"
        ValueListItem41.DataValue = CType(9, Byte)
        ValueListItem41.DisplayText = "2009"
        Me.cboÅr.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem9, ValueListItem10, ValueListItem11, ValueListItem12, ValueListItem13, ValueListItem14, ValueListItem15, ValueListItem16, ValueListItem17, ValueListItem18, ValueListItem19, ValueListItem20, ValueListItem21, ValueListItem22, ValueListItem23, ValueListItem24, ValueListItem25, ValueListItem26, ValueListItem27, ValueListItem28, ValueListItem41})
        Me.cboÅr.Location = New System.Drawing.Point(451, 122)
        Me.cboÅr.Name = "cboÅr"
        Me.cboÅr.NullText = "-Vælg År-"
        Me.cboÅr.Size = New System.Drawing.Size(93, 22)
        Me.cboÅr.TabIndex = 11
        '
        'cboMåned
        '
        Me.cboMåned.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "MedlemMåned", True))
        ValueListItem29.DataValue = CType(0, Byte)
        ValueListItem29.DisplayText = "Januar"
        ValueListItem30.DataValue = CType(1, Byte)
        ValueListItem30.DisplayText = "Februar"
        ValueListItem31.DataValue = CType(2, Byte)
        ValueListItem31.DisplayText = "Marts"
        ValueListItem32.DataValue = CType(3, Byte)
        ValueListItem32.DisplayText = "April"
        ValueListItem33.DataValue = CType(4, Byte)
        ValueListItem33.DisplayText = "Maj"
        ValueListItem34.DataValue = CType(5, Byte)
        ValueListItem34.DisplayText = "Juni"
        ValueListItem35.DataValue = CType(6, Byte)
        ValueListItem35.DisplayText = "Juli"
        ValueListItem36.DataValue = CType(7, Byte)
        ValueListItem36.DisplayText = "August"
        ValueListItem37.DataValue = CType(8, Byte)
        ValueListItem37.DisplayText = "September"
        ValueListItem38.DataValue = CType(9, Byte)
        ValueListItem38.DisplayText = "Oktober"
        ValueListItem39.DataValue = CType(10, Byte)
        ValueListItem39.DisplayText = "November"
        ValueListItem40.DataValue = CType(11, Byte)
        ValueListItem40.DisplayText = "December"
        Me.cboMåned.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem29, ValueListItem30, ValueListItem31, ValueListItem32, ValueListItem33, ValueListItem34, ValueListItem35, ValueListItem36, ValueListItem37, ValueListItem38, ValueListItem39, ValueListItem40})
        Me.cboMåned.Location = New System.Drawing.Point(550, 122)
        Me.cboMåned.Name = "cboMåned"
        Me.cboMåned.NullText = "-Vælg Måned-"
        Me.cboMåned.Size = New System.Drawing.Size(114, 22)
        Me.cboMåned.TabIndex = 12
        Me.cboMåned.ValueMember = "MedlemMåned"
        '
        'chkOphørt
        '
        Me.chkOphørt.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblBladStamdataBindingSource, "Ophørt", True))
        Me.chkOphørt.Location = New System.Drawing.Point(451, 320)
        Me.chkOphørt.Name = "chkOphørt"
        Me.chkOphørt.Size = New System.Drawing.Size(105, 19)
        Me.chkOphørt.TabIndex = 14
        Me.chkOphørt.Text = "Ophørt"
        '
        'chkMedPåWWW
        '
        Me.chkMedPåWWW.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblBladStamdataBindingSource, "VisPåWWW", True))
        Me.chkMedPåWWW.Location = New System.Drawing.Point(451, 345)
        Me.chkMedPåWWW.Name = "chkMedPåWWW"
        Me.chkMedPåWWW.Size = New System.Drawing.Size(335, 19)
        Me.chkMedPåWWW.TabIndex = 15
        Me.chkMedPåWWW.Text = "Avisen skal overføres til DLU's website"
        '
        'txtKontaktperson
        '
        Me.txtKontaktperson.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Kontaktperson", True))
        Me.txtKontaktperson.Location = New System.Drawing.Point(170, 288)
        Me.txtKontaktperson.MaxLength = 30
        Me.txtKontaktperson.Name = "txtKontaktperson"
        Me.txtKontaktperson.NullText = "- Skriv navn på Kontaktperson -"
        Me.txtKontaktperson.Size = New System.Drawing.Size(213, 22)
        Me.txtKontaktperson.TabIndex = 9
        '
        'txtFIK
        '
        Me.txtFIK.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "FIK", True))
        Me.txtFIK.Location = New System.Drawing.Point(170, 260)
        Me.txtFIK.Name = "txtFIK"
        Me.txtFIK.NullText = "- Skriv FIK nr. -"
        Me.txtFIK.Size = New System.Drawing.Size(124, 22)
        Me.txtFIK.TabIndex = 8
        '
        'txtCVR
        '
        Me.txtCVR.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "CVR", True))
        Me.txtCVR.Location = New System.Drawing.Point(170, 232)
        Me.txtCVR.Name = "txtCVR"
        Me.txtCVR.NullText = "- Skriv CVR nr. -"
        Me.txtCVR.Size = New System.Drawing.Size(124, 22)
        Me.txtCVR.TabIndex = 7
        '
        'medFax
        '
        Me.medFax.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Fax", True))
        Me.medFax.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.medFax.FormatString = "#### ####"
        Me.medFax.InputMask = "#### ####"
        Me.medFax.Location = New System.Drawing.Point(170, 205)
        Me.medFax.Name = "medFax"
        Me.medFax.NonAutoSizeHeight = 20
        Me.medFax.NullText = "- Skriv Fax nr. -"
        Me.medFax.Size = New System.Drawing.Size(124, 21)
        Me.medFax.TabIndex = 6
        Me.medFax.Text = " "
        '
        'medTlf
        '
        Me.medTlf.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Tlf", True))
        Me.medTlf.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.medTlf.FormatString = "#### ####"
        Me.medTlf.InputMask = "#### ####"
        Me.medTlf.Location = New System.Drawing.Point(170, 178)
        Me.medTlf.Name = "medTlf"
        Me.medTlf.NonAutoSizeHeight = 20
        Me.medTlf.NullText = "- Skriv Tlf. nr. -"
        Me.medTlf.Size = New System.Drawing.Size(124, 21)
        Me.medTlf.TabIndex = 5
        Me.medTlf.Text = " "
        '
        'txtAdresse
        '
        Me.txtAdresse.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Adresse", True))
        Me.txtAdresse.Location = New System.Drawing.Point(170, 94)
        Me.txtAdresse.MaxLength = 30
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.NullText = "- Skriv Adresse -"
        Me.txtAdresse.Size = New System.Drawing.Size(213, 22)
        Me.txtAdresse.TabIndex = 2
        '
        'txtNavn
        '
        Me.txtNavn.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Navn", True))
        Me.txtNavn.Location = New System.Drawing.Point(170, 66)
        Me.txtNavn.MaxLength = 30
        Me.txtNavn.Name = "txtNavn"
        Me.txtNavn.NullText = "- Skriv Navn -"
        Me.txtNavn.Size = New System.Drawing.Size(213, 22)
        Me.txtNavn.TabIndex = 1
        '
        'txtAdresse2
        '
        Me.txtAdresse2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Adresse2", True))
        Me.txtAdresse2.Location = New System.Drawing.Point(170, 122)
        Me.txtAdresse2.MaxLength = 30
        Me.txtAdresse2.Name = "txtAdresse2"
        Me.txtAdresse2.NullText = "- Skriv Adresse 2 -"
        Me.txtAdresse2.Size = New System.Drawing.Size(213, 22)
        Me.txtAdresse2.TabIndex = 3
        '
        'txtBynavn
        '
        Me.txtBynavn.Location = New System.Drawing.Point(248, 150)
        Me.txtBynavn.Name = "txtBynavn"
        Me.txtBynavn.NullText = "- Vælg postnr. -"
        Me.txtBynavn.ReadOnly = True
        Me.txtBynavn.Size = New System.Drawing.Size(135, 22)
        Me.txtBynavn.TabIndex = 110
        '
        'tbpDækningsområde
        '
        Me.tbpDækningsområde.Controls.Add(Me.cboGeoKode)
        Me.tbpDækningsområde.Controls.Add(Me.cboDelområde)
        Me.tbpDækningsområde.Controls.Add(Me.cboRegion)
        Me.tbpDækningsområde.Controls.Add(Me.cboPostNrDækning)
        Me.tbpDækningsområde.Controls.Add(Me.grdDækning)
        Me.tbpDækningsområde.Controls.Add(lblDækningsområde)
        Me.tbpDækningsområde.Controls.Add(lblGeografiskeData)
        Me.tbpDækningsområde.Controls.Add(lblLæsertal)
        Me.tbpDækningsområde.Controls.Add(lblGeokode)
        Me.tbpDækningsområde.Controls.Add(lblBeskrivelseAfDækningsområdet)
        Me.tbpDækningsområde.Controls.Add(Me.txtTotalområdePct)
        Me.tbpDækningsområde.Controls.Add(lblDelområde)
        Me.tbpDækningsområde.Controls.Add(lblTotalområdePct)
        Me.tbpDækningsområde.Controls.Add(Me.txtPrimærPct)
        Me.tbpDækningsområde.Controls.Add(lblRegion)
        Me.tbpDækningsområde.Controls.Add(Me.txtTotalområde)
        Me.tbpDækningsområde.Controls.Add(lblPrimærPct)
        Me.tbpDækningsområde.Controls.Add(lblTotalområde)
        Me.tbpDækningsområde.Controls.Add(Me.WWWDækningSomTekstUltraFormattedTextEditor)
        Me.tbpDækningsområde.Controls.Add(Me.txtPrimær)
        Me.tbpDækningsområde.Controls.Add(lblPrimær)
        Me.tbpDækningsområde.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpDækningsområde.Name = "tbpDækningsområde"
        Me.tbpDækningsområde.Size = New System.Drawing.Size(893, 642)
        '
        'cboGeoKode
        '
        Me.cboGeoKode.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "GeoKodeID", True))
        Me.cboGeoKode.DataSource = Me.TblGeoKodeBindingSource
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboGeoKode.DisplayLayout.Appearance = Appearance37
        Me.cboGeoKode.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridBand4.ColHeadersVisible = False
        UltraGridColumn68.Header.VisiblePosition = 0
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.Caption = "Geo kode"
        UltraGridColumn69.Header.VisiblePosition = 1
        UltraGridColumn70.Header.VisiblePosition = 2
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 3
        UltraGridColumn71.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71})
        Me.cboGeoKode.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cboGeoKode.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboGeoKode.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance38.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.cboGeoKode.DisplayLayout.GroupByBox.Appearance = Appearance38
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboGeoKode.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance39
        Me.cboGeoKode.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance40.BackColor2 = System.Drawing.SystemColors.Control
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboGeoKode.DisplayLayout.GroupByBox.PromptAppearance = Appearance40
        Me.cboGeoKode.DisplayLayout.MaxColScrollRegions = 1
        Me.cboGeoKode.DisplayLayout.MaxRowScrollRegions = 1
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboGeoKode.DisplayLayout.Override.ActiveCellAppearance = Appearance41
        Appearance42.BackColor = System.Drawing.SystemColors.Highlight
        Appearance42.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboGeoKode.DisplayLayout.Override.ActiveRowAppearance = Appearance42
        Me.cboGeoKode.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboGeoKode.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Me.cboGeoKode.DisplayLayout.Override.CardAreaAppearance = Appearance43
        Appearance44.BorderColor = System.Drawing.Color.Silver
        Appearance44.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboGeoKode.DisplayLayout.Override.CellAppearance = Appearance44
        Me.cboGeoKode.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboGeoKode.DisplayLayout.Override.CellPadding = 0
        Appearance45.BackColor = System.Drawing.SystemColors.Control
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.cboGeoKode.DisplayLayout.Override.GroupByRowAppearance = Appearance45
        Appearance46.TextHAlignAsString = "Left"
        Me.cboGeoKode.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.cboGeoKode.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboGeoKode.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Appearance47.BorderColor = System.Drawing.Color.Silver
        Me.cboGeoKode.DisplayLayout.Override.RowAppearance = Appearance47
        Me.cboGeoKode.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance48.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboGeoKode.DisplayLayout.Override.TemplateAddRowAppearance = Appearance48
        Me.cboGeoKode.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboGeoKode.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboGeoKode.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboGeoKode.DisplayMember = "GeoKodeNavn"
        Me.cboGeoKode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGeoKode.Location = New System.Drawing.Point(128, 96)
        Me.cboGeoKode.Name = "cboGeoKode"
        Me.cboGeoKode.NullText = "- Vælg Geo kode -"
        Me.cboGeoKode.Size = New System.Drawing.Size(155, 23)
        Me.cboGeoKode.TabIndex = 2
        Me.cboGeoKode.ValueMember = "GeoKodeID"
        '
        'TblGeoKodeBindingSource
        '
        Me.TblGeoKodeBindingSource.DataMember = "tblGeoKode"
        Me.TblGeoKodeBindingSource.DataSource = Me.GeoKodeListeDropdown
        '
        'GeoKodeListeDropdown
        '
        Me.GeoKodeListeDropdown.DataSetName = "GeoKodeListeDropdown"
        Me.GeoKodeListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboDelområde
        '
        Me.cboDelområde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "DelOmrådeID", True))
        Me.cboDelområde.DataSource = Me.TblDelOmrådeBindingSource
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboDelområde.DisplayLayout.Appearance = Appearance49
        Me.cboDelområde.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn72.Header.VisiblePosition = 0
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.Caption = "Delområde"
        UltraGridColumn73.Header.VisiblePosition = 1
        UltraGridColumn74.Header.Caption = "Navn"
        UltraGridColumn74.Header.VisiblePosition = 2
        UltraGridColumn75.Header.VisiblePosition = 3
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 4
        UltraGridColumn76.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76})
        Me.cboDelområde.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.cboDelområde.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboDelområde.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance50.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.BorderColor = System.Drawing.SystemColors.Window
        Me.cboDelområde.DisplayLayout.GroupByBox.Appearance = Appearance50
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboDelområde.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance51
        Me.cboDelområde.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance52.BackColor2 = System.Drawing.SystemColors.Control
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboDelområde.DisplayLayout.GroupByBox.PromptAppearance = Appearance52
        Me.cboDelområde.DisplayLayout.MaxColScrollRegions = 1
        Me.cboDelområde.DisplayLayout.MaxRowScrollRegions = 1
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboDelområde.DisplayLayout.Override.ActiveCellAppearance = Appearance53
        Appearance54.BackColor = System.Drawing.SystemColors.Highlight
        Appearance54.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboDelområde.DisplayLayout.Override.ActiveRowAppearance = Appearance54
        Me.cboDelområde.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboDelområde.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Me.cboDelområde.DisplayLayout.Override.CardAreaAppearance = Appearance55
        Appearance56.BorderColor = System.Drawing.Color.Silver
        Appearance56.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboDelområde.DisplayLayout.Override.CellAppearance = Appearance56
        Me.cboDelområde.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboDelområde.DisplayLayout.Override.CellPadding = 0
        Appearance57.BackColor = System.Drawing.SystemColors.Control
        Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance57.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance57.BorderColor = System.Drawing.SystemColors.Window
        Me.cboDelområde.DisplayLayout.Override.GroupByRowAppearance = Appearance57
        Appearance58.TextHAlignAsString = "Left"
        Me.cboDelområde.DisplayLayout.Override.HeaderAppearance = Appearance58
        Me.cboDelområde.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboDelområde.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Appearance59.BorderColor = System.Drawing.Color.Silver
        Me.cboDelområde.DisplayLayout.Override.RowAppearance = Appearance59
        Me.cboDelområde.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance60.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboDelområde.DisplayLayout.Override.TemplateAddRowAppearance = Appearance60
        Me.cboDelområde.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboDelområde.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboDelområde.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.cboDelområde.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboDelområde.DisplayMember = "DelOmrådeKode"
        Me.cboDelområde.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDelområde.Location = New System.Drawing.Point(128, 67)
        Me.cboDelområde.Name = "cboDelområde"
        Me.cboDelområde.NullText = "- Vælg delområde -"
        Me.cboDelområde.Size = New System.Drawing.Size(155, 23)
        Me.cboDelområde.TabIndex = 1
        Me.cboDelområde.ValueMember = "DelOmrådeID"
        '
        'TblDelOmrådeBindingSource
        '
        Me.TblDelOmrådeBindingSource.DataMember = "tblDelOmråde"
        Me.TblDelOmrådeBindingSource.DataSource = Me.DelområdeListeDropdown
        '
        'DelområdeListeDropdown
        '
        Me.DelområdeListeDropdown.DataSetName = "DelområdeListeDropdown"
        Me.DelområdeListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboRegion
        '
        Me.cboRegion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "RegionID", True))
        Me.cboRegion.DataSource = Me.TblRegionBindingSource
        Appearance61.BackColor = System.Drawing.SystemColors.Window
        Appearance61.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboRegion.DisplayLayout.Appearance = Appearance61
        Me.cboRegion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridBand6.ColHeadersVisible = False
        UltraGridColumn77.Header.VisiblePosition = 0
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.Caption = "Region"
        UltraGridColumn78.Header.VisiblePosition = 1
        UltraGridColumn79.Header.Enabled = False
        UltraGridColumn79.Header.VisiblePosition = 2
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 3
        UltraGridColumn80.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80})
        Me.cboRegion.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.cboRegion.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboRegion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance62.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance62.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance62.BorderColor = System.Drawing.SystemColors.Window
        Me.cboRegion.DisplayLayout.GroupByBox.Appearance = Appearance62
        Appearance63.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboRegion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance63
        Me.cboRegion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance64.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance64.BackColor2 = System.Drawing.SystemColors.Control
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance64.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboRegion.DisplayLayout.GroupByBox.PromptAppearance = Appearance64
        Me.cboRegion.DisplayLayout.MaxColScrollRegions = 1
        Me.cboRegion.DisplayLayout.MaxRowScrollRegions = 1
        Appearance65.BackColor = System.Drawing.SystemColors.Window
        Appearance65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboRegion.DisplayLayout.Override.ActiveCellAppearance = Appearance65
        Appearance66.BackColor = System.Drawing.SystemColors.Highlight
        Appearance66.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboRegion.DisplayLayout.Override.ActiveRowAppearance = Appearance66
        Me.cboRegion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboRegion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance67.BackColor = System.Drawing.SystemColors.Window
        Me.cboRegion.DisplayLayout.Override.CardAreaAppearance = Appearance67
        Appearance68.BorderColor = System.Drawing.Color.Silver
        Appearance68.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboRegion.DisplayLayout.Override.CellAppearance = Appearance68
        Me.cboRegion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboRegion.DisplayLayout.Override.CellPadding = 0
        Appearance69.BackColor = System.Drawing.SystemColors.Control
        Appearance69.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance69.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance69.BorderColor = System.Drawing.SystemColors.Window
        Me.cboRegion.DisplayLayout.Override.GroupByRowAppearance = Appearance69
        Appearance70.TextHAlignAsString = "Left"
        Me.cboRegion.DisplayLayout.Override.HeaderAppearance = Appearance70
        Me.cboRegion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboRegion.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance71.BackColor = System.Drawing.SystemColors.Window
        Appearance71.BorderColor = System.Drawing.Color.Silver
        Me.cboRegion.DisplayLayout.Override.RowAppearance = Appearance71
        Me.cboRegion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance72.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboRegion.DisplayLayout.Override.TemplateAddRowAppearance = Appearance72
        Me.cboRegion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboRegion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboRegion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboRegion.DisplayMember = "RegionNavn"
        Me.cboRegion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegion.Location = New System.Drawing.Point(128, 38)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.NullText = "- Vælg Region -"
        Me.cboRegion.Size = New System.Drawing.Size(155, 23)
        Me.cboRegion.TabIndex = 0
        Me.cboRegion.ValueMember = "RegionID"
        '
        'TblRegionBindingSource
        '
        Me.TblRegionBindingSource.DataMember = "tblRegion"
        Me.TblRegionBindingSource.DataSource = Me.RegionListeDropdown
        '
        'RegionListeDropdown
        '
        Me.RegionListeDropdown.DataSetName = "RegionListeDropdown"
        Me.RegionListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdDækning
        '
        Me.grdDækning.DataSource = Me.TblBladDækningBindingSource
        Me.grdDækning.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn81.Header.VisiblePosition = 0
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.EditorComponent = Me.cboPostNrDækning
        UltraGridColumn82.Header.VisiblePosition = 1
        UltraGridColumn82.Width = 73
        UltraGridColumn83.Header.VisiblePosition = 2
        UltraGridColumn83.Width = 108
        UltraGridColumn84.Header.Caption = "Dækningsgrad"
        UltraGridColumn84.Header.VisiblePosition = 3
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84})
        Me.grdDækning.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.grdDækning.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grdDækning.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdDækning.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Synchronized
        Me.grdDækning.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdDækning.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.EntireColumn
        Me.grdDækning.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdDækning.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grdDækning.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDækning.Location = New System.Drawing.Point(448, 37)
        Me.grdDækning.Name = "grdDækning"
        Me.grdDækning.Size = New System.Drawing.Size(365, 346)
        Me.grdDækning.TabIndex = 8
        Me.grdDækning.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus
        '
        'TblBladDækningBindingSource
        '
        Me.TblBladDækningBindingSource.AllowNew = True
        Me.TblBladDækningBindingSource.DataMember = "FK_tblBladDækning_tblBladStamdata"
        Me.TblBladDækningBindingSource.DataSource = Me.TblBladStamdataBindingSource
        '
        'txtTotalområdePct
        '
        Me.txtTotalområdePct.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "TotalområdePct", True))
        Me.txtTotalområdePct.Location = New System.Drawing.Point(128, 200)
        Me.txtTotalområdePct.Name = "txtTotalområdePct"
        Me.txtTotalområdePct.NullText = "- Skriv Procent -"
        Me.txtTotalområdePct.Size = New System.Drawing.Size(155, 22)
        Me.txtTotalområdePct.TabIndex = 4
        '
        'txtPrimærPct
        '
        Me.txtPrimærPct.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "PrimærPct", True))
        Me.txtPrimærPct.Location = New System.Drawing.Point(128, 256)
        Me.txtPrimærPct.Name = "txtPrimærPct"
        Me.txtPrimærPct.NullText = "- Skriv Procent -"
        Me.txtPrimærPct.Size = New System.Drawing.Size(155, 22)
        Me.txtPrimærPct.TabIndex = 6
        '
        'txtTotalområde
        '
        Me.txtTotalområde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Totalområde", True))
        Me.txtTotalområde.Location = New System.Drawing.Point(128, 172)
        Me.txtTotalområde.Name = "txtTotalområde"
        Me.txtTotalområde.NullText = "- Skriv Totalområde -"
        Me.txtTotalområde.Size = New System.Drawing.Size(155, 22)
        Me.txtTotalområde.TabIndex = 3
        '
        'WWWDækningSomTekstUltraFormattedTextEditor
        '
        Me.WWWDækningSomTekstUltraFormattedTextEditor.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "WWWDækningSomTekst", True))
        Me.WWWDækningSomTekstUltraFormattedTextEditor.Location = New System.Drawing.Point(18, 337)
        Me.WWWDækningSomTekstUltraFormattedTextEditor.Name = "WWWDækningSomTekstUltraFormattedTextEditor"
        Me.WWWDækningSomTekstUltraFormattedTextEditor.ReadOnly = True
        Me.WWWDækningSomTekstUltraFormattedTextEditor.Size = New System.Drawing.Size(366, 46)
        Me.WWWDækningSomTekstUltraFormattedTextEditor.TabIndex = 7
        Me.WWWDækningSomTekstUltraFormattedTextEditor.Value = Nothing
        '
        'txtPrimær
        '
        Me.txtPrimær.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Primær", True))
        Me.txtPrimær.Location = New System.Drawing.Point(128, 228)
        Me.txtPrimær.Name = "txtPrimær"
        Me.txtPrimær.NullText = "- Skriv Primær -"
        Me.txtPrimær.Size = New System.Drawing.Size(155, 22)
        Me.txtPrimær.TabIndex = 5
        '
        'tbpPriser
        '
        Me.tbpPriser.Controls.Add(Me.cboPrislisterPrÅr)
        Me.tbpPriser.Controls.Add(Me.cboPriserÅr)
        Me.tbpPriser.Controls.Add(Me.cboPrislister)
        Me.tbpPriser.Controls.Add(Me.TblPrislisterPrBladPrUgeUltraGrid)
        Me.tbpPriser.Controls.Add(Me.btnTilføjPrisliste)
        Me.tbpPriser.Controls.Add(lblPrisLister)
        Me.tbpPriser.Controls.Add(lblPrislistePrUge)
        Me.tbpPriser.Controls.Add(lblÅr)
        Me.tbpPriser.Controls.Add(Me.tabPriser)
        Me.tbpPriser.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpPriser.Name = "tbpPriser"
        Me.tbpPriser.Size = New System.Drawing.Size(893, 642)
        '
        'cboPriserÅr
        '
        Me.cboPriserÅr.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPriserÅr.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FKtblÅrMedPrisertblBladStamdataBindingSource1, "År", True))
        Me.cboPriserÅr.DataSource = Me.FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource
        Me.cboPriserÅr.DisplayMember = "År"
        Me.cboPriserÅr.Location = New System.Drawing.Point(77, 18)
        Me.cboPriserÅr.Name = "cboPriserÅr"
        Me.cboPriserÅr.Size = New System.Drawing.Size(100, 22)
        Me.cboPriserÅr.TabIndex = 0
        Me.cboPriserÅr.ValueMember = "År"
        '
        'FKtblÅrMedPrisertblBladStamdataBindingSource1
        '
        Me.FKtblÅrMedPrisertblBladStamdataBindingSource1.DataMember = "FK_tblÅrMedPriser_tblBladStamdata"
        Me.FKtblÅrMedPrisertblBladStamdataBindingSource1.DataSource = Me.TblBladStamdataBindingSource
        '
        'cboPrislister
        '
        Me.cboPrislister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboPrislister.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblPrislisterPrBladPrUgeBindingSource, "PrislisteID", True))
        Me.cboPrislister.DataSource = Me.FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource
        Appearance73.BackColor = System.Drawing.SystemColors.Window
        Appearance73.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboPrislister.DisplayLayout.Appearance = Appearance73
        UltraGridBand8.ColHeadersVisible = False
        UltraGridColumn85.Header.VisiblePosition = 0
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 1
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 2
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.Caption = "Prisliste"
        UltraGridColumn88.Header.VisiblePosition = 3
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88})
        Me.cboPrislister.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.cboPrislister.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboPrislister.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance74.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance74.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance74.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPrislister.DisplayLayout.GroupByBox.Appearance = Appearance74
        Appearance75.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPrislister.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance75
        Me.cboPrislister.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance76.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance76.BackColor2 = System.Drawing.SystemColors.Control
        Appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance76.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPrislister.DisplayLayout.GroupByBox.PromptAppearance = Appearance76
        Me.cboPrislister.DisplayLayout.MaxColScrollRegions = 1
        Me.cboPrislister.DisplayLayout.MaxRowScrollRegions = 1
        Appearance77.BackColor = System.Drawing.SystemColors.Window
        Appearance77.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboPrislister.DisplayLayout.Override.ActiveCellAppearance = Appearance77
        Appearance78.BackColor = System.Drawing.SystemColors.Highlight
        Appearance78.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboPrislister.DisplayLayout.Override.ActiveRowAppearance = Appearance78
        Me.cboPrislister.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboPrislister.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance79.BackColor = System.Drawing.SystemColors.Window
        Me.cboPrislister.DisplayLayout.Override.CardAreaAppearance = Appearance79
        Appearance80.BorderColor = System.Drawing.Color.Silver
        Appearance80.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboPrislister.DisplayLayout.Override.CellAppearance = Appearance80
        Me.cboPrislister.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboPrislister.DisplayLayout.Override.CellPadding = 0
        Appearance81.BackColor = System.Drawing.SystemColors.Control
        Appearance81.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance81.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance81.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPrislister.DisplayLayout.Override.GroupByRowAppearance = Appearance81
        Appearance82.TextHAlignAsString = "Left"
        Me.cboPrislister.DisplayLayout.Override.HeaderAppearance = Appearance82
        Me.cboPrislister.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboPrislister.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance83.BackColor = System.Drawing.SystemColors.Window
        Appearance83.BorderColor = System.Drawing.Color.Silver
        Me.cboPrislister.DisplayLayout.Override.RowAppearance = Appearance83
        Me.cboPrislister.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance84.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboPrislister.DisplayLayout.Override.TemplateAddRowAppearance = Appearance84
        Me.cboPrislister.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboPrislister.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboPrislister.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.cboPrislister.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboPrislister.DisplayMember = "PrislisteNavn"
        Me.cboPrislister.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrislister.Location = New System.Drawing.Point(77, 272)
        Me.cboPrislister.Name = "cboPrislister"
        Me.cboPrislister.Size = New System.Drawing.Size(100, 23)
        Me.cboPrislister.TabIndex = 2
        Me.cboPrislister.ValueMember = "PrislisteID"
        '
        'TblPrislisterPrBladPrUgeBindingSource
        '
        Me.TblPrislisterPrBladPrUgeBindingSource.DataMember = "FK_tblPrislisterPrBladPrUge_tblBladStamdata"
        Me.TblPrislisterPrBladPrUgeBindingSource.DataSource = Me.TblBladStamdataBindingSource
        '
        'TblPrislisterPrBladPrUgeUltraGrid
        '
        Me.TblPrislisterPrBladPrUgeUltraGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblPrislisterPrBladPrUgeUltraGrid.DataSource = Me.TblPrislisterPrBladPrUgeBindingSource
        Me.TblPrislisterPrBladPrUgeUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn89.Header.VisiblePosition = 0
        UltraGridColumn90.Header.VisiblePosition = 1
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 2
        UltraGridColumn91.Width = 39
        UltraGridColumn92.EditorComponent = Me.cboPrislisterPrÅr
        UltraGridColumn92.Header.Caption = "Prisliste"
        UltraGridColumn92.Header.VisiblePosition = 3
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92})
        Me.TblPrislisterPrBladPrUgeUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.TblPrislisterPrBladPrUgeUltraGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.TblPrislisterPrBladPrUgeUltraGrid.Location = New System.Drawing.Point(267, 38)
        Me.TblPrislisterPrBladPrUgeUltraGrid.Name = "TblPrislisterPrBladPrUgeUltraGrid"
        Me.TblPrislisterPrBladPrUgeUltraGrid.Size = New System.Drawing.Size(279, 221)
        Me.TblPrislisterPrBladPrUgeUltraGrid.TabIndex = 1
        '
        'btnTilføjPrisliste
        '
        Me.btnTilføjPrisliste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTilføjPrisliste.Location = New System.Drawing.Point(195, 271)
        Me.btnTilføjPrisliste.Name = "btnTilføjPrisliste"
        Me.btnTilføjPrisliste.Size = New System.Drawing.Size(98, 23)
        Me.btnTilføjPrisliste.TabIndex = 362
        Me.btnTilføjPrisliste.Text = "Tilføj Prisliste"
        '
        'tabPriser
        '
        Me.tabPriser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabPriser.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabPriser.Controls.Add(Me.tbpRubrik)
        Me.tabPriser.Controls.Add(Me.tbpMotor)
        Me.tabPriser.Controls.Add(Me.tbpForlystelser)
        Me.tabPriser.Controls.Add(Me.tbpOfficielle)
        Me.tabPriser.Controls.Add(Me.tbpStillinger)
        Me.tabPriser.Controls.Add(Me.tbpBolig)
        Me.tabPriser.Controls.Add(Me.tbpUddannelse)
        Me.tabPriser.Controls.Add(Me.tbpTekstside)
        Me.tabPriser.Controls.Add(Me.tbpSide3)
        Me.tabPriser.Controls.Add(Me.tbpSide5)
        Me.tabPriser.Controls.Add(Me.tbpHøjreSide)
        Me.tabPriser.Controls.Add(Me.tbpSide7)
        Me.tabPriser.Controls.Add(Me.UltraTabPageControl1)
        Me.tabPriser.Controls.Add(Me.UltraTabPageControl2)
        Me.tabPriser.Location = New System.Drawing.Point(16, 301)
        Me.tabPriser.Name = "tabPriser"
        Me.tabPriser.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.grpPriser})
        Me.tabPriser.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tabPriser.Size = New System.Drawing.Size(858, 330)
        Me.tabPriser.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.tabPriser.TabIndex = 3
        UltraTab1.TabPage = Me.tbpTekstside
        UltraTab1.Text = "Tekstside"
        UltraTab15.TabPage = Me.tbpSide3
        UltraTab15.Text = "Side 3"
        UltraTab16.TabPage = Me.tbpSide5
        UltraTab16.Text = "Side 5"
        UltraTab18.TabPage = Me.tbpSide7
        UltraTab18.Text = "Side 7"
        UltraTab17.TabPage = Me.tbpHøjreSide
        UltraTab17.Text = "Højre Side"
        UltraTab7.TabPage = Me.UltraTabPageControl1
        UltraTab7.Text = "Supplerende"
        UltraTab20.TabPage = Me.UltraTabPageControl2
        UltraTab20.Text = "Højre Side Sup"
        UltraTab2.TabPage = Me.tbpRubrik
        UltraTab2.Text = "Rubrik"
        UltraTab3.TabPage = Me.tbpMotor
        UltraTab3.Text = "Motor"
        UltraTab4.TabPage = Me.tbpForlystelser
        UltraTab4.Text = "Forlystelser"
        UltraTab5.TabPage = Me.tbpOfficielle
        UltraTab5.Text = "Officielle"
        UltraTab6.TabPage = Me.tbpStillinger
        UltraTab6.Text = "Stillinger"
        UltraTab8.TabPage = Me.tbpBolig
        UltraTab8.Text = "Bolig"
        UltraTab9.TabPage = Me.tbpUddannelse
        UltraTab9.Text = "Uddannelse"
        Me.tabPriser.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab15, UltraTab16, UltraTab18, UltraTab17, UltraTab7, UltraTab20, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab8, UltraTab9})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Controls.Add(Me.grpPriser)
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(856, 309)
        '
        'tbpPriserOversigt
        '
        Me.tbpPriserOversigt.Controls.Add(Me.grdAllePriser)
        Me.tbpPriserOversigt.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpPriserOversigt.Name = "tbpPriserOversigt"
        Me.tbpPriserOversigt.Size = New System.Drawing.Size(893, 642)
        '
        'grdAllePriser
        '
        Me.grdAllePriser.DataSource = Me.TableMedAllePriserBindingSource
        Me.grdAllePriser.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn93.Header.VisiblePosition = 0
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.Caption = "Prisliste"
        UltraGridColumn94.Header.VisiblePosition = 1
        UltraGridColumn94.Width = 107
        UltraGridColumn95.Header.Caption = "Placering"
        UltraGridColumn95.Header.VisiblePosition = 2
        UltraGridColumn95.Width = 103
        Appearance85.TextHAlignAsString = "Right"
        UltraGridColumn96.CellAppearance = Appearance85
        UltraGridColumn96.Format = "#,##0"
        UltraGridColumn96.Header.Caption = "Fra Mm"
        UltraGridColumn96.Header.VisiblePosition = 3
        UltraGridColumn96.Width = 67
        Appearance86.TextHAlignAsString = "Right"
        UltraGridColumn97.CellAppearance = Appearance86
        UltraGridColumn97.Format = "#,##0"
        UltraGridColumn97.Header.Caption = "Til Mm"
        UltraGridColumn97.Header.VisiblePosition = 4
        UltraGridColumn97.Width = 65
        Appearance87.TextHAlignAsString = "Right"
        UltraGridColumn98.CellAppearance = Appearance87
        UltraGridColumn98.Format = "#,##0.00"
        UltraGridColumn98.Header.Caption = "Mm Pris"
        UltraGridColumn98.Header.VisiblePosition = 5
        UltraGridColumn98.Width = 91
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn99.CellAppearance = Appearance88
        UltraGridColumn99.Format = "#,##0.00"
        UltraGridColumn99.Header.Caption = "Farve pris"
        UltraGridColumn99.Header.VisiblePosition = 6
        UltraGridColumn99.Width = 91
        Appearance89.TextHAlignAsString = "Right"
        UltraGridColumn100.CellAppearance = Appearance89
        UltraGridColumn100.Format = "#,##0"
        UltraGridColumn100.Header.Caption = "Min."
        UltraGridColumn100.Header.VisiblePosition = 7
        UltraGridColumn100.Width = 91
        Appearance90.TextHAlignAsString = "Right"
        UltraGridColumn101.CellAppearance = Appearance90
        UltraGridColumn101.Format = "#,##0"
        UltraGridColumn101.Header.Caption = "Max."
        UltraGridColumn101.Header.VisiblePosition = 8
        UltraGridColumn101.Width = 91
        Appearance91.TextHAlignAsString = "Right"
        UltraGridColumn105.CellAppearance = Appearance91
        UltraGridColumn105.Format = "#,##0.00"
        UltraGridColumn105.Header.Caption = "4 Farve pris"
        UltraGridColumn105.Header.VisiblePosition = 9
        UltraGridColumn105.Width = 91
        Appearance92.TextHAlignAsString = "Right"
        UltraGridColumn106.CellAppearance = Appearance92
        UltraGridColumn106.Format = "#,##0"
        UltraGridColumn106.Header.Caption = "Min."
        UltraGridColumn106.Header.VisiblePosition = 10
        UltraGridColumn106.Width = 91
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn108.CellAppearance = Appearance93
        UltraGridColumn108.Format = "#,##0"
        UltraGridColumn108.Header.Caption = "Max."
        UltraGridColumn108.Header.VisiblePosition = 11
        UltraGridColumn108.Width = 91
        UltraGridColumn109.Header.Caption = "Året"
        UltraGridColumn109.Header.VisiblePosition = 12
        UltraGridColumn110.Header.VisiblePosition = 13
        UltraGridColumn110.Hidden = True
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn105, UltraGridColumn106, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110})
        UltraGridBand10.Indentation = 0
        UltraGridBand10.IndentationGroupByRow = 0
        UltraGridBand10.IndentationGroupByRowExpansionIndicator = 0
        UltraGridBand10.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdAllePriser.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.grdAllePriser.DisplayLayout.Override.GroupByRowInitialExpansionState = Infragistics.Win.UltraWinGrid.GroupByRowInitialExpansionState.Expanded
        Me.grdAllePriser.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdAllePriser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAllePriser.Location = New System.Drawing.Point(0, 0)
        Me.grdAllePriser.Name = "grdAllePriser"
        Me.grdAllePriser.Size = New System.Drawing.Size(893, 642)
        Me.grdAllePriser.TabIndex = 0
        '
        'TableMedAllePriserBindingSource
        '
        Me.TableMedAllePriserBindingSource.DataMember = "tblBladStamdata_tableMedAllePriser"
        Me.TableMedAllePriserBindingSource.DataSource = Me.TblBladStamdataBindingSource
        '
        'tbpTekniskeData
        '
        Me.tbpTekniskeData.Controls.Add(Me.cboUgedag)
        Me.tbpTekniskeData.Controls.Add(Me.txtOplag)
        Me.tbpTekniskeData.Controls.Add(lblOplysningerTilDLUsHjemmeside)
        Me.tbpTekniskeData.Controls.Add(lblHjemmeside)
        Me.tbpTekniskeData.Controls.Add(lblRedaktionsEmail)
        Me.tbpTekniskeData.Controls.Add(lblBladetsAnnonceEmail)
        Me.tbpTekniskeData.Controls.Add(Me.txtHjemmeside)
        Me.tbpTekniskeData.Controls.Add(Me.txtRedaktionsEmail)
        Me.tbpTekniskeData.Controls.Add(Me.txtBladetsAnnonceEmail)
        Me.tbpTekniskeData.Controls.Add(Me.txtMaterialedeadlineRubrik)
        Me.tbpTekniskeData.Controls.Add(lblMaterialedeadlineRubrik)
        Me.tbpTekniskeData.Controls.Add(Me.txtMaterialedeadlineTekst)
        Me.tbpTekniskeData.Controls.Add(lblMaterialedeadlineTekst)
        Me.tbpTekniskeData.Controls.Add(lblForMateriale)
        Me.tbpTekniskeData.Controls.Add(Me.txtOrdredeadlineRubrik)
        Me.tbpTekniskeData.Controls.Add(lblOrdredeadlineRubrik)
        Me.tbpTekniskeData.Controls.Add(Me.txtOrdredeadlineTekst)
        Me.tbpTekniskeData.Controls.Add(lblOrdredeadlineTekst)
        Me.tbpTekniskeData.Controls.Add(lblForOrdrer)
        Me.tbpTekniskeData.Controls.Add(lblDeadlines)
        Me.tbpTekniskeData.Controls.Add(Me.txtFormat)
        Me.tbpTekniskeData.Controls.Add(lblTekniskeDataFormat)
        Me.tbpTekniskeData.Controls.Add(lblUgedag)
        Me.tbpTekniskeData.Controls.Add(lblOplag)
        Me.tbpTekniskeData.Controls.Add(lblTekniskeData)
        Me.tbpTekniskeData.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpTekniskeData.Name = "tbpTekniskeData"
        Me.tbpTekniskeData.Size = New System.Drawing.Size(893, 642)
        '
        'cboUgedag
        '
        Me.cboUgedag.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "UgedagID", True))
        Me.cboUgedag.DataSource = Me.TblDageBindingSource
        Appearance94.BackColor = System.Drawing.SystemColors.Window
        Appearance94.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboUgedag.DisplayLayout.Appearance = Appearance94
        Me.cboUgedag.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn111.Header.VisiblePosition = 0
        UltraGridColumn111.Hidden = True
        UltraGridColumn115.Header.Caption = "Dag"
        UltraGridColumn115.Header.VisiblePosition = 1
        UltraGridColumn116.Header.VisiblePosition = 2
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 3
        UltraGridColumn117.Hidden = True
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn111, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117})
        Me.cboUgedag.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.cboUgedag.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboUgedag.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance95.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance95.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance95.BorderColor = System.Drawing.SystemColors.Window
        Me.cboUgedag.DisplayLayout.GroupByBox.Appearance = Appearance95
        Appearance96.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboUgedag.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance96
        Me.cboUgedag.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance97.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance97.BackColor2 = System.Drawing.SystemColors.Control
        Appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance97.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboUgedag.DisplayLayout.GroupByBox.PromptAppearance = Appearance97
        Me.cboUgedag.DisplayLayout.MaxColScrollRegions = 1
        Me.cboUgedag.DisplayLayout.MaxRowScrollRegions = 1
        Appearance98.BackColor = System.Drawing.SystemColors.Window
        Appearance98.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboUgedag.DisplayLayout.Override.ActiveCellAppearance = Appearance98
        Appearance99.BackColor = System.Drawing.SystemColors.Highlight
        Appearance99.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboUgedag.DisplayLayout.Override.ActiveRowAppearance = Appearance99
        Me.cboUgedag.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboUgedag.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance100.BackColor = System.Drawing.SystemColors.Window
        Me.cboUgedag.DisplayLayout.Override.CardAreaAppearance = Appearance100
        Appearance101.BorderColor = System.Drawing.Color.Silver
        Appearance101.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboUgedag.DisplayLayout.Override.CellAppearance = Appearance101
        Me.cboUgedag.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboUgedag.DisplayLayout.Override.CellPadding = 0
        Appearance102.BackColor = System.Drawing.SystemColors.Control
        Appearance102.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance102.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance102.BorderColor = System.Drawing.SystemColors.Window
        Me.cboUgedag.DisplayLayout.Override.GroupByRowAppearance = Appearance102
        Appearance103.TextHAlignAsString = "Left"
        Me.cboUgedag.DisplayLayout.Override.HeaderAppearance = Appearance103
        Me.cboUgedag.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboUgedag.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance104.BackColor = System.Drawing.SystemColors.Window
        Appearance104.BorderColor = System.Drawing.Color.Silver
        Me.cboUgedag.DisplayLayout.Override.RowAppearance = Appearance104
        Me.cboUgedag.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance105.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboUgedag.DisplayLayout.Override.TemplateAddRowAppearance = Appearance105
        Me.cboUgedag.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboUgedag.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboUgedag.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboUgedag.DisplayMember = "DagNavn"
        Me.cboUgedag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUgedag.Location = New System.Drawing.Point(176, 66)
        Me.cboUgedag.Name = "cboUgedag"
        Me.cboUgedag.NullText = "- Vælg Udgivelsesdag -"
        Me.cboUgedag.Size = New System.Drawing.Size(155, 23)
        Me.cboUgedag.TabIndex = 1
        Me.cboUgedag.ValueMember = "DagID"
        '
        'TblDageBindingSource
        '
        Me.TblDageBindingSource.DataMember = "tblDage"
        Me.TblDageBindingSource.DataSource = Me.UgedagListeDropdown
        '
        'UgedagListeDropdown
        '
        Me.UgedagListeDropdown.DataSetName = "UgedagListeDropdown"
        Me.UgedagListeDropdown.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtOplag
        '
        Me.txtOplag.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Oplag", True))
        Me.txtOplag.Location = New System.Drawing.Point(176, 38)
        Me.txtOplag.Name = "txtOplag"
        Me.txtOplag.NullText = "- Skriv Oplag -"
        Me.txtOplag.Size = New System.Drawing.Size(155, 22)
        Me.txtOplag.TabIndex = 0
        '
        'txtHjemmeside
        '
        Me.txtHjemmeside.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Hjemmeside", True))
        Me.txtHjemmeside.Location = New System.Drawing.Point(616, 38)
        Me.txtHjemmeside.MaxLength = 50
        Me.txtHjemmeside.Name = "txtHjemmeside"
        Me.txtHjemmeside.NullText = "- Skriv Hjemmeside -"
        Me.txtHjemmeside.Size = New System.Drawing.Size(172, 22)
        Me.txtHjemmeside.TabIndex = 7
        '
        'txtRedaktionsEmail
        '
        Me.txtRedaktionsEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "RedaktionEmail", True))
        Me.txtRedaktionsEmail.Location = New System.Drawing.Point(616, 66)
        Me.txtRedaktionsEmail.MaxLength = 50
        Me.txtRedaktionsEmail.Name = "txtRedaktionsEmail"
        Me.txtRedaktionsEmail.NullText = "- Skriv Redaktions email -"
        Me.txtRedaktionsEmail.Size = New System.Drawing.Size(172, 22)
        Me.txtRedaktionsEmail.TabIndex = 8
        '
        'txtBladetsAnnonceEmail
        '
        Me.txtBladetsAnnonceEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "AnnonceEmail", True))
        Me.txtBladetsAnnonceEmail.Location = New System.Drawing.Point(616, 94)
        Me.txtBladetsAnnonceEmail.MaxLength = 50
        Me.txtBladetsAnnonceEmail.Name = "txtBladetsAnnonceEmail"
        Me.txtBladetsAnnonceEmail.NullText = "- Skriv Annonce email -"
        Me.txtBladetsAnnonceEmail.Size = New System.Drawing.Size(172, 22)
        Me.txtBladetsAnnonceEmail.TabIndex = 9
        '
        'txtMaterialedeadlineRubrik
        '
        Me.txtMaterialedeadlineRubrik.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "MaterialedeadlineRubrik", True))
        Me.txtMaterialedeadlineRubrik.Location = New System.Drawing.Point(176, 287)
        Me.txtMaterialedeadlineRubrik.Name = "txtMaterialedeadlineRubrik"
        Me.txtMaterialedeadlineRubrik.NullText = "- Skriv Deadline -"
        Me.txtMaterialedeadlineRubrik.Size = New System.Drawing.Size(155, 22)
        Me.txtMaterialedeadlineRubrik.TabIndex = 6
        '
        'txtMaterialedeadlineTekst
        '
        Me.txtMaterialedeadlineTekst.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "MaterialedeadlineTekst", True))
        Me.txtMaterialedeadlineTekst.Location = New System.Drawing.Point(176, 259)
        Me.txtMaterialedeadlineTekst.Name = "txtMaterialedeadlineTekst"
        Me.txtMaterialedeadlineTekst.NullText = "- Skriv Deadline -"
        Me.txtMaterialedeadlineTekst.Size = New System.Drawing.Size(155, 22)
        Me.txtMaterialedeadlineTekst.TabIndex = 5
        '
        'txtOrdredeadlineRubrik
        '
        Me.txtOrdredeadlineRubrik.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "OrdredeadlineRubrik", True))
        Me.txtOrdredeadlineRubrik.Location = New System.Drawing.Point(176, 212)
        Me.txtOrdredeadlineRubrik.Name = "txtOrdredeadlineRubrik"
        Me.txtOrdredeadlineRubrik.NullText = "- Skriv Deadline -"
        Me.txtOrdredeadlineRubrik.Size = New System.Drawing.Size(155, 22)
        Me.txtOrdredeadlineRubrik.TabIndex = 4
        '
        'txtOrdredeadlineTekst
        '
        Me.txtOrdredeadlineTekst.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "OrdredeadlineTekst", True))
        Me.txtOrdredeadlineTekst.Location = New System.Drawing.Point(176, 184)
        Me.txtOrdredeadlineTekst.Name = "txtOrdredeadlineTekst"
        Me.txtOrdredeadlineTekst.NullText = "- Skriv Deadline -"
        Me.txtOrdredeadlineTekst.Size = New System.Drawing.Size(155, 22)
        Me.txtOrdredeadlineTekst.TabIndex = 3
        '
        'txtFormat
        '
        Me.txtFormat.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Format", True))
        Me.txtFormat.Location = New System.Drawing.Point(176, 94)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.NullText = "- Skriv Format -"
        Me.txtFormat.Size = New System.Drawing.Size(155, 22)
        Me.txtFormat.TabIndex = 2
        '
        'tbpUdsending
        '
        Me.tbpUdsending.Controls.Add(Me.cboTjeklisteDag)
        Me.tbpUdsending.Controls.Add(lblBogholderiEmails)
        Me.tbpUdsending.Controls.Add(Me.txtBogholderiEmails)
        Me.tbpUdsending.Controls.Add(lblKontaktpersonerEmails)
        Me.tbpUdsending.Controls.Add(Me.txtKontaktpersonerEmails)
        Me.tbpUdsending.Controls.Add(lblEmails)
        Me.tbpUdsending.Controls.Add(Me.txtEmails)
        Me.tbpUdsending.Controls.Add(lblOrienteringEmails)
        Me.tbpUdsending.Controls.Add(Me.txtOrienteringsEmails)
        Me.tbpUdsending.Controls.Add(Me.txtBilagsbladeEmail)
        Me.tbpUdsending.Controls.Add(lblBilagsbladeEmail)
        Me.tbpUdsending.Controls.Add(Me.txtAnnoncekontrolEmail)
        Me.tbpUdsending.Controls.Add(lblAnnoncekontrolEmail)
        Me.tbpUdsending.Controls.Add(Me.txtMaterialeEmail)
        Me.tbpUdsending.Controls.Add(lblMaterialeEmail)
        Me.tbpUdsending.Controls.Add(lblMedienet)
        Me.tbpUdsending.Controls.Add(lblMedienetID)
        Me.tbpUdsending.Controls.Add(Me.txtMedienetID)
        Me.tbpUdsending.Controls.Add(lblAnsvarligFor)
        Me.tbpUdsending.Controls.Add(lblAnsvarligForStamdataEmail)
        Me.tbpUdsending.Controls.Add(lblPrisforespørgselEmails)
        Me.tbpUdsending.Controls.Add(Me.txtAnsvarligForStamdataEmail)
        Me.tbpUdsending.Controls.Add(Me.txtPrisforespørgselEmails)
        Me.tbpUdsending.Controls.Add(Me.txtOrdrecheckEmail)
        Me.tbpUdsending.Controls.Add(lblOrdrecheckEmail)
        Me.tbpUdsending.Controls.Add(Me.txtOrdreEmail)
        Me.tbpUdsending.Controls.Add(lblOrdreEmail)
        Me.tbpUdsending.Controls.Add(lblUdsending)
        Me.tbpUdsending.Controls.Add(lblUdsendelsesTidspunkt)
        Me.tbpUdsending.Controls.Add(Me.cboUdsendelsesTidspunkt)
        Me.tbpUdsending.Controls.Add(Me.chkSendIndeværendeUge)
        Me.tbpUdsending.Location = New System.Drawing.Point(-10000, -10000)
        Me.tbpUdsending.Name = "tbpUdsending"
        Me.tbpUdsending.Size = New System.Drawing.Size(893, 642)
        '
        'cboTjeklisteDag
        '
        Me.cboTjeklisteDag.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "OrdrecheckSendeDagID", True))
        Me.cboTjeklisteDag.DataSource = Me.TblDageBindingSource
        Me.cboTjeklisteDag.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn118.Header.VisiblePosition = 0
        UltraGridColumn118.Hidden = True
        UltraGridColumn120.Header.Caption = "Dag"
        UltraGridColumn120.Header.VisiblePosition = 1
        UltraGridColumn121.Header.VisiblePosition = 2
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 3
        UltraGridColumn122.Hidden = True
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn118, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122})
        Me.cboTjeklisteDag.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.cboTjeklisteDag.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboTjeklisteDag.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance106.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance106.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance106.BorderColor = System.Drawing.SystemColors.Window
        Me.cboTjeklisteDag.DisplayLayout.GroupByBox.Appearance = Appearance106
        Appearance107.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboTjeklisteDag.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance107
        Me.cboTjeklisteDag.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance108.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance108.BackColor2 = System.Drawing.SystemColors.Control
        Appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance108.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboTjeklisteDag.DisplayLayout.GroupByBox.PromptAppearance = Appearance108
        Me.cboTjeklisteDag.DisplayLayout.MaxColScrollRegions = 1
        Me.cboTjeklisteDag.DisplayLayout.MaxRowScrollRegions = 1
        Appearance109.BackColor = System.Drawing.SystemColors.Window
        Appearance109.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboTjeklisteDag.DisplayLayout.Override.ActiveCellAppearance = Appearance109
        Appearance110.BackColor = System.Drawing.SystemColors.Highlight
        Appearance110.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboTjeklisteDag.DisplayLayout.Override.ActiveRowAppearance = Appearance110
        Me.cboTjeklisteDag.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboTjeklisteDag.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance111.BackColor = System.Drawing.SystemColors.Window
        Me.cboTjeklisteDag.DisplayLayout.Override.CardAreaAppearance = Appearance111
        Appearance112.BorderColor = System.Drawing.Color.Silver
        Appearance112.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboTjeklisteDag.DisplayLayout.Override.CellAppearance = Appearance112
        Me.cboTjeklisteDag.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboTjeklisteDag.DisplayLayout.Override.CellPadding = 0
        Appearance113.BackColor = System.Drawing.SystemColors.Control
        Appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance113.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance113.BorderColor = System.Drawing.SystemColors.Window
        Me.cboTjeklisteDag.DisplayLayout.Override.GroupByRowAppearance = Appearance113
        Appearance114.TextHAlignAsString = "Left"
        Me.cboTjeklisteDag.DisplayLayout.Override.HeaderAppearance = Appearance114
        Me.cboTjeklisteDag.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboTjeklisteDag.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance115.BackColor = System.Drawing.SystemColors.Window
        Appearance115.BorderColor = System.Drawing.Color.Silver
        Me.cboTjeklisteDag.DisplayLayout.Override.RowAppearance = Appearance115
        Me.cboTjeklisteDag.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance116.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboTjeklisteDag.DisplayLayout.Override.TemplateAddRowAppearance = Appearance116
        Me.cboTjeklisteDag.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboTjeklisteDag.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboTjeklisteDag.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboTjeklisteDag.DisplayMember = "DagNavn"
        Me.cboTjeklisteDag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTjeklisteDag.Location = New System.Drawing.Point(170, 122)
        Me.cboTjeklisteDag.Name = "cboTjeklisteDag"
        Me.cboTjeklisteDag.Size = New System.Drawing.Size(100, 23)
        Me.cboTjeklisteDag.TabIndex = 3
        Me.cboTjeklisteDag.ValueMember = "DagID"
        '
        'txtBogholderiEmails
        '
        Me.txtBogholderiEmails.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "BogholderiEmails", True))
        Me.txtBogholderiEmails.Location = New System.Drawing.Point(170, 401)
        Me.txtBogholderiEmails.MaxLength = 200
        Me.txtBogholderiEmails.Name = "txtBogholderiEmails"
        Me.txtBogholderiEmails.NullText = "- Skriv 1 eller flere Bogholderi emails, adskilt med semikolon -"
        Me.txtBogholderiEmails.Size = New System.Drawing.Size(675, 22)
        Me.txtBogholderiEmails.TabIndex = 12
        '
        'txtKontaktpersonerEmails
        '
        Me.txtKontaktpersonerEmails.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "KontaktpersonerEmails", True))
        Me.txtKontaktpersonerEmails.Location = New System.Drawing.Point(170, 373)
        Me.txtKontaktpersonerEmails.MaxLength = 200
        Me.txtKontaktpersonerEmails.Name = "txtKontaktpersonerEmails"
        Me.txtKontaktpersonerEmails.NullText = "- Skriv 1 eller flere Kontaktperson emails, adskilt med semikolon -"
        Me.txtKontaktpersonerEmails.Size = New System.Drawing.Size(675, 22)
        Me.txtKontaktpersonerEmails.TabIndex = 11
        '
        'txtEmails
        '
        Me.txtEmails.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "Emails", True))
        Me.txtEmails.Location = New System.Drawing.Point(170, 345)
        Me.txtEmails.MaxLength = 200
        Me.txtEmails.Name = "txtEmails"
        Me.txtEmails.NullText = "- Skriv 1 eller flere Emails, adskilt med semikolon -"
        Me.txtEmails.Size = New System.Drawing.Size(675, 22)
        Me.txtEmails.TabIndex = 10
        '
        'txtOrienteringsEmails
        '
        Me.txtOrienteringsEmails.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "OrienteringEmails", True))
        Me.txtOrienteringsEmails.Location = New System.Drawing.Point(170, 317)
        Me.txtOrienteringsEmails.MaxLength = 200
        Me.txtOrienteringsEmails.Name = "txtOrienteringsEmails"
        Me.txtOrienteringsEmails.NullText = "- Skriv 1 eller flere Orientering emails, adskilt med semikolon -"
        Me.txtOrienteringsEmails.Size = New System.Drawing.Size(675, 22)
        Me.txtOrienteringsEmails.TabIndex = 9
        '
        'txtBilagsbladeEmail
        '
        Me.txtBilagsbladeEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "BilagsbladeEmail", True))
        Me.txtBilagsbladeEmail.Location = New System.Drawing.Point(170, 200)
        Me.txtBilagsbladeEmail.MaxLength = 50
        Me.txtBilagsbladeEmail.Name = "txtBilagsbladeEmail"
        Me.txtBilagsbladeEmail.NullText = "- Skriv Bilagsblade email -"
        Me.txtBilagsbladeEmail.Size = New System.Drawing.Size(260, 22)
        Me.txtBilagsbladeEmail.TabIndex = 6
        '
        'txtAnnoncekontrolEmail
        '
        Me.txtAnnoncekontrolEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "AnnonceKontrolEmail", True))
        Me.txtAnnoncekontrolEmail.Location = New System.Drawing.Point(170, 172)
        Me.txtAnnoncekontrolEmail.MaxLength = 50
        Me.txtAnnoncekontrolEmail.Name = "txtAnnoncekontrolEmail"
        Me.txtAnnoncekontrolEmail.NullText = "- Skriv Annoncekontrol email -"
        Me.txtAnnoncekontrolEmail.Size = New System.Drawing.Size(260, 22)
        Me.txtAnnoncekontrolEmail.TabIndex = 5
        '
        'txtMaterialeEmail
        '
        Me.txtMaterialeEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "MaterialeEmail", True))
        Me.txtMaterialeEmail.Location = New System.Drawing.Point(170, 66)
        Me.txtMaterialeEmail.MaxLength = 50
        Me.txtMaterialeEmail.Name = "txtMaterialeEmail"
        Me.txtMaterialeEmail.NullText = "- Skriv Materiale email -"
        Me.txtMaterialeEmail.Size = New System.Drawing.Size(260, 22)
        Me.txtMaterialeEmail.TabIndex = 1
        '
        'txtMedienetID
        '
        Me.txtMedienetID.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "MedieNetKode", True))
        Me.txtMedienetID.Location = New System.Drawing.Point(539, 94)
        Me.txtMedienetID.Name = "txtMedienetID"
        Me.txtMedienetID.NullText = "- Skriv Medienet ID -"
        Me.txtMedienetID.Size = New System.Drawing.Size(170, 22)
        Me.txtMedienetID.TabIndex = 13
        '
        'txtAnsvarligForStamdataEmail
        '
        Me.txtAnsvarligForStamdataEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "StamdataEmail", True))
        Me.txtAnsvarligForStamdataEmail.Location = New System.Drawing.Point(170, 261)
        Me.txtAnsvarligForStamdataEmail.MaxLength = 50
        Me.txtAnsvarligForStamdataEmail.Name = "txtAnsvarligForStamdataEmail"
        Me.txtAnsvarligForStamdataEmail.NullText = "- Skriv Stamdata ansvarlig email -"
        Me.txtAnsvarligForStamdataEmail.Size = New System.Drawing.Size(260, 22)
        Me.txtAnsvarligForStamdataEmail.TabIndex = 7
        '
        'txtPrisforespørgselEmails
        '
        Me.txtPrisforespørgselEmails.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "PrisforespørgselEmails", True))
        Me.txtPrisforespørgselEmails.Location = New System.Drawing.Point(170, 289)
        Me.txtPrisforespørgselEmails.MaxLength = 200
        Me.txtPrisforespørgselEmails.Name = "txtPrisforespørgselEmails"
        Me.txtPrisforespørgselEmails.NullText = "- Skriv 1 eller flere Prisforespørgsel emails, adskilt med semikolon -"
        Me.txtPrisforespørgselEmails.Size = New System.Drawing.Size(675, 22)
        Me.txtPrisforespørgselEmails.TabIndex = 8
        '
        'txtOrdrecheckEmail
        '
        Me.txtOrdrecheckEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "OrdrecheckEmail", True))
        Me.txtOrdrecheckEmail.Location = New System.Drawing.Point(170, 94)
        Me.txtOrdrecheckEmail.MaxLength = 50
        Me.txtOrdrecheckEmail.Name = "txtOrdrecheckEmail"
        Me.txtOrdrecheckEmail.NullText = "- Skriv Tjekliste email -"
        Me.txtOrdrecheckEmail.Size = New System.Drawing.Size(260, 22)
        Me.txtOrdrecheckEmail.TabIndex = 2
        '
        'txtOrdreEmail
        '
        Me.txtOrdreEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "OrdreEmail", True))
        Me.txtOrdreEmail.Location = New System.Drawing.Point(170, 38)
        Me.txtOrdreEmail.MaxLength = 200
        Me.txtOrdreEmail.Name = "txtOrdreEmail"
        Me.txtOrdreEmail.NullText = "- Skriv 1 eller flere Ordre emails, adskilt med semikolon -"
        Me.txtOrdreEmail.Size = New System.Drawing.Size(675, 22)
        Me.txtOrdreEmail.TabIndex = 0
        '
        'cboUdsendelsesTidspunkt
        '
        Me.cboUdsendelsesTidspunkt.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBladStamdataBindingSource, "SendetidOrdrecheck", True))
        Me.cboUdsendelsesTidspunkt.DisplayMember = ""
        Me.cboUdsendelsesTidspunkt.Location = New System.Drawing.Point(288, 122)
        Me.cboUdsendelsesTidspunkt.Name = "cboUdsendelsesTidspunkt"
        Me.cboUdsendelsesTidspunkt.NullText = "- Vælg Tidspunkt -"
        Me.cboUdsendelsesTidspunkt.Size = New System.Drawing.Size(142, 22)
        Me.cboUdsendelsesTidspunkt.TabIndex = 4
        '
        'chkSendIndeværendeUge
        '
        Me.chkSendIndeværendeUge.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblBladStamdataBindingSource, "SendIndeværendeUge", True))
        Me.chkSendIndeværendeUge.Location = New System.Drawing.Point(170, 150)
        Me.chkSendIndeværendeUge.Name = "chkSendIndeværendeUge"
        Me.chkSendIndeværendeUge.Size = New System.Drawing.Size(237, 16)
        Me.chkSendIndeværendeUge.TabIndex = 112
        Me.chkSendIndeværendeUge.Text = "Send liste for indeværende uge"
        '
        'FKtblÅrMedPrisertblBladStamdataBindingSource
        '
        Me.FKtblÅrMedPrisertblBladStamdataBindingSource.DataMember = "FK_tblÅrMedPriser_tblBladStamdata"
        Me.FKtblÅrMedPrisertblBladStamdataBindingSource.DataSource = Me.TblBladStamdataBindingSource
        '
        'tabStamdata
        '
        Me.tabStamdata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabStamdata.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabStamdata.Controls.Add(Me.tbpNavnAdresse)
        Me.tabStamdata.Controls.Add(Me.tbpPriser)
        Me.tabStamdata.Controls.Add(Me.tbpDækningsområde)
        Me.tabStamdata.Controls.Add(Me.tbpTekniskeData)
        Me.tabStamdata.Controls.Add(Me.tbpUdsending)
        Me.tabStamdata.Controls.Add(Me.tbpPriserOversigt)
        Me.tabStamdata.Location = New System.Drawing.Point(0, 28)
        Me.tabStamdata.Name = "tabStamdata"
        Me.tabStamdata.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabStamdata.Size = New System.Drawing.Size(895, 663)
        Me.tabStamdata.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.tabStamdata.TabIndex = 2
        UltraTab10.TabPage = Me.tbpNavnAdresse
        UltraTab10.Text = "Navn / Adresse"
        UltraTab11.TabPage = Me.tbpDækningsområde
        UltraTab11.Text = "Dækningsområde"
        UltraTab12.TabPage = Me.tbpPriser
        UltraTab12.Text = "Priser"
        UltraTab19.TabPage = Me.tbpPriserOversigt
        UltraTab19.Text = "Priser oversigt"
        UltraTab13.TabPage = Me.tbpTekniskeData
        UltraTab13.Text = "Tekniske Data"
        UltraTab14.TabPage = Me.tbpUdsending
        UltraTab14.Text = "Udsending"
        Me.tabStamdata.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab11, UltraTab12, UltraTab19, UltraTab13, UltraTab14})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(893, 642)
        '
        'TblBladStamdataBindingNavigator
        '
        Me.TblBladStamdataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblBladStamdataBindingNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblBladStamdataBindingNavigator.AutoSize = False
        Me.TblBladStamdataBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TblBladStamdataBindingNavigator.BindingSource = Me.TblBladStamdataBindingSource
        Me.TblBladStamdataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblBladStamdataBindingNavigator.CountItemFormat = "af {0}"
        Me.TblBladStamdataBindingNavigator.DeleteItem = Nothing
        Me.TblBladStamdataBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblBladStamdataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.TblBladStamdataBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.tslAvisNavn})
        Me.TblBladStamdataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblBladStamdataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblBladStamdataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblBladStamdataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblBladStamdataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblBladStamdataBindingNavigator.Name = "TblBladStamdataBindingNavigator"
        Me.TblBladStamdataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblBladStamdataBindingNavigator.Size = New System.Drawing.Size(987, 25)
        Me.TblBladStamdataBindingNavigator.TabIndex = 322
        Me.TblBladStamdataBindingNavigator.Text = "Naviger ugeaviser"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(96, 22)
        Me.BindingNavigatorAddNewItem.Text = "Opret ny avis"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "af {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Antal ugeaviser i alt"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Flyt til første avis"
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "Flyt til første avis"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Flyt til forrige avis"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BindingNavigatorPositionItem.ToolTipText = "Nuværende position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Flyt til næste avis"
        Me.BindingNavigatorMoveNextItem.ToolTipText = "Flyt til næste avis"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Flyt til sidste avis"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblBladStamdataBindingNavigatorSaveItem
        '
        Me.TblBladStamdataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblBladStamdataBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblBladStamdataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblBladStamdataBindingNavigatorSaveItem.Name = "TblBladStamdataBindingNavigatorSaveItem"
        Me.TblBladStamdataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblBladStamdataBindingNavigatorSaveItem.Text = "Gem Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslAvisNavn
        '
        Me.tslAvisNavn.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslAvisNavn.Name = "tslAvisNavn"
        Me.tslAvisNavn.Size = New System.Drawing.Size(135, 22)
        Me.tslAvisNavn.Text = "Den Lokale Ugeavis"
        Me.tslAvisNavn.ToolTipText = "ID og Navn på valgt avis"
        '
        'lblBigStamdata
        '
        Me.lblBigStamdata.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBigStamdata.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBigStamdata.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblBigStamdata.Location = New System.Drawing.Point(850, 0)
        Me.lblBigStamdata.Name = "lblBigStamdata"
        Me.lblBigStamdata.Size = New System.Drawing.Size(137, 29)
        Me.lblBigStamdata.TabIndex = 323
        Me.lblBigStamdata.Text = "Stamdata"
        '
        'imgChain
        '
        Me.imgChain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgChain.BorderShadowColor = System.Drawing.Color.Empty
        Me.imgChain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgChain.Image = Global.WinPlanner.My.Resources.Resources.chainOpen
        Me.imgChain.Location = New System.Drawing.Point(909, 662)
        Me.imgChain.Name = "imgChain"
        Me.imgChain.Size = New System.Drawing.Size(56, 56)
        Me.imgChain.TabIndex = 321
        Me.imgChain.Visible = False
        '
        'imgLock
        '
        Me.imgLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgLock.BorderShadowColor = System.Drawing.Color.Empty
        Me.imgLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgLock.Image = Global.WinPlanner.My.Resources.Resources.lockClose
        Me.imgLock.Location = New System.Drawing.Point(901, 48)
        Me.imgLock.Name = "imgLock"
        Me.imgLock.ScaleImage = Infragistics.Win.ScaleImage.Never
        Me.imgLock.Size = New System.Drawing.Size(64, 64)
        Me.imgLock.TabIndex = 320
        Me.imgLock.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnGem
        '
        Me.btnGem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGem.Location = New System.Drawing.Point(808, 703)
        Me.btnGem.Name = "btnGem"
        Me.btnGem.ShowFocusRect = False
        Me.btnGem.ShowOutline = False
        Me.btnGem.Size = New System.Drawing.Size(87, 24)
        Me.btnGem.TabIndex = 337
        Me.btnGem.Text = "Opdatere"
        Me.btnGem.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnAnnuller
        '
        Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnnuller.Location = New System.Drawing.Point(12, 703)
        Me.btnAnnuller.Name = "btnAnnuller"
        Me.btnAnnuller.ShowFocusRect = False
        Me.btnAnnuller.ShowOutline = False
        Me.btnAnnuller.Size = New System.Drawing.Size(87, 24)
        Me.btnAnnuller.TabIndex = 339
        Me.btnAnnuller.Text = "&Annuller"
        Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnLuk
        '
        Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuk.Location = New System.Drawing.Point(105, 703)
        Me.btnLuk.Name = "btnLuk"
        Me.btnLuk.ShowFocusRect = False
        Me.btnLuk.ShowOutline = False
        Me.btnLuk.Size = New System.Drawing.Size(87, 24)
        Me.btnLuk.TabIndex = 340
        Me.btnLuk.Text = "&Luk"
        Me.btnLuk.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'btnUdskriv
        '
        Me.btnUdskriv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUdskriv.Location = New System.Drawing.Point(700, 703)
        Me.btnUdskriv.Name = "btnUdskriv"
        Me.btnUdskriv.ShowFocusRect = False
        Me.btnUdskriv.ShowOutline = False
        Me.btnUdskriv.Size = New System.Drawing.Size(87, 24)
        Me.btnUdskriv.TabIndex = 368
        Me.btnUdskriv.Text = "&Udskriv"
        Me.btnUdskriv.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(298, 705)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 13)
        Me.statusLabel.TabIndex = 369
        '
        'Label_Status
        '
        Me.Label_Status.AutoSize = True
        Me.Label_Status.Location = New System.Drawing.Point(253, 705)
        Me.Label_Status.Name = "Label_Status"
        Me.Label_Status.Size = New System.Drawing.Size(0, 13)
        Me.Label_Status.TabIndex = 370
        '
        'TblPostNrTableAdapter
        '
        Me.TblPostNrTableAdapter.ClearBeforeFill = True
        '
        'TblRegionTableAdapter
        '
        Me.TblRegionTableAdapter.ClearBeforeFill = True
        '
        'TblDelOmrådeTableAdapter
        '
        Me.TblDelOmrådeTableAdapter.ClearBeforeFill = True
        '
        'TblGeoKodeTableAdapter
        '
        Me.TblGeoKodeTableAdapter.ClearBeforeFill = True
        '
        'TblDageTableAdapter
        '
        Me.TblDageTableAdapter.ClearBeforeFill = True
        '
        'TblBladStamdataBindingSource
        '
        Me.TblBladStamdataBindingSource.AllowNew = True
        Me.TblBladStamdataBindingSource.DataMember = "tblBladStamdata"
        Me.TblBladStamdataBindingSource.DataSource = Me.DstBladStamdata
        '
        'DstBladStamdata
        '
        Me.DstBladStamdata.DataSetName = "dstBladStamdata"
        Me.DstBladStamdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBladStamdataTableAdapter
        '
        Me.TblBladStamdataTableAdapter.ClearBeforeFill = True
        '
        'TblBladDækningTableAdapter
        '
        Me.TblBladDækningTableAdapter.ClearBeforeFill = True
        '
        'TblPrislisterPrBladPrUgeTableAdapter
        '
        Me.TblPrislisterPrBladPrUgeTableAdapter.ClearBeforeFill = True
        '
        'TableMedAllePriserTableAdapter
        '
        Me.TableMedAllePriserTableAdapter.ClearBeforeFill = True
        '
        'TblPrislisterPrBladPrÅrTableAdapter
        '
        Me.TblPrislisterPrBladPrÅrTableAdapter.ClearBeforeFill = True
        '
        'TblÅrMedPriserTableAdapter
        '
        Me.TblÅrMedPriserTableAdapter.ClearBeforeFill = True
        '
        'FrmBladStamData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(985, 739)
        Me.Controls.Add(Me.Label_Status)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.btnUdskriv)
        Me.Controls.Add(Me.btnAnnuller)
        Me.Controls.Add(Me.btnLuk)
        Me.Controls.Add(Me.btnGem)
        Me.Controls.Add(Me.lblBigStamdata)
        Me.Controls.Add(Me.TblBladStamdataBindingNavigator)
        Me.Controls.Add(Me.tabStamdata)
        Me.Controls.Add(Me.imgChain)
        Me.Controls.Add(Me.imgLock)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(967, 300)
        Me.Name = "FrmBladStamData"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " "
        CType(Me.cboPostNrDækning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPostNrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostNrListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPrislisterPrÅr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpTekstside.ResumeLayout(False)
        CType(Me.grpPriser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPriser.ResumeLayout(False)
        Me.grpPriser.PerformLayout()
        CType(Me.txt4FarvertillægMax8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMin8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4Farvertillæg8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMax8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMin8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMmPris8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatTil8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatFra8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1Farvetillæg8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMax7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMin7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4Farvertillæg7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMax7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMin7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMmPris7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatTil7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatFra7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1Farvetillæg7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optFarverabatMåGives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMax6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMin6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4Farvertillæg6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMax6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMin6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMmPris6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatTil6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatFra6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1Farvetillæg6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMax5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMin5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4Farvertillæg5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMax5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMin5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMmPris5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatTil5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatFra5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1Farvetillæg5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMax4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMin4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4Farvertillæg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMax4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMin4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMmPris4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatTil4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatFra4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1Farvetillæg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMax3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMin3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4Farvertillæg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMax3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMin3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMmPris3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatTil3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatFra3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1Farvetillæg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMax2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4Farvertillæg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMax2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMmPris2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatTil2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatFra2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1Farvetillæg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMax1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4FarvertillægMin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4Farvertillæg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMax1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1FarvetillægMin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMmPris1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatTil1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatFra1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1Farvetillæg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpNavnAdresse.ResumeLayout(False)
        Me.tbpNavnAdresse.PerformLayout()
        CType(Me.txtKoncern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPostNr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEjerforhold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optHovedgruppe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUgeavisID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboÅr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMåned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOphørt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedPåWWW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKontaktperson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFIK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCVR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdresse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdresse2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBynavn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDækningsområde.ResumeLayout(False)
        Me.tbpDækningsområde.PerformLayout()
        CType(Me.cboGeoKode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGeoKodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeoKodeListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDelområde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDelOmrådeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelområdeListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRegion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRegionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegionListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDækning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBladDækningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalområdePct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrimærPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalområde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrimær, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPriser.ResumeLayout(False)
        Me.tbpPriser.PerformLayout()
        CType(Me.cboPriserÅr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblÅrMedPrisertblBladStamdataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPrislister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPrislisterPrBladPrUgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPrislisterPrBladPrUgeUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPriser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPriser.ResumeLayout(False)
        Me.UltraTabSharedControlsPage3.ResumeLayout(False)
        Me.tbpPriserOversigt.ResumeLayout(False)
        CType(Me.grdAllePriser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableMedAllePriserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpTekniskeData.ResumeLayout(False)
        Me.tbpTekniskeData.PerformLayout()
        CType(Me.cboUgedag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UgedagListeDropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOplag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHjemmeside, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRedaktionsEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBladetsAnnonceEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialedeadlineRubrik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialedeadlineTekst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdredeadlineRubrik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdredeadlineTekst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpUdsending.ResumeLayout(False)
        Me.tbpUdsending.PerformLayout()
        CType(Me.cboTjeklisteDag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBogholderiEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKontaktpersonerEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrienteringsEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBilagsbladeEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnnoncekontrolEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialeEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedienetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnsvarligForStamdataEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrisforespørgselEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdrecheckEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdreEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUdsendelsesTidspunkt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSendIndeværendeUge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblÅrMedPrisertblBladStamdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabStamdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabStamdata.ResumeLayout(False)
        CType(Me.TblBladStamdataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblBladStamdataBindingNavigator.ResumeLayout(False)
        Me.TblBladStamdataBindingNavigator.PerformLayout()
        CType(Me.TblBladStamdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstBladStamdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabStamdata As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tbpNavnAdresse As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpPriser As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpTekniskeData As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabPriser As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tbpTekstside As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpRubrik As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpMotor As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpForlystelser As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpOfficielle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpStillinger As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpBolig As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpUddannelse As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grpPriser As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtFormatFra1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatTil1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMmPris1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMin1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1Farvetillæg1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMax1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMax1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4Farvertillæg1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMin1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents imgLock As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents imgChain As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents tbpDækningsområde As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents WWWDækningSomTekstUltraFormattedTextEditor As Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor
    Friend WithEvents txtPrimærPct As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtPrimær As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTotalområde As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTotalområdePct As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtKontaktperson As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFIK As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCVR As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents medFax As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents medTlf As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtAdresse As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNavn As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtAdresse2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtBynavn As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboÅr As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboMåned As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkOphørt As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkMedPåWWW As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtFormat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtOrdredeadlineRubrik As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtOrdredeadlineTekst As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMaterialedeadlineRubrik As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMaterialedeadlineTekst As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtUgeavisID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMax4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMin4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4Farvertillæg4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMax4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMin4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMmPris4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatTil4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatFra4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1Farvetillæg4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMax3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMin3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4Farvertillæg3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMax3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMin3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMmPris3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatTil3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatFra3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1Farvetillæg3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMax2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMin2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4Farvertillæg2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMax2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMin2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMmPris2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatTil2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatFra2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1Farvetillæg2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TblBladStamdataTableAdapter As WinPlanner.dstBladStamdataTableAdapters.tblBladStamdataTableAdapter
    Friend WithEvents DstBladStamdata As WinPlanner.dstBladStamdata
    Friend WithEvents TblBladStamdataBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblBladStamdataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblBladStamdataBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents optHovedgruppe As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents tbpUdsending As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txtMedienetID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtAnsvarligForStamdataEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtPrisforespørgselEmails As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtOrdrecheckEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtOrdreEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboUdsendelsesTidspunkt As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkSendIndeværendeUge As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtAnnoncekontrolEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMaterialeEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtBilagsbladeEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtBogholderiEmails As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtKontaktpersonerEmails As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtEmails As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtOrienteringsEmails As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtEjerforhold As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMax5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMin5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4Farvertillæg5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMax5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMin5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMmPris5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatTil5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatFra5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1Farvetillæg5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMax6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMin6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4Farvertillæg6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMax6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMin6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMmPris6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatTil6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatFra6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1Farvetillæg6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtHjemmeside As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRedaktionsEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtBladetsAnnonceEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblBigStamdata As System.Windows.Forms.Label
    Friend WithEvents txtOplag As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tbpSide3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpSide5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpHøjreSide As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tbpSide7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents lbl4Farver As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl1Farve As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl4FarvertillægMax As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl1FarvetillægMin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl4FarvertillægMin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl1FarvetillægMax As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnTilføjPrisliste As Infragistics.Win.Misc.UltraButton
    Friend WithEvents TblBladDækningBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblBladDækningTableAdapter As WinPlanner.dstBladStamdataTableAdapters.tblBladDækningTableAdapter
    Friend WithEvents grdDækning As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents TblPrislisterPrBladPrUgeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPrislisterPrBladPrUgeTableAdapter As WinPlanner.dstBladStamdataTableAdapters.tblPrislisterPrBladPrUgeTableAdapter
    Friend WithEvents TblPrislisterPrBladPrUgeUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tbpPriserOversigt As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents TableMedAllePriserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableMedAllePriserTableAdapter As WinPlanner.dstBladStamdataTableAdapters.tableMedAllePriserTableAdapter
    Friend WithEvents grdAllePriser As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents PostNrListeDropdown As WinPlanner.PostNrListeDropdown
    Friend WithEvents TblPostNrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPostNrTableAdapter As WinPlanner.PostNrListeDropdownTableAdapters.tblPostNrTableAdapter
    Friend WithEvents cboPostNr As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboPostNrDækning As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboRegion As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents RegionListeDropdown As WinPlanner.RegionListeDropdown
    Friend WithEvents TblRegionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRegionTableAdapter As WinPlanner.RegionListeDropdownTableAdapters.tblRegionTableAdapter
    Friend WithEvents cboDelområde As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents DelområdeListeDropdown As WinPlanner.DelområdeListeDropdown
    Friend WithEvents TblDelOmrådeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDelOmrådeTableAdapter As WinPlanner.DelområdeListeDropdownTableAdapters.tblDelOmrådeTableAdapter
    Friend WithEvents cboGeoKode As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents GeoKodeListeDropdown As WinPlanner.GeoKodeListeDropdown
    Friend WithEvents TblGeoKodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblGeoKodeTableAdapter As WinPlanner.GeoKodeListeDropdownTableAdapters.tblGeoKodeTableAdapter
    Friend WithEvents cboUgedag As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UgedagListeDropdown As WinPlanner.UgedagListeDropdown
    Friend WithEvents TblDageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDageTableAdapter As WinPlanner.UgedagListeDropdownTableAdapters.tblDageTableAdapter
    Friend WithEvents cboTjeklisteDag As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboPrislister As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents FKtblPrislisterPrBladPrÅrtblBladStamdataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPrislisterPrBladPrÅrTableAdapter As WinPlanner.dstBladStamdataTableAdapters.tblPrislisterPrBladPrÅrTableAdapter
    Friend WithEvents cboPriserÅr As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents FKtblÅrMedPrisertblBladStamdataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblÅrMedPriserTableAdapter As WinPlanner.dstBladStamdataTableAdapters.tblÅrMedPriserTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslAvisNavn As System.Windows.Forms.ToolStripLabel
    Private WithEvents btnGem As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnLuk As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnUdskriv As Infragistics.Win.Misc.UltraButton
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents optFarverabatMåGives As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboPrislisterPrÅr As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtKoncern As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMax8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMin8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4Farvertillæg8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMax8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMin8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMmPris8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatTil8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatFra8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1Farvetillæg8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMax7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4FarvertillægMin7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt4Farvertillæg7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMax7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1FarvetillægMin7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMmPris7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatTil7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFormatFra7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt1Farvetillæg7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents FKtblÅrMedPrisertblBladStamdataBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents Label_Status As System.Windows.Forms.Label
End Class
