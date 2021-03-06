Imports Entities
Imports Core.Bll
Imports Core.UI
Imports Core.Dal


Public Class frmLoggingManagement

    Private _currentAuditMessage As AuditMessage
    Private _eLogEntry As Entities(Of LogEntryConfigCurrentUser)
    Private _eLogEntryUser As Entities(Of LogEntryConfigUser)
    Private _eLogEntryRole As Entities(Of LogEntryConfigRole)
    Private _eLogEntryPosition As Entities(Of LogEntryConfigPosition)
    Private _eLogEntryEmail As Entities(Of LogEntryConfigEmail)


    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.bndActivityType.DataSource = Entities(Of AuditMessage).GetAll(Session, New Core.Dal.Expressions.IsNotNull("Parents"))
        Me.bndRole.DataSource = Core.Bll.Entities(Of Role).GetAll(Session, New Core.Dal.Expressions.IsNull("DeleteTime"))
        _currentAuditMessage = bndActivityType.Current

        _eLogEntry = Entities(Of LogEntryConfigCurrentUser).GetAll(Session)
        _eLogEntryUser = Entities(Of LogEntryConfigUser).GetAll(Session)
        _eLogEntryRole = Entities(Of LogEntryConfigRole).GetAll(Session)
        _eLogEntryPosition = Entities(Of LogEntryConfigPosition).GetAll(Session)
        _eLogEntryEmail = Entities(Of LogEntryConfigEmail).GetAll(Session)

        Me.bindLogEntryConfig.DataSource = _eLogEntry
        Me.bindLogEntryConfigUser.DataSource = _eLogEntryUser
        Me.bindLogEntryConfigPosition.DataSource = _eLogEntryPosition
        Me.bindLogEntryConfigRole.DataSource = _eLogEntryRole
        Me.bindLogEntryConfigEmail.DataSource = _eLogEntryEmail

    End Sub

