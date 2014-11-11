Imports Entities
Imports core
Imports Core.UI
Imports Core.Bll
Imports Core.Dal
Imports Core.Dal.Expressions
Imports System.Reflection
Imports System.ComponentModel
Imports System.Collections
Imports NHibernate.Expression

Public Class frmHierClassifierList
    Implements ISelectionForm
    Private _setAsFirstNode As Boolean = False

#Region "Public property"

    Public Property Selection() As Object Implements ISelectionForm.Selection
        Get
            Select Case _mode
                Case ClassifierListMode.Edit
                    Return Nothing
                Case ClassifierListMode.SingleSelect
                    If Me.trvHierClassifier.SelectedNode Is Nothing Then
                        Return Nothing
                    Else
                        Dim node As CoreTreeNode = CType(trvHierClassifier.SelectedNode, CoreTreeNode)
                        Return node.Data
                    End If
                Case ClassifierListMode.MultiSelect
                    Dim mi As MethodInfo = Me.GetType().GetMethod("GenericTrick1")
                    mi = mi.MakeGenericMethod(_typeEntity.TypeObject)
                    Return mi.Invoke(Me, Nothing)
                Case Else
                    Return Nothing
            End Select
        End Get
        Set(ByVal value As Object)
            'If Not value Is System.DBNull.Value Then Dim item As HierClassifier = CType(value, HierClassifier)
            'Select Case mode
            '    Case ClassifierListMode.SingleSelect
            '    Case ClassifierListMode.MultiSelect
            'End Select
        End Set
    End Property

    Public Property FormMode() As ClassifierListMode Implements ISelectionForm.FormMode
        Get
            Return _mode
        End Get
        Set(ByVal value As ClassifierListMode)
            _mode = value
            Select Case value
                Case ClassifierListMode.Edit
                    Me.btnOK.Visible = False
                    Me.btnEdit.Visible = True
                    Me.btnDelete.Visible = True
                    If Not _typeEntity.Kind Is Nothing Then
                        Me.btnActivate.Visible = (_typeEntity.Kind.Value = ClassifierKindEnum.External)
                    Else
                        Me.btnActivate.Visible = False
                    End If
                    Me.trvHierClassifier.CheckBoxes = False
                    Me.chkSelectActive.Enabled = True
                    Me.chkShowComments.Visible = True
                Case ClassifierListMode.MultiSelect
                    Me.btnOK.Visible = True
                    Me.trvHierClassifier.CheckBoxes = True
                    Me.trvHierClassifier.ContextMenuStrip = Nothing
                    Me.btnEdit.Visible = False
                    Me.btnDelete.Visible = False
                    Me.btnActivate.Visible = False
                    Me.btnAdd.Visible = False
                    Me.chkSelectActive.Enabled = False
                    Me.chkShowComments.Visible = False
                Case ClassifierListMode.SingleSelect
                    Me.btnOK.Visible = True
                    Me.trvHierClassifier.CheckBoxes = False
                    Me.trvHierClassifier.ContextMenuStrip = Nothing
                    Me.btnEdit.Visible = False
                    Me.btnDelete.Visible = False
                    Me.btnActivate.Visible = False
                    Me.btnAdd.Visible = False
                    Me.chkSelectActive.Enabled = False
                    Me.chkShowComments.Visible = False
            End Select
        End Set
    End Property

    Dim nodes As IList
    Public Sub SetRootNodeIDs(ByVal ParamArray nodeIDs() As Object)
        Dim rootnodes As IList
        If nodeIDs Is Nothing Then
            rootnodes = Session.CreateCriteria(Me._typeEntity.TypeObject()).List()
            If chkSelectActive.Checked Then
                If _idList Is Nothing OrElse _idList.Count = 0 Then
                    rootnodes = Session.CreateCriteria(Me._typeEntity.TypeObject()).Add(New [NullExpression]("DeleteTime")).List()
                Else
                    Dim _objMas(_idList.Count - 1) As Object
                    Dim y As Integer = 0
                    For Each x As Guid In _idList
                        _objMas(y) = x
                        y += 1
                    Next
                    rootnodes = Session.CreateCriteria(Me._typeEntity.TypeObject()).Add(New [NullExpression]("DeleteTime")).Add( _
                                                                                        New NHibernate.Expression.NotExpression( _
                                                                                        New NHibernate.Expression.InExpression("Id", _objMas))).List()
                End If
                bndClassifier.DataSource = rootnodes
            End If
        Else
            If chkSelectActive.Checked Then
                If _idList Is Nothing OrElse _idList.Count = 0 Then
                    rootnodes = Session.CreateCriteria(Me._typeEntity.TypeObject()).Add(New NHibernate.Expression.InExpression("Id", nodeIDs)).List()
                Else
                    Dim _objMas(_idList.Count - 1) As Object
                    Dim y As Integer = 0
                    For Each x As Guid In _idList
                        _objMas(y) = x
                        y += 1
                    Next
                    rootnodes = Session.CreateCriteria(Me._typeEntity.TypeObject()).Add(New NHibernate.Expression.InExpression("Id", nodeIDs)).Add( _
                                                                                        New NHibernate.Expression.NotExpression( _
                                                                                        New NHibernate.Expression.InExpression("Id", _objMas))).List()
                End If
                nodes = New ArrayList()
                For Each rootItem As HierClassifier In rootnodes
                    rootItem.FirstRecord = _setAsFirstNode
                    AppendChildren(rootItem)
                Next
            Else
                nodes = Session.CreateCriteria(_typeEntity.TypeObject).List()
            End If
            bndClassifier.DataSource = nodes
        End If
    End Sub

    Private Sub AppendChildren(ByVal item As HierClassifier)
        nodes.Add(item)
        Dim child As IList
        If _idList Is Nothing OrElse _idList.Count = 0 Then
            'child = Session.CreateCriteria(_typeEntity.TypeObject).List()
            child = Session.CreateCriteria(Me._typeEntity.TypeObject()).Add(New NHibernate.Expression.AndExpression(New NHibernate.Expression.EqExpression("Parents", item), _
                                                                                                                    New NHibernate.Expression.NotExpression( _
                                                                                                                    New NHibernate.Expression.EqExpression("Id", item.Id)))).List()
        Else
            Dim _idMas(_idList.Count - 1) As Object
            Dim y As Integer = 0
            For Each x As Guid In _idList
                _idMas(y) = x
                y += 1
            Next
            child = Session.CreateCriteria(Me._typeEntity.TypeObject()).Add(New NHibernate.Expression.AndExpression(New NHibernate.Expression.EqExpression("Parents", item), _
                                                                                                                    New NHibernate.Expression.NotExpression( _
                                                                                                                    New NHibernate.Expression.EqExpression("Id", item.Id)))).Add( _
                                                                                                                    New NHibernate.Expression.NotExpression( _
                                                                                                                    New NHibernate.Expression.InExpression("Id", _idMas))).List()
        End If
        For Each childItem As HierClassifier In child
            If (Not childItem.Parents Is Nothing AndAlso Not childItem.Id = childItem.Parents.Id) And ((chkSelectActive.Checked AndAlso childItem.IsActive) OrElse Not chkSelectActive.Checked) Then
                AppendChildren(childItem)
            End If
        Next
    End Sub

