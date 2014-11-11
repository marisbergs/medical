Public Enum DocumentTypeEnum
    Prescription
    RtgSummary
    RTG
    USG
    DenticalCard
End Enum


Public Class DocumentType
    Inherits Core.EnumWrapper(Of DocumentTypeEnum)

    Sub New(ByVal value As DocumentTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Receptes</summary>
    Public Shared ReadOnly Prescription As DocumentType = New DocumentType(DocumentTypeEnum.Prescription)
    ''' <summary>RTG izmeklējuma slēdziens</summary>
    Public Shared ReadOnly RtgSummary As DocumentType = New DocumentType(DocumentTypeEnum.RtgSummary)
    ''' <summary>RTG</summary>
    Public Shared ReadOnly RTG As DocumentType = New DocumentType(DocumentTypeEnum.RTG)
    ''' <summary>USG</summary>
    Public Shared ReadOnly USG As DocumentType = New DocumentType(DocumentTypeEnum.USG)
    ''' <summary>USG</summary>
    Public Shared ReadOnly DenticalCard As DocumentType = New DocumentType(DocumentTypeEnum.DenticalCard)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList

            End If
            Return _listHolder
        End Get
    End Property
    Public Overloads Shared ReadOnly Property TIReportListSource() As IList(Of DocumentType)
        Get
            Dim _list As New List(Of DocumentType)
            
            Return _list
        End Get
    End Property
End Class
