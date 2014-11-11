Imports Core.Bll
Imports Entities

Public Class frmAccountingByDate

    Private _criteria As New List(Of Core.Dal.Expressions.CriterionBase)
    Private Sub CtlVisitsFinder1_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs) Handles CtlVisitsFinder1.Find
        'savācam kritērijus nofiltra
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        Dim visits As New Entities(Of Visit)
        'atlasam visas vizītes pēc dotajiem kritērijiem
        Session.CreateAndBuildCriteria(Of Visit)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(visits) '.AddOrder(NHibernate.Expression.Order.Asc("Doctor")).AddOrder(NHibernate.Expression.Order.Asc("StartTime")).List(visits)
        'sataisam konstrukciju kurā liekam ārstus, pakalpojumus un sarakstu ar tiem pakalpojumiem ko šis ārsts ir sniedzis
        Dim lst As New SortedDictionary(Of User, SortedDictionary(Of UserService, List(Of VisitService)))
        If Not visits Is Nothing Then
            For Each o As Visit In visits
                'ja dzēsta neskatamies
                If Not o.IsActive Then
                    Continue For
                End If
                'ejam cauri vizītes pakalpojumiem un liekam listā
                For Each s As VisitService In o.VisitServices.ActiveItemsWithoutEmpty
                    'ja pakalpojums nav sniegts tad neņemam vērā
                    If Not s.ServiceGiven Then
                        Continue For
                    End If
                    Dim srv As UserService = Nothing
                    Dim relatedServ As UserService = Nothing
                    Dim doctorService As Boolean = False 'pazīme vai pakalpojums ir piesaistīts ārstam
                    'skatamies vai pie ārsta ir šāds pakalpojums lai zinātu vai izmantot algas aprēķinā
                    For Each x As UserService In o.Doctor.UserServices
                        If Not s.Service Is Nothing AndAlso x.Service.Id = s.Service.Id Then
                            If Not x.DeleteTime.HasValue Then
                                srv = x
                                doctorService = True
                                Exit For
                            ElseIf x.DeleteTime.Value >= s.Visit.StartTime Then
                                srv = x
                                doctorService = True
                                Exit For
                            End If
                        End If
                    Next
                    'skatamies vai vizītei ir saistītais ārsts
                    If Not o.RelatedDoctor Is Nothing Then
                        'skatamies vai pie ārsta ir šāds pakalpojums lai zinātu vai izmantot algas aprēķinā
                        For Each x As UserService In o.RelatedDoctor.UserServices
                            If Not s.Service Is Nothing AndAlso x.Service.Id = s.Service.Id Then
                                If Not x.DeleteTime.HasValue Then
                                    relatedServ = x
                                    Exit For
                                ElseIf x.DeleteTime.Value >= s.Visit.StartTime Then
                                    relatedServ = x
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                    If srv Is Nothing Then
                        'ja paklapojums nav piesaistīts ārstam tad liekam atsevišķā sadaļā lai sakristu iemaksātās summas
                        Dim emptyUserService As New UserService(Session)
                        emptyUserService.Service = s.Service
                        emptyUserService.Id = s.Service.Id
                        If (Not lst.ContainsKey(o.Doctor)) Then
                            lst.Add(o.Doctor, New SortedDictionary(Of UserService, List(Of VisitService)))
                        End If
                        If Not lst(o.Doctor).ContainsKey(emptyUserService) Then
                            lst(o.Doctor).Add(emptyUserService, New List(Of VisitService))
                        End If
                        lst(o.Doctor)(emptyUserService).Add(s)
                    End If
                    If Not (srv Is Nothing) Then
                        If (Not lst.ContainsKey(o.Doctor)) Then
                            lst.Add(o.Doctor, New SortedDictionary(Of UserService, List(Of VisitService)))
                        End If
                        If Not lst(o.Doctor).ContainsKey(srv) Then
                            lst(o.Doctor).Add(srv, New List(Of VisitService))
                        End If
                        lst(o.Doctor)(srv).Add(s)
                    End If
                    If Not relatedServ Is Nothing Then
                        If (Not lst.ContainsKey(o.RelatedDoctor)) Then
                            lst.Add(o.RelatedDoctor, New SortedDictionary(Of UserService, List(Of VisitService)))
                        End If
                        If Not lst(o.RelatedDoctor).ContainsKey(relatedServ) Then
                            lst(o.RelatedDoctor).Add(relatedServ, New List(Of VisitService))
                        End If
                        lst(o.RelatedDoctor)(relatedServ).Add(s)
                    End If
                Next
            Next
        End If
        'sataisam datu tabulu kurā glabāsim rezultātu
        Dim dt As New DataTable()
        dt.Columns.Add("User", System.Type.GetType("System.String"))
        dt.Columns.Add("Service", System.Type.GetType("System.String"))
        dt.Columns.Add("ServicePrice", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("Cash", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("Insurance", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("PresentCard", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("BonusPoints", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("Payd", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("SalaryType", System.Type.GetType("System.String"))
        dt.Columns.Add("Salary", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("SalaryValueType", System.Type.GetType("System.String"))
        dt.Columns.Add("SalaryCalculation", System.Type.GetType("System.Decimal"))

        Dim dist As New Dictionary(Of String, Dictionary(Of String, Decimal))

        For Each pair As KeyValuePair(Of User, SortedDictionary(Of UserService, List(Of VisitService))) In lst
            dist.Clear()
            Dim servicePriceTotal As Decimal = 0
            Dim paydTotal As Decimal = 0
            Dim _seleryTotal As Decimal = 0
            Dim insuranceTotal As Decimal = 0
            Dim presentCardTotal As Decimal = 0
            Dim bonuspointsTotal As Decimal = 0
            Dim cashTotal As Decimal = 0
            For Each valuePair As KeyValuePair(Of UserService, List(Of VisitService)) In pair.Value
                Dim servicePrice As Decimal = 0
                Dim payd As Decimal = 0
                Dim insurance As Decimal = 0
                Dim presentCard As Decimal = 0
                Dim bonuspoints As Decimal = 0
                Dim cash As Decimal = 0
                Dim nodCount As String = ""
                Dim lt As New Dictionary(Of Guid, List(Of VisitService))
                If Not valuePair.Value.Item(0).Service.ReferenceSecond Is Nothing AndAlso valuePair.Value.Item(0).Service.ReferenceSecond.Mark Then
                    For Each service As VisitService In valuePair.Value
                        If Not lt.ContainsKey(service.Visit.ParentId) Then
                            lt.Add(service.Visit.ParentId, New List(Of VisitService))
                        End If
                        lt(service.Visit.ParentId).Add(service)
                        servicePrice += service.DefaultPrice
                        payd += service.Price
                        cash += service.Price
                        If service.Insurance.HasValue Then
                            payd += service.Insurance.Value
                            insurance += service.Insurance.Value
                        End If
                        If service.PresentCardSum.HasValue Then
                            payd += service.PresentCardSum.Value
                            presentCard += service.PresentCardSum.Value
                        End If
                        If service.BonusPoints.HasValue Then
                            payd += CalculateBonusPoints(service.Visit.StartTime, service.BonusPoints.Value)
                            bonuspoints += service.BonusPoints.Value
                        End If
                        If valuePair.Key.RemoveMaterials AndAlso Not service.Service.MaterialCost Is Nothing Then
                            payd = payd - service.Service.MaterialCost
                        End If
                        If service.Price > 0 Then
                            Diagnostics.Debug.WriteLine("klients: " & service.Visit.Patient.FullName & ", Vizītes datums: " & service.Visit.StartTime.ToShortDateString & ", Apmaksai:," & service.Price & ", Apmaksas datums: " & service.PaydDate)
                        End If
                    Next
                    If valuePair.Key.RemoveVAT AndAlso Not valuePair.Value.Item(0).Service.Reference Is Nothing Then
                        payd = Decimal.Round(Convert.ToDecimal(payd / (valuePair.Value.Item(0).Service.Reference.DecimalValue / 100 + 1)), 2)
                    End If
                    nodCount = " nod. sk.: " & lt.Count
                ElseIf valuePair.Key.SeleryType = SeleryType.Time Then
                    For Each service As VisitService In valuePair.Value
                        If Not lt.ContainsKey(service.Visit.Id) Then
                            lt.Add(service.Visit.Id, New List(Of VisitService))
                        End If
                        lt(service.Visit.Id).Add(service)
                        servicePrice += service.DefaultPrice
                        payd += service.Price
                        cash += service.Price
                        If service.Insurance.HasValue Then
                            payd += service.Insurance.Value
                            insurance += service.Insurance.Value
                        End If
                        If service.PresentCardSum.HasValue Then
                            payd += service.PresentCardSum.Value
                            presentCard += service.PresentCardSum.Value
                        End If
                        If service.BonusPoints.HasValue Then
                            payd += CalculateBonusPoints(service.Visit.StartTime, service.BonusPoints.Value)
                            bonuspoints += service.BonusPoints.Value
                        End If
                        If valuePair.Key.RemoveMaterials AndAlso Not service.Service.MaterialCost Is Nothing Then
                            payd = payd - service.Service.MaterialCost
                        End If
                    Next
                    If valuePair.Key.RemoveVAT AndAlso Not valuePair.Value.Item(0).Service.Reference Is Nothing Then
                        payd = Decimal.Round(Convert.ToDecimal(payd / (valuePair.Value.Item(0).Service.Reference.DecimalValue / 100 + 1)), 2)
                    End If
                    nodCount = " nod. sk.: " & lt.Count
                Else
                    For Each service As VisitService In valuePair.Value
                        servicePrice += service.DefaultPrice
                        payd += service.Price
                        cash += service.Price
                        If service.Insurance.HasValue Then
                            payd += service.Insurance.Value
                            insurance += service.Insurance.Value
                        End If
                        If service.PresentCardSum.HasValue Then
                            payd += service.PresentCardSum.Value
                            presentCard += service.PresentCardSum.Value
                        End If
                        If service.BonusPoints.HasValue Then
                            payd += service.BonusPoints.Value
                            bonuspoints += service.BonusPoints.Value
                        End If
                        If valuePair.Key.RemoveMaterials AndAlso Not service.Service.MaterialCost Is Nothing Then
                            payd = payd - service.Service.MaterialCost
                        End If
                    Next
                    If valuePair.Key.RemoveVAT AndAlso Not valuePair.Value.Item(0).Service.Reference Is Nothing Then
                        payd = Decimal.Round(Convert.ToDecimal(payd / (valuePair.Value.Item(0).Service.Reference.DecimalValue / 100 + 1)), 2)
                    End If
                    nodCount = " vizīšu. sk.: " & valuePair.Value.Count
                End If
                servicePriceTotal += servicePrice
                paydTotal += payd
                insuranceTotal += insurance
                presentCardTotal += presentCard
                bonuspointsTotal += bonuspoints
                cashTotal += cash
                Dim _selery As Decimal = 0
                If valuePair.Key.SeleryValue.HasValue AndAlso valuePair.Key.Selery = Selery.Percentage Then
                    _selery = (payd * valuePair.Key.SeleryValue / 100)
                    _seleryTotal += _selery
                ElseIf valuePair.Key.SeleryValue.HasValue AndAlso valuePair.Key.Selery = Selery.Ls Then
                    _selery = (lt.Count * valuePair.Key.SeleryValue.Value)
                    _seleryTotal += _selery
                End If
                Dim serviceName As String = valuePair.Key.Service.Value
                If valuePair.Key.ManualPrice.HasValue Then
                    serviceName &= "(" & valuePair.Key.ManualPrice.Value & " Ls" & nodCount & ")"
                Else
                    serviceName &= "(" & valuePair.Key.Service.DecimalValue & " Ls" & nodCount & ")"
                End If
                If CheckBox1.Checked Then
                    If (valuePair.Key.SeleryType = SeleryType.Percentage AndAlso valuePair.Key.Selery = Selery.Percentage) Then
                        dt.Rows.Add(pair.Key.FullNameStartWithName, serviceName, servicePrice, cash, insurance, presentCard, bonuspoints, payd, valuePair.Key.SeleryType, valuePair.Key.SeleryValue, valuePair.Key.Selery, _selery)
                    ElseIf (valuePair.Key.SeleryType = SeleryType.Time AndAlso valuePair.Key.Selery = Selery.Ls) Then
                        dt.Rows.Add(pair.Key.FullNameStartWithName, serviceName, servicePrice, cash, insurance, presentCard, bonuspoints, payd, valuePair.Key.SeleryType, valuePair.Key.SeleryValue, valuePair.Key.Selery, _selery)
                    Else
                        dt.Rows.Add(pair.Key.FullNameStartWithName, serviceName, servicePrice, cash, insurance, presentCard, bonuspoints, payd, valuePair.Key.SeleryType, valuePair.Key.SeleryValue, valuePair.Key.Selery, 0)
                    End If
                End If
                If Not valuePair.Key.SeleryType Is Nothing AndAlso valuePair.Key.SeleryValue.HasValue AndAlso Not valuePair.Key.Selery Is Nothing Then
                    Dim key As String = valuePair.Key.SeleryType.Name & "|" & valuePair.Key.SeleryValue.ToString() & "|" & valuePair.Key.Selery.Name
                    If (dist.ContainsKey(key)) Then
                        dist(key)("1") += servicePrice
                        dist(key)("4") += insurance
                        dist(key)("5") += presentCard
                        dist(key)("6") += bonuspoints
                        dist(key)("2") += payd
                        dist(key)("3") += _selery
                        dist(key)("7") += cash
                    Else
                        dist.Add(key, New Dictionary(Of String, Decimal)())
                        dist(key).Add("1", servicePrice)
                        dist(key).Add("4", insurance)
                        dist(key).Add("5", presentCard)
                        dist(key).Add("6", bonuspoints)
                        dist(key).Add("2", payd)
                        dist(key).Add("3", _selery)
                        dist(key).Add("7", cash)
                    End If
                End If
            Next

            If Not CheckBox1.Checked Then
                For Each valuePair As KeyValuePair(Of String, Dictionary(Of String, Decimal)) In dist
                    dt.Rows.Add(pair.Key.FullNameStartWithName, "", valuePair.Value("1"), valuePair.Value("7"), valuePair.Value("4"), valuePair.Value("5"), valuePair.Value("6"), valuePair.Value("2"), valuePair.Key.Split("|")(0), valuePair.Key.Split("|")(1), valuePair.Key.Split("|")(2), valuePair.Value("3"))
                Next
            End If
            If pair.Key.Salary.HasValue Then
                _seleryTotal += pair.Key.Salary.Value
                dt.Rows.Add(pair.Key.FullNameStartWithName, "Pamatalga:", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, pair.Key.Salary.Value)
            End If
            dt.Rows.Add(pair.Key.FullNameStartWithName, "Kopā:", servicePriceTotal, cashTotal, insuranceTotal, presentCardTotal, bonuspointsTotal, paydTotal, Nothing, Nothing, Nothing, _seleryTotal)

        Next
        grdData.DataSource = dt
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        grdData.Export()
    End Sub
    Private Function CalculateBonusPoints(ByVal visitDate As DateTime, ByVal price As Decimal) As Decimal
        If visitDate.Date < New Date(2009, 9, 1) Then
            Return price
        Else
            Return Decimal.Round(price / 2, 2)
        End If
    End Function


End Class