#End Region

#Region "Constructor"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal tp As Entities.ClassifierType, ByVal session As ISession, ByVal formMode As ClassifierListMode)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        session = session
        InitUsingClassifierType(tp)
        Me.Text = tp.Value
        Me.FormMode = formMode
        ReloudCmbRootNode()
        'CanCreate new record
        If tp.Kind.Value = ClassifierKindEnum.System Then
            btnAdd.Enabled = False
        ElseIf tp.Kind.Value = ClassifierKindEnum.External Then
            btnAdd.Enabled = PermissionsChecker.CanDo("Classifier.External.Save")
        Else
            btnAdd.Enabled = PermissionsChecker.CanDo("Menu.ClassifierAdministration")
        End If
        cmbRootNode.SelectedIndex = -1
        Me.FormMode = ClassifierListMode.Edit
        If tp.CommentPrompt Is Nothing Then
            chkShowComments.Checked = False
        Else
            chkShowComments.Checked = True
        End If
    End Sub

#End Region

#Region "Private variables"
    Private _items As IList
    Private _mode As ClassifierListMode
    Private _typeEntity As ClassifierType
    Private _idList As IList(Of Guid)
#End Region

#Region "Public methods"

    Public Sub InitUsingClassifierType(ByVal typeEntity As Entities.ClassifierType)
        _typeEntity = typeEntity

        If chkSelectActive.Checked Then
            If _idList Is Nothing OrElse _idList.Count = 0 Then
                nodes = Session.CreateCriteria(Me._typeEntity.TypeObject()).Add(New [NullExpression]("DeleteTime")).List()
            Else
                Dim _objMas(_idList.Count - 1) As Object
                Dim y As Integer = 0
                For Each x As Guid In _idList
                    _objMas(y) = x
                    y += 1
                Next
                nodes = Session.CreateCriteria(Me._typeEntity.TypeObject()).Add(New [NullExpression]("DeleteTime")).Add( _
                                                                                New NHibernate.Expression.NotExpression( _
                                                                                New NHibernate.Expression.InExpression("Id", _objMas))).List()
            End If
        Else
            nodes = Session.CreateCriteria(_typeEntity.TypeObject).List()
        End If
        bndClassifier.DataSource = nodes
    End Sub

    Public Sub GenericTrick(Of classifierType As {New, HierClassifier})()
        Dim items As Entities(Of classifierType)

        items = Entities(Of classifierType).GetAll(Session)
        _items = items
        Me.bndClassifier.DataSource = items
    End Sub

    Public Function GenericTrick1(Of ct As {New, IBusinessObjectBase})() As IList(Of ct)
        Dim list As New Entities(Of ct)
        If Not Me.bndClassifier Is Nothing Then
            For Each itm As ct In Me.bndClassifier.List
                list.Add(itm)
            Next
        End If
        If list.Count = 0 Then Return Nothing
        Return list.FilterItems(New Expressions.Eq("Selected", True))
        'Dim _items As IList = bndClassifier.List
        'If _items.Count = 0 Then Return Nothing
        'Dim lists As Entities(Of ct) = CType(_items, Entities(Of ct))
        'Return lists.FilterItems(New Expressions.Eq("Selected", True))
    End Function

    Public Function ShowDialog1() As System.Windows.Forms.DialogResult Implements Core.UI.ISelectionForm.ShowDialog
        Return Me.ShowDialog()
    End Function

    Public WriteOnly Property SearchObjectPropertyPresets() As Queue(Of KeyValuePair(Of String, Object)) Implements ISelectionForm.SearchObjectPropertyPresets
        Set(ByVal value As Queue(Of KeyValuePair(Of String, Object)))
            ' Search not implemented
            If Not value Is Nothing Then
                For Each x As KeyValuePair(Of String, Object) In value
                    If x.Key = "NotIn" Then
                        _idList = x.Value
                        ReloudCmbRootNode()
                    End If
                    If x.Key = "FirstRecord" Then
                        _setAsFirstNode = CBool(x.Value)
                    End If
                    If x.Key = "StartWith" Then
                        SetRootNodeIDs(CType(x.Value, Guid))
                    End If
                    If x.Key = "CanChangeGroup" Then
                        If Not CBool(x.Value) Then
                            chkRootNode.Enabled = False
                            cmbRootNode.Enabled = False
                        End If
                    End If
                Next
            End If
        End Set
    End Property

