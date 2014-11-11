Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System
Imports System.Text
Imports System.Collections.Generic

Imports Core.Bll
Imports Entities

<TestClass()> _
Public Class HierClassifierTests

    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
        End Set
    End Property
#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region

    <TestMethod()> _
    Public Sub PlaceReadingTest()

        Using session As Core.Dal.ISession = Core.Dal.Manager.Instance.OpenSession(Core.Dal.ConnectionTarget.Central)
            Dim p As Entities(Of Insurance) = Entities(Of Insurance).GetAll(session)





        End Using

    End Sub


End Class
