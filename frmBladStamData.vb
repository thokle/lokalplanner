Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinEditors
'Imports System.IO
'Imports System.Data.SqlClient
'Imports System.Text

Public Class FrmBladStamData
  Private _locked As Boolean = True
  Private _chained As Boolean
  Private _previousPrisliste As Integer = 0
  Private _previousBladID As Integer = 0
  Private _previousÅr As Integer = 0
  Private _prisColl As New Collection
  Private _noSave As Boolean = False
  Private _isLoading As Boolean = True
    Private _nyTilføjet As Boolean = False
    Private _nyErOprettet As Boolean = False


  Public Property LockStatus() As Boolean
    Get
      Return _locked
    End Get
    Set(ByVal value As Boolean)
      _locked = value
      If _locked Then
        imgLock.Image = My.Resources.lockOpen
      Else
        imgLock.Image = My.Resources.lockClose
      End If
    End Set
  End Property

  Public Sub New()
    InitializePrisCollection()
    TblBladStamdataTableAdapter.Fill(DstBladStamdata.tblBladStamdata)
    Me.Cursor = Cursors.Default
  End Sub

  Public Sub New(ByVal UgeavisID As Integer)
    InitializePrisCollection()
    TblBladStamdataTableAdapter.FillByBladID(DstBladStamdata.tblBladStamdata, UgeavisID)
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub InitializePrisCollection()
    Dim placeringID As Integer
    Dim året As Byte
    Dim teksten As String

    InitializeComponent()
    For i As Integer = 2010 To frmMain.DetteÅr
      året = i - 2000
      teksten = CStr(i)
      cboÅr.Items.Add(året, teksten)
    Next i

    For Each tab As Infragistics.Win.UltraWinTabControl.UltraTab In tabPriser.Tabs
      For Each ctrl As Control In grpPriser.Controls
        If TypeOf ctrl Is UltraTextEditor Then
          placeringID = tab.Index
          If placeringID < 7 Then
            placeringID = placeringID + 1
          Else
            placeringID = placeringID + 4
          End If
          If ctrl.Name = "txtFormatFra1" Then
            _prisColl.Add("0", "tab" & placeringID.ToString & ctrl.Name)
          Else
            _prisColl.Add("", "tab" & placeringID.ToString & ctrl.Name)
          End If
        End If
      Next
    Next
  End Sub

  Private Sub imgLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLock.Click
    If _locked Then
      imgLock.Image = My.Resources.lockOpen
      'tspBladStamData.BackColor = Color.FromArgb(196, 201, 207)
    Else
      imgLock.Image = My.Resources.lockClose
      'tspBladStamData.BackColor = Color.FromArgb(43, 87, 97)
    End If
    _locked = Not _locked
  End Sub

  Private Sub imgChain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgChain.Click
    If _chained Then
      imgChain.Image = My.Resources.chainOpen
    Else
      imgChain.Image = My.Resources.chainClosed
    End If
    _chained = Not _chained
  End Sub

  Private Sub txtFarvetillæg_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1Farvetillæg1.ValueChanged, txt4Farvertillæg1.ValueChanged, txt1Farvetillæg2.ValueChanged, txt4Farvertillæg2.ValueChanged, txt1Farvetillæg3.ValueChanged, txt4Farvertillæg3.ValueChanged, txt1Farvetillæg4.ValueChanged, txt4Farvertillæg4.ValueChanged, txt1Farvetillæg5.ValueChanged, txt4Farvertillæg5.ValueChanged, txt1Farvetillæg6.ValueChanged, txt4Farvertillæg6.ValueChanged, txt1Farvetillæg7.ValueChanged, txt4Farvertillæg7.ValueChanged, txt1Farvetillæg8.ValueChanged, txt4Farvertillæg8.ValueChanged
    Dim control As UltraTextEditor = DirectCast(sender, UltraTextEditor)
    Dim controlName As String = control.Name.Substring(0, control.Name.Length - 1)
    Dim controlNr As String = CInt(control.Name.Substring(control.Name.Length - 1))
    Dim minMaxAktiveret As Boolean = False
    Dim i As Integer
    Dim controlValue As Double

    If control.TextLength > 0 AndAlso Double.TryParse(control.Text, controlValue) AndAlso controlValue < 20 Then
      grpPriser.Controls(controlName & "Min" & controlNr).Enabled = True
      grpPriser.Controls(controlName & "Max" & controlNr).Enabled = True
    Else
      grpPriser.Controls(controlName & "Min" & controlNr).Enabled = False
      grpPriser.Controls(controlName & "Max" & controlNr).Enabled = False
    End If
    For i = 1 To 8
      If grpPriser.Controls(controlName & "Min" & i.ToString).Enabled = True Then minMaxAktiveret = True
    Next
    If minMaxAktiveret = True Then
      grpPriser.Controls(controlName.Replace("txt", "lbl") & "Min").Enabled = True
      grpPriser.Controls(controlName.Replace("txt", "lbl") & "Max").Enabled = True
    Else
      grpPriser.Controls(controlName.Replace("txt", "lbl") & "Min").Enabled = False
      grpPriser.Controls(controlName.Replace("txt", "lbl") & "Max").Enabled = False
    End If
  End Sub

  Private Sub txtFormatTil_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFormatTil1.ValueChanged, txtFormatTil2.ValueChanged, txtFormatTil3.ValueChanged, txtFormatTil4.ValueChanged, txtFormatTil5.ValueChanged, txtFormatTil6.ValueChanged, txtFormatTil7.ValueChanged, txtFormatTil8.ValueChanged
    Dim control As UltraTextEditor = DirectCast(sender, UltraTextEditor)
    Dim controlName As String = control.Name.Substring(0, control.Name.Length - 1)
    Dim controlNr As String = CInt(control.Name.Substring(control.Name.Length - 1))
    Dim controlValue As Integer
    Dim trueOrFalse As Boolean = False
    Dim placeringID As Integer

    If control.TextLength > 0 AndAlso Integer.TryParse(control.Text, controlValue) Then
      trueOrFalse = True
    Else
      trueOrFalse = False
    End If
    If controlNr = 1 Then
      lbl1Farve.Enabled = trueOrFalse
      lbl4Farver.Enabled = trueOrFalse
    End If
    If controlNr < 8 Then
      For Each ctrl As Control In grpPriser.Controls
        If ctrl.Name.EndsWith(Trim(Str(controlNr + 1))) Then ctrl.Visible = trueOrFalse
      Next
      grpPriser.Controls("txtFormatFra" & Trim(Str(controlNr + 1))).Text = CStr(controlValue + 1)
      placeringID = tabPriser.SelectedTab.Index
      If placeringID < 7 Then
        placeringID = placeringID + 1
      Else
        placeringID = placeringID + 4
      End If
      _prisColl.Remove("tab" & placeringID.ToString & "txtFormatFra" & Trim(Str(controlNr + 1)))
      _prisColl.Add(CStr(controlValue + 1), "tab" & placeringID.ToString & "txtFormatFra" & Trim(Str(controlNr + 1)))
    End If
  End Sub

  Private Sub tabPriser_SelectedTabChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabPriser.SelectedTabChanged
    Dim placeringID As Integer

    For Each ctrl As Control In grpPriser.Controls
      If TypeOf ctrl Is UltraTextEditor Then
        If e.PreviousSelectedTab IsNot Nothing Then
          placeringID = e.PreviousSelectedTab.Index
          If placeringID < 7 Then
            placeringID = placeringID + 1
          Else
            placeringID = placeringID + 4
          End If
          If _prisColl.Contains("tab" & placeringID.ToString & ctrl.Name) Then _prisColl.Remove("tab" & placeringID.ToString & ctrl.Name)
          _prisColl.Add(ctrl.Text.ToString, "tab" & placeringID.ToString & ctrl.Name)
        End If
        placeringID = e.Tab.Index
        If placeringID < 7 Then
          placeringID = placeringID + 1
        Else
          placeringID = placeringID + 4
        End If
        ctrl.Text = _prisColl("tab" & placeringID.ToString & ctrl.Name).ToString
      End If
    Next
  End Sub

  Private Sub FrmBladStamData_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Dim svar As DialogResult
    EndEdit()
    If DstBladStamdata.HasChanges AndAlso _noSave = False Then
      svar = MessageBox.Show("Du har ændringer der ikke er gemt." & vbCrLf & "Vil du gemme dem?", "Ikke gemt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
      If svar = Windows.Forms.DialogResult.Cancel Then e.Cancel = True
      If svar = Windows.Forms.DialogResult.Yes Then SaveData()
    End If
  End Sub

  Private Sub FrmBladStamData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    grdAllePriser.DrawFilter = New SortIndicatorDrawFilter
    Me.TblÅrMedPriserTableAdapter.Fill(Me.DstBladStamdata.tblÅrMedPriser)
    Me.TblDageTableAdapter.Fill(Me.UgedagListeDropdown.tblDage)
    Me.TblGeoKodeTableAdapter.Fill(Me.GeoKodeListeDropdown.tblGeoKode)
    Me.TblDelOmrådeTableAdapter.Fill(Me.DelområdeListeDropdown.tblDelOmråde)
    Me.TblRegionTableAdapter.Fill(Me.RegionListeDropdown.tblRegion)
        Me.TblPostNrTableAdapter.Fill(Me.PostNrListeDropdown.tblPostNr)


        Me.TableMedAllePriserTableAdapter.Fill(Me.DstBladStamdata.tableMedAllePriser)
        Me.TblPrislisterPrBladPrUgeTableAdapter.FillByÅr(Me.DstBladStamdata.tblPrislisterPrBladPrUge, frmMain.DetteÅr)
        Try
            Me.TblBladDækningTableAdapter.Fill(Me.DstBladStamdata.tblBladDækning)
        Catch
        End Try
        Me.TblPrislisterPrBladPrÅrTableAdapter.FillByÅr(Me.DstBladStamdata.tblPrislisterPrBladPrÅr, frmMain.DetteÅr)
        _isLoading = False
    End Sub

    Private Sub TblBladStamdataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblBladStamdataBindingNavigatorSaveItem.Click

        EndEdit()
        SaveData()
        If _nyErOprettet Then
            Me.TblPrislisterPrBladPrÅrTableAdapter.InsertPrisliste(txtUgeavisID.Value, frmMain.DetteÅr, 1)
            _nyErOprettet = False
            Me.TblÅrMedPriserTableAdapter.Fill(Me.DstBladStamdata.tblÅrMedPriser)
        End If
        indlæsPriser()
    End Sub

    Private Sub EndEdit()


        Me.TblBladStamdataBindingSource.AllowNew = True
   
        Me.TblBladStamdataBindingSource.EndEdit()
        Me.TblPrislisterPrBladPrUgeBindingSource.EndEdit()
        Me.TblBladDækningBindingSource.EndEdit()
    End Sub

    Private Sub SaveData()
        Me.Cursor = Cursors.WaitCursor
        Dim resultat As Boolean

        Me.Validate()
        If Me.TblBladStamdataTableAdapter.Update(Me.DstBladStamdata.tblBladStamdata) > 0 Then
            resultat = True


        End If

        If frmMain.BrugerNavn = "LEJ" OrElse frmMain.BrugerNavn = "LW" OrElse frmMain.BrugerNavn = "AN" OrElse frmMain.BrugerNavn = "CWS" OrElse frmMain.BrugerNavn = "SMJ" OrElse frmMain.BrugerNavn = "LVL" OrElse frmMain.BrugerNavn = "TK" Then


            Me.TblPrislisterPrBladPrUgeTableAdapter.Update(Me.DstBladStamdata.tblPrislisterPrBladPrUge)
       
            Me.TblBladDækningTableAdapter.Update(Me.DstBladStamdata.tblBladDækning)
            savePriser(_previousBladID, _previousÅr, _previousPrisliste)
            Me.Cursor = Cursors.Default
            _nyErOprettet = True
        End If



    End Sub

    Private Sub savePriser(ByVal bladID As Integer, ByVal år As Integer, ByVal prisListe As Integer)
        Dim ta As New dstBladStamdataTableAdapters.tblPriserTableAdapter
        Dim controlName As String
        Dim controlNr As String
        Dim formatFra As Integer
        Dim formatTil As Integer
        Dim mmPris As Double
        Dim farvePris As Double
        Dim farveMin As Double
        Dim farveMax As Double
        Dim farve4Pris As Double
        Dim farve4Min As Double
        Dim farve4Max As Double
        Dim placeringID As Integer
        Dim proceed As Boolean = False

        If frmMain.BrugerNavn <> "LEJ" AndAlso frmMain.BrugerNavn <> "LW" AndAlso frmMain.BrugerNavn <> "AN" AndAlso frmMain.BrugerNavn <> "CWS" AndAlso frmMain.BrugerNavn <> "SMJ" AndAlso frmMain.BrugerNavn <> "LVL" AndAlso frmMain.BrugerNavn <> "TK" Then Exit Sub
        If prisListe = 0 OrElse bladID = 0 Then Exit Sub
        ' MessageBox.Show("Gemmer priser for ID:" & bladID & " - År:" & år & " - Prisliste:" & prisListe)
        For Each ctrl As Control In grpPriser.Controls
            If TypeOf ctrl Is UltraTextEditor Then
                placeringID = tabPriser.SelectedTab.Index
                If placeringID < 7 Then
                    placeringID = placeringID + 1
                Else
                    placeringID = placeringID + 4
                End If
                If _prisColl.Contains("tab" & placeringID.ToString & ctrl.Name) Then _prisColl.Remove("tab" & placeringID.ToString & ctrl.Name)
                _prisColl.Add(ctrl.Text.ToString, "tab" & placeringID.ToString & ctrl.Name)
            End If
        Next
        ta.DeletePriserBladIDÅrPrisliste(bladID, år, prisListe)
        For Each tab As Infragistics.Win.UltraWinTabControl.UltraTab In tabPriser.Tabs
            For Each ctrl As Control In grpPriser.Controls
                If TypeOf ctrl Is UltraTextEditor Then
                    controlName = ctrl.Name.Substring(0, ctrl.Name.Length - 1)
                    controlNr = CInt(ctrl.Name.Substring(ctrl.Name.Length - 1))
                    If controlName = "txtMmPris" Then
                        placeringID = tab.Index
                        If placeringID < 7 Then
                            placeringID = placeringID + 1
                        Else
                            placeringID = placeringID + 4
                        End If
                        If _prisColl.Contains("tab" & placeringID.ToString & ctrl.Name) Then
                            proceed = False
                            If TypeOf (_prisColl("tab" & placeringID.ToString & ctrl.Name)) Is String Then
                                If _prisColl("tab" & placeringID.ToString & ctrl.Name) <> "" Then proceed = True
                            Else
                                If _prisColl("tab" & placeringID.ToString & ctrl.Name) <> 0 Then proceed = True
                            End If
                            If proceed Then
                                Integer.TryParse(_prisColl("tab" & placeringID.ToString & "txtFormatFra" & controlNr), formatFra)
                                Integer.TryParse(_prisColl("tab" & placeringID.ToString & "txtFormatTil" & controlNr), formatTil)
                                If formatTil < 1 Then formatTil = 9999
                                Double.TryParse(_prisColl("tab" & placeringID.ToString & "txtMmPris" & controlNr), mmPris)
                                Double.TryParse(_prisColl("tab" & placeringID.ToString & "txt1FarveTillæg" & controlNr), farvePris)
                                Double.TryParse(_prisColl("tab" & placeringID.ToString & "txt1FarveTillægMin" & controlNr), farveMin)
                                Double.TryParse(_prisColl("tab" & placeringID.ToString & "txt1FarveTillægMax" & controlNr), farveMax)
                                Double.TryParse(_prisColl("tab" & placeringID.ToString & "txt4FarverTillæg" & controlNr), farve4Pris)
                                Double.TryParse(_prisColl("tab" & placeringID.ToString & "txt4FarverTillægMin" & controlNr), farve4Min)
                                Double.TryParse(_prisColl("tab" & placeringID.ToString & "txt4FarverTillægMax" & controlNr), farve4Max)
                                'ta.DeletePrisLinje(bladID, placeringID, år, prisListe, formatFra)
                                ta.Insert(bladID, placeringID, år, prisListe, formatFra, formatTil, mmPris, farvePris, farveMin, farveMax, farve4Pris, farve4Min, farve4Max, controlNr)
                            End If
                        End If
                    End If
                End If
            Next
        Next
        _nyErOprettet = False

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        MessageBox.Show("Opret nyt stamblad med id " & _previousBladID + 1)
        _nyErOprettet = False

        SaveData()

    End Sub

    Private Sub indlæsPriser()
        Dim ta As New dstBladStamdataTableAdapters.tblPriserTableAdapter
        Dim table As New dstBladStamdata.tblPriserDataTable
        Dim i As Integer
        Dim j As Integer
        Dim placeringID As Integer
        Dim formatFra As Integer
        Dim formatTil As Integer
        Dim mmPris As Double
        Dim farvePris As Double
        Dim farveMin As Double
        Dim farveMax As Double
        Dim farve4Pris As Double
        Dim farve4Min As Double
        Dim farve4Max As Double

        If cboPriserÅr.Text <> "- Vælg år -" Then
            i = ta.FillByBladIDÅrPrislisteID(table, txtUgeavisID.Value, cboPriserÅr.Value, cboPrislister.Value)
        Else
            i = 0
        End If
        _prisColl.Clear()
        For Each tab As Infragistics.Win.UltraWinTabControl.UltraTab In tabPriser.Tabs
            For Each ctrl As Control In grpPriser.Controls
                If TypeOf ctrl Is UltraTextEditor Then
                    placeringID = tab.Index
                    If placeringID < 7 Then
                        placeringID = placeringID + 1
                    Else
                        placeringID = placeringID + 4
                    End If
                    If ctrl.Name = "txtFormatFra1" Then
                        _prisColl.Add("0", "tab" & placeringID.ToString & ctrl.Name)
                    Else
                        _prisColl.Add("", "tab" & placeringID.ToString & ctrl.Name)
                    End If
                End If
            Next
        Next
        If i > 0 Then
            '     MessageBox.Show("Henter priser for ID:" & txtUgeavisID.Value & " - År:" & cboPriserÅr.Value & " - Prisliste:" & cboPrislister.Value)
            For j = 0 To i - 1
                placeringID = table(j).PlaceringID
                _prisColl.Remove("tab" & placeringID.ToString & "txtFormatFra" & table(j).ControlNavn)
                Integer.TryParse(table(j).FormatFra, formatFra)
                _prisColl.Add(formatFra, "tab" & placeringID.ToString & "txtFormatFra" & table(j).ControlNavn)

                _prisColl.Remove("tab" & placeringID.ToString & "txtFormatTil" & table(j).ControlNavn)
                Integer.TryParse(table(j).FormatTil, formatTil)
                If formatTil = 9999 Then
                    _prisColl.Add("", "tab" & placeringID.ToString & "txtFormatTil" & table(j).ControlNavn)
                Else
                    _prisColl.Add(formatTil, "tab" & placeringID.ToString & "txtFormatTil" & table(j).ControlNavn)
                End If

                _prisColl.Remove("tab" & placeringID.ToString & "txtMmPris" & table(j).ControlNavn)
                If Not table(j).IsmmPrisNull Then
                    Double.TryParse(table(j).mmPris, mmPris)
                    _prisColl.Add(mmPris, "tab" & placeringID.ToString & "txtMmPris" & table(j).ControlNavn)
                Else
                    _prisColl.Add("", "tab" & placeringID.ToString & "txtMmPris" & table(j).ControlNavn)
                End If

                _prisColl.Remove("tab" & placeringID.ToString & "txt1FarveTillæg" & table(j).ControlNavn)
                If Not table(j).IsFarvePrisNull Then
                    Double.TryParse(table(j).FarvePris, farvePris)
                    If farvePris = 0 Then
                        _prisColl.Add("", "tab" & placeringID.ToString & "txt1FarveTillæg" & table(j).ControlNavn)
                    Else
                        _prisColl.Add(farvePris, "tab" & placeringID.ToString & "txt1FarveTillæg" & table(j).ControlNavn)
                    End If
                Else
                    _prisColl.Add("", "tab" & placeringID.ToString & "txt1FarveTillæg" & table(j).ControlNavn)
                End If

                _prisColl.Remove("tab" & placeringID.ToString & "txt1FarveTillægMin" & table(j).ControlNavn)
                If Not table(j).IsFarveMinNull Then
                    Double.TryParse(table(j).FarveMin, farveMin)
                    If farveMin = 0 Then
                        _prisColl.Add("", "tab" & placeringID.ToString & "txt1FarveTillægMin" & table(j).ControlNavn)
                    Else
                        _prisColl.Add(farveMin, "tab" & placeringID.ToString & "txt1FarveTillægMin" & table(j).ControlNavn)
                    End If
                Else
                    _prisColl.Add("", "tab" & placeringID.ToString & "txt1FarveTillægMin" & table(j).ControlNavn)
                End If

                _prisColl.Remove("tab" & placeringID.ToString & "txt1FarveTillægMax" & table(j).ControlNavn)
                If Not table(j).IsFarveMaxNull Then
                    Double.TryParse(table(j).FarveMax, farveMax)
                    If farveMax = 0 Then
                        _prisColl.Add("", "tab" & placeringID.ToString & "txt1FarveTillægMax" & table(j).ControlNavn)
                    Else
                        _prisColl.Add(farveMax, "tab" & placeringID.ToString & "txt1FarveTillægMax" & table(j).ControlNavn)
                    End If
                Else
                    _prisColl.Add("", "tab" & placeringID.ToString & "txt1FarveTillægMax" & table(j).ControlNavn)
                End If

                _prisColl.Remove("tab" & placeringID.ToString & "txt4FarverTillæg" & table(j).ControlNavn)
                If Not table(j).IsFarve4PrisNull Then
                    Double.TryParse(table(j).Farve4Pris, farve4Pris)
                    If farve4Pris = 0 Then
                        _prisColl.Add("", "tab" & placeringID.ToString & "txt4FarverTillæg" & table(j).ControlNavn)
                    Else
                        _prisColl.Add(farve4Pris, "tab" & placeringID.ToString & "txt4FarverTillæg" & table(j).ControlNavn)
                    End If
                Else
                    _prisColl.Add("", "tab" & placeringID.ToString & "txt4FarverTillæg" & table(j).ControlNavn)
                End If

                _prisColl.Remove("tab" & placeringID.ToString & "txt4FarverTillægMin" & table(j).ControlNavn)
                If Not table(j).IsFarve4MinNull Then
                    Double.TryParse(table(j).Farve4Min, farve4Min)
                    If farve4Min = 0 Then
                        _prisColl.Add("", "tab" & placeringID.ToString & "txt4FarverTillægMin" & table(j).ControlNavn)
                    Else
                        _prisColl.Add(farve4Min, "tab" & placeringID.ToString & "txt4FarverTillægMin" & table(j).ControlNavn)
                    End If
                Else
                    _prisColl.Add("", "tab" & placeringID.ToString & "txt4FarverTillægMin" & table(j).ControlNavn)
                End If

                _prisColl.Remove("tab" & placeringID.ToString & "txt4FarverTillægMax" & table(j).ControlNavn)
                If Not table(j).IsFarve4MaxNull Then
                    Double.TryParse(table(j).Farve4Max, farve4Max)
                    If farve4Max = 0 Then
                        _prisColl.Add("", "tab" & placeringID.ToString & "txt4FarverTillægMax" & table(j).ControlNavn)
                    Else
                        _prisColl.Add(farve4Max, "tab" & placeringID.ToString & "txt4FarverTillægMax" & table(j).ControlNavn)
                    End If
                Else
                    _prisColl.Add("", "tab" & placeringID.ToString & "txt4FarverTillægMax" & table(j).ControlNavn)
                End If
            Next
            'Else
            '_prisColl.Clear()
            'For Each tab As Infragistics.Win.UltraWinTabControl.UltraTab In tabPriser.Tabs
            '  For Each ctrl As Control In grpPriser.Controls
            '    If TypeOf ctrl Is UltraTextEditor Then
            '      placeringID = tab.Index
            '      If placeringID < 5 Then
            '        placeringID = placeringID + 1
            '      Else
            '        placeringID = placeringID + 6
            '      End If
            '      If ctrl.Name = "txtFormatFra1" Then
            '        _prisColl.Add("0", "tab" & placeringID.ToString & ctrl.Name)
            '      Else
            '        _prisColl.Add("", "tab" & placeringID.ToString & ctrl.Name)
            '      End If
            '    End If
            '  Next
            'Next
        End If
        For Each ctrl As Control In grpPriser.Controls
            If TypeOf ctrl Is UltraTextEditor Then
                placeringID = tabPriser.SelectedTab.Index
                If placeringID < 7 Then
                    placeringID = placeringID + 1
                Else
                    placeringID = placeringID + 4
                End If
                ctrl.Text = _prisColl("tab" & placeringID.ToString & ctrl.Name).ToString
            End If
        Next
        _previousBladID = txtUgeavisID.Value
        If cboPriserÅr.Text <> "- Vælg år -" Then
            _previousÅr = cboPriserÅr.Value
        Else
            _previousÅr = 0
        End If
        _previousPrisliste = cboPrislister.Value
    End Sub

    Private Sub cboPostNr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPostNr.TextChanged
        Try
            txtBynavn.Text = cboPostNr.SelectedRow.Cells("PostBy").Value
        Catch
        End Try
    End Sub

    Private Sub cboPrislister_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPrislister.ValueChanged
        savePriser(_previousBladID, _previousÅr, _previousPrisliste)
        ''   _previousPrisliste = CInt(cboPrislister.Value)
        indlæsPriser()
    End Sub

    Private Sub cboPriserÅr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPriserÅr.ValueChanged
        'savePriser(_previousBladID, _previousÅr, _previousPrisliste)
        Me.TblPrislisterPrBladPrUgeTableAdapter.FillByÅr(Me.DstBladStamdata.tblPrislisterPrBladPrUge, cboPriserÅr.Value)

        'Me.TblPrislisterPrBladPrÅrTableAdapter.FillByÅr(Me.DstBladStamdata.tblPrislisterPrBladPrÅr, cboPriserÅr.Value)
        '  _previousÅr = CInt(cboPriserÅr.Value)
        'indlæsPriser()
    End Sub

    Private Sub btnTilføjPrisliste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTilføjPrisliste.Click
        Dim år As Integer = cboPriserÅr.Value
        Dim huskPosition As Integer = TblBladStamdataBindingSource.Position
        Dim huskFilter As String = TblBladStamdataBindingSource.Filter
        If frmTilføjPrisliste.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TblPrislisterPrBladPrÅrTableAdapter.InsertPrisliste(txtUgeavisID.Value, år, frmTilføjPrisliste.ValgtPrisliste)
            TblBladStamdataBindingSource.Filter = ""
            Me.TblPrislisterPrBladPrÅrTableAdapter.FillByÅr(Me.DstBladStamdata.tblPrislisterPrBladPrÅr, frmMain.DetteÅr)
            TblBladStamdataBindingSource.Filter = huskFilter
            If huskPosition > 0 Then TblBladStamdataBindingSource.Position = huskPosition
        End If
    End Sub


    Private Sub txtNavn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNavn.ValueChanged
        If chkOphørt.Checked Then
            tslAvisNavn.Text = txtUgeavisID.Text & " - " & Trim(txtNavn.Text) & " - Ophørt"
            Me.Text = txtUgeavisID.Text & " - " & Trim(txtNavn.Text) & " - Ophørt"
        Else
            tslAvisNavn.Text = txtUgeavisID.Text & " - " & Trim(txtNavn.Text)
            Me.Text = txtUgeavisID.Text & " - " & Trim(txtNavn.Text)
        End If
    End Sub

    Private Sub chkOphørt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOphørt.CheckedChanged
        If chkOphørt.Checked Then
            chkMedPåWWW.Checked = False
        End If
    End Sub

    Private Sub chkMedPåWWW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedPåWWW.CheckedChanged
        If chkMedPåWWW.Checked Then
            chkOphørt.Checked = False
        End If
    End Sub

    Private Sub btnLuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuk.Click
        Me.Close()
    End Sub

    Private Sub btnGem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGem.Click
        EndEdit()
        SaveData()
    End Sub

    Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
        _noSave = True
        Me.Close()
    End Sub

    Private Sub btnUdskriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUdskriv.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 10
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 10
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 10
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 10
        PrintDialog1.PrinterSettings = PrintForm1.PrinterSettings
        PrintDialog1.ShowDialog()
        PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
    End Sub

    Private Sub TblBladStamdataBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles TblBladStamdataBindingSource.ListChanged
        If Not _isLoading Then
            savePriser(_previousBladID, _previousÅr, _previousPrisliste)
            indlæsPriser()
        End If
    End Sub

    Private Sub TblBladStamdataBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TblBladStamdataBindingSource.PositionChanged
        savePriser(_previousBladID, _previousÅr, _previousPrisliste)
        indlæsPriser()
        If _nyTilføjet Then
            MessageBox.Show("Ny positionchanged " & txtUgeavisID.Text)
            Dim i As Integer
            Dim huskPosition As Integer = TblBladStamdataBindingSource.Position
            Dim huskFilter As String = TblBladStamdataBindingSource.Filter

            SaveData()

            Me.TblPrislisterPrBladPrÅrTableAdapter.FillByÅr(Me.DstBladStamdata.tblPrislisterPrBladPrÅr, frmMain.DetteÅr)
            For i = 1 To 53
                TblPrislisterPrBladPrUgeTableAdapter.InsertPrislistePrBladPrÅrPrUge(frmMain.DetteÅr, txtUgeavisID.Text, i, 1)
            Next i
            TblBladStamdataBindingSource.Filter = ""
            Me.TblÅrMedPriserTableAdapter.Fill(Me.DstBladStamdata.tblÅrMedPriser)
            Me.TableMedAllePriserTableAdapter.Fill(Me.DstBladStamdata.tableMedAllePriser)
            Me.TblPrislisterPrBladPrÅrTableAdapter.InsertPrisliste(txtUgeavisID.Value, frmMain.DetteÅr, 1)
            Me.TblPrislisterPrBladPrUgeTableAdapter.FillByÅr(Me.DstBladStamdata.tblPrislisterPrBladPrUge, frmMain.DetteÅr)

            TblBladStamdataBindingSource.Filter = huskFilter
            If huskPosition > 0 Then TblBladStamdataBindingSource.Position = huskPosition
            _nyTilføjet = False
            indlæsPriser()
        End If
    End Sub

    Private Sub txtOrdreEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrdreEmail.Leave
        CheckEmailAdr(txtOrdreEmail.Text)
    End Sub

    Private Sub CheckEmailAdr(ByVal Adresser As String)
        '   Dim EmailVerify As New EmailVerifierComponent.EmailVerifier
        '  Dim VerifyResult As Boolean 'EmailVerifierComponent.Result
        Dim Emails() As String
        Dim i As Integer
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match
        If Adresser.Length > 0 Then
            Emails = Split(Adresser, ";")
            For i = 0 To UBound(Emails)
                '       VerifyResult = EmailVerify.EmailAddressIsValid(Emails(i)) 'Verify(Emails(i))
                emailMatch = emailRegex.Match(Emails(i))
                If Not emailMatch.Success Then MessageBox.Show("Fejl i email adressen: " & Emails(i), "Fejl i Email adresse", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Next
        End If
    End Sub

    Private Sub txtMaterialeEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaterialeEmail.Leave
        CheckEmailAdr(txtMaterialeEmail.Text)
    End Sub

    Private Sub txtOrdrecheckEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrdrecheckEmail.Leave
        CheckEmailAdr(txtOrdrecheckEmail.Text)
    End Sub

    Private Sub txtAnnoncekontrolEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnnoncekontrolEmail.Leave
        CheckEmailAdr(txtAnnoncekontrolEmail.Text)
    End Sub

    Private Sub txtBilagsbladeEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBilagsbladeEmail.Leave
        CheckEmailAdr(txtBilagsbladeEmail.Text)
    End Sub

    Private Sub txtAnsvarligForStamdataEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnsvarligForStamdataEmail.Leave
        CheckEmailAdr(txtAnsvarligForStamdataEmail.Text)
    End Sub

    Private Sub txtPrisforespørgselEmails_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrisforespørgselEmails.Leave
        CheckEmailAdr(txtPrisforespørgselEmails.Text)
    End Sub

    Private Sub txtOrienteringsEmails_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrienteringsEmails.Leave
        CheckEmailAdr(txtOrienteringsEmails.Text)
    End Sub

    Private Sub txtEmails_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmails.Leave
        CheckEmailAdr(txtEmails.Text)
    End Sub

    Private Sub txtKontaktpersonerEmails_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKontaktpersonerEmails.Leave
        CheckEmailAdr(txtKontaktpersonerEmails.Text)
    End Sub

    Private Sub txtBogholderiEmails_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBogholderiEmails.Leave
        CheckEmailAdr(txtBogholderiEmails.Text)
    End Sub

    Private Sub txtRedaktionsEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRedaktionsEmail.Leave
        CheckEmailAdr(txtRedaktionsEmail.Text)
    End Sub

    Private Sub txtBladetsAnnonceEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBladetsAnnonceEmail.Leave
        CheckEmailAdr(txtBladetsAnnonceEmail.Text)
    End Sub


    Private Sub txtOrdredeadlineTekst_Leave(sender As System.Object, e As System.EventArgs) Handles txtOrdredeadlineTekst.Leave
        If txtUgeavisID.Value <> 0 Then
            Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
            Dim cm As SqlCommand = cn.CreateCommand()

            cm.CommandType = CommandType.Text

            cm.CommandText = "UPDATE tblBladStamdata SET OrdreDeadlineTekstDag = " & findUgedagID(txtOrdredeadlineTekst.Text) & " WHERE  (BladID = " & txtUgeavisID.Text & ")"
            cn.Open()
            cm.ExecuteNonQuery()

            cm.CommandText = "UPDATE tblBladStamdata SET OrdreDeadlineTekstKl = N'" & txtOrdredeadlineTekst.Text.Substring(txtOrdredeadlineTekst.TextLength - 5, 5) & "' WHERE (BladID = " & txtUgeavisID.Text & ")"
            cm.ExecuteNonQuery()
            cn.Close()
            cm.Dispose()
            cn.Dispose()
        End If
    End Sub

    Private Function findUgedagID(Ugedag As String) As Integer
        Dim findTekst As String = UCase(Ugedag.Substring(0, 3))
        Dim fundetDag As Integer = 0

        Select Case findTekst
            Case "MAN"
                fundetDag = 1
            Case "TIR"
                fundetDag = 2
            Case "ONS"
                fundetDag = 3
            Case "TOR"
                fundetDag = 4
            Case "FRE"
                fundetDag = 5
        End Select
        Return fundetDag
    End Function

    Private Sub txtOrdredeadlineRubrik_Leave(sender As System.Object, e As System.EventArgs) Handles txtOrdredeadlineRubrik.Leave
        If txtUgeavisID.Value <> 0 Then
            Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
            Dim cm As SqlCommand = cn.CreateCommand()

            cm.CommandType = CommandType.Text

            cm.CommandText = "UPDATE tblBladStamdata SET OrdreDeadlineRubrikDag = " & findUgedagID(txtOrdredeadlineRubrik.Text) & " WHERE (BladID = " & txtUgeavisID.Text & ")"
            cn.Open()
            cm.ExecuteNonQuery()

            cm.CommandText = "UPDATE tblBladStamdata SET OrdreDeadlineRubrikKl = N'" & txtOrdredeadlineRubrik.Text.Substring(txtOrdredeadlineRubrik.TextLength - 5, 5) & "' WHERE (BladID = " & txtUgeavisID.Text & ")"
            cm.ExecuteNonQuery()
            cn.Close()
            cm.Dispose()
            cn.Dispose()
        End If
    End Sub

    Private Sub txtMaterialedeadlineTekst_Leave(sender As System.Object, e As System.EventArgs) Handles txtMaterialedeadlineTekst.Leave
        If txtUgeavisID.Value <> 0 Then
            Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
            Dim cm As SqlCommand = cn.CreateCommand()

            cm.CommandType = CommandType.Text

            cm.CommandText = "UPDATE tblBladStamdata SET MaterialeDeadlineTekstDag = " & findUgedagID(txtMaterialedeadlineTekst.Text) & " WHERE  (BladID = " & txtUgeavisID.Text & ")"
            cn.Open()
            cm.ExecuteNonQuery()

            cm.CommandText = "UPDATE tblBladStamdata SET MaterialeDeadlineTekstKl = N'" & txtMaterialedeadlineTekst.Text.Substring(txtMaterialedeadlineTekst.TextLength - 5, 5) & "' WHERE (BladID = " & txtUgeavisID.Text & ")"
            cm.ExecuteNonQuery()
            cn.Close()
            cm.Dispose()
            cn.Dispose()
        End If
    End Sub

    Private Sub txtMaterialedeadlineRubrik_Leave(sender As System.Object, e As System.EventArgs) Handles txtMaterialedeadlineRubrik.Leave
        If txtUgeavisID.Value <> 0 Then
            Dim cn As New SqlConnection(My.Settings.DiMPdotNetConnectionString)
            Dim cm As SqlCommand = cn.CreateCommand()

            cm.CommandType = CommandType.Text

            cm.CommandText = "UPDATE tblBladStamdata SET MaterialeDeadlineRubrikDag = " & findUgedagID(txtMaterialedeadlineRubrik.Text) & " WHERE  (BladID = " & txtUgeavisID.Text & ")"
            cn.Open()
            cm.ExecuteNonQuery()

            cm.CommandText = "UPDATE tblBladStamdata SET MaterialeDeadlineRubrikKl = N'" & txtMaterialedeadlineRubrik.Text.Substring(txtMaterialedeadlineRubrik.TextLength - 5, 5) & "' WHERE (BladID = " & txtUgeavisID.Text & ")"
            cm.ExecuteNonQuery()
            cn.Close()
            cm.Dispose()
            cn.Dispose()
        End If
    End Sub

End Class