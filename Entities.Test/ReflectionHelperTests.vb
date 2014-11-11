Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System
Imports System.Text
Imports System.Collections.Generic
Imports System.Reflection


Imports Entities



<TestClass()> _
Public Class ReflectionHelperTests

#Region "TestContext"

    Private testContextInstance As TestContext

    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
        End Set
    End Property
#End Region
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
    Public Sub LocatePropertyTest()
        Dim actual As PropertyInfo

        Dim t As Type
        Dim propertyName As String
        Dim bindingFlags As BindingFlags = bindingFlags.Public Or bindingFlags.Instance

        t = GetType(HierClassifier)

        propertyName = "Parent"
        actual = Core.ReflectionHelper.LocateProperty(t, propertyName, bindingFlags)
        Assert.IsNotNull(actual, "1st level")

        propertyName = "Code"
        actual = Core.ReflectionHelper.LocateProperty(t, propertyName, bindingFlags)
        Assert.IsNotNull(actual, "2nd level")

        propertyName = "Id"
        actual = Core.ReflectionHelper.LocateProperty(t, propertyName, bindingFlags)
        Assert.IsNotNull(actual, "3rd level")

    End Sub

End Class
