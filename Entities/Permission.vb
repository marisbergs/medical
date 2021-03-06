Imports Core

<Serializable()> _
Public Class Permission
    Inherits Core.Bll.BusinessObjectBase(Of String)
    Implements Core.Dal.ISynchronizesSeparately

#Region "Private members"
    Private _mutexGroup As String
    Private _description As String
    Private _centralOnly As Boolean
#End Region

    Public Overridable Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            Assign("Description", value, _description)
        End Set
    End Property

End Class

Public Class CompatiblePermissions
    Inherits Bll.Entities(Of Permission)

    Public Sub New()
        ' Validator.AddBusinessRule("Items", AddressOf CheckForMutexPermissions)
        ' TODO: Look into overriding of collection methods to keep a dynamic list of mutexes and violations
    End Sub

End Class
' Уныкоде