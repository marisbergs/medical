Public Class DatabaseAppender
    Implements Core.ILogger

    Private _session As Core.Dal.ISession

    Private ReadOnly Property AuditSession() As Core.Dal.ISession
        Get
            If (_session Is Nothing) Then
                _session = Core.Dal.Manager.Instance.OpenSession()
            End If
            Return _session
        End Get
    End Property

    Public Sub Log(ByVal session As Core.Dal.ISession, ByVal messageId As System.Guid, ByVal ParamArray parameters() As Object) Implements Core.ILogger.Log
        
    End Sub

    Public Sub LogImmediate(ByVal messageId As System.Guid, ByVal ParamArray parameters() As Object) Implements Core.ILogger.LogImmediate
        Log(AuditSession, messageId, parameters)
        AuditSession.Commit()
    End Sub
End Class
