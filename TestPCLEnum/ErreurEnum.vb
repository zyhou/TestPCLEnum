Imports System.ComponentModel
Imports LibraryClass

Public Enum ErreurEnum

    <EnumDescription("Aucun CE ne correspond aux codes transmis")>
    NotFoundCE = 100

    <EnumDescription("Aucun bénéficiaire ne correspond aux identifiants transmis")>
     NotFoundBenef = 200

    <EnumDescription("Le bénéficiaire ne possède pas de droit actif a la date du jour")>
    NotRightBenef = 210

    <EnumDescription("Le bénéficiaire est en blocage de droit à la date du jour")>
    IsBlockRight = 220

    None = 0

End Enum