#End Region

#Region "Private methods"

    Private Sub TreeView1_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        Dim item As HierClassifier = CType(e.Node.Tag, HierClassifier)
        item.Selected = e.Node.Checked
    End Sub

    Private Sub cmbRootNode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRootNode.SelectedIndexChanged
        If Not Me.Created Then Return
        Dim item As HierClassifier = CType(cmbRootNode.SelectedItem, HierClassifier)
        If item Is Nothing Then Return
        SetRootNodeIDs(item.Id)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If (trvHierClassifier.SelectedNode Is Nothing) Then
            Return
        End If
        Dim frm As New frmClassifierEdit
        Dim dataIds As New Dictionary(Of Type, Guid)
        Dim node As CoreTreeNode = CType(trvHierClassifier.SelectedNode, CoreTreeNode)
        dataIds.Add(GetType(HierClassifier), CType(node.Data, HierClassifier).Id)
        frm.DataIDs = dataIds
        frm.DataList = bndClassifier.List
        frm.ConfigureUsingClassifierType(_typeEntity)
        frm.ShowDialog()

        'bndClassifier.ResetBindings(False)
        ReloudCmbRootNode()
        ReloudTree()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmClassifierEdit
        Dim dataIds As New Dictionary(Of Type, Guid)
        frm.ConfigureUsingClassifierType(_typeEntity)
        dataIds.Add(GetType(HierClassifier), Guid.Empty)
        Dim node As CoreTreeNode = CType(trvHierClassifier.SelectedNode, CoreTreeNode)
        
        frm.DataIDs = dataIds
        frm.PartnerSession = Me.Session
        frm.DataList = bndClassifier.List
        frm.ShowDialog()
        ' bndClassifier.ResetBindings(False)
        ReloudCmbRootNode()
        ReloudTree()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkRootNode_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRootNode.CheckStateChanged
        If Not Me.Created Then Return
        If CType(sender, CheckBox).Checked Then
            cmbRootNode.Enabled = True
            If cmbRootNode.SelectedItem Is Nothing Then
                SetRootNodeIDs(Nothing)
            Else
                Dim item As HierClassifier = CType(cmbRootNode.SelectedItem, HierClassifier)
                SetRootNodeIDs(item.Id)
            End If
        Else
            cmbRootNode.SelectedIndex = -1
            cmbRootNode.Enabled = False
            SetRootNodeIDs(Nothing)
        End If
    End Sub

    Private Sub chkSelectActive_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectActive.CheckedChanged
        If Not Me.Created Then Return
        ReloudCmbRootNode()
        ReloudTree()
    End Sub

    Private Sub trvHierClassifier_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvHierClassifier.AfterSelect
        If trvHierClassifier.SelectedNode Is Nothing Then Return
        btnDelete.Enabled = CType(CType(Me.trvHierClassifier.SelectedNode, Core.UI.CoreTreeNode).Data, HierClassifier).CanDelete
        btnActivate.Enabled = CType(CType(Me.trvHierClassifier.SelectedNode, Core.UI.CoreTreeNode).Data, HierClassifier).CanActivate
    End Sub
