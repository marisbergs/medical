Public Enum ClassifierKindEnum

    System = 0
    External = 1
    Internal = 2

    NotAClassifier = 99

End Enum

Public Class ClassifierKind
    Inherits Core.EnumWrapper(Of ClassifierKindEnum)

    Protected Sub New()

    End Sub

    Public Sub New(ByVal value As ClassifierKindEnum)
        MyBase.New(value)
    End Sub
End Class
