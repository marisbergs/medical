Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports Entities

Public Class frmGroupWorkVisitsEdit
    Implements IEditForm

    Private defaultWorktime As WorkTime
    Private _dataList As IList
    Private _list As Entities(Of Visit)


    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(WorkTime)) = Guid.Empty Then 'add new 
                'ir švaki
            Else 'edit existing
                defaultWorktime = Session.Get(Of WorkTime)(value(GetType(WorkTime)))
            End If
            bndGroupWork.DataSource = defaultWorktime
            _list = Entities(Of Visit).GetAll(Session, New Expressions.Eq("ParentId", defaultWorktime.Id))
            bndVisits.DataSource = _list

            gbhVisits.ShowActive = True
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
    Private Sub gbhVisits_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhVisits.OnAddNew
        Dim count As Integer
        For Each x As Visit In _list
            If x.IsActive Then
                count += 1
            End If
        Next
        If count = defaultWorktime.PatientCount.Value Then
            MsgBox.Show("Grupas maksimālais dalībnieku skaits ir sasniegts un vairs nav iespējams pievienot dalībniekus.")
            Return
        End If

        Dim visit As New Visit(Session)
        visit.Doctor = defaultWorktime.User
        visit.Room = defaultWorktime.Room
        visit.StartTime = defaultWorktime.StartTime
        visit.EndTime = defaultWorktime.EndTime
        visit.Service = defaultWorktime.GroupWork
        visit.ParentId = defaultWorktime.Id
        visit.Length = defaultWorktime.Length
        visit.Group = True
        visit.CreatePlace = LocalSettings.GetValueByKey(Session, SystemInformation.ComputerName).Value
        Dim visitservice As New VisitService(Session)
        visitservice.Service = visit.Service
        visitservice.Price = defaultWorktime.Price
        visitservice.DefaultPrice = defaultWorktime.Price
        If Not visit.Service.Reference Is Nothing Then
            visitservice.Percentage = visit.Service.Reference.DecimalValue
        End If
        visit.VisitServices.Add(visitservice)
        _list.Add(visit)
        args.AddedObject = visit
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Function Save() As Boolean
        For Each x As Visit In bndVisits
            If Not x.IsValid Then
                MsgBox.HasErrorMessage()
                Return False
            End If
        Next
        For Each x As Visit In bndVisits
            Session.SaveOrUpdate(x)
        Next
        Session.Commit()
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub txtPatient_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPatient.ButtonClick
        Dim frm As New frmPatients
        frm.canAddNew = True
        frm.Visit = CType(bndVisits.Current, Visit)
        frm.FormMode = ClassifierListMode.SingleSelect

        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If bndVisits.Current Is Nothing Then Return
        Dim frm As New frmVisitEdit()
        frm.Session = Nothing
        frm.PartnerSession = Session
        frm.visit = CType(bndVisits.Current, Visit)
        frm.Tag = CType(bndVisits.Current, Visit)

        frmMain.AddChild(frm)
    End Sub
End Class
