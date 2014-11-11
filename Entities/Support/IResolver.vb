''' <summary>
''' Callbacks to resolve synchronization conflicts and other problems
''' </summary>
''' <remarks></remarks>
Public Interface IResolver

    ''' <summary>
    ''' Requests workstation id during the first synchronization or reports workstation id during subsequent synchronizations
    ''' </summary>
    ''' <returns>Workstation id or <c>Guid.Empty</c> if process should be aborted</returns>
    Function ChooseWorkstationId(ByRef id As Nullable(Of Guid)) As Boolean

    ''' <summary>
    ''' Called when an obsolete case that has to be deleted from local workstation contains unsynchronized data
    ''' </summary>
    ''' <param name="caseId">The Id of case that should be deleted</param>
    Function ObsoleteCaseIsDirty(ByVal caseId As Guid) As Core.Dal.ConflictResolution

    ''' <summary>
    ''' Called when version conflict occurred
    ''' </summary>
    ''' <param name="conflict">object in conflict</param>
    Function ConflictingChangesOfObject(ByVal conflict As Object) As Core.Dal.ConflictResolution

    ''' <summary>
    ''' Reports progress and gives an oportunity to interrupt synchronization
    ''' </summary>
    ''' <param name="message">String, Core.Err or Core.Msg</param>
    ''' <param name="messageParams">Message parameters</param>
    ''' <returns><c>True</c> if synchronization should continue</returns>
    Function ReportProgress(ByVal message As Object, ByVal ParamArray messageParams As Object()) As Boolean

End Interface
