Imports System
Imports System.Reflection


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.mitCMCaseLists = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmClientSimple = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmClientAdvanced = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmActivity = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitVisits = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitVisitsPlanner = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitPlanner = New System.Windows.Forms.ToolStripMenuItem()
        Me.DāvanuKartesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAbonnements = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmProgramms = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmGiftCards = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmPAK = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmCosmetic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitTemplates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitAdministration = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitSysConfiguration = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitSMS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitUserManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitUserList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitPermissions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitClassifiers = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmInsurance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitClassifierLinking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitRoomsSpecialities = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitRoomgroupsRooms = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitSpecialityGroupsSpeciality = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitServicesRoomGroups = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatussStatussToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitContacts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApdrošināšanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmProfileEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmProgrammTemplates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitLocalSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtskaitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitViewDoctorService = New System.Windows.Forms.ToolStripMenuItem()
        Me.PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArKoduToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BezAkalpojumaKodaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenuLapaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmClientGrouping = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitAccounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitSalaryCalculation = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmIncomeSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAccountingByPatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmServices = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSmsSending = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmCampaign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.PalīdzībaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCurrentUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblNewVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bndData = New System.Windows.Forms.BindingSource(Me.components)
        Me.itmLocalization = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitCMCaseLists, Me.itmActivity, Me.mitVisits, Me.mitVisitsPlanner, Me.mitPlanner, Me.DāvanuKartesToolStripMenuItem, Me.mitTemplates, Me.mitAdministration, Me.mitLocalSettings, Me.AtskaitesToolStripMenuItem, Me.mitAccounting, Me.itmServices, Me.mitWindows, Me.PalīdzībaToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.MdiWindowListItem = Me.mitWindows
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1092, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'mitCMCaseLists
        '
        Me.mitCMCaseLists.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmClientSimple, Me.itmClientAdvanced})
        Me.mitCMCaseLists.Name = "mitCMCaseLists"
        Me.mitCMCaseLists.Size = New System.Drawing.Size(52, 20)
        Me.mitCMCaseLists.Text = "Klienti"
        '
        'itmClientSimple
        '
        Me.itmClientSimple.Name = "itmClientSimple"
        Me.itmClientSimple.Size = New System.Drawing.Size(170, 22)
        Me.itmClientSimple.Text = "Klienti"
        '
        'itmClientAdvanced
        '
        Me.itmClientAdvanced.Name = "itmClientAdvanced"
        Me.itmClientAdvanced.Size = New System.Drawing.Size(170, 22)
        Me.itmClientAdvanced.Tag = "Menu.ClientAdvanced"
        Me.itmClientAdvanced.Text = "Klienti paplašināta"
        '
        'itmActivity
        '
        Me.itmActivity.Name = "itmActivity"
        Me.itmActivity.Size = New System.Drawing.Size(74, 20)
        Me.itmActivity.Text = "Aktivitātes"
        '
        'mitVisits
        '
        Me.mitVisits.Name = "mitVisits"
        Me.mitVisits.Size = New System.Drawing.Size(52, 20)
        Me.mitVisits.Text = "Vizītes"
        '
        'mitVisitsPlanner
        '
        Me.mitVisitsPlanner.Name = "mitVisitsPlanner"
        Me.mitVisitsPlanner.Size = New System.Drawing.Size(100, 20)
        Me.mitVisitsPlanner.Text = "Vizišu plānotājs"
        '
        'mitPlanner
        '
        Me.mitPlanner.Name = "mitPlanner"
        Me.mitPlanner.Size = New System.Drawing.Size(67, 20)
        Me.mitPlanner.Tag = "Menu.Planer"
        Me.mitPlanner.Text = "&Plānotājs"
        '
        'DāvanuKartesToolStripMenuItem
        '
        Me.DāvanuKartesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmAbonnements, Me.itmProgramms, Me.itmGiftCards, Me.itmPAK, Me.itmCosmetic})
        Me.DāvanuKartesToolStripMenuItem.Name = "DāvanuKartesToolStripMenuItem"
        Me.DāvanuKartesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.DāvanuKartesToolStripMenuItem.Text = "Pakalpojumi"
        '
        'itmAbonnements
        '
        Me.itmAbonnements.Name = "itmAbonnements"
        Me.itmAbonnements.Size = New System.Drawing.Size(148, 22)
        Me.itmAbonnements.Text = "Abonementi"
        '
        'itmProgramms
        '
        Me.itmProgramms.Name = "itmProgramms"
        Me.itmProgramms.Size = New System.Drawing.Size(148, 22)
        Me.itmProgramms.Text = "Programmas"
        '
        'itmGiftCards
        '
        Me.itmGiftCards.Name = "itmGiftCards"
        Me.itmGiftCards.Size = New System.Drawing.Size(148, 22)
        Me.itmGiftCards.Text = "Dāvanu kartes"
        '
        'itmPAK
        '
        Me.itmPAK.Name = "itmPAK"
        Me.itmPAK.Size = New System.Drawing.Size(148, 22)
        Me.itmPAK.Text = "PAK"
        '
        'itmCosmetic
        '
        Me.itmCosmetic.Name = "itmCosmetic"
        Me.itmCosmetic.Size = New System.Drawing.Size(148, 22)
        Me.itmCosmetic.Text = "Kosmētika"
        '
        'mitTemplates
        '
        Me.mitTemplates.Name = "mitTemplates"
        Me.mitTemplates.Size = New System.Drawing.Size(123, 20)
        Me.mitTemplates.Tag = "Menu.Templates"
        Me.mitTemplates.Text = "&Veidlapu pārvaldība"
        '
        'mitAdministration
        '
        Me.mitAdministration.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitSysConfiguration, Me.mitSMS, Me.mitUserManagement, Me.mitClassifiers, Me.itmInsurance, Me.mitClassifierLinking, Me.mitContacts, Me.ApdrošināšanaToolStripMenuItem, Me.itmProfileEdit, Me.itmProgrammTemplates, Me.itmLocalization})
        Me.mitAdministration.Name = "mitAdministration"
        Me.mitAdministration.Size = New System.Drawing.Size(101, 20)
        Me.mitAdministration.Tag = "Central"
        Me.mitAdministration.Text = "A&dministrēšana"
        '
        'mitSysConfiguration
        '
        Me.mitSysConfiguration.Name = "mitSysConfiguration"
        Me.mitSysConfiguration.Size = New System.Drawing.Size(199, 22)
        Me.mitSysConfiguration.Tag = "Menu.SystemConfiguration"
        Me.mitSysConfiguration.Text = "Sistēmas konfigurācija"
        '
        'mitSMS
        '
        Me.mitSMS.Name = "mitSMS"
        Me.mitSMS.Size = New System.Drawing.Size(199, 22)
        Me.mitSMS.Tag = "Menu.SmsAdministration"
        Me.mitSMS.Text = "Īsziņu administrēšana"
        '
        'mitUserManagement
        '
        Me.mitUserManagement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitUserList, Me.mitPermissions})
        Me.mitUserManagement.Name = "mitUserManagement"
        Me.mitUserManagement.Size = New System.Drawing.Size(199, 22)
        Me.mitUserManagement.Text = "Lietotāju pārvaldība"
        '
        'mitUserList
        '
        Me.mitUserList.Name = "mitUserList"
        Me.mitUserList.Size = New System.Drawing.Size(243, 22)
        Me.mitUserList.Tag = "Menu.UsersAdministration"
        Me.mitUserList.Text = "Darbinieku saraksts"
        '
        'mitPermissions
        '
        Me.mitPermissions.Name = "mitPermissions"
        Me.mitPermissions.Size = New System.Drawing.Size(243, 22)
        Me.mitPermissions.Tag = "Menu.PermissionsAdministration"
        Me.mitPermissions.Text = "Lomu un tiesību administrēšana"
        '
        'mitClassifiers
        '
        Me.mitClassifiers.Name = "mitClassifiers"
        Me.mitClassifiers.Size = New System.Drawing.Size(199, 22)
        Me.mitClassifiers.Tag = "Menu.ClassifierAdministration"
        Me.mitClassifiers.Text = "Klasifikatoru pārvaldība"
        '
        'itmInsurance
        '
        Me.itmInsurance.Name = "itmInsurance"
        Me.itmInsurance.Size = New System.Drawing.Size(199, 22)
        Me.itmInsurance.Text = "Apdrošināšana"
        '
        'mitClassifierLinking
        '
        Me.mitClassifierLinking.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitRoomsSpecialities, Me.mitRoomgroupsRooms, Me.mitSpecialityGroupsSpeciality, Me.mitServicesRoomGroups, Me.StatussStatussToolStripMenuItem})
        Me.mitClassifierLinking.Name = "mitClassifierLinking"
        Me.mitClassifierLinking.Size = New System.Drawing.Size(199, 22)
        Me.mitClassifierLinking.Text = "Klasifikatoru sasaiste"
        '
        'mitRoomsSpecialities
        '
        Me.mitRoomsSpecialities.Name = "mitRoomsSpecialities"
        Me.mitRoomsSpecialities.Size = New System.Drawing.Size(253, 22)
        Me.mitRoomsSpecialities.Text = "Kabinetu grupas -> Specialitātes"
        '
        'mitRoomgroupsRooms
        '
        Me.mitRoomgroupsRooms.Name = "mitRoomgroupsRooms"
        Me.mitRoomgroupsRooms.Size = New System.Drawing.Size(253, 22)
        Me.mitRoomgroupsRooms.Text = "Specialitāte->Pakalpojums"
        '
        'mitSpecialityGroupsSpeciality
        '
        Me.mitSpecialityGroupsSpeciality.Name = "mitSpecialityGroupsSpeciality"
        Me.mitSpecialityGroupsSpeciality.Size = New System.Drawing.Size(253, 22)
        Me.mitSpecialityGroupsSpeciality.Text = "Specialitāšu grupas->Specialitātes"
        '
        'mitServicesRoomGroups
        '
        Me.mitServicesRoomGroups.Name = "mitServicesRoomGroups"
        Me.mitServicesRoomGroups.Size = New System.Drawing.Size(253, 22)
        Me.mitServicesRoomGroups.Text = "Pakalpojumi -> Kabinetu grupas"
        '
        'StatussStatussToolStripMenuItem
        '
        Me.StatussStatussToolStripMenuItem.Name = "StatussStatussToolStripMenuItem"
        Me.StatussStatussToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.StatussStatussToolStripMenuItem.Text = "Statuss -> Statuss"
        '
        'mitContacts
        '
        Me.mitContacts.Name = "mitContacts"
        Me.mitContacts.Size = New System.Drawing.Size(199, 22)
        Me.mitContacts.Text = "Klīnikas dati"
        '
        'ApdrošināšanaToolStripMenuItem
        '
        Me.ApdrošināšanaToolStripMenuItem.Name = "ApdrošināšanaToolStripMenuItem"
        Me.ApdrošināšanaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ApdrošināšanaToolStripMenuItem.Tag = "Menu.Insurance"
        Me.ApdrošināšanaToolStripMenuItem.Text = "Apdrošināšana"
        '
        'itmProfileEdit
        '
        Me.itmProfileEdit.Name = "itmProfileEdit"
        Me.itmProfileEdit.Size = New System.Drawing.Size(199, 22)
        Me.itmProfileEdit.Tag = "Menu.ClassifierAdministration"
        Me.itmProfileEdit.Text = "Primārās aprūpes profili"
        '
        'itmProgrammTemplates
        '
        Me.itmProgrammTemplates.Name = "itmProgrammTemplates"
        Me.itmProgrammTemplates.Size = New System.Drawing.Size(199, 22)
        Me.itmProgrammTemplates.Tag = "Menu.ClassifierAdministration"
        Me.itmProgrammTemplates.Text = "Programmu apraksti"
        '
        'mitLocalSettings
        '
        Me.mitLocalSettings.Name = "mitLocalSettings"
        Me.mitLocalSettings.Size = New System.Drawing.Size(120, 20)
        Me.mitLocalSettings.Text = "Lokālie uzstādījumi"
        '
        'AtskaitesToolStripMenuItem
        '
        Me.AtskaitesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitViewDoctorService, Me.PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem, Me.CenuLapaToolStripMenuItem, Me.itmClientGrouping})
        Me.AtskaitesToolStripMenuItem.Name = "AtskaitesToolStripMenuItem"
        Me.AtskaitesToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AtskaitesToolStripMenuItem.Text = "Pārskati"
        '
        'mitViewDoctorService
        '
        Me.mitViewDoctorService.Name = "mitViewDoctorService"
        Me.mitViewDoctorService.Size = New System.Drawing.Size(411, 22)
        Me.mitViewDoctorService.Text = "Ārstu sniegtie pakalpojumi"
        '
        'PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem
        '
        Me.PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArKoduToolStripMenuItem, Me.BezAkalpojumaKodaToolStripMenuItem})
        Me.PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem.Name = "PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem"
        Me.PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem.Size = New System.Drawing.Size(411, 22)
        Me.PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem.Text = "Pakalpojumu saraksts sagrupēts pēc medicīniskās specializācijas"
        '
        'ArKoduToolStripMenuItem
        '
        Me.ArKoduToolStripMenuItem.Name = "ArKoduToolStripMenuItem"
        Me.ArKoduToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ArKoduToolStripMenuItem.Text = "Ar pakalpojuma kodu"
        '
        'BezAkalpojumaKodaToolStripMenuItem
        '
        Me.BezAkalpojumaKodaToolStripMenuItem.Name = "BezAkalpojumaKodaToolStripMenuItem"
        Me.BezAkalpojumaKodaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BezAkalpojumaKodaToolStripMenuItem.Text = "Bez pakalpojuma koda"
        '
        'CenuLapaToolStripMenuItem
        '
        Me.CenuLapaToolStripMenuItem.Name = "CenuLapaToolStripMenuItem"
        Me.CenuLapaToolStripMenuItem.Size = New System.Drawing.Size(411, 22)
        Me.CenuLapaToolStripMenuItem.Text = "Cenu lapa"
        '
        'itmClientGrouping
        '
        Me.itmClientGrouping.Name = "itmClientGrouping"
        Me.itmClientGrouping.Size = New System.Drawing.Size(411, 22)
        Me.itmClientGrouping.Text = "Klientu grupēšana"
        '
        'mitAccounting
        '
        Me.mitAccounting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitSalaryCalculation, Me.itmIncomeSummary, Me.itmAccountingByPatient})
        Me.mitAccounting.Name = "mitAccounting"
        Me.mitAccounting.Size = New System.Drawing.Size(93, 20)
        Me.mitAccounting.Tag = "Menu.Accounting"
        Me.mitAccounting.Text = "Grāmatvedība"
        '
        'mitSalaryCalculation
        '
        Me.mitSalaryCalculation.Name = "mitSalaryCalculation"
        Me.mitSalaryCalculation.Size = New System.Drawing.Size(207, 22)
        Me.mitSalaryCalculation.Tag = "Menu.Accounting"
        Me.mitSalaryCalculation.Text = "Algu aprēķins"
        '
        'itmIncomeSummary
        '
        Me.itmIncomeSummary.Name = "itmIncomeSummary"
        Me.itmIncomeSummary.Size = New System.Drawing.Size(207, 22)
        Me.itmIncomeSummary.Tag = "Menu.Accounting"
        Me.itmIncomeSummary.Text = "Ieņēmumu kopsavilkums"
        '
        'itmAccountingByPatient
        '
        Me.itmAccountingByPatient.Name = "itmAccountingByPatient"
        Me.itmAccountingByPatient.Size = New System.Drawing.Size(207, 22)
        Me.itmAccountingByPatient.Tag = "Menu.Accounting"
        Me.itmAccountingByPatient.Text = "Aprēķins pa klientiem"
        '
        'itmServices
        '
        Me.itmServices.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmSmsSending, Me.itmCampaign})
        Me.itmServices.Name = "itmServices"
        Me.itmServices.Size = New System.Drawing.Size(52, 20)
        Me.itmServices.Tag = "Menu.Services"
        Me.itmServices.Text = "Servisi"
        '
        'itmSmsSending
        '
        Me.itmSmsSending.Name = "itmSmsSending"
        Me.itmSmsSending.Size = New System.Drawing.Size(150, 22)
        Me.itmSmsSending.Tag = "Menu.Services"
        Me.itmSmsSending.Text = "Īsziņu sūtīšana"
        '
        'itmCampaign
        '
        Me.itmCampaign.Name = "itmCampaign"
        Me.itmCampaign.Size = New System.Drawing.Size(150, 22)
        Me.itmCampaign.Tag = "Menu.Services"
        Me.itmCampaign.Text = "Akcijas"
        '
        'mitWindows
        '
        Me.mitWindows.Name = "mitWindows"
        Me.mitWindows.Size = New System.Drawing.Size(42, 20)
        Me.mitWindows.Text = "&Logi"
        '
        'PalīdzībaToolStripMenuItem
        '
        Me.PalīdzībaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmHelp, Me.itmAbout})
        Me.PalīdzībaToolStripMenuItem.Name = "PalīdzībaToolStripMenuItem"
        Me.PalīdzībaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PalīdzībaToolStripMenuItem.Text = "Palī&dzība"
        '
        'itmHelp
        '
        Me.itmHelp.Name = "itmHelp"
        Me.itmHelp.Size = New System.Drawing.Size(121, 22)
        Me.itmHelp.Text = "Palīdzība"
        '
        'itmAbout
        '
        Me.itmAbout.Name = "itmAbout"
        Me.itmAbout.Size = New System.Drawing.Size(121, 22)
        Me.itmAbout.Text = "Par"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.DefaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCurrentUser, Me.lblNewVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 503)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1092, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(72, 17)
        Me.lblCurrentUser.Text = "Current user"
        '
        'lblNewVersion
        '
        Me.lblNewVersion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNewVersion.ForeColor = System.Drawing.Color.Red
        Me.lblNewVersion.Name = "lblNewVersion"
        Me.lblNewVersion.Size = New System.Drawing.Size(384, 17)
        Me.lblNewVersion.Text = "Pieejama jaunāka versija aizveriet aplikāciju un atveriet par jaunu"
        Me.lblNewVersion.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 6000
        '
        'itmLocalization
        '
        Me.itmLocalization.Name = "itmLocalization"
        Me.itmLocalization.Size = New System.Drawing.Size(199, 22)
        Me.itmLocalization.Tag = "Menu.Localization"
        Me.itmLocalization.Text = "Interfeisa tulkojums"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 525)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MainMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Medical"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        If Entities.Context.Current.DevelopmentDebugMode Then

            Me.mnuForms = New System.Windows.Forms.ToolStripMenuItem
            Me.mnuForms.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
            Me.mnuForms.Name = "mnuForms"
            Me.mnuForms.Size = New System.Drawing.Size(48, 20)
            Me.mnuForms.Text = "Forms"

            Dim assembly As Reflection.Assembly = Reflection.Assembly.LoadFrom("Client.exe")

            Dim types() As Type = assembly.GetTypes()


            Dim t As Type

            For Each t In types
                If (t.IsSubclassOf(GetType(Core.frmBase))) Then
                    Dim mnuItem As New System.Windows.Forms.ToolStripMenuItem

                    mnuItem.Text = t.Name
                    mnuItem.Tag = t

                    mnuForms.DropDownItems.Add(mnuItem)
                End If




            Next t

            Dim mnuItem1 As New System.Windows.Forms.ToolStripMenuItem

            mnuItem1.Text = "DictionaryBase"


            mnuItem1.Tag = Type.GetType("Core.frmDictionaryBase, Core")


            mnuForms.DropDownItems.Add(mnuItem1)

            Me.MainMenu.Items.Add(Me.mnuForms)
        End If
    End Sub
    Friend WithEvents mnuForms As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents mitCMCaseLists As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitPlanner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitTemplates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitAdministration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitSysConfiguration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitUserManagement As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitUserList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitPermissions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitClassifiers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblCurrentUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mitWindows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PalīdzībaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitClassifierLinking As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitRoomsSpecialities As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitRoomgroupsRooms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitContacts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitVisitsPlanner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitSMS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitVisits As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitSpecialityGroupsSpeciality As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtskaitesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitViewDoctorService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitServicesRoomGroups As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PakalpojumuSarakstsSagrupētsPēcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArKoduToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BezAkalpojumaKodaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bndData As System.Windows.Forms.BindingSource
    Friend WithEvents StatussStatussToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitLocalSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitAccounting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitSalaryCalculation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CenuLapaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNewVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ApdrošināšanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmInsurance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmServices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmSmsSending As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmCampaign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmActivity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DāvanuKartesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmAbonnements As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmProgramms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmGiftCards As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmClientGrouping As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmClientSimple As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmClientAdvanced As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmProfileEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmProgrammTemplates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmPAK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmIncomeSummary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmAccountingByPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmCosmetic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmLocalization As System.Windows.Forms.ToolStripMenuItem
End Class
