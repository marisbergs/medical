<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNorikojumi
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPievienotNorikojumus = New System.Windows.Forms.Button()
        Me.btnNonemtNorikojumus = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnVisit = New System.Windows.Forms.Button()
        Me.btnPatientCard = New System.Windows.Forms.Button()
        Me.tabNorikojumi = New System.Windows.Forms.TabControl()
        Me.pagMainInformation = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VisitResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout
        Me.FlowLayoutPanel2.SuspendLayout
        Me.tabNorikojumi.SuspendLayout
        Me.pagMainInformation.SuspendLayout
        CType(Me.VisitResultBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = true
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPievienotNorikojumus)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNonemtNorikojumus)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(781, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnPievienotNorikojumus
        '
        Me.btnPievienotNorikojumus.AutoSize = true
        Me.btnPievienotNorikojumus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPievienotNorikojumus.Location = New System.Drawing.Point(3, 3)
        Me.btnPievienotNorikojumus.Name = "btnPievienotNorikojumus"
        Me.btnPievienotNorikojumus.Size = New System.Drawing.Size(116, 23)
        Me.btnPievienotNorikojumus.TabIndex = 0
        Me.btnPievienotNorikojumus.Text = "Pievienot norīkojumu"
        Me.btnPievienotNorikojumus.UseVisualStyleBackColor = true
        '
        'btnNonemtNorikojumus
        '
        Me.btnNonemtNorikojumus.AutoSize = true
        Me.btnNonemtNorikojumus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNonemtNorikojumus.Location = New System.Drawing.Point(125, 3)
        Me.btnNonemtNorikojumus.Name = "btnNonemtNorikojumus"
        Me.btnNonemtNorikojumus.Size = New System.Drawing.Size(109, 23)
        Me.btnNonemtNorikojumus.TabIndex = 1
        Me.btnNonemtNorikojumus.Text = "Noņemt norīkojumu"
        Me.btnNonemtNorikojumus.UseVisualStyleBackColor = true
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = true
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnVisit)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnPatientCard)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 288)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(781, 29)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.AutoSize = true
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.Location = New System.Drawing.Point(703, 3)
        Me.Button3.MinimumSize = New System.Drawing.Size(75, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Aizvērt"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.AutoSize = true
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(622, 3)
        Me.Button1.MinimumSize = New System.Drawing.Size(75, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Saglabāt"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.AutoSize = true
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Location = New System.Drawing.Point(532, 3)
        Me.Button2.MinimumSize = New System.Drawing.Size(75, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Asins analīzes"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'btnVisit
        '
        Me.btnVisit.AutoSize = true
        Me.btnVisit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVisit.Location = New System.Drawing.Point(451, 3)
        Me.btnVisit.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnVisit.Name = "btnVisit"
        Me.btnVisit.Size = New System.Drawing.Size(75, 23)
        Me.btnVisit.TabIndex = 5
        Me.btnVisit.Text = "Vizīte"
        Me.btnVisit.UseVisualStyleBackColor = true
        '
        'btnPatientCard
        '
        Me.btnPatientCard.AutoSize = true
        Me.btnPatientCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPatientCard.Location = New System.Drawing.Point(361, 3)
        Me.btnPatientCard.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnPatientCard.Name = "btnPatientCard"
        Me.btnPatientCard.Size = New System.Drawing.Size(84, 23)
        Me.btnPatientCard.TabIndex = 6
        Me.btnPatientCard.Text = "Klienta kartiņa"
        Me.btnPatientCard.UseVisualStyleBackColor = true
        '
        'tabNorikojumi
        '
        Me.tabNorikojumi.Controls.Add(Me.pagMainInformation)
        Me.tabNorikojumi.Location = New System.Drawing.Point(0, 29)
        Me.tabNorikojumi.Name = "tabNorikojumi"
        Me.tabNorikojumi.SelectedIndex = 0
        Me.tabNorikojumi.Size = New System.Drawing.Size(781, 259)
        Me.tabNorikojumi.TabIndex = 2
        '
        'pagMainInformation
        '
        Me.pagMainInformation.Controls.Add(Me.Label2)
        Me.pagMainInformation.Controls.Add(Me.CheckBox1)
        Me.pagMainInformation.Controls.Add(Me.TextBox1)
        Me.pagMainInformation.Controls.Add(Me.Label1)
        Me.pagMainInformation.Location = New System.Drawing.Point(4, 22)
        Me.pagMainInformation.Name = "pagMainInformation"
        Me.pagMainInformation.Size = New System.Drawing.Size(773, 233)
        Me.pagMainInformation.TabIndex = 0
        Me.pagMainInformation.Text = "Pamatinformācija"
        Me.pagMainInformation.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(8, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Asins analīzes nav nepieciešamas:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VisitResultBindingSource, "NotNeedBloodTest", true))
        Me.CheckBox1.Location = New System.Drawing.Point(185, 177)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitResultBindingSource, "Notes", true))
        Me.TextBox1.Location = New System.Drawing.Point(66, 7)
        Me.TextBox1.MaxLength = 3000
        Me.TextBox1.Multiline = true
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(704, 164)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Piezīmes:"
        '
        'VisitResultBindingSource
        '
        Me.VisitResultBindingSource.DataSource = GetType(Entities.VisitResult)
        '
        'frmNorikojumi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.ClientSize = New System.Drawing.Size(781, 317)
        Me.Controls.Add(Me.tabNorikojumi)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmNorikojumi"
        Me.Text = "Norīkojumi"
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        Me.FlowLayoutPanel2.ResumeLayout(false)
        Me.FlowLayoutPanel2.PerformLayout
        Me.tabNorikojumi.ResumeLayout(false)
        Me.pagMainInformation.ResumeLayout(false)
        Me.pagMainInformation.PerformLayout
        CType(Me.VisitResultBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnPievienotNorikojumus As System.Windows.Forms.Button
    Friend WithEvents btnNonemtNorikojumus As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tabNorikojumi As System.Windows.Forms.TabControl
    Friend WithEvents pagMainInformation As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents VisitResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnVisit As System.Windows.Forms.Button
    Friend WithEvents btnPatientCard As System.Windows.Forms.Button

End Class
