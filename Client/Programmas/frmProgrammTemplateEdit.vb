Imports Entities
Imports Core.UI
Imports Core.Dal
Imports Core.Bll

Public Class frmProgrammTemplateEdit
    Implements IEditForm

    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private _editedObj As ProgrammTemplate

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(ProgrammTemplate)) = Guid.Empty Then 'add new
                _editedObj = New ProgrammTemplate(Session)
            Else 'edit existing User
                _editedObj = Session.Get(Of ProgrammTemplate)(value(GetType(ProgrammTemplate)))
            End If
            bndProgrammTemplate.DataSource = _editedObj
            bndProgrammTemplatePaymentService.DataSource = _editedObj.PaymentServices
            bndProgrammTemplateService.DataSource = _editedObj.Servicves
            gbgPaymentservices.ShowActive = True
            gbhServices.ShowActive = True
        End Set
    End Property

    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As System.Collections.IList)
            _dataList = value
        End Set
    End Property

    Private Sub gbgPaymentservices_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbgPaymentservices.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))

        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As ProgrammTemplateService In _editedObj.PaymentServices.ActiveItemsWithoutEmpty
            If Not x.Service Is Nothing AndAlso Not obj.Contains(x.Service.Id) Then
                obj.Add(x.Service.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                Dim itm As ProgrammTemplateService
                itm = New ProgrammTemplateService(Session)
                itm.Service = x
                itm.PaymentGroup = True
                _editedObj.PaymentServices.Add(itm)
            Next
        End If
        frm.Dispose()
    End Sub

    Private Sub gbhServices_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhServices.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As ProgrammTemplateService In _editedObj.Servicves.ActiveItemsWithoutEmpty
            If Not x.Service Is Nothing AndAlso Not obj.Contains(x.Service.Id) Then
                obj.Add(x.Service.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                Dim itm As ProgrammTemplateService
                itm = New ProgrammTemplateService(Session)
                itm.Service = x
                itm.PaymentGroup = False
                _editedObj.Servicves.Add(itm)
            Next
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Public Function Save() As Boolean
        If Not _editedObj.IsValid Then
            MsgBox.HasErrorMessage()
            Return False
        End If
        Session.SaveOrUpdate(_editedObj)
        Session.Commit()
        Return True
    End Function
End Class
