<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesList
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
        Me.grdData = New Core.UI.CoreGrid()
        Me.SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPatient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.DataSource = Me.SaleBindingSource
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdData.EmbeddedNavigator.Name = ""
        Me.grdData.EnforceCanEdit = False
        Me.grdData.Location = New System.Drawing.Point(0, 0)
        Me.grdData.MainView = Me.gvwData
        Me.grdData.Name = "grdData"
        Me.grdData.ShowOnlyActive = False
        Me.grdData.Size = New System.Drawing.Size(795, 321)
        Me.grdData.TabIndex = 0
        Me.grdData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwData})
        '
        'SaleBindingSource
        '
        Me.SaleBindingSource.DataSource = GetType(Entities.Sale)
        '
        'gvwData
        '
        Me.gvwData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPatient, Me.colPaymentDate, Me.colPaymentUser, Me.colNotes})
        Me.gvwData.GridControl = Me.grdData
        Me.gvwData.Name = "gvwData"
        Me.gvwData.OptionsBehavior.Editable = False
        Me.gvwData.OptionsView.ShowAutoFilterRow = True
        Me.gvwData.OptionsView.ShowDetailButtons = False
        Me.gvwData.OptionsView.ShowFilterPanel = False
        Me.gvwData.OptionsView.ShowGroupPanel = False
        '
        'colPatient
        '
        Me.colPatient.Caption = "Klients"
        Me.colPatient.FieldName = "Patient"
        Me.colPatient.Name = "colPatient"
        Me.colPatient.Visible = True
        Me.colPatient.VisibleIndex = 0
        '
        'colPaymentDate
        '
        Me.colPaymentDate.Caption = "Apmaksas datums"
        Me.colPaymentDate.FieldName = "PaymentDate"
        Me.colPaymentDate.Name = "colPaymentDate"
        Me.colPaymentDate.Visible = True
        Me.colPaymentDate.VisibleIndex = 1
        '
        'colPaymentUser
        '
        Me.colPaymentUser.Caption = "Apmaksu pieņēma"
        Me.colPaymentUser.FieldName = "PaymentUser"
        Me.colPaymentUser.Name = "colPaymentUser"
        Me.colPaymentUser.Visible = True
        Me.colPaymentUser.VisibleIndex = 2
        '
        'colNotes
        '
        Me.colNotes.Caption = "Piezīmes"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(401, 28)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(3, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(69, 23)
        Me.btnOpen.TabIndex = 6
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Location = New System.Drawing.Point(78, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(69, 23)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "Jauns"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(153, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(69, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 321)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(795, 28)
        Me.SplitContainer1.SplitterDistance = 401
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(390, 28)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(318, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSalesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(795, 349)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmSalesList"
        Me.Text = "Pārdošana"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdData As Core.UI.CoreGrid
    Friend WithEvents gvwData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPatient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class
