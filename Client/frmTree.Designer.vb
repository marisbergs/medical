<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTree
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vispārīgā informācija")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ginekoloģija")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pediatrija")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Terapija")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTG")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Klienta profili", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kontakti")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ieplānotās vizītes")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Veiktās vizītes")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nosûtījumi")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Receptes")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pievienotie dokumenti")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Check-up")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Klienta kartes")
        Me.cmsNewRtgSummary = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsNewVisit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsNewPrescription = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itmNew = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsNewAttachment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.trvList = New System.Windows.Forms.TreeView
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.panControls = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.btnSinchronization = New System.Windows.Forms.Button
        Me.cmsPatientCards = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itmPatientDentistCard = New System.Windows.Forms.ToolStripMenuItem
        Me.bndPatient = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmsNewRtgSummary.SuspendLayout()
        Me.cmsNewVisit.SuspendLayout()
        Me.cmsNewPrescription.SuspendLayout()
        Me.cmsNewAttachment.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.cmsPatientCards.SuspendLayout()
        CType(Me.bndPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmsNewRtgSummary
        '
        Me.cmsNewRtgSummary.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.cmsNewRtgSummary.Name = "comNew"
        Me.cmsNewRtgSummary.Size = New System.Drawing.Size(130, 26)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem3.Text = "Pievienot"
        '
        'cmsNewVisit
        '
        Me.cmsNewVisit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmsNewVisit.Name = "comNew"
        Me.cmsNewVisit.Size = New System.Drawing.Size(130, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem1.Text = "Pievienot"
        '
        'cmsNewPrescription
        '
        Me.cmsNewPrescription.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmNew})
        Me.cmsNewPrescription.Name = "comNew"
        Me.cmsNewPrescription.Size = New System.Drawing.Size(130, 26)
        '
        'itmNew
        '
        Me.itmNew.Name = "itmNew"
        Me.itmNew.Size = New System.Drawing.Size(129, 22)
        Me.itmNew.Text = "Pievienot"
        '
        'cmsNewAttachment
        '
        Me.cmsNewAttachment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.cmsNewAttachment.Name = "comNew"
        Me.cmsNewAttachment.Size = New System.Drawing.Size(130, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem2.Text = "Pievienot"
        '
        'trvList
        '
        Me.trvList.Dock = System.Windows.Forms.DockStyle.Left
        Me.trvList.FullRowSelect = True
        Me.trvList.HideSelection = False
        Me.trvList.Location = New System.Drawing.Point(0, 0)
        Me.trvList.Name = "trvList"
        TreeNode1.Name = "nodDefault"
        TreeNode1.Text = "Vispārīgā informācija"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Ginekoloģija"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Pediatrija"
        TreeNode4.Name = "Node4"
        TreeNode4.Text = "Terapija"
        TreeNode5.ContextMenuStrip = Me.cmsNewRtgSummary
        TreeNode5.Name = "nodRtg"
        TreeNode5.Text = "RTG"
        TreeNode6.Name = "Node1"
        TreeNode6.Text = "Klienta profili"
        TreeNode7.Name = "nodContacts"
        TreeNode7.Text = "Kontakti"
        TreeNode8.ContextMenuStrip = Me.cmsNewVisit
        TreeNode8.Name = "nodNewVisits"
        TreeNode8.Text = "Ieplānotās vizītes"
        TreeNode9.Name = "nodPreviousVisits"
        TreeNode9.Text = "Veiktās vizītes"
        TreeNode10.Name = "nodRefer"
        TreeNode10.Text = "Nosûtījumi"
        TreeNode11.ContextMenuStrip = Me.cmsNewPrescription
        TreeNode11.Name = "nodPrescription"
        TreeNode11.Text = "Receptes"
        TreeNode12.ContextMenuStrip = Me.cmsNewAttachment
        TreeNode12.Name = "nodAttachments"
        TreeNode12.Text = "Pievienotie dokumenti"
        TreeNode13.Name = "nodCheckUp"
        TreeNode13.Text = "Check-up"
        TreeNode14.Checked = True
        TreeNode14.ContextMenuStrip = Me.cmsPatientCards
        TreeNode14.Name = "nodPatientCard"
        TreeNode14.Text = "Klienta kartes"
        Me.trvList.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Me.trvList.Size = New System.Drawing.Size(181, 586)
        Me.trvList.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(239, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(320, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'panControls
        '
        Me.panControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panControls.Location = New System.Drawing.Point(181, 0)
        Me.panControls.Name = "panControls"
        Me.panControls.Size = New System.Drawing.Size(811, 557)
        Me.panControls.TabIndex = 5
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(398, 29)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(181, 557)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(811, 29)
        Me.SplitContainer1.SplitterDistance = 409
        Me.SplitContainer1.TabIndex = 7
        Me.SplitContainer1.TabStop = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnGenerate)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSinchronization)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(409, 29)
        Me.FlowLayoutPanel2.TabIndex = 8
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(84, 3)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Ìenerēt"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnSinchronization
        '
        Me.btnSinchronization.AutoSize = True
        Me.btnSinchronization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSinchronization.Location = New System.Drawing.Point(165, 3)
        Me.btnSinchronization.Name = "btnSinchronization"
        Me.btnSinchronization.Size = New System.Drawing.Size(90, 23)
        Me.btnSinchronization.TabIndex = 5
        Me.btnSinchronization.Text = "Nosûtīt uz EEG"
        Me.btnSinchronization.UseVisualStyleBackColor = True
        '
        'cmsPatientCards
        '
        Me.cmsPatientCards.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmPatientDentistCard})
        Me.cmsPatientCards.Name = "cmsPatientCards"
        Me.cmsPatientCards.Size = New System.Drawing.Size(231, 26)
        '
        'itmPatientDentistCard
        '
        Me.itmPatientDentistCard.Name = "itmPatientDentistCard"
        Me.itmPatientDentistCard.Size = New System.Drawing.Size(230, 22)
        Me.itmPatientDentistCard.Text = "Pievienot zobārstniecības karti"
        '
        'bndPatient
        '
        Me.bndPatient.DataSource = GetType(Entities.Patient)
        '
        'frmTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 586)
        Me.Controls.Add(Me.panControls)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.trvList)
        Me.MinimumSize = New System.Drawing.Size(1000, 620)
        Me.Name = "frmTree"
        Me.Text = "Klients"
        Me.cmsNewRtgSummary.ResumeLayout(False)
        Me.cmsNewVisit.ResumeLayout(False)
        Me.cmsNewPrescription.ResumeLayout(False)
        Me.cmsNewAttachment.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.cmsPatientCards.ResumeLayout(False)
        CType(Me.bndPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvList As System.Windows.Forms.TreeView
    Friend WithEvents bndPatient As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents panControls As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents cmsNewPrescription As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itmNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsNewVisit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSinchronization As System.Windows.Forms.Button
    Friend WithEvents cmsNewAttachment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsNewRtgSummary As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPatientCards As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itmPatientDentistCard As System.Windows.Forms.ToolStripMenuItem

End Class
