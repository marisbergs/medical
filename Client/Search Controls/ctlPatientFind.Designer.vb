Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
'ёй
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPatientFind
    Inherits ctlFind

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        If DesignMode Then Return
        If DesignerDetector.IsComponentInDesignMode(Me) Then Return
        ' Dim coll As New Core.Bll.BusinessCollectionBase(Of Entities.Position)


        '        coll.CriteriaDelegate = AddressOf Entities.Position.ApplyCriteriaAsc
        '       coll.FetchWithCriteria()

        ' bindFindUsers.DataSource = so
        ' bindPositions.DataSource = coll

        ' If coll.Count > 0 Then
        ' so.Position = coll.Item(0)
        ' End If

    End Sub


    'UserControl overrides dispose to clean up the component list.
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
        Me.panTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.PeriodWithTimePicker = New Core.UI.PeriodWithTimePicker()
        Me.chkCreateDate = New System.Windows.Forms.CheckBox()
        Me.chkBirthDate = New System.Windows.Forms.CheckBox()
        Me.PeriodPicker = New Core.UI.PeriodPicker()
        Me.chkVisitDate = New System.Windows.Forms.CheckBox()
        Me.dtpVisitDate = New Core.UI.PeriodWithTimePicker()
        Me.chkDiagnoze = New System.Windows.Forms.CheckBox()
        Me.txtDiagnoze = New Client.ClassifierPicker()
        Me.txtPatientStatus = New System.Windows.Forms.TextBox()
        Me.chkPatientStatus = New System.Windows.Forms.CheckBox()
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.txtDiagnoze.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndFind
        '
        Me.bndFind.DataSource = GetType(Entities.FindPatients)
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(408, 3)
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(277, 3)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(489, 3)
        '
        'btnHideNonChecked
        '
        Me.btnHideNonChecked.Location = New System.Drawing.Point(129, 3)
        '
        'panTableLayout
        '
        Me.panTableLayout.AutoSize = True
        Me.panTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panTableLayout.ColumnCount = 2
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panTableLayout.Controls.Add(Me.PeriodWithTimePicker, 1, 8)
        Me.panTableLayout.Controls.Add(Me.chkCreateDate, 0, 8)
        Me.panTableLayout.Controls.Add(Me.chkBirthDate, 0, 5)
        Me.panTableLayout.Controls.Add(Me.PeriodPicker, 1, 5)
        Me.panTableLayout.Controls.Add(Me.txtPatientStatus, 1, 4)
        Me.panTableLayout.Controls.Add(Me.chkPatientStatus, 0, 4)
        Me.panTableLayout.Controls.Add(Me.chkVisitDate, 0, 9)
        Me.panTableLayout.Controls.Add(Me.dtpVisitDate, 1, 9)
        Me.panTableLayout.Controls.Add(Me.chkDiagnoze, 0, 12)
        Me.panTableLayout.Controls.Add(Me.txtDiagnoze, 1, 12)
        Me.panTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.panTableLayout.Name = "panTableLayout"
        Me.panTableLayout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.panTableLayout.RowCount = 14
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.Size = New System.Drawing.Size(662, 314)
        Me.panTableLayout.TabIndex = 2
        '
        'PeriodWithTimePicker
        '
        Me.PeriodWithTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PeriodWithTimePicker.AutoSize = True
        Me.PeriodWithTimePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PeriodWithTimePicker.Location = New System.Drawing.Point(111, 55)
        Me.PeriodWithTimePicker.Name = "PeriodWithTimePicker"
        Me.PeriodWithTimePicker.Size = New System.Drawing.Size(539, 20)
        Me.PeriodWithTimePicker.TabIndex = 181
        '
        'chkCreateDate
        '
        Me.chkCreateDate.AutoSize = True
        Me.chkCreateDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCreateDate.Location = New System.Drawing.Point(3, 55)
        Me.chkCreateDate.Name = "chkCreateDate"
        Me.chkCreateDate.Size = New System.Drawing.Size(102, 20)
        Me.chkCreateDate.TabIndex = 182
        Me.chkCreateDate.Text = "Izveides datums"
        Me.chkCreateDate.UseVisualStyleBackColor = True
        '
        'chkBirthDate
        '
        Me.chkBirthDate.AutoSize = True
        Me.chkBirthDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkBirthDate.Location = New System.Drawing.Point(3, 29)
        Me.chkBirthDate.Name = "chkBirthDate"
        Me.chkBirthDate.Size = New System.Drawing.Size(102, 20)
        Me.chkBirthDate.TabIndex = 185
        Me.chkBirthDate.Text = "Dzimš. datums:"
        Me.chkBirthDate.UseVisualStyleBackColor = True
        '
        'PeriodPicker
        '
        Me.PeriodPicker.AutoSize = True
        Me.PeriodPicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PeriodPicker.Location = New System.Drawing.Point(111, 29)
        Me.PeriodPicker.Name = "PeriodPicker"
        Me.PeriodPicker.Size = New System.Drawing.Size(225, 20)
        Me.PeriodPicker.TabIndex = 187
        '
        'chkVisitDate
        '
        Me.chkVisitDate.AutoSize = True
        Me.chkVisitDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkVisitDate.Location = New System.Drawing.Point(3, 81)
        Me.chkVisitDate.Name = "chkVisitDate"
        Me.chkVisitDate.Size = New System.Drawing.Size(102, 20)
        Me.chkVisitDate.TabIndex = 192
        Me.chkVisitDate.Text = "Vizītes datums:"
        Me.chkVisitDate.UseVisualStyleBackColor = True
        '
        'dtpVisitDate
        '
        Me.dtpVisitDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpVisitDate.AutoSize = True
        Me.dtpVisitDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.dtpVisitDate.Location = New System.Drawing.Point(111, 81)
        Me.dtpVisitDate.Name = "dtpVisitDate"
        Me.dtpVisitDate.Size = New System.Drawing.Size(539, 20)
        Me.dtpVisitDate.TabIndex = 193
        '
        'chkDiagnoze
        '
        Me.chkDiagnoze.AutoSize = True
        Me.chkDiagnoze.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDiagnoze.Location = New System.Drawing.Point(3, 107)
        Me.chkDiagnoze.Name = "chkDiagnoze"
        Me.chkDiagnoze.Size = New System.Drawing.Size(102, 20)
        Me.chkDiagnoze.TabIndex = 194
        Me.chkDiagnoze.Text = "Diagnoze:"
        Me.chkDiagnoze.UseVisualStyleBackColor = True
        '
        'txtDiagnoze
        '
        Me.txtDiagnoze.AllowDrop = True
        Me.txtDiagnoze.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDiagnoze.Location = New System.Drawing.Point(111, 107)
        Me.txtDiagnoze.Name = "txtDiagnoze"
        Me.txtDiagnoze.PickerPresets = Nothing
        Me.txtDiagnoze.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDiagnoze.Properties.ReadOnly = True
        Me.txtDiagnoze.Size = New System.Drawing.Size(539, 20)
        Me.txtDiagnoze.TabIndex = 195
        '
        'txtPatientStatus
        '
        Me.txtPatientStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatientStatus.Location = New System.Drawing.Point(111, 3)
        Me.txtPatientStatus.Name = "txtPatientStatus"
        Me.txtPatientStatus.Size = New System.Drawing.Size(539, 20)
        Me.txtPatientStatus.TabIndex = 189
        '
        'chkPatientStatus
        '
        Me.chkPatientStatus.AutoSize = True
        Me.chkPatientStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkPatientStatus.Location = New System.Drawing.Point(3, 3)
        Me.chkPatientStatus.Name = "chkPatientStatus"
        Me.chkPatientStatus.Size = New System.Drawing.Size(102, 20)
        Me.chkPatientStatus.TabIndex = 188
        Me.chkPatientStatus.Text = "Statuss:"
        Me.chkPatientStatus.UseVisualStyleBackColor = True
        '
        'ctlPatientFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.Name = "ctlPatientFind"
        Me.Size = New System.Drawing.Size(662, 344)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.txtDiagnoze.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeriodWithTimePicker As Core.UI.PeriodWithTimePicker
    Friend WithEvents chkCreateDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkBirthDate As System.Windows.Forms.CheckBox
    Friend WithEvents PeriodPicker As Core.UI.PeriodPicker
    Friend WithEvents chkVisitDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpVisitDate As Core.UI.PeriodWithTimePicker
    Friend WithEvents chkDiagnoze As System.Windows.Forms.CheckBox
    Friend WithEvents txtDiagnoze As Client.ClassifierPicker
    Friend WithEvents txtPatientStatus As System.Windows.Forms.TextBox
    Friend WithEvents chkPatientStatus As System.Windows.Forms.CheckBox

End Class
