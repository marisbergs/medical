<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSMS
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
        Me.components = New System.ComponentModel.Container
        Me.bndSMS = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdSMS = New Core.UI.CoreGrid
        Me.gvwSMS = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSended = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResponse = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMessage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSMSSesion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSendTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        CType(Me.bndSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndSMS
        '
        Me.bndSMS.DataSource = GetType(Entities.SMSSendingList)
        '
        'grdSMS
        '
        Me.grdSMS.DataSource = Me.bndSMS
        Me.grdSMS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSMS.EmbeddedNavigator.Name = ""
        Me.grdSMS.EnforceCanEdit = False
        Me.grdSMS.Location = New System.Drawing.Point(0, 0)
        Me.grdSMS.MainView = Me.gvwSMS
        Me.grdSMS.Name = "grdSMS"
        Me.grdSMS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1})
        Me.grdSMS.ShowOnlyActive = False
        Me.grdSMS.Size = New System.Drawing.Size(597, 330)
        Me.grdSMS.TabIndex = 1
        Me.grdSMS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSMS})
        '
        'gvwSMS
        '
        Me.gvwSMS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSended, Me.colResponse, Me.colMessage, Me.colSMSSesion, Me.colSendTime})
        Me.gvwSMS.GridControl = Me.grdSMS
        Me.gvwSMS.Name = "gvwSMS"
        Me.gvwSMS.OptionsBehavior.Editable = False
        Me.gvwSMS.OptionsSelection.MultiSelect = True
        Me.gvwSMS.OptionsView.ShowDetailButtons = False
        Me.gvwSMS.OptionsView.ShowFilterPanel = False
        Me.gvwSMS.OptionsView.ShowFooter = True
        Me.gvwSMS.OptionsView.ShowGroupPanel = False
        '
        'colSended
        '
        Me.colSended.Caption = "Nosûtīts"
        Me.colSended.FieldName = "Sended"
        Me.colSended.Name = "colSended"
        Me.colSended.OptionsColumn.ReadOnly = True
        Me.colSended.Visible = True
        Me.colSended.VisibleIndex = 2
        Me.colSended.Width = 58
        '
        'colResponse
        '
        Me.colResponse.Caption = "Rezultāts"
        Me.colResponse.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colResponse.FieldName = "Response"
        Me.colResponse.Name = "colResponse"
        Me.colResponse.OptionsColumn.ReadOnly = True
        Me.colResponse.Visible = True
        Me.colResponse.VisibleIndex = 3
        Me.colResponse.Width = 96
        '
        'colMessage
        '
        Me.colMessage.Caption = "Ziņa"
        Me.colMessage.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colMessage.FieldName = "Message"
        Me.colMessage.Name = "colMessage"
        Me.colMessage.OptionsColumn.ReadOnly = True
        Me.colMessage.Visible = True
        Me.colMessage.VisibleIndex = 1
        Me.colMessage.Width = 235
        '
        'colSMSSesion
        '
        Me.colSMSSesion.Caption = "Sesija"
        Me.colSMSSesion.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colSMSSesion.FieldName = "SMSSesion"
        Me.colSMSSesion.Name = "colSMSSesion"
        Me.colSMSSesion.OptionsColumn.ReadOnly = True
        Me.colSMSSesion.Visible = True
        Me.colSMSSesion.VisibleIndex = 4
        Me.colSMSSesion.Width = 106
        '
        'colSendTime
        '
        Me.colSendTime.Caption = "Sûtīšanas laiks"
        Me.colSendTime.FieldName = "SendTime"
        Me.colSendTime.Name = "colSendTime"
        Me.colSendTime.OptionsColumn.ReadOnly = True
        Me.colSendTime.Visible = True
        Me.colSendTime.VisibleIndex = 0
        Me.colSendTime.Width = 88
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'ctlSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdSMS)
        Me.Name = "ctlSMS"
        Me.Size = New System.Drawing.Size(597, 330)
        CType(Me.bndSMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndSMS As System.Windows.Forms.BindingSource
    Friend WithEvents grdSMS As Core.UI.CoreGrid
    Friend WithEvents gvwSMS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSended As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMSSesion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSendTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

End Class
