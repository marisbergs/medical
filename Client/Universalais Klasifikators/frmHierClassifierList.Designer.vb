<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHierClassifierList
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
        Me.trvHierClassifier = New Core.UI.CoreTreeView(Me.components)
        Me.bndClassifier = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbRootNode = New System.Windows.Forms.ComboBox()
        Me.chkSelectActive = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkRootNode = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkShowComments = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.bndClassifier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'trvHierClassifier
        '
        Me.trvHierClassifier.DataSource = Me.bndClassifier
        Me.trvHierClassifier.DisplayMember = "ShowMode"
        Me.trvHierClassifier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvHierClassifier.Location = New System.Drawing.Point(0, 72)
        Me.trvHierClassifier.Name = "trvHierClassifier"
        Me.trvHierClassifier.ParentMember = "Parents.Id"
        Me.trvHierClassifier.SelectedMember = "Selected"
        Me.trvHierClassifier.Size = New System.Drawing.Size(522, 286)
        Me.trvHierClassifier.TabIndex = 2
        Me.trvHierClassifier.UseAsParent = "FirstRecord"
        Me.trvHierClassifier.ValueMember = "Id"
        '
        'bndClassifier
        '
        Me.bndClassifier.DataSource = GetType(Entities.HierClassifier)
        '
        'cmbRootNode
        '
        Me.cmbRootNode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRootNode.DataSource = Me.bndClassifier
        Me.cmbRootNode.DisplayMember = "Value"
        Me.cmbRootNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRootNode.Enabled = False
        Me.cmbRootNode.FormattingEnabled = True
        Me.cmbRootNode.Location = New System.Drawing.Point(28, 3)
        Me.cmbRootNode.Name = "cmbRootNode"
        Me.cmbRootNode.Size = New System.Drawing.Size(491, 21)
        Me.cmbRootNode.TabIndex = 2
        Me.cmbRootNode.ValueMember = "Id"
        '
        'chkSelectActive
        '
        Me.chkSelectActive.AutoSize = True
        Me.chkSelectActive.Checked = True
        Me.chkSelectActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSelectActive.Location = New System.Drawing.Point(7, 30)
        Me.chkSelectActive.Name = "chkSelectActive"
        Me.chkSelectActive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSelectActive.Size = New System.Drawing.Size(89, 17)
        Me.chkSelectActive.TabIndex = 1
        Me.chkSelectActive.Text = "Tikai aktuālie"
        Me.chkSelectActive.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOK)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnActivate)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(411, 34)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.AutoSize = True
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "Labi"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(84, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Pievienot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(165, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Atvērt"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(246, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.AutoSize = True
        Me.btnActivate.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndClassifier, "CanActivate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActivate.Location = New System.Drawing.Point(327, 3)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(75, 23)
        Me.btnActivate.TabIndex = 12
        Me.btnActivate.Text = "Atjaunot"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.Location = New System.Drawing.Point(33, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkRootNode
        '
        Me.chkRootNode.AutoSize = True
        Me.chkRootNode.Location = New System.Drawing.Point(7, 6)
        Me.chkRootNode.Name = "chkRootNode"
        Me.chkRootNode.Size = New System.Drawing.Size(15, 14)
        Me.chkRootNode.TabIndex = 3
        Me.chkRootNode.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.chkShowComments)
        Me.Panel1.Controls.Add(Me.chkSelectActive)
        Me.Panel1.Controls.Add(Me.cmbRootNode)
        Me.Panel1.Controls.Add(Me.chkRootNode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 72)
        Me.Panel1.TabIndex = 8
        '
        'chkShowComments
        '
        Me.chkShowComments.AutoSize = True
        Me.chkShowComments.Checked = True
        Me.chkShowComments.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowComments.Location = New System.Drawing.Point(7, 52)
        Me.chkShowComments.Name = "chkShowComments"
        Me.chkShowComments.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShowComments.Size = New System.Drawing.Size(96, 17)
        Me.chkShowComments.TabIndex = 4
        Me.chkShowComments.Text = "Rādīt piezīmes"
        Me.chkShowComments.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(411, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(111, 34)
        Me.FlowLayoutPanel3.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 358)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(522, 34)
        Me.Panel2.TabIndex = 9
        '
        'frmHierClassifierList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 392)
        Me.Controls.Add(Me.trvHierClassifier)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(530, 419)
        Me.Name = "frmHierClassifierList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hierarhiskais klasifikators"
        CType(Me.bndClassifier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trvHierClassifier As Core.UI.CoreTreeView
    Friend WithEvents bndClassifier As System.Windows.Forms.BindingSource
    Friend WithEvents chkSelectActive As System.Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cmbRootNode As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents chkRootNode As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkShowComments As System.Windows.Forms.CheckBox
End Class
