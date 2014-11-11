Imports System.Reflection
Imports Entities
Imports Core.Bll
Imports Core.Dal
Imports Core.UI

Public Class frmUniversalClassifierBase
    Implements ISelectionForm


    Protected _criterion As IList(Of Core.Dal.Expressions.CriterionBase) = New List(Of Core.Dal.Expressions.CriterionBase)
    Protected _mode As ClassifierListMode
    Protected _typeEntity As ClassifierType
    Protected bIsChanged As Boolean = False
    Public Overridable Property FormMode() As ClassifierListMode Implements ISelectionForm.FormMode
        Get
            Return _mode
        End Get
        Set(ByVal value As ClassifierListMode)

        End Set
    End Property
    Public Overridable WriteOnly Property SearchObjectPropertyPresets() As Queue(Of KeyValuePair(Of String, Object)) Implements ISelectionForm.SearchObjectPropertyPresets
        Set(ByVal value As Queue(Of KeyValuePair(Of String, Object)))
            ' Has to be implemented in derived classes
        End Set
    End Property



    Public Sub GenericTrick(Of classifierType As {New, IBusinessObjectBase})()
        
        bndClassifiers.DataSource = Entities(Of classifierType).GetAll(Session, _criterion)
    End Sub
    Public Function GenericTrick1(Of ct As {New, IBusinessObjectBase})() As IList(Of ct)
        Dim source As Entities(Of ct) = CType(bndClassifiers.DataSource, Entities(Of ct))
        Return source.FilterItems(New Expressions.Eq("Selected", True))
    End Function
    Public Overridable Property Selection() As Object Implements ISelectionForm.Selection
        Get
            Select Case _mode
                Case ClassifierListMode.Edit
                    Return Nothing
                Case ClassifierListMode.MultiSelect
                    Dim mi As MethodInfo = Me.GetType().GetMethod("GenericTrick1")
                    mi = mi.MakeGenericMethod(_typeEntity.TypeObject)
                    Return mi.Invoke(Me, Nothing)
                Case ClassifierListMode.SingleSelect
                    Return bndClassifiers.Current
                Case Else
                    Return Nothing
            End Select
        End Get
        Set(ByVal value As Object)
            If Me.FormMode = ClassifierListMode.MultiSelect Then
                If Not value Is Nothing AndAlso Not IsDBNull(value) Then
                    If Not bndClassifiers Is Nothing Then
                        For Each x As Classifier In bndClassifiers.List
                            x.Selected = False
                        Next
                    End If
                    For Each x As Classifier In value
                        If bndClassifiers.Contains(x) Then
                            CType(bndClassifiers.Item(bndClassifiers.IndexOf(x)), Classifier).Selected = True
                        End If
                    Next
                Else
                    If Not bndClassifiers Is Nothing Then
                        For Each x As Classifier In bndClassifiers.List
                            x.Selected = False
                        Next
                    End If
                End If
            Else
                If Not bndClassifiers Is Nothing Then
                    For Each x As Classifier In bndClassifiers.List
                        x.Selected = False
                    Next
                End If
            End If
        End Set
    End Property
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If HasError() Then
            'ActivateErrorControls(Me.ErrorProvider, Me)
            Core.UI.MsgBox.HasErrorMessage()
        Else
            'Me.AcceptChanges()
            For Each x As Object In bndClassifiers.List
                Session.SaveOrUpdate(x)
            Next
            Session.Commit()
            bIsChanged = False
        End If

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Public Function ShowDialog1() As System.Windows.Forms.DialogResult Implements Core.UI.ISelectionForm.ShowDialog
        Return Me.ShowDialog()
    End Function

    Public Function HasError() As Boolean
        For Each i As Classifier In Me.bndClassifiers.List
            If Not i.IsValid AndAlso i.CanEdit Then Return True
        Next
        Return False
    End Function
End Class
' Lūdzu, Юникод