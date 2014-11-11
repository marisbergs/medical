<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAttachment
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
        Me.grdAttachment = New Core.UI.CoreGrid
        Me.bndDocumentList = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwAttachment = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCreator = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsueDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.grdAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndDocumentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdAttachment
        '
        Me.grdAttachment.DataSource = Me.bndDocumentList
        Me.grdAttachment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAttachment.EmbeddedNavigator.Name = ""
        Me.grdAttachment.EnforceCanEdit = False
        Me.grdAttachment.Location = New System.Drawing.Point(0, 0)
        Me.grdAttachment.MainView = Me.gvwAttachment
        Me.grdAttachment.Name = "grdAttachment"
        Me.grdAttachment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdAttachment.ShowOnlyActive = False
        Me.grdAttachment.Size = New System.Drawing.Size(546, 335)
        Me.grdAttachment.TabIndex = 1
        Me.grdAttachment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwAttachment})
        '
        'bndDocumentList
        '
        Me.bndDocumentList.DataSource = GetType(Entities.PatientDocument)
        '
        'gvwAttachment
        '
        Me.gvwAttachment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName, Me.colIsActive, Me.colCreator, Me.colNotes, Me.colIsueDate})
        Me.gvwAttachment.GridControl = Me.grdAttachment
        Me.gvwAttachment.Name = "gvwAttachment"
        Me.gvwAttachment.OptionsBehavior.Editable = False
        Me.gvwAttachment.OptionsView.ShowDetailButtons = False
        Me.gvwAttachment.OptionsView.ShowFilterPanel = False
        Me.gvwAttachment.OptionsView.ShowGroupPanel = False
        Me.gvwAttachment.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colIsueDate, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colName
        '
        Me.colName.Caption = "Dokumenta nosaukums"
        Me.colName.FieldName = "DocType"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        Me.colName.Width = 133
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'colCreator
        '
        Me.colCreator.Caption = "Pievienoja"
        Me.colCreator.FieldName = "Creator"
        Me.colCreator.Name = "colCreator"
        Me.colCreator.Visible = True
        Me.colCreator.VisibleIndex = 1
        Me.colCreator.Width = 122
        '
        'colNotes
        '
        Me.colNotes.Caption = "Apraksts"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 3
        Me.colNotes.Width = 201
        '
        'colIsueDate
        '
        Me.colIsueDate.Caption = "Datums"
        Me.colIsueDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colIsueDate.DisplayFormat.FormatString = "d"
        Me.colIsueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colIsueDate.FieldName = "CreateDate"
        Me.colIsueDate.Name = "colIsueDate"
        Me.colIsueDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colIsueDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.colIsueDate.Visible = True
        Me.colIsueDate.VisibleIndex = 2
        Me.colIsueDate.Width = 69
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'ctlAttachment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdAttachment)
        Me.Name = "ctlAttachment"
        Me.Size = New System.Drawing.Size(546, 335)
        CType(Me.grdAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndDocumentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdAttachment As Core.UI.CoreGrid
    Friend WithEvents gvwAttachment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents bndDocumentList As System.Windows.Forms.BindingSource
    Friend WithEvents colCreator As DevExpress.XtraGrid.Columns.GridColumn

End Class
