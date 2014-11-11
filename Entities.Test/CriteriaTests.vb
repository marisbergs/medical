﻿'The following code was generated by Microsoft Visual Studio 2005.
'The test owner should check each test for validity.
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Core.Dal.Expressions
Imports Core.Bll






<TestClass()> _
Public Class CriteriaTests


    Private testContextInstance As TestContext

    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
        End Set
    End Property

    Private Class TestClass
        Private _theString As String = "AbCdEfGh"
        Private _theInteger As Nullable(Of Integer) = 5
        Private _theDate As Nullable(Of Date) = New Date(2003, 11, 17)
        Private _theObject As Object = Nothing

        Public Property TheString() As String
            Get
                Return _theString
            End Get
            Set(ByVal value As String)
                _theString = value
            End Set
        End Property

        Public Property TheInteger() As Nullable(Of Integer)
            Get
                Return _theInteger
            End Get
            Set(ByVal value As Nullable(Of Integer))
                _theInteger = value
            End Set
        End Property

        Public Property TheDate() As Nullable(Of Date)
            Get
                Return _theDate
            End Get
            Set(ByVal value As Nullable(Of Date))
                _theDate = value
            End Set
        End Property

        Public Property TheObject() As Object
            Get
                Return _theObject
            End Get
            Set(ByVal value As Object)
                _theObject = value
            End Set
        End Property
    End Class

    <TestMethod()> _
    Public Sub IsNullTest()
        Dim obj As TestClass = New TestClass()
        Dim target As IsNull = New IsNull("TheString")
        Assert.AreEqual(False, target.EvaluateFor(obj), "String")
        obj.TheString = Nothing
        Assert.AreEqual(True, target.EvaluateFor(obj), "null")
        obj.TheString = ""
        Assert.AreEqual(True, target.EvaluateFor(obj), "Empty String")

        target = New IsNull("TheInteger")
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer")
        obj.TheInteger = Nothing
        Assert.AreEqual(True, target.EvaluateFor(obj), "Null Integer")
        obj.TheInteger = 0
        Assert.AreEqual(False, target.EvaluateFor(obj), "0")

        target = New IsNull("TheDate")
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date")
        obj.TheDate = Nothing
        Assert.AreEqual(True, target.EvaluateFor(obj), "null Date")

        target = New IsNull("TheObject")
        Assert.AreEqual(True, target.EvaluateFor(obj), "null Object")
        obj.TheObject = obj
        Assert.AreEqual(False, target.EvaluateFor(obj), "Object")
    End Sub

    <TestMethod()> _
    Public Sub NotTest()
        Dim obj As TestClass = New TestClass()
        Dim target As [Not] = New [Not](New IsNull("TheString"))
        Assert.AreEqual(True, target.EvaluateFor(obj), "Not False")
        obj.TheString = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not True")
    End Sub

    <TestMethod()> _
    Public Sub AndTest()
        Dim obj As TestClass = New TestClass()
        Dim lhs As CriterionBase = New IsNull("TheString")
        Dim rhs As CriterionBase = New IsNull("TheDate")
        Dim target As [And] = New [And](lhs, rhs)
        Assert.AreEqual(False, target.EvaluateFor(obj), "False And False")
        obj.TheString = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "True And False")
        obj.TheDate = Nothing
        Assert.AreEqual(True, target.EvaluateFor(obj), "True And True")
        obj.TheString = "Not Null"
        Assert.AreEqual(False, target.EvaluateFor(obj), "False And True")
    End Sub

    <TestMethod()> _
    Public Sub OrTest()
        Dim obj As TestClass = New TestClass()
        Dim lhs As CriterionBase = New IsNull("TheString")
        Dim rhs As CriterionBase = New IsNull("TheDate")
        Dim target As [Or] = New [Or](lhs, rhs)
        Assert.AreEqual(False, target.EvaluateFor(obj), "False Or False")
        obj.TheString = Nothing
        Assert.AreEqual(True, target.EvaluateFor(obj), "True Or False")
        obj.TheDate = Nothing
        Assert.AreEqual(True, target.EvaluateFor(obj), "True Or True")
        obj.TheString = "Not Null"
        Assert.AreEqual(True, target.EvaluateFor(obj), "False Or True")
    End Sub

    <TestMethod()> _
    Public Sub EqTest()
        Dim obj As TestClass = New TestClass()
        Dim target As Eq = New Eq("TheString", obj.TheString)
        Assert.AreEqual(True, target.EvaluateFor(obj), "String == String")
        obj.TheString = obj.TheString.ToUpper()
        Assert.AreEqual(False, target.EvaluateFor(obj), "String != STRING")
        obj.TheString = "A"
        Assert.AreEqual(False, target.EvaluateFor(obj), "String != A")
        obj.TheString = ""
        Assert.AreEqual(False, target.EvaluateFor(obj), "String != ''")
        obj.TheString = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "String != null")
        target = New Eq("TheString", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null String != null")
        obj.TheString = ""
        Assert.AreEqual(False, target.EvaluateFor(obj), "null String != ''")
        obj.TheString = "String"
        Assert.AreEqual(False, target.EvaluateFor(obj), "null String != String")

        target = New Eq("TheInteger", obj.TheInteger)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer == Integer")
        obj.TheInteger = obj.TheInteger.Value + 1
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer != Integer + 1")
        obj.TheInteger = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer != null")
        target = New Eq("TheInteger", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Integer != null")
        obj.TheInteger = 0
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Integer != 0")
        obj.TheInteger = 5
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Integer != Integer")
        target = New Eq("TheInteger", obj.TheInteger.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer.Value == Integer")

        target = New Eq("TheDate", obj.TheDate)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date == Date")
        obj.TheDate = DateAdd(DateInterval.Second, 1, obj.TheDate.Value)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date != Date + 1 second")
        obj.TheDate = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date != null")
        target = New Eq("TheDate", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Date != null")
        obj.TheDate = Date.Now
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Date != Date")
        target = New Eq("TheDate", obj.TheDate.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date.Value == Date")

        obj.TheObject = obj
        target = New Eq("TheObject", obj.TheObject)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Object == Object")
        obj.TheObject = target
        Assert.AreEqual(False, target.EvaluateFor(obj), "Object != AnotherObject")
        obj.TheObject = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Object != null")
        target = New Eq("TheObject", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Object != null")
        obj.TheObject = obj
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Object != Object")
    End Sub

    <TestMethod()> _
    Public Sub NotEqTest()
        Dim obj As TestClass = New TestClass()
        Dim target As NotEq = New NotEq("TheString", obj.TheString)
        Assert.AreEqual(False, target.EvaluateFor(obj), "String == String")
        obj.TheString = obj.TheString.ToUpper()
        Assert.AreEqual(True, target.EvaluateFor(obj), "String != STRING")
        obj.TheString = "A"
        Assert.AreEqual(True, target.EvaluateFor(obj), "String != A")
        obj.TheString = ""
        Assert.AreEqual(True, target.EvaluateFor(obj), "String != ''")
        obj.TheString = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "String != null")
        target = New NotEq("TheString", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null String != null")
        obj.TheString = ""
        Assert.AreEqual(False, target.EvaluateFor(obj), "null String != ''")
        obj.TheString = "String"
        Assert.AreEqual(False, target.EvaluateFor(obj), "null String != String")

        target = New NotEq("TheInteger", obj.TheInteger)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer == Integer")
        obj.TheInteger = obj.TheInteger.Value + 1
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer != Integer + 1")
        obj.TheInteger = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer != null")
        target = New NotEq("TheInteger", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Integer != null")
        obj.TheInteger = 0
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Integer != 0")
        obj.TheInteger = 5
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Integer != Integer")
        target = New NotEq("TheInteger", obj.TheInteger.Value + 1)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer.Value+1 == Integer")

        target = New NotEq("TheDate", obj.TheDate)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date == Date")
        obj.TheDate = DateAdd(DateInterval.Second, 1, obj.TheDate.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date != Date + 1 second")
        obj.TheDate = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date != null")
        target = New NotEq("TheDate", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Date != null")
        obj.TheDate = Date.Now
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Date != Date")
        target = New NotEq("TheDate", DateAdd(DateInterval.Second, 1, obj.TheDate.Value))
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date.Value+1 == Date")

        obj.TheObject = obj
        target = New NotEq("TheObject", obj.TheObject)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Object == Object")
        obj.TheObject = target
        Assert.AreEqual(True, target.EvaluateFor(obj), "Object != AnotherObject")
        obj.TheObject = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Object != null")
        target = New NotEq("TheObject", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Object != null")
        obj.TheObject = obj
        Assert.AreEqual(False, target.EvaluateFor(obj), "null Object != Object")
    End Sub

    <TestMethod()> _
    Public Sub GeTest()
        Dim obj As TestClass = New TestClass()
        Dim target As Ge = New Ge("TheString", obj.TheString)
        Assert.AreEqual(True, target.EvaluateFor(obj), "String >= String")
        obj.TheString = obj.TheString.ToUpper()
        Assert.AreEqual(True, target.EvaluateFor(obj), "STRING >= String")
        obj.TheString = obj.TheString.ToLower()
        Assert.AreEqual(False, target.EvaluateFor(obj), "string !>= String")
        obj.TheString = ""
        Assert.AreEqual(False, target.EvaluateFor(obj), "'' !>= String")
        obj.TheString = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !>= String ")
        target = New Ge("TheString", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !>= null String")
        obj.TheString = ""
        Assert.AreEqual(False, target.EvaluateFor(obj), "'' !>= null String")
        obj.TheString = "String"
        Assert.AreEqual(False, target.EvaluateFor(obj), "String !>= null String")

        target = New Ge("TheInteger", obj.TheInteger)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer >= Integer")
        obj.TheInteger = obj.TheInteger.Value + 1
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer+1 >= Integer")
        obj.TheInteger = obj.TheInteger.Value - 2
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer-1 !>= Integer")
        obj.TheInteger = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !>= Integer")
        target = New Ge("TheInteger", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !>= null Integer")
        obj.TheInteger = 0
        Assert.AreEqual(False, target.EvaluateFor(obj), "0 !>= null Integer")
        obj.TheInteger = 5
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer !>= null Integer")
        target = New Ge("TheInteger", obj.TheInteger.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer >= Integer.Value")

        target = New Ge("TheDate", obj.TheDate)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date >= Date")
        obj.TheDate = DateAdd(DateInterval.Second, 1, obj.TheDate.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date + 1s >= Date")
        obj.TheDate = DateAdd(DateInterval.Second, -2, obj.TheDate.Value)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date - 1s !>= Date")
        obj.TheDate = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !>= Date")
        target = New Ge("TheDate", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !>= null Date")
        obj.TheDate = Date.Now
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date !>= null Date")
        target = New Ge("TheDate", obj.TheDate.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date >= Date.Value")

        obj.TheObject = obj
        target = New Ge("TheObject", obj.TheObject)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not IComparable")
        obj.TheObject = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not IComparable")
        target = New Ge("TheObject", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not IComparable")
        obj.TheObject = obj
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not IComparable")
    End Sub

    <TestMethod()> _
    Public Sub LeTest()
        Dim obj As TestClass = New TestClass()
        Dim target As Le = New Le("TheString", obj.TheString)
        Assert.AreEqual(True, target.EvaluateFor(obj), "String <= String")
        obj.TheString = obj.TheString.ToUpper()
        Assert.AreEqual(False, target.EvaluateFor(obj), "STRING !<= String")
        obj.TheString = obj.TheString.ToLower()
        Assert.AreEqual(True, target.EvaluateFor(obj), "string <= String")
        obj.TheString = ""
        Assert.AreEqual(True, target.EvaluateFor(obj), "'' <= String")
        obj.TheString = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !<= String ")
        target = New Le("TheString", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !<= null String")
        obj.TheString = ""
        Assert.AreEqual(False, target.EvaluateFor(obj), "'' !<= null String")
        obj.TheString = "String"
        Assert.AreEqual(False, target.EvaluateFor(obj), "String !<= null String")

        target = New Le("TheInteger", obj.TheInteger)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer <= Integer")
        obj.TheInteger = obj.TheInteger.Value + 1
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer+1 !<= Integer")
        obj.TheInteger = obj.TheInteger.Value - 2
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer-1 <= Integer")
        obj.TheInteger = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !<= Integer")
        target = New Le("TheInteger", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !<= null Integer")
        obj.TheInteger = 0
        Assert.AreEqual(False, target.EvaluateFor(obj), "0 !<= null Integer")
        obj.TheInteger = 5
        Assert.AreEqual(False, target.EvaluateFor(obj), "Integer !<= null Integer")
        target = New Le("TheInteger", obj.TheInteger.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Integer <= Integer.Value")

        target = New Le("TheDate", obj.TheDate)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date <= Date")
        obj.TheDate = DateAdd(DateInterval.Second, 1, obj.TheDate.Value)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date + 1s !<= Date")
        obj.TheDate = DateAdd(DateInterval.Second, -2, obj.TheDate.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date - 1s <= Date")
        obj.TheDate = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !<= Date")
        target = New Le("TheDate", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !<= null Date")
        obj.TheDate = Date.Now
        Assert.AreEqual(False, target.EvaluateFor(obj), "Date !<= null Date")
        target = New Le("TheDate", obj.TheDate.Value)
        Assert.AreEqual(True, target.EvaluateFor(obj), "Date <= Date.Value")

        obj.TheObject = obj
        target = New Le("TheObject", obj.TheObject)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not IComparable")
        obj.TheObject = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not IComparable")
        target = New Le("TheObject", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not IComparable")
        obj.TheObject = obj
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not IComparable")
    End Sub

    <TestMethod()> _
    Public Sub BetweenTest()
        Dim obj As TestClass = New TestClass()
        Dim target As Between = New Between("TheString", obj.TheString, obj.TheString)
        Assert.AreEqual(True, target.EvaluateFor(obj), "String BETWEEN String AND String")
        obj.TheString = obj.TheString.ToUpper()
        Assert.AreEqual(False, target.EvaluateFor(obj), "STRING !BETWEEN String AND String")
        obj.TheString = obj.TheString.ToLower()
        Assert.AreEqual(False, target.EvaluateFor(obj), "string !BETWEEN String AND String")
        obj.TheString = ""
        Assert.AreEqual(False, target.EvaluateFor(obj), "'' !BETWEEN String AND String")
        obj.TheString = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !BETWEEN String AND String")
        target = New Between("TheString", "", "")
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !BETWEEN '' AND ''")
        obj.TheString = ""
        Assert.AreEqual(True, target.EvaluateFor(obj), "'' BETWEEN '' AND ''")
        obj.TheString = "TheString"
        Assert.AreEqual(False, target.EvaluateFor(obj), "String !BETWEEN '' AND ''")
    End Sub

    <TestMethod()> _
    Public Sub LikeTest()
        Dim obj As TestClass = New TestClass()
        Dim target As [Like] = New [Like]("TheString", "")
        Assert.AreEqual(False, target.EvaluateFor(obj), "String !LIKE ''")
        obj.TheString = ""
        Assert.AreEqual(True, target.EvaluateFor(obj), "'' LIKE ''")
        target = New [Like]("TheString", "%")
        Assert.AreEqual(True, target.EvaluateFor(obj), "'' LIKE %")
        obj.TheString = "123"
        Assert.AreEqual(True, target.EvaluateFor(obj), "123 LIKE %")
        obj.TheString = Nothing
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !LIKE %")
        target = New [Like]("TheString", Nothing)
        Assert.AreEqual(False, target.EvaluateFor(obj), "null !LIKE null")
        obj.TheString = "123"
        Assert.AreEqual(False, target.EvaluateFor(obj), "123 !LIKE null")
        obj.TheString = ""
        Assert.AreEqual(False, target.EvaluateFor(obj), "'' !LIKE null")
        target = New [Like]("TheString", "aBc")
        obj.TheString = "aBcD"
        Assert.AreEqual(False, target.EvaluateFor(obj), "aBcD !LIKE aBc")
        obj.TheString = "aBc"
        Assert.AreEqual(True, target.EvaluateFor(obj), "aBc LIKE aBc")
        obj.TheString = "AbC"
        Assert.AreEqual(True, target.EvaluateFor(obj), "AbC LIKE aBc")
        target = New [Like]("TheString", "%aBc")
        Assert.AreEqual(True, target.EvaluateFor(obj), "AbC LIKE %aBc")
        target = New [Like]("TheString", "aBc%")
        Assert.AreEqual(True, target.EvaluateFor(obj), "AbC LIKE aBc%")
        target = New [Like]("TheString", "aB%")
        Assert.AreEqual(True, target.EvaluateFor(obj), "AbC LIKE aB%")
        target = New [Like]("TheString", "%Bc")
        Assert.AreEqual(True, target.EvaluateFor(obj), "AbC LIKE %Bc")
        target = New [Like]("TheString", "%B%")
        Assert.AreEqual(True, target.EvaluateFor(obj), "AbC LIKE %B%")

        target = New [Like]("TheInteger", "%")
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not a String")

        target = New [Like]("TheDate", "%")
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not a String")

        target = New [Like]("TheObject", "%")
        obj.TheObject = obj
        Assert.AreEqual(False, target.EvaluateFor(obj), "Not a String")
        obj.TheObject = obj.TheString
        Assert.AreEqual(True, target.EvaluateFor(obj), "Object is String")
    End Sub

    <TestMethod()> _
    Public Sub InTest()
        Dim obj As TestClass = New TestClass()
        Dim target As [In] = New [In]("TheString", obj.TheString, obj.TheString)
        Assert.IsTrue(target.EvaluateFor(obj), "String IN (String, String)")
        obj.TheString = "A"
        Assert.IsFalse(target.EvaluateFor(obj), "A  !IN (String, String)")
        obj.TheString = Nothing
        Assert.IsFalse(target.EvaluateFor(obj), "null !IN (String, String)")
        target = New [In]("TheString")
        Assert.IsFalse(target.EvaluateFor(obj), "TheString !IN ()")
        obj.TheObject = obj
        target = New [In]("TheObject", obj.TheObject, obj.TheString)
        Assert.IsTrue(target.EvaluateFor(obj), "TheObject IN (TheObject, TheString)")
    End Sub

    <TestMethod()> _
    Public Sub DeepPathTestWithoutCollection()
        Dim obj As New TestClass()
        Dim childObj As New TestClass()

        childObj.TheString = "I am the child"
        obj.TheObject = childObj

        Dim target As [Like] = New [Like]("TheObject.TheString", "%child")

        Assert.IsTrue(target.EvaluateFor(obj), "Find deep object")
        Assert.IsFalse(target.EvaluateFor(childObj), "Path does not exist")
    End Sub

    <TestMethod()> _
    <Ignore()> _
    Public Sub DeepPathTestWithCollection()
        Dim obj As New TestClass()
        Dim childObj As New TestClass()
        Dim childCollection As New List(Of TestClass)

        childObj.TheString = "I am the child"
        childCollection.Add(childObj)
        obj.TheObject = childCollection

        Dim target As [Like] = New [Like]("TheObject.TheObject.TheString", "%child")

        Assert.IsTrue(target.EvaluateFor(obj), "Find deep object")
        Assert.IsFalse(target.EvaluateFor(childObj), "Path does not exist")
    End Sub

End Class