#Region "Private methods"

    Private Function HasError() As Boolean
        'Error validating

        Dim bIsValid As Boolean = False

        If Not CType(Me.bndActivityType.DataSource, Core.Bll.IBusinessObjectBase).IsValid Then bIsValid = True
        If Not CType(Me.bindLogEntryConfig.DataSource, Core.Bll.IBusinessObjectBase).IsValid Then bIsValid = True
        If Not CType(Me.bindLogEntryConfigEmail.DataSource, Core.Bll.IBusinessObjectBase).IsValid Then bIsValid = True
        If Not CType(Me.bindLogEntryConfigPosition.DataSource, Core.Bll.IBusinessObjectBase).IsValid Then bIsValid = True
        If Not CType(Me.bindLogEntryConfigRole.DataSource, Core.Bll.IBusinessObjectBase).IsValid Then bIsValid = True
        If Not CType(Me.bindLogEntryConfigUser.DataSource, Core.Bll.IBusinessObjectBase).IsValid Then bIsValid = True

        Return bIsValid

    End Function

    Private Function _Save() As Boolean

        If Me.HasError Then
            ActivateErrorControls(Me.ErrorProvider1, Me)
            Core.UI.MsgBox.HasErrorMessage()
            Return False
        End If



        If _eLogEntry.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage)).Count > 0 Then
            Dim eLogEntryConfigEmail As Entities(Of LogEntryConfigEmail) = Entities(Of LogEntryConfigEmail).GetAll(Session, New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
            For Each obj As LogEntryConfigEmail In eLogEntryConfigEmail
                If obj.IsActive Then obj.IsUseForSend = _eLogEntry.Item(0).IsUseForSend
            Next

            Dim eLogEntryConfigPosition As Entities(Of LogEntryConfigPosition) = Entities(Of LogEntryConfigPosition).GetAll(Session, New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
            For Each obj As LogEntryConfigPosition In eLogEntryConfigPosition
                If obj.IsActive Then obj.IsUseForSend = _eLogEntry.Item(0).IsUseForSend
            Next

            Dim eLogEntryConfigRole As Entities(Of LogEntryConfigRole) = Entities(Of LogEntryConfigRole).GetAll(Session, New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
            For Each obj As LogEntryConfigRole In eLogEntryConfigRole
                If obj.IsActive Then obj.IsUseForSend = _eLogEntry.Item(0).IsUseForSend
            Next

            Dim eLogEntryConfigUser As Entities(Of LogEntryConfigUser) = Entities(Of LogEntryConfigUser).GetAll(Session, New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
            For Each obj As LogEntryConfigUser In eLogEntryConfigUser
                If obj.IsActive Then obj.IsUseForSend = _eLogEntry.Item(0).IsUseForSend
            Next
        End If



        Try
            Session.Commit()
        Catch ex As Exception
            MsgBox.HasErrorMessage()
            Return False
        End Try

        Return True

    End Function

#End Region

    Private Sub bndActivityType_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bndActivityType.CurrentItemChanged
        If _eLogEntry Is Nothing Or _eLogEntryUser Is Nothing Or _eLogEntryPosition Is Nothing _
        Or _eLogEntryRole Is Nothing Or _eLogEntryEmail Is Nothing Then Return

        _currentAuditMessage = bndActivityType.Current
        Me.bindLogEntryConfig.DataSource = _eLogEntry.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
        Me.bindLogEntryConfigUser.DataSource = _eLogEntryUser.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
        Me.bindLogEntryConfigPosition.DataSource = _eLogEntryPosition.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
        Me.bindLogEntryConfigRole.DataSource = _eLogEntryRole.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
        Me.bindLogEntryConfigEmail.DataSource = _eLogEntryEmail.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))



        Me.gbhEmail.AddNewButton.DataBindings.Clear()
        Me.gbhPosition.AddNewButton.DataBindings.Clear()
        Me.gbhRole.AddNewButton.DataBindings.Clear()
        Me.gbhSystemUser.AddNewButton.DataBindings.Clear()

        If Not Me.bindLogEntryConfig.Current Is Nothing Then

            Me.gbhEmail.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
            Me.gbhPosition.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
            Me.gbhRole.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
            Me.gbhSystemUser.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
        Else

            Me.gbhEmail.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bndActivityType.Current, AuditMessage), "ReturFalse", True))
            Me.gbhPosition.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bndActivityType.Current, AuditMessage), "ReturFalse", True))
            Me.gbhRole.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bndActivityType.Current, AuditMessage), "ReturFalse", True))
            Me.gbhSystemUser.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bndActivityType.Current, AuditMessage), "ReturFalse", True))
        End If


    End Sub

    Private Sub ButtonEditRole_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEditRole.ButtonClick
        If Not Me._currentAuditMessage.CanEdit Then Exit Sub
        Dim frm As Form
        Dim EntityType As System.Type = GetType(Role)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session)
        CType(frm, frmClassifierList).FormMode = ClassifierListMode.SingleSelect

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim editor As DevExpress.XtraEditors.ButtonEdit = CType(sender, DevExpress.XtraEditors.ButtonEdit)
            editor.EditValue = CType(frm, frmClassifierList).Selection
        End If
    End Sub

    Private Sub ButtonEditUser_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEditUser.ButtonClick
        If Not Me._currentAuditMessage.CanEdit Then Exit Sub
        Dim frm As New frmUsers
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.PartnerSession = Session

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim editor As DevExpress.XtraEditors.ButtonEdit = CType(sender, DevExpress.XtraEditors.ButtonEdit)
            editor.EditValue = frm.Selection
            CType(bindLogEntryConfigUser.Current, LogEntryConfigUser).User = frm.Selection
        End If
    End Sub

    Private Sub BuutonEditPosition_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles BuutonEditPosition.ButtonClick
        If Not Me._currentAuditMessage.CanEdit Then Exit Sub
        Dim frm As Form
        Dim EntityType As System.Type = GetType(Position)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session)
        CType(frm, frmClassifierList).FormMode = ClassifierListMode.SingleSelect

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim editor As DevExpress.XtraEditors.ButtonEdit = CType(sender, DevExpress.XtraEditors.ButtonEdit)
            editor.EditValue = CType(frm, frmClassifierList).Selection
        End If
    End Sub

    Private Sub gbhRole_OnAddNew(ByVal sender As Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhRole.OnAddNew
        Dim obj As New LogEntryConfigRole
        obj.ActionId = _currentAuditMessage
        Session.SaveOrUpdate(obj)
        _eLogEntryRole.Add(obj)
        Me.bindLogEntryConfigRole.DataSource = _eLogEntryRole.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
    End Sub

    Private Sub gbhEmail_OnAddNew(ByVal sender As Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhEmail.OnAddNew
        Dim obj As New LogEntryConfigEmail
        obj.ActionId = _currentAuditMessage
        Session.SaveOrUpdate(obj)
        _eLogEntryEmail.Add(obj)
        Me.bindLogEntryConfigEmail.DataSource = _eLogEntryEmail.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
    End Sub

    Private Sub gbhSystemUser_OnAddNew(ByVal sender As Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhSystemUser.OnAddNew
        Dim obj As New LogEntryConfigUser
        obj.ActionId = _currentAuditMessage
        Session.SaveOrUpdate(obj)
        _eLogEntryUser.Add(obj)
        Me.bindLogEntryConfigUser.DataSource = _eLogEntryUser.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
    End Sub

    Private Sub gbhPosition_OnAddNew(ByVal sender As Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhPosition.OnAddNew
        Dim obj As New LogEntryConfigPosition
        obj.ActionId = _currentAuditMessage
        Session.SaveOrUpdate(obj)
        _eLogEntryPosition.Add(obj)
        Me.bindLogEntryConfigPosition.DataSource = _eLogEntryPosition.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
    End Sub

    Private Sub frmLoggingManagement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Me._currentAuditMessage.CanEdit Then Exit Sub

        If Me._eLogEntry.IsDirty Or Me._eLogEntryEmail.IsDirty Or Me._eLogEntryPosition.IsDirty Or _
        Me._eLogEntryRole.IsDirty Or Me._eLogEntryUser.IsDirty Or _
       CType(Me.bndActivityType.DataSource, Entities(Of AuditMessage)).IsDirty Then

            Dim result As Windows.Forms.DialogResult = MsgBox.SaveMessage
            If result = Windows.Forms.DialogResult.No Then Exit Sub
            If result = Windows.Forms.DialogResult.Cancel Then e.Cancel = True
            If Not Me._Save Then e.Cancel = True

        End If
    End Sub

    Private Sub frmLoggingManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.gbhEmail.ShowActive = True
        Me.gbhPosition.ShowActive = True
        Me.gbhRole.ShowActive = True
        Me.gbhSystemUser.ShowActive = True

        Me.grdEmail.SetEditMode()
        Me.grdPosition.SetEditMode()
        Me.grdRole.SetEditMode()
        Me.grdSystemUser.SetEditMode()

        If Me.bindLogEntryConfig.Current Is Nothing Then Return

        Me.gbhEmail.AddNewButton.DataBindings.Clear()
        Me.gbhPosition.AddNewButton.DataBindings.Clear()
        Me.gbhRole.AddNewButton.DataBindings.Clear()
        Me.gbhSystemUser.AddNewButton.DataBindings.Clear()

        Me.gbhEmail.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
        Me.gbhPosition.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
        Me.gbhRole.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
        Me.gbhSystemUser.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        _Save()
    End Sub



    Private Sub chkUseForSend_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseForSend.CheckedChanged
        If Me.chkUseForSend.CheckState = CheckState.Checked Then
            If _eLogEntry.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage)).Count = 0 Then
                Dim obj As New LogEntryConfigCurrentUser
                obj.ActionId = _currentAuditMessage
                obj.IsCurrentUser = True
                Session.SaveOrUpdate(obj)
                Session.Commit()
                _eLogEntry.Add(obj)
                Me.bindLogEntryConfig.DataSource = _eLogEntry.FilterItems(New Core.Dal.Expressions.Eq("ActionId", _currentAuditMessage))
                chkUseForSend.Checked = True
            End If
        End If


        If Me.bindLogEntryConfig.Current Is Nothing Then Return

        Me.gbhEmail.AddNewButton.DataBindings.Clear()
        Me.gbhPosition.AddNewButton.DataBindings.Clear()
        Me.gbhRole.AddNewButton.DataBindings.Clear()
        Me.gbhSystemUser.AddNewButton.DataBindings.Clear()


        Me.gbhEmail.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
        Me.gbhPosition.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
        Me.gbhRole.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))
        Me.gbhSystemUser.AddNewButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", CType(Me.bindLogEntryConfig.Current, LogEntryConfigCurrentUser), "CanAddParameters", True))

        Me.bindLogEntryConfigUser.ResetBindings(True)
        Me.bindLogEntryConfigEmail.ResetBindings(True)
        Me.bindLogEntryConfigPosition.ResetBindings(True)
        Me.bindLogEntryConfigRole.ResetBindings(True)

        Me.grdEmail.UpdateReadonlyRowStatus()
        Me.grdPosition.UpdateReadonlyRowStatus()
        Me.grdRole.UpdateReadonlyRowStatus()
        Me.grdSystemUser.UpdateReadonlyRowStatus()
    End Sub
End Class
' Lūdzu, Юникод
