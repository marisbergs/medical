Imports Core.Bll
Imports Core.UI
Imports Entities
Imports Core.Dal
Public Class frmClassifierLinkingManagement

    Private _permissions As Entities(Of Permission)
    Private _roles As Entities(Of Role)
    Private _bIsChanged As Boolean = False
    Private mainClassifier As Type
    Private subClassifier As Type
    Private mainClassif As Entities(Of Classifier)
    Private subClassif As Entities(Of Classifier)
#Region "New&Load"
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByVal _mainClassifier As Type, ByVal _subClassifier As Type, ByVal formName As String)
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        grdSubclassifier.SetListMode()
        grdMainClassifier.SetListMode()
        mainClassifier = _mainClassifier
        subClassifier = _subClassifier
        Me.Text = formName
    End Sub
    Private Sub frmClassifierLinkingManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DesignMode Then Return
        Me.grdMainClassifier.SetEditMode()
        bndMainClassifier.DataSource = Classifier.getClassifersByType(mainClassifier, Session)
        bndSubClassifier.DataSource = Classifier.getClassifersByType(subClassifier, Session)
    End Sub
#End Region

#Region "Save and close"
    Private Function Save() As Boolean
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
        If _bIsChanged Then
            Dim result As Windows.Forms.DialogResult = MsgBox.SaveMessage
            If result = Windows.Forms.DialogResult.No Then Exit Sub
            If result = Windows.Forms.DialogResult.Cancel Then e.Cancel = True
            If Not Save() Then e.Cancel = True
        End If
    End Sub
    'private sub 
#End Region

#Region "Permission list"
    Private Sub bndRole_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndMainClassifier.PositionChanged
        PermissionsReload()
        ControlStates()
    End Sub
    Private Sub PermissionsReload()
        If bndSubClassifier.Current Is Nothing Then Exit Sub
        Dim classif As Entities.Classifier = CType(bndMainClassifier.Current, Entities.Classifier)
        Select Case bndSubClassifier.Current.GetType().Name
            Case "Speciality"
                For Each p As Classifier In bndSubClassifier
                    If classif.GetType().Name = "SpecialityGroups" Then
                        p.Selected = CType(classif, SpecialityGroups).Specialities.Contains(p)
                    Else
                        p.Selected = CType(classif, RoomGroups).Specialities.Contains(p)
                    End If
                Next
            Case "Services"
                For Each p As Classifier In bndSubClassifier
                    p.Selected = CType(classif, Speciality).Services.Contains(p)
                Next
            Case "RoomGroups"
                For Each p As Classifier In bndSubClassifier
                    p.Selected = CType(classif, Services).RoomGroup.Contains(p)
                Next
            Case "Statuss"
                For Each p As Classifier In bndSubClassifier
                    p.Selected = CType(classif, Statuss).Status.Contains(p)
                Next
        End Select
        bndSubClassifier.ResetBindings(False)
    End Sub
    Private Sub ControlStates()
        'Dim selectedRole As Role = CType(bndMainClassifier.Current, Role)
        'Me.RepositoryItemCheckEdit.ReadOnly = Not selectedRole.CanEdit
        'Me.colName.OptionsColumn.ReadOnly = Not selectedRole.CanEdit
    End Sub
#End Region


    Private Sub RepositoryItemCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit.CheckedChanged
        If bndSubClassifier.Current Is Nothing Then Exit Sub
        If bndMainClassifier.Current Is Nothing Then Exit Sub
        Dim main As Classifier = CType(bndMainClassifier.Current, Classifier)
        Dim subclass As Classifier = CType(bndSubClassifier.Current, Classifier)
        Dim classif As Entities.Classifier = CType(bndMainClassifier.Current, Entities.Classifier)
        Select Case subclass.GetType().Name
            Case "Speciality"
                If classif.GetType().Name = "SpecialityGroups" Then
                    If Not subclass.Selected And Not CType(classif, SpecialityGroups).Specialities.Contains(subclass) Then
                        CType(classif, SpecialityGroups).Specialities.Add(subclass)
                        _bIsChanged = True
                        CType(classif, SpecialityGroups).SpecialitiesChanged = True
                    End If
                    If subclass.Selected Then
                        CType(classif, SpecialityGroups).Specialities.Remove(subclass)
                        _bIsChanged = True
                        CType(classif, SpecialityGroups).SpecialitiesChanged = True
                    End If
                Else
                    If Not subclass.Selected And Not CType(classif, RoomGroups).Specialities.Contains(subclass) Then
                        CType(classif, RoomGroups).Specialities.Add(subclass)
                        _bIsChanged = True
                        CType(classif, RoomGroups).SpecialitiesChanged = True
                    End If
                    If subclass.Selected Then
                        CType(classif, RoomGroups).Specialities.Remove(subclass)
                        _bIsChanged = True
                        CType(classif, RoomGroups).SpecialitiesChanged = True
                    End If
                End If
            Case "Services"
                For Each p As Classifier In bndSubClassifier
                    p.Selected = CType(classif, Speciality).Services.Contains(p)
                Next
                If Not subclass.Selected And Not CType(classif, Speciality).Services.Contains(subclass) Then
                    CType(classif, Speciality).Services.Add(subclass)
                    _bIsChanged = True
                    CType(classif, Speciality).ServicesChanged = True
                End If
                If subclass.Selected Then
                    CType(classif, Speciality).Services.Remove(subclass)
                    _bIsChanged = True
                    CType(classif, Speciality).ServicesChanged = True
                End If
            Case "RoomGroups"
                For Each p As Classifier In bndSubClassifier
                    p.Selected = CType(classif, Services).RoomGroup.Contains(p)
                Next
                If Not subclass.Selected And Not CType(classif, Services).RoomGroup.Contains(subclass) Then
                    CType(classif, Services).RoomGroup.Add(subclass)
                    _bIsChanged = True
                    CType(classif, Services).RoomGroumsChanged = True
                End If
                If subclass.Selected Then
                    CType(classif, Services).RoomGroup.Remove(subclass)
                    _bIsChanged = True
                    CType(classif, Services).RoomGroumsChanged = True
                End If
            Case "Statuss"
                For Each p As Classifier In bndSubClassifier
                    p.Selected = CType(classif, Statuss).Status.Contains(p)
                Next
                If Not subclass.Selected And Not CType(classif, Statuss).Status.Contains(subclass) Then
                    CType(classif, Statuss).Status.Add(subclass)
                    _bIsChanged = True
                    CType(classif, Statuss).StatusChanged = True
                End If
                If subclass.Selected Then
                    CType(classif, Statuss).Status.Remove(subclass)
                    _bIsChanged = True
                    CType(classif, Statuss).StatusChanged = True
                End If
        End Select
        'If Not subclass.Selected And Not Role.Permissions.Contains(Permission) Then
        '    Role.Permissions.Add(Permission)
        '    _bIsChanged = True
        '    Role.PermsChanged = True
        'End If
        'If permission.Selected Then
        '    CType(Role.Permissions, IList).Remove(permission)
        '    _bIsChanged = True
        '    Role.PermsChanged = True
        'End If
    End Sub

    Private Sub grdPermissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdSubclassifier.Click

    End Sub
End Class