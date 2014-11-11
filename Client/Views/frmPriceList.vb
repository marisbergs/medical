Imports Entities
Imports Core.Bll
Imports Core.Dal
Imports Core
Imports System.Text

Public Class frmPriceList

    Private _criteria As New List(Of Core.Dal.Expressions.CriterionBase)

    Private Sub CtlUserServicesFinder1_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs) Handles CtlUserServicesFinder1.Find
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        Dim userServices As New Entities(Of UserService)
        Session.CreateAndBuildCriteria(Of UserService)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(userServices)
        Dim f As UserServicesFinder = CType(CtlUserServicesFinder1.bndFind.Current, UserServicesFinder)

        Dim useSpeciality As Boolean = f.UseSpeciality
        Dim specialityList As New List(Of Speciality)
        If useSpeciality Then
            For Each speciality1 As Speciality In f.Speciality
                If Not specialityList.Contains(speciality1) Then
                    specialityList.Add(speciality1)
                End If
            Next
        End If

        Entities(Of User).GetAll(Session, New Expressions.IsNull("DeleteTime"))
        Entities(Of UserService).GetAll(Session, New Expressions.IsNull("DeleteTime"))
        Entities(Of Services).GetAll(Session, New Expressions.IsNull("DeleteTime"))
        Entities(Of Speciality).GetAll(Session, New Expressions.IsNull("DeleteTime"))
        Entities(Of UsersSpecialities).GetAll(Session, New Expressions.IsNull("DeleteTime"))
        Dim lst As New SortedDictionary(Of Speciality, List(Of UserService))
        For Each service As UserService In userServices
            If service.Specialities.Count = 1 Then
                If useSpeciality Then
                    If specialityList.Contains(service.Specialities(0)) Then
                        If Not lst.ContainsKey(service.Specialities(0)) Then
                            lst.Add(service.Specialities(0), New List(Of UserService)())
                        End If
                        lst(service.Specialities(0)).Add(service)
                    End If
                Else
                    If Not lst.ContainsKey(service.Specialities(0)) Then
                        lst.Add(service.Specialities(0), New List(Of UserService)())
                    End If
                    lst(service.Specialities(0)).Add(service)
                End If
            ElseIf service.Specialities.Count > 1 Then
                For Each spec As Speciality In service.Specialities
                    If useSpeciality Then
                        If specialityList.Contains(spec) Then
                            If Not lst.ContainsKey(spec) Then
                                lst.Add(spec, New List(Of UserService)())
                            End If
                            lst(spec).Add(service)
                        End If
                    Else
                        If Not lst.ContainsKey(spec) Then
                            lst.Add(spec, New List(Of UserService)())
                        End If
                        lst(spec).Add(service)
                    End If
                Next
            End If
        Next
        For Each pair As KeyValuePair(Of Speciality, List(Of UserService)) In lst
            System.Diagnostics.Debug.Print(pair.Key.Value)
        Next

        Dim dt As New DataTable
        dt.Columns.Add("colSpeciality", System.Type.GetType("System.String"))
        dt.Columns.Add("colUser", System.Type.GetType("System.String"))
        dt.Columns.Add("colService", System.Type.GetType("System.String"))
        dt.Columns.Add("colPrice", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("colTime", System.Type.GetType("System.Int32"))

        For Each pair As KeyValuePair(Of Speciality, List(Of UserService)) In lst
            Dim spec As String = pair.Key.Value
            Dim serv As New SortedDictionary(Of String, Dictionary(Of UserService, SortedList(Of String, User)))
            Dim temp As New Dictionary(Of String, UserService)
            For Each service As UserService In pair.Value
                Dim key As String = service.ServiceCode & "-" & service.Price & "-" & service.Time
                If Not serv.ContainsKey(key) Then
                    serv.Add(key, New Dictionary(Of UserService, SortedList(Of String, User))())
                    temp.Add(key, service)
                    serv(key).Add(service, New SortedList(Of String, User)())
                    serv(key)(service).Add(service.User.FullName, service.User)
                Else
                    If Not serv(key)(temp(key)).ContainsKey(service.User.FullName) Then
                        serv(key)(temp(key)).Add(service.User.FullName, service.User)
                    End If
                End If
            Next
            Dim xx As New Dictionary(Of String, List(Of UserService))
            For Each v As KeyValuePair(Of String, Dictionary(Of UserService, SortedList(Of String, User))) In serv
                Dim usr As String = ""
                For Each v1 As KeyValuePair(Of UserService, SortedList(Of String, User)) In v.Value
                    For Each v2 As KeyValuePair(Of String, User) In v1.Value
                        If usr.Length > 0 Then
                            usr &= "$"
                        End If
                        usr &= v2.Key
                    Next
                    If Not xx.ContainsKey(usr) Then
                        xx.Add(usr, New List(Of UserService)())
                    End If
                    xx(usr).Add(v1.Key)
                Next
            Next

            For Each v3 As KeyValuePair(Of String, List(Of UserService)) In xx
                For Each s As UserService In v3.Value
                    Dim dr As DataRow = dt.NewRow()
                    dr("colSpeciality") = spec
                    Dim userList As String() = v3.Key.Split("$")
                    Dim sb As New StringBuilder()
                    For Each s1 As String In userList
                        sb.AppendLine(s1)
                    Next
                    dr("colUser") = sb.ToString().Trim()
                    dr("colService") = s.ServiceCode & " " & s.Service.Value
                    dr("colPrice") = s.Price
                    dr("colTime") = s.Time
                    dt.Rows.Add(dr)
                Next
            Next
        Next
        grdData.DataSource = dt
        grdData.RefreshDataSource()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        grdData.Export()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
