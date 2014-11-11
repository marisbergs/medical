Option Strict On
''' <summary>Uzrādītais dokuments</summary>
Public Enum PresentedDocumentEnum
    Passport = 1
    DrivingLicence = 2
    Other = 3
    PassportAccuse = 4
    DrivingLicenceAccuse = 5
    OtherAccuse = 6
End Enum

Public Class PresentedDocument
    Inherits Core.EnumWrapper(Of PresentedDocumentEnum)

    Sub New(ByVal value As PresentedDocumentEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub

    ''' <summary>Pase</summary>
    Public Shared ReadOnly Passport As PresentedDocument = New PresentedDocument(PresentedDocumentEnum.Passport)
    ''' <summary>Vadītāja apliecība</summary>
    Public Shared ReadOnly DrivingLicence As PresentedDocument = New PresentedDocument(PresentedDocumentEnum.DrivingLicence)
    ''' <summary>Cits</summary>
    Public Shared ReadOnly Other As PresentedDocument = New PresentedDocument(PresentedDocumentEnum.Other)
    ''' <summary>Pase(Akuz.)</summary>
    Public Shared ReadOnly PassportAccuse As PresentedDocument = New PresentedDocument(PresentedDocumentEnum.PassportAccuse)
    ''' <summary>Vadītāja apliecība(Akuz.)</summary>
    Public Shared ReadOnly DrivingLicenceAccuse As PresentedDocument = New PresentedDocument(PresentedDocumentEnum.DrivingLicenceAccuse)
    ''' <summary>Cits(Akuz.)</summary>
    Public Shared ReadOnly OtherAccuse As PresentedDocument = New PresentedDocument(PresentedDocumentEnum.OtherAccuse)


    ''' <summary>
    ''' Uzrādīto dokumentu saraksts
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Passport)
                _listHolder.Add(DrivingLicence)
                _listHolder.Add(Other)
            End If
            Return _listHolder
        End Get
    End Property

    ''' <summary>
    ''' Uzrādīto dokumentu saraksts(Akuz.)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSourceAccuse() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(PassportAccuse)
                _listHolder.Add(DrivingLicenceAccuse)
                _listHolder.Add(OtherAccuse)
            End If
            Return _listHolder
        End Get
    End Property
End Class
