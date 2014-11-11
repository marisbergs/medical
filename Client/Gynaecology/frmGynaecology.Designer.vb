<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGynaecology
    Inherits Client.frmUIBase

    'Form overrides dispose to clean up the component list.
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
        Dim YesNo7 As Entities.YesNo = New Entities.YesNo
        Dim YesNo8 As Entities.YesNo = New Entities.YesNo
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.btnOpen = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.pagAnamneses = New System.Windows.Forms.TabPage
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdExtragenitalPathalogy = New Core.UI.CoreGrid
        Me.bndExtragenitalPathalogy = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwExtragenitalPathalogy = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colExtragenitalPathalogy = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtExtragenitalPathalogy = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colExtragenitalPathalogyNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtExtragenitalPathalogyNotes = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colExtragenitalPathalogyIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhExtragenitalPathalogy = New Core.UI.GridButtonHelper
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioGroup1 = New Core.UI.RadioGroup
        Me.bndGynaecology = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grdOperations = New Core.UI.CoreGrid
        Me.bndOperations = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwOperations = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOperation = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtOperation = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colOperationNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtOperationNotes = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colOperationIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhOperations = New Core.UI.GridButtonHelper
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RadioGroup2 = New Core.UI.RadioGroup
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ClassifierPicker1 = New Client.ClassifierPicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDateUntil = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.ClassifierPicker2 = New Client.ClassifierPicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.gbxAllergy = New System.Windows.Forms.GroupBox
        Me.grdAllergy = New Core.UI.CoreGrid
        Me.bndAllergy = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwAllergy = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colAllergy = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAllergy = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colAllergyNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAllergyNotes = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colAllergyIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhAllergy = New Core.UI.GridButtonHelper
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.rgbAllergy = New Core.UI.RadioGroup
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.grdUsedMedicaments = New Core.UI.CoreGrid
        Me.bndUsedMedicaments = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwUsedMedicaments = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUsedMedicaments = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtUsedMedicaments = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colUsedMedicamentsNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtUsedMedicamentsNotes = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colUsedMedicamentsIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhUsedMedicaments = New Core.UI.GridButtonHelper
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.RadioGroup4 = New Core.UI.RadioGroup
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.grdEvolutionAnomaly = New Core.UI.CoreGrid
        Me.bndEvolutionAnomaly = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwEvolutionAnomaly = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colEvolutionAnomaly = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtEvolutionAnomaly = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colEvolutionAnomalyNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtEvolutionAnomalyNotes = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colEvolutionAnomalyIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhEvolutionAnomaly = New Core.UI.GridButtonHelper
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.RadioGroup3 = New Core.UI.RadioGroup
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.grdHereditaryDsesase = New Core.UI.CoreGrid
        Me.bndHereditaryDsesase = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwHereditaryDsesase = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colHereditaryDsesase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtHereditaryDsesase = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colHereditaryDsesaseNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtHereditaryDsesaseNotes = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colHereditaryDsesaseIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhHereditaryDsesase = New Core.UI.GridButtonHelper
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.RadioGroup5 = New Core.UI.RadioGroup
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.RadioGroup10 = New Core.UI.RadioGroup
        Me.RadioGroup9 = New Core.UI.RadioGroup
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.RadioGroup8 = New Core.UI.RadioGroup
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.MemoExEdit2 = New DevExpress.XtraEditors.MemoExEdit
        Me.RadioGroup7 = New Core.UI.RadioGroup
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.RadioGroup6 = New Core.UI.RadioGroup
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.MemoExEdit1 = New DevExpress.XtraEditors.MemoExEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.grdActyalMedicaments = New Core.UI.CoreGrid
        Me.bndActyalMedicaments = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwActyalMedicaments = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grdActyalMedicament = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colActyalMedicamentNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colActyalMedicamentsIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhActyalMedicaments = New Core.UI.GridButtonHelper
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
        Me.RadioGroup11 = New Core.UI.RadioGroup
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.grdIlness = New Core.UI.CoreGrid
        Me.bndIlness = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwIlness = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIlness = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colIlnessNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colIlnessIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gbhIlness = New Core.UI.GridButtonHelper
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel
        Me.RadioGroup12 = New Core.UI.RadioGroup
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.grdLabour = New Core.UI.CoreGrid
        Me.bndLabour = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwLabour = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colYear = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.txtYear = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colWeight = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.txtWeight = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colHealth = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbHealth = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colHealthNow = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbHealthNow = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colSex = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbSex = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colHealthNowNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.txtTextContent = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colHealthNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLactation = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.txtLactation = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.gbhLabour = New Core.UI.GridButtonHelper
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.CoreGrid2 = New Core.UI.CoreGrid
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridButtonHelper2 = New Core.UI.GridButtonHelper
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.pagAnamneses.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdExtragenitalPathalogy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndExtragenitalPathalogy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwExtragenitalPathalogy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtragenitalPathalogy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtragenitalPathalogyNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bndGynaecology, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdOperations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndOperations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOperations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperationNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateUntil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassifierPicker2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.gbxAllergy.SuspendLayout()
        CType(Me.grdAllergy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndAllergy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwAllergy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllergy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllergyNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdUsedMedicaments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndUsedMedicaments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwUsedMedicaments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsedMedicaments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsedMedicamentsNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdEvolutionAnomaly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndEvolutionAnomaly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwEvolutionAnomaly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEvolutionAnomaly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEvolutionAnomalyNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.grdHereditaryDsesase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndHereditaryDsesase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwHereditaryDsesase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHereditaryDsesase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHereditaryDsesaseNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.MemoExEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.MemoExEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.grdActyalMedicaments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndActyalMedicaments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwActyalMedicaments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.grdIlness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndIlness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwIlness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.grdLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbHealthNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTextContent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLactation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        CType(Me.CoreGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(478, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(400, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(319, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 436)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 28)
        Me.SplitContainer1.SplitterDistance = 498
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnGenerate)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(498, 28)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(3, 3)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Ìenerēt"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(84, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pagAnamneses)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 436)
        Me.TabControl1.TabIndex = 4
        '
        'pagAnamneses
        '
        Me.pagAnamneses.Controls.Add(Me.SplitContainer2)
        Me.pagAnamneses.Controls.Add(Me.Panel3)
        Me.pagAnamneses.Location = New System.Drawing.Point(4, 22)
        Me.pagAnamneses.Name = "pagAnamneses"
        Me.pagAnamneses.Padding = New System.Windows.Forms.Padding(3)
        Me.pagAnamneses.Size = New System.Drawing.Size(976, 410)
        Me.pagAnamneses.TabIndex = 0
        Me.pagAnamneses.Text = "Ekstraģenitālā pataloģija/Operācijas"
        Me.pagAnamneses.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 60)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(970, 347)
        Me.SplitContainer2.SplitterDistance = 169
        Me.SplitContainer2.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdExtragenitalPathalogy)
        Me.GroupBox1.Controls.Add(Me.gbhExtragenitalPathalogy)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 169)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ekstraģenitālā pataloģija"
        '
        'grdExtragenitalPathalogy
        '
        Me.grdExtragenitalPathalogy.DataSource = Me.bndExtragenitalPathalogy
        Me.grdExtragenitalPathalogy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdExtragenitalPathalogy.EmbeddedNavigator.Name = ""
        Me.grdExtragenitalPathalogy.EnforceCanEdit = False
        Me.grdExtragenitalPathalogy.Location = New System.Drawing.Point(3, 74)
        Me.grdExtragenitalPathalogy.MainView = Me.gvwExtragenitalPathalogy
        Me.grdExtragenitalPathalogy.Name = "grdExtragenitalPathalogy"
        Me.grdExtragenitalPathalogy.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtExtragenitalPathalogy, Me.txtExtragenitalPathalogyNotes})
        Me.grdExtragenitalPathalogy.ShowOnlyActive = False
        Me.grdExtragenitalPathalogy.Size = New System.Drawing.Size(964, 92)
        Me.grdExtragenitalPathalogy.TabIndex = 2
        Me.grdExtragenitalPathalogy.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwExtragenitalPathalogy})
        '
        'bndExtragenitalPathalogy
        '
        Me.bndExtragenitalPathalogy.DataSource = GetType(Entities.AnamnesesExtragenitalPathalogy)
        '
        'gvwExtragenitalPathalogy
        '
        Me.gvwExtragenitalPathalogy.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colExtragenitalPathalogy, Me.colExtragenitalPathalogyNotes, Me.colExtragenitalPathalogyIsActive})
        Me.gvwExtragenitalPathalogy.GridControl = Me.grdExtragenitalPathalogy
        Me.gvwExtragenitalPathalogy.Name = "gvwExtragenitalPathalogy"
        Me.gvwExtragenitalPathalogy.OptionsView.ColumnAutoWidth = False
        Me.gvwExtragenitalPathalogy.OptionsView.ShowFilterPanel = False
        Me.gvwExtragenitalPathalogy.OptionsView.ShowGroupPanel = False
        '
        'colExtragenitalPathalogy
        '
        Me.colExtragenitalPathalogy.Caption = "Dizagnoze"
        Me.colExtragenitalPathalogy.ColumnEdit = Me.txtExtragenitalPathalogy
        Me.colExtragenitalPathalogy.FieldName = "ExtragenitalPathalogy"
        Me.colExtragenitalPathalogy.Name = "colExtragenitalPathalogy"
        Me.colExtragenitalPathalogy.Visible = True
        Me.colExtragenitalPathalogy.VisibleIndex = 0
        Me.colExtragenitalPathalogy.Width = 391
        '
        'txtExtragenitalPathalogy
        '
        Me.txtExtragenitalPathalogy.AutoHeight = False
        Me.txtExtragenitalPathalogy.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtExtragenitalPathalogy.MaxLength = 1000
        Me.txtExtragenitalPathalogy.Name = "txtExtragenitalPathalogy"
        Me.txtExtragenitalPathalogy.ShowIcon = False
        '
        'colExtragenitalPathalogyNotes
        '
        Me.colExtragenitalPathalogyNotes.Caption = "Diagnozes apraksts"
        Me.colExtragenitalPathalogyNotes.ColumnEdit = Me.txtExtragenitalPathalogyNotes
        Me.colExtragenitalPathalogyNotes.FieldName = "Notes"
        Me.colExtragenitalPathalogyNotes.Name = "colExtragenitalPathalogyNotes"
        Me.colExtragenitalPathalogyNotes.Visible = True
        Me.colExtragenitalPathalogyNotes.VisibleIndex = 1
        Me.colExtragenitalPathalogyNotes.Width = 545
        '
        'txtExtragenitalPathalogyNotes
        '
        Me.txtExtragenitalPathalogyNotes.AutoHeight = False
        Me.txtExtragenitalPathalogyNotes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtExtragenitalPathalogyNotes.MaxLength = 2800
        Me.txtExtragenitalPathalogyNotes.Name = "txtExtragenitalPathalogyNotes"
        Me.txtExtragenitalPathalogyNotes.ShowIcon = False
        '
        'colExtragenitalPathalogyIsActive
        '
        Me.colExtragenitalPathalogyIsActive.Caption = "IsActive"
        Me.colExtragenitalPathalogyIsActive.FieldName = "IsActive"
        Me.colExtragenitalPathalogyIsActive.Name = "colExtragenitalPathalogyIsActive"
        '
        'gbhExtragenitalPathalogy
        '
        Me.gbhExtragenitalPathalogy.AutoSize = True
        Me.gbhExtragenitalPathalogy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhExtragenitalPathalogy.DeleteReason = False
        Me.gbhExtragenitalPathalogy.DeleteReasonColumn = Nothing
        Me.gbhExtragenitalPathalogy.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhExtragenitalPathalogy.Grid = Me.grdExtragenitalPathalogy
        Me.gbhExtragenitalPathalogy.GridDataSource = Me.bndExtragenitalPathalogy
        Me.gbhExtragenitalPathalogy.Location = New System.Drawing.Point(3, 45)
        Me.gbhExtragenitalPathalogy.Name = "gbhExtragenitalPathalogy"
        Me.gbhExtragenitalPathalogy.ShowActive = False
        Me.gbhExtragenitalPathalogy.ShowAdd = True
        Me.gbhExtragenitalPathalogy.ShowChk = True
        Me.gbhExtragenitalPathalogy.ShowDelete = True
        Me.gbhExtragenitalPathalogy.Size = New System.Drawing.Size(964, 29)
        Me.gbhExtragenitalPathalogy.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.RadioGroup1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 29)
        Me.Panel1.TabIndex = 0
        '
        'RadioGroup1
        '
        Me.RadioGroup1.AutoSize = True
        Me.RadioGroup1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup1.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "ExtragenitalPathology", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        YesNo7.StringValue = "Yes"
        Me.RadioGroup1.EditValue = YesNo7
        Me.RadioGroup1.Location = New System.Drawing.Point(3, 3)
        Me.RadioGroup1.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Size = New System.Drawing.Size(88, 23)
        Me.RadioGroup1.TabIndex = 0
        '
        'bndGynaecology
        '
        Me.bndGynaecology.DataSource = GetType(Entities.Gynaecology)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdOperations)
        Me.GroupBox2.Controls.Add(Me.gbhOperations)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(970, 174)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operācijas"
        '
        'grdOperations
        '
        Me.grdOperations.DataSource = Me.bndOperations
        Me.grdOperations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOperations.EmbeddedNavigator.Name = ""
        Me.grdOperations.EnforceCanEdit = False
        Me.grdOperations.Location = New System.Drawing.Point(3, 71)
        Me.grdOperations.MainView = Me.gvwOperations
        Me.grdOperations.Name = "grdOperations"
        Me.grdOperations.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtOperation, Me.txtOperationNotes})
        Me.grdOperations.ShowOnlyActive = False
        Me.grdOperations.Size = New System.Drawing.Size(964, 100)
        Me.grdOperations.TabIndex = 3
        Me.grdOperations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOperations})
        '
        'bndOperations
        '
        Me.bndOperations.DataSource = GetType(Entities.AnamnesesOperation)
        '
        'gvwOperations
        '
        Me.gvwOperations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOperation, Me.colOperationNotes, Me.colOperationIsActive})
        Me.gvwOperations.GridControl = Me.grdOperations
        Me.gvwOperations.Name = "gvwOperations"
        Me.gvwOperations.OptionsView.ColumnAutoWidth = False
        Me.gvwOperations.OptionsView.ShowFilterPanel = False
        Me.gvwOperations.OptionsView.ShowGroupPanel = False
        '
        'colOperation
        '
        Me.colOperation.Caption = "Operācija"
        Me.colOperation.ColumnEdit = Me.txtOperation
        Me.colOperation.FieldName = "Operation"
        Me.colOperation.Name = "colOperation"
        Me.colOperation.Visible = True
        Me.colOperation.VisibleIndex = 0
        Me.colOperation.Width = 390
        '
        'txtOperation
        '
        Me.txtOperation.AutoHeight = False
        Me.txtOperation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtOperation.MaxLength = 1000
        Me.txtOperation.Name = "txtOperation"
        Me.txtOperation.ShowIcon = False
        '
        'colOperationNotes
        '
        Me.colOperationNotes.Caption = "Operācijas apraksts"
        Me.colOperationNotes.ColumnEdit = Me.txtOperationNotes
        Me.colOperationNotes.FieldName = "Notes"
        Me.colOperationNotes.Name = "colOperationNotes"
        Me.colOperationNotes.Visible = True
        Me.colOperationNotes.VisibleIndex = 1
        Me.colOperationNotes.Width = 549
        '
        'txtOperationNotes
        '
        Me.txtOperationNotes.AutoHeight = False
        Me.txtOperationNotes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtOperationNotes.MaxLength = 2800
        Me.txtOperationNotes.Name = "txtOperationNotes"
        Me.txtOperationNotes.ShowIcon = False
        '
        'colOperationIsActive
        '
        Me.colOperationIsActive.Caption = "IsActive"
        Me.colOperationIsActive.FieldName = "IsActive"
        Me.colOperationIsActive.Name = "colOperationIsActive"
        '
        'gbhOperations
        '
        Me.gbhOperations.AutoSize = True
        Me.gbhOperations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhOperations.DeleteReason = False
        Me.gbhOperations.DeleteReasonColumn = Nothing
        Me.gbhOperations.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhOperations.Grid = Me.grdOperations
        Me.gbhOperations.GridDataSource = Me.bndOperations
        Me.gbhOperations.Location = New System.Drawing.Point(3, 42)
        Me.gbhOperations.Name = "gbhOperations"
        Me.gbhOperations.ShowActive = False
        Me.gbhOperations.ShowAdd = True
        Me.gbhOperations.ShowChk = True
        Me.gbhOperations.ShowDelete = True
        Me.gbhOperations.Size = New System.Drawing.Size(964, 29)
        Me.gbhOperations.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.RadioGroup2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(964, 26)
        Me.Panel2.TabIndex = 0
        '
        'RadioGroup2
        '
        Me.RadioGroup2.AutoSize = True
        Me.RadioGroup2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup2.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Operation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup2.EditValue = Nothing
        Me.RadioGroup2.Location = New System.Drawing.Point(6, 0)
        Me.RadioGroup2.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup2.Name = "RadioGroup2"
        Me.RadioGroup2.Size = New System.Drawing.Size(88, 23)
        Me.RadioGroup2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ClassifierPicker1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.dtpDateUntil)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.ClassifierPicker2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(970, 57)
        Me.Panel3.TabIndex = 16
        '
        'ClassifierPicker1
        '
        Me.ClassifierPicker1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Doctor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClassifierPicker1.Location = New System.Drawing.Point(77, 3)
        Me.ClassifierPicker1.Name = "ClassifierPicker1"
        Me.ClassifierPicker1.PickerPresets = Nothing
        Me.ClassifierPicker1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ClassifierPicker1.Size = New System.Drawing.Size(451, 20)
        Me.ClassifierPicker1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ârsts:"
        '
        'dtpDateUntil
        '
        Me.dtpDateUntil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateUntil.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "FillDate", True))
        Me.dtpDateUntil.EditValue = Nothing
        Me.dtpDateUntil.Location = New System.Drawing.Point(648, 3)
        Me.dtpDateUntil.Name = "dtpDateUntil"
        Me.dtpDateUntil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpDateUntil.Size = New System.Drawing.Size(313, 23)
        Me.dtpDateUntil.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(534, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Aizpildīšanas datums:"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "BloodPressure", True))
        Me.TextBox4.Location = New System.Drawing.Point(650, 29)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(147, 20)
        Me.TextBox4.TabIndex = 12
        Me.TextBox4.Text = "120/80 mm/Hg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Augums:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(534, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Asinsspiediens:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "Height", True))
        Me.TextBox3.Location = New System.Drawing.Point(77, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox3.TabIndex = 5
        '
        'ClassifierPicker2
        '
        Me.ClassifierPicker2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "BloodGroup", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClassifierPicker2.Location = New System.Drawing.Point(356, 29)
        Me.ClassifierPicker2.Name = "ClassifierPicker2"
        Me.ClassifierPicker2.PickerPresets = Nothing
        Me.ClassifierPicker2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ClassifierPicker2.Size = New System.Drawing.Size(172, 20)
        Me.ClassifierPicker2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Svars:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Asins grupa:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "Weight", True))
        Me.TextBox1.Location = New System.Drawing.Point(206, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(73, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(976, 410)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Alerģija/Ikdienas medikamenti"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.gbxAllergy)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer3.Size = New System.Drawing.Size(970, 404)
        Me.SplitContainer3.SplitterDistance = 202
        Me.SplitContainer3.TabIndex = 0
        '
        'gbxAllergy
        '
        Me.gbxAllergy.Controls.Add(Me.grdAllergy)
        Me.gbxAllergy.Controls.Add(Me.gbhAllergy)
        Me.gbxAllergy.Controls.Add(Me.Panel4)
        Me.gbxAllergy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxAllergy.Location = New System.Drawing.Point(0, 0)
        Me.gbxAllergy.Name = "gbxAllergy"
        Me.gbxAllergy.Size = New System.Drawing.Size(970, 202)
        Me.gbxAllergy.TabIndex = 0
        Me.gbxAllergy.TabStop = False
        Me.gbxAllergy.Text = "Alerģija"
        '
        'grdAllergy
        '
        Me.grdAllergy.DataSource = Me.bndAllergy
        Me.grdAllergy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAllergy.EmbeddedNavigator.Name = ""
        Me.grdAllergy.EnforceCanEdit = False
        Me.grdAllergy.Location = New System.Drawing.Point(3, 74)
        Me.grdAllergy.MainView = Me.gvwAllergy
        Me.grdAllergy.Name = "grdAllergy"
        Me.grdAllergy.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAllergy, Me.txtAllergyNotes})
        Me.grdAllergy.ShowOnlyActive = False
        Me.grdAllergy.Size = New System.Drawing.Size(964, 125)
        Me.grdAllergy.TabIndex = 4
        Me.grdAllergy.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwAllergy})
        '
        'bndAllergy
        '
        Me.bndAllergy.DataSource = GetType(Entities.AnamnesesAllergy)
        '
        'gvwAllergy
        '
        Me.gvwAllergy.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAllergy, Me.colAllergyNotes, Me.colAllergyIsActive})
        Me.gvwAllergy.GridControl = Me.grdAllergy
        Me.gvwAllergy.Name = "gvwAllergy"
        Me.gvwAllergy.OptionsView.ColumnAutoWidth = False
        Me.gvwAllergy.OptionsView.ShowFilterPanel = False
        Me.gvwAllergy.OptionsView.ShowGroupPanel = False
        '
        'colAllergy
        '
        Me.colAllergy.Caption = "Alerģija"
        Me.colAllergy.ColumnEdit = Me.txtAllergy
        Me.colAllergy.FieldName = "Allergy"
        Me.colAllergy.Name = "colAllergy"
        Me.colAllergy.Visible = True
        Me.colAllergy.VisibleIndex = 0
        Me.colAllergy.Width = 388
        '
        'txtAllergy
        '
        Me.txtAllergy.AutoHeight = False
        Me.txtAllergy.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtAllergy.MaxLength = 1000
        Me.txtAllergy.Name = "txtAllergy"
        Me.txtAllergy.ShowIcon = False
        '
        'colAllergyNotes
        '
        Me.colAllergyNotes.Caption = "Alerģijas apraksts"
        Me.colAllergyNotes.ColumnEdit = Me.txtAllergyNotes
        Me.colAllergyNotes.FieldName = "Notes"
        Me.colAllergyNotes.Name = "colAllergyNotes"
        Me.colAllergyNotes.Visible = True
        Me.colAllergyNotes.VisibleIndex = 1
        Me.colAllergyNotes.Width = 551
        '
        'txtAllergyNotes
        '
        Me.txtAllergyNotes.AutoHeight = False
        Me.txtAllergyNotes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtAllergyNotes.MaxLength = 2800
        Me.txtAllergyNotes.Name = "txtAllergyNotes"
        Me.txtAllergyNotes.ShowIcon = False
        '
        'colAllergyIsActive
        '
        Me.colAllergyIsActive.Caption = "IsActive"
        Me.colAllergyIsActive.FieldName = "IsActive"
        Me.colAllergyIsActive.Name = "colAllergyIsActive"
        '
        'gbhAllergy
        '
        Me.gbhAllergy.AutoSize = True
        Me.gbhAllergy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhAllergy.DeleteReason = False
        Me.gbhAllergy.DeleteReasonColumn = Nothing
        Me.gbhAllergy.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhAllergy.Grid = Me.grdAllergy
        Me.gbhAllergy.GridDataSource = Me.bndAllergy
        Me.gbhAllergy.Location = New System.Drawing.Point(3, 45)
        Me.gbhAllergy.Name = "gbhAllergy"
        Me.gbhAllergy.ShowActive = False
        Me.gbhAllergy.ShowAdd = True
        Me.gbhAllergy.ShowChk = True
        Me.gbhAllergy.ShowDelete = True
        Me.gbhAllergy.Size = New System.Drawing.Size(964, 29)
        Me.gbhAllergy.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.Controls.Add(Me.rgbAllergy)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(964, 29)
        Me.Panel4.TabIndex = 0
        '
        'rgbAllergy
        '
        Me.rgbAllergy.AutoSize = True
        Me.rgbAllergy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rgbAllergy.BackColor = System.Drawing.Color.Transparent
        Me.rgbAllergy.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Allergy", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rgbAllergy.EditValue = Nothing
        Me.rgbAllergy.Location = New System.Drawing.Point(3, 3)
        Me.rgbAllergy.MinimumSize = New System.Drawing.Size(30, 10)
        Me.rgbAllergy.Name = "rgbAllergy"
        Me.rgbAllergy.Size = New System.Drawing.Size(88, 23)
        Me.rgbAllergy.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grdUsedMedicaments)
        Me.GroupBox4.Controls.Add(Me.gbhUsedMedicaments)
        Me.GroupBox4.Controls.Add(Me.Panel5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(970, 198)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ikdienā lietojamie medikamenti"
        '
        'grdUsedMedicaments
        '
        Me.grdUsedMedicaments.DataSource = Me.bndUsedMedicaments
        Me.grdUsedMedicaments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdUsedMedicaments.EmbeddedNavigator.Name = ""
        Me.grdUsedMedicaments.EnforceCanEdit = False
        Me.grdUsedMedicaments.Location = New System.Drawing.Point(3, 74)
        Me.grdUsedMedicaments.MainView = Me.gvwUsedMedicaments
        Me.grdUsedMedicaments.Name = "grdUsedMedicaments"
        Me.grdUsedMedicaments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtUsedMedicaments, Me.txtUsedMedicamentsNotes})
        Me.grdUsedMedicaments.ShowOnlyActive = False
        Me.grdUsedMedicaments.Size = New System.Drawing.Size(964, 121)
        Me.grdUsedMedicaments.TabIndex = 4
        Me.grdUsedMedicaments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwUsedMedicaments})
        '
        'bndUsedMedicaments
        '
        Me.bndUsedMedicaments.DataSource = GetType(Entities.AnamnesesUsedMedicaments)
        '
        'gvwUsedMedicaments
        '
        Me.gvwUsedMedicaments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUsedMedicaments, Me.colUsedMedicamentsNotes, Me.colUsedMedicamentsIsActive})
        Me.gvwUsedMedicaments.GridControl = Me.grdUsedMedicaments
        Me.gvwUsedMedicaments.Name = "gvwUsedMedicaments"
        Me.gvwUsedMedicaments.OptionsView.ColumnAutoWidth = False
        Me.gvwUsedMedicaments.OptionsView.ShowFilterPanel = False
        Me.gvwUsedMedicaments.OptionsView.ShowGroupPanel = False
        '
        'colUsedMedicaments
        '
        Me.colUsedMedicaments.Caption = "Medikaments"
        Me.colUsedMedicaments.ColumnEdit = Me.txtUsedMedicaments
        Me.colUsedMedicaments.FieldName = "UsedMedicaments"
        Me.colUsedMedicaments.Name = "colUsedMedicaments"
        Me.colUsedMedicaments.Visible = True
        Me.colUsedMedicaments.VisibleIndex = 0
        Me.colUsedMedicaments.Width = 388
        '
        'txtUsedMedicaments
        '
        Me.txtUsedMedicaments.AutoHeight = False
        Me.txtUsedMedicaments.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtUsedMedicaments.MaxLength = 1000
        Me.txtUsedMedicaments.Name = "txtUsedMedicaments"
        Me.txtUsedMedicaments.ShowIcon = False
        '
        'colUsedMedicamentsNotes
        '
        Me.colUsedMedicamentsNotes.Caption = "Medikamenta apraksts"
        Me.colUsedMedicamentsNotes.ColumnEdit = Me.txtUsedMedicamentsNotes
        Me.colUsedMedicamentsNotes.FieldName = "Notes"
        Me.colUsedMedicamentsNotes.Name = "colUsedMedicamentsNotes"
        Me.colUsedMedicamentsNotes.Visible = True
        Me.colUsedMedicamentsNotes.VisibleIndex = 1
        Me.colUsedMedicamentsNotes.Width = 552
        '
        'txtUsedMedicamentsNotes
        '
        Me.txtUsedMedicamentsNotes.AutoHeight = False
        Me.txtUsedMedicamentsNotes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtUsedMedicamentsNotes.MaxLength = 2800
        Me.txtUsedMedicamentsNotes.Name = "txtUsedMedicamentsNotes"
        Me.txtUsedMedicamentsNotes.ShowIcon = False
        '
        'colUsedMedicamentsIsActive
        '
        Me.colUsedMedicamentsIsActive.Caption = "IsActive"
        Me.colUsedMedicamentsIsActive.FieldName = "IsActive"
        Me.colUsedMedicamentsIsActive.Name = "colUsedMedicamentsIsActive"
        '
        'gbhUsedMedicaments
        '
        Me.gbhUsedMedicaments.AutoSize = True
        Me.gbhUsedMedicaments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhUsedMedicaments.DeleteReason = False
        Me.gbhUsedMedicaments.DeleteReasonColumn = Nothing
        Me.gbhUsedMedicaments.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhUsedMedicaments.Grid = Me.grdUsedMedicaments
        Me.gbhUsedMedicaments.GridDataSource = Me.bndUsedMedicaments
        Me.gbhUsedMedicaments.Location = New System.Drawing.Point(3, 45)
        Me.gbhUsedMedicaments.Name = "gbhUsedMedicaments"
        Me.gbhUsedMedicaments.ShowActive = False
        Me.gbhUsedMedicaments.ShowAdd = True
        Me.gbhUsedMedicaments.ShowChk = True
        Me.gbhUsedMedicaments.ShowDelete = True
        Me.gbhUsedMedicaments.Size = New System.Drawing.Size(964, 29)
        Me.gbhUsedMedicaments.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.AutoSize = True
        Me.Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel5.Controls.Add(Me.RadioGroup4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(964, 29)
        Me.Panel5.TabIndex = 1
        '
        'RadioGroup4
        '
        Me.RadioGroup4.AutoSize = True
        Me.RadioGroup4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup4.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "UseMedicament", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup4.EditValue = Nothing
        Me.RadioGroup4.Location = New System.Drawing.Point(3, 3)
        Me.RadioGroup4.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup4.Name = "RadioGroup4"
        Me.RadioGroup4.Size = New System.Drawing.Size(88, 23)
        Me.RadioGroup4.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 410)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Attīstības anomālijas/Iedzimtās slimības"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer4.Size = New System.Drawing.Size(970, 404)
        Me.SplitContainer4.SplitterDistance = 200
        Me.SplitContainer4.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdEvolutionAnomaly)
        Me.GroupBox3.Controls.Add(Me.gbhEvolutionAnomaly)
        Me.GroupBox3.Controls.Add(Me.Panel6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(970, 200)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Attīstības anomālijas"
        '
        'grdEvolutionAnomaly
        '
        Me.grdEvolutionAnomaly.DataSource = Me.bndEvolutionAnomaly
        Me.grdEvolutionAnomaly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEvolutionAnomaly.EmbeddedNavigator.Name = ""
        Me.grdEvolutionAnomaly.EnforceCanEdit = False
        Me.grdEvolutionAnomaly.Location = New System.Drawing.Point(3, 74)
        Me.grdEvolutionAnomaly.MainView = Me.gvwEvolutionAnomaly
        Me.grdEvolutionAnomaly.Name = "grdEvolutionAnomaly"
        Me.grdEvolutionAnomaly.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtEvolutionAnomaly, Me.txtEvolutionAnomalyNotes})
        Me.grdEvolutionAnomaly.ShowOnlyActive = False
        Me.grdEvolutionAnomaly.Size = New System.Drawing.Size(964, 123)
        Me.grdEvolutionAnomaly.TabIndex = 4
        Me.grdEvolutionAnomaly.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwEvolutionAnomaly})
        '
        'bndEvolutionAnomaly
        '
        Me.bndEvolutionAnomaly.DataSource = GetType(Entities.AnamnesesEvolutionAnomaly)
        '
        'gvwEvolutionAnomaly
        '
        Me.gvwEvolutionAnomaly.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEvolutionAnomaly, Me.colEvolutionAnomalyNotes, Me.colEvolutionAnomalyIsActive})
        Me.gvwEvolutionAnomaly.GridControl = Me.grdEvolutionAnomaly
        Me.gvwEvolutionAnomaly.Name = "gvwEvolutionAnomaly"
        Me.gvwEvolutionAnomaly.OptionsView.ColumnAutoWidth = False
        Me.gvwEvolutionAnomaly.OptionsView.ShowFilterPanel = False
        Me.gvwEvolutionAnomaly.OptionsView.ShowGroupPanel = False
        '
        'colEvolutionAnomaly
        '
        Me.colEvolutionAnomaly.Caption = "Anomālija"
        Me.colEvolutionAnomaly.ColumnEdit = Me.txtEvolutionAnomaly
        Me.colEvolutionAnomaly.FieldName = "EvolutionAnomaly"
        Me.colEvolutionAnomaly.Name = "colEvolutionAnomaly"
        Me.colEvolutionAnomaly.Visible = True
        Me.colEvolutionAnomaly.VisibleIndex = 0
        Me.colEvolutionAnomaly.Width = 388
        '
        'txtEvolutionAnomaly
        '
        Me.txtEvolutionAnomaly.AutoHeight = False
        Me.txtEvolutionAnomaly.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtEvolutionAnomaly.MaxLength = 1000
        Me.txtEvolutionAnomaly.Name = "txtEvolutionAnomaly"
        Me.txtEvolutionAnomaly.ShowIcon = False
        '
        'colEvolutionAnomalyNotes
        '
        Me.colEvolutionAnomalyNotes.Caption = "Anomālijas apraksts"
        Me.colEvolutionAnomalyNotes.ColumnEdit = Me.txtEvolutionAnomalyNotes
        Me.colEvolutionAnomalyNotes.FieldName = "Notes"
        Me.colEvolutionAnomalyNotes.Name = "colEvolutionAnomalyNotes"
        Me.colEvolutionAnomalyNotes.Visible = True
        Me.colEvolutionAnomalyNotes.VisibleIndex = 1
        Me.colEvolutionAnomalyNotes.Width = 550
        '
        'txtEvolutionAnomalyNotes
        '
        Me.txtEvolutionAnomalyNotes.AutoHeight = False
        Me.txtEvolutionAnomalyNotes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtEvolutionAnomalyNotes.MaxLength = 2800
        Me.txtEvolutionAnomalyNotes.Name = "txtEvolutionAnomalyNotes"
        Me.txtEvolutionAnomalyNotes.ShowIcon = False
        '
        'colEvolutionAnomalyIsActive
        '
        Me.colEvolutionAnomalyIsActive.Caption = "IsActive"
        Me.colEvolutionAnomalyIsActive.FieldName = "IsActive"
        Me.colEvolutionAnomalyIsActive.Name = "colEvolutionAnomalyIsActive"
        '
        'gbhEvolutionAnomaly
        '
        Me.gbhEvolutionAnomaly.AutoSize = True
        Me.gbhEvolutionAnomaly.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhEvolutionAnomaly.DeleteReason = False
        Me.gbhEvolutionAnomaly.DeleteReasonColumn = Nothing
        Me.gbhEvolutionAnomaly.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhEvolutionAnomaly.Grid = Me.grdEvolutionAnomaly
        Me.gbhEvolutionAnomaly.GridDataSource = Me.bndEvolutionAnomaly
        Me.gbhEvolutionAnomaly.Location = New System.Drawing.Point(3, 45)
        Me.gbhEvolutionAnomaly.Name = "gbhEvolutionAnomaly"
        Me.gbhEvolutionAnomaly.ShowActive = False
        Me.gbhEvolutionAnomaly.ShowAdd = True
        Me.gbhEvolutionAnomaly.ShowChk = True
        Me.gbhEvolutionAnomaly.ShowDelete = True
        Me.gbhEvolutionAnomaly.Size = New System.Drawing.Size(964, 29)
        Me.gbhEvolutionAnomaly.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.AutoSize = True
        Me.Panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel6.Controls.Add(Me.RadioGroup3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(964, 29)
        Me.Panel6.TabIndex = 0
        '
        'RadioGroup3
        '
        Me.RadioGroup3.AutoSize = True
        Me.RadioGroup3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup3.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "EvolutionAnomaly", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup3.EditValue = Nothing
        Me.RadioGroup3.Location = New System.Drawing.Point(3, 3)
        Me.RadioGroup3.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup3.Name = "RadioGroup3"
        Me.RadioGroup3.Size = New System.Drawing.Size(88, 23)
        Me.RadioGroup3.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.grdHereditaryDsesase)
        Me.GroupBox5.Controls.Add(Me.gbhHereditaryDsesase)
        Me.GroupBox5.Controls.Add(Me.Panel7)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(970, 200)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Iedzimtās slimības"
        '
        'grdHereditaryDsesase
        '
        Me.grdHereditaryDsesase.DataSource = Me.bndHereditaryDsesase
        Me.grdHereditaryDsesase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdHereditaryDsesase.EmbeddedNavigator.Name = ""
        Me.grdHereditaryDsesase.EnforceCanEdit = False
        Me.grdHereditaryDsesase.Location = New System.Drawing.Point(3, 74)
        Me.grdHereditaryDsesase.MainView = Me.gvwHereditaryDsesase
        Me.grdHereditaryDsesase.Name = "grdHereditaryDsesase"
        Me.grdHereditaryDsesase.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtHereditaryDsesase, Me.txtHereditaryDsesaseNotes})
        Me.grdHereditaryDsesase.ShowOnlyActive = False
        Me.grdHereditaryDsesase.Size = New System.Drawing.Size(964, 123)
        Me.grdHereditaryDsesase.TabIndex = 4
        Me.grdHereditaryDsesase.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwHereditaryDsesase})
        '
        'bndHereditaryDsesase
        '
        Me.bndHereditaryDsesase.DataSource = GetType(Entities.AnamnesesHereditaryDsesase)
        '
        'gvwHereditaryDsesase
        '
        Me.gvwHereditaryDsesase.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHereditaryDsesase, Me.colHereditaryDsesaseNotes, Me.colHereditaryDsesaseIsActive})
        Me.gvwHereditaryDsesase.GridControl = Me.grdHereditaryDsesase
        Me.gvwHereditaryDsesase.Name = "gvwHereditaryDsesase"
        Me.gvwHereditaryDsesase.OptionsView.ColumnAutoWidth = False
        Me.gvwHereditaryDsesase.OptionsView.ShowFilterPanel = False
        Me.gvwHereditaryDsesase.OptionsView.ShowGroupPanel = False
        '
        'colHereditaryDsesase
        '
        Me.colHereditaryDsesase.Caption = "Slimība"
        Me.colHereditaryDsesase.ColumnEdit = Me.txtHereditaryDsesase
        Me.colHereditaryDsesase.FieldName = "ExtragenitalPathalogy"
        Me.colHereditaryDsesase.Name = "colHereditaryDsesase"
        Me.colHereditaryDsesase.Visible = True
        Me.colHereditaryDsesase.VisibleIndex = 0
        Me.colHereditaryDsesase.Width = 388
        '
        'txtHereditaryDsesase
        '
        Me.txtHereditaryDsesase.AutoHeight = False
        Me.txtHereditaryDsesase.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtHereditaryDsesase.MaxLength = 1000
        Me.txtHereditaryDsesase.Name = "txtHereditaryDsesase"
        Me.txtHereditaryDsesase.ShowIcon = False
        '
        'colHereditaryDsesaseNotes
        '
        Me.colHereditaryDsesaseNotes.Caption = "Slimības apraksts"
        Me.colHereditaryDsesaseNotes.ColumnEdit = Me.txtHereditaryDsesaseNotes
        Me.colHereditaryDsesaseNotes.FieldName = "Notes"
        Me.colHereditaryDsesaseNotes.Name = "colHereditaryDsesaseNotes"
        Me.colHereditaryDsesaseNotes.Visible = True
        Me.colHereditaryDsesaseNotes.VisibleIndex = 1
        Me.colHereditaryDsesaseNotes.Width = 550
        '
        'txtHereditaryDsesaseNotes
        '
        Me.txtHereditaryDsesaseNotes.AutoHeight = False
        Me.txtHereditaryDsesaseNotes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtHereditaryDsesaseNotes.MaxLength = 2800
        Me.txtHereditaryDsesaseNotes.Name = "txtHereditaryDsesaseNotes"
        Me.txtHereditaryDsesaseNotes.ShowIcon = False
        '
        'colHereditaryDsesaseIsActive
        '
        Me.colHereditaryDsesaseIsActive.Caption = "IsActive"
        Me.colHereditaryDsesaseIsActive.FieldName = "IsActive"
        Me.colHereditaryDsesaseIsActive.Name = "colHereditaryDsesaseIsActive"
        '
        'gbhHereditaryDsesase
        '
        Me.gbhHereditaryDsesase.AutoSize = True
        Me.gbhHereditaryDsesase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhHereditaryDsesase.DeleteReason = False
        Me.gbhHereditaryDsesase.DeleteReasonColumn = Nothing
        Me.gbhHereditaryDsesase.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhHereditaryDsesase.Grid = Me.grdHereditaryDsesase
        Me.gbhHereditaryDsesase.GridDataSource = Me.bndHereditaryDsesase
        Me.gbhHereditaryDsesase.Location = New System.Drawing.Point(3, 45)
        Me.gbhHereditaryDsesase.Name = "gbhHereditaryDsesase"
        Me.gbhHereditaryDsesase.ShowActive = False
        Me.gbhHereditaryDsesase.ShowAdd = True
        Me.gbhHereditaryDsesase.ShowChk = True
        Me.gbhHereditaryDsesase.ShowDelete = True
        Me.gbhHereditaryDsesase.Size = New System.Drawing.Size(964, 29)
        Me.gbhHereditaryDsesase.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.AutoSize = True
        Me.Panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel7.Controls.Add(Me.RadioGroup5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 16)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(964, 29)
        Me.Panel7.TabIndex = 1
        '
        'RadioGroup5
        '
        Me.RadioGroup5.AutoSize = True
        Me.RadioGroup5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup5.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "HereditaryDsesase", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup5.EditValue = Nothing
        Me.RadioGroup5.Location = New System.Drawing.Point(3, 3)
        Me.RadioGroup5.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup5.Name = "RadioGroup5"
        Me.RadioGroup5.Size = New System.Drawing.Size(88, 23)
        Me.RadioGroup5.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(976, 410)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Menarhe/Dzimumdzīve"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.RadioGroup10)
        Me.GroupBox8.Controls.Add(Me.RadioGroup9)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.TextBox10)
        Me.GroupBox8.Controls.Add(Me.TextBox11)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.RadioGroup8)
        Me.GroupBox8.Controls.Add(Me.TextBox9)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 182)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(970, 75)
        Me.GroupBox8.TabIndex = 20
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Dzimumpartneris"
        '
        'RadioGroup10
        '
        Me.RadioGroup10.AutoSize = True
        Me.RadioGroup10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup10.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Smoking", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup10.EditValue = Nothing
        Me.RadioGroup10.ListSourceMethod = "ListSourceNeJa"
        Me.RadioGroup10.Location = New System.Drawing.Point(54, 44)
        Me.RadioGroup10.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup10.Name = "RadioGroup10"
        Me.RadioGroup10.Size = New System.Drawing.Size(87, 23)
        Me.RadioGroup10.TabIndex = 27
        '
        'RadioGroup9
        '
        Me.RadioGroup9.AutoSize = True
        Me.RadioGroup9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup9.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "UseAlcohol", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup9.EditValue = Nothing
        Me.RadioGroup9.ListSourceMethod = "ListSourceNeJa"
        Me.RadioGroup9.Location = New System.Drawing.Point(242, 44)
        Me.RadioGroup9.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup9.Name = "RadioGroup9"
        Me.RadioGroup9.Size = New System.Drawing.Size(87, 23)
        Me.RadioGroup9.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(160, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Lieto alkoholu:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Smēķē:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(464, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Darbavieta:"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "LayAge", True))
        Me.TextBox10.Location = New System.Drawing.Point(396, 17)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(62, 20)
        Me.TextBox10.TabIndex = 21
        Me.TextBox10.Text = "15 līdz 20"
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "LayWorkPlace", True))
        Me.TextBox11.Location = New System.Drawing.Point(527, 17)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(437, 20)
        Me.TextBox11.TabIndex = 23
        Me.TextBox11.Text = "5 - 6"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(242, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Patreizējā partnera vecums:"
        '
        'RadioGroup8
        '
        Me.RadioGroup8.AutoSize = True
        Me.RadioGroup8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup8.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Lay", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup8.EditValue = Nothing
        Me.RadioGroup8.Location = New System.Drawing.Point(9, 15)
        Me.RadioGroup8.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup8.Name = "RadioGroup8"
        Me.RadioGroup8.Size = New System.Drawing.Size(158, 23)
        Me.RadioGroup8.TabIndex = 18
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "LayCount", True))
        Me.TextBox9.Location = New System.Drawing.Point(167, 17)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(69, 20)
        Me.TextBox9.TabIndex = 19
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.MemoExEdit2)
        Me.GroupBox7.Controls.Add(Me.RadioGroup7)
        Me.GroupBox7.Controls.Add(Me.TextBox8)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(3, 109)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(970, 73)
        Me.GroupBox7.TabIndex = 16
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Dzimumdzīve"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Piezīmes:"
        '
        'MemoExEdit2
        '
        Me.MemoExEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "SexLifeNotes", True))
        Me.MemoExEdit2.Location = New System.Drawing.Point(121, 45)
        Me.MemoExEdit2.Name = "MemoExEdit2"
        Me.MemoExEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.MemoExEdit2.Properties.ShowIcon = False
        Me.MemoExEdit2.Size = New System.Drawing.Size(843, 23)
        Me.MemoExEdit2.TabIndex = 15
        '
        'RadioGroup7
        '
        Me.RadioGroup7.AutoSize = True
        Me.RadioGroup7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup7.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "SexLifeFrequence", True))
        Me.RadioGroup7.EditValue = Nothing
        Me.RadioGroup7.Location = New System.Drawing.Point(177, 16)
        Me.RadioGroup7.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup7.Name = "RadioGroup7"
        Me.RadioGroup7.Size = New System.Drawing.Size(155, 23)
        Me.RadioGroup7.TabIndex = 10
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "SexLifeStart", True))
        Me.TextBox8.Location = New System.Drawing.Point(121, 19)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(51, 20)
        Me.TextBox8.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Dzimumdzīve uzsākta:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox7)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.RadioGroup6)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.MemoExEdit1)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.TextBox6)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(970, 106)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Menarhe"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "Menopause", True))
        Me.TextBox7.Location = New System.Drawing.Point(77, 71)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(77, 20)
        Me.TextBox7.TabIndex = 17
        Me.TextBox7.Text = "5 - 6"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Menopauze:"
        '
        'RadioGroup6
        '
        Me.RadioGroup6.AutoSize = True
        Me.RadioGroup6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup6.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Cycle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup6.EditValue = Nothing
        Me.RadioGroup6.Location = New System.Drawing.Point(169, 16)
        Me.RadioGroup6.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup6.Name = "RadioGroup6"
        Me.RadioGroup6.Size = New System.Drawing.Size(155, 23)
        Me.RadioGroup6.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "Menarhe", True))
        Me.TextBox2.Location = New System.Drawing.Point(77, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(51, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Piezīmes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Menarhe:"
        '
        'MemoExEdit1
        '
        Me.MemoExEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Notes", True))
        Me.MemoExEdit1.Location = New System.Drawing.Point(77, 45)
        Me.MemoExEdit1.Name = "MemoExEdit1"
        Me.MemoExEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.MemoExEdit1.Properties.ShowIcon = False
        Me.MemoExEdit1.Size = New System.Drawing.Size(887, 23)
        Me.MemoExEdit1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cikls:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(696, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Ilgums:"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "Periodicity", True))
        Me.TextBox5.Location = New System.Drawing.Point(429, 19)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(261, 20)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = "15 līdz 20"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndGynaecology, "Length", True))
        Me.TextBox6.Location = New System.Drawing.Point(742, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(222, 20)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = "5 - 6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(340, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Periodiskums:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(976, 410)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Medikamenti/Slimības"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.GroupBox9)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.GroupBox10)
        Me.SplitContainer5.Size = New System.Drawing.Size(976, 410)
        Me.SplitContainer5.SplitterDistance = 202
        Me.SplitContainer5.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.grdActyalMedicaments)
        Me.GroupBox9.Controls.Add(Me.gbhActyalMedicaments)
        Me.GroupBox9.Controls.Add(Me.FlowLayoutPanel3)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(976, 202)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Medikamnti"
        '
        'grdActyalMedicaments
        '
        Me.grdActyalMedicaments.DataSource = Me.bndActyalMedicaments
        Me.grdActyalMedicaments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdActyalMedicaments.EmbeddedNavigator.Name = ""
        Me.grdActyalMedicaments.EnforceCanEdit = False
        Me.grdActyalMedicaments.Location = New System.Drawing.Point(3, 74)
        Me.grdActyalMedicaments.MainView = Me.gvwActyalMedicaments
        Me.grdActyalMedicaments.Name = "grdActyalMedicaments"
        Me.grdActyalMedicaments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoExEdit2})
        Me.grdActyalMedicaments.ShowOnlyActive = False
        Me.grdActyalMedicaments.Size = New System.Drawing.Size(970, 125)
        Me.grdActyalMedicaments.TabIndex = 6
        Me.grdActyalMedicaments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwActyalMedicaments})
        '
        'bndActyalMedicaments
        '
        Me.bndActyalMedicaments.DataSource = GetType(Entities.GynaecologyActualMedicaments)
        '
        'gvwActyalMedicaments
        '
        Me.gvwActyalMedicaments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.grdActyalMedicament, Me.colActyalMedicamentNotes, Me.colActyalMedicamentsIsActive})
        Me.gvwActyalMedicaments.GridControl = Me.grdActyalMedicaments
        Me.gvwActyalMedicaments.Name = "gvwActyalMedicaments"
        Me.gvwActyalMedicaments.OptionsView.ColumnAutoWidth = False
        Me.gvwActyalMedicaments.OptionsView.ShowFilterPanel = False
        Me.gvwActyalMedicaments.OptionsView.ShowGroupPanel = False
        '
        'grdActyalMedicament
        '
        Me.grdActyalMedicament.Caption = "Medikaments"
        Me.grdActyalMedicament.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.grdActyalMedicament.FieldName = "Medicament"
        Me.grdActyalMedicament.Name = "grdActyalMedicament"
        Me.grdActyalMedicament.Visible = True
        Me.grdActyalMedicament.VisibleIndex = 0
        Me.grdActyalMedicament.Width = 388
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit1.MaxLength = 1000
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'colActyalMedicamentNotes
        '
        Me.colActyalMedicamentNotes.Caption = "Medikamenta apraksts"
        Me.colActyalMedicamentNotes.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.colActyalMedicamentNotes.FieldName = "Notes"
        Me.colActyalMedicamentNotes.Name = "colActyalMedicamentNotes"
        Me.colActyalMedicamentNotes.Visible = True
        Me.colActyalMedicamentNotes.VisibleIndex = 1
        Me.colActyalMedicamentNotes.Width = 550
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit2.MaxLength = 2800
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'colActyalMedicamentsIsActive
        '
        Me.colActyalMedicamentsIsActive.Caption = "IsActive"
        Me.colActyalMedicamentsIsActive.FieldName = "IsActive"
        Me.colActyalMedicamentsIsActive.Name = "colActyalMedicamentsIsActive"
        '
        'gbhActyalMedicaments
        '
        Me.gbhActyalMedicaments.AutoSize = True
        Me.gbhActyalMedicaments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhActyalMedicaments.DeleteReason = False
        Me.gbhActyalMedicaments.DeleteReasonColumn = Nothing
        Me.gbhActyalMedicaments.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhActyalMedicaments.Grid = Me.grdActyalMedicaments
        Me.gbhActyalMedicaments.GridDataSource = Me.bndActyalMedicaments
        Me.gbhActyalMedicaments.Location = New System.Drawing.Point(3, 45)
        Me.gbhActyalMedicaments.Name = "gbhActyalMedicaments"
        Me.gbhActyalMedicaments.ShowActive = False
        Me.gbhActyalMedicaments.ShowAdd = True
        Me.gbhActyalMedicaments.ShowChk = True
        Me.gbhActyalMedicaments.ShowDelete = True
        Me.gbhActyalMedicaments.Size = New System.Drawing.Size(970, 29)
        Me.gbhActyalMedicaments.TabIndex = 5
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.RadioGroup11)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(970, 29)
        Me.FlowLayoutPanel3.TabIndex = 0
        '
        'RadioGroup11
        '
        Me.RadioGroup11.AutoSize = True
        Me.RadioGroup11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup11.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Medicaments", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        YesNo8.StringValue = "Ja"
        Me.RadioGroup11.EditValue = YesNo8
        Me.RadioGroup11.ListSourceMethod = "ListSourceNeJa"
        Me.RadioGroup11.Location = New System.Drawing.Point(3, 3)
        Me.RadioGroup11.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup11.Name = "RadioGroup11"
        Me.RadioGroup11.Size = New System.Drawing.Size(87, 23)
        Me.RadioGroup11.TabIndex = 1
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.grdIlness)
        Me.GroupBox10.Controls.Add(Me.gbhIlness)
        Me.GroupBox10.Controls.Add(Me.FlowLayoutPanel4)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(976, 204)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Slimības"
        '
        'grdIlness
        '
        Me.grdIlness.DataSource = Me.bndIlness
        Me.grdIlness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdIlness.EmbeddedNavigator.Name = ""
        Me.grdIlness.EnforceCanEdit = False
        Me.grdIlness.Location = New System.Drawing.Point(3, 74)
        Me.grdIlness.MainView = Me.gvwIlness
        Me.grdIlness.Name = "grdIlness"
        Me.grdIlness.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit3, Me.RepositoryItemMemoExEdit4})
        Me.grdIlness.ShowOnlyActive = False
        Me.grdIlness.Size = New System.Drawing.Size(970, 127)
        Me.grdIlness.TabIndex = 6
        Me.grdIlness.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwIlness})
        '
        'bndIlness
        '
        Me.bndIlness.DataSource = GetType(Entities.GynaecologyIlness)
        '
        'gvwIlness
        '
        Me.gvwIlness.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIlness, Me.colIlnessNotes, Me.colIlnessIsActive})
        Me.gvwIlness.GridControl = Me.grdIlness
        Me.gvwIlness.Name = "gvwIlness"
        Me.gvwIlness.OptionsView.ColumnAutoWidth = False
        Me.gvwIlness.OptionsView.ShowFilterPanel = False
        Me.gvwIlness.OptionsView.ShowGroupPanel = False
        '
        'colIlness
        '
        Me.colIlness.Caption = "Slimība"
        Me.colIlness.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.colIlness.FieldName = "Ilness"
        Me.colIlness.Name = "colIlness"
        Me.colIlness.Visible = True
        Me.colIlness.VisibleIndex = 0
        Me.colIlness.Width = 388
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit3.MaxLength = 1000
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'colIlnessNotes
        '
        Me.colIlnessNotes.Caption = "Slimības apraksts"
        Me.colIlnessNotes.ColumnEdit = Me.RepositoryItemMemoExEdit4
        Me.colIlnessNotes.FieldName = "Notes"
        Me.colIlnessNotes.Name = "colIlnessNotes"
        Me.colIlnessNotes.Visible = True
        Me.colIlnessNotes.VisibleIndex = 1
        Me.colIlnessNotes.Width = 550
        '
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit4.MaxLength = 2800
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        Me.RepositoryItemMemoExEdit4.ShowIcon = False
        '
        'colIlnessIsActive
        '
        Me.colIlnessIsActive.Caption = "IsActive"
        Me.colIlnessIsActive.FieldName = "IsActive"
        Me.colIlnessIsActive.Name = "colIlnessIsActive"
        '
        'gbhIlness
        '
        Me.gbhIlness.AutoSize = True
        Me.gbhIlness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhIlness.DeleteReason = False
        Me.gbhIlness.DeleteReasonColumn = Nothing
        Me.gbhIlness.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhIlness.Grid = Me.grdIlness
        Me.gbhIlness.GridDataSource = Me.bndIlness
        Me.gbhIlness.Location = New System.Drawing.Point(3, 45)
        Me.gbhIlness.Name = "gbhIlness"
        Me.gbhIlness.ShowActive = False
        Me.gbhIlness.ShowAdd = True
        Me.gbhIlness.ShowChk = True
        Me.gbhIlness.ShowDelete = True
        Me.gbhIlness.Size = New System.Drawing.Size(970, 29)
        Me.gbhIlness.TabIndex = 5
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel4.Controls.Add(Me.RadioGroup12)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(970, 29)
        Me.FlowLayoutPanel4.TabIndex = 1
        '
        'RadioGroup12
        '
        Me.RadioGroup12.AutoSize = True
        Me.RadioGroup12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RadioGroup12.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGynaecology, "Ilness", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioGroup12.EditValue = Nothing
        Me.RadioGroup12.Location = New System.Drawing.Point(3, 3)
        Me.RadioGroup12.MinimumSize = New System.Drawing.Size(30, 10)
        Me.RadioGroup12.Name = "RadioGroup12"
        Me.RadioGroup12.Size = New System.Drawing.Size(88, 23)
        Me.RadioGroup12.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.SplitContainer6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(976, 410)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Dzemdības/Aborti"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.GroupBox11)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.GroupBox12)
        Me.SplitContainer6.Size = New System.Drawing.Size(970, 404)
        Me.SplitContainer6.SplitterDistance = 228
        Me.SplitContainer6.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.grdLabour)
        Me.GroupBox11.Controls.Add(Me.gbhLabour)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox11.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(970, 228)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Dzemdības"
        '
        'grdLabour
        '
        Me.grdLabour.DataSource = Me.bndLabour
        Me.grdLabour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdLabour.EmbeddedNavigator.Name = ""
        Me.grdLabour.EnforceCanEdit = False
        Me.grdLabour.Location = New System.Drawing.Point(3, 45)
        Me.grdLabour.MainView = Me.gvwLabour
        Me.grdLabour.Name = "grdLabour"
        Me.grdLabour.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtYear, Me.cmbSex, Me.txtWeight, Me.txtLactation, Me.cmbHealth, Me.txtTextContent, Me.cmbHealthNow})
        Me.grdLabour.ShowOnlyActive = False
        Me.grdLabour.Size = New System.Drawing.Size(964, 180)
        Me.grdLabour.TabIndex = 8
        Me.grdLabour.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwLabour})
        '
        'bndLabour
        '
        Me.bndLabour.DataSource = GetType(Entities.Labour)
        '
        'gvwLabour
        '
        Me.gvwLabour.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2})
        Me.gvwLabour.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colYear, Me.colWeight, Me.colSex, Me.colLactation, Me.colHealth, Me.colHealthNotes, Me.colHealthNow, Me.colHealthNowNotes, Me.GridColumn3})
        Me.gvwLabour.GridControl = Me.grdLabour
        Me.gvwLabour.Name = "gvwLabour"
        Me.gvwLabour.OptionsView.ShowFilterPanel = False
        Me.gvwLabour.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colYear)
        Me.GridBand1.Columns.Add(Me.colWeight)
        Me.GridBand1.Columns.Add(Me.GridColumn3)
        Me.GridBand1.Columns.Add(Me.colHealth)
        Me.GridBand1.Columns.Add(Me.colHealthNow)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.OptionsBand.AllowMove = False
        Me.GridBand1.OptionsBand.ShowCaption = False
        Me.GridBand1.OptionsBand.ShowInCustomizationForm = False
        Me.GridBand1.Width = 219
        '
        'colYear
        '
        Me.colYear.Caption = "Gads"
        Me.colYear.ColumnEdit = Me.txtYear
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.Width = 109
        '
        'txtYear
        '
        Me.txtYear.AutoHeight = False
        Me.txtYear.Mask.EditMask = "\d{4}"
        Me.txtYear.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtYear.Mask.ShowPlaceHolders = False
        Me.txtYear.Name = "txtYear"
        '
        'colWeight
        '
        Me.colWeight.Caption = "Svars"
        Me.colWeight.ColumnEdit = Me.txtWeight
        Me.colWeight.FieldName = "Weight"
        Me.colWeight.Name = "colWeight"
        Me.colWeight.Visible = True
        Me.colWeight.Width = 110
        '
        'txtWeight
        '
        Me.txtWeight.AutoHeight = False
        Me.txtWeight.Mask.EditMask = "\d{0,5}"
        Me.txtWeight.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtWeight.Mask.ShowPlaceHolders = False
        Me.txtWeight.Name = "txtWeight"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "IsActive"
        Me.GridColumn3.FieldName = "IsActive"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'colHealth
        '
        Me.colHealth.Caption = "Health"
        Me.colHealth.ColumnEdit = Me.cmbHealth
        Me.colHealth.FieldName = "Health"
        Me.colHealth.Name = "colHealth"
        Me.colHealth.RowIndex = 1
        Me.colHealth.Visible = True
        Me.colHealth.Width = 219
        '
        'cmbHealth
        '
        Me.cmbHealth.AutoHeight = False
        Me.cmbHealth.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbHealth.Name = "cmbHealth"
        '
        'colHealthNow
        '
        Me.colHealthNow.Caption = "Patreiz"
        Me.colHealthNow.ColumnEdit = Me.cmbHealthNow
        Me.colHealthNow.FieldName = "HealthNow"
        Me.colHealthNow.Name = "colHealthNow"
        Me.colHealthNow.RowIndex = 2
        Me.colHealthNow.Visible = True
        Me.colHealthNow.Width = 219
        '
        'cmbHealthNow
        '
        Me.cmbHealthNow.AutoHeight = False
        Me.cmbHealthNow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbHealthNow.Name = "cmbHealthNow"
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "gridBand1"
        Me.GridBand2.Columns.Add(Me.colSex)
        Me.GridBand2.Columns.Add(Me.colHealthNowNotes)
        Me.GridBand2.Columns.Add(Me.colHealthNotes)
        Me.GridBand2.Columns.Add(Me.colLactation)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.OptionsBand.AllowMove = False
        Me.GridBand2.OptionsBand.ShowCaption = False
        Me.GridBand2.OptionsBand.ShowInCustomizationForm = False
        Me.GridBand2.Width = 696
        '
        'colSex
        '
        Me.colSex.Caption = "Dzimums"
        Me.colSex.ColumnEdit = Me.cmbSex
        Me.colSex.FieldName = "Sex"
        Me.colSex.Name = "colSex"
        Me.colSex.Visible = True
        Me.colSex.Width = 113
        '
        'cmbSex
        '
        Me.cmbSex.AutoHeight = False
        Me.cmbSex.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbSex.Name = "cmbSex"
        '
        'colHealthNowNotes
        '
        Me.colHealthNowNotes.Caption = "Apraksts"
        Me.colHealthNowNotes.ColumnEdit = Me.txtTextContent
        Me.colHealthNowNotes.FieldName = "HealthNowNotes"
        Me.colHealthNowNotes.Name = "colHealthNowNotes"
        Me.colHealthNowNotes.RowIndex = 2
        Me.colHealthNowNotes.Visible = True
        Me.colHealthNowNotes.Width = 696
        '
        'txtTextContent
        '
        Me.txtTextContent.AutoHeight = False
        Me.txtTextContent.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtTextContent.Name = "txtTextContent"
        Me.txtTextContent.ShowIcon = False
        '
        'colHealthNotes
        '
        Me.colHealthNotes.Caption = "Apraksts"
        Me.colHealthNotes.ColumnEdit = Me.txtTextContent
        Me.colHealthNotes.FieldName = "HealthNotes"
        Me.colHealthNotes.Name = "colHealthNotes"
        Me.colHealthNotes.RowIndex = 1
        Me.colHealthNotes.Visible = True
        Me.colHealthNotes.Width = 696
        '
        'colLactation
        '
        Me.colLactation.Caption = "Laktācija līdz"
        Me.colLactation.ColumnEdit = Me.txtLactation
        Me.colLactation.FieldName = "Lactation"
        Me.colLactation.Name = "colLactation"
        Me.colLactation.Visible = True
        Me.colLactation.Width = 358
        '
        'txtLactation
        '
        Me.txtLactation.AutoHeight = False
        Me.txtLactation.Name = "txtLactation"
        '
        'gbhLabour
        '
        Me.gbhLabour.AutoSize = True
        Me.gbhLabour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhLabour.DeleteReason = False
        Me.gbhLabour.DeleteReasonColumn = Nothing
        Me.gbhLabour.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhLabour.Grid = Me.grdLabour
        Me.gbhLabour.GridDataSource = Me.bndLabour
        Me.gbhLabour.Location = New System.Drawing.Point(3, 16)
        Me.gbhLabour.Name = "gbhLabour"
        Me.gbhLabour.ShowActive = False
        Me.gbhLabour.ShowAdd = True
        Me.gbhLabour.ShowChk = True
        Me.gbhLabour.ShowDelete = True
        Me.gbhLabour.Size = New System.Drawing.Size(964, 29)
        Me.gbhLabour.TabIndex = 7
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.CoreGrid2)
        Me.GroupBox12.Controls.Add(Me.GridButtonHelper2)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(970, 172)
        Me.GroupBox12.TabIndex = 0
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Aborti"
        '
        'CoreGrid2
        '
        Me.CoreGrid2.DataSource = Me.bndActyalMedicaments
        Me.CoreGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoreGrid2.EmbeddedNavigator.Name = ""
        Me.CoreGrid2.EnforceCanEdit = False
        Me.CoreGrid2.Location = New System.Drawing.Point(3, 45)
        Me.CoreGrid2.MainView = Me.GridView2
        Me.CoreGrid2.Name = "CoreGrid2"
        Me.CoreGrid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit7, Me.RepositoryItemMemoExEdit8})
        Me.CoreGrid2.ShowOnlyActive = False
        Me.CoreGrid2.Size = New System.Drawing.Size(964, 124)
        Me.CoreGrid2.TabIndex = 8
        Me.CoreGrid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView2.GridControl = Me.CoreGrid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFilterPanel = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Medikaments"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemMemoExEdit7
        Me.GridColumn4.FieldName = "Medicament"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 388
        '
        'RepositoryItemMemoExEdit7
        '
        Me.RepositoryItemMemoExEdit7.AutoHeight = False
        Me.RepositoryItemMemoExEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit7.MaxLength = 1000
        Me.RepositoryItemMemoExEdit7.Name = "RepositoryItemMemoExEdit7"
        Me.RepositoryItemMemoExEdit7.ShowIcon = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Medikamenta apraksts"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemMemoExEdit8
        Me.GridColumn5.FieldName = "Notes"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 550
        '
        'RepositoryItemMemoExEdit8
        '
        Me.RepositoryItemMemoExEdit8.AutoHeight = False
        Me.RepositoryItemMemoExEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit8.MaxLength = 2800
        Me.RepositoryItemMemoExEdit8.Name = "RepositoryItemMemoExEdit8"
        Me.RepositoryItemMemoExEdit8.ShowIcon = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "IsActive"
        Me.GridColumn6.FieldName = "IsActive"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridButtonHelper2
        '
        Me.GridButtonHelper2.AutoSize = True
        Me.GridButtonHelper2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GridButtonHelper2.DeleteReason = False
        Me.GridButtonHelper2.DeleteReasonColumn = Nothing
        Me.GridButtonHelper2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridButtonHelper2.Grid = Me.CoreGrid2
        Me.GridButtonHelper2.GridDataSource = Me.bndActyalMedicaments
        Me.GridButtonHelper2.Location = New System.Drawing.Point(3, 16)
        Me.GridButtonHelper2.Name = "GridButtonHelper2"
        Me.GridButtonHelper2.ShowActive = False
        Me.GridButtonHelper2.ShowAdd = True
        Me.GridButtonHelper2.ShowChk = True
        Me.GridButtonHelper2.ShowDelete = True
        Me.GridButtonHelper2.Size = New System.Drawing.Size(964, 29)
        Me.GridButtonHelper2.TabIndex = 7
        '
        'frmGynaecology
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 464)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmGynaecology"
        Me.Text = "Ginekoloģuiskā karte"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.pagAnamneses.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdExtragenitalPathalogy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndExtragenitalPathalogy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwExtragenitalPathalogy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtragenitalPathalogy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtragenitalPathalogyNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bndGynaecology, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdOperations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndOperations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOperations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperationNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateUntil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassifierPicker2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.gbxAllergy.ResumeLayout(False)
        Me.gbxAllergy.PerformLayout()
        CType(Me.grdAllergy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndAllergy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwAllergy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllergy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllergyNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.grdUsedMedicaments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndUsedMedicaments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwUsedMedicaments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsedMedicaments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsedMedicamentsNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grdEvolutionAnomaly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndEvolutionAnomaly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwEvolutionAnomaly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEvolutionAnomaly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEvolutionAnomalyNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.grdHereditaryDsesase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndHereditaryDsesase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwHereditaryDsesase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHereditaryDsesase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHereditaryDsesaseNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.MemoExEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.MemoExEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.grdActyalMedicaments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndActyalMedicaments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwActyalMedicaments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.grdIlness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndIlness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwIlness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.grdLabour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndLabour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwLabour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbHealthNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTextContent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLactation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.CoreGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents pagAnamneses As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClassifierPicker1 As Client.ClassifierPicker
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ClassifierPicker2 As Client.ClassifierPicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDateUntil As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioGroup1 As Core.UI.RadioGroup
    Friend WithEvents bndGynaecology As System.Windows.Forms.BindingSource
    Friend WithEvents gbhExtragenitalPathalogy As Core.UI.GridButtonHelper
    Friend WithEvents grdExtragenitalPathalogy As Core.UI.CoreGrid
    Friend WithEvents gvwExtragenitalPathalogy As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndExtragenitalPathalogy As System.Windows.Forms.BindingSource
    Friend WithEvents colExtragenitalPathalogy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtragenitalPathalogyNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtragenitalPathalogyIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtExtragenitalPathalogy As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdOperations As Core.UI.CoreGrid
    Friend WithEvents gvwOperations As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtOperation As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents gbhOperations As Core.UI.GridButtonHelper
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadioGroup2 As Core.UI.RadioGroup
    Friend WithEvents bndOperations As System.Windows.Forms.BindingSource
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperationNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperationIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbxAllergy As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rgbAllergy As Core.UI.RadioGroup
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RadioGroup4 As Core.UI.RadioGroup
    Friend WithEvents bndAllergy As System.Windows.Forms.BindingSource
    Friend WithEvents bndUsedMedicaments As System.Windows.Forms.BindingSource
    Friend WithEvents bndEvolutionAnomaly As System.Windows.Forms.BindingSource
    Friend WithEvents bndHereditaryDsesase As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents grdAllergy As Core.UI.CoreGrid
    Friend WithEvents gvwAllergy As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAllergy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAllergy As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colAllergyNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllergyIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbhAllergy As Core.UI.GridButtonHelper
    Friend WithEvents grdUsedMedicaments As Core.UI.CoreGrid
    Friend WithEvents gvwUsedMedicaments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUsedMedicaments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtUsedMedicaments As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colUsedMedicamentsNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsedMedicamentsIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbhUsedMedicaments As Core.UI.GridButtonHelper
    Friend WithEvents grdEvolutionAnomaly As Core.UI.CoreGrid
    Friend WithEvents gvwEvolutionAnomaly As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEvolutionAnomaly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEvolutionAnomaly As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colEvolutionAnomalyNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEvolutionAnomalyIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbhEvolutionAnomaly As Core.UI.GridButtonHelper
    Friend WithEvents grdHereditaryDsesase As Core.UI.CoreGrid
    Friend WithEvents gvwHereditaryDsesase As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHereditaryDsesase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtHereditaryDsesase As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colHereditaryDsesaseNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHereditaryDsesaseIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbhHereditaryDsesase As Core.UI.GridButtonHelper
    Friend WithEvents txtAllergyNotes As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents txtUsedMedicamentsNotes As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents txtEvolutionAnomalyNotes As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents txtHereditaryDsesaseNotes As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents txtExtragenitalPathalogyNotes As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents txtOperationNotes As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MemoExEdit1 As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioGroup6 As Core.UI.RadioGroup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RadioGroup7 As Core.UI.RadioGroup
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MemoExEdit2 As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents RadioGroup8 As Core.UI.RadioGroup
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents RadioGroup10 As Core.UI.RadioGroup
    Friend WithEvents RadioGroup9 As Core.UI.RadioGroup
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents RadioGroup3 As Core.UI.RadioGroup
    Friend WithEvents RadioGroup5 As Core.UI.RadioGroup
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RadioGroup11 As Core.UI.RadioGroup
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RadioGroup12 As Core.UI.RadioGroup
    Friend WithEvents grdActyalMedicaments As Core.UI.CoreGrid
    Friend WithEvents gvwActyalMedicaments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdActyalMedicament As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colActyalMedicamentNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colActyalMedicamentsIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbhActyalMedicaments As Core.UI.GridButtonHelper
    Friend WithEvents grdIlness As Core.UI.CoreGrid
    Friend WithEvents gvwIlness As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIlness As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colIlnessNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colIlnessIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbhIlness As Core.UI.GridButtonHelper
    Friend WithEvents bndActyalMedicaments As System.Windows.Forms.BindingSource
    Friend WithEvents bndIlness As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents grdLabour As Core.UI.CoreGrid
    Friend WithEvents gbhLabour As Core.UI.GridButtonHelper
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents CoreGrid2 As Core.UI.CoreGrid
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridButtonHelper2 As Core.UI.GridButtonHelper
    Friend WithEvents txtYear As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bndLabour As System.Windows.Forms.BindingSource
    Friend WithEvents gvwLabour As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colYear As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWeight As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSex As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLactation As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colHealth As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colHealthNotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colHealthNow As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colHealthNowNotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents txtWeight As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmbSex As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbHealth As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbHealthNow As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents txtTextContent As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents txtLactation As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
