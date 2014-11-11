Imports Core.Bll
Imports Core.UI
Imports Entities
Imports Core.Dal
Public Class frmRolesManagement

    Private _permissions As Entities(Of Permission)
    Private _roles As Entities(Of Role)
    Private _bIsChanged As Boolean = False
#Region "New&Load"
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        grdPermissions.SetEditMode()
        grdRoles.SetEditMode()
    End Sub
    Private Sub frmRolesManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DesignMode Then Return
        Me.grdRoles.SetEditMode()
        _permissions = Core.Bll.Entities(Of Permission).GetAll(Session)
        bndPermissions.DataSource = _permissions
        _roles = Core.Bll.Entities(Of Entities.Role).GetAll(Session)
        bndRole.DataSource = _roles
        Me.gbhRolePermision.ShowActive = True
    End Sub
#End Region
#Region "Save and close"
    Private Function Save() As Boolean
        If Not _roles.IsValid Then Return False
        For Each r As Role In _roles
            If r.WasJustDeleted Then
                Core.Logger.DB.Log(Session, AuditMessage.RoleDelete, r.Name)
                r.WasJustDeleted = False
            End If
            If r.NameTouched Then
                Core.Logger.DB.Log(Session, AuditMessage.RoleRename, r.OldName, r.Name)
                r.OldName = String.Empty
                r.NameTouched = False
            End If
            If r.PermsChanged Then
                Core.Logger.DB.Log(Session, AuditMessage.RolePermissionsChange, r.Name)
                r.PermsChanged = False
            End If
        Next
        _roles.Save(Session)
        Session.Commit()
        _bIsChanged = False
        Return True
    End Function
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub
    Private Sub frmRolesManagement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _bIsChanged Or _roles.IsDirty Then
            Dim result As Windows.Forms.DialogResult = MsgBox.SaveMessage
            If result = Windows.Forms.DialogResult.No Then Exit Sub
            If result = Windows.Forms.DialogResult.Cancel Then e.Cancel = True
            If Not Save() Then e.Cancel = True
        End If
    End Sub
    'private sub 
#End Region
#Region "Permission list"
    Private Sub bndRole_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndRole.PositionChanged
        PermissionsReload()
        ControlStates()
    End Sub
    Private Sub PermissionsReload()
        Dim rle As Entities.Role = CType(bndRole.Current, Entities.Role)
        For Each p As Permission In _permissions
            p.Selected = rle.Permissions.Contains(p)
        Next
        bndPermissions.ResetBindings(False)
    End Sub
    Private Sub ControlStates()
        Dim selectedRole As Role = CType(bndRole.Current, Role)
        Me.RepositoryItemCheckEdit.ReadOnly = Not selectedRole.CanEdit
        Me.colName.OptionsColumn.ReadOnly = Not selectedRole.CanEdit
    End Sub
#End Region
    Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim selectedRole As Role = CType(bndRole.Current, Role)
        Dim newRole As New Entities.Role(Session)

        newRole.Name = "~" & selectedRole.Name
        For Each p As Permission In selectedRole.Permissions
            newRole.Permissions.Add(p)
        Next
        Session.Save(newRole)
        _roles.Add(newRole)
    End Sub
    Private Sub GridButtonHelper1_OnDelete(ByVal sender As Object, ByVal args As Core.UI.GridButtonHelper.DeleteEventArgs) Handles gbhRolePermision.OnDelete
        args.CancelDelete = True
        Dim result As Windows.Forms.DialogResult = MsgBox.DeleteMessage
        If result = Windows.Forms.DialogResult.Yes Then
            If CType(bndRole.Current, Role).HasUsers Then
                Core.UI.MsgBox.Show(Core.Err.RoleIsBysy, MessageBoxButtons.OK)
            Else
                args.CancelDelete = False
            End If
        End If
    End Sub
    Private Sub gbhRolePermision_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhRolePermision.OnAddNew
        Dim newRole As New Entities.Role(Session)
        'Session.Save(newRole)
        _roles.Add(newRole)
    End Sub
    Private Sub RepositoryItemCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit.CheckedChanged
        Dim role As Role = CType(bndRole.Current, Role)
        Dim permission As Permission = CType(bndPermissions.Current, Permission)
        If Not permission.Selected And Not role.Permissions.Contains(permission) Then
            role.Permissions.Add(permission)
            _bIsChanged = True
            role.PermsChanged = True
        End If
        If permission.Selected Then
            CType(role.Permissions, IList).Remove(permission)
            _bIsChanged = True
            role.PermsChanged = True
        End If
    End Sub
End Class