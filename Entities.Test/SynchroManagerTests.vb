Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Entities
Imports Core.Dal






<TestClass()> _
Public Class SynchroManagerTests


    Private testContextInstance As TestContext

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
    Public Sub ReplicationMethodTest()
        Using local As ISession = Manager.Instance.OpenSession(ConnectionTarget.Local), central As ISession = Manager.Instance.OpenSession(ConnectionTarget.Central)
            Dim cbf As BinaryFile = central.CreateCriteria(GetType(BinaryFile)).Add(New NHibernate.Expression.EqExpression("Id", New Guid("d2d0c364-9e7d-48ac-8845-97c2011e498a"))).List(Of BinaryFile)()(0)
            NHibernate.NHibernateUtil.Initialize(cbf)
            NHibernate.NHibernateUtil.Initialize(cbf.Content)
            'central.Evict(cbf.Content)
            'central.Evict(cbf)
            central.Close() ' Source session has to be closed. Evict() is not enough... :(
            local.Replicate(cbf.Content, NHibernate.ReplicationMode.Overwrite)
            local.Replicate(cbf, NHibernate.ReplicationMode.Overwrite)
            ' SaveCopy(local, cbf.Content, cbf.Content.Id)
            'SaveCopy(local, cbf, cbf.Id)
            Using tx As NHibernate.ITransaction = local.BeginTransaction()
                local.Flush()

                local.Clear()

                Dim bf As BinaryFile = local.Get(Of BinaryFile)(New Guid("d2d0c364-9e7d-48ac-8845-97c2011e498a"))
                Assert.IsNotNull(bf)
                Assert.AreEqual(bf.Content.Id, New Guid("3045e0c2-6cb2-4a5f-a275-97c2011e498a"))
                Dim bc As BinaryContent = local.Get(Of BinaryContent)(New Guid("3045e0c2-6cb2-4a5f-a275-97c2011e498a"))
                Assert.IsNotNull(bc)

                tx.Rollback()
            End Using
        End Using
    End Sub

    <TestMethod()> _
    Public Sub CollectChangedItemsTest()
        Dim items As New System.Collections.Queue()
        Using central As ISession = Manager.Instance.OpenSession(ConnectionTarget.Central)
            Dim target As Template = central.Get(Of Template)(New Guid("03469c52-bd1b-4f13-b5ba-981e00cd7545"))
            Dim lists As New System.Collections.ArrayList
            target.CollectChangedItems(items, New Core.Dal.Expressions.IsNotNull("Id"), False, lists)
            CollectionAssert.Contains(items, target)
        End Using
        Using local As ISession = Manager.Instance.OpenSession(ConnectionTarget.Local)
            Dim tx As NHibernate.ITransaction = local.BeginTransaction()
            While items.Count > 0
                Dim obj As Object = items.Dequeue()
                local.Replicate(obj, NHibernate.ReplicationMode.Overwrite)
            End While
            local.Flush()
            tx.Rollback()
        End Using
    End Sub

    Private Class ResolverMock
        Implements IResolver

        Public Function ChooseWorkstationId(ByRef id As Nullable(Of System.Guid)) As Boolean Implements IResolver.ChooseWorkstationId
            If Not id.HasValue Then
                id = New Guid(New String("E"c, 32))
            End If
            Return True
        End Function

        Public Function ConflictingChangesOfObject(ByVal conflict As Object) As Core.Dal.ConflictResolution Implements IResolver.ConflictingChangesOfObject
            Return ConflictResolution.Proceed
        End Function

        Public Function ObsoleteCaseIsDirty(ByVal caseId As Guid) As Core.Dal.ConflictResolution Implements IResolver.ObsoleteCaseIsDirty
            Return ConflictResolution.Abort
        End Function

        Public Function ReportProgress(ByVal message As Object, ByVal ParamArray messageParams() As Object) As Boolean Implements IResolver.ReportProgress
            Return True
        End Function
    End Class

    <TestMethod()> _
    Public Sub SynchronizeTest()

    End Sub

End Class
