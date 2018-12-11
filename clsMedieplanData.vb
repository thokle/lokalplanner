Public Class MedieplanData
  Public AnnoncørNo_ As String = ""
  Public BureauNo_ As String = ""
  Public Format1 As Integer = 1
  Public Format2 As Integer = 100
  Public AntalFarver As Integer = 0
  Public DPKulørID As Integer = 0
  Public PlaceringID As Integer = 1
  Public IndrykningsUge As Integer = 0
  Public IndrykningsÅr As Integer = 0
  Public Overskrift As String = ""
  Public Beskrivelse As String = ""
  Public KontaktPerson As String = ""
  Public KontaktpersonTilhører As Integer = 0
  Public Fakturering As Integer = 0
  Public RekvisitionsNr As String = ""
  Public BilagsBladeTil As Integer = -1
  Public BilagsBladeTilNavn As String = ""
  Public BilagsBladeTilAdresse As String = ""
  Public BilagsBladeTilPostNr As Integer = 0
  Public BilagsBladeAtt As String = ""
  Public MaterialeFølgerFra As Integer = -1
  Public MaterialeFølgerFraLeverandør As String = ""
  Public BrugMaterialeFraUge As Integer = 0
  Public TilladFarveSærRabat As Boolean = False
  Public TilladMmSærRabat As Boolean = False
  Public SammeMateriale As Boolean = True
  Public KunForhandlerBundForskellig As Boolean = True
  Public SammeBureauOrdreNr As Boolean = False
  ' Public WebTillægOpkræves As Boolean = True
  Public MiljøTillægOpkræves As Boolean = True
  Public OpkrævJyskeMiljøTillæg As Boolean = True
  Public OpkrævFynskeMiljøTillæg As Boolean = True
  Public OpkrævNorthMiljøTillæg As Boolean = True
  Public OpkrævDSVPMiljøTillæg As Boolean = True
  Public OpkrævJyskeMedierASTillæg As Boolean = True
  Public OpkrævHelsingørMiljøTillæg As Boolean = True
  Public FællesBureauOrdreNr As String = ""
  Public BemærkningTilAnnoncør As String = ""
  Public BemærkningTilUgeavis As String = ""

  Shared Operator =(ByVal dat1 As MedieplanData, ByVal dat2 As MedieplanData) As Boolean
    Return Not (dat1 <> dat2)
  End Operator

  Shared Operator <>(ByVal dat1 As MedieplanData, ByVal dat2 As MedieplanData) As Boolean
    Dim changes As Boolean = False
    Select Case True
      Case dat1.AnnoncørNO_ <> dat2.AnnoncørNO_
        changes = True
      Case dat1.BureauNO_ <> dat2.BureauNO_
        changes = True
      Case dat1.Format1 <> dat2.Format1
        changes = True
      Case dat1.Format2 <> dat2.Format2
        changes = True
      Case dat1.AntalFarver <> dat2.AntalFarver
        changes = True
      Case dat1.DPKulørID <> dat2.DPKulørID
        changes = True
      Case dat1.PlaceringID <> dat2.PlaceringID
        changes = True
      Case dat1.IndrykningsUge <> dat2.IndrykningsUge
        changes = True
      Case dat1.IndrykningsÅr <> dat2.IndrykningsÅr
        changes = True
      Case dat1.BemærkningTilAnnoncør <> dat2.BemærkningTilAnnoncør
        changes = True
      Case dat1.BemærkningTilUgeavis <> dat2.BemærkningTilUgeavis
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
      Case dat1.MaterialeFølgerFra <> dat2.MaterialeFølgerFra
        changes = True
      Case dat1.MaterialeFølgerFraLeverandør <> dat2.MaterialeFølgerFraLeverandør
        If dat1.MaterialeFølgerFra <> 1 Then changes = True
      Case dat1.BrugMaterialeFraUge <> dat2.BrugMaterialeFraUge
        changes = True
      Case dat1.SammeMateriale <> dat2.SammeMateriale
        changes = True
      Case dat1.KunForhandlerBundForskellig <> dat2.KunForhandlerBundForskellig
        changes = True
      Case dat1.SammeBureauOrdreNr <> dat2.SammeBureauOrdreNr
        changes = True
      Case dat1.FællesBureauOrdreNr <> dat2.FællesBureauOrdreNr
        changes = True
        '     Case dat1.WebTillægOpkræves <> dat2.WebTillægOpkræves
        '      If dat1.IndrykningsÅr > 2010 Then changes = True
      Case dat1.MiljøTillægOpkræves <> dat2.MiljøTillægOpkræves
        changes = True
      Case dat1.OpkrævJyskeMiljøTillæg <> dat2.OpkrævJyskeMiljøTillæg
        changes = True
      Case dat1.OpkrævFynskeMiljøTillæg <> dat2.OpkrævFynskeMiljøTillæg
        changes = True
      Case dat1.OpkrævNorthMiljøTillæg <> dat2.OpkrævNorthMiljøTillæg
        changes = True
      Case dat1.OpkrævDSVPMiljøTillæg <> dat2.OpkrævDSVPMiljøTillæg
        changes = True
      Case dat1.OpkrævJyskeMedierASTillæg <> dat2.OpkrævJyskeMedierASTillæg
        changes = True
      Case dat1.OpkrævHelsingørMiljøTillæg <> dat2.OpkrævHelsingørMiljøTillæg
        changes = True
    End Select
    Return changes
  End Operator
End Class
