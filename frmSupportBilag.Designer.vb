<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupportBilag
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
    Dim lblL�bendeOrdre As System.Windows.Forms.Label
    Dim lblBilagsblade As System.Windows.Forms.Label
    Dim lblAtt As Infragistics.Win.Misc.UltraLabel
    Dim lblOverskrift As System.Windows.Forms.Label
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupportBilag))
    Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
    Me.picSupportBilag = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
    Me.lblAnnonc�r = New System.Windows.Forms.Label()
    Me.lblMedieplanNr = New System.Windows.Forms.Label()
    Me.lblUgeNr = New System.Windows.Forms.Label()
    Me.txtAnnonc�r = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblOrdre = New System.Windows.Forms.Label()
    Me.txtMedieplanNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.txtUgeNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblMateriale = New System.Windows.Forms.Label()
    Me.lblBem�rkninger = New System.Windows.Forms.Label()
    Me.txtBem�rkningTilUgeaviserne = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.chkBladeneSkalFakturere = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
    Me.btnAnnuller = New Infragistics.Win.Misc.UltraButton()
    Me.btnSend = New Infragistics.Win.Misc.UltraButton()
    Me.txtL�bendeOrdre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.optMaterialeF�lgerFra = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.lblMaterialeF�lgerFra = New Infragistics.Win.Misc.UltraLabel()
    Me.txtMaterialeF�lgerFraLeverand�r = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.txtBrugMaterialeFraUge = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblMatFraUge = New Infragistics.Win.Misc.UltraLabel()
    Me.txtBem�rkningTilSupport = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblTilUgeaviserne = New System.Windows.Forms.Label()
    Me.lblTilSupport = New System.Windows.Forms.Label()
    Me.chkLiggerIIndbakke = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
    Me.chkBilagsblade = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
    Me.txtBilagsBladeAtt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.btnUdskriv = New Infragistics.Win.Misc.UltraButton()
    Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
    Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
    Me.txtOverskrift = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.optBilagsBladeTil = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtPostNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblPostNr = New Infragistics.Win.Misc.UltraLabel()
    Me.txtAdresse = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblAdresse = New Infragistics.Win.Misc.UltraLabel()
    Me.txtNavn = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.lblNavn = New Infragistics.Win.Misc.UltraLabel()
    Me.chkMaterialeModtaget = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
    Me.optSammeMateriale = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
    Me.chkKunForhandlerBundForskellig = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
    Me.lblFakturaNem�rkning = New System.Windows.Forms.Label()
    Me.txtFakturaBem�rkning1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    Me.txtFakturaBem�rkning2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
    lblL�bendeOrdre = New System.Windows.Forms.Label()
    lblBilagsblade = New System.Windows.Forms.Label()
    lblAtt = New Infragistics.Win.Misc.UltraLabel()
    lblOverskrift = New System.Windows.Forms.Label()
    CType(Me.txtAnnonc�r, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMedieplanNr, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUgeNr, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBem�rkningTilUgeaviserne, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkBladeneSkalFakturere, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtL�bendeOrdre, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optMaterialeF�lgerFra, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMaterialeF�lgerFraLeverand�r, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBrugMaterialeFraUge, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBem�rkningTilSupport, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkLiggerIIndbakke, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkBilagsblade, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBilagsBladeAtt, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtOverskrift, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optBilagsBladeTil, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPostNr, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAdresse, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNavn, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkMaterialeModtaget, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.optSammeMateriale, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkKunForhandlerBundForskellig, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFakturaBem�rkning1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFakturaBem�rkning2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblL�bendeOrdre
    '
    lblL�bendeOrdre.AutoSize = True
    lblL�bendeOrdre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    lblL�bendeOrdre.Location = New System.Drawing.Point(361, 45)
    lblL�bendeOrdre.Name = "lblL�bendeOrdre"
    lblL�bendeOrdre.Size = New System.Drawing.Size(102, 13)
    lblL�bendeOrdre.TabIndex = 343
    lblL�bendeOrdre.Text = "L�bende ordre"
    '
    'lblBilagsblade
    '
    lblBilagsblade.AutoSize = True
    lblBilagsblade.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    lblBilagsblade.Location = New System.Drawing.Point(362, 181)
    lblBilagsblade.Name = "lblBilagsblade"
    lblBilagsblade.Size = New System.Drawing.Size(82, 13)
    lblBilagsblade.TabIndex = 391
    lblBilagsblade.Text = "Bilagsblade"
    '
    'lblAtt
    '
    lblAtt.AutoSize = True
    lblAtt.Location = New System.Drawing.Point(370, 229)
    lblAtt.Name = "lblAtt"
    lblAtt.Size = New System.Drawing.Size(25, 15)
    lblAtt.TabIndex = 393
    lblAtt.Tag = ""
    lblAtt.Text = "Att."
    '
    'lblOverskrift
    '
    lblOverskrift.AutoSize = True
    lblOverskrift.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    lblOverskrift.Location = New System.Drawing.Point(361, 96)
    lblOverskrift.Name = "lblOverskrift"
    lblOverskrift.Size = New System.Drawing.Size(73, 13)
    lblOverskrift.TabIndex = 396
    lblOverskrift.Text = "Overskrift"
    '
    'picSupportBilag
    '
    Me.picSupportBilag.AutoSize = True
    Me.picSupportBilag.BorderShadowColor = System.Drawing.Color.Empty
    Me.picSupportBilag.Image = CType(resources.GetObject("picSupportBilag.Image"), Object)
    Me.picSupportBilag.Location = New System.Drawing.Point(437, 6)
    Me.picSupportBilag.Name = "picSupportBilag"
    Me.picSupportBilag.Size = New System.Drawing.Size(170, 26)
    Me.picSupportBilag.TabIndex = 9
    '
    'lblAnnonc�r
    '
    Me.lblAnnonc�r.AutoSize = True
    Me.lblAnnonc�r.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnnonc�r.Location = New System.Drawing.Point(11, 64)
    Me.lblAnnonc�r.Name = "lblAnnonc�r"
    Me.lblAnnonc�r.Size = New System.Drawing.Size(61, 13)
    Me.lblAnnonc�r.TabIndex = 10
    Me.lblAnnonc�r.Text = "Annonc�r"
    '
    'lblMedieplanNr
    '
    Me.lblMedieplanNr.AutoSize = True
    Me.lblMedieplanNr.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMedieplanNr.Location = New System.Drawing.Point(11, 88)
    Me.lblMedieplanNr.Name = "lblMedieplanNr"
    Me.lblMedieplanNr.Size = New System.Drawing.Size(80, 13)
    Me.lblMedieplanNr.TabIndex = 11
    Me.lblMedieplanNr.Text = "Medieplan nr"
    '
    'lblUgeNr
    '
    Me.lblUgeNr.AutoSize = True
    Me.lblUgeNr.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblUgeNr.Location = New System.Drawing.Point(11, 112)
    Me.lblUgeNr.Margin = New System.Windows.Forms.Padding(0)
    Me.lblUgeNr.Name = "lblUgeNr"
    Me.lblUgeNr.Size = New System.Drawing.Size(45, 13)
    Me.lblUgeNr.TabIndex = 13
    Me.lblUgeNr.Text = "Uge nr"
    '
    'txtAnnonc�r
    '
    Me.txtAnnonc�r.Location = New System.Drawing.Point(121, 63)
    Me.txtAnnonc�r.Name = "txtAnnonc�r"
    Me.txtAnnonc�r.ReadOnly = True
    Me.txtAnnonc�r.Size = New System.Drawing.Size(215, 22)
    Me.txtAnnonc�r.TabIndex = 342
    Me.txtAnnonc�r.TabStop = False
    '
    'lblOrdre
    '
    Me.lblOrdre.AutoSize = True
    Me.lblOrdre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOrdre.Location = New System.Drawing.Point(8, 45)
    Me.lblOrdre.Name = "lblOrdre"
    Me.lblOrdre.Size = New System.Drawing.Size(44, 13)
    Me.lblOrdre.TabIndex = 344
    Me.lblOrdre.Text = "Ordre"
    '
    'txtMedieplanNr
    '
    Me.txtMedieplanNr.Location = New System.Drawing.Point(121, 87)
    Me.txtMedieplanNr.Name = "txtMedieplanNr"
    Me.txtMedieplanNr.ReadOnly = True
    Me.txtMedieplanNr.Size = New System.Drawing.Size(75, 22)
    Me.txtMedieplanNr.TabIndex = 345
    Me.txtMedieplanNr.TabStop = False
    '
    'txtUgeNr
    '
    Me.txtUgeNr.Location = New System.Drawing.Point(121, 111)
    Me.txtUgeNr.Name = "txtUgeNr"
    Me.txtUgeNr.Size = New System.Drawing.Size(37, 22)
    Me.txtUgeNr.TabIndex = 0
    '
    'lblMateriale
    '
    Me.lblMateriale.AutoSize = True
    Me.lblMateriale.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMateriale.Location = New System.Drawing.Point(8, 204)
    Me.lblMateriale.Name = "lblMateriale"
    Me.lblMateriale.Size = New System.Drawing.Size(68, 13)
    Me.lblMateriale.TabIndex = 348
    Me.lblMateriale.Text = "Materiale"
    '
    'lblBem�rkninger
    '
    Me.lblBem�rkninger.AutoSize = True
    Me.lblBem�rkninger.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBem�rkninger.Location = New System.Drawing.Point(9, 354)
    Me.lblBem�rkninger.Name = "lblBem�rkninger"
    Me.lblBem�rkninger.Size = New System.Drawing.Size(103, 13)
    Me.lblBem�rkninger.TabIndex = 359
    Me.lblBem�rkninger.Text = "Bem�rkninger"
    '
    'txtBem�rkningTilUgeaviserne
    '
    Me.txtBem�rkningTilUgeaviserne.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBem�rkningTilUgeaviserne.Location = New System.Drawing.Point(11, 459)
    Me.txtBem�rkningTilUgeaviserne.MaxLength = 250
    Me.txtBem�rkningTilUgeaviserne.Multiline = True
    Me.txtBem�rkningTilUgeaviserne.Name = "txtBem�rkningTilUgeaviserne"
    Me.txtBem�rkningTilUgeaviserne.NullText = "- Skriv evt. bem�rkning til Ugeaviserne -"
    Me.txtBem�rkningTilUgeaviserne.Size = New System.Drawing.Size(304, 122)
    Me.txtBem�rkningTilUgeaviserne.TabIndex = 7
    '
    'chkBladeneSkalFakturere
    '
    Me.chkBladeneSkalFakturere.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.chkBladeneSkalFakturere.Location = New System.Drawing.Point(12, 158)
    Me.chkBladeneSkalFakturere.Name = "chkBladeneSkalFakturere"
    Me.chkBladeneSkalFakturere.Size = New System.Drawing.Size(159, 20)
    Me.chkBladeneSkalFakturere.TabIndex = 1
    Me.chkBladeneSkalFakturere.Text = "Bladene skal fakturere"
    '
    'btnAnnuller
    '
    Me.btnAnnuller.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 595)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.ShowFocusRect = False
    Me.btnAnnuller.ShowOutline = False
    Me.btnAnnuller.Size = New System.Drawing.Size(87, 24)
    Me.btnAnnuller.TabIndex = 10
    Me.btnAnnuller.Text = "&Annuller"
    Me.btnAnnuller.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'btnSend
    '
    Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSend.Enabled = False
    Me.btnSend.Location = New System.Drawing.Point(546, 595)
    Me.btnSend.Name = "btnSend"
    Me.btnSend.ShowFocusRect = False
    Me.btnSend.ShowOutline = False
    Me.btnSend.Size = New System.Drawing.Size(87, 24)
    Me.btnSend.TabIndex = 11
    Me.btnSend.Text = "&Send"
    Me.btnSend.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'txtL�bendeOrdre
    '
    Me.txtL�bendeOrdre.Location = New System.Drawing.Point(364, 63)
    Me.txtL�bendeOrdre.Name = "txtL�bendeOrdre"
    Me.txtL�bendeOrdre.Size = New System.Drawing.Size(261, 22)
    Me.txtL�bendeOrdre.TabIndex = 8
    '
    'optMaterialeF�lgerFra
    '
    Me.optMaterialeF�lgerFra.CheckedIndex = 1
    ValueListItem1.DataValue = CType(0, Byte)
    ValueListItem1.DisplayText = "Tidligere Uge"
    ValueListItem2.DataValue = CType(1, Byte)
    ValueListItem2.DisplayText = "DLU"
    ValueListItem3.DataValue = CType(2, Byte)
    ValueListItem3.DisplayText = "Bur."
    ValueListItem4.DataValue = CType(3, Byte)
    ValueListItem4.DisplayText = "Ann."
    Me.optMaterialeF�lgerFra.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4})
    Me.optMaterialeF�lgerFra.Location = New System.Drawing.Point(107, 227)
    Me.optMaterialeF�lgerFra.Name = "optMaterialeF�lgerFra"
    Me.optMaterialeF�lgerFra.Size = New System.Drawing.Size(247, 24)
    Me.optMaterialeF�lgerFra.TabIndex = 2
    Me.optMaterialeF�lgerFra.Tag = ""
    Me.optMaterialeF�lgerFra.Text = "DLU"
    '
    'lblMaterialeF�lgerFra
    '
    Me.lblMaterialeF�lgerFra.AutoSize = True
    Me.lblMaterialeF�lgerFra.Location = New System.Drawing.Point(11, 229)
    Me.lblMaterialeF�lgerFra.Name = "lblMaterialeF�lgerFra"
    Me.lblMaterialeF�lgerFra.Size = New System.Drawing.Size(90, 15)
    Me.lblMaterialeF�lgerFra.TabIndex = 380
    Me.lblMaterialeF�lgerFra.Tag = ""
    Me.lblMaterialeF�lgerFra.Text = "Matr. f�lger fra"
    '
    'txtMaterialeF�lgerFraLeverand�r
    '
    Me.txtMaterialeF�lgerFraLeverand�r.Location = New System.Drawing.Point(108, 282)
    Me.txtMaterialeF�lgerFraLeverand�r.MaxLength = 30
    Me.txtMaterialeF�lgerFraLeverand�r.Name = "txtMaterialeF�lgerFraLeverand�r"
    Me.txtMaterialeF�lgerFraLeverand�r.NullText = "- Skriv matr. leverand�r (til DLU) -"
    Me.txtMaterialeF�lgerFraLeverand�r.Size = New System.Drawing.Size(224, 22)
    Me.txtMaterialeF�lgerFraLeverand�r.TabIndex = 4
    '
    'txtBrugMaterialeFraUge
    '
    Me.txtBrugMaterialeFraUge.Location = New System.Drawing.Point(108, 254)
    Me.txtBrugMaterialeFraUge.Name = "txtBrugMaterialeFraUge"
    Me.txtBrugMaterialeFraUge.NullText = "- Uge -"
    Me.txtBrugMaterialeFraUge.Size = New System.Drawing.Size(58, 22)
    Me.txtBrugMaterialeFraUge.TabIndex = 3
    Me.txtBrugMaterialeFraUge.Tag = ""
    Me.txtBrugMaterialeFraUge.Visible = False
    '
    'lblMatFraUge
    '
    Me.lblMatFraUge.AutoSize = True
    Me.lblMatFraUge.Location = New System.Drawing.Point(11, 258)
    Me.lblMatFraUge.Name = "lblMatFraUge"
    Me.lblMatFraUge.Size = New System.Drawing.Size(79, 15)
    Me.lblMatFraUge.TabIndex = 384
    Me.lblMatFraUge.Tag = ""
    Me.lblMatFraUge.Text = "Matr. fra uge"
    Me.lblMatFraUge.Visible = False
    '
    'txtBem�rkningTilSupport
    '
    Me.txtBem�rkningTilSupport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBem�rkningTilSupport.Location = New System.Drawing.Point(329, 459)
    Me.txtBem�rkningTilSupport.MaxLength = 250
    Me.txtBem�rkningTilSupport.Multiline = True
    Me.txtBem�rkningTilSupport.Name = "txtBem�rkningTilSupport"
    Me.txtBem�rkningTilSupport.NullText = "- Skriv evt. bem�rkning til Support -"
    Me.txtBem�rkningTilSupport.Size = New System.Drawing.Size(304, 122)
    Me.txtBem�rkningTilSupport.TabIndex = 9
    '
    'lblTilUgeaviserne
    '
    Me.lblTilUgeaviserne.AutoSize = True
    Me.lblTilUgeaviserne.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTilUgeaviserne.Location = New System.Drawing.Point(11, 445)
    Me.lblTilUgeaviserne.Name = "lblTilUgeaviserne"
    Me.lblTilUgeaviserne.Size = New System.Drawing.Size(95, 13)
    Me.lblTilUgeaviserne.TabIndex = 386
    Me.lblTilUgeaviserne.Text = "Til Ugeaviserne"
    '
    'lblTilSupport
    '
    Me.lblTilSupport.AutoSize = True
    Me.lblTilSupport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTilSupport.Location = New System.Drawing.Point(329, 445)
    Me.lblTilSupport.Name = "lblTilSupport"
    Me.lblTilSupport.Size = New System.Drawing.Size(69, 13)
    Me.lblTilSupport.TabIndex = 387
    Me.lblTilSupport.Text = "Til Support"
    '
    'chkLiggerIIndbakke
    '
    Me.chkLiggerIIndbakke.Location = New System.Drawing.Point(401, 442)
    Me.chkLiggerIIndbakke.Name = "chkLiggerIIndbakke"
    Me.chkLiggerIIndbakke.Size = New System.Drawing.Size(241, 20)
    Me.chkLiggerIIndbakke.TabIndex = 390
    Me.chkLiggerIIndbakke.Text = "Bureauordresedler ligger i indbakken"
    '
    'chkBilagsblade
    '
    Me.chkBilagsblade.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.chkBilagsblade.Location = New System.Drawing.Point(471, 174)
    Me.chkBilagsblade.Name = "chkBilagsblade"
    Me.chkBilagsblade.Size = New System.Drawing.Size(96, 20)
    Me.chkBilagsblade.TabIndex = 392
    Me.chkBilagsblade.Text = "Bilagsblade"
    Me.chkBilagsblade.Visible = False
    '
    'txtBilagsBladeAtt
    '
    Me.txtBilagsBladeAtt.Location = New System.Drawing.Point(423, 225)
    Me.txtBilagsBladeAtt.MaxLength = 30
    Me.txtBilagsBladeAtt.Name = "txtBilagsBladeAtt"
    Me.txtBilagsBladeAtt.NullText = "- Skriv Att. person -"
    Me.txtBilagsBladeAtt.Size = New System.Drawing.Size(202, 22)
    Me.txtBilagsBladeAtt.TabIndex = 394
    '
    'btnUdskriv
    '
    Me.btnUdskriv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnUdskriv.Location = New System.Drawing.Point(437, 595)
    Me.btnUdskriv.Name = "btnUdskriv"
    Me.btnUdskriv.ShowFocusRect = False
    Me.btnUdskriv.ShowOutline = False
    Me.btnUdskriv.Size = New System.Drawing.Size(87, 24)
    Me.btnUdskriv.TabIndex = 395
    Me.btnUdskriv.Text = "&Udskriv"
    Me.btnUdskriv.UseHotTracking = Infragistics.Win.DefaultableBoolean.[True]
    '
    'PrintDialog1
    '
    Me.PrintDialog1.UseEXDialog = True
    '
    'PrintForm1
    '
    Me.PrintForm1.DocumentName = "document"
    Me.PrintForm1.Form = Me
    Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
    Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
    Me.PrintForm1.PrintFileName = Nothing
    '
    'txtOverskrift
    '
    Me.txtOverskrift.Location = New System.Drawing.Point(364, 112)
    Me.txtOverskrift.MaxLength = 30
    Me.txtOverskrift.Name = "txtOverskrift"
    Me.txtOverskrift.Size = New System.Drawing.Size(261, 22)
    Me.txtOverskrift.TabIndex = 397
    '
    'optBilagsBladeTil
    '
    ValueListItem7.DataValue = CType(1, Byte)
    ValueListItem7.DisplayText = "Annonc�r"
    ValueListItem8.DataValue = CType(2, Byte)
    ValueListItem8.DisplayText = "Bureau"
    ValueListItem9.DataValue = CType(3, Byte)
    ValueListItem9.DisplayText = "Anden"
    Me.optBilagsBladeTil.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7, ValueListItem8, ValueListItem9})
    Me.optBilagsBladeTil.Location = New System.Drawing.Point(437, 201)
    Me.optBilagsBladeTil.Name = "optBilagsBladeTil"
    Me.optBilagsBladeTil.Size = New System.Drawing.Size(199, 18)
    Me.optBilagsBladeTil.TabIndex = 398
    Me.optBilagsBladeTil.Tag = ""
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(365, 203)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 13)
    Me.Label1.TabIndex = 399
    Me.Label1.Text = "Bilagsblade"
    '
    'txtPostNr
    '
    Me.txtPostNr.Location = New System.Drawing.Point(423, 309)
    Me.txtPostNr.MaxLength = 4
    Me.txtPostNr.Name = "txtPostNr"
    Me.txtPostNr.NullText = "- Skriv post nr. -"
    Me.txtPostNr.Size = New System.Drawing.Size(93, 22)
    Me.txtPostNr.TabIndex = 405
    Me.txtPostNr.Visible = False
    '
    'lblPostNr
    '
    Me.lblPostNr.AutoSize = True
    Me.lblPostNr.Location = New System.Drawing.Point(368, 313)
    Me.lblPostNr.Name = "lblPostNr"
    Me.lblPostNr.Size = New System.Drawing.Size(48, 15)
    Me.lblPostNr.TabIndex = 404
    Me.lblPostNr.Text = "Post nr."
    Me.lblPostNr.Visible = False
    '
    'txtAdresse
    '
    Me.txtAdresse.Location = New System.Drawing.Point(423, 281)
    Me.txtAdresse.MaxLength = 30
    Me.txtAdresse.Name = "txtAdresse"
    Me.txtAdresse.NullText = "- Skriv adresse -"
    Me.txtAdresse.Size = New System.Drawing.Size(202, 22)
    Me.txtAdresse.TabIndex = 403
    Me.txtAdresse.Visible = False
    '
    'lblAdresse
    '
    Me.lblAdresse.AutoSize = True
    Me.lblAdresse.Location = New System.Drawing.Point(368, 285)
    Me.lblAdresse.Name = "lblAdresse"
    Me.lblAdresse.Size = New System.Drawing.Size(49, 15)
    Me.lblAdresse.TabIndex = 402
    Me.lblAdresse.Text = "Adresse"
    Me.lblAdresse.Visible = False
    '
    'txtNavn
    '
    Me.txtNavn.Location = New System.Drawing.Point(423, 253)
    Me.txtNavn.MaxLength = 30
    Me.txtNavn.Name = "txtNavn"
    Me.txtNavn.NullText = "- Skriv navn p� modtager -"
    Me.txtNavn.Size = New System.Drawing.Size(202, 22)
    Me.txtNavn.TabIndex = 401
    Me.txtNavn.Visible = False
    '
    'lblNavn
    '
    Me.lblNavn.AutoSize = True
    Me.lblNavn.Location = New System.Drawing.Point(368, 257)
    Me.lblNavn.Name = "lblNavn"
    Me.lblNavn.Size = New System.Drawing.Size(33, 15)
    Me.lblNavn.TabIndex = 400
    Me.lblNavn.Text = "Navn"
    Me.lblNavn.Visible = False
    '
    'chkMaterialeModtaget
    '
    Me.chkMaterialeModtaget.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.chkMaterialeModtaget.Location = New System.Drawing.Point(177, 256)
    Me.chkMaterialeModtaget.Name = "chkMaterialeModtaget"
    Me.chkMaterialeModtaget.Size = New System.Drawing.Size(110, 20)
    Me.chkMaterialeModtaget.TabIndex = 406
    Me.chkMaterialeModtaget.Tag = ""
    Me.chkMaterialeModtaget.Text = "Matr. modtaget"
    '
    'optSammeMateriale
    '
    Me.optSammeMateriale.CheckedIndex = 0
    ValueListItem5.DataValue = True
    ValueListItem5.DisplayText = "Samme"
    ValueListItem6.DataValue = False
    ValueListItem6.DisplayText = "Forskelligt"
    Me.optSammeMateriale.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
    Me.optSammeMateriale.Location = New System.Drawing.Point(107, 310)
    Me.optSammeMateriale.Name = "optSammeMateriale"
    Me.optSammeMateriale.Size = New System.Drawing.Size(150, 18)
    Me.optSammeMateriale.TabIndex = 407
    Me.optSammeMateriale.Tag = ""
    Me.optSammeMateriale.Text = "Samme"
    '
    'chkKunForhandlerBundForskellig
    '
    Me.chkKunForhandlerBundForskellig.Checked = True
    Me.chkKunForhandlerBundForskellig.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkKunForhandlerBundForskellig.Location = New System.Drawing.Point(121, 334)
    Me.chkKunForhandlerBundForskellig.Name = "chkKunForhandlerBundForskellig"
    Me.chkKunForhandlerBundForskellig.Size = New System.Drawing.Size(202, 18)
    Me.chkKunForhandlerBundForskellig.TabIndex = 408
    Me.chkKunForhandlerBundForskellig.Text = "Kun forhandlerbund forskellig"
    Me.chkKunForhandlerBundForskellig.Visible = False
    '
    'lblFakturaNem�rkning
    '
    Me.lblFakturaNem�rkning.AutoSize = True
    Me.lblFakturaNem�rkning.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFakturaNem�rkning.Location = New System.Drawing.Point(11, 368)
    Me.lblFakturaNem�rkning.Name = "lblFakturaNem�rkning"
    Me.lblFakturaNem�rkning.Size = New System.Drawing.Size(66, 13)
    Me.lblFakturaNem�rkning.TabIndex = 410
    Me.lblFakturaNem�rkning.Text = "Til Faktura"
    '
    'txtFakturaBem�rkning1
    '
    Me.txtFakturaBem�rkning1.Location = New System.Drawing.Point(11, 384)
    Me.txtFakturaBem�rkning1.MaxLength = 50
    Me.txtFakturaBem�rkning1.Name = "txtFakturaBem�rkning1"
    Me.txtFakturaBem�rkning1.NullText = "- Skriv evt. bem�rkning til faktura -"
    Me.txtFakturaBem�rkning1.Size = New System.Drawing.Size(304, 22)
    Me.txtFakturaBem�rkning1.TabIndex = 411
    '
    'txtFakturaBem�rkning2
    '
    Me.txtFakturaBem�rkning2.Location = New System.Drawing.Point(11, 409)
    Me.txtFakturaBem�rkning2.MaxLength = 50
    Me.txtFakturaBem�rkning2.Name = "txtFakturaBem�rkning2"
    Me.txtFakturaBem�rkning2.NullText = "- Skriv evt. bem�rkning til faktura -"
    Me.txtFakturaBem�rkning2.Size = New System.Drawing.Size(304, 22)
    Me.txtFakturaBem�rkning2.TabIndex = 412
    '
    'frmSupportBilag
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(645, 631)
    Me.Controls.Add(Me.txtFakturaBem�rkning2)
    Me.Controls.Add(Me.txtFakturaBem�rkning1)
    Me.Controls.Add(Me.lblFakturaNem�rkning)
    Me.Controls.Add(Me.chkKunForhandlerBundForskellig)
    Me.Controls.Add(Me.optSammeMateriale)
    Me.Controls.Add(Me.chkMaterialeModtaget)
    Me.Controls.Add(Me.txtPostNr)
    Me.Controls.Add(Me.lblPostNr)
    Me.Controls.Add(Me.txtAdresse)
    Me.Controls.Add(Me.lblAdresse)
    Me.Controls.Add(Me.txtNavn)
    Me.Controls.Add(Me.lblNavn)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.optBilagsBladeTil)
    Me.Controls.Add(Me.txtOverskrift)
    Me.Controls.Add(lblOverskrift)
    Me.Controls.Add(Me.btnUdskriv)
    Me.Controls.Add(Me.txtBilagsBladeAtt)
    Me.Controls.Add(lblAtt)
    Me.Controls.Add(Me.chkBilagsblade)
    Me.Controls.Add(lblBilagsblade)
    Me.Controls.Add(Me.lblTilSupport)
    Me.Controls.Add(Me.lblTilUgeaviserne)
    Me.Controls.Add(Me.txtBem�rkningTilSupport)
    Me.Controls.Add(Me.txtMaterialeF�lgerFraLeverand�r)
    Me.Controls.Add(Me.txtBrugMaterialeFraUge)
    Me.Controls.Add(Me.lblMatFraUge)
    Me.Controls.Add(Me.optMaterialeF�lgerFra)
    Me.Controls.Add(Me.lblMaterialeF�lgerFra)
    Me.Controls.Add(Me.txtL�bendeOrdre)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnSend)
    Me.Controls.Add(Me.chkBladeneSkalFakturere)
    Me.Controls.Add(Me.txtBem�rkningTilUgeaviserne)
    Me.Controls.Add(Me.lblBem�rkninger)
    Me.Controls.Add(Me.lblMateriale)
    Me.Controls.Add(Me.txtUgeNr)
    Me.Controls.Add(Me.txtMedieplanNr)
    Me.Controls.Add(Me.lblOrdre)
    Me.Controls.Add(lblL�bendeOrdre)
    Me.Controls.Add(Me.txtAnnonc�r)
    Me.Controls.Add(Me.lblUgeNr)
    Me.Controls.Add(Me.lblMedieplanNr)
    Me.Controls.Add(Me.lblAnnonc�r)
    Me.Controls.Add(Me.picSupportBilag)
    Me.Controls.Add(Me.chkLiggerIIndbakke)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmSupportBilag"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Support Bilag"
    Me.TopMost = True
    CType(Me.txtAnnonc�r, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMedieplanNr, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUgeNr, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBem�rkningTilUgeaviserne, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkBladeneSkalFakturere, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtL�bendeOrdre, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optMaterialeF�lgerFra, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMaterialeF�lgerFraLeverand�r, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBrugMaterialeFraUge, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBem�rkningTilSupport, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkLiggerIIndbakke, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkBilagsblade, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBilagsBladeAtt, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtOverskrift, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optBilagsBladeTil, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPostNr, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAdresse, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNavn, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkMaterialeModtaget, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.optSammeMateriale, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkKunForhandlerBundForskellig, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFakturaBem�rkning1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFakturaBem�rkning2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents picSupportBilag As Infragistics.Win.UltraWinEditors.UltraPictureBox
  Friend WithEvents lblAnnonc�r As System.Windows.Forms.Label
  Friend WithEvents lblMedieplanNr As System.Windows.Forms.Label
  Friend WithEvents lblUgeNr As System.Windows.Forms.Label
  Friend WithEvents txtAnnonc�r As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblOrdre As System.Windows.Forms.Label
  Friend WithEvents txtMedieplanNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtUgeNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblMateriale As System.Windows.Forms.Label
  Friend WithEvents lblBem�rkninger As System.Windows.Forms.Label
  Friend WithEvents txtBem�rkningTilUgeaviserne As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents chkBladeneSkalFakturere As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Private WithEvents btnAnnuller As Infragistics.Win.Misc.UltraButton
  Private WithEvents btnSend As Infragistics.Win.Misc.UltraButton
  Friend WithEvents txtL�bendeOrdre As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents optMaterialeF�lgerFra As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents lblMaterialeF�lgerFra As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtMaterialeF�lgerFraLeverand�r As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtBrugMaterialeFraUge As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblMatFraUge As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtBem�rkningTilSupport As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblTilUgeaviserne As System.Windows.Forms.Label
  Friend WithEvents lblTilSupport As System.Windows.Forms.Label
  Friend WithEvents chkLiggerIIndbakke As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents chkBilagsblade As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents txtBilagsBladeAtt As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Private WithEvents btnUdskriv As Infragistics.Win.Misc.UltraButton
  Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
  Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
  Friend WithEvents txtOverskrift As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents optBilagsBladeTil As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtPostNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblPostNr As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtAdresse As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblAdresse As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents txtNavn As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblNavn As Infragistics.Win.Misc.UltraLabel
  Friend WithEvents chkMaterialeModtaget As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents optSammeMateriale As Infragistics.Win.UltraWinEditors.UltraOptionSet
  Friend WithEvents chkKunForhandlerBundForskellig As Infragistics.Win.UltraWinEditors.UltraCheckEditor
  Friend WithEvents txtFakturaBem�rkning2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents txtFakturaBem�rkning1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
  Friend WithEvents lblFakturaNem�rkning As System.Windows.Forms.Label
End Class
