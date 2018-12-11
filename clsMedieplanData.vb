Public Class MedieplanData
  Public Annonc�rNo_ As String = ""
  Public BureauNo_ As String = ""
  Public Format1 As Integer = 1
  Public Format2 As Integer = 100
  Public AntalFarver As Integer = 0
  Public DPKul�rID As Integer = 0
  Public PlaceringID As Integer = 1
  Public IndrykningsUge As Integer = 0
  Public Indryknings�r As Integer = 0
  Public Overskrift As String = ""
  Public Beskrivelse As String = ""
  Public KontaktPerson As String = ""
  Public KontaktpersonTilh�rer As Integer = 0
  Public Fakturering As Integer = 0
  Public RekvisitionsNr As String = ""
  Public BilagsBladeTil As Integer = -1
  Public BilagsBladeTilNavn As String = ""
  Public BilagsBladeTilAdresse As String = ""
  Public BilagsBladeTilPostNr As Integer = 0
  Public BilagsBladeAtt As String = ""
  Public MaterialeF�lgerFra As Integer = -1
  Public MaterialeF�lgerFraLeverand�r As String = ""
  Public BrugMaterialeFraUge As Integer = 0
  Public TilladFarveS�rRabat As Boolean = False
  Public TilladMmS�rRabat As Boolean = False
  Public SammeMateriale As Boolean = True
  Public KunForhandlerBundForskellig As Boolean = True
  Public SammeBureauOrdreNr As Boolean = False
  ' Public WebTill�gOpkr�ves As Boolean = True
  Public Milj�Till�gOpkr�ves As Boolean = True
  Public Opkr�vJyskeMilj�Till�g As Boolean = True
  Public Opkr�vFynskeMilj�Till�g As Boolean = True
  Public Opkr�vNorthMilj�Till�g As Boolean = True
  Public Opkr�vDSVPMilj�Till�g As Boolean = True
  Public Opkr�vJyskeMedierASTill�g As Boolean = True
  Public Opkr�vHelsing�rMilj�Till�g As Boolean = True
  Public F�llesBureauOrdreNr As String = ""
  Public Bem�rkningTilAnnonc�r As String = ""
  Public Bem�rkningTilUgeavis As String = ""

  Shared Operator =(ByVal dat1 As MedieplanData, ByVal dat2 As MedieplanData) As Boolean
    Return Not (dat1 <> dat2)
  End Operator

  Shared Operator <>(ByVal dat1 As MedieplanData, ByVal dat2 As MedieplanData) As Boolean
    Dim changes As Boolean = False
    Select Case True
      Case dat1.Annonc�rNO_ <> dat2.Annonc�rNO_
        changes = True
      Case dat1.BureauNO_ <> dat2.BureauNO_
        changes = True
      Case dat1.Format1 <> dat2.Format1
        changes = True
      Case dat1.Format2 <> dat2.Format2
        changes = True
      Case dat1.AntalFarver <> dat2.AntalFarver
        changes = True
      Case dat1.DPKul�rID <> dat2.DPKul�rID
        changes = True
      Case dat1.PlaceringID <> dat2.PlaceringID
        changes = True
      Case dat1.IndrykningsUge <> dat2.IndrykningsUge
        changes = True
      Case dat1.Indryknings�r <> dat2.Indryknings�r
        changes = True
      Case dat1.Bem�rkningTilAnnonc�r <> dat2.Bem�rkningTilAnnonc�r
        changes = True
      Case dat1.Bem�rkningTilUgeavis <> dat2.Bem�rkningTilUgeavis
        changes = True
      Case dat1.Overskrift <> dat2.Overskrift
        changes = True
      Case dat1.Fakturering <> dat2.Fakturering
        changes = True
      Case dat1.BilagsBladeTil <> dat2.BilagsBladeTil
        changes = True
      Case dat1.BilagsBladeTilNavn <> dat2.BilagsBladeTilNavn
        changes = True
      Case dat1.BilagsBladeTilAdresse <> dat2.BilagsBladeTilAdresse
        changes = True
      Case dat1.BilagsBladeTilPostNr <> dat2.BilagsBladeTilPostNr
        changes = True
      Case dat1.BilagsBladeAtt <> dat2.BilagsBladeAtt
        changes = True
      Case dat1.MaterialeF�lgerFra <> dat2.MaterialeF�lgerFra
        changes = True
      Case dat1.MaterialeF�lgerFraLeverand�r <> dat2.MaterialeF�lgerFraLeverand�r
        If dat1.MaterialeF�lgerFra <> 1 Then changes = True
      Case dat1.BrugMaterialeFraUge <> dat2.BrugMaterialeFraUge
        changes = True
      Case dat1.SammeMateriale <> dat2.SammeMateriale
        changes = True
      Case dat1.KunForhandlerBundForskellig <> dat2.KunForhandlerBundForskellig
        changes = True
      Case dat1.SammeBureauOrdreNr <> dat2.SammeBureauOrdreNr
        changes = True
      Case dat1.F�llesBureauOrdreNr <> dat2.F�llesBureauOrdreNr
        changes = True
        '     Case dat1.WebTill�gOpkr�ves <> dat2.WebTill�gOpkr�ves
        '      If dat1.Indryknings�r > 2010 Then changes = True
      Case dat1.Milj�Till�gOpkr�ves <> dat2.Milj�Till�gOpkr�ves
        changes = True
      Case dat1.Opkr�vJyskeMilj�Till�g <> dat2.Opkr�vJyskeMilj�Till�g
        changes = True
      Case dat1.Opkr�vFynskeMilj�Till�g <> dat2.Opkr�vFynskeMilj�Till�g
        changes = True
      Case dat1.Opkr�vNorthMilj�Till�g <> dat2.Opkr�vNorthMilj�Till�g
        changes = True
      Case dat1.Opkr�vDSVPMilj�Till�g <> dat2.Opkr�vDSVPMilj�Till�g
        changes = True
      Case dat1.Opkr�vJyskeMedierASTill�g <> dat2.Opkr�vJyskeMedierASTill�g
        changes = True
      Case dat1.Opkr�vHelsing�rMilj�Till�g <> dat2.Opkr�vHelsing�rMilj�Till�g
        changes = True
    End Select
    Return changes
  End Operator
End Class
