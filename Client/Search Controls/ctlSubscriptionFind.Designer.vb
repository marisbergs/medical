Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
'ёй
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSubscriptionFind
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
        Me.chkService = New System.Windows.Forms.CheckBox()
        Me.txtService = New Client.ClassifierPicker()
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panTableLayout.Controls.Add(Me.chkService, 0, 1)
        Me.panTableLayout.Controls.Add(Me.txtService, 1, 1)
        Me.panTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.panTableLayout.Name = "panTableLayout"
        Me.panTableLayout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.panTableLayout.RowCount = 10
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
        Me.panTableLayout.Size = New System.Drawing.Size(662, 57)
        Me.panTableLayout.TabIndex = 2
        '
        'chkService
        '
        Me.chkService.AutoSize = True
        Me.chkService.Location = New System.Drawing.Point(3, 3)
        Me.chkService.Name = "chkService"
        Me.chkService.Size = New System.Drawing.Size(86, 17)
        Me.chkService.TabIndex = 169
        Me.chkService.Text = "Pakalpojums"
        Me.chkService.UseVisualStyleBackColor = True
        '
        'txtService
        '
        Me.txtService.AllowDrop = True
        Me.txtService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtService.Location = New System.Drawing.Point(95, 3)
        Me.txtService.Name = "txtService"
        Me.txtService.PickerPresets = Nothing
        Me.txtService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtService.Properties.ReadOnly = True
        Me.txtService.Size = New System.Drawing.Size(549, 20)
        Me.txtService.TabIndex = 190
        '
        'ctlSubscriptionFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.Name = "ctlSubscriptionFind"
        Me.Size = New System.Drawing.Size(662, 87)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkService As System.Windows.Forms.CheckBox
    Friend WithEvents txtService As Client.ClassifierPicker

End Class
