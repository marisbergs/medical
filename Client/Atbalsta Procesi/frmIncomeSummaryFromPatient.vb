
Imports System.Data.Common
Imports Core.Bll
Imports Entities
Imports Core.Dal.Expressions
Imports Core.UI

Public Class frmIncomeSummaryFromPatient


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

        Dim _criteria As New List(Of Core.Dal.Expressions.CriterionBase)
        _criteria.Add(New Between("PaydDate", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))))
        _criteria.Add(New IsNull("DeleteTime"))
        _criteria.Add(New IsNull("Visit.DeleteTime"))
        _criteria.Add(New Eq("ServiceGiven", True))
        Session.CreateAndBuildCriteria(Of VisitService)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).SetFetchMode("Visit", NHibernate.FetchMode.Select).SetFetchMode("Service", NHibernate.FetchMode.Select).SetFetchMode("PaymentType", NHibernate.FetchMode.Select).List(visits)

        For Each visitService As VisitService In visits
            If visitService.PaymentType Is Nothing Then
                MsgBox.Show(String.Format("Pakalpojuma apmaksas detaļās nav norādīts apmaksas veids. Klients {0} vizītes laiks {1}", visitService.Visit.Patient.FullName, visitService.Visit.StartTime))
            Else
                If (visitService.PaymentType.Id = PaymentType.Cash) Then
                    'If visitService.Insurance.HasValue AndAlso visitService.Insurance.Value > 0 Then
                    '    apdrosinasana += visitService.Insurance.Value
                    'End If
                    If visitService.Price > 0 Then
                        skaidraNauda += visitService.Price
                    End If
                    'If visitService.BonusPoints.HasValue AndAlso visitService.BonusPoints.Value > 0 Then
                    '    BonusaPunkti += visitService.BonusPoints.Value
                    'End If
                End If

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
                End If
                If visitService.BonusPoints.HasValue AndAlso visitService.BonusPoints.Value > 0 Then
                    bonusaPunkti += visitService.BonusPoints.Value
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
        Next
        txtPresentCard.Text = davanuKartes

        ''abonementi
        Dim abonementi As Decimal
        abonementi = 0
        Dim abo As Entities(Of Subscription)
        abo = Entities(Of Subscription).GetAll(Session, New Between("PayTime", dtpFrom.EditValue, CType(dtpTo.EditValue, DateTime).AddSeconds((-1))), New IsNull("DeleteTime"))
        For Each payment As Subscription In abo
            abonementi += payment.Price
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
            End If
        Next
        txtTransfer.Text = transfer

        txtSummary.Text = skaidraNauda + apdrosinasana + bonusaPunkti + programmas + davanuKartes + abonementi + pak + transfer
    End Sub
End Class
