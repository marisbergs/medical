Imports Entities
Imports System.IO
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports System.Collections.Generic
Imports Core


Public Class frmRtgSummary
    Implements IEditForm


    Private _edit As RtgSummary
    Private _dataList As IList


    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(RtgSummary)) = Guid.Empty Then 'add new TcdPlan
                _edit = New RtgSummary(Session, value(GetType(Patient)))
            Else 'edit existing
                _edit = Session.Get(Of RtgSummary)(value(GetType(RtgSummary)))
            End If
            txtPatient.Text = _edit.Patient.FullName
            bndRtgSummaryRecords.DataSource = _edit.Rtg
            If bndRtgSummaryRecords.Current Is Nothing Then
                Panel2.Enabled = False
            End If
        End Set
    End Property

    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As IList)
            _dataList = value
        End Set
    End Property

    Private Function Save() As Boolean
        Dim add As Boolean = (_edit.Id = Guid.Empty)
        If Not _edit.IsValid Then
            MsgBox.HasErrorMessage()
            Return False
        End If
        For Each record As RtgSummaryRecord In _edit.Rtg
            If Not record.IsValid Then
                MsgBox.HasErrorMessage()
                Return False
            End If
            'Session.SaveOrUpdate(record)
        Next
        Session.SaveOrUpdate(_edit)
        Session.Commit()
        If add Then
            DataList.Add(PartnerSession.Get(Of RtgSummary)(_edit.Id))
        End If
        Return True
    End Function


    Private Sub frmRtgSummary_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If _edit.IsDirty Then
            Dim answer As DialogResult = MsgBox.SaveMessage()
            If answer = DialogResult.Yes Then
                If Not Save() Then
                    e.Cancel = True
                End If
            ElseIf answer = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub gbhAppealFiles_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhAppealFiles.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(RtgType)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As RtgSummaryRecord In _edit.Rtg.ActiveItemsWithoutEmpty
            If Not x.RtgType Is Nothing AndAlso Not obj.Contains(x.RtgType.Id) Then
                obj.Add(x.RtgType.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim tem As RtgSummaryRecord
            For Each x As RtgType In CType(frm.Selection, Entities(Of RtgType))
                tem = New RtgSummaryRecord(Session)
                tem.RtgType = x
                tem.RtgSummary = _edit
                args.AddedObject = tem
                _edit.Rtg.Add(tem)
            Next
        End If
        Panel2.Enabled = Not (bndRtgSummaryRecords.Current Is Nothing)
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If _edit.IsValid Then
            For Each record As RtgSummaryRecord In _edit.Rtg
                If Not record.IsValid Then
                    MsgBox.HasErrorMessage()
                    Return
                End If
            Next
            If _edit.IsDirty Then
                If Core.UI.MsgBox.Show(Msg.CantGenerateUnlessSaved, MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                    Save()
                Else
                    Return
                End If
            End If

            If Not _edit.File Is Nothing Then
                If Core.UI.MsgBox.Show(Msg.GenerateAgain, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            _edit.GenerateDocument("D05")
        Else
            Core.UI.MsgBox.HasErrorMessage()
        End If
        Save()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        _edit.ShowTrackedDocument()
    End Sub

    Private Sub bndRtgSummaryRecords_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndRtgSummaryRecords.PositionChanged
        Panel2.Enabled = Not (bndRtgSummaryRecords.Current Is Nothing)
    End Sub
End Class
