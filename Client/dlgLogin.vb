Imports System.ComponentModel
Imports Core.Bll
Imports Core.Dal
Imports NVelocity.Runtime.Directive
Imports Entities
Imports Core
Imports System.IO
Imports System.Globalization

Public Class dlgLogin
    Inherits Core.frmBase

    Private destFilePath As String

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim target As ConnectionTarget = Core.Dal.ConnectionTarget.Central
            Core.Dal.Manager.Instance.SetDefaultConnectionTarget(target)
            ' UpdateDbIfNeeded()
            Dim users As ICollection = Entities.Context.Current.Connect(txtLogin.Text, txtPassword.Text, _session, target)
            If users Is Nothing Then
                Core.UI.MsgBox.Show(Core.Err.InvalidLoginInformation, MessageBoxButtons.OK)
            ElseIf users.Count > 1 Then
                Me.UsernameLabel.Enabled = False
                Me.txtLogin.Enabled = False
                Me.PasswordLabel.Enabled = False
                Me.txtPassword.Enabled = False
                Me.btnLogin.Visible = False
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Finally
            Me.Cursor = Cursors.Default
#If Not Debug Then
            Dim publishingVersion As String = My.Application.Info.Version.ToString()
            Try
                publishingVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
            Catch ex As Exception
            End Try
            Dim val As SystemParameter = Session.Get(Of SystemParameter)("APP_VERSION")
            If val.Value <> publishingVersion.Split(".")(3) Then
                Helper.RunShell("net", "use x: /delete")
                Helper.RunShell("net", "use x: \\192.168.1.246\Application PM87432 /USER:premedic /PERSISTENT:YES")
                Core.UI.MsgBox.Show("Aizveriet aplikāciju un atveriet par jaunu. Nepieciešamā versija " + val.Value & " pašreizējā versija " & publishingVersion.Split(".")(3))
            End If
#End If
            'saglabā username un valodu
            File.WriteAllText(destFilePath, txtLogin.Text & "#$" & cmbLanguage.SelectedValue)
            Context.Current.AuthenticatedUser.InterfaceLanguage = cmbLanguage.SelectedValue
            Context.Current.Localization = Entities(Of Entities.Localization).GetAll(Session)

            'pārnesam visus lokalizācijas ierakstus uz core
            For Each o As Entities.Localization In Context.Current.Localization
                If (o.Forma = "xml") Then
                End If
                Core.Localization.Instance.LocalizationObjects.Add(New LocalizationObject(o.Forma, o.Labels, o.Aktuala))
            Next
        End Try
    End Sub

    Private Sub UpdateDbIfNeeded()
        'If CType(cmbConnectionTarget.SelectedItem, Core.Dal.ConnectionTarget) = Core.Dal.ConnectionTarget.Local Then
        '    Me.Update()
        '    Dim updater As New Core.DbUpdates.DbUpdater()
        '    If updater.UpdateNeeded() Then
        '        Dim updateForm As New dlgDbUpdates()
        '        updateForm.updater = updater
        '        updateForm.ShowDialog()
        '    End If
        'End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Me.DialogResult <> Windows.Forms.DialogResult.OK Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    'Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Context.Current.ImpersonatedUser = cmbImpersonatedUser.SelectedItem
    '    Me.DialogResult = Windows.Forms.DialogResult.OK
    'End Sub

    Private Sub dlgLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim lang As List(Of Languages) = New List(Of Languages)()
        Dim lvl As Languages = New Languages()
        lvl.Name = "Latviešu"
        lvl.Code = "LVL"
        Dim rus As Languages = New Languages()
        rus.Name = "Русский"
        rus.Code = "RUS"
        Dim eng As Languages = New Languages()
        eng.Name = "English"
        eng.Code = "ENG"
        lang.Add(lvl)
        lang.Add(rus)
        lang.Add(eng)
        LanguagesBindingSource.DataSource = lang
        If Context.Current.DevelopmentDebugMode Then
            txtLogin.Text = "admin"
            txtPassword.Text = txtLogin.Text
            btnLogin.PerformClick()
        Else
            Dim localAppData As String = _
  Environment.GetFolderPath( _
  Environment.SpecialFolder.LocalApplicationData)
            Dim userFilePath As String = _
              Path.Combine(localAppData, "Medical")

            If (Not Directory.Exists(userFilePath)) Then
                Directory.CreateDirectory(userFilePath)
            End If

            destFilePath = _
              Path.Combine(userFilePath, "config.txt")
            If (File.Exists(destFilePath)) Then
                Dim val = File.ReadAllText(destFilePath)

                txtLogin.Text = Split(val, "#$")(0)
                txtPassword.Text = ""
                Dim tmp As String = Split(val, "#$")(1)
                If (Not String.IsNullOrEmpty(tmp)) Then
                    If tmp = lvl.Code Then
                        cmbLanguage.SelectedItem = lvl
                    ElseIf tmp = rus.Code Then
                        cmbLanguage.SelectedItem = rus
                    Else
                        cmbLanguage.SelectedItem = eng
                    End If
                Else
                    cmbLanguage.SelectedItem = lvl
                End If
            Else
                txtLogin.Text = My.User.CurrentPrincipal.Identity.Name
                txtPassword.Text = ""
            End If
        End If
    End Sub

    Private Sub dlgLogin_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        txtPassword.Focus()
    End Sub

    Private Sub cmbLanguage_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbLanguage.SelectedValueChanged
        If (cmbLanguage.SelectedValue = "RUS") Then
            ChangeLanguage("ru-RU")
        ElseIf (cmbLanguage.SelectedValue = "ENG") Then
            ChangeLanguage("en")
        Else
            ChangeLanguage("lv-LV")
        End If
    End Sub


    Private Sub ChangeLanguage(ByVal lang As String)
        For Each c As Control In Me.Controls
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(dlgLogin))
            resources.ApplyResources(c, c.Name, New CultureInfo(lang))
        Next c
    End Sub
End Class
' Lūdzu, Юникод