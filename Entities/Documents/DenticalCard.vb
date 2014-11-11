
Imports Core.Dal

Public Class DenticalCard
    Inherits Document

    Protected Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal session As ISession, ByVal _patient As Guid)
        MyBase.New(session)
        DocType = New DocumentType(DocumentTypeEnum.DenticalCard)
        Template = session.Get(Of Template)(Entities.Template.DenticalCard)
        Patient = session.Get(Of Patient)(_patient)
    End Sub
End Class
