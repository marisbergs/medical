Imports Core
Imports System
Imports Entities
Imports Core.Bll
Imports Core.Dal.Expressions
Imports System.Diagnostics
Imports System.Net


Public Class frmMain
    Public CancelClosing As Boolean = False
    Private withCode As Boolean = False

    Public Sub AddChild(ByVal child As Form, Optional ByVal shareSession As Boolean = False)
        child.MdiParent = Me
        If TypeOf child Is frmBase And shareSession Then
            CType(child, frmBase).Session = Me.Session
        End If
        child.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub mnuForms_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuForms.DropDownItemClicked
        Dim t As System.Type = CType(e.ClickedItem.Tag, Type)
        Try
            Dim frm As Form = CType(Activator.CreateInstance(t, True), Form)
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Context.Current.AuthenticatedUser Is Nothing Then
            If CancelClosing Then
                e.Cancel = True
                CancelClosing = False
            Else
                If Core.UI.MsgBox.Show(Core.ErrMsg.GetText(Core.Msg.CloseApp), MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DevExpress.XtraEditors.Controls.Localizer.Active = New Core.UI.DevExpressLocalizer()
            ''Core.Localization.Instance.Localize(Me)
            lblCurrentUser.Text = ""
            ApplyVisibilityConstraintsToMenu()
            Dim login As New dlgLogin()
            If login.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Me.Close()
            Else
                Lokalizacija()
                lblCurrentUser.Text = String.Format("{0}", Context.Current.ImpersonatedUser.FullName)
                Session = dlgLogin.Session
                If (Context.Current.ConnectedTo = Core.Dal.ConnectionTarget.Central) Then
                    Core.Bll.PermissionsChecker.Permissions.Add("Central", Nothing)
                End If
                ApplyVisibilityConstraintsToMenu()
                Text &= " " & Session.Get(Of SystemParameter)("APPLICATION_DB").Value
#If Not Debug Then
                Timer1.Start()
#End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Private Sub ApplyVisibilityConstraintsToMenu()
        For Each item As ToolStripMenuItem In MainMenu.Items
            ApplyVisibilityConstraints(item)
        Next
    End Sub

    Private Function ApplyVisibilityConstraints(ByVal parentItem As ToolStripMenuItem) As Boolean

        Dim result As Boolean = False
        Dim centralConn As Boolean = False
        If parentItem.DropDownItems.Count > 0 Then
            For Each item As ToolStripMenuItem In parentItem.DropDownItems
                result = ApplyVisibilityConstraints(item) OrElse result
            Next
            parentItem.Visible = result
            Return result
        End If

        ' Childless items are checked for necessary permissions
        If Not (parentItem.Tag Is Nothing) And (TypeOf parentItem.Tag Is String) Then
            Dim codeString As String = CType(parentItem.Tag, String).Trim()
            Dim permissionCodes As String() = codeString.Split(" "c)
            If permissionCodes.Length > 0 Then
                For Each permissionCode As String In permissionCodes
                    If permissionCode = "Central" Then
                        If Core.Bll.PermissionsChecker.CanDo(permissionCode) Then
                            For Each permCode As String In permissionCodes
                                If permCode <> "Central" Then
                                    If Core.Bll.PermissionsChecker.CanDo(permCode) Then
                                        parentItem.Visible = True
                                        Return True
                                    End If
                                End If
                            Next
                            parentItem.Visible = False
                            Return False
                        Else
                            parentItem.Visible = False
                            Return False
                        End If
                    End If
                Next
                For Each permCode As String In permissionCodes
                    If Core.Bll.PermissionsChecker.CanDo(permCode) Then
                        parentItem.Visible = True
                        Return True
                    End If
                Next
                parentItem.Visible = False
                Return False
            Else
                ' No specific permissions required
                parentItem.Visible = True
                Return True
            End If
        Else
            ' No specific permissions required
            parentItem.Visible = True
            Return True
        End If

    End Function
    
    Private Sub mitTemplates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitTemplates.Click
        AddChild(New frmTemplateList)
    End Sub

    Private Sub mitUserList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitUserList.Click
        Dim frm As New frmUsers
        frm.FormMode = UI.ClassifierListMode.Edit
        AddChild(frm)
    End Sub

    Private Sub mitClassifiers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitClassifiers.Click
        AddChild(New frmClassifierTypeList)
    End Sub

    Private Sub mitPermissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitPermissions.Click
        AddChild(New frmRolesManagement)
    End Sub

    'Private Sub NotikumuŽurnālaAdministrēšanaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    AddChild(New frmLoggingManagement)
    'End Sub

    Private Sub itmAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmAbout.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub mitSysConfiguration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitSysConfiguration.Click
        AddChild(New frmSystemParameters)
    End Sub

    Private Sub itmHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmHelp.Click
        'Dim mURL As String = ""
        'Try
        '    mURL = Application.StartupPath + "\HELP\help_all.chm"
        '    Process.Start(mURL)
        'Catch ex As Exception
        '    MessageBox.Show("Palīdzības sistēma (Help) nav pieejama ['" + mURL + "'] vietā!")
        'End Try
    End Sub

    Private Sub mitRoomsSpecialities_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitRoomsSpecialities.Click
        AddChild(New frmClassifierLinkingManagement(GetType(RoomGroups), GetType(Speciality), mitRoomsSpecialities.Text))
    End Sub

    Private Sub mitRoomgroupsRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitRoomgroupsRooms.Click
        AddChild(New frmClassifierLinkingManagement(GetType(Speciality), GetType(Services), mitRoomgroupsRooms.Text))
    End Sub

    Private Sub mitCMCaseLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmClientSimple.Click
        Dim frm As New frmPatients
        frm.FormMode = UI.ClassifierListMode.Edit
        AddChild(frm)
    End Sub

    Private Sub mitContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitContacts.Click
        AddChild(New frmContacts)
    End Sub

    Private Sub mitPlanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitPlanner.Click
        AddChild(New frmWorkTime)
    End Sub

    Private Sub VizitesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitVisitsPlanner.Click
        AddChild(New frmPlanner)
    End Sub

    Private Sub mitSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitSMS.Click
        AddChild(New frmSMSManager)
    End Sub

    Private Sub mitVisits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitVisits.Click
        AddChild(New frmVisits)
    End Sub

    Private Sub mitSpecialityGroupsSpeciality_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitSpecialityGroupsSpeciality.Click
        AddChild(New frmClassifierLinkingManagement(GetType(SpecialityGroups), GetType(Speciality), mitSpecialityGroupsSpeciality.Text))
    End Sub

    Private Sub mitViewDoctorService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitViewDoctorService.Click
        AddChild(New frmDoctorServices)
    End Sub

    Private Sub mitServicesRoomGroups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitServicesRoomGroups.Click
        AddChild(New frmClassifierLinkingManagement(GetType(Services), GetType(RoomGroups), mitServicesRoomGroups.Text))
    End Sub

    Private Sub ArKoduToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArKoduToolStripMenuItem.Click
        GetServices()
        Dim template As Template = Session.Get(Of Template)(template.PricelistWithCode)
        Session.Refresh(template)

        Dim templateStream As IO.Stream = template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        context.Add("P03", bndData)

        Dim fileName As String = IO.Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        Dim File As BinaryFile = New BinaryFile(Session, fileName)
        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        Core.Helper.RunShell(tempPath)
    End Sub

    Private Sub GetServices()
        bndData.Clear()
        Dim lst As New Dictionary(Of String, SortedDictionary(Of String, Dictionary(Of User, SortedDictionary(Of String, UserService))))
        Dim vispareja As String = Session.Get(Of Classifier)(Specialization.VisparejaMedicina).Value
        lst.Add(vispareja, New SortedDictionary(Of String, Dictionary(Of User, SortedDictionary(Of String, UserService))))
        Dim ginekologija As String = Session.Get(Of Classifier)(Specialization.Ginekologija).Value
        lst.Add(ginekologija, New SortedDictionary(Of String, Dictionary(Of User, SortedDictionary(Of String, UserService))))
        Dim pediatrija As String = Session.Get(Of Classifier)(Specialization.Pediatrija).Value
        lst.Add(pediatrija, New SortedDictionary(Of String, Dictionary(Of User, SortedDictionary(Of String, UserService))))
        Dim users As Entities(Of User)
        users = Entities(Of User).GetAll(Session, New IsNull("DeleteTime"), New Dal.Expressions.And(New Dal.Expressions.Le("WorksFrom", Today), New Dal.Expressions.Or(New Dal.Expressions.IsNull("WorkedUntil"), New Dal.Expressions.Ge("WorkedUntil", Today))))
        For Each user As User In users
            For Each userService As UserService In user.UserServices.ActiveItemsWithoutEmpty
                If userService.Service.IsActive AndAlso Not userService.Service.ReferenceThird Is Nothing Then
                    If userService.Service.ReferenceThird.Id = Specialization.VisparejaMedicina Then
                        If Not lst(vispareja).ContainsKey(user.Specialities & user.FullName) Then
                            lst(vispareja).Add(user.Specialities & user.FullName, New Dictionary(Of User, SortedDictionary(Of String, UserService)))
                            lst(vispareja)(user.Specialities & user.FullName).Add(user, New SortedDictionary(Of String, UserService))
                        End If
                        lst(vispareja)(user.Specialities & user.FullName)(user).Add(userService.Service.Value, userService)
                    End If
                    If userService.Service.ReferenceThird.Id = Specialization.Ginekologija Then
                        If Not lst(ginekologija).ContainsKey(user.Specialities & user.FullName) Then
                            lst(ginekologija).Add(user.Specialities & user.FullName, New Dictionary(Of User, SortedDictionary(Of String, UserService)))
                            lst(ginekologija)(user.Specialities & user.FullName).Add(user, New SortedDictionary(Of String, UserService))
                        End If
                        lst(ginekologija)(user.Specialities & user.FullName)(user).Add(userService.Service.Value, userService)
                    End If
                    If userService.Service.ReferenceThird.Id = Specialization.Pediatrija Then
                        If Not lst(pediatrija).ContainsKey(user.Specialities & user.FullName) Then
                            lst(pediatrija).Add(user.Specialities & user.FullName, New Dictionary(Of User, SortedDictionary(Of String, UserService)))
                            lst(pediatrija)(user.Specialities & user.FullName).Add(user, New SortedDictionary(Of String, UserService))
                        End If
                        lst(pediatrija)(user.Specialities & user.FullName)(user).Add(userService.Service.Value, userService)
                    End If
                End If
            Next
        Next
        Dim temp As New Dictionary(Of String, Core.Dal.ChildCollection(Of User))
        For Each pair As KeyValuePair(Of String, SortedDictionary(Of String, Dictionary(Of User, SortedDictionary(Of String, UserService)))) In lst
            temp.Add(Helper.ToRtfString(pair.Key), New Core.Dal.ChildCollection(Of User))
            For Each t As KeyValuePair(Of String, Dictionary(Of User, SortedDictionary(Of String, UserService))) In pair.Value
                For Each z As KeyValuePair(Of User, SortedDictionary(Of String, UserService)) In t.Value
                    Dim us As New User(Session)
                    us.FirstName = z.Key.FirstName
                    us.OtherNames = z.Key.OtherNames
                    us.LastName = z.Key.LastName
                    us.Specialities = z.Key.Specialities
                    For Each j As KeyValuePair(Of String, UserService) In z.Value
                        us.UserServices.Add(j.Value)
                    Next
                    temp(Helper.ToRtfString(pair.Key)).Add(us)
                Next
            Next
        Next
        bndData.DataSource = temp
        'Dim cls As New Classifier
        'cls.ReferenceThird
    End Sub

    Private Sub BezAkalpojumaKodaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BezAkalpojumaKodaToolStripMenuItem.Click
        GetServices()
        Dim template As Template = Session.Get(Of Template)(template.PricelistWithoutCode)
        Session.Refresh(template)

        Dim templateStream As IO.Stream = template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        context.Add("P03", bndData)

        Dim fileName As String = IO.Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        Dim File As BinaryFile = New BinaryFile(Session, fileName)
        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        Core.Helper.RunShell(tempPath)
    End Sub

    Private Sub StatussStatussToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatussStatussToolStripMenuItem.Click
        AddChild(New frmClassifierLinkingManagement(GetType(Statuss), GetType(Statuss), StatussStatussToolStripMenuItem.Text))
    End Sub

    Private Sub mitLocalSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitLocalSettings.Click
        AddChild(New frmLocalSettings)
    End Sub

    Private Sub mitPresentCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddChild(New frmPresentCards)
    End Sub

    Private Sub mitSalaryCalculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitSalaryCalculation.Click
        AddChild(New frmAccountingByDate)
    End Sub

    Private Sub CenuLapaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenuLapaToolStripMenuItem.Click
        AddChild(New frmPriceList)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Entities.Context.Current.AuthenticatedUser Is Nothing Then
            Return
        End If
        Dim publishingVersion As String = My.Application.Info.Version.ToString()
        Try
            publishingVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Catch ex As Exception
        End Try
        Dim val As SystemParameter = Session.Get(Of SystemParameter)("APP_VERSION")
        Session.Refresh(val)
        If val.Value <> publishingVersion.Split(".")(3) Then
            lblNewVersion.Visible = True
        Else
            lblNewVersion.Visible = False
        End If
    End Sub

    Private Sub itmInsurance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmInsurance.Click
        AddChild(New frmInsurance)
    End Sub

    Private Sub itmSmsSending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmSmsSending.Click
        AddChild(New frmSmsSending)
    End Sub

    Private Sub itmCampaign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmCampaign.Click
        AddChild(New frmCampaign(False))
    End Sub

    Private Sub itmActivity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmActivity.Click
        AddChild(New frmActivity)
    End Sub

    Private Sub itmGiftCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmGiftCards.Click
        AddChild(New frmPresentCards)
    End Sub

    Private Sub itmAbonnements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmAbonnements.Click
        AddChild(New frmSubscription)
    End Sub

    Private Sub mitAccounting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitAccounting.Click

    End Sub

    Private Sub itmClientGrouping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmClientGrouping.Click
        AddChild(New frmClientGrouping)
    End Sub

    Private Sub itmProfileEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmProfileEdit.Click
        AddChild(New frmPrimarasAprupesProfiluSaraksts)
    End Sub

    Private Sub itmProgrammTemplates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmProgrammTemplates.Click
        AddChild(New frmProgrammTemplateList(False))
    End Sub

    Private Sub itmProgramms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmProgramms.Click
        AddChild(New frmPatientProgrammList)
    End Sub

    Private Sub itmPAK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmPAK.Click
        AddChild(New frmPAKList)
    End Sub

    Private Sub itmIncomeSummary_Click(sender As System.Object, e As System.EventArgs) Handles itmIncomeSummary.Click
        AddChild(New frmIncomeSummary)
    End Sub

    Private Sub itmAccountingByPatient_Click(sender As System.Object, e As System.EventArgs) Handles itmAccountingByPatient.Click
        AddChild(New frmAccountingByPatient)
    End Sub

    Private Sub itmCosmetic_Click(sender As System.Object, e As System.EventArgs) Handles itmCosmetic.Click
        AddChild(New frmSalesList)
    End Sub

    Private Sub itmLocalization_Click(sender As System.Object, e As System.EventArgs) Handles itmLocalization.Click
        AddChild(New frmLocalization)
    End Sub
End Class
