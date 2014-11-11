Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class SMSSendingList
    Inherits BusinessObjectBase(Of Guid)

#Region "Private members"
    Private _patient As Patient
    Private _sendTime As DateTime
    Private _message As String
    Private _sended As SmsSendStatus
    Private _response As String
    Private _sMSSesion As String
#End Region


#Region "Property"

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
        End Set
    End Property

    Public Overridable Property SendTime() As DateTime
        Get
            Return _sendTime
        End Get
        Set(ByVal value As DateTime)
            Assign("SendTime", value, _sendTime)
        End Set
    End Property

    Public Overridable Property Message() As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            Assign("Message", value, _message)
        End Set
    End Property

    Public Overridable Property Sended() As SmsSendStatus
        Get
            Return _sended
        End Get
        Set(ByVal value As SmsSendStatus)
            Assign("Sended", value, _sended)
        End Set
    End Property

    Public Overridable Property Response() As String
        Get
            Return _response
        End Get
        Set(ByVal value As String)
            Assign("Response", value, _response)
        End Set
    End Property

    Public Overridable Property SMSSesion() As String
        Get
            Return _sMSSesion
        End Get
        Set(ByVal value As String)
            Assign("SMSSesion", value, _sMSSesion)
        End Set
    End Property
#End Region
End Class
