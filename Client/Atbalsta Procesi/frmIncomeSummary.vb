
Imports Core.Bll
Imports Entities
Imports Core.Dal.Expressions
Imports Core.UI

Public Class frmIncomeSummary


    Private Sub btnClose_Click(sender As System.Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub ŠodienaToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ŠodienaToolStripMenuItem.Click
        dtpFrom.EditValue = Now.Date
        dtpTo.EditValue = Now.Date.AddDays(1)
    End Sub

    Private Sub VakardienaToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles VakardienaToolStripMenuItem.Click
        dtpFrom.EditValue = Now.Date.AddDays(-1)
        dtpTo.EditValue = Now.Date
    End Sub

    Private Sub ŠonedēļToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ŠonedēļToolStripMenuItem.Click
        dtpFrom.EditValue = Now.Date.AddDays((Now.Date.DayOfWeek.GetHashCode() * -1) + 1)
        dtpTo.EditValue = CType(dtpFrom.EditValue, DateTime).AddDays(7)
    End Sub

    Private Sub PagājušāNedēļaToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles PagājušāNedēļaToolStripMenuItem.Click
        dtpFrom.EditValue = Now.Date.AddDays((Now.Date.DayOfWeek.GetHashCode() * -1) + 1 - 7)
        dtpTo.EditValue = CType(dtpFrom.EditValue, DateTime).AddDays(7)
    End Sub

    Private Sub PagToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles PagToolStripMenuItem.Click
        dtpFrom.EditValue = New Date(Now.Date.Year, Now.Date.Month, 1)
        dtpTo.EditValue = New Date(Now.Date.Year, Now.Date.Month, 1).AddMonths(1)
    End Sub

    Private Sub AjušoMēnesToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles AjušoMēnesToolStripMenuItem.Click
        dtpFrom.EditValue = New Date(Now.Date.Year, Now.Date.Month, 1).AddMonths(-1)
        dtpTo.EditValue = New Date(Now.Date.Year, Now.Date.Month, 1)
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As EventArgs) Handles btnSearch.Click
        ''atlasam visas vizītes pakalpojumus kuriem apmaksas datums ir par norādīto periodu
        Dim skaidraNauda As Decimal
        Dim apdrosinasana As Decimal
        Dim bonusaPunkti As Decimal
        skaidraNauda = 0
        apdrosinasana = 0
        bonusaPunkti = 0
        Dim visits As Entities(Of VisitService)
        visits = New Entities(Of VisitService)
        Dim dt As New DataTable()
        Dim _criteria As New List(Of Core.Dal.Expressions.CriterionBase)
        _criteria.Add(New Between("Visit.StartTime", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))))
        _criteria.Add(New IsNull("DeleteTime"))
        _criteria.Add(New IsNull("Visit.DeleteTime"))
        _criteria.Add(New Eq("ServiceGiven", True))
        Dim eks As New SortedDictionary(Of DateTime, SortedDictionary(Of String, Nullable(Of Decimal)))

        Session.CreateAndBuildCriteria(Of VisitService)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).SetFetchMode("Visit", NHibernate.FetchMode.Select).SetFetchMode("Service", NHibernate.FetchMode.Select).SetFetchMode("PaymentType", NHibernate.FetchMode.Select).List(visits)
        If (chkCollectDataInDays.Checked) Then
            dt.Columns.Add("Datums", Type.GetType("System.String"))
            dt.Columns.Add("Kodi", Type.GetType("System.String"))
            dt.Columns.Add("Summas", Type.GetType("System.Decimal"))
            dt.Columns.Add("Debits", Type.GetType("System.String"))
        End If

        For Each visitService As VisitService In visits
            If visitService.PaymentType Is Nothing Then
                MsgBox.Show(String.Format("Pakalpojuma apmaksas detaļās nav norādīts apmaksas veids. Klients {0} vizītes laiks {1}", visitService.Visit.Patient.FullName, visitService.Visit.StartTime))
            Else
                If (visitService.PaymentType.Id = PaymentType.Cash AndAlso visitService.PaydDate.HasValue) Then
                    'If visitService.Insurance.HasValue AndAlso visitService.Insurance.Value > 0 Then
                    '    apdrosinasana += visitService.Insurance.Value
                    'End If
                    If visitService.Price > 0 Then
                        skaidraNauda += visitService.Price
                        If (chkCollectDataInDays.Checked) Then
                            If (Not eks.ContainsKey(visitService.Visit.StartTime.Date)) Then
                                eks.Add(visitService.Visit.StartTime.Date, New SortedDictionary(Of String, Nullable(Of Decimal))())
                            End If
                            If (visitService.Service.Reference Is Nothing) Then
                                If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6220")) Then
                                    eks(visitService.Visit.StartTime.Date).Add("6220", 0)
                                End If
                                eks(visitService.Visit.StartTime.Date)("6220") += visitService.Price
                            ElseIf (visitService.Service.Reference.DecimalValue = 21) Then
                                If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6110")) Then
                                    eks(visitService.Visit.StartTime.Date).Add("6110", 0)
                                End If
                                If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("5721")) Then
                                    eks(visitService.Visit.StartTime.Date).Add("5721", 0)
                                End If
                                eks(visitService.Visit.StartTime.Date)("6110") += Decimal.Round(Decimal.Parse(visitService.Price / 1.21), 2)
                                eks(visitService.Visit.StartTime.Date)("5721") += visitService.Price - Decimal.Round(Decimal.Parse(visitService.Price / 1.21), 2)
                            ElseIf (visitService.Service.Reference.DecimalValue = 12) Then
                                If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6111")) Then
                                    eks(visitService.Visit.StartTime.Date).Add("6111", 0)
                                End If
                                If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("5721")) Then
                                    eks(visitService.Visit.StartTime.Date).Add("5721", 0)
                                End If
                                eks(visitService.Visit.StartTime.Date)("6111") += Decimal.Round(Decimal.Parse(visitService.Price / 1.12), 2)
                                eks(visitService.Visit.StartTime.Date)("5721") += visitService.Price - Decimal.Round(Decimal.Parse(visitService.Price / 1.12), 2)
                            End If
                        End If
                    End If
                End If
                'If visitService.BonusPoints.HasValue AndAlso visitService.BonusPoints.Value > 0 Then
                '    BonusaPunkti += visitService.BonusPoints.Value
                'End If
            End If
        Next

        _criteria = New List(Of Core.Dal.Expressions.CriterionBase)
        _criteria.Add(New Between("Visit.StartTime", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))))
        _criteria.Add(New [Or](New Gt("Insurance", 0), New Gt("BonusPoints", 0)))
        _criteria.Add(New IsNull("DeleteTime"))
        _criteria.Add(New IsNull("Visit.DeleteTime"))
        _criteria.Add(New Eq("ServiceGiven", True))
        visits = New Entities(Of VisitService)
        Session.CreateAndBuildCriteria(Of VisitService)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).SetFetchMode("Visit", NHibernate.FetchMode.Select).SetFetchMode("Service", NHibernate.FetchMode.Select).SetFetchMode("PaymentType", NHibernate.FetchMode.Select).List(visits)

        For Each visitService As VisitService In visits
            If visitService.PaymentType Is Nothing Then
                MsgBox.Show(String.Format("Pakalpojuma apmaksas detaļās nav norādīts apmaksas veids. Klients {0} vizītes laiks {1}", visitService.Visit.Patient.FullName, visitService.Visit.StartTime))
            Else
                If visitService.Insurance.HasValue AndAlso visitService.Insurance.Value > 0 Then
                    apdrosinasana += visitService.Insurance.Value
                    If (chkCollectDataInDays.Checked) Then
                        If (Not eks.ContainsKey(visitService.Visit.StartTime.Date)) Then
                            eks.Add(visitService.Visit.StartTime.Date, New SortedDictionary(Of String, Nullable(Of Decimal))())
                        End If
                        If (visitService.Service.Reference Is Nothing) Then
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6220")) Then
                                eks(visitService.Visit.StartTime.Date).Add("6220", 0)
                            End If
                            eks(visitService.Visit.StartTime.Date)("6220") += visitService.Insurance.Value
                        ElseIf (visitService.Service.Reference.DecimalValue = 21) Then
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6110")) Then
                                eks(visitService.Visit.StartTime.Date).Add("6110", 0)
                            End If
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("5721")) Then
                                eks(visitService.Visit.StartTime.Date).Add("5721", 0)
                            End If
                            eks(visitService.Visit.StartTime.Date)("6110") += Decimal.Round(Decimal.Parse(visitService.Insurance.Value / 1.21), 2)
                            eks(visitService.Visit.StartTime.Date)("5721") += visitService.Insurance.Value - Decimal.Round(Decimal.Parse(visitService.Insurance.Value / 1.21), 2)
                        ElseIf (visitService.Service.Reference.DecimalValue = 12) Then
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6111")) Then
                                eks(visitService.Visit.StartTime.Date).Add("6111", 0)
                            End If
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("5721")) Then
                                eks(visitService.Visit.StartTime.Date).Add("5721", 0)
                            End If
                            eks(visitService.Visit.StartTime.Date)("6111") += Decimal.Round(Decimal.Parse(visitService.Insurance.Value / 1.12), 2)
                            eks(visitService.Visit.StartTime.Date)("5721") += visitService.Insurance.Value - Decimal.Round(Decimal.Parse(visitService.Insurance.Value / 1.12), 2)
                        End If
                    End If
                End If
                If visitService.BonusPoints.HasValue AndAlso visitService.BonusPoints.Value > 0 Then
                    bonusaPunkti += visitService.BonusPoints.Value
                    If (chkCollectDataInDays.Checked) Then
                        If (Not eks.ContainsKey(visitService.Visit.StartTime.Date)) Then
                            eks.Add(visitService.Visit.StartTime.Date, New SortedDictionary(Of String, Nullable(Of Decimal))())
                       End If
                        If (visitService.Service.Reference Is Nothing) Then
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6220")) Then
                                eks(visitService.Visit.StartTime.Date).Add("6220", 0)
                            End If
                            eks(visitService.Visit.StartTime.Date)("6220") += visitService.BonusPoints.Value
                        ElseIf (visitService.Service.Reference.DecimalValue = 21) Then
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6110")) Then
                                eks(visitService.Visit.StartTime.Date).Add("6110", 0)
                            End If
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("5721")) Then
                                eks(visitService.Visit.StartTime.Date).Add("5721", 0)
                            End If
                            eks(visitService.Visit.StartTime.Date)("6110") += Decimal.Round(Decimal.Parse(visitService.BonusPoints.Value / 1.21), 2)
                            eks(visitService.Visit.StartTime.Date)("5721") += visitService.BonusPoints.Value - Decimal.Round(Decimal.Parse(visitService.BonusPoints.Value / 1.21), 2)
                        ElseIf (visitService.Service.Reference.DecimalValue = 12) Then
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("6111")) Then
                                eks(visitService.Visit.StartTime.Date).Add("6111", 0)
                            End If
                            If (Not eks(visitService.Visit.StartTime.Date).ContainsKey("5721")) Then
                                eks(visitService.Visit.StartTime.Date).Add("5721", 0)
                            End If
                            eks(visitService.Visit.StartTime.Date)("6111") += Decimal.Round(Decimal.Parse(visitService.BonusPoints.Value / 1.12), 2)
                            eks(visitService.Visit.StartTime.Date)("5721") += visitService.BonusPoints.Value - Decimal.Round(Decimal.Parse(visitService.BonusPoints.Value / 1.12), 2)
                        End If
                    End If
                End If
            End If
        Next
        txtCash.Text = skaidraNauda
        txtBonusPoints.Text = bonusaPunkti
        txtInsurance.Text = apdrosinasana

        ''programmas
        Dim programmas As Decimal
        programmas = 0
        Dim p As Entities(Of PatientProgrammPayment)
        p = Entities(Of PatientProgrammPayment).GetAll(Session, New Between("PaymentDate", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))), New IsNull("DeleteTime"), New IsNull("PatientProgramm.DeleteTime"))
        For Each payment As PatientProgrammPayment In p
            If payment.PaydTotal > 0 Then
                programmas += payment.PaydTotal
                If (chkCollectDataInDays.Checked) Then
                    For Each service As PatientProgrammPaymentService In payment.PaymentServices
                        If (Not eks.ContainsKey(payment.PaymentDate.Value.Date)) Then
                            eks.Add(payment.PaymentDate.Value.Date, New SortedDictionary(Of String, Nullable(Of Decimal))())
                        End If
                        If (service.Service.Reference Is Nothing) Then
                            If (Not eks(payment.PaymentDate.Value.Date).ContainsKey("6220")) Then
                                eks(payment.PaymentDate.Value.Date).Add("6220", 0)
                            End If
                            eks(payment.PaymentDate.Value.Date)("6220") += service.Price
                        ElseIf (service.Service.Reference.DecimalValue = 21) Then
                            If (Not eks(payment.PaymentDate.Value.Date).ContainsKey("6110")) Then
                                eks(payment.PaymentDate.Value.Date).Add("6110", 0)
                            End If
                            If (Not eks(payment.PaymentDate.Value.Date).ContainsKey("5721")) Then
                                eks(payment.PaymentDate.Value.Date).Add("5721", 0)
                            End If
                            eks(payment.PaymentDate.Value.Date)("6110") += Decimal.Round(Decimal.Parse(service.Price / 1.21), 2)
                            eks(payment.PaymentDate.Value.Date)("5721") += service.Price - Decimal.Round(Decimal.Parse(service.Price / 1.21), 2)
                        ElseIf (service.Service.Reference.DecimalValue = 12) Then
                            If (Not eks(payment.PaymentDate.Value.Date).ContainsKey("6111")) Then
                                eks(payment.PaymentDate.Value.Date).Add("6111", 0)
                            End If
                            If (Not eks(payment.PaymentDate.Value.Date).ContainsKey("5721")) Then
                                eks(payment.PaymentDate.Value.Date).Add("5721", 0)
                            End If
                            eks(payment.PaymentDate.Value.Date)("6111") += Decimal.Round(Decimal.Parse(service.Price / 1.12), 2)
                            eks(payment.PaymentDate.Value.Date)("5721") += service.Price - Decimal.Round(Decimal.Parse(service.Price / 1.12), 2)
                        End If
                    Next
                End If
            End If
        Next
        txtProgramm.Text = programmas

        ''dāvanu kartes
        Dim davanuKartes As Decimal
        davanuKartes = 0
        Dim pc As Entities(Of PresentCard)
        pc = Entities(Of PresentCard).GetAll(Session, New Between("PayDate", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))), New IsNull("DeleteTime"))
        For Each payment As PresentCard In pc
            davanuKartes += payment.Price
            If (chkCollectDataInDays.Checked) Then
                If (Not eks.ContainsKey(payment.PayDate.Date)) Then
                    eks.Add(payment.PayDate.Date, New SortedDictionary(Of String, Nullable(Of Decimal))())
                End If
                If (payment.Service.Reference Is Nothing) Then
                    If (Not eks(payment.PayDate.Date).ContainsKey("6220")) Then
                        eks(payment.PayDate.Date).Add("6220", 0)
                    End If
                    eks(payment.PayDate.Date)("6220") += payment.Price
                ElseIf (payment.Service.Reference.DecimalValue = 21) Then
                    If (Not eks(payment.PayDate.Date).ContainsKey("6110")) Then
                        eks(payment.PayDate.Date).Add("6110", 0)
                    End If
                    If (Not eks(payment.PayDate.Date).ContainsKey("5721")) Then
                        eks(payment.PayDate.Date).Add("5721", 0)
                    End If
                    eks(payment.PayDate.Date)("6110") += Decimal.Round(Decimal.Parse(payment.Price / 1.21), 2)
                    eks(payment.PayDate.Date)("5721") += payment.Price - Decimal.Round(Decimal.Parse(payment.Price / 1.21), 2)
                ElseIf (payment.Service.Reference.DecimalValue = 12) Then
                    If (Not eks(payment.PayDate.Date).ContainsKey("6111")) Then
                        eks(payment.PayDate.Date).Add("6111", 0)
                    End If
                    If (Not eks(payment.PayDate.Date).ContainsKey("5721")) Then
                        eks(payment.PayDate.Date).Add("5721", 0)
                    End If
                    eks(payment.PayDate.Date)("6111") += Decimal.Round(Decimal.Parse(payment.Price / 1.12), 2)
                    eks(payment.PayDate.Date)("5721") += payment.Price - Decimal.Round(Decimal.Parse(payment.Price / 1.12), 2)
                End If
            End If
        Next
        txtPresentCard.Text = davanuKartes

        ''abonementi
        Dim abonementi As Decimal
        abonementi = 0
        Dim abo As Entities(Of Subscription)
        abo = Entities(Of Subscription).GetAll(Session, New Between("PayTime", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))), New IsNull("DeleteTime"))
        For Each payment As Subscription In abo
            abonementi += payment.Price
            If (chkCollectDataInDays.Checked) Then
                If (Not eks.ContainsKey(payment.PayTime.Value.Date)) Then
                    eks.Add(payment.PayTime.Value.Date, New SortedDictionary(Of String, Nullable(Of Decimal))())
                End If
                If (payment.Service.Reference Is Nothing) Then
                    If (Not eks(payment.PayTime.Value.Date).ContainsKey("6220")) Then
                        eks(payment.PayTime.Value.Date).Add("6220", 0)
                    End If
                    eks(payment.PayTime.Value.Date)("6220") += payment.Price
                ElseIf (payment.Service.Reference.DecimalValue = 21) Then
                    If (Not eks(payment.PayTime.Value.Date).ContainsKey("6110")) Then
                        eks(payment.PayTime.Value.Date).Add("6110", 0)
                    End If
                    If (Not eks(payment.PayTime.Value.Date).ContainsKey("5721")) Then
                        eks(payment.PayTime.Value.Date).Add("5721", 0)
                    End If
                    eks(payment.PayTime.Value.Date)("6110") += Decimal.Round(Decimal.Parse(payment.Price / 1.21), 2)
                    eks(payment.PayTime.Value.Date)("5721") += payment.Price - Decimal.Round(Decimal.Parse(payment.Price / 1.21), 2)
                ElseIf (payment.Service.Reference.DecimalValue = 12) Then
                    If (Not eks(payment.PayTime.Value.Date).ContainsKey("6111")) Then
                        eks(payment.PayTime.Value.Date).Add("6111", 0)
                    End If
                    If (Not eks(payment.PayTime.Value.Date).ContainsKey("5721")) Then
                        eks(payment.PayTime.Value.Date).Add("5721", 0)
                    End If
                    eks(payment.PayTime.Value.Date)("6111") += Decimal.Round(Decimal.Parse(payment.Price / 1.12), 2)
                    eks(payment.PayTime.Value.Date)("5721") += payment.Price - Decimal.Round(Decimal.Parse(payment.Price / 1.12), 2)
                End If
            End If
        Next
        txtSubscription.Text = abonementi

        ''PAK
        Dim pak As Decimal
        pak = 0
        Dim ab As Entities(Of PatientProfileDescription)
        ab = Entities(Of PatientProfileDescription).GetAll(Session, New Between("PayDate", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))), New IsNull("DeleteTime"))
        For Each payment As PatientProfileDescription In ab
            If payment.Price.HasValue Then
                pak += payment.Price
                If (chkCollectDataInDays.Checked) Then
                    If (Not eks.ContainsKey(payment.PayDate.Value.Date)) Then
                        eks.Add(payment.PayDate.Value.Date, New SortedDictionary(Of String, Nullable(Of Decimal))())
                    End If
                    If (payment.Profile.Reference Is Nothing) Then
                        If (Not eks(payment.PayDate.Value.Date).ContainsKey("6220")) Then
                            eks(payment.PayDate.Value.Date).Add("6220", 0)
                        End If
                        eks(payment.PayDate.Value.Date)("6220") += payment.Price
                    ElseIf (payment.Profile.Reference.DecimalValue = 21) Then
                        If (Not eks(payment.PayDate.Value.Date).ContainsKey("6110")) Then
                            eks(payment.PayDate.Value.Date).Add("6110", 0)
                        End If
                        If (Not eks(payment.PayDate.Value.Date).ContainsKey("5721")) Then
                            eks(payment.PayDate.Value.Date).Add("5721", 0)
                        End If
                        eks(payment.PayDate.Value.Date)("6110") += Decimal.Round(Decimal.Parse(payment.Price / 1.21), 2)
                        eks(payment.PayDate.Value.Date)("5721") += payment.Price - Decimal.Round(Decimal.Parse(payment.Price / 1.21), 2)
                    ElseIf (payment.Profile.Reference.DecimalValue = 12) Then
                        If (Not eks(payment.PayDate.Value.Date).ContainsKey("6111")) Then
                            eks(payment.PayDate.Value.Date).Add("6111", 0)
                        End If
                        If (Not eks(payment.PayDate.Value.Date).ContainsKey("5721")) Then
                            eks(payment.PayDate.Value.Date).Add("5721", 0)
                        End If
                        eks(payment.PayDate.Value.Date)("6111") += Decimal.Round(Decimal.Parse(payment.Price / 1.12), 2)
                        eks(payment.PayDate.Value.Date)("5721") += payment.Price - Decimal.Round(Decimal.Parse(payment.Price / 1.12), 2)
                    End If
                End If
            End If
        Next
        txtPAK.Text = pak

        ''Pārskaitījums
        Dim transfer As Decimal
        transfer = 0

        _criteria = New List(Of Core.Dal.Expressions.CriterionBase)
        _criteria.Add(New Between("Visit.StartTime", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))))
        _criteria.Add(New Eq("PaymentType.Id", PaymentType.Transfer))
        _criteria.Add(New IsNull("DeleteTime"))
        _criteria.Add(New IsNull("Visit.DeleteTime"))
        _criteria.Add(New Eq("ServiceGiven", True))
        visits = New Entities(Of VisitService)
        Session.CreateAndBuildCriteria(Of VisitService)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).SetFetchMode("Visit", NHibernate.FetchMode.Select).SetFetchMode("Service", NHibernate.FetchMode.Select).SetFetchMode("PaymentType", NHibernate.FetchMode.Select).List(visits)

        For Each payment As VisitService In visits
            If payment.Price > 0 Then
                transfer += payment.Price
                If (chkCollectDataInDays.Checked) Then
                    If (Not eks.ContainsKey(payment.Visit.StartTime.Date)) Then
                        eks.Add(payment.Visit.StartTime.Date, New SortedDictionary(Of String, Nullable(Of Decimal))())
                    End If
                    If (payment.Service.Reference Is Nothing) Then
                        If (Not eks(payment.Visit.StartTime.Date).ContainsKey("6220")) Then
                            eks(payment.Visit.StartTime.Date).Add("6220", 0)
                        End If
                        eks(payment.Visit.StartTime.Date)("6220") += payment.Price
                    ElseIf (payment.Service.Reference.DecimalValue = 21) Then
                        If (Not eks(payment.Visit.StartTime.Date).ContainsKey("6110")) Then
                            eks(payment.Visit.StartTime.Date).Add("6110", 0)
                        End If
                        If (Not eks(payment.Visit.StartTime.Date).ContainsKey("5721")) Then
                            eks(payment.Visit.StartTime.Date).Add("5721", 0)
                        End If
                        eks(payment.Visit.StartTime.Date)("6110") += Decimal.Round(Decimal.Parse(payment.Price / 1.21), 2)
                        eks(payment.Visit.StartTime.Date)("5721") += payment.Price - Decimal.Round(Decimal.Parse(payment.Price / 1.21), 2)
                    ElseIf (payment.Service.Reference.DecimalValue = 12) Then
                        If (Not eks(payment.Visit.StartTime.Date).ContainsKey("6111")) Then
                            eks(payment.Visit.StartTime.Date).Add("6111", 0)
                        End If
                        If (Not eks(payment.Visit.StartTime.Date).ContainsKey("5721")) Then
                            eks(payment.Visit.StartTime.Date).Add("5721", 0)
                        End If
                        eks(payment.Visit.StartTime.Date)("6111") += Decimal.Round(Decimal.Parse(payment.Price / 1.12), 2)
                        eks(payment.Visit.StartTime.Date)("5721") += payment.Price - Decimal.Round(Decimal.Parse(payment.Price / 1.12), 2)
                    End If
                End If
            End If
        Next
        txtTransfer.Text = transfer
        Dim total As Decimal = 0
        If chkCollectDataInDays.Checked Then
            Dim rowArray(3) As Object
            rowArray(0) = DBNull.Value
            rowArray(1) = "Sāk. saldo"
            rowArray(2) = DBNull.Value
            rowArray(3) = DBNull.Value
            dt.Rows.Add(rowArray)
            For Each ek As KeyValuePair(Of Date, SortedDictionary(Of String, Decimal?)) In eks
                rowArray(0) = ek.Key.ToShortDateString()
                rowArray(1) = "Sāk. saldo"
                rowArray(2) = DBNull.Value
                rowArray(3) = DBNull.Value
                dt.Rows.Add(rowArray)

                rowArray(0) = DBNull.Value
                rowArray(1) = "2312"
                rowArray(2) = DBNull.Value
                rowArray(3) = DBNull.Value
                dt.Rows.Add(rowArray)

                rowArray(0) = DBNull.Value
                rowArray(1) = "2610"
                rowArray(2) = DBNull.Value
                rowArray(3) = DBNull.Value
                dt.Rows.Add(rowArray)
                Dim summa As Decimal = 0
                For Each o As KeyValuePair(Of String, Nullable(Of Decimal)) In ek.Value
                    rowArray(0) = DBNull.Value
                    rowArray(1) = o.Key
                    rowArray(2) = o.Value
                    rowArray(3) = DBNull.Value
                    dt.Rows.Add(rowArray)
                    summa += o.Value
                Next
                total += summa
                rowArray(0) = DBNull.Value
                rowArray(1) = "Apgrozījums"
                rowArray(2) = summa
                rowArray(3) = DBNull.Value
                dt.Rows.Add(rowArray)

                rowArray(0) = DBNull.Value
                rowArray(1) = "Beigu saldo"
                rowArray(2) = DBNull.Value
                rowArray(3) = DBNull.Value
                dt.Rows.Add(rowArray)
            Next

            rowArray(0) = "KOPĀ"
            rowArray(1) = "Apgrozījums"
            rowArray(2) = total
            rowArray(3) = DBNull.Value
            dt.Rows.Add(rowArray)
            grdPVN.DataSource = dt
            grdPVN.Export()
            dt.Rows.Clear()
            Dim dc As New SortedDictionary(Of String, Decimal)
            For Each ek As KeyValuePair(Of Date, SortedDictionary(Of String, Decimal?)) In eks
                For Each o As KeyValuePair(Of String, Nullable(Of Decimal)) In ek.Value
                    If Not dc.ContainsKey(o.Key) Then
                        dc.Add(o.Key, o.Value)
                    Else
                        dc(o.Key) += o.Value
                    End If
                Next
            Next
            For Each pair As KeyValuePair(Of String,Decimal) In dc
                rowArray(0) = DBNull.Value
                rowArray(1) = pair.Key
                rowArray(2) = pair.Value
                rowArray(3) = DBNull.Value
                dt.Rows.Add(rowArray)
            Next
            grdPVN.DataSource = dt
            grdPVN.Export()
            
        End If
        txtSummary.Text = skaidraNauda + apdrosinasana + bonusaPunkti + programmas + davanuKartes + abonementi + pak + transfer
    End Sub
End Class
