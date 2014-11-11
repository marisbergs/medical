<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubscription
    Inherits Client.frmUIBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvwDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAppointment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetailPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetailService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVisit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdData = New Core.UI.CoreGrid()
        Me.bndData = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwSubscription = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPatient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTimeCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserAcceptedPayment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CtlSubscriptionFind1 = New Client.ctlSubscriptionFind()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        CType(Me.gvwDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSubscription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvwDetails
        '
        Me.gvwDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAppointment, Me.colDetailPrice, Me.colDetailService, Me.colVisit})
        Me.gvwDetails.GridControl = Me.grdData
        Me.gvwDetails.GroupFormat = "{0}: [#image]{1} {2}gg"
        Me.gvwDetails.Name = "gvwDetails"
        Me.gvwDetails.OptionsBehavior.Editable = False
        Me.gvwDetails.OptionsView.ShowFilterPanel = False
        Me.gvwDetails.OptionsView.ShowGroupPanel = False
        Me.gvwDetails.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAppointment, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.gvwDetails.ViewCaption = "Abonementa apmeklējuma reižu saraksts"
        '
        'colAppointment
        '
        Me.colAppointment.Caption = "Apmeklējuma reize"
        Me.colAppointment.FieldName = "Appointment"
        Me.colAppointment.Name = "colAppointment"
        Me.colAppointment.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colAppointment.Visible = True
        Me.colAppointment.VisibleIndex = 0
        Me.colAppointment.Width = 118
        '
        'colDetailPrice
        '
        Me.colDetailPrice.Caption = "Cena"
        Me.colDetailPrice.DisplayFormat.FormatString = "n2"
        Me.colDetailPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDetailPrice.FieldName = "Price"
        Me.colDetailPrice.Name = "colDetailPrice"
        Me.colDetailPrice.Visible = True
        Me.colDetailPrice.VisibleIndex = 1
        Me.colDetailPrice.Width = 56
        '
        'colDetailService
        '
        Me.colDetailService.Caption = "Pakalpojums"
        Me.colDetailService.FieldName = "Service"
        Me.colDetailService.Name = "colDetailService"
        Me.colDetailService.Visible = True
        Me.colDetailService.VisibleIndex = 2
        Me.colDetailService.Width = 393
        '
        'colVisit
        '
        Me.colVisit.Caption = "Saistītā vizīte"
        Me.colVisit.FieldName = "VisitForDisplay"
        Me.colVisit.Name = "colVisit"
        Me.colVisit.Visible = True
        Me.colVisit.VisibleIndex = 3
        Me.colVisit.Width = 396
        '
        'grdData
        '
        Me.grdData.DataSource = Me.bndData
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdData.EmbeddedNavigator.Name = ""
        Me.grdData.EnforceCanEdit = False
        GridLevelNode1.LevelTemplate = Me.gvwDetails
        GridLevelNode1.RelationName = "SubscriptionDetail"
        Me.grdData.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdData.Location = New System.Drawing.Point(0, 82)
        Me.grdData.MainView = Me.gvwSubscription
        Me.grdData.Name = "grdData"
        Me.grdData.ShowOnlyActive = False
        Me.grdData.ShowOnlyPredefinedDetails = True
        Me.grdData.Size = New System.Drawing.Size(992, 271)
        Me.grdData.TabIndex = 2
        Me.grdData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSubscription, Me.gvwDetails})
        '
        'bndData
        '
        Me.bndData.DataSource = GetType(Entities.Subscription)
        '
        'gvwSubscription
        '
        Me.gvwSubscription.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPatient, Me.colService, Me.colPrice, Me.colTimeCount, Me.colComment, Me.colPayTime, Me.colUserAcceptedPayment})
        Me.gvwSubscription.GridControl = Me.grdData
        Me.gvwSubscription.Name = "gvwSubscription"
        Me.gvwSubscription.OptionsBehavior.Editable = False
        Me.gvwSubscription.OptionsView.ColumnAutoWidth = False
        Me.gvwSubscription.OptionsView.ShowAutoFilterRow = True
        Me.gvwSubscription.OptionsView.ShowFilterPanel = False
        Me.gvwSubscription.OptionsView.ShowGroupPanel = False
        '
        'colPatient
        '
        Me.colPatient.Caption = "Klients"
        Me.colPatient.FieldName = "Patient"
        Me.colPatient.Name = "colPatient"
        Me.colPatient.Visible = True
        Me.colPatient.VisibleIndex = 0
        Me.colPatient.Width = 192
        '
        'colService
        '
        Me.colService.Caption = "Abonements"
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 1
        Me.colService.Width = 180
        '
        'colPrice
        '
        Me.colPrice.Caption = "Cena"
        Me.colPrice.DisplayFormat.FormatString = "n2"
        Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 2
        Me.colPrice.Width = 50
        '
        'colTimeCount
        '
        Me.colTimeCount.Caption = "Reižu skaits"
        Me.colTimeCount.FieldName = "TimeCount"
        Me.colTimeCount.Name = "colTimeCount"
        Me.colTimeCount.Visible = True
        Me.colTimeCount.VisibleIndex = 3
        '
        'colComment
        '
        Me.colComment.Caption = "Piezīmes"
        Me.colComment.FieldName = "Comment"
        Me.colComment.Name = "colComment"
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 4
        Me.colComment.Width = 209
        '
        'colPayTime
        '
        Me.colPayTime.Caption = "Apmaksas datums"
        Me.colPayTime.FieldName = "PayTime"
        Me.colPayTime.Name = "colPayTime"
        Me.colPayTime.Visible = True
        Me.colPayTime.VisibleIndex = 5
        Me.colPayTime.Width = 107
        '
        'colUserAcceptedPayment
        '
        Me.colUserAcceptedPayment.Caption = "Apmaksu pieņēma"
        Me.colUserAcceptedPayment.FieldName = "UserAcceptedPayment"
        Me.colUserAcceptedPayment.Name = "colUserAcceptedPayment"
        Me.colUserAcceptedPayment.Visible = True
        Me.colUserAcceptedPayment.VisibleIndex = 6
        Me.colUserAcceptedPayment.Width = 149
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(496, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(418, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(337, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Eksportēt"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Pievienot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndData
        '
        'CtlSubscriptionFind1
        '
        Me.CtlSubscriptionFind1.AutoSize = True
        Me.CtlSubscriptionFind1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlSubscriptionFind1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlSubscriptionFind1.Location = New System.Drawing.Point(0, 0)
        Me.CtlSubscriptionFind1.MinimumSize = New System.Drawing.Size(403, 0)
        Me.CtlSubscriptionFind1.Name = "CtlSubscriptionFind1"
        Me.CtlSubscriptionFind1.Size = New System.Drawing.Size(992, 82)
        Me.CtlSubscriptionFind1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 353)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(992, 28)
        Me.SplitContainer1.SplitterDistance = 492
        Me.SplitContainer1.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(492, 28)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(84, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(165, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'frmSubscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 381)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.CtlSubscriptionFind1)
        Me.MinimumSize = New System.Drawing.Size(1000, 415)
        Me.Name = "frmSubscription"
        Me.Text = "Abonementi"
        CType(Me.gvwDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSubscription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents bndData As System.Windows.Forms.BindingSource
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CtlSubscriptionFind1 As Client.ctlSubscriptionFind
    Private _criteria As Object
    Friend WithEvents grdData As Core.UI.CoreGrid
    Friend WithEvents gvwSubscription As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPatient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTimeCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserAcceptedPayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents gvwDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAppointment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetailPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetailService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVisit As DevExpress.XtraGrid.Columns.GridColumn
End Class
