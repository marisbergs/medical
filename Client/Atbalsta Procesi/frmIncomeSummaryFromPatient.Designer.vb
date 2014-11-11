<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeSummaryFromPatient
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
        Me.dtpFrom = New DevExpress.XtraEditors.DateEdit()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ŠodienaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VakardienaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ŠonedēļToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagājušāNedēļaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjušoMēnesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtInsurance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBonusPoints = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProgramm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPresentCard = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubscription = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPAK = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransfer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dtpFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dtpTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFrom
        '
        Me.dtpFrom.EditValue = Nothing
        Me.dtpFrom.Location = New System.Drawing.Point(76, 12)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpFrom.Properties.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtpFrom.Size = New System.Drawing.Size(100, 20)
        Me.dtpFrom.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ŠodienaToolStripMenuItem, Me.VakardienaToolStripMenuItem, Me.ŠonedēļToolStripMenuItem, Me.PagājušāNedēļaToolStripMenuItem, Me.PagToolStripMenuItem, Me.AjušoMēnesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 136)
        '
        'ŠodienaToolStripMenuItem
        '
        Me.ŠodienaToolStripMenuItem.Name = "ŠodienaToolStripMenuItem"
        Me.ŠodienaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ŠodienaToolStripMenuItem.Text = "Šodiena"
        '
        'VakardienaToolStripMenuItem
        '
        Me.VakardienaToolStripMenuItem.Name = "VakardienaToolStripMenuItem"
        Me.VakardienaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.VakardienaToolStripMenuItem.Text = "Vakardiena"
        '
        'ŠonedēļToolStripMenuItem
        '
        Me.ŠonedēļToolStripMenuItem.Name = "ŠonedēļToolStripMenuItem"
        Me.ŠonedēļToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ŠonedēļToolStripMenuItem.Text = "Šonedēļ"
        '
        'PagājušāNedēļaToolStripMenuItem
        '
        Me.PagājušāNedēļaToolStripMenuItem.Name = "PagājušāNedēļaToolStripMenuItem"
        Me.PagājušāNedēļaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PagājušāNedēļaToolStripMenuItem.Text = "Pagājušā nedēļa"
        '
        'PagToolStripMenuItem
        '
        Me.PagToolStripMenuItem.Name = "PagToolStripMenuItem"
        Me.PagToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PagToolStripMenuItem.Text = "Šomēnes"
        '
        'AjušoMēnesToolStripMenuItem
        '
        Me.AjušoMēnesToolStripMenuItem.Name = "AjušoMēnesToolStripMenuItem"
        Me.AjušoMēnesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AjušoMēnesToolStripMenuItem.Text = "Pagājušo mēnes"
        '
        'dtpTo
        '
        Me.dtpTo.EditValue = Nothing
        Me.dtpTo.Location = New System.Drawing.Point(218, 12)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpTo.Properties.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtpTo.Size = New System.Drawing.Size(100, 20)
        Me.dtpTo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periods no:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Līdz:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(324, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Atlasīt"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(323, 222)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Skaidrā nauda:"
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(97, 50)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.ReadOnly = True
        Me.txtCash.Size = New System.Drawing.Size(100, 20)
        Me.txtCash.TabIndex = 8
        '
        'txtInsurance
        '
        Me.txtInsurance.Location = New System.Drawing.Point(97, 76)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.ReadOnly = True
        Me.txtInsurance.Size = New System.Drawing.Size(100, 20)
        Me.txtInsurance.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Apdrošināšana:"
        '
        'txtBonusPoints
        '
        Me.txtBonusPoints.Location = New System.Drawing.Point(97, 102)
        Me.txtBonusPoints.Name = "txtBonusPoints"
        Me.txtBonusPoints.ReadOnly = True
        Me.txtBonusPoints.Size = New System.Drawing.Size(100, 20)
        Me.txtBonusPoints.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Bonusa punkti:"
        '
        'txtProgramm
        '
        Me.txtProgramm.Location = New System.Drawing.Point(97, 128)
        Me.txtProgramm.Name = "txtProgramm"
        Me.txtProgramm.ReadOnly = True
        Me.txtProgramm.Size = New System.Drawing.Size(100, 20)
        Me.txtProgramm.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Programmas:"
        '
        'txtPresentCard
        '
        Me.txtPresentCard.Location = New System.Drawing.Point(97, 154)
        Me.txtPresentCard.Name = "txtPresentCard"
        Me.txtPresentCard.ReadOnly = True
        Me.txtPresentCard.Size = New System.Drawing.Size(100, 20)
        Me.txtPresentCard.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Dāvanu kartes:"
        '
        'txtSubscription
        '
        Me.txtSubscription.Location = New System.Drawing.Point(97, 180)
        Me.txtSubscription.Name = "txtSubscription"
        Me.txtSubscription.ReadOnly = True
        Me.txtSubscription.Size = New System.Drawing.Size(100, 20)
        Me.txtSubscription.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Abonementi:"
        '
        'txtPAK
        '
        Me.txtPAK.Location = New System.Drawing.Point(97, 206)
        Me.txtPAK.Name = "txtPAK"
        Me.txtPAK.ReadOnly = True
        Me.txtPAK.Size = New System.Drawing.Size(100, 20)
        Me.txtPAK.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "PAK:"
        '
        'txtSummary
        '
        Me.txtSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummary.Location = New System.Drawing.Point(268, 50)
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.ReadOnly = True
        Me.txtSummary.Size = New System.Drawing.Size(100, 20)
        Me.txtSummary.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(214, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "KOPĀ:"
        '
        'txtTransfer
        '
        Me.txtTransfer.Location = New System.Drawing.Point(97, 232)
        Me.txtTransfer.Name = "txtTransfer"
        Me.txtTransfer.ReadOnly = True
        Me.txtTransfer.Size = New System.Drawing.Size(100, 20)
        Me.txtTransfer.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Pārskaitījums:"
        '
        'frmIncomeSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(410, 257)
        Me.Controls.Add(Me.txtTransfer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPAK)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSummary)
        Me.Controls.Add(Me.txtSubscription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPresentCard)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProgramm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBonusPoints)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInsurance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpTo)
        Me.Name = "frmIncomeSummary"
        Me.Text = "Ieņēmumu kopsavilkums"
        CType(Me.dtpFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dtpTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ŠodienaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VakardienaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ŠonedēļToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagājušāNedēļaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjušoMēnesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtInsurance As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBonusPoints As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProgramm As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPresentCard As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSubscription As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPAK As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSummary As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTransfer As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
