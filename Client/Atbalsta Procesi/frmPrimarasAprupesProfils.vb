Imports Core.UI
Imports Core
Imports Core.Bll
Imports Core.Dal
Imports Entities

Public Class frmPrimarasAprupesProfils
    Implements IEditForm

    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private _profileDescription As ProfileDescription

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(ProfileDescription)) = Guid.Empty Then 'add new
                _profileDescription = New ProfileDescription(Session)
            Else 'edit existing User
                _profileDescription = Session.Get(Of ProfileDescription)(value(GetType(ProfileDescription)))
            End If
            bndProfileDescription.DataSource = _profileDescription
            bndProfileDescriptioDiscountServices.DataSource = _profileDescription.DiscountService
            bndProfileDescriptionFreeServices.DataSource = _profileDescription.FreeService
            gbhFreeServices.ShowActive = True
            GridButtonHelper1.ShowActive = True
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

    Private Sub gbhFreeServices_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhFreeServices.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                Dim itm As ProfileDescriptionService
                itm = New ProfileDescriptionService(Session)
                itm.Service = x
                itm.FreeGroup = True
                _profileDescription.FreeService.Add(itm)
            Next
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not _profileDescription.IsValid Then
            Core.UI.MsgBox.Show("Pirms saglabāšanas aizpildiet visus obligātos laukus")
            Return
        End If
        Dim jauns As Boolean = _profileDescription.Id = Guid.Empty
        Session.SaveOrUpdate(_profileDescription)
        Session.Commit()
        If jauns Then
            DataList.Add(PartnerSession.Get(Of ProfileDescription)(_profileDescription.Id))
        End If
    End Sub

    Private Sub txtFreeServices_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFreeServices.ButtonClick
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.SingleSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseIsPresentCard", True))

        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Dim card As PresentCard = CType(bndProfileDescriptionFreeServices.Current, PresentCard)
            'card.Service = CType(frm.Selection, Services)
            'card.Price = card.Service.DecimalValue
        End If
    End Sub

    Private Sub GridButtonHelper1_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles GridButtonHelper1.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                Dim itm As ProfileDescriptionService
                itm = New ProfileDescriptionService(Session)
                itm.Service = x
                itm.FreeGroup = False
                _profileDescription.DiscountService.Add(itm)
            Next
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
