Imports Core.Bll

''' <summary>
''' Iedzimtās slimības
''' </summary>
Public Class AnamnesesHereditaryDsesase
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

#Region "Constructor"
    Protected Sub New()

    End Sub

    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
    End Sub
#End Region

#Region "Private members"
    Private _hereditaryDsesase As String
    Private _notes As String
    Private _gynaecology As Gynaecology
#End Region


    ''' <summary>
    ''' Slimība
    ''' </summary>
    Public Overridable Property HereditaryDsesase() As String
        Get
            Return _hereditaryDsesase
        End Get
        Set(ByVal value As String)
            Assign("HereditaryDsesase", value, _hereditaryDsesase)
        End Set
    End Property

    ''' <summary>
    ''' Slimības apraksts
    ''' </summary>
    Public Overridable Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal value As String)
            Assign("Notes", value, _notes)
        End Set
    End Property

    ''' <summary>
    ''' Ginekoloģijas karte
    ''' </summary>
    Public Overridable Property Gynaecology() As Gynaecology
        Get
            Return _gynaecology
        End Get
        Set(ByVal value As Gynaecology)
            Assign("Gynaecology", value, _gynaecology)
        End Set
    End Property

    Public Overridable Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.Gynaecology
        End Get
        Set(ByVal value As Object)
            Me.Gynaecology = CType(value, Gynaecology)
        End Set
    End Property

    ''' <summary>
    ''' Vai drīkst dzēst ierakstu
    ''' </summary>
    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            If Not Me.IsActive Then
                Return False
            End If
            Return True
        End Get
    End Property

    ''' <summary>
    ''' Vai drīkst labot ierakstu
    ''' </summary>
    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides Function ToString() As String
        Return HereditaryDsesase
    End Function
End Class
' Уныкоде