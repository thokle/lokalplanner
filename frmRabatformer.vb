Imports Infragistics.Win.UltraWinGrid
Imports System.Data.SqlClient

Public Class frmRabatformer
  Private MaxVersion As Integer

  Private Sub frmRabatformer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim ta As New GruppeListeDropdownTableAdapters.tblGrupperTableAdapter
    MaxVersion = ta.GetMaxVersion()
    Dim counter As Integer

    For counter = 1 To MaxVersion
      tscVersion.Tabs.Add(counter.ToString)
      tscVersion.Tabs(counter - 1).Text = counter.ToString
      tscVersion.Tabs(counter - 1).Key = counter.ToString
    Next
    tscVersion.Tabs(MaxVersion - 1).Selected = True
    Me.TblGrupperTableAdapter.Fill(Me.GruppeListeDropdown.tblGrupper, MaxVersion)
    If frmMain.HarRollen("Admin") Then
      btnGem.Visible = True
      btnNyVersion.Visible = True
      If MaxVersion <> frmMain.AktivGruppeVersion Then
        btnNyVersion.Text = "Aktiver version " & MaxVersion
      Else
        btnNyVersion.Text = "Opret Ny Version"
      End If
    Else
      btnGem.Visible = False
      btnNyVersion.Visible = False
      grdBladeMedIRabatform.DisplayLayout.Bands(0).Columns("ErTillægsAvis").CellActivation = Activation.Disabled
    End If
  End Sub

  Private Sub cboRabatformer_ItemNotInList(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.ValidationErrorEventArgs) Handles cboRabatformer.ItemNotInList
    If e.InvalidText.Length < 1 Then Exit Sub
    If MsgBox(String.Format("Skal der oprettes en ny rabatform{0}der hedder : {1}", vbCrLf, e.InvalidText), MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Opret ny Rabatform?") = MsgBoxResult.Yes Then
      Dim ta As New GruppeListeDropdownTableAdapters.tblGrupperTableAdapter
      Dim MaxGruppeID As Byte = ta.GetMaxGruppeID(tscVersion.SelectedTab.Key)
      If ta.InsertQuery(MaxGruppeID + 1, e.InvalidText, "Rabatform", 2, "", "", tscVersion.SelectedTab.Key) > 0 Then
        Me.TblGrupperTableAdapter.Fill(Me.GruppeListeDropdown.tblGrupper, tscVersion.SelectedTab.Key)
        txtAntalAviserVælges.Value = Nothing
        txtOrdreModtager.Value = Nothing
        txtMaterialeModtager.Value = Nothing
      Else
        e.Beep = True
        e.RetainFocus = True
        cboRabatformer.Value = e.LastValidValue
      End If
    Else
      e.RetainFocus = False
      cboRabatformer.Value = e.LastValidValue
    End If
  End Sub

  Private Sub cboRabatformer_SelectionChanged(sender As Object, e As System.EventArgs) Handles cboRabatformer.SelectionChanged
    If cboRabatformer.IsItemInList Then
      Me.TblBladeMedIRabatformTableAdapter.FillByGruppeID(Me.DstBladeMedIRabatform.tblBladeMedIRabatform, cboRabatformer.Value, tscVersion.SelectedTab.Key)
      Me.TblGruppeRabatterTableAdapter.FillByGruppeIDAndPlaceringID(Me.DstGruppeRabatter.tblGruppeRabatter, cboRabatformer.Value, 1 + tabPlacering.SelectedTab.Index * 10, tscVersion.SelectedTab.Key)
      txtAntalAviserVælges.Value = Me.GruppeListeDropdown.tblGrupper(cboRabatformer.SelectedIndex).AntalBladeForValg
      txtOrdreModtager.Value = Me.GruppeListeDropdown.tblGrupper(cboRabatformer.SelectedIndex).OrdreEmail
      txtMaterialeModtager.Value = Me.GruppeListeDropdown.tblGrupper(cboRabatformer.SelectedIndex).MaterialeModtager
      grdGruppeRabatter.UpdateData()
    Else
      Me.TblBladeMedIRabatformTableAdapter.FillByGruppeID(Me.DstBladeMedIRabatform.tblBladeMedIRabatform, 0, tscVersion.SelectedTab.Key)
      Me.TblGruppeRabatterTableAdapter.FillByGruppeIDAndPlaceringID(Me.DstGruppeRabatter.tblGruppeRabatter, 0, 0, tscVersion.SelectedTab.Key)
      txtAntalAviserVælges.Value = Nothing
      txtOrdreModtager.Value = Nothing
      txtMaterialeModtager.Value = Nothing
    End If
  End Sub

  'Private Sub cboRabatformer_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRabatformer.ValueChanged
  '  If cboRabatformer.IsItemInList Then
  '    Me.TblBladeMedIRabatformTableAdapter.FillByGruppeID(Me.DstBladeMedIRabatform.tblBladeMedIRabatform, cboRabatformer.Value, tscVersion.SelectedTab.Key)
  '    Me.TblGruppeRabatterTableAdapter.FillByGruppeIDAndPlaceringID(Me.DstGruppeRabatter.tblGruppeRabatter, cboRabatformer.Value, 1 + tabPlacering.SelectedTab.Index * 10, tscVersion.SelectedTab.Key)
  '    txtAntalAviserVælges.Value = Me.GruppeListeDropdown.tblGrupper(cboRabatformer.SelectedIndex).AntalBladeForValg
  '    txtOrdreModtager.Value = Me.GruppeListeDropdown.tblGrupper(cboRabatformer.SelectedIndex).OrdreEmail
  '    txtMaterialeModtager.Value = Me.GruppeListeDropdown.tblGrupper(cboRabatformer.SelectedIndex).MaterialeModtager
  '    grdGruppeRabatter.UpdateData()
  '  Else
  '    Me.TblBladeMedIRabatformTableAdapter.FillByGruppeID(Me.DstBladeMedIRabatform.tblBladeMedIRabatform, 0, tscVersion.SelectedTab.Key)
  '    Me.TblGruppeRabatterTableAdapter.FillByGruppeIDAndPlaceringID(Me.DstGruppeRabatter.tblGruppeRabatter, 0, 0, tscVersion.SelectedTab.Key)
  '    txtAntalAviserVælges.Value = Nothing
  '    txtOrdreModtager.Value = Nothing
  '    txtMaterialeModtager.Value = Nothing
  '  End If
  'End Sub

  Private Sub grdBladeMedIRabatform_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grdBladeMedIRabatform.BeforeRowsDeleted
    For Each arow As UltraGridRow In e.Rows
      Me.TblBladeMedIRabatformTableAdapter.DeleteQuery(cboRabatformer.Value, arow.Cells("BladID").Value, tscVersion.SelectedTab.Key)
    Next
    e.DisplayPromptMsg = False
  End Sub

  Private Sub grdGruppeRabatter_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grdGruppeRabatter.BeforeRowsDeleted
    e.DisplayPromptMsg = False
  End Sub

  Private Sub grdGruppeRabatter_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles grdGruppeRabatter.InitializeRow
    If Not e.ReInitialize Then
      e.Row.Cells("GruppeID").Value = cboRabatformer.Value
      e.Row.Cells("PlaceringID").Value = 1 + tabPlacering.SelectedTab.Index * 10
    End If
  End Sub

  Private Sub tabPlacering_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabPlacering.SelectedTabChanged
    Try
      Me.TblGruppeRabatterTableAdapter.FillByGruppeIDAndPlaceringID(Me.DstGruppeRabatter.tblGruppeRabatter, cboRabatformer.Value, 1 + tabPlacering.SelectedTab.Index * 10, tscVersion.SelectedTab.Key)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub btnGem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGem.Click
    Me.Cursor = Cursors.WaitCursor
    For Each arow As UltraGridRow In grdBladeMedIRabatform.Rows
      Me.TblBladeMedIRabatformTableAdapter.UpdateQuery(arow.Cells("ErTillægsAvis").Value, cboRabatformer.Value, arow.Cells("BladID").Value, tscVersion.SelectedTab.Key)
    Next
    If Me.TblGrupperTableAdapter.UpdateQuery("Rabatform", txtAntalAviserVælges.Value, txtOrdreModtager.Value, txtMaterialeModtager.Value, cboRabatformer.Value) > 0 Then
      Me.TblGrupperTableAdapter.Fill(Me.GruppeListeDropdown.tblGrupper, tscVersion.SelectedTab.Key)
    End If
    grdGruppeRabatter.UpdateData()
    TblGruppeRabatterTableAdapter.Update(DstGruppeRabatter)
    Me.TblBladeMedIRabatformTableAdapter.FillByGruppeID(Me.DstBladeMedIRabatform.tblBladeMedIRabatform, cboRabatformer.Value, tscVersion.SelectedTab.Key)
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnNyVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNyVersion.Click
    Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
    Dim cm As SqlCommand = cn.CreateCommand()

    cm.CommandType = CommandType.Text
    cn.Open()

    If btnNyVersion.Text = "Opret Ny Version" Then
      cm.CommandText = "INSERT INTO tblGrupper (GruppeID, GruppeNavn, GruppeType, AntalBladeForValg, GruppeHovedbladID, OrdreEmail, MaterialeModtager, Version) SELECT GruppeID, GruppeNavn, GruppeType, AntalBladeForValg, GruppeHovedbladID, OrdreEmail, MaterialeModtager, Version + 1 AS NyVersion FROM tblGrupper AS tblGrupper_1 WHERE (Version = " & MaxVersion & ")"
      cm.ExecuteNonQuery()
      cm.CommandText = "INSERT INTO tblMedIGruppe (GruppeID, ID, ErTillægsAvis, Version) SELECT GruppeID, ID, ErTillægsAvis, Version + 1 AS NyVersion FROM tblMedIGruppe AS tblMedIGruppe_1 WHERE (Version = " & MaxVersion & ")"
      cm.ExecuteNonQuery()
      ' HUSK SET IDENTITY_INSERT tblGruppeRabatter ON
      cm.CommandText = "SET IDENTITY_INSERT tblGruppeRabatter ON;INSERT INTO tblGruppeRabatter (RabatFormID, GruppeID, PlaceringID, AntalFra, AntalTil, MmRabat, FarveRabat, MmPris, FarveMin, FarveMax, FarveTillæg, PrisInclFarver, Version) SELECT RabatFormID, GruppeID, PlaceringID, AntalFra, AntalTil, MmRabat, FarveRabat, MmPris, FarveMin, FarveMax, FarveTillæg, PrisInclFarver, Version + 1 AS NyVersion FROM tblGruppeRabatter AS tblGruppeRabatter_1 WHERE (Version = " & MaxVersion & ")"
      cm.ExecuteNonQuery()
    Else
      cm.CommandText = "UPDATE tblAktiveVærdier SET GruppeVersion = " & MaxVersion
      cm.ExecuteNonQuery()
    End If
    cm.Dispose()
    cn.Close()
    cn.Dispose()
    Me.Close()
  End Sub

End Class