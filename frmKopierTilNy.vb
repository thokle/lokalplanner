Imports System.Windows.Forms

Public Class frmKopierTilNy
  Private _modul As String
  Private _bemærkning As String

  Public Sub New(ByVal modul As String, ByVal Bemærkning As String, ByVal AnvendtMiljøTillæg As Double)
    InitializeComponent()
    _modul = modul
    _bemærkning = Bemærkning
    txtBemærkning.Text = Bemærkning
    If modul = "Medieplan" Then
      optModul.Visible = False
      lblBemærkning.Visible = False
      txtBemærkning.Visible = False
      optBemærkning.Visible = False
    End If
    If frmMain.AktivMiljøTillæg <> AnvendtMiljøTillæg Then
      Me.Size = New Size(290, 375)
      optMiljøTillæg.Visible = True
      lblMiljøTillæg.Visible = True
    Else
      optMiljøTillæg.Visible = False
      lblMiljøTillæg.Visible = False
      Me.Size = New Size(290, 315)
    End If
  End Sub

  Public ReadOnly Property MedtagBemærkning() As Boolean
    Get
      If optBemærkning.Value = 0 Then
        Return True
      Else
        Return False
      End If
    End Get
  End Property

  Public ReadOnly Property Genberegn() As Boolean
    Get
      If optGenberegn.Value = 0 Then
        Return True
      Else
        Return False
      End If
    End Get
  End Property

  Public ReadOnly Property NulstilBureauOrdreNr() As Boolean
    Get
      If optBureauOrdreNr.Value = 0 Then
        Return True
      Else
        Return False
      End If
    End Get
  End Property

  Public ReadOnly Property ÅbenIModul() As String
    Get
      If optModul.Value = 0 Then
        Return "Medieplan"
      Else
        Return "Booking"
      End If
    End Get
  End Property

  Public ReadOnly Property BeholdMiljøTillæg As Boolean
    Get
      If optMiljøTillæg.Value = 0 Then
        Return False
      Else
        Return True
      End If
    End Get
  End Property

  Private Sub btnAnnuller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub optGenberegn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGenberegn.ValueChanged
    checkValid()
  End Sub

  Private Sub checkValid()
    If _modul = "Medieplan" Then
      If optGenberegn.Value > -1 AndAlso optBureauOrdreNr.Value > -1 Then
        btnOk.Enabled = True
      Else
        btnOk.Enabled = False
      End If
    Else
      If optGenberegn.Value > -1 AndAlso optModul.Value > -1 AndAlso optBureauOrdreNr.Value > -1 AndAlso optBemærkning.Value > -1 Then
        btnOk.Enabled = True
      Else
        btnOk.Enabled = False
      End If
    End If
  End Sub

  Private Sub optBemærkning_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBemærkning.ValueChanged
    If optBemærkning.Value = 0 Then
      txtBemærkning.Text = _bemærkning
    Else
      txtBemærkning.Text = ""
    End If
    checkValid()
  End Sub

  Private Sub optMiljøTillæg_ValueChanged(sender As System.Object, e As System.EventArgs) Handles optMiljøTillæg.ValueChanged
    checkValid()
  End Sub
End Class
