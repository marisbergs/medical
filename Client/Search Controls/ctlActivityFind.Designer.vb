Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
'ёй
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlActivityFind
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
        Me.components = New System.ComponentModel.Container
        Me.panTableLayout = New System.Windows.Forms.TableLayoutPanel
        Me.chkPatientName = New System.Windows.Forms.CheckBox
        Me.chkPatientSurname = New System.Windows.Forms.CheckBox
        Me.txtPatientName = New System.Windows.Forms.TextBox
        Me.txtPatientSurname = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtUserSurname = New System.Windows.Forms.TextBox
        Me.chkUserName = New System.Windows.Forms.CheckBox
        Me.chkUserSurname = New System.Windows.Forms.CheckBox
        Me.chkService = New System.Windows.Forms.CheckBox
        Me.txtService = New Client.ClassifierPicker
        Me.chkActivityDate = New System.Windows.Forms.CheckBox
        Me.chkRemindDate = New System.Windows.Forms.CheckBox
        Me.bndIsSystemUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpActivityDate = New Core.UI.PeriodWithTimePicker
        Me.dtpRemindDate = New Core.UI.PeriodWithTimePicker
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndIsSystemUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndFind
        '
        Me.bndFind.DataSource = GetType(Entities.FindUsers)
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(306, 3)
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(175, 3)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(387, 3)
        '
        'btnHideNonChecked
        '
        Me.btnHideNonChecked.Location = New System.Drawing.Point(27, 3)
        '
        'panTableLayout
        '
        Me.panTableLayout.AutoSize = True
        Me.panTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panTableLayout.ColumnCount = 2
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.panTableLayout.Controls.Add(Me.chkPatientName, 0, 0)
        Me.panTableLayout.Controls.Add(Me.chkPatientSurname, 0, 1)
        Me.panTableLayout.Controls.Add(Me.txtPatientName, 1, 0)
        Me.panTableLayout.Controls.Add(Me.txtPatientSurname, 1, 1)
        Me.panTableLayout.Controls.Add(Me.txtUserName, 1, 2)
        Me.panTableLayout.Controls.Add(Me.txtUserSurname, 1, 3)
        Me.panTableLayout.Controls.Add(Me.chkUserName, 0, 2)
        Me.panTableLayout.Controls.Add(Me.chkUserSurname, 0, 3)
        Me.panTableLayout.Controls.Add(Me.chkService, 0, 4)
        Me.panTableLayout.Controls.Add(Me.txtService, 1, 4)
        Me.panTableLayout.Controls.Add(Me.chkActivityDate, 0, 6)
        Me.panTableLayout.Controls.Add(Me.dtpActivityDate, 1, 6)
        Me.panTableLayout.Controls.Add(Me.chkRemindDate, 0, 7)
        Me.panTableLayout.Controls.Add(Me.dtpRemindDate, 1, 7)
        Me.panTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.panTableLayout.Name = "panTableLayout"
        Me.panTableLayout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.panTableLayout.RowCount = 14
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.Size = New System.Drawing.Size(560, 182)
        Me.panTableLayout.TabIndex = 2
        '
        'chkPatientName
        '
        Me.chkPatientName.AutoSize = True
        Me.chkPatientName.Location = New System.Drawing.Point(3, 3)
        Me.chkPatientName.Name = "chkPatientName"
        Me.chkPatientName.Size = New System.Drawing.Size(90, 17)
        Me.chkPatientName.TabIndex = 174
        Me.chkPatientName.Text = "Klienta vārds:"
        Me.chkPatientName.UseVisualStyleBackColor = True
        '
        'chkPatientSurname
        '
        Me.chkPatientSurname.AutoSize = True
        Me.chkPatientSurname.Location = New System.Drawing.Point(3, 29)
        Me.chkPatientSurname.Name = "chkPatientSurname"
        Me.chkPatientSurname.Size = New System.Drawing.Size(101, 17)
        Me.chkPatientSurname.TabIndex = 175
        Me.chkPatientSurname.Text = "Klienta uzvārds:"
        Me.chkPatientSurname.UseVisualStyleBackColor = True
        '
        'txtPatientName
        '
        Me.txtPatientName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatientName.Location = New System.Drawing.Point(139, 3)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(403, 20)
        Me.txtPatientName.TabIndex = 176
        '
        'txtPatientSurname
        '
        Me.txtPatientSurname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatientSurname.Location = New System.Drawing.Point(139, 29)
        Me.txtPatientSurname.Name = "txtPatientSurname"
        Me.txtPatientSurname.Size = New System.Drawing.Size(403, 20)
        Me.txtPatientSurname.TabIndex = 177
        '
        'txtUserName
        '
        Me.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUserName.Location = New System.Drawing.Point(139, 55)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(403, 20)
        Me.txtUserName.TabIndex = 178
        '
        'txtUserSurname
        '
        Me.txtUserSurname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUserSurname.Location = New System.Drawing.Point(139, 81)
        Me.txtUserSurname.Name = "txtUserSurname"
        Me.txtUserSurname.Size = New System.Drawing.Size(403, 20)
        Me.txtUserSurname.TabIndex = 179
        '
        'chkUserName
        '
        Me.chkUserName.AutoSize = True
        Me.chkUserName.Location = New System.Drawing.Point(3, 55)
        Me.chkUserName.Name = "chkUserName"
        Me.chkUserName.Size = New System.Drawing.Size(109, 17)
        Me.chkUserName.TabIndex = 169
        Me.chkUserName.Text = "Darbinieka vārds:"
        Me.chkUserName.UseVisualStyleBackColor = True
        '
        'chkUserSurname
        '
        Me.chkUserSurname.AutoSize = True
        Me.chkUserSurname.Location = New System.Drawing.Point(3, 81)
        Me.chkUserSurname.Name = "chkUserSurname"
        Me.chkUserSurname.Size = New System.Drawing.Size(120, 17)
        Me.chkUserSurname.TabIndex = 181
        Me.chkUserSurname.Text = "Darbinieka uzvārds:"
        Me.chkUserSurname.UseVisualStyleBackColor = True
        '
        'chkService
        '
        Me.chkService.AutoSize = True
        Me.chkService.Location = New System.Drawing.Point(3, 107)
        Me.chkService.Name = "chkService"
        Me.chkService.Size = New System.Drawing.Size(89, 17)
        Me.chkService.TabIndex = 6
        Me.chkService.Text = "Pakalpojums:"
        Me.chkService.UseVisualStyleBackColor = True
        '
        'txtService
        '
        Me.txtService.AllowDrop = True
        Me.txtService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtService.Location = New System.Drawing.Point(139, 107)
        Me.txtService.Name = "txtService"
        Me.txtService.PickerPresets = Nothing
        Me.txtService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtService.Properties.ReadOnly = True
        Me.txtService.Size = New System.Drawing.Size(403, 20)
        Me.txtService.TabIndex = 167
        '
        'chkActivityDate
        '
        Me.chkActivityDate.AutoSize = True
        Me.chkActivityDate.Location = New System.Drawing.Point(3, 133)
        Me.chkActivityDate.Name = "chkActivityDate"
        Me.chkActivityDate.Size = New System.Drawing.Size(115, 17)
        Me.chkActivityDate.TabIndex = 10
        Me.chkActivityDate.Text = "Aktivitātes datums:"
        Me.chkActivityDate.UseVisualStyleBackColor = True
        '
        'chkRemindDate
        '
        Me.chkRemindDate.AutoSize = True
        Me.chkRemindDate.Location = New System.Drawing.Point(3, 159)
        Me.chkRemindDate.Name = "chkRemindDate"
        Me.chkRemindDate.Size = New System.Drawing.Size(130, 17)
        Me.chkRemindDate.TabIndex = 183
        Me.chkRemindDate.Text = "Atgādinājuma datums:"
        Me.chkRemindDate.UseVisualStyleBackColor = True
        '
        'dtpActivityDate
        '
        Me.dtpActivityDate.AutoSize = True
        Me.dtpActivityDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.dtpActivityDate.Location = New System.Drawing.Point(139, 133)
        Me.dtpActivityDate.Name = "dtpActivityDate"
        Me.dtpActivityDate.Size = New System.Drawing.Size(375, 20)
        Me.dtpActivityDate.TabIndex = 182
        '
        'dtpRemindDate
        '
        Me.dtpRemindDate.AutoSize = True
        Me.dtpRemindDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.dtpRemindDate.Location = New System.Drawing.Point(139, 159)
        Me.dtpRemindDate.Name = "dtpRemindDate"
        Me.dtpRemindDate.Size = New System.Drawing.Size(375, 20)
        Me.dtpRemindDate.TabIndex = 184
        '
        'ctlActivityFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.MinimumSize = New System.Drawing.Size(200, 0)
        Me.Name = "ctlActivityFind"
        Me.Size = New System.Drawing.Size(560, 212)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndIsSystemUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkActivityDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkService As System.Windows.Forms.CheckBox
    Friend WithEvents bndIsSystemUser As System.Windows.Forms.BindingSource
    Friend WithEvents chkUserName As System.Windows.Forms.CheckBox
    Friend WithEvents chkPatientName As System.Windows.Forms.CheckBox
    Friend WithEvents chkPatientSurname As System.Windows.Forms.CheckBox
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserSurname As System.Windows.Forms.TextBox
    Friend WithEvents chkUserSurname As System.Windows.Forms.CheckBox
    Friend WithEvents txtService As Client.ClassifierPicker
    Friend WithEvents dtpActivityDate As Core.UI.PeriodWithTimePicker
    Friend WithEvents chkRemindDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRemindDate As Core.UI.PeriodWithTimePicker

End Class
