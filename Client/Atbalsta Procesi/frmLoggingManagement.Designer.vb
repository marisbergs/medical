<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoggingManagement
    Inherits Core.frmBase

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition9 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition10 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition11 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition12 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition13 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition14 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoggingManagement))
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.bindLogEntryConfig = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbxActivityGroup = New System.Windows.Forms.GroupBox
        Me.grdTemplateList = New Core.UI.CoreGrid
        Me.bndActivityType = New System.Windows.Forms.BindingSource(Me.components)
        Me.vwMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colParent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsActive4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gbxSystemReactions = New System.Windows.Forms.GroupBox
        Me.chkUseForSend = New DevExpress.XtraEditors.CheckEdit
        Me.gbxEvent = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.lblPriorty = New System.Windows.Forms.Label
        Me.cmbPriority = New Core.UI.ListPicker
        Me.lblCode = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.gbxRecivers = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.gbxEmail = New System.Windows.Forms.GroupBox
        Me.grdEmail = New Core.UI.CoreGrid
        Me.bindLogEntryConfigEmail = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colEMails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colIsActive3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhEmail = New Core.UI.GridButtonHelper
        Me.cbxRole = New System.Windows.Forms.GroupBox
        Me.grdRole = New Core.UI.CoreGrid
        Me.bindLogEntryConfigRole = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colRole = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbRole_lookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.bndRole = New System.Windows.Forms.BindingSource(Me.components)
        Me.colIsActive1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ButtonEditRole = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.cmbRole = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.gbhRole = New Core.UI.GridButtonHelper
        Me.gbxPosition = New System.Windows.Forms.GroupBox
        Me.grdPosition = New Core.UI.CoreGrid
        Me.bindLogEntryConfigPosition = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPosition = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BuutonEditPosition = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colIsActive2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhPosition = New Core.UI.GridButtonHelper
        Me.gbxSystemUser = New System.Windows.Forms.GroupBox
        Me.grdSystemUser = New Core.UI.CoreGrid
        Me.bindLogEntryConfigUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ButtonEditUser = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.gbhSystemUser = New Core.UI.GridButtonHelper
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkCurrentUser = New DevExpress.XtraEditors.CheckEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindLogEntryConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxActivityGroup.SuspendLayout()
        CType(Me.grdTemplateList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndActivityType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vwMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSystemReactions.SuspendLayout()
        CType(Me.chkUseForSend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxEvent.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRecivers.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbxEmail.SuspendLayout()
        CType(Me.grdEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindLogEntryConfigEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cbxRole.SuspendLayout()
        CType(Me.grdRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindLogEntryConfigRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRole_lookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEditRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPosition.SuspendLayout()
        CType(Me.grdPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindLogEntryConfigPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuutonEditPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSystemUser.SuspendLayout()
        CType(Me.grdSystemUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindLogEntryConfigUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEditUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.chkCurrentUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.AutoHeight = False
        Me.RepositoryItemTextEdit12.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit12.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit12.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
        '
        'RepositoryItemTextEdit13
        '
        Me.RepositoryItemTextEdit13.AutoHeight = False
        Me.RepositoryItemTextEdit13.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit13.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit13.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit13.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit13.Name = "RepositoryItemTextEdit13"
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit14.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit14.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit14.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        '
        'RepositoryItemTextEdit15
        '
        Me.RepositoryItemTextEdit15.AutoHeight = False
        Me.RepositoryItemTextEdit15.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit15.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit15.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit15.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit15.Name = "RepositoryItemTextEdit15"
        '
        'RepositoryItemTextEdit16
        '
        Me.RepositoryItemTextEdit16.AutoHeight = False
        Me.RepositoryItemTextEdit16.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit16.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit16.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit16.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit16.Name = "RepositoryItemTextEdit16"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit10.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit10.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'bindLogEntryConfig
        '
        Me.bindLogEntryConfig.DataSource = GetType(Entities.LogEntryConfigCurrentUser)
        '
        'gbxActivityGroup
        '
        Me.gbxActivityGroup.Controls.Add(Me.grdTemplateList)
        Me.gbxActivityGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxActivityGroup.Location = New System.Drawing.Point(0, 0)
        Me.gbxActivityGroup.Name = "gbxActivityGroup"
        Me.gbxActivityGroup.Size = New System.Drawing.Size(205, 414)
        Me.gbxActivityGroup.TabIndex = 3
        Me.gbxActivityGroup.TabStop = False
        Me.gbxActivityGroup.Text = "Aktivitāšu grupas:"
        '
        'grdTemplateList
        '
        Me.grdTemplateList.DataSource = Me.bndActivityType
        Me.grdTemplateList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTemplateList.EmbeddedNavigator.Name = ""
        Me.grdTemplateList.EnforceCanEdit = False
        GridLevelNode1.RelationName = "Level1"
        Me.grdTemplateList.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdTemplateList.Location = New System.Drawing.Point(3, 16)
        Me.grdTemplateList.MainView = Me.vwMain
        Me.grdTemplateList.Name = "grdTemplateList"
        Me.grdTemplateList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit12, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit2, Me.RepositoryItemGridLookUpEdit1})
        Me.grdTemplateList.ShowOnlyActive = False
        Me.grdTemplateList.Size = New System.Drawing.Size(199, 395)
        Me.grdTemplateList.TabIndex = 1
        Me.grdTemplateList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vwMain})
        '
        'bndActivityType
        '
        Me.bndActivityType.DataSource = GetType(Entities.AuditMessage)
        '
        'vwMain
        '
        Me.vwMain.Appearance.GroupRow.BackColor = System.Drawing.SystemColors.Window
        Me.vwMain.Appearance.GroupRow.Options.UseBackColor = True
        Me.vwMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colValue, Me.colParent, Me.colIsActive4})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightGray
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = False
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = False
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = False
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = False
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Value1 = False
        StyleFormatCondition6.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition6.Appearance.Options.UseBackColor = True
        StyleFormatCondition6.ApplyToRow = True
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition6.Value1 = False
        StyleFormatCondition7.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition7.Appearance.Options.UseBackColor = True
        StyleFormatCondition7.ApplyToRow = True
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition7.Value1 = False
        StyleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition8.Appearance.Options.UseForeColor = True
        StyleFormatCondition8.ApplyToRow = True
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition8.Value1 = False
        StyleFormatCondition9.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition9.Appearance.Options.UseForeColor = True
        StyleFormatCondition9.ApplyToRow = True
        StyleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition9.Value1 = False
        StyleFormatCondition10.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition10.Appearance.Options.UseForeColor = True
        StyleFormatCondition10.ApplyToRow = True
        StyleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition10.Value1 = False
        StyleFormatCondition11.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition11.Appearance.Options.UseForeColor = True
        StyleFormatCondition11.ApplyToRow = True
        StyleFormatCondition11.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition11.Value1 = False
        StyleFormatCondition12.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition12.Appearance.Options.UseForeColor = True
        StyleFormatCondition12.ApplyToRow = True
        StyleFormatCondition12.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition12.Value1 = False
        StyleFormatCondition13.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition13.Appearance.Options.UseForeColor = True
        StyleFormatCondition13.ApplyToRow = True
        StyleFormatCondition13.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition13.Value1 = False
        StyleFormatCondition14.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition14.Appearance.Options.UseForeColor = True
        StyleFormatCondition14.ApplyToRow = True
        StyleFormatCondition14.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition14.Value1 = False
        Me.vwMain.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6, StyleFormatCondition7, StyleFormatCondition8, StyleFormatCondition9, StyleFormatCondition10, StyleFormatCondition11, StyleFormatCondition12, StyleFormatCondition13, StyleFormatCondition14})
        Me.vwMain.GridControl = Me.grdTemplateList
        Me.vwMain.GroupCount = 1
        Me.vwMain.GroupFormat = "[#image]{1} {2}"
        Me.vwMain.MRUFilters.Add(CType(resources.GetObject("vwMain.MRUFilters"), DevExpress.XtraGrid.Views.Base.ViewFilter))
        Me.vwMain.Name = "vwMain"
        Me.vwMain.OptionsBehavior.AutoExpandAllGroups = True
        Me.vwMain.OptionsBehavior.Editable = False
        Me.vwMain.OptionsDetail.EnableMasterViewMode = False
        Me.vwMain.OptionsView.ShowColumnHeaders = False
        Me.vwMain.OptionsView.ShowDetailButtons = False
        Me.vwMain.OptionsView.ShowFilterPanel = False
        Me.vwMain.OptionsView.ShowGroupPanel = False
        Me.vwMain.OptionsView.ShowIndicator = False
        Me.vwMain.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colParent, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colValue, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colValue
        '
        Me.colValue.Caption = "Value"
        Me.colValue.FieldName = "Value"
        Me.colValue.Name = "colValue"
        Me.colValue.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colValue.Visible = True
        Me.colValue.VisibleIndex = 0
        Me.colValue.Width = 220
        '
        'colParent
        '
        Me.colParent.Caption = "Parent"
        Me.colParent.FieldName = "Parent"
        Me.colParent.Name = "colParent"
        '
        'colIsActive4
        '
        Me.colIsActive4.Caption = "IsActive"
        Me.colIsActive4.FieldName = "IsActive"
        Me.colIsActive4.Name = "colIsActive4"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'gbxSystemReactions
        '
        Me.gbxSystemReactions.Controls.Add(Me.chkUseForSend)
        Me.gbxSystemReactions.Controls.Add(Me.gbxEvent)
        Me.gbxSystemReactions.Controls.Add(Me.gbxRecivers)
        Me.gbxSystemReactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxSystemReactions.Location = New System.Drawing.Point(0, 0)
        Me.gbxSystemReactions.Name = "gbxSystemReactions"
        Me.gbxSystemReactions.Size = New System.Drawing.Size(590, 414)
        Me.gbxSystemReactions.TabIndex = 4
        Me.gbxSystemReactions.TabStop = False
        Me.gbxSystemReactions.Text = "Sistēmas reakcijas:"
        '
        'chkUseForSend
        '
        Me.chkUseForSend.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindLogEntryConfig, "IsUseForSend", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkUseForSend.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndActivityType, "CanEdit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkUseForSend.Location = New System.Drawing.Point(15, 84)
        Me.chkUseForSend.Name = "chkUseForSend"
        Me.chkUseForSend.Properties.Caption = "Paziņojumu nosūtīšana uz e-pastu"
        Me.chkUseForSend.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkUseForSend.Properties.ValueGrayed = False
        Me.chkUseForSend.Size = New System.Drawing.Size(268, 19)
        Me.chkUseForSend.TabIndex = 6
        '
        'gbxEvent
        '
        Me.gbxEvent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxEvent.Controls.Add(Me.Label2)
        Me.gbxEvent.Controls.Add(Me.TextEdit1)
        Me.gbxEvent.Controls.Add(Me.lblPriorty)
        Me.gbxEvent.Controls.Add(Me.cmbPriority)
        Me.gbxEvent.Controls.Add(Me.lblCode)
        Me.gbxEvent.Controls.Add(Me.txtCode)
        Me.gbxEvent.Location = New System.Drawing.Point(6, 16)
        Me.gbxEvent.Name = "gbxEvent"
        Me.gbxEvent.Size = New System.Drawing.Size(581, 62)
        Me.gbxEvent.TabIndex = 0
        Me.gbxEvent.TabStop = False
        Me.gbxEvent.Text = "Notikums:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Aktivitātes veids: "
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivityType, "Value", True))
        Me.TextEdit1.Location = New System.Drawing.Point(105, 14)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(466, 20)
        Me.TextEdit1.TabIndex = 5
        '
        'lblPriorty
        '
        Me.lblPriorty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPriorty.AutoSize = True
        Me.lblPriorty.Location = New System.Drawing.Point(414, 42)
        Me.lblPriorty.Name = "lblPriorty"
        Me.lblPriorty.Size = New System.Drawing.Size(54, 13)
        Me.lblPriorty.TabIndex = 4
        Me.lblPriorty.Text = "Prioritāte: "
        '
        'cmbPriority
        '
        Me.cmbPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPriority.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivityType, "Priority", True))
        Me.cmbPriority.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndActivityType, "CanEdit", True))
        Me.cmbPriority.Location = New System.Drawing.Point(471, 39)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbPriority.Properties.PopupFormWidth = 100
        Me.cmbPriority.Properties.PopupSizeable = False
        Me.cmbPriority.Properties.ShowPopupCloseButton = False
        Me.cmbPriority.Size = New System.Drawing.Size(100, 20)
        Me.cmbPriority.TabIndex = 3
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(9, 45)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(37, 13)
        Me.lblCode.TabIndex = 2
        Me.lblCode.Text = "Kods: "
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivityType, "Code", True))
        Me.txtCode.Location = New System.Drawing.Point(105, 37)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(121, 20)
        Me.txtCode.TabIndex = 1
        '
        'gbxRecivers
        '
        Me.gbxRecivers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRecivers.Controls.Add(Me.TableLayoutPanel1)
        Me.gbxRecivers.Controls.Add(Me.Panel1)
        Me.gbxRecivers.Location = New System.Drawing.Point(6, 109)
        Me.gbxRecivers.Name = "gbxRecivers"
        Me.gbxRecivers.Size = New System.Drawing.Size(578, 300)
        Me.gbxRecivers.TabIndex = 1
        Me.gbxRecivers.TabStop = False
        Me.gbxRecivers.Text = "Adresāti:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbxEmail, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxRole, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gbxPosition, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbxSystemUser, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 48)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(572, 249)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'gbxEmail
        '
        Me.gbxEmail.Controls.Add(Me.grdEmail)
        Me.gbxEmail.Controls.Add(Me.gbhEmail)
        Me.gbxEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxEmail.Location = New System.Drawing.Point(289, 127)
        Me.gbxEmail.Name = "gbxEmail"
        Me.gbxEmail.Size = New System.Drawing.Size(280, 119)
        Me.gbxEmail.TabIndex = 4
        Me.gbxEmail.TabStop = False
        Me.gbxEmail.Text = "E-pasts:"
        '
        'grdEmail
        '
        Me.grdEmail.DataSource = Me.bindLogEntryConfigEmail
        Me.grdEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEmail.EmbeddedNavigator.Name = ""
        Me.grdEmail.EnforceCanEdit = False
        Me.grdEmail.Location = New System.Drawing.Point(3, 44)
        Me.grdEmail.MainView = Me.GridView4
        Me.grdEmail.Name = "grdEmail"
        Me.grdEmail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit13, Me.RepositoryItemTextEdit8, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit1})
        Me.grdEmail.ShowOnlyActive = False
        Me.grdEmail.Size = New System.Drawing.Size(274, 72)
        Me.grdEmail.TabIndex = 0
        Me.grdEmail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'bindLogEntryConfigEmail
        '
        Me.bindLogEntryConfigEmail.DataSource = GetType(Entities.LogEntryConfigEmail)
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEMails, Me.colIsActive3})
        Me.GridView4.GridControl = Me.grdEmail
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowFilterPanel = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colEMails
        '
        Me.colEMails.Caption = "E-pasts"
        Me.colEMails.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colEMails.FieldName = "EMails"
        Me.colEMails.Name = "colEMails"
        Me.colEMails.Visible = True
        Me.colEMails.VisibleIndex = 0
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = ".+@.+\..+"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit1.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colIsActive3
        '
        Me.colIsActive3.Caption = "IsActive"
        Me.colIsActive3.FieldName = "IsActive"
        Me.colIsActive3.Name = "colIsActive3"
        '
        'gbhEmail
        '
        Me.gbhEmail.DeleteReason = False
        Me.gbhEmail.DeleteReasonColumn = Nothing
        Me.gbhEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhEmail.Grid = Me.grdEmail
        Me.gbhEmail.GridDataSource = Me.bindLogEntryConfigEmail
        Me.gbhEmail.Location = New System.Drawing.Point(3, 16)
        Me.gbhEmail.Name = "gbhEmail"
        Me.gbhEmail.ShowActive = False
        Me.gbhEmail.ShowAdd = True
        Me.gbhEmail.ShowChk = True
        Me.gbhEmail.ShowDelete = True
        Me.gbhEmail.Size = New System.Drawing.Size(274, 28)
        Me.gbhEmail.TabIndex = 1
        '
        'cbxRole
        '
        Me.cbxRole.Controls.Add(Me.grdRole)
        Me.cbxRole.Controls.Add(Me.gbhRole)
        Me.cbxRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxRole.Location = New System.Drawing.Point(289, 3)
        Me.cbxRole.Name = "cbxRole"
        Me.cbxRole.Size = New System.Drawing.Size(280, 118)
        Me.cbxRole.TabIndex = 2
        Me.cbxRole.TabStop = False
        Me.cbxRole.Text = "Loma:"
        '
        'grdRole
        '
        Me.grdRole.DataSource = Me.bindLogEntryConfigRole
        Me.grdRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRole.EmbeddedNavigator.Name = ""
        Me.grdRole.EnforceCanEdit = False
        Me.grdRole.Location = New System.Drawing.Point(3, 44)
        Me.grdRole.MainView = Me.GridView2
        Me.grdRole.Name = "grdRole"
        Me.grdRole.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit14, Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit4, Me.ButtonEditRole, Me.cmbRole, Me.cmbRole_lookUp})
        Me.grdRole.ShowOnlyActive = False
        Me.grdRole.Size = New System.Drawing.Size(274, 71)
        Me.grdRole.TabIndex = 0
        Me.grdRole.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bindLogEntryConfigRole
        '
        Me.bindLogEntryConfigRole.DataSource = GetType(Entities.LogEntryConfigRole)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRole, Me.colIsActive1})
        Me.GridView2.GridControl = Me.grdRole
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFilterPanel = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRole
        '
        Me.colRole.Caption = "Loma"
        Me.colRole.ColumnEdit = Me.cmbRole_lookUp
        Me.colRole.FieldName = "Role"
        Me.colRole.Name = "colRole"
        Me.colRole.Visible = True
        Me.colRole.VisibleIndex = 0
        '
        'cmbRole_lookUp
        '
        Me.cmbRole_lookUp.AutoHeight = False
        Me.cmbRole_lookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbRole_lookUp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Loma", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsActive", "Aktīvs", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbRole_lookUp.DataSource = Me.bndRole
        Me.cmbRole_lookUp.DisplayMember = "Name"
        Me.cmbRole_lookUp.Name = "cmbRole_lookUp"
        Me.cmbRole_lookUp.NullText = ""
        Me.cmbRole_lookUp.ValueMember = "Object"
        '
        'bndRole
        '
        Me.bndRole.DataSource = GetType(Entities.Role)
        '
        'colIsActive1
        '
        Me.colIsActive1.Caption = "IsActive"
        Me.colIsActive1.FieldName = "IsActive"
        Me.colIsActive1.Name = "colIsActive1"
        '
        'ButtonEditRole
        '
        Me.ButtonEditRole.AutoHeight = False
        Me.ButtonEditRole.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ButtonEditRole.Name = "ButtonEditRole"
        '
        'cmbRole
        '
        Me.cmbRole.AutoHeight = False
        Me.cmbRole.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbRole.Name = "cmbRole"
        '
        'gbhRole
        '
        Me.gbhRole.DeleteReason = False
        Me.gbhRole.DeleteReasonColumn = Nothing
        Me.gbhRole.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhRole.Grid = Me.grdRole
        Me.gbhRole.GridDataSource = Me.bindLogEntryConfigRole
        Me.gbhRole.Location = New System.Drawing.Point(3, 16)
        Me.gbhRole.Name = "gbhRole"
        Me.gbhRole.ShowActive = False
        Me.gbhRole.ShowAdd = True
        Me.gbhRole.ShowChk = True
        Me.gbhRole.ShowDelete = True
        Me.gbhRole.Size = New System.Drawing.Size(274, 28)
        Me.gbhRole.TabIndex = 1
        '
        'gbxPosition
        '
        Me.gbxPosition.Controls.Add(Me.grdPosition)
        Me.gbxPosition.Controls.Add(Me.gbhPosition)
        Me.gbxPosition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxPosition.Location = New System.Drawing.Point(3, 127)
        Me.gbxPosition.Name = "gbxPosition"
        Me.gbxPosition.Size = New System.Drawing.Size(280, 119)
        Me.gbxPosition.TabIndex = 3
        Me.gbxPosition.TabStop = False
        Me.gbxPosition.Text = "Amats:"
        '
        'grdPosition
        '
        Me.grdPosition.DataSource = Me.bindLogEntryConfigPosition
        Me.grdPosition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPosition.EmbeddedNavigator.Name = ""
        Me.grdPosition.EnforceCanEdit = False
        Me.grdPosition.Location = New System.Drawing.Point(3, 44)
        Me.grdPosition.MainView = Me.GridView3
        Me.grdPosition.Name = "grdPosition"
        Me.grdPosition.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit15, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit5, Me.BuutonEditPosition})
        Me.grdPosition.ShowOnlyActive = False
        Me.grdPosition.Size = New System.Drawing.Size(274, 72)
        Me.grdPosition.TabIndex = 0
        Me.grdPosition.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'bindLogEntryConfigPosition
        '
        Me.bindLogEntryConfigPosition.DataSource = GetType(Entities.LogEntryConfigPosition)
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPosition, Me.colIsActive2})
        Me.GridView3.GridControl = Me.grdPosition
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFilterPanel = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colPosition
        '
        Me.colPosition.Caption = "Amats"
        Me.colPosition.ColumnEdit = Me.BuutonEditPosition
        Me.colPosition.FieldName = "Position"
        Me.colPosition.Name = "colPosition"
        Me.colPosition.Visible = True
        Me.colPosition.VisibleIndex = 0
        '
        'BuutonEditPosition
        '
        Me.BuutonEditPosition.AutoHeight = False
        Me.BuutonEditPosition.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.BuutonEditPosition.Name = "BuutonEditPosition"
        Me.BuutonEditPosition.ReadOnly = True
        '
        'colIsActive2
        '
        Me.colIsActive2.Caption = "IsActive"
        Me.colIsActive2.FieldName = "IsActive"
        Me.colIsActive2.Name = "colIsActive2"
        '
        'gbhPosition
        '
        Me.gbhPosition.DeleteReason = False
        Me.gbhPosition.DeleteReasonColumn = Nothing
        Me.gbhPosition.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhPosition.Grid = Me.grdPosition
        Me.gbhPosition.GridDataSource = Me.bindLogEntryConfigPosition
        Me.gbhPosition.Location = New System.Drawing.Point(3, 16)
        Me.gbhPosition.Name = "gbhPosition"
        Me.gbhPosition.ShowActive = False
        Me.gbhPosition.ShowAdd = True
        Me.gbhPosition.ShowChk = True
        Me.gbhPosition.ShowDelete = True
        Me.gbhPosition.Size = New System.Drawing.Size(274, 28)
        Me.gbhPosition.TabIndex = 1
        '
        'gbxSystemUser
        '
        Me.gbxSystemUser.Controls.Add(Me.grdSystemUser)
        Me.gbxSystemUser.Controls.Add(Me.gbhSystemUser)
        Me.gbxSystemUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxSystemUser.Location = New System.Drawing.Point(3, 3)
        Me.gbxSystemUser.Name = "gbxSystemUser"
        Me.gbxSystemUser.Size = New System.Drawing.Size(280, 118)
        Me.gbxSystemUser.TabIndex = 1
        Me.gbxSystemUser.TabStop = False
        Me.gbxSystemUser.Text = "Sistēmas lietotājs:"
        '
        'grdSystemUser
        '
        Me.grdSystemUser.DataSource = Me.bindLogEntryConfigUser
        Me.grdSystemUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSystemUser.EmbeddedNavigator.Name = ""
        Me.grdSystemUser.EnforceCanEdit = False
        Me.grdSystemUser.Location = New System.Drawing.Point(3, 44)
        Me.grdSystemUser.MainView = Me.GridView1
        Me.grdSystemUser.Name = "grdSystemUser"
        Me.grdSystemUser.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit16, Me.RepositoryItemTextEdit11, Me.RepositoryItemTextEdit6, Me.ButtonEditUser, Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2})
        Me.grdSystemUser.ShowOnlyActive = False
        Me.grdSystemUser.Size = New System.Drawing.Size(274, 71)
        Me.grdSystemUser.TabIndex = 0
        Me.grdSystemUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bindLogEntryConfigUser
        '
        Me.bindLogEntryConfigUser.DataSource = GetType(Entities.LogEntryConfigUser)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUser, Me.colIsActive})
        Me.GridView1.GridControl = Me.grdSystemUser
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colUser
        '
        Me.colUser.Caption = "Sistēmas lietotājs"
        Me.colUser.ColumnEdit = Me.ButtonEditUser
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 0
        '
        'ButtonEditUser
        '
        Me.ButtonEditUser.AutoHeight = False
        Me.ButtonEditUser.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ButtonEditUser.Name = "ButtonEditUser"
        Me.ButtonEditUser.ReadOnly = True
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.ColumnEdit = Me.ButtonEditUser
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'gbhSystemUser
        '
        Me.gbhSystemUser.DeleteReason = False
        Me.gbhSystemUser.DeleteReasonColumn = Nothing
        Me.gbhSystemUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhSystemUser.Grid = Me.grdSystemUser
        Me.gbhSystemUser.GridDataSource = Me.bindLogEntryConfigUser
        Me.gbhSystemUser.Location = New System.Drawing.Point(3, 16)
        Me.gbhSystemUser.Name = "gbhSystemUser"
        Me.gbhSystemUser.ShowActive = False
        Me.gbhSystemUser.ShowAdd = True
        Me.gbhSystemUser.ShowChk = True
        Me.gbhSystemUser.ShowDelete = True
        Me.gbhSystemUser.Size = New System.Drawing.Size(274, 28)
        Me.gbhSystemUser.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkCurrentUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 32)
        Me.Panel1.TabIndex = 7
        '
        'chkCurrentUser
        '
        Me.chkCurrentUser.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindLogEntryConfig, "IsCurrentUser", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkCurrentUser.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bindLogEntryConfig, "CanEdit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkCurrentUser.Location = New System.Drawing.Point(6, 3)
        Me.chkCurrentUser.Name = "chkCurrentUser"
        Me.chkCurrentUser.Properties.Caption = "Lietotājs, kurš veicis aktivitāti"
        Me.chkCurrentUser.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkCurrentUser.Properties.ValueGrayed = False
        Me.chkCurrentUser.Size = New System.Drawing.Size(175, 19)
        Me.chkCurrentUser.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 418)
        Me.Panel2.MinimumSize = New System.Drawing.Size(787, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(809, 31)
        Me.Panel2.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(731, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndActivityType, "CanEdit", True))
        Me.btnSave.Location = New System.Drawing.Point(650, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gbxActivityGroup)
        Me.SplitContainerControl1.Panel1.Text = "SplitContainerControl1_Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gbxSystemReactions)
        Me.SplitContainerControl1.Panel2.Text = "SplitContainerControl1_Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(809, 418)
        Me.SplitContainerControl1.SplitterPosition = 209
        Me.SplitContainerControl1.TabIndex = 6
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bindLogEntryConfig
        '
        'frmLoggingManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 449)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.Panel2)
        Me.MinimumSize = New System.Drawing.Size(817, 476)
        Me.Name = "frmLoggingManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notikumu žurnāla administrēšana"
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindLogEntryConfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxActivityGroup.ResumeLayout(False)
        CType(Me.grdTemplateList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndActivityType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vwMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSystemReactions.ResumeLayout(False)
        CType(Me.chkUseForSend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxEvent.ResumeLayout(False)
        Me.gbxEvent.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRecivers.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbxEmail.ResumeLayout(False)
        CType(Me.grdEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindLogEntryConfigEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cbxRole.ResumeLayout(False)
        CType(Me.grdRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindLogEntryConfigRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRole_lookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEditRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPosition.ResumeLayout(False)
        CType(Me.grdPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindLogEntryConfigPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuutonEditPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSystemUser.ResumeLayout(False)
        CType(Me.grdSystemUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindLogEntryConfigUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEditUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.chkCurrentUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bindLogEntryConfig As System.Windows.Forms.BindingSource
    Friend WithEvents gbxActivityGroup As System.Windows.Forms.GroupBox
    Friend WithEvents gbxSystemReactions As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bndActivityType As System.Windows.Forms.BindingSource
    Friend WithEvents gbxEvent As System.Windows.Forms.GroupBox
    Friend WithEvents lblPriorty As System.Windows.Forms.Label
    Friend WithEvents cmbPriority As Core.UI.ListPicker
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gbxRecivers As System.Windows.Forms.GroupBox
    Friend WithEvents gbxSystemUser As System.Windows.Forms.GroupBox
    Friend WithEvents grdSystemUser As Core.UI.CoreGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbhSystemUser As Core.UI.GridButtonHelper
    Friend WithEvents gbxPosition As System.Windows.Forms.GroupBox
    Friend WithEvents grdPosition As Core.UI.CoreGrid
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbhPosition As Core.UI.GridButtonHelper
    Friend WithEvents cbxRole As System.Windows.Forms.GroupBox
    Friend WithEvents grdRole As Core.UI.CoreGrid
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbhRole As Core.UI.GridButtonHelper
    Friend WithEvents gbxEmail As System.Windows.Forms.GroupBox
    Friend WithEvents grdEmail As Core.UI.CoreGrid
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbhEmail As Core.UI.GridButtonHelper
    Friend WithEvents bindLogEntryConfigUser As System.Windows.Forms.BindingSource
    Friend WithEvents bindLogEntryConfigRole As System.Windows.Forms.BindingSource
    Friend WithEvents bindLogEntryConfigPosition As System.Windows.Forms.BindingSource
    Friend WithEvents bindLogEntryConfigEmail As System.Windows.Forms.BindingSource
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonEditUser As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colRole As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BuutonEditPosition As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ButtonEditRole As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbRole As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents bndRole As System.Windows.Forms.BindingSource
    Friend WithEvents cmbRole_lookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grdTemplateList As Core.UI.CoreGrid
    Friend WithEvents vwMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkCurrentUser As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkUseForSend As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
