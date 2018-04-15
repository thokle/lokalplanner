Imports Infragistics.Win.UltraWinGrid
Public Class frmVisRabatter
  Private _gruppeID As Integer

  Public Sub New(ByVal GruppeID As Integer)
    InitializeComponent()
    _gruppeID = GruppeID
  End Sub

  Private Sub frmVisRabatter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.TblGruppeRabatterTableAdapter.FillByGruppeIDAndPlaceringID(Me.DstGruppeRabatter.tblGruppeRabatter, _gruppeID, 1 + tabPlacering.SelectedTab.Index * 10, frmMain.AktivGruppeVersion)
  End Sub

  Private Sub tabPlacering_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabPlacering.SelectedTabChanged
    Me.TblGruppeRabatterTableAdapter.FillByGruppeIDAndPlaceringID(Me.DstGruppeRabatter.tblGruppeRabatter, _gruppeID, 1 + tabPlacering.SelectedTab.Index * 10, frmMain.AktivGruppeVersion)
  End Sub
End Class