<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnonceKontrol
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
    Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tblManglerKontrol", -1)
    Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Navn")
    Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndrykningsUge", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, True)
    Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BladID")
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnnonceKontrol))
    Me.grdAnnoncekontrol = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.TblManglerKontrolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DstManglerAnnonceKontrol = New WinPlanner.dstManglerAnnonceKontrol()
    Me.TblManglerKontrolTableAdapter = New WinPlanner.dstManglerAnnonceKontrolTableAdapters.tblManglerKontrolTableAdapter()
    CType(Me.grdAnnoncekontrol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblManglerKontrolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DstManglerAnnonceKontrol, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdAnnoncekontrol
    '
    Me.grdAnnoncekontrol.DataSource = Me.TblManglerKontrolBindingSource
    Me.grdAnnoncekontrol.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
    UltraGridBand1.ColHeadersVisible = False
    UltraGridColumn4.Header.Caption = "Lokal Ugeavis"
    UltraGridColumn4.Header.VisiblePosition = 0
    UltraGridColumn4.Width = 764
    UltraGridColumn5.Header.Caption = "Uge"
    UltraGridColumn5.Header.VisiblePosition = 1
    UltraGridColumn5.Width = 372
    UltraGridColumn6.Header.VisiblePosition = 2
    UltraGridColumn6.Hidden = True
    UltraGridColumn6.Width = 55
    UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
    UltraGridBand1.Indentation = 0
    UltraGridBand1.IndentationGroupByRow = 0
    UltraGridBand1.IndentationGroupByRowExpansionIndicator = 0
    Me.grdAnnoncekontrol.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
    Me.grdAnnoncekontrol.DisplayLayout.GroupByBox.Hidden = True
    Me.grdAnnoncekontrol.DisplayLayout.GroupByBox.Prompt = "Træk en kolonne herop for at gruppere på den"
    Me.grdAnnoncekontrol.DisplayLayout.Override.GroupByRowInitialExpansionState = Infragistics.Win.UltraWinGrid.GroupByRowInitialExpansionState.Expanded
    Me.grdAnnoncekontrol.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdAnnoncekontrol.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdAnnoncekontrol.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdAnnoncekontrol.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdAnnoncekontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grdAnnoncekontrol.Location = New System.Drawing.Point(0, 0)
    Me.grdAnnoncekontrol.Name = "grdAnnoncekontrol"
    Me.grdAnnoncekontrol.Size = New System.Drawing.Size(785, 481)
    Me.grdAnnoncekontrol.TabIndex = 1
    '
    'TblManglerKontrolBindingSource
    '
    Me.TblManglerKontrolBindingSource.DataMember = "tblManglerKontrol"
    Me.TblManglerKontrolBindingSource.DataSource = Me.DstManglerAnnonceKontrol
    '
    'DstManglerAnnonceKontrol
    '
    Me.DstManglerAnnonceKontrol.DataSetName = "dstManglerAnnonceKontrol"
    Me.DstManglerAnnonceKontrol.EnforceConstraints = False
    Me.DstManglerAnnonceKontrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'TblManglerKontrolTableAdapter
    '
    Me.TblManglerKontrolTableAdapter.ClearBeforeFill = True
    '
    'frmAnnonceKontrol
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(785, 481)
    Me.Controls.Add(Me.grdAnnoncekontrol)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmAnnonceKontrol"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.Text = "Blade der mangler Annoncekontrol"
    CType(Me.grdAnnoncekontrol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblManglerKontrolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DstManglerAnnonceKontrol, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents DstManglerAnnonceKontrol As WinPlanner.dstManglerAnnonceKontrol
  Friend WithEvents TblManglerKontrolBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblManglerKontrolTableAdapter As WinPlanner.dstManglerAnnonceKontrolTableAdapters.tblManglerKontrolTableAdapter
  Friend WithEvents grdAnnoncekontrol As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
