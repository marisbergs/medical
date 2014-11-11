Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Collections
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions
Imports Entities

Public Class FindUsers
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements INotifyPropertyChanged
    Implements Core.Bll.ISearchObject

#Region "Private members"
    Private _canUsePosition As Boolean = True
    Private _usePosition As Boolean
    Private _position As IList(Of Position)
    Private _user As IList(Of Guid)
    Private _useNotInUser As Boolean
    Private _useName As Boolean
    Private _name As String
    Private _useLastName As Boolean
    Private _lastName As String
    Private _useIsUser As Boolean = True
    Private _isUser As YesNo = YesNo.Yes
    Private _useLogon As Boolean
    Private _logon As String
    Private _canUseActive As Boolean = True
    Private _useActive As Boolean = True
    Private _useActualUsers As Boolean
    Private _useInUser As Boolean
    Private _userIn As IList(Of Guid)
    Private _useValidAt As Boolean
    Private _validAt As Date
    Private _useDoctor As Boolean
    Private _useSpeciality As Boolean
    Private _useSpecialities As Boolean
    Private _useServices As Boolean
    Private _speciality As IList(Of Guid)
    Private _specialities As IList(Of Speciality)
    Private _services As IList(Of Guid)

#End Region

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
        Validator.AddBusinessRule("Position", AddressOf CommonBusinessRules.CheckConditionalRequired, "UsePosition", "Position")
        Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseName", "Name")
        Validator.AddBusinessRule("LastName", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseLastName", "LastName")
        Validator.AddBusinessRule("IsUser", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseIsUser", "IsUser")
        Validator.AddBusinessRule("Logon", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseLogon", "Logon")
    End Sub


    ''' <summary>
    ''' vai neiekļaut lietotājus atlasē
    ''' </summary>
    Public Overridable Property UseNotInUser() As Boolean
        Get
            Return _useNotInUser
        End Get
        Set(ByVal value As Boolean)
            Assign("UseNotInUser", value, _useNotInUser)
        End Set
    End Property

    ''' <summary>
    ''' vai iekļaut lietotājus atlasē
    ''' </summary>
    Public Overridable Property UseInUser() As Boolean
        Get
            Return _useInUser
        End Get
        Set(ByVal value As Boolean)
            Assign("UseInUser", value, _useInUser)
        End Set
    End Property


    ''' <summary>
    ''' Atlasē neiekļautie lietotāji
    ''' </summary>
    Public Overridable Property User() As IList(Of Guid)
        Get
            Return _user
        End Get
        Set(ByVal value As IList(Of Guid))
            If _user Is Nothing Then _user = New List(Of Guid)
            Assign("User", value, _user)
        End Set
    End Property

    ''' <summary>
    ''' Atlasē iekļautie lietotāji
    ''' </summary>
    Public Overridable Property UserIn() As IList(Of Guid)
        Get
            Return _userIn
        End Get
        Set(ByVal value As IList(Of Guid))
            If _userIn Is Nothing Then _userIn = New List(Of Guid)
            Assign("UserIn", value, _userIn)
        End Set
    End Property


    ''' <summary>
    ''' Atlasē neiekļautie lietotāji
    ''' </summary>
    Public Overridable Property UseSpeciality() As Boolean
        Get
            Return _useSpeciality
        End Get
        Set(ByVal value As Boolean)
            Assign("UseSpeciality", value, _useSpeciality)
        End Set
    End Property


    ''' <summary>
    ''' iekļaut atlases kritērijos specialitāti
    ''' </summary>
    Public Overridable Property UseSpecialities() As Boolean
        Get
            Return _useSpecialities
        End Get
        Set(ByVal value As Boolean)
            Assign("UseSpecialities", value, _useSpecialities)
        End Set
    End Property


    ''' <summary>
    ''' Atlasē neiekļautie lietotāji ar norādīto pakalpojumu
    ''' </summary>
    Public Overridable Property UseServices() As Boolean
        Get
            Return _useServices
        End Get
        Set(ByVal value As Boolean)
            Assign("UseServices", value, _useServices)
        End Set
    End Property

    ''' <summary>
    ''' Atlasē iekļautie lietotāji
    ''' </summary>
    Public Overridable Property Speciality() As IList(Of Guid)
        Get
            Return _speciality
        End Get
        Set(ByVal value As IList(Of Guid))
            Assign("Speciality", value, _speciality)
        End Set
    End Property

    ''' <summary>
    ''' Atlasē iekļautās specialitātes
    ''' </summary>
    Public Overridable Property Specialities() As IList(Of Speciality)
        Get
            Return _specialities
        End Get
        Set(ByVal value As IList(Of Speciality))
            Assign("Specialities", value, _specialities)
        End Set
    End Property

    ''' <summary>
    ''' Atlasē iekļautie lietotāji
    ''' </summary>
    Public Overridable Property Services() As IList(Of Guid)
        Get
            Return _services
        End Get
        Set(ByVal value As IList(Of Guid))
            Assign("Services", value, _services)
        End Set
    End Property


    ''' <summary>
    ''' vai neiekļaut lietotājus atlasē
    ''' </summary>
    Public Overridable Property UseActualUsers() As Boolean
        Get
            Return _useActualUsers
        End Get
        Set(ByVal value As Boolean)
            Assign("UseActualUsers", value, _useActualUsers)
        End Set
    End Property


    ''' <summary>
    ''' iekļaut atlasē tikai ārstus
    ''' </summary>
    Public Overridable Property UseDoctor() As Boolean
        Get
            Return _useDoctor
        End Get
        Set(ByVal value As Boolean)
            Assign("UseDoctor", value, _useDoctor)
        End Set
    End Property

    Public Property CanUsePosition() As Boolean
        Get
            Return _canUsePosition
        End Get
        Set(ByVal value As Boolean)
            Assign("CanUsePosition", value, _canUsePosition)
        End Set
    End Property

    ''' <summary>
    ''' Amats
    ''' </summary>
    Public Overridable Property UsePosition() As Boolean
        Get
            Return _usePosition
        End Get
        Set(ByVal value As Boolean)
            If CanUsePosition Then _
                Assign("UsePosition", value, _usePosition)
        End Set
    End Property

    ''' <summary>
    ''' Amats
    ''' </summary>
    Public Overridable Property Position() As IList(Of Position)
        Get
            Return _position
        End Get
        Set(ByVal value As IList(Of Position))
            If CanUsePosition Then _
                Assign("Position", value, _position)
        End Set
    End Property

    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property UseName() As Boolean
        Get
            UseName = _useName
        End Get
        Set(ByVal value As Boolean)
            Assign("UseName", value, _useName)
        End Set
    End Property

    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property

    ''' <summary>
    ''' Uzvārds
    ''' </summary>
    Public Overridable Property UseLastName() As Boolean
        Get
            UseLastName = _useLastName
        End Get
        Set(ByVal value As Boolean)
            Assign("UseLastName", value, _useLastName)
        End Set
    End Property

    ''' <summary>
    ''' Uzvārds
    ''' </summary>
    Public Overridable Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            Assign("LastName", value, _lastName)
        End Set
    End Property

    ''' <summary>
    ''' Ir sistēmas lietotājs
    ''' </summary>
    Public Overridable Property UseIsUser() As Boolean
        Get
            Return _useIsUser
        End Get
        Set(ByVal value As Boolean)
            Assign("UseIsUser", value, _useIsUser)
        End Set
    End Property

    ''' <summary>
    ''' Ir sistēmas lietotājs
    ''' </summary>
    Public Overridable Property IsUser() As YesNo
        Get
            Return _isUser
        End Get
        Set(ByVal value As YesNo)
            Assign("IsUser", value, _isUser)
        End Set
    End Property

    ''' <summary>
    ''' Lietotāja konts
    ''' </summary>
    Public Overridable Property UseLogon() As Boolean
        Get
            Return _useLogon
        End Get
        Set(ByVal value As Boolean)
            Assign("UseLogon", value, _useLogon)
        End Set
    End Property

    ''' <summary>
    ''' Lietotāja konts
    ''' </summary>
    Public Overridable Property Logon() As String
        Get
            Return _logon
        End Get
        Set(ByVal value As String)
            Assign("Logon", value, _logon)
        End Set
    End Property

    Public Property CanUseActive() As Boolean
        Get
            Return _canUseActive
        End Get
        Set(ByVal value As Boolean)
            Assign("CanUseActive", value, _canUseActive)
        End Set
    End Property

    ''' <summary>
    ''' Tikai aktuālie
    ''' </summary>
    Public Overridable Property UseActive() As Boolean
        Get
            Return _useActive
        End Get
        Set(ByVal value As Boolean)
            If CanUseActive Then _
                Assign("UseActive", value, _useActive)
        End Set
    End Property

    Public Overridable Property UseValidAt() As Boolean
        Get
            Return _useValidAt
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseValidAt", value, _useValidAt)
        End Set
    End Property

    Public Overridable Property ValidAt() As Date
        Get
            Return _validAt
        End Get
        Set(ByVal value As Date)
            Assign("ValidAt", value, _validAt)
        End Set
    End Property

#Region "ISearchObject"
    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of CriterionBase)

        ' TODO: nestrādā atlase pēc VID sr.v. un amata
        'todo: tiešām nestrādā atlase pēc VID srv
        'If Me.UseOrganization Then result.Add(CriteriaBuilder.IsInCollection("Organization", Me._organization))

        If UseNotInUser Then result.Add(CriteriaBuilder.IsNotInCollection("Id", Me.User))
        If UseInUser Then result.Add(CriteriaBuilder.IsInCollection("Id", Me.UserIn))

        If Me.UsePosition Then result.Add(CriteriaBuilder.IsInCollection("Position", Me._position))
        If Me.UseSpecialities Then result.Add(CriteriaBuilder.IsInCollection("UserSpecialities.Speciality", Me._specialities))

        If Me.UseName Then
            Dim exprFName As Expressions.CriterionBase = CriteriaBuilder.MultiValueLike("FirstName", Me._name & "%")
            Dim exprOName As Expressions.CriterionBase = CriteriaBuilder.MultiValueLike("OtherNames", Me._name & "%")
            result.Add(New [Or](exprFName, exprOName))
        End If

        If Me.UseLastName Then result.Add(CriteriaBuilder.MultiValueLike("LastName", Me._lastName & "%"))

        If UseDoctor Then result.Add(New Expressions.Eq("Position.Mark", True))

        If UseSpeciality Then
            result.Add(CriteriaBuilder.IsInCollection("UserSpecialities.Speciality.Id", Speciality))
            result.Add(New Expressions.IsNull("UserSpecialities.DeleteTime"))
        End If

        If UseServices Then
            result.Add(CriteriaBuilder.IsInCollection("UserServices.Service.Id", Services))
            result.Add(New Expressions.IsNull("UserServices.DeleteTime"))
        End If

        If Me.UseIsUser Then
            Dim exprRole As New [IsNull]("Role")
            If IsUser = YesNo.Yes Then
                result.Add(New [Not](exprRole))
            Else
                result.Add(exprRole)
            End If
        End If

        If Me.UseLogon Then result.Add(CriteriaBuilder.MultiValueLike("Logon", Me._logon))

        If Me.UseActive Then result.Add(New [IsNull]("DeleteTime"))
        If Me.UseActualUsers Then result.Add(New Expressions.Or(New Expressions.IsNull("WorkedUntil"), New Expressions.Ge("WorkedUntil", DateTime.Today)))

        If Me.UseValidAt Then result.Add(New Expressions.And(New Expressions.Le("WorksFrom", ValidAt), New Expressions.Or(New Expressions.IsNull("WorkedUntil"), New Expressions.Ge("WorkedUntil", ValidAt))))

        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        If Me.CanUsePosition Then Me.UsePosition = False
        Me.UseName = False
        Me.UseLastName = False
        Me.UseIsUser = False
        Me.UseLogon = False
        If Me.CanUseActive Then Me.UseActive = True
        Me.Position = Nothing
        Me.Name = Nothing
        Me.LastName = Nothing
        Me.IsUser = Nothing
        Me.Logon = Nothing
        Me.UseValidAt = True
        Me.ValidAt = Now()
    End Sub
#End Region

End Class
