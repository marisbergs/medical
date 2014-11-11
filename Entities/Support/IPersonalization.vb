Public Interface IPersonalization
    ReadOnly Property Criteria() As System.Collections.Generic.List(Of Core.Dal.Expressions.CriterionBase)
    Sub SetLayout(ByVal _layout As String)
    Sub ReadLayout(ByVal _layout As String)
    Property Personalization() As Entities.Personalization
End Interface
