Imports Microsoft.VisualStudio.TestTools.UnitTesting

Public NotInheritable Class Helper

#Region "Transaction control methods"
    Public Shared Sub StartTransaction()
        ' Enter a new COM+ transaction without inheriting from ServicedComponent
        Dim config As New System.EnterpriseServices.ServiceConfig()
        config.Transaction = System.EnterpriseServices.TransactionOption.RequiresNew
        System.EnterpriseServices.ServiceDomain.Enter(config)
    End Sub

    Public Shared Sub AbortTransaction()
        ' Rollback and leave transactional context
        If System.EnterpriseServices.ContextUtil.IsInTransaction Then
            ' Abort the running transaction
            System.EnterpriseServices.ContextUtil.SetAbort()
        End If
        System.EnterpriseServices.ServiceDomain.Leave()
    End Sub
#End Region

    Public Shared Sub ValidateAndAssertNoErrors(Of T As Core.Bll.IBusinessObjectBase)(ByVal obj As T)
        Assert.IsTrue(obj.IsValid, "No errors were expected")
    End Sub

    Public Shared Sub AssertNoErrors(ByVal validationResult As Core.Result)
        Assert.IsFalse(validationResult.HasErrors, "No errors were expected")
    End Sub

    Public Shared Function ValidateAndAssertErrorsCount(Of T As Core.Bll.IBusinessObjectBase)(ByVal obj As T, ByVal expectedCount As Integer) As Core.Result
        Dim validationResult As Core.Result
        validationResult = obj.Validate()
        Assert.AreEqual(expectedCount, validationResult.Messages.Count, "{0} errors were expected", expectedCount)
        Return validationResult
    End Function

    Public Shared Function ValidateAndAssertPropertyErrorsCount(Of T As Core.Bll.IBusinessObjectBase)(ByVal obj As T, ByVal propertyName As String, ByVal expectedCount As Integer) As Core.Result
        Dim validationResult As Core.Result
        validationResult = obj.ValidateProperty(propertyName)
        Assert.AreEqual(expectedCount, validationResult.Messages.Count, "{0} errors were expected for {1}", expectedCount, propertyName)
        Return validationResult
    End Function

    Public Shared Function AssertExpectedError(ByVal validationResult As Core.Result, ByVal err As Core.Err) As Core.Message
        Assert.IsNotNull(validationResult.Messages)
        Dim code As String
        code = "ERR." + err.ToString()
        For Each m As Core.Message In validationResult.Messages
            If m.Code = code Then Return m
        Next
        Assert.Fail("Error message [{0}] not found.", code)
        Return Nothing
    End Function

    Public Shared Function GenerateString(ByVal fragment As Char, ByVal repeat As Int32) As String
        Dim sb As New System.Text.StringBuilder
        Return sb.Append(fragment, repeat).ToString()
    End Function

    ''' <summary>
    ''' Tests contents of two streams for equality. Testing starts from the current position of both streams.
    ''' </summary>
    ''' <param name="stream1">First stream</param>
    ''' <param name="stream2">Second stream</param>
    ''' <returns>String with the first encountered difference described,
    ''' or empty string if no differences were encountered.</returns>
    ''' <remarks></remarks>
    Public Shared Function CompareStreams(ByVal stream1 As System.IO.Stream, ByVal stream2 As System.IO.Stream) As String
        Dim buf1 As Integer = 0
        Dim buf2 As Integer = 0
        Dim i As Long = 0
        While buf1 <> -1 And buf2 <> -1
            buf1 = stream1.ReadByte()
            buf2 = stream2.ReadByte()
            If buf1 <> buf2 Then
                Return "Byte " & i & " is different: " & buf1 & " vs. " & buf2
            End If
            i = i + 1
        End While
        Return ""
    End Function 'CompareStreams

End Class
