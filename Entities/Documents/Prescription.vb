Imports core
Imports Core.Dal
Imports Core.Bll
Imports System.IO
Imports System.Windows.Forms
Imports System

Public Class Prescription
    Inherits Document

    Private _isueDate As Nullable(Of DateTime)
    Private _diagnosisCode As String
    Private _validTo As Nullable(Of DateTime)

    Private Sub AddBusinessRules()
        'validation
        Validator.AddBusinessRule("IsueDate", AddressOf CommonBusinessRules.CheckRequired, "IsueDate")
        Validator.AddBusinessRule("ValidTo", AddressOf CommonBusinessRules.CheckRequired, "ValidTo")
        Validator.AddBusinessRule("DiagnosisCode", AddressOf CommonBusinessRules.CheckRequired, "DiagnosisCode")
        Validator.AddBusinessRule("Notes", AddressOf CommonBusinessRules.CheckRequired, "Notes")
    End Sub

    Protected Sub New()
        MyBase.New()
        AddBusinessRules()
    End Sub

    Public Sub New(ByVal session As ISession, ByVal _patient As Guid)
        MyBase.New(session)
        AddBusinessRules()
        DocType = New DocumentType(DocumentTypeEnum.Prescription)
        Template = session.Get(Of Template)(Entities.Template.Prescription)
        Patient = session.Get(Of Patient)(_patient)
        IsueDate = DateTime.Now.Date
    End Sub

    Public Overridable Property IsueDate() As Nullable(Of DateTime)
        Get
            Return _isueDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("IsueDate", value, _isueDate)
        End Set
    End Property

    Public Overridable ReadOnly Property IsueDay() As String
        Get
            If IsueDate.HasValue Then
                If IsueDate.Value.Day.ToString.Length = 1 Then
                    Return "0" & IsueDate.Value.Day.ToString
                Else
                    Return IsueDate.Value.Day.ToString
                End If
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property IsueMonth() As String
        Get
            If IsueDate.HasValue Then
                If IsueDate.Value.Month.ToString.Length = 1 Then
                    Return "0" & IsueDate.Value.Month.ToString
                Else
                    Return IsueDate.Value.Month.ToString
                End If
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property IsueYear() As String
        Get
            If IsueDate.HasValue Then
                Return IsueDate.Value.Year.ToString
            End If
        End Get
    End Property

    Public Overridable Property ValidTo() As Nullable(Of DateTime)
        Get
            Return _validTo
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidTo", value, _validTo)
        End Set
    End Property

    Public Overridable ReadOnly Property ValidToDay() As String
        Get
            If ValidTo.HasValue Then
                If ValidTo.Value.Day.ToString.Length = 1 Then
                    Return "0" & ValidTo.Value.Day.ToString
                Else
                    Return ValidTo.Value.Day.ToString
                End If
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property ValidToMonth() As String
        Get
            If ValidTo.HasValue Then
                If ValidTo.Value.Month.ToString.Length = 1 Then
                    Return "0" & ValidTo.Value.Month.ToString
                Else
                    Return ValidTo.Value.Month.ToString
                End If
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property ValidToYear() As String
        Get
            If ValidTo.HasValue Then
                Return ValidTo.Value.Year.ToString
            End If
        End Get
    End Property

    Public Overridable Property DiagnosisCode() As String
        Get
            Return _diagnosisCode
        End Get
        Set(ByVal value As String)
            Assign("DiagnosisCode", value, _diagnosisCode)
        End Set
    End Property

End Class
