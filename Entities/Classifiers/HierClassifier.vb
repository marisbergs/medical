Imports Core.Dal

Public Class HierClassifier
    Inherits Classifier


    Protected _parents As HierClassifier
    Private _children As IChildCollection(Of HierClassifier)
    Private _firstRecord As Boolean = False
    ''Private _code As String

    Public Overridable Property Parents() As HierClassifier
        Get
            Return _parents
        End Get
        Set(ByVal value As HierClassifier)
            Assign("Parents", value, _parents)
        End Set
    End Property


    Public Overridable Property Children() As IChildCollection(Of HierClassifier)
        Get
            Return _children
        End Get
        Set(ByVal value As IChildCollection(Of HierClassifier))
            _children = value
            If Not (value Is Nothing) Then
                _children.Parent = Me
            End If
        End Set
    End Property

    Public Overridable Property FirstRecord() As Boolean
        Get
            Return _firstRecord
        End Get
        Set(ByVal value As Boolean)
            _firstRecord = value
        End Set
    End Property

    Public Overridable ReadOnly Property ShowMode() As String
        Get
            Dim _classifType As ClassifierType = ClassifierType.FromType(Me.GetType, Core.Dal.Manager.Instance.OpenSession())
            If _classifType.CommentPrompt Is Nothing Then
                Return BaseValue()
            Else
                If Comment Is Nothing Then
                    Return BaseValue()
                Else
                    Return BaseValue() & " (" & Comment & ")"
                End If
            End If
        End Get
    End Property

    Private Function BaseValue() As String
        If Me.ValidFrom.HasValue AndAlso Me.ValidUntil.HasValue Then
            Return Me.ToString() & " (" & Me.ValidFrom.Value.ToShortDateString() & " - " & Me.ValidUntil.Value.ToShortDateString() & ")"
        ElseIf Me.ValidFrom.HasValue AndAlso Not Me.ValidUntil.HasValue Then
            Return Me.ToString() & " (" & Me.ValidFrom.Value.ToShortDateString() & " - )"
        ElseIf Not Me.ValidFrom.HasValue AndAlso Not Me.ValidUntil.HasValue Then
            Return Me.ToString()
        End If
    End Function


    Public Overridable Function GetChildrens(ieraksts As HierClassifier, saraksts As List(Of HierClassifier), _sesija As ISession) As List(Of HierClassifier)
        ieraksts.SetSession(_sesija)
        _sesija.Refresh(ieraksts)
        For Each a As HierClassifier In Children
            If Not saraksts.Contains(a) Then
                saraksts.Add(a)
                a.GetChildrens(a, saraksts, _sesija)
            End If
        Next
        Return saraksts
    End Function


    'public sub 

    'Public Overrides Property Code() As String
    '    Get
    '        Return _code
    '    End Get
    '    Set(ByVal value As String)
    '        Assign("Code", value, _code)
    '    End Set
    'End Property

End Class



''' <summary>
''' Apdrošinātāju klasifikators
''' </summary>
''' <remarks></remarks>
Public Class Insurance : Inherits HierClassifier

End Class

''' <summary>
''' Diagnozes, ko piesaista klientam
''' </summary>
''' <remarks></remarks>
Public Class Diagnoze : Inherits HierClassifier

End Class

' Уныкоде