#End Region

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If trvHierClassifier.SelectedNode Is Nothing Then Return
        If Not Core.UI.MsgBox.DeleteMessage = Windows.Forms.DialogResult.Yes Then Return
        Dim node As CoreTreeNode = CType(trvHierClassifier.SelectedNode, CoreTreeNode)

        Dim currCl As HierClassifier = Session.Get(Of HierClassifier)(CType(trvHierClassifier.SelectedNode, Core.UI.CoreTreeNode).Value)
        Dim listCl As New Entities(Of HierClassifier)
        Dim getListCl As New Entities(Of HierClassifier) 'IList(Of Organization) = New Entities(Of Organization)
        getListCl.Add(currCl)
        Dim counter As Integer = 0

        While Not getListCl.Count = 0
            For Each getCl As HierClassifier In getListCl
                listCl = Entities(Of HierClassifier).GetAll(Session, New [Eq]("Parents", getCl))
                For Each org As HierClassifier In listCl
                    If org.IsActive And Not org Is org.Parents Then
                        Core.UI.MsgBox.Show(Err.HierClassifierDeleteChild, MessageBoxButtons.OK)
                        Return
                    End If
                Next
            Next
            getListCl = listCl
            counter += 1
            'go in cicle
            If counter = 25 Then Exit While
        End While

        currCl.Delete()
        Me.AcceptChanges()
        'remove not active record's from comboBox 
        If currCl.Parents Is Nothing And chkSelectActive.Checked Then
            ReloudCmbRootNode()
            ReloudTree()
        End If
        If Me.chkSelectActive.Checked Then
            If Not node.Parent Is Nothing Then
                Dim parent As CoreTreeNode = CType(node.Parent, CoreTreeNode)
                parent.Nodes.Remove(node)
            Else
                trvHierClassifier.Nodes.Remove(node)
            End If
        Else
            node.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        If Core.UI.MsgBox.Show(Msg.ActivateConfirmation, MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.No Then Return
        If trvHierClassifier.SelectedNode Is Nothing Then Return
        Dim node As CoreTreeNode = CType(trvHierClassifier.SelectedNode, CoreTreeNode)
        Dim currCl As HierClassifier = Session.Get(Of HierClassifier)(CType(trvHierClassifier.SelectedNode, Core.UI.CoreTreeNode).Value)
        currCl.Activate()
        Me.AcceptChanges()
        node.ForeColor = Color.Black
    End Sub

    Private Sub ReloudCmbRootNode()
        Dim selectedItem As Object
        If Not cmbRootNode.SelectedItem Is Nothing Then selectedItem = cmbRootNode.SelectedItem
        If chkSelectActive.Checked Then
            If _idList Is Nothing OrElse _idList.Count = 0 Then
                cmbRootNode.DataSource = Session.CreateCriteria(_typeEntity.TypeObject).Add(New NHibernate.Expression.AndExpression(New [OrExpression](New [NullExpression]("Parents"), New [EqPropertyExpression]("Parents.Id", "Id")), _
                                                                                                                                    New [NullExpression]("DeleteTime"))).AddOrder(New [Order]("Value", True)).List()
            Else
                Dim _objMas(_idList.Count - 1) As Object
                Dim y As Integer = 0
                For Each x As Guid In _idList
                    _objMas(y) = x
                    y += 1
                Next
                cmbRootNode.DataSource = Session.CreateCriteria(_typeEntity.TypeObject).Add(New NHibernate.Expression.AndExpression(New [OrExpression](New [NullExpression]("Parents"), New [EqPropertyExpression]("Parents.Id", "Id")), _
                                                                                                                                    New [NullExpression]("DeleteTime"))).AddOrder(New [Order]("Value", True)).Add( _
                                                                                                                                    New NHibernate.Expression.NotExpression(New NHibernate.Expression.InExpression("Id", _objMas))).List()
            End If
        Else ' If Not chkSelectActive.Checked
            If _idList Is Nothing OrElse _idList.Count = 0 Then
                cmbRootNode.DataSource = Session.CreateCriteria(_typeEntity.TypeObject).Add(New [OrExpression](New [NullExpression]("Parents"), New [EqPropertyExpression]("Parents.Id", "Id"))).AddOrder(New [Order]("Value", True)).List()
            Else
                Dim _objMas(_idList.Count - 1) As Object
                Dim y As Integer = 0
                For Each x As Guid In _idList
                    _objMas(y) = x
                    y += 1
                Next
                cmbRootNode.DataSource = Session.CreateCriteria(_typeEntity.TypeObject).Add(New [OrExpression](New [NullExpression]("Parents"), New [EqPropertyExpression]("Parents.Id", "Id"))).AddOrder(New [Order]("Value", True)).Add( _
                                                                                                                                                New NHibernate.Expression.NotExpression(New NHibernate.Expression.InExpression("Id", _objMas))).List()
            End If
        End If
        If selectedItem Is Nothing Then
            cmbRootNode.SelectedIndex = -1
        Else
            cmbRootNode.SelectedItem = selectedItem
        End If

    End Sub

    Private Sub ReloudTree()
        If chkRootNode.Checked Then
            If cmbRootNode.SelectedItem Is Nothing Then
                SetRootNodeIDs(Nothing)
            Else
                Dim item As HierClassifier = CType(cmbRootNode.SelectedItem, HierClassifier)
                SetRootNodeIDs(item.Id)
            End If
        Else
            SetRootNodeIDs(Nothing)
        End If
    End Sub

    Private Sub chkShowComments_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowComments.CheckedChanged
        If Not _typeEntity Is Nothing Then
            If chkShowComments.Checked Then
                _typeEntity.CommentPrompt = "Classifier.CommentPrompt"
                If FormMode = ClassifierListMode.Edit Then
                    Session.Update(_typeEntity)
                    Session.Commit()
                    ReloudTree()
                End If
            Else
                If Not _typeEntity.CommentPrompt Is Nothing Then
                    _typeEntity.CommentPrompt = Nothing
                    If FormMode = ClassifierListMode.Edit Then
                        Session.Update(_typeEntity)
                        Session.Commit()
                        ReloudTree()
                    End If
                End If
            End If
        End If
    End Sub
End Class
' Lūdzu, Юникод
