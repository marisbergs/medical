Imports Core.UI
Imports Entities

Public Class frmProgrammPaymentSet
    Implements IEditForm

    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private _subscription As PatientProgrammPayment

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(PatientProgrammPayment)) = Guid.Empty Then 'add new activity
                _subscription = New PatientProgrammPayment(Session, Nothing)
            Else 'edit existing User
                _subscription = Session.Get(Of PatientProgrammPayment)(value(GetType(PatientProgrammPayment)))
            End If
            bndSubscription.DataSource = _subscription
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
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If _subscription.IsValid Then
            Session.SaveOrUpdate(_subscription)
            Session.Commit()
            Close()
        Else
            MsgBox.Show("Pirms saglabāšanas aizpildiet obligāti aizpildāmos laukus.")
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
