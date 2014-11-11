<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPAKList
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
        Me.components = New System.ComponentModel.Container
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnOpen = New System.Windows.Forms.Button
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.bndPatientProgramms = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdProgramms = New Core.UI.CoreGrid
        Me.gvwProgramms = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProfile = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPatient = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBeginDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPayDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPaymentAcceptedByUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCreateUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.bndPatientProgramms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProgramms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwProgramms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 393)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1015, 30)
        Me.SplitContainer1.SplitterDistance = 505
        Me.SplitContainer1.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(505, 30)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(3, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(506, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(428, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'bndPatientProgramms
        '
        Me.bndPatientProgramms.DataSource = GetType(Entities.PatientProfileDescription)
        '
        'grdProgramms
        '
        Me.grdProgramms.DataSource = Me.bndPatientProgramms
        Me.grdProgramms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProgramms.EmbeddedNavigator.Name = ""
        Me.grdProgramms.EnforceCanEdit = False
        Me.grdProgramms.Location = New System.Drawing.Point(0, 0)
        Me.grdProgramms.MainView = Me.gvwProgramms
        Me.grdProgramms.Name = "grdProgramms"
        Me.grdProgramms.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdProgramms.ShowOnlyActive = False
        Me.grdProgramms.Size = New System.Drawing.Size(1015, 393)
        Me.grdProgramms.TabIndex = 4
        Me.grdProgramms.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwProgramms})
        '
        'gvwProgramms
        '
        Me.gvwProgramms.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProfile, Me.colPatient, Me.colNumber, Me.colBeginDate, Me.colEndDate, Me.colPrice, Me.colPayDate, Me.colPaymentAcceptedByUser, Me.colCreateDate, Me.colCreateUser})
        Me.gvwProgramms.GridControl = Me.grdProgramms
        Me.gvwProgramms.Name = "gvwProgramms"
        Me.gvwProgramms.OptionsBehavior.Editable = False
        Me.gvwProgramms.OptionsView.ColumnAutoWidth = False
        Me.gvwProgramms.OptionsView.ShowAutoFilterRow = True
        Me.gvwProgramms.OptionsView.ShowDetailButtons = False
        Me.gvwProgramms.OptionsView.ShowFilterPanel = False
        Me.gvwProgramms.OptionsView.ShowGroupPanel = False
        '
        'colProfile
        '
        Me.colProfile.Caption = "Nosaukums"
        Me.colProfile.FieldName = "Profile"
        Me.colProfile.Name = "colProfile"
        Me.colProfile.Visible = True
        Me.colProfile.VisibleIndex = 0
        Me.colProfile.Width = 118
        '
        'colPatient
        '
        Me.colPatient.Caption = "Klients"
        Me.colPatient.FieldName = "Patient"
        Me.colPatient.Name = "colPatient"
        Me.colPatient.Visible = True
        Me.colPatient.VisibleIndex = 1
        Me.colPatient.Width = 139
        '
        'colNumber
        '
        Me.colNumber.Caption = "Numurs"
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 2
        Me.colNumber.Width = 58
        '
        'colBeginDate
        '
        Me.colBeginDate.Caption = "Sākuma dat."
        Me.colBeginDate.FieldName = "BeginDate"
        Me.colBeginDate.Name = "colBeginDate"
        Me.colBeginDate.Visible = True
        Me.colBeginDate.VisibleIndex = 3
        Me.colBeginDate.Width = 82
        '
        'colEndDate
        '
        Me.colEndDate.Caption = "Beigu dat."
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.Name = "colEndDate"
        Me.colEndDate.Visible = True
        Me.colEndDate.VisibleIndex = 4
        Me.colEndDate.Width = 71
        '
        'colPrice
        '
        Me.colPrice.Caption = "Cena"
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 5
        Me.colPrice.Width = 45
        '
        'colPayDate
        '
        Me.colPayDate.Caption = "Apmaksas dat."
        Me.colPayDate.FieldName = "PayDate"
        Me.colPayDate.Name = "colPayDate"
        Me.colPayDate.Visible = True
        Me.colPayDate.VisibleIndex = 6
        Me.colPayDate.Width = 93
        '
        'colPaymentAcceptedByUser
        '
        Me.colPaymentAcceptedByUser.Caption = "Apmaksu pieņēma"
        Me.colPaymentAcceptedByUser.FieldName = "PaymentAcceptedByUser"
        Me.colPaymentAcceptedByUser.Name = "colPaymentAcceptedByUser"
        Me.colPaymentAcceptedByUser.Visible = True
        Me.colPaymentAcceptedByUser.VisibleIndex = 7
        Me.colPaymentAcceptedByUser.Width = 132
        '
        'colCreateDate
        '
        Me.colCreateDate.Caption = "Izveidošanas dat."
        Me.colCreateDate.FieldName = "CreateDate"
        Me.colCreateDate.Name = "colCreateDate"
        Me.colCreateDate.Visible = True
        Me.colCreateDate.VisibleIndex = 8
        Me.colCreateDate.Width = 108
        '
        'colCreateUser
        '
        Me.colCreateUser.Caption = "Izveidoja"
        Me.colCreateUser.FieldName = "CreateUser"
        Me.colCreateUser.Name = "colCreateUser"
        Me.colCreateUser.Visible = True
        Me.colCreateUser.VisibleIndex = 9
        Me.colCreateUser.Width = 101
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'frmPAKList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1015, 423)
        Me.Controls.Add(Me.grdProgramms)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmPAKList"
        Me.Text = "PAK"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.bndPatientProgramms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProgramms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwProgramms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents bndPatientProgramms As System.Windows.Forms.BindingSource
    Friend WithEvents grdProgramms As Core.UI.CoreGrid
    Friend WithEvents gvwProgramms As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colProfile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPatient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeginDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentAcceptedByUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateUser As DevExpress.XtraGrid.Columns.GridColumn

End Class
