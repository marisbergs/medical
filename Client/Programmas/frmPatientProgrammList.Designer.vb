<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientProgrammList
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grdProgramms = New Core.UI.CoreGrid()
        Me.bndPatientProgramms = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwProgramms = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPatient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgrammTemplate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsageStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgrammIsLock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.grdProgramms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPatientProgramms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwProgramms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 436)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(992, 30)
        Me.SplitContainer1.SplitterDistance = 495
        Me.SplitContainer1.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(495, 30)
        Me.FlowLayoutPanel2.TabIndex = 0
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
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(84, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(165, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(493, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(415, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grdProgramms
        '
        Me.grdProgramms.DataSource = Me.bndPatientProgramms
        Me.grdProgramms.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdProgramms.EmbeddedNavigator.Name = ""
        Me.grdProgramms.EnforceCanEdit = False
        Me.grdProgramms.Location = New System.Drawing.Point(0, 0)
        Me.grdProgramms.MainView = Me.gvwProgramms
        Me.grdProgramms.Name = "grdProgramms"
        Me.grdProgramms.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdProgramms.ShowOnlyActive = False
        Me.grdProgramms.Size = New System.Drawing.Size(992, 436)
        Me.grdProgramms.TabIndex = 2
        Me.grdProgramms.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwProgramms})
        '
        'bndPatientProgramms
        '
        Me.bndPatientProgramms.DataSource = GetType(Entities.PatientProgramm)
        '
        'gvwProgramms
        '
        Me.gvwProgramms.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPatient, Me.colPrice, Me.colProgrammTemplate, Me.colUsageStatus, Me.colPaymentStatus, Me.colPaymentDay, Me.colProgrammIsLock, Me.colNotes})
        Me.gvwProgramms.GridControl = Me.grdProgramms
        Me.gvwProgramms.Name = "gvwProgramms"
        Me.gvwProgramms.OptionsBehavior.Editable = False
        Me.gvwProgramms.OptionsView.ColumnAutoWidth = False
        Me.gvwProgramms.OptionsView.ShowAutoFilterRow = True
        Me.gvwProgramms.OptionsView.ShowDetailButtons = False
        Me.gvwProgramms.OptionsView.ShowFilterPanel = False
        Me.gvwProgramms.OptionsView.ShowGroupPanel = False
        '
        'colPatient
        '
        Me.colPatient.Caption = "Klients"
        Me.colPatient.FieldName = "Patient"
        Me.colPatient.Name = "colPatient"
        Me.colPatient.Visible = True
        Me.colPatient.VisibleIndex = 0
        Me.colPatient.Width = 201
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
        Me.colPrice.Width = 47
        '
        'colProgrammTemplate
        '
        Me.colProgrammTemplate.Caption = "Programma"
        Me.colProgrammTemplate.FieldName = "ProgrammTemplate"
        Me.colProgrammTemplate.Name = "colProgrammTemplate"
        Me.colProgrammTemplate.Visible = True
        Me.colProgrammTemplate.VisibleIndex = 1
        Me.colProgrammTemplate.Width = 244
        '
        'colUsageStatus
        '
        Me.colUsageStatus.Caption = "Izmantots"
        Me.colUsageStatus.FieldName = "UsageStatus"
        Me.colUsageStatus.Name = "colUsageStatus"
        Me.colUsageStatus.Visible = True
        Me.colUsageStatus.VisibleIndex = 3
        Me.colUsageStatus.Width = 98
        '
        'colPaymentStatus
        '
        Me.colPaymentStatus.Caption = "Apmaksa"
        Me.colPaymentStatus.FieldName = "PaymentStatus"
        Me.colPaymentStatus.Name = "colPaymentStatus"
        Me.colPaymentStatus.Visible = True
        Me.colPaymentStatus.VisibleIndex = 4
        Me.colPaymentStatus.Width = 96
        '
        'colPaymentDay
        '
        Me.colPaymentDay.Caption = "Apmaksas datums"
        Me.colPaymentDay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPaymentDay.FieldName = "PaymentDate"
        Me.colPaymentDay.Name = "colPaymentDay"
        Me.colPaymentDay.Visible = True
        Me.colPaymentDay.VisibleIndex = 5
        Me.colPaymentDay.Width = 108
        '
        'colProgrammIsLock
        '
        Me.colProgrammIsLock.Caption = "Programma slēgta"
        Me.colProgrammIsLock.FieldName = "ProgrammIsLock"
        Me.colProgrammIsLock.Name = "colProgrammIsLock"
        Me.colProgrammIsLock.Visible = True
        Me.colProgrammIsLock.VisibleIndex = 6
        Me.colProgrammIsLock.Width = 108
        '
        'colNotes
        '
        Me.colNotes.Caption = "Piezīmes"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 7
        Me.colNotes.Width = 156
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'frmPatientProgrammList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 466)
        Me.Controls.Add(Me.grdProgramms)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "frmPatientProgrammList"
        Me.Text = "Programmu saraksts"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.grdProgramms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPatientProgramms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwProgramms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grdProgramms As Core.UI.CoreGrid
    Friend WithEvents gvwProgramms As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndPatientProgramms As System.Windows.Forms.BindingSource
    Friend WithEvents colPatient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgrammTemplate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsageStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgrammIsLock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

End Class
