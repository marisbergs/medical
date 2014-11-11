Imports core
Imports Core.Dal
Imports Core.Bll
Imports System.IO
Imports System.Windows.Forms
Imports System

Public Class PatientFamily
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Private _patient As Patient
    Private _patientRelated As Patient
    Private _kindred As Kindred
    Private _groupWork As GroupsWork

    Protected Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub
    Private Sub BusinessRule()
        Validator.AddBusinessRule("PatientRelated", AddressOf CommonBusinessRules.CheckRequired, "PatientRelated")
    End Sub

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
        End Set
    End Property

    Public Overridable Property PatientRelated() As Patient
        Get
            Return _patientRelated
        End Get
        Set(ByVal value As Patient)
            Assign("PatientRelated", value, _patientRelated)
        End Set
    End Property

    Public Overridable ReadOnly Property FullName() As String
        Get
            If Not _patientRelated Is Nothing Then
                Return _patientRelated.FullName
            Else
                Return ""
            End If
        End Get
    End Property

    Public Overridable Property Kindred() As Kindred
        Get
            Return _kindred
        End Get
        Set(ByVal value As Kindred)
            Assign("Kindred", value, _kindred)
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
