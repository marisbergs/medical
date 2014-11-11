Imports Core
Imports Entities
Imports Core.Bll
Imports Core.Dal

Public Class frmClientGrouping

    Private Sub btnAverageSumm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverageSumm.Click
        Dim border As SystemParameter = Session.Get(Of SystemParameter)("BORDER_SUMM_VALUE")
        Dim t As Integer
        If (Integer.TryParse(txtBorderSumm.Value, t)) Then
            border.Value = t
            Session.SaveOrUpdate(border)
            Session.Commit()
        Else
            Core.UI.MsgBox.Show("Kļūda robežvērtibas konvertēšanā uz ciparu.")
            Return
        End If
        Dim cmd As New SqlClient.SqlCommand("PreMedic.dbo.CalcTotalSumm", New SqlClient.SqlConnection(Session.Connection.ConnectionString))
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        cmd.Dispose()
        RefreshCalcData()
    End Sub

    Private Sub frmClientGrouping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshCalcData()
        TextBox1.DataBindings.Add("Text", txtBorderSumm, "Value", True, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    Private Sub RefreshCalcData()
        Dim border As SystemParameter = Session.Get(Of SystemParameter)("BORDER_SUMM_VALUE")
        Session.Refresh(border)
        Dim t As Integer
        If (Integer.TryParse(border.Value, t)) Then
            txtBorderSumm.Text = t
        Else
            txtBorderSumm.Text = 0
        End If

        t = 0
        Dim count As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_COUNT")
        Session.Refresh(count)
        If (Integer.TryParse(count.Value, t)) Then
            txtTotalCount.Text = t
        Else
            txtTotalCount.Text = 0
        End If

        Dim sum As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD")
        Session.Refresh(sum)
        Dim r As Decimal = 0
        If (Decimal.TryParse(sum.Value.Replace(".", ","), r)) Then
            txtTotalSumm.Text = r
        Else
            txtTotalSumm.Text = 0
        End If

        If t > 0 AndAlso r > 0 Then
            txtAverage.Text = Decimal.Round(r / t, 2)
        Else
            txtAverage.Text = 0
        End If

        Dim AborderPercentage As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD_A_BORDER_PERCENTAGE")
        Session.Refresh(AborderPercentage)
        Dim r1 As Integer = 0
        If (Integer.TryParse(AborderPercentage.Value, r1)) Then
            txtAborderPercentage.Text = r1
        Else
            txtAborderPercentage.Text = 50
        End If

        Dim BborderPcentage As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD_B_BORDER_PERCENTAGE")
        Session.Refresh(BborderPcentage)
        r1 = 0
        If (Integer.TryParse(BborderPcentage.Value, r1)) Then
            txtBborderPercentage.Text = r1
        Else
            txtBborderPercentage.Text = 80
        End If

        Dim AborderValue As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD_A_BORDER_VALUE")
        Session.Refresh(AborderValue)
        r = 0
        If (Decimal.TryParse(AborderValue.Value.Replace(".", ","), r)) Then
            txtAborderSumm.Text = r
        Else
            txtAborderSumm.Text = 0
        End If

        Dim BborderValue As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD_B_BORDER_VALUE")
        Session.Refresh(BborderValue)
        r = 0
        If (Decimal.TryParse(BborderValue.Value.Replace(".", ","), r)) Then
            txtBborderSumm.Text = r
        Else
            txtBborderSumm.Text = 0
        End If

        Dim PercentageOrValueUsage As SystemParameter = Session.Get(Of SystemParameter)("PERCENTAGE_OR_VALUE_USAGE")
        Session.Refresh(PercentageOrValueUsage)
        r1 = 0
        If BborderPcentage.Value = "1" Then
            rbtUsePercentage.Checked = True
        Else
            rbtUseValue.Checked = True
        End If
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim sum As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD")
        Session.Refresh(sum)
        Dim totalSumm As Decimal = 0
        If Not (Decimal.TryParse(sum.Value.Replace(".", ","), totalSumm)) Then
            Core.UI.MsgBox.Show("Neizdevās nolasīt kopējo ienākumu summu")
            Return
        End If


        Dim count As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_COUNT")
        Session.Refresh(count)
        Dim t As Integer = 0
        If (Integer.TryParse(count.Value, t)) Then
            txtTotalCount.Text = t
        Else
            txtTotalCount.Text = 0
        End If


        Dim AborderValue As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD_A_BORDER_VALUE")
        Session.Refresh(AborderValue)
        AborderValue.Value = txtAborderSumm.Value.ToString()
        Session.SaveOrUpdate(AborderValue)

        Dim BborderValue As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD_B_BORDER_VALUE")
        Session.Refresh(BborderValue)
        BborderValue.Value = txtBborderSumm.Value.ToString()
        Session.SaveOrUpdate(BborderValue)

        Dim AborderPercentage As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD_A_BORDER_PERCENTAGE")
        Session.Refresh(AborderPercentage)
        AborderPercentage.Value = txtAborderPercentage.Value.ToString()
        Session.SaveOrUpdate(AborderPercentage)

        Dim BborderPcentage As SystemParameter = Session.Get(Of SystemParameter)("TOTAL_CLIENT_PAYD_B_BORDER_PERCENTAGE")
        Session.Refresh(BborderPcentage)
        BborderPcentage.Value = txtBborderPercentage.Value.ToString()
        Session.SaveOrUpdate(BborderPcentage)

        Dim PercentageOrValueUsage As SystemParameter = Session.Get(Of SystemParameter)("PERCENTAGE_OR_VALUE_USAGE")
        Session.Refresh(PercentageOrValueUsage)

        Dim cmd As New SqlClient.SqlCommand("PreMedic.dbo.ReadClientSumm", New SqlClient.SqlConnection(Session.Connection.ConnectionString))
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If
        Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader()
        Dim summa As Decimal = 0
        Dim counter As Integer = 0
        If rbtUsePercentage.Checked Then
            PercentageOrValueUsage.Value = 1
        Else
            PercentageOrValueUsage.Value = 0
        End If
        Session.SaveOrUpdate(PercentageOrValueUsage)
        Session.Commit()
        Dim reachB As Boolean = False
        Dim reachC As Boolean = False
        While reader.Read()
            counter += 1
            If rbtUsePercentage.Checked Then
                Dim s As Decimal = Decimal.Parse(reader.Item("summa").ToString().Replace(".", ","))
                Dim id As Guid = New Guid(reader.Item("PAT_ID").ToString())
                Dim dat As DateTime = DateTime.Parse(reader.Item("lastVisit").ToString())
                Dim pat As Patient = Session.Get(Of Patient)(id)
                summa = summa + s
                If (summa) <= ((totalSumm * txtAborderPercentage.Value) / 100) Then
                    pat.IncomeGroup = "A"
                ElseIf (summa) <= ((totalSumm * txtBborderPercentage.Value) / 100) Then
                    pat.IncomeGroup = "B"
                    If Not reachB Then
                        reachB = True
                        AborderValue.Value = s
                        txtAborderSumm.Value = s
                        Session.SaveOrUpdate(AborderValue)
                    End If
                Else
                    pat.IncomeGroup = "C"
                    If Not reachC Then
                        reachC = True
                        BborderValue.Value = s
                        txtBborderSumm.Value = s
                        Session.SaveOrUpdate(BborderValue)
                    End If
                End If
                SetLastVisitGroup(pat, dat)
                Session.SaveOrUpdate(pat)
                Session.Commit()
                btnCalc.Text = "Pārrēķināti " & counter & " no " & t
                Application.DoEvents()
            Else
                Dim s As Decimal = Decimal.Parse(reader.Item("summa").ToString().Replace(".", ","))
                Dim id As Guid = New Guid(reader.Item("PAT_ID").ToString())
                If (reader.Item("lastVisit").ToString() = "") Then
                    Continue While
                End If
                Dim dat As DateTime = DateTime.Parse(reader.Item("lastVisit").ToString())
                Dim pat As Patient = Session.Get(Of Patient)(id)
                summa = summa + s
                If (s) >= txtAborderSumm.Value Then
                    pat.IncomeGroup = "A"
                ElseIf (s) >= txtBborderSumm.Value Then
                    pat.IncomeGroup = "B"
                    If Not reachB Then
                        reachB = True
                        AborderPercentage.Value = Decimal.Round(Convert.ToDecimal((summa * 100) / totalSumm), 0)
                        txtAborderPercentage.Value = AborderPercentage.Value
                        Session.SaveOrUpdate(AborderPercentage)
                    End If
                Else
                    pat.IncomeGroup = "C"
                    If Not reachC Then
                        reachC = True
                        BborderPcentage.Value = Decimal.Round(Convert.ToDecimal((summa * 100) / totalSumm), 0)
                        txtBborderPercentage.Value = BborderPcentage.Value
                        Session.SaveOrUpdate(BborderPcentage)
                    End If
                End If
                SetLastVisitGroup(pat, dat)
                Session.SaveOrUpdate(pat)
                Session.Commit()
                btnCalc.Text = "Pārrēķināti " & counter & " no " & t
                Application.DoEvents()
            End If
        End While
        reader.Close()
        cmd.Connection.Close()
        cmd.Dispose()
        Core.UI.MsgBox.Show("Pārrēķins pabeigts veiksmīgi")
    End Sub

    Private Sub SetLastVisitGroup(ByVal pat As Patient, ByVal dat As DateTime)
        If (DateDiff(DateInterval.Month, dat, Now) <= 12) Then
            pat.Lastvisitgroup = 0
        ElseIf (DateDiff(DateInterval.Month, dat, Now) <= 24) Then
            pat.Lastvisitgroup = 1
        Else
            pat.Lastvisitgroup = 2
        End If
    End Sub
End Class
