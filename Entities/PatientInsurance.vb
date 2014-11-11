Imports core
Imports Core.Dal
Imports Core.Bll
Imports System.IO
Imports System.Windows.Forms
Imports System

Public Class PatientInsurance
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Protected Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
    End Sub

#Region "Private members"
    Private _patient As Patient
    Private _insurance As Insurance
    Private _program As Insurance
    Private _number As String
    Private _validFrom As Nullable(Of DateTime)
    Private _validTo As Nullable(Of DateTime)
#End Region


#Region "Public member"
    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
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

    Public Overridable Property Insurance() As Insurance
        Get
            Return _insurance
        End Get
        Set(ByVal value As Insurance)
            Assign("Insurance", value, _insurance)
        End Set
    End Property

    Public Overridable Property Program() As Insurance
        Get
            Return _program
        End Get
        Set(ByVal value As Insurance)
            Assign("Program", value, _program)
        End Set
    End Property

    Public Overridable Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As String)
            Assign("Number", value, _number)
        End Set
    End Property

    Public Overridable Property ValidFrom() As Nullable(Of DateTime)
        Get
            Return _validFrom
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidFrom", value, _validFrom)
        End Set
    End Property

    Public Overridable Property ValidTo() As Nullable(Of DateTime)
        Get
            Return _validTo
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidTo", value, _validTo)
        End Set
    End Property

#End Region
End Class
