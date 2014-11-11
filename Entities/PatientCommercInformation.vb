Imports core
Imports Core.Dal
Imports Core.Bll
Imports System.IO
Imports System.Windows.Forms
Imports System

Public Class PatientCommercInformation
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Private _patient As Patient
    Private _name As String
    Private _givDate As Nullable(Of DateTime)
    Private _user As User
    Private _notes As String

    Protected Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub
    Private Sub BusinessRule()
        Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
    End Sub

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
        End Set
    End Property

    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property

    Public Overridable Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            Assign("User", value, _user)
        End Set
    End Property

    Public Overridable Property GivDate() As Nullable(Of DateTime)
        Get
            Return _givDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("GivDate", value, _givDate)
        End Set
    End Property

    Public Overridable Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal value As String)
            Assign("Notes", value, _notes)
        End Set
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.Patient
        End Get
        Set(ByVal value As Object)
            Me.Patient = CType(value, Patient)
        End Set
    End Property
End Class
