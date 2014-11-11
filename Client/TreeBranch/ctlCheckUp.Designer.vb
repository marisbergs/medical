<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlCheckUp
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panTemplates = New System.Windows.Forms.FlowLayoutPanel
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panTemplates
        '
        Me.panTemplates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTemplates.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panTemplates.Location = New System.Drawing.Point(0, 0)
        Me.panTemplates.Name = "panTemplates"
        Me.panTemplates.Size = New System.Drawing.Size(605, 389)
        Me.panTemplates.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnGenerate)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 389)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(605, 31)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(3, 3)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Ìenerēt"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'ctlCheckUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panTemplates)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "ctlCheckUp"
        Me.Size = New System.Drawing.Size(605, 420)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panTemplates As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnGenerate As System.Windows.Forms.Button

End Class
