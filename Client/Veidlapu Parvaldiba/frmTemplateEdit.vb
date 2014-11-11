Imports Core.Dal
Imports Core.UI
Imports Core.Bll
Imports Core
Imports Entities
Imports Core.Localization
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports System
Imports System.Threading
Imports System.IO
Public Class frmTemplateEdit
    Implements Core.UI.IEditForm

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        If Not Me.DesignMode Then
            bndTemplateType.DataSource = Core.Bll.Entities(Of Entities.TemplateType).GetAll(Session)
        End If
        'lueTemplateType.Properties.ReadOnly = True
    End Sub

    Private _editedObject As Template
    Private _isNew As Boolean
    Private _wasSaved As Boolean = False

    Private _dataList As IList
    Public Property DataList() As IList Implements IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As IList)
            _dataList = value
        End Set
    End Property

    Private _dataIDs As Dictionary(Of Type, Guid)
    Public Property DataIDs() As Dictionary(Of Type, Guid) Implements IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As Dictionary(Of Type, Guid))
            _dataIDs = value
            Dim editedObjectId As Guid
            editedObjectId = _dataIDs(GetType(Template))
            If editedObjectId = Guid.Empty Then
                _isNew = True
                _editedObject = New Template(Session)
                If Not Me.DesignMode Then
                    'bndTemplateType.DataSource = Core.Bll.Entities(Of Entities.TemplateType).GetAll(Session)
                    'bndTemplateType.DataSource = Core.Bll.Entities(Of Entities.TemplateType).GetAll(Session, Core.Dal.Expressions.CriterionBase.Equals("", ))
                End If
            Else
                _isNew = False
                _editedObject = Session.Get(Of Template)(editedObjectId)
            End If

            bndTemplate.DataSource = _editedObject
            gbhTemplateFile.ShowActive = True
            'Dim _selTyp As New Queue(Of KeyValuePair(Of String, Object))
            '_selTyp.Enqueue(New KeyValuePair(Of String, Object)("StartWith", TemplateType.LetterParentId))
            '_selTyp.Enqueue(New KeyValuePair(Of String, Object)("CanChangeGroup", False))
            'CType(txtType, IPickerSupportsPresets).PickerPresets = _selTyp
        End Set
    End Property

    Protected Overrides Sub OnShown(ByVal e As System.EventArgs)
        'MyBase.OnShown(e)
        'If _isNew Then
        '    Dim args As New Core.UI.GridButtonHelper.AddNewEventArgs()
        '    args.CancelAdd = False
        '    gbhTempalateFile_OnAddNew(Me, args)
        '    If args.CancelAdd Then
        '        Me.DialogResult = Windows.Forms.DialogResult.Abort
        '        Return
        '    Else
        '        _editedObject.Files.Add(args.AddedObject)
        '    End If
        'End If

        ''Me.lueTemplateType.Properties.ReadOnly = Not _isNew
        'bndTemplate.DataSource = _editedObject
        'Me.gbhTemplateFile.ShowActive = True
    End Sub

    Private Function HasError() As Boolean
        Return Not CType(bndTemplate.DataSource, Template).IsValid
    End Function

    Private Function _Save() As Boolean


        If HasError() Then
            ActivateErrorControls(Me.ErrorProvider, Me)
            Core.UI.MsgBox.HasErrorMessage()
            Return False
        End If



        If _editedObject.IsValid Then
            'Session.SaveOrUpdate(_editedObject)
            _editedObject.SaveTemplate(_isNew)
            Me.AcceptChanges()
            _wasSaved = True
            If _isNew Then
                _dataIDs(GetType(Template)) = Session.GetIdentifier(_editedObject)
            End If
            _editedObject.IsDirty = False
            Return True
        Else
            ActivateErrorControls(Me.ErrorProvider, Me)
            MsgBox.HasErrorMessage()
            Return False
        End If
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        _Save()
    End Sub

    Private Sub bntClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmTemplateEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult = Windows.Forms.DialogResult.Abort Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Return
        End If
        If _editedObject.IsDirty Then
            Select Case MsgBox.SaveMessage()
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
                Case Windows.Forms.DialogResult.Yes
                    If _Save() Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        e.Cancel = True
                    End If
                Case Else
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End Select
        Else
            If _wasSaved Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub


#Region "Files"

    Private Sub inplaceFileOpenButton_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles inplaceFileOpenButton.ButtonClick

        If Me.FilesBindingSource.Current Is Nothing Then Return

        Dim templateFile As TemplateFileVersion = CType(FilesBindingSource.Current, TemplateFileVersion)
        Dim tempFileName As String = Path.GetTempPath + "\" + Guid.NewGuid().ToString() + templateFile.File.Name
        Core.Helper.ReadWriteStream(templateFile.File.Content.GetAsStream(), New FileStream(tempFileName, FileMode.Create))
        Core.Helper.RunShell(tempFileName)

    End Sub

    Private Sub gbhTempalateFile_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhTemplateFile.OnAddNew
        Dim iVersionNumber As Integer
        Dim ofd As New OpenFileDialog
        ofd.Filter = "RTF files (*.rtf)|*.rtf"
        ofd.FilterIndex = 0

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim istrim As New IO.FileStream(ofd.FileName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
                istrim.Dispose()
                If _editedObject.CurrentVersion Is Nothing Then
                    iVersionNumber = 1
                Else
                    iVersionNumber = _editedObject.CurrentVersion.VersionNumber + 1
                    _editedObject.CurrentVersion.ValidUntil = DateTime.Today
                    _editedObject.CurrentVersion.IsActive = False
                End If
                Dim tfv As New TemplateFileVersion(Session, ofd.FileName, iVersionNumber)
                args.AddedObject = tfv
                args.CancelAdd = False
            Catch err As System.IO.IOException
                MsgBox.Show(Core.Err.TemplateFileOpened)
            Catch err As Exception
                MsgBox.Show(err.Message)
            End Try
        Else
            args.CancelAdd = True
        End If
    End Sub

#End Region
End Class